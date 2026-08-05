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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1DD02D0", Offset = "0x1DCF4D0", VA = "0x181DD02D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PDACODFAKHB
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EIDMPNBJGML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public DKMDKGGKAIH<int> BENJKLOBCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public DKMDKGGKAIH<int> IFKGHKOEAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public int HICIFOCNLKB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8CC0", Offset = "0x1DC7EC0", VA = "0x181DC8CC0")]
	private EIDMPNBJGML([In] DKMDKGGKAIH<int> PHPHMLPOKIO, [In] DKMDKGGKAIH<int> CNKJBCFAJLE, int PIBEGGCKFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8C30", Offset = "0x1DC7E30", VA = "0x181DC8C30")]
	public static EIDMPNBJGML GOMGEEBODDD()
	{
		return default(EIDMPNBJGML);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class NAKFIIECJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFD00", Offset = "0x1DCEF00", VA = "0x181DCFD00")]
	public static void JNJLPFFCJBK(this EIDMPNBJGML KPBGCHDNDLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PHIDMEBOJAH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum KHGJGMEDANN
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		ExternalManagedObjectStack
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class BLIJIKCKOHO : MJDJEABPIGG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct PIOIJEGPCBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public IJMPLGOCAIG<GDDCHBNGCFK> KEFLFFFBNIH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class GDDCHBNGCFK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MJDJEABPIGG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct AEGONJNLCGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public DKMDKGGKAIH<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> BENJKLOBCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public DKMDKGGKAIH<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> IFKGHKOEAJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> NJKICGKNDLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public IJMPLGOCAIG<JLOOKFPFDIM<ACEOCGOLBHF>> AGDFHHADHAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public KHGJGMEDANN FLODIALBBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public IJMPLGOCAIG<MJDJEABPIGG> DKFOAGPCPCA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC7080", Offset = "0x1DC6280", VA = "0x181DC7080")]
		private AEGONJNLCGI([In] DKMDKGGKAIH<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> PHPHMLPOKIO, [In] DKMDKGGKAIH<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> CNKJBCFAJLE, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> LDAPMPANGBK, IJMPLGOCAIG<JLOOKFPFDIM<ACEOCGOLBHF>> BAIPOKEMCOP, KHGJGMEDANN FIAHNAGEPAE, IJMPLGOCAIG<MJDJEABPIGG> FENEMJNGLGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC6FC0", Offset = "0x1DC61C0", VA = "0x181DC6FC0")]
		public static AEGONJNLCGI GOMGEEBODDD(IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> LDAPMPANGBK, KHGJGMEDANN FIAHNAGEPAE)
		{
			return default(AEGONJNLCGI);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal PIEPADPFBKC<GDDCHBNGCFK, AEGONJNLCGI> FKKFHCBDPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal PIEPADPFBKC<BLIJIKCKOHO, PIOIJEGPCBC> FFNOBAPIIHH;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0600", Offset = "0x1DCF800", VA = "0x181DD0600")]
	private PHIDMEBOJAH([In] PIEPADPFBKC<GDDCHBNGCFK, AEGONJNLCGI> IOJCMNMENLD, [In] PIEPADPFBKC<BLIJIKCKOHO, PIOIJEGPCBC> JOGDNDIONIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0520", Offset = "0x1DCF720", VA = "0x181DD0520")]
	public static PHIDMEBOJAH GOMGEEBODDD()
	{
		return default(PHIDMEBOJAH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NMAEFOLLDKF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0280", Offset = "0x1DCF480", VA = "0x181DD0280")]
	public static void JNJLPFFCJBK(this PHIDMEBOJAH.AEGONJNLCGI KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DD00D0", Offset = "0x1DCF2D0", VA = "0x181DD00D0")]
	public static void JNJLPFFCJBK(this PHIDMEBOJAH KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFDD0", Offset = "0x1DCEFD0", VA = "0x181DCFDD0")]
	public static OCNFGMPPOGH<PHIDMEBOJAH.GDDCHBNGCFK> DGIMJPKJEEG([In] this PHIDMEBOJAH KPBGCHDNDLM)
	{
		return default(OCNFGMPPOGH<PHIDMEBOJAH.GDDCHBNGCFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFFB0", Offset = "0x1DCF1B0", VA = "0x181DCFFB0")]
	public static IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> ICDFIHFADEK(this PHIDMEBOJAH KPBGCHDNDLM, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> LDAPMPANGBK)
	{
		return default(IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFE90", Offset = "0x1DCF090", VA = "0x181DCFE90")]
	public static IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> ICBPFBDOFJC(this PHIDMEBOJAH KPBGCHDNDLM, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> LDAPMPANGBK)
	{
		return default(IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFE10", Offset = "0x1DCF010", VA = "0x181DCFE10")]
	public static void GHMJKEFCPOJ(this PHIDMEBOJAH KPBGCHDNDLM, IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> EOHPLEHPKEN, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DHHPKMFLOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFD50", Offset = "0x1DCEF50", VA = "0x181DCFD50")]
	public static void CBECFNGLCKJ(this PHIDMEBOJAH KPBGCHDNDLM, IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> EOHPLEHPKEN, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DHHPKMFLOHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct DPCJLNOPGBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public DKMDKGGKAIH<byte> JKFLBNGIPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public PHIDMEBOJAH BDFOMGHEFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public CGGBMDIIIGA HDMKJIFDGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal Dictionary<string, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> HLMENDEOKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal MHFBEOMNLGO<PPNFJJIMEAG, KLKCBIPAHGO?> BADEOKFENHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal DKMDKGGKAIH<IJMPLGOCAIG<PPNFJJIMEAG>> HBOFCADAIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal MHFBEOMNLGO<DKKGADNFDJB, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>>?> BKNMBBKCOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal DKMDKGGKAIH<(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> VariableId, IJMPLGOCAIG<JLOOKFPFDIM<JKNONLABPBM<AAGAMICAFID>>> ByteCodeWriteLocation, int Offset)> MMIPHCHFHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	internal DKMDKGGKAIH<(IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> Target, IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>> ByteCodeWriteLocation)> IGOJEBLOLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	internal bool HOGPJONDDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	internal ADNOIFFHFMI CEBINGLOAJK;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7CC0", Offset = "0x1DC6EC0", VA = "0x181DC7CC0")]
	private DPCJLNOPGBF([In] DKMDKGGKAIH<byte> EAFPGKFKPKP, [In] PHIDMEBOJAH JLHJAAGBFOO, [In] CGGBMDIIIGA BEDNADLJBIH, [In] MHFBEOMNLGO<PPNFJJIMEAG, KLKCBIPAHGO?> AHDPAHNNNCF, [In] DKMDKGGKAIH<IJMPLGOCAIG<PPNFJJIMEAG>> JLFGELLGDJA, [In] MHFBEOMNLGO<DKKGADNFDJB, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>>?> PJDBBMCBGKF, [In] DKMDKGGKAIH<(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> VariableId, IJMPLGOCAIG<JLOOKFPFDIM<JKNONLABPBM<AAGAMICAFID>>> ByteCodeWriteLocation, int VariableOffset)> NCCMMIMFFPK, [In] DKMDKGGKAIH<(IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> Target, IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>> ByteCodeWriteLocation)> BKAKABIDMKC, bool OFCMILGAHKN, [In] ADNOIFFHFMI PGMFAFFABNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7550", Offset = "0x1DC6750", VA = "0x181DC7550")]
	public static DPCJLNOPGBF GOMGEEBODDD()
	{
		return default(DPCJLNOPGBF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EECFDBMEGKO
{
	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8270", Offset = "0x1DC7470", VA = "0x181DC8270")]
	public static void JNJLPFFCJBK(this DPCJLNOPGBF KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8100", Offset = "0x1DC7300", VA = "0x181DC8100")]
	public static IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> HIMIDLPAPEC(this DPCJLNOPGBF KPBGCHDNDLM)
	{
		return default(IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2637010", Offset = "0x2636210", VA = "0x182637010")]
	public static void AIGNPNKIALL<M>(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DHHPKMFLOHD, IJMPLGOCAIG<JLOOKFPFDIM<JKNONLABPBM<M>>> NDJPDAELBNC, int GIIMOODLBON = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8AA0", Offset = "0x1DC7CA0", VA = "0x181DC8AA0")]
	public static void MBOGPJCGNJN(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> MJBOJGOCOJL, IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>> MNFHDEADECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8BC0", Offset = "0x1DC7DC0", VA = "0x181DC8BC0")]
	public static void PMOGKDDBGJF(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> FAAGGPIHNME, IJMPLGOCAIG<JLOOKFPFDIM<ACEOCGOLBHF>> BAIPOKEMCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8040", Offset = "0x1DC7240", VA = "0x181DC8040")]
	public static void DAFNHPGGHLH(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DHHPKMFLOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8730", Offset = "0x1DC7930", VA = "0x181DC8730")]
	public static void KGNGMIBCHGF(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<PPNFJJIMEAG> MPELNFINDJE, [In] KLKCBIPAHGO EHMKJBKGGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8970", Offset = "0x1DC7B70", VA = "0x181DC8970")]
	public static void KMKEKCPPPBP(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<PPNFJJIMEAG> MPELNFINDJE, [In] KLKCBIPAHGO EHMKJBKGGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1DC7F80", Offset = "0x1DC7180", VA = "0x181DC7F80")]
	public static KLKCBIPAHGO? CDBGOICLGHD([In] this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<PPNFJJIMEAG> MPELNFINDJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x26370F0", Offset = "0x26362F0", VA = "0x1826370F0")]
	public static KLKCBIPAHGO GJCDABMGEJI<TDeps, TStateSys>(this DPCJLNOPGBF KPBGCHDNDLM, TDeps ECDJFINNJIE, TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<DKKGADNFDJB> MPKOHKKPBDB) where TDeps : JJOBFKFEEBJ<TStateSys>
	{
		return default(KLKCBIPAHGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8810", Offset = "0x1DC7A10", VA = "0x181DC8810")]
	private static void KJJKLJONAHG(this DPCJLNOPGBF KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8B30", Offset = "0x1DC7D30", VA = "0x181DC8B30")]
	private static IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>>? PMNMDAGGMEB([In] this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<DKKGADNFDJB> MPKOHKKPBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8480", Offset = "0x1DC7680", VA = "0x181DC8480")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> JOKAPFAHHKG(this DPCJLNOPGBF KPBGCHDNDLM, [In] string NLBAJPAADNH, int KPMNHIPLJAJ)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2637F40", Offset = "0x2637140", VA = "0x182637F40")]
	public static CPJHAKJMFCK OEFENLJMAMN<TDeps, TStateSys>(this DPCJLNOPGBF KPBGCHDNDLM, TDeps ECDJFINNJIE, TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<PPNFJJIMEAG> MPELNFINDJE) where TDeps : JJOBFKFEEBJ<TStateSys>
	{
		return default(CPJHAKJMFCK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct KLKCBIPAHGO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum DEGGFAHDHOC
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Register
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public readonly struct DEBEMOHPBFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> HGKADHCDFIM;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x912360", Offset = "0x911560", VA = "0x180912360")]
		public DEBEMOHPBFC(IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> GMNLMGKDFDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct GFBMGHFFNFD : IEquatable<GFBMGHFFNFD>, IOADHLEGEJM<GFBMGHFFNFD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public ReadOnlyMemory<byte> ENBGCGDEDAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public FJAGDKHDPHN PAEECCCJLGN;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC92D0", Offset = "0x1DC84D0", VA = "0x181DC92D0")]
		private GFBMGHFFNFD([In] ReadOnlyMemory<byte> EHGLENBKLPL, FJAGDKHDPHN OAMDKJBHNON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8FC0", Offset = "0x1DC81C0", VA = "0x181DC8FC0")]
		public static GFBMGHFFNFD MGFJMIFBEGL(bool HLMCHMLFGLN)
		{
			return default(GFBMGHFFNFD);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8F80", Offset = "0x1DC8180", VA = "0x181DC8F80")]
		public static GFBMGHFFNFD IIMLIMMLLJE([In] ReadOnlyMemory<byte> EHGLENBKLPL)
		{
			return default(GFBMGHFFNFD);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8ED0", Offset = "0x1DC80D0", VA = "0x181DC8ED0")]
		public static GFBMGHFFNFD FBBJABOMCBL(int BAKKMCBKPDL)
		{
			return default(GFBMGHFFNFD);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8D10", Offset = "0x1DC7F10", VA = "0x181DC8D10")]
		public static bool CDBCKLPENDN([In] GFBMGHFFNFD KGLNCFAJNGP, [In] GFBMGHFFNFD KINCGEJJBNA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8E60", Offset = "0x1DC8060", VA = "0x181DC8E60", Slot = "4")]
		public bool Equals(GFBMGHFFNFD NFMPGFPPFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8D10", Offset = "0x1DC7F10", VA = "0x181DC8D10")]
		public bool MMFILHONGAG([In] GFBMGHFFNFD NFMPGFPPFKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8D80", Offset = "0x1DC7F80", VA = "0x181DC8D80", Slot = "0")]
		public override bool Equals(object MFLACBLODGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8F20", Offset = "0x1DC8120", VA = "0x181DC8F20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9020", Offset = "0x1DC8220", VA = "0x181DC9020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8D10", Offset = "0x1DC7F10", VA = "0x181DC8D10", Slot = "5")]
		private bool OPIHJIDCBAN([In] GFBMGHFFNFD NFMPGFPPFKH)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct NKKBCGHBIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public readonly IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> FIKIACHLIKI;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x912360", Offset = "0x911560", VA = "0x180912360")]
		public NKKBCGHBIGE(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DHHPKMFLOHD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly DEBEMOHPBFC AOEDBMFBHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly GFBMGHFFNFD GFEOJGAGFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly NKKBCGHBIGE MPIFNDMAGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly DEGGFAHDHOC LNPLLJDGKMK;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFCB0", Offset = "0x1DCEEB0", VA = "0x181DCFCB0")]
	private KLKCBIPAHGO(DEBEMOHPBFC IHEEFMLAEBK, [In] GFBMGHFFNFD KEPFLDIKBPG, NKKBCGHBIGE KOOACLHJIAK, DEGGFAHDHOC OKEPMODBMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFA70", Offset = "0x1DCEC70", VA = "0x181DCFA70")]
	public static KLKCBIPAHGO ADONNIMJFCI(IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> GMNLMGKDFDO)
	{
		return default(KLKCBIPAHGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFB50", Offset = "0x1DCED50", VA = "0x181DCFB50")]
	public static KLKCBIPAHGO IHBHGEJAPCN(bool HLMCHMLFGLN)
	{
		return default(KLKCBIPAHGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFC40", Offset = "0x1DCEE40", VA = "0x181DCFC40")]
	public static KLKCBIPAHGO NLFKLOOFHOO([In] ReadOnlyMemory<byte> EHGLENBKLPL)
	{
		return default(KLKCBIPAHGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFAC0", Offset = "0x1DCECC0", VA = "0x181DCFAC0")]
	public static KLKCBIPAHGO BBODMBNNCAL(int BAKKMCBKPDL)
	{
		return default(KLKCBIPAHGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1DCFBE0", Offset = "0x1DCEDE0", VA = "0x181DCFBE0")]
	public static KLKCBIPAHGO INGLMLNPHJI(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> GMKGAIGBJIE)
	{
		return default(KLKCBIPAHGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class EBJCAJADHFH
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0")]
	public static CPJHAKJMFCK MJHKADEPCEI([In] this KLKCBIPAHGO KPBGCHDNDLM)
	{
		return default(CPJHAKJMFCK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct CPJHAKJMFCK
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum AMDOCPCNEGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		OutNode,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Branch
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly AMDOCPCNEGN LNPLLJDGKMK;

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x912360", Offset = "0x911560", VA = "0x180912360")]
	private CPJHAKJMFCK(AMDOCPCNEGN OKEPMODBMGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0")]
	public static CPJHAKJMFCK ADONNIMJFCI()
	{
		return default(CPJHAKJMFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0")]
	public static CPJHAKJMFCK FNDEACBBKAB([In] KLKCBIPAHGO BBEDKDLIKBI)
	{
		return default(CPJHAKJMFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x87EF20", Offset = "0x87E120", VA = "0x18087EF20")]
	public static CPJHAKJMFCK OIPHMJMHJIJ()
	{
		return default(CPJHAKJMFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x934A50", Offset = "0x933C50", VA = "0x180934A50")]
	public static CPJHAKJMFCK BICCEEGDJBC()
	{
		return default(CPJHAKJMFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x927750", Offset = "0x926950", VA = "0x180927750")]
	public static CPJHAKJMFCK NCLAILLMALN()
	{
		return default(CPJHAKJMFCK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JJOBFKFEEBJ<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IJMPLGOCAIG<OOMADKFFFDB> ADHEAEHCLKI(TStateSys NELPHFHNMLP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IJMPLGOCAIG<OOMADKFFFDB> HEMHOPILEAE(TStateSys NELPHFHNMLP);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CPJHAKJMFCK EODOIKCCKAD(TStateSys NELPHFHNMLP, DPCJLNOPGBF JJOEIPCDEKD, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<DKKGADNFDJB> MPKOHKKPBDB);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KLKCBIPAHGO BMKAFEHKAJO(TStateSys NELPHFHNMLP, DPCJLNOPGBF JJOEIPCDEKD, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<PPNFJJIMEAG> MPELNFINDJE);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BMIELKDAJND(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<DKKGADNFDJB> MPKOHKKPBDB);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IJMPLGOCAIG<PPNFJJIMEAG> MHFLNGFPPLC(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<DKKGADNFDJB> MPKOHKKPBDB, int IHLCDHLEEFD);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PDACODFAKHB LEFFNMFLKFO(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<DKKGADNFDJB> MPKOHKKPBDB);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KHLBBNFECHG(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<DKKGADNFDJB> MPKOHKKPBDB);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int KKHGLEBMFON(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<DKKGADNFDJB> MPKOHKKPBDB);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "9")]
	BJKCGAGNJIN<byte> GPGGNAHDGOJ(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<DKKGADNFDJB> MPKOHKKPBDB);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	(BJKCGAGNJIN<byte>, IJMPLGOCAIG<OOMADKFFFDB>) PIBKKDNFGMM(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<DKKGADNFDJB> MPKOHKKPBDB);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int HBPONDKMLPC(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<PPNFJJIMEAG> MPELNFINDJE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IJMPLGOCAIG<DKKGADNFDJB> GLCCAFPBCNI(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, IJMPLGOCAIG<PPNFJJIMEAG> MPELNFINDJE, int LGONANNFKGL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int LLDPEKBIDAC(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	int JNDFGKKECPO(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, int ILNNGHKJMBD);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int ECMHFJFMGNJ(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int LGEBACILKIO(TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, int ILNNGHKJMBD);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JEPEJKHAAPP
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCEAF0", Offset = "0x1DCDCF0", VA = "0x181DCEAF0")]
	public static IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> MMPKIAAGJCG([In] this DPCJLNOPGBF KPBGCHDNDLM)
	{
		return default(IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF550", Offset = "0x1DCE750", VA = "0x181DCF550")]
	private static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> OINLBOHBHED(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> FAAGGPIHNME, int ILNNGHKJMBD, int KPMNHIPLJAJ)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1DCADF0", Offset = "0x1DC9FF0", VA = "0x181DCADF0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> BMPCPHDNMMJ(this DPCJLNOPGBF KPBGCHDNDLM, int ILNNGHKJMBD)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1DCEC70", Offset = "0x1DCDE70", VA = "0x181DCEC70")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> NFLPPDCHHLL(this DPCJLNOPGBF KPBGCHDNDLM, int DKMFLNHKFDF, bool OMDCKJDBIHC)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE2A0", Offset = "0x1DCD4A0", VA = "0x181DCE2A0")]
	private static void LBNJDEPCIAG(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DHHPKMFLOHD, IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> FAAGGPIHNME, int ILNNGHKJMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD5B0", Offset = "0x1DCC7B0", VA = "0x181DCD5B0")]
	public static void JKGGKOLFDJL(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DHHPKMFLOHD, int ILNNGHKJMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB0A0", Offset = "0x1DCA2A0", VA = "0x181DCB0A0")]
	private static void CBECFNGLCKJ(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> FAAGGPIHNME, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> EOHPLEHPKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC1D0", Offset = "0x1DCB3D0", VA = "0x181DCC1D0")]
	private static void GHMJKEFCPOJ(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> FAAGGPIHNME, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> EOHPLEHPKEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27ECCF0", Offset = "0x27EBEF0", VA = "0x1827ECCF0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI?> KCDENIFMDIP<T, TOpInput, TOpOutput>(this DPCJLNOPGBF KPBGCHDNDLM, T KGLNCFAJNGP, T KINCGEJJBNA, int AGLAMDANFLC, IntPtr FDJKDAICALJ)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27ED120", Offset = "0x27EC320", VA = "0x1827ED120")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI?> NKJIFHCNOFO<T, TOpInput, TOpOutput>(this DPCJLNOPGBF KPBGCHDNDLM, T KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA, int AGLAMDANFLC, IntPtr FDJKDAICALJ)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x27EC9B0", Offset = "0x27EBBB0", VA = "0x1827EC9B0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI?> EOHOEKDFICH<TOpInput, TOpOutput>(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA, int AGLAMDANFLC, IntPtr FDJKDAICALJ)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC4F0", Offset = "0x1DCB6F0", VA = "0x181DCC4F0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> HBJHNKLGENC(this DPCJLNOPGBF KPBGCHDNDLM, float DBPPLGPAEKB, float PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE7C0", Offset = "0x1DCD9C0", VA = "0x181DCE7C0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> LPAGFDGMKGA(this DPCJLNOPGBF KPBGCHDNDLM, float DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC350", Offset = "0x1DCB550", VA = "0x181DCC350")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> GOABPIODIAE(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA010", Offset = "0x1DC9210", VA = "0x181DCA010")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> ADMAIFOBHCG(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, int PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1DCAC80", Offset = "0x1DC9E80", VA = "0x181DCAC80")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> BGKLMBPBJGO(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC7B0", Offset = "0x1DCB9B0", VA = "0x181DCC7B0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> HMOADENMIFJ(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9E70", Offset = "0x1DC9070", VA = "0x181DC9E70")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> ACDEANIBCCC(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, KLKCBIPAHGO PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1DCEBD0", Offset = "0x1DCDDD0", VA = "0x181DCEBD0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> NECLGHGKFAM(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, int PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC5A0", Offset = "0x1DCB7A0", VA = "0x181DCC5A0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> HDDAFIMDEAJ(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE4C0", Offset = "0x1DCD6C0", VA = "0x181DCE4C0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> LEEOLFJDLML(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1DCDE10", Offset = "0x1DCD010", VA = "0x181DCDE10")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KFPDNDFOLMP(this DPCJLNOPGBF KPBGCHDNDLM, int KGLNCFAJNGP, int KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB3A0", Offset = "0x1DCA5A0", VA = "0x181DCB3A0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DEEGENCEFPJ(this DPCJLNOPGBF KPBGCHDNDLM, int KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC250", Offset = "0x1DCB450", VA = "0x181DCC250")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> GNIJLLBDOBG(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1DCABD0", Offset = "0x1DC9DD0", VA = "0x181DCABD0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> BGGJEJDHNFC(this DPCJLNOPGBF KPBGCHDNDLM, float KGLNCFAJNGP, float KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF2F0", Offset = "0x1DCE4F0", VA = "0x181DCF2F0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> ODDLBJFMCMN(this DPCJLNOPGBF KPBGCHDNDLM, float KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE5C0", Offset = "0x1DCD7C0", VA = "0x181DCE5C0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> LEOFCHDBPOH(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC980", Offset = "0x1DCBB80", VA = "0x181DCC980")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> IACLCDPHLCJ(this DPCJLNOPGBF KPBGCHDNDLM, int KGLNCFAJNGP, int KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA300", Offset = "0x1DC9500", VA = "0x181DCA300")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> AMLBKIJJLGI(this DPCJLNOPGBF KPBGCHDNDLM, int KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF9F0", Offset = "0x1DCEBF0", VA = "0x181DCF9F0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PKALEOPLKNO(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1DCEB50", Offset = "0x1DCDD50", VA = "0x181DCEB50")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> NAFICFGHILC(this DPCJLNOPGBF KPBGCHDNDLM, float KGLNCFAJNGP, float KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE440", Offset = "0x1DCD640", VA = "0x181DCE440")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> LDFAFAHEMDK(this DPCJLNOPGBF KPBGCHDNDLM, float KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA5D0", Offset = "0x1DC97D0", VA = "0x181DCA5D0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> BEDDCLFKDOO(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB120", Offset = "0x1DCA320", VA = "0x181DCB120")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> CBNDNHDACBO(this DPCJLNOPGBF KPBGCHDNDLM, int KGLNCFAJNGP, int KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBFF0", Offset = "0x1DCB1F0", VA = "0x181DCBFF0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> GFEPJJHIGEN(this DPCJLNOPGBF KPBGCHDNDLM, int KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF450", Offset = "0x1DCE650", VA = "0x181DCF450")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> OGBBKBMAGNH(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD530", Offset = "0x1DCC730", VA = "0x181DCD530")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> JJPHPBLFOLE(this DPCJLNOPGBF KPBGCHDNDLM, float KGLNCFAJNGP, float KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCDF0", Offset = "0x1DCBFF0", VA = "0x181DCCDF0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> IPEDGLACEAF(this DPCJLNOPGBF KPBGCHDNDLM, float KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF3D0", Offset = "0x1DCE5D0", VA = "0x181DCF3D0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> OFLGFKICKHC(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCA00", Offset = "0x1DCBC00", VA = "0x181DCCA00")]
	public static IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>> IEHGJMGODFF(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE0D0", Offset = "0x1DCD2D0", VA = "0x181DCE0D0")]
	public static IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>> LAHGPJAAMIC(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA190", Offset = "0x1DC9390", VA = "0x181DCA190")]
	public static IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>> AMDCCGPDHFO(this DPCJLNOPGBF KPBGCHDNDLM, KLKCBIPAHGO AFCGKMGKPEF)
	{
		return default(IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF800", Offset = "0x1DCEA00", VA = "0x181DCF800")]
	public static IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>> PDPAKJDGDAF(this DPCJLNOPGBF KPBGCHDNDLM, int AFCGKMGKPEF)
	{
		return default(IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC670", Offset = "0x1DCB870", VA = "0x181DCC670")]
	public static IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>> HDJOLLDBIJD(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> AFCGKMGKPEF)
	{
		return default(IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBE80", Offset = "0x1DCB080", VA = "0x181DCBE80")]
	public static IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>> GBPAKMDLNON(this DPCJLNOPGBF KPBGCHDNDLM, KLKCBIPAHGO AFCGKMGKPEF)
	{
		return default(IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD6F0", Offset = "0x1DCC8F0", VA = "0x181DCD6F0")]
	public static IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>> JOFAAJFGLDJ(this DPCJLNOPGBF KPBGCHDNDLM, int AFCGKMGKPEF)
	{
		return default(IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE9A0", Offset = "0x1DCDBA0", VA = "0x181DCE9A0")]
	public static IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>> MDPIBKADIHA(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> AFCGKMGKPEF)
	{
		return default(IJMPLGOCAIG<JLOOKFPFDIM<JLOOKFPFDIM<OEKAJLLNFGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD050", Offset = "0x1DCC250", VA = "0x181DCD050")]
	public static void JGOAAIKNKCD(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<OOMADKFFFDB> CJMOPFKFPEM, [In] ReadOnlySpan<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> CNKJBCFAJLE, [In] ReadOnlySpan<int> IMABJGCCMON, [In] Span<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> FNIDCBOLKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA800", Offset = "0x1DC9A00", VA = "0x181DCA800")]
	public static void BGDNDCAPPGN(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<LIHBHCDGBND> KIAIAGALOGJ, [In] ReadOnlySpan<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> CNKJBCFAJLE, [In] ReadOnlySpan<int> IMABJGCCMON, [In] Span<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> FNIDCBOLKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC070", Offset = "0x1DCB270", VA = "0x181DCC070")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> GFLLBKFECPP(this DPCJLNOPGBF KPBGCHDNDLM, KLKCBIPAHGO PIEEPJDKNFE, [Optional] IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>? HDDBKHCJMKP)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC120", Offset = "0x1DCB320", VA = "0x181DCC120")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> GHIELPMMCMF(this DPCJLNOPGBF KPBGCHDNDLM, int PIEEPJDKNFE, [Optional] IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>? HDDBKHCJMKP, int JMNNKGCOGAF = 0)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE6D0", Offset = "0x1DCD8D0", VA = "0x181DCE6D0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> LIEIDDEEMGL(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PIEEPJDKNFE, [Optional] IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>? HDDBKHCJMKP, int DAPEGJKAKNO = 0, int JMNNKGCOGAF = 0)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA0B0", Offset = "0x1DC92B0", VA = "0x181DCA0B0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> ALJPDHAGFJH(this DPCJLNOPGBF KPBGCHDNDLM, [In] ReadOnlySpan<byte> PIEEPJDKNFE, [Optional] IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>? HDDBKHCJMKP)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9D60", Offset = "0x1DC8F60", VA = "0x181DC9D60")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> ACBILLBMEJN(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PIEEPJDKNFE, int DKMFLNHKFDF, [Optional] IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>? HDDBKHCJMKP)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1DCEA40", Offset = "0x1DCDC40", VA = "0x181DCEA40")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> MIOALICDHDE(this DPCJLNOPGBF KPBGCHDNDLM, float DBPPLGPAEKB, float PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB240", Offset = "0x1DCA440", VA = "0x181DCB240")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> CJHNOBMFKLG(this DPCJLNOPGBF KPBGCHDNDLM, float DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE8A0", Offset = "0x1DCDAA0", VA = "0x181DCE8A0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> MAEMIGPJOFB(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB8E0", Offset = "0x1DCAAE0", VA = "0x181DCB8E0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> FDCBMKACALI(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, int PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1DCAF20", Offset = "0x1DCA120", VA = "0x181DCAF20")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> BNOOFBHKFJG(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB570", Offset = "0x1DCA770", VA = "0x181DCB570")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> EOFLHEMMBGE(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF4D0", Offset = "0x1DCE6D0", VA = "0x181DCF4D0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> OGMEHINNIJO(this DPCJLNOPGBF KPBGCHDNDLM, int KGLNCFAJNGP, int KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF780", Offset = "0x1DCE980", VA = "0x181DCF780")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> OLJHJCJFILO(this DPCJLNOPGBF KPBGCHDNDLM, int KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBAD0", Offset = "0x1DCACD0", VA = "0x181DCBAD0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> FHLMJAODBGM(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBA50", Offset = "0x1DCAC50", VA = "0x181DCBA50")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> FHJLCBDOENJ(this DPCJLNOPGBF KPBGCHDNDLM, float KGLNCFAJNGP, float KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB320", Offset = "0x1DCA520", VA = "0x181DCB320")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> CMBIOKILLBJ(this DPCJLNOPGBF KPBGCHDNDLM, float KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCDEB0", Offset = "0x1DCD0B0", VA = "0x181DCDEB0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KHPGKMIGBKL(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KGLNCFAJNGP, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KINCGEJJBNA)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF880", Offset = "0x1DCEA80", VA = "0x181DCF880")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PFEGPHHDNIA(this DPCJLNOPGBF KPBGCHDNDLM, float DBPPLGPAEKB, float PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCE70", Offset = "0x1DCC070", VA = "0x181DCCE70")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> IPPANBOGAGP(this DPCJLNOPGBF KPBGCHDNDLM, float DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD420", Offset = "0x1DCC620", VA = "0x181DCD420")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> JIPNNIEPHLA(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE030", Offset = "0x1DCD230", VA = "0x181DCE030")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KKKMJPBHACK(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, int PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC8B0", Offset = "0x1DCBAB0", VA = "0x181DCC8B0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> HNLEINGAEHK(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB470", Offset = "0x1DCA670", VA = "0x181DCB470")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DLOMJOOMPDM(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA650", Offset = "0x1DC9850", VA = "0x181DCA650")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> BFIPOEFOLAM(this DPCJLNOPGBF KPBGCHDNDLM, LKLCPOLAEPE ANHBPHNMEAF, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> APKJEBIDCDI)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD770", Offset = "0x1DCC970", VA = "0x181DCD770")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> JOMPJIEADEF(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> ANHBPHNMEAF, float APKJEBIDCDI)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD930", Offset = "0x1DCCB30", VA = "0x181DCD930")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KDOCEACEHDL(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> ANHBPHNMEAF, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> APKJEBIDCDI)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1DCAFF0", Offset = "0x1DCA1F0", VA = "0x181DCAFF0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> BPONICGECII(this DPCJLNOPGBF KPBGCHDNDLM, float DBPPLGPAEKB, float PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCAD0", Offset = "0x1DCBCD0", VA = "0x181DCCAD0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> IFKJEIFPFBH(this DPCJLNOPGBF KPBGCHDNDLM, float DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA4D0", Offset = "0x1DC96D0", VA = "0x181DCA4D0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> BBGNOKDDAJJ(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC710", Offset = "0x1DCB910", VA = "0x181DCC710")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> HJOFOAPNPPL(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, int PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB980", Offset = "0x1DCAB80", VA = "0x181DCB980")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> FFFLKHNPJAI(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB670", Offset = "0x1DCA870", VA = "0x181DCB670")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> EPKMMFPFMDH(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCEDA0", Offset = "0x1DCDFA0", VA = "0x181DCEDA0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> NNCIPOMNAOJ(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> AFCGKMGKPEF)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF930", Offset = "0x1DCEB30", VA = "0x181DCF930")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PINPHBLDLMH(this DPCJLNOPGBF KPBGCHDNDLM, int AFCGKMGKPEF)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1DCAD50", Offset = "0x1DC9F50", VA = "0x181DCAD50")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> BJCBFBFNBPM(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> AFCGKMGKPEF)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBB50", Offset = "0x1DCAD50", VA = "0x181DCBB50")]
	public static void FLLMJHMFKLL(this DPCJLNOPGBF KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBDD0", Offset = "0x1DCAFD0", VA = "0x181DCBDD0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> FONDHEEMFNP(this DPCJLNOPGBF KPBGCHDNDLM, float DBPPLGPAEKB, float PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9C80", Offset = "0x1DC8E80", VA = "0x181DC9C80")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> ABEFFJCEIBH(this DPCJLNOPGBF KPBGCHDNDLM, float DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1DCE1A0", Offset = "0x1DCD3A0", VA = "0x181DCE1A0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> LBLCEMLGBJB(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB840", Offset = "0x1DCAA40", VA = "0x181DCB840")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> FCMJAHLPADF(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, int PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB770", Offset = "0x1DCA970", VA = "0x181DCB770")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> FAGKIFKMDCC(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1DCDF30", Offset = "0x1DCD130", VA = "0x181DCDF30")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KIEFFDBBOEE(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCD10", Offset = "0x1DCBF10", VA = "0x181DCCD10")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> INOALFGOHHD(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> NKIKIMMJFMI)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1DCDB80", Offset = "0x1DCCD80", VA = "0x181DCDB80")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> KFEKAAENFDI(this DPCJLNOPGBF KPBGCHDNDLM, KLKCBIPAHGO DBPPLGPAEKB, KLKCBIPAHGO PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC450", Offset = "0x1DCB650", VA = "0x181DCC450")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> GOBPMHNMFOD(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, int PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF6B0", Offset = "0x1DCE8B0", VA = "0x181DCF6B0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> OKNMGIHPEDB(this DPCJLNOPGBF KPBGCHDNDLM, int DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCF50", Offset = "0x1DCC150", VA = "0x181DCCF50")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> JBKOENPBBLH(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DBPPLGPAEKB, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> PHPLMLCANHO)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1DCEE20", Offset = "0x1DCE020", VA = "0x181DCEE20")]
	public static void NOIMHCJMLPB(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<OOMADKFFFDB> CJMOPFKFPEM, [In] ReadOnlySpan<(KLKCBIPAHGO DataBack, int Size)> GJOOBNKLANK, [In] ReadOnlySpan<int> IMABJGCCMON, [In] Span<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> FNIDCBOLKPN, [In] Span<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> OFDMNBMBKFH, [In] ReadOnlySpan<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>?> CINLMMOIIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBB60", Offset = "0x1DCAD60", VA = "0x181DCBB60")]
	public static void FMNAJHAHBHL(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<LIHBHCDGBND> PFGMNDNOGDD, [In] ReadOnlySpan<(KLKCBIPAHGO DataBack, int Size)> GJOOBNKLANK, [In] ReadOnlySpan<int> IMABJGCCMON, [In] Span<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> FNIDCBOLKPN, [In] Span<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>> OFDMNBMBKFH, [In] ReadOnlySpan<IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>?> CINLMMOIIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCBB0", Offset = "0x1DCBDB0", VA = "0x181DCCBB0")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> IHEHMMAIMKK(this DPCJLNOPGBF KPBGCHDNDLM, [In] KLKCBIPAHGO.GFBMGHFFNFD KEPFLDIKBPG, int DKMFLNHKFDF, [Optional] IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>? HDDBKHCJMKP)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA380", Offset = "0x1DC9580", VA = "0x181DCA380")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> BBGKODAFHBF(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> ICDPGDDEMLH, int DKMFLNHKFDF, [Optional] IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>? HDDBKHCJMKP)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1DCF090", Offset = "0x1DCE290", VA = "0x181DCF090")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> NOOKNCHFMGK(this DPCJLNOPGBF KPBGCHDNDLM, [In] KLKCBIPAHGO DNDBPJMENAJ, int DKMFLNHKFDF, [Optional] IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>? HDDBKHCJMKP)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x27ECE70", Offset = "0x27EC070", VA = "0x1827ECE70")]
	public static KLKCBIPAHGO MOMOAAGNMJN<TStateSys, TDeps>(this DPCJLNOPGBF KPBGCHDNDLM, TStateSys NELPHFHNMLP, TDeps ECDJFINNJIE) where TStateSys : notnull where TDeps : notnull, JJOBFKFEEBJ<TStateSys>
	{
		return default(KLKCBIPAHGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x27ECAB0", Offset = "0x27EBCB0", VA = "0x1827ECAB0")]
	public static CPJHAKJMFCK FHKIIIKIBLM<TStateSys, TDeps>(this DPCJLNOPGBF KPBGCHDNDLM, TStateSys NELPHFHNMLP, TDeps ECDJFINNJIE) where TStateSys : notnull where TDeps : notnull, JJOBFKFEEBJ<TStateSys>
	{
		return default(CPJHAKJMFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB1A0", Offset = "0x1DCA3A0", VA = "0x181DCB1A0")]
	private static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> CGHNOFEEEHI(this DPCJLNOPGBF KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>? ICDPGDDEMLH, int DKMFLNHKFDF)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BEFCCDBEIFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> GKMHODHLDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> ODNJHHKHKOL;

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0xAF2C30", Offset = "0xAF1E30", VA = "0x180AF2C30")]
	public BEFCCDBEIFI(IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> OIGMCDJKDAK, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> DFKBBIGGEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1DC70E0", Offset = "0x1DC62E0", VA = "0x181DC70E0")]
	public static BEFCCDBEIFI GOMGEEBODDD(IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> OIGMCDJKDAK)
	{
		return default(BEFCCDBEIFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CGGBMDIIIGA
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class AJMHEFANMHI : PGGOPONBHHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct CFBIIODEENI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> AJLBKMIKEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int ANPNOFMCDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int AMONKOGAFPF;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1976E90", Offset = "0x1976090", VA = "0x181976E90")]
		public CFBIIODEENI(IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> FAAGGPIHNME, int ILNNGHKJMBD, int KPMNHIPLJAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class EEHMLHJHLGK : PGGOPONBHHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct FKIOEPPGPHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int ANPNOFMCDKC;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x912360", Offset = "0x911560", VA = "0x180912360")]
		public FKIOEPPGPHE(int ILNNGHKJMBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class LNCLAIKGHAL : PGGOPONBHHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct HGMFJLDACPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> AJLBKMIKEMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int ANPNOFMCDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int AMONKOGAFPF;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1976E90", Offset = "0x1976090", VA = "0x181976E90")]
		public HGMFJLDACPF(IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> FAAGGPIHNME, int ILNNGHKJMBD, int KPMNHIPLJAJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum CEMNECKONOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class BGBMCMPGCOI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class PGGOPONBHHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct ADBPMAHJBCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public BEFCCDBEIFI ENOMBBNJEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CEMNECKONOM FLODIALBBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IJMPLGOCAIG<PGGOPONBHHN> DKFOAGPCPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public bool JMJMHBODPOM;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1DC6F60", Offset = "0x1DC6160", VA = "0x181DC6F60")]
		private ADBPMAHJBCP([In] BEFCCDBEIFI DBPDHNEILFD, CEMNECKONOM FIAHNAGEPAE, IJMPLGOCAIG<PGGOPONBHHN> FENEMJNGLGH, bool OMDCKJDBIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1DC6F30", Offset = "0x1DC6130", VA = "0x181DC6F30")]
		public static ADBPMAHJBCP GOMGEEBODDD(IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> OIGMCDJKDAK, CEMNECKONOM FIAHNAGEPAE, IJMPLGOCAIG<PGGOPONBHHN> FENEMJNGLGH, bool OMDCKJDBIHC)
		{
			return default(ADBPMAHJBCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class FCFCINOOJAP : PGGOPONBHHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct IIOEKLJHOPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int AMONKOGAFPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public bool PELMCNIEHKN;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xF0E0D0", Offset = "0xF0D2D0", VA = "0x180F0E0D0")]
		public IIOEKLJHOPM(int KPMNHIPLJAJ, bool DACNKIAKIIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class BKLMIKJKHIJ : PGGOPONBHHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public struct JOJCLIPIMCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int ANPNOFMCDKC;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x912360", Offset = "0x911560", VA = "0x180912360")]
		public JOJCLIPIMCN(int ILNNGHKJMBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class HPLGKGMIGBP : PGGOPONBHHN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct NGCKOOMLAFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int AMONKOGAFPF;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x912360", Offset = "0x911560", VA = "0x180912360")]
		public NGCKOOMLAFP(int KPMNHIPLJAJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal PIEPADPFBKC<BGBMCMPGCOI, ADBPMAHJBCP> FKKFHCBDPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal PIEPADPFBKC<HPLGKGMIGBP, NGCKOOMLAFP> JONPNNAOLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal PIEPADPFBKC<FCFCINOOJAP, IIOEKLJHOPM> DIHGKOMPOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal PIEPADPFBKC<AJMHEFANMHI, CFBIIODEENI> FENOEHNKKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal PIEPADPFBKC<LNCLAIKGHAL, HGMFJLDACPF> HEEJKMCNDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal PIEPADPFBKC<BKLMIKJKHIJ, JOJCLIPIMCN> EPAFCMBGECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal PIEPADPFBKC<EEHMLHJHLGK, FKIOEPPGPHE> GDGCMLJJJDN;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1DC73A0", Offset = "0x1DC65A0", VA = "0x181DC73A0")]
	private CGGBMDIIIGA([In] PIEPADPFBKC<BGBMCMPGCOI, ADBPMAHJBCP> IOJCMNMENLD, [In] PIEPADPFBKC<HPLGKGMIGBP, NGCKOOMLAFP> EKLJCPOKPFE, [In] PIEPADPFBKC<FCFCINOOJAP, IIOEKLJHOPM> MCHHKBBBCFO, [In] PIEPADPFBKC<AJMHEFANMHI, CFBIIODEENI> KDABIPDHNLI, [In] PIEPADPFBKC<LNCLAIKGHAL, HGMFJLDACPF> ADEHDHHJNGF, [In] PIEPADPFBKC<BKLMIKJKHIJ, JOJCLIPIMCN> MBJEEMDGKJD, [In] PIEPADPFBKC<EEHMLHJHLGK, FKIOEPPGPHE> BKNHEPDCCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1DC70F0", Offset = "0x1DC62F0", VA = "0x181DC70F0")]
	public static CGGBMDIIIGA GOMGEEBODDD()
	{
		return default(CGGBMDIIIGA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HHKJBJDGFBG
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0")]
	public static PIEPADPFBKC<CGGBMDIIIGA.BGBMCMPGCOI, CGGBMDIIIGA.ADBPMAHJBCP> JDJFFPMJEIE([In] this CGGBMDIIIGA KPBGCHDNDLM)
	{
		return default(PIEPADPFBKC<CGGBMDIIIGA.BGBMCMPGCOI, CGGBMDIIIGA.ADBPMAHJBCP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1C6B390", Offset = "0x1C6A590", VA = "0x181C6B390")]
	public static PIEPADPFBKC<CGGBMDIIIGA.FCFCINOOJAP, CGGBMDIIIGA.IIOEKLJHOPM> DPJJOKBIHGA([In] this CGGBMDIIIGA KPBGCHDNDLM)
	{
		return default(PIEPADPFBKC<CGGBMDIIIGA.FCFCINOOJAP, CGGBMDIIIGA.IIOEKLJHOPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9590", Offset = "0x1DC8790", VA = "0x181DC9590")]
	public static void JNJLPFFCJBK(this CGGBMDIIIGA KPBGCHDNDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9A40", Offset = "0x1DC8C40", VA = "0x181DC9A40")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> NFLPPDCHHLL(this CGGBMDIIIGA KPBGCHDNDLM, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> OIGMCDJKDAK, int KPMNHIPLJAJ, bool OMDCKJDBIHC)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9930", Offset = "0x1DC8B30", VA = "0x181DC9930")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> MGJHHKLHGMA(this CGGBMDIIIGA KPBGCHDNDLM, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> OIGMCDJKDAK, int KPMNHIPLJAJ, bool DACNKIAKIIN)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9680", Offset = "0x1DC8880", VA = "0x181DC9680")]
	public static void LBNJDEPCIAG(this CGGBMDIIIGA KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DHHPKMFLOHD, IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> FAAGGPIHNME, int ILNNGHKJMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9820", Offset = "0x1DC8A20", VA = "0x181DC9820")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> MECCJHCPMFL(this CGGBMDIIIGA KPBGCHDNDLM, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> OIGMCDJKDAK, IJMPLGOCAIG<PHIDMEBOJAH.GDDCHBNGCFK> FAAGGPIHNME, int ILNNGHKJMBD, int KPMNHIPLJAJ)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9300", Offset = "0x1DC8500", VA = "0x181DC9300")]
	public static IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> BMPCPHDNMMJ(this CGGBMDIIIGA KPBGCHDNDLM, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> OIGMCDJKDAK, int ILNNGHKJMBD)
	{
		return default(IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1DC93E0", Offset = "0x1DC85E0", VA = "0x181DC93E0")]
	public static void JKGGKOLFDJL(this CGGBMDIIIGA KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> DHHPKMFLOHD, int ILNNGHKJMBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9520", Offset = "0x1DC8720", VA = "0x181DC9520")]
	public static void JLHPMLNFMAF(this CGGBMDIIIGA KPBGCHDNDLM, IJMPLGOCAIG<CGGBMDIIIGA.BGBMCMPGCOI> EOHPLEHPKEN, IJMPLGOCAIG<JLOOKFPFDIM<OEKAJLLNFGM>> PANFDOIKDGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class JCKKMKGDCHP
{
	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9B20", Offset = "0x1DC8D20", VA = "0x181DC9B20")]
	public static void PNGLLFMNHOL(DPCJLNOPGBF KPBGCHDNDLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct ADNOIFFHFMI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public int PADOELFHCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public MHFBEOMNLGO<CGGBMDIIIGA.BGBMCMPGCOI, IJMPLGOCAIG<FPLIMJJHBGA>> NEPGJADGFAN;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DC6F80", Offset = "0x1DC6180", VA = "0x181DC6F80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class DMCAFJEPEJK
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x261E6A0", Offset = "0x261D8A0", VA = "0x18261E6A0")]
	public static int PNGLLFMNHOL<TDeps, TStateSys>(DPCJLNOPGBF KPBGCHDNDLM, TDeps ECDJFINNJIE, TStateSys NELPHFHNMLP, IJMPLGOCAIG<ENDAAFIJDLG> JAKGJEDDCHL, MHFBEOMNLGO<PHIDMEBOJAH.GDDCHBNGCFK, EIDMPNBJGML> IHNLBFIHBHP) where TDeps : notnull, JJOBFKFEEBJ<TStateSys> where TStateSys : notnull
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class OIHLKEOMIBG
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1DD0350", Offset = "0x1DCF550", VA = "0x181DD0350")]
	public static void PNGLLFMNHOL(DPCJLNOPGBF KPBGCHDNDLM, [In] MHFBEOMNLGO<PHIDMEBOJAH.GDDCHBNGCFK, EIDMPNBJGML> IEPPHJKKACN, int OKILKKHMIIO)
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
