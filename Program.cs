namespace TextDataAnalayzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to File Analyzer");
            Console.WriteLine("------------------------");
            Console.WriteLine("Please enter the folder path:");

            string directoryPath = Console.ReadLine();

            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

            if(directoryInfo.Exists is false)
            {
                Console.WriteLine("This path does not exist");
                return;
            }

            var fileNames = directoryInfo.GetFiles();

            IFileAnalyzer fileAnalyzer = null;

            foreach( var file in fileNames)
            {
                if (file.IsTxtfile())
                {
                    fileAnalyzer = new TxtFileAnalyzer();
                    fileAnalyzer.AnalyzeFile(file);
                    AnalysisResults results = ((FileAnalyzer)fileAnalyzer).Results;

                    Console.WriteLine($"File Name: {file.Name}");
                    Console.WriteLine($"Words Count: {results.numberOfWords}");
                    Console.WriteLine($"Characters Count: {results.numberOfChars}");
                    Console.WriteLine($"Lines Count: {results.numberOfLines}\n");
                }
                else if (file.IsCsvfile())
                {
                    fileAnalyzer = new CsvFileAnalyzer();
                    fileAnalyzer.AnalyzeFile(file);
                    AnalysisResults results = ((FileAnalyzer)fileAnalyzer).Results;

                    Console.WriteLine($"File Name: {file.Name}");
                    Console.WriteLine($"Fields Count: {results.numberOfFields}\n");
                }
                else 
                    return;
            }
        }
    }
}
