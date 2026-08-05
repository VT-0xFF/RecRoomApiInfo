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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7B83D0", Offset = "0x7B71D0", VA = "0x1807B83D0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct AADGNKDEFDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int INILEJHBGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 LCPKEFAJNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion PAEPMBEMNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 INFIEOMJEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int GMHLOAKCMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int KCAFBEKNJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int HCBPANOMIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float OOICLHOICLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 NHHOCHPJONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool FPILGBNAPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public GJDBFAJDNJA LOLEBKHNBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 GMEFJEJFECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float FEMNNAOOPDM;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CGONFMMPGJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static EMKKKJMEPJO GPGPAJEJGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<AADGNKDEFDF> JMMHFNKNHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<MPCIFMIIGOJ> CHBCDNMBEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<GEMLIMHPPDB> GBDEHIOINDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<HLECICCLKDJ> FGHMDKFMHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<MPCIFMIIGOJ> FPGNLNMJBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<HKLHAPEABCL> IHBPIAJBBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<HLECICCLKDJ>> JJIBKFMNANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<BDPFBMDHMLL> BOKGEAJOKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> AAICDOJAEAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DJJCNCNJDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBA33A0", Offset = "0xBA21A0", VA = "0x180BA33A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xBA1B00", Offset = "0xBA0900", VA = "0x180BA1B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int MJIIMMOILLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBA33B0", Offset = "0xBA21B0", VA = "0x180BA33B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBA24A0", Offset = "0xBA12A0", VA = "0x180BA24A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6020000", Offset = "0x601EE00", VA = "0x186020000")]
	public CGONFMMPGJP(int DJDICEDOCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x601EA10", Offset = "0x601D810", VA = "0x18601EA10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x601FA40", Offset = "0x601E840", VA = "0x18601FA40")]
	public void GDLOLPODHHB(JobHandle NDHGJDFCLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x601E4B0", Offset = "0x601D2B0", VA = "0x18601E4B0")]
	public void CPEEGPAMGAC(AADGNKDEFDF HKPHNGEBIED, BDPFBMDHMLL HJHPFPDJIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x601FEC0", Offset = "0x601ECC0", VA = "0x18601FEC0")]
	public void OLNDPHDJKDK(GEMLIMHPPDB HKPHNGEBIED, NativeArray<HLECICCLKDJ> IKFDMNDAOCF, int JNGDKNNMLKM, int JGGLBGKHCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x601EA30", Offset = "0x601D830", VA = "0x18601EA30")]
	public JobHandle EJDMJKEEOLO(DLJCFELHJEE BCLABIPAPKM, LAAAGJPBBGJ OAEFCHHAFGA, float3 GDCAGGCHEPC, quaternion BBECHMLNDBH, float KPCMAFDAKKM, bool GEPGDFADCIB, int ANBHLGHGIGN = 0, int FJNFOKKKMHJ = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x601E6D0", Offset = "0x601D4D0", VA = "0x18601E6D0")]
	public static JobHandle DBNJMIOKLBL(FMAEOJDLELL JBKKCCIEMML, DLJCFELHJEE BCLABIPAPKM, AADGNKDEFDF HKPHNGEBIED, JobHandle NDHGJDFCLHE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x601FC10", Offset = "0x601EA10", VA = "0x18601FC10")]
	public static JobHandle MGFHLBEBDID(LNKLEFGKLGK JBKKCCIEMML, DLJCFELHJEE BCLABIPAPKM, GEMLIMHPPDB HKPHNGEBIED, NativeArray<HLECICCLKDJ> IKFDMNDAOCF, int JNGDKNNMLKM, int JGGLBGKHCMP, JobHandle NDHGJDFCLHE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LILCCODLCJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 ICGAHFEOGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 JKBAMAFHNGL;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NHNINHKFKCP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<LILCCODLCJA> JCGJPDDHIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> GKHEILLBJNG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DJJCNCNJDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7944A0", Offset = "0x7932A0", VA = "0x1807944A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MJIIMMOILLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7944C0", Offset = "0x7932C0", VA = "0x1807944C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60267B0", Offset = "0x60255B0", VA = "0x1860267B0")]
	public NHNINHKFKCP(int EKEDMMAJONM, int HKNOEIEGFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6026750", Offset = "0x6025550", VA = "0x186026750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6026670", Offset = "0x6025470", VA = "0x186026670")]
	public void DEIAFMCPDCO(NHNINHKFKCP KGPPINABBNK, int FDFIKEMJOMD, int MIMLCMKCBBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PBIBOFPKBMK
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static NHNINHKFKCP ELDLODOEBGF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<MPCIFMIIGOJ> OEGKCBODKGE;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] EPFIMODNOHL;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool DPBABGALAKN;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, NHNINHKFKCP> GBHBILEDMEO;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, NHNINHKFKCP> JMPGPENBEJB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool FKCPHDOBCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6029910", Offset = "0x6028710", VA = "0x186029910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<MPCIFMIIGOJ> JJMFNKMKJJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6029AA0", Offset = "0x60288A0", VA = "0x186029AA0")]
		get
		{
			return default(NativeList<MPCIFMIIGOJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NHNINHKFKCP LPMHLGGDOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x602A320", Offset = "0x6029120", VA = "0x18602A320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x602A3C0", Offset = "0x60291C0", VA = "0x18602A3C0")]
	private static void OEOOJAABLKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6029700", Offset = "0x6028500", VA = "0x186029700")]
	public static int APKFDIEDGDC(bool KIDFEHNPBGN, int NAHMIMMAJJB, bool JLKCKNOOICE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6029990", Offset = "0x6028790", VA = "0x186029990")]
	private static int IIANMCBPPBB(int NAHMIMMAJJB, bool HLMGMICOHPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60297F0", Offset = "0x60285F0", VA = "0x1860297F0")]
	private static int DGFDPIGIMEN(int NAHMIMMAJJB, bool HLMGMICOHPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6029B40", Offset = "0x6028940", VA = "0x186029B40")]
	public static int KELIFJOIMGL(int CPNHGLGJPKN, int NAHMIMMAJJB, int LLHBDCOLNDA, bool HLMGMICOHPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6029810", Offset = "0x6028610", VA = "0x186029810")]
	public static int FBGFAICKOBN(int CPNHGLGJPKN, int NAHMIMMAJJB, int LLHBDCOLNDA, bool HLMGMICOHPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6029800", Offset = "0x6028600", VA = "0x186029800")]
	public static int EPLFEFDFJHM(int LLHBDCOLNDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6029730", Offset = "0x6028530", VA = "0x186029730")]
	private static int BEKDIJBHJBG(int NAHMIMMAJJB, bool HLMGMICOHPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60297D0", Offset = "0x60285D0", VA = "0x1860297D0")]
	private static int CJLAKIIHFCE(int NAHMIMMAJJB, bool HLMGMICOHPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60298A0", Offset = "0x60286A0", VA = "0x1860298A0")]
	public static int FEHPOLBOBNJ(int CPNHGLGJPKN, int NAHMIMMAJJB, int LLHBDCOLNDA, bool HLMGMICOHPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6029740", Offset = "0x6028540", VA = "0x186029740")]
	public static int CFIJMDBLDNA(int CPNHGLGJPKN, int NAHMIMMAJJB, int LLHBDCOLNDA, bool HLMGMICOHPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6029450", Offset = "0x6028250", VA = "0x186029450")]
	public static int AKLBFOFFOKK(int LLHBDCOLNDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60299B0", Offset = "0x60287B0", VA = "0x1860299B0")]
	public static NHNINHKFKCP JIPEDEKOGNI(int NAHMIMMAJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6029470", Offset = "0x6028270", VA = "0x186029470")]
	private static NHNINHKFKCP ANLEBABEJDP(int NAHMIMMAJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x602A9D0", Offset = "0x60297D0", VA = "0x18602A9D0")]
	public static NHNINHKFKCP PFLINOBHEKG(int NAHMIMMAJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6029FE0", Offset = "0x6028DE0", VA = "0x186029FE0")]
	private static NHNINHKFKCP MAEJLHHBDND(int NAHMIMMAJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6029BD0", Offset = "0x60289D0", VA = "0x186029BD0")]
	public static void LHEALPDOPLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct GEMLIMHPPDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int MNDPEBAHGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 LCPKEFAJNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion PAEPMBEMNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float INFIEOMJEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float GNOLGOMFALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int GMHLOAKCMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int KCAFBEKNJJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int HCBPANOMIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool HGLPKCPNGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool KHHACADAFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float OOICLHOICLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 NHHOCHPJONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool IMNBOFEKEPO;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct HKLHAPEABCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int OPHIALKHLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int FKKNNAJKOPC;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct LNKLEFGKLGK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<GEMLIMHPPDB> JBKPGDFCFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<HLECICCLKDJ> CBEKLKNKAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<MPCIFMIIGOJ> DLCEFHOLCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<HKLHAPEABCL> FIGJFGNFPCK;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6026540", Offset = "0x6025340", VA = "0x186026540")]
	public LNKLEFGKLGK(NativeArray<HLECICCLKDJ> CBEKLKNKAPB, int GENDLFFGOMM = 1, Allocator MAJIAODMLCM = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6026450", Offset = "0x6025250", VA = "0x186026450", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct LELOEMHIHMK : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<LILCCODLCJA> ODBINIBJAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> KOKPMMJAMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<MPCIFMIIGOJ> KGNABIAFMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<GEMLIMHPPDB> JBKPGDFCFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<HLECICCLKDJ> CBEKLKNKAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<MPCIFMIIGOJ> DLCEFHOLCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<HKLHAPEABCL> FIGJFGNFPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int ADNCOHNLELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int KHENBBPODPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 OIMGEIBCKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion CGFGCHEFDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 ACBGKDAHBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CNGIOCGOPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KEDKNGEADBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JBBKHNBFKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DDFDFEJGJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> DFHJAPLIHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> IGEOOHFDEGL;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60261C0", Offset = "0x6024FC0", VA = "0x1860261C0")]
	public LELOEMHIHMK(CGONFMMPGJP NFBPEBMNGAN, DLJCFELHJEE CCIFFNNJKLB, float3 AEFEEPFGFCD, quaternion CDIADKCMCMP, float MINKJENPPNO, int ANBHLGHGIGN = 0, int FJNFOKKKMHJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6025F90", Offset = "0x6024D90", VA = "0x186025F90")]
	public LELOEMHIHMK(LNKLEFGKLGK NFBPEBMNGAN, DLJCFELHJEE CCIFFNNJKLB, float3 AEFEEPFGFCD, quaternion CDIADKCMCMP, float3 MINKJENPPNO, int ANBHLGHGIGN = 0, int FJNFOKKKMHJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6024010", Offset = "0x6022E10", VA = "0x186024010")]
	private float3 ANOCHFHGAFI(float3 EFBCHKHADMG, Matrix4x4 HPKPGMIBHCN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6025F00", Offset = "0x6024D00", VA = "0x186025F00")]
	private float3x3 FEECJKNOOII(float3x3 NJCFAPGKMFD, float3x3 KLCPGNCONBO)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6025F80", Offset = "0x6024D80", VA = "0x186025F80")]
	private float PLPJLBGPMOE(float OPIINMIIKCC, float LMIDKMPCDNJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6024D60", Offset = "0x6023B60", VA = "0x186024D60", Slot = "4")]
	public void Execute(int ACEFEPBEAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6024140", Offset = "0x6022F40", VA = "0x186024140")]
	private void BCBALPPLJJP(int CGGEMLFGKLH, float3 MHFADBEELBD, float3 ONELACJMJNO, float3 CHFLKGLPBCB, float GBGAAPIAACD, bool NNNAFJHLPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6024900", Offset = "0x6023700", VA = "0x186024900")]
	private void DHBNHOMIKFO(GEMLIMHPPDB BOEDDEJLIFN, float3 CPKBHHGCLEC, float3x3 HPGENMAJHAF, float OPIINMIIKCC, int GBACAFPNBHC, int NEDFIECFBHN, int IDAPBLCLMGB, float HEFDLEKJBHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60242B0", Offset = "0x60230B0", VA = "0x1860242B0")]
	private void CLDDDGLNBPE(int CGGEMLFGKLH, int ELJIBMLKCJH, GEMLIMHPPDB BOEDDEJLIFN, float3 CPKBHHGCLEC, float3x3 HPGENMAJHAF, bool KIGPMOECLKJ, float OPIINMIIKCC, int PFJFNNJDPNK, int MNGLJOFBADA, int IDAPBLCLMGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct FMAEOJDLELL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<AADGNKDEFDF> CABKLIKLKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<MPCIFMIIGOJ> CHOBHOPGINN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6022290", Offset = "0x6021090", VA = "0x186022290")]
	public FMAEOJDLELL(int GENDLFFGOMM, Allocator MAJIAODMLCM = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60221F0", Offset = "0x6020FF0", VA = "0x1860221F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct OJGAFPLLBFO : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum KIHHMHFIIID
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
	private NativeList<float3> EDILGFEDOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> BKLIKMKHDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> JNEBBIEADJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> PEFIFNDEECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> OLODFMNKDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> GJKKJKCHHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> MLGFNCBBFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> HGMPDLIPKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<MPCIFMIIGOJ> APANCLNELBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<AADGNKDEFDF> CABKLIKLKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<MPCIFMIIGOJ> CHOBHOPGINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int ADNCOHNLELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int KHENBBPODPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CNGIOCGOPCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KEDKNGEADBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JBBKHNBFKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DDFDFEJGJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> DFHJAPLIHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> IGEOOHFDEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 ACBGKDAHBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion CGFGCHEFDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 OIMGEIBCKOA;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6029070", Offset = "0x6027E70", VA = "0x186029070")]
	public OJGAFPLLBFO(CGONFMMPGJP NFBPEBMNGAN, DLJCFELHJEE CCIFFNNJKLB, float3 AEFEEPFGFCD, quaternion CDIADKCMCMP, float MINKJENPPNO, int ANBHLGHGIGN = 0, int FJNFOKKKMHJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6029260", Offset = "0x6028060", VA = "0x186029260")]
	public OJGAFPLLBFO(FMAEOJDLELL HKPHNGEBIED, DLJCFELHJEE CCIFFNNJKLB, float3 AEFEEPFGFCD, quaternion CDIADKCMCMP, float3 MINKJENPPNO, int ANBHLGHGIGN = 0, int FJNFOKKKMHJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6028050", Offset = "0x6026E50", VA = "0x186028050", Slot = "4")]
	public void Execute(int ACEFEPBEAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6027C60", Offset = "0x6026A60", VA = "0x186027C60")]
	private void BHEJFGPBIJJ(float4x4 MJFEKHLLJNO, int ACEFEPBEAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6029000", Offset = "0x6027E00", VA = "0x186029000")]
	private KIHHMHFIIID IPEHCAFEOBH(float3 ONELACJMJNO)
	{
		return default(KIHHMHFIIID);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6028FB0", Offset = "0x6027DB0", VA = "0x186028FB0")]
	private float4 FMMGGEJGBCK(KIHHMHFIIID AIOHAJOHMGK, int HPLKFBKKIBG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6028010", Offset = "0x6026E10", VA = "0x186028010")]
	private float2 BMOJNDMACFB(KIHHMHFIIID AIOHAJOHMGK, float3 MHFADBEELBD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct BDPFBMDHMLL
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum BCLPPMLBPDI
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static BDPFBMDHMLL CABPEDJKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 DPEPKOKDODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 JDNMGOKOLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 ELGBHPFJHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public BCLPPMLBPDI MCBKDNIENIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 EABDPAMMAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 DAJKOEPEHMJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NKGKIMMPNMN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x601B500", Offset = "0x601A300", VA = "0x18601B500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 GEJDPKODOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x601B190", Offset = "0x6019F90", VA = "0x18601B190")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x601B920", Offset = "0x601A720", VA = "0x18601B920")]
	public BDPFBMDHMLL(float3 MHFADBEELBD, quaternion NJBEEEBFFMP, float3 GENDLFFGOMM, BCLPPMLBPDI HJCFEPLFGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x601AF90", Offset = "0x6019D90", VA = "0x18601AF90")]
	public float AMDEBJBNNAD(float3 CPKBHHGCLEC, float JEGIMMPDPCG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x601B610", Offset = "0x601A410", VA = "0x18601B610")]
	public bool LPGBHCKHLDB(float3 ONELACJMJNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x601B700", Offset = "0x601A500", VA = "0x18601B700")]
	public void PFHBGMBCBMA(float3 HIGINHKCIJN, float3x3 MFLNBAOJGCL, float MNIIFHBKIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x601B510", Offset = "0x601A310", VA = "0x18601B510")]
	private void LFEPMJKCMJI(float3 LCBHOPGDHPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x601B270", Offset = "0x601A070", VA = "0x18601B270")]
	public void HHEANDNPCED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct EPFMPPKDAAO : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<BDPFBMDHMLL> HKPHNGEBIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> MCOBBNACBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> FEHBJBJBFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> AAICDOJAEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<MPCIFMIIGOJ> CHOBHOPGINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int GMNIBNALCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int IHKHPOFJCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float JEGIMMPDPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float BPCEKOKDOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> GPIAMJMIFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> OKPOMOPMDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> LIHOPHECHMJ;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6022150", Offset = "0x6020F50", VA = "0x186022150")]
	public EPFMPPKDAAO(DLJCFELHJEE NLCOEGGGEBL, float MBOILPAIODI, int MIMLCMKCBBJ, int GBACAFPNBHC, NativeList<BDPFBMDHMLL> HKPHNGEBIED, NativeArray<int> AAICDOJAEAB, NativeList<MPCIFMIIGOJ> CHOBHOPGINN, LAAAGJPBBGJ OAEFCHHAFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6021770", Offset = "0x6020570", VA = "0x186021770", Slot = "4")]
	public void Execute(int EIPIPPFLCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x60216B0", Offset = "0x60204B0", VA = "0x1860216B0")]
	private bool AMIAABCCBKJ(BDPFBMDHMLL OIPELOMOKGO, BDPFBMDHMLL BJNEJGMGENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6021EB0", Offset = "0x6020CB0", VA = "0x186021EB0")]
	private bool HKPFODMFCPJ(BDPFBMDHMLL GAEAFBNLNKG, int NFEDFLHALHP, int BOLKMPDLDOL, int JJDDHLIDKFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class LAAAGJPBBGJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> MCONMMANEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> HOFGKDCOHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> IJOGIBEEGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> BMNABEAACBH;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6023E00", Offset = "0x6022C00", VA = "0x186023E00")]
	public void BJPFOOKHDHM(int EKEDMMAJONM, int HKNOEIEGFDE, Allocator MAJIAODMLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6023F00", Offset = "0x6022D00", VA = "0x186023F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6023F20", Offset = "0x6022D20", VA = "0x186023F20")]
	public void GDLOLPODHHB(JobHandle NDHGJDFCLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public LAAAGJPBBGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct JCBHNEFCFGL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> MCOBBNACBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> JCDPLCFMFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> PFFJOFICDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> JFLJFKHDIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> FEHBJBJBFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> MCKFPBJKPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> HMPBJOBEDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> GPIAMJMIFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> OKPOMOPMDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int ANBHLGHGIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int FJNFOKKKMHJ;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6022E70", Offset = "0x6021C70", VA = "0x186022E70")]
	public JCBHNEFCFGL(DLJCFELHJEE NLCOEGGGEBL, LAAAGJPBBGJ OAEFCHHAFGA, int FJNFOKKKMHJ = 0, int ANBHLGHGIGN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6022A30", Offset = "0x6021830", VA = "0x186022A30", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6022E10", Offset = "0x6021C10", VA = "0x186022E10")]
	private void OJNOFHCDJKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MOKGIBNGOHL
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x26A5B40", Offset = "0x26A4940", VA = "0x1826A5B40")]
	public static bool JCDKJAFIIJE<T>(NativeArray<T> IPODKPLEDFE, int GENDLFFGOMM, Allocator MAJIAODMLCM, NativeArrayOptions EAELIKKMFAJ = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26A5C80", Offset = "0x26A4A80", VA = "0x1826A5C80")]
	public static bool JCDKJAFIIJE<T>(NativeList<T> HFLDOAFOIEF, int GENDLFFGOMM, Allocator MAJIAODMLCM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum CPNOCOMGBOB
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
public interface DPCEGIKJIFK
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OFBIKFBKFIF(CPNOCOMGBOB CPNHGLGJPKN);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int KILDIBCMMIH(CPNOCOMGBOB CPNHGLGJPKN);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EKEEBKFEOGO(CPNOCOMGBOB CPNHGLGJPKN, CGONFMMPGJP INJPBKECCIP, int GDONGNPGMAH = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DLJCFELHJEE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int ONMJMLOPHPE = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> NMCJKIFMCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> EGLICDNGFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> NEGJAHELAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> NKAKODEPEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> KKEBAGELFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> GCELEDJJNCO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool IJDAKCFEOFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60205B0", Offset = "0x601F3B0", VA = "0x1860205B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DJJCNCNJDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6020210", Offset = "0x601F010", VA = "0x186020210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int MJIIMMOILLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6020C20", Offset = "0x601FA20", VA = "0x186020C20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NNCLLEOMBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6020C60", Offset = "0x601FA60", VA = "0x186020C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60204A0", Offset = "0x601F2A0", VA = "0x1860204A0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6020250", Offset = "0x601F050", VA = "0x186020250")]
	public void BJPFOOKHDHM(int EKEDMMAJONM, int HKNOEIEGFDE, Allocator MAJIAODMLCM, bool IKHLPLIGKHP, bool BBJLMLGFJPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6020420", Offset = "0x601F220", VA = "0x186020420")]
	public void DMPNNANBKOH(int EKEDMMAJONM, int HKNOEIEGFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6020CA0", Offset = "0x601FAA0", VA = "0x186020CA0", Slot = "6")]
	public bool NOMFHMENNPB(Mesh NLCOEGGGEBL, bool KCCNDJDCEGM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60205F0", Offset = "0x601F3F0", VA = "0x1860205F0")]
	public bool GKLHHGGHMPL(Mesh NLCOEGGGEBL, DLJCFELHJEE MPNJCCLPPDE, bool KCCNDJDCEGM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public DLJCFELHJEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HGINNFMLLGI
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6022380", Offset = "0x6021180", VA = "0x186022380")]
	public static void LHEALPDOPLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OBIDKGNNFKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> NMCJKIFMCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> EGLICDNGFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> DEANABHOLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> NOOGMKGDCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> GMCGKNGPKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> EGCKCODOOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> BIIMICPGMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> GCELEDJJNCO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DJJCNCNJDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6026870", Offset = "0x6025670", VA = "0x186026870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int MJIIMMOILLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60276D0", Offset = "0x60264D0", VA = "0x1860276D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int POMDKBANDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6027710", Offset = "0x6026510", VA = "0x186027710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6027750", Offset = "0x6026550", VA = "0x186027750")]
	public OBIDKGNNFKA(int EKEDMMAJONM, int HKNOEIEGFDE, int JEILHONAMBE, Allocator MAJIAODMLCM = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6027970", Offset = "0x6026770", VA = "0x186027970")]
	public OBIDKGNNFKA(Mesh NLCOEGGGEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6026BB0", Offset = "0x60259B0", VA = "0x186026BB0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60268B0", Offset = "0x60256B0", VA = "0x1860268B0")]
	public void DEIAFMCPDCO(OBIDKGNNFKA NLCOEGGGEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6027240", Offset = "0x6026040", VA = "0x186027240")]
	private void FEADADJCIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6026CC0", Offset = "0x6025AC0", VA = "0x186026CC0")]
	private void FDEHBFCHGJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct MPCIFMIIGOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int PKPICONJEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int DJJCNCNJDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int MCOABGMPHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int MJIIMMOILLA;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1172840", Offset = "0x1171640", VA = "0x181172840")]
	public MPCIFMIIGOJ(int GBACAFPNBHC, int JNGDKNNMLKM, int MIMLCMKCBBJ, int JGGLBGKHCMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EMKKKJMEPJO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<MPCIFMIIGOJ> JIGICNBFLAP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB5EDE0", Offset = "0xB5DBE0", VA = "0x180B5EDE0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<MPCIFMIIGOJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1BB96D0", Offset = "0x1BB84D0", VA = "0x181BB96D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public OBIDKGNNFKA DIBEPNDALHA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7919F0", Offset = "0x7907F0", VA = "0x1807919F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60210F0", Offset = "0x601FEF0", VA = "0x1860210F0")]
	public EMKKKJMEPJO(IEnumerable<OBIDKGNNFKA> NIJAKBHKNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6021080", Offset = "0x601FE80", VA = "0x186021080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum GJDBFAJDNJA
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HPGIJBOEBOI
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> CANLIGLGDAI;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> LDAFBAAEEDL;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> FOLJDPJODHB;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> KIAHKLOAKGB;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60226F0", Offset = "0x60214F0", VA = "0x1860226F0")]
	public static void LHEALPDOPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6022920", Offset = "0x6021720", VA = "0x186022920")]
	public static NativeArray<float2> MAOMBMFFLBH(NativeArray<float2> GKNMNHKAMDE, int JDGDEMANKMC, NativeArray<float2> LNHOBMDEGIK, int PJONONOJENB)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6022810", Offset = "0x6021610", VA = "0x186022810")]
	public static NativeArray<float3> LHEJMFCMMGE(NativeArray<float3> GKNMNHKAMDE, int JDGDEMANKMC, NativeArray<float3> LNHOBMDEGIK, int PJONONOJENB)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x60225E0", Offset = "0x60213E0", VA = "0x1860225E0")]
	public static NativeArray<float4> KFNPNFJOOAP(NativeArray<float4> GKNMNHKAMDE, int JDGDEMANKMC, NativeArray<float4> LNHOBMDEGIK, int PJONONOJENB)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x60224D0", Offset = "0x60212D0", VA = "0x1860224D0")]
	public static NativeArray<int> INBMIBMFOIK(NativeArray<int> GKNMNHKAMDE, int JDGDEMANKMC, NativeArray<int> LNHOBMDEGIK, int PJONONOJENB)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x25D3C00", Offset = "0x25D2A00", VA = "0x1825D3C00")]
	private static void FIPICIBKEFI<T>(NativeArray<T> IPODKPLEDFE, int BLINPPCIIJE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x25D3B50", Offset = "0x25D2950", VA = "0x1825D3B50")]
	private static void ECPIDEMKDEF<T>(NativeArray<T> GKNMNHKAMDE, int JDGDEMANKMC, NativeArray<T> LNHOBMDEGIK, int PJONONOJENB, NativeArray<T> GJGPLBMHKPD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JMCNFKAGOAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<DPCEGIKJIFK> MLGEHMMCOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly FAIKJEPOLAE BNPDFMGBOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int JNGDKNNMLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int JGGLBGKHCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool EKNAEDOHCPC;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh DIBEPNDALHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x78E2A0", Offset = "0x78D0A0", VA = "0x18078E2A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x795720", Offset = "0x794520", VA = "0x180795720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer GFNKKPMMHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7944B0", Offset = "0x7932B0", VA = "0x1807944B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int DJJCNCNJDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6022EF0", Offset = "0x6021CF0", VA = "0x186022EF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x21494F0", Offset = "0x21482F0", VA = "0x1821494F0")]
	public void OEEFDLEGDBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6023CE0", Offset = "0x6022AE0", VA = "0x186023CE0")]
	public JMCNFKAGOAK(string AOAIBMOPKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6023180", Offset = "0x6021F80", VA = "0x186023180")]
	public void GDLOLPODHHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6023A10", Offset = "0x6022810", VA = "0x186023A10")]
	public void HIBJFAJCNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6023A40", Offset = "0x6022840", VA = "0x186023A40")]
	public void HOEFPEPDPFI(DPCEGIKJIFK CBCLBMHPCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6022F10", Offset = "0x6021D10", VA = "0x186022F10")]
	private void CNLELDLFEGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6023AF0", Offset = "0x60228F0", VA = "0x186023AF0")]
	public bool KCMLEJJLMHO(DPCEGIKJIFK CBCLBMHPCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6023C80", Offset = "0x6022A80", VA = "0x186023C80")]
	public bool PCLOONMEAJB(DPCEGIKJIFK CBCLBMHPCOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6023C10", Offset = "0x6022A10", VA = "0x186023C10", Slot = "4")]
	public virtual void OKGLJEFFAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6023940", Offset = "0x6022740", VA = "0x186023940")]
	public void HBMIFIIHIBD(Transform LEAKIOKLJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x60231C0", Offset = "0x6021FC0", VA = "0x1860231C0")]
	public bool GHPNABKJKOC(Transform LEAKIOKLJGK, [Out] (DLJCFELHJEE destMesh, Mesh mesh, JobHandle job) HKPHNGEBIED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6023B60", Offset = "0x6022960", VA = "0x186023B60")]
	public void LBGCMBIHADB([In] (DLJCFELHJEE destMesh, Mesh mesh, JobHandle job) HKPHNGEBIED)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker EANKPPCHMCF;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker IGLACJAIKBO;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker FFBPLJFIBDN;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int EBBGIHDHOFM = 65000;

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
		private Dictionary<Material, List<JMCNFKAGOAK>> LPAGICGNEHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<JMCNFKAGOAK> EGFHPOIEJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> HFNOCFINCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(JMCNFKAGOAK, (DLJCFELHJEE, Mesh, JobHandle))> IBOIOHECOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool MGDGINMFMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> LOAFMPKAMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> EAEPFDCOKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> OPECDIPCLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> IMCHNLHJBDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private JMCNFKAGOAK IFHIDAPMIEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material JGFJHIBFNNN;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> JOKCKCDKEAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x78E270", Offset = "0x78D070", VA = "0x18078E270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x601CE80", Offset = "0x601BC80", VA = "0x18601CE80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x601C1F0", Offset = "0x601AFF0", VA = "0x18601C1F0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x601BA10", Offset = "0x601A810", VA = "0x18601BA10")]
		public JMCNFKAGOAK AddToBatchedMesh(DPCEGIKJIFK GBGNJJICADP, Material ELKLKFMLCMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x601D6C0", Offset = "0x601C4C0", VA = "0x18601D6C0")]
		public void RemoveFromBatchedMesh(DPCEGIKJIFK NLCOEGGGEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x601BAF0", Offset = "0x601A8F0", VA = "0x18601BAF0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x601D840", Offset = "0x601C640", VA = "0x18601D840")]
		public void SetMaterialProperty(int DECHDHLGAML, Color PIPDACHFJNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x601DCD0", Offset = "0x601CAD0", VA = "0x18601DCD0")]
		public void SetMaterialProperty(int DECHDHLGAML, float MBDKMNBCLGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x601DEF0", Offset = "0x601CCF0", VA = "0x18601DEF0")]
		public void SetMaterialProperty(int DECHDHLGAML, Vector4 OHAAFFGCPMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x601DA70", Offset = "0x601C870", VA = "0x18601DA70")]
		public void SetMaterialProperty(int DECHDHLGAML, Matrix4x4 JNHHMDNCHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x601D0D0", Offset = "0x601BED0", VA = "0x18601D0D0")]
		private void PIIIDLCADFH(Renderer BCGNNFCJICK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x601C3D0", Offset = "0x601B1D0", VA = "0x18601C3D0")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x601BC90", Offset = "0x601AA90", VA = "0x18601BC90")]
		private void DMGNFJJCIDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x601C3E0", Offset = "0x601B1E0", VA = "0x18601C3E0")]
		private JMCNFKAGOAK IFCHNKLCMEJ(DPCEGIKJIFK NLCOEGGGEBL, Material ELKLKFMLCMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x601C5E0", Offset = "0x601B3E0", VA = "0x18601C5E0")]
		private JMCNFKAGOAK LNNIDMJCDCA(Material ELKLKFMLCMF, int BGFKHDMFAGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x601C9D0", Offset = "0x601B7D0", VA = "0x18601C9D0")]
		private JMCNFKAGOAK NFBJDDINLJP(Material ELKLKFMLCMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x601C7B0", Offset = "0x601B5B0", VA = "0x18601C7B0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x601C840", Offset = "0x601B640", VA = "0x18601C840")]
		public void MarkDirty(DPCEGIKJIFK NLCOEGGGEBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x601E1F0", Offset = "0x601CFF0", VA = "0x18601E1F0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DGFIOBHOAJL<KeyType> : JMCNFKAGOAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, DPCEGIKJIFK> ILADCFABFJL;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4F46B00", Offset = "0x4F45900", VA = "0x184F46B00")]
	public DGFIOBHOAJL(string AOAIBMOPKPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4F46790", Offset = "0x4F45590", VA = "0x184F46790")]
	public void HOEFPEPDPFI(KeyType IDGIKKEFDCG, DPCEGIKJIFK CBCLBMHPCOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4F468B0", Offset = "0x4F456B0", VA = "0x184F468B0")]
	public bool IHDBEKMKPCO(KeyType IDGIKKEFDCG, DPCEGIKJIFK GCNAKPMBFDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4F46980", Offset = "0x4F45780", VA = "0x184F46980")]
	public void KCMDBOJJGEL(KeyType IDGIKKEFDCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4F46AC0", Offset = "0x4F458C0", VA = "0x184F46AC0", Slot = "4")]
	public override void OKGLJEFFAJC()
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
