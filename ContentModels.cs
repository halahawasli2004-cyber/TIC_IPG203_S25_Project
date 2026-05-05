using System;
using System.Collections.Generic;

// فئة الفيديو
public class VideoContent : MediaContent
{
    public int Duration { get; set; }


    public VideoContent(string id, string title, int duration) : base(id, title) 
    {
        Duration = duration;
    }

    public override void DisplayDetails() => 
        Console.WriteLine($"[Video] ID: {Id}, Title: {Title}, Duration: {Duration} mins");
}

// فئة الكتاب
public class StoryBook : MediaContent
{
    public int Pages { get; set; }

    public StoryBook(string id, string title, int pages) : base(id, title) 
    {
        Pages = pages;
    }

    public override void DisplayDetails() => 
        Console.WriteLine($"[Book] ID: {Id}, Title: {Title}, Pages: {Pages}");
}

// فئة اللعبة
public class InteractiveGame : MediaContent
{
    public string Difficulty { get; set; }

    public InteractiveGame(string id, string title, string diff) : base(id, title) 
    {
        Difficulty = diff;
    }

    public override void DisplayDetails() => 
        Console.WriteLine($"[Game] ID: {Id}, Title: {Title}, Difficulty: {Difficulty}");
    
    public override void StartActivity() => 
        Console.WriteLine($"Loading Game: {Title} ({Difficulty} mode)...");
}
