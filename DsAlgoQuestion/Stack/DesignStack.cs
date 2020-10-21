using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace DsAlgoQuestion.Stack
{
    public class MyStack
    {
        int maxSize = 0 ;
        int[] array;
        int top = -1;

        public MyStack(int size)
        {
            maxSize = size;
            array = new int[maxSize];
            top = -1;
        }

        public bool push(int n)
        {
            if (top == maxSize - 1)
                return false;
            else
                array[++top] = n;
            return true;
        }

        public bool pop()
        {
            if (top == -1) { 
                Console.WriteLine("Stack is alredy emoty");
                return false;
            }
            else 
            {
                int popedUpElement = array[top];
                array[top] = top--;
                return true; ;
            }    
            
        }

        public int peek()
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
    }
}
