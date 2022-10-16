using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Declareint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //計算1+(2+2)*3-1
            int sum = 1 + (2 + 2) * 3 - 1;
            Console.WriteLine("1+(2+2)*3-1=" + sum.ToString());
            //求120/7的商以及餘數各是多少
            int result = 120 / 7;
            Console.WriteLine("120/7的商數是" + result.ToString());
            int remainder = 120 % 7;
            Console.WriteLine("120/7的餘數是" + remainder.ToString());
            //判斷9,202個別是奇數或偶數
            //判斷9是奇數或偶數
            int num1 = 9 % 2;
            if (num1 == 0)
                Console.WriteLine("9是偶數");
            else
                Console.WriteLine("9是奇數");
            //判斷202是奇數或偶數
            int num2 = 202 % 2;
            if (num2 == 0)
                Console.WriteLine("202是偶數");
            else
                Console.WriteLine("202是奇數");
        }
    }
}
