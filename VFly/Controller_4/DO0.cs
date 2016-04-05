using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VFlyGit.Controller_4;
using VFlyGit.Controller_4.Interfaces;

namespace VFly
{
    public class DO0 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = AU_TEL;
                Bit[1] = AU_COM1_2;
                Bit[2] = AU_COM3;
                Bit[3] = AU_COM3_MIC;
                Bit[4] = AU_COM2;
                Bit[5] = AU_COM2_MIC;
                Bit[6] = AU_COM1;
                Bit[7] = AU_COM1_MIC;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                AU_TEL = Bit[0];
                AU_COM1_2 = Bit[1];
                AU_COM3 = Bit[2];
                AU_COM3_MIC = Bit[3];
                AU_COM2 = Bit[4];
                AU_COM2_MIC = Bit[5];
                AU_COM1 = Bit[6];
                AU_COM1_MIC = Bit[7];
            }

        }

        #region Bits

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_TEL;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM1_2;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM3;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM3_MIC;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM2;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM2_MIC;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM1;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_COM1_MIC;

        #endregion
    }
}
