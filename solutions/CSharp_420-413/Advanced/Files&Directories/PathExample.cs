using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_420_413.Advanced.Files_Directories
{
    internal class PathExample
    {
        public static void PathMethods()
        {
            string path1 = @"c:\temp\MyTest.txt";
            string path2 = @"c:\temp\MyTest";
            string path3 = @"temp";
            string result1 = Path.ChangeExtension(@"C:\fichiers.txt", "doc");         // result = "C:\fichiers.doc"
            string result2 = Path.Combine(@"C:\Dossier1", "Dossier2", "fichier.txt"); // result = "C:\Dossier1\Dossier2\fichiers.txt”

            if (Path.HasExtension(path1))
            {
                Console.WriteLine("{0} has an extension.", path1);
            }

            if (!Path.HasExtension(path2))
            {
                Console.WriteLine("{0} has no extension.", path2);
            }

            if (!Path.IsPathRooted(path3))
            {
                Console.WriteLine("The string {0} contains no root information.", path3);
            }

            Console.WriteLine("The full path of {0} is {1}.", path3, Path.GetFullPath(path3));
            Console.WriteLine("{0} is the location for temporary files.", Path.GetTempPath());
            Console.WriteLine("{0} is a file available for use.", Path.GetTempFileName());

            /* This code produces output similar to the following:
             * c:\temp\MyTest.txt has an extension.
             * c:\temp\MyTest has no extension.
             * The string temp contains no root information.
             * The full path of temp is D:\Documents and Settings\cliffc\My Documents\Visual Studio 2005\Projects\ConsoleApplication2\ConsoleApplication2\bin\Debug\temp.
             * D:\Documents and Settings\cliffc\Local Settings\Temp\8\ is the location for temporary files.
             * D:\Documents and Settings\cliffc\Local Settings\Temp\8\tmp3D.tmp is a file available for use.
             */
        }
    }
}
