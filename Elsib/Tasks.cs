using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elsib
{
		class Tasks
		{

				public static int [] task1(int [] array)
				{
						List<int> resultList = new List<int>();
						for (int i = 0, j = 1; i < array.Length; i++, j++)
						{
								while (array[i] > j)
								{
										resultList.Add(j);
										j++;
								}
						}
						return resultList.ToArray();
				}

				public static int[] task2(int [] array)
				{
						int [] result = new int[array.Length];
						for (int i = 0; i < array.Length; result[i] = (array[i] % 2 == 0) ? 1 : 0, i++) ;
						return result;
				}
				public static string task3(string str, char oldSym, char newSym)
				{
						int index = str.IndexOf(oldSym);
						return newSym + str.Substring(index + 1);
				}
		}
}
