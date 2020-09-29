using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgoQuestion
{
	public class BinarySearchProgram
	{

		//Write a function that takes in a sorted array of integers as well as a target
		//integer.The function should use the Binary Search algorithm to determine if
		//the target integer is contained in the array and should return its index if it
		//is, otherwise
		public static int BinarySearch(int[] array, int target)
		{
        	int left = 0;
			int right = array.Length - 1;
			int mid = 0;
			bool isFound = false;
			while (left <= right)
			{
				mid = (left + right) / 2;
				if (target == array[mid])
				{
					isFound = true;
					break;
				}
				if (target > array[mid])
					left = mid + 1;
				else
					right = mid - 1;
			}

			if (isFound == true)
				return mid;
			else
				return -1;
		}
		
	}
}
