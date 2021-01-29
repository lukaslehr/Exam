using System;


namespace library
{
    public class Question
    {
        
        public Func<float, float, float> Largest = (x, y) => Math.Max(x, y);

        public Action<string> Hello = x => Console.WriteLine("Hello, " + x);

        public Func<Car, bool> Fast = x => x.getNoughttoSixty() > 4.0 ? true : false;

    }

    public class Car{
        public float NoughtToSixty { get; set; }

        public float getNoughttoSixty(){
            return NoughtToSixty;
        }
    }
}