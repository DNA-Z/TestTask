using TestTask.Application.Algorithm;
using TestTask.Application.Infrastructure;

//string path = String.Empty;

//Console.WriteLine("Здравствуйте\nВведите путь к файлу:");
//path = @"D:\Work\OVK_Group\Акцент\Стройнадзор_Карелия\Шаблоны\New Text Document.txt"; //Console.ReadLine();

//// We get a set: the key is the path to the file and the value is the checksum
//var fileParser = new FileParser();
//var fileChecksums = fileParser.Parse(path);

//foreach (var checksum in fileChecksums)
//{
//    Console.WriteLine(checksum.Path + " - " + checksum.Hash);
//}

//// 
//var checksumsFile = new HashFileCalculate();

string bits = "00011011";
byte a = Convert.ToByte(bits, 2); //переводим из двоичной в десятичную
Console.WriteLine(a.ToString());

Console.WriteLine(Convert.ToString(a, 2).PadLeft(8, '0')); // из десятичной в двоичную

Console.ReadKey();