using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLearning
{
    class Program
    {
        private static readonly object _lock = new object();
        private static readonly Random rnd = new Random();

        private static readonly AutoResetEvent re = new AutoResetEvent(true);
        private static readonly Mutex mutex = new Mutex();
        private static int count = 0;

        static void Main(string[] args)
        {
            /*Thread[] threads = new Thread[4];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(Printers);
                threads[i].Start();
            }
            foreach (var th in threads)
                th.Join();
            Console.ReadLine();*/

            var proccessorCount1 = Environment.TickCount;
            var proccessorCount2 = Environment.ProcessorCount;
            var proccessorCount3 = Environment.CommandLine;
            Console.WriteLine(proccessorCount1);
            Console.WriteLine("main process");

            var pthr = new Thread(new ParameterizedThreadStart(Print));
            //pthr.Start("HEllO");
            //pthr.Start(343);
            //pthr.Start(new object());
            Console.ReadLine();
        }

        static void Printers()
        {
            re.WaitOne();
            Console.WriteLine("Первый принтер");
            //Thread.Sleep(rnd.Next(200, 1000));
            re.Set();

            Console.WriteLine("Второй принтер");            
        }

        static void Counter()
        {
            lock (_lock)
            {
                for (int i = 0; i < 10; i++)
                {
                    count++;
                    Console.WriteLine(count);
                }
            }
        }

        static void Print(object msg)
        {
            switch (msg)
            {
                case string str:
                    Console.WriteLine($"String: {str}");
                    break;
                case int num:
                    Console.WriteLine($"Int: {num}");
                    break;
                default:
                    Console.WriteLine($"Object: {msg}");
                    break;
            }
        }
    }
    /*internal class Semaphore
    {
        private readonly Semaphore _semaphore = new Semaphore(3, 5);
        private int _count = 5;

        public SemaphoreTest(int i)
        {
            new Thread(Read) { Name = $"Поток {i}" }.Start();
        }
        public void Read()
        {
            while(_count > 0)
            {
                _semaphore.WaitOne();
            }
        }        
    }*/
}
