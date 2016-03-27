using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 25;
            int b = 23;
            int c = 37;

            int njw = znajdzNajwieksza(a, b, c);
            Console.WriteLine(njw);
            Console.ReadKey();
        }

        static int znajdzdruga(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {

                    if (b > c)
                    {
                        return b;
                        //Console.WriteLine("1a,2b,3c");
                    }
                    else
                    {
                        return c;
                        // Console.WriteLine("1a,2c,3b");
                    }
                }
                return a;
                //Console.WriteLine("1c,2a,3b");
            }
            else
            {
                if (b > c)
                {
                    if (c > a)
                    {

                        return c;
                        //Console.WriteLine("1b,2c,3a");
                    }
                    return a;
                    //Console.WriteLine("1b,2a,3c");
                }
                else
                {
                    return b;
                    //Console.WriteLine("1c,2b,3a");
                }
            }
        }



        static int znajdzNajwieksza(int a, int b, int c)
        {
            if (a > b)
            {
                if (a > c)
                {

                    if (b > c)
                    {
                        return a;
                        //Console.WriteLine("1a,2b,3c");
                    }
                    else
                    {
                        return a;
                       // Console.WriteLine("1a,2c,3b");
                    }
                }
                return c;
                //Console.WriteLine("1c,2a,3b");
            }
            else
            {
                if (b > c)
                {
                    if (c > a)
                    {

                        return b;
                        //Console.WriteLine("1b,2c,3a");
                    }
                    return b;
                    //Console.WriteLine("1b,2a,3c");
                }
                else
                {
                    return c;
                    //Console.WriteLine("1c,2b,3a");
                }
            }
        }
    }
}

