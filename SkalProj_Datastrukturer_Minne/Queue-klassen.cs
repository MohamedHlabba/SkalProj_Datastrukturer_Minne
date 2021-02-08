using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    public class Queueklassen
    {
      

        private Queue queue;
        public Queue Queue { get; set; }


        public Queueklassen()
        {
           
            Queue = new Queue();
            
           
        }

        internal void CheckListCount()
        {
            if (Queue.Count == 0)
            {

                Console.WriteLine("*-----------------*"); 
                Console.WriteLine("*Kö är tomt*");
                

            }
            else
            {

                Console.WriteLine($"{Queue.Dequeue()} blir expedierad och lämnar kö");
               // que.Remove(Enque[0]);
                
                if (Queue.Count == 0)
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

            Queue.Enqueue(name);


            Console.WriteLine("*-------------Kö----------------*");
            foreach (string namee in Queue)
            {

                

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
                
                foreach (string item in Queue)
                {
                    
                    Console.WriteLine($" {item}  ställer sig i kö");
                    Console.WriteLine("*--------------------------*");
                }


            }
         

        }


    }
}

