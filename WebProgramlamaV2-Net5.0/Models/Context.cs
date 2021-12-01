using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaV2_Net5._0.Models
{
    public class Context: DbContext
    {
        // Entities        
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Isilani> isilanlari { get; set; }
        public DbSet<Patron> patronlar { get; set; }
        public DbSet<Yazilimci> yazilimcilar { get; set; }
    }
}
