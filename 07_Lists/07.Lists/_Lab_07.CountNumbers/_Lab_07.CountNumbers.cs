﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Lab_07.CountNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = Console.ReadLine()
						   .Split(' ')
						   .Select(int.Parse)
						   .ToList();

			numbers.Sort();
			numbers.Add(int.MaxValue);
			int count = 1;

			for (int i = 0; i < numbers.Count - 1; i++)
			{
				if (numbers[i] == numbers[i + 1])
				{
					count++;
				}
				else
				{
					Console.WriteLine($"{numbers[i]} -> {count}");
					count = 1;
				}
			}
		}
	}
}
