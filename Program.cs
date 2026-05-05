using System;

// 1. صنف ساكن للتحقق من صحة البيانات 
public static class Validator
{
    public static bool IsValidId(string id) => !string.IsNullOrWhiteSpace(id) && id.Length >= 3;
}

// 2. الكلاس الأساسي الذي يحتوي على دالة Main لتشغيل المشروع
class Program
{
    static void Main(string[] args)
    {
        // إعداد المدير والاشتراك في الأحداث
        ContentManager manager = new ContentManager();
        
        // استخدام Anonymous Method للاستجابة للحدث
        manager.OnContentFinished += (msg) => {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        };

        // إضافة بيانات تجريبية (تطبيق تعدد الأشكال)
        if (Validator.IsValidId("V101"))
            manager.AddContent(new VideoContent("V101", "Lily's Garden", 5));

        manager.AddContent(new StoryBook("B202", "The Secret Mission", 15));
        manager.AddContent(new InteractiveGame("G303", "Logic Puzzle", "Easy"));

        // تشغيل المعالجة وعرض النتائج
        manager.ProcessAll();

        // عرض الخاصية الساكنة 
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Total Items in System: {ContentManager.TotalContentCount}");
        
        Console.WriteLine("\nPress any key to close the program...");
        Console.ReadKey();
    }
}
