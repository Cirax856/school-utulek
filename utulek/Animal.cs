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
    {
        string card = string.Format("{0} named {1} age {2} with gender {3} was admitted {4} with health status of {5}, extra note: {6}. adoption: {7}, adoption date: {8}, id: {9}", type, name, age, gender, date, status, note, adoption, adoptionDate, id);
        return card;
    }
}
