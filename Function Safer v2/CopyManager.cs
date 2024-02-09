using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Safer_v2 {
    class CopyManager {
        public List<string> Stack { get; private set; }
        public List<string> Codes { get; private set; }

        public string Result {
            get {
                string temp = "Stack\n";

                for (int i = 0; i < Stack.Count; i++)
                    temp += Stack[i] + "\n";

                temp += "\nCodes\n";

                for (int i = 0; i < Codes.Count; i++)
                    temp += Codes[i] + "\n";

                return temp;
            }
        }

        private List<Function> Functions;

        public CopyManager(List<Function> Functions) {
            this.Functions = Functions;

            this.Stack = new List<string>();
            this.Codes = new List<string>();
        }

        public void Copy() {
            HexAddress NewAddress = new HexAddress("000a0000");

            for (int f = 0; f < Functions.Count; f++) {
                NewAddress += new HexAddress("00001000");
                HexAddress TempBytes = new HexAddress(Functions[f].Bytes);

                HexAddress Temp = new HexAddress("00000000") + TempBytes;

                string NewStack = "5" + Functions[f].TopAddress.Address.Remove(0, 1) + " " + Temp;
                NewStack += "\n" + NewAddress.Address + " 00000000";
                Stack.Add(NewStack);

                for (int c = 0; c < Functions[f].Codes.Count; c++) {
                    TempBytes = new HexAddress(Functions[f].Codes[c].BytesFromTop(Functions[f].TopAddress));
                    Temp = NewAddress + TempBytes;
                    Codes.Add(Temp.Address + " 00000000");
                }
            }
        }
    }
}