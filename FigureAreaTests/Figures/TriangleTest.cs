using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaLib.Figures;

namespace FigureAreaTests.Figures
{
	[TestClass]
	public class TriangleTest : FigureTest
	{
		[TestMethod]
		public void CheckAreaOfTriangle()
		{
			//Arrange
			double a = 2, b = 5, c = 4;
			var result = 3.799671038392666;
			var triangle = new Triangle(a,b,c);
			//Act
			var calcResult = triangle.GetArea();
			//Assert
			Assert.AreEqual(result, calcResult, accuracy);
		}

		[TestMethod]
		public void CheckAreaOfEquilateralTriangle()
		{
			//Arrange
			var result = 10.82531754730548;
			var triangle = new Triangle(new double[] { 5, 5, 5 });
			//Act
			var calcResult = triangle.GetArea();
			//Assert
			Assert.AreEqual(result, calcResult, accuracy);
		}

		[TestMethod]
		public void CheckWrongTriangleCreation()
		{
			Assert.ThrowsException<ArgumentException>(() =>
			{
				var triangle = new Triangle(1, 2, 3);
			});
		}
	}
}
