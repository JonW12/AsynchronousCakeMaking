using System;

namespace AsynchronousCakeMaking
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Result of Synchronous cake:");
            SynchronousMaker syncMaker = new SynchronousMaker();
            syncMaker.Run();

            Console.WriteLine("Result of Asynchronous cake:");
            AsynchronousMaker asyncMaker = new AsynchronousMaker();
            await asyncMaker.Run();
        }
    }
}
