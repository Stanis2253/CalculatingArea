using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingArea.Factories
{
    internal interface IFigureFactory
    {
        /// <summary>
        /// Стороны фигуры
        /// </summary>
        public double[] SidesList { get; set; }

        /// <summary>
        /// Метод для вычисления площади фигуры
        /// </summary>
        /// <returns></returns>
        abstract double CalculateArea();
    }
}
