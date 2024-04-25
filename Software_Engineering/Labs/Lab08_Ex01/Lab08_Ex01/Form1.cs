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

namespace Lab08_Ex01
{
    public partial class Form1 : Form
    { 
        BUS_Student l;
        int dk = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            l = new BUS_Student("", "", "", "", 0);
            grd.DataSource = l.selectQuery();
        }
    }
}
