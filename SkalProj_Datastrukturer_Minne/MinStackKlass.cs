using System;
using System.Collections;
using System.Collections.Generic;


namespace SkalProj_Datastrukturer_Minne
{
    internal class MinStackKlass
    {

        private  Stack stack;
      
        public Stack Stack{ get; set; }
        

        public MinStackKlass()
        {
           
            Stack = new Stack();
           
        }


        internal void CheckListCount()
        {


            if (Stack.Count == 0)
            {
                Console.WriteLine("*-----------------*");
                Console.WriteLine("*Kö är tomt*");

            }
            else
            {
                Console.WriteLine($"{Stack.Pop()} blir expedierad och lämnar kö");
               


                if (Stack.Count == 0)
                {

                    Console.WriteLine("*-----------------*");
                    Console.WriteLine("*Kö är tomt*");

                }

            }
            


        }       



        


        internal void Push()
        {

          


                Console.WriteLine("Välkomen till Ica kassan , namnet ");
                string name = Console.ReadLine();

                while (string.IsNullOrEmpty(name))
                //det här är ett test
                {
                    Console.WriteLine("Name can't be empty! ");
                    name = Console.ReadLine();
                }

            Stack.Push(name);
            Console.WriteLine("*-------------Kö----------------*");



            foreach (string namee in Stack)
                {

     

                    Console.WriteLine($"{namee} ställer sig i kön ");

                    Console.WriteLine("*---------------------------*");
   
            }
 


        }



        internal void Pop()
        {

            try
            {


                CheckListCount();

            }

            catch (Exception exception)
            {
                Console.WriteLine("Message:" + exception.Message);
                Console.WriteLine("Stack Trace" + exception.StackTrace);

            }
            finally
            {
                foreach (var item in Stack)
                {
                    Console.WriteLine("*---------------------------*");
                    Console.WriteLine($"{item} ställer sig i kön");
                    Console.WriteLine("*---------------------------*");
               
                }
            }
                     

        }

        internal void Reverse()
        {
           
           

            Console.WriteLine("Enter Text");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            //det här är ett test
            {
                Console.WriteLine("Text can't be empty! ");
                name = Console.ReadLine();
            }

            

            var c = name.ToCharArray();

            // create a Stack from an array
            Stack<char> myStack = new Stack<char>(c);
            Stack st = new Stack();

           


            foreach (var item in myStack)
            {

               
              Console.Write(item);

            }


        }

       

 

        internal void ReverseText()
        {
            Console.WriteLine("Enter Text");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            //det här är ett test
            {
                Console.WriteLine("Text can't be empty! ");
                name = Console.ReadLine();
            }
            char[] charArray = name.ToCharArray();
                   Array.Reverse(charArray);
              new string(charArray);

            foreach (var item in charArray)
            {
                Console.Write(item);

            }

        }
       
            internal void CheckIfIsWellFormed()
            {

            Console.WriteLine("Enter Text");
            string text = Console.ReadLine();
            while (string.IsNullOrEmpty(text))
            //det här är ett test
            {
                Console.WriteLine("Text can't be empty! ");
                text = Console.ReadLine();
            }
            char[] charArray = text.ToCharArray();


                  Dictionary<string, string> openWith =
                 new Dictionary<string, string>();



            }
        public void Check()
        {



            var dictionary = new Dictionary<string, string>() {
            { "{", "}" },
            {"[", "]" },
            {"(",")" }
        };


            var input = Console.ReadLine();
            var queue = new Queue();
            var stack = new Stack();

            bool isBalanced = true;

            var size = input.ToCharArray().Length;

            if (size % 2 != 0)
            {
                isBalanced = false;
            }
            else
            {
                foreach (var c in input.ToCharArray())
                {
                    stack.Push(c.ToString());
                    queue.Enqueue(c.ToString());
                }

                while (stack.Count > size / 2 && queue.Count > size / 2)
                {
                    var a = (string)queue.Dequeue();
                    var b = (string)stack.Pop();

                    if (dictionary.ContainsKey(a) && b != dictionary[a])
                    {
                        isBalanced = false;

                    }


                }


            }

            Console.WriteLine(isBalanced ? "balanced!" : "Not Balanced");

            Console.ReadLine();
        }


    }




}




