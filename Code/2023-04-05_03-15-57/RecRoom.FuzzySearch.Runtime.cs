using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class MJNIBDMBLIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly IDMADNADIJI ELMDOCMPKBK;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class IDMADNADIJI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate int IEGANCBLBKN(IReadOnlyList<char> BECFNFMFENI, int GBGHOLJCLHP, string CPBMOMLCDIK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly GJPFBCGPJDB NLJAIAAMHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly IEGANCBLBKN CIIECKPIPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly char[] ECEAGLLKMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly IPEOKONAFPB[] NMHEFOCBLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly bool[] NLGKBPLGNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] MMLMMEHEILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly IPEOKONAFPB[] DDHJBNNFGAP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E6170", Offset = "0x6E5170", VA = "0x1806E6170")]
	public static int GJKOHBCGMKG(IReadOnlyList<char> BECFNFMFENI, int GBGHOLJCLHP, string CPBMOMLCDIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6691FA0", Offset = "0x6690FA0", VA = "0x186691FA0")]
	public IDMADNADIJI(IReadOnlyCollection<string> MDLPCOKOOJK, in GJPFBCGPJDB DIPDOLLDPNK, [Optional] IEGANCBLBKN INDIPKGCADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6691F00", Offset = "0x6690F00", VA = "0x186691F00")]
	public string HDKCLOHJBGP(string EDBBFPGDGDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6691F90", Offset = "0x6690F90", VA = "0x186691F90")]
	public int HHOHIEMNAOE(int LFGEPLHBAOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6691830", Offset = "0x6690830", VA = "0x186691830")]
	public int BGOOFNEFLEP(string EDBBFPGDGDD, int EFEINHNAMFG, int LFDNBDCEMOH, ref int GBGHOLJCLHP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct GJPFBCGPJDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool DEAGENAKOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool ENOGNBMIOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int MOBLGDNFHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly int MIKFCIJADAB;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly GJPFBCGPJDB LCPPKENAKOJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GJPFBCGPJDB LMPNKNOCBFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6691750", Offset = "0x6690750", VA = "0x186691750")]
		get
		{
			return default(GJPFBCGPJDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6691810", Offset = "0x6690810", VA = "0x186691810")]
	public GJPFBCGPJDB(bool POJOBPNJLMJ, bool CGPFNKNMOAM, int HGNFPMEALDB, int JGFAFKDKHHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct IPEOKONAFPB : IEquatable<IPEOKONAFPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int NOAKOLDJPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int BGOOFNEFLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int BAAPKCELIGF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0xE96F20", Offset = "0xE95F20", VA = "0x180E96F20")]
	public IPEOKONAFPB(int EGBCAPEEJBF, int CAJBENPMIDP, int ICEDKCOPKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x66928B0", Offset = "0x66918B0", VA = "0x1866928B0")]
	public static int ABGLIMBPGBI(in IPEOKONAFPB AJDPMFOKMPC, in IPEOKONAFPB DAAPHBHBHCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x551A990", Offset = "0x5519990", VA = "0x18551A990", Slot = "4")]
	public bool Equals(IPEOKONAFPB JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x66928D0", Offset = "0x66918D0", VA = "0x1866928D0", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6692980", Offset = "0x6691980", VA = "0x186692980", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ABDEFKJJHNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IDMADNADIJI ELMDOCMPKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private string LKIFEJGOBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int HNAABHDIDEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int JBBPFOHFOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int LIIKHGPFJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int DBBICOONFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Func<bool> FGHKGIONJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private GFHMIECOIDH DHLJFMJDBIP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<IPEOKONAFPB> NGIBDJDFICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x718E90", Offset = "0x717E90", VA = "0x180718E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> INDGAKIJKHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8B6BE0", Offset = "0x8B5BE0", VA = "0x1808B6BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x66916B0", Offset = "0x66906B0", VA = "0x1866916B0")]
	public ABDEFKJJHNJ(IReadOnlyCollection<string> MDLPCOKOOJK, in GJPFBCGPJDB DIPDOLLDPNK, [Optional] IDMADNADIJI.IEGANCBLBKN INDIPKGCADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6691330", Offset = "0x6690330", VA = "0x186691330")]
	public bool ACNMKOHBBPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x66914E0", Offset = "0x66904E0", VA = "0x1866914E0")]
	public void CKIFMHIFFGP(string EDBBFPGDGDD, int OFJDFHLGFBG, Func<bool> IELNCFNHIDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LICCMEPMPFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void EBAGKPKOMMK(IReadOnlyList<IPEOKONAFPB> DBIGCGIMDJD, IReadOnlyList<bool> PKLAKCIJGHO);

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const int GIDDKFNKHLF = 100;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const double EKAOCNOCIKE = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly ABDEFKJJHNJ MKAPADMBKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly EBAGKPKOMMK FLEOLJBBOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MonoBehaviour LMDGGILPMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int DBBICOONFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly double PHHHCFOODJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Stopwatch JJDNCLEFGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private IDisposable DAPNMNPJOKM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<IPEOKONAFPB> NGIBDJDFICF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x45BE400", Offset = "0x45BD400", VA = "0x1845BE400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> INDGAKIJKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6692BB0", Offset = "0x6691BB0", VA = "0x186692BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LABIELHAHMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x77FBE0", Offset = "0x77EBE0", VA = "0x18077FBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double FMDNMJEBLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6692AD0", Offset = "0x6691AD0", VA = "0x186692AD0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6692E90", Offset = "0x6691E90", VA = "0x186692E90")]
	public LICCMEPMPFO(IReadOnlyCollection<string> MDLPCOKOOJK, in GJPFBCGPJDB DIPDOLLDPNK, EBAGKPKOMMK DEPINNJFJKO, MonoBehaviour MFEOJPNCOBA, [Optional] IDMADNADIJI.IEGANCBLBKN INDIPKGCADB, int OFJDFHLGFBG = 100, double EICGPNKHAOO = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6692C90", Offset = "0x6691C90", VA = "0x186692C90")]
	public void OPLEOLDCLGN(string EDBBFPGDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6692BE0", Offset = "0x6691BE0", VA = "0x186692BE0")]
	private bool KOIDDNKKMLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x66929F0", Offset = "0x66919F0", VA = "0x1866929F0")]
	private void ACNMKOHBBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6692B60", Offset = "0x6691B60", VA = "0x186692B60", Slot = "4")]
	public void Dispose()
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
