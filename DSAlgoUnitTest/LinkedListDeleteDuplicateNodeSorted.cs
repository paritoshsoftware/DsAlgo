using DsAlgoQuestion.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace DSAlgoUnitTest
{
   [TestClass]
	public class LinkedListDeleteDuplicateNodeSorted
	{
		[TestMethod]
		public void DeleteDuplicateNodeSortedLinkedListTestCase1()
		{
			DeleteDuplicateNode.LinkedList test = NewLinkedList(new int[] { 11,11,11,14,13,15 });
			List<int> result = ToList(DeleteDuplicateNode.DeleteDuplicateNodeSorted(test));
			int[] expected = new int[] { 11,14,13,15 };
			CollectionAssert.AreEqual(expected, result);
		}

		public DeleteDuplicateNode.LinkedList NewLinkedList(int[] values)
		{
			DeleteDuplicateNode.LinkedList ll = new DeleteDuplicateNode.LinkedList(values[0]);
			DeleteDuplicateNode.LinkedList current = ll;
			for (int i = 1; i < values.Length; i++)
			{
				current.Next = new DeleteDuplicateNode.LinkedList(values[i]);
				current = current.Next;
			}
			return ll;
		}

		public List<int> ToList(DeleteDuplicateNode.LinkedList ll)
		{
			List<int> arr = new List<int>();
			DeleteDuplicateNode.LinkedList current = ll;
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
