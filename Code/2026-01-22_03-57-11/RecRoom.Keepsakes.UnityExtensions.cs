using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class XNCQREGHNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x835EBD0", Offset = "0x835D3D0", VA = "0x18835EBD0")]
		public static KeepsakeTheme XBUHNNZYCLD(this TTAMIDQIXCW a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x835ECD0", Offset = "0x835D4D0", VA = "0x18835ECD0")]
		public static KeepsakeTheme XBUHNNZYCLD(this TTAMIDQIXCW a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x835EA80", Offset = "0x835D280", VA = "0x18835EA80")]
		public static List<KeepsakeTheme> JRCUKDLKDUN(this TTAMIDQIXCW a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x835E9E0", Offset = "0x835D1E0", VA = "0x18835E9E0")]
		public static KeepsakeCategory ERJXAEZFEAM(this TTAMIDQIXCW a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x835EB40", Offset = "0x835D340", VA = "0x18835EB40")]
		public static int JXGUZJFWJHU(this TTAMIDQIXCW a, KeepsakeCategory b)
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
