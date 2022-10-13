using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TestTask.Application.Models;

namespace TestTask.Application
{
    public class FileParser
    {
        /// <summary>
        /// Parses the file and returns a LinkedList<ChecksumPath>
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public LinkedList<ChecksumPath> Parse(string path)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', ';', '\t', '\n', '\r' };
            LinkedList<ChecksumPath> checksumPathes = new LinkedList<ChecksumPath>();
            
            string fileContent = ReadFile(path);
            string[] fileContentParse = fileContent.Split(delimiterChars)
                .Select(x => x.Replace(" ", "")).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray(); 

            for(int i = 0; i < fileContentParse.Length - 1; i += 2)
                checksumPathes.AddLast(new ChecksumPath(fileContentParse[i], fileContentParse[i + 1]));

            return checksumPathes;
        }

        public string ReadFile(string path)
        {
            string fileContent = string.Empty;

            using (var reader = new StreamReader(path))
            {
                fileContent = reader.ReadToEnd();
            }

            return fileContent;
        }
    }
}
