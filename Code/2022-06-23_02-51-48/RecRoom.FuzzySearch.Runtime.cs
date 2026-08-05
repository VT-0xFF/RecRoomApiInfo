using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class DFACFIPMCEG
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate int CMHMAIENCJH(IReadOnlyList<char> IFILHLNMAJP, int CMJKLMHKEPH, string HEJOIILNKIK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly FPACHILMMAP GAEGCJFOGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly CMHMAIENCJH EPEFEKKJMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly char[] IMMPIGMAEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly KMANCLILNHE[] ADAIHADEIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly bool[] LIGEGONCGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] ACLDOCPJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly KMANCLILNHE[] JLGPCGFAJIM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x579850", Offset = "0x578A50", VA = "0x180579850")]
	public static int EHKFMMCHOJL(IReadOnlyList<char> IFILHLNMAJP, int CMJKLMHKEPH, string HEJOIILNKIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDCD0", Offset = "0x4FDCED0", VA = "0x184FDDCD0")]
	public DFACFIPMCEG(IReadOnlyCollection<string> OLBGLGFFCFB, in FPACHILMMAP JGJCMDCBDEH, [Optional] CMHMAIENCJH KIOMKGHDAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDC50", Offset = "0x4FDCE50", VA = "0x184FDDC50")]
	public string IHGJDMLDNPP(string INGJMJKICGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4FDDC40", Offset = "0x4FDCE40", VA = "0x184FDDC40")]
	public int FINAKBMPCMM(int AJDLOGCMKNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4FDD4C0", Offset = "0x4FDC6C0", VA = "0x184FDD4C0")]
	public int DCCOAGHJHFI(string INGJMJKICGH, int OCCMPDEAIOD, int PDPCKIGNNBO, ref int CMJKLMHKEPH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct FPACHILMMAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly bool EGLCFEFGPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool BCJAMPJBEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly int CELEJHPHAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int JJKPFAOPBCE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly FPACHILMMAP DHEIBGNOLBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FPACHILMMAP MLLBELOGAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4FDE4C0", Offset = "0x4FDD6C0", VA = "0x184FDE4C0")]
		get
		{
			return default(FPACHILMMAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4FDE580", Offset = "0x4FDD780", VA = "0x184FDE580")]
	public FPACHILMMAP(bool BPHOGPADMPJ, bool EEJOBOIMAHL, int CCGIJNNFHFJ, int FEPBDCIMBDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct KMANCLILNHE : IEquatable<KMANCLILNHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int AGIDOAOJPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int DCCOAGHJHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int LPCAGFMEPPF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x647050", Offset = "0x646250", VA = "0x180647050")]
	public KMANCLILNHE(int PPMIPKENDBN, int NAEGNDFECHA, int FACPGJALNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4FDEA90", Offset = "0x4FDDC90", VA = "0x184FDEA90")]
	public static int HHEBFLDDFMJ(in KMANCLILNHE EKPKCLNNFCJ, in KMANCLILNHE NJJGMIMHBHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x406C560", Offset = "0x406B760", VA = "0x18406C560", Slot = "4")]
	public bool Equals(KMANCLILNHE EBJKBJMLDOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4FDE970", Offset = "0x4FDDB70", VA = "0x184FDE970", Slot = "0")]
	public override bool Equals(object CEEAMODAEEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4FDEA20", Offset = "0x4FDDC20", VA = "0x184FDEA20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class GJEEGGGIAEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly DFACFIPMCEG GLJMJPJFAIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private string OPIBLIMHHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int AEEEKGGMKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int PDCDBHEMENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int HNAOKHOJJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int NEIBHPFOPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Func<bool> PAIBFHDLAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IJPHNEPACNG MMHFBAPFMPJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<KMANCLILNHE> GLLCOBDINGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x677530", Offset = "0x676730", VA = "0x180677530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> BLFOLPFIDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x17500C0", Offset = "0x174F2C0", VA = "0x1817500C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4FDE8D0", Offset = "0x4FDDAD0", VA = "0x184FDE8D0")]
	public GJEEGGGIAEK(IReadOnlyCollection<string> OLBGLGFFCFB, in FPACHILMMAP JGJCMDCBDEH, [Optional] DFACFIPMCEG.CMHMAIENCJH KIOMKGHDAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4FDE5A0", Offset = "0x4FDD7A0", VA = "0x184FDE5A0")]
	public bool OBKEBFILHLM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4FDE730", Offset = "0x4FDD930", VA = "0x184FDE730")]
	public void PGFHMMHDNJL(string INGJMJKICGH, int CEAAOFNBCIN, Func<bool> FEABIHKFEFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class MKDFEMBLGGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void INMDIOMNOCK(IReadOnlyList<KMANCLILNHE> IGMIMJFCABK, IReadOnlyList<bool> PGFDMJGAANE);

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int CICGJNBLJAI = 100;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const double PGEHJEHLDMF = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly GJEEGGGIAEK KEPFCPDOMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly INMDIOMNOCK PFDMDKPMAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MonoBehaviour MGJDLMMGFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int NEIBHPFOPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly double BNONGOBCKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stopwatch BIMNAIDHBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private IDisposable APNOLIADLEM;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<KMANCLILNHE> GLLCOBDINGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4FDEF40", Offset = "0x4FDE140", VA = "0x184FDEF40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> BLFOLPFIDNE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4FDEF70", Offset = "0x4FDE170", VA = "0x184FDEF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool ONMGKENLHBH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1449760", Offset = "0x1448960", VA = "0x181449760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double BKDFIKHKEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4FDEEB0", Offset = "0x4FDE0B0", VA = "0x184FDEEB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4FDF080", Offset = "0x4FDE280", VA = "0x184FDF080")]
	public MKDFEMBLGGO(IReadOnlyCollection<string> OLBGLGFFCFB, in FPACHILMMAP JGJCMDCBDEH, INMDIOMNOCK JMGNKHOBCOB, MonoBehaviour JOBPOOEPEBN, [Optional] DFACFIPMCEG.CMHMAIENCJH KIOMKGHDAAP, int CEAAOFNBCIN = 100, double HNODPKDJHON = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4FDEB00", Offset = "0x4FDDD00", VA = "0x184FDEB00")]
	public void EBGBKPIAHGB(string INGJMJKICGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4FDEE10", Offset = "0x4FDE010", VA = "0x184FDEE10")]
	private bool FNIBIJHNNJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4FDEFA0", Offset = "0x4FDE1A0", VA = "0x184FDEFA0")]
	private void OBKEBFILHLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4FDEAB0", Offset = "0x4FDDCB0", VA = "0x184FDEAB0", Slot = "4")]
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
