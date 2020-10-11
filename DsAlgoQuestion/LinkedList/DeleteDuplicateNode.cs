using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgoQuestion.LinkedList
{
   public class DeleteDuplicateNode
    {

	public static LinkedList DeleteDuplicateNodeSorted(LinkedList head)
	{
		// Write your code here.This is currently in construction
		LinkedList first = head;
		LinkedList second = head;
		LinkedList temp;

		while (first.Next != null)
		{
			second = second.Next;
		    if(first.Value == second.Value)
				{
					temp = second;
					first.Next = temp.Next;
					temp.Next = null;				
				}
				else
				{
					first = first.Next;
				}
				second = first;
		}
			 
		return head;
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
