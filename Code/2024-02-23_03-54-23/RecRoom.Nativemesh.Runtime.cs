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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D1B20", Offset = "0x7D0520", VA = "0x1807D1B20")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FDHFDDGPBFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int LHEOIBGJDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 CPIMPAJPGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion CGJPFIFLIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 GEELPAEEMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int KCEDECNMLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int IBKABMHFCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int EFKIDGNHAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float DJAIJJDJAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 PDGEDGJIFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool MPHNMFGEBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public LPIBLMIGNCM GHEPKPCLMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 ADOOOBOLKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float PMGPKAHKJIA;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MNPEKFKOHDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static JGIOJJGGDBP FMKHPGOMPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<FDHFDDGPBFM> FFCEPKNFOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<FEFAOGELEAI> OCANFJCBGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<JKMEEPDPANG> IOICIDOPPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<BJPEKJEJMDP> GIAJJNCOAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<FEFAOGELEAI> NEBBGBEGPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<AJPMHJAPEPF> LHFHFHPGNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<BJPEKJEJMDP>> EPIBLHJALIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<PLJCJABFAIC> FFNABJABPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> NDEICNNMPFN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IMMIALKKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBAD540", Offset = "0xBABF40", VA = "0x180BAD540")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xBAC4E0", Offset = "0xBAAEE0", VA = "0x180BAC4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EAGAKCKFBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBAD550", Offset = "0xBABF50", VA = "0x180BAD550")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBACFF0", Offset = "0xBAB9F0", VA = "0x180BACFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6033350", Offset = "0x6031D50", VA = "0x186033350")]
	public MNPEKFKOHDI(int GADGECMBKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6031BF0", Offset = "0x60305F0", VA = "0x186031BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6031A20", Offset = "0x6030420", VA = "0x186031A20")]
	public void CHHCLLKKAAE(JobHandle HFPNAGFOPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6031800", Offset = "0x6030200", VA = "0x186031800")]
	public void BNJPGEHINNG(FDHFDDGPBFM MFNOAEFOKBK, PLJCJABFAIC EANMCFJPLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6031C10", Offset = "0x6030610", VA = "0x186031C10")]
	public void GPLDIAMAHEK(JKMEEPDPANG MFNOAEFOKBK, NativeArray<BJPEKJEJMDP> ADEACHKEABK, int COOBDEHLEOH, int OMBMJGHHAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6031D50", Offset = "0x6030750", VA = "0x186031D50")]
	public JobHandle KMPKHECPKHD(INDDBAPPCEM NAAGAICHNAE, DKGFHPPPJBM LNJFJMOALMK, float3 IJDNGKFKEDB, quaternion ANHJKGCAOMF, float HNFFFMDOHKG, bool PDLMFLDPKIG, int CKECHJKLOMB = 0, int CMFGCNPDMJA = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6033010", Offset = "0x6031A10", VA = "0x186033010")]
	public static JobHandle OGKOBDGOLPP(PMCOFGKDNGB ACCGPNHBEFL, INDDBAPPCEM NAAGAICHNAE, FDHFDDGPBFM MFNOAEFOKBK, JobHandle HFPNAGFOPLB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6032D60", Offset = "0x6031760", VA = "0x186032D60")]
	public static JobHandle LJPEJLPNKNK(ACPNGEEGLLC ACCGPNHBEFL, INDDBAPPCEM NAAGAICHNAE, JKMEEPDPANG MFNOAEFOKBK, NativeArray<BJPEKJEJMDP> ADEACHKEABK, int COOBDEHLEOH, int OMBMJGHHAON, JobHandle HFPNAGFOPLB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BCPPOHKPIOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct GEIIOOKDHJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half INJFEKKFIFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort GGEJLOFJENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte LGGHMNEIFHJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int COOBDEHLEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int OMBMJGHHAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> IEFNFGFDBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> PAOJFKHEHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> BHCGBLDJJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> OMCNDCEHOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<GEIIOOKDHJC> NIBOJJINGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> NHMIEPCJCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> KGHMEIOIKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 MHFPEKNDKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 NCDEALMJNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 HMGGEKNFPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 EFPBIAHHGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long CKCNBJDIEPM;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long GJDBMOGNLMB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float PJIGIEJOIEL;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool PPHKJLKGIAH;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DFOJBNCOKOO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x601FAA0", Offset = "0x601E4A0", VA = "0x18601FAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x601F9A0", Offset = "0x601E3A0", VA = "0x18601F9A0")]
	public void CHHCLLKKAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6021970", Offset = "0x6020370", VA = "0x186021970")]
	public static BCPPOHKPIOJ NDFPICIGPEG(Allocator FNHHOCKOINK, INDDBAPPCEM JGGMPFDFHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60215A0", Offset = "0x601FFA0", VA = "0x1860215A0")]
	public static BCPPOHKPIOJ NDFPICIGPEG(Allocator FNHHOCKOINK, NativeArray<float3> NDEMHJPHDAF, NativeArray<float3> BNIDFGHMFDB, NativeArray<float2> FBGOODLOJKB, NativeArray<float4> ILBEPKLGBHG, bool CMOHPKMNKFM, NativeArray<float4> PNKHOFOKDDP, NativeArray<int> JMNLCKPLCAM, int COOBDEHLEOH, int LBDMINCHIKM, int OMBMJGHHAON, int COMBBDPCDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60203A0", Offset = "0x601EDA0", VA = "0x1860203A0")]
	public INDDBAPPCEM FOKHANKEDFG(Allocator FNHHOCKOINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6021290", Offset = "0x601FC90", VA = "0x186021290")]
	public void MABMPDACOBP(Mesh PCJADICJELP, bool ACAKCBAPDPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60208C0", Offset = "0x601F2C0", VA = "0x1860208C0")]
	public long FPKIFFCDHDI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6020250", Offset = "0x601EC50", VA = "0x186020250")]
	private void EPGLAEIGFDP(int JKBBFJJFMMH, int FIFBHKJHCEF, Allocator FNHHOCKOINK, bool OBEFDPKEGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6020D70", Offset = "0x601F770", VA = "0x186020D70")]
	private float3 INEHEINLAKJ(int AGPOANHMAGC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60213F0", Offset = "0x601FDF0", VA = "0x1860213F0")]
	private void MGDCHNCIAJO(int AGPOANHMAGC, float3 FGEMNKIMNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6020360", Offset = "0x601ED60", VA = "0x186020360")]
	private float3 FCNJNBMCOAG(int AGPOANHMAGC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6021240", Offset = "0x601FC40", VA = "0x186021240")]
	private void LPJIKPLDOLH(int AGPOANHMAGC, float3 FGEMNKIMNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6020950", Offset = "0x601F350", VA = "0x186020950")]
	private float4 GCKKMJCGJGB(int AGPOANHMAGC)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6021370", Offset = "0x601FD70", VA = "0x186021370")]
	private void MANENLKDNIK(int AGPOANHMAGC, float4 FGEMNKIMNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x601F940", Offset = "0x601E340", VA = "0x18601F940")]
	private float2 BJMDHBJFBAK(int AGPOANHMAGC)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6020E00", Offset = "0x601F800", VA = "0x186020E00")]
	private void KJBLLENKDKA(int AGPOANHMAGC, float2 FGEMNKIMNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6020F10", Offset = "0x601F910", VA = "0x186020F10")]
	private void LLFGNBIKBJF(NativeArray<float3> NDEMHJPHDAF, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x601F8C0", Offset = "0x601E2C0", VA = "0x18601F8C0")]
	private void BGBPAJFKEGE(NativeArray<float3> BNIDFGHMFDB, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6021E40", Offset = "0x6020840", VA = "0x186021E40")]
	private void PHPPOFDOPNL(NativeArray<float2> FBGOODLOJKB, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x601FFC0", Offset = "0x601E9C0", VA = "0x18601FFC0")]
	private void DMNEGDJCABD(NativeArray<float4> DCFGBPPHIFA, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x601FAE0", Offset = "0x601E4E0", VA = "0x18601FAE0")]
	private void DAAPOBBCBKA(Allocator FNHHOCKOINK, NativeArray<float4> ILBEPKLGBHG, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6021BB0", Offset = "0x60205B0", VA = "0x186021BB0")]
	private static void NIILGIEOELH(NativeArray<float4> AAILKMEHKBK, NativeArray<GEIIOOKDHJC> PNDHBMNLPBD, NativeArray<byte> BJGOFFHMAKG, int COOBDEHLEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60209C0", Offset = "0x601F3C0", VA = "0x1860209C0")]
	private void HKOHLMICHFA(Allocator FNHHOCKOINK, NativeArray<int> JMNLCKPLCAM, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6020AA0", Offset = "0x601F4A0", VA = "0x186020AA0")]
	private static NativeArray<byte> ILKGKHBHFMC(Allocator FNHHOCKOINK, NativeArray<int> JMNLCKPLCAM, int IDIEFHHFPCE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60211A0", Offset = "0x601FBA0", VA = "0x1860211A0")]
	private static void LMKBDMGDOOH(NativeArray<int> NCABAHNHPPK, NativeArray<byte> HLBELIFPJDD, int OMBMJGHHAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6021CF0", Offset = "0x60206F0", VA = "0x186021CF0")]
	private static float3 NOAEPDPBHGE(ushort EAGKEMDFHNL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6020090", Offset = "0x601EA90", VA = "0x186020090")]
	private static ushort ELPEJNEGMDC(float3 FGEMNKIMNKN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public BCPPOHKPIOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GDHGIBDIFEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float2 LJINDFIJDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float2 KIOOKMJBFDM;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FDKIFOIFLIF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<GDHGIBDIFEP> PKKJEIHJOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<int> LONDIFJNCAI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int IMMIALKKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0920", Offset = "0x7AF320", VA = "0x1807B0920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EAGAKCKFBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B1080", Offset = "0x7AFA80", VA = "0x1807B1080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6028E80", Offset = "0x6027880", VA = "0x186028E80")]
	public FDKIFOIFLIF(int JKBBFJJFMMH, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6028E20", Offset = "0x6027820", VA = "0x186028E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6028D40", Offset = "0x6027740", VA = "0x186028D40")]
	public void ABNKOKNAONG(FDKIFOIFLIF AMCIMJPLADE, int EKANNDJCBLJ, int DAGOHCNFGEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class EFAGGMIPCKA
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static FDKIFOIFLIF NLAKNPLFEHC;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static NativeList<FEFAOGELEAI> FDFDMAEGBIF;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int[] PCHGPOENOBA;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static bool CNFHELOMBAM;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Dictionary<int, FDKIFOIFLIF> JJDLBGFLKJP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Dictionary<int, FDKIFOIFLIF> NMPAPPPLCMI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool BICENOLMKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6027C40", Offset = "0x6026640", VA = "0x186027C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<FEFAOGELEAI> BCILLMMIOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6027560", Offset = "0x6025F60", VA = "0x186027560")]
		get
		{
			return default(NativeList<FEFAOGELEAI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static FDKIFOIFLIF HJLBPHFHPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6028A40", Offset = "0x6027440", VA = "0x186028A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6027630", Offset = "0x6026030", VA = "0x186027630")]
	private static void BOBAPCNOIFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6027600", Offset = "0x6026000", VA = "0x186027600")]
	public static int BHPDGHOAOLP(bool ILHKPMBNHPF, int MGFMLEPBGPH, bool CCHDEAGOGEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60288A0", Offset = "0x60272A0", VA = "0x1860288A0")]
	private static int KCMCKNGPIEJ(int MGFMLEPBGPH, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6028210", Offset = "0x6026C10", VA = "0x186028210")]
	private static int HDDAMLFNDGE(int MGFMLEPBGPH, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6028580", Offset = "0x6026F80", VA = "0x186028580")]
	public static int IJNEGDKFGPI(int GGLFIAJMIFD, int MGFMLEPBGPH, int GFOBHBCDBNP, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6027D70", Offset = "0x6026770", VA = "0x186027D70")]
	public static int FIIDPJIHGNH(int GGLFIAJMIFD, int MGFMLEPBGPH, int GFOBHBCDBNP, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6028230", Offset = "0x6026C30", VA = "0x186028230")]
	public static int HNMFOFPKLNA(int GFOBHBCDBNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6028220", Offset = "0x6026C20", VA = "0x186028220")]
	private static int HEHBJLCJJFB(int MGFMLEPBGPH, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60288C0", Offset = "0x60272C0", VA = "0x1860288C0")]
	private static int MEHDHINOFHH(int MGFMLEPBGPH, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60288E0", Offset = "0x60272E0", VA = "0x1860288E0")]
	public static int MMCFNAKNGOD(int GGLFIAJMIFD, int MGFMLEPBGPH, int GFOBHBCDBNP, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6027CC0", Offset = "0x60266C0", VA = "0x186027CC0")]
	public static int CIJPBHPDAIG(int GGLFIAJMIFD, int MGFMLEPBGPH, int GFOBHBCDBNP, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6027D50", Offset = "0x6026750", VA = "0x186027D50")]
	public static int FHAFDJNOHDA(int GFOBHBCDBNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6028AE0", Offset = "0x60274E0", VA = "0x186028AE0")]
	public static FDKIFOIFLIF PCKDBGBHNDN(int MGFMLEPBGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6028610", Offset = "0x6027010", VA = "0x186028610")]
	private static FDKIFOIFLIF JDOHDGMIMJF(int MGFMLEPBGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6028950", Offset = "0x6027350", VA = "0x186028950")]
	public static FDKIFOIFLIF NBGMJDAGIFM(int MGFMLEPBGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6028240", Offset = "0x6026C40", VA = "0x186028240")]
	private static FDKIFOIFLIF HOFHNOMFDMC(int MGFMLEPBGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6027E00", Offset = "0x6026800", VA = "0x186027E00")]
	public static void GBGMMGKBFOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct JKMEEPDPANG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int MDMHBPPKCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3 CPIMPAJPGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public quaternion CGJPFIFLIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float GEELPAEEMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float LCGKLHLGFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int KCEDECNMLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int IBKABMHFCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int EFKIDGNHAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool FFLBAFAIALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool IFNKAKIMOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float DJAIJJDJAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 PDGEDGJIFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool EIIEOFMLAKJ;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct AJPMHJAPEPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int NAPPKAOEFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int BHMKEIAOLBO;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ACPNGEEGLLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<JKMEEPDPANG> DKIBHCDMEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<BJPEKJEJMDP> FMNAIPDFOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeArray<FEFAOGELEAI> JGLBKCIFOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<AJPMHJAPEPF> GEGHICHABMA;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x601F230", Offset = "0x601DC30", VA = "0x18601F230")]
	public ACPNGEEGLLC(NativeArray<BJPEKJEJMDP> FMNAIPDFOEA, int BFFGCOIILMK = 1, Allocator FNHHOCKOINK = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x601F140", Offset = "0x601DB40", VA = "0x18601F140", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct IODDGCNOEKC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeArray<GDHGIBDIFEP> HCGJHAHJHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<int> DPMNJKEEIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<FEFAOGELEAI> JIDGOGGCBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeList<JKMEEPDPANG> DKIBHCDMEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<BJPEKJEJMDP> FMNAIPDFOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<FEFAOGELEAI> JGLBKCIFOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	public NativeArray<AJPMHJAPEPF> GEGHICHABMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private int FMGLONOKFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private int NKDPIAJCGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private float3 MKOKGNGKDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private quaternion DGDAILKNHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private float3 NAOFFFIJKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JKJMBAKFJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KMEOOHBEBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KHHAAKJPHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FDAGMFLLHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> EOKDJIFDBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FCDGJOJNCLP;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6030DF0", Offset = "0x602F7F0", VA = "0x186030DF0")]
	public IODDGCNOEKC(MNPEKFKOHDI OIOMANJGKON, INDDBAPPCEM JIJGPIGACGE, float3 HGONBMKEHCC, quaternion MLEDPDPMPNO, float KNEEOLHLNNN, int CKECHJKLOMB = 0, int CMFGCNPDMJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6030BC0", Offset = "0x602F5C0", VA = "0x186030BC0")]
	public IODDGCNOEKC(ACPNGEEGLLC OIOMANJGKON, INDDBAPPCEM JIJGPIGACGE, float3 HGONBMKEHCC, quaternion MLEDPDPMPNO, float3 KNEEOLHLNNN, int CKECHJKLOMB = 0, int CMFGCNPDMJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6030A90", Offset = "0x602F490", VA = "0x186030A90")]
	private float3 ONGJNOAPJHA(float3 KIICICDHHMF, Matrix4x4 MOKNKEHJHFP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6030A10", Offset = "0x602F410", VA = "0x186030A10")]
	private float3x3 KDHGJNFLEBD(float3x3 PACEFEGKEAF, float3x3 IMBLDHIKKDI)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x602F290", Offset = "0x602DC90", VA = "0x18602F290")]
	private float BFDPEBFHBEM(float CMIJAKFGAEH, float KLCNIHDNHPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x602F700", Offset = "0x602E100", VA = "0x18602F700", Slot = "4")]
	public void Execute(int MCGKIOCGDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60308A0", Offset = "0x602F2A0", VA = "0x1860308A0")]
	private void IBJCNEIMDED(int PHHHCKNFBEE, float3 HGKJDOIPDNM, float3 GKJEHHDBDOI, float3 IACENKFIOLG, float NLAEHEEAFBH, bool AGKHLPKFJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x602F2A0", Offset = "0x602DCA0", VA = "0x18602F2A0")]
	private void DOGIMIHNHFK(JKMEEPDPANG IPNPIFKCHIE, float3 AAMPHNBHBHG, float3x3 NFELANJKNHP, float CMIJAKFGAEH, int DDEJPBHNFII, int FMEIGAEPGLM, int OCFCOOOIDBE, float GCBKFJHNBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x602EC40", Offset = "0x602D640", VA = "0x18602EC40")]
	private void AGOHDABEMFK(int PHHHCKNFBEE, int MJNFIIMDFCL, JKMEEPDPANG IPNPIFKCHIE, float3 AAMPHNBHBHG, float3x3 NFELANJKNHP, bool EAIIKAHNBMG, float CMIJAKFGAEH, int LKAMJENHKBB, int MBOMCPMIJMA, int OCFCOOOIDBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct PMCOFGKDNGB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeList<FDHFDDGPBFM> MNCBEDCLDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeList<FEFAOGELEAI> CNGPFGPPIKP;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6034BC0", Offset = "0x60335C0", VA = "0x186034BC0")]
	public PMCOFGKDNGB(int BFFGCOIILMK, Allocator FNHHOCKOINK = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6034B20", Offset = "0x6033520", VA = "0x186034B20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct GOPIBKHKAHJ : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private enum DNKDKLFPFKN
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
	private NativeList<float3> DFHKPBPDGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private NativeArray<float3> MMBBDNAMEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	[ReadOnly]
	private NativeList<int> AGOJLKMGFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeArray<int> FEOCCENNMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeArray<float4> NNKMDFDHFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private NativeArray<float4> CGPIODEHFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private NativeArray<float4> GCJIBIMALBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> CPCPDLJBJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private NativeList<FEFAOGELEAI> IHAEMBEJKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<FDHFDDGPBFM> MNCBEDCLDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<FEFAOGELEAI> CNGPFGPPIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private int FMGLONOKFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private int NKDPIAJCGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JKJMBAKFJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> KMEOOHBEBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KHHAAKJPHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FDAGMFLLHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> EOKDJIFDBLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FCDGJOJNCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private float3 NAOFFFIJKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private quaternion DGDAILKNHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private float3 MKOKGNGKDNM;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x602D4F0", Offset = "0x602BEF0", VA = "0x18602D4F0")]
	public GOPIBKHKAHJ(MNPEKFKOHDI OIOMANJGKON, INDDBAPPCEM JIJGPIGACGE, float3 HGONBMKEHCC, quaternion MLEDPDPMPNO, float KNEEOLHLNNN, int CKECHJKLOMB = 0, int CMFGCNPDMJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x602D6E0", Offset = "0x602C0E0", VA = "0x18602D6E0")]
	public GOPIBKHKAHJ(PMCOFGKDNGB MFNOAEFOKBK, INDDBAPPCEM JIJGPIGACGE, float3 HGONBMKEHCC, quaternion MLEDPDPMPNO, float3 KNEEOLHLNNN, int CKECHJKLOMB = 0, int CMFGCNPDMJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x602C150", Offset = "0x602AB50", VA = "0x18602C150", Slot = "4")]
	public void Execute(int MCGKIOCGDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x602D0B0", Offset = "0x602BAB0", VA = "0x18602D0B0")]
	private void JLMMMHPAHON(float4x4 BBKBGGOCPLL, int MCGKIOCGDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x602C0E0", Offset = "0x602AAE0", VA = "0x18602C0E0")]
	private DNKDKLFPFKN AHPCABINNIJ(float3 GKJEHHDBDOI)
	{
		return default(DNKDKLFPFKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x602D460", Offset = "0x602BE60", VA = "0x18602D460")]
	private float4 OEBKIDOLCOI(DNKDKLFPFKN CJHDBNANIHI, int OJANCMLFDOJ)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x602D4B0", Offset = "0x602BEB0", VA = "0x18602D4B0")]
	private float2 PAMKFLJMHFH(DNKDKLFPFKN CJHDBNANIHI, float3 HGKJDOIPDNM)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PLJCJABFAIC
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum BPEGJKBPJLG
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static PLJCJABFAIC FEAMHHDKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float3 FFAIKMBLIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3x3 CAPHJLBJELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 DPKBEHGMNCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public BPEGJKBPJLG MIOIDKGGEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 PGHLKNFGBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 HJMOOPBFHPL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool LIEFAHOJBOO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6034350", Offset = "0x6032D50", VA = "0x186034350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 GNAGFCEEPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x60348E0", Offset = "0x60332E0", VA = "0x1860348E0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6034A30", Offset = "0x6033430", VA = "0x186034A30")]
	public PLJCJABFAIC(float3 HGKJDOIPDNM, quaternion PGPLGEJKHLI, float3 BFFGCOIILMK, BPEGJKBPJLG ADAMDPHPFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6034360", Offset = "0x6032D60", VA = "0x186034360")]
	public float JCNNMJDOLMO(float3 AAMPHNBHBHG, float AINKGNEFIPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60347F0", Offset = "0x60331F0", VA = "0x1860347F0")]
	public bool PAFKFNAFIEL(float3 GKJEHHDBDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60340A0", Offset = "0x6032AA0", VA = "0x1860340A0")]
	public void BCFMKALPAMP(float3 JOMODIAMGAB, float3x3 CCBFIDIHHOD, float MNIGHKINAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6034250", Offset = "0x6032C50", VA = "0x186034250")]
	private void FMMPOLOODPC(float3 INKDDDGDGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6034560", Offset = "0x6032F60", VA = "0x186034560")]
	public void MABDILGKPCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct OIPOBPOMCNJ : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeList<PLJCJABFAIC> MFNOAEFOKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeList<float3> IEFNFGFDBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeList<int> KGHMEIOIKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NDEICNNMPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<FEFAOGELEAI> CNGPFGPPIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int HLCMGMPLDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int JOCPNEBBMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private float AINKGNEFIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private float PMPGLJOGDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> ANDBNGCKLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> DLGFOKFKDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> FFJKOJKJDEM;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6034000", Offset = "0x6032A00", VA = "0x186034000")]
	public OIPOBPOMCNJ(INDDBAPPCEM PCJADICJELP, float EMFOBMJODDD, int DAGOHCNFGEF, int DDEJPBHNFII, NativeList<PLJCJABFAIC> MFNOAEFOKBK, NativeArray<int> NDEICNNMPFN, NativeList<FEFAOGELEAI> CNGPFGPPIKP, DKGFHPPPJBM LNJFJMOALMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6033620", Offset = "0x6032020", VA = "0x186033620", Slot = "4")]
	public void Execute(int FFBIJLMCPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6033560", Offset = "0x6031F60", VA = "0x186033560")]
	private bool CJAPHGCHDKE(PLJCJABFAIC MAGGDEMNFDG, PLJCJABFAIC LFCFPOEDJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6033D60", Offset = "0x6032760", VA = "0x186033D60")]
	private bool HHICKDPMMPK(PLJCJABFAIC KGLKPBOCCOO, int HHHALBBCNLG, int EKLGIIPJPPN, int EGEDDIDLEMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DKGFHPPPJBM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public NativeArray<bool> GMFBCLGMIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeArray<int> OFFAMEEOEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> EAIBGMCFONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float> OAOGIBFNOAI;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6027460", Offset = "0x6025E60", VA = "0x186027460")]
	public void EPGLAEIGFDP(int JKBBFJJFMMH, int FIFBHKJHCEF, Allocator FNHHOCKOINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6027440", Offset = "0x6025E40", VA = "0x186027440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6027350", Offset = "0x6025D50", VA = "0x186027350")]
	public void CHHCLLKKAAE(JobHandle HFPNAGFOPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public DKGFHPPPJBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[BurstCompile]
public struct COKKLBDJMEM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeList<float3> IEFNFGFDBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<float3> PAOJFKHEHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<float4> NIBOJJINGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<float2> OMCNDCEHOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private NativeList<int> KGHMEIOIKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> BHCGBLDJJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NativeArray<int> OCNBGMBFNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[ReadOnly]
	private NativeArray<bool> ANDBNGCKLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[ReadOnly]
	private NativeArray<bool> DLGFOKFKDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[ReadOnly]
	private int CKECHJKLOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private int CMFGCNPDMJA;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6027250", Offset = "0x6025C50", VA = "0x186027250")]
	public COKKLBDJMEM(INDDBAPPCEM PCJADICJELP, DKGFHPPPJBM LNJFJMOALMK, int CMFGCNPDMJA = 0, int CKECHJKLOMB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6026E70", Offset = "0x6025870", VA = "0x186026E70", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6026E10", Offset = "0x6025810", VA = "0x186026E10")]
	private void DGFAHIHANDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class IHODKCAMABN
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x26C9550", Offset = "0x26C7F50", VA = "0x1826C9550")]
	public static bool CGNHKOLOKIJ<T>(NativeArray<T> NIKMHLBDDHG, int BFFGCOIILMK, Allocator FNHHOCKOINK, NativeArrayOptions HKFMBOCPCME = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x26C95F0", Offset = "0x26C7FF0", VA = "0x1826C95F0")]
	public static bool CGNHKOLOKIJ<T>(NativeList<T> EPNEAFACLDA, int BFFGCOIILMK, Allocator FNHHOCKOINK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum LDMFHDIDKEI
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
public interface ODBDAGKGKIO
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BKLMJIMHPDK(LDMFHDIDKEI GGLFIAJMIFD);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int PENHKMNILAM(LDMFHDIDKEI GGLFIAJMIFD);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds DKBHODMHEHG();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DPBDHALBJNH(LDMFHDIDKEI GGLFIAJMIFD, MNPEKFKOHDI DCOGAPHOCJI, int IIDILGDJBJD = -1);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class INDDBAPPCEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const int OLGCPDBKELI = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<float3> MEIHJBPJEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<float3> CONPEFOPBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float4> DGCKEBKAPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float4> IECDOHHMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeArray<float2> DLLOEOAAHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<int> OOPGOFPKGEO;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool INMLDJBGPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x602DF60", Offset = "0x602C960", VA = "0x18602DF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IMMIALKKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x602E490", Offset = "0x602CE90", VA = "0x18602E490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EAGAKCKFBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x602E450", Offset = "0x602CE50", VA = "0x18602E450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DFOJBNCOKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x602DF20", Offset = "0x602C920", VA = "0x18602DF20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x602DFA0", Offset = "0x602C9A0", VA = "0x18602DFA0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x602E130", Offset = "0x602CB30", VA = "0x18602E130")]
	public void EPGLAEIGFDP(int JKBBFJJFMMH, int FIFBHKJHCEF, Allocator FNHHOCKOINK, bool BKHFBDLIKDA, bool OBEFDPKEGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x602E0B0", Offset = "0x602CAB0", VA = "0x18602E0B0")]
	public void EKPFACEGKBP(int JKBBFJJFMMH, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x602DB40", Offset = "0x602C540", VA = "0x18602DB40", Slot = "6")]
	public bool BHKCLHNABLA(Mesh PCJADICJELP, bool ACAKCBAPDPH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x602E610", Offset = "0x602D010", VA = "0x18602E610")]
	public bool MNENJDCEAPO(Mesh PCJADICJELP, INDDBAPPCEM DNJHOANGOJI, bool ACAKCBAPDPH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x602D8D0", Offset = "0x602C2D0", VA = "0x18602D8D0")]
	public void ABNKOKNAONG(INDDBAPPCEM PCJADICJELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x602E4D0", Offset = "0x602CED0", VA = "0x18602E4D0")]
	public INDDBAPPCEM LEIGIPOJOGD(Allocator FNHHOCKOINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x602E360", Offset = "0x602CD60", VA = "0x18602E360")]
	public long FPKIFFCDHDI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x602E300", Offset = "0x602CD00", VA = "0x18602E300")]
	public void FJGBIMFHAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7AE800", Offset = "0x7AD200", VA = "0x1807AE800")]
	public INDDBAPPCEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MKPMMFPEIJF
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x60316B0", Offset = "0x60300B0", VA = "0x1860316B0")]
	public static void GBGMMGKBFOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class FHIKKKLJNEN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeList<float3> MEIHJBPJEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> CONPEFOPBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<int> NGEMMBKHOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeArray<float4> KBMIGHOHOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<float4> KFHIGGGGBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<float4> BDMIECOFOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<float3> KONHCIINAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<int> OOPGOFPKGEO;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int IMMIALKKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6029860", Offset = "0x6028260", VA = "0x186029860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int EAGAKCKFBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6029820", Offset = "0x6028220", VA = "0x186029820")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PCJFKPMIPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60297E0", Offset = "0x60281E0", VA = "0x1860297E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x602A110", Offset = "0x6028B10", VA = "0x18602A110")]
	public FHIKKKLJNEN(int JKBBFJJFMMH, int FIFBHKJHCEF, int FINKIICJPMC, Allocator FNHHOCKOINK = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6029E20", Offset = "0x6028820", VA = "0x186029E20")]
	public FHIKKKLJNEN(Mesh PCJADICJELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60296D0", Offset = "0x60280D0", VA = "0x1860296D0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60293D0", Offset = "0x6027DD0", VA = "0x1860293D0")]
	public void ABNKOKNAONG(FHIKKKLJNEN PCJADICJELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6028F40", Offset = "0x6027940", VA = "0x186028F40")]
	private void AAPCGECGDBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60298A0", Offset = "0x60282A0", VA = "0x1860298A0")]
	private void JPKOCOGKCFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FEFAOGELEAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int MBHJKEKLPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int IMMIALKKAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public int HIBCDCKOLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int EAGAKCKFBEO;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x117B970", Offset = "0x117A370", VA = "0x18117B970")]
	public FEFAOGELEAI(int DDEJPBHNFII, int COOBDEHLEOH, int DAGOHCNFGEF, int OMBMJGHHAON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class JGIOJJGGDBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<FEFAOGELEAI> OIDIDJKBCEH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xB644E0", Offset = "0xB62EE0", VA = "0x180B644E0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<FEFAOGELEAI>);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1C094C0", Offset = "0x1C07EC0", VA = "0x181C094C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FHIKKKLJNEN FGEFIKKOOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7AC270", Offset = "0x7AAC70", VA = "0x1807AC270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7AAC60", Offset = "0x7A9660", VA = "0x1807AAC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60310F0", Offset = "0x602FAF0", VA = "0x1860310F0")]
	public JGIOJJGGDBP(IEnumerable<FHIKKKLJNEN> AIHIMILDJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6031080", Offset = "0x602FA80", VA = "0x186031080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum LPIBLMIGNCM
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class AMAFAGEGDFI
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static NativeArray<float2> CGOOHEEGAKJ;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static NativeArray<float3> JMBCNNBCHEB;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static NativeArray<float4> GMNAAAHDABD;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static NativeArray<int> FCJCEBNBPFN;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x601F580", Offset = "0x601DF80", VA = "0x18601F580")]
	public static void GBGMMGKBFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x601F470", Offset = "0x601DE70", VA = "0x18601F470")]
	public static NativeArray<float2> CFCKIJGOCCC(NativeArray<float2> GHKKGLLLJNG, int GNNPAPJPBGB, NativeArray<float2> KDAIGOLNFBF, int ADMGCOJACNH)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x601F7B0", Offset = "0x601E1B0", VA = "0x18601F7B0")]
	public static NativeArray<float3> MMDNKDIMBJN(NativeArray<float3> GHKKGLLLJNG, int GNNPAPJPBGB, NativeArray<float3> KDAIGOLNFBF, int ADMGCOJACNH)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x601F6A0", Offset = "0x601E0A0", VA = "0x18601F6A0")]
	public static NativeArray<float4> GEPFCCFNFEA(NativeArray<float4> GHKKGLLLJNG, int GNNPAPJPBGB, NativeArray<float4> KDAIGOLNFBF, int ADMGCOJACNH)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x601F360", Offset = "0x601DD60", VA = "0x18601F360")]
	public static NativeArray<int> BPBCEIGPMGF(NativeArray<int> GHKKGLLLJNG, int GNNPAPJPBGB, NativeArray<int> KDAIGOLNFBF, int ADMGCOJACNH)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C622B0", Offset = "0x2C60CB0", VA = "0x182C622B0")]
	private static void PNMECKNNNCP<T>(NativeArray<T> NIKMHLBDDHG, int JBPHKAEFNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C62200", Offset = "0x2C60C00", VA = "0x182C62200")]
	private static void MPEDPGPEGMJ<T>(NativeArray<T> GHKKGLLLJNG, int GNNPAPJPBGB, NativeArray<T> KDAIGOLNFBF, int ADMGCOJACNH, NativeArray<T> ELFPBLFJCMK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BLPFBPHAOLI
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal enum NEGLEKMHMEO
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
	public class DEODCKPJGOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public BCPPOHKPIOJ PCJADICJELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int ABAIGCEKPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int JPGODCDJDEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public float JCKPOEHPAOL;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6027310", Offset = "0x6025D10", VA = "0x186027310")]
		public DEODCKPJGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x60272D0", Offset = "0x6025CD0", VA = "0x1860272D0")]
		public void CHHCLLKKAAE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<ODBDAGKGKIO> BAFLFHMOJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly JFHNBCMMCBM KFEGNFNMHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int COOBDEHLEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int OMBMJGHHAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool KNGMMLJLDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal bool CEDGJLJNMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	internal bool PCJKDMDMCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal NEGLEKMHMEO ILNNMFPHEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal float3 EBGJHGFAHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	internal float3 DLNEBCBMHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal float HLBDIAKHJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal int EKFMCIFDKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	internal int FBEBPDOCHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int BDACDILFIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float PJOGDIDOFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float OOEOLKKLKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int AHAFOMBPNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private long BHHBFCJKFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private long IHDEHPBKHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private long MNKJOFNBHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int HKMMAHNGOKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private INDDBAPPCEM KGGKEFMCJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private int EPAMKHCDPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private List<DEODCKPJGOO> LPFOEGEKMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal float GECFKJCHNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool HFOADKHNGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FILMCLPNEHA OPMLAJHFIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private JobHandle LILCEFJGDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	internal NativeArray<long> OPJAICMFEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool KPJFIJIEBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private JobHandle LFNJNJKNKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private INDDBAPPCEM JKPHABKCDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform OPBKDAMPFBB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh FGEFIKKOOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7A91E0", Offset = "0x7A7BE0", VA = "0x1807A91E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7AC260", Offset = "0x7AAC60", VA = "0x1807AC260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer EJAPACOIFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7AC280", Offset = "0x7AAC80", VA = "0x1807AC280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EDFPJFMICPI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9B30E0", Offset = "0x9B1AE0", VA = "0x1809B30E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MAJHKLOIMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7DD5F0", Offset = "0x7DBFF0", VA = "0x1807DD5F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int IMMIALKKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6025200", Offset = "0x6023C00", VA = "0x186025200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<ODBDAGKGKIO> GBNOBILGCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A9200", Offset = "0x7A7C00", VA = "0x1807A9200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x60232D0", Offset = "0x6021CD0", VA = "0x1860232D0")]
	public void BEAJMANOOJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6024440", Offset = "0x6022E40", VA = "0x186024440")]
	public void FLBGCEOMAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x60262A0", Offset = "0x6024CA0", VA = "0x1860262A0")]
	public void OANGNFKFPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6026C20", Offset = "0x6025620", VA = "0x186026C20")]
	public BLPFBPHAOLI(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6023510", Offset = "0x6021F10", VA = "0x186023510")]
	public void CHHCLLKKAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6025250", Offset = "0x6023C50", VA = "0x186025250")]
	public void JIHNOCINLII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6024FC0", Offset = "0x60239C0", VA = "0x186024FC0")]
	public void IBOLJCNNBEB(ODBDAGKGKIO MPBAGKKKGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x60252A0", Offset = "0x6023CA0", VA = "0x1860252A0")]
	private void JJPHNIOBCOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6026B70", Offset = "0x6025570", VA = "0x186026B70")]
	public bool OHCNMKGOHJO(ODBDAGKGKIO MPBAGKKKGFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6025C80", Offset = "0x6024680", VA = "0x186025C80")]
	public bool NBEEIKJCOIK(ODBDAGKGKIO MPBAGKKKGFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6024530", Offset = "0x6022F30", VA = "0x186024530", Slot = "4")]
	public virtual void GMKCCPFLIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6024660", Offset = "0x6023060", VA = "0x186024660")]
	public void HMCFNELLPJI(Transform LIGDJMDPDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6023610", Offset = "0x6022010", VA = "0x186023610")]
	public bool FAGNAIKBMFN(Transform LIGDJMDPDAF, [Out] bool EGJKPDKGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6022420", Offset = "0x6020E20", VA = "0x186022420")]
	public bool BCKJLLIFPHM(bool CIKCMKPCHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x60246D0", Offset = "0x60230D0", VA = "0x1860246D0")]
	public void HPJPDPOJEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x60250A0", Offset = "0x6023AA0", VA = "0x1860250A0")]
	public bool ICENBGJFAMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6024760", Offset = "0x6023160", VA = "0x186024760")]
	public bool IAKFJFMJPEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6025510", Offset = "0x6023F10", VA = "0x186025510")]
	public bool LLEHHDOJHCJ(Transform AOOGIIEBLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6023EC0", Offset = "0x60228C0", VA = "0x186023EC0")]
	public void FKENPMKDHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6025150", Offset = "0x6023B50", VA = "0x186025150")]
	public bool IEKLCHAIIDN(bool CIKCMKPCHFM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6023E40", Offset = "0x6022840", VA = "0x186023E40")]
	public void FBIEBKMLOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6025220", Offset = "0x6023C20", VA = "0x186025220")]
	public void JBIILMELHGL(INDDBAPPCEM PCJADICJELP, int IKMGCEEEJIF, float MPPBPENHMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x60220C0", Offset = "0x6020AC0", VA = "0x1860220C0")]
	public void AEDMNBCADPJ(BCPPOHKPIOJ LJJLIEEHKBG, int IKMGCEEEJIF, float MPPBPENHMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6024520", Offset = "0x6022F20", VA = "0x186024520")]
	public long FPKIFFCDHDI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7B3520", Offset = "0x7B1F20", VA = "0x1807B3520")]
	public long GLNLIEFNOCH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6025550", Offset = "0x6023F50", VA = "0x186025550")]
	public void LNOBFONKHKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xA0B6D0", Offset = "0xA0A0D0", VA = "0x180A0B6D0")]
	internal void FDDBMCDHILM(NEGLEKMHMEO FENFBDLFCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x60222D0", Offset = "0x6020CD0", VA = "0x1860222D0")]
	private void BCBEFGEGPGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6025CE0", Offset = "0x60246E0", VA = "0x186025CE0")]
	private float NIDEIJGNFJI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6023F70", Offset = "0x6022970", VA = "0x186023F70")]
	public void FKIHEKOIHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x60235E0", Offset = "0x6021FE0", VA = "0x1860235E0")]
	private void EJMLBIDGLGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x60220F0", Offset = "0x6020AF0", VA = "0x1860220F0")]
	private void AHIMNAEJHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6025850", Offset = "0x6024250", VA = "0x186025850")]
	private void MCOONFPAAAI(INDDBAPPCEM OAJAADMPJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x60232E0", Offset = "0x6021CE0", VA = "0x1860232E0")]
	private void CGDLOAHFHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x6026380", Offset = "0x6024D80", VA = "0x186026380")]
	private void OBKFGHJBPFN(INDDBAPPCEM PCJADICJELP, BCPPOHKPIOJ LJJLIEEHKBG, int IKMGCEEEJIF, float MPPBPENHMJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal struct FILMCLPNEHA : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct CHFAOHDHBCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int IIMAOOJIENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int DKNECAEIENF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int FJKPHNJNPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int OGALCJJEJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int IIDDHPGIOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int DOJMEDOJPGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int ABAIGCEKPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int JPGODCDJDEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public float JCKPOEHPAOL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct HDCEJLOJDKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NativeArray<float3> MEIHJBPJEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public NativeArray<float3> CONPEFOPBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public NativeArray<float4> DGCKEBKAPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NativeArray<float4> IECDOHHMDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public NativeArray<float2> DLLOEOAAHHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public NativeArray<int> OOPGOFPKGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool CMOHPKMNKFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int IMMIALKKAEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int EAGAKCKFBEO;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x603A7C0", Offset = "0x60391C0", VA = "0x18603A7C0")]
		public void EPGLAEIGFDP(int JKBBFJJFMMH, int FIFBHKJHCEF, Allocator FNHHOCKOINK, bool OBEFDPKEGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x603A4B0", Offset = "0x6038EB0", VA = "0x18603A4B0")]
		public static HDCEJLOJDKA AHAIGHMGLID(INDDBAPPCEM DJMHFPMABHB)
		{
			return default(HDCEJLOJDKA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x603A700", Offset = "0x6039100", VA = "0x18603A700")]
		public void CHHCLLKKAAE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<CHFAOHDHBCL> GGIAPHNHAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private HDCEJLOJDKA FJDNHKCBEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private HDCEJLOJDKA OAJAADMPJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private float3 CDCBNNIHIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float3 APCLCDFELFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* CHLCNIFNAKG;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x602BD90", Offset = "0x602A790", VA = "0x18602BD90")]
	public FILMCLPNEHA([In] List<BLPFBPHAOLI.DEODCKPJGOO> DAAGPHKHLAK, [In] INDDBAPPCEM BJDNDBBHMMM, [In] BLPFBPHAOLI EFIDHEGEIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x602A5F0", Offset = "0x6028FF0", VA = "0x18602A5F0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x602A330", Offset = "0x6028D30", VA = "0x18602A330")]
	public void AELGKBPFLJC(List<BLPFBPHAOLI.DEODCKPJGOO> PDEBLBKPFPF, [In] BLPFBPHAOLI EFIDHEGEIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x602BD70", Offset = "0x602A770", VA = "0x18602BD70")]
	private bool OEAHJEICCEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x602BCA0", Offset = "0x602A6A0", VA = "0x18602BCA0")]
	private BCPPOHKPIOJ MHKEPNEPHPC(int OENPJCNACDL, Allocator FNHHOCKOINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x602A920", Offset = "0x6029320", VA = "0x18602A920")]
	private void FNBAKCLDJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x602A600", Offset = "0x6029000", VA = "0x18602A600")]
	private CHFAOHDHBCL FFLIFPJELIE([In] CHFAOHDHBCL LNJGMMACIJE, int OIOINHDJNPM, [In] NativeArray<int> KGHMEIOIKFD, [In] NativeArray<bool> DLGFOKFKDHM, NativeArray<int> JNEOKPKGGDL)
	{
		return default(CHFAOHDHBCL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x602BBE0", Offset = "0x602A5E0", VA = "0x18602BBE0")]
	private static int IIPJBGKBIDA(NativeArray<int> KGHMEIOIKFD, int FAPMFGNFEKE, int EMKGLOCLCKM, int NIBAEOKEPDI)
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
		private static readonly ProfilerMarker ALDFFCNHLEP;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly ProfilerMarker EGBFHBJOMPO;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly ProfilerMarker IPNHODEJIPO;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal const int IPJKHJOLAJG = 65000;

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
		private Dictionary<Material, List<BLPFBPHAOLI>> OFGLDCGIJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal List<BLPFBPHAOLI> LPDEMAHHNBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private List<MeshRenderer> BAFKONDIGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool AOGPLOHOIOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int PANCIGBKICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private Dictionary<int, float> IONMGNIIMJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private Dictionary<int, Color> GLKJAIHGKGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<int, Vector4> KGNMAKFPIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private Dictionary<int, Matrix4x4> OPJEDHDBMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private BLPFBPHAOLI BGNEFCPKNNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Material HIMGEILBMOB;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> HPHAPFKKOGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7A9100", Offset = "0x7A7B00", VA = "0x1807A9100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int KBKDHNCLBBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6038EB0", Offset = "0x60378B0", VA = "0x186038EB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x60364B0", Offset = "0x6034EB0", VA = "0x1860364B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6034F80", Offset = "0x6033980", VA = "0x186034F80")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6034DA0", Offset = "0x60337A0", VA = "0x186034DA0")]
		public BLPFBPHAOLI AddToBatchedMesh(ODBDAGKGKIO MBILPDEFEMJ, Material OODGJPECLJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6038150", Offset = "0x6036B50", VA = "0x186038150")]
		public void RemoveFromBatchedMesh(ODBDAGKGKIO PCJADICJELP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6034E50", Offset = "0x6033850", VA = "0x186034E50")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6038290", Offset = "0x6036C90", VA = "0x186038290")]
		public void SetMaterialProperty(int CDIBIGKIGCI, Color IKNGOAKEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6038720", Offset = "0x6037120", VA = "0x186038720")]
		public void SetMaterialProperty(int CDIBIGKIGCI, float FDFHGIHHGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6038940", Offset = "0x6037340", VA = "0x186038940")]
		public void SetMaterialProperty(int CDIBIGKIGCI, Vector4 POMEINMNNLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x60384C0", Offset = "0x6036EC0", VA = "0x1860384C0")]
		public void SetMaterialProperty(int CDIBIGKIGCI, Matrix4x4 LMCFKCFFACO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6035EC0", Offset = "0x60348C0", VA = "0x186035EC0")]
		private void OGNGFDEENCH(Renderer AOCIMHKIBEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6035140", Offset = "0x6033B40", VA = "0x186035140")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6034E40", Offset = "0x6033840", VA = "0x186034E40")]
		private void BPOLAAIKLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6035550", Offset = "0x6033F50", VA = "0x186035550")]
		private void HCGKJPHBPFE(bool KMCEJKFJOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6035B50", Offset = "0x6034550", VA = "0x186035B50")]
		private BLPFBPHAOLI IFKGPOFFPCL(ODBDAGKGKIO PCJADICJELP, Material OODGJPECLJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6035950", Offset = "0x6034350", VA = "0x186035950")]
		private BLPFBPHAOLI HLIBEPANMLB(Material OODGJPECLJK, int OMJJHCLNDII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6035150", Offset = "0x6033B50", VA = "0x186035150")]
		private BLPFBPHAOLI GFALHFMDFHC(Material OODGJPECLJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x16A17E0", Offset = "0x16A01E0", VA = "0x1816A17E0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6035D60", Offset = "0x6034760", VA = "0x186035D60")]
		public void MarkDirty(ODBDAGKGKIO PCJADICJELP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6037970", Offset = "0x6036370", VA = "0x186037970")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6035B30", Offset = "0x6034530", VA = "0x186035B30")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x60367A0", Offset = "0x60351A0", VA = "0x1860367A0")]
		public void RebatchOptimally()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6038C40", Offset = "0x6037640", VA = "0x186038C40")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class EJPPPANLHFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static bool MDFDLDIICIJ;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static Vector3 FKPJEMPECHM;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int NAELOHHNIIJ;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int IOLCLHABMON;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int HHKELECJBPO;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int ABBMBADBDMA;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static List<BatchedMeshRenderer> PBPGOCANAON;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool EFKBBMENKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6038FA0", Offset = "0x60379A0", VA = "0x186038FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x603A250", Offset = "0x6038C50", VA = "0x18603A250")]
	public static void OHCMDEDMAIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6039D70", Offset = "0x6038770", VA = "0x186039D70")]
	public static void KOELNEFLNMH(BatchedMeshRenderer HCDHIDJNBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6038F00", Offset = "0x6037900", VA = "0x186038F00")]
	public static void DJDEONLFAOD(BatchedMeshRenderer HCDHIDJNBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6039150", Offset = "0x6037B50", VA = "0x186039150")]
	public static void IAKFJFMJPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6039FC0", Offset = "0x60389C0", VA = "0x186039FC0")]
	public static void MAAHHMBDNBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6039060", Offset = "0x6037A60", VA = "0x186039060")]
	public static int HMBGAENJPAI()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DNJLIBOGMNI<KeyType> : BLPFBPHAOLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Dictionary<KeyType, ODBDAGKGKIO> KFAECECIILN;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4F211B0", Offset = "0x4F1FBB0", VA = "0x184F211B0")]
	public DNJLIBOGMNI(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4F20E40", Offset = "0x4F1F840", VA = "0x184F20E40")]
	public void IBOLJCNNBEB(KeyType KCGLPAPOILB, ODBDAGKGKIO MPBAGKKKGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4F20E90", Offset = "0x4F1F890", VA = "0x184F20E90")]
	public bool LOHHNEBCDEF(KeyType KCGLPAPOILB, ODBDAGKGKIO HIEHEJLGDIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4F21050", Offset = "0x4F1FA50", VA = "0x184F21050")]
	public void NAOGAFPAJFI(KeyType KCGLPAPOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4F20E00", Offset = "0x4F1F800", VA = "0x184F20E00", Slot = "4")]
	public override void GMKCCPFLIEL()
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
