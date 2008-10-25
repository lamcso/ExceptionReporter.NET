using System.Collections.Generic;
using System.Configuration;
using ExceptionReporting.Config;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace Test.ExceptionReporter
{
	[TestFixture]
	public class ConfigReaderTest
	{
		[Test]
		public void CanCreate_ConfigStringList_With_1()
		{
			// using ConfigurationManager.AppSettings in a UnitTest works, although brittle (and could cause issues one day)
			// because the settings added are compounded for each test (you can't erase a config key once you've added it)
			ConfigurationManager.AppSettings["AKey"] = "AValue";

			IList<string> stringList = ConfigReader.GetConfigKeyValuePairsToString();

			Assert.That(stringList.Count, Is.EqualTo(1));
			Assert.That(stringList[0], Is.EqualTo("AKey = AValue"));
		}

		[Test]
		public void CanCreate_ConfigStringList_With_2()
		{
			ConfigurationManager.AppSettings["Key2"] = "Value2";

			IList<string> stringList = ConfigReader.GetConfigKeyValuePairsToString();

			Assert.That(stringList.Count, Is.EqualTo(2));
			Assert.That(stringList[0], Is.EqualTo("AKey = AValue"));
			Assert.That(stringList[1], Is.EqualTo("Key2 = Value2"));
		}
	}
}