using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingArea.Factories
{
    internal class CicleFactory : IFigureFactory
    {
        public double[] SidesList { get; set; }

        public CicleFactory(double[] SidesList)
        {
            this.SidesList = SidesList;
        }

        public double CalculateArea()
        {
            double result = 2 * 3.14 * SidesList[0];
            return result;
        }
    }
}
