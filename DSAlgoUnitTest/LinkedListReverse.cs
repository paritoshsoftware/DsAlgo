using DsAlgoQuestion.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DSAlgoUnitTest
{
    [TestClass]
   
	public class ReverseLinkListTest
	{
		[TestMethod]
		public void ReverseLinkLisTestCase1()
		{
			ReverseLinkList.LinkedList test = NewLinkedList(new int[] { 0, 1, 2, 3, 4, 5 });
			List<int> result = ToList(ReverseLinkList.ReverseLinkedList(test));
			int[] expected = new int[] { 5, 4, 3, 2, 1, 0 };
			CollectionAssert.AreEqual(expected, result);
		}

		public ReverseLinkList.LinkedList NewLinkedList(int[] values)
		{
			ReverseLinkList.LinkedList ll = new ReverseLinkList.LinkedList(values[0]);
			ReverseLinkList.LinkedList current = ll;
			for (int i = 1; i < values.Length; i++)
			{
				current.Next = new ReverseLinkList.LinkedList(values[i]);
				current = current.Next;
			}
			return ll;
		}

		public List<int> ToList(ReverseLinkList.LinkedList ll)
		{
			List<int> arr = new List<int>();
			ReverseLinkList.LinkedList current = ll;
			while (current != null)
			{
				arr.Add(current.Value);
				current = current.Next;
			}
			return arr;
		}

		public bool ArraysEqual(List<int> arr1, int[] arr2)
		{
			if (arr1.Count != arr2.Length) return false;
			for (int i = 0; i < arr1.Count; i++)
			{
				if (arr1[i] != arr2[i]) return false;
			}
			return true;
		}
	}
}
