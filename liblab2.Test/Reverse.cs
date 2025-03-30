using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liblab2.Test
{
    public class Reverse
    {
        public string rev(string str)
        {
            string rts = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rts = rts + str[i];
            }
            return rts;
        }
    }
}
