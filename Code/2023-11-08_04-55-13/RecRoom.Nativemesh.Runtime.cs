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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JDPJEJMAOAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int FHOFOMDOHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 NOEADKKDLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion DBKCPCNCMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 IKECGEJBMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int MEMOPEABICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int PLFNHDOOCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int OBPOMCCKBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float LDKLHBNLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 LIBHDIIIPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool MAGEFBEDBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public LBGBHJFNEPJ JNBCGOKPFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 MANMODLDGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float HLOLPCOFNAM;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IKHLDBCNHKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static HGICCFFGOBK DELDIGNPOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<JDPJEJMAOAF> LBCGADEBKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<PNAPIAKIBKB> BAHEAJIDFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<CECGJLNIGDM> HPAOFPIACHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<GNFALECBCGO> CKMFGNFEPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<PNAPIAKIBKB> PMEFAJMEEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<LBFLBNEAINI> MBJAEKIOOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<GNFALECBCGO>> MJJNFCGNFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<PMDBCDMBEMP> OAONBIOPPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> EOCJIHMMOJK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AGCNMCGDMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB63850", Offset = "0xB62650", VA = "0x180B63850")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xB63300", Offset = "0xB62100", VA = "0x180B63300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AMDIIKLPFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB63860", Offset = "0xB62660", VA = "0x180B63860")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB622C0", Offset = "0xB610C0", VA = "0x180B622C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E39410", Offset = "0x5E38210", VA = "0x185E39410")]
	public IKHLDBCNHKI(int AODLBJDAEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E37DF0", Offset = "0x5E36BF0", VA = "0x185E37DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E37AE0", Offset = "0x5E368E0", VA = "0x185E37AE0")]
	public void DGLMKNHCGON(JobHandle FNAOMEBIJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E378C0", Offset = "0x5E366C0", VA = "0x185E378C0")]
	public void COLECPJIKEC(JDPJEJMAOAF KNAIEKIJLBC, PMDBCDMBEMP MGIOFMPNKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E37CB0", Offset = "0x5E36AB0", VA = "0x185E37CB0")]
	public void DNHPIIBMCOO(CECGJLNIGDM KNAIEKIJLBC, NativeArray<GNFALECBCGO> PAPCOAOICOF, int AEBFGABBPOO, int HEIIPFMODCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E38400", Offset = "0x5E37200", VA = "0x185E38400")]
	public JobHandle PONHODMNFLI(NIBNGLMJCDC EHMMKNHGNPO, CHIENOMKGLL ENIELDCEHIG, float3 PFNIOBMNEEC, quaternion GDFDKAINMGP, float NIHNOJMFFOA, bool GCOFKIDNCIA, int NKHGHFJFMEB = 0, int IOGHJFECFPK = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E37E10", Offset = "0x5E36C10", VA = "0x185E37E10")]
	public static JobHandle FCMLBGNCMKA(DFFBCEJGJGG LPKFJCBIELK, NIBNGLMJCDC EHMMKNHGNPO, JDPJEJMAOAF KNAIEKIJLBC, JobHandle FNAOMEBIJLL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E38150", Offset = "0x5E36F50", VA = "0x185E38150")]
	public static JobHandle HCNJJPFOONK(DPPBEPEEJMA LPKFJCBIELK, NIBNGLMJCDC EHMMKNHGNPO, CECGJLNIGDM KNAIEKIJLBC, NativeArray<GNFALECBCGO> PAPCOAOICOF, int AEBFGABBPOO, int HEIIPFMODCM, JobHandle FNAOMEBIJLL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HDHPCNMDKDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 DBDMPPMEDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 DCHOACCDIAI;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class LDEIHEGKEFF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<HDHPCNMDKDO> DJKIJIJBMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> FEENFBFFPDK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int AGCNMCGDMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x774610", Offset = "0x773410", VA = "0x180774610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int AMDIIKLPFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x775E40", Offset = "0x774C40", VA = "0x180775E40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B690", Offset = "0x5E3A490", VA = "0x185E3B690")]
	public LDEIHEGKEFF(int PNBBJPKNIHN, int KKCMENNLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B550", Offset = "0x5E3A350", VA = "0x185E3B550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B5B0", Offset = "0x5E3A3B0", VA = "0x185E3B5B0")]
	public void JDKMACKLFHN(LDEIHEGKEFF NABEBLGFDBC, int EPDFMBFFJLJ, int FNPACLAMELJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GONAJOBFCPP
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static LDEIHEGKEFF ODMBGPOIGPF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<PNAPIAKIBKB> FHIFEJKBOHK;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] EJHAFEGAIGF;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool FGLCHAMNEEI;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, LDEIHEGKEFF> BCPOIICAJEO;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, LDEIHEGKEFF> BMCIPBMEBAA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool GOJIEPHOLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E35580", Offset = "0x5E34380", VA = "0x185E35580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<PNAPIAKIBKB> AJEIAAMPBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E35C30", Offset = "0x5E34A30", VA = "0x185E35C30")]
		get
		{
			return default(NativeList<PNAPIAKIBKB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static LDEIHEGKEFF EOHLBGJKFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E35780", Offset = "0x5E34580", VA = "0x185E35780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E34C30", Offset = "0x5E33A30", VA = "0x185E34C30")]
	private static void DEACPMFAFCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E356B0", Offset = "0x5E344B0", VA = "0x185E356B0")]
	public static int JFJNBNEKGPJ(bool FDOGHDGPPNB, int DJAFNAJHIKJ, bool DPDEENPLPIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E36000", Offset = "0x5E34E00", VA = "0x185E36000")]
	private static int MOKCCKLICBF(int DJAFNAJHIKJ, bool AGLGONMJPHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E36020", Offset = "0x5E34E20", VA = "0x185E36020")]
	private static int NHMJNBBALID(int DJAFNAJHIKJ, bool AGLGONMJPHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E35620", Offset = "0x5E34420", VA = "0x185E35620")]
	public static int IOHNFOIPKDE(int CDAJEDEHPKE, int DJAFNAJHIKJ, int PAGIHNNDAND, bool AGLGONMJPHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E35CE0", Offset = "0x5E34AE0", VA = "0x185E35CE0")]
	public static int MIFGAAJNGLE(int CDAJEDEHPKE, int DJAFNAJHIKJ, int PAGIHNNDAND, bool AGLGONMJPHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E356E0", Offset = "0x5E344E0", VA = "0x185E356E0")]
	public static int JJDENHKIMBA(int PAGIHNNDAND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E35CD0", Offset = "0x5E34AD0", VA = "0x185E35CD0")]
	private static int LGFINGIMMOP(int DJAFNAJHIKJ, bool AGLGONMJPHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E35600", Offset = "0x5E34400", VA = "0x185E35600")]
	private static int HPCNEBDOPNC(int DJAFNAJHIKJ, bool AGLGONMJPHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E36050", Offset = "0x5E34E50", VA = "0x185E36050")]
	public static int PJCEDOLCKHI(int CDAJEDEHPKE, int DJAFNAJHIKJ, int PAGIHNNDAND, bool AGLGONMJPHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E356F0", Offset = "0x5E344F0", VA = "0x185E356F0")]
	public static int JKHMCNBLNGM(int CDAJEDEHPKE, int DJAFNAJHIKJ, int PAGIHNNDAND, bool AGLGONMJPHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E36030", Offset = "0x5E34E30", VA = "0x185E36030")]
	public static int OCAGLDOJPJO(int PAGIHNNDAND)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E34B40", Offset = "0x5E33940", VA = "0x185E34B40")]
	public static LDEIHEGKEFF AMDKAGHIIBC(int DJAFNAJHIKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E35D70", Offset = "0x5E34B70", VA = "0x185E35D70")]
	private static LDEIHEGKEFF MOIMDMGFJON(int DJAFNAJHIKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E34A50", Offset = "0x5E33850", VA = "0x185E34A50")]
	public static LDEIHEGKEFF ALIIFJMFGFO(int DJAFNAJHIKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E35240", Offset = "0x5E34040", VA = "0x185E35240")]
	private static LDEIHEGKEFF DFHHKIIJDNN(int DJAFNAJHIKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5E35820", Offset = "0x5E34620", VA = "0x185E35820")]
	public static void JMPLFIKHALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct CECGJLNIGDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int LFCGGFPAMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 NOEADKKDLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion DBKCPCNCMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float IKECGEJBMHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float ALDHPDGLNFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int MEMOPEABICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int PLFNHDOOCAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int OBPOMCCKBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool MBKEBCDOPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool MFIHKEGEMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float LDKLHBNLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 LIBHDIIIPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool BJLKNLAGEMH;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct LBFLBNEAINI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int NEGPCOLHEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int MAHAMDHKMKN;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct DPPBEPEEJMA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<CECGJLNIGDM> MCDINLKIKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<GNFALECBCGO> EHABACJOJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<PNAPIAKIBKB> HOBJHGHPIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<LBFLBNEAINI> PKAFCOBPKEJ;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5E324E0", Offset = "0x5E312E0", VA = "0x185E324E0")]
	public DPPBEPEEJMA(NativeArray<GNFALECBCGO> EHABACJOJJG, int ICPPKLAMHFE = 1, Allocator DGKNIHLPENE = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5E323F0", Offset = "0x5E311F0", VA = "0x185E323F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct FJICGOFFGGE : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<HDHPCNMDKDO> CFAFMFFCNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> GHMKACDMICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<PNAPIAKIBKB> PIPKDAHPMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<CECGJLNIGDM> MCDINLKIKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<GNFALECBCGO> EHABACJOJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<PNAPIAKIBKB> HOBJHGHPIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<LBFLBNEAINI> PKAFCOBPKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int NJFBOJPKMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int MDIPAENMNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 CMJIKOIBPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion HBBMLOAFOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 NJCGJGDEEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PDMEALHBMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OOIFLKDFAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JHKGNDAGECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EBBMCFBPADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JCDNCOICDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> OBBOIFJMEFC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E347C0", Offset = "0x5E335C0", VA = "0x185E347C0")]
	public FJICGOFFGGE(IKHLDBCNHKI LCBHFEKHOBE, NIBNGLMJCDC DNNAEHEONCA, float3 NNJGJCDLOAJ, quaternion ILKLMMEPIBJ, float FNECBIKHEHG, int NKHGHFJFMEB = 0, int IOGHJFECFPK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E34590", Offset = "0x5E33390", VA = "0x185E34590")]
	public FJICGOFFGGE(DPPBEPEEJMA LCBHFEKHOBE, NIBNGLMJCDC DNNAEHEONCA, float3 NNJGJCDLOAJ, quaternion ILKLMMEPIBJ, float3 FNECBIKHEHG, int NKHGHFJFMEB = 0, int IOGHJFECFPK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E33E00", Offset = "0x5E32C00", VA = "0x185E33E00")]
	private float3 NKHGMLNOJPK(float3 EFMMLKKJDBO, Matrix4x4 FIPKNIFHEMD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5E32780", Offset = "0x5E31580", VA = "0x185E32780")]
	private float3x3 EDHIFEIEAGP(float3x3 PJOCFGJAILK, float3x3 KFAEKAPGIPM)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E33F30", Offset = "0x5E32D30", VA = "0x185E33F30")]
	private float NPMKJNMOAOK(float OINLNNPPPEB, float NCGACIINIKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E32800", Offset = "0x5E31600", VA = "0x185E32800", Slot = "4")]
	public void Execute(int JOEPNNKIFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E32610", Offset = "0x5E31410", VA = "0x185E32610")]
	private void DGICLGJGLDH(int BIMIPAJHJNO, float3 LMGPBOPOFGA, float3 PPEOGMAIJEH, float3 DHCMFKBPJDL, float CMBCKFHIOMK, bool EEIJDHPEKBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E339A0", Offset = "0x5E327A0", VA = "0x185E339A0")]
	private void FCIAPIAPKHG(CECGJLNIGDM AHIGDPNCNLJ, float3 PHLIKEKMOFA, float3x3 GKLJGLEHAOP, float OINLNNPPPEB, int CGKFABFEACB, int CPEEKHHELCP, int NIPFBLHDGNA, float DJBHFFIBLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E33F40", Offset = "0x5E32D40", VA = "0x185E33F40")]
	private void OEPLCFIIECA(int BIMIPAJHJNO, int LBKBNPDABOC, CECGJLNIGDM AHIGDPNCNLJ, float3 PHLIKEKMOFA, float3x3 GKLJGLEHAOP, bool GGEEKCPKGCN, float OINLNNPPPEB, int GNNHOLBPIBB, int BMNGPIJDEAL, int NIPFBLHDGNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct DFFBCEJGJGG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<JDPJEJMAOAF> IFHJFIGIOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<PNAPIAKIBKB> FJAKNOABDKN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5E32300", Offset = "0x5E31100", VA = "0x185E32300")]
	public DFFBCEJGJGG(int ICPPKLAMHFE, Allocator DGKNIHLPENE = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5E32260", Offset = "0x5E31060", VA = "0x185E32260", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct PPJNKGMHCEB : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum NJAKNABKHKC
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
	private NativeList<float3> CMJPEFMHBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> OGLHOPNKMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> HJNEKGNPNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> BDJKADLLEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> NELNEDGJPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> DPMJNFDEEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> GKCNJALFAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> FDGJDMDBHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<PNAPIAKIBKB> PIGOFPEEKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<JDPJEJMAOAF> IFHJFIGIOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<PNAPIAKIBKB> FJAKNOABDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int NJFBOJPKMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int MDIPAENMNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PDMEALHBMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OOIFLKDFAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JHKGNDAGECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EBBMCFBPADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JCDNCOICDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> OBBOIFJMEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 NJCGJGDEEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion HBBMLOAFOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 CMJIKOIBPAO;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EE70", Offset = "0x5E3DC70", VA = "0x185E3EE70")]
	public PPJNKGMHCEB(IKHLDBCNHKI LCBHFEKHOBE, NIBNGLMJCDC DNNAEHEONCA, float3 NNJGJCDLOAJ, quaternion ILKLMMEPIBJ, float FNECBIKHEHG, int NKHGHFJFMEB = 0, int IOGHJFECFPK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5E3F060", Offset = "0x5E3DE60", VA = "0x185E3F060")]
	public PPJNKGMHCEB(DFFBCEJGJGG KNAIEKIJLBC, NIBNGLMJCDC DNNAEHEONCA, float3 NNJGJCDLOAJ, quaternion ILKLMMEPIBJ, float3 FNECBIKHEHG, int NKHGHFJFMEB = 0, int IOGHJFECFPK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5E3DA60", Offset = "0x5E3C860", VA = "0x185E3DA60", Slot = "4")]
	public void Execute(int JOEPNNKIFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EAC0", Offset = "0x5E3D8C0", VA = "0x185E3EAC0")]
	private void OPHHFLBOFFM(float4x4 GIOFOJDDCFP, int JOEPNNKIFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EA00", Offset = "0x5E3D800", VA = "0x185E3EA00")]
	private NJAKNABKHKC HMHCPKFNPOP(float3 PPEOGMAIJEH)
	{
		return default(NJAKNABKHKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3EA70", Offset = "0x5E3D870", VA = "0x185E3EA70")]
	private float4 JIPIFGDIKMD(NJAKNABKHKC IGIGAJIHOJH, int NGIPPLLBEKC)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3E9C0", Offset = "0x5E3D7C0", VA = "0x185E3E9C0")]
	private float2 GIFIMIPKCON(NJAKNABKHKC IGIGAJIHOJH, float3 LMGPBOPOFGA)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct PMDBCDMBEMP
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum HOLBKPCLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static PMDBCDMBEMP EAKJMFHJPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 MLELCAAHFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 MPKKDIEJJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 BMGCJGPBFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public HOLBKPCLHEJ OIIFFAPKJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 IOBLCHFMEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 BPMMICKMMIA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ACDJDJBKPCD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D0D0", Offset = "0x5E3BED0", VA = "0x185E3D0D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 JIOADLGMACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D620", Offset = "0x5E3C420", VA = "0x185E3D620")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D970", Offset = "0x5E3C770", VA = "0x185E3D970")]
	public PMDBCDMBEMP(float3 LMGPBOPOFGA, quaternion BPBCJFMFECG, float3 ICPPKLAMHFE, HOLBKPCLHEJ AOPDMLJGEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D700", Offset = "0x5E3C500", VA = "0x185E3D700")]
	public float NDEJDCDCCJN(float3 PHLIKEKMOFA, float GCBNPIBCLBP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CFE0", Offset = "0x5E3BDE0", VA = "0x185E3CFE0")]
	public bool ANNKKIEDECF(float3 PPEOGMAIJEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D370", Offset = "0x5E3C170", VA = "0x185E3D370")]
	public void DKAHHOKIFPC(float3 CCMJKMOEDEN, float3x3 PGCGKOCFNBF, float FLHHDHNJOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D520", Offset = "0x5E3C320", VA = "0x185E3D520")]
	private void IHMJDDJCCFC(float3 MFPMPHOGKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D0E0", Offset = "0x5E3BEE0", VA = "0x185E3D0E0")]
	public void COODJGGNABP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct JMOGAAIGDBP : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<PMDBCDMBEMP> KNAIEKIJLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> JGIOHBDJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> EOFNAJLKOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EOCJIHMMOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<PNAPIAKIBKB> FJAKNOABDKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int KGJAOHJCNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int EOIEJNPPPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float GCBNPIBCLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float ILHJGJLOJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> AAGNJOINCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> OHCBPPMMELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> GBKICGAEGDF;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A0C0", Offset = "0x5E38EC0", VA = "0x185E3A0C0")]
	public JMOGAAIGDBP(NIBNGLMJCDC CKBGHBCJIHN, float CFFJFAINOCE, int FNPACLAMELJ, int CGKFABFEACB, NativeList<PMDBCDMBEMP> KNAIEKIJLBC, NativeArray<int> EOCJIHMMOJK, NativeList<PNAPIAKIBKB> FJAKNOABDKN, CHIENOMKGLL ENIELDCEHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5E39620", Offset = "0x5E38420", VA = "0x185E39620", Slot = "4")]
	public void Execute(int JHCKMHGADFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A000", Offset = "0x5E38E00", VA = "0x185E3A000")]
	private bool ONMJJALCPNM(PMDBCDMBEMP ALNGIEPPLJJ, PMDBCDMBEMP DCODMCLNKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5E39D60", Offset = "0x5E38B60", VA = "0x185E39D60")]
	private bool GAAJGOKAKAN(PMDBCDMBEMP JINDDDAPFKP, int FCPFMEDKNBF, int DKIOPCHKBIN, int OPJBCGKDMPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CHIENOMKGLL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> OIAMBDFKGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> CGNNDLEEIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> JGPGMPFPALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> IBCPKAOPMLK;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E32160", Offset = "0x5E30F60", VA = "0x185E32160")]
	public void PHNFOJGFNMF(int PNBBJPKNIHN, int KKCMENNLFIK, Allocator DGKNIHLPENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E32140", Offset = "0x5E30F40", VA = "0x185E32140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E32050", Offset = "0x5E30E50", VA = "0x185E32050")]
	public void DGLMKNHCGON(JobHandle FNAOMEBIJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public CHIENOMKGLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct LGNEKLIEEED : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> JGIOHBDJHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> FIPLFEDBCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> FBGNHHFCJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> EAHKBEOMADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> EOFNAJLKOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CLBICJCMNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> JLECNDOEALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> AAGNJOINCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> OHCBPPMMELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int NKHGHFJFMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int IOGHJFECFPK;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BB90", Offset = "0x5E3A990", VA = "0x185E3BB90")]
	public LGNEKLIEEED(NIBNGLMJCDC CKBGHBCJIHN, CHIENOMKGLL ENIELDCEHIG, int IOGHJFECFPK = 0, int NKHGHFJFMEB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B7B0", Offset = "0x5E3A5B0", VA = "0x185E3B7B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B750", Offset = "0x5E3A550", VA = "0x185E3B750")]
	private void ALGMBOCAGLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class EILBNNGNLKF
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x23A6800", Offset = "0x23A5600", VA = "0x1823A6800")]
	public static bool DDJKLIHCMPM<T>(NativeArray<T> LPMIAHOCPLL, int ICPPKLAMHFE, Allocator DGKNIHLPENE, NativeArrayOptions INHBNHHKMGG = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x23A68A0", Offset = "0x23A56A0", VA = "0x1823A68A0")]
	public static bool DDJKLIHCMPM<T>(NativeList<T> LCPNBOPPGBK, int ICPPKLAMHFE, Allocator DGKNIHLPENE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum PHNBODBFNIA
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
public interface OANCJOCFBNI
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int DINJJEECECI(PHNBODBFNIA CDAJEDEHPKE);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HCCCOHDFPCL(PHNBODBFNIA CDAJEDEHPKE);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPOELAILDLJ(PHNBODBFNIA CDAJEDEHPKE, IKHLDBCNHKI BNEEBEFLJJD, int LJIDCINJMCG = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NIBNGLMJCDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int DOHGHGNEELK = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> LIABHEDEFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> HHMPNKOJBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> GLCKFGIGPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> NMPHGGLPKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> KDHAGDAHDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> DEMFKKBPKFN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool BGJCPKHADFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E3BDA0", Offset = "0x5E3ABA0", VA = "0x185E3BDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int AGCNMCGDMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E3C7F0", Offset = "0x5E3B5F0", VA = "0x185E3C7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int AMDIIKLPFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E3BC10", Offset = "0x5E3AA10", VA = "0x185E3BC10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool ODIIKJJLGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E3BD60", Offset = "0x5E3AB60", VA = "0x185E3BD60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BC50", Offset = "0x5E3AA50", VA = "0x185E3BC50", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C830", Offset = "0x5E3B630", VA = "0x185E3C830")]
	public void PHNFOJGFNMF(int PNBBJPKNIHN, int KKCMENNLFIK, Allocator DGKNIHLPENE, bool NKCCDBILBFN, bool DFEIPHBKFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CA00", Offset = "0x5E3B800", VA = "0x185E3CA00")]
	public void PMFCDPBKAOC(int PNBBJPKNIHN, int KKCMENNLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BDE0", Offset = "0x5E3ABE0", VA = "0x185E3BDE0", Slot = "6")]
	public bool KJCOGGDACBN(Mesh CKBGHBCJIHN, bool JLAKIMKGOII = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C1C0", Offset = "0x5E3AFC0", VA = "0x185E3C1C0")]
	public bool LMEANHOMMAN(Mesh CKBGHBCJIHN, NIBNGLMJCDC KLGIFHBCGDK, bool JLAKIMKGOII = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public NIBNGLMJCDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HIAFIBNNGJA
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5E36860", Offset = "0x5E35660", VA = "0x185E36860")]
	public static void JMPLFIKHALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JPFJEIBHHEE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> LIABHEDEFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> HHMPNKOJBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> FHNAPHOLPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> KDIFLPLKOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> AAEJOHJNJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> OOIDPLMNHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> GJFHGPEHDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> DEMFKKBPKFN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AGCNMCGDMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AA80", Offset = "0x5E39880", VA = "0x185E3AA80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int AMDIIKLPFCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A1A0", Offset = "0x5E38FA0", VA = "0x185E3A1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int AKNENOKHABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E3A160", Offset = "0x5E38F60", VA = "0x185E3A160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B330", Offset = "0x5E3A130", VA = "0x185E3B330")]
	public JPFJEIBHHEE(int PNBBJPKNIHN, int KKCMENNLFIK, int EFADJEBCDAM, Allocator DGKNIHLPENE = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B040", Offset = "0x5E39E40", VA = "0x185E3B040")]
	public JPFJEIBHHEE(Mesh CKBGHBCJIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A670", Offset = "0x5E39470", VA = "0x185E3A670", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A780", Offset = "0x5E39580", VA = "0x185E3A780")]
	public void JDKMACKLFHN(JPFJEIBHHEE CKBGHBCJIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5E3A1E0", Offset = "0x5E38FE0", VA = "0x185E3A1E0")]
	private void CBOFAEIOAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5E3AAC0", Offset = "0x5E398C0", VA = "0x185E3AAC0")]
	private void POEDEPPDBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PNAPIAKIBKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int JCNLCBMDMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int AGCNMCGDMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int DKFMOMMFNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int AMDIIKLPFCN;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x10FC890", Offset = "0x10FB690", VA = "0x1810FC890")]
	public PNAPIAKIBKB(int CGKFABFEACB, int AEBFGABBPOO, int FNPACLAMELJ, int HEIIPFMODCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HGICCFFGOBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<PNAPIAKIBKB> KFLMKCGGKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xAFA210", Offset = "0xAF9010", VA = "0x180AFA210")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<PNAPIAKIBKB>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1B3E8C0", Offset = "0x1B3D6C0", VA = "0x181B3E8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public JPFJEIBHHEE NNGKPPCEDAC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x775E10", Offset = "0x774C10", VA = "0x180775E10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x770C80", Offset = "0x76FA80", VA = "0x180770C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5E362A0", Offset = "0x5E350A0", VA = "0x185E362A0")]
	public HGICCFFGOBK(IEnumerable<JPFJEIBHHEE> ONBCOMPLFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5E36230", Offset = "0x5E35030", VA = "0x185E36230", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum LBGBHJFNEPJ
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OKLJDJGMLIA
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> LABFAEALEBP;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> NMBPBIMJECH;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> CJEFMIBGGDP;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> BIDPJHDLMIL;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CB90", Offset = "0x5E3B990", VA = "0x185E3CB90")]
	public static void JMPLFIKHALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CED0", Offset = "0x5E3BCD0", VA = "0x185E3CED0")]
	public static NativeArray<float2> ODONHKHCBNB(NativeArray<float2> MONIKNLLBFF, int PJBJALOAPDE, NativeArray<float2> LNEJGELICHL, int GOAAONAJBMP)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CA80", Offset = "0x5E3B880", VA = "0x185E3CA80")]
	public static NativeArray<float3> FPCOOLHIEKN(NativeArray<float3> MONIKNLLBFF, int PJBJALOAPDE, NativeArray<float3> LNEJGELICHL, int GOAAONAJBMP)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CDC0", Offset = "0x5E3BBC0", VA = "0x185E3CDC0")]
	public static NativeArray<float4> LLKKEHGDIGC(NativeArray<float4> MONIKNLLBFF, int PJBJALOAPDE, NativeArray<float4> LNEJGELICHL, int GOAAONAJBMP)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E3CCB0", Offset = "0x5E3BAB0", VA = "0x185E3CCB0")]
	public static NativeArray<int> JPCEGJLNHBB(NativeArray<int> MONIKNLLBFF, int PJBJALOAPDE, NativeArray<int> LNEJGELICHL, int GOAAONAJBMP)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2634140", Offset = "0x2632F40", VA = "0x182634140")]
	private static void EOCAILGEEOL<T>(NativeArray<T> LPMIAHOCPLL, int FGLIGMMIHFM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2634340", Offset = "0x2633140", VA = "0x182634340")]
	private static void LDLGDONALFF<T>(NativeArray<T> MONIKNLLBFF, int PJBJALOAPDE, NativeArray<T> LNEJGELICHL, int GOAAONAJBMP, NativeArray<T> LHMFEDBCHED) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IGFLCIKAPJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<OANCJOCFBNI> ABPCBCABECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly BGIGGGBPADJ EFHCKGMAEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int AEBFGABBPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int HEIIPFMODCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool HGKKAIHHIII;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh NNGKPPCEDAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x772C10", Offset = "0x771A10", VA = "0x180772C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x779B70", Offset = "0x778970", VA = "0x180779B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer NGPBHNMHAAN
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x777020", Offset = "0x775E20", VA = "0x180777020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int AGCNMCGDMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5E37780", Offset = "0x5E36580", VA = "0x185E37780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2084250", Offset = "0x2083050", VA = "0x182084250")]
	public void PCGDIIOMDIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E377A0", Offset = "0x5E365A0", VA = "0x185E377A0")]
	public IGFLCIKAPJM(string NDLLBBKGIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E36A80", Offset = "0x5E35880", VA = "0x185E36A80")]
	public void DGLMKNHCGON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E37360", Offset = "0x5E36160", VA = "0x185E37360")]
	public void LEGHMHHLEAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E36B30", Offset = "0x5E35930", VA = "0x185E36B30")]
	public void GNFIIJDDHJM(OANCJOCFBNI DFFBJHMPHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E37390", Offset = "0x5E36190", VA = "0x185E37390")]
	private void LENHJFDFJDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5E36AC0", Offset = "0x5E358C0", VA = "0x185E36AC0")]
	public bool GHJEBNOJNGN(OANCJOCFBNI DFFBJHMPHMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5E37720", Offset = "0x5E36520", VA = "0x185E37720")]
	public bool ONHABPEFGAG(OANCJOCFBNI DFFBJHMPHMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5E37600", Offset = "0x5E36400", VA = "0x185E37600", Slot = "4")]
	public virtual void MMHADLDHJEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5E369B0", Offset = "0x5E357B0", VA = "0x185E369B0")]
	public void ABNEJNJLCGJ(Transform JGLJKIHONEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5E36BE0", Offset = "0x5E359E0", VA = "0x185E36BE0")]
	public bool HHDNFLCHELC(Transform JGLJKIHONEL, [Out] (NIBNGLMJCDC destMesh, Mesh mesh, JobHandle job) KNAIEKIJLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5E37670", Offset = "0x5E36470", VA = "0x185E37670")]
	public void NCBCLPIKCEI([In] (NIBNGLMJCDC destMesh, Mesh mesh, JobHandle job) KNAIEKIJLBC)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker JJLKFMJFCFK;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker NMDJAPKKOOL;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker CPGPPPPDLPH;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int JFIOBDIDICP = 65000;

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
		private Dictionary<Material, List<IGFLCIKAPJM>> HGOOJGIANOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<IGFLCIKAPJM> NLIBIJKMIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> JNPLBIEPINM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(IGFLCIKAPJM, (NIBNGLMJCDC, Mesh, JobHandle))> FDKAIBCMCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool PLMJBEDIHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> IONBLAJJEOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> FJHJMLGOACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> AGKFKPHFGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> BDIEGKEBANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private IGFLCIKAPJM ADOPJBMHGJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material HCBBBPDEKBJ;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> PPGMMJDCAHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E31010", Offset = "0x5E2FE10", VA = "0x185E31010")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E302D0", Offset = "0x5E2F0D0", VA = "0x185E302D0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F5B0", Offset = "0x5E2E3B0", VA = "0x185E2F5B0")]
		public IGFLCIKAPJM AddToBatchedMesh(OANCJOCFBNI FLEAEOHAPDA, Material EACDLEEFOLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E31260", Offset = "0x5E30060", VA = "0x185E31260")]
		public void RemoveFromBatchedMesh(OANCJOCFBNI CKBGHBCJIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E30130", Offset = "0x5E2EF30", VA = "0x185E30130")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E313E0", Offset = "0x5E301E0", VA = "0x185E313E0")]
		public void SetMaterialProperty(int PNCLPGLPBGN, Color HBLLOHAOGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E31870", Offset = "0x5E30670", VA = "0x185E31870")]
		public void SetMaterialProperty(int PNCLPGLPBGN, float PHPDIJICBJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5E31A90", Offset = "0x5E30890", VA = "0x185E31A90")]
		public void SetMaterialProperty(int PNCLPGLPBGN, Vector4 FOPKDJBJFKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E31610", Offset = "0x5E30410", VA = "0x185E31610")]
		public void SetMaterialProperty(int PNCLPGLPBGN, Matrix4x4 KJNMKBEALDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F690", Offset = "0x5E2E490", VA = "0x185E2F690")]
		private void CACOMFMIBDI(Renderer EKPEHCAOMDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E306B0", Offset = "0x5E2F4B0", VA = "0x185E306B0")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E30AB0", Offset = "0x5E2F8B0", VA = "0x185E30AB0")]
		private void ONGNPMHJHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E304B0", Offset = "0x5E2F2B0", VA = "0x185E304B0")]
		private IGFLCIKAPJM FACHLAHDIGH(OANCJOCFBNI CKBGHBCJIHN, Material EACDLEEFOLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E306C0", Offset = "0x5E2F4C0", VA = "0x185E306C0")]
		private IGFLCIKAPJM KKJJIJAPDPO(Material EACDLEEFOLG, int NIGKIFFPBHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FC80", Offset = "0x5E2EA80", VA = "0x185E2FC80")]
		private IGFLCIKAPJM CKFDGAHPLEH(Material EACDLEEFOLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5E30890", Offset = "0x5E2F690", VA = "0x185E30890")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5E30920", Offset = "0x5E2F720", VA = "0x185E30920")]
		public void MarkDirty(OANCJOCFBNI CKBGHBCJIHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5E31D90", Offset = "0x5E30B90", VA = "0x185E31D90")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class AFINMBCFLEP<KeyType> : IGFLCIKAPJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, OANCJOCFBNI> ANKFBPDOICN;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x37A3FE0", Offset = "0x37A2DE0", VA = "0x1837A3FE0")]
	public AFINMBCFLEP(string NDLLBBKGIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x37A3C70", Offset = "0x37A2A70", VA = "0x1837A3C70")]
	public void GNFIIJDDHJM(KeyType GAMCILOFBAF, OANCJOCFBNI DFFBJHMPHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x37A3ED0", Offset = "0x37A2CD0", VA = "0x1837A3ED0")]
	public bool JLPPLPHGJAM(KeyType GAMCILOFBAF, OANCJOCFBNI LKMMFIMDJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x37A3CC0", Offset = "0x37A2AC0", VA = "0x1837A3CC0")]
	public void IKGGGKKGLMO(KeyType GAMCILOFBAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x37A3FA0", Offset = "0x37A2DA0", VA = "0x1837A3FA0", Slot = "4")]
	public override void MMHADLDHJEE()
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
