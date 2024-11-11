using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AdventOfCode2020.Entities.Enums;

namespace AdventOfCode2020.Components
{
    internal class TextReader
    {
        private string _fileName;
        private LowestLevel _lowestLevel;
        private string _delimiter;
        public TextReader(string fileName, LowestLevel lowestLevel, string delimiter = " ")
        {
            _fileName = fileName;
            _lowestLevel = lowestLevel;
            _delimiter = delimiter;
        }

        public List<List<String>> ReadEntries()
        {
            var returnable = new List<List<String>>();
            string line;
            try
            {
                StreamReader sr = new StreamReader(_fileName);

                line = sr.ReadLine();
                while (line != null) 
                {
                    returnable.Add(new List<String>());
                    if (_lowestLevel == LowestLevel.Char) 
                    {
                        while (line.Length > 0) {
                            returnable.ElementAt(-1).Add(line.ToCharArray()[0] + "");
                            line = line.Substring(1);
                        }
                    }
                    else if (_lowestLevel == LowestLevel.Word)
                    {
                        returnable.ElementAt(-1).AddRange(line.Split(_delimiter));
                    }
                    else
                    {
                        returnable.ElementAt(-1).Add(line);
                    }
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine("Error encountered while reading file at " + _fileName + ": " + e.ToString());
            }
            return returnable;
        }
    }
}
