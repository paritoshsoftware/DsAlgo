using DsAlgoQuestion.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DSAlgoUnitTest
{
   	[TestClass]
	public class StackParenthesisChecker
	{
		/// <summary>
		/// Check whether stack insert value or not
		/// </summary>
		[TestMethod]
		public void StackParenthesisCheckerTestCase1()
		{
			ParenthesisChecker checker = new ParenthesisChecker();
			string input = "([])(){ }(())()()";
			bool actual = checker.BalancedBracets(input);
		    bool expected = true;
			Assert.AreEqual(expected, actual);
		}
		[TestMethod]
		public void StackParenthesisCheckerTestCase2()
		{
			ParenthesisChecker checker = new ParenthesisChecker();
			string input = "([)]";
			bool actual = checker.BalancedBracets(input);
			bool expected = false;
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void StackParenthesisCheckerTestCase3()
		{
			ParenthesisChecker checker = new ParenthesisChecker();
			string input = "(((((({ { { { { [[[[[([)])]]]]]} } } } }))))))";
			bool actual = checker.BalancedBracets(input);
			bool expected = false;
			Assert.AreEqual(expected, actual);
		}


		[TestMethod]
		public void StackParenthesisCheckerTestCase4()
		{
			ParenthesisChecker checker = new ParenthesisChecker();
			string input = ")[]}";
			bool actual = checker.BalancedBracets(input);
			bool expected = false;
			Assert.AreEqual(expected, actual);
		}	

	}
}
