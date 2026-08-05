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
public struct PLILFKBFCFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct FICBMKECCFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int FAEOLJHAEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int CHLGGHIKDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int ALHGCKIJAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int JMCHOIOKGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int EGFIPHDGDDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int GMCPCENGLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 ILFBEFJNKLJ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0ED0", Offset = "0x6DAF8D0", VA = "0x186DB0ED0")]
		public FICBMKECCFP(int FGBNHEDKEFN, int BCMGJIJMLKO, int NHKCMFBMGIN, int DHCHMJCOKFJ, int MBGILKMLOHG, int EMOCPOPGDPM, float3 LIGJJEDBJEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct IMDGNIENPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int FADPNIKFNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int PBOCLABCMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float JDEPCFMBFLM;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1527330", Offset = "0x1525D30", VA = "0x181527330")]
		public IMDGNIENPBD(int CGOKOAJMBEG, int NMEMINLANOG, float GMLMJDCJBHC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct DGNHHMEOIOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int PBOCLABCMDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int HOKOLDFGFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int GFEKEKMCJFC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, FICBMKECCFP> IELALOFOCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<IMDGNIENPBD> BGNCPHIJBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> IBPAKBJIBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<DGNHHMEOIOJ> PBGLIGFPLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> MECGCOFALGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int NBCIDJCCAHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int FEDAMLGFLLO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DB47C0", Offset = "0x6DB31C0", VA = "0x186DB47C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5D30", Offset = "0x6DB4730", VA = "0x186DB5D30")]
	public bool JGHJJCKKCDI([In] NativeArray<float3> APEFCMODIEJ, NativeList<float3> OODCEEMLGGA, NativeList<int> HAKNLBHIDBB, Allocator MCBEFIMHDPO, CancellationToken PPLDCJFFMEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6DB51B0", Offset = "0x6DB3BB0", VA = "0x186DB51B0")]
	private void GCHKJEOLKFE([In] NativeArray<float3> APEFCMODIEJ, Allocator MCBEFIMHDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6DB37A0", Offset = "0x6DB21A0", VA = "0x186DB37A0")]
	private void CPOIJEBHCLH([In] NativeArray<float3> APEFCMODIEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DB25D0", Offset = "0x6DB0FD0", VA = "0x186DB25D0")]
	private void ADNJHKELMPM([In] NativeArray<float3> APEFCMODIEJ, [Out] int JAFINGMKHAB, [Out] int KCBDIKKODBF, [Out] int EPKEENFGMKP, [Out] int BEMOHPKGGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6DB53F0", Offset = "0x6DB3DF0", VA = "0x186DB53F0")]
	private void GICJOODCGKB([In] NativeArray<float3> APEFCMODIEJ, Allocator MCBEFIMHDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4960", Offset = "0x6DB3360", VA = "0x186DB4960")]
	private void FEAIEFNDAKN([In] NativeArray<float3> APEFCMODIEJ, float3 MODBPDPODDG, int KNIFNAFJGJJ, FICBMKECCFP PDPIKHLDGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2B60", Offset = "0x6DB1560", VA = "0x186DB2B60")]
	private void CELNJMICNJG([In] NativeArray<float3> APEFCMODIEJ, float3 MODBPDPODDG, int MJMLMBMGEEA, int FEDAMLGFLLO, FICBMKECCFP PDPIKHLDGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6DB55F0", Offset = "0x6DB3FF0", VA = "0x186DB55F0")]
	private void HFBCGOFOHHF([In] NativeArray<float3> APEFCMODIEJ, int OCHAHBJLFGF, Allocator MCBEFIMHDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2F50", Offset = "0x6DB1950", VA = "0x186DB2F50")]
	private void CGBFFBNHBLB([In] NativeArray<float3> APEFCMODIEJ, Allocator MCBEFIMHDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB32C0", Offset = "0x6DB1CC0", VA = "0x186DB32C0")]
	private void CHGCOEJIDLC([In] NativeArray<float3> APEFCMODIEJ, NativeList<float3> OODCEEMLGGA, NativeList<int> HAKNLBHIDBB, Allocator MCBEFIMHDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4900", Offset = "0x6DB3300", VA = "0x186DB4900")]
	private float ELCHIFEAEGN(float3 MODBPDPODDG, float3 PDAMKCMDEPK, FICBMKECCFP PDPIKHLDGKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5C20", Offset = "0x6DB4620", VA = "0x186DB5C20")]
	private float3 ILFBEFJNKLJ(float3 FGBNHEDKEFN, float3 BCMGJIJMLKO, float3 NHKCMFBMGIN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5BF0", Offset = "0x6DB45F0", VA = "0x186DB5BF0")]
	private static float HMKJPLEEPEP(float3 PEMPEACEHBG, float3 FDDPOELCNDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6DB5390", Offset = "0x6DB3D90", VA = "0x186DB5390")]
	private static float3 GHFNLBLIGDA(float3 PEMPEACEHBG, float3 FDDPOELCNDG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4E40", Offset = "0x6DB3840", VA = "0x186DB4E40")]
	private bool FGOEIHAOEJP(float3 PEMPEACEHBG, float3 FDDPOELCNDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2A90", Offset = "0x6DB1490", VA = "0x186DB2A90")]
	private bool AIFNFILJOND(float3 PEMPEACEHBG, float3 FDDPOELCNDG, float3 CLNPLAGFLPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DB4EA0", Offset = "0x6DB38A0", VA = "0x186DB4EA0")]
	private bool FKBIDOFAGNM(float3 PEMPEACEHBG, float3 FDDPOELCNDG, float3 CLNPLAGFLPF, float3 GMLMJDCJBHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KLKIBFDNGOC : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct PALHKDAMLNI
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
	private NativeList<float3> GDDHNFPPCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> DDCBJBGNCCK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DJPFGJHLGJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6DB16A0", Offset = "0x6DB00A0", VA = "0x186DB16A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int IKJKOHPMOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0F90", Offset = "0x6DAF990", VA = "0x186DB0F90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CLJHAIJPKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DB18D0", Offset = "0x6DB02D0", VA = "0x186DB18D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public MJFHLLKHPIA PIOOCIHLOKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6DB0F10", Offset = "0x6DAF910", VA = "0x186DB0F10")]
		get
		{
			return default(MJFHLLKHPIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2000", Offset = "0x6DB0A00", VA = "0x186DB2000")]
	public KLKIBFDNGOC(int GACOPDJBCOH, int PIGMEJDKNKC, Allocator MCBEFIMHDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB20C0", Offset = "0x6DB0AC0", VA = "0x186DB20C0")]
	public KLKIBFDNGOC(MJFHLLKHPIA DCIBEAKKNFD, Allocator MCBEFIMHDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1E90", Offset = "0x6DB0890", VA = "0x186DB1E90")]
	public KLKIBFDNGOC(Mesh JMPEEMGIIHN, Allocator MCBEFIMHDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB20F0", Offset = "0x6DB0AF0", VA = "0x186DB20F0")]
	public KLKIBFDNGOC(KLKIBFDNGOC GGEMPJLCHFC, Allocator MCBEFIMHDPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB15E0", Offset = "0x6DAFFE0", VA = "0x186DB15E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1910", Offset = "0x6DB0310", VA = "0x186DB1910")]
	public void NOEGDDICEDP([In] KLKIBFDNGOC NEELBFFPDOA, float4x4 OIIDHEPGBAL, Transform GBKILFLBDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6DB16E0", Offset = "0x6DB00E0", VA = "0x186DB16E0")]
	public void HFPAJBODOAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6DB10F0", Offset = "0x6DAFAF0", VA = "0x186DB10F0")]
	public void CPIMMALDDLP(float FHNFOJHGAMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1C90", Offset = "0x6DB0690", VA = "0x186DB1C90")]
	public KLKIBFDNGOC OBPLHKNHPOC(Allocator MCBEFIMHDPO, CancellationToken PPLDCJFFMEP)
	{
		return default(KLKIBFDNGOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0FD0", Offset = "0x6DAF9D0", VA = "0x186DB0FD0")]
	public Mesh CAKEKOIJJJD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1830", Offset = "0x6DB0230", VA = "0x186DB1830")]
	private unsafe static float3* IMNPNKDIKHN(NativeArray<float3> LOCJOHPCANM)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1880", Offset = "0x6DB0280", VA = "0x186DB1880")]
	private unsafe static int* IMNPNKDIKHN(NativeArray<int> LOCJOHPCANM)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1670", Offset = "0x6DB0070", VA = "0x186DB1670")]
	[CompilerGenerated]
	internal static void FKOELMFPAPA(int LEHDMNHMEHP, int KHMJMPDPGBK, PALHKDAMLNI P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct MJFHLLKHPIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int DJPFGJHLGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int IKJKOHPMOKM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DOIPGIOIADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2460", Offset = "0x6DB0E60", VA = "0x186DB2460")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2184AE0", Offset = "0x21834E0", VA = "0x182184AE0")]
	public static MJFHLLKHPIA OGAJIJOBEEF(MJFHLLKHPIA PEMPEACEHBG, MJFHLLKHPIA FDDPOELCNDG)
	{
		return default(MJFHLLKHPIA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2470", Offset = "0x6DB0E70", VA = "0x186DB2470")]
	public static MJFHLLKHPIA CEGJEAHMODI(MJFHLLKHPIA ENDOJKHJELK, int DHCJGAOOJAG)
	{
		return default(MJFHLLKHPIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2490", Offset = "0x6DB0E90", VA = "0x186DB2490", Slot = "0")]
	public override bool Equals(object GGPLPOGAHGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB24E0", Offset = "0x6DB0EE0", VA = "0x186DB24E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2530", Offset = "0x6DB0F30", VA = "0x186DB2530", Slot = "3")]
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
