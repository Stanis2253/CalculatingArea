using CalculatingArea.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingArea
{
    public class Calculating
    {
        private double[] SidesList { get; set; }
        /// <summary>
        /// Класс, вычисляющий площадь по длине сторон.
        /// </summary>
        /// <param name="SidesList">Длина сторон фигуры. Если фигуры это круг, то укажите радиус</param>
        public Calculating(params double[] SidesList)
        {
            this.SidesList = SidesList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns>Возвращает площадь фигуры. Если площадь вычислить не удалось, то вернёт -1</returns>
        public double GetArea()
        {
            IFigureFactory figure;

            if (SidesList.Length ==  1)
            {
                figure = new CicleFactory(SidesList);
            }
            else if (SidesList.Length == 3)
            {
                figure = new TriangleFactory(SidesList);
            }
            else 
            {
                ///Площадь такой фигуры вычислить нельзя
                return -1;
            }
            return figure.CalculateArea();
        }
    }
}
