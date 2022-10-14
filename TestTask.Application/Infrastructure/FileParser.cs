using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TestTask.Application.Models;

namespace TestTask.Application.Infrastructure
{
    public class FileParser
    {
        public LinkedList<DataFile> Parse(string path)
        {
            char[] delimiterChars = { ' ', ',', ';', '-', '\'', '\"', '\t', '\n', '\r' };
            LinkedList<DataFile> checksumPathes = new LinkedList<DataFile>();

            string fileContent = ReadFile(path);
            string[] fileContentParse = fileContent.Split(delimiterChars)
                .Select(x => x.Replace(" ", "")).Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            for (int i = 0; i < fileContentParse.Length - 1; i += 2)
                checksumPathes.AddLast(new DataFile(fileContentParse[i], fileContentParse[i + 1]));

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
