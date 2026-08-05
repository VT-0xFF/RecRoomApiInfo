using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class PHNLEDELDBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HHPHIHJAMFI BIIDFALPOBC;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class HHPHIHJAMFI
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate int DFOODLEJCNI(IReadOnlyList<char> PBAELHJEEHN, int OPEDLDABKAB, string IJHPKBNPLJD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly BHCPONGLDMO KLLAILDNKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DFOODLEJCNI MMIDBJJMMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly char[] NLHAJBGAPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly KFDHOEHFJPM[] MPPIICENOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly bool[] JNEONIAMCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] BCLDFHJJEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly KFDHOEHFJPM[] CGKAEFGEEFH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C6930", Offset = "0x6C5D30", VA = "0x1806C6930")]
	public static int CCMPNAEHKBB(IReadOnlyList<char> PBAELHJEEHN, int OPEDLDABKAB, string IJHPKBNPLJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64F1090", Offset = "0x64F0490", VA = "0x1864F1090")]
	public HHPHIHJAMFI(IReadOnlyCollection<string> KLJNKEKKANB, in BHCPONGLDMO ANFIGENLNBN, [Optional] DFOODLEJCNI CGEBNLBHFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64F1000", Offset = "0x64F0400", VA = "0x1864F1000")]
	public string PILJDAIOEGF(string MEKJFCLBIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64F0920", Offset = "0x64EFD20", VA = "0x1864F0920")]
	public int DLJIFACNBLH(int DNKAOMHFDMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64F0930", Offset = "0x64EFD30", VA = "0x1864F0930")]
	public int MCDAMFACDDF(string MEKJFCLBIFI, int OJAHKMGIGJC, int PBGIJNFPJJI, ref int OPEDLDABKAB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct BHCPONGLDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool ILAGDPJLCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool BCHMCAMNDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int CJNGOANIBIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly int IFHEFBMLGJK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly BHCPONGLDMO MNLGLBJBOED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static BHCPONGLDMO OKLBJLNFLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x64F01C0", Offset = "0x64EF5C0", VA = "0x1864F01C0")]
		get
		{
			return default(BHCPONGLDMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64F0280", Offset = "0x64EF680", VA = "0x1864F0280")]
	public BHCPONGLDMO(bool HKEBLILGIBL, bool LCHIMIOCIDN, int JFFLAIEOEDM, int JKMIGOPPCHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct KFDHOEHFJPM : IEquatable<KFDHOEHFJPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int JNPBIMHEMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int MCDAMFACDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int FGPEJFMCDCD;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82E560", Offset = "0x82D960", VA = "0x18082E560")]
	public KFDHOEHFJPM(int GABJOMFFJAI, int GNDBGGKKFMG, int IMNMJIIPBOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x64F1E50", Offset = "0x64F1250", VA = "0x1864F1E50")]
	public static int PCBKGNIEEDC(in KFDHOEHFJPM BEOAJHMDOLI, in KFDHOEHFJPM CEKIIBILJFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x14DD110", Offset = "0x14DC510", VA = "0x1814DD110", Slot = "4")]
	public bool Equals(KFDHOEHFJPM FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64F1D30", Offset = "0x64F1130", VA = "0x1864F1D30", Slot = "0")]
	public override bool Equals(object JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64F1DE0", Offset = "0x64F11E0", VA = "0x1864F1DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IMNKMJHNPFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HHPHIHJAMFI BIIDFALPOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private string ANINIIOIAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int LPPNDCGDEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int HOKILALHMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int MOJGJCLEBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int OFBKOBHJNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Func<bool> BACJMFIMPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private AKMCOFPKJMM MOIHHJJGCJF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<KFDHOEHFJPM> AKHDEKJIIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x94B540", Offset = "0x94A940", VA = "0x18094B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> OHIFMCNKJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x871F10", Offset = "0x871310", VA = "0x180871F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64F1C90", Offset = "0x64F1090", VA = "0x1864F1C90")]
	public IMNKMJHNPFA(IReadOnlyCollection<string> KLJNKEKKANB, in BHCPONGLDMO ANFIGENLNBN, [Optional] HHPHIHJAMFI.DFOODLEJCNI CGEBNLBHFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64F1AE0", Offset = "0x64F0EE0", VA = "0x1864F1AE0")]
	public bool LNDNBBELHDE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x64F1910", Offset = "0x64F0D10", VA = "0x1864F1910")]
	public void BCPDBCMHLJJ(string MEKJFCLBIFI, int DHDJPAEFEDL, Func<bool> LEPFCLCNLNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GMIDMGCMBIN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void CAEIJABDBLB(IReadOnlyList<KFDHOEHFJPM> NPMGLIPJHGI, IReadOnlyList<bool> NGINAPELFLC);

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const int AAPJLPIAEOA = 100;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const double GNHFGLEEBMH = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly IMNKMJHNPFA ELFKLNAADJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly CAEIJABDBLB OAIKMLKFCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MonoBehaviour PIHLPIDHFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int OFBKOBHJNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly double LBADCONPENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Stopwatch CBAAMIGFKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private IDisposable NHNELCAHFGF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<KFDHOEHFJPM> AKHDEKJIIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xF022F0", Offset = "0xF016F0", VA = "0x180F022F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> OHIFMCNKJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x64F04C0", Offset = "0x64EF8C0", VA = "0x1864F04C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NGJNLJJJHCG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA9B400", Offset = "0xA9A800", VA = "0x180A9B400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double CDCJBIBIGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x64F0330", Offset = "0x64EF730", VA = "0x1864F0330")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x64F07D0", Offset = "0x64EFBD0", VA = "0x1864F07D0")]
	public GMIDMGCMBIN(IReadOnlyCollection<string> KLJNKEKKANB, in BHCPONGLDMO ANFIGENLNBN, CAEIJABDBLB DOOCLNJBJEK, MonoBehaviour OEGBAMNPENI, [Optional] HHPHIHJAMFI.DFOODLEJCNI CGEBNLBHFPP, int DHDJPAEFEDL = 100, double ADNGODDOIGG = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x64F04F0", Offset = "0x64EF8F0", VA = "0x1864F04F0")]
	public void HCKJJPJEKMD(string MEKJFCLBIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x64F03C0", Offset = "0x64EF7C0", VA = "0x1864F03C0")]
	private bool DLAGIJOLCAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x64F06F0", Offset = "0x64EFAF0", VA = "0x1864F06F0")]
	private void LNDNBBELHDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x64F0470", Offset = "0x64EF870", VA = "0x1864F0470", Slot = "4")]
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
