using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2020.Days;
using AdventOfCode2020.Entities;

namespace AdventOfCode2020
{
    public class Instantiator
    {
        public static void Main(string[] args) 
        {
            Day currentDay = new Day1(true, false);
            currentDay.Run();
        }
    }
}
