using System;

namespace Kub
{
    class ExecMethod
    {
        public int firstNum;
        public int upperNum;
        public int numBer;
        public int[] arrayCub;
        public ExecMethod(int firstNum, int upperNum) 
        {
            this.firstNum = firstNum;
            this.upperNum = upperNum;
            this.randExecute();
            this.cubExecute();
            this.cubPrint();
        }
        public void randExecute()
        {
            this.numBer = new Random().Next(this.firstNum, this.upperNum);
            Console.WriteLine($"Введено число: {this.numBer}");
        }
        public void cubExecute()
        {
            this.arrayCub = new int[this.numBer];
            for (int i = 0; i < this.arrayCub.Length; i++)
            {
                this.arrayCub[i] = Convert.ToInt32(Math.Pow((i + 1), 3));
            }

        }
        public void cubPrint()
        {
            for (int i = 0; i < this.arrayCub.Length; i++)
            {
                int counter = i + 1;
                Console.WriteLine("Куб числа {0} равен {1}", counter, this.arrayCub[i]);
            }
        }
    }
}