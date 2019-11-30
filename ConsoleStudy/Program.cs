using System;

namespace ConsoleStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassEvent classEvent = new ClassEvent();
            classEvent.OnFPress += ClassEvent_OnFPress;
            classEvent.OnFPress += Star;
            while (true)
            {
                classEvent.CheckKey(Console.ReadKey().Key);
            }
        }

        private static void ClassEvent_OnFPress()
        {
            Console.WriteLine("FFFFFFFF");
        }

        public static void Star()
        {
            Console.WriteLine("I am a star");
        }
    }
}
