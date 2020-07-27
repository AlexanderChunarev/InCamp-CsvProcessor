using System;
using InCamp_CsvProcessor.processors;

namespace InCamp_CsvProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            new CsvProcessor("acme_worksheet.csv").Process();
        }
    }
}
