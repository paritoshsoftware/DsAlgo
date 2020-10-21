using DsAlgoQuestion.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace DSAlgoUnitTest
{
   
	[TestClass]
	public class StackBasic
	{
		/// <summary>
		/// Check whether stack insert value or not
		/// </summary>
		[TestMethod]
		public void StackBasicTestCase1()
		{
			MyStack myStack = new MyStack(2);
			bool actual = myStack.push(10);
			bool expected = true;
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// checks overflow condition
		/// </summary>
		[TestMethod]
		public void StackBasicTestCase2()
		{
			MyStack myStack = new MyStack(5);
			myStack.push(1);
			myStack.push(2);
			myStack.push(3);
			myStack.push(4);
			myStack.push(5);
			bool actual = myStack.push(10);
			bool expected = false;		
			Assert.AreEqual(expected, actual);
		}


		/// <summary>
		/// checks pop overflow condition
		/// </summary>
		[TestMethod]
		public void StackBasicTestCase3()
		{
			MyStack myStack = new MyStack(5);
			myStack.push(1);
			myStack.push(2);
			myStack.push(3);
			myStack.push(4);
			myStack.push(5);
			myStack.pop();
			myStack.pop();
			myStack.pop();
			myStack.pop();
			myStack.pop();
			bool actual = myStack.pop();			
			bool expected = false;
			Assert.AreEqual(expected, actual);
		}


		/// <summary>
		/// checks pop  condition
		/// </summary>
		[TestMethod]
		public void StackBasicTestCase4()
		{
			MyStack myStack = new MyStack(2);
			myStack.push(1);
			myStack.push(2);		
			myStack.pop();			
			bool actual = myStack.pop();
			bool expected = true;
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		/// checks peek  condition
		/// </summary>
		[TestMethod]
		public void StackBasicTestCase5()
		{
			MyStack myStack = new MyStack(2);
			myStack.push(1);
			myStack.push(2);		
			int actual =  myStack.peek();
			int expected = 1;
			Assert.AreEqual(expected, actual);
		}


		/// <summary>
		/// checks peek overflow condition
		/// </summary>
		[TestMethod]
		public void StackBasicTestCase6()
		{
			MyStack myStack = new MyStack(2);			
			int actual = myStack.peek();
			int expected = -1;
			Assert.AreEqual(expected, actual);
		}

	}
}
