﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Activity6
{
	class program
	{
		public static void Main(string[] args)
		{
			string data = "SXCOMPUTER";
			List<char> code = new List<char>();
			code.AddRange(data);
            int result;
            Console.WriteLine("X C O M P U T E R S");
			Console.Write("Enter Code: ");
			string input = Console.ReadLine();
			char[] charArr = input.ToCharArray();
            Console.Write("Equal Value: ");
            foreach (char item in charArr)
			{
                result = code.IndexOf(item) ;
				Console.Write("{0}", result);
			}
		}
	}
}