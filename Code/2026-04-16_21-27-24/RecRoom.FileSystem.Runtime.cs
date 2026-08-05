using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.FileSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class WBMILFSWBDT
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string QNGYMRAQVBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9840340", Offset = "0x983F140", VA = "0x189840340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static string IKPQBAKECOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9840170", Offset = "0x983EF70", VA = "0x189840170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static string XIMSWEMCDQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x98402C0", Offset = "0x983F0C0", VA = "0x1898402C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static string KXGIOLXVWQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9840130", Offset = "0x983EF30", VA = "0x189840130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98401E0", Offset = "0x983EFE0", VA = "0x1898401E0")]
		public static string PGBAZORVKAB([Optional] string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x983FFC0", Offset = "0x983EDC0", VA = "0x18983FFC0")]
		private static string AXZIHTYUECD(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9840060", Offset = "0x983EE60", VA = "0x189840060")]
		public static void BOIGZXZRLDD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9840320", Offset = "0x983F120", VA = "0x189840320")]
		public static bool UXSOYAIXYJN(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x98401B0", Offset = "0x983EFB0", VA = "0x1898401B0")]
		public static void OVJGFSSYJTW(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9840300", Offset = "0x983F100", VA = "0x189840300")]
		public static string RABSOCJTXSQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9840110", Offset = "0x983EF10", VA = "0x189840110")]
		public static void CBISVYIBASL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		private static void VRMECMTCVZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public static void TFPHBGJYLAK()
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
