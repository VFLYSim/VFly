using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using ConvertByte;

namespace VFly
{
    public class Controller_1_DO2 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = EmptyBit1; //AP_MASTER
                Bit[1] = PITOT_HEAT;
                Bit[2] = EmptyBit2; //AP_TRIM_MASTER_SWITCH
                Bit[3] = BEACON_LIGHT;
                Bit[4] = STROBE_LIGHT;
                Bit[5] = NAV_LIGHT;
                Bit[6] = TAXI_LIGHT;
                Bit[7] = LANDING_LIGHT;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                EmptyBit1 = Bit[0];
                EmptyBit2 = Bit[1];
                EmptyBit3= Bit[2];
                BEACON_LIGHT = Bit[3];
                STROBE_LIGHT = Bit[4];
                NAV_LIGHT= Bit[5];
                TAXI_LIGHT= Bit[6];
                LANDING_LIGHT= Bit[7];
            }

        }

        #region Bits

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit1 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit2 = false;

        [Description("Włączony - 1, Wyłączony - 0")]
        public bool PITOT_HEAT;

        [Description("Włączony - 1, Wyłączony - 0")]
        public bool BEACON_LIGHT;

        [Description("Włączony - 1, Wyłączony - 0")]
        public bool STROBE_LIGHT;

        [Description("Włączony - 1, Wyłączony - 0")]
        public bool NAV_LIGHT;

        [Description("Włączony - 1, Wyłączony - 0")]
        public bool TAXI_LIGHT;

        [Description("Włączony - 1, Wyłączony - 0")]
        public bool LANDING_LIGHT;

        #endregion
    }
}
