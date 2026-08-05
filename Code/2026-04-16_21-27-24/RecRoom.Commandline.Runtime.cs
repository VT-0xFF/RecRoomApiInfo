using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.NoEngine.Common;
using UJect;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x97433A0", Offset = "0x97421A0", VA = "0x1897433A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29EF0F0", Offset = "0x29EDEF0", VA = "0x1829EF0F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface JAQTYTFINJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string AQRIJSAXHOW(string a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IEBVRDEJLXQ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.NoEngine.Common.Preserve]
	public class CommandLineManager : JAQTYTFINJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static List<string> ZTWSGOIUSSN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static string[] EPAPACWHIVI;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static string[] PMCEWJNDKHC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static string[] WTOWYGEKUJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9742FB0", Offset = "0x9741DB0", VA = "0x189742FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static string[] JEYTTYBIPAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9742FC0", Offset = "0x9741DC0", VA = "0x189742FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9743210", Offset = "0x9742010", VA = "0x189743210")]
		[CXDXQIFYXBD.Root]
		internal static void WESKAKIVYCE(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9742EA0", Offset = "0x9741CA0", VA = "0x189742EA0")]
		internal static string[] QAUMYMGWGIK(string[] a, string[] b, List<string> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9743160", Offset = "0x9741F60", VA = "0x189743160", Slot = "4")]
		private string UNRBXLECPRJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9742D50", Offset = "0x9741B50", VA = "0x189742D50")]
		public static string AQRIJSAXHOW(string a, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9743300", Offset = "0x9742100", VA = "0x189743300", Slot = "5")]
		private bool YYTDQAIRAXF(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9742E00", Offset = "0x9741C00", VA = "0x189742E00")]
		public static bool IEBVRDEJLXQ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		public CommandLineManager()
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
