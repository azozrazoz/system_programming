using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Child_process
{
    class Program
    {
        static int MathOperation(int arg1, int arg2, char op)
        {
            switch (op)
            {
                case '+':
                    return arg1 + arg2;
                    
                case '-':
                    return arg1 - arg2;

                case '/':
                    return arg1 / arg2;

                case '*':
                    return arg1 * arg2;
                default:
                    break;
            }

            return 0;
        }
        static int Main(string[] args)
        {
            // 1

            /*Console.WriteLine("Hello, this is child process!");
            Thread.Sleep(5000);

            return 12345;*/



            // 2

            /*Console.WriteLine("Hello, this is child process!");
            Thread.Sleep(10000);

            return 12345;*/



            // 3

            /*Console.WriteLine("Hello, this is child process!");
            try
            {
                int result = MathOperation(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]), Convert.ToChar(args[2]));
                Console.WriteLine($"Restul: {result}");
                Console.ReadLine();
                return 0;
            }
            catch
            {
                Console.WriteLine("Enter numbers in arguments!");
                return -1;
            }*/



            // 4

            /*int count = 0;
            Console.WriteLine("Hello, this is child process!");
            using (StreamReader reader = new StreamReader(args[0], Encoding.UTF8))
            {
                string[] text = reader.ReadToEnd().Split('\n');

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i].IndexOf(args[1]) != -1)
                        count++;
                }
            }
            Console.WriteLine($"Count: {count}");

            Console.ReadLine();
            return 0;*/
        }
    }
}
