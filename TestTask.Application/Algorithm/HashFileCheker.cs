using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Application.Models;

namespace TestTask.Application.Algorithm
{
    internal class HashFileCheker
    {
        public void CheckFileHash(LinkedList<DataFile> files)
        {
            HashFileCalculate checksums = new HashFileCalculate();
            string hesh = string.Empty;

            foreach (DataFile file in files)
            {
                hesh = checksums.GetFileHash(file.Path);

                if (!hesh.Equals(file.Hash))
                    Console.WriteLine($"В файле {file.Path} обранужено несоответствие контрольной суммы");
            }
        }
    }
}
