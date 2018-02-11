using System;

namespace FigureAreaLib.Figures
{
	/// <summary>
	/// Circle figure class.
	/// </summary>
	public class Circle : Figure
	{
		/// <summary>
		/// Radius of circle.
		/// </summary>
		public double Radius { get; set; }

		/// <summary>
		/// Default ctor.
		/// </summary>
		/// <param name="radius">Radius of circle.</param>
		public Circle(double radius)
		{
			//radius cannot be less than zero.
			if(radius < 0)
			{
				throw new ArgumentOutOfRangeException("Radius of circle cannot be less than 0!");
			}

			Radius = radius;
		}

		/// <summary>
		/// Implementation of base calculate area method.
		/// </summary>
		protected override void calculateArea()
		{
			area = Math.PI * Radius * Radius;
		}

		/// <summary>
		/// Implementation of base ToString method.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("Circle: R = {0}, Area = {1}; ", Radius,
				area.HasValue ? area.Value.ToString() : "Not calculated yet");
		}
	}
}
