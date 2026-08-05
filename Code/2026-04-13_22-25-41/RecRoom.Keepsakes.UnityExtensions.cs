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
		[Cpp2IlInjected.Address(RVA = "0x98BA0B0", Offset = "0x98B8AB0", VA = "0x1898BA0B0")]
		public static KeepsakeTheme OXXHOJPVQXI(this XZQFVGGJDDL a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98BA000", Offset = "0x98B8A00", VA = "0x1898BA000")]
		public static KeepsakeTheme OXXHOJPVQXI(this XZQFVGGJDDL a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98B9EB0", Offset = "0x98B88B0", VA = "0x1898B9EB0")]
		public static List<KeepsakeTheme> ILSILLPGKLS(this XZQFVGGJDDL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98B9E10", Offset = "0x98B8810", VA = "0x1898B9E10")]
		public static KeepsakeCategory AJNARVELKSJ(this XZQFVGGJDDL a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98B9F70", Offset = "0x98B8970", VA = "0x1898B9F70")]
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
