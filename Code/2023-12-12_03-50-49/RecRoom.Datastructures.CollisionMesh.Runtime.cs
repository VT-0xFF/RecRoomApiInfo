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
public struct NCLNOPODBLK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct FFNACAJAENK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int NIKOPCCNDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int NDIHOPGJHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int FPGHNKGBKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int PFFGELJELDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int KNIOJAGAPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int COBIKNDKHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 IFMAPHDCCNK;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DD5850", Offset = "0x5DD4050", VA = "0x185DD5850")]
		public FFNACAJAENK(int EBACBPFKOGF, int NKFENKBEHEE, int GKFCIIMEPAI, int KPIFPLMAGCM, int IHKGAIJKABD, int FFFPBPIIEPJ, float3 HMKNLJLLNBH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct HEJJPGHHNBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int LOALAGGCNMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int KKCJMBOJLMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float CPPHDKIIOBF;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xF3E940", Offset = "0xF3D140", VA = "0x180F3E940")]
		public HEJJPGHHNBK(int NDMBOLPNCGE, int AFDAJFEDCNL, float FCAIODKILEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct HCNODFOFMBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int KKCJMBOJLMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int AHOJEDMGNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int EHKAINAPGOB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, FFNACAJAENK> HMNDCBLOHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<HEJJPGHHNBK> ABICKHOCOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> OGBDPNCLLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<HCNODFOFMBG> JBNCDNEFEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> PAHEGMEOIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int LDNPAIGKDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int NKKPEPDAFDE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7BF0", Offset = "0x5DD63F0", VA = "0x185DD7BF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DD85D0", Offset = "0x5DD6DD0", VA = "0x185DD85D0")]
	public bool FPAIPFJPMIJ([In] NativeArray<float3> KKBLKMFNFEJ, NativeList<float3> BJDIBCJMGMP, NativeList<int> GMFDKLICKLF, Allocator BIOBDEGNFFO, CancellationToken GANAOLJLMGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7D30", Offset = "0x5DD6530", VA = "0x185DD7D30")]
	private void EBEAKPIECKB([In] NativeArray<float3> KKBLKMFNFEJ, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DD90C0", Offset = "0x5DD78C0", VA = "0x185DD90C0")]
	private void OCKNFBLOFGN([In] NativeArray<float3> KKBLKMFNFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6DD0", Offset = "0x5DD55D0", VA = "0x185DD6DD0")]
	private void ACIPNPIIHGP([In] NativeArray<float3> KKBLKMFNFEJ, [Out] int OCCMJOOBFEH, [Out] int EPDMHADHBIL, [Out] int LMGPHIJNHCJ, [Out] int IGKOGONLEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DD78F0", Offset = "0x5DD60F0", VA = "0x185DD78F0")]
	private void BFKBPEMCDEJ([In] NativeArray<float3> KKBLKMFNFEJ, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA130", Offset = "0x5DD8930", VA = "0x185DDA130")]
	private void PNFLJBGHAAF([In] NativeArray<float3> KKBLKMFNFEJ, float3 JCKCLHMKLHE, int HLIHCJAPJLB, FFNACAJAENK HBOICHJCHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8200", Offset = "0x5DD6A00", VA = "0x185DD8200")]
	private void EMAPHBLHGFB([In] NativeArray<float3> KKBLKMFNFEJ, float3 JCKCLHMKLHE, int MHCPGILGBAJ, int NKKPEPDAFDE, FFNACAJAENK HBOICHJCHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7290", Offset = "0x5DD5A90", VA = "0x185DD7290")]
	private void ADPODFEKJIH([In] NativeArray<float3> KKBLKMFNFEJ, int JAOBFOKKLEK, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8820", Offset = "0x5DD7020", VA = "0x185DD8820")]
	private void LOKCELJFMFM([In] NativeArray<float3> KKBLKMFNFEJ, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8B90", Offset = "0x5DD7390", VA = "0x185DD8B90")]
	private void MFKCFJEJCIM([In] NativeArray<float3> KKBLKMFNFEJ, NativeList<float3> BJDIBCJMGMP, NativeList<int> GMFDKLICKLF, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA0D0", Offset = "0x5DD88D0", VA = "0x185DDA0D0")]
	private float PMPBKAHHPPK(float3 JCKCLHMKLHE, float3 OMGPBBOAKFE, FFNACAJAENK HBOICHJCHHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8710", Offset = "0x5DD6F10", VA = "0x185DD8710")]
	private float3 IFMAPHDCCNK(float3 EBACBPFKOGF, float3 NKFENKBEHEE, float3 GKFCIIMEPAI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7AF0", Offset = "0x5DD62F0", VA = "0x185DD7AF0")]
	private static float CAEICBNMMOP(float3 GIFKCLLLICD, float3 KIOLHHMPBGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9060", Offset = "0x5DD7860", VA = "0x185DD9060")]
	private static float3 NBAGAHBHEPB(float3 GIFKCLLLICD, float3 KIOLHHMPBGL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7890", Offset = "0x5DD6090", VA = "0x185DD7890")]
	private bool AMCHDAJCBHD(float3 GIFKCLLLICD, float3 KIOLHHMPBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7B20", Offset = "0x5DD6320", VA = "0x185DD7B20")]
	private bool COPMABPOFGL(float3 GIFKCLLLICD, float3 KIOLHHMPBGL, float3 DNNFFPMDBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7F10", Offset = "0x5DD6710", VA = "0x185DD7F10")]
	private bool EGNGHIHBJME(float3 GIFKCLLLICD, float3 KIOLHHMPBGL, float3 DNNFFPMDBKK, float3 FCAIODKILEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KDNPLCKPLPG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JICHFMINLHA
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
	private NativeList<float3> CPFEPDGINIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> EOLPOOCFIEN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JFKDLKFKLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6700", Offset = "0x5DD4F00", VA = "0x185DD6700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DDIBKKFCILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DD5890", Offset = "0x5DD4090", VA = "0x185DD5890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CCNAENOMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DD5BE0", Offset = "0x5DD43E0", VA = "0x185DD5BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NKAGLOGKMIO IHLJOGCGPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5DD5B60", Offset = "0x5DD4360", VA = "0x185DD5B60")]
		get
		{
			return default(NKAGLOGKMIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6980", Offset = "0x5DD5180", VA = "0x185DD6980")]
	public KDNPLCKPLPG(int EPPAOOHNOOD, int FLEJGBGFGKO, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6DA0", Offset = "0x5DD55A0", VA = "0x185DD6DA0")]
	public KDNPLCKPLPG(NKAGLOGKMIO FDCDDBBBIAO, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6810", Offset = "0x5DD5010", VA = "0x185DD6810")]
	public KDNPLCKPLPG(Mesh OPJNLFOIMJC, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6A40", Offset = "0x5DD5240", VA = "0x185DD6A40")]
	public KDNPLCKPLPG(KDNPLCKPLPG FCHBDAMJEHN, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD58D0", Offset = "0x5DD40D0", VA = "0x185DD58D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6230", Offset = "0x5DD4A30", VA = "0x185DD6230")]
	public void INCGBOEKEGG([In] KDNPLCKPLPG PCNNAKCFNJC, float4x4 JHMJPNGIPCF, Transform PFDINFPFNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD65B0", Offset = "0x5DD4DB0", VA = "0x185DD65B0")]
	public void JCPDFDDCBBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5C20", Offset = "0x5DD4420", VA = "0x185DD5C20")]
	public void HOJHKLJJNKC(float EMBKCPDDBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DD5960", Offset = "0x5DD4160", VA = "0x185DD5960")]
	public KDNPLCKPLPG EHILNKEJDKJ(Allocator BIOBDEGNFFO, CancellationToken GANAOLJLMGA)
	{
		return default(KDNPLCKPLPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6110", Offset = "0x5DD4910", VA = "0x185DD6110")]
	public Mesh IKFBNLMPNIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6770", Offset = "0x5DD4F70", VA = "0x185DD6770")]
	private unsafe static float3* PMIBFFIAOMG(NativeArray<float3> CMKNCDNHDNA)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DD67C0", Offset = "0x5DD4FC0", VA = "0x185DD67C0")]
	private unsafe static int* PMIBFFIAOMG(NativeArray<int> CMKNCDNHDNA)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6740", Offset = "0x5DD4F40", VA = "0x185DD6740")]
	[CompilerGenerated]
	internal static void OFCIKOMCCIN(int KKDDEDLDHFK, int KFCNBPOGDGA, JICHFMINLHA P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct NKAGLOGKMIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int JFKDLKFKLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int DDIBKKFCILI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HIFPAIAIBLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5DDA5E0", Offset = "0x5DD8DE0", VA = "0x185DDA5E0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1BEF700", Offset = "0x1BEDF00", VA = "0x181BEF700")]
	public static NKAGLOGKMIO HGGBPNAHAGN(NKAGLOGKMIO GIFKCLLLICD, NKAGLOGKMIO KIOLHHMPBGL)
	{
		return default(NKAGLOGKMIO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA5F0", Offset = "0x5DD8DF0", VA = "0x185DDA5F0")]
	public static NKAGLOGKMIO GPBNOHHECGA(NKAGLOGKMIO CENHLLPCGDF, int FIGFPNIEGIA)
	{
		return default(NKAGLOGKMIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA590", Offset = "0x5DD8D90", VA = "0x185DDA590", Slot = "0")]
	public override bool Equals(object DJOJOABBMNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA610", Offset = "0x5DD8E10", VA = "0x185DDA610", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA660", Offset = "0x5DD8E60", VA = "0x185DDA660", Slot = "3")]
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
