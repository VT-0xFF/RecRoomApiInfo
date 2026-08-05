using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class CPPJLNGJIHP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate int AOAOEOECIKM(IReadOnlyList<char> DGDBNDOBJDP, int NEDHOJJBJPI, string GLAMJGHJABC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ABHCKIMHDDO LGABEINJKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly AOAOEOECIKM EEENGAPMMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly char[] LGOFMCMCNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly BGLIJGCMKAF[] CMNMEFCFAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly bool[] HAHNNMDKMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] DKHFDEMDELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly BGLIJGCMKAF[] FLKELDLGGHG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5F6110", Offset = "0x5F5310", VA = "0x1805F6110")]
	public static int EOLBPMBHHDE(IReadOnlyList<char> DGDBNDOBJDP, int NEDHOJJBJPI, string GLAMJGHJABC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x287B060", Offset = "0x287A260", VA = "0x18287B060")]
	public CPPJLNGJIHP(IReadOnlyCollection<string> AIAOCELCMCL, in ABHCKIMHDDO GPFOOINJGFL, [Optional] AOAOEOECIKM FJHKFDBBCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x287AFE0", Offset = "0x287A1E0", VA = "0x18287AFE0")]
	public string KCHGEAMAIJK(string FPPFKBKNBJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x287AFD0", Offset = "0x287A1D0", VA = "0x18287AFD0")]
	public int JEEECEJMDGD(int EKHGMLIDNCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x287A850", Offset = "0x2879A50", VA = "0x18287A850")]
	public int DMCCFODIMLI(string FPPFKBKNBJC, int NAEDJPLAHJI, int MPBNFPLBHCO, ref int NEDHOJJBJPI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct ABHCKIMHDDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly bool LMKLKJDOLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool OGCKFPABOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly int IPCBADGMBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int ICHGMIGLFJF;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly ABHCKIMHDDO AJKDBNBGMDF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static ABHCKIMHDDO HPMHEACECHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x287A590", Offset = "0x2879790", VA = "0x18287A590")]
		get
		{
			return default(ABHCKIMHDDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x287A650", Offset = "0x2879850", VA = "0x18287A650")]
	public ABHCKIMHDDO(bool JENGCPAFJDM, bool PEKFCPGNAMI, int EHCHNBMKFHC, int NNBEGKNMLME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct BGLIJGCMKAF : IEquatable<BGLIJGCMKAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int CCIFACONDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int DMCCFODIMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int GNNOOFEKGGC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x11E5710", Offset = "0x11E4910", VA = "0x1811E5710")]
	public BGLIJGCMKAF(int MJNAIOAAGCG, int NMHGIEKENJO, int MPFNGCLNCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x287A710", Offset = "0x2879910", VA = "0x18287A710")]
	public static int DAOCKOGOJCL(in BGLIJGCMKAF DHAMHGONHGF, in BGLIJGCMKAF ODBGDMOKIMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x20057B0", Offset = "0x20049B0", VA = "0x1820057B0", Slot = "4")]
	public bool Equals(BGLIJGCMKAF GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x287A730", Offset = "0x2879930", VA = "0x18287A730", Slot = "0")]
	public override bool Equals(object PBKPNJLDBOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x287A7E0", Offset = "0x28799E0", VA = "0x18287A7E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GDADGBPJOHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CPPJLNGJIHP EJCNIOEODGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private string LEEEMHKDJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int HLNDLEFIHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int KBBOALAHGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int DIAHIONNKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int PKLELHAMIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Func<bool> DHHLLCEMBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private AJCJONOPNGE FOAKLEDICCK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<BGLIJGCMKAF> IOIKNBGBCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCFF540", Offset = "0xCFE740", VA = "0x180CFF540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> KLEEBFJBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xBA8F70", Offset = "0xBA8170", VA = "0x180BA8F70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x287BB80", Offset = "0x287AD80", VA = "0x18287BB80")]
	public GDADGBPJOHG(IReadOnlyCollection<string> AIAOCELCMCL, in ABHCKIMHDDO GPFOOINJGFL, [Optional] CPPJLNGJIHP.AOAOEOECIKM FJHKFDBBCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x287B850", Offset = "0x287AA50", VA = "0x18287B850")]
	public bool LKMBBCJKNPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x287B9E0", Offset = "0x287ABE0", VA = "0x18287B9E0")]
	public void LNJKFIFCFCI(string FPPFKBKNBJC, int FBKJAKAPELC, Func<bool> FJPJMEFKPIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GINIODPBFPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void NHILLGEBHCN(IReadOnlyList<BGLIJGCMKAF> AAJBAEPHJFG, IReadOnlyList<bool> CAEBFFHDIFB);

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int PKLHJCPADNP = 100;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const double PIPJNDPNCDG = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GDADGBPJOHG KAEPJCKOKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly NHILLGEBHCN EJCBOPJFELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MonoBehaviour KJLDBCFLNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int PKLELHAMIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly double HALGKOJFKJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stopwatch ONBBNGIMKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private IDisposable MMPAODGFOBF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<BGLIJGCMKAF> IOIKNBGBCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x287BD30", Offset = "0x287AF30", VA = "0x18287BD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> KLEEBFJBHFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x287BC20", Offset = "0x287AE20", VA = "0x18287BC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MCMFACIOMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x108DE50", Offset = "0x108D050", VA = "0x18108DE50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double GMHBHBLJGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x287BCA0", Offset = "0x287AEA0", VA = "0x18287BCA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x287C1F0", Offset = "0x287B3F0", VA = "0x18287C1F0")]
	public GINIODPBFPA(IReadOnlyCollection<string> AIAOCELCMCL, in ABHCKIMHDDO GPFOOINJGFL, NHILLGEBHCN HFHHBOMFLND, MonoBehaviour JAEDJGBMHAP, [Optional] CPPJLNGJIHP.AOAOEOECIKM FJHKFDBBCBN, int FBKJAKAPELC = 100, double ILAPINEJPPG = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x287BD60", Offset = "0x287AF60", VA = "0x18287BD60")]
	public void HHEMGNOGPAC(string FPPFKBKNBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x287C070", Offset = "0x287B270", VA = "0x18287C070")]
	private bool IHMJEOKFDAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x287C110", Offset = "0x287B310", VA = "0x18287C110")]
	private void LKMBBCJKNPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287AE50", VA = "0x18287BC50", Slot = "4")]
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
