using System;

namespace Palindrome
{
    class ExecMethod : Program
    {
        public int numBer;
        public int counterDigit;
        public int reversNumber = 0;
        public ExecMethod()
        {
            this.randExecute();
            this.findDigit();
            this.Reversnumber();
        }
        public void randExecute()
        {
            int number = new Random().Next(this.firstNum, this.upperNum);
            this.numBer = number;
        }
        public void findDigit()
        {
            this.counterDigit = 0;
            while (this.numBer / Math.Pow(10, this.counterDigit + 1) > 1)
            {
                this.counterDigit++;
            }
//            this.counterDigit++;
        }
        public void Reversnumber()
        {
            int fraction, degree;
            int initialNumber = this.numBer;
            for (int i = 1; i < this.counterDigit + 2; i++)
            {
                degree = this.counterDigit - (i-1);
                fraction = Convert.ToInt32(initialNumber % 10);
                this.reversNumber = this.reversNumber + Convert.ToInt32(fraction * Math.Pow(10, degree));
                initialNumber = Convert.ToInt32(initialNumber / 10);
            }

        }

    }

}