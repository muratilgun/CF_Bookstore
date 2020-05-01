using CF_Bookstore.Entities.Entity.Concrete.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF_Bookstore.Entities.Entity.Concrete
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int? TotalPages { get; set; }
        public decimal? Rating { get; set; }
        public int ISBN { get; set; }

        public IList<BookAuthor> BookAuthors { get; set; }
        public override string ToString()
        {
            return Title;
        }


    }
}
