using System;
using System.Collections.Generic;

// تعريف الواجهة 
public interface IPlayable
{
    void StartActivity();
}

// تعريف الفئة المجردة الأساسية 
public abstract class MediaContent : IPlayable
{
   
    public abstract void DisplayDetails();

    public virtual void StartActivity() 
    {
     
    }
}
