using System;

namespace persons
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass x = new MyClass { X = 10 };
            MyClass y = new MyClass { X = 7 };
            MyClass z = x + y;
            Console.WriteLine(z.X);
        }
    }
    class MyClass
    {
        public int X { get; set; }
        public static MyClass operator + (MyClass left, MyClass right)
            {
            return new MyClass { X = left.X + right.X };
        }
}
}
