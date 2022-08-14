using System;

namespace Palindrome
{
    class Program
    {
        public int firstNum = 100000;
        public int upperNum = 1000000;
        static void Main(string[] args)
        {
            Console.Clear();
            ExecMethod print = new ExecMethod();
            if (print.numBer == print.reversNumber)
            {
                Console.WriteLine($"Заданное число: {print.numBer}, является палиндромом к обратному числу: {print.reversNumber}");
            }
            else 
            {
                Console.WriteLine($"Заданное число: {print.numBer} не является палиндромом к обратному числу: {print.reversNumber}");
            }
        }
        
    }
}