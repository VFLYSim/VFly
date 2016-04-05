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
    public class Controller_4_DO1 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = AU_NAV2;
                Bit[1] = AU_ADF;
                Bit[2] = AU_NAV1;
                Bit[3] = AU_DME;
                Bit[4] = AU_HI_SENS;
                Bit[5] = AU_MKR_MUTE;
                Bit[6] = AU_SPKR;
                Bit[7] = AU_PA;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                AU_NAV2 = Bit[0];
                AU_ADF = Bit[1];
                AU_NAV1 = Bit[2];
                AU_DME = Bit[3];
                AU_HI_SENS = Bit[4];
                AU_MKR_MUTE = Bit[5];
                AU_SPKR = Bit[6];
                AU_PA = Bit[7];
            }

        }

        #region Bits

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_NAV2;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_ADF;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_NAV1;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_DME;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_HI_SENS;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_MKR_MUTE;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_SPKR;

        [Description("Wciśnięty - 1, Puszczony - 0")]
        public bool AU_PA;

        #endregion
    }
}
