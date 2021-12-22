using System;
using System.IO;
using System.Linq;

const string FILE_PATH = "file.txt";
const int COUNT = 5;

var numbers = Enumerable
    .Range(0, COUNT)
    .Select(exponent => Math.Pow(3, exponent));

await File.WriteAllTextAsync(FILE_PATH, string.Join(Environment.NewLine, numbers));

var fileNumbers = await File.ReadAllLinesAsync(FILE_PATH);
for (var i = 0; i < fileNumbers.Length; i += 2)
{
    Console.WriteLine(fileNumbers[i]);
}