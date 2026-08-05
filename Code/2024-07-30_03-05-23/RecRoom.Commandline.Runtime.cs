using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KNHMAAMHPJM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HNKJDALOOBI(string PBJFNDLHABE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KPGNLPLLBHC(string PBJFNDLHABE);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum HKEAFNHPBMI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class HLJGEPJNLGN : KNHMAAMHPJM
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> JHNNKKNEAJD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] PBABHILPHDE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] LOFFPMPNHDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] NGAEIGAPLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x693BE70", Offset = "0x693A470", VA = "0x18693BE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] CCJILHNICOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x693BA30", Offset = "0x693A030", VA = "0x18693BA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x693B810", Offset = "0x6939E10", VA = "0x18693B810")]
	[ILMJIPMJHLC(LIEKAGJMIGB.Root, IAFNNCJJPGN.None)]
	private static void APAJJDIPHPG(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x693B910", Offset = "0x6939F10", VA = "0x18693B910")]
	internal static string[] CEPBBDEKDAL(string[] OCCJOIPKEGP, string[] DFPPMCCKAPI, List<string> FPEOPFPLHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x693BBE0", Offset = "0x693A1E0", VA = "0x18693BBE0", Slot = "4")]
	private string GNMAAELBBDA(string PBJFNDLHABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x693BC80", Offset = "0x693A280", VA = "0x18693BC80")]
	public static string HNKJDALOOBI(string PBJFNDLHABE, [Optional] string DNKAMNBGFFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x693BDD0", Offset = "0x693A3D0", VA = "0x18693BDD0", Slot = "5")]
	private bool LCMHEDIIOFA(string PBJFNDLHABE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x693BD30", Offset = "0x693A330", VA = "0x18693BD30")]
	public static bool KPGNLPLLBHC(string PBJFNDLHABE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public HLJGEPJNLGN()
	{
	}
}
namespace Cpp2IlInjected;

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
