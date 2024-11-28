using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DigitalLibrary
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string author = authortype.Text.Trim();
            string title = titletype.Text.Trim();
            string genre = genretype.Text.Trim();
            string statu = status.Text.Trim();
            if (statu == "To buy")
            {
                if (File.Exists("bookstobuy.txt"))
                {
                    string[] lines = File.ReadAllLines("bookstobuy.txt");
                    foreach (string line in lines)
                    {
                        if (line.Contains($";{title};"))
                        {
                            MessageBox.Show("This book is already in the list!");
                            return;
                        }
                    }
                }
                string info1 = $"{title};{author};{genre};{statu}{Environment.NewLine}";
                File.AppendAllText("bookstobuy.txt", info1);
                MessageBox.Show("Book added successfully!");
                authortype.Text = "";
                titletype.Text = "";
                genretype.Text = "";
                status.Text = "";
            }
            else
            {
                if (File.Exists("books.txt"))
                {
                    string[] lines = File.ReadAllLines("books.txt");
                    foreach (string line in lines)
                    {
                        if (line.Contains($";{title};"))
                        {
                            MessageBox.Show("This book is already in the list!");
                            return;
                        }
                    }
                }
                string info = $"{title};{author};{genre};{statu}{Environment.NewLine}";
                File.AppendAllText("books.txt", info);
                MessageBox.Show("Book added successfully!");
                authortype.Text = "";
                titletype.Text = "";
                genretype.Text = "";
                status.Text = "";

            }

        }
    }
}
