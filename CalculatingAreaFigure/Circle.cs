using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAreaFigure
{
    public class Circle : Figure
    {
        public override string Name { get => "Круг";}
        public double Radius { get; set; }
        /// <summary>
        /// Вычисление площади круга по формуле S(r) = pi * r^2
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            double area = 0;
            try
            {
                if (Radius < 0)
                    throw new Exception("Значение радиуса не должно быть отрицательным");
                
                area = Math.PI * Math.Pow(Radius,2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return area;
        }
    }
}
