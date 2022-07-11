using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            Console.WriteLine(MyMathLibrary.MyMath.AreaSquare(34));
            Console.WriteLine(MyMathLibrary.MyMath.AreaRectangle(34, 23));
            Console.WriteLine(MyMathLibrary.MyMath.AreaTriangle(34, 23, 3));



            //2

            
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            Console.WriteLine($"Это полиндром: {MyStringLibrary.Text.Palindrom(text)}");
            Console.WriteLine($"Количество предложений: {MyStringLibrary.Text.SentenceCount(text)}");
            Console.WriteLine($"Перевернутый текст: {MyStringLibrary.Text.Reverse(text)}");



            //3

            MyUsers.User user = new MyUsers.User()
            {
                FullName = "Doshan",
                PhoneNumber = "+79261234567",
                Age = "16",
                Email = "doshan@example.com",
            };
            Console.WriteLine(MyUsers.User.CheckFullName(user.FullName));
            Console.WriteLine(MyUsers.User.CheckAge(user.Age));
            Console.WriteLine(MyUsers.User.CheckPhoneNumber(user.PhoneNumber));
            Console.WriteLine(MyUsers.User.CheckEmail(user.Email));



            //4
            string[] files = new string[]
            {
                "test_2.txt",
                "test_3.txt",
                "test_4.txt",
            };
            MyUsers.FileLibrary.CopyFile("D:\\test_1.txt", "D:\\CopyDir\\test_2.txt");
            MyUsers.FileLibrary.CopyDirectoryes("D:\\CopyDir", "D:\\CopyDir_2");
            MyUsers.FileLibrary.DeleteFile("D:\\", "test_1.txt");
            MyUsers.FileLibrary.DeleteFiles("D:\\CopyDir", files);
            MyUsers.FileLibrary.DeleteFiles("D:\\CopyDir_2", ".txt");
            MyUsers.FileLibrary.CutFile("D:\\test_1.txt", "D:\\CopyDir");



            //5
            MyUsers.FileLibrary.SearchWordInFile("D:\\test_1.txt", "text");
            MyUsers.FileLibrary.SearchWordInDirectory("D:\\", "text");

            Console.ReadKey();
        }
    }
}
