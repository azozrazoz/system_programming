using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Home_work_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainPath = "D:\\";

            List<string> files = new List<string>();


            foreach (var f in Directory.GetFiles(mainPath))
                if (f.EndsWith(".txt"))
                    files.Add(f);

            int[] counts = new int[files.Count];

            Task<int>[] tasks = new Task<int>[files.Count];
            for(int i = 0; i < files.Count; i++)
            {
                tasks[i] = new Task<int>(() => WordCount(files[i]));
                tasks[i].Start();
                counts[i] = tasks[i].Result;
                tasks[i].Wait();
            }

            for(int i = 0; i< files.Count; i++)
            {
                Console.WriteLine($"{files[i]} === {counts[i]}");
            }

            Console.ReadLine();
        }

        static int WordCount(string path)
        {
            using (StreamReader reader = new StreamReader(path))
                return reader.ReadToEndAsync().Result.Split(' ', '\n').Length;
        }
    }
}
