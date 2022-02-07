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
            String p1 = Command.ToString();
            String p2 = OffsetH.ToString()+OffsetL.ToString();
            String p3 = Dissembler.MatchKey(Command);
            result = p1+"\t"+p3+"\t"+p2;
            return result;
        }
    }
}
