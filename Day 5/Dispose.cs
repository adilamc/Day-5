using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    //Dispose pattern
    public class Customer:IDisposable
    {
        private StringReader _reader;
        //to detect deduntant calls
        private bool disposed = false;
        public Customer(string value)
        {
            this._reader = new StringReader(value);

        }
        protected virtual void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    if(_reader !=null)
                    {
                        this._reader.Dispose();
                    }
                }
            }
            disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
    class sample
    {
        public static void Main()
        {
            Customer c = new Customer("Sample");
            Console.ReadLine();
        }
    }
}
