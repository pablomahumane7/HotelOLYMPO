using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HotelOLYMPO.Models;

namespace HotelOLYMPO.Data
{
    public class HotelOLYMPOContext : DbContext
    {
        public HotelOLYMPOContext (DbContextOptions<HotelOLYMPOContext> options)
            : base(options)
        {
        }

        public DbSet<HotelOLYMPO.Models.Reserva> Reserva { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AH919IS;Initial Catalog=hotelOlympo;Integrated Security=True");
        }

        public DbSet<HotelOLYMPO.Models.Quartos> Quartos { get; set; }
    }
}
