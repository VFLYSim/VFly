using ConvertByte;
using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VFly
{
    public class Controller_3_DO3 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = ALT1_B;
                Bit[1] = ALT1_A;
                Bit[2] = HDG_B;
                Bit[3] = HDG_A;
                Bit[4] = NAV2_B;
                Bit[5] = NAV2_A;
                Bit[6] = NAV1_B;
                Bit[7] = NAV1_A;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                ALT1_B = Bit[0];
                ALT1_A = Bit[1];
                HDG_B = Bit[2];
                HDG_A = Bit[3];
                NAV2_B = Bit[4];
                NAV2_A = Bit[5];
                NAV1_B = Bit[6];
                NAV1_A = Bit[7];
            }

        }

        #region Bits

        [Description("Potencjometr wewnętrzny Alt, połączony z ALT1_A, zmiana 00->11")]
        public bool ALT1_B;

        [Description("Potencjometr wewnętrzny Alt, połączony z ALT1_B, zmiana 00->11")]
        public bool ALT1_A;

        [Description("Potencjometr HDG, połączony z HDG_A, zmiana 00->11")]
        public bool HDG_B;

        [Description("Potencjometr HDG, połączony z HDG_B, zmiana 00->11")]
        public bool HDG_A;

        [Description("Potencjometr zewnętrzny Nav1-2, połączony z NAV2_A, zmiana 00->11")]
        public bool NAV2_B;

        [Description("Potencjometr zewnętrzny Nav1-2, połączony z NAV2_B, zmiana 00->11")]
        public bool NAV2_A;

        [Description("Potencjometr wewnętrzny Nav1-2, połączony z NAV1_A, zmiana 00->11")]
        public bool NAV1_B;

        [Description("Potencjometr wewnętrzny Nav1-2, połączony z NAV1_B, zmiana 00->11")]
        public bool NAV1_A;

        #endregion
    }
}
