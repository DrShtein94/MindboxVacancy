using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaLib;
using FigureAreaLib.Figures;
using System.Collections.Generic;

namespace FigureAreaTests
{
	[TestClass]
	public class GeneralTest : FigureTest
	{
		[TestMethod]
		public void TestCollectionOfFigures()
		{
			//Arrange
			var results = new List<double>
			{
				201.0619298297466,
				0.4330127018922193,
				49.60783708246107,
				5.332682251925385,
				0.0,
				3.14159265358979
			};
			var collection = new List<Figure>
			{
				new Circle(8),
				new Triangle(new double[] {1,1,1}),
				new Triangle(10,15,10),
				new Triangle (3,4,6),
				new Circle(0),
				new Circle(1)
			};
			//Act
			collection.ForEach(f => f.GetArea());
			//Assert
			for(var i=0; i<collection.Count; i++)
			{
				Assert.AreEqual(results[i], collection[i].GetArea(), accuracy);
			}
		}
	}
}
