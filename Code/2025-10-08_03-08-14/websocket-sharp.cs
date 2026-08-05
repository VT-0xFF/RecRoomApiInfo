using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("1.0.2.59611")]
namespace WebSocketSharp
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class Ext
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly byte[] _last;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly int _retry;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA3559D0", Offset = "0xA3547D0", VA = "0x18A3559D0")]
		public static bool IsNullOrEmpty(this string value)
		{
			return default(bool);
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
