using System;

namespace ConsoleApp1
{
    struct MyStruct
    {
        public int X;
        public int Y
        {
            get => X;
            set => X = value;
        }

        public MyStruct(int y, int x)
        {
            X = x;
            Y = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
