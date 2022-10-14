using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Application.Algorithm
{
    // CRC-32/MPEG-2
    internal class CRC32 : HashAlgorithm
    {
        private uint crc;
        private readonly uint startInit;
        private readonly uint generatorPoly;
        private readonly int width;

        public CRC32()
        {
            startInit = 0xffffffffu;
            generatorPoly = 0x4C11DB7u;
            width = 32;
        }

        public uint GetHashCrc32(byte data)
        {
            //int length = data.Length;
            //int index = 0;
            //uint dw = BinaryPrimitives.ReadUInt32LittleEndian(
            //        data.Slice(index * sizeof(uint), sizeof(uint)));

            crc = startInit ^ data;

            //while (true)
            //{
                for (int i = 0; i < width; i++)
                {
                    if ((crc & 0x80000000) != 0)
                        crc = (crc << 1) ^ generatorPoly;
                    else
                        crc = (crc << 1);
                }

            //if (length <= sizeof(uint)) return crc;
            //length -= sizeof(uint);
            //}
            return crc;
        }

        protected override byte[] HashFinal() => new byte[] { 0 };

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            return;
        }

        public override void Initialize()
        {
            return;
        }
    }
}
