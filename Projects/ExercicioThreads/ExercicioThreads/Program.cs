using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExercicioThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Executivo ex = new Executivo();
            Thread ola = new Thread(ex.ImprimeOla);
            Thread thread = new Thread(ex.ImprimeThreads);
            ola.Start();
            thread.Start();
            
        }
    }
}
