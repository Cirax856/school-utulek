using System;
using System.Collections.Generic;

namespace utulek
{
    internal class Program
    {
        static List<Animal> animalList = new List<Animal>();
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Write("What do you want to do (add): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "add":
                        string name = AskInput("Name: ");
                        string type = AskInput("Type: ");
                        string age = AskInput("Age: ");
                        string gender = AskInput("Gender: ");
                        string date = AskInput("Date: ");
                        string status = AskInput("Health status: ");
                        string note = AskInput("Note: ");

                        animalList.Add(new Animal(animalList.Count + 1, name, type, int.Parse(age), gender, date, status, note));
                        break;
                }

                Console.WriteLine(animalList[0].animalCard());
            }
        }
        static string AskInput(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
        }
    }
}

