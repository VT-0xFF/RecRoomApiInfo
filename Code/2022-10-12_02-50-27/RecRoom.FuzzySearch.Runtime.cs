using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class LCHFFOBHNOD
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate int GBKMOEOJGLB(IReadOnlyList<char> CBKMLDECDIO, int EAODJOKAKLD, string KEHCNPFPOCH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly KJALLDPPOJN JGLFMCBGOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly GBKMOEOJGLB JANKIHNOMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly char[] KHAPINMMDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly KHCJEAEANNH[] FBIPGFAHDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly bool[] HJEJLAEHHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] JLAGMBCMIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly KHCJEAEANNH[] ANGCHCKIJOO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6670F0", Offset = "0x6658F0", VA = "0x1806670F0")]
	public static int BMCKCAFLAGB(IReadOnlyList<char> CBKMLDECDIO, int EAODJOKAKLD, string KEHCNPFPOCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1EAB6A0", Offset = "0x1EA9EA0", VA = "0x181EAB6A0")]
	public LCHFFOBHNOD(IReadOnlyCollection<string> LCKNJIIOGLH, in KJALLDPPOJN JNANFIIFIEG, [Optional] GBKMOEOJGLB OBBDOJEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1EAB600", Offset = "0x1EA9E00", VA = "0x181EAB600")]
	public string LIBEHMLCMKO(string PLIACKIMLKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1EAB690", Offset = "0x1EA9E90", VA = "0x181EAB690")]
	public int OMMIKMFEEON(int EJBKBKNLPNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1EAAF30", Offset = "0x1EA9730", VA = "0x181EAAF30")]
	public int CEMIDJFFHEK(string PLIACKIMLKF, int FABCGGPFPPE, int DKEAJNCGKPC, ref int EAODJOKAKLD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct KJALLDPPOJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly bool JGEOIIHFPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool MLKNLCAGMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly int LDNOFMIJIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int GCJHCALIJMF;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly KJALLDPPOJN JPGBFNDMBBC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static KJALLDPPOJN PJLEDACBOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1EAAE50", Offset = "0x1EA9650", VA = "0x181EAAE50")]
		get
		{
			return default(KJALLDPPOJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1EAAF10", Offset = "0x1EA9710", VA = "0x181EAAF10")]
	public KJALLDPPOJN(bool KBCEPMHFAAP, bool FFKHLLGNGDK, int OOOAFMGOBIJ, int DPAEFAGNGGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct KHCJEAEANNH : IEquatable<KHCJEAEANNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int DCEMEBHPCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int CEMIDJFFHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int DBPCAIHDJDE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x81ADF0", Offset = "0x8195F0", VA = "0x18081ADF0")]
	public KHCJEAEANNH(int MMABPPDCBIB, int NEOLCKELHLC, int PKIHPGNHAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1EAAD10", Offset = "0x1EA9510", VA = "0x181EAAD10")]
	public static int DHHFFIBIONM(in KHCJEAEANNH FEBCAKEBBCL, in KHCJEAEANNH EEACLMBPLFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x193C340", Offset = "0x193AB40", VA = "0x18193C340", Slot = "4")]
	public bool Equals(KHCJEAEANNH IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1EAAD30", Offset = "0x1EA9530", VA = "0x181EAAD30", Slot = "0")]
	public override bool Equals(object ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1EAADE0", Offset = "0x1EA95E0", VA = "0x181EAADE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MAAIAAFJCKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LCHFFOBHNOD GGMAFMNLMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private string KJDOMMPJDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int FAGLKMCFFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int DNKGNDJLNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int FEPKPLDPOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int GDIHDDKALFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Func<bool> EDCFCNHPJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private JOLIMIIAILF NNJDEEJOIHM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<KHCJEAEANNH> ACAOGFPIPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x928C40", Offset = "0x927440", VA = "0x180928C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> GNDIAFBCHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x89EBD0", Offset = "0x89D3D0", VA = "0x18089EBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC290", Offset = "0x1EAAA90", VA = "0x181EAC290")]
	public MAAIAAFJCKC(IReadOnlyCollection<string> LCKNJIIOGLH, in KJALLDPPOJN JNANFIIFIEG, [Optional] LCHFFOBHNOD.GBKMOEOJGLB OBBDOJEACIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1EAC0F0", Offset = "0x1EAA8F0", VA = "0x181EAC0F0")]
	public bool OPFMGPMNNIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1EABF20", Offset = "0x1EAA720", VA = "0x181EABF20")]
	public void EJBDEEHCBFM(string PLIACKIMLKF, int LJLDACFHDDI, Func<bool> AFBNBNGJHFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class HADHEILJKNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void LHIOCOGHAIE(IReadOnlyList<KHCJEAEANNH> EDPHBMHGCEN, IReadOnlyList<bool> LGNPDNPJICG);

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int GFGDIFMJACD = 100;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const double KDJEDCJFNCA = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly MAAIAAFJCKC KBFICNEOGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly LHIOCOGHAIE BMKHPGMOPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MonoBehaviour ILKDJHOFJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int GDIHDDKALFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly double JCAEJKOBPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stopwatch LDGNPKEIOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private IDisposable LCGOMAOHFIF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<KHCJEAEANNH> ACAOGFPIPFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x123DF20", Offset = "0x123C720", VA = "0x18123DF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> GNDIAFBCHJF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1EAAAB0", Offset = "0x1EA92B0", VA = "0x181EAAAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MFICCHDBDLK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xB2B5B0", Offset = "0xB29DB0", VA = "0x180B2B5B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double NDHJPGOINPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1EAA720", Offset = "0x1EA8F20", VA = "0x181EAA720")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1EAABC0", Offset = "0x1EA93C0", VA = "0x181EAABC0")]
	public HADHEILJKNC(IReadOnlyCollection<string> LCKNJIIOGLH, in KJALLDPPOJN JNANFIIFIEG, LHIOCOGHAIE MNOHPGHJNAP, MonoBehaviour IGBOEABBEHO, [Optional] LCHFFOBHNOD.GBKMOEOJGLB OBBDOJEACIP, int LJLDACFHDDI = 100, double ODOAKONPICN = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1EAA8B0", Offset = "0x1EA90B0", VA = "0x181EAA8B0")]
	public void IABHCPMFCFA(string PLIACKIMLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1EAA800", Offset = "0x1EA9000", VA = "0x181EAA800")]
	private bool EKGPGBMHLJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1EAAAE0", Offset = "0x1EA92E0", VA = "0x181EAAAE0")]
	private void OPFMGPMNNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1EAA7B0", Offset = "0x1EA8FB0", VA = "0x181EAA7B0", Slot = "4")]
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
