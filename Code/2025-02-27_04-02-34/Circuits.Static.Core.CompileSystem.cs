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
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x256ECC0", Offset = "0x256E0C0", VA = "0x18256ECC0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x975680", Offset = "0x974A80", VA = "0x180975680")]
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
		[Cpp2IlInjected.Address(RVA = "0x9756C0", Offset = "0x974AC0", VA = "0x1809756C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct IOFBBBHHNMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> NPHAABPPNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int MBLKEEKGIMP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xBAEB50", Offset = "0xBADF50", VA = "0x180BAEB50")]
	public IOFBBBHHNMH(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> PANEEJBPJIB, int FDJGEFDKBBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EHHPKHHJDEH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class KLDPNIGMLJI : OKNJCNHOGMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct KJEJIKPNHNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly CMNAKGAJECJ<byte> OEKDHNEFOEA;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2505520", Offset = "0x2504920", VA = "0x182505520")]
		public KJEJIKPNHNN(CMNAKGAJECJ<byte> HECJPBMFJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2566F10", Offset = "0x2566310", VA = "0x182566F10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class LLLFINADEKE : OKNJCNHOGMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct PJNPPDIEHBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> ILEDABHHHPD;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640")]
		public PJNPPDIEHBH(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> FGFHFMAAPCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum KIOFCPABEOD
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
	public sealed class ODMIPPAJKNC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class OKNJCNHOGMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct KIKHIGKPAEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly KIOFCPABEOD JHADKPFHNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly AAFGLNNJOHN<OKNJCNHOGMJ> EPLMGEKKGNH;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBAEB50", Offset = "0xBADF50", VA = "0x180BAEB50")]
		public KIKHIGKPAEE(KIOFCPABEOD CJNJJHGCMNP, AAFGLNNJOHN<OKNJCNHOGMJ> JEDMOOBIPEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class EGDDJHKNOEI : OKNJCNHOGMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct CNGAKKOKBNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KNIPBCLACEK;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640")]
		public CNGAKKOKBNJ(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OBJDIELFEEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class FMMOGFLEPEO : OKNJCNHOGMJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct GICGIBIBLHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly GJIJKFCGDLH KFBGFOOEOAP;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640")]
		public GICGIBIBLHI(GJIJKFCGDLH JBBFCBFMCFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2565CD0", Offset = "0x25650D0", VA = "0x182565CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal LGAOODPNEIE<ODMIPPAJKNC, KIKHIGKPAEE> NGEGHEPOOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal LGAOODPNEIE<KLDPNIGMLJI, KJEJIKPNHNN> APPFCIECCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal LGAOODPNEIE<LLLFINADEKE, PJNPPDIEHBH> COCOEPHDGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal LGAOODPNEIE<EGDDJHKNOEI, CNGAKKOKBNJ> AMLPGNJFGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal LGAOODPNEIE<FMMOGFLEPEO, GICGIBIBLHI> MCHPAKPMIOE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2565270", Offset = "0x2564670", VA = "0x182565270")]
	private EHHPKHHJDEH([In] LGAOODPNEIE<ODMIPPAJKNC, KIKHIGKPAEE> EDMOECAGMMB, [In] LGAOODPNEIE<KLDPNIGMLJI, KJEJIKPNHNN> FFBHEKGMBKO, [In] LGAOODPNEIE<LLLFINADEKE, PJNPPDIEHBH> PLCBPMFMABA, [In] LGAOODPNEIE<EGDDJHKNOEI, CNGAKKOKBNJ> HOCMAMKMADC, [In] LGAOODPNEIE<FMMOGFLEPEO, GICGIBIBLHI> FDFOOMEPHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2565130", Offset = "0x2564530", VA = "0x182565130")]
	public static EHHPKHHJDEH FEOBEKOIKMG()
	{
		return default(EHHPKHHJDEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IPCJCEPCONO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2565EB0", Offset = "0x25652B0", VA = "0x182565EB0")]
	public static void MHAKNCNBNPL(this EHHPKHHJDEH JDCFMPOHCEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum OGLNNMIENEH
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
public struct LCFHNJGJDNO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class FHONPIPLLGC : HGIMGOGLHGK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct BNGBAFIJAPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> HOGEIGMOPBN;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640")]
		public BNGBAFIJAPG(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> AIGBMOACGPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum HHMEJDLHMPF
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
	public sealed class PNCPNAJBDFD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class HGIMGOGLHGK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct AIMEDJGBDMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly HHMEJDLHMPF JHADKPFHNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly AAFGLNNJOHN<HGIMGOGLHGK> EPLMGEKKGNH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xBAEB50", Offset = "0xBADF50", VA = "0x180BAEB50")]
		public AIMEDJGBDMM(HHMEJDLHMPF CJNJJHGCMNP, AAFGLNNJOHN<HGIMGOGLHGK> JEDMOOBIPEE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal LGAOODPNEIE<PNCPNAJBDFD, AIMEDJGBDMM> NGEGHEPOOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LGAOODPNEIE<FHONPIPLLGC, BNGBAFIJAPG> PGHFDFHFJDO;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2564A30", Offset = "0x2563E30", VA = "0x182564A30")]
	private LCFHNJGJDNO([In] LGAOODPNEIE<PNCPNAJBDFD, AIMEDJGBDMM> EDMOECAGMMB, [In] LGAOODPNEIE<FHONPIPLLGC, BNGBAFIJAPG> IAEFDFGDEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2566FD0", Offset = "0x25663D0", VA = "0x182566FD0")]
	public static LCFHNJGJDNO FEOBEKOIKMG()
	{
		return default(LCFHNJGJDNO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class HEBJGBFFJNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2565CF0", Offset = "0x25650F0", VA = "0x182565CF0")]
	public static void MHAKNCNBNPL(this LCFHNJGJDNO JDCFMPOHCEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BMCPBJELNAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public LDIDKHKLAFM<int> CFGKFHDMOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public LDIDKHKLAFM<int> ECCMLAHPDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int NMKIBBHPCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int DAACLCJEJLJ;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x25646B0", Offset = "0x2563AB0", VA = "0x1825646B0")]
	private BMCPBJELNAP([In] LDIDKHKLAFM<int> MPBPJPJOLGL, [In] LDIDKHKLAFM<int> BFNHIJIODEA, int JALFJIOKLHP, int LMJCBJLNDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2564610", Offset = "0x2563A10", VA = "0x182564610")]
	public static BMCPBJELNAP FEOBEKOIKMG()
	{
		return default(BMCPBJELNAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KNPDJGADKLE
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2566F80", Offset = "0x2566380", VA = "0x182566F80")]
	public static void MHAKNCNBNPL(this BMCPBJELNAP JDCFMPOHCEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FBBMGEKBAEG
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum PDNKFMLMDFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class BHDMNDBFOEO : PHCLEEHEFOJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct AEBACGJKPJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly AAFGLNNJOHN<CBCIMGBEMLP> KBGIFGANMOG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640")]
		public AEBACGJKPJN(AAFGLNNJOHN<CBCIMGBEMLP> MDLEBAMNKKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class HCAJLNPPEED
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class PHCLEEHEFOJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct CNEHNKPBGMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly PDNKFMLMDFA JHADKPFHNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly AAFGLNNJOHN<PHCLEEHEFOJ> EPLMGEKKGNH;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xBAEB50", Offset = "0xBADF50", VA = "0x180BAEB50")]
		private CNEHNKPBGMN(PDNKFMLMDFA CJNJJHGCMNP, AAFGLNNJOHN<PHCLEEHEFOJ> JEDMOOBIPEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2564A70", Offset = "0x2563E70", VA = "0x182564A70")]
		public static CNEHNKPBGMN FEOBEKOIKMG(PDNKFMLMDFA CJNJJHGCMNP, AAFGLNNJOHN<PHCLEEHEFOJ> JEDMOOBIPEE)
		{
			return default(CNEHNKPBGMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class DOOPHNICFHG : PHCLEEHEFOJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct AKKKHFOBCGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly AAFGLNNJOHN<CBCIMGBEMLP> KBGIFGANMOG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640")]
		public AKKKHFOBCGB(AAFGLNNJOHN<CBCIMGBEMLP> MDLEBAMNKKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class CBCIMGBEMLP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct CKJDGHLCMPD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public LDIDKHKLAFM<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> ONODPEKHKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LDIDKHKLAFM<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> HKLBMMOHJKN;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2564A30", Offset = "0x2563E30", VA = "0x182564A30")]
		private CKJDGHLCMPD([In] LDIDKHKLAFM<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> KAACKOKPHBP, [In] LDIDKHKLAFM<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> MDJCOPALAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x25649B0", Offset = "0x2563DB0", VA = "0x1825649B0")]
		public static CKJDGHLCMPD FEOBEKOIKMG()
		{
			return default(CKJDGHLCMPD);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal LGAOODPNEIE<HCAJLNPPEED, CNEHNKPBGMN> NGEGHEPOOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal LGAOODPNEIE<DOOPHNICFHG, AKKKHFOBCGB> JPDEOIMFGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal LGAOODPNEIE<BHDMNDBFOEO, AEBACGJKPJN> MCKJDIKEKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal LDIDKHKLAFM<(AAFGLNNJOHN<HCAJLNPPEED> CallId, AAFGLNNJOHN<CBCIMGBEMLP> IOId)> FCAMEDHCOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal LGAOODPNEIE<CBCIMGBEMLP, CKJDGHLCMPD> DPMONPKNENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal HOLDAFBGHPF<CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>> HHPIPEBDOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal HOLDAFBGHPF<CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>> PDDKBEBLOKC;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x25654A0", Offset = "0x25648A0", VA = "0x1825654A0")]
	private FBBMGEKBAEG([In] LGAOODPNEIE<HCAJLNPPEED, CNEHNKPBGMN> EDMOECAGMMB, [In] LGAOODPNEIE<DOOPHNICFHG, AKKKHFOBCGB> HEFKIFADLBH, [In] LGAOODPNEIE<BHDMNDBFOEO, AEBACGJKPJN> BCJKBBNHDBP, [In] LDIDKHKLAFM<(AAFGLNNJOHN<HCAJLNPPEED> CallId, AAFGLNNJOHN<CBCIMGBEMLP> IOId)> DKPNFOAKLEJ, [In] LGAOODPNEIE<CBCIMGBEMLP, CKJDGHLCMPD> NNNBNOBDKPO, [In] HOLDAFBGHPF<CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>> NNBHLDPDCOA, [In] HOLDAFBGHPF<CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>> LDLPCADJOOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2565300", Offset = "0x2564700", VA = "0x182565300")]
	public static FBBMGEKBAEG FEOBEKOIKMG()
	{
		return default(FBBMGEKBAEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DCPHMIGGDNL
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2564A80", Offset = "0x2563E80", VA = "0x182564A80")]
	private static void MHAKNCNBNPL(this FBBMGEKBAEG.CKJDGHLCMPD JDCFMPOHCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2564AD0", Offset = "0x2563ED0", VA = "0x182564AD0")]
	public static void MHAKNCNBNPL(this FBBMGEKBAEG JDCFMPOHCEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BJJJDBBOKOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public LDIDKHKLAFM<byte> ENLDGDABICN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal FBBMGEKBAEG DELJGNJFHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal GANFCKFDIJB LIHHENFGMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> IIBMINGDLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal EHHPKHHJDEH EAGOFDLHIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal LCFHNJGJDNO KPLDFFNEKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal HOLDAFBGHPF<OECNLCLGMED, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>?> IOIEDALLPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>> BHCIMJHBIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?> APMPBFEFEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> VariableId, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>> ByteCodeWriteLocation)> HJBCMKLCLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> JKKDAFIAHOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal PEKPHDNHCNN OLFIJGINJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal ANKJIJJHKCP INONDCDLPNA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2564230", Offset = "0x2563630", VA = "0x182564230")]
	private BJJJDBBOKOI([In] LDIDKHKLAFM<byte> OGGJFKFPLFG, [In] FBBMGEKBAEG NJPENKLEDNK, [In] GANFCKFDIJB MPEEJLIGHIL, [In] EHHPKHHJDEH EJCFAPAIMOE, [In] LCFHNJGJDNO KDMLEFLFFJH, [In] HOLDAFBGHPF<OECNLCLGMED, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>?> NJINJHAOHEL, [In] LDIDKHKLAFM<AAFGLNNJOHN<OECNLCLGMED>> KIGHJKDKHGG, [In] HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?> EEJHJBMAFBP, [In] LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> VariableId, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>> ByteCodeWriteLocation)> BIBDLGKAPGC, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> JKKEMHNICNN, [In] PEKPHDNHCNN FMFNLCNCJEI, [In] ANKJIJJHKCP HHFLOOBHENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2563880", Offset = "0x2562C80", VA = "0x182563880")]
	public static BJJJDBBOKOI FEOBEKOIKMG()
	{
		return default(BJJJDBBOKOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class LDHHLPOKNLN
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct ALBOOMPFONJ : DLGBCGIBMJB<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>, HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x25634A0", Offset = "0x25628A0", VA = "0x1825634A0")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2563460", Offset = "0x2562860", VA = "0x182563460", Slot = "4")]
		public AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> BAPPKCJHPNJ(int EAHKFAJBNDN)
		{
			return default(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500")]
		public bool JCPEEMKBPPD(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "5")]
		private bool EPIBMNIAFEA(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2563490", Offset = "0x2562890", VA = "0x182563490", Slot = "6")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> IFBCKFKDGGL(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct CEGDMIJGNAF : JBHKPIHGADG<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>, HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x25647C0", Offset = "0x2563BC0", VA = "0x1825647C0")]
		public LDIDKHKLAFM<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>> KIJJMLGBDFE(int HJMOELCIOOJ, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2564840", Offset = "0x2563C40", VA = "0x182564840")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x25648F0", Offset = "0x2563CF0", VA = "0x1825648F0", Slot = "6")]
		public void JNKGPALNEEF(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>> BMKDAHEBDHE, AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x25647C0", Offset = "0x2563BC0", VA = "0x1825647C0", Slot = "4")]
		private LDIDKHKLAFM<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>> BKFPHCLEIOI(int HJMOELCIOOJ, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2564830", Offset = "0x2563C30", VA = "0x182564830", Slot = "5")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> GMAMCLJAEKE(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct MIMBHIMCJJJ : DLGBCGIBMJB<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>, HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x25697D0", Offset = "0x2568BD0", VA = "0x1825697D0")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2569790", Offset = "0x2568B90", VA = "0x182569790", Slot = "4")]
		public AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> BAPPKCJHPNJ(int EAHKFAJBNDN)
		{
			return default(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500")]
		public bool JCPEEMKBPPD(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "5")]
		private bool FFFMHBAODBO(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x25697C0", Offset = "0x2568BC0", VA = "0x1825697C0", Slot = "6")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> DDMFLGOPOFE(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct BBAEGFDKOJJ : JBHKPIHGADG<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>, HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2563690", Offset = "0x2562A90", VA = "0x182563690")]
		public LDIDKHKLAFM<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>> KIJJMLGBDFE(int HJMOELCIOOJ, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2563710", Offset = "0x2562B10", VA = "0x182563710")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x25637C0", Offset = "0x2562BC0", VA = "0x1825637C0", Slot = "6")]
		public void JNKGPALNEEF(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>> BMKDAHEBDHE, AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2563690", Offset = "0x2562A90", VA = "0x182563690", Slot = "4")]
		private LDIDKHKLAFM<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>> CAMCEGIONLK(int HJMOELCIOOJ, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2563700", Offset = "0x2562B00", VA = "0x182563700", Slot = "5")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> DKLHGGJOGAC(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> EAHKFAJBNDN, [In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct NPMOHJBCKOJ : DLGBCGIBMJB<AAFGLNNJOHN<KPIEMJMGBJJ>, HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x256EBF0", Offset = "0x256DFF0", VA = "0x18256EBF0")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(AAFGLNNJOHN<KPIEMJMGBJJ> EAHKFAJBNDN, [In] HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x256EBB0", Offset = "0x256DFB0", VA = "0x18256EBB0", Slot = "4")]
		public AAFGLNNJOHN<KPIEMJMGBJJ> BAPPKCJHPNJ(int EAHKFAJBNDN)
		{
			return default(AAFGLNNJOHN<KPIEMJMGBJJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x256EB30", Offset = "0x256DF30", VA = "0x18256EB30")]
		public bool JCPEEMKBPPD(AAFGLNNJOHN<KPIEMJMGBJJ> EAHKFAJBNDN, [In] HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x256EB30", Offset = "0x256DF30", VA = "0x18256EB30", Slot = "5")]
		private bool AHOPGECFICK(AAFGLNNJOHN<KPIEMJMGBJJ> EAHKFAJBNDN, [In] HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x256EBE0", Offset = "0x256DFE0", VA = "0x18256EBE0", Slot = "6")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> CMNCJNOHMNG(AAFGLNNJOHN<KPIEMJMGBJJ> EAHKFAJBNDN, [In] HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct EENAPMNGCKO : JBHKPIHGADG<AAFGLNNJOHN<KPIEMJMGBJJ>, HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x25650B0", Offset = "0x25644B0", VA = "0x1825650B0")]
		public LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>> KIJJMLGBDFE(int HJMOELCIOOJ, [In] HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2564F00", Offset = "0x2564300", VA = "0x182564F00")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(AAFGLNNJOHN<KPIEMJMGBJJ> EAHKFAJBNDN, [In] HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2564FD0", Offset = "0x25643D0", VA = "0x182564FD0", Slot = "6")]
		public void JNKGPALNEEF(AAFGLNNJOHN<KPIEMJMGBJJ> EAHKFAJBNDN, HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?> BMKDAHEBDHE, AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x25650B0", Offset = "0x25644B0", VA = "0x1825650B0", Slot = "4")]
		private LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>> LBBOKFPKJOM(int HJMOELCIOOJ, [In] HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<AAFGLNNJOHN<KPIEMJMGBJJ>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2565120", Offset = "0x2564520", VA = "0x182565120", Slot = "5")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> NJMACKOBNGC(AAFGLNNJOHN<KPIEMJMGBJJ> EAHKFAJBNDN, [In] HOLDAFBGHPF<KPIEMJMGBJJ, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>?> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct IAPKHIFKGCO : DLGBCGIBMJB<int, LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2565E00", Offset = "0x2565200", VA = "0x182565E00")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> VariableId, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xC38A70", Offset = "0xC37E70", VA = "0x180C38A70", Slot = "4")]
		public int BAPPKCJHPNJ(int EAHKFAJBNDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500")]
		public bool JCPEEMKBPPD(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> VariableId, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "5")]
		private bool LBOLHJHPKLK(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> VariableId, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2565EA0", Offset = "0x25652A0", VA = "0x182565EA0", Slot = "6")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> KEFIJJLCBLB(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> VariableId, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct GGKPICHDOJM : JBHKPIHGADG<int, LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2565C60", Offset = "0x2565060", VA = "0x182565C60")]
		public LDIDKHKLAFM<int> KIJJMLGBDFE(int HJMOELCIOOJ, [In] LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> VariableId, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2565AC0", Offset = "0x2564EC0", VA = "0x182565AC0")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> VariableId, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2565B60", Offset = "0x2564F60", VA = "0x182565B60", Slot = "6")]
		public void JNKGPALNEEF(int EAHKFAJBNDN, LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> VariableId, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>> ByteCodeWriteLocation)> BMKDAHEBDHE, AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2565C60", Offset = "0x2565060", VA = "0x182565C60", Slot = "4")]
		private LDIDKHKLAFM<int> MFLAJKDNLMH(int HJMOELCIOOJ, [In] LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> VariableId, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2565AB0", Offset = "0x2564EB0", VA = "0x182565AB0", Slot = "5")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> DMMIBCPOLKB(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> VariableId, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<EOLBIJIAMFK>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct HGEPJJCBCMO : DLGBCGIBMJB<int, LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2565D60", Offset = "0x2565160", VA = "0x182565D60")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xC38A70", Offset = "0xC37E70", VA = "0x180C38A70", Slot = "4")]
		public int BAPPKCJHPNJ(int EAHKFAJBNDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500")]
		public bool JCPEEMKBPPD(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "5")]
		private bool IGMFHJOCEAM(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2565D50", Offset = "0x2565150", VA = "0x182565D50", Slot = "6")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> FIKPDBANGMH(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct DKGGCNILKNN : JBHKPIHGADG<int, LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2564E80", Offset = "0x2564280", VA = "0x182564E80")]
		public LDIDKHKLAFM<int> KIJJMLGBDFE(int HJMOELCIOOJ, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2564CF0", Offset = "0x25640F0", VA = "0x182564CF0")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2564D90", Offset = "0x2564190", VA = "0x182564D90", Slot = "6")]
		public void JNKGPALNEEF(int EAHKFAJBNDN, LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE, AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2564E80", Offset = "0x2564280", VA = "0x182564E80", Slot = "4")]
		private LDIDKHKLAFM<int> LPFIKGAHHLA(int HJMOELCIOOJ, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2564EF0", Offset = "0x25642F0", VA = "0x182564EF0", Slot = "5")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> PKJIFKKHMLN(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct BPHADMBJJBA : DLGBCGIBMJB<int, LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2564720", Offset = "0x2563B20", VA = "0x182564720")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xC38A70", Offset = "0xC37E70", VA = "0x180C38A70", Slot = "4")]
		public int BAPPKCJHPNJ(int EAHKFAJBNDN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500")]
		public bool JCPEEMKBPPD(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "5")]
		private bool IGMFHJOCEAM(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2564710", Offset = "0x2563B10", VA = "0x182564710", Slot = "6")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> FIKPDBANGMH(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct JIMMPCOBNMA : JBHKPIHGADG<int, LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2566CC0", Offset = "0x25660C0", VA = "0x182566CC0")]
		public LDIDKHKLAFM<int> KIJJMLGBDFE(int HJMOELCIOOJ, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2566B20", Offset = "0x2565F20", VA = "0x182566B20")]
		public AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2566BC0", Offset = "0x2565FC0", VA = "0x182566BC0", Slot = "6")]
		public void JNKGPALNEEF(int EAHKFAJBNDN, LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE, AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2566CC0", Offset = "0x25660C0", VA = "0x182566CC0", Slot = "4")]
		private LDIDKHKLAFM<int> LPFIKGAHHLA(int HJMOELCIOOJ, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(LDIDKHKLAFM<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2566D30", Offset = "0x2566130", VA = "0x182566D30", Slot = "5")]
		private AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> PKJIFKKHMLN(int EAHKFAJBNDN, [In] LDIDKHKLAFM<(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> Target, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ByteCodeWriteLocation)> BMKDAHEBDHE)
		{
			return default(AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct DGCIBEDKNJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> GMOEDGJDPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool FEOFNMOLBKK;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1BE4AB0", Offset = "0x1BE3EB0", VA = "0x181BE4AB0")]
		public DGCIBEDKNJD(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN, bool BPPEGCPDFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2564CE0", Offset = "0x25640E0", VA = "0x182564CE0")]
		public void JNMBAPLKJHM([Out] AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN, [Out] bool BPPEGCPDFLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct OAIJAHDGPMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly AAFGLNNJOHN<KPIEMJMGBJJ> EPANCMGKEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> GMOEDGJDPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool FEOFNMOLBKK;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x256ED70", Offset = "0x256E170", VA = "0x18256ED70")]
		public OAIJAHDGPMF(AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN, bool BPPEGCPDFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x256ED60", Offset = "0x256E160", VA = "0x18256ED60")]
		public void JNMBAPLKJHM([Out] AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN, [Out] bool BPPEGCPDFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x256ED40", Offset = "0x256E140", VA = "0x18256ED40")]
		public void JNMBAPLKJHM([Out] AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN, [Out] AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO, [Out] bool BPPEGCPDFLL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct OHFMDIGJBLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly AAFGLNNJOHN<KPIEMJMGBJJ> EPANCMGKEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> GMOEDGJDPOM;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xBAEB50", Offset = "0xBADF50", VA = "0x180BAEB50")]
		public OHFMDIGJBLM(AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x256ED80", Offset = "0x256E180", VA = "0x18256ED80")]
		public void JNMBAPLKJHM([Out] AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN, [Out] AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2568ED0", Offset = "0x25682D0", VA = "0x182568ED0")]
	public static void MHAKNCNBNPL(this BJJJDBBOKOI JDCFMPOHCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2567FC0", Offset = "0x25673C0", VA = "0x182567FC0")]
	public static void IAOLPGPKFLL(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> JABEIALNILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2568630", Offset = "0x2567A30", VA = "0x182568630")]
	public static void KMLAGJHBGHF(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> JABEIALNILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2567AA0", Offset = "0x2566EA0", VA = "0x182567AA0")]
	public static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>? FKLJMPFHEAN([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2567400", Offset = "0x2566800", VA = "0x182567400")]
	public static AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> AMPLGOENADG([In] this BJJJDBBOKOI JDCFMPOHCEA)
	{
		return default(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2568050", Offset = "0x2567450", VA = "0x182568050")]
	private static void IDNPEKJLDOJ(this BJJJDBBOKOI JDCFMPOHCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x25677E0", Offset = "0x2566BE0", VA = "0x1825677E0")]
	private static AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>? DAKJIOJNJOD([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2568BF0", Offset = "0x2567FF0", VA = "0x182568BF0")]
	public static void LDNHBBMPNDO(this BJJJDBBOKOI JDCFMPOHCEA, [In] LDIDKHKLAFM<IOFBBBHHNMH> OBHJKMJOBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2569500", Offset = "0x2568900", VA = "0x182569500")]
	public static EHHPKHHJDEH.KIOFCPABEOD OJFDAIKJJAN([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN)
	{
		return default(EHHPKHHJDEH.KIOFCPABEOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2568400", Offset = "0x2567800", VA = "0x182568400")]
	public static CMNAKGAJECJ<byte> JAJBALHBPHK([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN)
	{
		return default(CMNAKGAJECJ<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2568540", Offset = "0x2567940", VA = "0x182568540")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KIAEMIFMIME([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2568A70", Offset = "0x2567E70", VA = "0x182568A70")]
	public static GJIJKFCGDLH LAFANGHNEEN([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN)
	{
		return default(GJIJKFCGDLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x347A490", Offset = "0x3479890", VA = "0x18347A490")]
	private static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> JEAAAELCFKA<TMJoin>(this BJJJDBBOKOI JDCFMPOHCEA, EHHPKHHJDEH.KIOFCPABEOD CJNJJHGCMNP, AAFGLNNJOHN<TMJoin> JEDMOOBIPEE) where TMJoin : EHHPKHHJDEH.OKNJCNHOGMJ
	{
		return default(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2568300", Offset = "0x2567700", VA = "0x182568300")]
	public static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> IMPHMFEBMKM(this BJJJDBBOKOI JDCFMPOHCEA, bool NCBAJNLNANA)
	{
		return default(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2567B60", Offset = "0x2566F60", VA = "0x182567B60")]
	public static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> GBNMMLPMIHL(this BJJJDBBOKOI JDCFMPOHCEA, CMNAKGAJECJ<byte> HECJPBMFJGG)
	{
		return default(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x25693B0", Offset = "0x25687B0", VA = "0x1825693B0")]
	public static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> ODEOEOCFGOC(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> FGFHFMAAPCG)
	{
		return default(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2569430", Offset = "0x2568830", VA = "0x182569430")]
	public static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> OEFNGMDABKB(this BJJJDBBOKOI JDCFMPOHCEA, int IKNLPEMHPGP)
	{
		return default(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2567EC0", Offset = "0x25672C0", VA = "0x182567EC0")]
	public static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> HEBIIGHLHMC(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OBJDIELFEEG)
	{
		return default(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x347BD40", Offset = "0x347B140", VA = "0x18347BD40")]
	private static AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD> OMJPNCFFEAN<TMJoin>(this BJJJDBBOKOI JDCFMPOHCEA, LCFHNJGJDNO.HHMEJDLHMPF CJNJJHGCMNP, AAFGLNNJOHN<TMJoin> JEDMOOBIPEE) where TMJoin : LCFHNJGJDNO.HGIMGOGLHGK
	{
		return default(AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x25673C0", Offset = "0x25667C0", VA = "0x1825673C0")]
	public static AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD> AMLPDKLBLKO(this BJJJDBBOKOI JDCFMPOHCEA)
	{
		return default(AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2567900", Offset = "0x2566D00", VA = "0x182567900")]
	public static AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD> EEKLCFMPLBP(this BJJJDBBOKOI JDCFMPOHCEA)
	{
		return default(AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x25692F0", Offset = "0x25686F0", VA = "0x1825692F0")]
	public static AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD> MNAMHBCIDHN(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> AIGBMOACGPD)
	{
		return default(AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x25694B0", Offset = "0x25688B0", VA = "0x1825694B0")]
	public static AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD> OIGLBKBJGGA(this BJJJDBBOKOI JDCFMPOHCEA)
	{
		return default(AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2568D60", Offset = "0x2568160", VA = "0x182568D60")]
	public static AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD> LGOOJOHAJEF(this BJJJDBBOKOI JDCFMPOHCEA)
	{
		return default(AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2567F40", Offset = "0x2567340", VA = "0x182567F40")]
	public static FBBMGEKBAEG.PDNKFMLMDFA HGJDDDLMFDK([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED> DDAKJGFIEFN)
	{
		return default(FBBMGEKBAEG.PDNKFMLMDFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2569370", Offset = "0x2568770", VA = "0x182569370")]
	public static INCPBLHJHCJ<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>, BKNIIOFGLIL<FBBMGEKBAEG.CBCIMGBEMLP>> NFAOJENKION([In] this BJJJDBBOKOI JDCFMPOHCEA)
	{
		return default(INCPBLHJHCJ<AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>, BKNIIOFGLIL<FBBMGEKBAEG.CBCIMGBEMLP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2568700", Offset = "0x2567B00", VA = "0x182568700")]
	public static AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> KOFJFEPMHNM([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED> DDAKJGFIEFN)
	{
		return default(AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2567A20", Offset = "0x2566E20", VA = "0x182567A20")]
	public static FBBMGEKBAEG.CKJDGHLCMPD FEFPIBLKDNP([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> MDLEBAMNKKE)
	{
		return default(FBBMGEKBAEG.CKJDGHLCMPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2568380", Offset = "0x2567780", VA = "0x182568380")]
	public static FBBMGEKBAEG.CKJDGHLCMPD IOBIFICFAFI(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> MDLEBAMNKKE)
	{
		return default(FBBMGEKBAEG.CKJDGHLCMPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x347A540", Offset = "0x3479940", VA = "0x18347A540")]
	private static AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED> KIOKKDFHJFJ<TMJoin>(this BJJJDBBOKOI JDCFMPOHCEA, FBBMGEKBAEG.PDNKFMLMDFA CJNJJHGCMNP, AAFGLNNJOHN<TMJoin> JEDMOOBIPEE) where TMJoin : FBBMGEKBAEG.PHCLEEHEFOJ
	{
		return default(AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x25675C0", Offset = "0x25669C0", VA = "0x1825675C0")]
	public static (AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>) CEPCBGAEEEK(this BJJJDBBOKOI JDCFMPOHCEA)
	{
		return default((AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x25695E0", Offset = "0x25689E0", VA = "0x1825695E0")]
	public static (AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>) PPBKDLBHOGM(this BJJJDBBOKOI JDCFMPOHCEA)
	{
		return default((AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x25684F0", Offset = "0x25678F0", VA = "0x1825684F0")]
	public static AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED> JBDBNGDPBMD(this BJJJDBBOKOI JDCFMPOHCEA)
	{
		return default(AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2568B60", Offset = "0x2567F60", VA = "0x182568B60")]
	public static void LDHBIDODPDE(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP> MDLEBAMNKKE, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> JNMCGMMHFBO, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>> DDEPKGDBJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x347A5E0", Offset = "0x34799E0", VA = "0x18347A5E0")]
	public static DGCIBEDKNJD KNOOMAOLFEM<TDeps, TStateSys>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO) where TDeps : ODBLNDPDEIF<TStateSys>
	{
		return default(DGCIBEDKNJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x347B4D0", Offset = "0x347A8D0", VA = "0x18347B4D0")]
	public static OAIJAHDGPMF MKKOOKKGHMN<TDeps, TStateSys>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, int HAONHOPHKAF) where TDeps : ODBLNDPDEIF<TStateSys>
	{
		return default(OAIJAHDGPMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3479F50", Offset = "0x3479350", VA = "0x183479F50")]
	public static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>? BAIDCMNGNBP<TDeps, TStateSys>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, [In] ReadOnlySpan<int> EGOMPLJFNDP, [In] Span<OHFMDIGJBLM> MEFCABABIEN) where TDeps : ODBLNDPDEIF<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x347B770", Offset = "0x347AB70", VA = "0x18347B770")]
	public static AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD> OHHHACBBGPB<TDeps, TStateSys>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP) where TDeps : ODBLNDPDEIF<TStateSys>
	{
		return default(AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2567BF0", Offset = "0x2566FF0", VA = "0x182567BF0")]
	public static GANFCKFDIJB.DFGPGAGDJCH GHCMFADJNDJ([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KGHCKLKGJKM)
	{
		return default(GANFCKFDIJB.DFGPGAGDJCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2567CE0", Offset = "0x25670E0", VA = "0x182567CE0")]
	public static GANFCKFDIJB.GBMLAOIKHAJ GIHMJFPDNPM([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KGHCKLKGJKM)
	{
		return default(GANFCKFDIJB.GBMLAOIKHAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2567DD0", Offset = "0x25671D0", VA = "0x182567DD0")]
	public static GANFCKFDIJB.CKBPBEMFOFL HCIFCADKFCK([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KGHCKLKGJKM)
	{
		return default(GANFCKFDIJB.CKBPBEMFOFL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x25688E0", Offset = "0x2567CE0", VA = "0x1825688E0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> LADCDLAOOAL(this BJJJDBBOKOI JDCFMPOHCEA, int? HJECGODGNIG, string OMOOEGOLALI)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x25674D0", Offset = "0x25668D0", VA = "0x1825674D0")]
	public static GANFCKFDIJB.CHEMOKCKPNP BPKKPADGNLN([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KGHCKLKGJKM)
	{
		return default(GANFCKFDIJB.CHEMOKCKPNP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2567770", Offset = "0x2566B70", VA = "0x182567770")]
	public static GANFCKFDIJB.DMKMGOGPHLD CIHNCIMLNEA([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KGHCKLKGJKM)
	{
		return default(GANFCKFDIJB.DMKMGOGPHLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2567460", Offset = "0x2566860", VA = "0x182567460")]
	public static int? BJDGCFOFHDP([In] this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KGHCKLKGJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x347A390", Offset = "0x3479790", VA = "0x18347A390")]
	private static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> BGEJEIHJICD<TMJoin>(this BJJJDBBOKOI JDCFMPOHCEA, int? HJECGODGNIG, GANFCKFDIJB.DMKMGOGPHLD CJNJJHGCMNP, AAFGLNNJOHN<TMJoin> JEDMOOBIPEE) where TMJoin : GANFCKFDIJB.DNEEBHMEBCH
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2567110", Offset = "0x2566510", VA = "0x182567110")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> AHHMADLNPCJ(this BJJJDBBOKOI JDCFMPOHCEA, int? HJECGODGNIG, AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED> DDAKJGFIEFN, int EAHKFAJBNDN)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x25678A0", Offset = "0x2566CA0", VA = "0x1825678A0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> DCFOEBGFEOI(this BJJJDBBOKOI JDCFMPOHCEA, int? HJECGODGNIG)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x25691A0", Offset = "0x25685A0", VA = "0x1825691A0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> MHLLHNPKFOC(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>? FKNMMJEILOJ, int? HJECGODGNIG)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2568DB0", Offset = "0x25681B0", VA = "0x182568DB0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> LNLHDJJFKJL(this BJJJDBBOKOI JDCFMPOHCEA, int? HJECGODGNIG, int EAHKFAJBNDN)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2569580", Offset = "0x2568980", VA = "0x182569580")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> PFPDGHLAGBB(this BJJJDBBOKOI JDCFMPOHCEA, int? HJECGODGNIG)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x25681C0", Offset = "0x25675C0", VA = "0x1825681C0")]
	public static void ILKDODNIDAO(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OBJDIELFEEG, AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED> DDAKJGFIEFN, int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x25671C0", Offset = "0x25665C0", VA = "0x1825671C0")]
	public static void AKKNGPHFKOO(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OBJDIELFEEG, int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2567950", Offset = "0x2566D50", VA = "0x182567950")]
	public static void FBIPNEIFNII(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OBJDIELFEEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2568E40", Offset = "0x2568240", VA = "0x182568E40")]
	public static void MBFBOLOLGJJ(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> MOCLCNOAHKF, AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> HAGCDOBPGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x25672F0", Offset = "0x25666F0", VA = "0x1825672F0")]
	public static void ALKGIGBCDPK(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OBJDIELFEEG, AAFGLNNJOHN<PNOOFANHHGG<NFNCFOKAJAC>> DGPEBKGHHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x347B400", Offset = "0x347A800", VA = "0x18347B400")]
	public static void LAINIDIIFHJ<M>(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OBJDIELFEEG, AAFGLNNJOHN<PNOOFANHHGG<LKCLNJGFCJN<M>>> DGPEBKGHHHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface ODBLNDPDEIF<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AAFGLNNJOHN<JAOIAFOAMDK> OKHJOMIGAAE(TStateSys GNOAOBDBNPB);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AAFGLNNJOHN<JAOIAFOAMDK> HIHJHHGOLLL(TStateSys GNOAOBDBNPB);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AAFGLNNJOHN<JAOIAFOAMDK> PMPAMBPPMLD(TStateSys GNOAOBDBNPB);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AAFGLNNJOHN<JAOIAFOAMDK> PDPKCNPAEJA(TStateSys GNOAOBDBNPB);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD> HOCDBOOGMJH(TStateSys GNOAOBDBNPB, BJJJDBBOKOI FJEAFAFKFMM, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> GPLCLLIANIB(TStateSys GNOAOBDBNPB, BJJJDBBOKOI FJEAFAFKFMM, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int EJIGJNMKECL(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AAFGLNNJOHN<OECNLCLGMED> DNIIGDONNKF(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO, int JLLMELNAAHA);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	OGLNNMIENEH KNJFPICKKMK(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GEMCEPEAKEP(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int KGNIOENFGBK(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CMNAKGAJECJ<byte> JBPPMIBPFCH(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(CMNAKGAJECJ<byte>, AAFGLNNJOHN<JAOIAFOAMDK>) FHDDKNOFJAB(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<KPIEMJMGBJJ> FAEFIHLMPDO);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int GFHCJBHEPHP(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AAFGLNNJOHN<KPIEMJMGBJJ> JFBDBLBPPDP(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<OECNLCLGMED> HFCCPEEKCLP, int HAONHOPHKAF);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AAFGLNNJOHN<KPIEMJMGBJJ> OJCADCOOFIJ(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, AAFGLNNJOHN<MOHGMBIPFPM> MEGMENINLOE, int HAONHOPHKAF);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int JOBIOAJDMEF(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? BPGNPOBABHK(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, int EAHKFAJBNDN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int HFMOINDPJFI(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? HNICFBODEJJ(TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA, int EAHKFAJBNDN);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NCKGLBBALIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x352F760", Offset = "0x352EB60", VA = "0x18352F760")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH?> GJOMLMMHLFG<T, TOpInput, TOpOutput>(this BJJJDBBOKOI JDCFMPOHCEA, T CLHNCHKFPON, T KMNANLEEDKO, int DBOIMKIJPGH, IntPtr PDMAGOJMJEB)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x352DBF0", Offset = "0x352CFF0", VA = "0x18352DBF0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH?> BABBHFJLLPA<T, TOpInput, TOpOutput>(this BJJJDBBOKOI JDCFMPOHCEA, T CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO, int DBOIMKIJPGH, IntPtr PDMAGOJMJEB)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x352F5F0", Offset = "0x352E9F0", VA = "0x18352F5F0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH?> GECMNHDLDPN<TOpInput, TOpOutput>(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO, int DBOIMKIJPGH, IntPtr PDMAGOJMJEB)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x256D0B0", Offset = "0x256C4B0", VA = "0x18256D0B0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KIKLOAHAIBK(this BJJJDBBOKOI JDCFMPOHCEA, float GLOEBIACMJE, float HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x256C040", Offset = "0x256B440", VA = "0x18256C040")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HLIEMKONGCC(this BJJJDBBOKOI JDCFMPOHCEA, float GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x256DE00", Offset = "0x256D200", VA = "0x18256DE00")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> NHLNHGEEGFE(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x256B260", Offset = "0x256A660", VA = "0x18256B260")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> EGKAHFCNOIB(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, int HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x256E910", Offset = "0x256DD10", VA = "0x18256E910")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> PKKNJADHMEA(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2569E00", Offset = "0x2569200", VA = "0x182569E00")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> AEGOGAGBEDD(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x256C590", Offset = "0x256B990", VA = "0x18256C590")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> JDCHBGALAPH(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, int HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2569880", Offset = "0x2568C80", VA = "0x182569880")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> AANNBLNCEHI(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x256BB90", Offset = "0x256AF90", VA = "0x18256BB90")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GIKEKDCKEPG(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x256A380", Offset = "0x2569780", VA = "0x18256A380")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> BLMDHACEEMF(this BJJJDBBOKOI JDCFMPOHCEA, int CLHNCHKFPON, int KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x256A6A0", Offset = "0x2569AA0", VA = "0x18256A6A0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CBBIFBNHHGA(this BJJJDBBOKOI JDCFMPOHCEA, int CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2569FE0", Offset = "0x25693E0", VA = "0x182569FE0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> ANPNNOGICIP(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x256EA30", Offset = "0x256DE30", VA = "0x18256EA30")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> POAPJCCKEBL(this BJJJDBBOKOI JDCFMPOHCEA, float CLHNCHKFPON, float KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x256BDD0", Offset = "0x256B1D0", VA = "0x18256BDD0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GOPBHAPHIHD(this BJJJDBBOKOI JDCFMPOHCEA, float CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x256D1B0", Offset = "0x256C5B0", VA = "0x18256D1B0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> LEOLNAIKGOC(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x256D370", Offset = "0x256C770", VA = "0x18256D370")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> MAIFICMPGOB(this BJJJDBBOKOI JDCFMPOHCEA, int CLHNCHKFPON, int KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x256B480", Offset = "0x256A880", VA = "0x18256B480")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> EMMMFIIPPFF(this BJJJDBBOKOI JDCFMPOHCEA, int CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x256E890", Offset = "0x256DC90", VA = "0x18256E890")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> PJPBAHMPFHK(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x256AE60", Offset = "0x256A260", VA = "0x18256AE60")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> DONGAADJFGM(this BJJJDBBOKOI JDCFMPOHCEA, float CLHNCHKFPON, float KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x256DA30", Offset = "0x256CE30", VA = "0x18256DA30")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> MOENCDPNCHD(this BJJJDBBOKOI JDCFMPOHCEA, float CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x256AA00", Offset = "0x2569E00", VA = "0x18256AA00")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CLEGKEFKHJN(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x256B500", Offset = "0x256A900", VA = "0x18256B500")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> FBCGJELBIMO(this BJJJDBBOKOI JDCFMPOHCEA, int CLHNCHKFPON, int KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x256ACE0", Offset = "0x256A0E0", VA = "0x18256ACE0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> DJFKEIENLEL(this BJJJDBBOKOI JDCFMPOHCEA, int CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x256C350", Offset = "0x256B750", VA = "0x18256C350")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> IGPIFPHEBAO(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x256C510", Offset = "0x256B910", VA = "0x18256C510")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> IJOAMAJKPPC(this BJJJDBBOKOI JDCFMPOHCEA, float CLHNCHKFPON, float KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x256D2F0", Offset = "0x256C6F0", VA = "0x18256D2F0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> LPFGPMBIHCA(this BJJJDBBOKOI JDCFMPOHCEA, float CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x256DAB0", Offset = "0x256CEB0", VA = "0x18256DAB0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> NAGCNFJNGNK(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2569BD0", Offset = "0x2568FD0", VA = "0x182569BD0")]
	public static AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> ACPBDGCJEDD(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN)
	{
		return default(AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x256D030", Offset = "0x256C430", VA = "0x18256D030")]
	public static AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> JPHGMDHNAFP(this BJJJDBBOKOI JDCFMPOHCEA, int KBGCCIOIGBD)
	{
		return default(AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x256DF40", Offset = "0x256D340", VA = "0x18256DF40")]
	public static AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> NNCNDEBNFIH(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KBGCCIOIGBD)
	{
		return default(AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x256DB30", Offset = "0x256CF30", VA = "0x18256DB30")]
	public static AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> NEFOCPAKJJF(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> NDJJNPIHKNN)
	{
		return default(AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x256E480", Offset = "0x256D880", VA = "0x18256E480")]
	public static AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> OOJKPKFEKNJ(this BJJJDBBOKOI JDCFMPOHCEA, int KBGCCIOIGBD)
	{
		return default(AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2569F40", Offset = "0x2569340", VA = "0x182569F40")]
	public static AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> AGCLKHCOAGJ(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KBGCCIOIGBD)
	{
		return default(AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x256C690", Offset = "0x256BA90", VA = "0x18256C690")]
	public static (AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>) JFIKBJGDPCO(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<OPFEFJJJJKO> BBCCFKJEDAB, [In] ReadOnlySpan<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> KAACKOKPHBP, [In] ReadOnlySpan<int?> PNOFOBKOGEB, [In] Span<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> LGAHGGNHBEH)
	{
		return default((AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x256CAD0", Offset = "0x256BED0", VA = "0x18256CAD0")]
	public static (AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>) JFNOKFKJBFE(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<CEJJGGEHIJG> NFFAOGLAMPM, [In] ReadOnlySpan<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> KAACKOKPHBP, [In] ReadOnlySpan<int?> PNOFOBKOGEB, [In] Span<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> LGAHGGNHBEH)
	{
		return default((AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3530410", Offset = "0x352F810", VA = "0x183530410")]
	public static (AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>, AAFGLNNJOHN<PNOOFANHHGG<JAOIAFOAMDK>>, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>, AAFGLNNJOHN<PNOOFANHHGG<TMarker>>, AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>) NGICHAPKMNI<TMarker>(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<JAOIAFOAMDK> HMBKOGFKGAE, [In] ReadOnlySpan<byte> GIDGOODJFLJ)
	{
		return default((AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>, AAFGLNNJOHN<PNOOFANHHGG<JAOIAFOAMDK>>, AAFGLNNJOHN<PNOOFANHHGG<GDGHBCNBBGI>>, AAFGLNNJOHN<PNOOFANHHGG<TMarker>>, AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x256A240", Offset = "0x2569640", VA = "0x18256A240")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> BGFNDACDPJG(this BJJJDBBOKOI JDCFMPOHCEA, int AFANAFIDJJF, [Optional] AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>? DGMCFDFIOFE)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x256C260", Offset = "0x256B660", VA = "0x18256C260")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> IFMCNCGDCCN(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> AFANAFIDJJF, [Optional] AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>? DGMCFDFIOFE)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2569AE0", Offset = "0x2568EE0", VA = "0x182569AE0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> ABHFHBMGLHK(this BJJJDBBOKOI JDCFMPOHCEA, [In] ReadOnlySpan<byte> AFANAFIDJJF, [Optional] AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>? DGMCFDFIOFE)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x256AA80", Offset = "0x2569E80", VA = "0x18256AA80")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> COBPBPEEHBP(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> AFANAFIDJJF, int IBMHAIHIDJJ, [Optional] AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>? DGMCFDFIOFE)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x256AD60", Offset = "0x256A160", VA = "0x18256AD60")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> DLAEJHOFCPO(this BJJJDBBOKOI JDCFMPOHCEA, float GLOEBIACMJE, float HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x256DCE0", Offset = "0x256D0E0", VA = "0x18256DCE0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> NENJOIJMPAG(this BJJJDBBOKOI JDCFMPOHCEA, float GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x256A8C0", Offset = "0x2569CC0", VA = "0x18256A8C0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CDJFJLMEBGP(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x256BA90", Offset = "0x256AE90", VA = "0x18256BA90")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GHJBKIFHIAD(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, int HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x256E640", Offset = "0x256DA40", VA = "0x18256E640")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> PFNFNJCNBJC(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x256ABA0", Offset = "0x2569FA0", VA = "0x18256ABA0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> DGOLIIBAACP(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2569D80", Offset = "0x2569180", VA = "0x182569D80")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> ADKDFPKIDGJ(this BJJJDBBOKOI JDCFMPOHCEA, int CLHNCHKFPON, int KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x256A300", Offset = "0x2569700", VA = "0x18256A300")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> BIGGKCKBHMO(this BJJJDBBOKOI JDCFMPOHCEA, int CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x256B580", Offset = "0x256A980", VA = "0x18256B580")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> FEMAKMBDCAD(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CLHNCHKFPON, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMNANLEEDKO)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x256B850", Offset = "0x256AC50", VA = "0x18256B850")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> FPCKOCAJHMF(this BJJJDBBOKOI JDCFMPOHCEA, float GLOEBIACMJE, float HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x256E760", Offset = "0x256DB60", VA = "0x18256E760")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> PJDNPGENLCC(this BJJJDBBOKOI JDCFMPOHCEA, float GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x256DFE0", Offset = "0x256D3E0", VA = "0x18256DFE0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OAPCBNLBHAO(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x256A5A0", Offset = "0x25699A0", VA = "0x18256A5A0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CABAFIMDNNB(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, int HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x256B360", Offset = "0x256A760", VA = "0x18256B360")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> EMDOJCNEKKJ(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x256E120", Offset = "0x256D520", VA = "0x18256E120")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OEBGICALECO(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x256C020", Offset = "0x256B420", VA = "0x18256C020")]
	public static AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>> HBNIBALBMPO(this BJJJDBBOKOI JDCFMPOHCEA)
	{
		return default(AAFGLNNJOHN<PNOOFANHHGG<PNOOFANHHGG<OBDNNAELJJC>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x256E380", Offset = "0x256D780", VA = "0x18256E380")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OMHBHOODCIA(this BJJJDBBOKOI JDCFMPOHCEA, float GLOEBIACMJE, float HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x256BF00", Offset = "0x256B300", VA = "0x18256BF00")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HBMKBKOFICD(this BJJJDBBOKOI JDCFMPOHCEA, float GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x256B600", Offset = "0x256AA00", VA = "0x18256B600")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> FIFGHAEFAKG(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x256A7C0", Offset = "0x2569BC0", VA = "0x18256A7C0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> CBOKAMGPEHO(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, int HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x256A480", Offset = "0x2569880", VA = "0x18256A480")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> BPPPEHHDCLH(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x256B950", Offset = "0x256AD50", VA = "0x18256B950")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GDCNCBEJJCB(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x256C160", Offset = "0x256B560", VA = "0x18256C160")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HPIIBIFOJPP(this BJJJDBBOKOI JDCFMPOHCEA, int KBGCCIOIGBD)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x256D920", Offset = "0x256CD20", VA = "0x18256D920")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> MMBKDFCILDA(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KBGCCIOIGBD)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x256B840", Offset = "0x256AC40", VA = "0x18256B840")]
	public static void FLBLJCKIAAN(this BJJJDBBOKOI JDCFMPOHCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x256D3F0", Offset = "0x256C7F0", VA = "0x18256D3F0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> MBFDACIILEN(this BJJJDBBOKOI JDCFMPOHCEA, float GLOEBIACMJE, float HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x256CF10", Offset = "0x256C310", VA = "0x18256CF10")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> JOJJNKJMHNF(this BJJJDBBOKOI JDCFMPOHCEA, float GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x25699A0", Offset = "0x2568DA0", VA = "0x1825699A0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> AAOALDGJHHP(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x256BCD0", Offset = "0x256B0D0", VA = "0x18256BCD0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GMHJGFDCBKL(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, int HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x256A120", Offset = "0x2569520", VA = "0x18256A120")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> BAHEDJOMKDL(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x256E500", Offset = "0x256D900", VA = "0x18256E500")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OPBKJJOKKKE(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x256AEE0", Offset = "0x256A2E0", VA = "0x18256AEE0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> DPBECPMCHJJ(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> IAKOOKHIIAE, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> BHDPJBEJCJH)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x256B740", Offset = "0x256AB40", VA = "0x18256B740")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> FLAIONHPNNB(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, int HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x256E260", Offset = "0x256D660", VA = "0x18256E260")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OKBLAPPFCFN(this BJJJDBBOKOI JDCFMPOHCEA, int GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x256C3D0", Offset = "0x256B7D0", VA = "0x18256C3D0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> IHFDNNABABF(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> GLOEBIACMJE, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> HONFAPDGDEM)
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x352E1A0", Offset = "0x352D5A0", VA = "0x18352E1A0")]
	public static void CJEAAPJKPNA<TDeps, TState>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TState CEGAGHAOIDD, AAFGLNNJOHN<OPFEFJJJJKO> BBCCFKJEDAB, [In] ReadOnlySpan<AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>> OPNEDMPDAIG, [In] ReadOnlySpan<int?> PNOFOBKOGEB, [In] Span<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> LGAHGGNHBEH, [In] Span<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> BEFBLLDLDJK, [In] ReadOnlySpan<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>?> GFLPFLEICOB) where TDeps : notnull, ODBLNDPDEIF<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x352FE70", Offset = "0x352F270", VA = "0x18352FE70")]
	public static void LJDKLOBHPGF<TDeps, TState>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TState CEGAGHAOIDD, AAFGLNNJOHN<CEJJGGEHIJG> BPHLLBLGCAD, [In] ReadOnlySpan<AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>> BHIEKNPBDLC, [In] ReadOnlySpan<int?> PNOFOBKOGEB, [In] Span<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> LGAHGGNHBEH, [In] Span<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>> BEFBLLDLDJK, [In] ReadOnlySpan<AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>?> GFLPFLEICOB) where TDeps : notnull, ODBLNDPDEIF<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x352FC90", Offset = "0x352F090", VA = "0x18352FC90")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KMPJBODJIPA<TDeps, TState>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TState CEGAGHAOIDD, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> FKNMMJEILOJ, [Optional] AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>? DGMCFDFIOFE) where TDeps : notnull, ODBLNDPDEIF<TState> where TState : notnull
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x352F190", Offset = "0x352E590", VA = "0x18352F190")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> DFNEEOHIHFF<TDeps, TState>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TState CEGAGHAOIDD, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> AIGBMOACGPD, [Optional] AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>? DGMCFDFIOFE) where TDeps : notnull, ODBLNDPDEIF<TState> where TState : notnull
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x352FA60", Offset = "0x352EE60", VA = "0x18352FA60")]
	public static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> HELPCJPNMNJ<TDeps, TStateSys>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TStateSys GNOAOBDBNPB) where TDeps : notnull, ODBLNDPDEIF<TStateSys> where TStateSys : notnull
	{
		return default(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x352DF90", Offset = "0x352D390", VA = "0x18352DF90")]
	public static AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD> BCIEKIDMHLN<TDeps, TStateSys>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TStateSys GNOAOBDBNPB) where TDeps : notnull, ODBLNDPDEIF<TStateSys> where TStateSys : notnull
	{
		return default(AAFGLNNJOHN<LCFHNJGJDNO.PNCPNAJBDFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x256D7F0", Offset = "0x256CBF0", VA = "0x18256D7F0")]
	public static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> MJCBELEPBIA(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> HIJMNCAKGFF, IntPtr KBJONDKELGM, IntPtr EGJEBOAIOFG)
	{
		return default(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x256D4F0", Offset = "0x256C8F0", VA = "0x18256D4F0")]
	public static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> MGEALJBOLIF(this BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> LOHLDKIKANB, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> EDPBNDLIMAG, IntPtr CBAFGLLNKIC, IntPtr IOOLJAKNHEO, IntPtr ADLHOGBNDMO, bool BHOPDHFGPAM)
	{
		return default(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x352E740", Offset = "0x352DB40", VA = "0x18352E740")]
	public static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> CPBFJKDMCFK<TDeps, TState>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TState CEGAGHAOIDD, AAFGLNNJOHN<OPFEFJJJJKO> ABINFCJADBG, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> LOHLDKIKANB, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> EDPBNDLIMAG, int? NGPLECCHPDF, [Optional] IntPtr JDNLHIDAFDK) where TDeps : notnull, ODBLNDPDEIF<TState> where TState : notnull
	{
		return default(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x352E950", Offset = "0x352DD50", VA = "0x18352E950")]
	private static AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> CPBFJKDMCFK<TDeps, TState>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TState CEGAGHAOIDD, AAFGLNNJOHN<OPFEFJJJJKO> ABINFCJADBG, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> LOHLDKIKANB, AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC> EDPBNDLIMAG, int? NGPLECCHPDF) where TDeps : notnull, ODBLNDPDEIF<TState> where TState : notnull
	{
		return default(AAFGLNNJOHN<EHHPKHHJDEH.ODMIPPAJKNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x35307A0", Offset = "0x352FBA0", VA = "0x1835307A0")]
	public static AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OLPOFJMGEHA<TDeps, TState>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TState CEGAGHAOIDD, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> AFANAFIDJJF, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>? DGMCFDFIOFE) where TDeps : notnull, ODBLNDPDEIF<TState> where TState : notnull
	{
		return default(AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3530510", Offset = "0x352F910", VA = "0x183530510")]
	public static void NPHDMKAMPNO<TDeps, TState>(this BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TState CEGAGHAOIDD, int IKJDKOCIAAK) where TDeps : notnull, ODBLNDPDEIF<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct PLGLFINLIDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> LELAHKECAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> FFCFLDKELFM;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xBAEB50", Offset = "0xBADF50", VA = "0x180BAEB50")]
	public PLGLFINLIDB(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> ECLHMCIIKEK, AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> LLONGODBDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x256F0B0", Offset = "0x256E4B0", VA = "0x18256F0B0")]
	public static PLGLFINLIDB FEOBEKOIKMG(AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>> ECLHMCIIKEK)
	{
		return default(PLGLFINLIDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct GANFCKFDIJB
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class DEELCIKAANJ : DNEEBHMEBCH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct DFGPGAGDJCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED> FLCLPJNGHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int MPMCCDHNNEC;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xBAEB50", Offset = "0xBADF50", VA = "0x180BAEB50")]
		public DFGPGAGDJCH(AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED> DDAKJGFIEFN, int EAHKFAJBNDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class IFCIEBJFLEH : DNEEBHMEBCH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct GBMLAOIKHAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int MPMCCDHNNEC;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640")]
		public GBMLAOIKHAJ(int EAHKFAJBNDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class ABIOICKDNKE : DNEEBHMEBCH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct CKBPBEMFOFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED> FLCLPJNGHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int MPMCCDHNNEC;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xBAEB50", Offset = "0xBADF50", VA = "0x180BAEB50")]
		public CKBPBEMFOFL(AAFGLNNJOHN<FBBMGEKBAEG.HCAJLNPPEED> DDAKJGFIEFN, int EAHKFAJBNDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum DMKMGOGPHLD
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
	public sealed class NDOJKMNLPBH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class DNEEBHMEBCH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct FBHGPANLPIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? CMJMOIPNCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public PLGLFINLIDB BKDJJGPIPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public DMKMGOGPHLD JHADKPFHNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AAFGLNNJOHN<DNEEBHMEBCH> EPLMGEKKGNH;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2565560", Offset = "0x2564960", VA = "0x182565560")]
		public FBHGPANLPIE(int? HJECGODGNIG, [In] PLGLFINLIDB GJMENOPDHLB, DMKMGOGPHLD CJNJJHGCMNP, AAFGLNNJOHN<DNEEBHMEBCH> JEDMOOBIPEE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class OEDCJNKNIHH : DNEEBHMEBCH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct CHEMOKCKPNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int MPMCCDHNNEC;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1098640", Offset = "0x1097A40", VA = "0x181098640")]
		public CHEMOKCKPNP(int EAHKFAJBNDN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal NKFOKEKIHKD<NDOJKMNLPBH, FBHGPANLPIE> NGEGHEPOOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal NKFOKEKIHKD<DEELCIKAANJ, DFGPGAGDJCH> NDMKAPBGIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal NKFOKEKIHKD<ABIOICKDNKE, CKBPBEMFOFL> LIBPLENCPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal NKFOKEKIHKD<OEDCJNKNIHH, CHEMOKCKPNP> PKLHNDMEKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal NKFOKEKIHKD<IFCIEBJFLEH, GBMLAOIKHAJ> KJFCLGGNLDJ;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x25658D0", Offset = "0x2564CD0", VA = "0x1825658D0")]
	private GANFCKFDIJB([In] NKFOKEKIHKD<NDOJKMNLPBH, FBHGPANLPIE> EDMOECAGMMB, [In] NKFOKEKIHKD<DEELCIKAANJ, DFGPGAGDJCH> EBJJDJCKPLM, [In] NKFOKEKIHKD<ABIOICKDNKE, CKBPBEMFOFL> GIAOHLCJNOG, [In] NKFOKEKIHKD<OEDCJNKNIHH, CHEMOKCKPNP> CGFIDOOJFJP, [In] NKFOKEKIHKD<IFCIEBJFLEH, GBMLAOIKHAJ> BDCGIKNCEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x25656E0", Offset = "0x2564AE0", VA = "0x1825656E0")]
	public static GANFCKFDIJB FEOBEKOIKMG()
	{
		return default(GANFCKFDIJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class LDAFPPLOKMA
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2567060", Offset = "0x2566460", VA = "0x182567060")]
	public static void MHAKNCNBNPL(this GANFCKFDIJB JDCFMPOHCEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FJFOACNBBOC
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2565580", Offset = "0x2564980", VA = "0x182565580")]
	public static void IKIFLPOJPIB(BJJJDBBOKOI JDCFMPOHCEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct PEKPHDNHCNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, BMCPBJELNAP> DKLIHBFOBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int LOABGIJFBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int HHKJNLJJFAC;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x256F070", Offset = "0x256E470", VA = "0x18256F070")]
	private PEKPHDNHCNN([In] HOLDAFBGHPF<FBBMGEKBAEG.CBCIMGBEMLP, BMCPBJELNAP> HOCGLHMGFLP, int BAKEBHLLBGJ, int JEOMFHOKGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x256EE10", Offset = "0x256E210", VA = "0x18256EE10")]
	public static PEKPHDNHCNN FEOBEKOIKMG()
	{
		return default(PEKPHDNHCNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x256EE80", Offset = "0x256E280", VA = "0x18256EE80")]
	public void MHAKNCNBNPL([In] BJJJDBBOKOI HEPINKPGFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x35C08C0", Offset = "0x35BFCC0", VA = "0x1835C08C0")]
	public static void IKIFLPOJPIB<TDeps, TStateSys>(BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TStateSys GNOAOBDBNPB, AAFGLNNJOHN<IBLJEHJLOFH> JLMDJNDONMA) where TDeps : notnull, ODBLNDPDEIF<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KBKEIAAPLFN
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2566D40", Offset = "0x2566140", VA = "0x182566D40")]
	public static void IKIFLPOJPIB(BJJJDBBOKOI JDCFMPOHCEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct ANKJIJJHKCP
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface HGEMAPFKJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IALPOJOEAOJ(LDIDKHKLAFM<byte> OGGJFKFPLFG, int DIIFHOBEJCF);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct PCOGBIGJHNP : HGEMAPFKJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x256ED90", Offset = "0x256E190", VA = "0x18256ED90", Slot = "4")]
		public void IALPOJOEAOJ(LDIDKHKLAFM<byte> OGGJFKFPLFG, int DIIFHOBEJCF)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct GBMLPECKNPM : HGEMAPFKJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2565A00", Offset = "0x2564E00", VA = "0x182565A00", Slot = "4")]
		public void IALPOJOEAOJ(LDIDKHKLAFM<byte> OGGJFKFPLFG, int DIIFHOBEJCF)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct BLDMCNMHOGO : HGEMAPFKJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2564590", Offset = "0x2563990", VA = "0x182564590", Slot = "4")]
		public void IALPOJOEAOJ(LDIDKHKLAFM<byte> OGGJFKFPLFG, int DIIFHOBEJCF)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct JALGNLEHGBJ : HGEMAPFKJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2565F60", Offset = "0x2565360", VA = "0x182565F60", Slot = "4")]
		public void IALPOJOEAOJ(LDIDKHKLAFM<byte> OGGJFKFPLFG, int DIIFHOBEJCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class NGHJNEIDBNM<TCallProcessorDeps> where TCallProcessorDeps : struct, HGEMAPFKJML
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps JDFKOKOAHAA;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x356C390", Offset = "0x356B790", VA = "0x18356C390")]
		public static int IKIFLPOJPIB<TDeps, TStateSys>(TDeps GKFDJGEMKAB, TStateSys CEGAGHAOIDD, BJJJDBBOKOI HEPINKPGFIG, [In] LDIDKHKLAFM<byte> HNHBJPJPMBM, int CJHGALFGNOG) where TDeps : ODBLNDPDEIF<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private LDIDKHKLAFM<IOFBBBHHNMH> CDPAHMFFIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>> HNIHHLNBJBD;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2563650", Offset = "0x2562A50", VA = "0x182563650")]
	private ANKJIJJHKCP([In] LDIDKHKLAFM<IOFBBBHHNMH> OBHJKMJOBAB, Dictionary<AAFGLNNJOHN<PNOOFANHHGG<OBDNNAELJJC>>, AAFGLNNJOHN<FBBMGEKBAEG.CBCIMGBEMLP>> NOFJKHEENFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2563550", Offset = "0x2562950", VA = "0x182563550")]
	public static ANKJIJJHKCP FEOBEKOIKMG()
	{
		return default(ANKJIJJHKCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2563610", Offset = "0x2562A10", VA = "0x182563610")]
	public void MHAKNCNBNPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3B2D8E0", Offset = "0x3B2CCE0", VA = "0x183B2D8E0")]
	public static void IKIFLPOJPIB<TDeps, TStateSys>(BJJJDBBOKOI JDCFMPOHCEA, TDeps GKFDJGEMKAB, TStateSys GNOAOBDBNPB) where TDeps : ODBLNDPDEIF<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class JFOMHBGLCND
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct NKGOKCKNDGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> OGAEGBJGILN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int ILHIIGCHFAH;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int CAKIFAPGOPM;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int JGPGFKPJGDL;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x25662E0", Offset = "0x25656E0", VA = "0x1825662E0")]
	public static void IKIFLPOJPIB(BJJJDBBOKOI JDCFMPOHCEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2566010", Offset = "0x2565410", VA = "0x182566010")]
	private static void DNDLOGNPADF([In] BJJJDBBOKOI JDCFMPOHCEA, AAFGLNNJOHN<GANFCKFDIJB.NDOJKMNLPBH> KGHCKLKGJKM, LDIDKHKLAFM<byte> HFGGABAPPCM, List<NKGOKCKNDGJ> ENHLONHCMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x25661A0", Offset = "0x25655A0", VA = "0x1825661A0")]
	private static void DNDLOGNPADF(LDIDKHKLAFM<byte> HFGGABAPPCM, int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x25669A0", Offset = "0x2565DA0", VA = "0x1825669A0")]
	private static void JELADJJMCKJ(BJJJDBBOKOI JDCFMPOHCEA, List<NKGOKCKNDGJ> ENHLONHCMHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class NFEAIFPOLJO<TDeps, TIndex, TValues> where TDeps : struct, JBHKPIHGADG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps JDFKOKOAHAA;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4E2CA90", Offset = "0x4E2BE90", VA = "0x184E2CA90")]
	public static void IKIFLPOJPIB([In] LDIDKHKLAFM<IOFBBBHHNMH> OBHJKMJOBAB, int HJMOELCIOOJ, TValues BMKDAHEBDHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JBHKPIHGADG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LDIDKHKLAFM<TIndex> KIJJMLGBDFE(int HJMOELCIOOJ, [In] TValues BMKDAHEBDHE);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(TIndex EAHKFAJBNDN, [In] TValues BMKDAHEBDHE);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JNKGPALNEEF(TIndex EAHKFAJBNDN, TValues BMKDAHEBDHE, AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> KBGCCIOIGBD);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface DLGBCGIBMJB<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex BAPPKCJHPNJ(int EAHKFAJBNDN);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JCPEEMKBPPD(TIndex EAHKFAJBNDN, [In] TValues BMKDAHEBDHE);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AAFGLNNJOHN<PNOOFANHHGG<EOLBIJIAMFK>> JFHEFKOGAEB(TIndex EAHKFAJBNDN, [In] TValues BMKDAHEBDHE);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class NMJFIKJDPHJ<TDeps, TIndex, TValues> where TDeps : struct, DLGBCGIBMJB<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps JDFKOKOAHAA;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4E8A6F0", Offset = "0x4E89AF0", VA = "0x184E8A6F0")]
	public static LDIDKHKLAFM<TIndex> IKIFLPOJPIB(int HJMOELCIOOJ, [In] TValues BMKDAHEBDHE)
	{
		return default(LDIDKHKLAFM<TIndex>);
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
