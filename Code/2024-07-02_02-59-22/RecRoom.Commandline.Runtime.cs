using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KPBKOPDJHOG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string ONFMJKHLHAJ(string JNNHDMKPDLF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PKDAENNCOPH(string JNNHDMKPDLF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum EFBAGCFBLLD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class LJKJOHBPJIG : KPBKOPDJHOG
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> NDBHGPBILOG;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] FOIBMIOPCEM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] GKGHDNLOFAO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] BAJCNGDBIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68A7E90", Offset = "0x68A6E90", VA = "0x1868A7E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] NMAPLIDFBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68A7AC0", Offset = "0x68A6AC0", VA = "0x1868A7AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68A7D90", Offset = "0x68A6D90", VA = "0x1868A7D90")]
	[PECFDJPHGEK(HCAAGBIMBOB.Root, BOIKMOKIOJG.None)]
	private static void JEEKJHILOBP(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68A7C70", Offset = "0x68A6C70", VA = "0x1868A7C70")]
	internal static string[] ILGKCNAPJIM(string[] GHFMOJIGPOG, string[] MKIGMLGDDCF, List<string> BNNNAIHMBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68A7980", Offset = "0x68A6980", VA = "0x1868A7980", Slot = "4")]
	private string AEJMHEIHECJ(string JNNHDMKPDLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68A7EA0", Offset = "0x68A6EA0", VA = "0x1868A7EA0")]
	public static string ONFMJKHLHAJ(string JNNHDMKPDLF, [Optional] string AJMLHGDNPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68A7A20", Offset = "0x68A6A20", VA = "0x1868A7A20", Slot = "5")]
	private bool ECEHOABIDDD(string JNNHDMKPDLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68A7F50", Offset = "0x68A6F50", VA = "0x1868A7F50")]
	public static bool PKDAENNCOPH(string JNNHDMKPDLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	public LJKJOHBPJIG()
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
