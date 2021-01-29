using System;


namespace console_app
{
    class Question
    {
        
         Func<float, float, float> Largest = (x, y) => Math.Max(x, y);

        Action<string> Hello = x => Console.WriteLine("Hello, " + x);

        Func<Car, bool> Fast = x => x.getNoughttoSixty() > 4.0 ? true : false;

    }

    class Car{
        public float NoughtToSixty { get; set; }

        public float getNoughttoSixty(){
            return NoughtToSixty;
        }
    }
}