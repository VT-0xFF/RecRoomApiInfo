using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Burst.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_NativeMesh_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C09AB0", Offset = "0x6C084B0", VA = "0x186C09AB0", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class IDEOENCBNKD
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CAFGMNLACIN CNMOIMPACKG;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly CAFGMNLACIN BJNOFDHMEBD;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly CAFGMNLACIN LKELPOIDPJG;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class AECMCNOFGIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public OKOCLBPJOEP FLBMGAIEBLI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NHPNPOOIEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public AECMCNOFGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct OKOCLBPJOEP
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct MEBJEPIOLDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public half PMIMGCDJCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ushort IKDNDAOFAFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public byte CABPMAMCINB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ProfilerMarker EAFFHKONPBF;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ProfilerMarker OJIMCIBCJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int NHPNPOOIEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int OCJJKCEPHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public NativeArray<ushort> EBLHLLMOJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<ushort> PPFPMPHOIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> NNLIGJLJJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> HMMBCCAOJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<MEBJEPIOLDN> POALGEAPANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<byte> GGAIKPNHPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<byte> MBDNPINLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float3 CCJDBBEHABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float3 MGEFJDDHJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float2 FKNIILMPOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float2 CNOOJLNLLBL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static long EKJMHEEPIIF;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static long IGDFPLLACDJ;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static float IHIGDBKHJKI;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static bool DHOMKGDGNHH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool EMCJBNDMBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C10520", Offset = "0x6C0EF20", VA = "0x186C10520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PCAPILBILFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6C0B990", Offset = "0x6C0A390", VA = "0x186C0B990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C11440", Offset = "0x6C0FE40", VA = "0x186C11440")]
	public void NEECMKACHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C0C440", Offset = "0x6C0AE40", VA = "0x186C0C440")]
	public static OKOCLBPJOEP EMJKOLAJLFI(Allocator MPFEIGMBFCP, CCDNCOACIDM KLNLLDDABME)
	{
		return default(OKOCLBPJOEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C0C710", Offset = "0x6C0B110", VA = "0x186C0C710")]
	public static OKOCLBPJOEP EMJKOLAJLFI(Allocator MPFEIGMBFCP, NativeArray<float3> OKOIFGKONJJ, NativeArray<float3> FDCLGABBMHB, NativeArray<float2> GKEGMHKEAKA, NativeArray<float4> DIMHEKCFDMF, bool HEOMIIOEKEE, NativeArray<float4> MMGNMNCMPCD, NativeArray<int> JKIHIHHFIPB, int NHPNPOOIEDN, int IFOGKPMMFDK, int OCJJKCEPHKD, int JCPIFCAAIEB)
	{
		return default(OKOCLBPJOEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FBA0", Offset = "0x6C0E5A0", VA = "0x186C0FBA0")]
	public CCDNCOACIDM JGAAONCHLLD(Allocator MPFEIGMBFCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6C0ABB0", Offset = "0x6C095B0", VA = "0x186C0ABB0")]
	public void AIPPEMFICCJ(Mesh LDNHICGPCIN, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A980", Offset = "0x6C09380", VA = "0x186C0A980")]
	private void AFKDFHEGCGK(Mesh LDNHICGPCIN, NativeArray<ushort> LAMFIAFBMLM, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D1C0", Offset = "0x6C0BBC0", VA = "0x186C0D1C0")]
	public void GMBANCNAILN(Mesh LDNHICGPCIN, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C11830", Offset = "0x6C10230", VA = "0x186C11830")]
	public void NPDHPMAEINI(Mesh LDNHICGPCIN, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C0EB70", Offset = "0x6C0D570", VA = "0x186C0EB70")]
	public void IKNICANGCCH(Mesh LDNHICGPCIN, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C0A050", Offset = "0x6C08A50", VA = "0x186C0A050")]
	public void ADCIBMPLCMK(Mesh LDNHICGPCIN, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C10560", Offset = "0x6C0EF60", VA = "0x186C10560")]
	public void LBEANOJCIFO(Mesh LDNHICGPCIN, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BD80", Offset = "0x6C0A780", VA = "0x186C0BD80")]
	public void DJPJFLDGBAA(Mesh LDNHICGPCIN, CCDNCOACIDM.MMFBGFODIND EPLBBPBANLK, bool BKBGHDDFJBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C0F700", Offset = "0x6C0E100", VA = "0x186C0F700")]
	public long IOPMHHCCPGJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B9D0", Offset = "0x6C0A3D0", VA = "0x186C0B9D0")]
	public long CEGDODLLDPO(CCDNCOACIDM.MMFBGFODIND EPLBBPBANLK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C11310", Offset = "0x6C0FD10", VA = "0x186C11310")]
	private void MKPLHMCKEFN(int FBOKOPMOEJK, int AJEDNCMAFDC, Allocator MPFEIGMBFCP, bool EGBKFGBEKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C0C350", Offset = "0x6C0AD50", VA = "0x186C0C350")]
	private void EIDCCLHMLJM(NativeArray<float3> KAAKJDADBHH, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8E60", Offset = "0x6BF7860", VA = "0x186BF8E60")]
	[BurstCompile]
	private unsafe static void EIDCCLHMLJM([NoAlias] float3* KAAKJDADBHH, [In][NoAlias] ushort* OKOIFGKONJJ, int NHPNPOOIEDN, [In] float3 CCJDBBEHABD, [In] float3 MGEFJDDHJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C12CE0", Offset = "0x6C116E0", VA = "0x186C12CE0")]
	[BurstCompile]
	private unsafe static void OPGGGDIJJDF([NoAlias] CCDNCOACIDM.OFMOFAGFMLN* KAAKJDADBHH, [In][NoAlias] ushort* OKOIFGKONJJ, int NHPNPOOIEDN, [In] float3 CCJDBBEHABD, [In] float3 MGEFJDDHJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C127E0", Offset = "0x6C111E0", VA = "0x186C127E0")]
	[BurstCompile]
	private unsafe static void ONKMCIDMHAE([NoAlias] CCDNCOACIDM.MHIEPBJMNDD* KAAKJDADBHH, [In][NoAlias] ushort* OKOIFGKONJJ, int NHPNPOOIEDN, [In] float3 CCJDBBEHABD, [In] float3 MGEFJDDHJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BCC0", Offset = "0x6C0A6C0", VA = "0x186C0BCC0")]
	[BurstCompile]
	private unsafe static void IEMLJJKJLEF([NoAlias] CCDNCOACIDM.OMNLDCDLNAF* KAAKJDADBHH, [In][NoAlias] ushort* OKOIFGKONJJ, int NHPNPOOIEDN, [In] float3 CCJDBBEHABD, [In] float3 MGEFJDDHJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BCC0", Offset = "0x6C0A6C0", VA = "0x186C0BCC0")]
	[BurstCompile]
	private unsafe static void CKNNBGGIDKK([NoAlias] CCDNCOACIDM.OMCKMLHEHMP* KAAKJDADBHH, [In][NoAlias] ushort* OKOIFGKONJJ, int NHPNPOOIEDN, [In] float3 CCJDBBEHABD, [In] float3 MGEFJDDHJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C0EA10", Offset = "0x6C0D410", VA = "0x186C0EA10")]
	[BurstCompile]
	private unsafe static void IEJCPCEIIJE([NoAlias] CCDNCOACIDM.GLIGFOGBAPG* KAAKJDADBHH, [In][NoAlias] ushort* OKOIFGKONJJ, int NHPNPOOIEDN, [In] float3 CCJDBBEHABD, [In] float3 MGEFJDDHJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FED0", Offset = "0x6C0E8D0", VA = "0x186C0FED0")]
	private void JHNOHMJDAHI(NativeArray<float3> OKOIFGKONJJ, int JCPIFCAAIEB, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BF90C0", Offset = "0x6BF7AC0", VA = "0x186BF90C0")]
	[BurstCompile]
	private unsafe static void JHNOHMJDAHI([NoAlias] ushort* KAAKJDADBHH, [Out] float3 KGGODADCPMK, [Out] float3 MGEFJDDHJGI, [In][NoAlias] float3* OKOIFGKONJJ, int JCPIFCAAIEB, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B7B0", Offset = "0x6C0A1B0", VA = "0x186C0B7B0")]
	private void BMAENHFALFO(NativeArray<float3> FDCLGABBMHB, int JCPIFCAAIEB, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B4F0", Offset = "0x6C09EF0", VA = "0x186C0B4F0")]
	[BurstCompile]
	private unsafe static void BMAENHFALFO([NoAlias] ushort* KGCGLKOAKNJ, [In][NoAlias] float3* FDCLGABBMHB, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C0DB80", Offset = "0x6C0C580", VA = "0x186C0DB80")]
	private void HBFJBHBOKGO(NativeArray<float3> KFNBFBBGBPC, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C0DC40", Offset = "0x6C0C640", VA = "0x186C0DC40")]
	[BurstCompile]
	private unsafe static void HBFJBHBOKGO([NoAlias] float3* KFNBFBBGBPC, [In][NoAlias] ushort* FDCLGABBMHB, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C12DA0", Offset = "0x6C117A0", VA = "0x186C12DA0")]
	[BurstCompile]
	private unsafe static void PCHHPLMKJNJ([NoAlias] CCDNCOACIDM.OFMOFAGFMLN* KAAKJDADBHH, [In][NoAlias] ushort* FDCLGABBMHB, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C0DE40", Offset = "0x6C0C840", VA = "0x186C0DE40")]
	[BurstCompile]
	private unsafe static void HDNJBMFDCIK([NoAlias] CCDNCOACIDM.MHIEPBJMNDD* KAAKJDADBHH, [In][NoAlias] ushort* FDCLGABBMHB, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C13590", Offset = "0x6C11F90", VA = "0x186C13590")]
	[BurstCompile]
	private unsafe static void POKDEJFALCE([NoAlias] CCDNCOACIDM.OMNLDCDLNAF* KAAKJDADBHH, [In][NoAlias] ushort* FDCLGABBMHB, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AE90", Offset = "0x6C09890", VA = "0x186C0AE90")]
	[BurstCompile]
	private unsafe static void BAPOJMFCKOI([NoAlias] CCDNCOACIDM.OMCKMLHEHMP* KAAKJDADBHH, [In][NoAlias] ushort* FDCLGABBMHB, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AFE0", Offset = "0x6C099E0", VA = "0x186C0AFE0")]
	[BurstCompile]
	private unsafe static void BBBIBJJHLPC([NoAlias] CCDNCOACIDM.GLIGFOGBAPG* KAAKJDADBHH, [In][NoAlias] ushort* FDCLGABBMHB, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C12930", Offset = "0x6C11330", VA = "0x186C12930")]
	private void OOKJLNFHKNH(NativeArray<float2> GKEGMHKEAKA, int JCPIFCAAIEB, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C12A20", Offset = "0x6C11420", VA = "0x186C12A20")]
	[BurstCompile]
	private unsafe static void OOKJLNFHKNH([NoAlias] ushort* NKELLFBLOAB, [Out] float2 LEAIFMBEPGH, [Out] float2 CNOOJLNLLBL, [In][NoAlias] float2* GKEGMHKEAKA, int JCPIFCAAIEB, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C0C300", Offset = "0x6C0AD00", VA = "0x186C0C300")]
	[BurstCompile]
	private static void EFIPCOKBHEG([Out] float2 HEJFDMKOMMK, ushort BAHIDEJIOFP, [In] float2 FKNIILMPOIF, [In] float2 CNOOJLNLLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E4B0", Offset = "0x6C0CEB0", VA = "0x186C0E4B0")]
	private void HGKKMNFIHDG(NativeArray<float2> NKELLFBLOAB, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E620", Offset = "0x6C0D020", VA = "0x186C0E620")]
	[BurstCompile]
	private unsafe static void HGKKMNFIHDG([NoAlias] float2* NKELLFBLOAB, [NoAlias] ushort* GKEGMHKEAKA, int NHPNPOOIEDN, [In] float2 FKNIILMPOIF, [In] float2 CNOOJLNLLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C0AD90", Offset = "0x6C09790", VA = "0x186C0AD90")]
	[BurstCompile]
	private unsafe static void BALPONCCPPB([NoAlias] CCDNCOACIDM.OFMOFAGFMLN* KAAKJDADBHH, [NoAlias] ushort* GKEGMHKEAKA, int NHPNPOOIEDN, [In] float2 FKNIILMPOIF, [In] float2 CNOOJLNLLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E3B0", Offset = "0x6C0CDB0", VA = "0x186C0E3B0")]
	[BurstCompile]
	private unsafe static void HFBGAMDBLMN([NoAlias] CCDNCOACIDM.MHIEPBJMNDD* KAAKJDADBHH, [NoAlias] ushort* GKEGMHKEAKA, int NHPNPOOIEDN, [In] float2 FKNIILMPOIF, [In] float2 CNOOJLNLLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C0CFD0", Offset = "0x6C0B9D0", VA = "0x186C0CFD0")]
	[BurstCompile]
	private unsafe static void GEIPFPEGDNN([NoAlias] CCDNCOACIDM.OMNLDCDLNAF* KAAKJDADBHH, [NoAlias] ushort* GKEGMHKEAKA, int NHPNPOOIEDN, [In] float2 FKNIILMPOIF, [In] float2 CNOOJLNLLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FAA0", Offset = "0x6C0E4A0", VA = "0x186C0FAA0")]
	[BurstCompile]
	private unsafe static void JFHEGECKBKB([NoAlias] CCDNCOACIDM.OMCKMLHEHMP* KAAKJDADBHH, [NoAlias] ushort* GKEGMHKEAKA, int NHPNPOOIEDN, [In] float2 FKNIILMPOIF, [In] float2 CNOOJLNLLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C0F7C0", Offset = "0x6C0E1C0", VA = "0x186C0F7C0")]
	[BurstCompile]
	private unsafe static void JBDAKCLPEHH([NoAlias] CCDNCOACIDM.GLIGFOGBAPG* KAAKJDADBHH, [NoAlias] ushort* GKEGMHKEAKA, int NHPNPOOIEDN, [In] float2 FKNIILMPOIF, [In] float2 CNOOJLNLLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C11680", Offset = "0x6C10080", VA = "0x186C11680")]
	private void NOPEFLLPHME(NativeArray<float4> MMGNMNCMPCD, int JCPIFCAAIEB, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C11560", Offset = "0x6C0FF60", VA = "0x186C11560")]
	[BurstCompile]
	private unsafe static void NOPEFLLPHME([NoAlias] ushort* PLFMIGCKMNN, [In][NoAlias] float4* FKLEECKKPGC, int JCPIFCAAIEB, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C128A0", Offset = "0x6C112A0", VA = "0x186C128A0")]
	[BurstCompile]
	private static ushort ONOFLIACAEL([In] float4 KDDOAOLIOLC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BB90", Offset = "0x6C0A590", VA = "0x186C0BB90")]
	private void CGJBLCKNIAF(NativeArray<float4> PLFMIGCKMNN, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BA40", Offset = "0x6C0A440", VA = "0x186C0BA40")]
	[BurstCompile]
	private unsafe static void CGJBLCKNIAF([NoAlias] float4* PLFMIGCKMNN, [In][NoAlias] ushort* MMGNMNCMPCD, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E700", Offset = "0x6C0D100", VA = "0x186C0E700")]
	[BurstCompile]
	private unsafe static void ICAHPILFACN([NoAlias] CCDNCOACIDM.OFMOFAGFMLN* KAAKJDADBHH, [In][NoAlias] ushort* MMGNMNCMPCD, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B140", Offset = "0x6C09B40", VA = "0x186C0B140")]
	[BurstCompile]
	private unsafe static void BEPPCPHLMGH([NoAlias] CCDNCOACIDM.MHIEPBJMNDD* KAAKJDADBHH, [In][NoAlias] ushort* MMGNMNCMPCD, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C0CE10", Offset = "0x6C0B810", VA = "0x186C0CE10")]
	[BurstCompile]
	private unsafe static void FNGIMMAIDJD([NoAlias] CCDNCOACIDM.OMNLDCDLNAF* KAAKJDADBHH, [In][NoAlias] ushort* MMGNMNCMPCD, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C10F00", Offset = "0x6C0F900", VA = "0x186C10F00")]
	[BurstCompile]
	private unsafe static void LCBMCFJCKJO([NoAlias] CCDNCOACIDM.OMCKMLHEHMP* KAAKJDADBHH, [In][NoAlias] ushort* MMGNMNCMPCD, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C12370", Offset = "0x6C10D70", VA = "0x186C12370")]
	[BurstCompile]
	private unsafe static void OMJKHOMAAMG([NoAlias] CCDNCOACIDM.GLIGFOGBAPG* KAAKJDADBHH, [In][NoAlias] ushort* MMGNMNCMPCD, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C0ACD0", Offset = "0x6C096D0", VA = "0x186C0ACD0")]
	[BurstCompile]
	private static void AMHHHPHPAEJ([Out] float4 NLAECIHBKHE, ushort BAHIDEJIOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C13190", Offset = "0x6C11B90", VA = "0x186C13190")]
	private void PIGNMIHIIBD(Allocator MPFEIGMBFCP, NativeArray<float4> DIMHEKCFDMF, int JCPIFCAAIEB, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C12FD0", Offset = "0x6C119D0", VA = "0x186C12FD0")]
	[BurstCompile]
	private unsafe static void PIGNMIHIIBD([NoAlias] float4* IGKLLHAOPEP, [NoAlias] byte* NMJKOIGPPJE, [Out] int GONDJIONOGJ, [Out] int BGDAGNCNGPI, [NoAlias] float4* DIMHEKCFDMF, int JCPIFCAAIEB, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FFC0", Offset = "0x6C0E9C0", VA = "0x186C0FFC0")]
	private static void JJNAGKIMLGP(NativeArray<float4> BLBLNLNKFOO, NativeArray<MEBJEPIOLDN> NLDHJDINPDB, NativeArray<byte> BENMOJPPBMM, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C101A0", Offset = "0x6C0EBA0", VA = "0x186C101A0")]
	[BurstCompile]
	private unsafe static void JJNAGKIMLGP([NoAlias] float4* BLBLNLNKFOO, [In][NoAlias] MEBJEPIOLDN* NLDHJDINPDB, [In][NoAlias] byte* BENMOJPPBMM, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B310", Offset = "0x6C09D10", VA = "0x186C0B310")]
	[BurstCompile]
	private unsafe static void BKPJNALAMMC([NoAlias] CCDNCOACIDM.OFMOFAGFMLN* KAAKJDADBHH, [In][NoAlias] MEBJEPIOLDN* NLDHJDINPDB, [In][NoAlias] byte* BENMOJPPBMM, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C11130", Offset = "0x6C0FB30", VA = "0x186C11130")]
	[BurstCompile]
	private unsafe static void LGDKFNGGJHG([NoAlias] CCDNCOACIDM.MHIEPBJMNDD* KAAKJDADBHH, [In][NoAlias] MEBJEPIOLDN* NLDHJDINPDB, [In][NoAlias] byte* BENMOJPPBMM, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C0F8C0", Offset = "0x6C0E2C0", VA = "0x186C0F8C0")]
	[BurstCompile]
	private unsafe static void JBFPCNBLHHJ([NoAlias] CCDNCOACIDM.OMNLDCDLNAF* KAAKJDADBHH, [In][NoAlias] MEBJEPIOLDN* NLDHJDINPDB, [In][NoAlias] byte* BENMOJPPBMM, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C102E0", Offset = "0x6C0ECE0", VA = "0x186C102E0")]
	[BurstCompile]
	private unsafe static void JOFDJBKIEOI([NoAlias] CCDNCOACIDM.OMCKMLHEHMP* KAAKJDADBHH, [In][NoAlias] MEBJEPIOLDN* NLDHJDINPDB, [In][NoAlias] byte* BENMOJPPBMM, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C125A0", Offset = "0x6C10FA0", VA = "0x186C125A0")]
	[BurstCompile]
	private unsafe static void OMKGPCNLMEA([NoAlias] CCDNCOACIDM.GLIGFOGBAPG* KAAKJDADBHH, [In][NoAlias] MEBJEPIOLDN* NLDHJDINPDB, [In][NoAlias] byte* BENMOJPPBMM, int NHPNPOOIEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B890", Offset = "0x6C0A290", VA = "0x186C0B890")]
	private void BPIKNMNMMEG(Allocator MPFEIGMBFCP, NativeArray<int> JKIHIHHFIPB, int JCPIFCAAIEB, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E080", Offset = "0x6C0CA80", VA = "0x186C0E080")]
	private static NativeArray<byte> HEKOJKFGIBE(Allocator MPFEIGMBFCP, NativeArray<int> JKIHIHHFIPB, int HJHKCCKGGCM)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C0DF80", Offset = "0x6C0C980", VA = "0x186C0DF80")]
	[BurstCompile]
	private unsafe static int HEKOJKFGIBE([NoAlias] byte* NEGCJOEIDLH, [In][NoAlias] int* JKIHIHHFIPB, int HJHKCCKGGCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C0F5E0", Offset = "0x6C0DFE0", VA = "0x186C0F5E0")]
	private static void IOMOFOILKKH(NativeArray<int> MJMFDBAJGAG, NativeArray<byte> LPHFANJGLGG, int OCJJKCEPHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C0F540", Offset = "0x6C0DF40", VA = "0x186C0F540")]
	[BurstCompile]
	private unsafe static void IOMOFOILKKH([NoAlias] int* MJMFDBAJGAG, [In][NoAlias] byte* LPHFANJGLGG, int OCJJKCEPHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C122D0", Offset = "0x6C10CD0", VA = "0x186C122D0")]
	[BurstCompile]
	private unsafe static void OEJDKGLMNFO([NoAlias] ushort* MJMFDBAJGAG, [In][NoAlias] byte* LPHFANJGLGG, int OCJJKCEPHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C0CCD0", Offset = "0x6C0B6D0", VA = "0x186C0CCD0")]
	[BurstCompile]
	private static void FFKEKKMPOBC([Out] float3 HEJFDMKOMMK, ushort BAHIDEJIOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D9C0", Offset = "0x6C0C3C0", VA = "0x186C0D9C0")]
	[BurstCompile]
	private static ushort GNNICJBPOME([In] float3 KDDOAOLIOLC)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BurstCompile]
public class CCDNCOACIDM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum MMFBGFODIND
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum ACFNMDPMKLA
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		_,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		_VERTEX_FORMAT_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		_VERTEX_FORMAT_POSFIXED16_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct KGEPNBHACHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public MMFBGFODIND EPLBBPBANLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool FFPEIOBGMIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int EOHBEBKFHGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public VertexAttributeDescriptor[] IONJLKJKOGC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[BurstCompile]
	public struct HJHPNBBGPHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3 EJEBFMEPKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float3 MLNCIIKLLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float4 HLAFCKKNDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float2 EKKIKBJJEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float4 POALGEAPANE;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly VertexAttributeDescriptor[] IONJLKJKOGC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[BurstCompile]
	public struct OFMOFAGFMLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float3 EJEBFMEPKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half4 MLNCIIKLLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half4 HLAFCKKNDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float2 EKKIKBJJEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 POALGEAPANE;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly VertexAttributeDescriptor[] IONJLKJKOGC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[BurstCompile]
	public struct MHIEPBJMNDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float3 EJEBFMEPKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public uint MLNCIIKLLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public uint HLAFCKKNDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float2 EKKIKBJJEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half4 POALGEAPANE;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly VertexAttributeDescriptor[] IONJLKJKOGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[BurstCompile]
	public struct OMNLDCDLNAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float3 EJEBFMEPKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public uint MLNCIIKLLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public uint HLAFCKKNDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 EKKIKBJJEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 POALGEAPANE;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly VertexAttributeDescriptor[] IONJLKJKOGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[BurstCompile]
	public struct OMCKMLHEHMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float3 EJEBFMEPKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public uint MELFDLPICKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float2 EKKIKBJJEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public uint KLAOBCEDHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public uint HICMHKKLOFF;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly VertexAttributeDescriptor[] IONJLKJKOGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile]
	public struct GLIGFOGBAPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public ECNJLGDNCJE.FNOJKOIFMGI FPEFGIHHBIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint MELFDLPICKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float2 EKKIKBJJEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public uint KLAOBCEDHBB;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly VertexAttributeDescriptor[] IONJLKJKOGC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int OFPKFKMOFKD(float OFCNMBDJPHM);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class FABDGAOFGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr IKHHAMMOCMD;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr HEFHPOOJBHL;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6C054A0", Offset = "0x6C03EA0", VA = "0x186C054A0")]
		[BurstDiscard]
		private static void KJFMGMIABDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6C055C0", Offset = "0x6C03FC0", VA = "0x186C055C0")]
		private static IntPtr NDCMKDNCJFI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6C05400", Offset = "0x6C03E00", VA = "0x186C05400")]
		public static void GNCGOKJJKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6C051A0", Offset = "0x6C03BA0", VA = "0x186C051A0")]
		public static int CPLCIOOIDJC(float OFCNMBDJPHM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate uint BEKLPJLMGGH([In] float4 NLEGDNPENLM);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class JEMEIBIKLED
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr IKHHAMMOCMD;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr HEFHPOOJBHL;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6C092C0", Offset = "0x6C07CC0", VA = "0x186C092C0")]
		[BurstDiscard]
		private static void KJFMGMIABDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6C093E0", Offset = "0x6C07DE0", VA = "0x186C093E0")]
		private static IntPtr NDCMKDNCJFI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6C09220", Offset = "0x6C07C20", VA = "0x186C09220")]
		public static void GNCGOKJJKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6C08EF0", Offset = "0x6C078F0", VA = "0x186C08EF0")]
		public static uint CPLCIOOIDJC([In] float4 NLEGDNPENLM)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate uint HCLACMOKPAB([In] float3 NLEGDNPENLM);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class KLCGODNHMJH
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr IKHHAMMOCMD;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr HEFHPOOJBHL;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6C09840", Offset = "0x6C08240", VA = "0x186C09840")]
		[BurstDiscard]
		private static void KJFMGMIABDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6C09960", Offset = "0x6C08360", VA = "0x186C09960")]
		private static IntPtr NDCMKDNCJFI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6C097A0", Offset = "0x6C081A0", VA = "0x186C097A0")]
		public static void GNCGOKJJKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6C09530", Offset = "0x6C07F30", VA = "0x186C09530")]
		public static uint CPLCIOOIDJC([In] float3 NLEGDNPENLM)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void HOKNNGCJHOG([NoAlias] MHIEPBJMNDD* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class FEGNLEPDDPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr IKHHAMMOCMD;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr HEFHPOOJBHL;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C059E0", Offset = "0x6C043E0", VA = "0x186C059E0")]
		[BurstDiscard]
		private static void KJFMGMIABDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6C05B00", Offset = "0x6C04500", VA = "0x186C05B00")]
		private static IntPtr NDCMKDNCJFI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6C05940", Offset = "0x6C04340", VA = "0x186C05940")]
		public static void GNCGOKJJKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C05710", Offset = "0x6C04110", VA = "0x186C05710")]
		public unsafe static void CPLCIOOIDJC([NoAlias] MHIEPBJMNDD* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void IODFKICOCNF([NoAlias] OMNLDCDLNAF* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class DEOFPIIPHEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr IKHHAMMOCMD;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr HEFHPOOJBHL;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C01550", Offset = "0x6BFFF50", VA = "0x186C01550")]
		[BurstDiscard]
		private static void KJFMGMIABDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C01670", Offset = "0x6C00070", VA = "0x186C01670")]
		private static IntPtr NDCMKDNCJFI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C014B0", Offset = "0x6BFFEB0", VA = "0x186C014B0")]
		public static void GNCGOKJJKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C01280", Offset = "0x6BFFC80", VA = "0x186C01280")]
		public unsafe static void CPLCIOOIDJC([NoAlias] OMNLDCDLNAF* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void HEBNPNBAJCO([NoAlias] OMCKMLHEHMP* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class ILHHLCBEMHK
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr IKHHAMMOCMD;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr HEFHPOOJBHL;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C08C80", Offset = "0x6C07680", VA = "0x186C08C80")]
		[BurstDiscard]
		private static void KJFMGMIABDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C08DA0", Offset = "0x6C077A0", VA = "0x186C08DA0")]
		private static IntPtr NDCMKDNCJFI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6C08BE0", Offset = "0x6C075E0", VA = "0x186C08BE0")]
		public static void GNCGOKJJKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6C08800", Offset = "0x6C07200", VA = "0x186C08800")]
		public unsafe static void CPLCIOOIDJC([NoAlias] OMCKMLHEHMP* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void IDLLAPKIPAA([NoAlias] GLIGFOGBAPG* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE, [Out] float3 LIJJBPIIGGH, [Out] float3 EKPMEGFFHKM);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class PBIHKCLHEEL
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr IKHHAMMOCMD;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr HEFHPOOJBHL;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C140E0", Offset = "0x6C12AE0", VA = "0x186C140E0")]
		[BurstDiscard]
		private static void KJFMGMIABDM(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6C14200", Offset = "0x6C12C00", VA = "0x186C14200")]
		private static IntPtr NDCMKDNCJFI()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C14040", Offset = "0x6C12A40", VA = "0x186C14040")]
		public static void GNCGOKJJKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void HINDDHMAHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6C13AF0", Offset = "0x6C124F0", VA = "0x186C13AF0")]
		public unsafe static void CPLCIOOIDJC([NoAlias] GLIGFOGBAPG* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE, [Out] float3 LIJJBPIIGGH, [Out] float3 EKPMEGFFHKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int NIILPGIEFPM = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeList<float3> DBHGOMEALGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<float3> CDPAAJHHBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<float4> MNFADFCKGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<float4> IIGCPNODIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<float2> MPDFFHGOHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeList<int> PCHEEJGAOHB;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly VertexAttributeDescriptor[][] LIGPDBNAPFJ;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static bool HBIABINHNHG;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static KGEPNBHACHA[] FKHJKPNAFOC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool EMCJBNDMBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6BFDF10", Offset = "0x6BFC910", VA = "0x186BFDF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PDIJFBBJBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6BFCFF0", Offset = "0x6BFB9F0", VA = "0x186BFCFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DLPMFIBCHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6BFE9A0", Offset = "0x6BFD3A0", VA = "0x186BFE9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool PCAPILBILFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6BFAEA0", Offset = "0x6BF98A0", VA = "0x186BFAEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BFBFF0", Offset = "0x6BFA9F0", VA = "0x186BFBFF0")]
	public static ACFNMDPMKLA GCMCPBFCKPD(MMFBGFODIND EPLBBPBANLK)
	{
		return default(ACFNMDPMKLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB150", Offset = "0x6BF9B50", VA = "0x186BFB150")]
	public static void DNFFJEBFCFO(ACFNMDPMKLA IOHMNGLJPLF, Material PPFNGNPGEKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB210", Offset = "0x6BF9C10", VA = "0x186BFB210", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE9E0", Offset = "0x6BFD3E0", VA = "0x186BFE9E0")]
	public void MKPLHMCKEFN(int FBOKOPMOEJK, int AJEDNCMAFDC, Allocator MPFEIGMBFCP, bool JPGGAOJIILF, bool EGBKFGBEKKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BFF5A0", Offset = "0x6BFDFA0", VA = "0x186BFF5A0")]
	public void OEBCLMCMPAP(int FBOKOPMOEJK, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE980", Offset = "0x6BFD380", VA = "0x186BFE980", Slot = "6")]
	public bool LHJCKCLEAIP(Mesh LDNHICGPCIN, bool GGJBONHMINM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA2C0", Offset = "0x6BF8CC0", VA = "0x186BFA2C0")]
	public bool AIPPEMFICCJ(Mesh LDNHICGPCIN, bool GGJBONHMINM, bool BKBGHDDFJBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BFCAF0", Offset = "0x6BFB4F0", VA = "0x186BFCAF0")]
	public bool HDDDDPNPEKF(Mesh LDNHICGPCIN, CCDNCOACIDM EELMJEFFAJG, bool GGJBONHMINM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6BFC040", Offset = "0x6BFAA40", VA = "0x186BFC040")]
	public void GMBANCNAILN(Mesh LDNHICGPCIN, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6BFF6C0", Offset = "0x6BFE0C0", VA = "0x186BFF6C0")]
	[BurstCompile]
	public static int OOJCIDMIKNO(float OFCNMBDJPHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BFF620", Offset = "0x6BFE020", VA = "0x186BFF620")]
	[BurstCompile]
	public static uint OOJCIDMIKNO([In] float4 NLEGDNPENLM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6BFF670", Offset = "0x6BFE070", VA = "0x186BFF670")]
	[BurstCompile]
	public static uint OOJCIDMIKNO([In] float3 NLEGDNPENLM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6BFEF10", Offset = "0x6BFD910", VA = "0x186BFEF10")]
	public void NPDHPMAEINI(Mesh LDNHICGPCIN, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB040", Offset = "0x6BF9A40", VA = "0x186BFB040")]
	[BurstCompile]
	private unsafe static void COMFELOBJCJ([NoAlias] MHIEPBJMNDD* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BFD3F0", Offset = "0x6BFBDF0", VA = "0x186BFD3F0")]
	public void IKNICANGCCH(Mesh LDNHICGPCIN, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6BFBC30", Offset = "0x6BFA630", VA = "0x186BFBC30")]
	[BurstCompile]
	private unsafe static void FEDNCBICEIA([NoAlias] OMNLDCDLNAF* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9C30", Offset = "0x6BF8630", VA = "0x186BF9C30")]
	public void ADCIBMPLCMK(Mesh LDNHICGPCIN, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB660", Offset = "0x6BFA060", VA = "0x186BFB660")]
	[BurstCompile]
	private unsafe static void ECFLBMNPLOP([NoAlias] OMCKMLHEHMP* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE240", Offset = "0x6BFCC40", VA = "0x186BFE240")]
	public void LBEANOJCIFO(Mesh LDNHICGPCIN, bool BKBGHDDFJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA6C0", Offset = "0x6BF90C0", VA = "0x186BFA6C0")]
	[BurstCompile]
	private unsafe static void BFPJCAEDKNH([NoAlias] GLIGFOGBAPG* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE, [Out] float3 LIJJBPIIGGH, [Out] float3 EKPMEGFFHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB0C0", Offset = "0x6BF9AC0", VA = "0x186BFB0C0")]
	public void DJPJFLDGBAA(Mesh LDNHICGPCIN, MMFBGFODIND EPLBBPBANLK, bool BKBGHDDFJBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6BFBCB0", Offset = "0x6BFA6B0", VA = "0x186BFBCB0")]
	public void FFOEOKOCNDM(CCDNCOACIDM LDNHICGPCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB6E0", Offset = "0x6BFA0E0", VA = "0x186BFB6E0")]
	public void EJNEOKBFAGK(CCDNCOACIDM FCLIEHCKPJG, Allocator MPFEIGMBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDA80", Offset = "0x6BFC480", VA = "0x186BFDA80")]
	public long IOPMHHCCPGJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDBD0", Offset = "0x6BFC5D0", VA = "0x186BFDBD0")]
	public static long IOPMHHCCPGJ(int KPDFMAJJIDO, int APGPKFJLLNJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6BFAFA0", Offset = "0x6BF99A0", VA = "0x186BFAFA0")]
	public static long CEGDODLLDPO(int KPDFMAJJIDO, int APGPKFJLLNJ, MMFBGFODIND EPLBBPBANLK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6BFAEE0", Offset = "0x6BF98E0", VA = "0x186BFAEE0")]
	public long CEGDODLLDPO(MMFBGFODIND EPLBBPBANLK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BFEBD0", Offset = "0x6BFD5D0", VA = "0x186BFEBD0")]
	public void MNOGAMBGGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDF50", Offset = "0x6BFC950", VA = "0x186BFDF50")]
	public static void KIPNIPBAJGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6BFA740", Offset = "0x6BF9140", VA = "0x186BFA740")]
	public MMFBGFODIND CAMOAGJMJMG()
	{
		return default(MMFBGFODIND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BFBF20", Offset = "0x6BFA920", VA = "0x186BFBF20")]
	public static (int, int) GAEPOEIPGHG(Mesh LDNHICGPCIN)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BFEC30", Offset = "0x6BFD630", VA = "0x186BFEC30")]
	public static int MPCKEEDDNEA(VertexAttributeDescriptor[] LMLJGINIKJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BFCA80", Offset = "0x6BFB480", VA = "0x186BFCA80")]
	public static long GOBHHPGHHLB(Mesh LDNHICGPCIN, int KCBKHLKNOGG, int IKAMAFCLHNM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public CCDNCOACIDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDDC0", Offset = "0x6BFC7C0", VA = "0x186BFDDC0")]
	[BurstCompile]
	public static int JCEHGKNFLOE(float OFCNMBDJPHM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDC30", Offset = "0x6BFC630", VA = "0x186BFDC30")]
	[BurstCompile]
	public static uint JCEHGKNFLOE([In] float4 NLEGDNPENLM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDE60", Offset = "0x6BFC860", VA = "0x186BFDE60")]
	[BurstCompile]
	public static uint JCEHGKNFLOE([In] float3 NLEGDNPENLM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BFD030", Offset = "0x6BFBA30", VA = "0x186BFD030")]
	[BurstCompile]
	public unsafe static void IGMPCEBFNPA([NoAlias] MHIEPBJMNDD* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB7E0", Offset = "0x6BFA1E0", VA = "0x186BFB7E0")]
	[BurstCompile]
	public unsafe static void ELCLDHDLKJE([NoAlias] OMNLDCDLNAF* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6BFED10", Offset = "0x6BFD710", VA = "0x186BFED10")]
	[BurstCompile]
	public unsafe static void NDDMCOPKIGC([NoAlias] OMCKMLHEHMP* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6BFB320", Offset = "0x6BF9D20", VA = "0x186BFB320")]
	[BurstCompile]
	public unsafe static void EBKBIILIANC([NoAlias] GLIGFOGBAPG* KAAKJDADBHH, int NHPNPOOIEDN, [In][NoAlias] float3* AFJIEILGPHO, [In][NoAlias] float3* PPFPMPHOIPJ, [In][NoAlias] float4* NNLIGJLJJPB, [In][NoAlias] float2* HMMBCCAOJNE, [In][NoAlias] float4* POALGEAPANE, [Out] float3 LIJJBPIIGGH, [Out] float3 EKPMEGFFHKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct APCNFEJOGHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int ELOOIMLKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 DIECILFOMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public quaternion PNJCJALKMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 EEIOAOCPFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int LEJGECJHNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int CBBLFCJPJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int ALOCJOCGMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float BDFLNHNKFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 POLEEJMBAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool IAGACNPNBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public BPANGNGAEKC KNOLLLHCLID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 OKKDJCNCHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float BPHPJDHFKJD;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class ENAKOAFNLIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static NAHHJEPLBBI GOFEMNLFGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<APCNFEJOGHL> KPBHPOBBNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<CHCPMMDIJPC> PBLDGEIJPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<DIIGFEGOJJP> OJMPBDEENHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<GIIFOCGKODC> MIBHCGOBBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<CHCPMMDIJPC> IMNLMAMCHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeList<DKBOBCBBMPI> MAHCLFBCCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeArray<GIIFOCGKODC>> EPKCOLBNGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<JPGICEJAGBI> JALKOEKJCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<int> MFJIAOCGHAB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PDIJFBBJBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x10314C0", Offset = "0x102FEC0", VA = "0x1810314C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x102FDB0", Offset = "0x102E7B0", VA = "0x18102FDB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int DLPMFIBCHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x10314D0", Offset = "0x102FED0", VA = "0x1810314D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1030370", Offset = "0x102ED70", VA = "0x181030370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C04F80", Offset = "0x6C03980", VA = "0x186C04F80")]
	public ENAKOAFNLIC(int EPPDOKJKACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C03580", Offset = "0x6C01F80", VA = "0x186C03580", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C04DB0", Offset = "0x6C037B0", VA = "0x186C04DB0")]
	public void NEECMKACHFC(JobHandle AJLOAOCOAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C039F0", Offset = "0x6C023F0", VA = "0x186C039F0")]
	public void FLMIIBLAEEF(APCNFEJOGHL LNCKNHNHHDF, JPGICEJAGBI IPMIDBLDMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6C04C50", Offset = "0x6C03650", VA = "0x186C04C50")]
	public void JHKINFPMGDP(DIIGFEGOJJP LNCKNHNHHDF, NativeArray<GIIFOCGKODC> CCFEFGMEFDM, int NHPNPOOIEDN, int OCJJKCEPHKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C03C10", Offset = "0x6C02610", VA = "0x186C03C10")]
	public JobHandle HDAEGHBOGKP(CCDNCOACIDM FCPABHLACHO, FCKFJPINFJG CABEFGAIAIB, float3 CMMAJLILLDA, quaternion HCNFJGGDODJ, float PGNMBJADAOJ, bool HFIHKBNBMIK, int LADLNIKFPAC = 0, int HNKBPPHELJL = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C03240", Offset = "0x6C01C40", VA = "0x186C03240")]
	public static JobHandle APLPOFEPAIJ(PCOCLEGEFAO CENFCNEDLCH, CCDNCOACIDM FCPABHLACHO, APCNFEJOGHL LNCKNHNHHDF, JobHandle AJLOAOCOAJH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C03740", Offset = "0x6C02140", VA = "0x186C03740")]
	public static JobHandle EABKNPFGEPJ(IBFNBBNHNKM CENFCNEDLCH, CCDNCOACIDM FCPABHLACHO, DIIGFEGOJJP LNCKNHNHHDF, NativeArray<GIIFOCGKODC> CCFEFGMEFDM, int NHPNPOOIEDN, int OCJJKCEPHKD, JobHandle AJLOAOCOAJH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct ALFIKELPKKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float2 DLIHEBHOHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float2 CJCJBFOPPCO;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EEINLHAOFPG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeArray<ALFIKELPKKJ> EMGFLNPJGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeArray<int> ENAEJNEKJBN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PDIJFBBJBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x883E10", Offset = "0x882810", VA = "0x180883E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DLPMFIBCHFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884030", VA = "0x180885630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6C01900", Offset = "0x6C00300", VA = "0x186C01900")]
	public EEINLHAOFPG(int FBOKOPMOEJK, int AJEDNCMAFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6C017C0", Offset = "0x6C001C0", VA = "0x186C017C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C01820", Offset = "0x6C00220", VA = "0x186C01820")]
	public void FFOEOKOCNDM(EEINLHAOFPG MBBNIOPNEPF, int KJODIAFLICC, int BHLKMIGNPBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class EJMIJJCCGMG
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static EEINLHAOFPG NPKDIGGHOIK;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static NativeList<CHCPMMDIJPC> EOIENKNPPAL;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int[] FAHOJNCOHNO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static bool EAIEJBIPPDD;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static Dictionary<int, EEINLHAOFPG> MGCKDOAGKCH;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static Dictionary<int, EEINLHAOFPG> APLNFOOFLGO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool NGLCIJHHODC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6C03070", Offset = "0x6C01A70", VA = "0x186C03070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<CHCPMMDIJPC> NFCDHPKCJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6C01C50", Offset = "0x6C00650", VA = "0x186C01C50")]
		get
		{
			return default(NativeList<CHCPMMDIJPC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static EEINLHAOFPG EACNFEPKPOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C02FB0", Offset = "0x6C019B0", VA = "0x186C02FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C02520", Offset = "0x6C00F20", VA = "0x186C02520")]
	private static void ILMFOKGIIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C03040", Offset = "0x6C01A40", VA = "0x186C03040")]
	public static int PGFIKGFMKOF(bool LMDICACNINH, int ODGJGBCNAPA, bool PCJIIOGGLPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6C02DA0", Offset = "0x6C017A0", VA = "0x186C02DA0")]
	private static int KJBGJJHABCF(int ODGJGBCNAPA, bool DGDJJMGEDPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6C01D20", Offset = "0x6C00720", VA = "0x186C01D20")]
	private static int EMDNGKBIKLM(int ODGJGBCNAPA, bool DGDJJMGEDPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6C01D30", Offset = "0x6C00730", VA = "0x186C01D30")]
	public static int EOMEDKDMMAK(int PDJBKOAOLLN, int ODGJGBCNAPA, int IMJLKFHCBIL, bool DGDJJMGEDPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6C02F20", Offset = "0x6C01920", VA = "0x186C02F20")]
	public static int KMLJJPOELKN(int PDJBKOAOLLN, int ODGJGBCNAPA, int IMJLKFHCBIL, bool DGDJJMGEDPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6C01DD0", Offset = "0x6C007D0", VA = "0x186C01DD0")]
	public static int FLAAIHKMBGJ(int IMJLKFHCBIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6C01DC0", Offset = "0x6C007C0", VA = "0x186C01DC0")]
	private static int FCANEFOEAKJ(int ODGJGBCNAPA, bool DGDJJMGEDPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6C01D00", Offset = "0x6C00700", VA = "0x186C01D00")]
	private static int EKKOLPGKJDH(int ODGJGBCNAPA, bool DGDJJMGEDPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6C02EB0", Offset = "0x6C018B0", VA = "0x186C02EB0")]
	public static int KMEAOBCJOME(int PDJBKOAOLLN, int ODGJGBCNAPA, int IMJLKFHCBIL, bool DGDJJMGEDPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6C02D10", Offset = "0x6C01710", VA = "0x186C02D10")]
	public static int JOMJPLCIAEM(int PDJBKOAOLLN, int ODGJGBCNAPA, int IMJLKFHCBIL, bool DGDJJMGEDPF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6C01CE0", Offset = "0x6C006E0", VA = "0x186C01CE0")]
	public static int BBLKKHGFNGA(int IMJLKFHCBIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6C02C20", Offset = "0x6C01620", VA = "0x186C02C20")]
	public static EEINLHAOFPG JAPBAOMDGLP(int ODGJGBCNAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C019C0", Offset = "0x6C003C0", VA = "0x186C019C0")]
	private static EEINLHAOFPG AEOOHNIGLII(int ODGJGBCNAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6C02DC0", Offset = "0x6C017C0", VA = "0x186C02DC0")]
	public static EEINLHAOFPG KKCJJIFDAJF(int ODGJGBCNAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6C01DE0", Offset = "0x6C007E0", VA = "0x186C01DE0")]
	private static EEINLHAOFPG GJOANCGJCGD(int ODGJGBCNAPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6C02120", Offset = "0x6C00B20", VA = "0x186C02120")]
	public static void HBMCPINPHMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DIIGFEGOJJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public int DLKLFEHPHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 DIECILFOMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public quaternion PNJCJALKMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float EEIOAOCPFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float FGIANFCABMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int LEJGECJHNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int CBBLFCJPJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int ALOCJOCGMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool HDJINLOGFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool FDMNCDNLLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public float BDFLNHNKFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float3 POLEEJMBAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool DMOFABFIKEM;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct DKBOBCBBMPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public int FAFMIGKFBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public int ANBLLOPGBCI;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct IBFNBBNHNKM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeList<DIIGFEGOJJP> NFOEDAHEOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<GIIFOCGKODC> LMMHBIEKAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<CHCPMMDIJPC> LCPINLOKHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeArray<DKBOBCBBMPI> EICFOPKKBHC;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6C06180", Offset = "0x6C04B80", VA = "0x186C06180")]
	public IBFNBBNHNKM(NativeArray<GIIFOCGKODC> LMMHBIEKAPK, int ECFPAOHDFEB = 1, Allocator MPFEIGMBFCP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6C06090", Offset = "0x6C04A90", VA = "0x186C06090", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
public struct IIJOGHNCAJC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private NativeArray<ALFIKELPKKJ> LBIDEIPEOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[ReadOnly]
	private NativeArray<int> DMFGCKNNNFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[ReadOnly]
	private NativeList<CHCPMMDIJPC> ADAALANIKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<DIIGFEGOJJP> NFOEDAHEOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<GIIFOCGKODC> LMMHBIEKAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeArray<CHCPMMDIJPC> LCPINLOKHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	public NativeArray<DKBOBCBBMPI> EICFOPKKBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private int HLOAACPKNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private int LGDKNGELBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private float3 GJJMDNBPPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private quaternion PNFLDLFMAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private float3 GLIJFLKLPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JHAODFHNNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DALNODGHPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DJKGABFAPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PDKKDJGAKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> PCHAPHDLKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LBCIGMJDCDA;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6C08350", Offset = "0x6C06D50", VA = "0x186C08350")]
	public IIJOGHNCAJC(ENAKOAFNLIC BELEHLIEEHM, CCDNCOACIDM OELLCDODEAO, float3 FIHELOEINMP, quaternion HKMNCENFBFC, float FNIDFFFFBMA, int LADLNIKFPAC = 0, int HNKBPPHELJL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6C085D0", Offset = "0x6C06FD0", VA = "0x186C085D0")]
	public IIJOGHNCAJC(IBFNBBNHNKM BELEHLIEEHM, CCDNCOACIDM OELLCDODEAO, float3 FIHELOEINMP, quaternion HKMNCENFBFC, float3 FNIDFFFFBMA, int LADLNIKFPAC = 0, int HNKBPPHELJL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6C064B0", Offset = "0x6C04EB0", VA = "0x186C064B0")]
	private float3 CHNIJBLMLKH(float3 HJOGAOCMIOF, Matrix4x4 HKJDFDLBMOG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6C07D10", Offset = "0x6C06710", VA = "0x186C07D10")]
	private float3x3 FPAEPFHAKDM(float3x3 FOCMGCGNLKH, float3x3 OOGBJJOJMKK)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6C07D90", Offset = "0x6C06790", VA = "0x186C07D90")]
	private float GBCANLGFCOC(float FCFDEHNOPJK, float AIPMMEJFPJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6C06B70", Offset = "0x6C05570", VA = "0x186C06B70", Slot = "4")]
	public void Execute(int PMJJDLNJJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6C07DA0", Offset = "0x6C067A0", VA = "0x186C07DA0")]
	private void LPBANGIAKPN(int MCNLMPNJCIA, float3 EJEBFMEPKGF, float3 MLNCIIKLLEK, float3 HLAFCKKNDEJ, float KGJKNMNONHN, bool JKDNJMGKGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6C07F10", Offset = "0x6C06910", VA = "0x186C07F10")]
	private void POPPFNIIAKI(DIIGFEGOJJP INPHFGEGPBD, float3 BJFHPDFPFFI, float3x3 GNJAOBEFJHH, float FCFDEHNOPJK, int PLBIEMLINNE, int CNPJAJKGNLC, int AMGMIDEJNAA, float FGCGMAFCFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6C065F0", Offset = "0x6C04FF0", VA = "0x186C065F0")]
	private void DFEKOECJHBE(int MCNLMPNJCIA, int GAMILOIBIBB, DIIGFEGOJJP INPHFGEGPBD, float3 BJFHPDFPFFI, float3x3 GNJAOBEFJHH, bool GECLONPDDDA, float FCFDEHNOPJK, int JMLGOHGKFNA, int HBALGGGNGNG, int AMGMIDEJNAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct PCOCLEGEFAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<APCNFEJOGHL> LLNCDMGLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<CHCPMMDIJPC> CAEMGDGPOOJ;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6C143F0", Offset = "0x6C12DF0", VA = "0x186C143F0")]
	public PCOCLEGEFAO(int ECFPAOHDFEB, Allocator MPFEIGMBFCP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6C14350", Offset = "0x6C12D50", VA = "0x186C14350", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct COOFNDELNOD : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private enum ALJHDKBONIC
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		X,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> DPAJCGAMNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> ODFLFNPPDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<int> POGONACFFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> KMKHCMKEOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<float4> BONCIKGPCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float4> ONIFADCDKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float4> IGFPHMLBFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> MJFKHEPGOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private NativeList<CHCPMMDIJPC> JOHBPAMKHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<APCNFEJOGHL> LLNCDMGLLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeList<CHCPMMDIJPC> CAEMGDGPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private int HLOAACPKNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private int LGDKNGELBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JHAODFHNNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DALNODGHPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DJKGABFAPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PDKKDJGAKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> PCHAPHDLKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LBCIGMJDCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float3 GLIJFLKLPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private quaternion PNFLDLFMAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private float3 GJJMDNBPPEL;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6C01090", Offset = "0x6BFFA90", VA = "0x186C01090")]
	public COOFNDELNOD(ENAKOAFNLIC BELEHLIEEHM, CCDNCOACIDM OELLCDODEAO, float3 FIHELOEINMP, quaternion HKMNCENFBFC, float FNIDFFFFBMA, int LADLNIKFPAC = 0, int HNKBPPHELJL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6C00EB0", Offset = "0x6BFF8B0", VA = "0x186C00EB0")]
	public COOFNDELNOD(PCOCLEGEFAO LNCKNHNHHDF, CCDNCOACIDM OELLCDODEAO, float3 FIHELOEINMP, quaternion HKMNCENFBFC, float3 FNIDFFFFBMA, int LADLNIKFPAC = 0, int HNKBPPHELJL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6BFFB00", Offset = "0x6BFE500", VA = "0x186BFFB00", Slot = "4")]
	public void Execute(int PMJJDLNJJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6C00B00", Offset = "0x6BFF500", VA = "0x186C00B00")]
	private void PFBEFMCNAEL(float4x4 AOJGHDIINDK, int PMJJDLNJJBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6C00A90", Offset = "0x6BFF490", VA = "0x186C00A90")]
	private ALJHDKBONIC NIGGKBAHIIB(float3 MLNCIIKLLEK)
	{
		return default(ALJHDKBONIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6C00A00", Offset = "0x6BFF400", VA = "0x186C00A00")]
	private float4 JAFEDGNELJD(ALJHDKBONIC LBDMGJNBLIA, int ENMILGHAHOM)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6C00A50", Offset = "0x6BFF450", VA = "0x186C00A50")]
	private float2 KMCNMAHFILG(ALJHDKBONIC LBDMGJNBLIA, float3 EJEBFMEPKGF)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct JPGICEJAGBI
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum MLPGBANFKJG
	{
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static JPGICEJAGBI CKLKOBNMKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 EDBNILFNKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3x3 EEFKFMHIEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float3 BKOAINILKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public MLPGBANFKJG GPKIFFDGPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float3 LCEFAIMDJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float3 PKHAJGBOIDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool DDBKACNOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC50", Offset = "0x6C29650", VA = "0x186C2AC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 HNBIDONPKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B390", Offset = "0x6C29D90", VA = "0x186C2B390")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B4D0", Offset = "0x6C29ED0", VA = "0x186C2B4D0")]
	public JPGICEJAGBI(float3 EJEBFMEPKGF, quaternion PCIAHIPKDFG, float3 ECFPAOHDFEB, MLPGBANFKJG AOGCIMANLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AD50", Offset = "0x6C29750", VA = "0x186C2AD50")]
	public float LNCJNCMIJAJ(float3 BJFHPDFPFFI, float NKLADHFBECN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AC60", Offset = "0x6C29660", VA = "0x186C2AC60")]
	public bool IENFMEDIIJL(float3 MLNCIIKLLEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AF50", Offset = "0x6C29950", VA = "0x186C2AF50")]
	public void MKDNAECKPBH(float3 AIBNBKDEEOK, float3x3 KMKCJFMOOLA, float BDDECOPOPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2AB60", Offset = "0x6C29560", VA = "0x186C2AB60")]
	private void GEFIBMNHLCK(float3 CJFPFKBEIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B100", Offset = "0x6C29B00", VA = "0x186C2B100")]
	public void MMPPFLPAMPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
public struct FAGFMGFDBPC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	private NativeList<JPGICEJAGBI> LNCKNHNHHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	private NativeList<float3> EBLHLLMOJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	private NativeList<int> MBDNPINLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MFJIAOCGHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	private NativeList<CHCPMMDIJPC> CAEMGDGPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	private int KHLLDIKGCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private int IMOBNHPLOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private float NKLADHFBECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private float LGCIKEIHALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> OCFKPDDPIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> BDFBDGLDABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> BBFEANEOPKA;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6C29D00", Offset = "0x6C28700", VA = "0x186C29D00")]
	public FAGFMGFDBPC(CCDNCOACIDM LDNHICGPCIN, float DGFLHGGMMKE, int BHLKMIGNPBH, int PLBIEMLINNE, NativeList<JPGICEJAGBI> LNCKNHNHHDF, NativeArray<int> MFJIAOCGHAB, NativeList<CHCPMMDIJPC> CAEMGDGPOOJ, FCKFJPINFJG CABEFGAIAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6C29330", Offset = "0x6C27D30", VA = "0x186C29330", Slot = "4")]
	public void Execute(int DBGFIJJANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C29270", Offset = "0x6C27C70", VA = "0x186C29270")]
	private bool DEDHIKGPCDP(JPGICEJAGBI KPNKONMDFPM, JPGICEJAGBI NGNLLOFPDHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6C29A70", Offset = "0x6C28470", VA = "0x186C29A70")]
	private bool OOGHBCHHEPB(JPGICEJAGBI PCNHICDPHHL, int FMJCNFMMHMI, int CBJBGKIIBNP, int HJKIHFAPPBI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FCKFJPINFJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public NativeArray<bool> GDBCMDONHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public NativeArray<int> BDDGAAMBION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public NativeArray<bool> IDJEDPPHPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NativeArray<float> DBGAHDJNBAK;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C29EB0", Offset = "0x6C288B0", VA = "0x186C29EB0")]
	public void MKPLHMCKEFN(int FBOKOPMOEJK, int AJEDNCMAFDC, Allocator MPFEIGMBFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6C29E90", Offset = "0x6C28890", VA = "0x186C29E90")]
	public static long KBJJKABHAIG(int FBOKOPMOEJK, int AJEDNCMAFDC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C29DA0", Offset = "0x6C287A0", VA = "0x186C29DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6C29FD0", Offset = "0x6C289D0", VA = "0x186C29FD0")]
	public void NEECMKACHFC(JobHandle AJLOAOCOAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public FCKFJPINFJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
public struct NLJDKLOHECH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NativeList<float3> EBLHLLMOJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private NativeArray<float3> PPFPMPHOIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeArray<float4> POALGEAPANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float2> HMMBCCAOJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeList<int> MBDNPINLOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NNLIGJLJJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> NCFLODLHEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[ReadOnly]
	private NativeArray<bool> OCFKPDDPIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[ReadOnly]
	private NativeArray<bool> BDFBDGLDABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	private int LADLNIKFPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private int HNKBPPHELJL;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D4C0", Offset = "0x6C2BEC0", VA = "0x186C2D4C0")]
	public NLJDKLOHECH(CCDNCOACIDM LDNHICGPCIN, FCKFJPINFJG CABEFGAIAIB, int HNKBPPHELJL = 0, int LADLNIKFPAC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D080", Offset = "0x6C2BA80", VA = "0x186C2D080", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D460", Offset = "0x6C2BE60", VA = "0x186C2D460")]
	private void HPBECJGOHKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KOAIEHJDBCO
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2E159D0", Offset = "0x2E143D0", VA = "0x182E159D0")]
	public static bool HGLDNHMBNED<T>(NativeArray<T> FEMJEOMOEIN, int ECFPAOHDFEB, Allocator MPFEIGMBFCP, NativeArrayOptions JIEJKJIJPFC = NativeArrayOptions.ClearMemory, int GCJNCMIEMOC = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2E15A90", Offset = "0x2E14490", VA = "0x182E15A90")]
	public static bool HGLDNHMBNED<T>(NativeList<T> GLCCIANLCJC, int ECFPAOHDFEB, Allocator MPFEIGMBFCP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum BMENCFGGDHJ
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Force2
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LFILPOBKFEH
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LLPGLDJILPJ(BMENCFGGDHJ PDJBKOAOLLN);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LIOFLIMODLJ(BMENCFGGDHJ PDJBKOAOLLN);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds LOFPOCMJDLC();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float FBEJCKCDMKJ();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DANDGDJPKDJ(BMENCFGGDHJ PDJBKOAOLLN, ENAKOAFNLIC MPPLAHJJFFO, int JJCECAFOBMP = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class DHOJOMLLHKL
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AC60", Offset = "0x6C19660", VA = "0x186C1AC60")]
	public static void HBMCPINPHMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class LKCDLPHPLGK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public NativeList<float3> DBHGOMEALGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public NativeArray<float3> CDPAAJHHBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public NativeArray<int> DEPJPJNICED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<float4> GNBFGDFOCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeArray<float4> DNMOIFFNMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeArray<float4> AAINLAGLBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public NativeList<float3> AMAPKABHION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public NativeList<int> PCHEEJGAOHB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PDIJFBBJBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BEA0", Offset = "0x6C2A8A0", VA = "0x186C2BEA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DLPMFIBCHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6C2C450", Offset = "0x6C2AE50", VA = "0x186C2C450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int JLBPICEINAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B5C0", Offset = "0x6C29FC0", VA = "0x186C2B5C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C790", Offset = "0x6C2B190", VA = "0x186C2C790")]
	public LKCDLPHPLGK(int FBOKOPMOEJK, int AJEDNCMAFDC, int AENDGOKKGBJ, Allocator MPFEIGMBFCP = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C490", Offset = "0x6C2AE90", VA = "0x186C2C490")]
	public LKCDLPHPLGK(Mesh LDNHICGPCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B600", Offset = "0x6C2A000", VA = "0x186C2B600", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B710", Offset = "0x6C2A110", VA = "0x186C2B710")]
	public void FFOEOKOCNDM(LKCDLPHPLGK LDNHICGPCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BA10", Offset = "0x6C2A410", VA = "0x186C2BA10")]
	private void GBGPMDAIOID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BEE0", Offset = "0x6C2A8E0", VA = "0x186C2BEE0")]
	private void HOBMBBGNMPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct CHCPMMDIJPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int MENBNGIMKAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public int PDIJFBBJBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public int NPAFOBEABDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int DLPMFIBCHFB;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x173D310", Offset = "0x173BD10", VA = "0x18173D310")]
	public CHCPMMDIJPC(int PLBIEMLINNE, int NHPNPOOIEDN, int BHLKMIGNPBH, int OCJJKCEPHKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class NAHHJEPLBBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<CHCPMMDIJPC> JOLLFKFGBOP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9F9DB0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<CHCPMMDIJPC>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9FB630", Offset = "0x9FA030", VA = "0x1809FB630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public LKCDLPHPLGK HPOAHBCFCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CAD0", Offset = "0x6C2B4D0", VA = "0x186C2CAD0")]
	public NAHHJEPLBBI(IEnumerable<LKCDLPHPLGK> IKMOMJBBJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C2CA60", Offset = "0x6C2B460", VA = "0x186C2CA60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum BPANGNGAEKC
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class OIFNPBCJEGK
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static NativeArray<float2> NDOEKKPNBJE;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static NativeArray<float3> FLHPOBFCDCP;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static NativeArray<float4> GLDMPNIJCCL;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static NativeArray<int> FNKLHNPECLL;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D740", Offset = "0x6C2C140", VA = "0x186C2D740")]
	public static void HBMCPINPHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D540", Offset = "0x6C2BF40", VA = "0x186C2D540")]
	public static NativeArray<float2> BMIGIILAPBD(NativeArray<float2> HOEEHDFCAMP, int BEMHJCGDDDI, NativeArray<float2> AJLJBIKGDLB, int GCDKJNGAHOE)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D850", Offset = "0x6C2C250", VA = "0x186C2D850")]
	public static NativeArray<float3> KGMJOFEBNEE(NativeArray<float3> HOEEHDFCAMP, int BEMHJCGDDDI, NativeArray<float3> AJLJBIKGDLB, int GCDKJNGAHOE)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D640", Offset = "0x6C2C040", VA = "0x186C2D640")]
	public static NativeArray<float4> EDHJCHCHNIH(NativeArray<float4> HOEEHDFCAMP, int BEMHJCGDDDI, NativeArray<float4> AJLJBIKGDLB, int GCDKJNGAHOE)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D950", Offset = "0x6C2C350", VA = "0x186C2D950")]
	public static NativeArray<int> MJKMNMEJHBC(NativeArray<int> HOEEHDFCAMP, int BEMHJCGDDDI, NativeArray<int> AJLJBIKGDLB, int GCDKJNGAHOE)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2F024D0", Offset = "0x2F00ED0", VA = "0x182F024D0")]
	private static void IOCDDEBAOAF<T>(NativeArray<T> FEMJEOMOEIN, int IAEFMFLPDFC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2F023F0", Offset = "0x2F00DF0", VA = "0x182F023F0")]
	private static void GEJAMEBPDOA<T>(NativeArray<T> HOEEHDFCAMP, int BEMHJCGDDDI, NativeArray<T> AJLJBIKGDLB, int GCDKJNGAHOE, NativeArray<T> NEBBCPKHFCI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BurstCompile]
public class ECNJLGDNCJE
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct FNOJKOIFMGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ushort OFCNMBDJPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ushort CONCKFNNMJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ushort DKJMHGLFONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ushort FPMJGOIDMHF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6C25FB0", Offset = "0x6C249B0", VA = "0x186C25FB0")]
	public static uint LBNCFGHOLLB(float PENNKIGNOKH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6C261E0", Offset = "0x6C24BE0", VA = "0x186C261E0")]
	public static void MAEDKLMBHAL(float4 POALGEAPANE, float ALNFHFMBHHF, [Out] uint KLAOBCEDHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6C26110", Offset = "0x6C24B10", VA = "0x186C26110")]
	public static void MAEDKLMBHAL(float4 POALGEAPANE, uint JEKFFHBJBBG, [Out] uint KLAOBCEDHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6C26440", Offset = "0x6C24E40", VA = "0x186C26440")]
	public static void NGNIDFMCHPK(float3 IHDGHKFIFMG, float3 JIABFFOMMJH, float4 KGLCBPPJFKL, float2 ODOCABHGPGB, float4 POALGEAPANE, [Out] CCDNCOACIDM.OMCKMLHEHMP NJBBNIGKBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6C26690", Offset = "0x6C25090", VA = "0x186C26690")]
	public static void NGNIDFMCHPK(float3 IHDGHKFIFMG, float3 JIABFFOMMJH, float4 KGLCBPPJFKL, float2 ODOCABHGPGB, float4 POALGEAPANE, [Out] CCDNCOACIDM.GLIGFOGBAPG NJBBNIGKBKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C268F0", Offset = "0x6C252F0", VA = "0x186C268F0")]
	public static byte OJDNJIOFLCD(float IPHMAHBENGI)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C25F60", Offset = "0x6C24960", VA = "0x186C25F60")]
	public static ushort KDKMBILBFDM(float IPHMAHBENGI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6C25EB0", Offset = "0x6C248B0", VA = "0x186C25EB0")]
	public static uint GIGDOPLIKAK(float IPHMAHBENGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6C25EE0", Offset = "0x6C248E0", VA = "0x186C25EE0")]
	public static float2 IHIEIGNFOKH(float2 NLEGDNPENLM)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6C25FC0", Offset = "0x6C249C0", VA = "0x186C25FC0")]
	public static float2 LPCMHOJKHFA(float3 JCHGHJIDPLJ)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6C262F0", Offset = "0x6C24CF0", VA = "0x186C262F0")]
	public static void MBFNECHBDAH(float3 IPHMAHBENGI, [Out] float3 OBHMPAEABBC, [Out] uint3 FPMJGOIDMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6C25D50", Offset = "0x6C24750", VA = "0x186C25D50")]
	public static FNOJKOIFMGI DFLODEGDJBC(float3 EJEBFMEPKGF)
	{
		return default(FNOJKOIFMGI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GJDJKPDEHHO
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker JDNHPKNHKNC;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static float IJNONLBAKBK;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void EPECEFLOFOF(bool DMOHAGJNEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A5B0", Offset = "0x6C28FB0", VA = "0x186C2A5B0")]
	public static void PPBKONHLJPI(float OGPPENKCKAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class DIAPMCADDEM
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal enum NCIMOJMCOLO
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct OPDCEJCMILG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public OKOCLBPJOEP LDNHICGPCIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int GKNDDCIKBOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int DBLOKKFAIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public long JDEHPFLLLEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public long OEKIPIOFBOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float NODBODFPAOB;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6C2DA50", Offset = "0x6C2C450", VA = "0x186C2DA50")]
		public void BDNFIJHBNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6C2DA80", Offset = "0x6C2C480", VA = "0x186C2DA80")]
		public void NEECMKACHFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string IMOFKKBKBKB;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly string MENILBKMBFB;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly ProfilerMarker JDNHPKNHKNC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly ProfilerMarker EPAGIPDALMJ;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly ProfilerMarker ILGAFIJHJFM;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly ProfilerMarker LFGGELCNHMC;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly ProfilerMarker PNKHBFEILNK;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly ProfilerMarker ILHALHJMNBD;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly ProfilerMarker FBKFOBACMOD;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly ProfilerMarker KMNMJCPEAAK;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly ProfilerMarker HAEPJFKEDLC;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly ProfilerMarker MKGCOILGFHB;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly ProfilerMarker LILHHGFHHDP;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly ProfilerMarker FKBFGEDIFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly List<LFILPOBKFEH> LFCFJOHJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly DBDJPHJPOCF OJIHIFDIHIL;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public const bool FINLDKDKNNP = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int NHPNPOOIEDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int OCJJKCEPHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool CHOICHNPEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal bool NLMNMLPDNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool NOKDDMJKDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	internal NCIMOJMCOLO PFFGBBPKGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	internal bool GKFHBBEEAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	internal float3 PEENBFDPFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	internal float3 AOMFBOGKBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal float FPEHNOPKIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	internal float LHIHCCABMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	internal int JDJMIMKPLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	internal int MNAIKLONLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int DIDFIGGOALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int MPNBCHEIEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private float NOEJPEDKELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private float EPBBNKMDMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int FIKJJBKICEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long OIKNOCBCAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long DNADICFKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private long KPADBPBPBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public int NDMOKGAOFCK;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private const int JFPFFNIDPHO = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private float[] FOGNBJMCEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int[] NINHKPOCIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long[] CMAIGMKBCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<OPDCEJCMILG> PDGHPOFGKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private CCDNCOACIDM OLCEHAMOKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private long DHNEENGGHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private long CJAADBJBGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int JAIDDBNCAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	internal float AKFBOJFGJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	internal CCDNCOACIDM.MMFBGFODIND CALAEMAEHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool OMGAAONJOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private EIEHGCLLBBO JDHLOJEOOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private JobHandle FHKFHBDJJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	internal NativeArray<long> NMEECIIDHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool IIALGEPLBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private JobHandle EOPLMCCFKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private CCDNCOACIDM HNLCLIDOOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private FCKFJPINFJG ADAEPFGOODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform GJCOBPPBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private BMENCFGGDHJ PEAHLEMKGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private long EOGPHBBLLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private long KPIPHEKBDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long OPJMBHEICPM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	internal Mesh HPOAHBCFCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8892C0", Offset = "0x887CC0", VA = "0x1808892C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MeshFilter EEGHBACBCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x885620", Offset = "0x884020", VA = "0x180885620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshRenderer OOFBFHKIJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x88B260", Offset = "0x889C60", VA = "0x18088B260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<Material> EIPGGDHHKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x889090", Offset = "0x887A90", VA = "0x180889090")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8890B0", Offset = "0x887AB0", VA = "0x1808890B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int PALFOJACOBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x928550", Offset = "0x926F50", VA = "0x180928550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int GABFKHBFIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x124B9E0", Offset = "0x124A3E0", VA = "0x18124B9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int PDIJFBBJBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6C1FBD0", Offset = "0x6C1E5D0", VA = "0x186C1FBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public List<LFILPOBKFEH> PNIDCJCOPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6C20D90", Offset = "0x6C1F790", VA = "0x186C20D90")]
	public void KDEFGHIAEJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6C20A90", Offset = "0x6C1F490", VA = "0x186C20A90")]
	private void KADDFOAAEJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6C25A70", Offset = "0x6C24470", VA = "0x186C25A70")]
	public DIAPMCADDEM(string DDDMPLCOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6C21940", Offset = "0x6C20340", VA = "0x186C21940")]
	public void NEECMKACHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6C23E70", Offset = "0x6C22870", VA = "0x186C23E70")]
	private void PMBLGHCPBMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1ADB0", Offset = "0x6C197B0", VA = "0x186C1ADB0")]
	private void AIGLJMPCBMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F180", Offset = "0x6C1DB80", VA = "0x186C1F180")]
	public Mesh FPLJMCAGFLP(MeshFilter JHNBDIAGEJA, Transform ICGEMCDDICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6C20360", Offset = "0x6C1ED60", VA = "0x186C20360")]
	private void ILELLKPHAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FA70", Offset = "0x6C1E470", VA = "0x186C1FA70")]
	public void GOCPGLDBIPD(LFILPOBKFEH IIEEOIFAMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6C1EC60", Offset = "0x6C1D660", VA = "0x186C1EC60")]
	public bool FFNKDEBAHHN(LFILPOBKFEH IIEEOIFAMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C4A0", Offset = "0x6C1AEA0", VA = "0x186C1C4A0")]
	public bool DDGNJIHOIKG(LFILPOBKFEH IIEEOIFAMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6C23DE0", Offset = "0x6C227E0", VA = "0x186C23DE0", Slot = "4")]
	public virtual void PMBGPBIGCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FBF0", Offset = "0x6C1E5F0", VA = "0x186C1FBF0")]
	public void HNCIDHGDPLM(Transform PAJBIGFDMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FE30", Offset = "0x6C1E830", VA = "0x186C1FE30")]
	private long HPFICBHCMKA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6C1D3D0", Offset = "0x6C1BDD0", VA = "0x186C1D3D0")]
	private long DFDPDDCKGEG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6C1DB20", Offset = "0x6C1C520", VA = "0x186C1DB20")]
	public bool DPMCPMNAPEC(Transform PAJBIGFDMMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C500", Offset = "0x6C1AF00", VA = "0x186C1C500")]
	public bool DECAEHLJFMB(bool AAPHIDJCMAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F270", Offset = "0x6C1DC70", VA = "0x186C1F270")]
	private void GGJONEEFEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6C23F10", Offset = "0x6C22910", VA = "0x186C23F10")]
	public bool PPBKONHLJPI(float4x4 GLKOCMNKMNE, BatchedMeshRenderer EENGIPOJMEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C2C0", Offset = "0x6C1ACC0", VA = "0x186C1C2C0")]
	public void CGDBJJPMAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BF90", Offset = "0x6C1A990", VA = "0x186C1BF90")]
	public bool CEPBOKBCLBI(bool AAPHIDJCMAN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C1EC50", Offset = "0x6C1D650", VA = "0x186C1EC50")]
	public void FACLFJAPMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F150", Offset = "0x6C1DB50", VA = "0x186C1F150")]
	public void FOBPNKFLFBH(CCDNCOACIDM LDNHICGPCIN, int MJCCABJMIKA, int LMACLLFOGFL, float OMGHLIHPJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1D870", Offset = "0x6C1C270", VA = "0x186C1D870")]
	public void DKNBFPIDBNF(OKOCLBPJOEP JACAHIBOHPK, int MJCCABJMIKA, int LMACLLFOGFL, float OMGHLIHPJCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6C205F0", Offset = "0x6C1EFF0", VA = "0x186C205F0")]
	public (long, long, long) IOPMHHCCPGJ()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x92C030", Offset = "0x92AA30", VA = "0x18092C030")]
	public long AIMCDHPIMMB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6C20690", Offset = "0x6C1F090", VA = "0x186C20690")]
	private void JLFECPIEAPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6C22D30", Offset = "0x6C21730", VA = "0x186C22D30")]
	public (long, long) PBAPLBNNBDC(float MCPDBMBGEOL, float4x4 GLKOCMNKMNE)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public void LDGLLPPHLDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6C21820", Offset = "0x6C20220", VA = "0x186C21820")]
	internal void MDCJINFGKEH(NCIMOJMCOLO PKAFPBIKDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6C21A70", Offset = "0x6C20470", VA = "0x186C21A70")]
	private (float, float, float, float) OCEICPPCKMC(float EMFBMDLKMBA, float4x4 GLKOCMNKMNE)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6C22CD0", Offset = "0x6C216D0", VA = "0x186C22CD0")]
	private float OOEJJDEMOJB(float EMFBMDLKMBA, float4x4 GLKOCMNKMNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6C1D530", Offset = "0x6C1BF30", VA = "0x186C1D530")]
	private (int, int) DFLCAMPDKIB(float GMFGACCIMGJ)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AE90", Offset = "0x6C19890", VA = "0x186C1AE90")]
	public void ALKAHICAHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FFF0", Offset = "0x6C1E9F0", VA = "0x186C1FFF0")]
	private void IHGHJBEELEI(CCDNCOACIDM IPGIPHNDGLL, CCDNCOACIDM.MMFBGFODIND MAKDKMCPBAM, bool BKBGHDDFJBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FEF0", Offset = "0x6C1E8F0", VA = "0x186C1FEF0")]
	private void IHGHJBEELEI([In] OKOCLBPJOEP IPGIPHNDGLL, CCDNCOACIDM.MMFBGFODIND MAKDKMCPBAM, bool BKBGHDDFJBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6C20DA0", Offset = "0x6C1F7A0", VA = "0x186C20DA0")]
	private void LKIFDCMGIFF(CCDNCOACIDM.MMFBGFODIND MAKDKMCPBAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6C20660", Offset = "0x6C1F060", VA = "0x186C20660")]
	private void JADBMPLALEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6C20040", Offset = "0x6C1EA40", VA = "0x186C20040")]
	private void IJNPJHNAGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6C22320", Offset = "0x6C20D20", VA = "0x186C22320")]
	public long OKKGDKNNFPO(long FDLPEDDHEIF, int MIHBAENBALM)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6C230C0", Offset = "0x6C21AC0", VA = "0x186C230C0")]
	private void PCBCINMHJEH(CCDNCOACIDM KBGIGEFCPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6C1ECE0", Offset = "0x6C1D6E0", VA = "0x186C1ECE0")]
	private void FOBALJAKIBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BF00", Offset = "0x6C1A900", VA = "0x186C1BF00")]
	private float CBMMJLNNLNK(int ALGJBBFNOJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6C20E40", Offset = "0x6C1F840", VA = "0x186C20E40")]
	private void MCDEJHGOKFH(CCDNCOACIDM LDNHICGPCIN, AECMCNOFGIJ JACAHIBOHPK, int MJCCABJMIKA, int LMACLLFOGFL, float OMGHLIHPJCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct EIEHGCLLBBO : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct PLNKCDIPIMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int LFLHBFFHHNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int IBPONNAKMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int LAMOIJOCKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int LAAFPECJCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int CPPNBFBNEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int HBNOPAMEICE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int GKNDDCIKBOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int DBLOKKFAIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public float NODBODFPAOB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private struct NLGDEFJCPHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public AJIIPBEPPPI.JGBLEICKNMD CNHJKFCBPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float KOMONNFMHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public float ELJJCGNGBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public float HDMBECJEGDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float NCKLCPONEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public float LGDIKHCLKCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public float KGCIIIOAMPD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct FGMMDPNECAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public NativeArray<float3> DBHGOMEALGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NativeArray<float3> CDPAAJHHBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public NativeArray<float4> MNFADFCKGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NativeArray<float4> IIGCPNODIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NativeArray<float2> MPDFFHGOHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NativeArray<int> PCHEEJGAOHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool HEOMIIOEKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int PDIJFBBJBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int DLPMFIBCHFB;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6C2A310", Offset = "0x6C28D10", VA = "0x186C2A310")]
		public void MKPLHMCKEFN(int FBOKOPMOEJK, int AJEDNCMAFDC, Allocator MPFEIGMBFCP, bool EGBKFGBEKKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6C2A0C0", Offset = "0x6C28AC0", VA = "0x186C2A0C0")]
		public static FGMMDPNECAI JDHBBKAPBLL(CCDNCOACIDM EEBGELKKKEJ)
		{
			return default(FGMMDPNECAI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6C2A4F0", Offset = "0x6C28EF0", VA = "0x186C2A4F0")]
		public void NEECMKACHFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly ProfilerMarker EIGNCKJNJFO;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly ProfilerMarker BBBHMKOFIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<PLNKCDIPIMM> OJMCGEOIKOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private FGMMDPNECAI ICDEHGHOGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private FGMMDPNECAI KBGIGEFCPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private float3 NCHOFJIIFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private float3 FIMGHINJEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private NLGDEFJCPHE KOHGKLDHCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* ODHNAJPCKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NativeArray<int> IHFMLEDDGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private NativeArray<bool> BDFBDGLDABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeArray<int> LIIPAMIOMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private NativeArray<int> KMMCONFBODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private NativeArray<float> OCFLKCHGEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeArray<int> PKKPAAFBPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeArray<float> HJEEJOGHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeArray<float> CJFIKPEIPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<int> CDLAHNABKAI;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6C28A10", Offset = "0x6C27410", VA = "0x186C28A10")]
	public EIEHGCLLBBO([In] List<DIAPMCADDEM.OPDCEJCMILG> DMDDIHNPNDC, [In] CCDNCOACIDM LMKEJMCLFCM, [In] DIAPMCADDEM AACCKIOLJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6C27550", Offset = "0x6C25F50", VA = "0x186C27550", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6C26BF0", Offset = "0x6C255F0", VA = "0x186C26BF0")]
	public void CHAJLMDCMGI(List<DIAPMCADDEM.OPDCEJCMILG> NKEDJMMFGMA, [In] DIAPMCADDEM AACCKIOLJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6C28630", Offset = "0x6C27030", VA = "0x186C28630")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool NCEAAGJELEA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6C269C0", Offset = "0x6C253C0", VA = "0x186C269C0")]
	private OKOCLBPJOEP AGFLILJBOOE(int MHHIGMDLJCP, Allocator MPFEIGMBFCP)
	{
		return default(OKOCLBPJOEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6C276A0", Offset = "0x6C260A0", VA = "0x186C276A0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void LCPCANOCFFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6C28650", Offset = "0x6C27050", VA = "0x186C28650")]
	[IgnoreWarning(1371)]
	private PLNKCDIPIMM PAANMAKJNEA([In] PLNKCDIPIMM HHIJDAMCOCM, int NMAFCBGIFMP, [In] NativeArray<int> MBDNPINLOGK, [In] NativeArray<bool> BDFBDGLDABP, NativeArray<int> LIIPAMIOMBI)
	{
		return default(PLNKCDIPIMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6C275A0", Offset = "0x6C25FA0", VA = "0x186C275A0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int HCLKPMHJDDB(NativeArray<int> MBDNPINLOGK, int HNDLLGCKPLJ, int BPPMPOCNENE, int HAHPLMJCLHJ)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly CAFGMNLACIN log;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static readonly ProfilerMarker GPCAMLBGFPD;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private static readonly ProfilerMarker AMFBIHNKBID;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly ProfilerMarker FHBMAAIBIED;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly ProfilerMarker EMPKCEPIGGO;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly ProfilerMarker DAIBHJCNCJH;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static readonly ProfilerMarker PNKHBFEILNK;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private static readonly ProfilerMarker BFPPFDFOMOI;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		internal const int CPOHLHFGEAI = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		internal static Dictionary<Material, List<Material>> ONPJPLLFGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Dictionary<Material, List<DIAPMCADDEM>> LJOMNLHENJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal List<DIAPMCADDEM> BIFOMHNLLLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private List<MeshRenderer> EOBPJJAEFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Transform EGLPOHJGKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private bool OLENKPGJJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private bool AEPFMCEEMHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private int JFLPEBEPLLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private Dictionary<int, float> DDNOBPGPCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Dictionary<int, Color> CGGGDLJKMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Dictionary<int, Vector4> CLHOFDEMBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Dictionary<int, Matrix4x4> KAAHCMJHCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private DIAPMCADDEM MABGHGGEDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private Material MFKFDNLACDM;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private const int FHHFAHMNGHK = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static List<(long, Bounds, LFILPOBKFEH)> JFMGGEOMODG;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<MeshRenderer> LILLJFJLKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int GCDEBHFHMHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6C1AC10", Offset = "0x6C19610", VA = "0x186C1AC10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		private static void ELJFIFFEILA(bool DMOHAGJNEMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		private static void ELJFIFFEILA(bool DMOHAGJNEMP, string BBDGOIMNDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6C17140", Offset = "0x6C15B40", VA = "0x186C17140")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6C14B70", Offset = "0x6C13570", VA = "0x186C14B70")]
		public DIAPMCADDEM AddToBatchedMesh(LFILPOBKFEH FEHLKOOMDHL, Material PPFNGNPGEKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6C19C80", Offset = "0x6C18680", VA = "0x186C19C80")]
		public void RemoveFromBatchedMesh(LFILPOBKFEH LDNHICGPCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6C152E0", Offset = "0x6C13CE0", VA = "0x186C152E0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A4B0", Offset = "0x6C18EB0", VA = "0x186C1A4B0")]
		public void SetMaterialProperty(int MEOOGDKENOH, Color BJCIGJMGMBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A070", Offset = "0x6C18A70", VA = "0x186C1A070")]
		public void SetMaterialProperty(int MEOOGDKENOH, float IPHMAHBENGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A290", Offset = "0x6C18C90", VA = "0x186C1A290")]
		public void SetMaterialProperty(int MEOOGDKENOH, Vector4 DGFOKJOPJFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6C19E10", Offset = "0x6C18810", VA = "0x186C19E10")]
		public void SetMaterialProperty(int MEOOGDKENOH, Matrix4x4 PKEDODFODMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6C16B50", Offset = "0x6C15550", VA = "0x186C16B50")]
		private void NLJLCMJKANN(Renderer DGLLFNJJPBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6C15D80", Offset = "0x6C14780", VA = "0x186C15D80")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6C15D70", Offset = "0x6C14770", VA = "0x186C15D70")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6C15410", Offset = "0x6C13E10", VA = "0x186C15410")]
		private void EHDNPIGKDEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6C16620", Offset = "0x6C15020", VA = "0x186C16620")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6C148D0", Offset = "0x6C132D0", VA = "0x186C148D0")]
		private DIAPMCADDEM AMAHFFNOFIG(LFILPOBKFEH LDNHICGPCIN, Material PPFNGNPGEKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6C15A00", Offset = "0x6C14400", VA = "0x186C15A00")]
		private DIAPMCADDEM EPAJDAFHCEB(Material PPFNGNPGEKG, int BOFJEJOBFPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6C14C70", Offset = "0x6C13670", VA = "0x186C14C70")]
		private DIAPMCADDEM BLCAFIHHADL(Material PPFNGNPGEKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6C16390", Offset = "0x6C14D90", VA = "0x186C16390")]
		private float4x4 KHMELIAGBAB()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6C173A0", Offset = "0x6C15DA0", VA = "0x186C173A0")]
		private List<Material> PIMKJHKCDJF(Material PPFNGNPGEKG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xC49A30", Offset = "0xC48430", VA = "0x180C49A30")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6C16490", Offset = "0x6C14E90", VA = "0x186C16490")]
		public void MarkDirty(LFILPOBKFEH LDNHICGPCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6C16790", Offset = "0x6C15190", VA = "0x186C16790")]
		public (long, long) MemorySizeInBytesForChosenDetail(float MCPDBMBGEOL)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6C189F0", Offset = "0x6C173F0", VA = "0x186C189F0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6C15E20", Offset = "0x6C14820", VA = "0x186C15E20")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6C174C0", Offset = "0x6C15EC0", VA = "0x186C174C0")]
		public void RebatchOptimally(int PFLPCCBMPHC, int OGICBIJAKAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C1A9A0", Offset = "0x6C193A0", VA = "0x186C1A9A0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class NMPEOIDPCDA
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct PPKLHFIMJHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public float FLCNNPBENEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public BatchedMeshRenderer IOHFHAKBPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public DIAPMCADDEM MFNHHBHBGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public long GCIGABICPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public float NDFNEFIENNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public bool NPILHBAHDDG;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class AHCGENKKHBJ : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private int <batchSizeNaughty>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private int <batchSizeNice>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private int <countdownBeforeYield>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xB6AD30", Offset = "0xB69730", VA = "0x180B6AD30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x6C2EB40", Offset = "0x6C2D540", VA = "0x186C2EB40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xCB3850", Offset = "0xCB2250", VA = "0x180CB3850")]
		[DebuggerHidden]
		public AHCGENKKHBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C2EB90", Offset = "0x6C2D590", VA = "0x186C2EB90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6C2DDD0", Offset = "0x6C2C7D0", VA = "0x186C2DDD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6C2DD80", Offset = "0x6C2C780", VA = "0x186C2DD80")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6C2DD30", Offset = "0x6C2C730", VA = "0x186C2DD30")]
		private void EEFNKGAPPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6C2EAF0", Offset = "0x6C2D4F0", VA = "0x186C2EAF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6C2EA40", Offset = "0x6C2D440", VA = "0x186C2EA40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6C2EA40", Offset = "0x6C2D440", VA = "0x186C2EA40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker PNKHBFEILNK;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static readonly ProfilerMarker MDKLKGPOOKE;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly ProfilerMarker NJILONKCBHG;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly ProfilerMarker GBHKIBIFEGE;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static float3 EBHKELEMHOK;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int NFABFHNFGHO;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static int KJIMKDMAIBP;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static int GPNHADEFKOB;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int EKKEDHEAJAC;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int NAPKJKHEPNM;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int CHKJNOMNACO;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long KNGLDFHPHFG;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static long GDCMILFEKHH;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static int ENEPEFCJJPH;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static int JKDIGKDOOFI;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static int JKIPHHLAMME;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static float HJNBFLBGOGI;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static bool GNPGPJDMODO;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public static int HIBAOMICBFL;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static float JJLLJJGEAAE;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static float NINEMPDEOHL;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static float MEKKNMMOJEK;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public static float FFEFOKKPMGA;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public static float HKBIFMAFOLA;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static float JONFPMPKOHE;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float OHJPGFHCAAE;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static float EOKHCGLPIDG;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static long JFOHKPBBMJN;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static bool AMHKPEBLDBH;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static List<BatchedMeshRenderer> PJEELPDLCJD;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static List<PPKLHFIMJHG> KBKBLCLNCMH;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static Stack<CCDNCOACIDM> KPPBIDPJNMN;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static Stack<FCKFJPINFJG> ANJIBCAILPE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool IIOHKPDIKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C30280", Offset = "0x6C2EC80", VA = "0x186C30280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void ELJFIFFEILA(bool DMOHAGJNEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void EPECEFLOFOF(bool DMOHAGJNEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void ELJFIFFEILA(bool DMOHAGJNEMP, string BBDGOIMNDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public static void BDNFIJHBNDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F220", Offset = "0x6C2DC20", VA = "0x186C2F220")]
	public static void DFNGKAAGLOM(BatchedMeshRenderer MAHMLMDMKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FA70", Offset = "0x6C2E470", VA = "0x186C2FA70")]
	public static void JNFECMDJAKJ(BatchedMeshRenderer MAHMLMDMKBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F0A0", Offset = "0x6C2DAA0", VA = "0x186C2F0A0")]
	private static (long, long, long) CGPJCGFKAIC(long OKOJNILHDJO)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C301D0", Offset = "0x6C2EBD0", VA = "0x186C301D0")]
	public static bool MOGBFCJPNGF(float EGOHPOLCJAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F1B0", Offset = "0x6C2DBB0", VA = "0x186C2F1B0")]
	public static void CJMJNEGJGFP(float EGOHPOLCJAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6C2EF90", Offset = "0x6C2D990", VA = "0x186C2EF90")]
	public static bool BJMNMLOHNPD(float EGOHPOLCJAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C30BE0", Offset = "0x6C2F5E0", VA = "0x186C30BE0")]
	public static void PPBKONHLJPI(long OKOJNILHDJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C30680", Offset = "0x6C2F080", VA = "0x186C30680")]
	public static long OKKGDKNNFPO(long FDLPEDDHEIF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FE20", Offset = "0x6C2E820", VA = "0x186C2FE20")]
	public static void LBFIKIGPBAG(DIAPMCADDEM MFNHHBHBGML, BatchedMeshRenderer IOHFHAKBPFA, long GCIGABICPIF, float FLCNNPBENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F380", Offset = "0x6C2DD80", VA = "0x186C2F380")]
	public static void EIACFMNEDMF(DIAPMCADDEM MFNHHBHBGML, BatchedMeshRenderer IOHFHAKBPFA, long GCIGABICPIF, float OGPPENKCKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FF60", Offset = "0x6C2E960", VA = "0x186C2FF60")]
	public static void MBOGNMPILEE(DIAPMCADDEM MFNHHBHBGML, BatchedMeshRenderer IOHFHAKBPFA, long GCIGABICPIF, float OGPPENKCKAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C30310", Offset = "0x6C2ED10", VA = "0x186C30310")]
	public static void NNIOIFENNBG(DIAPMCADDEM MFNHHBHBGML, BatchedMeshRenderer IOHFHAKBPFA, long GCIGABICPIF, float BKKAKHPPBJB, bool NPILHBAHDDG, float FLCNNPBENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F690", Offset = "0x6C2E090", VA = "0x186C2F690")]
	public static float JIPONBINJCI(long DAPMHLGCOIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C30A10", Offset = "0x6C2F410", VA = "0x186C30A10")]
	public static (long, long) PBAPLBNNBDC(float MCPDBMBGEOL)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F4B0", Offset = "0x6C2DEB0", VA = "0x186C2F4B0")]
	[IteratorStateMachine(typeof(AHCGENKKHBJ))]
	public static IEnumerable<bool> HANEGNGKFNK(long NCOELCJKPOP, bool DKCCKIONDKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2ECB0", Offset = "0x6C2D6B0", VA = "0x186C2ECB0")]
	public static void AOKHCGINLAD(long NCOELCJKPOP, bool DKCCKIONDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C30090", Offset = "0x6C2EA90", VA = "0x186C30090")]
	public static int MJINFLEFFML()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6C30530", Offset = "0x6C2EF30", VA = "0x186C30530")]
	internal static CCDNCOACIDM OFOAGJMAGEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C2EF00", Offset = "0x6C2D900", VA = "0x186C2EF00")]
	internal static void BBCNACECAJF(CCDNCOACIDM CNJJENBJDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F540", Offset = "0x6C2DF40", VA = "0x186C2F540")]
	internal static FCKFJPINFJG INDOKHPPCPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C2EE70", Offset = "0x6C2D870", VA = "0x186C2EE70")]
	internal static void BBCNACECAJF(FCKFJPINFJG CABEFGAIAIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class NOJJNEBIABE<KeyType> : DIAPMCADDEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly Dictionary<KeyType, LFILPOBKFEH> PMHOIHOFGFH;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x47FC150", Offset = "0x47FAB50", VA = "0x1847FC150")]
	public NOJJNEBIABE(string DDDMPLCOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x47FBF80", Offset = "0x47FA980", VA = "0x1847FBF80")]
	public void GOCPGLDBIPD(KeyType COMNIKKFEEB, LFILPOBKFEH IIEEOIFAMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x47FBCF0", Offset = "0x47FA6F0", VA = "0x1847FBCF0")]
	public bool AFPNLCOOMKO(KeyType COMNIKKFEEB, LFILPOBKFEH EFILFANEFEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x47FBDE0", Offset = "0x47FA7E0", VA = "0x1847FBDE0")]
	public void DEGPBDIIBAO(KeyType COMNIKKFEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x47FBFF0", Offset = "0x47FA9F0", VA = "0x1847FBFF0", Slot = "4")]
	public override void PMBGPBIGCKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C338E0", Offset = "0x6C322E0", VA = "0x186C338E0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
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
