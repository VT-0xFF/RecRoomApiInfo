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
		[Cpp2IlInjected.Address(RVA = "0x9E8DC30", Offset = "0x9E8C630", VA = "0x189E8DC30")]
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
