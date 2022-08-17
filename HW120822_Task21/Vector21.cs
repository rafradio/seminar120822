using System;

namespace Vector
{
    public class Program 
    {
        public int firstNum = -10;
        public int upperNum = 11;
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
            Console.WriteLine(aDot.CoorAxes[0] + " " + aDot.CoorAxes[1] + " " + aDot.CoorAxes[2]);
            Console.WriteLine(bDot.CoorAxes[0] + " " + bDot.CoorAxes[1] + " " + bDot.CoorAxes[2]);
            ExecMethod execVector = new ExecMethod(aDot, bDot);
            Console.WriteLine($"Расстояние между двумя точками в 3D пространстве равно {execVector.LengthVector}");

        }
    }
    public class InitialSetting 
    {
        public int[] CoorAxes = new int[4];
        public InitialSetting(Program obj2)
        {
            for (int i = 0; i < 3; i++) 
            {
                CoorAxes[i] = obj2.randExecute();
            }
        }

    }
}