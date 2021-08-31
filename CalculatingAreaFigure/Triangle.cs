using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaFigure
{
    public class Triangle: Figure
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }
        /// <summary>
        /// Расчет площади треугольника по трем сторонам
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            double area = 0;
            try
            {
                if (sideA < 0 || sideB < 0 || sideC < 0)
                    throw new Exception("Значения сторон не должны быть отрицательными");
                if (sideA > (sideB + sideC) || sideB > (sideA + sideC) || sideC > (sideA + sideB))
                {
                    throw new Exception("Одна сторона не может быть больше суммы двух других");
                }
                double p = (sideA + sideB + sideC) / 2;
                area = Math.Sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return area;
        }
        /// <summary>
        /// Проверка на то, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            if (Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2)
                ||
                Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2)
                ||
                Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2)
                )
                return true;
            return false;
        }
    }
}
