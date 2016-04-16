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
    public class Controller_1_DO1 : ByteBase, IByteValue
    {
        public byte Value
        {
            get
            {
                bool[] Bit = new bool[7];

                Bit[0] = EmptyBit1; //RIGHT_ENGINE_RH_IGNITION
                Bit[1] = EmptyBit2; //RIGHT_ENGINE_LH_IGNITION
                Bit[2] = EmptyBit3; //RH_FUEL_PUMP
                Bit[3] = EmptyBit4; //RH_STARTER
                Bit[4] = EmptyBit5; //LEFT_ENGINE_RH_IGNITION
                Bit[5] = EmptyBit6; //LEFT_ENGINE_LH_IGNITION
                Bit[6] = EmptyBit7; //LH_STARTER
                Bit[7] = EmptyBit8; //LH_FUEL_PUMP

                return ConvertBoolArrayToByte(Bit);
            }
            set
            {
                bool[] Bit = ConvertByteToBoolArray(value);

                EmptyBit1 = Bit[0];
                EmptyBit2 = Bit[1];
                EmptyBit3 = Bit[2];
                EmptyBit4 = Bit[3];
                EmptyBit5 = Bit[4];
                EmptyBit6 = Bit[5];
                EmptyBit7 = Bit[6];
                EmptyBit8 = Bit[7];
            }

        }

        #region Bits

        #endregion
    }
}
