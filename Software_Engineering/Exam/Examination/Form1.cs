using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Security.Policy;
using DAL;

namespace Examination
{
    public partial class Form1 : Form
    {
        BUS_Project l;
        int dk = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l = new BUS_Project("", "", "", 0);
            grd.DataSource = l.selectQuery();
        }

        private void ClearInputFields()
        {
            txtBID.Text = "";
            txtBN.Text = "";
            txtAN.Text = "";
            txtQT.Text = "";
        }


        private void bAdd_Click(object sender, EventArgs e)
        {
            dk = 1;
            ClearInputFields();
            txtBID.Text = l.getmasach();
        }

        private void bEDIT_Click(object sender, EventArgs e)
        {
            dk = 2;
        }

        private void bDELETE_Click(object sender, EventArgs e)
        {
            string masach = txtBID.Text;
            l = new BUS_Project(masach, "", "", 0);
            l.deleteQuery();

            grd.DataSource = l.selectQuery();
        }

        private void bSAVE_Click(object sender, EventArgs e)
        {
            string s = "";
            if (dk == 1)
            {
                l = new BUS_Project(txtBID.Text, txtBN.Text, txtAN.Text, int.Parse(txtQT.Text));
                l.addQuery();
            }
            else if (dk == 2)
            {
                l = new BUS_Project(txtBID.Text, txtBN.Text, txtAN.Text, int.Parse(txtQT.Text));
                l.updateQuery();
            }
            grd.DataSource = l.selectQuery();
        }

        private void bCANCEL_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            bEDIT.Enabled = false;
        }

        private void bPDF_Click(object sender, EventArgs e)
        {
            if (grd.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Danhsach.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(grd.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in grd.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }


                            for (int i = 0; i < grd.Rows.Count - 1; ++i)
                            {
                                for (int j = 0; j < grd.Columns.Count; ++j)
                                {

                                    pdfTable.AddCell(grd.Rows[i].Cells[j].Value.ToString());

                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void bSEARCH_Click(object sender, EventArgs e)
        {
            string searchText = txtSEARCH.Text.Trim();

            try
            {
                string searchQuery = "SELECT * FROM Sach WHERE masach LIKE @SearchText OR tensach LIKE @SearchText OR tacgia LIKE @SearchText";
                SqlParameter[] parameters = { new SqlParameter("@SearchText", "%" + searchText + "%") };

                DataTable searchResults = Connection.selectQuery(searchQuery, parameters);

                grd.DataSource = searchResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching for projects: " + ex.Message, "Error");
            }

        }

        private void grd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grd_Click(object sender, EventArgs e)
        {
            txtBID.Text = grd.CurrentRow.Cells[0].Value.ToString();
            txtBN.Text = grd.CurrentRow.Cells[1].Value.ToString();
            txtAN.Text = grd.CurrentRow.Cells[2].Value.ToString();
            txtQT.Text = grd.CurrentRow.Cells[3].Value.ToString();

            bEDIT.Enabled = true;
        }
    }
}
