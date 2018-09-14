using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mod3_SelfAsses
{
    abstract class Person : IDisposable
    {
        private string m_name;
        private int m_age;

        public Person(string name, int age) {
            m_name = name;
            m_age = age;
        }

        //~Person() {
        //    Dispose();
        //}

        public string Name {
            get => m_name;
        }
        public int Age {
            get => m_age;

        }

        public void writeInfo()
        {
            // or use using
            string filename = this.Name + ".txt";
            StreamWriter sr = null;
            try
            {
                sr = new StreamWriter(filename);
                // Assigns "streamReaderObject" to read from a text file named "file1"               
                sr.WriteLine(m_name);
            }

            // Code to handle any errors
            catch (FileNotFoundException)
            {
                // Informs user there is no file created
                Console.WriteLine("The file cannot be written.");
            }

            // Invoking the Dispose method in a finally block
            // Note that code in finally block will always execute
            finally
            {
                // Checks if object is not null
                if (sr != null)
                {
                    // Closes StreamReader
                    sr.Close();

                    // Calls upon the Dispose method
                    // Releases all resources used by the TextReader object
                    sr.Dispose();
                }

            }
            

        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Person() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
