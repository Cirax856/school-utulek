using System;

public class Animal
{
    public int id;
    public string name;
    public string type;
    public int age;
    public string gender;
    public string date;
    public string status;
    public string note;
    public bool adoption;
    public string adoptionDate;

    public Animal(int id, string name, string type, int age, string gender, string date, string status, string note)
    {
        this.id = id;
        this.name = name;
        this.type = type;
        this.age = age;
        this.gender = gender;
        this.date = date;
        this.status = status;
        this.note = note;
    }

    public string AnimalCard()
        => $"{type}, id {id}, named {name}, a {age} year old {gender}\nadmitted on {date} with a health status of {status}\nextra note: {note}\n{(adoption ? $"adopted on {adoptionDate}" : "")}";

    public void Adopt()
    {
        Console.Write("Enter adoption date: ");
        adoptionDate = Console.ReadLine();
        adoption = true;
    }
}

