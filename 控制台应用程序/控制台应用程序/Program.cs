﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台应用程序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!!");
            Console.ReadLine();
            Console.WriteLine("请输入以下计算的结果,按回车结束");

            Random randomClass = new Random();
            int number1, number2, result;
            while (true)
            {
                number1 = randomClass.Next(1, 100);
                number2 = randomClass.Next(1, 100);
                result = number1 + number2;

                Console.Write("{0}+{1}=", number1, number2);
                int userResult;
                userResult = Convert.ToInt16(Console.ReadLine());
                if (userResult == result)
                {
                    Console.WriteLine("right!");
                    break;
                }
                else
                {
                    Console.WriteLine("erron!");
                }
                Console.WriteLine("github 的同步是什么作用我实在是弄不懂");
            }
            Console.ReadLine();
        }
    }
}
