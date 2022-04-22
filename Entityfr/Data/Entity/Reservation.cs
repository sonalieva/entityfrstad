using System;
using System.Collections.Generic;
using System.Text;

namespace Entityfr.Data.Entity
{
    public class Reservation
    {

        public int Id { get; set; }
        public int Stadionid { get; set; }
        public int Userid { get; set; }
        public Stadion Stadion { get; set; }
        public User user { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
