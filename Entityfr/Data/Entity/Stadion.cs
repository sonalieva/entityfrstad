using System;
using System.Collections.Generic;
using System.Text;
using Entityfr.Data.Entity;

namespace Entityfr.Data.Entity
{
    public class Stadion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hourlyprice { get; set; }
        public int Capacity { get; set; }
    }
}
