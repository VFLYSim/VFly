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
    public class Controller_3_DO2 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = FMS_PUSH;
                Bit[1] = EmptyBit;
                Bit[2] = ENTER;
                Bit[3] = CLEAR;
                Bit[4] = SOFT12;
                Bit[5] = SOFT11;
                Bit[6] = SOFT10;
                Bit[7] = SOFT9;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                FMS_PUSH = Bit[0];
                EmptyBit = Bit[1];
                ENTER = Bit[2];
                CLEAR = Bit[3];
                SOFT12 = Bit[4];
                SOFT11 = Bit[5];
                SOFT10 = Bit[6];
                SOFT9 = Bit[7];
            }

        }

        #region Bits 

        [Description("Potensjometr FMS, Wciśnięty - 1, Puszczony - 0")]
        public bool FMS_PUSH;

        public bool EmptyBit = false;

        [Description("Przycisk ENT, Wciśnięty - 1, Puszczony - 0")]
        public bool ENTER;

        [Description("Przycisk CLR, Wciśnięty - 1, Puszczony - 0")]
        public bool CLEAR;

        [Description("Strzałka pod ekranem (pierwszy od prawej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT12;

        [Description("Strzałka pod ekranem (drugi od prawej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT11;

        [Description("Strzałka pod ekranem (trzeci od prawej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT10;

        [Description("Strzałka pod ekranem (czwarty od prawej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT9;

        #endregion
    }
}
