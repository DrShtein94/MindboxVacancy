namespace FigureAreaLib
{
	/// <summary>
	/// Basic figure class
	/// </summary>
	public abstract class Figure
    {
		/// <summary>
		/// Area of figure.
		/// </summary>
		protected double? area;

		/// <summary>
		/// Calculate area of figure and set it.
		/// </summary>
		protected abstract void calculateArea();

		/// <summary>
		/// Get information about figura in string.
		/// </summary>
		/// <returns>Information about figure</returns>
		public override abstract string ToString();

		/// <summary>
		/// Get area of figure.
		/// If area isn't calculated, calculate area first.
		/// </summary>
		/// <returns>Area of figure</returns>
		public double GetArea()
		{
			if (area.HasValue)
			{
				return area.Value;
			}
			calculateArea();
			return area.Value;
		}
    }
}
