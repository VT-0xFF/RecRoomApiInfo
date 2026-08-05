using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class KBODALJBHOC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate int IIJEFNLLBIB(IReadOnlyList<char> MKHFNNGHHCJ, int AIOGOCFKMDI, string JBMAFDMHLNN);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AFBGENIPNDK DMNJMMPOOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IIJEFNLLBIB OHLPDMKKLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly char[] ICICJMCGMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly NDIBMFKCNOF[] DINKFKOMONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly bool[] BBKGIJJGBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] OAJNEKHNJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly NDIBMFKCNOF[] NLPPALNBNCK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x57FE80", Offset = "0x57F280", VA = "0x18057FE80")]
	public static int JGLPHFCJAKI(IReadOnlyList<char> MKHFNNGHHCJ, int AIOGOCFKMDI, string JBMAFDMHLNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4DA60B0", Offset = "0x4DA54B0", VA = "0x184DA60B0")]
	public KBODALJBHOC(IReadOnlyCollection<string> FAABDMOLHID, in AFBGENIPNDK PGIEKFMPOOM, [Optional] IIJEFNLLBIB BPPJCBPONGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4DA58B0", Offset = "0x4DA4CB0", VA = "0x184DA58B0")]
	public string DPIAHOPHBIH(string GCNKCIEJJBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4DA58A0", Offset = "0x4DA4CA0", VA = "0x184DA58A0")]
	public int CKFJHDNLAPH(int IILBKFAMHPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5930", Offset = "0x4DA4D30", VA = "0x184DA5930")]
	public int HPCPLLMACEF(string GCNKCIEJJBI, int ICFLHEABEJN, int JHEIKAFKDFG, ref int AIOGOCFKMDI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct AFBGENIPNDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly bool EODPCPICJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool HPCKGDMFOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly int EPCFIPPPFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int GKOECNIKFAK;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly AFBGENIPNDK KMKOCBFGKDD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AFBGENIPNDK NHBAGNNNDIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5010", Offset = "0x4DA4410", VA = "0x184DA5010")]
		get
		{
			return default(AFBGENIPNDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4DA50D0", Offset = "0x4DA44D0", VA = "0x184DA50D0")]
	public AFBGENIPNDK(bool BLOLHKPDBGD, bool FBHILDLPGKA, int HMEJMAHHCIJ, int BPKIPJMAOFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct NDIBMFKCNOF : IEquatable<NDIBMFKCNOF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int EEKKOADMDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int HPCPLLMACEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int JMDLIMHJNPH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x887D40", Offset = "0x887140", VA = "0x180887D40")]
	public NDIBMFKCNOF(int DBFCFFLFJDL, int NAPHNBMCIPP, int KJGOBDDNGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4DA69C0", Offset = "0x4DA5DC0", VA = "0x184DA69C0")]
	public static int NFCALFEPABP(in NDIBMFKCNOF NCCAGEJPKHF, in NDIBMFKCNOF LIGCOAKACCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F45330", Offset = "0x3F44730", VA = "0x183F45330", Slot = "4")]
	public bool Equals(NDIBMFKCNOF OGCBGOIPCGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4DA68A0", Offset = "0x4DA5CA0", VA = "0x184DA68A0", Slot = "0")]
	public override bool Equals(object CMGFKLKICHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6950", Offset = "0x4DA5D50", VA = "0x184DA6950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OJNOMMJCGKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KBODALJBHOC JKJABAHJJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private string FBLMKFLEFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int KOOPIMKJGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int AHHNGKFFLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int NHFPADGDEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int IPJINKILICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Func<bool> JPBAAJJPLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private DNGBBONCDJE AMAIOGPGFAE;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<NDIBMFKCNOF> GJICKKKLKML
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x780C30", Offset = "0x780030", VA = "0x180780C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> EGKJGGEBPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1A5F8C0", Offset = "0x1A5ECC0", VA = "0x181A5F8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6D10", Offset = "0x4DA6110", VA = "0x184DA6D10")]
	public OJNOMMJCGKG(IReadOnlyCollection<string> FAABDMOLHID, in AFBGENIPNDK PGIEKFMPOOM, [Optional] KBODALJBHOC.IIJEFNLLBIB BPPJCBPONGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4DA69E0", Offset = "0x4DA5DE0", VA = "0x184DA69E0")]
	public bool HFDDNLHDFLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6B70", Offset = "0x4DA5F70", VA = "0x184DA6B70")]
	public void LKPAKPIFAPJ(string GCNKCIEJJBI, int FKCKLKEJAGM, Func<bool> GOANNMJICKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class DMCKFOPMHPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void CAENCAFGFDA(IReadOnlyList<NDIBMFKCNOF> FEHAJANCAHE, IReadOnlyList<bool> IKFBJHCFIMM);

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int PCJMHCEAPEK = 100;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const double LGICMOLEGPJ = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly OJNOMMJCGKG DDBANJBEDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly CAENCAFGFDA PJHDGJJALOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MonoBehaviour NGBLAGEAHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int IPJINKILICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly double ELAIKDAHFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stopwatch GFIBIDBFOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private IDisposable JGFGKOKLIML;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<NDIBMFKCNOF> GJICKKKLKML
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5690", Offset = "0x4DA4A90", VA = "0x184DA5690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> EGKJGGEBPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5400", Offset = "0x4DA4800", VA = "0x184DA5400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool DJAFIPKOAJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7D8040", Offset = "0x7D7440", VA = "0x1807D8040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double OKCKDLDKIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4DA5480", Offset = "0x4DA4880", VA = "0x184DA5480")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4DA56C0", Offset = "0x4DA4AC0", VA = "0x184DA56C0")]
	public DMCKFOPMHPN(IReadOnlyCollection<string> FAABDMOLHID, in AFBGENIPNDK PGIEKFMPOOM, CAENCAFGFDA LIDNLIEPGDB, MonoBehaviour IJBCJIEGGIM, [Optional] KBODALJBHOC.IIJEFNLLBIB BPPJCBPONGM, int FKCKLKEJAGM = 100, double MLMLEDIFLKN = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4DA50F0", Offset = "0x4DA44F0", VA = "0x184DA50F0")]
	public void BBJMBBCHFHN(string GCNKCIEJJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5510", Offset = "0x4DA4910", VA = "0x184DA5510")]
	private bool FMHGOECIAJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4DA55B0", Offset = "0x4DA49B0", VA = "0x184DA55B0")]
	private void HFDDNLHDFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4DA5430", Offset = "0x4DA4830", VA = "0x184DA5430", Slot = "4")]
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
