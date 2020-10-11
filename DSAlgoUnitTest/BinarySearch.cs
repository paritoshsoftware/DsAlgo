using DsAlgoQuestion;
using DsAlgoQuestion.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DSAlgoUnitTest
{
	[TestClass]
	public class BinarySearch
	{
		[TestMethod]
		public void BinarySearchTestCase1()
		{
			int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int expected = 8;
			int actual = BinarySearchProgram.BinarySearch(array, 8);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BinarySearchTestCase2()
		{
			int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int expected = -1;
			int actual = BinarySearchProgram.BinarySearch(array, 15);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BinarySearchTestCase3()
		{
			int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			int expected = 0;
			int actual = BinarySearchProgram.BinarySearch(array, 0);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void BinarySearchTestCase4()
		{
			int[] array = new int[] { 100, 200, 300 };
			int expected = -1;
			int actual = BinarySearchProgram.BinarySearch(array, 15);
			Assert.AreEqual(expected, actual);
		}
	}
}
