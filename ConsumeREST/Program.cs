using System;

namespace ConsumeREST
{
    class Program
    {
        static void Main(string[] args)
        {
            RestWorker worker = new RestWorker();
            worker.Start();

            Console.ReadLine();
        }
    }
}
