using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Birthday_Remainder_Backend.Models
{
    public class Birthdays
    {
        public int Id { get; set; }

        public string Names { get; set; } = " ";

        public int Age { get; set; }

        public byte[] Images { get; set; }

    }
}