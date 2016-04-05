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
    public class Controller_4_DO2 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = PILOT_B;
                Bit[1] = PILOT_A;
                Bit[2] = EmptyBit;
                Bit[3] = AU_COPLT;
                Bit[4] = AU_PILOT;
                Bit[5] = AU_PLAY;
                Bit[6] = AU_MAN_SQ;
                Bit[7] = AU_AUX;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                PILOT_B = Bit[0];
                PILOT_B = Bit[1];
                EmptyBit = Bit[2];
                AU_COPLT = Bit[3];
                AU_PILOT = Bit[4];
                AU_PLAY = Bit[5];
                AU_MAN_SQ = Bit[6];
                AU_AUX = Bit[7];
            }

        }

        #region Bits

        [Description("Połączony z PILOT_A - w prawo rośnie 00->11, w lewo maleje 11->00, wciśnięty daje 00, puszczony 11")]
        public bool PILOT_B;

        [Description("Połączony z PILOT_B - w prawo rośnie 00->11, w lewo maleje 11->00, wciśnięty daje 00, puszczony 11")]
        public bool PILOT_A;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit = false;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COPLT;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_PILOT;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_PLAY;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_MAN_SQ;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_AUX;

        #endregion
    }
}
