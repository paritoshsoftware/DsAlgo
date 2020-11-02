using DsAlgoQuestion.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DSAlgoUnitTest
{

	[TestClass]
	public class StackSort
	{
		/// <summary>
		/// Check whether stack insert value or not
		/// </summary>
		[TestMethod]
		public void StackSortTestCase1()
		{
			int[] marks = new int[] { 10,5,2,7,9 };
			SortStack myStack = new SortStack(marks);
			int [] actual = myStack.stackSortDessending();
			int[] expected = new int[] {10,9,7,5,2};
			CollectionAssert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void StackSortTestCase2()
		{
			int[] marks = new int[] { 10, 5, 2, 7, 9 };
			SortStack myStack = new SortStack(marks);
			int[] actual = myStack.stackSortAssending();
			int[] expected = new int[] {2,5,7,9,10 };
			CollectionAssert.AreEqual(expected, actual);
		}
	}
}
