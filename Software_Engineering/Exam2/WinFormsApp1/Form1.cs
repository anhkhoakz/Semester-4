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


namespace WinFormsApp1
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
            l = new BUS_Project("", "", "", "", "");
            grd.DataSource = l.selectQuery();
        }

        private void ClearInputFields()
        {
            txtRD.Text = "";
            txtBID.Text = "";
            ngayMuon.Text = "";
            ngayTRA.Text = "";
        }

        private void bADD_Click(object sender, EventArgs e)
        {
            if (dk == 0)
            {
                l = new BUS_Project("", txtRD.Text, txtBID.Text, ngayMuon.Text, ngayTRA.Text);
                l.addQuery();
                grd.DataSource = l.selectQuery();
                ClearInputFields();
            }
            else
            {
                l = new BUS_Project(txtRD.Text, txtBID.Text, ngayMuon.Text, ngayTRA.Text);
                l.updateQuery();
                grd.DataSource = l.selectQuery();
                ClearInputFields();
                dk = 0;
            }
        }

        private void bBORROW_Click(object sender, EventArgs e)
        {
            dk = 1;
            txtRD.Text = grd.CurrentRow.Cells[1].Value.ToString();
            txtBID.Text = grd.CurrentRow.Cells[2].Value.ToString();
            ngayMuon.Text = grd.CurrentRow.Cells[4].Value.ToString();
            ngayTRA.Text = grd.CurrentRow.Cells[5].Value.ToString();
        }

        private void bSHOW_Click(object sender, EventArgs e)
        {
            grd.DataSource = l.selectQuery();
        }

        private void bTICKET_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
            doc.Open();
            Paragraph p = new Paragraph("Ticket");
            doc.Add(p);
            doc.Close();
            MessageBox.Show("Ticket saved to " + path);
        }
    }
}
