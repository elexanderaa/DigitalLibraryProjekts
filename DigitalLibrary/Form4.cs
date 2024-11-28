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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Title";
            dataGridView1.Columns[1].Name = "Author";
            dataGridView1.Columns[2].Name = "Genre";

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;

            DataGridViewButtonColumn ButtonColumn = new DataGridViewButtonColumn();
            ButtonColumn.Text = "Move to main list";
            ButtonColumn.UseColumnTextForButtonValue = true;
            ButtonColumn.Visible = true;
            dataGridView1.Columns.Add(ButtonColumn);


            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LoadBooksIntoTable();

        }

        private void LoadBooksIntoTable()
        {
            dataGridView1.Rows.Clear();
            if (File.Exists("bookstobuy.txt"))
            {
                string[] lines = File.ReadAllLines("bookstobuy.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 4)
                    {
                        dataGridView1.Rows.Add(parts[0], parts[1], parts[2]);
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[3].Index && e.RowIndex >= 0)
            {
                string title = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string author = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string genre = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string information = $"{title};{author};{genre};To Read{Environment.NewLine}";
                File.AppendAllText("books.txt", information);

                dataGridView1.Rows.RemoveAt(e.RowIndex);

                List<string> lines = File.ReadAllLines("bookstobuy.txt").ToList();

                lines.RemoveAll(line =>
                {
                    string[] parts = line.Split(';');
                    return parts.Length == 4 && parts[0] == title && parts[1] == author && parts[2] == genre;
                });


                File.WriteAllLines("bookstobuy.txt", lines.ToArray());

            }

        }
    }
}
