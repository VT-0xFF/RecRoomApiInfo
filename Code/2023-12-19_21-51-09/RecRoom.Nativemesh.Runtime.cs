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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79B4F0", Offset = "0x79A0F0", VA = "0x18079B4F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EIAFKFDEIOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int INECOEKKODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 AHGCAMGLMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion GFCNKEHPGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 EFMLLKBKNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int EHABNMABMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int CNEODCOCNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int DMOKKBABBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float HGPFJMEFMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 DLNOGCKNHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool FLIPIPLOFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public ICIPGHFAMNC ODODMONFNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 PKACEEGFDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float EEKKBFLBGAO;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BJANHGENLCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static HLPMOOECHPJ FIODPCKMOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<EIAFKFDEIOD> CAIBLKDLLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<FKMJMKGNLEJ> CEMDEAFCLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<HAMDPFBMELD> NBALDJKGIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<MHLBIEOACMJ> IOBBFHONCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<FKMJMKGNLEJ> KJDAAOFGEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<BIKBDBNBCDJ> PABBKFOPAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<MHLBIEOACMJ>> LDEKBHNEFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<ODHCBAAOIGN> GKHOOLDFDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> PMAGNHDJBFP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CNDBAOMBLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB98B60", Offset = "0xB97760", VA = "0x180B98B60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB98600", Offset = "0xB97200", VA = "0x180B98600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DNHIIEHEHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB98B70", Offset = "0xB97770", VA = "0x180B98B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB98650", Offset = "0xB97250", VA = "0x180B98650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E56100", Offset = "0x5E54D00", VA = "0x185E56100")]
	public BJANHGENLCB(int LJOBJMBFHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E55FA0", Offset = "0x5E54BA0", VA = "0x185E55FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E545B0", Offset = "0x5E531B0", VA = "0x185E545B0")]
	public void BAMMMHDNJPA(JobHandle JJFOCCDGDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E54780", Offset = "0x5E53380", VA = "0x185E54780")]
	public void BOICDFHDNDD(EIAFKFDEIOD IGJLGPELHOJ, ODHCBAAOIGN FHOIKEFMEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E55FC0", Offset = "0x5E54BC0", VA = "0x185E55FC0")]
	public void NABGPEJPKAL(HAMDPFBMELD IGJLGPELHOJ, NativeArray<MHLBIEOACMJ> LNGDGNCOBNF, int KJKNLDPPFJF, int HGMIIIHBHGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E54C50", Offset = "0x5E53850", VA = "0x185E54C50")]
	public JobHandle DBALEKGKMNP(CNLDEILFBDO FMDAKFPJIKJ, NIMNMDNCKOJ FNKBHCFEDFI, float3 EDJJNHKLAGP, quaternion KIDNLBMLDGP, float PCAPLOPMLAG, bool HJGNKLPPDFN, int JLLHKNOBIJM = 0, int CHFFBBBNEPD = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E55C60", Offset = "0x5E54860", VA = "0x185E55C60")]
	public static JobHandle DGECLAKKDOF(EDEIOMGDNFG LIBJKEKNCBO, CNLDEILFBDO FMDAKFPJIKJ, EIAFKFDEIOD IGJLGPELHOJ, JobHandle JJFOCCDGDHO)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E549A0", Offset = "0x5E535A0", VA = "0x185E549A0")]
	public static JobHandle CCLJLEKPFCK(OLGHFJGAAIB LIBJKEKNCBO, CNLDEILFBDO FMDAKFPJIKJ, HAMDPFBMELD IGJLGPELHOJ, NativeArray<MHLBIEOACMJ> LNGDGNCOBNF, int KJKNLDPPFJF, int HGMIIIHBHGC, JobHandle JJFOCCDGDHO)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JJDDPBICPED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 NAJLGFDJGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 NEELNFNONFP;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IABKPMMBKJL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<JJDDPBICPED> AHJELMBNGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> AJJJPFBHGDJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CNDBAOMBLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7786A0", Offset = "0x7772A0", VA = "0x1807786A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DNHIIEHEHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77DAF0", Offset = "0x77C6F0", VA = "0x18077DAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D3B0", Offset = "0x5E5BFB0", VA = "0x185E5D3B0")]
	public IABKPMMBKJL(int ILGDAKLFJLG, int NPDEELJCGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D270", Offset = "0x5E5BE70", VA = "0x185E5D270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D2D0", Offset = "0x5E5BED0", VA = "0x185E5D2D0")]
	public void ECPKJCOHHNL(IABKPMMBKJL NNLIIOEJAMD, int JFAKGMPEOHK, int EJAHPHIIAGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EOGAKCCPHMJ
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static IABKPMMBKJL OAGINNAMPGJ;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<FKMJMKGNLEJ> MJEFICLKFJD;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] GKBEPLKMMBC;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool MIPKFKCNKEM;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, IABKPMMBKJL> NNPJOHKBOAE;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, IABKPMMBKJL> PLJJLFMBDKP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool NNLLNLJPFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E5B710", Offset = "0x5E5A310", VA = "0x185E5B710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<FKMJMKGNLEJ> PNFAJPEHFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E5C1E0", Offset = "0x5E5ADE0", VA = "0x185E5C1E0")]
		get
		{
			return default(NativeList<FKMJMKGNLEJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static IABKPMMBKJL HECDNLOMKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E5AF70", Offset = "0x5E59B70", VA = "0x185E5AF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E5BBD0", Offset = "0x5E5A7D0", VA = "0x185E5BBD0")]
	private static void LKGFCKGJJKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C490", Offset = "0x5E5B090", VA = "0x185E5C490")]
	public static int PDEJJMAGAEF(bool MKOPGDAAOKB, int NFGMAIKCCHK, bool JONKIPKPMHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AE50", Offset = "0x5E59A50", VA = "0x185E5AE50")]
	private static int CADPBGLPLDD(int NFGMAIKCCHK, bool MIDNDGLABHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B7B0", Offset = "0x5E5A3B0", VA = "0x185E5B7B0")]
	private static int IPMGAMCAGCI(int NFGMAIKCCHK, bool MIDNDGLABHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C390", Offset = "0x5E5AF90", VA = "0x185E5C390")]
	public static int NIACOLLGNOA(int HOFKCAJMBMN, int NFGMAIKCCHK, int JIFFNNNCBPK, bool MIDNDGLABHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B2B0", Offset = "0x5E59EB0", VA = "0x185E5B2B0")]
	public static int GNCFPOBKFFG(int HOFKCAJMBMN, int NFGMAIKCCHK, int JIFFNNNCBPK, bool MIDNDGLABHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AF60", Offset = "0x5E59B60", VA = "0x185E5AF60")]
	public static int CIOJKCHMBJE(int JIFFNNNCBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B010", Offset = "0x5E59C10", VA = "0x185E5B010")]
	private static int EIJDCEEHPHC(int NFGMAIKCCHK, bool MIDNDGLABHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B790", Offset = "0x5E5A390", VA = "0x185E5B790")]
	private static int INHNIOPJPOP(int NFGMAIKCCHK, bool MIDNDGLABHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C420", Offset = "0x5E5B020", VA = "0x185E5C420")]
	public static int ODONBODIANC(int HOFKCAJMBMN, int NFGMAIKCCHK, int JIFFNNNCBPK, bool MIDNDGLABHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B340", Offset = "0x5E59F40", VA = "0x185E5B340")]
	public static int GPMGJBMFIMO(int HOFKCAJMBMN, int NFGMAIKCCHK, int JIFFNNNCBPK, bool MIDNDGLABHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C370", Offset = "0x5E5AF70", VA = "0x185E5C370")]
	public static int MNNLCIIDCFN(int JIFFNNNCBPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C280", Offset = "0x5E5AE80", VA = "0x185E5C280")]
	public static IABKPMMBKJL MILIGEMCIIA(int NFGMAIKCCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B020", Offset = "0x5E59C20", VA = "0x185E5B020")]
	private static IABKPMMBKJL EOPIKFHKHLN(int NFGMAIKCCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E5AE70", Offset = "0x5E59A70", VA = "0x185E5AE70")]
	public static IABKPMMBKJL CINOILPFBAE(int NFGMAIKCCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B3D0", Offset = "0x5E59FD0", VA = "0x185E5B3D0")]
	private static IABKPMMBKJL HALGFJPEICC(int NFGMAIKCCHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E5B7C0", Offset = "0x5E5A3C0", VA = "0x185E5B7C0")]
	public static void KONCIADLIJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HAMDPFBMELD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int GOOLHBJOLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 AHGCAMGLMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion GFCNKEHPGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float EFMLLKBKNDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float DOOIENPOLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int EHABNMABMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int CNEODCOCNAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int DMOKKBABBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool ECMMKPGKPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool LAJDPECKIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float HGPFJMEFMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 DLNOGCKNHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool OOPPHOOCMGM;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BIKBDBNBCDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int FBNNOGOGKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int CBLNGKJLFNF;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct OLGHFJGAAIB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<HAMDPFBMELD> BIAIGACLAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<MHLBIEOACMJ> HCAJEBIHPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<FKMJMKGNLEJ> OHAIJJDMJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<BIKBDBNBCDJ> GPDHJODJAPF;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E64120", Offset = "0x5E62D20", VA = "0x185E64120")]
	public OLGHFJGAAIB(NativeArray<MHLBIEOACMJ> HCAJEBIHPAC, int JIGGJNDJAAO = 1, Allocator NOFANFDHPGP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E64030", Offset = "0x5E62C30", VA = "0x185E64030", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct KPPPMMOOFEG : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<JJDDPBICPED> JEEEADNPOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> CMCECPMJOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<FKMJMKGNLEJ> ADAJDMDKNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<HAMDPFBMELD> BIAIGACLAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<MHLBIEOACMJ> HCAJEBIHPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<FKMJMKGNLEJ> OHAIJJDMJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<BIKBDBNBCDJ> GPDHJODJAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int BHBFIOLGMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int FOFAMAILILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 NEHAEMHLLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion OIJOCANBGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 JOHNOOMOKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KEKFPLBGCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FBIFPKMJLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PDLKGJAMJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HKEIMGOHOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> EIINJBCAFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LAOHKCCOOMF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E60530", Offset = "0x5E5F130", VA = "0x185E60530")]
	public KPPPMMOOFEG(BJANHGENLCB IMGAAOPMILN, CNLDEILFBDO PKCGFOKPNKB, float3 MNEBLCNMHGK, quaternion IBOCOACGPHL, float EPPFEPIPOGO, int JLLHKNOBIJM = 0, int CHFFBBBNEPD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E60300", Offset = "0x5E5EF00", VA = "0x185E60300")]
	public KPPPMMOOFEG(OLGHFJGAAIB IMGAAOPMILN, CNLDEILFBDO PKCGFOKPNKB, float3 MNEBLCNMHGK, quaternion IBOCOACGPHL, float3 EPPFEPIPOGO, int JLLHKNOBIJM = 0, int CHFFBBBNEPD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E601D0", Offset = "0x5E5EDD0", VA = "0x185E601D0")]
	private float3 POEPJPMFMKI(float3 HJKLOHEOBID, Matrix4x4 DGOGFFJNONK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FFD0", Offset = "0x5E5EBD0", VA = "0x185E5FFD0")]
	private float3x3 HDOJCHGMDEJ(float3x3 FOKFLNGKAJP, float3x3 AJOBHBCEMCH)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E60050", Offset = "0x5E5EC50", VA = "0x185E60050")]
	private float LHJHOMNBOEC(float JIFOIDNONIC, float CNCOKLKNHCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E9D0", Offset = "0x5E5D5D0", VA = "0x185E5E9D0", Slot = "4")]
	public void Execute(int EANIEPCFJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E60060", Offset = "0x5E5EC60", VA = "0x185E60060")]
	private void NJMCFJMFPPL(int KPEEMGFCDDG, float3 CFCLFCDKKPD, float3 FNDECJGLHAI, float3 MGJADLIGJAI, float JBOECICKFAJ, bool JLMFFAJDFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FB70", Offset = "0x5E5E770", VA = "0x185E5FB70")]
	private void FOPCCEEPNND(HAMDPFBMELD BOGJHPOOECN, float3 PFPKEOGBCMG, float3x3 NPBGCICJLPM, float JIFOIDNONIC, int AOBAIAHHPFD, int DKMLEKHEHHL, int COOAOMOFCAP, float NICAOJBNCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E380", Offset = "0x5E5CF80", VA = "0x185E5E380")]
	private void DKCFMLCMNII(int KPEEMGFCDDG, int HNIMNAEBHEO, HAMDPFBMELD BOGJHPOOECN, float3 PFPKEOGBCMG, float3x3 NPBGCICJLPM, bool MPFLGHLPOPC, float JIFOIDNONIC, int AHADCBNKMMP, int FCHHJEGFHPO, int COOAOMOFCAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EDEIOMGDNFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<EIAFKFDEIOD> FFFKLCGCLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<FKMJMKGNLEJ> GEHBKLIEHND;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A220", Offset = "0x5E58E20", VA = "0x185E5A220")]
	public EDEIOMGDNFG(int JIGGJNDJAAO, Allocator NOFANFDHPGP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A180", Offset = "0x5E58D80", VA = "0x185E5A180", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct NIAIDMEGBCJ : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum ABEEHADPOIG
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
	private NativeList<float3> NLAMINLNJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> MFPELJONNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> FGCJCKELGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> OOGCLBCOOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> OIELMFEBLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> PHLMOFPHMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> MPDBGNCFGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> MKGGAAFJOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<FKMJMKGNLEJ> JOFDOHCLFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<EIAFKFDEIOD> FFFKLCGCLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<FKMJMKGNLEJ> GEHBKLIEHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int BHBFIOLGMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int FOFAMAILILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KEKFPLBGCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> FBIFPKMJLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PDLKGJAMJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HKEIMGOHOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> EIINJBCAFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LAOHKCCOOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 JOHNOOMOKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion OIJOCANBGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 NEHAEMHLLLG;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E631B0", Offset = "0x5E61DB0", VA = "0x185E631B0")]
	public NIAIDMEGBCJ(BJANHGENLCB IMGAAOPMILN, CNLDEILFBDO PKCGFOKPNKB, float3 MNEBLCNMHGK, quaternion IBOCOACGPHL, float EPPFEPIPOGO, int JLLHKNOBIJM = 0, int CHFFBBBNEPD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E62FC0", Offset = "0x5E61BC0", VA = "0x185E62FC0")]
	public NIAIDMEGBCJ(EDEIOMGDNFG IGJLGPELHOJ, CNLDEILFBDO PKCGFOKPNKB, float3 MNEBLCNMHGK, quaternion IBOCOACGPHL, float3 EPPFEPIPOGO, int JLLHKNOBIJM = 0, int CHFFBBBNEPD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E61C60", Offset = "0x5E60860", VA = "0x185E61C60", Slot = "4")]
	public void Execute(int EANIEPCFJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E62C10", Offset = "0x5E61810", VA = "0x185E62C10")]
	private void MANLEFLPDJL(float4x4 LNKINELBFEC, int EANIEPCFJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E61BB0", Offset = "0x5E607B0", VA = "0x185E61BB0")]
	private ABEEHADPOIG ABECJDLIDMG(float3 FNDECJGLHAI)
	{
		return default(ABEEHADPOIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E62BC0", Offset = "0x5E617C0", VA = "0x185E62BC0")]
	private float4 FPOINFLCMBK(ABEEHADPOIG PLPJEEMEBIG, int DCGGFHOCGGH)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E61C20", Offset = "0x5E60820", VA = "0x185E61C20")]
	private float2 AGFABJBPJDK(ABEEHADPOIG PLPJEEMEBIG, float3 CFCLFCDKKPD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct ODHCBAAOIGN
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum OLFNBKDEMFC
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static ODHCBAAOIGN MANJPJPLOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 GAFNFHBABIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 GAAKDKFPAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 JKLDCECNLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public OLFNBKDEMFC IBCFEMEEMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 LINHLJHNCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 JEJBCGBALHD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LNBKOGHJAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E63A20", Offset = "0x5E62620", VA = "0x185E63A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 IAAEOCINLBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E63940", Offset = "0x5E62540", VA = "0x185E63940")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E63F40", Offset = "0x5E62B40", VA = "0x185E63F40")]
	public ODHCBAAOIGN(float3 CFCLFCDKKPD, quaternion HFKFMHAMLPE, float3 JIGGJNDJAAO, OLFNBKDEMFC OMKEAAPIABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E63B20", Offset = "0x5E62720", VA = "0x185E63B20")]
	public float NFALHFDIFDO(float3 PFPKEOGBCMG, float MIKHGJMPOMH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E63A30", Offset = "0x5E62630", VA = "0x185E63A30")]
	public bool JCFIFDLFDJH(float3 FNDECJGLHAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5E63D20", Offset = "0x5E62920", VA = "0x185E63D20")]
	public void OHFHOMMMEPG(float3 AMPCDIBJMLG, float3x3 LJMHBLAKFMM, float IEJLJEOJPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E63840", Offset = "0x5E62440", VA = "0x185E63840")]
	private void CEDOJLLONMD(float3 BHCNJFDJBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E635B0", Offset = "0x5E621B0", VA = "0x185E635B0")]
	public void AGLKAJIJMNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct EECMMKHFBIN : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<ODHCBAAOIGN> IGJLGPELHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> AGLCONKBMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> MPILLPOLLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> PMAGNHDJBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<FKMJMKGNLEJ> GEHBKLIEHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int GOGMNDIDBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int FAMBJHFMNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float MIKHGJMPOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float IFLGMIKPNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> IPJGJJAANLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> AEGOLGADIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> MFDFFBFAEPE;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5E5ADB0", Offset = "0x5E599B0", VA = "0x185E5ADB0")]
	public EECMMKHFBIN(CNLDEILFBDO PBIOEFEPBND, float KJKKBEEJADD, int EJAHPHIIAGB, int AOBAIAHHPFD, NativeList<ODHCBAAOIGN> IGJLGPELHOJ, NativeArray<int> PMAGNHDJBFP, NativeList<FKMJMKGNLEJ> GEHBKLIEHND, NIMNMDNCKOJ FNKBHCFEDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A5B0", Offset = "0x5E591B0", VA = "0x185E5A5B0", Slot = "4")]
	public void Execute(int GAFPBDLPMEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E5ACF0", Offset = "0x5E598F0", VA = "0x185E5ACF0")]
	private bool NKPPCOPGJDJ(ODHCBAAOIGN FLGIINLNNEM, ODHCBAAOIGN KNDAEONALIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A310", Offset = "0x5E58F10", VA = "0x185E5A310")]
	private bool CLJEHPLHPFC(ODHCBAAOIGN DKFOONILOPO, int LONPHHHCMAK, int FBEJMAIGJCK, int LINAEDMOGKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NIMNMDNCKOJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> PPDPFPFDAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> OAGANLFCBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> AELGDACFMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> AOIDPDCEALF;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E633A0", Offset = "0x5E61FA0", VA = "0x185E633A0")]
	public void ADINGHMPBPE(int ILGDAKLFJLG, int NPDEELJCGPN, Allocator NOFANFDHPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E63590", Offset = "0x5E62190", VA = "0x185E63590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E634A0", Offset = "0x5E620A0", VA = "0x185E634A0")]
	public void BAMMMHDNJPA(JobHandle JJFOCCDGDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public NIMNMDNCKOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct HEGPNODBBLB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> AGLCONKBMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> FKABCNNEGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> BFFDOMEBAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> HIHNKFEILKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> MPILLPOLLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DMDICCIKBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> JJMFDGAABLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> IPJGJJAANLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> AEGOLGADIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int JLLHKNOBIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int CHFFBBBNEPD;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CBC0", Offset = "0x5E5B7C0", VA = "0x185E5CBC0")]
	public HEGPNODBBLB(CNLDEILFBDO PBIOEFEPBND, NIMNMDNCKOJ FNKBHCFEDFI, int CHFFBBBNEPD = 0, int JLLHKNOBIJM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C780", Offset = "0x5E5B380", VA = "0x185E5C780", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CB60", Offset = "0x5E5B760", VA = "0x185E5CB60")]
	private void LNIEDOKBAFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CJGDLHIEJNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x23511E0", Offset = "0x234FDE0", VA = "0x1823511E0")]
	public static bool DMNBEJPDHFJ<T>(NativeArray<T> DAJPKFPFPMI, int JIGGJNDJAAO, Allocator NOFANFDHPGP, NativeArrayOptions MCIMANHECMC = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2351280", Offset = "0x234FE80", VA = "0x182351280")]
	public static bool DMNBEJPDHFJ<T>(NativeList<T> ALFGCABNDNK, int JIGGJNDJAAO, Allocator NOFANFDHPGP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum BMEGOJHDNIM
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
public interface MGPDNLADELI
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PDACPDGCAPM(BMEGOJHDNIM HOFKCAJMBMN);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IOFMJBKANKM(BMEGOJHDNIM HOFKCAJMBMN);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEHEKIOEPFH(BMEGOJHDNIM HOFKCAJMBMN, BJANHGENLCB MKCFKGNJLDF, int KNEFGCOIDCF = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CNLDEILFBDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int BEBODAIGCKD = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> DIBAFCIBODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> IEOEOOJHBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> BLEFJFNLMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> APFFBGHLDMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> ODHDBBGHPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> FHODFHJDABC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PJGJGCEHBMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E59BA0", Offset = "0x5E587A0", VA = "0x185E59BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CNDBAOMBLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E590D0", Offset = "0x5E57CD0", VA = "0x185E590D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DNHIIEHEHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E59BE0", Offset = "0x5E587E0", VA = "0x185E59BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool PBOJMAOIJKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E59090", Offset = "0x5E57C90", VA = "0x185E59090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E58F80", Offset = "0x5E57B80", VA = "0x185E58F80", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E58DB0", Offset = "0x5E579B0", VA = "0x185E58DB0")]
	public void ADINGHMPBPE(int ILGDAKLFJLG, int NPDEELJCGPN, Allocator NOFANFDHPGP, bool GGGMJFEDEOG, bool OGMGNAKAMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E59740", Offset = "0x5E58340", VA = "0x185E59740")]
	public void LNECDJDAFPB(int ILGDAKLFJLG, int NPDEELJCGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E597C0", Offset = "0x5E583C0", VA = "0x185E597C0", Slot = "6")]
	public bool MJAMENJCMNF(Mesh PBIOEFEPBND, bool KCCIBLFDBAO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E59110", Offset = "0x5E57D10", VA = "0x185E59110")]
	public bool JGIACDEKLCF(Mesh PBIOEFEPBND, CNLDEILFBDO EDJIKOGAFJL, bool KCCIBLFDBAO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public CNLDEILFBDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class GPFLCAMEKFC
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5E5C630", Offset = "0x5E5B230", VA = "0x185E5C630")]
	public static void KONCIADLIJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LFJLOFKOIBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> DIBAFCIBODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> IEOEOOJHBAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> PHJMLBCOBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> CDOLBFLBMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> MABEFEELDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> FHEAOOINEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> NHIJDPJPGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> FHODFHJDABC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CNDBAOMBLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E615E0", Offset = "0x5E601E0", VA = "0x185E615E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DNHIIEHEHGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E61660", Offset = "0x5E60260", VA = "0x185E61660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int HHKBDHBPDLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E61620", Offset = "0x5E60220", VA = "0x185E61620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E616A0", Offset = "0x5E602A0", VA = "0x185E616A0")]
	public LFJLOFKOIBN(int ILGDAKLFJLG, int NPDEELJCGPN, int CNJLLOJFFGK, Allocator NOFANFDHPGP = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E618C0", Offset = "0x5E604C0", VA = "0x185E618C0")]
	public LFJLOFKOIBN(Mesh PBIOEFEPBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5E60C50", Offset = "0x5E5F850", VA = "0x185E60C50", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E60D60", Offset = "0x5E5F960", VA = "0x185E60D60")]
	public void ECPKJCOHHNL(LFJLOFKOIBN PBIOEFEPBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E607C0", Offset = "0x5E5F3C0", VA = "0x185E607C0")]
	private void AMFCPNOBDCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5E61060", Offset = "0x5E5FC60", VA = "0x185E61060")]
	private void GMNLOLEGAJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FKMJMKGNLEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int GBAPLCLBAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int CNDBAOMBLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int HBGPJILDHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int DNHIIEHEHGF;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x11334F0", Offset = "0x11320F0", VA = "0x1811334F0")]
	public FKMJMKGNLEJ(int AOBAIAHHPFD, int KJKNLDPPFJF, int EJAHPHIIAGB, int HGMIIIHBHGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HLPMOOECHPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<FKMJMKGNLEJ> DJBHNNKOBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB2A490", Offset = "0xB29090", VA = "0x180B2A490")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<FKMJMKGNLEJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1B78D20", Offset = "0x1B77920", VA = "0x181B78D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public LFJLOFKOIBN HENKODENAFI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CCB0", Offset = "0x5E5B8B0", VA = "0x185E5CCB0")]
	public HLPMOOECHPJ(IEnumerable<LFJLOFKOIBN> MPJMINFDDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CC40", Offset = "0x5E5B840", VA = "0x185E5CC40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum ICIPGHFAMNC
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class DPJFGLAOHOG
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> CKKDPEMDNDH;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> KNMFMGBCCAE;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> IKJAFBIJIAM;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> NKBEJDKEIOG;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5E59F50", Offset = "0x5E58B50", VA = "0x185E59F50")]
	public static void KONCIADLIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E59C20", Offset = "0x5E58820", VA = "0x185E59C20")]
	public static NativeArray<float2> BMCJIDCBIGF(NativeArray<float2> OLLOBMELOLP, int DFDLANHIKIH, NativeArray<float2> OANBBNGKHED, int HLGJLPCHHFJ)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E5A070", Offset = "0x5E58C70", VA = "0x185E5A070")]
	public static NativeArray<float3> OFJCCOPPKMJ(NativeArray<float3> OLLOBMELOLP, int DFDLANHIKIH, NativeArray<float3> OANBBNGKHED, int HLGJLPCHHFJ)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E59D30", Offset = "0x5E58930", VA = "0x185E59D30")]
	public static NativeArray<float4> CDEMPEPJNNO(NativeArray<float4> OLLOBMELOLP, int DFDLANHIKIH, NativeArray<float4> OANBBNGKHED, int HLGJLPCHHFJ)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E59E40", Offset = "0x5E58A40", VA = "0x185E59E40")]
	public static NativeArray<int> IIEAJDKHPFO(NativeArray<int> OLLOBMELOLP, int DFDLANHIKIH, NativeArray<int> OANBBNGKHED, int HLGJLPCHHFJ)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x238B2B0", Offset = "0x2389EB0", VA = "0x18238B2B0")]
	private static void CPFBPPOAKKJ<T>(NativeArray<T> DAJPKFPFPMI, int OLLHNNNEEKH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x238B4B0", Offset = "0x238A0B0", VA = "0x18238B4B0")]
	private static void GBAMBINNIKP<T>(NativeArray<T> OLLOBMELOLP, int DFDLANHIKIH, NativeArray<T> OANBBNGKHED, int HLGJLPCHHFJ, NativeArray<T> DIPHBHAMLOM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KGIBLEFBFKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<MGPDNLADELI> OMHOHOBDCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly BEFJNOBFPAB NJBLJMDPADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int KJKNLDPPFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int HGMIIIHBHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool JPEKGADAEEJ;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh HENKODENAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772420", VA = "0x180773820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer LEGPFKGFPII
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int CNDBAOMBLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D6D0", Offset = "0x5E5C2D0", VA = "0x185E5D6D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x209FB20", Offset = "0x209E720", VA = "0x18209FB20")]
	public void LKAEADELBHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E260", Offset = "0x5E5CE60", VA = "0x185E5E260")]
	public KGIBLEFBFKO(string JEICAPDKHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D470", Offset = "0x5E5C070", VA = "0x185E5D470")]
	public void BAMMMHDNJPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D4B0", Offset = "0x5E5C0B0", VA = "0x185E5D4B0")]
	public void BPIBIPGDKCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DA30", Offset = "0x5E5C630", VA = "0x185E5DA30")]
	public void OPIJDHCPGKJ(MGPDNLADELI JGALFGJJOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D7C0", Offset = "0x5E5C3C0", VA = "0x185E5D7C0")]
	private void KMMJBDFJOPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D660", Offset = "0x5E5C260", VA = "0x185E5D660")]
	public bool HJGPGOGLAFK(MGPDNLADELI JGALFGJJOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D4E0", Offset = "0x5E5C0E0", VA = "0x185E5D4E0")]
	public bool EBENCGGDEAG(MGPDNLADELI JGALFGJJOFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D5F0", Offset = "0x5E5C1F0", VA = "0x185E5D5F0", Slot = "4")]
	public virtual void FNKFNHMCPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D6F0", Offset = "0x5E5C2F0", VA = "0x185E5D6F0")]
	public void IPEBPFHPIHF(Transform HCCJOODFAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DAE0", Offset = "0x5E5C6E0", VA = "0x185E5DAE0")]
	public bool PCDICKCOMJG(Transform HCCJOODFAMD, [Out] (CNLDEILFBDO destMesh, Mesh mesh, JobHandle job) IGJLGPELHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D540", Offset = "0x5E5C140", VA = "0x185E5D540")]
	public void FJBCPFNPHOK([In] (CNLDEILFBDO destMesh, Mesh mesh, JobHandle job) IGJLGPELHOJ)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker JJHEHKDLDCA;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker CGPLIAAFEOI;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker GGDFPPILJIB;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int GFIENIHJKPA = 65000;

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
		private Dictionary<Material, List<KGIBLEFBFKO>> CLECMEJGMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<KGIBLEFBFKO> FAKFPCLCIMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> FCLJLOMHLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(KGIBLEFBFKO, (CNLDEILFBDO, Mesh, JobHandle))> PPHLEJACPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool EIJOOLCLBBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> LFGFMEMDGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> LLMFACDKIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> DOOGKGGHCAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> HNMFCHEGPHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private KGIBLEFBFKO KGJLICNCNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material ALABJBHPHBL;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> KPGMFOPGFHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E57780", Offset = "0x5E56380", VA = "0x185E57780")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E56790", Offset = "0x5E55390", VA = "0x185E56790")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E56310", Offset = "0x5E54F10", VA = "0x185E56310")]
		public KGIBLEFBFKO AddToBatchedMesh(MGPDNLADELI KEGDNHBHBNM, Material ELHBBBNEEAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E57FC0", Offset = "0x5E56BC0", VA = "0x185E57FC0")]
		public void RemoveFromBatchedMesh(MGPDNLADELI PBIOEFEPBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E565F0", Offset = "0x5E551F0", VA = "0x185E565F0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E58140", Offset = "0x5E56D40", VA = "0x185E58140")]
		public void SetMaterialProperty(int MGCLAKBCFBH, Color EFLLOODPMDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E585D0", Offset = "0x5E571D0", VA = "0x185E585D0")]
		public void SetMaterialProperty(int MGCLAKBCFBH, float GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5E587F0", Offset = "0x5E573F0", VA = "0x185E587F0")]
		public void SetMaterialProperty(int MGCLAKBCFBH, Vector4 ELGIBJGKOHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E58370", Offset = "0x5E56F70", VA = "0x185E58370")]
		public void SetMaterialProperty(int MGCLAKBCFBH, Matrix4x4 KCGLKGHEFJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5E579D0", Offset = "0x5E565D0", VA = "0x185E579D0")]
		private void PJNLJAOEFHK(Renderer NOCLHDPKCMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E56ED0", Offset = "0x5E55AD0", VA = "0x185E56ED0")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E56970", Offset = "0x5E55570", VA = "0x185E56970")]
		private void EMJNEDCCCGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E563F0", Offset = "0x5E54FF0", VA = "0x185E563F0")]
		private KGIBLEFBFKO CBHKLCKMKKE(MGPDNLADELI PBIOEFEPBND, Material ELHBBBNEEAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E56EE0", Offset = "0x5E55AE0", VA = "0x185E56EE0")]
		private KGIBLEFBFKO IDFPJOCHFKL(Material ELHBBBNEEAK, int ILCAFKCFPPD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E570B0", Offset = "0x5E55CB0", VA = "0x185E570B0")]
		private KGIBLEFBFKO LKBDNGHOJJN(Material ELHBBBNEEAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E576F0", Offset = "0x5E562F0", VA = "0x185E576F0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5E57560", Offset = "0x5E56160", VA = "0x185E57560")]
		public void MarkDirty(MGPDNLADELI PBIOEFEPBND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5E58AF0", Offset = "0x5E576F0", VA = "0x185E58AF0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CINBPMBGCOE<KeyType> : KGIBLEFBFKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, MGPDNLADELI> HENGHLOKLPO;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4A397F0", Offset = "0x4A383F0", VA = "0x184A397F0")]
	public CINBPMBGCOE(string JEICAPDKHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4A397A0", Offset = "0x4A383A0", VA = "0x184A397A0")]
	public void OPIJDHCPGKJ(KeyType PPNDANAOAMK, MGPDNLADELI JGALFGJJOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4A396D0", Offset = "0x4A382D0", VA = "0x184A396D0")]
	public bool ODACFNKJJMP(KeyType PPNDANAOAMK, MGPDNLADELI FGNICIBJCGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4A39520", Offset = "0x4A38120", VA = "0x184A39520")]
	public void FCJGDFKHCPD(KeyType PPNDANAOAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4A395C0", Offset = "0x4A381C0", VA = "0x184A395C0", Slot = "4")]
	public override void FNKFNHMCPOB()
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
