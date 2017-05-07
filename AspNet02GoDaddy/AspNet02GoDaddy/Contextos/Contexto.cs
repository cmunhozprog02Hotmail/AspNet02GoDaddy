using AspNet02GoDaddy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNet02GoDaddy.Contextos
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DefaultConnection")
        {

        }

        public DbSet<teste> testes { get; set; }
    }
}