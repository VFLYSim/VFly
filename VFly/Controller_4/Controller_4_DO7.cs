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
    public class Controller_4_DO7 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = EmptyBit1;
                Bit[1] = EmptyBit2;
                Bit[2] = EmptyBit3;
                Bit[3] = EmptyBit4;
                Bit[4] = EmptyBit5;
                Bit[5] = EmptyBit6;
                Bit[6] = C172_RUDDER_TRIM_B;
                Bit[7] = C172_RUDDER_TRIM_A;

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
                C172_RUDDER_TRIM_B = Bit[6];
                C172_RUDDER_TRIM_A = Bit[7];
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

        [Description("Połączone C172_RUDDER_TRIM_A - 'koło w dolnej części kokpitu (NoseLeft, NoseRight)', zmiana 00->11 w losowej kolejności")]
        public bool C172_RUDDER_TRIM_B;

        [Description("Połączone C172_RUDDER_TRIM_B - 'koło w dolnej części kokpitu (NoseLeft, NoseRight)', zmiana 00->11 w losowej kolejności")]
        public bool C172_RUDDER_TRIM_A;

        #endregion
    }
}
