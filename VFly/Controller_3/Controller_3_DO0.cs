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
    public class Controller_3_DO0 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = NAV_SWAP;
                Bit[1] = VOL_PUSH_ID_NAV;
                Bit[2] = MENU;
                Bit[3] = DIRECT_TO;
                Bit[4] = SOFT4;
                Bit[5] = SOFT3;
                Bit[6] = SOFT2;
                Bit[7] = SOFT1;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                NAV_SWAP = Bit[0];
                VOL_PUSH_ID_NAV = Bit[1];
                MENU = Bit[2];
                DIRECT_TO = Bit[3];
                SOFT4 = Bit[4];
                SOFT3 = Bit[5];
                SOFT2 = Bit[6];
                SOFT1 = Bit[7];
            }

        }

        #region Bits

        [Description("Przycisk strzałka lewo-prawo, Wciśnięty - 1, Puszczony - 0")]
        public bool NAV_SWAP;

        [Description("Potencjomter Vol Push ID, Wciśnięty - 1, Puszczony - 0")]
        public bool VOL_PUSH_ID_NAV;

        [Description("Przycisk Menu, Wciśnięty - 1, Puszczony - 0")]
        public bool MENU;

        [Description("Przycisk D ze strzałką w prawo, Wciśnięty - 1, Puszczony - 0")]
        public bool DIRECT_TO;

        [Description("Strzałka pod ekranem (czwarta od lewej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT4;

        [Description("Strzałka pod ekranem (trzeci od lewej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT3;

        [Description("Strzałka pod ekranem (druga od lewej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT2;

        [Description("Strzałka pod ekranem (pierwsza od lewej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT1;

        #endregion
    }
}
