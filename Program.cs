using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex_1();
            Ex_2();
            Ex_3();
        }

        static void Ex_1()
        {
            try
            {
                double z1, z2, a;
                Console.Write("a = ");
                a = Convert.ToInt32(Console.ReadLine());

                z1 = Math.Cos(a) + Math.Sin(a) + Math.Cos(3 * a) + Math.Sin(3 * a);
                z2 = 2 * Math.Sqrt(2) * Math.Cos(a) * Math.Sin(Math.PI / 4 + 2 * a);

                Console.WriteLine("z1 = {0}", z1);
                Console.WriteLine("z2 = {0}", z2);
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ex_2()
        {
            int a, b, x;
            double y;

            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());

            //if (3 * a > b) y = Math.Log(x * x) - Math.Exp(x / 3);
            //else y = Math.Atan(2 * x - 0.6);

            y = (3 * a > b) ? Math.Log(x * x) - Math.Exp(x / 3) : Math.Atan(2 * x - 0.6);
            Console.WriteLine("y = {0}", y);
        }

        static void Ex_3()
        {
            int year;
           
            Console.Write("Year number = ");
            year = Convert.ToInt32(Console.ReadLine());

            switch (year % 12)
            {
                case 0:
                    Console.WriteLine("{0} - год обезьяны", year);
                    break;
                case 1:
                    Console.WriteLine("{0} - год петуха", year);
                    break;
                case 2:
                    Console.WriteLine("{0} - год собаки", year);
                    break;
                case 3:
                    Console.WriteLine("{0} - год свиньи", year);
                    break;
                case 4:
                    Console.WriteLine("{0} - год крысы", year);
                    break;
                case 5:
                    Console.WriteLine("{0} - год коровы", year);
                    break;
                case 6:
                    Console.WriteLine("{0} - год тигра", year);
                    break;
                case 7:
                    Console.WriteLine("{0} - год зайца", year);
                    break;
                case 8:
                    Console.WriteLine("{0} - год дракона", year);
                    break;
                case 9:
                    Console.WriteLine("{0} - год змеи", year);
                    break;
                case 10:
                    Console.WriteLine("{0} - год лошади", year);
                    break;
                case 11:
                    Console.WriteLine("{0} - год овцы", year);
                    break;
            }
        }
    }
}
