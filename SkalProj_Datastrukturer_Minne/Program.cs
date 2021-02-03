using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
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
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
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
            List<string> theList = new List<string>();
            String[] mylist = null;
            do
            {
                    Console.WriteLine("Press (+) To add a string to the list ");
                    Console.WriteLine("Press (-) To remove a string from the list ");
                

                    string input = Console.ReadLine();
                    
                while (string.IsNullOrWhiteSpace(input))
                    {
                    Console.WriteLine("Please enter something !");
                    input = Console.ReadLine();

                    }

                    char nav = input[0];

                 string value = input.Substring(1);
                    value = Regex.Replace(value, @"\s+", " ");
                string input2 = input.Substring(1);
                input2 = Regex.Replace(input2, " ", "");

                                  
  
                    Char[] seperator = { '+', '-', ' ' };
                    mylist = value.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                    
                    

                
                    switch (nav)
                    {


                        case '+':
                        
                            for (int i = 0; i < mylist.Length; i++)
                            {
                            if ((!string.IsNullOrWhiteSpace(mylist[i])) && (!theList.Contains(value)))
                            {

                                theList.Add(mylist[i]);
                            }
                            else
                            {
                                Console.WriteLine("Name or string exist already");
                            }
                            }

                            foreach (string s in theList)
                            {
                                Console.WriteLine(s);

                            Console.WriteLine($"Count :{theList.Count}");
                            Console.WriteLine($"ListCapacity :{theList.Capacity}");

                            }
                            break;



                        case '-':

                            if (theList.Count == 0)
                            {

                                Console.WriteLine("Add  a name or string  first");

                            }
                            else if (theList.Contains(input2))
                            {

                                theList.Remove(input2);
                            }
                            else if(!theList.Contains(input2))

                            {

                            Console.WriteLine("Please Check the spelling first or maybe name doesn't exist ");
                         
                            }


                            foreach (string s in theList)
                            {
                                Console.WriteLine(s);


                            }

                            Console.WriteLine($"Count :{theList.Count}");
                            Console.WriteLine($"ListCapacity :{theList.Capacity}");
                            break;

                        default:
                            Console.WriteLine(" (in this scope you can just use +,- to add or remove a string)");
                            break;
                        case '0':

                            Main();
                            break;

                    }
                
                
                
            }
            

            while (true);

           
        
            /// <summary>
        }     /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            Queueklassen queueklassen = new Queueklassen();
           
           
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            do
            {

            Console.WriteLine("\n1.Add a person to the Queue" + "\n2.Dequeue a person" + "\n0.Go back to the main menu");


            string Entree = Console.ReadLine();
            switch (Entree)
            {
                case "1":
                    queueklassen.Enqueue();
                    break;
                case "2":
                    queueklassen.Dequeue();
                    break;
                case "0":
                    Main();
                    break;

                default:
                    Console.WriteLine("Please choose a choice from the list");
                    break;
            }
            } while (true);
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        /// //TODO
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            StackKlass stackKlass = new StackKlass();
            do
            {

                

                Console.WriteLine("\n1.Push" + "\n2.Pop" + "\n0.Go back to the main menu");


                string Entree = Console.ReadLine();
                switch (Entree)
                {
                    case "1":    
                        stackKlass.Push();
                        break;
                    case "2":
                        stackKlass.Pop();
                        break;
                    case "0":
                        Main();
                        break;

                    default:
                        Console.WriteLine("Please choose a choice from the list");
                        break;
                }
            } while (true);
        }



    

    static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

