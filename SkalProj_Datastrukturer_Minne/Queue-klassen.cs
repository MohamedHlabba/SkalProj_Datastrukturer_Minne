using System;
using System.Collections.Generic;
using System.Text;

namespace SkalProj_Datastrukturer_Minne
{
    public class Queueklassen
    {
        private List<string> enQue;
        public List<string> Enque { get; set; }
        private List<string> deQue;
        public List<string> Deque { get; set; }

        
        public Queueklassen()
        {
            Enque = new List<string>();
            Deque = new List<string>();
        }
        internal void TestQueue​()
        {

            do
            {
                

                Console.WriteLine("\n1.Add a person to the Queue"+ "\n2.Dequeue a person"+ "\n0.Go back to the main menu");
                

                string input = Console.ReadLine();
                switch (input)
                {



                    case "1":
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


                            //var myList = new List<string> { "Yes", "No", "Maybe" };
                            //var firstItem = myList.ElementAt(0);



                            Console.WriteLine("*-------------Kö----------------*");

                            Console.WriteLine($"{namee} ställer sig i kön ");

                            Console.WriteLine("*---------------------------*");


                        }
                        
                       // string FirstElement = Enque[0];



                        break;
                    case "2":

                        
                        try 
                        {



                            while (Enque.Count != 0)
                            {
                                Console.WriteLine($"{Enque[0]} blir expedierad och lämnar kö");
                                   Enque.Remove(Enque[0]);
                                   Console.WriteLine("*-----------------*");

                            }
                            Console.WriteLine("*Kö är tomt*");

                            //if (Enque.Count == 0)
                            //{
                            //    Console.WriteLine("*Kö är tomt*");
                            //    Console.WriteLine("*-----------------*");
                            //}
                            //else 
                            //{
                            //    Console.WriteLine($"{Enque[0]} blir expedierad och lämnar kö");
                            //    Enque.Remove(Enque[0]);
                            //    Console.WriteLine("*-----------------*");


                            //}

                            //Console.WriteLine("*Kö är tomt*");
                            //Console.WriteLine("*-----------------*");

                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine("Message:" + exception.Message);
                            Console.WriteLine("Stack Trace" + exception.StackTrace);

                        }

                        finally
                        {   
                            foreach (string sortie in Enque)
                            {
                                Console.WriteLine("*-------Kö---------*");
                                Console.WriteLine($" {sortie}  ställer sig i kö");
                                Console.WriteLine("*--------------------------*");
                            }


                        }
                            break;
                            //FirstElement = null;

                            
                    case "0":
                       // Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Choose a number between the following list (1,2,0)");
                        break;
                }

            } while (true);
            
         }


    }
}

