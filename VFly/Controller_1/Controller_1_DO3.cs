using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertByte.Controller_4;
using Interfaces;
using ConvertByte;

namespace VFly
{
    public class Controller_1_DO3 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = ATTITUDE_BAR_B; //ENCODER 0
                Bit[1] = ATTITUDE_BAR_A; //ENCODER 0
                Bit[2] = EmptyBit1; //AP_DISCONNECT
                Bit[3] = EmptyBit2; //FLAPS_DOWN
                Bit[4] = EmptyBit3; //FLAPS_UP
                Bit[5] = EmptyBit4; //SWITCHES_LIGHT
                Bit[6] = EmptyBit5; //PANEL_LIGHT
                Bit[7] = EmptyBit6; //INSTRUMENTS_LIGHT

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                ATTITITUDE_BAR_B = Bit[0];
                ATTITUDE_BAR_A= Bit[1];
                EmptyBit1 = Bit[2];
                EmptyBit2 = Bit[3];
                EmptyBit3 = Bit[4];
                EmptyBit4 = Bit[5];
                EmptyBit5 = Bit[6];
                EmptyBit6 = Bit[7];

            }

        }

        #region Bits

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit1 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit2 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit3 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit4 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit5 = false;

        [Description("Pusty bit -> zero logiczne")]
        public bool EmptyBit6 = false;

        [Description("Przekręcenie w  strone daje wartość 1")] // moje przeoczenie - trzeba dopisać w którą strone
        public bool ATTITUDE_BAR_B;

        [Description("Przekręcenie w  strone daje wartość 1")]
        public bool ATTITUDE_BAR_A;

        #endregion
    }
}
