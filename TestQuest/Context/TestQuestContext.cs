using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestQuest.Models;

namespace TestQuest.Context
{
    public class TestQuestContext : DbContext
    {
        //public TestQuestContext()
        //{

        //}
        public TestQuestContext(DbContextOptions<TestQuestContext> options)
            : base(options){}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employe>().HasKey(e => new { e.Name, e.LastName, e.FamilyName });
        //}

        public DbSet<Employe> Employes { get; set; }
        public DbSet<Letter> Letters { get; set; }
    }
}
