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
using System.Runtime.InteropServices;

namespace Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        static List<Book> books = new List<Book>();
        static int selectedRow = 0;
        static BindingSource source = new BindingSource();

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();

            List<string> booksCsv = File.ReadAllLines("books.csv").ToList();

            foreach (string line in booksCsv)
            {
                string[] splitLine = line.Split(';');

                books.Add(new Book(splitLine[0], splitLine[1], splitLine[2], Convert.ToInt32(splitLine[3])));
            }

            source.DataSource = books;
            bookListDataGridView.DataSource = source;
        }

        private void bookListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                selectedRow = e.RowIndex;
                tabControl.SelectTab(modifyBook_tab);
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            books.Add(new Book(textBoxAuthor.Text, textBoxGenre.Text, textBoxTitle.Text, Convert.ToInt32(textBoxPages.Text)));
            source.ResetBindings(true);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string currentAuthor = bookListDataGridView.Rows[selectedRow].Cells[1].Value.ToString();
            string currentGenre = bookListDataGridView.Rows[selectedRow].Cells[2].Value.ToString();
            string currentTitle = bookListDataGridView.Rows[selectedRow].Cells[3].Value.ToString();
            string currentPages = bookListDataGridView.Rows[selectedRow].Cells[4].Value.ToString();

            Book currentBook = books.Where(x => x.Author == currentAuthor).Where(y => y.Genre == currentGenre)
                 .Where(z => z.Title == currentTitle).Where(e => e.Pages == Convert.ToInt32(currentPages))
                .FirstOrDefault();

            books.RemoveAt(books.IndexOf(currentBook));
            source.ResetBindings(true);

            tabControl.SelectTab(bookList_tab);
        }
    }
}
