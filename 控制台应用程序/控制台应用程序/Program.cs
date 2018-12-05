using System;
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
            string name,sayHello;

            name = "wuzhixin";
            sayHello = "    hello world   ";

            Console.WriteLine($"hello world!!{name}"+name);
            Console.WriteLine($"my name is {name} it has {name.Length} letters");
            Console.WriteLine(sayHello);
            Console.WriteLine($"[{sayHello}]");
            string sayTrimmed = sayHello.TrimStart();
            Console.WriteLine($"[{sayTrimmed}]");
            sayTrimmed = sayHello.TrimEnd();
            Console.WriteLine($"[{sayTrimmed}]");
            sayTrimmed = sayHello.Trim();
            Console.WriteLine($"[{sayTrimmed}]");
            string sayReplaced = sayHello.Replace("wo", "xiahan");
            Console.WriteLine($"[{sayReplaced}]");
            sayReplaced = sayHello.ToUpper();
            Console.WriteLine($"[{sayReplaced}]");
            Console.WriteLine(sayReplaced);
            sayReplaced = sayReplaced.ToLower();
            Console.WriteLine(sayReplaced);

            string iSpeakSomething = "我叫吴智鑫我想学习我爱学习";

            Console.WriteLine(iSpeakSomething.Contains("吴智鑫"));
            Console.WriteLine(iSpeakSomething.StartsWith("我叫吴智鑫"));
            Console.WriteLine(iSpeakSomething.EndsWith("我爱学习"));

            double maxNumber = double.MaxValue;
            double minNumber = double.MinValue;
            Console.WriteLine($"double 's max value is {maxNumber} min value is {minNumber}");



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
                    break;
                }
                Console.WriteLine("github 的同步是什么作用我实在是弄不懂");
            }
            Console.ReadLine();
        }
    }
}
