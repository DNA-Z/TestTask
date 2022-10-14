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
        public async Task CheckFileHash(LinkedList<DataFile> files)
        {
            HashCalculate checksums = new HashCalculate();
            uint hesh = 0;

            foreach (DataFile file in files)
            {
                await Task.Run(() => hesh = checksums.GetHash(file.Path));

                if (!hesh.Equals(file.Hash.ToLower()))
                    Console.WriteLine($"В файле {file.Path} обранужено несоответствие контрольной суммы");
            }
        }
    }
}
