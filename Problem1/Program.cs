using System;

namespace Problem1 {
    class Program {
        static void Main(string[] args) {
            int A = Read("A");
            int B = Read("B");

            int sum = 0;

            for(int i = A + 1; i < B; i++) 
                sum += i;

            System.Console.WriteLine($"sum = {sum}");

            for(int i = A + 1; i < B; i++)
                if(i % 2 == 1)
                    System.Console.Write($"{i} ");
        }

        static int Read(string varName) {
            Console.Write($"{varName} = ");
            return int.Parse(Console.ReadLine());
        }
    }
}
