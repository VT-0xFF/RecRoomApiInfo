using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FKGBFIHOAFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int MNKJPMEDCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 KBMPLFGNMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion MINBFBNDDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 KMEGAONJOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int NLLGBGNAADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int BDGDBNCMBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int NLBHDIGKCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float EDDAPKMEHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 GDFMPAGOPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool MGDEGFMNIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public HFCINMOIJCM BBGDDEOEELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 AFFDNFLHNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float FDGJPHLFEAN;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ABPIHCMGHHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static HGMJMIMEOBG JFOCEMCNFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<FKGBFIHOAFH> KOPIMJLEHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<PFMCIJLJJMA> JPONBBHBGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<DFNKMDNLCBK> FKJHMMHMGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<JIIOCPIGNAG> INCOPJDEKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<PFMCIJLJJMA> GMLAEDPKFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<FDHNNCJKNGP> PLIGGMEMGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<JIIOCPIGNAG>> AALNKOMBEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<BCEDDLKONIN> DAGCKMLMOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> DKFANOAJDOC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int APDKACJPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBB9390", Offset = "0xBB8190", VA = "0x180BB9390")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xBB77E0", Offset = "0xBB65E0", VA = "0x180BB77E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EOBPCLINPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBB93A0", Offset = "0xBB81A0", VA = "0x180BB93A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBB7DC0", Offset = "0xBB6BC0", VA = "0x180BB7DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6056060", Offset = "0x6054E60", VA = "0x186056060")]
	public ABPIHCMGHHG(int LMLEFKNINGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6054510", Offset = "0x6053310", VA = "0x186054510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6054530", Offset = "0x6053330", VA = "0x186054530")]
	public void EMJKKLCOFHG(JobHandle PHKOIIDBFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6055B00", Offset = "0x6054900", VA = "0x186055B00")]
	public void NMIIFIFOEJE(FKGBFIHOAFH OMHIFBJFAGA, BCEDDLKONIN IODKBIBDLCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60549B0", Offset = "0x60537B0", VA = "0x1860549B0")]
	public void KBOGLEIMDKM(DFNKMDNLCBK OMHIFBJFAGA, NativeArray<JIIOCPIGNAG> HHNKPMJOABH, int KFOEOCOIBCG, int KICAGGFEGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6054AF0", Offset = "0x60538F0", VA = "0x186054AF0")]
	public JobHandle MMMOIFIPJLE(GEAAJBLIKPP GKDBHGBJHEF, PNHPNKAMAGD DJFMMHKGECB, float3 AHCDKABCINI, quaternion MBGICFPAAHC, float FJMNGCJCHHL, bool FKDPNIOEDAA, int AJMBFGCHLPL = 0, int OCHKCLODFMI = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6055D20", Offset = "0x6054B20", VA = "0x186055D20")]
	public static JobHandle PCHIBKKNOEN(BJLIKGPKKHC HGAKDEMPBDG, GEAAJBLIKPP GKDBHGBJHEF, FKGBFIHOAFH OMHIFBJFAGA, JobHandle PHKOIIDBFOB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6054700", Offset = "0x6053500", VA = "0x186054700")]
	public static JobHandle FKLHDCNGEBL(OEMNDMDIHBO HGAKDEMPBDG, GEAAJBLIKPP GKDBHGBJHEF, DFNKMDNLCBK OMHIFBJFAGA, NativeArray<JIIOCPIGNAG> HHNKPMJOABH, int KFOEOCOIBCG, int KICAGGFEGDE, JobHandle PHKOIIDBFOB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GANMEJOIIOE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct BALAOONEFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half HPPEJNFJECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort NPBKPJABBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte ACCEFBCFFCH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int KFOEOCOIBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int KICAGGFEGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> PDKDMNLECGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> AJKJHGFKGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> NJLNDPDOEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> PGANEGDPFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<BALAOONEFKL> NEGMHOMALDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> KKFNNLFKMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> FHDFOIFJGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 CEBBGCENDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 KAPABKHNNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 JECFAPIHGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 LIIDLIFGALG;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long PKDKABKPGND;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long OKPDAGFPDAI;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float NPJHCMPPFHE;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool GBHFNFEOMDK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EPGGJBCFLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x605A570", Offset = "0x6059370", VA = "0x18605A570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6059E90", Offset = "0x6058C90", VA = "0x186059E90")]
	public void EMJKKLCOFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x605A980", Offset = "0x6059780", VA = "0x18605A980")]
	public static GANMEJOIIOE IKNJBMGGGFK(Allocator MGPHHCICJPF, GEAAJBLIKPP IFELPOJNDKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x605A5B0", Offset = "0x60593B0", VA = "0x18605A5B0")]
	public static GANMEJOIIOE IKNJBMGGGFK(Allocator MGPHHCICJPF, NativeArray<float3> HFJAKMJLLKC, NativeArray<float3> KHNCCJIDIAJ, NativeArray<float2> DCOCDJNOBDL, NativeArray<float4> DAFFACFNGAG, bool MKIDCIGKGEB, NativeArray<float4> APCEFCEOHAD, NativeArray<int> EGLHONCFCFI, int KFOEOCOIBCG, int LEJPGOOBLHL, int KICAGGFEGDE, int FGMGJILMNCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6059780", Offset = "0x6058580", VA = "0x186059780")]
	public GEAAJBLIKPP DILLDNNMPBA(Allocator MGPHHCICJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x605A490", Offset = "0x6059290", VA = "0x18605A490")]
	public void HIKODOHJCKE(Mesh CKIIGCAJEFJ, bool GIBAHAOKCEO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x605AF50", Offset = "0x6059D50", VA = "0x18605AF50")]
	public long KLNAPKILHPO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x605AE40", Offset = "0x6059C40", VA = "0x18605AE40")]
	private void KLFFECAIJIF(int OKCCCLKDDPJ, int EHMJDPLLMJE, Allocator MGPHHCICJPF, bool EMDLCAJAGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x605AD70", Offset = "0x6059B70", VA = "0x18605AD70")]
	private float3 KHKDBGAFJJE(int FGNDPACDHGL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6059F90", Offset = "0x6058D90", VA = "0x186059F90")]
	private void FLMGIEHAPPI(int FGNDPACDHGL, float3 CIFAJCNKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x605AE00", Offset = "0x6059C00", VA = "0x18605AE00")]
	private float3 KJLAOOALLMF(int FGNDPACDHGL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x605AD20", Offset = "0x6059B20", VA = "0x18605AD20")]
	private void JMFMGCKIKID(int FGNDPACDHGL, float3 CIFAJCNKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6059710", Offset = "0x6058510", VA = "0x186059710")]
	private float4 CEHBECGPOIH(int FGNDPACDHGL)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x605B230", Offset = "0x605A030", VA = "0x18605B230")]
	private void MAPFEFMOFHP(int FGNDPACDHGL, float4 CIFAJCNKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x605BBE0", Offset = "0x605A9E0", VA = "0x18605BBE0")]
	private float2 PFOLNNNNAAL(int FGNDPACDHGL)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x605B120", Offset = "0x6059F20", VA = "0x18605B120")]
	private void LNAKNPCFLIH(int FGNDPACDHGL, float2 CIFAJCNKKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x605B470", Offset = "0x605A270", VA = "0x18605B470")]
	private void OBKDFLCMFMF(NativeArray<float3> HFJAKMJLLKC, int FGMGJILMNCB, int EHMJDPLLMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x605ACA0", Offset = "0x6059AA0", VA = "0x18605ACA0")]
	private void IOEGDOAGMNH(NativeArray<float3> KHNCCJIDIAJ, int FGMGJILMNCB, int EHMJDPLLMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x605A140", Offset = "0x6058F40", VA = "0x18605A140")]
	private void GMMNPMNLFCM(NativeArray<float2> DCOCDJNOBDL, int FGMGJILMNCB, int EHMJDPLLMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x605A3C0", Offset = "0x60591C0", VA = "0x18605A3C0")]
	private void HBGPPIFAFEK(NativeArray<float4> OLMICDGIABA, int FGMGJILMNCB, int EHMJDPLLMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x605B700", Offset = "0x605A500", VA = "0x18605B700")]
	private void OCLCPJINJDK(Allocator MGPHHCICJPF, NativeArray<float4> DAFFACFNGAG, int FGMGJILMNCB, int EHMJDPLLMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x605AFE0", Offset = "0x6059DE0", VA = "0x18605AFE0")]
	private static void LJKCAFPAKMH(NativeArray<float4> KKPJNCFGLIL, NativeArray<BALAOONEFKL> ACFNIIMFABG, NativeArray<byte> NHIGAOAKBKE, int KFOEOCOIBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x605ABC0", Offset = "0x60599C0", VA = "0x18605ABC0")]
	private void ILIGHHCBAAC(Allocator MGPHHCICJPF, NativeArray<int> EGLHONCFCFI, int FGMGJILMNCB, int EHMJDPLLMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6059440", Offset = "0x6058240", VA = "0x186059440")]
	private static NativeArray<byte> BOPKIICOALO(Allocator MGPHHCICJPF, NativeArray<int> EGLHONCFCFI, int PNGMIOFGNBM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6059CA0", Offset = "0x6058AA0", VA = "0x186059CA0")]
	private static void DNOGKINILHJ(NativeArray<int> CDDJBECPMOO, NativeArray<byte> LGDDDNEOAHO, int KICAGGFEGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6059D40", Offset = "0x6058B40", VA = "0x186059D40")]
	private static float3 ECFKKNJDKIP(ushort CGJMNLHPHDJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x605B2B0", Offset = "0x605A0B0", VA = "0x18605B2B0")]
	private static ushort NIBEEHLLFJF(float3 CIFAJCNKKAJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public GANMEJOIIOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JNLGHFCFPEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float2 MHPLMCPGHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float2 OAJANCKGLCD;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MOFLLHMPNLH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<JNLGHFCFPEH> ADHJMGEEOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<int> IGMALEAMAKP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int APDKACJPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E90", Offset = "0x7B4C90", VA = "0x1807B5E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EOBPCLINPMO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E00", Offset = "0x7B2C00", VA = "0x1807B3E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6061210", Offset = "0x6060010", VA = "0x186061210")]
	public MOFLLHMPNLH(int OKCCCLKDDPJ, int EHMJDPLLMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60610D0", Offset = "0x605FED0", VA = "0x1860610D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6061130", Offset = "0x605FF30", VA = "0x186061130")]
	public void ICLMOFPCEIP(MOFLLHMPNLH DIBJBLMKMCI, int IFPNNLKBOFG, int BKOJFCPJPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class HAKPIGOEJDJ
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static MOFLLHMPNLH EGABEOCHCFM;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static NativeList<PFMCIJLJJMA> HJFGNEGFMBP;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int[] AMCLIIHAOKM;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static bool JMILOKGEJFK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Dictionary<int, MOFLLHMPNLH> HHLDFINMFIA;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Dictionary<int, MOFLLHMPNLH> ANFCMFIJHGG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool HKFMELILIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x605E5A0", Offset = "0x605D3A0", VA = "0x18605E5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<PFMCIJLJJMA> HGDBPOPOEHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x605CFB0", Offset = "0x605BDB0", VA = "0x18605CFB0")]
		get
		{
			return default(NativeList<PFMCIJLJJMA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static MOFLLHMPNLH HILINFFCOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x605DF60", Offset = "0x605CD60", VA = "0x18605DF60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x605D4A0", Offset = "0x605C2A0", VA = "0x18605D4A0")]
	private static void EGCIKMKACKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x605E090", Offset = "0x605CE90", VA = "0x18605E090")]
	public static int IBLOLAOOHAO(bool HLEJFHCPECB, int LIGBANOJLFA, bool EJNHHPCHDMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x605E0C0", Offset = "0x605CEC0", VA = "0x18605E0C0")]
	private static int JFCEKNBHKNG(int LIGBANOJLFA, bool NLGPOFGCAPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x605D050", Offset = "0x605BE50", VA = "0x18605D050")]
	private static int BHKCMNPIDCG(int LIGBANOJLFA, bool NLGPOFGCAPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x605E170", Offset = "0x605CF70", VA = "0x18605E170")]
	public static int KENHHPFCLLP(int KEIPHEGFNFM, int LIGBANOJLFA, int FJIOJHGDPLJ, bool NLGPOFGCAPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x605E0E0", Offset = "0x605CEE0", VA = "0x18605E0E0")]
	public static int KELEKPNJHHA(int KEIPHEGFNFM, int LIGBANOJLFA, int FJIOJHGDPLJ, bool NLGPOFGCAPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x605D490", Offset = "0x605C290", VA = "0x18605D490")]
	public static int DPJKHHLKBCP(int FJIOJHGDPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x605DF50", Offset = "0x605CD50", VA = "0x18605DF50")]
	private static int GIHLBFKCKJE(int LIGBANOJLFA, bool NLGPOFGCAPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x605DF30", Offset = "0x605CD30", VA = "0x18605DF30")]
	private static int FFCMFOAHHEL(int LIGBANOJLFA, bool NLGPOFGCAPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x605DAB0", Offset = "0x605C8B0", VA = "0x18605DAB0")]
	public static int EOLMIHOJJMP(int KEIPHEGFNFM, int LIGBANOJLFA, int FJIOJHGDPLJ, bool NLGPOFGCAPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x605E000", Offset = "0x605CE00", VA = "0x18605E000")]
	public static int HLNEPCANIAI(int KEIPHEGFNFM, int LIGBANOJLFA, int FJIOJHGDPLJ, bool NLGPOFGCAPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x605E580", Offset = "0x605D380", VA = "0x18605E580")]
	public static int OHPCBLBFGBL(int FJIOJHGDPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x605D3A0", Offset = "0x605C1A0", VA = "0x18605D3A0")]
	public static MOFLLHMPNLH DOCPKPPPAIL(int LIGBANOJLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x605E2F0", Offset = "0x605D0F0", VA = "0x18605E2F0")]
	private static MOFLLHMPNLH MCLFGKHFOCK(int LIGBANOJLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x605E200", Offset = "0x605D000", VA = "0x18605E200")]
	public static MOFLLHMPNLH LAPOCJNNJPO(int LIGBANOJLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x605D060", Offset = "0x605BE60", VA = "0x18605D060")]
	private static MOFLLHMPNLH CPEMDNNNEPK(int LIGBANOJLFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x605DB20", Offset = "0x605C920", VA = "0x18605DB20")]
	public static void FCABCBLHNBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DFNKMDNLCBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int CCCFKCEJADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3 KBMPLFGNMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public quaternion MINBFBNDDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float KMEGAONJOGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float AEBCMBDDEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int NLLGBGNAADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int BDGDBNCMBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int NLBHDIGKCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool GPICAPBNELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool CAFBFIAPMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float EDDAPKMEHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 GDFMPAGOPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool GBBLNJEMCLI;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct FDHNNCJKNGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int DGADEFBBBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int NJFKAKBFHMH;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct OEMNDMDIHBO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<DFNKMDNLCBK> IJNFLHCEJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<JIIOCPIGNAG> NDOFPANCGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeArray<PFMCIJLJJMA> CADJFCHBGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<FDHNNCJKNGP> EKAIBAKBDGM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x60613C0", Offset = "0x60601C0", VA = "0x1860613C0")]
	public OEMNDMDIHBO(NativeArray<JIIOCPIGNAG> NDOFPANCGCB, int DDGPJFNNFJK = 1, Allocator MGPHHCICJPF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x60612D0", Offset = "0x60600D0", VA = "0x1860612D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct PIMIODNFGEN : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeArray<JNLGHFCFPEH> ENLCAJCLFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<int> NGFLFLDDBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<PFMCIJLJJMA> PCFMPIKLBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeList<DFNKMDNLCBK> IJNFLHCEJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<JIIOCPIGNAG> NDOFPANCGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<PFMCIJLJJMA> CADJFCHBGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	public NativeArray<FDHNNCJKNGP> EKAIBAKBDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private int DCCFJDOKJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private int BJENLEOGDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private float3 PLFAHBAAKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private quaternion DAOKHJBBOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private float3 FNJEPKNOEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BJOLNEOIBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FHHIJGHEPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PJLBAGCIAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JHAEGPBLFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> BLAJFPKELBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EPGFDEAGOBC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6064E90", Offset = "0x6063C90", VA = "0x186064E90")]
	public PIMIODNFGEN(ABPIHCMGHHG FGABNPFGECC, GEAAJBLIKPP AOOGGOOKEPK, float3 LNILFPFHKCP, quaternion NEEHDPJHICF, float POMOIDIFAGA, int AJMBFGCHLPL = 0, int OCHKCLODFMI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6064C60", Offset = "0x6063A60", VA = "0x186064C60")]
	public PIMIODNFGEN(OEMNDMDIHBO FGABNPFGECC, GEAAJBLIKPP AOOGGOOKEPK, float3 LNILFPFHKCP, quaternion NEEHDPJHICF, float3 POMOIDIFAGA, int AJMBFGCHLPL = 0, int OCHKCLODFMI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6064070", Offset = "0x6062E70", VA = "0x186064070")]
	private float3 JMFBFBIHHFF(float3 LNOCDBADHFG, Matrix4x4 PCEPNMAPBLI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6063FF0", Offset = "0x6062DF0", VA = "0x186063FF0")]
	private float3x3 FLCDCBGMCGC(float3x3 EILMNGMCFCI, float3x3 GEGAKGPGJJK)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60641A0", Offset = "0x6062FA0", VA = "0x1860641A0")]
	private float LICPOGHCCJE(float NANBGKEHFBG, float IABHGHIMIHG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6062E50", Offset = "0x6061C50", VA = "0x186062E50", Slot = "4")]
	public void Execute(int PKGDCCCLANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6062CE0", Offset = "0x6061AE0", VA = "0x186062CE0")]
	private void DKLIDBKNEIP(int HCIBHAABOBG, float3 JCOIMLJCHFJ, float3 NPJIMHPPOGG, float3 EHJGJPELCNI, float LLPCJKICLFP, bool DCPGPICJMON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60641B0", Offset = "0x6062FB0", VA = "0x1860641B0")]
	private void MIBAAAEPLOA(DFNKMDNLCBK PEDNDPPPONK, float3 OBIONJJHEHM, float3x3 MMKDNLHLGPC, float NANBGKEHFBG, int EOBCOCKDGHB, int NLCBCPMDEMI, int CKCNABBDDPL, float LDDFEDEOICJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6064610", Offset = "0x6063410", VA = "0x186064610")]
	private void PCLPGDKGBME(int HCIBHAABOBG, int DMNCNIOCGNF, DFNKMDNLCBK PEDNDPPPONK, float3 OBIONJJHEHM, float3x3 MMKDNLHLGPC, bool NIOINEOOLPH, float NANBGKEHFBG, int KEPJDFMGCIN, int DMCPBFMAMKD, int CKCNABBDDPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BJLIKGPKKHC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeList<FKGBFIHOAFH> GJGDIDLCIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeList<PFMCIJLJJMA> NEOIDHNEBHF;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6057250", Offset = "0x6056050", VA = "0x186057250")]
	public BJLIKGPKKHC(int DDGPJFNNFJK, Allocator MGPHHCICJPF = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x60571B0", Offset = "0x6055FB0", VA = "0x1860571B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct OLMPPPIKCMH : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private enum LNPOFOLOKPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private NativeList<float3> LOBHGHMJOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private NativeArray<float3> KOKKEIJAMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	[ReadOnly]
	private NativeList<int> PEHDANJFDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeArray<int> NEGHDHGBLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeArray<float4> MMHAFEKIAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private NativeArray<float4> LEGPPFKFHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private NativeArray<float4> LDGIJGKGHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> JPDEBDDDPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private NativeList<PFMCIJLJJMA> GMIBNDCANKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<FKGBFIHOAFH> GJGDIDLCIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<PFMCIJLJJMA> NEOIDHNEBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private int DCCFJDOKJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private int BJENLEOGDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BJOLNEOIBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FHHIJGHEPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PJLBAGCIAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JHAEGPBLFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> BLAJFPKELBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EPGFDEAGOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private float3 FNJEPKNOEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private quaternion DAOKHJBBOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private float3 PLFAHBAAKBI;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6062AF0", Offset = "0x60618F0", VA = "0x186062AF0")]
	public OLMPPPIKCMH(ABPIHCMGHHG FGABNPFGECC, GEAAJBLIKPP AOOGGOOKEPK, float3 LNILFPFHKCP, quaternion NEEHDPJHICF, float POMOIDIFAGA, int AJMBFGCHLPL = 0, int OCHKCLODFMI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6062900", Offset = "0x6061700", VA = "0x186062900")]
	public OLMPPPIKCMH(BJLIKGPKKHC OMHIFBJFAGA, GEAAJBLIKPP AOOGGOOKEPK, float3 LNILFPFHKCP, quaternion NEEHDPJHICF, float3 POMOIDIFAGA, int AJMBFGCHLPL = 0, int OCHKCLODFMI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6061560", Offset = "0x6060360", VA = "0x186061560", Slot = "4")]
	public void Execute(int PKGDCCCLANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x60624C0", Offset = "0x60612C0", VA = "0x1860624C0")]
	private void GMDCCAJKCAP(float4x4 ECPGDAINGIF, int PKGDCCCLANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x60614F0", Offset = "0x60602F0", VA = "0x1860614F0")]
	private LNPOFOLOKPM DHNBIKNNAIA(float3 NPJIMHPPOGG)
	{
		return default(LNPOFOLOKPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x60628B0", Offset = "0x60616B0", VA = "0x1860628B0")]
	private float4 NBHNKPFIPFG(LNPOFOLOKPM GAEADBNOBDA, int ENPOKNEMOMH)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6062870", Offset = "0x6061670", VA = "0x186062870")]
	private float2 MOLPEGNNNMP(LNPOFOLOKPM GAEADBNOBDA, float3 JCOIMLJCHFJ)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BCEDDLKONIN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum MGDGKFBPENI
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static BCEDDLKONIN NJBMLHJLPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float3 CDFOMBDMAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3x3 DMOAIFFPMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 MLMGACONFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public MGDGKFBPENI KKPIOFNDDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 CKJMBMGGHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 AEGMNDJGFCA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool MEKBGLMALDK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6056800", Offset = "0x6055600", VA = "0x186056800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 ONNDDMNILLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6056520", Offset = "0x6055320", VA = "0x186056520")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6056C00", Offset = "0x6055A00", VA = "0x186056C00")]
	public BCEDDLKONIN(float3 JCOIMLJCHFJ, quaternion GJMDICOFEBG, float3 DDGPJFNNFJK, MGDGKFBPENI HFFNCGFKMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6056600", Offset = "0x6055400", VA = "0x186056600")]
	public float GOLNCHAPJLG(float3 OBIONJJHEHM, float OLOIIMEKKDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6056810", Offset = "0x6055610", VA = "0x186056810")]
	public bool JNIPEOEANLH(float3 NPJIMHPPOGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6056270", Offset = "0x6055070", VA = "0x186056270")]
	public void AHPLCAGLACP(float3 OHACEMPLJFP, float3x3 DGHOJGOKBMA, float IOEFLEHAINB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6056420", Offset = "0x6055220", VA = "0x186056420")]
	private void DAFOLKMMLPE(float3 MHCNCLONLOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6056900", Offset = "0x6055700", VA = "0x186056900")]
	public void PBCIAOIJHGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct BLMOLADDMNO : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeList<BCEDDLKONIN> OMHIFBJFAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeList<float3> PDKDMNLECGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeList<int> FHDFOIFJGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DKFANOAJDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<PFMCIJLJJMA> NEOIDHNEBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int ONJPNMAJMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int ENDGCKBKIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private float OLOIIMEKKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private float AOOCBBBNEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> CAEGKKALCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> MPGFGMIHPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> MOBPAJGHAKJ;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6057DE0", Offset = "0x6056BE0", VA = "0x186057DE0")]
	public BLMOLADDMNO(GEAAJBLIKPP CKIIGCAJEFJ, float HPDIIHJKLHM, int BKOJFCPJPEL, int EOBCOCKDGHB, NativeList<BCEDDLKONIN> OMHIFBJFAGA, NativeArray<int> DKFANOAJDOC, NativeList<PFMCIJLJJMA> NEOIDHNEBHF, PNHPNKAMAGD DJFMMHKGECB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6057400", Offset = "0x6056200", VA = "0x186057400", Slot = "4")]
	public void Execute(int MCPJGLNAGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6057340", Offset = "0x6056140", VA = "0x186057340")]
	private bool EIGHAJGEFOB(BCEDDLKONIN GCMDJKOKHCO, BCEDDLKONIN LGCDJBDIEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6057B40", Offset = "0x6056940", VA = "0x186057B40")]
	private bool IEFOHKJGNMG(BCEDDLKONIN DDIKBLEEKFK, int DANNDFKDGNN, int OPENPCFPBAC, int IAONNGHIMKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PNHPNKAMAGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public NativeArray<bool> HIALILBKELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeArray<int> OLJDIJLANLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> MGCGGAAIOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float> HBCGHOKOEHG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6065230", Offset = "0x6064030", VA = "0x186065230")]
	public void KLFFECAIJIF(int OKCCCLKDDPJ, int EHMJDPLLMJE, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6065120", Offset = "0x6063F20", VA = "0x186065120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6065140", Offset = "0x6063F40", VA = "0x186065140")]
	public void EMJKKLCOFHG(JobHandle PHKOIIDBFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public PNHPNKAMAGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[BurstCompile]
public struct BDAMBLGLMLN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeList<float3> PDKDMNLECGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<float3> AJKJHGFKGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<float4> NEGMHOMALDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<float2> PGANEGDPFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private NativeList<int> FHDFOIFJGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NJLNDPDOEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NativeArray<int> JMOGONEHNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[ReadOnly]
	private NativeArray<bool> CAEGKKALCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[ReadOnly]
	private NativeArray<bool> MPGFGMIHPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[ReadOnly]
	private int AJMBFGCHLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private int OCHKCLODFMI;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6057130", Offset = "0x6055F30", VA = "0x186057130")]
	public BDAMBLGLMLN(GEAAJBLIKPP CKIIGCAJEFJ, PNHPNKAMAGD DJFMMHKGECB, int OCHKCLODFMI = 0, int AJMBFGCHLPL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6056CF0", Offset = "0x6055AF0", VA = "0x186056CF0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60570D0", Offset = "0x6055ED0", VA = "0x1860570D0")]
	private void JOMEGAGJPBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class JOJIOMGGKOB
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x27601C0", Offset = "0x275EFC0", VA = "0x1827601C0")]
	public static bool KKEOCOENGIK<T>(NativeArray<T> AAKJIOEDOGA, int DDGPJFNNFJK, Allocator MGPHHCICJPF, NativeArrayOptions BAPOGPMCDNA = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2760300", Offset = "0x275F100", VA = "0x182760300")]
	public static bool KKEOCOENGIK<T>(NativeList<T> FOKGGJDBEOD, int DDGPJFNNFJK, Allocator MGPHHCICJPF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum CDKBKGKLIGO
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Force2
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface AMAEBDGJKGN
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LNGODMNGKAM(CDKBKGKLIGO KEIPHEGFNFM);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int KKCHBPKNFJL(CDKBKGKLIGO KEIPHEGFNFM);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds KKELLMEEFEN();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNKONPJCGDA(CDKBKGKLIGO KEIPHEGFNFM, ABPIHCMGHHG BGFOMOFODDE, int AGDIIKOFJHK = -1);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GEAAJBLIKPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const int KOFIKOJIDLG = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<float3> KEFFKHDBLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<float3> EKDKNDOFKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float4> CJOCFCNKGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float4> EHGGLGHKLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeArray<float2> AGFKDMOFHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<int> FKCOPGGANLI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool CHDBPBGLOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x605C670", Offset = "0x605B470", VA = "0x18605C670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int APDKACJPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x605C270", Offset = "0x605B070", VA = "0x18605C270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EOBPCLINPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x605CF70", Offset = "0x605BD70", VA = "0x18605CF70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool EPGGJBCFLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x605C3C0", Offset = "0x605B1C0", VA = "0x18605C3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x605C2B0", Offset = "0x605B0B0", VA = "0x18605C2B0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x605C7F0", Offset = "0x605B5F0", VA = "0x18605C7F0")]
	public void KLFFECAIJIF(int OKCCCLKDDPJ, int EHMJDPLLMJE, Allocator MGPHHCICJPF, bool EBMHGPEFLGE, bool EMDLCAJAGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x605CE90", Offset = "0x605BC90", VA = "0x18605CE90")]
	public void OMOKHOCKANJ(int OKCCCLKDDPJ, int EHMJDPLLMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x605CAB0", Offset = "0x605B8B0", VA = "0x18605CAB0", Slot = "6")]
	public bool LLAAMGAHIHD(Mesh CKIIGCAJEFJ, bool GIBAHAOKCEO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x605BC40", Offset = "0x605AA40", VA = "0x18605BC40")]
	public bool APGNJGGOJOI(Mesh CKIIGCAJEFJ, GEAAJBLIKPP CAIGIKLHEEH, bool GIBAHAOKCEO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x605C400", Offset = "0x605B200", VA = "0x18605C400")]
	public void ICLMOFPCEIP(GEAAJBLIKPP CKIIGCAJEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x605C6B0", Offset = "0x605B4B0", VA = "0x18605C6B0")]
	public GEAAJBLIKPP JLEDLPHOJFD(Allocator MGPHHCICJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x605C9C0", Offset = "0x605B7C0", VA = "0x18605C9C0")]
	public long KLNAPKILHPO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x605CF10", Offset = "0x605BD10", VA = "0x18605CF10")]
	public void PAEMGHKHBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public GEAAJBLIKPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FOCFLHLJPMD
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x60592F0", Offset = "0x60580F0", VA = "0x1860592F0")]
	public static void FCABCBLHNBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ENPDAEDNAJB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeList<float3> KEFFKHDBLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> EKDKNDOFKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<int> KHGIIBBCLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeArray<float4> DOAHPDEOJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<float4> AMOONEHIPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<float4> OBLCLOFKEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<float3> FDEHBHFGCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<int> FKCOPGGANLI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int APDKACJPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6057F00", Offset = "0x6056D00", VA = "0x186057F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int EOBPCLINPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6058820", Offset = "0x6057620", VA = "0x186058820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int OBPFNGHNLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6057F40", Offset = "0x6056D40", VA = "0x186057F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6058DE0", Offset = "0x6057BE0", VA = "0x186058DE0")]
	public ENPDAEDNAJB(int OKCCCLKDDPJ, int EHMJDPLLMJE, int OPLKBNJLGMC, Allocator MGPHHCICJPF = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6059000", Offset = "0x6057E00", VA = "0x186059000")]
	public ENPDAEDNAJB(Mesh CKIIGCAJEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6057F80", Offset = "0x6056D80", VA = "0x186057F80", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6058520", Offset = "0x6057320", VA = "0x186058520")]
	public void ICLMOFPCEIP(ENPDAEDNAJB CKIIGCAJEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6058090", Offset = "0x6056E90", VA = "0x186058090")]
	private void GICMPFPLLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6058860", Offset = "0x6057660", VA = "0x186058860")]
	private void POJHKEOMEOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PFMCIJLJJMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int EBGFBAELAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int APDKACJPMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public int BEFEFDJCHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int EOBPCLINPMO;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x118EFA0", Offset = "0x118DDA0", VA = "0x18118EFA0")]
	public PFMCIJLJJMA(int EOBCOCKDGHB, int KFOEOCOIBCG, int BKOJFCPJPEL, int KICAGGFEGDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HGMJMIMEOBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<PFMCIJLJJMA> OOFAFCNNABF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xB6E440", Offset = "0xB6D240", VA = "0x180B6E440")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<PFMCIJLJJMA>);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1C33E90", Offset = "0x1C32C90", VA = "0x181C33E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public ENPDAEDNAJB EIGBAIPFFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x605E800", Offset = "0x605D600", VA = "0x18605E800")]
	public HGMJMIMEOBG(IEnumerable<ENPDAEDNAJB> DCAEHJHBCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x605E790", Offset = "0x605D590", VA = "0x18605E790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum HFCINMOIJCM
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class LFMNIPLCPPH
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static NativeArray<float2> LKEEKIHLKGJ;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static NativeArray<float3> MJOPIGIKPAI;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static NativeArray<float4> DMCLCJFAOML;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static NativeArray<int> CGJAJDKKCJP;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x605EED0", Offset = "0x605DCD0", VA = "0x18605EED0")]
	public static void FCABCBLHNBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x605EFF0", Offset = "0x605DDF0", VA = "0x18605EFF0")]
	public static NativeArray<float2> LJKBAOPMBDJ(NativeArray<float2> PEMCNADPJEC, int HAONODHCKON, NativeArray<float2> PEHEFKMKDKH, int LJJEKGPCCCO)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x605F210", Offset = "0x605E010", VA = "0x18605F210")]
	public static NativeArray<float3> OMNJGPLPIDN(NativeArray<float3> PEMCNADPJEC, int HAONODHCKON, NativeArray<float3> PEHEFKMKDKH, int LJJEKGPCCCO)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x605F100", Offset = "0x605DF00", VA = "0x18605F100")]
	public static NativeArray<float4> NGJKNNLDDFD(NativeArray<float4> PEMCNADPJEC, int HAONODHCKON, NativeArray<float4> PEHEFKMKDKH, int LJJEKGPCCCO)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x605EDC0", Offset = "0x605DBC0", VA = "0x18605EDC0")]
	public static NativeArray<int> DFMKBKIAAJC(NativeArray<int> PEMCNADPJEC, int HAONODHCKON, NativeArray<int> PEHEFKMKDKH, int LJJEKGPCCCO)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x279C040", Offset = "0x279AE40", VA = "0x18279C040")]
	private static void BDDOBKCIIIJ<T>(NativeArray<T> AAKJIOEDOGA, int JPJAAIFDDPB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x279BF90", Offset = "0x279AD90", VA = "0x18279BF90")]
	private static void AFDNOJCPFEH<T>(NativeArray<T> PEMCNADPJEC, int HAONODHCKON, NativeArray<T> PEHEFKMKDKH, int LJJEKGPCCCO, NativeArray<T> BMPPJGKJFJC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AAOMHGDOOCC
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal enum EPBGPMEJCJB
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		Uninitialised,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		ExcludedNoLodNoMesh,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		ExcludedNoLodMeshData,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		ExcludedNoLodMeshDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		NoMesh,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		MeshLod0,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		MeshLod0WantsLod0Refresh,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		MeshLod0WantsRefresh,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		MeshLod0AllLodsInJob,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		MeshAllLods,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		MeshAllLodsWantsLod0Refresh,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		MeshAllLodsWantsRefresh
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class EGPGIOJEJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public GANMEJOIIOE CKIIGCAJEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int BHIDICEKCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int ENFCCFBNPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public float EAIDNEPMGLP;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6057EC0", Offset = "0x6056CC0", VA = "0x186057EC0")]
		public EGPGIOJEJIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6057E80", Offset = "0x6056C80", VA = "0x186057E80")]
		public void EMJKKLCOFHG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<AMAEBDGJKGN> HFOALDPPCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly EHEIKHGHOCA HBMHGMCFMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int KFOEOCOIBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int KICAGGFEGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool NPLEIBMMNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal bool EIDIDKDDKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	internal bool DDEAIFIMBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal EPBGPMEJCJB DCBJOKKHJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal float3 KOPJILIBILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	internal float3 IBIMOKIBBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal float CHBBNDOEBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal int OMKOOLNHKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	internal int DBBAHLLICCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int OICBHBPBDCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float JMBLBMBJDIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float DKOGPJCEDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int NNDLDKHMMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private long PMABAFKODBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private long KFBIPDGAANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private long MKAPHLBCKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int OPFDEIBHJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private GEAAJBLIKPP ELHAOJPPDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private int EKIKMGPHMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private List<EGPGIOJEJIB> KHAFNIPHPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal float AFENMDMHINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool MOOLMJECGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MAPILEBNPAI GIAIMNAFMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private JobHandle CNIAMKICICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	internal NativeArray<long> PMEFNLNOIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool GIHMPCBPJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private JobHandle FFIEKMBPJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private GEAAJBLIKPP ICFHIHCIJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform JGDHAPAGLHI;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh EIGBAIPFFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7A81E0", Offset = "0x7A6FE0", VA = "0x1807A81E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer HPEDIFGLNOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8190", Offset = "0x7A6F90", VA = "0x1807A8190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int IGANBOJAKMO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9B9F80", Offset = "0x9B8D80", VA = "0x1809B9F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int KDHDJOEPFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7DF400", Offset = "0x7DE200", VA = "0x1807DF400")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int APDKACJPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6050880", Offset = "0x604F680", VA = "0x186050880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<AMAEBDGJKGN> PBIFGIHFHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6054310", Offset = "0x6053110", VA = "0x186054310")]
	public void PHPNKEMLLAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6051C70", Offset = "0x6050A70", VA = "0x186051C70")]
	public void HJAHOHGFFJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x60506F0", Offset = "0x604F4F0", VA = "0x1860506F0")]
	public void ANDJLNFHKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6054320", Offset = "0x6053120", VA = "0x186054320")]
	public AAOMHGDOOCC(string OHHBGJPCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6051490", Offset = "0x6050290", VA = "0x186051490")]
	public void EMJKKLCOFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6052D70", Offset = "0x6051B70", VA = "0x186052D70")]
	public void MBNCBCPNGIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6051B20", Offset = "0x6050920", VA = "0x186051B20")]
	public void GAJAKJGPEAP(AMAEBDGJKGN AFOKBIDANDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x60525E0", Offset = "0x60513E0", VA = "0x1860525E0")]
	private void JGGODLCACOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x60507D0", Offset = "0x604F5D0", VA = "0x1860507D0")]
	public bool APALAKEAPLH(AMAEBDGJKGN AFOKBIDANDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6050CD0", Offset = "0x604FAD0", VA = "0x186050CD0")]
	public bool BOPPHNBAJLP(AMAEBDGJKGN AFOKBIDANDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6052C40", Offset = "0x6051A40", VA = "0x186052C40", Slot = "4")]
	public virtual void MBHECKOAPCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6051C00", Offset = "0x6050A00", VA = "0x186051C00")]
	public void GLEPBOCLPIM(Transform MAAHMMDDMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x60539E0", Offset = "0x60527E0", VA = "0x1860539E0")]
	public bool OAEEFJAEIGE(Transform MAAHMMDDMHI, [Out] bool EBICJEGEOJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x604F840", Offset = "0x604E640", VA = "0x18604F840")]
	public bool ACNAPEAJJOD(bool OOBAFKEAKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6054210", Offset = "0x6053010", VA = "0x186054210")]
	public void ODDFCJFODKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6053930", Offset = "0x6052730", VA = "0x186053930")]
	public bool NDCHBEKNJIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6051D80", Offset = "0x6050B80", VA = "0x186051D80")]
	public bool JCBFGLEOHFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x60542D0", Offset = "0x60530D0", VA = "0x1860542D0")]
	public bool PBNFPGEEOJA(Transform PFIKOEBPDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6050D30", Offset = "0x604FB30", VA = "0x186050D30")]
	public void CDDDEJMIILN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6052B50", Offset = "0x6051950", VA = "0x186052B50")]
	public bool KDIBIIBOEID(bool OOBAFKEAKEM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x604F7C0", Offset = "0x604E5C0", VA = "0x18604F7C0")]
	public void ABFBPGBMGKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6052C10", Offset = "0x6051A10", VA = "0x186052C10")]
	public void MABEIMFOLFN(GEAAJBLIKPP CKIIGCAJEFJ, int DADMKFNEBIG, float NMBGLOPMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6051D50", Offset = "0x6050B50", VA = "0x186051D50")]
	public void INDCBAFPFFN(GANMEJOIIOE CAJLJKCLDAK, int DADMKFNEBIG, float NMBGLOPMKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6052C00", Offset = "0x6051A00", VA = "0x186052C00")]
	public long KLNAPKILHPO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7B5E50", Offset = "0x7B4C50", VA = "0x1807B5E50")]
	public long IHPPAOGDHPN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6052850", Offset = "0x6051650", VA = "0x186052850")]
	public void JNDMCADFLAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xA165A0", Offset = "0xA153A0", VA = "0x180A165A0")]
	internal void AEPHIIJMGJN(EPBGPMEJCJB JJPABFJMCAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6052DC0", Offset = "0x6051BC0", VA = "0x186052DC0")]
	private void MKKDHKCFPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6051560", Offset = "0x6050360", VA = "0x186051560")]
	private float FNINLHMIDOF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6050FC0", Offset = "0x604FDC0", VA = "0x186050FC0")]
	public void EHGNPFCALOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x60542A0", Offset = "0x60530A0", VA = "0x1860542A0")]
	private void OKPBOAJMMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6050DE0", Offset = "0x604FBE0", VA = "0x186050DE0")]
	private void EBHIHJMLPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x60508A0", Offset = "0x604F6A0", VA = "0x1860508A0")]
	private void BOIIOEBGFED(GEAAJBLIKPP PKPBCDIOAPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6053700", Offset = "0x6052500", VA = "0x186053700")]
	private void NCKLNKBMBKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6052F10", Offset = "0x6051D10", VA = "0x186052F10")]
	private void MOKHMNFNCCJ(GEAAJBLIKPP CKIIGCAJEFJ, GANMEJOIIOE CAJLJKCLDAK, int DADMKFNEBIG, float NMBGLOPMKFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal struct MAPILEBNPAI : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct FCODPOEKHAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int CCPGAOJGPMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int NMIFJJGFGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int EIGNGMBBJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int OEFNEMINNPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int GJOMKNNHBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int AMLBBCOKJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int BHIDICEKCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int ENFCCFBNPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public float EAIDNEPMGLP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct FLKOCPDDADA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NativeArray<float3> KEFFKHDBLKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public NativeArray<float3> EKDKNDOFKEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public NativeArray<float4> CJOCFCNKGFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NativeArray<float4> EHGGLGHKLOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public NativeArray<float2> AGFKDMOFHJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public NativeArray<int> FKCOPGGANLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool MKIDCIGKGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int APDKACJPMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int EOBPCLINPMO;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6069890", Offset = "0x6068690", VA = "0x186069890")]
		public void KLFFECAIJIF(int OKCCCLKDDPJ, int EHMJDPLLMJE, Allocator MGPHHCICJPF, bool EMDLCAJAGJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6069640", Offset = "0x6068440", VA = "0x186069640")]
		public static FLKOCPDDADA HAHCOAEFMFF(GEAAJBLIKPP HAMFKMJEGLE)
		{
			return default(FLKOCPDDADA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6069580", Offset = "0x6068380", VA = "0x186069580")]
		public void EMJKKLCOFHG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<FCODPOEKHAG> IIAIJMPJAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private FLKOCPDDADA GPBCIBMMCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private FLKOCPDDADA PKPBCDIOAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private float3 LPKMGMBHFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float3 IKGBDJMLOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* AKFFGJBPJIO;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6060D80", Offset = "0x605FB80", VA = "0x186060D80")]
	public MAPILEBNPAI([In] List<AAOMHGDOOCC.EGPGIOJEJIB> LJLOOEFMOAE, [In] GEAAJBLIKPP DIODMGHBIKB, [In] AAOMHGDOOCC PMDDKKJCMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x605F790", Offset = "0x605E590", VA = "0x18605F790", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x605F4B0", Offset = "0x605E2B0", VA = "0x18605F4B0")]
	public void CCFBMJODDEB(List<AAOMHGDOOCC.EGPGIOJEJIB> CAOEJNMFIPG, [In] AAOMHGDOOCC PMDDKKJCMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x605F770", Offset = "0x605E570", VA = "0x18605F770")]
	private bool EOLIHPPAECC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x605F3E0", Offset = "0x605E1E0", VA = "0x18605F3E0")]
	private GANMEJOIIOE BOLAAPPKEEH(int CANLJIEMDMK, Allocator MGPHHCICJPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x605FAC0", Offset = "0x605E8C0", VA = "0x18605FAC0")]
	private void PFOMCCHNJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x605F7A0", Offset = "0x605E5A0", VA = "0x18605F7A0")]
	private FCODPOEKHAG IHAOGHIMCGE([In] FCODPOEKHAG EOOFHJNLPND, int LMKDNADDAOH, [In] NativeArray<int> FHDFOIFJGPB, [In] NativeArray<bool> MPGFGMIHPHF, NativeArray<int> GDMNFDIBBOE)
	{
		return default(FCODPOEKHAG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x605F320", Offset = "0x605E120", VA = "0x18605F320")]
	private static int BOGIPHAPKDB(NativeArray<int> FHDFOIFJGPB, int PAIPPBCLMAE, int HKJFIODEEPE, int IPGNLDFGNMB)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static readonly ProfilerMarker FJHCFLGMIFN;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly ProfilerMarker MNMDCIFHMLF;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly ProfilerMarker MHGFFEECHAE;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal const int BDDGFCGGBOE = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private Dictionary<Material, List<AAOMHGDOOCC>> KFDJIOOLANH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal List<AAOMHGDOOCC> IDOPBCNMKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private List<MeshRenderer> PEDPAAOPNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool HIELGEJJBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int JLPFLJHIJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private Dictionary<int, float> DHPIDOOMABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private Dictionary<int, Color> DJMIABLNFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<int, Vector4> EPLOBBGEADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private Dictionary<int, Matrix4x4> IFEIKADPMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private AAOMHGDOOCC DLJBLNOFNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Material DEJODIBNFKD;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> BBIBJBBHKLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int AJFIDAMIFFI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6069530", Offset = "0x6068330", VA = "0x186069530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6066950", Offset = "0x6065750", VA = "0x186066950")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6065810", Offset = "0x6064610", VA = "0x186065810")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6065630", Offset = "0x6064430", VA = "0x186065630")]
		public AAOMHGDOOCC AddToBatchedMesh(AMAEBDGJKGN PFLJMNOFDEE, Material CMHHFEPJBNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x60687D0", Offset = "0x60675D0", VA = "0x1860687D0")]
		public void RemoveFromBatchedMesh(AMAEBDGJKGN CKIIGCAJEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x60656D0", Offset = "0x60644D0", VA = "0x1860656D0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6068910", Offset = "0x6067710", VA = "0x186068910")]
		public void SetMaterialProperty(int LHOPDKBHFLC, Color OLDELFAHHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6068DA0", Offset = "0x6067BA0", VA = "0x186068DA0")]
		public void SetMaterialProperty(int LHOPDKBHFLC, float NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6068FC0", Offset = "0x6067DC0", VA = "0x186068FC0")]
		public void SetMaterialProperty(int LHOPDKBHFLC, Vector4 PFJPBNGOGDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6068B40", Offset = "0x6067940", VA = "0x186068B40")]
		public void SetMaterialProperty(int LHOPDKBHFLC, Matrix4x4 EEHLKGFBENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6065DE0", Offset = "0x6064BE0", VA = "0x186065DE0")]
		private void GFFKIIFGFHN(Renderer LAJADMHLOJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6065DD0", Offset = "0x6064BD0", VA = "0x186065DD0")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6065800", Offset = "0x6064600", VA = "0x186065800")]
		private void DOFOPLEKGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x60663D0", Offset = "0x60651D0", VA = "0x1860663D0")]
		private void GMPCFPPBJGJ(bool POFLPKHNEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6065420", Offset = "0x6064220", VA = "0x186065420")]
		private AAOMHGDOOCC AGIPEFJANJN(AMAEBDGJKGN CKIIGCAJEFJ, Material CMHHFEPJBNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6066C40", Offset = "0x6065A40", VA = "0x186066C40")]
		private AAOMHGDOOCC PLCDGJFNEDO(Material CMHHFEPJBNC, int IOKDPBKLJIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x60659D0", Offset = "0x60647D0", VA = "0x1860659D0")]
		private AAOMHGDOOCC EJNPMPLBKKJ(Material CMHHFEPJBNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x16B7920", Offset = "0x16B6720", VA = "0x1816B7920")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x60667F0", Offset = "0x60655F0", VA = "0x1860667F0")]
		public void MarkDirty(AMAEBDGJKGN CKIIGCAJEFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6067FF0", Offset = "0x6066DF0", VA = "0x186067FF0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x60667D0", Offset = "0x60655D0", VA = "0x1860667D0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6066E20", Offset = "0x6065C20", VA = "0x186066E20")]
		public void RebatchOptimally()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60692C0", Offset = "0x60680C0", VA = "0x1860692C0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class OOFNDJDFJCC
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static bool JJOCLFONJGP;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static Vector3 BAALFFPDCNK;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int ACFJBOLBMDJ;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int CLMEMDPFDLC;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int LEBHKGEKLNO;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int MJPEMIKGKON;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static List<BatchedMeshRenderer> EPJGHOPDPFD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool NCMMEOEJNKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6069B70", Offset = "0x6068970", VA = "0x186069B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x60699E0", Offset = "0x60687E0", VA = "0x1860699E0")]
	public static void AFGFMMMFKEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6069C30", Offset = "0x6068A30", VA = "0x186069C30")]
	public static void BPPJHICBECE(BatchedMeshRenderer DCICCPAEALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x606AE20", Offset = "0x6069C20", VA = "0x18606AE20")]
	public static void PONONHJDCJC(BatchedMeshRenderer DCICCPAEALP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6069F70", Offset = "0x6068D70", VA = "0x186069F70")]
	public static void JCBFGLEOHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x606AB90", Offset = "0x6069990", VA = "0x18606AB90")]
	public static void LFAHAMMCOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6069E80", Offset = "0x6068C80", VA = "0x186069E80")]
	public static int FBKJKGLJLHL()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LJGHIGMANCK<KeyType> : AAOMHGDOOCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Dictionary<KeyType, AMAEBDGJKGN> NNMLBILGBFB;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3BF78F0", Offset = "0x3BF66F0", VA = "0x183BF78F0")]
	public LJGHIGMANCK(string OHHBGJPCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3BF7700", Offset = "0x3BF6500", VA = "0x183BF7700")]
	public void GAJAKJGPEAP(KeyType JCMGBFKGKLO, AMAEBDGJKGN AFOKBIDANDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3BF7620", Offset = "0x3BF6420", VA = "0x183BF7620")]
	public bool FIIINHABNFH(KeyType JCMGBFKGKLO, AMAEBDGJKGN MILJBIAJPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3BF7750", Offset = "0x3BF6550", VA = "0x183BF7750")]
	public void GFKLOHCMCCB(KeyType JCMGBFKGKLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3BF78B0", Offset = "0x3BF66B0", VA = "0x183BF78B0", Slot = "4")]
	public override void MBHECKOAPCE()
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
