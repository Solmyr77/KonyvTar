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

namespace Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> booksCsv = File.ReadAllLines("books.csv").ToList();
            List<Book> books = new List<Book>();

            booksCsv.RemoveAt(0);

            foreach (string line in booksCsv)
            {
                string[] splitLine = line.Split(',');

                // nem jo a books csv
                books.Add(new Book(splitLine[0], splitLine[1], splitLine[2], splitLine[3]));
            }

            BindingSource binding = new BindingSource();
            binding.DataSource = books;

            bookListDataGridView.DataSource = binding;
        }
    }
}
