using TestTask.Application.Infrastructure;
using TestTask.Application.Models;

namespace TestTask.Application.Algorithm
{
    public class HashCalculate
    {
        public uint GetHash(string filesPath)
        {
            var crc32 = new CRC32();
            uint hash = 0;
            var byteReader = new ByteReader();
            ReadOnlySpan<byte> bytes = byteReader.ByteRead(filesPath);

            foreach(var line in bytes)
            {
                hash += crc32.GetHashCrc32(line);
            }            

            Console.WriteLine("CRC-32 is {0}", hash);

            return hash;
        }
    }
}
