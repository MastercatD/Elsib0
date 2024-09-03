using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elsib
{
		class Program
		{

				static void Main(string[] args)
				{
						int[] array1 = { 1, 2, 4, 5, 6, 8, 10 };
						//	1 задача
						Console.WriteLine("Task 1:");
						Console.WriteLine(string.Join(", ", Tasks.task1(array1)));
						//	2 задача
						Tasks.task2(array1);
						Console.WriteLine("Task 2:");
						Console.WriteLine(string.Join(", ", Tasks.task2(array1)));
						//	3 задача
						string str = "Hello morld!";
						Console.WriteLine("Task 3:");
						char oldSym = 'm', newSym = 'w';
						Console.WriteLine(Tasks.task3(str, oldSym, newSym));
				}
		}
}
