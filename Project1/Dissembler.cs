using System;
using System.Collections.Generic;

namespace CAProj1
{

    class Dissembler
    {
        Dictionary<byte, string> _instructions = new Dictionary<byte, string>
            {
                { 0xC0, "LWD" },
                { 0x24, "CALL" },
                { 0xE9, "STWX" },
                { 0xE2, "STWA" },
                { 0x62, "ADDA" },
                { 0x49, "STRO" },
                { 0x00, "STOP" }
            };
        public string MatchKey(byte key)
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
