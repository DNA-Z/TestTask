using System.Runtime.Intrinsics.Arm;
using TestTask.Application;


string path = String.Empty;

Console.WriteLine("Здравствуйте\nВведите путь к файлу:");
path = @"D:\Work\OVK_Group\Акцент\Стройнадзор_Карелия\Шаблоны\New Text Document.txt"; //Console.ReadLine();

// We get a set: the key is the path to the file and the value is the checksum
var fileParser = new FileParser();
var fileChecksums = fileParser.Parse(path);

foreach (var checksum in fileChecksums)
{
    Console.WriteLine(checksum.Path + " - " + checksum.Checksum);
}

// 
var checksumsFile = new ChecksumsFile();

