using CF_Bookstore.Entities.Entity.Concrete.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CF_Bookstore.Entities.Entity.Abstraction
{
    public interface IKernelEntity
    {
        [Column(TypeName = "datetime2")]
        DateTime CreateDate { get; set; }
        [Column(TypeName = "datetime2")]
        DateTime? UpdateDate { get; set; }
        [Column(TypeName = "datetime2")]
        DateTime? DeleteDate { get; set; }
        Status Status { get; set; }
    }

}
