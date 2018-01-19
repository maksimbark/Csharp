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

		
		static void Main(string[] args)
        {
			int[] a = { 1, 2, 5, 8, 4, 6, 9, 0, 23, 11, 5, 4, -9 };
           var meow = a.Where(k => k % 2 == 1).OrderByDescending(k => k);
            a.
        }

	}
}
