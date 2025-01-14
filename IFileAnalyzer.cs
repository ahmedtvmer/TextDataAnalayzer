using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalayzer
{
    internal interface IFileAnalyzer
    {
        void AnalyzeFile(FileInfo file);
    }
}
