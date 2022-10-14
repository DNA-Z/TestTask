using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Application.Algorithm;

namespace TestTask.Application.Infrastructure
{
    internal class ByteReader
    {
        public ReadOnlySpan<byte> ByteRead(string filesPath)
        {
            CRC32 crc32 = new CRC32();
            List<byte> bytes = new List<byte>();

            using (var fs = File.Open(filesPath, FileMode.Open))
            {
                foreach (byte b in crc32.ComputeHash(fs))
                {
                    bytes.Add(b);
                    Console.WriteLine(b);
                }
            }

            return bytes.ToArray();
        }
    }
}
