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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PECLCENNCPC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int PADPPKFLBOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 NMJALPPIBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion EHNOPPENGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 BHPDCMBCCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int IGFAMDADIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int EPNBLEOPJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int ECNKBKKCAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float CMCIHBJNHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 HBBJJKJHFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool BOFIPJINCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public JKEPHBBOAEI CFIIHAHIHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 DOEMFJJDMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float LIGIBHACLPH;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AGIBOIPDIEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static HBIPFJMKGHM LKBDPOEAGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<PECLCENNCPC> PKFKCMDADEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<KJCDEGKLPML> JHFAGFBGFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<FEDMFOEFIJH> OFAAAEKLDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<AABFEELECDL> ODMGFNMNACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<KJCDEGKLPML> PNJDIBFDBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<OHICKLHOFJP> JBHCJLKIHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<AABFEELECDL>> KHNPBBDFNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<DBBFKOLNKJN> PGOJLCEJIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> JMFALNEIEMJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GEHBAEEJLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC0D4A0", Offset = "0xC0C2A0", VA = "0x180C0D4A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC0CF90", Offset = "0xC0BD90", VA = "0x180C0CF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ELCABDHJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC0D4B0", Offset = "0xC0C2B0", VA = "0x180C0D4B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC0C1F0", Offset = "0xC0AFF0", VA = "0x180C0C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x613B820", Offset = "0x613A620", VA = "0x18613B820")]
	public AGIBOIPDIEB(int EGBDJDIJJPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x613A230", Offset = "0x6139030", VA = "0x18613A230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x613A500", Offset = "0x6139300", VA = "0x18613A500")]
	public void NCJLPOJPDAM(JobHandle PHIMPJOOHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x613A010", Offset = "0x6138E10", VA = "0x18613A010")]
	public void CDGGMPBLIGG(PECLCENNCPC EEDANCJJEPL, DBBFKOLNKJN LPHFPLCPDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x613B6E0", Offset = "0x613A4E0", VA = "0x18613B6E0")]
	public void PGCAHPCBHAP(FEDMFOEFIJH EEDANCJJEPL, NativeArray<AABFEELECDL> BABCBKPPAKJ, int BHKPNGHCBGD, int LNKPNAAAPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x613A6D0", Offset = "0x61394D0", VA = "0x18613A6D0")]
	public JobHandle NPNHGDAIBCP(MGPLABDHAAM GJGLOLHOALA, GLALCEFIKMI JHOFADHKJJN, float3 JDCNAKMLLNF, quaternion ADIHFCALOJA, float GFAOIDELIMK, bool IFDBOEHKGLE, int PLLFFNMJKMH = 0, int LPGFNECCDJL = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6139CD0", Offset = "0x6138AD0", VA = "0x186139CD0")]
	public static JobHandle AJKCFMMNJAH(LCOJPKNLEMO OCEDIIFPAPA, MGPLABDHAAM GJGLOLHOALA, PECLCENNCPC EEDANCJJEPL, JobHandle PHIMPJOOHAK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x613A250", Offset = "0x6139050", VA = "0x18613A250")]
	public static JobHandle KOBNDLEJPMF(MJAAIIDBHAM OCEDIIFPAPA, MGPLABDHAAM GJGLOLHOALA, FEDMFOEFIJH EEDANCJJEPL, NativeArray<AABFEELECDL> BABCBKPPAKJ, int BHKPNGHCBGD, int LNKPNAAAPMI, JobHandle PHIMPJOOHAK)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MNPAJBCJHBA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct HKECBAKFOKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half FOIPFJCEBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort NDGACFAOGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte JOMOMIEHNOP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int BHKPNGHCBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int LNKPNAAAPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> CPJBEKJMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> IMGHEOEJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> JIFECIOHLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> MOMENEFIALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<HKECBAKFOKB> MEIJPPJOLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> EMBGKCPAKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> PBHPDJIAGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 HDKJDHOPHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 OFPJEMOADNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 NFBIHFAOMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 HHAGHILCJFO;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long OIPFFLIAPBI;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long NHBFNEEHBCL;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float EHJKBKCPOIP;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool AMHFAKJKMPB;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JDBEMNEDKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x614B170", Offset = "0x6149F70", VA = "0x18614B170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x614CAD0", Offset = "0x614B8D0", VA = "0x18614CAD0")]
	public void NCJLPOJPDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x614C640", Offset = "0x614B440", VA = "0x18614C640")]
	public static MNPAJBCJHBA KNBFKAAGFFE(Allocator ALDDPOOJFGI, MGPLABDHAAM NIMOGEKJPOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x614C270", Offset = "0x614B070", VA = "0x18614C270")]
	public static MNPAJBCJHBA KNBFKAAGFFE(Allocator ALDDPOOJFGI, NativeArray<float3> IHIJABNGPDM, NativeArray<float3> AEBELDNEDII, NativeArray<float2> AJALMOEOELA, NativeArray<float4> PCPNAIJINGM, bool ADDJAFNLEJM, NativeArray<float4> IBBPFMENGCB, NativeArray<int> GGIKNEHGGKK, int BHKPNGHCBGD, int BDOEPKAKAOF, int LNKPNAAAPMI, int FLKKLBKOHOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x614B750", Offset = "0x614A550", VA = "0x18614B750")]
	public MGPLABDHAAM IHAPCCAILKK(Allocator ALDDPOOJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x614B1B0", Offset = "0x6149FB0", VA = "0x18614B1B0")]
	public void FMPEPCAILDO(Mesh HCHDFAPIGCD, bool PMICLONNFOB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x614C880", Offset = "0x614B680", VA = "0x18614C880")]
	public long KOKBEECEFEH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x614AEA0", Offset = "0x6149CA0", VA = "0x18614AEA0")]
	private void CFLBAOLHBFM(int MCFPLAICKOP, int LHBKINCEPEH, Allocator ALDDPOOJFGI, bool CFCKBMKMFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x614C1E0", Offset = "0x614AFE0", VA = "0x18614C1E0")]
	private float3 KHPHEHKBFAK(int EKONEPANMNP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x614D220", Offset = "0x614C020", VA = "0x18614D220")]
	private void PNNNOIKDDNP(int EKONEPANMNP, float3 CPLFIBOBMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x614BC70", Offset = "0x614AA70", VA = "0x18614BC70")]
	private float3 JAOLNJFKCBH(int EKONEPANMNP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x614C190", Offset = "0x614AF90", VA = "0x18614C190")]
	private void KBMIBJCKNLG(int EKONEPANMNP, float3 CPLFIBOBMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x614C990", Offset = "0x614B790", VA = "0x18614C990")]
	private float4 LLJHBAMDMIB(int EKONEPANMNP)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x614D1A0", Offset = "0x614BFA0", VA = "0x18614D1A0")]
	private void PIBEMFHCIMM(int EKONEPANMNP, float4 CPLFIBOBMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x614CBD0", Offset = "0x614B9D0", VA = "0x18614CBD0")]
	private float2 NDPLOIIMPIO(int EKONEPANMNP)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x614CE10", Offset = "0x614BC10", VA = "0x18614CE10")]
	private void OKBIPLDJMMG(int EKONEPANMNP, float2 CPLFIBOBMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x614B290", Offset = "0x614A090", VA = "0x18614B290")]
	private void HGACCENNDOG(NativeArray<float3> IHIJABNGPDM, int FLKKLBKOHOB, int LHBKINCEPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x614C910", Offset = "0x614B710", VA = "0x18614C910")]
	private void LJJMOIAPIED(NativeArray<float3> AEBELDNEDII, int FLKKLBKOHOB, int LHBKINCEPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x614CF20", Offset = "0x614BD20", VA = "0x18614CF20")]
	private void PDNDNCIAGNJ(NativeArray<float2> AJALMOEOELA, int FLKKLBKOHOB, int LHBKINCEPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x614CA00", Offset = "0x614B800", VA = "0x18614CA00")]
	private void MDMMHLFJLFM(NativeArray<float4> LGBJLPBPEJI, int FLKKLBKOHOB, int LHBKINCEPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x614BCB0", Offset = "0x614AAB0", VA = "0x18614BCB0")]
	private void JBPOEBLFBMO(Allocator ALDDPOOJFGI, NativeArray<float4> PCPNAIJINGM, int FLKKLBKOHOB, int LHBKINCEPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x614CCD0", Offset = "0x614BAD0", VA = "0x18614CCD0")]
	private static void OGJLFKMEPBA(NativeArray<float4> MKLLIOPANNF, NativeArray<HKECBAKFOKB> MPBMJBNICDP, NativeArray<byte> JFEHKBKIEME, int BHKPNGHCBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x614B670", Offset = "0x614A470", VA = "0x18614B670")]
	private void IBNOOAKAFOH(Allocator ALDDPOOJFGI, NativeArray<int> GGIKNEHGGKK, int FLKKLBKOHOB, int LHBKINCEPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x614ABD0", Offset = "0x61499D0", VA = "0x18614ABD0")]
	private static NativeArray<byte> CCDEOEEFHHF(Allocator ALDDPOOJFGI, NativeArray<int> GGIKNEHGGKK, int LNKNEGIKEMG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x614CC30", Offset = "0x614BA30", VA = "0x18614CC30")]
	private static void OFBKAOOLODG(NativeArray<int> FOPFHKGHNNC, NativeArray<byte> FGOHOMAHCCC, int LNKPNAAAPMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x614B520", Offset = "0x614A320", VA = "0x18614B520")]
	private static float3 HNBODDCEKAM(ushort LIMOGHJFOKD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x614AFB0", Offset = "0x6149DB0", VA = "0x18614AFB0")]
	private static ushort COCPMGJDBLN(float3 CPLFIBOBMLI)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public MNPAJBCJHBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct FFENIPIKEME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float2 EBBAINNAODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float2 ECAMAJBPDPL;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PACLCHAMLCM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<FFENIPIKEME> IBFFEBIEIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<int> NFLDKPHKGCO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int GEHBAEEJLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB30", Offset = "0x7BE930", VA = "0x1807BFB30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ELCABDHJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C24B0", Offset = "0x7C12B0", VA = "0x1807C24B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x614D9D0", Offset = "0x614C7D0", VA = "0x18614D9D0")]
	public PACLCHAMLCM(int MCFPLAICKOP, int LHBKINCEPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x614D890", Offset = "0x614C690", VA = "0x18614D890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x614D8F0", Offset = "0x614C6F0", VA = "0x18614D8F0")]
	public void GHCIFJGGKPO(PACLCHAMLCM KBDNAPBGBME, int DHKJNNBAPHH, int NIAPLMNAGEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class JMCDIJJJACF
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static PACLCHAMLCM HHKEPNHFDBB;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static NativeList<KJCDEGKLPML> FHHMCJNFOGH;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int[] DKIIPNIFPFG;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static bool CHELFPGMFPJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Dictionary<int, PACLCHAMLCM> OHEBGDPFIEO;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Dictionary<int, PACLCHAMLCM> LBLKCNJHFKC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool GGFGBNHKFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6145420", Offset = "0x6144220", VA = "0x186145420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<KJCDEGKLPML> BGBPAJIMCHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6145090", Offset = "0x6143E90", VA = "0x186145090")]
		get
		{
			return default(NativeList<KJCDEGKLPML>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static PACLCHAMLCM CHLAKGKOAEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61458E0", Offset = "0x61446E0", VA = "0x1861458E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6145980", Offset = "0x6144780", VA = "0x186145980")]
	private static void MPIIEFCPNCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6145130", Offset = "0x6143F30", VA = "0x186145130")]
	public static int FGLAKOEJILE(bool CMEHBOFIIDL, int POAKHBGOENG, bool DMBEKBDJBJA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61452C0", Offset = "0x61440C0", VA = "0x1861452C0")]
	private static int IANBMPDHDML(int POAKHBGOENG, bool JMBHEIBLMKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6144DF0", Offset = "0x6143BF0", VA = "0x186144DF0")]
	private static int DABJLHHFKJP(int POAKHBGOENG, bool JMBHEIBLMKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6144D50", Offset = "0x6143B50", VA = "0x186144D50")]
	public static int BHHALICCFPL(int FBJIHPHAKKE, int POAKHBGOENG, int OFCNKPEBGAI, bool JMBHEIBLMKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6145390", Offset = "0x6144190", VA = "0x186145390")]
	public static int JDICPHDNJNH(int FBJIHPHAKKE, int POAKHBGOENG, int OFCNKPEBGAI, bool JMBHEIBLMKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61458B0", Offset = "0x61446B0", VA = "0x1861458B0")]
	public static int KKNOAGPLEPB(int OFCNKPEBGAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6144DE0", Offset = "0x6143BE0", VA = "0x186144DE0")]
	private static int CIFFPIELIBB(int POAKHBGOENG, bool JMBHEIBLMKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61458C0", Offset = "0x61446C0", VA = "0x1861458C0")]
	private static int LBINOEOPMKG(int POAKHBGOENG, bool JMBHEIBLMKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6145160", Offset = "0x6143F60", VA = "0x186145160")]
	public static int HAELOMAHOFM(int FBJIHPHAKKE, int POAKHBGOENG, int OFCNKPEBGAI, bool JMBHEIBLMKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6145300", Offset = "0x6144100", VA = "0x186145300")]
	public static int JBFGJIGIJOD(int FBJIHPHAKKE, int POAKHBGOENG, int OFCNKPEBGAI, bool JMBHEIBLMKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61452E0", Offset = "0x61440E0", VA = "0x1861452E0")]
	public static int INELMKPIKJF(int OFCNKPEBGAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x61451D0", Offset = "0x6143FD0", VA = "0x1861451D0")]
	public static PACLCHAMLCM HJBDMPOHCDO(int POAKHBGOENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6144E00", Offset = "0x6143C00", VA = "0x186144E00")]
	private static PACLCHAMLCM DICBFIHCLEO(int POAKHBGOENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61462D0", Offset = "0x61450D0", VA = "0x1861462D0")]
	public static PACLCHAMLCM OELCEBENJIN(int POAKHBGOENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6145F90", Offset = "0x6144D90", VA = "0x186145F90")]
	private static PACLCHAMLCM NGCPIEACDOI(int POAKHBGOENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x61454A0", Offset = "0x61442A0", VA = "0x1861454A0")]
	public static void JPCBNIODHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FEDMFOEFIJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int CHIJAKELPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3 NMJALPPIBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public quaternion EHNOPPENGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float BHPDCMBCCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float KILPNMEBGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int IGFAMDADIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int EPNBLEOPJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int ECNKBKKCAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool FMJNOIEFLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool JJLAOFOCJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float CMCIHBJNHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 HBBJJKJHFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool FJOKEJACNAM;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OHICKLHOFJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int AFGNDNDDHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int AIFMPBOGECC;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct MJAAIIDBHAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<FEDMFOEFIJH> BGKGGNHFFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<AABFEELECDL> GMGJOHPFOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeArray<KJCDEGKLPML> BDHOBJKDGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<OHICKLHOFJP> MOOMIFILEBM;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x614AAA0", Offset = "0x61498A0", VA = "0x18614AAA0")]
	public MJAAIIDBHAM(NativeArray<AABFEELECDL> GMGJOHPFOJG, int JEOEJJBKODC = 1, Allocator ALDDPOOJFGI = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x614A9B0", Offset = "0x61497B0", VA = "0x18614A9B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct LAODGHJJPLO : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeArray<FFENIPIKEME> PJJFAGMIDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<int> LFPOLMLOOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<KJCDEGKLPML> EJNNJBFFEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeList<FEDMFOEFIJH> BGKGGNHFFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<AABFEELECDL> GMGJOHPFOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<KJCDEGKLPML> BDHOBJKDGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	public NativeArray<OHICKLHOFJP> MOOMIFILEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private int DAGNONBKMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private int OBHPMHAGBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private float3 BJJFEPKDMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private quaternion PBMDIKFDPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private float3 JNIGAEAPFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MIMFOGBGNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> IJCENFJAOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FFFECPFKJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FLJAMLPDNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JMJDJPINAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CHAJLAANDAD;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61486E0", Offset = "0x61474E0", VA = "0x1861486E0")]
	public LAODGHJJPLO(AGIBOIPDIEB ALLOBMGFBOO, MGPLABDHAAM CCKDKNGNICJ, float3 KPMGKDBOEHL, quaternion GDBMMBEIEPP, float OEBLKMAJAJK, int PLLFFNMJKMH = 0, int LPGFNECCDJL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x61484B0", Offset = "0x61472B0", VA = "0x1861484B0")]
	public LAODGHJJPLO(MJAAIIDBHAM ALLOBMGFBOO, MGPLABDHAAM CCKDKNGNICJ, float3 KPMGKDBOEHL, quaternion GDBMMBEIEPP, float3 OEBLKMAJAJK, int PLLFFNMJKMH = 0, int LPGFNECCDJL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6146990", Offset = "0x6145790", VA = "0x186146990")]
	private float3 EHHJNJCALPE(float3 GJBBINDOCDB, Matrix4x4 FFMANNFBHMH)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61482B0", Offset = "0x61470B0", VA = "0x1861482B0")]
	private float3x3 MNEFMFIDIIB(float3x3 EPEJCHKJKKP, float3x3 EPCDOPGCBHK)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61484A0", Offset = "0x61472A0", VA = "0x1861484A0")]
	private float PANDFJPGFOK(float BJOKGACKCGO, float ELOFFKKNPBD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6146AC0", Offset = "0x61458C0", VA = "0x186146AC0", Slot = "4")]
	public void Execute(int FOKFIOMCHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6148330", Offset = "0x6147130", VA = "0x186148330")]
	private void ONEKPHBPOMI(int OLDIDKGNGOG, float3 AJFNKFFNDBD, float3 BKELBBDDNIG, float3 KFMPINIBKCM, float NOBKBEIDCKI, bool NGFEFEMLNKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6146530", Offset = "0x6145330", VA = "0x186146530")]
	private void DBLLMLPHGLL(FEDMFOEFIJH MKFGBKPJNKE, float3 OOEFMBGLDAP, float3x3 POGHNPIKNGB, float BJOKGACKCGO, int KHPJEMLCLNN, int PPFIGPHAJBH, int EFPANJIALEI, float IOAGJOKPHPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6147C60", Offset = "0x6146A60", VA = "0x186147C60")]
	private void FEBHCHBDONM(int OLDIDKGNGOG, int BCICOMKFAAD, FEDMFOEFIJH MKFGBKPJNKE, float3 OOEFMBGLDAP, float3x3 POGHNPIKNGB, bool MIHIINEHCDD, float BJOKGACKCGO, int BGABHFEOAJJ, int LDBBKPBBJLP, int EFPANJIALEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct LCOJPKNLEMO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeList<PECLCENNCPC> GDLPHCAODKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeList<KJCDEGKLPML> FFOPPABLIGN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6149550", Offset = "0x6148350", VA = "0x186149550")]
	public LCOJPKNLEMO(int JEOEJJBKODC, Allocator ALDDPOOJFGI = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61494B0", Offset = "0x61482B0", VA = "0x1861494B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct EBGMDEAIMNG : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private enum DNCIOCJPACM
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
	private NativeList<float3> FCPCICFLPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private NativeArray<float3> DADAPOBDGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	[ReadOnly]
	private NativeList<int> HDKNEMJPCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeArray<int> DILLMIIJPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeArray<float4> AEJLGGELKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private NativeArray<float4> MOMPDALFHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private NativeArray<float4> HNGFNKPKNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> JMOCPOAPKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private NativeList<KJCDEGKLPML> OICHIPNNGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<PECLCENNCPC> GDLPHCAODKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<KJCDEGKLPML> FFOPPABLIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private int DAGNONBKMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private int OBHPMHAGBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MIMFOGBGNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> IJCENFJAOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FFFECPFKJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FLJAMLPDNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JMJDJPINAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CHAJLAANDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private float3 JNIGAEAPFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private quaternion PBMDIKFDPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private float3 BJJFEPKDMND;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x613DE20", Offset = "0x613CC20", VA = "0x18613DE20")]
	public EBGMDEAIMNG(AGIBOIPDIEB ALLOBMGFBOO, MGPLABDHAAM CCKDKNGNICJ, float3 KPMGKDBOEHL, quaternion GDBMMBEIEPP, float OEBLKMAJAJK, int PLLFFNMJKMH = 0, int LPGFNECCDJL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x613E010", Offset = "0x613CE10", VA = "0x18613E010")]
	public EBGMDEAIMNG(LCOJPKNLEMO EEDANCJJEPL, MGPLABDHAAM CCKDKNGNICJ, float3 KPMGKDBOEHL, quaternion GDBMMBEIEPP, float3 OEBLKMAJAJK, int PLLFFNMJKMH = 0, int LPGFNECCDJL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x613CA80", Offset = "0x613B880", VA = "0x18613CA80", Slot = "4")]
	public void Execute(int FOKFIOMCHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x613DA30", Offset = "0x613C830", VA = "0x18613DA30")]
	private void OJANJGFEFIG(float4x4 KHCAEEMGJLK, int FOKFIOMCHGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x613CA10", Offset = "0x613B810", VA = "0x18613CA10")]
	private DNCIOCJPACM EHEGBGMCDGP(float3 BKELBBDDNIG)
	{
		return default(DNCIOCJPACM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x613D9E0", Offset = "0x613C7E0", VA = "0x18613D9E0")]
	private float4 NLLLOADDFAL(DNCIOCJPACM JEAHKMAMCDC, int OHINPGIGDNE)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x613DDE0", Offset = "0x613CBE0", VA = "0x18613DDE0")]
	private float2 PMFJHFJGLJM(DNCIOCJPACM JEAHKMAMCDC, float3 AJFNKFFNDBD)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct DBBFKOLNKJN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum FGIPMGPFCPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static DBBFKOLNKJN DGHDBBJHGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float3 AEKKFHEKCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3x3 INCJBNNECEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 LGOFLDBOEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public FGIPMGPFCPI BCIPLIOEBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 OIIJCMFJKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 ELGPJAADCEK;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool ADIMDPHMPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x613C340", Offset = "0x613B140", VA = "0x18613C340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 DEONCGKKGAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x613BB30", Offset = "0x613A930", VA = "0x18613BB30")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x613C3C0", Offset = "0x613B1C0", VA = "0x18613C3C0")]
	public DBBFKOLNKJN(float3 AJFNKFFNDBD, quaternion OKEJHHGCFPM, float3 JEOEJJBKODC, FGIPMGPFCPI LPFFKBBBCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x613BC10", Offset = "0x613AA10", VA = "0x18613BC10")]
	public float GPLAFNHEALF(float3 OOEFMBGLDAP, float GPKIGKODLFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x613C250", Offset = "0x613B050", VA = "0x18613C250")]
	public bool LAHKFNABKLM(float3 BKELBBDDNIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x613C0A0", Offset = "0x613AEA0", VA = "0x18613C0A0")]
	public void IOJGBCKGPEM(float3 OAJKELHJOFE, float3x3 IAHIENGNDPP, float NGLFEEBDDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x613BA30", Offset = "0x613A830", VA = "0x18613BA30")]
	private void APOOELDNDEI(float3 MNMDECHMAEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x613BE10", Offset = "0x613AC10", VA = "0x18613BE10")]
	public void HKHNBHCPIKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct LBGBCJPKHGN : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeList<DBBFKOLNKJN> EEDANCJJEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeList<float3> CPJBEKJMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeList<int> PBHPDJIAGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> JMFALNEIEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<KJCDEGKLPML> FFOPPABLIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int IADPNMBEEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int LNIJOFELIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private float GPKIGKODLFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private float PLKKOAEBONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> JMMHPPKHKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> JKIBDMJJBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> JLPKLILLGMH;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6149410", Offset = "0x6148210", VA = "0x186149410")]
	public LBGBCJPKHGN(MGPLABDHAAM HCHDFAPIGCD, float LGELOFFENEE, int NIAPLMNAGEM, int KHPJEMLCLNN, NativeList<DBBFKOLNKJN> EEDANCJJEPL, NativeArray<int> JMFALNEIEMJ, NativeList<KJCDEGKLPML> FFOPPABLIGN, GLALCEFIKMI JHOFADHKJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6148C10", Offset = "0x6147A10", VA = "0x186148C10", Slot = "4")]
	public void Execute(int CFIHHMAELNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6149350", Offset = "0x6148150", VA = "0x186149350")]
	private bool IGAMFHPKMIP(DBBFKOLNKJN AOHIFIJNOBB, DBBFKOLNKJN FNDBFMFAGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6148970", Offset = "0x6147770", VA = "0x186148970")]
	private bool CJKPIEMOHFC(DBBFKOLNKJN GLPEKNLBHMD, int IKLMIOPBFLM, int OCHOKBKPPFJ, int JBMKEHLEDPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class GLALCEFIKMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public NativeArray<bool> MIKFMOEOBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeArray<int> MJGKPMLOFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> FFHOGIKLIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float> ODPODCIDNGD;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x613F5F0", Offset = "0x613E3F0", VA = "0x18613F5F0")]
	public void CFLBAOLHBFM(int MCFPLAICKOP, int LHBKINCEPEH, Allocator ALDDPOOJFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x613F6F0", Offset = "0x613E4F0", VA = "0x18613F6F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x613F710", Offset = "0x613E510", VA = "0x18613F710")]
	public void NCJLPOJPDAM(JobHandle PHIMPJOOHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public GLALCEFIKMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[BurstCompile]
public struct NJLDHLDKBBD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeList<float3> CPJBEKJMAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<float3> IMGHEOEJLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<float4> MEIJPPJOLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<float2> MOMENEFIALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private NativeList<int> PBHPDJIAGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JIFECIOHLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NativeArray<int> FCPAEMOCOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[ReadOnly]
	private NativeArray<bool> JMMHPPKHKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[ReadOnly]
	private NativeArray<bool> JKIBDMJJBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[ReadOnly]
	private int PLLFFNMJKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private int LPGFNECCDJL;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x614D810", Offset = "0x614C610", VA = "0x18614D810")]
	public NJLDHLDKBBD(MGPLABDHAAM HCHDFAPIGCD, GLALCEFIKMI JHOFADHKJJN, int LPGFNECCDJL = 0, int PLLFFNMJKMH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x614D3D0", Offset = "0x614C1D0", VA = "0x18614D3D0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x614D7B0", Offset = "0x614C5B0", VA = "0x18614D7B0")]
	private void MPBCLCPPOOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class COFJPEIAIMJ
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2596B80", Offset = "0x2595980", VA = "0x182596B80")]
	public static bool MJKLCCKELAJ<T>(NativeArray<T> HHAMBPGBENG, int JEOEJJBKODC, Allocator ALDDPOOJFGI, NativeArrayOptions BAELEFOBFMO = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2596C20", Offset = "0x2595A20", VA = "0x182596C20")]
	public static bool MJKLCCKELAJ<T>(NativeList<T> MOAFNEBEDKD, int JEOEJJBKODC, Allocator ALDDPOOJFGI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum LKHLODFBHNK
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
public interface ANBCOICGLMP
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JFHNCNFHEFL(LKHLODFBHNK FBJIHPHAKKE);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int DBCLBIONAIB(LKHLODFBHNK FBJIHPHAKKE);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds AABFFGMDMJB();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MIEEPGFAHAN(LKHLODFBHNK FBJIHPHAKKE, AGIBOIPDIEB MHIFCIEBDFO, int HMKMJMBAOGM = -1);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MGPLABDHAAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const int IJGIOFJDCHN = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<float3> BLHCGKLECIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<float3> OFFFOBNCBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float4> AAPMFICMBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float4> JDPOLGIHEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeArray<float2> OJIBOMEGNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<int> NFEHFPNPIEJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool KOELFDEDMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6149870", Offset = "0x6148670", VA = "0x186149870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GEHBAEEJLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x614A2A0", Offset = "0x61490A0", VA = "0x18614A2A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int ELCABDHJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x614A510", Offset = "0x6149310", VA = "0x18614A510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool JDBEMNEDKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x61498B0", Offset = "0x61486B0", VA = "0x1861498B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61498F0", Offset = "0x61486F0", VA = "0x1861498F0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61496A0", Offset = "0x61484A0", VA = "0x1861496A0")]
	public void CFLBAOLHBFM(int MCFPLAICKOP, int LHBKINCEPEH, Allocator ALDDPOOJFGI, bool LMKFGOOEKCP, bool CFCKBMKMFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x614A550", Offset = "0x6149350", VA = "0x18614A550")]
	public void NPMMHLCHOFH(int MCFPLAICKOP, int LHBKINCEPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x614A5D0", Offset = "0x61493D0", VA = "0x18614A5D0", Slot = "6")]
	public bool ONJGKCELFDE(Mesh HCHDFAPIGCD, bool PMICLONNFOB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6149A00", Offset = "0x6148800", VA = "0x186149A00")]
	public bool GBJBJBGMNAL(Mesh HCHDFAPIGCD, MGPLABDHAAM MOMGEKGGBIK, bool PMICLONNFOB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x614A030", Offset = "0x6148E30", VA = "0x18614A030")]
	public void GHCIFJGGKPO(MGPLABDHAAM HCHDFAPIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x614A3D0", Offset = "0x61491D0", VA = "0x18614A3D0")]
	public MGPLABDHAAM LOCLECIGPFG(Allocator ALDDPOOJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x614A2E0", Offset = "0x61490E0", VA = "0x18614A2E0")]
	public long KOKBEECEFEH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6149640", Offset = "0x6148440", VA = "0x186149640")]
	public void BBHJBDKKGMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public MGPLABDHAAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JCMODLMGAGF
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x613FEB0", Offset = "0x613ECB0", VA = "0x18613FEB0")]
	public static void JPCBNIODHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EDPJNOIOHNJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeList<float3> BLHCGKLECIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> OFFFOBNCBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<int> JDEADGNEEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeArray<float4> HLMJIJEFMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<float4> MJEAGHAGKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<float4> BDDNCPHLNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<float3> GIFPHNNIOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<int> NFEHFPNPIEJ;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int GEHBAEEJLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x613EBD0", Offset = "0x613D9D0", VA = "0x18613EBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int ELCABDHJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x613F0A0", Offset = "0x613DEA0", VA = "0x18613F0A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PJOIDEOPKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x613EB90", Offset = "0x613D990", VA = "0x18613EB90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x613F3D0", Offset = "0x613E1D0", VA = "0x18613F3D0")]
	public EDPJNOIOHNJ(int MCFPLAICKOP, int LHBKINCEPEH, int LKBAANPFGNK, Allocator ALDDPOOJFGI = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x613F0E0", Offset = "0x613DEE0", VA = "0x18613F0E0")]
	public EDPJNOIOHNJ(Mesh HCHDFAPIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x613E200", Offset = "0x613D000", VA = "0x18613E200", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x613E310", Offset = "0x613D110", VA = "0x18613E310")]
	public void GHCIFJGGKPO(EDPJNOIOHNJ HCHDFAPIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x613EC10", Offset = "0x613DA10", VA = "0x18613EC10")]
	private void MDDFEFONBCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x613E610", Offset = "0x613D410", VA = "0x18613E610")]
	private void GNGKBKLLMJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KJCDEGKLPML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int NKAFIJGNFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int GEHBAEEJLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public int AEAHDEEJDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int ELCABDHJDJE;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x11F6A40", Offset = "0x11F5840", VA = "0x1811F6A40")]
	public KJCDEGKLPML(int KHPJEMLCLNN, int BHKPNGHCBGD, int NIAPLMNAGEM, int LNKPNAAAPMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HBIPFJMKGHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<KJCDEGKLPML> CKKOEGFKCID
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x825D70", Offset = "0x824B70", VA = "0x180825D70")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<KJCDEGKLPML>);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x825DE0", Offset = "0x824BE0", VA = "0x180825DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public EDPJNOIOHNJ NAEHHPHLDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F00", Offset = "0x7B7D00", VA = "0x1807B8F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x613F870", Offset = "0x613E670", VA = "0x18613F870")]
	public HBIPFJMKGHM(IEnumerable<EDPJNOIOHNJ> LMOFJDPLHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x613F800", Offset = "0x613E600", VA = "0x18613F800", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum JKEPHBBOAEI
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class DHCGKLDDANO
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static NativeArray<float2> JPCAHJEJABO;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static NativeArray<float3> FNKLHEDKFLM;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static NativeArray<float4> CPONNJMBEFO;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static NativeArray<int> ENBKABEFJFF;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x613C8F0", Offset = "0x613B6F0", VA = "0x18613C8F0")]
	public static void JPCBNIODHMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x613C7E0", Offset = "0x613B5E0", VA = "0x18613C7E0")]
	public static NativeArray<float2> JOPFGEJFPJK(NativeArray<float2> KJFNFJJLLFK, int ABBPJIHPJFI, NativeArray<float2> JJAECBJHAMC, int LKIJCNJHLHP)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x613C6D0", Offset = "0x613B4D0", VA = "0x18613C6D0")]
	public static NativeArray<float3> IOGMABPGCBB(NativeArray<float3> KJFNFJJLLFK, int ABBPJIHPJFI, NativeArray<float3> JJAECBJHAMC, int LKIJCNJHLHP)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x613C5C0", Offset = "0x613B3C0", VA = "0x18613C5C0")]
	public static NativeArray<float4> IDMAFDHOGME(NativeArray<float4> KJFNFJJLLFK, int ABBPJIHPJFI, NativeArray<float4> JJAECBJHAMC, int LKIJCNJHLHP)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x613C4B0", Offset = "0x613B2B0", VA = "0x18613C4B0")]
	public static NativeArray<int> CAPIEGMFOFM(NativeArray<int> KJFNFJJLLFK, int ABBPJIHPJFI, NativeArray<int> JJAECBJHAMC, int LKIJCNJHLHP)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x25B9B60", Offset = "0x25B8960", VA = "0x1825B9B60")]
	private static void MNHCEJFOIMD<T>(NativeArray<T> HHAMBPGBENG, int CMIFAPKEEGN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x25B9D60", Offset = "0x25B8B60", VA = "0x1825B9D60")]
	private static void NGCANBMKLCP<T>(NativeArray<T> KJFNFJJLLFK, int ABBPJIHPJFI, NativeArray<T> JJAECBJHAMC, int LKIJCNJHLHP, NativeArray<T> EFIKGKBNAFJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JLLFLNJKOPI
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal enum HDKGDLCENHE
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
	public class HPAGCEPMHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public MNPAJBCJHBA HCHDFAPIGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int PENODLEHIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int DJHNFANHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public float JFEHEJGIMOA;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x613FE70", Offset = "0x613EC70", VA = "0x18613FE70")]
		public HPAGCEPMHFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x613FE30", Offset = "0x613EC30", VA = "0x18613FE30")]
		public void NCJLPOJPDAM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<ANBCOICGLMP> MGEIFNHNIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly KCKOIHMNECF MEEPAEBLFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int BHKPNGHCBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int LNKPNAAAPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool LNADJDJPDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal bool DCIIAJHNFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	internal bool BOJEDBILOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal HDKGDLCENHE OHBBLINCHPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal float3 INGEGMBOBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	internal float3 CMIFIPBPCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal float EDGLGJGBLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal int DLEGCNJEPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	internal int JKAELGPOIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int JJGEJKAAIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float ECIJAJAJGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float DMKEBLMHELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int GFCABHBEINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private long AGFGMLPCIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private long HPMCOOPJMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private long ABFBGLIOACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int BNINNCJPMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private MGPLABDHAAM IPCNHLGLDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private int BICBKCEAJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private List<HPAGCEPMHFA> JLLDLMFKMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal float OPNLDMPHCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool LKALHHKBEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private PCMLKLNKBCC PGAKEOBKCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private JobHandle BEHPDIEGBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	internal NativeArray<long> HEEKIENKHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool FDBMEJHMPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private JobHandle IIMDLENCBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private MGPLABDHAAM CODNGJDHNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform GJBKNCNCEOF;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh NAEHHPHLDLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D50", Offset = "0x7B7B50", VA = "0x1807B8D50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F60", Offset = "0x7B7D60", VA = "0x1807B8F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer HKLMJLOIFEN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C24E0", Offset = "0x7C12E0", VA = "0x1807C24E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int IMNIIAKDFID
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA0E470", Offset = "0xA0D270", VA = "0x180A0E470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int EIAEHOAOMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F0210", Offset = "0x7EF010", VA = "0x1807F0210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int GEHBAEEJLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6143DA0", Offset = "0x6142BA0", VA = "0x186143DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<ANBCOICGLMP> OBIHFJOAFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6140FA0", Offset = "0x613FDA0", VA = "0x186140FA0")]
	public void CCCPCCOBJEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6143E00", Offset = "0x6142C00", VA = "0x186143E00")]
	public void NAOFNBLGFGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6140B50", Offset = "0x613F950", VA = "0x186140B50")]
	public void BHNPODDLLIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6144B60", Offset = "0x6143960", VA = "0x186144B60")]
	public JLLFLNJKOPI(string OCCHBLONHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61441E0", Offset = "0x6142FE0", VA = "0x1861441E0")]
	public void NCJLPOJPDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x61442E0", Offset = "0x61430E0", VA = "0x1861442E0")]
	public void OMPNGGHMJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6143CC0", Offset = "0x6142AC0", VA = "0x186143CC0")]
	public void KCKNHKPHCBG(ANBCOICGLMP HKIMHJKLBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61448F0", Offset = "0x61436F0", VA = "0x1861448F0")]
	private void PNGMCFMOMLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6142BA0", Offset = "0x61419A0", VA = "0x186142BA0")]
	public bool GGFBGDFNIGH(ANBCOICGLMP HKIMHJKLBPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6140000", Offset = "0x613EE00", VA = "0x186140000")]
	public bool ADCHJIHGBAF(ANBCOICGLMP HKIMHJKLBPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6140060", Offset = "0x613EE60", VA = "0x186140060", Slot = "4")]
	public virtual void ADLCKNGNNHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6142B30", Offset = "0x6141930", VA = "0x186142B30")]
	public void FBDHBCJHPGK(Transform IBFDAAOJDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6140320", Offset = "0x613F120", VA = "0x186140320")]
	public bool BDNAAJEDDBG(Transform IBFDAAOJDII, [Out] bool KMEAMDDIEEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6141C80", Offset = "0x6140A80", VA = "0x186141C80")]
	public bool EHOMGMAFGIM(bool AALCJFLGONL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6143530", Offset = "0x6142330", VA = "0x186143530")]
	public void JBHMOKEHODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x61401C0", Offset = "0x613EFC0", VA = "0x1861401C0")]
	public bool AHNEHIBLGPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6142C50", Offset = "0x6141A50", VA = "0x186142C50")]
	public bool HMBJHFCCGFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6140D80", Offset = "0x613FB80", VA = "0x186140D80")]
	public bool BNDJALEOFGJ(Transform NBCGMJPEDEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6140270", Offset = "0x613F070", VA = "0x186140270")]
	public void BCCICNDINEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61413E0", Offset = "0x61401E0", VA = "0x1861413E0")]
	public bool DPBONGAEOIE(bool AALCJFLGONL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61434B0", Offset = "0x61422B0", VA = "0x1861434B0")]
	public void INLCCNHHIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6143DD0", Offset = "0x6142BD0", VA = "0x186143DD0")]
	public void MDGBGJNEOEH(MGPLABDHAAM HCHDFAPIGCD, int EICEICLLOHA, float OCGAHHHDJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6140190", Offset = "0x613EF90", VA = "0x186140190")]
	public void AFGJMPCEIPI(MNPAJBCJHBA EFPLAGLLEEJ, int EICEICLLOHA, float OCGAHHHDJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6143DC0", Offset = "0x6142BC0", VA = "0x186143DC0")]
	public long KOKBEECEFEH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7BFBA0", Offset = "0x7BE9A0", VA = "0x1807BFBA0")]
	public long NBHAKMIBEED()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6143EE0", Offset = "0x6142CE0", VA = "0x186143EE0")]
	public void NCEHJKBKKLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xA6A2D0", Offset = "0xA690D0", VA = "0x180A6A2D0")]
	internal void KDFBEGJFPLI(HDKGDLCENHE OCFJCPGDBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6140C30", Offset = "0x613FA30", VA = "0x186140C30")]
	private void BMDHAJIFNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6144330", Offset = "0x6143130", VA = "0x186144330")]
	private float PKCOJKKMFPE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x61435C0", Offset = "0x61423C0", VA = "0x1861435C0")]
	public void JCHIMFAODGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x61442B0", Offset = "0x61430B0", VA = "0x1861442B0")]
	private void NECMEJAEKMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6140DC0", Offset = "0x613FBC0", VA = "0x186140DC0")]
	private void BNNBPLJELGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6140FB0", Offset = "0x613FDB0", VA = "0x186140FB0")]
	private void DIHOKPDBPEK(MGPLABDHAAM NHMPAAEFHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6143A90", Offset = "0x6142890", VA = "0x186143A90")]
	private void JMHPMAKMJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6141490", Offset = "0x6140290", VA = "0x186141490")]
	private void EHNIFHCGCNH(MGPLABDHAAM HCHDFAPIGCD, MNPAJBCJHBA EFPLAGLLEEJ, int EICEICLLOHA, float OCGAHHHDJIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal struct PCMLKLNKBCC : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct JKCBEGAPCCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int OCBGNEJDLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int NCFBDOBCECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int JIADCKPACDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int JGBEHMMEKFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int GFMMNFFOEDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int JFCEDCEKNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int PENODLEHIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int DJHNFANHFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public float JFEHEJGIMOA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct NBMLFEADIMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NativeArray<float3> BLHCGKLECIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public NativeArray<float3> OFFFOBNCBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public NativeArray<float4> AAPMFICMBEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NativeArray<float4> JDPOLGIHEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public NativeArray<float2> OJIBOMEGNCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public NativeArray<int> NFEHFPNPIEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool ADDJAFNLEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int GEHBAEEJLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int ELCABDHJDJE;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6155290", Offset = "0x6154090", VA = "0x186155290")]
		public void CFLBAOLHBFM(int MCFPLAICKOP, int LHBKINCEPEH, Allocator ALDDPOOJFGI, bool CFCKBMKMFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6155040", Offset = "0x6153E40", VA = "0x186155040")]
		public static NBMLFEADIMM CEEGNKPMFGG(MGPLABDHAAM MCFKOLILEBF)
		{
			return default(NBMLFEADIMM);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x61553E0", Offset = "0x61541E0", VA = "0x1861553E0")]
		public void NCJLPOJPDAM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<JKCBEGAPCCL> EGMFHGDKEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NBMLFEADIMM CPGBDAOBNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NBMLFEADIMM NHMPAAEFHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private float3 NEJDDNLIADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float3 BMAJNDOOOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* LBBAEAPKNPD;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x614F4F0", Offset = "0x614E2F0", VA = "0x18614F4F0")]
	public PCMLKLNKBCC([In] List<JLLFLNJKOPI.HPAGCEPMHFA> BFLBDJNMPPF, [In] MGPLABDHAAM KLMKOLCEOPJ, [In] JLLFLNJKOPI FMHFICFLKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x614F0D0", Offset = "0x614DED0", VA = "0x18614F0D0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x614ED50", Offset = "0x614DB50", VA = "0x18614ED50")]
	public void BDGPEGFCGCB(List<JLLFLNJKOPI.HPAGCEPMHFA> PHACADEBPNK, [In] JLLFLNJKOPI FMHFICFLKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x614F4D0", Offset = "0x614E2D0", VA = "0x18614F4D0")]
	private bool NMEFDFBJPOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x614F0E0", Offset = "0x614DEE0", VA = "0x18614F0E0")]
	private MNPAJBCJHBA HHCLAHCBCEJ(int JMEIEPBKEDE, Allocator ALDDPOOJFGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x614DA90", Offset = "0x614C890", VA = "0x18614DA90")]
	private void BCHFFCEBLBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x614F1B0", Offset = "0x614DFB0", VA = "0x18614F1B0")]
	private JKCBEGAPCCL KCBDEOHNPJO([In] JKCBEGAPCCL FFCINECBPBH, int EDBLOMGCDJD, [In] NativeArray<int> PBHPDJIAGJG, [In] NativeArray<bool> JKIBDMJJBEI, NativeArray<int> AIFDNKOMFLO)
	{
		return default(JKCBEGAPCCL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x614F010", Offset = "0x614DE10", VA = "0x18614F010")]
	private static int EFFDMLCIGGC(NativeArray<int> PBHPDJIAGJG, int HMLKBMNKCKM, int LNCGFNKBAGL, int DIALDKNFKIP)
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
		private static readonly ProfilerMarker CINLKHGGBDD;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly ProfilerMarker NLEDLCKJKDC;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly ProfilerMarker EBCOKHLPBAN;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal const int PCAIBJILENJ = 65000;

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
		private Dictionary<Material, List<JLLFLNJKOPI>> ILAINABNMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal List<JLLFLNJKOPI> LGIBJLKNFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private List<MeshRenderer> DCIFCDFGGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool HKNNPCOOCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int LGIMNPHNFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private Dictionary<int, float> MJPGOEFMJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private Dictionary<int, Color> LJILCBAGCPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<int, Vector4> OFCOCMMMKNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private Dictionary<int, Matrix4x4> NCECIOHJMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private JLLFLNJKOPI LLJEBEFGIIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Material HHLFBDANKFI;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> IEEHDDFFNPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int PDNHEHFGKCD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6153A40", Offset = "0x6152840", VA = "0x186153A40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6151040", Offset = "0x614FE40", VA = "0x186151040")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x614FF10", Offset = "0x614ED10", VA = "0x18614FF10")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x614F930", Offset = "0x614E730", VA = "0x18614F930")]
		public JLLFLNJKOPI AddToBatchedMesh(ANBCOICGLMP LNFFKLBIHFF, Material NLKDDMHEDOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6152CE0", Offset = "0x6151AE0", VA = "0x186152CE0")]
		public void RemoveFromBatchedMesh(ANBCOICGLMP HCHDFAPIGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x614FDE0", Offset = "0x614EBE0", VA = "0x18614FDE0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6152E20", Offset = "0x6151C20", VA = "0x186152E20")]
		public void SetMaterialProperty(int CMJOIMNALBN, Color DNOKCMICDIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x61532B0", Offset = "0x61520B0", VA = "0x1861532B0")]
		public void SetMaterialProperty(int CMJOIMNALBN, float MAEBFBHFPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x61534D0", Offset = "0x61522D0", VA = "0x1861534D0")]
		public void SetMaterialProperty(int CMJOIMNALBN, Vector4 ACOBIKOBIGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6153050", Offset = "0x6151E50", VA = "0x186153050")]
		public void SetMaterialProperty(int CMJOIMNALBN, Matrix4x4 NOCBMIFHKJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x61504F0", Offset = "0x614F2F0", VA = "0x1861504F0")]
		private void JICMJPHNAGE(Renderer FNMHNENOEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61500D0", Offset = "0x614EED0", VA = "0x1861500D0")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x614FDD0", Offset = "0x614EBD0", VA = "0x18614FDD0")]
		private void BKGONKBPLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6150C40", Offset = "0x614FA40", VA = "0x186150C40")]
		private void NMOGDLMILIK(bool MAKMHJDACDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6150100", Offset = "0x614EF00", VA = "0x186150100")]
		private JLLFLNJKOPI IJOOGEGOAIG(ANBCOICGLMP HCHDFAPIGCD, Material NLKDDMHEDOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6150310", Offset = "0x614F110", VA = "0x186150310")]
		private JLLFLNJKOPI IPNFPCBAMAK(Material NLKDDMHEDOF, int FAFEJCHCOIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x614F9D0", Offset = "0x614E7D0", VA = "0x18614F9D0")]
		private JLLFLNJKOPI BBHDABNJPMP(Material NLKDDMHEDOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1705280", Offset = "0x1704080", VA = "0x181705280")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6150AE0", Offset = "0x614F8E0", VA = "0x186150AE0")]
		public void MarkDirty(ANBCOICGLMP HCHDFAPIGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6152500", Offset = "0x6151300", VA = "0x186152500")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x61500E0", Offset = "0x614EEE0", VA = "0x1861500E0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6151330", Offset = "0x6150130", VA = "0x186151330")]
		public void RebatchOptimally()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x61537D0", Offset = "0x61525D0", VA = "0x1861537D0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ENOIMIGBOJK
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static bool DBKJADOMPIJ;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static Vector3 JIMNOCMAEFL;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int MKGMANOHHEC;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int HENPFAPMBEN;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int HGIFPBLFODK;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int BPHKNAMCCMI;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static List<BatchedMeshRenderer> EFMIBMOCBOK;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool DDFNODFFKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6153E70", Offset = "0x6152C70", VA = "0x186153E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6153A90", Offset = "0x6152890", VA = "0x186153A90")]
	public static void AAEOMMPCBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6153C20", Offset = "0x6152A20", VA = "0x186153C20")]
	public static void EDBKGLEAKOI(BatchedMeshRenderer KCFHKMOPIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6154ED0", Offset = "0x6153CD0", VA = "0x186154ED0")]
	public static void NJJGMHODIKN(BatchedMeshRenderer KCFHKMOPIEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6154020", Offset = "0x6152E20", VA = "0x186154020")]
	public static void HMBJHFCCGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6154C40", Offset = "0x6153A40", VA = "0x186154C40")]
	public static void IFILFADOCCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6153F30", Offset = "0x6152D30", VA = "0x186153F30")]
	public static int GCKIGHGGPHJ()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KPMFCBKJELL<KeyType> : JLLFLNJKOPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Dictionary<KeyType, ANBCOICGLMP> DHCKFACCAJJ;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3B8D810", Offset = "0x3B8C610", VA = "0x183B8D810")]
	public KPMFCBKJELL(string OCCHBLONHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3B8D7C0", Offset = "0x3B8C5C0", VA = "0x183B8D7C0")]
	public void KCKNHKPHCBG(KeyType ONOECNHBCDA, ANBCOICGLMP HKIMHJKLBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3B8D600", Offset = "0x3B8C400", VA = "0x183B8D600")]
	public bool CKOJOCKIJBH(KeyType ONOECNHBCDA, ANBCOICGLMP EPCEPEEEFCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3B8D550", Offset = "0x3B8C350", VA = "0x183B8D550")]
	public void AONNHDJLIAK(KeyType ONOECNHBCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3B8D460", Offset = "0x3B8C260", VA = "0x183B8D460", Slot = "4")]
	public override void ADLCKNGNNHO()
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
