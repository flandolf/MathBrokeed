using System;
using System.IO;
using System.Threading;

namespace MathSucks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Double i;
            Double ib;
            Console.WriteLine("[C]alculate? or [G]enerate");
            string a = Console.ReadLine();
            Console.WriteLine("What number to go by? e.g 2, 4 ,3");
            int o = Convert.ToInt32(Console.ReadLine());

            if (a == "C")
            {
                Console.WriteLine("Whats your number?");
                Double d = Convert.ToDouble(Console.ReadLine());
                Double db = d;
                d = d + o;
                d = d * o;
                d = d - o;
                d = d / o;
                d = d - db;
                Console.WriteLine(d);
                Console.ReadKey();

            }

            if (a == "G")
            {
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    for (int z = 0; z < 100; z++)
                    {
                        double TOLERANCE = 1;
                        for (int j = 0; j < 100; j++)
                        {
                            i = 0;
                            ib = 0;
                            i = r.NextDouble();
                            ib = i;
                            i = i + o;
                            i = i * o;
                            i = i - o;
                            i = i / o;
                            i = i - ib;
                            if (Math.Abs(i - 1) > TOLERANCE)
                            { 
                                sw.WriteLine(ib);
                                Console.WriteLine("Found one: " + ib);
                            }
                            else
                            {
                                Console.WriteLine("Failed! " + ib);
                            } 
                        }
                    }
                    sw.Close();

                }
            }
            
            
        }
    }
}
