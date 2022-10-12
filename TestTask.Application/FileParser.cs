
using System.Reflection.PortableExecutable;

namespace TestTask.Application
{
    public class FileParser
    {

        /// <summary>
        /// Parses the file and returns a dictionary, where the key is the file path and the value is the checksum
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Dictionary<string, string> Parse(string path)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', ';', '\t', '\n' };
            string fileContent = ReadFile(path);
            string[] fileContentParse = fileContent.Split(delimiterChars);
            var fileChecksums = fileContentParse.Select(s => s.Split(delimiterChars))
                .ToDictionary(arr => arr[0], arr => arr[1]);

            return fileChecksums;
        }

        public string ReadFile(string path)
        {
            string fileContent = string.Empty;

            using(var reader = new StreamReader(path))
            {
                do
                {
                    fileContent = reader.ReadLine();
                } while (fileContent != null);
            }

            return fileContent;
        }


    }
}
