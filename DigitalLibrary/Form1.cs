using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addnew_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 addnew= new Form2();
            addnew.Show();
        }

        private void seeall_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 seeall = new Form3();
            seeall.Show();
        }

        private void tobuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 tobuy = new Form4();
            tobuy.Show();
        }
    }
}
