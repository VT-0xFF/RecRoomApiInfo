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
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x252E900", Offset = "0x252DB00", VA = "0x18252E900")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x91E490", Offset = "0x91D690", VA = "0x18091E490")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D6D0", VA = "0x18091E4D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct IMPPHNFEAGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> PJLMPKCCAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int LHEECLLPINN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xBBA4F0", Offset = "0xBB96F0", VA = "0x180BBA4F0")]
	public IMPPHNFEAGB(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> KBEFBKPBFOO, int KLICPJBJAIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EBLPEBOCPEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class MGLOOKOJCBG : ADOCCMFHLOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct IKOHKCLPMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly NNEACHFMOIK<byte> AAGGNGGEHHH;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24C2090", Offset = "0x24C1290", VA = "0x1824C2090")]
		public IKOHKCLPMAM(NNEACHFMOIK<byte> JIGDFCPIKCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x252D350", Offset = "0x252C550", VA = "0x18252D350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class ANJMPLHAAEJ : ADOCCMFHLOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct HGKEOLEHGNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> CBHFMGKLKKF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
		public HGKEOLEHGNJ(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> JBDDPILCOGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum NDBHHKDAGHH
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
	public sealed class GFMONJOAMNN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class ADOCCMFHLOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct AHLCBJLMPBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly NDBHHKDAGHH ODLJPIABCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly ANHNAJIBLBK<ADOCCMFHLOM> LEGJILEPNMH;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBBA4F0", Offset = "0xBB96F0", VA = "0x180BBA4F0")]
		public AHLCBJLMPBN(NDBHHKDAGHH AOGHHHEGBOG, ANHNAJIBLBK<ADOCCMFHLOM> PGEAEAGPPJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class PEMHBIKNLOO : ADOCCMFHLOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct LIAGPEPEMLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> EEHEMKCKEFF;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
		public LIAGPEPEMLG(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> MHGOIPHOLNN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class PAJOLPNIOHJ : ADOCCMFHLOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct ICPBDAOALHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly NIJFDNGGKMN INBEMJKGNNN;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
		public ICPBDAOALHF(NIJFDNGGKMN AHFAOLKKGOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x252CF90", Offset = "0x252C190", VA = "0x18252CF90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal KLPLGBAGKGB<GFMONJOAMNN, AHLCBJLMPBN> NPPBCJKBDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal KLPLGBAGKGB<MGLOOKOJCBG, IKOHKCLPMAM> FEEKBKBMNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal KLPLGBAGKGB<ANJMPLHAAEJ, HGKEOLEHGNJ> NELEIOOCKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal KLPLGBAGKGB<PEMHBIKNLOO, LIAGPEPEMLG> JDIHLPAHIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal KLPLGBAGKGB<PAJOLPNIOHJ, ICPBDAOALHF> PDJLNABHLJL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2524420", Offset = "0x2523620", VA = "0x182524420")]
	private EBLPEBOCPEJ([In] KLPLGBAGKGB<GFMONJOAMNN, AHLCBJLMPBN> PMALBODAEMG, [In] KLPLGBAGKGB<MGLOOKOJCBG, IKOHKCLPMAM> IHGJMPLAMLH, [In] KLPLGBAGKGB<ANJMPLHAAEJ, HGKEOLEHGNJ> FEFHHGBMNPJ, [In] KLPLGBAGKGB<PEMHBIKNLOO, LIAGPEPEMLG> LLBMFEGFFFA, [In] KLPLGBAGKGB<PAJOLPNIOHJ, ICPBDAOALHF> JIPNBGLDELN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x25242E0", Offset = "0x25234E0", VA = "0x1825242E0")]
	public static EBLPEBOCPEJ PAJOIGLPBMN()
	{
		return default(EBLPEBOCPEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FPKMCNFABCF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2527040", Offset = "0x2526240", VA = "0x182527040")]
	public static void LEGDOGAINAB(this EBLPEBOCPEJ MLNFAKCEGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum JKNNPKOPBDO
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
public struct DKNJPAIFLML
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class LMHMFHPJEDD : KPHNEBGMGPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct LEOBLCMEANC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> LIKNNDHDNKJ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
		public LEOBLCMEANC(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> OMCDLLKLNFF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum HFOOFHLPMCB
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
	public sealed class GGBMNICMPDF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class KPHNEBGMGPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct DNHJLEKLKHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly HFOOFHLPMCB ODLJPIABCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly ANHNAJIBLBK<KPHNEBGMGPA> LEGJILEPNMH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xBBA4F0", Offset = "0xBB96F0", VA = "0x180BBA4F0")]
		public DNHJLEKLKHF(HFOOFHLPMCB AOGHHHEGBOG, ANHNAJIBLBK<KPHNEBGMGPA> PGEAEAGPPJA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal KLPLGBAGKGB<GGBMNICMPDF, DNHJLEKLKHF> NPPBCJKBDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal KLPLGBAGKGB<LMHMFHPJEDD, LEOBLCMEANC> HIDDNNACDLG;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2524070", Offset = "0x2523270", VA = "0x182524070")]
	private DKNJPAIFLML([In] KLPLGBAGKGB<GGBMNICMPDF, DNHJLEKLKHF> PMALBODAEMG, [In] KLPLGBAGKGB<LMHMFHPJEDD, LEOBLCMEANC> LAFOCOALIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2523FE0", Offset = "0x25231E0", VA = "0x182523FE0")]
	public static DKNJPAIFLML PAJOIGLPBMN()
	{
		return default(DKNJPAIFLML);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FKFADDMPPFI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2524960", Offset = "0x2523B60", VA = "0x182524960")]
	public static void LEGDOGAINAB(this DKNJPAIFLML MLNFAKCEGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MLJKHGPDPHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public LPEAOCPACPN<int> NEOMFANBCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public LPEAOCPACPN<int> HJMEEGBGNEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int IIJEDMAEGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int KICCIFBPAJA;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x252D8C0", Offset = "0x252CAC0", VA = "0x18252D8C0")]
	private MLJKHGPDPHO([In] LPEAOCPACPN<int> FPIIJAKDPJN, [In] LPEAOCPACPN<int> NEPKOBGAFCN, int IFELGKBNKFH, int CJKCLDFLEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x252D820", Offset = "0x252CA20", VA = "0x18252D820")]
	public static MLJKHGPDPHO PAJOIGLPBMN()
	{
		return default(MLJKHGPDPHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KOHBLAJHJHB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x252D570", Offset = "0x252C770", VA = "0x18252D570")]
	public static void LEGDOGAINAB(this MLJKHGPDPHO MLNFAKCEGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FJCLLDLKNAL
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum BPKOEDKMCIM
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class LEPNAGLBHBM : EAHBILKAHAA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct IBEELAOJGGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly ANHNAJIBLBK<JJBPJDLMLAN> CONIABJMOHN;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
		public IBEELAOJGGE(ANHNAJIBLBK<JJBPJDLMLAN> NCEIFJCHIAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class NFMAIBAPMMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class EAHBILKAHAA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct PJCNPNCKCDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly BPKOEDKMCIM ODLJPIABCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly ANHNAJIBLBK<EAHBILKAHAA> LEGJILEPNMH;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xBBA4F0", Offset = "0xBB96F0", VA = "0x180BBA4F0")]
		private PJCNPNCKCDO(BPKOEDKMCIM AOGHHHEGBOG, ANHNAJIBLBK<EAHBILKAHAA> PGEAEAGPPJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x252EE90", Offset = "0x252E090", VA = "0x18252EE90")]
		public static PJCNPNCKCDO PAJOIGLPBMN(BPKOEDKMCIM AOGHHHEGBOG, ANHNAJIBLBK<EAHBILKAHAA> PGEAEAGPPJA)
		{
			return default(PJCNPNCKCDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class DGOHHFFFADJ : EAHBILKAHAA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct FGJKKIANKMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly ANHNAJIBLBK<JJBPJDLMLAN> CONIABJMOHN;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
		public FGJKKIANKMD(ANHNAJIBLBK<JJBPJDLMLAN> NCEIFJCHIAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class JJBPJDLMLAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct OANPFFJMFNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public LPEAOCPACPN<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> KDOHCHHEBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LPEAOCPACPN<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> HCHGLPKJFAI;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2524070", Offset = "0x2523270", VA = "0x182524070")]
		private OANPFFJMFNJ([In] LPEAOCPACPN<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> GIMIPDCICCE, [In] LPEAOCPACPN<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> INIPOIHLKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x252E980", Offset = "0x252DB80", VA = "0x18252E980")]
		public static OANPFFJMFNJ PAJOIGLPBMN()
		{
			return default(OANPFFJMFNJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal KLPLGBAGKGB<NFMAIBAPMMJ, PJCNPNCKCDO> NPPBCJKBDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal KLPLGBAGKGB<DGOHHFFFADJ, FGJKKIANKMD> PJMHILEABFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal KLPLGBAGKGB<LEPNAGLBHBM, IBEELAOJGGE> EPJEIPELLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal LPEAOCPACPN<(ANHNAJIBLBK<NFMAIBAPMMJ> CallId, ANHNAJIBLBK<JJBPJDLMLAN> IOId)> OLNNFLKBLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal KLPLGBAGKGB<JJBPJDLMLAN, OANPFFJMFNJ> MJNIHNMNBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal CBNAMIGFMIB<JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>> DBJDGMHJADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal CBNAMIGFMIB<JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>> FFKGAFDCPOC;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x25248A0", Offset = "0x2523AA0", VA = "0x1825248A0")]
	private FJCLLDLKNAL([In] KLPLGBAGKGB<NFMAIBAPMMJ, PJCNPNCKCDO> PMALBODAEMG, [In] KLPLGBAGKGB<DGOHHFFFADJ, FGJKKIANKMD> OPFDCMOHEMJ, [In] KLPLGBAGKGB<LEPNAGLBHBM, IBEELAOJGGE> GHPCHDKFIPF, [In] LPEAOCPACPN<(ANHNAJIBLBK<NFMAIBAPMMJ> CallId, ANHNAJIBLBK<JJBPJDLMLAN> IOId)> EEEDJOFELHN, [In] KLPLGBAGKGB<JJBPJDLMLAN, OANPFFJMFNJ> FBNGMFKILIH, [In] CBNAMIGFMIB<JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>> NGNLECOLMBN, [In] CBNAMIGFMIB<JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>> NDGEOFEBHDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2524700", Offset = "0x2523900", VA = "0x182524700")]
	public static FJCLLDLKNAL PAJOIGLPBMN()
	{
		return default(FJCLLDLKNAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class IBPJGFCFOBE
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x252CD30", Offset = "0x252BF30", VA = "0x18252CD30")]
	private static void LEGDOGAINAB(this FJCLLDLKNAL.OANPFFJMFNJ MLNFAKCEGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x252CD80", Offset = "0x252BF80", VA = "0x18252CD80")]
	public static void LEGDOGAINAB(this FJCLLDLKNAL MLNFAKCEGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NNIOICHGNPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public LPEAOCPACPN<byte> EGAFMKDHKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal FJCLLDLKNAL NFOBCALBJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal GAHEJFOHDIM KAIPIDNGABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> JPDCIOIPCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal EBLPEBOCPEJ EOIJGFBKMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal DKNJPAIFLML LNPEDCDMODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal CBNAMIGFMIB<GMJCCLIJBIB, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>?> MOKKNIDPDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal LPEAOCPACPN<ANHNAJIBLBK<GMJCCLIJBIB>> POMOOJIMCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?> ENBIGMNHFNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> VariableId, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>> ByteCodeWriteLocation)> LOFKIGLPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> BLGCJHBLMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal GAFNPEKEMDD OKPGPLCNNMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal GLKEDPAOPHL OEOGKHDDCLJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x252E4F0", Offset = "0x252D6F0", VA = "0x18252E4F0")]
	private NNIOICHGNPM([In] LPEAOCPACPN<byte> GFGNCFPMCIN, [In] FJCLLDLKNAL EDIKDFDLCMI, [In] GAHEJFOHDIM FLNFMLCICMJ, [In] EBLPEBOCPEJ EOCFPLBLHNA, [In] DKNJPAIFLML KBGMJKBILFL, [In] CBNAMIGFMIB<GMJCCLIJBIB, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>?> FOFGBKLCPNO, [In] LPEAOCPACPN<ANHNAJIBLBK<GMJCCLIJBIB>> ENOAEFHALBI, [In] CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?> AHGGMLIKPMD, [In] LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> VariableId, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>> ByteCodeWriteLocation)> GNNPFHCIKFP, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> EDEIOMPEKNF, [In] GAFNPEKEMDD BPMPHOFKLOL, [In] GLKEDPAOPHL PJDHGOHMPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x252DB40", Offset = "0x252CD40", VA = "0x18252DB40")]
	public static NNIOICHGNPM PAJOIGLPBMN()
	{
		return default(NNIOICHGNPM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FLPPGMBMLJK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct JDAIPHMHMOH : FFPDAOPDMIK<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>, CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x252D4B0", Offset = "0x252C6B0", VA = "0x18252D4B0")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x252D470", Offset = "0x252C670", VA = "0x18252D470", Slot = "4")]
		public ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPGCHONKNAF(int CPLNODNGKGB)
		{
			return default(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330")]
		public bool PCMGFNGBJPC(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "5")]
		private bool JMJNBGMAJPI(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x252D4A0", Offset = "0x252C6A0", VA = "0x18252D4A0", Slot = "6")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> EBIGPLLFKFK(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct OGPKHHIPJGC : HCCJBJEDIFN<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>, CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x252EB50", Offset = "0x252DD50", VA = "0x18252EB50")]
		public LPEAOCPACPN<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>> JDLPOLLBNDL(int INBBENCFHIF, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x252EBC0", Offset = "0x252DDC0", VA = "0x18252EBC0")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x252EA90", Offset = "0x252DC90", VA = "0x18252EA90", Slot = "6")]
		public void HALJCDJBEOB(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>> CJALOAIIOIM, ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x252EB50", Offset = "0x252DD50", VA = "0x18252EB50", Slot = "4")]
		private LPEAOCPACPN<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>> NLKCJGJOONB(int INBBENCFHIF, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x252EA80", Offset = "0x252DC80", VA = "0x18252EA80", Slot = "5")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> GOBMKPOMPMK(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct EMFIMFGPHPD : FFPDAOPDMIK<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>, CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x25244F0", Offset = "0x25236F0", VA = "0x1825244F0")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x25244B0", Offset = "0x25236B0", VA = "0x1825244B0", Slot = "4")]
		public ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPGCHONKNAF(int CPLNODNGKGB)
		{
			return default(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330")]
		public bool PCMGFNGBJPC(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "5")]
		private bool ODLEIKKADIH(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x25244E0", Offset = "0x25236E0", VA = "0x1825244E0", Slot = "6")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> JHKHCBAMOAP(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct NLOHHIGIACC : HCCJBJEDIFN<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>, CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x252DA20", Offset = "0x252CC20", VA = "0x18252DA20")]
		public LPEAOCPACPN<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>> JDLPOLLBNDL(int INBBENCFHIF, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x252DA90", Offset = "0x252CC90", VA = "0x18252DA90")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x252D960", Offset = "0x252CB60", VA = "0x18252D960", Slot = "6")]
		public void HALJCDJBEOB(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>> CJALOAIIOIM, ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x252DA20", Offset = "0x252CC20", VA = "0x18252DA20", Slot = "4")]
		private LPEAOCPACPN<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>> LNCCIAIBBNO(int INBBENCFHIF, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x252D950", Offset = "0x252CB50", VA = "0x18252D950", Slot = "5")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> FFGALHEBDBA(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> CPLNODNGKGB, [In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct IGAJKGEGGHN : FFPDAOPDMIK<ANHNAJIBLBK<FOIPKNJPLLP>, CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x252D120", Offset = "0x252C320", VA = "0x18252D120")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(ANHNAJIBLBK<FOIPKNJPLLP> CPLNODNGKGB, [In] CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x252D060", Offset = "0x252C260", VA = "0x18252D060", Slot = "4")]
		public ANHNAJIBLBK<FOIPKNJPLLP> CPGCHONKNAF(int CPLNODNGKGB)
		{
			return default(ANHNAJIBLBK<FOIPKNJPLLP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x252D090", Offset = "0x252C290", VA = "0x18252D090")]
		public bool PCMGFNGBJPC(ANHNAJIBLBK<FOIPKNJPLLP> CPLNODNGKGB, [In] CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x252D090", Offset = "0x252C290", VA = "0x18252D090", Slot = "5")]
		private bool EHIEDKEBJEH(ANHNAJIBLBK<FOIPKNJPLLP> CPLNODNGKGB, [In] CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x252D110", Offset = "0x252C310", VA = "0x18252D110", Slot = "6")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> HCCIAAHLAKP(ANHNAJIBLBK<FOIPKNJPLLP> CPLNODNGKGB, [In] CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct DPKMJPEMDHH : HCCJBJEDIFN<ANHNAJIBLBK<FOIPKNJPLLP>, CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x25240B0", Offset = "0x25232B0", VA = "0x1825240B0")]
		public LPEAOCPACPN<ANHNAJIBLBK<FOIPKNJPLLP>> JDLPOLLBNDL(int INBBENCFHIF, [In] CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<ANHNAJIBLBK<FOIPKNJPLLP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2524210", Offset = "0x2523410", VA = "0x182524210")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(ANHNAJIBLBK<FOIPKNJPLLP> CPLNODNGKGB, [In] CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2524120", Offset = "0x2523320", VA = "0x182524120", Slot = "6")]
		public void HALJCDJBEOB(ANHNAJIBLBK<FOIPKNJPLLP> CPLNODNGKGB, CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?> CJALOAIIOIM, ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x25240B0", Offset = "0x25232B0", VA = "0x1825240B0", Slot = "4")]
		private LPEAOCPACPN<ANHNAJIBLBK<FOIPKNJPLLP>> GFOOGGLAHKK(int INBBENCFHIF, [In] CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<ANHNAJIBLBK<FOIPKNJPLLP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2524200", Offset = "0x2523400", VA = "0x182524200", Slot = "5")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> KGMDLOIEEGM(ANHNAJIBLBK<FOIPKNJPLLP> CPLNODNGKGB, [In] CBNAMIGFMIB<FOIPKNJPLLP, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>?> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct JCNMNNJAHGK : FFPDAOPDMIK<int, LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x252D3D0", Offset = "0x252C5D0", VA = "0x18252D3D0")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> VariableId, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC30780", Offset = "0xC2F980", VA = "0x180C30780", Slot = "4")]
		public int CPGCHONKNAF(int CPLNODNGKGB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330")]
		public bool PCMGFNGBJPC(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> VariableId, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "5")]
		private bool LECOPNHDDPK(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> VariableId, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x252D3C0", Offset = "0x252C5C0", VA = "0x18252D3C0", Slot = "6")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> CDMIIOCJAEI(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> VariableId, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct LHEBLACHGKH : HCCJBJEDIFN<int, LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x252D710", Offset = "0x252C910", VA = "0x18252D710")]
		public LPEAOCPACPN<int> JDLPOLLBNDL(int INBBENCFHIF, [In] LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> VariableId, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x252D780", Offset = "0x252C980", VA = "0x18252D780")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> VariableId, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x252D610", Offset = "0x252C810", VA = "0x18252D610", Slot = "6")]
		public void HALJCDJBEOB(int CPLNODNGKGB, LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> VariableId, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>> ByteCodeWriteLocation)> CJALOAIIOIM, ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x252D710", Offset = "0x252C910", VA = "0x18252D710", Slot = "4")]
		private LPEAOCPACPN<int> LMPNKKBHKNF(int INBBENCFHIF, [In] LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> VariableId, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x252D600", Offset = "0x252C800", VA = "0x18252D600", Slot = "5")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> DIHICPBAKCB(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> VariableId, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<NJCGFOAHAGH>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct IFOAFGAJLPM : FFPDAOPDMIK<int, LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x252CFC0", Offset = "0x252C1C0", VA = "0x18252CFC0")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xC30780", Offset = "0xC2F980", VA = "0x180C30780", Slot = "4")]
		public int CPGCHONKNAF(int CPLNODNGKGB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330")]
		public bool PCMGFNGBJPC(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "5")]
		private bool JMOCOEIDGNG(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x252CFB0", Offset = "0x252C1B0", VA = "0x18252CFB0", Slot = "6")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> AGMBEHOPLPA(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct GLCPOIFANBP : HCCJBJEDIFN<int, LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x252CAE0", Offset = "0x252BCE0", VA = "0x18252CAE0")]
		public LPEAOCPACPN<int> JDLPOLLBNDL(int INBBENCFHIF, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x252CB50", Offset = "0x252BD50", VA = "0x18252CB50")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x252C9F0", Offset = "0x252BBF0", VA = "0x18252C9F0", Slot = "6")]
		public void HALJCDJBEOB(int CPLNODNGKGB, LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM, ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x252CAE0", Offset = "0x252BCE0", VA = "0x18252CAE0", Slot = "4")]
		private LPEAOCPACPN<int> KEANEAEFBFA(int INBBENCFHIF, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x252C9E0", Offset = "0x252BBE0", VA = "0x18252C9E0", Slot = "5")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> GAFKOBOMLPI(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct PMLLFEPGAOK : FFPDAOPDMIK<int, LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x252F9C0", Offset = "0x252EBC0", VA = "0x18252F9C0")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xC30780", Offset = "0xC2F980", VA = "0x180C30780", Slot = "4")]
		public int CPGCHONKNAF(int CPLNODNGKGB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330")]
		public bool PCMGFNGBJPC(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "5")]
		private bool JMOCOEIDGNG(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x252F9B0", Offset = "0x252EBB0", VA = "0x18252F9B0", Slot = "6")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> AGMBEHOPLPA(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct OPHBPKACEGI : HCCJBJEDIFN<int, LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x252ED80", Offset = "0x252DF80", VA = "0x18252ED80")]
		public LPEAOCPACPN<int> JDLPOLLBNDL(int INBBENCFHIF, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x252EDF0", Offset = "0x252DFF0", VA = "0x18252EDF0")]
		public ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x252EC80", Offset = "0x252DE80", VA = "0x18252EC80", Slot = "6")]
		public void HALJCDJBEOB(int CPLNODNGKGB, LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM, ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> OMEFCJCOLII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x252ED80", Offset = "0x252DF80", VA = "0x18252ED80", Slot = "4")]
		private LPEAOCPACPN<int> KEANEAEFBFA(int INBBENCFHIF, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(LPEAOCPACPN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x252EC70", Offset = "0x252DE70", VA = "0x18252EC70", Slot = "5")]
		private ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> GAFKOBOMLPI(int CPLNODNGKGB, [In] LPEAOCPACPN<(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> Target, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> ByteCodeWriteLocation)> CJALOAIIOIM)
		{
			return default(ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct NGMKKCFNCGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> HBGBJNDKGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool GDBBKNEMIMJ;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1BC53F0", Offset = "0x1BC45F0", VA = "0x181BC53F0")]
		public NGMKKCFNCGF(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI, bool PNALDOMFOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x252D920", Offset = "0x252CB20", VA = "0x18252D920")]
		public void NLHBJIEEJHA([Out] ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI, [Out] bool PNALDOMFOFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct LFPNOBOLBPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly ANHNAJIBLBK<FOIPKNJPLLP> KKANMPDJBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> HBGBJNDKGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool GDBBKNEMIMJ;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x252D5F0", Offset = "0x252C7F0", VA = "0x18252D5F0")]
		public LFPNOBOLBPO(ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI, bool PNALDOMFOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x252D5E0", Offset = "0x252C7E0", VA = "0x18252D5E0")]
		public void NLHBJIEEJHA([Out] ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI, [Out] bool PNALDOMFOFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x252D5C0", Offset = "0x252C7C0", VA = "0x18252D5C0")]
		public void NLHBJIEEJHA([Out] ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI, [Out] ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP, [Out] bool PNALDOMFOFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct AFBJCFPAJPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly ANHNAJIBLBK<FOIPKNJPLLP> KKANMPDJBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> HBGBJNDKGFE;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xBBA4F0", Offset = "0xBB96F0", VA = "0x180BBA4F0")]
		public AFBJCFPAJPN(ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2523E00", Offset = "0x2523000", VA = "0x182523E00")]
		public void NLHBJIEEJHA([Out] ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI, [Out] ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2526290", Offset = "0x2525490", VA = "0x182526290")]
	public static void LEGDOGAINAB(this NNIOICHGNPM MLNFAKCEGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2526560", Offset = "0x2525760", VA = "0x182526560")]
	public static void LMINHGDNHKG(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> DFGJFLOLFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x25257D0", Offset = "0x25249D0", VA = "0x1825257D0")]
	public static void GFAENPFFPLN(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> DFGJFLOLFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2524F50", Offset = "0x2524150", VA = "0x182524F50")]
	public static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>? BPCIOEAOPFM([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2525A40", Offset = "0x2524C40", VA = "0x182525A40")]
	public static ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> HGAPHOGGCEH([In] this NNIOICHGNPM MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2524C30", Offset = "0x2523E30", VA = "0x182524C30")]
	private static void BDKNMOIEIMC(this NNIOICHGNPM MLNFAKCEGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2526180", Offset = "0x2525380", VA = "0x182526180")]
	private static ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>? LAIJHDMGDHP([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2526800", Offset = "0x2525A00", VA = "0x182526800")]
	public static void MJNIAMEHBJE(this NNIOICHGNPM MLNFAKCEGNM, [In] LPEAOCPACPN<IMPPHNFEAGB> GOLEBIKPOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2525DC0", Offset = "0x2524FC0", VA = "0x182525DC0")]
	public static EBLPEBOCPEJ.NDBHHKDAGHH IDPEHOCBDKE([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI)
	{
		return default(EBLPEBOCPEJ.NDBHHKDAGHH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2525FB0", Offset = "0x25251B0", VA = "0x182525FB0")]
	public static NNEACHFMOIK<byte> JIKMINMJGGD([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI)
	{
		return default(NNEACHFMOIK<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2525520", Offset = "0x2524720", VA = "0x182525520")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FEELLAPEJGG([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x25249C0", Offset = "0x2523BC0", VA = "0x1825249C0")]
	public static NIJFDNGGKMN AAMNAFPHBBL([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI)
	{
		return default(NIJFDNGGKMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x324C8D0", Offset = "0x324BAD0", VA = "0x18324C8D0")]
	private static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> EMIHOIJEEHB<TMJoin>(this NNIOICHGNPM MLNFAKCEGNM, EBLPEBOCPEJ.NDBHHKDAGHH AOGHHHEGBOG, ANHNAJIBLBK<TMJoin> PGEAEAGPPJA) where TMJoin : EBLPEBOCPEJ.ADOCCMFHLOM
	{
		return default(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2526AB0", Offset = "0x2525CB0", VA = "0x182526AB0")]
	public static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> OHMNBFFMHDB(this NNIOICHGNPM MLNFAKCEGNM, bool MHGNIJHKPNB)
	{
		return default(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2524BA0", Offset = "0x2523DA0", VA = "0x182524BA0")]
	public static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> AOEOEENOCPB(this NNIOICHGNPM MLNFAKCEGNM, NNEACHFMOIK<byte> JIGDFCPIKCH)
	{
		return default(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2526BB0", Offset = "0x2525DB0", VA = "0x182526BB0")]
	public static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> OMBBOGLKLNO(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> JBDDPILCOGF)
	{
		return default(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2525610", Offset = "0x2524810", VA = "0x182525610")]
	public static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> FEHNCKKICOK(this NNIOICHGNPM MLNFAKCEGNM, int DANDJCDKNPI)
	{
		return default(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2526780", Offset = "0x2525980", VA = "0x182526780")]
	public static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> MGHHFPEPMOK(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> MHGOIPHOLNN)
	{
		return default(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x324CA20", Offset = "0x324BC20", VA = "0x18324CA20")]
	private static ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF> IPKEELLCMDO<TMJoin>(this NNIOICHGNPM MLNFAKCEGNM, DKNJPAIFLML.HFOOFHLPMCB AOGHHHEGBOG, ANHNAJIBLBK<TMJoin> PGEAEAGPPJA) where TMJoin : DKNJPAIFLML.KPHNEBGMGPA
	{
		return default(ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2525320", Offset = "0x2524520", VA = "0x182525320")]
	public static ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF> EGGHLNIDFFO(this NNIOICHGNPM MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x25250A0", Offset = "0x25242A0", VA = "0x1825250A0")]
	public static ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF> CGJGFMHEJNH(this NNIOICHGNPM MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2525E40", Offset = "0x2525040", VA = "0x182525E40")]
	public static ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF> IFOFFCPJJFD(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> OMCDLLKLNFF)
	{
		return default(ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x25258A0", Offset = "0x2524AA0", VA = "0x1825258A0")]
	public static ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF> GHMDPHNHPLM(this NNIOICHGNPM MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2526F00", Offset = "0x2526100", VA = "0x182526F00")]
	public static ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF> PNDBOBPCHNB(this NNIOICHGNPM MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25254A0", Offset = "0x25246A0", VA = "0x1825254A0")]
	public static FJCLLDLKNAL.BPKOEDKMCIM EOHCMPJGDIB([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ> CFNGJPFLNME)
	{
		return default(FJCLLDLKNAL.BPKOEDKMCIM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2525AA0", Offset = "0x2524CA0", VA = "0x182525AA0")]
	public static CDCOHBGBHFJ<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>, LJKPDNGPOAK<FJCLLDLKNAL.JJBPJDLMLAN>> HJBGEGMBLKN([In] this NNIOICHGNPM MLNFAKCEGNM)
	{
		return default(CDCOHBGBHFJ<ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>, LJKPDNGPOAK<FJCLLDLKNAL.JJBPJDLMLAN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2526D20", Offset = "0x2525F20", VA = "0x182526D20")]
	public static ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> PJJHGBGPKOI([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ> CFNGJPFLNME)
	{
		return default(ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2526B30", Offset = "0x2525D30", VA = "0x182526B30")]
	public static FJCLLDLKNAL.OANPFFJMFNJ OLMKEGLDKMG([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> NCEIFJCHIAA)
	{
		return default(FJCLLDLKNAL.OANPFFJMFNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25260A0", Offset = "0x25252A0", VA = "0x1825260A0")]
	public static FJCLLDLKNAL.OANPFFJMFNJ KAMLHDNMDHJ(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> NCEIFJCHIAA)
	{
		return default(FJCLLDLKNAL.OANPFFJMFNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x324C980", Offset = "0x324BB80", VA = "0x18324C980")]
	private static ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ> IPIMMCFMHGJ<TMJoin>(this NNIOICHGNPM MLNFAKCEGNM, FJCLLDLKNAL.BPKOEDKMCIM AOGHHHEGBOG, ANHNAJIBLBK<TMJoin> PGEAEAGPPJA) where TMJoin : FJCLLDLKNAL.EAHBILKAHAA
	{
		return default(ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2525C10", Offset = "0x2524E10", VA = "0x182525C10")]
	public static (ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>) IAHAEEKIAHB(this NNIOICHGNPM MLNFAKCEGNM)
	{
		return default((ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2524DA0", Offset = "0x2523FA0", VA = "0x182524DA0")]
	public static (ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>) BGPNBNHBCGI(this NNIOICHGNPM MLNFAKCEGNM)
	{
		return default((ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2526240", Offset = "0x2525440", VA = "0x182526240")]
	public static ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ> LBLDKFDOGBG(this NNIOICHGNPM MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2525010", Offset = "0x2524210", VA = "0x182525010")]
	public static void BPEHDMIGEGD(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN> NCEIFJCHIAA, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> EDNLMNKAFHL, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>> LHHIPFOACKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x324BAB0", Offset = "0x324ACB0", VA = "0x18324BAB0")]
	public static NGMKKCFNCGF DEHCNFMFCNL<TDeps, TStateSys>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP) where TDeps : EAMHFLHBJLH<TStateSys>
	{
		return default(NGMKKCFNCGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x324CCA0", Offset = "0x324BEA0", VA = "0x18324CCA0")]
	public static LFPNOBOLBPO NDPDAICDBMM<TDeps, TStateSys>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP, int JKBGDBBPBCM) where TDeps : EAMHFLHBJLH<TStateSys>
	{
		return default(LFPNOBOLBPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x324CF40", Offset = "0x324C140", VA = "0x18324CF40")]
	public static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>? NKADNGMPAFN<TDeps, TStateSys>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP, [In] ReadOnlySpan<int> KMCMLLGLPAJ, [In] Span<AFBJCFPAJPN> DPEFKPODJCK) where TDeps : EAMHFLHBJLH<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x324D380", Offset = "0x324C580", VA = "0x18324D380")]
	public static ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF> PPCHJALBFPL<TDeps, TStateSys>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA) where TDeps : EAMHFLHBJLH<TStateSys>
	{
		return default(ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2525EC0", Offset = "0x25250C0", VA = "0x182525EC0")]
	public static GAHEJFOHDIM.EDLHHIOAIGC JACLHAFBEAP([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> BEHEHKFONGA)
	{
		return default(GAHEJFOHDIM.EDLHHIOAIGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2524AB0", Offset = "0x2523CB0", VA = "0x182524AB0")]
	public static GAHEJFOHDIM.BIHBAIIDKAP AJJNBOLHIHD([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> BEHEHKFONGA)
	{
		return default(GAHEJFOHDIM.BIHBAIIDKAP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2526C30", Offset = "0x2525E30", VA = "0x182526C30")]
	public static GAHEJFOHDIM.HBMJDMFMCFC PFFGKIOIFLD([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> BEHEHKFONGA)
	{
		return default(GAHEJFOHDIM.HBMJDMFMCFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x25265F0", Offset = "0x25257F0", VA = "0x1825265F0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> LOPPJIJCDGA(this NNIOICHGNPM MLNFAKCEGNM, int? OMLDLEFDIAI, string LMOANCJLHKC)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2526F50", Offset = "0x2526150", VA = "0x182526F50")]
	public static GAHEJFOHDIM.BKHMBNFOACM PPPOCDLAPAG([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> BEHEHKFONGA)
	{
		return default(GAHEJFOHDIM.BKHMBNFOACM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2525360", Offset = "0x2524560", VA = "0x182525360")]
	public static GAHEJFOHDIM.LOBLHBNJNEE EJFDOFMEKDE([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> BEHEHKFONGA)
	{
		return default(GAHEJFOHDIM.LOBLHBNJNEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2526A40", Offset = "0x2525C40", VA = "0x182526A40")]
	public static int? NCLEHLMDBAB([In] this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> BEHEHKFONGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x324CAD0", Offset = "0x324BCD0", VA = "0x18324CAD0")]
	private static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> KJGCNENPEGO<TMJoin>(this NNIOICHGNPM MLNFAKCEGNM, int? OMLDLEFDIAI, GAHEJFOHDIM.LOBLHBNJNEE AOGHHHEGBOG, ANHNAJIBLBK<TMJoin> PGEAEAGPPJA) where TMJoin : GAHEJFOHDIM.FCOKDCEFKGP
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2525690", Offset = "0x2524890", VA = "0x182525690")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FHFNANLLOBE(this NNIOICHGNPM MLNFAKCEGNM, int? OMLDLEFDIAI, ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ> CFNGJPFLNME, int CPLNODNGKGB)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x25252C0", Offset = "0x25244C0", VA = "0x1825252C0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> DNOAPNHCIPF(this NNIOICHGNPM MLNFAKCEGNM, int? OMLDLEFDIAI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x25258F0", Offset = "0x2524AF0", VA = "0x1825258F0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> GJBONCBNHDP(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>? IDELDGBCIFI, int? OMLDLEFDIAI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2525740", Offset = "0x2524940", VA = "0x182525740")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FMDIPLGCACE(this NNIOICHGNPM MLNFAKCEGNM, int? OMLDLEFDIAI, int CPLNODNGKGB)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2526120", Offset = "0x2525320", VA = "0x182526120")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> KMOIPLONNKC(this NNIOICHGNPM MLNFAKCEGNM, int? OMLDLEFDIAI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2525180", Offset = "0x2524380", VA = "0x182525180")]
	public static void CKMPMFDHFOH(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> MHGOIPHOLNN, ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ> CFNGJPFLNME, int CPLNODNGKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2525AE0", Offset = "0x2524CE0", VA = "0x182525AE0")]
	public static void HOEMHFEEAKJ(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> MHGOIPHOLNN, int CPLNODNGKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x25253D0", Offset = "0x25245D0", VA = "0x1825253D0")]
	public static void EKCLIBACBOD(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> MHGOIPHOLNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x25250F0", Offset = "0x25242F0", VA = "0x1825250F0")]
	public static void CIFNCEJGGOC(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> MKMPLOHPJDC, ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> LCFPKPOIHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2526970", Offset = "0x2525B70", VA = "0x182526970")]
	public static void MOPFDFKAIML(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> MHGOIPHOLNN, ANHNAJIBLBK<OAPDHILNJPL<COAFALAOCMK>> JACBPMPFBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x324CBD0", Offset = "0x324BDD0", VA = "0x18324CBD0")]
	public static void NDKCKKKMCOH<M>(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> MHGOIPHOLNN, ANHNAJIBLBK<OAPDHILNJPL<EPNBOEFMACB<M>>> JACBPMPFBAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface EAMHFLHBJLH<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ANHNAJIBLBK<HNCEKEBEOFB> LABAOLGDKFJ(TStateSys PMBHPKCGDKC);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ANHNAJIBLBK<HNCEKEBEOFB> MECAPLDHGBK(TStateSys PMBHPKCGDKC);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ANHNAJIBLBK<HNCEKEBEOFB> MJLNNOBEDJD(TStateSys PMBHPKCGDKC);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ANHNAJIBLBK<HNCEKEBEOFB> AEOMJJBJMFO(TStateSys PMBHPKCGDKC);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF> NICPIGDHNCM(TStateSys PMBHPKCGDKC, NNIOICHGNPM HEKBFHLNMDL, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> IBPCMIDJNCP(TStateSys PMBHPKCGDKC, NNIOICHGNPM HEKBFHLNMDL, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int MFALFJKCOHL(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ANHNAJIBLBK<GMJCCLIJBIB> MGLEDJPKDCN(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP, int KPAHGANODGF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	JKNNPKOPBDO CKELKAGMGLJ(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BKKNJENOGFK(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int HNBEEAFEJHN(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	NNEACHFMOIK<byte> PPIJOMAEBPC(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(NNEACHFMOIK<byte>, ANHNAJIBLBK<HNCEKEBEOFB>) NJMDDLBLALK(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<FOIPKNJPLLP> CFHBDBIEIEP);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int ADKOHPFLHAI(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	ANHNAJIBLBK<FOIPKNJPLLP> DDLNPILPGME(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<GMJCCLIJBIB> KGKPKEDHPHA, int JKBGDBBPBCM);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ANHNAJIBLBK<FOIPKNJPLLP> KFCKALCECDK(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, ANHNAJIBLBK<COBLBOLGAKJ> MFMLNNMNGAP, int JKBGDBBPBCM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int PGIIEPCBGMA(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? IMJECOBNBDP(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, int CPLNODNGKGB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int PLKLAPAJLOJ(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? KAFDIBGNHCJ(TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL, int CPLNODNGKGB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GJIMGICPFOM
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x32600A0", Offset = "0x325F2A0", VA = "0x1832600A0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE?> NIEOKLIENMN<T, TOpInput, TOpOutput>(this NNIOICHGNPM MLNFAKCEGNM, T FBCBJPMNPEK, T HHDMEFHBCOI, int MDKKCNDPCCM, IntPtr BGJAGMIIILD)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x325FD00", Offset = "0x325EF00", VA = "0x18325FD00")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE?> NAMHPCPPFOD<T, TOpInput, TOpOutput>(this NNIOICHGNPM MLNFAKCEGNM, T FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI, int MDKKCNDPCCM, IntPtr BGJAGMIIILD)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x32603A0", Offset = "0x325F5A0", VA = "0x1832603A0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE?> OJNOHDENBOC<TOpInput, TOpOutput>(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI, int MDKKCNDPCCM, IntPtr BGJAGMIIILD)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x252ACF0", Offset = "0x2529EF0", VA = "0x18252ACF0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> JGGKJALNMIA(this NNIOICHGNPM MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x252B490", Offset = "0x252A690", VA = "0x18252B490")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> MMMDLAILECE(this NNIOICHGNPM MLNFAKCEGNM, float OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2529480", Offset = "0x2528680", VA = "0x182529480")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> EOBPIPGIBDN(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2529F40", Offset = "0x2529140", VA = "0x182529F40")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HDPPHHGNEAA(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x252BBA0", Offset = "0x252ADA0", VA = "0x18252BBA0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OBCPHMLAAOL(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x252C780", Offset = "0x252B980", VA = "0x18252C780")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> PCPJEIIIOCC(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x252B5B0", Offset = "0x252A7B0", VA = "0x18252B5B0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> NDKLGOJNIBJ(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2528E00", Offset = "0x2528000", VA = "0x182528E00")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> EDNPDGIEOAL(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x252ADF0", Offset = "0x2529FF0", VA = "0x18252ADF0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> JMBEEBFMEEN(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x252BCC0", Offset = "0x252AEC0", VA = "0x18252BCC0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OBKOIMEMCEP(this NNIOICHGNPM MLNFAKCEGNM, int FBCBJPMNPEK, int HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2528CE0", Offset = "0x2527EE0", VA = "0x182528CE0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> DPBGPIFIJLD(this NNIOICHGNPM MLNFAKCEGNM, int FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2528020", Offset = "0x2527220", VA = "0x182528020")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CCKCLAANMJF(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x252B6B0", Offset = "0x252A8B0", VA = "0x18252B6B0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> NELKAPNIHPD(this NNIOICHGNPM MLNFAKCEGNM, float FBCBJPMNPEK, float HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x252BDC0", Offset = "0x252AFC0", VA = "0x18252BDC0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCBBJDAHNLC(this NNIOICHGNPM MLNFAKCEGNM, float FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2529010", Offset = "0x2528210", VA = "0x182529010")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> EFOPAFNHAJF(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2529C60", Offset = "0x2528E60", VA = "0x182529C60")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> GFNIPFLCEMH(this NNIOICHGNPM MLNFAKCEGNM, int FBCBJPMNPEK, int HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2529380", Offset = "0x2528580", VA = "0x182529380")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> EMMEFKKJBDK(this NNIOICHGNPM MLNFAKCEGNM, int FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x252C5C0", Offset = "0x252B7C0", VA = "0x18252C5C0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OLDJCIBHCDG(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x25284C0", Offset = "0x25276C0", VA = "0x1825284C0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> DAFDONHEBCP(this NNIOICHGNPM MLNFAKCEGNM, float FBCBJPMNPEK, float HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x252C010", Offset = "0x252B210", VA = "0x18252C010")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OIMPGCNOPJA(this NNIOICHGNPM MLNFAKCEGNM, float FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2529400", Offset = "0x2528600", VA = "0x182529400")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> ENBMHMFEEED(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2528B20", Offset = "0x2527D20", VA = "0x182528B20")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> DNPCEFJOOAI(this NNIOICHGNPM MLNFAKCEGNM, int FBCBJPMNPEK, int HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2529940", Offset = "0x2528B40", VA = "0x182529940")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FBPFAMEINEG(this NNIOICHGNPM MLNFAKCEGNM, int FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2528160", Offset = "0x2527360", VA = "0x182528160")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDJDHAPFHKH(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x252B8F0", Offset = "0x252AAF0", VA = "0x18252B8F0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> NKNJDFPCIIB(this NNIOICHGNPM MLNFAKCEGNM, float FBCBJPMNPEK, float HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x252C700", Offset = "0x252B900", VA = "0x18252C700")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OPAMINOEFNL(this NNIOICHGNPM MLNFAKCEGNM, float FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x252BB20", Offset = "0x252AD20", VA = "0x18252BB20")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> NPKPDJEONFD(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x252B970", Offset = "0x252AB70", VA = "0x18252B970")]
	public static ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> NPKCCDNPJFJ(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2528280", Offset = "0x2527480", VA = "0x182528280")]
	public static ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> CIMLIBCFMOD(this NNIOICHGNPM MLNFAKCEGNM, int OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2527D50", Offset = "0x2526F50", VA = "0x182527D50")]
	public static ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> BLLLNMMNLKE(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x25291D0", Offset = "0x25283D0", VA = "0x1825291D0")]
	public static ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> EJINFMBAFFI(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> GJGIAMCOGNI)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2528440", Offset = "0x2527640", VA = "0x182528440")]
	public static ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> CONILAEAAFL(this NNIOICHGNPM MLNFAKCEGNM, int OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x25281E0", Offset = "0x25273E0", VA = "0x1825281E0")]
	public static ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> CGBNAEACEIA(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x252C090", Offset = "0x252B290", VA = "0x18252C090")]
	public static (ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>) OKCGMKGGDBG(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<AIBCAJKOANN> EINCAEEABFF, [In] ReadOnlySpan<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> GIMIPDCICCE, [In] ReadOnlySpan<int?> DFLMKENHHMK, [In] Span<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> EBHIJMNCING)
	{
		return default((ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x252A690", Offset = "0x2529890", VA = "0x18252A690")]
	public static (ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>) IDFAMPBBOCP(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<BAPNAOEGGLF> KOGILCMFGPN, [In] ReadOnlySpan<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> GIMIPDCICCE, [In] ReadOnlySpan<int?> DFLMKENHHMK, [In] Span<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> EBHIJMNCING)
	{
		return default((ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x325F7A0", Offset = "0x325E9A0", VA = "0x18325F7A0")]
	public static (ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<HNCEKEBEOFB>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<TMarker>>, ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>) IAPJABCPCBN<TMarker>(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<HNCEKEBEOFB> GMJMILMEMED, [In] ReadOnlySpan<byte> LFDKFEEPNFP)
	{
		return default((ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<OAPDHILNJPL<HNCEKEBEOFB>>, ANHNAJIBLBK<OAPDHILNJPL<EKLCHICICCF>>, ANHNAJIBLBK<OAPDHILNJPL<TMarker>>, ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x252C640", Offset = "0x252B840", VA = "0x18252C640")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OOILBKMAHLB(this NNIOICHGNPM MLNFAKCEGNM, int CBAPPNMGAFG, [Optional] ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>? CMNHJIAJJEP)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x252C4D0", Offset = "0x252B6D0", VA = "0x18252C4D0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OKKMHKJPMHH(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CBAPPNMGAFG, [Optional] ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>? CMNHJIAJJEP)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2528F20", Offset = "0x2528120", VA = "0x182528F20")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> EEBGHCMGIPN(this NNIOICHGNPM MLNFAKCEGNM, [In] ReadOnlySpan<byte> CBAPPNMGAFG, [Optional] ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>? CMNHJIAJJEP)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x252C8C0", Offset = "0x252BAC0", VA = "0x18252C8C0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> PPBAEEEFMNM(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CBAPPNMGAFG, int AFLMMFDMNOE, [Optional] ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>? CMNHJIAJJEP)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2528540", Offset = "0x2527740", VA = "0x182528540")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> DAHHLKPGILE(this NNIOICHGNPM MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x252AAD0", Offset = "0x2529CD0", VA = "0x18252AAD0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> JACOJHEPJMM(this NNIOICHGNPM MLNFAKCEGNM, float OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x25288A0", Offset = "0x2527AA0", VA = "0x1825288A0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> DLNMOJPIBEJ(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2529AE0", Offset = "0x2528CE0", VA = "0x182529AE0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> GCEDOAOEOCH(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2527730", Offset = "0x2526930", VA = "0x182527730")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> AOABAIKFLLM(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2528BA0", Offset = "0x2527DA0", VA = "0x182528BA0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> DOKMDAFFBDK(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x252A170", Offset = "0x2529370", VA = "0x18252A170")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHPFBHGPGMB(this NNIOICHGNPM MLNFAKCEGNM, int FBCBJPMNPEK, int HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2529BE0", Offset = "0x2528DE0", VA = "0x182529BE0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> GFMKDHOEGIO(this NNIOICHGNPM MLNFAKCEGNM, int FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2529150", Offset = "0x2528350", VA = "0x182529150")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> EGGHMIGLECF(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FBCBJPMNPEK, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HHDMEFHBCOI)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2527950", Offset = "0x2526B50", VA = "0x182527950")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> BJIIIHOKJFM(this NNIOICHGNPM MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x252B360", Offset = "0x252A560", VA = "0x18252B360")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> MFOGDPNIIOJ(this NNIOICHGNPM MLNFAKCEGNM, float OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2528300", Offset = "0x2527500", VA = "0x182528300")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CKEGDJCFILG(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x252B050", Offset = "0x252A250", VA = "0x18252B050")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> KKOHKJIKLIM(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x252AF30", Offset = "0x252A130", VA = "0x18252AF30")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> JOPACNDNBIA(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2528640", Offset = "0x2527840", VA = "0x182528640")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> DFIBNBOKDAK(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2529F20", Offset = "0x2529120", VA = "0x182529F20")]
	public static ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>> GPMLDAIMKFO(this NNIOICHGNPM MLNFAKCEGNM)
	{
		return default(ANHNAJIBLBK<OAPDHILNJPL<OAPDHILNJPL<ABEMNJEHFPP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2529840", Offset = "0x2528A40", VA = "0x182529840")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FANMOCNNNPB(this NNIOICHGNPM MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x252BEF0", Offset = "0x252B0F0", VA = "0x18252BEF0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OHICONMLHDA(this NNIOICHGNPM MLNFAKCEGNM, float OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x252B7B0", Offset = "0x252A9B0", VA = "0x18252B7B0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> NKCCGIGCGOF(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2529CE0", Offset = "0x2528EE0", VA = "0x182529CE0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> GOEKENLADJI(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x25299C0", Offset = "0x2528BC0", VA = "0x1825299C0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> FHMDLMNAHGI(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2529700", Offset = "0x2528900", VA = "0x182529700")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> EOIJCDBIJCG(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x252B260", Offset = "0x252A460", VA = "0x18252B260")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> MCOKMGPKINL(this NNIOICHGNPM MLNFAKCEGNM, int OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x252B150", Offset = "0x252A350", VA = "0x18252B150")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> LPIMPGMKBAE(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OMEFCJCOLII)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2528010", Offset = "0x2527210", VA = "0x182528010")]
	public static void BPNEHDDCENN(this NNIOICHGNPM MLNFAKCEGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2527F10", Offset = "0x2527110", VA = "0x182527F10")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> BPDIJFJHDAP(this NNIOICHGNPM MLNFAKCEGNM, float OCIGCGAJDPN, float CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x252A1F0", Offset = "0x25293F0", VA = "0x18252A1F0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HJLEGDEIIIN(this NNIOICHGNPM MLNFAKCEGNM, float OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x25289E0", Offset = "0x2527BE0", VA = "0x1825289E0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> DNIEEMLIGCG(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x252ABF0", Offset = "0x2529DF0", VA = "0x18252ABF0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> JBOIKMGONEG(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2528780", Offset = "0x2527980", VA = "0x182528780")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> DLBOKJHEIID(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2529DE0", Offset = "0x2528FE0", VA = "0x182529DE0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> GOJKNBHHLPL(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x252A310", Offset = "0x2529510", VA = "0x18252A310")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> HNKFJLMGPJN(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> CFNHJLOLOMN, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> PGMJJNPICDL)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2527850", Offset = "0x2526A50", VA = "0x182527850")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> BDEBBGHHFNI(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, int CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2527DF0", Offset = "0x2526FF0", VA = "0x182527DF0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> BMAGLJLHHHN(this NNIOICHGNPM MLNFAKCEGNM, int OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x25295C0", Offset = "0x25287C0", VA = "0x1825295C0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> EOCMLMCEMLC(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> OCIGCGAJDPN, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CDDLBPNACLO)
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x325D960", Offset = "0x325CB60", VA = "0x18325D960")]
	public static void AONIMNBOFGM<TDeps, TState>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TState ONNLPKDFGPA, ANHNAJIBLBK<AIBCAJKOANN> EINCAEEABFF, [In] ReadOnlySpan<ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>> HFIEIKFPBFO, [In] ReadOnlySpan<int?> DFLMKENHHMK, [In] Span<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> EBHIJMNCING, [In] Span<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> PANMIHHDABB, [In] ReadOnlySpan<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>?> HCKHIDNCAFC) where TDeps : notnull, EAMHFLHBJLH<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x325EE10", Offset = "0x325E010", VA = "0x18325EE10")]
	public static void FMHABDHCOEC<TDeps, TState>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TState ONNLPKDFGPA, ANHNAJIBLBK<BAPNAOEGGLF> LGBMMKDPNBN, [In] ReadOnlySpan<ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>> PLFJFADPNEI, [In] ReadOnlySpan<int?> DFLMKENHHMK, [In] Span<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> EBHIJMNCING, [In] Span<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>> PANMIHHDABB, [In] ReadOnlySpan<ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>?> HCKHIDNCAFC) where TDeps : notnull, EAMHFLHBJLH<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x325F3B0", Offset = "0x325E5B0", VA = "0x18325F3B0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> GKJBHAJKDKE<TDeps, TState>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TState ONNLPKDFGPA, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> IDELDGBCIFI, [Optional] ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>? CMNHJIAJJEP) where TDeps : notnull, EAMHFLHBJLH<TState> where TState : notnull
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x325F8A0", Offset = "0x325EAA0", VA = "0x18325F8A0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> JPCNFNKHDKB<TDeps, TState>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TState ONNLPKDFGPA, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> OMCDLLKLNFF, [Optional] ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>? CMNHJIAJJEP) where TDeps : notnull, EAMHFLHBJLH<TState> where TState : notnull
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x325EBE0", Offset = "0x325DDE0", VA = "0x18325EBE0")]
	public static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> FFHCKOCMBFG<TDeps, TStateSys>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TStateSys PMBHPKCGDKC) where TDeps : notnull, EAMHFLHBJLH<TStateSys> where TStateSys : notnull
	{
		return default(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x325F590", Offset = "0x325E790", VA = "0x18325F590")]
	public static ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF> HFHAGPCKIJK<TDeps, TStateSys>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TStateSys PMBHPKCGDKC) where TDeps : notnull, EAMHFLHBJLH<TStateSys> where TStateSys : notnull
	{
		return default(ANHNAJIBLBK<DKNJPAIFLML.GGBMNICMPDF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x252A040", Offset = "0x2529240", VA = "0x18252A040")]
	public static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> HEIEHELCPIK(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> AJPNIKLJPOF, IntPtr BGHIDABPKFH, IntPtr ELLPOCKHKHH)
	{
		return default(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2527A50", Offset = "0x2526C50", VA = "0x182527A50")]
	public static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> BKPBDBBGKIF(this NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> MLOCMAHMMFE, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> BIHAJFFAIKI, IntPtr AAFLMJIPKNO, IntPtr KGPHEAFMAGK, IntPtr BGOLIJFDMLJ, bool LJIPIFHFFDA)
	{
		return default(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x325E4B0", Offset = "0x325D6B0", VA = "0x18325E4B0")]
	public static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> DEBFLPBNPPH<TDeps, TState>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TState ONNLPKDFGPA, ANHNAJIBLBK<AIBCAJKOANN> LAGCAOADLGF, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> MLOCMAHMMFE, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> BIHAJFFAIKI, int? HKHDGCNBDKN, [Optional] IntPtr DNGFDBNDJFM) where TDeps : notnull, EAMHFLHBJLH<TState> where TState : notnull
	{
		return default(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x325E190", Offset = "0x325D390", VA = "0x18325E190")]
	private static ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> DEBFLPBNPPH<TDeps, TState>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TState ONNLPKDFGPA, ANHNAJIBLBK<AIBCAJKOANN> LAGCAOADLGF, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> MLOCMAHMMFE, ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN> BIHAJFFAIKI, int? HKHDGCNBDKN) where TDeps : notnull, EAMHFLHBJLH<TState> where TState : notnull
	{
		return default(ANHNAJIBLBK<EBLPEBOCPEJ.GFMONJOAMNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x325D5B0", Offset = "0x325C7B0", VA = "0x18325D5B0")]
	public static ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> ANHPECICGEH<TDeps, TState>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TState ONNLPKDFGPA, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> CBAPPNMGAFG, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>? CMNHJIAJJEP) where TDeps : notnull, EAMHFLHBJLH<TState> where TState : notnull
	{
		return default(ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x325DF00", Offset = "0x325D100", VA = "0x18325DF00")]
	public static void BIOCKBIEKPG<TDeps, TState>(this NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TState ONNLPKDFGPA, int ECCNBLFDGPM) where TDeps : notnull, EAMHFLHBJLH<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct KDJGKKKIJLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> OAEOOACPDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> EFBLFMKIOAF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xBBA4F0", Offset = "0xBB96F0", VA = "0x180BBA4F0")]
	public KDJGKKKIJLO(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> LIIFPOOFHPJ, ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> AAFCGNOBJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x252D560", Offset = "0x252C760", VA = "0x18252D560")]
	public static KDJGKKKIJLO PAJOIGLPBMN(ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>> LIIFPOOFHPJ)
	{
		return default(KDJGKKKIJLO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct GAHEJFOHDIM
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class BALAIAPHLBM : FCOKDCEFKGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct EDLHHIOAIGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ> PEMINALIPJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int JDABKJNJMBH;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xBBA4F0", Offset = "0xBB96F0", VA = "0x180BBA4F0")]
		public EDLHHIOAIGC(ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ> CFNGJPFLNME, int CPLNODNGKGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class AIIKPGNGPNN : FCOKDCEFKGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct BIHBAIIDKAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int JDABKJNJMBH;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
		public BIHBAIIDKAP(int CPLNODNGKGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class HLJBCKGGBIM : FCOKDCEFKGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct HBMJDMFMCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ> PEMINALIPJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int JDABKJNJMBH;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xBBA4F0", Offset = "0xBB96F0", VA = "0x180BBA4F0")]
		public HBMJDMFMCFC(ANHNAJIBLBK<FJCLLDLKNAL.NFMAIBAPMMJ> CFNGJPFLNME, int CPLNODNGKGB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum LOBLHBNJNEE
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
	public sealed class GJKOPIFAIEE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class FCOKDCEFKGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct NJLJCMABEIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? BJFMDGJGPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public KDJGKKKIJLO JIDFNIFLFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public LOBLHBNJNEE ODLJPIABCHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public ANHNAJIBLBK<FCOKDCEFKGP> LEGJILEPNMH;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x252D930", Offset = "0x252CB30", VA = "0x18252D930")]
		public NJLJCMABEIN(int? OMLDLEFDIAI, [In] KDJGKKKIJLO PNNMHNCEDDK, LOBLHBNJNEE AOGHHHEGBOG, ANHNAJIBLBK<FCOKDCEFKGP> PGEAEAGPPJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class KLCPGEFJKCF : FCOKDCEFKGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct BKHMBNFOACM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int JDABKJNJMBH;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
		public BKHMBNFOACM(int CPLNODNGKGB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal GJPLMLHCMGN<GJKOPIFAIEE, NJLJCMABEIN> NPPBCJKBDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal GJPLMLHCMGN<BALAIAPHLBM, EDLHHIOAIGC> GAIPGGMADEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal GJPLMLHCMGN<HLJBCKGGBIM, HBMJDMFMCFC> DOLMAMEDIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal GJPLMLHCMGN<KLCPGEFJKCF, BKHMBNFOACM> FDAMOFDOAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal GJPLMLHCMGN<AIIKPGNGPNN, BIHBAIIDKAP> EJGIHKEKOLO;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2527580", Offset = "0x2526780", VA = "0x182527580")]
	private GAHEJFOHDIM([In] GJPLMLHCMGN<GJKOPIFAIEE, NJLJCMABEIN> PMALBODAEMG, [In] GJPLMLHCMGN<BALAIAPHLBM, EDLHHIOAIGC> IMJGIAAHCGK, [In] GJPLMLHCMGN<HLJBCKGGBIM, HBMJDMFMCFC> ELAEFMGKOBC, [In] GJPLMLHCMGN<KLCPGEFJKCF, BKHMBNFOACM> PGIFNANEGOH, [In] GJPLMLHCMGN<AIIKPGNGPNN, BIHBAIIDKAP> EAPGPLHANEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2527390", Offset = "0x2526590", VA = "0x182527390")]
	public static GAHEJFOHDIM PAJOIGLPBMN()
	{
		return default(GAHEJFOHDIM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class FBDAAAFHPDM
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2524650", Offset = "0x2523850", VA = "0x182524650")]
	public static void LEGDOGAINAB(this GAHEJFOHDIM MLNFAKCEGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class IJMCKKPGJGD
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x252D1F0", Offset = "0x252C3F0", VA = "0x18252D1F0")]
	public static void BOIJOOGLJMA(NNIOICHGNPM MLNFAKCEGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct GAFNPEKEMDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, MLJKHGPDPHO> MPPECGHKJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int LPDLEALFBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int ELOCADGEIAA;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2527350", Offset = "0x2526550", VA = "0x182527350")]
	private GAFNPEKEMDD([In] CBNAMIGFMIB<FJCLLDLKNAL.JJBPJDLMLAN, MLJKHGPDPHO> JOBMMJFDFKN, int PPMDHBALEJN, int EJFMOINBIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x25272E0", Offset = "0x25264E0", VA = "0x1825272E0")]
	public static GAFNPEKEMDD PAJOIGLPBMN()
	{
		return default(GAFNPEKEMDD);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x25270F0", Offset = "0x25262F0", VA = "0x1825270F0")]
	public void LEGDOGAINAB([In] NNIOICHGNPM LBBKMINILHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x32542D0", Offset = "0x32534D0", VA = "0x1832542D0")]
	public static void BOIJOOGLJMA<TDeps, TStateSys>(NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TStateSys PMBHPKCGDKC, ANHNAJIBLBK<KJENBNHGDMG> KMGNKJBKEAL) where TDeps : notnull, EAMHFLHBJLH<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class CMGPCEAIFII
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2523E10", Offset = "0x2523010", VA = "0x182523E10")]
	public static void BOIJOOGLJMA(NNIOICHGNPM MLNFAKCEGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct GLKEDPAOPHL
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface CNIIIIKFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void INEEIPPIANI(LPEAOCPACPN<byte> GFGNCFPMCIN, int IMPFFPPEBLA);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct OBHCKFAENHN : CNIIIIKFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x252EA00", Offset = "0x252DC00", VA = "0x18252EA00", Slot = "4")]
		public void INEEIPPIANI(LPEAOCPACPN<byte> GFGNCFPMCIN, int IMPFFPPEBLA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct NOHPLFLAFBM : CNIIIIKFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x252E850", Offset = "0x252DA50", VA = "0x18252E850", Slot = "4")]
		public void INEEIPPIANI(LPEAOCPACPN<byte> GFGNCFPMCIN, int IMPFFPPEBLA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct GEEFDBHNMNF : CNIIIIKFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x25276B0", Offset = "0x25268B0", VA = "0x1825276B0", Slot = "4")]
		public void INEEIPPIANI(LPEAOCPACPN<byte> GFGNCFPMCIN, int IMPFFPPEBLA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct EPJLLBANBIC : CNIIIIKFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x25245A0", Offset = "0x25237A0", VA = "0x1825245A0", Slot = "4")]
		public void INEEIPPIANI(LPEAOCPACPN<byte> GFGNCFPMCIN, int IMPFFPPEBLA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class FCKPLJOKIPI<TCallProcessorDeps> where TCallProcessorDeps : struct, CNIIIIKFIJB
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps PHOHCHAEDED;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x32C6AC0", Offset = "0x32C5CC0", VA = "0x1832C6AC0")]
		public static int BOIJOOGLJMA<TDeps, TStateSys>(TDeps KHICLIFOGCP, TStateSys ONNLPKDFGPA, NNIOICHGNPM LBBKMINILHE, [In] LPEAOCPACPN<byte> FOJBBBHMPBG, int COGKOGHIDCL) where TDeps : EAMHFLHBJLH<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private LPEAOCPACPN<IMPPHNFEAGB> JPKHFDGCBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>> NGOJGKOEMJA;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x252CCF0", Offset = "0x252BEF0", VA = "0x18252CCF0")]
	private GLKEDPAOPHL([In] LPEAOCPACPN<IMPPHNFEAGB> GOLEBIKPOPN, Dictionary<ANHNAJIBLBK<OAPDHILNJPL<ABEMNJEHFPP>>, ANHNAJIBLBK<FJCLLDLKNAL.JJBPJDLMLAN>> JGAIKPJOPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x252CC30", Offset = "0x252BE30", VA = "0x18252CC30")]
	public static GLKEDPAOPHL PAJOIGLPBMN()
	{
		return default(GLKEDPAOPHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x252CBF0", Offset = "0x252BDF0", VA = "0x18252CBF0")]
	public void LEGDOGAINAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3261B60", Offset = "0x3260D60", VA = "0x183261B60")]
	public static void BOIJOOGLJMA<TDeps, TStateSys>(NNIOICHGNPM MLNFAKCEGNM, TDeps KHICLIFOGCP, TStateSys PMBHPKCGDKC) where TDeps : EAMHFLHBJLH<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class PLNFNOJJMND
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct NPCDDFKHIMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> AIDIGFPDNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int MGMJKJBNJOG;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int AGOKLHFOLPN;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int KFALFOMADEA;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x252EEA0", Offset = "0x252E0A0", VA = "0x18252EEA0")]
	public static void BOIJOOGLJMA(NNIOICHGNPM MLNFAKCEGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x252F7D0", Offset = "0x252E9D0", VA = "0x18252F7D0")]
	private static void LGFLBJFIGHF([In] NNIOICHGNPM MLNFAKCEGNM, ANHNAJIBLBK<GAHEJFOHDIM.GJKOPIFAIEE> BEHEHKFONGA, LPEAOCPACPN<byte> OEPFMBELJGD, List<NPCDDFKHIMG> KEHMPJHBNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x252F690", Offset = "0x252E890", VA = "0x18252F690")]
	private static void LGFLBJFIGHF(LPEAOCPACPN<byte> OEPFMBELJGD, int AFLMMFDMNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x252F560", Offset = "0x252E760", VA = "0x18252F560")]
	private static void IPOHGFNMNHO(NNIOICHGNPM MLNFAKCEGNM, List<NPCDDFKHIMG> KEHMPJHBNCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class IDKNBGNBIJK<TDeps, TIndex, TValues> where TDeps : struct, HCCJBJEDIFN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps PHOHCHAEDED;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x45ADA90", Offset = "0x45ACC90", VA = "0x1845ADA90")]
	public static void BOIJOOGLJMA([In] LPEAOCPACPN<IMPPHNFEAGB> GOLEBIKPOPN, int INBBENCFHIF, TValues CJALOAIIOIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HCCJBJEDIFN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LPEAOCPACPN<TIndex> JDLPOLLBNDL(int INBBENCFHIF, [In] TValues CJALOAIIOIM);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(TIndex CPLNODNGKGB, [In] TValues CJALOAIIOIM);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HALJCDJBEOB(TIndex CPLNODNGKGB, TValues CJALOAIIOIM, ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> OMEFCJCOLII);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface FFPDAOPDMIK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex CPGCHONKNAF(int CPLNODNGKGB);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PCMGFNGBJPC(TIndex CPLNODNGKGB, [In] TValues CJALOAIIOIM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ANHNAJIBLBK<OAPDHILNJPL<NJCGFOAHAGH>> NEOAJOCDBKD(TIndex CPLNODNGKGB, [In] TValues CJALOAIIOIM);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class PJALMPJGKPB<TDeps, TIndex, TValues> where TDeps : struct, FFPDAOPDMIK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps PHOHCHAEDED;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4F3CF00", Offset = "0x4F3C100", VA = "0x184F3CF00")]
	public static LPEAOCPACPN<TIndex> BOIJOOGLJMA(int INBBENCFHIF, [In] TValues CJALOAIIOIM)
	{
		return default(LPEAOCPACPN<TIndex>);
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
