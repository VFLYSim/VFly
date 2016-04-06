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
    public class Controller_3_DO1 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = HDG_SYNC;
                Bit[1] = NAV_PUSH;
                Bit[2] = PROCEDURE;
                Bit[3] = FLIGHT_PLAN;
                Bit[4] = SOFT8;
                Bit[5] = SOFT7;
                Bit[6] = SOFT6;
                Bit[7] = SOFT5;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                HDG_SYNC = Bit[0];
                NAV_PUSH = Bit[1];
                PROCEDURE = Bit[2];
                FLIGHT_PLAN = Bit[3];
                SOFT8 = Bit[4];
                SOFT7 = Bit[5];
                SOFT6 = Bit[6];
                SOFT5 = Bit[7];
            }

        }

        #region Bits

        [Description("Potencjomter HDG, Wciśnięty - 1, Puszczony - 0")]
        public bool HDG_SYNC;

        [Description("Potencjomter Push Nav1-2, Wciśnięty - 1, Puszczony - 0")]
        public bool NAV_PUSH;

        [Description("Przycisk PROC, Wciśnięty - 1, Puszczony - 0")]
        public bool PROCEDURE;

        [Description("Przycisk FPL, Wciśnięty - 1, Puszczony - 0")]
        public bool FLIGHT_PLAN;

        [Description("Strzałka pod ekranem (piąty od prawej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT8;

        [Description("Strzałka pod ekranem (szósty od prawej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT7;

        [Description("Strzałka pod ekranem (szósty od lewej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT6;

        [Description("Strzałka pod ekranem (piąty od lewej strony), Wciśnięty - 1, Puszczony - 0")]
        public bool SOFT5;

        #endregion
    }
}
