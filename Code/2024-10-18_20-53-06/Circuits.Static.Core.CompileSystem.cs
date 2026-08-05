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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x223C100", Offset = "0x223B500", VA = "0x18223C100")]
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
public readonly struct LBOHAAEMDDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> EFDGNLAEJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int NLMHBLNBBHA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
	public LBOHAAEMDDL(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> MHDOPFNMJEE, int OLMEFNCLGNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GLIOLJFACDH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class EPLCLKBOOGC : LICOBDILKPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct JHDJFHFIOIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly ODADIOPEEKI<byte> MOJBFCJHECB;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21DC2D0", Offset = "0x21DB6D0", VA = "0x1821DC2D0")]
		public JHDJFHFIOIN(ODADIOPEEKI<byte> FAHBHOHHIKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2238350", Offset = "0x2237750", VA = "0x182238350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BBHNHIONBCI : LICOBDILKPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct PADPLCFGBIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> LFGEKHDNCNI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
		public PADPLCFGBIF(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> FKNNFDEECPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum MJMPHKHJOEJ
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
	public sealed class LGOMPCLKODE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class LICOBDILKPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct FDNOFLECBOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly MJMPHKHJOEJ DLEKHPMLGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly MIEEFIOIIBN<LICOBDILKPA> IPCDEIJPOCO;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
		public FDNOFLECBOP(MJMPHKHJOEJ AJHEBLENGLF, MIEEFIOIIBN<LICOBDILKPA> OBAFEDFLKJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class BKIIGOEGPFE : LICOBDILKPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct KHPKHPFHPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> CPBMIBHJCOH;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
		public KHPKHPFHPBD(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EBNFDMPGBOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class GOBKBHDIINO : LICOBDILKPA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct MPDLLJMCKBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly GKIFKJFALJB HGEPIJOIDDL;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
		public MPDLLJMCKBN(GKIFKJFALJB NNBNHMGFGBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2238AB0", Offset = "0x2237EB0", VA = "0x182238AB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal FAFACDIMDHL<LGOMPCLKODE, FDNOFLECBOP> LFJOEILMCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal FAFACDIMDHL<EPLCLKBOOGC, JHDJFHFIOIN> IOGBPKACOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal FAFACDIMDHL<BBHNHIONBCI, PADPLCFGBIF> BLMKDFADOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal FAFACDIMDHL<BKIIGOEGPFE, KHPKHPFHPBD> OOPKKELPJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal FAFACDIMDHL<GOBKBHDIINO, MPDLLJMCKBN> HAJOMCLAIOJ;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2237BE0", Offset = "0x2236FE0", VA = "0x182237BE0")]
	private GLIOLJFACDH([In] FAFACDIMDHL<LGOMPCLKODE, FDNOFLECBOP> FIOIDGFGFOO, [In] FAFACDIMDHL<EPLCLKBOOGC, JHDJFHFIOIN> DMNFHFHMFBJ, [In] FAFACDIMDHL<BBHNHIONBCI, PADPLCFGBIF> DNDMKPHCMGB, [In] FAFACDIMDHL<BKIIGOEGPFE, KHPKHPFHPBD> DPJBPNJEMOP, [In] FAFACDIMDHL<GOBKBHDIINO, MPDLLJMCKBN> PMGAAGJHPDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2237AA0", Offset = "0x2236EA0", VA = "0x182237AA0")]
	public static GLIOLJFACDH AHLALEPNKFA()
	{
		return default(GLIOLJFACDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GAJENFJOIMF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2237940", Offset = "0x2236D40", VA = "0x182237940")]
	public static void KJDEEDGEPIJ(this GLIOLJFACDH MCPMOAEEEOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum BIGPOOEHNNE
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
public struct JJPMIKLDFBC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class EBOOMLPDAAB : BGBJHEOOOKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct EGBDFECLPAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> ENMJLHFLBNF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
		public EGBDFECLPAD(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> HPKPMFPJGPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum AJHKBDNPOKE
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
	public sealed class AMHGPDMJOMG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class BGBJHEOOOKO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct EMFFOLJAAPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly AJHKBDNPOKE DLEKHPMLGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly MIEEFIOIIBN<BGBJHEOOOKO> IPCDEIJPOCO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
		public EMFFOLJAAPP(AJHKBDNPOKE AJHEBLENGLF, MIEEFIOIIBN<BGBJHEOOOKO> OBAFEDFLKJP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal FAFACDIMDHL<AMHGPDMJOMG, EMFFOLJAAPP> LFJOEILMCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal FAFACDIMDHL<EBOOMLPDAAB, EGBDFECLPAD> GGPLJEPBJIM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2238450", Offset = "0x2237850", VA = "0x182238450")]
	private JJPMIKLDFBC([In] FAFACDIMDHL<AMHGPDMJOMG, EMFFOLJAAPP> FIOIDGFGFOO, [In] FAFACDIMDHL<EBOOMLPDAAB, EGBDFECLPAD> AJOAPDGJGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x22383C0", Offset = "0x22377C0", VA = "0x1822383C0")]
	public static JJPMIKLDFBC AHLALEPNKFA()
	{
		return default(JJPMIKLDFBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class DMOJCMJEDDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2237060", Offset = "0x2236460", VA = "0x182237060")]
	public static void KJDEEDGEPIJ(this JJPMIKLDFBC MCPMOAEEEOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CJCDLPDCMIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public OCJDOODMLMI<int> CDHIEANMAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public OCJDOODMLMI<int> IEOFKAGGBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int GGPGPIHNCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int KLIJHADGJLA;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2236CE0", Offset = "0x22360E0", VA = "0x182236CE0")]
	private CJCDLPDCMIG([In] OCJDOODMLMI<int> ABPOKOEJGIP, [In] OCJDOODMLMI<int> LCAOLMBEANM, int HGGIGEOLIGC, int BIFAAFNAOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2236C40", Offset = "0x2236040", VA = "0x182236C40")]
	public static CJCDLPDCMIG AHLALEPNKFA()
	{
		return default(CJCDLPDCMIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class ODIIAIGMOGF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x223C180", Offset = "0x223B580", VA = "0x18223C180")]
	public static void KJDEEDGEPIJ(this CJCDLPDCMIG MCPMOAEEEOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EEGFLIINHGM
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum HODMNKDFDLC
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class MHGIKHHGFDI : FBEBIHMMFGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct FCIHCKDKJML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly MIEEFIOIIBN<IMEEPANNABA> OAFLMDAAACP;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
		public FCIHCKDKJML(MIEEFIOIIBN<IMEEPANNABA> JOMDNEDAIPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class KBHJPOPKJAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class FBEBIHMMFGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct OOFIDGECDHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly HODMNKDFDLC DLEKHPMLGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly MIEEFIOIIBN<FBEBIHMMFGO> IPCDEIJPOCO;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
		private OOFIDGECDHP(HODMNKDFDLC AJHEBLENGLF, MIEEFIOIIBN<FBEBIHMMFGO> OBAFEDFLKJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x223C1E0", Offset = "0x223B5E0", VA = "0x18223C1E0")]
		public static OOFIDGECDHP AHLALEPNKFA(HODMNKDFDLC AJHEBLENGLF, MIEEFIOIIBN<FBEBIHMMFGO> OBAFEDFLKJP)
		{
			return default(OOFIDGECDHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class NAPHBCKNJIC : FBEBIHMMFGO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct JLNDFEMFBMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly MIEEFIOIIBN<IMEEPANNABA> OAFLMDAAACP;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
		public JLNDFEMFBMD(MIEEFIOIIBN<IMEEPANNABA> JOMDNEDAIPE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class IMEEPANNABA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct PIBMHDMCKIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public OCJDOODMLMI<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> GEONHCLIDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OCJDOODMLMI<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> NFEBFJDBPKH;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2238450", Offset = "0x2237850", VA = "0x182238450")]
		private PIBMHDMCKIN([In] OCJDOODMLMI<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> AECHHEDDKNJ, [In] OCJDOODMLMI<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> PLJAKEFKIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x223C1F0", Offset = "0x223B5F0", VA = "0x18223C1F0")]
		public static PIBMHDMCKIN AHLALEPNKFA()
		{
			return default(PIBMHDMCKIN);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal FAFACDIMDHL<KBHJPOPKJAG, OOFIDGECDHP> LFJOEILMCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal FAFACDIMDHL<NAPHBCKNJIC, JLNDFEMFBMD> HDOHPACFBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal FAFACDIMDHL<MHGIKHHGFDI, FCIHCKDKJML> AHAFGKBFDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal OCJDOODMLMI<(MIEEFIOIIBN<KBHJPOPKJAG> CallId, MIEEFIOIIBN<IMEEPANNABA> IOId)> GIOGGIKJAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal FAFACDIMDHL<IMEEPANNABA, PIBMHDMCKIN> FAJONFMADOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal DGOPJPCIBPB<IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>> OIMDDKMLMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal DGOPJPCIBPB<IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>> DIJGIGBPMMD;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2237310", Offset = "0x2236710", VA = "0x182237310")]
	private EEGFLIINHGM([In] FAFACDIMDHL<KBHJPOPKJAG, OOFIDGECDHP> FIOIDGFGFOO, [In] FAFACDIMDHL<NAPHBCKNJIC, JLNDFEMFBMD> IJLMJOCCNDE, [In] FAFACDIMDHL<MHGIKHHGFDI, FCIHCKDKJML> NEKBJKODKJA, [In] OCJDOODMLMI<(MIEEFIOIIBN<KBHJPOPKJAG> CallId, MIEEFIOIIBN<IMEEPANNABA> IOId)> BDOENLBMHIB, [In] FAFACDIMDHL<IMEEPANNABA, PIBMHDMCKIN> JHBANNGAEBN, [In] DGOPJPCIBPB<IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>> KAKEGIDEEHP, [In] DGOPJPCIBPB<IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>> AOBJJBOHNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2237170", Offset = "0x2236570", VA = "0x182237170")]
	public static EEGFLIINHGM AHLALEPNKFA()
	{
		return default(EEGFLIINHGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class ABAOIBFIHHM
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2231500", Offset = "0x2230900", VA = "0x182231500")]
	private static void KJDEEDGEPIJ(this EEGFLIINHGM.PIBMHDMCKIN MCPMOAEEEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x22312F0", Offset = "0x22306F0", VA = "0x1822312F0")]
	public static void KJDEEDGEPIJ(this EEGFLIINHGM MCPMOAEEEOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NDKKNACFGPO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public OCJDOODMLMI<byte> DKHDGFLODMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal EEGFLIINHGM LPCEOBDGBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal DIKLJDHDIIF JMOLPNLNBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> EPKDFCAMGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal GLIOLJFACDH GAONOHBDHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal JJPMIKLDFBC LEFOOHMEMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal DGOPJPCIBPB<IMBJFPFGGEG, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>?> EGABBCIHEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal OCJDOODMLMI<MIEEFIOIIBN<IMBJFPFGGEG>> EEMBNCFMHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?> NCNLPPGHECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> VariableId, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>> ByteCodeWriteLocation)> FBKJJBMGLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> OHCHKFJLGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal HMCHJJGLLNF ONDDDICOFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal MJLEJLMJJIG ICOHFOICGDF;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2239480", Offset = "0x2238880", VA = "0x182239480")]
	private NDKKNACFGPO([In] OCJDOODMLMI<byte> KGIGJMCJCJD, [In] EEGFLIINHGM DGGOLPKDLOJ, [In] DIKLJDHDIIF JBFLKCOIAKA, [In] GLIOLJFACDH LEJPNBGAIHK, [In] JJPMIKLDFBC KCLJFCJEBOA, [In] DGOPJPCIBPB<IMBJFPFGGEG, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>?> PMCMFIOPLCK, [In] OCJDOODMLMI<MIEEFIOIIBN<IMBJFPFGGEG>> ONHIDBIPJKE, [In] DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?> JIMFNPFDBGO, [In] OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> VariableId, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>> ByteCodeWriteLocation)> HOHNONLDBOK, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> DOHDGJIDCIP, [In] HMCHJJGLLNF BMCKHKBDEFG, [In] MJLEJLMJJIG BKEOOCGOKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2238AD0", Offset = "0x2237ED0", VA = "0x182238AD0")]
	public static NDKKNACFGPO AHLALEPNKFA()
	{
		return default(NDKKNACFGPO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class NFHKLKMBFHH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct JKPOBHOJOCH : BIBJIIFFIIF<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>, DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x22384A0", Offset = "0x22378A0", VA = "0x1822384A0")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2238550", Offset = "0x2237950", VA = "0x182238550", Slot = "4")]
		public MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> FIAFJNJLCAG(int HAJICDLBEKC)
		{
			return default(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810")]
		public bool KHNIDMLPLNH(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "5")]
		private bool GBECCIOBGPE(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2238490", Offset = "0x2237890", VA = "0x182238490", Slot = "6")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> AENFAOEDOCA(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct NOBJINAELDF : JIPMPMDPDOK<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>, DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x223BF10", Offset = "0x223B310", VA = "0x18223BF10")]
		public OCJDOODMLMI<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>> BFOAICGCOBB(int ELHBDDPPEAK, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x223BE60", Offset = "0x223B260", VA = "0x18223BE60")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x223BF90", Offset = "0x223B390", VA = "0x18223BF90", Slot = "6")]
		public void NJOOCHCFAKL(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>> BFAMJIIMLEB, MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x223BF10", Offset = "0x223B310", VA = "0x18223BF10", Slot = "4")]
		private OCJDOODMLMI<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>> DPJEDJHFECC(int ELHBDDPPEAK, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x223BF80", Offset = "0x223B380", VA = "0x18223BF80", Slot = "5")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> CMMMFJIKINH(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct KLCLKBCPGGE : BIBJIIFFIIF<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>, DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x22385A0", Offset = "0x22379A0", VA = "0x1822385A0")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2238650", Offset = "0x2237A50", VA = "0x182238650", Slot = "4")]
		public MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> FIAFJNJLCAG(int HAJICDLBEKC)
		{
			return default(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810")]
		public bool KHNIDMLPLNH(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "5")]
		private bool NDCPFGDJCMH(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2238590", Offset = "0x2237990", VA = "0x182238590", Slot = "6")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> AGEONOAKFNB(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct AJJJCMEMPBE : JIPMPMDPDOK<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>, DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2231830", Offset = "0x2230C30", VA = "0x182231830")]
		public OCJDOODMLMI<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>> BFOAICGCOBB(int ELHBDDPPEAK, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2231780", Offset = "0x2230B80", VA = "0x182231780")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x22318A0", Offset = "0x2230CA0", VA = "0x1822318A0", Slot = "6")]
		public void NJOOCHCFAKL(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>> BFAMJIIMLEB, MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2231830", Offset = "0x2230C30", VA = "0x182231830", Slot = "4")]
		private OCJDOODMLMI<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>> EOIJFBFMGEB(int ELHBDDPPEAK, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2231960", Offset = "0x2230D60", VA = "0x182231960", Slot = "5")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> PNIMJPNMPHJ(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> HAJICDLBEKC, [In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct LEIKNKHBHBB : BIBJIIFFIIF<MIEEFIOIIBN<HIBILKABFFC>, DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2238680", Offset = "0x2237A80", VA = "0x182238680")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(MIEEFIOIIBN<HIBILKABFFC> HAJICDLBEKC, [In] DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x22387E0", Offset = "0x2237BE0", VA = "0x1822387E0", Slot = "4")]
		public MIEEFIOIIBN<HIBILKABFFC> FIAFJNJLCAG(int HAJICDLBEKC)
		{
			return default(MIEEFIOIIBN<HIBILKABFFC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2238760", Offset = "0x2237B60", VA = "0x182238760")]
		public bool KHNIDMLPLNH(MIEEFIOIIBN<HIBILKABFFC> HAJICDLBEKC, [In] DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2238760", Offset = "0x2237B60", VA = "0x182238760", Slot = "5")]
		private bool DJHGLPAMABK(MIEEFIOIIBN<HIBILKABFFC> HAJICDLBEKC, [In] DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2238750", Offset = "0x2237B50", VA = "0x182238750", Slot = "6")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> CAJFPHFGIDC(MIEEFIOIIBN<HIBILKABFFC> HAJICDLBEKC, [In] DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct AIFOJCIHPML : JIPMPMDPDOK<MIEEFIOIIBN<HIBILKABFFC>, DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2231620", Offset = "0x2230A20", VA = "0x182231620")]
		public OCJDOODMLMI<MIEEFIOIIBN<HIBILKABFFC>> BFOAICGCOBB(int ELHBDDPPEAK, [In] DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<MIEEFIOIIBN<HIBILKABFFC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2231550", Offset = "0x2230950", VA = "0x182231550")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(MIEEFIOIIBN<HIBILKABFFC> HAJICDLBEKC, [In] DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x22316A0", Offset = "0x2230AA0", VA = "0x1822316A0", Slot = "6")]
		public void NJOOCHCFAKL(MIEEFIOIIBN<HIBILKABFFC> HAJICDLBEKC, DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?> BFAMJIIMLEB, MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2231620", Offset = "0x2230A20", VA = "0x182231620", Slot = "4")]
		private OCJDOODMLMI<MIEEFIOIIBN<HIBILKABFFC>> CBBALFDNLFJ(int ELHBDDPPEAK, [In] DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<MIEEFIOIIBN<HIBILKABFFC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2231690", Offset = "0x2230A90", VA = "0x182231690", Slot = "5")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> GDELJINJDLN(MIEEFIOIIBN<HIBILKABFFC> HAJICDLBEKC, [In] DGOPJPCIBPB<HIBILKABFFC, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>?> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct HEBEGPFIMKM : BIBJIIFFIIF<int, OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2237CB0", Offset = "0x22370B0", VA = "0x182237CB0")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> VariableId, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9470D0", Offset = "0x9464D0", VA = "0x1809470D0", Slot = "4")]
		public int FIAFJNJLCAG(int HAJICDLBEKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810")]
		public bool KHNIDMLPLNH(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> VariableId, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "5")]
		private bool DDAAPBMCEEJ(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> VariableId, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2237D50", Offset = "0x2237150", VA = "0x182237D50", Slot = "6")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> GFLNPHGFIAM(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> VariableId, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct EPAAIOJHHNH : JIPMPMDPDOK<int, OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2237520", Offset = "0x2236920", VA = "0x182237520")]
		public OCJDOODMLMI<int> BFOAICGCOBB(int ELHBDDPPEAK, [In] OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> VariableId, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2237480", Offset = "0x2236880", VA = "0x182237480")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> VariableId, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2237590", Offset = "0x2236990", VA = "0x182237590", Slot = "6")]
		public void NJOOCHCFAKL(int HAJICDLBEKC, OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> VariableId, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>> ByteCodeWriteLocation)> BFAMJIIMLEB, MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2237520", Offset = "0x2236920", VA = "0x182237520", Slot = "4")]
		private OCJDOODMLMI<int> OMMDGNEHMAL(int ELHBDDPPEAK, [In] OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> VariableId, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2237690", Offset = "0x2236A90", VA = "0x182237690", Slot = "5")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> OIHJJOIKPCP(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> VariableId, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<LCMAICEDDBI>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct EAOICJNJKOC : BIBJIIFFIIF<int, OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x22370C0", Offset = "0x22364C0", VA = "0x1822370C0")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9470D0", Offset = "0x9464D0", VA = "0x1809470D0", Slot = "4")]
		public int FIAFJNJLCAG(int HAJICDLBEKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810")]
		public bool KHNIDMLPLNH(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "5")]
		private bool BGCIHIDDCNB(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2237160", Offset = "0x2236560", VA = "0x182237160", Slot = "6")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> OPCGGFONKDO(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct INAFJMCHJID : JIPMPMDPDOK<int, OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2238160", Offset = "0x2237560", VA = "0x182238160")]
		public OCJDOODMLMI<int> BFOAICGCOBB(int ELHBDDPPEAK, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x22380C0", Offset = "0x22374C0", VA = "0x1822380C0")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x22381E0", Offset = "0x22375E0", VA = "0x1822381E0", Slot = "6")]
		public void NJOOCHCFAKL(int HAJICDLBEKC, OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB, MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2238160", Offset = "0x2237560", VA = "0x182238160", Slot = "4")]
		private OCJDOODMLMI<int> BCLAMMGGPNG(int ELHBDDPPEAK, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x22381D0", Offset = "0x22375D0", VA = "0x1822381D0", Slot = "5")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> KMPJLIIDOPI(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct GHCMKNEAELN : BIBJIIFFIIF<int, OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x22379F0", Offset = "0x2236DF0", VA = "0x1822379F0")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9470D0", Offset = "0x9464D0", VA = "0x1809470D0", Slot = "4")]
		public int FIAFJNJLCAG(int HAJICDLBEKC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810")]
		public bool KHNIDMLPLNH(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "5")]
		private bool BGCIHIDDCNB(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2237A90", Offset = "0x2236E90", VA = "0x182237A90", Slot = "6")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> OPCGGFONKDO(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct FCDKLMJAIGL : JIPMPMDPDOK<int, OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2237740", Offset = "0x2236B40", VA = "0x182237740")]
		public OCJDOODMLMI<int> BFOAICGCOBB(int ELHBDDPPEAK, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x22376A0", Offset = "0x2236AA0", VA = "0x1822376A0")]
		public MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x22377C0", Offset = "0x2236BC0", VA = "0x1822377C0", Slot = "6")]
		public void NJOOCHCFAKL(int HAJICDLBEKC, OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB, MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2237740", Offset = "0x2236B40", VA = "0x182237740", Slot = "4")]
		private OCJDOODMLMI<int> BCLAMMGGPNG(int ELHBDDPPEAK, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(OCJDOODMLMI<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x22377B0", Offset = "0x2236BB0", VA = "0x1822377B0", Slot = "5")]
		private MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> KMPJLIIDOPI(int HAJICDLBEKC, [In] OCJDOODMLMI<(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> Target, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> ByteCodeWriteLocation)> BFAMJIIMLEB)
		{
			return default(MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct OFKBNAEJHIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> FKEMLOPKCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool FJBMBDDHLKN;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1784E80", Offset = "0x1784280", VA = "0x181784E80")]
		public OFKBNAEJHIG(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD, bool NMPNDIHELAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x223C1D0", Offset = "0x223B5D0", VA = "0x18223C1D0")]
		public void KGNAIFFBBCO([Out] MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD, [Out] bool NMPNDIHELAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct GPCLNAFODMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly MIEEFIOIIBN<HIBILKABFFC> HBKOJDFPBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> FKEMLOPKCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool FJBMBDDHLKN;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2237CA0", Offset = "0x22370A0", VA = "0x182237CA0")]
		public GPCLNAFODMJ(MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD, bool NMPNDIHELAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2237C90", Offset = "0x2237090", VA = "0x182237C90")]
		public void KGNAIFFBBCO([Out] MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD, [Out] bool NMPNDIHELAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2237C70", Offset = "0x2237070", VA = "0x182237C70")]
		public void KGNAIFFBBCO([Out] MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD, [Out] MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH, [Out] bool NMPNDIHELAH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct IBHJPOCMJEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly MIEEFIOIIBN<HIBILKABFFC> HBKOJDFPBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> FKEMLOPKCPN;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
		public IBHJPOCMJEA(MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2238000", Offset = "0x2237400", VA = "0x182238000")]
		public void KGNAIFFBBCO([Out] MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD, [Out] MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x223B2D0", Offset = "0x223A6D0", VA = "0x18223B2D0")]
	public static void KJDEEDGEPIJ(this NDKKNACFGPO MCPMOAEEEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2239C90", Offset = "0x2239090", VA = "0x182239C90")]
	public static void BGACCEOHFHO(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> CEEIJFCEOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2239EB0", Offset = "0x22392B0", VA = "0x182239EB0")]
	public static void CMHCIPLNCGP(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> CEEIJFCEOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2239DF0", Offset = "0x22391F0", VA = "0x182239DF0")]
	public static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>? CFEDDOEOMGD([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x223BD40", Offset = "0x223B140", VA = "0x18223BD40")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> PEOLFMBHEEL([In] this NDKKNACFGPO MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x223AFF0", Offset = "0x223A3F0", VA = "0x18223AFF0")]
	private static void KGEFEFIMCLH(this NDKKNACFGPO MCPMOAEEEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x223BDA0", Offset = "0x223B1A0", VA = "0x18223BDA0")]
	private static MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>? PKMFKEGICMN([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x223B160", Offset = "0x223A560", VA = "0x18223B160")]
	public static void KHKKECPKFAH(this NDKKNACFGPO MCPMOAEEEOJ, [In] OCJDOODMLMI<LBOHAAEMDDL> PKNDFLFELNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x223A460", Offset = "0x2239860", VA = "0x18223A460")]
	public static GLIOLJFACDH.MJMPHKHJOEJ ELJJGLLBNEO([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD)
	{
		return default(GLIOLJFACDH.MJMPHKHJOEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x223ABF0", Offset = "0x2239FF0", VA = "0x18223ABF0")]
	public static ODADIOPEEKI<byte> HMMCGGFCGNG([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD)
	{
		return default(ODADIOPEEKI<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x223BAB0", Offset = "0x223AEB0", VA = "0x18223BAB0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> NNBCCBACOBK([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x223AEC0", Offset = "0x223A2C0", VA = "0x18223AEC0")]
	public static GKIFKJFALJB JEOHDKDMIGF([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD)
	{
		return default(GKIFKJFALJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6980", Offset = "0x2FB5D80", VA = "0x182FB6980")]
	private static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OPMPFHDOPGO<TMJoin>(this NDKKNACFGPO MCPMOAEEEOJ, GLIOLJFACDH.MJMPHKHJOEJ AJHEBLENGLF, MIEEFIOIIBN<TMJoin> OBAFEDFLKJP) where TMJoin : GLIOLJFACDH.LICOBDILKPA
	{
		return default(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2239B80", Offset = "0x2238F80", VA = "0x182239B80")]
	public static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> AKLDNJEBKLN(this NDKKNACFGPO MCPMOAEEEOJ, bool GOIEKBAOEIL)
	{
		return default(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2239C00", Offset = "0x2239000", VA = "0x182239C00")]
	public static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> BEEODAMCAOB(this NDKKNACFGPO MCPMOAEEEOJ, ODADIOPEEKI<byte> FAHBHOHHIKE)
	{
		return default(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x223A620", Offset = "0x2239A20", VA = "0x18223A620")]
	public static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> GBIKDIKJAOJ(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> FKNNFDEECPP)
	{
		return default(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x223BCC0", Offset = "0x223B0C0", VA = "0x18223BCC0")]
	public static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OIANKMFDKBO(this NDKKNACFGPO MCPMOAEEEOJ, int MLEOCLIPKMG)
	{
		return default(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x223AB70", Offset = "0x2239F70", VA = "0x18223AB70")]
	public static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> HKJFGFMDJAM(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EBNFDMPGBOD)
	{
		return default(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2FB50A0", Offset = "0x2FB44A0", VA = "0x182FB50A0")]
	private static MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG> AOGJHDHJIMB<TMJoin>(this NDKKNACFGPO MCPMOAEEEOJ, JJPMIKLDFBC.AJHKBDNPOKE AJHEBLENGLF, MIEEFIOIIBN<TMJoin> OBAFEDFLKJP) where TMJoin : JJPMIKLDFBC.BGBJHEOOOKO
	{
		return default(MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x223AFB0", Offset = "0x223A3B0", VA = "0x18223AFB0")]
	public static MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG> JJIDDDLBJKP(this NDKKNACFGPO MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x223A5D0", Offset = "0x22399D0", VA = "0x18223A5D0")]
	public static MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG> FJCMEOCLBFF(this NDKKNACFGPO MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x223AA60", Offset = "0x2239E60", VA = "0x18223AA60")]
	public static MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG> HHFGIJEFJJD(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> HPKPMFPJGPP)
	{
		return default(MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x223A710", Offset = "0x2239B10", VA = "0x18223A710")]
	public static MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG> GMPGBEAPGBO(this NDKKNACFGPO MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x223BC70", Offset = "0x223B070", VA = "0x18223BC70")]
	public static MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG> OENJKNHPNHL(this NDKKNACFGPO MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x223A0F0", Offset = "0x22394F0", VA = "0x18223A0F0")]
	public static EEGFLIINHGM.HODMNKDFDLC DNGGPAKLMFN([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG> GJEHHAMDKCJ)
	{
		return default(EEGFLIINHGM.HODMNKDFDLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x223B8C0", Offset = "0x223ACC0", VA = "0x18223B8C0")]
	public static JNMOIDIJNBK<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>, DGCGPABIOBD<EEGFLIINHGM.IMEEPANNABA>> LHGBEDFAPDP([In] this NDKKNACFGPO MCPMOAEEEOJ)
	{
		return default(JNMOIDIJNBK<MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>, DGCGPABIOBD<EEGFLIINHGM.IMEEPANNABA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x223B6E0", Offset = "0x223AAE0", VA = "0x18223B6E0")]
	public static MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> LDKMMNEKMBI([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG> GJEHHAMDKCJ)
	{
		return default(MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x223A070", Offset = "0x2239470", VA = "0x18223A070")]
	public static EEGFLIINHGM.PIBMHDMCKIN DLEGJKCAOMF([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> JOMDNEDAIPE)
	{
		return default(EEGFLIINHGM.PIBMHDMCKIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x223A9E0", Offset = "0x2239DE0", VA = "0x18223A9E0")]
	public static EEGFLIINHGM.PIBMHDMCKIN HBMOFJANFLO(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> JOMDNEDAIPE)
	{
		return default(EEGFLIINHGM.PIBMHDMCKIN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2FB53F0", Offset = "0x2FB47F0", VA = "0x182FB53F0")]
	private static MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG> EMAAEHEHLGM<TMJoin>(this NDKKNACFGPO MCPMOAEEEOJ, EEGFLIINHGM.HODMNKDFDLC AJHEBLENGLF, MIEEFIOIIBN<TMJoin> OBAFEDFLKJP) where TMJoin : EEGFLIINHGM.FBEBIHMMFGO
	{
		return default(MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x223A220", Offset = "0x2239620", VA = "0x18223A220")]
	public static (MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>) EGDMDFJCHAH(this NDKKNACFGPO MCPMOAEEEOJ)
	{
		return default((MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x223B900", Offset = "0x223AD00", VA = "0x18223B900")]
	public static (MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>) MHPHCJDDPLE(this NDKKNACFGPO MCPMOAEEEOJ)
	{
		return default((MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x223AE70", Offset = "0x223A270", VA = "0x18223AE70")]
	public static MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG> IKDEGMKNLNH(this NDKKNACFGPO MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x223AAE0", Offset = "0x2239EE0", VA = "0x18223AAE0")]
	public static void HJBHLNAJPEE(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA> JOMDNEDAIPE, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> EOCPMEKOAFA, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>> IDBHCHAEADE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5B50", Offset = "0x2FB4F50", VA = "0x182FB5B50")]
	public static OFKBNAEJHIG MMGPHNMENJE<TDeps, TStateSys>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH) where TDeps : OMLLDHLPPHN<TStateSys>
	{
		return default(OFKBNAEJHIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5150", Offset = "0x2FB4550", VA = "0x182FB5150")]
	public static GPCLNAFODMJ EHJOIKEDBFH<TDeps, TStateSys>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, int CNAIPFMACGM) where TDeps : OMLLDHLPPHN<TStateSys>
	{
		return default(GPCLNAFODMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2FB4C60", Offset = "0x2FB4060", VA = "0x182FB4C60")]
	public static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>? AGCGLJEBFOC<TDeps, TStateSys>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, [In] ReadOnlySpan<int> ENEGFJKLFHC, [In] Span<IBHJPOCMJEA> KKFFBLMDIMD) where TDeps : OMLLDHLPPHN<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5490", Offset = "0x2FB4890", VA = "0x182FB5490")]
	public static MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG> FPHEDKEBDNB<TDeps, TStateSys>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE) where TDeps : OMLLDHLPPHN<TStateSys>
	{
		return default(MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2239A90", Offset = "0x2238E90", VA = "0x182239A90")]
	public static DIKLJDHDIIF.KPBNJMIGJFK AJNMELBGOIK([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> NKPCGMJMEIE)
	{
		return default(DIKLJDHDIIF.KPBNJMIGJFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x22397E0", Offset = "0x2238BE0", VA = "0x1822397E0")]
	public static DIKLJDHDIIF.NJDAPDEJBFM ADIFEOLFDHO([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> NKPCGMJMEIE)
	{
		return default(DIKLJDHDIIF.NJDAPDEJBFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x22398D0", Offset = "0x2238CD0", VA = "0x1822398D0")]
	public static DIKLJDHDIIF.KKNOKEKLPMN AHNJNFEOEIP([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> NKPCGMJMEIE)
	{
		return default(DIKLJDHDIIF.KKNOKEKLPMN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x223ACE0", Offset = "0x223A0E0", VA = "0x18223ACE0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IJMABEKKBCO(this NDKKNACFGPO MCPMOAEEEOJ, int? PAEEAFEAEAD, string DDDHPCNFCEK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x223A4E0", Offset = "0x22398E0", VA = "0x18223A4E0")]
	public static DIKLJDHDIIF.DJKDPEEIEID FEAIOOENHFG([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> NKPCGMJMEIE)
	{
		return default(DIKLJDHDIIF.DJKDPEEIEID);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2239D80", Offset = "0x2239180", VA = "0x182239D80")]
	public static DIKLJDHDIIF.JPOAMOJIIDC BODKECANNEB([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> NKPCGMJMEIE)
	{
		return default(DIKLJDHDIIF.JPOAMOJIIDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x223A6A0", Offset = "0x2239AA0", VA = "0x18223A6A0")]
	public static int? GIPCEPJCPBP([In] this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> NKPCGMJMEIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2FB5A50", Offset = "0x2FB4E50", VA = "0x182FB5A50")]
	private static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> KFDEIPAFEGF<TMJoin>(this NDKKNACFGPO MCPMOAEEEOJ, int? PAEEAFEAEAD, DIKLJDHDIIF.JPOAMOJIIDC AJHEBLENGLF, MIEEFIOIIBN<TMJoin> OBAFEDFLKJP) where TMJoin : DIKLJDHDIIF.FHFINCFBAJB
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x223A170", Offset = "0x2239570", VA = "0x18223A170")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> ECCMBMGBFKG(this NDKKNACFGPO MCPMOAEEEOJ, int? PAEEAFEAEAD, MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG> GJEHHAMDKCJ, int HAJICDLBEKC)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x223A010", Offset = "0x2239410", VA = "0x18223A010")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> DICFIHKHALB(this NDKKNACFGPO MCPMOAEEEOJ, int? PAEEAFEAEAD)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x223A760", Offset = "0x2239B60", VA = "0x18223A760")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> GPLJJADLJBK(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>? JHBDLCOPMCF, int? PAEEAFEAEAD)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2239F80", Offset = "0x2239380", VA = "0x182239F80")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> CMMINCCAMHA(this NDKKNACFGPO MCPMOAEEEOJ, int? PAEEAFEAEAD, int HAJICDLBEKC)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2239D20", Offset = "0x2239120", VA = "0x182239D20")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> BGHFGNHLKKB(this NDKKNACFGPO MCPMOAEEEOJ, int? PAEEAFEAEAD)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x223B5A0", Offset = "0x223A9A0", VA = "0x18223B5A0")]
	public static void KMPMPDMHFON(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EBNFDMPGBOD, MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG> GJEHHAMDKCJ, int HAJICDLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x223A8B0", Offset = "0x2239CB0", VA = "0x18223A8B0")]
	public static void HBCEIACNJIM(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EBNFDMPGBOD, int HAJICDLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x223BBA0", Offset = "0x223AFA0", VA = "0x18223BBA0")]
	public static void NNKMOBGDDEI(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EBNFDMPGBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x223A3D0", Offset = "0x22397D0", VA = "0x18223A3D0")]
	public static void EJOLKBCDNKC(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> KDGMCPCFIID, MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> LGIHCGMGPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x22399C0", Offset = "0x2238DC0", VA = "0x1822399C0")]
	public static void AJHLLHPHDBA(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EBNFDMPGBOD, MIEEFIOIIBN<FLIDLELCAJJ<GDFDOLCLGIL>> MJGPEDKKJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2FB6A30", Offset = "0x2FB5E30", VA = "0x182FB6A30")]
	public static void PNDHGKKBGLL<M>(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EBNFDMPGBOD, MIEEFIOIIBN<FLIDLELCAJJ<CMBJJMFFHEG<M>>> MJGPEDKKJDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface OMLLDHLPPHN<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MIEEFIOIIBN<AEMFFDNPCNP> EMMDDGDJGBG(TStateSys NCIHMAFAKAP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MIEEFIOIIBN<AEMFFDNPCNP> BFHIKMLLLLE(TStateSys NCIHMAFAKAP);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MIEEFIOIIBN<AEMFFDNPCNP> BJNLGAANKBO(TStateSys NCIHMAFAKAP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MIEEFIOIIBN<AEMFFDNPCNP> CLEGCFFEOAI(TStateSys NCIHMAFAKAP);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG> DFFDEEOCKEM(TStateSys NCIHMAFAKAP, NDKKNACFGPO HOEAJCDADPH, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> ICJNHOLELGI(TStateSys NCIHMAFAKAP, NDKKNACFGPO HOEAJCDADPH, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OJOMOAKDHEH(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MIEEFIOIIBN<IMBJFPFGGEG> CGLFIGFIOHA(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH, int KLEBBHLPMGG);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BIGPOOEHNNE JAEHLAODFBE(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NNDNHAMOEDP(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int GGAKLDCAMKC(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ODADIOPEEKI<byte> OCKLCIGPKLC(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(ODADIOPEEKI<byte>, MIEEFIOIIBN<AEMFFDNPCNP>) KDGMHCAEDCM(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<HIBILKABFFC> JJEIDNNKDCH);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int JPMJACNMAKN(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MIEEFIOIIBN<HIBILKABFFC> DDPHNKPGIFO(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<IMBJFPFGGEG> KEAJHDKKBAE, int CNAIPFMACGM);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MIEEFIOIIBN<HIBILKABFFC> OGHDPNLJNMA(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, MIEEFIOIIBN<LKDNFLJFHHO> BBANEDNDONM, int CNAIPFMACGM);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int PEJNJBCNCNM(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? IPFCDPJHFNK(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, int HAJICDLBEKC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int CPCKBLNHKEC(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? FLAEIGIAEBD(TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE, int HAJICDLBEKC);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BGBONLLJPHC
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC360", Offset = "0x2BEB760", VA = "0x182BEC360")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH?> EBLOCODCEIN<T, TOpInput, TOpOutput>(this NDKKNACFGPO MCPMOAEEEOJ, T JKMLNPBBJIG, T JDJGFJGMEAK, int IJLPFLHMIBP, IntPtr ACIGGFPDBDE)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2BEBFC0", Offset = "0x2BEB3C0", VA = "0x182BEBFC0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH?> DOIEIEBOCCD<T, TOpInput, TOpOutput>(this NDKKNACFGPO MCPMOAEEEOJ, T JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK, int IJLPFLHMIBP, IntPtr ACIGGFPDBDE)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC890", Offset = "0x2BEBC90", VA = "0x182BEC890")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH?> FEFPBPOJDHJ<TOpInput, TOpOutput>(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK, int IJLPFLHMIBP, IntPtr ACIGGFPDBDE)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2236230", Offset = "0x2235630", VA = "0x182236230")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> NNHJKDAHIPF(this NDKKNACFGPO MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2231C30", Offset = "0x2231030", VA = "0x182231C30")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> BABDGEDCOGB(this NDKKNACFGPO MCPMOAEEEOJ, float HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2236560", Offset = "0x2235960", VA = "0x182236560")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> OINPIBBEFBE(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2232F20", Offset = "0x2232320", VA = "0x182232F20")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> DKNIAEFFCAJ(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2232E00", Offset = "0x2232200", VA = "0x182232E00")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> DKCGONMHKCN(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x22349D0", Offset = "0x2233DD0", VA = "0x1822349D0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> KBHPGGFDDAK(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2233770", Offset = "0x2232B70", VA = "0x182233770")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> GCFNEEIHDNF(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x22319F0", Offset = "0x2230DF0", VA = "0x1822319F0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> AONEDCLMLJM(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2233E20", Offset = "0x2233220", VA = "0x182233E20")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HCCDKJCOHMH(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2235400", Offset = "0x2234800", VA = "0x182235400")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> KNHKOGEFBIH(this NDKKNACFGPO MCPMOAEEEOJ, int JKMLNPBBJIG, int JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2231B10", Offset = "0x2230F10", VA = "0x182231B10")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> APAJHOJEIMA(this NDKKNACFGPO MCPMOAEEEOJ, int JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2234080", Offset = "0x2233480", VA = "0x182234080")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HMCFCPMDCML(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2233420", Offset = "0x2232820", VA = "0x182233420")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EJCCBAAOBAF(this NDKKNACFGPO MCPMOAEEEOJ, float JKMLNPBBJIG, float JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2233520", Offset = "0x2232920", VA = "0x182233520")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> FANKHOLPFAB(this NDKKNACFGPO MCPMOAEEEOJ, float JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x22344B0", Offset = "0x22338B0", VA = "0x1822344B0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JEPGKNGNGKO(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2236330", Offset = "0x2235730", VA = "0x182236330")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> OBCICPBODAH(this NDKKNACFGPO MCPMOAEEEOJ, int JKMLNPBBJIG, int JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2235B40", Offset = "0x2234F40", VA = "0x182235B40")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> MBBHHPNHDFI(this NDKKNACFGPO MCPMOAEEEOJ, int JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2234C30", Offset = "0x2234030", VA = "0x182234C30")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> KFMADPPKDOI(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2231970", Offset = "0x2230D70", VA = "0x182231970")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> ANGDNKGBDNP(this NDKKNACFGPO MCPMOAEEEOJ, float JKMLNPBBJIG, float JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2236720", Offset = "0x2235B20", VA = "0x182236720")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> PGCPNPKJLFJ(this NDKKNACFGPO MCPMOAEEEOJ, float JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2232340", Offset = "0x2231740", VA = "0x182232340")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> CGIJBJLCJEC(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2233980", Offset = "0x2232D80", VA = "0x182233980")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> GHHGJPBDOHM(this NDKKNACFGPO MCPMOAEEEOJ, int JKMLNPBBJIG, int JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2231E50", Offset = "0x2231250", VA = "0x182231E50")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> BJNGLCCHELE(this NDKKNACFGPO MCPMOAEEEOJ, int JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2235940", Offset = "0x2234D40", VA = "0x182235940")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> LGBANDMOINO(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2233C60", Offset = "0x2233060", VA = "0x182233C60")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> GPMBDCNNHAF(this NDKKNACFGPO MCPMOAEEEOJ, float JKMLNPBBJIG, float JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x22366A0", Offset = "0x2235AA0", VA = "0x1822366A0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> OLIKMIEKIJF(this NDKKNACFGPO MCPMOAEEEOJ, float JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2233650", Offset = "0x2232A50", VA = "0x182233650")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> FKEOFEHPDPF(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x22363B0", Offset = "0x22357B0", VA = "0x1822363B0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> OELNJCDODNB(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2235BC0", Offset = "0x2234FC0", VA = "0x182235BC0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> MDBMKGNELLJ(this NDKKNACFGPO MCPMOAEEEOJ, int EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2232080", Offset = "0x2231480", VA = "0x182232080")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> BNHIENMOAID(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2231ED0", Offset = "0x22312D0", VA = "0x182231ED0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> BMLPEMKNNDC(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> OLHIKIOJPGD)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x22345F0", Offset = "0x22339F0", VA = "0x1822345F0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> JFOCHMMHMLP(this NDKKNACFGPO MCPMOAEEEOJ, int EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x22336D0", Offset = "0x2232AD0", VA = "0x1822336D0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> FPNKKCMAKFE(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2235CE0", Offset = "0x22350E0", VA = "0x182235CE0")]
	public static (MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>) MKGGHNJCKKC(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<APDAHEMLLEN> DBAJNLPDJDO, [In] ReadOnlySpan<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> AECHHEDDKNJ, [In] ReadOnlySpan<int?> APIIIDELDBC, [In] Span<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> LLEIGHKFKMM)
	{
		return default((MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2232620", Offset = "0x2231A20", VA = "0x182232620")]
	public static (MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>) CLBCHIBMEEO(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DILABIFDKAP> PIGJIHDPIHB, [In] ReadOnlySpan<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> AECHHEDDKNJ, [In] ReadOnlySpan<int?> APIIIDELDBC, [In] Span<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> LLEIGHKFKMM)
	{
		return default((MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2BEBEC0", Offset = "0x2BEB2C0", VA = "0x182BEBEC0")]
	public static (MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<AEMFFDNPCNP>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<TMarker>>, MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>) BDFOAOEBKIA<TMarker>(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<AEMFFDNPCNP> PIEAKHJHCIG, [In] ReadOnlySpan<byte> AIKOCCMKKAE)
	{
		return default((MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<FLIDLELCAJJ<AEMFFDNPCNP>>, MIEEFIOIIBN<FLIDLELCAJJ<GKANNGPKLLI>>, MIEEFIOIIBN<FLIDLELCAJJ<TMarker>>, MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2233360", Offset = "0x2232760", VA = "0x182233360")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EEKPGGLPINE(this NDKKNACFGPO MCPMOAEEEOJ, int AEMACDNHKLC, [Optional] MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>? KNKLOPPILKI)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2234ED0", Offset = "0x22342D0", VA = "0x182234ED0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> KKJKBJJIKMA(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> AEMACDNHKLC, [Optional] MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>? KNKLOPPILKI)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2235720", Offset = "0x2234B20", VA = "0x182235720")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> LEMAMLJAMKM(this NDKKNACFGPO MCPMOAEEEOJ, [In] ReadOnlySpan<byte> AEMACDNHKLC, [Optional] MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>? KNKLOPPILKI)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2232BA0", Offset = "0x2231FA0", VA = "0x182232BA0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> DCPAFFBPDNN(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> AEMACDNHKLC, int IKJKAFPPDBP, [Optional] MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>? KNKLOPPILKI)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2233020", Offset = "0x2232420", VA = "0x182233020")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> DOLJJLCIAMB(this NDKKNACFGPO MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x22323C0", Offset = "0x22317C0", VA = "0x1822323C0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> CIGJHIBJPHG(this NDKKNACFGPO MCPMOAEEEOJ, float HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2234FC0", Offset = "0x22343C0", VA = "0x182234FC0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> KKPEBCADLGC(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2236120", Offset = "0x2235520", VA = "0x182236120")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> MLGNFIIOJKE(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2232120", Offset = "0x2231520", VA = "0x182232120")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> BOIOEIPAHKD(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2233220", Offset = "0x2232620", VA = "0x182233220")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EDOHEFKKMDA(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x22359C0", Offset = "0x2234DC0", VA = "0x1822359C0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> LIMHOBONDEG(this NDKKNACFGPO MCPMOAEEEOJ, int JKMLNPBBJIG, int JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x22341C0", Offset = "0x22335C0", VA = "0x1822341C0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IMENJLEGMOJ(this NDKKNACFGPO MCPMOAEEEOJ, int JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2235C40", Offset = "0x2235040", VA = "0x182235C40")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> MDIBEJCOFKD(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JKMLNPBBJIG, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JDJGFJGMEAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x22367A0", Offset = "0x2235BA0", VA = "0x1822367A0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> PIPPLIGPDEO(this NDKKNACFGPO MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2234380", Offset = "0x2233780", VA = "0x182234380")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JENEFFIJNKE(this NDKKNACFGPO MCPMOAEEEOJ, float HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x22324E0", Offset = "0x22318E0", VA = "0x1822324E0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> CJFCDMBAHHG(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2234CB0", Offset = "0x22340B0", VA = "0x182234CB0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> KGKMNDOHNGC(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2234670", Offset = "0x2233A70", VA = "0x182234670")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JGBBBLFCFIC(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2233CE0", Offset = "0x22330E0", VA = "0x182233CE0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HBBDENBEENB(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2235CC0", Offset = "0x22350C0", VA = "0x182235CC0")]
	public static MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>> MGFMIGEHNLA(this NDKKNACFGPO MCPMOAEEEOJ)
	{
		return default(MIEEFIOIIBN<FLIDLELCAJJ<FLIDLELCAJJ<LOIEPIHKKBL>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2232240", Offset = "0x2231640", VA = "0x182232240")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> CAAICFNAANL(this NDKKNACFGPO MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2233A00", Offset = "0x2232E00", VA = "0x182233A00")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> GLLGINFOBNA(this NDKKNACFGPO MCPMOAEEEOJ, float HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2234790", Offset = "0x2233B90", VA = "0x182234790")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JGEGPNCDIIG(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2233120", Offset = "0x2232520", VA = "0x182233120")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EBKIFADFALI(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2233F60", Offset = "0x2233360", VA = "0x182233F60")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HCPLOJIHAAH(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2232CC0", Offset = "0x22320C0", VA = "0x182232CC0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> DFIMPGGMLCN(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2235A40", Offset = "0x2234E40", VA = "0x182235A40")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> LPGHOGNPCAF(this NDKKNACFGPO MCPMOAEEEOJ, int EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2233870", Offset = "0x2232C70", VA = "0x182233870")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> GFNCNKEKEHL(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> EEPLCHCGAIN)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2236220", Offset = "0x2235620", VA = "0x182236220")]
	public static void NDGCAHDAMIK(this NDKKNACFGPO MCPMOAEEEOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2231D50", Offset = "0x2231150", VA = "0x182231D50")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> BHAKDAOPLAH(this NDKKNACFGPO MCPMOAEEEOJ, float HIPFNFECPMD, float IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2235500", Offset = "0x2234900", VA = "0x182235500")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> LAELBKNEMHD(this NDKKNACFGPO MCPMOAEEEOJ, float HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2233B20", Offset = "0x2232F20", VA = "0x182233B20")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> GMLEGIKIANA(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2235620", Offset = "0x2234A20", VA = "0x182235620")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> LBBGNBKDPEP(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2234DB0", Offset = "0x22341B0", VA = "0x182234DB0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> KICOIDFANID(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2234240", Offset = "0x2233640", VA = "0x182234240")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IOHLIEKDPJD(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x22368A0", Offset = "0x2235CA0", VA = "0x1822368A0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> PMBEIBAOGKD(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> PHOGGLIAJAG, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> CCLAIKJFLAK)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x22348D0", Offset = "0x2233CD0", VA = "0x1822348D0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JNBLIDDIFJI(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, int IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2234B10", Offset = "0x2233F10", VA = "0x182234B10")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> KCFGAAEOODJ(this NDKKNACFGPO MCPMOAEEEOJ, int HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2232A60", Offset = "0x2231E60", VA = "0x182232A60")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> CLCGBPLBIAM(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> HIPFNFECPMD, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IFNNNCDKMOA)
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2BEE5F0", Offset = "0x2BED9F0", VA = "0x182BEE5F0")]
	public static void PPECAAIFJAC<TDeps, TState>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TState NMAIGNOENJN, MIEEFIOIIBN<APDAHEMLLEN> DBAJNLPDJDO, [In] ReadOnlySpan<MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>> BJMADEJAPNF, [In] ReadOnlySpan<int?> APIIIDELDBC, [In] Span<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> LLEIGHKFKMM, [In] Span<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> LCMILNHNPIM, [In] ReadOnlySpan<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>?> AIHMCEHOEPE) where TDeps : notnull, OMLLDHLPPHN<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2BECC10", Offset = "0x2BEC010", VA = "0x182BECC10")]
	public static void GHPLLIKIJIH<TDeps, TState>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TState NMAIGNOENJN, MIEEFIOIIBN<DILABIFDKAP> KNNCNNMDAMC, [In] ReadOnlySpan<MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>> GEFNAEGGOMA, [In] ReadOnlySpan<int?> APIIIDELDBC, [In] Span<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> LLEIGHKFKMM, [In] Span<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>> LCMILNHNPIM, [In] ReadOnlySpan<MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>?> AIHMCEHOEPE) where TDeps : notnull, OMLLDHLPPHN<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2BED1B0", Offset = "0x2BEC5B0", VA = "0x182BED1B0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> IDMPFKELKIB<TDeps, TState>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TState NMAIGNOENJN, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> JHBDLCOPMCF, [Optional] MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>? KNKLOPPILKI) where TDeps : notnull, OMLLDHLPPHN<TState> where TState : notnull
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2BED390", Offset = "0x2BEC790", VA = "0x182BED390")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> LJANJNKKNOE<TDeps, TState>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TState NMAIGNOENJN, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> HPKPMFPJGPP, [Optional] MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>? KNKLOPPILKI) where TDeps : notnull, OMLLDHLPPHN<TState> where TState : notnull
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2BEC660", Offset = "0x2BEBA60", VA = "0x182BEC660")]
	public static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> EDPLGNBJLIH<TDeps, TStateSys>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TStateSys NCIHMAFAKAP) where TDeps : notnull, OMLLDHLPPHN<TStateSys> where TStateSys : notnull
	{
		return default(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2BECA00", Offset = "0x2BEBE00", VA = "0x182BECA00")]
	public static MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG> GFCLLGMNNME<TDeps, TStateSys>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TStateSys NCIHMAFAKAP) where TDeps : notnull, OMLLDHLPPHN<TStateSys> where TStateSys : notnull
	{
		return default(MIEEFIOIIBN<JJPMIKLDFBC.AMHGPDMJOMG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2235810", Offset = "0x2234C10", VA = "0x182235810")]
	public static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> LEMMIFDNPEN(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> HLGOKOKGAIL, IntPtr MMGDLJPDJNF, IntPtr GBNDEBLLHNN)
	{
		return default(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2235100", Offset = "0x2234500", VA = "0x182235100")]
	public static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> KNGIGBCPABC(this NDKKNACFGPO MCPMOAEEEOJ, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> DLIAFJCOEGA, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> GGKCAFLCIJG, IntPtr GNAJNDIEHCD, IntPtr EPCHJNONAJL, IntPtr BHLKBGCNIIG, bool IEDLPECGJJN)
	{
		return default(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDBA0", Offset = "0x2BECFA0", VA = "0x182BEDBA0")]
	public static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> NMIJLFEAPHK<TDeps, TState>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TState NMAIGNOENJN, MIEEFIOIIBN<APDAHEMLLEN> CAOCGPCEJFM, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> DLIAFJCOEGA, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> GGKCAFLCIJG, int? OEMKINNKCNO, [Optional] IntPtr LHDKHMJLCPK) where TDeps : notnull, OMLLDHLPPHN<TState> where TState : notnull
	{
		return default(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDDB0", Offset = "0x2BED1B0", VA = "0x182BEDDB0")]
	private static MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> NMIJLFEAPHK<TDeps, TState>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TState NMAIGNOENJN, MIEEFIOIIBN<APDAHEMLLEN> CAOCGPCEJFM, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> DLIAFJCOEGA, MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE> GGKCAFLCIJG, int? OEMKINNKCNO) where TDeps : notnull, OMLLDHLPPHN<TState> where TState : notnull
	{
		return default(MIEEFIOIIBN<GLIOLJFACDH.LGOMPCLKODE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2BED7F0", Offset = "0x2BECBF0", VA = "0x182BED7F0")]
	public static MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> MDIGOHDMKKF<TDeps, TState>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TState NMAIGNOENJN, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH> AEMACDNHKLC, MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>? KNKLOPPILKI) where TDeps : notnull, OMLLDHLPPHN<TState> where TState : notnull
	{
		return default(MIEEFIOIIBN<DIKLJDHDIIF.FDPBIJCDBKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2BEBC30", Offset = "0x2BEB030", VA = "0x182BEBC30")]
	public static void ABHCEPKIBDC<TDeps, TState>(this NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TState NMAIGNOENJN, int OCFBNPJOJGF) where TDeps : notnull, OMLLDHLPPHN<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct KHNDMKJOJLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> CNHKHPGJBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> JFCFGONPAMD;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
	public KHNDMKJOJLF(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> ONDGINOKHHD, MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> PNNELMIKLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2238580", Offset = "0x2237980", VA = "0x182238580")]
	public static KHNDMKJOJLF AHLALEPNKFA(MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>> ONDGINOKHHD)
	{
		return default(KHNDMKJOJLF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct DIKLJDHDIIF
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class LPKHHLPCCOI : FHFINCFBAJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct KPBNJMIGJFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG> JCGIDNGFHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int KMIIBMECGKI;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
		public KPBNJMIGJFK(MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG> GJEHHAMDKCJ, int HAJICDLBEKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class FNEAPDILAFI : FHFINCFBAJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct NJDAPDEJBFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int KMIIBMECGKI;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
		public NJDAPDEJBFM(int HAJICDLBEKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class GLCNMFIKDAH : FHFINCFBAJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct KKNOKEKLPMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG> JCGIDNGFHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int KMIIBMECGKI;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE90", Offset = "0xA2A290", VA = "0x180A2AE90")]
		public KKNOKEKLPMN(MIEEFIOIIBN<EEGFLIINHGM.KBHJPOPKJAG> GJEHHAMDKCJ, int HAJICDLBEKC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum JPOAMOJIIDC
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
	public sealed class FDPBIJCDBKH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class FHFINCFBAJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct BOGOCFEMBLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? AOLKAPKIAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public KHNDMKJOJLF FOBKBEJMAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public JPOAMOJIIDC DLEKHPMLGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public MIEEFIOIIBN<FHFINCFBAJB> IPCDEIJPOCO;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2236C20", Offset = "0x2236020", VA = "0x182236C20")]
		public BOGOCFEMBLP(int? PAEEAFEAEAD, [In] KHNDMKJOJLF CIKAEOMNEDA, JPOAMOJIIDC AJHEBLENGLF, MIEEFIOIIBN<FHFINCFBAJB> OBAFEDFLKJP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class ANDELBPMOGM : FHFINCFBAJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct DJKDPEEIEID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int KMIIBMECGKI;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xC15E20", Offset = "0xC15220", VA = "0x180C15E20")]
		public DJKDPEEIEID(int HAJICDLBEKC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal CAAPFMCNPEG<FDPBIJCDBKH, BOGOCFEMBLP> LFJOEILMCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal CAAPFMCNPEG<LPKHHLPCCOI, KPBNJMIGJFK> PNFECJJKKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal CAAPFMCNPEG<GLCNMFIKDAH, KKNOKEKLPMN> JFAKFIAEJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal CAAPFMCNPEG<ANDELBPMOGM, DJKDPEEIEID> OHLDFOAFHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal CAAPFMCNPEG<FNEAPDILAFI, NJDAPDEJBFM> LPLAAEFGNIP;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2236F30", Offset = "0x2236330", VA = "0x182236F30")]
	private DIKLJDHDIIF([In] CAAPFMCNPEG<FDPBIJCDBKH, BOGOCFEMBLP> FIOIDGFGFOO, [In] CAAPFMCNPEG<LPKHHLPCCOI, KPBNJMIGJFK> DHJDFGFNCGP, [In] CAAPFMCNPEG<GLCNMFIKDAH, KKNOKEKLPMN> LFFLMGOOMCL, [In] CAAPFMCNPEG<ANDELBPMOGM, DJKDPEEIEID> ABHOLIPFHFG, [In] CAAPFMCNPEG<FNEAPDILAFI, NJDAPDEJBFM> CLBEAPBHFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2236D40", Offset = "0x2236140", VA = "0x182236D40")]
	public static DIKLJDHDIIF AHLALEPNKFA()
	{
		return default(DIKLJDHDIIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class ELOIDDDOEGI
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x22373D0", Offset = "0x22367D0", VA = "0x1822373D0")]
	public static void KJDEEDGEPIJ(this DIKLJDHDIIF MCPMOAEEEOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class LHCOJMLBAJI
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2238810", Offset = "0x2237C10", VA = "0x182238810")]
	public static void EPAPKGBPEKK(NDKKNACFGPO MCPMOAEEEOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct HMCHJJGLLNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, CJCDLPDCMIG> DIHBLMNPDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int PCCDAIHMIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int BGOKOBMIAMN;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2237FC0", Offset = "0x22373C0", VA = "0x182237FC0")]
	private HMCHJJGLLNF([In] DGOPJPCIBPB<EEGFLIINHGM.IMEEPANNABA, CJCDLPDCMIG> EADJDLEFMIH, int OANOMEDKKIB, int PMIDJJDNJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2237D60", Offset = "0x2237160", VA = "0x182237D60")]
	public static HMCHJJGLLNF AHLALEPNKFA()
	{
		return default(HMCHJJGLLNF);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2237DD0", Offset = "0x22371D0", VA = "0x182237DD0")]
	public void KJDEEDGEPIJ([In] NDKKNACFGPO GMBKOAJKCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2E75D60", Offset = "0x2E75160", VA = "0x182E75D60")]
	public static void EPAPKGBPEKK<TDeps, TStateSys>(NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TStateSys NCIHMAFAKAP, MIEEFIOIIBN<ABNDNCLMDPA> HANIKMKPJIE) where TDeps : notnull, OMLLDHLPPHN<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PKPNFKOLOLD
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x223C270", Offset = "0x223B670", VA = "0x18223C270")]
	public static void EPAPKGBPEKK(NDKKNACFGPO MCPMOAEEEOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct MJLEJLMJJIG
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface NFKLJDKAJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MIJEHPFKMPH(OCJDOODMLMI<byte> KGIGJMCJCJD, int MCKOEFCEDDC);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct IPNCPDBHNLN : NFKLJDKAJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x22382D0", Offset = "0x22376D0", VA = "0x1822382D0", Slot = "4")]
		public void MIJEHPFKMPH(OCJDOODMLMI<byte> KGIGJMCJCJD, int MCKOEFCEDDC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct ICLJKOGLNDA : NFKLJDKAJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2238010", Offset = "0x2237410", VA = "0x182238010", Slot = "4")]
		public void MIJEHPFKMPH(OCJDOODMLMI<byte> KGIGJMCJCJD, int MCKOEFCEDDC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct FEHKMFMLAGB : NFKLJDKAJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x22378C0", Offset = "0x2236CC0", VA = "0x1822378C0", Slot = "4")]
		public void MIJEHPFKMPH(OCJDOODMLMI<byte> KGIGJMCJCJD, int MCKOEFCEDDC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct NODOAMBCIHA : NFKLJDKAJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x223C050", Offset = "0x223B450", VA = "0x18223C050", Slot = "4")]
		public void MIJEHPFKMPH(OCJDOODMLMI<byte> KGIGJMCJCJD, int MCKOEFCEDDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class DICJBAEIHGB<TCallProcessorDeps> where TCallProcessorDeps : struct, NFKLJDKAJCI
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps DBHDOFFCGAC;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2D7EE50", Offset = "0x2D7E250", VA = "0x182D7EE50")]
		public static int EPAPKGBPEKK<TDeps, TStateSys>(TDeps CLOGBAKPPIL, TStateSys NMAIGNOENJN, NDKKNACFGPO GMBKOAJKCLF, [In] OCJDOODMLMI<byte> EGAGMJPDKCA, int OEEKMEPGGIJ) where TDeps : OMLLDHLPPHN<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private OCJDOODMLMI<LBOHAAEMDDL> KBIPKLGMGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>> LDPHAMPPDON;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2238A70", Offset = "0x2237E70", VA = "0x182238A70")]
	private MJLEJLMJJIG([In] OCJDOODMLMI<LBOHAAEMDDL> PKNDFLFELNK, Dictionary<MIEEFIOIIBN<FLIDLELCAJJ<LOIEPIHKKBL>>, MIEEFIOIIBN<EEGFLIINHGM.IMEEPANNABA>> OPKBHPMBEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2238970", Offset = "0x2237D70", VA = "0x182238970")]
	public static MJLEJLMJJIG AHLALEPNKFA()
	{
		return default(MJLEJLMJJIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2238A30", Offset = "0x2237E30", VA = "0x182238A30")]
	public void KJDEEDGEPIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2F37320", Offset = "0x2F36720", VA = "0x182F37320")]
	public static void EPAPKGBPEKK<TDeps, TStateSys>(NDKKNACFGPO MCPMOAEEEOJ, TDeps CLOGBAKPPIL, TStateSys NCIHMAFAKAP) where TDeps : OMLLDHLPPHN<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class LBJAPMGPGPP<TDeps, TIndex, TValues> where TDeps : struct, JIPMPMDPDOK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps DBHDOFFCGAC;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x458B2A0", Offset = "0x458A6A0", VA = "0x18458B2A0")]
	public static void EPAPKGBPEKK([In] OCJDOODMLMI<LBOHAAEMDDL> PKNDFLFELNK, int ELHBDDPPEAK, TValues BFAMJIIMLEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface JIPMPMDPDOK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OCJDOODMLMI<TIndex> BFOAICGCOBB(int ELHBDDPPEAK, [In] TValues BFAMJIIMLEB);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(TIndex HAJICDLBEKC, [In] TValues BFAMJIIMLEB);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJOOCHCFAKL(TIndex HAJICDLBEKC, TValues BFAMJIIMLEB, MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> EEPLCHCGAIN);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface BIBJIIFFIIF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex FIAFJNJLCAG(int HAJICDLBEKC);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KHNIDMLPLNH(TIndex HAJICDLBEKC, [In] TValues BFAMJIIMLEB);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MIEEFIOIIBN<FLIDLELCAJJ<LCMAICEDDBI>> ANDHJFFLFNC(TIndex HAJICDLBEKC, [In] TValues BFAMJIIMLEB);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class FCKNPADOPDE<TDeps, TIndex, TValues> where TDeps : struct, BIBJIIFFIIF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps DBHDOFFCGAC;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3F31A40", Offset = "0x3F30E40", VA = "0x183F31A40")]
	public static OCJDOODMLMI<TIndex> EPAPKGBPEKK(int ELHBDDPPEAK, [In] TValues BFAMJIIMLEB)
	{
		return default(OCJDOODMLMI<TIndex>);
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
