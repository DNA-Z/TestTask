using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Application.Infrastructure
{
    internal class BBConverter
    {
        public string ByteToBitConvert(byte inputByte)
        {
            string bits = Convert.ToString(inputByte, 2).PadLeft(8, '0');
            return bits;
        }

        public byte BitToByteConvert(string inputBits)
        {
            byte resultBytes = Convert.ToByte(inputBits, 2);
            return resultBytes;
        }
    }
}
