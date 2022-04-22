using Entityfr.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entityfr.Data.DAL
{
    class StadionDbContest:DbContext
    {

        public DbSet<Stadion> Stadions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BQU8U4V;Database=Enstadion;Trusted_Connection=TRUE");
        }
    }
}
