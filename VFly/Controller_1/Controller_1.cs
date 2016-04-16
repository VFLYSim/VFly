using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Interfaces;
using VFly;
using ConvertByte.Interfaces;

namespace ConvertByte.Controller_1
{
    class Controller_1 : IFrame
    {
        public Controller_1_DO0 EmptyByte1 { get; set; } = new Controller_1_DO0();
        public Controller_1_DO1 EmptyByte2 { get; set; } = new Controller_1_DO1();
        public Controller_1_DO2 Lights { get; set; } = new Controller_1_DO2();
        public Controller_1_DO3 Attitude { get; set; } = new Controller_1_DO3();
        public Controller_1_DO4 Gears { get; set; } = new Controller_1_DO4();
        public Controller_1_DO5 Volts { get; set; } = new Controller_1_DO5();
        public Controller_1_DO6 Starter { get; set; } = new Controller_1_DO6();
        public Controller_1_DO7 FuelSelector { get; set; } = new Controller_1_DO7();
        public Controller_1_Analog Analog { get; set; } = new Controller_1_Analog();

        public byte[] Frame
        {
            get
            {
                List<byte> ListOfBytes = new List<byte>();

                ListOfBytes.Add(EmptyByte1.Value);
                ListOfBytes.Add(EmptyByte2.Value);
                ListOfBytes.Add(Lights.Value);
                ListOfBytes.Add(Attitude.Value);
                ListOfBytes.Add(Gears.Value);
                ListOfBytes.Add(Volts.Value);
                ListOfBytes.Add(Starter.Value);
                ListOfBytes.Add(FuelSelector.Value);

                return ListOfBytes.ToArray().Concat(Analog.Value).ToArray();
            }

            set
            {
                value[0] = EmptyByte1.Value;
                value[1] = EmptyByte2.Value;
                value[2] = Lights.Value;
                value[3] = Attitude.Value;
                value[4] = Gears.Value;
                value[5] = Volts.Value;
                value[6] = Starter.Value;
                value[7] = FuelSelector.Value;
                value[8] = Analog.Value[0];
                value[9] = Analog.Value[1];
                value[10] = Analog.Value[2];
                value[11] = Analog.Value[3];
                value[12] = Analog.Value[4];
                value[13] = Analog.Value[5];
                value[14] = Analog.Value[6];
                value[15] = Analog.Value[7];
                value[16] = Analog.Value[8];
                value[17] = Analog.Value[9];
                value[18] = Analog.Value[10];
                value[19] = Analog.Value[11];
                value[20] = Analog.Value[12];
                value[21] = Analog.Value[13];
                value[22] = Analog.Value[14];
                value[23] = Analog.Value[15];
                value[24] = Analog.Value[16];
            }
        }
    }
}
