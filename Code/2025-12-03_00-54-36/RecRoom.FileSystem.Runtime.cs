using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.FileSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class NRGLPBAHXAX
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string YINYAVQBHFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x81CA810", Offset = "0x81C9410", VA = "0x1881CA810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static string RJHJDRJATMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x81CA7D0", Offset = "0x81C93D0", VA = "0x1881CA7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static string LUIUACEPNNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x81CA850", Offset = "0x81C9450", VA = "0x1881CA850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static string WTTZFFBWJQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x81CAA40", Offset = "0x81C9640", VA = "0x1881CAA40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x81CA6F0", Offset = "0x81C92F0", VA = "0x1881CA6F0")]
		public static string AVBHCWQTOCX([Optional] string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81CA9A0", Offset = "0x81C95A0", VA = "0x1881CA9A0")]
		private static string OHGNFENQZBX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81CA8B0", Offset = "0x81C94B0", VA = "0x1881CA8B0")]
		public static void IAPHDFZJQFJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81CA890", Offset = "0x81C9490", VA = "0x1881CA890")]
		public static bool GNCLTODDTBL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81CAA80", Offset = "0x81C9680", VA = "0x1881CAA80")]
		public static void YIYZOUSYIQK(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81CA960", Offset = "0x81C9560", VA = "0x1881CA960")]
		public static string ISIIUJUHNPM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81CA980", Offset = "0x81C9580", VA = "0x1881CA980")]
		public static void NVSROAGPTIV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void THYQONHXOOD()
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
