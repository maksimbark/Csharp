using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = int.Parse(Console.ReadLine());
            for (int i = 2; i <= Math.Sqrt(a); ++i) {
                while (a % i == 0)
                {
                    Console.WriteLine(i);
                    a /= i;
                }
            }
            if (a != 1)
                Console.WriteLine(a);
                */

            Quiz myQuiz = new Quiz();
            Console.WriteLine(myQuiz.question);
            int answer = int.Parse(Console.ReadLine());
            if (myQuiz.Check(answer)) {
                Console.WriteLine("Right");
            } else {
                Console.WriteLine("Not Right");
            }

        }
    }

}