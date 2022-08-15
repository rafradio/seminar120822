using System;

namespace Kub
{
    class Program
    {
        public int firstNum = 1;
        public int upperNum = 10;
        static void Main(string[] args)
        {
            Console.Clear();
            Program initial = new Program();
            ExecMethod raschet = new ExecMethod(initial.firstNum, initial.upperNum);

        }
    }
}