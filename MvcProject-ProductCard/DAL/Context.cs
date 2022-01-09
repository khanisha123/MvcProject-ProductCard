using Microsoft.EntityFrameworkCore;
using MvcProject_ProductCard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject_ProductCard.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
        public DbSet<Card> cards { get; set; }
        public DbSet<Images> Images { get; set; }

    }
}
