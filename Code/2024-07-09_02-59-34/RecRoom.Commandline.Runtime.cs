using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface ADDINENLEJI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string IGNJFBMGOFO(string LOLFBCCGJCN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEIHJHCDGAG(string LOLFBCCGJCN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum KJELKMPFHCM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class ODLEFMKIIEC : ADDINENLEJI
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> MFHMELNNNJF;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] EDEHJAGAGDE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] IHBHAADKAJI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] HJLOFLHDKCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69059F0", Offset = "0x69045F0", VA = "0x1869059F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] ELDMLIGEOFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6905A00", Offset = "0x6904600", VA = "0x186905A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6905860", Offset = "0x6904460", VA = "0x186905860")]
	[DHOHFCLMOGD(OBGPNJNCONH.Root, IDHBAGABJJA.None)]
	private static void MHPOAGMJOPB(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6905550", Offset = "0x6904150", VA = "0x186905550")]
	internal static string[] BBDLGKNODNA(string[] KKDHABGEIJA, string[] CKBGIGFADAD, List<string> LJPDLIJCDDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6905950", Offset = "0x6904550", VA = "0x186905950", Slot = "4")]
	private string NJJBMEPMJAF(string LOLFBCCGJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6905670", Offset = "0x6904270", VA = "0x186905670")]
	public static string IGNJFBMGOFO(string LOLFBCCGJCN, [Optional] string APDNGABBFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69057C0", Offset = "0x69043C0", VA = "0x1869057C0", Slot = "5")]
	private bool JOBMNMAIJLH(string LOLFBCCGJCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6905720", Offset = "0x6904320", VA = "0x186905720")]
	public static bool JEIHJHCDGAG(string LOLFBCCGJCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public ODLEFMKIIEC()
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
