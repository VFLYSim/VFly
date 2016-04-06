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
    public class Controller_2_DO6 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = FMS2_B;
                Bit[1] = FMS2_A;
                Bit[2] = EmptyBit;
                Bit[3] = RANGE_PUSH;
                Bit[4] = RANGE_RIGHT;
                Bit[5] = RANGE_LEFT;
                Bit[6] = RANGE_DOWN;
                Bit[7] = RANGE_UP;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                FMS2_B = Bit[0];
                FMS2_A = Bit[1];
                EmptyBit = Bit[2];
                RANGE_PUSH = Bit[3];
                RANGE_RIGHT = Bit[4];
                RANGE_LEFT = Bit[5];
                RANGE_DOWN = Bit[6];
                RANGE_UP = Bit[7];
            }

        }

        #region Bits

        [Description("Potencjomert zewnętrzny Fms, połączony z FMS2_A, zmianan 00->11")]
        public bool FMS2_B;

        [Description("Potencjomert zewnętrzny Fms, połączony z FMS2_B, zmianan 00->11")]
        public bool FMS2_A;

        public bool EmptyBit = false;

        [Description("Joystick Range, Wciśnięty - 1, Puszczony - 0")]
        public bool RANGE_PUSH;

        [Description("Joystick Range w prawo, Wciśnięty - 1, Puszczony - 0")]
        public bool RANGE_RIGHT;

        [Description("Joystick Rangew lewo, Wciśnięty - 1, Puszczony - 0)]
        public bool RANGE_LEFT;

        [Description("Joystick Rangena dół, Wciśnięty - 1, Puszczony - 0")]
        public bool RANGE_DOWN;

        [Description("Joystick Range do góry, Wciśnięty - 1, Puszczony - 0")]
        public bool RANGE_UP;

        #endregion
    }
}
