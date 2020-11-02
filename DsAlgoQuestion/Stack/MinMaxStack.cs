using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgoQuestion.Stack
{
    public class StackElement
    {
        public int min { get; set; }
        public int max { get; set; }
    }
    public class MinMaxStack
    {
        int maxSize = 0;
        int[] array;
        int top = -1;
        Dictionary<int, StackElement> dic = new Dictionary<int, StackElement>();
        public MinMaxStack(int size)
        {
            maxSize = size;
            array = new int[maxSize];
            top = -1;
        }

        public void Push(int numberToBeEntered)
        {
            if (top <= maxSize - 1)             
            {
                array[++top] = numberToBeEntered;
                int currentmin = 0 ;
                int currentMax = 0 ;
                if (dic.Count > 0)
                {
                    currentMax = Math.Max(numberToBeEntered, dic[top - 1].max);
                    currentmin = Math.Min(numberToBeEntered, dic[top - 1].min);
                }
                else
                { //first time insertion
                    currentmin = numberToBeEntered;
                    currentMax = numberToBeEntered;                  
                }
                StackElement dicObj = new StackElement() { min = currentmin, max = currentMax };
                dic.Add(top, dicObj);               
            }
        }

        public int Pop()
        {
            if (top == -1)
            {
                
                return -1;
            }
            else
            {
                int popedUpElement = array[top];
                dic.Remove(top);
                array[top] = top--;
                return popedUpElement; ;
            }

        }

        public int Peek()
        {
            if (top == -1)
            {
                return -1;
            }
            else
            {
                return top;
            }

        }

        public int GetMax()
        {
            if (top == -1)
            {
                return -1;
            }
            else
            {
                return dic[top].max;
            }

        }
        public int GetMin()
        {
            if (top == -1)
            {
                return -1;
            }
            else
            {
                return dic[top].min;
            }

        }
    }
}
