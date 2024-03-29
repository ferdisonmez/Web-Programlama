﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaV2_Net5._0.Models
{
    public class Context: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-A2K7DC0; database=projectDB; integrated security=true;");

        }
        // Entities        
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Isilani> isilanlari { get; set; }
        public DbSet<Patron> patronlar { get; set; }
        public DbSet<Yazilimci> yazilimcilar { get; set; }
        public DbSet<Basvuru> Basvurular { get; set; }


    }
}
