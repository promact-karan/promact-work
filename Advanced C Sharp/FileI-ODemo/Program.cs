using System;
using System.IO;

namespace FileIODemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FileStream file = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i <= 20; i++)
            {
                file.WriteByte((byte)i);
            }

            file.Position = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(file.ReadByte() + " ");
            }            
            Console.ReadKey();
        }
    }
}
