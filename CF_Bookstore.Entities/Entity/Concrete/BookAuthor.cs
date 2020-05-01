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
    [Table("BookAuthors")]
    public class BookAuthor
    {
        
        [Column(Order =1)]
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        [Column(Order = 2)]
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }
    }
}
