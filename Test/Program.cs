using DataReader;

var CsvData = new ImportCsv("data/Housing.csv");
var data = CsvData.ReadCsv();

Console.WriteLine("Hello, World!");
