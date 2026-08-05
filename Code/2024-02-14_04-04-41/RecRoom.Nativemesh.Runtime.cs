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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C7B20", Offset = "0x7C6F20", VA = "0x1807C7B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xBA16D0", Offset = "0xBA0AD0", VA = "0x180BA16D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xBA0670", Offset = "0xB9FA70", VA = "0x180BA0670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EAGAKCKFBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBA16E0", Offset = "0xBA0AE0", VA = "0x180BA16E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBA1180", Offset = "0xBA0580", VA = "0x180BA1180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9920", Offset = "0x5FB8D20", VA = "0x185FB9920")]
	public MNPEKFKOHDI(int GADGECMBKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FB81C0", Offset = "0x5FB75C0", VA = "0x185FB81C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7FF0", Offset = "0x5FB73F0", VA = "0x185FB7FF0")]
	public void CHHCLLKKAAE(JobHandle HFPNAGFOPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7DD0", Offset = "0x5FB71D0", VA = "0x185FB7DD0")]
	public void BNJPGEHINNG(FDHFDDGPBFM MFNOAEFOKBK, PLJCJABFAIC EANMCFJPLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB81E0", Offset = "0x5FB75E0", VA = "0x185FB81E0")]
	public void GPLDIAMAHEK(JKMEEPDPANG MFNOAEFOKBK, NativeArray<BJPEKJEJMDP> ADEACHKEABK, int COOBDEHLEOH, int OMBMJGHHAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB8320", Offset = "0x5FB7720", VA = "0x185FB8320")]
	public JobHandle KMPKHECPKHD(INDDBAPPCEM NAAGAICHNAE, DKGFHPPPJBM LNJFJMOALMK, float3 IJDNGKFKEDB, quaternion ANHJKGCAOMF, float HNFFFMDOHKG, bool PDLMFLDPKIG, int CKECHJKLOMB = 0, int CMFGCNPDMJA = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB95E0", Offset = "0x5FB89E0", VA = "0x185FB95E0")]
	public static JobHandle OGKOBDGOLPP(PMCOFGKDNGB ACCGPNHBEFL, INDDBAPPCEM NAAGAICHNAE, FDHFDDGPBFM MFNOAEFOKBK, JobHandle HFPNAGFOPLB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9330", Offset = "0x5FB8730", VA = "0x185FB9330")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FA6070", Offset = "0x5FA5470", VA = "0x185FA6070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5F70", Offset = "0x5FA5370", VA = "0x185FA5F70")]
	public void CHHCLLKKAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7F40", Offset = "0x5FA7340", VA = "0x185FA7F40")]
	public static BCPPOHKPIOJ NDFPICIGPEG(Allocator FNHHOCKOINK, INDDBAPPCEM JGGMPFDFHKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7B70", Offset = "0x5FA6F70", VA = "0x185FA7B70")]
	public static BCPPOHKPIOJ NDFPICIGPEG(Allocator FNHHOCKOINK, NativeArray<float3> NDEMHJPHDAF, NativeArray<float3> BNIDFGHMFDB, NativeArray<float2> FBGOODLOJKB, NativeArray<float4> ILBEPKLGBHG, bool CMOHPKMNKFM, NativeArray<float4> PNKHOFOKDDP, NativeArray<int> JMNLCKPLCAM, int COOBDEHLEOH, int LBDMINCHIKM, int OMBMJGHHAON, int COMBBDPCDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6970", Offset = "0x5FA5D70", VA = "0x185FA6970")]
	public INDDBAPPCEM FOKHANKEDFG(Allocator FNHHOCKOINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7860", Offset = "0x5FA6C60", VA = "0x185FA7860")]
	public void MABMPDACOBP(Mesh PCJADICJELP, bool ACAKCBAPDPH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6E90", Offset = "0x5FA6290", VA = "0x185FA6E90")]
	public long FPKIFFCDHDI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6820", Offset = "0x5FA5C20", VA = "0x185FA6820")]
	private void EPGLAEIGFDP(int JKBBFJJFMMH, int FIFBHKJHCEF, Allocator FNHHOCKOINK, bool OBEFDPKEGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7340", Offset = "0x5FA6740", VA = "0x185FA7340")]
	private float3 INEHEINLAKJ(int AGPOANHMAGC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FA79C0", Offset = "0x5FA6DC0", VA = "0x185FA79C0")]
	private void MGDCHNCIAJO(int AGPOANHMAGC, float3 FGEMNKIMNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6930", Offset = "0x5FA5D30", VA = "0x185FA6930")]
	private float3 FCNJNBMCOAG(int AGPOANHMAGC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7810", Offset = "0x5FA6C10", VA = "0x185FA7810")]
	private void LPJIKPLDOLH(int AGPOANHMAGC, float3 FGEMNKIMNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6F20", Offset = "0x5FA6320", VA = "0x185FA6F20")]
	private float4 GCKKMJCGJGB(int AGPOANHMAGC)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7940", Offset = "0x5FA6D40", VA = "0x185FA7940")]
	private void MANENLKDNIK(int AGPOANHMAGC, float4 FGEMNKIMNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5F10", Offset = "0x5FA5310", VA = "0x185FA5F10")]
	private float2 BJMDHBJFBAK(int AGPOANHMAGC)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA73D0", Offset = "0x5FA67D0", VA = "0x185FA73D0")]
	private void KJBLLENKDKA(int AGPOANHMAGC, float2 FGEMNKIMNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA74E0", Offset = "0x5FA68E0", VA = "0x185FA74E0")]
	private void LLFGNBIKBJF(NativeArray<float3> NDEMHJPHDAF, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5E90", Offset = "0x5FA5290", VA = "0x185FA5E90")]
	private void BGBPAJFKEGE(NativeArray<float3> BNIDFGHMFDB, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8410", Offset = "0x5FA7810", VA = "0x185FA8410")]
	private void PHPPOFDOPNL(NativeArray<float2> FBGOODLOJKB, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6590", Offset = "0x5FA5990", VA = "0x185FA6590")]
	private void DMNEGDJCABD(NativeArray<float4> DCFGBPPHIFA, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FA60B0", Offset = "0x5FA54B0", VA = "0x185FA60B0")]
	private void DAAPOBBCBKA(Allocator FNHHOCKOINK, NativeArray<float4> ILBEPKLGBHG, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8180", Offset = "0x5FA7580", VA = "0x185FA8180")]
	private static void NIILGIEOELH(NativeArray<float4> AAILKMEHKBK, NativeArray<GEIIOOKDHJC> PNDHBMNLPBD, NativeArray<byte> BJGOFFHMAKG, int COOBDEHLEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6F90", Offset = "0x5FA6390", VA = "0x185FA6F90")]
	private void HKOHLMICHFA(Allocator FNHHOCKOINK, NativeArray<int> JMNLCKPLCAM, int COMBBDPCDOO, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7070", Offset = "0x5FA6470", VA = "0x185FA7070")]
	private static NativeArray<byte> ILKGKHBHFMC(Allocator FNHHOCKOINK, NativeArray<int> JMNLCKPLCAM, int IDIEFHHFPCE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5FA7770", Offset = "0x5FA6B70", VA = "0x185FA7770")]
	private static void LMKBDMGDOOH(NativeArray<int> NCABAHNHPPK, NativeArray<byte> HLBELIFPJDD, int OMBMJGHHAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FA82C0", Offset = "0x5FA76C0", VA = "0x185FA82C0")]
	private static float3 NOAEPDPBHGE(ushort EAGKEMDFHNL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FA6660", Offset = "0x5FA5A60", VA = "0x185FA6660")]
	private static ushort ELPEJNEGMDC(float3 FGEMNKIMNKN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
		[Cpp2IlInjected.Address(RVA = "0x7A6920", Offset = "0x7A5D20", VA = "0x1807A6920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EAGAKCKFBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7A7080", Offset = "0x7A6480", VA = "0x1807A7080")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF450", Offset = "0x5FAE850", VA = "0x185FAF450")]
	public FDKIFOIFLIF(int JKBBFJJFMMH, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF3F0", Offset = "0x5FAE7F0", VA = "0x185FAF3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF310", Offset = "0x5FAE710", VA = "0x185FAF310")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FAE210", Offset = "0x5FAD610", VA = "0x185FAE210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<FEFAOGELEAI> BCILLMMIOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FADB30", Offset = "0x5FACF30", VA = "0x185FADB30")]
		get
		{
			return default(NativeList<FEFAOGELEAI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static FDKIFOIFLIF HJLBPHFHPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF010", Offset = "0x5FAE410", VA = "0x185FAF010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5FADC00", Offset = "0x5FAD000", VA = "0x185FADC00")]
	private static void BOBAPCNOIFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5FADBD0", Offset = "0x5FACFD0", VA = "0x185FADBD0")]
	public static int BHPDGHOAOLP(bool ILHKPMBNHPF, int MGFMLEPBGPH, bool CCHDEAGOGEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5FAEE70", Offset = "0x5FAE270", VA = "0x185FAEE70")]
	private static int KCMCKNGPIEJ(int MGFMLEPBGPH, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE7E0", Offset = "0x5FADBE0", VA = "0x185FAE7E0")]
	private static int HDDAMLFNDGE(int MGFMLEPBGPH, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5FAEB50", Offset = "0x5FADF50", VA = "0x185FAEB50")]
	public static int IJNEGDKFGPI(int GGLFIAJMIFD, int MGFMLEPBGPH, int GFOBHBCDBNP, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE340", Offset = "0x5FAD740", VA = "0x185FAE340")]
	public static int FIIDPJIHGNH(int GGLFIAJMIFD, int MGFMLEPBGPH, int GFOBHBCDBNP, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE800", Offset = "0x5FADC00", VA = "0x185FAE800")]
	public static int HNMFOFPKLNA(int GFOBHBCDBNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE7F0", Offset = "0x5FADBF0", VA = "0x185FAE7F0")]
	private static int HEHBJLCJJFB(int MGFMLEPBGPH, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5FAEE90", Offset = "0x5FAE290", VA = "0x185FAEE90")]
	private static int MEHDHINOFHH(int MGFMLEPBGPH, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5FAEEB0", Offset = "0x5FAE2B0", VA = "0x185FAEEB0")]
	public static int MMCFNAKNGOD(int GGLFIAJMIFD, int MGFMLEPBGPH, int GFOBHBCDBNP, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE290", Offset = "0x5FAD690", VA = "0x185FAE290")]
	public static int CIJPBHPDAIG(int GGLFIAJMIFD, int MGFMLEPBGPH, int GFOBHBCDBNP, bool CKPLCCHCBNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE320", Offset = "0x5FAD720", VA = "0x185FAE320")]
	public static int FHAFDJNOHDA(int GFOBHBCDBNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF0B0", Offset = "0x5FAE4B0", VA = "0x185FAF0B0")]
	public static FDKIFOIFLIF PCKDBGBHNDN(int MGFMLEPBGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5FAEBE0", Offset = "0x5FADFE0", VA = "0x185FAEBE0")]
	private static FDKIFOIFLIF JDOHDGMIMJF(int MGFMLEPBGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FAEF20", Offset = "0x5FAE320", VA = "0x185FAEF20")]
	public static FDKIFOIFLIF NBGMJDAGIFM(int MGFMLEPBGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE810", Offset = "0x5FADC10", VA = "0x185FAE810")]
	private static FDKIFOIFLIF HOFHNOMFDMC(int MGFMLEPBGPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5FAE3D0", Offset = "0x5FAD7D0", VA = "0x185FAE3D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FA5800", Offset = "0x5FA4C00", VA = "0x185FA5800")]
	public ACPNGEEGLLC(NativeArray<BJPEKJEJMDP> FMNAIPDFOEA, int BFFGCOIILMK = 1, Allocator FNHHOCKOINK = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5710", Offset = "0x5FA4B10", VA = "0x185FA5710", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FB73C0", Offset = "0x5FB67C0", VA = "0x185FB73C0")]
	public IODDGCNOEKC(MNPEKFKOHDI OIOMANJGKON, INDDBAPPCEM JIJGPIGACGE, float3 HGONBMKEHCC, quaternion MLEDPDPMPNO, float KNEEOLHLNNN, int CKECHJKLOMB = 0, int CMFGCNPDMJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7190", Offset = "0x5FB6590", VA = "0x185FB7190")]
	public IODDGCNOEKC(ACPNGEEGLLC OIOMANJGKON, INDDBAPPCEM JIJGPIGACGE, float3 HGONBMKEHCC, quaternion MLEDPDPMPNO, float3 KNEEOLHLNNN, int CKECHJKLOMB = 0, int CMFGCNPDMJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7060", Offset = "0x5FB6460", VA = "0x185FB7060")]
	private float3 ONGJNOAPJHA(float3 KIICICDHHMF, Matrix4x4 MOKNKEHJHFP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6FE0", Offset = "0x5FB63E0", VA = "0x185FB6FE0")]
	private float3x3 KDHGJNFLEBD(float3x3 PACEFEGKEAF, float3x3 IMBLDHIKKDI)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5860", Offset = "0x5FB4C60", VA = "0x185FB5860")]
	private float BFDPEBFHBEM(float CMIJAKFGAEH, float KLCNIHDNHPD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5CD0", Offset = "0x5FB50D0", VA = "0x185FB5CD0", Slot = "4")]
	public void Execute(int MCGKIOCGDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB6E70", Offset = "0x5FB6270", VA = "0x185FB6E70")]
	private void IBJCNEIMDED(int PHHHCKNFBEE, float3 HGKJDOIPDNM, float3 GKJEHHDBDOI, float3 IACENKFIOLG, float NLAEHEEAFBH, bool AGKHLPKFJPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5870", Offset = "0x5FB4C70", VA = "0x185FB5870")]
	private void DOGIMIHNHFK(JKMEEPDPANG IPNPIFKCHIE, float3 AAMPHNBHBHG, float3x3 NFELANJKNHP, float CMIJAKFGAEH, int DDEJPBHNFII, int FMEIGAEPGLM, int OCFCOOOIDBE, float GCBKFJHNBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB5210", Offset = "0x5FB4610", VA = "0x185FB5210")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FBB190", Offset = "0x5FBA590", VA = "0x185FBB190")]
	public PMCOFGKDNGB(int BFFGCOIILMK, Allocator FNHHOCKOINK = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB0F0", Offset = "0x5FBA4F0", VA = "0x185FBB0F0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FB3AC0", Offset = "0x5FB2EC0", VA = "0x185FB3AC0")]
	public GOPIBKHKAHJ(MNPEKFKOHDI OIOMANJGKON, INDDBAPPCEM JIJGPIGACGE, float3 HGONBMKEHCC, quaternion MLEDPDPMPNO, float KNEEOLHLNNN, int CKECHJKLOMB = 0, int CMFGCNPDMJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3CB0", Offset = "0x5FB30B0", VA = "0x185FB3CB0")]
	public GOPIBKHKAHJ(PMCOFGKDNGB MFNOAEFOKBK, INDDBAPPCEM JIJGPIGACGE, float3 HGONBMKEHCC, quaternion MLEDPDPMPNO, float3 KNEEOLHLNNN, int CKECHJKLOMB = 0, int CMFGCNPDMJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2720", Offset = "0x5FB1B20", VA = "0x185FB2720", Slot = "4")]
	public void Execute(int MCGKIOCGDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3680", Offset = "0x5FB2A80", VA = "0x185FB3680")]
	private void JLMMMHPAHON(float4x4 BBKBGGOCPLL, int MCGKIOCGDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FB26B0", Offset = "0x5FB1AB0", VA = "0x185FB26B0")]
	private DNKDKLFPFKN AHPCABINNIJ(float3 GKJEHHDBDOI)
	{
		return default(DNKDKLFPFKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3A30", Offset = "0x5FB2E30", VA = "0x185FB3A30")]
	private float4 OEBKIDOLCOI(DNKDKLFPFKN CJHDBNANIHI, int OJANCMLFDOJ)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3A80", Offset = "0x5FB2E80", VA = "0x185FB3A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FBA920", Offset = "0x5FB9D20", VA = "0x185FBA920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 GNAGFCEEPHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5FBAEB0", Offset = "0x5FBA2B0", VA = "0x185FBAEB0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5FBB000", Offset = "0x5FBA400", VA = "0x185FBB000")]
	public PLJCJABFAIC(float3 HGKJDOIPDNM, quaternion PGPLGEJKHLI, float3 BFFGCOIILMK, BPEGJKBPJLG ADAMDPHPFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA930", Offset = "0x5FB9D30", VA = "0x185FBA930")]
	public float JCNNMJDOLMO(float3 AAMPHNBHBHG, float AINKGNEFIPJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FBADC0", Offset = "0x5FBA1C0", VA = "0x185FBADC0")]
	public bool PAFKFNAFIEL(float3 GKJEHHDBDOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA670", Offset = "0x5FB9A70", VA = "0x185FBA670")]
	public void BCFMKALPAMP(float3 JOMODIAMGAB, float3x3 CCBFIDIHHOD, float MNIGHKINAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA820", Offset = "0x5FB9C20", VA = "0x185FBA820")]
	private void FMMPOLOODPC(float3 INKDDDGDGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5FBAB30", Offset = "0x5FB9F30", VA = "0x185FBAB30")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FBA5D0", Offset = "0x5FB99D0", VA = "0x185FBA5D0")]
	public OIPOBPOMCNJ(INDDBAPPCEM PCJADICJELP, float EMFOBMJODDD, int DAGOHCNFGEF, int DDEJPBHNFII, NativeList<PLJCJABFAIC> MFNOAEFOKBK, NativeArray<int> NDEICNNMPFN, NativeList<FEFAOGELEAI> CNGPFGPPIKP, DKGFHPPPJBM LNJFJMOALMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9BF0", Offset = "0x5FB8FF0", VA = "0x185FB9BF0", Slot = "4")]
	public void Execute(int FFBIJLMCPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5FB9B30", Offset = "0x5FB8F30", VA = "0x185FB9B30")]
	private bool CJAPHGCHDKE(PLJCJABFAIC MAGGDEMNFDG, PLJCJABFAIC LFCFPOEDJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5FBA330", Offset = "0x5FB9730", VA = "0x185FBA330")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FADA30", Offset = "0x5FACE30", VA = "0x185FADA30")]
	public void EPGLAEIGFDP(int JKBBFJJFMMH, int FIFBHKJHCEF, Allocator FNHHOCKOINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5FADA10", Offset = "0x5FACE10", VA = "0x185FADA10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD920", Offset = "0x5FACD20", VA = "0x185FAD920")]
	public void CHHCLLKKAAE(JobHandle HFPNAGFOPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FAD820", Offset = "0x5FACC20", VA = "0x185FAD820")]
	public COKKLBDJMEM(INDDBAPPCEM PCJADICJELP, DKGFHPPPJBM LNJFJMOALMK, int CMFGCNPDMJA = 0, int CKECHJKLOMB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD440", Offset = "0x5FAC840", VA = "0x185FAD440", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD3E0", Offset = "0x5FAC7E0", VA = "0x185FAD3E0")]
	private void DGFAHIHANDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class IHODKCAMABN
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2674B80", Offset = "0x2673F80", VA = "0x182674B80")]
	public static bool CGNHKOLOKIJ<T>(NativeArray<T> NIKMHLBDDHG, int BFFGCOIILMK, Allocator FNHHOCKOINK, NativeArrayOptions HKFMBOCPCME = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2674C20", Offset = "0x2674020", VA = "0x182674C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FB4530", Offset = "0x5FB3930", VA = "0x185FB4530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IMMIALKKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4A60", Offset = "0x5FB3E60", VA = "0x185FB4A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EAGAKCKFBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4A20", Offset = "0x5FB3E20", VA = "0x185FB4A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool DFOJBNCOKOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5FB44F0", Offset = "0x5FB38F0", VA = "0x185FB44F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4570", Offset = "0x5FB3970", VA = "0x185FB4570", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4700", Offset = "0x5FB3B00", VA = "0x185FB4700")]
	public void EPGLAEIGFDP(int JKBBFJJFMMH, int FIFBHKJHCEF, Allocator FNHHOCKOINK, bool BKHFBDLIKDA, bool OBEFDPKEGMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4680", Offset = "0x5FB3A80", VA = "0x185FB4680")]
	public void EKPFACEGKBP(int JKBBFJJFMMH, int FIFBHKJHCEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4110", Offset = "0x5FB3510", VA = "0x185FB4110", Slot = "6")]
	public bool BHKCLHNABLA(Mesh PCJADICJELP, bool ACAKCBAPDPH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4BE0", Offset = "0x5FB3FE0", VA = "0x185FB4BE0")]
	public bool MNENJDCEAPO(Mesh PCJADICJELP, INDDBAPPCEM DNJHOANGOJI, bool ACAKCBAPDPH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5FB3EA0", Offset = "0x5FB32A0", VA = "0x185FB3EA0")]
	public void ABNKOKNAONG(INDDBAPPCEM PCJADICJELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4AA0", Offset = "0x5FB3EA0", VA = "0x185FB4AA0")]
	public INDDBAPPCEM LEIGIPOJOGD(Allocator FNHHOCKOINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5FB4930", Offset = "0x5FB3D30", VA = "0x185FB4930")]
	public long FPKIFFCDHDI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5FB48D0", Offset = "0x5FB3CD0", VA = "0x185FB48D0")]
	public void FJGBIMFHAFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
	public INDDBAPPCEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MKPMMFPEIJF
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7C80", Offset = "0x5FB7080", VA = "0x185FB7C80")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FAFE30", Offset = "0x5FAF230", VA = "0x185FAFE30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int EAGAKCKFBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5FAFDF0", Offset = "0x5FAF1F0", VA = "0x185FAFDF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PCJFKPMIPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5FAFDB0", Offset = "0x5FAF1B0", VA = "0x185FAFDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5FB06E0", Offset = "0x5FAFAE0", VA = "0x185FB06E0")]
	public FHIKKKLJNEN(int JKBBFJJFMMH, int FIFBHKJHCEF, int FINKIICJPMC, Allocator FNHHOCKOINK = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5FB03F0", Offset = "0x5FAF7F0", VA = "0x185FB03F0")]
	public FHIKKKLJNEN(Mesh PCJADICJELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFCA0", Offset = "0x5FAF0A0", VA = "0x185FAFCA0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF9A0", Offset = "0x5FAEDA0", VA = "0x185FAF9A0")]
	public void ABNKOKNAONG(FHIKKKLJNEN PCJADICJELP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5FAF510", Offset = "0x5FAE910", VA = "0x185FAF510")]
	private void AAPCGECGDBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5FAFE70", Offset = "0x5FAF270", VA = "0x185FAFE70")]
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
	[Cpp2IlInjected.Address(RVA = "0x1166DD0", Offset = "0x11661D0", VA = "0x181166DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB58670", Offset = "0xB57A70", VA = "0x180B58670")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<FEFAOGELEAI>);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1BEF8C0", Offset = "0x1BEECC0", VA = "0x181BEF8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public FHIKKKLJNEN FGEFIKKOOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7A2270", Offset = "0x7A1670", VA = "0x1807A2270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7A0C60", Offset = "0x7A0060", VA = "0x1807A0C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5FB76C0", Offset = "0x5FB6AC0", VA = "0x185FB76C0")]
	public JGIOJJGGDBP(IEnumerable<FHIKKKLJNEN> AIHIMILDJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5FB7650", Offset = "0x5FB6A50", VA = "0x185FB7650", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FA5B50", Offset = "0x5FA4F50", VA = "0x185FA5B50")]
	public static void GBGMMGKBFOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5A40", Offset = "0x5FA4E40", VA = "0x185FA5A40")]
	public static NativeArray<float2> CFCKIJGOCCC(NativeArray<float2> GHKKGLLLJNG, int GNNPAPJPBGB, NativeArray<float2> KDAIGOLNFBF, int ADMGCOJACNH)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5D80", Offset = "0x5FA5180", VA = "0x185FA5D80")]
	public static NativeArray<float3> MMDNKDIMBJN(NativeArray<float3> GHKKGLLLJNG, int GNNPAPJPBGB, NativeArray<float3> KDAIGOLNFBF, int ADMGCOJACNH)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5C70", Offset = "0x5FA5070", VA = "0x185FA5C70")]
	public static NativeArray<float4> GEPFCCFNFEA(NativeArray<float4> GHKKGLLLJNG, int GNNPAPJPBGB, NativeArray<float4> KDAIGOLNFBF, int ADMGCOJACNH)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5930", Offset = "0x5FA4D30", VA = "0x185FA5930")]
	public static NativeArray<int> BPBCEIGPMGF(NativeArray<int> GHKKGLLLJNG, int GNNPAPJPBGB, NativeArray<int> KDAIGOLNFBF, int ADMGCOJACNH)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x2C0A3E0", Offset = "0x2C097E0", VA = "0x182C0A3E0")]
	private static void PNMECKNNNCP<T>(NativeArray<T> NIKMHLBDDHG, int JBPHKAEFNGF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2C0A330", Offset = "0x2C09730", VA = "0x182C0A330")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FAD8E0", Offset = "0x5FACCE0", VA = "0x185FAD8E0")]
		public DEODCKPJGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD8A0", Offset = "0x5FACCA0", VA = "0x185FAD8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x79F1E0", Offset = "0x79E5E0", VA = "0x18079F1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7A2260", Offset = "0x7A1660", VA = "0x1807A2260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer EJAPACOIFGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7A2280", Offset = "0x7A1680", VA = "0x1807A2280")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int EDFPJFMICPI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9A7A20", Offset = "0x9A6E20", VA = "0x1809A7A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int MAJHKLOIMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7D35F0", Offset = "0x7D29F0", VA = "0x1807D35F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int IMMIALKKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB7D0", Offset = "0x5FAABD0", VA = "0x185FAB7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<ODBDAGKGKIO> GBNOBILGCEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x79F200", Offset = "0x79E600", VA = "0x18079F200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA98A0", Offset = "0x5FA8CA0", VA = "0x185FA98A0")]
	public void BEAJMANOOJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAA10", Offset = "0x5FA9E10", VA = "0x185FAAA10")]
	public void FLBGCEOMAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC870", Offset = "0x5FABC70", VA = "0x185FAC870")]
	public void OANGNFKFPPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD1F0", Offset = "0x5FAC5F0", VA = "0x185FAD1F0")]
	public BLPFBPHAOLI(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9AE0", Offset = "0x5FA8EE0", VA = "0x185FA9AE0")]
	public void CHHCLLKKAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB820", Offset = "0x5FAAC20", VA = "0x185FAB820")]
	public void JIHNOCINLII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB590", Offset = "0x5FAA990", VA = "0x185FAB590")]
	public void IBOLJCNNBEB(ODBDAGKGKIO MPBAGKKKGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB870", Offset = "0x5FAAC70", VA = "0x185FAB870")]
	private void JJPHNIOBCOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5FAD140", Offset = "0x5FAC540", VA = "0x185FAD140")]
	public bool OHCNMKGOHJO(ODBDAGKGKIO MPBAGKKKGFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC250", Offset = "0x5FAB650", VA = "0x185FAC250")]
	public bool NBEEIKJCOIK(ODBDAGKGKIO MPBAGKKKGFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAB00", Offset = "0x5FA9F00", VA = "0x185FAAB00", Slot = "4")]
	public virtual void GMKCCPFLIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAC30", Offset = "0x5FAA030", VA = "0x185FAAC30")]
	public void HMCFNELLPJI(Transform LIGDJMDPDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9BE0", Offset = "0x5FA8FE0", VA = "0x185FA9BE0")]
	public bool FAGNAIKBMFN(Transform LIGDJMDPDAF, [Out] bool EGJKPDKGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5FA89F0", Offset = "0x5FA7DF0", VA = "0x185FA89F0")]
	public bool BCKJLLIFPHM(bool CIKCMKPCHFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x5FAACA0", Offset = "0x5FAA0A0", VA = "0x185FAACA0")]
	public void HPJPDPOJEJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB670", Offset = "0x5FAAA70", VA = "0x185FAB670")]
	public bool ICENBGJFAMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAD30", Offset = "0x5FAA130", VA = "0x185FAAD30")]
	public bool IAKFJFMJPEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5FABAE0", Offset = "0x5FAAEE0", VA = "0x185FABAE0")]
	public bool LLEHHDOJHCJ(Transform AOOGIIEBLDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA490", Offset = "0x5FA9890", VA = "0x185FAA490")]
	public void FKENPMKDHNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB720", Offset = "0x5FAAB20", VA = "0x185FAB720")]
	public bool IEKLCHAIIDN(bool CIKCMKPCHFM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA410", Offset = "0x5FA9810", VA = "0x185FAA410")]
	public void FBIEBKMLOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5FAB7F0", Offset = "0x5FAABF0", VA = "0x185FAB7F0")]
	public void JBIILMELHGL(INDDBAPPCEM PCJADICJELP, int IKMGCEEEJIF, float MPPBPENHMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5FA8690", Offset = "0x5FA7A90", VA = "0x185FA8690")]
	public void AEDMNBCADPJ(BCPPOHKPIOJ LJJLIEEHKBG, int IKMGCEEEJIF, float MPPBPENHMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5FAAAF0", Offset = "0x5FA9EF0", VA = "0x185FAAAF0")]
	public long FPKIFFCDHDI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7A9520", Offset = "0x7A8920", VA = "0x1807A9520")]
	public long GLNLIEFNOCH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5FABB20", Offset = "0x5FAAF20", VA = "0x185FABB20")]
	public void LNOBFONKHKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xA00010", Offset = "0x9FF410", VA = "0x180A00010")]
	internal void FDDBMCDHILM(NEGLEKMHMEO FENFBDLFCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5FA88A0", Offset = "0x5FA7CA0", VA = "0x185FA88A0")]
	private void BCBEFGEGPGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC2B0", Offset = "0x5FAB6B0", VA = "0x185FAC2B0")]
	private float NIDEIJGNFJI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5FAA540", Offset = "0x5FA9940", VA = "0x185FAA540")]
	public void FKIHEKOIHGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5FA9BB0", Offset = "0x5FA8FB0", VA = "0x185FA9BB0")]
	private void EJMLBIDGLGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5FA86C0", Offset = "0x5FA7AC0", VA = "0x185FA86C0")]
	private void AHIMNAEJHEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5FABE20", Offset = "0x5FAB220", VA = "0x185FABE20")]
	private void MCOONFPAAAI(INDDBAPPCEM OAJAADMPJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5FA98B0", Offset = "0x5FA8CB0", VA = "0x185FA98B0")]
	private void CGDLOAHFHPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC950", Offset = "0x5FABD50", VA = "0x185FAC950")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FC0D90", Offset = "0x5FC0190", VA = "0x185FC0D90")]
		public void EPGLAEIGFDP(int JKBBFJJFMMH, int FIFBHKJHCEF, Allocator FNHHOCKOINK, bool OBEFDPKEGMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0A80", Offset = "0x5FBFE80", VA = "0x185FC0A80")]
		public static HDCEJLOJDKA AHAIGHMGLID(INDDBAPPCEM DJMHFPMABHB)
		{
			return default(HDCEJLOJDKA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5FC0CD0", Offset = "0x5FC00D0", VA = "0x185FC0CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5FB2360", Offset = "0x5FB1760", VA = "0x185FB2360")]
	public FILMCLPNEHA([In] List<BLPFBPHAOLI.DEODCKPJGOO> DAAGPHKHLAK, [In] INDDBAPPCEM BJDNDBBHMMM, [In] BLPFBPHAOLI EFIDHEGEIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0BC0", Offset = "0x5FAFFC0", VA = "0x185FB0BC0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0900", Offset = "0x5FAFD00", VA = "0x185FB0900")]
	public void AELGKBPFLJC(List<BLPFBPHAOLI.DEODCKPJGOO> PDEBLBKPFPF, [In] BLPFBPHAOLI EFIDHEGEIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2340", Offset = "0x5FB1740", VA = "0x185FB2340")]
	private bool OEAHJEICCEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5FB2270", Offset = "0x5FB1670", VA = "0x185FB2270")]
	private BCPPOHKPIOJ MHKEPNEPHPC(int OENPJCNACDL, Allocator FNHHOCKOINK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0EF0", Offset = "0x5FB02F0", VA = "0x185FB0EF0")]
	private void FNBAKCLDJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5FB0BD0", Offset = "0x5FAFFD0", VA = "0x185FB0BD0")]
	private CHFAOHDHBCL FFLIFPJELIE([In] CHFAOHDHBCL LNJGMMACIJE, int OIOINHDJNPM, [In] NativeArray<int> KGHMEIOIKFD, [In] NativeArray<bool> DLGFOKFKDHM, NativeArray<int> JNEOKPKGGDL)
	{
		return default(CHFAOHDHBCL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5FB21B0", Offset = "0x5FB15B0", VA = "0x185FB21B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x79F100", Offset = "0x79E500", VA = "0x18079F100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int KBKDHNCLBBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x5FBF480", Offset = "0x5FBE880", VA = "0x185FBF480")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCA80", Offset = "0x5FBBE80", VA = "0x185FBCA80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB550", Offset = "0x5FBA950", VA = "0x185FBB550")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB370", Offset = "0x5FBA770", VA = "0x185FBB370")]
		public BLPFBPHAOLI AddToBatchedMesh(ODBDAGKGKIO MBILPDEFEMJ, Material OODGJPECLJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE720", Offset = "0x5FBDB20", VA = "0x185FBE720")]
		public void RemoveFromBatchedMesh(ODBDAGKGKIO PCJADICJELP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB420", Offset = "0x5FBA820", VA = "0x185FBB420")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5FBE860", Offset = "0x5FBDC60", VA = "0x185FBE860")]
		public void SetMaterialProperty(int CDIBIGKIGCI, Color IKNGOAKEJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5FBECF0", Offset = "0x5FBE0F0", VA = "0x185FBECF0")]
		public void SetMaterialProperty(int CDIBIGKIGCI, float FDFHGIHHGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5FBEF10", Offset = "0x5FBE310", VA = "0x185FBEF10")]
		public void SetMaterialProperty(int CDIBIGKIGCI, Vector4 POMEINMNNLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5FBEA90", Offset = "0x5FBDE90", VA = "0x185FBEA90")]
		public void SetMaterialProperty(int CDIBIGKIGCI, Matrix4x4 LMCFKCFFACO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC490", Offset = "0x5FBB890", VA = "0x185FBC490")]
		private void OGNGFDEENCH(Renderer AOCIMHKIBEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB710", Offset = "0x5FBAB10", VA = "0x185FBB710")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB410", Offset = "0x5FBA810", VA = "0x185FBB410")]
		private void BPOLAAIKLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5FBBB20", Offset = "0x5FBAF20", VA = "0x185FBBB20")]
		private void HCGKJPHBPFE(bool KMCEJKFJOHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC120", Offset = "0x5FBB520", VA = "0x185FBC120")]
		private BLPFBPHAOLI IFKGPOFFPCL(ODBDAGKGKIO PCJADICJELP, Material OODGJPECLJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5FBBF20", Offset = "0x5FBB320", VA = "0x185FBBF20")]
		private BLPFBPHAOLI HLIBEPANMLB(Material OODGJPECLJK, int OMJJHCLNDII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x5FBB720", Offset = "0x5FBAB20", VA = "0x185FBB720")]
		private BLPFBPHAOLI GFALHFMDFHC(Material OODGJPECLJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x168BAB0", Offset = "0x168AEB0", VA = "0x18168BAB0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC330", Offset = "0x5FBB730", VA = "0x185FBC330")]
		public void MarkDirty(ODBDAGKGKIO PCJADICJELP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5FBDF40", Offset = "0x5FBD340", VA = "0x185FBDF40")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x5FBC100", Offset = "0x5FBB500", VA = "0x185FBC100")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5FBCD70", Offset = "0x5FBC170", VA = "0x185FBCD70")]
		public void RebatchOptimally()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5FBF210", Offset = "0x5FBE610", VA = "0x185FBF210")]
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
		[Cpp2IlInjected.Address(RVA = "0x5FBF570", Offset = "0x5FBE970", VA = "0x185FBF570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0820", Offset = "0x5FBFC20", VA = "0x185FC0820")]
	public static void OHCMDEDMAIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0340", Offset = "0x5FBF740", VA = "0x185FC0340")]
	public static void KOELNEFLNMH(BatchedMeshRenderer HCDHIDJNBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF4D0", Offset = "0x5FBE8D0", VA = "0x185FBF4D0")]
	public static void DJDEONLFAOD(BatchedMeshRenderer HCDHIDJNBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF720", Offset = "0x5FBEB20", VA = "0x185FBF720")]
	public static void IAKFJFMJPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0590", Offset = "0x5FBF990", VA = "0x185FC0590")]
	public static void MAAHHMBDNBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF630", Offset = "0x5FBEA30", VA = "0x185FBF630")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EB7100", Offset = "0x4EB6500", VA = "0x184EB7100")]
	public DNJLIBOGMNI(string OMHHPMIDNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6D90", Offset = "0x4EB6190", VA = "0x184EB6D90")]
	public void IBOLJCNNBEB(KeyType KCGLPAPOILB, ODBDAGKGKIO MPBAGKKKGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6DE0", Offset = "0x4EB61E0", VA = "0x184EB6DE0")]
	public bool LOHHNEBCDEF(KeyType KCGLPAPOILB, ODBDAGKGKIO HIEHEJLGDIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6FA0", Offset = "0x4EB63A0", VA = "0x184EB6FA0")]
	public void NAOGAFPAJFI(KeyType KCGLPAPOILB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4EB6D50", Offset = "0x4EB6150", VA = "0x184EB6D50", Slot = "4")]
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
