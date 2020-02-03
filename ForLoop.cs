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
            for (int i = 6000; i >= 200 ; i=i-250) {
                Sum += i;
            }

        }
    }
}
