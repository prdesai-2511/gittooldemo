using System;

namespace MyApp.Services
{
    public class ConsoleGreeter : IGreeter
    {
        public void Greet(string message)
        {
            Console.WriteLine(message);
        }
    }
}
