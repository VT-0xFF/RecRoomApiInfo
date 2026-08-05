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
public struct BFMGDDPIGEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct GAGOPDMMHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int KLOMMNJENJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int APLGPKCCIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int HCGNCCDKNLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int GGHIAKAHGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int KLDLAFDBOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int IBPGEOHDNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 OAJANCKGLCD;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2D70", Offset = "0x5FC1B70", VA = "0x185FC2D70")]
		public GAGOPDMMHGG(int ENHLLLBPJKH, int MMAEBPHLOFM, int PONCFBBBDNM, int HFBCKAAHJKC, int CDPBEHPIGHH, int CPKLAONGEJL, float3 NPJIMHPPOGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct BOHNOHLMMEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int PHPILDBGNEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int JIFCEJJCMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float HBCGHOKOEHG;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xFB0D70", Offset = "0xFAFB70", VA = "0x180FB0D70")]
		public BOHNOHLMMEG(int KADGOLMMJFK, int IFCHLPHCIDI, float DDIKBLEEKFK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct JHGILCPBFLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int JIFCEJJCMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int AKEIIJEKIAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int GEENHFLGJCL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, GAGOPDMMHGG> FFDHJNNAHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<BOHNOHLMMEG> BEADKHJJFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> DCKIIHGGGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<JHGILCPBFLF> OINFJGHMAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> GJCNEOMEFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int CKGMNCEJIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int DDIJPEGGKAN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0560", Offset = "0x5FBF360", VA = "0x185FC0560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2C30", Offset = "0x5FC1A30", VA = "0x185FC2C30")]
	public bool PCIHIEOAIPN([In] NativeArray<float3> EOHEBNAMJII, NativeList<float3> KDHHHHIFMFO, NativeList<int> FHDFOIFJGPB, Allocator MGPHHCICJPF, CancellationToken HHBHDBLGMFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0B70", Offset = "0x5FBF970", VA = "0x185FC0B70")]
	private void FCIFMHNEBDM([In] NativeArray<float3> EOHEBNAMJII, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0E80", Offset = "0x5FBFC80", VA = "0x185FC0E80")]
	private void JBCGBFHCKEL([In] NativeArray<float3> EOHEBNAMJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FBFC10", Offset = "0x5FBEA10", VA = "0x185FBFC10")]
	private void APHEPGOJHCH([In] NativeArray<float3> EOHEBNAMJII, [Out] int FKIPJHGGFPD, [Out] int CEDHBHNFMLG, [Out] int FCDCJIPALPJ, [Out] int FPIJEJHJDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2920", Offset = "0x5FC1720", VA = "0x185FC2920")]
	private void LIHKPMCFGNG([In] NativeArray<float3> EOHEBNAMJII, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2490", Offset = "0x5FC1290", VA = "0x185FC2490")]
	private void KKCIIPGAGBA([In] NativeArray<float3> EOHEBNAMJII, float3 MHCNCLONLOI, int IDOBDGPKAHL, GAGOPDMMHGG EKDIFEEOOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0130", Offset = "0x5FBEF30", VA = "0x185FC0130")]
	private void CFPGAOELCDE([In] NativeArray<float3> EOHEBNAMJII, float3 MHCNCLONLOI, int NJEIJFADCKA, int DDIJPEGGKAN, GAGOPDMMHGG EKDIFEEOOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FC1E90", Offset = "0x5FC0C90", VA = "0x185FC1E90")]
	private void JCKKAKECOJI([In] NativeArray<float3> EOHEBNAMJII, int CHMFIGBNGMA, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF5B0", Offset = "0x5FBE3B0", VA = "0x185FBF5B0")]
	private void AADIGPDGKHB([In] NativeArray<float3> EOHEBNAMJII, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC06A0", Offset = "0x5FBF4A0", VA = "0x185FC06A0")]
	private void EJONLKBNCKN([In] NativeArray<float3> EOHEBNAMJII, NativeList<float3> KDHHHHIFMFO, NativeList<int> FHDFOIFJGPB, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0D50", Offset = "0x5FBFB50", VA = "0x185FC0D50")]
	private float GNMFLPFFMBI(float3 MHCNCLONLOI, float3 AHIAAJEPKAC, GAGOPDMMHGG EKDIFEEOOEG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2B20", Offset = "0x5FC1920", VA = "0x185FC2B20")]
	private float3 OAJANCKGLCD(float3 ENHLLLBPJKH, float3 MMAEBPHLOFM, float3 PONCFBBBDNM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC28F0", Offset = "0x5FC16F0", VA = "0x185FC28F0")]
	private static float KODLAKKKNJJ(float3 GCMDJKOKHCO, float3 LGCDJBDIEJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5FC00D0", Offset = "0x5FBEED0", VA = "0x185FC00D0")]
	private static float3 BELPJBONBLG(float3 GCMDJKOKHCO, float3 LGCDJBDIEJC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0500", Offset = "0x5FBF300", VA = "0x185FC0500")]
	private bool DDNIPCEPFBB(float3 GCMDJKOKHCO, float3 LGCDJBDIEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5FC0DB0", Offset = "0x5FBFBB0", VA = "0x185FC0DB0")]
	private bool HGKIDIPOHFF(float3 GCMDJKOKHCO, float3 LGCDJBDIEJC, float3 JJJKOMKEIGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FBF920", Offset = "0x5FBE720", VA = "0x185FBF920")]
	private bool AIJJOCMIMFO(float3 GCMDJKOKHCO, float3 LGCDJBDIEJC, float3 JJJKOMKEIGG, float3 DDIKBLEEKFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MOFLMIMMFAF : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct LHGNEMJPPCP
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
	private NativeList<float3> KEANILHACDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> FKCOPGGANLI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int APDKACJPMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5FC32A0", Offset = "0x5FC20A0", VA = "0x185FC32A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int EOBPCLINPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FC3D40", Offset = "0x5FC2B40", VA = "0x185FC3D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CIOMBLIBDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FC35E0", Offset = "0x5FC23E0", VA = "0x185FC35E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JEKFBCLLJNM MHBBFJCGLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5FC34C0", Offset = "0x5FC22C0", VA = "0x185FC34C0")]
		get
		{
			return default(JEKFBCLLJNM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FC43A0", Offset = "0x5FC31A0", VA = "0x185FC43A0")]
	public MOFLMIMMFAF(int KFOEOCOIBCG, int KICAGGFEGDE, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC4370", Offset = "0x5FC3170", VA = "0x185FC4370")]
	public MOFLMIMMFAF(JEKFBCLLJNM IONIHFKBFJF, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC4200", Offset = "0x5FC3000", VA = "0x185FC4200")]
	public MOFLMIMMFAF(Mesh CKIIGCAJEFJ, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3EA0", Offset = "0x5FC2CA0", VA = "0x185FC3EA0")]
	public MOFLMIMMFAF(MOFLMIMMFAF OMHIFBJFAGA, Allocator MGPHHCICJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3430", Offset = "0x5FC2230", VA = "0x185FC3430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2F20", Offset = "0x5FC1D20", VA = "0x185FC2F20")]
	public void ANMBPKAMKOK([In] MOFLMIMMFAF DIIPJIMFFMD, float4x4 GBHGFIFOAOD, Transform MAAHMMDDMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FC32E0", Offset = "0x5FC20E0", VA = "0x185FC32E0")]
	public void DPMLNIEHLDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3620", Offset = "0x5FC2420", VA = "0x185FC3620")]
	public void LLMKNBAAOKO(float ABEPJPPAIOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3B40", Offset = "0x5FC2940", VA = "0x185FC3B40")]
	public MOFLMIMMFAF NJLHKJKOFCO(Allocator MGPHHCICJPF, CancellationToken HHBHDBLGMFA)
	{
		return default(MOFLMIMMFAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3D80", Offset = "0x5FC2B80", VA = "0x185FC3D80")]
	public Mesh PMONNMLDCDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3540", Offset = "0x5FC2340", VA = "0x185FC3540")]
	private unsafe static float3* HEANEIGCIGB(NativeArray<float3> AAKJIOEDOGA)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3590", Offset = "0x5FC2390", VA = "0x185FC3590")]
	private unsafe static int* HEANEIGCIGB(NativeArray<int> AAKJIOEDOGA)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FC3B10", Offset = "0x5FC2910", VA = "0x185FC3B10")]
	[CompilerGenerated]
	internal static void NBJDLNJJAGM(int BINJLNJCCHL, int PDEAGLIJHBN, LHGNEMJPPCP P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JEKFBCLLJNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int APDKACJPMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int EOBPCLINPMO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BKKLLKNDAHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FC2E00", Offset = "0x5FC1C00", VA = "0x185FC2E00")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1C9EFB0", Offset = "0x1C9DDB0", VA = "0x181C9EFB0")]
	public static JEKFBCLLJNM FKIIBOICILH(JEKFBCLLJNM GCMDJKOKHCO, JEKFBCLLJNM LGCDJBDIEJC)
	{
		return default(JEKFBCLLJNM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2E60", Offset = "0x5FC1C60", VA = "0x185FC2E60")]
	public static JEKFBCLLJNM KJHIKKNKOAD(JEKFBCLLJNM ILCDEGLHAOK, int PIOMDGMHEIP)
	{
		return default(JEKFBCLLJNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2DB0", Offset = "0x5FC1BB0", VA = "0x185FC2DB0", Slot = "0")]
	public override bool Equals(object MLMEAJNIJBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2E10", Offset = "0x5FC1C10", VA = "0x185FC2E10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FC2E80", Offset = "0x5FC1C80", VA = "0x185FC2E80", Slot = "3")]
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
