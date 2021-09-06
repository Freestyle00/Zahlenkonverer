using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenkonverter
{
	public partial class Rechner
	{
		public void Eingaben()
		{
			Console.WriteLine("Please input the base of your first number : ");
			string Base = Console.ReadLine();
			bool isParsable = isParsable = Int64.TryParse(Base, out long BaseInt);
			if (isParsable)
			{
				Console.WriteLine("Please give me the number to convert: ");
				string NumberToConvert = Console.ReadLine();
				Console.WriteLine("Please give me the Base to convert to (16/10/8/2):");
				string BaseToconvertTo = Console.ReadLine();
				bool IParsable2 = Int64.TryParse(BaseToconvertTo, out long BaseToConvertTo);
				if (IParsable2)
				{
					Converter converter = new Converter();
					try
					{
						Console.WriteLine(converter.ConverterFunc(NumberToConvert, (int)BaseInt, (int)BaseToConvertTo));
					}
					catch (OverflowException)
					{
						this.Exit("", 0);
					}
				}
				else { this.Exit("You need to input a number instead of "+"\""+BaseToconvertTo+"\"", 0); }
			}
			else { this.Exit("You need to input a number instead of "+"\""+Base+"\"", 0); }
		}
		private void Exit(string Message, int ExitCode) { Console.WriteLine(Message); Environment.Exit(ExitCode); }
	}
}
