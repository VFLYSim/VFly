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
    public class Controller_1_DO4 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = KOLSHMAN_B; //ENCODER 1
                Bit[1] = KOLSHMAN_A; //ENCODER 1
                Bit[2] = EmptyBit1; //TRIM_RIGHT
                Bit[3] = EmptyBit2; //TRIM_LEFT
                Bit[4] = EmptyBit3; //TRIM_DOWN
                Bit[5] = EmptyBit4; //TRIM_UP
                Bit[6] = GEARS;
                Bit[7] = AMPERES;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                KOLSHMAN_B = Bit[0];
                KOLSHMAN_A = Bit[1];
                EmptyBit1 = Bit[2];
                EmptyBit2 = Bit[3];
                EmptyBit3 = Bit[4];
                EmptyBit4 = Bit[5];
                GEARS = Bit[6];
                AMPERES = Bit[7];
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

        [Description("Przekręcenie w  strone daje wartość 1")] // moje przeoczenie - trzeba dopisać w którą strone
        public bool KOLSHMAN_B;

        [Description("Przekręcenie w strone daje wartość 1")]
        public bool KOLSHMAN_A;

        [Description("Ustawione w góre - 0, Ustawione w dół - 1")]
        public bool GEARS;

        [Description("Niepodpisany przełącznik pod taxi lights")]
        public bool AMPERES;

        #endregion
    }
}
