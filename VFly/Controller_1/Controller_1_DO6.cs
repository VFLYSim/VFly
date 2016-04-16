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
    public class Controller_1_DO6 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = C172_STARTER_RIGHT;//C127_STARTER_START W DOKUMENTAJI NA OFF 1
                Bit[1] = C172_STARTER_LEFT; //C127_STARTER_BOTH W DOKUMENTACJI NA OFF 1
                Bit[2] = C172_STARTER_START; //C127_STARTER_RIGHT W DOKUMENTACJI OSTATNIE 3 BITY 110 PRZY URUCHOMIENIU
                Bit[3] = EmptyBit1; //C127_STARTER_LEFT
                Bit[4] = EmptyBit2; //C127_STARTER_OFF
                Bit[5] = C172_AVIONICS;
                Bit[6] = C172_MASTER_ALT;//C127_MASTER_BAT
                Bit[7] = C172_MASTER_BAT;//C127_MASTER_ALT

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                C172_STARTER_RIGHT = Bit[0];
                C172_STARTER_LEFT= Bit[1];
                C172_STARTER_START= Bit[2];
                EmptyBit1 = Bit[3];
                EmptyBit2 = Bit[4];
                C172_AVIONICS= Bit[5];
                C172_MASTER_ALT= Bit[6];
                C172_MASTER_BAT= Bit[7];
            }

        }

        #region Bits

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit1 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit2 = false;

        [Description("Stacyjka - gdy ustawiona na off - 1, ustawione na R - 0")]
        public bool C172_STARTER_RIGHT;

        [Description("Stacyjka - gdy ustawiona na off - 1 Ustawione na L - 0")]
        public bool C172_STARTER_LEFT;

        [Description("Stacyjka, gdy przekręcona na start 3 ostatnie bity zamieniają się na 110")]
        public bool C172_STARTER_START;

        [Description("Biały przycisk Avionics obok lewego wolantu, wciśnięty w dół - 0 w góre - 1")]
        public bool C172_AVIONICS;

        [Description("Czerwony przycisk Master obok lewego wolantu ALT może zostać włączony dopiero do wciśnięciu BAT")]
        public bool C172_MASTER_ALT;

        [Description("Czerwony przycisk Master obok lewego wolantu ALT może zostać włączony dopiero do wciśnięciu BAT")]
        public bool C172_MASTER_BAT;

        #endregion
    }
}
