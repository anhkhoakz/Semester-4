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


namespace Review
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int dk = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "server = 172.16.97.108; database = QuanLyThuVien; uid = SA; pwd = Gt24AUzfUpJZ2PKh6eZx";
            cn = new SqlConnection(s);
            cn.Open();
            formload();
        }

        void formload()
        {
            showGRD();
            enable(groupBox1, true);
            bXoa.Enabled = false;
            bSua.Enabled = false;
            bLuu.Enabled = false;
            dk = 0;
        }

        public void showGRD()
        {
            string sql = "select * from Sach";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            dataGridView1.DataSource = tb;
        }

        public void enable(GroupBox grp, bool b)
        {
            groupBox1.Enabled = b;
        }


        private void bThem_Click(object sender, EventArgs e)
        {
            enable(groupBox1, true);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


            textBox1.Focus();
            bLuu.Enabled = true;
            dk = 1;
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "delete from Sach where masach = '" + textBox1.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
                formload();
            }
        }

        private void bSua_Click(object sender, EventArgs e)
        {
            enable(groupBox1, true);
            textBox1.Enabled = false;
            textBox2.Focus();
            bLuu.Enabled = true;
            dk = 2;
        }

        private void bLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (dk == 1)//Add
            {
                //check primary key
                sql = "select * from Sach where masach = '" + textBox1.Text + "'";
                data = new SqlDataAdapter(sql, cn);
                tb = new DataTable();
                data.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    MessageBox.Show("Student exists");
                    textBox1.Focus();
                    return;
                }
                //Insert into
                sql = "insert into Sach values ('" + textBox1.Text + "', N'" + textBox2.Text + "', N'" + textBox3.Text + "', '" + textBox4.Text + "')";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            else //dk =2
            {
                //Update
                sql = "update Sach set masach = N'" + textBox1.Text + "', tensach = N'" + textBox2.Text + "', tacgia = '" + textBox3.Text + "', soluong = " + textBox4.Text + " where masach = '" + textBox1.Text + "'";
                cm = new SqlCommand(sql, cn);
                cm.ExecuteNonQuery();
            }
            formload();
        }

        private void bTim_Click(object sender, EventArgs e)
        {
            string sql = "select * from Sach where tensach = N'" + textBox2.Text + "'";
            data = new SqlDataAdapter(sql, cn);
            tb = new DataTable();
            data.Fill(tb);
            dataGridView1.DataSource = tb;

        }

        private void bPDF_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count - 1 > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
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
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            //add column
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            //add value
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                                {

                                    pdfTable.AddCell(dataGridView1.Rows[i].Cells[j].Value.ToString());

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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            bXoa.Enabled = true;
            bSua.Enabled = true;

        }
    }
}
