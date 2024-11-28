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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;

namespace DigitalLibrary
{
    public partial class Form3 : Form
    {
        private DataTable stdDataTable = new DataTable();

        public Form3()
        {
            InitializeComponent();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            stdDataTable.Columns.Add("Title", typeof(string));
            stdDataTable.Columns.Add("Author", typeof(string));
            stdDataTable.Columns.Add("Genre", typeof(string));
            stdDataTable.Columns.Add("Status", typeof(string));

         

            dataGridView1.DataSource = stdDataTable;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns["Title"].ReadOnly = true;
            dataGridView1.Columns["Author"].ReadOnly = true;
            dataGridView1.Columns["Genre"].ReadOnly = true;
            LoadBooksIntoTable();

            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
        }
        private void LoadBooksIntoTable()
        {
            stdDataTable.Clear();
            if (File.Exists("books.txt"))
            {
                string[] lines = File.ReadAllLines("books.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 4)
                    {
                        stdDataTable.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                    }
                }
            }
            
        }
        
        private void search_TextChanged(object sender, EventArgs e)
        {
            string searchText = search.Text.ToLower();
            string filter = $"Title LIKE '%{searchText}%' OR " +
                            $"Author LIKE '%{searchText}%' OR " +
                            $"Genre LIKE '%{searchText}%' OR " +
                            $"Status LIKE '%{searchText}%'";
            stdDataTable.DefaultView.RowFilter = filter;
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Status"].Index && e.RowIndex >= 0)
            {
                string title = dataGridView1.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                string author = dataGridView1.Rows[e.RowIndex].Cells["Author"].Value.ToString();
                string genre = dataGridView1.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                string status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

               
                UpdateBookInFile(title, author, genre, status);
            }
        }

       
        private void UpdateBookInFile(string title, string author, string genre, string status)
        {
        
            string[] lines = File.ReadAllLines("books.txt");
            List<string> updatedLines = new List<string>();

         
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length == 4 && parts[0] == title && parts[1] == author && parts[2] == genre)
                {
               
                    updatedLines.Add($"{title};{author};{genre};{status}");
                }
                else
                {
                 
                    updatedLines.Add(line);
                }
            }

        
            File.WriteAllLines("books.txt", updatedLines);
        }
    }
}
