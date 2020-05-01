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
    public class Author
    {
        public int AuthorId { get; set; }
        public string FullName { get; set; }
        public override string ToString()
        {
            return FullName;
        }
        public IList<BookAuthor> BookAuthors { get; set; }
    }

}
