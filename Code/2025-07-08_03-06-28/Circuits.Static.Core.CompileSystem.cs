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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x29DF140", Offset = "0x29DDF40", VA = "0x1829DF140")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct ILFCEKNJNEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> OPHGEBKABDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int KJPGBDEIAKE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xE3B7B0", Offset = "0xE3A5B0", VA = "0x180E3B7B0")]
	public ILFCEKNJNEM(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MGMCAGDADHN, int DOBKAGHAEBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MAELHFLAIHO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class IPBCMEPPEAF : JPHFHMDINAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct NJJHMFOFOFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly MPKIBFFOKBM<byte> FMGPPHOIPGO;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2964A90", Offset = "0x2963890", VA = "0x182964A90")]
		public NJJHMFOFOFM(MPKIBFFOKBM<byte> JMAPKDPGDHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x29DF020", Offset = "0x29DDE20", VA = "0x1829DF020", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class JHPKPGMFPOC : JPHFHMDINAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct JLAGJIDOIKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> CIPMNFDHAEI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
		public JLAGJIDOIKD(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> MGBDJEDFCBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DMLHNHNKFHJ
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
	public sealed class LGIBKAHNBCO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class JPHFHMDINAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct LJNADAKGEDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly DMLHNHNKFHJ JHDJOPLIDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly HBBCPCNIOON<JPHFHMDINAG> LKOAGGONJHH;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7B0", Offset = "0xE3A5B0", VA = "0x180E3B7B0")]
		public LJNADAKGEDJ(DMLHNHNKFHJ JFANEKCFJPP, HBBCPCNIOON<JPHFHMDINAG> PHOFEEAAGHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class OMEBBNPIANO : JPHFHMDINAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct CKMMKNMMNAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GMJBGGJACCJ;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
		public CKMMKNMMNAA(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EIFNHPDMBOB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class BBCGBEHGFAD : JPHFHMDINAG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct JCOLPNCANAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly PDLHEEOINJI NAIFFMLIGHC;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
		public JCOLPNCANAD(PDLHEEOINJI ADKNLNPNDPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x29D61D0", Offset = "0x29D4FD0", VA = "0x1829D61D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal HOCKIMKBPHD<LGIBKAHNBCO, LJNADAKGEDJ> LNOLIBJKCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal HOCKIMKBPHD<IPBCMEPPEAF, NJJHMFOFOFM> NIEFNLHJAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal HOCKIMKBPHD<JHPKPGMFPOC, JLAGJIDOIKD> HDAPNIHNBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal HOCKIMKBPHD<OMEBBNPIANO, CKMMKNMMNAA> BHNDFKICMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal HOCKIMKBPHD<BBCGBEHGFAD, JCOLPNCANAD> PICKKOGJPBK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29D8C50", Offset = "0x29D7A50", VA = "0x1829D8C50")]
	private MAELHFLAIHO([In] HOCKIMKBPHD<LGIBKAHNBCO, LJNADAKGEDJ> PNCIHFJAGLB, [In] HOCKIMKBPHD<IPBCMEPPEAF, NJJHMFOFOFM> PJGCBMICAAD, [In] HOCKIMKBPHD<JHPKPGMFPOC, JLAGJIDOIKD> HLCGHMFKCGN, [In] HOCKIMKBPHD<OMEBBNPIANO, CKMMKNMMNAA> BBGFHANLFPC, [In] HOCKIMKBPHD<BBCGBEHGFAD, JCOLPNCANAD> EELMFNKIEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x29D8B10", Offset = "0x29D7910", VA = "0x1829D8B10")]
	public static MAELHFLAIHO OGAKBGHEIKK()
	{
		return default(MAELHFLAIHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NCAHBLJPOEP
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x29D9BA0", Offset = "0x29D89A0", VA = "0x1829D9BA0")]
	public static void BOGGHIAGAGL(this MAELHFLAIHO FEOFEEGOGIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum ICCODGOOPFK
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
public struct APAGDGHDOCK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class GOIGBNLBHAC : JBNHBFJBOGD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct CDBKMDCIMND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> PCMPGNLFFND;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
		public CDBKMDCIMND(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> HBBBLCEKKGL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum ADIPIJFILJG
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
	public sealed class PDBEOHPCLAO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class JBNHBFJBOGD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct JCCIBPGMGJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly ADIPIJFILJG JHDJOPLIDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly HBBCPCNIOON<JBNHBFJBOGD> LKOAGGONJHH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7B0", Offset = "0xE3A5B0", VA = "0x180E3B7B0")]
		public JCCIBPGMGJO(ADIPIJFILJG JFANEKCFJPP, HBBCPCNIOON<JBNHBFJBOGD> PHOFEEAAGHG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal HOCKIMKBPHD<PDBEOHPCLAO, JCCIBPGMGJO> LNOLIBJKCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal HOCKIMKBPHD<GOIGBNLBHAC, CDBKMDCIMND> AAPAAGJIEHN;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x29D4650", Offset = "0x29D3450", VA = "0x1829D4650")]
	private APAGDGHDOCK([In] HOCKIMKBPHD<PDBEOHPCLAO, JCCIBPGMGJO> PNCIHFJAGLB, [In] HOCKIMKBPHD<GOIGBNLBHAC, CDBKMDCIMND> EKBEJFDHJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x29D45C0", Offset = "0x29D33C0", VA = "0x1829D45C0")]
	public static APAGDGHDOCK OGAKBGHEIKK()
	{
		return default(APAGDGHDOCK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LMIGBBJEDEI
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x29D8AA0", Offset = "0x29D78A0", VA = "0x1829D8AA0")]
	public static void BOGGHIAGAGL(this APAGDGHDOCK FEOFEEGOGIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct MBOBBGFKOLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public OJAIHBKPJPA<int> HKINCOPFOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public OJAIHBKPJPA<int> EMNOLDIHEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int KCADGFLGGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int NEIECBPHLCC;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x29D8D80", Offset = "0x29D7B80", VA = "0x1829D8D80")]
	private MBOBBGFKOLM([In] OJAIHBKPJPA<int> GDLEOPBICJF, [In] OJAIHBKPJPA<int> PNCPBDJMENO, int FEJMGNNDMFL, int JJKJELJMMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x29D8CE0", Offset = "0x29D7AE0", VA = "0x1829D8CE0")]
	public static MBOBBGFKOLM OGAKBGHEIKK()
	{
		return default(MBOBBGFKOLM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LIPKEOMJGGL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x29D8840", Offset = "0x29D7640", VA = "0x1829D8840")]
	public static void BOGGHIAGAGL(this MBOBBGFKOLM FEOFEEGOGIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct PCNFKLOMOBA
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum GEDJJICAAPP
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class GDCAGIIJMPH : JCLDFFNPKIH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct JJEEGPPLCKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly HBBCPCNIOON<KKCDKPGECEB> EBOJBAEBFGH;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
		public JJEEGPPLCKE(HBBCPCNIOON<KKCDKPGECEB> PEGMMPPABMF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class LGOCLAGJFGI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class JCLDFFNPKIH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct HEPGCIDAIIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly GEDJJICAAPP JHDJOPLIDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly HBBCPCNIOON<JCLDFFNPKIH> LKOAGGONJHH;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7B0", Offset = "0xE3A5B0", VA = "0x180E3B7B0")]
		private HEPGCIDAIIP(GEDJJICAAPP JFANEKCFJPP, HBBCPCNIOON<JCLDFFNPKIH> PHOFEEAAGHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x29D5C00", Offset = "0x29D4A00", VA = "0x1829D5C00")]
		public static HEPGCIDAIIP OGAKBGHEIKK(GEDJJICAAPP JFANEKCFJPP, HBBCPCNIOON<JCLDFFNPKIH> PHOFEEAAGHG)
		{
			return default(HEPGCIDAIIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class IFLEMLFGLLO : JCLDFFNPKIH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct ECNEMLCJOED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly HBBCPCNIOON<KKCDKPGECEB> EBOJBAEBFGH;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
		public ECNEMLCJOED(HBBCPCNIOON<KKCDKPGECEB> PEGMMPPABMF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class KKCDKPGECEB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct GELIKCOKMIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public OJAIHBKPJPA<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> GMEHEODHGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OJAIHBKPJPA<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> PKJFMAFPCKD;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x29D4650", Offset = "0x29D3450", VA = "0x1829D4650")]
		private GELIKCOKMIG([In] OJAIHBKPJPA<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> FLNLCOLLCMF, [In] OJAIHBKPJPA<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> KAIDEOJCKBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x29D5110", Offset = "0x29D3F10", VA = "0x1829D5110")]
		public static GELIKCOKMIG OGAKBGHEIKK()
		{
			return default(GELIKCOKMIG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal HOCKIMKBPHD<LGOCLAGJFGI, HEPGCIDAIIP> LNOLIBJKCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal HOCKIMKBPHD<IFLEMLFGLLO, ECNEMLCJOED> BBHAPHIMDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal HOCKIMKBPHD<GDCAGIIJMPH, JJEEGPPLCKE> AHMAHNEEBME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal OJAIHBKPJPA<(HBBCPCNIOON<LGOCLAGJFGI> CallId, HBBCPCNIOON<KKCDKPGECEB> IOId)> JINMBLCKEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal HOCKIMKBPHD<KKCDKPGECEB, GELIKCOKMIG> LIFHPAIMNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal GHBIFODMAFN<KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>> EBGABGJKOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal GHBIFODMAFN<KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>> PMGCAPJNHGG;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x29DF760", Offset = "0x29DE560", VA = "0x1829DF760")]
	private PCNFKLOMOBA([In] HOCKIMKBPHD<LGOCLAGJFGI, HEPGCIDAIIP> PNCIHFJAGLB, [In] HOCKIMKBPHD<IFLEMLFGLLO, ECNEMLCJOED> ACLNGNGGEIA, [In] HOCKIMKBPHD<GDCAGIIJMPH, JJEEGPPLCKE> AKHLBICKHDB, [In] OJAIHBKPJPA<(HBBCPCNIOON<LGOCLAGJFGI> CallId, HBBCPCNIOON<KKCDKPGECEB> IOId)> AJABLIBBEDK, [In] HOCKIMKBPHD<KKCDKPGECEB, GELIKCOKMIG> PDOFNDDGIKI, [In] GHBIFODMAFN<KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>> MLIHFKJEDED, [In] GHBIFODMAFN<KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>> DAGLOPCKLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x29DF5C0", Offset = "0x29DE3C0", VA = "0x1829DF5C0")]
	public static PCNFKLOMOBA OGAKBGHEIKK()
	{
		return default(PCNFKLOMOBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class CFHNHMLBIPL
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x29D4B20", Offset = "0x29D3920", VA = "0x1829D4B20")]
	private static void BOGGHIAGAGL(this PCNFKLOMOBA.GELIKCOKMIG FEOFEEGOGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x29D4910", Offset = "0x29D3710", VA = "0x1829D4910")]
	public static void BOGGHIAGAGL(this PCNFKLOMOBA FEOFEEGOGIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct NAFEFBPFJHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public OJAIHBKPJPA<byte> ADJKPGKIJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal PCNFKLOMOBA OBOAHBJEHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal IJJGMDABGMJ NBJKFJFJIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> IEHBGGEFOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal MAELHFLAIHO PJELPICAANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal APAGDGHDOCK LOBHDBIGHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal GHBIFODMAFN<KJOAJLIJKDJ, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>?> POKMLOPMHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal OJAIHBKPJPA<HBBCPCNIOON<KJOAJLIJKDJ>> EBDFAOOILGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?> KFDBHNCCECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> VariableId, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>> ByteCodeWriteLocation)> GJPANKNCMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> HNIPJGOAGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal BLIHHDADEOA FGKCKAIGDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal AIDADMKLBAB HAEAADCFKBN;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x29D9840", Offset = "0x29D8640", VA = "0x1829D9840")]
	private NAFEFBPFJHC([In] OJAIHBKPJPA<byte> KMNJHDICDEJ, [In] PCNFKLOMOBA OLDNHJABNEE, [In] IJJGMDABGMJ KOHINCAEACB, [In] MAELHFLAIHO DMPGLCHILAI, [In] APAGDGHDOCK NOECOJHBPCM, [In] GHBIFODMAFN<KJOAJLIJKDJ, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>?> DKOKMGLILOJ, [In] OJAIHBKPJPA<HBBCPCNIOON<KJOAJLIJKDJ>> HBKNKHMANBH, [In] GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?> NFBFDHNMAJA, [In] OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> VariableId, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>> ByteCodeWriteLocation)> DDPBBDMEKNE, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> AGJBDEJAAEC, [In] BLIHHDADEOA LCDMINMDJKJ, [In] AIDADMKLBAB JMBONMBHDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x29D8E90", Offset = "0x29D7C90", VA = "0x1829D8E90")]
	public static NAFEFBPFJHC OGAKBGHEIKK()
	{
		return default(NAFEFBPFJHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class KPDEPPNPAJC
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct ONFFDJFOGMD : NELJKFHKJGG<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>, GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x29DF510", Offset = "0x29DE310", VA = "0x1829DF510")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x29DF590", Offset = "0x29DE390", VA = "0x1829DF590", Slot = "4")]
		public HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> IGNIFGMLEKN(int CKFKPOAGPKN)
		{
			return default(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0")]
		public bool PDNFAKHJGLP(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "5")]
		private bool ILFLJDMOABJ(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x29DF510", Offset = "0x29DE310", VA = "0x1829DF510", Slot = "6")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> DMADPODGNNJ(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct LLFDANGEJOB : HAEDPCNCBBC<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>, GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x29D8920", Offset = "0x29D7720", VA = "0x1829D8920")]
		public OJAIHBKPJPA<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>> BLFIIGLGDAE(int LNFLDNENGDM, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x29D8990", Offset = "0x29D7790", VA = "0x1829D8990")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x29D8A10", Offset = "0x29D7810", VA = "0x1829D8A10", Slot = "6")]
		public void JALNFDGEAFA(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>> FEBLBJIINOM, HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x29D8920", Offset = "0x29D7720", VA = "0x1829D8920", Slot = "4")]
		private OJAIHBKPJPA<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>> BEDNANFKMCM(int LNFLDNENGDM, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x29D8990", Offset = "0x29D7790", VA = "0x1829D8990", Slot = "5")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> EEIAHEAHIOI(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct ILPHNFNDAKA : NELJKFHKJGG<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>, GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x29D6120", Offset = "0x29D4F20", VA = "0x1829D6120")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x29D61A0", Offset = "0x29D4FA0", VA = "0x1829D61A0", Slot = "4")]
		public HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> IGNIFGMLEKN(int CKFKPOAGPKN)
		{
			return default(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0")]
		public bool PDNFAKHJGLP(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "5")]
		private bool LHFFCNBDDDJ(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x29D6120", Offset = "0x29D4F20", VA = "0x1829D6120", Slot = "6")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> CAFMKAKAAPP(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct OLBHKNCPMGG : HAEDPCNCBBC<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>, GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x29DF390", Offset = "0x29DE190", VA = "0x1829DF390")]
		public OJAIHBKPJPA<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>> BLFIIGLGDAE(int LNFLDNENGDM, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x29DF490", Offset = "0x29DE290", VA = "0x1829DF490")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x29DF400", Offset = "0x29DE200", VA = "0x1829DF400", Slot = "6")]
		public void JALNFDGEAFA(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>> FEBLBJIINOM, HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x29DF390", Offset = "0x29DE190", VA = "0x1829DF390", Slot = "4")]
		private OJAIHBKPJPA<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>> PPJEMGLFCKN(int LNFLDNENGDM, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x29DF490", Offset = "0x29DE290", VA = "0x1829DF490", Slot = "5")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MCHCNOGOFHO(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> CKFKPOAGPKN, [In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct DFFCFNJMBGE : NELJKFHKJGG<HBBCPCNIOON<CJCPCFJCIBN>, GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x29D4C10", Offset = "0x29D3A10", VA = "0x1829D4C10")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(HBBCPCNIOON<CJCPCFJCIBN> CKFKPOAGPKN, [In] GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x29D4B80", Offset = "0x29D3980", VA = "0x1829D4B80", Slot = "4")]
		public HBBCPCNIOON<CJCPCFJCIBN> IGNIFGMLEKN(int CKFKPOAGPKN)
		{
			return default(HBBCPCNIOON<CJCPCFJCIBN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x29D4BB0", Offset = "0x29D39B0", VA = "0x1829D4BB0")]
		public bool PDNFAKHJGLP(HBBCPCNIOON<CJCPCFJCIBN> CKFKPOAGPKN, [In] GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x29D4BB0", Offset = "0x29D39B0", VA = "0x1829D4BB0", Slot = "5")]
		private bool JEHOFEBKAGN(HBBCPCNIOON<CJCPCFJCIBN> CKFKPOAGPKN, [In] GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x29D4B70", Offset = "0x29D3970", VA = "0x1829D4B70", Slot = "6")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> HDMFGFDLCGI(HBBCPCNIOON<CJCPCFJCIBN> CKFKPOAGPKN, [In] GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct GCKBOHMFECF : HAEDPCNCBBC<HBBCPCNIOON<CJCPCFJCIBN>, GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x29D4F40", Offset = "0x29D3D40", VA = "0x1829D4F40")]
		public OJAIHBKPJPA<HBBCPCNIOON<CJCPCFJCIBN>> BLFIIGLGDAE(int LNFLDNENGDM, [In] GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<HBBCPCNIOON<CJCPCFJCIBN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x29D5070", Offset = "0x29D3E70", VA = "0x1829D5070")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(HBBCPCNIOON<CJCPCFJCIBN> CKFKPOAGPKN, [In] GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x29D4FB0", Offset = "0x29D3DB0", VA = "0x1829D4FB0", Slot = "6")]
		public void JALNFDGEAFA(HBBCPCNIOON<CJCPCFJCIBN> CKFKPOAGPKN, GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?> FEBLBJIINOM, HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x29D4F40", Offset = "0x29D3D40", VA = "0x1829D4F40", Slot = "4")]
		private OJAIHBKPJPA<HBBCPCNIOON<CJCPCFJCIBN>> ODDMODCNKDC(int LNFLDNENGDM, [In] GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<HBBCPCNIOON<CJCPCFJCIBN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x29D5060", Offset = "0x29D3E60", VA = "0x1829D5060", Slot = "5")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> JIBIMHIIPDM(HBBCPCNIOON<CJCPCFJCIBN> CKFKPOAGPKN, [In] GHBIFODMAFN<CJCPCFJCIBN, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>?> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct IDCCJEPLDNK : NELJKFHKJGG<int, OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x29D5D80", Offset = "0x29D4B80", VA = "0x1829D5D80")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> VariableId, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB66700", Offset = "0xB65500", VA = "0x180B66700", Slot = "4")]
		public int IGNIFGMLEKN(int CKFKPOAGPKN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0")]
		public bool PDNFAKHJGLP(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> VariableId, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "5")]
		private bool HBJHBBFNFIA(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> VariableId, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x29D5D70", Offset = "0x29D4B70", VA = "0x1829D5D70", Slot = "6")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> HAAHKEJEKKL(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> VariableId, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct DOPBEBBAHMA : HAEDPCNCBBC<int, OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x29D4CB0", Offset = "0x29D3AB0", VA = "0x1829D4CB0")]
		public OJAIHBKPJPA<int> BLFIIGLGDAE(int LNFLDNENGDM, [In] OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> VariableId, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x29D4E20", Offset = "0x29D3C20", VA = "0x1829D4E20")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> VariableId, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x29D4D30", Offset = "0x29D3B30", VA = "0x1829D4D30", Slot = "6")]
		public void JALNFDGEAFA(int CKFKPOAGPKN, OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> VariableId, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>> ByteCodeWriteLocation)> FEBLBJIINOM, HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x29D4CB0", Offset = "0x29D3AB0", VA = "0x1829D4CB0", Slot = "4")]
		private OJAIHBKPJPA<int> LGFCOKCFAHP(int LNFLDNENGDM, [In] OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> VariableId, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x29D4D20", Offset = "0x29D3B20", VA = "0x1829D4D20", Slot = "5")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> HPLHFFANDGF(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> VariableId, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<CMJJGMNNMIB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct PIEEAADIJBK : NELJKFHKJGG<int, OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x29DF9D0", Offset = "0x29DE7D0", VA = "0x1829DF9D0")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB66700", Offset = "0xB65500", VA = "0x180B66700", Slot = "4")]
		public int IGNIFGMLEKN(int CKFKPOAGPKN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0")]
		public bool PDNFAKHJGLP(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "5")]
		private bool IPIHACHIGGL(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x29DF9D0", Offset = "0x29DE7D0", VA = "0x1829DF9D0", Slot = "6")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> GKGAJIKGHEP(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct OBBGHHFFEOC : HAEDPCNCBBC<int, OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x29DF1C0", Offset = "0x29DDFC0", VA = "0x1829DF1C0")]
		public OJAIHBKPJPA<int> BLFIIGLGDAE(int LNFLDNENGDM, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x29DF310", Offset = "0x29DE110", VA = "0x1829DF310")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x29DF230", Offset = "0x29DE030", VA = "0x1829DF230", Slot = "6")]
		public void JALNFDGEAFA(int CKFKPOAGPKN, OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM, HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x29DF1C0", Offset = "0x29DDFC0", VA = "0x1829DF1C0", Slot = "4")]
		private OJAIHBKPJPA<int> CELOOBLBGJL(int LNFLDNENGDM, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x29DF310", Offset = "0x29DE110", VA = "0x1829DF310", Slot = "5")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> PKMONAHMPJH(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct LJFJHCAFLKI : NELJKFHKJGG<int, OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x29D88A0", Offset = "0x29D76A0", VA = "0x1829D88A0")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB66700", Offset = "0xB65500", VA = "0x180B66700", Slot = "4")]
		public int IGNIFGMLEKN(int CKFKPOAGPKN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0")]
		public bool PDNFAKHJGLP(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "5")]
		private bool IPIHACHIGGL(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x29D8890", Offset = "0x29D7690", VA = "0x1829D8890", Slot = "6")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> GKGAJIKGHEP(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct JLKGAFDBFOF : HAEDPCNCBBC<int, OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x29D6210", Offset = "0x29D5010", VA = "0x1829D6210")]
		public OJAIHBKPJPA<int> BLFIIGLGDAE(int LNFLDNENGDM, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x29D6370", Offset = "0x29D5170", VA = "0x1829D6370")]
		public HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x29D6280", Offset = "0x29D5080", VA = "0x1829D6280", Slot = "6")]
		public void JALNFDGEAFA(int CKFKPOAGPKN, OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM, HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x29D6210", Offset = "0x29D5010", VA = "0x1829D6210", Slot = "4")]
		private OJAIHBKPJPA<int> CELOOBLBGJL(int LNFLDNENGDM, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(OJAIHBKPJPA<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x29D63F0", Offset = "0x29D51F0", VA = "0x1829D63F0", Slot = "5")]
		private HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> PKMONAHMPJH(int CKFKPOAGPKN, [In] OJAIHBKPJPA<(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> Target, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> ByteCodeWriteLocation)> FEBLBJIINOM)
		{
			return default(HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct LOMEJPCMBGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> BLKHCGMOCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool PPDGEAPFJHB;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x2099640", Offset = "0x2098440", VA = "0x182099640")]
		public LOMEJPCMBGJ(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM, bool IPJOCMILADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x29D8B00", Offset = "0x29D7900", VA = "0x1829D8B00")]
		public void DNJKCOADEJJ([Out] HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM, [Out] bool IPJOCMILADM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct KEKHDLCIILG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly HBBCPCNIOON<CJCPCFJCIBN> KBICNEPGLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> BLKHCGMOCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool PPDGEAPFJHB;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x29D6430", Offset = "0x29D5230", VA = "0x1829D6430")]
		public KEKHDLCIILG(HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM, bool IPJOCMILADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x29D6400", Offset = "0x29D5200", VA = "0x1829D6400")]
		public void DNJKCOADEJJ([Out] HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM, [Out] bool IPJOCMILADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x29D6410", Offset = "0x29D5210", VA = "0x1829D6410")]
		public void DNJKCOADEJJ([Out] HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM, [Out] HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB, [Out] bool IPJOCMILADM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct HELFOCOAPJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly HBBCPCNIOON<CJCPCFJCIBN> KBICNEPGLHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> BLKHCGMOCCJ;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7B0", Offset = "0xE3A5B0", VA = "0x180E3B7B0")]
		public HELFOCOAPJB(HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x29D5190", Offset = "0x29D3F90", VA = "0x1829D5190")]
		public void DNJKCOADEJJ([Out] HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM, [Out] HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x29D6780", Offset = "0x29D5580", VA = "0x1829D6780")]
	public static void BOGGHIAGAGL(this NAFEFBPFJHC FEOFEEGOGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x29D6CF0", Offset = "0x29D5AF0", VA = "0x1829D6CF0")]
	public static void DJANGBFKLCJ(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<KJOAJLIJKDJ> DMPMODALFLM, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> LOLBICFEECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29D7210", Offset = "0x29D6010", VA = "0x1829D7210")]
	public static void FFBMGIIPNOG(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<KJOAJLIJKDJ> DMPMODALFLM, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> LOLBICFEECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29D82C0", Offset = "0x29D70C0", VA = "0x1829D82C0")]
	public static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>? OAKEPMJOAPA([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<KJOAJLIJKDJ> DMPMODALFLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x29D6BE0", Offset = "0x29D59E0", VA = "0x1829D6BE0")]
	public static HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> CLPPAPJDIJK([In] this NAFEFBPFJHC FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x29D75D0", Offset = "0x29D63D0", VA = "0x1829D75D0")]
	private static void HOANLKJLLHC(this NAFEFBPFJHC FEOFEEGOGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x29D7180", Offset = "0x29D5F80", VA = "0x1829D7180")]
	private static HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>? FFBCEJJPJCG([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x29D78E0", Offset = "0x29D66E0", VA = "0x1829D78E0")]
	public static void IPDGOOGLBDO(this NAFEFBPFJHC FEOFEEGOGIO, [In] OJAIHBKPJPA<ILFCEKNJNEM> AEEGKHPPDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x29D87E0", Offset = "0x29D75E0", VA = "0x1829D87E0")]
	public static MAELHFLAIHO.DMLHNHNKFHJ PPKHNHIJJLG([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM)
	{
		return default(MAELHFLAIHO.DMLHNHNKFHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x29D7040", Offset = "0x29D5E40", VA = "0x1829D7040")]
	public static MPKIBFFOKBM<byte> FCHNDOOPBCB([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM)
	{
		return default(MPKIBFFOKBM<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x29D6C40", Offset = "0x29D5A40", VA = "0x1829D6C40")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> COEAHLOEKOF([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x29D6F90", Offset = "0x29D5D90", VA = "0x1829D6F90")]
	public static PDLHEEOINJI ENCAOFCJOCG([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM)
	{
		return default(PDLHEEOINJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3C488F0", Offset = "0x3C476F0", VA = "0x183C488F0")]
	private static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> KJBJAJBAIEH<TMJoin>(this NAFEFBPFJHC FEOFEEGOGIO, MAELHFLAIHO.DMLHNHNKFHJ JFANEKCFJPP, HBBCPCNIOON<TMJoin> PHOFEEAAGHG) where TMJoin : MAELHFLAIHO.JPHFHMDINAG
	{
		return default(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x29D72E0", Offset = "0x29D60E0", VA = "0x1829D72E0")]
	public static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FJDDHNEBBAD(this NAFEFBPFJHC FEOFEEGOGIO, bool FENAADFCEIG)
	{
		return default(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x29D70F0", Offset = "0x29D5EF0", VA = "0x1829D70F0")]
	public static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FCPILNBFBKD(this NAFEFBPFJHC FEOFEEGOGIO, MPKIBFFOKBM<byte> JMAPKDPGDHP)
	{
		return default(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x29D6DD0", Offset = "0x29D5BD0", VA = "0x1829D6DD0")]
	public static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> EDNOMGCJPAK(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> MGBDJEDFCBP)
	{
		return default(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x29D8180", Offset = "0x29D6F80", VA = "0x1829D8180")]
	public static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> MGNOLOIJFAF(this NAFEFBPFJHC FEOFEEGOGIO, int DAEDDCCGGIA)
	{
		return default(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x29D6AB0", Offset = "0x29D58B0", VA = "0x1829D6AB0")]
	public static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> CDJHFCECFNP(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EIFNHPDMBOB)
	{
		return default(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3C46CE0", Offset = "0x3C45AE0", VA = "0x183C46CE0")]
	private static HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO> AHJFLIFFMDA<TMJoin>(this NAFEFBPFJHC FEOFEEGOGIO, APAGDGHDOCK.ADIPIJFILJG JFANEKCFJPP, HBBCPCNIOON<TMJoin> PHOFEEAAGHG) where TMJoin : APAGDGHDOCK.JBNHBFJBOGD
	{
		return default(HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x29D8610", Offset = "0x29D7410", VA = "0x1829D8610")]
	public static HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO> OMNGPNFKLMA(this NAFEFBPFJHC FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x29D7B00", Offset = "0x29D6900", VA = "0x1829D7B00")]
	public static HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO> KJJHDKPAMBF(this NAFEFBPFJHC FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x29D7D60", Offset = "0x29D6B60", VA = "0x1829D7D60")]
	public static HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO> LDHDONPOLKE(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> HBBBLCEKKGL)
	{
		return default(HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x29D7A50", Offset = "0x29D6850", VA = "0x1829D7A50")]
	public static HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO> KCLMBHFDKCK(this NAFEFBPFJHC FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x29D6D80", Offset = "0x29D5B80", VA = "0x1829D6D80")]
	public static HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO> DLLLKODLBFK(this NAFEFBPFJHC FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29D8780", Offset = "0x29D7580", VA = "0x1829D8780")]
	public static PCNFKLOMOBA.GEDJJICAAPP PKMNNAMHMJI([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI> KGAOEKMFLFI)
	{
		return default(PCNFKLOMOBA.GEDJJICAAPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x29D6580", Offset = "0x29D5380", VA = "0x1829D6580")]
	public static IAJKFBFDADD<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>, ALGNHGDBDEF<PCNFKLOMOBA.KKCDKPGECEB>> AJNCIKFKALM([In] this NAFEFBPFJHC FEOFEEGOGIO)
	{
		return default(IAJKFBFDADD<HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>, ALGNHGDBDEF<PCNFKLOMOBA.KKCDKPGECEB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x29D7B50", Offset = "0x29D6950", VA = "0x1829D7B50")]
	public static HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> LAPGIDMELMF([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI> KGAOEKMFLFI)
	{
		return default(HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29D7AA0", Offset = "0x29D68A0", VA = "0x1829D7AA0")]
	public static PCNFKLOMOBA.GELIKCOKMIG KEMOFKEAPEE([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> PEGMMPPABMF)
	{
		return default(PCNFKLOMOBA.GELIKCOKMIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29D6670", Offset = "0x29D5470", VA = "0x1829D6670")]
	public static PCNFKLOMOBA.GELIKCOKMIG ALGFLGMJOFG(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> PEGMMPPABMF)
	{
		return default(PCNFKLOMOBA.GELIKCOKMIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3C470D0", Offset = "0x3C45ED0", VA = "0x183C470D0")]
	private static HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI> FJPOOIMEDFE<TMJoin>(this NAFEFBPFJHC FEOFEEGOGIO, PCNFKLOMOBA.GEDJJICAAPP JFANEKCFJPP, HBBCPCNIOON<TMJoin> PHOFEEAAGHG) where TMJoin : PCNFKLOMOBA.JCLDFFNPKIH
	{
		return default(HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x29D7F70", Offset = "0x29D6D70", VA = "0x1829D7F70")]
	public static (HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>) MADLDMJAEHL(this NAFEFBPFJHC FEOFEEGOGIO)
	{
		return default((HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x29D7730", Offset = "0x29D6530", VA = "0x1829D7730")]
	public static (HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>) ICMNALFMKIO(this NAFEFBPFJHC FEOFEEGOGIO)
	{
		return default((HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x29D73C0", Offset = "0x29D61C0", VA = "0x1829D73C0")]
	public static HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI> GNLLGHFMGOC(this NAFEFBPFJHC FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x29D7CD0", Offset = "0x29D6AD0", VA = "0x1829D7CD0")]
	public static void LBCIGIPJKLM(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB> PEGMMPPABMF, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> KDGIOKJCBCM, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>> BKPOGMOKEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3C476F0", Offset = "0x3C464F0", VA = "0x183C476F0")]
	public static LOMEJPCMBGJ HDLFOMOCCKC<TDeps, TStateSys>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB) where TDeps : NIMNPPEGLOE<TStateSys>
	{
		return default(LOMEJPCMBGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C46D70", Offset = "0x3C45B70", VA = "0x183C46D70")]
	public static KEKHDLCIILG AOGGEFAGEEJ<TDeps, TStateSys>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KNPFHPANEIM> BPBNOKKGEDO, int PGKOCCKEOFI) where TDeps : NIMNPPEGLOE<TStateSys>
	{
		return default(KEKHDLCIILG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C484D0", Offset = "0x3C472D0", VA = "0x183C484D0")]
	public static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>? IAGBIHKNMIB<TDeps, TStateSys>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KNPFHPANEIM> BPBNOKKGEDO, [In] ReadOnlySpan<int> EHHGCKEBEGE, [In] Span<HELFOCOAPJB> IEELABOAOGH) where TDeps : NIMNPPEGLOE<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3C47160", Offset = "0x3C45F60", VA = "0x183C47160")]
	public static HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO> FOLKNDJIFFC<TDeps, TStateSys>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KJOAJLIJKDJ> DMPMODALFLM) where TDeps : NIMNPPEGLOE<TStateSys>
	{
		return default(HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x29D6B30", Offset = "0x29D5930", VA = "0x1829D6B30")]
	public static IJJGMDABGMJ.EPDODKPLGCI CLEIKIINEEO([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PPPFBKMGIMA)
	{
		return default(IJJGMDABGMJ.EPDODKPLGCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29D6EE0", Offset = "0x29D5CE0", VA = "0x1829D6EE0")]
	public static IJJGMDABGMJ.LFCBBFMGKFH EMFPICGHAPI([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PPPFBKMGIMA)
	{
		return default(IJJGMDABGMJ.LFCBBFMGKFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x29D65C0", Offset = "0x29D53C0", VA = "0x1829D65C0")]
	public static IJJGMDABGMJ.ENBLMKJPFMJ ALGCGHDKMLD([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PPPFBKMGIMA)
	{
		return default(IJJGMDABGMJ.ENBLMKJPFMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x29D7410", Offset = "0x29D6210", VA = "0x1829D7410")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> HBMMJHIGCJN(this NAFEFBPFJHC FEOFEEGOGIO, int? FHNEJCMBLKL, string GGDFKFACHGG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x29D66D0", Offset = "0x29D54D0", VA = "0x1829D66D0")]
	public static IJJGMDABGMJ.HFPKLIIJCKM BELABAOLGBJ([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PPPFBKMGIMA)
	{
		return default(IJJGMDABGMJ.HFPKLIIJCKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x29D7360", Offset = "0x29D6160", VA = "0x1829D7360")]
	public static IJJGMDABGMJ.AAHLHCBCEKO GDLNKLBMOHF([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PPPFBKMGIMA)
	{
		return default(IJJGMDABGMJ.AAHLHCBCEKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x29D8120", Offset = "0x29D6F20", VA = "0x1829D8120")]
	public static int? MFAMPFLABFD([In] this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PPPFBKMGIMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3C46FF0", Offset = "0x3C45DF0", VA = "0x183C46FF0")]
	private static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> CCNKFAEPHEI<TMJoin>(this NAFEFBPFJHC FEOFEEGOGIO, int? FHNEJCMBLKL, IJJGMDABGMJ.AAHLHCBCEKO JFANEKCFJPP, HBBCPCNIOON<TMJoin> PHOFEEAAGHG) where TMJoin : IJJGMDABGMJ.CFCPOBLKPDD
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x29D8560", Offset = "0x29D7360", VA = "0x1829D8560")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> OMLPGIMJBJD(this NAFEFBPFJHC FEOFEEGOGIO, int? FHNEJCMBLKL, HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI> KGAOEKMFLFI, int CKFKPOAGPKN)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x29D6A50", Offset = "0x29D5850", VA = "0x1829D6A50")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> CCALJEABPFL(this NAFEFBPFJHC FEOFEEGOGIO, int? FHNEJCMBLKL)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x29D7DE0", Offset = "0x29D6BE0", VA = "0x1829D7DE0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> LEPDCLOFOBC(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>? IDODFHDDLGI, int? FHNEJCMBLKL)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29D6E50", Offset = "0x29D5C50", VA = "0x1829D6E50")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EHJBMNAALHF(this NAFEFBPFJHC FEOFEEGOGIO, int? FHNEJCMBLKL, int CKFKPOAGPKN)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x29D8500", Offset = "0x29D7300", VA = "0x1829D8500")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> OLLGLEGGEDE(this NAFEFBPFJHC FEOFEEGOGIO, int? FHNEJCMBLKL)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x29D8650", Offset = "0x29D7450", VA = "0x1829D8650")]
	public static void PGMIEEKDDGO(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EIFNHPDMBOB, HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI> KGAOEKMFLFI, int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x29D8350", Offset = "0x29D7150", VA = "0x1829D8350")]
	public static void OCGLBOBMCGD(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EIFNHPDMBOB, int CKFKPOAGPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29D64C0", Offset = "0x29D52C0", VA = "0x1829D64C0")]
	public static void ACNKLJDAODB(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EIFNHPDMBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x29D8470", Offset = "0x29D7270", VA = "0x1829D8470")]
	public static void OLEMJINJCJF(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> IMBAOPHEODM, HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> OKONBHMPBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29D8200", Offset = "0x29D7000", VA = "0x1829D8200")]
	public static void NEAANFOFCAE(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EIFNHPDMBOB, HBBCPCNIOON<JDDKNNOFDCE<PBFFPGONLAD>> FCALCFKCPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3C48980", Offset = "0x3C47780", VA = "0x183C48980")]
	public static void KJEGJHMKIMJ<M>(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EIFNHPDMBOB, HBBCPCNIOON<JDDKNNOFDCE<NNNCHCBIJGL<M>>> FCALCFKCPOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NIMNPPEGLOE<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HBBCPCNIOON<OLOEGFAPHEG> FPDHBOMBCJH(TStateSys DOIBAFBKDCO);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HBBCPCNIOON<OLOEGFAPHEG> JODFCCEGFBA(TStateSys DOIBAFBKDCO);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HBBCPCNIOON<OLOEGFAPHEG> DEILNIPCNJI(TStateSys DOIBAFBKDCO);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HBBCPCNIOON<OLOEGFAPHEG> HHFHNNAHPGA(TStateSys DOIBAFBKDCO);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO> LIACMLPPBKJ(TStateSys DOIBAFBKDCO, NAFEFBPFJHC KEKIAHEEDKM, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> KAHKJDOMAJD(TStateSys DOIBAFBKDCO, NAFEFBPFJHC KEKIAHEEDKM, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KJOAJLIJKDJ> DMPMODALFLM);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JCFPEFPEFOC(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HBBCPCNIOON<KJOAJLIJKDJ> LCKPEDMFEJG(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB, int GMKGGMCELLE);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	ICCODGOOPFK IOGFOPOKDFN(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KNNHFGCDIJJ(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int LIGGEMFMIKE(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MPKIBFFOKBM<byte> AFIEBCKFMBN(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(MPKIBFFOKBM<byte>, HBBCPCNIOON<OLOEGFAPHEG>) LLMAOEOKICO(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<CJCPCFJCIBN> BPEIPEAIKOB);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int MMEPKIIKLAJ(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KJOAJLIJKDJ> DMPMODALFLM);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	HBBCPCNIOON<CJCPCFJCIBN> NHDFHALDAMH(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KJOAJLIJKDJ> DMPMODALFLM, int PGKOCCKEOFI);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HBBCPCNIOON<CJCPCFJCIBN> CPNLEJJDOLJ(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KNPFHPANEIM> BPBNOKKGEDO, int PGKOCCKEOFI);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int DJJDLJEFIKA(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? LOHOPBIAJNL(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, int CKFKPOAGPKN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int IHOGABEKGPH(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? OIHPBDPOPDJ(TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, int CKFKPOAGPKN);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NJCPAMEFOPB
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3D0CD40", Offset = "0x3D0BB40", VA = "0x183D0CD40")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM?> KDFGDDHBGKK<T, TOpInput, TOpOutput>(this NAFEFBPFJHC FEOFEEGOGIO, T PHLJLBDJNIE, T GEOHFJAPCHG, int PAAONFGFGHG, IntPtr NNAICENCINP)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C630", Offset = "0x3D0B430", VA = "0x183D0C630")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM?> JEOKEJNOJPF<T, TOpInput, TOpOutput>(this NAFEFBPFJHC FEOFEEGOGIO, T PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG, int PAAONFGFGHG, IntPtr NNAICENCINP)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C2E0", Offset = "0x3D0B0E0", VA = "0x183D0C2E0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM?> GAILGAOIFKK<TOpInput, TOpOutput>(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG, int PAAONFGFGHG, IntPtr NNAICENCINP)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x29DB340", Offset = "0x29DA140", VA = "0x1829DB340")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EBPEGNPOJIB(this NAFEFBPFJHC FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x29DC2C0", Offset = "0x29DB0C0", VA = "0x1829DC2C0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GAJLAMDFIEL(this NAFEFBPFJHC FEOFEEGOGIO, float MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x29DE000", Offset = "0x29DCE00", VA = "0x1829DE000")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> KPAEKELLKDM(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x29DE5A0", Offset = "0x29DD3A0", VA = "0x1829DE5A0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MDPOGKBADHN(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x29DE960", Offset = "0x29DD760", VA = "0x1829DE960")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> ONJPBALLJFF(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x29DA600", Offset = "0x29D9400", VA = "0x1829DA600")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> CHCDOCBOPNC(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x29DE7E0", Offset = "0x29DD5E0", VA = "0x1829DE7E0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> OFBKIDFJLAO(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x29DC1A0", Offset = "0x29DAFA0", VA = "0x1829DC1A0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> FOIAIMPMJFI(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x29DD120", Offset = "0x29DBF20", VA = "0x1829DD120")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> ICMNOELFAHA(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x29DE420", Offset = "0x29DD220", VA = "0x1829DE420")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> LJOBNCAMCGI(this NAFEFBPFJHC FEOFEEGOGIO, int PHLJLBDJNIE, int GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x29DD620", Offset = "0x29DC420", VA = "0x1829DD620")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> JCMIJOHOEPK(this NAFEFBPFJHC FEOFEEGOGIO, int PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x29D9FF0", Offset = "0x29D8DF0", VA = "0x1829D9FF0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BGAECNIHJNB(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x29DACB0", Offset = "0x29D9AB0", VA = "0x1829DACB0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> DCNDIHHGOMD(this NAFEFBPFJHC FEOFEEGOGIO, float PHLJLBDJNIE, float GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x29DDED0", Offset = "0x29DCCD0", VA = "0x1829DDED0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> KNMCKLFCHEO(this NAFEFBPFJHC FEOFEEGOGIO, float PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x29DDC50", Offset = "0x29DCA50", VA = "0x1829DDC50")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> KBHONDOOOCJ(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x29DE8E0", Offset = "0x29DD6E0", VA = "0x1829DE8E0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> OLDLGFJDCOP(this NAFEFBPFJHC FEOFEEGOGIO, int PHLJLBDJNIE, int GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x29DE3A0", Offset = "0x29DD1A0", VA = "0x1829DE3A0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> LDPPPNKFLIJ(this NAFEFBPFJHC FEOFEEGOGIO, int PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x29DDA40", Offset = "0x29DC840", VA = "0x1829DDA40")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> JIPNHCNIEDJ(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x29DEA80", Offset = "0x29DD880", VA = "0x1829DEA80")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> OOEIJPJCEPF(this NAFEFBPFJHC FEOFEEGOGIO, float PHLJLBDJNIE, float GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x29DE740", Offset = "0x29DD540", VA = "0x1829DE740")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> NAFDGEGIEJO(this NAFEFBPFJHC FEOFEEGOGIO, float PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x29DD9C0", Offset = "0x29DC7C0", VA = "0x1829DD9C0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> JGPNCDLGNLK(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x29DA2B0", Offset = "0x29D90B0", VA = "0x1829DA2B0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BOPGBCCODBH(this NAFEFBPFJHC FEOFEEGOGIO, int PHLJLBDJNIE, int GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x29DE520", Offset = "0x29DD320", VA = "0x1829DE520")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> LPDEFDMEBCI(this NAFEFBPFJHC FEOFEEGOGIO, int PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x29DDBD0", Offset = "0x29DC9D0", VA = "0x1829DDBD0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> JOBBCEIOOIM(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x29DD5A0", Offset = "0x29DC3A0", VA = "0x1829DD5A0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> IPFFIDOMBEK(this NAFEFBPFJHC FEOFEEGOGIO, float PHLJLBDJNIE, float GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x29DA580", Offset = "0x29D9380", VA = "0x1829DA580")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> CGOKIGPKCLN(this NAFEFBPFJHC FEOFEEGOGIO, float PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x29DBB10", Offset = "0x29DA910", VA = "0x1829DBB10")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> FDFMGJNJIJC(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x29DC870", Offset = "0x29DB670", VA = "0x1829DC870")]
	public static HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> GMGLGCEPBCO(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x29DC3E0", Offset = "0x29DB1E0", VA = "0x1829DC3E0")]
	public static HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> GCAAACEGMNB(this NAFEFBPFJHC FEOFEEGOGIO, int BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x29DE6A0", Offset = "0x29DD4A0", VA = "0x1829DE6A0")]
	public static HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> MOEDLLHEPMP(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x29DB540", Offset = "0x29DA340", VA = "0x1829DB540")]
	public static HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> EKMDEINBPKC(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FONPFLLIJJM)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x29DC770", Offset = "0x29DB570", VA = "0x1829DC770")]
	public static HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> GLDACLABBBN(this NAFEFBPFJHC FEOFEEGOGIO, int BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x29DC100", Offset = "0x29DAF00", VA = "0x1829DC100")]
	public static HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> FNLKJAAFNFO(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BNECONOIKOE)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x29DBB90", Offset = "0x29DA990", VA = "0x1829DBB90")]
	public static (HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>) FJBJNPEACDE(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<GOOCMPIBMLE> KAFHHGJGNMB, [In] ReadOnlySpan<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> FLNLCOLLCMF, [In] ReadOnlySpan<int?> DNDEDNMCNEF, [In] Span<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> DPGJEABJFLA)
	{
		return default((HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x29DA740", Offset = "0x29D9540", VA = "0x1829DA740")]
	public static (HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>) CHLPDPKIKDF(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<DNHAKBEOBHF> NFNLFKGCHIM, [In] ReadOnlySpan<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> FLNLCOLLCMF, [In] ReadOnlySpan<int?> DNDEDNMCNEF, [In] Span<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> DPGJEABJFLA)
	{
		return default((HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3D0E4F0", Offset = "0x3D0D2F0", VA = "0x183D0E4F0")]
	public static (HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<OLOEGFAPHEG>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<TMarker>>, HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>) PIOPEHHNCNI<TMarker>(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<OLOEGFAPHEG> IEOLNLCELKI, [In] ReadOnlySpan<byte> BOIPFNOKGBJ)
	{
		return default((HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<JDDKNNOFDCE<OLOEGFAPHEG>>, HBBCPCNIOON<JDDKNNOFDCE<EJCLCGIGHHB>>, HBBCPCNIOON<JDDKNNOFDCE<TMarker>>, HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x29DEB00", Offset = "0x29DD900", VA = "0x1829DEB00")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> OOMEIINLAIB(this NAFEFBPFJHC FEOFEEGOGIO, int BDNOGLGKMMF, [Optional] HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>? BHIDIDEELPL)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x29DBA20", Offset = "0x29DA820", VA = "0x1829DBA20")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EMEIBDFHHGE(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BDNOGLGKMMF, [Optional] HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>? BHIDIDEELPL)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x29DB030", Offset = "0x29D9E30", VA = "0x1829DB030")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> DKHNAMAODEJ(this NAFEFBPFJHC FEOFEEGOGIO, [In] ReadOnlySpan<byte> BDNOGLGKMMF, [Optional] HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>? BHIDIDEELPL)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x29DEDE0", Offset = "0x29DDBE0", VA = "0x1829DEDE0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PLIKFLNODHN(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BDNOGLGKMMF, int DFCCCGNJINK, [Optional] HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>? BHIDIDEELPL)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x29DB440", Offset = "0x29DA240", VA = "0x1829DB440")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EGNDEFOMJIL(this NAFEFBPFJHC FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x29DD360", Offset = "0x29DC160", VA = "0x1829DD360")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> INBAIKEMIML(this NAFEFBPFJHC FEOFEEGOGIO, float MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x29DB720", Offset = "0x29DA520", VA = "0x1829DB720")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> EKNPIIMFDHM(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x29DD010", Offset = "0x29DBE10", VA = "0x1829DD010")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> HGCLMGANEGF(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x29DB120", Offset = "0x29D9F20", VA = "0x1829DB120")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> DLDLNCDEMOG(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x29DAEF0", Offset = "0x29D9CF0", VA = "0x1829DAEF0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> DJNKMNMIAPO(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x29DC7F0", Offset = "0x29DB5F0", VA = "0x1829DC7F0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GLIHKIELJMP(this NAFEFBPFJHC FEOFEEGOGIO, int PHLJLBDJNIE, int GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x29DB860", Offset = "0x29DA660", VA = "0x1829DB860")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> ELHADGKEFEO(this NAFEFBPFJHC FEOFEEGOGIO, int PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x29DA130", Offset = "0x29D8F30", VA = "0x1829DA130")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BGHINBCOPPG(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PHLJLBDJNIE, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GEOHFJAPCHG)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x29DA1B0", Offset = "0x29D8FB0", VA = "0x1829DA1B0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BKHCLHBEHHI(this NAFEFBPFJHC FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x29DA450", Offset = "0x29D9250", VA = "0x1829DA450")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> CCIOGIMMBNI(this NAFEFBPFJHC FEOFEEGOGIO, float MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x29D9EB0", Offset = "0x29D8CB0", VA = "0x1829D9EB0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> AIHFIBAFKPP(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x29DCA50", Offset = "0x29DB850", VA = "0x1829DCA50")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GPEBIDHIGIB(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x29D9D90", Offset = "0x29D8B90", VA = "0x1829D9D90")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> AHMCAICNFKA(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x29DD740", Offset = "0x29DC540", VA = "0x1829DD740")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> JDOOFALIBFM(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x29DE7C0", Offset = "0x29DD5C0", VA = "0x1829DE7C0")]
	public static HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>> NCPLBJEPOPK(this NAFEFBPFJHC FEOFEEGOGIO)
	{
		return default(HBBCPCNIOON<JDDKNNOFDCE<JDDKNNOFDCE<POGJONOCEFB>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x29DECE0", Offset = "0x29DDAE0", VA = "0x1829DECE0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PGBPCDAJOAD(this NAFEFBPFJHC FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x29DE280", Offset = "0x29DD080", VA = "0x1829DE280")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> LBNGJAPNFML(this NAFEFBPFJHC FEOFEEGOGIO, float MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x29DB8E0", Offset = "0x29DA6E0", VA = "0x1829DB8E0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> ELLNOIDJLBA(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x29DCB50", Offset = "0x29DB950", VA = "0x1829DCB50")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> GPGCFJLGEOM(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x29DA330", Offset = "0x29D9130", VA = "0x1829DA330")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> CBDCICHEOPI(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x29DADB0", Offset = "0x29D9BB0", VA = "0x1829DADB0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> DDPCCIOOPBJ(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x29DC000", Offset = "0x29DAE00", VA = "0x1829DC000")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> FNCCIHDPIKO(this NAFEFBPFJHC FEOFEEGOGIO, int BNECONOIKOE)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x29DDAC0", Offset = "0x29DC8C0", VA = "0x1829DDAC0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> JJLJLKNGDED(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BNECONOIKOE)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x29DD110", Offset = "0x29DBF10", VA = "0x1829DD110")]
	public static void HJDODBPBBEG(this NAFEFBPFJHC FEOFEEGOGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x29DABB0", Offset = "0x29D99B0", VA = "0x1829DABB0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> CIJCAILLBID(this NAFEFBPFJHC FEOFEEGOGIO, float MKJOHHEOFOA, float BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x29DEBC0", Offset = "0x29DD9C0", VA = "0x1829DEBC0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PCDKDNBCOAJ(this NAFEFBPFJHC FEOFEEGOGIO, float MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x29DDD90", Offset = "0x29DCB90", VA = "0x1829DDD90")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> KGBFEGNNOHN(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x29DD260", Offset = "0x29DC060", VA = "0x1829DD260")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> IKJHCGLICAI(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x29DEF00", Offset = "0x29DDD00", VA = "0x1829DEF00")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> POFAOACBJBJ(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x29D9C50", Offset = "0x29D8A50", VA = "0x1829D9C50")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> ACHDGLBFIJH(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x29DCC50", Offset = "0x29DBA50", VA = "0x1829DCC50")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> HALNAOANPGF(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> EPCFOAINNFN, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> BABBGJPJAHJ)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x29DB240", Offset = "0x29DA040", VA = "0x1829DB240")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> DLIGHIOJOMM(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, int BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x29DD480", Offset = "0x29DC280", VA = "0x1829DD480")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> INIPOIJIJFG(this NAFEFBPFJHC FEOFEEGOGIO, int MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x29DD880", Offset = "0x29DC680", VA = "0x1829DD880")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> JGPKICKGGMJ(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> MKJOHHEOFOA, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BPBBEDOFING)
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3D0BDD0", Offset = "0x3D0ABD0", VA = "0x183D0BDD0")]
	public static void CDPMCOMIEDC<TDeps, TState>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TState EOMNODKHFBK, HBBCPCNIOON<GOOCMPIBMLE> KAFHHGJGNMB, [In] ReadOnlySpan<HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>> NKAPHCADJEJ, [In] ReadOnlySpan<int?> DNDEDNMCNEF, [In] Span<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> DPGJEABJFLA, [In] Span<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> EJCINHNECHP, [In] ReadOnlySpan<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>?> NCNBALOBJAB) where TDeps : notnull, NIMNPPEGLOE<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3D0DBB0", Offset = "0x3D0C9B0", VA = "0x183D0DBB0")]
	public static void PBBDMDFGHMI<TDeps, TState>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TState EOMNODKHFBK, HBBCPCNIOON<DNHAKBEOBHF> FAMNJGOAPBK, [In] ReadOnlySpan<HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>> CMNHAAHFHKM, [In] ReadOnlySpan<int?> DNDEDNMCNEF, [In] Span<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> DPGJEABJFLA, [In] Span<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>> EJCINHNECHP, [In] ReadOnlySpan<HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>?> NCNBALOBJAB) where TDeps : notnull, NIMNPPEGLOE<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3D0B8B0", Offset = "0x3D0A6B0", VA = "0x183D0B8B0")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BGJBEAAHEIB<TDeps, TState>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TState EOMNODKHFBK, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> IDODFHDDLGI, [Optional] HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>? BHIDIDEELPL) where TDeps : notnull, NIMNPPEGLOE<TState> where TState : notnull
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C910", Offset = "0x3D0B710", VA = "0x183D0C910")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> JGAGDBBPOBM<TDeps, TState>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TState EOMNODKHFBK, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> HBBBLCEKKGL, [Optional] HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>? BHIDIDEELPL) where TDeps : notnull, NIMNPPEGLOE<TState> where TState : notnull
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3D0C400", Offset = "0x3D0B200", VA = "0x183D0C400")]
	public static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> GGPCGLEDEEK<TDeps, TStateSys>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TStateSys DOIBAFBKDCO) where TDeps : notnull, NIMNPPEGLOE<TStateSys> where TStateSys : notnull
	{
		return default(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3D0CFE0", Offset = "0x3D0BDE0", VA = "0x183D0CFE0")]
	public static HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO> MKALFFGOKIH<TDeps, TStateSys>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TStateSys DOIBAFBKDCO) where TDeps : notnull, NIMNPPEGLOE<TStateSys> where TStateSys : notnull
	{
		return default(HBBCPCNIOON<APAGDGHDOCK.PDBEOHPCLAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x29DE140", Offset = "0x29DCF40", VA = "0x1829DE140")]
	public static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> KPGMPDFHFLG(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> PKEIBEIHGLF, IntPtr PKJDIKNIMBE, IntPtr EPPKABAALIP)
	{
		return default(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x29DC460", Offset = "0x29DB260", VA = "0x1829DC460")]
	public static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> GIIJBAPABAN(this NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FMECIMDJPDB, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> LIFAJPGHMGF, IntPtr DCKLFBAILHL, IntPtr FNNFCKBGFHD, IntPtr KNFOCLFKODN, bool IDMACDPPKNN)
	{
		return default(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D500", Offset = "0x3D0C300", VA = "0x183D0D500")]
	public static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> NFGDLOGJBOE<TDeps, TState>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TState EOMNODKHFBK, HBBCPCNIOON<GOOCMPIBMLE> PGILDBIGKDO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FMECIMDJPDB, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> LIFAJPGHMGF, int? LDCFLLNPKHF, [Optional] IntPtr MNMABGDDFIA) where TDeps : notnull, NIMNPPEGLOE<TState> where TState : notnull
	{
		return default(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3D0D1F0", Offset = "0x3D0BFF0", VA = "0x183D0D1F0")]
	private static HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> NFGDLOGJBOE<TDeps, TState>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TState EOMNODKHFBK, HBBCPCNIOON<GOOCMPIBMLE> PGILDBIGKDO, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> FMECIMDJPDB, HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO> LIFAJPGHMGF, int? LDCFLLNPKHF) where TDeps : notnull, NIMNPPEGLOE<TState> where TState : notnull
	{
		return default(HBBCPCNIOON<MAELHFLAIHO.LGIBKAHNBCO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3D0BA70", Offset = "0x3D0A870", VA = "0x183D0BA70")]
	public static HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BKOEBIGMBNI<TDeps, TState>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TState EOMNODKHFBK, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> BDNOGLGKMMF, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>? BHIDIDEELPL) where TDeps : notnull, NIMNPPEGLOE<TState> where TState : notnull
	{
		return default(HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3D0E0C0", Offset = "0x3D0CEC0", VA = "0x183D0E0C0")]
	public static void PIKBEPFOGNA<TDeps, TState>(this NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TState EOMNODKHFBK, int KBFFCOKIMFI) where TDeps : notnull, NIMNPPEGLOE<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct MMAAHLOPGNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> DANMKMNDKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> AINKPLLNPFF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xE3B7B0", Offset = "0xE3A5B0", VA = "0x180E3B7B0")]
	public MMAAHLOPGNM(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> CHOPEBPJPHD, HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> NBOCNEAFJBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x29D8E80", Offset = "0x29D7C80", VA = "0x1829D8E80")]
	public static MMAAHLOPGNM OGAKBGHEIKK(HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>> CHOPEBPJPHD)
	{
		return default(MMAAHLOPGNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct IJJGMDABGMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class FOHMBPMOGMG : CFCPOBLKPDD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct EPDODKPLGCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI> CJAHDBOMJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int GBFKBOHPEJM;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7B0", Offset = "0xE3A5B0", VA = "0x180E3B7B0")]
		public EPDODKPLGCI(HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI> KGAOEKMFLFI, int CKFKPOAGPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class MOCLLHHABCA : CFCPOBLKPDD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct LFCBBFMGKFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int GBFKBOHPEJM;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
		public LFCBBFMGKFH(int CKFKPOAGPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class MMOCOOLLDJG : CFCPOBLKPDD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct ENBLMKJPFMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI> CJAHDBOMJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int GBFKBOHPEJM;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7B0", Offset = "0xE3A5B0", VA = "0x180E3B7B0")]
		public ENBLMKJPFMJ(HBBCPCNIOON<PCNFKLOMOBA.LGOCLAGJFGI> KGAOEKMFLFI, int CKFKPOAGPKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum AAHLHCBCEKO
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
	public sealed class IJHNGFKJAOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class CFCPOBLKPDD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct JGJMCEPDIDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? MKPBEBIDAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public MMAAHLOPGNM GGBGLHOMPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public AAHLHCBCEKO JHDJOPLIDON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public HBBCPCNIOON<CFCPOBLKPDD> LKOAGGONJHH;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x29D61F0", Offset = "0x29D4FF0", VA = "0x1829D61F0")]
		public JGJMCEPDIDG(int? FHNEJCMBLKL, [In] MMAAHLOPGNM KJAIJKMOBEM, AAHLHCBCEKO JFANEKCFJPP, HBBCPCNIOON<CFCPOBLKPDD> PHOFEEAAGHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class FCPNPCAPBDA : CFCPOBLKPDD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct HFPKLIIJCKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int GBFKBOHPEJM;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x14A3E20", Offset = "0x14A2C20", VA = "0x1814A3E20")]
		public HFPKLIIJCKM(int CKFKPOAGPKN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal OMJAEEKOKJJ<IJHNGFKJAOM, JGJMCEPDIDG> LNOLIBJKCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal OMJAEEKOKJJ<FOHMBPMOGMG, EPDODKPLGCI> NKDAFPECFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal OMJAEEKOKJJ<MMOCOOLLDJG, ENBLMKJPFMJ> CFCHGMJDFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal OMJAEEKOKJJ<FCPNPCAPBDA, HFPKLIIJCKM> ECGPHJCJJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal OMJAEEKOKJJ<MOCLLHHABCA, LFCBBFMGKFH> PMOGJFEJMAJ;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x29D5FF0", Offset = "0x29D4DF0", VA = "0x1829D5FF0")]
	private IJJGMDABGMJ([In] OMJAEEKOKJJ<IJHNGFKJAOM, JGJMCEPDIDG> PNCIHFJAGLB, [In] OMJAEEKOKJJ<FOHMBPMOGMG, EPDODKPLGCI> AIAKBDLCEIO, [In] OMJAEEKOKJJ<MMOCOOLLDJG, ENBLMKJPFMJ> MCNCLJHAGPK, [In] OMJAEEKOKJJ<FCPNPCAPBDA, HFPKLIIJCKM> GFJPKBDFEAM, [In] OMJAEEKOKJJ<MOCLLHHABCA, LFCBBFMGKFH> NOKHKAGAJIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x29D5E00", Offset = "0x29D4C00", VA = "0x1829D5E00")]
	public static IJJGMDABGMJ OGAKBGHEIKK()
	{
		return default(IJJGMDABGMJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NLHMOCCKJBE
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x29DF090", Offset = "0x29DDE90", VA = "0x1829DF090")]
	public static void BOGGHIAGAGL(this IJJGMDABGMJ FEOFEEGOGIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class HHPEPHIACFD
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x29D5C10", Offset = "0x29D4A10", VA = "0x1829D5C10")]
	public static void DIEFFEOBOIO(NAFEFBPFJHC FEOFEEGOGIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct BLIHHDADEOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, MBOBBGFKOLM> EIGPJNKLCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int LCBIHDCJIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int DIHJGHKEJDB;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x29D48D0", Offset = "0x29D36D0", VA = "0x1829D48D0")]
	private BLIHHDADEOA([In] GHBIFODMAFN<PCNFKLOMOBA.KKCDKPGECEB, MBOBBGFKOLM> OCHLGNHKHFE, int GPFHCHADFCJ, int PLBKNAOABLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x29D4860", Offset = "0x29D3660", VA = "0x1829D4860")]
	public static BLIHHDADEOA OGAKBGHEIKK()
	{
		return default(BLIHHDADEOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x29D4690", Offset = "0x29D3490", VA = "0x1829D4690")]
	public void BOGGHIAGAGL([In] NAFEFBPFJHC JACKFIDBPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x39398B0", Offset = "0x39386B0", VA = "0x1839398B0")]
	public static void DIEFFEOBOIO<TDeps, TStateSys>(NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TStateSys DOIBAFBKDCO, HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN) where TDeps : notnull, NIMNPPEGLOE<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PFHKEBFEJGA
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x29DF820", Offset = "0x29DE620", VA = "0x1829DF820")]
	public static void DIEFFEOBOIO(NAFEFBPFJHC FEOFEEGOGIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct AIDADMKLBAB
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface HAEDDPINBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FJNBDDFDDAC(OJAIHBKPJPA<byte> KMNJHDICDEJ, int FNCDHPMGAAN);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct AGHHKHJLENO : HAEDDPINBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x29D4400", Offset = "0x29D3200", VA = "0x1829D4400", Slot = "4")]
		public void FJNBDDFDDAC(OJAIHBKPJPA<byte> KMNJHDICDEJ, int FNCDHPMGAAN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct MLBGEKKNJBB : HAEDDPINBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x29D8DE0", Offset = "0x29D7BE0", VA = "0x1829D8DE0", Slot = "4")]
		public void FJNBDDFDDAC(OJAIHBKPJPA<byte> KMNJHDICDEJ, int FNCDHPMGAAN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct KLBGBAJCCKE : HAEDDPINBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x29D6440", Offset = "0x29D5240", VA = "0x1829D6440", Slot = "4")]
		public void FJNBDDFDDAC(OJAIHBKPJPA<byte> KMNJHDICDEJ, int FNCDHPMGAAN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct GBPJDBPDHEM : HAEDDPINBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x29D4EA0", Offset = "0x29D3CA0", VA = "0x1829D4EA0", Slot = "4")]
		public void FJNBDDFDDAC(OJAIHBKPJPA<byte> KMNJHDICDEJ, int FNCDHPMGAAN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class BLABCBDLILB<TCallProcessorDeps> where TCallProcessorDeps : struct, HAEDDPINBMG
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps IHILFMGFJPA;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3F32E30", Offset = "0x3F31C30", VA = "0x183F32E30")]
		public static int DIEFFEOBOIO<TDeps, TStateSys>(TDeps FEBHHEFFJMB, TStateSys EOMNODKHFBK, NAFEFBPFJHC JACKFIDBPJG, [In] OJAIHBKPJPA<byte> EBNIOOKBOHL, int ILCFCFOGKMI) where TDeps : NIMNPPEGLOE<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private OJAIHBKPJPA<ILFCEKNJNEM> MNKCLDLKOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>> JCNPFGHKMBF;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x29D4580", Offset = "0x29D3380", VA = "0x1829D4580")]
	private AIDADMKLBAB([In] OJAIHBKPJPA<ILFCEKNJNEM> AEEGKHPPDBG, Dictionary<HBBCPCNIOON<JDDKNNOFDCE<POGJONOCEFB>>, HBBCPCNIOON<PCNFKLOMOBA.KKCDKPGECEB>> AELHMCHOMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x29D44C0", Offset = "0x29D32C0", VA = "0x1829D44C0")]
	public static AIDADMKLBAB OGAKBGHEIKK()
	{
		return default(AIDADMKLBAB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x29D4480", Offset = "0x29D3280", VA = "0x1829D4480")]
	public void BOGGHIAGAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3118B40", Offset = "0x3117940", VA = "0x183118B40")]
	public static void DIEFFEOBOIO<TDeps, TStateSys>(NAFEFBPFJHC FEOFEEGOGIO, TDeps FEBHHEFFJMB, TStateSys DOIBAFBKDCO) where TDeps : NIMNPPEGLOE<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class HEOIODMJDBH
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct KAFOBGOGLNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PDEFFEMLBGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int DJKNDBCGENH;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int NMPAPFHGNFG;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int ECLFJNEAINO;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x29D52D0", Offset = "0x29D40D0", VA = "0x1829D52D0")]
	public static void DIEFFEOBOIO(NAFEFBPFJHC FEOFEEGOGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x29D5840", Offset = "0x29D4640", VA = "0x1829D5840")]
	private static void JLINDNBGPFH([In] NAFEFBPFJHC FEOFEEGOGIO, HBBCPCNIOON<IJJGMDABGMJ.IJHNGFKJAOM> PPPFBKMGIMA, OJAIHBKPJPA<byte> HINLJAEMHLJ, List<KAFOBGOGLNC> IBABHEKPMPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x29D5A70", Offset = "0x29D4870", VA = "0x1829D5A70")]
	private static void JLINDNBGPFH(OJAIHBKPJPA<byte> HINLJAEMHLJ, int DFCCCGNJINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x29D51A0", Offset = "0x29D3FA0", VA = "0x1829D51A0")]
	private static void BCBNCMADFLP(NAFEFBPFJHC FEOFEEGOGIO, List<KAFOBGOGLNC> IBABHEKPMPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class LBKMHKKLIAG<TDeps, TIndex, TValues> where TDeps : struct, HAEDPCNCBBC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps IHILFMGFJPA;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x54043D0", Offset = "0x54031D0", VA = "0x1854043D0")]
	public static void DIEFFEOBOIO([In] OJAIHBKPJPA<ILFCEKNJNEM> AEEGKHPPDBG, int LNFLDNENGDM, TValues FEBLBJIINOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HAEDPCNCBBC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OJAIHBKPJPA<TIndex> BLFIIGLGDAE(int LNFLDNENGDM, [In] TValues FEBLBJIINOM);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(TIndex CKFKPOAGPKN, [In] TValues FEBLBJIINOM);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JALNFDGEAFA(TIndex CKFKPOAGPKN, TValues FEBLBJIINOM, HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> BNECONOIKOE);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface NELJKFHKJGG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex IGNIFGMLEKN(int CKFKPOAGPKN);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PDNFAKHJGLP(TIndex CKFKPOAGPKN, [In] TValues FEBLBJIINOM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HBBCPCNIOON<JDDKNNOFDCE<CMJJGMNNMIB>> MHJIPDKFCEJ(TIndex CKFKPOAGPKN, [In] TValues FEBLBJIINOM);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class FLCBLPADOOM<TDeps, TIndex, TValues> where TDeps : struct, NELJKFHKJGG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps IHILFMGFJPA;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4CBEE80", Offset = "0x4CBDC80", VA = "0x184CBEE80")]
	public static OJAIHBKPJPA<TIndex> DIEFFEOBOIO(int LNFLDNENGDM, [In] TValues FEBLBJIINOM)
	{
		return default(OJAIHBKPJPA<TIndex>);
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
