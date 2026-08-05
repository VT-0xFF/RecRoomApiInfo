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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_NativeMesh_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : ADNHPIGEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7CD0", Offset = "0x6DC70D0", VA = "0x186DC7CD0", Slot = "4")]
		public override void CIGOIKFLIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class KMIPENMMJHA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly LDGDBHIGNCI BJKGLJFPCEP;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly LDGDBHIGNCI JNGGLLIJKBO;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly LDGDBHIGNCI HFJHPCNJOAN;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class EJIOBGNCPBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public ODOGJEOMOFN BHGJJKCLFGJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JJMBBDFCOFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public EJIOBGNCPBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct ODOGJEOMOFN
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct AAJAIMHEAME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public half ANCNCIBPAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ushort DLHELOFMPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public byte EIGAGINCBKE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ProfilerMarker PMPKMNGIAJA;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ProfilerMarker NFCLOOIHDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int JJMBBDFCOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int HPGKMCIBAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public NativeArray<ushort> CJBKMBMHMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<ushort> FCGBNFHNIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> HKJGHHHAKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<uint> LDDLFPFBJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<AAJAIMHEAME> LDNEEGOGGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<byte> CPKPAMELPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<byte> GELILLPLHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float3 MAGCGDDEKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float3 GFMHPBDDOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float2 JPAAFJOIHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float2 EDKDHNIJFBC;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static long KJBAJJCDFJP;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static long JOLKALECACA;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static float LPFONKLODCF;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static bool BBENLHHOBLH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FKFNLLHBIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6DD26B0", Offset = "0x6DD1AB0", VA = "0x186DD26B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NHOEDLLAGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DCE270", Offset = "0x6DCD670", VA = "0x186DCE270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD27B0", Offset = "0x6DD1BB0", VA = "0x186DD27B0")]
	public void PBEAHLLBJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6DCAF20", Offset = "0x6DCA320", VA = "0x186DCAF20")]
	public static ODOGJEOMOFN ANJEPJLHJHG(Allocator DBCOPEDFGJL, KMIFCNHLIKA PJHOPPOODKM)
	{
		return default(ODOGJEOMOFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCA9C0", Offset = "0x6DC9DC0", VA = "0x186DCA9C0")]
	public static ODOGJEOMOFN ANJEPJLHJHG(Allocator DBCOPEDFGJL, NativeArray<float3> CEGEBHIFEAP, NativeArray<float3> KOGCNFCBHGJ, NativeArray<float2> NACGFJGDFHN, NativeArray<float4> GAEPJIGJELK, bool NLLBLKMFDPL, NativeArray<float4> DJBOGFJHOIH, NativeArray<int> KLNFDDKGONC, int JJMBBDFCOFB, int AFBPDNMBFNE, int HPGKMCIBAGD, int HLNCHFBJNBN)
	{
		return default(ODOGJEOMOFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCA350", Offset = "0x6DC9750", VA = "0x186DCA350")]
	public KMIFCNHLIKA ACFLHIKOFAL(Allocator DBCOPEDFGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1630", Offset = "0x6DD0A30", VA = "0x186DD1630")]
	public void MHOHBLJLAON(Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD22B0", Offset = "0x6DD16B0", VA = "0x186DD22B0")]
	private void OBIGGAJDMDC(Mesh OHLMFEKEKFF, NativeArray<ushort> EPCKJPFGIAH, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DD28D0", Offset = "0x6DD1CD0", VA = "0x186DD28D0")]
	public void PIFBEFDPOIF(Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE710", Offset = "0x6DCDB10", VA = "0x186DCE710")]
	public void JILGLLBGCGP(Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0310", Offset = "0x6DCF710", VA = "0x186DD0310")]
	public void KNBFELCDBJH(Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC230", Offset = "0x6DCB630", VA = "0x186DCC230")]
	public void FBOMFBNDCPD(Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF570", Offset = "0x6DCE970", VA = "0x186DCF570")]
	public void JPDNGLINNEL(Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6DCA680", Offset = "0x6DC9A80", VA = "0x186DCA680")]
	public void AFPCMEJPCDL(Mesh OHLMFEKEKFF, KMIFCNHLIKA.CECKBGNLKMH BEMIADMLHDO, bool IMGOEAMFPMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6DD26F0", Offset = "0x6DD1AF0", VA = "0x186DD26F0")]
	public long OIBPLCEHOKG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD4E0", Offset = "0x6DCC8E0", VA = "0x186DCD4E0")]
	public long GLCOPMGJAKH(KMIFCNHLIKA.CECKBGNLKMH BEMIADMLHDO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDF60", Offset = "0x6DCD360", VA = "0x186DCDF60")]
	private void IDGPHFOCHGM(int MHFEFMCBKKI, int ENPJOKOLAHO, Allocator DBCOPEDFGJL, bool GGIBEFKOOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6DCFF10", Offset = "0x6DCF310", VA = "0x186DCFF10")]
	private void KIDHMJILCNP(NativeArray<float3> EICJGENLPCF, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6DBB350", Offset = "0x6DBA750", VA = "0x186DBB350")]
	[BurstCompile]
	private unsafe static void KIDHMJILCNP([NoAlias] float3* EICJGENLPCF, [In][NoAlias] ushort* CEGEBHIFEAP, int JJMBBDFCOFB, [In] float3 MAGCGDDEKJP, [In] float3 GFMHPBDDOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBB50", Offset = "0x6DCAF50", VA = "0x186DCBB50")]
	[BurstCompile]
	private unsafe static void DGOLPNOMAEF([NoAlias] KMIFCNHLIKA.EFCLCNABAFI* EICJGENLPCF, [In][NoAlias] ushort* CEGEBHIFEAP, int JJMBBDFCOFB, [In] float3 MAGCGDDEKJP, [In] float3 GFMHPBDDOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1750", Offset = "0x6DD0B50", VA = "0x186DD1750")]
	[BurstCompile]
	private unsafe static void NCNJPEOMOFA([NoAlias] KMIFCNHLIKA.HPCNKLIIGFM* EICJGENLPCF, [In][NoAlias] ushort* CEGEBHIFEAP, int JJMBBDFCOFB, [In] float3 MAGCGDDEKJP, [In] float3 GFMHPBDDOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1570", Offset = "0x6DD0970", VA = "0x186DD1570")]
	[BurstCompile]
	private unsafe static void MGDFHIFJBPJ([NoAlias] KMIFCNHLIKA.OONDMHPMHPG* EICJGENLPCF, [In][NoAlias] ushort* CEGEBHIFEAP, int JJMBBDFCOFB, [In] float3 MAGCGDDEKJP, [In] float3 GFMHPBDDOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1570", Offset = "0x6DD0970", VA = "0x186DD1570")]
	[BurstCompile]
	private unsafe static void MKDMDOAECDO([NoAlias] KMIFCNHLIKA.JDIGHCKDKBP* EICJGENLPCF, [In][NoAlias] ushort* CEGEBHIFEAP, int JJMBBDFCOFB, [In] float3 MAGCGDDEKJP, [In] float3 GFMHPBDDOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE5B0", Offset = "0x6DCD9B0", VA = "0x186DCE5B0")]
	[BurstCompile]
	private unsafe static void JELLGMAPENK([NoAlias] KMIFCNHLIKA.FEFJECGALEK* EICJGENLPCF, [In][NoAlias] ushort* CEGEBHIFEAP, int JJMBBDFCOFB, [In] float3 MAGCGDDEKJP, [In] float3 GFMHPBDDOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBC10", Offset = "0x6DCB010", VA = "0x186DCBC10")]
	private void DOGPKIGDELI(NativeArray<float3> CEGEBHIFEAP, int HLNCHFBJNBN, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6DBAF70", Offset = "0x6DBA370", VA = "0x186DBAF70")]
	[BurstCompile]
	private unsafe static void DOGPKIGDELI([NoAlias] ushort* EICJGENLPCF, [Out] float3 EIHHLHFDPBF, [Out] float3 GFMHPBDDOOI, [In][NoAlias] float3* CEGEBHIFEAP, int HLNCHFBJNBN, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB930", Offset = "0x6DCAD30", VA = "0x186DCB930")]
	private void CALDMKMEOFH(NativeArray<float3> KOGCNFCBHGJ, int HLNCHFBJNBN, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB670", Offset = "0x6DCAA70", VA = "0x186DCB670")]
	[BurstCompile]
	private unsafe static void CALDMKMEOFH([NoAlias] ushort* PLHEHJJFOOC, [In][NoAlias] float3* KOGCNFCBHGJ, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF4B0", Offset = "0x6DCE8B0", VA = "0x186DCF4B0")]
	private void JPAJGKDFLKH(NativeArray<float3> JKBDAPMJKBK, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF2B0", Offset = "0x6DCE6B0", VA = "0x186DCF2B0")]
	[BurstCompile]
	private unsafe static void JPAJGKDFLKH([NoAlias] float3* JKBDAPMJKBK, [In][NoAlias] ushort* KOGCNFCBHGJ, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD0D0", Offset = "0x6DCC4D0", VA = "0x186DCD0D0")]
	[BurstCompile]
	private unsafe static void GHIDMEDPLIO([NoAlias] KMIFCNHLIKA.EFCLCNABAFI* EICJGENLPCF, [In][NoAlias] ushort* KOGCNFCBHGJ, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1910", Offset = "0x6DD0D10", VA = "0x186DD1910")]
	[BurstCompile]
	private unsafe static void NEIGFAPGMCC([NoAlias] KMIFCNHLIKA.HPCNKLIIGFM* EICJGENLPCF, [In][NoAlias] ushort* KOGCNFCBHGJ, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBA10", Offset = "0x6DCAE10", VA = "0x186DCBA10")]
	[BurstCompile]
	private unsafe static void DAJMLPOEDNK([NoAlias] KMIFCNHLIKA.OONDMHPMHPG* EICJGENLPCF, [In][NoAlias] ushort* KOGCNFCBHGJ, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCDC0", Offset = "0x6DCC1C0", VA = "0x186DCCDC0")]
	[BurstCompile]
	private unsafe static void GEHANDNABIO([NoAlias] KMIFCNHLIKA.JDIGHCKDKBP* EICJGENLPCF, [In][NoAlias] ushort* KOGCNFCBHGJ, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2150", Offset = "0x6DD1550", VA = "0x186DD2150")]
	[BurstCompile]
	private unsafe static void NOMFHFPODAP([NoAlias] KMIFCNHLIKA.FEFJECGALEK* EICJGENLPCF, [In][NoAlias] ushort* KOGCNFCBHGJ, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD810", Offset = "0x6DCCC10", VA = "0x186DCD810")]
	private void GOLCDPPEDPM(NativeArray<float2> NACGFJGDFHN, int HLNCHFBJNBN, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD550", Offset = "0x6DCC950", VA = "0x186DCD550")]
	[BurstCompile]
	private unsafe static void GOLCDPPEDPM([NoAlias] uint* JKNBIHICBHN, [Out] float2 OHBNEFPAAGP, [Out] float2 EDKDHNIJFBC, [In][NoAlias] float2* NACGFJGDFHN, int HLNCHFBJNBN, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE570", Offset = "0x6DCD970", VA = "0x186DCE570")]
	[BurstCompile]
	private static void JBAJIPJKMCB([Out] float2 HLGOPMNMCFC, uint CDOOAAFCCNO, [In] float2 JPAAFJOIHOG, [In] float2 EDKDHNIJFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB430", Offset = "0x6DCA830", VA = "0x186DCB430")]
	private void BILCGENFPCA(NativeArray<float2> JKNBIHICBHN, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB590", Offset = "0x6DCA990", VA = "0x186DCB590")]
	[BurstCompile]
	private unsafe static void BILCGENFPCA([NoAlias] float2* JKNBIHICBHN, [NoAlias] uint* NACGFJGDFHN, int JJMBBDFCOFB, [In] float2 JPAAFJOIHOG, [In] float2 EDKDHNIJFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DD2050", Offset = "0x6DD1450", VA = "0x186DD2050")]
	[BurstCompile]
	private unsafe static void NJCNNIONEDB([NoAlias] KMIFCNHLIKA.EFCLCNABAFI* EICJGENLPCF, [NoAlias] uint* NACGFJGDFHN, int JJMBBDFCOFB, [In] float2 JPAAFJOIHOG, [In] float2 EDKDHNIJFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1150", Offset = "0x6DD0550", VA = "0x186DD1150")]
	[BurstCompile]
	private unsafe static void MCBJAHIDEIF([NoAlias] KMIFCNHLIKA.HPCNKLIIGFM* EICJGENLPCF, [NoAlias] uint* NACGFJGDFHN, int JJMBBDFCOFB, [In] float2 JPAAFJOIHOG, [In] float2 EDKDHNIJFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD900", Offset = "0x6DCCD00", VA = "0x186DCD900")]
	[BurstCompile]
	private unsafe static void HGJHCHKHLJM([NoAlias] KMIFCNHLIKA.OONDMHPMHPG* EICJGENLPCF, [NoAlias] uint* NACGFJGDFHN, int JJMBBDFCOFB, [In] float2 JPAAFJOIHOG, [In] float2 EDKDHNIJFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCB80", Offset = "0x6DCBF80", VA = "0x186DCCB80")]
	[BurstCompile]
	private unsafe static void FHIBDLNPFKN([NoAlias] KMIFCNHLIKA.JDIGHCKDKBP* EICJGENLPCF, [NoAlias] uint* NACGFJGDFHN, int JJMBBDFCOFB, [In] float2 JPAAFJOIHOG, [In] float2 EDKDHNIJFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DCF1B0", Offset = "0x6DCE5B0", VA = "0x186DCF1B0")]
	[BurstCompile]
	private unsafe static void JJKKELCNIFB([NoAlias] KMIFCNHLIKA.FEFJECGALEK* EICJGENLPCF, [NoAlias] uint* NACGFJGDFHN, int JJMBBDFCOFB, [In] float2 JPAAFJOIHOG, [In] float2 EDKDHNIJFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBF60", Offset = "0x6DCB360", VA = "0x186DCBF60")]
	private void EPNAKGJHNNC(NativeArray<float4> DJBOGFJHOIH, int HLNCHFBJNBN, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC110", Offset = "0x6DCB510", VA = "0x186DCC110")]
	[BurstCompile]
	private unsafe static void EPNAKGJHNNC([NoAlias] ushort* EDLENENOEAC, [In][NoAlias] float4* GFFFMONLIJP, int HLNCHFBJNBN, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE4E0", Offset = "0x6DCD8E0", VA = "0x186DCE4E0")]
	[BurstCompile]
	private static ushort IPDEHJAFOOI([In] float4 ACLLKMEDJFP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1020", Offset = "0x6DD0420", VA = "0x186DD1020")]
	private void LMMBFAIHCFO(NativeArray<float4> EDLENENOEAC, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0ED0", Offset = "0x6DD02D0", VA = "0x186DD0ED0")]
	[BurstCompile]
	private unsafe static void LMMBFAIHCFO([NoAlias] float4* EDLENENOEAC, [In][NoAlias] ushort* DJBOGFJHOIH, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0000", Offset = "0x6DCF400", VA = "0x186DD0000")]
	[BurstCompile]
	private unsafe static void KLGBDPPLCHP([NoAlias] KMIFCNHLIKA.EFCLCNABAFI* EICJGENLPCF, [In][NoAlias] ushort* DJBOGFJHOIH, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD24E0", Offset = "0x6DD18E0", VA = "0x186DD24E0")]
	[BurstCompile]
	private unsafe static void ODJNGJNHMPG([NoAlias] KMIFCNHLIKA.HPCNKLIIGFM* EICJGENLPCF, [In][NoAlias] ushort* DJBOGFJHOIH, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBDA0", Offset = "0x6DCB1A0", VA = "0x186DCBDA0")]
	[BurstCompile]
	private unsafe static void EPLHCBDHACN([NoAlias] KMIFCNHLIKA.OONDMHPMHPG* EICJGENLPCF, [In][NoAlias] ushort* DJBOGFJHOIH, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDAF0", Offset = "0x6DCCEF0", VA = "0x186DCDAF0")]
	[BurstCompile]
	private unsafe static void HLJBPPNALBG([NoAlias] KMIFCNHLIKA.JDIGHCKDKBP* EICJGENLPCF, [In][NoAlias] ushort* DJBOGFJHOIH, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE2B0", Offset = "0x6DCD6B0", VA = "0x186DCE2B0")]
	[BurstCompile]
	private unsafe static void INMNDFFJNMB([NoAlias] KMIFCNHLIKA.FEFJECGALEK* EICJGENLPCF, [In][NoAlias] ushort* DJBOGFJHOIH, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD36A0", Offset = "0x6DD2AA0", VA = "0x186DD36A0")]
	[BurstCompile]
	private static void PPOCAIODBHM([Out] float4 HCMJFDLGOJF, ushort CDOOAAFCCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DD30E0", Offset = "0x6DD24E0", VA = "0x186DD30E0")]
	private void PPDEAJJKOOI(Allocator DBCOPEDFGJL, NativeArray<float4> GAEPJIGJELK, int HLNCHFBJNBN, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DD34E0", Offset = "0x6DD28E0", VA = "0x186DD34E0")]
	[BurstCompile]
	private unsafe static void PPDEAJJKOOI([NoAlias] float4* JPHDIHGABHF, [NoAlias] byte* EJGKGLFNNFG, [Out] int HMPLGDKICDJ, [Out] int AAPKDNNPIFC, [NoAlias] float4* GAEPJIGJELK, int HLNCHFBJNBN, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1390", Offset = "0x6DD0790", VA = "0x186DD1390")]
	private static void MEINOKIPAOJ(NativeArray<float4> GJEBNEKDOKH, NativeArray<AAJAIMHEAME> CIILLNJOCMG, NativeArray<byte> GNAIBICJPEL, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1250", Offset = "0x6DD0650", VA = "0x186DD1250")]
	[BurstCompile]
	private unsafe static void MEINOKIPAOJ([NoAlias] float4* GJEBNEKDOKH, [In][NoAlias] AAJAIMHEAME* CIILLNJOCMG, [In][NoAlias] byte* GNAIBICJPEL, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6DCE090", Offset = "0x6DCD490", VA = "0x186DCE090")]
	[BurstCompile]
	private unsafe static void IJHHLDLAFMI([NoAlias] KMIFCNHLIKA.EFCLCNABAFI* EICJGENLPCF, [In][NoAlias] AAJAIMHEAME* CIILLNJOCMG, [In][NoAlias] byte* GNAIBICJPEL, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD300", Offset = "0x6DCC700", VA = "0x186DCD300")]
	[BurstCompile]
	private unsafe static void GILHKBKNKDF([NoAlias] KMIFCNHLIKA.HPCNKLIIGFM* EICJGENLPCF, [In][NoAlias] AAJAIMHEAME* CIILLNJOCMG, [In][NoAlias] byte* GNAIBICJPEL, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6DD0CF0", Offset = "0x6DD00F0", VA = "0x186DD0CF0")]
	[BurstCompile]
	private unsafe static void LEANBCEGLOL([NoAlias] KMIFCNHLIKA.OONDMHPMHPG* EICJGENLPCF, [In][NoAlias] AAJAIMHEAME* CIILLNJOCMG, [In][NoAlias] byte* GNAIBICJPEL, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDD20", Offset = "0x6DCD120", VA = "0x186DCDD20")]
	[BurstCompile]
	private unsafe static void ICJCIBDBEBN([NoAlias] KMIFCNHLIKA.JDIGHCKDKBP* EICJGENLPCF, [In][NoAlias] AAJAIMHEAME* CIILLNJOCMG, [In][NoAlias] byte* GNAIBICJPEL, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB1F0", Offset = "0x6DCA5F0", VA = "0x186DCB1F0")]
	[BurstCompile]
	private unsafe static void BDOABHPKMDA([NoAlias] KMIFCNHLIKA.FEFJECGALEK* EICJGENLPCF, [In][NoAlias] AAJAIMHEAME* CIILLNJOCMG, [In][NoAlias] byte* GNAIBICJPEL, int JJMBBDFCOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1810", Offset = "0x6DD0C10", VA = "0x186DD1810")]
	private void NDKADODGAAD(Allocator DBCOPEDFGJL, NativeArray<int> KLNFDDKGONC, int HLNCHFBJNBN, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1D10", Offset = "0x6DD1110", VA = "0x186DD1D10")]
	private static NativeArray<byte> NIIGALKPJIA(Allocator DBCOPEDFGJL, NativeArray<int> KLNFDDKGONC, int DABJAOGLPID)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1C10", Offset = "0x6DD1010", VA = "0x186DD1C10")]
	[BurstCompile]
	private unsafe static int NIIGALKPJIA([NoAlias] byte* FOHKLPHCNHH, [In][NoAlias] int* KLNFDDKGONC, int DABJAOGLPID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1AF0", Offset = "0x6DD0EF0", VA = "0x186DD1AF0")]
	private static void NHAEDBPPKMP(NativeArray<int> KGIAHKEJMED, NativeArray<byte> FOADFGAGEDM, int HPGKMCIBAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DD1A50", Offset = "0x6DD0E50", VA = "0x186DD1A50")]
	[BurstCompile]
	private unsafe static void NHAEDBPPKMP([NoAlias] int* KGIAHKEJMED, [In][NoAlias] byte* FOADFGAGEDM, int HPGKMCIBAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBD00", Offset = "0x6DCB100", VA = "0x186DCBD00")]
	[BurstCompile]
	private unsafe static void EHLBOFOFDOL([NoAlias] ushort* KGIAHKEJMED, [In][NoAlias] byte* FOADFGAGEDM, int HPGKMCIBAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCC80", Offset = "0x6DCC080", VA = "0x186DCCC80")]
	[BurstCompile]
	private static void FMOMEAKGGAD([Out] float3 HLGOPMNMCFC, ushort CDOOAAFCCNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCF10", Offset = "0x6DCC310", VA = "0x186DCCF10")]
	[BurstCompile]
	private static ushort GGEPGPIJOMC([In] float3 ACLLKMEDJFP)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BurstCompile]
public class KMIFCNHLIKA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum CECKBGNLKMH
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
	public enum PMFMFDJKGJE
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
	public struct IHNGKCFGCDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public CECKBGNLKMH BEMIADMLHDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool KDMHNHPHMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int APFCHKPLGDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public VertexAttributeDescriptor[] KGNFGABDKPN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[BurstCompile]
	public struct JMHLNHNLCBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3 OGKCMCMHLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float3 HAGCLANLPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float4 DDAAOLNLDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float2 MEFCEMIKOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float4 LDNEEGOGGCI;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly VertexAttributeDescriptor[] KGNFGABDKPN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[BurstCompile]
	public struct EFCLCNABAFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float3 OGKCMCMHLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half4 HAGCLANLPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half4 DDAAOLNLDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float2 MEFCEMIKOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 LDNEEGOGGCI;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly VertexAttributeDescriptor[] KGNFGABDKPN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[BurstCompile]
	public struct HPCNKLIIGFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float3 OGKCMCMHLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public uint HAGCLANLPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public uint DDAAOLNLDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float2 MEFCEMIKOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half4 LDNEEGOGGCI;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly VertexAttributeDescriptor[] KGNFGABDKPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[BurstCompile]
	public struct OONDMHPMHPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float3 OGKCMCMHLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public uint HAGCLANLPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public uint DDAAOLNLDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 MEFCEMIKOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 LDNEEGOGGCI;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly VertexAttributeDescriptor[] KGNFGABDKPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[BurstCompile]
	public struct JDIGHCKDKBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float3 OGKCMCMHLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public uint PMGCJDIKCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float2 MEFCEMIKOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public uint KFIDBKKNMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public uint PPOJIKJFEPI;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly VertexAttributeDescriptor[] KGNFGABDKPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile]
	public struct FEFJECGALEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public FLPJINOLGHP.JPEBLJCNKNA JCEMOMNMCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint PMGCJDIKCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float2 MEFCEMIKOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public uint KFIDBKKNMPO;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly VertexAttributeDescriptor[] KGNFGABDKPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int MNNILIDLKGC(float KPPEBBOFEKD);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class MDBKKJIAMCO
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr AMFDKPHIKJM;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr PEHBCLMGEHN;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6DC7EF0", Offset = "0x6DC72F0", VA = "0x186DC7EF0")]
		[BurstDiscard]
		private static void HHINNAJKKLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8340", Offset = "0x6DC7740", VA = "0x186DC8340")]
		private static IntPtr PHGCBNNEOGN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8290", Offset = "0x6DC7690", VA = "0x186DC8290")]
		public static void KDHCDKMGDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public static void NOCOEJHJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8020", Offset = "0x6DC7420", VA = "0x186DC8020")]
		public static int IIFNBMCHKOM(float KPPEBBOFEKD)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate uint OMLDDLNJJMN([In] float4 FCBPGONDPJI);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class GPKLNLCNMLC
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr AMFDKPHIKJM;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr PEHBCLMGEHN;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6DBEB30", Offset = "0x6DBDF30", VA = "0x186DBEB30")]
		[BurstDiscard]
		private static void HHINNAJKKLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6DBF050", Offset = "0x6DBE450", VA = "0x186DBF050")]
		private static IntPtr PHGCBNNEOGN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6DBEFA0", Offset = "0x6DBE3A0", VA = "0x186DBEFA0")]
		public static void KDHCDKMGDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public static void NOCOEJHJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6DBEC60", Offset = "0x6DBE060", VA = "0x186DBEC60")]
		public static uint IIFNBMCHKOM([In] float4 FCBPGONDPJI)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate uint FFIIMCOPECN([In] float3 FCBPGONDPJI);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class OOCCGENEGMH
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr AMFDKPHIKJM;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr PEHBCLMGEHN;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3F80", Offset = "0x6DD3380", VA = "0x186DD3F80")]
		[BurstDiscard]
		private static void HHINNAJKKLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6DD43E0", Offset = "0x6DD37E0", VA = "0x186DD43E0")]
		private static IntPtr PHGCBNNEOGN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD4330", Offset = "0x6DD3730", VA = "0x186DD4330")]
		public static void KDHCDKMGDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public static void NOCOEJHJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6DD40B0", Offset = "0x6DD34B0", VA = "0x186DD40B0")]
		public static uint IIFNBMCHKOM([In] float3 FCBPGONDPJI)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void MPDBAFMAPCA([NoAlias] HPCNKLIIGFM* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class PNPOMHFPJHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr AMFDKPHIKJM;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr PEHBCLMGEHN;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6C90", Offset = "0x6DD6090", VA = "0x186DD6C90")]
		[BurstDiscard]
		private static void HHINNAJKKLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6DD70B0", Offset = "0x6DD64B0", VA = "0x186DD70B0")]
		private static IntPtr PHGCBNNEOGN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6DD7000", Offset = "0x6DD6400", VA = "0x186DD7000")]
		public static void KDHCDKMGDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public static void NOCOEJHJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6DD6DC0", Offset = "0x6DD61C0", VA = "0x186DD6DC0")]
		public unsafe static void IIFNBMCHKOM([NoAlias] HPCNKLIIGFM* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void KEBPBAGAHEO([NoAlias] OONDMHPMHPG* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class NELGJGMGIFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr AMFDKPHIKJM;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr PEHBCLMGEHN;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9DD0", Offset = "0x6DC91D0", VA = "0x186DC9DD0")]
		[BurstDiscard]
		private static void HHINNAJKKLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA1F0", Offset = "0x6DC95F0", VA = "0x186DCA1F0")]
		private static IntPtr PHGCBNNEOGN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6DCA140", Offset = "0x6DC9540", VA = "0x186DCA140")]
		public static void KDHCDKMGDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public static void NOCOEJHJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6DC9F00", Offset = "0x6DC9300", VA = "0x186DC9F00")]
		public unsafe static void IIFNBMCHKOM([NoAlias] OONDMHPMHPG* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void GFNIHIIECMB([NoAlias] JDIGHCKDKBP* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class OJHBJEEHNHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr AMFDKPHIKJM;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr PEHBCLMGEHN;

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3850", Offset = "0x6DD2C50", VA = "0x186DD3850")]
		[BurstDiscard]
		private static void HHINNAJKKLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3E20", Offset = "0x6DD3220", VA = "0x186DD3E20")]
		private static IntPtr PHGCBNNEOGN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3D70", Offset = "0x6DD3170", VA = "0x186DD3D70")]
		public static void KDHCDKMGDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public static void NOCOEJHJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6DD3980", Offset = "0x6DD2D80", VA = "0x186DD3980")]
		public unsafe static void IIFNBMCHKOM([NoAlias] JDIGHCKDKBP* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void MHMODAFGMMN([NoAlias] FEFJECGALEK* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI, [Out] float3 FEEFAJFKFAP, [Out] float3 LBDAEAEEIJE);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class GILACMCKIJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr AMFDKPHIKJM;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr PEHBCLMGEHN;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE290", Offset = "0x6DBD690", VA = "0x186DBE290")]
		[BurstDiscard]
		private static void HHINNAJKKLB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE9D0", Offset = "0x6DBDDD0", VA = "0x186DBE9D0")]
		private static IntPtr PHGCBNNEOGN()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE920", Offset = "0x6DBDD20", VA = "0x186DBE920")]
		public static void KDHCDKMGDON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public static void NOCOEJHJFAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6DBE3C0", Offset = "0x6DBD7C0", VA = "0x186DBE3C0")]
		public unsafe static void IIFNBMCHKOM([NoAlias] FEFJECGALEK* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI, [Out] float3 FEEFAJFKFAP, [Out] float3 LBDAEAEEIJE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int AEPEFMOOHKL = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeList<float3> OPCKCNPCGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<float3> DGEHJPOOIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<float4> JHICLBDAICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<float4> FCKEHPPKBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<float2> KCIHACHEDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeList<int> CHCKHCIJNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly VertexAttributeDescriptor[][] KPENBDGLMAL;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static bool DMCCJHHLAPL;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static IHNGKCFGCDE[] APPGFGKFABG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FKFNLLHBIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6DC65C0", Offset = "0x6DC59C0", VA = "0x186DC65C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CGHKBDLAPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3920", Offset = "0x6DC2D20", VA = "0x186DC3920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BAINBALNHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3170", Offset = "0x6DC2570", VA = "0x186DC3170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NHOEDLLAGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6DC3960", Offset = "0x6DC2D60", VA = "0x186DC3960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2FC0", Offset = "0x6DC23C0", VA = "0x186DC2FC0")]
	public static PMFMFDJKGJE GGLNDIIPIPH(CECKBGNLKMH BEMIADMLHDO)
	{
		return default(PMFMFDJKGJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6AB0", Offset = "0x6DC5EB0", VA = "0x186DC6AB0")]
	public static void ONCKIJHKABC(PMFMFDJKGJE IFLPKLPAFJE, Material JAEJMKKLMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1CD0", Offset = "0x6DC10D0", VA = "0x186DC1CD0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3650", Offset = "0x6DC2A50", VA = "0x186DC3650")]
	public void IDGPHFOCHGM(int MHFEFMCBKKI, int ENPJOKOLAHO, Allocator DBCOPEDFGJL, bool MIAHKEEBMME, bool GGIBEFKOOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6DC7720", Offset = "0x6DC6B20", VA = "0x186DC7720")]
	public void PMHNDNMDLEP(int MHFEFMCBKKI, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4AF0", Offset = "0x6DC3EF0", VA = "0x186DC4AF0", Slot = "6")]
	public bool KKPBIAEOLJF(Mesh OHLMFEKEKFF, bool DCNNHAPMEPO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5220", Offset = "0x6DC4620", VA = "0x186DC5220")]
	public bool MHOHBLJLAON(Mesh OHLMFEKEKFF, bool DCNNHAPMEPO, bool IMGOEAMFPMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6DC60C0", Offset = "0x6DC54C0", VA = "0x186DC60C0")]
	public bool NFLMKLOOOLF(Mesh OHLMFEKEKFF, KMIFCNHLIKA NBLBJJHOKOB, bool DCNNHAPMEPO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3490", Offset = "0x6DC2890", VA = "0x186DC3490")]
	public bool HNGKCEJIJDH(Mesh OHLMFEKEKFF, KMIFCNHLIKA NBLBJJHOKOB, CECKBGNLKMH BEMIADMLHDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5620", Offset = "0x6DC4A20", VA = "0x186DC5620")]
	private void NEIJCJKOGGG(Mesh OHLMFEKEKFF, KMIFCNHLIKA NBLBJJHOKOB, bool IMGOEAMFPMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6DC5DB0", Offset = "0x6DC51B0", VA = "0x186DC5DB0")]
	public void NEIJCJKOGGG(NativeArray<ushort> CGNFEBBPDIO, NativeArray<JDIGHCKDKBP> ABMNPKHDKLM, Mesh OHLMFEKEKFF, KMIFCNHLIKA NBLBJJHOKOB, bool IMGOEAMFPMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6CE0", Offset = "0x6DC60E0", VA = "0x186DC6CE0")]
	public void PIFBEFDPOIF(Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3560", Offset = "0x6DC2960", VA = "0x186DC3560")]
	[BurstCompile]
	public static int IAKAPIJEOGA(float KPPEBBOFEKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6DC35B0", Offset = "0x6DC29B0", VA = "0x186DC35B0")]
	[BurstCompile]
	public static uint IAKAPIJEOGA([In] float4 FCBPGONDPJI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3600", Offset = "0x6DC2A00", VA = "0x186DC3600")]
	[BurstCompile]
	public static uint IAKAPIJEOGA([In] float3 FCBPGONDPJI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6DC39A0", Offset = "0x6DC2DA0", VA = "0x186DC39A0")]
	public void JILGLLBGCGP(Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4030", Offset = "0x6DC3430", VA = "0x186DC4030")]
	[BurstCompile]
	private unsafe static void JLMOPEPMBKI([NoAlias] HPCNKLIIGFM* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6DC4B10", Offset = "0x6DC3F10", VA = "0x186DC4B10")]
	public void KNBFELCDBJH(Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6B70", Offset = "0x6DC5F70", VA = "0x186DC6B70")]
	[BurstCompile]
	private unsafe static void OOGGDNHLOBN([NoAlias] OONDMHPMHPG* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6DC20B0", Offset = "0x6DC14B0", VA = "0x186DC20B0")]
	public void FBOMFBNDCPD(Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2480", Offset = "0x6DC1880", VA = "0x186DC2480")]
	public void FBOMFBNDCPD(NativeArray<ushort> EPCKJPFGIAH, NativeArray<JDIGHCKDKBP> FGLMDOBFNPP, Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6DC51A0", Offset = "0x6DC45A0", VA = "0x186DC51A0")]
	[BurstCompile]
	public unsafe static void MGJFJDFLBHJ([NoAlias] JDIGHCKDKBP* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC40B0", Offset = "0x6DC34B0", VA = "0x186DC40B0")]
	public void JPDNGLINNEL(Mesh OHLMFEKEKFF, bool IMGOEAMFPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6BF0", Offset = "0x6DC5FF0", VA = "0x186DC6BF0")]
	[BurstCompile]
	private unsafe static void PDAJHPEEAKB([NoAlias] FEFJECGALEK* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI, [Out] float3 FEEFAJFKFAP, [Out] float3 LBDAEAEEIJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1050", Offset = "0x6DC0450", VA = "0x186DC1050")]
	public void AFPCMEJPCDL(Mesh OHLMFEKEKFF, CECKBGNLKMH BEMIADMLHDO, bool IMGOEAMFPMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1DE0", Offset = "0x6DC11E0", VA = "0x186DC1DE0")]
	public void EJPACLHODAH(KMIFCNHLIKA OHLMFEKEKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6DC47F0", Offset = "0x6DC3BF0", VA = "0x186DC47F0")]
	public void KBHLJJFJBPN(KMIFCNHLIKA LHOBDGJGOHD, Allocator DBCOPEDFGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6660", Offset = "0x6DC5A60", VA = "0x186DC6660")]
	public long OIBPLCEHOKG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6600", Offset = "0x6DC5A00", VA = "0x186DC6600")]
	public static long OIBPLCEHOKG(int IAGDPCEJDGB, int CIJINPLMCEC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6DC30D0", Offset = "0x6DC24D0", VA = "0x186DC30D0")]
	public static long GLCOPMGJAKH(int IAGDPCEJDGB, int CIJINPLMCEC, CECKBGNLKMH BEMIADMLHDO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3010", Offset = "0x6DC2410", VA = "0x186DC3010")]
	public long GLCOPMGJAKH(CECKBGNLKMH BEMIADMLHDO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2050", Offset = "0x6DC1450", VA = "0x186DC2050")]
	public void EKGCBJPCBPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6DC67B0", Offset = "0x6DC5BB0", VA = "0x186DC67B0")]
	public static void OMKHOIMHPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6DC1570", Offset = "0x6DC0970", VA = "0x186DC1570")]
	public CECKBGNLKMH DPDEGGAMKMJ()
	{
		return default(CECKBGNLKMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6DC14A0", Offset = "0x6DC08A0", VA = "0x186DC14A0")]
	public static (int, int) DJJJGBOAFGA(Mesh OHLMFEKEKFF)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3840", Offset = "0x6DC2C40", VA = "0x186DC3840")]
	public static int IHGCJPIJCOJ(VertexAttributeDescriptor[] HOJNJBCDKLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6DC6C70", Offset = "0x6DC6070", VA = "0x186DC6C70")]
	public static long PDFGFFIIBBB(Mesh OHLMFEKEKFF, int IOLJGIFBGKJ, int FCBHNKDCADF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public KMIFCNHLIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6DC31B0", Offset = "0x6DC25B0", VA = "0x186DC31B0")]
	[BurstCompile]
	public static int HIOBEGFINKO(float KPPEBBOFEKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3300", Offset = "0x6DC2700", VA = "0x186DC3300")]
	[BurstCompile]
	public static uint HIOBEGFINKO([In] float4 FCBPGONDPJI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC3250", Offset = "0x6DC2650", VA = "0x186DC3250")]
	[BurstCompile]
	public static uint HIOBEGFINKO([In] float3 FCBPGONDPJI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DC10E0", Offset = "0x6DC04E0", VA = "0x186DC10E0")]
	[BurstCompile]
	public unsafe static void CJAICGFPGOH([NoAlias] HPCNKLIIGFM* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2830", Offset = "0x6DC1C30", VA = "0x186DC2830")]
	[BurstCompile]
	public unsafe static void FECKLBCHMHG([NoAlias] OONDMHPMHPG* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DC48F0", Offset = "0x6DC3CF0", VA = "0x186DC48F0")]
	[BurstCompile]
	public unsafe static void KKMIMELJLEN([NoAlias] JDIGHCKDKBP* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DC2C80", Offset = "0x6DC2080", VA = "0x186DC2C80")]
	[BurstCompile]
	public unsafe static void FMPBKNKLIGJ([NoAlias] FEFJECGALEK* EICJGENLPCF, int JJMBBDFCOFB, [In][NoAlias] float3* AEJPGHGNHOG, [In][NoAlias] float3* FCGBNFHNIJJ, [In][NoAlias] float4* HKJGHHHAKHK, [In][NoAlias] float2* LDDLFPFBJPG, [In][NoAlias] float4* LDNEEGOGGCI, [Out] float3 FEEFAJFKFAP, [Out] float3 LBDAEAEEIJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct EGNNDCACJPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int JEKMANPMOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 AEGHBALNIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public quaternion HEONEJGLLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 KGIHBHPJOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int NOGBAHLMMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int HNPECLDCLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int LFGCNDIPMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float NBBLLKBEIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 LODFBHHFNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool LHIIJPBJFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public CJMFAEJDJMH POLPKAKGODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 IKIKADLGJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float PPKLPCLKGLO;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class CAPLDBHNLDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static HFGDPFDNLFO FDGBDJKPHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<EGNNDCACJPA> CCPCABLOOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<IADHCANKFMA> CKGFODNOKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<FHOLELOMBBL> IOLBKPJPBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<HPBGCJLBAIH> KEJEPKHONLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<IADHCANKFMA> LAOLJMONOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeList<ONNBHILKIHG> FPBCBLPCOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeArray<HPBGCJLBAIH>> AEMOPOEAOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<KKBFCKNOONG> GBGMFPEALEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<int> LMDGEALPIGP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CGHKBDLAPID
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9713B0", Offset = "0x9707B0", VA = "0x1809713B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x96F5D0", Offset = "0x96E9D0", VA = "0x18096F5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int BAINBALNHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9713A0", Offset = "0x9707A0", VA = "0x1809713A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9700F0", Offset = "0x96F4F0", VA = "0x1809700F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDA90", Offset = "0x6DBCE90", VA = "0x186DBDA90")]
	public CAPLDBHNLDF(int IHIIAMFIKJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBD40", Offset = "0x6DBB140", VA = "0x186DBBD40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6DBD8C0", Offset = "0x6DBCCC0", VA = "0x186DBD8C0")]
	public void PBEAHLLBJJI(JobHandle NCIJHBALCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC650", Offset = "0x6DBBA50", VA = "0x186DBC650")]
	public void MIILPOHDHKL(EGNNDCACJPA EIFGKHNPLEK, KKBFCKNOONG MLEEFKBIBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC1B0", Offset = "0x6DBB5B0", VA = "0x186DBC1B0")]
	public void EJBNECACMMM(FHOLELOMBBL EIFGKHNPLEK, NativeArray<HPBGCJLBAIH> GNGGAEAHINN, int JJMBBDFCOFB, int HPGKMCIBAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC880", Offset = "0x6DBBC80", VA = "0x186DBC880")]
	public JobHandle OBOLPBCCGOB(KMIFCNHLIKA MAJHOIBIGAB, OCOANHMKNKA GOLHPPKBDDC, float3 HODCIJHILKJ, quaternion KFMIGGFKEHO, float LHCMCBMFPPO, bool IJMDBFJFCLC, int BLKIJMPKHOC = 0, int PCDKNDNGEAP = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6DBC310", Offset = "0x6DBB710", VA = "0x186DBC310")]
	public static JobHandle ICJDEAGOCGC(ELGJKGHBFLN PFGENKHOPNH, KMIFCNHLIKA MAJHOIBIGAB, EGNNDCACJPA EIFGKHNPLEK, JobHandle NCIJHBALCJA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6DBBF00", Offset = "0x6DBB300", VA = "0x186DBBF00")]
	public static JobHandle EEMOIPDFPCO(PFENPGOPGKD PFGENKHOPNH, KMIFCNHLIKA MAJHOIBIGAB, FHOLELOMBBL EIFGKHNPLEK, NativeArray<HPBGCJLBAIH> GNGGAEAHINN, int JJMBBDFCOFB, int HPGKMCIBAGD, JobHandle NCIJHBALCJA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct FHJEKJFOIFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float2 GPBKFOICKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float2 GIMIAIDDGOD;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ILPILPFMBNB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeArray<FHJEKJFOIFO> BDLEBDFLOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeArray<int> FLILFJGBEJA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CGHKBDLAPID
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x89FC40", Offset = "0x89F040", VA = "0x18089FC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BAINBALNHCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8A6040", Offset = "0x8A5440", VA = "0x1808A6040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0C50", Offset = "0x6DC0050", VA = "0x186DC0C50")]
	public ILPILPFMBNB(int MHFEFMCBKKI, int ENPJOKOLAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0B10", Offset = "0x6DBFF10", VA = "0x186DC0B10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0B70", Offset = "0x6DBFF70", VA = "0x186DC0B70")]
	public void EJPACLHODAH(ILPILPFMBNB MHMMFLPBCCF, int NNMCFEDJAAJ, int PNGCLOMDHAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class NAAGHOCKNKH
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static ILPILPFMBNB ADNBBHLEEHM;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static NativeList<IADHCANKFMA> FGJAIJMMPNJ;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int[] DBJBFMGCGNH;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static bool EDCMOLEENOO;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static Dictionary<int, ILPILPFMBNB> GBEDLBHIJHP;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static Dictionary<int, ILPILPFMBNB> HGABEFCFAEK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool AHOALOBHGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8E90", Offset = "0x6DC8290", VA = "0x186DC8E90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<IADHCANKFMA> LNGGLOMLINK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8DF0", Offset = "0x6DC81F0", VA = "0x186DC8DF0")]
		get
		{
			return default(NativeList<IADHCANKFMA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static ILPILPFMBNB IDFFBFMCFCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6DC93C0", Offset = "0x6DC87C0", VA = "0x186DC93C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9460", Offset = "0x6DC8860", VA = "0x186DC9460")]
	private static void MPLEOPDGJOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9BB0", Offset = "0x6DC8FB0", VA = "0x186DC9BB0")]
	public static int NCMHGOFPPIG(bool NLJICBGFHCG, int CKHACIIHGOO, bool ONEKNBBHPGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8DD0", Offset = "0x6DC81D0", VA = "0x186DC8DD0")]
	private static int HDGAGLPIDDL(int CKHACIIHGOO, bool NJDLBLOAPEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8D10", Offset = "0x6DC8110", VA = "0x186DC8D10")]
	private static int FDAFCHPGDJN(int CKHACIIHGOO, bool NJDLBLOAPEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6DC88E0", Offset = "0x6DC7CE0", VA = "0x186DC88E0")]
	public static int AKHFFPELKKF(int BGHMMFOMOHD, int CKHACIIHGOO, int AJHIOBOIPFJ, bool NJDLBLOAPEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9320", Offset = "0x6DC8720", VA = "0x186DC9320")]
	public static int LCJPGFIEMEJ(int BGHMMFOMOHD, int CKHACIIHGOO, int AJHIOBOIPFJ, bool NJDLBLOAPEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9BE0", Offset = "0x6DC8FE0", VA = "0x186DC9BE0")]
	public static int NJMNINCBOLH(int AJHIOBOIPFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6DC93B0", Offset = "0x6DC87B0", VA = "0x186DC93B0")]
	private static int LDLLEEIHFGG(int CKHACIIHGOO, bool NJDLBLOAPEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8970", Offset = "0x6DC7D70", VA = "0x186DC8970")]
	private static int ALACBGHANGE(int CKHACIIHGOO, bool NJDLBLOAPEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9BF0", Offset = "0x6DC8FF0", VA = "0x186DC9BF0")]
	public static int PKIKIJFCFMH(int BGHMMFOMOHD, int CKHACIIHGOO, int AJHIOBOIPFJ, bool NJDLBLOAPEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8D20", Offset = "0x6DC8120", VA = "0x186DC8D20")]
	public static int GAHOIHLGLED(int BGHMMFOMOHD, int CKHACIIHGOO, int AJHIOBOIPFJ, bool NJDLBLOAPEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8DB0", Offset = "0x6DC81B0", VA = "0x186DC8DB0")]
	public static int GOJEKNIIDDN(int AJHIOBOIPFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9AC0", Offset = "0x6DC8EC0", VA = "0x186DC9AC0")]
	public static ILPILPFMBNB NBAGHFJNHLO(int CKHACIIHGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8A80", Offset = "0x6DC7E80", VA = "0x186DC8A80")]
	private static ILPILPFMBNB ENPJJFOLAAF(int CKHACIIHGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8990", Offset = "0x6DC7D90", VA = "0x186DC8990")]
	public static ILPILPFMBNB BNHHDIIMHPC(int CKHACIIHGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6DC85A0", Offset = "0x6DC79A0", VA = "0x186DC85A0")]
	private static ILPILPFMBNB AHIBGKPOFGC(int CKHACIIHGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8F10", Offset = "0x6DC8310", VA = "0x186DC8F10")]
	public static void JJHBPEBHDLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct FHOLELOMBBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public int EKHBFLHEHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 AEGHBALNIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public quaternion HEONEJGLLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float KGIHBHPJOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float MMCDPDDEMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int NOGBAHLMMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int HNPECLDCLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int LFGCNDIPMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool POFOKMHPHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool APCIJCBMNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public float NBBLLKBEIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float3 LODFBHHFNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool ALDJEMGMHGI;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct ONNBHILKIHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public int CLOFKPEJCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public int PKMKJIJLPHC;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct PFENPGOPGKD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeList<FHOLELOMBBL> PNDFAPFNMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<HPBGCJLBAIH> DCGLFBKBNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<IADHCANKFMA> LMKLALMFCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeArray<ONNBHILKIHG> LFMLPKPDMHE;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4800", Offset = "0x6DD3C00", VA = "0x186DD4800")]
	public PFENPGOPGKD(NativeArray<HPBGCJLBAIH> DCGLFBKBNPB, int JKIIGJDNBMO = 1, Allocator DBCOPEDFGJL = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4710", Offset = "0x6DD3B10", VA = "0x186DD4710", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
public struct PMGPEHBPEBP : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private NativeArray<FHJEKJFOIFO> GEOLIKBNIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[ReadOnly]
	private NativeArray<int> JFCJGDGHHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[ReadOnly]
	private NativeList<IADHCANKFMA> JODLHJEIIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<FHOLELOMBBL> PNDFAPFNMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<HPBGCJLBAIH> DCGLFBKBNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeArray<IADHCANKFMA> LMKLALMFCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	public NativeArray<ONNBHILKIHG> LFMLPKPDMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private int CLBGMPBFEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private int CDPIEDMFGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private float3 DGGMNECIOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private quaternion AMADHKKGDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private float3 FBFAIJGPJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> HDECFCOLPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OBHJNHBIJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CFLMCNLANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EAGFMIMDDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> KHBLDAOEFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BGKLMHBGCPJ;

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6A00", Offset = "0x6DD5E00", VA = "0x186DD6A00")]
	public PMGPEHBPEBP(CAPLDBHNLDF KALJMDCABDE, KMIFCNHLIKA PLPEIMHIMMC, float3 JLCNNMCIENC, quaternion JAIIDKOFBBG, float OJJPNKJGNID, int BLKIJMPKHOC = 0, int PCDKNDNGEAP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6DD67D0", Offset = "0x6DD5BD0", VA = "0x186DD67D0")]
	public PMGPEHBPEBP(PFENPGOPGKD KALJMDCABDE, KMIFCNHLIKA PLPEIMHIMMC, float3 JLCNNMCIENC, quaternion JAIIDKOFBBG, float3 OJJPNKJGNID, int BLKIJMPKHOC = 0, int PCDKNDNGEAP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4930", Offset = "0x6DD3D30", VA = "0x186DD4930")]
	private float3 AFONAKNNDKC(float3 DPALLLKKHLC, Matrix4x4 ALFFECMLDPO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4EB0", Offset = "0x6DD42B0", VA = "0x186DD4EB0")]
	private float3x3 CDPOJCLONOC(float3x3 OGHKCPHHJCN, float3x3 KBFHADOKIMH)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4F30", Offset = "0x6DD4330", VA = "0x186DD4F30")]
	private float CHDHPIOKHHE(float EAEIAKHGPAC, float ONPAGBLEHEH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6DD50B0", Offset = "0x6DD44B0", VA = "0x186DD50B0", Slot = "4")]
	public void Execute(int CMANFNLPJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4F40", Offset = "0x6DD4340", VA = "0x186DD4F40")]
	private void DLIENEGPEFF(int LOKCINAPPGD, float3 OGKCMCMHLOD, float3 HAGCLANLPAD, float3 DDAAOLNLDGA, float JBJFBPBLEOH, bool FGEPICADOPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4A70", Offset = "0x6DD3E70", VA = "0x186DD4A70")]
	private void BKIGFGGBOHF(FHOLELOMBBL NKAAOLBAMOB, float3 MJEPAHGEEKO, float3x3 FBOHIOHFFKI, float EAEIAKHGPAC, int ENIDENFKPNJ, int BGHJGMOPNPN, int LFNBKBFIIFD, float PNBHFDPHEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6DD6250", Offset = "0x6DD5650", VA = "0x186DD6250")]
	private void KBMJAPJDNGE(int LOKCINAPPGD, int EIPLNACNPEC, FHOLELOMBBL NKAAOLBAMOB, float3 MJEPAHGEEKO, float3x3 FBOHIOHFFKI, bool GPKLJGGAIBN, float EAEIAKHGPAC, int AMBIBOJNDEI, int EGLBLKODJNA, int LFNBKBFIIFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct ELGJKGHBFLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<EGNNDCACJPA> CJBOECHFBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<IADHCANKFMA> DDHNDDCAJIN;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDF20", Offset = "0x6DBD320", VA = "0x186DBDF20")]
	public ELGJKGHBFLN(int JKIIGJDNBMO, Allocator DBCOPEDFGJL = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6DBDE80", Offset = "0x6DBD280", VA = "0x186DBDE80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct IGKKBDDMHCP : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private enum AHEJAENMHEG
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
	private NativeList<float3> ENBBGGOHJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> MEAMEJLHNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<int> LDBJKDEIAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> PNFEJOPKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<float4> JDGHBIOIPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float4> EIEHONBCODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float4> OICADABMGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> DANINKGOLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private NativeList<IADHCANKFMA> EBDKBONIDAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<EGNNDCACJPA> CJBOECHFBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeList<IADHCANKFMA> DDHNDDCAJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private int CLBGMPBFEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private int CDPIEDMFGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> HDECFCOLPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OBHJNHBIJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CFLMCNLANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EAGFMIMDDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> KHBLDAOEFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BGKLMHBGCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float3 FBFAIJGPJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private quaternion AMADHKKGDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private float3 DGGMNECIOIN;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0920", Offset = "0x6DBFD20", VA = "0x186DC0920")]
	public IGKKBDDMHCP(CAPLDBHNLDF KALJMDCABDE, KMIFCNHLIKA PLPEIMHIMMC, float3 JLCNNMCIENC, quaternion JAIIDKOFBBG, float OJJPNKJGNID, int BLKIJMPKHOC = 0, int PCDKNDNGEAP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0730", Offset = "0x6DBFB30", VA = "0x186DC0730")]
	public IGKKBDDMHCP(ELGJKGHBFLN EIFGKHNPLEK, KMIFCNHLIKA PLPEIMHIMMC, float3 JLCNNMCIENC, quaternion JAIIDKOFBBG, float3 OJJPNKJGNID, int BLKIJMPKHOC = 0, int PCDKNDNGEAP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF780", Offset = "0x6DBEB80", VA = "0x186DBF780", Slot = "4")]
	public void Execute(int CMANFNLPJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF3D0", Offset = "0x6DBE7D0", VA = "0x186DBF3D0")]
	private void COCDAMOLKFM(float4x4 FCEPELPKMED, int CMANFNLPJKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x6DC06C0", Offset = "0x6DBFAC0", VA = "0x186DC06C0")]
	private AHEJAENMHEG PKFJACCMHMA(float3 HAGCLANLPAD)
	{
		return default(AHEJAENMHEG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6DBF380", Offset = "0x6DBE780", VA = "0x186DBF380")]
	private float4 AAGMJONLMLF(AHEJAENMHEG MOFKFEMMJEI, int OBFJPFHENMC)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6DC0680", Offset = "0x6DBFA80", VA = "0x186DC0680")]
	private float2 MPPHJEOJGMP(AHEJAENMHEG MOFKFEMMJEI, float3 OGKCMCMHLOD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct KKBFCKNOONG
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum JEKAALKIKBD
	{
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static KKBFCKNOONG HABKGKOFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 NOBECIHIBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3x3 KCACHGKLDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float3 INPFMBGIDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public JEKAALKIKBD LLHMNEIJLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float3 FNKCDCLJLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float3 PNNDJKKIFOF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KIGAEJLFEFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6DEE3D0", Offset = "0x6DED7D0", VA = "0x186DEE3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 JDBMEDLBFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6DEDDC0", Offset = "0x6DED1C0", VA = "0x186DEDDC0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x6DEE650", Offset = "0x6DEDA50", VA = "0x186DEE650")]
	public KKBFCKNOONG(float3 OGKCMCMHLOD, quaternion GEMHEIIKJKD, float3 JKIIGJDNBMO, JEKAALKIKBD EKNPHEPNHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6DEE3E0", Offset = "0x6DED7E0", VA = "0x186DEE3E0")]
	public float MFDHFKCBGKB(float3 MJEPAHGEEKO, float MKGGHAHKNAJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6DEDCD0", Offset = "0x6DED0D0", VA = "0x186DEDCD0")]
	public bool DHGAILLBPLB(float3 HAGCLANLPAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6DEE220", Offset = "0x6DED620", VA = "0x186DEE220")]
	public void HDPPAGEJMBB(float3 JBHIEPBFHAO, float3x3 PIKKOOJDAIE, float HBHCPJMMKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6DEDEA0", Offset = "0x6DED2A0", VA = "0x186DEDEA0")]
	private void FJNNBHKCCOD(float3 FJJNEGEALHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6DEDF90", Offset = "0x6DED390", VA = "0x186DEDF90")]
	public void HDGEFONEOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
public struct ANLCMOJOGNB : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	private NativeList<KKBFCKNOONG> EIFGKHNPLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	private NativeList<float3> CJBKMBMHMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	private NativeList<int> GELILLPLHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LMDGEALPIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	private NativeList<IADHCANKFMA> DDHNDDCAJIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	private int PNHDMKHAGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private int HLEFMMBMLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private float MKGGHAHKNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private float KCNDJGBBKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> PEDKJMEOLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> DLNEBJEFJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> NLIBOKBPNFK;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6DD8140", Offset = "0x6DD7540", VA = "0x186DD8140")]
	public ANLCMOJOGNB(KMIFCNHLIKA OHLMFEKEKFF, float EHDNLPGIMHM, int PNGCLOMDHAJ, int ENIDENFKPNJ, NativeList<KKBFCKNOONG> EIFGKHNPLEK, NativeArray<int> LMDGEALPIGP, NativeList<IADHCANKFMA> DDHNDDCAJIN, OCOANHMKNKA GOLHPPKBDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7770", Offset = "0x6DD6B70", VA = "0x186DD7770", Slot = "4")]
	public void Execute(int OGDIHKBALMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6DD76B0", Offset = "0x6DD6AB0", VA = "0x186DD76B0")]
	private bool DMDHODNPPOG(KKBFCKNOONG FIGPMCHHKJO, KKBFCKNOONG LLNOONNFEHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6DD7EB0", Offset = "0x6DD72B0", VA = "0x186DD7EB0")]
	private bool NCODJFGHINI(KKBFCKNOONG GLPIIJCKGCI, int KNNNOMCJLND, int IANKEHPAJHN, int HDOPKHPJCBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OCOANHMKNKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public NativeArray<bool> IBHGMEGCAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public NativeArray<int> NHJGDEKALAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public NativeArray<bool> NMHOPCDNGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NativeArray<float> BMPAPCBFNNE;

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6DEEDB0", Offset = "0x6DEE1B0", VA = "0x186DEEDB0")]
	public void IDGPHFOCHGM(int MHFEFMCBKKI, int ENPJOKOLAHO, Allocator DBCOPEDFGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6DEECA0", Offset = "0x6DEE0A0", VA = "0x186DEECA0")]
	public static long ALIPNFGPJIN(int MHFEFMCBKKI, int ENPJOKOLAHO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6DEECC0", Offset = "0x6DEE0C0", VA = "0x186DEECC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6DEEED0", Offset = "0x6DEE2D0", VA = "0x186DEEED0")]
	public void PBEAHLLBJJI(JobHandle NCIJHBALCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public OCOANHMKNKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
public struct BAEAHCCLFAE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NativeList<float3> CJBKMBMHMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private NativeArray<float3> FCGBNFHNIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeArray<float4> LDNEEGOGGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float2> LDDLFPFBJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeList<int> GELILLPLHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HKJGHHHAKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> FKGHCJHBLLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[ReadOnly]
	private NativeArray<bool> PEDKJMEOLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[ReadOnly]
	private NativeArray<bool> DLNEBJEFJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	private int BLKIJMPKHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private int PCDKNDNGEAP;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6DD8620", Offset = "0x6DD7A20", VA = "0x186DD8620")]
	public BAEAHCCLFAE(KMIFCNHLIKA OHLMFEKEKFF, OCOANHMKNKA GOLHPPKBDDC, int PCDKNDNGEAP = 0, int BLKIJMPKHOC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6DD8240", Offset = "0x6DD7640", VA = "0x186DD8240", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6DD81E0", Offset = "0x6DD75E0", VA = "0x186DD81E0")]
	private void EDGFGEOKLFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class ALJJIHJOMLK
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x35D0910", Offset = "0x35CFD10", VA = "0x1835D0910")]
	public static bool LPKHLPCHGKB<T>(NativeArray<T> EFKOIGFMOHD, int JKIIGJDNBMO, Allocator DBCOPEDFGJL, NativeArrayOptions POLCFNEEHMO = NativeArrayOptions.ClearMemory, int IKHIHBGPHOO = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x35D09D0", Offset = "0x35CFDD0", VA = "0x1835D09D0")]
	public static bool LPKHLPCHGKB<T>(NativeList<T> PBBPHMMFLFN, int JKIIGJDNBMO, Allocator DBCOPEDFGJL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum GOABLIECIPO
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
public interface BLKKLIPAAIE
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LMMGPNIBMFL(GOABLIECIPO BGHMMFOMOHD);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JOBDFNBGLGM(GOABLIECIPO BGHMMFOMOHD);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds PKOCDMDCPLP();

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float BKILODMACIN();

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHHKOELINCC(GOABLIECIPO BGHMMFOMOHD, CAPLDBHNLDF ALAHJIMLIMJ, int DMFBNHANBGJ = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class PHJOLBIPGLD
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF070", Offset = "0x6DEE470", VA = "0x186DEF070")]
	public static void JJHBPEBHDLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class CFAKDNCBHNB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public NativeList<float3> OPCKCNPCGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public NativeArray<float3> DGEHJPOOIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public NativeArray<int> JOLCBNOAEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<float4> FDKJPCBCPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeArray<float4> JECBILCBBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeArray<float4> DHKAOKKJEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public NativeList<float3> PENPDMIGJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public NativeList<int> CHCKHCIJNMJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CGHKBDLAPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE2F0", Offset = "0x6DDD6F0", VA = "0x186DDE2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int BAINBALNHCN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6DDE2B0", Offset = "0x6DDD6B0", VA = "0x186DDE2B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int BECENHBNELE
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6DDD9D0", Offset = "0x6DDCDD0", VA = "0x186DDD9D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE8A0", Offset = "0x6DDDCA0", VA = "0x186DDE8A0")]
	public CFAKDNCBHNB(int MHFEFMCBKKI, int ENPJOKOLAHO, int HBEMKCIEGBF, Allocator DBCOPEDFGJL = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6DDEB70", Offset = "0x6DDDF70", VA = "0x186DDEB70")]
	public CFAKDNCBHNB(Mesh OHLMFEKEKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6DDDA10", Offset = "0x6DDCE10", VA = "0x186DDDA10", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6DDDB20", Offset = "0x6DDCF20", VA = "0x186DDDB20")]
	public void EJPACLHODAH(CFAKDNCBHNB OHLMFEKEKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6DDDE20", Offset = "0x6DDD220", VA = "0x186DDDE20")]
	private void GLJOPMLPGGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6DDE330", Offset = "0x6DDD730", VA = "0x186DDE330")]
	private void KKDLMKFJALJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct IADHCANKFMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int EPIIMOIGOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public int CGHKBDLAPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public int MNJICPHCING;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int BAINBALNHCN;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x186C4E0", Offset = "0x186B8E0", VA = "0x18186C4E0")]
	public IADHCANKFMA(int ENIDENFKPNJ, int JJMBBDFCOFB, int PNGCLOMDHAJ, int HPGKMCIBAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class HFGDPFDNLFO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<IADHCANKFMA> CFMOLGEPBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xAE8210", Offset = "0xAE7610", VA = "0x180AE8210")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<IADHCANKFMA>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xAE8120", Offset = "0xAE7520", VA = "0x180AE8120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public CFAKDNCBHNB OOMIAPBAKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x89CED0", Offset = "0x89C2D0", VA = "0x18089CED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6DE29D0", Offset = "0x6DE1DD0", VA = "0x186DE29D0")]
	public HFGDPFDNLFO(IEnumerable<CFAKDNCBHNB> DJKBGNFBDHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2960", Offset = "0x6DE1D60", VA = "0x186DE2960", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum CJMFAEJDJMH
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class MFFILDOFNHO
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static NativeArray<float2> GEJKCMHNGIH;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static NativeArray<float3> LGGCMDNMEMF;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static NativeArray<float4> AJBOOOILCPE;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static NativeArray<int> ONJEFICMCBA;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6DEEA70", Offset = "0x6DEDE70", VA = "0x186DEEA70")]
	public static void JJHBPEBHDLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6DEE740", Offset = "0x6DEDB40", VA = "0x186DEE740")]
	public static NativeArray<float2> BAKHFOIEJIN(NativeArray<float2> DCMENJIBPIH, int POIPBJGLCBJ, NativeArray<float2> IJLMPMNIDKH, int LEFMABJHCFF)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6DEEB90", Offset = "0x6DEDF90", VA = "0x186DEEB90")]
	public static NativeArray<float3> PJNPNHFGNPJ(NativeArray<float3> DCMENJIBPIH, int POIPBJGLCBJ, NativeArray<float3> IJLMPMNIDKH, int LEFMABJHCFF)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6DEE960", Offset = "0x6DEDD60", VA = "0x186DEE960")]
	public static NativeArray<float4> JIGOKGOAOJL(NativeArray<float4> DCMENJIBPIH, int POIPBJGLCBJ, NativeArray<float4> IJLMPMNIDKH, int LEFMABJHCFF)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6DEE850", Offset = "0x6DEDC50", VA = "0x186DEE850")]
	public static NativeArray<int> EHEIGGJCKLB(NativeArray<int> DCMENJIBPIH, int POIPBJGLCBJ, NativeArray<int> IJLMPMNIDKH, int LEFMABJHCFF)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2FC21B0", Offset = "0x2FC15B0", VA = "0x182FC21B0")]
	private static void IMHHPOHOLKC<T>(NativeArray<T> EFKOIGFMOHD, int HHHFMPCMMIM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC20D0", Offset = "0x2FC14D0", VA = "0x182FC20D0")]
	private static void FMCDENHFFPF<T>(NativeArray<T> DCMENJIBPIH, int POIPBJGLCBJ, NativeArray<T> IJLMPMNIDKH, int LEFMABJHCFF, NativeArray<T> BAIIIPHOBAL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BurstCompile]
public class FLPJINOLGHP
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct JPEBLJCNKNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ushort KPPEBBOFEKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ushort EJAKPDCBGAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ushort NECLOIHPKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ushort DPAGALKLNIH;
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6DE24D0", Offset = "0x6DE18D0", VA = "0x186DE24D0")]
	public static uint GOFJKBJPMGG(float EFMCPKNICLK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6DE27C0", Offset = "0x6DE1BC0", VA = "0x186DE27C0")]
	public static void OHCKJEFOOJO(float4 LDNEEGOGGCI, float KDAFIDIKMPI, [Out] uint KFIDBKKNMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6DE26F0", Offset = "0x6DE1AF0", VA = "0x186DE26F0")]
	public static void OHCKJEFOOJO(float4 LDNEEGOGGCI, uint LKCDLNBGILC, [Out] uint KFIDBKKNMPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1CE0", Offset = "0x6DE10E0", VA = "0x186DE1CE0")]
	public static void ALIIAJNIDNE(float3 LJNLHONCELC, float3 JKOFEFJEPCD, float4 MMOEELKDIDE, float2 PIIEKKHPDFB, float4 LDNEEGOGGCI, [Out] KMIFCNHLIKA.JDIGHCKDKBP GNCDHCLOIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1F30", Offset = "0x6DE1330", VA = "0x186DE1F30")]
	public static void ALIIAJNIDNE(float3 LJNLHONCELC, float3 JKOFEFJEPCD, float4 MMOEELKDIDE, float2 PIIEKKHPDFB, float4 LDNEEGOGGCI, [Out] KMIFCNHLIKA.FEFJECGALEK GNCDHCLOIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2190", Offset = "0x6DE1590", VA = "0x186DE2190")]
	public static byte BOAODONDIAE(float PFKKDHPJFEH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6DE21E0", Offset = "0x6DE15E0", VA = "0x186DE21E0")]
	public static ushort DHELCFONPPH(float PFKKDHPJFEH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6DE24E0", Offset = "0x6DE18E0", VA = "0x186DE24E0")]
	public static uint HMKLODGAJNE(float PFKKDHPJFEH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2670", Offset = "0x6DE1A70", VA = "0x186DE2670")]
	public static float2 LFGHBCEEIGM(float2 FCBPGONDPJI)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2230", Offset = "0x6DE1630", VA = "0x186DE2230")]
	public static float2 DJFJKDINPFE(float3 KNIHHDMJHNC)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2380", Offset = "0x6DE1780", VA = "0x186DE2380")]
	public static void GAFHHEFFMCM(float3 PFKKDHPJFEH, [Out] float3 NBPMGJPKJJC, [Out] uint3 DPAGALKLNIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2510", Offset = "0x6DE1910", VA = "0x186DE2510")]
	public static JPEBLJCNKNA ICIEDBAACIM(float3 OGKCMCMHLOD)
	{
		return default(JPEBLJCNKNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CNBJPAIBBOB
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker GMHBNFBAMOF;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static float FCDEGFHDCLF;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	private static void MEBEHECAPPO(bool JJCEMMCANMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6DDEE70", Offset = "0x6DDE270", VA = "0x186DDEE70")]
	public static void DNFEAOOGECM(float BMLMDCAJKOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class IGMHIBLEHLL
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal enum ODPEIICNFFP
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
	public struct OFEDNFFHPEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public ODOGJEOMOFN OHLMFEKEKFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int LMPLPMNLGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int CNIJLABMOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public long BHINNOBBAMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public long KLFBCNJOBAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float LNJLBLCMLDG;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6DEEFC0", Offset = "0x6DEE3C0", VA = "0x186DEEFC0")]
		public void MABFCCPGADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6DEEFF0", Offset = "0x6DEE3F0", VA = "0x186DEEFF0")]
		public void PBEAHLLBJJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string DCAJFBBNNJM;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly string KAPKIBPKEPM;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly ProfilerMarker GMHBNFBAMOF;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly ProfilerMarker FOLLOCPNDEE;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly ProfilerMarker BFBDNKINDNN;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly ProfilerMarker FCGCPBHMMNI;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly ProfilerMarker HOPIBOGGEID;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly ProfilerMarker GAOJEGHFAMN;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly ProfilerMarker PBGLNKMIBGM;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly ProfilerMarker IKLBDICLGDJ;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly ProfilerMarker HFDADOJGIMB;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly ProfilerMarker PACMDOIFMNC;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly ProfilerMarker JEHGCHGCJBH;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly ProfilerMarker NBDIHFBJBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly List<BLKKLIPAAIE> IPHGGCFGEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly HLACFEIODAE KODNCECHAMA;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public const bool EICAOKJEAAG = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int JJMBBDFCOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int HPGKMCIBAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool HPGKIPIMCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal bool PKBFALEHAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool KDEAAJLHCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	internal ODPEIICNFFP GCJJLPMGMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	internal bool BHJIEIMMNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	internal float3 OIDFAGNOPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	internal float3 GEJOOCPCAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal float FADCHNFHOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	internal float OMINONDBEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	internal int AJIEJMOHGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	internal int JOBCFJIKGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int CHMGKPFGNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int AHECBIPFAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private float OJBDPAPGCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private float CEIDGBCOCMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int OKNCLAHMBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long KEKMAOFPOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long JDLHGBBAPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private long DKMMPFGJFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public int DBDJIHEAADH;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private const int IIDGGLINBAP = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private float[] GPEGPFPBPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int[] ILIPHBKHKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long[] NOLDBMOGCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<OFEDNFFHPEP> FBGAIKDKCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private KMIFCNHLIKA MOFGPFBDMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private long GFHAEGJOOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private long PGKECGICDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int HFKLONNCGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	internal float IIADLCJIBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	internal KMIFCNHLIKA.CECKBGNLKMH EGPNNDHAKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool HLPKAKELBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private DIDPCEGGHJH BHJPHOHPIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private JobHandle KGOEDNDLJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	internal NativeArray<long> JEFOOOOGGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool LLPFPLAFMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private JobHandle BPIBOJDFMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private KMIFCNHLIKA NMOFFNGEHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private OCOANHMKNKA EFFMKIBPHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform FNGFOFPHJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private GOABLIECIPO MBENHMJHNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private long NPNDJODHOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private long CCBCDNAHPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long KLFHMDELFGE;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	internal Mesh OOMIAPBAKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x89EF00", Offset = "0x89E300", VA = "0x18089EF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MeshFilter BOBANDHBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x89EF30", Offset = "0x89E330", VA = "0x18089EF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshRenderer ANFIKHNOHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x8A0740", VA = "0x1808A1340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F10", Offset = "0x8A1310", VA = "0x1808A1F10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<Material> HPKICCAJCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F80", Offset = "0x8A0380", VA = "0x1808A0F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8A1350", Offset = "0x8A0750", VA = "0x1808A1350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int KCBIGBBHEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9E8DA0", Offset = "0x9E81A0", VA = "0x1809E8DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int CKHNELPGPAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x135B770", Offset = "0x135AB70", VA = "0x18135B770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int CGHKBDLAPID
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6DEA9E0", Offset = "0x6DE9DE0", VA = "0x186DEA9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public List<BLKKLIPAAIE> IFKOCPAHDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4DB0", Offset = "0x6DE41B0", VA = "0x186DE4DB0")]
	public void BHMCCPMCJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6DEAE00", Offset = "0x6DEA200", VA = "0x186DEAE00")]
	private void LCEJNNDKBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6DED500", Offset = "0x6DEC900", VA = "0x186DED500")]
	public IGMHIBLEHLL(string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6DECF20", Offset = "0x6DEC320", VA = "0x186DECF20")]
	public void PBEAHLLBJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4F20", Offset = "0x6DE4320", VA = "0x186DE4F20")]
	private void CGPAEFMOMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6DEA5B0", Offset = "0x6DE99B0", VA = "0x186DEA5B0")]
	private void HKFLPIAJCDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6DE89D0", Offset = "0x6DE7DD0", VA = "0x186DE89D0")]
	public Mesh GLEPNDDOIEJ(MeshFilter AKINLHLELAI, Transform JGDFNKEDOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6DEAA00", Offset = "0x6DE9E00", VA = "0x186DEAA00")]
	private void JGBOKCCDMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4DC0", Offset = "0x6DE41C0", VA = "0x186DE4DC0")]
	public void BOEEECNBGLP(BLKKLIPAAIE IGPFMFDMNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6DEA960", Offset = "0x6DE9D60", VA = "0x186DEA960")]
	public bool ICMHAJIBPAE(BLKKLIPAAIE IGPFMFDMNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4D50", Offset = "0x6DE4150", VA = "0x186DE4D50")]
	public bool APJCMBOKLHP(BLKKLIPAAIE IGPFMFDMNCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6DED050", Offset = "0x6DEC450", VA = "0x186DED050", Slot = "4")]
	public virtual void PIFJJMNLOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6DEA750", Offset = "0x6DE9B50", VA = "0x186DEA750")]
	public void IALCFMNNFKI(Transform IDCGNGNIFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7380", Offset = "0x6DE6780", VA = "0x186DE7380")]
	private long EODCFOGBDHM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6DEAC90", Offset = "0x6DEA090", VA = "0x186DEAC90")]
	private long JNMLKPNCBKN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE2F80", Offset = "0x6DE2380", VA = "0x186DE2F80")]
	public bool ABDFIBDHAAG(Transform IDCGNGNIFNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB670", Offset = "0x6DEAA70", VA = "0x186DEB670")]
	public bool NANNCABCHEF(bool NCGBIEFLMHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7AD0", Offset = "0x6DE6ED0", VA = "0x186DE7AD0")]
	private void GIHPNHCLPIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6DE5580", Offset = "0x6DE4980", VA = "0x186DE5580")]
	public bool DNFEAOOGECM(float4x4 IMPPBMLLOGM, BatchedMeshRenderer NCBCNPMHEEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB170", Offset = "0x6DEA570", VA = "0x186DEB170")]
	public void MLLCBEKNJND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7590", Offset = "0x6DE6990", VA = "0x186DE7590")]
	public bool FLOECMCMABE(bool NCGBIEFLMHI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6DEADF0", Offset = "0x6DEA1F0", VA = "0x186DEADF0")]
	public void KABGEPAOAFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8E20", Offset = "0x6DE8220", VA = "0x186DE8E20")]
	public void HFDAIGFPIFO(KMIFCNHLIKA OHLMFEKEKFF, int KELGFIBBMPA, int GOMCDFBICGK, float IGNDKIIFBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7820", Offset = "0x6DE6C20", VA = "0x186DE7820")]
	public void FOCNCBJDKBB(ODOGJEOMOFN GAMPEDKIJEI, int KELGFIBBMPA, int GOMCDFBICGK, float IGNDKIIFBGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6DECEB0", Offset = "0x6DEC2B0", VA = "0x186DECEB0")]
	public (long, long, long) OIBPLCEHOKG()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x9F1750", Offset = "0x9F0B50", VA = "0x1809F1750")]
	public long MBEKPODFAED()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6DE5180", Offset = "0x6DE4580", VA = "0x186DE5180")]
	private void DBLLPJFDKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8260", Offset = "0x6DE7660", VA = "0x186DE8260")]
	public (long, long) GKCIIAABPNM(float MNAKEADNFFP, float4x4 IMPPBMLLOGM)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	public void KBMIMHJJHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6DE5060", Offset = "0x6DE4460", VA = "0x186DE5060")]
	internal void CNKDFENKNOL(ODPEIICNFFP PGBDEPBMNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6DE9E10", Offset = "0x6DE9210", VA = "0x186DE9E10")]
	private (float, float, float, float) HJHIAPDGOED(float DCBMPJADHNJ, float4x4 IMPPBMLLOGM)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB110", Offset = "0x6DEA510", VA = "0x186DEB110")]
	private float MGJBNDLLEDO(float DCBMPJADHNJ, float4x4 IMPPBMLLOGM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8AE0", Offset = "0x6DE7EE0", VA = "0x186DE8AE0")]
	private (int, int) GLKCBHOKCDI(float KFEFMEEOEEL)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6DE8E50", Offset = "0x6DE8250", VA = "0x186DE8E50")]
	public void HFMFICKLNDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7440", Offset = "0x6DE6840", VA = "0x186DE7440")]
	private void FHKICIFMNPH(KMIFCNHLIKA POJGCGBJBMB, KMIFCNHLIKA.CECKBGNLKMH MFINFDPPMLE, bool IMGOEAMFPMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE7490", Offset = "0x6DE6890", VA = "0x186DE7490")]
	private void FHKICIFMNPH([In] ODOGJEOMOFN POJGCGBJBMB, KMIFCNHLIKA.CECKBGNLKMH MFINFDPPMLE, bool IMGOEAMFPMA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4FC0", Offset = "0x6DE43C0", VA = "0x186DE4FC0")]
	private void CKDGJAJDICD(KMIFCNHLIKA.CECKBGNLKMH MFINFDPPMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6DEA690", Offset = "0x6DE9A90", VA = "0x186DEA690")]
	private void HLPNNABCGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB350", Offset = "0x6DEA750", VA = "0x186DEB350")]
	private void MOALBPMIMON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC4E0", Offset = "0x6DEB8E0", VA = "0x186DEC4E0")]
	public long OEDCADAMPFB(long AOOFHBFCGEP, int OBBHOOCMPPB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6DE4050", Offset = "0x6DE3450", VA = "0x186DE4050")]
	private void AKANGFDIBNB(KMIFCNHLIKA FHBKDJPBFMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6DE85F0", Offset = "0x6DE79F0", VA = "0x186DE85F0")]
	private void GKCMCMHIFJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x6DEA6C0", Offset = "0x6DE9AC0", VA = "0x186DEA6C0")]
	private float IAFGPKOMDJD(int IAKGEKGFOPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6DE6A50", Offset = "0x6DE5E50", VA = "0x186DE6A50")]
	private void DNOMIELJBKO(KMIFCNHLIKA OHLMFEKEKFF, EJIOBGNCPBF GAMPEDKIJEI, int KELGFIBBMPA, int GOMCDFBICGK, float IGNDKIIFBGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct DIDPCEGGHJH : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct KOKEMLHNFFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int KAHEMPNBCPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int BLEKHLDEHBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int LOKDFIAMKEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int FBHMOFIONDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int NDNHJHHNOFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int BKOBOCELFIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int LMPLPMNLGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int CNIJLABMOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public float LNJLBLCMLDG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private struct CKLKNAGLEMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public GAHDOEBJBJI.PCIDMNKKACC IMJIIPINKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float AIGFDHBGJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public float DNOPJOAMAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public float LKLALBBGANO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float NFGMJAHBFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public float JLHOBKPBOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public float LKKBKPMLFFL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct KANHEDILCEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public NativeArray<float3> OPCKCNPCGBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NativeArray<float3> DGEHJPOOIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public NativeArray<float4> JHICLBDAICK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NativeArray<float4> FCKEHPPKBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NativeArray<float2> KCIHACHEDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NativeArray<int> CHCKHCIJNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool NLLBLKMFDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int CGHKBDLAPID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int BAINBALNHCN;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6DED7E0", Offset = "0x6DECBE0", VA = "0x186DED7E0")]
		public void IDGPHFOCHGM(int MHFEFMCBKKI, int ENPJOKOLAHO, Allocator DBCOPEDFGJL, bool GGIBEFKOOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6DEDA80", Offset = "0x6DECE80", VA = "0x186DEDA80")]
		public static KANHEDILCEK PGJLGEAHHIL(KMIFCNHLIKA DPJCEEDGHJL)
		{
			return default(KANHEDILCEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6DED9C0", Offset = "0x6DECDC0", VA = "0x186DED9C0")]
		public void PBEAHLLBJJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly ProfilerMarker NODOJALBNCH;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly ProfilerMarker DCELENGAPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<KOKEMLHNFFK> DMPPIMMAAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private KANHEDILCEK LPIEFACDOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private KANHEDILCEK FHBKDJPBFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private float3 CMPJAMADOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private float3 HLAGJLEPBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private CKLKNAGLEMI PEADCBEEPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* OEHHCBLPMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NativeArray<int> HBONMAMGBAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private NativeArray<bool> DLNEBJEFJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeArray<int> POPHGMFDMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private NativeArray<int> EFOJOOGHFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private NativeArray<float> FMPLAFMLONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeArray<int> BHODMPMOKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeArray<float> KBNGAGFDIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeArray<float> HAEGCPKKBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<int> LFLCNKKCDOH;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1470", Offset = "0x6DE0870", VA = "0x186DE1470")]
	public DIDPCEGGHJH([In] List<IGMHIBLEHLL.OFEDNFFHPEP> AAILNEPFKMH, [In] KMIFCNHLIKA JFDOMNNJPAB, [In] IGMHIBLEHLL DLHDEMNJEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0D10", Offset = "0x6DE0110", VA = "0x186DE0D10", Slot = "4")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6DE03F0", Offset = "0x6DDF7F0", VA = "0x186DE03F0")]
	public void DHFHABEGKBK(List<IGMHIBLEHLL.OFEDNFFHPEP> FFIBPHEHCMJ, [In] IGMHIBLEHLL DLHDEMNJEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6DE1090", Offset = "0x6DE0490", VA = "0x186DE1090")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool OKLOHKKNFGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0E60", Offset = "0x6DE0260", VA = "0x186DE0E60")]
	private ODOGJEOMOFN ODCDNNIDJMJ(int NBHFBJAJJPE, Allocator DBCOPEDFGJL)
	{
		return default(ODOGJEOMOFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6DDF460", Offset = "0x6DDE860", VA = "0x186DDF460")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void BDPLHCAPLKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6DE10B0", Offset = "0x6DE04B0", VA = "0x186DE10B0")]
	[IgnoreWarning(1371)]
	private KOKEMLHNFFK PHFJEPKGAOI([In] KOKEMLHNFFK LOJPHMOJDAJ, int JKDIBDOCHML, [In] NativeArray<int> GELILLPLHOC, [In] NativeArray<bool> DLNEBJEFJOB, NativeArray<int> POPHGMFDMBA)
	{
		return default(KOKEMLHNFFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6DE0D60", Offset = "0x6DE0160", VA = "0x186DE0D60")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int LMMLCPLEPNK(NativeArray<int> GELILLPLHOC, int NJGBHJHCGOM, int AOIHIBEGLKI, int MJHAGOICLHN)
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
		public static readonly LDGDBHIGNCI log;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static readonly ProfilerMarker JNLAGIMKKME;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private static readonly ProfilerMarker FENIJGGIECP;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly ProfilerMarker DDMGPMMPEIJ;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly ProfilerMarker HBAJBFPEIJA;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly ProfilerMarker GBKFLCCHJOP;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static readonly ProfilerMarker HOPIBOGGEID;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private static readonly ProfilerMarker CJOCLBJCLFH;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		internal const int HJLFKIPCMIN = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		internal static Dictionary<Material, List<Material>> LGKBEEMKJHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Dictionary<Material, List<IGMHIBLEHLL>> NJGJKKFHGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal List<IGMHIBLEHLL> FIIFKPODANP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private List<MeshRenderer> MEANAAICGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Transform KHBDEMOBGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private bool IPOPAAKHKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private bool CGJBNODBJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private int CMEJOPEPOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private IGMHIBLEHLL MEMECACBODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Material HHNPMCKIGFO;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private const int MGNIDOFGLIP = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static List<(long, Bounds, BLKKLIPAAIE)> FDMNPHPGJIM;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<MeshRenderer> AMJKNPMBPKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int GIINJDJGAJP
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x6DDD980", Offset = "0x6DDCD80", VA = "0x186DDD980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		private static void LFCIONKMDFP(bool JJCEMMCANMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		private static void LFCIONKMDFP(bool JJCEMMCANMG, string NFKMLKNHFEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6DDA960", Offset = "0x6DD9D60", VA = "0x186DDA960")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8950", Offset = "0x6DD7D50", VA = "0x186DD8950")]
		public IGMHIBLEHLL AddToBatchedMesh(BLKKLIPAAIE FIJFGKFDOEL, Material JAEJMKKLMIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6DDD3B0", Offset = "0x6DDC7B0", VA = "0x186DDD3B0")]
		public void RemoveFromBatchedMesh(BLKKLIPAAIE OHLMFEKEKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8D40", Offset = "0x6DD8140", VA = "0x186DD8D40")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD88D0", Offset = "0x6DD7CD0", VA = "0x186DD88D0")]
		private void AHJFJNGNHHP(Renderer CJAGOGFODOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8E80", Offset = "0x6DD8280", VA = "0x186DD8E80")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8E70", Offset = "0x6DD8270", VA = "0x186DD8E70")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6DD95C0", Offset = "0x6DD89C0", VA = "0x186DD95C0")]
		private void GOOGJDJINNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6DDA470", Offset = "0x6DD9870", VA = "0x186DDA470")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6DD86A0", Offset = "0x6DD7AA0", VA = "0x186DD86A0")]
		private IGMHIBLEHLL ADIPNNBAMJN(BLKKLIPAAIE OHLMFEKEKFF, Material JAEJMKKLMIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8A50", Offset = "0x6DD7E50", VA = "0x186DD8A50")]
		private IGMHIBLEHLL CHGMEFMNMJI(Material JAEJMKKLMIE, int LNCHEAOGAHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6DD8F20", Offset = "0x6DD8320", VA = "0x186DD8F20")]
		private IGMHIBLEHLL GFKLJHLMAAA(Material JAEJMKKLMIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6DDA1E0", Offset = "0x6DD95E0", VA = "0x186DDA1E0")]
		private float4x4 HAMBONKELNG()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9B80", Offset = "0x6DD8F80", VA = "0x186DD9B80")]
		public static List<Material> GenerateVertexFormatVariants(Material JAEJMKKLMIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xD31380", Offset = "0xD30780", VA = "0x180D31380")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6DDA2E0", Offset = "0x6DD96E0", VA = "0x186DDA2E0")]
		public void MarkDirty(BLKKLIPAAIE OHLMFEKEKFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6DDA5E0", Offset = "0x6DD99E0", VA = "0x186DDA5E0")]
		public (long, long) MemorySizeInBytesForChosenDetail(float MNAKEADNFFP)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6DDC0C0", Offset = "0x6DDB4C0", VA = "0x186DDC0C0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6DD9CA0", Offset = "0x6DD90A0", VA = "0x186DD9CA0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6DDABC0", Offset = "0x6DD9FC0", VA = "0x186DDABC0")]
		public void RebatchOptimally(int MBJLHGMCIMK, int OLJLGKDBPII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6DDD850", Offset = "0x6DDCC50", VA = "0x186DDD850")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class ALLEFCDAAKL
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct HCHDHNLLEMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public float IABPFIADDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public BatchedMeshRenderer GGAPPLJAONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public IGMHIBLEHLL NGHCMDEPGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public long PGOCBMNHENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public float OABIIAEPAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public bool OGPBDBPGCPP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class FDNOOELFDID : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private int <batchSizeNaughty>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private int <batchSizeNice>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private int <countdownBeforeYield>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xC50840", Offset = "0xC4FC40", VA = "0x180C50840", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6DF5040", Offset = "0x6DF4440", VA = "0x186DF5040", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xDAF920", Offset = "0xDAED20", VA = "0x180DAF920")]
		[DebuggerHidden]
		public FDNOOELFDID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6DF5090", Offset = "0x6DF4490", VA = "0x186DF5090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6DF42A0", Offset = "0x6DF36A0", VA = "0x186DF42A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4250", Offset = "0x6DF3650", VA = "0x186DF4250")]
		private void KAONCANHJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4EF0", Offset = "0x6DF42F0", VA = "0x186DF4EF0")]
		private void NJJPNOJLCPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4FF0", Offset = "0x6DF43F0", VA = "0x186DF4FF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4F40", Offset = "0x6DF4340", VA = "0x186DF4F40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4F40", Offset = "0x6DF4340", VA = "0x186DF4F40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly ProfilerMarker HOPIBOGGEID;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly ProfilerMarker ABNHCGNDHJM;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly ProfilerMarker HGNIKCMNPCI;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker ACKAIFLOCEP;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static float3 EKHKJCLGJLH;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static int AIMOBPAPJHP;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static int LEDIGGJOJCM;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static int BKBMBMOOFLD;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int FABLOCCKLFI;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static int MOCCMEEIHNB;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static int KKHINONJCIH;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static long BBNEKELEBMB;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static long POADDGILLGI;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int LHAOGBICKKM;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static int KLNDLCJGEBK;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int IODOMNNCINA;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static float LJPCGLEGJEC;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static bool EGKCIBPEIPB;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static int KDNGCAIPDBG;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static float OOFMGIIPIDL;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static float LOLGAOMLCOH;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public static float ILKPBEDLDHK;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static float PEJAPBGOOLH;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static float KMHLMFLFMFB;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static float CPKKDAMKALL;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public static float MGDOMGIJLCP;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public static float CGNNAKEAHFG;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static long LNCLNHPJBOH;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static bool MOOCLLOIAME;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static List<BatchedMeshRenderer> EFBCICOCDBJ;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static List<HCHDHNLLEMC> JKLKJILLFLO;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static Stack<KMIFCNHLIKA> FEPJNBNAOFL;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static Stack<OCOANHMKNKA> GOOKPOMEEHL;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool BNLNBELJFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6DF2E40", Offset = "0x6DF2240", VA = "0x186DF2E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	private static void LFCIONKMDFP(bool JJCEMMCANMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	private static void MEBEHECAPPO(bool JJCEMMCANMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	private static void LFCIONKMDFP(bool JJCEMMCANMG, string NFKMLKNHFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	public static void MABFCCPGADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3A80", Offset = "0x6DF2E80", VA = "0x186DF3A80")]
	public static void PIIMIIIGKIP(BatchedMeshRenderer POBMDALANFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2950", Offset = "0x6DF1D50", VA = "0x186DF2950")]
	public static void IBKOJJDPPOH(BatchedMeshRenderer POBMDALANFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF460", Offset = "0x6DEE860", VA = "0x186DEF460")]
	private static (long, long, long) AIKBOLOIGME(long EGNLIDCFHHK)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF570", Offset = "0x6DEE970", VA = "0x186DEF570")]
	public static bool BAMPLBHHGDK(float NLLEHAEJIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2ED0", Offset = "0x6DF22D0", VA = "0x186DF2ED0")]
	public static void KDIAFNMDIIO(float NLLEHAEJIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6DF23B0", Offset = "0x6DF17B0", VA = "0x186DF23B0")]
	public static bool DNIFLEPLDPG(float NLLEHAEJIOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6DEFA10", Offset = "0x6DEEE10", VA = "0x186DEFA10")]
	public static void DNFEAOOGECM(long EGNLIDCFHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3240", Offset = "0x6DF2640", VA = "0x186DF3240")]
	public static long OEDCADAMPFB(long AOOFHBFCGEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3BE0", Offset = "0x6DF2FE0", VA = "0x186DF3BE0")]
	public static void PLOCBGEFAGO(IGMHIBLEHLL NGHCMDEPGKD, BatchedMeshRenderer GGAPPLJAONO, long PGOCBMNHENF, float IABPFIADDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2F50", Offset = "0x6DF2350", VA = "0x186DF2F50")]
	public static void MPPBEHINMBH(IGMHIBLEHLL NGHCMDEPGKD, BatchedMeshRenderer GGAPPLJAONO, long PGOCBMNHENF, float BMLMDCAJKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6DF2D00", Offset = "0x6DF2100", VA = "0x186DF2D00")]
	public static void JMCAKNEAPBF(IGMHIBLEHLL NGHCMDEPGKD, BatchedMeshRenderer GGAPPLJAONO, long PGOCBMNHENF, float BMLMDCAJKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6DF24C0", Offset = "0x6DF18C0", VA = "0x186DF24C0")]
	public static void EMIDIEEIANK(IGMHIBLEHLL NGHCMDEPGKD, BatchedMeshRenderer GGAPPLJAONO, long PGOCBMNHENF, float ILPLMMOMMIA, bool OGPBDBPGCPP, float IABPFIADDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3720", Offset = "0x6DF2B20", VA = "0x186DF3720")]
	public static float PFKMOCLDHOJ(long OGAMMNCGBAM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6DF26F0", Offset = "0x6DF1AF0", VA = "0x186DF26F0")]
	public static (long, long) GKCIIAABPNM(float MNAKEADNFFP)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6DF28C0", Offset = "0x6DF1CC0", VA = "0x186DF28C0")]
	[IteratorStateMachine(typeof(FDNOOELFDID))]
	public static IEnumerable<bool> HNKKJCELPCE(long OJCPMEFCKMI, bool BEPDMFPFGDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6DF3080", Offset = "0x6DF2480", VA = "0x186DF3080")]
	public static void NFBPNFIDCAC(long OJCPMEFCKMI, bool BEPDMFPFGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6DF35E0", Offset = "0x6DF29E0", VA = "0x186DF35E0")]
	public static int OMOFILAIKHP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF8B0", Offset = "0x6DEECB0", VA = "0x186DEF8B0")]
	internal static KMIFCNHLIKA CLDGHLPLJLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF6C0", Offset = "0x6DEEAC0", VA = "0x186DEF6C0")]
	internal static void BJLGHMDBPOF(KMIFCNHLIKA DEPKJGINFLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF750", Offset = "0x6DEEB50", VA = "0x186DEF750")]
	internal static OCOANHMKNKA CADJBPHBGGP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6DEF630", Offset = "0x6DEEA30", VA = "0x186DEF630")]
	internal static void BJLGHMDBPOF(OCOANHMKNKA GOLHPPKBDDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class MKAHCMFFCDM<KeyType> : IGMHIBLEHLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Dictionary<KeyType, BLKKLIPAAIE> BDMGPMCINNF;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x48D2A70", Offset = "0x48D1E70", VA = "0x1848D2A70")]
	public MKAHCMFFCDM(string ACDGEPBIBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x48D2520", Offset = "0x48D1920", VA = "0x1848D2520")]
	public void BOEEECNBGLP(KeyType PBFBBOFLBNL, BLKKLIPAAIE IGPFMFDMNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x48D2680", Offset = "0x48D1A80", VA = "0x1848D2680")]
	public bool ENCJIKBNNLO(KeyType PBFBBOFLBNL, BLKKLIPAAIE NKGIMJDDKCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x48D2840", Offset = "0x48D1C40", VA = "0x1848D2840")]
	public void OFFANOPADJA(KeyType PBFBBOFLBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x48D2910", Offset = "0x48D1D10", VA = "0x1848D2910", Slot = "4")]
	public override void PIFJJMNLOBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6DF51B0", Offset = "0x6DF45B0", VA = "0x186DF51B0")]
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
