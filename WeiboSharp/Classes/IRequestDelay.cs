using System;

namespace WeiboSharp.Classes
{
    public interface IRequestDelay
    {
        TimeSpan Value { get; }
        bool Exist { get; }

        void Enable();

        void Disable();
    }
}