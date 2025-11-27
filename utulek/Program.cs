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
<<<<<<< HEAD
                Console.Write("What do you want to do (add/adopt): ");
                string input = Console.ReadLine();
=======
                Console.WriteLine("===== ANIMAL SHELTER =====");
                Console.WriteLine("1) Add animal");
                Console.WriteLine("2) List all animals");
                Console.WriteLine("3) Search / filter");
                Console.WriteLine("4) Mark adoption");
                Console.WriteLine("5) Statistics");
                Console.WriteLine("0) Exit");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();
>>>>>>> 5edb011 (fixed a lot of stuff)

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
<<<<<<< HEAD
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
=======
                    case "2":
                        ListAnimals(animalList);
                        break;
                    case "3":
                        FilterAnimals();
                        break;
                    case "4":
                        AdoptAnimal();
                        break;
                    case "5":
                        GetStatistics();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
>>>>>>> 5edb011 (fixed a lot of stuff)
                        break;
                }

                Console.WriteLine("");
<<<<<<< HEAD
                Console.WriteLine(animalList[0].AnimalCard());
=======
>>>>>>> 5edb011 (fixed a lot of stuff)
            }
        }
        static string AskInput(string input)
        {
<<<<<<< HEAD
            Console.Write(input);
=======
            string name = AskInput("Name: ");
            string type = AskInput("Type: ");
            string ageInput = AskInput("Age: ");
            int age = int.TryParse(ageInput, out int a) ? a : 0;
            string gender = AskInput("Gender: ");
            string date = AskInput("Admission date: ");
            string status = AskInput("Health status: ");
            string note = AskInput("Note: ");

            animalList.Add(new Animal(animalList.Count + 1, name, type, age, gender, date, status, note));
            Console.WriteLine("Animal added.");
        }

        static void ListAnimals(List<Animal> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("No animals in the shelter.");
                return;
            }

            Console.WriteLine("===== ANIMAL LIST =====");
            foreach (Animal a in list)
            {
                Console.WriteLine(a.AnimalCard());
            }
        }

        static void FilterAnimals()
        {
            Console.WriteLine("==== FILTER ====");
            string name = AskInput("Filter by name (leave empty to skip): ");
            string type = AskInput("Filter by type: ");
            string age = AskInput("Filter by age (e.g., <=5 or >=3, leave empty to skip): ");

            var result = animalList.AsEnumerable();

            if (!string.IsNullOrEmpty(name))
                result = result.Where(a => a.name != null && a.name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0);

            if (!string.IsNullOrEmpty(type))
                result = result.Where(a => a.type != null && a.type.IndexOf(type, StringComparison.OrdinalIgnoreCase) >= 0);

            if (!string.IsNullOrEmpty(age))
            {
                if (age.StartsWith("<=") && int.TryParse(age.Substring(2), out int max))
                    result = result.Where(a => a.age <= max);
                else if (age.StartsWith(">=") && int.TryParse(age.Substring(2), out int min))
                    result = result.Where(a => a.age >= min);
            }

            Console.WriteLine("==== FILTER RESULT ====");
            ListAnimals(result.ToList());
        }

        static void AdoptAnimal()
        {
            try
            {
                int id = int.Parse(AskInput("Enter ID: "));
                Animal animal = animalList.FirstOrDefault(a => a.id == id);
                
                if (animal == null)
                {
                    Console.WriteLine("Animal does not exist.");
                    return;
                }

                animal.Adopt();
                Console.WriteLine("Animal adopted.");
            }
            catch
            {
                Console.WriteLine("Invalid ID");
            }
        }

        static void GetStatistics()
        {
            Dictionary<string, int> groupByType = animalList.GroupBy(animal => animal.type).ToDictionary(g => g.Key, g => g.Count());

            float avgAge = (float)animalList.Sum(animal => animal.age) / (float)animalList.Count;
            float adoptedCount = animalList.Where(animal => animal.adoption).Count();

            Console.WriteLine("Animals by count:");
            Console.WriteLine(string.Join("\n", groupByType.Select(kv => $"{kv.Key}: {kv.Value}")));
            
            Console.WriteLine($"Average animal age: {avgAge}");
            Console.WriteLine($"Adopted animals: {adoptedCount}");
        }

        static string AskInput(string prompt)
        {
            Console.Write(prompt);
>>>>>>> 5edb011 (fixed a lot of stuff)
            return Console.ReadLine();
        }
    }
}

