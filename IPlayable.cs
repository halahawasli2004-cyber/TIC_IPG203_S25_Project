using System;

// تعريف الواجهة (الطلب 1)
public interface IPlayable
{
    void StartActivity();
}

// تعريف الفئة المجردة الأساسية (الطلب 1)
public abstract class MediaContent : IPlayable
{
   
    public abstract void DisplayDetails();

    public virtual void StartActivity() 
    {
     
    }
}
