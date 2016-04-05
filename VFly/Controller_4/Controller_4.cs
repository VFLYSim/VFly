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

namespace ConvertByte.Controller_4
{
    class Controller_4 : IFrame
    {
        public Controller_4_DO0 Button0 { get; set; } = new Controller_4_DO0();
        public Controller_4_DO1 Button1 { get; set; } = new Controller_4_DO1();
        public Controller_4_DO2 Button2 { get; set; } = new Controller_4_DO2();
        public Controller_4_DO3 Display { get; set; } = new Controller_4_DO3();
        public Controller_4_DO4 FuelSelector { get; set; } = new Controller_4_DO4();
        public Controller_4_DO5 EmptyByte { get; set; } = new Controller_4_DO5();
        public Controller_4_DO6 Pitch { get; set; } = new Controller_4_DO6();
        public Controller_4_DO7 Rudder { get; set; } = new Controller_4_DO7();

        public byte[] Frame
        {
            get
            {
                List<byte> ListOfBytes = new List<byte>();

                ListOfBytes.Add(Button0.Value);
                ListOfBytes.Add(Button1.Value);
                ListOfBytes.Add(Button2.Value);
                ListOfBytes.Add(Display.Value);
                ListOfBytes.Add(FuelSelector.Value);
                ListOfBytes.Add(EmptyByte.Value);
                ListOfBytes.Add(Pitch.Value);
                ListOfBytes.Add(Rudder.Value);

                return ListOfBytes.ToArray();
            }

            set
            {
                value[0] = Button0.Value;
                value[1] = Button1.Value;
                value[2] = Button2.Value;
                value[3] = Display.Value;
                value[4] = FuelSelector.Value;
                value[5] = EmptyByte.Value;
                value[6] = Pitch.Value;
                value[7] = Rudder.Value;
            }
        }
    }
}
