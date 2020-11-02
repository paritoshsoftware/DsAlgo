using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgoQuestion.Stack
{
   public class ParenthesisChecker
    {
       
       public bool BalancedBracets(string str)
        {
         List<char> MyStack = new List<char>();
         Dictionary<char, char> checkerDictionary = new Dictionary<char, char>();
         bool isValid = true;
         // if string is empty then we will send false case
            if (str == string.Empty)
            return false;
         //adding opposite value for (, { ,[
         checkerDictionary.Add(')', '(');
         checkerDictionary.Add('}', '{');
         checkerDictionary.Add(']', '[');
        
          for(int i = 0; i <str.Length; i++)
          {
              /* if you have opening bractes then insert into stack
               if you have closing bracets then find the equivalent opening bracets and
               compare it with the top most value of stack. If they are equal then pop elements.
               in the end if stack is empty it means the string had vvalid parenthesis */
              if(str[i] == '(' || str[i] == '[' || str[i] == '{' )
                {
                    //adding into the stack
                    MyStack.Add(str[i]);
                }
              else if(str[i] == ')' || str[i] == ']' || str[i] == '}')
                {
                    //checking from dictionary
                    char equivalanetCharacter = checkerDictionary[str[i]];                  
                    if(MyStack.IndexOf(equivalanetCharacter)!=-1)
                    {
                        if (MyStack[MyStack.Count - 1] == equivalanetCharacter)
                        {
                            //removing from stack
                            MyStack.RemoveAt(MyStack.Count - 1);
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }                   
                }
          }
            //final condition which return true or false

            if (MyStack.Count == 0 && isValid == true)
                return true;
            else
                return false;
        }
    }
}
