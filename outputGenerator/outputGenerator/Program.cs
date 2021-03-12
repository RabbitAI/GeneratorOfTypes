using System;

namespace outputGenerator
{
    class Program
    {

        static void Main(string[] args)
        {
            string value =" ";
            int num;
            Game g = new Game(value);
            for (int i = 0; i < 20; i++)
            {
                Random randi = new Random(DateTime.Now.Millisecond);
                num = randi.Next() % 5;
                value = g.setValue(num);
                Console.WriteLine(value);
            }
        }
    }
}
