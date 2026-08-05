using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.FileSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class HCBRKPOXRRO
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string RXMCZSZMFDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x99B71F0", Offset = "0x99B61F0", VA = "0x1899B71F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static string LIHIZNHGREC
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x99B7190", Offset = "0x99B6190", VA = "0x1899B7190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static string EQINNFQYDHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x99B7150", Offset = "0x99B6150", VA = "0x1899B7150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static string BMTWDRQNUXF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x99B7010", Offset = "0x99B6010", VA = "0x1899B7010")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99B7070", Offset = "0x99B6070", VA = "0x1899B7070")]
		public static string FHUZYCCNTQG([Optional] string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99B7260", Offset = "0x99B6260", VA = "0x1899B7260")]
		private static string POFSJDCKRSG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99B7300", Offset = "0x99B6300", VA = "0x1899B7300")]
		public static void QJXFGWSVASE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99B71D0", Offset = "0x99B61D0", VA = "0x1899B71D0")]
		public static bool KYBMODTQFWE(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99B7230", Offset = "0x99B6230", VA = "0x1899B7230")]
		public static void NFAHGNFTZDB(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99B73B0", Offset = "0x99B63B0", VA = "0x1899B73B0")]
		public static string VJIYPATWXRB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99B7050", Offset = "0x99B6050", VA = "0x1899B7050")]
		public static void EQALHTHSXOU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private static void WWOAAYJNGMS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void KRMWPJDZVDZ()
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
