﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_SelfAssessLab
{
    abstract class Person : IDisposable
    {
        protected string _firstName;
        protected string _lastName;
        protected int _age;
        private StreamWriter sr;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }

        public Person(string name, string lastName, int age)
        {
            FirstName = name;
            LastName = lastName;
            Age = age;
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected void WriteRelevantInfo(List<string> strings, string filename)
        {
            if (disposedValue)
            {
                throw new ObjectDisposedException(this.GetType().Name);
            }

            try
            {
                sr = new StreamWriter(filename);
                foreach (string s in strings)
                {
                    sr.WriteLine(s);
                }
            }
            catch (Exception e) when (e is System.Security.SecurityException || e is IOException) 
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }
                   
        }

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
                sr?.Dispose();
                sr = null;

                disposedValue = true;
            }
        }

        //TODO: override a finalizer only if dispose(bool disposing) above has code to free unmanaged resources.
        ~Person()
        {
            // do not change this code. put cleanup code in dispose(bool disposing) above.
            Dispose(false);
        }

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