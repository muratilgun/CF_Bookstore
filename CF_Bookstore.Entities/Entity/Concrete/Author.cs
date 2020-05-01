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
    [Table("Authors")]
    public class Author :BaseEntity
    {
        [Key, Column(Order = 0)]
        public int AuthorId { get; set; }
        public string FullName { get; set; }
    }
}
