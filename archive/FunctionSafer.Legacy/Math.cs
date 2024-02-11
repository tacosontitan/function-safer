using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Safer_v2 {
    public class Math {
        public static string ToHex(int NumberToConvert) { return NumberToConvert.ToString("x"); }
        public static int ToDecimal(string Address) { return Convert.ToInt32(Address, 16); }
    }
}