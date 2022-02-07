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
            List<Instruction> commands = new List<Instruction>(); 
            Instruction myCommand;
            string instructions = System.IO.File.ReadAllText(@"hex.txt");
            String[] array = instructions.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);
            List<Byte> vals = array.Select(arg => Byte.Parse(arg.ToString(), System.Globalization.NumberStyles.HexNumber)).ToList();
            for(int i = 0; i<vals.Count;i+=3)
            {
                if(vals[i]==0x00)
                {
                    myCommand = new Instruction(0x00, 0x00, 0x00);
                    commands.Add(myCommand);
                    break;
                }
                myCommand = new Instruction(vals[i], vals[i + 1], vals[i + 2]);
                commands.Add(myCommand);
                
            }
            for(int i = 0; i< commands.Count;i++)
            {
                Console.WriteLine(commands[i].Verbose());
            }
            Console.WriteLine(instructions);
        }
    }
}
