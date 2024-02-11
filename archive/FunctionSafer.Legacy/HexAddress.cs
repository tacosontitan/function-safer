using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Safer_v2 {
class HexAddress {
    public string Address { get; private set; }

    public HexAddress(string Address) {
        while (Address.Length < 8)
            Address = "0" + Address;

        if (!Illegals.CheckForIllegals(Address))
            this.Address = Illegals.ReplaceWriteMode(Address);

        else
            this.Address = "00000000";
    }

    public string BytesFromTop(HexAddress FunctionTop) { return (this - FunctionTop).ToString(); }

    public override string ToString() {
        return Address;
    }

    public static HexAddress operator -(HexAddress Operand1, HexAddress Operand2) {
        HexAddress temp = new HexAddress((Math.ToDecimal(Operand1.Address) - Math.ToDecimal(Operand2.Address)).ToString("x"));
        return temp;
    }

    public static HexAddress operator +(HexAddress Operand1, HexAddress Operand2) {
        HexAddress temp = new HexAddress((Math.ToDecimal(Operand1.Address) + Math.ToDecimal(Operand2.Address)).ToString("x"));
        return temp;
    }
}
}