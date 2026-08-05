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
		[Cpp2IlInjected.Address(RVA = "0x9A5D090", Offset = "0x9A5C090", VA = "0x189A5D090")]
		public static KeepsakeTheme OXXHOJPVQXI(this XZQFVGGJDDL a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9A5CFD0", Offset = "0x9A5BFD0", VA = "0x189A5CFD0")]
		public static KeepsakeTheme OXXHOJPVQXI(this XZQFVGGJDDL a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9A5CE70", Offset = "0x9A5BE70", VA = "0x189A5CE70")]
		public static List<KeepsakeTheme> ILSILLPGKLS(this XZQFVGGJDDL a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A5CDD0", Offset = "0x9A5BDD0", VA = "0x189A5CDD0")]
		public static KeepsakeCategory AJNARVELKSJ(this XZQFVGGJDDL a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A5CF40", Offset = "0x9A5BF40", VA = "0x189A5CF40")]
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
