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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1F81CB0", Offset = "0x1F804B0", VA = "0x181F81CB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KGFCENCONAI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E5C0", Offset = "0x1F6CDC0", VA = "0x181F6E5C0")]
	public static bool MEFAHOBFGHM(this PKOMODIBNOD HKAKMPIMEOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E500", Offset = "0x1F6CD00", VA = "0x181F6E500")]
	public static bool MEFAHOBFGHM(this PFGPOGOMAJP GKKCGGGBBMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface APIEPECKJBO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	BEMDKNAJANC? KHHCDOONBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class BGCAECFAIIG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1F62110", Offset = "0x1F60910", VA = "0x181F62110")]
	internal static EPLGAHDLMCC KHHCDOONBDA(this APIEPECKJBO EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1F621F0", Offset = "0x1F609F0", VA = "0x181F621F0")]
	internal static MEKCEIEFNPI<EPLGAHDLMCC, MIHJJDIKIPK> LPIJGHBMCEM(this APIEPECKJBO EGJINJKGIAK)
	{
		return default(MEKCEIEFNPI<EPLGAHDLMCC, MIHJJDIKIPK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct BEMDKNAJANC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly EPLGAHDLMCC KHHCDOONBDA;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
	public BEMDKNAJANC(EPLGAHDLMCC JOCPIDCNJOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AFONNADOGAD
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3147890", Offset = "0x3146090", VA = "0x183147890")]
	public static IMNPCNCFILD<CCBMGFEGKNJ, FFPCMKOBEGP, TRoot, OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, TRoot>> JJIFEINAIAI<TRoot>([In] this IMNPCNCFILD<CCBMGFEGKNJ, FFPCMKOBEGP, TRoot, OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, TRoot>> IELOOBIDFCI) where TRoot : APIEPECKJBO
	{
		return default(IMNPCNCFILD<CCBMGFEGKNJ, FFPCMKOBEGP, TRoot, OPEEJNJBEAD.OHFECBHGEAO<CCBMGFEGKNJ, FFPCMKOBEGP, TRoot>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct AENIBMFNBOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct HDIJGFHGDLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly PFHKOKHNBAM MMBGMPGEOID;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8EB4C0", Offset = "0x8E9CC0", VA = "0x1808EB4C0")]
		public HDIJGFHGDLD(PFHKOKHNBAM CCFDAEFHGMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct GMBIKMBBHGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public KPFGDODNFBO<DEHBGIDHIKL> HCFCBAAHMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public KPFGDODNFBO<DEHBGIDHIKL> LKJJCEIEBJA;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1F6C1E0", Offset = "0x1F6A9E0", VA = "0x181F6C1E0")]
		public static GMBIKMBBHGJ OJFFIHPLODM(GBEFBHJHHLC<EPLGAHDLMCC> CJELABLKNAB)
		{
			return default(GMBIKMBBHGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct CCIGGLPECPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public KPFGDODNFBO<DNFJKNPMMBK> LMFDGOAHLEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public KPFGDODNFBO<DNFJKNPMMBK> MMIFGCDKMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public KPFGDODNFBO<DNFJKNPMMBK> GAMGILIJGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public KPFGDODNFBO<DNFJKNPMMBK> KMENDGADHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public KPFGDODNFBO<DNFJKNPMMBK> IBLOOCJNDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public KPFGDODNFBO<DNFJKNPMMBK> IJNDCLAOJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public KPFGDODNFBO<DNFJKNPMMBK> KGGEIKOFNHA;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1F63D20", Offset = "0x1F62520", VA = "0x181F63D20")]
		public static CCIGGLPECPA OJFFIHPLODM(HMLBBMKMNBM<EPLGAHDLMCC> CJELABLKNAB)
		{
			return default(CCIGGLPECPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class BKCGCAENLDN
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static Dictionary<KPFGDODNFBO<IJBGHHCCACH>, HBOBMNPBINN> MBFCEIMBNLI;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> GKJEPKMOIEE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> AIONKIIBDKE;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> DIHJFFAGEBC;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> ADIHHBLBFBJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> IAJMDDLOGLN;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> KLOOCKECGJH;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> EAHCGLGGOJI;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> FNAPINIMPFK;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> KMMGPJLADOB;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> NMDOMJABKCP;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> CFNIKMLLBOF;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> BNPIKIABCDB;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> JPFKODMNHHP;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> KBJNOCELEMA;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> BPPJGPDBEML;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> OOBBIJIPDIC;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> ONGIFDBGGEF;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> NCDOIOAOPBH;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> LNJBDJNOIPA;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> OMEIOOHNNIJ;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> JKHGNDFCDIA;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> FGJLNDNBFCC;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> NFKBAHBGLBL;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> ANAHGNLNEGO;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> CFJCADGCNPD;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> OEJNDGNDPDG;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> MAAKKFOLHJK;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> AJCELKMNMMK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> DMHFIDGIKBG;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> DDBFIEELGJC;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> JILNFDLEDMC;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> DAHNAFPHMKO;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> BEMPEMKBCNF;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> PHBOOOMPAIG;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> JKPEGJHHMGN;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> CCOPKGDCCDE;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> ICHLGEGICNF;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> JMGPCOAHBCK;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> HABEEIDFJGM;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> NPCNCPHCLFI;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> BAIGBJJKHFM;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> OGEBDBGCGDD;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> BBHBIOEBFHO;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> DNIDBHPLNJC;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> MGCEIJFLDKN;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> FGEJGFJJHIC;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> CPJILJNMHFK;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> IPJKLMPFBDG;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> LOIKDNFECFL;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> BHJGFDBLEPJ;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> FIPGIINMMKF;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> IMKEPBCAEEH;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> BDLKJALNGLG;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> LEKGBJEHOAC;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> HFBGCPOIHJI;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly KPFGDODNFBO<IJBGHHCCACH> EOAALHOJALG;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1F623B0", Offset = "0x1F60BB0", VA = "0x181F623B0")]
		public static HBOBMNPBINN FFKFBBPKMGB(KPFGDODNFBO<IJBGHHCCACH> EGNLNANJFMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1F62570", Offset = "0x1F60D70", VA = "0x181F62570")]
		public static bool OMGNDPLDOOC(KPFGDODNFBO<IJBGHHCCACH> EGNLNANJFMI, [Out] HBOBMNPBINN GFMHIPGIBKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1F62430", Offset = "0x1F60C30", VA = "0x181F62430")]
		public static PKOMODIBNOD JEFDBIKPBCM(KPFGDODNFBO<IJBGHHCCACH> EGNLNANJFMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1F624E0", Offset = "0x1F60CE0", VA = "0x181F624E0")]
		private static KPFGDODNFBO<IJBGHHCCACH> MPPLGFJBDHC(HBOBMNPBINN GFMHIPGIBKI, KPFGDODNFBO<IJBGHHCCACH> EGNLNANJFMI)
		{
			return default(KPFGDODNFBO<IJBGHHCCACH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class MBGGNMMJBJC
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class NNIMODEMDGC : IEnumerable<PKOMODIBNOD>, IEnumerable, IEnumerator<PKOMODIBNOD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private PKOMODIBNOD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private NGANAJKCJBN roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public NGANAJKCJBN <>3__roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private bool <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private bool <r2>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000064")]
			private PKOMODIBNOD System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x898540", Offset = "0x896D40", VA = "0x180898540")]
			[DebuggerHidden]
			public NNIMODEMDGC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x1F80060", Offset = "0x1F7E860", VA = "0x181F80060", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1F81860", Offset = "0x1F80060", VA = "0x181F81860", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1F817B0", Offset = "0x1F7FFB0", VA = "0x181F817B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PKOMODIBNOD> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1F817B0", Offset = "0x1F7FFB0", VA = "0x181F817B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class ICBFJFENFLB : IEnumerable<PKOMODIBNOD>, IEnumerable, IEnumerator<PKOMODIBNOD>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private PKOMODIBNOD <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private bool includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public bool <>3__includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NGANAJKCJBN roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public NGANAJKCJBN <>3__roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private IEnumerator<PKOMODIBNOD> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private PKOMODIBNOD <circuitType>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			private PKOMODIBNOD System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x898540", Offset = "0x896D40", VA = "0x180898540")]
			[DebuggerHidden]
			public ICBFJFENFLB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1F6D780", Offset = "0x1F6BF80", VA = "0x181F6D780", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1F6D130", Offset = "0x1F6B930", VA = "0x181F6D130", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x1F6D620", Offset = "0x1F6BE20", VA = "0x181F6D620")]
			private void OLLLOCKLGDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x1F6D730", Offset = "0x1F6BF30", VA = "0x181F6D730", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x1F6D670", Offset = "0x1F6BE70", VA = "0x181F6D670", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<PKOMODIBNOD> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x1F6D670", Offset = "0x1F6BE70", VA = "0x181F6D670", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public static readonly PFGPOGOMAJP GEAOPKKILLG;

		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public static readonly PFGPOGOMAJP LCANBHEPECL;

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private static readonly HashSet<PKOMODIBNOD> PKINPHNNAHF;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static List<PKOMODIBNOD> BLKFBEBPDGH;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static KEEKMJAAFON LMLIIAMCPDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E00", Offset = "0x8C3600", VA = "0x1808C4E00")]
			get
			{
				return default(KEEKMJAAFON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static PKOMODIBNOD DDNCMBEHIEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1F70980", Offset = "0x1F6F180", VA = "0x181F70980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static PKOMODIBNOD BMAHENENKBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FA30", Offset = "0x1F6E230", VA = "0x181F6FA30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static PKOMODIBNOD LJJAAFLAADP
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1F71110", Offset = "0x1F6F910", VA = "0x181F71110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static PKOMODIBNOD LMDEMILPCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1F70B50", Offset = "0x1F6F350", VA = "0x181F70B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PKOMODIBNOD FIGOADFFCKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F7C0", Offset = "0x1F6DFC0", VA = "0x181F6F7C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PKOMODIBNOD BAIMJFCOFLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1F70C30", Offset = "0x1F6F430", VA = "0x181F70C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static PKOMODIBNOD IAOCDCAMAHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F560", Offset = "0x1F6DD60", VA = "0x181F6F560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PKOMODIBNOD IHHHIDGENDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F690", Offset = "0x1F6DE90", VA = "0x181F6F690")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static NPNJCDCCMOD CDKPKBBFNBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FC00", Offset = "0x1F6E400", VA = "0x181F6FC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static NPNJCDCCMOD FDIHNFIIHHO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1F71020", Offset = "0x1F6F820", VA = "0x181F71020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static NPNJCDCCMOD EDHNLJKLPMM
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1F70AB0", Offset = "0x1F6F2B0", VA = "0x181F70AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static NPNJCDCCMOD GKDJJOFINBM
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1F70340", Offset = "0x1F6EB40", VA = "0x181F70340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static NPNJCDCCMOD HMDLBMPGEKI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FBB0", Offset = "0x1F6E3B0", VA = "0x181F6FBB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static NPNJCDCCMOD MPECOIDNCJK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F470", Offset = "0x1F6DC70", VA = "0x181F6F470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static NPNJCDCCMOD OINDFGEKGAB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1F6ED50", Offset = "0x1F6D550", VA = "0x181F6ED50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static NPNJCDCCMOD MHKKHMFPDGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F000", Offset = "0x1F6D800", VA = "0x181F6F000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static NPNJCDCCMOD KCLNDPKNPLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1F70530", Offset = "0x1F6ED30", VA = "0x181F70530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static NPNJCDCCMOD GKOOOCHIAPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1F6EEC0", Offset = "0x1F6D6C0", VA = "0x181F6EEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static NPNJCDCCMOD CKLALFFKPNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FCA0", Offset = "0x1F6E4A0", VA = "0x181F6FCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static NPNJCDCCMOD DEKKGODOLCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FB60", Offset = "0x1F6E360", VA = "0x181F6FB60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static NPNJCDCCMOD KEPADFEMBNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1F706C0", Offset = "0x1F6EEC0", VA = "0x181F706C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static NPNJCDCCMOD GCBELOALMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F1E0", Offset = "0x1F6D9E0", VA = "0x181F6F1E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static NPNJCDCCMOD OEFEFPBKEDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1F701B0", Offset = "0x1F6E9B0", VA = "0x181F701B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static NPNJCDCCMOD EOBKDFOPENA
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1F70670", Offset = "0x1F6EE70", VA = "0x181F70670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static NPNJCDCCMOD IGFOIKDMPCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1F70FD0", Offset = "0x1F6F7D0", VA = "0x181F70FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static NPNJCDCCMOD ILONIOGGMDL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x1F70620", Offset = "0x1F6EE20", VA = "0x181F70620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static NPNJCDCCMOD IMJAKFPAEHK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x1F713D0", Offset = "0x1F6FBD0", VA = "0x181F713D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static NPNJCDCCMOD HPIHPAPEPPK
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1F708E0", Offset = "0x1F6F0E0", VA = "0x181F708E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static NPNJCDCCMOD MAMHNNKPOIM
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F5F0", Offset = "0x1F6DDF0", VA = "0x181F6F5F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static NPNJCDCCMOD JNFFDNLMDFO
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x1F71420", Offset = "0x1F6FC20", VA = "0x181F71420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static NPNJCDCCMOD FLDMLGLMFAE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x1F70A10", Offset = "0x1F6F210", VA = "0x181F70A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static NPNJCDCCMOD OOHEDLNKNJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x1F712E0", Offset = "0x1F6FAE0", VA = "0x181F712E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static NPNJCDCCMOD CHMPBHKHKIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x1F70160", Offset = "0x1F6E960", VA = "0x181F70160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static NPNJCDCCMOD OBKNIPICDLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x1F70930", Offset = "0x1F6F130", VA = "0x181F70930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static NPNJCDCCMOD POCLKMFLLAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x1F70CC0", Offset = "0x1F6F4C0", VA = "0x181F70CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static NPNJCDCCMOD PJCAJFCOHGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x1F70EE0", Offset = "0x1F6F6E0", VA = "0x181F70EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static NPNJCDCCMOD GMNHNEFAKDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x1F70110", Offset = "0x1F6E910", VA = "0x181F70110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static NPNJCDCCMOD DEIPMGFMFKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FAC0", Offset = "0x1F6E2C0", VA = "0x181F6FAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static NPNJCDCCMOD OEMJJEBIOAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x1F702F0", Offset = "0x1F6EAF0", VA = "0x181F702F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static NPNJCDCCMOD PHDLEEBHIOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F420", Offset = "0x1F6DC20", VA = "0x181F6F420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static NPNJCDCCMOD KMBJCGNDNLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x1F6EDD0", Offset = "0x1F6D5D0", VA = "0x181F6EDD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static NPNJCDCCMOD EOMFMHCBMED
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F380", Offset = "0x1F6DB80", VA = "0x181F6F380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static NPNJCDCCMOD BLIDJEIKGMO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F190", Offset = "0x1F6D990", VA = "0x181F6F190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static NPNJCDCCMOD IPLNLBKDPPD
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x1F6EE20", Offset = "0x1F6D620", VA = "0x181F6EE20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public static NPNJCDCCMOD LMPNALFCGFB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F140", Offset = "0x1F6D940", VA = "0x181F6F140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public static NPNJCDCCMOD BCBBJBMCIHE
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1F704E0", Offset = "0x1F6ECE0", VA = "0x181F704E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static NPNJCDCCMOD LNAFCBBJKPE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FDE0", Offset = "0x1F6E5E0", VA = "0x181F6FDE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static NPNJCDCCMOD OKBAOEPDEIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F850", Offset = "0x1F6E050", VA = "0x181F6F850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static NPNJCDCCMOD GGIEFPBIEEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x1F70250", Offset = "0x1F6EA50", VA = "0x181F70250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public static NPNJCDCCMOD BEIOJCIAPCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1F70070", Offset = "0x1F6E870", VA = "0x181F70070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static NPNJCDCCMOD OJEDMKKPLKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x1F705D0", Offset = "0x1F6EDD0", VA = "0x181F705D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public static NPNJCDCCMOD MNPDKKKFFPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F050", Offset = "0x1F6D850", VA = "0x181F6F050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static NPNJCDCCMOD BGFMJIJPJLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1F6EF10", Offset = "0x1F6D710", VA = "0x181F6EF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static NPNJCDCCMOD LDEMGMNIIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FE30", Offset = "0x1F6E630", VA = "0x181F6FE30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static NPNJCDCCMOD MKIHMJJOICP
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1F711F0", Offset = "0x1F6F9F0", VA = "0x181F711F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static NPNJCDCCMOD HJMGIBFALIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x1F70B00", Offset = "0x1F6F300", VA = "0x181F70B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public static NPNJCDCCMOD LFFEICPCEHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x1F70710", Offset = "0x1F6EF10", VA = "0x181F70710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static NPNJCDCCMOD PGHMGONAFCI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F4C0", Offset = "0x1F6DCC0", VA = "0x181F6F4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static NPNJCDCCMOD GFILAPIJCNK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x1F70D10", Offset = "0x1F6F510", VA = "0x181F70D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static NPNJCDCCMOD NPENFJNKAFF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F720", Offset = "0x1F6DF20", VA = "0x181F6F720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public static NPNJCDCCMOD ONJOEIHCHDF
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x1F71070", Offset = "0x1F6F870", VA = "0x181F71070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static NPNJCDCCMOD BKPBDFNOEOE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x1F70A60", Offset = "0x1F6F260", VA = "0x181F70A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static NPNJCDCCMOD GEFLEHJEKIO
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x1F70580", Offset = "0x1F6ED80", VA = "0x181F70580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public static NPNJCDCCMOD KOBBHKNOBFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FE80", Offset = "0x1F6E680", VA = "0x181F6FE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static NPNJCDCCMOD HDEBKONAHMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FED0", Offset = "0x1F6E6D0", VA = "0x181F6FED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public static NPNJCDCCMOD OLFNKEMIABE
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F640", Offset = "0x1F6DE40", VA = "0x181F6F640")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static NPNJCDCCMOD HHCOHJIKIHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x1F71380", Offset = "0x1F6FB80", VA = "0x181F71380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static NPNJCDCCMOD APADJKEPDEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x1F6EF60", Offset = "0x1F6D760", VA = "0x181F6EF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public static NPNJCDCCMOD COGEHEHFLIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1F71240", Offset = "0x1F6FA40", VA = "0x181F71240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public static NPNJCDCCMOD KOPAJLBKMOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x1F71330", Offset = "0x1F6FB30", VA = "0x181F71330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public static NPNJCDCCMOD KAHCHFHLKDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x1F702A0", Offset = "0x1F6EAA0", VA = "0x181F702A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public static NPNJCDCCMOD GCDPOLJHFBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1F70E90", Offset = "0x1F6F690", VA = "0x181F70E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static NPNJCDCCMOD HOLLILBDMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1F6EFB0", Offset = "0x1F6D7B0", VA = "0x181F6EFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public static NPNJCDCCMOD BADDBGIJOLO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F510", Offset = "0x1F6DD10", VA = "0x181F6F510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public static NPNJCDCCMOD EBOBKPFDAFH
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FC50", Offset = "0x1F6E450", VA = "0x181F6FC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public static NPNJCDCCMOD EBOBDOBIOEI
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F3D0", Offset = "0x1F6DBD0", VA = "0x181F6F3D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public static NPNJCDCCMOD BJAECMMGLNP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x1F700C0", Offset = "0x1F6E8C0", VA = "0x181F700C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static NPNJCDCCMOD MBBHJIFEJPA
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x1F703E0", Offset = "0x1F6EBE0", VA = "0x181F703E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static NPNJCDCCMOD GNHOKDPLLLM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F770", Offset = "0x1F6DF70", VA = "0x181F6F770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static NPNJCDCCMOD FJDMNGOAFMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x1F70390", Offset = "0x1F6EB90", VA = "0x181F70390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static NPNJCDCCMOD BKACBJLHEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x1F70200", Offset = "0x1F6EA00", VA = "0x181F70200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static NPNJCDCCMOD JFOAKFNOIPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x1F70E40", Offset = "0x1F6F640", VA = "0x181F70E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static NPNJCDCCMOD EEHFBFHAPHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x1F711A0", Offset = "0x1F6F9A0", VA = "0x181F711A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static NPNJCDCCMOD KDAMOCNEGED
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x1F70020", Offset = "0x1F6E820", VA = "0x181F70020")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static NPNJCDCCMOD HIHPBMKMLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F0A0", Offset = "0x1F6D8A0", VA = "0x181F6F0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static NPNJCDCCMOD AMOCKIDIIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F0F0", Offset = "0x1F6D8F0", VA = "0x181F6F0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static NPNJCDCCMOD HELIHNABOKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x1F710C0", Offset = "0x1F6F8C0", VA = "0x181F710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public static NPNJCDCCMOD JAPOAECHFGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x1F70F30", Offset = "0x1F6F730", VA = "0x181F70F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public static NPNJCDCCMOD HJEBFIGBFFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x1F70F80", Offset = "0x1F6F780", VA = "0x181F70F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public static NPNJCDCCMOD HKMGNFDPIPF
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x1F70BE0", Offset = "0x1F6F3E0", VA = "0x181F70BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public static NPNJCDCCMOD CEKJGHOFGAF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x1F71290", Offset = "0x1F6FA90", VA = "0x181F71290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static NPNJCDCCMOD EGHPABFFJDP
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FFD0", Offset = "0x1F6E7D0", VA = "0x181F6FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public static NPNJCDCCMOD HJOCIGPFHAB
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FB10", Offset = "0x1F6E310", VA = "0x181F6FB10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public static NPNJCDCCMOD AGCBKIFLEGN
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x1F6EE70", Offset = "0x1F6D670", VA = "0x181F6EE70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public static NPNJCDCCMOD CMDEACIBKKO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F2E0", Offset = "0x1F6DAE0", VA = "0x181F6F2E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public static NPNJCDCCMOD FEPLGDLFMEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1F70760", Offset = "0x1F6EF60", VA = "0x181F70760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static NPNJCDCCMOD IAHGMKAHLIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x1F6F330", Offset = "0x1F6DB30", VA = "0x181F6F330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FCF0", Offset = "0x1F6E4F0", VA = "0x181F6FCF0")]
		public static PFGPOGOMAJP HHOLKDKBJHG([In] DJLOJAFGFOG OMCGGOKGBLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1F70D60", Offset = "0x1F6F560", VA = "0x181F70D60")]
		public static FGJDHNDDOEJ NEGLGEIKLAG(string EGNLNANJFMI, [Optional] string GCDLMFGKKMH)
		{
			return default(FGJDHNDDOEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1F70E10", Offset = "0x1F6F610", VA = "0x181F70E10")]
		public static FGJDHNDDOEJ NEGLGEIKLAG([Optional][In] Guid? EGNLNANJFMI, [Optional] string GCDLMFGKKMH)
		{
			return default(FGJDHNDDOEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1F704B0", Offset = "0x1F6ECB0", VA = "0x181F704B0")]
		public static PFGPOGOMAJP JBOKONCJNEP(params DJLOJAFGFOG[] DHGCKNFJOCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1F6EDA0", Offset = "0x1F6D5A0", VA = "0x181F6EDA0")]
		public static PFGPOGOMAJP AEHJJPMOEIN(params DJLOJAFGFOG[] DHGCKNFJOCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1F707B0", Offset = "0x1F6EFB0", VA = "0x181F707B0")]
		public static PFGPOGOMAJP LDKHGFHHJKD([In] DJLOJAFGFOG OMCGGOKGBLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1F71650", Offset = "0x1F6FE50", VA = "0x181F71650")]
		static MBGGNMMJBJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F230", Offset = "0x1F6DA30", VA = "0x181F6F230")]
		[IteratorStateMachine(typeof(NNIMODEMDGC))]
		private static IEnumerable<PKOMODIBNOD> DAJDLBFECHG(NGANAJKCJBN DHMPLGEOOMG, bool FDGJMKCOBJK, bool HNLPNJHDPNO, bool GEGAPLNBGOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1F6FF20", Offset = "0x1F6E720", VA = "0x181F6FF20")]
		[IteratorStateMachine(typeof(ICBFJFENFLB))]
		public static IEnumerable<PKOMODIBNOD> HNGNLODJOBA(NGANAJKCJBN DHMPLGEOOMG, bool GFCJBBLNPDH, bool FDGJMKCOBJK, bool HNLPNJHDPNO, bool GEGAPLNBGOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1F6F8A0", Offset = "0x1F6E0A0", VA = "0x181F6F8A0")]
		public static HKDHDGKFGJB GAAIFFJKMDL(PKOMODIBNOD HKAKMPIMEOA)
		{
			return default(HKDHDGKFGJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1F71470", Offset = "0x1F6FC70", VA = "0x181F71470")]
		public static HKDHDGKFGJB POJDBICOLPJ(PKOMODIBNOD HKAKMPIMEOA)
		{
			return default(HKDHDGKFGJB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1F70430", Offset = "0x1F6EC30", VA = "0x181F70430")]
		public static bool JBCANJMHMHP(PKOMODIBNOD HKAKMPIMEOA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly CCIGGLPECPA LCCLDDFOOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly GMBIKMBBHGJ MCOKPIFJIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly CCPKKOHIOOB<DNFJKNPMMBK, CAFHBJAALAB<EPLGAHDLMCC>> JPAFJJEHAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CCPKKOHIOOB<DEHBGIDHIKL, EFIIICFJLEM<EPLGAHDLMCC>> BGJDPAAGBKD;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1F61EC0", Offset = "0x1F606C0", VA = "0x181F61EC0")]
	private AENIBMFNBOO([In] CCIGGLPECPA CLFIPNAGGOL, [In] GMBIKMBBHGJ MENPLFLGJDP, CCPKKOHIOOB<DNFJKNPMMBK, CAFHBJAALAB<EPLGAHDLMCC>> PMLBHPHOBBP, CCPKKOHIOOB<DEHBGIDHIKL, EFIIICFJLEM<EPLGAHDLMCC>> GFGEDNBAILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1F618F0", Offset = "0x1F600F0", VA = "0x181F618F0")]
	public static AENIBMFNBOO OJFFIHPLODM()
	{
		return default(AENIBMFNBOO);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1F61A70", Offset = "0x1F60270", VA = "0x181F61A70")]
	public static void PGFGBHFCFEG([In] AENIBMFNBOO EGJINJKGIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F61670", Offset = "0x1F5FE70", VA = "0x181F61670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F61680", Offset = "0x1F5FE80", VA = "0x181F61680")]
	public static GKHPEDGHKDL<EPLGAHDLMCC> HBGDGODPEMD([In] AENIBMFNBOO EGJINJKGIAK, [In] HMLPMLHKKOJ MPBAPALKIII, [In] BDGNMHBOEAC IBAJDJBAHOC)
	{
		return default(GKHPEDGHKDL<EPLGAHDLMCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F61760", Offset = "0x1F5FF60", VA = "0x181F61760")]
	public static EPLGAHDLMCC MENLBPPEAPM([In] AENIBMFNBOO EGJINJKGIAK, [In] AODLCFBMMLO FAEEKJBPPAH, [In] GKHPEDGHKDL<EPLGAHDLMCC> BGDDDMIGBBF, [In] HPCGCLPHJPJ EKDDOIEBBNK, KPFGDODNFBO<GPCAGFNHADK> PGKDKOMBEKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class EPLGAHDLMCC : EHEGKBLLKLE, AKAOHLPLIEB<EPLGAHDLMCC>, KIAMDGPNJCC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public readonly AENIBMFNBOO NJNLHHOPBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private AODLCFBMMLO CEFFLJOLDKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private GKHPEDGHKDL<EPLGAHDLMCC> BMKHPBODGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private HPCGCLPHJPJ FFEKFLKJPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> LIEIDGAIGFK;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A680", Offset = "0x1F68E80", VA = "0x181F6A680")]
	private EPLGAHDLMCC([In] AENIBMFNBOO PPMHPNOFLGJ, [In] AODLCFBMMLO LHBNEDPFEIF, [In] GKHPEDGHKDL<EPLGAHDLMCC> BGDDDMIGBBF, [In] HPCGCLPHJPJ EKDDOIEBBNK, KPFGDODNFBO<GPCAGFNHADK> BMOLLLCBODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1F61760", Offset = "0x1F5FF60", VA = "0x181F61760")]
	public static EPLGAHDLMCC PMGDHNKMLHE([In] AENIBMFNBOO PPMHPNOFLGJ, [In] AODLCFBMMLO LHBNEDPFEIF, [In] GKHPEDGHKDL<EPLGAHDLMCC> BGDDDMIGBBF, [In] HPCGCLPHJPJ EKDDOIEBBNK, KPFGDODNFBO<GPCAGFNHADK> BMOLLLCBODE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1F694C0", Offset = "0x1F67CC0", VA = "0x181F694C0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1F68B80", Offset = "0x1F67380", VA = "0x181F68B80", Slot = "8")]
	public GKHPEDGHKDL<EPLGAHDLMCC> BFALLNJDFDH()
	{
		return default(GKHPEDGHKDL<EPLGAHDLMCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A040", Offset = "0x1F68840", VA = "0x181F6A040")]
	public AODLCFBMMLO IKAPGPDCKJM()
	{
		return default(AODLCFBMMLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2928FD0", Offset = "0x29277D0", VA = "0x182928FD0")]
	public KPFGDODNFBO<TMVirt> ANGPIKOJGEB<TMVirt>(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM) where TMVirt : OGPHMFGOEIO.FCBJCMKOJNM
	{
		return default(KPFGDODNFBO<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2929520", Offset = "0x2927D20", VA = "0x182929520")]
	public KPFGDODNFBO<TMVirt> OGDEDHGEFNN<TMVirt>(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG) where TMVirt : CAEFPLIDPEM.HGMEPGLCHGG
	{
		return default(KPFGDODNFBO<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A5B0", Offset = "0x1F68DB0", VA = "0x181F6A5B0")]
	internal HMLPMLHKKOJ PDNFOCIOKFO()
	{
		return default(HMLPMLHKKOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A000", Offset = "0x1F68800", VA = "0x181F6A000")]
	internal BDGNMHBOEAC IIMEAMHBMCM()
	{
		return default(BDGNMHBOEAC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1F68B80", Offset = "0x1F67380", VA = "0x181F68B80")]
	internal GKHPEDGHKDL<EPLGAHDLMCC> DJAKIJIHAPG()
	{
		return default(GKHPEDGHKDL<EPLGAHDLMCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A040", Offset = "0x1F68840", VA = "0x181F6A040")]
	internal AODLCFBMMLO MJBGAGPPEKK()
	{
		return default(AODLCFBMMLO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F695B0", Offset = "0x1F67DB0", VA = "0x181F695B0")]
	internal HPCGCLPHJPJ FEEEOMNFBEO()
	{
		return default(HPCGCLPHJPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x29295F0", Offset = "0x2927DF0", VA = "0x1829295F0")]
	public void OMJBJIOLOFD<TMVirt>(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<TMVirt> KHFKAMLEDND) where TMVirt : OGPHMFGOEIO.FCBJCMKOJNM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2929060", Offset = "0x2927860", VA = "0x182929060")]
	public void BMMPHIDCLPN<TMVirt>(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, KPFGDODNFBO<TMVirt> KHFKAMLEDND) where TMVirt : CAEFPLIDPEM.HGMEPGLCHGG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A570", Offset = "0x1F68D70", VA = "0x181F6A570", Slot = "9")]
	public AHJKEBGFGJB PDBBCCNFPAN()
	{
		return default(AHJKEBGFGJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F69450", Offset = "0x1F67C50", VA = "0x181F69450", Slot = "10")]
	public HKDHDGKFGJB CBHDAJLCAEP(PKOMODIBNOD HKAKMPIMEOA)
	{
		return default(HKDHDGKFGJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F695C0", Offset = "0x1F67DC0", VA = "0x181F695C0", Slot = "11")]
	public bool GNIOELKBIEK(PKOMODIBNOD HKAKMPIMEOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1F678F0", Offset = "0x1F660F0", VA = "0x181F678F0", Slot = "4")]
	private void AENCDIAODAG(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, OKHLIJCALEC ICLKOKIEPPK, KPFGDODNFBO<PGLFCGKLJFG.DGDPOBOLHHK>? EOCIGKKBMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1F69670", Offset = "0x1F67E70", VA = "0x181F69670", Slot = "5")]
	private void HPAEKEJLOJA(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A5F0", Offset = "0x1F68DF0", VA = "0x181F6A5F0", Slot = "6")]
	private void POMAGFLNNBL(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, OKHLIJCALEC ICLKOKIEPPK, KPFGDODNFBO<PGLFCGKLJFG.DGDPOBOLHHK>? EOCIGKKBMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F69540", Offset = "0x1F67D40", VA = "0x181F69540", Slot = "7")]
	private void EBFLPPIIJEK(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A3E0", Offset = "0x1F68BE0", VA = "0x181F6A3E0")]
	internal MEKCEIEFNPI<KPFGDODNFBO<GHBFIOLFDBB>, FDKFIPGCOGB> LMFDGOAHLEB(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<DNFJKNPMMBK> AKGBALPFAKC, [In] BAPMBLOBIME KKDCNJKFOII, [In] FLOGLJPGMHF HGJODEDMNMO, OKHLIJCALEC BMHMMHOBAOM, KPFGDODNFBO<PGLFCGKLJFG.DGDPOBOLHHK>? HHFHLNABMMF)
	{
		return default(MEKCEIEFNPI<KPFGDODNFBO<GHBFIOLFDBB>, FDKFIPGCOGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1F68A80", Offset = "0x1F67280", VA = "0x181F68A80")]
	internal KPFGDODNFBO<GHBFIOLFDBB> BCFMKJMOJFK(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<DNFJKNPMMBK> AKGBALPFAKC, [In] BAPMBLOBIME KKDCNJKFOII, [In] FLOGLJPGMHF HGJODEDMNMO, OKHLIJCALEC BMHMMHOBAOM, KPFGDODNFBO<PGLFCGKLJFG.DGDPOBOLHHK>? HHFHLNABMMF)
	{
		return default(KPFGDODNFBO<GHBFIOLFDBB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1F68B90", Offset = "0x1F67390", VA = "0x181F68B90")]
	internal MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> BFOFKIIGCPP(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x2929350", Offset = "0x2927B50", VA = "0x182929350")]
	public MEKCEIEFNPI<KPFGDODNFBO<TM>, FDKFIPGCOGB> NKIAHGCJCKC<TM>(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<DEHBGIDHIKL> KHIEKIHGGHJ) where TM : OGPHMFGOEIO.FCBJCMKOJNM
	{
		return default(MEKCEIEFNPI<KPFGDODNFBO<TM>, FDKFIPGCOGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2929130", Offset = "0x2927930", VA = "0x182929130")]
	public MEKCEIEFNPI<KPFGDODNFBO<TM>, FDKFIPGCOGB> EFPILEHKLGF<TM>(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, KPFGDODNFBO<DNFJKNPMMBK> CCLNLBGLPDP) where TM : CAEFPLIDPEM.HGMEPGLCHGG
	{
		return default(MEKCEIEFNPI<KPFGDODNFBO<TM>, FDKFIPGCOGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A050", Offset = "0x1F68850", VA = "0x181F6A050")]
	private MEKCEIEFNPI<(KPFGDODNFBO<ALFODNACFEO.AJCCPDIFNAC>, KPFGDODNFBO<NFLGKJNAJEM.AGFAGBCDPGG>), FDKFIPGCOGB> LBEEALGBDLF(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
		return default(MEKCEIEFNPI<(KPFGDODNFBO<ALFODNACFEO.AJCCPDIFNAC>, KPFGDODNFBO<NFLGKJNAJEM.AGFAGBCDPGG>), FDKFIPGCOGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1F68200", Offset = "0x1F66A00", VA = "0x181F68200")]
	internal MEKCEIEFNPI<(KPFGDODNFBO<CNIDNALDCPF>, KPFGDODNFBO<FICFLFAPGGD>), FDKFIPGCOGB> BBDIKINGOFG(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int OHHOEGDMHEB, [In] IFMODNOJONE HKAKMPIMEOA)
	{
		return default(MEKCEIEFNPI<(KPFGDODNFBO<CNIDNALDCPF>, KPFGDODNFBO<FICFLFAPGGD>), FDKFIPGCOGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1F68C20", Offset = "0x1F67420", VA = "0x181F68C20")]
	internal MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> CAHJMGIECGC(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int OHHOEGDMHEB)
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F69710", Offset = "0x1F67F10", VA = "0x181F69710")]
	internal MEKCEIEFNPI<(KPFGDODNFBO<FICFLFAPGGD>, KPFGDODNFBO<CNIDNALDCPF>), FDKFIPGCOGB> IANFJLCDLJD(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int JFOGABNIOHM, [In] IFMODNOJONE HKAKMPIMEOA)
	{
		return default(MEKCEIEFNPI<(KPFGDODNFBO<FICFLFAPGGD>, KPFGDODNFBO<CNIDNALDCPF>), FDKFIPGCOGB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F679A0", Offset = "0x1F661A0", VA = "0x181F679A0")]
	internal MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> APJLLFFAEDM(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int JFOGABNIOHM)
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct HPCGCLPHJPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public PEOPJNDHKBL<NFLGKJNAJEM.AGFAGBCDPGG, BBEKMJCHKNG> BHJHMBIPALG;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1EEBEE0", Offset = "0x1EEA6E0", VA = "0x181EEBEE0")]
	private HPCGCLPHJPJ([In] PEOPJNDHKBL<NFLGKJNAJEM.AGFAGBCDPGG, BBEKMJCHKNG> MBEIDGMCFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D050", Offset = "0x1F6B850", VA = "0x181F6D050")]
	public static HPCGCLPHJPJ OJFFIHPLODM()
	{
		return default(HPCGCLPHJPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LHLMMBJCJAP
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E970", Offset = "0x1F6D170", VA = "0x181F6E970")]
	public static void PGFGBHFCFEG(this HPCGCLPHJPJ EGJINJKGIAK, [In] NNJCIDIHBNF<NFLGKJNAJEM.AGFAGBCDPGG> BNCKADMKOMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class CDLPBFNCIOE
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F655B0", Offset = "0x1F63DB0", VA = "0x181F655B0")]
	public static DNCJDBJPHOD HNAIEAEAFJH(EPLGAHDLMCC BGDDDMIGBBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F64E70", Offset = "0x1F63670", VA = "0x181F64E70")]
	public static DNCJDBJPHOD GEBCGEJDEDF(KPFGDODNFBO<DEHBGIDHIKL> CJGLOPCOEFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NJADOHJICMA
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E310", Offset = "0x1F7CB10", VA = "0x181F7E310")]
	public static GDADLGLDOBJ HNAIEAEAFJH(this PKOMODIBNOD HKAKMPIMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F410", Offset = "0x1F7DC10", VA = "0x181F7F410")]
	public static PKOMODIBNOD PKPMANIAHDL(this GDADLGLDOBJ HKAKMPIMEOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class DEBGPJJACEI
{
	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x28F0170", Offset = "0x28EE970", VA = "0x1828F0170")]
	public static Dictionary<TDeserializedKey, TDeserializedValue> HAFFPBAGLEG<TDeserializedKey, TDeserializedValue, TSerialized>(this RepeatedField<TSerialized> LPKKJDFMNJA, Func<TSerialized, TDeserializedKey> FILOJNMIHJD, Func<TSerialized, TDeserializedValue> HBENJFDBBNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CCONCPMNDIA
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F63F60", Offset = "0x1F62760", VA = "0x181F63F60")]
	public static JHBJPDJDPJO HNAIEAEAFJH([In] this OGPHMFGOEIO EGJINJKGIAK, [In] GBBGHEOMNOA<CNIDNALDCPF, FICFLFAPGGD, GHBFIOLFDBB> NCNAHELFBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F64640", Offset = "0x1F62E40", VA = "0x181F64640")]
	public static OGPHMFGOEIO PKPMANIAHDL(this JHBJPDJDPJO EGJINJKGIAK, [In] GBBGHEOMNOA<CNIDNALDCPF, FICFLFAPGGD, GHBFIOLFDBB> NCNAHELFBKL)
	{
		return default(OGPHMFGOEIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class DMOOCNDEJEH
{
	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F66560", Offset = "0x1F64D60", VA = "0x181F66560")]
	public static MGMMJFKEHJJ HNAIEAEAFJH([In] this BDGNMHBOEAC EGJINJKGIAK, [In] HMLPMLHKKOJ DLHDCKDDNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F66870", Offset = "0x1F65070", VA = "0x181F66870")]
	public static BDGNMHBOEAC PKPMANIAHDL(this MGMMJFKEHJJ EGJINJKGIAK, [In] HMLPMLHKKOJ DLHDCKDDNHE)
	{
		return default(BDGNMHBOEAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LEKGCIAFMFG
{
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E6D0", Offset = "0x1F6CED0", VA = "0x181F6E6D0")]
	public static BLGELHAMBMF HNAIEAEAFJH([In] this BJODEHPFOJD EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E8C0", Offset = "0x1F6D0C0", VA = "0x181F6E8C0")]
	public static BJODEHPFOJD PKPMANIAHDL(this BLGELHAMBMF EGJINJKGIAK)
	{
		return default(BJODEHPFOJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NKHKLOKHHLL
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FF60", Offset = "0x1F7E760", VA = "0x181F7FF60")]
	public static NNHKMFIGDNG HNAIEAEAFJH([In] this CAEFPLIDPEM EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FFE0", Offset = "0x1F7E7E0", VA = "0x181F7FFE0")]
	public static CAEFPLIDPEM PKPMANIAHDL(this NNHKMFIGDNG EGJINJKGIAK)
	{
		return default(CAEFPLIDPEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class NOLIANIMHLL
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F818B0", Offset = "0x1F800B0", VA = "0x181F818B0")]
	public static HBFLABINGMN HNAIEAEAFJH([In] this AGIBCMCDGLJ EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1F81920", Offset = "0x1F80120", VA = "0x181F81920")]
	public static AGIBCMCDGLJ PKPMANIAHDL(this HBFLABINGMN EGJINJKGIAK)
	{
		return default(AGIBCMCDGLJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class FNGPDPMILLD
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C670", Offset = "0x2A7AE70", VA = "0x182A7C670")]
	public static CFCPIIAMIII HNAIEAEAFJH<TRoot>([In] this GKHPEDGHKDL<TRoot> EGJINJKGIAK) where TRoot : AKAOHLPLIEB<TRoot>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1F6A7C0", Offset = "0x1F68FC0", VA = "0x181F6A7C0")]
	public static GKHPEDGHKDL<EPLGAHDLMCC> PKPMANIAHDL(this CFCPIIAMIII EGJINJKGIAK, [In] AENIBMFNBOO PPMHPNOFLGJ)
	{
		return default(GKHPEDGHKDL<EPLGAHDLMCC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class CGGNAKECEOB
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1F65BA0", Offset = "0x1F643A0", VA = "0x181F65BA0")]
	public static FONDMBGCFDM HNAIEAEAFJH([In] this NFLGKJNAJEM.OLAAGDDIHIL EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1F65DF0", Offset = "0x1F645F0", VA = "0x181F65DF0")]
	public static NFLGKJNAJEM.OLAAGDDIHIL PKPMANIAHDL(this FONDMBGCFDM EGJINJKGIAK)
	{
		return default(NFLGKJNAJEM.OLAAGDDIHIL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class KAKKCNDDNJC
{
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E2B0", Offset = "0x1F6CAB0", VA = "0x181F6E2B0")]
	public static CJGOGLCLADF HNAIEAEAFJH([In] this ALFODNACFEO.JHBIMAJOCBB EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E320", Offset = "0x1F6CB20", VA = "0x181F6E320")]
	public static ALFODNACFEO.JHBIMAJOCBB PKPMANIAHDL(this CJGOGLCLADF EGJINJKGIAK)
	{
		return default(ALFODNACFEO.JHBIMAJOCBB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CEMMAEKOGKH
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F65760", Offset = "0x1F63F60", VA = "0x181F65760")]
	public static BOLOGGJKPFJ HNAIEAEAFJH([In] this HMLPMLHKKOJ EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1F65950", Offset = "0x1F64150", VA = "0x181F65950")]
	public static HMLPMLHKKOJ PKPMANIAHDL(this BOLOGGJKPFJ EGJINJKGIAK)
	{
		return default(HMLPMLHKKOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class MENMMHMPDEH
{
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1F77D10", Offset = "0x1F76510", VA = "0x181F77D10")]
	public static ELMADGALMDO HNAIEAEAFJH([In] Guid EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1F77E10", Offset = "0x1F76610", VA = "0x181F77E10")]
	public static Guid PKPMANIAHDL(ELMADGALMDO EGJINJKGIAK)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class GJOLCEDINAP
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B720", Offset = "0x1F69F20", VA = "0x181F6B720")]
	public static PKNNDFEJPML HNAIEAEAFJH([In] this DMIKOCGDNFP EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1F6B7A0", Offset = "0x1F69FA0", VA = "0x181F6B7A0")]
	public static DMIKOCGDNFP PKPMANIAHDL(this PKNNDFEJPML EGJINJKGIAK)
	{
		return default(DMIKOCGDNFP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class NGJNCBJCPCJ
{
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DF20", Offset = "0x1F7C720", VA = "0x181F7DF20")]
	public static FGOHKCFGICP HNAIEAEAFJH([In] this IFMODNOJONE EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DFB0", Offset = "0x1F7C7B0", VA = "0x181F7DFB0")]
	public static IFMODNOJONE PKPMANIAHDL(this FGOHKCFGICP EGJINJKGIAK)
	{
		return default(IFMODNOJONE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class LMDKNDMOGAN
{
	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EAC0", Offset = "0x1F6D2C0", VA = "0x181F6EAC0")]
	public static GNEPNIKFIIL HNAIEAEAFJH([In] this MGLBBFAFOEK EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EB40", Offset = "0x1F6D340", VA = "0x181F6EB40")]
	public static MGLBBFAFOEK PKPMANIAHDL(this GNEPNIKFIIL EGJINJKGIAK)
	{
		return default(MGLBBFAFOEK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class JJABDGLKMAO
{
	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2AE98E0", Offset = "0x2AE80E0", VA = "0x182AE98E0")]
	public static void DPPFFNGOEFG<TDeserialized, TSerialized>(this IReadOnlyCollection<TDeserialized> EGJINJKGIAK, RepeatedField<TSerialized> LPKKJDFMNJA, CAKIGKEPBDC<TDeserialized, TSerialized> HBJJJFBIMFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class CCFHGLDEJAB
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F63700", Offset = "0x1F61F00", VA = "0x181F63700")]
	public static KAFNJEODPKK HNAIEAEAFJH([In] this CGJPJKNKLNL EGJINJKGIAK, [In] GBBGHEOMNOA<CNIDNALDCPF, FICFLFAPGGD, GHBFIOLFDBB> NCNAHELFBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1F63A00", Offset = "0x1F62200", VA = "0x181F63A00")]
	public static CGJPJKNKLNL PKPMANIAHDL(this KAFNJEODPKK EGJINJKGIAK, [In] GBBGHEOMNOA<CNIDNALDCPF, FICFLFAPGGD, GHBFIOLFDBB> NCNAHELFBKL)
	{
		return default(CGJPJKNKLNL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FODJKNFAKGH
{
	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x1F6AAF0", Offset = "0x1F692F0", VA = "0x181F6AAF0")]
	public static HCOIOODFCKK HNAIEAEAFJH([In] this AODLCFBMMLO EGJINJKGIAK, [In] HMLPMLHKKOJ DLHDCKDDNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1F6AF70", Offset = "0x1F69770", VA = "0x181F6AF70")]
	public static AODLCFBMMLO PKPMANIAHDL(this HCOIOODFCKK EGJINJKGIAK, [In] HMLPMLHKKOJ DLHDCKDDNHE)
	{
		return default(AODLCFBMMLO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NACEPOKAEFE
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DDE0", Offset = "0x1F7C5E0", VA = "0x181F7DDE0")]
	public static HHMINCMBOAO HNAIEAEAFJH([In] this HCBLDGAKHKC EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DE70", Offset = "0x1F7C670", VA = "0x181F7DE70")]
	public static HCBLDGAKHKC PKPMANIAHDL(this HHMINCMBOAO EGJINJKGIAK)
	{
		return default(HCBLDGAKHKC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class HEEJLODCFHM
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C720", Offset = "0x1F6AF20", VA = "0x181F6C720")]
	public static JAHNOFINJFF HNAIEAEAFJH(this EPLGAHDLMCC EGJINJKGIAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C810", Offset = "0x1F6B010", VA = "0x181F6C810")]
	public static EPLGAHDLMCC PKPMANIAHDL(this JAHNOFINJFF EGJINJKGIAK, [In] AENIBMFNBOO PPMHPNOFLGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class NPNKGPHEJNN
{
	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1F819A0", Offset = "0x1F801A0", VA = "0x181F819A0")]
	public static OPLLKKMGFPC HNAIEAEAFJH([In] this HKDHDGKFGJB EGJINJKGIAK, PKOMODIBNOD HKAKMPIMEOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x1F81B60", Offset = "0x1F80360", VA = "0x181F81B60")]
	public static HKDHDGKFGJB PKPMANIAHDL(this OPLLKKMGFPC EGJINJKGIAK)
	{
		return default(HKDHDGKFGJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct PEIPINKLDID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public readonly KPFGDODNFBO<FICFLFAPGGD> HACJAPCJILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public readonly KPFGDODNFBO<CNIDNALDCPF> BGDMJIMHLLK;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x1B51C30", Offset = "0x1B50430", VA = "0x181B51C30")]
	private PEIPINKLDID(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> NBEKJKEDPBE, KPFGDODNFBO<CNIDNALDCPF> OPNPBHOMMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1F81D90", Offset = "0x1F80590", VA = "0x181F81D90")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, PEIPINKLDID> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, PEIPINKLDID>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2C4A570", Offset = "0x2C48D70", VA = "0x182C4A570")]
	public static MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] PEIPINKLDID EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct EIHPGABMEOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly KPFGDODNFBO<GPCAGFNHADK>? AINGEBOALMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly KPFGDODNFBO<DEHBGIDHIKL> FHIKDNKGAGE;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x1F26840", Offset = "0x1F25040", VA = "0x181F26840")]
	private EIHPGABMEOF(KPFGDODNFBO<GPCAGFNHADK>? NACEFCKPKPL, KPFGDODNFBO<DEHBGIDHIKL> KHIEKIHGGHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1F67670", Offset = "0x1F65E70", VA = "0x181F67670")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, EIHPGABMEOF> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, EIHPGABMEOF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2917DF0", Offset = "0x29165F0", VA = "0x182917DF0")]
	public static MEKCEIEFNPI<KPFGDODNFBO<GPCAGFNHADK>, FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] EIHPGABMEOF EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<KPFGDODNFBO<GPCAGFNHADK>, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct CHNPDFJLPJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly KPFGDODNFBO<GHBFIOLFDBB> OCEMBOOHLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly KPFGDODNFBO<GOLMGBIAPOO> OJGNPECLLFB;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1B51C30", Offset = "0x1B50430", VA = "0x181B51C30")]
	private CHNPDFJLPJG(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1F660E0", Offset = "0x1F648E0", VA = "0x181F660E0")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, CHNPDFJLPJG> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, CHNPDFJLPJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x28ADE90", Offset = "0x28AC690", VA = "0x1828ADE90")]
	public static MEKCEIEFNPI<KPFGDODNFBO<CNIDNALDCPF>, FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] CHNPDFJLPJG EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<KPFGDODNFBO<CNIDNALDCPF>, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct EPKEGJACOEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public readonly KPFGDODNFBO<DNFJKNPMMBK> AFOAPOMGDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly BAPMBLOBIME NPNMPABLGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly FLOGLJPGMHF NIILCMPNFAF;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x1F678C0", Offset = "0x1F660C0", VA = "0x181F678C0")]
	private EPKEGJACOEF(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<DNFJKNPMMBK> OIEEOLLBGNA, [In] BAPMBLOBIME EONDIBIJGLI, [In] FLOGLJPGMHF JOKJOHNELPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1F67750", Offset = "0x1F65F50", VA = "0x181F67750")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, EPKEGJACOEF> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, EPKEGJACOEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2928EA0", Offset = "0x29276A0", VA = "0x182928EA0")]
	public static MEKCEIEFNPI<KPFGDODNFBO<GHBFIOLFDBB>, FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] EPKEGJACOEF EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<KPFGDODNFBO<GHBFIOLFDBB>, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct LPGHEMNCDNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public readonly KPFGDODNFBO<GHBFIOLFDBB> OCEMBOOHLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public readonly int EKOBOCNFGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public readonly IFMODNOJONE LBCGEBEPPGP;

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1F620E0", Offset = "0x1F608E0", VA = "0x181F620E0")]
	private LPGHEMNCDNO(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int JFOGABNIOHM, IFMODNOJONE HKAKMPIMEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1F6EBE0", Offset = "0x1F6D3E0", VA = "0x181F6EBE0")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, LPGHEMNCDNO> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, LPGHEMNCDNO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2B5AED0", Offset = "0x2B596D0", VA = "0x182B5AED0")]
	public static MEKCEIEFNPI<(KPFGDODNFBO<CNIDNALDCPF>, KPFGDODNFBO<FICFLFAPGGD>), FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] LPGHEMNCDNO EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<(KPFGDODNFBO<CNIDNALDCPF>, KPFGDODNFBO<FICFLFAPGGD>), FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct BBDMFEIBKLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public readonly KPFGDODNFBO<GHBFIOLFDBB> OCEMBOOHLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly int ENPLNOPNNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly IFMODNOJONE LBCGEBEPPGP;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x1F620E0", Offset = "0x1F608E0", VA = "0x181F620E0")]
	private BBDMFEIBKLI(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int JFOGABNIOHM, IFMODNOJONE HKAKMPIMEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1F61F70", Offset = "0x1F60770", VA = "0x181F61F70")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, BBDMFEIBKLI> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, BBDMFEIBKLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x282E760", Offset = "0x282CF60", VA = "0x18282E760")]
	public static MEKCEIEFNPI<(KPFGDODNFBO<FICFLFAPGGD>, KPFGDODNFBO<CNIDNALDCPF>), FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] BBDMFEIBKLI EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<(KPFGDODNFBO<FICFLFAPGGD>, KPFGDODNFBO<CNIDNALDCPF>), FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct HHACBIDFNNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly KPFGDODNFBO<GHBFIOLFDBB> OCEMBOOHLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly int EKOBOCNFGHD;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x1B51C30", Offset = "0x1B50430", VA = "0x181B51C30")]
	private HHACBIDFNNP(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int OHHOEGDMHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CCE0", Offset = "0x1F6B4E0", VA = "0x181F6CCE0")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, HHACBIDFNNP> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, HHACBIDFNNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2AACFF0", Offset = "0x2AAB7F0", VA = "0x182AACFF0")]
	public static MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] HHACBIDFNNP EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct HCHDOMPDNFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public readonly KPFGDODNFBO<GHBFIOLFDBB> OCEMBOOHLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly int ENPLNOPNNKL;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x1B51C30", Offset = "0x1B50430", VA = "0x181B51C30")]
	private HCHDOMPDNFB(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int OHHOEGDMHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1F6C660", Offset = "0x1F6AE60", VA = "0x181F6C660")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, HCHDOMPDNFB> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, HCHDOMPDNFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA92E0", Offset = "0x2AA7AE0", VA = "0x182AA92E0")]
	public static MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] HCHDOMPDNFB EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct CDEMJOIJKJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly KPFGDODNFBO<CNIDNALDCPF> MLHDEEICKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public readonly HKDHDGKFGJB OAKHKBCMPHH;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1F64E50", Offset = "0x1F63650", VA = "0x181F64E50")]
	private CDEMJOIJKJF(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ, [In] HKDHDGKFGJB HLCNDDGKJJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1F64D40", Offset = "0x1F63540", VA = "0x181F64D40")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, CDEMJOIJKJF> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, CDEMJOIJKJF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x289C820", Offset = "0x289B020", VA = "0x18289C820")]
	public static MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] CDEMJOIJKJF EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct KFELOOKJBNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public readonly KPFGDODNFBO<FICFLFAPGGD> HACJAPCJILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public readonly KPFGDODNFBO<CNIDNALDCPF> BGDMJIMHLLK;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x1B51C30", Offset = "0x1B50430", VA = "0x181B51C30")]
	private KFELOOKJBNA(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> NBEKJKEDPBE, KPFGDODNFBO<CNIDNALDCPF> OPNPBHOMMHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E430", Offset = "0x1F6CC30", VA = "0x181F6E430")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, KFELOOKJBNA> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, KFELOOKJBNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2B273C0", Offset = "0x2B25BC0", VA = "0x182B273C0")]
	public static MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] KFELOOKJBNA EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct IADGLOCGPCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
	private IADGLOCGPCM(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x1F6D0B0", Offset = "0x1F6B8B0", VA = "0x181F6D0B0")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, IADGLOCGPCM> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, IADGLOCGPCM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2ABF8C0", Offset = "0x2ABE0C0", VA = "0x182ABF8C0")]
	public static MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] IADGLOCGPCM EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct KANFHPNAJHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly KPFGDODNFBO<GPCAGFNHADK> IIDMDJMPOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly KPFGDODNFBO<GHBFIOLFDBB> OCEMBOOHLEM;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
	private KANFHPNAJHA(KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x1F6E370", Offset = "0x1F6CB70", VA = "0x181F6E370")]
	public static KAPLCJNFCJL<CCBMGFEGKNJ, KANFHPNAJHA> LGDGMAPANEP(FFPCMKOBEGP GBNFLMDHJDA)
	{
		return default(KAPLCJNFCJL<CCBMGFEGKNJ, KANFHPNAJHA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2B1BD80", Offset = "0x2B1A580", VA = "0x182B1BD80")]
	public static MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB> HBHJMBFCIJJ<TRoot>(TRoot AHKBBGKKCNK, [In] KANFHPNAJHA EGJINJKGIAK) where TRoot : APIEPECKJBO
	{
		return default(MEKCEIEFNPI<KNDENJDHONE, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class EIBPIPMPOGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly Guid BBLLFHNFDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public readonly bool NDFMKPPOJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public readonly bool NOLNJMOAJKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly bool ONCLEHAHAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public readonly bool DFEKFGAAGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly bool LBLHIENJGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly List<(string Name, PKOMODIBNOD Type)> FDPJDMLIIIB;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Guid ACEJJAKLDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1F34790", Offset = "0x1F32F90", VA = "0x181F34790")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string HMPIIAILGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x844F30", Offset = "0x843730", VA = "0x180844F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public IReadOnlyList<(string Name, PKOMODIBNOD Type)> OIEJANJHCID
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action HKENALJNLKP
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1F67540", Offset = "0x1F65D40", VA = "0x181F67540")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1F67260", Offset = "0x1F65A60", VA = "0x181F67260")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<string, PKOMODIBNOD> KLGMKJLEOMD
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x1F67300", Offset = "0x1F65B00", VA = "0x181F67300")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1F66EB0", Offset = "0x1F656B0", VA = "0x181F66EB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<int> DMOKEPGLJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1F66F60", Offset = "0x1F65760", VA = "0x181F66F60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1F673B0", Offset = "0x1F65BB0", VA = "0x181F673B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action GLKGDFDODJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x1F66D80", Offset = "0x1F65580", VA = "0x181F66D80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1F67010", Offset = "0x1F65810", VA = "0x181F67010")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x1CCD590", Offset = "0x1CCBD90", VA = "0x181CCD590")]
	public void IELKGHDMENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x1F675E0", Offset = "0x1F65DE0", VA = "0x181F675E0")]
	internal EIBPIPMPOGP([In] Guid EGNLNANJFMI, string GCDLMFGKKMH, bool LNEMJJIJNJP, bool GONKGFOMJAJ, bool FDEDJHIFCCC, bool PMEPDHJMGJP, bool MGCFIAMBILD, List<(string Name, PKOMODIBNOD Type)> PJFBFEDAOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1F66E20", Offset = "0x1F65620", VA = "0x181F66E20")]
	public static NIFIEPDAAAO HHCMFMGGOKF(string EGNLNANJFMI, string GCDLMFGKKMH, bool LNEMJJIJNJP = false, bool GONKGFOMJAJ = false, bool FDEDJHIFCCC = false, bool PMEPDHJMGJP = true, bool MGCFIAMBILD = true)
	{
		return default(NIFIEPDAAAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x1F67460", Offset = "0x1F65C60", VA = "0x181F67460")]
	public static EIBPIPMPOGP OBMEADHNCNH([In] Guid EGNLNANJFMI, string GCDLMFGKKMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x1F66D20", Offset = "0x1F65520", VA = "0x181F66D20")]
	public void AOHMKGKHGGF(string GCDLMFGKKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1F670B0", Offset = "0x1F658B0", VA = "0x181F670B0")]
	public void MGDAIBJPIAN(string GCDLMFGKKMH, PKOMODIBNOD JPCNFDCDDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x1F671F0", Offset = "0x1F659F0", VA = "0x181F671F0")]
	public void MOKAFPMBICF(int JBDLDJOINOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct NIFIEPDAAAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private readonly Guid BBLLFHNFDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly string NNIAFGOIGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly bool BHIGLAGFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly bool PMLBKAEKJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly bool AOGMCMLNOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly bool MLICKDEBAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool JGILCIGKGDJ;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E2B0", Offset = "0x1F7CAB0", VA = "0x181F7E2B0")]
	public NIFIEPDAAAO([In] Guid EGNLNANJFMI, string GCDLMFGKKMH, bool LNEMJJIJNJP, bool GONKGFOMJAJ, bool FDEDJHIFCCC, bool PMEPDHJMGJP, bool MGCFIAMBILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E130", Offset = "0x1F7C930", VA = "0x181F7E130")]
	public HMEBIOCHFOL FIPNHECIBHD(string GCDLMFGKKMH, PKOMODIBNOD HKAKMPIMEOA)
	{
		return default(HMEBIOCHFOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E010", Offset = "0x1F7C810", VA = "0x181F7E010")]
	public EIBPIPMPOGP AICBEBBPJOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct HMEBIOCHFOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly Guid BBLLFHNFDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly string NNIAFGOIGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly bool BHIGLAGFJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly bool PMLBKAEKJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly bool AOGMCMLNOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly bool MLICKDEBAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly bool JGILCIGKGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly List<(string Name, PKOMODIBNOD Type)> FDPJDMLIIIB;

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CFE0", Offset = "0x1F6B7E0", VA = "0x181F6CFE0")]
	public HMEBIOCHFOL([In] Guid EGNLNANJFMI, string GCDLMFGKKMH, bool LNEMJJIJNJP, bool GONKGFOMJAJ, bool FDEDJHIFCCC, bool PMEPDHJMGJP, bool MGCFIAMBILD, List<(string Name, PKOMODIBNOD Type)> PJFBFEDAOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CE90", Offset = "0x1F6B690", VA = "0x181F6CE90")]
	public HMEBIOCHFOL FIPNHECIBHD(string GCDLMFGKKMH, PKOMODIBNOD HKAKMPIMEOA)
	{
		return default(HMEBIOCHFOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x1F6CDA0", Offset = "0x1F6B5A0", VA = "0x181F6CDA0")]
	public EIBPIPMPOGP AICBEBBPJOO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BMIPKIFFJII
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class GKFAFJBHJIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly EIBPIPMPOGP LKFMEFEHKPA;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly EIBPIPMPOGP KECLKCIFMHE;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class MCCJIGIHBBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly EIBPIPMPOGP PMCOHEJFDJN;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class GJBGDBMBOEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly EIBPIPMPOGP LMDAOECICOP;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly EIBPIPMPOGP LDKPGDOPOID;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class HAJPNMNDEPN
	{
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly EIBPIPMPOGP DMKKEBOJDBN;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly EIBPIPMPOGP DDFHBCLCGCN;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class GLGLIFHDCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly EIBPIPMPOGP FPBDEEBHIII;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly EIBPIPMPOGP BGFLCEKJIAA;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class ILEFHKBNLHL
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly EIBPIPMPOGP LMDAOECICOP;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly EIBPIPMPOGP LDKPGDOPOID;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class JKPMNPCALPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly EIBPIPMPOGP PPHDBMOLMGF;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly EIBPIPMPOGP DHFPDFMDHHF;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly EIBPIPMPOGP AOOBFLBPHLJ;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly EIBPIPMPOGP GLKBOACKMGD;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly EIBPIPMPOGP BGFJKDBOCOL;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly EIBPIPMPOGP AINKHNFBLKF;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly EIBPIPMPOGP MPGIGNLHFNM;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class DPOGJHKKPOI
	{
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class GBHEKFHNFEL
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class CEAAOGNOAID
	{
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class DLEJAIPPODF
	{
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly EIBPIPMPOGP EAGKPKCFLNL;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly EIBPIPMPOGP CMKAFKADNAN;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class OPENJDMDKFG
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class MPOFNHPEBBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class AMPCBMAKLID
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class GDBOGPCFDCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class DOEOAEPPFGA
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly EIBPIPMPOGP MHNDMDECLJI;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class MKNJBHEKHPE
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly EIBPIPMPOGP MAMFDGGJHEF;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly EIBPIPMPOGP NCHIMMMEPKN;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly EIBPIPMPOGP JOILGPCGBEI;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly EIBPIPMPOGP FPBDEEBHIII;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly EIBPIPMPOGP IHGBBGJGKNA;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly EIBPIPMPOGP MGCBGANHKNF;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly EIBPIPMPOGP NCLONAPHJDC;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly EIBPIPMPOGP GOFBJGDAFMA;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly EIBPIPMPOGP LMFELNJIFPP;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly EIBPIPMPOGP AGNNGJFOOIN;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly EIBPIPMPOGP FJFABGHGDGB;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly EIBPIPMPOGP LGMFPKBILFO;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly EIBPIPMPOGP CKDHMNCDAOB;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly EIBPIPMPOGP AIGCNHCLNOP;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly EIBPIPMPOGP EDJKJMDOHBH;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly EIBPIPMPOGP CDEAHAPJBHP;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly EIBPIPMPOGP AHDMFLMCJAN;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly EIBPIPMPOGP JCIHDDDAMKN;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly EIBPIPMPOGP NLNCOEBPFHM;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly EIBPIPMPOGP IOMEMEGNGFM;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly EIBPIPMPOGP DGHMEKLKPDN;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly EIBPIPMPOGP NBKDMDKJMEP;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly EIBPIPMPOGP JKIIMHADAFJ;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly EIBPIPMPOGP AAHGLDDNPEI;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public static readonly EIBPIPMPOGP ADBNLPDKOMB;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly EIBPIPMPOGP NPCIADHMBOC;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly EIBPIPMPOGP GHDANCBLMHO;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly EIBPIPMPOGP IMLAJOLKGGK;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly EIBPIPMPOGP LPGMIEHLCHD;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly EIBPIPMPOGP ONPFLMJNFGG;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public static readonly EIBPIPMPOGP GKICBNDADHO;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public static readonly EIBPIPMPOGP PMFNINNBIAE;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly EIBPIPMPOGP MLCKIKMBOLC;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public static readonly EIBPIPMPOGP MOJDIHCGGPM;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public static readonly EIBPIPMPOGP MILNHHOCCEF;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public static readonly EIBPIPMPOGP CCKAHPEKIKP;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public static readonly EIBPIPMPOGP DBHPJDGDMHK;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public static readonly EIBPIPMPOGP PLEGLPKJEBJ;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public static readonly EIBPIPMPOGP JKJPGBIPAHK;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public static readonly EIBPIPMPOGP PIOJCJIBCGC;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public static readonly EIBPIPMPOGP LECFCDEGHPH;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public static readonly EIBPIPMPOGP LCAIGOLPHFF;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static readonly EIBPIPMPOGP AMOPMCNOGCE;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public static readonly EIBPIPMPOGP BBEJEKFJHHN;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static readonly EIBPIPMPOGP FFIAGNAPLAP;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public static readonly EIBPIPMPOGP ABDPIJGEIFB;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public static readonly EIBPIPMPOGP NJEGPAOKPCM;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public static readonly EIBPIPMPOGP KNCLEOCGOFF;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public static readonly EIBPIPMPOGP BFLMEJJHOEE;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static readonly EIBPIPMPOGP DHOFDIMGPPF;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public static readonly EIBPIPMPOGP NGLDNAMIFGD;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public static readonly EIBPIPMPOGP HDIDHCGJEHN;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public static readonly EIBPIPMPOGP ADKEGPOJEOF;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static readonly EIBPIPMPOGP JILBABIEIFM;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public static readonly EIBPIPMPOGP GELMKPFGAKF;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public static readonly EIBPIPMPOGP JBFAMICAJBN;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static readonly EIBPIPMPOGP EDLHKPODNJA;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public static readonly EIBPIPMPOGP JDDEAAIEHED;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class GFECMAGLMLD
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class JPFJANADEJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public static readonly EIBPIPMPOGP KFDFOHHIJFD;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public static readonly EIBPIPMPOGP CHEAPHHCLBO;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public static readonly EIBPIPMPOGP DJKNOIOANLN;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public static readonly EIBPIPMPOGP JJODBKECGBA;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public static readonly EIBPIPMPOGP GAAOFFHDHFH;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public static readonly EIBPIPMPOGP MMIKDLJOPKD;

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class JNBHAFHINEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly EIBPIPMPOGP MAMFDGGJHEF;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public static readonly EIBPIPMPOGP NCHIMMMEPKN;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly EIBPIPMPOGP EMOOHINPKLO;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public static readonly EIBPIPMPOGP PLGKJOFKDAO;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public static readonly EIBPIPMPOGP BDMCKHFHHCO;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public static readonly EIBPIPMPOGP OOGCFHBEHLE;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class HCOLCAKIPDK
	{
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly EIBPIPMPOGP EFFKNDFMCEL;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly EIBPIPMPOGP FMCBMEMIKDH;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public static readonly EIBPIPMPOGP CKIJMIKIBPO;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly EIBPIPMPOGP BCDLEAJCOBD;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public static readonly EIBPIPMPOGP IKOHOHHOFGD;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public static readonly EIBPIPMPOGP LLLDDDFHAKN;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class PBLPCKFBNPN
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class DOCEIAFCHHC
	{
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class OJBDLJEIBKC
	{
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public static readonly EIBPIPMPOGP JHDDOGILMNA;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class AOCGKDJBADI
	{
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly EIBPIPMPOGP MHNDMDECLJI;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class HEHCMBPFGKK
	{
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class KIBAHDAOMFE
	{
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class FGDHGLJNDIG
	{
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public static readonly EIBPIPMPOGP EECKDJONMHA;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly EIBPIPMPOGP GFKDKEMDGOE;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public static readonly EIBPIPMPOGP JFEPJAMEOCG;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public static readonly EIBPIPMPOGP HPNABGJLDAA;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class LJCNBBHHHKN
	{
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public static readonly EIBPIPMPOGP FGGEPECMNAI;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static readonly EIBPIPMPOGP OJAOCPOHMBP;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class ODGBPHHCFNO
	{
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class ELEMCILIKNM
	{
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public static readonly EIBPIPMPOGP KFDFOHHIJFD;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static readonly EIBPIPMPOGP CHEAPHHCLBO;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class IBKADEDMJIN
	{
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public static readonly EIBPIPMPOGP NCBHAEONLMG;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public static readonly EIBPIPMPOGP JJODBKECGBA;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public static readonly EIBPIPMPOGP GAAOFFHDHFH;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public static readonly EIBPIPMPOGP MMIKDLJOPKD;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public static readonly EIBPIPMPOGP JDOEMBMMOLP;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public static readonly EIBPIPMPOGP EGDNIIOPGPA;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public static readonly EIBPIPMPOGP LFMHEDLJJAC;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public static readonly EIBPIPMPOGP JAHKFKFMMPE;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public static readonly EIBPIPMPOGP FJEIAEGMOJL;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public static readonly EIBPIPMPOGP FKDHKMLGMEH;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public static readonly EIBPIPMPOGP KFDFOHHIJFD;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public static readonly EIBPIPMPOGP CHEAPHHCLBO;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class LOPGGJFDMPG
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class NKJIFEGJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public static readonly EIBPIPMPOGP KFDFOHHIJFD;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public static readonly EIBPIPMPOGP CHEAPHHCLBO;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public static readonly EIBPIPMPOGP BJDJLBPHEPP;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public static readonly EIBPIPMPOGP PKPHMEKKDMH;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public static readonly EIBPIPMPOGP PMFOCNFPMMM;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class CDPHJMPMGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public static class HFNPPIPLOAO
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public static readonly EIBPIPMPOGP DGHKEDFPDFH;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class DKMNMMGKEOM
	{
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public static readonly EIBPIPMPOGP LKPLJOAAGNE;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public static readonly EIBPIPMPOGP NKIGJFAKDGN;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public static readonly EIBPIPMPOGP KFDFOHHIJFD;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public static readonly EIBPIPMPOGP CHEAPHHCLBO;

		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class JJCDABOIJMA
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class OJLBEMGOKPM
	{
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public static class AOLABKCJPAK
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public static class EMCMDOBKBNO
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class BJALFAEABAF
	{
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public static readonly EIBPIPMPOGP EAGKPKCFLNL;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public static readonly EIBPIPMPOGP CMKAFKADNAN;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class JODJLGPMKFI
	{
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public static readonly EIBPIPMPOGP GIAPEJGJINI;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public static readonly EIBPIPMPOGP LJANBHLFFOO;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public static readonly EIBPIPMPOGP BGGLIDPFPBG;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public static readonly EIBPIPMPOGP KPGGEDHOBNK;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class EPDFJAGGKEA
	{
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public static readonly EIBPIPMPOGP GIAPEJGJINI;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public static readonly EIBPIPMPOGP LJANBHLFFOO;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public static readonly EIBPIPMPOGP BGGLIDPFPBG;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public static readonly EIBPIPMPOGP KPGGEDHOBNK;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public static class MKOOHJGBCGD
	{
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class BKOPAFNLLKP
	{
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public static readonly EIBPIPMPOGP HCNBGALGEAN;

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public static readonly EIBPIPMPOGP DKMBGNLKDPB;

		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public static readonly EIBPIPMPOGP HNOCBMHGAEH;

		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class LDFKHECCONO
	{
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public static readonly EIBPIPMPOGP DMCHNBKKCAL;

		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public static readonly EIBPIPMPOGP FJIMEFLNGLJ;

		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public static readonly EIBPIPMPOGP LEGLBJDLJNG;

		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public static class AAPEILMEBLH
	{
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class KKGNDOOMABA
	{
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public static readonly EIBPIPMPOGP LHBNACJKOGB;

		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public static readonly EIBPIPMPOGP ACJENFGPAPH;

		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public static readonly EIBPIPMPOGP PPGODPGBPBM;

		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public static readonly EIBPIPMPOGP EHBAGMIOLBD;

		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public static readonly EIBPIPMPOGP ALELPNECHLK;

		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class HBNAJPBDJBN
	{
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public static readonly EIBPIPMPOGP DJNCKOFDIEN;

		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public static class PCOCNNGHFDI
	{
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public static readonly EIBPIPMPOGP LBHKLNIFGCP;

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public static readonly EIBPIPMPOGP EHPCBGOLLND;

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public static readonly EIBPIPMPOGP EKEKPPKGEFH;

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public static class CMDLEFIENPJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class FDJBJBOPFPP
	{
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public static class GMMBCJPGCKP
	{
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public static class EPHGMPEAHKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public static readonly EIBPIPMPOGP GIPOILHEDFC;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public static readonly EIBPIPMPOGP MADFEBFCMCC;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public static readonly EIBPIPMPOGP BEMONFOMFJG;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		internal static readonly EIBPIPMPOGP[] PENPJHPBNAA;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public abstract class HBOBMNPBINN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public readonly PKOMODIBNOD GNHKOBDDJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly List<EIBPIPMPOGP> DHOONHJEDMF;

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public IReadOnlyList<EIBPIPMPOGP> DODKEOEJCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A560", Offset = "0x1F88D60", VA = "0x181F8A560")]
	protected HBOBMNPBINN(PKOMODIBNOD OACHEIGJJHH, params EIBPIPMPOGP[][] NDMBDPLCDJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class ILLIPJLJDIP : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CB90", Offset = "0x1F8B390", VA = "0x181F8CB90")]
	internal ILLIPJLJDIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class GHNDFAOCKJP : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1F89EF0", Offset = "0x1F886F0", VA = "0x181F89EF0")]
	internal GHNDFAOCKJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class BGMDGLAJLPF : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x1F847F0", Offset = "0x1F82FF0", VA = "0x181F847F0")]
	internal BGMDGLAJLPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class AMLKAKDFOHL : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x1F84110", Offset = "0x1F82910", VA = "0x181F84110")]
	internal AMLKAKDFOHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class MDACHCDOJFA : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x1F91160", Offset = "0x1F8F960", VA = "0x181F91160")]
	internal MDACHCDOJFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class IBJEHCGDAFP : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x1F8BB90", Offset = "0x1F8A390", VA = "0x181F8BB90")]
	internal IBJEHCGDAFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class POBDHKCBMBH : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x1F94E60", Offset = "0x1F93660", VA = "0x181F94E60")]
	internal POBDHKCBMBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class HFOIMOCAPGN : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B5F0", Offset = "0x1F89DF0", VA = "0x181F8B5F0")]
	internal HFOIMOCAPGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class PKKGNKOFCAL : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x1F94730", Offset = "0x1F92F30", VA = "0x181F94730")]
	internal PKKGNKOFCAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class CJOLEOOONLO : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x1F85BD0", Offset = "0x1F843D0", VA = "0x181F85BD0")]
	internal CJOLEOOONLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class MIGPOPHLHEL : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x1F91520", Offset = "0x1F8FD20", VA = "0x181F91520")]
	internal MIGPOPHLHEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class OIIEHDMNEKP : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x1F93480", Offset = "0x1F91C80", VA = "0x181F93480")]
	internal OIIEHDMNEKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class JHGCFJIJOFG : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CF50", Offset = "0x1F8B750", VA = "0x181F8CF50")]
	internal JHGCFJIJOFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class GCFDFKKMEDP : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x1F89CB0", Offset = "0x1F884B0", VA = "0x181F89CB0")]
	internal GCFDFKKMEDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class MNFOBLNHBMD : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x1F91690", Offset = "0x1F8FE90", VA = "0x181F91690")]
	internal MNFOBLNHBMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class HNEGBFFECBE : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B7D0", Offset = "0x1F89FD0", VA = "0x181F8B7D0")]
	internal HNEGBFFECBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class MEAJIKFENKH : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x1F91340", Offset = "0x1F8FB40", VA = "0x181F91340")]
	internal MEAJIKFENKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class NOLGEDFHKKD : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1F92950", Offset = "0x1F91150", VA = "0x181F92950")]
	internal NOLGEDFHKKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class OHGHMFAMOOD : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1F93220", Offset = "0x1F91A20", VA = "0x181F93220")]
	internal OHGHMFAMOOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class MBAHOJICJBB : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1F90D20", Offset = "0x1F8F520", VA = "0x181F90D20")]
	internal MBAHOJICJBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class JOKNOMFHFLJ : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1F8EA50", Offset = "0x1F8D250", VA = "0x181F8EA50")]
	internal JOKNOMFHFLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class PBBOCPBHENM : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1F93D10", Offset = "0x1F92510", VA = "0x181F93D10")]
	internal PBBOCPBHENM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class LGDAHHNAPPC : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1F90750", Offset = "0x1F8EF50", VA = "0x181F90750")]
	internal LGDAHHNAPPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class PKFKANLNFLM : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1F94550", Offset = "0x1F92D50", VA = "0x181F94550")]
	internal PKFKANLNFLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class AKKLFJAJKLC : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1F833C0", Offset = "0x1F81BC0", VA = "0x181F833C0")]
	internal AKKLFJAJKLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class ABGIEBBNAIN : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1F82E20", Offset = "0x1F81620", VA = "0x181F82E20")]
	internal ABGIEBBNAIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class CFGPGDOKCDD : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1F85540", Offset = "0x1F83D40", VA = "0x181F85540")]
	internal CFGPGDOKCDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class PDNLPHLNLDP : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1F94370", Offset = "0x1F92B70", VA = "0x181F94370")]
	internal PDNLPHLNLDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class JMABNDFHFPM : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1F8D190", Offset = "0x1F8B990", VA = "0x181F8D190")]
	internal JMABNDFHFPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class HOJLEPEDHFO : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x1F8B9B0", Offset = "0x1F8A1B0", VA = "0x181F8B9B0")]
	internal HOJLEPEDHFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class EHHOGOIDOID : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1F872C0", Offset = "0x1F85AC0", VA = "0x181F872C0")]
	internal EHHOGOIDOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class PNFMMBEKOFC : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x1F94C80", Offset = "0x1F93480", VA = "0x181F94C80")]
	internal PNFMMBEKOFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class MCMBMOCOBOF : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x1F90F00", Offset = "0x1F8F700", VA = "0x181F90F00")]
	internal MCMBMOCOBOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class OGMAHALAJHH : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1F92FC0", Offset = "0x1F917C0", VA = "0x181F92FC0")]
	internal OGMAHALAJHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class OFBLCOCEHBH : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x1F92C00", Offset = "0x1F91400", VA = "0x181F92C00")]
	internal OFBLCOCEHBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class AELILNALCLM : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1F831E0", Offset = "0x1F819E0", VA = "0x181F831E0")]
	internal AELILNALCLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class KILOLBCGOEA : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1F8F610", Offset = "0x1F8DE10", VA = "0x181F8F610")]
	internal KILOLBCGOEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class BKGEKPEGGHJ : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1F84D90", Offset = "0x1F83590", VA = "0x181F84D90")]
	internal BKGEKPEGGHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class CHIGIGIONPB : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1F85810", Offset = "0x1F84010", VA = "0x181F85810")]
	internal CHIGIGIONPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class OFMLGFGIHKN : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1F92DE0", Offset = "0x1F915E0", VA = "0x181F92DE0")]
	internal OFMLGFGIHKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class ABPBJMGICJK : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1F83000", Offset = "0x1F81800", VA = "0x181F83000")]
	internal ABPBJMGICJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class EMBDHPKCJBG : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1F87AC0", Offset = "0x1F862C0", VA = "0x181F87AC0")]
	internal EMBDHPKCJBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class EKPHLLCLHAK : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x1F87520", Offset = "0x1F85D20", VA = "0x181F87520")]
	internal EKPHLLCLHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class FNPCIFIKGIG : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1F89AD0", Offset = "0x1F882D0", VA = "0x181F89AD0")]
	internal FNPCIFIKGIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class GIELGCICLPL : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A0D0", Offset = "0x1F888D0", VA = "0x181F8A0D0")]
	internal GIELGCICLPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class DDOMFBENAKI : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1F86180", Offset = "0x1F84980", VA = "0x181F86180")]
	internal DDOMFBENAKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class BEEAJBMELHE : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F84610", Offset = "0x1F82E10", VA = "0x181F84610")]
	internal BEEAJBMELHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class NAHNEFJBGPI : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F91870", Offset = "0x1F90070", VA = "0x181F91870")]
	internal NAHNEFJBGPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class DNJDDPKDFOK : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F86EA0", Offset = "0x1F856A0", VA = "0x181F86EA0")]
	internal DNJDDPKDFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class EBFDGBGJMEE : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1F870E0", Offset = "0x1F858E0", VA = "0x181F870E0")]
	internal EBFDGBGJMEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class CIAOBIMNIIK : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F859F0", Offset = "0x1F841F0", VA = "0x181F859F0")]
	internal CIAOBIMNIIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class JEGBJNCEEAE : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CD70", Offset = "0x1F8B570", VA = "0x181F8CD70")]
	internal JEGBJNCEEAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class OMGEHEBIBEN : HBOBMNPBINN
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F93B30", Offset = "0x1F92330", VA = "0x181F93B30")]
	internal OMGEHEBIBEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class HBPLICKLJAO : PMFKPPCBLGG
{
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A660", Offset = "0x1F88E60", VA = "0x181F8A660")]
	public HBPLICKLJAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class CPFBMNFLOKP : HJJHIMDKMJE<EPLGAHDLMCC>
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F840D0", Offset = "0x1F828D0", VA = "0x181F840D0")]
	protected CPFBMNFLOKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public abstract class DKCIHILLLFB : BIJOEDGAEPK<EPLGAHDLMCC>
{
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F86500", Offset = "0x1F84D00", VA = "0x181F86500")]
	protected DKCIHILLLFB([In] CMOBDPDMEIM BHNAHCHLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F863E0", Offset = "0x1F84BE0", VA = "0x181F863E0", Slot = "11")]
	public override void HCPJIHHHNJF(EPLGAHDLMCC AHKBBGKKCNK, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, OKHLIJCALEC ICLKOKIEPPK, KPFGDODNFBO<PGLFCGKLJFG.DGDPOBOLHHK>? EOCIGKKBMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F86470", Offset = "0x1F84C70", VA = "0x181F86470", Slot = "14")]
	public override void LIMDJGOIGFC(EPLGAHDLMCC AHKBBGKKCNK, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public abstract class HBHLGILILKO : DKCIHILLLFB
{
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F86500", Offset = "0x1F84D00", VA = "0x181F86500")]
	public HBHLGILILKO([In] CMOBDPDMEIM BHNAHCHLCKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public sealed class FFMGNBEIBON : CPFBMNFLOKP
{
	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "11")]
	public override void HCPJIHHHNJF(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, OKHLIJCALEC ICLKOKIEPPK, KPFGDODNFBO<PGLFCGKLJFG.DGDPOBOLHHK>? EOCIGKKBMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "12")]
	public override void EAECLOKGNBC(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F88A60", Offset = "0x1F87260", VA = "0x181F88A60", Slot = "13")]
	public override IEnumerable<MKPHKNHNCLA<PKOMODIBNOD>> MAFKKKOBPOI(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F887A0", Offset = "0x1F86FA0", VA = "0x181F887A0", Slot = "14")]
	public override void LIMDJGOIGFC(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F88A90", Offset = "0x1F87290", VA = "0x181F88A90")]
	public static void NMLICNFHOAO(EPLGAHDLMCC BGDDDMIGBBF, [In] NFLGKJNAJEM.OLAAGDDIHIL FAKPOFMOJJC, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F84090", Offset = "0x1F82890", VA = "0x181F84090", Slot = "15")]
	public override HKDHDGKFGJB ONJPNGGDBIH(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ, PKOMODIBNOD DFONJHMANFP)
	{
		return default(HKDHDGKFGJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F840D0", Offset = "0x1F828D0", VA = "0x181F840D0")]
	public FFMGNBEIBON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public sealed class ALFODNACFEO : CPFBMNFLOKP
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public sealed class AJCCPDIFNAC : CAEFPLIDPEM.HGMEPGLCHGG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public struct JHBIMAJOCBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public readonly KPFGDODNFBO<GPCAGFNHADK> LGJEEJCGPFO;

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
		private JHBIMAJOCBB(KPFGDODNFBO<GPCAGFNHADK> EGLLFPNPPPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xE0B770", Offset = "0xE09F70", VA = "0x180E0B770")]
		public static JHBIMAJOCBB OJFFIHPLODM(KPFGDODNFBO<GPCAGFNHADK> EGMAGGFLNJB)
		{
			return default(JHBIMAJOCBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F83840", Offset = "0x1F82040", VA = "0x181F83840", Slot = "11")]
	public override void HCPJIHHHNJF(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, OKHLIJCALEC ICLKOKIEPPK, KPFGDODNFBO<PGLFCGKLJFG.DGDPOBOLHHK>? EOCIGKKBMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F835A0", Offset = "0x1F81DA0", VA = "0x181F835A0", Slot = "12")]
	public override void EAECLOKGNBC(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F83F00", Offset = "0x1F82700", VA = "0x181F83F00", Slot = "13")]
	public override IEnumerable<MKPHKNHNCLA<PKOMODIBNOD>> MAFKKKOBPOI(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F839F0", Offset = "0x1F821F0", VA = "0x181F839F0", Slot = "14")]
	public override void LIMDJGOIGFC(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F83740", Offset = "0x1F81F40", VA = "0x181F83740")]
	public static void GOICKAAJIFM(EPLGAHDLMCC BGDDDMIGBBF, [In] NFLGKJNAJEM.OLAAGDDIHIL FAKPOFMOJJC, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F83F90", Offset = "0x1F82790", VA = "0x181F83F90")]
	public static void NMLICNFHOAO(EPLGAHDLMCC BGDDDMIGBBF, [In] NFLGKJNAJEM.OLAAGDDIHIL FAKPOFMOJJC, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F84090", Offset = "0x1F82890", VA = "0x181F84090", Slot = "15")]
	public override HKDHDGKFGJB ONJPNGGDBIH(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ, PKOMODIBNOD DFONJHMANFP)
	{
		return default(HKDHDGKFGJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F840D0", Offset = "0x1F828D0", VA = "0x181F840D0")]
	public ALFODNACFEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public sealed class DLGCEPIDIAN : CPFBMNFLOKP
{
	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "11")]
	public override void HCPJIHHHNJF(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, OKHLIJCALEC ICLKOKIEPPK, KPFGDODNFBO<PGLFCGKLJFG.DGDPOBOLHHK>? EOCIGKKBMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "12")]
	public override void EAECLOKGNBC(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F86E70", Offset = "0x1F85670", VA = "0x181F86E70", Slot = "13")]
	public override IEnumerable<MKPHKNHNCLA<PKOMODIBNOD>> MAFKKKOBPOI(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F86BB0", Offset = "0x1F853B0", VA = "0x181F86BB0", Slot = "14")]
	public override void LIMDJGOIGFC(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F86AB0", Offset = "0x1F852B0", VA = "0x181F86AB0")]
	public static void GOICKAAJIFM(EPLGAHDLMCC BGDDDMIGBBF, [In] NFLGKJNAJEM.OLAAGDDIHIL FAKPOFMOJJC, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1F84090", Offset = "0x1F82890", VA = "0x181F84090", Slot = "15")]
	public override HKDHDGKFGJB ONJPNGGDBIH(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ, PKOMODIBNOD DFONJHMANFP)
	{
		return default(HKDHDGKFGJB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F840D0", Offset = "0x1F828D0", VA = "0x181F840D0")]
	public DLGCEPIDIAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class NOEOBMMLPKB : DKCIHILLLFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public readonly KPFGDODNFBO<GOLMGBIAPOO> BECJGBDGGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public readonly KPFGDODNFBO<DBEENCOBDHN> AFBGEHGBIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public readonly KPFGDODNFBO<DBEENCOBDHN> IJIFBEPCKCP;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F92650", Offset = "0x1F90E50", VA = "0x181F92650")]
	public NOEOBMMLPKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public abstract class PMFKPPCBLGG : BDEONIFFIGA<EPLGAHDLMCC>
{
	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F94C30", Offset = "0x1F93430", VA = "0x181F94C30")]
	protected PMFKPPCBLGG([In] ODEKHKMBDCC BHNAHCHLCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1F94AF0", Offset = "0x1F932F0", VA = "0x181F94AF0", Slot = "11")]
	public override void HCPJIHHHNJF(EPLGAHDLMCC AHKBBGKKCNK, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, OKHLIJCALEC ICLKOKIEPPK, KPFGDODNFBO<PGLFCGKLJFG.DGDPOBOLHHK>? EOCIGKKBMPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1F94A50", Offset = "0x1F93250", VA = "0x181F94A50", Slot = "12")]
	public override void EAECLOKGNBC(EPLGAHDLMCC AHKBBGKKCNK, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1F94BA0", Offset = "0x1F933A0", VA = "0x181F94BA0", Slot = "14")]
	public override void LIMDJGOIGFC(EPLGAHDLMCC AHKBBGKKCNK, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F94910", Offset = "0x1F93110", VA = "0x181F94910", Slot = "17")]
	public override MEKCEIEFNPI<KPFGDODNFBO<CNIDNALDCPF>, FDKFIPGCOGB> BEEFCDPKACA(EPLGAHDLMCC AHKBBGKKCNK, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, KPFGDODNFBO<GOLMGBIAPOO> EFMFHDBJLDJ)
	{
		return default(MEKCEIEFNPI<KPFGDODNFBO<CNIDNALDCPF>, FDKFIPGCOGB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class KIBNAACEKCN : HBHLGILILKO
{
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F8F3B0", Offset = "0x1F8DBB0", VA = "0x181F8F3B0")]
	public KIBNAACEKCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public struct HCBLDGAKHKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	public BAPMBLOBIME NPNMPABLGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public FLOGLJPGMHF NIILCMPNFAF;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1F8AA20", Offset = "0x1F89220", VA = "0x181F8AA20")]
	internal HCBLDGAKHKC([In] BAPMBLOBIME KKDCNJKFOII, [In] FLOGLJPGMHF HGJODEDMNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1F8A9D0", Offset = "0x1F891D0", VA = "0x181F8A9D0")]
	public static HCBLDGAKHKC OJFFIHPLODM()
	{
		return default(HCBLDGAKHKC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1F8AA00", Offset = "0x1F89200", VA = "0x181F8AA00")]
	public static HCBLDGAKHKC PMGDHNKMLHE([In] BAPMBLOBIME KKDCNJKFOII, [In] FLOGLJPGMHF HGJODEDMNMO)
	{
		return default(HCBLDGAKHKC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public sealed class CMDDBEHHBNH : PMFKPPCBLGG
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1F85DB0", Offset = "0x1F845B0", VA = "0x181F85DB0")]
	public CMDDBEHHBNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public sealed class IJPLECONDJE
{
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public sealed class NFLGKJNAJEM : BDBDEKNDPBG
{
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public sealed class AGFAGBCDPGG : OGPHMFGOEIO.FCBJCMKOJNM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public struct OLAAGDDIHIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public string HMPIIAILGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public DPKMCLCFMEL<GOLMGBIAPOO, IFMODNOJONE> BKAHNEONHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public DPKMCLCFMEL<DBEENCOBDHN, IFMODNOJONE> NEBGAHDKBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public readonly KPFGDODNFBO<GHBFIOLFDBB> ILFDJMFENJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public readonly KPFGDODNFBO<GHBFIOLFDBB> PNIOFMFGOMH;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1F93A60", Offset = "0x1F92260", VA = "0x181F93A60")]
		private OLAAGDDIHIL(string GCDLMFGKKMH, [In] DPKMCLCFMEL<GOLMGBIAPOO, IFMODNOJONE> FPMJPCCLAIC, [In] DPKMCLCFMEL<DBEENCOBDHN, IFMODNOJONE> CJLPBJALDFK, KPFGDODNFBO<GHBFIOLFDBB> JONCBAHLJHP, KPFGDODNFBO<GHBFIOLFDBB> BOONCEPLCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x1F93910", Offset = "0x1F92110", VA = "0x181F93910")]
		public static OLAAGDDIHIL OJFFIHPLODM(KPFGDODNFBO<GHBFIOLFDBB> KKIOPJCEHHE, KPFGDODNFBO<GHBFIOLFDBB> KAGODDIHNOJ)
		{
			return default(OLAAGDDIHIL);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x1F939E0", Offset = "0x1F921E0", VA = "0x181F939E0")]
		public static OLAAGDDIHIL PMGDHNKMLHE(string GCDLMFGKKMH, [In] DPKMCLCFMEL<GOLMGBIAPOO, IFMODNOJONE> FPMJPCCLAIC, [In] DPKMCLCFMEL<DBEENCOBDHN, IFMODNOJONE> CJLPBJALDFK, KPFGDODNFBO<GHBFIOLFDBB> KKIOPJCEHHE, KPFGDODNFBO<GHBFIOLFDBB> KAGODDIHNOJ)
		{
			return default(OLAAGDDIHIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1F91CA0", Offset = "0x1F904A0", VA = "0x181F91CA0", Slot = "8")]
	public override void HCPJIHHHNJF(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, OKHLIJCALEC ICLKOKIEPPK, KPFGDODNFBO<PGLFCGKLJFG.DGDPOBOLHHK>? HHFHLNABMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F91A50", Offset = "0x1F90250", VA = "0x181F91A50", Slot = "9")]
	public override void EAECLOKGNBC(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F845D0", Offset = "0x1F82DD0", VA = "0x181F845D0")]
	public NFLGKJNAJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public static class OLAIILDLKDO
{
	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1F93AD0", Offset = "0x1F922D0", VA = "0x181F93AD0")]
	public static void PGFGBHFCFEG(this NFLGKJNAJEM.OLAAGDDIHIL EGJINJKGIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public abstract class BDBDEKNDPBG : PKBOHKIPEHH<EPLGAHDLMCC>
{
	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1F845D0", Offset = "0x1F82DD0", VA = "0x181F845D0")]
	protected BDBDEKNDPBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public readonly struct IFMODNOJONE : IEquatable<IFMODNOJONE>, LDBDBADILKG<IFMODNOJONE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public readonly string HMPIIAILGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public readonly PKOMODIBNOD LBCGEBEPPGP;

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0xA648B0", Offset = "0xA630B0", VA = "0x180A648B0")]
	private IFMODNOJONE(string GCDLMFGKKMH, PKOMODIBNOD HKAKMPIMEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F5B910", Offset = "0x1F5A110", VA = "0x181F5B910")]
	public static IFMODNOJONE OJFFIHPLODM(string GCDLMFGKKMH, PKOMODIBNOD HKAKMPIMEOA)
	{
		return default(IFMODNOJONE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CAA0", Offset = "0x1F8B2A0", VA = "0x181F8CAA0")]
	public static bool JAJJILMADFD([In] IFMODNOJONE JOMKMIJJPCA, [In] IFMODNOJONE DFLDBCDDIFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CAA0", Offset = "0x1F8B2A0", VA = "0x181F8CAA0", Slot = "4")]
	public bool Equals(IFMODNOJONE OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CAA0", Offset = "0x1F8B2A0", VA = "0x181F8CAA0")]
	public bool FBAIKNDMJDK([In] IFMODNOJONE OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1F8C9E0", Offset = "0x1F8B1E0", VA = "0x181F8C9E0", Slot = "0")]
	public override bool Equals(object GHDJADLHPAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CAF0", Offset = "0x1F8B2F0", VA = "0x181F8CAF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CB50", Offset = "0x1F8B350", VA = "0x181F8CB50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1F8CAA0", Offset = "0x1F8B2A0", VA = "0x181F8CAA0", Slot = "5")]
	private bool PAABLEIFDHG([In] IFMODNOJONE OGFCKBADKBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public sealed class NMFNDEFCNKL : BDBDEKNDPBG
{
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "8")]
	public override void HCPJIHHHNJF(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, OKHLIJCALEC ICLKOKIEPPK, KPFGDODNFBO<PGLFCGKLJFG.DGDPOBOLHHK>? HHFHLNABMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "9")]
	public override void EAECLOKGNBC(EPLGAHDLMCC BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1F845D0", Offset = "0x1F82DD0", VA = "0x181F845D0")]
	public NMFNDEFCNKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public struct CGJPJKNKLNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public PEOPJNDHKBL<GHBFIOLFDBB, HCBLDGAKHKC> MMNFKFIIMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public NNJCIDIHBNF<ALFODNACFEO.AJCCPDIFNAC> IICKNEPINCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public PEOPJNDHKBL<ALFODNACFEO.AJCCPDIFNAC, ALFODNACFEO.JHBIMAJOCBB> BOCDGNFDFPB;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1F84500", Offset = "0x1F82D00", VA = "0x181F84500")]
	private CGJPJKNKLNL([In] PEOPJNDHKBL<GHBFIOLFDBB, HCBLDGAKHKC> NILPHENHLFH, [In] NNJCIDIHBNF<ALFODNACFEO.AJCCPDIFNAC> KLPHMJKHGJD, [In] PEOPJNDHKBL<ALFODNACFEO.AJCCPDIFNAC, ALFODNACFEO.JHBIMAJOCBB> HCAFOGBADDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1F85720", Offset = "0x1F83F20", VA = "0x181F85720")]
	public static CGJPJKNKLNL OJFFIHPLODM()
	{
		return default(CGJPJKNKLNL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1F84470", Offset = "0x1F82C70", VA = "0x181F84470")]
	public static CGJPJKNKLNL PMGDHNKMLHE([In] PEOPJNDHKBL<GHBFIOLFDBB, HCBLDGAKHKC> NILPHENHLFH, [In] NNJCIDIHBNF<ALFODNACFEO.AJCCPDIFNAC> KLPHMJKHGJD, [In] PEOPJNDHKBL<ALFODNACFEO.AJCCPDIFNAC, ALFODNACFEO.JHBIMAJOCBB> HCAFOGBADDK)
	{
		return default(CGJPJKNKLNL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public static class DJANFFODOJD
{
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1F86360", Offset = "0x1F84B60", VA = "0x181F86360")]
	public static void PGFGBHFCFEG(this CGJPJKNKLNL EGJINJKGIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct AODLCFBMMLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	public PEOPJNDHKBL<GPCAGFNHADK, CGJPJKNKLNL> DCDNIOLCHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public NNJCIDIHBNF<NFLGKJNAJEM.AGFAGBCDPGG> BBLAHELJCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public PEOPJNDHKBL<NFLGKJNAJEM.AGFAGBCDPGG, NFLGKJNAJEM.OLAAGDDIHIL> KMPMNCONAFL;

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F84500", Offset = "0x1F82D00", VA = "0x181F84500")]
	private AODLCFBMMLO([In] PEOPJNDHKBL<GPCAGFNHADK, CGJPJKNKLNL> BFMOHBHIKHF, [In] NNJCIDIHBNF<NFLGKJNAJEM.AGFAGBCDPGG> BNCKADMKOMB, [In] PEOPJNDHKBL<NFLGKJNAJEM.AGFAGBCDPGG, NFLGKJNAJEM.OLAAGDDIHIL> GEIFFKFNGAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1F84470", Offset = "0x1F82C70", VA = "0x181F84470")]
	public static AODLCFBMMLO PMGDHNKMLHE([In] PEOPJNDHKBL<GPCAGFNHADK, CGJPJKNKLNL> BFMOHBHIKHF, [In] NNJCIDIHBNF<NFLGKJNAJEM.AGFAGBCDPGG> BNCKADMKOMB, [In] PEOPJNDHKBL<NFLGKJNAJEM.AGFAGBCDPGG, NFLGKJNAJEM.OLAAGDDIHIL> GEIFFKFNGAJ)
	{
		return default(AODLCFBMMLO);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class FNINAAOBMGI
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1F89730", Offset = "0x1F87F30", VA = "0x181F89730")]
	public static void PGFGBHFCFEG(this AODLCFBMMLO EGJINJKGIAK, [In] HMLPMLHKKOJ MPBAPALKIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1F895F0", Offset = "0x1F87DF0", VA = "0x181F895F0")]
	public static void GGEAEMAJLHK(this AODLCFBMMLO EGJINJKGIAK, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, [In] CGJPJKNKLNL NCNAHELFBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x1F893B0", Offset = "0x1F87BB0", VA = "0x181F893B0")]
	public static void CHEAPHHCLBO(this AODLCFBMMLO EGJINJKGIAK, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, [In] HMLPMLHKKOJ MPBAPALKIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x1F89650", Offset = "0x1F87E50", VA = "0x181F89650")]
	public static CGJPJKNKLNL NBGKOOJKKKA([In] this AODLCFBMMLO EGJINJKGIAK, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM)
	{
		return default(CGJPJKNKLNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x1F896C0", Offset = "0x1F87EC0", VA = "0x181F896C0")]
	public static CGJPJKNKLNL NNHFKLOCKDB(this AODLCFBMMLO EGJINJKGIAK, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM)
	{
		return default(CGJPJKNKLNL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class KMFOLMFLAMK : JIGKGLOHCNN<KMFOLMFLAMK, EPLGAHDLMCC>
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x1F90270", Offset = "0x1F8EA70", VA = "0x181F90270")]
	private KMFOLMFLAMK([In] DPKMCLCFMEL<DNFJKNPMMBK, CAFHBJAALAB<EPLGAHDLMCC>> PMLBHPHOBBP, [In] DPKMCLCFMEL<DEHBGIDHIKL, EFIIICFJLEM<EPLGAHDLMCC>> GFGEDNBAILD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x1F901A0", Offset = "0x1F8E9A0", VA = "0x181F901A0")]
	public static KMFOLMFLAMK OJFFIHPLODM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x1F90120", Offset = "0x1F8E920", VA = "0x181F90120")]
	public new (CCPKKOHIOOB<DNFJKNPMMBK, CAFHBJAALAB<EPLGAHDLMCC>>, CCPKKOHIOOB<DEHBGIDHIKL, EFIIICFJLEM<EPLGAHDLMCC>>) GIKLILNBKHF()
	{
		return default((CCPKKOHIOOB<DNFJKNPMMBK, CAFHBJAALAB<EPLGAHDLMCC>>, CCPKKOHIOOB<DEHBGIDHIKL, EFIIICFJLEM<EPLGAHDLMCC>>));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public sealed class MIHJJDIKIPK : APMPPMKJADO
{
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x1F915F0", Offset = "0x1F8FDF0", VA = "0x181F915F0", Slot = "7")]
	public override string ILHCPMBLOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x1F91620", Offset = "0x1F8FE20", VA = "0x181F91620")]
	public MIHJJDIKIPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public interface PFHKOKHNBAM
{
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<MEKCEIEFNPI<object, MNGIPKBLGNG>> GLFCEICCAAA(FFPCMKOBEGP BMOCGPMNBAF, bool IFCNCLOFHHB);
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
