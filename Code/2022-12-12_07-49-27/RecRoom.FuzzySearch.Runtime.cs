using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class KDIOMNNOKDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly IAFELEGGEDN CEFMGFGIFAE;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class IAFELEGGEDN
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate int MBHOOBMDLLI(IReadOnlyList<char> CBBCKFFONKC, int PGIDKPCFJDI, string MOMLBABBPHC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly EMNNIKGODBO HADKHJBPACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MBHOOBMDLLI ABKPHOEOAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly char[] JOIEKKIKDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly CJJHALHPKPB[] JHELNGEEMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly bool[] MGFBHCMJNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] BOKBAIPONOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly CJJHALHPKPB[] PLGBAHKOMMK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x677290", Offset = "0x675890", VA = "0x180677290")]
	public static int IMGKNNHHMBC(IReadOnlyList<char> CBBCKFFONKC, int PGIDKPCFJDI, string MOMLBABBPHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1D1DC50", Offset = "0x1D1C250", VA = "0x181D1DC50")]
	public IAFELEGGEDN(IReadOnlyCollection<string> OPDCGIOIAOG, in EMNNIKGODBO LIKJEMDJKAM, [Optional] MBHOOBMDLLI PFPJLPOFIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D1DBC0", Offset = "0x1D1C1C0", VA = "0x181D1DBC0")]
	public string LFHEHPIODHG(string MOEFFEOLKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1D1D4E0", Offset = "0x1D1BAE0", VA = "0x181D1D4E0")]
	public int KOPJCLBPIHG(int GIOAMCEBCKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1D1D4F0", Offset = "0x1D1BAF0", VA = "0x181D1D4F0")]
	public int LCAAKFPBDBB(string MOEFFEOLKIC, int JDIGEFIOLPP, int JLJCMAKBDBJ, ref int PGIDKPCFJDI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct EMNNIKGODBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool GABIHIJMMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool HBLGCIHKGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int HANIKFACOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly int KJMOKPOMLBN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly EMNNIKGODBO KMNHNMBKIMA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static EMNNIKGODBO MKNJDLGIAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CFF0", Offset = "0x1D1B5F0", VA = "0x181D1CFF0")]
		get
		{
			return default(EMNNIKGODBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D1D0B0", Offset = "0x1D1B6B0", VA = "0x181D1D0B0")]
	public EMNNIKGODBO(bool LIDLEMBHGGJ, bool AOLMCDBAILI, int GFFCBOPEKFO, int OANHBBFHANB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct CJJHALHPKPB : IEquatable<CJJHALHPKPB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int DNFPKCNMAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int LCAAKFPBDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int HDNIIDPHMIC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F8C30", Offset = "0x7F7230", VA = "0x1807F8C30")]
	public CJJHALHPKPB(int EBBLFLFCHFB, int KMOFKPFPLCB, int HFAABGBMEOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D1C9E0", Offset = "0x1D1AFE0", VA = "0x181D1C9E0")]
	public static int MPOENEHOPND(in CJJHALHPKPB OLACFPEGPAG, in CJJHALHPKPB GLLCOOLKDAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1725C50", Offset = "0x1724250", VA = "0x181725C50", Slot = "4")]
	public bool Equals(CJJHALHPKPB OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D1C8C0", Offset = "0x1D1AEC0", VA = "0x181D1C8C0", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D1C970", Offset = "0x1D1AF70", VA = "0x181D1C970", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class GBFNGLHPPAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly IAFELEGGEDN CEFMGFGIFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private string ECKHHJGHCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int PGLFEJMIDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int DKLLCEOCIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int OMIGMGPGCDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int GGCFPDPLNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Func<bool> CMPOIBPGBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private MIDAIKDIFHB IFCAPHJKGKF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<CJJHALHPKPB> MBFLDHJPAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9271D0", Offset = "0x9257D0", VA = "0x1809271D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> DACDFNGLPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84FA20", Offset = "0x84E020", VA = "0x18084FA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D1D440", Offset = "0x1D1BA40", VA = "0x181D1D440")]
	public GBFNGLHPPAG(IReadOnlyCollection<string> OPDCGIOIAOG, in EMNNIKGODBO LIKJEMDJKAM, [Optional] IAFELEGGEDN.MBHOOBMDLLI PFPJLPOFIMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D1D0D0", Offset = "0x1D1B6D0", VA = "0x181D1D0D0")]
	public bool JOCILFJKCBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1D1D270", Offset = "0x1D1B870", VA = "0x181D1D270")]
	public void PICFFKMJNEB(string MOEFFEOLKIC, int PFPPEGBMLKN, Func<bool> OAJJEKGBJJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DILIKIJFCFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void FNFNPCDPLPJ(IReadOnlyList<CJJHALHPKPB> CHMIIAOHKND, IReadOnlyList<bool> BBDPKDNPGPG);

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const int DEMIIKCJKLN = 100;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const double KONGBMGJNCG = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly GBFNGLHPPAG NKNGDHJIAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly FNFNPCDPLPJ JIMCJMMAIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MonoBehaviour HDGPDJKJJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int GGCFPDPLNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly double LOHAJLBPDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Stopwatch HAJNCLMEOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private IDisposable BGLLPONMFNH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<CJJHALHPKPB> MBFLDHJPAJD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1031D60", Offset = "0x1030360", VA = "0x181031D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> DACDFNGLPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CC00", Offset = "0x1D1B200", VA = "0x181D1CC00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool LNIMLLDJPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAA00B0", Offset = "0xA9E6B0", VA = "0x180AA00B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double JDGMJANJIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1D1CD60", Offset = "0x1D1B360", VA = "0x181D1CD60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1D1CEA0", Offset = "0x1D1B4A0", VA = "0x181D1CEA0")]
	public DILIKIJFCFP(IReadOnlyCollection<string> OPDCGIOIAOG, in EMNNIKGODBO LIKJEMDJKAM, FNFNPCDPLPJ DFNGGELNPAG, MonoBehaviour JOOJGLPIMBB, [Optional] IAFELEGGEDN.MBHOOBMDLLI PFPJLPOFIMP, int PFPPEGBMLKN = 100, double ABLIGOBMLPL = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1D1CA00", Offset = "0x1D1B000", VA = "0x181D1CA00")]
	public void CGFBJKCHPMJ(string MOEFFEOLKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1D1CDF0", Offset = "0x1D1B3F0", VA = "0x181D1CDF0")]
	private bool NDEACNNPIAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1D1CC80", Offset = "0x1D1B280", VA = "0x181D1CC80")]
	private void JOCILFJKCBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1D1CC30", Offset = "0x1D1B230", VA = "0x181D1CC30", Slot = "4")]
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
