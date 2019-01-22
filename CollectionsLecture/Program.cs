using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //start with a refresher on Arrays

            //Array & foreach loop example (list of jokes)
            string[] fruitArray = new string[8];
            fruitArray[1] = "Apple";
            fruitArray[2] = "Kiwi";
            //etc.
            foreach (string fruit in fruitArray)
            {
                Console.WriteLine(fruit);
            }

            //BREAK

            //Collections - used to hold objects but are more flexible and efficient than arrays.

            //Arraylist - type of collection that was released with .NET version 1.1.
            //Not frequently used now because there have been more 
            //dynamic types of Collections created in more recent versions of .NET.
            //Might need to be used if working with old .NET programs. 
            //Could be used if trying to store information of different data types.
            //But there are better ways (more on that later)


            // The ArrayList will store elements as objects
            ArrayList numbers = new ArrayList();
            numbers.Add(5); //Add method
            numbers.Add("seven");
            numbers.Insert(1, "eight"); //inserts "eight" in the first index and moves the next index over one (1 becomes 2)
            foreach (var i in numbers)
            {
                Console.WriteLine(i); //print out
            }
            Console.WriteLine(numbers.Count); //count method

            //Hashtables ... word words words (pending)

            //Hashtable example
            Hashtable bookTable = new Hashtable();

            bookTable.Add("001", "John");
            bookTable.Add("002", "Paul");
            Console.WriteLine(bookTable["001"]);

            // (Stack) Last in, First out - white board the example

            // (Queue) First in, First out - white board the example


            //Generic Collections (System.Collections.Generic) - Dictionaries & Lists

            //Dictionaries: a Generic Collections subsitute for Hashtables
            //main differences include: 
            //1. Dictionaries are strongly typed, Hashtables are not.
            //2. Dictionaries are faster 
            //3. if you use an index to reference a value in the Hashtable & the value does not exist, the computer will return NULL
            //a Dictionary will throw an exception.


            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Joydip");
            dictionary.Add(2, "James");
            dictionary.Add(3, "Steve");

            foreach (KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine(kvp.Key.ToString() + " - " + kvp.Value.ToString());
            }


            //LISTS - stress main differences between lists and arrays
            //1. Arrays are created to a certain length and cannot be made bigger.
            //2. Lists are dynamic. Can be added and taken away from.

            bool userContinue = true;
            List<string> colorList = new List<string>();

            while (userContinue)
            {
                Console.WriteLine("Please give me a color!");
                colorList.Add(Console.ReadLine());
                Console.WriteLine("Would you like to add another color to your list ? y / n");
                string result = Console.ReadLine();
                while (result != "y" && result != "n")
                {
                    Console.WriteLine("I’m sorry!That’s not a valid response! Would you like to add another color to your list ? y / n");
                    result = Console.ReadLine();
                }
                if (result == "n")
                {
                    userContinue = false;
                }
            }

            for (int i = 0; i < colorList.Count; i++)
            {
                Console.Write($"{ colorList[i]}, ");
            }

        }
    }
}
