using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_01
{
    class Program
    {
        static int Main(string[] args)
        {
            // 1

            /*Console.WriteLine("Hello, this is parent process!");

            Process process = new Process();
            process.StartInfo.FileName =
                @"C:\Users\Дошан\source\repos\system_programming\Home_work_01\Child_process\bin\Debug\Child_process.exe";

            process.Start();
            process.WaitForExit();
            process.Exited += Process_exited;
            Console.WriteLine($"Code exit: {process.ExitCode}");
            Console.ReadLine();*/



            // 2

            /*Console.WriteLine("Hello, this is parent process!");

            Process process = new Process();
            process.StartInfo.FileName =
                @"C:\Users\Дошан\source\repos\system_programming\Home_work_01\Child_process\bin\Debug\Child_process.exe";
            process.Start();

            string command = Console.ReadLine();
            if (command == "exit")
            {
                process.Kill();
            }

            process.WaitForExit();
            process.Exited += Process_exited;
            Console.WriteLine($"Code exit: {process.ExitCode}");
            Console.ReadLine();*/



            // 3

            /*Console.WriteLine("Hello, this is parent process!");

            Console.Write("Enter first argument: ");
            string arg1 = Console.ReadLine();
            Console.Write("Enter second argument: ");
            string arg2 = Console.ReadLine();
            Console.Write("Enter operation: ");
            string op = Console.ReadLine();


            Process process = new Process();
            process.StartInfo.FileName =
                @"C:\Users\Дошан\source\repos\system_programming\Home_work_01\Child_process\bin\Debug\Child_process.exe";
            process.StartInfo.Arguments = $"{arg1} {arg2} {op}";
            process.Start();
            process.Exited += Process_exited;


            Console.ReadLine();
            return 0;*/



            // 4

            /*Console.WriteLine("Hello, this is parent process!");
            Console.Write("Enter path to file: ");
            string pathToFile = Console.ReadLine();
            Console.Write("Enter path to file: ");
            string word = Console.ReadLine();

            Process process = new Process();
            process.StartInfo.FileName =
                @"C:\Users\Дошан\source\repos\system_programming\Home_work_01\Child_process\bin\Debug\Child_process.exe";
            process.StartInfo.Arguments = $"{pathToFile} {word}";
            process.Start();
            process.Exited += Process_exited;


            Console.ReadLine();
            return 0;*/
        }

        static void Process_exited(object sender, EventArgs e)
        {
            Console.WriteLine("Process exit");
        }
    }
}
