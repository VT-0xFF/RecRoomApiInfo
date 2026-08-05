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
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FB6C00", Offset = "0x1FB5600", VA = "0x181FB6C00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8775C0", Offset = "0x875FC0", VA = "0x1808775C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x877600", Offset = "0x876000", VA = "0x180877600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct GLHNEJGAEME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> EMMPNGGGBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int DMLMLBJLCEP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
	public GLHNEJGAEME(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> GPKNPEONEDN, int LJEHDHLGGJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GBHGPDCEEMC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class GILHBHBHOMD : IGGCBKLFNEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct IDJBDBJLJHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly DAJKLPNGMBB<byte> HMPLPNJGGJL;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F6D3E0", Offset = "0x1F6BDE0", VA = "0x181F6D3E0")]
		public IDJBDBJLJHF(DAJKLPNGMBB<byte> KKELJOOMKNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3A90", Offset = "0x1FB2490", VA = "0x181FB3A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class KKJPHBJFPMJ : IGGCBKLFNEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct NBPEDIDKMAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> MKMDAPBJHMF;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
		public NBPEDIDKMAE(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> CPMPDFKNDPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum PPBOHLEKGNN
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
	public sealed class NOMBCFICFKP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class IGGCBKLFNEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct MBEIDLNLKKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly PPBOHLEKGNN GAGDNAGNODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly AEAOKLPMJLF<IGGCBKLFNEF> MPDKFCOIPIG;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
		public MBEIDLNLKKF(PPBOHLEKGNN IMMFLLDNCEM, AEAOKLPMJLF<IGGCBKLFNEF> JCDOMIIJNDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class ILDENJFCFLM : IGGCBKLFNEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct LEJPBFNMOFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NBIIBNJBFFD;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
		public LEJPBFNMOFM(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NBGBAELNAAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class LGBANFBLLDH : IGGCBKLFNEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct ANDADJNOODD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly KMKODCHIEIO PKLIEBGODLI;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
		public ANDADJNOODD(KMKODCHIEIO LNDBJGEBENP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC270", Offset = "0x1FAAC70", VA = "0x181FAC270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal DGFDEJCBFIK<NOMBCFICFKP, MBEIDLNLKKF> EPJEOLAINMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal DGFDEJCBFIK<GILHBHBHOMD, IDJBDBJLJHF> IIHICMBFMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal DGFDEJCBFIK<KKJPHBJFPMJ, NBPEDIDKMAE> BOOGJNDFMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal DGFDEJCBFIK<ILDENJFCFLM, LEJPBFNMOFM> LKFFDGDBMNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal DGFDEJCBFIK<LGBANFBLLDH, ANDADJNOODD> FDHIMDIKDMH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FB27B0", Offset = "0x1FB11B0", VA = "0x181FB27B0")]
	private GBHGPDCEEMC([In] DGFDEJCBFIK<NOMBCFICFKP, MBEIDLNLKKF> FMLJDAHLEGG, [In] DGFDEJCBFIK<GILHBHBHOMD, IDJBDBJLJHF> NECKGMINCOA, [In] DGFDEJCBFIK<KKJPHBJFPMJ, NBPEDIDKMAE> OJPAMFNFMFE, [In] DGFDEJCBFIK<ILDENJFCFLM, LEJPBFNMOFM> ACBBEDACGEO, [In] DGFDEJCBFIK<LGBANFBLLDH, ANDADJNOODD> OKPEDFEOPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2670", Offset = "0x1FB1070", VA = "0x181FB2670")]
	public static GBHGPDCEEMC KHKANEAPNIK()
	{
		return default(GBHGPDCEEMC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ECHFKFMDAKC
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2220", Offset = "0x1FB0C20", VA = "0x181FB2220")]
	public static void IKAGPDLIFEB(this GBHGPDCEEMC BBCPNLGGBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum MDOOGDGMAGG
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
public struct MOEOENAHOEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class FALNGAAHBEA : PIHBFDHEJKB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct GPIIIAJIDOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> HLAAGBBEOPA;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
		public GPIIIAJIDOJ(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> ADICOPEFHJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum CMFPKKBNLCI
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
	public sealed class JOHLILBJCOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class PIHBFDHEJKB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct GKKDGMLIEGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly CMFPKKBNLCI GAGDNAGNODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly AEAOKLPMJLF<PIHBFDHEJKB> MPDKFCOIPIG;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
		public GKKDGMLIEGA(CMFPKKBNLCI IMMFLLDNCEM, AEAOKLPMJLF<PIHBFDHEJKB> JCDOMIIJNDM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal DGFDEJCBFIK<JOHLILBJCOB, GKKDGMLIEGA> EPJEOLAINMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DGFDEJCBFIK<FALNGAAHBEA, GPIIIAJIDOJ> LJMKKFDAHME;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6BB0", Offset = "0x1FB55B0", VA = "0x181FB6BB0")]
	private MOEOENAHOEJ([In] DGFDEJCBFIK<JOHLILBJCOB, GKKDGMLIEGA> FMLJDAHLEGG, [In] DGFDEJCBFIK<FALNGAAHBEA, GPIIIAJIDOJ> MKKDBIEBIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6B20", Offset = "0x1FB5520", VA = "0x181FB6B20")]
	public static MOEOENAHOEJ KHKANEAPNIK()
	{
		return default(MOEOENAHOEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class BHDCLEAJPNI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC660", Offset = "0x1FAB060", VA = "0x181FAC660")]
	public static void IKAGPDLIFEB(this MOEOENAHOEJ BBCPNLGGBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct AMCJGCCIEAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public KHFGELOKLHG<int> CKJBNFAKLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public KHFGELOKLHG<int> HIKNFEOFFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int CLNOPHKCLJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int KGAODIFJPED;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC210", Offset = "0x1FAAC10", VA = "0x181FAC210")]
	private AMCJGCCIEAA([In] KHFGELOKLHG<int> NMGBBJGCCEG, [In] KHFGELOKLHG<int> PPFKKEMLCPP, int CNGPGLBDDOB, int LEKILLCHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC170", Offset = "0x1FAAB70", VA = "0x181FAC170")]
	public static AMCJGCCIEAA KHKANEAPNIK()
	{
		return default(AMCJGCCIEAA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class EBNNHOCCIFH
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FB21D0", Offset = "0x1FB0BD0", VA = "0x181FB21D0")]
	public static void IKAGPDLIFEB(this AMCJGCCIEAA BBCPNLGGBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PBLAHGGNEHG
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum DALDKIAKLAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class FDAHDCJEOJJ : MBJOOMJFKHJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct GLDGEMGBOOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly AEAOKLPMJLF<KJMPKDPNFOB> PKOMIAPCGHJ;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
		public GLDGEMGBOOI(AEAOKLPMJLF<KJMPKDPNFOB> GNELAKALNMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class IBGALOCOAOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class MBJOOMJFKHJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct LJAKEEHPIMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly DALDKIAKLAB GAGDNAGNODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly AEAOKLPMJLF<MBJOOMJFKHJ> MPDKFCOIPIG;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
		private LJAKEEHPIMD(DALDKIAKLAB IMMFLLDNCEM, AEAOKLPMJLF<MBJOOMJFKHJ> JCDOMIIJNDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4450", Offset = "0x1FB2E50", VA = "0x181FB4450")]
		public static LJAKEEHPIMD KHKANEAPNIK(DALDKIAKLAB IMMFLLDNCEM, AEAOKLPMJLF<MBJOOMJFKHJ> JCDOMIIJNDM)
		{
			return default(LJAKEEHPIMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class NBBKAEAPDEN : MBJOOMJFKHJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct BJBHLKONOBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly AEAOKLPMJLF<KJMPKDPNFOB> PKOMIAPCGHJ;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
		public BJBHLKONOBC(AEAOKLPMJLF<KJMPKDPNFOB> GNELAKALNMM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class KJMPKDPNFOB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct OEKECGJBMOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public KHFGELOKLHG<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> BPLFFBFPIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KHFGELOKLHG<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> KIKPJLOGKPN;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6BB0", Offset = "0x1FB55B0", VA = "0x181FB6BB0")]
		private OEKECGJBMOB([In] KHFGELOKLHG<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> HJDONKPJEOG, [In] KHFGELOKLHG<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> AJEDANMKNLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6C80", Offset = "0x1FB5680", VA = "0x181FB6C80")]
		public static OEKECGJBMOB KHKANEAPNIK()
		{
			return default(OEKECGJBMOB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal DGFDEJCBFIK<IBGALOCOAOM, LJAKEEHPIMD> EPJEOLAINMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal DGFDEJCBFIK<NBBKAEAPDEN, BJBHLKONOBC> HAKABHPFGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal DGFDEJCBFIK<FDAHDCJEOJJ, GLDGEMGBOOI> GBGEDJDJANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal KHFGELOKLHG<(AEAOKLPMJLF<IBGALOCOAOM> CallId, AEAOKLPMJLF<KJMPKDPNFOB> IOId)> KJNHEDCDDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal DGFDEJCBFIK<KJMPKDPNFOB, OEKECGJBMOB> DBFKODKLMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal AIEMCJFFFEM<KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>> AHPGMLBIHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal AIEMCJFFFEM<KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>> DJINEHPOJAA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FB7140", Offset = "0x1FB5B40", VA = "0x181FB7140")]
	private PBLAHGGNEHG([In] DGFDEJCBFIK<IBGALOCOAOM, LJAKEEHPIMD> FMLJDAHLEGG, [In] DGFDEJCBFIK<NBBKAEAPDEN, BJBHLKONOBC> BBOIJAOEGNK, [In] DGFDEJCBFIK<FDAHDCJEOJJ, GLDGEMGBOOI> GNJGDGEAEMI, [In] KHFGELOKLHG<(AEAOKLPMJLF<IBGALOCOAOM> CallId, AEAOKLPMJLF<KJMPKDPNFOB> IOId)> NPLHKKPGMOD, [In] DGFDEJCBFIK<KJMPKDPNFOB, OEKECGJBMOB> HGIPPMPIBKL, [In] AIEMCJFFFEM<KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>> FDKBOBICMGM, [In] AIEMCJFFFEM<KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>> PGBLAIOIEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6FA0", Offset = "0x1FB59A0", VA = "0x181FB6FA0")]
	public static PBLAHGGNEHG KHKANEAPNIK()
	{
		return default(PBLAHGGNEHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class CGDHLFFIFAM
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC960", Offset = "0x1FAB360", VA = "0x181FAC960")]
	private static void IKAGPDLIFEB(this PBLAHGGNEHG.OEKECGJBMOB BBCPNLGGBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC9B0", Offset = "0x1FAB3B0", VA = "0x181FAC9B0")]
	public static void IKAGPDLIFEB(this PBLAHGGNEHG BBCPNLGGBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct IBCECOKELDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public KHFGELOKLHG<byte> EJLMKGMJIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal PBLAHGGNEHG NBEJJAOLNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal APKIILKFBMN ILJJACEEPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> OCFJNIAECCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal GBHGPDCEEMC IMDMIMGGMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal MOEOENAHOEJ LIMMHNNKGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal AIEMCJFFFEM<IHEDEIEMLNB, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>?> CMNOLNNNLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal KHFGELOKLHG<AEAOKLPMJLF<IHEDEIEMLNB>> CJFJLOALDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?> EOGKDPADJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> VariableId, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>> ByteCodeWriteLocation)> DECGGEHAGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> PKEILNIDIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal BNDMAOBBMEA LAIILAJFDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal JOBDDCLEJNG DBNDDAJBHLA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1FB3730", Offset = "0x1FB2130", VA = "0x181FB3730")]
	private IBCECOKELDD([In] KHFGELOKLHG<byte> POLMEJNGIKA, [In] PBLAHGGNEHG PGPFHDKAPMP, [In] APKIILKFBMN NINFJPHHBJD, [In] GBHGPDCEEMC MJOEKJIHJHD, [In] MOEOENAHOEJ BGKAMKCGEGG, [In] AIEMCJFFFEM<IHEDEIEMLNB, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>?> EAKHBFHHCNA, [In] KHFGELOKLHG<AEAOKLPMJLF<IHEDEIEMLNB>> KNBKIDNECMC, [In] AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?> DKFEPNGEOPL, [In] KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> VariableId, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>> ByteCodeWriteLocation)> MHPLDBPCNJF, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> NBPMMBPILDD, [In] BNDMAOBBMEA GELEEBJKJLA, [In] JOBDDCLEJNG IHJJCABDHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2C70", Offset = "0x1FB1670", VA = "0x181FB2C70")]
	public static IBCECOKELDD KHKANEAPNIK()
	{
		return default(IBCECOKELDD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class LNGBKLONCFA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct JEIGAGKNOMG : IIHBOBPHFKO<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>, AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3B10", Offset = "0x1FB2510", VA = "0x181FB3B10")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3BC0", Offset = "0x1FB25C0", VA = "0x181FB3BC0", Slot = "4")]
		public AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> NGJEPEAJAML(int ILOCEPPJPDO)
		{
			return default(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0")]
		public bool BHJDMNCFNHP(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "5")]
		private bool OFDACJAAIPB(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3B00", Offset = "0x1FB2500", VA = "0x181FB3B00", Slot = "6")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> BBJJCAGDOKI(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct HJJCIANCNLK : CBOADCGGDKA<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>, AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2A80", Offset = "0x1FB1480", VA = "0x181FB2A80")]
		public KHFGELOKLHG<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>> NBGADLGPPMO(int JPBPDEHIHCN, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2B00", Offset = "0x1FB1500", VA = "0x181FB2B00")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2BB0", Offset = "0x1FB15B0", VA = "0x181FB2BB0", Slot = "6")]
		public void DFNPFNDBBIN(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>> AHBFNFFEMPG, AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2A80", Offset = "0x1FB1480", VA = "0x181FB2A80", Slot = "4")]
		private KHFGELOKLHG<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>> BCFPPEJFLMN(int JPBPDEHIHCN, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2AF0", Offset = "0x1FB14F0", VA = "0x181FB2AF0", Slot = "5")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> BGBCBOHIFGK(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct AELACNFLJLF : IIHBOBPHFKO<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>, AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC090", Offset = "0x1FAAA90", VA = "0x181FAC090")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC140", Offset = "0x1FAAB40", VA = "0x181FAC140", Slot = "4")]
		public AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> NGJEPEAJAML(int ILOCEPPJPDO)
		{
			return default(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0")]
		public bool BHJDMNCFNHP(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "5")]
		private bool IDBHMMGBGEB(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC080", Offset = "0x1FAAA80", VA = "0x181FAC080", Slot = "6")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> ABJEOPMMKFG(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct OJOJCFBEACO : CBOADCGGDKA<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>, AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6E80", Offset = "0x1FB5880", VA = "0x181FB6E80")]
		public KHFGELOKLHG<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>> NBGADLGPPMO(int JPBPDEHIHCN, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6D10", Offset = "0x1FB5710", VA = "0x181FB6D10")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6DC0", Offset = "0x1FB57C0", VA = "0x181FB6DC0", Slot = "6")]
		public void DFNPFNDBBIN(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>> AHBFNFFEMPG, AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6E80", Offset = "0x1FB5880", VA = "0x181FB6E80", Slot = "4")]
		private KHFGELOKLHG<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>> NDFLKIOMFOH(int JPBPDEHIHCN, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6D00", Offset = "0x1FB5700", VA = "0x181FB6D00", Slot = "5")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> AGLKDBJBJJH(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> ILOCEPPJPDO, [In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct GALDNKAPGIO : IIHBOBPHFKO<AEAOKLPMJLF<BDBPCEJKAMG>, AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1FB24B0", Offset = "0x1FB0EB0", VA = "0x181FB24B0")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(AEAOKLPMJLF<BDBPCEJKAMG> ILOCEPPJPDO, [In] AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2590", Offset = "0x1FB0F90", VA = "0x181FB2590", Slot = "4")]
		public AEAOKLPMJLF<BDBPCEJKAMG> NGJEPEAJAML(int ILOCEPPJPDO)
		{
			return default(AEAOKLPMJLF<BDBPCEJKAMG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2430", Offset = "0x1FB0E30", VA = "0x181FB2430")]
		public bool BHJDMNCFNHP(AEAOKLPMJLF<BDBPCEJKAMG> ILOCEPPJPDO, [In] AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2430", Offset = "0x1FB0E30", VA = "0x181FB2430", Slot = "5")]
		private bool LOGPNHHIGMF(AEAOKLPMJLF<BDBPCEJKAMG> ILOCEPPJPDO, [In] AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2580", Offset = "0x1FB0F80", VA = "0x181FB2580", Slot = "6")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> KDIKFBHFLPK(AEAOKLPMJLF<BDBPCEJKAMG> ILOCEPPJPDO, [In] AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct JNJIHAKCOFG : CBOADCGGDKA<AEAOKLPMJLF<BDBPCEJKAMG>, AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1FB42A0", Offset = "0x1FB2CA0", VA = "0x181FB42A0")]
		public KHFGELOKLHG<AEAOKLPMJLF<BDBPCEJKAMG>> NBGADLGPPMO(int JPBPDEHIHCN, [In] AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<AEAOKLPMJLF<BDBPCEJKAMG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1FB40E0", Offset = "0x1FB2AE0", VA = "0x181FB40E0")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(AEAOKLPMJLF<BDBPCEJKAMG> ILOCEPPJPDO, [In] AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1FB41B0", Offset = "0x1FB2BB0", VA = "0x181FB41B0", Slot = "6")]
		public void DFNPFNDBBIN(AEAOKLPMJLF<BDBPCEJKAMG> ILOCEPPJPDO, AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?> AHBFNFFEMPG, AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1FB42A0", Offset = "0x1FB2CA0", VA = "0x181FB42A0", Slot = "4")]
		private KHFGELOKLHG<AEAOKLPMJLF<BDBPCEJKAMG>> OIHDELABGAB(int JPBPDEHIHCN, [In] AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<AEAOKLPMJLF<BDBPCEJKAMG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4290", Offset = "0x1FB2C90", VA = "0x181FB4290", Slot = "5")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> LIMBIDFKHPP(AEAOKLPMJLF<BDBPCEJKAMG> ILOCEPPJPDO, [In] AIEMCJFFFEM<BDBPCEJKAMG, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>?> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct PDDLHHDILEB : IIHBOBPHFKO<int, KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB7210", Offset = "0x1FB5C10", VA = "0x181FB7210")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> VariableId, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x13808F0", Offset = "0x137F2F0", VA = "0x1813808F0", Slot = "4")]
		public int NGJEPEAJAML(int ILOCEPPJPDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0")]
		public bool BHJDMNCFNHP(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> VariableId, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "5")]
		private bool FALBBAJBNCH(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> VariableId, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB7200", Offset = "0x1FB5C00", VA = "0x181FB7200", Slot = "6")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> BGLJHIMCCLG(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> VariableId, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct HGIOMJLAICC : CBOADCGGDKA<int, KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2A00", Offset = "0x1FB1400", VA = "0x181FB2A00")]
		public KHFGELOKLHG<int> NBGADLGPPMO(int JPBPDEHIHCN, [In] KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> VariableId, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2860", Offset = "0x1FB1260", VA = "0x181FB2860")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> VariableId, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2900", Offset = "0x1FB1300", VA = "0x181FB2900", Slot = "6")]
		public void DFNPFNDBBIN(int ILOCEPPJPDO, KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> VariableId, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>> ByteCodeWriteLocation)> AHBFNFFEMPG, AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2A00", Offset = "0x1FB1400", VA = "0x181FB2A00", Slot = "4")]
		private KHFGELOKLHG<int> KHPCNBNCIBJ(int JPBPDEHIHCN, [In] KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> VariableId, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2A70", Offset = "0x1FB1470", VA = "0x181FB2A70", Slot = "5")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> KOLNPIHKJKG(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> VariableId, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<ABOEOBPACKI>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct DHFNLFIKAMJ : IIHBOBPHFKO<int, KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1FACE90", Offset = "0x1FAB890", VA = "0x181FACE90")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x13808F0", Offset = "0x137F2F0", VA = "0x1813808F0", Slot = "4")]
		public int NGJEPEAJAML(int ILOCEPPJPDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0")]
		public bool BHJDMNCFNHP(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "5")]
		private bool PBNGMHPIHBD(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1FACF30", Offset = "0x1FAB930", VA = "0x181FACF30", Slot = "6")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> MFEFJHELCGF(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct JNAFKCPLCBB : CBOADCGGDKA<int, KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4070", Offset = "0x1FB2A70", VA = "0x181FB4070")]
		public KHFGELOKLHG<int> NBGADLGPPMO(int JPBPDEHIHCN, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3ED0", Offset = "0x1FB28D0", VA = "0x181FB3ED0")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3F80", Offset = "0x1FB2980", VA = "0x181FB3F80", Slot = "6")]
		public void DFNPFNDBBIN(int ILOCEPPJPDO, KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG, AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1FB4070", Offset = "0x1FB2A70", VA = "0x181FB4070", Slot = "4")]
		private KHFGELOKLHG<int> IEKNHCHLHNG(int JPBPDEHIHCN, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3F70", Offset = "0x1FB2970", VA = "0x181FB3F70", Slot = "5")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> DDAEOIBJPJM(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct OOKAKCBMBJJ : IIHBOBPHFKO<int, KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6EF0", Offset = "0x1FB58F0", VA = "0x181FB6EF0")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x13808F0", Offset = "0x137F2F0", VA = "0x1813808F0", Slot = "4")]
		public int NGJEPEAJAML(int ILOCEPPJPDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0")]
		public bool BHJDMNCFNHP(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8678D0", Offset = "0x8662D0", VA = "0x1808678D0", Slot = "5")]
		private bool PBNGMHPIHBD(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6F90", Offset = "0x1FB5990", VA = "0x181FB6F90", Slot = "6")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> MFEFJHELCGF(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct CIMOHNLKCCE : CBOADCGGDKA<int, KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1FACD70", Offset = "0x1FAB770", VA = "0x181FACD70")]
		public KHFGELOKLHG<int> NBGADLGPPMO(int JPBPDEHIHCN, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1FACBC0", Offset = "0x1FAB5C0", VA = "0x181FACBC0")]
		public AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1FACC70", Offset = "0x1FAB670", VA = "0x181FACC70", Slot = "6")]
		public void DFNPFNDBBIN(int ILOCEPPJPDO, KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG, AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> DBOBEHLEAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1FACD70", Offset = "0x1FAB770", VA = "0x181FACD70", Slot = "4")]
		private KHFGELOKLHG<int> IEKNHCHLHNG(int JPBPDEHIHCN, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(KHFGELOKLHG<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1FACC60", Offset = "0x1FAB660", VA = "0x181FACC60", Slot = "5")]
		private AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> DDAEOIBJPJM(int ILOCEPPJPDO, [In] KHFGELOKLHG<(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> Target, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ByteCodeWriteLocation)> AHBFNFFEMPG)
		{
			return default(AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct MMILDAMCEHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BJAENHLPONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool FOMBOGMMFLJ;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x10CCA10", Offset = "0x10CB410", VA = "0x1810CCA10")]
		public MMILDAMCEHO(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB, bool GDLGALLFGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6B10", Offset = "0x1FB5510", VA = "0x181FB6B10")]
		public void DNIPHOADCKN([Out] AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB, [Out] bool GDLGALLFGDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct LNIDNFMCPGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly AEAOKLPMJLF<BDBPCEJKAMG> COPMCAIHLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BJAENHLPONG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool FOMBOGMMFLJ;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6B00", Offset = "0x1FB5500", VA = "0x181FB6B00")]
		public LNIDNFMCPGM(AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB, bool GDLGALLFGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6AF0", Offset = "0x1FB54F0", VA = "0x181FB6AF0")]
		public void DNIPHOADCKN([Out] AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB, [Out] bool GDLGALLFGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1FB6AD0", Offset = "0x1FB54D0", VA = "0x181FB6AD0")]
		public void DNIPHOADCKN([Out] AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB, [Out] AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN, [Out] bool GDLGALLFGDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct JGMABEDFKPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly AEAOKLPMJLF<BDBPCEJKAMG> COPMCAIHLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BJAENHLPONG;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
		public JGMABEDFKPE(AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3BF0", Offset = "0x1FB25F0", VA = "0x181FB3BF0")]
		public void DNIPHOADCKN([Out] AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB, [Out] AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5660", Offset = "0x1FB4060", VA = "0x181FB5660")]
	public static void IKAGPDLIFEB(this IBCECOKELDD BBCPNLGGBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4980", Offset = "0x1FB3380", VA = "0x181FB4980")]
	public static void EEOIDPHFBOG(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> KMGDPLEACFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4FD0", Offset = "0x1FB39D0", VA = "0x181FB4FD0")]
	public static void FHAPHJHFGPH(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> KMGDPLEACFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5D00", Offset = "0x1FB4700", VA = "0x181FB5D00")]
	public static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>? LCPPJLEAECC([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5AA0", Offset = "0x1FB44A0", VA = "0x181FB5AA0")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> IOGCFIOJHHF([In] this IBCECOKELDD BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1FB62F0", Offset = "0x1FB4CF0", VA = "0x181FB62F0")]
	private static void NGOKJEBJOMO(this IBCECOKELDD BBCPNLGGBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB55A0", Offset = "0x1FB3FA0", VA = "0x181FB55A0")]
	private static AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>? IJECMMLKMMC([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5930", Offset = "0x1FB4330", VA = "0x181FB5930")]
	public static void INLIOLHLLNH(this IBCECOKELDD BBCPNLGGBMJ, [In] KHFGELOKLHG<GLHNEJGAEME> KJFBJAIFDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4740", Offset = "0x1FB3140", VA = "0x181FB4740")]
	public static GBHGPDCEEMC.PPBOHLEKGNN DKOMEIENIMC([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB)
	{
		return default(GBHGPDCEEMC.PPBOHLEKGNN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5200", Offset = "0x1FB3C00", VA = "0x181FB5200")]
	public static DAJKLPNGMBB<byte> HDHIAJMEGOK([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB)
	{
		return default(DAJKLPNGMBB<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4E50", Offset = "0x1FB3850", VA = "0x181FB4E50")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> FGEEBBCKIAH([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4AA0", Offset = "0x1FB34A0", VA = "0x181FB4AA0")]
	public static KMKODCHIEIO ELCGNJJBIKK([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB)
	{
		return default(KMKODCHIEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2BE58F0", Offset = "0x2BE42F0", VA = "0x182BE58F0")]
	private static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> GKOENAFFOHP<TMJoin>(this IBCECOKELDD BBCPNLGGBMJ, GBHGPDCEEMC.PPBOHLEKGNN IMMFLLDNCEM, AEAOKLPMJLF<TMJoin> JCDOMIIJNDM) where TMJoin : GBHGPDCEEMC.IGGCBKLFNEF
	{
		return default(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4600", Offset = "0x1FB3000", VA = "0x181FB4600")]
	public static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BOGGIDLKOFM(this IBCECOKELDD BBCPNLGGBMJ, bool MOCAGHFEIFE)
	{
		return default(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4A10", Offset = "0x1FB3410", VA = "0x181FB4A10")]
	public static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> EGGCFCDDFKA(this IBCECOKELDD BBCPNLGGBMJ, DAJKLPNGMBB<byte> KKELJOOMKNM)
	{
		return default(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5C80", Offset = "0x1FB4680", VA = "0x181FB5C80")]
	public static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> KNIFMMKJNGD(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> CPMPDFKNDPH)
	{
		return default(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4B90", Offset = "0x1FB3590", VA = "0x181FB4B90")]
	public static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> ELLJPOHJHFJ(this IBCECOKELDD BBCPNLGGBMJ, int BMMBKMLDPCP)
	{
		return default(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4DD0", Offset = "0x1FB37D0", VA = "0x181FB4DD0")]
	public static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> FDDDMNNEDOE(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NBGBAELNAAF)
	{
		return default(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4F90", Offset = "0x2BE3990", VA = "0x182BE4F90")]
	private static AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB> COFODMHHACA<TMJoin>(this IBCECOKELDD BBCPNLGGBMJ, MOEOENAHOEJ.CMFPKKBNLCI IMMFLLDNCEM, AEAOKLPMJLF<TMJoin> JCDOMIIJNDM) where TMJoin : MOEOENAHOEJ.PIHBFDHEJKB
	{
		return default(AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5DC0", Offset = "0x1FB47C0", VA = "0x181FB5DC0")]
	public static AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB> LFBKFBEMGHB(this IBCECOKELDD BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5120", Offset = "0x1FB3B20", VA = "0x181FB5120")]
	public static AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB> FNPNKGJMJPN(this IBCECOKELDD BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5380", Offset = "0x1FB3D80", VA = "0x181FB5380")]
	public static AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB> HJFNAJPIFEH(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> ADICOPEFHJN)
	{
		return default(AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6690", Offset = "0x1FB5090", VA = "0x181FB6690")]
	public static AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB> OFIPEJKKKKF(this IBCECOKELDD BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB62B0", Offset = "0x1FB4CB0", VA = "0x181FB62B0")]
	public static AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB> NAKJLEOLCMH(this IBCECOKELDD BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB46C0", Offset = "0x1FB30C0", VA = "0x181FB46C0")]
	public static PBLAHGGNEHG.DALDKIAKLAB CJPDJHGAGLL([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM> NNFDMPJGLAD)
	{
		return default(PBLAHGGNEHG.DALDKIAKLAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5160", Offset = "0x1FB3B60", VA = "0x181FB5160")]
	public static BDNDGHPHEGN<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>, HDHIPHHJCBF<PBLAHGGNEHG.KJMPKDPNFOB>> GCFPODDAAID([In] this IBCECOKELDD BBCPNLGGBMJ)
	{
		return default(BDNDGHPHEGN<AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>, HDHIPHHJCBF<PBLAHGGNEHG.KJMPKDPNFOB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB68F0", Offset = "0x1FB52F0", VA = "0x181FB68F0")]
	public static AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> PPPMENEBLAK([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM> NNFDMPJGLAD)
	{
		return default(AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB50A0", Offset = "0x1FB3AA0", VA = "0x181FB50A0")]
	public static PBLAHGGNEHG.OEKECGJBMOB FHOBDLFPCPH([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> GNELAKALNMM)
	{
		return default(PBLAHGGNEHG.OEKECGJBMOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5ED0", Offset = "0x1FB48D0", VA = "0x181FB5ED0")]
	public static PBLAHGGNEHG.OEKECGJBMOB LLGJMBIMKMJ(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> GNELAKALNMM)
	{
		return default(PBLAHGGNEHG.OEKECGJBMOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2BE6000", Offset = "0x2BE4A00", VA = "0x182BE6000")]
	private static AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM> OJFDKPECLDL<TMJoin>(this IBCECOKELDD BBCPNLGGBMJ, PBLAHGGNEHG.DALDKIAKLAB IMMFLLDNCEM, AEAOKLPMJLF<TMJoin> JCDOMIIJNDM) where TMJoin : PBLAHGGNEHG.MBJOOMJFKHJ
	{
		return default(AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FB60E0", Offset = "0x1FB4AE0", VA = "0x181FB60E0")]
	public static (AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>) MKAIPIKGJMF(this IBCECOKELDD BBCPNLGGBMJ)
	{
		return default((AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1FB47C0", Offset = "0x1FB31C0", VA = "0x181FB47C0")]
	public static (AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>) ECDAJJPHKPL(this IBCECOKELDD BBCPNLGGBMJ)
	{
		return default((AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4680", Offset = "0x1FB3080", VA = "0x181FB4680")]
	public static AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM> CEDFJJMJEOH(this IBCECOKELDD BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1FB52F0", Offset = "0x1FB3CF0", VA = "0x181FB52F0")]
	public static void HJDKCCMPJMD(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB> GNELAKALNMM, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> LPBMEAFOKEE, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>> KPIEJDKLJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2BE4730", Offset = "0x2BE3130", VA = "0x182BE4730")]
	public static MMILDAMCEHO AAEJMKAMCDM<TDeps, TStateSys>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN) where TDeps : DHDJCAMANBL<TStateSys>
	{
		return default(MMILDAMCEHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5190", Offset = "0x2BE3B90", VA = "0x182BE5190")]
	public static LNIDNFMCPGM EPKFCJLBCOL<TDeps, TStateSys>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, int OPIPICHPLDD) where TDeps : DHDJCAMANBL<TStateSys>
	{
		return default(LNIDNFMCPGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5C10", Offset = "0x2BE4610", VA = "0x182BE5C10")]
	public static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>? JONFDBCBHAD<TDeps, TStateSys>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, [In] ReadOnlySpan<int> BCOFCLIGAFD, [In] Span<JGMABEDFKPE> PHKKBKENPBJ) where TDeps : DHDJCAMANBL<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5560", Offset = "0x2BE3F60", VA = "0x182BE5560")]
	public static AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB> FAJGEBIEGBG<TDeps, TStateSys>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK) where TDeps : DHDJCAMANBL<TStateSys>
	{
		return default(AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB65A0", Offset = "0x1FB4FA0", VA = "0x181FB65A0")]
	public static APKIILKFBMN.CGMLMDCJPPN OCKNMCEEHIA([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> OBDGAAHPMCD)
	{
		return default(APKIILKFBMN.CGMLMDCJPPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6800", Offset = "0x1FB5200", VA = "0x181FB6800")]
	public static APKIILKFBMN.DMFEJPKBAEP PDFKBKBFGJO([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> OBDGAAHPMCD)
	{
		return default(APKIILKFBMN.DMFEJPKBAEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1FB54B0", Offset = "0x1FB3EB0", VA = "0x181FB54B0")]
	public static APKIILKFBMN.OJCCMBDFICM IHMJKHHOAIG([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> OBDGAAHPMCD)
	{
		return default(APKIILKFBMN.OJCCMBDFICM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5F50", Offset = "0x1FB4950", VA = "0x181FB5F50")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> LOHDPDIPPML(this IBCECOKELDD BBCPNLGGBMJ, int? AMHMKGGEOCM, string CCMEKJGADHN)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5B00", Offset = "0x1FB4500", VA = "0x181FB5B00")]
	public static APKIILKFBMN.NENLDMEBEKG JFMNHIBAIIB([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> OBDGAAHPMCD)
	{
		return default(APKIILKFBMN.NENLDMEBEKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB44C0", Offset = "0x1FB2EC0", VA = "0x181FB44C0")]
	public static APKIILKFBMN.LNADOFKNKED BCNIDKGCDPP([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> OBDGAAHPMCD)
	{
		return default(APKIILKFBMN.LNADOFKNKED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4D60", Offset = "0x1FB3760", VA = "0x181FB4D60")]
	public static int? ENPJIAFCECH([In] this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> OBDGAAHPMCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5E30", Offset = "0x2BE4830", VA = "0x182BE5E30")]
	private static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NGKOFPMCNEP<TMJoin>(this IBCECOKELDD BBCPNLGGBMJ, int? AMHMKGGEOCM, APKIILKFBMN.LNADOFKNKED IMMFLLDNCEM, AEAOKLPMJLF<TMJoin> JCDOMIIJNDM) where TMJoin : APKIILKFBMN.OFHGMLFDJCJ
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5400", Offset = "0x1FB3E00", VA = "0x181FB5400")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HPENPNDIHNJ(this IBCECOKELDD BBCPNLGGBMJ, int? AMHMKGGEOCM, AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM> NNFDMPJGLAD, int ILOCEPPJPDO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4460", Offset = "0x1FB2E60", VA = "0x181FB4460")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> BCLMBJHLLBE(this IBCECOKELDD BBCPNLGGBMJ, int? AMHMKGGEOCM)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4C10", Offset = "0x1FB3610", VA = "0x181FB4C10")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> EMFLDJOJENH(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>? BHENIBLBMJJ, int? AMHMKGGEOCM)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5BF0", Offset = "0x1FB45F0", VA = "0x181FB5BF0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JOHOFLLJLPI(this IBCECOKELDD BBCPNLGGBMJ, int? AMHMKGGEOCM, int ILOCEPPJPDO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1FB51A0", Offset = "0x1FB3BA0", VA = "0x181FB51A0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HBEAMBANHBH(this IBCECOKELDD BBCPNLGGBMJ, int? AMHMKGGEOCM)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6460", Offset = "0x1FB4E60", VA = "0x181FB6460")]
	public static void NMJLMEKJKLI(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NBGBAELNAAF, AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM> NNFDMPJGLAD, int ILOCEPPJPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1FB66D0", Offset = "0x1FB50D0", VA = "0x181FB66D0")]
	public static void ONGHLJCNOIN(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NBGBAELNAAF, int ILOCEPPJPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1FB5E00", Offset = "0x1FB4800", VA = "0x181FB5E00")]
	public static void LJGHMBANOLF(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NBGBAELNAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4F40", Offset = "0x1FB3940", VA = "0x181FB4F40")]
	public static void FGKJILCLFIM(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> PIBCCEDJCCL, AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> LLIAMDCIKFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4530", Offset = "0x1FB2F30", VA = "0x181FB4530")]
	public static void BKNLHGPFIGJ(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NBGBAELNAAF, AEAOKLPMJLF<MPIMPNCNAOI<BKKMOABAPKC>> LKOMKMBEBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2BE5F30", Offset = "0x2BE4930", VA = "0x182BE5F30")]
	public static void NKNGMJDBEAH<M>(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NBGBAELNAAF, AEAOKLPMJLF<MPIMPNCNAOI<PNEAIIFMLDM<M>>> LKOMKMBEBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface DHDJCAMANBL<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AEAOKLPMJLF<FNJJLOFGLPE> JPBPDJABLFH(TStateSys GIGDOMADJKF);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AEAOKLPMJLF<FNJJLOFGLPE> MEAJDJNIOFG(TStateSys GIGDOMADJKF);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AEAOKLPMJLF<FNJJLOFGLPE> ECFIOOBAPPC(TStateSys GIGDOMADJKF);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AEAOKLPMJLF<FNJJLOFGLPE> GPBFBILJDGB(TStateSys GIGDOMADJKF);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB> KBOMHHFNOGC(TStateSys GIGDOMADJKF, IBCECOKELDD OJHEFGCKEAI, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> HKICNDNBLDO(TStateSys GIGDOMADJKF, IBCECOKELDD OJHEFGCKEAI, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FMNGKEDFKDB(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AEAOKLPMJLF<IHEDEIEMLNB> FGGCEKNFMEE(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN, int KIAKECHEIHO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MDOOGDGMAGG DEGAMHCCIBB(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HOCELAGFOHD(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int JDOOGHHLCNM(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	DAJKLPNGMBB<byte> ILBLPBNLIII(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(DAJKLPNGMBB<byte>, AEAOKLPMJLF<FNJJLOFGLPE>) BAKMBHPEMBK(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<BDBPCEJKAMG> DGIOPPMBDMN);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int CFJPBFLFGCG(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AEAOKLPMJLF<BDBPCEJKAMG> IPBOIKPACON(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<IHEDEIEMLNB> JALOBJNANCK, int OPIPICHPLDD);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AEAOKLPMJLF<BDBPCEJKAMG> KGLGCNKNDON(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, AEAOKLPMJLF<KLHFMEEJLPO> OAAAKELMLJG, int OPIPICHPLDD);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int HAOLEIGJAAD(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? JDPAMFJNJGJ(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, int ILOCEPPJPDO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int OJIILIFAIGI(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? FKBEEAEAEAL(TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC, int ILOCEPPJPDO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DPAAIBDELAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x29965F0", Offset = "0x2994FF0", VA = "0x1829965F0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE?> FFOAEAHPIOC<T, TOpInput, TOpOutput>(this IBCECOKELDD BBCPNLGGBMJ, T NNEJNMNIIPM, T MENCHHOFOIO, int BNBMJOGDOHC, IntPtr HOOCHEJJIDI)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2994FD0", Offset = "0x29939D0", VA = "0x182994FD0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE?> AGHHOHMKNFK<T, TOpInput, TOpOutput>(this IBCECOKELDD BBCPNLGGBMJ, T NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO, int BNBMJOGDOHC, IntPtr HOOCHEJJIDI)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2997BB0", Offset = "0x29965B0", VA = "0x182997BB0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE?> MALLIPPBKOM<TOpInput, TOpOutput>(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO, int BNBMJOGDOHC, IntPtr HOOCHEJJIDI)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFB80", Offset = "0x1FAE580", VA = "0x181FAFB80")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JGOHIPDBLDH(this IBCECOKELDD BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEBC0", Offset = "0x1FAD5C0", VA = "0x181FAEBC0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HALKAMHNBAK(this IBCECOKELDD BBCPNLGGBMJ, float JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF190", Offset = "0x1FADB90", VA = "0x181FAF190")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> IFMBOODCPPJ(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1760", Offset = "0x1FB0160", VA = "0x181FB1760")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NACJGBOPLIM(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD9A0", Offset = "0x1FAC3A0", VA = "0x181FAD9A0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> CEOBLHIOEAC(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2090", Offset = "0x1FB0A90", VA = "0x181FB2090")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> PLEONMANJMH(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB06B0", Offset = "0x1FAF0B0", VA = "0x181FB06B0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> KOBMMJMBDLK(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1D90", Offset = "0x1FB0790", VA = "0x181FB1D90")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> PBBHNAAMBML(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1FADEE0", Offset = "0x1FAC8E0", VA = "0x181FADEE0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> EADOFBKBEGE(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1FADC50", Offset = "0x1FAC650", VA = "0x181FADC50")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> DBLAONIFKGI(this IBCECOKELDD BBCPNLGGBMJ, int NNEJNMNIIPM, int MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF920", Offset = "0x1FAE320", VA = "0x181FAF920")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JEHGBPIMHEF(this IBCECOKELDD BBCPNLGGBMJ, int NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB15A0", Offset = "0x1FAFFA0", VA = "0x181FB15A0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MLNDPKLMCLA(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0F50", Offset = "0x1FAF950", VA = "0x181FB0F50")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MJNINAKNAKP(this IBCECOKELDD BBCPNLGGBMJ, float NNEJNMNIIPM, float MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE540", Offset = "0x1FACF40", VA = "0x181FAE540")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> ENMEKJOHFBE(this IBCECOKELDD BBCPNLGGBMJ, float NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF3D0", Offset = "0x1FADDD0", VA = "0x181FAF3D0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> IIAPBILJDPP(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2F0", Offset = "0x1FABCF0", VA = "0x181FAD2F0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> AGHGHIELBKG(this IBCECOKELDD BBCPNLGGBMJ, int NNEJNMNIIPM, int MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFF90", Offset = "0x1FAE990", VA = "0x181FAFF90")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> KIBCLIBLCAG(this IBCECOKELDD BBCPNLGGBMJ, int NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1FADBD0", Offset = "0x1FAC5D0", VA = "0x181FADBD0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> CPMLIFLEBEL(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1970", Offset = "0x1FB0370", VA = "0x181FB1970")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NCLHEOMIGCN(this IBCECOKELDD BBCPNLGGBMJ, float NNEJNMNIIPM, float MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1FADB50", Offset = "0x1FAC550", VA = "0x181FADB50")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> CNAFCNCBDCC(this IBCECOKELDD BBCPNLGGBMJ, float NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1AF0", Offset = "0x1FB04F0", VA = "0x181FB1AF0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NLDGAGFBNNH(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1FADE60", Offset = "0x1FAC860", VA = "0x181FADE60")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> DNDGOIGFEII(this IBCECOKELDD BBCPNLGGBMJ, int NNEJNMNIIPM, int MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB16E0", Offset = "0x1FB00E0", VA = "0x181FB16E0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NAAODFIJABE(this IBCECOKELDD BBCPNLGGBMJ, int NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD5B0", Offset = "0x1FABFB0", VA = "0x181FAD5B0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> BLBNBNIMBJH(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD630", Offset = "0x1FAC030", VA = "0x181FAD630")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> BLMLCOKNPIH(this IBCECOKELDD BBCPNLGGBMJ, float NNEJNMNIIPM, float MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFDA0", Offset = "0x1FAE7A0", VA = "0x181FAFDA0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JMLLJPFLLBH(this IBCECOKELDD BBCPNLGGBMJ, float NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1D10", Offset = "0x1FB0710", VA = "0x181FB1D10")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> OPGDGHKLFJO(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF650", Offset = "0x1FAE050", VA = "0x181FAF650")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> IMGHKCMILDI(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1B70", Offset = "0x1FB0570", VA = "0x181FB1B70")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> OBHCCFJMBEH(this IBCECOKELDD BBCPNLGGBMJ, int DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE670", Offset = "0x1FAD070", VA = "0x181FAE670")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> FDEMEGEBPGD(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEFE0", Offset = "0x1FAD9E0", VA = "0x181FAEFE0")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> IBIINILJGDA(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BADDLAFMBNB)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFF10", Offset = "0x1FAE910", VA = "0x181FAFF10")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> KFEDMFEFEBG(this IBCECOKELDD BBCPNLGGBMJ, int DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE4A0", Offset = "0x1FACEA0", VA = "0x181FAE4A0")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> ELBACKGDBNP(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1140", Offset = "0x1FAFB40", VA = "0x181FB1140")]
	public static (AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>) MLEKBPHOJPL(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<PLOGIFEADJP> EDPLPIHMHBM, [In] ReadOnlySpan<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> HJDONKPJEOG, [In] ReadOnlySpan<int?> DFJNFPKAFDF, [In] Span<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> DMCGDCNDLCN)
	{
		return default((AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0240", Offset = "0x1FAEC40", VA = "0x181FB0240")]
	public static (AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>) KMNOMBLKEOL(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<FDJGKMNJDKI> PANEJEDHHIP, [In] ReadOnlySpan<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> HJDONKPJEOG, [In] ReadOnlySpan<int?> DFJNFPKAFDF, [In] Span<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> DMCGDCNDLCN)
	{
		return default((AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2996E90", Offset = "0x2995890", VA = "0x182996E90")]
	public static (AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<FNJJLOFGLPE>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<TMarker>>, AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>) HEEDPDKKIHC<TMarker>(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<FNJJLOFGLPE> EPHOFGCMDAF, [In] ReadOnlySpan<byte> EEOBDBMOHPL)
	{
		return default((AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<MPIMPNCNAOI<FNJJLOFGLPE>>, AEAOKLPMJLF<MPIMPNCNAOI<CHLIDABPDDH>>, AEAOKLPMJLF<MPIMPNCNAOI<TMarker>>, AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD6B0", Offset = "0x1FAC0B0", VA = "0x181FAD6B0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> BMNIIIEHIGF(this IBCECOKELDD BBCPNLGGBMJ, int CLIKFJHOANF, [Optional] AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>? IAJKDACGMME)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0B30", Offset = "0x1FAF530", VA = "0x181FB0B30")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> LIOJGAPHCBP(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> CLIKFJHOANF, [Optional] AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>? IAJKDACGMME)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1EB0", Offset = "0x1FB08B0", VA = "0x181FB1EB0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> PKAFMPJEEIC(this IBCECOKELDD BBCPNLGGBMJ, [In] ReadOnlySpan<byte> CLIKFJHOANF, [Optional] AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>? IAJKDACGMME)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1FADD40", Offset = "0x1FAC740", VA = "0x181FADD40")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> DDNALPDGGKK(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> CLIKFJHOANF, int BKEGNEKBPFA, [Optional] AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>? IAJKDACGMME)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1FB19F0", Offset = "0x1FB03F0", VA = "0x181FB19F0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NGJGOGMFCKH(this IBCECOKELDD BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0010", Offset = "0x1FAEA10", VA = "0x181FB0010")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> KIMENAJPAPD(this IBCECOKELDD BBCPNLGGBMJ, float JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1FAED60", Offset = "0x1FAD760", VA = "0x181FAED60")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HGGBNFBIJDD(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0C20", Offset = "0x1FAF620", VA = "0x181FB0C20")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MBAHMPDLGIB(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0D10", Offset = "0x1FAF710", VA = "0x181FB0D10")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MCHGIJBOEHB(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD860", Offset = "0x1FAC260", VA = "0x181FAD860")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> CCHMFDHBJHB(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE120", Offset = "0x1FACB20", VA = "0x181FAE120")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> EGJKAKJHKBI(this IBCECOKELDD BBCPNLGGBMJ, int NNEJNMNIIPM, int MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1FAECE0", Offset = "0x1FAD6E0", VA = "0x181FAECE0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HGBCMECGNFM(this IBCECOKELDD BBCPNLGGBMJ, int NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1FADAD0", Offset = "0x1FAC4D0", VA = "0x181FADAD0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> CIPEBKMFHOC(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NNEJNMNIIPM, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MENCHHOFOIO)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD4B0", Offset = "0x1FABEB0", VA = "0x181FAD4B0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> BIIFNEGNPOB(this IBCECOKELDD BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1FB07A0", Offset = "0x1FAF1A0", VA = "0x181FB07A0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> KOEOIJMNIAI(this IBCECOKELDD BBCPNLGGBMJ, float JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1FB08D0", Offset = "0x1FAF2D0", VA = "0x181FB08D0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> LAIFCIHHIEH(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1050", Offset = "0x1FAFA50", VA = "0x181FB1050")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MKADPPKPGOJ(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE710", Offset = "0x1FAD110", VA = "0x181FAE710")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> FKDFDGOGONL(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD370", Offset = "0x1FABD70", VA = "0x181FAD370")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> BGIAABCIFMA(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1BF0", Offset = "0x1FB05F0", VA = "0x181FB1BF0")]
	public static AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>> OFEOAKHBBDF(this IBCECOKELDD BBCPNLGGBMJ)
	{
		return default(AEAOKLPMJLF<MPIMPNCNAOI<MPIMPNCNAOI<BDKFFLBNIHO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF2D0", Offset = "0x1FADCD0", VA = "0x181FAF2D0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> IHEMOFJILID(this IBCECOKELDD BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0A10", Offset = "0x1FAF410", VA = "0x181FB0A10")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> LDMIJDFOLGF(this IBCECOKELDD BBCPNLGGBMJ, float JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD1B0", Offset = "0x1FABBB0", VA = "0x181FAD1B0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> ACDMOFHPKAH(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD770", Offset = "0x1FAC170", VA = "0x181FAD770")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> BODNLBHFHMD(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF800", Offset = "0x1FAE200", VA = "0x181FAF800")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAGHNECCMEN(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1FAF510", Offset = "0x1FADF10", VA = "0x181FAF510")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> IMGEFKNILJB(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1C10", Offset = "0x1FB0610", VA = "0x181FB1C10")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> OMILFEBPMAE(this IBCECOKELDD BBCPNLGGBMJ, int DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0130", Offset = "0x1FAEB30", VA = "0x181FB0130")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> KKKHJMPNCKJ(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> DBOBEHLEAAE)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1FADAC0", Offset = "0x1FAC4C0", VA = "0x181FADAC0")]
	public static void CIOIFNNBADE(this IBCECOKELDD BBCPNLGGBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE020", Offset = "0x1FACA20", VA = "0x181FAE020")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> EEPDMCFFPNE(this IBCECOKELDD BBCPNLGGBMJ, float JAEBINEILPK, float HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1850", Offset = "0x1FB0250", VA = "0x181FB1850")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> NAKAPPOFBLP(this IBCECOKELDD BBCPNLGGBMJ, float JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1FACF40", Offset = "0x1FAB940", VA = "0x181FACF40")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> AAKEGOOGHLE(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFE20", Offset = "0x1FAE820", VA = "0x181FAFE20")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> KBPJLCIIEHO(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1FB0E30", Offset = "0x1FAF830", VA = "0x181FB0E30")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> MDBKHGANLDD(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFA40", Offset = "0x1FAE440", VA = "0x181FAFA40")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JFANDMLFICL(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE830", Offset = "0x1FAD230", VA = "0x181FAE830")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> FLOAMEBIPNE(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> JFPBANLMPAJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> OBCLKNLPCBC)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1FB1FA0", Offset = "0x1FB09A0", VA = "0x181FB1FA0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> PLAGFEJPFJD(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, int HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1FAFC80", Offset = "0x1FAE680", VA = "0x181FAFC80")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JJGDPFKCFBD(this IBCECOKELDD BBCPNLGGBMJ, int JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1FAEEA0", Offset = "0x1FAD8A0", VA = "0x181FAEEA0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HIKNEHLFIJD(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JAEBINEILPK, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> HODNNKKLCPA)
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2996320", Offset = "0x2994D20", VA = "0x182996320")]
	public static void FAFLOOPKOMO<TDeps, TState>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TState FAKDNFCMPPB, AEAOKLPMJLF<PLOGIFEADJP> EDPLPIHMHBM, [In] ReadOnlySpan<AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>> DDNBNPIODFI, [In] ReadOnlySpan<int?> DFJNFPKAFDF, [In] Span<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> DMCGDCNDLCN, [In] Span<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> OILKMAIDHPE, [In] ReadOnlySpan<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>?> LMLLJNLHJKD) where TDeps : notnull, DHDJCAMANBL<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2996BC0", Offset = "0x29955C0", VA = "0x182996BC0")]
	public static void FKNHLJPMDKJ<TDeps, TState>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TState FAKDNFCMPPB, AEAOKLPMJLF<FDJGKMNJDKI> MFKPABNLOJE, [In] ReadOnlySpan<AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>> CCBHCOOCFCG, [In] ReadOnlySpan<int?> DFJNFPKAFDF, [In] Span<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> DMCGDCNDLCN, [In] Span<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>> OILKMAIDHPE, [In] ReadOnlySpan<AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>?> LMLLJNLHJKD) where TDeps : notnull, DHDJCAMANBL<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2997710", Offset = "0x2996110", VA = "0x182997710")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> JIIGLJHGIIK<TDeps, TState>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TState FAKDNFCMPPB, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> BHENIBLBMJJ, [Optional] AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>? IAJKDACGMME) where TDeps : notnull, DHDJCAMANBL<TState> where TState : notnull
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x29973F0", Offset = "0x2995DF0", VA = "0x1829973F0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> IJKDIJIBMLK<TDeps, TState>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TState FAKDNFCMPPB, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> ADICOPEFHJN, [Optional] AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>? IAJKDACGMME) where TDeps : notnull, DHDJCAMANBL<TState> where TState : notnull
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2997090", Offset = "0x2995A90", VA = "0x182997090")]
	public static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> HNNPGLPPDBJ<TDeps, TStateSys>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TStateSys GIGDOMADJKF) where TDeps : notnull, DHDJCAMANBL<TStateSys> where TStateSys : notnull
	{
		return default(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2997E10", Offset = "0x2996810", VA = "0x182997E10")]
	public static AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB> OALIFKHHGBN<TDeps, TStateSys>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TStateSys GIGDOMADJKF) where TDeps : notnull, DHDJCAMANBL<TStateSys> where TStateSys : notnull
	{
		return default(AEAOKLPMJLF<MOEOENAHOEJ.JOHLILBJCOB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD080", Offset = "0x1FABA80", VA = "0x181FAD080")]
	public static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> AAPLKHNGLCB(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> FJJDFIBCJNH, IntPtr KLFDBDEHJPJ, IntPtr CIIIFLAJHAP)
	{
		return default(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE1A0", Offset = "0x1FACBA0", VA = "0x181FAE1A0")]
	public static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> EHCENFDEMJP(this IBCECOKELDD BBCPNLGGBMJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> NDFLCDBPEOJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> ICKGBBOJAMN, IntPtr EEKNHFJBLJL, IntPtr KEBHBDOEEEK, IntPtr KEBFIIAINHH, bool KEEHIFBDKKC)
	{
		return default(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2995BB0", Offset = "0x29945B0", VA = "0x182995BB0")]
	public static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BGHNBAPBBKN<TDeps, TState>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TState FAKDNFCMPPB, AEAOKLPMJLF<PLOGIFEADJP> HECGGGEPGAB, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> NDFLCDBPEOJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> ICKGBBOJAMN, int? LJECCMMOIOI, [Optional] IntPtr BIJBDDCEOED) where TDeps : notnull, DHDJCAMANBL<TState> where TState : notnull
	{
		return default(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x29958A0", Offset = "0x29942A0", VA = "0x1829958A0")]
	private static AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> BGHNBAPBBKN<TDeps, TState>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TState FAKDNFCMPPB, AEAOKLPMJLF<PLOGIFEADJP> HECGGGEPGAB, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> NDFLCDBPEOJ, AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP> ICKGBBOJAMN, int? LJECCMMOIOI) where TDeps : notnull, DHDJCAMANBL<TState> where TState : notnull
	{
		return default(AEAOKLPMJLF<GBHGPDCEEMC.NOMBCFICFKP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x29979C0", Offset = "0x29963C0", VA = "0x1829979C0")]
	public static AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> KCOJINLIJDF<TDeps, TState>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TState FAKDNFCMPPB, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE> CLIKFJHOANF, AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>? IAJKDACGMME) where TDeps : notnull, DHDJCAMANBL<TState> where TState : notnull
	{
		return default(AEAOKLPMJLF<APKIILKFBMN.AMLDAKOMPEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2995EF0", Offset = "0x29948F0", VA = "0x182995EF0")]
	public static void CFEEJOMLPIC<TDeps, TState>(this IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TState FAKDNFCMPPB, int BGLGOOLDJPF) where TDeps : notnull, DHDJCAMANBL<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct NFKJAFIJKCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> EINNKHJHMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> KFPFBIFAKEB;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
	public NFKJAFIJKCK(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> CPGPOECHBIC, AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> CIEFMDNCNEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB6BF0", Offset = "0x1FB55F0", VA = "0x181FB6BF0")]
	public static NFKJAFIJKCK KHKANEAPNIK(AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>> CPGPOECHBIC)
	{
		return default(NFKJAFIJKCK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct APKIILKFBMN
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class JOMONEHKOHC : OFHGMLFDJCJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct CGMLMDCJPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM> CDPCPFNLDGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int JCLKIAMNLIO;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
		public CGMLMDCJPPN(AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM> NNFDMPJGLAD, int ILOCEPPJPDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class GJKABJFJAJM : OFHGMLFDJCJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct DMFEJPKBAEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int JCLKIAMNLIO;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
		public DMFEJPKBAEP(int ILOCEPPJPDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class CDKNKDIBIPC : OFHGMLFDJCJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct OJCCMBDFICM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM> CDPCPFNLDGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int JCLKIAMNLIO;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xC2A010", Offset = "0xC28A10", VA = "0x180C2A010")]
		public OJCCMBDFICM(AEAOKLPMJLF<PBLAHGGNEHG.IBGALOCOAOM> NNFDMPJGLAD, int ILOCEPPJPDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum LNADOFKNKED
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
	public sealed class AMLDAKOMPEE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class OFHGMLFDJCJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct GCJDJGIIHOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? EHCCFDHJAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public NFKJAFIJKCK BHMFMHIMFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public LNADOFKNKED GAGDNAGNODP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AEAOKLPMJLF<OFHGMLFDJCJ> MPDKFCOIPIG;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FB2840", Offset = "0x1FB1240", VA = "0x181FB2840")]
		public GCJDJGIIHOC(int? AMHMKGGEOCM, [In] NFKJAFIJKCK NNAHIKHCHAB, LNADOFKNKED IMMFLLDNCEM, AEAOKLPMJLF<OFHGMLFDJCJ> JCDOMIIJNDM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class CBODFBNFKLD : OFHGMLFDJCJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct NENLDMEBEKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int JCLKIAMNLIO;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA72650", Offset = "0xA71050", VA = "0x180A72650")]
		public NENLDMEBEKG(int ILOCEPPJPDO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal LDOLIFPJCFP<AMLDAKOMPEE, GCJDJGIIHOC> EPJEOLAINMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal LDOLIFPJCFP<JOMONEHKOHC, CGMLMDCJPPN> CKMNNJFOHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal LDOLIFPJCFP<CDKNKDIBIPC, OJCCMBDFICM> INFCFJADJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal LDOLIFPJCFP<CBODFBNFKLD, NENLDMEBEKG> AEAJHLAJEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal LDOLIFPJCFP<GJKABJFJAJM, DMFEJPKBAEP> FKJEDBBGIME;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC480", Offset = "0x1FAAE80", VA = "0x181FAC480")]
	private APKIILKFBMN([In] LDOLIFPJCFP<AMLDAKOMPEE, GCJDJGIIHOC> FMLJDAHLEGG, [In] LDOLIFPJCFP<JOMONEHKOHC, CGMLMDCJPPN> BHGONFHBMGP, [In] LDOLIFPJCFP<CDKNKDIBIPC, OJCCMBDFICM> NFHMACFCPBL, [In] LDOLIFPJCFP<CBODFBNFKLD, NENLDMEBEKG> LINALBABGED, [In] LDOLIFPJCFP<GJKABJFJAJM, DMFEJPKBAEP> IKGNINGABBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC290", Offset = "0x1FAAC90", VA = "0x181FAC290")]
	public static APKIILKFBMN KHKANEAPNIK()
	{
		return default(APKIILKFBMN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BBNGPKFAMJM
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC5B0", Offset = "0x1FAAFB0", VA = "0x181FAC5B0")]
	public static void IKAGPDLIFEB(this APKIILKFBMN BBCPNLGGBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FFIEHMOJANO
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1FB22D0", Offset = "0x1FB0CD0", VA = "0x181FB22D0")]
	public static void AJIENLNABLE(IBCECOKELDD BBCPNLGGBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct BNDMAOBBMEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AMCJGCCIEAA> MECCOLHLPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int IFHDHJNOBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int MFEAKKINLCG;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC920", Offset = "0x1FAB320", VA = "0x181FAC920")]
	private BNDMAOBBMEA([In] AIEMCJFFFEM<PBLAHGGNEHG.KJMPKDPNFOB, AMCJGCCIEAA> LEEBAOPAEEN, int EFFCJNDGBPB, int HAKBPLMNAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC8B0", Offset = "0x1FAB2B0", VA = "0x181FAC8B0")]
	public static BNDMAOBBMEA KHKANEAPNIK()
	{
		return default(BNDMAOBBMEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1FAC6C0", Offset = "0x1FAB0C0", VA = "0x181FAC6C0")]
	public void IKAGPDLIFEB([In] IBCECOKELDD KNJFLEFNAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x28CB350", Offset = "0x28C9D50", VA = "0x1828CB350")]
	public static void AJIENLNABLE<TDeps, TStateSys>(IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TStateSys GIGDOMADJKF, AEAOKLPMJLF<NBLNJAIONPA> OLJKGANNLIC) where TDeps : notnull, DHDJCAMANBL<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class JMBIPHLCFFA
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1FB3D00", Offset = "0x1FB2700", VA = "0x181FB3D00")]
	public static void AJIENLNABLE(IBCECOKELDD BBCPNLGGBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct JOBDDCLEJNG
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface JMECHJNPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EBCCBKAHMAF(KHFGELOKLHG<byte> POLMEJNGIKA, int MFDCGOPHOPO);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct JJKMEDKKIAL : JMECHJNPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3C00", Offset = "0x1FB2600", VA = "0x181FB3C00", Slot = "4")]
		public void EBCCBKAHMAF(KHFGELOKLHG<byte> POLMEJNGIKA, int MFDCGOPHOPO)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct DCPAODHEPMB : JMECHJNPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1FACDE0", Offset = "0x1FAB7E0", VA = "0x181FACDE0", Slot = "4")]
		public void EBCCBKAHMAF(KHFGELOKLHG<byte> POLMEJNGIKA, int MFDCGOPHOPO)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct JJLCIGBNEDI : JMECHJNPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1FB3C80", Offset = "0x1FB2680", VA = "0x181FB3C80", Slot = "4")]
		public void EBCCBKAHMAF(KHFGELOKLHG<byte> POLMEJNGIKA, int MFDCGOPHOPO)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct GANEFDIAIAF : JMECHJNPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1FB25C0", Offset = "0x1FB0FC0", VA = "0x181FB25C0", Slot = "4")]
		public void EBCCBKAHMAF(KHFGELOKLHG<byte> POLMEJNGIKA, int MFDCGOPHOPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class FMCPIOCCNFL<TCallProcessorDeps> where TCallProcessorDeps : struct, JMECHJNPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps OHOKKIEJNJH;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2A642B0", Offset = "0x2A62CB0", VA = "0x182A642B0")]
		public static int AJIENLNABLE<TDeps, TStateSys>(TDeps GMLBPALEECE, TStateSys FAKDNFCMPPB, IBCECOKELDD KNJFLEFNAIO, [In] KHFGELOKLHG<byte> CMALLBAECMJ, int LMJCPBMGFKO) where TDeps : DHDJCAMANBL<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private KHFGELOKLHG<GLHNEJGAEME> CAEJPGGNBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>> FNMKAMFNAAK;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4410", Offset = "0x1FB2E10", VA = "0x181FB4410")]
	private JOBDDCLEJNG([In] KHFGELOKLHG<GLHNEJGAEME> KJFBJAIFDEA, Dictionary<AEAOKLPMJLF<MPIMPNCNAOI<BDKFFLBNIHO>>, AEAOKLPMJLF<PBLAHGGNEHG.KJMPKDPNFOB>> ONBMLECDACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4350", Offset = "0x1FB2D50", VA = "0x181FB4350")]
	public static JOBDDCLEJNG KHKANEAPNIK()
	{
		return default(JOBDDCLEJNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1FB4310", Offset = "0x1FB2D10", VA = "0x181FB4310")]
	public void IKAGPDLIFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2B84F70", Offset = "0x2B83970", VA = "0x182B84F70")]
	public static void AJIENLNABLE<TDeps, TStateSys>(IBCECOKELDD BBCPNLGGBMJ, TDeps GMLBPALEECE, TStateSys GIGDOMADJKF) where TDeps : DHDJCAMANBL<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class CGBLKMDEGKD<TDeps, TIndex, TValues> where TDeps : struct, CBOADCGGDKA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps OHOKKIEJNJH;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5163220", Offset = "0x5161C20", VA = "0x185163220")]
	public static void AJIENLNABLE([In] KHFGELOKLHG<GLHNEJGAEME> KJFBJAIFDEA, int JPBPDEHIHCN, TValues AHBFNFFEMPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface CBOADCGGDKA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KHFGELOKLHG<TIndex> NBGADLGPPMO(int JPBPDEHIHCN, [In] TValues AHBFNFFEMPG);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(TIndex ILOCEPPJPDO, [In] TValues AHBFNFFEMPG);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFNPFNDBBIN(TIndex ILOCEPPJPDO, TValues AHBFNFFEMPG, AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> DBOBEHLEAAE);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface IIHBOBPHFKO<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex NGJEPEAJAML(int ILOCEPPJPDO);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BHJDMNCFNHP(TIndex ILOCEPPJPDO, [In] TValues AHBFNFFEMPG);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AEAOKLPMJLF<MPIMPNCNAOI<ABOEOBPACKI>> CFINBDFFFKA(TIndex ILOCEPPJPDO, [In] TValues AHBFNFFEMPG);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class BHDFBFFELND<TDeps, TIndex, TValues> where TDeps : struct, IIHBOBPHFKO<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps OHOKKIEJNJH;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4DDA530", Offset = "0x4DD8F30", VA = "0x184DDA530")]
	public static KHFGELOKLHG<TIndex> AJIENLNABLE(int JPBPDEHIHCN, [In] TValues AHBFNFFEMPG)
	{
		return default(KHFGELOKLHG<TIndex>);
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
