using System;

namespace ConsoleStudy
{
    public class ClassEvent
    {
        public event Action OnFPress;

        public void CheckKey(ConsoleKey key)
        {
            if (key == ConsoleKey.F)
            {
                OnFPress?.Invoke();
            }
        }
    }
}
