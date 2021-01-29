using library;
using System;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {

            var q = new Question();
            Console.WriteLine(q.Largest(2.4f, 4.5f));
            q.Hello("Lukas");

        }
    }
}
