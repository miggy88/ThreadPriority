using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPriority
{
    class MyThreadClass
    {
        static void Thread1()
        {

            for (int loopcount = 1; loopcount < 2; loopcount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread " + thread.Name + " = " + loopcount );
                Thread.Sleep(500);


            }

      



        }

        static void Thread2()
        {
            for (int loopcount = 1; loopcount < 6; loopcount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread " + thread.Name + " = " + loopcount);
                Thread.Sleep(1500);

            }


        }
    }
}
