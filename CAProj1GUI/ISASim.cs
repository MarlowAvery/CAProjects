using System;
using System.Collections.Generic;
using System.Linq;

namespace CAProj1
{
    class ISASimulator
    {
        //main entry point
        public static string ISASim(String path)
        {
            List<Instruction> commands = new List<Instruction>(); 
            Instruction myCommand;
            byte pCount = 0000;
            String output = "";
            String header = "COUNT\tSPEC\t\tINST\t\tOP";
            string instructions = System.IO.File.ReadAllText(@path);
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
            output += header;
            for(int i = 0; i< commands.Count;i++)
            {

                output+="\n"+String.Format("{0:X}",pCount)+"\t"+commands[i].Verbose();
                pCount += 3;
            }
            return output;
        }
    }
}
