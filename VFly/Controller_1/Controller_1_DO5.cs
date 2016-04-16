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
    public class Controller_1_DO5 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = EmptyBit1; //TRIM_DOWN2
                Bit[1] = EmptyBit2; //TRIM_UP2
                Bit[2] = EmptyBit3; //PUSTY BIT
                Bit[3] = EmptyBit4; //AP_FREEZE
                Bit[4] = EmptyBit5; //PITCH_TRIM_B
                Bit[5] = EmptyBit6; //PITCH_TRIM_A
                Bit[6] = EmptyBit7; //GEARS_TEST
                Bit[7] = PUSH_FOR_VOLTS;

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
                PUSH_FOR_VOLTS = Bit[7];
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

        [Description("Niepodpisany przełącznik pod NAV")]
        public bool PUSH_FOR_VOLTS = false;

        #endregion
    }
}