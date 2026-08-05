using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct JFEABPGGKNF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct EONHLIHEELC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int BBMJGHBDPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int HLIDJMJHGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int DHDLMHIAEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int HMKBFIHKCDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int ELJCKAHDGMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int BGIGLNJHKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 ACHFGAEIKEO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6304920", Offset = "0x6303320", VA = "0x186304920")]
		public EONHLIHEELC(int LJHPJJPPDPN, int MFBEFONFCGB, int CDOCKOIIOOJ, int DJDIFBLEGLP, int LKLKEJMOJNC, int HFJLKGDFMDN, float3 AMMBIDJOPFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct DCFMPKNGEHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int ECGFOKJIOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int GPNKMINMDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float KJOHKDLDGAL;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x108B660", Offset = "0x108A060", VA = "0x18108B660")]
		public DCFMPKNGEHH(int KDAABOPFDKH, int LDFEPBIGIPB, float PNJHJOFNOLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct LBDHONALIFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int GPNKMINMDAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int KAPLCCBHOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int KJEBNMAOCPB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, EONHLIHEELC> IDDKBABAPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<DCFMPKNGEHH> DGOCIAJIOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> IMPFEECBAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<LBDHONALIFI> KPFFDABCIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> JBPFPDIFOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int FAHOHLINCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int MGLMHLNPFCA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6305B60", Offset = "0x6304560", VA = "0x186305B60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6304AD0", Offset = "0x63034D0", VA = "0x186304AD0")]
	public bool AAFEMCPKKBE([In] NativeArray<float3> GINDAHNPHKL, NativeList<float3> GMMGMGFPBII, NativeList<int> PPMAFAFGCKM, Allocator IMPJLMNPHBC, CancellationToken CFAFANOFDNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6307690", Offset = "0x6306090", VA = "0x186307690")]
	private void MPOMBMILLLK([In] NativeArray<float3> GINDAHNPHKL, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6305FF0", Offset = "0x63049F0", VA = "0x186305FF0")]
	private void IBOPMABNJEP([In] NativeArray<float3> GINDAHNPHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6307D40", Offset = "0x6306740", VA = "0x186307D40")]
	private void NLOCIEGBEDN([In] NativeArray<float3> GINDAHNPHKL, [Out] int LFGKPDOEFNB, [Out] int HCHKBGBBMLG, [Out] int LDCMOLCIDGC, [Out] int CPDHGKLCKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6307060", Offset = "0x6305A60", VA = "0x186307060")]
	private void KAFCPNFPIEA([In] NativeArray<float3> GINDAHNPHKL, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6305700", Offset = "0x6304100", VA = "0x186305700")]
	private void DGDNDCAFLEC([In] NativeArray<float3> GINDAHNPHKL, float3 OENLNJOIKNJ, int ODAJINCIPDN, EONHLIHEELC KBIHLCNHHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6307260", Offset = "0x6305C60", VA = "0x186307260")]
	private void KKLOBJIALHO([In] NativeArray<float3> GINDAHNPHKL, float3 OENLNJOIKNJ, int AHIOMGLPOLE, int MGLMHLNPFCA, EONHLIHEELC KBIHLCNHHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6304D20", Offset = "0x6303720", VA = "0x186304D20")]
	private void BIDIAPCENAJ([In] NativeArray<float3> GINDAHNPHKL, int GPNPKOMJAPP, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6305390", Offset = "0x6303D90", VA = "0x186305390")]
	private void BIHJHPMJBEA([In] NativeArray<float3> GINDAHNPHKL, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6307870", Offset = "0x6306270", VA = "0x186307870")]
	private void NJAKFPIDEAG([In] NativeArray<float3> GINDAHNPHKL, NativeList<float3> GMMGMGFPBII, NativeList<int> PPMAFAFGCKM, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6307630", Offset = "0x6306030", VA = "0x186307630")]
	private float LCJMOCBAKLH(float3 OENLNJOIKNJ, float3 OCPMLCHBCEH, EONHLIHEELC KBIHLCNHHPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6304C10", Offset = "0x6303610", VA = "0x186304C10")]
	private float3 ACHFGAEIKEO(float3 LJHPJJPPDPN, float3 MFBEFONFCGB, float3 CDOCKOIIOOJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6308200", Offset = "0x6306C00", VA = "0x186308200")]
	private static float OHOOFFHKBNL(float3 LMANHAAPNDE, float3 AMHFHPBEBNM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6307000", Offset = "0x6305A00", VA = "0x186307000")]
	private static float3 IKAEBOLEMIK(float3 LMANHAAPNDE, float3 AMHFHPBEBNM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6305F90", Offset = "0x6304990", VA = "0x186305F90")]
	private bool GGDAABIAOMM(float3 LMANHAAPNDE, float3 AMHFHPBEBNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6308230", Offset = "0x6306C30", VA = "0x186308230")]
	private bool OLOLCJDPLEP(float3 LMANHAAPNDE, float3 AMHFHPBEBNM, float3 KMFGKGNHDDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6305CA0", Offset = "0x63046A0", VA = "0x186305CA0")]
	private bool FGBABGGCKAN(float3 LMANHAAPNDE, float3 AMHFHPBEBNM, float3 KMFGKGNHDDK, float3 PNJHJOFNOLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct CHPMAJMJAGB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OHLHKEIHMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public unsafe int* indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int indexCount;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<float3> OIOCOLNDGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> KLCOEGMPPBE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PENGDLNAGKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6303540", Offset = "0x6301F40", VA = "0x186303540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CDIBEELIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6303B90", Offset = "0x6302590", VA = "0x186303B90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IFFKIMEMNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6303BD0", Offset = "0x63025D0", VA = "0x186303BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FPAHONIIHJE BGGEAMNCMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x63042F0", Offset = "0x6302CF0", VA = "0x1863042F0")]
		get
		{
			return default(FPAHONIIHJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6304510", Offset = "0x6302F10", VA = "0x186304510")]
	public CHPMAJMJAGB(int NDNMCFIKHGD, int NCJEGPKKOJP, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6304370", Offset = "0x6302D70", VA = "0x186304370")]
	public CHPMAJMJAGB(FPAHONIIHJE PBGGIHGPCMD, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63043A0", Offset = "0x6302DA0", VA = "0x1863043A0")]
	public CHPMAJMJAGB(Mesh LPABBIBOFCJ, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63045D0", Offset = "0x6302FD0", VA = "0x1863045D0")]
	public CHPMAJMJAGB(CHPMAJMJAGB ABDLEBPKDKC, Allocator IMPJLMNPHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6303B00", Offset = "0x6302500", VA = "0x186303B00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6303580", Offset = "0x6301F80", VA = "0x186303580")]
	public void BIPEDCDHLGG([In] CHPMAJMJAGB HIHHIJKIJFM, float4x4 LDHLOHPAJPD, Transform IDOHLBJMFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63033F0", Offset = "0x6301DF0", VA = "0x1863033F0")]
	public void AGPOMIPCAFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6303E00", Offset = "0x6302800", VA = "0x186303E00")]
	public void NINKMBONMDN(float EHAOBONCKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6303900", Offset = "0x6302300", VA = "0x186303900")]
	public CHPMAJMJAGB CPPCOPJFHGI(Allocator IMPJLMNPHBC, CancellationToken CFAFANOFDNJ)
	{
		return default(CHPMAJMJAGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6303CE0", Offset = "0x63026E0", VA = "0x186303CE0")]
	public Mesh MEDINNLHHMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6303C40", Offset = "0x6302640", VA = "0x186303C40")]
	private unsafe static float3* KHIPMPIHMJD(NativeArray<float3> KKAKPOKBAHF)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6303C90", Offset = "0x6302690", VA = "0x186303C90")]
	private unsafe static int* KHIPMPIHMJD(NativeArray<int> KKAKPOKBAHF)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6303C10", Offset = "0x6302610", VA = "0x186303C10")]
	[CompilerGenerated]
	internal static void KFOABHBLCJN(int LJAJINEOPOC, int LMDNAEDNFOB, OHLHKEIHMAM P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct FPAHONIIHJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int PENGDLNAGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int CDIBEELIFEG;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GNAIKBNOBJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6304A20", Offset = "0x6303420", VA = "0x186304A20")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1D847B0", Offset = "0x1D831B0", VA = "0x181D847B0")]
	public static FPAHONIIHJE MOEMOFPBKII(FPAHONIIHJE LMANHAAPNDE, FPAHONIIHJE AMHFHPBEBNM)
	{
		return default(FPAHONIIHJE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6304A00", Offset = "0x6303400", VA = "0x186304A00")]
	public static FPAHONIIHJE KIAENIKCIMN(FPAHONIIHJE LIFGCFOCINJ, int ANGOLELPPJD)
	{
		return default(FPAHONIIHJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6304960", Offset = "0x6303360", VA = "0x186304960", Slot = "0")]
	public override bool Equals(object PNIKNNKOGCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x63049B0", Offset = "0x63033B0", VA = "0x1863049B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6304A30", Offset = "0x6303430", VA = "0x186304A30", Slot = "3")]
	public override string ToString()
	{
		return null;
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
