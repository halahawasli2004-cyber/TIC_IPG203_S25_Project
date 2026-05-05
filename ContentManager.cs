using System;
using System.Collections.Generic;

// 1. تعريف التفويض (Delegate)
public delegate void ContentHandler(string message);

public class ContentManager
{
    // 2. تعريف الحدث (Event)
    public event ContentHandler OnContentFinished; 
    
    private List<MediaContent> _contents = new List<MediaContent>();

    // خاصية ساكنة (تتبع الطلب 5)
    public static int TotalContentCount { get; private set; }

    public void AddContent(MediaContent content)
    {
        _contents.Add(content);
        TotalContentCount++;
    }

    public void ProcessAll()
    {
        Console.WriteLine("--- Lily World: Processing Educational Content ---");
        foreach (var item in _contents)
        {
            item.DisplayDetails(); 
            item.StartActivity();
            
            // إطلاق الحدث عند الانتهاء من قراءة "قصة"
            if (item is StoryBook)
            {
                OnContentFinished?.Invoke($"[Notification] Well Done! The child finished: {item.Title}");
            }
        }
    }
}
