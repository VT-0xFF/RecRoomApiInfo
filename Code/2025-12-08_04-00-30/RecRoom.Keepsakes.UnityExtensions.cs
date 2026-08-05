using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class EMYIDDYDGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82A36B0", Offset = "0x82A1EB0", VA = "0x1882A36B0")]
		public static KeepsakeTheme TPADVDRGQCN(this ZHJTAMFGQEW a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x82A37B0", Offset = "0x82A1FB0", VA = "0x1882A37B0")]
		public static KeepsakeTheme TPADVDRGQCN(this ZHJTAMFGQEW a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82A3860", Offset = "0x82A2060", VA = "0x1882A3860")]
		public static List<KeepsakeTheme> XVDIZZMGMFH(this ZHJTAMFGQEW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82A3580", Offset = "0x82A1D80", VA = "0x1882A3580")]
		public static KeepsakeCategory ECMXDFGBNEI(this ZHJTAMFGQEW a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82A3620", Offset = "0x82A1E20", VA = "0x1882A3620")]
		public static int SIBTETRYDVI(this ZHJTAMFGQEW a, KeepsakeCategory b)
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
