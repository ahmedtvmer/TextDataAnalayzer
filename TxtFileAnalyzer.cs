using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalayzer
{
    internal class TxtFileAnalyzer : FileAnalyzer, IFileAnalyzer
    {
        public void AnalyzeFile(FileInfo file)
        {
            string fileString = File.ReadAllText(file.FullName);
            string[] words = fileString.Split(new char[] { ' ', '\n', '\r' });

            AnalysisResults results = new AnalysisResults();

            results.numberOfWords = words.Length;
            results.numberOfChars = fileString.Length;

            string[] lines = fileString.Split(new char[] { '\n', '\r' });
            results.numberOfLines = lines.Length;

            Results = results;  
        }
    }
}
