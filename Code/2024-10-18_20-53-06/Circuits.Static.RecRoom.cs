using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf.Collections;
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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x22794D0", Offset = "0x22788D0", VA = "0x1822794D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DFFIMJKNAKB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x22680E0", Offset = "0x22674E0", VA = "0x1822680E0")]
	public static bool KMAEPMFICPI(this FJIDBMMCBDN DPOLEDLIAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2268020", Offset = "0x2267420", VA = "0x182268020")]
	public static bool KMAEPMFICPI(this HAMBHDDMLGB FBDFEIGOJJA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ENDCBPFDIAM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BDONJDJNHOP? PMOJPKLODGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class OHKBOMGKEJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2279890", Offset = "0x2278C90", VA = "0x182279890")]
	internal static PIJMOKLJHHD PMOJPKLODGM(this ENDCBPFDIAM MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x22796E0", Offset = "0x2278AE0", VA = "0x1822796E0")]
	internal static LMFFMMPMNDB<PIJMOKLJHHD, BDKNELMLIIE> OLDPLJKKGAM(this ENDCBPFDIAM MCPMOAEEEOJ)
	{
		return default(LMFFMMPMNDB<PIJMOKLJHHD, BDKNELMLIIE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BDONJDJNHOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly PIJMOKLJHHD PMOJPKLODGM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
	public BDONJDJNHOP(PIJMOKLJHHD JLFIDACFIIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class MIJKGMNDLEH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2F36290", Offset = "0x2F35690", VA = "0x182F36290")]
	public static ODHHEHMOGNP<BFOPIJOMCBH, IIIMLHFAMEO, TRoot, JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, TRoot>> DAELJDDJEFG<TRoot>([In] this ODHHEHMOGNP<BFOPIJOMCBH, IIIMLHFAMEO, TRoot, JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, TRoot>> MDIMFOFMFHC) where TRoot : ENDCBPFDIAM
	{
		return default(ODHHEHMOGNP<BFOPIJOMCBH, IIIMLHFAMEO, TRoot, JGNPCHJFAMM.IOBGODHJBMF<BFOPIJOMCBH, IIIMLHFAMEO, TRoot>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct AMOCPKHIDKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct GBIJGDEIGEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IEOBNKPDNKH AMPKEHMJPIO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xBF8A90", Offset = "0xBF7E90", VA = "0x180BF8A90")]
		public GBIJGDEIGEG(IEOBNKPDNKH MACGMKINBBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct NGEOGAEFNAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public MIEEFIOIIBN<CKPANFPLABI> PEPAMMICBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public MIEEFIOIIBN<CKPANFPLABI> JEOCKGLLAPM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2279230", Offset = "0x2278630", VA = "0x182279230")]
		public static NGEOGAEFNAM AHLALEPNKFA(DALEOPEJMOI<PIJMOKLJHHD> IPMOENJCOCL)
		{
			return default(NGEOGAEFNAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct JLNBLKMKNMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MIEEFIOIIBN<LIGCAJFGNCM> FOGDGCBEFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public MIEEFIOIIBN<LIGCAJFGNCM> AIFDDLPIAIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public MIEEFIOIIBN<LIGCAJFGNCM> IKPOICHNDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public MIEEFIOIIBN<LIGCAJFGNCM> JLFIOBIBHEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public MIEEFIOIIBN<LIGCAJFGNCM> CFLHPOGBIBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public MIEEFIOIIBN<LIGCAJFGNCM> GCBDDFHEDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MIEEFIOIIBN<LIGCAJFGNCM> DEIADHIKIOC;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2276990", Offset = "0x2275D90", VA = "0x182276990")]
		public static JLNBLKMKNMH AHLALEPNKFA(GBPOJJCCOPF<PIJMOKLJHHD> IPMOENJCOCL)
		{
			return default(JLNBLKMKNMH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class AOEOMONAIDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static Dictionary<MIEEFIOIIBN<KBMOJAAFIFN>, DLMNIGGIEMH> OKHLNIFDHJH;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> ILFKJMJAIPF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> LDJDNLFKOHJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> FHKJCDFBCGM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> MMINKOAJBFC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> IKDBMIPIDOB;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> DBLACJCJIIJ;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> IIAACHABJIF;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> BOEMNFPODDD;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> MKLFBPMFBOB;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> AACFEOHANNK;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> LDGMKCPEFCB;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> JGOMCAAMJHJ;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> HBAIGGFPJHN;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> KBGJEICBEGL;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> NBDNEHIKCNO;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> LJBENCNDFNI;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> LKPGCHDHOEK;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> OMBLMFMJPAJ;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> FDPKPNPGMGO;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> FDNIOKNLGIE;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> GHHKMOMKIJH;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> FLKGIDLBJBD;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> JJGBEICBNNH;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> NDBAJEMLGCK;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> AMDLMLPMBIE;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> JMFBJNOBAFB;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> MOOHJJGLIML;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> LFIPKFPBLOG;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> MNOANBJGKKI;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> LNNGFFKOFBD;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> MFJMMHOKEDD;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> CPABIDJCMHC;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> NHEDLLBBMDK;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> MAIDNABJCIO;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> PGMNOBHBKDE;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> PHJBLFGPJIE;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> JOKGKJGFLME;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> DKCJCOAJKPA;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> IOECFDJAJMB;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> EEOLOMKKOKN;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> PMLHBMBIHKL;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> BIPDNGMBFOG;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> INJLAIMDFLM;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> MAGGILNHFMF;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> NFLKKPEPIOL;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> AFKKHKEHOKE;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> BFCNNHNOIAN;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> CPBAGKJPIBH;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> IALOBLLCHPB;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> GBPIAHEAMMI;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> DBCKKNOGAMD;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> FMLPJOGGBLK;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> HDMDCPNBAFJ;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> JNOLKOKBGGK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> AAIOFCBACOB;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> PHOCAPGLMKB;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly MIEEFIOIIBN<KBMOJAAFIFN> CHGLDLFGCMI;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2262DA0", Offset = "0x22621A0", VA = "0x182262DA0")]
		public static DLMNIGGIEMH HCECKNOEPEA(MIEEFIOIIBN<KBMOJAAFIFN> NKPCGMJMEIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2262C60", Offset = "0x2262060", VA = "0x182262C60")]
		public static bool EMEGENEICEN(MIEEFIOIIBN<KBMOJAAFIFN> NKPCGMJMEIE, [Out] DLMNIGGIEMH LCMKOOOFAJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2262CF0", Offset = "0x22620F0", VA = "0x182262CF0")]
		public static FJIDBMMCBDN GJAMOMMOOED(MIEEFIOIIBN<KBMOJAAFIFN> NKPCGMJMEIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2262E20", Offset = "0x2262220", VA = "0x182262E20")]
		private static MIEEFIOIIBN<KBMOJAAFIFN> MHJHNBDIMHP(DLMNIGGIEMH LCMKOOOFAJF, MIEEFIOIIBN<KBMOJAAFIFN> NKPCGMJMEIE)
		{
			return default(MIEEFIOIIBN<KBMOJAAFIFN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class JILJNODJPMH
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class COLAMJEAODA : IEnumerable<FJIDBMMCBDN>, IEnumerable, IEnumerator<FJIDBMMCBDN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private FJIDBMMCBDN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private APGGJPBALIL roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public APGGJPBALIL <>3__roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private bool <r2>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			private FJIDBMMCBDN System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7D0", Offset = "0x9EABD0", VA = "0x1809EB7D0")]
			[DebuggerHidden]
			public COLAMJEAODA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2266740", Offset = "0x2265B40", VA = "0x182266740", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x2267FD0", Offset = "0x22673D0", VA = "0x182267FD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2267F20", Offset = "0x2267320", VA = "0x182267F20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FJIDBMMCBDN> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x2267F20", Offset = "0x2267320", VA = "0x182267F20", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IGCLIFOIPJP : IEnumerable<FJIDBMMCBDN>, IEnumerable, IEnumerator<FJIDBMMCBDN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private FJIDBMMCBDN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private bool includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public bool <>3__includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private APGGJPBALIL roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public APGGJPBALIL <>3__roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private IEnumerator<FJIDBMMCBDN> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private FJIDBMMCBDN <circuitType>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			private FJIDBMMCBDN System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000069")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9EB7D0", Offset = "0x9EABD0", VA = "0x1809EB7D0")]
			[DebuggerHidden]
			public IGCLIFOIPJP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x226DBA0", Offset = "0x226CFA0", VA = "0x18226DBA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x226D5A0", Offset = "0x226C9A0", VA = "0x18226D5A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x226D550", Offset = "0x226C950", VA = "0x18226D550")]
			private void CPDIPGODGJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x226DB50", Offset = "0x226CF50", VA = "0x18226DB50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x226DA90", Offset = "0x226CE90", VA = "0x18226DA90", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<FJIDBMMCBDN> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x226DA90", Offset = "0x226CE90", VA = "0x18226DA90", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly HAMBHDDMLGB AKCALGADHBL;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static readonly HAMBHDDMLGB LLKKJLAAFOJ;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private static readonly HashSet<FJIDBMMCBDN> NAEPFAFKJFD;

		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public static List<FJIDBMMCBDN> JDCCALOOBBL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static LNONNIJFHAH DJKMDIIGNEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA16A60", Offset = "0xA15E60", VA = "0x180A16A60")]
			get
			{
				return default(LNONNIJFHAH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static FJIDBMMCBDN AENMLANJAFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x226F060", Offset = "0x226E460", VA = "0x18226F060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static FJIDBMMCBDN DCDEMKFJENG
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x226E780", Offset = "0x226DB80", VA = "0x18226E780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static FJIDBMMCBDN EGOPIJHFHPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x226ED50", Offset = "0x226E150", VA = "0x18226ED50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static FJIDBMMCBDN EOIALGCEDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x22702D0", Offset = "0x226F6D0", VA = "0x1822702D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static FJIDBMMCBDN KLGHBCOMMKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x226F270", Offset = "0x226E670", VA = "0x18226F270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static FJIDBMMCBDN MEHPCLMJFHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x226E1B0", Offset = "0x226D5B0", VA = "0x18226E1B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static FJIDBMMCBDN GHKJCOPLMEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x226FCF0", Offset = "0x226F0F0", VA = "0x18226FCF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static FJIDBMMCBDN PPGCGMDBONO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x226E6F0", Offset = "0x226DAF0", VA = "0x18226E6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static COKJMKHCHKH DIANDGAGFDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2270590", Offset = "0x226F990", VA = "0x182270590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static COKJMKHCHKH MKNGJDBKCCO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x226FD80", Offset = "0x226F180", VA = "0x18226FD80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static COKJMKHCHKH NGFALGIEDKK
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2270450", Offset = "0x226F850", VA = "0x182270450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static COKJMKHCHKH KIEPFAEMBFM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x226F440", Offset = "0x226E840", VA = "0x18226F440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static COKJMKHCHKH KMGPBACBEJG
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x226E860", Offset = "0x226DC60", VA = "0x18226E860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static COKJMKHCHKH DJEDKHANEEN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x226F7B0", Offset = "0x226EBB0", VA = "0x18226F7B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static COKJMKHCHKH BIGJIPFKNEI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x226EE30", Offset = "0x226E230", VA = "0x18226EE30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static COKJMKHCHKH OKPFNLFJHEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x226E600", Offset = "0x226DA00", VA = "0x18226E600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static COKJMKHCHKH EKEAFCJFFDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x226FFB0", Offset = "0x226F3B0", VA = "0x18226FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static COKJMKHCHKH LBLGBKLMMDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x226DCD0", Offset = "0x226D0D0", VA = "0x18226DCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static COKJMKHCHKH DEMLJKKFNKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x226EDE0", Offset = "0x226E1E0", VA = "0x18226EDE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static COKJMKHCHKH NIDFGOEIJCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x226E160", Offset = "0x226D560", VA = "0x18226E160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static COKJMKHCHKH HELHCDNKBED
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x226E9F0", Offset = "0x226DDF0", VA = "0x18226E9F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static COKJMKHCHKH IPHPFNMMODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x226E240", Offset = "0x226D640", VA = "0x18226E240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static COKJMKHCHKH CGDOFHIJKIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x226F6C0", Offset = "0x226EAC0", VA = "0x18226F6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static COKJMKHCHKH LBOEDHGKKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x226E950", Offset = "0x226DD50", VA = "0x18226E950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static COKJMKHCHKH GFFHIPLFAFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x226FDD0", Offset = "0x226F1D0", VA = "0x18226FDD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static COKJMKHCHKH HBJFGEEOFIO
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x226F4E0", Offset = "0x226E8E0", VA = "0x18226F4E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static COKJMKHCHKH MOKJAFHODFD
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x22704F0", Offset = "0x226F8F0", VA = "0x1822704F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static COKJMKHCHKH CLJJLDAIOFH
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x226DC80", Offset = "0x226D080", VA = "0x18226DC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static COKJMKHCHKH JPCBMJBKMMA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x226F010", Offset = "0x226E410", VA = "0x18226F010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static COKJMKHCHKH CDDBCJBPPLO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2270000", Offset = "0x226F400", VA = "0x182270000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static COKJMKHCHKH AMEGOPKMHNH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x226E8B0", Offset = "0x226DCB0", VA = "0x18226E8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static COKJMKHCHKH HDPKOAJKIGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x226FEC0", Offset = "0x226F2C0", VA = "0x18226FEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static COKJMKHCHKH MPHDEGIIIDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x226EAE0", Offset = "0x226DEE0", VA = "0x18226EAE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static COKJMKHCHKH EOIGLPNIPBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x226F5D0", Offset = "0x226E9D0", VA = "0x18226F5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static COKJMKHCHKH GPOHKDONKOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x226F760", Offset = "0x226EB60", VA = "0x18226F760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static COKJMKHCHKH IOIPMLDMGMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2270230", Offset = "0x226F630", VA = "0x182270230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static COKJMKHCHKH FDKGGLOIGIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2270140", Offset = "0x226F540", VA = "0x182270140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static COKJMKHCHKH KEKCPADMMIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x226EBB0", Offset = "0x226DFB0", VA = "0x18226EBB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static COKJMKHCHKH MCEOEOHKLPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x226E510", Offset = "0x226D910", VA = "0x18226E510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static COKJMKHCHKH CIIPNHLHFAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2270050", Offset = "0x226F450", VA = "0x182270050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static COKJMKHCHKH JAOPGBOBNDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x226E380", Offset = "0x226D780", VA = "0x18226E380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static COKJMKHCHKH NELKOAJGKIA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2270360", Offset = "0x226F760", VA = "0x182270360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static COKJMKHCHKH BMPADJPPDJH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x226EB60", Offset = "0x226DF60", VA = "0x18226EB60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static COKJMKHCHKH BPGLDPCHCBG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x226EFC0", Offset = "0x226E3C0", VA = "0x18226EFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public static COKJMKHCHKH DGDEOKHFDCC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x226F3A0", Offset = "0x226E7A0", VA = "0x18226F3A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public static COKJMKHCHKH LEEKIPEOOFP
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x22701E0", Offset = "0x226F5E0", VA = "0x1822701E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static COKJMKHCHKH JILKCBAKEOC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x226E0C0", Offset = "0x226D4C0", VA = "0x18226E0C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static COKJMKHCHKH IJKKGEDACOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x226E650", Offset = "0x226DA50", VA = "0x18226E650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static COKJMKHCHKH PMMDIMEPAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x226EE80", Offset = "0x226E280", VA = "0x18226EE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public static COKJMKHCHKH NIHFMLPPINI
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x226F220", Offset = "0x226E620", VA = "0x18226F220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static COKJMKHCHKH KEHCIGFPDKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x226E290", Offset = "0x226D690", VA = "0x18226E290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public static COKJMKHCHKH HPGDFFIOOIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x226E110", Offset = "0x226D510", VA = "0x18226E110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static COKJMKHCHKH GCDONOPEEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x22704A0", Offset = "0x226F8A0", VA = "0x1822704A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static COKJMKHCHKH PKINADJCKHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x226EC50", Offset = "0x226E050", VA = "0x18226EC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static COKJMKHCHKH PAKMHOONELH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x226FF60", Offset = "0x226F360", VA = "0x18226FF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static COKJMKHCHKH EGLGJDNJLJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x226DD20", Offset = "0x226D120", VA = "0x18226DD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public static COKJMKHCHKH MJOHMOFIADI
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x226DC30", Offset = "0x226D030", VA = "0x18226DC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static COKJMKHCHKH HBEFGMENBJD
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x226F530", Offset = "0x226E930", VA = "0x18226F530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static COKJMKHCHKH HLALPFPFMIP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x226FBD0", Offset = "0x226EFD0", VA = "0x18226FBD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static COKJMKHCHKH FCOAADFFGCM
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x226F990", Offset = "0x226ED90", VA = "0x18226F990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public static COKJMKHCHKH OLIGDMLBCDK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x22703B0", Offset = "0x226F7B0", VA = "0x1822703B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static COKJMKHCHKH KINHNGIEGNM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x22700A0", Offset = "0x226F4A0", VA = "0x1822700A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static COKJMKHCHKH ECGIICMMLHI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x226F3F0", Offset = "0x226E7F0", VA = "0x18226F3F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public static COKJMKHCHKH NCEKMOEODEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x226E6A0", Offset = "0x226DAA0", VA = "0x18226E6A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static COKJMKHCHKH JGOOIDBANGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x226EA40", Offset = "0x226DE40", VA = "0x18226EA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public static COKJMKHCHKH LECIEDBMILE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x2270190", Offset = "0x226F590", VA = "0x182270190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static COKJMKHCHKH GNBKACIBPIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x226F670", Offset = "0x226EA70", VA = "0x18226F670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static COKJMKHCHKH BLIOAFJNBCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x226E420", Offset = "0x226D820", VA = "0x18226E420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public static COKJMKHCHKH LHIIFNLFLMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x2270400", Offset = "0x226F800", VA = "0x182270400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public static COKJMKHCHKH MAIBNNGCEEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x226E810", Offset = "0x226DC10", VA = "0x18226E810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public static COKJMKHCHKH PEBPAOPLLLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x226E900", Offset = "0x226DD00", VA = "0x18226E900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public static COKJMKHCHKH EOJCEPPPPLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x226FE20", Offset = "0x226F220", VA = "0x18226FE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static COKJMKHCHKH LAIPKHLCGKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x226F580", Offset = "0x226E980", VA = "0x18226F580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public static COKJMKHCHKH ACIICHJOOIH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x226FC70", Offset = "0x226F070", VA = "0x18226FC70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public static COKJMKHCHKH MOGPLEGAKHA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x22700F0", Offset = "0x226F4F0", VA = "0x1822700F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public static COKJMKHCHKH EHGGPHBLIAB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x226F490", Offset = "0x226E890", VA = "0x18226F490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public static COKJMKHCHKH GLKBMEIAGFN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x226E4C0", Offset = "0x226D8C0", VA = "0x18226E4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static COKJMKHCHKH DJLIHPOIKDM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x226EA90", Offset = "0x226DE90", VA = "0x18226EA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static COKJMKHCHKH JJGFGEGJOLA
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x226E5B0", Offset = "0x226D9B0", VA = "0x18226E5B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static COKJMKHCHKH HKNKIKAMABB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x226EED0", Offset = "0x226E2D0", VA = "0x18226EED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static COKJMKHCHKH ANCGDCMNEBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x226EC00", Offset = "0x226E000", VA = "0x18226EC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static COKJMKHCHKH JENJKAKNPON
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x226E3D0", Offset = "0x226D7D0", VA = "0x18226E3D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static COKJMKHCHKH AJKALDBOHKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x226FE70", Offset = "0x226F270", VA = "0x18226FE70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static COKJMKHCHKH IFEBCHGLBKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x226EF70", Offset = "0x226E370", VA = "0x18226EF70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static COKJMKHCHKH JEIPDBIHBDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x226E2E0", Offset = "0x226D6E0", VA = "0x18226E2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static COKJMKHCHKH FEPNIEEFBIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x226E470", Offset = "0x226D870", VA = "0x18226E470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static COKJMKHCHKH MLFEDLNMFMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x226F710", Offset = "0x226EB10", VA = "0x18226F710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public static COKJMKHCHKH ALPAHIEDGBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x226FF10", Offset = "0x226F310", VA = "0x18226FF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public static COKJMKHCHKH EHOJEEIOKCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x226F620", Offset = "0x226EA20", VA = "0x18226F620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public static COKJMKHCHKH MEEDPHLIHMC
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x226FC20", Offset = "0x226F020", VA = "0x18226FC20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public static COKJMKHCHKH BLILKNEOOIB
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x226E560", Offset = "0x226D960", VA = "0x18226E560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static COKJMKHCHKH DJPGJGNHDGM
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x226EF20", Offset = "0x226E320", VA = "0x18226EF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public static COKJMKHCHKH OPGODFALOGM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2270540", Offset = "0x226F940", VA = "0x182270540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public static COKJMKHCHKH LKBEOBDEHBE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x226F350", Offset = "0x226E750", VA = "0x18226F350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public static COKJMKHCHKH PCJPGDICJJE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2270280", Offset = "0x226F680", VA = "0x182270280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public static COKJMKHCHKH EEIJKBECBPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x226F300", Offset = "0x226E700", VA = "0x18226F300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static COKJMKHCHKH OGHGPHBGLBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x226E330", Offset = "0x226D730", VA = "0x18226E330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public static COKJMKHCHKH DNMDAFCKJPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x226E9A0", Offset = "0x226DDA0", VA = "0x18226E9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public static COKJMKHCHKH CBKODPMJPCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x226FB80", Offset = "0x226EF80", VA = "0x18226FB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x226FA90", Offset = "0x226EE90", VA = "0x18226FA90")]
		public static HAMBHDDMLGB KHNDOPFKFAK([In] JPPKBIDEFIO DIMPEGEDIAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x226DDA0", Offset = "0x226D1A0", VA = "0x18226DDA0")]
		public static GCILIINBJDO AJMABIGAKBP(string NKPCGMJMEIE, [Optional] string DDDHPCNFCEK)
		{
			return default(GCILIINBJDO);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x226DD70", Offset = "0x226D170", VA = "0x18226DD70")]
		public static GCILIINBJDO AJMABIGAKBP([Optional][In] Guid? NKPCGMJMEIE, [Optional] string DDDHPCNFCEK)
		{
			return default(GCILIINBJDO);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x226EB30", Offset = "0x226DF30", VA = "0x18226EB30")]
		public static HAMBHDDMLGB EPCOOKMHPGN(params JPPKBIDEFIO[] GJPEPGIOJEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x226FCC0", Offset = "0x226F0C0", VA = "0x18226FCC0")]
		public static HAMBHDDMLGB LNCOPMGHPPI(params JPPKBIDEFIO[] GJPEPGIOJEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x226F0F0", Offset = "0x226E4F0", VA = "0x18226F0F0")]
		public static HAMBHDDMLGB HGNMEAIFEJM([In] JPPKBIDEFIO DIMPEGEDIAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x22705E0", Offset = "0x226F9E0", VA = "0x1822705E0")]
		static JILJNODJPMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x226ECA0", Offset = "0x226E0A0", VA = "0x18226ECA0")]
		[IteratorStateMachine(typeof(COLAMJEAODA))]
		private static IEnumerable<FJIDBMMCBDN> GCDIHIJHEFP(APGGJPBALIL NHHHDJMHPLL, bool CANGKBNLFBH, bool AAJPPFKLFMC, bool JFMPDOBOHMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x226F9E0", Offset = "0x226EDE0", VA = "0x18226F9E0")]
		[IteratorStateMachine(typeof(IGCLIFOIPJP))]
		public static IEnumerable<FJIDBMMCBDN> KDNGFKKJHIP(APGGJPBALIL NHHHDJMHPLL, bool AIEGKADNMPC, bool CANGKBNLFBH, bool AAJPPFKLFMC, bool JFMPDOBOHMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x226F800", Offset = "0x226EC00", VA = "0x18226F800")]
		public static AJGHNFAOCDE JODJGFDICGL(FJIDBMMCBDN DPOLEDLIAMP)
		{
			return default(AJGHNFAOCDE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x226DE50", Offset = "0x226D250", VA = "0x18226DE50")]
		public static AJGHNFAOCDE AMCOJMCNMHJ(FJIDBMMCBDN DPOLEDLIAMP)
		{
			return default(AJGHNFAOCDE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x226E040", Offset = "0x226D440", VA = "0x18226E040")]
		public static bool AMMDMCGOODJ(FJIDBMMCBDN DPOLEDLIAMP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly JLNBLKMKNMH CJNFJNFMPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly NGEOGAEFNAM OBFIAMPHJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LMPCPDJAHLE<LIGCAJFGNCM, LFJPAIMJONE<PIJMOKLJHHD>> KIECGBCMPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LMPCPDJAHLE<CKPANFPLABI, PEIMMJMMEOC<PIJMOKLJHHD>> LHKGDPCMCPH;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2262C10", Offset = "0x2262010", VA = "0x182262C10")]
	private AMOCPKHIDKG([In] JLNBLKMKNMH DGNDIKCCBJB, [In] NGEOGAEFNAM AKAJJMPODEO, LMPCPDJAHLE<LIGCAJFGNCM, LFJPAIMJONE<PIJMOKLJHHD>> KKMJNPLGPNP, LMPCPDJAHLE<CKPANFPLABI, PEIMMJMMEOC<PIJMOKLJHHD>> KLONDJPOFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x22623D0", Offset = "0x22617D0", VA = "0x1822623D0")]
	public static AMOCPKHIDKG AHLALEPNKFA()
	{
		return default(AMOCPKHIDKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x22626F0", Offset = "0x2261AF0", VA = "0x1822626F0")]
	public static void KJDEEDGEPIJ([In] AMOCPKHIDKG MCPMOAEEEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2262550", Offset = "0x2261950", VA = "0x182262550", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2262B30", Offset = "0x2261F30", VA = "0x182262B30")]
	public static BOCHCKILHLO<PIJMOKLJHHD> LMGBDACJPPL([In] AMOCPKHIDKG MCPMOAEEEOJ, [In] HJJGMFAIGAE JDNJCOOAFDB, [In] MOGAJMCDCNB LKIILAPOEJP)
	{
		return default(BOCHCKILHLO<PIJMOKLJHHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2262560", Offset = "0x2261960", VA = "0x182262560")]
	public static PIJMOKLJHHD ELDPDGMGLGO([In] AMOCPKHIDKG MCPMOAEEEOJ, [In] KMDEDNNHHFI OJCEAILDFAM, [In] BOCHCKILHLO<PIJMOKLJHHD> NCIHMAFAKAP, [In] ONAMEFGMHPA GDGALODOLMO, MIEEFIOIIBN<ABNDNCLMDPA> FJNKOGEOPJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class PIJMOKLJHHD : DBDHNNLMDPB, GLCMHENNKMJ<PIJMOKLJHHD>, CPGPGNPJBAB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public readonly AMOCPKHIDKG AEFOAEAGGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private KMDEDNNHHFI KGNEENALBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private BOCHCKILHLO<PIJMOKLJHHD> CIILDJIJDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private ONAMEFGMHPA AKHFEGJFDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> INDEOOJLEKM;

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x227CF60", Offset = "0x227C360", VA = "0x18227CF60")]
	private PIJMOKLJHHD([In] AMOCPKHIDKG LMKJJGAGOOO, [In] KMDEDNNHHFI GGCJLNCFIJI, [In] BOCHCKILHLO<PIJMOKLJHHD> NCIHMAFAKAP, [In] ONAMEFGMHPA GDGALODOLMO, MIEEFIOIIBN<ABNDNCLMDPA> PILCKHPHIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2262560", Offset = "0x2261960", VA = "0x182262560")]
	public static PIJMOKLJHHD JFEHLEBMCMC([In] AMOCPKHIDKG LMKJJGAGOOO, [In] KMDEDNNHHFI GGCJLNCFIJI, [In] BOCHCKILHLO<PIJMOKLJHHD> NCIHMAFAKAP, [In] ONAMEFGMHPA GDGALODOLMO, MIEEFIOIIBN<ABNDNCLMDPA> PILCKHPHIKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x227A860", Offset = "0x2279C60", VA = "0x18227A860", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2242520", Offset = "0x2241920", VA = "0x182242520", Slot = "8")]
	public BOCHCKILHLO<PIJMOKLJHHD> LIKOCCNEMEJ()
	{
		return default(BOCHCKILHLO<PIJMOKLJHHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2242530", Offset = "0x2241930", VA = "0x182242530")]
	public KMDEDNNHHFI DPLNFGDNLGJ()
	{
		return default(KMDEDNNHHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3043820", Offset = "0x3042C20", VA = "0x183043820")]
	public MIEEFIOIIBN<TMVirt> EBGILKHOGIF<TMVirt>(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE) where TMVirt : BEEPHLANAAP.OMFGJPOPOOG
	{
		return default(MIEEFIOIIBN<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3043920", Offset = "0x3042D20", VA = "0x183043920")]
	public MIEEFIOIIBN<TMVirt> FNGNINCFPBM<TMVirt>(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM) where TMVirt : FKAHMBEAONA.FLLPJEELKEO
	{
		return default(MIEEFIOIIBN<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x227AAE0", Offset = "0x2279EE0", VA = "0x18227AAE0")]
	internal HJJGMFAIGAE HJNKPDFALCD()
	{
		return default(HJJGMFAIGAE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x227A220", Offset = "0x2279620", VA = "0x18227A220")]
	internal MOGAJMCDCNB ANKFMAGPKIO()
	{
		return default(MOGAJMCDCNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x2242520", Offset = "0x2241920", VA = "0x182242520")]
	internal BOCHCKILHLO<PIJMOKLJHHD> POHEFLEFPON()
	{
		return default(BOCHCKILHLO<PIJMOKLJHHD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x2242530", Offset = "0x2241930", VA = "0x182242530")]
	internal KMDEDNNHHFI JDNDGEBFPGA()
	{
		return default(KMDEDNNHHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x227BDE0", Offset = "0x227B1E0", VA = "0x18227BDE0")]
	internal ONAMEFGMHPA LLHBJIAMJIH()
	{
		return default(ONAMEFGMHPA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x30438B0", Offset = "0x3042CB0", VA = "0x1830438B0")]
	public void FAPDBGMDMOH<TMVirt>(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<TMVirt> JCHDJKONEBP) where TMVirt : BEEPHLANAAP.OMFGJPOPOOG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x30439F0", Offset = "0x3042DF0", VA = "0x1830439F0")]
	public void KDKLIPDMJJI<TMVirt>(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<TMVirt> JCHDJKONEBP) where TMVirt : FKAHMBEAONA.FLLPJEELKEO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x227BDA0", Offset = "0x227B1A0", VA = "0x18227BDA0", Slot = "9")]
	public GGEKMJMDANN LHLADBODGJN()
	{
		return default(GGEKMJMDANN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x227AA70", Offset = "0x2279E70", VA = "0x18227AA70", Slot = "10")]
	public AJGHNFAOCDE GFFKDMEMMLC(FJIDBMMCBDN DPOLEDLIAMP)
	{
		return default(AJGHNFAOCDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x227BCF0", Offset = "0x227B0F0", VA = "0x18227BCF0", Slot = "11")]
	public bool LHJNIDBBDDB(FJIDBMMCBDN DPOLEDLIAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x227BC40", Offset = "0x227B040", VA = "0x18227BC40", Slot = "4")]
	private void LFBIEJKGIFD(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, OEANGFGCLHO ECHCIKCBIED, MIEEFIOIIBN<PCDHPDNGICC.HJDBMJEKEBM>? NLLGOKIEPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x227A3F0", Offset = "0x22797F0", VA = "0x18227A3F0", Slot = "5")]
	private void DINHHGGEJCM(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x227A260", Offset = "0x2279660", VA = "0x18227A260", Slot = "6")]
	private void CCPFFLCBGJL(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, OEANGFGCLHO ECHCIKCBIED, MIEEFIOIIBN<PCDHPDNGICC.HJDBMJEKEBM>? NLLGOKIEPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x227AB20", Offset = "0x2279F20", VA = "0x18227AB20", Slot = "7")]
	private void ICIKBOPLGDD(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x227A8E0", Offset = "0x2279CE0", VA = "0x18227A8E0")]
	internal LMFFMMPMNDB<MIEEFIOIIBN<LKDNFLJFHHO>, JLINDJLDKOH> FOGDGCBEFBI(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LIGCAJFGNCM> JMMCBCOBCMJ, [In] DPPHGIGHBKC OGHPOADGEMG, [In] FHHIKJNGAEG MHGGNDLFNAD, OEANGFGCLHO IBIJAFGIHDD, MIEEFIOIIBN<PCDHPDNGICC.HJDBMJEKEBM>? KMGODOKIFHE)
	{
		return default(LMFFMMPMNDB<MIEEFIOIIBN<LKDNFLJFHHO>, JLINDJLDKOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x227A2F0", Offset = "0x22796F0", VA = "0x18227A2F0")]
	internal MIEEFIOIIBN<LKDNFLJFHHO> CPJAMANLNBN(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LIGCAJFGNCM> JMMCBCOBCMJ, [In] DPPHGIGHBKC OGHPOADGEMG, [In] FHHIKJNGAEG MHGGNDLFNAD, OEANGFGCLHO IBIJAFGIHDD, MIEEFIOIIBN<PCDHPDNGICC.HJDBMJEKEBM>? KMGODOKIFHE)
	{
		return default(MIEEFIOIIBN<LKDNFLJFHHO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x227BDF0", Offset = "0x227B1F0", VA = "0x18227BDF0")]
	internal LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> MMDFIEFDBKJ(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3043650", Offset = "0x3042A50", VA = "0x183043650")]
	public LMFFMMPMNDB<MIEEFIOIIBN<TM>, JLINDJLDKOH> ACJOLPJHPIF<TM>(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<CKPANFPLABI> BDFFCKBOEMO) where TM : BEEPHLANAAP.OMFGJPOPOOG
	{
		return default(LMFFMMPMNDB<MIEEFIOIIBN<TM>, JLINDJLDKOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3043AC0", Offset = "0x3042EC0", VA = "0x183043AC0")]
	public LMFFMMPMNDB<MIEEFIOIIBN<TM>, JLINDJLDKOH> LJCBPCELMEF<TM>(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<LIGCAJFGNCM> HILCHLHCIKH) where TM : FKAHMBEAONA.FLLPJEELKEO
	{
		return default(LMFFMMPMNDB<MIEEFIOIIBN<TM>, JLINDJLDKOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x227A4D0", Offset = "0x22798D0", VA = "0x18227A4D0")]
	private LMFFMMPMNDB<(MIEEFIOIIBN<FCDKJKPGPDK.LFIIPHOGMIK>, MIEEFIOIIBN<BAFKBFILGOE.EKKHBBLCECM>), JLINDJLDKOH> DJMNALPJHLK(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
		return default(LMFFMMPMNDB<(MIEEFIOIIBN<FCDKJKPGPDK.LFIIPHOGMIK>, MIEEFIOIIBN<BAFKBFILGOE.EKKHBBLCECM>), JLINDJLDKOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x227AB90", Offset = "0x2279F90", VA = "0x18227AB90")]
	internal LMFFMMPMNDB<(MIEEFIOIIBN<HIBILKABFFC>, MIEEFIOIIBN<IMBJFPFGGEG>), JLINDJLDKOH> KGOGPNPKEEG(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, int CNAIPFMACGM, [In] FPLHNNLFDPF DPOLEDLIAMP)
	{
		return default(LMFFMMPMNDB<(MIEEFIOIIBN<HIBILKABFFC>, MIEEFIOIIBN<IMBJFPFGGEG>), JLINDJLDKOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x227C760", Offset = "0x227BB60", VA = "0x18227C760")]
	internal LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> POAJKCOGAHM(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, int CNAIPFMACGM)
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x227BE80", Offset = "0x227B280", VA = "0x18227BE80")]
	internal LMFFMMPMNDB<(MIEEFIOIIBN<IMBJFPFGGEG>, MIEEFIOIIBN<HIBILKABFFC>), JLINDJLDKOH> PGKBGFDOGJE(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, int KLEBBHLPMGG, [In] FPLHNNLFDPF DPOLEDLIAMP)
	{
		return default(LMFFMMPMNDB<(MIEEFIOIIBN<IMBJFPFGGEG>, MIEEFIOIIBN<HIBILKABFFC>), JLINDJLDKOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x227B400", Offset = "0x227A800", VA = "0x18227B400")]
	internal LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> KNFEOFGEPME(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, int KLEBBHLPMGG)
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct ONAMEFGMHPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public DGOPJPCIBPB<BAFKBFILGOE.EKKHBBLCECM, NDKKNACFGPO> NBAHJKODMGK;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x21D5670", Offset = "0x21D4A70", VA = "0x1821D5670")]
	private ONAMEFGMHPA([In] DGOPJPCIBPB<BAFKBFILGOE.EKKHBBLCECM, NDKKNACFGPO> MPAIAHHFCGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2279C00", Offset = "0x2279000", VA = "0x182279C00")]
	public static ONAMEFGMHPA AHLALEPNKFA()
	{
		return default(ONAMEFGMHPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OHKFADLIINL
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2279970", Offset = "0x2278D70", VA = "0x182279970")]
	public static void KJDEEDGEPIJ(this ONAMEFGMHPA MCPMOAEEEOJ, [In] KAAJPLPJGFK<BAFKBFILGOE.EKKHBBLCECM> EIBFHPFLEOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LECPPLMDCLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x22778E0", Offset = "0x2276CE0", VA = "0x1822778E0")]
	public static IKCDDPNEMII IFDLICGNEEM(PIJMOKLJHHD NCIHMAFAKAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2277A30", Offset = "0x2276E30", VA = "0x182277A30")]
	public static IKCDDPNEMII PEKOLAECDOA(MIEEFIOIIBN<CKPANFPLABI> OBNLGLOBDCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HLPGOAHMPFC
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x226B050", Offset = "0x226A450", VA = "0x18226B050")]
	public static ENJPJBLAFCH IFDLICGNEEM(this FJIDBMMCBDN DPOLEDLIAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x226A500", Offset = "0x2269900", VA = "0x18226A500")]
	public static FJIDBMMCBDN AJCCBGLJAMD(this ENJPJBLAFCH DPOLEDLIAMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class PNAAPOIMFJI
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x30479C0", Offset = "0x3046DC0", VA = "0x1830479C0")]
	public static Dictionary<TDeserializedKey, TDeserializedValue> ILPMOHMBOGE<TDeserializedKey, TDeserializedValue, TSerialized>(this RepeatedField<TSerialized> GNHHNHJOMCE, Func<TSerialized, TDeserializedKey> INHHBGKIMNN, Func<TSerialized, TDeserializedValue> PIBEOJNGLCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class ICMGMJDCILG
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x226CE40", Offset = "0x226C240", VA = "0x18226CE40")]
	public static HEGKCEHNOKJ IFDLICGNEEM([In] this BEEPHLANAAP MCPMOAEEEOJ, [In] IPEKKNICFBG CGOGNBPFMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x226C6D0", Offset = "0x226BAD0", VA = "0x18226C6D0")]
	public static BEEPHLANAAP AJCCBGLJAMD(this HEGKCEHNOKJ MCPMOAEEEOJ, [In] IPEKKNICFBG CGOGNBPFMJH)
	{
		return default(BEEPHLANAAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FIGKOAOJBAG
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2269680", Offset = "0x2268A80", VA = "0x182269680")]
	public static PMGNKBKGHEJ IFDLICGNEEM([In] this MOGAJMCDCNB MCPMOAEEEOJ, [In] HJJGMFAIGAE FNGDPCCALJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x22693C0", Offset = "0x22687C0", VA = "0x1822693C0")]
	public static MOGAJMCDCNB AJCCBGLJAMD(this PMGNKBKGHEJ MCPMOAEEEOJ, [In] HJJGMFAIGAE FNGDPCCALJF)
	{
		return default(MOGAJMCDCNB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GLAEMJMIKDP
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2269B20", Offset = "0x2268F20", VA = "0x182269B20")]
	public static JACMGNCIHKC IFDLICGNEEM([In] this KMLNNKAHOMM MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2269A70", Offset = "0x2268E70", VA = "0x182269A70")]
	public static KMLNNKAHOMM AJCCBGLJAMD(this JACMGNCIHKC MCPMOAEEEOJ)
	{
		return default(KMLNNKAHOMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CMKNGOMCBAE
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x22666C0", Offset = "0x2265AC0", VA = "0x1822666C0")]
	public static GHFIKAMIJIE IFDLICGNEEM([In] this FKAHMBEAONA MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2266640", Offset = "0x2265A40", VA = "0x182266640")]
	public static FKAHMBEAONA AJCCBGLJAMD(this GHFIKAMIJIE MCPMOAEEEOJ)
	{
		return default(FKAHMBEAONA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KAEJNBEGBOL
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2276C50", Offset = "0x2276050", VA = "0x182276C50")]
	public static AFJKBJIFLBE IFDLICGNEEM([In] this CDKFEEDBCDM MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2276BD0", Offset = "0x2275FD0", VA = "0x182276BD0")]
	public static CDKFEEDBCDM AJCCBGLJAMD(this AFJKBJIFLBE MCPMOAEEEOJ)
	{
		return default(CDKFEEDBCDM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class MPAJALFPFBF
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2F44670", Offset = "0x2F43A70", VA = "0x182F44670")]
	public static JMIFOPMLLFI IFDLICGNEEM<TRoot>([In] this BOCHCKILHLO<TRoot> MCPMOAEEEOJ) where TRoot : GLCMHENNKMJ<TRoot>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2278E20", Offset = "0x2278220", VA = "0x182278E20")]
	public static BOCHCKILHLO<PIJMOKLJHHD> AJCCBGLJAMD(this JMIFOPMLLFI MCPMOAEEEOJ, [In] AMOCPKHIDKG LMKJJGAGOOO)
	{
		return default(BOCHCKILHLO<PIJMOKLJHHD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class HDJLNAJIGPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x226A2B0", Offset = "0x22696B0", VA = "0x18226A2B0")]
	public static GMBDHHAGDIC IFDLICGNEEM([In] this BAFKBFILGOE.HMOFPNFCDJH MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2269FC0", Offset = "0x22693C0", VA = "0x182269FC0")]
	public static BAFKBFILGOE.HMOFPNFCDJH AJCCBGLJAMD(this GMBDHHAGDIC MCPMOAEEEOJ)
	{
		return default(BAFKBFILGOE.HMOFPNFCDJH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class FBKEDKIPLAM
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2269350", Offset = "0x2268750", VA = "0x182269350")]
	public static CILLJODODCJ IFDLICGNEEM([In] this FCDKJKPGPDK.NOLNGMBPCMM MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2269300", Offset = "0x2268700", VA = "0x182269300")]
	public static FCDKJKPGPDK.NOLNGMBPCMM AJCCBGLJAMD(this CILLJODODCJ MCPMOAEEEOJ)
	{
		return default(FCDKJKPGPDK.NOLNGMBPCMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class EMOPLCAPODC
{
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2268F70", Offset = "0x2268370", VA = "0x182268F70")]
	public static PNMMAAIFCIA IFDLICGNEEM([In] this HJJGMFAIGAE MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2268D10", Offset = "0x2268110", VA = "0x182268D10")]
	public static HJJGMFAIGAE AJCCBGLJAMD(this PNMMAAIFCIA MCPMOAEEEOJ)
	{
		return default(HJJGMFAIGAE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class CHEJPICLPHK
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2265730", Offset = "0x2264B30", VA = "0x182265730")]
	public static FOCKAFCCMDA IFDLICGNEEM([In] Guid MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2265690", Offset = "0x2264A90", VA = "0x182265690")]
	public static Guid AJCCBGLJAMD(FOCKAFCCMDA MCPMOAEEEOJ)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class AJLKBNAPPCH
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2262350", Offset = "0x2261750", VA = "0x182262350")]
	public static CMKMODODDJG IFDLICGNEEM([In] this OHJKOONDFBG MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x22622B0", Offset = "0x22616B0", VA = "0x1822622B0")]
	public static OHJKOONDFBG AJCCBGLJAMD(this CMKMODODDJG MCPMOAEEEOJ)
	{
		return default(OHJKOONDFBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class KEJJFBJAAPL
{
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2276D20", Offset = "0x2276120", VA = "0x182276D20")]
	public static FBEOENLNGKM IFDLICGNEEM([In] this FPLHNNLFDPF MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2276CC0", Offset = "0x22760C0", VA = "0x182276CC0")]
	public static FPLHNNLFDPF AJCCBGLJAMD(this FBEOENLNGKM MCPMOAEEEOJ)
	{
		return default(FPLHNNLFDPF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class BBKNCENPJKD
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x22640E0", Offset = "0x22634E0", VA = "0x1822640E0")]
	public static FLEOEPPMFDC IFDLICGNEEM([In] this BHBIDHMDCFI MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2264040", Offset = "0x2263440", VA = "0x182264040")]
	public static BHBIDHMDCFI AJCCBGLJAMD(this FLEOEPPMFDC MCPMOAEEEOJ)
	{
		return default(BHBIDHMDCFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class EMDEHNGIPHB
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2CD2C70", Offset = "0x2CD2070", VA = "0x182CD2C70")]
	public static void MKHFDCNLPBF<TDeserialized, TSerialized>(this IReadOnlyCollection<TDeserialized> MCPMOAEEEOJ, RepeatedField<TSerialized> GNHHNHJOMCE, JFPOPINHAOB<TDeserialized, TSerialized> DNBNCOEGKCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DMMCNDHKNCG
{
	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2268820", Offset = "0x2267C20", VA = "0x182268820")]
	public static MIDPMPLOFEB IFDLICGNEEM([In] this HPNBFACGAPA MCPMOAEEEOJ, [In] IPEKKNICFBG CGOGNBPFMJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x22684E0", Offset = "0x22678E0", VA = "0x1822684E0")]
	public static HPNBFACGAPA AJCCBGLJAMD(this MIDPMPLOFEB MCPMOAEEEOJ, [In] IPEKKNICFBG CGOGNBPFMJH)
	{
		return default(HPNBFACGAPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class BGDNNIPAMMH
{
	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x22645F0", Offset = "0x22639F0", VA = "0x1822645F0")]
	public static MHAMANOJHOF IFDLICGNEEM([In] this KMDEDNNHHFI MCPMOAEEEOJ, [In] HJJGMFAIGAE FNGDPCCALJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2264160", Offset = "0x2263560", VA = "0x182264160")]
	public static KMDEDNNHHFI AJCCBGLJAMD(this MHAMANOJHOF MCPMOAEEEOJ, [In] HJJGMFAIGAE FNGDPCCALJF)
	{
		return default(KMDEDNNHHFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OMFKGNPABLE
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2279B70", Offset = "0x2278F70", VA = "0x182279B70")]
	public static MGHIEELNDIF IFDLICGNEEM([In] this FPHNBDLONKK MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2279AC0", Offset = "0x2278EC0", VA = "0x182279AC0")]
	public static FPHNBDLONKK AJCCBGLJAMD(this MGHIEELNDIF MCPMOAEEEOJ)
	{
		return default(FPHNBDLONKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class PCMIKKIMLNO
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x227A130", Offset = "0x2279530", VA = "0x18227A130")]
	public static BLNDJBBNLFK IFDLICGNEEM(this PIJMOKLJHHD MCPMOAEEEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2279C60", Offset = "0x2279060", VA = "0x182279C60")]
	public static PIJMOKLJHHD AJCCBGLJAMD(this BLNDJBBNLFK MCPMOAEEEOJ, [In] AMOCPKHIDKG LMKJJGAGOOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class LFDPEHICAJM
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x22782C0", Offset = "0x22776C0", VA = "0x1822782C0")]
	public static FDBAICGGOIK IFDLICGNEEM([In] this AJGHNFAOCDE MCPMOAEEEOJ, FJIDBMMCBDN DPOLEDLIAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x2278170", Offset = "0x2277570", VA = "0x182278170")]
	public static AJGHNFAOCDE AJCCBGLJAMD(this FDBAICGGOIK MCPMOAEEEOJ)
	{
		return default(AJGHNFAOCDE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct OAMGIJONIOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly MIEEFIOIIBN<IMBJFPFGGEG> MGPFPEDPIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly MIEEFIOIIBN<HIBILKABFFC> HDAOCGPLIPN;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2072140", Offset = "0x2071540", VA = "0x182072140")]
	private OAMGIJONIOF(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> JKKLNMFHNAN, MIEEFIOIIBN<HIBILKABFFC> NKJGOEKGFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2279550", Offset = "0x2278950", VA = "0x182279550")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, OAMGIJONIOF> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, OAMGIJONIOF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2FF9860", Offset = "0x2FF8C60", VA = "0x182FF9860")]
	public static LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] OAMGIJONIOF MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct NDOEKKMMCGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA>? MJAJCILNEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly MIEEFIOIIBN<CKPANFPLABI> KFKKFLHACDG;

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x22130A0", Offset = "0x22124A0", VA = "0x1822130A0")]
	private NDOEKKMMCGM(MIEEFIOIIBN<ABNDNCLMDPA>? OPKNCABAKGK, MIEEFIOIIBN<CKPANFPLABI> BDFFCKBOEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2279150", Offset = "0x2278550", VA = "0x182279150")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, NDOEKKMMCGM> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, NDOEKKMMCGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2FB2020", Offset = "0x2FB1420", VA = "0x182FB2020")]
	public static LMFFMMPMNDB<MIEEFIOIIBN<ABNDNCLMDPA>, JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] NDOEKKMMCGM MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<MIEEFIOIIBN<ABNDNCLMDPA>, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct EDJIBMBLIKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public readonly MIEEFIOIIBN<LKDNFLJFHHO> FLFAKIMCFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly MIEEFIOIIBN<AJJFJLHFCKF> JMCBMNEKMDG;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2072140", Offset = "0x2071540", VA = "0x182072140")]
	private EDJIBMBLIKC(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2268B10", Offset = "0x2267F10", VA = "0x182268B10")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, EDJIBMBLIKC> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, EDJIBMBLIKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5450", Offset = "0x2CC4850", VA = "0x182CC5450")]
	public static LMFFMMPMNDB<MIEEFIOIIBN<HIBILKABFFC>, JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] EDJIBMBLIKC MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<MIEEFIOIIBN<HIBILKABFFC>, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct ENBJAMKHGFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public readonly MIEEFIOIIBN<LIGCAJFGNCM> IJAGBKKNIDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public readonly DPPHGIGHBKC ADKILKCAHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public readonly FHHIKJNGAEG CKEEBDBDPCG;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x22692D0", Offset = "0x22686D0", VA = "0x1822692D0")]
	private ENBJAMKHGFN(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LIGCAJFGNCM> MNGBKMDLAGP, [In] DPPHGIGHBKC ADKLBMNABMC, [In] FHHIKJNGAEG LGBGAMDOFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2269160", Offset = "0x2268560", VA = "0x182269160")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, ENBJAMKHGFN> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, ENBJAMKHGFN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4AE0", Offset = "0x2CD3EE0", VA = "0x182CD4AE0")]
	public static LMFFMMPMNDB<MIEEFIOIIBN<LKDNFLJFHHO>, JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] ENBJAMKHGFN MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<MIEEFIOIIBN<LKDNFLJFHHO>, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct NJCHHGHADFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public readonly MIEEFIOIIBN<LKDNFLJFHHO> FLFAKIMCFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public readonly int OKGGDLBCCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly FPLHNNLFDPF NKDPEDOOFIH;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x22778B0", Offset = "0x2276CB0", VA = "0x1822778B0")]
	private NJCHHGHADFF(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, int KLEBBHLPMGG, FPLHNNLFDPF DPOLEDLIAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2279360", Offset = "0x2278760", VA = "0x182279360")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, NJCHHGHADFF> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, NJCHHGHADFF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x2FB95C0", Offset = "0x2FB89C0", VA = "0x182FB95C0")]
	public static LMFFMMPMNDB<(MIEEFIOIIBN<HIBILKABFFC>, MIEEFIOIIBN<IMBJFPFGGEG>), JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] NJCHHGHADFF MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<(MIEEFIOIIBN<HIBILKABFFC>, MIEEFIOIIBN<IMBJFPFGGEG>), JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct LDHBPBHCEJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly MIEEFIOIIBN<LKDNFLJFHHO> FLFAKIMCFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly int EHNEBACJCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly FPLHNNLFDPF NKDPEDOOFIH;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x22778B0", Offset = "0x2276CB0", VA = "0x1822778B0")]
	private LDHBPBHCEJJ(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, int KLEBBHLPMGG, FPLHNNLFDPF DPOLEDLIAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2277740", Offset = "0x2276B40", VA = "0x182277740")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, LDHBPBHCEJJ> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, LDHBPBHCEJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2F03FC0", Offset = "0x2F033C0", VA = "0x182F03FC0")]
	public static LMFFMMPMNDB<(MIEEFIOIIBN<IMBJFPFGGEG>, MIEEFIOIIBN<HIBILKABFFC>), JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] LDHBPBHCEJJ MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<(MIEEFIOIIBN<IMBJFPFGGEG>, MIEEFIOIIBN<HIBILKABFFC>), JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct OEMMMKFLMMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public readonly MIEEFIOIIBN<LKDNFLJFHHO> FLFAKIMCFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly int OKGGDLBCCIL;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2072140", Offset = "0x2071540", VA = "0x182072140")]
	private OEMMMKFLMMF(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, int CNAIPFMACGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2279620", Offset = "0x2278A20", VA = "0x182279620")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, OEMMMKFLMMF> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, OEMMMKFLMMF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2FFC740", Offset = "0x2FFBB40", VA = "0x182FFC740")]
	public static LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] OEMMMKFLMMF MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct MMELKBCPPMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly MIEEFIOIIBN<LKDNFLJFHHO> FLFAKIMCFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public readonly int EHNEBACJCLN;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2072140", Offset = "0x2071540", VA = "0x182072140")]
	private MMELKBCPPMN(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, int CNAIPFMACGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2278540", Offset = "0x2277940", VA = "0x182278540")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, MMELKBCPPMN> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, MMELKBCPPMN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2F44170", Offset = "0x2F43570", VA = "0x182F44170")]
	public static LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] MMELKBCPPMN MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct EEKMJLPOGMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public readonly MIEEFIOIIBN<HIBILKABFFC> HBKOJDFPBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public readonly AJGHNFAOCDE APHHEDCAJLK;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2268CF0", Offset = "0x22680F0", VA = "0x182268CF0")]
	private EEKMJLPOGMP(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH, [In] AJGHNFAOCDE BMLEAJPEFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2268BE0", Offset = "0x2267FE0", VA = "0x182268BE0")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, EEKMJLPOGMP> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, EEKMJLPOGMP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2CC5880", Offset = "0x2CC4C80", VA = "0x182CC5880")]
	public static LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] EEKMJLPOGMP MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct KOLHKNCFFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly MIEEFIOIIBN<IMBJFPFGGEG> MGPFPEDPIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly MIEEFIOIIBN<HIBILKABFFC> HDAOCGPLIPN;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2072140", Offset = "0x2071540", VA = "0x182072140")]
	private KOLHKNCFFFK(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> JKKLNMFHNAN, MIEEFIOIIBN<HIBILKABFFC> NKJGOEKGFEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x22774E0", Offset = "0x22768E0", VA = "0x1822774E0")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, KOLHKNCFFFK> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, KOLHKNCFFFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2EEA610", Offset = "0x2EE9A10", VA = "0x182EEA610")]
	public static LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] KOLHKNCFFFK MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct GEMNOOJOIHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC;

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
	private GEMNOOJOIHI(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x22699F0", Offset = "0x2268DF0", VA = "0x1822699F0")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, GEMNOOJOIHI> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, GEMNOOJOIHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2E5B570", Offset = "0x2E5A970", VA = "0x182E5B570")]
	public static LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] GEMNOOJOIHI MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct MMBFMGMJNKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly MIEEFIOIIBN<ABNDNCLMDPA> BPADNIEBHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public readonly MIEEFIOIIBN<LKDNFLJFHHO> FLFAKIMCFJA;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
	private MMBFMGMJNKC(MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2278480", Offset = "0x2277880", VA = "0x182278480")]
	public static DAGAJHJFHEN<BFOPIJOMCBH, MMBFMGMJNKC> GLOMKEHEIBB(IIIMLHFAMEO DJLOCNEPNPC)
	{
		return default(DAGAJHJFHEN<BFOPIJOMCBH, MMBFMGMJNKC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2F44090", Offset = "0x2F43490", VA = "0x182F44090")]
	public static LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH> JGMEIPOPKPO<TRoot>(TRoot KCFGMPGPMFA, [In] MMBFMGMJNKC MCPMOAEEEOJ) where TRoot : ENDCBPFDIAM
	{
		return default(LMFFMMPMNDB<IOADHBFKJOJ, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class CLGMBIGNILA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly Guid NKNGCBFKAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public readonly bool JPFOFDONOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly bool OMKFMOBFDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly bool EJDGLEHADPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public readonly bool KIEGMHJDIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public readonly bool MBHIHHNJGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private readonly List<(string Name, FJIDBMMCBDN Type)> PJCADMODENK;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public Guid DMJALGAFDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x22222C0", Offset = "0x22216C0", VA = "0x1822222C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public string ICAKBBAJKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A00", Offset = "0x8A7E00", VA = "0x1808A8A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public IReadOnlyList<(string Name, FJIDBMMCBDN Type)> NBFOLJIMPFF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action KDNFFNIDOPB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2265F30", Offset = "0x2265330", VA = "0x182265F30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2265E90", Offset = "0x2265290", VA = "0x182265E90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<string, FJIDBMMCBDN> BMAMBKIKKJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2266500", Offset = "0x2265900", VA = "0x182266500")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2265CF0", Offset = "0x22650F0", VA = "0x182265CF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<int> LBOFANDNJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2266120", Offset = "0x2265520", VA = "0x182266120")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2265920", Offset = "0x2264D20", VA = "0x182265920")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<int, string> ELILDHGOAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2265A90", Offset = "0x2264E90", VA = "0x182265A90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x22663F0", Offset = "0x22657F0", VA = "0x1822663F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<int, FJIDBMMCBDN> MHEHEMHJNAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2265FD0", Offset = "0x22653D0", VA = "0x182265FD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2265B40", Offset = "0x2264F40", VA = "0x182265B40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action EHPJJIAPPFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x22659D0", Offset = "0x2264DD0", VA = "0x1822659D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x2266080", Offset = "0x2265480", VA = "0x182266080")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2265A70", Offset = "0x2264E70", VA = "0x182265A70")]
	public void FPFJONBOOBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x22665B0", Offset = "0x22659B0", VA = "0x1822665B0")]
	internal CLGMBIGNILA([In] Guid NKPCGMJMEIE, string DDDHPCNFCEK, bool JPANLEBOBFO, bool HPLNGAGKIJH, bool INMIJKMEICH, bool GACLNPKGGHE, bool FHLBJIBCEGF, List<(string Name, FJIDBMMCBDN Type)> DIGOHHPBNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2265C60", Offset = "0x2265060", VA = "0x182265C60")]
	public static IBLCNNKGDKG LJILBNHJJFC(string NKPCGMJMEIE, string DDDHPCNFCEK, bool JPANLEBOBFO = false, bool HPLNGAGKIJH = false, bool INMIJKMEICH = false, bool GACLNPKGGHE = true, bool FHLBJIBCEGF = true)
	{
		return default(IBLCNNKGDKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2266310", Offset = "0x2265710", VA = "0x182266310")]
	public static CLGMBIGNILA OEKPAIAEEGM([In] Guid NKPCGMJMEIE, string DDDHPCNFCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x22664A0", Offset = "0x22658A0", VA = "0x1822664A0")]
	public void PFDLNGDFOHK(string DDDHPCNFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2265DA0", Offset = "0x22651A0", VA = "0x182265DA0")]
	public void LMJAKHNEJPF(int HAJICDLBEKC, string FBOCPMBJHCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2265830", Offset = "0x2264C30", VA = "0x182265830")]
	public void BBKFMJMFAPH(int HAJICDLBEKC, FJIDBMMCBDN FMLKNACJGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x22661D0", Offset = "0x22655D0", VA = "0x1822661D0")]
	public void OBGOGKCFPMM(string DDDHPCNFCEK, FJIDBMMCBDN EEKGNLEDDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2265BF0", Offset = "0x2264FF0", VA = "0x182265BF0")]
	public void KNHLEJPABOB(int HAJICDLBEKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct IBLCNNKGDKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Guid NKNGCBFKAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly string CENOPFAEPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly bool OMHOPBPPHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly bool DKCPKPOMGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly bool HEPLMBEEFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly bool CGPAPAIPCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly bool CANDCHNFFGP;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x226C670", Offset = "0x226BA70", VA = "0x18226C670")]
	public IBLCNNKGDKG([In] Guid NKPCGMJMEIE, string DDDHPCNFCEK, bool JPANLEBOBFO, bool HPLNGAGKIJH, bool INMIJKMEICH, bool GACLNPKGGHE, bool FHLBJIBCEGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x226C3D0", Offset = "0x226B7D0", VA = "0x18226C3D0")]
	public GOOMMAFKKGB FMOLBDFBDIK(string DDDHPCNFCEK, FJIDBMMCBDN DPOLEDLIAMP)
	{
		return default(GOOMMAFKKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x226C550", Offset = "0x226B950", VA = "0x18226C550")]
	public CLGMBIGNILA KNNOOCDGMKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct GOOMMAFKKGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly Guid NKNGCBFKAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly string CENOPFAEPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly bool OMHOPBPPHCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly bool DKCPKPOMGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly bool HEPLMBEEFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly bool CGPAPAIPCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private readonly bool CANDCHNFFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly List<(string Name, FJIDBMMCBDN Type)> PJCADMODENK;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2269F50", Offset = "0x2269350", VA = "0x182269F50")]
	public GOOMMAFKKGB([In] Guid NKPCGMJMEIE, string DDDHPCNFCEK, bool JPANLEBOBFO, bool HPLNGAGKIJH, bool INMIJKMEICH, bool GACLNPKGGHE, bool FHLBJIBCEGF, List<(string Name, FJIDBMMCBDN Type)> DIGOHHPBNFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2269D10", Offset = "0x2269110", VA = "0x182269D10")]
	public GOOMMAFKKGB FMOLBDFBDIK(string DDDHPCNFCEK, FJIDBMMCBDN DPOLEDLIAMP)
	{
		return default(GOOMMAFKKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x2269E60", Offset = "0x2269260", VA = "0x182269E60")]
	public CLGMBIGNILA KNNOOCDGMKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GDHDDELIGMP
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class BOJJJJAGOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly CLGMBIGNILA HPKPKOJKFPB;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly CLGMBIGNILA DADHFBKOMBL;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class LCGKLBJLHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly CLGMBIGNILA JNAGBDDABID;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class DLLACPHFPOK
	{
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly CLGMBIGNILA PEOJDHHCIOK;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly CLGMBIGNILA JLEDJMJBMIE;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class AGFPPFABCLO
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class BIJEGECMMNG
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly CLGMBIGNILA JBDKNIPKOCJ;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly CLGMBIGNILA GBFCILLLJPE;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class KOJAFEOKMIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly CLGMBIGNILA PGIDAOLHLME;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly CLGMBIGNILA PEPPHGEBNMD;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class IBCCIFKJPPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly CLGMBIGNILA PEOJDHHCIOK;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly CLGMBIGNILA JLEDJMJBMIE;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class MNAHIGMELMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly CLGMBIGNILA PCKBGNIPAEN;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly CLGMBIGNILA FGIBEGPOFEA;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly CLGMBIGNILA ILNAMMLCICB;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly CLGMBIGNILA FALNKDIHFCD;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly CLGMBIGNILA CFJNKMNAABG;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly CLGMBIGNILA AHPGBILEOAC;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly CLGMBIGNILA ABDHAPHCOMN;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class PLOKIBFELNJ
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class GAOLFIPOBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class ICMNBNEBKOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class BMFLLGAPBLM
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly CLGMBIGNILA IADIBGPPNNL;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly CLGMBIGNILA JIEDNHKGDLL;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class KHLGCGPGNJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class NINGCLDHJHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class KMFEKJILEJL
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class DJODHHBEGHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class BMMCGJPFCKH
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly CLGMBIGNILA JGFPNHEMMLL;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class AECDKMJBIDE
	{
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly CLGMBIGNILA AIBGGACNOHB;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly CLGMBIGNILA OBEHHBKBNGL;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly CLGMBIGNILA APOMOEOCGHG;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly CLGMBIGNILA PGIDAOLHLME;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly CLGMBIGNILA BLAJFFPBMKH;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly CLGMBIGNILA GHLDDAKJBBH;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly CLGMBIGNILA KIHOCLEGIBE;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly CLGMBIGNILA KHELMEMNLJK;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly CLGMBIGNILA HANJIKAOAFC;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly CLGMBIGNILA AAGACHODCLO;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly CLGMBIGNILA GFKLIMIEJBC;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly CLGMBIGNILA LHHDADFHNBJ;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly CLGMBIGNILA KCDKMLDGFIO;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly CLGMBIGNILA IMAKANDFEMI;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly CLGMBIGNILA LJHDINBCMGH;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly CLGMBIGNILA GKINODAMCHD;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly CLGMBIGNILA DHNPFLGPCPB;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly CLGMBIGNILA AHFNPNHJNID;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public static readonly CLGMBIGNILA DACGMKEBNHC;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly CLGMBIGNILA GBEMHHKODEN;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly CLGMBIGNILA HOKFDIHOAAF;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly CLGMBIGNILA IFBPHIDOPKL;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly CLGMBIGNILA LMADPNDLNEA;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly CLGMBIGNILA IKPMCLOJNMF;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public static readonly CLGMBIGNILA BONAEMILKHB;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public static readonly CLGMBIGNILA PDFFBOEGCLH;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly CLGMBIGNILA PPFHNMPLEEH;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public static readonly CLGMBIGNILA AIJEILDNGMN;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public static readonly CLGMBIGNILA PMAGMIAPFBI;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public static readonly CLGMBIGNILA OFMBFGMKFHN;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public static readonly CLGMBIGNILA FFJCBLHMDNF;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public static readonly CLGMBIGNILA KLIHMCEIEGF;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public static readonly CLGMBIGNILA IPNCOPJGPLK;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public static readonly CLGMBIGNILA IEEPCCDHBPO;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public static readonly CLGMBIGNILA DCLPHKFCKMC;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public static readonly CLGMBIGNILA AMDEPHDFIGO;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static readonly CLGMBIGNILA LMBOKKMBFLM;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public static readonly CLGMBIGNILA GJLNKEJAOHB;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static readonly CLGMBIGNILA OILOIPFIHJE;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public static readonly CLGMBIGNILA FCMGEKOJOLK;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public static readonly CLGMBIGNILA DLLOFINOJAM;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public static readonly CLGMBIGNILA PJNIJDKEMBB;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public static readonly CLGMBIGNILA HMBKIPKBEPI;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static readonly CLGMBIGNILA NLHDHDHIGCB;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public static readonly CLGMBIGNILA CADHIIHIDNL;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public static readonly CLGMBIGNILA BNEFEPPEJPP;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public static readonly CLGMBIGNILA OHBIOJGKGBL;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static readonly CLGMBIGNILA OEFMNBJDNGL;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public static readonly CLGMBIGNILA LAKBJJJIDCF;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public static readonly CLGMBIGNILA OKEMJKMOJLC;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static readonly CLGMBIGNILA BOAGPILJDLL;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public static readonly CLGMBIGNILA KBIFOPAIEEA;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public static readonly CLGMBIGNILA JMPAHGGDEPC;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public static readonly CLGMBIGNILA GLLDLIGEIHJ;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public static readonly CLGMBIGNILA DPPDCPHIMGC;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public static readonly CLGMBIGNILA HPLIENLMCKO;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public static readonly CLGMBIGNILA HABNCGOHPHK;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public static readonly CLGMBIGNILA PBFIDOHKECH;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public static readonly CLGMBIGNILA EBPMNFEALNI;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public static readonly CLGMBIGNILA HAGOPBJMPBH;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class KJJJLFFEBBF
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class HAJFGJFFGAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public static readonly CLGMBIGNILA BKJDCDIMIIO;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly CLGMBIGNILA HNEMOMPNNFO;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public static readonly CLGMBIGNILA HALIMGEDOFL;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public static readonly CLGMBIGNILA PHHCJNFBIOJ;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public static readonly CLGMBIGNILA KLAOFELDEAA;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public static readonly CLGMBIGNILA IAEMKHPCPGA;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class ABIACKLPHDK
	{
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly CLGMBIGNILA AIBGGACNOHB;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public static readonly CLGMBIGNILA OBEHHBKBNGL;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly CLGMBIGNILA OAODFHGNLHI;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public static readonly CLGMBIGNILA DPMOFAFDFFJ;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public static readonly CLGMBIGNILA NBNDJKEBKNO;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public static readonly CLGMBIGNILA ODMPBHNFAMG;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class PKDBIACDONB
	{
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly CLGMBIGNILA ELGMPFIFMKG;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public static readonly CLGMBIGNILA LPGOIBNKNFB;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public static readonly CLGMBIGNILA BPAKPCBEKKE;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly CLGMBIGNILA BHANEHKPMCI;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly CLGMBIGNILA CPAMGBJHKNJ;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public static readonly CLGMBIGNILA POKNMCBFLFO;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class OMCFBLMIDGB
	{
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class CFFLHFNJECF
	{
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class LIGGEEDFLCB
	{
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public static readonly CLGMBIGNILA DGMPKHBMLMB;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class HAGDJGAPJCF
	{
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public static readonly CLGMBIGNILA JGFPNHEMMLL;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class EPPOEJLFMGK
	{
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class FIKLBNDEMAD
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class HEMKABEPEFM
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static readonly CLGMBIGNILA KDMPGNHMGPL;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public static readonly CLGMBIGNILA OEAFGFBIIGP;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static readonly CLGMBIGNILA NFBDLKONBJL;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public static readonly CLGMBIGNILA EJELDIINGGK;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class NEOCIOHAKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public static readonly CLGMBIGNILA GFMEOLIBBNJ;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public static readonly CLGMBIGNILA EANLMMKLCEE;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class PJNLFFDOPPB
	{
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class AIDDMJOMGKJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public static readonly CLGMBIGNILA BKJDCDIMIIO;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public static readonly CLGMBIGNILA HNEMOMPNNFO;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class GNCDOJMKCKO
	{
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public static readonly CLGMBIGNILA HJCOBLNHBFA;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public static readonly CLGMBIGNILA PHHCJNFBIOJ;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public static readonly CLGMBIGNILA KLAOFELDEAA;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public static readonly CLGMBIGNILA IAEMKHPCPGA;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public static readonly CLGMBIGNILA HELIMGODKOD;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public static readonly CLGMBIGNILA FMEMHAMAPFH;

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public static readonly CLGMBIGNILA DIECMBELPLD;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public static readonly CLGMBIGNILA MCHJGFHJLEH;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public static readonly CLGMBIGNILA OIPHDANCKNC;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public static readonly CLGMBIGNILA HBAIOFCOKNP;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public static readonly CLGMBIGNILA BKJDCDIMIIO;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public static readonly CLGMBIGNILA HNEMOMPNNFO;

		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class KKDNBIDFKNP
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class GNDKOACMEDN
	{
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public static readonly CLGMBIGNILA BKJDCDIMIIO;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public static readonly CLGMBIGNILA HNEMOMPNNFO;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public static readonly CLGMBIGNILA NEIKLJDCABE;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public static readonly CLGMBIGNILA NEPFJIDAEIP;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public static readonly CLGMBIGNILA BPEHNEDGOFC;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public static class MCJGDBFAOOA
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class IPICFIJIBJD
	{
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public static readonly CLGMBIGNILA MEGKGOFPIHO;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class GNOJNGFNGLO
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public static readonly CLGMBIGNILA BPBGHODPCPO;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public static readonly CLGMBIGNILA AKKFCFAMGME;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public static readonly CLGMBIGNILA BKJDCDIMIIO;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public static readonly CLGMBIGNILA HNEMOMPNNFO;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class JFHCMCKMKIN
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public static class AEPLODBEKMG
	{
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public static class CECFCNPOMKF
	{
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class KDFDJBELINA
	{
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class FFEEGKAOJJE
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public static readonly CLGMBIGNILA IADIBGPPNNL;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public static readonly CLGMBIGNILA JIEDNHKGDLL;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class BOIMDFGGBFK
	{
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public static readonly CLGMBIGNILA EFKPNHMMKOL;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public static readonly CLGMBIGNILA MFBACBGIOJL;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public static readonly CLGMBIGNILA KBGHFPLLBNP;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public static readonly CLGMBIGNILA GHAPFHAHDEB;

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public static class GOFKBIEIMOK
	{
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public static readonly CLGMBIGNILA EFKPNHMMKOL;

		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public static readonly CLGMBIGNILA MFBACBGIOJL;

		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public static readonly CLGMBIGNILA KBGHFPLLBNP;

		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public static readonly CLGMBIGNILA GHAPFHAHDEB;

		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class LEFJOKBPALL
	{
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class GNCLIIGPNAL
	{
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public static readonly CLGMBIGNILA CHIFIOJFOPI;

		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public static readonly CLGMBIGNILA DDEODNHCKDK;

		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public static readonly CLGMBIGNILA OECJEJLIDPA;

		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public static class JGACGGJBDPL
	{
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public static readonly CLGMBIGNILA EFILFIHGIFC;

		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public static readonly CLGMBIGNILA IEFEMKNDIIG;

		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public static readonly CLGMBIGNILA ANNEMCMHEHG;

		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class DKDCAABGLFF
	{
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class FEINNCILFNF
	{
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public static readonly CLGMBIGNILA GOPNBOANKDJ;

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public static readonly CLGMBIGNILA CKDJDNMLKMG;

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public static readonly CLGMBIGNILA GACAFHMFPEN;

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public static readonly CLGMBIGNILA MANDFOHLMNJ;

		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public static readonly CLGMBIGNILA LPKJGEABMAK;

		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public static class CDKNNJKMJKI
	{
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public static readonly CLGMBIGNILA LLFHFBMPJGB;

		[Cpp2IlInjected.Token(Token = "0x4000200")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public static class DLNFNECBDGE
	{
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public static readonly CLGMBIGNILA CJKMKHGALAI;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public static readonly CLGMBIGNILA JBHHJDPOFGE;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public static readonly CLGMBIGNILA HFOALNEDOOL;

		[Cpp2IlInjected.Token(Token = "0x4000204")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class DPHOJBAENIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public static class HJKEBFCFDKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public static class IOOBIFLMFKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public static class ABHNCKFNDFP
	{
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public static readonly CLGMBIGNILA NAGAGLIAMNF;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public static readonly CLGMBIGNILA NJIMJANHJON;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public static readonly CLGMBIGNILA JDFOIGOPHFJ;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		internal static readonly CLGMBIGNILA[] AGBCAPOGEMP;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class DLMNIGGIEMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	public readonly FJIDBMMCBDN JFLDJJFGCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly List<CLGMBIGNILA> DDLDABFCCPC;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IReadOnlyList<CLGMBIGNILA> PDIJCEAJEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2282150", Offset = "0x2281550", VA = "0x182282150")]
	protected DLMNIGGIEMH(FJIDBMMCBDN FCEBPDNGMCM, params CLGMBIGNILA[][] EMOLLDGONPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class MOJHPHNLAFJ : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x228DDD0", Offset = "0x228D1D0", VA = "0x18228DDD0")]
	internal MOJHPHNLAFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LCBLKMPOEFG : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x228BB00", Offset = "0x228AF00", VA = "0x18228BB00")]
	internal LCBLKMPOEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class IIJNOMGBAJP : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2289780", Offset = "0x2288B80", VA = "0x182289780")]
	internal IIJNOMGBAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class PJMLMDPBKLO : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x228F9E0", Offset = "0x228EDE0", VA = "0x18228F9E0")]
	internal PJMLMDPBKLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class IOEIGCGIGKD : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2289CD0", Offset = "0x22890D0", VA = "0x182289CD0")]
	internal IOEIGCGIGKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class GCJPHCNEKPK : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x22850E0", Offset = "0x22844E0", VA = "0x1822850E0")]
	internal GCJPHCNEKPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GAAEJHFAPBD : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2284F00", Offset = "0x2284300", VA = "0x182284F00")]
	internal GAAEJHFAPBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class OOGFLGGLBCI : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x228F620", Offset = "0x228EA20", VA = "0x18228F620")]
	internal OOGFLGGLBCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class KDEEDCFMEMF : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x228AC30", Offset = "0x228A030", VA = "0x18228AC30")]
	internal KDEEDCFMEMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class EPHJAKODDAE : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2282CB0", Offset = "0x22820B0", VA = "0x182282CB0")]
	internal EPHJAKODDAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class ELPDNHOPFNN : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x22828F0", Offset = "0x2281CF0", VA = "0x1822828F0")]
	internal ELPDNHOPFNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class CHGFGAADPIH : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2281660", Offset = "0x2280A60", VA = "0x182281660")]
	internal CHGFGAADPIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class IFFAHGPGFBN : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x22893F0", Offset = "0x22887F0", VA = "0x1822893F0")]
	internal IFFAHGPGFBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class NPEAJKBNBGO : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x228F200", Offset = "0x228E600", VA = "0x18228F200")]
	internal NPEAJKBNBGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class AEKMLFDEPFN : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x227F7D0", Offset = "0x227EBD0", VA = "0x18227F7D0")]
	internal AEKMLFDEPFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class KGFBJILPFMH : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x228AE70", Offset = "0x228A270", VA = "0x18228AE70")]
	internal KGFBJILPFMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class NBJJOLLFCHN : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x228E190", Offset = "0x228D590", VA = "0x18228E190")]
	internal NBJJOLLFCHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class MENFNNLHOOF : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x228D060", Offset = "0x228C460", VA = "0x18228D060")]
	internal MENFNNLHOOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class LBDIGLKPMBN : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x228B8B0", Offset = "0x228ACB0", VA = "0x18228B8B0")]
	internal LBDIGLKPMBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class LLFIIGOIEJB : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x228C470", Offset = "0x228B870", VA = "0x18228C470")]
	internal LLFIIGOIEJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class AONDOEJMBJA : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x227FDD0", Offset = "0x227F1D0", VA = "0x18227FDD0")]
	internal AONDOEJMBJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class OINCEHDGBNB : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x228F3E0", Offset = "0x228E7E0", VA = "0x18228F3E0")]
	internal OINCEHDGBNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class JPIJICIJBKP : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x228AA50", Offset = "0x2289E50", VA = "0x18228AA50")]
	internal JPIJICIJBKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class HOGHFANAANE : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x2289020", Offset = "0x2288420", VA = "0x182289020")]
	internal HOGHFANAANE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class PJDKOEHILNL : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x228F800", Offset = "0x228EC00", VA = "0x18228F800")]
	internal PJDKOEHILNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class NJFFGMNOKCE : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x228EE40", Offset = "0x228E240", VA = "0x18228EE40")]
	internal NJFFGMNOKCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class KKGEBIPJFIM : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x228B2F0", Offset = "0x228A6F0", VA = "0x18228B2F0")]
	internal KKGEBIPJFIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class NALOFPIMNON : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x228DFB0", Offset = "0x228D3B0", VA = "0x18228DFB0")]
	internal NALOFPIMNON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class EOPIIBOPEOL : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2282AD0", Offset = "0x2281ED0", VA = "0x182282AD0")]
	internal EOPIIBOPEOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class BLLKBIOAFPH : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x22808B0", Offset = "0x227FCB0", VA = "0x1822808B0")]
	internal BLLKBIOAFPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class LEKEIHHCDBE : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x228BD40", Offset = "0x228B140", VA = "0x18228BD40")]
	internal LEKEIHHCDBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class HAOHMNEKFIB : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x2287F40", Offset = "0x2287340", VA = "0x182287F40")]
	internal HAOHMNEKFIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class HMLEHPPBAJN : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2288C80", Offset = "0x2288080", VA = "0x182288C80")]
	internal HMLEHPPBAJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class MHFJHAKOKEP : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x228D240", Offset = "0x228C640", VA = "0x18228D240")]
	internal MHFJHAKOKEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class NHIENFJJHLI : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x228EBE0", Offset = "0x228DFE0", VA = "0x18228EBE0")]
	internal NHIENFJJHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class AEJKHCPALHF : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x227F5F0", Offset = "0x227E9F0", VA = "0x18227F5F0")]
	internal AEJKHCPALHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class KIOHHBJIDJE : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x228B050", Offset = "0x228A450", VA = "0x18228B050")]
	internal KIOHHBJIDJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class LGPFHMLBEHC : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x228BF20", Offset = "0x228B320", VA = "0x18228BF20")]
	internal LGPFHMLBEHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class BPOJLOKKODC : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x2281170", Offset = "0x2280570", VA = "0x182281170")]
	internal BPOJLOKKODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class MMEKHPOGIOO : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x228D4A0", Offset = "0x228C8A0", VA = "0x18228D4A0")]
	internal MMEKHPOGIOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class JNLHOKKKOHA : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x228A870", Offset = "0x2289C70", VA = "0x18228A870")]
	internal JNLHOKKKOHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class NLJINOLLHAE : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x228F020", Offset = "0x228E420", VA = "0x18228F020")]
	internal NLJINOLLHAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class CODNKBFEMEC : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2281AF0", Offset = "0x2280EF0", VA = "0x182281AF0")]
	internal CODNKBFEMEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class CMBJIEIAJLG : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2281910", Offset = "0x2280D10", VA = "0x182281910")]
	internal CMBJIEIAJLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class DGGHKLCLDND : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2281F10", Offset = "0x2281310", VA = "0x182281F10")]
	internal DGGHKLCLDND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class NCFOPHDGFEO : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x228E370", Offset = "0x228D770", VA = "0x18228E370")]
	internal NCFOPHDGFEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class FPAJCBBKIEN : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2284B00", Offset = "0x2283F00", VA = "0x182284B00")]
	internal FPAJCBBKIEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class LOCEJHJBLME : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x228C6D0", Offset = "0x228BAD0", VA = "0x18228C6D0")]
	internal LOCEJHJBLME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class ADNBBDGPMGO : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x227F410", Offset = "0x227E810", VA = "0x18227F410")]
	internal ADNBBDGPMGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class BEFMGGOJAFA : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2280680", Offset = "0x227FA80", VA = "0x182280680")]
	internal BEFMGGOJAFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class DOKKPDBGALN : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2282670", Offset = "0x2281A70", VA = "0x182282670")]
	internal DOKKPDBGALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class CHKBPOGFDHB : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2281730", Offset = "0x2280B30", VA = "0x182281730")]
	internal CHKBPOGFDHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class DFKKNDPFNIA : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2281D30", Offset = "0x2281130", VA = "0x182281D30")]
	internal DFKKNDPFNIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class JGOCFCOGIGK : DLMNIGGIEMH
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x228A690", Offset = "0x2289A90", VA = "0x18228A690")]
	internal JGOCFCOGIGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public sealed class FIAMFHLDHPG : MOECJJACIPO
{
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2284730", Offset = "0x2283B30", VA = "0x182284730")]
	public FIAMFHLDHPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public abstract class ELBNMKOLOEG : IGGEKLJPMMA<PIJMOKLJHHD>
{
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x22828B0", Offset = "0x2281CB0", VA = "0x1822828B0")]
	protected ELBNMKOLOEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public abstract class LIHNKOIDGEH : EDHBLEBOOHI<PIJMOKLJHHD>
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2280860", Offset = "0x227FC60", VA = "0x182280860")]
	protected LIHNKOIDGEH([In] POOFKIAEEBF JHBANNGAEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x228C350", Offset = "0x228B750", VA = "0x18228C350", Slot = "11")]
	public override void MPMEBFCPMDO(PIJMOKLJHHD KCFGMPGPMFA, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, OEANGFGCLHO ECHCIKCBIED, MIEEFIOIIBN<PCDHPDNGICC.HJDBMJEKEBM>? NLLGOKIEPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x228C3E0", Offset = "0x228B7E0", VA = "0x18228C3E0", Slot = "14")]
	public override void OIHCPGGHJLE(PIJMOKLJHHD KCFGMPGPMFA, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public abstract class BLFDMAAKCKP : LIHNKOIDGEH
{
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x2280860", Offset = "0x227FC60", VA = "0x182280860")]
	public BLFDMAAKCKP([In] POOFKIAEEBF JHBANNGAEBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class KLLCCMLHBDM : ELBNMKOLOEG
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "11")]
	public override void MPMEBFCPMDO(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, OEANGFGCLHO ECHCIKCBIED, MIEEFIOIIBN<PCDHPDNGICC.HJDBMJEKEBM>? NLLGOKIEPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "12")]
	public override void AMMMGJHMDGB(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x228B4D0", Offset = "0x228A8D0", VA = "0x18228B4D0", Slot = "13")]
	public override IEnumerable<CPPIKLDEGAN<FJIDBMMCBDN>> FAFHDFEKAEH(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x228B500", Offset = "0x228A900", VA = "0x18228B500", Slot = "14")]
	public override void OIHCPGGHJLE(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x228B7B0", Offset = "0x228ABB0", VA = "0x18228B7B0")]
	public static void PGLOIMCOMHD(PIJMOKLJHHD NCIHMAFAKAP, [In] BAFKBFILGOE.HMOFPNFCDJH OJGPBFFHNKH, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x22830D0", Offset = "0x22824D0", VA = "0x1822830D0", Slot = "15")]
	public override AJGHNFAOCDE BFICIONOKJO(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ, FJIDBMMCBDN AOICPEGICFC)
	{
		return default(AJGHNFAOCDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x22828B0", Offset = "0x2281CB0", VA = "0x1822828B0")]
	public KLLCCMLHBDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public sealed class FCDKJKPGPDK : ELBNMKOLOEG
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class LFIIPHOGMIK : FKAHMBEAONA.FLLPJEELKEO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public struct NOLNGMBPCMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public readonly MIEEFIOIIBN<ABNDNCLMDPA> PHGBPOKNLPJ;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
		private NOLNGMBPCMM(MIEEFIOIIBN<ABNDNCLMDPA> NAHOJFKLEOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1731A10", Offset = "0x1730E10", VA = "0x181731A10")]
		public static NOLNGMBPCMM AHLALEPNKFA(MIEEFIOIIBN<ABNDNCLMDPA> OAOCPDKKMNE)
		{
			return default(NOLNGMBPCMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x22832A0", Offset = "0x22826A0", VA = "0x1822832A0", Slot = "11")]
	public override void MPMEBFCPMDO(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, OEANGFGCLHO ECHCIKCBIED, MIEEFIOIIBN<PCDHPDNGICC.HJDBMJEKEBM>? NLLGOKIEPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2282EF0", Offset = "0x22822F0", VA = "0x182282EF0", Slot = "12")]
	public override void AMMMGJHMDGB(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2283110", Offset = "0x2282510", VA = "0x182283110", Slot = "13")]
	public override IEnumerable<CPPIKLDEGAN<FJIDBMMCBDN>> FAFHDFEKAEH(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2283450", Offset = "0x2282850", VA = "0x182283450", Slot = "14")]
	public override void OIHCPGGHJLE(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x22831A0", Offset = "0x22825A0", VA = "0x1822831A0")]
	public static void KIHJOBEGAME(PIJMOKLJHHD NCIHMAFAKAP, [In] BAFKBFILGOE.HMOFPNFCDJH OJGPBFFHNKH, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2283940", Offset = "0x2282D40", VA = "0x182283940")]
	public static void PGLOIMCOMHD(PIJMOKLJHHD NCIHMAFAKAP, [In] BAFKBFILGOE.HMOFPNFCDJH OJGPBFFHNKH, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x22830D0", Offset = "0x22824D0", VA = "0x1822830D0", Slot = "15")]
	public override AJGHNFAOCDE BFICIONOKJO(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ, FJIDBMMCBDN AOICPEGICFC)
	{
		return default(AJGHNFAOCDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x22828B0", Offset = "0x2281CB0", VA = "0x1822828B0")]
	public FCDKJKPGPDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public sealed class MOGIMGBCOGA : ELBNMKOLOEG
{
	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "11")]
	public override void MPMEBFCPMDO(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, OEANGFGCLHO ECHCIKCBIED, MIEEFIOIIBN<PCDHPDNGICC.HJDBMJEKEBM>? NLLGOKIEPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "12")]
	public override void AMMMGJHMDGB(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x228D9F0", Offset = "0x228CDF0", VA = "0x18228D9F0", Slot = "13")]
	public override IEnumerable<CPPIKLDEGAN<FJIDBMMCBDN>> FAFHDFEKAEH(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x228DB20", Offset = "0x228CF20", VA = "0x18228DB20", Slot = "14")]
	public override void OIHCPGGHJLE(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x228DA20", Offset = "0x228CE20", VA = "0x18228DA20")]
	public static void KIHJOBEGAME(PIJMOKLJHHD NCIHMAFAKAP, [In] BAFKBFILGOE.HMOFPNFCDJH OJGPBFFHNKH, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x22830D0", Offset = "0x22824D0", VA = "0x1822830D0", Slot = "15")]
	public override AJGHNFAOCDE BFICIONOKJO(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ, FJIDBMMCBDN AOICPEGICFC)
	{
		return default(AJGHNFAOCDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x22828B0", Offset = "0x2281CB0", VA = "0x1822828B0")]
	public MOGIMGBCOGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class NDGNONEJMGI : LIHNKOIDGEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	public readonly MIEEFIOIIBN<AJJFJLHFCKF> OJGMLFFCHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public readonly MIEEFIOIIBN<OMLEDJJIGFA> JMNLJNEILJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public readonly MIEEFIOIIBN<OMLEDJJIGFA> HEDIHNPONOB;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x228E550", Offset = "0x228D950", VA = "0x18228E550")]
	public NDGNONEJMGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public abstract class MOECJJACIPO : NOMKFJGHDBL<PIJMOKLJHHD>
{
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x228D9A0", Offset = "0x228CDA0", VA = "0x18228D9A0")]
	protected MOECJJACIPO([In] BEFGNFPPPMI JHBANNGAEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x228D860", Offset = "0x228CC60", VA = "0x18228D860", Slot = "11")]
	public override void MPMEBFCPMDO(PIJMOKLJHHD KCFGMPGPMFA, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, OEANGFGCLHO ECHCIKCBIED, MIEEFIOIIBN<PCDHPDNGICC.HJDBMJEKEBM>? NLLGOKIEPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x228D7C0", Offset = "0x228CBC0", VA = "0x18228D7C0", Slot = "12")]
	public override void AMMMGJHMDGB(PIJMOKLJHHD KCFGMPGPMFA, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x228D910", Offset = "0x228CD10", VA = "0x18228D910", Slot = "14")]
	public override void OIHCPGGHJLE(PIJMOKLJHHD KCFGMPGPMFA, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x228D680", Offset = "0x228CA80", VA = "0x18228D680", Slot = "17")]
	public override LMFFMMPMNDB<MIEEFIOIIBN<HIBILKABFFC>, JLINDJLDKOH> ADLEKBIOJFG(PIJMOKLJHHD KCFGMPGPMFA, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, MIEEFIOIIBN<AJJFJLHFCKF> HLMLKEANCLJ)
	{
		return default(LMFFMMPMNDB<MIEEFIOIIBN<HIBILKABFFC>, JLINDJLDKOH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public sealed class HIFACOKOEJP : BLFDMAAKCKP
{
	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x22889C0", Offset = "0x2287DC0", VA = "0x1822889C0")]
	public HIFACOKOEJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public struct FPHNBDLONKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public DPPHGIGHBKC ADKILKCAHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public FHHIKJNGAEG CKEEBDBDPCG;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x2284D30", Offset = "0x2284130", VA = "0x182284D30")]
	internal FPHNBDLONKK([In] DPPHGIGHBKC OGHPOADGEMG, [In] FHHIKJNGAEG MHGGNDLFNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x2284CE0", Offset = "0x22840E0", VA = "0x182284CE0")]
	public static FPHNBDLONKK AHLALEPNKFA()
	{
		return default(FPHNBDLONKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x2284D10", Offset = "0x2284110", VA = "0x182284D10")]
	public static FPHNBDLONKK JFEHLEBMCMC([In] DPPHGIGHBKC OGHPOADGEMG, [In] FHHIKJNGAEG MHGGNDLFNAD)
	{
		return default(FPHNBDLONKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public sealed class IMIODJMLICL : MOECJJACIPO
{
	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2289960", Offset = "0x2288D60", VA = "0x182289960")]
	public IMIODJMLICL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public sealed class DAEMPJENPLO
{
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public sealed class BAFKBFILGOE : IKBIJCGJAFO
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class EKKHBBLCECM : BEEPHLANAAP.OMFGJPOPOOG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct HMOFPNFCDJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public string ICAKBBAJKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public FAFACDIMDHL<AJJFJLHFCKF, FPLHNNLFDPF> OLEAPPPALGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public FAFACDIMDHL<OMLEDJJIGFA, FPLHNNLFDPF> JCLFJMNFENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public readonly MIEEFIOIIBN<LKDNFLJFHHO> IGDOCCDKFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public readonly MIEEFIOIIBN<LKDNFLJFHHO> FCINBDNDGFK;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2288FB0", Offset = "0x22883B0", VA = "0x182288FB0")]
		private HMOFPNFCDJH(string DDDHPCNFCEK, [In] FAFACDIMDHL<AJJFJLHFCKF, FPLHNNLFDPF> HADCNPPEHJP, [In] FAFACDIMDHL<OMLEDJJIGFA, FPLHNNLFDPF> DJGLHBGKMGE, MIEEFIOIIBN<LKDNFLJFHHO> ACLKNEBABLK, MIEEFIOIIBN<LKDNFLJFHHO> NCPKEDCMNBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x2288E60", Offset = "0x2288260", VA = "0x182288E60")]
		public static HMOFPNFCDJH AHLALEPNKFA(MIEEFIOIIBN<LKDNFLJFHHO> EGFJGHGDNOL, MIEEFIOIIBN<LKDNFLJFHHO> BFCCDMIKEJL)
		{
			return default(HMOFPNFCDJH);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x2288F30", Offset = "0x2288330", VA = "0x182288F30")]
		public static HMOFPNFCDJH JFEHLEBMCMC(string DDDHPCNFCEK, [In] FAFACDIMDHL<AJJFJLHFCKF, FPLHNNLFDPF> HADCNPPEHJP, [In] FAFACDIMDHL<OMLEDJJIGFA, FPLHNNLFDPF> DJGLHBGKMGE, MIEEFIOIIBN<LKDNFLJFHHO> EGFJGHGDNOL, MIEEFIOIIBN<LKDNFLJFHHO> BFCCDMIKEJL)
		{
			return default(HMOFPNFCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x2280270", Offset = "0x227F670", VA = "0x182280270", Slot = "8")]
	public override void MPMEBFCPMDO(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, OEANGFGCLHO ECHCIKCBIED, MIEEFIOIIBN<PCDHPDNGICC.HJDBMJEKEBM>? KMGODOKIFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x227FFB0", Offset = "0x227F3B0", VA = "0x18227FFB0", Slot = "9")]
	public override void AMMMGJHMDGB(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x227DFF0", Offset = "0x227D3F0", VA = "0x18227DFF0")]
	public BAFKBFILGOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class COKMGBDCFFE
{
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2281CD0", Offset = "0x22810D0", VA = "0x182281CD0")]
	public static void KJDEEDGEPIJ(this BAFKBFILGOE.HMOFPNFCDJH MCPMOAEEEOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public abstract class IKBIJCGJAFO : JPKPHGHJKDK<PIJMOKLJHHD>
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x227DFF0", Offset = "0x227D3F0", VA = "0x18227DFF0")]
	protected IKBIJCGJAFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public readonly struct FPLHNNLFDPF : IEquatable<FPLHNNLFDPF>, EPJDBDLJNML<FPLHNNLFDPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public readonly string ICAKBBAJKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public readonly FJIDBMMCBDN NKDPEDOOFIH;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
	private FPLHNNLFDPF(string DDDHPCNFCEK, FJIDBMMCBDN DPOLEDLIAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x22531B0", Offset = "0x22525B0", VA = "0x1822531B0")]
	public static FPLHNNLFDPF AHLALEPNKFA(string DDDHPCNFCEK, FJIDBMMCBDN DPOLEDLIAMP)
	{
		return default(FPLHNNLFDPF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2284D50", Offset = "0x2284150", VA = "0x182284D50")]
	public static bool LBFMGPFDJNL([In] FPLHNNLFDPF JKMLNPBBJIG, [In] FPLHNNLFDPF JDJGFJGMEAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2284D50", Offset = "0x2284150", VA = "0x182284D50", Slot = "4")]
	public bool Equals(FPLHNNLFDPF KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2284D50", Offset = "0x2284150", VA = "0x182284D50")]
	public bool LPEDODGCMKF([In] FPLHNNLFDPF KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2284DA0", Offset = "0x22841A0", VA = "0x182284DA0", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2284E60", Offset = "0x2284260", VA = "0x182284E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2284EC0", Offset = "0x22842C0", VA = "0x182284EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x2284D50", Offset = "0x2284150", VA = "0x182284D50", Slot = "5")]
	private bool LGKGGMKMCII([In] FPLHNNLFDPF KNLMODPGFOA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public sealed class AAMFJHPEGOP : IKBIJCGJAFO
{
	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "8")]
	public override void MPMEBFCPMDO(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, OEANGFGCLHO ECHCIKCBIED, MIEEFIOIIBN<PCDHPDNGICC.HJDBMJEKEBM>? KMGODOKIFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "9")]
	public override void AMMMGJHMDGB(PIJMOKLJHHD NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x227DFF0", Offset = "0x227D3F0", VA = "0x18227DFF0")]
	public AAMFJHPEGOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct HPNBFACGAPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public DGOPJPCIBPB<LKDNFLJFHHO, FPHNBDLONKK> KLCINIBKPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public KAAJPLPJGFK<FCDKJKPGPDK.LFIIPHOGMIK> KOBDAJKMDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public DGOPJPCIBPB<FCDKJKPGPDK.LFIIPHOGMIK, FCDKJKPGPDK.NOLNGMBPCMM> CKKLELCAFIN;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x2289380", Offset = "0x2288780", VA = "0x182289380")]
	private HPNBFACGAPA([In] DGOPJPCIBPB<LKDNFLJFHHO, FPHNBDLONKK> CMKLHMOPPII, [In] KAAJPLPJGFK<FCDKJKPGPDK.LFIIPHOGMIK> MLLLBFKOCIJ, [In] DGOPJPCIBPB<FCDKJKPGPDK.LFIIPHOGMIK, FCDKJKPGPDK.NOLNGMBPCMM> BDDGBHODBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2289200", Offset = "0x2288600", VA = "0x182289200")]
	public static HPNBFACGAPA AHLALEPNKFA()
	{
		return default(HPNBFACGAPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x22892F0", Offset = "0x22886F0", VA = "0x1822892F0")]
	public static HPNBFACGAPA JFEHLEBMCMC([In] DGOPJPCIBPB<LKDNFLJFHHO, FPHNBDLONKK> CMKLHMOPPII, [In] KAAJPLPJGFK<FCDKJKPGPDK.LFIIPHOGMIK> MLLLBFKOCIJ, [In] DGOPJPCIBPB<FCDKJKPGPDK.LFIIPHOGMIK, FCDKJKPGPDK.NOLNGMBPCMM> BDDGBHODBNP)
	{
		return default(HPNBFACGAPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class BBIEDLGCCHK
{
	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x22805C0", Offset = "0x227F9C0", VA = "0x1822805C0")]
	public static void KJDEEDGEPIJ(this HPNBFACGAPA MCPMOAEEEOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct KMDEDNNHHFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public DGOPJPCIBPB<ABNDNCLMDPA, HPNBFACGAPA> OOBFMEJGFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public KAAJPLPJGFK<BAFKBFILGOE.EKKHBBLCECM> JCDLONCPGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public DGOPJPCIBPB<BAFKBFILGOE.EKKHBBLCECM, BAFKBFILGOE.HMOFPNFCDJH> NBDCNLCFCBL;

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2289380", Offset = "0x2288780", VA = "0x182289380")]
	private KMDEDNNHHFI([In] DGOPJPCIBPB<ABNDNCLMDPA, HPNBFACGAPA> JHBKFOICCJL, [In] KAAJPLPJGFK<BAFKBFILGOE.EKKHBBLCECM> EIBFHPFLEOL, [In] DGOPJPCIBPB<BAFKBFILGOE.EKKHBBLCECM, BAFKBFILGOE.HMOFPNFCDJH> DFELLNKNIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x22892F0", Offset = "0x22886F0", VA = "0x1822892F0")]
	public static KMDEDNNHHFI JFEHLEBMCMC([In] DGOPJPCIBPB<ABNDNCLMDPA, HPNBFACGAPA> JHBKFOICCJL, [In] KAAJPLPJGFK<BAFKBFILGOE.EKKHBBLCECM> EIBFHPFLEOL, [In] DGOPJPCIBPB<BAFKBFILGOE.EKKHBBLCECM, BAFKBFILGOE.HMOFPNFCDJH> DFELLNKNIPE)
	{
		return default(KMDEDNNHHFI);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class MBLKJINBCNO
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x228CC00", Offset = "0x228C000", VA = "0x18228CC00")]
	public static void KJDEEDGEPIJ(this KMDEDNNHHFI MCPMOAEEEOJ, [In] HJJGMFAIGAE JDNJCOOAFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x228CFA0", Offset = "0x228C3A0", VA = "0x18228CFA0")]
	public static void MLAGJHOCLHM(this KMDEDNNHHFI MCPMOAEEEOJ, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, [In] HPNBFACGAPA CGOGNBPFMJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x228C920", Offset = "0x228BD20", VA = "0x18228C920")]
	public static void HNEMOMPNNFO(this KMDEDNNHHFI MCPMOAEEEOJ, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, [In] HJJGMFAIGAE JDNJCOOAFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x228C8B0", Offset = "0x228BCB0", VA = "0x18228C8B0")]
	public static HPNBFACGAPA CADKKGPFCDD([In] this KMDEDNNHHFI MCPMOAEEEOJ, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return default(HPNBFACGAPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x228CB90", Offset = "0x228BF90", VA = "0x18228CB90")]
	public static HPNBFACGAPA KIDEOJHCBAM(this KMDEDNNHHFI MCPMOAEEEOJ, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE)
	{
		return default(HPNBFACGAPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class IHCKJGFHHEH : BBCOCPICNDF<IHCKJGFHHEH, PIJMOKLJHHD>
{
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2289720", Offset = "0x2288B20", VA = "0x182289720")]
	private IHCKJGFHHEH([In] FAFACDIMDHL<LIGCAJFGNCM, LFJPAIMJONE<PIJMOKLJHHD>> KKMJNPLGPNP, [In] FAFACDIMDHL<CKPANFPLABI, PEIMMJMMEOC<PIJMOKLJHHD>> KLONDJPOFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x22895D0", Offset = "0x22889D0", VA = "0x1822895D0")]
	public static IHCKJGFHHEH AHLALEPNKFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x22896A0", Offset = "0x2288AA0", VA = "0x1822896A0")]
	public new (LMPCPDJAHLE<LIGCAJFGNCM, LFJPAIMJONE<PIJMOKLJHHD>>, LMPCPDJAHLE<CKPANFPLABI, PEIMMJMMEOC<PIJMOKLJHHD>>) NCBEKLBCEEF()
	{
		return default((LMPCPDJAHLE<LIGCAJFGNCM, LFJPAIMJONE<PIJMOKLJHHD>>, LMPCPDJAHLE<CKPANFPLABI, PEIMMJMMEOC<PIJMOKLJHHD>>));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class BDKNELMLIIE : ONDEMIGOKOA
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2280640", Offset = "0x227FA40", VA = "0x182280640", Slot = "7")]
	public override string AHEFLPEKLMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x2280670", Offset = "0x227FA70", VA = "0x182280670")]
	public BDKNELMLIIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface IEOBNKPDNKH
{
	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LMFFMMPMNDB<object, FOPCNMINEGF>> GBHBCFEKDOP(IIIMLHFAMEO HJOAJFDFEDM, bool BFNNDCCPMOP);
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
