using System;

namespace Vector
{
    public class Program 
    {
        public int firstNum = -10;
        public int upperNum = 10;
        public int randExecute()
        {
            int number = new Random().Next(this.firstNum, this.upperNum);
            return number;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Program initial = new Program();
            InitialSetting aDot = new InitialSetting(initial);
            InitialSetting bDot = new InitialSetting(initial);
            Console.WriteLine(aDot.XAxes + " " + aDot.YAxes + " " + aDot.ZAxes);
            Console.WriteLine(bDot.XAxes + " " + bDot.YAxes + " " + bDot.ZAxes);
            ExecMethod execVector = new ExecMethod(aDot, bDot);

        }
    }
    public class InitialSetting 
    {
        public int XAxes;
        public int YAxes;
        public int ZAxes;
        public InitialSetting(Program obj2)
        {
            XAxes = obj2.randExecute();
            YAxes = obj2.randExecute();
            ZAxes = obj2.randExecute();
        }

    }
}