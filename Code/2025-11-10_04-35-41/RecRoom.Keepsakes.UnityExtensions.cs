using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class KIOYWUCTOKR
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82E5B80", Offset = "0x82E4F80", VA = "0x1882E5B80")]
		public static KeepsakeTheme CCBFHFXRGKA(this AXMYWMYZGOH a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x82E5C80", Offset = "0x82E5080", VA = "0x1882E5C80")]
		public static KeepsakeTheme CCBFHFXRGKA(this AXMYWMYZGOH a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82E5D40", Offset = "0x82E5140", VA = "0x1882E5D40")]
		public static List<KeepsakeTheme> LQBWTSQJNQO(this AXMYWMYZGOH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82E5E10", Offset = "0x82E5210", VA = "0x1882E5E10")]
		public static KeepsakeCategory LXVMYUJBTXV(this AXMYWMYZGOH a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82E5EB0", Offset = "0x82E52B0", VA = "0x1882E5EB0")]
		public static int YNHVEZFHVVH(this AXMYWMYZGOH a, KeepsakeCategory b)
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
