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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E7D80", Offset = "0x7E7180", VA = "0x1807E7D80")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GDBGKJFIPAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int FDOCPOCAICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 HNKMPCAHEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion INACHBHHGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 LNDOAOFFHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int KNLGFHNCIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int IGJMEEEPHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int PPKAMAIHPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float LJJFOMDALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 NCDFMNOMKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool IELGPFGLEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public MILFDLKIFBP PFBOFLKHEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 BEBCCBGPKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float LNGPPFBGBFI;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NBOEPFNINLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static CLDDKAJAGDJ NMCMFDKJONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<GDBGKJFIPAB> BMPKKNDDFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<HKIFHKFMLOC> EJLIMAGLGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<CHNKOBLMGKP> DNPDIOIMDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<ADKHNFAEHLC> FIHFCKJCIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<HKIFHKFMLOC> OEPKDPPHMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<JIBDPMPBIJJ> HIBEOCGBBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<ADKHNFAEHLC>> KHCABLHKOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<KNIMPINHKFF> MENNMNLJGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> ININCEDFBEL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int COAAALEKHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC6C3A0", Offset = "0xC6B7A0", VA = "0x180C6C3A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC6B0C0", Offset = "0xC6A4C0", VA = "0x180C6B0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BOFKIANMCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC6C3B0", Offset = "0xC6B7B0", VA = "0x180C6C3B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC6AB00", Offset = "0xC69F00", VA = "0x180C6AB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x62253D0", Offset = "0x62247D0", VA = "0x1862253D0")]
	public NBOEPFNINLL(int PONAGKHBAPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6224040", Offset = "0x6223440", VA = "0x186224040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6223880", Offset = "0x6222C80", VA = "0x186223880")]
	public void ALKBFJGPGJF(JobHandle IAOKDALFCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6224060", Offset = "0x6223460", VA = "0x186224060")]
	public void MBGNMEHCGMN(GDBGKJFIPAB FLKOGFDGJDF, KNIMPINHKFF JMFDNMCKODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6225290", Offset = "0x6224690", VA = "0x186225290")]
	public void POEGFPOKNCB(CHNKOBLMGKP FLKOGFDGJDF, NativeArray<ADKHNFAEHLC> IJIAGKMJPAB, int OJEOGFDOKKC, int ONDJDNNLLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6224280", Offset = "0x6223680", VA = "0x186224280")]
	public JobHandle NCBBEDLEBCM(PELBMAKIELE NPMAACCPBLE, CFCNFJKMFMJ MLLONOIMGDH, float3 FOBJFBCKFAI, quaternion KKHICBAABBF, float NENEBEKHAHJ, bool HDGFLPLBOGP, int KOALPENFJIG = 0, int KGDEDJJIKJN = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6223D00", Offset = "0x6223100", VA = "0x186223D00")]
	public static JobHandle DFIMFIBGOPJ(CLJMNDCDBPF ILDJMJAICEE, PELBMAKIELE NPMAACCPBLE, GDBGKJFIPAB FLKOGFDGJDF, JobHandle IAOKDALFCBL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6223A50", Offset = "0x6222E50", VA = "0x186223A50")]
	public static JobHandle DAKBIFEDNMO(DHAPMGAIOKJ ILDJMJAICEE, PELBMAKIELE NPMAACCPBLE, CHNKOBLMGKP FLKOGFDGJDF, NativeArray<ADKHNFAEHLC> IJIAGKMJPAB, int OJEOGFDOKKC, int ONDJDNNLLAH, JobHandle IAOKDALFCBL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DJLMMGLLLEC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct NKOJMHCEAIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half BAPCGGLGPPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort LGPPOOADGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte IPBCDHAKOHN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int OJEOGFDOKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int ONDJDNNLLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> MNGLCLLJAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> KKPGDOAKKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> DCNCAIPNLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> KBAOBMKHELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<NKOJMHCEAIM> AGAJGPHKPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> ONFKIBEICBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> ONGJPCKJJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 BLGKBCPFEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 FLODCBLKGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 IPDOHFPMFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 AJGLNFBCOJF;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long GJKIEJDDOKN;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long CKHLJPOBMHI;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float MDFLNBMCEIB;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool PGOMLBIIOJK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ADJGDHCDMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6217430", Offset = "0x6216830", VA = "0x186217430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6216DA0", Offset = "0x62161A0", VA = "0x186216DA0")]
	public void ALKBFJGPGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62180E0", Offset = "0x62174E0", VA = "0x1862180E0")]
	public static DJLMMGLLLEC HEJOOLMEDMH(Allocator ABAEADFKICB, PELBMAKIELE NLLKKECCJHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6217D10", Offset = "0x6217110", VA = "0x186217D10")]
	public static DJLMMGLLLEC HEJOOLMEDMH(Allocator ABAEADFKICB, NativeArray<float3> OEGIAAKMDHG, NativeArray<float3> KAGJBHFEMFL, NativeArray<float2> HKANHJJDJBH, NativeArray<float4> MDCNGKKFGPO, bool BKBBIEGFCID, NativeArray<float4> DKGLKNMJIKH, NativeArray<int> MALEHIJIACL, int OJEOGFDOKKC, int COFBNHODKHB, int ONDJDNNLLAH, int FIBLNKLOLLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6217470", Offset = "0x6216870", VA = "0x186217470")]
	public PELBMAKIELE GBHEJAELGPG(Allocator ABAEADFKICB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62187D0", Offset = "0x6217BD0", VA = "0x1862187D0")]
	public void JMBFGBJINDL(Mesh DJNFKIFDJHD, bool KNNFGDDGKGD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6218320", Offset = "0x6217720", VA = "0x186218320")]
	public long IANMIAHGDGI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6216C90", Offset = "0x6216090", VA = "0x186216C90")]
	private void AGDBFAAJIIO(int MEBJEAHFPML, int KMMNNOEABKO, Allocator ABAEADFKICB, bool PLKOAACFIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6217C80", Offset = "0x6217080", VA = "0x186217C80")]
	private float3 HEHDBBJHEMH(int DPLACKFNLNL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6219040", Offset = "0x6218440", VA = "0x186219040")]
	private void OGHGKFALNLJ(int DPLACKFNLNL, float3 PELDONBLJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x62184C0", Offset = "0x62178C0", VA = "0x1862184C0")]
	private float3 IIHOBGKGAFF(int DPLACKFNLNL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62173E0", Offset = "0x62167E0", VA = "0x1862173E0")]
	private void EJMFCNNPODL(int DPLACKFNLNL, float3 PELDONBLJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6217990", Offset = "0x6216D90", VA = "0x186217990")]
	private float4 GPCHKCILBCF(int DPLACKFNLNL)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6218A00", Offset = "0x6217E00", VA = "0x186218A00")]
	private void KPKOHEGCNKN(int DPLACKFNLNL, float4 PELDONBLJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6217380", Offset = "0x6216780", VA = "0x186217380")]
	private float2 DFKOGAEIDEG(int DPLACKFNLNL)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x62183B0", Offset = "0x62177B0", VA = "0x1862183B0")]
	private void IHIBNHHHKLD(int DPLACKFNLNL, float2 PELDONBLJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6218DB0", Offset = "0x62181B0", VA = "0x186218DB0")]
	private void NLNIIOPBCMM(NativeArray<float3> OEGIAAKMDHG, int FIBLNKLOLLH, int KMMNNOEABKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6218A80", Offset = "0x6217E80", VA = "0x186218A80")]
	private void LMIINAGPNAP(NativeArray<float3> KAGJBHFEMFL, int FIBLNKLOLLH, int KMMNNOEABKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6217A00", Offset = "0x6216E00", VA = "0x186217A00")]
	private void HEDIEDNHNCE(NativeArray<float2> HKANHJJDJBH, int FIBLNKLOLLH, int KMMNNOEABKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6218B00", Offset = "0x6217F00", VA = "0x186218B00")]
	private void LNHLFLDDNMA(NativeArray<float4> KGAKHOEGAIE, int FIBLNKLOLLH, int KMMNNOEABKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6216EA0", Offset = "0x62162A0", VA = "0x186216EA0")]
	private void BCCBKDFICCM(Allocator ABAEADFKICB, NativeArray<float4> MDCNGKKFGPO, int FIBLNKLOLLH, int KMMNNOEABKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6218BD0", Offset = "0x6217FD0", VA = "0x186218BD0")]
	private static void MBEMEBJNPEA(NativeArray<float4> KMKIDPPCHKD, NativeArray<NKOJMHCEAIM> ANONMKLGAAK, NativeArray<byte> HBLEOKCKFIG, int OJEOGFDOKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x62191F0", Offset = "0x62185F0", VA = "0x1862191F0")]
	private void OJPLDBOJNBO(Allocator ABAEADFKICB, NativeArray<int> MALEHIJIACL, int FIBLNKLOLLH, int KMMNNOEABKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6218500", Offset = "0x6217900", VA = "0x186218500")]
	private static NativeArray<byte> JADABODJPKC(Allocator ABAEADFKICB, NativeArray<int> MALEHIJIACL, int FBOCOODPAGE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6218D10", Offset = "0x6218110", VA = "0x186218D10")]
	private static void MDBKKALNFOP(NativeArray<int> GPIPOBBIGOG, NativeArray<byte> KBKHHCGCNML, int ONDJDNNLLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62188B0", Offset = "0x6217CB0", VA = "0x1862188B0")]
	private static float3 KOKOIEELBAA(ushort JFFAOPDEJND)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6216AD0", Offset = "0x6215ED0", VA = "0x186216AD0")]
	private static ushort AELHOJMGHHA(float3 PELDONBLJNO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public DJLMMGLLLEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GCLCMDKJPDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float2 JDFFMJCEGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float2 ALCMEJGKNJK;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CPOFLJDEBNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<GCLCMDKJPDF> BCBFIGNHLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<int> KDBLOMGJMAP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int COAAALEKHOH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BOFKIANMCJH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C6760", Offset = "0x7C5B60", VA = "0x1807C6760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6215400", Offset = "0x6214800", VA = "0x186215400")]
	public CPOFLJDEBNI(int MEBJEAHFPML, int KMMNNOEABKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x62153A0", Offset = "0x62147A0", VA = "0x1862153A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x62152C0", Offset = "0x62146C0", VA = "0x1862152C0")]
	public void ANLLJEFPKNH(CPOFLJDEBNI JDNJGDPNBIK, int OKFGILOOGBP, int CAIMMNKGOCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class AHIHPIGIAGF
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static CPOFLJDEBNI FDHNECLBGDD;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static NativeList<HKIFHKFMLOC> DFIDBGAMLBH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int[] PGPOAAEPOPO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static bool HOEPCJILDPK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Dictionary<int, CPOFLJDEBNI> NPCHPIFKCAB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Dictionary<int, CPOFLJDEBNI> DLOGMLMENGA;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool IALFFMJENAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62134C0", Offset = "0x62128C0", VA = "0x1862134C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<HKIFHKFMLOC> IFJCNHEJJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6213ED0", Offset = "0x62132D0", VA = "0x186213ED0")]
		get
		{
			return default(NativeList<HKIFHKFMLOC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static CPOFLJDEBNI LAOJKKGAALJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6213C90", Offset = "0x6213090", VA = "0x186213C90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6213550", Offset = "0x6212950", VA = "0x186213550")]
	private static void DBHLMAECMJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62143A0", Offset = "0x62137A0", VA = "0x1862143A0")]
	public static int KFOJKDHGEPJ(bool OFKDEABHGMP, int HJJOFMNIJBL, bool HFCJMLCANDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x62133B0", Offset = "0x62127B0", VA = "0x1862133B0")]
	private static int AJLOOHNNHDK(int HJJOFMNIJBL, bool EBGACKELBFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x62133A0", Offset = "0x62127A0", VA = "0x1862133A0")]
	private static int AEOMBHDIDBD(int HJJOFMNIJBL, bool EBGACKELBFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6213C00", Offset = "0x6213000", VA = "0x186213C00")]
	public static int GKECDDNHMCG(int EFFDMCNPFAB, int HJJOFMNIJBL, int OBEDLFFECHK, bool EBGACKELBFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6213B60", Offset = "0x6212F60", VA = "0x186213B60")]
	public static int EGIECFPOEPE(int EFFDMCNPFAB, int HJJOFMNIJBL, int OBEDLFFECHK, bool EBGACKELBFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6213BF0", Offset = "0x6212FF0", VA = "0x186213BF0")]
	public static int FPCLOFJHDAH(int OBEDLFFECHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6213540", Offset = "0x6212940", VA = "0x186213540")]
	private static int CPLPAFBBHNH(int HJJOFMNIJBL, bool EBGACKELBFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6213F70", Offset = "0x6213370", VA = "0x186213F70")]
	private static int JFJDKIMLDDJ(int HJJOFMNIJBL, bool EBGACKELBFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6214710", Offset = "0x6213B10", VA = "0x186214710")]
	public static int NPMOAOFPHIO(int EFFDMCNPFAB, int HJJOFMNIJBL, int OBEDLFFECHK, bool EBGACKELBFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6213D30", Offset = "0x6213130", VA = "0x186213D30")]
	public static int HIFADADJDGD(int EFFDMCNPFAB, int HJJOFMNIJBL, int OBEDLFFECHK, bool EBGACKELBFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6213DC0", Offset = "0x62131C0", VA = "0x186213DC0")]
	public static int HLHLCKKENJN(int OBEDLFFECHK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6213DE0", Offset = "0x62131E0", VA = "0x186213DE0")]
	public static CPOFLJDEBNI IEOECPEBOFN(int HJJOFMNIJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6213110", Offset = "0x6212510", VA = "0x186213110")]
	private static CPOFLJDEBNI ADDNINLDICF(int HJJOFMNIJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62133D0", Offset = "0x62127D0", VA = "0x1862133D0")]
	public static CPOFLJDEBNI BDKNNNPIAIG(int HJJOFMNIJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62143D0", Offset = "0x62137D0", VA = "0x1862143D0")]
	private static CPOFLJDEBNI MAHEDPMAHEN(int HJJOFMNIJBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6213F90", Offset = "0x6213390", VA = "0x186213F90")]
	public static void JJAGGAPHEFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct CHNKOBLMGKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int KEBEIJMEJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3 HNKMPCAHEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public quaternion INACHBHHGLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float LNDOAOFFHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float CBDNJGLFCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int KNLGFHNCIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int IGJMEEEPHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int PPKAMAIHPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool AIAKAFIKJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool CEMHIEFJBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float LJJFOMDALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 NCDFMNOMKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool NPAHKKDALOK;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct JIBDPMPBIJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int JDAAPDIBPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int PMIOHGGEONC;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct DHAPMGAIOKJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<CHNKOBLMGKP> AGJIMKHKDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<ADKHNFAEHLC> GGENJKMDPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeArray<HKIFHKFMLOC> DFHKMPOKLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<JIBDPMPBIJJ> FHKEOBFOCED;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x62169A0", Offset = "0x6215DA0", VA = "0x1862169A0")]
	public DHAPMGAIOKJ(NativeArray<ADKHNFAEHLC> GGENJKMDPMH, int HIAJHKACHMC = 1, Allocator ABAEADFKICB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x62168B0", Offset = "0x6215CB0", VA = "0x1862168B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct IMPAAGIGHLB : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeArray<GCLCMDKJPDF> GBNLKKPCMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<int> BGJGBIOCNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<HKIFHKFMLOC> NMFIPEHFDCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeList<CHNKOBLMGKP> AGJIMKHKDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<ADKHNFAEHLC> GGENJKMDPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<HKIFHKFMLOC> DFHKMPOKLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	public NativeArray<JIBDPMPBIJJ> FHKEOBFOCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private int AHKCHNJIIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private int KCCAELNJPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private float3 KGDJLILCKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private quaternion KFNLOAKJDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private float3 BHJHHHAEDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> IBBJPHBNECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MMNENLHLJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NMCPCDAINDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PGLIMMFHOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> FPANNHBONCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MEMBOPDPGBA;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6220D40", Offset = "0x6220140", VA = "0x186220D40")]
	public IMPAAGIGHLB(NBOEPFNINLL DPMNLLGFHPD, PELBMAKIELE DBKBHIILGAE, float3 DHMLHKOCJKC, quaternion EFEMKFAMCEJ, float OCGDNALCEKJ, int KOALPENFJIG = 0, int KGDEDJJIKJN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6220B10", Offset = "0x621FF10", VA = "0x186220B10")]
	public IMPAAGIGHLB(DHAPMGAIOKJ DPMNLLGFHPD, PELBMAKIELE DBKBHIILGAE, float3 DHMLHKOCJKC, quaternion EFEMKFAMCEJ, float3 OCGDNALCEKJ, int KOALPENFJIG = 0, int KGDEDJJIKJN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x62209E0", Offset = "0x621FDE0", VA = "0x1862209E0")]
	private float3 ONCAMMFGBOG(float3 GGAKFLPALFL, Matrix4x4 FJCDKFLNMBM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6220960", Offset = "0x621FD60", VA = "0x186220960")]
	private float3x3 OFKBOCOJBOM(float3x3 JPMJODBMIJE, float3x3 MLPLBEPJAED)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6220950", Offset = "0x621FD50", VA = "0x186220950")]
	private float HCEOBGCCFMP(float FHPLKKAFLOA, float ENOOIKIEJNJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x621F7B0", Offset = "0x621EBB0", VA = "0x18621F7B0", Slot = "4")]
	public void Execute(int IFCNELFPJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x621EB90", Offset = "0x621DF90", VA = "0x18621EB90")]
	private void BLIHDJFLNKI(int NCEHJNPHMJC, float3 CJBHLOLHNJP, float3 GCPIJELMKHI, float3 GOHAMNDEGFI, float BOGELENJKDJ, bool GPEECCBNLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x621ED00", Offset = "0x621E100", VA = "0x18621ED00")]
	private void CJHCDPEAFPJ(CHNKOBLMGKP EBGFAPJACKD, float3 OCAHEBEILLK, float3x3 BHKBINDHGLI, float FHPLKKAFLOA, int CLCNLIFFODK, int FACBIHNMNDF, int ACGLMCPDAGO, float OOAKLKDADOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x621F160", Offset = "0x621E560", VA = "0x18621F160")]
	private void COCFFMLBGEF(int NCEHJNPHMJC, int AAKEFLEACNA, CHNKOBLMGKP EBGFAPJACKD, float3 OCAHEBEILLK, float3x3 BHKBINDHGLI, bool JHMGFKCLDJE, float FHPLKKAFLOA, int FIANKKHLPCI, int MILACOIFODD, int ACGLMCPDAGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct CLJMNDCDBPF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeList<GDBGKJFIPAB> AKFLFGILIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeList<HKIFHKFMLOC> OEEILAALIHM;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x62151D0", Offset = "0x62145D0", VA = "0x1862151D0")]
	public CLJMNDCDBPF(int HIAJHKACHMC, Allocator ABAEADFKICB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6215130", Offset = "0x6214530", VA = "0x186215130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct OAPDFGMMIGG : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private enum NJIKNFCNJAM
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
	private NativeList<float3> KAPNIOPPKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private NativeArray<float3> PJAADHHDJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	[ReadOnly]
	private NativeList<int> FIMAEHAMEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeArray<int> NLOAACACMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeArray<float4> AFOCFPMMOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private NativeArray<float4> BGDAKNKPELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private NativeArray<float4> NOEPOGIOACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> AEAAHKBHJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private NativeList<HKIFHKFMLOC> KHLFLIIEHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<GDBGKJFIPAB> AKFLFGILIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<HKIFHKFMLOC> OEEILAALIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private int AHKCHNJIIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private int KCCAELNJPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> IBBJPHBNECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MMNENLHLJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NMCPCDAINDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PGLIMMFHOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> FPANNHBONCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MEMBOPDPGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private float3 BHJHHHAEDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private quaternion KFNLOAKJDME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private float3 KGDJLILCKPJ;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6227530", Offset = "0x6226930", VA = "0x186227530")]
	public OAPDFGMMIGG(NBOEPFNINLL DPMNLLGFHPD, PELBMAKIELE DBKBHIILGAE, float3 DHMLHKOCJKC, quaternion EFEMKFAMCEJ, float OCGDNALCEKJ, int KOALPENFJIG = 0, int KGDEDJJIKJN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6227720", Offset = "0x6226B20", VA = "0x186227720")]
	public OAPDFGMMIGG(CLJMNDCDBPF FLKOGFDGJDF, PELBMAKIELE DBKBHIILGAE, float3 DHMLHKOCJKC, quaternion EFEMKFAMCEJ, float3 OCGDNALCEKJ, int KOALPENFJIG = 0, int KGDEDJJIKJN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6226190", Offset = "0x6225590", VA = "0x186226190", Slot = "4")]
	public void Execute(int IFCNELFPJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6227180", Offset = "0x6226580", VA = "0x186227180")]
	private void JOCCLAELGAF(float4x4 KEFCOECEKCK, int IFCNELFPJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6226120", Offset = "0x6225520", VA = "0x186226120")]
	private NJIKNFCNJAM APOIMLIIPBD(float3 GCPIJELMKHI)
	{
		return default(NJIKNFCNJAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6227130", Offset = "0x6226530", VA = "0x186227130")]
	private float4 HOIEJEDKJED(NJIKNFCNJAM PPIFEDJBNKJ, int PMLKPJNGBAD)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x62270F0", Offset = "0x62264F0", VA = "0x1862270F0")]
	private float2 HEAKADMLDPM(NJIKNFCNJAM PPIFEDJBNKJ, float3 CJBHLOLHNJP)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct KNIMPINHKFF
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum GPBBPLHCJMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static KNIMPINHKFF CCDCOKAGGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float3 COHFCEILEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3x3 NMAJBJOMEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 JOOOJCLOMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public GPBBPLHCJMN HCHJICPCOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 IJOMELDKKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 KPFIKJJLOEO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JOKPAMMGCJH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x62217E0", Offset = "0x6220BE0", VA = "0x1862217E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 IFMMKKAIADP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6221470", Offset = "0x6220870", VA = "0x186221470")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6221960", Offset = "0x6220D60", VA = "0x186221960")]
	public KNIMPINHKFF(float3 CJBHLOLHNJP, quaternion APMJJPLCLEP, float3 HIAJHKACHMC, GPBBPLHCJMN NBMJAHOKHAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6220FD0", Offset = "0x62203D0", VA = "0x186220FD0")]
	public float AJBPMLNJCGG(float3 OCAHEBEILLK, float LAIIFDICPLH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6221380", Offset = "0x6220780", VA = "0x186221380")]
	public bool CNBDPMOPNEJ(float3 GCPIJELMKHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x62211D0", Offset = "0x62205D0", VA = "0x1862211D0")]
	public void BPDBMPBBHAB(float3 GFENEAGCGLC, float3x3 ECMCONIIPEJ, float KFNKBBMBHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x62217F0", Offset = "0x6220BF0", VA = "0x1862217F0")]
	private void NNOMGGCADFG(float3 AJNCJEIJBDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6221550", Offset = "0x6220950", VA = "0x186221550")]
	public void KFFNJBLJPLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct NPBLJNLPJLP : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeList<KNIMPINHKFF> FLKOGFDGJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeList<float3> MNGLCLLJAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeList<int> ONGJPCKJJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> ININCEDFBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<HKIFHKFMLOC> OEEILAALIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int JMJDBEPAMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int PGHIGGKHAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private float LAIIFDICPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private float IHJJBKAIEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> JGLALANKMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> GHPJKGMIAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> GNBKDLPMFNO;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6226080", Offset = "0x6225480", VA = "0x186226080")]
	public NPBLJNLPJLP(PELBMAKIELE DJNFKIFDJHD, float HNLIPMFIEIJ, int CAIMMNKGOCP, int CLCNLIFFODK, NativeList<KNIMPINHKFF> FLKOGFDGJDF, NativeArray<int> ININCEDFBEL, NativeList<HKIFHKFMLOC> OEEILAALIHM, CFCNFJKMFMJ MLLONOIMGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x62255E0", Offset = "0x62249E0", VA = "0x1862255E0", Slot = "4")]
	public void Execute(int CIIIFPAOGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6225FC0", Offset = "0x62253C0", VA = "0x186225FC0")]
	private bool NBHDIHCDNLI(KNIMPINHKFF HKHMJOHPMKP, KNIMPINHKFF GJKNLEMINPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6225D20", Offset = "0x6225120", VA = "0x186225D20")]
	private bool IAHOFOPFKCJ(KNIMPINHKFF MFNJPKAPFJG, int AAHCCLEIEMO, int HKPLLADLKLA, int HCJEGNEOLMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CFCNFJKMFMJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public NativeArray<bool> DJINOKDPOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeArray<int> MPCHIOAFHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> PPHHJCBDPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float> GLKAHFHLCEN;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x62148F0", Offset = "0x6213CF0", VA = "0x1862148F0")]
	public void AGDBFAAJIIO(int MEBJEAHFPML, int KMMNNOEABKO, Allocator ABAEADFKICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6214AE0", Offset = "0x6213EE0", VA = "0x186214AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x62149F0", Offset = "0x6213DF0", VA = "0x1862149F0")]
	public void ALKBFJGPGJF(JobHandle IAOKDALFCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public CFCNFJKMFMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[BurstCompile]
public struct GAJDHHDIGMD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeList<float3> MNGLCLLJAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<float3> KKPGDOAKKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<float4> AGAJGPHKPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<float2> KBAOBMKHELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private NativeList<int> ONGJPCKJJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DCNCAIPNLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NativeArray<int> KEPCHDLFAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[ReadOnly]
	private NativeArray<bool> JGLALANKMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[ReadOnly]
	private NativeArray<bool> GHPJKGMIAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[ReadOnly]
	private int KOALPENFJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private int KGDEDJJIKJN;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6219710", Offset = "0x6218B10", VA = "0x186219710")]
	public GAJDHHDIGMD(PELBMAKIELE DJNFKIFDJHD, CFCNFJKMFMJ MLLONOIMGDH, int KGDEDJJIKJN = 0, int KOALPENFJIG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62192D0", Offset = "0x62186D0", VA = "0x1862192D0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x62196B0", Offset = "0x6218AB0", VA = "0x1862196B0")]
	private void GAHDACGKMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class BFHNDHLLHGP
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x25B9680", Offset = "0x25B8A80", VA = "0x1825B9680")]
	public static bool PIEIOFAMDJJ<T>(NativeArray<T> KGECIFKDBHF, int HIAJHKACHMC, Allocator ABAEADFKICB, NativeArrayOptions ABKDMFHFFCD = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x25B9720", Offset = "0x25B8B20", VA = "0x1825B9720")]
	public static bool PIEIOFAMDJJ<T>(NativeList<T> OCAIIBKPIPH, int HIAJHKACHMC, Allocator ABAEADFKICB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum IPKLJNHJMNK
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
public interface BKEPMGIMHJB
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FMMBIENELEG(IPKLJNHJMNK EFFDMCNPFAB);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BHDCGIMJNKL(IPKLJNHJMNK EFFDMCNPFAB);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds MFHJPAOEHFM();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLMNGIJENMC(IPKLJNHJMNK EFFDMCNPFAB, NBOEPFNINLL GIPPPPOOLKA, int DGPDNNMEMLE = -1);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PELBMAKIELE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const int NEJMBJCEBHG = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<float3> HHCAFCGFHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<float3> OPILMPBGBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float4> HJGPLMBPAAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float4> IPOPDFDBDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeArray<float2> GJGNBHLFAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<int> AILABFKLJPN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LPBPADBNJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x62285B0", Offset = "0x62279B0", VA = "0x1862285B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int COAAALEKHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6228570", Offset = "0x6227970", VA = "0x186228570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int BOFKIANMCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6227AE0", Offset = "0x6226EE0", VA = "0x186227AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool ADJGDHCDMEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6227EA0", Offset = "0x62272A0", VA = "0x186227EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6227D90", Offset = "0x6227190", VA = "0x186227D90", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6227910", Offset = "0x6226D10", VA = "0x186227910")]
	public void AGDBFAAJIIO(int MEBJEAHFPML, int KMMNNOEABKO, Allocator ABAEADFKICB, bool JLNLPFIOACH, bool PLKOAACFIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6228020", Offset = "0x6227420", VA = "0x186228020")]
	public void GJEBGIHKLNM(int MEBJEAHFPML, int KMMNNOEABKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62280A0", Offset = "0x62274A0", VA = "0x1862280A0", Slot = "6")]
	public bool HPJKPHICMOC(Mesh DJNFKIFDJHD, bool KNNFGDDGKGD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6228650", Offset = "0x6227A50", VA = "0x186228650")]
	public bool OKAKAKAHEGG(Mesh DJNFKIFDJHD, PELBMAKIELE IGNNABLPJKN, bool KNNFGDDGKGD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6227B20", Offset = "0x6226F20", VA = "0x186227B20")]
	public void ANLLJEFPKNH(PELBMAKIELE DJNFKIFDJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6227EE0", Offset = "0x62272E0", VA = "0x186227EE0")]
	public PELBMAKIELE GEAKIBIKCED(Allocator ABAEADFKICB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6228480", Offset = "0x6227880", VA = "0x186228480")]
	public long IANMIAHGDGI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x62285F0", Offset = "0x62279F0", VA = "0x1862285F0")]
	public void OGIPNGLIMNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public PELBMAKIELE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class GMIKHAKDIHE
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x621EA40", Offset = "0x621DE40", VA = "0x18621EA40")]
	public static void JJAGGAPHEFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DFMBEDBOOHM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeList<float3> HHCAFCGFHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> OPILMPBGBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<int> MKDLFLIEDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeArray<float4> OAAGAIPJCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<float4> IPIKLDPCMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<float4> CHEINGBHCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<float3> NJGMHOGHKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<int> AILABFKLJPN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int COAAALEKHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6216360", Offset = "0x6215760", VA = "0x186216360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BOFKIANMCJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6215950", Offset = "0x6214D50", VA = "0x186215950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KOLAAMDDNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6215C90", Offset = "0x6215090", VA = "0x186215C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x62163A0", Offset = "0x62157A0", VA = "0x1862163A0")]
	public DFMBEDBOOHM(int MEBJEAHFPML, int KMMNNOEABKO, int LDHLFIGIODK, Allocator ABAEADFKICB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62165C0", Offset = "0x62159C0", VA = "0x1862165C0")]
	public DFMBEDBOOHM(Mesh DJNFKIFDJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6215CD0", Offset = "0x62150D0", VA = "0x186215CD0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6215990", Offset = "0x6214D90", VA = "0x186215990")]
	public void ANLLJEFPKNH(DFMBEDBOOHM DJNFKIFDJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x62154C0", Offset = "0x62148C0", VA = "0x1862154C0")]
	private void AFDNMLGKEGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6215DE0", Offset = "0x62151E0", VA = "0x186215DE0")]
	private void IHLAACPLBBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HKIFHKFMLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int JELIANAGAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int COAAALEKHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public int EPEHCEBPNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int BOFKIANMCJH;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1234630", Offset = "0x1233A30", VA = "0x181234630")]
	public HKIFHKFMLOC(int CLCNLIFFODK, int OJEOGFDOKKC, int CAIMMNKGOCP, int ONDJDNNLLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class CLDDKAJAGDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<HKIFHKFMLOC> GLPBMALDHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8516A0", Offset = "0x850AA0", VA = "0x1808516A0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<HKIFHKFMLOC>);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x851500", Offset = "0x850900", VA = "0x180851500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DFMBEDBOOHM HPCIACOJACH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6214B70", Offset = "0x6213F70", VA = "0x186214B70")]
	public CLDDKAJAGDJ(IEnumerable<DFMBEDBOOHM> KLCGBCDEFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6214B00", Offset = "0x6213F00", VA = "0x186214B00", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum MILFDLKIFBP
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class GJGODDKGIIB
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static NativeArray<float2> GBFDDNEHOPI;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static NativeArray<float3> ALEHKMEMCEM;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static NativeArray<float4> LBBIIPGMJNJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static NativeArray<int> HOIGAEALBBK;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x621E810", Offset = "0x621DC10", VA = "0x18621E810")]
	public static void JJAGGAPHEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x621E5F0", Offset = "0x621D9F0", VA = "0x18621E5F0")]
	public static NativeArray<float2> DIMKBICJGDN(NativeArray<float2> FGMNKPKCFIN, int AIGHJFLBPOE, NativeArray<float2> FOHLAPCIBHE, int CILOGFKGGLE)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x621E700", Offset = "0x621DB00", VA = "0x18621E700")]
	public static NativeArray<float3> HDKBLLAGKDO(NativeArray<float3> FGMNKPKCFIN, int AIGHJFLBPOE, NativeArray<float3> FOHLAPCIBHE, int CILOGFKGGLE)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x621E930", Offset = "0x621DD30", VA = "0x18621E930")]
	public static NativeArray<float4> KNJLBDONKLN(NativeArray<float4> FGMNKPKCFIN, int AIGHJFLBPOE, NativeArray<float4> FOHLAPCIBHE, int CILOGFKGGLE)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x621E4E0", Offset = "0x621D8E0", VA = "0x18621E4E0")]
	public static NativeArray<int> BHNALGMCGKP(NativeArray<int> FGMNKPKCFIN, int AIGHJFLBPOE, NativeArray<int> FOHLAPCIBHE, int CILOGFKGGLE)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x27E9D70", Offset = "0x27E9170", VA = "0x1827E9D70")]
	private static void LOBDKCLEDCE<T>(NativeArray<T> KGECIFKDBHF, int OCMNAJKBIJD) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x27E9CC0", Offset = "0x27E90C0", VA = "0x1827E9CC0")]
	private static void JMAOGPIOBIJ<T>(NativeArray<T> FGMNKPKCFIN, int AIGHJFLBPOE, NativeArray<T> FOHLAPCIBHE, int CILOGFKGGLE, NativeArray<T> OCNHJHPMCPF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GDAIKOPKIMH
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal enum JFDKEANPHJL
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
	public class LGMEODKJIIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public DJLMMGLLLEC DJNFKIFDJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int PKOFMMBJFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int IFCEOOMECDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public float MAFHIMPMMAO;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6221A90", Offset = "0x6220E90", VA = "0x186221A90")]
		public LGMEODKJIIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6221A50", Offset = "0x6220E50", VA = "0x186221A50")]
		public void ALKBFJGPGJF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<BKEPMGIMHJB> IBONOHEEFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly LKGPDLCIFPA ABOLGCDAHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int OJEOGFDOKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int ONDJDNNLLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool PJHDONJJPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal bool NHHBHIBEMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	internal bool MEIFFEMBMFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal JFDKEANPHJL KDDFGNJPJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal float3 NOCAHBDMIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	internal float3 PHCLDCIANIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal float GIEBEINEHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal int LDMKFNPJCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	internal int JEFABLHABBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int OOOMKJONDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float HPHJJBMONJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float CGNOLNFEBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int BMJJAIGBCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private long CLHNCDJDLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private long JMBGPPIBLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private long ECKKLMJGEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int FDDCBHFKBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PELBMAKIELE HLJOLDJLIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private int EDPEBLNIJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private List<LGMEODKJIIM> BFOPGONGDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal float JIGOMGLDHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool MFBKJKFCGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private MEEIAINNFNH HMFCKMHGEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private JobHandle HKMOOIEEDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	internal NativeArray<long> AFGPAAKJDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool PGDAGPDANAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private JobHandle IJFFBHEICED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private PELBMAKIELE ABMLMLPHGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform IOMJNFGDFPG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh HPCIACOJACH
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A80", Offset = "0x7BFE80", VA = "0x1807C0A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer HEOKIFIFBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F80", Offset = "0x7C1380", VA = "0x1807C1F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int JKJDCHHGNKF
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA30F20", Offset = "0xA30320", VA = "0x180A30F20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int POBBFOLEFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E80", Offset = "0x7F3280", VA = "0x1807F3E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int COAAALEKHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x621D7E0", Offset = "0x621CBE0", VA = "0x18621D7E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<BKEPMGIMHJB> LCEDNKJIENM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6219790", Offset = "0x6218B90", VA = "0x186219790")]
	public void ADNFJNFOINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x621BD20", Offset = "0x621B120", VA = "0x18621BD20")]
	public void LDNEIJGBOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x621E1A0", Offset = "0x621D5A0", VA = "0x18621E1A0")]
	public void PNGEFCBDMMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x621E2F0", Offset = "0x621D6F0", VA = "0x18621E2F0")]
	public GDAIKOPKIMH(string CCNKHEJHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6219880", Offset = "0x6218C80", VA = "0x186219880")]
	public void ALKBFJGPGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x621B410", Offset = "0x621A810", VA = "0x18621B410")]
	public void IOGMKLDDCBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x62197A0", Offset = "0x6218BA0", VA = "0x1862197A0")]
	public void AKHMPPDJDDD(BKEPMGIMHJB LCLKLNOMGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x621A850", Offset = "0x6219C50", VA = "0x18621A850")]
	private void FDIBLFNOFBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x621E0F0", Offset = "0x621D4F0", VA = "0x18621E0F0")]
	public bool PKGFEIHEOOL(BKEPMGIMHJB LCLKLNOMGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x621BCC0", Offset = "0x621B0C0", VA = "0x18621BCC0")]
	public bool LBFIBDMBLKM(BKEPMGIMHJB LCLKLNOMGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x621DFC0", Offset = "0x621D3C0", VA = "0x18621DFC0", Slot = "4")]
	public virtual void PCECHJPIFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x621E280", Offset = "0x621D680", VA = "0x18621E280")]
	public void POEHNIBFIKO(Transform HHFOBPJAPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x621BE00", Offset = "0x621B200", VA = "0x18621BE00")]
	public bool LHMCAEJJGIN(Transform HHFOBPJAPDP, [Out] bool MKNGCLCEGHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x621C930", Offset = "0x621BD30", VA = "0x18621C930")]
	public bool LLGDEDMGJFC(bool KIHFEDJJDIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x621A7C0", Offset = "0x6219BC0", VA = "0x18621A7C0")]
	public void EFCOLDKPBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x621AB70", Offset = "0x6219F70", VA = "0x18621AB70")]
	public bool IDJDCAKDNPK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x621B460", Offset = "0x621A860", VA = "0x18621B460")]
	public bool JLAHAONMIIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x621AAF0", Offset = "0x6219EF0", VA = "0x18621AAF0")]
	public bool GGPPMDMOAOO(Transform KDNNBEIJOEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x621DF10", Offset = "0x621D310", VA = "0x18621DF10")]
	public void OMICJJFDHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6219950", Offset = "0x6218D50", VA = "0x186219950")]
	public bool AOICIFBKDBP(bool KIHFEDJJDIF = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x621A090", Offset = "0x6219490", VA = "0x18621A090")]
	public void CPAKMGOKGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x621AAC0", Offset = "0x6219EC0", VA = "0x18621AAC0")]
	public void GBCLFPBBMMN(PELBMAKIELE DJNFKIFDJHD, int PMCLCHIJAEC, float NIOOIBPANGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6219E30", Offset = "0x6219230", VA = "0x186219E30")]
	public void BNKGMNHMJHE(DJLMMGLLLEC PBHFPKCCPHA, int PMCLCHIJAEC, float NIOOIBPANGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x621AB60", Offset = "0x6219F60", VA = "0x18621AB60")]
	public long IANMIAHGDGI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C5650", Offset = "0x7C4A50", VA = "0x1807C5650")]
	public long HBLKBCOGHGM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x621C630", Offset = "0x621BA30", VA = "0x18621C630")]
	public void LKDGDPMAIBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xA8B150", Offset = "0xA8A550", VA = "0x180A8B150")]
	internal void DEHDBHFBIPM(JFDKEANPHJL MIMCACJGDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x621D800", Offset = "0x621CC00", VA = "0x18621D800")]
	private void NALJMOLCGAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x621D950", Offset = "0x621CD50", VA = "0x18621D950")]
	private float OBOJEHHGNJD()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x621A110", Offset = "0x6219510", VA = "0x18621A110")]
	public void DEHINGPBNJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x621AB30", Offset = "0x6219F30", VA = "0x18621AB30")]
	private void GNOCMDOFMKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x621A5E0", Offset = "0x62199E0", VA = "0x18621A5E0")]
	private void DONKJCPMFAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6219A00", Offset = "0x6218E00", VA = "0x186219A00")]
	private void BKMBEMHKCNM(PELBMAKIELE HDLLOFENEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6219E60", Offset = "0x6219260", VA = "0x186219E60")]
	private void BPFNLFEKLOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x621AC20", Offset = "0x621A020", VA = "0x18621AC20")]
	private void IJMDNLNCIEB(PELBMAKIELE DJNFKIFDJHD, DJLMMGLLLEC PBHFPKCCPHA, int PMCLCHIJAEC, float NIOOIBPANGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal struct MEEIAINNFNH : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct JMENCJCLHND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int HKHNPNOEBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int NAKNHHOCCIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int PDELBPDCOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int KDHMJBIONEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int JNDCMNHDHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int NANCKDPCNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int PKOFMMBJFEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int IFCEOOMECDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public float MAFHIMPMMAO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct CHBKPLIEMFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NativeArray<float3> HHCAFCGFHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public NativeArray<float3> OPILMPBGBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public NativeArray<float4> HJGPLMBPAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NativeArray<float4> IPOPDFDBDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public NativeArray<float2> GJGNBHLFAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public NativeArray<int> AILABFKLJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool BKBBIEGFCID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int COAAALEKHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int BOFKIANMCJH;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x622CEF0", Offset = "0x622C2F0", VA = "0x18622CEF0")]
		public void AGDBFAAJIIO(int MEBJEAHFPML, int KMMNNOEABKO, Allocator ABAEADFKICB, bool PLKOAACFIJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x622D040", Offset = "0x622C440", VA = "0x18622D040")]
		public static CHBKPLIEMFK AKKOPPGFDLA(PELBMAKIELE PPKEPEHJANL)
		{
			return default(CHBKPLIEMFK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x622D290", Offset = "0x622C690", VA = "0x18622D290")]
		public void ALKBFJGPGJF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<JMENCJCLHND> HLCOCENBFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private CHBKPLIEMFK ACNKCOOOFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private CHBKPLIEMFK HDLLOFENEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private float3 BOCLOGOOOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float3 LFEDBFCJFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* EOPLAMBLEMH;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6223530", Offset = "0x6222930", VA = "0x186223530")]
	public MEEIAINNFNH([In] List<GDAIKOPKIMH.LGMEODKJIIM> COPEFEHAPCC, [In] PELBMAKIELE EEDHCEEHPBA, [In] GDAIKOPKIMH LNGHBOFFKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6223050", Offset = "0x6222450", VA = "0x186223050", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6221AD0", Offset = "0x6220ED0", VA = "0x186221AD0")]
	public void CGCCGLMBGFC(List<GDAIKOPKIMH.LGMEODKJIIM> IPKACFKFCEL, [In] GDAIKOPKIMH LNGHBOFFKIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x62231F0", Offset = "0x62225F0", VA = "0x1862231F0")]
	private bool HNJMAHNMPOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6223060", Offset = "0x6222460", VA = "0x186223060")]
	private DJLMMGLLLEC FHKNGEMCFIA(int PKNLJJAJANB, Allocator ABAEADFKICB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6221D90", Offset = "0x6221190", VA = "0x186221D90")]
	private void DJHJDIDHAOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6223210", Offset = "0x6222610", VA = "0x186223210")]
	private JMENCJCLHND LFLPHDHIBJB([In] JMENCJCLHND FCKICAHMJFF, int OCNNIJIGAHC, [In] NativeArray<int> ONGJPCKJJDA, [In] NativeArray<bool> GHPJKGMIAIC, NativeArray<int> GPDMBHCNJJF)
	{
		return default(JMENCJCLHND);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6223130", Offset = "0x6222530", VA = "0x186223130")]
	private static int GBHDMAEOJKN(NativeArray<int> ONGJPCKJJDA, int PEDGFNABCMC, int DFJLDBKGKIO, int DGJGPPJBBBM)
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
		private static readonly ProfilerMarker INGOLKBLBNK;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly ProfilerMarker NBJFDMKBLCP;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly ProfilerMarker AEFPKKOCDDO;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal const int LJAGHGIBNAO = 65000;

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
		private Dictionary<Material, List<GDAIKOPKIMH>> PJCAFOOJHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal List<GDAIKOPKIMH> OOLNBHKHBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private List<MeshRenderer> BIIPDAHHJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool PAHDELNFGPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int MEAAFNFMOLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private Dictionary<int, float> KEMLAJOLJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private Dictionary<int, Color> CKDNOBPIPNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<int, Vector4> CIHPCNFEILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private Dictionary<int, Matrix4x4> KIPONOFPFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private GDAIKOPKIMH NHBNKBKBMAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Material KPHIGOEOOAP;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> JNNDFHHNOAI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int FEALMJGIBME
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x622CEA0", Offset = "0x622C2A0", VA = "0x18622CEA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x622A4A0", Offset = "0x62298A0", VA = "0x18622A4A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6229350", Offset = "0x6228750", VA = "0x186229350")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6228D70", Offset = "0x6228170", VA = "0x186228D70")]
		public GDAIKOPKIMH AddToBatchedMesh(BKEPMGIMHJB KJEBKDIDAJJ, Material GDFHEJJFPNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x622C140", Offset = "0x622B540", VA = "0x18622C140")]
		public void RemoveFromBatchedMesh(BKEPMGIMHJB DJNFKIFDJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6229020", Offset = "0x6228420", VA = "0x186229020")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x622C280", Offset = "0x622B680", VA = "0x18622C280")]
		public void SetMaterialProperty(int JCGBIDKEGML, Color MAOKDDLICOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x622C710", Offset = "0x622BB10", VA = "0x18622C710")]
		public void SetMaterialProperty(int JCGBIDKEGML, float PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x622C930", Offset = "0x622BD30", VA = "0x18622C930")]
		public void SetMaterialProperty(int JCGBIDKEGML, Vector4 DHDCFCDFNBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x622C4B0", Offset = "0x622B8B0", VA = "0x18622C4B0")]
		public void SetMaterialProperty(int JCGBIDKEGML, Matrix4x4 FGCIMJDEIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6229510", Offset = "0x6228910", VA = "0x186229510")]
		private void EDELJBMMKBP(Renderer FPOCAHFIAOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6229F00", Offset = "0x6229300", VA = "0x186229F00")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x622A330", Offset = "0x6229730", VA = "0x18622A330")]
		private void LAHGLHPJOCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6229F30", Offset = "0x6229330", VA = "0x186229F30")]
		private void JEAJIMGEJCH(bool AHFDNLCDEMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6228E10", Offset = "0x6228210", VA = "0x186228E10")]
		private GDAIKOPKIMH CEOKBMGFCPL(BKEPMGIMHJB DJNFKIFDJHD, Material GDFHEJJFPNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6229150", Offset = "0x6228550", VA = "0x186229150")]
		private GDAIKOPKIMH DNCPFIKLJPN(Material GDFHEJJFPNA, int NAPCGJLCAKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6229B00", Offset = "0x6228F00", VA = "0x186229B00")]
		private GDAIKOPKIMH FNGLFGELBLO(Material GDFHEJJFPNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x172A580", Offset = "0x1729980", VA = "0x18172A580")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x622A340", Offset = "0x6229740", VA = "0x18622A340")]
		public void MarkDirty(BKEPMGIMHJB DJNFKIFDJHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x622B960", Offset = "0x622AD60", VA = "0x18622B960")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6229F10", Offset = "0x6229310", VA = "0x186229F10")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x622A790", Offset = "0x6229B90", VA = "0x18622A790")]
		public void RebatchOptimally()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x622CC30", Offset = "0x622C030", VA = "0x18622CC30")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NCNGGHMKDBO
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static bool MBJAFDIJFCD;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static Vector3 BCKAEHMBLFM;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int BPAELGCAAHO;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int APFPLEEHKEL;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int BCJBMCHEFCN;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int FBANJGLBJOH;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static List<BatchedMeshRenderer> FGJKACBLLNJ;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool LCOBJEKADML
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x622E770", Offset = "0x622DB70", VA = "0x18622E770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x622E5E0", Offset = "0x622D9E0", VA = "0x18622E5E0")]
	public static void PJKLBDDMIFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x622D3F0", Offset = "0x622C7F0", VA = "0x18622D3F0")]
	public static void GNCBBFFOOAH(BatchedMeshRenderer KMGBJECFCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x622D350", Offset = "0x622C750", VA = "0x18622D350")]
	public static void CJFPLCKBHNC(BatchedMeshRenderer KMGBJECFCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x622D640", Offset = "0x622CA40", VA = "0x18622D640")]
	public static void JLAHAONMIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x622E350", Offset = "0x622D750", VA = "0x18622E350")]
	public static void PEBONNKJAMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x622E260", Offset = "0x622D660", VA = "0x18622E260")]
	public static int NOIDFNKHONB()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GPEHJPFKCEN<KeyType> : GDAIKOPKIMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Dictionary<KeyType, BKEPMGIMHJB> JGBLKNLBOME;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x37F4940", Offset = "0x37F3D40", VA = "0x1837F4940")]
	public GPEHJPFKCEN(string CCNKHEJHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x37F4590", Offset = "0x37F3990", VA = "0x1837F4590")]
	public void AKHMPPDJDDD(KeyType NIOPCMHKLMB, BKEPMGIMHJB LCLKLNOMGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x37F4820", Offset = "0x37F3C20", VA = "0x1837F4820")]
	public bool KENAEIICPDP(KeyType NIOPCMHKLMB, BKEPMGIMHJB JIGMIKBJHKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x37F4690", Offset = "0x37F3A90", VA = "0x1837F4690")]
	public void DMLEKNMDOFE(KeyType NIOPCMHKLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x37F4900", Offset = "0x37F3D00", VA = "0x1837F4900", Slot = "4")]
	public override void PCECHJPIFLJ()
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
