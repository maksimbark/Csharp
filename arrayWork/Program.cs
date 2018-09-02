using System;
using System.Linq;

namespace arrayWork
{
	class Program
    {

        static int Sum(int a, int b)
        {
			return a + b;
        }

        public static Double taskFunction(Double param)
        {
            return (1.0) / (1.1 + 2.1 * param*param*param);
        }

		static void Main(string[] args)
        {
		//	int[] a = { 1, 2, 5, 8, 4, 6, 9, 0, 23, 11, 5, 4, -9 };
         //  var meow = a.Where(k => k % 2 == 1).OrderByDescending(k => k);
         
           
            const Double h = 0.1;

            Double chet = 0.0;
            Double nechet = 0.0;
            Double kray = taskFunction(1.0) + taskFunction(2.6);

            for (Double i = 1.2; i <= 2.4; i += 0.2)
                {
                    chet += taskFunction(i);
                }
            for (Double i = 1.1; i <= 2.5; i += 0.2)
                {
                    nechet += taskFunction(i);
                }

            Double res = (h / 3.0) * (kray + 2 * chet + 4 * nechet);
            System.Console.WriteLine(res);

        }

	}
}
