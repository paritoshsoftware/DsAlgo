using DsAlgoQuestion.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace DSAlgoUnitTest
{
    
	[TestClass]
	public class StackMinMax
	{
		/// <summary>
		/// checks overflow condition
		/// </summary>
		[TestMethod]
		public void StackMinMaxTestCase1()
		{
			MinMaxStack myStack = new MinMaxStack(5);
			myStack.Push(10);
			myStack.Push(12);
			myStack.Push(15);
			myStack.Push(5);
			myStack.Push(1);
			int actual = myStack.GetMax();
			int expected = 15;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void StackMinMaxTestCase2()
		{
			MinMaxStack myStack = new MinMaxStack(5);
			myStack.Push(2);
			myStack.Push(3);		
		    myStack.Pop();		
			int actual = myStack.GetMin();
			int expected = 2;
			Assert.AreEqual(expected, actual);
			myStack.Push(1);
			 actual = myStack.GetMin();
			 expected = 1;
			Assert.AreEqual(expected, actual);
		}


	}
}
