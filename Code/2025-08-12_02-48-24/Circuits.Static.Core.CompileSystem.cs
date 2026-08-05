using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A070", Offset = "0x2B08670", VA = "0x182B0A070")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct HBFIGJJPOHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> HPIMHCLFLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int IDBKJPJKELN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xEAD240", Offset = "0xEAB840", VA = "0x180EAD240")]
	public HBFIGJJPOHE(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> MEOIPJDHEIK, int EFCGAKGCCGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FHFKOFEGHCE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class IJAMNKIEKNL : GFCIDKADCGM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct FFIKJOFEAAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly MKOKAOLNOHA<byte> GMLHBIBFKDM;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A96240", Offset = "0x2A94840", VA = "0x182A96240")]
		public FFIKJOFEAAP(MKOKAOLNOHA<byte> NCMOHOAIBBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B05DE0", Offset = "0x2B043E0", VA = "0x182B05DE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class JHPPMJCCHFK : GFCIDKADCGM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct AMAKDCFOAKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> DJOPLOMDJAD;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		public AMAKDCFOAKA(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> BOIPNBLMBCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DBEICOGEIBA
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		BytesImmediate,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Variable,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		X32Immediate
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class AEDHKDHPNLN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class GFCIDKADCGM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct HFLLOBAAHDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly DBEICOGEIBA AGECILLPLJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly AEOJKNGHIFP<GFCIDKADCGM> GNHAELGMLIL;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEAD240", Offset = "0xEAB840", VA = "0x180EAD240")]
		public HFLLOBAAHDH(DBEICOGEIBA ENFAOJCOHIL, AEOJKNGHIFP<GFCIDKADCGM> BCGFPONHJPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class BIAIEGDCBLC : GFCIDKADCGM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct GMPKEHLFLPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KINHAAJHHGJ;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		public GMPKEHLFLPF(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JCOIOELBBMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class FFCJADOEJEK : GFCIDKADCGM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct PIOKGLBADPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly NCIHCFDNMCG KHCPLIFKNKE;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		public PIOKGLBADPF(NCIHCFDNMCG KIMDHMDCPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A350", Offset = "0x2B08950", VA = "0x182B0A350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal ODLNCHLIAFI<AEDHKDHPNLN, HFLLOBAAHDH> BJEKGDPOFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal ODLNCHLIAFI<IJAMNKIEKNL, FFIKJOFEAAP> OGJNOFACBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal ODLNCHLIAFI<JHPPMJCCHFK, AMAKDCFOAKA> GJBHBBPGIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal ODLNCHLIAFI<BIAIEGDCBLC, GMPKEHLFLPF> CLAGAHAPOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal ODLNCHLIAFI<FFCJADOEJEK, PIOKGLBADPF> OEFDKGEGJON;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B05F90", Offset = "0x2B04590", VA = "0x182B05F90")]
	private FHFKOFEGHCE([In] ODLNCHLIAFI<AEDHKDHPNLN, HFLLOBAAHDH> OIBPGNPICBF, [In] ODLNCHLIAFI<IJAMNKIEKNL, FFIKJOFEAAP> LGOFMNJIGHE, [In] ODLNCHLIAFI<JHPPMJCCHFK, AMAKDCFOAKA> JJDAMJCDKDE, [In] ODLNCHLIAFI<BIAIEGDCBLC, GMPKEHLFLPF> NLEIFGBOFPG, [In] ODLNCHLIAFI<FFCJADOEJEK, PIOKGLBADPF> MCPNKEACJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B05E50", Offset = "0x2B04450", VA = "0x182B05E50")]
	public static FHFKOFEGHCE BPFPEFLIIPC()
	{
		return default(FHFKOFEGHCE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JNNDIGBOPBO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2B07310", Offset = "0x2B05910", VA = "0x182B07310")]
	public static void LOMEBHIDOPA(this FHFKOFEGHCE CCKLBDLJPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum PAMKAGHGKEK
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KNOJMMGPAPI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class OGGDKJOLNBJ : EKFKGMCFEEI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct APMGLCODLFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> HDGDDPEPBIL;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		public APMGLCODLFI(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> LKJAONPCCIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum HAPOPAFNGMD
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Branch,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		DeadEndData,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		OutNode
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class KIGPJHOKMGF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class EKFKGMCFEEI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct KPHOIKBIGFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly HAPOPAFNGMD AGECILLPLJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly AEOJKNGHIFP<EKFKGMCFEEI> GNHAELGMLIL;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xEAD240", Offset = "0xEAB840", VA = "0x180EAD240")]
		public KPHOIKBIGFK(HAPOPAFNGMD ENFAOJCOHIL, AEOJKNGHIFP<EKFKGMCFEEI> BCGFPONHJPI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal ODLNCHLIAFI<KIGPJHOKMGF, KPHOIKBIGFK> BJEKGDPOFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal ODLNCHLIAFI<OGGDKJOLNBJ, APMGLCODLFI> LPJOEEPFMBA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B05BD0", Offset = "0x2B041D0", VA = "0x182B05BD0")]
	private KNOJMMGPAPI([In] ODLNCHLIAFI<KIGPJHOKMGF, KPHOIKBIGFK> OIBPGNPICBF, [In] ODLNCHLIAFI<OGGDKJOLNBJ, APMGLCODLFI> PIINNMBOHBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2B076A0", Offset = "0x2B05CA0", VA = "0x182B076A0")]
	public static KNOJMMGPAPI BPFPEFLIIPC()
	{
		return default(KNOJMMGPAPI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class KHONDAIDNBF
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B075E0", Offset = "0x2B05BE0", VA = "0x182B075E0")]
	public static void LOMEBHIDOPA(this KNOJMMGPAPI CCKLBDLJPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct ILJDLLEELLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public OEFGLPCMBJB<int> OEECHGIFPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public OEFGLPCMBJB<int> IBCDMBJEHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int IICGCEOKINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int APMBMAAPGGI;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2B06850", Offset = "0x2B04E50", VA = "0x182B06850")]
	private ILJDLLEELLP([In] OEFGLPCMBJB<int> CFDLAKBCLHM, [In] OEFGLPCMBJB<int> CGPHMMAPFDP, int EEHJMLANEHJ, int OOEJNAJEPKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2B067B0", Offset = "0x2B04DB0", VA = "0x182B067B0")]
	public static ILJDLLEELLP BPFPEFLIIPC()
	{
		return default(ILJDLLEELLP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KNMFCHGMFCE
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B07650", Offset = "0x2B05C50", VA = "0x182B07650")]
	public static void LOMEBHIDOPA(this ILJDLLEELLP CCKLBDLJPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct BOPBLJANNLN
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum MPBEBKEJIJN
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class IACMJNDBLCG : JGOBOLIKKOA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct JHLENDFDGJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly AEOJKNGHIFP<KAFKEDIGNEI> GFOAMBMJKDB;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		public JHLENDFDGJM(AEOJKNGHIFP<KAFKEDIGNEI> MNCHJKBKFHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class EFEAFGKBPDI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class JGOBOLIKKOA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct KCEMEFMIIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly MPBEBKEJIJN AGECILLPLJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly AEOJKNGHIFP<JGOBOLIKKOA> GNHAELGMLIL;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xEAD240", Offset = "0xEAB840", VA = "0x180EAD240")]
		private KCEMEFMIIFK(MPBEBKEJIJN ENFAOJCOHIL, AEOJKNGHIFP<JGOBOLIKKOA> BCGFPONHJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B07470", Offset = "0x2B05A70", VA = "0x182B07470")]
		public static KCEMEFMIIFK BPFPEFLIIPC(MPBEBKEJIJN ENFAOJCOHIL, AEOJKNGHIFP<JGOBOLIKKOA> BCGFPONHJPI)
		{
			return default(KCEMEFMIIFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class PPOKAAOLJGO : JGOBOLIKKOA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct IPCDFLBCNHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly AEOJKNGHIFP<KAFKEDIGNEI> GFOAMBMJKDB;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		public IPCDFLBCNHF(AEOJKNGHIFP<KAFKEDIGNEI> MNCHJKBKFHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class KAFKEDIGNEI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct EMEHAKPPOCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public OEFGLPCMBJB<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> OHLDBKFFHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OEFGLPCMBJB<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> INMBPGMGKBF;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B05BD0", Offset = "0x2B041D0", VA = "0x182B05BD0")]
		private EMEHAKPPOCM([In] OEFGLPCMBJB<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> ILLMINLDJKA, [In] OEFGLPCMBJB<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> JDJKNLPOMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B05B50", Offset = "0x2B04150", VA = "0x182B05B50")]
		public static EMEHAKPPOCM BPFPEFLIIPC()
		{
			return default(EMEHAKPPOCM);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal ODLNCHLIAFI<EFEAFGKBPDI, KCEMEFMIIFK> BJEKGDPOFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal ODLNCHLIAFI<PPOKAAOLJGO, IPCDFLBCNHF> DEBNFGODDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal ODLNCHLIAFI<IACMJNDBLCG, JHLENDFDGJM> AAPOPCKGOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal OEFGLPCMBJB<(AEOJKNGHIFP<EFEAFGKBPDI> CallId, AEOJKNGHIFP<KAFKEDIGNEI> IOId)> POPFOHHAFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal ODLNCHLIAFI<KAFKEDIGNEI, EMEHAKPPOCM> GEBLPCIOAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal PANIMMICCLI<KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>> EDLOEKCCDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal PANIMMICCLI<KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>> OCDNHHFCCPJ;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B04660", Offset = "0x2B02C60", VA = "0x182B04660")]
	private BOPBLJANNLN([In] ODLNCHLIAFI<EFEAFGKBPDI, KCEMEFMIIFK> OIBPGNPICBF, [In] ODLNCHLIAFI<PPOKAAOLJGO, IPCDFLBCNHF> JLMJOLKENFJ, [In] ODLNCHLIAFI<IACMJNDBLCG, JHLENDFDGJM> DAOEHEGCLOF, [In] OEFGLPCMBJB<(AEOJKNGHIFP<EFEAFGKBPDI> CallId, AEOJKNGHIFP<KAFKEDIGNEI> IOId)> DDCICCKHECF, [In] ODLNCHLIAFI<KAFKEDIGNEI, EMEHAKPPOCM> BAHHABKNIKI, [In] PANIMMICCLI<KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>> DDLBIALAAED, [In] PANIMMICCLI<KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>> ADADAFJPINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2B044C0", Offset = "0x2B02AC0", VA = "0x182B044C0")]
	public static BOPBLJANNLN BPFPEFLIIPC()
	{
		return default(BOPBLJANNLN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class PADJFIGALKD
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2B0A300", Offset = "0x2B08900", VA = "0x182B0A300")]
	private static void LOMEBHIDOPA(this BOPBLJANNLN.EMEHAKPPOCM CCKLBDLJPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2B0A0F0", Offset = "0x2B086F0", VA = "0x182B0A0F0")]
	public static void LOMEBHIDOPA(this BOPBLJANNLN CCKLBDLJPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DLKFHPFLKEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public OEFGLPCMBJB<byte> BCEBNHHNGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal BOPBLJANNLN KPMGAFCPIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal CJIGCDILDGH JAHLHBNAMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> CLPPEFMBGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal FHFKOFEGHCE NCBMLLEEPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal KNOJMMGPAPI HGIOCFFEHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal PANIMMICCLI<PIMLAEICHHO, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>?> FMKFLABAAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal OEFGLPCMBJB<AEOJKNGHIFP<PIMLAEICHHO>> JHJKCLGJPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?> EAHGNABLJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> VariableId, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>> ByteCodeWriteLocation)> DICDLKDLACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> GIHICOCDCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal BBPHGJHDMHK CLDGAEEILKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal HJFFLJAFKKH OCIINGEJNLK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B057D0", Offset = "0x2B03DD0", VA = "0x182B057D0")]
	private DLKFHPFLKEE([In] OEFGLPCMBJB<byte> GFEJIGLOEOE, [In] BOPBLJANNLN DJOMHEKDBLP, [In] CJIGCDILDGH BHFFJPHBMNE, [In] FHFKOFEGHCE JACCMLPDFPK, [In] KNOJMMGPAPI EOMOFOLNFEH, [In] PANIMMICCLI<PIMLAEICHHO, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>?> EMKLJPLEBII, [In] OEFGLPCMBJB<AEOJKNGHIFP<PIMLAEICHHO>> NMCOEBKHMMH, [In] PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?> FHEDKKMHAHN, [In] OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> VariableId, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>> ByteCodeWriteLocation)> CHDIDEBMJKD, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DAHJBJBPNJG, [In] BBPHGJHDMHK GDDJIKBGPAO, [In] HJFFLJAFKKH ALNICPLMEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B04E20", Offset = "0x2B03420", VA = "0x182B04E20")]
	public static DLKFHPFLKEE BPFPEFLIIPC()
	{
		return default(DLKFHPFLKEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class MDJLIEHLNPA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct JOKBMLECODK : KNEIAEKMLLH<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>, PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B073F0", Offset = "0x2B059F0", VA = "0x182B073F0")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B073C0", Offset = "0x2B059C0", VA = "0x182B073C0", Slot = "4")]
		public AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> KOOLDNOCIKH(int LEPAEEGOBDO)
		{
			return default(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
		public bool PGPHINEGHMM(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "5")]
		private bool JACNBCDADKP(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B073F0", Offset = "0x2B059F0", VA = "0x182B073F0", Slot = "6")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LJEIJNKNDNJ(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct MIFEIEEOAKG : CGAJDODHFBM<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>, PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B09E00", Offset = "0x2B08400", VA = "0x182B09E00")]
		public OEFGLPCMBJB<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>> OJJLPBKBLAD(int CJCIFJMAEKH, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B09CF0", Offset = "0x2B082F0", VA = "0x182B09CF0")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B09D70", Offset = "0x2B08370", VA = "0x182B09D70", Slot = "6")]
		public void NAOBOIANKEH(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>> DMJEPOICLBJ, AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B09E00", Offset = "0x2B08400", VA = "0x182B09E00", Slot = "4")]
		private OEFGLPCMBJB<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>> PANAHIIEKND(int CJCIFJMAEKH, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B09CF0", Offset = "0x2B082F0", VA = "0x182B09CF0", Slot = "5")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> JPEHDOLADJH(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct NDJLJBAMEPG : KNEIAEKMLLH<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>, PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B09EF0", Offset = "0x2B084F0", VA = "0x182B09EF0")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B09F70", Offset = "0x2B08570", VA = "0x182B09F70", Slot = "4")]
		public AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> KOOLDNOCIKH(int LEPAEEGOBDO)
		{
			return default(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
		public bool PGPHINEGHMM(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "5")]
		private bool NEAEBMBGGOK(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B09EF0", Offset = "0x2B084F0", VA = "0x182B09EF0", Slot = "6")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> ACBANLDLNBP(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct DJPDJAIBHGI : CGAJDODHFBM<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>, PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B04D20", Offset = "0x2B03320", VA = "0x182B04D20")]
		public OEFGLPCMBJB<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>> OJJLPBKBLAD(int CJCIFJMAEKH, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B04CA0", Offset = "0x2B032A0", VA = "0x182B04CA0")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B04D90", Offset = "0x2B03390", VA = "0x182B04D90", Slot = "6")]
		public void NAOBOIANKEH(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>> DMJEPOICLBJ, AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B04D20", Offset = "0x2B03320", VA = "0x182B04D20", Slot = "4")]
		private OEFGLPCMBJB<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>> HLLGPGFLAFC(int CJCIFJMAEKH, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B04CA0", Offset = "0x2B032A0", VA = "0x182B04CA0", Slot = "5")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> DDOJIHMAFBA(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LEPAEEGOBDO, [In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct IKNFHOCKHLL : KNEIAEKMLLH<AEOJKNGHIFP<POJMCLBLKJL>, PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B066B0", Offset = "0x2B04CB0", VA = "0x182B066B0")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(AEOJKNGHIFP<POJMCLBLKJL> LEPAEEGOBDO, [In] PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B06680", Offset = "0x2B04C80", VA = "0x182B06680", Slot = "4")]
		public AEOJKNGHIFP<POJMCLBLKJL> KOOLDNOCIKH(int LEPAEEGOBDO)
		{
			return default(AEOJKNGHIFP<POJMCLBLKJL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B06750", Offset = "0x2B04D50", VA = "0x182B06750")]
		public bool PGPHINEGHMM(AEOJKNGHIFP<POJMCLBLKJL> LEPAEEGOBDO, [In] PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B06750", Offset = "0x2B04D50", VA = "0x182B06750", Slot = "5")]
		private bool MDAIKDDLFBD(AEOJKNGHIFP<POJMCLBLKJL> LEPAEEGOBDO, [In] PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B06670", Offset = "0x2B04C70", VA = "0x182B06670", Slot = "6")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> JHPEDOKMEKG(AEOJKNGHIFP<POJMCLBLKJL> LEPAEEGOBDO, [In] PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct DEJIHHJHALN : CGAJDODHFBM<AEOJKNGHIFP<POJMCLBLKJL>, PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B04C20", Offset = "0x2B03220", VA = "0x182B04C20")]
		public OEFGLPCMBJB<AEOJKNGHIFP<POJMCLBLKJL>> OJJLPBKBLAD(int CJCIFJMAEKH, [In] PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<AEOJKNGHIFP<POJMCLBLKJL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B04AD0", Offset = "0x2B030D0", VA = "0x182B04AD0")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(AEOJKNGHIFP<POJMCLBLKJL> LEPAEEGOBDO, [In] PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B04B70", Offset = "0x2B03170", VA = "0x182B04B70", Slot = "6")]
		public void NAOBOIANKEH(AEOJKNGHIFP<POJMCLBLKJL> LEPAEEGOBDO, PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?> DMJEPOICLBJ, AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B04C20", Offset = "0x2B03220", VA = "0x182B04C20", Slot = "4")]
		private OEFGLPCMBJB<AEOJKNGHIFP<POJMCLBLKJL>> NNMAPEEEOOL(int CJCIFJMAEKH, [In] PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<AEOJKNGHIFP<POJMCLBLKJL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B04C90", Offset = "0x2B03290", VA = "0x182B04C90", Slot = "5")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> OODGIKJMHFP(AEOJKNGHIFP<POJMCLBLKJL> LEPAEEGOBDO, [In] PANIMMICCLI<POJMCLBLKJL, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>?> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct CBIEDHECJGI : KNEIAEKMLLH<int, OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B04730", Offset = "0x2B02D30", VA = "0x182B04730")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> VariableId, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xBA89A0", Offset = "0xBA6FA0", VA = "0x180BA89A0", Slot = "4")]
		public int KOOLDNOCIKH(int LEPAEEGOBDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
		public bool PGPHINEGHMM(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> VariableId, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "5")]
		private bool OJDLLAEEHLP(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> VariableId, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B04720", Offset = "0x2B02D20", VA = "0x182B04720", Slot = "6")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> AOIDHHLEFGF(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> VariableId, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct IDGMEIOLFHF : CGAJDODHFBM<int, OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B06510", Offset = "0x2B04B10", VA = "0x182B06510")]
		public OEFGLPCMBJB<int> OJJLPBKBLAD(int CJCIFJMAEKH, [In] OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> VariableId, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B06490", Offset = "0x2B04A90", VA = "0x182B06490")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> VariableId, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B06580", Offset = "0x2B04B80", VA = "0x182B06580", Slot = "6")]
		public void NAOBOIANKEH(int LEPAEEGOBDO, OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> VariableId, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>> ByteCodeWriteLocation)> DMJEPOICLBJ, AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B06510", Offset = "0x2B04B10", VA = "0x182B06510", Slot = "4")]
		private OEFGLPCMBJB<int> LFHNMIPKEHP(int CJCIFJMAEKH, [In] OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> VariableId, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B06480", Offset = "0x2B04A80", VA = "0x182B06480", Slot = "5")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> FNDJPDAIIEP(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> VariableId, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<EAKMKPIPACI>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct NIODJJHNOPD : KNEIAEKMLLH<int, OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B09FB0", Offset = "0x2B085B0", VA = "0x182B09FB0")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xBA89A0", Offset = "0xBA6FA0", VA = "0x180BA89A0", Slot = "4")]
		public int KOOLDNOCIKH(int LEPAEEGOBDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
		public bool PGPHINEGHMM(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "5")]
		private bool MDLNDIMHGJF(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B09FB0", Offset = "0x2B085B0", VA = "0x182B09FB0", Slot = "6")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> CGOAPILAJAG(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct FAPINCLNAAG : CGAJDODHFBM<int, OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B05D70", Offset = "0x2B04370", VA = "0x182B05D70")]
		public OEFGLPCMBJB<int> OJJLPBKBLAD(int CJCIFJMAEKH, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B05C10", Offset = "0x2B04210", VA = "0x182B05C10")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B05C90", Offset = "0x2B04290", VA = "0x182B05C90", Slot = "6")]
		public void NAOBOIANKEH(int LEPAEEGOBDO, OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ, AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B05D70", Offset = "0x2B04370", VA = "0x182B05D70", Slot = "4")]
		private OEFGLPCMBJB<int> NIDIKGMGGKJ(int CJCIFJMAEKH, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B05C10", Offset = "0x2B04210", VA = "0x182B05C10", Slot = "5")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> IGOAEKHJAEN(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct MACGBCHMCPA : KNEIAEKMLLH<int, OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B078F0", Offset = "0x2B05EF0", VA = "0x182B078F0")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xBA89A0", Offset = "0xBA6FA0", VA = "0x180BA89A0", Slot = "4")]
		public int KOOLDNOCIKH(int LEPAEEGOBDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
		public bool PGPHINEGHMM(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "5")]
		private bool MDLNDIMHGJF(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B078E0", Offset = "0x2B05EE0", VA = "0x182B078E0", Slot = "6")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> CGOAPILAJAG(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct HBEEJAJMJGM : CGAJDODHFBM<int, OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B06250", Offset = "0x2B04850", VA = "0x182B06250")]
		public OEFGLPCMBJB<int> OJJLPBKBLAD(int CJCIFJMAEKH, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B060E0", Offset = "0x2B046E0", VA = "0x182B060E0")]
		public AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B06160", Offset = "0x2B04760", VA = "0x182B06160", Slot = "6")]
		public void NAOBOIANKEH(int LEPAEEGOBDO, OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ, AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> FKMNCAKIOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B06250", Offset = "0x2B04850", VA = "0x182B06250", Slot = "4")]
		private OEFGLPCMBJB<int> NIDIKGMGGKJ(int CJCIFJMAEKH, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(OEFGLPCMBJB<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B060D0", Offset = "0x2B046D0", VA = "0x182B060D0", Slot = "5")]
		private AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> IGOAEKHJAEN(int LEPAEEGOBDO, [In] OEFGLPCMBJB<(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> Target, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> ByteCodeWriteLocation)> DMJEPOICLBJ)
		{
			return default(AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct KJIOKGDIIOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> MMPILBKOGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool JKJGOMJCICP;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x217FEB0", Offset = "0x217E4B0", VA = "0x18217FEB0")]
		public KJIOKGDIIOI(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI, bool BBKCCANLGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2B07640", Offset = "0x2B05C40", VA = "0x182B07640")]
		public void BHACFNDCJGJ([Out] AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI, [Out] bool BBKCCANLGFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct NNFPBEDMHPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly AEOJKNGHIFP<POJMCLBLKJL> OKOBFAGDFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> MMPILBKOGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool JKJGOMJCICP;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A060", Offset = "0x2B08660", VA = "0x182B0A060")]
		public NNFPBEDMHPL(AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI, bool BBKCCANLGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A050", Offset = "0x2B08650", VA = "0x182B0A050")]
		public void BHACFNDCJGJ([Out] AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI, [Out] bool BBKCCANLGFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A030", Offset = "0x2B08630", VA = "0x182B0A030")]
		public void BHACFNDCJGJ([Out] AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI, [Out] AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB, [Out] bool BBKCCANLGFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct PPOLKLMDGOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly AEOJKNGHIFP<POJMCLBLKJL> OKOBFAGDFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> MMPILBKOGNH;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xEAD240", Offset = "0xEAB840", VA = "0x180EAD240")]
		public PPOLKLMDGOL(AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2B0A370", Offset = "0x2B08970", VA = "0x182B0A370")]
		public void BHACFNDCJGJ([Out] AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI, [Out] AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B08FE0", Offset = "0x2B075E0", VA = "0x182B08FE0")]
	public static void LOMEBHIDOPA(this DLKFHPFLKEE CCKLBDLJPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2B07E70", Offset = "0x2B06470", VA = "0x182B07E70")]
	public static void EDJEIIEBCCM(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<PIMLAEICHHO> JIPPGBIBHAK, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> IMDOAINGGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2B07DA0", Offset = "0x2B063A0", VA = "0x182B07DA0")]
	public static void CMOJGIPNOPK(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<PIMLAEICHHO> JIPPGBIBHAK, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> IMDOAINGGKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B07970", Offset = "0x2B05F70", VA = "0x182B07970")]
	public static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>? ABENENAPFAC([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<PIMLAEICHHO> JIPPGBIBHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B08490", Offset = "0x2B06A90", VA = "0x182B08490")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> GMNMJFJKJBL([In] this DLKFHPFLKEE CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B07AD0", Offset = "0x2B060D0", VA = "0x182B07AD0")]
	private static void BAOOAPPEDHI(this DLKFHPFLKEE CCKLBDLJPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B094D0", Offset = "0x2B07AD0", VA = "0x182B094D0")]
	private static AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>? MPGNDAFLDKF([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B09810", Offset = "0x2B07E10", VA = "0x182B09810")]
	public static void OLKDPKKEMHN(this DLKFHPFLKEE CCKLBDLJPNG, [In] OEFGLPCMBJB<HBFIGJJPOHE> BAJGFKAJJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B07C30", Offset = "0x2B06230", VA = "0x182B07C30")]
	public static FHFKOFEGHCE.DBEICOGEIBA BPNBNKCEMFI([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI)
	{
		return default(FHFKOFEGHCE.DBEICOGEIBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2B08A10", Offset = "0x2B07010", VA = "0x182B08A10")]
	public static MKOKAOLNOHA<byte> JPBPNLPCBCJ([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI)
	{
		return default(MKOKAOLNOHA<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2B08BB0", Offset = "0x2B071B0", VA = "0x182B08BB0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KIOAGHNCJML([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B088B0", Offset = "0x2B06EB0", VA = "0x182B088B0")]
	public static NCIHCFDNMCG JEIAOCPIFLK([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3E9CBB0", Offset = "0x3E9B1B0", VA = "0x183E9CBB0")]
	private static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> MGGEOKJHBGM<TMJoin>(this DLKFHPFLKEE CCKLBDLJPNG, FHFKOFEGHCE.DBEICOGEIBA ENFAOJCOHIL, AEOJKNGHIFP<TMJoin> BCGFPONHJPI) where TMJoin : FHFKOFEGHCE.GFCIDKADCGM
	{
		return default(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2B093C0", Offset = "0x2B079C0", VA = "0x182B093C0")]
	public static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> MDACEMMKAJK(this DLKFHPFLKEE CCKLBDLJPNG, bool GDDAEPLINAK)
	{
		return default(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2B092B0", Offset = "0x2B078B0", VA = "0x182B092B0")]
	public static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> LOMIAHDGHJB(this DLKFHPFLKEE CCKLBDLJPNG, MKOKAOLNOHA<byte> NCMOHOAIBBB)
	{
		return default(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B09340", Offset = "0x2B07940", VA = "0x182B09340")]
	public static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> MCMFHODIEKM(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> BOIPNBLMBCP)
	{
		return default(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2B081B0", Offset = "0x2B067B0", VA = "0x182B081B0")]
	public static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> GDKGCOLMEPN(this DLKFHPFLKEE CCKLBDLJPNG, int KFIPCFMANMO)
	{
		return default(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2B09980", Offset = "0x2B07F80", VA = "0x182B09980")]
	public static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> OONCGAHCMAO(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JCOIOELBBMH)
	{
		return default(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B530", Offset = "0x3E99B30", VA = "0x183E9B530")]
	private static AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF> EKBHMPGHIBN<TMJoin>(this DLKFHPFLKEE CCKLBDLJPNG, KNOJMMGPAPI.HAPOPAFNGMD ENFAOJCOHIL, AEOJKNGHIFP<TMJoin> BCGFPONHJPI) where TMJoin : KNOJMMGPAPI.EKFKGMCFEEI
	{
		return default(AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B080B0", Offset = "0x2B066B0", VA = "0x182B080B0")]
	public static AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF> FEGACFNKLNG(this DLKFHPFLKEE CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B07C90", Offset = "0x2B06290", VA = "0x182B07C90")]
	public static AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF> CALDFONKHDG(this DLKFHPFLKEE CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B07A00", Offset = "0x2B06000", VA = "0x182B07A00")]
	public static AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF> AEGFNFGCAJO(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> LKJAONPCCIH)
	{
		return default(AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B08F30", Offset = "0x2B07530", VA = "0x182B08F30")]
	public static AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF> LKBPGILPENF(this DLKFHPFLKEE CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2B087B0", Offset = "0x2B06DB0", VA = "0x182B087B0")]
	public static AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF> INEHNIODNKN(this DLKFHPFLKEE CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B084F0", Offset = "0x2B06AF0", VA = "0x182B084F0")]
	public static BOPBLJANNLN.MPBEBKEJIJN GOBDKPAHLGI([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI> MOEJFADHKLO)
	{
		return default(BOPBLJANNLN.MPBEBKEJIJN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2B08C60", Offset = "0x2B07260", VA = "0x182B08C60")]
	public static MKBNAJJCKEF<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>, DGICMDBNMIP<BOPBLJANNLN.KAFKEDIGNEI>> KKNOCPBLAHF([In] this DLKFHPFLKEE CCKLBDLJPNG)
	{
		return default(MKBNAJJCKEF<AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>, DGICMDBNMIP<BOPBLJANNLN.KAFKEDIGNEI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2B08D00", Offset = "0x2B07300", VA = "0x182B08D00")]
	public static AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> LDJANELBFJN([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI> MOEJFADHKLO)
	{
		return default(AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B097B0", Offset = "0x2B07DB0", VA = "0x182B097B0")]
	public static BOPBLJANNLN.EMEHAKPPOCM OHBFPGLAKLO([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> MNCHJKBKFHP)
	{
		return default(BOPBLJANNLN.EMEHAKPPOCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B08CA0", Offset = "0x2B072A0", VA = "0x182B08CA0")]
	public static BOPBLJANNLN.EMEHAKPPOCM KOCMBBAENIL(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> MNCHJKBKFHP)
	{
		return default(BOPBLJANNLN.EMEHAKPPOCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3E9CB20", Offset = "0x3E9B120", VA = "0x183E9CB20")]
	private static AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI> MFMPEGDICAJ<TMJoin>(this DLKFHPFLKEE CCKLBDLJPNG, BOPBLJANNLN.MPBEBKEJIJN ENFAOJCOHIL, AEOJKNGHIFP<TMJoin> BCGFPONHJPI) where TMJoin : BOPBLJANNLN.JGOBOLIKKOA
	{
		return default(AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2B07F00", Offset = "0x2B06500", VA = "0x182B07F00")]
	public static (AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>) EPOLDKNKAGB(this DLKFHPFLKEE CCKLBDLJPNG)
	{
		return default((AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2B08550", Offset = "0x2B06B50", VA = "0x182B08550")]
	public static (AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>) HGAMLCPOFEN(this DLKFHPFLKEE CCKLBDLJPNG)
	{
		return default((AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B07A80", Offset = "0x2B06080", VA = "0x182B07A80")]
	public static AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI> BAKMHKLPKFK(this DLKFHPFLKEE CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2B082E0", Offset = "0x2B068E0", VA = "0x182B082E0")]
	public static void GHOEKDMHOLK(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI> MNCHJKBKFHP, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> HBMDPOJAOKI, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>> HGMDFEJHGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B5C0", Offset = "0x3E99BC0", VA = "0x183E9B5C0")]
	public static KJIOKGDIIOI FOMAEGAKCKM<TDeps, TStateSys>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB) where TDeps : ONHBOCCBCIC<TStateSys>
	{
		return default(KJIOKGDIIOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C7C0", Offset = "0x3E9ADC0", VA = "0x183E9C7C0")]
	public static NNFPBEDMHPL IHCJHGBLLCL<TDeps, TStateSys>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<GCCEHKIFAID> BHKHNPBBPIB, int ICPEAHGPANA) where TDeps : ONHBOCCBCIC<TStateSys>
	{
		return default(NNFPBEDMHPL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3E9C3A0", Offset = "0x3E9A9A0", VA = "0x183E9C3A0")]
	public static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>? GEDFKLELEDE<TDeps, TStateSys>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<GCCEHKIFAID> BHKHNPBBPIB, [In] ReadOnlySpan<int> BEFLBDMNIME, [In] Span<PPOLKLMDGOL> KLKKDIEMJAJ) where TDeps : ONHBOCCBCIC<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E9CC40", Offset = "0x3E9B240", VA = "0x183E9CC40")]
	public static AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF> OCBALLDDFOC<TDeps, TStateSys>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<PIMLAEICHHO> JIPPGBIBHAK) where TDeps : ONHBOCCBCIC<TStateSys>
	{
		return default(AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B08960", Offset = "0x2B06F60", VA = "0x182B08960")]
	public static CJIGCDILDGH.EFJPEOFJNGI JIDFHJGDBJN([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JIEJOKBHEMF)
	{
		return default(CJIGCDILDGH.EFJPEOFJNGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B08700", Offset = "0x2B06D00", VA = "0x182B08700")]
	public static CJIGCDILDGH.LADOGDPHMAN HGIJAPGPDPL([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JIEJOKBHEMF)
	{
		return default(CJIGCDILDGH.LADOGDPHMAN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2B08E80", Offset = "0x2B07480", VA = "0x182B08E80")]
	public static CJIGCDILDGH.OHCHGJGOFCH LFIJMCGPLPA([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JIEJOKBHEMF)
	{
		return default(CJIGCDILDGH.OHCHGJGOFCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2B09B30", Offset = "0x2B08130", VA = "0x182B09B30")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> PEGENBJFJJO(this DLKFHPFLKEE CCKLBDLJPNG, int? ECMCGKKPNLC, string DJFMCHMDHGK)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B08800", Offset = "0x2B06E00", VA = "0x182B08800")]
	public static CJIGCDILDGH.PKLHGPILKAP JANMIHAGGFJ([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JIEJOKBHEMF)
	{
		return default(CJIGCDILDGH.PKLHGPILKAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B08F80", Offset = "0x2B07580", VA = "0x182B08F80")]
	public static CJIGCDILDGH.NIPJDIOOMCO LLACLNPMAOB([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JIEJOKBHEMF)
	{
		return default(CJIGCDILDGH.NIPJDIOOMCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2B095C0", Offset = "0x2B07BC0", VA = "0x182B095C0")]
	public static int? NPACLILCLEM([In] this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JIEJOKBHEMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3E9CA40", Offset = "0x3E9B040", VA = "0x183E9CA40")]
	private static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LBNFHCMLCDJ<TMJoin>(this DLKFHPFLKEE CCKLBDLJPNG, int? ECMCGKKPNLC, CJIGCDILDGH.NIPJDIOOMCO ENFAOJCOHIL, AEOJKNGHIFP<TMJoin> BCGFPONHJPI) where TMJoin : CJIGCDILDGH.PHBGKNPBGME
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B08230", Offset = "0x2B06830", VA = "0x182B08230")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> GFKMCFEDAGF(this DLKFHPFLKEE CCKLBDLJPNG, int? ECMCGKKPNLC, AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI> MOEJFADHKLO, int LEPAEEGOBDO)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B09560", Offset = "0x2B07B60", VA = "0x182B09560")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> NLKODCGPKAF(this DLKFHPFLKEE CCKLBDLJPNG, int? ECMCGKKPNLC)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B09620", Offset = "0x2B07C20", VA = "0x182B09620")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> OGNCCGJIEFF(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>? NKIJIPLPNFH, int? ECMCGKKPNLC)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B09440", Offset = "0x2B07A40", VA = "0x182B09440")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> MFFEOCNCEAH(this DLKFHPFLKEE CCKLBDLJPNG, int? ECMCGKKPNLC, int LEPAEEGOBDO)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B08AC0", Offset = "0x2B070C0", VA = "0x182B08AC0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KBLNJOHFKNE(this DLKFHPFLKEE CCKLBDLJPNG, int? ECMCGKKPNLC)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B09A00", Offset = "0x2B08000", VA = "0x182B09A00")]
	public static void PANNOLBDAAE(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JCOIOELBBMH, AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI> MOEJFADHKLO, int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B08370", Offset = "0x2B06970", VA = "0x182B08370")]
	public static void GKICAOJJHCL(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JCOIOELBBMH, int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B07CE0", Offset = "0x2B062E0", VA = "0x182B07CE0")]
	public static void CIAOCHEMKDA(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JCOIOELBBMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B08B20", Offset = "0x2B07120", VA = "0x182B08B20")]
	public static void KHMPBMLMDNI(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> LKEAKCADNOO, AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> KJLEMDCJLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B080F0", Offset = "0x2B066F0", VA = "0x182B080F0")]
	public static void GCMHGIDCGOL(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JCOIOELBBMH, AEOJKNGHIFP<LBEDHGCJEFE<GBNKLJIOKII>> EHAFBFIGEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3E9B470", Offset = "0x3E99A70", VA = "0x183E9B470")]
	public static void DCGNKPNJCLF<M>(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JCOIOELBBMH, AEOJKNGHIFP<LBEDHGCJEFE<GHGPBDJNHMJ<M>>> EHAFBFIGEPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface ONHBOCCBCIC<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEOJKNGHIFP<CMEPPNMKNHN> DNLMIADGLBB(TStateSys AOGGHDKINFI);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AEOJKNGHIFP<CMEPPNMKNHN> GOAJKCEGOGB(TStateSys AOGGHDKINFI);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AEOJKNGHIFP<CMEPPNMKNHN> EABMCPIOIHC(TStateSys AOGGHDKINFI);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AEOJKNGHIFP<CMEPPNMKNHN> LGEEIKMPOKP(TStateSys AOGGHDKINFI);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF> LFNHCFEDMMH(TStateSys AOGGHDKINFI, DLKFHPFLKEE BOEMGECGEJI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> FPGABGGBLEJ(TStateSys AOGGHDKINFI, DLKFHPFLKEE BOEMGECGEJI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<PIMLAEICHHO> JIPPGBIBHAK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JHLJHLDMKEJ(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AEOJKNGHIFP<PIMLAEICHHO> DFKKMGHNHHF(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB, int PMLKJCOCAJP);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PAMKAGHGKEK JMGFDPCLBKN(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool LDILMKGIIDJ(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int BELGEDNCBKL(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MKOKAOLNOHA<byte> PGBDCCAAAJF(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(MKOKAOLNOHA<byte>, AEOJKNGHIFP<CMEPPNMKNHN>) IKMIAAFBGDM(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<POJMCLBLKJL> GPPODEGPBNB);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int FBJHPCCLLDP(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<PIMLAEICHHO> JIPPGBIBHAK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AEOJKNGHIFP<POJMCLBLKJL> OMOLEEAHOPH(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<PIMLAEICHHO> JIPPGBIBHAK, int ICPEAHGPANA);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AEOJKNGHIFP<POJMCLBLKJL> FGFJCBALLFA(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, AEOJKNGHIFP<GCCEHKIFAID> BHKHNPBBPIB, int ICPEAHGPANA);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int DKGNFLAGNKP(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? AKCADBLJDME(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int CPKMINCAPFC(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? GAHFBOAALDE(TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ, int LEPAEEGOBDO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BLCFNFOJMOD
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3B252F0", Offset = "0x3B238F0", VA = "0x183B252F0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL?> HGKIFFPGFJK<T, TOpInput, TOpOutput>(this DLKFHPFLKEE CCKLBDLJPNG, T KNPHEACNGDK, T IMDBLBCMEAE, int INFFPPKPDLF, IntPtr EMJGECFFEDE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3B25690", Offset = "0x3B23C90", VA = "0x183B25690")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL?> MDGJGEOOPMA<T, TOpInput, TOpOutput>(this DLKFHPFLKEE CCKLBDLJPNG, T KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE, int INFFPPKPDLF, IntPtr EMJGECFFEDE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3B251D0", Offset = "0x3B237D0", VA = "0x183B251D0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL?> GLNHNNDLJDD<TOpInput, TOpOutput>(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE, int INFFPPKPDLF, IntPtr EMJGECFFEDE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2B016D0", Offset = "0x2AFFCD0", VA = "0x182B016D0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> GELBHFHEAAK(this DLKFHPFLKEE CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2B027A0", Offset = "0x2B00DA0", VA = "0x182B027A0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JNIMMKNKLFE(this DLKFHPFLKEE CCKLBDLJPNG, float HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2B01DA0", Offset = "0x2B003A0", VA = "0x182B01DA0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJODFIDJNNA(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2B01950", Offset = "0x2AFFF50", VA = "0x182B01950")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> GLFABDEKMBA(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B03B20", Offset = "0x2B02120", VA = "0x182B03B20")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> NEFHOLOGBEL(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF810", Offset = "0x2AFDE10", VA = "0x182AFF810")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> BALIANGAOGE(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2AFFC30", Offset = "0x2AFE230", VA = "0x182AFFC30")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> BMCGBHGLILD(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2B02460", Offset = "0x2B00A60", VA = "0x182B02460")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JGACEPMHCBN(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2B012D0", Offset = "0x2AFF8D0", VA = "0x182B012D0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> FIFHIHFNMAO(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2AFFDB0", Offset = "0x2AFE3B0", VA = "0x182AFFDB0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> BOAPHPOCHHE(this DLKFHPFLKEE CCKLBDLJPNG, int KNPHEACNGDK, int IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF100", Offset = "0x2AFD700", VA = "0x182AFF100")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> ABCHOOFKIBK(this DLKFHPFLKEE CCKLBDLJPNG, int KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B02FF0", Offset = "0x2B015F0", VA = "0x182B02FF0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KJFAMBFEFHP(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2B007C0", Offset = "0x2AFEDC0", VA = "0x182B007C0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> ECILIBBPLKA(this DLKFHPFLKEE CCKLBDLJPNG, float KNPHEACNGDK, float IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2B038F0", Offset = "0x2B01EF0", VA = "0x182B038F0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> MFOLKOOPJKD(this DLKFHPFLKEE CCKLBDLJPNG, float KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2B03730", Offset = "0x2B01D30", VA = "0x182B03730")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LPJINJGJGAK(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2AFFD30", Offset = "0x2AFE330", VA = "0x182AFFD30")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> BNPODBHIKDA(this DLKFHPFLKEE CCKLBDLJPNG, int KNPHEACNGDK, int IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2B018D0", Offset = "0x2AFFED0", VA = "0x182B018D0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> GKBACKAAILJ(this DLKFHPFLKEE CCKLBDLJPNG, int KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2B01AF0", Offset = "0x2B000F0", VA = "0x182B01AF0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> GPBMAKFDJOG(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B028C0", Offset = "0x2B00EC0", VA = "0x182B028C0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JOOGCFFJKFF(this DLKFHPFLKEE CCKLBDLJPNG, float KNPHEACNGDK, float IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2B03C40", Offset = "0x2B02240", VA = "0x182B03C40")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> NMKAJLLHCEE(this DLKFHPFLKEE CCKLBDLJPNG, float KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2B020E0", Offset = "0x2B006E0", VA = "0x182B020E0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> INGHPGOIOPC(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF530", Offset = "0x2AFDB30", VA = "0x182AFF530")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> AJCHBMDKGON(this DLKFHPFLKEE CCKLBDLJPNG, int KNPHEACNGDK, int IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2B03CC0", Offset = "0x2B022C0", VA = "0x182B03CC0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> NNFDDDKBJCO(this DLKFHPFLKEE CCKLBDLJPNG, int KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2B02720", Offset = "0x2B00D20", VA = "0x182B02720")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JMEOODHCOCB(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2B03870", Offset = "0x2B01E70", VA = "0x182B03870")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> MBPNCPOGGFM(this DLKFHPFLKEE CCKLBDLJPNG, float KNPHEACNGDK, float IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B026A0", Offset = "0x2B00CA0", VA = "0x182B026A0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JKENMLDJEBP(this DLKFHPFLKEE CCKLBDLJPNG, float KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B03FE0", Offset = "0x2B025E0", VA = "0x182B03FE0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> OLOIJPILBNJ(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B04060", Offset = "0x2B02660", VA = "0x182B04060")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> OOOCIBFNBDJ(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B04440", Offset = "0x2B02A40", VA = "0x182B04440")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> PJJIHFCPEAD(this DLKFHPFLKEE CCKLBDLJPNG, int FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2B01110", Offset = "0x2AFF710", VA = "0x182B01110")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> FAOBOKBAKOI(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF350", Offset = "0x2AFD950", VA = "0x182AFF350")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> AGOMDJNDONI(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> EKKDJAEPGAI)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2B03F60", Offset = "0x2B02560", VA = "0x182B03F60")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> OHKGGKAJCPO(this DLKFHPFLKEE CCKLBDLJPNG, int FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2B01A50", Offset = "0x2B00050", VA = "0x182B01A50")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> GODHAHMJOPO(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2B02A40", Offset = "0x2B01040", VA = "0x182B02A40")]
	public static (AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>) KGPOGEELJCC(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<HGHHPBFOBDA> BMKCEGLIDKB, [In] ReadOnlySpan<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> ILLMINLDJKA, [In] ReadOnlySpan<int?> LFILFMPALMB, [In] Span<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> KBHAFCOAFAE)
	{
		return default((AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2B00BA0", Offset = "0x2AFF1A0", VA = "0x182B00BA0")]
	public static (AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>) EMOKFEHELOA(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<MBCCODFIKOD> FMEGBKCCDHP, [In] ReadOnlySpan<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> ILLMINLDJKA, [In] ReadOnlySpan<int?> LFILFMPALMB, [In] Span<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> KBHAFCOAFAE)
	{
		return default((AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3B255A0", Offset = "0x3B23BA0", VA = "0x183B255A0")]
	public static (AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<CMEPPNMKNHN>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<TMarker>>, AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>) IGKMGJKPPLC<TMarker>(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CMEPPNMKNHN> OCDCGAHLBOI, [In] ReadOnlySpan<byte> DAJAOHIJHHL)
	{
		return default((AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<LBEDHGCJEFE<CMEPPNMKNHN>>, AEOJKNGHIFP<LBEDHGCJEFE<JCJHMLMKFCL>>, AEOJKNGHIFP<LBEDHGCJEFE<TMarker>>, AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2B01EE0", Offset = "0x2B004E0", VA = "0x182B01EE0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HKCMJCJEHGM(this DLKFHPFLKEE CCKLBDLJPNG, int BEDGCBJMDED, [Optional] AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>? IKOPHEOIONA)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2B02950", Offset = "0x2B00F50", VA = "0x182B02950")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KGAHEDNKMLE(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> BEDGCBJMDED, [Optional] AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>? IKOPHEOIONA)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2AFFFB0", Offset = "0x2AFE5B0", VA = "0x182AFFFB0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> CIGKDBEFEIM(this DLKFHPFLKEE CCKLBDLJPNG, [In] ReadOnlySpan<byte> BEDGCBJMDED, [Optional] AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>? IKOPHEOIONA)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2B03610", Offset = "0x2B01C10", VA = "0x182B03610")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LPGEPDKHMBG(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> BEDGCBJMDED, int MLMBLBFOLPC, [Optional] AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>? IKOPHEOIONA)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2AFFEB0", Offset = "0x2AFE4B0", VA = "0x182AFFEB0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> BOMNMGABLKB(this DLKFHPFLKEE CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2B01B70", Offset = "0x2B00170", VA = "0x182B01B70")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HADHBFAMAOH(this DLKFHPFLKEE CCKLBDLJPNG, float HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2B03130", Offset = "0x2B01730", VA = "0x182B03130")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KLFMFCDEKHE(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B03A20", Offset = "0x2B02020", VA = "0x182B03A20")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> NBGDAHDOLBP(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF6F0", Offset = "0x2AFDCF0", VA = "0x182AFF6F0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> AMGFKKMPAAF(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2B00A60", Offset = "0x2AFF060", VA = "0x182B00A60")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> EHCECDLGPMG(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2AFFBB0", Offset = "0x2AFE1B0", VA = "0x182AFFBB0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> BKLDNHPGNDI(this DLKFHPFLKEE CCKLBDLJPNG, int KNPHEACNGDK, int IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B009E0", Offset = "0x2AFEFE0", VA = "0x182B009E0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> EGLJHMDDGFE(this DLKFHPFLKEE CCKLBDLJPNG, int KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B01550", Offset = "0x2AFFB50", VA = "0x182B01550")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> FPLFJLJDHGN(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KNPHEACNGDK, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IMDBLBCMEAE)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2B04240", Offset = "0x2B02840", VA = "0x182B04240")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> PBIAPENDCLO(this DLKFHPFLKEE CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF220", Offset = "0x2AFD820", VA = "0x182AFF220")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> ADABIALDGPN(this DLKFHPFLKEE CCKLBDLJPNG, float HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2B034D0", Offset = "0x2B01AD0", VA = "0x182B034D0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LOJAMMMHBHO(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2B015D0", Offset = "0x2AFFBD0", VA = "0x182B015D0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> GAPIEJHJIMJ(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2B03D40", Offset = "0x2B02340", VA = "0x182B03D40")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> OAHAKMJDKKB(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2B01410", Offset = "0x2AFFA10", VA = "0x182B01410")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> FMMCAEBLCNC(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2B012B0", Offset = "0x2AFF8B0", VA = "0x182B012B0")]
	public static AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>> FHAAODCKEIB(this DLKFHPFLKEE CCKLBDLJPNG)
	{
		return default(AEOJKNGHIFP<LBEDHGCJEFE<LBEDHGCJEFE<JPAECFFFFJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2B04340", Offset = "0x2B02940", VA = "0x182B04340")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> PDBOKLDKMID(this DLKFHPFLKEE CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF950", Offset = "0x2AFDF50", VA = "0x182AFF950")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> BDLDBGEGCIJ(this DLKFHPFLKEE CCKLBDLJPNG, float HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2B02EB0", Offset = "0x2B014B0", VA = "0x182B02EB0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> KIFMHMKDNNB(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2B011B0", Offset = "0x2AFF7B0", VA = "0x182B011B0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> FDAEOILBBFK(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2B001A0", Offset = "0x2AFE7A0", VA = "0x182B001A0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> DFDAEJPIGPP(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2B01FA0", Offset = "0x2B005A0", VA = "0x182B01FA0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> IBHGODJMDHO(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2B01010", Offset = "0x2AFF610", VA = "0x182B01010")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> FADFPHGGJOI(this DLKFHPFLKEE CCKLBDLJPNG, int FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2B01C90", Offset = "0x2B00290", VA = "0x182B01C90")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HGFILIKCKCF(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> FKMNCAKIOFK)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2B02940", Offset = "0x2B00F40", VA = "0x182B02940")]
	public static void KABPJGAABKC(this DLKFHPFLKEE CCKLBDLJPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2B03E60", Offset = "0x2B02460", VA = "0x182B03E60")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> OCOHEGCIEKC(this DLKFHPFLKEE CCKLBDLJPNG, float HJOOONLCNPC, float LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2B008C0", Offset = "0x2AFEEC0", VA = "0x182B008C0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> EDMGBFNNFBI(this DLKFHPFLKEE CCKLBDLJPNG, float HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2B03390", Offset = "0x2B01990", VA = "0x182B03390")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LMPIHAFPFPF(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2B000A0", Offset = "0x2AFE6A0", VA = "0x182B000A0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> DCPDMKOGEHL(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B02580", Offset = "0x2B00B80", VA = "0x182B02580")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JIDKKJKGGBL(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF5B0", Offset = "0x2AFDBB0", VA = "0x182AFF5B0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> AMDMFCHNKHF(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2B002C0", Offset = "0x2AFE8C0", VA = "0x182B002C0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> DKDPCODDGGM(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> FCGNOJPPJFK, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> FHHBHIBMNHP)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2B017D0", Offset = "0x2AFFDD0", VA = "0x182B017D0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> GFMDIIDOFEP(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, int LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2B03270", Offset = "0x2B01870", VA = "0x182B03270")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LHNEFOMPEMH(this DLKFHPFLKEE CCKLBDLJPNG, int HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2AFFA70", Offset = "0x2AFE070", VA = "0x182AFFA70")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> BIPHBOEMECA(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HJOOONLCNPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> LFDKOFAPJII)
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3B24380", Offset = "0x3B22980", VA = "0x183B24380")]
	public static void CKOINLPKJHO<TDeps, TState>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TState BJGEPEKIJPC, AEOJKNGHIFP<HGHHPBFOBDA> BMKCEGLIDKB, [In] ReadOnlySpan<AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>> LAPNKLBFDIO, [In] ReadOnlySpan<int?> LFILFMPALMB, [In] Span<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> KBHAFCOAFAE, [In] Span<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> FPCEMHLDIOP, [In] ReadOnlySpan<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>?> GGJGCPABLKD) where TDeps : notnull, ONHBOCCBCIC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3B24CC0", Offset = "0x3B232C0", VA = "0x183B24CC0")]
	public static void FILJPGBELIO<TDeps, TState>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TState BJGEPEKIJPC, AEOJKNGHIFP<MBCCODFIKOD> MGENEOADHDD, [In] ReadOnlySpan<AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>> LKJNDOLHEMG, [In] ReadOnlySpan<int?> LFILFMPALMB, [In] Span<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> KBHAFCOAFAE, [In] Span<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>> FPCEMHLDIOP, [In] ReadOnlySpan<AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>?> GGJGCPABLKD) where TDeps : notnull, ONHBOCCBCIC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3B241C0", Offset = "0x3B227C0", VA = "0x183B241C0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> CBAGJGKHPHH<TDeps, TState>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TState BJGEPEKIJPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> NKIJIPLPNFH, [Optional] AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>? IKOPHEOIONA) where TDeps : notnull, ONHBOCCBCIC<TState> where TState : notnull
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3B24890", Offset = "0x3B22E90", VA = "0x183B24890")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> FBCHKJKLMFP<TDeps, TState>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TState BJGEPEKIJPC, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> LKJAONPCCIH, [Optional] AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>? IKOPHEOIONA) where TDeps : notnull, ONHBOCCBCIC<TState> where TState : notnull
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3B25970", Offset = "0x3B23F70", VA = "0x183B25970")]
	public static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> NAPKEADMGOB<TDeps, TStateSys>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TStateSys AOGGHDKINFI) where TDeps : notnull, ONHBOCCBCIC<TStateSys> where TStateSys : notnull
	{
		return default(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3B266A0", Offset = "0x3B24CA0", VA = "0x183B266A0")]
	public static AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF> POENMLDPAPI<TDeps, TStateSys>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TStateSys AOGGHDKINFI) where TDeps : notnull, ONHBOCCBCIC<TStateSys> where TStateSys : notnull
	{
		return default(AEOJKNGHIFP<KNOJMMGPAPI.KIGPJHOKMGF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2B00680", Offset = "0x2AFEC80", VA = "0x182B00680")]
	public static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> DKNJHJHPBLJ(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> PMEDBIMEABL, IntPtr LMCLLFJCKJK, IntPtr PJLEJOBAKGB)
	{
		return default(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2B02160", Offset = "0x2B00760", VA = "0x182B02160")]
	public static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> JCFFGLBGLDL(this DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> CCHNACMDMBC, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> AGDENBHOJHK, IntPtr CIINMOOAHJK, IntPtr PGKGEDBEHEJ, IntPtr DPHPNEANAIN, bool IOKMBKFHHJO)
	{
		return default(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3B25FF0", Offset = "0x3B245F0", VA = "0x183B25FF0")]
	public static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> OCGBMMMILBC<TDeps, TState>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TState BJGEPEKIJPC, AEOJKNGHIFP<HGHHPBFOBDA> MHAPBGELPIH, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> CCHNACMDMBC, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> AGDENBHOJHK, int? IEIGDLGIHGM, [Optional] IntPtr OHFLNOKJBBK) where TDeps : notnull, ONHBOCCBCIC<TState> where TState : notnull
	{
		return default(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3B25CE0", Offset = "0x3B242E0", VA = "0x183B25CE0")]
	private static AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> OCGBMMMILBC<TDeps, TState>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TState BJGEPEKIJPC, AEOJKNGHIFP<HGHHPBFOBDA> MHAPBGELPIH, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> CCHNACMDMBC, AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN> AGDENBHOJHK, int? IEIGDLGIHGM) where TDeps : notnull, ONHBOCCBCIC<TState> where TState : notnull
	{
		return default(AEOJKNGHIFP<FHFKOFEGHCE.AEDHKDHPNLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3B269F0", Offset = "0x3B24FF0", VA = "0x183B269F0")]
	public static AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> PPEPBFHFMOJ<TDeps, TState>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TState BJGEPEKIJPC, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> BEDGCBJMDED, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>? IKOPHEOIONA) where TDeps : notnull, ONHBOCCBCIC<TState> where TState : notnull
	{
		return default(AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3B23E00", Offset = "0x3B22400", VA = "0x183B23E00")]
	public static void BCLADAJOHPI<TDeps, TState>(this DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TState BJGEPEKIJPC, int IFJKONJCAGO) where TDeps : notnull, ONHBOCCBCIC<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct NILDLFLHNEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> MNGKOPDMHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> AAGNELGILFJ;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xEAD240", Offset = "0xEAB840", VA = "0x180EAD240")]
	public NILDLFLHNEH(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> GOCCOADPFEF, AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> LHHGLEEOIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2B09FA0", Offset = "0x2B085A0", VA = "0x182B09FA0")]
	public static NILDLFLHNEH BPFPEFLIIPC(AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>> GOCCOADPFEF)
	{
		return default(NILDLFLHNEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct CJIGCDILDGH
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class GIJCMMBPFNJ : PHBGKNPBGME
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct EFJPEOFJNGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI> NOENFLDLMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int LBGMECNKHAM;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xEAD240", Offset = "0xEAB840", VA = "0x180EAD240")]
		public EFJPEOFJNGI(AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI> MOEJFADHKLO, int LEPAEEGOBDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class OMICFGBIFCN : PHBGKNPBGME
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct LADOGDPHMAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int LBGMECNKHAM;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		public LADOGDPHMAN(int LEPAEEGOBDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class IFLKBBHEELL : PHBGKNPBGME
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct OHCHGJGOFCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI> NOENFLDLMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int LBGMECNKHAM;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xEAD240", Offset = "0xEAB840", VA = "0x180EAD240")]
		public OHCHGJGOFCH(AEOJKNGHIFP<BOPBLJANNLN.EFEAFGKBPDI> MOEJFADHKLO, int LEPAEEGOBDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum NIPJDIOOMCO
	{
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class GFIHEIBNOCL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class PHBGKNPBGME
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct EGAOFKODDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? MMLKPGGFDAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NILDLFLHNEH OKOKINGGHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public NIPJDIOOMCO AGECILLPLJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AEOJKNGHIFP<PHBGKNPBGME> GNHAELGMLIL;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B05B30", Offset = "0x2B04130", VA = "0x182B05B30")]
		public EGAOFKODDOK(int? ECMCGKKPNLC, [In] NILDLFLHNEH IFEKGJCGPKN, NIPJDIOOMCO ENFAOJCOHIL, AEOJKNGHIFP<PHBGKNPBGME> BCGFPONHJPI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class CFLILKOLGPP : PHBGKNPBGME
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct PKLHGPILKAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int LBGMECNKHAM;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1574730", Offset = "0x1572D30", VA = "0x181574730")]
		public PKLHGPILKAP(int LEPAEEGOBDO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal CGFJLBHNKOO<GFIHEIBNOCL, EGAOFKODDOK> BJEKGDPOFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal CGFJLBHNKOO<GIJCMMBPFNJ, EFJPEOFJNGI> CPPOABEJIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal CGFJLBHNKOO<IFLKBBHEELL, OHCHGJGOFCH> OBLLMIPDNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal CGFJLBHNKOO<CFLILKOLGPP, PKLHGPILKAP> AFMNDGFAMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal CGFJLBHNKOO<OMICFGBIFCN, LADOGDPHMAN> JAGCJIKAEEF;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2B049A0", Offset = "0x2B02FA0", VA = "0x182B049A0")]
	private CJIGCDILDGH([In] CGFJLBHNKOO<GFIHEIBNOCL, EGAOFKODDOK> OIBPGNPICBF, [In] CGFJLBHNKOO<GIJCMMBPFNJ, EFJPEOFJNGI> BGDBNLDKAMF, [In] CGFJLBHNKOO<IFLKBBHEELL, OHCHGJGOFCH> JJINGCGEFPB, [In] CGFJLBHNKOO<CFLILKOLGPP, PKLHGPILKAP> DFEHBAMGMKE, [In] CGFJLBHNKOO<OMICFGBIFCN, LADOGDPHMAN> FFCILONKHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2B047B0", Offset = "0x2B02DB0", VA = "0x182B047B0")]
	public static CJIGCDILDGH BPFPEFLIIPC()
	{
		return default(CJIGCDILDGH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class FLLDKJAPOKO
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2B06020", Offset = "0x2B04620", VA = "0x182B06020")]
	public static void LOMEBHIDOPA(this CJIGCDILDGH CCKLBDLJPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class KFLGHHGELLG
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2B07480", Offset = "0x2B05A80", VA = "0x182B07480")]
	public static void FIJDFIALNIE(DLKFHPFLKEE CCKLBDLJPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct BBPHGJHDMHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, ILJDLLEELLP> GNMEIFLIKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int IFCGBGLBKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int AMLCPDHLHIP;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEF80", Offset = "0x2AFD580", VA = "0x182AFEF80")]
	private BBPHGJHDMHK([In] PANIMMICCLI<BOPBLJANNLN.KAFKEDIGNEI, ILJDLLEELLP> IJHOMGBBFHN, int OKIKMPEDGLG, int PLNCLCNDBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2AFED40", Offset = "0x2AFD340", VA = "0x182AFED40")]
	public static BBPHGJHDMHK BPFPEFLIIPC()
	{
		return default(BBPHGJHDMHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2AFEDB0", Offset = "0x2AFD3B0", VA = "0x182AFEDB0")]
	public void LOMEBHIDOPA([In] DLKFHPFLKEE KOPCCOFFNGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B0B330", Offset = "0x3B09930", VA = "0x183B0B330")]
	public static void FIJDFIALNIE<TDeps, TStateSys>(DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TStateSys AOGGHDKINFI, AEOJKNGHIFP<CHKBMGKDOKI> PJHNKIKCAOJ) where TDeps : notnull, ONHBOCCBCIC<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KOOGKPILBCB
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2B07730", Offset = "0x2B05D30", VA = "0x182B07730")]
	public static void FIJDFIALNIE(DLKFHPFLKEE CCKLBDLJPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct HJFFLJAFKKH
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface ALHGGKDDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DPCAEHMDCDP(OEFGLPCMBJB<byte> GFEJIGLOEOE, int NMKNLILLJJH);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct MKOBHDGCAHJ : ALHGGKDDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2B09E70", Offset = "0x2B08470", VA = "0x182B09E70", Slot = "4")]
		public void DPCAEHMDCDP(OEFGLPCMBJB<byte> GFEJIGLOEOE, int NMKNLILLJJH)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct BIFFLHPPONN : ALHGGKDDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2AFF060", Offset = "0x2AFD660", VA = "0x182AFF060", Slot = "4")]
		public void DPCAEHMDCDP(OEFGLPCMBJB<byte> GFEJIGLOEOE, int NMKNLILLJJH)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct HOAMMNILOHI : ALHGGKDDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2B06400", Offset = "0x2B04A00", VA = "0x182B06400", Slot = "4")]
		public void DPCAEHMDCDP(OEFGLPCMBJB<byte> GFEJIGLOEOE, int NMKNLILLJJH)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct BICOBEBMGBH : ALHGGKDDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2AFEFC0", Offset = "0x2AFD5C0", VA = "0x182AFEFC0", Slot = "4")]
		public void DPCAEHMDCDP(OEFGLPCMBJB<byte> GFEJIGLOEOE, int NMKNLILLJJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class DCGDBOLNNDE<TCallProcessorDeps> where TCallProcessorDeps : struct, ALHGGKDDGAF
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps LLKOIFELBCH;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4218F40", Offset = "0x4217540", VA = "0x184218F40")]
		public static int FIJDFIALNIE<TDeps, TStateSys>(TDeps AIJNNPIBFLN, TStateSys BJGEPEKIJPC, DLKFHPFLKEE KOPCCOFFNGJ, [In] OEFGLPCMBJB<byte> KCCCIJKLCMA, int MLNMINDHPEJ) where TDeps : ONHBOCCBCIC<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private OEFGLPCMBJB<HBFIGJJPOHE> NJFGPLMKDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>> BKJKPGJFMPJ;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2B063C0", Offset = "0x2B049C0", VA = "0x182B063C0")]
	private HJFFLJAFKKH([In] OEFGLPCMBJB<HBFIGJJPOHE> BAJGFKAJJCN, Dictionary<AEOJKNGHIFP<LBEDHGCJEFE<JPAECFFFFJC>>, AEOJKNGHIFP<BOPBLJANNLN.KAFKEDIGNEI>> PLNABIOGCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2B062C0", Offset = "0x2B048C0", VA = "0x182B062C0")]
	public static HJFFLJAFKKH BPFPEFLIIPC()
	{
		return default(HJFFLJAFKKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2B06380", Offset = "0x2B04980", VA = "0x182B06380")]
	public void LOMEBHIDOPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3DDBF40", Offset = "0x3DDA540", VA = "0x183DDBF40")]
	public static void FIJDFIALNIE<TDeps, TStateSys>(DLKFHPFLKEE CCKLBDLJPNG, TDeps AIJNNPIBFLN, TStateSys AOGGHDKINFI) where TDeps : ONHBOCCBCIC<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class JIAJLEBPCNN
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct IHKJBJHNGNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> HLOEIAGAHGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int NKMOPJNJGBF;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int IIGECMAAGMJ;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int OBFKHMGDAJC;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2B068B0", Offset = "0x2B04EB0", VA = "0x182B068B0")]
	public static void FIJDFIALNIE(DLKFHPFLKEE CCKLBDLJPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2B07090", Offset = "0x2B05690", VA = "0x182B07090")]
	private static void NEOOGBFJLPC([In] DLKFHPFLKEE CCKLBDLJPNG, AEOJKNGHIFP<CJIGCDILDGH.GFIHEIBNOCL> JIEJOKBHEMF, OEFGLPCMBJB<byte> AGBDGEAJIDN, List<IHKJBJHNGNM> LPANBNJCLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2B06F50", Offset = "0x2B05550", VA = "0x182B06F50")]
	private static void NEOOGBFJLPC(OEFGLPCMBJB<byte> AGBDGEAJIDN, int MLMBLBFOLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2B06E20", Offset = "0x2B05420", VA = "0x182B06E20")]
	private static void ICOBGMBGEOC(DLKFHPFLKEE CCKLBDLJPNG, List<IHKJBJHNGNM> LPANBNJCLDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class EBILIJLOCEI<TDeps, TIndex, TValues> where TDeps : struct, CGAJDODHFBM<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps LLKOIFELBCH;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4A49500", Offset = "0x4A47B00", VA = "0x184A49500")]
	public static void FIJDFIALNIE([In] OEFGLPCMBJB<HBFIGJJPOHE> BAJGFKAJJCN, int CJCIFJMAEKH, TValues DMJEPOICLBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface CGAJDODHFBM<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OEFGLPCMBJB<TIndex> OJJLPBKBLAD(int CJCIFJMAEKH, [In] TValues DMJEPOICLBJ);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(TIndex LEPAEEGOBDO, [In] TValues DMJEPOICLBJ);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAOBOIANKEH(TIndex LEPAEEGOBDO, TValues DMJEPOICLBJ, AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> FKMNCAKIOFK);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface KNEIAEKMLLH<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex KOOLDNOCIKH(int LEPAEEGOBDO);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PGPHINEGHMM(TIndex LEPAEEGOBDO, [In] TValues DMJEPOICLBJ);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AEOJKNGHIFP<LBEDHGCJEFE<EAKMKPIPACI>> LBOKJDCHKDL(TIndex LEPAEEGOBDO, [In] TValues DMJEPOICLBJ);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class FLPEDNFOADO<TDeps, TIndex, TValues> where TDeps : struct, KNEIAEKMLLH<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps LLKOIFELBCH;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4F4C120", Offset = "0x4F4A720", VA = "0x184F4C120")]
	public static OEFGLPCMBJB<TIndex> FIJDFIALNIE(int CJCIFJMAEKH, [In] TValues DMJEPOICLBJ)
	{
		return default(OEFGLPCMBJB<TIndex>);
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
