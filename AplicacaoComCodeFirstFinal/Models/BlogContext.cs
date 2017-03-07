using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AplicacaoComCodeFirstFinal.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("DefaultConnection")
        {
           
        }

        public static BlogContext Create()
        {
            return new BlogContext();
        }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Posts> Posts { get; set; }
    }
}