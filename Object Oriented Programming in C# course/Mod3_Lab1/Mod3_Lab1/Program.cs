using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader streamReaderObject = null;

            try
            {
                streamReaderObject = new StreamReader("file1.txt");

                string contents = streamReaderObject.ReadToEnd();

                streamReaderObject.Close();
                Console.WriteLine("The file has {0} text elements", new StringInfo(contents).LengthInTextElements);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (streamReaderObject != null)
                {
                    streamReaderObject.Close();
                    streamReaderObject.Dispose();
                }
                    
            }
            
        }
    }
}
