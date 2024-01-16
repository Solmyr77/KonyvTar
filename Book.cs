using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        private string author;
        private string genre;
        private string title;
        private int pages;

        public Book(string title, string author, string genre, string pages)
        {
            this.Author = author;
            this.Genre = genre;
            this.Title = title;
            this.Pages = Convert.ToInt32(pages);
        }

        public string Author { get => author; set => author = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Title { get => title; set => title = value; }
        public int Pages { get => pages; set => pages = value; }
    }
}
