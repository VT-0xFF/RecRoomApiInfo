using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.FileSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class GRQYWTHYNHB
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string EMVMKCVRPUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x84993A0", Offset = "0x84983A0", VA = "0x1884993A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static string DRUVPIAWREB
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8499400", Offset = "0x8498400", VA = "0x188499400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static string BKYBRWCJQJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8499330", Offset = "0x8498330", VA = "0x188499330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static string LQEHVLDWHWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8499520", Offset = "0x8498520", VA = "0x188499520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8499440", Offset = "0x8498440", VA = "0x188499440")]
		public static string XGDZFPVFFPZ([Optional] string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84991A0", Offset = "0x84981A0", VA = "0x1884991A0")]
		private static string CFYDLSQXJMB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8499280", Offset = "0x8498280", VA = "0x188499280")]
		public static void FOXKPJQCMID(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8499240", Offset = "0x8498240", VA = "0x188499240")]
		public static bool CLSOWXDBVSJ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8499370", Offset = "0x8498370", VA = "0x188499370")]
		public static void HSJXQSXIXGS(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84993E0", Offset = "0x84983E0", VA = "0x1884993E0")]
		public static string MWHXAWSCVSW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8499260", Offset = "0x8498260", VA = "0x188499260")]
		public static void DFZKYIIUFWJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private static void VFIOKTIWAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void MAQKCQECQPC()
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
