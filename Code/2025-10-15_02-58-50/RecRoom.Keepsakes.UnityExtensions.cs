using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class BXFXYHGDHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84E0EF0", Offset = "0x84DFCF0", VA = "0x1884E0EF0")]
		public static KeepsakeTheme KWTGKXRVBSN(this QHYSLOEGHVU a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84E0E30", Offset = "0x84DFC30", VA = "0x1884E0E30")]
		public static KeepsakeTheme KWTGKXRVBSN(this QHYSLOEGHVU a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84E1080", Offset = "0x84DFE80", VA = "0x1884E1080")]
		public static List<KeepsakeTheme> WNTRMKCAWGB(this QHYSLOEGHVU a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84E0D90", Offset = "0x84DFB90", VA = "0x1884E0D90")]
		public static KeepsakeCategory KHIKQQPHPKY(this QHYSLOEGHVU a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84E0FF0", Offset = "0x84DFDF0", VA = "0x1884E0FF0")]
		public static int QAOASLWFPHY(this QHYSLOEGHVU a, KeepsakeCategory b)
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
