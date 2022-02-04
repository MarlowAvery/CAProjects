using System;

namespace CAProj1
{
    class Program
    {
        //main entry point
        static void Main(string[] args)
        {
            string instructions = System.IO.File.ReadAllText(@"hex.txt");
            char[] chars = instructions.ToCharArray();  
            Console.WriteLine(instructions);
        }
    }
}
