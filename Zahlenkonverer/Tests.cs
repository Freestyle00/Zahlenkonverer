using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zahlenkonverter;

namespace Zahlenkonverter
{
	[TestClass]
	public class MyTestClass
	{
		Rechner rechner = new Rechner();
		Zahlenkonverter.Rechner.Converter converter = new Rechner.Converter();
		[TestMethod]
		public void FromBase16ToBase10()
		{
			const string HEX = "FFD78";
			const string DEC = "1047928";
			Assert.AreEqual(DEC, converter.ConverterFunc(HEX, 16, 10));
		}
		[TestMethod]
		public void FromBase10ToBase16()
		{
			const string DEC = "92673";
			const string HEX = "16A01";
			Assert.AreEqual(HEX, converter.ConverterFunc(DEC, 10, 16));
		}
		[TestMethod]
		public void FromBase2ToBase16()
		{
			const string BIN = "100101010101";
			const string HEX = "955";
			Assert.AreEqual(HEX, converter.ConverterFunc(BIN, 2, 16));
		}
		[TestMethod]
		public void FromBase16ToBase2()
		{
			const string HEX = "";
			const string BIN = "";
			Assert.AreEqual(BIN,converter.ConverterFunc(HEX, 16, 2));
		}
	}
}
