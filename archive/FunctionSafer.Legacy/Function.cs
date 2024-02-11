using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function_Safer_v2 {
    class Function {
        public string Name { get; private set; }

        public HexAddress TopAddress { get; private set; }
        public HexAddress JrRaPlus8 { get; private set; }

        public string Bytes { get { return Math.ToHex(Math.ToDecimal(JrRaPlus8.Address) - Math.ToDecimal(TopAddress.Address)); } }

        public List<HexAddress> Codes { get; private set; }

        public Function(string Name, HexAddress FunctionTop, HexAddress JrRaPlus8, ListBox Container) {
            if (Name == "" || Name == " ")
                this.Name = String.Format("Untitled {0}", Container.Items.Count + 1);

            else
                this.Name = Name;

            this.TopAddress = FunctionTop;
            this.JrRaPlus8 = JrRaPlus8;

            this.Codes = new List<HexAddress>();

            Container.Items.Add(this.Name);
        }

        public override string ToString() {
            return "Function Top: " + TopAddress.ToString() + "\n" + "Jr Ra + 8: " + JrRaPlus8.ToString() + "\n" + "Bytes: " + Bytes;
        }

        public void AddCode(HexAddress CodeAddress) {
            this.Codes.Add(CodeAddress);
        }
    }
}