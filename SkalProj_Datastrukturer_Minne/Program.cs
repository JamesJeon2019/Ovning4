using System;
using Collection.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
               Found:
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. Recurcive"
                    + "\n6. Iteration"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                     case '5':
                         RecursiveEven();
                        break;
                     case '6':
                         IterativEven();
                        break;
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4, 5, 6)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
             while (true)
             {
                Console.WriteLine("Please enter + , - or 0 \n" +
                    + "\n +  You will add Adam"
                    + "\n -  You will remove Adam"
                    + "\n0. Go to Main meny");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input: +, - , or 0 !");
                }

                List<string> adams = new List<string>();

                static void CapCount()
                {
                 Console.WriteLine("\nCapacity: {0}", adams.Capacity);
                 Console.WriteLine("Count: {0}", adams.Count);
                }
                 
                 string input = Console.ReadLine();
                 char nav = input[0];
                 //string value = input.substring(1);

                 switch(nav)
                 {
                      case "+":

                          adams.Add("Adam");
                          CapCount();
                     
                          break;

                      case "-":
                          adams.Remove("Adam");
                          CapCount();
                    
                          break;

                      case "0":
                          goto Found;

                           default:
                           Console.WriteLine("Please enter some valid input as + , - or 0 ");
                           break;
                           
                 }
             }
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        /// 
       
        
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        
        
            /* Queue item = new Queue();
             item.Enqueue(1);
             item.Enqueue(2);
             item.Enqueue(3);
             item.Enqueue(4);
             item.Enqueue(5);

             foreach (Object obj in item)
             {
                 Console.WriteLine(obj);
             }
             Console.WriteLine(); Console.WriteLine();
             Console.WriteLine("The number of elements in the Queue " + item.Count);
             Console.WriteLine("Does the Queue contain " + item.Contains(5));
             Console.ReadKey();
             */
          while(true)
          {
         
                Console.WriteLine("Please enter + , - or 0 " 
                   + "\n +  You will add Item to Queue"
                    + "\n -  You will remove Item from Queue"
                    + "\n0. Go to Main meny");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input: +, - , or 0 !");
                }

                Queue <int> item = new Queue<int>();


                 string input = Console.ReadLine();
                 char nav = input[0];
                 //string value = input.substring(1);
                int number = 1;
                switch (nav)
                {
                    case "+":

                        item.Enqueue(1);
                        item.Enqueue(2);
                        item.Enqueue(3);
                        item.Enqueue(4);
                        item.Enqueue(5);

                        // Or
                        item.Enqueue(number);//user has to iterate  with + to fyll queue

                        Console.WriteLine("The number of elements in the Queue " + item.Count);
                        Console.WriteLine("Does the Queue contain " + item.Contains(5));
                        number++;
                        break;

                    case "-":
                         Console.WriteLine("\nRemoving from Queue. \nNew Queue is : ", item.Dequeue());            
                         print(item);   
                         Console.WriteLine("The number of elements in the Queue " + item.Count);
                         Console.WriteLine("Does the Queue contain " + item.Contains(5));

                         break;

                    case "0":
                        goto Found;
                        

                        default:
                        Console.WriteLine("Please enter some valid input as + , - or 0 ");
                        break;
                       
                }
          }
        }

   


        }


        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

        while(true)
            {
             Console.WriteLine("Please enter + , - or 0 " 
                   + "\n +  You will add Item to stack"
                    + "\n -  You will remove Item from stack"
                    + "\n0. Go to Main meny");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input: +, - , or 0 !");
                }

                
                 string input = Console.ReadLine();
                 char nav = input[0];
                 //string value = input.substring(1);
                int number = 1;
                switch (nav)
                {
                    case "+":

                        Stack eS = new Stack();

                        eS.Push(1);
                        eS.Push(2);
                        eS.Push(3);
                        eS.Push(4);
                        eS.Push(5);

                        foreach (var itm in eS)
                        {
                         Console.WriteLine(itm);
                        }
                    case "-":
                         Console.Write("Number of elements in Stack: {0}", eS.Count);

                         while (eS.Count > 0)
                         Console.WriteLine(eS.Pop());

                         Console.Write("Number of elements in Stack: ", eS.Count);
                     case "0":
                         goto Found;
                         default:
                         Console.WriteLine("Please enter some valid input as + , - or 0 ");
                         break;
                        
                }
            }

            //string text= "(()])";
            static void CheckParanthesis(string text)
            {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             
             */


             Stack<char> stack = new Stack<char>();
 
            foreach(Char c in text)
                switch (c)
                {
                    case ')':
                        if (stack.Pop() != '(')
                            throw new Exception("Extra closing bracket')'");
                        break;
                    case '}':
                        if (stack.Pop() != '{')
                            throw new Exception("Extra closing bracket '}'");
                        break;
                    case ']':
                        if (stack.Pop() != '[')
                            throw new Exception("Extra closing bracket ']'");
                        break;
                    case '[':
                    case '{':
                    case '(':

                        stack.Push(c);
                        break;
                }
                if (stack.Count > 0)
                throw new Exception("No closing bracket found for " + stack.Pop());

                /*
                bool IsValid(string text)
                {
                 foreach (var c in text)
                 {
                        switch (c)
                        {
                              case '{':
                              case '(':
                              case '[':
                                  stack.Push(c);
                                  break;

                              case '}':
                                  if (stack.Count == 0) return false;
                                  if (stack.Pop() != '{') return false;
                                  break;
                              case ']':
                                  if (stack.Count == 0) return false;
                                  if (stack.Pop() != '[') return false;
                                  break;
                              case ')':
                                  if (stack.Count == 0) return false;
                                  if (stack.Pop() != '(') return false;
                                  break;
                        }
                 }   
                         return stack.Count == 0;
               }

               */
            }
        }
            // Fibonachi
            // (f(n)​=f(n-1) ​+ ​ f(n-2)) 
            //1,1,2,3,5,8,13,21,...
            //f(0)=0, f(1)=1  base 
            
            static int RecursiveEven(int ​n)
            {
            if (n==0)
               return 0;
            if (n==1)

               return 1;
            else 
                    return (RecursiveEven(​n-1) +RecursiveEven(​n-2));

            
            Console.WriteLine(RecursiveEven(​n));
            }
            //check
           // Console.WriteLine(RecursiveEven(​1));  =1
           // Console.WriteLine(RecursiveEven(​3));  =2
          //  Console.WriteLine(RecursiveEven(​5));  =5

      

        //Iteration  Odd
        //       1   3   5
        // Odd 1,3,5,7,9,11,,,,

        public interface IterativEven(int n)
        {
           if (int n == 0) return 0;
           int result=0;
               for(int i=0 ; i<=n; i++)
               {
               int result += 2;
               }
               return result;
        }

      static int IterativeFibonachi(int ​n)
      {
            if (n==0)
               return 0;
            if (n==1)

               return 1;

            else 
                   for(int i=0 ; i<=n; i++)
                   {
                    return (IterativeFibonachi(​n-1) +IterativeFibonachi(​n-2));

            
                    Console.WriteLine(IterativeFibonachi(​n));
                   }

      }
    }
}

  

//
 //   För att koppla om projektet till ett eget repository under ert eget konto behöver ni ta bort den gamla kopplingen.
    

//Team Explorer: Settings: Repository Settings:  Remotes: Remove. 
//Efter det gå tillbaks till huvudmenyn i Team Explorer genom att trycka på huset högst upp.
 //Gå in på  Sync: sedan som vanligt!
 //change
