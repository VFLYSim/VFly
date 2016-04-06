using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvertByte.Interfaces;

namespace VFly
{
    class Controller_3: IFrame
    {
        public Controller_3_DO0 Button0 { get; set; } = new Controller_3_DO0();
        public Controller_3_DO1 Button1 { get; set; } = new Controller_3_DO1();
        public Controller_3_DO2 Button2 { get; set; } = new Controller_3_DO2();
        public Controller_3_DO3 Button3 { get; set; } = new Controller_3_DO3();
        public Controller_3_DO4 Button4 { get; set; } = new Controller_3_DO4();
        public Controller_3_DO5 Button5 { get; set; } = new Controller_3_DO5();
        public Controller_3_DO6 Button6 { get; set; } = new Controller_3_DO6();
        public Controller_3_DO7 Button7 { get; set; } = new Controller_3_DO7();

        public byte[] Frame
        {
            get
            {
                List<byte> ListOfBytes = new List<byte>();

                ListOfBytes.Add(Button0.Value);
                ListOfBytes.Add(Button1.Value);
                ListOfBytes.Add(Button2.Value);
                ListOfBytes.Add(Button3.Value);
                ListOfBytes.Add(Button4.Value);
                ListOfBytes.Add(Button5.Value);
                ListOfBytes.Add(Button6.Value);
                ListOfBytes.Add(Button7.Value);

                return ListOfBytes.ToArray();
            }

            set
            {
                value[0] = Button0.Value;
                value[1] = Button1.Value;
                value[2] = Button2.Value;
                value[3] = Button3.Value;
                value[4] = Button4.Value;
                value[5] = Button5.Value;
                value[6] = Button6.Value;
                value[7] = Button7.Value;
            }
        }
    }
}
