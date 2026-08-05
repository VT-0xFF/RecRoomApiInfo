using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class NNDMPHNAPAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly EOOLIGPPBNJ CJJBCBGBIDF;
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class EOOLIGPPBNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate int LOPNFAJPLHH(IReadOnlyList<char> KHEADNBJDHC, int LMHFHMGAJJD, string DPJAFLGGMIO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly CIBONLCFMKI PIJJGDBOCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly LOPNFAJPLHH BOGJKEPDNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly char[] CLCIEDEIIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly LNGLCMCMPMP[] DMDANGLJDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly bool[] OKPDCNGJGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] IADKPENEIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly LNGLCMCMPMP[] KOBNHOCLKBJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40")]
	public static int GIOKKFEADEC(IReadOnlyList<char> KHEADNBJDHC, int LMHFHMGAJJD, string DPJAFLGGMIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E08FE0", Offset = "0x6E083E0", VA = "0x186E08FE0")]
	public EOOLIGPPBNJ(IReadOnlyCollection<string> PCNJODIOOKE, [In] CIBONLCFMKI LDMELPIIKID, [Optional] LOPNFAJPLHH ELJIOHBNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E08F50", Offset = "0x6E08350", VA = "0x186E08F50")]
	public string MBOLGBJIANF(string DPPCLLNGFIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E08940", Offset = "0x6E07D40", VA = "0x186E08940")]
	public int EGNNBLKLDLO(int OKIEAMNGGPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E08950", Offset = "0x6E07D50", VA = "0x186E08950")]
	public int EODMLCPAFMP(string DPPCLLNGFIM, int GBNOJOGPBDP, int KKCKILPNCLA, int LMHFHMGAJJD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct CIBONLCFMKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool BDKPMGCJGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly bool AGJHGNPJMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int HJGKJNBCENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly int MDJHKGEPNKD;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly CIBONLCFMKI ELFGPHLMKJC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static CIBONLCFMKI DPPOJDBEGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E08870", Offset = "0x6E07C70", VA = "0x186E08870")]
		get
		{
			return default(CIBONLCFMKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E08920", Offset = "0x6E07D20", VA = "0x186E08920")]
	public CIBONLCFMKI(bool LAOHGPKBCIA, bool KMBPPEKCJGE, int HHDNLMIHFHL, int JABMNLIAIKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public readonly struct LNGLCMCMPMP : IEquatable<LNGLCMCMPMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int LGPOLAJNCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int EODMLCPAFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly int NAJGKBFOGFG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x20BAEB0", Offset = "0x20BA2B0", VA = "0x1820BAEB0")]
	public LNGLCMCMPMP(int AEAHMAMPNLO, int DEDJNFIIOBH, int IBBAFECOKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A660", Offset = "0x6E09A60", VA = "0x186E0A660")]
	public static int HAHHEMKPNDH([In] LNGLCMCMPMP GIDMNJLJNOH, [In] LNGLCMCMPMP OONEKAPAHLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2114580", Offset = "0x2113980", VA = "0x182114580", Slot = "4")]
	public bool Equals(LNGLCMCMPMP OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A540", Offset = "0x6E09940", VA = "0x186E0A540", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A5F0", Offset = "0x6E099F0", VA = "0x186E0A5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IKEHCHKAKMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly EOOLIGPPBNJ CJJBCBGBIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private string ALOLGCJMHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int KGOJMIFDKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int MEMOGIMJEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int KIGOCIGJGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private int FGKIGBOPKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Func<bool> NBHELECDFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private AHGLCOHDJLC.NKFIHINHFBL<LNGLCMCMPMP> HAOICHEOKNC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<LNGLCMCMPMP> FIIFJKLMMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1549710", Offset = "0x1548B10", VA = "0x181549710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> IDGHHDIJMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FF3880", Offset = "0x5FF2C80", VA = "0x185FF3880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E09E40", Offset = "0x6E09240", VA = "0x186E09E40")]
	public IKEHCHKAKMK(IReadOnlyCollection<string> PCNJODIOOKE, [In] CIBONLCFMKI LDMELPIIKID, [Optional] EOOLIGPPBNJ.LOPNFAJPLHH ELJIOHBNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E09AD0", Offset = "0x6E08ED0", VA = "0x186E09AD0")]
	public bool HDKICDHPBBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E09C70", Offset = "0x6E09070", VA = "0x186E09C70")]
	public void OJOIHJMDPIF(string DPPCLLNGFIM, int BJHLDCIHHMM, Func<bool> LKHOBAPBJKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class JEKHMPOPAJN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate void JGDILEFJEDM(IReadOnlyList<LNGLCMCMPMP> ABMKEFKAFCI, IReadOnlyList<bool> MNJAONGLONL);

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const int PLAGPGHKHAD = 100;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const double CKPPOEMOAGG = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly IKEHCHKAKMK GJLKEAKBPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly JGDILEFJEDM CMNHGNNMJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly MonoBehaviour HHIHCKLFIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int FGKIGBOPKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly double OOKIPOGBHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Stopwatch HCIAAKLELGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private IDisposable HEIEJBBKBAI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<LNGLCMCMPMP> FIIFJKLMMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A390", Offset = "0x6E09790", VA = "0x186E0A390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> IDGHHDIJMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E0A360", Offset = "0x6E09760", VA = "0x186E0A360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OLEDNOKCEIL
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x10A1BE0", Offset = "0x10A0FE0", VA = "0x1810A1BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double PEHLBDNFDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6E09EF0", Offset = "0x6E092F0", VA = "0x186E09EF0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A3C0", Offset = "0x6E097C0", VA = "0x186E0A3C0")]
	public JEKHMPOPAJN(IReadOnlyCollection<string> PCNJODIOOKE, [In] CIBONLCFMKI LDMELPIIKID, JGDILEFJEDM MMHCPOCOKEG, MonoBehaviour JCPOMHNJOIE, [Optional] EOOLIGPPBNJ.LOPNFAJPLHH ELJIOHBNDPA, int BJHLDCIHHMM = 100, double FPGHBEGJHJM = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A150", Offset = "0x6E09550", VA = "0x186E0A150")]
	public void JCPKKODJNKH(string DPPCLLNGFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E09F80", Offset = "0x6E09380", VA = "0x186E09F80")]
	private bool BHNGLHGHNKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A070", Offset = "0x6E09470", VA = "0x186E0A070")]
	private void HDKICDHPBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E0A020", Offset = "0x6E09420", VA = "0x186E0A020", Slot = "4")]
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
