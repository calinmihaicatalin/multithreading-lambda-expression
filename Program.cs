using System.Diagnostics.Metrics;
using System.Threading;

namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {//thread = execution path of a program
         //using System.Threading

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            //Console.WriteLine(mainThread.Name);

            //Thread thread1 = new Thread(CountDown);
            //Thread thread2 = new Thread(CountUp;
            Thread thread1 = new Thread(() => CountDown("Timer #1"));
            Thread thread2 = new Thread(() => CountUp("Timer #2"));

            thread1.Start();
            thread2.Start();

            //CountDown();
            //CountUp();

            Console.WriteLine(mainThread.Name + " is complete!");
            Console.ReadKey();
        }
        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {

                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);//miliseconds
            }
            Console.WriteLine("Timer #1 is complete!");

        }
        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {

                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000); 
            }
            Console.WriteLine("Timer #2 is complete!");
        }
    }
}
