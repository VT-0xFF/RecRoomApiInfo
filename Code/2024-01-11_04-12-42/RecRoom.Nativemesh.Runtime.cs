using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7BA380", Offset = "0x7B8D80", VA = "0x1807BA380")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EIBAILHIKPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int GEHJBIEOCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 IKBNMPBFEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion BDHAGCAPNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 CFCAGMPKJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int IMHNEIGMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int LGOIHHCMPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int DMJIPHFNBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float ABINOJILEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 MJCBOCDPAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool IEHHPJHAKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NGBCNDKKDAH LIHMPJGDGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 KHIBCNKIMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float HIDIGNJPKPH;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PJPFBNNOCND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static GHOCLINLPFC BNODOLJDCJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<EIBAILHIKPI> BJBEKMEELDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<DOPABMFHIIH> KNDKMNCOANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<FFAHNNKMPFD> EFHJAIKJPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<CIBLCMOLLPK> HADDJNGHGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<DOPABMFHIIH> JGMDPALODOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<BEIJADPEJIK> FCPMOPENBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<CIBLCMOLLPK>> CLPGPLOJNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<HFBDOFDOPGA> FLECABAMFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> LCDENLFIECE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EEDKLJPOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBA4710", Offset = "0xBA3110", VA = "0x180BA4710")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xBA4070", Offset = "0xBA2A70", VA = "0x180BA4070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CFIAFMJLLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBA4720", Offset = "0xBA3120", VA = "0x180BA4720")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBA3DA0", Offset = "0xBA27A0", VA = "0x180BA3DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6029360", Offset = "0x6027D60", VA = "0x186029360")]
	public PJPFBNNOCND(int LPLNPELBNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60289F0", Offset = "0x60273F0", VA = "0x1860289F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6028820", Offset = "0x6027220", VA = "0x186028820")]
	public void BODCNAJIBKJ(JobHandle MPIOAGHMLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6028CC0", Offset = "0x60276C0", VA = "0x186028CC0")]
	public void GLANNFJKCBK(EIBAILHIKPI OBAHLGOPPIK, HFBDOFDOPGA COMPOIEPLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6028EE0", Offset = "0x60278E0", VA = "0x186028EE0")]
	public void HBPJFJOCGMI(FFAHNNKMPFD OBAHLGOPPIK, NativeArray<CIBLCMOLLPK> PGCBEPJDBLC, int DMDKKCCBCAB, int GIBEDFKDIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6027810", Offset = "0x6026210", VA = "0x186027810")]
	public JobHandle AFIBLNNFJLN(JNLLJECNLCA PPKAMCEGJOI, BGDLNCPLEGJ DLDNKNKBPGP, float3 OFLMKMOJKPE, quaternion PMCKGDNEBBO, float CIEODMIMEIF, bool MGMMEENEILJ, int AGMFMDPHEAB = 0, int JOHMEOFGLBM = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6029020", Offset = "0x6027A20", VA = "0x186029020")]
	public static JobHandle JAKENKCFLFL(EFGILPOCCNJ ACNHBCHBCCG, JNLLJECNLCA PPKAMCEGJOI, EIBAILHIKPI OBAHLGOPPIK, JobHandle MPIOAGHMLJG)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6028A10", Offset = "0x6027410", VA = "0x186028A10")]
	public static JobHandle FJHCOOMIMHG(JABACKMCPIK ACNHBCHBCCG, JNLLJECNLCA PPKAMCEGJOI, FFAHNNKMPFD OBAHLGOPPIK, NativeArray<CIBLCMOLLPK> PGCBEPJDBLC, int DMDKKCCBCAB, int GIBEDFKDIAI, JobHandle MPIOAGHMLJG)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NMKNAHLHIGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 EJGBKLGCLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 PFMKBDDCECO;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CFILGFHFKOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<NMKNAHLHIGK> ACNIBHLFBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> CLIELINIJCP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int EEDKLJPOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7977F0", Offset = "0x7961F0", VA = "0x1807977F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int CFIAFMJLLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7965A0", Offset = "0x794FA0", VA = "0x1807965A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x601EB40", Offset = "0x601D540", VA = "0x18601EB40")]
	public CFILGFHFKOM(int NPMLIJBCFAO, int PAHHNNCFBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x601EAE0", Offset = "0x601D4E0", VA = "0x18601EAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x601EA00", Offset = "0x601D400", VA = "0x18601EA00")]
	public void CMBGMLMCIAO(CFILGFHFKOM IIFEBMFNOOO, int CKKEPIMOANJ, int MGKCHJOOGGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DABLHLMAFGC
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static CFILGFHFKOM BHOAMHDOBMO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<DOPABMFHIIH> KMNIALDFEKD;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] NIHIMEGADLD;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool BFOOKKGCOPF;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, CFILGFHFKOM> EKJFAGIJODC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, CFILGFHFKOM> LOBONJDBDNM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool GEAMBBICLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60200D0", Offset = "0x601EAD0", VA = "0x1860200D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<DOPABMFHIIH> NONJPOOOCGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6021590", Offset = "0x601FF90", VA = "0x186021590")]
		get
		{
			return default(NativeList<DOPABMFHIIH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static CFILGFHFKOM GPJKPELMNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6020370", Offset = "0x601ED70", VA = "0x186020370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6020EC0", Offset = "0x601F8C0", VA = "0x186020EC0")]
	private static void NJDOFBALJBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6021560", Offset = "0x601FF60", VA = "0x186021560")]
	public static int NOFCBMMBGDM(bool GBEJEFEHFEJ, int ILDOKHKOBCE, bool CIHMLNOPDHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6020340", Offset = "0x601ED40", VA = "0x186020340")]
	private static int GEBFCOHHGCB(int ILDOKHKOBCE, bool CCADKFBGIDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6021630", Offset = "0x6020030", VA = "0x186021630")]
	private static int PCINCCKDDOJ(int ILDOKHKOBCE, bool CCADKFBGIDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60214D0", Offset = "0x601FED0", VA = "0x1860214D0")]
	public static int NJEJPNAOLEG(int EFFOMDBKFBD, int ILDOKHKOBCE, int GLJGEHNOGLI, bool CCADKFBGIDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6020E30", Offset = "0x601F830", VA = "0x186020E30")]
	public static int NDCJJGILHPG(int EFFOMDBKFBD, int ILDOKHKOBCE, int GLJGEHNOGLI, bool CCADKFBGIDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6020360", Offset = "0x601ED60", VA = "0x186020360")]
	public static int GEPDCMKELBA(int GLJGEHNOGLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6020150", Offset = "0x601EB50", VA = "0x186020150")]
	private static int EPLEGOHAHON(int ILDOKHKOBCE, bool CCADKFBGIDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6020410", Offset = "0x601EE10", VA = "0x186020410")]
	private static int GLCMPFKGBBM(int ILDOKHKOBCE, bool CCADKFBGIDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6020060", Offset = "0x601EA60", VA = "0x186020060")]
	public static int EMCPNCADKHC(int EFFOMDBKFBD, int ILDOKHKOBCE, int GLJGEHNOGLI, bool CCADKFBGIDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x601FFD0", Offset = "0x601E9D0", VA = "0x18601FFD0")]
	public static int CKDKBJJGAAO(int EFFOMDBKFBD, int ILDOKHKOBCE, int GLJGEHNOGLI, bool CCADKFBGIDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6020A00", Offset = "0x601F400", VA = "0x186020A00")]
	public static int KOOMJFBGFGK(int GLJGEHNOGLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6020160", Offset = "0x601EB60", VA = "0x186020160")]
	public static CFILGFHFKOM FGICCHPFGPJ(int ILDOKHKOBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6020430", Offset = "0x601EE30", VA = "0x186020430")]
	private static CFILGFHFKOM GNDOCFMICPK(int ILDOKHKOBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6020250", Offset = "0x601EC50", VA = "0x186020250")]
	public static CFILGFHFKOM FIDNHMJACJP(int ILDOKHKOBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60206C0", Offset = "0x601F0C0", VA = "0x1860206C0")]
	private static CFILGFHFKOM HIHKJBLDMNI(int ILDOKHKOBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6020A20", Offset = "0x601F420", VA = "0x186020A20")]
	public static void LNENHBICFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct FFAHNNKMPFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int OGEIHCFMIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 IKBNMPBFEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion BDHAGCAPNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float CFCAGMPKJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float GMOPOMJKHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int IMHNEIGMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int LGOIHHCMPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int DMJIPHFNBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool GMHNMMGBIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool OFIGDDLJONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float ABINOJILEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 MJCBOCDPAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool CJCIADNDHKB;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BEIJADPEJIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int OCBOLOFDHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int PCIMDIHCHMJ;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JABACKMCPIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<FFAHNNKMPFD> EDDOMDJDKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<CIBLCMOLLPK> OCNAIDNCFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<DOPABMFHIIH> CEGBFEIHCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<BEIJADPEJIK> GAENFFIFBGB;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6025480", Offset = "0x6023E80", VA = "0x186025480")]
	public JABACKMCPIK(NativeArray<CIBLCMOLLPK> OCNAIDNCFPH, int DDIMFHFNGHG = 1, Allocator OOLLJDKALHO = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6025390", Offset = "0x6023D90", VA = "0x186025390", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct DIBNKOPJIJO : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<NMKNAHLHIGK> MOPFONCMNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> MGKNPGPKLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<DOPABMFHIIH> KLIBHHMDENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<FFAHNNKMPFD> EDDOMDJDKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<CIBLCMOLLPK> OCNAIDNCFPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<DOPABMFHIIH> CEGBFEIHCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<BEIJADPEJIK> GAENFFIFBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int HHOLDGNPAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int DLNKKBMOHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 LIHHJFAOGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion CAHAEONDJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 KEADKNHMEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> HPHAOPECNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BLFJKPLAHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EDAMMKDHDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MBCEKMNLHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> BLFDPKIIECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> PMLNIMPIIHF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6023960", Offset = "0x6022360", VA = "0x186023960")]
	public DIBNKOPJIJO(PJPFBNNOCND EEADDEBGEFK, JNLLJECNLCA OIGBMPCPFOP, float3 OOHKHPBBKAE, quaternion LPHFFMOBGOB, float LEKFMABDDKN, int AGMFMDPHEAB = 0, int JOHMEOFGLBM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6023730", Offset = "0x6022130", VA = "0x186023730")]
	public DIBNKOPJIJO(JABACKMCPIK EEADDEBGEFK, JNLLJECNLCA OIGBMPCPFOP, float3 OOHKHPBBKAE, quaternion LPHFFMOBGOB, float3 LEKFMABDDKN, int AGMFMDPHEAB = 0, int JOHMEOFGLBM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60217B0", Offset = "0x60201B0", VA = "0x1860217B0")]
	private float3 DDMAFMHPLKC(float3 JJOKPLDGLDP, Matrix4x4 PMMHFNAFDLO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6022BF0", Offset = "0x60215F0", VA = "0x186022BF0")]
	private float3x3 FLLLPIJLFLK(float3x3 ONNJDBMEAJA, float3x3 GNGJFGPKNEG)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6022C70", Offset = "0x6021670", VA = "0x186022C70")]
	private float HKKIHMNANGL(float EFPGCAMCJII, float FGFCIENGODJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6021A50", Offset = "0x6020450", VA = "0x186021A50", Slot = "4")]
	public void Execute(int NBCDDECIMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60218E0", Offset = "0x60202E0", VA = "0x1860218E0")]
	private void DONILKEKNPD(int PEJHOPPIGLN, float3 CJONGNPPIAD, float3 AJENBHCBECD, float3 GLNMPHIHCIM, float HDEDKDLDKGD, bool HMEGADIAGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6022C80", Offset = "0x6021680", VA = "0x186022C80")]
	private void MHCOCMILGJN(FFAHNNKMPFD DEDINHKKLAK, float3 IIOMHHNKEHL, float3x3 MAIAHGOINCE, float EFPGCAMCJII, int HNCJCKBENFA, int HCNEAGDGMGP, int AAGEEFIOCKL, float HNJDJNMKFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60230E0", Offset = "0x6021AE0", VA = "0x1860230E0")]
	private void OLBJFCABKHJ(int PEJHOPPIGLN, int HIOFMCCLCKF, FFAHNNKMPFD DEDINHKKLAK, float3 IIOMHHNKEHL, float3x3 MAIAHGOINCE, bool BEAFPAJGPPI, float EFPGCAMCJII, int KPFKONCFPBC, int KNPKBPANNBL, int AAGEEFIOCKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EFGILPOCCNJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<EIBAILHIKPI> MDFOGABLEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<DOPABMFHIIH> MHOJMJFBILL;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60241F0", Offset = "0x6022BF0", VA = "0x1860241F0")]
	public EFGILPOCCNJ(int DDIMFHFNGHG, Allocator OOLLJDKALHO = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6024150", Offset = "0x6022B50", VA = "0x186024150", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct BILPNFHENIM : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum IFOAFGJAEGG
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeList<float3> IHIJJLAGFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> OJDCCHCDIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> KLDCBBAIBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> JMBJNOBOCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> CCMMJDABOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> DHLFELEINBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> PMKPNJBDPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> DJPOIJGLHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<DOPABMFHIIH> ALBLJOHGPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<EIBAILHIKPI> MDFOGABLEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<DOPABMFHIIH> MHOJMJFBILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int HHOLDGNPAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int DLNKKBMOHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> HPHAOPECNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BLFJKPLAHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EDAMMKDHDPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MBCEKMNLHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> BLFDPKIIECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> PMLNIMPIIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 KEADKNHMEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion CAHAEONDJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 LIHHJFAOGMP;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x601BC20", Offset = "0x601A620", VA = "0x18601BC20")]
	public BILPNFHENIM(PJPFBNNOCND EEADDEBGEFK, JNLLJECNLCA OIGBMPCPFOP, float3 OOHKHPBBKAE, quaternion LPHFFMOBGOB, float LEKFMABDDKN, int AGMFMDPHEAB = 0, int JOHMEOFGLBM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x601BA30", Offset = "0x601A430", VA = "0x18601BA30")]
	public BILPNFHENIM(EFGILPOCCNJ OBAHLGOPPIK, JNLLJECNLCA OIGBMPCPFOP, float3 OOHKHPBBKAE, quaternion LPHFFMOBGOB, float3 LEKFMABDDKN, int AGMFMDPHEAB = 0, int JOHMEOFGLBM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x601A670", Offset = "0x6019070", VA = "0x18601A670", Slot = "4")]
	public void Execute(int NBCDDECIMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x601B640", Offset = "0x601A040", VA = "0x18601B640")]
	private void KOOGCFFLJDG(float4x4 HBMGDLPMNEL, int NBCDDECIMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x601B5D0", Offset = "0x6019FD0", VA = "0x18601B5D0")]
	private IFOAFGJAEGG JEIBBOFEGPO(float3 AJENBHCBECD)
	{
		return default(IFOAFGJAEGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x601A620", Offset = "0x6019020", VA = "0x18601A620")]
	private float4 CNOOJNFIKGN(IFOAFGJAEGG NFGPFDMIPOF, int BNALCEABILL)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x601B9F0", Offset = "0x601A3F0", VA = "0x18601B9F0")]
	private float2 MKIDLLEEJDO(IFOAFGJAEGG NFGPFDMIPOF, float3 CJONGNPPIAD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct HFBDOFDOPGA
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum LOJNEPMDJOA
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static HFBDOFDOPGA DPEMCFFPABG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 LMPBAOBONND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 AMNPPNHEHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 DGFKKGBDDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public LOJNEPMDJOA KBCPOJJINMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 OPALPBLILCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 NLFNINCHNBO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DAJJFGPBCLH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6024CA0", Offset = "0x60236A0", VA = "0x186024CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 JBPEFCMIKOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6024F50", Offset = "0x6023950", VA = "0x186024F50")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60252A0", Offset = "0x6023CA0", VA = "0x1860252A0")]
	public HFBDOFDOPGA(float3 CJONGNPPIAD, quaternion KPKKBKKOGOG, float3 DDIMFHFNGHG, LOJNEPMDJOA AKDFFJNHJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6025030", Offset = "0x6023A30", VA = "0x186025030")]
	public float MKBJODMAOJL(float3 IIOMHHNKEHL, float AKFFJDMIHOF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6024E60", Offset = "0x6023860", VA = "0x186024E60")]
	public bool LOKBFJFKLKF(float3 AJENBHCBECD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6024CB0", Offset = "0x60236B0", VA = "0x186024CB0")]
	public void FGFBHONMANM(float3 LAEEMGPLHNB, float3x3 NCJFKCJIHOA, float KLCDDFAHGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6024BA0", Offset = "0x60235A0", VA = "0x186024BA0")]
	private void AOFBMNFDDNH(float3 HPCONAOEEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6024910", Offset = "0x6023310", VA = "0x186024910")]
	public void AGODGJLKGGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct BHCPMEECDEF : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<HFBDOFDOPGA> OBAHLGOPPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> DMPBGJCGONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> DHGAOAECDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LCDENLFIECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<DOPABMFHIIH> MHOJMJFBILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int OLFBACJIEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int BHLLNCNPFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float AKFFJDMIHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float MBCDCLIHKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> KAEDHMODECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> GMOIKDNDHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> FGLKNEIAFFO;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x601A580", Offset = "0x6018F80", VA = "0x18601A580")]
	public BHCPMEECDEF(JNLLJECNLCA JLGPFEEEKMH, float PCHLOMDJOKP, int MGKCHJOOGGA, int HNCJCKBENFA, NativeList<HFBDOFDOPGA> OBAHLGOPPIK, NativeArray<int> LCDENLFIECE, NativeList<DOPABMFHIIH> MHOJMJFBILL, BGDLNCPLEGJ DLDNKNKBPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6019BA0", Offset = "0x60185A0", VA = "0x186019BA0", Slot = "4")]
	public void Execute(int MCADDMAGBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6019AE0", Offset = "0x60184E0", VA = "0x186019AE0")]
	private bool CHLFMIOBHPA(HFBDOFDOPGA PJHMDOOMOBI, HFBDOFDOPGA OIKFNBPLIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x601A2E0", Offset = "0x6018CE0", VA = "0x18601A2E0")]
	private bool KMNKDBDKGMK(HFBDOFDOPGA ACHEPLMFHGG, int CBKPONCFKGO, int IOLDMCLGBBM, int KBNJGBAAEEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BGDLNCPLEGJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> ICHCGFOBMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> IAIOIBNIDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> JCONJFEEMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> ADOHACFDKMA;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60199E0", Offset = "0x60183E0", VA = "0x1860199E0")]
	public void NOOFBLLKBMJ(int NPMLIJBCFAO, int PAHHNNCFBIG, Allocator OOLLJDKALHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60199C0", Offset = "0x60183C0", VA = "0x1860199C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60198D0", Offset = "0x60182D0", VA = "0x1860198D0")]
	public void BODCNAJIBKJ(JobHandle MPIOAGHMLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public BGDLNCPLEGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct CHBFMIFCBHL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> DMPBGJCGONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> FPNMDKBDIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> EKAJECGIBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> OBJELMFPHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> DHGAOAECDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AEENJIJMOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> NDBKNFKNGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> KAEDHMODECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> GMOIKDNDHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int AGMFMDPHEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int JOHMEOFGLBM;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x601F040", Offset = "0x601DA40", VA = "0x18601F040")]
	public CHBFMIFCBHL(JNLLJECNLCA JLGPFEEEKMH, BGDLNCPLEGJ DLDNKNKBPGP, int JOHMEOFGLBM = 0, int AGMFMDPHEAB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x601EC00", Offset = "0x601D600", VA = "0x18601EC00", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x601EFE0", Offset = "0x601D9E0", VA = "0x18601EFE0")]
	private void LJJPEFBNCCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GGGGLIENHAP
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2609950", Offset = "0x2608350", VA = "0x182609950")]
	public static bool AAGBDOEAFPD<T>(NativeArray<T> BHNHFMPCKPL, int DDIMFHFNGHG, Allocator OOLLJDKALHO, NativeArrayOptions BFKMPGOIOPI = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26099F0", Offset = "0x26083F0", VA = "0x1826099F0")]
	public static bool AAGBDOEAFPD<T>(NativeList<T> BPDJICGMKNG, int DDIMFHFNGHG, Allocator OOLLJDKALHO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum LPPFIKCAIBF
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	None
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface EHFAJOKCNHD
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DMDFKKALGNL(LPPFIKCAIBF EFFOMDBKFBD);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HBLMBOILDOA(LPPFIKCAIBF EFFOMDBKFBD);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCKALOHEIKD(LPPFIKCAIBF EFFOMDBKFBD, PJPFBNNOCND LGLNEKFLEFL, int JGLBHPLKNJI = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JNLLJECNLCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int OFHOBINHEAI = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> PMIAPEJAAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> MPIBEPPGMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> KNFAKODPBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> OHCNIDPHDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> JDBNAGHCDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> IAIAFKKEPPA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool KBMKICIKMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6025AA0", Offset = "0x60244A0", VA = "0x186025AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EEDKLJPOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6025AE0", Offset = "0x60244E0", VA = "0x186025AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CFIAFMJLLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6026190", Offset = "0x6024B90", VA = "0x186026190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NNDMFLBOPHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6025B20", Offset = "0x6024520", VA = "0x186025B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6025990", Offset = "0x6024390", VA = "0x186025990", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6026250", Offset = "0x6024C50", VA = "0x186026250")]
	public void NOOFBLLKBMJ(int NPMLIJBCFAO, int PAHHNNCFBIG, Allocator OOLLJDKALHO, bool ACPCBFPNMAC, bool OEPDKILAEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60261D0", Offset = "0x6024BD0", VA = "0x1860261D0")]
	public void MACDJINENHL(int NPMLIJBCFAO, int PAHHNNCFBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60255B0", Offset = "0x6023FB0", VA = "0x1860255B0", Slot = "6")]
	public bool CLBCDGJIJFD(Mesh JLGPFEEEKMH, bool KIMNMFLLBOF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6025B60", Offset = "0x6024560", VA = "0x186025B60")]
	public bool JBBEJCBLGHI(Mesh JLGPFEEEKMH, JNLLJECNLCA HGBDEACGIDP, bool KIMNMFLLBOF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	public JNLLJECNLCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CBKABOPDFMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x601E8B0", Offset = "0x601D2B0", VA = "0x18601E8B0")]
	public static void LNENHBICFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PGGKBPOGFIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> PMIAPEJAAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> MPIBEPPGMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> BECINJAMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> ONIAGNHDGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> DNMENIBIHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> GDNPCANLANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> IJKMEBECLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> IAIAFKKEPPA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int EEDKLJPOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6026830", Offset = "0x6025230", VA = "0x186026830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int CFIAFMJLLCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6026870", Offset = "0x6025270", VA = "0x186026870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int IKKHEOBKKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6026E30", Offset = "0x6025830", VA = "0x186026E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6027300", Offset = "0x6025D00", VA = "0x186027300")]
	public PGGKBPOGFIO(int NPMLIJBCFAO, int PAHHNNCFBIG, int IGEIMJFNOIO, Allocator OOLLJDKALHO = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6027520", Offset = "0x6025F20", VA = "0x186027520")]
	public PGGKBPOGFIO(Mesh JLGPFEEEKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6026720", Offset = "0x6025120", VA = "0x186026720", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6026420", Offset = "0x6024E20", VA = "0x186026420")]
	public void CMBGMLMCIAO(PGGKBPOGFIO JLGPFEEEKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6026E70", Offset = "0x6025870", VA = "0x186026E70")]
	private void OKEFHBOPINC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60268B0", Offset = "0x60252B0", VA = "0x1860268B0")]
	private void MGOPELEMFMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DOPABMFHIIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int HBMFLAEDDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int EEDKLJPOMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int JBKFEJIDPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int CFIAFMJLLCN;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1174740", Offset = "0x1173140", VA = "0x181174740")]
	public DOPABMFHIIH(int HNCJCKBENFA, int DMDKKCCBCAB, int MGKCHJOOGGA, int GIBEDFKDIAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GHOCLINLPFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<DOPABMFHIIH> ODALLKCMDLF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB51900", Offset = "0xB50300", VA = "0x180B51900")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<DOPABMFHIIH>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1BCA120", Offset = "0x1BC8B20", VA = "0x181BCA120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public PGGKBPOGFIO FMJICEFJJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x793B40", Offset = "0x792540", VA = "0x180793B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x790CA0", Offset = "0x78F6A0", VA = "0x180790CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6024350", Offset = "0x6022D50", VA = "0x186024350")]
	public GHOCLINLPFC(IEnumerable<PGGKBPOGFIO> FNMPKBPEDIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60242E0", Offset = "0x6022CE0", VA = "0x1860242E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum NGBCNDKKDAH
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EDGCCJJEEEE
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> FPDGIMCOIGO;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> IPNBMGLEPHE;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> AMCONIOFJLM;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> NJKBIMOKPBD;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6024030", Offset = "0x6022A30", VA = "0x186024030")]
	public static void LNENHBICFIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6023F20", Offset = "0x6022920", VA = "0x186023F20")]
	public static NativeArray<float2> KPPOAEMEOLN(NativeArray<float2> GGDJPLICIBM, int EBKPONAKEBE, NativeArray<float2> ENEHGGMLEEE, int DDEIKOBFPNG)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6023D00", Offset = "0x6022700", VA = "0x186023D00")]
	public static NativeArray<float3> IBCCKBBFCLM(NativeArray<float3> GGDJPLICIBM, int EBKPONAKEBE, NativeArray<float3> ENEHGGMLEEE, int DDEIKOBFPNG)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6023E10", Offset = "0x6022810", VA = "0x186023E10")]
	public static NativeArray<float4> IBKPPBLJDIG(NativeArray<float4> GGDJPLICIBM, int EBKPONAKEBE, NativeArray<float4> ENEHGGMLEEE, int DDEIKOBFPNG)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6023BF0", Offset = "0x60225F0", VA = "0x186023BF0")]
	public static NativeArray<int> FLIFIDCPIBM(NativeArray<int> GGDJPLICIBM, int EBKPONAKEBE, NativeArray<int> ENEHGGMLEEE, int DDEIKOBFPNG)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x24A0420", Offset = "0x249EE20", VA = "0x1824A0420")]
	private static void NDKHOGNMICD<T>(NativeArray<T> BHNHFMPCKPL, int HJEBKGALAPD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x24A0370", Offset = "0x249ED70", VA = "0x1824A0370")]
	private static void GPNOHLPLLPJ<T>(NativeArray<T> GGDJPLICIBM, int EBKPONAKEBE, NativeArray<T> ENEHGGMLEEE, int DDEIKOBFPNG, NativeArray<T> BHKLFMLJICP) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DABKBOOAHMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<EHFAJOKCNHD> CKKKCBCEIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly FDBPKJCCENB AKLIJDAPOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int DMDKKCCBCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int GIBEDFKDIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool JGNCDKHHMEI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh FMJICEFJJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x793910", Offset = "0x792310", VA = "0x180793910")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x793D30", Offset = "0x792730", VA = "0x180793D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer HGLEFKDAPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x79A7B0", Offset = "0x7991B0", VA = "0x18079A7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int EEDKLJPOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x601FA30", Offset = "0x601E430", VA = "0x18601FA30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x215BEC0", Offset = "0x215A8C0", VA = "0x18215BEC0")]
	public void JJKPBJDFCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x601FEB0", Offset = "0x601E8B0", VA = "0x18601FEB0")]
	public DABKBOOAHMM(string CDHDOGOGPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x601F170", Offset = "0x601DB70", VA = "0x18601F170")]
	public void BODCNAJIBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x601FA00", Offset = "0x601E400", VA = "0x18601FA00")]
	public void FKEFMPNDMDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x601FA50", Offset = "0x601E450", VA = "0x18601FA50")]
	public void GONOJKAFIAJ(EHFAJOKCNHD OPMAJBDMJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x601FC40", Offset = "0x601E640", VA = "0x18601FC40")]
	private void KLFKGOHFFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x601FBD0", Offset = "0x601E5D0", VA = "0x18601FBD0")]
	public bool KEFPNABIBOE(EHFAJOKCNHD OPMAJBDMJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x601F220", Offset = "0x601DC20", VA = "0x18601F220")]
	public bool EODOHENOEFA(EHFAJOKCNHD OPMAJBDMJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x601F1B0", Offset = "0x601DBB0", VA = "0x18601F1B0", Slot = "4")]
	public virtual void ELCBMMPIGMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x601FB00", Offset = "0x601E500", VA = "0x18601FB00")]
	public void HMFHCIONIIE(Transform EOHLMBCMKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x601F280", Offset = "0x601DC80", VA = "0x18601F280")]
	public bool FCOPDIIEFAL(Transform EOHLMBCMKEP, [Out] (JNLLJECNLCA destMesh, Mesh mesh, JobHandle job) OBAHLGOPPIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x601F0C0", Offset = "0x601DAC0", VA = "0x18601F0C0")]
	public void BJOGEONBHGH([In] (JNLLJECNLCA destMesh, Mesh mesh, JobHandle job) OBAHLGOPPIK)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker BJCJHCDHOIE;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker FAHHCPLFANJ;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker DGALEHPHPNJ;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int KPNHJDCEDHC = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<Material, List<DABKBOOAHMM>> DAGBHMEMLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<DABKBOOAHMM> MDPKICOBMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> GKPBNINMNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(DABKBOOAHMM, (JNLLJECNLCA, Mesh, JobHandle))> FNLLCKNCEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool HCBEKDEDAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> BKHELOMBEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> FMLKOJHJNPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> GJGJHMFLAJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> INIJIIEBMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private DABKBOOAHMM DEFJMDFIOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material CHIHJNDEEBC;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> PPFDMJJKDJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x799000", Offset = "0x797A00", VA = "0x180799000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x601D870", Offset = "0x601C270", VA = "0x18601D870")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x601C090", Offset = "0x601AA90", VA = "0x18601C090")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x601BE10", Offset = "0x601A810", VA = "0x18601BE10")]
		public DABKBOOAHMM AddToBatchedMesh(EHFAJOKCNHD OGMMFCJOIDI, Material HEPAJJIBPIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x601DAC0", Offset = "0x601C4C0", VA = "0x18601DAC0")]
		public void RemoveFromBatchedMesh(EHFAJOKCNHD JLGPFEEEKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x601BEF0", Offset = "0x601A8F0", VA = "0x18601BEF0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x601DC40", Offset = "0x601C640", VA = "0x18601DC40")]
		public void SetMaterialProperty(int OBIGLBACPPM, Color GJNHDHNOICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x601E0D0", Offset = "0x601CAD0", VA = "0x18601E0D0")]
		public void SetMaterialProperty(int OBIGLBACPPM, float BEEGCHJLJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x601E2F0", Offset = "0x601CCF0", VA = "0x18601E2F0")]
		public void SetMaterialProperty(int OBIGLBACPPM, Vector4 KDOHLBBAJEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x601DE70", Offset = "0x601C870", VA = "0x18601DE70")]
		public void SetMaterialProperty(int OBIGLBACPPM, Matrix4x4 NOOKFOJOPEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x601CE60", Offset = "0x601B860", VA = "0x18601CE60")]
		private void KFMGJHGBBJN(Renderer OIBBJKCEHPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x601C720", Offset = "0x601B120", VA = "0x18601C720")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x601C730", Offset = "0x601B130", VA = "0x18601C730")]
		private void GKLMHKMPOHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x601D450", Offset = "0x601BE50", VA = "0x18601D450")]
		private DABKBOOAHMM LAOGPNFGBFP(EHFAJOKCNHD JLGPFEEEKMH, Material HEPAJJIBPIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x601CC90", Offset = "0x601B690", VA = "0x18601CC90")]
		private DABKBOOAHMM JKFKPLBGJNC(Material HEPAJJIBPIF, int EKGNKDNHINC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x601C270", Offset = "0x601AC70", VA = "0x18601C270")]
		private DABKBOOAHMM FDPBIHKPGFP(Material HEPAJJIBPIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x601D7E0", Offset = "0x601C1E0", VA = "0x18601D7E0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x601D650", Offset = "0x601C050", VA = "0x18601D650")]
		public void MarkDirty(EHFAJOKCNHD JLGPFEEEKMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x601E5F0", Offset = "0x601CFF0", VA = "0x18601E5F0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PBDFIPBCIAC<KeyType> : DABKBOOAHMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, EHFAJOKCNHD> MDGBGEHLFJE;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4059F60", Offset = "0x4058960", VA = "0x184059F60")]
	public PBDFIPBCIAC(string CDHDOGOGPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4059D70", Offset = "0x4058770", VA = "0x184059D70")]
	public void GONOJKAFIAJ(KeyType FHLJKJHFEEK, EHFAJOKCNHD OPMAJBDMJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4059DC0", Offset = "0x40587C0", VA = "0x184059DC0")]
	public bool OGJLEKGNANE(KeyType FHLJKJHFEEK, EHFAJOKCNHD FGCGCEKCIJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4059BF0", Offset = "0x40585F0", VA = "0x184059BF0")]
	public void DPPINOPEAMP(KeyType FHLJKJHFEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4059D30", Offset = "0x4058730", VA = "0x184059D30", Slot = "4")]
	public override void ELCBMMPIGMB()
	{
	}
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
