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
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1E52E10", Offset = "0x1E51E10", VA = "0x181E52E10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct MGCOFMLKDHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> DEMOBIGOMKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int KDFBEAEDFDN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAE6AB0", Offset = "0xAE5AB0", VA = "0x180AE6AB0")]
	public MGCOFMLKDHJ(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> EDLCCHGJONF, int NGKDOMEFDDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct NGJHBCLMNLC
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class JJKJIMPGAPH : OLDBGNIJJMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct PNDFCIFDHKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly HAOCLPALDAM<byte> FMOACKBLLEK;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C700", Offset = "0x1E0B700", VA = "0x181E0C700")]
		public PNDFCIFDHKC(HAOCLPALDAM<byte> MFPMCBPILCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E53190", Offset = "0x1E52190", VA = "0x181E53190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class HLIPKMLOEMB : OLDBGNIJJMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct CEOFCIJHHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> FIJHPCFODMO;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
		public CEOFCIJHHMF(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> KLPHMBEKDIB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum EMODHMKNNPC
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
	public sealed class LKKPLEPAHMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class OLDBGNIJJMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct CDIFGNJHDLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly EMODHMKNNPC KLHMKNHHPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly JLADLGKIDDG<OLDBGNIJJMN> CIMNIPCLENO;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AB0", Offset = "0xAE5AB0", VA = "0x180AE6AB0")]
		public CDIFGNJHDLA(EMODHMKNNPC COHEFBNLIFM, JLADLGKIDDG<OLDBGNIJJMN> FDFGNHCNMEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class AOGPBOAAMDO : OLDBGNIJJMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct DFECPPHLJDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> EKBCFDDFDEB;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
		public DFECPPHLJDB(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> BJANPDFODGF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class AOIEOFODIGN : OLDBGNIJJMN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct EHPPMHJGMFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly KHKHDENPCDD KEMNIENEFMC;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
		public EHPPMHJGMFG(KHKHDENPCDD CJKDIOENDKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1E50070", Offset = "0x1E4F070", VA = "0x181E50070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal NALEIHKMBDE<LKKPLEPAHMB, CDIFGNJHDLA> LEFHLLCPGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal NALEIHKMBDE<JJKJIMPGAPH, PNDFCIFDHKC> LCBMMMAKIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal NALEIHKMBDE<HLIPKMLOEMB, CEOFCIJHHMF> CHAHDLBBPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal NALEIHKMBDE<AOGPBOAAMDO, DFECPPHLJDB> NMGAALOFHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal NALEIHKMBDE<AOIEOFODIGN, EHPPMHJGMFG> BMPDKJEIGJO;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E52D60", Offset = "0x1E51D60", VA = "0x181E52D60")]
	private NGJHBCLMNLC([In] NALEIHKMBDE<LKKPLEPAHMB, CDIFGNJHDLA> LKHDFNFMHEL, [In] NALEIHKMBDE<JJKJIMPGAPH, PNDFCIFDHKC> NOLIPALBFLB, [In] NALEIHKMBDE<HLIPKMLOEMB, CEOFCIJHHMF> NLPKJNMOBNC, [In] NALEIHKMBDE<AOGPBOAAMDO, DFECPPHLJDB> ADLNOCDJLMK, [In] NALEIHKMBDE<AOIEOFODIGN, EHPPMHJGMFG> AGGPHGCKCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E52C20", Offset = "0x1E51C20", VA = "0x181E52C20")]
	public static NGJHBCLMNLC MGIIAIMPALM()
	{
		return default(NGJHBCLMNLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KMBHPBJAJIF
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E522B0", Offset = "0x1E512B0", VA = "0x181E522B0")]
	public static void FAAFJENLCBJ(this NGJHBCLMNLC HFLBADIEKAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum EKGILMNEGCA
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
public struct LDPDMAMMEJB
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class KNINNCMMIPD : HLKKBHHODMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct LIMKDDOGABM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> OLGJAPGDCOO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
		public LIMKDDOGABM(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> OGOPIFDKNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum DPJCDLPPNJJ
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
	public sealed class LDOCPGCFIOH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class HLKKBHHODMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct BFNCKHBNNHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly DPJCDLPPNJJ KLHMKNHHPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly JLADLGKIDDG<HLKKBHHODMA> CIMNIPCLENO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AB0", Offset = "0xAE5AB0", VA = "0x180AE6AB0")]
		public BFNCKHBNNHH(DPJCDLPPNJJ COHEFBNLIFM, JLADLGKIDDG<HLKKBHHODMA> FDFGNHCNMEL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal NALEIHKMBDE<LDOCPGCFIOH, BFNCKHBNNHH> LEFHLLCPGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal NALEIHKMBDE<KNINNCMMIPD, LIMKDDOGABM> MIAHOEFJAAB;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E50E30", Offset = "0x1E4FE30", VA = "0x181E50E30")]
	private LDPDMAMMEJB([In] NALEIHKMBDE<LDOCPGCFIOH, BFNCKHBNNHH> LKHDFNFMHEL, [In] NALEIHKMBDE<KNINNCMMIPD, LIMKDDOGABM> KOJIMEOODHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E524E0", Offset = "0x1E514E0", VA = "0x181E524E0")]
	public static LDPDMAMMEJB MGIIAIMPALM()
	{
		return default(LDPDMAMMEJB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class ALPGFGKGONI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A8B0", Offset = "0x1E498B0", VA = "0x181E4A8B0")]
	public static void FAAFJENLCBJ(this LDPDMAMMEJB HFLBADIEKAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FOKKBEBKMDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public EJCNFOOPALK<int> CGFJCPBJJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public EJCNFOOPALK<int> BJMNMNKGJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int PEPFDDPFLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int MFPCGJBLFHM;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E50340", Offset = "0x1E4F340", VA = "0x181E50340")]
	private FOKKBEBKMDA([In] EJCNFOOPALK<int> EEGDLDLHPED, [In] EJCNFOOPALK<int> DOHEOFEADDM, int IPEFMNHFALD, int FAELJIAPNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E502A0", Offset = "0x1E4F2A0", VA = "0x181E502A0")]
	public static FOKKBEBKMDA MGIIAIMPALM()
	{
		return default(FOKKBEBKMDA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class CBJANFBCEFO
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A910", Offset = "0x1E49910", VA = "0x181E4A910")]
	public static void FAAFJENLCBJ(this FOKKBEBKMDA HFLBADIEKAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct GPIJKLCGPHF
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum DACJHHHHBMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class PFIKHNOAOJK : HAPBJDKHLFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct MONIALJKPFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly JLADLGKIDDG<GIFEMCNMJDN> DBAMDKDMGOM;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
		public MONIALJKPFH(JLADLGKIDDG<GIFEMCNMJDN> JPBCPAOBLLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class PIIBLGBKPAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class HAPBJDKHLFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct KHLFHJJHKHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly DACJHHHHBMC KLHMKNHHPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly JLADLGKIDDG<HAPBJDKHLFC> CIMNIPCLENO;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AB0", Offset = "0xAE5AB0", VA = "0x180AE6AB0")]
		private KHLFHJJHKHN(DACJHHHHBMC COHEFBNLIFM, JLADLGKIDDG<HAPBJDKHLFC> FDFGNHCNMEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1E51030", Offset = "0x1E50030", VA = "0x181E51030")]
		public static KHLFHJJHKHN MGIIAIMPALM(DACJHHHHBMC COHEFBNLIFM, JLADLGKIDDG<HAPBJDKHLFC> FDFGNHCNMEL)
		{
			return default(KHLFHJJHKHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class PDPOKCCEPKJ : HAPBJDKHLFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct GGLJDHEIHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly JLADLGKIDDG<GIFEMCNMJDN> DBAMDKDMGOM;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
		public GGLJDHEIHNA(JLADLGKIDDG<GIFEMCNMJDN> JPBCPAOBLLC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class GIFEMCNMJDN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct JJPLIOPLOGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public EJCNFOOPALK<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> PAKNLANGINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public EJCNFOOPALK<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> KLDLNPLGKEI;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E50E30", Offset = "0x1E4FE30", VA = "0x181E50E30")]
		private JJPLIOPLOGG([In] EJCNFOOPALK<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> FJIONCIBEFF, [In] EJCNFOOPALK<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> DAKELNLGAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E50DB0", Offset = "0x1E4FDB0", VA = "0x181E50DB0")]
		public static JJPLIOPLOGG MGIIAIMPALM()
		{
			return default(JJPLIOPLOGG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal NALEIHKMBDE<PIIBLGBKPAF, KHLFHJJHKHN> LEFHLLCPGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal NALEIHKMBDE<PDPOKCCEPKJ, GGLJDHEIHNA> AOBIEGBAMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal NALEIHKMBDE<PFIKHNOAOJK, MONIALJKPFH> PIFNKDKOEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal EJCNFOOPALK<(JLADLGKIDDG<PIIBLGBKPAF> CallId, JLADLGKIDDG<GIFEMCNMJDN> IOId)> LLOAJFLFJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal NALEIHKMBDE<GIFEMCNMJDN, JJPLIOPLOGG> CNIPBBDIGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal LAFNIHFOMLK<GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>> PEOJNIBAKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal LAFNIHFOMLK<GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>> CMDEDGIEJEI;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E50C30", Offset = "0x1E4FC30", VA = "0x181E50C30")]
	private GPIJKLCGPHF([In] NALEIHKMBDE<PIIBLGBKPAF, KHLFHJJHKHN> LKHDFNFMHEL, [In] NALEIHKMBDE<PDPOKCCEPKJ, GGLJDHEIHNA> NICNADENBHF, [In] NALEIHKMBDE<PFIKHNOAOJK, MONIALJKPFH> IGENCJCMMOJ, [In] EJCNFOOPALK<(JLADLGKIDDG<PIIBLGBKPAF> CallId, JLADLGKIDDG<GIFEMCNMJDN> IOId)> NELODKMGIDB, [In] NALEIHKMBDE<GIFEMCNMJDN, JJPLIOPLOGG> JBJKIJECMHC, [In] LAFNIHFOMLK<GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>> HOKALDAKLHB, [In] LAFNIHFOMLK<GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>> NNDMBCJPFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E50A90", Offset = "0x1E4FA90", VA = "0x181E50A90")]
	public static GPIJKLCGPHF MGIIAIMPALM()
	{
		return default(GPIJKLCGPHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class OBPKDOPPKKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1E52E90", Offset = "0x1E51E90", VA = "0x181E52E90")]
	private static void FAAFJENLCBJ(this GPIJKLCGPHF.JJPLIOPLOGG HFLBADIEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1E52EE0", Offset = "0x1E51EE0", VA = "0x181E52EE0")]
	public static void FAAFJENLCBJ(this GPIJKLCGPHF HFLBADIEKAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct KILBPLDFBOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public EJCNFOOPALK<byte> GFFKLCGHHGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal GPIJKLCGPHF HABJNOLHPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal NEIFODCBPDH JBBCJLKAICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> BCCDEFNGNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal NGJHBCLMNLC EOPIEEENHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal LDPDMAMMEJB PKGAIHGGACH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal LAFNIHFOMLK<HIDODOLPGGA, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>?> JPBNLKDMGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal EJCNFOOPALK<JLADLGKIDDG<HIDODOLPGGA>> ONFBFNBFDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?> LOOEANPGODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> VariableId, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>> ByteCodeWriteLocation)> BCCJAHPAEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> GEMELHCPEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal KIGLHAKALJI IOJMBKEABAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal LGNLHKDPPCE JCEDKOBLPFL;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1E51D80", Offset = "0x1E50D80", VA = "0x181E51D80")]
	private KILBPLDFBOP([In] EJCNFOOPALK<byte> IONCLGMBDFJ, [In] GPIJKLCGPHF AMALEEFDJMA, [In] NEIFODCBPDH EIFIOGBGLEG, [In] NGJHBCLMNLC ILKGOFAGMPH, [In] LDPDMAMMEJB MEAKAJAANAB, [In] LAFNIHFOMLK<HIDODOLPGGA, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>?> HGHLJECCOPN, [In] EJCNFOOPALK<JLADLGKIDDG<HIDODOLPGGA>> DGHPJCGMDKI, [In] LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?> HPKGMDOGOBH, [In] EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> VariableId, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>> ByteCodeWriteLocation)> MFNDMHFOCKN, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> PHMFCCDPABE, [In] KIGLHAKALJI INIHICDIFLD, [In] LGNLHKDPPCE HAAJILDKBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1E512C0", Offset = "0x1E502C0", VA = "0x181E512C0")]
	public static KILBPLDFBOP MGIIAIMPALM()
	{
		return default(KILBPLDFBOP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class AHIGBCDNODJ
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct FAKOENILCKO : FCDDJPKIACF<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>, LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1E50090", Offset = "0x1E4F090", VA = "0x181E50090")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1E50110", Offset = "0x1E4F110", VA = "0x181E50110", Slot = "4")]
		public JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> PBDJECFDEGA(int GPEHCABDGEJ)
		{
			return default(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420")]
		public bool NFOCIBEDBBO(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "5")]
		private bool LGAMHPPLANL(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E50090", Offset = "0x1E4F090", VA = "0x181E50090", Slot = "6")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> KLJMMNBODIN(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct KOLHGBNNDFC : DLHBLINKPGL<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>, LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E52360", Offset = "0x1E51360", VA = "0x181E52360")]
		public EJCNFOOPALK<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>> IKHJPJKBBBG(int PGCGGEEIMNF, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1E523D0", Offset = "0x1E513D0", VA = "0x181E523D0")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E52450", Offset = "0x1E51450", VA = "0x181E52450", Slot = "6")]
		public void KKKGLFFLDOG(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>> AGKDCPLPFCM, JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> LDGMLLMKHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E52360", Offset = "0x1E51360", VA = "0x181E52360", Slot = "4")]
		private EJCNFOOPALK<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>> BGCBPFCDJLO(int PGCGGEEIMNF, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1E523D0", Offset = "0x1E513D0", VA = "0x181E523D0", Slot = "5")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> NEIBLECFKKB(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct GMHLCAJCFOJ : FCDDJPKIACF<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>, LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1E507F0", Offset = "0x1E4F7F0", VA = "0x181E507F0")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1E50870", Offset = "0x1E4F870", VA = "0x181E50870", Slot = "4")]
		public JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> PBDJECFDEGA(int GPEHCABDGEJ)
		{
			return default(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420")]
		public bool NFOCIBEDBBO(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "5")]
		private bool MCCEHLGNCLJ(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E507F0", Offset = "0x1E4F7F0", VA = "0x181E507F0", Slot = "6")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> BAOKIKLJAOB(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct KCJBGKKOHNH : DLHBLINKPGL<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>, LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1E50E70", Offset = "0x1E4FE70", VA = "0x181E50E70")]
		public EJCNFOOPALK<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>> IKHJPJKBBBG(int PGCGGEEIMNF, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1E50EE0", Offset = "0x1E4FEE0", VA = "0x181E50EE0")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1E50F60", Offset = "0x1E4FF60", VA = "0x181E50F60", Slot = "6")]
		public void KKKGLFFLDOG(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>> AGKDCPLPFCM, JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> LDGMLLMKHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1E50E70", Offset = "0x1E4FE70", VA = "0x181E50E70", Slot = "4")]
		private EJCNFOOPALK<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>> ONENBINKAOJ(int PGCGGEEIMNF, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1E50EE0", Offset = "0x1E4FEE0", VA = "0x181E50EE0", Slot = "5")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> PNLPCHAPOJA(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> GPEHCABDGEJ, [In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct NAPACICJBDE : FCDDJPKIACF<JLADLGKIDDG<OFKKFGCILME>, LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x1E52830", Offset = "0x1E51830", VA = "0x181E52830")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(JLADLGKIDDG<OFKKFGCILME> GPEHCABDGEJ, [In] LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1E528D0", Offset = "0x1E518D0", VA = "0x181E528D0", Slot = "4")]
		public JLADLGKIDDG<OFKKFGCILME> PBDJECFDEGA(int GPEHCABDGEJ)
		{
			return default(JLADLGKIDDG<OFKKFGCILME>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1E527D0", Offset = "0x1E517D0", VA = "0x181E527D0")]
		public bool NFOCIBEDBBO(JLADLGKIDDG<OFKKFGCILME> GPEHCABDGEJ, [In] LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1E527D0", Offset = "0x1E517D0", VA = "0x181E527D0", Slot = "5")]
		private bool IFNAJKEKPIO(JLADLGKIDDG<OFKKFGCILME> GPEHCABDGEJ, [In] LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1E527C0", Offset = "0x1E517C0", VA = "0x181E527C0", Slot = "6")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> APKEBNCBGBC(JLADLGKIDDG<OFKKFGCILME> GPEHCABDGEJ, [In] LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct KKODKKFAMMO : DLHBLINKPGL<JLADLGKIDDG<OFKKFGCILME>, LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1E520E0", Offset = "0x1E510E0", VA = "0x181E520E0")]
		public EJCNFOOPALK<JLADLGKIDDG<OFKKFGCILME>> IKHJPJKBBBG(int PGCGGEEIMNF, [In] LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<JLADLGKIDDG<OFKKFGCILME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1E52150", Offset = "0x1E51150", VA = "0x181E52150")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(JLADLGKIDDG<OFKKFGCILME> GPEHCABDGEJ, [In] LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1E521F0", Offset = "0x1E511F0", VA = "0x181E521F0", Slot = "6")]
		public void KKKGLFFLDOG(JLADLGKIDDG<OFKKFGCILME> GPEHCABDGEJ, LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?> AGKDCPLPFCM, JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> LDGMLLMKHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1E520E0", Offset = "0x1E510E0", VA = "0x181E520E0", Slot = "4")]
		private EJCNFOOPALK<JLADLGKIDDG<OFKKFGCILME>> IHAMILLPCEC(int PGCGGEEIMNF, [In] LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<JLADLGKIDDG<OFKKFGCILME>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1E522A0", Offset = "0x1E512A0", VA = "0x181E522A0", Slot = "5")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> NAHIGCOFPII(JLADLGKIDDG<OFKKFGCILME> GPEHCABDGEJ, [In] LAFNIHFOMLK<OFKKFGCILME, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>?> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct GBBOJAKEKJG : FCDDJPKIACF<int, EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1E503A0", Offset = "0x1E4F3A0", VA = "0x181E503A0")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> VariableId, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x11F7380", Offset = "0x11F6380", VA = "0x1811F7380", Slot = "4")]
		public int PBDJECFDEGA(int GPEHCABDGEJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420")]
		public bool NFOCIBEDBBO(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> VariableId, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "5")]
		private bool GAKCDJHEOBM(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> VariableId, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1E50420", Offset = "0x1E4F420", VA = "0x181E50420", Slot = "6")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> NNFBJONPLAO(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> VariableId, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct GOPIMMEDEDF : DLHBLINKPGL<int, EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1E508B0", Offset = "0x1E4F8B0", VA = "0x181E508B0")]
		public EJCNFOOPALK<int> IKHJPJKBBBG(int PGCGGEEIMNF, [In] EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> VariableId, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1E50920", Offset = "0x1E4F920", VA = "0x181E50920")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> VariableId, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1E509A0", Offset = "0x1E4F9A0", VA = "0x181E509A0", Slot = "6")]
		public void KKKGLFFLDOG(int GPEHCABDGEJ, EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> VariableId, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>> ByteCodeWriteLocation)> AGKDCPLPFCM, JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> LDGMLLMKHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1E508B0", Offset = "0x1E4F8B0", VA = "0x181E508B0", Slot = "4")]
		private EJCNFOOPALK<int> KCELHMEBEIO(int PGCGGEEIMNF, [In] EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> VariableId, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1E508A0", Offset = "0x1E4F8A0", VA = "0x181E508A0", Slot = "5")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> GLDPEPBBGOP(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> VariableId, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<MCDOBOMGEPK>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct DLLPKGKOPLC : FCDDJPKIACF<int, EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1E4FFF0", Offset = "0x1E4EFF0", VA = "0x181E4FFF0")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x11F7380", Offset = "0x11F6380", VA = "0x1811F7380", Slot = "4")]
		public int PBDJECFDEGA(int GPEHCABDGEJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420")]
		public bool NFOCIBEDBBO(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "5")]
		private bool OPCEONAHAAJ(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1E4FFF0", Offset = "0x1E4EFF0", VA = "0x181E4FFF0", Slot = "6")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> IMAHAICOPKD(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct GHFDNIJJLEC : DLHBLINKPGL<int, EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1E50430", Offset = "0x1E4F430", VA = "0x181E50430")]
		public EJCNFOOPALK<int> IKHJPJKBBBG(int PGCGGEEIMNF, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1E504A0", Offset = "0x1E4F4A0", VA = "0x181E504A0")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1E50520", Offset = "0x1E4F520", VA = "0x181E50520", Slot = "6")]
		public void KKKGLFFLDOG(int GPEHCABDGEJ, EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM, JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> LDGMLLMKHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1E50430", Offset = "0x1E4F430", VA = "0x181E50430", Slot = "4")]
		private EJCNFOOPALK<int> OCKAPLKEBDB(int PGCGGEEIMNF, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E504A0", Offset = "0x1E4F4A0", VA = "0x181E504A0", Slot = "5")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> PEEPJOCLGJG(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct MONPCLNJOLI : FCDDJPKIACF<int, EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1E52740", Offset = "0x1E51740", VA = "0x181E52740")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x11F7380", Offset = "0x11F6380", VA = "0x1811F7380", Slot = "4")]
		public int PBDJECFDEGA(int GPEHCABDGEJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420")]
		public bool NFOCIBEDBBO(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "5")]
		private bool OPCEONAHAAJ(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E52730", Offset = "0x1E51730", VA = "0x181E52730", Slot = "6")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> IMAHAICOPKD(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct GLJFANNHNKJ : DLHBLINKPGL<int, EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E50600", Offset = "0x1E4F600", VA = "0x181E50600")]
		public EJCNFOOPALK<int> IKHJPJKBBBG(int PGCGGEEIMNF, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1E50670", Offset = "0x1E4F670", VA = "0x181E50670")]
		public JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1E506F0", Offset = "0x1E4F6F0", VA = "0x181E506F0", Slot = "6")]
		public void KKKGLFFLDOG(int GPEHCABDGEJ, EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM, JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> LDGMLLMKHLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1E50600", Offset = "0x1E4F600", VA = "0x181E50600", Slot = "4")]
		private EJCNFOOPALK<int> OCKAPLKEBDB(int PGCGGEEIMNF, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(EJCNFOOPALK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1E507E0", Offset = "0x1E4F7E0", VA = "0x181E507E0", Slot = "5")]
		private JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> PEEPJOCLGJG(int GPEHCABDGEJ, [In] EJCNFOOPALK<(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> Target, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> ByteCodeWriteLocation)> AGKDCPLPFCM)
		{
			return default(JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct CFGHPOBJCNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> FNICNLGCBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool JANGCCMLFGK;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xEF7160", Offset = "0xEF6160", VA = "0x180EF7160")]
		public CFGHPOBJCNG(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME, bool CDFPCOCFOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A970", Offset = "0x1E49970", VA = "0x181E4A970")]
		public void KNBCCAGJFOM([Out] JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME, [Out] bool CDFPCOCFOFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct KDDGLCMKMPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly JLADLGKIDDG<OFKKFGCILME> BJKINNOFKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> FNICNLGCBDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool JANGCCMLFGK;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1E51020", Offset = "0x1E50020", VA = "0x181E51020")]
		public KDDGLCMKMPE(JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME, bool CDFPCOCFOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1E51010", Offset = "0x1E50010", VA = "0x181E51010")]
		public void KNBCCAGJFOM([Out] JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME, [Out] bool CDFPCOCFOFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1E50FF0", Offset = "0x1E4FFF0", VA = "0x181E50FF0")]
		public void KNBCCAGJFOM([Out] JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME, [Out] JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN, [Out] bool CDFPCOCFOFH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct JIAJOMOHLKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly JLADLGKIDDG<OFKKFGCILME> BJKINNOFKID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> FNICNLGCBDF;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AB0", Offset = "0xAE5AB0", VA = "0x180AE6AB0")]
		public JIAJOMOHLKO(JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1E50DA0", Offset = "0x1E4FDA0", VA = "0x181E50DA0")]
		public void KNBCCAGJFOM([Out] JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME, [Out] JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1E491A0", Offset = "0x1E481A0", VA = "0x181E491A0")]
	public static void FAAFJENLCBJ(this KILBPLDFBOP HFLBADIEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1E48F20", Offset = "0x1E47F20", VA = "0x181E48F20")]
	public static void DDPFNJECPLL(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<HIDODOLPGGA> IDIHOPKDBNN, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> CDMJLPNPGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1E488A0", Offset = "0x1E478A0", VA = "0x181E488A0")]
	public static void ANPNJGOAGOG(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<HIDODOLPGGA> IDIHOPKDBNN, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> CDMJLPNPGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1E48CE0", Offset = "0x1E47CE0", VA = "0x181E48CE0")]
	public static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>? CMIOLOCBNPD([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<HIDODOLPGGA> IDIHOPKDBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1E48B60", Offset = "0x1E47B60", VA = "0x181E48B60")]
	public static JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> CHCFAPLBNBO([In] this KILBPLDFBOP HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1E48740", Offset = "0x1E47740", VA = "0x181E48740")]
	private static void ALBLBEMEFGL(this KILBPLDFBOP HFLBADIEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1E49470", Offset = "0x1E48470", VA = "0x181E49470")]
	private static JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>? FDKMMMBIEHA([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A740", Offset = "0x1E49740", VA = "0x181E4A740")]
	public static void PPFFKIENDOM(this KILBPLDFBOP HFLBADIEKAM, [In] EJCNFOOPALK<MGCOFMLKDHJ> JBKENLNPDMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1E48E30", Offset = "0x1E47E30", VA = "0x181E48E30")]
	public static NGJHBCLMNLC.EMODHMKNNPC CPFCIFLGEDB([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME)
	{
		return default(NGJHBCLMNLC.EMODHMKNNPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1E49E30", Offset = "0x1E48E30", VA = "0x181E49E30")]
	public static HAOCLPALDAM<byte> NBBBDACBHOD([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME)
	{
		return default(HAOCLPALDAM<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1E498D0", Offset = "0x1E488D0", VA = "0x181E498D0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> JHCJBLNFDMH([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A470", Offset = "0x1E49470", VA = "0x181E4A470")]
	public static KHKHDENPCDD OPIPNPEPJCD([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME)
	{
		return default(KHKHDENPCDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2F15140", Offset = "0x2F14140", VA = "0x182F15140")]
	private static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> CLJGGCNNEFO<TMJoin>(this KILBPLDFBOP HFLBADIEKAM, NGJHBCLMNLC.EMODHMKNNPC COHEFBNLIFM, JLADLGKIDDG<TMJoin> FDFGNHCNMEL) where TMJoin : NGJHBCLMNLC.OLDBGNIJJMN
	{
		return default(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A130", Offset = "0x1E49130", VA = "0x181E4A130")]
	public static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> NMBFCICABJK(this KILBPLDFBOP HFLBADIEKAM, bool LPGLLHIDELL)
	{
		return default(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1E49110", Offset = "0x1E48110", VA = "0x181E49110")]
	public static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> EIODILPKEJH(this KILBPLDFBOP HFLBADIEKAM, HAOCLPALDAM<byte> MFPMCBPILCI)
	{
		return default(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1E49C90", Offset = "0x1E48C90", VA = "0x181E49C90")]
	public static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> MFJLGPHLDHC(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> KLPHMBEKDIB)
	{
		return default(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1E49D10", Offset = "0x1E48D10", VA = "0x181E49D10")]
	public static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> MOJEDFCFGEM(this KILBPLDFBOP HFLBADIEKAM, int OBDKDHBELDB)
	{
		return default(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1E48BC0", Offset = "0x1E47BC0", VA = "0x181E48BC0")]
	public static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> CIBPOPLKOKC(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> BJANPDFODGF)
	{
		return default(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2F16E70", Offset = "0x2F15E70", VA = "0x182F16E70")]
	private static JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH> PFLFJEIFAEE<TMJoin>(this KILBPLDFBOP HFLBADIEKAM, LDPDMAMMEJB.DPJCDLPPNJJ COHEFBNLIFM, JLADLGKIDDG<TMJoin> FDFGNHCNMEL) where TMJoin : LDPDMAMMEJB.HLKKBHHODMA
	{
		return default(JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1E49890", Offset = "0x1E48890", VA = "0x181E49890")]
	public static JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH> HLIIEBCBJMP(this KILBPLDFBOP HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1E49DF0", Offset = "0x1E48DF0", VA = "0x181E49DF0")]
	public static JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH> NAOOHECDJFL(this KILBPLDFBOP HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1E49540", Offset = "0x1E48540", VA = "0x181E49540")]
	public static JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH> FGLKBAGBDKN(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> OGOPIFDKNCN)
	{
		return default(JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1E49500", Offset = "0x1E48500", VA = "0x181E49500")]
	public static JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH> FFCHELLJEMM(this KILBPLDFBOP HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1E49850", Offset = "0x1E48850", VA = "0x181E49850")]
	public static JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH> HAPKADNIFGE(this KILBPLDFBOP HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A370", Offset = "0x1E49370", VA = "0x181E4A370")]
	public static GPIJKLCGPHF.DACJHHHHBMC ONDOOJJFBAA([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF> PLLGMJMBDKI)
	{
		return default(GPIJKLCGPHF.DACJHHHHBMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1E48700", Offset = "0x1E47700", VA = "0x181E48700")]
	public static FJDNLJOKGKJ<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>, PLJGLBAJNNF<GPIJKLCGPHF.GIFEMCNMJDN>> AHPIFJAOHPO([In] this KILBPLDFBOP HFLBADIEKAM)
	{
		return default(FJDNLJOKGKJ<JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>, PLJGLBAJNNF<GPIJKLCGPHF.GIFEMCNMJDN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1E49AE0", Offset = "0x1E48AE0", VA = "0x181E49AE0")]
	public static JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> KMAJICKDIHL([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF> PLLGMJMBDKI)
	{
		return default(JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x1E48D70", Offset = "0x1E47D70", VA = "0x181E48D70")]
	public static GPIJKLCGPHF.JJPLIOPLOGG CMNECCLHFAH([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> JPBCPAOBLLC)
	{
		return default(GPIJKLCGPHF.JJPLIOPLOGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1E48970", Offset = "0x1E47970", VA = "0x181E48970")]
	public static GPIJKLCGPHF.JJPLIOPLOGG BPMHBGBLKAG(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> JPBCPAOBLLC)
	{
		return default(GPIJKLCGPHF.JJPLIOPLOGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2F15FE0", Offset = "0x2F14FE0", VA = "0x182F15FE0")]
	private static JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF> HMNCGLKFKFC<TMJoin>(this KILBPLDFBOP HFLBADIEKAM, GPIJKLCGPHF.DACJHHHHBMC COHEFBNLIFM, JLADLGKIDDG<TMJoin> FDFGNHCNMEL) where TMJoin : GPIJKLCGPHF.HAPBJDKHLFC
	{
		return default(JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1E49680", Offset = "0x1E48680", VA = "0x181E49680")]
	public static (JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>) FILEBPPMBDM(this KILBPLDFBOP HFLBADIEKAM)
	{
		return default((JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1E49EE0", Offset = "0x1E48EE0", VA = "0x181E49EE0")]
	public static (JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>) NFGKGPDFGBD(this KILBPLDFBOP HFLBADIEKAM)
	{
		return default((JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x1E49C50", Offset = "0x1E48C50", VA = "0x181E49C50")]
	public static JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF> LLAFIMELJNI(this KILBPLDFBOP HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A0A0", Offset = "0x1E490A0", VA = "0x181E4A0A0")]
	public static void NGMHJGNLGME(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN> JPBCPAOBLLC, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> KAKGOOLOLNH, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>> BKNFKNNBHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2F15200", Offset = "0x2F14200", VA = "0x182F15200")]
	public static CFGHPOBJCNG EDOGPLHJNEN<TDeps, TStateSys>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN) where TDeps : GOODBLFMJLJ<TStateSys>
	{
		return default(CFGHPOBJCNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2F16A50", Offset = "0x2F15A50", VA = "0x182F16A50")]
	public static KDDGLCMKMPE KHFOLKIOJOK<TDeps, TStateSys>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<GAGHAPPFMGC> KBFBOOCDDFE, int JINJJOHPIJH) where TDeps : GOODBLFMJLJ<TStateSys>
	{
		return default(KDDGLCMKMPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2F16090", Offset = "0x2F15090", VA = "0x182F16090")]
	public static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>? HOEFJAFCAFP<TDeps, TStateSys>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<GAGHAPPFMGC> KBFBOOCDDFE, [In] ReadOnlySpan<int> NECNIANKPAG, [In] Span<JIAJOMOHLKO> CLMDMIONGGI) where TDeps : GOODBLFMJLJ<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2F164B0", Offset = "0x2F154B0", VA = "0x182F164B0")]
	public static JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH> IBPHFKFBPCG<TDeps, TStateSys>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<HIDODOLPGGA> IDIHOPKDBNN) where TDeps : GOODBLFMJLJ<TStateSys>
	{
		return default(JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A3D0", Offset = "0x1E493D0", VA = "0x181E4A3D0")]
	public static NEIFODCBPDH.ODMOGENKDJH ONOOCMNGLEF([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> JKEKANKKCCC)
	{
		return default(NEIFODCBPDH.ODMOGENKDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x1E499E0", Offset = "0x1E489E0", VA = "0x181E499E0")]
	public static NEIFODCBPDH.DICJMPDGIGC JLIEPCCDFGP([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> JKEKANKKCCC)
	{
		return default(NEIFODCBPDH.DICJMPDGIGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1E48C40", Offset = "0x1E47C40", VA = "0x181E48C40")]
	public static NEIFODCBPDH.OCOIJGGGONF CMAMONCMIGH([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> JKEKANKKCCC)
	{
		return default(NEIFODCBPDH.OCOIJGGGONF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A1B0", Offset = "0x1E491B0", VA = "0x181E4A1B0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> OJNJGOFAMDB(this KILBPLDFBOP HFLBADIEKAM, int? FBCJEJNNKCO, string ONGJKHHOIAM)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1E49070", Offset = "0x1E48070", VA = "0x181E49070")]
	public static NEIFODCBPDH.MIPLHDNPKEO EIOBDDALOJI([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> JKEKANKKCCC)
	{
		return default(NEIFODCBPDH.MIPLHDNPKEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1E49980", Offset = "0x1E48980", VA = "0x181E49980")]
	public static NEIFODCBPDH.ACENGBHJBCG JHEKIIFABKE([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> JKEKANKKCCC)
	{
		return default(NEIFODCBPDH.ACENGBHJBCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1E49D90", Offset = "0x1E48D90", VA = "0x181E49D90")]
	public static int? NALHKKKMGDL([In] this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> JKEKANKKCCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2F16CD0", Offset = "0x2F15CD0", VA = "0x182F16CD0")]
	private static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KJHMEDBHICH<TMJoin>(this KILBPLDFBOP HFLBADIEKAM, int? FBCJEJNNKCO, NEIFODCBPDH.ACENGBHJBCG COHEFBNLIFM, JLADLGKIDDG<TMJoin> FDFGNHCNMEL) where TMJoin : NEIFODCBPDH.EMCHBBJJHMB
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1E48650", Offset = "0x1E47650", VA = "0x181E48650")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> AFGHDMPKFPE(this KILBPLDFBOP HFLBADIEKAM, int? FBCJEJNNKCO, JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF> PLLGMJMBDKI, int GPEHCABDGEJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1E49A80", Offset = "0x1E48A80", VA = "0x181E49A80")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> JLKIPLDCFNO(this KILBPLDFBOP HFLBADIEKAM, int? FBCJEJNNKCO)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1E489D0", Offset = "0x1E479D0", VA = "0x181E489D0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> CDIIOPPCOBB(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>? OEAIFAABMHF, int? FBCJEJNNKCO)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E48E90", Offset = "0x1E47E90", VA = "0x181E48E90")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> DCEJPBJDJEC(this KILBPLDFBOP HFLBADIEKAM, int? FBCJEJNNKCO, int GPEHCABDGEJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E48DD0", Offset = "0x1E47DD0", VA = "0x181E48DD0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> COOAECNANAL(this KILBPLDFBOP HFLBADIEKAM, int? FBCJEJNNKCO)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A620", Offset = "0x1E49620", VA = "0x181E4A620")]
	public static void PMDELLKMPOF(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> BJANPDFODGF, JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF> PLLGMJMBDKI, int GPEHCABDGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A520", Offset = "0x1E49520", VA = "0x181E4A520")]
	public static void PIBBJPKCIII(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> BJANPDFODGF, int GPEHCABDGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E495C0", Offset = "0x1E485C0", VA = "0x181E495C0")]
	public static void FIBABMOMANJ(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> BJANPDFODGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E485C0", Offset = "0x1E475C0", VA = "0x181E485C0")]
	public static void AAJMOOKGOKD(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> AOHFGFEGDPB, JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> CNIIGDIMEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1E48FB0", Offset = "0x1E47FB0", VA = "0x181E48FB0")]
	public static void EFEKAKHDEFJ(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> BJANPDFODGF, JLADLGKIDDG<IDLGMCCAMDG<MPMJCDGBKCK>> KKFNJHGICDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2F16DB0", Offset = "0x2F15DB0", VA = "0x182F16DB0")]
	public static void MHOEKOPLCHA<M>(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> BJANPDFODGF, JLADLGKIDDG<IDLGMCCAMDG<PHCJBMLJEPM<M>>> KKFNJHGICDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface GOODBLFMJLJ<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JLADLGKIDDG<EPAMAENIHNO> DAGLBKNOLGL(TStateSys BJPEDFLBJOL);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JLADLGKIDDG<EPAMAENIHNO> MEBBIGJPGPK(TStateSys BJPEDFLBJOL);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JLADLGKIDDG<EPAMAENIHNO> HLGKOJPOLAK(TStateSys BJPEDFLBJOL);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JLADLGKIDDG<EPAMAENIHNO> ECDEDBJEDON(TStateSys BJPEDFLBJOL);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH> JAMDJDAMNBD(TStateSys BJPEDFLBJOL, KILBPLDFBOP MJKNOPPFGHO, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> EEKPPPFECIB(TStateSys BJPEDFLBJOL, KILBPLDFBOP MJKNOPPFGHO, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<HIDODOLPGGA> IDIHOPKDBNN);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int PIBAMJLKILH(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JLADLGKIDDG<HIDODOLPGGA> OCOHFCMGAON(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN, int AOJCNMOAOPE);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EKGILMNEGCA EHNCODJDPBM(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MFPMOMMEJDE(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int KEIBGMDHMBH(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HAOCLPALDAM<byte> APOGMOJCKGK(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(HAOCLPALDAM<byte>, JLADLGKIDDG<EPAMAENIHNO>) IHCCBDHLFEP(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<OFKKFGCILME> PGPGHAGDOFN);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int OGGMKAPKNJH(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<HIDODOLPGGA> IDIHOPKDBNN);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	JLADLGKIDDG<OFKKFGCILME> DDIBLIJCJCG(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<HIDODOLPGGA> IDIHOPKDBNN, int JINJJOHPIJH);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JLADLGKIDDG<OFKKFGCILME> LGLJOPPFMOF(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, JLADLGKIDDG<GAGHAPPFMGC> KBFBOOCDDFE, int JINJJOHPIJH);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int DHFECMLKPCI(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? MMCLBOEDJHF(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, int GPEHCABDGEJ);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int MMBHKEINEHF(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? HEGOANGMLNJ(TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP, int GPEHCABDGEJ);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class CLBJGFFAOAB
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x271C8F0", Offset = "0x271B8F0", VA = "0x18271C8F0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH?> MNCDHGLJCBF<T, TOpInput, TOpOutput>(this KILBPLDFBOP HFLBADIEKAM, T LEGDDGHJEMC, T KNJHKKJANOJ, int JEPDIIFEJMJ, IntPtr IAOJIDPOIGN)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x271A7F0", Offset = "0x27197F0", VA = "0x18271A7F0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH?> ANEAMPGHILD<T, TOpInput, TOpOutput>(this KILBPLDFBOP HFLBADIEKAM, T LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ, int JEPDIIFEJMJ, IntPtr IAOJIDPOIGN)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x271C7D0", Offset = "0x271B7D0", VA = "0x18271C7D0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH?> MIBAPAJGIOB<TOpInput, TOpOutput>(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ, int JEPDIIFEJMJ, IntPtr IAOJIDPOIGN)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E4F0", Offset = "0x1E4D4F0", VA = "0x181E4E4F0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MLPHEOLLMAJ(this KILBPLDFBOP HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E3D0", Offset = "0x1E4D3D0", VA = "0x181E4E3D0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MLLFCFHKKCP(this KILBPLDFBOP HFLBADIEKAM, float LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B870", Offset = "0x1E4A870", VA = "0x181E4B870")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> CFJHEAFHDEE(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D1A0", Offset = "0x1E4C1A0", VA = "0x181E4D1A0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> IMJHFCDOFDN(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B280", Offset = "0x1E4A280", VA = "0x181E4B280")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> BHNFHPCAEDG(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F020", Offset = "0x1E4E020", VA = "0x181E4F020")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> OCJCDMEIOLN(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EE30", Offset = "0x1E4DE30", VA = "0x181E4EE30")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> NOGGJCICGGH(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D520", Offset = "0x1E4C520", VA = "0x181E4D520")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KEENEPELHCI(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C7E0", Offset = "0x1E4B7E0", VA = "0x181E4C7E0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> GPLAPOALNGF(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1E4AFF0", Offset = "0x1E49FF0", VA = "0x181E4AFF0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> BFHKMILFEEL(this KILBPLDFBOP HFLBADIEKAM, int LEGDDGHJEMC, int KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D080", Offset = "0x1E4C080", VA = "0x181E4D080")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> IKOLJEPLHKI(this KILBPLDFBOP HFLBADIEKAM, int LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C580", Offset = "0x1E4B580", VA = "0x181E4C580")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> FOPACKHFKCA(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B770", Offset = "0x1E4A770", VA = "0x181E4B770")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> CBEFFPEFAME(this KILBPLDFBOP HFLBADIEKAM, float LEGDDGHJEMC, float KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C1F0", Offset = "0x1E4B1F0", VA = "0x181E4C1F0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> FCADDBHFGOC(this KILBPLDFBOP HFLBADIEKAM, float LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F170", Offset = "0x1E4E170", VA = "0x181E4F170")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> OJPNHJALPCM(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B200", Offset = "0x1E4A200", VA = "0x181E4B200")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> BHGJABGHGEK(this KILBPLDFBOP HFLBADIEKAM, int LEGDDGHJEMC, int KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DE60", Offset = "0x1E4CE60", VA = "0x181E4DE60")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LPBMIDJFIMP(this KILBPLDFBOP HFLBADIEKAM, int LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1E4AF50", Offset = "0x1E49F50", VA = "0x181E4AF50")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> AMJCMIJKAIM(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1E4CA40", Offset = "0x1E4BA40", VA = "0x181E4CA40")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> ICFPOKLGJBP(this KILBPLDFBOP HFLBADIEKAM, float LEGDDGHJEMC, float KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1E4AD90", Offset = "0x1E49D90", VA = "0x181E4AD90")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> AGCKDCDHELP(this KILBPLDFBOP HFLBADIEKAM, float LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C440", Offset = "0x1E4B440", VA = "0x181E4C440")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> FKLEDFCDJPJ(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D780", Offset = "0x1E4C780", VA = "0x181E4D780")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KMNEFNCFNKN(this KILBPLDFBOP HFLBADIEKAM, int LEGDDGHJEMC, int KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EDB0", Offset = "0x1E4DDB0", VA = "0x181E4EDB0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> NLEMNPOLPAA(this KILBPLDFBOP HFLBADIEKAM, int LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F2B0", Offset = "0x1E4E2B0", VA = "0x181E4F2B0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> OLNHFCDIPLK(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E230", Offset = "0x1E4D230", VA = "0x181E4E230")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MHJJFDHOIJJ(this KILBPLDFBOP HFLBADIEKAM, float LEGDDGHJEMC, float KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C9C0", Offset = "0x1E4B9C0", VA = "0x181E4C9C0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> HILOPBFOEDE(this KILBPLDFBOP HFLBADIEKAM, float LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F330", Offset = "0x1E4E330", VA = "0x181E4F330")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> PAAKDFHIIFE(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F630", Offset = "0x1E4E630", VA = "0x181E4F630")]
	public static JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> PJFKLNHJBBL(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1E4CEF0", Offset = "0x1E4BEF0", VA = "0x181E4CEF0")]
	public static JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> IJCJHBBJCDL(this KILBPLDFBOP HFLBADIEKAM, int LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C920", Offset = "0x1E4B920", VA = "0x181E4C920")]
	public static JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> HIKKAADENIP(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DA20", Offset = "0x1E4CA20", VA = "0x181E4DA20")]
	public static JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> LFACMCCKHCE(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> LGLHPEFNJME)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C3C0", Offset = "0x1E4B3C0", VA = "0x181E4C3C0")]
	public static JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> FIPAEKIANAB(this KILBPLDFBOP HFLBADIEKAM, int LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C320", Offset = "0x1E4B320", VA = "0x181E4C320")]
	public static JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> FEMCKEIGMGC(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E5F0", Offset = "0x1E4D5F0", VA = "0x181E4E5F0")]
	public static (JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>) MMOFLFLKOOO(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<DCNCMOEPGKE> PJIHGNKHLOB, [In] ReadOnlySpan<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> FJIONCIBEFF, [In] ReadOnlySpan<int?> POEAEBOBIAL, [In] Span<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> CAHABKDABBA)
	{
		return default((JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F930", Offset = "0x1E4E930", VA = "0x181E4F930")]
	public static (JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>) PNNCOGDONPF(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<AHKIDIJDGNC> GJNNELEMMHP, [In] ReadOnlySpan<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> FJIONCIBEFF, [In] ReadOnlySpan<int?> POEAEBOBIAL, [In] Span<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> CAHABKDABBA)
	{
		return default((JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x271A700", Offset = "0x2719700", VA = "0x18271A700")]
	public static (JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<EPAMAENIHNO>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<TMarker>>, JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>) ACNCNKEHPHM<TMarker>(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<EPAMAENIHNO> FGCFPCBLELN, [In] ReadOnlySpan<byte> GPKMLHOONCL)
	{
		return default((JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<IDLGMCCAMDG<EPAMAENIHNO>>, JLADLGKIDDG<IDLGMCCAMDG<PJBEFFCNGMJ>>, JLADLGKIDDG<IDLGMCCAMDG<TMarker>>, JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C4C0", Offset = "0x1E4B4C0", VA = "0x181E4C4C0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> FNGGBBOHMLF(this KILBPLDFBOP HFLBADIEKAM, int PCHMCJDHEHP, [Optional] JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>? JBHABPPCPJL)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1E4ACA0", Offset = "0x1E49CA0", VA = "0x181E4ACA0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> AFPIAMEGABN(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> PCHMCJDHEHP, [Optional] JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>? JBHABPPCPJL)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B9B0", Offset = "0x1E4A9B0", VA = "0x181E4B9B0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> CMEEMEOPLEH(this KILBPLDFBOP HFLBADIEKAM, [In] ReadOnlySpan<byte> PCHMCJDHEHP, [Optional] JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>? JBHABPPCPJL)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F810", Offset = "0x1E4E810", VA = "0x181E4F810")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> PJPILOFPDLO(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> PCHMCJDHEHP, int GFFAGBDKDAI, [Optional] JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>? JBHABPPCPJL)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D920", Offset = "0x1E4C920", VA = "0x181E4D920")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KOKOOKCNLEH(this KILBPLDFBOP HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B0E0", Offset = "0x1E4A0E0", VA = "0x181E4B0E0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> BFPIGJPNGIA(this KILBPLDFBOP HFLBADIEKAM, float LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EA80", Offset = "0x1E4DA80", VA = "0x181E4EA80")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MPKHFKFAMBL(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E000", Offset = "0x1E4D000", VA = "0x181E4E000")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MCMPGNKJIKE(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x1E4CDD0", Offset = "0x1E4BDD0", VA = "0x181E4CDD0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> IGLALPONDDB(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E0F0", Offset = "0x1E4D0F0", VA = "0x181E4E0F0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MEAOMDJJBLG(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EF20", Offset = "0x1E4DF20", VA = "0x181E4EF20")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> NPHBICFKOFO(this KILBPLDFBOP HFLBADIEKAM, int LEGDDGHJEMC, int KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D290", Offset = "0x1E4C290", VA = "0x181E4D290")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> IOFJCPHPOAO(this KILBPLDFBOP HFLBADIEKAM, int LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EFA0", Offset = "0x1E4DFA0", VA = "0x181E4EFA0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> OACDBCNOGNE(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LEGDDGHJEMC, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJHKKJANOJ)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x1E4BED0", Offset = "0x1E4AED0", VA = "0x181E4BED0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> EOAKGFIPCLB(this KILBPLDFBOP HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E4BFD0", Offset = "0x1E4AFD0", VA = "0x181E4BFD0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> EPLPLLEAEMK(this KILBPLDFBOP HFLBADIEKAM, float LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D640", Offset = "0x1E4C640", VA = "0x181E4D640")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KIEBHDMMPDE(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x1E4BDE0", Offset = "0x1E4ADE0", VA = "0x181E4BDE0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> EJKCIIHBDGK(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D800", Offset = "0x1E4C800", VA = "0x181E4D800")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> KNJMCHOIKEG(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E4BCA0", Offset = "0x1E4ACA0", VA = "0x181E4BCA0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> DNNJMAMEFIO(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x1E4AFD0", Offset = "0x1E49FD0", VA = "0x181E4AFD0")]
	public static JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>> BEBEGEJKIIL(this KILBPLDFBOP HFLBADIEKAM)
	{
		return default(JLADLGKIDDG<IDLGMCCAMDG<IDLGMCCAMDG<DBMDCKBHFBA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1E4BAA0", Offset = "0x1E4AAA0", VA = "0x181E4BAA0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> DHBOPHKIKKN(this KILBPLDFBOP HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E4E2B0", Offset = "0x1E4D2B0", VA = "0x181E4E2B0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MLELPIHAPOK(this KILBPLDFBOP HFLBADIEKAM, float LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F4F0", Offset = "0x1E4E4F0", VA = "0x181E4F4F0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> PIBEDLPFEOH(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D310", Offset = "0x1E4C310", VA = "0x181E4D310")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> JAAOBEGLMNB(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x1E4D400", Offset = "0x1E4C400", VA = "0x181E4D400")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> JNIJIMINIHA(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E4AB60", Offset = "0x1E49B60", VA = "0x181E4AB60")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> AFEJKDNEIKD(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E4ECB0", Offset = "0x1E4DCB0", VA = "0x181E4ECB0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> NFLOINHGAMB(this KILBPLDFBOP HFLBADIEKAM, int LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x1E4CF70", Offset = "0x1E4BF70", VA = "0x181E4CF70")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> IJMLELOAJEO(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LDGMLLMKHLF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F160", Offset = "0x1E4E160", VA = "0x181E4F160")]
	public static void OELKIJBJFHG(this KILBPLDFBOP HFLBADIEKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E4BBA0", Offset = "0x1E4ABA0", VA = "0x181E4BBA0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> DMMPHIFJEMK(this KILBPLDFBOP HFLBADIEKAM, float LFLKMMBCCPH, float MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DEE0", Offset = "0x1E4CEE0", VA = "0x181E4DEE0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MAJDDKCLODC(this KILBPLDFBOP HFLBADIEKAM, float LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DC00", Offset = "0x1E4CC00", VA = "0x181E4DC00")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LHDLBFMAGNM(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EBC0", Offset = "0x1E4DBC0", VA = "0x181E4EBC0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> NBJGPIIAAON(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C6C0", Offset = "0x1E4B6C0", VA = "0x181E4C6C0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> GNDDLOJEKDI(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x1E4AA20", Offset = "0x1E49A20", VA = "0x181E4AA20")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> AEINOKEAMKF(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x1E4B3A0", Offset = "0x1E4A3A0", VA = "0x181E4B3A0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> CBDABIGILCE(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> CGGIGCMNIHD, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> GLIHLLIBKDO)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x1E4C100", Offset = "0x1E4B100", VA = "0x181E4C100")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> FAPJGBNBGMA(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, int MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x1E4DD40", Offset = "0x1E4CD40", VA = "0x181E4DD40")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LOGEAGGENAC(this KILBPLDFBOP HFLBADIEKAM, int LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x1E4AE10", Offset = "0x1E49E10", VA = "0x181E4AE10")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> AHFPKAJPAJO(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> LFLKMMBCCPH, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> MJPOGINCCPF)
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x271A1F0", Offset = "0x27191F0", VA = "0x18271A1F0")]
	public static void ACCGHFGPHEJ<TDeps, TState>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TState DKOKOEEPCNN, JLADLGKIDDG<DCNCMOEPGKE> PJIHGNKHLOB, [In] ReadOnlySpan<JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>> GIMLFNAFEBC, [In] ReadOnlySpan<int?> POEAEBOBIAL, [In] Span<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> CAHABKDABBA, [In] Span<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> MMMEEFGFFAK, [In] ReadOnlySpan<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>?> LFIFGMOBMBG) where TDeps : notnull, GOODBLFMJLJ<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x271B900", Offset = "0x271A900", VA = "0x18271B900")]
	public static void LOPGHNCMPLL<TDeps, TState>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TState DKOKOEEPCNN, JLADLGKIDDG<AHKIDIJDGNC> DCLBDAHBMFI, [In] ReadOnlySpan<JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>> DLANMBNEDLF, [In] ReadOnlySpan<int?> POEAEBOBIAL, [In] Span<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> CAHABKDABBA, [In] Span<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>> MMMEEFGFFAK, [In] ReadOnlySpan<JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>?> LFIFGMOBMBG) where TDeps : notnull, GOODBLFMJLJ<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x271AF00", Offset = "0x2719F00", VA = "0x18271AF00")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> FNNMDNPCGLL<TDeps, TState>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TState DKOKOEEPCNN, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> OEAIFAABMHF, [Optional] JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>? JBHABPPCPJL) where TDeps : notnull, GOODBLFMJLJ<TState> where TState : notnull
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x271AAD0", Offset = "0x2719AD0", VA = "0x18271AAD0")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> CEKMEIHKLKP<TDeps, TState>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TState DKOKOEEPCNN, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> OGOPIFDKNCN, [Optional] JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>? JBHABPPCPJL) where TDeps : notnull, GOODBLFMJLJ<TState> where TState : notnull
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x271CB90", Offset = "0x271BB90", VA = "0x18271CB90")]
	public static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> NIGFBCCDCLK<TDeps, TStateSys>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TStateSys BJPEDFLBJOL) where TDeps : notnull, GOODBLFMJLJ<TStateSys> where TStateSys : notnull
	{
		return default(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x271CF00", Offset = "0x271BF00", VA = "0x18271CF00")]
	public static JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH> NNEEKOCMALB<TDeps, TStateSys>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TStateSys BJPEDFLBJOL) where TDeps : notnull, GOODBLFMJLJ<TStateSys> where TStateSys : notnull
	{
		return default(JLADLGKIDDG<LDPDMAMMEJB.LDOCPGCFIOH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x1E4F3B0", Offset = "0x1E4E3B0", VA = "0x181E4F3B0")]
	public static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> PHHGKPJFMBF(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> PFBGMGKHHMO, IntPtr DLILOAFBFLD, IntPtr AKGJCGFCIDG)
	{
		return default(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1E4CAC0", Offset = "0x1E4BAC0", VA = "0x181E4CAC0")]
	public static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> ICGOACEMBLJ(this KILBPLDFBOP HFLBADIEKAM, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> OAPAKHNDEEN, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> MFAGJJOGCNA, IntPtr KECGFHAHGNP, IntPtr MOBAEKNBCNI, IntPtr OJNEKKCAEJA, bool HCFEIECANBN)
	{
		return default(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x271C120", Offset = "0x271B120", VA = "0x18271C120")]
	public static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> MACGCAKABBH<TDeps, TState>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TState DKOKOEEPCNN, JLADLGKIDDG<DCNCMOEPGKE> BOPBHFAKIIC, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> OAPAKHNDEEN, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> MFAGJJOGCNA, int? EEGDLGEHKBM, [Optional] IntPtr BDPOAEOIMCD) where TDeps : notnull, GOODBLFMJLJ<TState> where TState : notnull
	{
		return default(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x271BE10", Offset = "0x271AE10", VA = "0x18271BE10")]
	private static JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> MACGCAKABBH<TDeps, TState>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TState DKOKOEEPCNN, JLADLGKIDDG<DCNCMOEPGKE> BOPBHFAKIIC, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> OAPAKHNDEEN, JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB> MFAGJJOGCNA, int? EEGDLGEHKBM) where TDeps : notnull, GOODBLFMJLJ<TState> where TState : notnull
	{
		return default(JLADLGKIDDG<NGJHBCLMNLC.LKKPLEPAHMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x271B480", Offset = "0x271A480", VA = "0x18271B480")]
	public static JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> JPHMKHKLBOH<TDeps, TState>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TState DKOKOEEPCNN, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH> PCHMCJDHEHP, JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>? JBHABPPCPJL) where TDeps : notnull, GOODBLFMJLJ<TState> where TState : notnull
	{
		return default(JLADLGKIDDG<NEIFODCBPDH.GPIBDBIGAHH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x271B0C0", Offset = "0x271A0C0", VA = "0x18271B0C0")]
	public static void GMLGOOHBGFJ<TDeps, TState>(this KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TState DKOKOEEPCNN, int CGJEKEHOKIO) where TDeps : notnull, GOODBLFMJLJ<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct CFELHNEMNMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> OACJNHNOOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> FNPKLAFCNBH;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xAE6AB0", Offset = "0xAE5AB0", VA = "0x180AE6AB0")]
	public CFELHNEMNMM(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> JFPAHGCMCKN, JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> PDDOPGHCENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x1E4A960", Offset = "0x1E49960", VA = "0x181E4A960")]
	public static CFELHNEMNMM MGIIAIMPALM(JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>> JFPAHGCMCKN)
	{
		return default(CFELHNEMNMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct NEIFODCBPDH
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class EOEIBHGHGOD : EMCHBBJJHMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct ODMOGENKDJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF> HFPKAGKODIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int CBOGBOOIKCP;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AB0", Offset = "0xAE5AB0", VA = "0x180AE6AB0")]
		public ODMOGENKDJH(JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF> PLLGMJMBDKI, int GPEHCABDGEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class NNBLKLKBEGK : EMCHBBJJHMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct DICJMPDGIGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int CBOGBOOIKCP;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
		public DICJMPDGIGC(int GPEHCABDGEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class IAHNMBEKELE : EMCHBBJJHMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct OCOIJGGGONF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF> HFPKAGKODIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int CBOGBOOIKCP;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AB0", Offset = "0xAE5AB0", VA = "0x180AE6AB0")]
		public OCOIJGGGONF(JLADLGKIDDG<GPIJKLCGPHF.PIIBLGBKPAF> PLLGMJMBDKI, int GPEHCABDGEJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum ACENGBHJBCG
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
	public sealed class GPIBDBIGAHH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class EMCHBBJJHMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct NPHMDPOAOGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? OKLLJBOKFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CFELHNEMNMM MKAMJMMKCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public ACENGBHJBCG KLHMKNHHPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public JLADLGKIDDG<EMCHBBJJHMB> CIMNIPCLENO;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1E52DF0", Offset = "0x1E51DF0", VA = "0x181E52DF0")]
		public NPHMDPOAOGN(int? FBCJEJNNKCO, [In] CFELHNEMNMM LDFCJFMLFID, ACENGBHJBCG COHEFBNLIFM, JLADLGKIDDG<EMCHBBJJHMB> FDFGNHCNMEL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class FEOOGEPGHPI : EMCHBBJJHMB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct MIPLHDNPKEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int CBOGBOOIKCP;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x915160", Offset = "0x914160", VA = "0x180915160")]
		public MIPLHDNPKEO(int GPEHCABDGEJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal FCCECAANEHG<GPIBDBIGAHH, NPHMDPOAOGN> LEFHLLCPGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal FCCECAANEHG<EOEIBHGHGOD, ODMOGENKDJH> MBEMEGJHBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal FCCECAANEHG<IAHNMBEKELE, OCOIJGGGONF> OLEEGGIMHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal FCCECAANEHG<FEOOGEPGHPI, MIPLHDNPKEO> DDPAIOEFAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal FCCECAANEHG<NNBLKLKBEGK, DICJMPDGIGC> IACBOOFFGIG;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1E52AF0", Offset = "0x1E51AF0", VA = "0x181E52AF0")]
	private NEIFODCBPDH([In] FCCECAANEHG<GPIBDBIGAHH, NPHMDPOAOGN> LKHDFNFMHEL, [In] FCCECAANEHG<EOEIBHGHGOD, ODMOGENKDJH> CCGJFPEIMOK, [In] FCCECAANEHG<IAHNMBEKELE, OCOIJGGGONF> CNGLNIDANOK, [In] FCCECAANEHG<FEOOGEPGHPI, MIPLHDNPKEO> JBKOIFBLMEG, [In] FCCECAANEHG<NNBLKLKBEGK, DICJMPDGIGC> GOMINJAAMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1E52900", Offset = "0x1E51900", VA = "0x181E52900")]
	public static NEIFODCBPDH MGIIAIMPALM()
	{
		return default(NEIFODCBPDH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IHCJMJBOFCD
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x1E50CF0", Offset = "0x1E4FCF0", VA = "0x181E50CF0")]
	public static void FAAFJENLCBJ(this NEIFODCBPDH HFLBADIEKAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class FFGIBJLPMAD
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1E50140", Offset = "0x1E4F140", VA = "0x181E50140")]
	public static void AOFLBJDIDMG(KILBPLDFBOP HFLBADIEKAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct KIGLHAKALJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, FOKKBEBKMDA> CMEGCLLIEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int JELMJHNFJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int MEDBNCKLFNE;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1E51280", Offset = "0x1E50280", VA = "0x181E51280")]
	private KIGLHAKALJI([In] LAFNIHFOMLK<GPIJKLCGPHF.GIFEMCNMJDN, FOKKBEBKMDA> PFCPILLMCEO, int DFCNDMCBKDD, int KIDDAACELFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x1E51210", Offset = "0x1E50210", VA = "0x181E51210")]
	public static KIGLHAKALJI MGIIAIMPALM()
	{
		return default(KIGLHAKALJI);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1E51040", Offset = "0x1E50040", VA = "0x181E51040")]
	public void FAAFJENLCBJ([In] KILBPLDFBOP PNMNIPGGMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2951010", Offset = "0x2950010", VA = "0x182951010")]
	public static void AOFLBJDIDMG<TDeps, TStateSys>(KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TStateSys BJPEDFLBJOL, JLADLGKIDDG<IHHFAAHIKGJ> ABBEJOMODMP) where TDeps : notnull, GOODBLFMJLJ<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DHHIDIOIPLF
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1E4FE40", Offset = "0x1E4EE40", VA = "0x181E4FE40")]
	public static void AOFLBJDIDMG(KILBPLDFBOP HFLBADIEKAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct LGNLHKDPPCE
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface CBFLJCJPJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KOFPGIPLLBH(EJCNFOOPALK<byte> IONCLGMBDFJ, int KCICMCPGOOA);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct MNOGOLLPIOH : CBFLJCJPJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1E526B0", Offset = "0x1E516B0", VA = "0x181E526B0", Slot = "4")]
		public void KOFPGIPLLBH(EJCNFOOPALK<byte> IONCLGMBDFJ, int KCICMCPGOOA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct PAIHLDHOLPG : CBFLJCJPJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x1E530F0", Offset = "0x1E520F0", VA = "0x181E530F0", Slot = "4")]
		public void KOFPGIPLLBH(EJCNFOOPALK<byte> IONCLGMBDFJ, int KCICMCPGOOA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct DHALCBJIPPH : CBFLJCJPJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1E4FDC0", Offset = "0x1E4EDC0", VA = "0x181E4FDC0", Slot = "4")]
		public void KOFPGIPLLBH(EJCNFOOPALK<byte> IONCLGMBDFJ, int KCICMCPGOOA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct CGAJOHDILME : CBFLJCJPJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1E4A980", Offset = "0x1E49980", VA = "0x181E4A980", Slot = "4")]
		public void KOFPGIPLLBH(EJCNFOOPALK<byte> IONCLGMBDFJ, int KCICMCPGOOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class KKBIOIOLJEL<TCallProcessorDeps> where TCallProcessorDeps : struct, CBFLJCJPJKI
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps KOPMBDPCNDC;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x27CD860", Offset = "0x27CC860", VA = "0x1827CD860")]
		public static int AOFLBJDIDMG<TDeps, TStateSys>(TDeps AKOGIKBAMPF, TStateSys DKOKOEEPCNN, KILBPLDFBOP PNMNIPGGMGH, [In] EJCNFOOPALK<byte> AODDEHDGOHN, int LFCMPLFCDIH) where TDeps : GOODBLFMJLJ<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private EJCNFOOPALK<MGCOFMLKDHJ> NHKMAIHJEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>> AGLLFOKOGEK;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1E52670", Offset = "0x1E51670", VA = "0x181E52670")]
	private LGNLHKDPPCE([In] EJCNFOOPALK<MGCOFMLKDHJ> JBKENLNPDMJ, Dictionary<JLADLGKIDDG<IDLGMCCAMDG<DBMDCKBHFBA>>, JLADLGKIDDG<GPIJKLCGPHF.GIFEMCNMJDN>> OHCJBMNFFEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x1E525B0", Offset = "0x1E515B0", VA = "0x181E525B0")]
	public static LGNLHKDPPCE MGIIAIMPALM()
	{
		return default(LGNLHKDPPCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1E52570", Offset = "0x1E51570", VA = "0x181E52570")]
	public void FAAFJENLCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x295F400", Offset = "0x295E400", VA = "0x18295F400")]
	public static void AOFLBJDIDMG<TDeps, TStateSys>(KILBPLDFBOP HFLBADIEKAM, TDeps AKOGIKBAMPF, TStateSys BJPEDFLBJOL) where TDeps : GOODBLFMJLJ<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class GKDLNFKFNEL<TDeps, TIndex, TValues> where TDeps : struct, DLHBLINKPGL<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps KOPMBDPCNDC;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x39B5750", Offset = "0x39B4750", VA = "0x1839B5750")]
	public static void AOFLBJDIDMG([In] EJCNFOOPALK<MGCOFMLKDHJ> JBKENLNPDMJ, int PGCGGEEIMNF, TValues AGKDCPLPFCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface DLHBLINKPGL<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJCNFOOPALK<TIndex> IKHJPJKBBBG(int PGCGGEEIMNF, [In] TValues AGKDCPLPFCM);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(TIndex GPEHCABDGEJ, [In] TValues AGKDCPLPFCM);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKKGLFFLDOG(TIndex GPEHCABDGEJ, TValues AGKDCPLPFCM, JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> LDGMLLMKHLF);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface FCDDJPKIACF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex PBDJECFDEGA(int GPEHCABDGEJ);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NFOCIBEDBBO(TIndex GPEHCABDGEJ, [In] TValues AGKDCPLPFCM);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JLADLGKIDDG<IDLGMCCAMDG<MCDOBOMGEPK>> JBFCOMDPNOF(TIndex GPEHCABDGEJ, [In] TValues AGKDCPLPFCM);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class KEGHHOIEMJD<TDeps, TIndex, TValues> where TDeps : struct, FCDDJPKIACF<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps KOPMBDPCNDC;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3D66A10", Offset = "0x3D65A10", VA = "0x183D66A10")]
	public static EJCNFOOPALK<TIndex> AOFLBJDIDMG(int PGCGGEEIMNF, [In] TValues AGKDCPLPFCM)
	{
		return default(EJCNFOOPALK<TIndex>);
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
