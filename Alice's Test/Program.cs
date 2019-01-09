using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alice_s_Test

/*test part 3 - winform:
 * question 2: on WinForm app we will use Debug.Trace because winform isnt console app,
 * there isn't any Console.WriteLine() command to check ourselves. instead we will use
 * Debug.Trace, which is supported by WinForm.
 * 
 * 
 * question 3: because the thread responsible for drawing on winform is capable of doing
 * only one thing. that's why we are making a new thread that will take over his place and
 * will make the drawing thread available to execute other code lines.
 * 
 * question 4: answer (1)
 * 
 * 
 * 
 * test part 1
 * question 2: yes, it will.
 * question 3: no, because in the Update method we are making a new array that is bound to that same method.
 * question 5: By using the params keyword, you can specify a method parameter that takes a variable number of arguments.
 * public static void UseParams(params int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }

    public static void UseParams2(params object[] b)
    {
        for (int i = 0; i < b.Length; i++)
        {
            Console.Write(b[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        UseParams(1, 2, 3, 4);
        UseParams2(1, 'a', "test");
	}
 */

{
	class Program
	{
		static void Main(string[] args)
		{
			//part 1 question 1
			Console.WriteLine("Enter a number: ");
			int x = Convert.ToInt32(Console.ReadLine());
			Multiply2(x);



			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();

			//part 1 question 4
			int[] a, b;
			InitializeArrays(out a, out b);
			for (int i = 0; i < a.Length; i++)
			{
				Console.WriteLine(a[i]);
			}
			for (int i = 0; i < b.Length; i++)
			{
				Console.WriteLine(b[i]);
			}



		}

		private static void Multiply2(int i) //for part 1 question 1
		{
			i = i * 2;
			Console.WriteLine($"Multiplication of 2 of your number is {i}");
		}

		private static void InitializeArrays(out int[] a, out int[] b) //for part 1 question 4
		{
			Random r = new Random();
			a = new int[10];
			b = new int[10];
			for (int i = 0; i < 10; i++)
			{
				a[i] = r.Next(101);
				b[i] = r.Next(101);
			}
		}

	}
}
