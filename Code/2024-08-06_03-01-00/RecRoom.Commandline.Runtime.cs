using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface OJKGMDIJJDL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string NDBLLALKBMO(string CJCGEMBCKKP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BOHJNFJLDBB(string CJCGEMBCKKP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum JKEAJFACHIH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class HHMBIEGAHCK : OJKGMDIJJDL
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> JLGJLJEKBAP;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] LEFFKDNEEHB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] PLPDKIBPIHH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] NNHBOBGMIDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68E8D70", Offset = "0x68E7370", VA = "0x1868E8D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] FCDCGDBEHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68E8D80", Offset = "0x68E7380", VA = "0x1868E8D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68E8BE0", Offset = "0x68E71E0", VA = "0x1868E8BE0")]
	[CCEDJDOPMOE(GIKFHLNFMKF.Root, CFIDNIINJOK.None)]
	private static void DGJGMJJCAOC(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68E8FD0", Offset = "0x68E75D0", VA = "0x1868E8FD0")]
	internal static string[] OGEMPBAAOLP(string[] JEBCKDHGOGA, string[] PPHJLNCJCFL, List<string> MKGEOJFMKIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68E8B40", Offset = "0x68E7140", VA = "0x1868E8B40", Slot = "4")]
	private string COEBKDGNIBL(string CJCGEMBCKKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68E8F20", Offset = "0x68E7520", VA = "0x1868E8F20")]
	public static string NDBLLALKBMO(string CJCGEMBCKKP, [Optional] string PBAONJMDGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68E8CD0", Offset = "0x68E72D0", VA = "0x1868E8CD0", Slot = "5")]
	private bool DOEHIHBGMAC(string CJCGEMBCKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68E8AA0", Offset = "0x68E70A0", VA = "0x1868E8AA0")]
	public static bool BOHJNFJLDBB(string CJCGEMBCKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public HHMBIEGAHCK()
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
