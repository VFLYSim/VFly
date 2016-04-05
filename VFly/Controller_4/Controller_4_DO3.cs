using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertByte.Controller_4;
using Interfaces;
using ConvertByte;

namespace VFly
{
    public class Controller_4_DO3 : ByteBase, IByteValue
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
                Bit[5] = DISPLAY_BACKUP;
                Bit[6] = PASS_B;
                Bit[7] = PASS_A;

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
                DISPLAY_BACKUP = Bit[5];
                PASS_B = Bit[6];
                PASS_A = Bit[7];
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

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool DISPLAY_BACKUP;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool PASS_B;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool PASS_A;

        #endregion
    }
}
