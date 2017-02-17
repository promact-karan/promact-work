using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            // m = no of row ,n = no of column , r = no of rotation
            int m, n, r;
            
            Console.Write("Enter Number Of Rows :: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Enter Number Of Columns :: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter Number Of Rotation time :: ");
            r = int.Parse(Console.ReadLine());

            int[,] tab= new int[m,n];
            
          //  Console.WriteLine("No of rows"+ tab.GetLength(0));
           // Console.WriteLine("No of column"+tab.GetLength(1));

             for(int i=1;i <= tab.GetLength(0);i++)
             {
                Console.WriteLine(" \n Row No Is::" + i);
                for (int j = 1; j <= tab.GetLength(1); j++)
                {
                    Console.Write("Enter "+j+" Element :: ");
                    tab[(i - 1), (j - 1)] = int.Parse(Console.ReadLine());
                }
             }
            Console.WriteLine("\n\n \t ::Your Input::");
            for (int i = 1; i <= tab.GetLength(0); i++)
            {
                for (int j = 1; j <= tab.GetLength(1); j++)
                {
                 
                    Console.Write(" "+tab[(i - 1), (j - 1)]+" ");                   
                }
                Console.WriteLine();
            }

           
            
            Console.ReadLine();
        }
    }
}
