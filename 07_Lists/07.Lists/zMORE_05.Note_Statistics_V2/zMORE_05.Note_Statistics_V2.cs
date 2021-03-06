﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zMORE_05.Note_Statistics_V2
{
	class Program
	{
		static void Main(string[] args)
		{

			List<double> frequencies = new List<double> { 261.63, 277.18, 293.66, 311.13, 329.63
														, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88};

			List<string> notes = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

			List<double> inputFrequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
			List<string> notesOutput = new List<string>();
			List<string> naturals = new List<string>();
			List<string> sharps = new List<string>();

			double naturalsSum = 0;
			double sharpsSum = 0;

			foreach (double frequency in inputFrequencies)
			{
				int index = frequencies.IndexOf(frequency);

				if (isSharp(notes[index]))
				{
					sharps.Add(notes[index]);
					sharpsSum += frequencies[index];
				}
				else
				{
					naturals.Add(notes[index]);
					naturalsSum += frequencies[index];
				}

				notesOutput.Add(notes[index]);
			}

			Console.WriteLine("Notes: {0}", string.Join(" ", notesOutput));
			Console.WriteLine("Naturals: {0}", string.Join(", ", naturals));
			Console.WriteLine("Sharps: {0}", string.Join(", ", sharps));
			Console.WriteLine("Naturals sum: {0:0.##}", naturalsSum);
			Console.WriteLine("Sharps sum: {0:0.##}", sharpsSum);
		}

		private static bool isSharp(string input)
		{

			foreach (char ch in input)
			{
				if (ch =='#')
				{
					return true;
				}
			}
			return false;
		}
	}
}
