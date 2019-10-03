using System;

namespace MyHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //11
            Console.WriteLine("Дюймы\tСантиметры");
            for (int i = 10; i < 23; i++)
                Console.WriteLine("{0}\t{1}", i, (double)(i * 2.54));

            Console.ReadLine();
        }


        public static void Test1()
        {
            //15
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(string.Format("{0}*{1}={2}", 7, i, 7 * i));
            }
            Console.ReadKey();


        }

        public static void Test2()
        {
            //16
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(string.Format("{0}*{1}={2}", 9, i, 9 * i));
            }
            Console.ReadKey();

        }

        public static void Test3()
        {
            //9
            for (int i = 1; i < 21; i++)
                Console.WriteLine("{0}\t{1}", i, (double)(i* 20.4));
            Console.ReadLine();
        }


        public static void Test4()
        {
            //17
            Console.WriteLine("Введи любое число");

            string y = Console.ReadLine();
            double t;
            t = Convert.ToDouble(y);
            for (int i = 1; i < 10; ++i)
                Console.WriteLine("{0}*{1}={2}", t, i, t * i);
            Console.ReadLine();
        }
        public static void Test5()
        {
            //23
            Console.WriteLine("Введите цену для 1 КГ Сыра :");
            string y = Console.ReadLine();
            double t, i;
            t = Convert.ToDouble(y);
            Console.WriteLine("KG\tPRICE");
            for (i = 0.05; i <= 1.05; i += 0.05)
                Console.WriteLine("{0}\t{1}", i, t * i);
            Console.ReadKey();
        }

        public static void Test6()
        {
            //10
            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine(i+ "funt = " + i*0.453 + "kg");
            }
                
        }


        public static void Test7()
        {
            long g = 123456789;
            long d = 9;
            long result = 0;

            for (int a = 1; a <=9; a++)
            {
                result = g * d;
                Console.WriteLine(result);
                d += 9;
            }
            Console.ReadLine();
                
        }




    }
}
