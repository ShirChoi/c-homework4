using System;

namespace Problem3 {
    class Program {
        static void Main(string[] args) {
            double S = 1000;
            double P = Read("P");
            
            int K;

            for(K = 0; S < 1100; K++) {
                S += S * P / 100;
            }

            System.Console.WriteLine($"K = {K}");
            System.Console.WriteLine($"S = {S}");
        }

        static double Read(string varName) {
            Console.Write($"{varName} = ");
            return double.Parse(Console.ReadLine());
        }
    }
}
