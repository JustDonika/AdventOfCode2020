using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2020.Entities
{
    public abstract class Day
    {
        static bool RunPart1;
        static bool RunPart2;

        public Day(bool runPart1, bool runPart2)
        {
            RunPart1 = runPart1;
            RunPart2 = runPart2;
        }
        static void ExecutePart1() {
            Console.WriteLine("Part 1 Not Overwritten");
        }
        static void ExecutePart2() {
            Console.WriteLine("Part 2 Not Overwritten");
        }
        public void Run()
        {
            if (RunPart1)
            {
                Console.WriteLine("Executing Part One: ");
                ExecutePart1();
                Console.WriteLine("________PART ONE CONCLUDED____________");
            }
            if (RunPart2)
            {
                Console.WriteLine("Executing Part Two: ");
                ExecutePart2();
                Console.WriteLine("________PART TWO CONCLUDED____________");
            }
        }
    }
}
