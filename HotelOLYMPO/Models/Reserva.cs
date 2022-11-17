using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelOLYMPO.Models
{
    public class Reserva
    {
        public int ID { get; set; }
      
        public string Nome { get; set; }
        public string email { get; set; }
        public int Telefone { get; set; }
        public int NumeruQuarto { get; set; }
        public int NumeruAduto { get; set; }
        public string Checkin { get; set; }
        public string Checkout { get; set; }
        public string Ano { get; set; }
        public string Detalhes { get; set; }


    }
}
