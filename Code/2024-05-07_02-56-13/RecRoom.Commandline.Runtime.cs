using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface KGIBGGPNEII
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string CBDMOILACIF(string IDJMHOBOGAF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BMGNOJLDCIE(string IDJMHOBOGAF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PIHLKPMOHLG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[Preserve]
public class MPGOLCCCPKA : KGIBGGPNEII
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static List<string> JOLEFKKKANA;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] CHKFFNDHFPN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static string[] GKGENBBBJHO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string[] DJDDHKNJNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6131C60", Offset = "0x6130E60", VA = "0x186131C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string[] IFMOAMCOJAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6131C70", Offset = "0x6130E70", VA = "0x186131C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6131F30", Offset = "0x6131130", VA = "0x186131F30")]
	[KEFCCLBEAOJ(BDECECCJEGA.Root, CMEECPGEPNF.GameOnly)]
	private static void PALMNDDNMFI(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6131E10", Offset = "0x6131010", VA = "0x186131E10")]
	internal static string[] MMNENAPHDPF(string[] MJJHEGLAGFB, string[] CNHHKNIMHHO, List<string> PENDMPCKOLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6131B20", Offset = "0x6130D20", VA = "0x186131B20", Slot = "4")]
	private string EOGPJDOFGBC(string IDJMHOBOGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6131A70", Offset = "0x6130C70", VA = "0x186131A70")]
	public static string CBDMOILACIF(string IDJMHOBOGAF, [Optional] string FJPKGOAOIBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6131BC0", Offset = "0x6130DC0", VA = "0x186131BC0", Slot = "5")]
	private bool JGFGIHKJFAI(string IDJMHOBOGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61319D0", Offset = "0x6130BD0", VA = "0x1861319D0")]
	public static bool BMGNOJLDCIE(string IDJMHOBOGAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public MPGOLCCCPKA()
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
