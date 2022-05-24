using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project2
{
    class MultiCellBuffer
    {
        public string[] buffer;
        private int N = 5, n = 2, elements; // N=5, and n = 2 for individual projects
        private static Semaphore write, read; 

        public MultiCellBuffer(int n) 
        {
            lock (this) 
            {
               elements = 0; 
                if (n <= N)
                {
                    this.n = n;
                    write = new Semaphore(n, n);
                    read = new Semaphore(n, n);
                    buffer = new string[n]; 

                    for (int i = 0; i < n; i++)
                    {
                        buffer[i] = "_";
                    }
                }
            }
        }
        public void setOneCell(string data) {
            write.WaitOne();
            lock (this)
            {
                while (elements == n)
                {
                    Monitor.Wait(this);
                }

                for (int i = 0; i < n; i++)
                {
                    if (buffer[i] == "_") 
                    {
                        buffer[i] = data;
                        elements++;
                        i = n; 
                    }
                }
                write.Release();
                Monitor.Pulse(this);
            }
        }
        public string getOneCell() {
            read.WaitOne();
            string output = string.Empty;
            lock (this)
            {
                while (elements == 0) 
                {
                    Monitor.Wait(this);
                }

                for (int i = 0; i < n; i++)
                {
                    if (buffer[i] != "_") 
                    {
                        output = buffer[i];
                        buffer[i] = "_";
                        elements--;
                        i = n; 
                    }
                }
                read.Release();
                Monitor.Pulse(this);
            }
            return output;
        }
    
    }
}
