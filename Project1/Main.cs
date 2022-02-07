using System;
using System.Collections.Generic;
using System.Linq;

namespace CAProj1
{
    class Program
    {
        //main entry point
        static void Main(string[] args)
        {
            var output = "";
            string instructions = System.IO.File.ReadAllText(@"hex.txt");
            String[] array = instructions.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);
            List<Byte> vals = array.Select(arg => Byte.Parse(arg.ToString(), System.Globalization.NumberStyles.HexNumber)).ToList();
            if(vals[0] == 0xC0)
            {
                output = Dissembler.MatchKey(vals[0]);
            }
            Console.WriteLine(instructions);
        }
    }
}
