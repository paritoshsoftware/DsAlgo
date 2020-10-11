using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgoQuestion.LinkedList
{
   public class DeleteDuplicateNode
    {

	public static LinkedList DeleteDuplicateNodeSorted(LinkedList head)
	{
		/* There will be two pointer pointing to head
		 at every iteration the second pointer will be moved at once place after first pointer.
		 it will be checked whether first value is equat to second value or not
		 if its equal we will direct the first pointer poiting to the next of second pointer
		 in this way we are actually deleting the duplicate value
		 if he value is not equal the first pointer will move to its next postion
		 in the end again the secong pointer points same as that of first pointer
		*/
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
