using TestTask.Application.Algorithm;
using TestTask.Application.Infrastructure;

string path = string.Empty;

Console.WriteLine("Здравствуйте\nВведите путь к файлу:");
Console.ReadLine(); // Console.WriteLine(path = @"D:\FileData.txt"); //Console.ReadLine();

var fileParser = new FileParser();
var fileDatas = fileParser.Parse(path);

foreach (var data in fileDatas)
{
    Console.WriteLine($"{data.Path} - {data.Hash}");
}

var calculate = new HashFileCheker();
await calculate.CheckFileHash(fileDatas);

Console.ReadKey();