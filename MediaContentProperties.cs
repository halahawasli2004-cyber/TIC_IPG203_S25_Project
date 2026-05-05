using System;

// هذا الكود يركز على حماية البيانات (التغليف)
public abstract partial class MediaContent
{
    // 1. الحقول الخاصة (Private Fields) - لا يمكن الوصول إليها مباشرة من الخارج
    private readonly string _id; 
    private string _title;

    // 2. الخصائص العامة (Public Properties) - للتحكم في الوصول للبيانات
    public string Id => _id; // القراءة فقط

    public string Title 
    { 
        get => _title; 
        // التحقق من صحة البيانات قبل إسنادها (منع العناوين الفارغة)
        set => _title = string.IsNullOrEmpty(value) ? "Untitled Content" : value; 
    }

    // المشيّد الذي يستقبل البيانات من الأصناف المشتقة
    protected MediaContent(string id, string title)
    {
        _id = id;
        _title = title;
    }
