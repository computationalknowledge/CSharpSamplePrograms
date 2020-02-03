using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            (new WorkerClass()).DoStuff();
            Console.WriteLine(WorkerClass.Sum);
        }
    }
    class WorkerClass
    {
        public static int Sum;
        public void DoStuff()
        {   // add the numbers from 6000 down to 200
            // count down by 250 each iteration
            // add up each number you step over
            // output the result
            int Value = 6000;
            while (Value >= 200)
            {
                Sum += Value;
                Value -= 250;
            }

        }
    }
}
