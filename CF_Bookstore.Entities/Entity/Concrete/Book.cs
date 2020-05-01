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
    [Table("Books")]
    public class Book : BaseEntity
    {
        [Key, Column(Order = 0)]
        int BookId { get; set; }
        string Title { get; set; }
        int? TotalPage { get; set; }
        decimal? rating { get; set; }

        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        //override ToString
        public override string ToString()
        {
            return Title;
        }
    }
}
