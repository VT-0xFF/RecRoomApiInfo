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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x289CCE0", Offset = "0x289B4E0", VA = "0x18289CCE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct PALMFECNECE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PPNEAFLHKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int DNFFEFMJBKO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xDC6C10", Offset = "0xDC5410", VA = "0x180DC6C10")]
	public PALMFECNECE(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> EGIBFICHIPJ, int BJCMHPBMOOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct AOMHHJJJCII
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class BAFHGENCLFA : LBGBFNPCAOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct KIHFDOBBKNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly LBCPBJKCGNG<byte> AOILIDFNCLH;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2838860", Offset = "0x2837060", VA = "0x182838860")]
		public KIHFDOBBKNF(LBCPBJKCGNG<byte> LLNMEIMBBLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28999A0", Offset = "0x28981A0", VA = "0x1828999A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class NOLLMMADPOJ : LBGBFNPCAOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct NEGGIFDGMCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> EKELOHHBCIO;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		public NEGGIFDGMCO(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> GKGGCKGEJJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum IPPGPFFFDOE
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
	public sealed class FEOOIOJDEEP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class LBGBFNPCAOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct KDBJKGHIGCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly IPPGPFFFDOE FLGLJEOENFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly DPJIAIFILPM<LBGBFNPCAOE> JBMIJNJEEPB;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDC6C10", Offset = "0xDC5410", VA = "0x180DC6C10")]
		public KDBJKGHIGCG(IPPGPFFFDOE KPIOAMAHGKA, DPJIAIFILPM<LBGBFNPCAOE> CNMCJDBBEDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class JEFDNGBCNOG : LBGBFNPCAOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct EHECJKEFLKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> PPBIMNPGNCL;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		public EHECJKEFLKI(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOKLIJDLKOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class JMMFBBMJOCM : LBGBFNPCAOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct KAHNMKEODAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly KGJKGFJIMIK BDKAAILDBFJ;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		public KAHNMKEODAO(KGJKGFJIMIK HCNKHBHFCMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2898D70", Offset = "0x2897570", VA = "0x182898D70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal MCBACNKJBND<FEOOIOJDEEP, KDBJKGHIGCG> CMENKADFGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal MCBACNKJBND<BAFHGENCLFA, KIHFDOBBKNF> BFLIMCGFDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal MCBACNKJBND<NOLLMMADPOJ, NEGGIFDGMCO> IJPEDDIBINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal MCBACNKJBND<JEFDNGBCNOG, EHECJKEFLKI> JNBMFCOJJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal MCBACNKJBND<JMMFBBMJOCM, KAHNMKEODAO> GNBGAEAGFHN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2891C00", Offset = "0x2890400", VA = "0x182891C00")]
	private AOMHHJJJCII([In] MCBACNKJBND<FEOOIOJDEEP, KDBJKGHIGCG> ADHHBCNNPIN, [In] MCBACNKJBND<BAFHGENCLFA, KIHFDOBBKNF> PIBHPDAGKJF, [In] MCBACNKJBND<NOLLMMADPOJ, NEGGIFDGMCO> DIEGNLPOCOJ, [In] MCBACNKJBND<JEFDNGBCNOG, EHECJKEFLKI> LGHBCBNNCHC, [In] MCBACNKJBND<JMMFBBMJOCM, KAHNMKEODAO> EAACNCPGCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2891AC0", Offset = "0x28902C0", VA = "0x182891AC0")]
	public static AOMHHJJJCII CCPKJDCALBG()
	{
		return default(AOMHHJJJCII);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GGANPECKEOL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2897640", Offset = "0x2895E40", VA = "0x182897640")]
	public static void MMIAFMKGHIE(this AOMHHJJJCII DKBBJFIDEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum EHIFDANGIKM
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
public struct GLBFAOHMKOA
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class NJCAKGKJCNG : OAPNPFGDKOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct HMPLABDBCKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> OGILLNBNDJF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		public HMPLABDBCKJ(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> CJCKLCPJOCF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum ELBMDOPPPPO
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
	public sealed class EAFHLFJKADC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class OAPNPFGDKOE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct EALLIBFBLKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly ELBMDOPPPPO FLGLJEOENFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly DPJIAIFILPM<OAPNPFGDKOE> JBMIJNJEEPB;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDC6C10", Offset = "0xDC5410", VA = "0x180DC6C10")]
		public EALLIBFBLKM(ELBMDOPPPPO KPIOAMAHGKA, DPJIAIFILPM<OAPNPFGDKOE> CNMCJDBBEDB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal MCBACNKJBND<EAFHLFJKADC, EALLIBFBLKM> CMENKADFGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal MCBACNKJBND<NJCAKGKJCNG, HMPLABDBCKJ> GCJMCFMDFOI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x28922F0", Offset = "0x2890AF0", VA = "0x1828922F0")]
	private GLBFAOHMKOA([In] MCBACNKJBND<EAFHLFJKADC, EALLIBFBLKM> ADHHBCNNPIN, [In] MCBACNKJBND<NJCAKGKJCNG, HMPLABDBCKJ> PJJMPPNJICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2897700", Offset = "0x2895F00", VA = "0x182897700")]
	public static GLBFAOHMKOA CCPKJDCALBG()
	{
		return default(GLBFAOHMKOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class FOJPFMIJBDM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2892330", Offset = "0x2890B30", VA = "0x182892330")]
	public static void MMIAFMKGHIE(this GLBFAOHMKOA DKBBJFIDEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KGEJFPAEPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public GJEDEGEJPLA<int> FACNMLLGMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public GJEDEGEJPLA<int> BGLBJKBODNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int AIDPPIGFJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int CBGEEGMCHGF;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2898E30", Offset = "0x2897630", VA = "0x182898E30")]
	private KGEJFPAEPKM([In] GJEDEGEJPLA<int> NKENOFJEEEP, [In] GJEDEGEJPLA<int> HAMMENAMHBI, int ICDLNMPADKA, int MGBJKGMBEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2898D90", Offset = "0x2897590", VA = "0x182898D90")]
	public static KGEJFPAEPKM CCPKJDCALBG()
	{
		return default(KGEJFPAEPKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class PJFAHMDGIMD
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x289CF60", Offset = "0x289B760", VA = "0x18289CF60")]
	public static void MMIAFMKGHIE(this KGEJFPAEPKM DKBBJFIDEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct AFEEIPNLLKF
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum AKGOJBAMKCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class GOJDJPMGFPP : MMDCEKKOHDG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct LDCJKEMKPNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly DPJIAIFILPM<AOKDNLHPEPC> AKAGLDENHLP;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		public LDCJKEMKPNK(DPJIAIFILPM<AOKDNLHPEPC> CICJGOHCMEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class MKEHCGDMJNL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class MMDCEKKOHDG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct GJAIHJNBLGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly AKGOJBAMKCM FLGLJEOENFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly DPJIAIFILPM<MMDCEKKOHDG> JBMIJNJEEPB;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xDC6C10", Offset = "0xDC5410", VA = "0x180DC6C10")]
		private GJAIHJNBLGD(AKGOJBAMKCM KPIOAMAHGKA, DPJIAIFILPM<MMDCEKKOHDG> CNMCJDBBEDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28976F0", Offset = "0x2895EF0", VA = "0x1828976F0")]
		public static GJAIHJNBLGD CCPKJDCALBG(AKGOJBAMKCM KPIOAMAHGKA, DPJIAIFILPM<MMDCEKKOHDG> CNMCJDBBEDB)
		{
			return default(GJAIHJNBLGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class PONIBIDHIJG : MMDCEKKOHDG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct CFCCDBBBDHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly DPJIAIFILPM<AOKDNLHPEPC> AKAGLDENHLP;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		public CFCCDBBBDHG(DPJIAIFILPM<AOKDNLHPEPC> CICJGOHCMEH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class AOKDNLHPEPC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct FMDNDLGBOPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public GJEDEGEJPLA<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> LBIAEDAPAHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GJEDEGEJPLA<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> JMHLOEDDDJD;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28922F0", Offset = "0x2890AF0", VA = "0x1828922F0")]
		private FMDNDLGBOPF([In] GJEDEGEJPLA<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> FKIDLMLIFPK, [In] GJEDEGEJPLA<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> DFGGJEEDOEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2892270", Offset = "0x2890A70", VA = "0x182892270")]
		public static FMDNDLGBOPF CCPKJDCALBG()
		{
			return default(FMDNDLGBOPF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal MCBACNKJBND<MKEHCGDMJNL, GJAIHJNBLGD> CMENKADFGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal MCBACNKJBND<PONIBIDHIJG, CFCCDBBBDHG> MNJDLNKOFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal MCBACNKJBND<GOJDJPMGFPP, LDCJKEMKPNK> AIBDLNPLBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal GJEDEGEJPLA<(DPJIAIFILPM<MKEHCGDMJNL> CallId, DPJIAIFILPM<AOKDNLHPEPC> IOId)> OMCKAIBKBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal MCBACNKJBND<AOKDNLHPEPC, FMDNDLGBOPF> CPLDMGNPOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal HFOFBJNAOJN<AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>> OAAECHFJDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal HFOFBJNAOJN<AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>> BINBADLDKLP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x28915A0", Offset = "0x288FDA0", VA = "0x1828915A0")]
	private AFEEIPNLLKF([In] MCBACNKJBND<MKEHCGDMJNL, GJAIHJNBLGD> ADHHBCNNPIN, [In] MCBACNKJBND<PONIBIDHIJG, CFCCDBBBDHG> NCGEGKMHNCH, [In] MCBACNKJBND<GOJDJPMGFPP, LDCJKEMKPNK> LEGMONDLBNA, [In] GJEDEGEJPLA<(DPJIAIFILPM<MKEHCGDMJNL> CallId, DPJIAIFILPM<AOKDNLHPEPC> IOId)> HHMGNBJNGGC, [In] MCBACNKJBND<AOKDNLHPEPC, FMDNDLGBOPF> GOHFALDMCKH, [In] HFOFBJNAOJN<AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>> ONCMDOMHHHE, [In] HFOFBJNAOJN<AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>> HGAIJIALGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2891400", Offset = "0x288FC00", VA = "0x182891400")]
	public static AFEEIPNLLKF CCPKJDCALBG()
	{
		return default(AFEEIPNLLKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HLLDOFELBJG
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2897BC0", Offset = "0x28963C0", VA = "0x182897BC0")]
	private static void MMIAFMKGHIE(this AFEEIPNLLKF.FMDNDLGBOPF DKBBJFIDEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x28979B0", Offset = "0x28961B0", VA = "0x1828979B0")]
	public static void MMIAFMKGHIE(this AFEEIPNLLKF DKBBJFIDEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct IIJMPDEJAIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public GJEDEGEJPLA<byte> LKJLBJJECFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal AFEEIPNLLKF ALHAGJNKCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal LCJEFGCIPPJ NNJDFANMOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> DEBOMADOBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal AOMHHJJJCII EJGLMHHEDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal GLBFAOHMKOA DNFBGJEBPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal HFOFBJNAOJN<PFIGHJMHNHG, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>?> BMPHFIAPFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal GJEDEGEJPLA<DPJIAIFILPM<PFIGHJMHNHG>> FNEBHDCNCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?> MENEHCOHKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> VariableId, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>> ByteCodeWriteLocation)> IAKBJOKIGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> DFFAODCOPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal NMOAGENHGIK ONIEIOHJBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal ELOGPCPAAPA CEPBPBNJCJL;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2898880", Offset = "0x2897080", VA = "0x182898880")]
	private IIJMPDEJAIF([In] GJEDEGEJPLA<byte> GMNCGHBIBAN, [In] AFEEIPNLLKF KFOKOHOMICI, [In] LCJEFGCIPPJ KKKMIIAKBMB, [In] AOMHHJJJCII ONDHNFFNHNL, [In] GLBFAOHMKOA NLKGKKEHBIP, [In] HFOFBJNAOJN<PFIGHJMHNHG, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>?> AJBKBMHIIOJ, [In] GJEDEGEJPLA<DPJIAIFILPM<PFIGHJMHNHG>> IFBGCABBOKA, [In] HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?> HMAKDFNDJME, [In] GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> VariableId, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>> ByteCodeWriteLocation)> JCGMHGFCCBO, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> ADCPPJCFLBP, [In] NMOAGENHGIK AKODLBFCEBH, [In] ELOGPCPAAPA COBODEIJLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2897ED0", Offset = "0x28966D0", VA = "0x182897ED0")]
	public static IIJMPDEJAIF CCPKJDCALBG()
	{
		return default(IIJMPDEJAIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class MHDKHAHAMJI
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct MBMEADMCHLG : GNEDDJANEHC<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>, HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2899E60", Offset = "0x2898660", VA = "0x182899E60")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2899E20", Offset = "0x2898620", VA = "0x182899E20", Slot = "4")]
		public DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> GMMBJEKKABJ(int PNJCJGEIDHG)
		{
			return default(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700")]
		public bool MOAIDDFDKFP(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "5")]
		private bool DIIHINPGBKL(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2899E50", Offset = "0x2898650", VA = "0x182899E50", Slot = "6")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> HCKPNADOIHB(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct OHKKFDLFDIG : GBJBINGOIPP<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>, HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x289CE20", Offset = "0x289B620", VA = "0x18289CE20")]
		public GJEDEGEJPLA<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>> NNCGJEEJEOM(int DJKGCLIFION, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x289CEA0", Offset = "0x289B6A0", VA = "0x18289CEA0")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x289CD60", Offset = "0x289B560", VA = "0x18289CD60", Slot = "6")]
		public void DNCCAGHFKLI(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>> IFMNLKCJNMD, DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x289CE20", Offset = "0x289B620", VA = "0x18289CE20", Slot = "4")]
		private GJEDEGEJPLA<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>> FGBDFCPCKMN(int DJKGCLIFION, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x289CE90", Offset = "0x289B690", VA = "0x18289CE90", Slot = "5")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> JBBEKPEMKEB(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct LBFELGJIPEO : GNEDDJANEHC<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>, HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2899A50", Offset = "0x2898250", VA = "0x182899A50")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2899A10", Offset = "0x2898210", VA = "0x182899A10", Slot = "4")]
		public DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> GMMBJEKKABJ(int PNJCJGEIDHG)
		{
			return default(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700")]
		public bool MOAIDDFDKFP(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "5")]
		private bool CAHFCGLKOJE(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2899A40", Offset = "0x2898240", VA = "0x182899A40", Slot = "6")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> JLIDLEKMAJB(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct EOIMLDKMICJ : GBJBINGOIPP<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>, HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2891F70", Offset = "0x2890770", VA = "0x182891F70")]
		public GJEDEGEJPLA<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>> NNCGJEEJEOM(int DJKGCLIFION, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2891FF0", Offset = "0x28907F0", VA = "0x182891FF0")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2891EB0", Offset = "0x28906B0", VA = "0x182891EB0", Slot = "6")]
		public void DNCCAGHFKLI(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>> IFMNLKCJNMD, DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2891F70", Offset = "0x2890770", VA = "0x182891F70", Slot = "4")]
		private GJEDEGEJPLA<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>> IKHMBLEMMAH(int DJKGCLIFION, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2891FE0", Offset = "0x28907E0", VA = "0x182891FE0", Slot = "5")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> LMEPMCLIICO(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> PNJCJGEIDHG, [In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct JMKBAEEMGHD : GNEDDJANEHC<DPJIAIFILPM<GNMEFCOMPFO>, HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2898CA0", Offset = "0x28974A0", VA = "0x182898CA0")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(DPJIAIFILPM<GNMEFCOMPFO> PNJCJGEIDHG, [In] HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2898BE0", Offset = "0x28973E0", VA = "0x182898BE0", Slot = "4")]
		public DPJIAIFILPM<GNMEFCOMPFO> GMMBJEKKABJ(int PNJCJGEIDHG)
		{
			return default(DPJIAIFILPM<GNMEFCOMPFO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2898C20", Offset = "0x2897420", VA = "0x182898C20")]
		public bool MOAIDDFDKFP(DPJIAIFILPM<GNMEFCOMPFO> PNJCJGEIDHG, [In] HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2898C20", Offset = "0x2897420", VA = "0x182898C20", Slot = "5")]
		private bool MEKPMEIBNBH(DPJIAIFILPM<GNMEFCOMPFO> PNJCJGEIDHG, [In] HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2898C10", Offset = "0x2897410", VA = "0x182898C10", Slot = "6")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> LMFJKHFFJBD(DPJIAIFILPM<GNMEFCOMPFO> PNJCJGEIDHG, [In] HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct AMDONDIGEBK : GBJBINGOIPP<DPJIAIFILPM<GNMEFCOMPFO>, HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2891980", Offset = "0x2890180", VA = "0x182891980")]
		public GJEDEGEJPLA<DPJIAIFILPM<GNMEFCOMPFO>> NNCGJEEJEOM(int DJKGCLIFION, [In] HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<DPJIAIFILPM<GNMEFCOMPFO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28919F0", Offset = "0x28901F0", VA = "0x1828919F0")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(DPJIAIFILPM<GNMEFCOMPFO> PNJCJGEIDHG, [In] HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28918A0", Offset = "0x28900A0", VA = "0x1828918A0", Slot = "6")]
		public void DNCCAGHFKLI(DPJIAIFILPM<GNMEFCOMPFO> PNJCJGEIDHG, HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?> IFMNLKCJNMD, DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2891980", Offset = "0x2890180", VA = "0x182891980", Slot = "4")]
		private GJEDEGEJPLA<DPJIAIFILPM<GNMEFCOMPFO>> HOBPPMGNLCC(int DJKGCLIFION, [In] HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<DPJIAIFILPM<GNMEFCOMPFO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2891890", Offset = "0x2890090", VA = "0x182891890", Slot = "5")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> BMANDJLMOHL(DPJIAIFILPM<GNMEFCOMPFO> PNJCJGEIDHG, [In] HFOFBJNAOJN<GNMEFCOMPFO, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>?> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct MFEIPPDBBDG : GNEDDJANEHC<int, GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2899FD0", Offset = "0x28987D0", VA = "0x182899FD0")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> VariableId, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAEDD00", Offset = "0xAEC500", VA = "0x180AEDD00", Slot = "4")]
		public int GMMBJEKKABJ(int PNJCJGEIDHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700")]
		public bool MOAIDDFDKFP(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> VariableId, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "5")]
		private bool FDADHLONLBF(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> VariableId, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2899FC0", Offset = "0x28987C0", VA = "0x182899FC0", Slot = "6")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> MCDODOGDDOJ(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> VariableId, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct ALKDPAAOGAC : GBJBINGOIPP<int, GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2891780", Offset = "0x288FF80", VA = "0x182891780")]
		public GJEDEGEJPLA<int> NNCGJEEJEOM(int DJKGCLIFION, [In] GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> VariableId, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28917F0", Offset = "0x288FFF0", VA = "0x1828917F0")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> VariableId, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2891680", Offset = "0x288FE80", VA = "0x182891680", Slot = "6")]
		public void DNCCAGHFKLI(int PNJCJGEIDHG, GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> VariableId, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>> ByteCodeWriteLocation)> IFMNLKCJNMD, DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2891780", Offset = "0x288FF80", VA = "0x182891780", Slot = "4")]
		private GJEDEGEJPLA<int> ICMINHPHPNF(int DJKGCLIFION, [In] GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> VariableId, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2891670", Offset = "0x288FE70", VA = "0x182891670", Slot = "5")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> BIIDONKGKCL(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> VariableId, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<DPNAIGBABBE>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct MKOHELJDBHN : GNEDDJANEHC<int, GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x289C700", Offset = "0x289AF00", VA = "0x18289C700")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAEDD00", Offset = "0xAEC500", VA = "0x180AEDD00", Slot = "4")]
		public int GMMBJEKKABJ(int PNJCJGEIDHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700")]
		public bool MOAIDDFDKFP(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "5")]
		private bool KKNMBMKJJEB(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x289C6F0", Offset = "0x289AEF0", VA = "0x18289C6F0", Slot = "6")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> BLMCOHMCGEO(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct HOJGINNPJHG : GBJBINGOIPP<int, GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2897D00", Offset = "0x2896500", VA = "0x182897D00")]
		public GJEDEGEJPLA<int> NNCGJEEJEOM(int DJKGCLIFION, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2897D80", Offset = "0x2896580", VA = "0x182897D80")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2897C10", Offset = "0x2896410", VA = "0x182897C10", Slot = "6")]
		public void DNCCAGHFKLI(int PNJCJGEIDHG, GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD, DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2897D00", Offset = "0x2896500", VA = "0x182897D00", Slot = "4")]
		private GJEDEGEJPLA<int> JGPMKNBCCOH(int DJKGCLIFION, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2897D70", Offset = "0x2896570", VA = "0x182897D70", Slot = "5")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> NGLFMNJKODH(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct MEEFJAFIAMA : GNEDDJANEHC<int, GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2899F20", Offset = "0x2898720", VA = "0x182899F20")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAEDD00", Offset = "0xAEC500", VA = "0x180AEDD00", Slot = "4")]
		public int GMMBJEKKABJ(int PNJCJGEIDHG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700")]
		public bool MOAIDDFDKFP(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "5")]
		private bool KKNMBMKJJEB(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2899F10", Offset = "0x2898710", VA = "0x182899F10", Slot = "6")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> BLMCOHMCGEO(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct HJALAPFDONG : GBJBINGOIPP<int, GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2897890", Offset = "0x2896090", VA = "0x182897890")]
		public GJEDEGEJPLA<int> NNCGJEEJEOM(int DJKGCLIFION, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2897910", Offset = "0x2896110", VA = "0x182897910")]
		public DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2897790", Offset = "0x2895F90", VA = "0x182897790", Slot = "6")]
		public void DNCCAGHFKLI(int PNJCJGEIDHG, GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD, DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> MGONBEDEDON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2897890", Offset = "0x2896090", VA = "0x182897890", Slot = "4")]
		private GJEDEGEJPLA<int> JGPMKNBCCOH(int DJKGCLIFION, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(GJEDEGEJPLA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2897900", Offset = "0x2896100", VA = "0x182897900", Slot = "5")]
		private DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> NGLFMNJKODH(int PNJCJGEIDHG, [In] GJEDEGEJPLA<(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> Target, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ByteCodeWriteLocation)> IFMNLKCJNMD)
		{
			return default(DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct OMANBPLMAKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> DENKLPCKKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool GAPCIAAJKBC;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1F60660", Offset = "0x1F5EE60", VA = "0x181F60660")]
		public OMANBPLMAKH(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND, bool BPNLKKHOILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x289CF50", Offset = "0x289B750", VA = "0x18289CF50")]
		public void EBKFCGEKMKA([Out] DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND, [Out] bool BPNLKKHOILI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct BPMBBGLLNKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly DPJIAIFILPM<GNMEFCOMPFO> DAJIEGHGJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> DENKLPCKKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool GAPCIAAJKBC;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2891CC0", Offset = "0x28904C0", VA = "0x182891CC0")]
		public BPMBBGLLNKB(DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND, bool BPNLKKHOILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2891C90", Offset = "0x2890490", VA = "0x182891C90")]
		public void EBKFCGEKMKA([Out] DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND, [Out] bool BPNLKKHOILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2891CA0", Offset = "0x28904A0", VA = "0x182891CA0")]
		public void EBKFCGEKMKA([Out] DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND, [Out] DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN, [Out] bool BPNLKKHOILI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct NHDJMJPJMBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly DPJIAIFILPM<GNMEFCOMPFO> DAJIEGHGJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> DENKLPCKKDP;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xDC6C10", Offset = "0xDC5410", VA = "0x180DC6C10")]
		public NHDJMJPJMBJ(DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x289C820", Offset = "0x289B020", VA = "0x18289C820")]
		public void EBKFCGEKMKA([Out] DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND, [Out] DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x289BAD0", Offset = "0x289A2D0", VA = "0x18289BAD0")]
	public static void MMIAFMKGHIE(this IIJMPDEJAIF DKBBJFIDEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x289AB50", Offset = "0x2899350", VA = "0x18289AB50")]
	public static void FIJANAJHDCP(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<PFIGHJMHNHG> JNLKPBIMJDB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> NGPBLCMMOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x289A880", Offset = "0x2899080", VA = "0x18289A880")]
	public static void EMPMDHFANNH(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<PFIGHJMHNHG> JNLKPBIMJDB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> NGPBLCMMOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x289C5D0", Offset = "0x289ADD0", VA = "0x18289C5D0")]
	public static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>? PLIJOPAFICB([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<PFIGHJMHNHG> JNLKPBIMJDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x289C690", Offset = "0x289AE90", VA = "0x18289C690")]
	public static DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> PMBHICBPKFG([In] this IIJMPDEJAIF DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x289B130", Offset = "0x2899930", VA = "0x18289B130")]
	private static void JFLFDAHNBHB(this IIJMPDEJAIF DKBBJFIDEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x289A4E0", Offset = "0x2898CE0", VA = "0x18289A4E0")]
	private static DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>? CFLHMHPADNN([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x289B8D0", Offset = "0x289A0D0", VA = "0x18289B8D0")]
	public static void LFHGCOHCCHG(this IIJMPDEJAIF DKBBJFIDEGB, [In] GJEDEGEJPLA<PALMFECNECE> PGOEPAIDCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x289A780", Offset = "0x2898F80", VA = "0x18289A780")]
	public static AOMHHJJJCII.IPPGPFFFDOE DHALLNDOGBG([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND)
	{
		return default(AOMHHJJJCII.IPPGPFFFDOE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x289B450", Offset = "0x2899C50", VA = "0x18289B450")]
	public static LBCPBJKCGNG<byte> JLLALLCPNEP([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND)
	{
		return default(LBCPBJKCGNG<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x289B6B0", Offset = "0x2899EB0", VA = "0x18289B6B0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> KKBAFGMNDBO([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x289A650", Offset = "0x2898E50", VA = "0x18289A650")]
	public static KGJKGFJIMIK DEFOBBIDBDM([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND)
	{
		return default(KGJKGFJIMIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEBB0", Offset = "0x3ADD3B0", VA = "0x183ADEBB0")]
	private static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> KBDMNLMAMCC<TMJoin>(this IIJMPDEJAIF DKBBJFIDEGB, AOMHHJJJCII.IPPGPFFFDOE KPIOAMAHGKA, DPJIAIFILPM<TMJoin> CNMCJDBBEDB) where TMJoin : AOMHHJJJCII.LBGBFNPCAOE
	{
		return default(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x289A2F0", Offset = "0x2898AF0", VA = "0x18289A2F0")]
	public static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> BBGDGFHKKKL(this IIJMPDEJAIF DKBBJFIDEGB, bool KMMMFDJAJEJ)
	{
		return default(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x289A950", Offset = "0x2899150", VA = "0x18289A950")]
	public static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> FEAJJFLBAEP(this IIJMPDEJAIF DKBBJFIDEGB, LBCPBJKCGNG<byte> LLNMEIMBBLB)
	{
		return default(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x289B630", Offset = "0x2899E30", VA = "0x18289B630")]
	public static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> KICCLEILBCJ(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> GKGGCKGEJJA)
	{
		return default(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x289A460", Offset = "0x2898C60", VA = "0x18289A460")]
	public static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> BGLEDCGHHDP(this IIJMPDEJAIF DKBBJFIDEGB, int HBFEGOPOJLP)
	{
		return default(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x289C190", Offset = "0x289A990", VA = "0x18289C190")]
	public static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> NCKBOGMACAB(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOKLIJDLKOG)
	{
		return default(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEA00", Offset = "0x3ADD200", VA = "0x183ADEA00")]
	private static DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC> GIBIHNAFLLM<TMJoin>(this IIJMPDEJAIF DKBBJFIDEGB, GLBFAOHMKOA.ELBMDOPPPPO KPIOAMAHGKA, DPJIAIFILPM<TMJoin> CNMCJDBBEDB) where TMJoin : GLBFAOHMKOA.OAPNPFGDKOE
	{
		return default(DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x289A740", Offset = "0x2898F40", VA = "0x18289A740")]
	public static DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC> DFBMABMAPHH(this IIJMPDEJAIF DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x289C270", Offset = "0x289AA70", VA = "0x18289C270")]
	public static DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC> OLIIEJOFDGC(this IIJMPDEJAIF DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x289A9E0", Offset = "0x28991E0", VA = "0x18289A9E0")]
	public static DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC> FGANKNMBKDL(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> CJCKLCPJOCF)
	{
		return default(DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x289B540", Offset = "0x2899D40", VA = "0x18289B540")]
	public static DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC> JMPJPLPPKKJ(this IIJMPDEJAIF DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x289B590", Offset = "0x2899D90", VA = "0x18289B590")]
	public static DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC> KBNLKBJEIFJ(this IIJMPDEJAIF DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x289A800", Offset = "0x2899000", VA = "0x18289A800")]
	public static AFEEIPNLLKF.AKGOJBAMKCM ELFIMFMEEBD([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL> FAMPCPFEHCE)
	{
		return default(AFEEIPNLLKF.AKGOJBAMKCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x289B7A0", Offset = "0x2899FA0", VA = "0x18289B7A0")]
	public static CNJPGMIIFBK<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>, EHPENEOPJED<AFEEIPNLLKF.AOKDNLHPEPC>> KOCLDAKAPHJ([In] this IIJMPDEJAIF DKBBJFIDEGB)
	{
		return default(CNJPGMIIFBK<DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>, EHPENEOPJED<AFEEIPNLLKF.AOKDNLHPEPC>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x289C2C0", Offset = "0x289AAC0", VA = "0x18289C2C0")]
	public static DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> OMJLCPKFPJL([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL> FAMPCPFEHCE)
	{
		return default(DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x289ADB0", Offset = "0x28995B0", VA = "0x18289ADB0")]
	public static AFEEIPNLLKF.FMDNDLGBOPF HLBLGAHDOPI([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> CICJGOHCMEH)
	{
		return default(AFEEIPNLLKF.FMDNDLGBOPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x289A0E0", Offset = "0x28988E0", VA = "0x18289A0E0")]
	public static AFEEIPNLLKF.FMDNDLGBOPF APLONCHJBDM(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> CICJGOHCMEH)
	{
		return default(AFEEIPNLLKF.FMDNDLGBOPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEC60", Offset = "0x3ADD460", VA = "0x183ADEC60")]
	private static DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL> MHIJEBGDPGI<TMJoin>(this IIJMPDEJAIF DKBBJFIDEGB, AFEEIPNLLKF.AKGOJBAMKCM KPIOAMAHGKA, DPJIAIFILPM<TMJoin> CNMCJDBBEDB) where TMJoin : AFEEIPNLLKF.MMDCEKKOHDG
	{
		return default(DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x289AF80", Offset = "0x2899780", VA = "0x18289AF80")]
	public static (DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>) IOIFDOEDMIA(this IIJMPDEJAIF DKBBJFIDEGB)
	{
		return default((DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x289B2A0", Offset = "0x2899AA0", VA = "0x18289B2A0")]
	public static (DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>) JHPDHEGBLDD(this IIJMPDEJAIF DKBBJFIDEGB)
	{
		return default((DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x289B5E0", Offset = "0x2899DE0", VA = "0x18289B5E0")]
	public static DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL> KGOCPOBDBAK(this IIJMPDEJAIF DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x289BA40", Offset = "0x289A240", VA = "0x18289BA40")]
	public static void LHDBIIFEKGO(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC> CICJGOHCMEH, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> BFOIKAFBINC, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>> IPBAGGMLCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEDD0", Offset = "0x3ADD5D0", VA = "0x183ADEDD0")]
	public static OMANBPLMAKH PCBMAHNBBGC<TDeps, TStateSys>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN) where TDeps : EODADFMLLEA<TStateSys>
	{
		return default(OMANBPLMAKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3ADDD60", Offset = "0x3ADC560", VA = "0x183ADDD60")]
	public static BPMBBGLLNKB CHJCLKAKKPO<TDeps, TStateSys>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<NCBBKKLBDCC> IBMDEKLDACD, int APDCDBMOPOI) where TDeps : EODADFMLLEA<TStateSys>
	{
		return default(BPMBBGLLNKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3ADE5C0", Offset = "0x3ADCDC0", VA = "0x183ADE5C0")]
	public static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>? DNOJJNDAHNK<TDeps, TStateSys>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<NCBBKKLBDCC> IBMDEKLDACD, [In] ReadOnlySpan<int> IPGJGEAPFFA, [In] Span<NHDJMJPJMBJ> OIDNJBHFDMG) where TDeps : EODADFMLLEA<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3ADE000", Offset = "0x3ADC800", VA = "0x183ADE000")]
	public static DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC> DGIKJEFHBED<TDeps, TStateSys>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<PFIGHJMHNHG> JNLKPBIMJDB) where TDeps : EODADFMLLEA<TStateSys>
	{
		return default(DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x289C0A0", Offset = "0x289A8A0", VA = "0x18289C0A0")]
	public static LCJEFGCIPPJ.CJJDCEKFEBH NBBCGLHLFGI([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EBHOIBHGECB)
	{
		return default(LCJEFGCIPPJ.CJJDCEKFEBH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x289AA60", Offset = "0x2899260", VA = "0x18289AA60")]
	public static LCJEFGCIPPJ.EFHEAEALLFJ FIGEGJJNNAO([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EBHOIBHGECB)
	{
		return default(LCJEFGCIPPJ.EFHEAEALLFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x289A370", Offset = "0x2898B70", VA = "0x18289A370")]
	public static LCJEFGCIPPJ.LENHJNKGHEG BGEMBOGDBGC([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EBHOIBHGECB)
	{
		return default(LCJEFGCIPPJ.LENHJNKGHEG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x289A160", Offset = "0x2898960", VA = "0x18289A160")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> BAFHBBCHFML(this IIJMPDEJAIF DKBBJFIDEGB, int? ALBKILFBGFI, string HPANEBBHGAC)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x289B7E0", Offset = "0x2899FE0", VA = "0x18289B7E0")]
	public static LCJEFGCIPPJ.CJHBFKKIPBN LBFHLHEFHDK([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EBHOIBHGECB)
	{
		return default(LCJEFGCIPPJ.CJHBFKKIPBN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x289A070", Offset = "0x2898870", VA = "0x18289A070")]
	public static LCJEFGCIPPJ.AEIPGNMGIAF ADEEFHJPCKO([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EBHOIBHGECB)
	{
		return default(LCJEFGCIPPJ.AEIPGNMGIAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x289AD40", Offset = "0x2899540", VA = "0x18289AD40")]
	public static int? HEAHFIHHILL([In] this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EBHOIBHGECB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3ADEAB0", Offset = "0x3ADD2B0", VA = "0x183ADEAB0")]
	private static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> IGNCMOHHFEO<TMJoin>(this IIJMPDEJAIF DKBBJFIDEGB, int? ALBKILFBGFI, LCJEFGCIPPJ.AEIPGNMGIAF KPIOAMAHGKA, DPJIAIFILPM<TMJoin> CNMCJDBBEDB) where TMJoin : LCJEFGCIPPJ.JCKEGAPJGFC
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x289A5A0", Offset = "0x2898DA0", VA = "0x18289A5A0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> CIHIJPKMAFD(this IIJMPDEJAIF DKBBJFIDEGB, int? ALBKILFBGFI, DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL> FAMPCPFEHCE, int PNJCJGEIDHG)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x289C210", Offset = "0x289AA10", VA = "0x18289C210")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> OFNEOLILOJF(this IIJMPDEJAIF DKBBJFIDEGB, int? ALBKILFBGFI)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x289AE30", Offset = "0x2899630", VA = "0x18289AE30")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> IJEKNHOHPHE(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>? NKDGAPGBNBD, int? ALBKILFBGFI)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x289C010", Offset = "0x289A810", VA = "0x18289C010")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NAEDPHOECNH(this IIJMPDEJAIF DKBBJFIDEGB, int? ALBKILFBGFI, int PNJCJGEIDHG)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x289C570", Offset = "0x289AD70", VA = "0x18289C570")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> PJGEBMNLFMM(this IIJMPDEJAIF DKBBJFIDEGB, int? ALBKILFBGFI)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x289BDA0", Offset = "0x289A5A0", VA = "0x18289BDA0")]
	public static void MOEMMEFCBMD(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOKLIJDLKOG, DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL> FAMPCPFEHCE, int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x289BEE0", Offset = "0x289A6E0", VA = "0x18289BEE0")]
	public static void MPPBDKGOEMM(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOKLIJDLKOG, int PNJCJGEIDHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x289ABE0", Offset = "0x28993E0", VA = "0x18289ABE0")]
	public static void FKDFDBBLHHA(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOKLIJDLKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x289ACB0", Offset = "0x28994B0", VA = "0x18289ACB0")]
	public static void GBPNNOCLHHO(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> OLBBKGLINIK, DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> IELDANLCJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x289C4A0", Offset = "0x289ACA0", VA = "0x18289C4A0")]
	public static void PFHMMFHEHGB(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOKLIJDLKOG, DPJIAIFILPM<PFNHDDPMOMF<LKOIAFBFCMJ>> ONKDKBIEBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3ADED00", Offset = "0x3ADD500", VA = "0x183ADED00")]
	public static void NPPLELMEPLJ<M>(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOKLIJDLKOG, DPJIAIFILPM<PFNHDDPMOMF<GHOAHPDFPIH<M>>> ONKDKBIEBIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface EODADFMLLEA<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DPJIAIFILPM<CCHCFBIDMLI> EGJDFFBCJCP(TStateSys OFFEKODFNEP);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DPJIAIFILPM<CCHCFBIDMLI> IODFADGPHHB(TStateSys OFFEKODFNEP);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPJIAIFILPM<CCHCFBIDMLI> EIOMICCGGDG(TStateSys OFFEKODFNEP);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DPJIAIFILPM<CCHCFBIDMLI> PFHCLAPKAHD(TStateSys OFFEKODFNEP);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC> MJHCEINJCBJ(TStateSys OFFEKODFNEP, IIJMPDEJAIF PHJAMFIDJNA, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> LBABCLFGMMF(TStateSys OFFEKODFNEP, IIJMPDEJAIF PHJAMFIDJNA, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<PFIGHJMHNHG> JNLKPBIMJDB);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int OHIMDFIELDA(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DPJIAIFILPM<PFIGHJMHNHG> BNBHDPOIENK(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN, int ONBMMAMINCF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EHIFDANGIKM PEFKNHAGENM(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DEJPACMMOCG(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int COCAKFHPDMD(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LBCPBJKCGNG<byte> KCPHMHKMGFF(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(LBCPBJKCGNG<byte>, DPJIAIFILPM<CCHCFBIDMLI>) OKHEKCHHHLO(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<GNMEFCOMPFO> DLGMHMNHANN);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int JIPHBCLFICF(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<PFIGHJMHNHG> JNLKPBIMJDB);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	DPJIAIFILPM<GNMEFCOMPFO> OOFPCMDBOHN(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<PFIGHJMHNHG> JNLKPBIMJDB, int APDCDBMOPOI);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	DPJIAIFILPM<GNMEFCOMPFO> HNLNOGMODKG(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<NCBBKKLBDCC> IBMDEKLDACD, int APDCDBMOPOI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int MJBGOKBJHMO(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? PELHCOMEMIP(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, int PNJCJGEIDHG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int GEPOMONKMMB(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? EFMGDHGAIHL(TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, int PNJCJGEIDHG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GBOMKBILPOA
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x39DF0B0", Offset = "0x39DD8B0", VA = "0x1839DF0B0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP?> AJJKFOLONPC<T, TOpInput, TOpOutput>(this IIJMPDEJAIF DKBBJFIDEGB, T NOGJAHKGFJD, T LHMEHOJLNDH, int FEMLLEAAAEJ, IntPtr LMHFEGIMILF)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x39E1430", Offset = "0x39DFC30", VA = "0x1839E1430")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP?> HONOADOFEIM<T, TOpInput, TOpOutput>(this IIJMPDEJAIF DKBBJFIDEGB, T NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH, int FEMLLEAAAEJ, IntPtr LMHFEGIMILF)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x39E19E0", Offset = "0x39E01E0", VA = "0x1839E19E0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP?> KBECOHHPADO<TOpInput, TOpOutput>(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH, int FEMLLEAAAEJ, IntPtr LMHFEGIMILF)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2893F70", Offset = "0x2892770", VA = "0x182893F70")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> ELJKCMIJAOA(this IIJMPDEJAIF DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2893AE0", Offset = "0x28922E0", VA = "0x182893AE0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EHENANMJADP(this IIJMPDEJAIF DKBBJFIDEGB, float FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2893660", Offset = "0x2891E60", VA = "0x182893660")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EDAKIGDMIKB(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2895880", Offset = "0x2894080", VA = "0x182895880")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JFBBHPOCLAM(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2896E20", Offset = "0x2895620", VA = "0x182896E20")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NJCAIOIMFFL(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2892F70", Offset = "0x2891770", VA = "0x182892F70")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> CDLDGLPPAMD(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2894760", Offset = "0x2892F60", VA = "0x182894760")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> GGMNLCOLHOJ(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2896170", Offset = "0x2894970", VA = "0x182896170")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> KOPMNLLBDOB(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2893D40", Offset = "0x2892540", VA = "0x182893D40")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EKNCIKHLCCD(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2894430", Offset = "0x2892C30", VA = "0x182894430")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FGDGIDBACFP(this IIJMPDEJAIF DKBBJFIDEGB, int NOGJAHKGFJD, int LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2894270", Offset = "0x2892A70", VA = "0x182894270")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FADNHIKHGPJ(this IIJMPDEJAIF DKBBJFIDEGB, int NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x28931C0", Offset = "0x28919C0", VA = "0x1828931C0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> CKJMMNBGAGJ(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x28937A0", Offset = "0x2891FA0", VA = "0x1828937A0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EFIIPNMEFII(this IIJMPDEJAIF DKBBJFIDEGB, float NOGJAHKGFJD, float LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2895F40", Offset = "0x2894740", VA = "0x182895F40")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> KIPIOOMNPNH(this IIJMPDEJAIF DKBBJFIDEGB, float NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2896B30", Offset = "0x2895330", VA = "0x182896B30")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NGDNKNJLBIE(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x28969B0", Offset = "0x28951B0", VA = "0x1828969B0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LLDOHJJPLJC(this IIJMPDEJAIF DKBBJFIDEGB, int NOGJAHKGFJD, int LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2894860", Offset = "0x2893060", VA = "0x182894860")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> GIKGJCNBJPA(this IIJMPDEJAIF DKBBJFIDEGB, int NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2892480", Offset = "0x2890C80", VA = "0x182892480")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> BDDHEEFCPEK(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x28945B0", Offset = "0x2892DB0", VA = "0x1828945B0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FJCCKDLAFOI(this IIJMPDEJAIF DKBBJFIDEGB, float NOGJAHKGFJD, float LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x28935E0", Offset = "0x2891DE0", VA = "0x1828935E0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EAJHBMLDDPA(this IIJMPDEJAIF DKBBJFIDEGB, float NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2895800", Offset = "0x2894000", VA = "0x182895800")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JDIGKNCIBIP(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2896290", Offset = "0x2894A90", VA = "0x182896290")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> KPIBNKLIDCC(this IIJMPDEJAIF DKBBJFIDEGB, int NOGJAHKGFJD, int LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2892EF0", Offset = "0x28916F0", VA = "0x182892EF0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> CCNHBOKHIJK(this IIJMPDEJAIF DKBBJFIDEGB, int NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2893420", Offset = "0x2891C20", VA = "0x182893420")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> DNIAINHEPKK(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2895780", Offset = "0x2893F80", VA = "0x182895780")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> IGKMELPHHPF(this IIJMPDEJAIF DKBBJFIDEGB, float NOGJAHKGFJD, float LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2892BC0", Offset = "0x28913C0", VA = "0x182892BC0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> CAMOGNCKOEI(this IIJMPDEJAIF DKBBJFIDEGB, float NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2894530", Offset = "0x2892D30", VA = "0x182894530")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FJAOLBIJJJP(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2896C70", Offset = "0x2895470", VA = "0x182896C70")]
	public static DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> NINKKGHAHCH(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2894B50", Offset = "0x2893350", VA = "0x182894B50")]
	public static DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> GLGLHGJFGEP(this IIJMPDEJAIF DKBBJFIDEGB, int MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2894390", Offset = "0x2892B90", VA = "0x182894390")]
	public static DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> FDEENCCBLBF(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2892C40", Offset = "0x2891440", VA = "0x182892C40")]
	public static DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> CBOOJLAHOJC(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> MGJCANKGPND)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2897060", Offset = "0x2895860", VA = "0x182897060")]
	public static DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> NMNHGLLDBBG(this IIJMPDEJAIF DKBBJFIDEGB, int MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x28970E0", Offset = "0x28958E0", VA = "0x1828970E0")]
	public static DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> ODDOOJFOGKL(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> MGONBEDEDON)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2894C90", Offset = "0x2893490", VA = "0x182894C90")]
	public static (DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>) HFPCOCLKJKK(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<GLIIMLJLBGC> OONBOKIBHLL, [In] ReadOnlySpan<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> FKIDLMLIFPK, [In] ReadOnlySpan<int?> HFONBHLAEGK, [In] Span<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> DKDLBFBLING)
	{
		return default((DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2895340", Offset = "0x2893B40", VA = "0x182895340")]
	public static (DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>) HJLMBOJOHPJ(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<HJCIKCOKJHA> PAKPNNDKOIF, [In] ReadOnlySpan<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> FKIDLMLIFPK, [In] ReadOnlySpan<int?> HFONBHLAEGK, [In] Span<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> DKDLBFBLING)
	{
		return default((DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x39DF3B0", Offset = "0x39DDBB0", VA = "0x1839DF3B0")]
	public static (DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<CCHCFBIDMLI>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<TMarker>>, DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>) APBFPMFIINM<TMarker>(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<CCHCFBIDMLI> AOMDHFHBPPF, [In] ReadOnlySpan<byte> IMINNNCPCJF)
	{
		return default((DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<PFNHDDPMOMF<CCHCFBIDMLI>>, DPJIAIFILPM<PFNHDDPMOMF<EIIOPMEMHJA>>, DPJIAIFILPM<PFNHDDPMOMF<TMarker>>, DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2894BD0", Offset = "0x28933D0", VA = "0x182894BD0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> GPKBHMHIOLJ(this IIJMPDEJAIF DKBBJFIDEGB, int JPGKLKLGGMN, [Optional] DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>? OOGMCHHLIPA)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2892390", Offset = "0x2890B90", VA = "0x182892390")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> AOMPOODGKPA(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JPGKLKLGGMN, [Optional] DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>? OOGMCHHLIPA)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2893E80", Offset = "0x2892680", VA = "0x182893E80")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EKNOANOBIED(this IIJMPDEJAIF DKBBJFIDEGB, [In] ReadOnlySpan<byte> JPGKLKLGGMN, [Optional] DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>? OOGMCHHLIPA)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2896770", Offset = "0x2894F70", VA = "0x182896770")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LGCMCHCCJLA(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JPGKLKLGGMN, int GGIJOHIPOOO, [Optional] DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>? OOGMCHHLIPA)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2892DF0", Offset = "0x28915F0", VA = "0x182892DF0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> CBPNEGPHJEO(this IIJMPDEJAIF DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x28965D0", Offset = "0x2894DD0", VA = "0x1828965D0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LBIJBLNGDFE(this IIJMPDEJAIF DKBBJFIDEGB, float FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x28948E0", Offset = "0x28930E0", VA = "0x1828948E0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> GKCLMJBKGMK(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2895220", Offset = "0x2893A20", VA = "0x182895220")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> HHKEIMOOBCJ(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x28972C0", Offset = "0x2895AC0", VA = "0x1828972C0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> OJFADEODHIG(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x28973E0", Offset = "0x2895BE0", VA = "0x1828973E0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> PGIBOHFIBHI(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x28966F0", Offset = "0x2894EF0", VA = "0x1828966F0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LFHCEDBOJLH(this IIJMPDEJAIF DKBBJFIDEGB, int NOGJAHKGFJD, int LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2892840", Offset = "0x2891040", VA = "0x182892840")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> BMIIFKBMHOJ(this IIJMPDEJAIF DKBBJFIDEGB, int NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2896410", Offset = "0x2894C10", VA = "0x182896410")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> KPNLPJDCCIM(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOGJAHKGFJD, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LHMEHOJLNDH)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2894070", Offset = "0x2892870", VA = "0x182894070")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EMLPECLKJCK(this IIJMPDEJAIF DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2894630", Offset = "0x2892E30", VA = "0x182894630")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> GBMLLGCOPGO(this IIJMPDEJAIF DKBBJFIDEGB, float FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x28934A0", Offset = "0x2891CA0", VA = "0x1828934A0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> DNMFLLHMJII(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2896A30", Offset = "0x2895230", VA = "0x182896A30")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> MBLLEFJNFCM(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2896890", Offset = "0x2895090", VA = "0x182896890")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> LKPLEFJDEKC(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x28950E0", Offset = "0x28938E0", VA = "0x1828950E0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> HGFFKDELMAN(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2895320", Offset = "0x2893B20", VA = "0x182895320")]
	public static DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>> HIPNIJHDCGF(this IIJMPDEJAIF DKBBJFIDEGB)
	{
		return default(DPJIAIFILPM<PFNHDDPMOMF<PFNHDDPMOMF<NFHBLMMELNO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2895AC0", Offset = "0x28942C0", VA = "0x182895AC0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JOLIJJNLHBE(this IIJMPDEJAIF DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2892720", Offset = "0x2890F20", VA = "0x182892720")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> BFPOMJLNFDP(this IIJMPDEJAIF DKBBJFIDEGB, float FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2896490", Offset = "0x2894C90", VA = "0x182896490")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> KPPGJMJNGDN(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x28938A0", Offset = "0x28920A0", VA = "0x1828938A0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EGBPLJKCNHP(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2896F40", Offset = "0x2895740", VA = "0x182896F40")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NLAMPDECDHN(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x28939A0", Offset = "0x28921A0", VA = "0x1828939A0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EGMICJKDIJI(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2894170", Offset = "0x2892970", VA = "0x182894170")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EOCJBKPKMNG(this IIJMPDEJAIF DKBBJFIDEGB, int MGONBEDEDON)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x28930B0", Offset = "0x28918B0", VA = "0x1828930B0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> CEDPHMAOIFA(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> MGONBEDEDON)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x28950D0", Offset = "0x28938D0", VA = "0x1828950D0")]
	public static void HGAGAINPEHA(this IIJMPDEJAIF DKBBJFIDEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2896070", Offset = "0x2894870", VA = "0x182896070")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> KLMBPCJEIAI(this IIJMPDEJAIF DKBBJFIDEGB, float FDGFOMMHJHO, float JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2893300", Offset = "0x2891B00", VA = "0x182893300")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> DEJMEPODPBI(this IIJMPDEJAIF DKBBJFIDEGB, float FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2897180", Offset = "0x2895980", VA = "0x182897180")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> OHNGCLDCHPO(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2896310", Offset = "0x2894B10", VA = "0x182896310")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> KPKMGKGJNDD(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2892500", Offset = "0x2890D00", VA = "0x182892500")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> BDKOBJBOOJA(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2893C00", Offset = "0x2892400", VA = "0x182893C00")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EIILHLLAAJP(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2895BC0", Offset = "0x28943C0", VA = "0x182895BC0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> KBIFOGEJAPE(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> GIKCMBIFIEF, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> OCFHMALOBMM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2892620", Offset = "0x2890E20", VA = "0x182892620")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> BFINMOMCDCA(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, int JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2897520", Offset = "0x2895D20", VA = "0x182897520")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> PIEDPNBNAFF(this IIJMPDEJAIF DKBBJFIDEGB, int FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2895980", Offset = "0x2894180", VA = "0x182895980")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JFMGBAHFDLB(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> FDGFOMMHJHO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JAEFIGHHDIM)
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x39E0E90", Offset = "0x39DF690", VA = "0x1839E0E90")]
	public static void HKJNMGBCLPF<TDeps, TState>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TState OJGLGPLNKGO, DPJIAIFILPM<GLIIMLJLBGC> OONBOKIBHLL, [In] ReadOnlySpan<DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>> JAMNDFGGGNC, [In] ReadOnlySpan<int?> HFONBHLAEGK, [In] Span<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> DKDLBFBLING, [In] Span<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> JCEPIAOHOGB, [In] ReadOnlySpan<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>?> CBEMPOIKNIF) where TDeps : notnull, EODADFMLLEA<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x39DF4B0", Offset = "0x39DDCB0", VA = "0x1839DF4B0")]
	public static void BGCLICPMAKB<TDeps, TState>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TState OJGLGPLNKGO, DPJIAIFILPM<HJCIKCOKJHA> OHENIKPHLCF, [In] ReadOnlySpan<DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>> PHPMKGGFIGO, [In] ReadOnlySpan<int?> HFONBHLAEGK, [In] Span<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> DKDLBFBLING, [In] Span<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>> JCEPIAOHOGB, [In] ReadOnlySpan<DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>?> CBEMPOIKNIF) where TDeps : notnull, EODADFMLLEA<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x39E0900", Offset = "0x39DF100", VA = "0x1839E0900")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> GCMBKNIBIOD<TDeps, TState>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TState OJGLGPLNKGO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NKDGAPGBNBD, [Optional] DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>? OOGMCHHLIPA) where TDeps : notnull, EODADFMLLEA<TState> where TState : notnull
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x39DFA50", Offset = "0x39DE250", VA = "0x1839DFA50")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> BJDNEEBJEHN<TDeps, TState>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TState OJGLGPLNKGO, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> CJCKLCPJOCF, [Optional] DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>? OOGMCHHLIPA) where TDeps : notnull, EODADFMLLEA<TState> where TState : notnull
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x39DEE80", Offset = "0x39DD680", VA = "0x1839DEE80")]
	public static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> ACPNICAGAFK<TDeps, TStateSys>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TStateSys OFFEKODFNEP) where TDeps : notnull, EODADFMLLEA<TStateSys> where TStateSys : notnull
	{
		return default(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x39E17D0", Offset = "0x39DFFD0", VA = "0x1839E17D0")]
	public static DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC> IMEIOCKCMIC<TDeps, TStateSys>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TStateSys OFFEKODFNEP) where TDeps : notnull, EODADFMLLEA<TStateSys> where TStateSys : notnull
	{
		return default(DPJIAIFILPM<GLBFAOHMKOA.EAFHLFJKADC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2894A20", Offset = "0x2893220", VA = "0x182894A20")]
	public static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> GKIANGGLHLK(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> LDOLMHKEJAD, IntPtr JHHGIJGFIAF, IntPtr GFKKDHOLKAP)
	{
		return default(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x28928C0", Offset = "0x28910C0", VA = "0x1828928C0")]
	public static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> BOJDJGJNMLK(this IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> AJMHBOHKCDD, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> HHBEAEEFKKJ, IntPtr LCLNFAAPLJN, IntPtr NEDGABDDLEE, IntPtr OGBPMPIOPKK, bool KLMPINGJEJG)
	{
		return default(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x39DFEB0", Offset = "0x39DE6B0", VA = "0x1839DFEB0")]
	public static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> CDCBLDPPKAA<TDeps, TState>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TState OJGLGPLNKGO, DPJIAIFILPM<GLIIMLJLBGC> PKAAADPKGNP, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> AJMHBOHKCDD, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> HHBEAEEFKKJ, int? DLMIAAFJHDH, [Optional] IntPtr INDMHKNAPGP) where TDeps : notnull, EODADFMLLEA<TState> where TState : notnull
	{
		return default(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x39E00C0", Offset = "0x39DE8C0", VA = "0x1839E00C0")]
	private static DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> CDCBLDPPKAA<TDeps, TState>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TState OJGLGPLNKGO, DPJIAIFILPM<GLIIMLJLBGC> PKAAADPKGNP, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> AJMHBOHKCDD, DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP> HHBEAEEFKKJ, int? DLMIAAFJHDH) where TDeps : notnull, EODADFMLLEA<TState> where TState : notnull
	{
		return default(DPJIAIFILPM<AOMHHJJJCII.FEOOIOJDEEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x39E0AE0", Offset = "0x39DF2E0", VA = "0x1839E0AE0")]
	public static DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> GPLCAMNDGGJ<TDeps, TState>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TState OJGLGPLNKGO, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> JPGKLKLGGMN, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>? OOGMCHHLIPA) where TDeps : notnull, EODADFMLLEA<TState> where TState : notnull
	{
		return default(DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x39E1B50", Offset = "0x39E0350", VA = "0x1839E1B50")]
	public static void MNPKHJIFFIM<TDeps, TState>(this IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TState OJGLGPLNKGO, int GHGOCAMACOC) where TDeps : notnull, EODADFMLLEA<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct AFPIIJBJIEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> HPBLOBOPAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> CEFFFNCFFJM;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xDC6C10", Offset = "0xDC5410", VA = "0x180DC6C10")]
	public AFPIIJBJIEJ(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> LKHDJNLBHMJ, DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> EIOAHKJGEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2891660", Offset = "0x288FE60", VA = "0x182891660")]
	public static AFPIIJBJIEJ CCPKJDCALBG(DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>> LKHDJNLBHMJ)
	{
		return default(AFPIIJBJIEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct LCJEFGCIPPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class HJOIEDLJFFE : JCKEGAPJGFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct CJJDCEKFEBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL> BBIOCLJLKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int PJLMPJGAPPO;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xDC6C10", Offset = "0xDC5410", VA = "0x180DC6C10")]
		public CJJDCEKFEBH(DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL> FAMPCPFEHCE, int PNJCJGEIDHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class EGMLMHKGMLG : JCKEGAPJGFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct EFHEAEALLFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int PJLMPJGAPPO;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		public EFHEAEALLFJ(int PNJCJGEIDHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class BCFINEHOKMB : JCKEGAPJGFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct LENHJNKGHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL> BBIOCLJLKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int PJLMPJGAPPO;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xDC6C10", Offset = "0xDC5410", VA = "0x180DC6C10")]
		public LENHJNKGHEG(DPJIAIFILPM<AFEEIPNLLKF.MKEHCGDMJNL> FAMPCPFEHCE, int PNJCJGEIDHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum AEIPGNMGIAF
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
	public sealed class NJHEAGNCBAP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class JCKEGAPJGFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct DDEDGFBKJHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? EHAMGMKFOBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AFPIIJBJIEJ BLBCJEPFLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AEIPGNMGIAF FLGLJEOENFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public DPJIAIFILPM<JCKEGAPJGFC> JBMIJNJEEPB;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2891D50", Offset = "0x2890550", VA = "0x182891D50")]
		public DDEDGFBKJHL(int? ALBKILFBGFI, [In] AFPIIJBJIEJ FPFOMOCJIHD, AEIPGNMGIAF KPIOAMAHGKA, DPJIAIFILPM<JCKEGAPJGFC> CNMCJDBBEDB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class EPAHDIDKNOF : JCKEGAPJGFC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct CJHBFKKIPBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int PJLMPJGAPPO;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		public CJHBFKKIPBN(int PNJCJGEIDHG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal MKJCPDNALDO<NJHEAGNCBAP, DDEDGFBKJHL> CMENKADFGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal MKJCPDNALDO<HJOIEDLJFFE, CJJDCEKFEBH> EPMIDBAPCJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal MKJCPDNALDO<BCFINEHOKMB, LENHJNKGHEG> NCJODIHEBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal MKJCPDNALDO<EPAHDIDKNOF, CJHBFKKIPBN> CBCMECGCHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal MKJCPDNALDO<EGMLMHKGMLG, EFHEAEALLFJ> ANEILMHIPIN;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2899CF0", Offset = "0x28984F0", VA = "0x182899CF0")]
	private LCJEFGCIPPJ([In] MKJCPDNALDO<NJHEAGNCBAP, DDEDGFBKJHL> ADHHBCNNPIN, [In] MKJCPDNALDO<HJOIEDLJFFE, CJJDCEKFEBH> HPKHNCNIDKE, [In] MKJCPDNALDO<BCFINEHOKMB, LENHJNKGHEG> JAPHHPBGFJM, [In] MKJCPDNALDO<EPAHDIDKNOF, CJHBFKKIPBN> DABAPHGPACF, [In] MKJCPDNALDO<EGMLMHKGMLG, EFHEAEALLFJ> MDOGHJAGAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2899B00", Offset = "0x2898300", VA = "0x182899B00")]
	public static LCJEFGCIPPJ CCPKJDCALBG()
	{
		return default(LCJEFGCIPPJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class AEHPLLNLKNA
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2891350", Offset = "0x288FB50", VA = "0x182891350")]
	public static void MMIAFMKGHIE(this LCJEFGCIPPJ DKBBJFIDEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NMHFKICJMJH
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x289C8E0", Offset = "0x289B0E0", VA = "0x18289C8E0")]
	public static void IHHPLANMBKM(IIJMPDEJAIF DKBBJFIDEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct NMOAGENHGIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, KGEJFPAEPKM> FBLLMFBBGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int GENDHHHGGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int BBJHFJPCEFP;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x289CCA0", Offset = "0x289B4A0", VA = "0x18289CCA0")]
	private NMOAGENHGIK([In] HFOFBJNAOJN<AFEEIPNLLKF.AOKDNLHPEPC, KGEJFPAEPKM> OLKGGAGNOKE, int GKEFMOADDPG, int NOPAANDGMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x289CA40", Offset = "0x289B240", VA = "0x18289CA40")]
	public static NMOAGENHGIK CCPKJDCALBG()
	{
		return default(NMOAGENHGIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x289CAB0", Offset = "0x289B2B0", VA = "0x18289CAB0")]
	public void MMIAFMKGHIE([In] IIJMPDEJAIF HEKEBEBCDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B4B1B0", Offset = "0x3B499B0", VA = "0x183B4B1B0")]
	public static void IHHPLANMBKM<TDeps, TStateSys>(IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TStateSys OFFEKODFNEP, DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML) where TDeps : notnull, EODADFMLLEA<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class FLDONIGFNMB
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x28920A0", Offset = "0x28908A0", VA = "0x1828920A0")]
	public static void IHHPLANMBKM(IIJMPDEJAIF DKBBJFIDEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct ELOGPCPAAPA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface PFHKABFOMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ODKCIONCAKB(GJEDEGEJPLA<byte> GMNCGHBIBAN, int COHGNMEIBDG);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct CLKDNFBDFKJ : PFHKABFOMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2891CD0", Offset = "0x28904D0", VA = "0x182891CD0", Slot = "4")]
		public void ODKCIONCAKB(GJEDEGEJPLA<byte> GMNCGHBIBAN, int COHGNMEIBDG)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct NKAEDGLDEKC : PFHKABFOMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x289C830", Offset = "0x289B030", VA = "0x18289C830", Slot = "4")]
		public void ODKCIONCAKB(GJEDEGEJPLA<byte> GMNCGHBIBAN, int COHGNMEIBDG)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct MNDFGKJLMEH : PFHKABFOMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x289C7A0", Offset = "0x289AFA0", VA = "0x18289C7A0", Slot = "4")]
		public void ODKCIONCAKB(GJEDEGEJPLA<byte> GMNCGHBIBAN, int COHGNMEIBDG)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct ICHEMLIMJMH : PFHKABFOMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2897E20", Offset = "0x2896620", VA = "0x182897E20", Slot = "4")]
		public void ODKCIONCAKB(GJEDEGEJPLA<byte> GMNCGHBIBAN, int COHGNMEIBDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class PIMJMNHDEBP<TCallProcessorDeps> where TCallProcessorDeps : struct, PFHKABFOMPB
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps OFNAGCEIFKB;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x41892C0", Offset = "0x4187AC0", VA = "0x1841892C0")]
		public static int IHHPLANMBKM<TDeps, TStateSys>(TDeps GGLINDGLEPB, TStateSys OJGLGPLNKGO, IIJMPDEJAIF HEKEBEBCDAB, [In] GJEDEGEJPLA<byte> HGBLFLIIBDJ, int NJNGIMABDDP) where TDeps : EODADFMLLEA<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private GJEDEGEJPLA<PALMFECNECE> JKAIKLOGJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>> GBHAIMNNHAD;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2891E70", Offset = "0x2890670", VA = "0x182891E70")]
	private ELOGPCPAAPA([In] GJEDEGEJPLA<PALMFECNECE> PGOEPAIDCHP, Dictionary<DPJIAIFILPM<PFNHDDPMOMF<NFHBLMMELNO>>, DPJIAIFILPM<AFEEIPNLLKF.AOKDNLHPEPC>> CNDKGIMAAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2891D70", Offset = "0x2890570", VA = "0x182891D70")]
	public static ELOGPCPAAPA CCPKJDCALBG()
	{
		return default(ELOGPCPAAPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2891E30", Offset = "0x2890630", VA = "0x182891E30")]
	public void MMIAFMKGHIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x38451B0", Offset = "0x38439B0", VA = "0x1838451B0")]
	public static void IHHPLANMBKM<TDeps, TStateSys>(IIJMPDEJAIF DKBBJFIDEGB, TDeps GGLINDGLEPB, TStateSys OFFEKODFNEP) where TDeps : EODADFMLLEA<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class KHEEMPBMFAF
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct MDFOCEDOBNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> NOKEFGMLINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int KNIIOEFDHFG;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int MJEHEPAECCK;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int BNJLPHOMOFO;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2899160", Offset = "0x2897960", VA = "0x182899160")]
	public static void IHHPLANMBKM(IIJMPDEJAIF DKBBJFIDEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2898FD0", Offset = "0x28977D0", VA = "0x182898FD0")]
	private static void FIGDOHCBJMK([In] IIJMPDEJAIF DKBBJFIDEGB, DPJIAIFILPM<LCJEFGCIPPJ.NJHEAGNCBAP> EBHOIBHGECB, GJEDEGEJPLA<byte> DJEAOKDFJCC, List<MDFOCEDOBNH> CECDKKEFIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2898E90", Offset = "0x2897690", VA = "0x182898E90")]
	private static void FIGDOHCBJMK(GJEDEGEJPLA<byte> DJEAOKDFJCC, int GGIJOHIPOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2899820", Offset = "0x2898020", VA = "0x182899820")]
	private static void KLCDCIFEHAF(IIJMPDEJAIF DKBBJFIDEGB, List<MDFOCEDOBNH> CECDKKEFIEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class EPAENCKCMGI<TDeps, TIndex, TValues> where TDeps : struct, GBJBINGOIPP<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps OFNAGCEIFKB;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x47552D0", Offset = "0x4753AD0", VA = "0x1847552D0")]
	public static void IHHPLANMBKM([In] GJEDEGEJPLA<PALMFECNECE> PGOEPAIDCHP, int DJKGCLIFION, TValues IFMNLKCJNMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface GBJBINGOIPP<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GJEDEGEJPLA<TIndex> NNCGJEEJEOM(int DJKGCLIFION, [In] TValues IFMNLKCJNMD);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(TIndex PNJCJGEIDHG, [In] TValues IFMNLKCJNMD);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNCCAGHFKLI(TIndex PNJCJGEIDHG, TValues IFMNLKCJNMD, DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> MGONBEDEDON);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface GNEDDJANEHC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex GMMBJEKKABJ(int PNJCJGEIDHG);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MOAIDDFDKFP(TIndex PNJCJGEIDHG, [In] TValues IFMNLKCJNMD);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPJIAIFILPM<PFNHDDPMOMF<DPNAIGBABBE>> PNFIBAMIGNE(TIndex PNJCJGEIDHG, [In] TValues IFMNLKCJNMD);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class FJAMIDEKLPJ<TDeps, TIndex, TValues> where TDeps : struct, GNEDDJANEHC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps OFNAGCEIFKB;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4BAE870", Offset = "0x4BAD070", VA = "0x184BAE870")]
	public static GJEDEGEJPLA<TIndex> IHHPLANMBKM(int DJKGCLIFION, [In] TValues IFMNLKCJNMD)
	{
		return default(GJEDEGEJPLA<TIndex>);
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
