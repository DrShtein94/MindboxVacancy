using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaLib.Figures;

namespace FigureAreaTests.Figures
{
	[TestClass]
	public class CircleTest : FigureTest
	{
		[TestMethod]
		public void CheckAreaOfCircle()
		{
			//Arrange
			var radius = 10;
			var result = 314.159265358979;
			var circle = new Circle(radius);
			//Act
			var calcResult = circle.GetArea();
			//Assert
			Assert.AreEqual(result, calcResult, accuracy);
		}

		[TestMethod]
		public void CheackAreaOfEmptyCircle()
		{
			//Arrange
			var radius = 0;
			var result = 0;
			var circle = new Circle(radius);
			//Act
			var calcResult = circle.GetArea();
			//Assert
			Assert.AreEqual(result, calcResult, accuracy);
		}

		[TestMethod]
		public void CheckMinusRadius()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				var circle = new Circle(-1);
			});
		}
	}
}
