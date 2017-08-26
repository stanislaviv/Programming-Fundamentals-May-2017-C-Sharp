﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _Lab._04.MatchDates
{
	class Program
	{
		static void Main(string[] args)
		{
			var regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
			
			var datesString = Console.ReadLine();

			MatchCollection dates = Regex.Matches(datesString, regex);

			foreach (Match date in dates)
			{
				var day = date.Groups["day"].Value;
				var month = date.Groups["month"].Value;
				var year = date.Groups["year"].Value;

				Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

			}
		}
	}
}
