using System;

namespace LogicalProblems
{
    internal class Stopwatch
    {
        public void StopWatchtime()
        {
            Console.WriteLine("Press Enter to start");
            Console.ReadLine();
            DateTime Start = DateTime.Now;

            Console.WriteLine("Press Enter to Stop");
            Console.ReadLine();
            DateTime Stop = DateTime.Now;

            Console.WriteLine("Elapsed Time= " + (Stop - Start));
        }
    }
}