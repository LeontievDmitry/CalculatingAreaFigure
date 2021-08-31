using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using org.mariuszgromada.math.mxparser;

namespace CalculatingAreaFigure
{
    /// <summary>
    /// Класс фигура
    /// </summary>
    public class Figure
    {
        /// <summary>
        /// Название фигуры
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// Метод рассчета площади фигуры.
        /// Реализация задания "Вычисление площади фигуры без знания типа фигуры в compile-time"
        /// P.S. Я понял это задание так, что мы можем создать любую фигуру и для неё вычислить площадь. Для решения я воспользовался библиотекой mxparser
        /// , которая позволяет работать с формулами.
        /// Ссылка на GitHub: https://github.com/mariuszgromada/MathParser.org-mXparser
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public double CalculateArea(string expression, params double[] args)
        {
            double area;
            Function function = new Function(expression);
            area = function.calculate(args);
            return area;
        }
    }
}
