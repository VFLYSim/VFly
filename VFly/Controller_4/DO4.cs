using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VFlyGit.Controller_4;
using VFlyGit.Controller_4.Interfaces;

namespace VFly
{
    public class DO4 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = EmptyBit1;
                Bit[1] = EmptyBit2;
                Bit[2] = FUEL_SELECTOR_RIGHT_3;
                Bit[3] = FUEL_SELECTOR_RIGHT_2;
                Bit[4] = FUEL_SELECTOR_RIGHT_1;
                Bit[5] = FUEL_SELECTOR_LEFT_3;
                Bit[6] = FUEL_SELECTOR_LEFT_2;
                Bit[7] = FUEL_SELECTOR_LEFT_1;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                EmptyBit1 = Bit[0];
                EmptyBit2 = Bit[1];
                FUEL_SELECTOR_RIGHT_3 = Bit[2];
                FUEL_SELECTOR_RIGHT_2 = Bit[3];
                FUEL_SELECTOR_RIGHT_1 = Bit[4];
                FUEL_SELECTOR_LEFT_3 = Bit[5];
                FUEL_SELECTOR_LEFT_2 = Bit[6];
                FUEL_SELECTOR_LEFT_1 = Bit[7];
            }

        }

        #region Bits

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit1 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit2 = false;

        [Description("")]
        public bool FUEL_SELECTOR_RIGHT_3;

        [Description("")]
        public bool FUEL_SELECTOR_RIGHT_2;

        [Description("")]
        public bool FUEL_SELECTOR_RIGHT_1;

        [Description("")]
        public bool FUEL_SELECTOR_LEFT_3;

        [Description("")]
        public bool FUEL_SELECTOR_LEFT_2;

        [Description("")]
        public bool FUEL_SELECTOR_LEFT_1;

        #endregion
    }
}
