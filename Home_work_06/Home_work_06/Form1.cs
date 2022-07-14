using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_work_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenBanWords.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        string path;

        private void button2_Click(object sender, EventArgs e)
        {
            if (OpenBanWords.ShowDialog() == DialogResult.OK)
                tbBanWords.Text = File.ReadAllText(OpenBanWords.FileName);
        }

        private void ChooseFolder_Click(object sender, EventArgs e)
        {
            if (FolderForBanWords.ShowDialog() == DialogResult.OK)
                path = FolderForBanWords.SelectedPath;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string[] banWords = tbBanWords.Text.Split(' ', '\r', '\n');

            if(tbMainPath.Text != "")
            {
                if (Directory.Exists(tbMainPath.Text))
                {
                    var files = Directory.GetFiles(tbMainPath.Text, "*.txt");
                    Task[] tasks = new Task[files.Length];                    

                    for (int i = 0; i < files.Length; i++)
                    {
                        for (int t = 0; t < banWords.Length; t++)
                        {
                            tasks[i] = new Task(() => SearchBanWords(files[i], banWords[t]));
                            tasks[i].Start();
                            tasks[i].Wait();
                            Thread.Sleep(1);
                        }
                        Task.WaitAll();
                    }


                    if (!File.Exists($"{path}\\result.txt"))
                    {
                        File.Create($"{path}\\result.txt");
                        using (StreamWriter writer = new StreamWriter($"{path}\\result.txt"))
                        {
                            writer.Write(result + $"Maximum: {maxResult}");
                            writer.Close();
                        }
                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter($"{path}\\result.txt"))
                        {
                            writer.Write(result + $"Maximum: {maxResult}");
                            writer.Close();
                        }
                    }

                    for (int i = 0; i < files.Length; i++)
                    {
                        var pathTo = path + "\\" + files[i].Split('\\').Last();
                        string finalResult = "";
                        MyUsers.FileLibrary.CopyFile(files[i], pathTo);
                        using(StreamReader reader = new StreamReader(pathTo))
                        {
                            finalResult = reader.ReadToEnd().ToLower();
                            for (int j = 0; j < banWords.Length; j++)
                            {
                                finalResult = finalResult.Replace(banWords[j], "*******");
                            }
                                
                            reader.Close();
                        }
                        using(StreamWriter writer = new StreamWriter(pathTo))
                        {
                            writer.WriteLine(finalResult);
                            writer.Close();
                        }
                    }

                    result = "";
                    maxCount = 0;
                    maxResult = "";
                    MessageBox.Show($"Файлы изменены и скопированы в {path}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                tbMainPath.Text = "Введите путь к файлам!";
        }

        string result;
        string maxResult;
        int maxCount = 0;

        private void SearchBanWords(string path, string word)
        {            
            int count = 0;
            
            FileStream file = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);

            string[] text = reader.ReadToEnd().ToLower().Split(' ', '\r', '\n');

            reader.Close();

            foreach (var t in text)
                if (t == word)
                    count++;

            result += $"{word}\t{count}\r\n";

            if(count > maxCount)
            {
                maxCount = count;
                maxResult = $"{word}\t{count}\r\n";
            }
            else if(count == maxCount)
                maxResult += $"{word}\t{count}\r\n";
        }
    }
}
