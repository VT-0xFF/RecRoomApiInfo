using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class ZYFXTIEWLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x822CAF0", Offset = "0x822B6F0", VA = "0x18822CAF0")]
		public static KeepsakeTheme DJPNERHKVDT(this OSBOCOKDSKG a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x822CA40", Offset = "0x822B640", VA = "0x18822CA40")]
		public static KeepsakeTheme DJPNERHKVDT(this OSBOCOKDSKG a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x822CD20", Offset = "0x822B920", VA = "0x18822CD20")]
		public static List<KeepsakeTheme> WYUQAEIHBOF(this OSBOCOKDSKG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x822CC80", Offset = "0x822B880", VA = "0x18822CC80")]
		public static KeepsakeCategory QUXKJUDOOWU(this OSBOCOKDSKG a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x822CBF0", Offset = "0x822B7F0", VA = "0x18822CBF0")]
		public static int QNVCSHJSZAW(this OSBOCOKDSKG a, KeepsakeCategory b)
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
