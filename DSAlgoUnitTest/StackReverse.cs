using DsAlgoQuestion.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DSAlgoUnitTest
{
   	[TestClass]
	public class StackReverse
	{
		
		[TestMethod]
		public void StackReverseTestCase1()
		{
			MyStackTyp1 myStack = new MyStackTyp1(2);
		    myStack.push("H");
		    myStack.push("I");
			string actual = myStack.reverse();
			string expected = "IH";
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void StackReverseTestCase2()
		{
			MyStackTyp1 myStack = new MyStackTyp1(10);
			myStack.push("I");
			myStack.push("N");
			myStack.push("D");
			myStack.push("I");
			myStack.push("A");
			string actual = myStack.reverse();
			string expected = "AIDNI";
			Assert.AreEqual(expected, actual);
		}



	}
}
