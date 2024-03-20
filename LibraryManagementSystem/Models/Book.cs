using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublicationYear { get; set; }
        public bool IsCheckedOut { get; set; }

        public override string ToString()
        {
            return $"ID: {Id},Title: {Title}, Author: {Author}, Genre: {Genre}, Publication Year: {PublicationYear}, IsCheckedOut: {IsCheckedOut}";
        }
    }
}
