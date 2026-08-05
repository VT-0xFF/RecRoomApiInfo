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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DMOHLCAHEDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int AFIGIKNJOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 BJJGNPCBCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion NNKDNJOPBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 GGNKBPHCEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int CDNFDPFEBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int ONEIJGNKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int PCJNGDPCKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float JGIGIHDGNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 DEBKOGKHLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool IDAMFFNAKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public DCDONBDHFKJ KLPBECGOEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 NAJHDMBHKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float GCICCNINPOM;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CDLFNPIGGEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static NMHMLGLJIFP IOKJPHCNPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<DMOHLCAHEDN> GEDCGCMKGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<LEEKJDHKPJL> JOLDNMIAOCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<NJPCKFBFBNO> JDHDFEEMJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<AKNBFKPBBEI> PMCGINHFEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<LEEKJDHKPJL> ADBGPGCOHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<DJGBDNNMCHK> FDCFLKJGLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<AKNBFKPBBEI>> MDOEJMKMCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<JNMPMBKLGLK> BHLMJANKHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> JHFNGNPECEB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GJKEDBHOEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC762A0", Offset = "0xC754A0", VA = "0x180C762A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC75BE0", Offset = "0xC74DE0", VA = "0x180C75BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PMKAIBBIGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC762B0", Offset = "0xC754B0", VA = "0x180C762B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC75780", Offset = "0xC74980", VA = "0x180C75780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61ADD70", Offset = "0x61ACF70", VA = "0x1861ADD70")]
	public CDLFNPIGGEJ(int HMCBGLOCEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61AC220", Offset = "0x61AB420", VA = "0x1861AC220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61AD250", Offset = "0x61AC450", VA = "0x1861AD250")]
	public void GFBILCCCLII(JobHandle EIMNPGHHIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61ADB50", Offset = "0x61ACD50", VA = "0x1861ADB50")]
	public void JNFFHKPFLGD(DMOHLCAHEDN GKNJGNIHLDH, JNMPMBKLGLK IGBKGNKLDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x61ADA10", Offset = "0x61ACC10", VA = "0x1861ADA10")]
	public void JBIMNFHNCHL(NJPCKFBFBNO GKNJGNIHLDH, NativeArray<AKNBFKPBBEI> GPOCNODFIHO, int JEOBOGLNJJI, int OPAJBDGDAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61AC240", Offset = "0x61AB440", VA = "0x1861AC240")]
	public JobHandle EGBNFOLBBIM(DLNHLGCKNMF NHLICHFNLOH, NNNGHDLACJL GDEGGFCOCON, float3 MNILGGPDMDB, quaternion PINPLBFIKPO, float MMIHEHMNPAJ, bool LMIHKPJMNEO, int NEGLMJNCIIJ = 0, int DBOBBPPEKOK = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61AD6D0", Offset = "0x61AC8D0", VA = "0x1861AD6D0")]
	public static JobHandle IJMGIAALAHD(EAJPOKCIJOB LAKPLIAJEEP, DLNHLGCKNMF NHLICHFNLOH, DMOHLCAHEDN GKNJGNIHLDH, JobHandle EIMNPGHHIJH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x61AD420", Offset = "0x61AC620", VA = "0x1861AD420")]
	public static JobHandle HGLOIAMOCNB(BCHGCHIAMDG LAKPLIAJEEP, DLNHLGCKNMF NHLICHFNLOH, NJPCKFBFBNO GKNJGNIHLDH, NativeArray<AKNBFKPBBEI> GPOCNODFIHO, int JEOBOGLNJJI, int OPAJBDGDAJK, JobHandle EIMNPGHHIJH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class OPJJAGBCJNB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct FPKMIOFKLGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half GPOCBAPGLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort HBMBLJKBIJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte JKACPCBOGFN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int JEOBOGLNJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int OPAJBDGDAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> DABNGMABAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> PAPPGFPLFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> PHKNKHJEDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> MFKKABMAGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<FPKMIOFKLGP> JOJOHLNLOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> ADLGKPAIAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> GMLINIGJIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 DKJDOCDBIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 NOBDMGFIFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 ANABLHBIACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 HHKJMNMDJBB;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long GGFGKIBGLHK;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long EHOKNBGJJCG;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float OJMGBOIIODJ;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool DGFPBPDPOBP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IFLCBICFIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61BC8E0", Offset = "0x61BBAE0", VA = "0x1861BC8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x61BCD60", Offset = "0x61BBF60", VA = "0x1861BCD60")]
	public void GFBILCCCLII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61BE590", Offset = "0x61BD790", VA = "0x1861BE590")]
	public static OPJJAGBCJNB NAIBINGPDAH(Allocator ECEHKFLCCDN, DLNHLGCKNMF LEKHIMFKFBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61BE7D0", Offset = "0x61BD9D0", VA = "0x1861BE7D0")]
	public static OPJJAGBCJNB NAIBINGPDAH(Allocator ECEHKFLCCDN, NativeArray<float3> IOMKOEKENJD, NativeArray<float3> KKPOMLPAKPB, NativeArray<float2> CELLEDBCNBO, NativeArray<float4> EHIIOGBEPPG, bool PIODNAEOPGP, NativeArray<float4> PANGPJLCHBM, NativeArray<int> EIHCNJKFHDO, int JEOBOGLNJJI, int GDNONFBGDMM, int OPAJBDGDAJK, int JDECGHIIKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x61BD380", Offset = "0x61BC580", VA = "0x1861BD380")]
	public DLNHLGCKNMF IHGNGBEAGCG(Allocator ECEHKFLCCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61BEBA0", Offset = "0x61BDDA0", VA = "0x1861BEBA0")]
	public void NDPPGOPMBEC(Mesh JLFPINMNNGM, bool BPDNNPHCALE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61BD8A0", Offset = "0x61BCAA0", VA = "0x1861BD8A0")]
	public long IJBKILOGEHC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x61BE2E0", Offset = "0x61BD4E0", VA = "0x1861BE2E0")]
	private void MFAMJJBKICE(int AKJJHODFGFH, int NFPPLLIAOCG, Allocator ECEHKFLCCDN, bool MIADGKCCABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61BDF40", Offset = "0x61BD140", VA = "0x1861BDF40")]
	private float3 JOBHODKHBDF(int GLODLAGLMOL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61BCE60", Offset = "0x61BC060", VA = "0x1861BCE60")]
	private void GGMBAEKGOAE(int GLODLAGLMOL, float3 HHKPBHPAGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61BD010", Offset = "0x61BC210", VA = "0x1861BD010")]
	private float3 HGPLMDIMGIF(int GLODLAGLMOL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61BE3F0", Offset = "0x61BD5F0", VA = "0x1861BE3F0")]
	private void MKPOHDBPBCK(int GLODLAGLMOL, float3 HHKPBHPAGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61BDFD0", Offset = "0x61BD1D0", VA = "0x1861BDFD0")]
	private float4 KDGLDLOMHAP(int GLODLAGLMOL)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61BE040", Offset = "0x61BD240", VA = "0x1861BE040")]
	private void KHLDINJEPPL(int GLODLAGLMOL, float4 HHKPBHPAGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61BD930", Offset = "0x61BCB30", VA = "0x1861BD930")]
	private float2 IMGNAIONONL(int GLODLAGLMOL)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61BC7D0", Offset = "0x61BB9D0", VA = "0x1861BC7D0")]
	private void BDKLHEDCLNE(int GLODLAGLMOL, float2 HHKPBHPAGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61BD050", Offset = "0x61BC250", VA = "0x1861BD050")]
	private void HKBLIPMIPKN(NativeArray<float3> IOMKOEKENJD, int JDECGHIIKDH, int NFPPLLIAOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61BEF50", Offset = "0x61BE150", VA = "0x1861BEF50")]
	private void PMNKINAMBEE(NativeArray<float3> KKPOMLPAKPB, int JDECGHIIKDH, int NFPPLLIAOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61BC920", Offset = "0x61BBB20", VA = "0x1861BC920")]
	private void DELCFEEPAIN(NativeArray<float2> CELLEDBCNBO, int JDECGHIIKDH, int NFPPLLIAOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61BD990", Offset = "0x61BCB90", VA = "0x1861BD990")]
	private void IOFFOGOBKEO(NativeArray<float4> GDCCCLKODBO, int JDECGHIIKDH, int NFPPLLIAOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61BDA60", Offset = "0x61BCC60", VA = "0x1861BDA60")]
	private void JNFBBEDMHPI(Allocator ECEHKFLCCDN, NativeArray<float4> EHIIOGBEPPG, int JDECGHIIKDH, int NFPPLLIAOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61BE1A0", Offset = "0x61BD3A0", VA = "0x1861BE1A0")]
	private static void LJBDCHAPOGK(NativeArray<float4> OFOJFPGJCCH, NativeArray<FPKMIOFKLGP> PDEKNMBIEDN, NativeArray<byte> BDHFFGNILEJ, int JEOBOGLNJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61BE0C0", Offset = "0x61BD2C0", VA = "0x1861BE0C0")]
	private void KPEOIKJEFAD(Allocator ECEHKFLCCDN, NativeArray<int> EIHCNJKFHDO, int JDECGHIIKDH, int NFPPLLIAOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61BEC80", Offset = "0x61BDE80", VA = "0x1861BEC80")]
	private static NativeArray<byte> OINAIEECFKD(Allocator ECEHKFLCCDN, NativeArray<int> EIHCNJKFHDO, int NGHHMAJFMAD)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61BD2E0", Offset = "0x61BC4E0", VA = "0x1861BD2E0")]
	private static void HMFFDJJHLHI(NativeArray<int> JFNEBLCFDOJ, NativeArray<byte> EKKHEANBAPK, int OPAJBDGDAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61BE440", Offset = "0x61BD640", VA = "0x1861BE440")]
	private static float3 MOJNFAAGCBP(ushort FEFHIFMHIBO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61BCBA0", Offset = "0x61BBDA0", VA = "0x1861BCBA0")]
	private static ushort FIEIFLFPJBH(float3 HHKPBHPAGEM)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public OPJJAGBCJNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CPDMNFHPCCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float2 DAFNKFGPHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float2 JPFFAFOAGGH;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PEIDHLNFHIH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<CPDMNFHPCCF> CBDKBOHKAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<int> PJBEPPKANGC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GJKEDBHOEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0510", Offset = "0x7BF710", VA = "0x1807C0510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PMKAIBBIGNI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5B0", Offset = "0x7BE7B0", VA = "0x1807BF5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61BF110", Offset = "0x61BE310", VA = "0x1861BF110")]
	public PEIDHLNFHIH(int AKJJHODFGFH, int NFPPLLIAOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61BEFD0", Offset = "0x61BE1D0", VA = "0x1861BEFD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61BF030", Offset = "0x61BE230", VA = "0x1861BF030")]
	public void MFGJAPNDLBI(PEIDHLNFHIH GELMLNOCEEA, int OEFEEBEDJDO, int CMAABPPFEEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JHKHLOBLEGC
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static PEIDHLNFHIH NKDPDACKNDK;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static NativeList<LEEKJDHKPJL> JNHBKILGMIF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int[] EKFLHNGEFBO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static bool IOEHOCNAMHK;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Dictionary<int, PEIDHLNFHIH> KKKDDJNFGBA;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Dictionary<int, PEIDHLNFHIH> KANGHFJBLLD;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool OJADGOCDKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61B9900", Offset = "0x61B8B00", VA = "0x1861B9900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<LEEKJDHKPJL> HACFKMFLPIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x61B9B30", Offset = "0x61B8D30", VA = "0x1861B9B30")]
		get
		{
			return default(NativeList<LEEKJDHKPJL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static PEIDHLNFHIH FFBKLAIAFKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61B9770", Offset = "0x61B8970", VA = "0x1861B9770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x61B9BD0", Offset = "0x61B8DD0", VA = "0x1861B9BD0")]
	private static void HLPJGEHICJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61B9740", Offset = "0x61B8940", VA = "0x1861B9740")]
	public static int BLCMIKMONDO(bool KPEIIPFPHFI, int GJANJLILBNF, bool FJPJHHLCMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61B9A10", Offset = "0x61B8C10", VA = "0x1861B9A10")]
	private static int EHMHHIGBMDG(int GJANJLILBNF, bool BBHFDLHJGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61B9B20", Offset = "0x61B8D20", VA = "0x1861B9B20")]
	private static int GBMPENADJNN(int GJANJLILBNF, bool BBHFDLHJGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61BA340", Offset = "0x61B9540", VA = "0x1861BA340")]
	public static int OJCGNBENKJD(int BKOOOMNKCNJ, int GJANJLILBNF, int DCLODHEKIIO, bool BBHFDLHJGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x61BA2B0", Offset = "0x61B94B0", VA = "0x1861BA2B0")]
	public static int ODODCHKNHMF(int BKOOOMNKCNJ, int GJANJLILBNF, int DCLODHEKIIO, bool BBHFDLHJGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61BA290", Offset = "0x61B9490", VA = "0x1861BA290")]
	public static int JJMGHCIEBGP(int DCLODHEKIIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61BA2A0", Offset = "0x61B94A0", VA = "0x1861BA2A0")]
	private static int NFNFGJMLANJ(int GJANJLILBNF, bool BBHFDLHJGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61BA270", Offset = "0x61B9470", VA = "0x1861BA270")]
	private static int IPBCDIFCPOI(int GJANJLILBNF, bool BBHFDLHJGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x61BA1E0", Offset = "0x61B93E0", VA = "0x1861BA1E0")]
	public static int IHDCENBJMHI(int BKOOOMNKCNJ, int GJANJLILBNF, int DCLODHEKIIO, bool BBHFDLHJGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x61B9980", Offset = "0x61B8B80", VA = "0x1861B9980")]
	public static int DHOICAILCHF(int BKOOOMNKCNJ, int GJANJLILBNF, int DCLODHEKIIO, bool BBHFDLHJGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61BA250", Offset = "0x61B9450", VA = "0x1861BA250")]
	public static int IHHHGPGKCEA(int DCLODHEKIIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x61B9A30", Offset = "0x61B8C30", VA = "0x1861B9A30")]
	public static PEIDHLNFHIH FNDCOCBIAMI(int GJANJLILBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x61B94B0", Offset = "0x61B86B0", VA = "0x1861B94B0")]
	private static PEIDHLNFHIH BHJHPCGOLNN(int GJANJLILBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61B9810", Offset = "0x61B8A10", VA = "0x1861B9810")]
	public static PEIDHLNFHIH CFCBFEJLJBJ(int GJANJLILBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61B9170", Offset = "0x61B8370", VA = "0x1861B9170")]
	private static PEIDHLNFHIH ANCJPHEPFNI(int GJANJLILBNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x61BA3D0", Offset = "0x61B95D0", VA = "0x1861BA3D0")]
	public static void PHPDGJKCMOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct NJPCKFBFBNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int BDNGIIMDMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3 BJJGNPCBCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public quaternion NNKDNJOPBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float GGNKBPHCEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float GCLINOLGKOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int CDNFDPFEBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int ONEIJGNKADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int PCJNGDPCKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool HKPFCOEPLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool ELBEIEPBNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float JGIGIHDGNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 DEBKOGKHLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool MOKIBFPOEOB;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DJGBDNNMCHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int IPGFJOKAMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int KKENMKCJOJH;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BCHGCHIAMDG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<NJPCKFBFBNO> KHNHJNHEJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<AKNBFKPBBEI> LGLPGAGFGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeArray<LEEKJDHKPJL> LLFGIIBMJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<DJGBDNNMCHK> PCBJPCEBPLG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x61AC0F0", Offset = "0x61AB2F0", VA = "0x1861AC0F0")]
	public BCHGCHIAMDG(NativeArray<AKNBFKPBBEI> LGLPGAGFGGA, int DKMFLNHKFDF = 1, Allocator ECEHKFLCCDN = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x61AC000", Offset = "0x61AB200", VA = "0x1861AC000", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct AKKNFIAKFAF : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeArray<CPDMNFHPCCF> FDOOLOJKCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<int> NCGAPGEKIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<LEEKJDHKPJL> KNMPFLFMEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeList<NJPCKFBFBNO> KHNHJNHEJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<AKNBFKPBBEI> LGLPGAGFGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<LEEKJDHKPJL> LLFGIIBMJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	public NativeArray<DJGBDNNMCHK> PCBJPCEBPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private int FGMNMNOFLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private int FIPHCPLICMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private float3 OAFOMEGLLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private quaternion GEKKCEKIGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private float3 NDEJFHBNNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NEHIJLKHFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KLCOEKGDALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NPFLIIMNBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FCCEEHPMMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> FOLIBHGBAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FJAGEKJCFOC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61ABD70", Offset = "0x61AAF70", VA = "0x1861ABD70")]
	public AKKNFIAKFAF(CDLFNPIGGEJ HDHAANKOKBI, DLNHLGCKNMF JBCHOMPAPMK, float3 GMFCJLABPEO, quaternion PLGAEONALAM, float DPFNONFGAIG, int NEGLMJNCIIJ = 0, int DBOBBPPEKOK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x61ABB40", Offset = "0x61AAD40", VA = "0x1861ABB40")]
	public AKKNFIAKFAF(BCHGCHIAMDG HDHAANKOKBI, DLNHLGCKNMF JBCHOMPAPMK, float3 GMFCJLABPEO, quaternion PLGAEONALAM, float3 DPFNONFGAIG, int NEGLMJNCIIJ = 0, int DBOBBPPEKOK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x61AAED0", Offset = "0x61AA0D0", VA = "0x1861AAED0")]
	private float3 HIMHKKPHBMF(float3 FPHFCCAHDCO, Matrix4x4 IEGPPGNBECF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61AB650", Offset = "0x61AA850", VA = "0x1861AB650")]
	private float3x3 KJEKFCLFBEH(float3x3 KLOGEDKHOMD, float3x3 NFKAPPNAMON)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61AB6D0", Offset = "0x61AA8D0", VA = "0x1861AB6D0")]
	private float NHAHHMNOONE(float LNFDMKEIMFC, float OCKFNOJIKLH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61A9BC0", Offset = "0x61A8DC0", VA = "0x1861A9BC0", Slot = "4")]
	public void Execute(int AIAMFINBMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61AAD60", Offset = "0x61A9F60", VA = "0x1861AAD60")]
	private void HDMKLILFCKF(int CMDMMLNPLPP, float3 HBEJPCPOKJI, float3 NNFMJLGEBBE, float3 OHEDMONCPFN, float AEKGFLEECNO, bool GJEOFBIKMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x61AB6E0", Offset = "0x61AA8E0", VA = "0x1861AB6E0")]
	private void OGCCGIONDGN(NJPCKFBFBNO GIEDBNLBNCN, float3 MFLOBHGAOMJ, float3x3 KDGHELGGGEP, float LNFDMKEIMFC, int CJGEDHCJHOB, int HIOFGMMLMLC, int CCLODLAJGEO, float DNEKIBBOEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61AB000", Offset = "0x61AA200", VA = "0x1861AB000")]
	private void IDOCEICCJPO(int CMDMMLNPLPP, int MPNJBPCAKOF, NJPCKFBFBNO GIEDBNLBNCN, float3 MFLOBHGAOMJ, float3x3 KDGHELGGGEP, bool HJDDPOAHKEP, float LNFDMKEIMFC, int OOGOJJHDNMB, int JNMLHAEFGBG, int CCLODLAJGEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct EAJPOKCIJOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeList<DMOHLCAHEDN> ILBKLBBBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeList<LEEKJDHKPJL> MCFENDIPLCC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x61AF390", Offset = "0x61AE590", VA = "0x1861AF390")]
	public EAJPOKCIJOB(int DKMFLNHKFDF, Allocator ECEHKFLCCDN = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61AF2F0", Offset = "0x61AE4F0", VA = "0x1861AF2F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct HLNPMABCLCB : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private enum NMIPCBNILHN
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
	private NativeList<float3> CHMABKBHJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private NativeArray<float3> LINKEBNEOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	[ReadOnly]
	private NativeList<int> DLNIFNBCDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeArray<int> HKKPFJKDNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeArray<float4> NJHPJBCCFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private NativeArray<float4> NONNDGKIOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private NativeArray<float4> CCBNBMEEDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> EAJNDEIJFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private NativeList<LEEKJDHKPJL> MNJOKGIAHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<DMOHLCAHEDN> ILBKLBBBNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<LEEKJDHKPJL> MCFENDIPLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private int FGMNMNOFLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private int FIPHCPLICMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NEHIJLKHFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KLCOEKGDALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NPFLIIMNBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FCCEEHPMMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> FOLIBHGBAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FJAGEKJCFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private float3 NDEJFHBNNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private quaternion GEKKCEKIGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private float3 OAFOMEGLLOC;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61B8F80", Offset = "0x61B8180", VA = "0x1861B8F80")]
	public HLNPMABCLCB(CDLFNPIGGEJ HDHAANKOKBI, DLNHLGCKNMF JBCHOMPAPMK, float3 GMFCJLABPEO, quaternion PLGAEONALAM, float DPFNONFGAIG, int NEGLMJNCIIJ = 0, int DBOBBPPEKOK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x61B8D90", Offset = "0x61B7F90", VA = "0x1861B8D90")]
	public HLNPMABCLCB(EAJPOKCIJOB GKNJGNIHLDH, DLNHLGCKNMF JBCHOMPAPMK, float3 GMFCJLABPEO, quaternion PLGAEONALAM, float3 DPFNONFGAIG, int NEGLMJNCIIJ = 0, int DBOBBPPEKOK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61B7D80", Offset = "0x61B6F80", VA = "0x1861B7D80", Slot = "4")]
	public void Execute(int AIAMFINBMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x61B79D0", Offset = "0x61B6BD0", VA = "0x1861B79D0")]
	private void EGOMJFAFNIO(float4x4 FFIDAFMBHAE, int AIAMFINBMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61B8CE0", Offset = "0x61B7EE0", VA = "0x1861B8CE0")]
	private NMIPCBNILHN FDNKNGFMEHH(float3 NNFMJLGEBBE)
	{
		return default(NMIPCBNILHN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x61B7980", Offset = "0x61B6B80", VA = "0x1861B7980")]
	private float4 CDOJHDJENJF(NMIPCBNILHN AHPMPFMNAEC, int ILNNGHKJMBD)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61B8D50", Offset = "0x61B7F50", VA = "0x1861B8D50")]
	private float2 IDPOJMMDAPH(NMIPCBNILHN AHPMPFMNAEC, float3 HBEJPCPOKJI)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JNMPMBKLGLK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum IIMEMIOGGOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static JNMPMBKLGLK LNBIPJDBGMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float3 PNLEOOLJLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3x3 CJDLFPMECND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 OMLLDMPJCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public IIMEMIOGGOI OFDHKLACDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 KHEAKFEKMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 JIKPJJBHGMB;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DOGDMICGGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x61BACF0", Offset = "0x61B9EF0", VA = "0x1861BACF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 DBNNONHHNII
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x61BB190", Offset = "0x61BA390", VA = "0x1861BB190")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61BB2E0", Offset = "0x61BA4E0", VA = "0x1861BB2E0")]
	public JNMPMBKLGLK(float3 HBEJPCPOKJI, quaternion KIIONLKEIBO, float3 DKMFLNHKFDF, IIMEMIOGGOI DMEGHACCPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61BAF90", Offset = "0x61BA190", VA = "0x1861BAF90")]
	public float NKAIIBDCDPC(float3 MFLOBHGAOMJ, float KBMLMCBNJNN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61BAC00", Offset = "0x61B9E00", VA = "0x1861BAC00")]
	public bool DFKLGFAMNAP(float3 NNFMJLGEBBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61BAA50", Offset = "0x61B9C50", VA = "0x1861BAA50")]
	public void AMBLCABNAKB(float3 CCFIKGNLBHA, float3x3 GKNJLNMBPKB, float PAINDJHDDOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x61BA950", Offset = "0x61B9B50", VA = "0x1861BA950")]
	private void AJGIFJMLNNC(float3 CPPDJJKKMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x61BAD00", Offset = "0x61B9F00", VA = "0x1861BAD00")]
	public void JKHGIGFPJOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct KKJIOHPCGCJ : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeList<JNMPMBKLGLK> GKNJGNIHLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeList<float3> DABNGMABAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeList<int> GMLINIGJIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> JHFNGNPECEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<LEEKJDHKPJL> MCFENDIPLCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int IIMNKGHNLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int HOLKPOBFOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private float KBMLMCBNJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private float IGIKGJIIGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> CEFBCKMKBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> DKHBOEDLCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> ONMCEBNAKEN;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x61BBEF0", Offset = "0x61BB0F0", VA = "0x1861BBEF0")]
	public KKJIOHPCGCJ(DLNHLGCKNMF JLFPINMNNGM, float HAHEPLHKKIM, int CMAABPPFEEC, int CJGEDHCJHOB, NativeList<JNMPMBKLGLK> GKNJGNIHLDH, NativeArray<int> JHFNGNPECEB, NativeList<LEEKJDHKPJL> MCFENDIPLCC, NNNGHDLACJL GDEGGFCOCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x61BB450", Offset = "0x61BA650", VA = "0x1861BB450", Slot = "4")]
	public void Execute(int KIMPGAJAMDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x61BBB90", Offset = "0x61BAD90", VA = "0x1861BBB90")]
	private bool JCAMFGKNHBK(JNMPMBKLGLK HEFLGIBKJHK, JNMPMBKLGLK LPGCLIAKDPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61BBC50", Offset = "0x61BAE50", VA = "0x1861BBC50")]
	private bool ONPNMDCAFMB(JNMPMBKLGLK DFLLICFNDLH, int CINAKMCGDIH, int MIBKAFKLBKO, int KDDPFANFBHO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NNNGHDLACJL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public NativeArray<bool> NMOOEJFJNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeArray<int> CFGDCMCJICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> DIGFGDIECDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float> HPFIHGJPPCA;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x61BC6D0", Offset = "0x61BB8D0", VA = "0x1861BC6D0")]
	public void MFAMJJBKICE(int AKJJHODFGFH, int NFPPLLIAOCG, Allocator ECEHKFLCCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61BC5C0", Offset = "0x61BB7C0", VA = "0x1861BC5C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61BC5E0", Offset = "0x61BB7E0", VA = "0x1861BC5E0")]
	public void GFBILCCCLII(JobHandle EIMNPGHHIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public NNNGHDLACJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[BurstCompile]
public struct FFFKKFBNCBH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeList<float3> DABNGMABAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<float3> PAPPGFPLFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<float4> JOJOHLNLOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<float2> MFKKABMAGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private NativeList<int> GMLINIGJIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PHKNKHJEDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NativeArray<int> DEHCEAEIPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[ReadOnly]
	private NativeArray<bool> CEFBCKMKBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[ReadOnly]
	private NativeArray<bool> DKHBOEDLCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[ReadOnly]
	private int NEGLMJNCIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private int DBOBBPPEKOK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x61B0CB0", Offset = "0x61AFEB0", VA = "0x1861B0CB0")]
	public FFFKKFBNCBH(DLNHLGCKNMF JLFPINMNNGM, NNNGHDLACJL GDEGGFCOCON, int DBOBBPPEKOK = 0, int NEGLMJNCIIJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61B08D0", Offset = "0x61AFAD0", VA = "0x1861B08D0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61B0870", Offset = "0x61AFA70", VA = "0x1861B0870")]
	private void DJHDAGGGKHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CEGCNMNDICI
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x25EB7F0", Offset = "0x25EA9F0", VA = "0x1825EB7F0")]
	public static bool DEALAOILJCI<T>(NativeArray<T> NPPGGGEFJIJ, int DKMFLNHKFDF, Allocator ECEHKFLCCDN, NativeArrayOptions AGAKJLDACOH = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x25EB890", Offset = "0x25EAA90", VA = "0x1825EB890")]
	public static bool DEALAOILJCI<T>(NativeList<T> MJCNKJMKHLD, int DKMFLNHKFDF, Allocator ECEHKFLCCDN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum MOFGHOIADPN
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
public interface MCEDACABFLO
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int KHEDOIGIICK(MOFGHOIADPN BKOOOMNKCNJ);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int NILBEJOLABO(MOFGHOIADPN BKOOOMNKCNJ);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds JNMEFINMJNN();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IINAGHLLDJL(MOFGHOIADPN BKOOOMNKCNJ, CDLFNPIGGEJ BMBGDCGNPCO, int FNOPHMCINKE = -1);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DLNHLGCKNMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const int LOGGMBKLMKM = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<float3> PGFFHPNADKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<float3> PLHEFNDLODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float4> DKHKMBCINFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float4> CJLLOLNFCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeArray<float2> AENHDJNAMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<int> INDIGAAEALF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool IOBGPOINBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x61AE4A0", Offset = "0x61AD6A0", VA = "0x1861AE4A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GJKEDBHOEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x61AEB50", Offset = "0x61ADD50", VA = "0x1861AEB50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int PMKAIBBIGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x61AF230", Offset = "0x61AE430", VA = "0x1861AF230")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool IFLCBICFIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x61AE4E0", Offset = "0x61AD6E0", VA = "0x1861AE4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61AEB90", Offset = "0x61ADD90", VA = "0x1861AEB90", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61AEDF0", Offset = "0x61ADFF0", VA = "0x1861AEDF0")]
	public void MFAMJJBKICE(int AKJJHODFGFH, int NFPPLLIAOCG, Allocator ECEHKFLCCDN, bool DKGNOMDHPAK, bool MIADGKCCABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61AF270", Offset = "0x61AE470", VA = "0x1861AF270")]
	public void PNEJEMAFDIO(int AKJJHODFGFH, int NFPPLLIAOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61AE0C0", Offset = "0x61AD2C0", VA = "0x1861AE0C0", Slot = "6")]
	public bool BBKNFEIGBDM(Mesh JLFPINMNNGM, bool BPDNNPHCALE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61AE520", Offset = "0x61AD720", VA = "0x1861AE520")]
	public bool CNCOKLPFBAB(Mesh JLFPINMNNGM, DLNHLGCKNMF BCLFMNBIOIE, bool BPDNNPHCALE = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61AEFC0", Offset = "0x61AE1C0", VA = "0x1861AEFC0")]
	public void MFGJAPNDLBI(DLNHLGCKNMF JLFPINMNNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61ADF80", Offset = "0x61AD180", VA = "0x1861ADF80")]
	public DLNHLGCKNMF BADHGPGGKLB(Allocator ECEHKFLCCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61AECA0", Offset = "0x61ADEA0", VA = "0x1861AECA0")]
	public long IJBKILOGEHC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x61AED90", Offset = "0x61ADF90", VA = "0x1861AED90")]
	public void LMAEGGJHMLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	public DLNHLGCKNMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class HDHMJOIDJEK
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61B7830", Offset = "0x61B6A30", VA = "0x1861B7830")]
	public static void PHPDGJKCMOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EKGEOMMMCPM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeList<float3> PGFFHPNADKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> PLHEFNDLODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<int> ABFNHFNPPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeArray<float4> CBJAKHFOHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<float4> HEHBJOCHDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<float4> LFHFOGEDNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<float3> JMBBGFHFOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<int> INDIGAAEALF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int GJKEDBHOEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x61AF910", Offset = "0x61AEB10", VA = "0x1861AF910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PMKAIBBIGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x61B0320", Offset = "0x61AF520", VA = "0x1861B0320")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PIIICHLBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x61AF950", Offset = "0x61AEB50", VA = "0x1861AF950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61B0650", Offset = "0x61AF850", VA = "0x1861B0650")]
	public EKGEOMMMCPM(int AKJJHODFGFH, int NFPPLLIAOCG, int NBFIHOENLHC, Allocator ECEHKFLCCDN = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61B0360", Offset = "0x61AF560", VA = "0x1861B0360")]
	public EKGEOMMMCPM(Mesh JLFPINMNNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61AF990", Offset = "0x61AEB90", VA = "0x1861AF990", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x61AFAA0", Offset = "0x61AECA0", VA = "0x1861AFAA0")]
	public void MFGJAPNDLBI(EKGEOMMMCPM JLFPINMNNGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61AF480", Offset = "0x61AE680", VA = "0x1861AF480")]
	private void BAGDHKDJIAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61AFDA0", Offset = "0x61AEFA0", VA = "0x1861AFDA0")]
	private void OGBKEOJOOIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LEEKJDHKPJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int DACELEMPMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int GJKEDBHOEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public int CBFGNOKNBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int PMKAIBBIGNI;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1227200", Offset = "0x1226400", VA = "0x181227200")]
	public LEEKJDHKPJL(int CJGEDHCJHOB, int JEOBOGLNJJI, int CMAABPPFEEC, int OPAJBDGDAJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NMHMLGLJIFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<LEEKJDHKPJL> HAGAPEMFPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8507D0", Offset = "0x84F9D0", VA = "0x1808507D0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<LEEKJDHKPJL>);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x850870", Offset = "0x84FA70", VA = "0x180850870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EKGEOMMMCPM OKEOGJBMPPO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3E0", Offset = "0x7B95E0", VA = "0x1807BA3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x61BC000", Offset = "0x61BB200", VA = "0x1861BC000")]
	public NMHMLGLJIFP(IEnumerable<EKGEOMMMCPM> LHDAANELKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61BBF90", Offset = "0x61BB190", VA = "0x1861BBF90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum DCDONBDHFKJ
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class AGHJJLJNBKF
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static NativeArray<float2> HACIMAJKLKC;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static NativeArray<float3> JDAOFIGLABO;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static NativeArray<float4> CDDPPPFMLGB;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static NativeArray<int> IJGLAIPMGIE;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61A9AA0", Offset = "0x61A8CA0", VA = "0x1861A9AA0")]
	public static void PHPDGJKCMOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x61A9990", Offset = "0x61A8B90", VA = "0x1861A9990")]
	public static NativeArray<float2> OACKAEHBJHP(NativeArray<float2> HICGLEIJMKB, int EMMOMDGKKNN, NativeArray<float2> KCLJNDFGCBB, int IFIGBCPNNAN)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x61A9660", Offset = "0x61A8860", VA = "0x1861A9660")]
	public static NativeArray<float3> CDFJHHGHFAM(NativeArray<float3> HICGLEIJMKB, int EMMOMDGKKNN, NativeArray<float3> KCLJNDFGCBB, int IFIGBCPNNAN)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x61A9880", Offset = "0x61A8A80", VA = "0x1861A9880")]
	public static NativeArray<float4> MECOCFFJHKF(NativeArray<float4> HICGLEIJMKB, int EMMOMDGKKNN, NativeArray<float4> KCLJNDFGCBB, int IFIGBCPNNAN)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x61A9770", Offset = "0x61A8970", VA = "0x1861A9770")]
	public static NativeArray<int> FELJPGBNLED(NativeArray<int> HICGLEIJMKB, int EMMOMDGKKNN, NativeArray<int> KCLJNDFGCBB, int IFIGBCPNNAN)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F470", Offset = "0x2D4E670", VA = "0x182D4F470")]
	private static void ENLFIMHFEFI<T>(NativeArray<T> NPPGGGEFJIJ, int IFNKPAPPEEO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F670", Offset = "0x2D4E870", VA = "0x182D4F670")]
	private static void KNJBLENFGNI<T>(NativeArray<T> HICGLEIJMKB, int EMMOMDGKKNN, NativeArray<T> KCLJNDFGCBB, int IFIGBCPNNAN, NativeArray<T> GBMFANKOHJP) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class FJKMBHPFOBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal enum NJBKENHILPO
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
	public class KEIFOKLAKOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public OPJJAGBCJNB JLFPINMNNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int FNLOBININBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int NHIMKCBOFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public float CKNHMFBFJGH;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x61BB410", Offset = "0x61BA610", VA = "0x1861BB410")]
		public KEIFOKLAKOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x61BB3D0", Offset = "0x61BA5D0", VA = "0x1861BB3D0")]
		public void GFBILCCCLII()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<MCEDACABFLO> IPKEBFFPHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly BMEHHGBDHJD BFPBACPAIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int JEOBOGLNJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int OPAJBDGDAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool EIHBOBPBPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal bool LACOLJCPDDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	internal bool JLEMBGGFMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal NJBKENHILPO MJCOPLGCMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal float3 KLEEPHBDMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	internal float3 CALFMHKFOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal float BGNEDEHDMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal int DAJIBEKMICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	internal int KIKMIHMBMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int PGJKBBDMPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float OMPKGBDDFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float ILEODNJMDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int FIIFMDOGALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private long POKCEOLAAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private long OFDJGEIMIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private long HPKEKPNBHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int LPCDMBFPNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private DLNHLGCKNMF GPCIGKCJENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private int GOFLFHNPPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private List<KEIFOKLAKOP> NJBCNALLJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal float BMKKHHDEKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool DKAICOPLOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FLLFHGEPJAE NFAFNKNBNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private JobHandle FDCJLOILBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	internal NativeArray<long> NGMKGLAPNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool HPOHPOMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private JobHandle KHIDLIBDDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private DLNHLGCKNMF HJOKDLODLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform IPOIEFLBPJE;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh OKEOGJBMPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3D0", Offset = "0x7B95D0", VA = "0x1807BA3D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3F0", Offset = "0x7B95F0", VA = "0x1807BA3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer PIADDKEEGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7BA420", Offset = "0x7B9620", VA = "0x1807BA420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int IBMGAKIIJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA30B20", Offset = "0xA2FD20", VA = "0x180A30B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int PPMLFKPOODI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E80", Offset = "0x7F1080", VA = "0x1807F1E80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GJKEDBHOEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x61B19C0", Offset = "0x61B0BC0", VA = "0x1861B19C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<MCEDACABFLO> ENFFOOBLFGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x61B1E70", Offset = "0x61B1070", VA = "0x1861B1E70")]
	public void ENMBONOFJHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x61B10F0", Offset = "0x61B02F0", VA = "0x1861B10F0")]
	public void BMHBONIDALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x61B1010", Offset = "0x61B0210", VA = "0x1861B1010")]
	public void BBNEEOCOPNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61B5890", Offset = "0x61B4A90", VA = "0x1861B5890")]
	public FJKMBHPFOBJ(string NLBAJPAADNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61B2200", Offset = "0x61B1400", VA = "0x1861B2200")]
	public void GFBILCCCLII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x61B2060", Offset = "0x61B1260", VA = "0x1861B2060")]
	public void FNNIBKDJMHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x61B32A0", Offset = "0x61B24A0", VA = "0x1861B32A0")]
	public void KGAFJBPNBHA(MCEDACABFLO BKBGNEOLGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61B1A20", Offset = "0x61B0C20", VA = "0x1861B1A20")]
	private void DHJGKAAMMHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61B1DC0", Offset = "0x61B0FC0", VA = "0x1861B1DC0")]
	public bool DPMLJLBIHFE(MCEDACABFLO BKBGNEOLGCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61B4220", Offset = "0x61B3420", VA = "0x1861B4220")]
	public bool NGGGJPKJNOI(MCEDACABFLO BKBGNEOLGCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x61B1C90", Offset = "0x61B0E90", VA = "0x1861B1C90", Slot = "4")]
	public virtual void DIBNFBDIGAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x61B2920", Offset = "0x61B1B20", VA = "0x1861B2920")]
	public void IOMMHJMOKDF(Transform EELPEPBCIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x61B2A40", Offset = "0x61B1C40", VA = "0x1861B2A40")]
	public bool JJDGCKFDBME(Transform EELPEPBCIDH, [Out] bool FMODCJOAIHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x61B49E0", Offset = "0x61B3BE0", VA = "0x1861B49E0")]
	public bool OEBKGDOFOCB(bool DJJAIACNHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x61B22D0", Offset = "0x61B14D0", VA = "0x1861B22D0")]
	public void GNLCOPGHOIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x61B2990", Offset = "0x61B1B90", VA = "0x1861B2990")]
	public bool JFFCCPCJPLE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x61B39C0", Offset = "0x61B2BC0", VA = "0x1861B39C0")]
	public bool LOABKLNKKOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x61B19E0", Offset = "0x61B0BE0", VA = "0x1861B19E0")]
	public bool DDJINIIAFMN(Transform ABJBIFMIENO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x61B2360", Offset = "0x61B1560", VA = "0x1861B2360")]
	public void IENHJPGKGFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61B0F60", Offset = "0x61B0160", VA = "0x1861B0F60")]
	public bool AIJGAIIFDFN(bool DJJAIACNHHB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61B3940", Offset = "0x61B2B40", VA = "0x1861B3940")]
	public void LLBNEIDBEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61B4280", Offset = "0x61B3480", VA = "0x1861B4280")]
	public void NHLKJJGFPGC(DLNHLGCKNMF JLFPINMNNGM, int MPEMLAEJKIC, float NAMLBFBANCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x61B2420", Offset = "0x61B1620", VA = "0x1861B2420")]
	public void IJFCNNAAAOE(OPJJAGBCJNB FGJHBCJIAJP, int MPEMLAEJKIC, float NAMLBFBANCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x61B2410", Offset = "0x61B1610", VA = "0x1861B2410")]
	public long IJBKILOGEHC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C9370", Offset = "0x7C8570", VA = "0x1807C9370")]
	public long JACFAHPJNAA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x61B46E0", Offset = "0x61B38E0", VA = "0x1861B46E0")]
	public void OBBNHHMAPOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xA89DA0", Offset = "0xA88FA0", VA = "0x180A89DA0")]
	internal void JGKKGEAKLMB(NJBKENHILPO AHBNOFEOHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x61B20B0", Offset = "0x61B12B0", VA = "0x1861B20B0")]
	private void FPGEFJNBBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x61B3380", Offset = "0x61B2580", VA = "0x1861B3380")]
	private float KJAFPNDDFII()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x61B2450", Offset = "0x61B1650", VA = "0x1861B2450")]
	public void INJEIBELJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x61B3270", Offset = "0x61B2470", VA = "0x1861B3270")]
	private void JOEPNOFLKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x61B1E80", Offset = "0x61B1080", VA = "0x1861B1E80")]
	private void FDNHFJFNCNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x61B42B0", Offset = "0x61B34B0", VA = "0x1861B42B0")]
	private void NIPKANIGMMF(DLNHLGCKNMF GMEHBLMAMAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x61B0D30", Offset = "0x61AFF30", VA = "0x1861B0D30")]
	private void AHFFLNPIGNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x61B11D0", Offset = "0x61B03D0", VA = "0x1861B11D0")]
	private void CFBJCAGPHNM(DLNHLGCKNMF JLFPINMNNGM, OPJJAGBCJNB FGJHBCJIAJP, int MPEMLAEJKIC, float NAMLBFBANCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal struct FLLFHGEPJAE : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct CBJKBCPDLDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int ADLCOKHHFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int HFMDNJGCJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int AOLNOIAILAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int MCKPADFNDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int FLIEIMFDBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int EPKJBMLNJAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int FNLOBININBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int NHIMKCBOFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public float CKNHMFBFJGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct PPADNNBMKBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NativeArray<float3> PGFFHPNADKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public NativeArray<float3> PLHEFNDLODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public NativeArray<float4> DKHKMBCINFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NativeArray<float4> CJLLOLNFCPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public NativeArray<float2> AENHDJNAMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public NativeArray<int> INDIGAAEALF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool PIODNAEOPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int GJKEDBHOEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int PMKAIBBIGNI;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x61C4CE0", Offset = "0x61C3EE0", VA = "0x1861C4CE0")]
		public void MFAMJJBKICE(int AKJJHODFGFH, int NFPPLLIAOCG, Allocator ECEHKFLCCDN, bool MIADGKCCABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x61C4A90", Offset = "0x61C3C90", VA = "0x1861C4A90")]
		public static PPADNNBMKBJ JPIMIAIINNE(DLNHLGCKNMF HJFOOBIEOKH)
		{
			return default(PPADNNBMKBJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x61C49D0", Offset = "0x61C3BD0", VA = "0x1861C49D0")]
		public void GFBILCCCLII()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<CBJKBCPDLDB> BCMFJNFBLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private PPADNNBMKBJ FNJHOEKBHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private PPADNNBMKBJ GMEHBLMAMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private float3 LNLDLOMOMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float3 AMGAFKNNMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* FCIBAOGAIAD;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x61B74E0", Offset = "0x61B66E0", VA = "0x1861B74E0")]
	public FLLFHGEPJAE([In] List<FJKMBHPFOBJ.KEIFOKLAKOP> NJFBODOLJAC, [In] DLNHLGCKNMF HHEBGNBDDDE, [In] FJKMBHPFOBJ LPHBGDENDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x61B5A80", Offset = "0x61B4C80", VA = "0x1861B5A80", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x61B7220", Offset = "0x61B6420", VA = "0x1861B7220")]
	public void NLEGEBDJJLF(List<FJKMBHPFOBJ.KEIFOKLAKOP> GANOFJNPDCB, [In] FJKMBHPFOBJ LPHBGDENDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x61B7200", Offset = "0x61B6400", VA = "0x1861B7200")]
	private bool NALIMLEMEEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x61B5A90", Offset = "0x61B4C90", VA = "0x1861B5A90")]
	private OPJJAGBCJNB FIHCKHFCMME(int MFMJCPLFLCM, Allocator ECEHKFLCCDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x61B5E80", Offset = "0x61B5080", VA = "0x1861B5E80")]
	private void HLNHCJBPMOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x61B5B60", Offset = "0x61B4D60", VA = "0x1861B5B60")]
	private CBJKBCPDLDB GOJLNBIKDAC([In] CBJKBCPDLDB FGAPDJKPNJK, int JJMFDMGKHKA, [In] NativeArray<int> GMLINIGJIKL, [In] NativeArray<bool> DKHBOEDLCGC, NativeArray<int> ENPCOIMJDOL)
	{
		return default(CBJKBCPDLDB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x61B7140", Offset = "0x61B6340", VA = "0x1861B7140")]
	private static int IPEAAJNDPLP(NativeArray<int> GMLINIGJIKL, int COBBOJFCEHL, int COOKMKOMMIB, int BMLBAPGPBKI)
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
		private static readonly ProfilerMarker MPGMCEDDGOE;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly ProfilerMarker EGFBNBGGDLD;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly ProfilerMarker OEKLBPAEEOE;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal const int MENCOHBGCOJ = 65000;

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
		private Dictionary<Material, List<FJKMBHPFOBJ>> LCKCCNCIFLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal List<FJKMBHPFOBJ> HBEDLDPMAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private List<MeshRenderer> EKDIPNCEMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool GBAALBOHEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int DCOLAFJMBBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private Dictionary<int, float> DFNDIJENJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private Dictionary<int, Color> IIOBHAKOEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<int, Vector4> NAMMKNLPJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private Dictionary<int, Matrix4x4> PGCIDIEKNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private FJKMBHPFOBJ HPANEDKEGHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Material ANPKDDMHLJO;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> HBHOLBLEGCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int DJAKJHPGAFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x61C33D0", Offset = "0x61C25D0", VA = "0x1861C33D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x61C09D0", Offset = "0x61BFBD0", VA = "0x1861C09D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61BFE80", Offset = "0x61BF080", VA = "0x1861BFE80")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x61BF2C0", Offset = "0x61BE4C0", VA = "0x1861BF2C0")]
		public FJKMBHPFOBJ AddToBatchedMesh(MCEDACABFLO ODLDEAJEKHM, Material FCJNMBKENDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x61C2670", Offset = "0x61C1870", VA = "0x1861C2670")]
		public void RemoveFromBatchedMesh(MCEDACABFLO JLFPINMNNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x61BF950", Offset = "0x61BEB50", VA = "0x1861BF950")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x61C27B0", Offset = "0x61C19B0", VA = "0x1861C27B0")]
		public void SetMaterialProperty(int MANOFLIJPJG, Color DKDNEEAJCMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x61C2C40", Offset = "0x61C1E40", VA = "0x1861C2C40")]
		public void SetMaterialProperty(int MANOFLIJPJG, float AFCGKMGKPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x61C2E60", Offset = "0x61C2060", VA = "0x1861C2E60")]
		public void SetMaterialProperty(int MANOFLIJPJG, Vector4 ANHBPHNMEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x61C29E0", Offset = "0x61C1BE0", VA = "0x1861C29E0")]
		public void SetMaterialProperty(int MANOFLIJPJG, Matrix4x4 DHDIMMOMLDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x61BF360", Offset = "0x61BE560", VA = "0x1861BF360")]
		private void CJHLHMHJDPH(Renderer HGMIPNBELIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61C0220", Offset = "0x61BF420", VA = "0x1861C0220")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x61C09C0", Offset = "0x61BFBC0", VA = "0x1861C09C0")]
		private void ODOIOKHEALL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x61C05C0", Offset = "0x61BF7C0", VA = "0x1861C05C0")]
		private void NPJNNCEOICC(bool IJBHNHECNCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x61C0250", Offset = "0x61BF450", VA = "0x1861C0250")]
		private FJKMBHPFOBJ ILGONDBNHID(MCEDACABFLO JLFPINMNNGM, Material FCJNMBKENDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x61C0040", Offset = "0x61BF240", VA = "0x1861C0040")]
		private FJKMBHPFOBJ EKOCEGFNDCJ(Material FCJNMBKENDK, int ALCFAPBBCCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x61BFA80", Offset = "0x61BEC80", VA = "0x1861BFA80")]
		private FJKMBHPFOBJ DLIBLGEOEEC(Material FCJNMBKENDK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x170E2C0", Offset = "0x170D4C0", VA = "0x18170E2C0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x61C0460", Offset = "0x61BF660", VA = "0x1861C0460")]
		public void MarkDirty(MCEDACABFLO JLFPINMNNGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x61C1E90", Offset = "0x61C1090", VA = "0x1861C1E90")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x61C0230", Offset = "0x61BF430", VA = "0x1861C0230")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61C0CC0", Offset = "0x61BFEC0", VA = "0x1861C0CC0")]
		public void RebatchOptimally()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x61C3160", Offset = "0x61C2360", VA = "0x1861C3160")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MLLLGKDKFFK
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static bool GGPCGEAGFAK;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static Vector3 NFPPDMEFFDC;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int CDGONNBMAKM;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int LJBGMPHJOHK;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int OLCAHFJFBOG;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int AJELLFIGHCM;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static List<BatchedMeshRenderer> JPMIEABFMDM;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool ICPIOPBLEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x61C4460", Offset = "0x61C3660", VA = "0x1861C4460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x61C4770", Offset = "0x61C3970", VA = "0x1861C4770")]
	public static void PIODBADEDMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x61C4520", Offset = "0x61C3720", VA = "0x1861C4520")]
	public static void MEHLGBOBELF(BatchedMeshRenderer PNLEAKLGICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x61C3420", Offset = "0x61C2620", VA = "0x1861C3420")]
	public static void CFGAGMIFCHI(BatchedMeshRenderer PNLEAKLGICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x61C3840", Offset = "0x61C2A40", VA = "0x1861C3840")]
	public static void LOABKLNKKOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x61C35B0", Offset = "0x61C27B0", VA = "0x1861C35B0")]
	public static void HICPLMAMEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x61C34C0", Offset = "0x61C26C0", VA = "0x1861C34C0")]
	public static int DLLEGFPDNLH()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OMDIEGOMFMC<KeyType> : FJKMBHPFOBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Dictionary<KeyType, MCEDACABFLO> NCJLOONAOOG;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x407DBF0", Offset = "0x407CDF0", VA = "0x18407DBF0")]
	public OMDIEGOMFMC(string NLBAJPAADNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x407DBA0", Offset = "0x407CDA0", VA = "0x18407DBA0")]
	public void KGAFJBPNBHA(KeyType HKNPGHOCJDO, MCEDACABFLO BKBGNEOLGCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x407D840", Offset = "0x407CA40", VA = "0x18407D840")]
	public bool CCBHNPMOKOH(KeyType HKNPGHOCJDO, MCEDACABFLO JKHJBHFCPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x407DAF0", Offset = "0x407CCF0", VA = "0x18407DAF0")]
	public void IIAJDEHIMCD(KeyType HKNPGHOCJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x407DA00", Offset = "0x407CC00", VA = "0x18407DA00", Slot = "4")]
	public override void DIBNFBDIGAO()
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
