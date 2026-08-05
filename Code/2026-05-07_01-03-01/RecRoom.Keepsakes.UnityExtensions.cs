using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class LUATROOQNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x98A1480", Offset = "0x989FE80", VA = "0x1898A1480")]
		public static KeepsakeTheme IYIXIGOHTEO(this JPDSEFSZZXX a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98A1580", Offset = "0x989FF80", VA = "0x1898A1580")]
		public static KeepsakeTheme IYIXIGOHTEO(this JPDSEFSZZXX a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98A1640", Offset = "0x98A0040", VA = "0x1898A1640")]
		public static List<KeepsakeTheme> XBUMOHDXHXC(this JPDSEFSZZXX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98A13E0", Offset = "0x989FDE0", VA = "0x1898A13E0")]
		public static KeepsakeCategory GOXUBORIDXX(this JPDSEFSZZXX a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98A1710", Offset = "0x98A0110", VA = "0x1898A1710")]
		public static int ZUPCQVMVEWT(this JPDSEFSZZXX a, KeepsakeCategory b)
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
