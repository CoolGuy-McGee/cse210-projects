using System;

class Program
{
    static void iterate(Video currentVid)
    {
        int length = currentVid.GetCommentCount();
        Console.WriteLine();
        Console.WriteLine($"Title: {currentVid.GetTitle()}");
        Console.WriteLine($"Author: {currentVid.GetAuthor()}");
        Console.WriteLine($"Length (sec): {currentVid.GetLength()}");
        Console.WriteLine($"Number of Comments: {currentVid.GetCommentCount()}");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"Comment {i + 1}: {currentVid.GetComments()[i].GetUsername()} - {currentVid.GetComments()[i].GetText()}");
        }
    }

    static void Main(string[] args)
    {
        Video video1 = new Video("clickbait title", "15minFame", 260);
        Comment comment1 = new Comment("regularGuy", "why are people watching this garbage?");
        Comment comment2 = new Comment("A Google User", "Another awesome vid!");
        Comment comment3 = new Comment("real15minFame", "I am here to scam you. Click my link.");
        Comment comment4 = new Comment("randomPoliticalGuy", "This is what happens when you vote for PLACEHOLDER.");

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);

        Video video2 = new Video(" I Lived Like a Viking for 72 Hours (No Technology!)", "WanderDan", 845);
        Comment comment5 = new Comment("NomadicNina", "This made me want to throw my phone in a lake");
        Comment comment6 = new Comment("historybuff3000", "Bro actually ate bark and called it authentic lol");
        Comment comment7 = new Comment("SarahSketches", "Cinematography was stunning! Loved the drone shots.");
        Comment comment8 = new Comment("LofiAxel", "Not a single power tool? Respect.");

        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);

        Video video3 = new Video("What Happens If You Microwave Lava?", "ScienceGoneBoom", 512);
        Comment comment9 = new Comment("ElementalSteve", "I’m both terrified and impressed.");
        Comment comment10 = new Comment("ShinyGurl_92", "My microwave just quit in solidarity.");
        Comment comment11 = new Comment("TechnoTony", "For science, we destroy everything. I love it.");
        Comment comment12 = new Comment("CasualWatcher", "Imagine being this chaotic before noon.");

        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);
        video3.AddComment(comment12);

        Video video4 = new Video("Ranking Every Pizza Topping From Best to Worst", "FoodFury", 618);
        Comment comment13 = new Comment("CheesePlease44", "Pineapple at #3? Bold. I respect it.");
        Comment comment14 = new Comment("SpicySamurai", "Jalapeños > olives any day. Fight me");
        Comment comment15 = new Comment("SaucySusan", " The rage I felt when you ranked mushrooms last");
        Comment comment16 = new Comment("GregEatsALot", "I came here for pepperoni justice and I was satisfied.");

        video4.AddComment(comment13);
        video4.AddComment(comment14);
        video4.AddComment(comment15);
        video4.AddComment(comment16);

        iterate(video1);
        iterate(video2);
        iterate(video3);
        iterate(video4);
    }
}