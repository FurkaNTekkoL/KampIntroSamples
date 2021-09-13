using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int> numbers = new MyDictionary<int>();
            numbers.Add(10);
        }
    }
}
