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
            Console.WriteLine(MyMathLibrary.MyMath.AreaSquare(34));
            Console.WriteLine(MyMathLibrary.MyMath.AreaRectangle(34, 23));
            Console.WriteLine(MyMathLibrary.MyMath.AreaTriangle(34, 23, 3));
            Console.ReadKey();
        }
    }
}
