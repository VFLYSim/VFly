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
    public class Controller_2_DO4 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = COM1_B;
                Bit[1] = COM1_A;
                Bit[2] = CRS_BARO_PUSH;
                Bit[3] = COM_PUSH;
                Bit[4] = COM_SWAP;
                Bit[5] = VOL_PUSH_SQ_COM;
                Bit[6] = ALT2_B;
                Bit[7] = ALT2_A;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                COM1_B = Bit[0];
                COM1_A = Bit[1];
                CRS_BARO_PUSH = Bit[2];
                COM_PUSH = Bit[3];
                COM_SWAP = Bit[4];
                VOL_PUSH_SQ_COM = Bit[5];
                ALT2_B = Bit[6];
                ALT2_A = Bit[7];
            }

        }

        #region Bits

        [Description("Potencjometr wewnętrzny COM, połączony z COM1_A, zmiana 00->11")]
        public bool COM1_B;

        [Description("Potencjometr wewnętrzny COM, połączony z COM1_B, zmiana 00->11")]
        public bool COM1_A;

        [Description("Potencjometr Crs Baro, Wciśnięty - 1, Puszczony - 0")]
        public bool CRS_BARO_PUSH;

        [Description("Przycisk EMRG, Wciśnięty - 1, Puszczony - 0")]
        public bool COM_PUSH;

        [Description("Potencjometr COM, Wciśnięty - 1, Puszczony - 0")]
        public bool COM_SWAP;

        [Description("Potencjometr Vol Push SQ, Wciśnięty - 1, Puszczony - 0")]
        public bool VOL_PUSH_SQ_COM;

        [Description("Potencjometr zewnętrzny Alt, połączony z ALT2_B, zmiana 00->11")]
        public bool ALT2_B;

        [Description("Potencjometr zewnętrzny Alt, połączony z ALT2_A, zmiana 00->11")]
        public bool ALT2_A;

        #endregion
    }
}
