using CF_Bookstore.Entities.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Primary keys -- Birincil Anahtarlarımız

            modelBuilder.Entity<Book>().HasKey(q => q.BookId);
            modelBuilder.Entity<Author>().HasKey(q => q.AuthorId);
            modelBuilder.Entity<BookAuthor>().HasKey(ba => new { ba.AuthorId, ba.BookId });
            //Relationships -- Tablolar arasındaki ilişkiler
            modelBuilder.Entity<BookAuthor>().HasRequired(t => t.Book).WithMany(t => t.BookAuthors).HasForeignKey(t => t.BookId);
            modelBuilder.Entity<BookAuthor>().HasRequired(t => t.Author).WithMany(t => t.BookAuthors).HasForeignKey(t => t.AuthorId);

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
    }
}
