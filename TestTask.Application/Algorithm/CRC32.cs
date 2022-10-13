using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Application.Algorithm
{
    // CRC-32/MPEG-2
    internal class CRC32
    {
        private uint crc;
        private readonly uint startInit;
        private readonly uint generatorPoly;
        private readonly int width;

        public CRC32()
        {
            if (!BitConverter.IsLittleEndian)
                throw new PlatformNotSupportedException("Не поддерживается процессорами Big Endian");

            startInit = 0xffffffffu;
            generatorPoly = 0x4C11DB7u;
            width = 32;
        }

        public void GetHashCrc32(byte data)
        {
            crc = startInit ^ data;

            for (int i = 0; i < width; i++)
            {
                var msbCrc = (crc & (1 << 7));

                if (msbCrc > 0)
                    crc = (crc << 1) ^ generatorPoly;
                else
                    crc = (crc << 1);
            }
        }
    }
}
