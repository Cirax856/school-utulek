using System;
using System.Linq;
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
                Console.Write("What do you want to do (add/adopt): ");
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

                        try
                        {
                            animalList.Add(new Animal(animalList.Count + 1, name, type, int.Parse(age), gender, date, status, note));
                        }
                        catch
                        {
                            Console.WriteLine("Invalid age");
                        }
                        break;
                    case "adopt":
                        try
                        {
                            int id = int.Parse(AskInput("Id: "));
                            
                            animalList.First(animal => animal.id == id).Adopt();
                        }
                        catch
                        {
                            Console.WriteLine("Invalid id");
                        }
                        break;
                }

                Console.WriteLine("");
                Console.WriteLine(animalList[0].AnimalCard());
            }
        }
        static string AskInput(string input)
        {
            Console.Write(input);
            return Console.ReadLine();
        }
    }
}

