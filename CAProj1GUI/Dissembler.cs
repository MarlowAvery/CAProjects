using System;
using System.Collections.Generic;

namespace CAProj1
{

  public class Dissembler
    {
       static Dictionary<byte, string> _instructions = new Dictionary<byte, string>
            {
                { 0xC0, "LDWA" },
                { 0xC1,"LDBR"},
                 {0xE1,"STBW" },
                 { 0x3A, "DECO" },
                 { 0xD0, "SUBR" },
                 { 0xF1, "STBR" },
                { 0x24, "CALL" },
                { 0xE9, "STWX" },
                { 0xE2, "STWA" },
                { 0x62, "ADDA" },
                { 0x49, "STRO" },
                { 0x00, "STOP" }
            };
        public static string MatchKey(byte key)
        {
            string value = "";
            if(_instructions.ContainsKey(key))
            {
                _instructions.TryGetValue(key, out value);
            }
            return value;
           
        }

    
      




    }
}
