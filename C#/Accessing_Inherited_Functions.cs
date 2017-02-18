using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
	// program Details URl https://www.hackerrank.com/challenges/accessing-inherited-functions
    
    class A
    {
        public int funcA(int compare,int startcal)
            {
            int repeatA=0;
            do
            {
                startcal = startcal * 2;
                repeatA++;
            } while (startcal == compare);
            Console.WriteLine(" A's func will be called " +repeatA);
            return startcal;
            }
    }

    class B 
    {
        public int funcB(int compare,int startcal)
        {
            int repeatB = 0;
            do
            {
                startcal = startcal * 3;
                repeatB++;
            } while (compare == startcal);
            Console.WriteLine(" B's func will be called " +repeatB);
            return compare;
        }

           
    }   

    class c 
    {
       public void funcC(int compare, int startcal)
       {
            int repeatC = 0;
            do
            {
                startcal = startcal * 5;
                repeatC++;
            } while (compare == startcal);
            Console.WriteLine(" C's func will be called " +repeatC);
     
        }
           

    }

    class D 
    {
        static void Main(string[] args)
        {
            int temp1, temp2, temp3, NewValue,ans,startcal;
            Console.WriteLine("Enter New Value::");
            NewValue=int.Parse(Console.ReadLine());

            A objA = new A();
            B objB = new B();
            c objC = new c();

            if (NewValue % 5 == 0)
            {
                temp3 = NewValue / 5;
                if (temp3 % 3 == 0)
                {
                    temp2 = temp3 / 3;
                    if (temp2 % 2 == 0)
                    {
                        temp1 = temp2 / 2;
                        startcal = objA.funcA(temp1, 1);
                        startcal = objB.funcB(temp2, startcal);
                        objC.funcC(temp3, startcal);
                    }
                    else
                    {
                        Console.WriteLine("New Value is not only 2,3 and 5 as its prime factor");
                    }
                }   
            
                 else if (temp3 % 2 == 0)
                {
                    temp1 = temp3 / 2;
                    startcal = objA.funcA(temp1, 1);
                    objC.funcC(temp3, startcal);
                }
                 else if (NewValue == 5)
                 {
                      Console.WriteLine(" C's func will be called 1");
                 }
                 else
                 {
                Console.WriteLine("New Value is not only 2,3 and 5 as its prime factor");
                 }     
            }
            else if(NewValue % 3 == 0)
            {
                temp2 = NewValue / 3;
                if(temp2 % 2 == 0)
                {
                    temp1 = temp2 / 2;
                    startcal = objA.funcA(temp1, 1);
                    startcal = objB.funcB(temp2, startcal);
                }
                else if(NewValue == 3)
                {
                    Console.WriteLine(" B's func will be called 1");
                }
                else
                {
                    Console.WriteLine("New Value is not only 2,3 and 5 as its prime factor");
                }
                
            }
            else if(NewValue % 2 == 0)
            {
                temp1 = NewValue / 2;
                startcal = objA.funcA(temp1, 1);
            }
            else
            {
                Console.WriteLine("New Value is not only 2,3 and 5 as its prime factor");
            }
           
           

            Console.Read();

        }
    }
}
