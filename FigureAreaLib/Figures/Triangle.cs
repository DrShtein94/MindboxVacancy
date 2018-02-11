using System;
using System.Collections.Generic;
using System.Linq;

namespace FigureAreaLib.Figures
{
	/// <summary>
	/// Triangle class.
	/// </summary>
	public class Triangle : Figure
	{
		/// <summary>
		/// Count of sides in triangle.
		/// </summary>
		private const int m_sideCount = 3;

		/// <summary>
		/// Triangle sides.
		/// </summary>
		private double[] m_sides;
		public double[] Sides
		{
			get => m_sides;
			set
			{
				m_sides = value;
				//Every time, when we set sides, we check triangle.
				checkTriangle();
			}
		}

		/// <summary>
		/// Ctor with separated sides.
		/// </summary>
		/// <param name="a">First side of triangle.</param>
		/// <param name="b">Second side of triangle.</param>
		/// <param name="c">Third side of triangle.</param>
		public Triangle(double a, double b, double c)
		{
			Sides = new double[] { a, b, c };
		}

		/// <summary>
		/// Ctor with sides as collection.
		/// </summary>
		/// <param name="sides">Sides of triangle.</param>
		public Triangle(IEnumerable<double> sides)
		{
			//Triangle can has only 3 side!
			if (sides.Count() != m_sideCount)
			{
				throw new ArgumentException("Triangle must contain 3 sides!");
			}

			Sides = sides.ToArray();
		}

		/// <summary>
		/// Implementation of calculate area base method.
		/// </summary>
		protected override void calculateArea()
		{
			var halfPerimeter = Sides.Sum() / 2;
			var areaOfFigure = halfPerimeter
				* (halfPerimeter - Sides[0])
				* (halfPerimeter - Sides[1])
				* (halfPerimeter - Sides[2]);
			area = Math.Sqrt(areaOfFigure);
		}

		/// <summary>
		/// Implementation of ToString base method.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("Triangle: A = {0}, B = {1}, C = {2}, Area = {3}; ", Sides[0], Sides[1], Sides[2],
									area.HasValue ? area.Value.ToString() : "Not calculated yet" );
		}

		/// <summary>
		/// Check is triangle exist.
		/// </summary>
		/// <returns>True if exist, false if not.</returns>
		private bool isExist()
		{
			for (var i = 0; i < m_sideCount; i++)
			{
				if (Sides[i] + Sides[(i + 1) % m_sideCount] <= Sides[(i + 2) % m_sideCount])
					return false;
			}
			return true;
		}

		/// <summary>
		/// General check triangle method.
		/// Do all checks on triangle.
		/// If check fail - throw exception.
		/// </summary>
		private void checkTriangle()
		{
			//Check side count.
			if (Sides.Count() != m_sideCount)
			{
				throw new ArgumentOutOfRangeException("Triangle must contains a 3 sides!");
			}
			//Check existence of triangle.
			if (!isExist())
			{
				var exStr = string.Format("This triangle doesn't exist! {0}", ToString());
				throw new ArgumentException(exStr);
			}
		}
	}
}
