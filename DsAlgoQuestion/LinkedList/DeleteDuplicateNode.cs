using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgoQuestion.LinkedList
{
   public class DeleteDuplicateNode
    {

		public static LinkedList DeleteDuplicateNodeSorted(LinkedList head)
	{
		// Write your code here.
		LinkedList current = head;
		LinkedList prev = null;
		LinkedList temp;

		while (current != null)
		{
			temp = current.Next;
			current.Next = prev;
			prev = current;
			current = temp;
		}

		return prev;
	}

		public class LinkedList
	{
		public int Value;
		public LinkedList Next = null;

		public LinkedList(int value)
		{
			this.Value = value;
		}
	}

	}

}
