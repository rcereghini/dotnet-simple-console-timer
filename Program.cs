using System;
using System.Timers;

namespace myApp
{
    class Program
    {
        static int ticks = 1;
        private static Timer theTimer;

        static void Main(string[] args)
        {
            theTimer = new System.Timers.Timer();
            theTimer.Interval = 1000;
            theTimer.Elapsed += onTimerTick;

            theTimer.AutoReset = true;
            theTimer.Enabled = true;
            
            Console.WriteLine("Press the Enter key to exit the program at any time... ");
            Console.ReadLine();
        }

    private static void onTimerTick(Object source, System.Timers.ElapsedEventArgs e){
        Console.WriteLine("The time is now: " + DateTime.Now);
        Console.WriteLine(ticks + " seconds have passed.");
        ticks++;
    }
    }
}
