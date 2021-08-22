using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {

        static Stack<int> one = new Stack<int>();
        static Stack<int> two = new Stack<int>();
        static Stack<int> three = new Stack<int>();

        static void Main(string[] args)
        {
            one.Push(3);
            one.Push(2);
            one.Push(1);

            Move(one, two, three, 3);
        }

        public static void Move(Stack<int> origin, Stack<int> temp, Stack<int> destination, int count)
        {
            PrintAll();

            Console.WriteLine("");
            Console.WriteLine("");
            if (count == 0)
            {
                return;
            }

            Move(origin, destination, temp, count-1);

            int disc = origin.Pop();
            destination.Push(disc);

            Move(temp, origin, destination, count - 1);

            
        }

        public static void PrintAll()
        {
            Console.Write("one: ");
            PrintStack(one);

            Console.WriteLine("");

            Console.Write("two: ");
            PrintStack(two);

            Console.WriteLine("");

            Console.Write("three: ");
            PrintStack(three);

            Console.WriteLine("");
        }

        public static void PrintStack(Stack<int> stack)
        {
            foreach (var item in stack)
            {
                Console.Write(item + ",");
            }
        }
    }
}
