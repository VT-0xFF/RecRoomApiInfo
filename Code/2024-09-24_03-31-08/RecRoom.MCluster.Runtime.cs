using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.MCluster;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct FOIAEGJBOAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] IDKAMHONGLK;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] IMEBMAMEMJN;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] FBJMEAPAIAK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1605D90", Offset = "0x1604790", VA = "0x181605D90")]
	public static int CGAEKNILMKO(OIBFOHGPJAP KPHOHHILDDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA250", Offset = "0x6BE8C50", VA = "0x186BEA250")]
	public static int DENOGGPIGKH(OIBFOHGPJAP KPHOHHILDDP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FMGLELNEAOE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int PHOGOKMBCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	INLKNLOKEBI HNCIDHGDPLM(int PDJBKOAOLLN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 KMBIJGBPLOA(int PDJBKOAOLLN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FGHMMAJOCCM IHADEMBOOIB();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NMDMIIDOBCA JMBDMLDBOLB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ODMIIBLNLBB : MGFLHNLFKJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private FGHMMAJOCCM ICGEMCDDICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform BDMMEGDJKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<LNKICLCIBML> EMBBBCJOPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BGFKBEMEBGD GFIJHLGHPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GDLPDGLOOMB LKFNOOBDDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HBCPFCMPDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FMGLELNEAOE FAGBJDAEMFB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float MPEAOAIIOEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9B6D90", Offset = "0x9B5790", VA = "0x1809B6D90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCF2150", Offset = "0xCF0B50", VA = "0x180CF2150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool POJBIGOKFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9084C0", Offset = "0x906EC0", VA = "0x1809084C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x906880", Offset = "0x905280", VA = "0x180906880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LCBMCCAEAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC8F9E0", Offset = "0xC8E3E0", VA = "0x180C8F9E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC8F390", Offset = "0xC8DD90", VA = "0x180C8F390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IIKOPGKOKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6272D20", Offset = "0x6271720", VA = "0x186272D20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6272CF0", Offset = "0x62716F0", VA = "0x186272CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IDIPFDNHBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x174AC50", Offset = "0x1749650", VA = "0x18174AC50", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0560", Offset = "0x6BEEF60", VA = "0x186BF0560")]
	public ODMIIBLNLBB(FMGLELNEAOE FCCHPKGBOPA, bool HBBCKOKDACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF330", Offset = "0x6BEDD30", VA = "0x186BEF330")]
	private bool BNHCHHIDHKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF950", Offset = "0x6BEE350", VA = "0x186BEF950", Slot = "4")]
	public bool KDCHLCHLBCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF560", Offset = "0x6BEDF60", VA = "0x186BEF560", Slot = "5")]
	public bool EOBPLEKHDDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF730", Offset = "0x6BEE130", VA = "0x186BEF730", Slot = "6")]
	public void GDFNAHCIADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF550", Offset = "0x6BEDF50", VA = "0x186BEF550", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KGFHPBOIAMH
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLEGNDIFCEJ(CommandBuffer KIDNBOFHEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NGHFLPJAGLJ : KGFHPBOIAMH
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int POAGINPHPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier HJOKAOLFFKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4469D90", Offset = "0x4468790", VA = "0x184469D90")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDC30", Offset = "0x6BEC630", VA = "0x186BEDC30")]
	public NGHFLPJAGLJ(int DNICIAANFHD, RenderTargetIdentifier LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDBE0", Offset = "0x6BEC5E0", VA = "0x186BEDBE0", Slot = "4")]
	public void OLEGNDIFCEJ(CommandBuffer KIDNBOFHEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HFOMAOGJIIO : KGFHPBOIAMH
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int POAGINPHPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] PGBOMEEAKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xAFAF10", Offset = "0xAF9910", VA = "0x180AFAF10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xFFE660", Offset = "0xFFD060", VA = "0x180FFE660")]
	public HFOMAOGJIIO(int DNICIAANFHD, Vector4[] LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAD20", Offset = "0x6BE9720", VA = "0x186BEAD20", Slot = "4")]
	public void OLEGNDIFCEJ(CommandBuffer KIDNBOFHEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JANLHNEPONC : KGFHPBOIAMH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int POAGINPHPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] OOGLPBJIABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAFAF10", Offset = "0xAF9910", VA = "0x180AFAF10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0xFFE660", Offset = "0xFFD060", VA = "0x180FFE660")]
	public JANLHNEPONC(int DNICIAANFHD, float[] LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB270", Offset = "0x6BE9C70", VA = "0x186BEB270", Slot = "4")]
	public void OLEGNDIFCEJ(CommandBuffer KIDNBOFHEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct MHDEJNEBFBJ : KGFHPBOIAMH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string FMJDNGHFJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x96CBC0", Offset = "0x96B5C0", VA = "0x18096CBC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool LPLMCBCEJBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1F31FF0", Offset = "0x1F309F0", VA = "0x181F31FF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x446E310", Offset = "0x446CD10", VA = "0x18446E310")]
	public MHDEJNEBFBJ(string DDDMPLCOGIM, bool PBBOCFHFMJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDA40", Offset = "0x6BEC440", VA = "0x186BEDA40", Slot = "4")]
	public void OLEGNDIFCEJ(CommandBuffer KIDNBOFHEDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NMDMIIDOBCA
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 FNFMIKMEOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xC382E0", Offset = "0xC36CE0", VA = "0x180C382E0")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 OONHAIDFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9F9DB0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int HHNDNMFKLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x92EC80", Offset = "0x92D680", VA = "0x18092EC80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int LPKEIKBJDOP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4080", Offset = "0x8C2A80", VA = "0x1808C4080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float CJHNMJPGKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B6DB0", Offset = "0x9B57B0", VA = "0x1809B6DB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDCE0", Offset = "0x6BEC6E0", VA = "0x186BEDCE0")]
	public NMDMIIDOBCA(Color BJCIGJMGMBG, int HPFODGNOKDB, int DFOHIMDHCEM, float HOOBMODJOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xB916C0", Offset = "0xB900C0", VA = "0x180B916C0")]
	private static float4 LHFFDEIPEOC(Color BJCIGJMGMBG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDC50", Offset = "0x6BEC650", VA = "0x186BEDC50")]
	private static Hash128 HOAPNPOOIGK(NMDMIIDOBCA FCCHPKGBOPA)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class BGFKBEMEBGD : MGFLHNLFKJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string COKPHJLEOKJ;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string JKGAEDJHPMJ;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string PLIPOGKMFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NMDMIIDOBCA JPFKIJECEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private HLKGEMOBFNC PPFNGNPGEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 BDBIPAJKHOM;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public GDLPDGLOOMB GNNPCLHFKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8AB7F0", Offset = "0x8AA1F0", VA = "0x1808AB7F0")]
		[CompilerGenerated]
		get
		{
			return default(GDLPDGLOOMB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD09080", Offset = "0xD07A80", VA = "0x180D09080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool POJBIGOKFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BEAAB0", Offset = "0x5BE94B0", VA = "0x185BEAAB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5BEAAC0", Offset = "0x5BE94C0", VA = "0x185BEAAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LCBMCCAEAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x20AFED0", Offset = "0x20AE8D0", VA = "0x1820AFED0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B7E350", Offset = "0x6B7CD50", VA = "0x186B7E350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IDIPFDNHBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool IIKOPGKOKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5CA0940", Offset = "0x5C9F340", VA = "0x185CA0940", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1470", Offset = "0x6BDFE70", VA = "0x186BE1470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int BDIPFIAMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE16D0", Offset = "0x6BE00D0", VA = "0x186BE16D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1840", Offset = "0x6BE0240", VA = "0x186BE1840")]
	public BGFKBEMEBGD(NMDMIIDOBCA AOJGHDIINDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE11C0", Offset = "0x6BDFBC0", VA = "0x186BE11C0")]
	private bool BNHCHHIDHKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1580", Offset = "0x6BDFF80", VA = "0x186BE1580", Slot = "4")]
	public bool KDCHLCHLBCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1720", Offset = "0x6BE0120", VA = "0x186BE1720")]
	private static HLKGEMOBFNC ODCPAIGAJBI(NMDMIIDOBCA FCCHPKGBOPA)
	{
		return default(HLKGEMOBFNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6BE12C0", Offset = "0x6BDFCC0", VA = "0x186BE12C0", Slot = "5")]
	public bool EOBPLEKHDDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1480", Offset = "0x6BDFE80", VA = "0x186BE1480", Slot = "6")]
	public void GDFNAHCIADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "9")]
	public void Dispose()
	{
	}
}
namespace RecRoom.MCluster
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MClusterData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			[Reload("Shaders/ClusterUpdate.compute", ReloadAttribute.Package.Root)]
			public ComputeShader UpdateShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			[Reload("Shaders/ClusterRaster.compute", ReloadAttribute.Package.Root)]
			public ComputeShader ClusterRasterShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			[Reload("Shaders/ClusterCoarseCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader CoarseCullShader;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			[Reload("Shaders/ClusterFineCull.compute", ReloadAttribute.Package.Root)]
			public ComputeShader FineCullShader;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6BED0F0", Offset = "0x6BEBAF0", VA = "0x186BED0F0", Slot = "0")]
		public override bool Equals(object CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6BED2F0", Offset = "0x6BEBCF0", VA = "0x186BED2F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x994550", Offset = "0x992F50", VA = "0x180994550")]
		public MClusterData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleRendererFeature(null)]
	public class MClusterRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IGPDKCIAAGK opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static DEIFFGNHJHA CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6BED9B0", Offset = "0x6BEC3B0", VA = "0x186BED9B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6BED9F0", Offset = "0x6BEC3F0", VA = "0x186BED9F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6BED3D0", Offset = "0x6BEBDD0", VA = "0x186BED3D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BED3A0", Offset = "0x6BEBDA0", VA = "0x186BED3A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DGLLFNJJPBO, RenderingData NPNFJHBDFOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BED820", Offset = "0x6BEC220", VA = "0x186BED820")]
		public void HEDNLNGDIMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x100ED00", Offset = "0x100D700", VA = "0x18100ED00")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PIFOAHDOMMJ<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private GMJAGIEDAPE GDNDDLGABEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private GMJAGIEDAPE EEIEGNPIGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer AMHJPCOLJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture AMFMGMDNGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int OMALKJALBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int IKNLIAPFNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string MOGKEHNNBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string KPOKBJIELGK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8892E0", Offset = "0x887CE0", VA = "0x1808892E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int LKEEGGAEIPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x92EC90", Offset = "0x92D690", VA = "0x18092EC90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int FEBDKHACFJH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8A2140", Offset = "0x8A0B40", VA = "0x1808A2140")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x49B19D0", Offset = "0x49B03D0", VA = "0x1849B19D0")]
	public PIFOAHDOMMJ(string DDDMPLCOGIM, int JLEHLCHPLLE, [Optional] RenderTextureFormat? EPLBBPBANLK, bool APBLMAOMHCA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x49ADD40", Offset = "0x49AC740", VA = "0x1849ADD40")]
	public void EOBPLEKHDDD(CommandBuffer KIDNBOFHEDH, NativeArray<ValType> LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x49AEED0", Offset = "0x49AD8D0", VA = "0x1849AEED0")]
	public void IJLLOPOCCDO(CommandBuffer KIDNBOFHEDH, ComputeShader MAGOLDFOHLC, int DIIFGBNECCF, int AEBIMJDOODD = -1, int AMFJCLBEMCC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x49AF5C0", Offset = "0x49ADFC0", VA = "0x1849AF5C0")]
	public void IJLLOPOCCDO(Material PPFNGNPGEKG, int AEBIMJDOODD = -1, int AMFJCLBEMCC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x49AD520", Offset = "0x49ABF20", VA = "0x1849AD520", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PAMGGKCHCGA
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJLLOPOCCDO(Material AOJGHDIINDK);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GFPBCLOHJEG<SrcEntry, DstEntry> : PAMGGKCHCGA, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] NBLLOBMHEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected GMJAGIEDAPE IFJEEJBNLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected GMJAGIEDAPE EKJAKMMNELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> FFGJEJCKIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> PHNANLDJMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int KPADIFEEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int IANDIDOLGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected PIFOAHDOMMJ<int> GMBCLLGODAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected PIFOAHDOMMJ<SrcEntry> NBGFLFIELPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected PIFOAHDOMMJ<DstEntry> ELIDKFKMJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader JMJPLPEHNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int DGBPIKMGCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int POOHIABNEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int ODIMDDILNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int KNMLCJLEFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int IAAKOOLAFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int LNDDMJODDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int BIGAMDCIIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int LHLCEBEHBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int FHMOOLADMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int NHOPMANKFGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int CFECGCMHJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int JIFHGMHLGCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string FCGNOOCCGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] OBKNHONBHHM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int OAKGABBNEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3ECB0E0", Offset = "0x3EC9AE0", VA = "0x183ECB0E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string KHIFKFJBOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3ECBF60", Offset = "0x3ECA960", VA = "0x183ECBF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3ECEB20", Offset = "0x3ECD520", VA = "0x183ECEB20")]
	public GFPBCLOHJEG(string DDDMPLCOGIM, int OBFDPILAHJO, int MKCBGBBALLD, RenderTextureFormat EPLBBPBANLK, ComputeShader NACNBHMFKMN, int OJDPEFOKPIC = 0, int PBKGNHHHLGM = 0, int BBLEKHECBDO = 0, int AIIFCLDKGLF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBA10", Offset = "0x3ECA410", VA = "0x183ECBA10")]
	public int IBBNDLGLAHE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB090", Offset = "0x3EC9A90", VA = "0x183ECB090")]
	protected void EIPDBMCECED(int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3ECD5F0", Offset = "0x3ECBFF0", VA = "0x183ECD5F0")]
	public GDLPDGLOOMB KDCHLCHLBCK(SrcEntry LNCKNHNHHDF)
	{
		return default(GDLPDGLOOMB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB2B0", Offset = "0x3EC9CB0", VA = "0x183ECB2B0")]
	public bool EOBPLEKHDDD(GDLPDGLOOMB DKMIJDPJCBM, SrcEntry LNCKNHNHHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3ECB890", Offset = "0x3ECA290", VA = "0x183ECB890")]
	public bool GDFNAHCIADO(GDLPDGLOOMB DKMIJDPJCBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
	protected virtual void ANHCBAGGANE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3ECCEB0", Offset = "0x3ECB8B0", VA = "0x183ECCEB0", Slot = "7")]
	public void JJFOAINCFIF(CommandBuffer KIDNBOFHEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3ECC7D0", Offset = "0x3ECB1D0", VA = "0x183ECC7D0", Slot = "8")]
	public void JJFOAINCFIF(CommandBuffer KIDNBOFHEDH, ComputeShader NACNBHMFKMN, int OJDPEFOKPIC = -1, int PBKGNHHHLGM = -1, int BBLEKHECBDO = -1, int AIIFCLDKGLF = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBAF0", Offset = "0x3ECA4F0", VA = "0x183ECBAF0", Slot = "9")]
	public void IJLLOPOCCDO(CommandBuffer KIDNBOFHEDH, ComputeShader NACNBHMFKMN, int OJDPEFOKPIC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3ECBA80", Offset = "0x3ECA480", VA = "0x183ECBA80", Slot = "4")]
	public void IJLLOPOCCDO(Material PPFNGNPGEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAD90", Offset = "0x3EC9790", VA = "0x183ECAD90", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GMJAGIEDAPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong KLGCAFFPKJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong CPCOEIMKKFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EOCLGOCMJJI
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct ABBNFJCLEOE : GMJAGIEDAPE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable FHNCCICEJBE;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong KLGCAFFPKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAFAF10", Offset = "0xAF9910", VA = "0x180AFAF10", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xBAA9D0", Offset = "0xBA93D0", VA = "0x180BAA9D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong CPCOEIMKKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x903080", Offset = "0x901A80", VA = "0x180903080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4EF6930", Offset = "0x4EF5330", VA = "0x184EF6930")]
		internal ABBNFJCLEOE(IDisposable DHGDHIFMAIG, ulong ICFNLJFMLJP, ulong OMOFNECFMLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6BE0750", Offset = "0x6BDF150", VA = "0x186BE0750", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct DNIFOEHNILE : GMJAGIEDAPE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture POAEEBPJHMD;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong KLGCAFFPKJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xAFAF10", Offset = "0xAF9910", VA = "0x180AFAF10", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xBAA9D0", Offset = "0xBA93D0", VA = "0x180BAA9D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong CPCOEIMKKFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x903080", Offset = "0x901A80", VA = "0x180903080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE93B0", Offset = "0x6BE7DB0", VA = "0x186BE93B0")]
		public DNIFOEHNILE(RenderTexture CGILPHBKMOF, ulong JCCPEAADPGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9310", Offset = "0x6BE7D10", VA = "0x186BE9310", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong FHBMDKLGHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9FF0", Offset = "0x6BE89F0", VA = "0x186BE9FF0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA170", Offset = "0x6BE8B70", VA = "0x186BEA170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong JCHJADLENNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9900", Offset = "0x6BE8300", VA = "0x186BE9900")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9FB0", Offset = "0x6BE89B0", VA = "0x186BE9FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9940", Offset = "0x6BE8340", VA = "0x186BE9940")]
	public static ComputeBuffer EMJKOLAJLFI(int CMNDBGDABDM, int GCHPLMBLFHD, ComputeBufferType AOGCIMANLIJ, [Out] GMJAGIEDAPE DKMIJDPJCBM, ComputeBufferMode LKBCPIIGDOH = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9B10", Offset = "0x6BE8510", VA = "0x186BE9B10")]
	public static RenderTexture EMJKOLAJLFI(int GBFKBKLFFAE, int GLAECBJDJFJ, int PHFLJEEIDLB, RenderTextureFormat EPLBBPBANLK, [Out] GMJAGIEDAPE DKMIJDPJCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD31B0", Offset = "0x2BD1BB0", VA = "0x182BD31B0")]
	public static NativeArray<T> NILACPLJKLB<T>(NativeArray<T> FHNCCICEJBE, ulong CGDCIDKGGML, [Out] GMJAGIEDAPE DKMIJDPJCBM) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD30F0", Offset = "0x2BD1AF0", VA = "0x182BD30F0")]
	public static NativeArray<T> EMJKOLAJLFI<T>(int CGDCIDKGGML, Allocator MPFEIGMBFCP, [Out] GMJAGIEDAPE DKMIJDPJCBM, NativeArrayOptions JIEJKJIJPFC = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA030", Offset = "0x6BE8A30", VA = "0x186BEA030")]
	public static void MOGENANDEFO(GMJAGIEDAPE FHNCCICEJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9EA0", Offset = "0x6BE88A0", VA = "0x186BE9EA0")]
	public static uint JHMJNLCNHMA(RenderTextureFormat EPLBBPBANLK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BBKNOEMHNKN : GFPBCLOHJEG<MKNPMPJAHMG, MKNPMPJAHMG>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct NNFCKMAJDBN : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> AKHCJEMFEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> PBDJHLCACGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> DPGPLICNNOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> KHECPLHNJLO;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA220", Offset = "0x6BE8C20", VA = "0x186BEA220")]
		public NNFCKMAJDBN(NativeArray<int> OHKDHNHOFDI, NativeArray<float> MDMOCFEIADC, NativeArray<float4x4> FJOAJPDCGLE, NativeArray<float4> BFCLJIDPENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6BEDEC0", Offset = "0x6BEC8C0", VA = "0x186BEDEC0", Slot = "4")]
		public void Execute(int ENMILGHAHOM, TransformAccess ICGEMCDDICC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct FJJDGKNEFNN : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> AKHCJEMFEEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> DIKLOIAEIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> LIPAIMDNNHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<MKNPMPJAHMG> MJOHPLLPKGI;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA220", Offset = "0x6BE8C20", VA = "0x186BEA220")]
		public FJJDGKNEFNN(NativeArray<int> OHKDHNHOFDI, NativeArray<float4x4> CBKAOFFDMHD, NativeArray<float4> EKAHLKBNAIH, NativeArray<MKNPMPJAHMG> NMMHFBINDGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA1B0", Offset = "0x6BE8BB0", VA = "0x186BEA1B0", Slot = "4")]
		public void Execute(int ENMILGHAHOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte MBGFJHPAJDE = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray HKBCIBDPNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> KEPDMCPIJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> BABCNGCPIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> KKJMBAOEOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> NEIGCEKBBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> DHDDMHHLLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private GMJAGIEDAPE MPGMLIKBEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private GMJAGIEDAPE NKALHICLHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private GMJAGIEDAPE PBCOMKDMEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private GMJAGIEDAPE EDGOPKCLJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private GMJAGIEDAPE OAGLBIIFAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform GLIHHHCIBJK;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0EE0", Offset = "0x6BDF8E0", VA = "0x186BE0EE0")]
	public BBKNOEMHNKN(int OBFDPILAHJO, int MKCBGBBALLD, ComputeShader NACNBHMFKMN, int OJDPEFOKPIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0880", Offset = "0x6BDF280", VA = "0x186BE0880", Slot = "6")]
	protected override void ANHCBAGGANE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0E20", Offset = "0x6BDF820", VA = "0x186BE0E20")]
	private void PACBDMMEOFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0CC0", Offset = "0x6BDF6C0", VA = "0x186BE0CC0")]
	public bool MFPNJMMNFPB(GDLPDGLOOMB DKMIJDPJCBM, Transform ICGEMCDDICC, float GHKOLIMNCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0BE0", Offset = "0x6BDF5E0", VA = "0x186BE0BE0")]
	public void FCEAEJLJDIP(GDLPDGLOOMB DKMIJDPJCBM, float GHKOLIMNCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0A90", Offset = "0x6BDF490", VA = "0x186BE0A90")]
	public void DOGEOMOFMEN(GDLPDGLOOMB DKMIJDPJCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0B40", Offset = "0x6BDF540", VA = "0x186BE0B40", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface INLKNLOKEBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CCDNCOACIDM EKAOOMEJNOB();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface BFNKNKGMLJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 FNFMIKMEOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int DLPMFIBCHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int PDIJFBBJBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> EDBNILFNKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> CJCJBFOPPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> KCLMNDKCEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> OHNNMDDMJDL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> EJKLHGFHOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> ECINGBKKLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int BDEEKIHABFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int LJBICMLGMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int JGBHPDOPFEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool HFFPLCAIBPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JJFOAINCFIF();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DAHAPMDLKAN : BFNKNKGMLJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private INLKNLOKEBI DKOLKPPOILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private CCDNCOACIDM LDNHICGPCIN;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 FNFMIKMEOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9F9DB0", VA = "0x1809FB3B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9FB630", Offset = "0x9FA030", VA = "0x1809FB630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool HIPDDNMHKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x88B250", Offset = "0x889C50", VA = "0x18088B250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int DLPMFIBCHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8C4080", Offset = "0x8C2A80", VA = "0x1808C4080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8C3670", Offset = "0x8C2070", VA = "0x1808C3670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int PDIJFBBJBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884030", VA = "0x180885630", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x885650", Offset = "0x884050", VA = "0x180885650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int PKOIBJOGBIK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xDAC790", Offset = "0xDAB190", VA = "0x180DAC790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> EDBNILFNKMN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1DB0", Offset = "0x6BE07B0", VA = "0x186BE1DB0", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> CJCJBFOPPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1C80", Offset = "0x6BE0680", VA = "0x186BE1C80", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> KCLMNDKCEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1FD0", Offset = "0x6BE09D0", VA = "0x186BE1FD0", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> OHNNMDDMJDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1CB0", Offset = "0x6BE06B0", VA = "0x186BE1CB0", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> EJKLHGFHOIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1E20", Offset = "0x6BE0820", VA = "0x186BE1E20", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> ECINGBKKLCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1FA0", Offset = "0x6BE09A0", VA = "0x186BE1FA0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool HFFPLCAIBPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xC320D0", Offset = "0xC30AD0", VA = "0x180C320D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xD12ED0", Offset = "0xD118D0", VA = "0x180D12ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int BDEEKIHABFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2000", Offset = "0x6BE0A00", VA = "0x186BE2000", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int LJBICMLGMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1E50", Offset = "0x6BE0850", VA = "0x186BE1E50", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int JGBHPDOPFEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1E70", Offset = "0x6BE0870", VA = "0x186BE1E70", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2010", Offset = "0x6BE0A10", VA = "0x186BE2010")]
	public DAHAPMDLKAN(Hash128 IHNIDNBHBBH, INLKNLOKEBI DKOLKPPOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1E90", Offset = "0x6BE0890", VA = "0x186BE1E90", Slot = "16")]
	public void JJFOAINCFIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1D20", Offset = "0x6BE0720", VA = "0x186BE1D20", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GDLPDGLOOMB : IEquatable<GDLPDGLOOMB>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly GDLPDGLOOMB GOLLGDANENM;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int BDIPFIAMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9FE7F0", Offset = "0x9FD1F0", VA = "0x1809FE7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xBAA9E0", Offset = "0xBA93E0", VA = "0x180BAA9E0")]
	public GDLPDGLOOMB(int ENMILGHAHOM = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA900", Offset = "0x6BE9300", VA = "0x186BEA900", Slot = "4")]
	public bool Equals(GDLPDGLOOMB CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6BEA950", Offset = "0x6BE9350", VA = "0x186BEA950", Slot = "0")]
	public override bool Equals(object FHFDEAHMMBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAA20", Offset = "0x6BE9420", VA = "0x186BEAA20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class LNKICLCIBML : MGFLHNLFKJL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool HBCPFCMPDPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private BFNKNKGMLJL OEMGMAHHIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<GDLPDGLOOMB> MPONKMBAEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<GDLPDGLOOMB> NLHNKHEHMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<GDLPDGLOOMB> IGLAEDHHKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> IANNELNOMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int NHPNPOOIEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int OCJJKCEPHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int NEGIDCNFGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int MKJIFFMKPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int BPBNECNMIND;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int BDIPFIAMOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6BECED0", Offset = "0x6BEB8D0", VA = "0x186BECED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB5F0", Offset = "0x6BE9FF0", VA = "0x186BEB5F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool POJBIGOKFLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x913F50", Offset = "0x912950", VA = "0x180913F50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x913F60", Offset = "0x912960", VA = "0x180913F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool LCBMCCAEAKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xDBE7C0", Offset = "0xDBD1C0", VA = "0x180DBE7C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xDBE860", Offset = "0xDBD260", VA = "0x180DBE860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool IDIPFDNHBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x89F000", Offset = "0x89DA00", VA = "0x18089F000", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool IIKOPGKOKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4CF0450", Offset = "0x4CEEE50", VA = "0x184CF0450", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1CEE230", Offset = "0x1CECC30", VA = "0x181CEE230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float MPEAOAIIOEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x98B4C0", Offset = "0x989EC0", VA = "0x18098B4C0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x98B600", Offset = "0x98A000", VA = "0x18098B600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6BECF80", Offset = "0x6BEB980", VA = "0x186BECF80")]
	public LNKICLCIBML(BFNKNKGMLJL LDNHICGPCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC020", Offset = "0x6BEAA20", VA = "0x186BEC020")]
	private void HAJHHEMOJKO(BFNKNKGMLJL LDNHICGPCIN, int NHPNPOOIEDN, int EBDHJDHNECO, int ENMILGHAHOM, int GGOHDJBGEMA, CBMONPGANMF LNCKNHNHHDF, float IBGMHGDAFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB710", Offset = "0x6BEA110", VA = "0x186BEB710")]
	private void FNAOLNDDLBL(BFNKNKGMLJL LDNHICGPCIN, int ALAJAHEOJJD, int ENMILGHAHOM, uint3 BKBMGLFBOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB350", Offset = "0x6BE9D50", VA = "0x186BEB350")]
	private bool BNHCHHIDHKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6BEC4F0", Offset = "0x6BEAEF0", VA = "0x186BEC4F0", Slot = "4")]
	public bool KDCHLCHLBCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB690", Offset = "0x6BEA090", VA = "0x186BEB690", Slot = "5")]
	public bool EOBPLEKHDDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB9D0", Offset = "0x6BEA3D0", VA = "0x186BEB9D0", Slot = "6")]
	public void GDFNAHCIADO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB630", Offset = "0x6BEA030", VA = "0x186BEB630")]
	public void GNKJKLNBJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB630", Offset = "0x6BEA030", VA = "0x186BEB630", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MGFLHNLFKJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool IDIPFDNHBDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool IIKOPGKOKAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KDCHLCHLBCK();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EOBPLEKHDDD();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GDFNAHCIADO();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NPAJIMLICOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float ALPCLBHBPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, LNKICLCIBML> CHDGLLKGCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, BGFKBEMEBGD> KIPNKDJDGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<MGFLHNLFKJL> OENMNPGEAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<MGFLHNLFKJL> EBONKIAIKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<MGFLHNLFKJL> KNNBLKCMOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int EDJICGODAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int HFMAMINANGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float AJBDAKDPAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool HKBAGLCKANC;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool JEIPMMKMIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1034390", Offset = "0x1032D90", VA = "0x181034390")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x103BF10", Offset = "0x103A910", VA = "0x18103BF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool IMCKIBMDPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF110", Offset = "0x6BEDB10", VA = "0x186BEF110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string KHIFKFJBOKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6BEE8C0", Offset = "0x6BED2C0", VA = "0x186BEE8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE080", Offset = "0x6BECA80", VA = "0x186BEE080")]
	public void ACGPBHLABNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE780", Offset = "0x6BED180", VA = "0x186BEE780")]
	public void GPNLNKNLFOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF1A0", Offset = "0x6BEDBA0", VA = "0x186BEF1A0")]
	public NPAJIMLICOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE230", Offset = "0x6BECC30", VA = "0x186BEE230")]
	public ODMIIBLNLBB FBIMIMMHNIB(FMGLELNEAOE MHOPBKMJKKN, bool HBBCKOKDACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE360", Offset = "0x6BECD60", VA = "0x186BEE360")]
	public BGFKBEMEBGD FBIMIMMHNIB(NMDMIIDOBCA PPFNGNPGEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE090", Offset = "0x6BECA90", VA = "0x186BEE090")]
	public bool BLNADNEANBH(Hash128 DNICIAANFHD, [Out] LNKICLCIBML JMIENFCGLPB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE4A0", Offset = "0x6BECEA0", VA = "0x186BEE4A0")]
	public LNKICLCIBML FBIMIMMHNIB(BFNKNKGMLJL LDNHICGPCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE210", Offset = "0x6BECC10", VA = "0x186BEE210")]
	private void ECJDPPGJMDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE790", Offset = "0x6BED190", VA = "0x186BEE790")]
	private bool HCPEGGLKOPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6BEEC60", Offset = "0x6BED660", VA = "0x186BEEC60")]
	public void JJFOAINCFIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE100", Offset = "0x6BECB00", VA = "0x186BEE100", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6BEE810", Offset = "0x6BED210", VA = "0x186BEE810")]
	public void IKHFGDALBFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NNBPMEFHOJI : GFPBCLOHJEG<DMNIPOFMLCO, DMNIPOFMLCO>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDE10", Offset = "0x6BEC810", VA = "0x186BEDE10")]
	public NNBPMEFHOJI(int OBFDPILAHJO, int MKCBGBBALLD, ComputeShader NACNBHMFKMN, int OJDPEFOKPIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GKCMOMOFEOF : GFPBCLOHJEG<HLKGEMOBFNC, HLKGEMOBFNC>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAAB0", Offset = "0x6BE94B0", VA = "0x186BEAAB0")]
	public GKCMOMOFEOF(int OBFDPILAHJO, int MKCBGBBALLD, ComputeShader NACNBHMFKMN, int OJDPEFOKPIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class KNFHMBCOGHF : GFPBCLOHJEG<INAJELFMLFM, INAJELFMLFM>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB2A0", Offset = "0x6BE9CA0", VA = "0x186BEB2A0")]
	public KNFHMBCOGHF(int OBFDPILAHJO, int MKCBGBBALLD, ComputeShader NACNBHMFKMN, int OJDPEFOKPIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class AEIHNIKEHNG : GFPBCLOHJEG<MDIDDCHBKCN, HMNCIFBLJNF>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6BE07D0", Offset = "0x6BDF1D0", VA = "0x186BE07D0")]
	public AEIHNIKEHNG(int OBFDPILAHJO, int MKCBGBBALLD, ComputeShader NACNBHMFKMN, int OJDPEFOKPIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PFBBOPNPLMI : GFPBCLOHJEG<BMKPBEDAHIJ, BMKPBEDAHIJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0620", Offset = "0x6BEF020", VA = "0x186BF0620")]
	public PFBBOPNPLMI(int OBFDPILAHJO, int MKCBGBBALLD, ComputeShader NACNBHMFKMN, int OJDPEFOKPIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class IGPDKCIAAGK : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private DEIFFGNHJHA EOEHGNEGILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool PBBOCFHFMJC;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool EDLNNAJAECL;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB180", Offset = "0x6BE9B80", VA = "0x186BEB180")]
	public IGPDKCIAAGK(DEIFFGNHJHA GIJGFIEBMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAFF0", Offset = "0x6BE99F0", VA = "0x186BEAFF0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer KIDNBOFHEDH, RenderingData NPNFJHBDFOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAD80", Offset = "0x6BE9780", VA = "0x186BEAD80", Slot = "6")]
	public override void Configure(CommandBuffer KIDNBOFHEDH, RenderTextureDescriptor GABFKKPIOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6BEADC0", Offset = "0x6BE97C0", VA = "0x186BEADC0", Slot = "9")]
	public override void Execute(ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class ENMPBPLFNKL
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct GPEFGGMFKNP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string DDDMPLCOGIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer KIDNBOFHEDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext MPOBGCPIOEI;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6BEAC10", Offset = "0x6BE9610", VA = "0x186BEAC10")]
		public GPEFGGMFKNP(string CMPCCOBJNDL, ScriptableRenderContext GFKFIMKFJND, [Out] CommandBuffer HCJGPHFDMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6BEAB60", Offset = "0x6BE9560", VA = "0x186BEAB60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6BE97B0", Offset = "0x6BE81B0", VA = "0x186BE97B0")]
	public static bool OIIEOHLKGGE(RenderingData NPNFJHBDFOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6BE93E0", Offset = "0x6BE7DE0", VA = "0x186BE93E0")]
	public static void BLJKLEHGFKM(CommandBuffer KIDNBOFHEDH, ScriptableRenderContext MPOBGCPIOEI, ShadowDrawingSettings ONONNKMGMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9580", Offset = "0x6BE7F80", VA = "0x186BE9580")]
	public static void EHCFGFGNDEI(CommandBuffer KIDNBOFHEDH, ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class DEIFFGNHJHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class DEFNENPBBFB
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int MDEGPGCLABC;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int HHIGEEJOEEF;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static PIFOAHDOMMJ<PGPJLCNJGAG> IBNCFBKLLHL;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static PIFOAHDOMMJ<uint> KHPNOMDNEAN;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static GMJAGIEDAPE OMCDMEMAHAP;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer ABJGCHMJDIL;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<PAMGGKCHCGA> PIGJEGLHKIE;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int DPEKHPDJLHC;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int KIOACJLMEAH;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int JHBMMBOJPAJ;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int AACMFACIHMK;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] ADEHKLGJEEO;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] CFGHBPFNKAE;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static KGFHPBOIAMH[][] JDDBHDGMMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] JOJAPMBKNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int LIKBLBPHMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int ABEJJDACFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int OHJDJCCEMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int KLBBDGEBDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int EJHILKLBEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int BPDKKOAOMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int ECBNCDMFGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int MLAPKOKBHGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int PKDOOCMIPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int GBPMGBCALEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int FLFNOCDPPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int KAELBHBGMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int ADBODCEJAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int GMBBEJJICMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int DOLOFDNJOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int MDINHDGEIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int ELDMOCCLACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int LDPCIKPLNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] NLMHKPELCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private NPAJIMLICOM CKJCIDLDEPC;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool PMOJFLDEEML
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3030", Offset = "0x6BE1A30", VA = "0x186BE3030")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6BE74B0", Offset = "0x6BE5EB0", VA = "0x186BE74B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool HFDJDELEPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8930", Offset = "0x6BE7330", VA = "0x186BE8930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6BE23C0", Offset = "0x6BE0DC0", VA = "0x186BE23C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData EIPGALGMOJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3080", Offset = "0x6BE1A80", VA = "0x186BE3080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2180", Offset = "0x6BE0B80", VA = "0x186BE2180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static BBKNOEMHNKN OBCMMALGHIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2130", Offset = "0x6BE0B30", VA = "0x186BE2130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8850", Offset = "0x6BE7250", VA = "0x186BE8850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static NNBPMEFHOJI GODIKALMJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3540", Offset = "0x6BE1F40", VA = "0x186BE3540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8980", Offset = "0x6BE7380", VA = "0x186BE8980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static GKCMOMOFEOF DMKEIOPCBNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8BE0", Offset = "0x6BE75E0", VA = "0x186BE8BE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7510", Offset = "0x6BE5F10", VA = "0x186BE7510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static KNFHMBCOGHF EEMBKNKEKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7460", Offset = "0x6BE5E60", VA = "0x186BE7460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8AD0", Offset = "0x6BE74D0", VA = "0x186BE8AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static AEIHNIKEHNG JGLOLFHHIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6BE5A40", Offset = "0x6BE4440", VA = "0x186BE5A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6BE5BB0", Offset = "0x6BE45B0", VA = "0x186BE5BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static PFBBOPNPLMI PJGMKBHIDAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7580", Offset = "0x6BE5F80", VA = "0x186BE7580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6BE46B0", Offset = "0x6BE30B0", VA = "0x186BE46B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material MMILKJDIJCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6BE5A90", Offset = "0x6BE4490", VA = "0x186BE5A90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6BE62D0", Offset = "0x6BE4CD0", VA = "0x186BE62D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material PAEECNDENGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8CA0", Offset = "0x6BE76A0", VA = "0x186BE8CA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6BE87E0", Offset = "0x6BE71E0", VA = "0x186BE87E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material JKCFJGHOCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6BE4490", Offset = "0x6BE2E90", VA = "0x186BE4490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6BE5B40", Offset = "0x6BE4540", VA = "0x186BE5B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material FPCGEFNBBGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6BE20E0", Offset = "0x6BE0AE0", VA = "0x186BE20E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8C30", Offset = "0x6BE7630", VA = "0x186BE8C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool EJDGBBJNJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6BE44E0", Offset = "0x6BE2EE0", VA = "0x186BE44E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6BE5AE0", Offset = "0x6BE44E0", VA = "0x186BE5AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool IMCKIBMDPPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6340", Offset = "0x6BE4D40", VA = "0x186BE6340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string KHIFKFJBOKB
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6BE5C20", Offset = "0x6BE4620", VA = "0x186BE5C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8D80", Offset = "0x6BE7780", VA = "0x186BE8D80")]
	internal DEIFFGNHJHA([Optional] MClusterData DGMOIMIBJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4720", Offset = "0x6BE3120", VA = "0x186BE4720")]
	public void HINDDHMAHAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8B40", Offset = "0x6BE7540", VA = "0x186BE8B40")]
	public void OOHHDLACEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3020", Offset = "0x6BE1A20", VA = "0x186BE3020")]
	public void EAIGNNFHGBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4610", Offset = "0x6BE3010", VA = "0x186BE4610")]
	public bool HFPLFJIPHIP(Hash128 IHNIDNBHBBH, [Out] LNKICLCIBML LDNHICGPCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3290", Offset = "0x6BE1C90", VA = "0x186BE3290")]
	public LNKICLCIBML FBIMIMMHNIB(BFNKNKGMLJL LNCKNHNHHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3350", Offset = "0x6BE1D50", VA = "0x186BE3350")]
	public BGFKBEMEBGD FBIMIMMHNIB(NMDMIIDOBCA PPFNGNPGEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6BE30D0", Offset = "0x6BE1AD0", VA = "0x186BE30D0")]
	public ODMIIBLNLBB FBIMIMMHNIB(FMGLELNEAOE MHOPBKMJKKN, bool HBBCKOKDACO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3B70", Offset = "0x6BE2570", VA = "0x186BE3B70")]
	public void GDFNAHCIADO(MGFLHNLFKJL LJHMHPGNKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6BE89F0", Offset = "0x6BE73F0", VA = "0x186BE89F0")]
	public static void OHOIPBFLKHG(OIBFOHGPJAP KPHOHHILDDP, KGFHPBOIAMH[] LNCKNHNHHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3BC0", Offset = "0x6BE25C0", VA = "0x186BE3BC0")]
	private void GFKKODKFHIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6BE63A0", Offset = "0x6BE4DA0", VA = "0x186BE63A0")]
	private static void KHFJPPJEIKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6BE84D0", Offset = "0x6BE6ED0", VA = "0x186BE84D0")]
	public void MPODCPAANCB(CommandBuffer KIDNBOFHEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6BE21F0", Offset = "0x6BE0BF0", VA = "0x186BE21F0")]
	public void CMNMBBDFKIN([Optional] ScriptableRenderContext? MPOBGCPIOEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2960", Offset = "0x6BE1360", VA = "0x186BE2960")]
	public void DGDDPMLEAOH(CommandBuffer KIDNBOFHEDH, ShadowSplitData GCPBDJGMNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2C30", Offset = "0x6BE1630", VA = "0x186BE2C30")]
	public void DGDDPMLEAOH(CommandBuffer KIDNBOFHEDH, CameraData ADNHEBHJICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2420", Offset = "0x6BE0E20", VA = "0x186BE2420")]
	public void DFACMOJPBBL(CommandBuffer KIDNBOFHEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6BE88C0", Offset = "0x6BE72C0", VA = "0x186BE88C0")]
	public void NNPGELFOILK(CommandBuffer KIDNBOFHEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6FE0", Offset = "0x6BE59E0", VA = "0x186BE6FE0")]
	public void KIAENGEHKKC(CommandBuffer KIDNBOFHEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3590", Offset = "0x6BE1F90", VA = "0x186BE3590")]
	public void FOJPGBPJNCD(CommandBuffer KIDNBOFHEDH, OIBFOHGPJAP INOAGOLKLEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4530", Offset = "0x6BE2F30", VA = "0x186BE4530")]
	public void HEDNLNGDIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE75D0", Offset = "0x6BE5FD0", VA = "0x186BE75D0")]
	public void MOGENANDEFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2F10", Offset = "0x6BE1910", VA = "0x186BE2F10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class EOIPEDDFOEI
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x209E000", Offset = "0x209CA00", VA = "0x18209E000")]
	public static int FLNMAKGOMBF(int ELMEOKPKOPN, int NGMADPFNIIF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct MKNPMPJAHMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 GAJAHHKGLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 BCCFMLCPDAC;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly MKNPMPJAHMG OOFAPELGIKH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly MKNPMPJAHMG GOLLGDANENM;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x446E630", Offset = "0x446D030", VA = "0x18446E630")]
	public MKNPMPJAHMG(float4x4 GMEJGBFJAOK, float4 MGKCPGGPHHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6BEDA80", Offset = "0x6BEC480", VA = "0x186BEDA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct CBMONPGANMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 EJEBFMEPKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 MLNCIIKLLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 HLAFCKKNDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 LMANEKEBKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 NDCCPAPAPAN;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct PGJGHCLNADF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 EJEBFMEPKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 MLNCIIKLLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 HLAFCKKNDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 LMANEKEBKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 NDCCPAPAPAN;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct HMNCIFBLJNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public PGJGHCLNADF CKEPJKCINNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public PGJGHCLNADF EPLPNCIGKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public PGJGHCLNADF CMBKDDHCDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public PGJGHCLNADF KHOCHMDPMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public PGJGHCLNADF JDMHOBEJNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public PGJGHCLNADF KHDAFMIFPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public PGJGHCLNADF AFMAOCCGKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public PGJGHCLNADF AAGBKAGMPEF;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct MDIDDCHBKCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public CBMONPGANMF CKEPJKCINNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public CBMONPGANMF EPLPNCIGKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public CBMONPGANMF CMBKDDHCDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public CBMONPGANMF KHOCHMDPMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public CBMONPGANMF JDMHOBEJNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public CBMONPGANMF KHDAFMIFPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public CBMONPGANMF AFMAOCCGKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public CBMONPGANMF AAGBKAGMPEF;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct HLKGEMOBFNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 NIMMDIFAMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint HPFODGNOKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint DFOHIMDHCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float HOOBMODJOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint BHEAMCMLNJB;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6BEAD50", Offset = "0x6BE9750", VA = "0x186BEAD50")]
	public HLKGEMOBFNC(NMDMIIDOBCA PPFNGNPGEKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct PGPJLCNJGAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint MOKGMLLMKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint LNKJFPKLAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint GGOHDJBGEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint BHEAMCMLNJB;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6BF06D0", Offset = "0x6BEF0D0", VA = "0x186BF06D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct INAJELFMLFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint EBDHJDHNECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint DBIOOBHPEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint OCJJKCEPHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint BHEAMCMLNJB;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6BEB1C0", Offset = "0x6BE9BC0", VA = "0x186BEB1C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct DMNIPOFMLCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint PJGDMFFOLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint OMGFCEFKAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint PMIICEMNAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint NHLADPLMGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint JJHGAPHFPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint EGHBCPELPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint MAFLGPGKHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint BHEAMCMLNJB;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8FE0", Offset = "0x6BE79E0", VA = "0x186BE8FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct BMKPBEDAHIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 BIFMNJOHDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 JDFDIGHDGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 NONGENKOMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 FHDFGOGGAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 IDBKHKGHCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 OMFLPBCBNMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 AAGGBMOJFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 PAPKCNHBPML;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1880", Offset = "0x6BE0280", VA = "0x186BE1880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum OIBFOHGPJAP
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Opaque,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	DepthOnly,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Transparent,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Shadow
}
namespace Cpp2IlInjected
{
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
}
