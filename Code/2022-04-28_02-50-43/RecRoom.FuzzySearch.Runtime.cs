using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class LFOHFGCONJM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate int IIADLJPDPFM(IReadOnlyList<char> OPHEDNBEHJA, int CDEAMJNKFGL, string CKNFPPHLHCH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly JDADIHCGIIG JIPEPBPDDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly IIADLJPDPFM NMHACBECECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly char[] GDGGOIPPPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MNFEFENPMJL[] EPMBAAMALNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly bool[] FOAGAMFPLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] IHAKFGGLFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly MNFEFENPMJL[] GEOAMLHACAE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x554E80", Offset = "0x554080", VA = "0x180554E80")]
	public static int LIFDOBABPAL(IReadOnlyList<char> OPHEDNBEHJA, int CDEAMJNKFGL, string CKNFPPHLHCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4C18BC0", Offset = "0x4C17DC0", VA = "0x184C18BC0")]
	public LFOHFGCONJM(IReadOnlyCollection<string> MJNHLIDGIDP, in JDADIHCGIIG AJIIJDAAKAO, [Optional] IIADLJPDPFM EMAOCHIEMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4C183B0", Offset = "0x4C175B0", VA = "0x184C183B0")]
	public string ICHBOBGJPEH(string BHAPINHHLMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4C18BB0", Offset = "0x4C17DB0", VA = "0x184C18BB0")]
	public int PBLGGCLLKJI(int MDMNCDJDHOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4C18430", Offset = "0x4C17630", VA = "0x184C18430")]
	public int LBJOBGHIPOJ(string BHAPINHHLMC, int BKOJDIHPBOO, int GDOPIHLPPOG, ref int CDEAMJNKFGL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct JDADIHCGIIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly bool NLHKOJJKAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool BAHKAPGKBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly int ELPCBMANBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int GANBGIMHBNI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly JDADIHCGIIG BNFKCFOFMPP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JDADIHCGIIG NGDBMKAAJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4C182D0", Offset = "0x4C174D0", VA = "0x184C182D0")]
		get
		{
			return default(JDADIHCGIIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C18390", Offset = "0x4C17590", VA = "0x184C18390")]
	public JDADIHCGIIG(bool HKGLAHAGNJK, bool DBLHMKLGLEJ, int JLCADOBHCBH, int GAANLNKJLIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct MNFEFENPMJL : IEquatable<MNFEFENPMJL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int PENJMDLPEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int LBJOBGHIPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int OPOMCBODFMD;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85CD40", Offset = "0x85BF40", VA = "0x18085CD40")]
	public MNFEFENPMJL(int NCBDKCDKIIG, int IHPDLAMJHGH, int AIOJPOPEOLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4C194D0", Offset = "0x4C186D0", VA = "0x184C194D0")]
	public static int KDGCNFGJFME(in MNFEFENPMJL NIFHNIMLIIM, in MNFEFENPMJL LPCOLAIDHBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3DFAC50", Offset = "0x3DF9E50", VA = "0x183DFAC50", Slot = "4")]
	public bool Equals(MNFEFENPMJL CDPFMCDBFNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4C193B0", Offset = "0x4C185B0", VA = "0x184C193B0", Slot = "0")]
	public override bool Equals(object KFCOOCIKJFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4C19460", Offset = "0x4C18660", VA = "0x184C19460", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OFEMGJFNNAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LFOHFGCONJM IABHDHFJIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private string OFEKIMDPADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int NPFOPAMLCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int BJMKBDLBHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int BNEIIIDINJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int HFOHCKCAELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Func<bool> MEDJNLKFMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private DMOAEFHFAAK LNHPAFLIONK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<MNFEFENPMJL> GMPADGEIALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x755C30", Offset = "0x754E30", VA = "0x180755C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> JCEEIOIBFOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xFCD510", Offset = "0xFCC710", VA = "0x180FCD510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4C19820", Offset = "0x4C18A20", VA = "0x184C19820")]
	public OFEMGJFNNAK(IReadOnlyCollection<string> MJNHLIDGIDP, in JDADIHCGIIG AJIIJDAAKAO, [Optional] LFOHFGCONJM.IIADLJPDPFM EMAOCHIEMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4C19690", Offset = "0x4C18890", VA = "0x184C19690")]
	public bool JKIKMKKIAGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4C194F0", Offset = "0x4C186F0", VA = "0x184C194F0")]
	public void CENEJMGGENF(string BHAPINHHLMC, int KGGDCJMOIHP, Func<bool> GBNOKPHIGON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class CILMGNEPJMD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void CBGIIPFFJAE(IReadOnlyList<MNFEFENPMJL> FBPLEKLLLHC, IReadOnlyList<bool> NMAIOPMHOJL);

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int HMDHIPAOLIN = 100;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const double JAICCGCPOKA = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly OFEMGJFNNAK MKOBGHDGBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly CBGIIPFFJAE GOIOJAJGFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MonoBehaviour MJANDKBEFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int HFOHCKCAELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly double FLNGFGMKAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stopwatch AHMJPPHCDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private IDisposable HKICAACEDAC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<MNFEFENPMJL> GMPADGEIALP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4C17B20", Offset = "0x4C16D20", VA = "0x184C17B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> JCEEIOIBFOK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4C180C0", Offset = "0x4C172C0", VA = "0x184C180C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool EICOBAOKBEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD040", Offset = "0x7AC240", VA = "0x1807AD040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double DDGOELOLGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4C17BA0", Offset = "0x4C16DA0", VA = "0x184C17BA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4C180F0", Offset = "0x4C172F0", VA = "0x184C180F0")]
	public CILMGNEPJMD(IReadOnlyCollection<string> MJNHLIDGIDP, in JDADIHCGIIG AJIIJDAAKAO, CBGIIPFFJAE JMCEJIKCKFA, MonoBehaviour EKDIFLKNOLC, [Optional] LFOHFGCONJM.IIADLJPDPFM EMAOCHIEMPM, int KGGDCJMOIHP = 100, double BFHOKGLCONI = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4C17C30", Offset = "0x4C16E30", VA = "0x184C17C30")]
	public void GGFKKNIBHNM(string BHAPINHHLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4C17F40", Offset = "0x4C17140", VA = "0x184C17F40")]
	private bool INILEDPPEKN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4C17FE0", Offset = "0x4C171E0", VA = "0x184C17FE0")]
	private void JKIKMKKIAGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4C17B50", Offset = "0x4C16D50", VA = "0x184C17B50", Slot = "4")]
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
