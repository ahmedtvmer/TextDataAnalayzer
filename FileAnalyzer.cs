using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalayzer
{
    internal abstract class FileAnalyzer
    {
        private AnalysisResults _results;
        public AnalysisResults Results
        { 
            get { return _results; }
            set { _results = value; }
        }
    }
}
