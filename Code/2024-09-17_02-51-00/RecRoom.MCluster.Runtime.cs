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
public struct LDIHHDJFIIF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly int[] GDPNNHIDBEF;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static readonly uint[] HNOOHFFIJEG;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly string[] ANBGEPLJFJK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x16172F0", Offset = "0x1615CF0", VA = "0x1816172F0")]
	public static int ACFAFFEFAHC(GMBENFHCBOD CEEMGDGDBHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8910", Offset = "0x6CA7310", VA = "0x186CA8910")]
	public static int HFFIIJMNFFM(GMBENFHCBOD CEEMGDGDBHO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EKENLHCAPBD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int CIBGOOGHOAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CHKKEPPLFAL CCHDKKMCFLL(int CLOHFODGPFM);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Hash128 IEIANCELHGK(int CLOHFODGPFM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OLHIMCMANHM DMHODGHFLAG();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NBCIBJODIAO ALDHKLJKAHI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BKCLCHMHELJ : BJAEJBNIKGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private OLHIMCMANHM FLDLBOHKNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private Transform KCMFGLEMLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public List<IMJHKMDODKH> HADIHKNEADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private JEAOPLIOJJK GICEKNNCEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private CKDFIMAECCO LFMBHOEIBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool NEEHMPGEIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private EKENLHCAPBD OHDHGLLCMBF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public float JEEBKEAOLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9CB050", Offset = "0x9C9A50", VA = "0x1809CB050")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD09BF0", Offset = "0xD085F0", VA = "0x180D09BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JLDMDLBNMKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x91C960", Offset = "0x91B360", VA = "0x18091C960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x919910", Offset = "0x918310", VA = "0x180919910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OLFJONFGBFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCA8970", Offset = "0xCA7370", VA = "0x180CA8970")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xCA8960", Offset = "0xCA7360", VA = "0x180CA8960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OKKHPAEKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6332600", Offset = "0x6331000", VA = "0x186332600", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6332870", Offset = "0x6331270", VA = "0x186332870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool IKMHLKIBJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1760480", Offset = "0x175EE80", VA = "0x181760480", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DE90", Offset = "0x6C9C890", VA = "0x186C9DE90")]
	public BKCLCHMHELJ(EKENLHCAPBD ONLDJBALHME, bool MBAOCLEIABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DC70", Offset = "0x6C9C670", VA = "0x186C9DC70")]
	private bool MJDPFGPPMMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CC50", Offset = "0x6C9B650", VA = "0x186C9CC50", Slot = "4")]
	public bool FABNFHGMHGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C9D880", Offset = "0x6C9C280", VA = "0x186C9D880", Slot = "5")]
	public bool KOLHFLEMELG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DA50", Offset = "0x6C9C450", VA = "0x186C9DA50", Slot = "6")]
	public void MBEEDABKNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C9CC40", Offset = "0x6C9B640", VA = "0x186C9CC40", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PKOAPGBMPCO
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HPICGIAEOCG(CommandBuffer FMDCOJMFHLF);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OHFHAEPKOLL : PKOAPGBMPCO
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public readonly int OMPMKCIPJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F6230", Offset = "0x9F4C30", VA = "0x1809F6230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public readonly RenderTargetIdentifier DBJPCJDMJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x44B49C0", Offset = "0x44B33C0", VA = "0x1844B49C0")]
		[CompilerGenerated]
		get
		{
			return default(RenderTargetIdentifier);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6CABCE0", Offset = "0x6CAA6E0", VA = "0x186CABCE0")]
	public OHFHAEPKOLL(int MCAKFNPAKIL, RenderTargetIdentifier JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6CABC90", Offset = "0x6CAA690", VA = "0x186CABC90", Slot = "4")]
	public void HPICGIAEOCG(CommandBuffer FMDCOJMFHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct CNPLHLDPAHH : PKOAPGBMPCO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public readonly int OMPMKCIPJEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6230", Offset = "0x9F4C30", VA = "0x1809F6230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public readonly Vector4[] NHGKLHJMENH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xB0FDE0", Offset = "0xB0E7E0", VA = "0x180B0FDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1012BB0", Offset = "0x10115B0", VA = "0x181012BB0")]
	public CNPLHLDPAHH(int MCAKFNPAKIL, Vector4[] JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5150", Offset = "0x6CA3B50", VA = "0x186CA5150", Slot = "4")]
	public void HPICGIAEOCG(CommandBuffer FMDCOJMFHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct AKICNIJIIMC : PKOAPGBMPCO
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public readonly int OMPMKCIPJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F6230", Offset = "0x9F4C30", VA = "0x1809F6230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public readonly float[] GGAEJOCHPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB0FDE0", Offset = "0xB0E7E0", VA = "0x180B0FDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1012BB0", Offset = "0x10115B0", VA = "0x181012BB0")]
	public AKICNIJIIMC(int MCAKFNPAKIL, float[] JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C9BD70", Offset = "0x6C9A770", VA = "0x186C9BD70", Slot = "4")]
	public void HPICGIAEOCG(CommandBuffer FMDCOJMFHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PHCKOHFAJLK : PKOAPGBMPCO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public readonly string FHACOBMPENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9810C0", Offset = "0x97FAC0", VA = "0x1809810C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public readonly bool GCCFAKHHEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1F46400", Offset = "0x1F44E00", VA = "0x181F46400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x44B6DF0", Offset = "0x44B57F0", VA = "0x1844B6DF0")]
	public PHCKOHFAJLK(string KJPHMNNIMDP, bool GCKGFMHINMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6CABDB0", Offset = "0x6CAA7B0", VA = "0x186CABDB0", Slot = "4")]
	public void HPICGIAEOCG(CommandBuffer FMDCOJMFHLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct NBCIBJODIAO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public Hash128 GBCNLCPMDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xC4C960", Offset = "0xC4B360", VA = "0x180C4C960")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float4 GJOFGIOBKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA13B20", Offset = "0xA12520", VA = "0x180A13B20")]
		[CompilerGenerated]
		get
		{
			return default(float4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int FOKHPPGBEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x941880", Offset = "0x940280", VA = "0x180941880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int OMPNCHEDFCC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8D79A0", Offset = "0x8D63A0", VA = "0x1808D79A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MDJCIBNDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9CB070", Offset = "0x9C9A70", VA = "0x1809CB070")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB340", Offset = "0x6CA9D40", VA = "0x186CAB340")]
	public NBCIBJODIAO(Color FEHNKBJAMFH, int DCOBFDGAPAO, int NMEBIIGAMHK, float EIFPFALHLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0xB919C0", Offset = "0xB903C0", VA = "0x180B919C0")]
	private static float4 OFIODEHJFLO(Color FEHNKBJAMFH)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB2B0", Offset = "0x6CA9CB0", VA = "0x186CAB2B0")]
	private static Hash128 BMHPLJNKKPJ(NBCIBJODIAO ONLDJBALHME)
	{
		return default(Hash128);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JEAOPLIOJJK : BJAEJBNIKGF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly string ILHIGPMLMMH;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly string EOKJKACEKLE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static readonly string IAPIFIIGAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NBCIBJODIAO EGGIGKBPGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private IMFFDCLGLDH KFGOIEOLDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Hash128 DANNMGEGNHF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public CKDFIMAECCO IPIJCIBCILB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8BF000", Offset = "0x8BDA00", VA = "0x1808BF000")]
		[CompilerGenerated]
		get
		{
			return default(CKDFIMAECCO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD1D7C0", Offset = "0xD1C1C0", VA = "0x180D1D7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool JLDMDLBNMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5CAAA90", Offset = "0x5CA9490", VA = "0x185CAAA90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5CAAAA0", Offset = "0x5CA94A0", VA = "0x185CAAAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool OLFJONFGBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x20C76B0", Offset = "0x20C60B0", VA = "0x1820C76B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C34D10", Offset = "0x6C33710", VA = "0x186C34D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IKMHLKIBJGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool OKKHPAEKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5D60B50", Offset = "0x5D5F550", VA = "0x185D60B50", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7FA0", Offset = "0x6CA69A0", VA = "0x186CA7FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public int OAGDGHBELJN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6CA7DC0", Offset = "0x6CA67C0", VA = "0x186CA7DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8440", Offset = "0x6CA6E40", VA = "0x186CA8440")]
	public JEAOPLIOJJK(NBCIBJODIAO DNJCIEHPMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8260", Offset = "0x6CA6C60", VA = "0x186CA8260")]
	private bool MJDPFGPPMMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7E10", Offset = "0x6CA6810", VA = "0x186CA7E10", Slot = "4")]
	public bool FABNFHGMHGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7F60", Offset = "0x6CA6960", VA = "0x186CA7F60")]
	private static IMFFDCLGLDH GDNJJBFIHBH(NBCIBJODIAO ONLDJBALHME)
	{
		return default(IMFFDCLGLDH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7FB0", Offset = "0x6CA69B0", VA = "0x186CA7FB0", Slot = "5")]
	public bool KOLHFLEMELG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8160", Offset = "0x6CA6B60", VA = "0x186CA8160", Slot = "6")]
	public void MBEEDABKNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
			public ShaderResources()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ShaderResources Shaders;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA3C0", Offset = "0x6CA8DC0", VA = "0x186CAA3C0", Slot = "0")]
		public override bool Equals(object PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA5C0", Offset = "0x6CA8FC0", VA = "0x186CAA5C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9A74A0", Offset = "0x9A5EA0", VA = "0x1809A74A0")]
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
		private NDIPFNDMAGD opaquePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		public MClusterData Data;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static CNKNKDOMMBO CurrentRenderPipeline
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6CAAC80", Offset = "0x6CA9680", VA = "0x186CAAC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6CAACC0", Offset = "0x6CA96C0", VA = "0x186CAACC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA6A0", Offset = "0x6CA90A0", VA = "0x186CAA6A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6CAA670", Offset = "0x6CA9070", VA = "0x186CAA670", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6CAAAF0", Offset = "0x6CA94F0", VA = "0x186CAAAF0")]
		public void NDGFIFLJNKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x10246E0", Offset = "0x10230E0", VA = "0x1810246E0")]
		public MClusterRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GDGMHCLBHCP<ValType> : IDisposable where ValType : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private FLNHMIPGDMB JGAKHMGFAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private FLNHMIPGDMB NPOHJJNBKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private ComputeBuffer EJNCADMMFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private RenderTexture PMKKNOINBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int FBLMIEJOLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int DFCKFKOBALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private string KEPPLGAJPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private string DPDNOLMHIOG;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8A64C0", Offset = "0x8A4EC0", VA = "0x1808A64C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int CFAABGANIMA
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x941890", Offset = "0x940290", VA = "0x180941890")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int OIGKLPNCHEI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8B58D0", Offset = "0x8B42D0", VA = "0x1808B58D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3EB1970", Offset = "0x3EB0370", VA = "0x183EB1970")]
	public GDGMHCLBHCP(string KJPHMNNIMDP, int PNPMHEEGHFM, [Optional] RenderTextureFormat? OJCKNPDLJJF, bool KMFNKIOKIPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3EAFBB0", Offset = "0x3EAE5B0", VA = "0x183EAFBB0")]
	public void KOLHFLEMELG(CommandBuffer FMDCOJMFHLF, NativeArray<ValType> JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3EAF010", Offset = "0x3EADA10", VA = "0x183EAF010")]
	public void GOHMKFMJHOE(CommandBuffer FMDCOJMFHLF, ComputeShader CAFFIBDJPDJ, int LGMMFLEJJBD, int JOBPAPDJCHC = -1, int IHDPEPACELD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE6E0", Offset = "0x3EAD0E0", VA = "0x183EAE6E0")]
	public void GOHMKFMJHOE(Material KFGOIEOLDHF, int JOBPAPDJCHC = -1, int IHDPEPACELD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE190", Offset = "0x3EACB90", VA = "0x183EAE190", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PHEMCBFLHGK
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOHMKFMJHOE(Material DNJCIEHPMCF);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DFMLFBJLEIC<SrcEntry, DstEntry> : PHEMCBFLHGK, IDisposable where SrcEntry : struct where DstEntry : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	protected bool[] HHLBENLIBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	protected FLNHMIPGDMB NLOGDCILJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	protected FLNHMIPGDMB LHKNODFJGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	protected NativeArray<int> FLOLFIEGMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	protected NativeArray<SrcEntry> KPAHLCFBLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	protected int CJFPKBPEHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	protected int OGAOIAFBMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	protected GDGMHCLBHCP<int> LDIDHEGILJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	protected GDGMHCLBHCP<SrcEntry> CLKLFNBPMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	protected GDGMHCLBHCP<DstEntry> KKGPCDKOAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	protected ComputeShader EKIHGKHOJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	protected int JPKHHJPJDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	protected int ACBLFHNGOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	protected int LLHDOEKBPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	protected int NADGJOJJEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	protected int JPMCFHNICBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	protected int BFBLBMNMPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	protected int MABFBAGGFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	protected int HLBOHPNCJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	protected int IBFIIJHEKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	protected int KBCAMIMGMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected int OIAPDILHLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected int GBIHBDNFIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	protected string HFILOGDCPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected float[] KEEMAIDBFOD;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JKEHIMLHIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5B34A60", Offset = "0x5B33460", VA = "0x185B34A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string NHNKLCLNHAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5B378C0", Offset = "0x5B362C0", VA = "0x185B378C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5B3A6A0", Offset = "0x5B390A0", VA = "0x185B3A6A0")]
	public DFMLFBJLEIC(string KJPHMNNIMDP, int ICLJOJMKBJK, int JIJODOLNGLO, RenderTextureFormat OJCKNPDLJJF, ComputeShader PELONBKJJAI, int DJDLFENCFNB = 0, int GOGEEPGJNJB = 0, int EAEPCICKDJP = 0, int CPCILIBIANJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5B38400", Offset = "0x5B36E00", VA = "0x185B38400")]
	public int KIIOFBCGLJD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5B370B0", Offset = "0x5B35AB0", VA = "0x185B370B0")]
	protected void FJOAMPOPBPM(int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5B36940", Offset = "0x5B35340", VA = "0x185B36940")]
	public CKDFIMAECCO FABNFHGMHGJ(SrcEntry JGCMECODHDI)
	{
		return default(CKDFIMAECCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5B38630", Offset = "0x5B37030", VA = "0x185B38630")]
	public bool KOLHFLEMELG(CKDFIMAECCO GPPOCIDKPII, SrcEntry JGCMECODHDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5B39220", Offset = "0x5B37C20", VA = "0x185B39220")]
	public bool MBEEDABKNGP(CKDFIMAECCO GPPOCIDKPII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "6")]
	protected virtual void OKMAJNIDIOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5B34A70", Offset = "0x5B33470", VA = "0x185B34A70", Slot = "7")]
	public void DJBPGJHLJCM(CommandBuffer FMDCOJMFHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5B351B0", Offset = "0x5B33BB0", VA = "0x185B351B0", Slot = "8")]
	public void DJBPGJHLJCM(CommandBuffer FMDCOJMFHLF, ComputeShader PELONBKJJAI, int DJDLFENCFNB = -1, int GOGEEPGJNJB = -1, int EAEPCICKDJP = -1, int CPCILIBIANJ = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5B37170", Offset = "0x5B35B70", VA = "0x185B37170", Slot = "9")]
	public void GOHMKFMJHOE(CommandBuffer FMDCOJMFHLF, ComputeShader PELONBKJJAI, int DJDLFENCFNB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5B37100", Offset = "0x5B35B00", VA = "0x185B37100", Slot = "4")]
	public void GOHMKFMJHOE(Material KFGOIEOLDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5B364C0", Offset = "0x5B34EC0", VA = "0x185B364C0", Slot = "10")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FLNHMIPGDMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ulong IPLJHIKMCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	ulong COBMMJNPFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class APMMFKPFDMK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct DHNBMGNOJFC : FLNHMIPGDMB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private IDisposable GOEOMDMENPE;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ulong IPLJHIKMCFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xB0FDE0", Offset = "0xB0E7E0", VA = "0x180B0FDE0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xBBBF80", Offset = "0xBBA980", VA = "0x180BBBF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public ulong COBMMJNPFLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x911D70", Offset = "0x910770", VA = "0x180911D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4F76C10", Offset = "0x4F75610", VA = "0x184F76C10")]
		internal DHNBMGNOJFC(IDisposable JBLLBPPKIKC, ulong ALOEPOFLMEO, ulong AEFPKDGPDJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5180", Offset = "0x6CA3B80", VA = "0x186CA5180", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct FOMGOOBAOAD : FLNHMIPGDMB, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private RenderTexture NLJNFEPLKML;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public ulong IPLJHIKMCFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xB0FDE0", Offset = "0xB0E7E0", VA = "0x180B0FDE0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xBBBF80", Offset = "0xBBA980", VA = "0x180BBBF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public ulong COBMMJNPFLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "5")]
			[CompilerGenerated]
			readonly get
			{
				return default(ulong);
			}
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x911D70", Offset = "0x910770", VA = "0x180911D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6CA54B0", Offset = "0x6CA3EB0", VA = "0x186CA54B0")]
		public FOMGOOBAOAD(RenderTexture AKFEKCILDGA, ulong DLDGJBNMMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5410", Offset = "0x6CA3E10", VA = "0x186CA5410", Slot = "6")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static ulong IGJBDOEEOMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C9D0", Offset = "0x6C9B3D0", VA = "0x186C9C9D0")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C990", Offset = "0x6C9B390", VA = "0x186C9C990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static ulong PHHNGPBEBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C9C950", Offset = "0x6C9B350", VA = "0x186C9C950")]
		[CompilerGenerated]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C9CA10", Offset = "0x6C9B410", VA = "0x186C9CA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C3F0", Offset = "0x6C9ADF0", VA = "0x186C9C3F0")]
	public static ComputeBuffer GMDNOGMNFLF(int FIGHABPEBPG, int BMBNBBMBCJN, ComputeBufferType JLAAKHANEHC, [Out] FLNHMIPGDMB GPPOCIDKPII, ComputeBufferMode COEMAIGHGPP = ComputeBufferMode.Immutable)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C5C0", Offset = "0x6C9AFC0", VA = "0x186C9C5C0")]
	public static RenderTexture GMDNOGMNFLF(int BNIDPDGADNN, int LGAIJEFLCNP, int EIIIOBOAFAN, RenderTextureFormat OJCKNPDLJJF, [Out] FLNHMIPGDMB GPPOCIDKPII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x344F5E0", Offset = "0x344DFE0", VA = "0x18344F5E0")]
	public static NativeArray<T> LAECEIBOBCL<T>(NativeArray<T> GOEOMDMENPE, ulong KHMKAEGDPPG, [Out] FLNHMIPGDMB GPPOCIDKPII) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x344F520", Offset = "0x344DF20", VA = "0x18344F520")]
	public static NativeArray<T> GMDNOGMNFLF<T>(int KHMKAEGDPPG, Allocator NPNPKHEIOHB, [Out] FLNHMIPGDMB GPPOCIDKPII, NativeArrayOptions CLJCAFMAPFP = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C1A0", Offset = "0x6C9ABA0", VA = "0x186C9C1A0")]
	public static void AGDCKPANMGG(FLNHMIPGDMB GOEOMDMENPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C9C2F0", Offset = "0x6C9ACF0", VA = "0x186C9C2F0")]
	public static uint CCMMOMNKAJN(RenderTextureFormat OJCKNPDLJJF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GIKBPKMAMPJ : DFMLFBJLEIC<BLMDLAHCMDI, BLMDLAHCMDI>
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[BurstCompile]
	public struct BDKDHCFMLEI : IJobParallelForTransform
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[ReadOnly]
		private NativeArray<int> OPLABAKGPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[ReadOnly]
		private NativeArray<float> LKNINIEJDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[WriteOnly]
		private NativeArray<float4x4> FEJBJIBMBMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[WriteOnly]
		private NativeArray<float4> PJONHCLGJIK;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C9CC10", Offset = "0x6C9B610", VA = "0x186C9CC10")]
		public BDKDHCFMLEI(NativeArray<int> BJJNPCGPHFA, NativeArray<float> AMAMMOFONHJ, NativeArray<float4x4> NDNGPNNBCBJ, NativeArray<float4> GHONHHONMNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6C9CA50", Offset = "0x6C9B450", VA = "0x186C9CA50", Slot = "4")]
		public void Execute(int HGFDMIDEFHN, TransformAccess FLDLBOHKNDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[BurstCompile]
	public struct LJMHNDDCOBH : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[ReadOnly]
		private NativeArray<int> OPLABAKGPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[ReadOnly]
		private NativeArray<float4x4> IBKPEEDDDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[ReadOnly]
		private NativeArray<float4> PNHMHOMJLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[WriteOnly]
		private NativeArray<BLMDLAHCMDI> BFHPHLHILGE;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C9CC10", Offset = "0x6C9B610", VA = "0x186C9CC10")]
		public LJMHNDDCOBH(NativeArray<int> BJJNPCGPHFA, NativeArray<float4x4> HCHHEHEFEFE, NativeArray<float4> DNPPHOGMOAJ, NativeArray<BLMDLAHCMDI> JPCKHGMDGNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9070", Offset = "0x6CA7A70", VA = "0x186CA9070", Slot = "4")]
		public void Execute(int HGFDMIDEFHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private const byte NLJKINJBFNP = byte.MaxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private TransformAccessArray KMBMPPPLEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<float> OABEPFEDPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float4x4> FPNHDAMHKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<float4> EDDLAIHFLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> BKCLEPFAAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<int> JFFMLKHMBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private FLNHMIPGDMB AOHDHDBEGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private FLNHMIPGDMB NPIBBKJLMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private FLNHMIPGDMB AIAAFPJALIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private FLNHMIPGDMB OICMNGCHHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private FLNHMIPGDMB BMJHHEOBPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private Transform KCIPGKHGECE;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5B30", Offset = "0x6CA4530", VA = "0x186CA5B30")]
	public GIKBPKMAMPJ(int ICLJOJMKBJK, int JIJODOLNGLO, ComputeShader PELONBKJJAI, int DJDLFENCFNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5930", Offset = "0x6CA4330", VA = "0x186CA5930", Slot = "6")]
	protected override void OKMAJNIDIOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5710", Offset = "0x6CA4110", VA = "0x186CA5710")]
	private void KDNFDAKOBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA57D0", Offset = "0x6CA41D0", VA = "0x186CA57D0")]
	public bool OJMMKIAMFCA(CKDFIMAECCO GPPOCIDKPII, Transform FLDLBOHKNDN, float NJMFEKLNLEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5630", Offset = "0x6CA4030", VA = "0x186CA5630")]
	public void JEIEJGMGIKB(CKDFIMAECCO GPPOCIDKPII, float NJMFEKLNLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5580", Offset = "0x6CA3F80", VA = "0x186CA5580")]
	public void GNONDGJDAKK(CKDFIMAECCO GPPOCIDKPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6CA54E0", Offset = "0x6CA3EE0", VA = "0x186CA54E0", Slot = "10")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface CHKKEPPLFAL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JOIDBGKONGK IKFNBHIKIAK();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface NOILJNDMGMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	Hash128 GBCNLCPMDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	NativeArray<float3> EHFBMINIGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NativeArray<float3> CNEDOCPBIID
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	NativeArray<float4> AFFNGGFFNEK
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	NativeArray<int> LJJHHOHHKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NativeArray<float2> BKGOPMNLPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	NativeArray<float4> ICPCEJKMGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	int NAOFJKPIAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	int JOPKFKKFCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	int HGFEOBMADLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool FJHILPNNHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DJBPGJHLJCM();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NNENGJEOFGC : NOILJNDMGMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private CHKKEPPLFAL JAACKCKOBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private JOIDBGKONGK CBNKKMIFMKD;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Hash128 GBCNLCPMDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA13B20", Offset = "0xA12520", VA = "0x180A13B20", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Hash128);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA13970", Offset = "0xA12370", VA = "0x180A13970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private bool ODLEDFAKBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x899990", Offset = "0x898390", VA = "0x180899990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8D79A0", Offset = "0x8D63A0", VA = "0x1808D79A0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8D70B0", Offset = "0x8D5AB0", VA = "0x1808D70B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x898FD0", Offset = "0x8979D0", VA = "0x180898FD0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x899000", Offset = "0x897A00", VA = "0x180899000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	private int ELIJNMLLLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xDC10A0", Offset = "0xDBFAA0", VA = "0x180DC10A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeArray<float3> EHFBMINIGFL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6CABB60", Offset = "0x6CAA560", VA = "0x186CABB60", Slot = "7")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeArray<float3> CNEDOCPBIID
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6CABB20", Offset = "0x6CAA520", VA = "0x186CABB20", Slot = "8")]
		get
		{
			return default(NativeArray<float3>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeArray<float4> AFFNGGFFNEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB8B0", Offset = "0x6CAA2B0", VA = "0x186CAB8B0", Slot = "9")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public NativeArray<int> LJJHHOHHKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6CABBD0", Offset = "0x6CAA5D0", VA = "0x186CABBD0", Slot = "10")]
		get
		{
			return default(NativeArray<int>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NativeArray<float2> BKGOPMNLPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6CABAA0", Offset = "0x6CAA4A0", VA = "0x186CABAA0", Slot = "11")]
		get
		{
			return default(NativeArray<float2>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NativeArray<float4> ICPCEJKMGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6CABAD0", Offset = "0x6CAA4D0", VA = "0x186CABAD0", Slot = "12")]
		get
		{
			return default(NativeArray<float4>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool FJHILPNNHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xC46710", Offset = "0xC45110", VA = "0x180C46710", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xD234D0", Offset = "0xD21ED0", VA = "0x180D234D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int NAOFJKPIAID
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6CABB50", Offset = "0x6CAA550", VA = "0x186CABB50", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int JOPKFKKFCJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6CAB8E0", Offset = "0x6CAA2E0", VA = "0x186CAB8E0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int HGFEOBMADLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6CABB00", Offset = "0x6CAA500", VA = "0x186CABB00", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6CABC40", Offset = "0x6CAA640", VA = "0x186CABC40")]
	public NNENGJEOFGC(Hash128 DOAOBIHCNJF, CHKKEPPLFAL JAACKCKOBGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB900", Offset = "0x6CAA300", VA = "0x186CAB900", Slot = "16")]
	public void DJBPGJHLJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6CABA10", Offset = "0x6CAA410", VA = "0x186CABA10", Slot = "18")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct CKDFIMAECCO : IEquatable<CKDFIMAECCO>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly CKDFIMAECCO PFLMBFLCPLB;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public readonly int OAGDGHBELJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F6230", Offset = "0x9F4C30", VA = "0x1809F6230")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
	public CKDFIMAECCO(int HGFDMIDEFHN = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E0B0", Offset = "0x6C9CAB0", VA = "0x186C9E0B0", Slot = "4")]
	public bool Equals(CKDFIMAECCO PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E100", Offset = "0x6C9CB00", VA = "0x186C9E100", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E1D0", Offset = "0x6C9CBD0", VA = "0x186C9E1D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class IMJHKMDODKH : BJAEJBNIKGF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private bool NEEHMPGEIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NOILJNDMGMN CLBMCMCIFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private List<CKDFIMAECCO> JINIGBPNEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private List<CKDFIMAECCO> HAEHALOIHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<CKDFIMAECCO> DHMILIJAPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<int, uint> JHLIDLDPKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private int KNHJBDAHGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private int EHANMNGLAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private int OMEIAPEENCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private int NNMOGKPPMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private int IHJGKLENFPL;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int OAGDGHBELJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6040", Offset = "0x6CA4A40", VA = "0x186CA6040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6CA6000", Offset = "0x6CA4A00", VA = "0x186CA6000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool JLDMDLBNMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x923890", Offset = "0x922290", VA = "0x180923890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x923B70", Offset = "0x922570", VA = "0x180923B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool OLFJONFGBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xDDDD60", Offset = "0xDDC760", VA = "0x180DDDD60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xDDDCC0", Offset = "0xDDC6C0", VA = "0x180DDDCC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool IKMHLKIBJGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool OKKHPAEKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4D65470", Offset = "0x4D63E70", VA = "0x184D65470", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1D05260", Offset = "0x1D03C60", VA = "0x181D05260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public float JEEBKEAOLHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9A44A0", Offset = "0x9A2EA0", VA = "0x1809A44A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9A4490", Offset = "0x9A2E90", VA = "0x1809A4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7C50", Offset = "0x6CA6650", VA = "0x186CA7C50")]
	public IMJHKMDODKH(NOILJNDMGMN CBNKKMIFMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6B30", Offset = "0x6CA5530", VA = "0x186CA6B30")]
	private void IIJIDJLDIPB(NOILJNDMGMN CBNKKMIFMKD, int KNHJBDAHGAE, int JDNDIJJOBPL, int HGFDMIDEFHN, int MNBGKMOCBGA, IHIKFIPPNLM JGCMECODHDI, float JELHHEKFEDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7980", Offset = "0x6CA6380", VA = "0x186CA7980")]
	private void NCFOJDPLCPI(NOILJNDMGMN CBNKKMIFMKD, int NCNJEGEHCPD, int HGFDMIDEFHN, uint3 ICBGFDHKPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA76E0", Offset = "0x6CA60E0", VA = "0x186CA76E0")]
	private bool MJDPFGPPMMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6CA6150", Offset = "0x6CA4B50", VA = "0x186CA6150", Slot = "4")]
	public bool FABNFHGMHGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7010", Offset = "0x6CA5A10", VA = "0x186CA7010", Slot = "5")]
	public bool KOLHFLEMELG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA7090", Offset = "0x6CA5A90", VA = "0x186CA7090", Slot = "6")]
	public void MBEEDABKNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA60F0", Offset = "0x6CA4AF0", VA = "0x186CA60F0")]
	public void FOBKJGKMLBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA60F0", Offset = "0x6CA4AF0", VA = "0x186CA60F0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface BJAEJBNIKGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool IKMHLKIBJGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool OKKHPAEKBNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FABNFHGMHGJ();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KOLHFLEMELG();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBEEDABKNGP();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LONIJONKHAK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static readonly float MCKPBBPFNLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<Hash128, IMJHKMDODKH> JKEADNDBHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<Hash128, JEAOPLIOJJK> JOLGGLNLEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Queue<BJAEJBNIKGF> KALFNDELJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Queue<BJAEJBNIKGF> CIBMHCANGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Queue<BJAEJBNIKGF> ABHKAHOBPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private int LMKGNHOFMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private int MFOFIAONOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private float OAMOGMFNDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool BILHLHFBMBP;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool MMMCCHPALMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1048F30", Offset = "0x1047930", VA = "0x181048F30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1063260", Offset = "0x1061C60", VA = "0x181063260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool IAEJPFLCJFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6CA96F0", Offset = "0x6CA80F0", VA = "0x186CA96F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string NHNKLCLNHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6CA9740", Offset = "0x6CA8140", VA = "0x186CA9740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA1E0", Offset = "0x6CA8BE0", VA = "0x186CAA1E0")]
	public void PGPJFFNLLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA95D0", Offset = "0x6CA7FD0", VA = "0x186CA95D0")]
	public void DPLBJLBKDGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA230", Offset = "0x6CA8C30", VA = "0x186CAA230")]
	public LONIJONKHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9D40", Offset = "0x6CA8740", VA = "0x186CA9D40")]
	public BKCLCHMHELJ JJJMHPMEAIK(EKENLHCAPBD NFEPGHCPILM, bool MBAOCLEIABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9C00", Offset = "0x6CA8600", VA = "0x186CA9C00")]
	public JEAOPLIOJJK JJJMHPMEAIK(NBCIBJODIAO KFGOIEOLDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9B90", Offset = "0x6CA8590", VA = "0x186CA9B90")]
	public bool JFEHPGDJPKM(Hash128 MCAKFNPAKIL, [Out] IMJHKMDODKH JANLKGKOMAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9E70", Offset = "0x6CA8870", VA = "0x186CA9E70")]
	public IMJHKMDODKH JJJMHPMEAIK(NOILJNDMGMN CBNKKMIFMKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CA90E0", Offset = "0x6CA7AE0", VA = "0x186CA90E0")]
	private void BOFKIAKADKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6CAA160", Offset = "0x6CA8B60", VA = "0x186CAA160")]
	private bool KLGNLJLBKCC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9100", Offset = "0x6CA7B00", VA = "0x186CA9100")]
	public void DJBPGJHLJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6CA95E0", Offset = "0x6CA7FE0", VA = "0x186CA95E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6CA9AE0", Offset = "0x6CA84E0", VA = "0x186CA9AE0")]
	public void ILGPEBACAAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FNONIHJONJJ : DFMLFBJLEIC<JGCGPKJEFDJ, JGCGPKJEFDJ>
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5360", Offset = "0x6CA3D60", VA = "0x186CA5360")]
	public FNONIHJONJJ(int ICLJOJMKBJK, int JIJODOLNGLO, ComputeShader PELONBKJJAI, int DJDLFENCFNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KILAMKNHFKI : DFMLFBJLEIC<IMFFDCLGLDH, IMFFDCLGLDH>
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8860", Offset = "0x6CA7260", VA = "0x186CA8860")]
	public KILAMKNHFKI(int ICLJOJMKBJK, int JIJODOLNGLO, ComputeShader PELONBKJJAI, int DJDLFENCFNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DJIDPGKFGDJ : DFMLFBJLEIC<PDLNOLBEGKC, PDLNOLBEGKC>
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5200", Offset = "0x6CA3C00", VA = "0x186CA5200")]
	public DJIDPGKFGDJ(int ICLJOJMKBJK, int JIJODOLNGLO, ComputeShader PELONBKJJAI, int DJDLFENCFNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class LJEJGEHEPDB : DFMLFBJLEIC<AIIHFIIOJFI, JDNKBIOFJDG>
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8FC0", Offset = "0x6CA79C0", VA = "0x186CA8FC0")]
	public LJEJGEHEPDB(int ICLJOJMKBJK, int JIJODOLNGLO, ComputeShader PELONBKJJAI, int DJDLFENCFNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ENPKFMKMADO : DFMLFBJLEIC<APJJGKPODMD, APJJGKPODMD>
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6CA52B0", Offset = "0x6CA3CB0", VA = "0x186CA52B0")]
	public ENPKFMKMADO(int ICLJOJMKBJK, int JIJODOLNGLO, ComputeShader PELONBKJJAI, int DJDLFENCFNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class NDIPFNDMAGD : ScriptableRenderPass
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private CNKNKDOMMBO KIMAADJHFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool GCKGFMHINMG;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public static bool ENEADCDANFG;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB870", Offset = "0x6CAA270", VA = "0x186CAB870")]
	public NDIPFNDMAGD(CNKNKDOMMBO INILLBOGABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB6E0", Offset = "0x6CAA0E0", VA = "0x186CAB6E0", Slot = "5")]
	public override void OnCameraSetup(CommandBuffer FMDCOJMFHLF, RenderingData JLJFGIMLKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB470", Offset = "0x6CA9E70", VA = "0x186CAB470", Slot = "6")]
	public override void Configure(CommandBuffer FMDCOJMFHLF, RenderTextureDescriptor HLLDBKGIPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB4B0", Offset = "0x6CA9EB0", VA = "0x186CAB4B0", Slot = "9")]
	public override void Execute(ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class MNACCDGAFFD
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct HMKKAABCDEP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly string KJPHMNNIMDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly CommandBuffer FMDCOJMFHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ScriptableRenderContext EIGKPCONJCB;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5EC0", Offset = "0x6CA48C0", VA = "0x186CA5EC0")]
		public HMKKAABCDEP(string NCNMEEGKIBN, ScriptableRenderContext OOCEAHIFBDI, [Out] CommandBuffer DCICDAKFEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6CA5E10", Offset = "0x6CA4810", VA = "0x186CA5E10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAF30", Offset = "0x6CA9930", VA = "0x186CAAF30")]
	public static bool CNIHCOBJKMG(RenderingData JLJFGIMLKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6CAAD90", Offset = "0x6CA9790", VA = "0x186CAAD90")]
	public static void CJNIEMAFABN(CommandBuffer FMDCOJMFHLF, ScriptableRenderContext EIGKPCONJCB, ShadowDrawingSettings HDGFLAHCMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6CAB080", Offset = "0x6CA9A80", VA = "0x186CAB080")]
	public static void JGEHIPMOFNP(CommandBuffer FMDCOJMFHLF, ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CNKNKDOMMBO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class MIIIBEMKELI
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static readonly int NHMFHLPDKGA;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static readonly int EOOOADICBAC;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static GDGMHCLBHCP<KDANFDMOPEB> CGOBADBFKON;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private static GDGMHCLBHCP<uint> NLOBHKLMFHM;

	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private static FLNHMIPGDMB CIEDAAANDEH;

	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private static ComputeBuffer IGACMBIDHJG;

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static List<PHEMCBFLHGK> EKGONIKENML;

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static int MCFMMJMJOIO;

	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private static int GPFPHLKHLPH;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private static int ONENLICOMKK;

	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private static int NEOIIPDHIHN;

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private static int[] FCPELLLJEEM;

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static Material[] KKKKADLPGFH;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static PKOAPGBMPCO[][] BCCFPJCLEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Plane[] BLCGCGAECEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private int FHOGGKLEFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private int LBEFNPAHMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private int MCKDAPDLHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private int HOPMLPBKPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int MOIBGPDDDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private int MHMDBNGKDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private int DNHEIJFAFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int AIGNCABLNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int ICHLLMOMMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int FFEJPOBCFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private int CIJCGNALAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private int ACKFMEABNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int CMMDNGBDNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int IGHPGJAMPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int ANIIOPBDBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private int GOCEOGKEPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private int JMBLMKKNEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int ANCJHFPPHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private float[] JPCBHOPPHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private LONIJONKHAK HBEKODCDHPD;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public static bool HMCJPKEMNMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3C90", Offset = "0x6CA2690", VA = "0x186CA3C90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6CA13B0", Offset = "0x6C9FDB0", VA = "0x186CA13B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static bool NGMMFCIJEFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6CA04F0", Offset = "0x6C9EEF0", VA = "0x186CA04F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1300", Offset = "0x6C9FD00", VA = "0x186CA1300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public static MClusterData MJHCHFCOEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2340", Offset = "0x6CA0D40", VA = "0x186CA2340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4AF0", Offset = "0x6CA34F0", VA = "0x186CA4AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static GIKBPKMAMPJ DPOLLMIIOLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4BB0", Offset = "0x6CA35B0", VA = "0x186CA4BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3B40", Offset = "0x6CA2540", VA = "0x186CA3B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public static FNONIHJONJJ NLIKKGMHELB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1AC0", Offset = "0x6CA04C0", VA = "0x186CA1AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0C40", Offset = "0x6C9F640", VA = "0x186CA0C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public static KILAMKNHFKI CHHPOEOCDKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6CA34E0", Offset = "0x6CA1EE0", VA = "0x186CA34E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6CA09C0", Offset = "0x6C9F3C0", VA = "0x186CA09C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public static DJIDPGKFGDJ NFLPHLDJMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0A30", Offset = "0x6C9F430", VA = "0x186CA0A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6CA19F0", Offset = "0x6CA03F0", VA = "0x186CA19F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static LJEJGEHEPDB ILNKGGDBPDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1B10", Offset = "0x6CA0510", VA = "0x186CA1B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4D50", Offset = "0x6CA3750", VA = "0x186CA4D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public static ENPKFMKMADO IPIHBGLNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6CA2FD0", Offset = "0x6CA19D0", VA = "0x186CA2FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1B60", Offset = "0x6CA0560", VA = "0x186CA1B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public static Material GELLKPCGBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4B60", Offset = "0x6CA3560", VA = "0x186CA4B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3A10", Offset = "0x6CA2410", VA = "0x186CA3A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static Material LMPPNBPNMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1BD0", Offset = "0x6CA05D0", VA = "0x186CA1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3AD0", Offset = "0x6CA24D0", VA = "0x186CA3AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public static Material NKLBAJLOCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6CA3490", Offset = "0x6CA1E90", VA = "0x186CA3490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6CA22D0", Offset = "0x6CA0CD0", VA = "0x186CA22D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public static Material KIKNOMNANBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1360", Offset = "0x6C9FD60", VA = "0x186CA1360")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6CA4CE0", Offset = "0x6CA36E0", VA = "0x186CA4CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public static bool CCDOOHHMBKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0BF0", Offset = "0x6C9F5F0", VA = "0x186CA0BF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6CA0A80", Offset = "0x6C9F480", VA = "0x186CA0A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool IAEJPFLCJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1A60", Offset = "0x6CA0460", VA = "0x186CA1A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string NHNKLCLNHAA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6CA1C20", Offset = "0x6CA0620", VA = "0x186CA1C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4EF0", Offset = "0x6CA38F0", VA = "0x186CA4EF0")]
	internal CNKNKDOMMBO([Optional] MClusterData OIGCFCOPMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C9F160", Offset = "0x6C9DB60", VA = "0x186C9F160")]
	public void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4DC0", Offset = "0x6CA37C0", VA = "0x186CA4DC0")]
	public void PONKPMPFDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4210", Offset = "0x6CA2C10", VA = "0x186CA4210")]
	public void NJEAPLMNIAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1260", Offset = "0x6C9FC60", VA = "0x186CA1260")]
	public bool FEJCBGLOGBK(Hash128 DOAOBIHCNJF, [Out] IMJHKMDODKH CBNKKMIFMKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6CA33D0", Offset = "0x6CA1DD0", VA = "0x186CA33D0")]
	public IMJHKMDODKH JJJMHPMEAIK(NOILJNDMGMN JGCMECODHDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA31E0", Offset = "0x6CA1BE0", VA = "0x186CA31E0")]
	public JEAOPLIOJJK JJJMHPMEAIK(NBCIBJODIAO KFGOIEOLDHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3020", Offset = "0x6CA1A20", VA = "0x186CA3020")]
	public BKCLCHMHELJ JJJMHPMEAIK(EKENLHCAPBD NFEPGHCPILM, bool MBAOCLEIABJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3A80", Offset = "0x6CA2480", VA = "0x186CA3A80")]
	public void MBEEDABKNGP(BJAEJBNIKGF DJFACICIDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4C00", Offset = "0x6CA3600", VA = "0x186CA4C00")]
	public static void PDEFKDIGNOC(GMBENFHCBOD CEEMGDGDBHO, PKOAPGBMPCO[] JGCMECODHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6CA4220", Offset = "0x6CA2C20", VA = "0x186CA4220")]
	private void NKOFBLHPBDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6CA2390", Offset = "0x6CA0D90", VA = "0x186CA2390")]
	private static void IMKGDPGCEAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3530", Offset = "0x6CA1F30", VA = "0x186CA3530")]
	public void KGIPELHHPIJ(CommandBuffer FMDCOJMFHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3840", Offset = "0x6CA2240", VA = "0x186CA3840")]
	public void KNBKEIHOGLB([Optional] ScriptableRenderContext? EIGKPCONJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0F90", Offset = "0x6C9F990", VA = "0x186CA0F90")]
	public void FAPFCKCPBIB(CommandBuffer FMDCOJMFHLF, ShadowSplitData GEDOAEFKIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0CB0", Offset = "0x6C9F6B0", VA = "0x186CA0CB0")]
	public void FAPFCKCPBIB(CommandBuffer FMDCOJMFHLF, CameraData JAOBICNLCGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3CE0", Offset = "0x6CA26E0", VA = "0x186CA3CE0")]
	public void NIJODBHKNPH(CommandBuffer FMDCOJMFHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0480", Offset = "0x6C9EE80", VA = "0x186CA0480")]
	public void APCICIFEMNP(CommandBuffer FMDCOJMFHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0540", Offset = "0x6C9EF40", VA = "0x186CA0540")]
	public void CMGOANDNBIJ(CommandBuffer FMDCOJMFHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6CA1410", Offset = "0x6C9FE10", VA = "0x186CA1410")]
	public void GIJGPNEGMHB(CommandBuffer FMDCOJMFHLF, GMBENFHCBOD MBAPAINNJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6CA3BB0", Offset = "0x6CA25B0", VA = "0x186CA3BB0")]
	public void NDGFIFLJNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6C9E260", Offset = "0x6C9CC60", VA = "0x186C9E260")]
	public void AGDCKPANMGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6CA0AE0", Offset = "0x6C9F4E0", VA = "0x186CA0AE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MKEELECAFEK
{
	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x20B5520", Offset = "0x20B3F20", VA = "0x1820B5520")]
	public static int HICGMNDBCGD(int DMIMFDDIIBO, int IPMHBDOCJBI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BLMDLAHCMDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public float4x4 BNKGAKAEKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public float4 OJECDGHGBJD;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly BLMDLAHCMDI EAIPHOJDJBD;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public static readonly BLMDLAHCMDI PFLMBFLCPLB;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x44B70F0", Offset = "0x44B5AF0", VA = "0x1844B70F0")]
	public BLMDLAHCMDI(float4x4 MPOFCBAKNEN, float4 CGLONKJJKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C9DF50", Offset = "0x6C9C950", VA = "0x186C9DF50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct IHIKFIPPNLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float4 LEELMECKGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public float4 DBBPPLLNKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float4 DNAJPPCEHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float4 EBFJNEKEPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public float4 NACKGENKNDE;
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct OFAGFJMBLHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public float4 LEELMECKGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public half4 DBBPPLLNKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public half4 DNAJPPCEHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public half4 EBFJNEKEPCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public half4 NACKGENKNDE;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct JDNKBIOFJDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public OFAGFJMBLHC KKHIPOLPLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public OFAGFJMBLHC LGBJCHNJJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	public OFAGFJMBLHC DOHALGEGHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	public OFAGFJMBLHC CPNNJPEIKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	public OFAGFJMBLHC EKBKKFPPHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public OFAGFJMBLHC JGGMPBADDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public OFAGFJMBLHC NFOCBEANIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public OFAGFJMBLHC AOIHKGOJCIB;
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public struct AIIHFIIOJFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public IHIKFIPPNLM KKHIPOLPLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	public IHIKFIPPNLM LGBJCHNJJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public IHIKFIPPNLM DOHALGEGHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public IHIKFIPPNLM CPNNJPEIKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public IHIKFIPPNLM EKBKKFPPHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public IHIKFIPPNLM JGGMPBADDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public IHIKFIPPNLM NFOCBEANIFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public IHIKFIPPNLM AOIHKGOJCIB;
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct IMFFDCLGLDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public float4 GECFOLMCGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public uint DCOBFDGAPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public uint NMEBIIGAMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	public float EIFPFALHLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public uint IMOHNFKJMDM;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6CA5FD0", Offset = "0x6CA49D0", VA = "0x186CA5FD0")]
	public IMFFDCLGLDH(NBCIBJODIAO KFGOIEOLDHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct KDANFDMOPEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	public uint JLIAFKAGGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public uint IINMNNDMPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public uint MNBGKMOCBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public uint IMOHNFKJMDM;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6CA87B0", Offset = "0x6CA71B0", VA = "0x186CA87B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct PDLNOLBEGKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public uint JDNDIJJOBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public uint PPJFJIPOJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public uint EHANMNGLAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public uint IMOHNFKJMDM;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6CABD00", Offset = "0x6CAA700", VA = "0x186CABD00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct JGCGPKJEFDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public uint HPANIDNNADA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public uint NJFBHDBFAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public uint HEGPCPKPDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public uint HNLLHFBABCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public uint KPAIKBNNHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public uint MOECPHBAIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public uint BJICEODHDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public uint IMOHNFKJMDM;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6CA8480", Offset = "0x6CA6E80", VA = "0x186CA8480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct APJJGKPODMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint3 EKHALBIHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public uint3 OBAKNFPEMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public uint3 OAIDEEBAJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public uint3 KHDBAAJAJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public uint3 HGIHNFJPEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public uint3 CAONALNIFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public uint3 HNHJGBIGGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public uint3 PPFHDODLGJA;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C9BDA0", Offset = "0x6C9A7A0", VA = "0x186C9BDA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public enum GMBENFHCBOD
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
