using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B40", Offset = "0x6D5340", VA = "0x1806D6B40")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D313E0", Offset = "0x5D2FBE0", VA = "0x185D313E0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91F620", Offset = "0x91DE20", VA = "0x18091F620")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IHPHKFAFLJD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F400", Offset = "0x5D2DC00", VA = "0x185D2F400")]
	public static bool BGOCNEJBKOI(FPPLNFNLKMA EEDGCGIIFNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F440", Offset = "0x5D2DC40", VA = "0x185D2F440")]
	private static bool BGOCNEJBKOI(NDILLGOKMAI BMBLDMPPAAE, ref FPPLNFNLKMA EEDGCGIIFNF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KECKDIDDPFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<MKGIHFJLGJE> NIBBNPJAECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<CJJIBDGAEJO> LFLFHNBDICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public OIOMLHDGGKC OCEEMHEIFGC;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JBOLLNLIJFN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(FAEINCGJHOC LBEMEOBAAJI, out Dictionary<int, int> JOEPJJPFEIK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(ODIIBMDEJGA LJKCNOMBBEH, OCLKKCOLHBC HEOPOOCPLDI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface BCEHAJLJGMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class HBLMMCBCBCC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> LKCOHDPOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly Dictionary<Guid, Guid> NKEOJFCFBHD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> MPDDBEMMCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D56E0", Offset = "0x6D3EE0", VA = "0x1806D56E0")]
	public HBLMMCBCBCC(Dictionary<Guid, Guid> LKCOHDPOIJK, Dictionary<Guid, Guid> NKEOJFCFBHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E2F0", Offset = "0x5D2CAF0", VA = "0x185D2E2F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BGADHEHFKAC
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private class FFENKNFBPJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public readonly HashSet<CJJIBDGAEJO> KEEJMFELMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public readonly HashSet<HOAJKDENCCE> FFMEBMFAEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly List<NKECLPPKMIN> KOFHEOIDEIO;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E0D0", Offset = "0x5D2C8D0", VA = "0x185D2E0D0")]
		public FFENKNFBPJG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JAGJHPIDIFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HOAJKDENCCE destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public JAGJHPIDIFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F7C0", Offset = "0x5D2DFC0", VA = "0x185D2F7C0")]
		internal bool <InitializeCircuitsV2Remapping>b__0(PKIIMFKECPB n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class JMAGCFOEHIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
		public JMAGCFOEHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F810", Offset = "0x5D2E010", VA = "0x185D2F810")]
		internal void <InitializeCircuitsV2Remapping>b__1(PKIIMFKECPB n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A2A0", Offset = "0x5D28AA0", VA = "0x185D2A2A0")]
	public static LKCMBLNDBBN FNDJIPBKLOJ(KECKDIDDPFL JLEKMMCGBCN, out IILJIFCIIFD JCBCHAKINCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C5B0", Offset = "0x5D2ADB0", VA = "0x185D2C5B0")]
	private static void MCCFIJGDNKC(LKCMBLNDBBN LLKEPEOOION, FFENKNFBPJG KBACCDNFHAO, out IILJIFCIIFD JCBCHAKINCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C920", Offset = "0x5D2B120", VA = "0x185D2C920")]
	private static void POEINAHDJBN(MKGIHFJLGJE LKGKIBJDEBE, FFENKNFBPJG KBACCDNFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C310", Offset = "0x5D2AB10", VA = "0x185D2C310")]
	private static void LKJKEENBHIK(LKCMBLNDBBN LLKEPEOOION, FFENKNFBPJG KBACCDNFHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D298B0", Offset = "0x5D280B0", VA = "0x185D298B0")]
	private static void BMONDHENBAO(ref KECKDIDDPFL NOIPMEGMFIM, FFENKNFBPJG KBACCDNFHAO, MKGIHFJLGJE LKGKIBJDEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AD90", Offset = "0x5D29590", VA = "0x185D2AD90")]
	public static bool HGFGHFBNNBA(LKCMBLNDBBN LLKEPEOOION, OHCMALOCKII OKIDDEOHONL, out HBLMMCBCBCC? PLHICPHOEGE, out string? EMPPPODHBFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D294F0", Offset = "0x5D27CF0", VA = "0x185D294F0")]
	private static void BHPKHCLIBEK(LKCMBLNDBBN LLKEPEOOION, ref OHCMALOCKII OKIDDEOHONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BFF0", Offset = "0x5D2A7F0", VA = "0x185D2BFF0")]
	public static Dictionary<Guid, Guid> LDAJLGFADIE(IEnumerable<MKGIHFJLGJE> GDAOEBKABOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C2D0", Offset = "0x5D2AAD0", VA = "0x185D2C2D0")]
	private static void LGBEODNKLGD(LKCMBLNDBBN LLKEPEOOION, ref OHCMALOCKII OKIDDEOHONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D28ED0", Offset = "0x5D276D0", VA = "0x185D28ED0")]
	private static bool BHOECFDNAHP(LKCMBLNDBBN LLKEPEOOION, ODIIBMDEJGA LJKCNOMBBEH, ref OHCMALOCKII OKIDDEOHONL, out string EMPPPODHBFE, out Dictionary<int, int> JOEPJJPFEIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C6B0", Offset = "0x5D2AEB0", VA = "0x185D2C6B0")]
	private static Dictionary<Guid, NDILLGOKMAI> NPFFIMPJCJH(LKCMBLNDBBN LLKEPEOOION)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B550", Offset = "0x5D29D50", VA = "0x185D2B550")]
	private static bool HOAHJNFCFAE(LKCMBLNDBBN LLKEPEOOION, ref OHCMALOCKII OKIDDEOHONL, out string? EMPPPODHBFE, out ELEBCAIJICO? DAJMDABEPJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AD00", Offset = "0x5D29500", VA = "0x185D2AD00")]
	private static void HEGAFNAOILP(bool GMKAFFEENMC, MKGIHFJLGJE INDGGBJPGFB, Dictionary<Guid, Guid> JLLCANNELOP, ELEBCAIJICO MJGIMOPEEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A8D0", Offset = "0x5D290D0", VA = "0x185D2A8D0")]
	private static void GHHBKICMJCI(bool GMKAFFEENMC, MKGIHFJLGJE INDGGBJPGFB, ELEBCAIJICO DAJMDABEPJE, Guid OCDJOGAOIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D29610", Offset = "0x5D27E10", VA = "0x185D29610")]
	private static void BMKJLGHLCEL(MKGIHFJLGJE INDGGBJPGFB, Guid HAGHHHIJOKL, FDEEENEPJKB? AFKHKOGNIOL, Dictionary<Guid, NDILLGOKMAI> GEMCJGEIFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D29B70", Offset = "0x5D28370", VA = "0x185D29B70")]
	private static void BNLGOJLLOPJ(MKGIHFJLGJE INDGGBJPGFB, Dictionary<Guid, Guid> JLLCANNELOP, Dictionary<int, int> JHFOKJDODII, ODIIBMDEJGA DKJEKCIHABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D29C60", Offset = "0x5D28460", VA = "0x185D29C60")]
	public static void EELIFPJFLEM(RepeatedField<MKGIHFJLGJE> BCCFMKPDKNH, EADKFKBINCO OIFJMHNNMME, IEnumerable<ByteString> MFBFGHACLGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D283E0", Offset = "0x5D26BE0", VA = "0x185D283E0")]
	private static void BCFMIHDINLI(RepeatedField<MKGIHFJLGJE> BCCFMKPDKNH, HAHLMLJBIDL HBACAGFADPP, BCEHAJLJGMJ JJCOBHBDBNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct OHCMALOCKII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public bool GMKAFFEENMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool OMJMJIHLNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public FDEEENEPJKB? AFKHKOGNIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public FDEEENEPJKB? PPNHFONFMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public FIIIECCDDDL LAFEIOBHKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public BCEHAJLJGMJ JJCOBHBDBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public JBOLLNLIJFN BOJKMJKLAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Guid OCDJOGAOIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public OIOMLHDGGKC OCEEMHEIFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public List<MKGIHFJLGJE> DHHKLLEOJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public Dictionary<string, object> LKOJGKLNFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public JDMNFHPMFAE BPPJBJDGNKA;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct FDEEENEPJKB
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private const float BIEBLHPOJAC = 1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 LMLCHIPKJPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion ILBCPDKFKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float NLPGPFFCFFJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 GIJCKEEGBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D880", Offset = "0x5D2C080", VA = "0x185D2D880")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1663610", Offset = "0x1661E10", VA = "0x181663610")]
	public FDEEENEPJKB(Vector3 LMLCHIPKJPI, Quaternion ILBCPDKFKMC, float NLPGPFFCFFJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DF40", Offset = "0x5D2C740", VA = "0x185D2DF40")]
	public FDEEENEPJKB(GNGCFLPFGEA OEDALBNIEAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E010", Offset = "0x5D2C810", VA = "0x185D2E010")]
	private FDEEENEPJKB(HECMLPPEKKL BFNJGHMAKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DC60", Offset = "0x5D2C460", VA = "0x185D2DC60")]
	public static FDEEENEPJKB GOGALFCJOOC(CJJIBDGAEJO HDCAJODGFPO)
	{
		return default(FDEEENEPJKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D980", Offset = "0x5D2C180", VA = "0x185D2D980")]
	public static FDEEENEPJKB FMIDNCCAJNH(FDEEENEPJKB FAAJOMIIHED, FDEEENEPJKB AAKKIFNMMGO)
	{
		return default(FDEEENEPJKB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D730", Offset = "0x5D2BF30", VA = "0x185D2D730")]
	public static FDEEENEPJKB AGJOPELLCGM((Vector3, Quaternion, float) LBEMEOBAAJI)
	{
		return default(FDEEENEPJKB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D780", Offset = "0x5D2BF80", VA = "0x185D2D780")]
	public static FDEEENEPJKB AGJOPELLCGM(Matrix4x4 PIHLLKCAKGP)
	{
		return default(FDEEENEPJKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DAD0", Offset = "0x5D2C2D0", VA = "0x185D2DAD0")]
	public FDEEENEPJKB FPAOIDLAANN(Matrix4x4 KPFEIMOAGDN)
	{
		return default(FDEEENEPJKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DEF0", Offset = "0x5D2C6F0", VA = "0x185D2DEF0")]
	public static FDEEENEPJKB NMCHPMCIFJK(Vector3 LMLCHIPKJPI)
	{
		return default(FDEEENEPJKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DC90", Offset = "0x5D2C490", VA = "0x185D2DC90")]
	[CompilerGenerated]
	internal static FDEEENEPJKB MFHNEKFNCJB(CJJIBDGAEJO KFMDDCEOFLE)
	{
		return default(FDEEENEPJKB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class CCLHNHOGIHI : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D2F0", Offset = "0x5D2BAF0", VA = "0x185D2D2F0", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CB10", Offset = "0x5D2B310", VA = "0x185D2CB10")]
	private void BJMDOOKHFFI(Dictionary<Guid, Guid> BHFMJDEJDFI, OKIAAGHNDGM CMLFMDOALJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D290", Offset = "0x5D2BA90", VA = "0x185D2D290")]
	private void BJMDOOKHFFI(Dictionary<Guid, Guid> BHFMJDEJDFI, CHALJJONLJB DDAOJMPJJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D040", Offset = "0x5D2B840", VA = "0x185D2D040")]
	private void BJMDOOKHFFI(Dictionary<Guid, Guid> BHFMJDEJDFI, LICEHKPFHGA ONCBMHHJAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public CCLHNHOGIHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class KMCDEJPNAKM : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F970", Offset = "0x5D2E170", VA = "0x185D2F970", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public KMCDEJPNAKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class KMNAODMAFJP : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FA30", Offset = "0x5D2E230", VA = "0x185D2FA30", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public KMNAODMAFJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class MABJLGDOFEG : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FD70", Offset = "0x5D2E570", VA = "0x185D2FD70", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public MABJLGDOFEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class DPHBNJMCNHP : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D3A0", Offset = "0x5D2BBA0", VA = "0x185D2D3A0", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public DPHBNJMCNHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class EMEFAHEOIFJ : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D5B0", Offset = "0x5D2BDB0", VA = "0x185D2D5B0", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public EMEFAHEOIFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class HPHMELJDJKL : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F210", Offset = "0x5D2DA10", VA = "0x185D2F210", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public HPHMELJDJKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class GNKJDODHKEE : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E1D0", Offset = "0x5D2C9D0", VA = "0x185D2E1D0", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public GNKJDODHKEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class LHACHFHDICA : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FBA0", Offset = "0x5D2E3A0", VA = "0x185D2FBA0", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public LHACHFHDICA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class MDOFKJABHKM : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5D31210", Offset = "0x5D2FA10", VA = "0x185D31210", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public MDOFKJABHKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class HHEHKCPFPKB : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F0F0", Offset = "0x5D2D8F0", VA = "0x185D2F0F0", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public HHEHKCPFPKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public sealed class JNHHACKLFAE : GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random HIIJBIMONFP;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F830", Offset = "0x5D2E030", VA = "0x185D2F830", Slot = "4")]
	public void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
	public JNHHACKLFAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct FPPLNFNLKMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public ODIIBMDEJGA OGPINCOPHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public MDKHGICIEDB PEIKACKCINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> JHFOKJDODII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> IADFLJJJNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public JDMNFHPMFAE BPPJBJDGNKA;
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface GEPLACJEJOC
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MGOOFPLFLKA(CCKGEJNPABF PCJAKKDBFKM);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HCEHJIJAOHK
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly GEPLACJEJOC[] EKPKIJLBEPP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E6B0", Offset = "0x5D2CEB0", VA = "0x185D2E6B0")]
	public static void DKBIHBFEGCK(MKGIHFJLGJE LBEMEOBAAJI, Dictionary<Guid, Guid> FOPHPIIOOKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E8C0", Offset = "0x5D2D0C0", VA = "0x185D2E8C0")]
	public static void OHNMMCJEKDG(MKGIHFJLGJE? LBEMEOBAAJI, ELEBCAIJICO MJGIMOPEEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E350", Offset = "0x5D2CB50", VA = "0x185D2E350")]
	public static void BGOCNEJBKOI(CCKGEJNPABF PCJAKKDBFKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CCKGEJNPABF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public ODIIBMDEJGA HCBPLDPKDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public MKGIHFJLGJE INDGGBJPGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> JHFOKJDODII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> IADFLJJJNNJ;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CA40", Offset = "0x5D2B240", VA = "0x185D2CA40")]
	public Guid PHPGCKNJCGE(Guid CNMALJMHIOD)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface JDMNFHPMFAE
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int COBLGHGFKBJ, out Guid DFDPFHNANAD);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public sealed class MDEPNOBOCHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> NONFDKLOLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> IBHNMHDHDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> BHANKILNONO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IReadOnlyCollection<string> BPPELIIEMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6D6AC0", Offset = "0x6D52C0", VA = "0x1806D6AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyDictionary<long, int> AOPJNFJPDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FF30", Offset = "0x5D2E730", VA = "0x185D2FF30")]
	public static MDEPNOBOCHE CFLAALPCLGM(MAHPOMANNIJ BJBAPBHIHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FEC0", Offset = "0x5D2E6C0", VA = "0x185D2FEC0")]
	public static MDEPNOBOCHE APHOHELNIKL(LKCMBLNDBBN HMNGBMACKHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5D30EA0", Offset = "0x5D2F6A0", VA = "0x185D30EA0")]
	public static MDEPNOBOCHE PLFBCCMGANH(IEnumerable<string> NONFDKLOLGJ, IDictionary<long, int> BFACFEBGFND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5D31110", Offset = "0x5D2F910", VA = "0x185D31110")]
	private MDEPNOBOCHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5D30FF0", Offset = "0x5D2F7F0", VA = "0x185D30FF0")]
	private MDEPNOBOCHE(IEnumerable<string> NONFDKLOLGJ, IDictionary<long, int> BFACFEBGFND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D30350", Offset = "0x5D2EB50", VA = "0x185D30350")]
	private void OPBHFDIKKAO(MAHPOMANNIJ BJBAPBHIHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D30510", Offset = "0x5D2ED10", VA = "0x185D30510")]
	private void OPBHFDIKKAO(LKCMBLNDBBN HMNGBMACKHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D30A80", Offset = "0x5D2F280", VA = "0x185D30A80")]
	private void OPBHFDIKKAO(EADKFKBINCO? FECENBBKPOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D301E0", Offset = "0x5D2E9E0", VA = "0x185D301E0")]
	private void OPBHFDIKKAO(PKIIMFKECPB? KFMDDCEOFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D306D0", Offset = "0x5D2EED0", VA = "0x185D306D0")]
	private void OPBHFDIKKAO(MKGIHFJLGJE? INDGGBJPGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D30170", Offset = "0x5D2E970", VA = "0x185D30170")]
	private void KBNIICFPOPD(string? GPFKHDGIMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5D30090", Offset = "0x5D2E890", VA = "0x185D30090")]
	private void IOIFAPGBBNA(JGDJKEICGPL? PHIFEGFBIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FFA0", Offset = "0x5D2E7A0", VA = "0x185D2FFA0")]
	private void IOIFAPGBBNA(KJPAADDAFNH? PHIFEGFBIOP)
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
