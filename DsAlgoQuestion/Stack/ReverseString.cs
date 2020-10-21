using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgoQuestion.Stack
{
   
    public class MyStackTyp1
    {
         int maxSize { get; set; }
         string [] array { get; set; }
         
         int top { get; set; }

        public MyStackTyp1(int size)
        {
            maxSize = size;
            array = new string[maxSize];
            top = -1;
        }

        public bool push(string character)
        {
            if (top == maxSize - 1)
                return false;
            array[++top] = character;
            return true;
        }

        public string pop()
        {
            string elementToBePoped = array[top];
            array[top] = "";
            top--;
            return elementToBePoped;
        }


        public bool isEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }


        public string reverse()
        {
            string reverseString = "";
            while (isEmpty() != true)
                reverseString += pop();
            return reverseString; 
        }
    }
}
