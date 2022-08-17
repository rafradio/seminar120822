using System;

namespace Vector
{
    class ExecMethod
    {
        public double LengthVector;
        public ExecMethod(InitialSetting obj, InitialSetting obj1)
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += Convert.ToInt32(Math.Pow((obj.CoorAxes[i] - obj1.CoorAxes[i]), 2));
            }
            LengthVector = Math.Round(Math.Sqrt(sum), 2, MidpointRounding.ToEven);
        }
    }
}