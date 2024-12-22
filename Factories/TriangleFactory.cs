using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingArea.Factories
{
    internal class TriangleFactory : IFigureFactory
    {
        public double[] SidesList { get; set; }

        public TriangleFactory(double[] SidesList)
        {
            this.SidesList = SidesList;
        }

        public double CalculateArea()
        {
            if (CheckIsRightTriangle())
            {
                return GetAreaRightTriangle();
            }
            else
            {
                return GetAreaTriangle();
            }
        }
        /// <summary>
        /// S = a*b/2
        /// </summary>
        /// <returns></returns>
        private double GetAreaRightTriangle()
        {
            double area = 1;
            for (int i = 0; i < SidesList.Length; i++)
            {
                if (SidesList[i] == SidesList.Max(x => x))
                {
                    area *= SidesList[i];
                }
                area = area / 2;
            }
            return area;
        }
        /// <summary>
        /// S = √(p(p-a)(p-b)(p-c))
        /// </summary>
        /// <returns></returns>
        private double GetAreaTriangle()
        {
            var p = (SidesList[0]+ SidesList[1]+ SidesList[2])/2;

            var Area =  Math.Sqrt(p*((p-SidesList[0])*(p-SidesList[1])*(p-SidesList[2])));

            return Area;
        }


        /// <summary>
        /// Проверка, является ли треугольник прямоугольным.
        /// </summary>
        /// <returns></returns>
        private bool CheckIsRightTriangle()
        {
            if (GetSumCathetus() == GetHypotenuse())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private double GetSumCathetus() 
        {
            double sumCathetus = 0;

            for (int i = 0; i < SidesList.Length; i++)
            {
                if (SidesList[i] != SidesList.Max(x => x))
                {
                    sumCathetus += Math.Pow(SidesList[i], 2);
                }
            }
            return sumCathetus;
        }
        private double GetHypotenuse()
        {
            return Math.Pow(SidesList.Max(x => x), 2);
        }
    }
}
