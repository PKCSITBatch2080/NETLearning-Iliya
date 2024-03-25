using System;
using System.IO;
using System.Linq;
class Program
{
    public static void Main()
    {
        string filePath = @"C:\Users\Jaid\Desktop\iliya\DOTnet GIT\NETLearning-Iliya\Assignment3\Inflation.csv";
        InflationAnalysis analysis = new InflationAnalysis();
        analysis.ReadData(filePath);
        //Console.WriteLine(filePath);
        //Console.ReadKey();
        Console.WriteLine("Inflation rates for countries for the year 2021:");
        var Data = analysis.GetInflationRatesForYear(2021);
        foreach (var inflation in Data)
        {
            Console.WriteLine($"{inflation.RegionalMember}: {inflation.InflationRate}%");
        }

        Console.WriteLine("\n Year when Nepal has highest inflation:");
        string countryName = "Nepal";
        int yearWithHighestInflationForNepal = analysis.GetYearWithHighestInflationForCountry(countryName);
        Console.WriteLine(yearWithHighestInflationForNepal);

        Console.WriteLine("\n Top 10 regions where inflation is highest for all time:");
        foreach (var inflation in analysis.GetTop10RegionsWithHighestInflation())
        {
            Console.WriteLine($"{inflation.RegionalMember}: {inflation.InflationRate}%");
        }

        Console.WriteLine("\n Top 3 South Asian countries with lowest inflation rate for year 2020:");
        foreach (var inflation in analysis.GetTop3SouthAsianCountriesWithLowestInflationForYear(2020))
        {
            Console.WriteLine($"{inflation.RegionalMember}: {inflation.InflationRate}%");
        }

    }
}
