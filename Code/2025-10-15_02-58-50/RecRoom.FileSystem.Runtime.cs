using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.FileSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class RWCLOACBWZZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string TUWKCTBANOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x847EAD0", Offset = "0x847D8D0", VA = "0x18847EAD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static string TKLAUAXLLQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x847E9C0", Offset = "0x847D7C0", VA = "0x18847E9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static string MAFUCBVBCNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x847EB90", Offset = "0x847D990", VA = "0x18847EB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static string LFQASKLWJFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x847EB50", Offset = "0x847D950", VA = "0x18847EB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x847E8E0", Offset = "0x847D6E0", VA = "0x18847E8E0")]
		public static string BDQRNGDNOOX([Optional] string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x847EBD0", Offset = "0x847D9D0", VA = "0x18847EBD0")]
		private static string XKQFMXUOWCR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x847EA20", Offset = "0x847D820", VA = "0x18847EA20")]
		public static void FNKQNICUXOT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x847EB30", Offset = "0x847D930", VA = "0x18847EB30")]
		public static bool PAIMBFMXKNP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x847E8B0", Offset = "0x847D6B0", VA = "0x18847E8B0")]
		public static void AOSIFRASQIC(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x847EA00", Offset = "0x847D800", VA = "0x18847EA00")]
		public static string DBAMJPBVSBM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x847EB10", Offset = "0x847D910", VA = "0x18847EB10")]
		public static void LHMBDMQOAZH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180")]
		private static void YBWGAURAASD()
		{
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
