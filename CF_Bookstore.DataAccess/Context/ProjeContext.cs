using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF_Bookstore.DataAccess.Context
{
    public class ProjeContext : DbContext
    {
        public ProjeContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=CF_Bookstore; Integrated Security=True;";
        }
    }
}
