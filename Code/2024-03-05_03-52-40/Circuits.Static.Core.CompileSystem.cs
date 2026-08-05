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
		[Cpp2IlInjected.Address(RVA = "0x7E3470", Offset = "0x7E2270", VA = "0x1807E3470")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1DBC850", Offset = "0x1DBB650", VA = "0x181DBC850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E43F0", Offset = "0x7E31F0", VA = "0x1807E43F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E4430", Offset = "0x7E3230", VA = "0x1807E4430")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MEMLLBFGJPN
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class LLMCLMGCCBB
	{
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal NFAJAPJFFDF<LLMCLMGCCBB> HGFACNJENIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal HALEKHNPJIF<LLMCLMGCCBB, object> HDKCJMICDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal Dictionary<object, GPIFJNELMMP<LLMCLMGCCBB>> JMAAPGKMILF;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DB60A0", Offset = "0x1DB4EA0", VA = "0x181DB60A0")]
	private MEMLLBFGJPN([In] NFAJAPJFFDF<LLMCLMGCCBB> LKKEDBNNCIF, [In] HALEKHNPJIF<LLMCLMGCCBB, object> NJDHENGKPDO, Dictionary<object, GPIFJNELMMP<LLMCLMGCCBB>> KOENOOEKIKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5E80", Offset = "0x1DB4C80", VA = "0x181DB5E80")]
	public static MEMLLBFGJPN IKCDCJJCDKO()
	{
		return default(MEMLLBFGJPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BEFLHJNKLKH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3400", Offset = "0x1DB2200", VA = "0x181DB3400")]
	public static void COJAMHJFIEG(this MEMLLBFGJPN OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3460", Offset = "0x1DB2260", VA = "0x181DB3460")]
	public static GPIFJNELMMP<MEMLLBFGJPN.LLMCLMGCCBB> ECAKBMHBGEC(this MEMLLBFGJPN OELHNDCFEMO, object KDHDNCADFDJ)
	{
		return default(GPIFJNELMMP<MEMLLBFGJPN.LLMCLMGCCBB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum FAPLJFKFLBH
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Bool,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Int,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Bytes,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Class
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct CENBGOBKEDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public FFPIJGBCMLA<int> PDOHJHEGJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public FFPIJGBCMLA<int> FFAHLDBEJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public int FCFLDHKBIKE;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3B20", Offset = "0x1DB2920", VA = "0x181DB3B20")]
	private CENBGOBKEDI([In] FFPIJGBCMLA<int> MJDJHBLDJIP, [In] FFPIJGBCMLA<int> OHHPHLJFHPD, int BMJOBBPNMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3A90", Offset = "0x1DB2890", VA = "0x181DB3A90")]
	public static CENBGOBKEDI IKCDCJJCDKO()
	{
		return default(CENBGOBKEDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class IJAAFDAGNMC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5220", Offset = "0x1DB4020", VA = "0x181DB5220")]
	public static void COJAMHJFIEG(this CENBGOBKEDI OELHNDCFEMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct MMCONGPKCIG
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public sealed class IDOAALMHJAK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum CFKIOHFKGEL
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		External
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct CGBPHFMJLLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public FFPIJGBCMLA<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> PDOHJHEGJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public FFPIJGBCMLA<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> FFAHLDBEJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public GPIFJNELMMP<FGAHPNBKCIK<PPBBFCHGLII>> CIIOJKDGLHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public CFKIOHFKGEL FAEBKGIBJLL;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3C10", Offset = "0x1DB2A10", VA = "0x181DB3C10")]
		private CGBPHFMJLLF([In] FFPIJGBCMLA<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> MJDJHBLDJIP, [In] FFPIJGBCMLA<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> OHHPHLJFHPD, GPIFJNELMMP<FGAHPNBKCIK<PPBBFCHGLII>> NECCLBJALAK, CFKIOHFKGEL CLHFLCCBOJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3B70", Offset = "0x1DB2970", VA = "0x181DB3B70")]
		public static CGBPHFMJLLF IKCDCJJCDKO(CFKIOHFKGEL CLHFLCCBOJO)
		{
			return default(CGBPHFMJLLF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal DKCIKNBBNIK<IDOAALMHJAK, CGBPHFMJLLF> EEJANFAECOO;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6180", Offset = "0x1DB4F80", VA = "0x181DB6180")]
	private MMCONGPKCIG([In] DKCIKNBBNIK<IDOAALMHJAK, CGBPHFMJLLF> NELBMGKONNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6110", Offset = "0x1DB4F10", VA = "0x181DB6110")]
	public static MMCONGPKCIG IKCDCJJCDKO()
	{
		return default(MMCONGPKCIG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BGDGLCOGMIE
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1DB36E0", Offset = "0x1DB24E0", VA = "0x181DB36E0")]
	public static void COJAMHJFIEG(this MMCONGPKCIG.CGBPHFMJLLF OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3730", Offset = "0x1DB2530", VA = "0x181DB3730")]
	public static void COJAMHJFIEG(this MMCONGPKCIG OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3A50", Offset = "0x1DB2850", VA = "0x181DB3A50")]
	public static NFAJAPJFFDF<MMCONGPKCIG.IDOAALMHJAK> HBFADDFCOFK([In] this MMCONGPKCIG OELHNDCFEMO)
	{
		return default(NFAJAPJFFDF<MMCONGPKCIG.IDOAALMHJAK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1DB38C0", Offset = "0x1DB26C0", VA = "0x181DB38C0")]
	public static GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> EBPHKEEDEKF(this MMCONGPKCIG OELHNDCFEMO)
	{
		return default(GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3550", Offset = "0x1DB2350", VA = "0x181DB3550")]
	public static GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> BEHMNHGKCIM(this MMCONGPKCIG OELHNDCFEMO)
	{
		return default(GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3660", Offset = "0x1DB2460", VA = "0x181DB3660")]
	public static void BJJLPKLNABD(this MMCONGPKCIG OELHNDCFEMO, GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> FJIJLBIGEAH, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CLPKPLPLPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1DB39D0", Offset = "0x1DB27D0", VA = "0x181DB39D0")]
	public static void EPGCODKEJIK(this MMCONGPKCIG OELHNDCFEMO, GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> FJIJLBIGEAH, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CLPKPLPLPPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct NCPJAKHBLLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public FFPIJGBCMLA<byte> KOBCIPHNOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public MMCONGPKCIG LJKHINIOHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public LBBJCNAPMEL JKPFLHOENCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal MEMLLBFGJPN IKIOLJEPGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal Dictionary<string, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> ENMJFKPPLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal HALEKHNPJIF<IHPNMOMBMAC, ADEHHGABOLD?> DJIPLCHBCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal FFPIJGBCMLA<GPIFJNELMMP<IHPNMOMBMAC>> OEGFLIGGFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal HALEKHNPJIF<BKCBFIPNEFB, GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>>?> KIECHMIMPIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal FFPIJGBCMLA<(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> VariableId, GPIFJNELMMP<FGAHPNBKCIK<FIOGNPNGOKP<DNFGOFFEMJG>>> ByteCodeWriteLocation, int Offset)> MAIBKAOGMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	internal FFPIJGBCMLA<(GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> Target, GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>> ByteCodeWriteLocation)> NPAGPNMLFJF;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1DBC5B0", Offset = "0x1DBB3B0", VA = "0x181DBC5B0")]
	private NCPJAKHBLLP([In] FFPIJGBCMLA<byte> EKFPLKGAMEA, [In] MMCONGPKCIG AOIIEGGMBON, [In] LBBJCNAPMEL BDBDMBGIOHO, [In] MEMLLBFGJPN CCEPMOJOFKK, [In] HALEKHNPJIF<IHPNMOMBMAC, ADEHHGABOLD?> HOPABOKFEDN, [In] FFPIJGBCMLA<GPIFJNELMMP<IHPNMOMBMAC>> JMAJNMGFLJH, [In] HALEKHNPJIF<BKCBFIPNEFB, GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>>?> DAKKFBKBKKJ, [In] FFPIJGBCMLA<(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> VariableId, GPIFJNELMMP<FGAHPNBKCIK<FIOGNPNGOKP<DNFGOFFEMJG>>> ByteCodeWriteLocation, int VariableOffset)> CPDPOPCLDKN, [In] FFPIJGBCMLA<(GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> Target, GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>> ByteCodeWriteLocation)> KAJDKJNCCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DBBE30", Offset = "0x1DBAC30", VA = "0x181DBBE30")]
	public static NCPJAKHBLLP IKCDCJJCDKO()
	{
		return default(NCPJAKHBLLP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FBNJFBBOIBF
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1DB42F0", Offset = "0x1DB30F0", VA = "0x181DB42F0")]
	public static void COJAMHJFIEG(this NCPJAKHBLLP OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5020", Offset = "0x1DB3E20", VA = "0x181DB5020")]
	public static GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> OLCJKEMFCHN(this NCPJAKHBLLP OELHNDCFEMO)
	{
		return default(GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x272CA90", Offset = "0x272B890", VA = "0x18272CA90")]
	public static void FMLIFOOPGII<M>(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CLPKPLPLPPO, GPIFJNELMMP<FGAHPNBKCIK<FIOGNPNGOKP<M>>> EJHIIPKMODH, int MOPCACFNEMP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4510", Offset = "0x1DB3310", VA = "0x181DB4510")]
	public static void DFBPGFCKMEP(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> EOCODFIAJEL, GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>> BLKNHGICENB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4AB0", Offset = "0x1DB38B0", VA = "0x181DB4AB0")]
	public static void JMJAPKLHIIF(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> OLAICIDMAFC, GPIFJNELMMP<FGAHPNBKCIK<PPBBFCHGLII>> NECCLBJALAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1DB46D0", Offset = "0x1DB34D0", VA = "0x181DB46D0")]
	public static void HHNJBAFFMEC(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CLPKPLPLPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4C80", Offset = "0x1DB3A80", VA = "0x181DB4C80")]
	public static void LHPAGFNFMGI(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<IHPNMOMBMAC> MKCJIMKGHPG, [In] ADEHHGABOLD DLAGAJIDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1DB45A0", Offset = "0x1DB33A0", VA = "0x181DB45A0")]
	public static void FDFGHKIPMDK(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<IHPNMOMBMAC> MKCJIMKGHPG, [In] ADEHHGABOLD DLAGAJIDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5130", Offset = "0x1DB3F30", VA = "0x181DB5130")]
	public static ADEHHGABOLD? PFIAKDMAHCD([In] this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<IHPNMOMBMAC> MKCJIMKGHPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x272F460", Offset = "0x272E260", VA = "0x18272F460")]
	public static ADEHHGABOLD PCNGJFIKMGD<TDeps, TStateSys>(this NCPJAKHBLLP OELHNDCFEMO, TDeps IKMKPNFBOIN, TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<BKCBFIPNEFB> NKFNLDOHMKN) where TDeps : JILJPBCJJFN<TStateSys>
	{
		return default(ADEHHGABOLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4B20", Offset = "0x1DB3920", VA = "0x181DB4B20")]
	private static void KNGBIFIGELC(this NCPJAKHBLLP OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4260", Offset = "0x1DB3060", VA = "0x181DB4260")]
	private static GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>>? AIKLKKMMJJD([In] this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<BKCBFIPNEFB> NKFNLDOHMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4D60", Offset = "0x1DB3B60", VA = "0x181DB4D60")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> NOKBDMCLJEI(this NCPJAKHBLLP OELHNDCFEMO, [In] string OCCHBLONHPL, int CGKDGFIFBAL)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x272CB70", Offset = "0x272B970", VA = "0x18272CB70")]
	public static EMJHLOKHGIJ GFDNKFCFEBP<TDeps, TStateSys>(this NCPJAKHBLLP OELHNDCFEMO, TDeps IKMKPNFBOIN, TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<IHPNMOMBMAC> MKCJIMKGHPG) where TDeps : JILJPBCJJFN<TStateSys>
	{
		return default(EMJHLOKHGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4950", Offset = "0x1DB3750", VA = "0x181DB4950")]
	public static void JHFHCDCMHJH(this NCPJAKHBLLP OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x272D190", Offset = "0x272BF90", VA = "0x18272D190")]
	public static int HKAPPFNAMHN<TDeps, TStateSys>(this NCPJAKHBLLP OELHNDCFEMO, TDeps IKMKPNFBOIN, TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, HALEKHNPJIF<MMCONGPKCIG.IDOAALMHJAK, CENBGOBKEDI> CCJENOOGKII) where TDeps : JILJPBCJJFN<TStateSys>
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1DB4780", Offset = "0x1DB3580", VA = "0x181DB4780")]
	public static void JHELKCFNNAL(this NCPJAKHBLLP OELHNDCFEMO, [In] HALEKHNPJIF<MMCONGPKCIG.IDOAALMHJAK, CENBGOBKEDI> EJLANHIIJNO, int BMCJMBEGDHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct ADEHHGABOLD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum LPFNBDDBJKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Register
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public readonly struct LNDKNAIIIOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> DILFCCOGCOM;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
		public LNDKNAIIIOD(GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> EKHBMCJDMOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct DAKENPFNPGN : IEquatable<DAKENPFNPGN>, CFGACMJPKMC<DAKENPFNPGN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public ReadOnlyMemory<byte> GPNCEMPCBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public IGNEGBKHMPD KJAMACAAJNF;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1DB4230", Offset = "0x1DB3030", VA = "0x181DB4230")]
		private DAKENPFNPGN([In] ReadOnlyMemory<byte> HCFBAPHHICF, IGNEGBKHMPD MBOHBEPKFBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3F20", Offset = "0x1DB2D20", VA = "0x181DB3F20")]
		public static DAKENPFNPGN MJAMMDFAFDI(bool EJEEAEHDLCK)
		{
			return default(DAKENPFNPGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3E90", Offset = "0x1DB2C90", VA = "0x181DB3E90")]
		public static DAKENPFNPGN KOAIMGCNPAM([In] ReadOnlyMemory<byte> HCFBAPHHICF)
		{
			return default(DAKENPFNPGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3ED0", Offset = "0x1DB2CD0", VA = "0x181DB3ED0")]
		public static DAKENPFNPGN LDKGOOIDBKK(int AOLOOLDMKEK)
		{
			return default(DAKENPFNPGN);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3C70", Offset = "0x1DB2A70", VA = "0x181DB3C70")]
		public static bool EILLJGMDDAM([In] DAKENPFNPGN MAJJJNOEIPE, [In] DAKENPFNPGN FBEFKCHGALI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3CE0", Offset = "0x1DB2AE0", VA = "0x181DB3CE0", Slot = "4")]
		public bool Equals(DAKENPFNPGN EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3C70", Offset = "0x1DB2A70", VA = "0x181DB3C70")]
		public bool BOFBAKIJPFH([In] DAKENPFNPGN EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3D50", Offset = "0x1DB2B50", VA = "0x181DB3D50", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3E30", Offset = "0x1DB2C30", VA = "0x181DB3E30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3F80", Offset = "0x1DB2D80", VA = "0x181DB3F80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1DB3C70", Offset = "0x1DB2A70", VA = "0x181DB3C70", Slot = "5")]
		private bool JNBMIDIGKIB([In] DAKENPFNPGN EDOEJIMPOFP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public readonly struct KLGDLGDNMFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> OKMIGAAJAJI;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
		public KLGDLGDNMFF(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CLPKPLPLPPO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly LNDKNAIIIOD GMKCDBDJPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly DAKENPFNPGN NNKGKBIGFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public readonly KLGDLGDNMFF GGPDGFKFIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly LPFNBDDBJKP EFBKLMHMPEA;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1DB33A0", Offset = "0x1DB21A0", VA = "0x181DB33A0")]
	private ADEHHGABOLD(LNDKNAIIIOD MHLKJAPINHC, [In] DAKENPFNPGN HPBMCLMJHDL, KLGDLGDNMFF ECOIKNKHNHK, LPFNBDDBJKP DMAENLOFJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB31F0", Offset = "0x1DB1FF0", VA = "0x181DB31F0")]
	public static ADEHHGABOLD HBHGAKFOEOC(GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> EKHBMCJDMOF)
	{
		return default(ADEHHGABOLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3160", Offset = "0x1DB1F60", VA = "0x181DB3160")]
	public static ADEHHGABOLD BHKEDNJCDPH(bool EJEEAEHDLCK)
	{
		return default(ADEHHGABOLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3240", Offset = "0x1DB2040", VA = "0x181DB3240")]
	public static ADEHHGABOLD KMDAIJNCHHM([In] ReadOnlyMemory<byte> HCFBAPHHICF)
	{
		return default(ADEHHGABOLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1DB3310", Offset = "0x1DB2110", VA = "0x181DB3310")]
	public static ADEHHGABOLD NLHNCNMFGAK(int AOLOOLDMKEK)
	{
		return default(ADEHHGABOLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB32B0", Offset = "0x1DB20B0", VA = "0x181DB32B0")]
	public static ADEHHGABOLD MPMMFOHDAEO(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> OKEIKKMJEEE)
	{
		return default(ADEHHGABOLD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class LANNKOBGOEH
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0")]
	public static EMJHLOKHGIJ ALEDEFBMHOF([In] this ADEHHGABOLD OELHNDCFEMO)
	{
		return default(EMJHLOKHGIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct EMJHLOKHGIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum MHDNPIACFLD
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		DeadEnd,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		OutNode,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		NodeCantVisit,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		NodeAlreadyVisited,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		Branch
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly MHDNPIACFLD EFBKLMHMPEA;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
	private EMJHLOKHGIJ(MHDNPIACFLD DMAENLOFJGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0")]
	public static EMJHLOKHGIJ HBHGAKFOEOC()
	{
		return default(EMJHLOKHGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7BADE0", Offset = "0x7B9BE0", VA = "0x1807BADE0")]
	public static EMJHLOKHGIJ LNLHINLLOEI([In] ADEHHGABOLD FGIPEOJEGND)
	{
		return default(EMJHLOKHGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x85D750", Offset = "0x85C550", VA = "0x18085D750")]
	public static EMJHLOKHGIJ JLLDKAIELDN()
	{
		return default(EMJHLOKHGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9008D0", Offset = "0x8FF6D0", VA = "0x1809008D0")]
	public static EMJHLOKHGIJ GHOFIJCKGMH()
	{
		return default(EMJHLOKHGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8ED300", Offset = "0x8EC100", VA = "0x1808ED300")]
	public static EMJHLOKHGIJ FHIOJMCKGPA()
	{
		return default(EMJHLOKHGIJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface JILJPBCJJFN<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPIFJNELMMP<NBDLPGLDGGC> ABFFFHJDJGP(TStateSys NPKLOAHJLOD);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GPIFJNELMMP<NBDLPGLDGGC> LGGAHIPFOKK(TStateSys NPKLOAHJLOD);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EMJHLOKHGIJ EFIDNFNNEEO(TStateSys NPKLOAHJLOD, NCPJAKHBLLP PDIMFLHKEDF, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<BKCBFIPNEFB> NKFNLDOHMKN);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ADEHHGABOLD HMBJJFFGIKH(TStateSys NPKLOAHJLOD, NCPJAKHBLLP PDIMFLHKEDF, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<IHPNMOMBMAC> MKCJIMKGHPG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int NJFEHLECPLA(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<BKCBFIPNEFB> NKFNLDOHMKN);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GPIFJNELMMP<IHPNMOMBMAC> FPIDBAIINNB(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<BKCBFIPNEFB> NKFNLDOHMKN, int BHGDDGHPAFP);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FAPLJFKFLBH NHCMDJMNANB(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<BKCBFIPNEFB> NKFNLDOHMKN);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool GHPENGAPMNC(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<BKCBFIPNEFB> NKFNLDOHMKN);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int JCEPLMEAOFN(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<BKCBFIPNEFB> NKFNLDOHMKN);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IPPOBGFPAOB<byte> GAOBKPGMKCE(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<BKCBFIPNEFB> NKFNLDOHMKN);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	object PCNIFBPALOH(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<BKCBFIPNEFB> NKFNLDOHMKN);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	int GBNGGAOMNOI(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<IHPNMOMBMAC> MKCJIMKGHPG);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "12")]
	GPIFJNELMMP<BKCBFIPNEFB> MMPEONAGHNE(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, GPIFJNELMMP<IHPNMOMBMAC> MKCJIMKGHPG, int DLPAGCNNKJE);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int CEHOEHOPHDL(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "14")]
	int HPCHCKOBAOO(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, int OHINPGIGDNE);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "15")]
	int JOICOEHJKFC(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int GCBCOIJFADC(TStateSys NPKLOAHJLOD, GPIFJNELMMP<NCFLANDMDIF> APHIOIJKKOI, int OHINPGIGDNE);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class MMGOJBDPAGD
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1DBBDD0", Offset = "0x1DBABD0", VA = "0x181DBBDD0")]
	public static GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> PPIFNEDPLKN([In] this NCPJAKHBLLP OELHNDCFEMO)
	{
		return default(GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7760", Offset = "0x1DB6560", VA = "0x181DB7760")]
	private static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> DOPLLHJBPMM(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> OLAICIDMAFC, int OHINPGIGDNE, int CGKDGFIFBAL)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9B80", Offset = "0x1DB8980", VA = "0x181DB9B80")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> IJLKLNHDICH(this NCPJAKHBLLP OELHNDCFEMO, int OHINPGIGDNE)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1DBAFF0", Offset = "0x1DB9DF0", VA = "0x181DBAFF0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MNNHBODFMMO(this NCPJAKHBLLP OELHNDCFEMO, int JEOEJJBKODC)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9940", Offset = "0x1DB8740", VA = "0x181DB9940")]
	private static void IHLHBCLKFEN(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CLPKPLPLPPO, GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> OLAICIDMAFC, int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA080", Offset = "0x1DB8E80", VA = "0x181DBA080")]
	public static void JOOBDKCCBPA(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CLPKPLPLPPO, int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8040", Offset = "0x1DB6E40", VA = "0x181DB8040")]
	private static void EPGCODKEJIK(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> OLAICIDMAFC, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FJIJLBIGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6A40", Offset = "0x1DB5840", VA = "0x181DB6A40")]
	private static void BJJLPKLNABD(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> OLAICIDMAFC, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FJIJLBIGEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2813CA0", Offset = "0x2812AA0", VA = "0x182813CA0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC?> MMANADDIGAG<T, TOpInput, TOpOutput>(this NCPJAKHBLLP OELHNDCFEMO, T MAJJJNOEIPE, T FBEFKCHGALI, int OKHFGMHJGNA, IntPtr CKABGGBNLGH)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2813460", Offset = "0x2812260", VA = "0x182813460")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC?> DMBMOGNOGOF<T, TOpInput, TOpOutput>(this NCPJAKHBLLP OELHNDCFEMO, T MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI, int OKHFGMHJGNA, IntPtr CKABGGBNLGH)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x28136B0", Offset = "0x28124B0", VA = "0x1828136B0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC?> FBDEEGGDGCM<TOpInput, TOpOutput>(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI, int OKHFGMHJGNA, IntPtr CKABGGBNLGH)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6E80", Offset = "0x1DB5C80", VA = "0x181DB6E80")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BOPOGGFCOCF(this NCPJAKHBLLP OELHNDCFEMO, float KPKHBCOMJNE, float GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7D20", Offset = "0x1DB6B20", VA = "0x181DB7D20")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> EJEKKPIICEI(this NCPJAKHBLLP OELHNDCFEMO, float KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1DBBC20", Offset = "0x1DBAA20", VA = "0x181DBBC20")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> PNLGNOKFPKC(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA770", Offset = "0x1DB9570", VA = "0x181DBA770")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> LIPBCNILNAN(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, int GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6AC0", Offset = "0x1DB58C0", VA = "0x181DB6AC0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BJNICHNFECO(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB8B0", Offset = "0x1DBA6B0", VA = "0x181DBB8B0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> PKGGPDLPFDI(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7360", Offset = "0x1DB6160", VA = "0x181DB7360")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> DFOMDIDOGIC(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, ADEHHGABOLD GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA6D0", Offset = "0x1DB94D0", VA = "0x181DBA6D0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> LIGFKFDEDNJ(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, int GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9870", Offset = "0x1DB8670", VA = "0x181DB9870")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> IEKOJEHCENB(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB070", Offset = "0x1DB9E70", VA = "0x181DBB070")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> NCDHCLBCDMC(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1DBAE60", Offset = "0x1DB9C60", VA = "0x181DBAE60")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MGBDPGOMNAM(this NCPJAKHBLLP OELHNDCFEMO, int MAJJJNOEIPE, int FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6460", Offset = "0x1DB5260", VA = "0x181DB6460")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BDAHPOHAKDC(this NCPJAKHBLLP OELHNDCFEMO, int MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8AC0", Offset = "0x1DB78C0", VA = "0x181DB8AC0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FJIHCIJEJPN(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1DB94F0", Offset = "0x1DB82F0", VA = "0x181DB94F0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> HECDACCGBGK(this NCPJAKHBLLP OELHNDCFEMO, float MAJJJNOEIPE, float FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA1C0", Offset = "0x1DB8FC0", VA = "0x181DBA1C0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KCOOJIDPMNL(this NCPJAKHBLLP OELHNDCFEMO, float MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB83E0", Offset = "0x1DB71E0", VA = "0x181DB83E0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FAAEKPICOHN(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6E00", Offset = "0x1DB5C00", VA = "0x181DB6E00")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BOEOJDJHIGK(this NCPJAKHBLLP OELHNDCFEMO, int MAJJJNOEIPE, int FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1DBBA90", Offset = "0x1DBA890", VA = "0x181DBBA90")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> PKMPNLHONHF(this NCPJAKHBLLP OELHNDCFEMO, int MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8D30", Offset = "0x1DB7B30", VA = "0x181DB8D30")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FNGDAOCBDKK(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1DB79C0", Offset = "0x1DB67C0", VA = "0x181DB79C0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> EABLPMJEOMK(this NCPJAKHBLLP OELHNDCFEMO, float MAJJJNOEIPE, float FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1DB65B0", Offset = "0x1DB53B0", VA = "0x181DB65B0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BFIPEPAGPDF(this NCPJAKHBLLP OELHNDCFEMO, float MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6630", Offset = "0x1DB5430", VA = "0x181DB6630")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BIADJEMMMJE(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB3B0", Offset = "0x1DBA1B0", VA = "0x181DBB3B0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> NKGEOPMOCAA(this NCPJAKHBLLP OELHNDCFEMO, int MAJJJNOEIPE, int FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6530", Offset = "0x1DB5330", VA = "0x181DB6530")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BDNKFPLBEME(this NCPJAKHBLLP OELHNDCFEMO, int MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1DB61B0", Offset = "0x1DB4FB0", VA = "0x181DB61B0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> AAPKAMCMPND(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7180", Offset = "0x1DB5F80", VA = "0x181DB7180")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CPGONBJNDOC(this NCPJAKHBLLP OELHNDCFEMO, float MAJJJNOEIPE, float FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7100", Offset = "0x1DB5F00", VA = "0x181DB7100")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CFLCNAKLAAC(this NCPJAKHBLLP OELHNDCFEMO, float MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB96A0", Offset = "0x1DB84A0", VA = "0x181DB96A0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> HHIPGEELMNB(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB84F0", Offset = "0x1DB72F0", VA = "0x181DB84F0")]
	public static GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>> FBAEKJGCABO(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB210", Offset = "0x1DBA010", VA = "0x181DBB210")]
	public static GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>> NHGKBAFOPAK(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1DB81C0", Offset = "0x1DB6FC0", VA = "0x181DB81C0")]
	public static GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>> EPLIBHNDEIF(this NCPJAKHBLLP OELHNDCFEMO, ADEHHGABOLD MAEBFBHFPDE)
	{
		return default(GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB78A0", Offset = "0x1DB66A0", VA = "0x181DB78A0")]
	public static GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>> DPHHPKCJAAA(this NCPJAKHBLLP OELHNDCFEMO, int MAEBFBHFPDE)
	{
		return default(GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB660", Offset = "0x1DBA460", VA = "0x181DBB660")]
	public static GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>> PHMLPLCHKPD(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAEBFBHFPDE)
	{
		return default(GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6B90", Offset = "0x1DB5990", VA = "0x181DB6B90")]
	public static GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>> BJNOPEEGLDP(this NCPJAKHBLLP OELHNDCFEMO, ADEHHGABOLD MAEBFBHFPDE)
	{
		return default(GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8910", Offset = "0x1DB7710", VA = "0x181DB8910")]
	public static GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>> FEHIFMCGODE(this NCPJAKHBLLP OELHNDCFEMO, int MAEBFBHFPDE)
	{
		return default(GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9D70", Offset = "0x1DB8B70", VA = "0x181DB9D70")]
	public static GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>> IPBCBJPLBAK(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAEBFBHFPDE)
	{
		return default(GPIFJNELMMP<FGAHPNBKCIK<FGAHPNBKCIK<GJAHNLPGNAP>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8FA0", Offset = "0x1DB7DA0", VA = "0x181DB8FA0")]
	public static void GJBGGFNJOLC(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<NBDLPGLDGGC> JGBLECCMLAD, [In] ReadOnlySpan<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> OHHPHLJFHPD, [In] ReadOnlySpan<int> NMKKKKNDMCF, [In] Span<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> LBNOLINCGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1DBAAE0", Offset = "0x1DB98E0", VA = "0x181DBAAE0")]
	public static void MENJKJOGAPD(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<PAOGANKFOJP> GMHCEMNMKBI, [In] ReadOnlySpan<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> OHHPHLJFHPD, [In] ReadOnlySpan<int> NMKKKKNDMCF, [In] Span<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> LBNOLINCGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8BC0", Offset = "0x1DB79C0", VA = "0x181DB8BC0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FLDOOJOELPI(this NCPJAKHBLLP OELHNDCFEMO, ADEHHGABOLD MJNOHBDDECC, [Optional] GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>? ANDIBGAILAG)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6230", Offset = "0x1DB5030", VA = "0x181DB6230")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> ANJODLAAMEJ(this NCPJAKHBLLP OELHNDCFEMO, int MJNOHBDDECC, [Optional] GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>? ANDIBGAILAG, int KPAPJILIKKH = 0)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x1DBAF00", Offset = "0x1DB9D00", VA = "0x181DBAF00")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MHIBLKHEEEJ(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MJNOHBDDECC, [Optional] GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>? ANDIBGAILAG, int MAECLCAIEFI = 0, int KPAPJILIKKH = 0)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1DB85C0", Offset = "0x1DB73C0", VA = "0x181DB85C0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBPJCNBBJFH(this NCPJAKHBLLP OELHNDCFEMO, [In] ReadOnlySpan<byte> MJNOHBDDECC, [Optional] GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>? ANDIBGAILAG)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8DB0", Offset = "0x1DB7BB0", VA = "0x181DB8DB0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FPKKNLLADBD(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MJNOHBDDECC, int JEOEJJBKODC, [Optional] GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>? ANDIBGAILAG)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8990", Offset = "0x1DB7790", VA = "0x181DB8990")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FHOIAGNNFNN(this NCPJAKHBLLP OELHNDCFEMO, float KPKHBCOMJNE, float GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB4B0", Offset = "0x1DBA2B0", VA = "0x181DBB4B0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> OLBHNBIBKDH(this NCPJAKHBLLP OELHNDCFEMO, float KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA340", Offset = "0x1DB9140", VA = "0x181DBA340")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KJNGJALNOKC(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7570", Offset = "0x1DB6370", VA = "0x181DB7570")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> DJODFHIIHMD(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, int GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6F30", Offset = "0x1DB5D30", VA = "0x181DB6F30")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CBOLDMIOGJM(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1DB95A0", Offset = "0x1DB83A0", VA = "0x181DB95A0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> HFCNDMBGEJI(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB430", Offset = "0x1DBA230", VA = "0x181DBB430")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> OIFBMPBJDCO(this NCPJAKHBLLP OELHNDCFEMO, int MAJJJNOEIPE, int FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1DB63E0", Offset = "0x1DB51E0", VA = "0x181DB63E0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BBPFLCOEOAA(this NCPJAKHBLLP OELHNDCFEMO, int MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1DB74F0", Offset = "0x1DB62F0", VA = "0x181DB74F0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> DJICOGEIPDL(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7CA0", Offset = "0x1DB6AA0", VA = "0x181DB7CA0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> EHOCIPOHEMJ(this NCPJAKHBLLP OELHNDCFEMO, float MAJJJNOEIPE, float FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7610", Offset = "0x1DB6410", VA = "0x181DB7610")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> DLKKEMKOGDO(this NCPJAKHBLLP OELHNDCFEMO, float MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1DB93D0", Offset = "0x1DB81D0", VA = "0x181DB93D0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> HBPLKAIAKKA(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAJJJNOEIPE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FBEFKCHGALI)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8330", Offset = "0x1DB7130", VA = "0x181DB8330")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> EPPBEMNDINK(this NCPJAKHBLLP OELHNDCFEMO, float KPKHBCOMJNE, float GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8EC0", Offset = "0x1DB7CC0", VA = "0x181DB8EC0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHOCLCJKHGL(this NCPJAKHBLLP OELHNDCFEMO, float KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1DBBB10", Offset = "0x1DBA910", VA = "0x181DBBB10")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> PMJOAFGEIJL(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA2A0", Offset = "0x1DB90A0", VA = "0x181DBA2A0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KEEBGKBLGAE(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, int GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7690", Offset = "0x1DB6490", VA = "0x181DB7690")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> DMMPINFHCLJ(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1DB62E0", Offset = "0x1DB50E0", VA = "0x181DB62E0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BBAIHMDEOEJ(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB700", Offset = "0x1DBA500", VA = "0x181DBB700")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> PJJLBGANCBE(this NCPJAKHBLLP OELHNDCFEMO, PODMDHOAEDD ACOBIKOBIGI, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BMEFMMMCCEH)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA510", Offset = "0x1DB9310", VA = "0x181DBA510")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> LCAJIMLMFFK(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> ACOBIKOBIGI, float BMEFMMMCCEH)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7DF0", Offset = "0x1DB6BF0", VA = "0x181DB7DF0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> EKOLJMLFJHL(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> ACOBIKOBIGI, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BMEFMMMCCEH)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1DBBD20", Offset = "0x1DBAB20", VA = "0x181DBBD20")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> POJAFBOFLPG(this NCPJAKHBLLP OELHNDCFEMO, float KPKHBCOMJNE, float GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB2E0", Offset = "0x1DBA0E0", VA = "0x181DBB2E0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> NJBONNCOJNF(this NCPJAKHBLLP OELHNDCFEMO, float KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA810", Offset = "0x1DB9610", VA = "0x181DBA810")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> LNBMKGFACDM(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9450", Offset = "0x1DB8250", VA = "0x181DB9450")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> HCNEAJOGBKH(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, int GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA440", Offset = "0x1DB9240", VA = "0x181DBA440")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KKCEBNOBDCD(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1DB6D00", Offset = "0x1DB5B00", VA = "0x181DB6D00")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BNKAPIPHJON(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8A40", Offset = "0x1DB7840", VA = "0x181DB8A40")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FIJLBPLAFAP(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAEBFBHFPDE)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1DB8C70", Offset = "0x1DB7A70", VA = "0x181DB8C70")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FNDEKOCJBJN(this NCPJAKHBLLP OELHNDCFEMO, int MAEBFBHFPDE)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB170", Offset = "0x1DB9F70", VA = "0x181DBB170")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> NFEANGIKDJN(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MAEBFBHFPDE)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB580", Offset = "0x1DBA380", VA = "0x181DBB580")]
	public static void PDMDDFMMAPE(this NCPJAKHBLLP OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9320", Offset = "0x1DB8120", VA = "0x181DB9320")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> HBEIBBPMCOL(this NCPJAKHBLLP OELHNDCFEMO, float KPKHBCOMJNE, float GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9CA0", Offset = "0x1DB8AA0", VA = "0x181DB9CA0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> IOJNEBLGEMA(this NCPJAKHBLLP OELHNDCFEMO, float KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1DBA910", Offset = "0x1DB9710", VA = "0x181DBA910")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> LOFDHOAPHHB(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7920", Offset = "0x1DB6720", VA = "0x181DB7920")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> EAADBLIOKCI(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, int GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1DBAA10", Offset = "0x1DB9810", VA = "0x181DBAA10")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MEANIMIDLMN(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1DB80C0", Offset = "0x1DB6EC0", VA = "0x181DB80C0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> EPIIDPPIDKJ(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB9B0", Offset = "0x1DBA7B0", VA = "0x181DBB9B0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> PKJOHABINEP(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> PMNEDIFJMIN)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1DB67B0", Offset = "0x1DB55B0", VA = "0x181DB67B0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BJFINCOEBGK(this NCPJAKHBLLP OELHNDCFEMO, ADEHHGABOLD KPKHBCOMJNE, ADEHHGABOLD GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9AE0", Offset = "0x1DB88E0", VA = "0x181DB9AE0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> IJIGDAFPIFG(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, int GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1DBB590", Offset = "0x1DBA390", VA = "0x181DBB590")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> PGELNMGLOCC(this NCPJAKHBLLP OELHNDCFEMO, int KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7000", Offset = "0x1DB5E00", VA = "0x181DB7000")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CDEEAHBBAHJ(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> KPKHBCOMJNE, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> GHCMJGCDKOD)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9E10", Offset = "0x1DB8C10", VA = "0x181DB9E10")]
	public static void JMCPHLGKBDP(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<NBDLPGLDGGC> JGBLECCMLAD, [In] ReadOnlySpan<(ADEHHGABOLD DataBack, int Size)> OPGFLJHIHOC, [In] ReadOnlySpan<int> NMKKKKNDMCF, [In] Span<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> LBNOLINCGHO, [In] Span<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> ONPCKENBBJB, [In] ReadOnlySpan<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>?> KJALPGJABJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1DB86A0", Offset = "0x1DB74A0", VA = "0x181DB86A0")]
	public static void FCGHGJINHOL(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<PAOGANKFOJP> BKMNKOEHPLG, [In] ReadOnlySpan<(ADEHHGABOLD DataBack, int Size)> OPGFLJHIHOC, [In] ReadOnlySpan<int> NMKKKKNDMCF, [In] Span<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> LBNOLINCGHO, [In] Span<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>> ONPCKENBBJB, [In] ReadOnlySpan<GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>?> KJALPGJABJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7200", Offset = "0x1DB6000", VA = "0x181DB7200")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> DFKMOPMOACM(this NCPJAKHBLLP OELHNDCFEMO, [In] ADEHHGABOLD.DAKENPFNPGN HPBMCLMJHDL, int JEOEJJBKODC, [Optional] GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>? ANDIBGAILAG)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1DB9720", Offset = "0x1DB8520", VA = "0x181DB9720")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> HMNHBDCLCMI(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> OMBIDINGJJL, int JEOEJJBKODC, [Optional] GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>? ANDIBGAILAG)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1DB7A40", Offset = "0x1DB6840", VA = "0x181DB7A40")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> EDMIJMBBFPM(this NCPJAKHBLLP OELHNDCFEMO, [In] ADEHHGABOLD MMPIIBINLPC, int JEOEJJBKODC, [Optional] GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>? ANDIBGAILAG)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x28137B0", Offset = "0x28125B0", VA = "0x1828137B0")]
	public static ADEHHGABOLD JAECPIHNGBB<TStateSys, TDeps>(this NCPJAKHBLLP OELHNDCFEMO, TStateSys NPKLOAHJLOD, TDeps IKMKPNFBOIN) where TStateSys : notnull where TDeps : notnull, JILJPBCJJFN<TStateSys>
	{
		return default(ADEHHGABOLD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2813A60", Offset = "0x2812860", VA = "0x182813A60")]
	public static EMJHLOKHGIJ KAENFBMPDGH<TStateSys, TDeps>(this NCPJAKHBLLP OELHNDCFEMO, TStateSys NPKLOAHJLOD, TDeps IKMKPNFBOIN) where TStateSys : notnull where TDeps : notnull, JILJPBCJJFN<TStateSys>
	{
		return default(EMJHLOKHGIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1DB66B0", Offset = "0x1DB54B0", VA = "0x181DB66B0")]
	private static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> BJDJAPNIOPP(this NCPJAKHBLLP OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>? OMBIDINGJJL, int JEOEJJBKODC)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct BDNKMHJBMEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> OOHJHNKJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> FJIDADAGMLO;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xAAB8D0", Offset = "0xAAA6D0", VA = "0x180AAB8D0")]
	public BDNKMHJBMEP(GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> CGKEGJLDHGL, GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> BLLNEAFENEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1DB33F0", Offset = "0x1DB21F0", VA = "0x181DB33F0")]
	public static BDNKMHJBMEP IKCDCJJCDKO(GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> CGKEGJLDHGL)
	{
		return default(BDNKMHJBMEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LBBJCNAPMEL
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public sealed class FMMCNMDIAJO : EJDIAOACPAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct LIBAHCIPMEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> ONLJICJJMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int LNBHMBDGGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int LIEMGDMJGGF;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x19443E0", Offset = "0x19431E0", VA = "0x1819443E0")]
		public LIBAHCIPMEL(GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> OLAICIDMAFC, int OHINPGIGDNE, int CGKDGFIFBAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class NBGKNPECKPN : EJDIAOACPAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct OLKAGEMNFMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int LNBHMBDGGMM;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
		public OLKAGEMNFMA(int OHINPGIGDNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public sealed class DMCCOBKHBFC : EJDIAOACPAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public struct NJGONGANIGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> ONLJICJJMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int LNBHMBDGGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int LIEMGDMJGGF;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x19443E0", Offset = "0x19431E0", VA = "0x1819443E0")]
		public NJGONGANIGP(GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> OLAICIDMAFC, int OHINPGIGDNE, int CGKDGFIFBAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum NKHFKBEEMPL
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Temporary,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		Named,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		Argument,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		CallerReturnValue,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		Parameter,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		CalleeReturnValue
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class CGBMMIMBKDC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class EJDIAOACPAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct GLIELEEDEPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public BDNKMHJBMEP JBBBOCBCADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public NKHFKBEEMPL FAEBKGIBJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public GPIFJNELMMP<EJDIAOACPAI> BCNNAEOOMPO;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1DB5210", Offset = "0x1DB4010", VA = "0x181DB5210")]
		private GLIELEEDEPL([In] BDNKMHJBMEP APGODGEDEAO, NKHFKBEEMPL CLHFLCCBOJO, GPIFJNELMMP<EJDIAOACPAI> DPNCADHGLEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1DB51F0", Offset = "0x1DB3FF0", VA = "0x181DB51F0")]
		public static GLIELEEDEPL IKCDCJJCDKO(GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> CGKEGJLDHGL, NKHFKBEEMPL CLHFLCCBOJO, GPIFJNELMMP<EJDIAOACPAI> DPNCADHGLEC)
		{
			return default(GLIELEEDEPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class HDOKABCJBNE : EJDIAOACPAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct PGMDHPELKIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int LIEMGDMJGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public bool KLJNACIGFDE;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xEF7510", Offset = "0xEF6310", VA = "0x180EF7510")]
		public PGMDHPELKIJ(int CGKDGFIFBAL, bool LPLDACFBAFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class FOFIFMGPHLG : EJDIAOACPAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public struct DGHBJNKIANJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int LNBHMBDGGMM;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
		public DGHBJNKIANJ(int OHINPGIGDNE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class FJEFEMOMHJO : EJDIAOACPAI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct INLMJLLBEBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int LIEMGDMJGGF;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8E9D70", VA = "0x1808EAF70")]
		public INLMJLLBEBG(int CGKDGFIFBAL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal DKCIKNBBNIK<CGBMMIMBKDC, GLIELEEDEPL> EEJANFAECOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal DKCIKNBBNIK<FJEFEMOMHJO, INLMJLLBEBG> JIJODEFLICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal DKCIKNBBNIK<HDOKABCJBNE, PGMDHPELKIJ> BCBJLJHDFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal DKCIKNBBNIK<FMMCNMDIAJO, LIBAHCIPMEL> JLHKILAGLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal DKCIKNBBNIK<DMCCOBKHBFC, NJGONGANIGP> HCIONMIIFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal DKCIKNBBNIK<FOFIFMGPHLG, DGHBJNKIANJ> KNCHCPCOLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal DKCIKNBBNIK<NBGKNPECKPN, OLKAGEMNFMA> DDIEDDEOKDD;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5CD0", Offset = "0x1DB4AD0", VA = "0x181DB5CD0")]
	private LBBJCNAPMEL([In] DKCIKNBBNIK<CGBMMIMBKDC, GLIELEEDEPL> NELBMGKONNK, [In] DKCIKNBBNIK<FJEFEMOMHJO, INLMJLLBEBG> LNNAAJBBLFN, [In] DKCIKNBBNIK<HDOKABCJBNE, PGMDHPELKIJ> ACKAIHLGDCH, [In] DKCIKNBBNIK<FMMCNMDIAJO, LIBAHCIPMEL> NHBNAGFOGEB, [In] DKCIKNBBNIK<DMCCOBKHBFC, NJGONGANIGP> OLHAEGCNOKI, [In] DKCIKNBBNIK<FOFIFMGPHLG, DGHBJNKIANJ> NDEOBKIGMGI, [In] DKCIKNBBNIK<NBGKNPECKPN, OLKAGEMNFMA> ACMHGACNNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5A20", Offset = "0x1DB4820", VA = "0x181DB5A20")]
	public static LBBJCNAPMEL IKCDCJJCDKO()
	{
		return default(LBBJCNAPMEL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class KKGFMHGJOCC
{
	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x85C2D0", Offset = "0x85B0D0", VA = "0x18085C2D0")]
	public static DKCIKNBBNIK<LBBJCNAPMEL.CGBMMIMBKDC, LBBJCNAPMEL.GLIELEEDEPL> BAICCLEBBFJ([In] this LBBJCNAPMEL OELHNDCFEMO)
	{
		return default(DKCIKNBBNIK<LBBJCNAPMEL.CGBMMIMBKDC, LBBJCNAPMEL.GLIELEEDEPL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1C37C90", Offset = "0x1C36A90", VA = "0x181C37C90")]
	public static DKCIKNBBNIK<LBBJCNAPMEL.HDOKABCJBNE, LBBJCNAPMEL.PGMDHPELKIJ> HNDDLNHKPLI([In] this LBBJCNAPMEL OELHNDCFEMO)
	{
		return default(DKCIKNBBNIK<LBBJCNAPMEL.HDOKABCJBNE, LBBJCNAPMEL.PGMDHPELKIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5270", Offset = "0x1DB4070", VA = "0x181DB5270")]
	public static void COJAMHJFIEG(this LBBJCNAPMEL OELHNDCFEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1DB58F0", Offset = "0x1DB46F0", VA = "0x181DB58F0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> MNNHBODFMMO(this LBBJCNAPMEL OELHNDCFEMO, GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> CGKEGJLDHGL, int CGKDGFIFBAL)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1DB56C0", Offset = "0x1DB44C0", VA = "0x181DB56C0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> ILLKHEADNFB(this LBBJCNAPMEL OELHNDCFEMO, GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> CGKEGJLDHGL, int CGKDGFIFBAL, bool LPLDACFBAFA)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5450", Offset = "0x1DB4250", VA = "0x181DB5450")]
	public static void IHLHBCLKFEN(this LBBJCNAPMEL OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CLPKPLPLPPO, GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> OLAICIDMAFC, int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1DB5360", Offset = "0x1DB4160", VA = "0x181DB5360")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FEPICKMKHFG(this LBBJCNAPMEL OELHNDCFEMO, GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> CGKEGJLDHGL, GPIFJNELMMP<MMCONGPKCIG.IDOAALMHJAK> OLAICIDMAFC, int OHINPGIGDNE, int CGKDGFIFBAL)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1DB55F0", Offset = "0x1DB43F0", VA = "0x181DB55F0")]
	public static GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> IJLKLNHDICH(this LBBJCNAPMEL OELHNDCFEMO, GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> CGKEGJLDHGL, int OHINPGIGDNE)
	{
		return default(GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1DB57B0", Offset = "0x1DB45B0", VA = "0x181DB57B0")]
	public static void JOOBDKCCBPA(this LBBJCNAPMEL OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> CLPKPLPLPPO, int OHINPGIGDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1DB59B0", Offset = "0x1DB47B0", VA = "0x181DB59B0")]
	public static void NIEMILIMNCB(this LBBJCNAPMEL OELHNDCFEMO, GPIFJNELMMP<LBBJCNAPMEL.CGBMMIMBKDC> FJIJLBIGEAH, GPIFJNELMMP<FGAHPNBKCIK<GJAHNLPGNAP>> GHJFJBAFNIK)
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
