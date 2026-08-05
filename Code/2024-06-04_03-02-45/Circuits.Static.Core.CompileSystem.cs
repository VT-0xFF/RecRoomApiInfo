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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D310", Offset = "0x1F4BB10", VA = "0x181F4D310")]
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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
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
public readonly struct CMIDFIOMJIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> EODFJBHKMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int FHAALGCKALP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
	public CMIDFIOMJIH(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> LBANIEJNOIP, int MFLLOPOPNNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct FLBBNACDOMO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class AEJPABGMAAK : IODLMCAOIAB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct BIFOEBECMIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly IBHGNNAFJNL<byte> MOPNBKPJBDN;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1EF1A60", Offset = "0x1EF0260", VA = "0x181EF1A60")]
		public BIFOEBECMIJ(IBHGNNAFJNL<byte> GHFEJDPMJDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F434C0", Offset = "0x1F41CC0", VA = "0x181F434C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BBEANFODIOE : IODLMCAOIAB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct EBJPCPNDMIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> KFNPHDNFBBP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
		public EBJPCPNDMIH(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> MCFPLNNMJPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum BEPHOMPJEAN
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
	public sealed class JHBILDIEIDH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class IODLMCAOIAB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct FBHMBBKBDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly BEPHOMPJEAN JKCPOGOLCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly KPFGDODNFBO<IODLMCAOIAB> GPOJPCNDIHG;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
		public FBHMBBKBDGN(BEPHOMPJEAN GINCABKOJCC, KPFGDODNFBO<IODLMCAOIAB> GFHNJHKNBCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class DKDGOJEAEHH : IODLMCAOIAB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct MFBMDPHAHBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> FIHBAPNBFAJ;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
		public MFBMDPHAHBB(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AJPMCKHNNHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class AMNKJCNNAJJ : IODLMCAOIAB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct PLFNKLJDNBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly AFFMEBCPHON KLCLEBCKMCG;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
		public PLFNKLJDNBJ(AFFMEBCPHON PPBKCGAJBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D440", Offset = "0x1F4BC40", VA = "0x181F4D440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal DPKMCLCFMEL<JHBILDIEIDH, FBHMBBKBDGN> ANFPIIPHNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal DPKMCLCFMEL<AEJPABGMAAK, BIFOEBECMIJ> IIBOEEJJDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal DPKMCLCFMEL<BBEANFODIOE, EBJPCPNDMIH> FFCAKFNCFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal DPKMCLCFMEL<DKDGOJEAEHH, MFBMDPHAHBB> BKAKCANLFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal DPKMCLCFMEL<AMNKJCNNAJJ, PLFNKLJDNBJ> MGFHCAFPBMK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1F46E00", Offset = "0x1F45600", VA = "0x181F46E00")]
	private FLBBNACDOMO([In] DPKMCLCFMEL<JHBILDIEIDH, FBHMBBKBDGN> NKPIONBJHPK, [In] DPKMCLCFMEL<AEJPABGMAAK, BIFOEBECMIJ> JBNNFLIFKNK, [In] DPKMCLCFMEL<BBEANFODIOE, EBJPCPNDMIH> HBGFEEMFMFG, [In] DPKMCLCFMEL<DKDGOJEAEHH, MFBMDPHAHBB> BAJIJAODCOE, [In] DPKMCLCFMEL<AMNKJCNNAJJ, PLFNKLJDNBJ> GFOBEANKJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1F46CC0", Offset = "0x1F454C0", VA = "0x181F46CC0")]
	public static FLBBNACDOMO OJFFIHPLODM()
	{
		return default(FLBBNACDOMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EPCPAKAHLFJ
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1F44430", Offset = "0x1F42C30", VA = "0x181F44430")]
	public static void PGFGBHFCFEG(this FLBBNACDOMO EGJINJKGIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum BOCGCDMFLPC
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
public struct LPIPPNKCDEB
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class KDHBIIGPIFB : ENMFKMDDDPE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ANGIPAKHGPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> FGEJAMBEGKI;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
		public ANGIPAKHGPH(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> IEBFCJOEBKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum HMGNNPNIFHL
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
	public sealed class HGNEFIHHPCF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class ENMFKMDDDPE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct OPHGBGPIBOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly HMGNNPNIFHL JKCPOGOLCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly KPFGDODNFBO<ENMFKMDDDPE> GPOJPCNDIHG;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
		public OPHGBGPIBOM(HMGNNPNIFHL GINCABKOJCC, KPFGDODNFBO<ENMFKMDDDPE> GFHNJHKNBCE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal DPKMCLCFMEL<HGNEFIHHPCF, OPHGBGPIBOM> ANFPIIPHNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal DPKMCLCFMEL<KDHBIIGPIFB, ANGIPAKHGPH> MNCJECIBJKP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F4CE80", Offset = "0x1F4B680", VA = "0x181F4CE80")]
	private LPIPPNKCDEB([In] DPKMCLCFMEL<HGNEFIHHPCF, OPHGBGPIBOM> NKPIONBJHPK, [In] DPKMCLCFMEL<KDHBIIGPIFB, ANGIPAKHGPH> HLNFAFPEOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F4CEC0", Offset = "0x1F4B6C0", VA = "0x181F4CEC0")]
	public static LPIPPNKCDEB OJFFIHPLODM()
	{
		return default(LPIPPNKCDEB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PMFOFLNNJNO
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1F4D460", Offset = "0x1F4BC60", VA = "0x181F4D460")]
	public static void PGFGBHFCFEG(this LPIPPNKCDEB EGJINJKGIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct GPFFHHMHFKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public JADAHCHJIGA<int> LKHGFCHKBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public JADAHCHJIGA<int> BDECLHFMGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int BLOOALCNJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int OGEEBODIBAG;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1F46F50", Offset = "0x1F45750", VA = "0x181F46F50")]
	private GPFFHHMHFKK([In] JADAHCHJIGA<int> GODIAGMKKEO, [In] JADAHCHJIGA<int> FODDEGFJHML, int OGAOPNNJFGE, int HDFOMOKNPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1F46EB0", Offset = "0x1F456B0", VA = "0x181F46EB0")]
	public static GPFFHHMHFKK OJFFIHPLODM()
	{
		return default(GPFFHHMHFKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class AHPMOCCLGNB
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1F425C0", Offset = "0x1F40DC0", VA = "0x181F425C0")]
	public static void PGFGBHFCFEG(this GPFFHHMHFKK EGJINJKGIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct FGDKHDFOAKE
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum FNHHDHPNMAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class CHCKKGABBJH : OOLCGFEJOLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct GEMIDLDGMCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly KPFGDODNFBO<KBFEHKDCFHI> JGJLLFHCKBP;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
		public GEMIDLDGMCI(KPFGDODNFBO<KBFEHKDCFHI> PNBDNIDJBJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class IHBMCBKLKGN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class OOLCGFEJOLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct DJDBAMKKFKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly FNHHDHPNMAB JKCPOGOLCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly KPFGDODNFBO<OOLCGFEJOLD> GPOJPCNDIHG;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
		private DJDBAMKKFKO(FNHHDHPNMAB GINCABKOJCC, KPFGDODNFBO<OOLCGFEJOLD> GFHNJHKNBCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1F43AE0", Offset = "0x1F422E0", VA = "0x181F43AE0")]
		public static DJDBAMKKFKO OJFFIHPLODM(FNHHDHPNMAB GINCABKOJCC, KPFGDODNFBO<OOLCGFEJOLD> GFHNJHKNBCE)
		{
			return default(DJDBAMKKFKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class JJPPGKDBIBE : OOLCGFEJOLD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct LHAEFBPMPKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly KPFGDODNFBO<KBFEHKDCFHI> JGJLLFHCKBP;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
		public LHAEFBPMPKG(KPFGDODNFBO<KBFEHKDCFHI> PNBDNIDJBJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class KBFEHKDCFHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct LMKNAPEDMLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public JADAHCHJIGA<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> DBFAGJCMLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public JADAHCHJIGA<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> DCLJBCDJHAI;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CE80", Offset = "0x1F4B680", VA = "0x181F4CE80")]
		private LMKNAPEDMLF([In] JADAHCHJIGA<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> AOKLANFDLBI, [In] JADAHCHJIGA<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> HLHIFHMNDBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CE00", Offset = "0x1F4B600", VA = "0x181F4CE00")]
		public static LMKNAPEDMLF OJFFIHPLODM()
		{
			return default(LMKNAPEDMLF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal DPKMCLCFMEL<IHBMCBKLKGN, DJDBAMKKFKO> ANFPIIPHNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal DPKMCLCFMEL<JJPPGKDBIBE, LHAEFBPMPKG> IJPKKJAHLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal DPKMCLCFMEL<CHCKKGABBJH, GEMIDLDGMCI> FMMBPJKMBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal JADAHCHJIGA<(KPFGDODNFBO<IHBMCBKLKGN> CallId, KPFGDODNFBO<KBFEHKDCFHI> IOId)> IPFGJGBBPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal DPKMCLCFMEL<KBFEHKDCFHI, LMKNAPEDMLF> PGDEEBEOBPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal PEOPJNDHKBL<KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>> PBJIGLCAELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal PEOPJNDHKBL<KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>> PLBDIOGKPFK;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1F46C00", Offset = "0x1F45400", VA = "0x181F46C00")]
	private FGDKHDFOAKE([In] DPKMCLCFMEL<IHBMCBKLKGN, DJDBAMKKFKO> NKPIONBJHPK, [In] DPKMCLCFMEL<JJPPGKDBIBE, LHAEFBPMPKG> MMEJGKGOKPD, [In] DPKMCLCFMEL<CHCKKGABBJH, GEMIDLDGMCI> HGHHBHOHBBG, [In] JADAHCHJIGA<(KPFGDODNFBO<IHBMCBKLKGN> CallId, KPFGDODNFBO<KBFEHKDCFHI> IOId)> GGCKLNOJMPP, [In] DPKMCLCFMEL<KBFEHKDCFHI, LMKNAPEDMLF> BHNAHCHLCKA, [In] PEOPJNDHKBL<KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>> LABBFDLBIKG, [In] PEOPJNDHKBL<KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>> EHIGEANHMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1F46A60", Offset = "0x1F45260", VA = "0x181F46A60")]
	public static FGDKHDFOAKE OJFFIHPLODM()
	{
		return default(FGDKHDFOAKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class EPBPJPDNLHC
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F441D0", Offset = "0x1F429D0", VA = "0x181F441D0")]
	private static void PGFGBHFCFEG(this FGDKHDFOAKE.LMKNAPEDMLF EGJINJKGIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F44220", Offset = "0x1F42A20", VA = "0x181F44220")]
	public static void PGFGBHFCFEG(this FGDKHDFOAKE EGJINJKGIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct BBEKMJCHKNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public JADAHCHJIGA<byte> PMFBIGJEDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal FGDKHDFOAKE AKMIFAAAOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal HEOFOPBBFFM KGBELDPODNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> GHOJFPEMOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal FLBBNACDOMO DNOLEKNNGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal LPIPPNKCDEB ICEOAHHMMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal PEOPJNDHKBL<FICFLFAPGGD, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>?> NMEPCPBIPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal JADAHCHJIGA<KPFGDODNFBO<FICFLFAPGGD>> DJDGOEHCHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?> OBBGJNMNFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> VariableId, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>> ByteCodeWriteLocation)> GAPOCNJOOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> GCIMCFDDGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal ENJEGLBJILF OLPKJEJCDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal DOAMJKGGHNH FGAGJCJNHEP;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1F430D0", Offset = "0x1F418D0", VA = "0x181F430D0")]
	private BBEKMJCHKNG([In] JADAHCHJIGA<byte> GIJOKGLHKNL, [In] FGDKHDFOAKE APKJLJDMOCP, [In] HEOFOPBBFFM HEHLEOPNLNL, [In] FLBBNACDOMO PFOLDCKJPHN, [In] LPIPPNKCDEB APKFBJBLOLM, [In] PEOPJNDHKBL<FICFLFAPGGD, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>?> AKKKKLHLNNF, [In] JADAHCHJIGA<KPFGDODNFBO<FICFLFAPGGD>> NNMKEPDNBPC, [In] PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?> OBKMDLGIMCC, [In] JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> VariableId, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>> ByteCodeWriteLocation)> CFJLICBDNDJ, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> NMJCBCOEPIB, [In] ENJEGLBJILF JJHICCFHLDI, [In] DOAMJKGGHNH IFIMMEFLKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1F42610", Offset = "0x1F40E10", VA = "0x181F42610")]
	public static BBEKMJCHKNG OJFFIHPLODM()
	{
		return default(BBEKMJCHKNG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class FAIMEDOHMEI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct MOFODJEEPJA : EMLAOOMOGJK<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>, PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CF50", Offset = "0x1F4B750", VA = "0x181F4CF50")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D010", Offset = "0x1F4B810", VA = "0x181F4D010", Slot = "4")]
		public KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> KJHCJNGKNAO(int JBDLDJOINOF)
		{
			return default(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960")]
		public bool GEAAJHCGCGA(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "5")]
		private bool JKMKJLLNKIM(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D000", Offset = "0x1F4B800", VA = "0x181F4D000", Slot = "6")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> FHHJNFIBHNC(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct KOFNPGOEODN : MHGOIBEKBFG<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>, PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CCE0", Offset = "0x1F4B4E0", VA = "0x181F4CCE0")]
		public JADAHCHJIGA<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>> DFIHJHMMBGA(int FOHKFNMNLAP, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CB70", Offset = "0x1F4B370", VA = "0x181F4CB70")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CC20", Offset = "0x1F4B420", VA = "0x181F4CC20", Slot = "6")]
		public void DFDNPGGNKDP(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>> AHHBLMGMEGC, KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CCE0", Offset = "0x1F4B4E0", VA = "0x181F4CCE0", Slot = "4")]
		private JADAHCHJIGA<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>> HBDBLBLLLBK(int FOHKFNMNLAP, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CB60", Offset = "0x1F4B360", VA = "0x181F4CB60", Slot = "5")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> AHJFGAGEOEP(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct CJPDLJNFIBF : EMLAOOMOGJK<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>, PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1F43750", Offset = "0x1F41F50", VA = "0x181F43750")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1F43800", Offset = "0x1F42000", VA = "0x181F43800", Slot = "4")]
		public KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> KJHCJNGKNAO(int JBDLDJOINOF)
		{
			return default(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960")]
		public bool GEAAJHCGCGA(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "5")]
		private bool MDIIDJAFOJE(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1F43830", Offset = "0x1F42030", VA = "0x181F43830", Slot = "6")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> NEIKLEJIIFL(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct DDAOPMCPNIN : MHGOIBEKBFG<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>, PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1F439B0", Offset = "0x1F421B0", VA = "0x181F439B0")]
		public JADAHCHJIGA<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>> DFIHJHMMBGA(int FOHKFNMNLAP, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1F43840", Offset = "0x1F42040", VA = "0x181F43840")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1F438F0", Offset = "0x1F420F0", VA = "0x181F438F0", Slot = "6")]
		public void DFDNPGGNKDP(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>> AHHBLMGMEGC, KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1F439B0", Offset = "0x1F421B0", VA = "0x181F439B0", Slot = "4")]
		private JADAHCHJIGA<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>> GKPJPGJGMIC(int FOHKFNMNLAP, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1F43A20", Offset = "0x1F42220", VA = "0x181F43A20", Slot = "5")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> EPDKBMEEOKA(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> JBDLDJOINOF, [In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct KHLPGNAJBCD : EMLAOOMOGJK<KPFGDODNFBO<CNIDNALDCPF>, PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C9D0", Offset = "0x1F4B1D0", VA = "0x181F4C9D0")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(KPFGDODNFBO<CNIDNALDCPF> JBDLDJOINOF, [In] PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CB20", Offset = "0x1F4B320", VA = "0x181F4CB20", Slot = "4")]
		public KPFGDODNFBO<CNIDNALDCPF> KJHCJNGKNAO(int JBDLDJOINOF)
		{
			return default(KPFGDODNFBO<CNIDNALDCPF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CAA0", Offset = "0x1F4B2A0", VA = "0x181F4CAA0")]
		public bool GEAAJHCGCGA(KPFGDODNFBO<CNIDNALDCPF> JBDLDJOINOF, [In] PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CAA0", Offset = "0x1F4B2A0", VA = "0x181F4CAA0", Slot = "5")]
		private bool PMECCEEDACM(KPFGDODNFBO<CNIDNALDCPF> JBDLDJOINOF, [In] PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CB50", Offset = "0x1F4B350", VA = "0x181F4CB50", Slot = "6")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> MPOGOPAJIAB(KPFGDODNFBO<CNIDNALDCPF> JBDLDJOINOF, [In] PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct AEGGOPCEAIA : MHGOIBEKBFG<KPFGDODNFBO<CNIDNALDCPF>, PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1F42540", Offset = "0x1F40D40", VA = "0x181F42540")]
		public JADAHCHJIGA<KPFGDODNFBO<CNIDNALDCPF>> DFIHJHMMBGA(int FOHKFNMNLAP, [In] PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<KPFGDODNFBO<CNIDNALDCPF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1F42390", Offset = "0x1F40B90", VA = "0x181F42390")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(KPFGDODNFBO<CNIDNALDCPF> JBDLDJOINOF, [In] PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1F42460", Offset = "0x1F40C60", VA = "0x181F42460", Slot = "6")]
		public void DFDNPGGNKDP(KPFGDODNFBO<CNIDNALDCPF> JBDLDJOINOF, PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?> AHHBLMGMEGC, KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1F42540", Offset = "0x1F40D40", VA = "0x181F42540", Slot = "4")]
		private JADAHCHJIGA<KPFGDODNFBO<CNIDNALDCPF>> EELFCGFLOKC(int FOHKFNMNLAP, [In] PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<KPFGDODNFBO<CNIDNALDCPF>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1F425B0", Offset = "0x1F40DB0", VA = "0x181F425B0", Slot = "5")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> JCAPFKELMNL(KPFGDODNFBO<CNIDNALDCPF> JBDLDJOINOF, [In] PEOPJNDHKBL<CNIDNALDCPF, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>?> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct LMAOBCKFBHM : EMLAOOMOGJK<int, JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CD50", Offset = "0x1F4B550", VA = "0x181F4CD50")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> VariableId, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1340540", Offset = "0x133ED40", VA = "0x181340540", Slot = "4")]
		public int KJHCJNGKNAO(int JBDLDJOINOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960")]
		public bool GEAAJHCGCGA(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> VariableId, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "5")]
		private bool IGDJAEKHFIN(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> VariableId, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1F4CDF0", Offset = "0x1F4B5F0", VA = "0x181F4CDF0", Slot = "6")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> NFJFECKPDFP(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> VariableId, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct NNCBNANLAFP : MHGOIBEKBFG<int, JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D190", Offset = "0x1F4B990", VA = "0x181F4D190")]
		public JADAHCHJIGA<int> DFIHJHMMBGA(int FOHKFNMNLAP, [In] JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> VariableId, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D0F0", Offset = "0x1F4B8F0", VA = "0x181F4D0F0")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> VariableId, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D210", Offset = "0x1F4BA10", VA = "0x181F4D210", Slot = "6")]
		public void DFDNPGGNKDP(int JBDLDJOINOF, JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> VariableId, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>> ByteCodeWriteLocation)> AHHBLMGMEGC, KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D190", Offset = "0x1F4B990", VA = "0x181F4D190", Slot = "4")]
		private JADAHCHJIGA<int> CNEBDLAFBNI(int FOHKFNMNLAP, [In] JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> VariableId, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D200", Offset = "0x1F4BA00", VA = "0x181F4D200", Slot = "5")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> DFAJLOKBOOL(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> VariableId, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<IPLNPIMDNNN>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct DDBKKDPCEML : EMLAOOMOGJK<int, JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1F43A30", Offset = "0x1F42230", VA = "0x181F43A30")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1340540", Offset = "0x133ED40", VA = "0x181340540", Slot = "4")]
		public int KJHCJNGKNAO(int JBDLDJOINOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960")]
		public bool GEAAJHCGCGA(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "5")]
		private bool PHNIPHONPDF(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1F43AD0", Offset = "0x1F422D0", VA = "0x181F43AD0", Slot = "6")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> GMNLFPFBALF(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct JKPJNJOKKMP : MHGOIBEKBFG<int, JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C910", Offset = "0x1F4B110", VA = "0x181F4C910")]
		public JADAHCHJIGA<int> DFIHJHMMBGA(int FOHKFNMNLAP, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C780", Offset = "0x1F4AF80", VA = "0x181F4C780")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C820", Offset = "0x1F4B020", VA = "0x181F4C820", Slot = "6")]
		public void DFDNPGGNKDP(int JBDLDJOINOF, JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC, KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C910", Offset = "0x1F4B110", VA = "0x181F4C910", Slot = "4")]
		private JADAHCHJIGA<int> DPABDBMIDOM(int FOHKFNMNLAP, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C980", Offset = "0x1F4B180", VA = "0x181F4C980", Slot = "5")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> EEBMKADMPOI(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct JJKEBOABDIH : EMLAOOMOGJK<int, JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C6D0", Offset = "0x1F4AED0", VA = "0x181F4C6D0")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1340540", Offset = "0x133ED40", VA = "0x181340540", Slot = "4")]
		public int KJHCJNGKNAO(int JBDLDJOINOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960")]
		public bool GEAAJHCGCGA(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85C160", VA = "0x18085D960", Slot = "5")]
		private bool PHNIPHONPDF(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C770", Offset = "0x1F4AF70", VA = "0x181F4C770", Slot = "6")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> GMNLFPFBALF(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct CGEPAFFJJIK : MHGOIBEKBFG<int, JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1F436D0", Offset = "0x1F41ED0", VA = "0x181F436D0")]
		public JADAHCHJIGA<int> DFIHJHMMBGA(int FOHKFNMNLAP, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1F43530", Offset = "0x1F41D30", VA = "0x181F43530")]
		public KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1F435D0", Offset = "0x1F41DD0", VA = "0x181F435D0", Slot = "6")]
		public void DFDNPGGNKDP(int JBDLDJOINOF, JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC, KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> IPHHABIKCHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1F436D0", Offset = "0x1F41ED0", VA = "0x181F436D0", Slot = "4")]
		private JADAHCHJIGA<int> DPABDBMIDOM(int FOHKFNMNLAP, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(JADAHCHJIGA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1F43740", Offset = "0x1F41F40", VA = "0x181F43740", Slot = "5")]
		private KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> EEBMKADMPOI(int JBDLDJOINOF, [In] JADAHCHJIGA<(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> Target, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> ByteCodeWriteLocation)> AHHBLMGMEGC)
		{
			return default(KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct IEMIHPJNONH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GANJJEMEADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool INAOEGOEGHG;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x10C8460", Offset = "0x10C6C60", VA = "0x1810C8460")]
		public IEMIHPJNONH(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM, bool DIDBJKIIFGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C6C0", Offset = "0x1F4AEC0", VA = "0x181F4C6C0")]
		public void LNLDOCGFLCM([Out] KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM, [Out] bool DIDBJKIIFGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct KDMALHNLMIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly KPFGDODNFBO<CNIDNALDCPF> MLHDEEICKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GANJJEMEADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool INAOEGOEGHG;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C9C0", Offset = "0x1F4B1C0", VA = "0x181F4C9C0")]
		public KDMALHNLMIK(KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM, bool DIDBJKIIFGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C9B0", Offset = "0x1F4B1B0", VA = "0x181F4C9B0")]
		public void LNLDOCGFLCM([Out] KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM, [Out] bool DIDBJKIIFGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C990", Offset = "0x1F4B190", VA = "0x181F4C990")]
		public void LNLDOCGFLCM([Out] KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM, [Out] KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ, [Out] bool DIDBJKIIFGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct BCNELLACHFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly KPFGDODNFBO<CNIDNALDCPF> MLHDEEICKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GANJJEMEADL;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
		public BCNELLACHFD(KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1F43430", Offset = "0x1F41C30", VA = "0x181F43430")]
		public void LNLDOCGFLCM([Out] KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM, [Out] KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1F465C0", Offset = "0x1F44DC0", VA = "0x181F465C0")]
	public static void PGFGBHFCFEG(this BBEKMJCHKNG EGJINJKGIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1F45390", Offset = "0x1F43B90", VA = "0x181F45390")]
	public static void GHCIMIDEHBN(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> ELBHHBGEHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1F46080", Offset = "0x1F44880", VA = "0x181F46080")]
	public static void OJODBLMFDLC(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> ELBHHBGEHEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1F455C0", Offset = "0x1F43DC0", VA = "0x181F455C0")]
	public static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>? ICPCKKGCDOP([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1F44B80", Offset = "0x1F43380", VA = "0x181F44B80")]
	public static KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> EAGGJPBKGOK([In] this BBEKMJCHKNG EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1F45220", Offset = "0x1F43A20", VA = "0x181F45220")]
	private static void GFOEEFKPMKE(this BBEKMJCHKNG EGJINJKGIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1F44890", Offset = "0x1F43090", VA = "0x181F44890")]
	private static KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>? CDBJECCKIBG([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1F461D0", Offset = "0x1F449D0", VA = "0x181F461D0")]
	public static void ONFOIGIHJPF(this BBEKMJCHKNG EGJINJKGIAK, [In] JADAHCHJIGA<CMIDFIOMJIH> OCOPIPAOPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1F45780", Offset = "0x1F43F80", VA = "0x181F45780")]
	public static FLBBNACDOMO.BEPHOMPJEAN JCMCPMEAKEH([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM)
	{
		return default(FLBBNACDOMO.BEPHOMPJEAN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1F44C60", Offset = "0x1F43460", VA = "0x181F44C60")]
	public static IBHGNNAFJNL<byte> ELPDGLGAJFO([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM)
	{
		return default(IBHGNNAFJNL<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1F45460", Offset = "0x1F43C60", VA = "0x181F45460")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> GPMEHLOIKMD([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1F45B80", Offset = "0x1F44380", VA = "0x181F45B80")]
	public static AFFMEBCPHON MKADGOFIAHD([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM)
	{
		return default(AFFMEBCPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AB40", Offset = "0x2A69340", VA = "0x182A6AB40")]
	private static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GNHJIFHBLDL<TMJoin>(this BBEKMJCHKNG EGJINJKGIAK, FLBBNACDOMO.BEPHOMPJEAN GINCABKOJCC, KPFGDODNFBO<TMJoin> GFHNJHKNBCE) where TMJoin : FLBBNACDOMO.IODLMCAOIAB
	{
		return default(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1F45540", Offset = "0x1F43D40", VA = "0x181F45540")]
	public static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> HGBDLCIEEJB(this BBEKMJCHKNG EGJINJKGIAK, bool EGMEKBCDLGL)
	{
		return default(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1F46460", Offset = "0x1F44C60", VA = "0x181F46460")]
	public static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> PEGINPABEOK(this BBEKMJCHKNG EGJINJKGIAK, IBHGNNAFJNL<byte> GHFEJDPMJDG)
	{
		return default(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1F45700", Offset = "0x1F43F00", VA = "0x181F45700")]
	public static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> ILIHDDKMCHC(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> MCFPLNNMJPO)
	{
		return default(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1F45B00", Offset = "0x1F44300", VA = "0x181F45B00")]
	public static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> MGHHNDKGNKF(this BBEKMJCHKNG EGJINJKGIAK, int ECEKDKBHMHI)
	{
		return default(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1F44BE0", Offset = "0x1F433E0", VA = "0x181F44BE0")]
	public static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> EBMLMOOGMHD(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AJPMCKHNNHP)
	{
		return default(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A4E0", Offset = "0x2A68CE0", VA = "0x182A6A4E0")]
	private static KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF> APKBPKNNNAH<TMJoin>(this BBEKMJCHKNG EGJINJKGIAK, LPIPPNKCDEB.HMGNNPNIFHL GINCABKOJCC, KPFGDODNFBO<TMJoin> GFHNJHKNBCE) where TMJoin : LPIPPNKCDEB.ENMFKMDDDPE
	{
		return default(KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1F45A50", Offset = "0x1F44250", VA = "0x181F45A50")]
	public static KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF> LLIKHGMHDPB(this BBEKMJCHKNG EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1F45680", Offset = "0x1F43E80", VA = "0x181F45680")]
	public static KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF> IDEBFMDKPDM(this BBEKMJCHKNG EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1F46150", Offset = "0x1F44950", VA = "0x181F46150")]
	public static KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF> OLNAFCJAOND(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> IEBFCJOEBKA)
	{
		return default(KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F45A10", Offset = "0x1F44210", VA = "0x181F45A10")]
	public static KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF> LIAHBPHCDGI(this BBEKMJCHKNG EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1F44F10", Offset = "0x1F43710", VA = "0x181F44F10")]
	public static KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF> FCCAHEOMOPD(this BBEKMJCHKNG EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1F44B00", Offset = "0x1F43300", VA = "0x181F44B00")]
	public static FGDKHDFOAKE.FNHHDHPNMAB DPGAGKIFONF([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN> PHHCJPKEKHF)
	{
		return default(FGDKHDFOAKE.FNHHDHPNMAB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1F45420", Offset = "0x1F43C20", VA = "0x181F45420")]
	public static LHLAHEHKEGG<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>, DGDMDOEDJEA<FGDKHDFOAKE.KBFEHKDCFHI>> GLIIDAGABJD([In] this BBEKMJCHKNG EGJINJKGIAK)
	{
		return default(LHLAHEHKEGG<KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>, DGDMDOEDJEA<FGDKHDFOAKE.KBFEHKDCFHI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1F44950", Offset = "0x1F43150", VA = "0x181F44950")]
	public static KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> DKIICADEFNB([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN> PHHCJPKEKHF)
	{
		return default(KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1F44E90", Offset = "0x1F43690", VA = "0x181F44E90")]
	public static FGDKHDFOAKE.LMKNAPEDMLF FAJIFJDELHH([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> PNBDNIDJBJH)
	{
		return default(FGDKHDFOAKE.LMKNAPEDMLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1F446B0", Offset = "0x1F42EB0", VA = "0x181F446B0")]
	public static FGDKHDFOAKE.LMKNAPEDMLF AMDJNJHFMGJ(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> PNBDNIDJBJH)
	{
		return default(FGDKHDFOAKE.LMKNAPEDMLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2A6AAA0", Offset = "0x2A692A0", VA = "0x182A6AAA0")]
	private static KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN> DDNADDNJDPL<TMJoin>(this BBEKMJCHKNG EGJINJKGIAK, FGDKHDFOAKE.FNHHDHPNMAB GINCABKOJCC, KPFGDODNFBO<TMJoin> GFHNJHKNBCE) where TMJoin : FGDKHDFOAKE.OOLCGFEJOLD
	{
		return default(KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1F444E0", Offset = "0x1F42CE0", VA = "0x181F444E0")]
	public static (KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>) AGCECADCAJO(this BBEKMJCHKNG EGJINJKGIAK)
	{
		return default((KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1F46890", Offset = "0x1F45090", VA = "0x181F46890")]
	public static (KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>) PPEJPBKAKCK(this BBEKMJCHKNG EGJINJKGIAK)
	{
		return default((KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1F456C0", Offset = "0x1F43EC0", VA = "0x181F456C0")]
	public static KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN> IGGPJPDBOGG(this BBEKMJCHKNG EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1F44F50", Offset = "0x1F43750", VA = "0x181F44F50")]
	public static void FEGLLFMKDAA(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI> PNBDNIDJBJH, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> NLJPKEEIEDH, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>> AACBNDCAKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2A6B2C0", Offset = "0x2A69AC0", VA = "0x182A6B2C0")]
	public static IEMIHPJNONH MJJPFFHAIBO<TDeps, TStateSys>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ) where TDeps : OILHNDNJLHG<TStateSys>
	{
		return default(IEMIHPJNONH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A240", Offset = "0x2A68A40", VA = "0x182A6A240")]
	public static KDMALHNLMIK ADPEDIAFHEB<TDeps, TStateSys>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int OHHOEGDMHEB) where TDeps : OILHNDNJLHG<TStateSys>
	{
		return default(KDMALHNLMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A590", Offset = "0x2A68D90", VA = "0x182A6A590")]
	public static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>? BFFBDCMFNMB<TDeps, TStateSys>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, [In] ReadOnlySpan<int> ECLEGCCOEJO, [In] Span<BCNELLACHFD> IDHOFAAHFIH) where TDeps : OILHNDNJLHG<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2A6ACF0", Offset = "0x2A694F0", VA = "0x182A6ACF0")]
	public static KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF> LODONPABDDH<TDeps, TStateSys>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI) where TDeps : OILHNDNJLHG<TStateSys>
	{
		return default(KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1F45800", Offset = "0x1F44000", VA = "0x181F45800")]
	public static HEOFOPBBFFM.GAOONLHHMAM JDFKLFFKEIB([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EGNLNANJFMI)
	{
		return default(HEOFOPBBFFM.GAOONLHHMAM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1F464F0", Offset = "0x1F44CF0", VA = "0x181F464F0")]
	public static HEOFOPBBFFM.KHFIOGBOKND PGBMCKEFBLP([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EGNLNANJFMI)
	{
		return default(HEOFOPBBFFM.KHFIOGBOKND);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1F45940", Offset = "0x1F44140", VA = "0x181F45940")]
	public static HEOFOPBBFFM.BGAFBLKGNOK LGOPPKFKABI([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EGNLNANJFMI)
	{
		return default(HEOFOPBBFFM.BGAFBLKGNOK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1F45090", Offset = "0x1F43890", VA = "0x181F45090")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> GEMBNLHEJDJ(this BBEKMJCHKNG EGJINJKGIAK, int? GLJCCKDGPCN, string GCDLMFGKKMH)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1F447C0", Offset = "0x1F42FC0", VA = "0x181F447C0")]
	public static HEOFOPBBFFM.EMJMGKHNJGH CBPOLMAJLFL([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EGNLNANJFMI)
	{
		return default(HEOFOPBBFFM.EMJMGKHNJGH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1F458D0", Offset = "0x1F440D0", VA = "0x181F458D0")]
	public static HEOFOPBBFFM.OFNABCBHMML JNEDGPBICOP([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EGNLNANJFMI)
	{
		return default(HEOFOPBBFFM.OFNABCBHMML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1F45A90", Offset = "0x1F44290", VA = "0x181F45A90")]
	public static int? MEDHOBDBKIJ([In] this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EGNLNANJFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2A6ABF0", Offset = "0x2A693F0", VA = "0x182A6ABF0")]
	private static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> HMGAHGNGBEF<TMJoin>(this BBEKMJCHKNG EGJINJKGIAK, int? GLJCCKDGPCN, HEOFOPBBFFM.OFNABCBHMML GINCABKOJCC, KPFGDODNFBO<TMJoin> GFHNJHKNBCE) where TMJoin : HEOFOPBBFFM.LDONLLJBGJE
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1F44FE0", Offset = "0x1F437E0", VA = "0x181F44FE0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> FLDHBFIGOJK(this BBEKMJCHKNG EGJINJKGIAK, int? GLJCCKDGPCN, KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN> PHHCJPKEKHF, int JBDLDJOINOF)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1F45C60", Offset = "0x1F44460", VA = "0x181F45C60")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> NAONNBKABMC(this BBEKMJCHKNG EGJINJKGIAK, int? GLJCCKDGPCN)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1F44D40", Offset = "0x1F43540", VA = "0x181F44D40")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> ENAJOCOOJOC(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>? JHGHDNMFIPK, int? GLJCCKDGPCN)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F45CC0", Offset = "0x1F444C0", VA = "0x181F45CC0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> NGOALCHDCEM(this BBEKMJCHKNG EGJINJKGIAK, int? GLJCCKDGPCN, int JBDLDJOINOF)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1F46020", Offset = "0x1F44820", VA = "0x181F46020")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> OGAILMBKNMG(this BBEKMJCHKNG EGJINJKGIAK, int? GLJCCKDGPCN)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1F45EF0", Offset = "0x1F446F0", VA = "0x181F45EF0")]
	public static void OFIJNOMKKKC(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AJPMCKHNNHP, KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN> PHHCJPKEKHF, int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F46340", Offset = "0x1F44B40", VA = "0x181F46340")]
	public static void PBDKKKFCHGB(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AJPMCKHNNHP, int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F45E20", Offset = "0x1F44620", VA = "0x181F45E20")]
	public static void NPDIKMLDKBB(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AJPMCKHNNHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1F44730", Offset = "0x1F42F30", VA = "0x181F44730")]
	public static void APJMIAOHMLM(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> LFFBLPMMGND, KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> PPBGHDBOHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1F45D50", Offset = "0x1F44550", VA = "0x181F45D50")]
	public static void NHBDAMFAOGI(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AJPMCKHNNHP, KPFGDODNFBO<CMNBACPDIDC<JOENAJIEMAA>> BAJMNBENJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2A6A9D0", Offset = "0x2A691D0", VA = "0x182A6A9D0")]
	public static void BJOPCFPMFLA<M>(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AJPMCKHNNHP, KPFGDODNFBO<CMNBACPDIDC<CPDDEKGJHME<M>>> BAJMNBENJLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface OILHNDNJLHG<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KPFGDODNFBO<IFKEIGMBLOF> MBOJLJDHPGL(TStateSys BGDDDMIGBBF);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPFGDODNFBO<IFKEIGMBLOF> CGLLGMIJFAG(TStateSys BGDDDMIGBBF);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KPFGDODNFBO<IFKEIGMBLOF> ICLCBNGGCGD(TStateSys BGDDDMIGBBF);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KPFGDODNFBO<IFKEIGMBLOF> EAAHJPKFICO(TStateSys BGDDDMIGBBF);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF> GMILFOEJFEH(TStateSys BGDDDMIGBBF, BBEKMJCHKNG DAOECAKDOHM, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> CJACPCCAJKN(TStateSys BGDDDMIGBBF, BBEKMJCHKNG DAOECAKDOHM, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int KKIJEPGEFKD(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KPFGDODNFBO<FICFLFAPGGD> MNAHNJHPIFC(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ, int JFOGABNIOHM);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BOCGCDMFLPC MKLEILJFNPJ(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool OJAFGBKFDND(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int PAAIDJDGPLC(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IBHGNNAFJNL<byte> EAHALAMENAH(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(IBHGNNAFJNL<byte>, KPFGDODNFBO<IFKEIGMBLOF>) CLHHOLDJGOJ(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<CNIDNALDCPF> CACIDFDKPBJ);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int LDJBOHBKLDM(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KPFGDODNFBO<CNIDNALDCPF> GDLILKMAHNC(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<FICFLFAPGGD> CJCIDDLJNDI, int OHHOEGDMHEB);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KPFGDODNFBO<CNIDNALDCPF> FOIJANBOENA(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, KPFGDODNFBO<GHBFIOLFDBB> FMPAALMFOIG, int OHHOEGDMHEB);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int NJMJFJAALNI(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? KCCCJDHNNOI(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, int JBDLDJOINOF);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int BGIBOPLHNMO(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? CFFIGIOOOHH(TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM, int JBDLDJOINOF);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IAGNGPNDAAG
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3000", Offset = "0x2AC1800", VA = "0x182AC3000")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL?> MGNDADKIPNJ<T, TOpInput, TOpOutput>(this BBEKMJCHKNG EGJINJKGIAK, T JOMKMIJJPCA, T DFLDBCDDIFI, int PFMEIFIDLOP, IntPtr DPMBLPDIHKF)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2AC11D0", Offset = "0x2ABF9D0", VA = "0x182AC11D0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL?> HFAHMHIOOMF<T, TOpInput, TOpOutput>(this BBEKMJCHKNG EGJINJKGIAK, T JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI, int PFMEIFIDLOP, IntPtr DPMBLPDIHKF)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2AC0680", Offset = "0x2ABEE80", VA = "0x182AC0680")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL?> DGCHIOPCHFK<TOpInput, TOpOutput>(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI, int PFMEIFIDLOP, IntPtr DPMBLPDIHKF)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1F480C0", Offset = "0x1F468C0", VA = "0x181F480C0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EKPCEDIEENA(this BBEKMJCHKNG EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1F496D0", Offset = "0x1F47ED0", VA = "0x181F496D0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> IFJEOCIIBGE(this BBEKMJCHKNG EGJINJKGIAK, float KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1F483F0", Offset = "0x1F46BF0", VA = "0x181F483F0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> FBEJOMPEEHO(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1F4C110", Offset = "0x1F4A910", VA = "0x181F4C110")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> PBAJNPAMMJN(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A9A0", Offset = "0x1F491A0", VA = "0x181F4A9A0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KOHOMDODBNP(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1F49310", Offset = "0x1F47B10", VA = "0x181F49310")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> HOJPAMKJLMP(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1F481C0", Offset = "0x1F469C0", VA = "0x181F481C0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> ENAJOHJOIMI(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1F47680", Offset = "0x1F45E80", VA = "0x181F47680")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> BCKAIKLMDNL(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1F47A00", Offset = "0x1F46200", VA = "0x181F47A00")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> BNHPDOOKDFO(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1F4BD00", Offset = "0x1F4A500", VA = "0x181F4BD00")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> OEPMPKAAKCA(this BBEKMJCHKNG EGJINJKGIAK, int JOMKMIJJPCA, int DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1F4C200", Offset = "0x1F4AA00", VA = "0x181F4C200")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> PFBAJCJAFJO(this BBEKMJCHKNG EGJINJKGIAK, int JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1F48F60", Offset = "0x1F47760", VA = "0x181F48F60")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> HBAPABDGIAH(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1F47580", Offset = "0x1F45D80", VA = "0x181F47580")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> BCEIMGFDAOM(this BBEKMJCHKNG EGJINJKGIAK, float JOMKMIJJPCA, float DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1F489D0", Offset = "0x1F471D0", VA = "0x181F489D0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> GIIIAJFMAHA(this BBEKMJCHKNG EGJINJKGIAK, float JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1F49C10", Offset = "0x1F48410", VA = "0x181F49C10")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JELHAEIDDHL(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1F47F40", Offset = "0x1F46740", VA = "0x181F47F40")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EFCMBFIICKO(this BBEKMJCHKNG EGJINJKGIAK, int JOMKMIJJPCA, int DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F47FC0", Offset = "0x1F467C0", VA = "0x181F47FC0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EJDAFGPPBGI(this BBEKMJCHKNG EGJINJKGIAK, int JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1F490A0", Offset = "0x1F478A0", VA = "0x181F490A0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> HFAGKFEMGFN(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1F4C090", Offset = "0x1F4A890", VA = "0x181F4C090")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> OLOMGCCCHAC(this BBEKMJCHKNG EGJINJKGIAK, float JOMKMIJJPCA, float DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1F4ADD0", Offset = "0x1F495D0", VA = "0x181F4ADD0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> MALMHOIAHAB(this BBEKMJCHKNG EGJINJKGIAK, float JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1F49FE0", Offset = "0x1F487E0", VA = "0x181F49FE0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JOILLFFEGEP(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1F4BC80", Offset = "0x1F4A480", VA = "0x181F4BC80")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> ODEPGCHPBIP(this BBEKMJCHKNG EGJINJKGIAK, int JOMKMIJJPCA, int DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1F48040", Offset = "0x1F46840", VA = "0x181F48040")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EKKPGCENEJE(this BBEKMJCHKNG EGJINJKGIAK, int JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1F47B40", Offset = "0x1F46340", VA = "0x181F47B40")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> CBHPEFJOGLD(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A800", Offset = "0x1F49000", VA = "0x181F4A800")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KMNFPBNLHKH(this BBEKMJCHKNG EGJINJKGIAK, float JOMKMIJJPCA, float DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1F4AE50", Offset = "0x1F49650", VA = "0x181F4AE50")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> MANNKJKECGJ(this BBEKMJCHKNG EGJINJKGIAK, float JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1F49E40", Offset = "0x1F48640", VA = "0x181F49E40")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JLKOGAHIIKF(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F48C20", Offset = "0x1F47420", VA = "0x181F48C20")]
	public static KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> GMBKHJGMCKN(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1F48EE0", Offset = "0x1F476E0", VA = "0x181F48EE0")]
	public static KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> HABKDAEBIDM(this BBEKMJCHKNG EGJINJKGIAK, int IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1F49930", Offset = "0x1F48130", VA = "0x181F49930")]
	public static KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> IJNIBKMMDBH(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1F4B9E0", Offset = "0x1F4A1E0", VA = "0x181F4B9E0")]
	public static KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> NMLFIDFPDDA(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> GAMGOOKCBJM)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A6E0", Offset = "0x1F48EE0", VA = "0x181F4A6E0")]
	public static KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> KEHGECEKFFI(this BBEKMJCHKNG EGJINJKGIAK, int IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A760", Offset = "0x1F48F60", VA = "0x181F4A760")]
	public static KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> KIHFLLBEMKK(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1F4B380", Offset = "0x1F49B80", VA = "0x181F4B380")]
	public static (KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>) NANOIINGBOC(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<LAMKMBLFJAO> POEMJPLJNKE, [In] ReadOnlySpan<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> AOKLANFDLBI, [In] ReadOnlySpan<int?> NGPDCMEOCOD, [In] Span<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> CLMNNIPBJLJ)
	{
		return default((KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A270", Offset = "0x1F48A70", VA = "0x181F4A270")]
	public static (KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>) KBOBDFAGOPA(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<IKHKKPLDKDK> JEOPOJGEFML, [In] ReadOnlySpan<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> AOKLANFDLBI, [In] ReadOnlySpan<int?> NGPDCMEOCOD, [In] Span<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> CLMNNIPBJLJ)
	{
		return default((KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3300", Offset = "0x2AC1B00", VA = "0x182AC3300")]
	public static (KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IFKEIGMBLOF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<TMarker>>, KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>) NEBMNMGKFNI<TMarker>(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<IFKEIGMBLOF> FDMNGHEMIJI, [In] ReadOnlySpan<byte> MLKNGAFFKGE)
	{
		return default((KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<CMNBACPDIDC<IFKEIGMBLOF>>, KPFGDODNFBO<CMNBACPDIDC<NDLDOELFLPF>>, KPFGDODNFBO<CMNBACPDIDC<TMarker>>, KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1F4B920", Offset = "0x1F4A120", VA = "0x181F4B920")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> NKDCOHMECEJ(this BBEKMJCHKNG EGJINJKGIAK, int KGKGNFIBJEB, [Optional] KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>? MBIIHBIIKOG)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1F49220", Offset = "0x1F47A20", VA = "0x181F49220")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> HKHBGFKJPLF(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGKGNFIBJEB, [Optional] KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>? MBIIHBIIKOG)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1F4BB90", Offset = "0x1F4A390", VA = "0x181F4BB90")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> NNGCOJKHAGO(this BBEKMJCHKNG EGJINJKGIAK, [In] ReadOnlySpan<byte> KGKGNFIBJEB, [Optional] KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>? MBIIHBIIKOG)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A880", Offset = "0x1F49080", VA = "0x181F4A880")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KMPPPKKJHAA(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGKGNFIBJEB, int GGKCGCGFHKJ, [Optional] KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>? MBIIHBIIKOG)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1F49120", Offset = "0x1F47920", VA = "0x181F49120")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> HHGHHPHHIJE(this BBEKMJCHKNG EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1F48530", Offset = "0x1F46D30", VA = "0x181F48530")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> FCPOPLAKNLN(this BBEKMJCHKNG EGJINJKGIAK, float KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1F49450", Offset = "0x1F47C50", VA = "0x181F49450")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> HPFKBDMNNCM(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1F4ACE0", Offset = "0x1F494E0", VA = "0x181F4ACE0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> LJFGMBKGPCE(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1F478E0", Offset = "0x1F460E0", VA = "0x181F478E0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> BMPFKCBANKJ(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1F499D0", Offset = "0x1F481D0", VA = "0x181F499D0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> IMLJMMIEOEN(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1F473C0", Offset = "0x1F45BC0", VA = "0x181F473C0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AMOPFAPFDHE(this BBEKMJCHKNG EGJINJKGIAK, int JOMKMIJJPCA, int DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1F48950", Offset = "0x1F47150", VA = "0x181F48950")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> FPODHDMPLFE(this BBEKMJCHKNG EGJINJKGIAK, int JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1F4BDF0", Offset = "0x1F4A5F0", VA = "0x181F4BDF0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> OHEMJALFGLF(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JOMKMIJJPCA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DFLDBCDDIFI)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1F49B10", Offset = "0x1F48310", VA = "0x181F49B10")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> IONLFBHNEEH(this BBEKMJCHKNG EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1F4BF60", Offset = "0x1F4A760", VA = "0x181F4BF60")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> OKFIOONNODI(this BBEKMJCHKNG EGJINJKGIAK, float KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1F47440", Offset = "0x1F45C40", VA = "0x181F47440")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> BCBAGEIIMOF(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A180", Offset = "0x1F48980", VA = "0x181F4A180")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JPHOJONMJPF(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1F4A060", Offset = "0x1F48860", VA = "0x181F4A060")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JPBIDNDKGIP(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1F49590", Offset = "0x1F47D90", VA = "0x181F49590")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> IBGMELLKPEJ(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1F47E20", Offset = "0x1F46620", VA = "0x181F47E20")]
	public static KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>> DPDOEAPCJLN(this BBEKMJCHKNG EGJINJKGIAK)
	{
		return default(KPFGDODNFBO<CMNBACPDIDC<CMNBACPDIDC<FOLPKKPBDGL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1F4C460", Offset = "0x1F4AC60", VA = "0x181F4C460")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> POELIIBCCBM(this BBEKMJCHKNG EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1F4AAC0", Offset = "0x1F492C0", VA = "0x181F4AAC0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> LAGMOCAHLCN(this BBEKMJCHKNG EGJINJKGIAK, float KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1F4B7E0", Offset = "0x1F49FE0", VA = "0x181F4B7E0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> NAOABOPAIBG(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1F472D0", Offset = "0x1F45AD0", VA = "0x181F472D0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> ADAFLABODLO(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1F47D00", Offset = "0x1F46500", VA = "0x181F47D00")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DDGGBFELDLK(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1F477A0", Offset = "0x1F45FA0", VA = "0x181F477A0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> BMPDDFNBKOA(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1F47E40", Offset = "0x1F46640", VA = "0x181F47E40")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EEAPMACNKDK(this BBEKMJCHKNG EGJINJKGIAK, int IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1F48DD0", Offset = "0x1F475D0", VA = "0x181F48DD0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> GNIKLLHDMIA(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> IPHHABIKCHD)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1F47BC0", Offset = "0x1F463C0", VA = "0x181F47BC0")]
	public static void CKLMKKBMJEJ(this BBEKMJCHKNG EGJINJKGIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1F4ABE0", Offset = "0x1F493E0", VA = "0x181F4ABE0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> LGFBGKCDELO(this BBEKMJCHKNG EGJINJKGIAK, float KGMLOMMNCLH, float AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1F48B00", Offset = "0x1F47300", VA = "0x181F48B00")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> GJHNMLBJMKN(this BBEKMJCHKNG EGJINJKGIAK, float KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1F497F0", Offset = "0x1F47FF0", VA = "0x181F497F0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> IIIBOPPLGKP(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1F49D50", Offset = "0x1F48550", VA = "0x181F49D50")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JJBIJOICKNM(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1F4B260", Offset = "0x1F49A60", VA = "0x181F4B260")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> NADCCKECKEO(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1F482B0", Offset = "0x1F46AB0", VA = "0x181F482B0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> EOIFFNDKOJF(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1F4AED0", Offset = "0x1F496D0", VA = "0x181F4AED0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> MKEDGPGHFOM(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> COPMGBMPLAA, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> HCEJEELFHJD)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1F4BE70", Offset = "0x1F4A670", VA = "0x181F4BE70")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> OHMBDODFIPI(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, int AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1F49EC0", Offset = "0x1F486C0", VA = "0x181F49EC0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JNLCBPKDMKN(this BBEKMJCHKNG EGJINJKGIAK, int KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1F4C320", Offset = "0x1F4AB20", VA = "0x181F4C320")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> PIAOCCMGFAB(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGMLOMMNCLH, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> AFJBDIDNCMM)
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2AC2010", Offset = "0x2AC0810", VA = "0x182AC2010")]
	public static void LFBADFEKAEK<TDeps, TState>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TState DAGLKLOEBMA, KPFGDODNFBO<LAMKMBLFJAO> POEMJPLJNKE, [In] ReadOnlySpan<KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>> EDCINHIHBID, [In] ReadOnlySpan<int?> NGPDCMEOCOD, [In] Span<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> CLMNNIPBJLJ, [In] Span<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> PCMJIANBBKD, [In] ReadOnlySpan<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>?> ABJCIHEOPJL) where TDeps : notnull, OILHNDNJLHG<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2AC0A20", Offset = "0x2ABF220", VA = "0x182AC0A20")]
	public static void EBHILFFLBAI<TDeps, TState>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TState DAGLKLOEBMA, KPFGDODNFBO<IKHKKPLDKDK> CPDLACEKNJL, [In] ReadOnlySpan<KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>> BFDGMEKFALF, [In] ReadOnlySpan<int?> NGPDCMEOCOD, [In] Span<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> CLMNNIPBJLJ, [In] Span<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>> PCMJIANBBKD, [In] ReadOnlySpan<KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>?> ABJCIHEOPJL) where TDeps : notnull, OILHNDNJLHG<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2AC04A0", Offset = "0x2ABECA0", VA = "0x182AC04A0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> DBMBEGANDGL<TDeps, TState>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TState DAGLKLOEBMA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JHGHDNMFIPK, [Optional] KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>? MBIIHBIIKOG) where TDeps : notnull, OILHNDNJLHG<TState> where TState : notnull
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2AC1BB0", Offset = "0x2AC03B0", VA = "0x182AC1BB0")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGDHAPCGGIC<TDeps, TState>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TState DAGLKLOEBMA, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> IEBFCJOEBKA, [Optional] KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>? MBIIHBIIKOG) where TDeps : notnull, OILHNDNJLHG<TState> where TState : notnull
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2AC07F0", Offset = "0x2ABEFF0", VA = "0x182AC07F0")]
	public static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> DHBAGBBBEAI<TDeps, TStateSys>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TStateSys BGDDDMIGBBF) where TDeps : notnull, OILHNDNJLHG<TStateSys> where TStateSys : notnull
	{
		return default(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2AC0FC0", Offset = "0x2ABF7C0", VA = "0x182AC0FC0")]
	public static KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF> FPLAEAGDPMP<TDeps, TStateSys>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TStateSys BGDDDMIGBBF) where TDeps : notnull, OILHNDNJLHG<TStateSys> where TStateSys : notnull
	{
		return default(KPFGDODNFBO<LPIPPNKCDEB.HGNEFIHHPCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1F47BD0", Offset = "0x1F463D0", VA = "0x181F47BD0")]
	public static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> DCACNJBIJDI(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> OICELEFAFIB, IntPtr NABDEOPKIOE, IntPtr LMMDFHAIBEG)
	{
		return default(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1F48650", Offset = "0x1F46E50", VA = "0x181F48650")]
	public static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> FDCECPIHHBH(this BBEKMJCHKNG EGJINJKGIAK, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> CKJPLJGDCHD, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> MFENCPLHIAL, IntPtr JOACEDFCCJH, IntPtr DOBEOGBIMID, IntPtr EFBCBLLKJGK, bool HOHBNCPDCON)
	{
		return default(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2AC28D0", Offset = "0x2AC10D0", VA = "0x182AC28D0")]
	public static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> MBNFKOPHHAM<TDeps, TState>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TState DAGLKLOEBMA, KPFGDODNFBO<LAMKMBLFJAO> EGBHPIAGHBM, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> CKJPLJGDCHD, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> MFENCPLHIAL, int? KDNDKBBLGKL, [Optional] IntPtr JBCOBPJGDGO) where TDeps : notnull, OILHNDNJLHG<TState> where TState : notnull
	{
		return default(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2AC25B0", Offset = "0x2AC0DB0", VA = "0x182AC25B0")]
	private static KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> MBNFKOPHHAM<TDeps, TState>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TState DAGLKLOEBMA, KPFGDODNFBO<LAMKMBLFJAO> EGBHPIAGHBM, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> CKJPLJGDCHD, KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH> MFENCPLHIAL, int? KDNDKBBLGKL) where TDeps : notnull, OILHNDNJLHG<TState> where TState : notnull
	{
		return default(KPFGDODNFBO<FLBBNACDOMO.JHBILDIEIDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC1800", Offset = "0x2AC0000", VA = "0x182AC1800")]
	public static KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> JADDKBGOCON<TDeps, TState>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TState DAGLKLOEBMA, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL> KGKGNFIBJEB, KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>? MBIIHBIIKOG) where TDeps : notnull, OILHNDNJLHG<TState> where TState : notnull
	{
		return default(KPFGDODNFBO<HEOFOPBBFFM.EOEANKCGGLL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2AC1570", Offset = "0x2ABFD70", VA = "0x182AC1570")]
	public static void HOGBOFGMIFC<TDeps, TState>(this BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TState DAGLKLOEBMA, int HNHIMAELEEG) where TDeps : notnull, OILHNDNJLHG<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct FDBIONPHOCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> BEGAKPKEDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> DLMFOGIKMBK;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
	public FDBIONPHOCL(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> IACPCCDPOCP, KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> FIEPGBIFOKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1F46A50", Offset = "0x1F45250", VA = "0x181F46A50")]
	public static FDBIONPHOCL OJFFIHPLODM(KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>> IACPCCDPOCP)
	{
		return default(FDBIONPHOCL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct HEOFOPBBFFM
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class ADENKMBCFJM : LDONLLJBGJE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct GAOONLHHMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN> NHHGCNGBDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int CFDBFCCMKIM;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
		public GAOONLHHMAM(KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN> PHHCJPKEKHF, int JBDLDJOINOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class HEJGIACMAMP : LDONLLJBGJE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct KHFIOGBOKND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int CFDBFCCMKIM;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
		public KHFIOGBOKND(int JBDLDJOINOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class HFAGDPAGKOA : LDONLLJBGJE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct BGAFBLKGNOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN> NHHGCNGBDLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int CFDBFCCMKIM;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xC07F10", Offset = "0xC06710", VA = "0x180C07F10")]
		public BGAFBLKGNOK(KPFGDODNFBO<FGDKHDFOAKE.IHBMCBKLKGN> PHHCJPKEKHF, int JBDLDJOINOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum OFNABCBHMML
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
	public sealed class EOEANKCGGLL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class LDONLLJBGJE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct GJOPHHIBKAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? LJJLFDHDKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public FDBIONPHOCL PLKHJBNCMFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public OFNABCBHMML JKCPOGOLCEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public KPFGDODNFBO<LDONLLJBGJE> GPOJPCNDIHG;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1F46E90", Offset = "0x1F45690", VA = "0x181F46E90")]
		public GJOPHHIBKAF(int? GLJCCKDGPCN, [In] FDBIONPHOCL DJECEICGNGL, OFNABCBHMML GINCABKOJCC, KPFGDODNFBO<LDONLLJBGJE> GFHNJHKNBCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class HIDJKONCHNM : LDONLLJBGJE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct EMJMGKHNJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int CFDBFCCMKIM;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA36A50", Offset = "0xA35250", VA = "0x180A36A50")]
		public EMJMGKHNJGH(int JBDLDJOINOF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal OLMMCLBBNFI<EOEANKCGGLL, GJOPHHIBKAF> ANFPIIPHNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal OLMMCLBBNFI<ADENKMBCFJM, GAOONLHHMAM> GFIEIBEHNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal OLMMCLBBNFI<HFAGDPAGKOA, BGAFBLKGNOK> IIBDJMLAPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal OLMMCLBBNFI<HIDJKONCHNM, EMJMGKHNJGH> DPMJGHIPGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal OLMMCLBBNFI<HEJGIACMAMP, KHFIOGBOKND> IKFHJGODGCL;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1F471A0", Offset = "0x1F459A0", VA = "0x181F471A0")]
	private HEOFOPBBFFM([In] OLMMCLBBNFI<EOEANKCGGLL, GJOPHHIBKAF> NKPIONBJHPK, [In] OLMMCLBBNFI<ADENKMBCFJM, GAOONLHHMAM> IMPGODEAFKK, [In] OLMMCLBBNFI<HFAGDPAGKOA, BGAFBLKGNOK> OLEPLKCCHMB, [In] OLMMCLBBNFI<HIDJKONCHNM, EMJMGKHNJGH> BAIGJDLEOGG, [In] OLMMCLBBNFI<HEJGIACMAMP, KHFIOGBOKND> HMHNFHCIAOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1F46FB0", Offset = "0x1F457B0", VA = "0x181F46FB0")]
	public static HEOFOPBBFFM OJFFIHPLODM()
	{
		return default(HEOFOPBBFFM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class EFHGHIJHENG
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1F43C30", Offset = "0x1F42430", VA = "0x181F43C30")]
	public static void PGFGBHFCFEG(this HEOFOPBBFFM EGJINJKGIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class IDEOMGFCGND
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1F4C560", Offset = "0x1F4AD60", VA = "0x181F4C560")]
	public static void OHLHHBJPLCP(BBEKMJCHKNG EGJINJKGIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct ENJEGLBJILF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, GPFFHHMHFKK> CMMLMJIAPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int NCDIFIEDPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int HDCAJDIMNCB;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1F43FC0", Offset = "0x1F427C0", VA = "0x181F43FC0")]
	private ENJEGLBJILF([In] PEOPJNDHKBL<FGDKHDFOAKE.KBFEHKDCFHI, GPFFHHMHFKK> HKBCCONPHHM, int ANDFHMBMJOH, int OJDCAMCKHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1F43D60", Offset = "0x1F42560", VA = "0x181F43D60")]
	public static ENJEGLBJILF OJFFIHPLODM()
	{
		return default(ENJEGLBJILF);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1F43DD0", Offset = "0x1F425D0", VA = "0x181F43DD0")]
	public void PGFGBHFCFEG([In] BBEKMJCHKNG MPOPMIPMGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x29252A0", Offset = "0x2923AA0", VA = "0x1829252A0")]
	public static void OHLHHBJPLCP<TDeps, TStateSys>(BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TStateSys BGDDDMIGBBF, KPFGDODNFBO<GPCAGFNHADK> IKNLCPDILAM) where TDeps : notnull, OILHNDNJLHG<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class EOKKBEMEKEA
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1F44000", Offset = "0x1F42800", VA = "0x181F44000")]
	public static void OHLHHBJPLCP(BBEKMJCHKNG EGJINJKGIAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct DOAMJKGGHNH
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface IAJOHGAEEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FFELAPKBAOM(JADAHCHJIGA<byte> GIJOKGLHKNL, int DLAONFMCAMA);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct BHDDIDMKAAK : IAJOHGAEEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1F43440", Offset = "0x1F41C40", VA = "0x181F43440", Slot = "4")]
		public void FFELAPKBAOM(JADAHCHJIGA<byte> GIJOKGLHKNL, int DLAONFMCAMA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct PFAOLAGIPJM : IAJOHGAEEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D390", Offset = "0x1F4BB90", VA = "0x181F4D390", Slot = "4")]
		public void FFELAPKBAOM(JADAHCHJIGA<byte> GIJOKGLHKNL, int DLAONFMCAMA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct EFOKCAKCIOA : IAJOHGAEEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1F43CE0", Offset = "0x1F424E0", VA = "0x181F43CE0", Slot = "4")]
		public void FFELAPKBAOM(JADAHCHJIGA<byte> GIJOKGLHKNL, int DLAONFMCAMA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct MPEIAGHIHFC : IAJOHGAEEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1F4D040", Offset = "0x1F4B840", VA = "0x181F4D040", Slot = "4")]
		public void FFELAPKBAOM(JADAHCHJIGA<byte> GIJOKGLHKNL, int DLAONFMCAMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class JOHMGJMGGLJ<TCallProcessorDeps> where TCallProcessorDeps : struct, IAJOHGAEEBP
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps KKHHCBLJJJL;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x299B330", Offset = "0x2999B30", VA = "0x18299B330")]
		public static int OHLHHBJPLCP<TDeps, TStateSys>(TDeps DNJOEPEBEMJ, TStateSys DAGLKLOEBMA, BBEKMJCHKNG MPOPMIPMGJI, [In] JADAHCHJIGA<byte> IGJMPGDNAKF, int PDAGNIIPACO) where TDeps : OILHNDNJLHG<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private JADAHCHJIGA<CMIDFIOMJIH> PBOKDEJAMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>> GLIAEOOGFHC;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1F43BF0", Offset = "0x1F423F0", VA = "0x181F43BF0")]
	private DOAMJKGGHNH([In] JADAHCHJIGA<CMIDFIOMJIH> OCOPIPAOPOH, Dictionary<KPFGDODNFBO<CMNBACPDIDC<FOLPKKPBDGL>>, KPFGDODNFBO<FGDKHDFOAKE.KBFEHKDCFHI>> FIBOJOMKEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1F43AF0", Offset = "0x1F422F0", VA = "0x181F43AF0")]
	public static DOAMJKGGHNH OJFFIHPLODM()
	{
		return default(DOAMJKGGHNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1F43BB0", Offset = "0x1F423B0", VA = "0x181F43BB0")]
	public void PGFGBHFCFEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x28F9D10", Offset = "0x28F8510", VA = "0x1828F9D10")]
	public static void OHLHHBJPLCP<TDeps, TStateSys>(BBEKMJCHKNG EGJINJKGIAK, TDeps DNJOEPEBEMJ, TStateSys BGDDDMIGBBF) where TDeps : OILHNDNJLHG<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class HJIAADIILOL<TDeps, TIndex, TValues> where TDeps : struct, MHGOIBEKBFG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps KKHHCBLJJJL;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3CAD340", Offset = "0x3CABB40", VA = "0x183CAD340")]
	public static void OHLHHBJPLCP([In] JADAHCHJIGA<CMIDFIOMJIH> OCOPIPAOPOH, int FOHKFNMNLAP, TValues AHHBLMGMEGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface MHGOIBEKBFG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JADAHCHJIGA<TIndex> DFIHJHMMBGA(int FOHKFNMNLAP, [In] TValues AHHBLMGMEGC);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(TIndex JBDLDJOINOF, [In] TValues AHHBLMGMEGC);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DFDNPGGNKDP(TIndex JBDLDJOINOF, TValues AHHBLMGMEGC, KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> IPHHABIKCHD);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface EMLAOOMOGJK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex KJHCJNGKNAO(int JBDLDJOINOF);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GEAAJHCGCGA(TIndex JBDLDJOINOF, [In] TValues AHHBLMGMEGC);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KPFGDODNFBO<CMNBACPDIDC<IPLNPIMDNNN>> BCLBLLDPKOJ(TIndex JBDLDJOINOF, [In] TValues AHHBLMGMEGC);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class PLMNEOMCLNJ<TDeps, TIndex, TValues> where TDeps : struct, EMLAOOMOGJK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps KKHHCBLJJJL;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x46687B0", Offset = "0x4666FB0", VA = "0x1846687B0")]
	public static JADAHCHJIGA<TIndex> OHLHHBJPLCP(int FOHKFNMNLAP, [In] TValues AHHBLMGMEGC)
	{
		return default(JADAHCHJIGA<TIndex>);
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
