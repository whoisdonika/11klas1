using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculations
{
    internal class Rectangle
    {
		private int sideA;

		public int SideA
		{
			get { return sideA; }
			set { sideA = value; }
		}

		private int sideB;

		public int SideB
		{
			get { return sideB; }
			set { sideB = value; }
		}
		public Rectangle(int sideA, int sideB)
		{
			this.sideA = sideA;
			this.sideB = sideB;
		}
		public int CalculateArea()
		{
			return this.SideA * this.SideB;
		}

		public int CalculatePerimeter()
		{
			return 2 * (this.SideA + this.SideB);
		}


	}
}
