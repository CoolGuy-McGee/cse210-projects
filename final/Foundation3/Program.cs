using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"---Lecture Demo---");
        Lecture lecture = new Lecture("Programming with Classes - Inheritance", "Continuing our series of lectures on Programming with Classes, this week we discuss Inheritance and how it is used.", new DateOnly(2025, 07, 15), new TimeOnly(14, 30), new Address("Lecture Hall 210", "BYU-I", "ID"), "Dalton Broderson", 150);

        lecture.StandardDetails();
        lecture.ShortDescription();
        lecture.FullDetails();
        Console.WriteLine($"------------------");

        Console.WriteLine($"---Reception Demo---");
        Reception reception = new Reception("John and Jane's Reception", "Join John & Jane, as well as their families, at their reception. There will be the newly married couple, food, dancing, and just a good time!", new DateOnly(2025, 08, 12), new TimeOnly(16, 00), new Address("Local Church", "Local City", "TN"), "newcouple@examplemail.com");

        reception.StandardDetails();
        reception.ShortDescription();
        reception.FullDetails();
        Console.WriteLine($"--------------------");

        // Outdoor.cs (line 12) I made a creative bit for the weather message. I based the message on the season the date of the event occurs.

        Console.WriteLine($"---Outdoor Demo---");
        Outdoor winterEvent1 = new Outdoor("(Winter 1 Event) New Year's Day Party", "I will be busy on New Year's Eve so visit me next year!", new DateOnly(2026, 01, 01), new TimeOnly(00, 00), new Address("My House", "Party City", "WI"));

        winterEvent1.StandardDetails();
        winterEvent1.ShortDescription();
        winterEvent1.FullDetails();
        Console.WriteLine("---------");

        Outdoor winterEvent2 = new Outdoor("(Winter 2 Event) New Year's Eve Party", "Join me for my New Year's Eve party!", new DateOnly(2025, 12, 31), new TimeOnly(23, 00), new Address("My House", "Party City", "WI"));

        winterEvent2.StandardDetails();
        winterEvent2.ShortDescription();
        winterEvent2.FullDetails();
        Console.WriteLine("---------");

        Outdoor springEvent = new Outdoor("(Spring Event) Spring Garden Party", "It's a party in a Garden. That's all I know.", new DateOnly(2025, 05, 14), new TimeOnly(09, 15), new Address("A Garden", "Somewhere", "CA"));
        springEvent.StandardDetails();
        springEvent.ShortDescription();
        springEvent.FullDetails();
        Console.WriteLine("---------");

        Outdoor summerEvent = new Outdoor("(Summer Event) Summer BBQ", "Grilled meats, maybe some vegetables, watermelon, baked beans... I'm getting hungry just thinking about it.", new DateOnly(2025, 08, 23), new TimeOnly(12, 00), new Address("A Backyard", "Sumner", "WA"));
        summerEvent.StandardDetails();
        summerEvent.ShortDescription();
        summerEvent.FullDetails();

        Console.WriteLine($"------------------");
    }
}