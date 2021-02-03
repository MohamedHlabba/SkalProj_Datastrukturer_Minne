using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    public class Queueklassen
    {
        private List<string> enQue;
        public List<string> Enque { get; set; }
       

        
        public Queueklassen()
        {
            Enque = new List<string>();
           
        }

        internal void CheckListCount()
        {
            if (Enque.Count == 0)
            {
                Console.WriteLine("Kö är tomt");
                
            }
            else
            {

                Console.WriteLine($"{Enque[0]} blir expedierad och lämnar kö");
                Enque.Remove(Enque[0]);
                if (Enque.Count == 0)
                {

                          Console.WriteLine("*-----------------*");
                           Console.WriteLine("*Kö är tomt*");

                }
            }

        }

        internal void Enqueue()
        {
            Console.WriteLine("Välkomen till Ica kassan , namnet ");
            string name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            //det här är ett test
            {
                Console.WriteLine("Name can't be empty! ");
                name = Console.ReadLine();
            }

            Enque.Add(name);


            foreach (string namee in Enque)
            {

                Console.WriteLine("*-------------Kö----------------*");

                Console.WriteLine($"{namee} ställer sig i kön ");

                Console.WriteLine("*---------------------------*");

            }


        }
        internal void Dequeue()
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
                foreach (string item in Enque)
                {
                    Console.WriteLine("*-------Kö---------*");
                    Console.WriteLine($" {item}  ställer sig i kö");
                    Console.WriteLine("*--------------------------*");
                }


            }
         

        }


    }
}

