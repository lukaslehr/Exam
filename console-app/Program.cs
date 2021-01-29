using System;
using library;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            Question.Hello("Brian");
=======
            var q = new Question();
            Console.WriteLine(q.Largest(2.4f, 4.5f));
>>>>>>> Stashed changes
        }
    }
}
