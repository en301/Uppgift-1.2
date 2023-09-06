using System;

namespace uppgift_1_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ett allvarligt fel har upptäckts i din dator... Den är full av vatten vänligen stäng av den omgående och starta den aldrig igen.");
            Console.ReadKey();
        }
    }
}
