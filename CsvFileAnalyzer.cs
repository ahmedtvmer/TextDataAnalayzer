using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalayzer
{
    internal class CsvFileAnalyzer : FileAnalyzer, IFileAnalyzer
    {
        public void AnalyzeFile(FileInfo file)
        {
            string[] fileString = File.ReadAllLines(file.FullName);
            var fields = fileString[0].Split(',');

            AnalysisResults results = new AnalysisResults();

            results.numberOfFields = fields.Length;

            Results = results;
        }
    }
}
