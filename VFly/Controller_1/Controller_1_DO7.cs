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
    public class Controller_1_DO7 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = C172_FUEL_SELECTOR_4; 
                Bit[1] = C172_FUEL_SELECTOR_3; 
                Bit[2] = C172_FUEL_SELECTOR_2;
                Bit[3] = EmptyBit1; //C127_FUEL_SELECTOR_1
                Bit[4] = EmptyBit2;//PUSTY BIT
                Bit[5] = C172_FUEL_PUMP;
                Bit[6] = TRUE_AIRSPEED_B; //ENCODER 3
                Bit[7] = TRUE_AIRSPEED_A; //ENCODER 3

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                C172_FUEL_SELECTOR_4 = Bit[0];
                C172_FUEL_SELECTOR_3 = Bit[1];
                C172_FUEL_SELECTOR_2 = Bit[2];
                EmptyBit1 = Bit[3];
                EmptyBit2 = Bit[4];
                C172_FUEL_PUMP = Bit[5];
                TRUE_AIRSPEED_B = Bit[6];
                TRUE_AIRSPEED_A = Bit[7];
            }

        }

        #region Bits

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit1 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit2 = false;

        [Description("Przełącznik zbiornika paliwa - 1 gdy ustawiony w prawo")]
        public bool C172_FUEL_SELECTOR_4;

        [Description("Przełącznik zbiornika paliwa - 1 gdy ustawiony w góre")]
        public bool C172_FUEL_SELECTOR_3;

        [Description("Przełącznik zbiornika paliwa - 1 gdy ustawiony w lewo")]
        public bool C172_FUEL_SELECTOR_2;

        [Description("Przełącznik fuel pump koło lewego wolanta")]
        public bool C172_FUEL_PUMP;

        [Description("Przekręcenie w  strone daje wartość 1")] // moje przeoczenie - trzeba dopisać w którą strone
        public bool TRUE_AIRSPEED_B;

        [Description("Przekręcenie w  strone daje wartość 1")]
        public bool TRUE_AIRSPEED_A;

        #endregion
    }
}
