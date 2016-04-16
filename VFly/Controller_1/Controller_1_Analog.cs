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
using ConvertByte;

namespace VFly
{
	public class Controller_1_Analog : ByteBase
	{
		public byte[] Value
        {
            get
            {
                byte[][] Bytes = new byte[15][];

                Bytes[0] = BitConverter.GetBytes(Alierons);
                Bytes[1] = BitConverter.GetBytes(Elevator);
                Bytes[2] = BitConverter.GetBytes(Rudder);
                Bytes[3] = BitConverter.GetBytes(Throttle_1);
                Bytes[4] = BitConverter.GetBytes(Throttle_2);
                Bytes[5] = BitConverter.GetBytes(EmptyByte);
                Bytes[6] = BitConverter.GetBytes(Carburetor_2);
                Bytes[7] = BitConverter.GetBytes(Propeller_1);
                Bytes[8] = BitConverter.GetBytes(Propeller_2);
                Bytes[9] = BitConverter.GetBytes(Parking_Brake);
                Bytes[10] = BitConverter.GetBytes(Choke_1);
                Bytes[11] = BitConverter.GetBytes(Choke_2);
                Bytes[12] = BitConverter.GetBytes(C172_Throttle);
                Bytes[13] = BitConverter.GetBytes(C172_Mixture);
                Bytes[14] = BitConverter.GetBytes(C172_Parking_Brake);
                Bytes[15] = BitConverter.GetBytes(Carburetor_1);

                byte[] tmp = new byte[Bytes.GetLength(0) * Bytes.GetLength(1)];
                Buffer.BlockCopy(Bytes, 0, tmp, 0, tmp.Length * sizeof(byte));
                List<byte> list = new List<byte>(tmp);

                return tmp;
            }

            set
            {
                byte[] Bytes = value;

                Alierons = Bytes[0];
                Elevator = Bytes[1];
                Rudder = Bytes[2];
                Throttle_1 = Bytes[3];
                Throttle_2 = Bytes[4];
                EmptyByte = Bytes[5];
                Carburetor_2 = Bytes[6];
                Propeller_1 = Bytes[7];
                Propeller_2 = Bytes[8];
                Parking_Brake = Bytes[9];
                Choke_1 = Bytes[10];
                Choke_2 = Bytes[11];
                C172_Throttle = Bytes[12];
                C172_Mixture = Bytes[13];
                C172_Parking_Brake = Bytes[14];
                Carburetor_1 = Bytes[15];

            }

        }

        #region Bytes
        [Description("Wolant lewo prawo")]
        public short Alierons;

        [Description("")]
        public short Elevator;

        [Description("")]
        public short Rudder;

        [Description("")]
        public short Throttle_1;

        [Description("")]
        public short Throttle_2;

        [Description("")]
        public short EmptyByte;

        [Description("")]
        public short Carburetor_2;

        [Description("")]
        public short Propeller_1;

        [Description("")]
        public short Propeller_2;

        [Description("")]
        public short Parking_Brake;

        [Description("")]
        public short Choke_1;

        [Description("")]
        public short Choke_2;

        [Description("")]
        public short C172_Throttle;

        [Description("")]
        public short C172_Mixture;

        [Description("")]
        public short C172_Parking_Brake;

        [Description("")]
        public short Carburetor_1;
        #endregion
    }
}
