using Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertByte;

namespace VFly
{
    public class Controller_1_DO0 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = EmptyBit1; //RUDDER_TRIM_DISC
                Bit[1] = EmptyBit2; //RH_CROSS_BUS
                Bit[2] = EmptyBit3; //LH_CROS_BUS
                Bit[3] = EmptyBit4; //AVIONICS_2
                Bit[4] = EmptyBit5; //AVIONICS_1
                Bit[5] = EmptyBit6; //RH_FIELD
                Bit[6] = EmptyBit7; //MASTER
                Bit[7] = EmptyBit8; //LH_FIELD

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                EmptyBit1 = Bit[0];
                EmptyBit2 = Bit[1];
                EmptyBit3 = Bit[2];
                EmptyBit4 = Bit[3];
                EmptyBit5 = Bit[4];
                EmptyBit6 = Bit[5];
                EmptyBit7 = Bit[6];
                EmptyBit8 = Bit[7];
            }

        }

        #region Bits
        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit1 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit2 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit3 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit4 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit5 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit6 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit7 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit8 = false;
        #endregion
    }
}
