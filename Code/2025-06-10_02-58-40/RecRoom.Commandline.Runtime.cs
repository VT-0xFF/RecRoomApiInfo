using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_Commandline_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B72870", Offset = "0x7B71A70", VA = "0x187B72870", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface COFHFABNMHG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string PEGEFCDEPMC(string FEJLOJNEDNM);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PCHDGAJNJEA(string FEJLOJNEDNM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CHPOEBHDBKH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RecRoom.NoEngine.Common.Preserve]
public class IBFFHJCHGFD : COFHFABNMHG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> BPOPKBHADLG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] EENGEMCDGDB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] HNEICJIBBCI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] HICADCDDCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B725F0", Offset = "0x7B717F0", VA = "0x187B725F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] LMJFFAAMBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B72200", Offset = "0x7B71400", VA = "0x187B72200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7B724F0", Offset = "0x7B716F0", VA = "0x187B724F0")]
	[MGCKGAIBEHC.PCMIGKEOIEO]
	internal static void LDPAGBHHOJF(FJCFOKJAKFO MBLPEFIMNGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B72750", Offset = "0x7B71950", VA = "0x187B72750")]
	internal static string[] PMNBMDPEHDF(string[] PABOMHIFMLC, string[] LDMIPKDNHBC, List<string> DNKJKPIIPHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7B723A0", Offset = "0x7B715A0", VA = "0x187B723A0", Slot = "4")]
	private string JLOPGDKGJOK(string FEJLOJNEDNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B726A0", Offset = "0x7B718A0", VA = "0x187B726A0")]
	public static string PEGEFCDEPMC(string FEJLOJNEDNM, [Optional] string FEOJADDJKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B72450", Offset = "0x7B71650", VA = "0x187B72450", Slot = "5")]
	private bool KCODPOBNHLO(string FEJLOJNEDNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B72600", Offset = "0x7B71800", VA = "0x187B72600")]
	public static bool PCHDGAJNJEA(string FEJLOJNEDNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public IBFFHJCHGFD()
	{
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
