using Microsoft.EntityFrameworkCore;
using System.Collections;
using Patron_Model;
using System;

namespace Patron_Database
{
    public class Context : DbContext
    {
        public DbSet<Album> albums { get; set; }

        public Context()
        {
            
        }
        public string DbPath { get; } = "Database/db.sqlite";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}
