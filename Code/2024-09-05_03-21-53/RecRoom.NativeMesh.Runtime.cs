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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
	public class LogRegistrationIndex : JOPFPPBONLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C520", Offset = "0x6C1AF20", VA = "0x186C1C520", Slot = "4")]
		public override void HEDMFNKAECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class DFJHDCFLJLG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly ANDGIEDMMDP IDDBKHDIKHA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly ANDGIEDMMDP LLCAOKFFDBH;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly ANDGIEDMMDP LNGPGBMKNJH;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class IAGKBAHGCJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public PFOHDIHLFKM GBMMOFEFFOL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NBBEBMFLJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public IAGKBAHGCJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PFOHDIHLFKM
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct BDGBMNOMHGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public half JKFEDNBMOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ushort JKAGCLIHECC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public byte PDFJEBFOPLO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ProfilerMarker EJLNPPHNGIC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ProfilerMarker KAGPIGNCAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int NBBEBMFLJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int AAFJIHGKCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public NativeArray<ushort> OLPJKPFHNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<ushort> LABFLHMCLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> IIHDJPGJDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> EPPHMIIOHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<BDGBMNOMHGM> ELCLOMHBFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<byte> PGOGEEKPNDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<byte> KMBCFLOJGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float3 HPCFENALIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float3 FPLKJLDMGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float2 HLOKNNLIMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float2 IAODJOBPBOG;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static long DMNPMMNPPBF;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static long MNFKGOKGIAP;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static float DICKKHDKHDC;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static bool HGBEKJAIHHO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool OFKDLHJCMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C25570", Offset = "0x6C23F70", VA = "0x186C25570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AMDHIANOJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6C1E060", Offset = "0x6C1CA60", VA = "0x186C1E060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C23820", Offset = "0x6C22220", VA = "0x186C23820")]
	public void LCECLFEFOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C20A00", Offset = "0x6C1F400", VA = "0x186C20A00")]
	public static PFOHDIHLFKM IFAFEFDLIPC(Allocator MDICAPEDFAK, LCFLAENFPKH KBKMOJHPPCD)
	{
		return default(PFOHDIHLFKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C20440", Offset = "0x6C1EE40", VA = "0x186C20440")]
	public static PFOHDIHLFKM IFAFEFDLIPC(Allocator MDICAPEDFAK, NativeArray<float3> DGOFNOKMDPC, NativeArray<float3> AKEEMMFMAJP, NativeArray<float2> BGBKIENJFEA, NativeArray<float4> KNKNMIHHKJB, bool GLEBCFKHOJG, NativeArray<float4> KBDDHLGDLOJ, NativeArray<int> MCKKPPDGMCI, int NBBEBMFLJHD, int JELGMAAMIHL, int AAFJIHGKCMC, int LLLMPDMDDPL)
	{
		return default(PFOHDIHLFKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C21700", Offset = "0x6C20100", VA = "0x186C21700")]
	public LCFLAENFPKH IKLCDDNNMNM(Allocator MDICAPEDFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6C24240", Offset = "0x6C22C40", VA = "0x186C24240")]
	public void MKJOHNKBEAJ(Mesh ANBKEJJPIHH, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FCD0", Offset = "0x6C1E6D0", VA = "0x186C1FCD0")]
	private void GOCNPBIMMOF(Mesh ANBKEJJPIHH, NativeArray<ushort> CKNCNJKNGEB, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C1D010", Offset = "0x6C1BA10", VA = "0x186C1D010")]
	public void AGFDPLMOAEF(Mesh ANBKEJJPIHH, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C228B0", Offset = "0x6C212B0", VA = "0x186C228B0")]
	public void KDLBOANJEFF(Mesh ANBKEJJPIHH, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C21A30", Offset = "0x6C20430", VA = "0x186C21A30")]
	public void INFJJHJIDOD(Mesh ANBKEJJPIHH, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C20CD0", Offset = "0x6C1F6D0", VA = "0x186C20CD0")]
	public void IFECLABEGGB(Mesh ANBKEJJPIHH, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C24360", Offset = "0x6C22D60", VA = "0x186C24360")]
	public void MNPECIKBIPD(Mesh ANBKEJJPIHH, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C1E270", Offset = "0x6C1CC70", VA = "0x186C1E270")]
	public void CGMDCKEMCIB(Mesh ANBKEJJPIHH, LCFLAENFPKH.FLJIGNHDJHO CJLNMCEFAGN, bool ACKFNEELKFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F8D0", Offset = "0x6C1E2D0", VA = "0x186C1F8D0")]
	public long GGINLMHBMBB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C23940", Offset = "0x6C22340", VA = "0x186C23940")]
	public long MBIKFIEDAMC(LCFLAENFPKH.FLJIGNHDJHO CJLNMCEFAGN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C22400", Offset = "0x6C20E00", VA = "0x186C22400")]
	private void JAKKOBEPFMA(int FCPKPFBGPNI, int OJDOODEMIJC, Allocator MDICAPEDFAK, bool EOONNEJNAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C1ED10", Offset = "0x6C1D710", VA = "0x186C1ED10")]
	private void EDEOEGODNEM(NativeArray<float3> BNKEIAEBHIG, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C0B890", Offset = "0x6C0A290", VA = "0x186C0B890")]
	[BurstCompile]
	private unsafe static void EDEOEGODNEM([NoAlias] float3* BNKEIAEBHIG, [In][NoAlias] ushort* DGOFNOKMDPC, int NBBEBMFLJHD, [In] float3 HPCFENALIMJ, [In] float3 FPLKJLDMGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1EA20", Offset = "0x6C1D420", VA = "0x186C1EA20")]
	[BurstCompile]
	private unsafe static void DCJHGBEHDEJ([NoAlias] LCFLAENFPKH.JDKFLICGFGK* BNKEIAEBHIG, [In][NoAlias] ushort* DGOFNOKMDPC, int NBBEBMFLJHD, [In] float3 HPCFENALIMJ, [In] float3 FPLKJLDMGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C20380", Offset = "0x6C1ED80", VA = "0x186C20380")]
	[BurstCompile]
	private unsafe static void IDBJAMCKMDD([NoAlias] LCFLAENFPKH.BDOHLCHFOLI* BNKEIAEBHIG, [In][NoAlias] ushort* DGOFNOKMDPC, int NBBEBMFLJHD, [In] float3 HPCFENALIMJ, [In] float3 FPLKJLDMGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C233E0", Offset = "0x6C21DE0", VA = "0x186C233E0")]
	[BurstCompile]
	private unsafe static void KIJNGAKHCLG([NoAlias] LCFLAENFPKH.EACBGGPNICB* BNKEIAEBHIG, [In][NoAlias] ushort* DGOFNOKMDPC, int NBBEBMFLJHD, [In] float3 HPCFENALIMJ, [In] float3 FPLKJLDMGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C233E0", Offset = "0x6C21DE0", VA = "0x186C233E0")]
	[BurstCompile]
	private unsafe static void NLIGGENKKBG([NoAlias] LCFLAENFPKH.DDNPPOBHHAM* BNKEIAEBHIG, [In][NoAlias] ushort* DGOFNOKMDPC, int NBBEBMFLJHD, [In] float3 HPCFENALIMJ, [In] float3 FPLKJLDMGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1EF60", Offset = "0x6C1D960", VA = "0x186C1EF60")]
	[BurstCompile]
	private unsafe static void ENFGPFKDNEK([NoAlias] LCFLAENFPKH.NHAJLFNBEAM* BNKEIAEBHIG, [In][NoAlias] ushort* DGOFNOKMDPC, int NBBEBMFLJHD, [In] float3 HPCFENALIMJ, [In] float3 FPLKJLDMGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C24150", Offset = "0x6C22B50", VA = "0x186C24150")]
	private void MJOHFKJIBOF(NativeArray<float3> DGOFNOKMDPC, int LLLMPDMDDPL, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C0BAE0", Offset = "0x6C0A4E0", VA = "0x186C0BAE0")]
	[BurstCompile]
	private unsafe static void MJOHFKJIBOF([NoAlias] ushort* BNKEIAEBHIG, [Out] float3 HDELEINBFAM, [Out] float3 FPLKJLDMGEO, [In][NoAlias] float3* DGOFNOKMDPC, int LLLMPDMDDPL, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C1DCA0", Offset = "0x6C1C6A0", VA = "0x186C1DCA0")]
	private void BEKAMGJGPGI(NativeArray<float3> AKEEMMFMAJP, int LLLMPDMDDPL, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C1D9E0", Offset = "0x6C1C3E0", VA = "0x186C1D9E0")]
	[BurstCompile]
	private unsafe static void BEKAMGJGPGI([NoAlias] ushort* FLMGNIHIADE, [In][NoAlias] float3* AKEEMMFMAJP, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C26140", Offset = "0x6C24B40", VA = "0x186C26140")]
	private void PFGAHBOOADE(NativeArray<float3> KDPBMJHGILA, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C26200", Offset = "0x6C24C00", VA = "0x186C26200")]
	[BurstCompile]
	private unsafe static void PFGAHBOOADE([NoAlias] float3* KDPBMJHGILA, [In][NoAlias] ushort* AKEEMMFMAJP, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C1EAE0", Offset = "0x6C1D4E0", VA = "0x186C1EAE0")]
	[BurstCompile]
	private unsafe static void DHCEBHKGOED([NoAlias] LCFLAENFPKH.JDKFLICGFGK* BNKEIAEBHIG, [In][NoAlias] ushort* AKEEMMFMAJP, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6C25270", Offset = "0x6C23C70", VA = "0x186C25270")]
	[BurstCompile]
	private unsafe static void NBLIPDJHOFA([NoAlias] LCFLAENFPKH.BDOHLCHFOLI* BNKEIAEBHIG, [In][NoAlias] ushort* AKEEMMFMAJP, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C236E0", Offset = "0x6C220E0", VA = "0x186C236E0")]
	[BurstCompile]
	private unsafe static void KLHJPEGLKBJ([NoAlias] LCFLAENFPKH.EACBGGPNICB* BNKEIAEBHIG, [In][NoAlias] ushort* AKEEMMFMAJP, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C22530", Offset = "0x6C20F30", VA = "0x186C22530")]
	[BurstCompile]
	private unsafe static void JHHBGBGNABD([NoAlias] LCFLAENFPKH.DDNPPOBHHAM* BNKEIAEBHIG, [In][NoAlias] ushort* AKEEMMFMAJP, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C1EE00", Offset = "0x6C1D800", VA = "0x186C1EE00")]
	[BurstCompile]
	private unsafe static void EFKOIHFCKGJ([NoAlias] LCFLAENFPKH.NHAJLFNBEAM* BNKEIAEBHIG, [In][NoAlias] ushort* AKEEMMFMAJP, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C26050", Offset = "0x6C24A50", VA = "0x186C26050")]
	private void OOKKLDJCGJN(NativeArray<float2> BGBKIENJFEA, int LLLMPDMDDPL, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6C25D90", Offset = "0x6C24790", VA = "0x186C25D90")]
	[BurstCompile]
	private unsafe static void OOKKLDJCGJN([NoAlias] ushort* KCLOMHABLAB, [Out] float2 GHDEACEAAPD, [Out] float2 IAODJOBPBOG, [In][NoAlias] float2* BGBKIENJFEA, int LLLMPDMDDPL, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C20330", Offset = "0x6C1ED30", VA = "0x186C20330")]
	[BurstCompile]
	private static void HNAKGJMHOAE([Out] float2 LDCBGOKEGEN, ushort ENODEMAJHPL, [In] float2 HLOKNNLIMHC, [In] float2 IAODJOBPBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6C200E0", Offset = "0x6C1EAE0", VA = "0x186C200E0")]
	private void HLEECBHINFC(NativeArray<float2> KCLOMHABLAB, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C20250", Offset = "0x6C1EC50", VA = "0x186C20250")]
	[BurstCompile]
	private unsafe static void HLEECBHINFC([NoAlias] float2* KCLOMHABLAB, [NoAlias] ushort* BGBKIENJFEA, int NBBEBMFLJHD, [In] float2 HLOKNNLIMHC, [In] float2 IAODJOBPBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FBD0", Offset = "0x6C1E5D0", VA = "0x186C1FBD0")]
	[BurstCompile]
	private unsafe static void GOBKBNINGCC([NoAlias] LCFLAENFPKH.JDKFLICGFGK* BNKEIAEBHIG, [NoAlias] ushort* BGBKIENJFEA, int NBBEBMFLJHD, [In] float2 HLOKNNLIMHC, [In] float2 IAODJOBPBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C26520", Offset = "0x6C24F20", VA = "0x186C26520")]
	[BurstCompile]
	private unsafe static void PKGMJBDJCJJ([NoAlias] LCFLAENFPKH.BDOHLCHFOLI* BNKEIAEBHIG, [NoAlias] ushort* BGBKIENJFEA, int NBBEBMFLJHD, [In] float2 HLOKNNLIMHC, [In] float2 IAODJOBPBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6C25920", Offset = "0x6C24320", VA = "0x186C25920")]
	[BurstCompile]
	private unsafe static void OGGPEPPHJKC([NoAlias] LCFLAENFPKH.EACBGGPNICB* BNKEIAEBHIG, [NoAlias] ushort* BGBKIENJFEA, int NBBEBMFLJHD, [In] float2 HLOKNNLIMHC, [In] float2 IAODJOBPBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6C26420", Offset = "0x6C24E20", VA = "0x186C26420")]
	[BurstCompile]
	private unsafe static void PGPIJOFPCJM([NoAlias] LCFLAENFPKH.DDNPPOBHHAM* BNKEIAEBHIG, [NoAlias] ushort* BGBKIENJFEA, int NBBEBMFLJHD, [In] float2 HLOKNNLIMHC, [In] float2 IAODJOBPBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C1DF60", Offset = "0x6C1C960", VA = "0x186C1DF60")]
	[BurstCompile]
	private unsafe static void CCFOONNEKKO([NoAlias] LCFLAENFPKH.NHAJLFNBEAM* BNKEIAEBHIG, [NoAlias] ushort* BGBKIENJFEA, int NBBEBMFLJHD, [In] float2 HLOKNNLIMHC, [In] float2 IAODJOBPBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C25770", Offset = "0x6C24170", VA = "0x186C25770")]
	private void ODLPDPOFIAB(NativeArray<float4> KBDDHLGDLOJ, int LLLMPDMDDPL, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C25650", Offset = "0x6C24050", VA = "0x186C25650")]
	[BurstCompile]
	private unsafe static void ODLPDPOFIAB([NoAlias] ushort* GLMEOJJIDLO, [In][NoAlias] float4* DKGIAIAFBEM, int LLLMPDMDDPL, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C26620", Offset = "0x6C25020", VA = "0x186C26620")]
	[BurstCompile]
	private static ushort PLOOIOCIPFK([In] float4 JODJFCCHPKB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6C25B10", Offset = "0x6C24510", VA = "0x186C25B10")]
	private void OHHHOLBCNLN(NativeArray<float4> GLMEOJJIDLO, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6C25C40", Offset = "0x6C24640", VA = "0x186C25C40")]
	[BurstCompile]
	private unsafe static void OHHHOLBCNLN([NoAlias] float4* GLMEOJJIDLO, [In][NoAlias] ushort* KBDDHLGDLOJ, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F3E0", Offset = "0x6C1DDE0", VA = "0x186C1F3E0")]
	[BurstCompile]
	private unsafe static void EPAMOCIHHLO([NoAlias] LCFLAENFPKH.JDKFLICGFGK* BNKEIAEBHIG, [In][NoAlias] ushort* KBDDHLGDLOJ, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1E0A0", Offset = "0x6C1CAA0", VA = "0x186C1E0A0")]
	[BurstCompile]
	private unsafe static void CFJKLJKBENI([NoAlias] LCFLAENFPKH.BDOHLCHFOLI* BNKEIAEBHIG, [In][NoAlias] ushort* KBDDHLGDLOJ, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1D820", Offset = "0x6C1C220", VA = "0x186C1D820")]
	[BurstCompile]
	private unsafe static void BCHPECMMNBM([NoAlias] LCFLAENFPKH.EACBGGPNICB* BNKEIAEBHIG, [In][NoAlias] ushort* KBDDHLGDLOJ, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C22680", Offset = "0x6C21080", VA = "0x186C22680")]
	[BurstCompile]
	private unsafe static void KANJDBGKMDJ([NoAlias] LCFLAENFPKH.DDNPPOBHHAM* BNKEIAEBHIG, [In][NoAlias] ushort* KBDDHLGDLOJ, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C1E7F0", Offset = "0x6C1D1F0", VA = "0x186C1E7F0")]
	[BurstCompile]
	private unsafe static void CIHOLHMMNPO([NoAlias] LCFLAENFPKH.NHAJLFNBEAM* BNKEIAEBHIG, [In][NoAlias] ushort* KBDDHLGDLOJ, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6C23320", Offset = "0x6C21D20", VA = "0x186C23320")]
	[BurstCompile]
	private static void KEIHHBANDAD([Out] float4 DFEFBOIIPKP, ushort ENODEMAJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6C23B70", Offset = "0x6C22570", VA = "0x186C23B70")]
	private void MDFNLECOMDP(Allocator MDICAPEDFAK, NativeArray<float4> KNKNMIHHKJB, int LLLMPDMDDPL, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C239B0", Offset = "0x6C223B0", VA = "0x186C239B0")]
	[BurstCompile]
	private unsafe static void MDFNLECOMDP([NoAlias] float4* FBCJGNNICBJ, [NoAlias] byte* CPNMGBCKHOO, [Out] int KCDIAOMCCLF, [Out] int FIEGAGHHMGP, [NoAlias] float4* KNKNMIHHKJB, int LLLMPDMDDPL, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F200", Offset = "0x6C1DC00", VA = "0x186C1F200")]
	private static void EOFAHCAEFIF(NativeArray<float4> GBPHLIOMILM, NativeArray<BDGBMNOMHGM> BOKMODFGJLK, NativeArray<byte> LKGFCDDHPFM, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F0C0", Offset = "0x6C1DAC0", VA = "0x186C1F0C0")]
	[BurstCompile]
	private unsafe static void EOFAHCAEFIF([NoAlias] float4* GBPHLIOMILM, [In][NoAlias] BDGBMNOMHGM* BOKMODFGJLK, [In][NoAlias] byte* LKGFCDDHPFM, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F6F0", Offset = "0x6C1E0F0", VA = "0x186C1F6F0")]
	[BurstCompile]
	private unsafe static void GCGCBHOAFNE([NoAlias] LCFLAENFPKH.JDKFLICGFGK* BNKEIAEBHIG, [In][NoAlias] BDGBMNOMHGM* BOKMODFGJLK, [In][NoAlias] byte* LKGFCDDHPFM, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C23F70", Offset = "0x6C22970", VA = "0x186C23F70")]
	[BurstCompile]
	private unsafe static void MJLKFCAGHDL([NoAlias] LCFLAENFPKH.BDOHLCHFOLI* BNKEIAEBHIG, [In][NoAlias] BDGBMNOMHGM* BOKMODFGJLK, [In][NoAlias] byte* LKGFCDDHPFM, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C1DD80", Offset = "0x6C1C780", VA = "0x186C1DD80")]
	[BurstCompile]
	private unsafe static void BFOOOGHNLPE([NoAlias] LCFLAENFPKH.EACBGGPNICB* BNKEIAEBHIG, [In][NoAlias] BDGBMNOMHGM* BOKMODFGJLK, [In][NoAlias] byte* LKGFCDDHPFM, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F990", Offset = "0x6C1E390", VA = "0x186C1F990")]
	[BurstCompile]
	private unsafe static void GKPFHCJPOME([NoAlias] LCFLAENFPKH.DDNPPOBHHAM* BNKEIAEBHIG, [In][NoAlias] BDGBMNOMHGM* BOKMODFGJLK, [In][NoAlias] byte* LKGFCDDHPFM, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C234A0", Offset = "0x6C21EA0", VA = "0x186C234A0")]
	[BurstCompile]
	private unsafe static void KJFHCBIJNMN([NoAlias] LCFLAENFPKH.NHAJLFNBEAM* BNKEIAEBHIG, [In][NoAlias] BDGBMNOMHGM* BOKMODFGJLK, [In][NoAlias] byte* LKGFCDDHPFM, int NBBEBMFLJHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C21600", Offset = "0x6C20000", VA = "0x186C21600")]
	private void IGMPLDGCACL(Allocator MDICAPEDFAK, NativeArray<int> MCKKPPDGMCI, int LLLMPDMDDPL, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C24E40", Offset = "0x6C23840", VA = "0x186C24E40")]
	private static NativeArray<byte> NAHJADMJOKC(Allocator MDICAPEDFAK, NativeArray<int> MCKKPPDGMCI, int OLPAMJCOINA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C25170", Offset = "0x6C23B70", VA = "0x186C25170")]
	[BurstCompile]
	private unsafe static int NAHJADMJOKC([NoAlias] byte* HDCFCEBBKGI, [In][NoAlias] int* MCKKPPDGMCI, int OLPAMJCOINA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C253B0", Offset = "0x6C23DB0", VA = "0x186C253B0")]
	private static void NKFANBFFEKK(NativeArray<int> BFCGLPDIBAI, NativeArray<byte> KNEGEBDINAG, int AAFJIHGKCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C254D0", Offset = "0x6C23ED0", VA = "0x186C254D0")]
	[BurstCompile]
	private unsafe static void NKFANBFFEKK([NoAlias] int* BFCGLPDIBAI, [In][NoAlias] byte* KNEGEBDINAG, int AAFJIHGKCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C255B0", Offset = "0x6C23FB0", VA = "0x186C255B0")]
	[BurstCompile]
	private unsafe static void ODALEDADKJJ([NoAlias] ushort* BFCGLPDIBAI, [In][NoAlias] byte* KNEGEBDINAG, int AAFJIHGKCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C24D00", Offset = "0x6C23700", VA = "0x186C24D00")]
	[BurstCompile]
	private static void MPKOPECPAFC([Out] float3 LDCBGOKEGEN, ushort ENODEMAJHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C1FF20", Offset = "0x6C1E920", VA = "0x186C1FF20")]
	[BurstCompile]
	private static ushort HIONMJKMHBF([In] float3 JODJFCCHPKB)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BurstCompile]
public class LCFLAENFPKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum FLJIGNHDJHO
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
	public enum BHJMHCGBPHK
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
	public struct COLKBAKDFLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public FLJIGNHDJHO CJLNMCEFAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool NOIGIJHDIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int MFKMHHMMEAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public VertexAttributeDescriptor[] PHLFKHCDPPC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[BurstCompile]
	public struct KGPCMDCOBHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3 BJDHDJCINFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float3 BELBOBCMBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float4 PMGHDGKDGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float2 FPACFIJBACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float4 ELCLOMHBFPK;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly VertexAttributeDescriptor[] PHLFKHCDPPC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[BurstCompile]
	public struct JDKFLICGFGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float3 BJDHDJCINFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half4 BELBOBCMBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half4 PMGHDGKDGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float2 FPACFIJBACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 ELCLOMHBFPK;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly VertexAttributeDescriptor[] PHLFKHCDPPC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[BurstCompile]
	public struct BDOHLCHFOLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float3 BJDHDJCINFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public uint BELBOBCMBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public uint PMGHDGKDGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float2 FPACFIJBACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half4 ELCLOMHBFPK;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly VertexAttributeDescriptor[] PHLFKHCDPPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[BurstCompile]
	public struct EACBGGPNICB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float3 BJDHDJCINFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public uint BELBOBCMBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public uint PMGHDGKDGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 FPACFIJBACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 ELCLOMHBFPK;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly VertexAttributeDescriptor[] PHLFKHCDPPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[BurstCompile]
	public struct DDNPPOBHHAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float3 BJDHDJCINFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public uint AAIMPLPGKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float2 FPACFIJBACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public uint ODGEKMAJHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public uint HHKFEHPNJLO;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly VertexAttributeDescriptor[] PHLFKHCDPPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile]
	public struct NHAJLFNBEAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public LEPGKMBNDJG.GGLCONKFOLM KFFDBKOCOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint AAIMPLPGKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float2 FPACFIJBACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public uint ODGEKMAJHJE;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly VertexAttributeDescriptor[] PHLFKHCDPPC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int PBGDHEMDCOD(float ICJCFEHCALD);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class EAOHDLDHINN
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr OHHMLJADHDB;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr OJOBLLOMJJA;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D010", Offset = "0x6C0BA10", VA = "0x186C0D010")]
		[BurstDiscard]
		private static void MFOHNJBPBPH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CEC0", Offset = "0x6C0B8C0", VA = "0x186C0CEC0")]
		private static IntPtr LCGPANINANG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0CE20", Offset = "0x6C0B820", VA = "0x186C0CE20")]
		public static void KDCHDLNBOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D130", Offset = "0x6C0BB30", VA = "0x186C0D130")]
		public static int NPIHGHHDKCM(float ICJCFEHCALD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate uint HEFPHNBJCFG([In] float4 OEHMKJHGMIJ);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class PKCIPCEPPDN
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr OHHMLJADHDB;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr OJOBLLOMJJA;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6C26B70", Offset = "0x6C25570", VA = "0x186C26B70")]
		[BurstDiscard]
		private static void MFOHNJBPBPH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6C26A20", Offset = "0x6C25420", VA = "0x186C26A20")]
		private static IntPtr LCGPANINANG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6C26980", Offset = "0x6C25380", VA = "0x186C26980")]
		public static void KDCHDLNBOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6C26C90", Offset = "0x6C25690", VA = "0x186C26C90")]
		public static uint NPIHGHHDKCM([In] float4 OEHMKJHGMIJ)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate uint PFGHLELFJIK([In] float3 OEHMKJHGMIJ);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class GAGHIHMFDNH
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr OHHMLJADHDB;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr OJOBLLOMJJA;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F4E0", Offset = "0x6C0DEE0", VA = "0x186C0F4E0")]
		[BurstDiscard]
		private static void MFOHNJBPBPH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F390", Offset = "0x6C0DD90", VA = "0x186C0F390")]
		private static IntPtr LCGPANINANG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F2F0", Offset = "0x6C0DCF0", VA = "0x186C0F2F0")]
		public static void KDCHDLNBOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6C0F600", Offset = "0x6C0E000", VA = "0x186C0F600")]
		public static uint NPIHGHHDKCM([In] float3 OEHMKJHGMIJ)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void DDPOOELMCKJ([NoAlias] BDOHLCHFOLI* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class MJGJHKLALBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr OHHMLJADHDB;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr OJOBLLOMJJA;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C930", Offset = "0x6C1B330", VA = "0x186C1C930")]
		[BurstDiscard]
		private static void MFOHNJBPBPH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C7E0", Offset = "0x6C1B1E0", VA = "0x186C1C7E0")]
		private static IntPtr LCGPANINANG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6C1C740", Offset = "0x6C1B140", VA = "0x186C1C740")]
		public static void KDCHDLNBOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6C1CA50", Offset = "0x6C1B450", VA = "0x186C1CA50")]
		public unsafe static void NPIHGHHDKCM([NoAlias] BDOHLCHFOLI* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void LBEAMJKPCFM([NoAlias] EACBGGPNICB* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class HJMPKGPIHKK
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr OHHMLJADHDB;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr OJOBLLOMJJA;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6C13670", Offset = "0x6C12070", VA = "0x186C13670")]
		[BurstDiscard]
		private static void MFOHNJBPBPH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C13520", Offset = "0x6C11F20", VA = "0x186C13520")]
		private static IntPtr LCGPANINANG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C13480", Offset = "0x6C11E80", VA = "0x186C13480")]
		public static void KDCHDLNBOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C13790", Offset = "0x6C12190", VA = "0x186C13790")]
		public unsafe static void NPIHGHHDKCM([NoAlias] EACBGGPNICB* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void DAONPBAAPKG([NoAlias] DDNPPOBHHAM* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class FIFEJFGANBH
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr OHHMLJADHDB;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr OJOBLLOMJJA;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EDF0", Offset = "0x6C0D7F0", VA = "0x186C0EDF0")]
		[BurstDiscard]
		private static void MFOHNJBPBPH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C0ECA0", Offset = "0x6C0D6A0", VA = "0x186C0ECA0")]
		private static IntPtr LCGPANINANG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EC00", Offset = "0x6C0D600", VA = "0x186C0EC00")]
		public static void KDCHDLNBOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6C0EF10", Offset = "0x6C0D910", VA = "0x186C0EF10")]
		public unsafe static void NPIHGHHDKCM([NoAlias] DDNPPOBHHAM* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void CABDPELDIPJ([NoAlias] NHAJLFNBEAM* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK, [Out] float3 KIMAPIPLIKB, [Out] float3 BNAGCMNPCHK);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class HNDBFHDCHAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr OHHMLJADHDB;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr OJOBLLOMJJA;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C13BB0", Offset = "0x6C125B0", VA = "0x186C13BB0")]
		[BurstDiscard]
		private static void MFOHNJBPBPH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6C13A60", Offset = "0x6C12460", VA = "0x186C13A60")]
		private static IntPtr LCGPANINANG()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C139C0", Offset = "0x6C123C0", VA = "0x186C139C0")]
		public static void KDCHDLNBOJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public static void PCEEADECCDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6C13CD0", Offset = "0x6C126D0", VA = "0x186C13CD0")]
		public unsafe static void NPIHGHHDKCM([NoAlias] NHAJLFNBEAM* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK, [Out] float3 KIMAPIPLIKB, [Out] float3 BNAGCMNPCHK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int FNHBEPJIKOF = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeList<float3> NDLNDMFKHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<float3> MFKMBOLEIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<float4> IIAFPDJDOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<float4> KDEHMNMLGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<float2> AIHJGKCDNEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeList<int> CJJKKOBBKMP;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly VertexAttributeDescriptor[][] BAOGLEALDKB;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static bool MNLKLMLEODN;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static COLKBAKDFLJ[] IPJKHHOLIGC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OFKDLHJCMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C1BFD0", Offset = "0x6C1A9D0", VA = "0x186C1BFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KGFCHDECLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C1B000", Offset = "0x6C19A00", VA = "0x186C1B000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CDFMPOLKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C17CA0", Offset = "0x6C166A0", VA = "0x186C17CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool AMDHIANOJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6C17880", Offset = "0x6C16280", VA = "0x186C17880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C19500", Offset = "0x6C17F00", VA = "0x186C19500")]
	public static BHJMHCGBPHK JAICAKEBPOP(FLJIGNHDJHO CJLNMCEFAGN)
	{
		return default(BHJMHCGBPHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A8E0", Offset = "0x6C192E0", VA = "0x186C1A8E0")]
	public static void KFAALNJEIDJ(BHJMHCGBPHK HBKFMGGGDOD, Material MLMFHAHBCEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6C17A30", Offset = "0x6C16430", VA = "0x186C17A30", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6C19550", Offset = "0x6C17F50", VA = "0x186C19550")]
	public void JAKKOBEPFMA(int FCPKPFBGPNI, int OJDOODEMIJC, Allocator MDICAPEDFAK, bool LILCFCHMCID, bool EOONNEJNAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C19EA0", Offset = "0x6C188A0", VA = "0x186C19EA0")]
	public void JKEMDMFBOJO(int FCPKPFBGPNI, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C100", Offset = "0x6C1AB00", VA = "0x186C1C100", Slot = "6")]
	public bool ONAINNEJBEA(Mesh ANBKEJJPIHH, bool OEHGKJPAHKJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B490", Offset = "0x6C19E90", VA = "0x186C1B490")]
	public bool MKJOHNKBEAJ(Mesh ANBKEJJPIHH, bool OEHGKJPAHKJ, bool ACKFNEELKFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A9A0", Offset = "0x6C193A0", VA = "0x186C1A9A0")]
	public bool LBGLBOCMLHN(Mesh ANBKEJJPIHH, LCFLAENFPKH FMIGLNNECOB, bool OEHGKJPAHKJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6C16750", Offset = "0x6C15150", VA = "0x186C16750")]
	public void AGFDPLMOAEF(Mesh ANBKEJJPIHH, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C16660", Offset = "0x6C15060", VA = "0x186C16660")]
	[BurstCompile]
	public static int AAGHHHAJIHF(float ICJCFEHCALD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C166B0", Offset = "0x6C150B0", VA = "0x186C166B0")]
	[BurstCompile]
	public static uint AAGHHHAJIHF([In] float4 OEHMKJHGMIJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C16700", Offset = "0x6C15100", VA = "0x186C16700")]
	[BurstCompile]
	public static uint AAGHHHAJIHF([In] float3 OEHMKJHGMIJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A260", Offset = "0x6C18C60", VA = "0x186C1A260")]
	public void KDLBOANJEFF(Mesh ANBKEJJPIHH, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C17C20", Offset = "0x6C16620", VA = "0x186C17C20")]
	[BurstCompile]
	private unsafe static void FGHIJFFGJKJ([NoAlias] BDOHLCHFOLI* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C18E80", Offset = "0x6C17880", VA = "0x186C18E80")]
	public void INFJJHJIDOD(Mesh ANBKEJJPIHH, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C17B40", Offset = "0x6C16540", VA = "0x186C17B40")]
	[BurstCompile]
	private unsafe static void EHIDOKGOBIN([NoAlias] EACBGGPNICB* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C18800", Offset = "0x6C17200", VA = "0x186C18800")]
	public void IFECLABEGGB(Mesh ANBKEJJPIHH, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C080", Offset = "0x6C1AA80", VA = "0x186C1C080")]
	[BurstCompile]
	private unsafe static void OHIADOPCCJJ([NoAlias] DDNPPOBHHAM* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B890", Offset = "0x6C1A290", VA = "0x186C1B890")]
	public void MNPECIKBIPD(Mesh ANBKEJJPIHH, bool ACKFNEELKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C18490", Offset = "0x6C16E90", VA = "0x186C18490")]
	[BurstCompile]
	private unsafe static void HNJIEOMDGEB([NoAlias] NHAJLFNBEAM* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK, [Out] float3 KIMAPIPLIKB, [Out] float3 BNAGCMNPCHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C178C0", Offset = "0x6C162C0", VA = "0x186C178C0")]
	public void CGMDCKEMCIB(Mesh ANBKEJJPIHH, FLJIGNHDJHO CJLNMCEFAGN, bool ACKFNEELKFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C18220", Offset = "0x6C16C20", VA = "0x186C18220")]
	public void GMIIOGCKDPD(LCFLAENFPKH ANBKEJJPIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C173D0", Offset = "0x6C15DD0", VA = "0x186C173D0")]
	public void BBPGAOGNNLM(LCFLAENFPKH NHGOKBHHHPE, Allocator MDICAPEDFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C180F0", Offset = "0x6C16AF0", VA = "0x186C180F0")]
	public long GGINLMHBMBB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C18090", Offset = "0x6C16A90", VA = "0x186C18090")]
	public static long GGINLMHBMBB(int DKBLKICIPOL, int ILDHFOPNDME)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AEA0", Offset = "0x6C198A0", VA = "0x186C1AEA0")]
	public static long MBIKFIEDAMC(int DKBLKICIPOL, int ILDHFOPNDME, FLJIGNHDJHO CJLNMCEFAGN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AF40", Offset = "0x6C19940", VA = "0x186C1AF40")]
	public long MBIKFIEDAMC(FLJIGNHDJHO CJLNMCEFAGN)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C17BC0", Offset = "0x6C165C0", VA = "0x186C17BC0")]
	public void FBCOOLOKAGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C18510", Offset = "0x6C16F10", VA = "0x186C18510")]
	public static void HOAMKFBKAJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C19740", Offset = "0x6C18140", VA = "0x186C19740")]
	public FLJIGNHDJHO JICHONEBJGL()
	{
		return default(FLJIGNHDJHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C174D0", Offset = "0x6C15ED0", VA = "0x186C174D0")]
	public static (int, int) BHCJPONNLMD(Mesh ANBKEJJPIHH)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C17950", Offset = "0x6C16350", VA = "0x186C17950")]
	public static int CJOFFALMEJN(VertexAttributeDescriptor[] MBFKELABNHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C010", Offset = "0x6C1AA10", VA = "0x186C1C010")]
	public static long OBBIOEOBBKK(Mesh ANBKEJJPIHH, int DCKADNAHJKI, int GPPFKBPNLFD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public LCFLAENFPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C175A0", Offset = "0x6C15FA0", VA = "0x186C175A0")]
	[BurstCompile]
	public static int BIFHFCNELFN(float ICJCFEHCALD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C17640", Offset = "0x6C16040", VA = "0x186C17640")]
	[BurstCompile]
	public static uint BIFHFCNELFN([In] float4 OEHMKJHGMIJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C177D0", Offset = "0x6C161D0", VA = "0x186C177D0")]
	[BurstCompile]
	public static uint BIFHFCNELFN([In] float3 OEHMKJHGMIJ)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C17CE0", Offset = "0x6C166E0", VA = "0x186C17CE0")]
	[BurstCompile]
	public unsafe static void FLJKEIOLPFN([NoAlias] BDOHLCHFOLI* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B040", Offset = "0x6C19A40", VA = "0x186C1B040")]
	[BurstCompile]
	public unsafe static void MGCFCEDCHFB([NoAlias] EACBGGPNICB* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C171D0", Offset = "0x6C15BD0", VA = "0x186C171D0")]
	[BurstCompile]
	public unsafe static void ANFCAEPDDAA([NoAlias] DDNPPOBHHAM* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C19F20", Offset = "0x6C18920", VA = "0x186C19F20")]
	[BurstCompile]
	public unsafe static void JMFFLPFOOOK([NoAlias] NHAJLFNBEAM* BNKEIAEBHIG, int NBBEBMFLJHD, [In][NoAlias] float3* IGHLHPNKDJG, [In][NoAlias] float3* LABFLHMCLEM, [In][NoAlias] float4* IIHDJPGJDHJ, [In][NoAlias] float2* EPPHMIIOHIO, [In][NoAlias] float4* ELCLOMHBFPK, [Out] float3 KIMAPIPLIKB, [Out] float3 BNAGCMNPCHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct EOLPIHCJHNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int BNIBIKCENAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 JJLDKIBOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public quaternion JINAABLNFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 FFNMGBBGPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int CKDAEMELGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int OAKOGEMAGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int LNMILGKBAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float EAPAIDANJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 GPOFBGPLJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool ABIINHNMODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public JBAIAMDHOOA JGDPLMHKBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 EHHPOMGNJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float BOLPLEBIBNN;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IEBIJPNOIHK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static MAFJEFDKHKP EGBMPAAHMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<EOLPIHCJHNP> DOEFGIKPLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<LMADLKMAIGB> FEHIHFMDGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<HHDNDABJKNI> NKJCHMKPNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<JMCOJBGJDJJ> GOOAKLKIPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<LMADLKMAIGB> DPNJMLODFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeList<BJAGOKLCBMM> EHNKDKLLJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeArray<JMCOJBGJDJJ>> IOJEJLIEKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<ANGGEMEBBDI> MMBBMIMNCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<int> AMFBFJBPBGC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KGFCHDECLIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xF719E0", Offset = "0xF703E0", VA = "0x180F719E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xF712F0", Offset = "0xF6FCF0", VA = "0x180F712F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int CDFMPOLKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xF719F0", Offset = "0xF703F0", VA = "0x180F719F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xF70C60", Offset = "0xF6F660", VA = "0x180F70C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C15F70", Offset = "0x6C14970", VA = "0x186C15F70")]
	public IEBIJPNOIHK(int OJIOLPIIEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6C14390", Offset = "0x6C12D90", VA = "0x186C14390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C15DA0", Offset = "0x6C147A0", VA = "0x186C15DA0")]
	public void LCECLFEFOKJ(JobHandle KPAOAOAPKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C14800", Offset = "0x6C13200", VA = "0x186C14800")]
	public void HOKIINLNBLJ(EOLPIHCJHNP OIGMDCDEKEG, ANGGEMEBBDI HAFBHBCLGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6C14230", Offset = "0x6C12C30", VA = "0x186C14230")]
	public void DMPLALIKEPJ(HHDNDABJKNI OIGMDCDEKEG, NativeArray<JMCOJBGJDJJ> ECCCANBMDPC, int NBBEBMFLJHD, int AAFJIHGKCMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C14A20", Offset = "0x6C13420", VA = "0x186C14A20")]
	public JobHandle IGBKNMDLPNA(LCFLAENFPKH HKEFJNBJIHP, JBIFMCPAACK GHCNMJDALHA, float3 BHMDKLCCECB, quaternion PHELMJAMJJJ, float MLPDDHMMJBO, bool KCNCPNBJEBJ, int AFJAGDFIMKO = 0, int IEBBBENDPCL = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C15A60", Offset = "0x6C14460", VA = "0x186C15A60")]
	public static JobHandle KHKMAJOHJOJ(JNGINCENJIL GGECGFLFENI, LCFLAENFPKH HKEFJNBJIHP, EOLPIHCJHNP OIGMDCDEKEG, JobHandle KPAOAOAPKHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C14550", Offset = "0x6C12F50", VA = "0x186C14550")]
	public static JobHandle GLDJPOHEIDP(NNPFDEEKELK GGECGFLFENI, LCFLAENFPKH HKEFJNBJIHP, HHDNDABJKNI OIGMDCDEKEG, NativeArray<JMCOJBGJDJJ> ECCCANBMDPC, int NBBEBMFLJHD, int AAFJIHGKCMC, JobHandle KPAOAOAPKHJ)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct HMNEGAMCNMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float2 JGJBOLABHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float2 KHMPGKCHOLL;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PJCFEJIMLKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeArray<HMNEGAMCNMG> CAFAOILMMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeArray<int> GMMLKNDOAHO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KGFCHDECLIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x889410", Offset = "0x887E10", VA = "0x180889410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CDFMPOLKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8893F0", Offset = "0x887DF0", VA = "0x1808893F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6C268C0", Offset = "0x6C252C0", VA = "0x186C268C0")]
	public PJCFEJIMLKI(int FCPKPFBGPNI, int OJDOODEMIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6C26780", Offset = "0x6C25180", VA = "0x186C26780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C267E0", Offset = "0x6C251E0", VA = "0x186C267E0")]
	public void GMIIOGCKDPD(PJCFEJIMLKI KIMGMEEPEMC, int FDLJGFJKPCB, int GLCOHEPGOCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class EPMECJFLELG
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static PJCFEJIMLKI EOJJGJMEKJP;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static NativeList<LMADLKMAIGB> OCPDHPPEHBB;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int[] CEIFFMNCGIN;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static bool OFHCFCCKGHE;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static Dictionary<int, PJCFEJIMLKI> DPEDCEOOEEO;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static Dictionary<int, PJCFEJIMLKI> FHGFDPBFDFB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool AAFKJENHGMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6C0D390", Offset = "0x6C0BD90", VA = "0x186C0D390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<LMADLKMAIGB> DGINFLEDFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E020", Offset = "0x6C0CA20", VA = "0x186C0E020")]
		get
		{
			return default(NativeList<LMADLKMAIGB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static PJCFEJIMLKI MOBBGCAKIOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6C0E310", Offset = "0x6C0CD10", VA = "0x186C0E310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E3A0", Offset = "0x6C0CDA0", VA = "0x186C0E3A0")]
	private static void OKINAIMGCNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E0B0", Offset = "0x6C0CAB0", VA = "0x186C0E0B0")]
	public static int JLPOCLMONOM(bool EOGCMJHKFIE, int FMEIJAKCDII, bool JPHEKJFKCCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6C0EA90", Offset = "0x6C0D490", VA = "0x186C0EA90")]
	private static int PLJIGICADCE(int FMEIJAKCDII, bool FCOJEKDNACO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6C0DCE0", Offset = "0x6C0C6E0", VA = "0x186C0DCE0")]
	private static int FMLFLOCFIAO(int FMEIJAKCDII, bool FCOJEKDNACO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6C0DF80", Offset = "0x6C0C980", VA = "0x186C0DF80")]
	public static int GEGKMCJCLMA(int NDKONLLHKBF, int FMEIJAKCDII, int BPHKFHOCPHP, bool FCOJEKDNACO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E280", Offset = "0x6C0CC80", VA = "0x186C0E280")]
	public static int MKCGDELDEIK(int NDKONLLHKBF, int FMEIJAKCDII, int BPHKFHOCPHP, bool FCOJEKDNACO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E010", Offset = "0x6C0CA10", VA = "0x186C0E010")]
	public static int IOGKAJLNOBH(int BPHKFHOCPHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D500", Offset = "0x6C0BF00", VA = "0x186C0D500")]
	private static int CHPDIMMPJHC(int FMEIJAKCDII, bool FCOJEKDNACO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D8C0", Offset = "0x6C0C2C0", VA = "0x186C0D8C0")]
	private static int DDGOCAIDINK(int FMEIJAKCDII, bool FCOJEKDNACO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D850", Offset = "0x6C0C250", VA = "0x186C0D850")]
	public static int CNEFLJIOPJM(int NDKONLLHKBF, int FMEIJAKCDII, int BPHKFHOCPHP, bool FCOJEKDNACO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E0E0", Offset = "0x6C0CAE0", VA = "0x186C0E0E0")]
	public static int KMBCGPMKHAG(int NDKONLLHKBF, int FMEIJAKCDII, int BPHKFHOCPHP, bool FCOJEKDNACO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E170", Offset = "0x6C0CB70", VA = "0x186C0E170")]
	public static int LCGIIGHFHIC(int BPHKFHOCPHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D410", Offset = "0x6C0BE10", VA = "0x186C0D410")]
	public static PJCFEJIMLKI BKKGBLNLONE(int FMEIJAKCDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C0DCF0", Offset = "0x6C0C6F0", VA = "0x186C0DCF0")]
	private static PJCFEJIMLKI GBMFGIDAEJJ(int FMEIJAKCDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6C0E190", Offset = "0x6C0CB90", VA = "0x186C0E190")]
	public static PJCFEJIMLKI LDEENMNHGJC(int FMEIJAKCDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D510", Offset = "0x6C0BF10", VA = "0x186C0D510")]
	private static PJCFEJIMLKI CILFMGIFHOC(int FMEIJAKCDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6C0D8E0", Offset = "0x6C0C2E0", VA = "0x186C0D8E0")]
	public static void FFLFLLEPLFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct HHDNDABJKNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public int BHDOBEENKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 JJLDKIBOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public quaternion JINAABLNFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float FFNMGBBGPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float HNPDPEPPFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int CKDAEMELGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int OAKOGEMAGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int LNMILGKBAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool ENAGCEHKMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool EIDFGPEIEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public float EAPAIDANJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float3 GPOFBGPLJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool MFMPBFCIMEN;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct BJAGOKLCBMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public int AKIMBDMNKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public int CMIHDODFJHE;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct NNPFDEEKELK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeList<HHDNDABJKNI> GNLIHAAJCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<JMCOJBGJDJJ> MLIFJJGMCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<LMADLKMAIGB> PJDJMHHBKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeArray<BJAGOKLCBMM> CLDCHHEBBHG;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6C1CEE0", Offset = "0x6C1B8E0", VA = "0x186C1CEE0")]
	public NNPFDEEKELK(NativeArray<JMCOJBGJDJJ> MLIFJJGMCFK, int MPLHLKNKHIM = 1, Allocator MDICAPEDFAK = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6C1CDF0", Offset = "0x6C1B7F0", VA = "0x186C1CDF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
public struct GILEDAELLLG : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private NativeArray<HMNEGAMCNMG> LDEAHDKJLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[ReadOnly]
	private NativeArray<int> AGPMDPCNEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[ReadOnly]
	private NativeList<LMADLKMAIGB> KOOHDFKOOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<HHDNDABJKNI> GNLIHAAJCCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<JMCOJBGJDJJ> MLIFJJGMCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeArray<LMADLKMAIGB> PJDJMHHBKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	public NativeArray<BJAGOKLCBMM> CLDCHHEBBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private int IODEFMPBLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private int MMCKMEGIKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private float3 DHNIJNCJHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private quaternion OCDGACKMOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private float3 CPKMFIHJLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NMGKLEGKMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NFGKNHPBOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PLGOPHPDADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EDONHPJONLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> IEOLDGICCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BJBJGIMKJMM;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6C11A20", Offset = "0x6C10420", VA = "0x186C11A20")]
	public GILEDAELLLG(IEBIJPNOIHK MFKDLAAANPO, LCFLAENFPKH DGKOANHDJBM, float3 ADOONEENHJJ, quaternion LDMJLNFCNJC, float MIFIANPDNGL, int AFJAGDFIMKO = 0, int IEBBBENDPCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6C117F0", Offset = "0x6C101F0", VA = "0x186C117F0")]
	public GILEDAELLLG(NNPFDEEKELK MFKDLAAANPO, LCFLAENFPKH DGKOANHDJBM, float3 ADOONEENHJJ, quaternion LDMJLNFCNJC, float3 MIFIANPDNGL, int AFJAGDFIMKO = 0, int IEBBBENDPCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6C10A90", Offset = "0x6C0F490", VA = "0x186C10A90")]
	private float3 JABJHBLPOAH(float3 LAKBGMHODME, Matrix4x4 ACACCMJIGAC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6C0F870", Offset = "0x6C0E270", VA = "0x186C0F870")]
	private float3x3 ACCKAMALEKK(float3x3 LEDMHNFKNLK, float3x3 MBLCCDOJLKH)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6C11020", Offset = "0x6C0FA20", VA = "0x186C11020")]
	private float MHIEOFBBBGD(float ADJNFMJNIAA, float KHMDOCFIGGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6C0F8F0", Offset = "0x6C0E2F0", VA = "0x186C0F8F0", Slot = "4")]
	public void Execute(int PEMICEPHOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6C11030", Offset = "0x6C0FA30", VA = "0x186C11030")]
	private void MMCAGGMMPOJ(int NDHKOGPOKBO, float3 BJDHDJCINFH, float3 BELBOBCMBGH, float3 PMGHDGKDGKL, float MNBMJJFKKCE, bool MNFPDEJDCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6C10BC0", Offset = "0x6C0F5C0", VA = "0x186C10BC0")]
	private void KEDEOPLNNLN(HHDNDABJKNI GGDMPNIKLKD, float3 OADBGCPFPOE, float3x3 CJJEGFAGPAN, float ADJNFMJNIAA, int BCMLGDGELOG, int AADCAMGHCHE, int ABLIEFFNPHC, float BJJFOJNCJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6C111A0", Offset = "0x6C0FBA0", VA = "0x186C111A0")]
	private void NBHMEFGFADF(int NDHKOGPOKBO, int NMJDIMINFCM, HHDNDABJKNI GGDMPNIKLKD, float3 OADBGCPFPOE, float3x3 CJJEGFAGPAN, bool JIEIDFHPHJL, float ADJNFMJNIAA, int CHFJKEFIDPA, int MMNFOIEOEON, int ABLIEFFNPHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct JNGINCENJIL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<EOLPIHCJHNP> DCNHADFDNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<LMADLKMAIGB> AJHFGABDIAF;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6C163D0", Offset = "0x6C14DD0", VA = "0x186C163D0")]
	public JNGINCENJIL(int MPLHLKNKHIM, Allocator MDICAPEDFAK = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6C16330", Offset = "0x6C14D30", VA = "0x186C16330", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct GOMDDOBPCIA : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private enum MPNIJBIMCCB
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
	private NativeList<float3> NBFMKEFDFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> LAOFAGGPOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<int> MANBPECOLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> AKCPENDMHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<float4> HPKLEKGPCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float4> LGMEIJHJEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float4> CGLAPEEJPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> HPKDNIDBHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private NativeList<LMADLKMAIGB> LBGMKNPFJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<EOLPIHCJHNP> DCNHADFDNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeList<LMADLKMAIGB> AJHFGABDIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private int IODEFMPBLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private int MMCKMEGIKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NMGKLEGKMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NFGKNHPBOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PLGOPHPDADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EDONHPJONLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> IEOLDGICCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BJBJGIMKJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float3 CPKMFIHJLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private quaternion OCDGACKMOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private float3 DHNIJNCJHJL;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6C13290", Offset = "0x6C11C90", VA = "0x186C13290")]
	public GOMDDOBPCIA(IEBIJPNOIHK MFKDLAAANPO, LCFLAENFPKH DGKOANHDJBM, float3 ADOONEENHJJ, quaternion LDMJLNFCNJC, float MIFIANPDNGL, int AFJAGDFIMKO = 0, int IEBBBENDPCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6C130B0", Offset = "0x6C11AB0", VA = "0x186C130B0")]
	public GOMDDOBPCIA(JNGINCENJIL OIGMDCDEKEG, LCFLAENFPKH DGKOANHDJBM, float3 ADOONEENHJJ, quaternion LDMJLNFCNJC, float3 MIFIANPDNGL, int AFJAGDFIMKO = 0, int IEBBBENDPCL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6C11CA0", Offset = "0x6C106A0", VA = "0x186C11CA0", Slot = "4")]
	public void Execute(int PEMICEPHOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6C12C70", Offset = "0x6C11670", VA = "0x186C12C70")]
	private void HPPBNCGANBN(float4x4 IILCLIIICBH, int PEMICEPHOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6C12C00", Offset = "0x6C11600", VA = "0x186C12C00")]
	private MPNIJBIMCCB HJAHODPMDLM(float3 BELBOBCMBGH)
	{
		return default(MPNIJBIMCCB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6C13060", Offset = "0x6C11A60", VA = "0x186C13060")]
	private float4 NNFJIELKIMM(MPNIJBIMCCB DAGJHAHCIND, int EBDDHAPIAHH)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6C13020", Offset = "0x6C11A20", VA = "0x186C13020")]
	private float2 KAEAMKGFMIP(MPNIJBIMCCB DAGJHAHCIND, float3 BJDHDJCINFH)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct ANGGEMEBBDI
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum CAEHEDCHOOM
	{
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static ANGGEMEBBDI MANEDJLMOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 FDBNADNMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3x3 MHMMIDFOFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float3 GCMPBODBNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public CAEHEDCHOOM HMGDADDECHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float3 KNNAFEGJENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float3 AFLHHCAJLHM;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool IMCHLNDGPGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6C27BC0", Offset = "0x6C265C0", VA = "0x186C27BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 OKDOINDOEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6C27650", Offset = "0x6C26050", VA = "0x186C27650")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C27D30", Offset = "0x6C26730", VA = "0x186C27D30")]
	public ANGGEMEBBDI(float3 BJDHDJCINFH, quaternion FJFNLINEAKI, float3 MPLHLKNKHIM, CAEHEDCHOOM NNCMOPPBEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6C279C0", Offset = "0x6C263C0", VA = "0x186C279C0")]
	public float LAKANFIJNDM(float3 OADBGCPFPOE, float OIGCJLCDAFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6C27560", Offset = "0x6C25F60", VA = "0x186C27560")]
	public bool CHCJHFBDLAG(float3 BELBOBCMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6C273B0", Offset = "0x6C25DB0", VA = "0x186C273B0")]
	public void ANIFGPNGEHA(float3 KJHPFIOBAEN, float3x3 BGOPGBDIBFM, float ADNDJOJBDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C27BD0", Offset = "0x6C265D0", VA = "0x186C27BD0")]
	private void OADLIKOMNCD(float3 LPCMJKGGJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C27730", Offset = "0x6C26130", VA = "0x186C27730")]
	public void KGLMBGFEIIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
public struct LKLBLCAPNFC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	private NativeList<ANGGEMEBBDI> OIGMDCDEKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	private NativeList<float3> OLPJKPFHNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	private NativeList<int> KMBCFLOJGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> AMFBFJBPBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	private NativeList<LMADLKMAIGB> AJHFGABDIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	private int AOEDOIDKKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private int HOMMGAIKLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private float OIGCJLCDAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private float NBLEKKPGAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> KBNKBFFJMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> FAOJGPGCAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> JGLBEKAHEKN;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E9C0", Offset = "0x6C3D3C0", VA = "0x186C3E9C0")]
	public LKLBLCAPNFC(LCFLAENFPKH ANBKEJJPIHH, float LBFLEIOBHBO, int GLCOHEPGOCK, int BCMLGDGELOG, NativeList<ANGGEMEBBDI> OIGMDCDEKEG, NativeArray<int> AMFBFJBPBGC, NativeList<LMADLKMAIGB> AJHFGABDIAF, JBIFMCPAACK GHCNMJDALHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DFE0", Offset = "0x6C3C9E0", VA = "0x186C3DFE0", Slot = "4")]
	public void Execute(int MGGDOPJKKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DF20", Offset = "0x6C3C920", VA = "0x186C3DF20")]
	private bool CDPDDCHGJKO(ANGGEMEBBDI GPKBBMJKBAE, ANGGEMEBBDI AAMOGMLMOOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6C3E720", Offset = "0x6C3D120", VA = "0x186C3E720")]
	private bool PIGBIGFICPD(ANGGEMEBBDI IEHAPHFDOCH, int EPKHLKKHDGK, int HKKPMDLDMDC, int BKMGHPEEGHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JBIFMCPAACK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public NativeArray<bool> OFJJENFFJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public NativeArray<int> EIBJAEJLCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public NativeArray<bool> DMKJMMKPOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NativeArray<float> JGDLOPNKFGL;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D070", Offset = "0x6C3BA70", VA = "0x186C3D070")]
	public void JAKKOBEPFMA(int FCPKPFBGPNI, int OJDOODEMIJC, Allocator MDICAPEDFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D280", Offset = "0x6C3BC80", VA = "0x186C3D280")]
	public static long PJGHFHJEFPF(int FCPKPFBGPNI, int OJDOODEMIJC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C3CF80", Offset = "0x6C3B980", VA = "0x186C3CF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D190", Offset = "0x6C3BB90", VA = "0x186C3D190")]
	public void LCECLFEFOKJ(JobHandle KPAOAOAPKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
	public JBIFMCPAACK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
public struct DHJOOAFKNAL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NativeList<float3> OLPJKPFHNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private NativeArray<float3> LABFLHMCLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeArray<float4> ELCLOMHBFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float2> EPPHMIIOHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeList<int> KMBCFLOJGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IIHDJPGJDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> KOMDPNIEGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[ReadOnly]
	private NativeArray<bool> KBNKBFFJMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[ReadOnly]
	private NativeArray<bool> FAOJGPGCAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	private int AFJAGDFIMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private int IEBBBENDPCL;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6C314B0", Offset = "0x6C2FEB0", VA = "0x186C314B0")]
	public DHJOOAFKNAL(LCFLAENFPKH ANBKEJJPIHH, JBIFMCPAACK GHCNMJDALHA, int IEBBBENDPCL = 0, int AFJAGDFIMKO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6C31070", Offset = "0x6C2FA70", VA = "0x186C31070", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6C31450", Offset = "0x6C2FE50", VA = "0x186C31450")]
	private void JCOBANNJFOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class AKKJGBGJCFF
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x336A4E0", Offset = "0x3368EE0", VA = "0x18336A4E0")]
	public static bool FOHHMFJJDFL<T>(NativeArray<T> FNCIFDCGDBA, int MPLHLKNKHIM, Allocator MDICAPEDFAK, NativeArrayOptions IIPNOBBMFOE = NativeArrayOptions.ClearMemory, int FOLDNNGFGLC = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x336A660", Offset = "0x3369060", VA = "0x18336A660")]
	public static bool FOHHMFJJDFL<T>(NativeList<T> JNHGBAGBHGA, int MPLHLKNKHIM, Allocator MDICAPEDFAK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum KALLCKNDJCE
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
public interface CIFAILKDFMK
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CHNABFMIGAD(KALLCKNDJCE NDKONLLHKBF);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int ICKIAAGBCNJ(KALLCKNDJCE NDKONLLHKBF);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds JMGEMEKJEON();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float IICPKKPEGDP();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFAPCMHGNMM(KALLCKNDJCE NDKONLLHKBF, IEBIJPNOIHK OAENGBHPIII, int JKKHHBDKLJB = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class BAFLFLPHKEG
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6C27E20", Offset = "0x6C26820", VA = "0x186C27E20")]
	public static void FFLFLLEPLFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MCEFCNOJFEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public NativeList<float3> NDLNDMFKHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public NativeArray<float3> MFKMBOLEIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public NativeArray<int> BPFMDBMGLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<float4> FJMODNCEABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeArray<float4> JHHNDEDHHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeArray<float4> MJLMFCANMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public NativeList<float3> GPHCAEPHNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public NativeList<int> CJJKKOBBKMP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int KGFCHDECLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6C3FEE0", Offset = "0x6C3E8E0", VA = "0x186C3FEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int CDFMPOLKEAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6C3F620", Offset = "0x6C3E020", VA = "0x186C3F620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int LGKNFFCPBPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6C3FF20", Offset = "0x6C3E920", VA = "0x186C3FF20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6C40250", Offset = "0x6C3EC50", VA = "0x186C40250")]
	public MCEFCNOJFEO(int FCPKPFBGPNI, int OJDOODEMIJC, int CKBDJDKMGJJ, Allocator MDICAPEDFAK = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6C3FF60", Offset = "0x6C3E960", VA = "0x186C3FF60")]
	public MCEFCNOJFEO(Mesh ANBKEJJPIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6C3F510", Offset = "0x6C3DF10", VA = "0x186C3F510", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6C3FBE0", Offset = "0x6C3E5E0", VA = "0x186C3FBE0")]
	public void GMIIOGCKDPD(MCEFCNOJFEO ANBKEJJPIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6C3F080", Offset = "0x6C3DA80", VA = "0x186C3F080")]
	private void CJMABIAJNHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6C3F660", Offset = "0x6C3E060", VA = "0x186C3F660")]
	private void FMNLCHLCMDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct LMADLKMAIGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int PAIADPFKGDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public int KGFCHDECLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public int DHFOAADDNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int CDFMPOLKEAP;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1600850", Offset = "0x15FF250", VA = "0x181600850")]
	public LMADLKMAIGB(int BCMLGDGELOG, int NBBEBMFLJHD, int GLCOHEPGOCK, int AAFJIHGKCMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MAFJEFDKHKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<LMADLKMAIGB> JKKGBLAKEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x94B360", Offset = "0x949D60", VA = "0x18094B360")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<LMADLKMAIGB>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x94B370", Offset = "0x949D70", VA = "0x18094B370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MCEFCNOJFEO GLAHKBPOCKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x885AF0", Offset = "0x8844F0", VA = "0x180885AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EAD0", Offset = "0x6C3D4D0", VA = "0x186C3EAD0")]
	public MAFJEFDKHKP(IEnumerable<MCEFCNOJFEO> IGECNCLMMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C3EA60", Offset = "0x6C3D460", VA = "0x186C3EA60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum JBAIAMDHOOA
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class HJFHCIPANDB
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static NativeArray<float2> MJNFMOEDJNB;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static NativeArray<float3> HDJLIBHHJIA;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static NativeArray<float4> PKNFBIAGMCA;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static NativeArray<int> NLEKILEKAAD;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C3CA70", Offset = "0x6C3B470", VA = "0x186C3CA70")]
	public static void FFLFLLEPLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C3CC80", Offset = "0x6C3B680", VA = "0x186C3CC80")]
	public static NativeArray<float2> IHHJNAEOEPO(NativeArray<float2> MFBIJAJIHJG, int LOIPBCECCEH, NativeArray<float2> EFCLNEHGOAP, int BPMENCPOFGJ)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C3CB80", Offset = "0x6C3B580", VA = "0x186C3CB80")]
	public static NativeArray<float3> GLJGAELLDGG(NativeArray<float3> MFBIJAJIHJG, int LOIPBCECCEH, NativeArray<float3> EFCLNEHGOAP, int BPMENCPOFGJ)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C3CD80", Offset = "0x6C3B780", VA = "0x186C3CD80")]
	public static NativeArray<float4> IHHMCAECIGD(NativeArray<float4> MFBIJAJIHJG, int LOIPBCECCEH, NativeArray<float4> EFCLNEHGOAP, int BPMENCPOFGJ)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C3CE80", Offset = "0x6C3B880", VA = "0x186C3CE80")]
	public static NativeArray<int> PCHJLJGGNGF(NativeArray<int> MFBIJAJIHJG, int LOIPBCECCEH, NativeArray<int> EFCLNEHGOAP, int BPMENCPOFGJ)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2C978F0", Offset = "0x2C962F0", VA = "0x182C978F0")]
	private static void LFCNHEGICBK<T>(NativeArray<T> FNCIFDCGDBA, int AKJKJIBOOOB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2C97810", Offset = "0x2C96210", VA = "0x182C97810")]
	private static void KGIIBLEDDGA<T>(NativeArray<T> MFBIJAJIHJG, int LOIPBCECCEH, NativeArray<T> EFCLNEHGOAP, int BPMENCPOFGJ, NativeArray<T> IEAOFIMMOPL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BurstCompile]
public class LEPGKMBNDJG
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct GGLCONKFOLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ushort ICJCFEHCALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ushort MPEFCGEJLMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ushort IKFLIAKFHDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ushort BKKFLKGDPKP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D2A0", Offset = "0x6C3BCA0", VA = "0x186C3D2A0")]
	public static uint AELEIHBAACL(float PKLNHEPNIBN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D2B0", Offset = "0x6C3BCB0", VA = "0x186C3D2B0")]
	public static void CMEGAMKFJAB(float4 ELCLOMHBFPK, float ICPLJMKCPPP, [Out] uint ODGEKMAJHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D3C0", Offset = "0x6C3BDC0", VA = "0x186C3D3C0")]
	public static void CMEGAMKFJAB(float4 ELCLOMHBFPK, uint IPNCCBHGKMI, [Out] uint ODGEKMAJHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DAB0", Offset = "0x6C3C4B0", VA = "0x186C3DAB0")]
	public static void MMHEOONOKMG(float3 FMCHGMBCKCH, float3 FCCOMIOLOGN, float4 IKEJPNIHHCF, float2 JCMOOBJCHNG, float4 ELCLOMHBFPK, [Out] LCFLAENFPKH.DDNPPOBHHAM GHBFCEMDLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D850", Offset = "0x6C3C250", VA = "0x186C3D850")]
	public static void MMHEOONOKMG(float3 FMCHGMBCKCH, float3 FCCOMIOLOGN, float4 IKEJPNIHHCF, float2 JCMOOBJCHNG, float4 ELCLOMHBFPK, [Out] LCFLAENFPKH.NHAJLFNBEAM GHBFCEMDLAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DE50", Offset = "0x6C3C850", VA = "0x186C3DE50")]
	public static byte OJHAFEBFLLI(float CLMKDBDPNNH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D520", Offset = "0x6C3BF20", VA = "0x186C3D520")]
	public static ushort FDHMMHIEOKH(float CLMKDBDPNNH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D6D0", Offset = "0x6C3C0D0", VA = "0x186C3D6D0")]
	public static uint LKEGLJNBMCI(float CLMKDBDPNNH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D490", Offset = "0x6C3BE90", VA = "0x186C3D490")]
	public static float2 DNOFFNOAIJK(float2 OEHMKJHGMIJ)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6C3DD00", Offset = "0x6C3C700", VA = "0x186C3DD00")]
	public static float2 NPHKENKELLB(float3 NGLGLPDMMBG)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D700", Offset = "0x6C3C100", VA = "0x186C3D700")]
	public static void LOAPKGGMKCC(float3 CLMKDBDPNNH, [Out] float3 ANCBCJNIIFJ, [Out] uint3 BKKFLKGDPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6C3D570", Offset = "0x6C3BF70", VA = "0x186C3D570")]
	public static GGLCONKFOLM JFMKFEFCFAD(float3 BJDHDJCINFH)
	{
		return default(GGLCONKFOLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ELJEBAPGLKC
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker OEAGKHJKKML;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static float LIHHMJGIDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void ABENPELKDMI(bool GLDACGDACAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6C3C4B0", Offset = "0x6C3AEB0", VA = "0x186C3C4B0")]
	public static void OEBEECLKHIL(float BMBPBJKDOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class EFIBBIOHLMP
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal enum DGOJPPPKGLK
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
	public struct OAOBDKKELNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public PFOHDIHLFKM ANBKEJJPIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int FPMLLBDJLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int AODKJGCCMEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public long KILKGKDEHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public long KOOICOOCEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float MAGEHKBGNFM;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6C40520", Offset = "0x6C3EF20", VA = "0x186C40520")]
		public void FKBEJNBPEHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6C40550", Offset = "0x6C3EF50", VA = "0x186C40550")]
		public void LCECLFEFOKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string ALBCHDIEBDH;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly string IJHOMHLINJJ;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly ProfilerMarker OEAGKHJKKML;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly ProfilerMarker IGDINHAIGHC;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly ProfilerMarker PCJEBMMJBEI;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly ProfilerMarker JIOCNPKPFGH;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly ProfilerMarker CNKGHNBIMMJ;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly ProfilerMarker CJIGHGMHKBL;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly ProfilerMarker ADNBNGAAGLM;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly ProfilerMarker FCKGBGKDKKG;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly ProfilerMarker CFEMILAOJEG;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly ProfilerMarker MKOGMNKFDBK;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly ProfilerMarker FOGGINDMLPK;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly ProfilerMarker MFPMMPNFDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly List<CIFAILKDFMK> DOJFLIMJFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly MHHIDICAJHA ICMODKGOCEM;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public const bool KLHMANPKFJK = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int NBBEBMFLJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int AAFJIHGKCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool CHAABKGDFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal bool FPOLMDCEONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool JDHHGLMLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	internal DGOJPPPKGLK ACEEMNFHFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	internal bool JONNKDMEIOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	internal float3 GLMPNJFOMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	internal float3 OHPKNCOENJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal float ECBKMFEADHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	internal float FPKGNADCFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	internal int APOOKCLDKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	internal int NHCANPOODOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int NGANCOEPIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int PPFLIDFFCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private float JILKJLMJJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private float OFBMADGOKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int KKIAPJBFGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long EKELBJFBKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long KCOFGJGJEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private long DEFFMBEFOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public int PDENHBBOKGJ;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private const int AJAGGNPLOGC = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private float[] JBCLKKCKJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int[] NNIBKNCIECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long[] CHEBNNLAIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<OAOBDKKELNI> CHJANEEMDDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private LCFLAENFPKH IMDBBAINMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private long LGPGHIKKINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private long IMAIDDJDPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int PFAKAEIHOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	internal float ONGKNPJGCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	internal LCFLAENFPKH.FLJIGNHDJHO JCANEKBBEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool KABNBAKIFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private BFOAGHLDJKI NKDIDHLBKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private JobHandle KDJFECOJCMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	internal NativeArray<long> ONBGGJHMPIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool FALGINHPAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private JobHandle GHNHGCLHGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private LCFLAENFPKH NNMLACFLMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private JBIFMCPAACK ADPAHDFEFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform DPKDGBFADKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private KALLCKNDJCE PCCKHCPJHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private long CHDBDOCGJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private long CLBHGCJIHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long KKHOPNPHCLE;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	internal Mesh GLAHKBPOCKA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x886770", Offset = "0x885170", VA = "0x180886770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MeshFilter AAMOCIOKGEI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8893D0", Offset = "0x887DD0", VA = "0x1808893D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshRenderer CBJFOAJDGFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8869C0", Offset = "0x8853C0", VA = "0x1808869C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x891470", Offset = "0x88FE70", VA = "0x180891470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<Material> OKJHDGDEBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8869B0", Offset = "0x8853B0", VA = "0x1808869B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x886990", Offset = "0x885390", VA = "0x180886990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int DNMLDKBODBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA0A610", Offset = "0xA09010", VA = "0x180A0A610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int OFMIEKMNIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x11AA9A0", Offset = "0x11A93A0", VA = "0x1811AA9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int KGFCHDECLIO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6C37CE0", Offset = "0x6C366E0", VA = "0x186C37CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public List<CIFAILKDFMK> JMLFNPIBHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x882780", Offset = "0x881180", VA = "0x180882780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6C35AD0", Offset = "0x6C344D0", VA = "0x186C35AD0")]
	public void HNAFKKFGPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6C38F60", Offset = "0x6C37960", VA = "0x186C38F60")]
	private void NLDHJKBFOKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6C3C1D0", Offset = "0x6C3ABD0", VA = "0x186C3C1D0")]
	public EFIBBIOHLMP(string HBOONHFLONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6C37730", Offset = "0x6C36130", VA = "0x186C37730")]
	public void LCECLFEFOKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6C37690", Offset = "0x6C36090", VA = "0x186C37690")]
	private void KJKEPCCMLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6C37D00", Offset = "0x6C36700", VA = "0x186C37D00")]
	private void MKINPHBGGLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6C32640", Offset = "0x6C31040", VA = "0x186C32640")]
	public Mesh DBOCPIHDKKG(MeshFilter CHDJFDKPPBC, Transform JKDLLOIHFGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6C37040", Offset = "0x6C35A40", VA = "0x186C37040")]
	private void JIKGLHILCFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C39260", Offset = "0x6C37C60", VA = "0x186C39260")]
	public void NLJICFCGPJA(CIFAILKDFMK GNBDEIILEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6C37C60", Offset = "0x6C36660", VA = "0x186C37C60")]
	public bool LJIFGFIAFAE(CIFAILKDFMK GNBDEIILEEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C322A0", Offset = "0x6C30CA0", VA = "0x186C322A0")]
	public bool BNBIAOAJEAG(CIFAILKDFMK GNBDEIILEEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6C32730", Offset = "0x6C31130", VA = "0x186C32730", Slot = "4")]
	public virtual void DDMJCAEINIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6C35170", Offset = "0x6C33B70", VA = "0x186C35170")]
	public void GOBHLOIHFDL(Transform KLBJBBMLEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AB40", Offset = "0x6C39540", VA = "0x186C3AB40")]
	private long OINELDHFAAJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AF80", Offset = "0x6C39980", VA = "0x186C3AF80")]
	private long PDEOJEOANFB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6C37E40", Offset = "0x6C36840", VA = "0x186C37E40")]
	public bool NKLPDPJHEIB(Transform KLBJBBMLEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6C327C0", Offset = "0x6C311C0", VA = "0x186C327C0")]
	public bool DLFAEAHEEBE(bool PPNMDJKPJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6C33680", Offset = "0x6C32080", VA = "0x186C33680")]
	private void ELHAIKPADAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6C393C0", Offset = "0x6C37DC0", VA = "0x186C393C0")]
	public bool OEBEECLKHIL(float4x4 FJCACPIFNPA, BatchedMeshRenderer HNJJOMMAOEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6C31F70", Offset = "0x6C30970", VA = "0x186C31F70")]
	public void BAKHJHPKBOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6C372D0", Offset = "0x6C35CD0", VA = "0x186C372D0")]
	public bool KCABFBMPAMK(bool PPNMDJKPJNM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C35C00", Offset = "0x6C34600", VA = "0x186C35C00")]
	public void IJJABDDLGPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6C31530", Offset = "0x6C2FF30", VA = "0x186C31530")]
	public void AHBFDAFIFCG(LCFLAENFPKH ANBKEJJPIHH, int MNLFLDCHNHJ, int HFFEOPLMMBM, float LBPIKMANIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6C35820", Offset = "0x6C34220", VA = "0x186C35820")]
	public void HHNFJBKMAMB(PFOHDIHLFKM CPAOFOCPCBP, int MNLFLDCHNHJ, int HFFEOPLMMBM, float LBPIKMANIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6C350D0", Offset = "0x6C33AD0", VA = "0x186C350D0")]
	public (long, long, long) GGINLMHBMBB()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x93A510", Offset = "0x938F10", VA = "0x18093A510")]
	public long BAGKMGJKIBK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6C37860", Offset = "0x6C36260", VA = "0x186C37860")]
	private void LFCCFPNEAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6C3AC00", Offset = "0x6C39600", VA = "0x186C3AC00")]
	public (long, long) PBDLBJEGJKK(float NKAKLCJAPOH, float4x4 FJCACPIFNPA)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public void KCHAJFOHHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6C35AE0", Offset = "0x6C344E0", VA = "0x186C35AE0")]
	internal void HONKBCLDGJK(DGOJPPPKGLK NDAHADENHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6C33E80", Offset = "0x6C32880", VA = "0x186C33E80")]
	private (float, float, float, float) FKHOHPFMHBI(float IODPOMKPDEH, float4x4 FJCACPIFNPA)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6C37DE0", Offset = "0x6C367E0", VA = "0x186C37DE0")]
	private float NDFCFKHLDEN(float IODPOMKPDEH, float4x4 FJCACPIFNPA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6C32300", Offset = "0x6C30D00", VA = "0x186C32300")]
	private (int, int) DAMKBGGLKJJ(float ICFLIKLJFLD)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6C35CB0", Offset = "0x6C346B0", VA = "0x186C35CB0")]
	public void IMJKABIPILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6C32150", Offset = "0x6C30B50", VA = "0x186C32150")]
	private void BJEFHMKNADM(LCFLAENFPKH GLFCHCGGEMC, LCFLAENFPKH.FLJIGNHDJHO HACDBMJFFIP, bool ACKFNEELKFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6C321A0", Offset = "0x6C30BA0", VA = "0x186C321A0")]
	private void BJEFHMKNADM([In] PFOHDIHLFKM GLFCHCGGEMC, LCFLAENFPKH.FLJIGNHDJHO HACDBMJFFIP, bool ACKFNEELKFC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6C35C10", Offset = "0x6C34610", VA = "0x186C35C10")]
	private void IJKAILLKGIA(LCFLAENFPKH.FLJIGNHDJHO HACDBMJFFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6C35140", Offset = "0x6C33B40", VA = "0x186C35140")]
	private void GJOPKNFEAED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6C36D20", Offset = "0x6C35720", VA = "0x186C36D20")]
	private void JDPEMDGEPFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6C34720", Offset = "0x6C33120", VA = "0x186C34720")]
	public long FPCMOLABLEL(long PADMNPGIFNF, int BNKFOIOKELG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6C3B0E0", Offset = "0x6C39AE0", VA = "0x186C3B0E0")]
	private void PLBFCPHDGGK(LCFLAENFPKH MILELMABGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6C353B0", Offset = "0x6C33DB0", VA = "0x186C353B0")]
	private void HEKFBIFNLCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6C37600", Offset = "0x6C36000", VA = "0x186C37600")]
	private float KCHMHLOCLEF(int BKOIIGDIINO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6C31560", Offset = "0x6C2FF60", VA = "0x186C31560")]
	private void AIOJHJPHNOO(LCFLAENFPKH ANBKEJJPIHH, IAGKBAHGCJL CPAOFOCPCBP, int MNLFLDCHNHJ, int HFFEOPLMMBM, float LBPIKMANIDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct BFOAGHLDJKI : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct LOBICGOICLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int FPHBGKMLNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int CABOEOBGDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int JNDGCJLEKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int HJKODJLFLHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int OPLELHGKIAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int FHNKBKCFDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int FPMLLBDJLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int AODKJGCCMEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public float MAGEHKBGNFM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private struct HFEJJKFLAIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public OCKJGOBGGCG.NDJFHAPBNMO KNPMNDMHMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float BGFAODGCEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public float EFHMHLEPKEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public float DACBGJMAGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float LFCPPHLICEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public float CCAHAJEPEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public float LAJMBPNFOJH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct BKAONBGFHPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public NativeArray<float3> NDLNDMFKHFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NativeArray<float3> MFKMBOLEIPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public NativeArray<float4> IIAFPDJDOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NativeArray<float4> KDEHMNMLGDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NativeArray<float2> AIHJGKCDNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NativeArray<int> CJJKKOBBKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool GLEBCFKHOJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int KGFCHDECLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int CDFMPOLKEAP;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AA50", Offset = "0x6C29450", VA = "0x186C2AA50")]
		public void JAKKOBEPFMA(int FCPKPFBGPNI, int OJDOODEMIJC, Allocator MDICAPEDFAK, bool EOONNEJNAEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6C2A800", Offset = "0x6C29200", VA = "0x186C2A800")]
		public static BKAONBGFHPA GEBCOICJNBC(LCFLAENFPKH CDNMICCKGIM)
		{
			return default(BKAONBGFHPA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC30", Offset = "0x6C29630", VA = "0x186C2AC30")]
		public void LCECLFEFOKJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly ProfilerMarker ICDIAIGFEPN;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly ProfilerMarker NHPAJGADPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<LOBICGOICLM> DNLLHNHKDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private BKAONBGFHPA CPHEMFHBALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private BKAONBGFHPA MILELMABGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private float3 ICKHHKAFLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private float3 GDLFCLDHFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private HFEJJKFLAIA JGFHBCENBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* BBCKFKIDELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NativeArray<int> HCJCMOMKMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private NativeArray<bool> FAOJGPGCAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeArray<int> HCCPONDGBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private NativeArray<int> IBBENCNNMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private NativeArray<float> PJLGFPFAOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeArray<int> IMCDFFMKGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeArray<float> PGHNLKLBLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeArray<float> AMANAMFBFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<int> HAPPELPJMFE;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6C29FB0", Offset = "0x6C289B0", VA = "0x186C29FB0")]
	public BFOAGHLDJKI([In] List<EFIBBIOHLMP.OAOBDKKELNI> CCMJOENPLPL, [In] LCFLAENFPKH DKBHPFCKBPI, [In] EFIBBIOHLMP OPPMCJDNHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6C28070", Offset = "0x6C26A70", VA = "0x186C28070", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6C295C0", Offset = "0x6C27FC0", VA = "0x186C295C0")]
	public void ODBJKPBBNMD(List<EFIBBIOHLMP.OAOBDKKELNI> LPEGNLKBMDF, [In] EFIBBIOHLMP OPPMCJDNHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6C280C0", Offset = "0x6C26AC0", VA = "0x186C280C0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool FNBHEBHKDFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6C280E0", Offset = "0x6C26AE0", VA = "0x186C280E0")]
	private PFOHDIHLFKM IDIDLBCGMEJ(int IOJJLPCNBPC, Allocator MDICAPEDFAK)
	{
		return default(PFOHDIHLFKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6C28630", Offset = "0x6C27030", VA = "0x186C28630")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void MENFBKEHGFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6C28310", Offset = "0x6C26D10", VA = "0x186C28310")]
	[IgnoreWarning(1371)]
	private LOBICGOICLM LHABNIJOMAM([In] LOBICGOICLM LIBDFIAMEAD, int CLKIPHMJOLH, [In] NativeArray<int> KMBCFLOJGMJ, [In] NativeArray<bool> FAOJGPGCAKO, NativeArray<int> HCCPONDGBFO)
	{
		return default(LOBICGOICLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6C27F70", Offset = "0x6C26970", VA = "0x186C27F70")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public int CNMHLKIGBGB(NativeArray<int> KMBCFLOJGMJ, int KBNHBJMPANA, int AONFDCALEIN, int AKLLFAPDHIM)
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
		public static readonly ANDGIEDMMDP log;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static readonly ProfilerMarker LLCPJHIGANO;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private static readonly ProfilerMarker OEINFLEAKMJ;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly ProfilerMarker OOIKMGNCIBF;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly ProfilerMarker BOPKKNJPKPN;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly ProfilerMarker ECFBNJDJMFC;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static readonly ProfilerMarker CNKGHNBIMMJ;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private static readonly ProfilerMarker ABMPLNPHCCN;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		internal const int CJLICKEKGEF = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		internal static Dictionary<Material, List<Material>> LLIAHOBPOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Dictionary<Material, List<EFIBBIOHLMP>> AHEPMMBKKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal List<EFIBBIOHLMP> GIMBOKDMNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private List<MeshRenderer> BKECIKLKMED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Transform LGGLBANNEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private bool IBGMFJLJHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private bool KFOJBBDFEKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private int NCADGGLKOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private Dictionary<int, float> LIMFDPLPKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Dictionary<int, Color> DIHJKNCAFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Dictionary<int, Vector4> EPJNPNCNPED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Dictionary<int, Matrix4x4> FFMLPKCNACK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private EFIBBIOHLMP LNBNKKKJENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private Material JBCOALDCDIK;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private const int EIBFGEKNFFM = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static List<(long, Bounds, CIFAILKDFMK)> NINEBKNECBN;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<MeshRenderer> NBFJFMPFJCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int CLIDNBMKCII
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6C31020", Offset = "0x6C2FA20", VA = "0x186C31020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		private static void FNFJANCJBCN(bool GLDACGDACAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		private static void FNFJANCJBCN(bool GLDACGDACAB, string MEBLNPKEJMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D680", Offset = "0x6C2C080", VA = "0x186C2D680")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AE10", Offset = "0x6C29810", VA = "0x186C2AE10")]
		public EFIBBIOHLMP AddToBatchedMesh(CIFAILKDFMK BEDKIJNAANP, Material MLMFHAHBCEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6C300A0", Offset = "0x6C2EAA0", VA = "0x186C300A0")]
		public void RemoveFromBatchedMesh(CIFAILKDFMK ANBKEJJPIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AF10", Offset = "0x6C29910", VA = "0x186C2AF10")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6C308D0", Offset = "0x6C2F2D0", VA = "0x186C308D0")]
		public void SetMaterialProperty(int BDGIFBFMLEP, Color BLBBBKOLGJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6C30490", Offset = "0x6C2EE90", VA = "0x186C30490")]
		public void SetMaterialProperty(int BDGIFBFMLEP, float CLMKDBDPNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6C306B0", Offset = "0x6C2F0B0", VA = "0x186C306B0")]
		public void SetMaterialProperty(int BDGIFBFMLEP, Vector4 PGAPJIAFEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6C30230", Offset = "0x6C2EC30", VA = "0x186C30230")]
		public void SetMaterialProperty(int BDGIFBFMLEP, Matrix4x4 BBNPOGHGGPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2C660", Offset = "0x6C2B060", VA = "0x186C2C660")]
		private void IPLONGIBCOK(Renderer AAPNFNNCHNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B640", Offset = "0x6C2A040", VA = "0x186C2B640")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B630", Offset = "0x6C2A030", VA = "0x186C2B630")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B040", Offset = "0x6C29A40", VA = "0x186C2B040")]
		private void ECBKOJEGBAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D150", Offset = "0x6C2BB50", VA = "0x186C2D150")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BD50", Offset = "0x6C2A750", VA = "0x186C2BD50")]
		private EFIBBIOHLMP IAGPBMFGAAI(CIFAILKDFMK ANBKEJJPIHH, Material MLMFHAHBCEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CC50", Offset = "0x6C2B650", VA = "0x186C2CC50")]
		private EFIBBIOHLMP MLCCHHNCOHL(Material MLMFHAHBCEC, int EGGGKANFHMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BFF0", Offset = "0x6C2A9F0", VA = "0x186C2BFF0")]
		private EFIBBIOHLMP IDCHDCDGPIF(Material MLMFHAHBCEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BC50", Offset = "0x6C2A650", VA = "0x186C2BC50")]
		private float4x4 HBIGLJPONOK()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6C2ACF0", Offset = "0x6C296F0", VA = "0x186C2ACF0")]
		private List<Material> AOCMIFGBAGF(Material MLMFHAHBCEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xB7FFD0", Offset = "0xB7E9D0", VA = "0x180B7FFD0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CFC0", Offset = "0x6C2B9C0", VA = "0x186C2CFC0")]
		public void MarkDirty(CIFAILKDFMK ANBKEJJPIHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D2C0", Offset = "0x6C2BCC0", VA = "0x186C2D2C0")]
		public (long, long) MemorySizeInBytesForChosenDetail(float NKAKLCJAPOH)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2EE10", Offset = "0x6C2D810", VA = "0x186C2EE10")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B6E0", Offset = "0x6C2A0E0", VA = "0x186C2B6E0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D8E0", Offset = "0x6C2C2E0", VA = "0x186C2D8E0")]
		public void RebatchOptimally(int IKAEKLLFLOE, int KKCHJIOEMDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C30DB0", Offset = "0x6C2F7B0", VA = "0x186C30DB0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JMDGDHDABCN
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct ILCFMLMIJBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public float IMEAKFNIDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public BatchedMeshRenderer HCICCMMKHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public EFIBBIOHLMP LKNIOKHHMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public long GOEMPMJBHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public float EDAIDGGEFNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public bool NOBKCIIPPNK;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class HKLDCMCDOIB : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xACC530", Offset = "0xACAF30", VA = "0x180ACC530", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6C41610", Offset = "0x6C40010", VA = "0x186C41610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xC17C40", Offset = "0xC16640", VA = "0x180C17C40")]
		[DebuggerHidden]
		public HKLDCMCDOIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6C41660", Offset = "0x6C40060", VA = "0x186C41660", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6C40850", Offset = "0x6C3F250", VA = "0x186C40850", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6C40800", Offset = "0x6C3F200", VA = "0x186C40800")]
		private void GPKDFCKBEHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6C414C0", Offset = "0x6C3FEC0", VA = "0x186C414C0")]
		private void OLBNGAJNBBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6C415C0", Offset = "0x6C3FFC0", VA = "0x186C415C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6C41510", Offset = "0x6C3FF10", VA = "0x186C41510", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C41510", Offset = "0x6C3FF10", VA = "0x186C41510", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker CNKGHNBIMMJ;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static readonly ProfilerMarker FIMFOBAEHHG;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly ProfilerMarker CNEINCGFFGJ;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly ProfilerMarker AEMJIMGKNBD;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static float3 CICBPIMJNPL;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int POLBFACOPND;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static int KCMPEJIPGNK;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static int EEMEBPAALCF;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int IKIHCCFEFPP;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int DIBEPPIFEPO;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int JILIAMGNEBK;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long MFIFNMAPFBF;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static long EBEAMKLJLAC;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static int DJBJEGBMMOK;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static int PHGEFOFJLEK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static int PGFNPKKCEME;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static float LHCHKDPBHCM;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static bool BEBOGCCADEM;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public static int NHCLODCDMGM;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static float CCNKCHCMDGI;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static float GJCDKLGENFD;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static float DHEPDAGFGNK;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public static float DBFFEDKFCOG;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public static float IBDJEALJPGF;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static float OCNBFOAGOCF;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float EENGCHFDHOD;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static float KKGPLPCNLHN;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static long HEJCFJHJMJJ;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static bool BBHOPMDMAGI;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static List<BatchedMeshRenderer> HBGHFJADMPK;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static List<ILCFMLMIJBO> PJFKAMDFAMP;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static Stack<LCFLAENFPKH> JAMKCCFICFK;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static Stack<JBIFMCPAACK> BCFKPNKIKCN;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool MODEMEEAMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C419C0", Offset = "0x6C403C0", VA = "0x186C419C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void FNFJANCJBCN(bool GLDACGDACAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void ABENPELKDMI(bool GLDACGDACAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	private static void FNFJANCJBCN(bool GLDACGDACAB, string MEBLNPKEJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public static void FKBEJNBPEHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C41C20", Offset = "0x6C40620", VA = "0x186C41C20")]
	public static void DGKAKIFIJAH(BatchedMeshRenderer JMPDOKKPHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C429D0", Offset = "0x6C413D0", VA = "0x186C429D0")]
	public static void KHMMILINMCI(BatchedMeshRenderer JMPDOKKPHPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C41780", Offset = "0x6C40180", VA = "0x186C41780")]
	private static (long, long, long) ACMJLLNMEDL(long AMKEFFKOPJL)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C45CA0", Offset = "0x6C446A0", VA = "0x186C45CA0")]
	public static bool OFEIEHMNKPH(float IKGAEHKFGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C41D80", Offset = "0x6C40780", VA = "0x186C41D80")]
	public static void ELBJICNDEEG(float IKGAEHKFGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6C428C0", Offset = "0x6C412C0", VA = "0x186C428C0")]
	public static bool HFJAGFJFKJM(float IKGAEHKFGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C43440", Offset = "0x6C41E40", VA = "0x186C43440")]
	public static void OEBEECLKHIL(long AMKEFFKOPJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C421D0", Offset = "0x6C40BD0", VA = "0x186C421D0")]
	public static long FPCMOLABLEL(long PADMNPGIFNF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C41AE0", Offset = "0x6C404E0", VA = "0x186C41AE0")]
	public static void DAGLPICGGML(EFIBBIOHLMP LKNIOKHHMDN, BatchedMeshRenderer HCICCMMKHNH, long GOEMPMJBHCJ, float IMEAKFNIDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C41890", Offset = "0x6C40290", VA = "0x186C41890")]
	public static void AEALBGKFHJG(EFIBBIOHLMP LKNIOKHHMDN, BatchedMeshRenderer HCICCMMKHNH, long GOEMPMJBHCJ, float BMBPBJKDOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C430A0", Offset = "0x6C41AA0", VA = "0x186C430A0")]
	public static void NIBONKFHIBN(EFIBBIOHLMP LKNIOKHHMDN, BatchedMeshRenderer HCICCMMKHNH, long GOEMPMJBHCJ, float BMBPBJKDOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C42D30", Offset = "0x6C41730", VA = "0x186C42D30")]
	public static void MJFDEMLPLFD(EFIBBIOHLMP LKNIOKHHMDN, BatchedMeshRenderer HCICCMMKHNH, long GOEMPMJBHCJ, float KMLANHNHCOB, bool NOBKCIIPPNK, float IMEAKFNIDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C41DF0", Offset = "0x6C407F0", VA = "0x186C41DF0")]
	public static float FOFFGNNJJJK(long ICCBDLKMPBK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C45D50", Offset = "0x6C44750", VA = "0x186C45D50")]
	public static (long, long) PBDLBJEGJKK(float NKAKLCJAPOH)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C41A50", Offset = "0x6C40450", VA = "0x186C41A50")]
	[IteratorStateMachine(typeof(HKLDCMCDOIB))]
	public static IEnumerable<bool> CKPONKEDMLH(long BDLMCBPMEPH, bool MJOMKFLMOCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C425B0", Offset = "0x6C40FB0", VA = "0x186C425B0")]
	public static void GLDBBHNDBHI(long BDLMCBPMEPH, bool MJOMKFLMOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C42F60", Offset = "0x6C41960", VA = "0x186C42F60")]
	public static int MLDGAFKEBDK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6C432F0", Offset = "0x6C41CF0", VA = "0x186C432F0")]
	internal static LCFLAENFPKH OCDNLALCDLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C43260", Offset = "0x6C41C60", VA = "0x186C43260")]
	internal static void NNGCOGIJHHF(LCFLAENFPKH FDEKOBEEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6C42770", Offset = "0x6C41170", VA = "0x186C42770")]
	internal static JBIFMCPAACK HAJAKMCNMCD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C431D0", Offset = "0x6C41BD0", VA = "0x186C431D0")]
	internal static void NNGCOGIJHHF(JBIFMCPAACK GHCNMJDALHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C42560", Offset = "0x6C40F60", VA = "0x186C42560")]
	[CompilerGenerated]
	internal static void GAIKANHEALO(UnityEngine.Object GIGIFGONEAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class AHLNIOJDLPC<KeyType> : EFIBBIOHLMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly Dictionary<KeyType, CIFAILKDFMK> AGODCMIHNJD;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC830", Offset = "0x3DDB230", VA = "0x183DDC830")]
	public AHLNIOJDLPC(string HBOONHFLONJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC6C0", Offset = "0x3DDB0C0", VA = "0x183DDC6C0")]
	public void NLJICFCGPJA(KeyType JODEIIFHAPK, CIFAILKDFMK GNBDEIILEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC3A0", Offset = "0x3DDADA0", VA = "0x183DDC3A0")]
	public bool BFOHGKAMEKF(KeyType JODEIIFHAPK, CIFAILKDFMK IMFFKMJLEDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC500", Offset = "0x3DDAF00", VA = "0x183DDC500")]
	public void LGCCEKFJOHN(KeyType JODEIIFHAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3DDC4A0", Offset = "0x3DDAEA0", VA = "0x183DDC4A0", Slot = "4")]
	public override void DDMJCAEINIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C463D0", Offset = "0x6C44DD0", VA = "0x186C463D0")]
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
