using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class XCUDKORDCSY
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84FAD50", Offset = "0x84F9D50", VA = "0x1884FAD50")]
		public static KeepsakeTheme BXNOLIYMXUB(this NNUSJCDIHWS a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84FAC90", Offset = "0x84F9C90", VA = "0x1884FAC90")]
		public static KeepsakeTheme BXNOLIYMXUB(this NNUSJCDIHWS a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84FAEF0", Offset = "0x84F9EF0", VA = "0x1884FAEF0")]
		public static List<KeepsakeTheme> SATZAYNUVFX(this NNUSJCDIHWS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84FAE50", Offset = "0x84F9E50", VA = "0x1884FAE50")]
		public static KeepsakeCategory FBKXMNWYZLW(this NNUSJCDIHWS a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84FAFC0", Offset = "0x84F9FC0", VA = "0x1884FAFC0")]
		public static int XWTSOMDOJQG(this NNUSJCDIHWS a, KeepsakeCategory b)
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
