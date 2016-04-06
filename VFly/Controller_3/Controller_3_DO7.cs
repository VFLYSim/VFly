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
    public class Controller_3_DO7 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = EmptyBit1;
                Bit[1] = EmptyBit1;
                Bit[2] = RANGE_DEC;
                Bit[3] = RANGE_INC;
                Bit[4] = VOL_COM_B;
                Bit[5] = VOL_COM_A;
                Bit[6] = VOL_NAV_B;
                Bit[7] = VOL_NAV_A;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                EmptyBit1 = Bit[0];
                EmptyBit2 = Bit[1];
                RANGE_DEC = Bit[2];
                RANGE_INC = Bit[3];
                VOL_COM_B = Bit[4];
                VOL_COM_A = Bit[5];
                VOL_NAV_B = Bit[6];
                VOL_NAV_A = Bit[7];
            }

        }

        #region Bits

        public bool EmptyBit1;

        public bool EmptyBit2;

        [Description("Joystick Range, kręcenie w prawo - 1, puszczony - 0")]
        public bool RANGE_DEC;

        [Description("Joystick Range, kręcenie w lewo - 1, puszczony - 0")]
        public bool RANGE_INC;

        [Description("Potencjometr nad COM, połączony z VOL_COM_A, zmiana 00->11")]
        public bool VOL_COM_B;

        [Description("Potencjometr nad COM, połączony z VOL_COM_B, zmiana 00->11")]
        public bool VOL_COM_A;

        [Description("Potencjometr nad NAV, połączony z VOL_NAV_A, zmiana 00->11")]
        public bool VOL_NAV_B;

        [Description("Potencjometr nad NAV, połączony z VOL_NAV_B, zmiana 00->11")]
        public bool VOL_NAV_A;

        #endregion
    }
}
