using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DsAlgoQuestion.Stack
{
    
    public class SortStack
    {
        int maxSize = 0;        
        int mainTop = -1;
        int[] unSortedArray;      
        Stack<int> tempStack = new Stack<int>();
        public SortStack(int [] unSortedArray)
        {
            maxSize = unSortedArray.Length;          
            this.unSortedArray = unSortedArray;
            mainTop = unSortedArray.Length - 1;
        }

        public int[] stackSortDessending()
        {
            while (isEmpty() != true)
            {
                int val = popInOriginalStack();

                while (tempStack.Count > 0 && val < tempStack.Peek())
                {
                    pushInOriginalStack(tempStack.Pop());
                }
                tempStack.Push(val);
            }

            return tempStack.ToArray();
        }
        public int [] stackSortAssending()
        {
            while(isEmpty() != true)
            {
                int val = popInOriginalStack();
                               
                while(tempStack.Count > 0 && val > tempStack.Peek())
                {
                    pushInOriginalStack(tempStack.Pop());
                }
                tempStack.Push(val);
            }
           
            return tempStack.ToArray();
        }
        public bool pushInOriginalStack(int n)
        {
            if (mainTop == maxSize - 1)
                return false;
            else
                unSortedArray[++mainTop] = n;
            return true;
        }

        public int popInOriginalStack()
        {
            if (mainTop == -1)
            {
                Console.WriteLine("Stack is alredy emoty");
                return -1;
            }
            else
            {
                int popedUpElement = unSortedArray[mainTop];
                unSortedArray[mainTop] = mainTop--;                  
                return popedUpElement; ;
            }

        }      


        public bool isEmpty()
        {
            if (mainTop == -1) return true; else return false;       
        }

    }
}
