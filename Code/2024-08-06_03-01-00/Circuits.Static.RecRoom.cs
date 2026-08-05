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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2029A70", Offset = "0x2028070", VA = "0x182029A70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EAHHCEFLNCP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2018180", Offset = "0x2016780", VA = "0x182018180")]
	public static bool OJGCEFKMBJF(this GICCCEAPIAH BDKLEMDNAFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2018290", Offset = "0x2016890", VA = "0x182018290")]
	public static bool OJGCEFKMBJF(this BFNIDFDKBAA AHGIDGJLIID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BAMIBLDLIFB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	OAHGPIOPPPG? ONOIPMEKDOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class MHEMBFHPIJB
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2027EB0", Offset = "0x20264B0", VA = "0x182027EB0")]
	internal static FCGFBJAACMM ONOIPMEKDOO(this BAMIBLDLIFB ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2027D00", Offset = "0x2026300", VA = "0x182027D00")]
	internal static HHANDHIMCMH<FCGFBJAACMM, OADMEHLBNPF> CMIKILFPOIG(this BAMIBLDLIFB ELMHNMGFNPC)
	{
		return default(HHANDHIMCMH<FCGFBJAACMM, OADMEHLBNPF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct OAHGPIOPPPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly FCGFBJAACMM ONOIPMEKDOO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
	public OAHGPIOPPPG(FCGFBJAACMM MEHMFCJKDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class COPPFPONBLN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2972660", Offset = "0x2970C60", VA = "0x182972660")]
	public static FAMFIOJDPLD<JJIHKNDFLHA, HAFPKGJPPHJ, TRoot, FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, TRoot>> BKEBOICMMOA<TRoot>([In] this FAMFIOJDPLD<JJIHKNDFLHA, HAFPKGJPPHJ, TRoot, FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, TRoot>> DPMNBGOPPCB) where TRoot : BAMIBLDLIFB
	{
		return default(FAMFIOJDPLD<JJIHKNDFLHA, HAFPKGJPPHJ, TRoot, FJIABIJAMOG.ANPLOJEBKIM<JJIHKNDFLHA, HAFPKGJPPHJ, TRoot>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct AKOENAINMMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct GLEKHDIGHHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly HNOLJOFDEMA JOLLNFAPIOJ;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA150A0", Offset = "0xA136A0", VA = "0x180A150A0")]
		public GLEKHDIGHHA(HNOLJOFDEMA GBBOEICPBMP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct DINFCLPGJAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public EJDMOINMPCI<PPNKDIOKKPB> POIJDCGIDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public EJDMOINMPCI<PPNKDIOKKPB> JAFMCIHNIEH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2016750", Offset = "0x2014D50", VA = "0x182016750")]
		public static DINFCLPGJAN NKOJKFHACJH(AIOBDGBPBIA<FCGFBJAACMM> CDGBAHFNDFG)
		{
			return default(DINFCLPGJAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct KPFGALFGIMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public EJDMOINMPCI<JLGGEKEAIFI> EHILODGCFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public EJDMOINMPCI<JLGGEKEAIFI> LNCOFPCBEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public EJDMOINMPCI<JLGGEKEAIFI> PCCAPGJADME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public EJDMOINMPCI<JLGGEKEAIFI> LLAADIKILAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EJDMOINMPCI<JLGGEKEAIFI> HOKJKPKFGFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public EJDMOINMPCI<JLGGEKEAIFI> MLHEADNKNFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public EJDMOINMPCI<JLGGEKEAIFI> CIOOLAHHKEE;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2021260", Offset = "0x201F860", VA = "0x182021260")]
		public static KPFGALFGIMM NKOJKFHACJH(IGBCFIBFFOH<FCGFBJAACMM> CDGBAHFNDFG)
		{
			return default(KPFGALFGIMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class DOIPNHIIFAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static Dictionary<EJDMOINMPCI<HEGJNECALAJ>, HJGNBGGFGJK> BEBIPDCGCGE;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> GPPCJKAAKNA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> PMKJKHNFPFF;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> ANPMKFPEFDL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> JADEEIKDJHJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> JENFKFJPCOK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> BILCJHFGHEC;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> JNHBNFCGDLK;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> EAMKAEILBMI;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> CBJJLFDEAIN;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> ECNAABDFEHK;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> JJIIJBOFMIG;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> LLFJJELGPAP;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> PBAKIDIFLEP;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> BMKCABFNHIF;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> OLDMCBCBLKP;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> LNFHIOPEBLD;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> LPEMKGKCNPI;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> PPDKBFABAEK;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> GBANCEHKBJJ;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> ANEGDIPHMIG;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> AECANMAHHLD;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> OIOKOAFHKNN;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> FOLINCDBGPD;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> PCOFIPABCEG;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> HEGGMEAFJJO;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> OKNLFPFOHNF;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> ELFJAKJMONL;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> MBPHGDMFCDD;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> LFGMOEEJDOG;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> IBGEKHAOMLL;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> CAJFPLOCGMH;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> FBKMNPGBAAK;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> DNEGKLLEHAN;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> JNMLELPNPCD;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> GKNHKBJGIMM;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> BHLMJNNHNDC;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> MHDOMGDMJLG;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> BNEAENBPAAM;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> HMJONFDJLKC;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> LPCAFJOPCBL;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> NOIBGOMHCNL;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> INFLKFEIDGP;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> DGAOEPBPEFD;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> LPHHFKBHJHP;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> KDNGDCPMKKJ;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> MMLKEBMALDH;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> PBAABPCLOBA;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> HNKJOHCLHDO;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> BMLFMLCNJML;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> PEKIJDKHMKF;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> FLMNGJEBDLB;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> BGNLMNOCNOG;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> LDHNACJLHDH;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> LADFDCMKLJK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> MPOFHFDDICO;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> BKBIKJMDOOM;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly EJDMOINMPCI<HEGJNECALAJ> OLBEBLKIKCK;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2016E90", Offset = "0x2015490", VA = "0x182016E90")]
		public static HJGNBGGFGJK HMIKDOHBINE(EJDMOINMPCI<HEGJNECALAJ> KAGKMEDPMHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2016F10", Offset = "0x2015510", VA = "0x182016F10")]
		public static bool KCAFCEOHCJE(EJDMOINMPCI<HEGJNECALAJ> KAGKMEDPMHO, [Out] HJGNBGGFGJK BHGNEDFIBBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2016DE0", Offset = "0x20153E0", VA = "0x182016DE0")]
		public static GICCCEAPIAH HAHCCHPMDKO(EJDMOINMPCI<HEGJNECALAJ> KAGKMEDPMHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2016FA0", Offset = "0x20155A0", VA = "0x182016FA0")]
		private static EJDMOINMPCI<HEGJNECALAJ> OOMCOBOGONK(HJGNBGGFGJK BHGNEDFIBBN, EJDMOINMPCI<HEGJNECALAJ> KAGKMEDPMHO)
		{
			return default(EJDMOINMPCI<HEGJNECALAJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class OKONOGBNHJG
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class KMJPKDMCKKH : IEnumerable<GICCCEAPIAH>, IEnumerable, IEnumerator<GICCCEAPIAH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private GICCCEAPIAH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private NPEPNAJEPGP roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public NPEPNAJEPGP <>3__roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private bool <r1>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool <r2>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000065")]
			private GICCCEAPIAH System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008E")]
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8A8AC0", Offset = "0x8A70C0", VA = "0x1808A8AC0")]
			[DebuggerHidden]
			public KMJPKDMCKKH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x201F9C0", Offset = "0x201DFC0", VA = "0x18201F9C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2021210", Offset = "0x201F810", VA = "0x182021210", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x2021160", Offset = "0x201F760", VA = "0x182021160", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GICCCEAPIAH> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x2021160", Offset = "0x201F760", VA = "0x182021160", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class HKNLEINCCKO : IEnumerable<GICCCEAPIAH>, IEnumerable, IEnumerator<GICCCEAPIAH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private GICCCEAPIAH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private bool includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public bool <>3__includeExec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NPEPNAJEPGP roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public NPEPNAJEPGP <>3__roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private bool includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public bool <>3__includeBeta;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private bool includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public bool <>3__includeStudio;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private bool isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public bool <>3__isDeveloper;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private IEnumerator<GICCCEAPIAH> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private GICCCEAPIAH <circuitType>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			private GICCCEAPIAH System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000068")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8A8AC0", Offset = "0x8A70C0", VA = "0x1808A8AC0")]
			[DebuggerHidden]
			public HKNLEINCCKO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x201F1D0", Offset = "0x201D7D0", VA = "0x18201F1D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x201EB80", Offset = "0x201D180", VA = "0x18201EB80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x201F070", Offset = "0x201D670", VA = "0x18201F070")]
			private void OGHBNIPNCAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x201F180", Offset = "0x201D780", VA = "0x18201F180", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x201F0C0", Offset = "0x201D6C0", VA = "0x18201F0C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<GICCCEAPIAH> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x201F0C0", Offset = "0x201D6C0", VA = "0x18201F0C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly BFNIDFDKBAA MLEOHFHPGLK;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly BFNIDFDKBAA FEMBIDEIHNE;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static readonly HashSet<GICCCEAPIAH> GBAEOPCIGJO;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static List<GICCCEAPIAH> PGJODIIDFMN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static BJNALGALMHE OPOMDCBCKGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9A2250", Offset = "0x9A0850", VA = "0x1809A2250")]
			get
			{
				return default(BJNALGALMHE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static GICCCEAPIAH DJEPCGADJJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x202BE20", Offset = "0x202A420", VA = "0x18202BE20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static GICCCEAPIAH FGGGBLMLOLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x202C390", Offset = "0x202A990", VA = "0x18202C390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static GICCCEAPIAH NEHDAFCDPCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x202A6C0", Offset = "0x2028CC0", VA = "0x18202A6C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static GICCCEAPIAH BHPODAPKFPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x202AA00", Offset = "0x2029000", VA = "0x18202AA00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static GICCCEAPIAH GNPHNKEOGAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x202AAE0", Offset = "0x20290E0", VA = "0x18202AAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static GICCCEAPIAH OFABGODLFCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x202BCA0", Offset = "0x202A2A0", VA = "0x18202BCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static GICCCEAPIAH OFEGMDKPAMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x202AB70", Offset = "0x2029170", VA = "0x18202AB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static GICCCEAPIAH PLFKCLCJAIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x202C080", Offset = "0x202A680", VA = "0x18202C080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static FEPOMFENLLL PLEPENAKNOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x202BF50", Offset = "0x202A550", VA = "0x18202BF50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static FEPOMFENLLL KGIMOBCHJKI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x202C790", Offset = "0x202AD90", VA = "0x18202C790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static FEPOMFENLLL MDOLGCOMIEF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x202ACA0", Offset = "0x20292A0", VA = "0x18202ACA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static FEPOMFENLLL IGPBPFHMCIG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x202C6F0", Offset = "0x202ACF0", VA = "0x18202C6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static FEPOMFENLLL APAEIACBADE
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x202CB00", Offset = "0x202B100", VA = "0x18202CB00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static FEPOMFENLLL OCLDMJLFPNI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x202A5D0", Offset = "0x2028BD0", VA = "0x18202A5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static FEPOMFENLLL AAIPDHBKNEE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x202CD80", Offset = "0x202B380", VA = "0x18202CD80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static FEPOMFENLLL FPJDIADOOPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x202AD90", Offset = "0x2029390", VA = "0x18202AD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static FEPOMFENLLL HIOIIBIOAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x202ACF0", Offset = "0x20292F0", VA = "0x18202ACF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static FEPOMFENLLL JCEJLALHPPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x202C340", Offset = "0x202A940", VA = "0x18202C340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static FEPOMFENLLL NMLNPLMCIKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x202CD30", Offset = "0x202B330", VA = "0x18202CD30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static FEPOMFENLLL CBNFINDLDLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x202C250", Offset = "0x202A850", VA = "0x18202C250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static FEPOMFENLLL KGKPPKJAEPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x202B610", Offset = "0x2029C10", VA = "0x18202B610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static FEPOMFENLLL ONLEKNIINGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x202CAB0", Offset = "0x202B0B0", VA = "0x18202CAB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static FEPOMFENLLL KIFHFGPIINO
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x202A4D0", Offset = "0x2028AD0", VA = "0x18202A4D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static FEPOMFENLLL IFJMIDKADBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x202C600", Offset = "0x202AC00", VA = "0x18202C600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static FEPOMFENLLL JGKMGAINGFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x202CB50", Offset = "0x202B150", VA = "0x18202CB50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static FEPOMFENLLL ABFHFLHOAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x202C970", Offset = "0x202AF70", VA = "0x18202C970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static FEPOMFENLLL FFNFOOMNHFH
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x202AC50", Offset = "0x2029250", VA = "0x18202AC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static FEPOMFENLLL PGPMAPHCJCN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x202B700", Offset = "0x2029D00", VA = "0x18202B700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static FEPOMFENLLL AAEGMBDLFMD
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x202B5C0", Offset = "0x2029BC0", VA = "0x18202B5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static FEPOMFENLLL BNMELBKJHMA
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x202C740", Offset = "0x202AD40", VA = "0x18202C740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static FEPOMFENLLL GGAMPJPAJJE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x202B1C0", Offset = "0x20297C0", VA = "0x18202B1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static FEPOMFENLLL NJPPIDCCFPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x202AC00", Offset = "0x2029200", VA = "0x18202AC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static FEPOMFENLLL BNJDKJKHHNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x202C110", Offset = "0x202A710", VA = "0x18202C110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static FEPOMFENLLL NCPCAPCEIPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x202BC00", Offset = "0x202A200", VA = "0x18202BC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static FEPOMFENLLL HMILMFPIEDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x202B6B0", Offset = "0x2029CB0", VA = "0x18202B6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static FEPOMFENLLL NFKPDDJIBMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x202B7F0", Offset = "0x2029DF0", VA = "0x18202B7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static FEPOMFENLLL MANFJFDDKGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x202B7A0", Offset = "0x2029DA0", VA = "0x18202B7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static FEPOMFENLLL LHCGKFPLJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x202B170", Offset = "0x2029770", VA = "0x18202B170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static FEPOMFENLLL NHIBNGFBOBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x202AF10", Offset = "0x2029510", VA = "0x18202AF10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static FEPOMFENLLL INBIEGJLKIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x202C920", Offset = "0x202AF20", VA = "0x18202C920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static FEPOMFENLLL FDMLBEMODMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x202C1B0", Offset = "0x202A7B0", VA = "0x18202C1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static FEPOMFENLLL FCDNJECBCGB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x202AFB0", Offset = "0x20295B0", VA = "0x18202AFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static FEPOMFENLLL MCEGNHFCBJN
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x202CC40", Offset = "0x202B240", VA = "0x18202CC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static FEPOMFENLLL OJJOGGIHLEL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x202B340", Offset = "0x2029940", VA = "0x18202B340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public static FEPOMFENLLL IOMNIJAGNAB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x202C650", Offset = "0x202AC50", VA = "0x18202C650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public static FEPOMFENLLL KIMGMBONDCH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x202B930", Offset = "0x2029F30", VA = "0x18202B930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static FEPOMFENLLL NEFBABJOCAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x202BC50", Offset = "0x202A250", VA = "0x18202BC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static FEPOMFENLLL FGOMEKMENOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x202AEC0", Offset = "0x20294C0", VA = "0x18202AEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static FEPOMFENLLL BCMHDPCEECJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x202C4C0", Offset = "0x202AAC0", VA = "0x18202C4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public static FEPOMFENLLL NGFOOHEMABC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x202B9D0", Offset = "0x2029FD0", VA = "0x18202B9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static FEPOMFENLLL MGMHPLDPCAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x202B430", Offset = "0x2029A30", VA = "0x18202B430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public static FEPOMFENLLL DDILIJHMFNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x202B3E0", Offset = "0x20299E0", VA = "0x18202B3E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static FEPOMFENLLL MCDKFGFLFAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x202AF60", Offset = "0x2029560", VA = "0x18202AF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static FEPOMFENLLL JNPAPMEEOKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x202B980", Offset = "0x2029F80", VA = "0x18202B980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static FEPOMFENLLL LJLCMBIFMMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x202C560", Offset = "0x202AB60", VA = "0x18202C560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static FEPOMFENLLL DCFNOCJJLFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x202C420", Offset = "0x202AA20", VA = "0x18202C420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public static FEPOMFENLLL KNDKCGKFADK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x202B120", Offset = "0x2029720", VA = "0x18202B120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static FEPOMFENLLL ANOKAOONFDN
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x202C2F0", Offset = "0x202A8F0", VA = "0x18202C2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static FEPOMFENLLL HBLMILIMMHM
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x202B000", Offset = "0x2029600", VA = "0x18202B000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static FEPOMFENLLL LCPFAMHAJIB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x202C200", Offset = "0x202A800", VA = "0x18202C200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public static FEPOMFENLLL LENMICCEJKB
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x202C8D0", Offset = "0x202AED0", VA = "0x18202C8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static FEPOMFENLLL LGDGPPNIMCA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x202C5B0", Offset = "0x202ABB0", VA = "0x18202C5B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static FEPOMFENLLL BMDHFHKANEE
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x202BD30", Offset = "0x202A330", VA = "0x18202BD30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public static FEPOMFENLLL PEBPMDLMCFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x202AA90", Offset = "0x2029090", VA = "0x18202AA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static FEPOMFENLLL PABJFLACCJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x202C2A0", Offset = "0x202A8A0", VA = "0x18202C2A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public static FEPOMFENLLL AKICOECDDIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x202CC90", Offset = "0x202B290", VA = "0x18202CC90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static FEPOMFENLLL PBOEMHAAJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x202B890", Offset = "0x2029E90", VA = "0x18202B890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static FEPOMFENLLL GNGAGKKEHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x202C830", Offset = "0x202AE30", VA = "0x18202C830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public static FEPOMFENLLL OMICHDIDLLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x202B0A0", Offset = "0x20296A0", VA = "0x18202B0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public static FEPOMFENLLL DJPFALEDIGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x202C9C0", Offset = "0x202AFC0", VA = "0x18202C9C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public static FEPOMFENLLL KJECJKGDMAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x202BDD0", Offset = "0x202A3D0", VA = "0x18202BDD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public static FEPOMFENLLL NGAEGEKDOGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x202CA10", Offset = "0x202B010", VA = "0x18202CA10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static FEPOMFENLLL NNDPFNBLHKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x202B660", Offset = "0x2029C60", VA = "0x18202B660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public static FEPOMFENLLL FPDKBBNGBPH
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x202B750", Offset = "0x2029D50", VA = "0x18202B750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public static FEPOMFENLLL JBEDIAGMGMM
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x202C7E0", Offset = "0x202ADE0", VA = "0x18202C7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public static FEPOMFENLLL IJLNIABHKMB
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x202B390", Offset = "0x2029990", VA = "0x18202B390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public static FEPOMFENLLL CMNHFJKACLC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x202AD40", Offset = "0x2029340", VA = "0x18202AD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static FEPOMFENLLL OKNDNBEOHML
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x202BBB0", Offset = "0x202A1B0", VA = "0x18202BBB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static FEPOMFENLLL DHHFNAHMEPM
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x202C470", Offset = "0x202AA70", VA = "0x18202C470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static FEPOMFENLLL FMJEAEFBDAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x202BD80", Offset = "0x202A380", VA = "0x18202BD80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static FEPOMFENLLL AHMFBMLLBJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x202B050", Offset = "0x2029650", VA = "0x18202B050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static FEPOMFENLLL MKNPMCCCFDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x202B570", Offset = "0x2029B70", VA = "0x18202B570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static FEPOMFENLLL ECKGAGJOEFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x202B8E0", Offset = "0x2029EE0", VA = "0x18202B8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static FEPOMFENLLL AEEEHOADOBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x202CBF0", Offset = "0x202B1F0", VA = "0x18202CBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static FEPOMFENLLL GBAGDLEFMNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x202CA60", Offset = "0x202B060", VA = "0x18202CA60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static FEPOMFENLLL OECJJDBDECA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x202B840", Offset = "0x2029E40", VA = "0x18202B840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static FEPOMFENLLL JJEIGCPPHMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x202A9B0", Offset = "0x2028FB0", VA = "0x18202A9B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public static FEPOMFENLLL BPEHKJIIOMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x202C6A0", Offset = "0x202ACA0", VA = "0x18202C6A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public static FEPOMFENLLL LLHHIFPNPFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x202BEB0", Offset = "0x202A4B0", VA = "0x18202BEB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public static FEPOMFENLLL FGFPPLPEHDL
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x202BF00", Offset = "0x202A500", VA = "0x18202BF00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public static FEPOMFENLLL DJLDGEIKKBM
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x202CBA0", Offset = "0x202B1A0", VA = "0x18202CBA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static FEPOMFENLLL CLIIHLNAOPL
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x202C880", Offset = "0x202AE80", VA = "0x18202C880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public static FEPOMFENLLL NNDJCMIAHPA
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x202CCE0", Offset = "0x202B2E0", VA = "0x18202CCE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public static FEPOMFENLLL CKLJJMFFELE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x202C510", Offset = "0x202AB10", VA = "0x18202C510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public static FEPOMFENLLL DLBNEPBBODM
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x202A620", Offset = "0x2028C20", VA = "0x18202A620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public static FEPOMFENLLL DAFKDMFDPCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x202C160", Offset = "0x202A760", VA = "0x18202C160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static FEPOMFENLLL EKFIJEFKMEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x202A670", Offset = "0x2028C70", VA = "0x18202A670")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public static FEPOMFENLLL MOJOIFEMKPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x202A480", Offset = "0x2028A80", VA = "0x18202A480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x202B480", Offset = "0x2029A80", VA = "0x18202B480")]
		public static BFNIDFDKBAA ENFPBOFANJI([In] LJIIHMMOGOI NMFJIPPDPCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x202AE10", Offset = "0x2029410", VA = "0x18202AE10")]
		public static HHOHPOBMBPL CIBNKECCLDC(string KAGKMEDPMHO, [Optional] string LGJDNDBECCI)
		{
			return default(HHOHPOBMBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x202ADE0", Offset = "0x20293E0", VA = "0x18202ADE0")]
		public static HHOHPOBMBPL CIBNKECCLDC([Optional][In] Guid? KAGKMEDPMHO, [Optional] string LGJDNDBECCI)
		{
			return default(HHOHPOBMBPL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x202C050", Offset = "0x202A650", VA = "0x18202C050")]
		public static BFNIDFDKBAA IAELGFOJPCP(params LJIIHMMOGOI[] NPALJOOCNBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x202B0F0", Offset = "0x20296F0", VA = "0x18202B0F0")]
		public static BFNIDFDKBAA DNELCMEIMDD(params LJIIHMMOGOI[] NPALJOOCNBD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x202B210", Offset = "0x2029810", VA = "0x18202B210")]
		public static BFNIDFDKBAA EJOGFCLECIE([In] LJIIHMMOGOI NMFJIPPDPCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x202CDD0", Offset = "0x202B3D0", VA = "0x18202CDD0")]
		static OKONOGBNHJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x202BFA0", Offset = "0x202A5A0", VA = "0x18202BFA0")]
		[IteratorStateMachine(typeof(KMJPKDMCKKH))]
		private static IEnumerable<GICCCEAPIAH> HOKOJHALEID(NPEPNAJEPGP OEAKAPPLKCC, bool HMDAELIENNL, bool OIMOLCBFDMH, bool DMEGLHBKJIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x202A520", Offset = "0x2028B20", VA = "0x18202A520")]
		[IteratorStateMachine(typeof(HKNLEINCCKO))]
		public static IEnumerable<GICCCEAPIAH> AKKFDALIFHG(NPEPNAJEPGP OEAKAPPLKCC, bool FDAJKGKDBKO, bool HMDAELIENNL, bool OIMOLCBFDMH, bool DMEGLHBKJIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x202BA20", Offset = "0x202A020", VA = "0x18202BA20")]
		public static BFKABKCMACF GPOGAOOHBPI(GICCCEAPIAH BDKLEMDNAFL)
		{
			return default(BFKABKCMACF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x202A7D0", Offset = "0x2028DD0", VA = "0x18202A7D0")]
		public static BFKABKCMACF BCODLANNCLG(GICCCEAPIAH BDKLEMDNAFL)
		{
			return default(BFKABKCMACF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x202A750", Offset = "0x2028D50", VA = "0x18202A750")]
		public static bool BCEFJMLPAOO(GICCCEAPIAH BDKLEMDNAFL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly KPFGALFGIMM JFNMFCIEBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly DINFCLPGJAN IEKNCEFIFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly JCKMAGOBPCF<JLGGEKEAIFI, EFLGBOKOFAJ<FCGFBJAACMM>> OOKCHELIHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JCKMAGOBPCF<PPNKDIOKKPB, EDJLMOLODMH<FCGFBJAACMM>> PBOMCEMMLAB;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2015740", Offset = "0x2013D40", VA = "0x182015740")]
	private AKOENAINMMA([In] KPFGALFGIMM CEDAEKHJCNP, [In] DINFCLPGJAN CPBPKPIOCJB, JCKMAGOBPCF<JLGGEKEAIFI, EFLGBOKOFAJ<FCGFBJAACMM>> HHNOJBFLNGF, JCKMAGOBPCF<PPNKDIOKKPB, EDJLMOLODMH<FCGFBJAACMM>> CADLDAMHLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x20155C0", Offset = "0x2013BC0", VA = "0x1820155C0")]
	public static AKOENAINMMA NKOJKFHACJH()
	{
		return default(AKOENAINMMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2014FE0", Offset = "0x20135E0", VA = "0x182014FE0")]
	public static void AMMOOILDICF([In] AKOENAINMMA ELMHNMGFNPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2015420", Offset = "0x2013A20", VA = "0x182015420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2014F00", Offset = "0x2013500", VA = "0x182014F00")]
	public static IJCLBOHFDPL<FCGFBJAACMM> AFCAAKNAPJK([In] AKOENAINMMA ELMHNMGFNPC, [In] ODKJEIKNABL HBJLBBPBJEE, [In] KCFKDAEGJHH AHEPDODLBJC)
	{
		return default(IJCLBOHFDPL<FCGFBJAACMM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2015430", Offset = "0x2013A30", VA = "0x182015430")]
	public static FCGFBJAACMM ICGFAEJAILD([In] AKOENAINMMA ELMHNMGFNPC, [In] EAIHJFJBHEP OKCJGMIPNFK, [In] IJCLBOHFDPL<FCGFBJAACMM> PMCDBPBJKDB, [In] JGDFJNPJECI DBDLDJCHFAF, EJDMOINMPCI<ALFNFGCIOCL> LPFGNMGMHKA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class FCGFBJAACMM : KPNCFAGJHAO, CBJENDFAIHA<FCGFBJAACMM>, CPKJNNJEPCJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly AKOENAINMMA NHNADLCGJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private EAIHJFJBHEP EOGDHFHPOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private IJCLBOHFDPL<FCGFBJAACMM> MMODEJODMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private JGDFJNPJECI OKDMGDFFOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> CPHACPONPAK;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x201D180", Offset = "0x201B780", VA = "0x18201D180")]
	private FCGFBJAACMM([In] AKOENAINMMA KMNGIDIHGLH, [In] EAIHJFJBHEP OCEOFDCIBPH, [In] IJCLBOHFDPL<FCGFBJAACMM> PMCDBPBJKDB, [In] JGDFJNPJECI DBDLDJCHFAF, EJDMOINMPCI<ALFNFGCIOCL> EHMACDECLFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2015430", Offset = "0x2013A30", VA = "0x182015430")]
	public static FCGFBJAACMM HBHGEDOCEKN([In] AKOENAINMMA KMNGIDIHGLH, [In] EAIHJFJBHEP OCEOFDCIBPH, [In] IJCLBOHFDPL<FCGFBJAACMM> PMCDBPBJKDB, [In] JGDFJNPJECI DBDLDJCHFAF, EJDMOINMPCI<ALFNFGCIOCL> EHMACDECLFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x201AED0", Offset = "0x20194D0", VA = "0x18201AED0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF75B0", Offset = "0x1FF5BB0", VA = "0x181FF75B0", Slot = "8")]
	public IJCLBOHFDPL<FCGFBJAACMM> DKAHABIOINB()
	{
		return default(IJCLBOHFDPL<FCGFBJAACMM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1FF75C0", Offset = "0x1FF5BC0", VA = "0x181FF75C0")]
	public EAIHJFJBHEP LJCEPHALIAB()
	{
		return default(EAIHJFJBHEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C430", Offset = "0x2B4AA30", VA = "0x182B4C430")]
	public EJDMOINMPCI<TMVirt> GKPKEHIJEKP<TMVirt>(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA) where TMVirt : ELEKHEFGCEB.PFGCOJFMLLD
	{
		return default(EJDMOINMPCI<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C360", Offset = "0x2B4A960", VA = "0x182B4C360")]
	public EJDMOINMPCI<TMVirt> FPABLGKMGJL<TMVirt>(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN) where TMVirt : ACCHELCNMEE.ABLLFBGGGLE
	{
		return default(EJDMOINMPCI<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x201BDA0", Offset = "0x201A3A0", VA = "0x18201BDA0")]
	internal ODKJEIKNABL HNIMLBJPGIE()
	{
		return default(ODKJEIKNABL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x201AE00", Offset = "0x2019400", VA = "0x18201AE00")]
	internal KCFKDAEGJHH BMMCKODOFFH()
	{
		return default(KCFKDAEGJHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1FF75B0", Offset = "0x1FF5BB0", VA = "0x181FF75B0")]
	internal IJCLBOHFDPL<FCGFBJAACMM> IIOOJKCAOAG()
	{
		return default(IJCLBOHFDPL<FCGFBJAACMM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1FF75C0", Offset = "0x1FF5BC0", VA = "0x181FF75C0")]
	internal EAIHJFJBHEP CDCDCKOJILA()
	{
		return default(EAIHJFJBHEP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x201B0E0", Offset = "0x20196E0", VA = "0x18201B0E0")]
	internal JGDFJNPJECI EJAHAMNCOMP()
	{
		return default(JGDFJNPJECI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C4C0", Offset = "0x2B4AAC0", VA = "0x182B4C4C0")]
	public void JGJOFMCGIHN<TMVirt>(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<TMVirt> PCJCGAPEBAG) where TMVirt : ELEKHEFGCEB.PFGCOJFMLLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C290", Offset = "0x2B4A890", VA = "0x182B4C290")]
	public void AJICOMEPKGA<TMVirt>(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<TMVirt> PCJCGAPEBAG) where TMVirt : ACCHELCNMEE.ABLLFBGGGLE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x201BDE0", Offset = "0x201A3E0", VA = "0x18201BDE0", Slot = "9")]
	public HOOGKFLMCLH IKMEMPGFCIL()
	{
		return default(HOOGKFLMCLH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x201D060", Offset = "0x201B660", VA = "0x18201D060", Slot = "10")]
	public BFKABKCMACF OPCEPFOPEDH(GICCCEAPIAH BDKLEMDNAFL)
	{
		return default(BFKABKCMACF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x201D0D0", Offset = "0x201B6D0", VA = "0x18201D0D0", Slot = "11")]
	public bool PCBDOLONHJN(GICCCEAPIAH BDKLEMDNAFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x201B160", Offset = "0x2019760", VA = "0x18201B160", Slot = "4")]
	private void HFDCNBJPOKA(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, CNFHBOBFJOE IHBFJIMCLJM, EJDMOINMPCI<GIMMNEHHJNK.ADGGLOKLALF>? NFOMBBGNLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x201AD60", Offset = "0x2019360", VA = "0x18201AD60", Slot = "5")]
	private void AMHBGCBKJIJ(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x201BF20", Offset = "0x201A520", VA = "0x18201BF20", Slot = "6")]
	private void LAHHIDCGEFF(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, CNFHBOBFJOE IHBFJIMCLJM, EJDMOINMPCI<GIMMNEHHJNK.ADGGLOKLALF>? NFOMBBGNLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x201B0F0", Offset = "0x20196F0", VA = "0x18201B0F0", Slot = "7")]
	private void EOHDBMBAEBL(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x201AF50", Offset = "0x2019550", VA = "0x18201AF50")]
	internal HHANDHIMCMH<EJDMOINMPCI<KNLAPOPPMHG>, LPFOGJHKMBP> EHILODGCFLP(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JLGGEKEAIFI> FPJBJDENJHB, [In] CBFBKLHLCNM JICIEEKFCFC, [In] FDHJIELJJFD GNOMFELINLB, CNFHBOBFJOE LHLIOKHLMKF, EJDMOINMPCI<GIMMNEHHJNK.ADGGLOKLALF>? GMACPHGFPBB)
	{
		return default(HHANDHIMCMH<EJDMOINMPCI<KNLAPOPPMHG>, LPFOGJHKMBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x201BE20", Offset = "0x201A420", VA = "0x18201BE20")]
	internal EJDMOINMPCI<KNLAPOPPMHG> JOKHFMOOAPP(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JLGGEKEAIFI> FPJBJDENJHB, [In] CBFBKLHLCNM JICIEEKFCFC, [In] FDHJIELJJFD GNOMFELINLB, CNFHBOBFJOE LHLIOKHLMKF, EJDMOINMPCI<GIMMNEHHJNK.ADGGLOKLALF>? GMACPHGFPBB)
	{
		return default(EJDMOINMPCI<KNLAPOPPMHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x201AE40", Offset = "0x2019440", VA = "0x18201AE40")]
	internal HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> DAIENBMKIEL(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C530", Offset = "0x2B4AB30", VA = "0x182B4C530")]
	public HHANDHIMCMH<EJDMOINMPCI<TM>, LPFOGJHKMBP> MNLPPMNFOCK<TM>(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<PPNKDIOKKPB> KLLFGOAAALA) where TM : ELEKHEFGCEB.PFGCOJFMLLD
	{
		return default(HHANDHIMCMH<EJDMOINMPCI<TM>, LPFOGJHKMBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C700", Offset = "0x2B4AD00", VA = "0x182B4C700")]
	public HHANDHIMCMH<EJDMOINMPCI<TM>, LPFOGJHKMBP> NCNPMFKDGDE<TM>(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<JLGGEKEAIFI> GEKOACPCMEB) where TM : ACCHELCNMEE.ABLLFBGGGLE
	{
		return default(HHANDHIMCMH<EJDMOINMPCI<TM>, LPFOGJHKMBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x201BA10", Offset = "0x201A010", VA = "0x18201BA10")]
	private HHANDHIMCMH<(EJDMOINMPCI<AOJCIBLOCPF.GMABEDEJPGN>, EJDMOINMPCI<AGIKIOCONOJ.FKFCADOPHIE>), LPFOGJHKMBP> HNGCGKFMGOH(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
		return default(HHANDHIMCMH<(EJDMOINMPCI<AOJCIBLOCPF.GMABEDEJPGN>, EJDMOINMPCI<AGIKIOCONOJ.FKFCADOPHIE>), LPFOGJHKMBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x201C7F0", Offset = "0x201ADF0", VA = "0x18201C7F0")]
	internal HHANDHIMCMH<(EJDMOINMPCI<JFGPEANAFFG>, EJDMOINMPCI<FNFFOGDJCBH>), LPFOGJHKMBP> OKBFCMKIPJB(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, int JCOCDKDILMK, [In] ACHIMMPEDOC BDKLEMDNAFL)
	{
		return default(HHANDHIMCMH<(EJDMOINMPCI<JFGPEANAFFG>, EJDMOINMPCI<FNFFOGDJCBH>), LPFOGJHKMBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x201B210", Offset = "0x2019810", VA = "0x18201B210")]
	internal HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> HMBKHBHOGHD(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, int JCOCDKDILMK)
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x201A480", Offset = "0x2018A80", VA = "0x18201A480")]
	internal HHANDHIMCMH<(EJDMOINMPCI<FNFFOGDJCBH>, EJDMOINMPCI<JFGPEANAFFG>), LPFOGJHKMBP> AGMNAEHIEJH(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, int KBEACEHLJAH, [In] ACHIMMPEDOC BDKLEMDNAFL)
	{
		return default(HHANDHIMCMH<(EJDMOINMPCI<FNFFOGDJCBH>, EJDMOINMPCI<JFGPEANAFFG>), LPFOGJHKMBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x201BFB0", Offset = "0x201A5B0", VA = "0x18201BFB0")]
	internal HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> LDLOBCPBCLC(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, int KBEACEHLJAH)
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JGDFJNPJECI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public JMJAGLIJMHJ<AGIKIOCONOJ.FKFCADOPHIE, PGOBKAMEOBJ> ODCFBMAEJEA;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FAA240", Offset = "0x1FA8840", VA = "0x181FAA240")]
	private JGDFJNPJECI([In] JMJAGLIJMHJ<AGIKIOCONOJ.FKFCADOPHIE, PGOBKAMEOBJ> LIMMEPMMGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x201F650", Offset = "0x201DC50", VA = "0x18201F650")]
	public static JGDFJNPJECI NKOJKFHACJH()
	{
		return default(JGDFJNPJECI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IAFKCIFKCAE
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x201F260", Offset = "0x201D860", VA = "0x18201F260")]
	public static void AMMOOILDICF(this JGDFJNPJECI ELMHNMGFNPC, [In] DLGAHFMKIEB<AGIKIOCONOJ.FKFCADOPHIE> HNJKNOHKKDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FBFMHMKOGDJ
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2019BF0", Offset = "0x20181F0", VA = "0x182019BF0")]
	public static ABKMHKCCGEC ALGEABNCNAB(FCGFBJAACMM PMCDBPBJKDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2019D40", Offset = "0x2018340", VA = "0x182019D40")]
	public static ABKMHKCCGEC OAKKDGMAPPI(EJDMOINMPCI<PPNKDIOKKPB> NNKOFNDAACM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class PBAADMEFKHH
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2033980", Offset = "0x2031F80", VA = "0x182033980")]
	public static NAMFLLBJBNM ALGEABNCNAB(this GICCCEAPIAH BDKLEMDNAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2034A70", Offset = "0x2033070", VA = "0x182034A70")]
	public static GICCCEAPIAH DIPBOAAMMJI(this NAMFLLBJBNM BDKLEMDNAFL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class LLGFFENKFAB
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C17B80", Offset = "0x2C16180", VA = "0x182C17B80")]
	public static Dictionary<TDeserializedKey, TDeserializedValue> DPALNFLGEAB<TDeserializedKey, TDeserializedValue, TSerialized>(this RepeatedField<TSerialized> PDJMPEHKHJH, Func<TSerialized, TDeserializedKey> BHKCDECONLN, Func<TSerialized, TDeserializedValue> HAIDHDAPEKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class NFLKHBLPAPD
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2028860", Offset = "0x2026E60", VA = "0x182028860")]
	public static MHILGAKNKAF ALGEABNCNAB([In] this ELEKHEFGCEB ELMHNMGFNPC, [In] PHJIMPBCICO CEAMJPPFFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2028F10", Offset = "0x2027510", VA = "0x182028F10")]
	public static ELEKHEFGCEB DIPBOAAMMJI(this MHILGAKNKAF ELMHNMGFNPC, [In] PHJIMPBCICO CEAMJPPFFCL)
	{
		return default(ELEKHEFGCEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PPBPKNAGFFB
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x20355C0", Offset = "0x2033BC0", VA = "0x1820355C0")]
	public static IIIHFLJPDIO ALGEABNCNAB([In] this KCFKDAEGJHH ELMHNMGFNPC, [In] ODKJEIKNABL IBGFHFACEKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x20358D0", Offset = "0x2033ED0", VA = "0x1820358D0")]
	public static KCFKDAEGJHH DIPBOAAMMJI(this IIIHFLJPDIO ELMHNMGFNPC, [In] ODKJEIKNABL IBGFHFACEKA)
	{
		return default(KCFKDAEGJHH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JBLBGAPEMCD
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x201F3B0", Offset = "0x201D9B0", VA = "0x18201F3B0")]
	public static PCFIKOOEAOM ALGEABNCNAB([In] this KFDOFEBPOLE ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x201F5A0", Offset = "0x201DBA0", VA = "0x18201F5A0")]
	public static KFDOFEBPOLE DIPBOAAMMJI(this PCFIKOOEAOM ELMHNMGFNPC)
	{
		return default(KFDOFEBPOLE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HGNBPJAIHAF
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x201E540", Offset = "0x201CB40", VA = "0x18201E540")]
	public static CNELILKDNCP ALGEABNCNAB([In] this ACCHELCNMEE ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x201E5C0", Offset = "0x201CBC0", VA = "0x18201E5C0")]
	public static ACCHELCNMEE DIPBOAAMMJI(this CNELILKDNCP ELMHNMGFNPC)
	{
		return default(ACCHELCNMEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HFJNPEOJOIN
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x201E450", Offset = "0x201CA50", VA = "0x18201E450")]
	public static NFKCGIBKAFM ALGEABNCNAB([In] this ONCEICAGLFL ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x201E4C0", Offset = "0x201CAC0", VA = "0x18201E4C0")]
	public static ONCEICAGLFL DIPBOAAMMJI(this NFKCGIBKAFM ELMHNMGFNPC)
	{
		return default(ONCEICAGLFL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class FACJJCGLDGM
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2B4A020", Offset = "0x2B48620", VA = "0x182B4A020")]
	public static FELMKPCAFNP ALGEABNCNAB<TRoot>([In] this IJCLBOHFDPL<TRoot> ELMHNMGFNPC) where TRoot : CBJENDFAIHA<TRoot>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2019520", Offset = "0x2017B20", VA = "0x182019520")]
	public static IJCLBOHFDPL<FCGFBJAACMM> DIPBOAAMMJI(this FELMKPCAFNP ELMHNMGFNPC, [In] AKOENAINMMA KMNGIDIHGLH)
	{
		return default(IJCLBOHFDPL<FCGFBJAACMM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class HDNGMLBGOEO
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x201DF10", Offset = "0x201C510", VA = "0x18201DF10")]
	public static PDGCHCMOGKL ALGEABNCNAB([In] this AGIKIOCONOJ.NGOOOFOBPGD ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x201E160", Offset = "0x201C760", VA = "0x18201E160")]
	public static AGIKIOCONOJ.NGOOOFOBPGD DIPBOAAMMJI(this PDGCHCMOGKL ELMHNMGFNPC)
	{
		return default(AGIKIOCONOJ.NGOOOFOBPGD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class GPMDCMHMHDL
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x201DE50", Offset = "0x201C450", VA = "0x18201DE50")]
	public static JEICGCGGFPJ ALGEABNCNAB([In] this AOJCIBLOCPF.CFHKFPLNFKL ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x201DEC0", Offset = "0x201C4C0", VA = "0x18201DEC0")]
	public static AOJCIBLOCPF.CFHKFPLNFKL DIPBOAAMMJI(this JEICGCGGFPJ ELMHNMGFNPC)
	{
		return default(AOJCIBLOCPF.CFHKFPLNFKL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class LLEIGIHDDBL
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x20217E0", Offset = "0x201FDE0", VA = "0x1820217E0")]
	public static EICPKMBHNDP ALGEABNCNAB([In] this ODKJEIKNABL ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x20219D0", Offset = "0x201FFD0", VA = "0x1820219D0")]
	public static ODKJEIKNABL DIPBOAAMMJI(this EICPKMBHNDP ELMHNMGFNPC)
	{
		return default(ODKJEIKNABL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class EIOKHBMANHK
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x20191A0", Offset = "0x20177A0", VA = "0x1820191A0")]
	public static OCHJKEINJJJ ALGEABNCNAB([In] Guid ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x20192A0", Offset = "0x20178A0", VA = "0x1820192A0")]
	public static Guid DIPBOAAMMJI(OCHJKEINJJJ ELMHNMGFNPC)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class ELDIEABIGGM
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2019400", Offset = "0x2017A00", VA = "0x182019400")]
	public static KJLOAIPAPML ALGEABNCNAB([In] this FFAJGCMBAEM ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2019480", Offset = "0x2017A80", VA = "0x182019480")]
	public static FFAJGCMBAEM DIPBOAAMMJI(this KJLOAIPAPML ELMHNMGFNPC)
	{
		return default(FFAJGCMBAEM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GDKABLACBCH
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x201DC40", Offset = "0x201C240", VA = "0x18201DC40")]
	public static GPBIOMIFNOB ALGEABNCNAB([In] this ACHIMMPEDOC ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x201DCD0", Offset = "0x201C2D0", VA = "0x18201DCD0")]
	public static ACHIMMPEDOC DIPBOAAMMJI(this GPBIOMIFNOB ELMHNMGFNPC)
	{
		return default(ACHIMMPEDOC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class BIEFPIJIAOO
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2015930", Offset = "0x2013F30", VA = "0x182015930")]
	public static IBOAHBMDEKA ALGEABNCNAB([In] this OAOODGMBBNC ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x20159B0", Offset = "0x2013FB0", VA = "0x1820159B0")]
	public static OAOODGMBBNC DIPBOAAMMJI(this IBOAHBMDEKA ELMHNMGFNPC)
	{
		return default(OAOODGMBBNC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DMHIOBNDEBP
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x29AD540", Offset = "0x29ABB40", VA = "0x1829AD540")]
	public static void LLGCJBFPLBN<TDeserialized, TSerialized>(this IReadOnlyCollection<TDeserialized> ELMHNMGFNPC, RepeatedField<TSerialized> PDJMPEHKHJH, KFNJKFBDHNG<TDeserialized, TSerialized> GPNJJCFBLBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FKALJNIMEDG
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x201D2C0", Offset = "0x201B8C0", VA = "0x18201D2C0")]
	public static JDJBNBGMPAH ALGEABNCNAB([In] this NIKEPNMEFKP ELMHNMGFNPC, [In] PHJIMPBCICO CEAMJPPFFCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x201D5B0", Offset = "0x201BBB0", VA = "0x18201D5B0")]
	public static NIKEPNMEFKP DIPBOAAMMJI(this JDJBNBGMPAH ELMHNMGFNPC, [In] PHJIMPBCICO CEAMJPPFFCL)
	{
		return default(NIKEPNMEFKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CHMFOBKEBFB
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2015B30", Offset = "0x2014130", VA = "0x182015B30")]
	public static IDJLGCBNHCG ALGEABNCNAB([In] this EAIHJFJBHEP ELMHNMGFNPC, [In] ODKJEIKNABL IBGFHFACEKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2015FB0", Offset = "0x20145B0", VA = "0x182015FB0")]
	public static EAIHJFJBHEP DIPBOAAMMJI(this IDJLGCBNHCG ELMHNMGFNPC, [In] ODKJEIKNABL IBGFHFACEKA)
	{
		return default(EAIHJFJBHEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OMPMGNEMAPB
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2033590", Offset = "0x2031B90", VA = "0x182033590")]
	public static BLCFBNJHDMD ALGEABNCNAB([In] this BIIPCPIDPPJ ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2033620", Offset = "0x2031C20", VA = "0x182033620")]
	public static BIIPCPIDPPJ DIPBOAAMMJI(this BLCFBNJHDMD ELMHNMGFNPC)
	{
		return default(BIIPCPIDPPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class DMDMNLEJCOM
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2016820", Offset = "0x2014E20", VA = "0x182016820")]
	public static BFPCGGMLAAL ALGEABNCNAB(this FCGFBJAACMM ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2016910", Offset = "0x2014F10", VA = "0x182016910")]
	public static FCGFBJAACMM DIPBOAAMMJI(this BFPCGGMLAAL ELMHNMGFNPC, [In] AKOENAINMMA KMNGIDIHGLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class JPIMFHKHPHK
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x201F6B0", Offset = "0x201DCB0", VA = "0x18201F6B0")]
	public static FAFOCHFGMHO ALGEABNCNAB([In] this BFKABKCMACF ELMHNMGFNPC, GICCCEAPIAH BDKLEMDNAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x201F870", Offset = "0x201DE70", VA = "0x18201F870")]
	public static BFKABKCMACF DIPBOAAMMJI(this FAFOCHFGMHO ELMHNMGFNPC)
	{
		return default(BFKABKCMACF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct ACDKCKAHDCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly EJDMOINMPCI<FNFFOGDJCBH> FIJOMBMOAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly EJDMOINMPCI<JFGPEANAFFG> BBHBAHMENOC;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1CA8F30", Offset = "0x1CA7530", VA = "0x181CA8F30")]
	private ACDKCKAHDCI(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> NMLOEFBCIFB, EJDMOINMPCI<JFGPEANAFFG> NOCHJOEJNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x2014D70", Offset = "0x2013370", VA = "0x182014D70")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, ACDKCKAHDCI> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, ACDKCKAHDCI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x31FAA00", Offset = "0x31F9000", VA = "0x1831FAA00")]
	public static HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] ACDKCKAHDCI ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct CGCFDBIILCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL>? EJNMCKPAGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly EJDMOINMPCI<PPNKDIOKKPB> JGLCEJBOCDL;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1FCD9B0", Offset = "0x1FCBFB0", VA = "0x181FCD9B0")]
	private CGCFDBIILCE(EJDMOINMPCI<ALFNFGCIOCL>? CIHGHGHAKOD, EJDMOINMPCI<PPNKDIOKKPB> KLLFGOAAALA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2015A50", Offset = "0x2014050", VA = "0x182015A50")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, CGCFDBIILCE> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, CGCFDBIILCE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2966850", Offset = "0x2964E50", VA = "0x182966850")]
	public static HHANDHIMCMH<EJDMOINMPCI<ALFNFGCIOCL>, LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] CGCFDBIILCE ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<EJDMOINMPCI<ALFNFGCIOCL>, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct COKHCBGEKMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public readonly EJDMOINMPCI<KNLAPOPPMHG> JCIJPNJJIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public readonly EJDMOINMPCI<IGPCADFLAPD> PJJMDECGIPE;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1CA8F30", Offset = "0x1CA7530", VA = "0x181CA8F30")]
	private COKHCBGEKMD(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2016420", Offset = "0x2014A20", VA = "0x182016420")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, COKHCBGEKMD> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, COKHCBGEKMD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2972550", Offset = "0x2970B50", VA = "0x182972550")]
	public static HHANDHIMCMH<EJDMOINMPCI<JFGPEANAFFG>, LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] COKHCBGEKMD ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<EJDMOINMPCI<JFGPEANAFFG>, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct ALLFFMNPKID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly EJDMOINMPCI<JLGGEKEAIFI> KMPILPKIJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public readonly CBFBKLHLCNM MCKPEAAMDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public readonly FDHJIELJJFD DFOFOGHOHDC;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2015900", Offset = "0x2013F00", VA = "0x182015900")]
	private ALLFFMNPKID(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JLGGEKEAIFI> KPBICOHOGAP, [In] CBFBKLHLCNM DIHKEDNFAAN, [In] FDHJIELJJFD LPFJDLDOEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2015790", Offset = "0x2013D90", VA = "0x182015790")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, ALLFFMNPKID> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, ALLFFMNPKID>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3217950", Offset = "0x3215F50", VA = "0x183217950")]
	public static HHANDHIMCMH<EJDMOINMPCI<KNLAPOPPMHG>, LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] ALLFFMNPKID ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<EJDMOINMPCI<KNLAPOPPMHG>, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct HHNFBNJACBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public readonly EJDMOINMPCI<KNLAPOPPMHG> JCIJPNJJIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public readonly int HEPNICKHADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public readonly ACHIMMPEDOC FJKMPMDCIGN;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x201E7B0", Offset = "0x201CDB0", VA = "0x18201E7B0")]
	private HHNFBNJACBH(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, int KBEACEHLJAH, ACHIMMPEDOC BDKLEMDNAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x201E640", Offset = "0x201CC40", VA = "0x18201E640")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, HHNFBNJACBH> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, HHNFBNJACBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2B7F880", Offset = "0x2B7DE80", VA = "0x182B7F880")]
	public static HHANDHIMCMH<(EJDMOINMPCI<JFGPEANAFFG>, EJDMOINMPCI<FNFFOGDJCBH>), LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] HHNFBNJACBH ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<(EJDMOINMPCI<JFGPEANAFFG>, EJDMOINMPCI<FNFFOGDJCBH>), LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct NKKLDCHFNHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly EJDMOINMPCI<KNLAPOPPMHG> JCIJPNJJIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly int ENOJOMEHDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly ACHIMMPEDOC FJKMPMDCIGN;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x201E7B0", Offset = "0x201CDB0", VA = "0x18201E7B0")]
	private NKKLDCHFNHP(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, int KBEACEHLJAH, ACHIMMPEDOC BDKLEMDNAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x2029710", Offset = "0x2027D10", VA = "0x182029710")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, NKKLDCHFNHP> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, NKKLDCHFNHP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2CC2390", Offset = "0x2CC0990", VA = "0x182CC2390")]
	public static HHANDHIMCMH<(EJDMOINMPCI<FNFFOGDJCBH>, EJDMOINMPCI<JFGPEANAFFG>), LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] NKKLDCHFNHP ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<(EJDMOINMPCI<FNFFOGDJCBH>, EJDMOINMPCI<JFGPEANAFFG>), LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct EKPGMDOGPMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public readonly EJDMOINMPCI<KNLAPOPPMHG> JCIJPNJJIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public readonly int HEPNICKHADM;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1CA8F30", Offset = "0x1CA7530", VA = "0x181CA8F30")]
	private EKPGMDOGPMM(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, int JCOCDKDILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2019340", Offset = "0x2017940", VA = "0x182019340")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, EKPGMDOGPMM> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, EKPGMDOGPMM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x29F7910", Offset = "0x29F5F10", VA = "0x1829F7910")]
	public static HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] EKPGMDOGPMM ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct GDNDINGDMLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly EJDMOINMPCI<KNLAPOPPMHG> JCIJPNJJIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly int ENOJOMEHDHI;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1CA8F30", Offset = "0x1CA7530", VA = "0x181CA8F30")]
	private GDNDINGDMLA(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, int JCOCDKDILMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x201DD30", Offset = "0x201C330", VA = "0x18201DD30")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, GDNDINGDMLA> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, GDNDINGDMLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2B6FC80", Offset = "0x2B6E280", VA = "0x182B6FC80")]
	public static HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] GDNDINGDMLA ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct NHONFFEAAPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public readonly EJDMOINMPCI<JFGPEANAFFG> AFBPNHCGBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public readonly BFKABKCMACF CLLNMNOFOEG;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x20296F0", Offset = "0x2027CF0", VA = "0x1820296F0")]
	private NHONFFEAAPI(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE, [In] BFKABKCMACF PBAONJMDGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x20295E0", Offset = "0x2027BE0", VA = "0x1820295E0")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, NHONFFEAAPI> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, NHONFFEAAPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2CBFF60", Offset = "0x2CBE560", VA = "0x182CBFF60")]
	public static HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] NHONFFEAAPI ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct DCBFKAGIGIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly EJDMOINMPCI<FNFFOGDJCBH> FIJOMBMOAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly EJDMOINMPCI<JFGPEANAFFG> BBHBAHMENOC;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x1CA8F30", Offset = "0x1CA7530", VA = "0x181CA8F30")]
	private DCBFKAGIGIE(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> NMLOEFBCIFB, EJDMOINMPCI<JFGPEANAFFG> NOCHJOEJNDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2016680", Offset = "0x2014C80", VA = "0x182016680")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, DCBFKAGIGIE> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, DCBFKAGIGIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x299BE40", Offset = "0x299A440", VA = "0x18299BE40")]
	public static HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] DCBFKAGIGIE ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct GDBGCJACDCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
	private GDBGCJACDCL(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x201DBC0", Offset = "0x201C1C0", VA = "0x18201DBC0")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, GDBGCJACDCL> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, GDBGCJACDCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F680", Offset = "0x2B6DC80", VA = "0x182B6F680")]
	public static HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] GDBGCJACDCL ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct LKFHDGOEIAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public readonly EJDMOINMPCI<ALFNFGCIOCL> DGAICGJEBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly EJDMOINMPCI<KNLAPOPPMHG> JCIJPNJJIII;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xD48E20", Offset = "0xD47420", VA = "0x180D48E20")]
	private LKFHDGOEIAG(EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x2021720", Offset = "0x201FD20", VA = "0x182021720")]
	public static BLMIMLGDJPA<JJIHKNDFLHA, LKFHDGOEIAG> LCFDAOENOAA(HAFPKGJPPHJ IDPNONKFFNM)
	{
		return default(BLMIMLGDJPA<JJIHKNDFLHA, LKFHDGOEIAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x2C17940", Offset = "0x2C15F40", VA = "0x182C17940")]
	public static HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP> LOFMEEBENCB<TRoot>(TRoot GOKNAIEAOEG, [In] LKFHDGOEIAG ELMHNMGFNPC) where TRoot : BAMIBLDLIFB
	{
		return default(HHANDHIMCMH<DHABIOOJNOJ, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class EEJMBKNEGAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly Guid PMOMHMFEGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly bool FIOEBBGEFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public readonly bool BNHLOCLCEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly bool HLFJEKGKPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly bool DOMALJHCIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public readonly bool BCIJDPLPDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly List<(string Name, GICCCEAPIAH Type)> CPLJBBOHFGP;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Guid EPFHNBBFJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1FDCA70", Offset = "0x1FDB070", VA = "0x181FDCA70")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string IKOGEGKCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x85F460", Offset = "0x85DA60", VA = "0x18085F460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public IReadOnlyList<(string Name, GICCCEAPIAH Type)> FGILDECDAIE
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action GELPPKIPAMI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2018A50", Offset = "0x2017050", VA = "0x182018A50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2018650", Offset = "0x2016C50", VA = "0x182018650")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<string, GICCCEAPIAH> BHKDCHJENHH
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2018930", Offset = "0x2016F30", VA = "0x182018930")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x20186F0", Offset = "0x2016CF0", VA = "0x1820186F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<int> CKNKNGPJDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x20185A0", Offset = "0x2016BA0", VA = "0x1820185A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2018D20", Offset = "0x2017320", VA = "0x182018D20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<int, string> INNIPHJKAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2018490", Offset = "0x2016A90", VA = "0x182018490")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2018350", Offset = "0x2016950", VA = "0x182018350")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<int, GICCCEAPIAH> PJGAFMHOEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2018E70", Offset = "0x2017470", VA = "0x182018E70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2019000", Offset = "0x2017600", VA = "0x182019000")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action IFJCAAOFAMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2018890", Offset = "0x2016E90", VA = "0x182018890")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2018DD0", Offset = "0x20173D0", VA = "0x182018DD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1D76F30", Offset = "0x1D75530", VA = "0x181D76F30")]
	public void MHLNJPMADFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x20190B0", Offset = "0x20176B0", VA = "0x1820190B0")]
	internal EEJMBKNEGAC([In] Guid KAGKMEDPMHO, string LGJDNDBECCI, bool NCIGCDEBHLB, bool LCEGPEIKKND, bool NKOGDOPANJI, bool LHHBPEAEICI, bool KDKBKLJBFJN, List<(string Name, GICCCEAPIAH Type)> GABJNPJHJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2018400", Offset = "0x2016A00", VA = "0x182018400")]
	public static GBCBOBADILC CINPMHEKJIO(string KAGKMEDPMHO, string LGJDNDBECCI, bool NCIGCDEBHLB = false, bool LCEGPEIKKND = false, bool NKOGDOPANJI = false, bool LHHBPEAEICI = true, bool KDKBKLJBFJN = true)
	{
		return default(GBCBOBADILC);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x2018F20", Offset = "0x2017520", VA = "0x182018F20")]
	public static EEJMBKNEGAC PNGELHEHBBF([In] Guid KAGKMEDPMHO, string LGJDNDBECCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x2018540", Offset = "0x2016B40", VA = "0x182018540")]
	public void GEJIMHFOMMD(string LGJDNDBECCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2018AF0", Offset = "0x20170F0", VA = "0x182018AF0")]
	public void MEMNDHHEDGM(int EBDMAJMOJLN, string BNCECJMCPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x20187A0", Offset = "0x2016DA0", VA = "0x1820187A0")]
	public void KJOFJBHJODJ(int EBDMAJMOJLN, GICCCEAPIAH FBIOFLKELNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2018BE0", Offset = "0x20171E0", VA = "0x182018BE0")]
	public void MMHNMNEOJAI(string LGJDNDBECCI, GICCCEAPIAH BIFBAEAPICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x20189E0", Offset = "0x2016FE0", VA = "0x1820189E0")]
	public void LOPIJKKABAG(int EBDMAJMOJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct GBCBOBADILC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly Guid PMOMHMFEGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly string HPELFNEMHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool BIPIAAAEMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly bool KPLLHLJDMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly bool EIKGPGGMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly bool CHCCNPDIJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly bool NHKHKDNHJOC;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x201DB60", Offset = "0x201C160", VA = "0x18201DB60")]
	public GBCBOBADILC([In] Guid KAGKMEDPMHO, string LGJDNDBECCI, bool NCIGCDEBHLB, bool LCEGPEIKKND, bool NKOGDOPANJI, bool LHHBPEAEICI, bool KDKBKLJBFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x201D9E0", Offset = "0x201BFE0", VA = "0x18201D9E0")]
	public ONDBKEDIOJM KJPIKEBGFKI(string LGJDNDBECCI, GICCCEAPIAH BDKLEMDNAFL)
	{
		return default(ONDBKEDIOJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x201D8C0", Offset = "0x201BEC0", VA = "0x18201D8C0")]
	public EEJMBKNEGAC FPPJAIDLFLK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct ONDBKEDIOJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Guid PMOMHMFEGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly string HPELFNEMHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly bool BIPIAAAEMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly bool KPLLHLJDMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly bool EIKGPGGMMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly bool CHCCNPDIJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly bool NHKHKDNHJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private readonly List<(string Name, GICCCEAPIAH Type)> CPLJBBOHFGP;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2033910", Offset = "0x2031F10", VA = "0x182033910")]
	public ONDBKEDIOJM([In] Guid KAGKMEDPMHO, string LGJDNDBECCI, bool NCIGCDEBHLB, bool LCEGPEIKKND, bool NKOGDOPANJI, bool LHHBPEAEICI, bool KDKBKLJBFJN, List<(string Name, GICCCEAPIAH Type)> GABJNPJHJDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x20337C0", Offset = "0x2031DC0", VA = "0x1820337C0")]
	public ONDBKEDIOJM KJPIKEBGFKI(string LGJDNDBECCI, GICCCEAPIAH BDKLEMDNAFL)
	{
		return default(ONDBKEDIOJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x20336D0", Offset = "0x2031CD0", VA = "0x1820336D0")]
	public EEJMBKNEGAC FPPJAIDLFLK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BCMDMOMDGBL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class OAFPFMKPMEB
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly EEJMBKNEGAC LFJNMJMNHIO;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly EEJMBKNEGAC PBLLFELDNIE;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class DCALDNMNJPL
	{
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly EEJMBKNEGAC GLBHBNLAOPE;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class OLMGHAABNLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly EEJMBKNEGAC DJOJEDDLCBI;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly EEJMBKNEGAC FIFLACMMFHC;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class LPCGJDENJHL
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class HJJKKPDOAJB
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly EEJMBKNEGAC MIKAHPDOMLJ;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly EEJMBKNEGAC MGBPGDIMBGO;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class OEGIHFLMEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly EEJMBKNEGAC NCLLIHPNNFE;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly EEJMBKNEGAC ONEGJHNJFNN;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class LFOBILBIKIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly EEJMBKNEGAC DJOJEDDLCBI;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly EEJMBKNEGAC FIFLACMMFHC;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class MOHDGLACPIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly EEJMBKNEGAC COIFAMNMJBF;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly EEJMBKNEGAC EIFNPHNCEBB;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly EEJMBKNEGAC FIMHAJFFKOL;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly EEJMBKNEGAC LAPEEBOGLJB;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly EEJMBKNEGAC BMPHHLKDLKG;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly EEJMBKNEGAC PKHPJNAAMPG;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly EEJMBKNEGAC DLPOJGEBLAA;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class GPGIANAJPDD
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class EHLCPPMHHIP
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class MMCIMBHEIKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class FAEOOLCKEBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly EEJMBKNEGAC LFPHIAPEKIJ;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly EEJMBKNEGAC OFFKPKPFJIM;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class NMHBBMGKCCL
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class AHBDOAMCJBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class NFEHEELBNHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class AJFIKFKCIHF
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class NOKJDFLGCLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly EEJMBKNEGAC PFLLAOJJKIG;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class MDCJDNEIEEN
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly EEJMBKNEGAC GFKCPLPDLLE;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly EEJMBKNEGAC JANKDAPPAFM;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly EEJMBKNEGAC CBBKKGJGEMB;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly EEJMBKNEGAC NCLLIHPNNFE;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly EEJMBKNEGAC DPFNGEKNPGK;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly EEJMBKNEGAC HHKDFLMEAOC;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly EEJMBKNEGAC HMGPKHDHNJJ;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly EEJMBKNEGAC OIKGDEHIOAJ;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly EEJMBKNEGAC MMMIAHFFJOI;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly EEJMBKNEGAC NDLNABKLLJJ;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly EEJMBKNEGAC NECCDKNLMIO;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly EEJMBKNEGAC NLOHMNKGNFL;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly EEJMBKNEGAC PNJFALMJLGD;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly EEJMBKNEGAC JCFPLDPKNKF;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly EEJMBKNEGAC CGBOLPHDPFH;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly EEJMBKNEGAC JMPBCDHMNEF;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly EEJMBKNEGAC IMPKKGNNIIL;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly EEJMBKNEGAC CAJAJLMAHMB;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly EEJMBKNEGAC FBBCCPAEPKC;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public static readonly EEJMBKNEGAC IOKCOOMBAMM;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly EEJMBKNEGAC GGHFJAPFDLJ;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly EEJMBKNEGAC LBHMKFGOKDC;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly EEJMBKNEGAC NACCODPJPGF;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly EEJMBKNEGAC CMDIHAIMLPP;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly EEJMBKNEGAC PMFMMLOGNBI;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public static readonly EEJMBKNEGAC BIHPENGDCOC;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public static readonly EEJMBKNEGAC OFJBGMCPEMM;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly EEJMBKNEGAC PDGPKAEJMON;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public static readonly EEJMBKNEGAC DOHKMJKHFNA;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public static readonly EEJMBKNEGAC GLJKONCLNNH;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public static readonly EEJMBKNEGAC IAEAJMLCMKN;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public static readonly EEJMBKNEGAC JNOLKNDAKEK;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public static readonly EEJMBKNEGAC AOOACHPBKGO;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public static readonly EEJMBKNEGAC BIHKKEJAFBM;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public static readonly EEJMBKNEGAC GLLKOGNCNLL;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public static readonly EEJMBKNEGAC NHAIAIFIFLM;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public static readonly EEJMBKNEGAC ENKKCLILMDO;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static readonly EEJMBKNEGAC POPPJGKMHAC;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public static readonly EEJMBKNEGAC HABBLLFDAFD;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static readonly EEJMBKNEGAC BCKJKKHANCD;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public static readonly EEJMBKNEGAC IJIFCNJIFGC;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public static readonly EEJMBKNEGAC NDFJIOBKHJH;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public static readonly EEJMBKNEGAC LHNDPLOCLEJ;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public static readonly EEJMBKNEGAC LKPNNNIDAOO;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static readonly EEJMBKNEGAC FAFILBJABEO;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public static readonly EEJMBKNEGAC BPFBGGKNFAO;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public static readonly EEJMBKNEGAC DMMMGIDOGJA;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public static readonly EEJMBKNEGAC EPNDIIGHODJ;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static readonly EEJMBKNEGAC EBHIPIGFNPB;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public static readonly EEJMBKNEGAC MDCHJMNIENF;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public static readonly EEJMBKNEGAC IKMJFNDNMDD;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static readonly EEJMBKNEGAC ILBPJPNIJPB;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public static readonly EEJMBKNEGAC AOLPKPODNCB;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public static readonly EEJMBKNEGAC PEGFJANPIGP;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public static readonly EEJMBKNEGAC HFJPIPPEFCB;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public static readonly EEJMBKNEGAC NGGKHIOAHLN;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public static readonly EEJMBKNEGAC FNBNCNECCCA;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public static readonly EEJMBKNEGAC HAJHJFOCNNC;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public static readonly EEJMBKNEGAC JMAOHCHLNBK;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public static readonly EEJMBKNEGAC DNNHIGCHEBI;

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class KHLMMNJECBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class EPCMFNNKELJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly EEJMBKNEGAC DGELJCEBAJL;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public static readonly EEJMBKNEGAC OCKLLMDPOLJ;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly EEJMBKNEGAC DEAHCKFMANJ;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public static readonly EEJMBKNEGAC JOAHEOMAMJH;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public static readonly EEJMBKNEGAC HGFLHIAPPKJ;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public static readonly EEJMBKNEGAC KGAAOMAIHGO;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class KGFLDJKPMIB
	{
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly EEJMBKNEGAC GFKCPLPDLLE;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly EEJMBKNEGAC JANKDAPPAFM;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public static readonly EEJMBKNEGAC CIMFNMLPFAP;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly EEJMBKNEGAC MJPIAJJLKGD;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public static readonly EEJMBKNEGAC IEBJAJODCHB;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public static readonly EEJMBKNEGAC JDBDBKJJCFH;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class KPIMDCPMOFP
	{
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly EEJMBKNEGAC OGGGKBOLFHC;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly EEJMBKNEGAC HDCBJJJBBFB;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public static readonly EEJMBKNEGAC KFIINNIBBEB;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public static readonly EEJMBKNEGAC ALAJIGFMCJO;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly EEJMBKNEGAC ABKEALBBLAC;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public static readonly EEJMBKNEGAC LNCBKNHHFIJ;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class FOLFPNJFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class OBMEAGKFFIP
	{
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class CMPBIDPPNFO
	{
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public static readonly EEJMBKNEGAC IFNENPBFIKK;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class HCDONEKMDDC
	{
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public static readonly EEJMBKNEGAC PFLLAOJJKIG;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class PHBPMBDCNJJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class EDDMNKCNACI
	{
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class GOEIMDIDGKB
	{
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public static readonly EEJMBKNEGAC FGPCEDFFNJA;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static readonly EEJMBKNEGAC GCMGOLNMJOF;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public static readonly EEJMBKNEGAC CFAMLILKKCD;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public static readonly EEJMBKNEGAC MAGONCANBFP;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class IHAIBBEFNKN
	{
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public static readonly EEJMBKNEGAC NNJDEKFDKCD;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public static readonly EEJMBKNEGAC HPACNDCKJMG;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class NGNACIDMEBB
	{
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class MBIPLKFOJJF
	{
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public static readonly EEJMBKNEGAC DGELJCEBAJL;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public static readonly EEJMBKNEGAC OCKLLMDPOLJ;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class KLOBJLHGHKP
	{
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public static readonly EEJMBKNEGAC PJKLBFAODCN;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public static readonly EEJMBKNEGAC JOAHEOMAMJH;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public static readonly EEJMBKNEGAC HGFLHIAPPKJ;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public static readonly EEJMBKNEGAC KGAAOMAIHGO;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public static readonly EEJMBKNEGAC EOELNGHFFPM;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public static readonly EEJMBKNEGAC GBMDBLLPGOK;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public static readonly EEJMBKNEGAC HIKENLIEACK;

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public static readonly EEJMBKNEGAC CEIKLEMBAFL;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public static readonly EEJMBKNEGAC CGOHIKGBMLE;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public static readonly EEJMBKNEGAC LFPMIFEGEPI;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public static readonly EEJMBKNEGAC DGELJCEBAJL;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public static readonly EEJMBKNEGAC OCKLLMDPOLJ;

		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class HICIBNMKKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class JJJJFFCKNCO
	{
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public static readonly EEJMBKNEGAC DGELJCEBAJL;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public static readonly EEJMBKNEGAC OCKLLMDPOLJ;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public static readonly EEJMBKNEGAC HLDJLHECEBM;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public static readonly EEJMBKNEGAC PEBHJKMNCEL;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public static readonly EEJMBKNEGAC JCNDCBFFLNE;

		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public static class INPNBLPICJL
	{
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class KKMHPIAABKA
	{
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public static readonly EEJMBKNEGAC FLFDKDLDPKF;

		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class JBHCOMOPJPE
	{
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public static readonly EEJMBKNEGAC AMOHGJHHBAD;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public static readonly EEJMBKNEGAC LDBDOLBIFHC;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public static readonly EEJMBKNEGAC DGELJCEBAJL;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public static readonly EEJMBKNEGAC OCKLLMDPOLJ;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class OBENEIIABJD
	{
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public static class OHCCMJCCILM
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public static class MJKAFHDDJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class NHPALFDNLGG
	{
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class DDAAIANHLAK
	{
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public static readonly EEJMBKNEGAC LFPHIAPEKIJ;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public static readonly EEJMBKNEGAC OFFKPKPFJIM;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class JAKONDMDFMB
	{
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public static readonly EEJMBKNEGAC KLKOMDEDFLO;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public static readonly EEJMBKNEGAC MMJBLJOCHID;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public static readonly EEJMBKNEGAC PKLGHJBBIAE;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public static readonly EEJMBKNEGAC FEEIJNGFFHJ;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public static class LPKJPDDOBDB
	{
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public static readonly EEJMBKNEGAC KLKOMDEDFLO;

		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public static readonly EEJMBKNEGAC MMJBLJOCHID;

		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public static readonly EEJMBKNEGAC PKLGHJBBIAE;

		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public static readonly EEJMBKNEGAC FEEIJNGFFHJ;

		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class HPPPGALMECP
	{
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class GBAFGLONCFI
	{
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public static readonly EEJMBKNEGAC BILHLKKPHOP;

		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public static readonly EEJMBKNEGAC MDENBFLCGDG;

		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public static readonly EEJMBKNEGAC NBMAGPOANMD;

		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public static class CLIAHJLMFDB
	{
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public static readonly EEJMBKNEGAC HIFBGAPAGAJ;

		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public static readonly EEJMBKNEGAC ICAHFPPKGHM;

		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public static readonly EEJMBKNEGAC KFDFNLLOBPO;

		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class POKIPHBLPML
	{
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class AHMKMIJPBKI
	{
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public static readonly EEJMBKNEGAC ALIOACBBHFO;

		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public static readonly EEJMBKNEGAC FGKJKDIJHKE;

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public static readonly EEJMBKNEGAC PPACINHKMLN;

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public static readonly EEJMBKNEGAC OCPFGJKJILP;

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public static readonly EEJMBKNEGAC NMJKFNBFNLO;

		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public static class HPLHNABACFC
	{
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public static readonly EEJMBKNEGAC JNEFHCJMHHN;

		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public static class MDCEONLLHJG
	{
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public static readonly EEJMBKNEGAC PNGJABNEHEC;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public static readonly EEJMBKNEGAC DLLDFMNHEEK;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public static readonly EEJMBKNEGAC MLANIJGPMHJ;

		[Cpp2IlInjected.Token(Token = "0x4000203")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class HICFFCJBALP
	{
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public static class DNBNKCBHMKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public static class CCKPHPEOPCG
	{
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public static class FCGHJLOOOMI
	{
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public static readonly EEJMBKNEGAC JIFDALAEOPI;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public static readonly EEJMBKNEGAC GKFCAIEAMPG;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public static readonly EEJMBKNEGAC AHOCBGJAKMD;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		internal static readonly EEJMBKNEGAC[] AIEOELGMNJE;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class HJGNBGGFGJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public readonly GICCCEAPIAH CKFEPHHHGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly List<EEJMBKNEGAC> BKOOCHKCAEF;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public IReadOnlyList<EEJMBKNEGAC> LNFKECAIOBG
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x203FAF0", Offset = "0x203E0F0", VA = "0x18203FAF0")]
	protected HJGNBGGFGJK(GICCCEAPIAH PANGJJOIBKL, params EEJMBKNEGAC[][] DKNHNLDIDMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class LKAKBHOGLJG : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2045AC0", Offset = "0x20440C0", VA = "0x182045AC0")]
	internal LKAKBHOGLJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class PLKICCGHBDL : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x20486B0", Offset = "0x2046CB0", VA = "0x1820486B0")]
	internal PLKICCGHBDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class ICAFMAMLAGJ : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x20400F0", Offset = "0x203E6F0", VA = "0x1820400F0")]
	internal ICAFMAMLAGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class OAOGECBCKOH : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2047820", Offset = "0x2045E20", VA = "0x182047820")]
	internal OAOGECBCKOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class CDDPIPBIKHN : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2039AC0", Offset = "0x20380C0", VA = "0x182039AC0")]
	internal CDDPIPBIKHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class DKFJDGJNGMD : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x203BC80", Offset = "0x203A280", VA = "0x18203BC80")]
	internal DKFJDGJNGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class GAOCBBKNJBP : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x203E1E0", Offset = "0x203C7E0", VA = "0x18203E1E0")]
	internal GAOCBBKNJBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class COJJIELCAPO : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x203AFF0", Offset = "0x20395F0", VA = "0x18203AFF0")]
	internal COJJIELCAPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class HBKHHOJMLBC : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x203F370", Offset = "0x203D970", VA = "0x18203F370")]
	internal HBKHHOJMLBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class PAJBOFOEHMJ : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2047CC0", Offset = "0x20462C0", VA = "0x182047CC0")]
	internal PAJBOFOEHMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class EHBKJMDHDGC : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x203C430", Offset = "0x203AA30", VA = "0x18203C430")]
	internal EHBKJMDHDGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class KDJKNNNCKNF : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2042AD0", Offset = "0x20410D0", VA = "0x182042AD0")]
	internal KDJKNNNCKNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class JJKKGDNKHIA : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2042730", Offset = "0x2040D30", VA = "0x182042730")]
	internal JJKKGDNKHIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class LOBFGNONEEK : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x2045C90", Offset = "0x2044290", VA = "0x182045C90")]
	internal LOBFGNONEEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class BJDPHPNDOFB : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x2039550", Offset = "0x2037B50", VA = "0x182039550")]
	internal BJDPHPNDOFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class PGOFFJCDKEP : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2048480", Offset = "0x2046A80", VA = "0x182048480")]
	internal PGOFFJCDKEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class MDNCNOGDLCF : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x20471C0", Offset = "0x20457C0", VA = "0x1820471C0")]
	internal MDNCNOGDLCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class BILBOHPHIDH : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2039120", Offset = "0x2037720", VA = "0x182039120")]
	internal BILBOHPHIDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class IBPDKNBDGDL : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x203FEA0", Offset = "0x203E4A0", VA = "0x18203FEA0")]
	internal IBPDKNBDGDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class LPGILDJIAKL : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2045E60", Offset = "0x2044460", VA = "0x182045E60")]
	internal LPGILDJIAKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class FAEICHEANGD : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x203D0B0", Offset = "0x203B6B0", VA = "0x18203D0B0")]
	internal FAEICHEANGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class BCKKADEKPFN : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2038D10", Offset = "0x2037310", VA = "0x182038D10")]
	internal BCKKADEKPFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class BGMEMIBDBHA : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2038EE0", Offset = "0x20374E0", VA = "0x182038EE0")]
	internal BGMEMIBDBHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class DGCIGNGJGAC : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x203B570", Offset = "0x2039B70", VA = "0x18203B570")]
	internal DGCIGNGJGAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class FAMHMHHNLNM : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x203D280", Offset = "0x203B880", VA = "0x18203D280")]
	internal FAMHMHHNLNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class KLMELEDCJNH : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x2043E90", Offset = "0x2042490", VA = "0x182043E90")]
	internal KLMELEDCJNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class ELGCDBKEBBP : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x203C7D0", Offset = "0x203ADD0", VA = "0x18203C7D0")]
	internal ELGCDBKEBBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class CFPAMLDBEJE : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2039C90", Offset = "0x2038290", VA = "0x182039C90")]
	internal CFPAMLDBEJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class PBBKCPACJLN : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x2047E90", Offset = "0x2046490", VA = "0x182047E90")]
	internal PBBKCPACJLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class BJCJDGPKAFN : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x2039300", Offset = "0x2037900", VA = "0x182039300")]
	internal BJCJDGPKAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class EJAABPIPGMM : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x203C600", Offset = "0x203AC00", VA = "0x18203C600")]
	internal EJAABPIPGMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class EEAFLNCIPNM : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x203C1E0", Offset = "0x203A7E0", VA = "0x18203C1E0")]
	internal EEAFLNCIPNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class CNIANKHDCCE : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x203AC50", Offset = "0x2039250", VA = "0x18203AC50")]
	internal CNIANKHDCCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class PFJDHGLMHGM : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x2048230", Offset = "0x2046830", VA = "0x182048230")]
	internal PFJDHGLMHGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class ACOKBCDECAJ : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x2036E80", Offset = "0x2035480", VA = "0x182036E80")]
	internal ACOKBCDECAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class COGKPBFEICI : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x203AE20", Offset = "0x2039420", VA = "0x18203AE20")]
	internal COGKPBFEICI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class POAGKBHHNOH : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2048880", Offset = "0x2046E80", VA = "0x182048880")]
	internal POAGKBHHNOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class FIMDPNOCICO : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x203DA00", Offset = "0x203C000", VA = "0x18203DA00")]
	internal FIMDPNOCICO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class FELBNFNMGMM : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x203D830", Offset = "0x203BE30", VA = "0x18203D830")]
	internal FELBNFNMGMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class DKIOJJOIMJA : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x203BE50", Offset = "0x203A450", VA = "0x18203BE50")]
	internal DKIOJJOIMJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class LFKHBEEBCLP : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x2045720", Offset = "0x2043D20", VA = "0x182045720")]
	internal LFKHBEEBCLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class DJCKHLJNAJP : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x203B740", Offset = "0x2039D40", VA = "0x18203B740")]
	internal DJCKHLJNAJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class BJPILAFLHFP : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2039720", Offset = "0x2037D20", VA = "0x182039720")]
	internal BJPILAFLHFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class PDKCPHBLGFO : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2048060", Offset = "0x2046660", VA = "0x182048060")]
	internal PDKCPHBLGFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class FOAPBCDDFLH : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x203DFB0", Offset = "0x203C5B0", VA = "0x18203DFB0")]
	internal FOAPBCDDFLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class GHFDDCPBCFM : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x203E920", Offset = "0x203CF20", VA = "0x18203E920")]
	internal GHFDDCPBCFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class JBAFCFLIALC : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2041620", Offset = "0x203FC20", VA = "0x182041620")]
	internal JBAFCFLIALC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class IDAFMFNKGBD : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x20402C0", Offset = "0x203E8C0", VA = "0x1820402C0")]
	internal IDAFMFNKGBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class BAJMLPMOCAD : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2038B40", Offset = "0x2037140", VA = "0x182038B40")]
	internal BAJMLPMOCAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class LDBPFCIBIEC : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2045550", Offset = "0x2043B50", VA = "0x182045550")]
	internal LDBPFCIBIEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class JCMMPGBHNCO : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2041D50", Offset = "0x2040350", VA = "0x182041D50")]
	internal JCMMPGBHNCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class LHLJIBIJCOH : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x20458F0", Offset = "0x2043EF0", VA = "0x1820458F0")]
	internal LHLJIBIJCOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class JGBPJFAIIJC : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2041F20", Offset = "0x2040520", VA = "0x182041F20")]
	internal JGBPJFAIIJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class KCLICJOCCLL : HJGNBGGFGJK
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2042900", Offset = "0x2040F00", VA = "0x182042900")]
	internal KCLICJOCCLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public sealed class HHAPCFOJCFJ : IIJNIEMDGGC
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x203F6C0", Offset = "0x203DCC0", VA = "0x18203F6C0")]
	public HHAPCFOJCFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public abstract class IGMHNHLIAJG : HBHBIDCMLCJ<FCGFBJAACMM>
{
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2038B00", Offset = "0x2037100", VA = "0x182038B00")]
	protected IGMHNHLIAJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public abstract class CCJMOMBKJLI : HMFFCKMIGEF<FCGFBJAACMM>
{
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2039A10", Offset = "0x2038010", VA = "0x182039A10")]
	protected CCJMOMBKJLI([In] LNLDEMACHPL GDIFCHONHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2039980", Offset = "0x2037F80", VA = "0x182039980", Slot = "11")]
	public override void LHMNPAEDBCL(FCGFBJAACMM GOKNAIEAOEG, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, CNFHBOBFJOE IHBFJIMCLJM, EJDMOINMPCI<GIMMNEHHJNK.ADGGLOKLALF>? NFOMBBGNLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x20398F0", Offset = "0x2037EF0", VA = "0x1820398F0", Slot = "14")]
	public override void KCJGBNLFFOD(FCGFBJAACMM GOKNAIEAOEG, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public abstract class JFIGHMEIBNI : CCJMOMBKJLI
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2039A10", Offset = "0x2038010", VA = "0x182039A10")]
	public JFIGHMEIBNI([In] LNLDEMACHPL GDIFCHONHHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class FMDAMNKBOFC : IGMHNHLIAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "11")]
	public override void LHMNPAEDBCL(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, CNFHBOBFJOE IHBFJIMCLJM, EJDMOINMPCI<GIMMNEHHJNK.ADGGLOKLALF>? NFOMBBGNLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "12")]
	public override void DIOHHBHMAJD(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x203DF80", Offset = "0x203C580", VA = "0x18203DF80", Slot = "13")]
	public override IEnumerable<FNBNBFACOFM<GICCCEAPIAH>> KJDKDCPPDJO(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x203DCD0", Offset = "0x203C2D0", VA = "0x18203DCD0", Slot = "14")]
	public override void KCJGBNLFFOD(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x203DBD0", Offset = "0x203C1D0", VA = "0x18203DBD0")]
	public static void FDMFAONPIDL(FCGFBJAACMM PMCDBPBJKDB, [In] AGIKIOCONOJ.NGOOOFOBPGD PMAHIDICPCE, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2038290", Offset = "0x2036890", VA = "0x182038290", Slot = "15")]
	public override BFKABKCMACF GGNCLCJPAAE(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP, GICCCEAPIAH BNEEDDHCPAI)
	{
		return default(BFKABKCMACF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2038B00", Offset = "0x2037100", VA = "0x182038B00")]
	public FMDAMNKBOFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public sealed class AOJCIBLOCPF : IGMHNHLIAJG
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class GMABEDEJPGN : ACCHELCNMEE.ABLLFBGGGLE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public struct CFHKFPLNFKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public readonly EJDMOINMPCI<ALFNFGCIOCL> GOIEJDBDHGK;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xB5EC40", Offset = "0xB5D240", VA = "0x180B5EC40")]
		private CFHKFPLNFKL(EJDMOINMPCI<ALFNFGCIOCL> ONAGBLFGJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xE6F580", Offset = "0xE6DB80", VA = "0x180E6F580")]
		public static CFHKFPLNFKL NKOJKFHACJH(EJDMOINMPCI<ALFNFGCIOCL> DKDPCHONLPG)
		{
			return default(CFHKFPLNFKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2038850", Offset = "0x2036E50", VA = "0x182038850", Slot = "11")]
	public override void LHMNPAEDBCL(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, CNFHBOBFJOE IHBFJIMCLJM, EJDMOINMPCI<GIMMNEHHJNK.ADGGLOKLALF>? NFOMBBGNLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2037FF0", Offset = "0x20365F0", VA = "0x182037FF0", Slot = "12")]
	public override void DIOHHBHMAJD(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x20387C0", Offset = "0x2036DC0", VA = "0x1820387C0", Slot = "13")]
	public override IEnumerable<FNBNBFACOFM<GICCCEAPIAH>> KJDKDCPPDJO(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x20382D0", Offset = "0x20368D0", VA = "0x1820382D0", Slot = "14")]
	public override void KCJGBNLFFOD(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2038A00", Offset = "0x2037000", VA = "0x182038A00")]
	public static void PCIEJHDIDHO(FCGFBJAACMM PMCDBPBJKDB, [In] AGIKIOCONOJ.NGOOOFOBPGD PMAHIDICPCE, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2038190", Offset = "0x2036790", VA = "0x182038190")]
	public static void FDMFAONPIDL(FCGFBJAACMM PMCDBPBJKDB, [In] AGIKIOCONOJ.NGOOOFOBPGD PMAHIDICPCE, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<FNFFOGDJCBH> BOFMKCGGCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2038290", Offset = "0x2036890", VA = "0x182038290", Slot = "15")]
	public override BFKABKCMACF GGNCLCJPAAE(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP, GICCCEAPIAH BNEEDDHCPAI)
	{
		return default(BFKABKCMACF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2038B00", Offset = "0x2037100", VA = "0x182038B00")]
	public AOJCIBLOCPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public sealed class IHDBDEENMJL : IGMHNHLIAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "11")]
	public override void LHMNPAEDBCL(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, CNFHBOBFJOE IHBFJIMCLJM, EJDMOINMPCI<GIMMNEHHJNK.ADGGLOKLALF>? NFOMBBGNLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "12")]
	public override void DIOHHBHMAJD(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2040AD0", Offset = "0x203F0D0", VA = "0x182040AD0", Slot = "13")]
	public override IEnumerable<FNBNBFACOFM<GICCCEAPIAH>> KJDKDCPPDJO(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2040820", Offset = "0x203EE20", VA = "0x182040820", Slot = "14")]
	public override void KCJGBNLFFOD(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2040B00", Offset = "0x203F100", VA = "0x182040B00")]
	public static void PCIEJHDIDHO(FCGFBJAACMM PMCDBPBJKDB, [In] AGIKIOCONOJ.NGOOOFOBPGD PMAHIDICPCE, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<JFGPEANAFFG> OGJENGKEFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2038290", Offset = "0x2036890", VA = "0x182038290", Slot = "15")]
	public override BFKABKCMACF GGNCLCJPAAE(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP, GICCCEAPIAH BNEEDDHCPAI)
	{
		return default(BFKABKCMACF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2038B00", Offset = "0x2037100", VA = "0x182038B00")]
	public IHDBDEENMJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class MDGDHGFJJPB : CCJMOMBKJLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	public readonly EJDMOINMPCI<IGPCADFLAPD> ONAGGJBMFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	public readonly EJDMOINMPCI<LKNDMCFLHDM> FJFOFLDNDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public readonly EJDMOINMPCI<LKNDMCFLHDM> FAHCIBFEIOJ;

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2046EC0", Offset = "0x20454C0", VA = "0x182046EC0")]
	public MDGDHGFJJPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public abstract class IIJNIEMDGGC : PGMKHOAJLPA<FCGFBJAACMM>
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2040F20", Offset = "0x203F520", VA = "0x182040F20")]
	protected IIJNIEMDGGC([In] KBKOPCFCFOA GDIFCHONHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2040D30", Offset = "0x203F330", VA = "0x182040D30", Slot = "11")]
	public override void LHMNPAEDBCL(FCGFBJAACMM GOKNAIEAOEG, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, CNFHBOBFJOE IHBFJIMCLJM, EJDMOINMPCI<GIMMNEHHJNK.ADGGLOKLALF>? NFOMBBGNLIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x2040C00", Offset = "0x203F200", VA = "0x182040C00", Slot = "12")]
	public override void DIOHHBHMAJD(FCGFBJAACMM GOKNAIEAOEG, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2040CA0", Offset = "0x203F2A0", VA = "0x182040CA0", Slot = "14")]
	public override void KCJGBNLFFOD(FCGFBJAACMM GOKNAIEAOEG, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2040DE0", Offset = "0x203F3E0", VA = "0x182040DE0", Slot = "17")]
	public override HHANDHIMCMH<EJDMOINMPCI<JFGPEANAFFG>, LPFOGJHKMBP> PFKPHLEGGOJ(FCGFBJAACMM GOKNAIEAOEG, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, EJDMOINMPCI<KNLAPOPPMHG> PPGBMGKOKAN, EJDMOINMPCI<IGPCADFLAPD> HMBOCIJNJJP)
	{
		return default(HHANDHIMCMH<EJDMOINMPCI<JFGPEANAFFG>, LPFOGJHKMBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public sealed class ACDBMEGNCPE : JFIGHMEIBNI
{
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2036A80", Offset = "0x2035080", VA = "0x182036A80")]
	public ACDBMEGNCPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public struct BIIPCPIDPPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public CBFBKLHLCNM MCKPEAAMDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public FDHJIELJJFD DFOFOGHOHDC;

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x2039100", Offset = "0x2037700", VA = "0x182039100")]
	internal BIIPCPIDPPJ([In] CBFBKLHLCNM JICIEEKFCFC, [In] FDHJIELJJFD GNOMFELINLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x20390D0", Offset = "0x20376D0", VA = "0x1820390D0")]
	public static BIIPCPIDPPJ NKOJKFHACJH()
	{
		return default(BIIPCPIDPPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x20390B0", Offset = "0x20376B0", VA = "0x1820390B0")]
	public static BIIPCPIDPPJ HBHGEDOCEKN([In] CBFBKLHLCNM JICIEEKFCFC, [In] FDHJIELJJFD GNOMFELINLB)
	{
		return default(BIIPCPIDPPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public sealed class DJJBILKFECD : IIJNIEMDGGC
{
	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x203B910", Offset = "0x2039F10", VA = "0x18203B910")]
	public DJJBILKFECD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public sealed class ICIMAKPBKDF
{
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public sealed class AGIKIOCONOJ : CNPALHNCFFG
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class FKFCADOPHIE : ELEKHEFGCEB.PFGCOJFMLLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct NGOOOFOBPGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public string IKOGEGKCJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public PKNCMADMAHA<IGPCADFLAPD, ACHIMMPEDOC> CPOMJMEKLEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public PKNCMADMAHA<LKNDMCFLHDM, ACHIMMPEDOC> NIPMIKLEFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public readonly EJDMOINMPCI<KNLAPOPPMHG> KLOGPIIFNLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public readonly EJDMOINMPCI<KNLAPOPPMHG> AGHPEOKDHIJ;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x2047620", Offset = "0x2045C20", VA = "0x182047620")]
		private NGOOOFOBPGD(string LGJDNDBECCI, [In] PKNCMADMAHA<IGPCADFLAPD, ACHIMMPEDOC> DBGKGGMDOJE, [In] PKNCMADMAHA<LKNDMCFLHDM, ACHIMMPEDOC> BOCGOFMFKIA, EJDMOINMPCI<KNLAPOPPMHG> GEAALJKHBPC, EJDMOINMPCI<KNLAPOPPMHG> FBEKEMGMEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x2047550", Offset = "0x2045B50", VA = "0x182047550")]
		public static NGOOOFOBPGD NKOJKFHACJH(EJDMOINMPCI<KNLAPOPPMHG> BANHMJNGNKO, EJDMOINMPCI<KNLAPOPPMHG> FMMBKKAIMGF)
		{
			return default(NGOOOFOBPGD);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x20474D0", Offset = "0x2045AD0", VA = "0x1820474D0")]
		public static NGOOOFOBPGD HBHGEDOCEKN(string LGJDNDBECCI, [In] PKNCMADMAHA<IGPCADFLAPD, ACHIMMPEDOC> DBGKGGMDOJE, [In] PKNCMADMAHA<LKNDMCFLHDM, ACHIMMPEDOC> BOCGOFMFKIA, EJDMOINMPCI<KNLAPOPPMHG> BANHMJNGNKO, EJDMOINMPCI<KNLAPOPPMHG> FMMBKKAIMGF)
		{
			return default(NGOOOFOBPGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2037320", Offset = "0x2035920", VA = "0x182037320", Slot = "8")]
	public override void LHMNPAEDBCL(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, CNFHBOBFJOE IHBFJIMCLJM, EJDMOINMPCI<GIMMNEHHJNK.ADGGLOKLALF>? GMACPHGFPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x20370D0", Offset = "0x20356D0", VA = "0x1820370D0", Slot = "9")]
	public override void DIOHHBHMAJD(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2037690", Offset = "0x2035C90", VA = "0x182037690")]
	public AGIKIOCONOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class HBFBDJCJIGI
{
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x203F310", Offset = "0x203D910", VA = "0x18203F310")]
	public static void AMMOOILDICF(this AGIKIOCONOJ.NGOOOFOBPGD ELMHNMGFNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public abstract class CNPALHNCFFG : ODPOLMMKAIE<FCGFBJAACMM>
{
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2037690", Offset = "0x2035C90", VA = "0x182037690")]
	protected CNPALHNCFFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public readonly struct ACHIMMPEDOC : IEquatable<ACHIMMPEDOC>, JLMFENJHCPD<ACHIMMPEDOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public readonly string IKOGEGKCJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public readonly GICCCEAPIAH FJKMPMDCIGN;

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
	private ACHIMMPEDOC(string LGJDNDBECCI, GICCCEAPIAH BDKLEMDNAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x200C6F0", Offset = "0x200ACF0", VA = "0x18200C6F0")]
	public static ACHIMMPEDOC NKOJKFHACJH(string LGJDNDBECCI, GICCCEAPIAH BDKLEMDNAFL)
	{
		return default(ACHIMMPEDOC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2036CE0", Offset = "0x20352E0", VA = "0x182036CE0")]
	public static bool MLHBCNDBLOI([In] ACHIMMPEDOC MIGBCLGIEPA, [In] ACHIMMPEDOC MMACHIKDDMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2036CE0", Offset = "0x20352E0", VA = "0x182036CE0", Slot = "4")]
	public bool Equals(ACHIMMPEDOC OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2036CE0", Offset = "0x20352E0", VA = "0x182036CE0")]
	public bool DFENCMHGJBG([In] ACHIMMPEDOC OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2036D30", Offset = "0x2035330", VA = "0x182036D30", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2036DE0", Offset = "0x20353E0", VA = "0x182036DE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2036E40", Offset = "0x2035440", VA = "0x182036E40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2036CE0", Offset = "0x20352E0", VA = "0x182036CE0", Slot = "5")]
	private bool KOFCKFHJGFN([In] ACHIMMPEDOC OGEIJLCLBIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public sealed class GOJAACGEOID : CNPALHNCFFG
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "8")]
	public override void LHMNPAEDBCL(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, CNFHBOBFJOE IHBFJIMCLJM, EJDMOINMPCI<GIMMNEHHJNK.ADGGLOKLALF>? GMACPHGFPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "9")]
	public override void DIOHHBHMAJD(FCGFBJAACMM PMCDBPBJKDB, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2037690", Offset = "0x2035C90", VA = "0x182037690")]
	public GOJAACGEOID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct NIKEPNMEFKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public JMJAGLIJMHJ<KNLAPOPPMHG, BIIPCPIDPPJ> HBCHGBJEOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public DLGAHFMKIEB<AOJCIBLOCPF.GMABEDEJPGN> NNIPFLDNALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public JMJAGLIJMHJ<AOJCIBLOCPF.GMABEDEJPGN, AOJCIBLOCPF.CFHKFPLNFKL> NBBBEFEJBBA;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x203C110", Offset = "0x203A710", VA = "0x18203C110")]
	private NIKEPNMEFKP([In] JMJAGLIJMHJ<KNLAPOPPMHG, BIIPCPIDPPJ> IGGPCDDBEOG, [In] DLGAHFMKIEB<AOJCIBLOCPF.GMABEDEJPGN> GBBHBAIFOKJ, [In] JMJAGLIJMHJ<AOJCIBLOCPF.GMABEDEJPGN, AOJCIBLOCPF.CFHKFPLNFKL> JCFCMHFIOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x20476F0", Offset = "0x2045CF0", VA = "0x1820476F0")]
	public static NIKEPNMEFKP NKOJKFHACJH()
	{
		return default(NIKEPNMEFKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x203C080", Offset = "0x203A680", VA = "0x18203C080")]
	public static NIKEPNMEFKP HBHGEDOCEKN([In] JMJAGLIJMHJ<KNLAPOPPMHG, BIIPCPIDPPJ> IGGPCDDBEOG, [In] DLGAHFMKIEB<AOJCIBLOCPF.GMABEDEJPGN> GBBHBAIFOKJ, [In] JMJAGLIJMHJ<AOJCIBLOCPF.GMABEDEJPGN, AOJCIBLOCPF.CFHKFPLNFKL> JCFCMHFIOEG)
	{
		return default(NIKEPNMEFKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class MLGELHNGJPK
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x20473F0", Offset = "0x20459F0", VA = "0x1820473F0")]
	public static void AMMOOILDICF(this NIKEPNMEFKP ELMHNMGFNPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct EAIHJFJBHEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public JMJAGLIJMHJ<ALFNFGCIOCL, NIKEPNMEFKP> EBDFONKGFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public DLGAHFMKIEB<AGIKIOCONOJ.FKFCADOPHIE> ECOFMFGFOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public JMJAGLIJMHJ<AGIKIOCONOJ.FKFCADOPHIE, AGIKIOCONOJ.NGOOOFOBPGD> CKACIFDBFBI;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x203C110", Offset = "0x203A710", VA = "0x18203C110")]
	private EAIHJFJBHEP([In] JMJAGLIJMHJ<ALFNFGCIOCL, NIKEPNMEFKP> HBAHAFEIFCB, [In] DLGAHFMKIEB<AGIKIOCONOJ.FKFCADOPHIE> HNJKNOHKKDP, [In] JMJAGLIJMHJ<AGIKIOCONOJ.FKFCADOPHIE, AGIKIOCONOJ.NGOOOFOBPGD> ONDBFKFPGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x203C080", Offset = "0x203A680", VA = "0x18203C080")]
	public static EAIHJFJBHEP HBHGEDOCEKN([In] JMJAGLIJMHJ<ALFNFGCIOCL, NIKEPNMEFKP> HBAHAFEIFCB, [In] DLGAHFMKIEB<AGIKIOCONOJ.FKFCADOPHIE> HNJKNOHKKDP, [In] JMJAGLIJMHJ<AGIKIOCONOJ.FKFCADOPHIE, AGIKIOCONOJ.NGOOOFOBPGD> ONDBFKFPGJI)
	{
		return default(EAIHJFJBHEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class CJCCOHFLPLL
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2039ED0", Offset = "0x20384D0", VA = "0x182039ED0")]
	public static void AMMOOILDICF(this EAIHJFJBHEP ELMHNMGFNPC, [In] ODKJEIKNABL HBJLBBPBJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x203A2E0", Offset = "0x20388E0", VA = "0x18203A2E0")]
	public static void EBAEMACHMLC(this EAIHJFJBHEP ELMHNMGFNPC, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, [In] NIKEPNMEFKP CEAMJPPFFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x203A340", Offset = "0x2038940", VA = "0x18203A340")]
	public static void OCKLLMDPOLJ(this EAIHJFJBHEP ELMHNMGFNPC, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA, [In] ODKJEIKNABL HBJLBBPBJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x203A270", Offset = "0x2038870", VA = "0x18203A270")]
	public static NIKEPNMEFKP BJJBEHDKBAF([In] this EAIHJFJBHEP ELMHNMGFNPC, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return default(NIKEPNMEFKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2039E60", Offset = "0x2038460", VA = "0x182039E60")]
	public static NIKEPNMEFKP AFEDJHKBJAG(this EAIHJFJBHEP ELMHNMGFNPC, EJDMOINMPCI<ALFNFGCIOCL> LNGDAHFHINA)
	{
		return default(NIKEPNMEFKP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class OCHAGHAIKAL : JLOMOFJGAJH<OCHAGHAIKAL, FCGFBJAACMM>
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x2047C00", Offset = "0x2046200", VA = "0x182047C00")]
	private OCHAGHAIKAL([In] PKNCMADMAHA<JLGGEKEAIFI, EFLGBOKOFAJ<FCGFBJAACMM>> HHNOJBFLNGF, [In] PKNCMADMAHA<PPNKDIOKKPB, EDJLMOLODMH<FCGFBJAACMM>> CADLDAMHLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x2047B30", Offset = "0x2046130", VA = "0x182047B30")]
	public static OCHAGHAIKAL NKOJKFHACJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2047AB0", Offset = "0x20460B0", VA = "0x182047AB0")]
	public new (JCKMAGOBPCF<JLGGEKEAIFI, EFLGBOKOFAJ<FCGFBJAACMM>>, JCKMAGOBPCF<PPNKDIOKKPB, EDJLMOLODMH<FCGFBJAACMM>>) EHGEMLAEOMA()
	{
		return default((JCKMAGOBPCF<JLGGEKEAIFI, EFLGBOKOFAJ<FCGFBJAACMM>>, JCKMAGOBPCF<PPNKDIOKKPB, EDJLMOLODMH<FCGFBJAACMM>>));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class OADMEHLBNPF : JGOBPFLFGDM
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x20477E0", Offset = "0x2045DE0", VA = "0x1820477E0", Slot = "7")]
	public override string DLMCGACMBKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2047810", Offset = "0x2045E10", VA = "0x182047810")]
	public OADMEHLBNPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface HNOLJOFDEMA
{
	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HHANDHIMCMH<object, LOIFPCPCONK>> AKNMCHDNJKK(HAFPKGJPPHJ IJDJHMGAIOM, bool BFIJDAFDCIO);
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
