using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] bank = { 1,2,3,4,5,6,7,8,9 };

			foreach (int name in bank)
			{
				Console.Write(name%2);
			}
			Console.ReadKey();
		}
	}
}
