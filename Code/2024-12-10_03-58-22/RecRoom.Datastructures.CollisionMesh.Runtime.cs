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
public struct BJPFIIHIMDL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct EBLOCMNHJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int IFDIFLLDLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int HLHIMCDJDMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int LKEIJJOLCCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int CDAKAOCKLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int CEGKAIIPJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int IECLIGDFBDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 IHGGCBNMEKB;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C08850", Offset = "0x6C07450", VA = "0x186C08850")]
		public EBLOCMNHJGO(int NNHNJIIDCGJ, int FNICGPLBMLH, int LMGMACFNLDJ, int IDOCGIDPCJH, int PPGLLDFHABF, int DACHIAMKDHK, float3 DJCDKMIHKHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct DPKMPJGPAIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int JHJBOMENJKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int BPGJEHPFGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float FGHPDGMLPJG;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x13B2B70", Offset = "0x13B1770", VA = "0x1813B2B70")]
		public DPKMPJGPAIG(int GAECIBGPFJF, int AAIOODEPOHO, float KPMPDBOMCOL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct MEFKKAIEHEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int BPGJEHPFGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int IELPDEGPILD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int DBHPOMMHIEM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, EBLOCMNHJGO> BBGKPKKGCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<DPKMPJGPAIG> OLBDODDMDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> ONLBAPLFBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<MEFKKAIEHEK> FLJHEEFECLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> KKDGOKIAPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int PHDOMCMDDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int PBPJNJOKMCG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C06760", Offset = "0x6C05360", VA = "0x186C06760", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C053A0", Offset = "0x6C03FA0", VA = "0x186C053A0")]
	public bool APIJEOFOHKH([In] NativeArray<float3> GJBCFAPBHLJ, NativeList<float3> JBDNLNKKEOL, NativeList<int> CJFLBGLEBAH, Allocator ICLGONBNBJO, CancellationToken CKKFHABGBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C073C0", Offset = "0x6C05FC0", VA = "0x186C073C0")]
	private void KMAKNPIEEHP([In] NativeArray<float3> GJBCFAPBHLJ, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C05740", Offset = "0x6C04340", VA = "0x186C05740")]
	private void COIOJLKOBCL([In] NativeArray<float3> GJBCFAPBHLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C075A0", Offset = "0x6C061A0", VA = "0x186C075A0")]
	private void KOODJMFCDLK([In] NativeArray<float3> GJBCFAPBHLJ, [Out] int IAADACKCEHO, [Out] int BMFNHAPOOFI, [Out] int IPAEKLCDOJE, [Out] int IFPLHPAGBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C054E0", Offset = "0x6C040E0", VA = "0x186C054E0")]
	private void BJMGACGCOHB([In] NativeArray<float3> GJBCFAPBHLJ, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C08370", Offset = "0x6C06F70", VA = "0x186C08370")]
	private void POCPLMKMEIK([In] NativeArray<float3> GJBCFAPBHLJ, float3 EJNKPMJJHKH, int GIEIMAGJCED, EBLOCMNHJGO GPGJMLNAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C04FB0", Offset = "0x6C03BB0", VA = "0x186C04FB0")]
	private void ABAFFAJCKDN([In] NativeArray<float3> GJBCFAPBHLJ, float3 EJNKPMJJHKH, int AACLPPBHKPG, int PBPJNJOKMCG, EBLOCMNHJGO GPGJMLNAANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C06DC0", Offset = "0x6C059C0", VA = "0x186C06DC0")]
	private void KJDLGODLNEM([In] NativeArray<float3> GJBCFAPBHLJ, int MKJCJOPMMIM, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C07B20", Offset = "0x6C06720", VA = "0x186C07B20")]
	private void LLBOIBDKDHE([In] NativeArray<float3> GJBCFAPBHLJ, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C07E90", Offset = "0x6C06A90", VA = "0x186C07E90")]
	private void NFKMGAMCBKB([In] NativeArray<float3> GJBCFAPBHLJ, NativeList<float3> JBDNLNKKEOL, NativeList<int> CJFLBGLEBAH, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C07AC0", Offset = "0x6C066C0", VA = "0x186C07AC0")]
	private float LEHCPGFONON(float3 EJNKPMJJHKH, float3 KONIEGLMLOP, EBLOCMNHJGO GPGJMLNAANK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C06970", Offset = "0x6C05570", VA = "0x186C06970")]
	private float3 IHGGCBNMEKB(float3 NNHNJIIDCGJ, float3 FNICGPLBMLH, float3 LMGMACFNLDJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6C06A80", Offset = "0x6C05680", VA = "0x186C06A80")]
	private static float JFANAGFGEOC(float3 ALHLFNOAFIL, float3 AFHCIMLJCHF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C07A60", Offset = "0x6C06660", VA = "0x186C07A60")]
	private static float3 LAJOCDEOJFP(float3 ALHLFNOAFIL, float3 AFHCIMLJCHF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C056E0", Offset = "0x6C042E0", VA = "0x186C056E0")]
	private bool CHGBPJPCBCD(float3 ALHLFNOAFIL, float3 AFHCIMLJCHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C068A0", Offset = "0x6C054A0", VA = "0x186C068A0")]
	private bool GCKAEBAAKPA(float3 ALHLFNOAFIL, float3 AFHCIMLJCHF, float3 NPAFKDGAFPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C06AB0", Offset = "0x6C056B0", VA = "0x186C06AB0")]
	private bool JHBGAKKBJOJ(float3 ALHLFNOAFIL, float3 AFHCIMLJCHF, float3 NPAFKDGAFPE, float3 KPMPDBOMCOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OKPACHBMJIM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NPHMCONHBNK
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
	private NativeList<float3> FBIJFOKALJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> KLOGNDJHLIN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NCHNHNDHOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C092B0", Offset = "0x6C07EB0", VA = "0x186C092B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int ACCPFFNJLOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C08A00", Offset = "0x6C07600", VA = "0x186C08A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JJKFDCCDGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C096D0", Offset = "0x6C082D0", VA = "0x186C096D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JKHIAOOFOPJ EKECBBOKGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C09860", Offset = "0x6C08460", VA = "0x186C09860")]
		get
		{
			return default(JKHIAOOFOPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C09E80", Offset = "0x6C08A80", VA = "0x186C09E80")]
	public OKPACHBMJIM(int JCNHMGBINFM, int CCHNADPHIEJ, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C09CE0", Offset = "0x6C088E0", VA = "0x186C09CE0")]
	public OKPACHBMJIM(JKHIAOOFOPJ DMLCDDLJDLI, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C09D10", Offset = "0x6C08910", VA = "0x186C09D10")]
	public OKPACHBMJIM(Mesh OOKDOLDBLMJ, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C09980", Offset = "0x6C08580", VA = "0x186C09980")]
	public OKPACHBMJIM(OKPACHBMJIM BFLLAIFBMAJ, Allocator ICLGONBNBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C09440", Offset = "0x6C08040", VA = "0x186C09440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C08A40", Offset = "0x6C07640", VA = "0x186C08A40")]
	public void CMCAIIEBGOH([In] OKPACHBMJIM DOHADELBNEM, float4x4 ICJJPDGCFNI, Transform FNCCHDDPHNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C092F0", Offset = "0x6C07EF0", VA = "0x186C092F0")]
	public void DPBPNJJJMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C08DC0", Offset = "0x6C079C0", VA = "0x186C08DC0")]
	public void CPAKBKFKOPN(float GHBEHFGEGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C094D0", Offset = "0x6C080D0", VA = "0x186C094D0")]
	public OKPACHBMJIM EJPGAMAIKOJ(Allocator ICLGONBNBJO, CancellationToken CKKFHABGBNL)
	{
		return default(OKPACHBMJIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C09740", Offset = "0x6C08340", VA = "0x186C09740")]
	public Mesh MKMMECHIGIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C09930", Offset = "0x6C08530", VA = "0x186C09930")]
	private unsafe static float3* PJEMILEAOKF(NativeArray<float3> BFDOCKABCPN)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C098E0", Offset = "0x6C084E0", VA = "0x186C098E0")]
	private unsafe static int* PJEMILEAOKF(NativeArray<int> BFDOCKABCPN)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C09710", Offset = "0x6C08310", VA = "0x186C09710")]
	[CompilerGenerated]
	internal static void JEIHAFIGCNI(int AEMDMDLBNOB, int LEPCMBJKJPE, NPHMCONHBNK P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JKHIAOOFOPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int NCHNHNDHOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int ACCPFFNJLOM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IPICNHJBHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C08950", Offset = "0x6C07550", VA = "0x186C08950")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x205A210", Offset = "0x2058E10", VA = "0x18205A210")]
	public static JKHIAOOFOPJ ENMMCEPCKOE(JKHIAOOFOPJ ALHLFNOAFIL, JKHIAOOFOPJ AFHCIMLJCHF)
	{
		return default(JKHIAOOFOPJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C08930", Offset = "0x6C07530", VA = "0x186C08930")]
	public static JKHIAOOFOPJ OAPOFDMOFHL(JKHIAOOFOPJ BHAHPLBHKHB, int BJFIIBACKFL)
	{
		return default(JKHIAOOFOPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C08890", Offset = "0x6C07490", VA = "0x186C08890", Slot = "0")]
	public override bool Equals(object GJAEFFOLCAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C088E0", Offset = "0x6C074E0", VA = "0x186C088E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C08960", Offset = "0x6C07560", VA = "0x186C08960", Slot = "3")]
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
