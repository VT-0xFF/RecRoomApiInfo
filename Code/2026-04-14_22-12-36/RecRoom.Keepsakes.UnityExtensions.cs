using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CYFZKHRULID
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x98BBB60", Offset = "0x98BA760", VA = "0x1898BBB60")]
		public static KeepsakeTheme OXXHOJPVQXI(this XZQFVGGJDDL a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98BBAB0", Offset = "0x98BA6B0", VA = "0x1898BBAB0")]
		public static KeepsakeTheme OXXHOJPVQXI(this XZQFVGGJDDL a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98BB960", Offset = "0x98BA560", VA = "0x1898BB960")]
		public static List<KeepsakeTheme> ILSILLPGKLS(this XZQFVGGJDDL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98BB8C0", Offset = "0x98BA4C0", VA = "0x1898BB8C0")]
		public static KeepsakeCategory AJNARVELKSJ(this XZQFVGGJDDL a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98BBA20", Offset = "0x98BA620", VA = "0x1898BBA20")]
		public static int IQLQJWAUZOD(this XZQFVGGJDDL a, KeepsakeCategory b)
		{
			return default(int);
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
