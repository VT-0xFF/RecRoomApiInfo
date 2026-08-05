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
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		[Cpp2IlInjected.Address(RVA = "0x204EDB0", Offset = "0x204D3B0", VA = "0x18204EDB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8917F0", Offset = "0x88FDF0", VA = "0x1808917F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x891830", Offset = "0x88FE30", VA = "0x180891830")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BJNCHBOAOOA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x202F110", Offset = "0x202D710", VA = "0x18202F110")]
	public static bool KKHFHODDCEP(this MBGGCGEEENC GOAECDHCJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x202F050", Offset = "0x202D650", VA = "0x18202F050")]
	public static bool KKHFHODDCEP(this FHMJCGPANEN ELAIAPBCPPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BJOCNHKJCEG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	AJNGKLOBPDA? FLGMCBGEDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class OGDEHGFHMHF
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x204F200", Offset = "0x204D800", VA = "0x18204F200")]
	internal static ICCDGPHNGEH FLGMCBGEDOL(this BJOCNHKJCEG HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x204F040", Offset = "0x204D640", VA = "0x18204F040")]
	internal static CBDPDIPONCF<ICCDGPHNGEH, FOFAIHFKFIO> EICMDDHJHMI(this BJOCNHKJCEG HLIDMKMINHN)
	{
		return default(CBDPDIPONCF<ICCDGPHNGEH, FOFAIHFKFIO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public readonly struct AJNGKLOBPDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal readonly ICCDGPHNGEH FLGMCBGEDOL;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
	public AJNGKLOBPDA(ICCDGPHNGEH PPGPMDCCHNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class NCNKAAFGGFN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2CD12D0", Offset = "0x2CCF8D0", VA = "0x182CD12D0")]
	public static LCNOMMPGMCL<LKJBELODGDI, EIJGBFLAMII, TRoot, JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, TRoot>> GGDNNJLGCEJ<TRoot>([In] this LCNOMMPGMCL<LKJBELODGDI, EIJGBFLAMII, TRoot, JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, TRoot>> PMFDAEILHAJ) where TRoot : BJOCNHKJCEG
	{
		return default(LCNOMMPGMCL<LKJBELODGDI, EIJGBFLAMII, TRoot, JJGBIGJGLEO.DCMFKDFHIDD<LKJBELODGDI, EIJGBFLAMII, TRoot>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public readonly struct EDBAHDNNLHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct OHLMNOAEDCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly PLCHFMGPMPF EGCCOKJIONM;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x958AF0", Offset = "0x9570F0", VA = "0x180958AF0")]
		public OHLMNOAEDCB(PLCHFMGPMPF LGGGFEEKDDL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct DJEBJLEOGII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CGBGMGFBCKF<LPCIIGCGGHE> JJIFGMMOMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CGBGMGFBCKF<LPCIIGCGGHE> OAEKMGNEBNP;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x20394F0", Offset = "0x2037AF0", VA = "0x1820394F0")]
		public static DJEBJLEOGII ENFOKLPNHAF(ELJALLGANLE<ICCDGPHNGEH> KBGKGFGIBGL)
		{
			return default(DJEBJLEOGII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct FMPDBFHBJFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public CGBGMGFBCKF<DLDOKKGNCJH> AHACAEONBPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CGBGMGFBCKF<DLDOKKGNCJH> PNMCOFNKDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public CGBGMGFBCKF<DLDOKKGNCJH> CHJOOKODEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CGBGMGFBCKF<DLDOKKGNCJH> OPDKBDGDBIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CGBGMGFBCKF<DLDOKKGNCJH> HPIOJFDFBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public CGBGMGFBCKF<DLDOKKGNCJH> GFFPJINBDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public CGBGMGFBCKF<DLDOKKGNCJH> PDDHHENJIAA;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x203B760", Offset = "0x2039D60", VA = "0x18203B760")]
		public static FMPDBFHBJFN ENFOKLPNHAF(IGPENLMCIBA<ICCDGPHNGEH> KBGKGFGIBGL)
		{
			return default(FMPDBFHBJFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class IMJIOLNEFNN
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static Dictionary<CGBGMGFBCKF<EALEHCMCLJJ>, JMBJGMPHAJG> CKJKBEEMBGC;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> NGHCGFLIPPC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> CCAFAANMCNA;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> FEBFNBKIJNE;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> IDJMOKAFDCH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> ELPMOOBMMKK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> OJFJMIFOFPI;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> HMFOAFECBNN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> EGPGMKPFGAK;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> PFMGGJNELNM;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> PNOBGAFMCOD;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> KDNKEEPFMNB;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> EFFELDMEKFN;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> MJOMHLDIBDI;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> MAJNOFNGHFO;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> KMDNKCFHILI;

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> NFBDJELNCAK;

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> OIGMGGKPNND;

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> FMIJPEFPGPM;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> NNJCFIMEMLO;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> CKKNOKNFDLM;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> DILFBDFEMLA;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> HIEHAHEFBOJ;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> DKLPMCFKLPO;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> MBOKLHLKGPB;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> NHDBGFFLHKD;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> HIJNCIKDMJG;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> DAEOCGCMNND;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> CDBCJCPBOGH;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> EGNMOLCDFEO;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> JMIDALJILIN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> ENKCHFDBDIJ;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> FJOJGKNIPEH;

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> PGJENCGACBP;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> ELOMCHKILDN;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> AJOCLNHIFML;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> EMDCMLIBMLM;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> BNALIJJLLOA;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> KBBECPKBOJE;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> HDKJGODLIKO;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> MEAKIPEBJEP;

		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> NIMMGFHHFLC;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> FLKJFCHDOAF;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> MPLLOAIAJBM;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> OJMGFIFFEOD;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> JHFFNCGEHDH;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> PHGAGNOJHHP;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> DPBCBAKMIJF;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> PLLOEHCAPGM;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> NKCNIBBKIBM;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> FBGIDCGHADF;

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> KNHPEPKEJOE;

		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> DNPBMGLPJFI;

		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> EHADDKOFKMH;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> CJGNAAJPPFM;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> PMAJBJKINOO;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> MDFEFHGDOKK;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly CGBGMGFBCKF<EALEHCMCLJJ> DPAHGGNGEFJ;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x20418F0", Offset = "0x203FEF0", VA = "0x1820418F0")]
		public static JMBJGMPHAJG PIKFFJALMDD(CGBGMGFBCKF<EALEHCMCLJJ> DAIJJLLIENA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x20417D0", Offset = "0x203FDD0", VA = "0x1820417D0")]
		public static bool LLKMMEEDFBJ(CGBGMGFBCKF<EALEHCMCLJJ> DAIJJLLIENA, [Out] JMBJGMPHAJG OAEOHPPPEKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2041720", Offset = "0x203FD20", VA = "0x182041720")]
		public static MBGGCGEEENC CDOCOELOGNB(CGBGMGFBCKF<EALEHCMCLJJ> DAIJJLLIENA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2041860", Offset = "0x203FE60", VA = "0x182041860")]
		private static CGBGMGFBCKF<EALEHCMCLJJ> NECNOABNHFL(JMBJGMPHAJG OAEOHPPPEKA, CGBGMGFBCKF<EALEHCMCLJJ> DAIJJLLIENA)
		{
			return default(CGBGMGFBCKF<EALEHCMCLJJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class DEBJOLFLAJH
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class GPCPMFBGHDL : IEnumerable<MBGGCGEEENC>, IEnumerable, IEnumerator<MBGGCGEEENC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private MBGGCGEEENC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private FMLMFCLNNJC roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public FMLMFCLNNJC <>3__roomVersion;

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
			private MBGGCGEEENC System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8BEBB0", Offset = "0x8BD1B0", VA = "0x1808BEBB0")]
			[DebuggerHidden]
			public GPCPMFBGHDL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x203C1A0", Offset = "0x203A7A0", VA = "0x18203C1A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x203D9F0", Offset = "0x203BFF0", VA = "0x18203D9F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x203D940", Offset = "0x203BF40", VA = "0x18203D940", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MBGGCGEEENC> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x203D940", Offset = "0x203BF40", VA = "0x18203D940", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private sealed class IMIMAAJECPA : IEnumerable<MBGGCGEEENC>, IEnumerable, IEnumerator<MBGGCGEEENC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private MBGGCGEEENC <>2__current;

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
			private FMLMFCLNNJC roomVersion;

			[Cpp2IlInjected.FieldOffset(Offset = "0x27")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public FMLMFCLNNJC <>3__roomVersion;

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
			private IEnumerator<MBGGCGEEENC> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private MBGGCGEEENC <circuitType>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			private MBGGCGEEENC System.Collections.Generic.IEnumerator<Circuits.Static.Core.TypeSystem.CircuitType>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x8BEBB0", Offset = "0x8BD1B0", VA = "0x1808BEBB0")]
			[DebuggerHidden]
			public IMIMAAJECPA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x2041690", Offset = "0x203FC90", VA = "0x182041690", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x2041090", Offset = "0x203F690", VA = "0x182041090", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x2041040", Offset = "0x203F640", VA = "0x182041040")]
			private void LEGBLNHPDPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x2041640", Offset = "0x203FC40", VA = "0x182041640", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2041580", Offset = "0x203FB80", VA = "0x182041580", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<MBGGCGEEENC> System.Collections.Generic.IEnumerable<Circuits.Static.Core.TypeSystem.CircuitType>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x2041580", Offset = "0x203FB80", VA = "0x182041580", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public static readonly FHMJCGPANEN AOGIENJIKEJ;

		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public static readonly FHMJCGPANEN FGAGILLBOLF;

		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private static readonly HashSet<MBGGCGEEENC> CCBNAICFHFI;

		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public static List<MBGGCGEEENC> OEKGJEABPFD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static NJBGOHGCOOF JHMCCGDOLHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8FC7E0", Offset = "0x8FADE0", VA = "0x1808FC7E0")]
			get
			{
				return default(NJBGOHGCOOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static MBGGCGEEENC PDAOFLBBEBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2031CC0", Offset = "0x20302C0", VA = "0x182031CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public static MBGGCGEEENC NDLFIGFIFDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2032190", Offset = "0x2030790", VA = "0x182032190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static MBGGCGEEENC BDCMFACHJCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2031320", Offset = "0x202F920", VA = "0x182031320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static MBGGCGEEENC CEIAPPHBGON
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2030490", Offset = "0x202EA90", VA = "0x182030490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static MBGGCGEEENC BEKANBEBNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2031F00", Offset = "0x2030500", VA = "0x182031F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static MBGGCGEEENC KCFGBAPLDGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2030890", Offset = "0x202EE90", VA = "0x182030890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static MBGGCGEEENC KIJOGFACEGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x202FDF0", Offset = "0x202E3F0", VA = "0x18202FDF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static MBGGCGEEENC HANMNBOADJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2030520", Offset = "0x202EB20", VA = "0x182030520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static BDDEKEDNAJK CLJLPFGABDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2032BA0", Offset = "0x20311A0", VA = "0x182032BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static BDDEKEDNAJK BJGEFDCENME
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2030E20", Offset = "0x202F420", VA = "0x182030E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static BDDEKEDNAJK LKCOBHGCMCH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x20316B0", Offset = "0x202FCB0", VA = "0x1820316B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static BDDEKEDNAJK BIBBCACIKNO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2032A90", Offset = "0x2031090", VA = "0x182032A90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static BDDEKEDNAJK GELNDPAOGPF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x2031050", Offset = "0x202F650", VA = "0x182031050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static BDDEKEDNAJK AFNABIEKMBO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x20305B0", Offset = "0x202EBB0", VA = "0x1820305B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static BDDEKEDNAJK KEKJLNCGACG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2031270", Offset = "0x202F870", VA = "0x182031270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static BDDEKEDNAJK MPPNOEDGDMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2031E00", Offset = "0x2030400", VA = "0x182031E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static BDDEKEDNAJK JDAKJCNLBND
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2032720", Offset = "0x2030D20", VA = "0x182032720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static BDDEKEDNAJK LBCBLJIDFNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x20307E0", Offset = "0x202EDE0", VA = "0x1820307E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static BDDEKEDNAJK HIKKKFAIGJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2031DB0", Offset = "0x20303B0", VA = "0x182031DB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static BDDEKEDNAJK CMNDEPBBDPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x2032220", Offset = "0x2030820", VA = "0x182032220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static BDDEKEDNAJK HMLMNHFPCKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x2030120", Offset = "0x202E720", VA = "0x182030120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static BDDEKEDNAJK HMHIEPOMODL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2031C70", Offset = "0x2030270", VA = "0x182031C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public static BDDEKEDNAJK IFDGJHNMGDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2031E50", Offset = "0x2030450", VA = "0x182031E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static BDDEKEDNAJK DNHLNJGPAGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2032110", Offset = "0x2030710", VA = "0x182032110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public static BDDEKEDNAJK OGOMBFBOLMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x2030F30", Offset = "0x202F530", VA = "0x182030F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static BDDEKEDNAJK NIHBGIHCHCA
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x2031AF0", Offset = "0x20300F0", VA = "0x182031AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static BDDEKEDNAJK HOKMKOCDKGL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x2031D50", Offset = "0x2030350", VA = "0x182031D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public static BDDEKEDNAJK BECMHHMEDLG
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x20313B0", Offset = "0x202F9B0", VA = "0x1820313B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public static BDDEKEDNAJK OJPCJFMEBPD
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x2030060", Offset = "0x202E660", VA = "0x182030060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public static BDDEKEDNAJK EBNIMJKIKHK
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x2030830", Offset = "0x202EE30", VA = "0x182030830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static BDDEKEDNAJK JDAIIHHNBGE
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x2030F90", Offset = "0x202F590", VA = "0x182030F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static BDDEKEDNAJK FHIICBBDDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x2031940", Offset = "0x202FF40", VA = "0x182031940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public static BDDEKEDNAJK EHAICPBIBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x2031410", Offset = "0x202FA10", VA = "0x182031410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static BDDEKEDNAJK CIMACHMPAFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x2031650", Offset = "0x202FC50", VA = "0x182031650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static BDDEKEDNAJK ILALBCHNDGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x20311B0", Offset = "0x202F7B0", VA = "0x1820311B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static BDDEKEDNAJK MFJGNDJNGAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x2032800", Offset = "0x2030E00", VA = "0x182032800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static BDDEKEDNAJK LPNDGFCKEKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2032980", Offset = "0x2030F80", VA = "0x182032980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static BDDEKEDNAJK BCDGBGNOCFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2032050", Offset = "0x2030650", VA = "0x182032050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static BDDEKEDNAJK NEEOMDJHKGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x2030000", Offset = "0x202E600", VA = "0x182030000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static BDDEKEDNAJK DCBDBJABPIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x2031C10", Offset = "0x2030210", VA = "0x182031C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static BDDEKEDNAJK GECHCLMCPNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x20326C0", Offset = "0x2030CC0", VA = "0x1820326C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static BDDEKEDNAJK NIKHKHBPFNB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x2030720", Offset = "0x202ED20", VA = "0x182030720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static BDDEKEDNAJK ADCDMHKFEGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x202FFA0", Offset = "0x202E5A0", VA = "0x18202FFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static BDDEKEDNAJK LFEGKOEHABI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x20306C0", Offset = "0x202ECC0", VA = "0x1820306C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public static BDDEKEDNAJK BOBECFAHENE
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x2031820", Offset = "0x202FE20", VA = "0x182031820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public static BDDEKEDNAJK KDBABGGPOJC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x202FEE0", Offset = "0x202E4E0", VA = "0x18202FEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public static BDDEKEDNAJK DIPCGBDKLGA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2030350", Offset = "0x202E950", VA = "0x182030350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static BDDEKEDNAJK IPLIPAHFJFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2032270", Offset = "0x2030870", VA = "0x182032270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static BDDEKEDNAJK BPGDGNKPIHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x2032860", Offset = "0x2030E60", VA = "0x182032860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public static BDDEKEDNAJK EPBLDEOLPNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x2031EA0", Offset = "0x20304A0", VA = "0x182031EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static BDDEKEDNAJK MKCGOFOLCOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x20319A0", Offset = "0x202FFA0", VA = "0x1820319A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public static BDDEKEDNAJK LACFBJKBJDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x20317C0", Offset = "0x202FDC0", VA = "0x1820317C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static BDDEKEDNAJK LPBPFNPFBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x2030E70", Offset = "0x202F470", VA = "0x182030E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static BDDEKEDNAJK DDNLJMPAANP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2031B50", Offset = "0x2030150", VA = "0x182031B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static BDDEKEDNAJK DMMPBOIOFHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2032B40", Offset = "0x2031140", VA = "0x182032B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static BDDEKEDNAJK CBFJDOODIHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x2031880", Offset = "0x202FE80", VA = "0x182031880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public static BDDEKEDNAJK PKJAMDAFPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x2031BB0", Offset = "0x20301B0", VA = "0x182031BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static BDDEKEDNAJK ANAANNHEKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x20324C0", Offset = "0x2030AC0", VA = "0x1820324C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static BDDEKEDNAJK MLKOJJPNNIP
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x2030230", Offset = "0x202E830", VA = "0x182030230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static BDDEKEDNAJK AFJIKHIACMB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x20302F0", Offset = "0x202E8F0", VA = "0x1820302F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public static BDDEKEDNAJK LAIENINKMLP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x2030D60", Offset = "0x202F360", VA = "0x182030D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public static BDDEKEDNAJK EKHIABHPFPF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x2031210", Offset = "0x202F810", VA = "0x182031210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public static BDDEKEDNAJK LMJNMPADFOD
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x20322D0", Offset = "0x20308D0", VA = "0x1820322D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public static BDDEKEDNAJK GMPKINNJFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x20318E0", Offset = "0x202FEE0", VA = "0x1820318E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public static BDDEKEDNAJK GFLELMDDJED
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x2030780", Offset = "0x202ED80", VA = "0x182030780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public static BDDEKEDNAJK DDDJPBCGCNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x20312C0", Offset = "0x202F8C0", VA = "0x1820312C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public static BDDEKEDNAJK IPPMCFBGCAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x20320B0", Offset = "0x20306B0", VA = "0x1820320B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public static BDDEKEDNAJK KDEPDMFJMAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x2031530", Offset = "0x202FB30", VA = "0x182031530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public static BDDEKEDNAJK GNHNEBAOMCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x20327A0", Offset = "0x2030DA0", VA = "0x1820327A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public static BDDEKEDNAJK IGEKLDIMMFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x2030290", Offset = "0x202E890", VA = "0x182030290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public static BDDEKEDNAJK LIDOCDKGCJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x2032460", Offset = "0x2030A60", VA = "0x182032460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public static BDDEKEDNAJK CEKDHCHKIJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x202FF40", Offset = "0x202E540", VA = "0x18202FF40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public static BDDEKEDNAJK ECJDNCKCCFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2030600", Offset = "0x202EC00", VA = "0x182030600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public static BDDEKEDNAJK OMKCAGLGDJC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2032520", Offset = "0x2030B20", VA = "0x182032520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public static BDDEKEDNAJK PAAKPJOFHBG
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x2031470", Offset = "0x202FA70", VA = "0x182031470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public static BDDEKEDNAJK GBIPHEFDCBO
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x2031F90", Offset = "0x2030590", VA = "0x182031F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public static BDDEKEDNAJK OIOFPHOICJK
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x2030DC0", Offset = "0x202F3C0", VA = "0x182030DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public static BDDEKEDNAJK DODPJDMPEJF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x2032920", Offset = "0x2030F20", VA = "0x182032920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public static BDDEKEDNAJK EFIGBNKPCBB
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x20315F0", Offset = "0x202FBF0", VA = "0x1820315F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public static BDDEKEDNAJK HEMFACCOPBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2030430", Offset = "0x202EA30", VA = "0x182030430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public static BDDEKEDNAJK LLMGOJOEPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2032660", Offset = "0x2030C60", VA = "0x182032660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public static BDDEKEDNAJK EJCLNJOEAOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x20314D0", Offset = "0x202FAD0", VA = "0x1820314D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public static BDDEKEDNAJK NHGKHPOGLMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x2031FF0", Offset = "0x20305F0", VA = "0x182031FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public static BDDEKEDNAJK LAEJKGBMAKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x20301D0", Offset = "0x202E7D0", VA = "0x1820301D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public static BDDEKEDNAJK OPMOEACGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x2031150", Offset = "0x202F750", VA = "0x182031150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public static BDDEKEDNAJK DMADEIAFIHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x2030920", Offset = "0x202EF20", VA = "0x182030920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public static BDDEKEDNAJK JMAJODGJPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x20300C0", Offset = "0x202E6C0", VA = "0x1820300C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public static BDDEKEDNAJK EKONHNKGEGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x202FE80", Offset = "0x202E480", VA = "0x18202FE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public static BDDEKEDNAJK NDIHDKKPFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x2030ED0", Offset = "0x202F4D0", VA = "0x182030ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public static BDDEKEDNAJK ALBIGHDGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x2030FF0", Offset = "0x202F5F0", VA = "0x182030FF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public static BDDEKEDNAJK CKEEDCLNDCH
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x2031590", Offset = "0x202FB90", VA = "0x182031590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static BDDEKEDNAJK IDDEMKNMICL
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x2030170", Offset = "0x202E770", VA = "0x182030170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public static BDDEKEDNAJK EMOKFCIMLLM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x2031700", Offset = "0x202FD00", VA = "0x182031700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public static BDDEKEDNAJK EHBENJLNGDP
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x2031760", Offset = "0x202FD60", VA = "0x182031760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public static BDDEKEDNAJK EGJHCEJNLAO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x2030D00", Offset = "0x202F300", VA = "0x182030D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public static BDDEKEDNAJK CMHFHPMMLFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x20328C0", Offset = "0x2030EC0", VA = "0x1820328C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public static BDDEKEDNAJK GNPCGPHEBPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x2030660", Offset = "0x202EC60", VA = "0x182030660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public static BDDEKEDNAJK KKNOKBCOOCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x2032AE0", Offset = "0x20310E0", VA = "0x182032AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2031A00", Offset = "0x2030000", VA = "0x182031A00")]
		public static FHMJCGPANEN JNGBMHPCIAL([In] MKIOPDNMALE HHLLKDHLING)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2032580", Offset = "0x2030B80", VA = "0x182032580")]
		public static GBEPMKLPKEA NLIFOHPDBME(string DAIJJLLIENA, [Optional] string GJEDHMJMNJA)
		{
			return default(GBEPMKLPKEA);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2032630", Offset = "0x2030C30", VA = "0x182032630")]
		public static GBEPMKLPKEA NLIFOHPDBME([Optional][In] Guid? DAIJJLLIENA, [Optional] string GJEDHMJMNJA)
		{
			return default(GBEPMKLPKEA);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2032770", Offset = "0x2030D70", VA = "0x182032770")]
		public static FHMJCGPANEN OFGIFOMOHOC(params MKIOPDNMALE[] LFIJBJGDKFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2032160", Offset = "0x2030760", VA = "0x182032160")]
		public static FHMJCGPANEN MKIMGOPHICP(params MKIOPDNMALE[] LFIJBJGDKFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2032330", Offset = "0x2030930", VA = "0x182032330")]
		public static FHMJCGPANEN NINCGMODIJJ([In] MKIOPDNMALE HHLLKDHLING)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2032BF0", Offset = "0x20311F0", VA = "0x182032BF0")]
		static DEBJOLFLAJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x20329E0", Offset = "0x2030FE0", VA = "0x1820329E0")]
		[IteratorStateMachine(typeof(GPCPMFBGHDL))]
		private static IEnumerable<MBGGCGEEENC> OPGLNBPMFOB(FMLMFCLNNJC GGIELKFPGAC, bool ABLDJNLDHEM, bool FMJCNGAJNGL, bool KHKLNEDBGEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x20310A0", Offset = "0x202F6A0", VA = "0x1820310A0")]
		[IteratorStateMachine(typeof(IMIMAAJECPA))]
		public static IEnumerable<MBGGCGEEENC> GBADFGIBGLM(FMLMFCLNNJC GGIELKFPGAC, bool GMMEANDEEKJ, bool ABLDJNLDHEM, bool FMJCNGAJNGL, bool KHKLNEDBGEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2030980", Offset = "0x202EF80", VA = "0x182030980")]
		public static EFGALINGOPJ EHMLMCOFLMB(MBGGCGEEENC GOAECDHCJMK)
		{
			return default(EFGALINGOPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2030B10", Offset = "0x202F110", VA = "0x182030B10")]
		public static EFGALINGOPJ EJHEEGFHEKE(MBGGCGEEENC GOAECDHCJMK)
		{
			return default(EFGALINGOPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x20303B0", Offset = "0x202E9B0", VA = "0x1820303B0")]
		public static bool CGDNNILJHBB(MBGGCGEEENC GOAECDHCJMK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly FMPDBFHBJFN NGEKAEDBOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly DJEBJLEOGII LHBHDCIPMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly GBHAABHCALK<DLDOKKGNCJH, PGHGNJOIEOA<ICCDGPHNGEH>> DEJAPCPOMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly GBHAABHCALK<LPCIIGCGGHE, MLNGDBLFLHB<ICCDGPHNGEH>> GNHDDGOOHEB;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x203A190", Offset = "0x2038790", VA = "0x18203A190")]
	private EDBAHDNNLHP([In] FMPDBFHBJFN BGMKDHODHKC, [In] DJEBJLEOGII KPMPIONCKKA, GBHAABHCALK<DLDOKKGNCJH, PGHGNJOIEOA<ICCDGPHNGEH>> JNMGMNKMJKD, GBHAABHCALK<LPCIIGCGGHE, MLNGDBLFLHB<ICCDGPHNGEH>> NPCFMPIHOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2039950", Offset = "0x2037F50", VA = "0x182039950")]
	public static EDBAHDNNLHP ENFOKLPNHAF()
	{
		return default(EDBAHDNNLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2039C60", Offset = "0x2038260", VA = "0x182039C60")]
	public static void IHOPKBJIMEI([In] EDBAHDNNLHP HLIDMKMINHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2039940", Offset = "0x2037F40", VA = "0x182039940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x203A0B0", Offset = "0x20386B0", VA = "0x18203A0B0")]
	public static MHLJFLNIGDL<ICCDGPHNGEH> LPCBCJLEKIC([In] EDBAHDNNLHP HLIDMKMINHN, [In] BDIECDJCIAI CHHNPBAHHIF, [In] GPOKAFLOGOI MNIEIPOGAJB)
	{
		return default(MHLJFLNIGDL<ICCDGPHNGEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2039AD0", Offset = "0x20380D0", VA = "0x182039AD0")]
	public static ICCDGPHNGEH GFBKBKMJDIM([In] EDBAHDNNLHP HLIDMKMINHN, [In] GHBLLNOLCAB AEGNIAEOIOB, [In] MHLJFLNIGDL<ICCDGPHNGEH> JJIILPFEIBK, [In] BHEFGPNDOIC GFHDGOJABKI, CGBGMGFBCKF<NPIPKFBHIBO> FKINMOKINKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class ICCDGPHNGEH : EJOGHEMMFNF, ONMKANNJPPJ<ICCDGPHNGEH>, ECODEOLNOGK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public readonly EDBAHDNNLHP CDJIAIPNJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private GHBLLNOLCAB BBNGGJKLLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private MHLJFLNIGDL<ICCDGPHNGEH> LKBHPJCNBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private BHEFGPNDOIC OGKFEBKHCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> DCPFAFGFMFK;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2040B90", Offset = "0x203F190", VA = "0x182040B90")]
	private ICCDGPHNGEH([In] EDBAHDNNLHP KKCNEBNFMMC, [In] GHBLLNOLCAB FJAFNPDPNGE, [In] MHLJFLNIGDL<ICCDGPHNGEH> JJIILPFEIBK, [In] BHEFGPNDOIC GFHDGOJABKI, CGBGMGFBCKF<NPIPKFBHIBO> KFDLPDMPHDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2039AD0", Offset = "0x20380D0", VA = "0x182039AD0")]
	public static ICCDGPHNGEH HMMGBDOMNOE([In] EDBAHDNNLHP KKCNEBNFMMC, [In] GHBLLNOLCAB FJAFNPDPNGE, [In] MHLJFLNIGDL<ICCDGPHNGEH> JJIILPFEIBK, [In] BHEFGPNDOIC GFHDGOJABKI, CGBGMGFBCKF<NPIPKFBHIBO> KFDLPDMPHDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x203EAD0", Offset = "0x203D0D0", VA = "0x18203EAD0", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x200E090", Offset = "0x200C690", VA = "0x18200E090", Slot = "8")]
	public MHLJFLNIGDL<ICCDGPHNGEH> JDPLKEHEOFL()
	{
		return default(MHLJFLNIGDL<ICCDGPHNGEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x200E0A0", Offset = "0x200C6A0", VA = "0x18200E0A0")]
	public GHBLLNOLCAB LNGECNEPHKA()
	{
		return default(GHBLLNOLCAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3930", Offset = "0x2BC1F30", VA = "0x182BC3930")]
	public CGBGMGFBCKF<TMVirt> NKDJGFAADDB<TMVirt>(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA) where TMVirt : DGFNMDLPMKC.IPDJOIBLBGJ
	{
		return default(CGBGMGFBCKF<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3730", Offset = "0x2BC1D30", VA = "0x182BC3730")]
	public CGBGMGFBCKF<TMVirt> LEJNPKBCBLA<TMVirt>(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB) where TMVirt : LEDDBICJHIN.NJHLIAMJFFF
	{
		return default(CGBGMGFBCKF<TMVirt>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x203EC40", Offset = "0x203D240", VA = "0x18203EC40")]
	internal BDIECDJCIAI HHLOOLIFFAF()
	{
		return default(BDIECDJCIAI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x203EC00", Offset = "0x203D200", VA = "0x18203EC00")]
	internal GPOKAFLOGOI GLCKAHCKIDL()
	{
		return default(GPOKAFLOGOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x200E090", Offset = "0x200C690", VA = "0x18200E090")]
	internal MHLJFLNIGDL<ICCDGPHNGEH> NELJPFDCBKL()
	{
		return default(MHLJFLNIGDL<ICCDGPHNGEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x200E0A0", Offset = "0x200C6A0", VA = "0x18200E0A0")]
	internal GHBLLNOLCAB EGEMJPFKLEK()
	{
		return default(GHBLLNOLCAB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x203EC80", Offset = "0x203D280", VA = "0x18203EC80")]
	internal BHEFGPNDOIC IKOEKDIHJIH()
	{
		return default(BHEFGPNDOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x2BC36C0", Offset = "0x2BC1CC0", VA = "0x182BC36C0")]
	public void JGBHMDJNIBD<TMVirt>(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<TMVirt> JPBKLMCKMLK) where TMVirt : DGFNMDLPMKC.IPDJOIBLBGJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3860", Offset = "0x2BC1E60", VA = "0x182BC3860")]
	public void MGNPEIGLACD<TMVirt>(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<TMVirt> JPBKLMCKMLK) where TMVirt : LEDDBICJHIN.NJHLIAMJFFF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x203EB50", Offset = "0x203D150", VA = "0x18203EB50", Slot = "9")]
	public HBJJGGBGKJD EOAHPJBLEAP()
	{
		return default(HBJJGGBGKJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x203EB90", Offset = "0x203D190", VA = "0x18203EB90", Slot = "10")]
	public EFGALINGOPJ GHEJLMPIPDF(MBGGCGEEENC GOAECDHCJMK)
	{
		return default(EFGALINGOPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2040AE0", Offset = "0x203F0E0", VA = "0x182040AE0", Slot = "11")]
	public bool PFGKEKLELIA(MBGGCGEEENC GOAECDHCJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x203E920", Offset = "0x203CF20", VA = "0x18203E920", Slot = "4")]
	private void DDGIDEJKOOE(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, OLHFKDFGMIB CAALNKNJIAB, CGBGMGFBCKF<FCPBGPKMICB.NLBPONGEFLF>? FNPHMPFPJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x203F900", Offset = "0x203DF00", VA = "0x18203F900", Slot = "5")]
	private void KJPOCHPELJD(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x203E890", Offset = "0x203CE90", VA = "0x18203E890", Slot = "6")]
	private void CDLGEAIAGGH(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, OLHFKDFGMIB CAALNKNJIAB, CGBGMGFBCKF<FCPBGPKMICB.NLBPONGEFLF>? FNPHMPFPJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x203EA60", Offset = "0x203D060", VA = "0x18203EA60", Slot = "7")]
	private void DMBKPNHHMIG(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x203DE90", Offset = "0x203C490", VA = "0x18203DE90")]
	internal CBDPDIPONCF<CGBGMGFBCKF<JBMJEMLAFJB>, IFONDHBKBCD> AHACAEONBPJ(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<DLDOKKGNCJH> BMBLGJACLCJ, [In] DHNIBFCDNLJ DJCNMBEIKME, [In] PBDCHDIIPAE CAANIPGJBEP, OLHFKDFGMIB EKBAIBGMFJL, CGBGMGFBCKF<FCPBGPKMICB.NLBPONGEFLF>? MDCNEPNEBCO)
	{
		return default(CBDPDIPONCF<CGBGMGFBCKF<JBMJEMLAFJB>, IFONDHBKBCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x203F9A0", Offset = "0x203DFA0", VA = "0x18203F9A0")]
	internal CGBGMGFBCKF<JBMJEMLAFJB> KOCODCGEMFC(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<DLDOKKGNCJH> BMBLGJACLCJ, [In] DHNIBFCDNLJ DJCNMBEIKME, [In] PBDCHDIIPAE CAANIPGJBEP, OLHFKDFGMIB EKBAIBGMFJL, CGBGMGFBCKF<FCPBGPKMICB.NLBPONGEFLF>? MDCNEPNEBCO)
	{
		return default(CGBGMGFBCKF<JBMJEMLAFJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x203E9D0", Offset = "0x203CFD0", VA = "0x18203E9D0")]
	internal CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> DLLBHPAOHCH(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
		return default(CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3210", Offset = "0x2BC1810", VA = "0x182BC3210")]
	public CBDPDIPONCF<CGBGMGFBCKF<TM>, IFONDHBKBCD> BMPKEMKFAHC<TM>(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<LPCIIGCGGHE> LHBKNLELJNB) where TM : DGFNMDLPMKC.IPDJOIBLBGJ
	{
		return default(CBDPDIPONCF<CGBGMGFBCKF<TM>, IFONDHBKBCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x2BC3440", Offset = "0x2BC1A40", VA = "0x182BC3440")]
	public CBDPDIPONCF<CGBGMGFBCKF<TM>, IFONDHBKBCD> DLKPBBDIHHO<TM>(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<DLDOKKGNCJH> KOGEFMMICBM) where TM : LEDDBICJHIN.NJHLIAMJFFF
	{
		return default(CBDPDIPONCF<CGBGMGFBCKF<TM>, IFONDHBKBCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x203EC90", Offset = "0x203D290", VA = "0x18203EC90")]
	private CBDPDIPONCF<(CGBGMGFBCKF<CCGBPLEEBJE.FAENEPNEPDO>, CGBGMGFBCKF<CFMNGFJNBKJ.LHILKIACOCF>), IFONDHBKBCD> KBCHLNBEOCN(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
		return default(CBDPDIPONCF<(CGBGMGFBCKF<CCGBPLEEBJE.FAENEPNEPDO>, CGBGMGFBCKF<CFMNGFJNBKJ.LHILKIACOCF>), IFONDHBKBCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x203E020", Offset = "0x203C620", VA = "0x18203E020")]
	internal CBDPDIPONCF<(CGBGMGFBCKF<HHDHBHHIDEB>, CGBGMGFBCKF<FELHHAAOOHO>), IFONDHBKBCD> BMNAIJJGECG(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, int AFHHNDIHHIG, [In] BJGJGGGFNAC GOAECDHCJMK)
	{
		return default(CBDPDIPONCF<(CGBGMGFBCKF<HHDHBHHIDEB>, CGBGMGFBCKF<FELHHAAOOHO>), IFONDHBKBCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x203FAA0", Offset = "0x203E0A0", VA = "0x18203FAA0")]
	internal CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> NMMMDFNJJMA(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, int AFHHNDIHHIG)
	{
		return default(CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x203F020", Offset = "0x203D620", VA = "0x18203F020")]
	internal CBDPDIPONCF<(CGBGMGFBCKF<FELHHAAOOHO>, CGBGMGFBCKF<HHDHBHHIDEB>), IFONDHBKBCD> KEECFPLAPBJ(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, int GMIICDFKBBD, [In] BJGJGGGFNAC GOAECDHCJMK)
	{
		return default(CBDPDIPONCF<(CGBGMGFBCKF<FELHHAAOOHO>, CGBGMGFBCKF<HHDHBHHIDEB>), IFONDHBKBCD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x20402A0", Offset = "0x203E8A0", VA = "0x1820402A0")]
	internal CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> ONLBCLJOKEB(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, int GMIICDFKBBD)
	{
		return default(CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct BHEFGPNDOIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public ODKHIEPFOPO<CFMNGFJNBKJ.LHILKIACOCF, PAENECJPGGE> PKDHCFHMLIE;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FABA70", Offset = "0x1FAA070", VA = "0x181FABA70")]
	private BHEFGPNDOIC([In] ODKHIEPFOPO<CFMNGFJNBKJ.LHILKIACOCF, PAENECJPGGE> HGJHMKOOIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x202EC30", Offset = "0x202D230", VA = "0x18202EC30")]
	public static BHEFGPNDOIC ENFOKLPNHAF()
	{
		return default(BHEFGPNDOIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class JKMCIBCIIBL
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2045EB0", Offset = "0x20444B0", VA = "0x182045EB0")]
	public static void IHOPKBJIMEI(this BHEFGPNDOIC HLIDMKMINHN, [In] CFOCJPIHMCC<CFMNGFJNBKJ.LHILKIACOCF> LEPGOBBPFCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FBBKADMFIGF
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x203B470", Offset = "0x2039A70", VA = "0x18203B470")]
	public static EHHGJCHGBMN PEGIGFCKLEH(ICCDGPHNGEH JJIILPFEIBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x203AD30", Offset = "0x2039330", VA = "0x18203AD30")]
	public static EHHGJCHGBMN EBMKNIHBHOJ(CGBGMGFBCKF<LPCIIGCGGHE> HAABBCPEFAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MCHKOKICGAI
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x204DA00", Offset = "0x204C000", VA = "0x18204DA00")]
	public static GBNIAEOAGIK PEGIGFCKLEH(this MBGGCGEEENC GOAECDHCJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x204CE40", Offset = "0x204B440", VA = "0x18204CE40")]
	public static MBGGCGEEENC OJPHNAHFOOE(this GBNIAEOAGIK GOAECDHCJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class AIHKMDCPJNF
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x324FAA0", Offset = "0x324E0A0", VA = "0x18324FAA0")]
	public static Dictionary<TDeserializedKey, TDeserializedValue> GBFMADPOKFB<TDeserializedKey, TDeserializedValue, TSerialized>(this RepeatedField<TSerialized> EABGAFLLHMP, Func<TSerialized, TDeserializedKey> PNFGAHJFFFK, Func<TSerialized, TDeserializedValue> PAONDBIOAPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class JEGGEJBKFCE
{
	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2044DA0", Offset = "0x20433A0", VA = "0x182044DA0")]
	public static BLEHBOKDKIN PEGIGFCKLEH([In] this DGFNMDLPMKC HLIDMKMINHN, [In] PAKFBCGAJOM BBOKFOJNMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2044690", Offset = "0x2042C90", VA = "0x182044690")]
	public static DGFNMDLPMKC OJPHNAHFOOE(this BLEHBOKDKIN HLIDMKMINHN, [In] PAKFBCGAJOM BBOKFOJNMIE)
	{
		return default(DGFNMDLPMKC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PGHJNGKOJMK
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x204F950", Offset = "0x204DF50", VA = "0x18204F950")]
	public static LPLNDHEJIEJ PEGIGFCKLEH([In] this GPOKAFLOGOI HLIDMKMINHN, [In] BDIECDJCIAI IKEFDAOMGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x204F690", Offset = "0x204DC90", VA = "0x18204F690")]
	public static GPOKAFLOGOI OJPHNAHFOOE(this LPLNDHEJIEJ HLIDMKMINHN, [In] BDIECDJCIAI IKEFDAOMGCG)
	{
		return default(GPOKAFLOGOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class JKBIGBNICOH
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2045CC0", Offset = "0x20442C0", VA = "0x182045CC0")]
	public static DHKOAKLFIHF PEGIGFCKLEH([In] this NCPPOENEOJJ HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2045C10", Offset = "0x2044210", VA = "0x182045C10")]
	public static NCPPOENEOJJ OJPHNAHFOOE(this DHKOAKLFIHF HLIDMKMINHN)
	{
		return default(NCPPOENEOJJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HCLINHMMNFG
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x203DD30", Offset = "0x203C330", VA = "0x18203DD30")]
	public static DBADDAICNHK PEGIGFCKLEH([In] this LEDDBICJHIN HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x203DCB0", Offset = "0x203C2B0", VA = "0x18203DCB0")]
	public static LEDDBICJHIN OJPHNAHFOOE(this DBADDAICNHK HLIDMKMINHN)
	{
		return default(LEDDBICJHIN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MINJCPCCKDM
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x204EBB0", Offset = "0x204D1B0", VA = "0x18204EBB0")]
	public static EKHLHMDJNOA PEGIGFCKLEH([In] this CKGKIIGADAB HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x204EB30", Offset = "0x204D130", VA = "0x18204EB30")]
	public static CKGKIIGADAB OJPHNAHFOOE(this EKHLHMDJNOA HLIDMKMINHN)
	{
		return default(CKGKIIGADAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class CNCPDNLBNPE
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x29BA520", Offset = "0x29B8B20", VA = "0x1829BA520")]
	public static MJJFGBDAIMC PEGIGFCKLEH<TRoot>([In] this MHLJFLNIGDL<TRoot> HLIDMKMINHN) where TRoot : ONMKANNJPPJ<TRoot>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x202F650", Offset = "0x202DC50", VA = "0x18202F650")]
	public static MHLJFLNIGDL<ICCDGPHNGEH> OJPHNAHFOOE(this MJJFGBDAIMC HLIDMKMINHN, [In] EDBAHDNNLHP KKCNEBNFMMC)
	{
		return default(MHLJFLNIGDL<ICCDGPHNGEH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class JCPMFOJIDBP
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2044420", Offset = "0x2042A20", VA = "0x182044420")]
	public static KGALJIJJBJA PEGIGFCKLEH([In] this CFMNGFJNBKJ.JJJAHPDFHIK HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2044120", Offset = "0x2042720", VA = "0x182044120")]
	public static CFMNGFJNBKJ.JJJAHPDFHIK OJPHNAHFOOE(this KGALJIJJBJA HLIDMKMINHN)
	{
		return default(CFMNGFJNBKJ.JJJAHPDFHIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class MCBFBKDBAKB
{
	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x204CDD0", Offset = "0x204B3D0", VA = "0x18204CDD0")]
	public static HDHLKADOICK PEGIGFCKLEH([In] this CCGBPLEEBJE.HGCFGBFLHFN HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x204CD80", Offset = "0x204B380", VA = "0x18204CD80")]
	public static CCGBPLEEBJE.HGCFGBFLHFN OJPHNAHFOOE(this HDHLKADOICK HLIDMKMINHN)
	{
		return default(CCGBPLEEBJE.HGCFGBFLHFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CPNFLFGFGED
{
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x202FBF0", Offset = "0x202E1F0", VA = "0x18202FBF0")]
	public static NPDALCDANHN PEGIGFCKLEH([In] this BDIECDJCIAI HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x202F990", Offset = "0x202DF90", VA = "0x18202F990")]
	public static BDIECDJCIAI OJPHNAHFOOE(this NPDALCDANHN HLIDMKMINHN)
	{
		return default(BDIECDJCIAI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class OBCKKJOMBFM
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x204EED0", Offset = "0x204D4D0", VA = "0x18204EED0")]
	public static NMOPJHLLFGI PEGIGFCKLEH([In] Guid HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x204EE30", Offset = "0x204D430", VA = "0x18204EE30")]
	public static Guid OJPHNAHFOOE(NMOPJHLLFGI HLIDMKMINHN)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class PKLDFLOKKAM
{
	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x204FD00", Offset = "0x204E300", VA = "0x18204FD00")]
	public static NDLMMJIAJFK PEGIGFCKLEH([In] this COCEBODHJKK HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x204FC60", Offset = "0x204E260", VA = "0x18204FC60")]
	public static COCEBODHJKK OJPHNAHFOOE(this NDLMMJIAJFK HLIDMKMINHN)
	{
		return default(COCEBODHJKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class GFJKOAGILEK
{
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x203BA80", Offset = "0x203A080", VA = "0x18203BA80")]
	public static FNCBMMCKGPF PEGIGFCKLEH([In] this BJGJGGGFNAC HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x203BA20", Offset = "0x203A020", VA = "0x18203BA20")]
	public static BJGJGGGFNAC OJPHNAHFOOE(this FNCBMMCKGPF HLIDMKMINHN)
	{
		return default(BJGJGGGFNAC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public static class NONIKKEPMKD
{
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x204ED30", Offset = "0x204D330", VA = "0x18204ED30")]
	public static LKIGJHONICI PEGIGFCKLEH([In] this NDOEPIEPFMN HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x204EC90", Offset = "0x204D290", VA = "0x18204EC90")]
	public static NDOEPIEPFMN OJPHNAHFOOE(this LKIGJHONICI HLIDMKMINHN)
	{
		return default(NDOEPIEPFMN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DCPMCCHGLKB
{
	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x29E63D0", Offset = "0x29E49D0", VA = "0x1829E63D0")]
	public static void APPPKMFAPCC<TDeserialized, TSerialized>(this IReadOnlyCollection<TDeserialized> HLIDMKMINHN, RepeatedField<TSerialized> EABGAFLLHMP, DCAFOLJMGGN<TDeserialized, TSerialized> FINKJMDONNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class JFNOJKJCKAE
{
	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x20457A0", Offset = "0x2043DA0", VA = "0x1820457A0")]
	public static HLCKIPLOLMB PEGIGFCKLEH([In] this OCECGGEJAHM HLIDMKMINHN, [In] PAKFBCGAJOM BBOKFOJNMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2045480", Offset = "0x2043A80", VA = "0x182045480")]
	public static OCECGGEJAHM OJPHNAHFOOE(this HLCKIPLOLMB HLIDMKMINHN, [In] PAKFBCGAJOM BBOKFOJNMIE)
	{
		return default(OCECGGEJAHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class ENPEEPOPBDO
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x203A7F0", Offset = "0x2038DF0", VA = "0x18203A7F0")]
	public static APLMMBLANIC PEGIGFCKLEH([In] this GHBLLNOLCAB HLIDMKMINHN, [In] BDIECDJCIAI IKEFDAOMGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x203A380", Offset = "0x2038980", VA = "0x18203A380")]
	public static GHBLLNOLCAB OJPHNAHFOOE(this APLMMBLANIC HLIDMKMINHN, [In] BDIECDJCIAI IKEFDAOMGCG)
	{
		return default(GHBLLNOLCAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class OJGMMILJLCC
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x204F530", Offset = "0x204DB30", VA = "0x18204F530")]
	public static AOICCPIBNMK PEGIGFCKLEH([In] this NHEOJCPEICL HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x204F480", Offset = "0x204DA80", VA = "0x18204F480")]
	public static NHEOJCPEICL OJPHNAHFOOE(this AOICCPIBNMK HLIDMKMINHN)
	{
		return default(NHEOJCPEICL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class KILEJHNHJHB
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x204C9F0", Offset = "0x204AFF0", VA = "0x18204C9F0")]
	public static AMKIMINIPIJ PEGIGFCKLEH(this ICCDGPHNGEH HLIDMKMINHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x204C520", Offset = "0x204AB20", VA = "0x18204C520")]
	public static ICCDGPHNGEH OJPHNAHFOOE(this AMKIMINIPIJ HLIDMKMINHN, [In] EDBAHDNNLHP KKCNEBNFMMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class ECJLFKJPPOD
{
	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2039780", Offset = "0x2037D80", VA = "0x182039780")]
	public static ALOCNEELEIH PEGIGFCKLEH([In] this EFGALINGOPJ HLIDMKMINHN, MBGGCGEEENC GOAECDHCJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2039630", Offset = "0x2037C30", VA = "0x182039630")]
	public static EFGALINGOPJ OJPHNAHFOOE(this ALOCNEELEIH HLIDMKMINHN)
	{
		return default(EFGALINGOPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public readonly struct HBHKADHCMEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public readonly CGBGMGFBCKF<FELHHAAOOHO> AJFKPIPANMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public readonly CGBGMGFBCKF<HHDHBHHIDEB> FKDPCOKFGNI;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x1C03B30", Offset = "0x1C02130", VA = "0x181C03B30")]
	private HBHKADHCMEC(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> LIOCIKIPKPI, CGBGMGFBCKF<HHDHBHHIDEB> ADCFLPJKMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x203DBE0", Offset = "0x203C1E0", VA = "0x18203DBE0")]
	public static HPKKLOLKELF<LKJBELODGDI, HBHKADHCMEC> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, HBHKADHCMEC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2BA17C0", Offset = "0x2B9FDC0", VA = "0x182BA17C0")]
	public static CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] HBHKADHCMEC HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public readonly struct HGBGBHNCMOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO>? GEDMLGKPMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public readonly CGBGMGFBCKF<LPCIIGCGGHE> GMHFCOGPBPP;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1FE6370", Offset = "0x1FE4970", VA = "0x181FE6370")]
	private HGBGBHNCMOP(CGBGMGFBCKF<NPIPKFBHIBO>? EFBHJEENKDA, CGBGMGFBCKF<LPCIIGCGGHE> LHBKNLELJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x203DDB0", Offset = "0x203C3B0", VA = "0x18203DDB0")]
	public static HPKKLOLKELF<LKJBELODGDI, HGBGBHNCMOP> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, HGBGBHNCMOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2BA4610", Offset = "0x2BA2C10", VA = "0x182BA4610")]
	public static CBDPDIPONCF<CGBGMGFBCKF<NPIPKFBHIBO>, IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] HGBGBHNCMOP HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<CGBGMGFBCKF<NPIPKFBHIBO>, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public readonly struct PDKMMAEEHGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public readonly CGBGMGFBCKF<JBMJEMLAFJB> ONOBLOEDEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public readonly CGBGMGFBCKF<JJKDMNECOCJ> MBBMILLMPKI;

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1C03B30", Offset = "0x1C02130", VA = "0x181C03B30")]
	private PDKMMAEEHGC(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x204F5C0", Offset = "0x204DBC0", VA = "0x18204F5C0")]
	public static HPKKLOLKELF<LKJBELODGDI, PDKMMAEEHGC> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, PDKMMAEEHGC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2D23550", Offset = "0x2D21B50", VA = "0x182D23550")]
	public static CBDPDIPONCF<CGBGMGFBCKF<HHDHBHHIDEB>, IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] PDKMMAEEHGC HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<CGBGMGFBCKF<HHDHBHHIDEB>, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct OGJKGLECFNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly CGBGMGFBCKF<DLDOKKGNCJH> AJBGDGMHMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public readonly DHNIBFCDNLJ AFDJHIPPHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public readonly PBDCHDIIPAE JGMGNPPDNFI;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x204F450", Offset = "0x204DA50", VA = "0x18204F450")]
	private OGJKGLECFNI(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<DLDOKKGNCJH> AACOCLPMLOL, [In] DHNIBFCDNLJ HONLKIPNFHG, [In] PBDCHDIIPAE MAEHIMLIPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x204F2E0", Offset = "0x204D8E0", VA = "0x18204F2E0")]
	public static HPKKLOLKELF<LKJBELODGDI, OGJKGLECFNI> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, OGJKGLECFNI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2CF7730", Offset = "0x2CF5D30", VA = "0x182CF7730")]
	public static CBDPDIPONCF<CGBGMGFBCKF<JBMJEMLAFJB>, IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] OGJKGLECFNI HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<CGBGMGFBCKF<JBMJEMLAFJB>, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct JJAPFKEMAMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public readonly CGBGMGFBCKF<JBMJEMLAFJB> ONOBLOEDEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public readonly int MENLOIMIDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public readonly BJGJGGGFNAC LADEKBPIHJB;

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x203DBB0", Offset = "0x203C1B0", VA = "0x18203DBB0")]
	private JJAPFKEMAMB(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, int GMIICDFKBBD, BJGJGGGFNAC GOAECDHCJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2045AA0", Offset = "0x20440A0", VA = "0x182045AA0")]
	public static HPKKLOLKELF<LKJBELODGDI, JJAPFKEMAMB> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, JJAPFKEMAMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x2C052B0", Offset = "0x2C038B0", VA = "0x182C052B0")]
	public static CBDPDIPONCF<(CGBGMGFBCKF<HHDHBHHIDEB>, CGBGMGFBCKF<FELHHAAOOHO>), IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] JJAPFKEMAMB HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<(CGBGMGFBCKF<HHDHBHHIDEB>, CGBGMGFBCKF<FELHHAAOOHO>), IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct HBAAOAJEKAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly CGBGMGFBCKF<JBMJEMLAFJB> ONOBLOEDEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly int LNKFKLPHIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public readonly BJGJGGGFNAC LADEKBPIHJB;

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x203DBB0", Offset = "0x203C1B0", VA = "0x18203DBB0")]
	private HBAAOAJEKAA(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, int GMIICDFKBBD, BJGJGGGFNAC GOAECDHCJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x203DA40", Offset = "0x203C040", VA = "0x18203DA40")]
	public static HPKKLOLKELF<LKJBELODGDI, HBAAOAJEKAA> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, HBAAOAJEKAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x2BA1450", Offset = "0x2B9FA50", VA = "0x182BA1450")]
	public static CBDPDIPONCF<(CGBGMGFBCKF<FELHHAAOOHO>, CGBGMGFBCKF<HHDHBHHIDEB>), IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] HBAAOAJEKAA HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<(CGBGMGFBCKF<FELHHAAOOHO>, CGBGMGFBCKF<HHDHBHHIDEB>), IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct JCIKHFGBHAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public readonly CGBGMGFBCKF<JBMJEMLAFJB> ONOBLOEDEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public readonly int MENLOIMIDFE;

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x1C03B30", Offset = "0x1C02130", VA = "0x181C03B30")]
	private JCIKHFGBHAA(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, int AFHHNDIHHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2044060", Offset = "0x2042660", VA = "0x182044060")]
	public static HPKKLOLKELF<LKJBELODGDI, JCIKHFGBHAA> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, JCIKHFGBHAA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2BF4510", Offset = "0x2BF2B10", VA = "0x182BF4510")]
	public static CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] JCIKHFGBHAA HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct EODHPEMJCBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public readonly CGBGMGFBCKF<JBMJEMLAFJB> ONOBLOEDEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public readonly int LNKFKLPHIDD;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x1C03B30", Offset = "0x1C02130", VA = "0x181C03B30")]
	private EODHPEMJCBE(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, int AFHHNDIHHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x203AC70", Offset = "0x2039270", VA = "0x18203AC70")]
	public static HPKKLOLKELF<LKJBELODGDI, EODHPEMJCBE> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, EODHPEMJCBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2A3C2F0", Offset = "0x2A3A8F0", VA = "0x182A3C2F0")]
	public static CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] EODHPEMJCBE HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct KCFLCLNPFEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public readonly CGBGMGFBCKF<HHDHBHHIDEB> KNIKGKHCEFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public readonly EFGALINGOPJ AFBOPANGGMH;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x204C490", Offset = "0x204AA90", VA = "0x18204C490")]
	private KCFLCLNPFEB(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM, [In] EFGALINGOPJ DNKAMNBGFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x204C380", Offset = "0x204A980", VA = "0x18204C380")]
	public static HPKKLOLKELF<LKJBELODGDI, KCFLCLNPFEB> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, KCFLCLNPFEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x2C34BD0", Offset = "0x2C331D0", VA = "0x182C34BD0")]
	public static CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] KCFLCLNPFEB HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct CFOCPIKJJNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly CGBGMGFBCKF<FELHHAAOOHO> AJFKPIPANMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly CGBGMGFBCKF<HHDHBHHIDEB> FKDPCOKFGNI;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x1C03B30", Offset = "0x1C02130", VA = "0x181C03B30")]
	private CFOCPIKJJNH(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> LIOCIKIPKPI, CGBGMGFBCKF<HHDHBHHIDEB> ADCFLPJKMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x202F4C0", Offset = "0x202DAC0", VA = "0x18202F4C0")]
	public static HPKKLOLKELF<LKJBELODGDI, CFOCPIKJJNH> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, CFOCPIKJJNH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x29A54D0", Offset = "0x29A3AD0", VA = "0x1829A54D0")]
	public static CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] CFOCPIKJJNH HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct FPKHPNBMAPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ;

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
	private FPKHPNBMAPN(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x203B9A0", Offset = "0x2039FA0", VA = "0x18203B9A0")]
	public static HPKKLOLKELF<LKJBELODGDI, FPKHPNBMAPN> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, FPKHPNBMAPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2B8AD30", Offset = "0x2B89330", VA = "0x182B8AD30")]
	public static CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] FPKHPNBMAPN HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct CLOIOKPAFNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public readonly CGBGMGFBCKF<NPIPKFBHIBO> IHPNLCLNIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public readonly CGBGMGFBCKF<JBMJEMLAFJB> ONOBLOEDEIC;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xC84530", Offset = "0xC82B30", VA = "0x180C84530")]
	private CLOIOKPAFNF(CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x202F590", Offset = "0x202DB90", VA = "0x18202F590")]
	public static HPKKLOLKELF<LKJBELODGDI, CLOIOKPAFNF> BAPBCJGBEDO(EIJGBFLAMII LECHCDDBDND)
	{
		return default(HPKKLOLKELF<LKJBELODGDI, CLOIOKPAFNF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x29B3150", Offset = "0x29B1750", VA = "0x1829B3150")]
	public static CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD> MIMELGANJCJ<TRoot>(TRoot OPJBDKMKMOF, [In] CLOIOKPAFNF HLIDMKMINHN) where TRoot : BJOCNHKJCEG
	{
		return default(CBDPDIPONCF<COKMANPFJNC, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class IOFPJMLPHFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly Guid KLAJLHLIJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public readonly bool FHIGIKLGAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public readonly bool MJHELKEOGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public readonly bool BGFPEICJMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public readonly bool BKEDMGHPLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public readonly bool DMBMIGAKCIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly List<(string Name, MBGGCGEEENC Type)> COAIOKJFPKJ;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Guid LAALHOAJCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1FF5A40", Offset = "0x1FF4040", VA = "0x181FF5A40")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x868200", Offset = "0x866800", VA = "0x180868200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x868230", Offset = "0x866830", VA = "0x180868230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public IReadOnlyList<(string Name, MBGGCGEEENC Type)> OJMLFFODJKK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action FKKHGNICDOM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x2043430", Offset = "0x2041A30", VA = "0x182043430")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x20431E0", Offset = "0x20417E0", VA = "0x1820431E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action<string, MBGGCGEEENC> MJJNFAMOHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2042E10", Offset = "0x2041410", VA = "0x182042E10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2043580", Offset = "0x2041B80", VA = "0x182043580")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action<int> JAJBCOAGCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x20434D0", Offset = "0x2041AD0", VA = "0x1820434D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x20437A0", Offset = "0x2041DA0", VA = "0x1820437A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action<int, string> DNCMMIMPIHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x2043130", Offset = "0x2041730", VA = "0x182043130")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x2042B70", Offset = "0x2041170", VA = "0x182042B70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action<int, MBGGCGEEENC> BJIALJAIDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x2043020", Offset = "0x2041620", VA = "0x182043020")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x2042C20", Offset = "0x2041220", VA = "0x182042C20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action DICLMOPLLGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2043390", Offset = "0x2041990", VA = "0x182043390")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2043850", Offset = "0x2041E50", VA = "0x182043850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2043370", Offset = "0x2041970", VA = "0x182043370")]
	public void ICKICNPIMHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x20438F0", Offset = "0x2041EF0", VA = "0x1820438F0")]
	internal IOFPJMLPHFE([In] Guid DAIJJLLIENA, string GJEDHMJMNJA, bool GJMLGEKBJCP, bool MJBHFKNIGOP, bool LFOICBILEBM, bool NPJBBDFDKBP, bool EHKMMKJACNF, List<(string Name, MBGGCGEEENC Type)> GAHPPKKAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x2043630", Offset = "0x2041C30", VA = "0x182043630")]
	public static IJGNKDBEION NGGHNELCOKP(string DAIJJLLIENA, string GJEDHMJMNJA, bool GJMLGEKBJCP = false, bool MJBHFKNIGOP = false, bool LFOICBILEBM = false, bool NPJBBDFDKBP = true, bool EHKMMKJACNF = true)
	{
		return default(IJGNKDBEION);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x20436C0", Offset = "0x2041CC0", VA = "0x1820436C0")]
	public static IOFPJMLPHFE NPMMPAGGBJP([In] Guid DAIJJLLIENA, string GJEDHMJMNJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x20430D0", Offset = "0x20416D0", VA = "0x1820430D0")]
	public void GDAJDOECFGG(string GJEDHMJMNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2043280", Offset = "0x2041880", VA = "0x182043280")]
	public void HGOAFOALCIK(int PDMMEDBMFPP, string BEEOOAHHFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2042EC0", Offset = "0x20414C0", VA = "0x182042EC0")]
	public void EIMCJAOJMLP(int PDMMEDBMFPP, MBGGCGEEENC KEEKEEHLKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2042CD0", Offset = "0x20412D0", VA = "0x182042CD0")]
	public void BOGBGBIMFAD(string GJEDHMJMNJA, MBGGCGEEENC NPOOIAJJIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2042FB0", Offset = "0x20415B0", VA = "0x182042FB0")]
	public void EOKAEHCGMAF(int PDMMEDBMFPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct IJGNKDBEION
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly Guid KLAJLHLIJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly string CIDBCKJOCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool CGOPCPICDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly bool PENDKKPJHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly bool KPFMFNJBBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly bool ODKOFLNAAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly bool CBDLANLFDPL;

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x2040F70", Offset = "0x203F570", VA = "0x182040F70")]
	public IJGNKDBEION([In] Guid DAIJJLLIENA, string GJEDHMJMNJA, bool GJMLGEKBJCP, bool MJBHFKNIGOP, bool LFOICBILEBM, bool NPJBBDFDKBP, bool EHKMMKJACNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2040DF0", Offset = "0x203F3F0", VA = "0x182040DF0")]
	public JBFLBMOBEAD KEDBDLEKIHI(string GJEDHMJMNJA, MBGGCGEEENC GOAECDHCJMK)
	{
		return default(JBFLBMOBEAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x2040CD0", Offset = "0x203F2D0", VA = "0x182040CD0")]
	public IOFPJMLPHFE CHPBHFGPOPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct JBFLBMOBEAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Guid KLAJLHLIJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly string CIDBCKJOCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly bool CGOPCPICDGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly bool PENDKKPJHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private readonly bool KPFMFNJBBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly bool ODKOFLNAAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly bool CBDLANLFDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private readonly List<(string Name, MBGGCGEEENC Type)> COAIOKJFPKJ;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x2043BC0", Offset = "0x20421C0", VA = "0x182043BC0")]
	public JBFLBMOBEAD([In] Guid DAIJJLLIENA, string GJEDHMJMNJA, bool GJMLGEKBJCP, bool MJBHFKNIGOP, bool LFOICBILEBM, bool NPJBBDFDKBP, bool EHKMMKJACNF, List<(string Name, MBGGCGEEENC Type)> GAHPPKKAPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2043A70", Offset = "0x2042070", VA = "0x182043A70")]
	public JBFLBMOBEAD KEDBDLEKIHI(string GJEDHMJMNJA, MBGGCGEEENC GOAECDHCJMK)
	{
		return default(JBFLBMOBEAD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2043980", Offset = "0x2041F80", VA = "0x182043980")]
	public IOFPJMLPHFE CHPBHFGPOPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BCNNEAIFJFG
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public static class POEPNABHNOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly IOFPJMLPHFE CFKABNBDDKG;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly IOFPJMLPHFE JOEAGFJPFPL;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public static class FDALNOJFMCO
	{
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly IOFPJMLPHFE OIOKKCMOFBP;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class LKDKPFANAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly IOFPJMLPHFE MLPFIDJICIJ;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly IOFPJMLPHFE DMNONCIMEJA;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class NGJMJCPPNOB
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public static class JCFEEFIHICJ
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly IOFPJMLPHFE BCGOHANLOCF;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly IOFPJMLPHFE KEIHBPEOADB;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public static class GHAMBMIGNKE
	{
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly IOFPJMLPHFE AIFAFILJDLL;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly IOFPJMLPHFE MJFKMNFFLEO;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public static class CEMKHIIENLF
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly IOFPJMLPHFE MLPFIDJICIJ;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly IOFPJMLPHFE DMNONCIMEJA;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public static class BGOEDGKDGNI
	{
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly IOFPJMLPHFE ENLHFJOELKD;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly IOFPJMLPHFE KKPECAAHOKI;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly IOFPJMLPHFE ALBCCOOIKJI;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly IOFPJMLPHFE LEBAJPNJFIM;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly IOFPJMLPHFE PKFNCEAABLB;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly IOFPJMLPHFE ABMJLDNLHAB;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly IOFPJMLPHFE GJIPAEEIDLM;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public static class ODAHFDHFIJA
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public static class DMLLBFKLJGO
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class JBGDDNPMDJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public static class BIBAJBLJIFB
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly IOFPJMLPHFE OBLHGAAOOAJ;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly IOFPJMLPHFE OAKILCGIFIN;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public static class PMLKLNDMAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class KDLGCKILPHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class IKAMPIBLDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class JMOJGCALLCK
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class EJFJJPKDBBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly IOFPJMLPHFE JIOLFFKFNGA;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class KCENDGLDNDE
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly IOFPJMLPHFE BIJJJHOFEND;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public static readonly IOFPJMLPHFE EBDMACAKKBE;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public static readonly IOFPJMLPHFE KHFHMLPFMOC;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public static readonly IOFPJMLPHFE AIFAFILJDLL;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public static readonly IOFPJMLPHFE BBBEDKFDCDM;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public static readonly IOFPJMLPHFE LFECAALDJBA;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static readonly IOFPJMLPHFE KDELJKMIGJM;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public static readonly IOFPJMLPHFE ILOBAPAEHID;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static readonly IOFPJMLPHFE KGFCIENDMLB;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public static readonly IOFPJMLPHFE LCMBMCCIFDH;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public static readonly IOFPJMLPHFE BBMDABPBJEL;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public static readonly IOFPJMLPHFE GLFBMHOEKHC;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly IOFPJMLPHFE OLMIMBLGFKA;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly IOFPJMLPHFE IOJIJEIHNNE;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly IOFPJMLPHFE HFCEJDIBKNB;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly IOFPJMLPHFE ICDCELFGHIP;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public static readonly IOFPJMLPHFE NABIEJHGOKA;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly IOFPJMLPHFE MHIPCCKDENC;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public static readonly IOFPJMLPHFE FKDMBBHDCLD;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public static readonly IOFPJMLPHFE BHIOKMPAHMM;

		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public static readonly IOFPJMLPHFE PGMDJNCKCBG;

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public static readonly IOFPJMLPHFE MCDBJABNCKF;

		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public static readonly IOFPJMLPHFE MOHILDHGAMC;

		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public static readonly IOFPJMLPHFE HBLHMBEDBFD;

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public static readonly IOFPJMLPHFE HLILDGJPAOP;

		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public static readonly IOFPJMLPHFE GFEHIBAMNBB;

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public static readonly IOFPJMLPHFE LABKJCDDFFD;

		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public static readonly IOFPJMLPHFE GPMPIPDOLEC;

		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public static readonly IOFPJMLPHFE KCCFIPEHFMC;

		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public static readonly IOFPJMLPHFE JMPBNHJOKDC;

		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public static readonly IOFPJMLPHFE PFGIHLKDCKM;

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public static readonly IOFPJMLPHFE LFGCOAPFJKD;

		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public static readonly IOFPJMLPHFE IBJIHDDAOGB;

		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public static readonly IOFPJMLPHFE ENJCMMCAPNG;

		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public static readonly IOFPJMLPHFE MEOLCMNAKJA;

		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public static readonly IOFPJMLPHFE DFLDKAPPKGJ;

		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public static readonly IOFPJMLPHFE EKBMCPLBELA;

		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public static readonly IOFPJMLPHFE BFMMNIPBEHP;

		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public static readonly IOFPJMLPHFE HCPKMKLNHJF;

		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public static readonly IOFPJMLPHFE DKNOAEMFBFD;

		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public static readonly IOFPJMLPHFE HPEDOMPKGOD;

		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public static readonly IOFPJMLPHFE MNFDMMPGKKK;

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public static readonly IOFPJMLPHFE BDJOIBNCBFH;

		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public static readonly IOFPJMLPHFE KJFPKFDKLAC;

		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public static readonly IOFPJMLPHFE PCCMAPKPICA;

		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public static readonly IOFPJMLPHFE IKFCLOOHMCC;

		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public static readonly IOFPJMLPHFE ODKLMGHJAOI;

		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public static readonly IOFPJMLPHFE KFOOECIIKJI;

		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public static readonly IOFPJMLPHFE DCIAFAAOBJA;

		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public static readonly IOFPJMLPHFE HNGJCFAPFFI;

		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public static readonly IOFPJMLPHFE APGHNFOKKNM;

		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public static readonly IOFPJMLPHFE ANCEPBKOBBP;

		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public static readonly IOFPJMLPHFE FKFCFKBDFCL;

		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public static readonly IOFPJMLPHFE PFCFLDFIJJB;

		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public static readonly IOFPJMLPHFE FFFLCCGNNON;

		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public static readonly IOFPJMLPHFE HMPBIEKJMHC;

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public static readonly IOFPJMLPHFE PMAJKFHICPM;

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public static readonly IOFPJMLPHFE GHPDKJOAEMP;

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public static readonly IOFPJMLPHFE AEGPLEBODMG;

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public static class FPLNOKCCENG
	{
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class ODPIOHCPGBH
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public static readonly IOFPJMLPHFE MBEIIEECCOP;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public static readonly IOFPJMLPHFE EKHKOALGJHM;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public static readonly IOFPJMLPHFE NNOMAMHLFOF;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public static readonly IOFPJMLPHFE KEFFMMEFCJC;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public static readonly IOFPJMLPHFE JKFACHPMDAO;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public static readonly IOFPJMLPHFE LKNNBENAHEG;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public static class JJEMIFJHHEO
	{
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public static readonly IOFPJMLPHFE BIJJJHOFEND;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly IOFPJMLPHFE EBDMACAKKBE;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public static readonly IOFPJMLPHFE HEBICDGLION;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public static readonly IOFPJMLPHFE IHHFEFAFJKO;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public static readonly IOFPJMLPHFE DIJAJCFCFDN;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public static readonly IOFPJMLPHFE IPCLEJGLGJG;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public static class HKMBKFNMAAD
	{
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public static readonly IOFPJMLPHFE LKLOMDFANLI;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public static readonly IOFPJMLPHFE MMFCLPMJIBM;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public static readonly IOFPJMLPHFE KFMGAGCJHEH;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public static readonly IOFPJMLPHFE CJPJHMGKKHN;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public static readonly IOFPJMLPHFE JLBBDEDAEPE;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public static readonly IOFPJMLPHFE FIAMJHLLLAK;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class NBMCNCFNAIF
	{
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class KLDEOCIFBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public static class MDNDDPNDMAE
	{
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public static readonly IOFPJMLPHFE NHHCGPKBNJB;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class OLJOFNEAIAE
	{
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public static readonly IOFPJMLPHFE JIOLFFKFNGA;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public static class HKBNGMEAIJH
	{
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public static class JILGEHEFECA
	{
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public static class PFOAMIKKIIL
	{
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static readonly IOFPJMLPHFE ANMPCCILDJN;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public static readonly IOFPJMLPHFE DEAJICBKDBG;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public static readonly IOFPJMLPHFE MDHNDNIGGAD;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public static readonly IOFPJMLPHFE MNDCNNNGHHJ;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class CFKAEIEDFKE
	{
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public static readonly IOFPJMLPHFE AEOHDFFECMN;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public static readonly IOFPJMLPHFE FEOMFFCFMEF;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class HFMIDLCIBEN
	{
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public static class PIKGJEKBGBL
	{
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public static readonly IOFPJMLPHFE MBEIIEECCOP;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public static readonly IOFPJMLPHFE EKHKOALGJHM;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class DNFAOEPLBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public static readonly IOFPJMLPHFE DMFCKDCANGI;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public static readonly IOFPJMLPHFE KEFFMMEFCJC;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public static readonly IOFPJMLPHFE JKFACHPMDAO;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public static readonly IOFPJMLPHFE LKNNBENAHEG;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public static readonly IOFPJMLPHFE CFKJLEJDKNP;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public static readonly IOFPJMLPHFE FGBBDGADDKO;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public static readonly IOFPJMLPHFE OKOLOFJGBCC;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public static readonly IOFPJMLPHFE GCAOJMLKNNA;

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public static readonly IOFPJMLPHFE CNGHOGGPFAH;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public static readonly IOFPJMLPHFE PJNGNOEAIFJ;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public static readonly IOFPJMLPHFE MBEIIEECCOP;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public static readonly IOFPJMLPHFE EKHKOALGJHM;

		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class GFKIAPNPJCI
	{
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public static class GAPNHGJPECL
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public static readonly IOFPJMLPHFE MBEIIEECCOP;

		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public static readonly IOFPJMLPHFE EKHKOALGJHM;

		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public static readonly IOFPJMLPHFE EBEBMANKEHE;

		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public static readonly IOFPJMLPHFE HIELKHMNPBL;

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public static readonly IOFPJMLPHFE DIONPFDJGBN;

		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public static class HGAKEJIHDJC
	{
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public static class MPELDEAGAKH
	{
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public static readonly IOFPJMLPHFE AAKLGGOCAAG;

		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public static class ELELHIDOENK
	{
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public static readonly IOFPJMLPHFE GEJMHAPKDOG;

		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public static readonly IOFPJMLPHFE EHCJKFHNLIO;

		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public static readonly IOFPJMLPHFE MBEIIEECCOP;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public static readonly IOFPJMLPHFE EKHKOALGJHM;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public static class FLIGDKCKIKP
	{
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public static class EJNNIKGCAEE
	{
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public static class EHGBIMICDDG
	{
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class ADKJFMEIBOB
	{
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public static class NDKOKBKPOIA
	{
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public static readonly IOFPJMLPHFE OBLHGAAOOAJ;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public static readonly IOFPJMLPHFE OAKILCGIFIN;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public static class IKMOGBPLNKI
	{
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public static readonly IOFPJMLPHFE IKJPLIMHCIG;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public static readonly IOFPJMLPHFE NENMMGKODGG;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public static readonly IOFPJMLPHFE NCFKEECBNDG;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public static readonly IOFPJMLPHFE AMJEKBCJLGI;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public static class OKDIHBHJMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public static readonly IOFPJMLPHFE IKJPLIMHCIG;

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public static readonly IOFPJMLPHFE NENMMGKODGG;

		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public static readonly IOFPJMLPHFE NCFKEECBNDG;

		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public static readonly IOFPJMLPHFE AMJEKBCJLGI;

		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public static class NICDHCFEKKE
	{
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public static class LGDNHALHDCM
	{
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public static readonly IOFPJMLPHFE JOCMCLJNBLA;

		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public static readonly IOFPJMLPHFE EGPBAIJMOKN;

		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public static readonly IOFPJMLPHFE AKKPFLLKHCO;

		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public static class AEGOEJFDLJK
	{
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public static readonly IOFPJMLPHFE EOFMPKDDCGI;

		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public static readonly IOFPJMLPHFE EEPEOADOCDG;

		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public static readonly IOFPJMLPHFE FDEOHIOEGBH;

		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public static class DGAHADPNHEH
	{
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public static class MIKJHGOJGDL
	{
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public static readonly IOFPJMLPHFE ODIMGIHLMCH;

		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public static readonly IOFPJMLPHFE BGDGCEIEEMC;

		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public static readonly IOFPJMLPHFE NGMJAPCBEKF;

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public static readonly IOFPJMLPHFE FKJDHHPJDNK;

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public static readonly IOFPJMLPHFE DJCAHKNIEIO;

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public static class KFPCJCIDOIN
	{
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public static readonly IOFPJMLPHFE ALMGPIONBON;

		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public static class CFAGFGIKKFE
	{
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public static readonly IOFPJMLPHFE CMGGPGGKFLL;

		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public static readonly IOFPJMLPHFE LELEGEKHHFB;

		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public static readonly IOFPJMLPHFE GICIDEIKJID;

		[Cpp2IlInjected.Token(Token = "0x4000202")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class NKJJJIPPGDG
	{
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public static class KPMNAFBANNH
	{
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public static class LJIHFOODOKM
	{
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public static class OBPCAINEEPG
	{
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public static readonly IOFPJMLPHFE JKCMCBMNJGE;

		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public static readonly IOFPJMLPHFE AFODECOOCHB;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public static readonly IOFPJMLPHFE DADAFLMEPCA;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		internal static readonly IOFPJMLPHFE[] AECFLPFHPJJ;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class JMBJGMPHAJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	public readonly MBGGCGEEENC GIGABCPOOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly List<IOFPJMLPHFE> GEOBGMGFADH;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public IReadOnlyList<IOFPJMLPHFE> ACLHCBHALFM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x205C430", Offset = "0x205AA30", VA = "0x18205C430")]
	protected JMBJGMPHAJG(MBGGCGEEENC KOJHPKIOJIC, params IOFPJMLPHFE[][] HHIALNGABOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class FGKKGBNPHKG : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2057130", Offset = "0x2055730", VA = "0x182057130")]
	internal FGKKGBNPHKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class CHCGKGHBAFI : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x20547D0", Offset = "0x2052DD0", VA = "0x1820547D0")]
	internal CHCGKGHBAFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class LFECLPDNDHI : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x205CE90", Offset = "0x205B490", VA = "0x18205CE90")]
	internal LFECLPDNDHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class IBLEIDMLACH : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x2059AF0", Offset = "0x20580F0", VA = "0x182059AF0")]
	internal IBLEIDMLACH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class OEKGDHDOGIM : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x2061210", Offset = "0x205F810", VA = "0x182061210")]
	internal OEKGDHDOGIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class ALODAFKGADG : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2052090", Offset = "0x2050690", VA = "0x182052090")]
	internal ALODAFKGADG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public class ABICGCEMEDK : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x2051090", Offset = "0x204F690", VA = "0x182051090")]
	internal ABICGCEMEDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public class AOOANMIMGKO : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x2052270", Offset = "0x2050870", VA = "0x182052270")]
	internal AOOANMIMGKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public class EILIGENMMOJ : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2056590", Offset = "0x2054B90", VA = "0x182056590")]
	internal EILIGENMMOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public class OLEAODMEDJP : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2061A80", Offset = "0x2060080", VA = "0x182061A80")]
	internal OLEAODMEDJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class KDDMFPDOCAC : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x205C530", Offset = "0x205AB30", VA = "0x18205C530")]
	internal KDDMFPDOCAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class CIEAPNHFLHB : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x20549B0", Offset = "0x2052FB0", VA = "0x1820549B0")]
	internal CIEAPNHFLHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class IJAEJCIEPMA : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2059EC0", Offset = "0x20584C0", VA = "0x182059EC0")]
	internal IJAEJCIEPMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public class DHLBJHFLCPE : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x20550B0", Offset = "0x20536B0", VA = "0x1820550B0")]
	internal DHLBJHFLCPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public class IPGMDNMAFDH : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x205ADD0", Offset = "0x20593D0", VA = "0x18205ADD0")]
	internal IPGMDNMAFDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public class JCFMLCOHNGM : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x205AFB0", Offset = "0x20595B0", VA = "0x18205AFB0")]
	internal JCFMLCOHNGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public class OBMAIHNPFKM : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x20603C0", Offset = "0x205E9C0", VA = "0x1820603C0")]
	internal OBMAIHNPFKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public class NGHCLALFKPM : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x205F730", Offset = "0x205DD30", VA = "0x18205F730")]
	internal NGHCLALFKPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public class BEJPICMPHOO : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2052810", Offset = "0x2050E10", VA = "0x182052810")]
	internal BEJPICMPHOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public class FMMECCJCKBF : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2057380", Offset = "0x2055980", VA = "0x182057380")]
	internal FMMECCJCKBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class DOFBKCJNHMH : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2056160", Offset = "0x2054760", VA = "0x182056160")]
	internal DOFBKCJNHMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public class GPHEKFHCCJK : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x20585B0", Offset = "0x2056BB0", VA = "0x1820585B0")]
	internal GPHEKFHCCJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class HIHLBBCINMM : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2058DC0", Offset = "0x20573C0", VA = "0x182058DC0")]
	internal HIHLBBCINMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class PHKELDEAOCC : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2062B40", Offset = "0x2061140", VA = "0x182062B40")]
	internal PHKELDEAOCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public class OALKIFOJMOE : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x20601E0", Offset = "0x205E7E0", VA = "0x1820601E0")]
	internal OALKIFOJMOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public class MMCEOJMJMED : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x205EE50", Offset = "0x205D450", VA = "0x18205EE50")]
	internal MMCEOJMJMED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class GGHPMHLFILC : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x2057F60", Offset = "0x2056560", VA = "0x182057F60")]
	internal GGHPMHLFILC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class FCKDGDMIEKF : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x2056D70", Offset = "0x2055370", VA = "0x182056D70")]
	internal FCKDGDMIEKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public class NHKDOAICFHI : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x205FB60", Offset = "0x205E160", VA = "0x18205FB60")]
	internal NHKDOAICFHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public class MKDKCJOLINL : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x205EBF0", Offset = "0x205D1F0", VA = "0x18205EBF0")]
	internal MKDKCJOLINL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class LFJNLLHJJMI : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x205D070", Offset = "0x205B670", VA = "0x18205D070")]
	internal LFJNLLHJJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public class INDGEKHNMNB : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x205A910", Offset = "0x2058F10", VA = "0x18205A910")]
	internal INDGEKHNMNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public class LLFNIEBBCAJ : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x205D860", Offset = "0x205BE60", VA = "0x18205D860")]
	internal LLFNIEBBCAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public class INMLLGONCEB : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x205AB70", Offset = "0x2059170", VA = "0x18205AB70")]
	internal INMLLGONCEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public class KIBDOJDPEMD : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x205CB50", Offset = "0x205B150", VA = "0x18205CB50")]
	internal KIBDOJDPEMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public class KEDOMCFLCBH : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x205C710", Offset = "0x205AD10", VA = "0x18205C710")]
	internal KEDOMCFLCBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class EFEMNKAAOAB : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x2056340", Offset = "0x2054940", VA = "0x182056340")]
	internal EFEMNKAAOAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class MIDCJGCHEMP : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x205DEE0", Offset = "0x205C4E0", VA = "0x18205DEE0")]
	internal MIDCJGCHEMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class MDPKHDILACK : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x205DD00", Offset = "0x205C300", VA = "0x18205DD00")]
	internal MDPKHDILACK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class PLAMGHEKMCA : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x20634E0", Offset = "0x2061AE0", VA = "0x1820634E0")]
	internal PLAMGHEKMCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class NHJHLCIGDBH : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x205F980", Offset = "0x205DF80", VA = "0x18205F980")]
	internal NHJHLCIGDBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class COGKMBFOPKD : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x2054A80", Offset = "0x2053080", VA = "0x182054A80")]
	internal COGKMBFOPKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public class BBPHDBKAFGI : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x2052450", Offset = "0x2050A50", VA = "0x182052450")]
	internal BBPHDBKAFGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class GDEBMADCBIB : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2057D10", Offset = "0x2056310", VA = "0x182057D10")]
	internal GDEBMADCBIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class BDHACNOMHIC : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2052630", Offset = "0x2050C30", VA = "0x182052630")]
	internal BDHACNOMHIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class HEOHJGIFNLO : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x2058B00", Offset = "0x2057100", VA = "0x182058B00")]
	internal HEOHJGIFNLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class DNGBMEJCHBD : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x2055F80", Offset = "0x2054580", VA = "0x182055F80")]
	internal DNGBMEJCHBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class IMKJGMLHDCE : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x205A730", Offset = "0x2058D30", VA = "0x18205A730")]
	internal IMKJGMLHDCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class HOMLNMOBAEG : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2059910", Offset = "0x2057F10", VA = "0x182059910")]
	internal HOMLNMOBAEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public class FCKGIPFDOLJ : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2056F50", Offset = "0x2055550", VA = "0x182056F50")]
	internal FCKGIPFDOLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class NPHNKCGGOPM : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2060000", Offset = "0x205E600", VA = "0x182060000")]
	internal NPHNKCGGOPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class OLFJIKBOMOE : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x2061C60", Offset = "0x2060260", VA = "0x182061C60")]
	internal OLFJIKBOMOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class ALFKMILHPJB : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2051790", Offset = "0x204FD90", VA = "0x182051790")]
	internal ALFKMILHPJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public class NNOMAIIAGKF : JMBJGMPHAJG
{
	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x205FE20", Offset = "0x205E420", VA = "0x18205FE20")]
	internal NNOMAIIAGKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public sealed class HAAMCAAIAAA : GLEJFJLOOKD
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2058790", Offset = "0x2056D90", VA = "0x182058790")]
	public HAAMCAAIAAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public abstract class EEBJFKJBNJL : JNGCEDIBEOI<ICCDGPHNGEH>
{
	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2053730", Offset = "0x2051D30", VA = "0x182053730")]
	protected EEBJFKJBNJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public abstract class IDMAIHFDNBO : DIKMNABKMFH<ICCDGPHNGEH>
{
	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2059DF0", Offset = "0x20583F0", VA = "0x182059DF0")]
	protected IDMAIHFDNBO([In] NKEKNJPEHLG PGHJJBIHFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x2059D60", Offset = "0x2058360", VA = "0x182059D60", Slot = "11")]
	public override void MBFPCONKEHL(ICCDGPHNGEH OPJBDKMKMOF, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, OLHFKDFGMIB CAALNKNJIAB, CGBGMGFBCKF<FCPBGPKMICB.NLBPONGEFLF>? FNPHMPFPJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x2059CD0", Offset = "0x20582D0", VA = "0x182059CD0", Slot = "14")]
	public override void HKGPALJDGOB(ICCDGPHNGEH OPJBDKMKMOF, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public abstract class LADDDCIEIFO : IDMAIHFDNBO
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x2059DF0", Offset = "0x20583F0", VA = "0x182059DF0")]
	public LADDDCIEIFO([In] NKEKNJPEHLG PGHJJBIHFJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class DEDFPKLAGAF : EEBJFKJBNJL
{
	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "11")]
	public override void MBFPCONKEHL(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, OLHFKDFGMIB CAALNKNJIAB, CGBGMGFBCKF<FCPBGPKMICB.NLBPONGEFLF>? FNPHMPFPJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "12")]
	public override void INBGCNECIGH(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x2054D60", Offset = "0x2053360", VA = "0x182054D60", Slot = "13")]
	public override IEnumerable<IJNLPEGNOKP<MBGGCGEEENC>> FFHKFMEJNCP(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x2054D90", Offset = "0x2053390", VA = "0x182054D90", Slot = "14")]
	public override void HKGPALJDGOB(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x2054C60", Offset = "0x2053260", VA = "0x182054C60")]
	public static void BIGBMMJJEOE(ICCDGPHNGEH JJIILPFEIBK, [In] CFMNGFJNBKJ.JJJAHPDFHIK ABBOHBHBCJN, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x2052E20", Offset = "0x2051420", VA = "0x182052E20", Slot = "15")]
	public override EFGALINGOPJ DEBOELEMMNE(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA, MBGGCGEEENC IGLLMPGCIFF)
	{
		return default(EFGALINGOPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x2053730", Offset = "0x2051D30", VA = "0x182053730")]
	public DEDFPKLAGAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public sealed class CCGBPLEEBJE : EEBJFKJBNJL
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public sealed class FAENEPNEPDO : LEDDBICJHIN.NJHLIAMJFFF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public struct HGCFGBFLHFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public readonly CGBGMGFBCKF<NPIPKFBHIBO> MMCDOBBMMEL;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xAAF690", Offset = "0xAADC90", VA = "0x180AAF690")]
		private HGCFGBFLHFN(CGBGMGFBCKF<NPIPKFBHIBO> OPGJHNEIHGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xE29C50", Offset = "0xE28250", VA = "0x180E29C50")]
		public static HGCFGBFLHFN ENFOKLPNHAF(CGBGMGFBCKF<NPIPKFBHIBO> HFGPMEDABBF)
		{
			return default(HGCFGBFLHFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x2053580", Offset = "0x2051B80", VA = "0x182053580", Slot = "11")]
	public override void MBFPCONKEHL(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, OLHFKDFGMIB CAALNKNJIAB, CGBGMGFBCKF<FCPBGPKMICB.NLBPONGEFLF>? FNPHMPFPJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x20533E0", Offset = "0x20519E0", VA = "0x1820533E0", Slot = "12")]
	public override void INBGCNECIGH(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x2052E60", Offset = "0x2051460", VA = "0x182052E60", Slot = "13")]
	public override IEnumerable<IJNLPEGNOKP<MBGGCGEEENC>> FFHKFMEJNCP(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x2052EF0", Offset = "0x20514F0", VA = "0x182052EF0", Slot = "14")]
	public override void HKGPALJDGOB(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x2052C20", Offset = "0x2051220", VA = "0x182052C20")]
	public static void ADNDPLGIBPH(ICCDGPHNGEH JJIILPFEIBK, [In] CFMNGFJNBKJ.JJJAHPDFHIK ABBOHBHBCJN, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x2052D20", Offset = "0x2051320", VA = "0x182052D20")]
	public static void BIGBMMJJEOE(ICCDGPHNGEH JJIILPFEIBK, [In] CFMNGFJNBKJ.JJJAHPDFHIK ABBOHBHBCJN, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<FELHHAAOOHO> PDHFLBHDHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x2052E20", Offset = "0x2051420", VA = "0x182052E20", Slot = "15")]
	public override EFGALINGOPJ DEBOELEMMNE(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA, MBGGCGEEENC IGLLMPGCIFF)
	{
		return default(EFGALINGOPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x2053730", Offset = "0x2051D30", VA = "0x182053730")]
	public CCGBPLEEBJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public sealed class PICOGAFICOF : EEBJFKJBNJL
{
	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "11")]
	public override void MBFPCONKEHL(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, OLHFKDFGMIB CAALNKNJIAB, CGBGMGFBCKF<FCPBGPKMICB.NLBPONGEFLF>? FNPHMPFPJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "12")]
	public override void INBGCNECIGH(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x2062E20", Offset = "0x2061420", VA = "0x182062E20", Slot = "13")]
	public override IEnumerable<IJNLPEGNOKP<MBGGCGEEENC>> FFHKFMEJNCP(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x2062E50", Offset = "0x2061450", VA = "0x182062E50", Slot = "14")]
	public override void HKGPALJDGOB(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x2062D20", Offset = "0x2061320", VA = "0x182062D20")]
	public static void ADNDPLGIBPH(ICCDGPHNGEH JJIILPFEIBK, [In] CFMNGFJNBKJ.JJJAHPDFHIK ABBOHBHBCJN, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<HHDHBHHIDEB> BEHIJEKELGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x2052E20", Offset = "0x2051420", VA = "0x182052E20", Slot = "15")]
	public override EFGALINGOPJ DEBOELEMMNE(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA, MBGGCGEEENC IGLLMPGCIFF)
	{
		return default(EFGALINGOPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x2053730", Offset = "0x2051D30", VA = "0x182053730")]
	public PICOGAFICOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class OOPBLHOMGLJ : IDMAIHFDNBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	public readonly CGBGMGFBCKF<JJKDMNECOCJ> HLFEIJECDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	public readonly CGBGMGFBCKF<FLNLEKBDPAB> APMALNDKNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	public readonly CGBGMGFBCKF<FLNLEKBDPAB> FLEMJFEIAED;

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x2061FD0", Offset = "0x20605D0", VA = "0x182061FD0")]
	public OOPBLHOMGLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public abstract class GLEJFJLOOKD : KKJAOMJCDCB<ICCDGPHNGEH>
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x2058560", Offset = "0x2056B60", VA = "0x182058560")]
	protected GLEJFJLOOKD([In] OGDKFKHPALI PGHJJBIHFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x2058370", Offset = "0x2056970", VA = "0x182058370", Slot = "11")]
	public override void MBFPCONKEHL(ICCDGPHNGEH OPJBDKMKMOF, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, OLHFKDFGMIB CAALNKNJIAB, CGBGMGFBCKF<FCPBGPKMICB.NLBPONGEFLF>? FNPHMPFPJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x20582D0", Offset = "0x20568D0", VA = "0x1820582D0", Slot = "12")]
	public override void INBGCNECIGH(ICCDGPHNGEH OPJBDKMKMOF, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x2058240", Offset = "0x2056840", VA = "0x182058240", Slot = "14")]
	public override void HKGPALJDGOB(ICCDGPHNGEH OPJBDKMKMOF, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x2058420", Offset = "0x2056A20", VA = "0x182058420", Slot = "17")]
	public override CBDPDIPONCF<CGBGMGFBCKF<HHDHBHHIDEB>, IFONDHBKBCD> PLDNGFOBGOG(ICCDGPHNGEH OPJBDKMKMOF, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, CGBGMGFBCKF<JBMJEMLAFJB> CNJMIDDPAFB, CGBGMGFBCKF<JJKDMNECOCJ> JMCNEMAGKLA)
	{
		return default(CBDPDIPONCF<CGBGMGFBCKF<HHDHBHHIDEB>, IFONDHBKBCD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public sealed class CEMOFPNCDDN : LADDDCIEIFO
{
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x2053770", Offset = "0x2051D70", VA = "0x182053770")]
	public CEMOFPNCDDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public struct NHEOJCPEICL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public DHNIBFCDNLJ AFDJHIPPHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public PBDCHDIIPAE JGMGNPPDNFI;

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x205F960", Offset = "0x205DF60", VA = "0x18205F960")]
	internal NHEOJCPEICL([In] DHNIBFCDNLJ DJCNMBEIKME, [In] PBDCHDIIPAE CAANIPGJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x205F910", Offset = "0x205DF10", VA = "0x18205F910")]
	public static NHEOJCPEICL ENFOKLPNHAF()
	{
		return default(NHEOJCPEICL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x205F940", Offset = "0x205DF40", VA = "0x18205F940")]
	public static NHEOJCPEICL HMMGBDOMNOE([In] DHNIBFCDNLJ DJCNMBEIKME, [In] PBDCHDIIPAE CAANIPGJBEP)
	{
		return default(NHEOJCPEICL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public sealed class POEDMKHFLDD : GLEJFJLOOKD
{
	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x20636C0", Offset = "0x2061CC0", VA = "0x1820636C0")]
	public POEDMKHFLDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public sealed class ALPDGGNGJAP
{
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public sealed class CFMNGFJNBKJ : PBPLGNHFHKG
{
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public sealed class LHILKIACOCF : DGFNMDLPMKC.IPDJOIBLBGJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct JJJAHPDFHIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public string OABCLOFHIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public EFGBPJHFLDL<JJKDMNECOCJ, BJGJGGGFNAC> AIOPCCLPLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public EFGBPJHFLDL<FLNLEKBDPAB, BJGJGGGFNAC> PHABLGLAKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public readonly CGBGMGFBCKF<JBMJEMLAFJB> BNEMJOLDGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public readonly CGBGMGFBCKF<JBMJEMLAFJB> PINJHENGNBK;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x205C3C0", Offset = "0x205A9C0", VA = "0x18205C3C0")]
		private JJJAHPDFHIK(string GJEDHMJMNJA, [In] EFGBPJHFLDL<JJKDMNECOCJ, BJGJGGGFNAC> CJDHDEHLPDF, [In] EFGBPJHFLDL<FLNLEKBDPAB, BJGJGGGFNAC> PEKOCFEDPPE, CGBGMGFBCKF<JBMJEMLAFJB> PHGBPHAPEND, CGBGMGFBCKF<JBMJEMLAFJB> FNNOAICJFHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x205C270", Offset = "0x205A870", VA = "0x18205C270")]
		public static JJJAHPDFHIK ENFOKLPNHAF(CGBGMGFBCKF<JBMJEMLAFJB> FHGCHLGPCGD, CGBGMGFBCKF<JBMJEMLAFJB> FMOFLPLDKKK)
		{
			return default(JJJAHPDFHIK);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x205C340", Offset = "0x205A940", VA = "0x18205C340")]
		public static JJJAHPDFHIK HMMGBDOMNOE(string GJEDHMJMNJA, [In] EFGBPJHFLDL<JJKDMNECOCJ, BJGJGGGFNAC> CJDHDEHLPDF, [In] EFGBPJHFLDL<FLNLEKBDPAB, BJGJGGGFNAC> PEKOCFEDPPE, CGBGMGFBCKF<JBMJEMLAFJB> FHGCHLGPCGD, CGBGMGFBCKF<JBMJEMLAFJB> FMOFLPLDKKK)
		{
			return default(JJJAHPDFHIK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2054410", Offset = "0x2052A10", VA = "0x182054410", Slot = "8")]
	public override void MBFPCONKEHL(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, OLHFKDFGMIB CAALNKNJIAB, CGBGMGFBCKF<FCPBGPKMICB.NLBPONGEFLF>? MDCNEPNEBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x20541C0", Offset = "0x20527C0", VA = "0x1820541C0", Slot = "9")]
	public override void INBGCNECIGH(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2054790", Offset = "0x2052D90", VA = "0x182054790")]
	public CFMNGFJNBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public static class LLHNNJKPMNP
{
	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x205DA40", Offset = "0x205C040", VA = "0x18205DA40")]
	public static void IHOPKBJIMEI(this CFMNGFJNBKJ.JJJAHPDFHIK HLIDMKMINHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public abstract class PBPLGNHFHKG : DMBBGJCLNPE<ICCDGPHNGEH>
{
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x2054790", Offset = "0x2052D90", VA = "0x182054790")]
	protected PBPLGNHFHKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public readonly struct BJGJGGGFNAC : IEquatable<BJGJGGGFNAC>, LAHDMDPGLOK<BJGJGGGFNAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public readonly string OABCLOFHIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public readonly MBGGCGEEENC LADEKBPIHJB;

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
	private BJGJGGGFNAC(string GJEDHMJMNJA, MBGGCGEEENC GOAECDHCJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2026440", Offset = "0x2024A40", VA = "0x182026440")]
	public static BJGJGGGFNAC ENFOKLPNHAF(string GJEDHMJMNJA, MBGGCGEEENC GOAECDHCJMK)
	{
		return default(BJGJGGGFNAC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2052A70", Offset = "0x2051070", VA = "0x182052A70")]
	public static bool FFOLOHFBIHN([In] BJGJGGGFNAC OIMGCNDKIAD, [In] BJGJGGGFNAC LMBIFCGLAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x2052A70", Offset = "0x2051070", VA = "0x182052A70", Slot = "4")]
	public bool Equals(BJGJGGGFNAC BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x2052A70", Offset = "0x2051070", VA = "0x182052A70")]
	public bool CBEHGBLKKJL([In] BJGJGGGFNAC BHFGHGMPKOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x2052AC0", Offset = "0x20510C0", VA = "0x182052AC0", Slot = "0")]
	public override bool Equals(object NJKKPOFFNNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x2052B80", Offset = "0x2051180", VA = "0x182052B80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x2052BE0", Offset = "0x20511E0", VA = "0x182052BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x2052A70", Offset = "0x2051070", VA = "0x182052A70", Slot = "5")]
	private bool FHEEGELOIEF([In] BJGJGGGFNAC BHFGHGMPKOJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public sealed class KOOAIDNCCMN : PBPLGNHFHKG
{
	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "8")]
	public override void MBFPCONKEHL(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, OLHFKDFGMIB CAALNKNJIAB, CGBGMGFBCKF<FCPBGPKMICB.NLBPONGEFLF>? MDCNEPNEBCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "9")]
	public override void INBGCNECIGH(ICCDGPHNGEH JJIILPFEIBK, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x2054790", Offset = "0x2052D90", VA = "0x182054790")]
	public KOOAIDNCCMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public struct OCECGGEJAHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public ODKHIEPFOPO<JBMJEMLAFJB, NHEOJCPEICL> CDJAIBPIGKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public CFOCJPIHMCC<CCGBPLEEBJE.FAENEPNEPDO> BNCJMGCHAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public ODKHIEPFOPO<CCGBPLEEBJE.FAENEPNEPDO, CCGBPLEEBJE.HGCFGBFLHFN> LBMOGFODNKC;

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x20581D0", Offset = "0x20567D0", VA = "0x1820581D0")]
	private OCECGGEJAHM([In] ODKHIEPFOPO<JBMJEMLAFJB, NHEOJCPEICL> LGGLALNCHKL, [In] CFOCJPIHMCC<CCGBPLEEBJE.FAENEPNEPDO> IBDEJGJBBJC, [In] ODKHIEPFOPO<CCGBPLEEBJE.FAENEPNEPDO, CCGBPLEEBJE.HGCFGBFLHFN> JGOMENBPPME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x20609B0", Offset = "0x205EFB0", VA = "0x1820609B0")]
	public static OCECGGEJAHM ENFOKLPNHAF()
	{
		return default(OCECGGEJAHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x2058140", Offset = "0x2056740", VA = "0x182058140")]
	public static OCECGGEJAHM HMMGBDOMNOE([In] ODKHIEPFOPO<JBMJEMLAFJB, NHEOJCPEICL> LGGLALNCHKL, [In] CFOCJPIHMCC<CCGBPLEEBJE.FAENEPNEPDO> IBDEJGJBBJC, [In] ODKHIEPFOPO<CCGBPLEEBJE.FAENEPNEPDO, CCGBPLEEBJE.HGCFGBFLHFN> JGOMENBPPME)
	{
		return default(OCECGGEJAHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public static class IGIALGICIBB
{
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x2059E40", Offset = "0x2058440", VA = "0x182059E40")]
	public static void IHOPKBJIMEI(this OCECGGEJAHM HLIDMKMINHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public struct GHBLLNOLCAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public ODKHIEPFOPO<NPIPKFBHIBO, OCECGGEJAHM> IMEDACOCEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public CFOCJPIHMCC<CFMNGFJNBKJ.LHILKIACOCF> GPGINNPAHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public ODKHIEPFOPO<CFMNGFJNBKJ.LHILKIACOCF, CFMNGFJNBKJ.JJJAHPDFHIK> EJMAFJBJFBM;

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x20581D0", Offset = "0x20567D0", VA = "0x1820581D0")]
	private GHBLLNOLCAB([In] ODKHIEPFOPO<NPIPKFBHIBO, OCECGGEJAHM> DOCJELGKFHE, [In] CFOCJPIHMCC<CFMNGFJNBKJ.LHILKIACOCF> LEPGOBBPFCC, [In] ODKHIEPFOPO<CFMNGFJNBKJ.LHILKIACOCF, CFMNGFJNBKJ.JJJAHPDFHIK> AHBKMKMGKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x2058140", Offset = "0x2056740", VA = "0x182058140")]
	public static GHBLLNOLCAB HMMGBDOMNOE([In] ODKHIEPFOPO<NPIPKFBHIBO, OCECGGEJAHM> DOCJELGKFHE, [In] CFOCJPIHMCC<CFMNGFJNBKJ.LHILKIACOCF> LEPGOBBPFCC, [In] ODKHIEPFOPO<CFMNGFJNBKJ.LHILKIACOCF, CFMNGFJNBKJ.JJJAHPDFHIK> AHBKMKMGKKN)
	{
		return default(GHBLLNOLCAB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class ALGCDDGIEMG
{
	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x2051C90", Offset = "0x2050290", VA = "0x182051C90")]
	public static void IHOPKBJIMEI(this GHBLLNOLCAB HLIDMKMINHN, [In] BDIECDJCIAI CHHNPBAHHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x2052030", Offset = "0x2050630", VA = "0x182052030")]
	public static void JFFHOHJLLDI(this GHBLLNOLCAB HLIDMKMINHN, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, [In] OCECGGEJAHM BBOKFOJNMIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x20519E0", Offset = "0x204FFE0", VA = "0x1820519E0")]
	public static void EKHKOALGJHM(this GHBLLNOLCAB HLIDMKMINHN, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA, [In] BDIECDJCIAI CHHNPBAHHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x2051C20", Offset = "0x2050220", VA = "0x182051C20")]
	public static OCECGGEJAHM FOHHCFMHKPE([In] this GHBLLNOLCAB HLIDMKMINHN, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return default(OCECGGEJAHM);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x2051970", Offset = "0x204FF70", VA = "0x182051970")]
	public static OCECGGEJAHM CMLCKEFLJIC(this GHBLLNOLCAB HLIDMKMINHN, CGBGMGFBCKF<NPIPKFBHIBO> EHLNCLBLNMA)
	{
		return default(OCECGGEJAHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class MJCFFPKAOFC : GHGAACCCJDH<MJCFFPKAOFC, ICCDGPHNGEH>
{
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x205EB90", Offset = "0x205D190", VA = "0x18205EB90")]
	private MJCFFPKAOFC([In] EFGBPJHFLDL<DLDOKKGNCJH, PGHGNJOIEOA<ICCDGPHNGEH>> JNMGMNKMJKD, [In] EFGBPJHFLDL<LPCIIGCGGHE, MLNGDBLFLHB<ICCDGPHNGEH>> NPCFMPIHOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x205EAC0", Offset = "0x205D0C0", VA = "0x18205EAC0")]
	public static MJCFFPKAOFC ENFOKLPNHAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x205EA40", Offset = "0x205D040", VA = "0x18205EA40")]
	public new (GBHAABHCALK<DLDOKKGNCJH, PGHGNJOIEOA<ICCDGPHNGEH>>, GBHAABHCALK<LPCIIGCGGHE, MLNGDBLFLHB<ICCDGPHNGEH>>) BIJFBOGAKLC()
	{
		return default((GBHAABHCALK<DLDOKKGNCJH, PGHGNJOIEOA<ICCDGPHNGEH>>, GBHAABHCALK<LPCIIGCGGHE, MLNGDBLFLHB<ICCDGPHNGEH>>));
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public sealed class FOFAIHFKFIO : BHBEJHMMGCJ
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x20575E0", Offset = "0x2055BE0", VA = "0x1820575E0", Slot = "7")]
	public override string AFLHKEIDPKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x2057610", Offset = "0x2055C10", VA = "0x182057610")]
	public FOFAIHFKFIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface PLCHFMGPMPF
{
	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CBDPDIPONCF<object, FBDDJIHDMAI>> FMLFFEDJMGK(EIJGBFLAMII PEMICEIPPPL, bool FINFIEKODAH);
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
