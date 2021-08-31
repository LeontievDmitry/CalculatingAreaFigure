using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatingAreaFigure;
using System;
/// <summary>
/// Unit-тесты
/// </summary>
namespace UnitTestAreaFigure
{
    [TestClass]
    public class CalculateAreaTest
    {
        /// <summary>
        /// Тест расчета площади круга по радиусу
        /// </summary>
        [TestMethod]
        public void CircleAreaTest()
        {
            Circle circle = new Circle()
            {
                Radius = 8
            };
            double resultArea = circle.CalculateArea();
            Assert.AreEqual(201, resultArea,0.1);
        }
        /// <summary>
        /// Тест расчета площади треугольника по трем сторонам
        /// </summary>
        [TestMethod]
        public void TriangleAreaTest()
        {
            Triangle triangle = new Triangle()
            {
                sideA = 4,
                sideB = 2,
                sideC = 3
            };
            double resultArea = triangle.CalculateArea();
            Assert.AreEqual(2.9, resultArea, 0.1);
        }
        /// <summary>
        /// Тест проверки на то, является ли треугольник прямоугольным
        /// </summary>
        [TestMethod]
        public void TriangleIsRightTest()
        {
            Triangle triangle = new Triangle()
            {
                sideA = 6,
                sideB = 8,
                sideC = 10
            };
            bool isRight = triangle.IsRightTriangle();
            Assert.IsTrue(isRight);
        }
        /// <summary>
        /// Проверка расчета площади любой фигуры
        /// </summary>
        [TestMethod]
        public void AnyFigureAreaTest()
        {
            Figure square = new Figure()
            {
                Name = "Квадрат"
            };
            double squareArea = square.CalculateArea("S(a)=a^2", 5);
            Assert.AreEqual(25, squareArea);

            Circle circle = new Circle()
            {
                Radius = 8
            };
            double resultArea = circle.CalculateArea("S(r)=pi*r^2", circle.Radius);
            Assert.AreEqual(201, resultArea, 0.1);
        }
    }
}
