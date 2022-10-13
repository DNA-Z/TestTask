using TestTask.Application.Models;

namespace TestTask.Application.Algorithm
{
    public class HashFileCalculate
    {
        public string GetFileHash(string filesPath)
        {
            var crc32 = new CRC32();
            var hash = String.Empty;

            foreach (var file in filesPath)
            {
                using (var fs = File.Open(filesPath, FileMode.Open))
                    foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();

                Console.WriteLine("CRC-32 is {0}", hash);
            }

            return hash;
        }
    }
}
