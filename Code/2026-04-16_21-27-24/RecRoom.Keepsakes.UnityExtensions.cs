using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class QUEIASWLDZQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x98A29B0", Offset = "0x98A17B0", VA = "0x1898A29B0")]
		public static KeepsakeTheme NBYOUSRDURF(this DAJULMVXOXO a, Guid b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98A2900", Offset = "0x98A1700", VA = "0x1898A2900")]
		public static KeepsakeTheme NBYOUSRDURF(this DAJULMVXOXO a, KeepsakeCategory b)
		{
			return default(KeepsakeTheme);
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98A27A0", Offset = "0x98A15A0", VA = "0x1898A27A0")]
		public static List<KeepsakeTheme> FGGYASGBEGH(this DAJULMVXOXO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98A2860", Offset = "0x98A1660", VA = "0x1898A2860")]
		public static KeepsakeCategory KUHBATUDBXU(this DAJULMVXOXO a, Guid b)
		{
			return default(KeepsakeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x98A2AB0", Offset = "0x98A18B0", VA = "0x1898A2AB0")]
		public static int NIASORGQRKQ(this DAJULMVXOXO a, KeepsakeCategory b)
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
