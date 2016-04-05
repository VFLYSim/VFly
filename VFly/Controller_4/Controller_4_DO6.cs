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
    public class Controller_4_DO6 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = EmptyBit1;
                Bit[1] = EmptyBit2;
                Bit[2] = EmptyBit3;
                Bit[3] = FIRE_SYSTEM_CHECK;
                Bit[4] = STBY_BATT_TEST;
                Bit[5] = STBY_BATT_ARM;
                Bit[6] = C172_PITCH_TRIM_B;
                Bit[7] = C172_PITCH_TRIM_A;

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                EmptyBit1 = Bit[0];
                EmptyBit2 = Bit[1];
                EmptyBit3 = Bit[2];
                FIRE_SYSTEM_CHECK = Bit[3];
                STBY_BATT_TEST = Bit[4];
                STBY_BATT_ARM = Bit[5];
                C172_PITCH_TRIM_B = Bit[6];
                C172_PITCH_TRIM_A = Bit[7];
            }

        }

        #region Bits

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit1 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit2 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit3 = false;

        [Description("Brak informacji - prawdopodobnie wyświetlane podczas włączonego symulatora")]
        public bool FIRE_SYSTEM_CHECK;

        [Description("Brak informacji - prawdopodobnie wyświetlane podczas włączonego symulatora")]
        public bool STBY_BATT_TEST;

        [Description("Brak informacji - prawdopodobnie wyświetlane podczas włączonego symulatora")]
        public bool STBY_BATT_ARM;

        [Description("Połączone C172_PITCH_TRIM_A - 'koło w dolnej części kokpitu (NoseDown, NoseUp, TakeOff)', zmiana 00->11 w losowej kolejności")]
        public bool C172_PITCH_TRIM_B;

        [Description("Połączone C172_PITCH_TRIM_B - 'koło w dolnej części kokpitu (NoseDown, NoseUp, TakeOff)', zmiana 00->11 w losowej kolejności")]
        public bool C172_PITCH_TRIM_A;

        #endregion
    }
}
