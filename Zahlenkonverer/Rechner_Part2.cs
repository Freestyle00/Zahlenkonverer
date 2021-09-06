﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zahlenkonverter
{
	public partial class Rechner
	{
		public class Converter
		{
			private Dictionary<int, string> NumbersIntToString = new Dictionary<int, string>() { { 0, "0" }, { 1, "1" }, { 2, "2" }, { 3, "3" }, { 4, "4" }, { 5, "5" }, { 6, "6" }, { 7, "7" }, { 8, "8" }, { 9, "9" }, { 10, "A" }, { 11, "B" }, {12, "C" }, {13, "D" }, {14, "E" }, {15, "F" }  };
			private Dictionary<string, int> NumbersStringToInt = new Dictionary<string, int>() { { "0", 0 }, { "1", 1 }, { "2", 2 }, { "3", 3 }, {"4", 4 }, { "5", 5 }, { "6", 6 }, { "7", 7 }, { "8", 8 }, {"9", 9 }, { "A", 10 }, { "B", 11 }, { "C", 12 }, { "D", 13 }, { "E", 14 }, { "F", 15 } };
			public string ConverterFunc(string InNumber, int InBase, int OutBase) //i want to applaude to microsoft for giving me state of the art testing tools which are non exitent and have to be pulled from some random corner of the internet which i cant find *applause*
			{
				string Number;
				if (InBase == 10)
				{
					
					
				}
				else if (OutBase == 10)
				{
					return "" + ToBase10(InNumber, InBase);
				}
				return "shut";
			}
			private int ToBase10(string InNumber, int InBase)
			{
				string InNumberCor = InvertString(InNumber);
				int OutNumber = 0;
				int index = 0;
				//F5A
				foreach (char I in InNumberCor)
				{
					string Istring = "" + I; //Why wis this so hard to pull off
					NumbersStringToInt.TryGetValue(Istring, out int CurrentInt);
					OutNumber += CurrentInt * (int)Math.Pow((double)InBase ,(double)index);
					index++;
				}
				return OutNumber;
			}
			private string InvertString(string ToBeInverted)
			{
				char[] charArray = ToBeInverted.ToCharArray();
				Array.Reverse(charArray);
				return new string(charArray);
			}
		}
	}
}
