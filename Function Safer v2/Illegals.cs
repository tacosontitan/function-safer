using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Safer_v2 {
    public class Illegals {
        public static char[] IllegalCharacters = new char[52] { 'G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X',
            'Y','Z','`','~','!','@','#','$','%','^','&','*','(',')','_','-','+','=','{','}','[',']','\\','/','|',':',';','\'','\"',',',
            '.','?','<','>'
        };

        public static bool CheckForIllegals(string Address) {
            for (int i = 0; i < 52; i++) {
                if (Address.Contains(IllegalCharacters[i])) {
                    return true;
                }
            }

            return false;
        }

        public static string ReplaceWriteMode(string Address) {
            return "0" + Address.Remove(0, 1);
        }
    }
}