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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5960", Offset = "0x1FA4560", VA = "0x181FA5960")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct ICOKPKEJJLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> FIJOPJIGAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int OPIIJFJCLEC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC225C0", Offset = "0xC211C0", VA = "0x180C225C0")]
	public ICOKPKEJJLH(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> KOINAPBFLMG, int MANKJHLJMBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KKAILNBNLCI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class KBPNGECFHNB : NKCPKPKJCJH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct IGIINEKIOLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly DNNDMHLOCGD<byte> JCGHCBOKHDH;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F4B0D0", Offset = "0x1F49CD0", VA = "0x181F4B0D0")]
		public IGIINEKIOLN(DNNDMHLOCGD<byte> HNGDLLNOPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C5F0", Offset = "0x1F9B1F0", VA = "0x181F9C5F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class EGFABDFINAI : NKCPKPKJCJH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct CDBENHHCLIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> BCPFCMIPENG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
		public CDBENHHCLIC(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> MFJMPDDAEKI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum CMDGOMBJILD
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
	public sealed class NDFIAAOBEDN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class NKCPKPKJCJH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct LHNKJIOEJNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly CMDGOMBJILD PKHNFADCBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly DCECDLKENED<NKCPKPKJCJH> GOOHAHDMAFF;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC225C0", Offset = "0xC211C0", VA = "0x180C225C0")]
		public LHNKJIOEJNO(CMDGOMBJILD NCNPANCIGOF, DCECDLKENED<NKCPKPKJCJH> PCOEEOOBGKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class FEFAECOKFAE : NKCPKPKJCJH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct DJPEPPEOIAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> LNHIJGJMOPP;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
		public DJPEPPEOIAO(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> ODCFMIOIDNL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class DFJCBKNGIIK : NKCPKPKJCJH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct OMEDOKGDIOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly IOAFEKLHBKI POKDJNKDNNB;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
		public OMEDOKGDIOF(IOAFEKLHBKI HNCEOLGKCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5C50", Offset = "0x1FA4850", VA = "0x181FA5C50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal ECMLKLNNOHI<NDFIAAOBEDN, LHNKJIOEJNO> MBKNFAHMAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal ECMLKLNNOHI<KBPNGECFHNB, IGIINEKIOLN> PBHBGMGENBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal ECMLKLNNOHI<EGFABDFINAI, CDBENHHCLIC> CGICNPHLPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal ECMLKLNNOHI<FEFAECOKFAE, DJPEPPEOIAO> LLBJNOGAPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal ECMLKLNNOHI<DFJCBKNGIIK, OMEDOKGDIOF> OFMEMNEEAII;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FA53B0", Offset = "0x1FA3FB0", VA = "0x181FA53B0")]
	private KKAILNBNLCI([In] ECMLKLNNOHI<NDFIAAOBEDN, LHNKJIOEJNO> EBMPOFEBENL, [In] ECMLKLNNOHI<KBPNGECFHNB, IGIINEKIOLN> FGNILKJOCNC, [In] ECMLKLNNOHI<EGFABDFINAI, CDBENHHCLIC> EPNLBNMBKHD, [In] ECMLKLNNOHI<FEFAECOKFAE, DJPEPPEOIAO> CDBFKMKOBMA, [In] ECMLKLNNOHI<DFJCBKNGIIK, OMEDOKGDIOF> JNLGMEPLGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5270", Offset = "0x1FA3E70", VA = "0x181FA5270")]
	public static KKAILNBNLCI PPOPBMPFEOP()
	{
		return default(KKAILNBNLCI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NOGAJMCCBJC
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5800", Offset = "0x1FA4400", VA = "0x181FA5800")]
	public static void IICIADDLCDE(this KKAILNBNLCI HNFMOHFACKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum OKHEBJABHLG
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
public struct JPOEJJJPIMO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class FOGICKMFHIM : BJLPEAJDFAM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct LPGOEMFPAFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> OOCHKKAAJGP;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
		public LPGOEMFPAFP(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> JLJKHDIPICA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum PBHGOANHINM
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
	public sealed class EKJEGBPPBHO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class BJLPEAJDFAM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct BNLPBMLFPFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly PBHGOANHINM PKHNFADCBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly DCECDLKENED<BJLPEAJDFAM> GOOHAHDMAFF;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC225C0", Offset = "0xC211C0", VA = "0x180C225C0")]
		public BNLPBMLFPFG(PBHGOANHINM NCNPANCIGOF, DCECDLKENED<BJLPEAJDFAM> PCOEEOOBGKG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal ECMLKLNNOHI<EKJEGBPPBHO, BNLPBMLFPFG> MBKNFAHMAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal ECMLKLNNOHI<FOGICKMFHIM, LPGOEMFPAFP> MGJBLCEALOL;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B220", Offset = "0x1F99E20", VA = "0x181F9B220")]
	private JPOEJJJPIMO([In] ECMLKLNNOHI<EKJEGBPPBHO, BNLPBMLFPFG> EBMPOFEBENL, [In] ECMLKLNNOHI<FOGICKMFHIM, LPGOEMFPAFP> LNPPGMEINDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1CA0", Offset = "0x1FA08A0", VA = "0x181FA1CA0")]
	public static JPOEJJJPIMO PPOPBMPFEOP()
	{
		return default(JPOEJJJPIMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class EOOMBHNEJPM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BBA0", Offset = "0x1F9A7A0", VA = "0x181F9BBA0")]
	public static void IICIADDLCDE(this JPOEJJJPIMO HNFMOHFACKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FBMNPCDHMOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public BDDFKGHGNDI<int> APFIMJFGJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public BDDFKGHGNDI<int> NAMCEFHADKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int GALDMAMMIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int DHPDAFIAGBO;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BCA0", Offset = "0x1F9A8A0", VA = "0x181F9BCA0")]
	private FBMNPCDHMOJ([In] BDDFKGHGNDI<int> FLHGLCDIIOH, [In] BDDFKGHGNDI<int> BHCFAIMOEON, int JHLKCNBLLPC, int IPBOGAPOFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BC00", Offset = "0x1F9A800", VA = "0x181F9BC00")]
	public static FBMNPCDHMOJ PPOPBMPFEOP()
	{
		return default(FBMNPCDHMOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class JDMJIMHHAIH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C660", Offset = "0x1F9B260", VA = "0x181F9C660")]
	public static void IICIADDLCDE(this FBMNPCDHMOJ HNFMOHFACKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EOBLGINOGOH
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum CJEFPAGOBEG
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class BGEALILDIDB : HPMHBEBLMKG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct GOIPDMLDPLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly DCECDLKENED<JAPHFDCNDFO> FNCNEOJEGPJ;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
		public GOIPDMLDPLP(DCECDLKENED<JAPHFDCNDFO> FJCDDILGHCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class LBALBBHBEKN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class HPMHBEBLMKG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct AFALIAKEPHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly CJEFPAGOBEG PKHNFADCBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly DCECDLKENED<HPMHBEBLMKG> GOOHAHDMAFF;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC225C0", Offset = "0xC211C0", VA = "0x180C225C0")]
		private AFALIAKEPHH(CJEFPAGOBEG NCNPANCIGOF, DCECDLKENED<HPMHBEBLMKG> PCOEEOOBGKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AD30", Offset = "0x1F99930", VA = "0x181F9AD30")]
		public static AFALIAKEPHH PPOPBMPFEOP(CJEFPAGOBEG NCNPANCIGOF, DCECDLKENED<HPMHBEBLMKG> PCOEEOOBGKG)
		{
			return default(AFALIAKEPHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class LMMJBHKHHHI : HPMHBEBLMKG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct IOKNMNONGEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly DCECDLKENED<JAPHFDCNDFO> FNCNEOJEGPJ;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
		public IOKNMNONGEM(DCECDLKENED<JAPHFDCNDFO> FJCDDILGHCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class JAPHFDCNDFO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct CEPGJFDIBNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public BDDFKGHGNDI<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> JDMCFOPNGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public BDDFKGHGNDI<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> EICOKBBOKHF;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B220", Offset = "0x1F99E20", VA = "0x181F9B220")]
		private CEPGJFDIBNI([In] BDDFKGHGNDI<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> APOINAMEDEL, [In] BDDFKGHGNDI<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> CDAJHNALKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B1A0", Offset = "0x1F99DA0", VA = "0x181F9B1A0")]
		public static CEPGJFDIBNI PPOPBMPFEOP()
		{
			return default(CEPGJFDIBNI);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal ECMLKLNNOHI<LBALBBHBEKN, AFALIAKEPHH> MBKNFAHMAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal ECMLKLNNOHI<LMMJBHKHHHI, IOKNMNONGEM> CIINAAMGBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal ECMLKLNNOHI<BGEALILDIDB, GOIPDMLDPLP> GGLPNCJFOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal BDDFKGHGNDI<(DCECDLKENED<LBALBBHBEKN> CallId, DCECDLKENED<JAPHFDCNDFO> IOId)> MBDLLEFMOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal ECMLKLNNOHI<JAPHFDCNDFO, CEPGJFDIBNI> HPAMOGHBNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal GFJNJNMLLEF<JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>> HBJFELGBEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal GFJNJNMLLEF<JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>> DKMEDFCHIDA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1F9BAE0", Offset = "0x1F9A6E0", VA = "0x181F9BAE0")]
	private EOBLGINOGOH([In] ECMLKLNNOHI<LBALBBHBEKN, AFALIAKEPHH> EBMPOFEBENL, [In] ECMLKLNNOHI<LMMJBHKHHHI, IOKNMNONGEM> HJEJCNLHKPG, [In] ECMLKLNNOHI<BGEALILDIDB, GOIPDMLDPLP> DEENKAPFJGB, [In] BDDFKGHGNDI<(DCECDLKENED<LBALBBHBEKN> CallId, DCECDLKENED<JAPHFDCNDFO> IOId)> BNDPFGBEMAO, [In] ECMLKLNNOHI<JAPHFDCNDFO, CEPGJFDIBNI> BCHOKNDAHPO, [In] GFJNJNMLLEF<JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>> NJEABGAGNBO, [In] GFJNJNMLLEF<JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>> GJOEGHNIMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B940", Offset = "0x1F9A540", VA = "0x181F9B940")]
	public static EOBLGINOGOH PPOPBMPFEOP()
	{
		return default(EOBLGINOGOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class MONJAKOPDHG
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1FA57A0", Offset = "0x1FA43A0", VA = "0x181FA57A0")]
	private static void IICIADDLCDE(this EOBLGINOGOH.CEPGJFDIBNI HNFMOHFACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5590", Offset = "0x1FA4190", VA = "0x181FA5590")]
	public static void IICIADDLCDE(this EOBLGINOGOH HNFMOHFACKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct KBGCIDDEAME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public BDDFKGHGNDI<byte> EDMNPPMFFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal EOBLGINOGOH PCMOMIDLEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal JFGFPPBDLML HFFJEPOFEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> APHBNBPAIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal KKAILNBNLCI EBLEKPMAHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal JPOEJJJPIMO BDAFBDIOFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal GFJNJNMLLEF<PNPFCEGBCNJ, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>?> PINAGDNKIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal BDDFKGHGNDI<DCECDLKENED<PNPFCEGBCNJ>> GOEHNAPNLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?> EOMKPFJDCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> VariableId, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>> ByteCodeWriteLocation)> IJGHOKEAOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> PNBBFKILEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal ENPPPICIJEC JDEJPBLFCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal EDCOKMICLMD PCBGINGMHCC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FA27F0", Offset = "0x1FA13F0", VA = "0x181FA27F0")]
	private KBGCIDDEAME([In] BDDFKGHGNDI<byte> HPBAFMJAEPH, [In] EOBLGINOGOH DEKFMPBINJF, [In] JFGFPPBDLML BHJGIPFFCLG, [In] KKAILNBNLCI DOECBNGMNIF, [In] JPOEJJJPIMO AOEKNGDCAMP, [In] GFJNJNMLLEF<PNPFCEGBCNJ, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>?> AECNOHMLMHN, [In] BDDFKGHGNDI<DCECDLKENED<PNPFCEGBCNJ>> GCAACAOEJIN, [In] GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?> KIALAEMMBBK, [In] BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> VariableId, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>> ByteCodeWriteLocation)> FMGFJPPIIHE, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> HMIOOCBIJNO, [In] ENPPPICIJEC LHFFHIGHLNB, [In] EDCOKMICLMD DIECOKJOHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1D30", Offset = "0x1FA0930", VA = "0x181FA1D30")]
	public static KBGCIDDEAME PPOPBMPFEOP()
	{
		return default(KBGCIDDEAME);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KJLMCGEFDAD
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct CIHNOJGHJCM : KGFFBFFDAJC<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>, GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B270", Offset = "0x1F99E70", VA = "0x181F9B270")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B320", Offset = "0x1F99F20", VA = "0x181F9B320", Slot = "4")]
		public DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> PJINEIIJLFJ(int OPDMGNJCACB)
		{
			return default(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420")]
		public bool HCNLLHKIFPH(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "5")]
		private bool PJIDDMHJNEG(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B260", Offset = "0x1F99E60", VA = "0x181F9B260", Slot = "6")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> IMDAFOIAOML(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct PMLPBOMHLCK : GIHGEDGNEHJ<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>, GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5D60", Offset = "0x1FA4960", VA = "0x181FA5D60")]
		public BDDFKGHGNDI<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>> KMFONHHAIMG(int AENEIBEBGLJ, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5EA0", Offset = "0x1FA4AA0", VA = "0x181FA5EA0")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5DE0", Offset = "0x1FA49E0", VA = "0x181FA5DE0", Slot = "6")]
		public void EBHAFLMAHAE(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>> DJGHJNNEKKN, DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5D60", Offset = "0x1FA4960", VA = "0x181FA5D60", Slot = "4")]
		private BDDFKGHGNDI<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>> DAOGALLCJAO(int AENEIBEBGLJ, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5DD0", Offset = "0x1FA49D0", VA = "0x181FA5DD0", Slot = "5")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> DNIANIJEEPJ(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct OPCPAPIBDDA : KGFFBFFDAJC<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>, GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5C80", Offset = "0x1FA4880", VA = "0x181FA5C80")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5D30", Offset = "0x1FA4930", VA = "0x181FA5D30", Slot = "4")]
		public DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> PJINEIIJLFJ(int OPDMGNJCACB)
		{
			return default(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420")]
		public bool HCNLLHKIFPH(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "5")]
		private bool KKBIGKENDOP(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5C70", Offset = "0x1FA4870", VA = "0x181FA5C70", Slot = "6")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> AJONDGNCFGA(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct OKHMECIGLAB : GIHGEDGNEHJ<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>, GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5B30", Offset = "0x1FA4730", VA = "0x181FA5B30")]
		public BDDFKGHGNDI<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>> KMFONHHAIMG(int AENEIBEBGLJ, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5BA0", Offset = "0x1FA47A0", VA = "0x181FA5BA0")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5A70", Offset = "0x1FA4670", VA = "0x181FA5A70", Slot = "6")]
		public void EBHAFLMAHAE(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>> DJGHJNNEKKN, DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5B30", Offset = "0x1FA4730", VA = "0x181FA5B30", Slot = "4")]
		private BDDFKGHGNDI<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>> MDMCLDAFEOF(int AENEIBEBGLJ, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5A60", Offset = "0x1FA4660", VA = "0x181FA5A60", Slot = "5")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> ALDENABLDPJ(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> OPDMGNJCACB, [In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct FKGAPJCPNFJ : KGFFBFFDAJC<DCECDLKENED<IMCNFENPJKF>, GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BE40", Offset = "0x1F9AA40", VA = "0x181F9BE40")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(DCECDLKENED<IMCNFENPJKF> OPDMGNJCACB, [In] GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BF10", Offset = "0x1F9AB10", VA = "0x181F9BF10", Slot = "4")]
		public DCECDLKENED<IMCNFENPJKF> PJINEIIJLFJ(int OPDMGNJCACB)
		{
			return default(DCECDLKENED<IMCNFENPJKF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BDB0", Offset = "0x1F9A9B0", VA = "0x181F9BDB0")]
		public bool HCNLLHKIFPH(DCECDLKENED<IMCNFENPJKF> OPDMGNJCACB, [In] GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BDB0", Offset = "0x1F9A9B0", VA = "0x181F9BDB0", Slot = "5")]
		private bool CMBICJBLIBK(DCECDLKENED<IMCNFENPJKF> OPDMGNJCACB, [In] GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BE30", Offset = "0x1F9AA30", VA = "0x181F9BE30", Slot = "6")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> EMBMFMHIBPE(DCECDLKENED<IMCNFENPJKF> OPDMGNJCACB, [In] GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct CDNGEFFHNDI : GIHGEDGNEHJ<DCECDLKENED<IMCNFENPJKF>, GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AE30", Offset = "0x1F99A30", VA = "0x181F9AE30")]
		public BDDFKGHGNDI<DCECDLKENED<IMCNFENPJKF>> KMFONHHAIMG(int AENEIBEBGLJ, [In] GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<DCECDLKENED<IMCNFENPJKF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AEB0", Offset = "0x1F99AB0", VA = "0x181F9AEB0")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(DCECDLKENED<IMCNFENPJKF> OPDMGNJCACB, [In] GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AD50", Offset = "0x1F99950", VA = "0x181F9AD50", Slot = "6")]
		public void EBHAFLMAHAE(DCECDLKENED<IMCNFENPJKF> OPDMGNJCACB, GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?> DJGHJNNEKKN, DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AE30", Offset = "0x1F99A30", VA = "0x181F9AE30", Slot = "4")]
		private BDDFKGHGNDI<DCECDLKENED<IMCNFENPJKF>> MLAECIKLOGN(int AENEIBEBGLJ, [In] GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<DCECDLKENED<IMCNFENPJKF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AEA0", Offset = "0x1F99AA0", VA = "0x181F9AEA0", Slot = "5")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> LJBLPFIIEIJ(DCECDLKENED<IMCNFENPJKF> OPDMGNJCACB, [In] GFJNJNMLLEF<IMCNFENPJKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>?> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct FIPGPDBPAOA : KGFFBFFDAJC<int, BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BD00", Offset = "0x1F9A900", VA = "0x181F9BD00")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> VariableId, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1375930", Offset = "0x1374530", VA = "0x181375930", Slot = "4")]
		public int PJINEIIJLFJ(int OPDMGNJCACB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420")]
		public bool HCNLLHKIFPH(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> VariableId, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "5")]
		private bool BFNLCPPAKEF(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> VariableId, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BDA0", Offset = "0x1F9A9A0", VA = "0x181F9BDA0", Slot = "6")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> NCAFNLPHNIM(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> VariableId, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct GALHHCBFOOM : GIHGEDGNEHJ<int, BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C050", Offset = "0x1F9AC50", VA = "0x181F9C050")]
		public BDDFKGHGNDI<int> KMFONHHAIMG(int AENEIBEBGLJ, [In] BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> VariableId, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C0C0", Offset = "0x1F9ACC0", VA = "0x181F9C0C0")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> VariableId, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BF50", Offset = "0x1F9AB50", VA = "0x181F9BF50", Slot = "6")]
		public void EBHAFLMAHAE(int OPDMGNJCACB, BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> VariableId, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>> ByteCodeWriteLocation)> DJGHJNNEKKN, DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C050", Offset = "0x1F9AC50", VA = "0x181F9C050", Slot = "4")]
		private BDDFKGHGNDI<int> LIIKBEPLFLC(int AENEIBEBGLJ, [In] BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> VariableId, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1F9BF40", Offset = "0x1F9AB40", VA = "0x181F9BF40", Slot = "5")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> DPDBDMHHHGM(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> VariableId, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<CEEKBHBAKNH>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct LMMGEPCLOMJ : KGFFBFFDAJC<int, BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1FA54F0", Offset = "0x1FA40F0", VA = "0x181FA54F0")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1375930", Offset = "0x1374530", VA = "0x181375930", Slot = "4")]
		public int PJINEIIJLFJ(int OPDMGNJCACB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420")]
		public bool HCNLLHKIFPH(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "5")]
		private bool AHFJAGJHHDO(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1FA54E0", Offset = "0x1FA40E0", VA = "0x181FA54E0", Slot = "6")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> AEOCOEDGGEI(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct GFGNDNHHIJI : GIHGEDGNEHJ<int, BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C260", Offset = "0x1F9AE60", VA = "0x181F9C260")]
		public BDDFKGHGNDI<int> KMFONHHAIMG(int AENEIBEBGLJ, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C2D0", Offset = "0x1F9AED0", VA = "0x181F9C2D0")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C170", Offset = "0x1F9AD70", VA = "0x181F9C170", Slot = "6")]
		public void EBHAFLMAHAE(int OPDMGNJCACB, BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN, DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C260", Offset = "0x1F9AE60", VA = "0x181F9C260", Slot = "4")]
		private BDDFKGHGNDI<int> EFBFEGONLPK(int AENEIBEBGLJ, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C160", Offset = "0x1F9AD60", VA = "0x181F9C160", Slot = "5")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> DHMCPIICMJF(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct EGMKCFHOJMG : KGFFBFFDAJC<int, BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B600", Offset = "0x1F9A200", VA = "0x181F9B600")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1375930", Offset = "0x1374530", VA = "0x181375930", Slot = "4")]
		public int PJINEIIJLFJ(int OPDMGNJCACB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420")]
		public bool HCNLLHKIFPH(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x85E420", Offset = "0x85D020", VA = "0x18085E420", Slot = "5")]
		private bool AHFJAGJHHDO(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B5F0", Offset = "0x1F9A1F0", VA = "0x181F9B5F0", Slot = "6")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> AEOCOEDGGEI(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct CEBPEEJNFJG : GIHGEDGNEHJ<int, BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B090", Offset = "0x1F99C90", VA = "0x181F9B090")]
		public BDDFKGHGNDI<int> KMFONHHAIMG(int AENEIBEBGLJ, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B100", Offset = "0x1F99D00", VA = "0x181F9B100")]
		public DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AF90", Offset = "0x1F99B90", VA = "0x181F9AF90", Slot = "6")]
		public void EBHAFLMAHAE(int OPDMGNJCACB, BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN, DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> GLMEMJNJKAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B090", Offset = "0x1F99C90", VA = "0x181F9B090", Slot = "4")]
		private BDDFKGHGNDI<int> EFBFEGONLPK(int AENEIBEBGLJ, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(BDDFKGHGNDI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AF80", Offset = "0x1F99B80", VA = "0x181F9AF80", Slot = "5")]
		private DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> DHMCPIICMJF(int OPDMGNJCACB, [In] BDDFKGHGNDI<(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> Target, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> ByteCodeWriteLocation)> DJGHJNNEKKN)
		{
			return default(DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct NNMCPMOPBDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> PCHJNOFCMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool JHOGBJKKCFA;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x10C3AF0", Offset = "0x10C26F0", VA = "0x1810C3AF0")]
		public NNMCPMOPBDN(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC, bool OCOEPNEAMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1FA57F0", Offset = "0x1FA43F0", VA = "0x181FA57F0")]
		public void ALCMIDHBGAI([Out] DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC, [Out] bool OCOEPNEAMFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct JNGMKJEIAOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly DCECDLKENED<IMCNFENPJKF> FCEGNBBCJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> PCHJNOFCMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool JHOGBJKKCFA;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1C90", Offset = "0x1FA0890", VA = "0x181FA1C90")]
		public JNGMKJEIAOP(DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC, bool OCOEPNEAMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1C60", Offset = "0x1FA0860", VA = "0x181FA1C60")]
		public void ALCMIDHBGAI([Out] DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC, [Out] bool OCOEPNEAMFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1FA1C70", Offset = "0x1FA0870", VA = "0x181FA1C70")]
		public void ALCMIDHBGAI([Out] DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC, [Out] DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN, [Out] bool OCOEPNEAMFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct ADHJCNHJKCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly DCECDLKENED<IMCNFENPJKF> FCEGNBBCJCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> PCHJNOFCMGI;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC225C0", Offset = "0xC211C0", VA = "0x180C225C0")]
		public ADHJCNHJKCN(DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1F9AD20", Offset = "0x1F99920", VA = "0x181F9AD20")]
		public void ALCMIDHBGAI([Out] DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC, [Out] DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4260", Offset = "0x1FA2E60", VA = "0x181FA4260")]
	public static void IICIADDLCDE(this KBGCIDDEAME HNFMOHFACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4F80", Offset = "0x1FA3B80", VA = "0x181FA4F80")]
	public static void OMMPHMPECEH(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<PNPFCEGBCNJ> LKMOAAHJAKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> FEMIADPIJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1FA35C0", Offset = "0x1FA21C0", VA = "0x181FA35C0")]
	public static void DDFJLDDCCMH(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<PNPFCEGBCNJ> LKMOAAHJAKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> FEMIADPIJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4AB0", Offset = "0x1FA36B0", VA = "0x181FA4AB0")]
	public static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>? MMODPANIFPD([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<PNPFCEGBCNJ> LKMOAAHJAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2F40", Offset = "0x1FA1B40", VA = "0x181FA2F40")]
	public static DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> APOIJMHIOIO([In] this KBGCIDDEAME HNFMOHFACKF)
	{
		return default(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2C00", Offset = "0x1FA1800", VA = "0x181FA2C00")]
	private static void ACFNAAFEEFC(this KBGCIDDEAME HNFMOHFACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3D10", Offset = "0x1FA2910", VA = "0x181FA3D10")]
	private static DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>? FLNEJBDKIJG([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5010", Offset = "0x1FA3C10", VA = "0x181FA5010")]
	public static void PGDKBKPILEC(this KBGCIDDEAME HNFMOHFACKF, [In] BDDFKGHGNDI<ICOKPKEJJLH> LELCMPOJPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3350", Offset = "0x1FA1F50", VA = "0x181FA3350")]
	public static KKAILNBNLCI.CMDGOMBJILD CLGCPGFECMC([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC)
	{
		return default(KKAILNBNLCI.CMDGOMBJILD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA34D0", Offset = "0x1FA20D0", VA = "0x181FA34D0")]
	public static DNNDMHLOCGD<byte> DAAFOLOFNJI([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC)
	{
		return default(DNNDMHLOCGD<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA49C0", Offset = "0x1FA35C0", VA = "0x181FA49C0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> MJKOEBCAPCL([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3DD0", Offset = "0x1FA29D0", VA = "0x181FA3DD0")]
	public static IOAFEKLHBKI GEHPJFFFHHM([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC)
	{
		return default(IOAFEKLHBKI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE450", Offset = "0x2BCD050", VA = "0x182BCE450")]
	private static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> NALGBJGJDLN<TMJoin>(this KBGCIDDEAME HNFMOHFACKF, KKAILNBNLCI.CMDGOMBJILD NCNPANCIGOF, DCECDLKENED<TMJoin> PCOEEOOBGKG) where TMJoin : KKAILNBNLCI.NKCPKPKJCJH
	{
		return default(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4110", Offset = "0x1FA2D10", VA = "0x181FA4110")]
	public static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> IBAGBMAEBDA(this KBGCIDDEAME HNFMOHFACKF, bool OFBAANLNPEB)
	{
		return default(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3A80", Offset = "0x1FA2680", VA = "0x181FA3A80")]
	public static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> FBODLFHOGJF(this KBGCIDDEAME HNFMOHFACKF, DNNDMHLOCGD<byte> HNGDLLNOPEB)
	{
		return default(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4F00", Offset = "0x1FA3B00", VA = "0x181FA4F00")]
	public static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> OGKILFPHKEE(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> MFJMPDDAEKI)
	{
		return default(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2D70", Offset = "0x1FA1970", VA = "0x181FA2D70")]
	public static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> AIGINNNLGDN(this KBGCIDDEAME HNFMOHFACKF, int HMNPNGMIENE)
	{
		return default(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3720", Offset = "0x1FA2320", VA = "0x181FA3720")]
	public static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> EHPKAANGPEH(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> ODCFMIOIDNL)
	{
		return default(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2BCCB70", Offset = "0x2BCB770", VA = "0x182BCCB70")]
	private static DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO> FBANMHKNDOJ<TMJoin>(this KBGCIDDEAME HNFMOHFACKF, JPOEJJJPIMO.PBHGOANHINM NCNPANCIGOF, DCECDLKENED<TMJoin> PCOEEOOBGKG) where TMJoin : JPOEJJJPIMO.BJLPEAJDFAM
	{
		return default(DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3FA0", Offset = "0x1FA2BA0", VA = "0x181FA3FA0")]
	public static DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO> GPNAHFOIHDK(this KBGCIDDEAME HNFMOHFACKF)
	{
		return default(DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4D50", Offset = "0x1FA3950", VA = "0x181FA4D50")]
	public static DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO> NKKEIGMACEN(this KBGCIDDEAME HNFMOHFACKF)
	{
		return default(DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4940", Offset = "0x1FA3540", VA = "0x181FA4940")]
	public static DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO> LJGINPMFLGF(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> JLJKHDIPICA)
	{
		return default(DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2F00", Offset = "0x1FA1B00", VA = "0x181FA2F00")]
	public static DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO> ANFMBFJBKGK(this KBGCIDDEAME HNFMOHFACKF)
	{
		return default(DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3CD0", Offset = "0x1FA28D0", VA = "0x181FA3CD0")]
	public static DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO> FGCCPFJFEIL(this KBGCIDDEAME HNFMOHFACKF)
	{
		return default(DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4E80", Offset = "0x1FA3A80", VA = "0x181FA4E80")]
	public static EOBLGINOGOH.CJEFPAGOBEG OCPNMELJNNP([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN> JDPFEPEOIBO)
	{
		return default(EOBLGINOGOH.CJEFPAGOBEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2DF0", Offset = "0x1FA19F0", VA = "0x181FA2DF0")]
	public static NBJLPHMBNMH<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>, CLNFAHIDEDF<EOBLGINOGOH.JAPHFDCNDFO>> AILBDMFHDHN([In] this KBGCIDDEAME HNFMOHFACKF)
	{
		return default(NBJLPHMBNMH<DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>, CLNFAHIDEDF<EOBLGINOGOH.JAPHFDCNDFO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4B70", Offset = "0x1FA3770", VA = "0x181FA4B70")]
	public static DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> NFIBHHIOEKH([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN> JDPFEPEOIBO)
	{
		return default(DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4790", Offset = "0x1FA3390", VA = "0x181FA4790")]
	public static EOBLGINOGOH.CEPGJFDIBNI LAFLMBDDANM([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> FJCDDILGHCD)
	{
		return default(EOBLGINOGOH.CEPGJFDIBNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3F20", Offset = "0x1FA2B20", VA = "0x181FA3F20")]
	public static EOBLGINOGOH.CEPGJFDIBNI GLJMLIEAKMC(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> FJCDDILGHCD)
	{
		return default(EOBLGINOGOH.CEPGJFDIBNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2BCDDE0", Offset = "0x2BCC9E0", VA = "0x182BCDDE0")]
	private static DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN> IIGAIGACLDP<TMJoin>(this KBGCIDDEAME HNFMOHFACKF, EOBLGINOGOH.CJEFPAGOBEG NCNPANCIGOF, DCECDLKENED<TMJoin> PCOEEOOBGKG) where TMJoin : EOBLGINOGOH.HPMHBEBLMKG
	{
		return default(DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FA45C0", Offset = "0x1FA31C0", VA = "0x181FA45C0")]
	public static (DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>) KJEIOMPEGDC(this KBGCIDDEAME HNFMOHFACKF)
	{
		return default((DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3B10", Offset = "0x1FA2710", VA = "0x181FA3B10")]
	public static (DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>) FBOOAGKIOLK(this KBGCIDDEAME HNFMOHFACKF)
	{
		return default((DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3FE0", Offset = "0x1FA2BE0", VA = "0x181FA3FE0")]
	public static DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN> HFMPEHGKCKC(this KBGCIDDEAME HNFMOHFACKF)
	{
		return default(DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3690", Offset = "0x1FA2290", VA = "0x181FA3690")]
	public static void DKFMMNHIOJD(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO> FJCDDILGHCD, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> CNGPCHAELDH, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>> OMMLNDAHHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2BCCC20", Offset = "0x2BCB820", VA = "0x182BCCC20")]
	public static NNMCPMOPBDN HEGADGPEOFN<TDeps, TStateSys>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN) where TDeps : HJNKINAPIMH<TStateSys>
	{
		return default(NNMCPMOPBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2BCDA40", Offset = "0x2BCC640", VA = "0x182BCDA40")]
	public static JNGMKJEIAOP HIMDHPNOPNM<TDeps, TStateSys>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<GIGLGMMBICO> KJPMBCBOCOO, int BJIDOJPLAFP) where TDeps : HJNKINAPIMH<TStateSys>
	{
		return default(JNGMKJEIAOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE500", Offset = "0x2BCD100", VA = "0x182BCE500")]
	public static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>? OIICCFNFDBN<TDeps, TStateSys>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<GIGLGMMBICO> KJPMBCBOCOO, [In] ReadOnlySpan<int> CNANNGEBKIN, [In] Span<ADHJCNHJKCN> HKCHEONEGFC) where TDeps : HJNKINAPIMH<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2BCDE80", Offset = "0x2BCCA80", VA = "0x182BCDE80")]
	public static DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO> KLCAPENLENF<TDeps, TStateSys>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<PNPFCEGBCNJ> LKMOAAHJAKF) where TDeps : HJNKINAPIMH<TStateSys>
	{
		return default(DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4020", Offset = "0x1FA2C20", VA = "0x181FA4020")]
	public static JFGFPPBDLML.OMAAGPPDGAM HOIJOLBPFOK([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EPKGPGILADI)
	{
		return default(JFGFPPBDLML.OMAAGPPDGAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA5180", Offset = "0x1FA3D80", VA = "0x181FA5180")]
	public static JFGFPPBDLML.MDOCKMJPOEN PKAADKDEACM([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EPKGPGILADI)
	{
		return default(JFGFPPBDLML.MDOCKMJPOEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3070", Offset = "0x1FA1C70", VA = "0x181FA3070")]
	public static JFGFPPBDLML.FHGAIFKNBML BOHLILBJNEN([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EPKGPGILADI)
	{
		return default(JFGFPPBDLML.FHGAIFKNBML);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1FA37A0", Offset = "0x1FA23A0", VA = "0x181FA37A0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EIAPJDPNALD(this KBGCIDDEAME HNFMOHFACKF, int? GPDACEGMIDJ, string GFLNGGKHEOH)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4D90", Offset = "0x1FA3990", VA = "0x181FA4D90")]
	public static JFGFPPBDLML.CMAJAECEGDE OCFHCLBFEDN([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EPKGPGILADI)
	{
		return default(JFGFPPBDLML.CMAJAECEGDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2E30", Offset = "0x1FA1A30", VA = "0x181FA2E30")]
	public static JFGFPPBDLML.MLKHBDIDHJL AKLHCEFPENO([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EPKGPGILADI)
	{
		return default(JFGFPPBDLML.MLKHBDIDHJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FA33D0", Offset = "0x1FA1FD0", VA = "0x181FA33D0")]
	public static int? CLNGLNMFMCJ([In] this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EPKGPGILADI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2BCDCE0", Offset = "0x2BCC8E0", VA = "0x182BCDCE0")]
	private static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HKMOFFAHFFE<TMJoin>(this KBGCIDDEAME HNFMOHFACKF, int? GPDACEGMIDJ, JFGFPPBDLML.MLKHBDIDHJL NCNPANCIGOF, DCECDLKENED<TMJoin> PCOEEOOBGKG) where TMJoin : JFGFPPBDLML.AGLDPJFPEAF
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FA32A0", Offset = "0x1FA1EA0", VA = "0x181FA32A0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> CIGBBKKHLCC(this KBGCIDDEAME HNFMOHFACKF, int? GPDACEGMIDJ, DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN> JDPFEPEOIBO, int OPDMGNJCACB)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3EC0", Offset = "0x1FA2AC0", VA = "0x181FA3EC0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GLBEKLECIPL(this KBGCIDDEAME HNFMOHFACKF, int? GPDACEGMIDJ)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3930", Offset = "0x1FA2530", VA = "0x181FA3930")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EJFFOHCKLMB(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>? KOELKEAPBNP, int? GPDACEGMIDJ)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3440", Offset = "0x1FA2040", VA = "0x181FA3440")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> CPKGALOBFBJ(this KBGCIDDEAME HNFMOHFACKF, int? GPDACEGMIDJ, int OPDMGNJCACB)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2EA0", Offset = "0x1FA1AA0", VA = "0x181FA2EA0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> ANDMAJONNBM(this KBGCIDDEAME HNFMOHFACKF, int? GPDACEGMIDJ)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FA3160", Offset = "0x1FA1D60", VA = "0x181FA3160")]
	public static void CHFNPPFKNBI(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> ODCFMIOIDNL, DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN> JDPFEPEOIBO, int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4810", Offset = "0x1FA3410", VA = "0x181FA4810")]
	public static void LGAPHMMHNMF(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> ODCFMIOIDNL, int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FA2FA0", Offset = "0x1FA1BA0", VA = "0x181FA2FA0")]
	public static void BKIMNHMACFK(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> ODCFMIOIDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4530", Offset = "0x1FA3130", VA = "0x181FA4530")]
	public static void IJJCIAOIHBB(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> PJIFCLGMLOL, DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> EJLBPEELBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FA4190", Offset = "0x1FA2D90", VA = "0x181FA4190")]
	public static void IGNPFDMLKGI(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> ODCFMIOIDNL, DCECDLKENED<AADDKPGCELF<PFEFPKNAADD>> NBKJILOHCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2BCE940", Offset = "0x2BCD540", VA = "0x182BCE940")]
	public static void OJOHPCENFDF<M>(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> ODCFMIOIDNL, DCECDLKENED<AADDKPGCELF<HBEBPHNMJKB<M>>> NBKJILOHCOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HJNKINAPIMH<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DCECDLKENED<HHAKONKLIPE> HMDLMPAFEAO(TStateSys MHJDBEKJELG);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DCECDLKENED<HHAKONKLIPE> MOBJODKKEDH(TStateSys MHJDBEKJELG);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DCECDLKENED<HHAKONKLIPE> BANHHADPNDO(TStateSys MHJDBEKJELG);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DCECDLKENED<HHAKONKLIPE> OCDIKILLPDP(TStateSys MHJDBEKJELG);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO> OHOLPIFLJGP(TStateSys MHJDBEKJELG, KBGCIDDEAME KOKNNEAOJPH, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> IENIKKMILMD(TStateSys MHJDBEKJELG, KBGCIDDEAME KOKNNEAOJPH, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<PNPFCEGBCNJ> LKMOAAHJAKF);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EABGFKJKGFB(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DCECDLKENED<PNPFCEGBCNJ> HCFDGBMGOLE(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN, int OEGEHNAFPGM);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OKHEBJABHLG OLHABONHKMG(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PIFDJOJGFBP(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int CILNDCHOAIC(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DNNDMHLOCGD<byte> OPGELLEAAAK(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(DNNDMHLOCGD<byte>, DCECDLKENED<HHAKONKLIPE>) NMIEPFBOGBD(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<IMCNFENPJKF> ALMJBMBCMPN);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int LCBIHBADAPH(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<PNPFCEGBCNJ> LKMOAAHJAKF);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DCECDLKENED<IMCNFENPJKF> HIHEHBIFNKC(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<PNPFCEGBCNJ> LKMOAAHJAKF, int BJIDOJPLAFP);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DCECDLKENED<IMCNFENPJKF> CJOFPHIEKKA(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, DCECDLKENED<GIGLGMMBICO> KJPMBCBOCOO, int BJIDOJPLAFP);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int DKOMJLJEKKP(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? LCAGKBOJKBP(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, int OPDMGNJCACB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int HFGLMOAGMNO(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? ODCCOFMKIAH(TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH, int OPDMGNJCACB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class JKFOGBMNCEC
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2B99E80", Offset = "0x2B98A80", VA = "0x182B99E80")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK?> GIBMAJBGAEG<T, TOpInput, TOpOutput>(this KBGCIDDEAME HNFMOHFACKF, T HLHDFJDLHFM, T GIHDHONABPM, int ADENHCDDILE, IntPtr DFHGMPBBALO)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2B99AE0", Offset = "0x2B986E0", VA = "0x182B99AE0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK?> GAFPAGCLJGB<T, TOpInput, TOpOutput>(this KBGCIDDEAME HNFMOHFACKF, T HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM, int ADENHCDDILE, IntPtr DFHGMPBBALO)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A5E0", Offset = "0x2B991E0", VA = "0x182B9A5E0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK?> JGHGOJGLMBL<TOpInput, TOpOutput>(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM, int ADENHCDDILE, IntPtr DFHGMPBBALO)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DEA0", Offset = "0x1F9CAA0", VA = "0x181F9DEA0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EINMEINIBEB(this KBGCIDDEAME HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EE00", Offset = "0x1F9DA00", VA = "0x181F9EE00")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HDDKIBAKLLI(this KBGCIDDEAME HNFMOHFACKF, float NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0520", Offset = "0x1F9F120", VA = "0x181FA0520")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> KPCMKAOGDNG(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FA16F0", Offset = "0x1FA02F0", VA = "0x181FA16F0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> OMNDAEHCFFH(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D040", Offset = "0x1F9BC40", VA = "0x181F9D040")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BKBJEBDENNN(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FA15B0", Offset = "0x1FA01B0", VA = "0x181FA15B0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> OICGPFLELGJ(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DCB0", Offset = "0x1F9C8B0", VA = "0x181F9DCB0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EEGGKLPHDKO(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0300", Offset = "0x1F9EF00", VA = "0x181FA0300")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> KJNAKKHMHLO(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D810", Offset = "0x1F9C410", VA = "0x181F9D810")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> DOHMPKLAKDL(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0E40", Offset = "0x1F9FA40", VA = "0x181FA0E40")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> LOHAFAJNBFB(this KBGCIDDEAME HNFMOHFACKF, int HLHDFJDLHFM, int GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0FD0", Offset = "0x1F9FBD0", VA = "0x181FA0FD0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NDKODLBKOAA(this KBGCIDDEAME HNFMOHFACKF, int HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EBC0", Offset = "0x1F9D7C0", VA = "0x181F9EBC0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GGAMDBPNPNJ(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CB10", Offset = "0x1F9B710", VA = "0x181F9CB10")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> AHGECEJEJLF(this KBGCIDDEAME HNFMOHFACKF, float HLHDFJDLHFM, float GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F890", Offset = "0x1F9E490", VA = "0x181F9F890")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> JNDAPCAOHPB(this KBGCIDDEAME HNFMOHFACKF, float HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C9D0", Offset = "0x1F9B5D0", VA = "0x181F9C9D0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> AHEOGOONCOC(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9ED00", Offset = "0x1F9D900", VA = "0x181F9ED00")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GKJMFJLCGDC(this KBGCIDDEAME HNFMOHFACKF, int HLHDFJDLHFM, int GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F710", Offset = "0x1F9E310", VA = "0x181F9F710")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> JIBIJNBMCKM(this KBGCIDDEAME HNFMOHFACKF, int HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D680", Offset = "0x1F9C280", VA = "0x181F9D680")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> DIFEFAFKAGL(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FA08D0", Offset = "0x1F9F4D0", VA = "0x181FA08D0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> LBPODEJDLOO(this KBGCIDDEAME HNFMOHFACKF, float HLHDFJDLHFM, float GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F330", Offset = "0x1F9DF30", VA = "0x181F9F330")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HMNKEOFDEHN(this KBGCIDDEAME HNFMOHFACKF, float HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FA11B0", Offset = "0x1F9FDB0", VA = "0x181FA11B0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NFGAHCJOMFD(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1370", Offset = "0x1F9FF70", VA = "0x181FA1370")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NKJBLEPCLND(this KBGCIDDEAME HNFMOHFACKF, int HLHDFJDLHFM, int GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F690", Offset = "0x1F9E290", VA = "0x181F9F690")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> IJLDFKHBNKF(this KBGCIDDEAME HNFMOHFACKF, int HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F4F0", Offset = "0x1F9E0F0", VA = "0x181F9F4F0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> IFBDEJKOMOD(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1530", Offset = "0x1FA0130", VA = "0x181FA1530")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> OFKJJDLEILI(this KBGCIDDEAME HNFMOHFACKF, float HLHDFJDLHFM, float GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CD00", Offset = "0x1F9B900", VA = "0x181F9CD00")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BAJIELIDONO(this KBGCIDDEAME HNFMOHFACKF, float HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D490", Offset = "0x1F9C090", VA = "0x181F9D490")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> CNDIKGBPOLC(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D950", Offset = "0x1F9C550", VA = "0x181F9D950")]
	public static DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> DPPKFHCJPND(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC)
	{
		return default(DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D600", Offset = "0x1F9C200", VA = "0x181F9D600")]
	public static DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> DCLPPOKDMIA(this KBGCIDDEAME HNFMOHFACKF, int GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0F30", Offset = "0x1F9FB30", VA = "0x181FA0F30")]
	public static DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> MELOCCBBANA(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F040", Offset = "0x1F9DC40", VA = "0x181F9F040")]
	public static DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> HELOBLFBENF(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CPNFBBCMLIC)
	{
		return default(DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E8E0", Offset = "0x1F9D4E0", VA = "0x181F9E8E0")]
	public static DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> FGOCIJEOAMM(this KBGCIDDEAME HNFMOHFACKF, int GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CE80", Offset = "0x1F9BA80", VA = "0x181F9CE80")]
	public static DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> BEBHFFBCKKM(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GLMEMJNJKAN)
	{
		return default(DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E480", Offset = "0x1F9D080", VA = "0x181F9E480")]
	public static (DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>) FBGMLHFDIOP(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFDLLLDCMPM> HPLEBJMADHP, [In] ReadOnlySpan<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> APOINAMEDEL, [In] ReadOnlySpan<int?> NJDGJOBJPMA, [In] Span<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> NIBAMMNNLPI)
	{
		return default((DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F9FD50", Offset = "0x1F9E950", VA = "0x181F9FD50")]
	public static (DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>) KFNCBEIKGPP(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<HJKDMECBPGM> HOMFNKEKDKJ, [In] ReadOnlySpan<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> APOINAMEDEL, [In] ReadOnlySpan<int?> NJDGJOBJPMA, [In] Span<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> NIBAMMNNLPI)
	{
		return default((DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2B9AED0", Offset = "0x2B99AD0", VA = "0x182B9AED0")]
	public static (DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HHAKONKLIPE>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<TMarker>>, DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>) MDNMDPBBPKM<TMarker>(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<HHAKONKLIPE> MLHJPBMNGNB, [In] ReadOnlySpan<byte> IMCLGJBJJKP)
	{
		return default((DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<AADDKPGCELF<HHAKONKLIPE>>, DCECDLKENED<AADDKPGCELF<JDJEBLCOKFJ>>, DCECDLKENED<AADDKPGCELF<TMarker>>, DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1FA10F0", Offset = "0x1F9FCF0", VA = "0x181FA10F0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NEJPMBGMEBC(this KBGCIDDEAME HNFMOHFACKF, int FODGPLAKPJP, [Optional] DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>? PJFHHDPNDJM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D260", Offset = "0x1F9BE60", VA = "0x181F9D260")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> CFHFLJMEIFF(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> FODGPLAKPJP, [Optional] DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>? PJFHHDPNDJM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D510", Offset = "0x1F9C110", VA = "0x181F9D510")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> CPGPCHCNCKP(this KBGCIDDEAME HNFMOHFACKF, [In] ReadOnlySpan<byte> FODGPLAKPJP, [Optional] DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>? PJFHHDPNDJM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EAA0", Offset = "0x1F9D6A0", VA = "0x181F9EAA0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GFGJCMILDLA(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> FODGPLAKPJP, int AEOJMEBJNPD, [Optional] DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>? PJFHHDPNDJM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CD80", Offset = "0x1F9B980", VA = "0x181F9CD80")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BDINNJOMPJP(this KBGCIDDEAME HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CF20", Offset = "0x1F9BB20", VA = "0x181F9CF20")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BFJIGBIGKEJ(this KBGCIDDEAME HNFMOHFACKF, float NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1FA01C0", Offset = "0x1F9EDC0", VA = "0x181FA01C0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> KHFBPAGPGPF(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D170", Offset = "0x1F9BD70", VA = "0x181F9D170")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> CEIAIIEBMNJ(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0D20", Offset = "0x1F9F920", VA = "0x181FA0D20")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> LKIGKHFIIEO(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1FA13F0", Offset = "0x1F9FFF0", VA = "0x181FA13F0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NOONCJMEBMI(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DB00", Offset = "0x1F9C700", VA = "0x181F9DB00")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EBAOAHNDCHN(this KBGCIDDEAME HNFMOHFACKF, int HLHDFJDLHFM, int GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9ED80", Offset = "0x1F9D980", VA = "0x181F9ED80")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GLENKJKEFFI(this KBGCIDDEAME HNFMOHFACKF, int HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0CA0", Offset = "0x1F9F8A0", VA = "0x181FA0CA0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> LILPDMAPNDC(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HLHDFJDLHFM, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GIHDHONABPM)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0420", Offset = "0x1F9F020", VA = "0x181FA0420")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> KPCEODHHECJ(this KBGCIDDEAME HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DB80", Offset = "0x1F9C780", VA = "0x181F9DB80")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EBMBEDELCBB(this KBGCIDDEAME HNFMOHFACKF, float NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E960", Offset = "0x1F9D560", VA = "0x181F9E960")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> FONBGCKPCMM(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E390", Offset = "0x1F9CF90", VA = "0x181F9E390")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> FAFADECPNEO(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1F9EF20", Offset = "0x1F9DB20", VA = "0x181F9EF20")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HDICCOMOHFK(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F3B0", Offset = "0x1F9DFB0", VA = "0x181F9F3B0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> IEIJPMNGEEG(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1C40", Offset = "0x1FA0840", VA = "0x181FA1C40")]
	public static DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>> PMFFIPLNCGL(this KBGCIDDEAME HNFMOHFACKF)
	{
		return default(DCECDLKENED<AADDKPGCELF<AADDKPGCELF<NNEHCMPOKFL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1FA17E0", Offset = "0x1FA03E0", VA = "0x181FA17E0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> PAMDDPHCJFF(this KBGCIDDEAME HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FA18E0", Offset = "0x1FA04E0", VA = "0x181FA18E0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> PEOJCNKJCIL(this KBGCIDDEAME HNFMOHFACKF, float NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D350", Offset = "0x1F9BF50", VA = "0x181F9D350")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> CGAAONJIAJE(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1F9CC10", Offset = "0x1F9B810", VA = "0x181F9CC10")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> AJEDKPPPDJD(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F570", Offset = "0x1F9E170", VA = "0x181F9F570")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> IHIJEHMNEJF(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0660", Offset = "0x1F9F260", VA = "0x181FA0660")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> LBADKFCAIHE(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F790", Offset = "0x1F9E390", VA = "0x181F9F790")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> JKDJGAMIPNE(this KBGCIDDEAME HNFMOHFACKF, int GLMEMJNJKAN)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D700", Offset = "0x1F9C300", VA = "0x181F9D700")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> DJKHKINNGIG(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> GLMEMJNJKAN)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1F9D160", Offset = "0x1F9BD60", VA = "0x181F9D160")]
	public static void CEADFNBAKCJ(this KBGCIDDEAME HNFMOHFACKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DDA0", Offset = "0x1F9C9A0", VA = "0x181F9DDA0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> EFHCKELIKOH(this KBGCIDDEAME HNFMOHFACKF, float NBGKBNFPFCC, float BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0B80", Offset = "0x1F9F780", VA = "0x181FA0B80")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> LDONHMCGJPG(this KBGCIDDEAME HNFMOHFACKF, float NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0A40", Offset = "0x1F9F640", VA = "0x181FA0A40")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> LDMPFHEBGEB(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E2A0", Offset = "0x1F9CEA0", VA = "0x181F9E2A0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> ELALFICGAKI(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1B20", Offset = "0x1FA0720", VA = "0x181FA1B20")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> PLPDGDPPDCJ(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F1F0", Offset = "0x1F9DDF0", VA = "0x181F9F1F0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> HIOJFKOJFAF(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F9C0", Offset = "0x1F9E5C0", VA = "0x181F9F9C0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> JPOBPKHJOMO(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> JOJJPGOIDIC, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> CNKHNBDMNIA)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1FA0950", Offset = "0x1F9F550", VA = "0x181FA0950")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> LCOPPKGGOHJ(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, int BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1A00", Offset = "0x1FA0600", VA = "0x181FA1A00")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> PKHNOCDANFD(this KBGCIDDEAME HNFMOHFACKF, int NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1FA1230", Offset = "0x1F9FE30", VA = "0x181FA1230")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NKICPJODFKF(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> NBGKBNFPFCC, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> BANMHJGBLPC)
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2B992B0", Offset = "0x2B97EB0", VA = "0x182B992B0")]
	public static void AGDMBOHNAIJ<TDeps, TState>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TState GJEHPOMDLIP, DCECDLKENED<JFDLLLDCMPM> HPLEBJMADHP, [In] ReadOnlySpan<DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>> ILGANIPGBCG, [In] ReadOnlySpan<int?> NJDGJOBJPMA, [In] Span<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> NIBAMMNNLPI, [In] Span<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> NEADHGMAOLC, [In] ReadOnlySpan<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>?> ABGLCCJGCJC) where TDeps : notnull, HJNKINAPIMH<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A750", Offset = "0x2B99350", VA = "0x182B9A750")]
	public static void KACGOJNPFJE<TDeps, TState>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TState GJEHPOMDLIP, DCECDLKENED<HJKDMECBPGM> DFEAGIPALPH, [In] ReadOnlySpan<DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>> LBCJIFPGIBA, [In] ReadOnlySpan<int?> NJDGJOBJPMA, [In] Span<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> NIBAMMNNLPI, [In] Span<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>> NEADHGMAOLC, [In] ReadOnlySpan<DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>?> ABGLCCJGCJC) where TDeps : notnull, HJNKINAPIMH<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2B9ACF0", Offset = "0x2B998F0", VA = "0x182B9ACF0")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> LGMADEJMOFN<TDeps, TState>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TState GJEHPOMDLIP, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> KOELKEAPBNP, [Optional] DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>? PJFHHDPNDJM) where TDeps : notnull, HJNKINAPIMH<TState> where TState : notnull
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2B9A180", Offset = "0x2B98D80", VA = "0x182B9A180")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> IBBPIPPEDCK<TDeps, TState>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TState GJEHPOMDLIP, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> JLJKHDIPICA, [Optional] DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>? PJFHHDPNDJM) where TDeps : notnull, HJNKINAPIMH<TState> where TState : notnull
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B1E0", Offset = "0x2B99DE0", VA = "0x182B9B1E0")]
	public static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> MJGFNPMJABE<TDeps, TStateSys>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TStateSys MHJDBEKJELG) where TDeps : notnull, HJNKINAPIMH<TStateSys> where TStateSys : notnull
	{
		return default(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2B9AFD0", Offset = "0x2B99BD0", VA = "0x182B9AFD0")]
	public static DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO> MHOCIGKJCED<TDeps, TStateSys>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TStateSys MHJDBEKJELG) where TDeps : notnull, HJNKINAPIMH<TStateSys> where TStateSys : notnull
	{
		return default(DCECDLKENED<JPOEJJJPIMO.EKJEGBPPBHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1FA07A0", Offset = "0x1F9F3A0", VA = "0x181FA07A0")]
	public static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> LBECFPMDEJP(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> JIPKFDFJNMG, IntPtr GILNGFOHJNA, IntPtr JHAKKOLCJJM)
	{
		return default(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1F9DFA0", Offset = "0x1F9CBA0", VA = "0x181F9DFA0")]
	public static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> EJJHBLDNKDM(this KBGCIDDEAME HNFMOHFACKF, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> ILHBEFIGJLM, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> DFPPJNPOBLE, IntPtr JNKAEOMOKGD, IntPtr IAAKBBDDGEG, IntPtr BJBMIKIOAHH, bool FJGEICDHNMO)
	{
		return default(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B730", Offset = "0x2B9A330", VA = "0x182B9B730")]
	public static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> NNAMBPOFCKI<TDeps, TState>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TState GJEHPOMDLIP, DCECDLKENED<JFDLLLDCMPM> KCGIHIHOOOD, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> ILHBEFIGJLM, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> DFPPJNPOBLE, int? JDDLKOGIOLA, [Optional] IntPtr OFCKCGCCMEP) where TDeps : notnull, HJNKINAPIMH<TState> where TState : notnull
	{
		return default(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2B9B410", Offset = "0x2B9A010", VA = "0x182B9B410")]
	private static DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> NNAMBPOFCKI<TDeps, TState>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TState GJEHPOMDLIP, DCECDLKENED<JFDLLLDCMPM> KCGIHIHOOOD, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> ILHBEFIGJLM, DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN> DFPPJNPOBLE, int? JDDLKOGIOLA) where TDeps : notnull, HJNKINAPIMH<TState> where TState : notnull
	{
		return default(DCECDLKENED<KKAILNBNLCI.NDFIAAOBEDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2B9BE60", Offset = "0x2B9AA60", VA = "0x182B9BE60")]
	public static DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> PIPCJLLMPLN<TDeps, TState>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TState GJEHPOMDLIP, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK> FODGPLAKPJP, DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>? PJFHHDPNDJM) where TDeps : notnull, HJNKINAPIMH<TState> where TState : notnull
	{
		return default(DCECDLKENED<JFGFPPBDLML.EFHAPFNMPNK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2B99850", Offset = "0x2B98450", VA = "0x182B99850")]
	public static void CCOFGKMNLNN<TDeps, TState>(this KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TState GJEHPOMDLIP, int AOBHHFINPNG) where TDeps : notnull, HJNKINAPIMH<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct AJCCFGHBAGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> OOPADNCDNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> NHBDBHAKDKL;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xC225C0", Offset = "0xC211C0", VA = "0x180C225C0")]
	public AJCCFGHBAGO(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> BAOIGCEMOBM, DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> CMAHKBCLPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1F9AD40", Offset = "0x1F99940", VA = "0x181F9AD40")]
	public static AJCCFGHBAGO PPOPBMPFEOP(DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>> BAOIGCEMOBM)
	{
		return default(AJCCFGHBAGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct JFGFPPBDLML
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class DANADOGMACD : AGLDPJFPEAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct OMAAGPPDGAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN> PDJCKEGPGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int HDEPOMLIBHF;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC225C0", Offset = "0xC211C0", VA = "0x180C225C0")]
		public OMAAGPPDGAM(DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN> JDPFEPEOIBO, int OPDMGNJCACB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class BHEDBIIDKPG : AGLDPJFPEAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct MDOCKMJPOEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int HDEPOMLIBHF;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
		public MDOCKMJPOEN(int OPDMGNJCACB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class IOENEGFKEJI : AGLDPJFPEAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct FHGAIFKNBML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN> PDJCKEGPGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int HDEPOMLIBHF;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xC225C0", Offset = "0xC211C0", VA = "0x180C225C0")]
		public FHGAIFKNBML(DCECDLKENED<EOBLGINOGOH.LBALBBHBEKN> JDPFEPEOIBO, int OPDMGNJCACB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum MLKHBDIDHJL
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
	public sealed class EFHAPFNMPNK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class AGLDPJFPEAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct KKCFLBGIMGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? LPBFPAAJJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AJCCFGHBAGO BEALPMDDBNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public MLKHBDIDHJL PKHNFADCBFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public DCECDLKENED<AGLDPJFPEAF> GOOHAHDMAFF;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5440", Offset = "0x1FA4040", VA = "0x181FA5440")]
		public KKCFLBGIMGB(int? GPDACEGMIDJ, [In] AJCCFGHBAGO AALIMHLEPMF, MLKHBDIDHJL NCNPANCIGOF, DCECDLKENED<AGLDPJFPEAF> PCOEEOOBGKG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class EDODOMAJFHA : AGLDPJFPEAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct CMAJAECEGDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int HDEPOMLIBHF;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA63EA0", Offset = "0xA62AA0", VA = "0x180A63EA0")]
		public CMAJAECEGDE(int OPDMGNJCACB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal MKPFJIPKEKC<EFHAPFNMPNK, KKCFLBGIMGB> MBKNFAHMAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal MKPFJIPKEKC<DANADOGMACD, OMAAGPPDGAM> MCNHKAKFNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal MKPFJIPKEKC<IOENEGFKEJI, FHGAIFKNBML> JJMJGNIMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal MKPFJIPKEKC<EDODOMAJFHA, CMAJAECEGDE> FBKMPPBEDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal MKPFJIPKEKC<BHEDBIIDKPG, MDOCKMJPOEN> KAMNKAOLLPO;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C8A0", Offset = "0x1F9B4A0", VA = "0x181F9C8A0")]
	private JFGFPPBDLML([In] MKPFJIPKEKC<EFHAPFNMPNK, KKCFLBGIMGB> EBMPOFEBENL, [In] MKPFJIPKEKC<DANADOGMACD, OMAAGPPDGAM> CEKMFCEOMGH, [In] MKPFJIPKEKC<IOENEGFKEJI, FHGAIFKNBML> KMAFIAIDHGC, [In] MKPFJIPKEKC<EDODOMAJFHA, CMAJAECEGDE> NGCGEHPLJNC, [In] MKPFJIPKEKC<BHEDBIIDKPG, MDOCKMJPOEN> AIAEBGENDML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C6B0", Offset = "0x1F9B2B0", VA = "0x181F9C6B0")]
	public static JFGFPPBDLML PPOPBMPFEOP()
	{
		return default(JFGFPPBDLML);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NPMBOELNHOE
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1FA58B0", Offset = "0x1FA44B0", VA = "0x181FA58B0")]
	public static void IICIADDLCDE(this JFGFPPBDLML HNFMOHFACKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class DBHFNPADEPG
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B350", Offset = "0x1F99F50", VA = "0x181F9B350")]
	public static void JHMLCEABGGF(KBGCIDDEAME HNFMOHFACKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct ENPPPICIJEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, FBMNPCDHMOJ> GOGGDAGAOFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int NJNJPCEGEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int NAKEOPKFGJE;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B900", Offset = "0x1F9A500", VA = "0x181F9B900")]
	private ENPPPICIJEC([In] GFJNJNMLLEF<EOBLGINOGOH.JAPHFDCNDFO, FBMNPCDHMOJ> AFBFDBICGCL, int PBNKAOIPJIB, int LIHOKJJPJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B890", Offset = "0x1F9A490", VA = "0x181F9B890")]
	public static ENPPPICIJEC PPOPBMPFEOP()
	{
		return default(ENPPPICIJEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B6A0", Offset = "0x1F9A2A0", VA = "0x181F9B6A0")]
	public void IICIADDLCDE([In] KBGCIDDEAME CCHBOMPCDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x297F8C0", Offset = "0x297E4C0", VA = "0x18297F8C0")]
	public static void JHMLCEABGGF<TDeps, TStateSys>(KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TStateSys MHJDBEKJELG, DCECDLKENED<AJNNPPKMCNH> DJGLMBCCEPH) where TDeps : notnull, HJNKINAPIMH<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HNMDLGANJBD
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1F9C420", Offset = "0x1F9B020", VA = "0x181F9C420")]
	public static void JHMLCEABGGF(KBGCIDDEAME HNFMOHFACKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct EDCOKMICLMD
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface NDNPNBIKJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DOFHPEFAJOD(BDDFKGHGNDI<byte> HPBAFMJAEPH, int FPLCOFPBFFC);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct OFECGPFBAAG : NDNPNBIKJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1FA59E0", Offset = "0x1FA45E0", VA = "0x181FA59E0", Slot = "4")]
		public void DOFHPEFAJOD(BDDFKGHGNDI<byte> HPBAFMJAEPH, int FPLCOFPBFFC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct KILFNIOFIIK : NDNPNBIKJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1FA2B50", Offset = "0x1FA1750", VA = "0x181FA2B50", Slot = "4")]
		public void DOFHPEFAJOD(BDDFKGHGNDI<byte> HPBAFMJAEPH, int FPLCOFPBFFC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct KLKCPDJGHKA : NDNPNBIKJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1FA5460", Offset = "0x1FA4060", VA = "0x181FA5460", Slot = "4")]
		public void DOFHPEFAJOD(BDDFKGHGNDI<byte> HPBAFMJAEPH, int FPLCOFPBFFC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct HBDKOIAFEND : NDNPNBIKJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1F9C370", Offset = "0x1F9AF70", VA = "0x181F9C370", Slot = "4")]
		public void DOFHPEFAJOD(BDDFKGHGNDI<byte> HPBAFMJAEPH, int FPLCOFPBFFC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class NLNEAHEFIJF<TCallProcessorDeps> where TCallProcessorDeps : struct, NDNPNBIKJPA
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps KJMCLGOJKLB;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x29545C0", Offset = "0x29531C0", VA = "0x1829545C0")]
		public static int JHMLCEABGGF<TDeps, TStateSys>(TDeps CFCALMONEJL, TStateSys GJEHPOMDLIP, KBGCIDDEAME CCHBOMPCDMN, [In] BDDFKGHGNDI<byte> LFFKGPEEPAM, int MOPFGIKDMOL) where TDeps : HJNKINAPIMH<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private BDDFKGHGNDI<ICOKPKEJJLH> HOMJGBFKNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>> NPDAENMHCJA;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B5B0", Offset = "0x1F9A1B0", VA = "0x181F9B5B0")]
	private EDCOKMICLMD([In] BDDFKGHGNDI<ICOKPKEJJLH> LELCMPOJPIG, Dictionary<DCECDLKENED<AADDKPGCELF<NNEHCMPOKFL>>, DCECDLKENED<EOBLGINOGOH.JAPHFDCNDFO>> GHKMJBKKDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B4F0", Offset = "0x1F9A0F0", VA = "0x181F9B4F0")]
	public static EDCOKMICLMD PPOPBMPFEOP()
	{
		return default(EDCOKMICLMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1F9B4B0", Offset = "0x1F9A0B0", VA = "0x181F9B4B0")]
	public void IICIADDLCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2971460", Offset = "0x2970060", VA = "0x182971460")]
	public static void JHMLCEABGGF<TDeps, TStateSys>(KBGCIDDEAME HNFMOHFACKF, TDeps CFCALMONEJL, TStateSys MHJDBEKJELG) where TDeps : HJNKINAPIMH<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class CNILKDCNAFJ<TDeps, TIndex, TValues> where TDeps : struct, GIHGEDGNEHJ<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps KJMCLGOJKLB;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x537E0E0", Offset = "0x537CCE0", VA = "0x18537E0E0")]
	public static void JHMLCEABGGF([In] BDDFKGHGNDI<ICOKPKEJJLH> LELCMPOJPIG, int AENEIBEBGLJ, TValues DJGHJNNEKKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface GIHGEDGNEHJ<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BDDFKGHGNDI<TIndex> KMFONHHAIMG(int AENEIBEBGLJ, [In] TValues DJGHJNNEKKN);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(TIndex OPDMGNJCACB, [In] TValues DJGHJNNEKKN);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBHAFLMAHAE(TIndex OPDMGNJCACB, TValues DJGHJNNEKKN, DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> GLMEMJNJKAN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface KGFFBFFDAJC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex PJINEIIJLFJ(int OPDMGNJCACB);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HCNLLHKIFPH(TIndex OPDMGNJCACB, [In] TValues DJGHJNNEKKN);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DCECDLKENED<AADDKPGCELF<CEEKBHBAKNH>> MMKOPIEMJHJ(TIndex OPDMGNJCACB, [In] TValues DJGHJNNEKKN);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class GCIEOBJGHMD<TDeps, TIndex, TValues> where TDeps : struct, KGFFBFFDAJC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps KJMCLGOJKLB;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3C71D30", Offset = "0x3C70930", VA = "0x183C71D30")]
	public static BDDFKGHGNDI<TIndex> JHMLCEABGGF(int AENEIBEBGLJ, [In] TValues DJGHJNNEKKN)
	{
		return default(BDDFKGHGNDI<TIndex>);
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
