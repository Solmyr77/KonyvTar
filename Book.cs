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
        private string title;
        private string genre;
        private int pages;

        public Book(string author, string title, string genre, int pages)
        {
            this.Author = author;
            this.Genre = genre;
            this.Title = title;
            this.Pages = pages;
        }

        public string Author { get => author; set => author = value; }
        public string Title { get => title; set => title = value; }
        public string Genre { get => genre; set => genre = value; }
        public int Pages { get => pages; set => pages = value; }

        public override string ToString()
        {
            return $"{this.Author};{this.Genre};{this.Title};{this.Pages}";
        }
    }
}
