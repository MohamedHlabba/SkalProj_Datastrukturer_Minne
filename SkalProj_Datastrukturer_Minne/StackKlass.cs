using System;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    internal class StackKlass
    {
        private List<string> pushs;
        public List<string> Pushs { get; set; }
        public List<string> Pops { get; set; }

        public StackKlass()
        {
            Pushs = new List<string>();
            Pops = new List<string> ();


        }


        internal void CheckListCount()
        {


            if (Pops.Count == 0)
            {
                Console.WriteLine("Kö är tomt");

            }
            else
            {
            Console.WriteLine($"{Pops[0]} blir expedierad och lämnar kö");
            Pops.Remove(Pops[0]);

            if (Pops.Count == 0)
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

                Pushs.Add(name);
                Pops.Add(name);
             



            foreach (string namee in Pushs)
                {

                    Console.WriteLine("*-------------Kö----------------*");

                    Console.WriteLine($"{namee} ställer sig i kön ");

                    Console.WriteLine("*---------------------------*");
                    Pops.Reverse();
               

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
                foreach (var item in Pops)
                {
                    Console.WriteLine("*---------------------------*");
                    Console.WriteLine($"{item} ställer sig i kön");
                    Console.WriteLine("*---------------------------*");
               
                }
            }
                     

        }


        //string text = "text to reverse";
        //string reversed = ReverseText(text);

        //method:
        public string ReverseText(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }




    }

}


