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
        internal void addperson()
        {

            do
            {
                //string name = "";
                //int index = 0;

                Console.WriteLine("1.Add new person to the queue");
                Console.WriteLine("2.Remove  a person from the queue");

                string input = Console.ReadLine();
                switch (input)
                {



                    case "1":
                        Console.WriteLine("Person Name:");
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



                            Console.WriteLine("*-----------------*");

                            Console.WriteLine($"{namee}");

                            Console.WriteLine("*-----------------*");


                        }
                        string FirstElement = Enque[0];



                        break;
                    case "2":
                        Console.WriteLine("Sortie");

                        Deque.Insert(0, Enque[0]);
                        Enque.Remove(Enque[0]);

                        foreach (string sortie in Deque)
                        {

                            Console.WriteLine(sortie);
                        }
                        break;
                         FirstElement = null; 

                    default:
                        break;
                }

            } while (true);
            
         }


    }
}

