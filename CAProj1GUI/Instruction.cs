using System;
using System.Collections.Generic;
using System.Text;

namespace CAProj1
{
    public struct Instruction
    {
        public Instruction(byte command, byte offsetH, byte offsetL)
        {
            Command = command;
            OffsetH = offsetH;
            OffsetL = offsetL;
        }
        public byte Command { get; set; }
        public byte OffsetH { get; set; }
        public byte OffsetL { get; set; }
        public string Verbose()
        {
            String result;
            String p1 = String.Format("{0:X}", Command);
            String p2 = String.Format("{0:X}", OffsetH) + String.Format("{0:X}", OffsetL);
            String p3 = Dissembler.MatchKey(Command);
            result = "\t"+p1+"\t\t"+p3+"\t\t"+p2;
            return result;
        }
    }
}
