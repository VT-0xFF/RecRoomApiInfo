using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class LXZKBOLNSXU
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8A60510", Offset = "0x8A5F110", VA = "0x188A60510")]
		public static KeepsakeTheme HAYTJCJQTAH(this FLHJXQNPHVS a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8A60450", Offset = "0x8A5F050", VA = "0x188A60450")]
		public static KeepsakeTheme HAYTJCJQTAH(this FLHJXQNPHVS a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8A60380", Offset = "0x8A5EF80", VA = "0x188A60380")]
		public static List<KeepsakeTheme> GDTPJJBYMST(this FLHJXQNPHVS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A60610", Offset = "0x8A5F210", VA = "0x188A60610")]
		public static KeepsakeCategory LSXGHRKFXRM(this FLHJXQNPHVS a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8A606B0", Offset = "0x8A5F2B0", VA = "0x188A606B0")]
		public static int ZEQUSWXQNVO(this FLHJXQNPHVS a, KeepsakeCategory b)
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
