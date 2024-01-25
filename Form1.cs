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
        static List<Book> listedBooks = new List<Book>();
        static int selectedRow = 0;
        static BindingSource source = new BindingSource();
        static Book currentSelectedBook;
        static string searchPlaceholder = "Keresés...";
        static TabPage modifyTab;

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();

            List<string> booksCsv = File.ReadAllLines("books.csv").ToList();

            foreach (string line in booksCsv)
            {
                string[] splitLine = line.Split(';');

                books.Add(new Book(splitLine[0], splitLine[2], splitLine[1], Convert.ToInt32(splitLine[3])));
            }

            searchBar.Text = searchPlaceholder;

            modifyTab = tabControl.TabPages[2];
            tabControl.TabPages.Remove(modifyBook_tab);
            tabControl.Deselecting += new TabControlCancelEventHandler(tabControlDeselect);

            listedBooks = books;

            source.DataSource = listedBooks;
            bookListDataGridView.DataSource = source;
        }

        private void SelectBookRow()
        {
            tabControl.TabPages.Add(modifyTab);
            tabControl.SelectTab(modifyBook_tab);

            string currentAuthor = bookListDataGridView.Rows[selectedRow].Cells[1].Value.ToString();
            string currentGenre = bookListDataGridView.Rows[selectedRow].Cells[3].Value.ToString();
            string currentTitle = bookListDataGridView.Rows[selectedRow].Cells[2].Value.ToString();
            string currentPages = bookListDataGridView.Rows[selectedRow].Cells[4].Value.ToString();

            currentSelectedBook = books.Where(x => x.Author == currentAuthor).Where(y => y.Genre == currentGenre)
                 .Where(z => z.Title == currentTitle).Where(e => e.Pages == Convert.ToInt32(currentPages))
                 .FirstOrDefault();

            textBoxAuthorOp.Text = currentSelectedBook.Author;
            textBoxGenreOp.Text = currentSelectedBook.Genre;
            textBoxTitleOp.Text = currentSelectedBook.Title;
            textBoxPagesOp.Text = currentSelectedBook.Pages.ToString();
        }

        private void bookListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                selectedRow = e.RowIndex;
                SelectBookRow();
            }
        }

        private void tabControlDeselect(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == modifyBook_tab)
            {
                tabControl.TabPages.Remove(modifyBook_tab);
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            books.Add(new Book(textBoxAuthor.Text, textBoxGenre.Text, textBoxTitle.Text, Convert.ToInt32(textBoxPages.Text)));
            source.ResetBindings(true);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            books.RemoveAt(books.IndexOf(currentSelectedBook));
            source.ResetBindings(true);

            tabControl.TabPages.Remove(modifyBook_tab);
            tabControl.SelectTab(bookList_tab);
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            currentSelectedBook.Author = textBoxAuthorOp.Text;
            currentSelectedBook.Genre = textBoxGenreOp.Text;
            currentSelectedBook.Title = textBoxTitleOp.Text;
            currentSelectedBook.Pages = Convert.ToInt32(textBoxPagesOp.Text);

            source.ResetBindings(true);

            tabControl.TabPages.Remove(modifyBook_tab);
            tabControl.SelectTab(bookList_tab);
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            if (searchBar.Text != searchPlaceholder)
            {
                string currentSearch = searchBar.Text.ToLower();

                Console.WriteLine(currentSearch);

                if (currentSearch == "")
                {
                    listedBooks = books;
                }
                else
                {
                    listedBooks = books.Where(x =>
                        String.Concat(x.Author, x.Genre, x.Title).ToLower().Contains(currentSearch)
                    ).ToList();
                }

                source.DataSource = listedBooks;
                source.ResetBindings(true);
            }
        }

        private void searchBar_Enter(object sender, EventArgs e)
        {
            if (searchBar.Text == searchPlaceholder)
            {
                searchBar.Text = "";
            }
        }

        private void searchBar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBar.Text))
            {
                searchBar.Text = searchPlaceholder;
            }
        }
    }
}
