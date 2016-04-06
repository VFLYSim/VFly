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
    public class Controller_2_DO5 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = FMS1_B;
                Bit[1] = FMS1_A;
                Bit[2] = BARO_B;
                Bit[3] = BARO_A;
                Bit[4] = CRS_B;
                Bit[5] = CRS_A;
                Bit[6] = COM2_B;
                Bit[7] = COM2_A;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                FMS1_B = Bit[0];
                FMS1_A = Bit[1];
                BARO_B = Bit[2];
                BARO_A = Bit[3];
                CRS_B = Bit[4];
                CRS_A = Bit[5];
                COM2_B = Bit[6];
                COM2_A = Bit[7];
            }

        }

        #region Bits

        [Description("Potencjomert zewnętrzny Fms, połączony z FMS1_A, zmianan 00->11")]
        public bool FMS1_B;

        [Description("Potencjomert zewnętrzny Fms, połączony z FMS1_B, zmianan 00->11")]
        public bool FMS1_A;

        [Description("Potencjomert zewnętrzny Crs Baro, połączony z BARO_A, zmianan 00->11")]
        public bool BARO_B;

        [Description("Potencjomert zewnętrzny Crs Baro, połączony z BARO_B, zmianan 00->11")]
        public bool BARO_A;

        [Description("Potencjomert wewnętrzny Crs Baro, połączony z CRS_A, zmianan 00->11")]
        public bool CRS_B;

        [Description("Potencjomert wewnętrzny Crs Baro, połączony z CRS_B, zmianan 00->11")]
        public bool CRS_A;

        [Description("Potencjomert zewnętrzny COM, połączony z COM2_A, zmianan 00->11")]
        public bool COM2_B;

        [Description("Potencjomert zewnętrzny COM, połączony z COM2_B, zmianan 00->11")]
        public bool COM2_A;

        #endregion
    }
}
