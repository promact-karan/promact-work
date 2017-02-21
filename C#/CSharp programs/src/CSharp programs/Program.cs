using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp_programs
{
    class A
    {
        public int funcA(int a)
        {
            return a * 2;
        }
    }
    class B
    {
        public int funcB(int b)
        {
            return b * 3;
        }
    }
    class c
    {
        public int funcC(int c)
        {
            return c * 5;
        }
    }

    class D
    {
        static void Main(string[] args)
        {
            int NewValue, temp, countA = 0, countB = 0, countC = 0;
            Boolean res = true;
            Console.WriteLine("Enter New Value::");
            NewValue = int.Parse(Console.ReadLine());
            temp = NewValue;
            A objA = new A();
            B objB = new B();
            c objC = new c();

            if (NewValue == 1)
            {
                res = false;
            }
            else
            {
                do
                {
                    if (temp % 2 != 0 && temp % 3 != 0 && temp % 5 != 0)
                    {
                        res = false;
                        break;
                    }
                    else if (temp % 2 == 0)
                    {
                        temp = temp / 2;
                        countA++;
                    }
                    else if (temp % 3 == 0)
                    {
                        temp = temp / 3;
                        countB++;
                    }
                    else if (temp % 5 == 0)
                    {
                        temp = temp / 5;
                        countC++;
                    }
                    else
                    {
                        break;
                    }
                } while (temp != 1);
            }
            if (res == false)
            {
                Console.WriteLine("New Value is not only 2,3 and 5 as its prime factor");
            }
            else
            {
                Console.WriteLine("A's function is called: " + countA);
                Console.WriteLine("B's function is called: " + countB);
                Console.WriteLine("C's function is called: " + countC);
            }
            Console.ReadLine();
        }
    }
}
