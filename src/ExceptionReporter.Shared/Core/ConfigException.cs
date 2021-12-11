using System;

namespace ExceptionReporting.Shared.Core
{
  internal class ConfigException : Exception
  {
	public ConfigException(string message) : base(message) { }
  }

}