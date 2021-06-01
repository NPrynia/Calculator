using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0106
{
    public class Calculate
    {
        public static double calculate(double a, double b, int act)
        {
            double res = 0;
            switch (act)
            {
                case 0:
                    res = a + b;

                    break;
                case 1:
                    res = a - b;
                    break;
                case 2:
                    res = a * b;

                    break;
                case 3:
                    res = a / b;

                    break;
                case 4:
                    res = Math.Pow(a, b);

                    break;

            }
            return res;

        }

    }
}
