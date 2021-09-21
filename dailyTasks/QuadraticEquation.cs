using System;

namespace dailyTasks
{
    /// <summary>
    /// Квадратное уравнение — это уравнение вида ax2 + bx + c = 0,
    /// где коэффициенты a, b и c — произвольные числа, причем a ≠ 0.
    ///
    /// Прежде, чем изучать конкретные методы решения, заметим, что все квадратные уравнения можно условно разделить на три класса:
    ///Не имеют корней;
    ///Имеют ровно один корень;
    ///Имеют два различных корня.
    /// Пусть дано квадратное уравнение ax2 + bx + c = 0.
    /// Тогда дискриминант — это просто число D = b2 − 4ac.
    /// </summary>
    public interface IQuadraticEquation
    {
        //количество корней и сами корни
        public string GetRoots(double a, double b, double c, out double x1, out double x2)
        {
            double d;
            d = (b * b) - (4 * a * c);
            if (d == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                return "Both Roots Are Equal";
                

            }

            if (d > 0)
            {
                x1 = -b + Math.Sqrt(d) / (2.0 * a);
                x2 = -b - Math.Sqrt(d) / (2.0 * a);
                return "2 Real Roots";

            }
            x1 = 0;
            x2 = 0;
            return "The Given roots are Imaginary";
        }
    }
    public class QuadraticEquation: IQuadraticEquation
    {
        
    }
}