using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class EPMBLLONIKL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public delegate int LDIIOBODHJG(IReadOnlyList<char> FFOIKLABBPO, int NNHPDDBNAIJ, string KDGLCAMLLOL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly GIEJNAMICLM BODBHAAJCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly LDIIOBODHJG EHLAJHEPCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly char[] LHCJLMNHNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly MDAPFILHJND[] IIJDGOJLHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly bool[] FIBDDNJOKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly (int SearchStringIndex, int ConsecutiveCount, int Value)[] ALCMOKDDGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly MDAPFILHJND[] PKGCFNPIDLD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x550E80", Offset = "0x54FE80", VA = "0x180550E80")]
	public static int OPKFBCCAIJJ(IReadOnlyList<char> FFOIKLABBPO, int NNHPDDBNAIJ, string KDGLCAMLLOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4BEB7F0", Offset = "0x4BEA7F0", VA = "0x184BEB7F0")]
	public EPMBLLONIKL(IReadOnlyCollection<string> BKDDLCFLMDE, in GIEJNAMICLM AIAJKNAGNBJ, [Optional] LDIIOBODHJG DADAPFAIKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4BEAFF0", Offset = "0x4BE9FF0", VA = "0x184BEAFF0")]
	public string KKCPIELCFPH(string ACCPLFOHDCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4BEAFE0", Offset = "0x4BE9FE0", VA = "0x184BEAFE0")]
	public int ACJKOLKANDG(int LAMFLLGJFMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4BEB070", Offset = "0x4BEA070", VA = "0x184BEB070")]
	public int NAJDBEEGJCA(string ACCPLFOHDCE, int ECBDOELMONK, int AHKEBLNOJNP, ref int NNHPDDBNAIJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct GIEJNAMICLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public readonly bool DALMKPACAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public readonly bool EJOOCIJKEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public readonly int JOLDEFGALOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly int MKGFCPGJLGI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly GIEJNAMICLM ABIEOCMKPHP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GIEJNAMICLM JNOOCAGMNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4BEC6F0", Offset = "0x4BEB6F0", VA = "0x184BEC6F0")]
		get
		{
			return default(GIEJNAMICLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4BEC7B0", Offset = "0x4BEB7B0", VA = "0x184BEC7B0")]
	public GIEJNAMICLM(bool LMPBAHLOEHD, bool NNEGNGIDDOD, int ADOHELFAEFH, int CGJPNNFGAGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public readonly struct MDAPFILHJND : IEquatable<MDAPFILHJND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly int LNGEFDKGBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly int NAJDBEEGJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly int ILDNKIELODO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x858D40", Offset = "0x857D40", VA = "0x180858D40")]
	public MDAPFILHJND(int EKKABPEEACK, int KNJOEFHJBMB, int KMFCOKMJLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4BEC990", Offset = "0x4BEB990", VA = "0x184BEC990")]
	public static int MMDFMOGHNDE(in MDAPFILHJND GONHPLJMHJK, in MDAPFILHJND CHGAACPNHMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D7A1A0", Offset = "0x3D791A0", VA = "0x183D7A1A0", Slot = "4")]
	public bool Equals(MDAPFILHJND JFBDCEDLHDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4BEC870", Offset = "0x4BEB870", VA = "0x184BEC870", Slot = "0")]
	public override bool Equals(object HAFCDCMNBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4BEC920", Offset = "0x4BEB920", VA = "0x184BEC920", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CEFCODDNOLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EPMBLLONIKL HGFBCABADBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private string MDNNMNMPNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private int PIFLGOPMGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int JGPELOFICBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private int HGGJOMDOFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private int FJGPKBOBLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Func<bool> CDHADOJGFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private BBPCGGAEKGD BOLFFBONPHI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<MDAPFILHJND> ENFECECLBOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x751C30", Offset = "0x750C30", VA = "0x180751C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyList<bool> CPMHIBCOCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x19F9300", Offset = "0x19F8300", VA = "0x1819F9300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4BEAF40", Offset = "0x4BE9F40", VA = "0x184BEAF40")]
	public CEFCODDNOLF(IReadOnlyCollection<string> BKDDLCFLMDE, in GIEJNAMICLM AIAJKNAGNBJ, [Optional] EPMBLLONIKL.LDIIOBODHJG DADAPFAIKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4BEAC10", Offset = "0x4BE9C10", VA = "0x184BEAC10")]
	public bool BKCNOMJCAFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4BEADA0", Offset = "0x4BE9DA0", VA = "0x184BEADA0")]
	public void EBIBBOHLEBK(string ACCPLFOHDCE, int CFPIEMDCMAI, Func<bool> EFDLAENCDGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class FFALOOGPFCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public delegate void IOIOEMFLIEE(IReadOnlyList<MDAPFILHJND> DDLGPEIFKOB, IReadOnlyList<bool> NDAGOEPEADO);

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const int LLAOFANMNNJ = 100;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const double INOGDCABBJP = 0.1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly CEFCODDNOLF OIPMLFODDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly IOIOEMFLIEE DPHKCNDNCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly MonoBehaviour BADOAOGCFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly int FJGPKBOBLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly double NCMJNBADHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Stopwatch PONJEKAHDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private IDisposable OMCCFFFGFEB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<MDAPFILHJND> ENFECECLBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4BEC1A0", Offset = "0x4BEB1A0", VA = "0x184BEC1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyList<bool> CPMHIBCOCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4BEC1D0", Offset = "0x4BEB1D0", VA = "0x184BEC1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MCJIBEHFLEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9040", Offset = "0x7A8040", VA = "0x1807A9040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private double DGFOEFOCDAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4BEC110", Offset = "0x4BEB110", VA = "0x184BEC110")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4BEC5B0", Offset = "0x4BEB5B0", VA = "0x184BEC5B0")]
	public FFALOOGPFCG(IReadOnlyCollection<string> BKDDLCFLMDE, in GIEJNAMICLM AIAJKNAGNBJ, IOIOEMFLIEE FDHIMBBLPDB, MonoBehaviour JBPOCMHHIBO, [Optional] EPMBLLONIKL.LDIIOBODHJG DADAPFAIKDH, int CFPIEMDCMAI = 100, double IJJALGJLPJC = 0.1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4BEC2A0", Offset = "0x4BEB2A0", VA = "0x184BEC2A0")]
	public void ODDPLLOMGHP(string ACCPLFOHDCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4BEC200", Offset = "0x4BEB200", VA = "0x184BEC200")]
	private bool LNFBJCCCJGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4BEBFE0", Offset = "0x4BEAFE0", VA = "0x184BEBFE0")]
	private void BKCNOMJCAFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4BEC0C0", Offset = "0x4BEB0C0", VA = "0x184BEC0C0", Slot = "4")]
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
