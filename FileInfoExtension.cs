using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TextDataAnalayzer
{
    public static class FileInfoExtension
    {
        public static bool IsTxtfile(this FileInfo fileInfo)
        {
            return (fileInfo.Extension == ".txt");
        }

        public static bool IsCsvfile(this FileInfo fileInfo)
        {
            return (fileInfo.Extension == ".csv");
        }   
    }
}
