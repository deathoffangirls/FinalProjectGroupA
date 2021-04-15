using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectGroupA.Models
{
    public class Coach
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartDate { get; set; }
        public int Ranking { get; set; }
    }
}
