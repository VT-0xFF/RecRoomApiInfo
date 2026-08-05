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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x2695DE0", Offset = "0x26951E0", VA = "0x182695DE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct BPLMMHANMGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> NILHKCFACFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int MPKJDDCJPBL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xC707B0", Offset = "0xC6FBB0", VA = "0x180C707B0")]
	public BPLMMHANMGE(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> OEOPIEBOEBM, int HGHGCNDALFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JLIGNDJDGFD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class PPHMLMEAMPI : FOMEKLECOJL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct HANOJNCKOKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly GHDELNLDBAO<byte> HAONEAHMEGA;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2633730", Offset = "0x2632B30", VA = "0x182633730")]
		public HANOJNCKOKF(GHDELNLDBAO<byte> DHHEGLJJIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2694580", Offset = "0x2693980", VA = "0x182694580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class LBADFMFJKBI : FOMEKLECOJL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct AKNNLNEEGLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> JPFMJOGGDFP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
		public AKNNLNEEGLC(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> AKLIGBGACAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum OMODGDONHAE
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
	public sealed class AFNNHJDEFHB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class FOMEKLECOJL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct JFFCCKBMJFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly OMODGDONHAE ONFCMJAOFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly IJOGBJOFPED<FOMEKLECOJL> GFMICMNHHGG;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC707B0", Offset = "0xC6FBB0", VA = "0x180C707B0")]
		public JFFCCKBMJFA(OMODGDONHAE EIJDODJDHLH, IJOGBJOFPED<FOMEKLECOJL> OFPHKBLIIDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class DBNIKHNEMAL : FOMEKLECOJL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct DLDFBNLOKEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> EIOAIONHMJC;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
		public DLDFBNLOKEN(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class OHIMMIKKKMC : FOMEKLECOJL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct FLMFEBHFNNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly AKBOPDOBDEE NAGDBOBKALD;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
		public FLMFEBHFNNP(AKBOPDOBDEE IBDFALHFKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x268ECF0", Offset = "0x268E0F0", VA = "0x18268ECF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal MMJCDOPJBPK<AFNNHJDEFHB, JFFCCKBMJFA> EANPIOBPFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal MMJCDOPJBPK<PPHMLMEAMPI, HANOJNCKOKF> EIAHHNCGKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal MMJCDOPJBPK<LBADFMFJKBI, AKNNLNEEGLC> CJNHGJIFHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal MMJCDOPJBPK<DBNIKHNEMAL, DLDFBNLOKEN> MDBLOEPOEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal MMJCDOPJBPK<OHIMMIKKKMC, FLMFEBHFNNP> IJOKLMKKKEF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x26954F0", Offset = "0x26948F0", VA = "0x1826954F0")]
	private JLIGNDJDGFD([In] MMJCDOPJBPK<AFNNHJDEFHB, JFFCCKBMJFA> OJKCOPIGGNJ, [In] MMJCDOPJBPK<PPHMLMEAMPI, HANOJNCKOKF> MLOFOAEFFOB, [In] MMJCDOPJBPK<LBADFMFJKBI, AKNNLNEEGLC> DEJBMMLBIJA, [In] MMJCDOPJBPK<DBNIKHNEMAL, DLDFBNLOKEN> IGOPLLLPIIE, [In] MMJCDOPJBPK<OHIMMIKKKMC, FLMFEBHFNNP> EIDHLBHDMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x26953B0", Offset = "0x26947B0", VA = "0x1826953B0")]
	public static JLIGNDJDGFD HBLBJMFGHFK()
	{
		return default(JLIGNDJDGFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MOPLJPKGALC
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x26958C0", Offset = "0x2694CC0", VA = "0x1826958C0")]
	public static void OAHDOECNNKP(this JLIGNDJDGFD JOCJBPPJMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum IPDBFBEAMDP
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
public struct FCAEPDDPFBC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class POHLBGHFPEE : NOOINAHCFJH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct CPPNONEIMGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> NOJAOHFEFAO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
		public CPPNONEIMGC(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> CJLKOLCLMEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum HIINLLBJOAN
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
	public sealed class IFENLCHPHFK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class NOOINAHCFJH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct HHCPGNIGLOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly HIINLLBJOAN ONFCMJAOFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly IJOGBJOFPED<NOOINAHCFJH> GFMICMNHHGG;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xC707B0", Offset = "0xC6FBB0", VA = "0x180C707B0")]
		public HHCPGNIGLOD(HIINLLBJOAN EIJDODJDHLH, IJOGBJOFPED<NOOINAHCFJH> OFPHKBLIIDI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal MMJCDOPJBPK<IFENLCHPHFK, HHCPGNIGLOD> EANPIOBPFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal MMJCDOPJBPK<POHLBGHFPEE, CPPNONEIMGC> HPHOFMNOBAH;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x268EB20", Offset = "0x268DF20", VA = "0x18268EB20")]
	private FCAEPDDPFBC([In] MMJCDOPJBPK<IFENLCHPHFK, HHCPGNIGLOD> OJKCOPIGGNJ, [In] MMJCDOPJBPK<POHLBGHFPEE, CPPNONEIMGC> HNBIMJLBICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x268EA90", Offset = "0x268DE90", VA = "0x18268EA90")]
	public static FCAEPDDPFBC HBLBJMFGHFK()
	{
		return default(FCAEPDDPFBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MDLNFJFJFNK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2695860", Offset = "0x2694C60", VA = "0x182695860")]
	public static void OAHDOECNNKP(this FCAEPDDPFBC JOCJBPPJMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HDEBCKOAHJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public AJFCGHOLDCP<int> HKAFMBBNBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public AJFCGHOLDCP<int> LLLEPGECPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int ONGIBPIHEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int CFBEFJAEMDN;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2694690", Offset = "0x2693A90", VA = "0x182694690")]
	private HDEBCKOAHJN([In] AJFCGHOLDCP<int> IHMKENAIEDD, [In] AJFCGHOLDCP<int> MECHNNGKIGE, int CFEDFNKPJBG, int ALCBIEBNHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x26945F0", Offset = "0x26939F0", VA = "0x1826945F0")]
	public static HDEBCKOAHJN HBLBJMFGHFK()
	{
		return default(HDEBCKOAHJN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class AODNDCDPGAL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x268A920", Offset = "0x2689D20", VA = "0x18268A920")]
	public static void OAHDOECNNKP(this HDEBCKOAHJN JOCJBPPJMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct CILPNDCBHOO
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum KKPEOFPBMPB
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class GOBOBPOPFAB : IKDNMCOFGEN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct JKCDMHLMHPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly IJOGBJOFPED<BCKDPEPOOOG> FIGCAFFACOO;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
		public JKCDMHLMHPB(IJOGBJOFPED<BCKDPEPOOOG> ODGINCJIADF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class JHHFOECNGCC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class IKDNMCOFGEN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct KOJAGAKKHHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly KKPEOFPBMPB ONFCMJAOFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly IJOGBJOFPED<IKDNMCOFGEN> GFMICMNHHGG;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xC707B0", Offset = "0xC6FBB0", VA = "0x180C707B0")]
		private KOJAGAKKHHO(KKPEOFPBMPB EIJDODJDHLH, IJOGBJOFPED<IKDNMCOFGEN> OFPHKBLIIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2695630", Offset = "0x2694A30", VA = "0x182695630")]
		public static KOJAGAKKHHO HBLBJMFGHFK(KKPEOFPBMPB EIJDODJDHLH, IJOGBJOFPED<IKDNMCOFGEN> OFPHKBLIIDI)
		{
			return default(KOJAGAKKHHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class JDECNIGJCJM : IKDNMCOFGEN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct AKDAKPMEBFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly IJOGBJOFPED<BCKDPEPOOOG> FIGCAFFACOO;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
		public AKDAKPMEBFI(IJOGBJOFPED<BCKDPEPOOOG> ODGINCJIADF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class BCKDPEPOOOG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct OCCLCJDDNPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AJFCGHOLDCP<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> MMFNFAEHKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AJFCGHOLDCP<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> EPFJBGBLNIH;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x268EB20", Offset = "0x268DF20", VA = "0x18268EB20")]
		private OCCLCJDDNPE([In] AJFCGHOLDCP<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> PBMICCGPFNN, [In] AJFCGHOLDCP<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> ADPAAGKNICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2695E60", Offset = "0x2695260", VA = "0x182695E60")]
		public static OCCLCJDDNPE HBLBJMFGHFK()
		{
			return default(OCCLCJDDNPE);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal MMJCDOPJBPK<JHHFOECNGCC, KOJAGAKKHHO> EANPIOBPFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal MMJCDOPJBPK<JDECNIGJCJM, AKDAKPMEBFI> FJBGPCKGFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal MMJCDOPJBPK<GOBOBPOPFAB, JKCDMHLMHPB> ANLEIBFAPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal AJFCGHOLDCP<(IJOGBJOFPED<JHHFOECNGCC> CallId, IJOGBJOFPED<BCKDPEPOOOG> IOId)> LENGGKMMJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal MMJCDOPJBPK<BCKDPEPOOOG, OCCLCJDDNPE> EKNLJIOIIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal LPLBBMCLGNH<BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> LJGIKANKNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal LPLBBMCLGNH<BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> GKNPHGKOFBA;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x268AE80", Offset = "0x268A280", VA = "0x18268AE80")]
	private CILPNDCBHOO([In] MMJCDOPJBPK<JHHFOECNGCC, KOJAGAKKHHO> OJKCOPIGGNJ, [In] MMJCDOPJBPK<JDECNIGJCJM, AKDAKPMEBFI> CMPCHENMBAA, [In] MMJCDOPJBPK<GOBOBPOPFAB, JKCDMHLMHPB> LGCKHJKNGLH, [In] AJFCGHOLDCP<(IJOGBJOFPED<JHHFOECNGCC> CallId, IJOGBJOFPED<BCKDPEPOOOG> IOId)> DLLEMFGMALO, [In] MMJCDOPJBPK<BCKDPEPOOOG, OCCLCJDDNPE> LEPHMABGCFG, [In] LPLBBMCLGNH<BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> OKHINBNMAIG, [In] LPLBBMCLGNH<BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> FFHHBDMABFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x268ACE0", Offset = "0x268A0E0", VA = "0x18268ACE0")]
	public static CILPNDCBHOO HBLBJMFGHFK()
	{
		return default(CILPNDCBHOO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class GNKOKJKBBAK
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2694320", Offset = "0x2693720", VA = "0x182694320")]
	private static void OAHDOECNNKP(this CILPNDCBHOO.OCCLCJDDNPE JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2694370", Offset = "0x2693770", VA = "0x182694370")]
	public static void OAHDOECNNKP(this CILPNDCBHOO JOCJBPPJMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct EDDACBEFLJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public AJFCGHOLDCP<byte> EOMIEBCMJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal CILPNDCBHOO CEKAOHPJCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal ADPHNPFBBOB EKCBJICBOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> EAIGONBEMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal JLIGNDJDGFD FOGIDMMNMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal FCAEPDDPFBC DNKINFHLDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal LPLBBMCLGNH<DIEOFHIAEHN, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>?> DGNALODPDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>> FNPNCLKGGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> PPCGIMHJJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> BAJAGIAACFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> MONJIAHOHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal NJAMGGIAIGO LELNCALKEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal BAHKKEKGKBO DDELECEEJGB;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x268E460", Offset = "0x268D860", VA = "0x18268E460")]
	private EDDACBEFLJG([In] AJFCGHOLDCP<byte> IIMJDNDCHAP, [In] CILPNDCBHOO ALDIPGAMFGC, [In] ADPHNPFBBOB LBLBHCBDBOI, [In] JLIGNDJDGFD IGBCLDOOJEE, [In] FCAEPDDPFBC BAMEHFMKOCH, [In] LPLBBMCLGNH<DIEOFHIAEHN, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>?> AMCDCGABGPO, [In] AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>> LIPAINJNFKP, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> CCKOGHCOENC, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> OIFFOAMPHJC, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> PPMLFHJNGCE, [In] NJAMGGIAIGO MEMGJPDIPDI, [In] BAHKKEKGKBO FIKNDAEDMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x268DAB0", Offset = "0x268CEB0", VA = "0x18268DAB0")]
	public static EDDACBEFLJG HBLBJMFGHFK()
	{
		return default(EDDACBEFLJG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EBMHAPKLEJD
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct HINGBIKHPDM : GLGDEFBGMMC<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>, LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x26946F0", Offset = "0x2693AF0", VA = "0x1826946F0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x26947B0", Offset = "0x2693BB0", VA = "0x1826947B0", Slot = "4")]
		public IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0")]
		public bool DOHBBEDOPEE(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "5")]
		private bool DPAPPEFGJAG(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x26947A0", Offset = "0x2693BA0", VA = "0x1826947A0", Slot = "6")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FIAAKEAANDI(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct CKOKPBFOCAK : DJJGBHEOEJK<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>, LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x268AFF0", Offset = "0x268A3F0", VA = "0x18268AFF0")]
		public AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>> DCPABAHBGKL(int FPEMFJILKDE, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x268AF40", Offset = "0x268A340", VA = "0x18268AF40")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x268B060", Offset = "0x268A460", VA = "0x18268B060", Slot = "6")]
		public void LNOLCFOFNAO(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x268AFF0", Offset = "0x268A3F0", VA = "0x18268AFF0", Slot = "4")]
		private AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>> FJLCLIEDLMI(int FPEMFJILKDE, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x268B120", Offset = "0x268A520", VA = "0x18268B120", Slot = "5")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> OOKEGGONAHO(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct OFMMAMFJFBI : GLGDEFBGMMC<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>, LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2695EE0", Offset = "0x26952E0", VA = "0x182695EE0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2695F90", Offset = "0x2695390", VA = "0x182695F90", Slot = "4")]
		public IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0")]
		public bool DOHBBEDOPEE(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "5")]
		private bool KKDHCKBAMPC(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2695FC0", Offset = "0x26953C0", VA = "0x182695FC0", Slot = "6")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> LIMEKEMJGCH(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct LLCHOPIBGMP : DJJGBHEOEJK<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>, LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2695700", Offset = "0x2694B00", VA = "0x182695700")]
		public AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>> DCPABAHBGKL(int FPEMFJILKDE, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2695650", Offset = "0x2694A50", VA = "0x182695650")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2695780", Offset = "0x2694B80", VA = "0x182695780", Slot = "6")]
		public void LNOLCFOFNAO(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2695700", Offset = "0x2694B00", VA = "0x182695700", Slot = "4")]
		private AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>> EGJCCKEGFIH(int FPEMFJILKDE, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2695770", Offset = "0x2694B70", VA = "0x182695770", Slot = "5")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> HFBPKCOGKEK(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct FDGJNKGGPFO : GLGDEFBGMMC<IJOGBJOFPED<KHMKGBDANIH>, LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x268EBE0", Offset = "0x268DFE0", VA = "0x18268EBE0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x268ECC0", Offset = "0x268E0C0", VA = "0x18268ECC0", Slot = "4")]
		public IJOGBJOFPED<KHMKGBDANIH> JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(IJOGBJOFPED<KHMKGBDANIH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x268EB60", Offset = "0x268DF60", VA = "0x18268EB60")]
		public bool DOHBBEDOPEE(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x268EB60", Offset = "0x268DF60", VA = "0x18268EB60", Slot = "5")]
		private bool CMPKDFKGLFM(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x268ECB0", Offset = "0x268E0B0", VA = "0x18268ECB0", Slot = "6")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> IIEFOBNBMMI(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct GBFBIBCANBK : DJJGBHEOEJK<IJOGBJOFPED<KHMKGBDANIH>, LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2694090", Offset = "0x2693490", VA = "0x182694090")]
		public AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>> DCPABAHBGKL(int FPEMFJILKDE, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2693FC0", Offset = "0x26933C0", VA = "0x182693FC0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2694110", Offset = "0x2693510", VA = "0x182694110", Slot = "6")]
		public void LNOLCFOFNAO(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2694090", Offset = "0x2693490", VA = "0x182694090", Slot = "4")]
		private AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>> LINECBIBCLA(int FPEMFJILKDE, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2694100", Offset = "0x2693500", VA = "0x182694100", Slot = "5")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> JDOKIJAJJPI(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct IHBHONOMAFC : GLGDEFBGMMC<int, AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x26947E0", Offset = "0x2693BE0", VA = "0x1826947E0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD053E0", Offset = "0xD047E0", VA = "0x180D053E0", Slot = "4")]
		public int JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0")]
		public bool DOHBBEDOPEE(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "5")]
		private bool LCKBKBPANPI(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2694880", Offset = "0x2693C80", VA = "0x182694880", Slot = "6")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> OOHFIAENJGJ(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct EMMDKEBGLFO : DJJGBHEOEJK<int, AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x268E910", Offset = "0x268DD10", VA = "0x18268E910")]
		public AJFCGHOLDCP<int> DCPABAHBGKL(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x268E870", Offset = "0x268DC70", VA = "0x18268E870")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x268E990", Offset = "0x268DD90", VA = "0x18268E990", Slot = "6")]
		public void LNOLCFOFNAO(int CJFNAFNJJLB, AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x268E910", Offset = "0x268DD10", VA = "0x18268E910", Slot = "4")]
		private AJFCGHOLDCP<int> IHCMGLCDNEF(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x268E980", Offset = "0x268DD80", VA = "0x18268E980", Slot = "5")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> DHLHDDCNOKN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct GDILOGCGKBE : GLGDEFBGMMC<int, AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2694270", Offset = "0x2693670", VA = "0x182694270")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD053E0", Offset = "0xD047E0", VA = "0x180D053E0", Slot = "4")]
		public int JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0")]
		public bool DOHBBEDOPEE(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "5")]
		private bool POGIKPMAOOD(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2694310", Offset = "0x2693710", VA = "0x182694310", Slot = "6")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> GEIKEOBMIBF(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct DEEBJIKIOBO : DJJGBHEOEJK<int, AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x268B280", Offset = "0x268A680", VA = "0x18268B280")]
		public AJFCGHOLDCP<int> DCPABAHBGKL(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x268B1E0", Offset = "0x268A5E0", VA = "0x18268B1E0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x268B300", Offset = "0x268A700", VA = "0x18268B300", Slot = "6")]
		public void LNOLCFOFNAO(int CJFNAFNJJLB, AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x268B280", Offset = "0x268A680", VA = "0x18268B280", Slot = "4")]
		private AJFCGHOLDCP<int> JGDBLDJILOJ(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x268B2F0", Offset = "0x268A6F0", VA = "0x18268B2F0", Slot = "5")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> JLKFPAIPGNA(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct KCMANHHAJLB : GLGDEFBGMMC<int, AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2695580", Offset = "0x2694980", VA = "0x182695580")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xD053E0", Offset = "0xD047E0", VA = "0x180D053E0", Slot = "4")]
		public int JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0")]
		public bool DOHBBEDOPEE(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9C55F0", Offset = "0x9C49F0", VA = "0x1809C55F0", Slot = "5")]
		private bool POGIKPMAOOD(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2695620", Offset = "0x2694A20", VA = "0x182695620", Slot = "6")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> GEIKEOBMIBF(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct CFAJDGAAFAP : DJJGBHEOEJK<int, AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x268AB60", Offset = "0x2689F60", VA = "0x18268AB60")]
		public AJFCGHOLDCP<int> DCPABAHBGKL(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x268AAC0", Offset = "0x2689EC0", VA = "0x18268AAC0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x268ABE0", Offset = "0x2689FE0", VA = "0x18268ABE0", Slot = "6")]
		public void LNOLCFOFNAO(int CJFNAFNJJLB, AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x268AB60", Offset = "0x2689F60", VA = "0x18268AB60", Slot = "4")]
		private AJFCGHOLDCP<int> JGDBLDJILOJ(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x268ABD0", Offset = "0x2689FD0", VA = "0x18268ABD0", Slot = "5")]
		private IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> JLKFPAIPGNA(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct JDJGONKJECJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> JMOFBBIHAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool EFCPMPGAHLA;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1D42C00", Offset = "0x1D42000", VA = "0x181D42C00")]
		public JDJGONKJECJ(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF, bool BGFDPHNDDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2694890", Offset = "0x2693C90", VA = "0x182694890")]
		public void LKJBGMAPBIG([Out] IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF, [Out] bool BGFDPHNDDKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct DLLNNGJEJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly IJOGBJOFPED<KHMKGBDANIH> HFEOEOAIAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> JMOFBBIHAOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool EFCPMPGAHLA;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x268B420", Offset = "0x268A820", VA = "0x18268B420")]
		public DLLNNGJEJLM(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF, bool BGFDPHNDDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x268B3F0", Offset = "0x268A7F0", VA = "0x18268B3F0")]
		public void LKJBGMAPBIG([Out] IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF, [Out] bool BGFDPHNDDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x268B400", Offset = "0x268A800", VA = "0x18268B400")]
		public void LKJBGMAPBIG([Out] IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF, [Out] IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK, [Out] bool BGFDPHNDDKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct LKPECIBOABK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly IJOGBJOFPED<KHMKGBDANIH> HFEOEOAIAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> JMOFBBIHAOB;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xC707B0", Offset = "0xC6FBB0", VA = "0x180C707B0")]
		public LKPECIBOABK(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2695640", Offset = "0x2694A40", VA = "0x182695640")]
		public void LKJBGMAPBIG([Out] IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF, [Out] IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x268D460", Offset = "0x268C860", VA = "0x18268D460")]
	public static void OAHDOECNNKP(this EDDACBEFLJG JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x268D3D0", Offset = "0x268C7D0", VA = "0x18268D3D0")]
	public static void NMEMKDDOOCA(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> JNIGANDJNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x268C8F0", Offset = "0x268BCF0", VA = "0x18268C8F0")]
	public static void IMAPNGFMMKE(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> JNIGANDJNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x268B5A0", Offset = "0x268A9A0", VA = "0x18268B5A0")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>? ANGHAAMIHDD([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x268BEF0", Offset = "0x268B2F0", VA = "0x18268BEF0")]
	public static IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> DOKALJNJPJE([In] this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x268BB90", Offset = "0x268AF90", VA = "0x18268BB90")]
	private static void CLIJONDIDAA(this EDDACBEFLJG JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x268C3C0", Offset = "0x268B7C0", VA = "0x18268C3C0")]
	private static IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? HHDFDIACCDF([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x268CAF0", Offset = "0x268BEF0", VA = "0x18268CAF0")]
	public static void JAFLPDKAICG(this EDDACBEFLJG JOCJBPPJMJJ, [In] AJFCGHOLDCP<BPLMMHANMGE> PJCDGNKPJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x268B430", Offset = "0x268A830", VA = "0x18268B430")]
	public static JLIGNDJDGFD.OMODGDONHAE AHALBNMBBHB([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(JLIGNDJDGFD.OMODGDONHAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x268D260", Offset = "0x268C660", VA = "0x18268D260")]
	public static GHDELNLDBAO<byte> MMCIFJEEEEJ([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(GHDELNLDBAO<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x268B4B0", Offset = "0x268A8B0", VA = "0x18268B4B0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> ALHHLDLENMH([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x268BD80", Offset = "0x268B180", VA = "0x18268BD80")]
	public static AKBOPDOBDEE DKDGOEKILNK([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x347A3F0", Offset = "0x34797F0", VA = "0x18347A3F0")]
	private static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> IBFGDMMHKLL<TMJoin>(this EDDACBEFLJG JOCJBPPJMJJ, JLIGNDJDGFD.OMODGDONHAE EIJDODJDHLH, IJOGBJOFPED<TMJoin> OFPHKBLIIDI) where TMJoin : JLIGNDJDGFD.FOMEKLECOJL
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x268D350", Offset = "0x268C750", VA = "0x18268D350")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> NEECBHCNHDM(this EDDACBEFLJG JOCJBPPJMJJ, bool OAAFEPPONMI)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x268CDD0", Offset = "0x268C1D0", VA = "0x18268CDD0")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> KCEAAMDNKHN(this EDDACBEFLJG JOCJBPPJMJJ, GHDELNLDBAO<byte> DHHEGLJJIIE)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x268C730", Offset = "0x268BB30", VA = "0x18268C730")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> IFKAFOBAHJL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> AKLIGBGACAM)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x268CD50", Offset = "0x268C150", VA = "0x18268CD50")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> JJGAACJBIOB(this EDDACBEFLJG JOCJBPPJMJJ, int DJLIDNFCFDD)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x268BD00", Offset = "0x268B100", VA = "0x18268BD00")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> DFOHNJAPFDK(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x347A340", Offset = "0x3479740", VA = "0x18347A340")]
	private static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> GFFIBBCHKGG<TMJoin>(this EDDACBEFLJG JOCJBPPJMJJ, FCAEPDDPFBC.HIINLLBJOAN EIJDODJDHLH, IJOGBJOFPED<TMJoin> OFPHKBLIIDI) where TMJoin : FCAEPDDPFBC.NOOINAHCFJH
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x268C0E0", Offset = "0x268B4E0", VA = "0x18268C0E0")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> GOHAJMKJEKC(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x268BFA0", Offset = "0x268B3A0", VA = "0x18268BFA0")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> FBDMDOOHCDE(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x268B920", Offset = "0x268AD20", VA = "0x18268B920")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> CCJLEEADAIP(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> CJLKOLCLMEC)
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x268C7B0", Offset = "0x268BBB0", VA = "0x18268C7B0")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> IIHAGCCKELN(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x268BF50", Offset = "0x268B350", VA = "0x18268BF50")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> DONGFFCDDAL(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x268C120", Offset = "0x268B520", VA = "0x18268C120")]
	public static CILPNDCBHOO.KKPEOFPBMPB GOIHANGFJDO([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> AHMNMKOHBOP)
	{
		return default(CILPNDCBHOO.KKPEOFPBMPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x268DA70", Offset = "0x268CE70", VA = "0x18268DA70")]
	public static DCFBMJCCGFF<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>, PCNDONFGOFI<CILPNDCBHOO.BCKDPEPOOOG>> PDAAAKNHJED([In] this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(DCFBMJCCGFF<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>, PCNDONFGOFI<CILPNDCBHOO.BCKDPEPOOOG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x268D7A0", Offset = "0x268CBA0", VA = "0x18268D7A0")]
	public static IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> OKCGJHPMHBP([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> AHMNMKOHBOP)
	{
		return default(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x268BE70", Offset = "0x268B270", VA = "0x18268BE70")]
	public static CILPNDCBHOO.OCCLCJDDNPE DLECHHAJNOK([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> ODGINCJIADF)
	{
		return default(CILPNDCBHOO.OCCLCJDDNPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x268D0F0", Offset = "0x268C4F0", VA = "0x18268D0F0")]
	public static CILPNDCBHOO.OCCLCJDDNPE LPLGFABCACL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> ODGINCJIADF)
	{
		return default(CILPNDCBHOO.OCCLCJDDNPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x347A2A0", Offset = "0x34796A0", VA = "0x18347A2A0")]
	private static IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> FGBEJFELMNP<TMJoin>(this EDDACBEFLJG JOCJBPPJMJJ, CILPNDCBHOO.KKPEOFPBMPB EIJDODJDHLH, IJOGBJOFPED<TMJoin> OFPHKBLIIDI) where TMJoin : CILPNDCBHOO.IKDNMCOFGEN
	{
		return default(IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x268CE60", Offset = "0x268C260", VA = "0x18268CE60")]
	public static (IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>) KGHFMCJIKFI(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default((IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x268C480", Offset = "0x268B880", VA = "0x18268C480")]
	public static (IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>) HIKELPDDALB(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default((IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x268D0A0", Offset = "0x268C4A0", VA = "0x18268D0A0")]
	public static IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> LCFNIEHLNLP(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x268D010", Offset = "0x268C410", VA = "0x18268D010")]
	public static void LBAPIPAGPPL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> ODGINCJIADF, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> IDGPNLEBBBI, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>> HOMLKMNGBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3479470", Offset = "0x3478870", VA = "0x183479470")]
	public static JDJGONKJECJ CLCBKNONAOL<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK) where TDeps : CMBMBJMPEFJ<TStateSys>
	{
		return default(JDJGONKJECJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x347A570", Offset = "0x3479970", VA = "0x18347A570")]
	public static DLLNNGJEJLM NHMBPBGHAEB<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, int FNJFCLABCPK) where TDeps : CMBMBJMPEFJ<TStateSys>
	{
		return default(DLLNNGJEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3478880", Offset = "0x3477C80", VA = "0x183478880")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>? APGFCKNONIO<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, [In] ReadOnlySpan<int> DGOGFAIDOHL, [In] Span<LKPECIBOABK> LDLOAPOMCNG) where TDeps : CMBMBJMPEFJ<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3478EB0", Offset = "0x34782B0", VA = "0x183478EB0")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> CACLDCNIDBJ<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN) where TDeps : CMBMBJMPEFJ<TStateSys>
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x268D170", Offset = "0x268C570", VA = "0x18268D170")]
	public static ADPHNPFBBOB.MBPONCINENC MIFBGPIPLDA([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return default(ADPHNPFBBOB.MBPONCINENC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x268C800", Offset = "0x268BC00", VA = "0x18268C800")]
	public static ADPHNPFBBOB.INEEPBGOCLG IIKOLAGNCAJ([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return default(ADPHNPFBBOB.INEEPBGOCLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x268CC60", Offset = "0x268C060", VA = "0x18268CC60")]
	public static ADPHNPFBBOB.ELDOLLHGIJK JELEACINJDL([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return default(ADPHNPFBBOB.ELDOLLHGIJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x268B790", Offset = "0x268AB90", VA = "0x18268B790")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BJAKDFAFNDA(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL, string IGEPDAOOLBO)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x268BFF0", Offset = "0x268B3F0", VA = "0x18268BFF0")]
	public static ADPHNPFBBOB.IJKNMBAIJOB GLAMENFJLPI([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return default(ADPHNPFBBOB.IJKNMBAIJOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x268C6C0", Offset = "0x268BAC0", VA = "0x18268C6C0")]
	public static ADPHNPFBBOB.FINEOBEFHDP IDINCOLJJJF([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return default(ADPHNPFBBOB.FINEOBEFHDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x268D730", Offset = "0x268CB30", VA = "0x18268D730")]
	public static int? OGDBCGKHCAO([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3478780", Offset = "0x3477B80", VA = "0x183478780")]
	private static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> AFDCCIHIMNL<TMJoin>(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL, ADPHNPFBBOB.FINEOBEFHDP EIJDODJDHLH, IJOGBJOFPED<TMJoin> OFPHKBLIIDI) where TMJoin : ADPHNPFBBOB.GOMNELOMNHI
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x268BAE0", Offset = "0x268AEE0", VA = "0x18268BAE0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CJELJBODFBB(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> AHMNMKOHBOP, int CJFNAFNJJLB)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x268B730", Offset = "0x268AB30", VA = "0x18268B730")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BEEGKBNLBAG(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x268C1A0", Offset = "0x268B5A0", VA = "0x18268C1A0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> HEGCBDFGCHC(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? AEIDFEKHNMP, int? DFEEGAKIKLL)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x268C630", Offset = "0x268BA30", VA = "0x18268C630")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> HJBMKFGHDEN(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL, int CJFNAFNJJLB)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x268DA10", Offset = "0x268CE10", VA = "0x18268DA10")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PBMOBJDAPBA(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x268B9A0", Offset = "0x268ADA0", VA = "0x18268B9A0")]
	public static void CCNJPKPONMM(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> AHMNMKOHBOP, int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x268C9C0", Offset = "0x268BDC0", VA = "0x18268C9C0")]
	public static void IMIPMNKMKBK(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI, int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x268B660", Offset = "0x268AA60", VA = "0x18268B660")]
	public static void AOLPFABLHCN(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x268D980", Offset = "0x268CD80", VA = "0x18268D980")]
	public static void OPHIEHBMGNI(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> IGICHEAKAKH, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> KDPKPPHCBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x268C2F0", Offset = "0x268B6F0", VA = "0x18268C2F0")]
	public static void HHCFFKDCBAA(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI, IJOGBJOFPED<JAHELGAGFCI<NGJBIHDGFDI>> DIIFAOEIECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x347A4A0", Offset = "0x34798A0", VA = "0x18347A4A0")]
	public static void MPIDICJNENL<M>(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<M>>> DIIFAOEIECI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CMBMBJMPEFJ<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IJOGBJOFPED<FNOIGLEFPAM> KCFHJGNOMGG(TStateSys BFFPFEMKACL);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IJOGBJOFPED<FNOIGLEFPAM> MMPFJBJHNLK(TStateSys BFFPFEMKACL);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IJOGBJOFPED<FNOIGLEFPAM> BGIKCDEMJNF(TStateSys BFFPFEMKACL);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IJOGBJOFPED<FNOIGLEFPAM> NHGJJPLDHBD(TStateSys BFFPFEMKACL);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> HDIDKOLHHCH(TStateSys BFFPFEMKACL, EDDACBEFLJG CIBBJHMCOIJ, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> MEDAMJHHMBA(TStateSys BFFPFEMKACL, EDDACBEFLJG CIBBJHMCOIJ, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int AENINCPBBKG(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IJOGBJOFPED<DIEOFHIAEHN> BHCICPOMBNN(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK, int MCIKILGHAHK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IPDBFBEAMDP IABLPHEEKCM(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FCMHNAABNKL(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int JEGNKAHKDGG(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	GHDELNLDBAO<byte> MIEBBDPKBNP(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(GHDELNLDBAO<byte>, IJOGBJOFPED<FNOIGLEFPAM>) EPAPLNDOBPL(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int FKKECHIGKDI(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IJOGBJOFPED<KHMKGBDANIH> MBOFEFAFNFB(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN, int FNJFCLABCPK);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IJOGBJOFPED<KHMKGBDANIH> BFANDEFPLCD(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, int FNJFCLABCPK);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int NKJKFBPOJEO(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? PJPODDICDHO(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, int CJFNAFNJJLB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int IGBIIAEDDKN(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? AJLMGKMMIFM(TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, int CJFNAFNJJLB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class GAKHFDHIALM
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x35ED750", Offset = "0x35ECB50", VA = "0x1835ED750")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK?> KLJGJDAMFMH<T, TOpInput, TOpOutput>(this EDDACBEFLJG JOCJBPPJMJJ, T BICHNBDCKLH, T CKCKMBIGMMF, int ELCPMIPCPDL, IntPtr DKFMMLIFNLP)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x35EEE10", Offset = "0x35EE210", VA = "0x1835EEE10")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK?> OPANOFNHKGE<T, TOpInput, TOpOutput>(this EDDACBEFLJG JOCJBPPJMJJ, T BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF, int ELCPMIPCPDL, IntPtr DKFMMLIFNLP)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x35EE6E0", Offset = "0x35EDAE0", VA = "0x1835EE6E0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK?> MBNLMNJNCBA<TOpInput, TOpOutput>(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF, int ELCPMIPCPDL, IntPtr DKFMMLIFNLP)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x268F8E0", Offset = "0x268ECE0", VA = "0x18268F8E0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DAMNAACPOMB(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2691340", Offset = "0x2690740", VA = "0x182691340")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> HHEAMEACOIL(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x268F660", Offset = "0x268EA60", VA = "0x18268F660")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CJDMJALBHAN(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x268F1F0", Offset = "0x268E5F0", VA = "0x18268F1F0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BMBCDNIIJNC(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2693900", Offset = "0x2692D00", VA = "0x182693900")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OOCMMMFLOGP(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2691760", Offset = "0x2690B60", VA = "0x182691760")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> IBOJHJLHODP(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2692470", Offset = "0x2691870", VA = "0x182692470")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> LBNCDPNBMDB(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2693C60", Offset = "0x2693060", VA = "0x182693C60")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PHOEJBOPBNE(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2692C00", Offset = "0x2692000", VA = "0x182692C00")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NGJAGLIBCOC(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2691D90", Offset = "0x2691190", VA = "0x182691D90")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> JLEMNGPNFCB(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, int CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x268EE30", Offset = "0x268E230", VA = "0x18268EE30")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> AMAMPDPCCKK(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x268F9E0", Offset = "0x268EDE0", VA = "0x18268F9E0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DCDIPCLEOPJ(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2692010", Offset = "0x2691410", VA = "0x182692010")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KFLHFOJCNBE(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, float CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x26927A0", Offset = "0x2691BA0", VA = "0x1826927A0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> MIHNBGLOCDO(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2693D80", Offset = "0x2693180", VA = "0x182693D80")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PILINANMNFC(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2692DD0", Offset = "0x26921D0", VA = "0x182692DD0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NMDNAMAEGPJ(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, int CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x268F2F0", Offset = "0x268E6F0", VA = "0x18268F2F0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BMKEJHMDHAL(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x26931C0", Offset = "0x26925C0", VA = "0x1826931C0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OGIILFMNLFP(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2693140", Offset = "0x2692540", VA = "0x182693140")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OGIIFIPFNDF(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, float CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2693BE0", Offset = "0x2692FE0", VA = "0x182693BE0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PEOMNIDFMEC(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x26918A0", Offset = "0x2690CA0", VA = "0x1826918A0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> IEGIMHFAMHL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2690C70", Offset = "0x2690070", VA = "0x182690C70")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> GGFMAOCNPGE(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, int CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2691F90", Offset = "0x2691390", VA = "0x182691F90")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KEEALCFEBPI(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x268FC40", Offset = "0x268F040", VA = "0x18268FC40")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DOEDGMDJEGF(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x26905A0", Offset = "0x268F9A0", VA = "0x1826905A0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FKGNJNOMOEP(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, float CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2690340", Offset = "0x268F740", VA = "0x182690340")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> ELKJMOBNDKA(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2691C10", Offset = "0x2691010", VA = "0x182691C10")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> JEKCIAKAJFC(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2691920", Offset = "0x2690D20", VA = "0x182691920")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> JBCIGMKHLNB(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x268F370", Offset = "0x268E770", VA = "0x18268F370")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> CELJLDADEBA(this EDDACBEFLJG JOCJBPPJMJJ, int FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2690040", Offset = "0x268F440", VA = "0x182690040")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ECAPPNGKHHA(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2690F30", Offset = "0x2690330", VA = "0x182690F30")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> HAJCNFCMCCG(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x26912C0", Offset = "0x26906C0", VA = "0x1826912C0")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> HGKFGNEDGCO(this EDDACBEFLJG JOCJBPPJMJJ, int FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x26910E0", Offset = "0x26904E0", VA = "0x1826910E0")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> HDNJCICJGAH(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2690620", Offset = "0x268FA20", VA = "0x182690620")]
	public static (IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>) FKHICOOPDPN(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<GFMPOBJPFLN> BMMHOGHMCMD, [In] ReadOnlySpan<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> PBMICCGPFNN, [In] ReadOnlySpan<int?> PGFOLGJDCCH, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> LMCBKNEPHCC)
	{
		return default((IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x26934C0", Offset = "0x26928C0", VA = "0x1826934C0")]
	public static (IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>) OMMGLKFNBPL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<DCGBFPGIBOL> ABAEHEHCKOH, [In] ReadOnlySpan<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> PBMICCGPFNN, [In] ReadOnlySpan<int?> PGFOLGJDCCH, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> LMCBKNEPHCC)
	{
		return default((IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x35ED0B0", Offset = "0x35EC4B0", VA = "0x1835ED0B0")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>) GONHHDDEJDE<TMarker>(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<FNOIGLEFPAM> DPOANBKHFEA, [In] ReadOnlySpan<byte> HPMNBNLACCC)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x26904E0", Offset = "0x268F8E0", VA = "0x1826904E0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FKFLNCICGLC(this EDDACBEFLJG JOCJBPPJMJJ, int FJONCPGPEAA, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2692B10", Offset = "0x2691F10", VA = "0x182692B10")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NBPIGBPECID(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FJONCPGPEAA, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2692F50", Offset = "0x2692350", VA = "0x182692F50")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NOMHEBBIEKA(this EDDACBEFLJG JOCJBPPJMJJ, [In] ReadOnlySpan<byte> FJONCPGPEAA, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2691180", Offset = "0x2690580", VA = "0x182691180")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> HDOGJCJALJC(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FJONCPGPEAA, int MNDMOIHIBEI, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x268F0F0", Offset = "0x268E4F0", VA = "0x18268F0F0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDFEOPEADBK(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x26903C0", Offset = "0x268F7C0", VA = "0x1826903C0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FDLHNNIHBAA(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2692230", Offset = "0x2691630", VA = "0x182692230")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KMAOIEBEECH(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2690B70", Offset = "0x268FF70", VA = "0x182690B70")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FMKHIOIKNFL(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x268EF50", Offset = "0x268E350", VA = "0x18268EF50")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> AOIOKJOBMFM(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x26928D0", Offset = "0x2691CD0", VA = "0x1826928D0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> MIIDIMJCILL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2692D40", Offset = "0x2692140", VA = "0x182692D40")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NIFADNPFPEJ(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, int CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x268F070", Offset = "0x268E470", VA = "0x18268F070")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> APOCGKJELEN(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2693A20", Offset = "0x2692E20", VA = "0x182693A20")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PBFMOKJFHEA(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2691C90", Offset = "0x2691090", VA = "0x182691C90")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> JKLAKODMOAC(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x268F3F0", Offset = "0x268E7F0", VA = "0x18268F3F0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CHBEJOLGKCA(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x268F7A0", Offset = "0x268EBA0", VA = "0x18268F7A0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CLCKBBDGDIF(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2692A10", Offset = "0x2691E10", VA = "0x182692A10")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> MPLIELCDNDF(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2690E10", Offset = "0x2690210", VA = "0x182690E10")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> GLLGGKFNCCA(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x26900E0", Offset = "0x268F4E0", VA = "0x1826900E0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> EELAAEFLNMK(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x26912A0", Offset = "0x26906A0", VA = "0x1826912A0")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> HFOOOBIKGDI(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x26926A0", Offset = "0x2691AA0", VA = "0x1826926A0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> LPKJLCGPLMP(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2692110", Offset = "0x2691510", VA = "0x182692110")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KLGHOPHCBCF(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2693240", Offset = "0x2692640", VA = "0x182693240")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OHFACKLMLEN(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2692370", Offset = "0x2691770", VA = "0x182692370")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KOEEFDPKMNH(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x268FB20", Offset = "0x268EF20", VA = "0x18268FB20")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DKMCINFOKKG(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2691AD0", Offset = "0x2690ED0", VA = "0x182691AD0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> JCIAGDIDPMF(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2693EC0", Offset = "0x26932C0", VA = "0x182693EC0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PKOPGHAEJLI(this EDDACBEFLJG JOCJBPPJMJJ, int FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2690A60", Offset = "0x268FE60", VA = "0x182690A60")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FLLLFGDPNFF(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2692DC0", Offset = "0x26921C0", VA = "0x182692DC0")]
	public static void NJDOCPNPPIO(this EDDACBEFLJG JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2691E90", Offset = "0x2691290", VA = "0x182691E90")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KBAALKCLKGP(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x268ED10", Offset = "0x268E110", VA = "0x18268ED10")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> ACEKPMDNCCE(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2693380", Offset = "0x2692780", VA = "0x182693380")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OMKGMDDIEPK(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2693040", Offset = "0x2692440", VA = "0x182693040")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OGAIGFDCDBM(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2690220", Offset = "0x268F620", VA = "0x182690220")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> EJJBPAACIAJ(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2693AA0", Offset = "0x2692EA0", VA = "0x182693AA0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PBLNKCALNMF(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x268FCC0", Offset = "0x268F0C0", VA = "0x18268FCC0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> EBODLGLIFKI(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> MGBEIFFJIMF, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> BLAIJCBBAKK)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2692E50", Offset = "0x2692250", VA = "0x182692E50")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NOALDOFHLGO(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2690CF0", Offset = "0x26900F0", VA = "0x182690CF0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> GJCHODJKFJO(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x268F520", Offset = "0x268E920", VA = "0x18268F520")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CIPDEIHPELB(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x35ED1B0", Offset = "0x35EC5B0", VA = "0x1835ED1B0")]
	public static void KCNGHJHKMKI<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<GFMPOBJPFLN> BMMHOGHMCMD, [In] ReadOnlySpan<IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>> GANOKHBODHE, [In] ReadOnlySpan<int?> PGFOLGJDCCH, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> LMCBKNEPHCC, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> BKNKGBPICFA, [In] ReadOnlySpan<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>?> PJGEDMLFNJK) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x35EE140", Offset = "0x35ED540", VA = "0x1835EE140")]
	public static void LJNLDDLEBCO<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<DCGBFPGIBOL> MOIIPMBKBLO, [In] ReadOnlySpan<IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>> MEFGIOJONAH, [In] ReadOnlySpan<int?> PGFOLGJDCCH, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> LMCBKNEPHCC, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> BKNKGBPICFA, [In] ReadOnlySpan<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>?> PJGEDMLFNJK) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x35EC250", Offset = "0x35EB650", VA = "0x1835EC250")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DBABOBIKBIO<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> AEIDFEKHNMP, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x35EDCE0", Offset = "0x35ED0E0", VA = "0x1835EDCE0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> LFPAICEDMND<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> CJLKOLCLMEC, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x35EC430", Offset = "0x35EB830", VA = "0x1835EC430")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> FKIKOAKOKDC<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL) where TDeps : notnull, CMBMBJMPEFJ<TStateSys> where TStateSys : notnull
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x35EEC00", Offset = "0x35EE000", VA = "0x1835EEC00")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> NELEHBBGHEF<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL) where TDeps : notnull, CMBMBJMPEFJ<TStateSys> where TStateSys : notnull
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2692570", Offset = "0x2691970", VA = "0x182692570")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> LOHHKJHLMEI(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> KFLJPENHCGO, IntPtr OCJCMAFICIM, IntPtr CHBMCIMNEFN)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2691460", Offset = "0x2690860", VA = "0x182691460")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> HKFEEDPCAOI(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> MHPBHKJGGDO, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> GOIBOPLIJAF, IntPtr KCFFJEOMCMJ, IntPtr JFLKIHGDLMP, IntPtr HGPAGNHHADF, bool DEIELNKMDNJ)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x35EC660", Offset = "0x35EBA60", VA = "0x1835EC660")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> FLKMAFJMNOI<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<GFMPOBJPFLN> HBJCDKADOKE, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> MHPBHKJGGDO, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> GOIBOPLIJAF, int? OLLGCHGGKLF, [Optional] IntPtr FOGPIMBEOKF) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x35EC870", Offset = "0x35EBC70", VA = "0x1835EC870")]
	private static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> FLKMAFJMNOI<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<GFMPOBJPFLN> HBJCDKADOKE, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> MHPBHKJGGDO, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> GOIBOPLIJAF, int? OLLGCHGGKLF) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x35EE850", Offset = "0x35EDC50", VA = "0x1835EE850")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> MNMNGHMFAIO<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FJONCPGPEAA, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x35EDA50", Offset = "0x35ECE50", VA = "0x1835EDA50")]
	public static void KPAICBHCOLG<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, int EBOKFAMBDMP) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct BKEHPPOADCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> LDADAJIEMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> PCCADFGNGKM;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xC707B0", Offset = "0xC6FBB0", VA = "0x180C707B0")]
	public BKEHPPOADCP(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> LBHANGFCPFF, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> MKNDHEOLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x268AAB0", Offset = "0x2689EB0", VA = "0x18268AAB0")]
	public static BKEHPPOADCP HBLBJMFGHFK(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> LBHANGFCPFF)
	{
		return default(BKEHPPOADCP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct ADPHNPFBBOB
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class DMMNNCOPFHI : GOMNELOMNHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct MBPONCINENC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> HNNEFEBNEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int FBMJOLKHIKJ;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xC707B0", Offset = "0xC6FBB0", VA = "0x180C707B0")]
		public MBPONCINENC(IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> AHMNMKOHBOP, int CJFNAFNJJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class GDLPIHKLGAI : GOMNELOMNHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct INEEPBGOCLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int FBMJOLKHIKJ;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
		public INEEPBGOCLG(int CJFNAFNJJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class LDBKLELIOGB : GOMNELOMNHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct ELDOLLHGIJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> HNNEFEBNEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int FBMJOLKHIKJ;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xC707B0", Offset = "0xC6FBB0", VA = "0x180C707B0")]
		public ELDOLLHGIJK(IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> AHMNMKOHBOP, int CJFNAFNJJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum FINEOBEFHDP
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
	public sealed class FDDNNFEDGPK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class GOMNELOMNHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct LNGLGEAHADL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? CFOCPCBNJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BKEHPPOADCP EMAIBJFFPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FINEOBEFHDP ONFCMJAOFKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public IJOGBJOFPED<GOMNELOMNHI> GFMICMNHHGG;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2695840", Offset = "0x2694C40", VA = "0x182695840")]
		public LNGLGEAHADL(int? DFEEGAKIKLL, [In] BKEHPPOADCP LOGHFLOCDBM, FINEOBEFHDP EIJDODJDHLH, IJOGBJOFPED<GOMNELOMNHI> OFPHKBLIIDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class KGLBOEIOADE : GOMNELOMNHI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct IJKNMBAIJOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int FBMJOLKHIKJ;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x11C3CB0", Offset = "0x11C30B0", VA = "0x1811C3CB0")]
		public IJKNMBAIJOB(int CJFNAFNJJLB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal LILLHCBLPLN<FDDNNFEDGPK, LNGLGEAHADL> EANPIOBPFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal LILLHCBLPLN<DMMNNCOPFHI, MBPONCINENC> GBMFKCEKGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal LILLHCBLPLN<LDBKLELIOGB, ELDOLLHGIJK> MJFHGANJCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal LILLHCBLPLN<KGLBOEIOADE, IJKNMBAIJOB> KKLJCMBOFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal LILLHCBLPLN<GDLPIHKLGAI, INEEPBGOCLG> GFHJJJPMLMH;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x268A7F0", Offset = "0x2689BF0", VA = "0x18268A7F0")]
	private ADPHNPFBBOB([In] LILLHCBLPLN<FDDNNFEDGPK, LNGLGEAHADL> OJKCOPIGGNJ, [In] LILLHCBLPLN<DMMNNCOPFHI, MBPONCINENC> POFFKGPLKCF, [In] LILLHCBLPLN<LDBKLELIOGB, ELDOLLHGIJK> OCBKMBIFEAG, [In] LILLHCBLPLN<KGLBOEIOADE, IJKNMBAIJOB> FLFMKGJFANF, [In] LILLHCBLPLN<GDLPIHKLGAI, INEEPBGOCLG> PPHMOPPBFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x268A600", Offset = "0x2689A00", VA = "0x18268A600")]
	public static ADPHNPFBBOB HBLBJMFGHFK()
	{
		return default(ADPHNPFBBOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class PNHAFFNCACB
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2695FD0", Offset = "0x26953D0", VA = "0x182695FD0")]
	public static void OAHDOECNNKP(this ADPHNPFBBOB JOCJBPPJMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class AABBEMNJPEC
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x268A420", Offset = "0x2689820", VA = "0x18268A420")]
	public static void AMNMBKBGPIL(EDDACBEFLJG JOCJBPPJMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct NJAMGGIAIGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, HDEBCKOAHJN> BGJPFOKPDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int PKHBKCJDMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int AFNPNBBNHMF;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2695DA0", Offset = "0x26951A0", VA = "0x182695DA0")]
	private NJAMGGIAIGO([In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, HDEBCKOAHJN> GCLEABKBNIC, int NMFGNKHMDLC, int LBMPMOPJKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2695B40", Offset = "0x2694F40", VA = "0x182695B40")]
	public static NJAMGGIAIGO HBLBJMFGHFK()
	{
		return default(NJAMGGIAIGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2695BB0", Offset = "0x2694FB0", VA = "0x182695BB0")]
	public void OAHDOECNNKP([In] EDDACBEFLJG PDBOIKJNMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x37D1470", Offset = "0x37D0870", VA = "0x1837D1470")]
	public static void AMNMBKBGPIL<TDeps, TStateSys>(EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH) where TDeps : notnull, CMBMBJMPEFJ<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NEAPDPAEADL
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2695970", Offset = "0x2694D70", VA = "0x182695970")]
	public static void AMNMBKBGPIL(EDDACBEFLJG JOCJBPPJMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct BAHKKEKGKBO
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface EMJLFLFLJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GLHCMKINICF(AJFCGHOLDCP<byte> IIMJDNDCHAP, int PHFIONPIAGC);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct GCEAPMADEFF : EMJLFLFLJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x26941F0", Offset = "0x26935F0", VA = "0x1826941F0", Slot = "4")]
		public void GLHCMKINICF(AJFCGHOLDCP<byte> IIMJDNDCHAP, int PHFIONPIAGC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct EKGINKMJFBL : EMJLFLFLJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x268E7C0", Offset = "0x268DBC0", VA = "0x18268E7C0", Slot = "4")]
		public void GLHCMKINICF(AJFCGHOLDCP<byte> IIMJDNDCHAP, int PHFIONPIAGC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct ADKJOLJJEOH : EMJLFLFLJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x268A580", Offset = "0x2689980", VA = "0x18268A580", Slot = "4")]
		public void GLHCMKINICF(AJFCGHOLDCP<byte> IIMJDNDCHAP, int PHFIONPIAGC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct CLFMEDJMGIC : EMJLFLFLJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x268B130", Offset = "0x268A530", VA = "0x18268B130", Slot = "4")]
		public void GLHCMKINICF(AJFCGHOLDCP<byte> IIMJDNDCHAP, int PHFIONPIAGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class ONNFAEKIPJK<TCallProcessorDeps> where TCallProcessorDeps : struct, EMJLFLFLJAM
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps AMCNMNPOCHO;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3CDA580", Offset = "0x3CD9980", VA = "0x183CDA580")]
		public static int AMNMBKBGPIL<TDeps, TStateSys>(TDeps OHJFEHDLOHB, TStateSys DHJOIBPBMPI, EDDACBEFLJG PDBOIKJNMKA, [In] AJFCGHOLDCP<byte> BEAIPLNCIOD, int NAFKDGMKBON) where TDeps : CMBMBJMPEFJ<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private AJFCGHOLDCP<BPLMMHANMGE> PNAOLECAOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>> LMGKHCBOADF;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x268AA70", Offset = "0x2689E70", VA = "0x18268AA70")]
	private BAHKKEKGKBO([In] AJFCGHOLDCP<BPLMMHANMGE> PJCDGNKPJKH, Dictionary<IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>> GNNKGJNBMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x268A970", Offset = "0x2689D70", VA = "0x18268A970")]
	public static BAHKKEKGKBO HBLBJMFGHFK()
	{
		return default(BAHKKEKGKBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x268AA30", Offset = "0x2689E30", VA = "0x18268AA30")]
	public void OAHDOECNNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3385D10", Offset = "0x3385110", VA = "0x183385D10")]
	public static void AMNMBKBGPIL<TDeps, TStateSys>(EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL) where TDeps : CMBMBJMPEFJ<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class JLFPDKOKIBK
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct CJBFFOAGFMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> MJNALPDIMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int CIJNNIIEHDE;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int PLFDCAJBEJD;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int JNHPIJGBIFO;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x26948A0", Offset = "0x2693CA0", VA = "0x1826948A0")]
	public static void AMNMBKBGPIL(EDDACBEFLJG JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2694F60", Offset = "0x2694360", VA = "0x182694F60")]
	private static void BEJIBKIOGEP([In] EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH, AJFCGHOLDCP<byte> JPAHMGFBKBH, List<CJBFFOAGFMK> IBDHNEBCFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x26950F0", Offset = "0x26944F0", VA = "0x1826950F0")]
	private static void BEJIBKIOGEP(AJFCGHOLDCP<byte> JPAHMGFBKBH, int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2695230", Offset = "0x2694630", VA = "0x182695230")]
	private static void DIAKJNBAOPC(EDDACBEFLJG JOCJBPPJMJJ, List<CJBFFOAGFMK> IBDHNEBCFJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class JFGEFLEIGIJ<TDeps, TIndex, TValues> where TDeps : struct, DJJGBHEOEJK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps AMCNMNPOCHO;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4C068F0", Offset = "0x4C05CF0", VA = "0x184C068F0")]
	public static void AMNMBKBGPIL([In] AJFCGHOLDCP<BPLMMHANMGE> PJCDGNKPJKH, int FPEMFJILKDE, TValues JGMAGBDHLIF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface DJJGBHEOEJK<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AJFCGHOLDCP<TIndex> DCPABAHBGKL(int FPEMFJILKDE, [In] TValues JGMAGBDHLIF);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(TIndex CJFNAFNJJLB, [In] TValues JGMAGBDHLIF);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNOLCFOFNAO(TIndex CJFNAFNJJLB, TValues JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface GLGDEFBGMMC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex JJHMBHCPEID(int CJFNAFNJJLB);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DOHBBEDOPEE(TIndex CJFNAFNJJLB, [In] TValues JGMAGBDHLIF);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(TIndex CJFNAFNJJLB, [In] TValues JGMAGBDHLIF);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class KNCAFBAJMKM<TDeps, TIndex, TValues> where TDeps : struct, GLGDEFBGMMC<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps AMCNMNPOCHO;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4DAA090", Offset = "0x4DA9490", VA = "0x184DAA090")]
	public static AJFCGHOLDCP<TIndex> AMNMBKBGPIL(int FPEMFJILKDE, [In] TValues JGMAGBDHLIF)
	{
		return default(AJFCGHOLDCP<TIndex>);
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
