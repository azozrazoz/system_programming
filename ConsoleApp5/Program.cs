using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // МОНИТОРИНГ ПРОЦЕССА CHROME


            /*while (true)
            {
                var processes = Process.GetProcessesByName("chrome").OrderBy(x => x.ProcessName);

                foreach (var process in processes)
                {
                    Console.WriteLine($"{process.Id}\t{process.ProcessName}\t{process.PagedMemorySize64}");
                }
                Thread.Sleep(250);
                Console.Clear();
            }*/


            //  МАНИПУЛИРОВАНИЕ ПРОЦЕССАМИ


            /*
            Console.Write("Введите имя процесса: ");
            string ProcessName = Console.ReadLine();
            int command = 1;
            while (command != 0)
            {
                Console.WriteLine("1 - Завершить процесс, 2 - Запустить процесс");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        KillProcess(ProcessName);
                        break;
                    case 2:
                        Console.Write("Введите аргументы процесса: ");
                        string ProcessArguments = Console.ReadLine();
                        StartProcess(ProcessName, ProcessArguments);
                        break;
                }
            }
            Console.WriteLine("Программа завершилась успешно!");
            Thread.Sleep(2500);*/



            var @class = new TestClass


        }

        static void StartProcess(string ProcessName, string ProcessArguments)
        {
            Process process = new Process();
            process.StartInfo.FileName = ProcessName;
            process.StartInfo.Arguments = ProcessArguments;
            process.Start();
        }

        static void KillProcess(string ProcessName)
        {
            var ProcessToKill = Process.GetProcessesByName(ProcessName);
            foreach (var process in ProcessToKill)
            {
                process.Kill();
            }
        }    
    }
}
