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
		[Cpp2IlInjected.Address(RVA = "0x9BE830", Offset = "0x9BDC30", VA = "0x1809BE830")]
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
		[Cpp2IlInjected.Address(RVA = "0x2692610", Offset = "0x2691A10", VA = "0x182692610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BF4A0", Offset = "0x9BE8A0", VA = "0x1809BF4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BF4E0", Offset = "0x9BE8E0", VA = "0x1809BF4E0")]
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
	[Cpp2IlInjected.Address(RVA = "0xC6A680", Offset = "0xC69A80", VA = "0x180C6A680")]
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
		[Cpp2IlInjected.Address(RVA = "0x262F8D0", Offset = "0x262ECD0", VA = "0x18262F8D0")]
		public HANOJNCKOKF(GHDELNLDBAO<byte> DHHEGLJJIIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2690DB0", Offset = "0x26901B0", VA = "0x182690DB0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
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
		[Cpp2IlInjected.Address(RVA = "0xC6A680", Offset = "0xC69A80", VA = "0x180C6A680")]
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
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
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
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
		public FLMFEBHFNNP(AKBOPDOBDEE IBDFALHFKEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x268B520", Offset = "0x268A920", VA = "0x18268B520", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x2691D20", Offset = "0x2691120", VA = "0x182691D20")]
	private JLIGNDJDGFD([In] MMJCDOPJBPK<AFNNHJDEFHB, JFFCCKBMJFA> OJKCOPIGGNJ, [In] MMJCDOPJBPK<PPHMLMEAMPI, HANOJNCKOKF> MLOFOAEFFOB, [In] MMJCDOPJBPK<LBADFMFJKBI, AKNNLNEEGLC> DEJBMMLBIJA, [In] MMJCDOPJBPK<DBNIKHNEMAL, DLDFBNLOKEN> IGOPLLLPIIE, [In] MMJCDOPJBPK<OHIMMIKKKMC, FLMFEBHFNNP> EIDHLBHDMPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2691BE0", Offset = "0x2690FE0", VA = "0x182691BE0")]
	public static JLIGNDJDGFD HBLBJMFGHFK()
	{
		return default(JLIGNDJDGFD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class MOPLJPKGALC
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x26920F0", Offset = "0x26914F0", VA = "0x1826920F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
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
		[Cpp2IlInjected.Address(RVA = "0xC6A680", Offset = "0xC69A80", VA = "0x180C6A680")]
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
	[Cpp2IlInjected.Address(RVA = "0x268B350", Offset = "0x268A750", VA = "0x18268B350")]
	private FCAEPDDPFBC([In] MMJCDOPJBPK<IFENLCHPHFK, HHCPGNIGLOD> OJKCOPIGGNJ, [In] MMJCDOPJBPK<POHLBGHFPEE, CPPNONEIMGC> HNBIMJLBICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x268B2C0", Offset = "0x268A6C0", VA = "0x18268B2C0")]
	public static FCAEPDDPFBC HBLBJMFGHFK()
	{
		return default(FCAEPDDPFBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MDLNFJFJFNK
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2692090", Offset = "0x2691490", VA = "0x182692090")]
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
	[Cpp2IlInjected.Address(RVA = "0x2690EC0", Offset = "0x26902C0", VA = "0x182690EC0")]
	private HDEBCKOAHJN([In] AJFCGHOLDCP<int> IHMKENAIEDD, [In] AJFCGHOLDCP<int> MECHNNGKIGE, int CFEDFNKPJBG, int ALCBIEBNHNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2690E20", Offset = "0x2690220", VA = "0x182690E20")]
	public static HDEBCKOAHJN HBLBJMFGHFK()
	{
		return default(HDEBCKOAHJN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class AODNDCDPGAL
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2687150", Offset = "0x2686550", VA = "0x182687150")]
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
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
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
		[Cpp2IlInjected.Address(RVA = "0xC6A680", Offset = "0xC69A80", VA = "0x180C6A680")]
		private KOJAGAKKHHO(KKPEOFPBMPB EIJDODJDHLH, IJOGBJOFPED<IKDNMCOFGEN> OFPHKBLIIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2691E60", Offset = "0x2691260", VA = "0x182691E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
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
		[Cpp2IlInjected.Address(RVA = "0x268B350", Offset = "0x268A750", VA = "0x18268B350")]
		private OCCLCJDDNPE([In] AJFCGHOLDCP<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> PBMICCGPFNN, [In] AJFCGHOLDCP<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> ADPAAGKNICC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2692690", Offset = "0x2691A90", VA = "0x182692690")]
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
	[Cpp2IlInjected.Address(RVA = "0x26876B0", Offset = "0x2686AB0", VA = "0x1826876B0")]
	private CILPNDCBHOO([In] MMJCDOPJBPK<JHHFOECNGCC, KOJAGAKKHHO> OJKCOPIGGNJ, [In] MMJCDOPJBPK<JDECNIGJCJM, AKDAKPMEBFI> CMPCHENMBAA, [In] MMJCDOPJBPK<GOBOBPOPFAB, JKCDMHLMHPB> LGCKHJKNGLH, [In] AJFCGHOLDCP<(IJOGBJOFPED<JHHFOECNGCC> CallId, IJOGBJOFPED<BCKDPEPOOOG> IOId)> DLLEMFGMALO, [In] MMJCDOPJBPK<BCKDPEPOOOG, OCCLCJDDNPE> LEPHMABGCFG, [In] LPLBBMCLGNH<BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> OKHINBNMAIG, [In] LPLBBMCLGNH<BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> FFHHBDMABFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2687510", Offset = "0x2686910", VA = "0x182687510")]
	public static CILPNDCBHOO HBLBJMFGHFK()
	{
		return default(CILPNDCBHOO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class GNKOKJKBBAK
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2690B50", Offset = "0x268FF50", VA = "0x182690B50")]
	private static void OAHDOECNNKP(this CILPNDCBHOO.OCCLCJDDNPE JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2690BA0", Offset = "0x268FFA0", VA = "0x182690BA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x268AC90", Offset = "0x268A090", VA = "0x18268AC90")]
	private EDDACBEFLJG([In] AJFCGHOLDCP<byte> IIMJDNDCHAP, [In] CILPNDCBHOO ALDIPGAMFGC, [In] ADPHNPFBBOB LBLBHCBDBOI, [In] JLIGNDJDGFD IGBCLDOOJEE, [In] FCAEPDDPFBC BAMEHFMKOCH, [In] LPLBBMCLGNH<DIEOFHIAEHN, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>?> AMCDCGABGPO, [In] AJFCGHOLDCP<IJOGBJOFPED<DIEOFHIAEHN>> LIPAINJNFKP, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> CCKOGHCOENC, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> OIFFOAMPHJC, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> PPMLFHJNGCE, [In] NJAMGGIAIGO MEMGJPDIPDI, [In] BAHKKEKGKBO FIKNDAEDMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x268A2E0", Offset = "0x26896E0", VA = "0x18268A2E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2690F20", Offset = "0x2690320", VA = "0x182690F20")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2690FE0", Offset = "0x26903E0", VA = "0x182690FE0", Slot = "4")]
		public IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690")]
		public bool DOHBBEDOPEE(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "5")]
		private bool DPAPPEFGJAG(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2690FD0", Offset = "0x26903D0", VA = "0x182690FD0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x2687820", Offset = "0x2686C20", VA = "0x182687820")]
		public AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>> DCPABAHBGKL(int FPEMFJILKDE, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2687770", Offset = "0x2686B70", VA = "0x182687770")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2687890", Offset = "0x2686C90", VA = "0x182687890", Slot = "6")]
		public void LNOLCFOFNAO(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2687820", Offset = "0x2686C20", VA = "0x182687820", Slot = "4")]
		private AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>> FJLCLIEDLMI(int FPEMFJILKDE, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2687950", Offset = "0x2686D50", VA = "0x182687950", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2692710", Offset = "0x2691B10", VA = "0x182692710")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x26927C0", Offset = "0x2691BC0", VA = "0x1826927C0", Slot = "4")]
		public IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690")]
		public bool DOHBBEDOPEE(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "5")]
		private bool KKDHCKBAMPC(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x26927F0", Offset = "0x2691BF0", VA = "0x1826927F0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x2691F30", Offset = "0x2691330", VA = "0x182691F30")]
		public AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>> DCPABAHBGKL(int FPEMFJILKDE, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2691E80", Offset = "0x2691280", VA = "0x182691E80")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2691FB0", Offset = "0x26913B0", VA = "0x182691FB0", Slot = "6")]
		public void LNOLCFOFNAO(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> CJFNAFNJJLB, LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2691F30", Offset = "0x2691330", VA = "0x182691F30", Slot = "4")]
		private AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>> EGJCCKEGFIH(int FPEMFJILKDE, [In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2691FA0", Offset = "0x26913A0", VA = "0x182691FA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x268B410", Offset = "0x268A810", VA = "0x18268B410")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x268B4F0", Offset = "0x268A8F0", VA = "0x18268B4F0", Slot = "4")]
		public IJOGBJOFPED<KHMKGBDANIH> JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(IJOGBJOFPED<KHMKGBDANIH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x268B390", Offset = "0x268A790", VA = "0x18268B390")]
		public bool DOHBBEDOPEE(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x268B390", Offset = "0x268A790", VA = "0x18268B390", Slot = "5")]
		private bool CMPKDFKGLFM(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x268B4E0", Offset = "0x268A8E0", VA = "0x18268B4E0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x26908C0", Offset = "0x268FCC0", VA = "0x1826908C0")]
		public AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>> DCPABAHBGKL(int FPEMFJILKDE, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x26907F0", Offset = "0x268FBF0", VA = "0x1826907F0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2690940", Offset = "0x268FD40", VA = "0x182690940", Slot = "6")]
		public void LNOLCFOFNAO(IJOGBJOFPED<KHMKGBDANIH> CJFNAFNJJLB, LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x26908C0", Offset = "0x268FCC0", VA = "0x1826908C0", Slot = "4")]
		private AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>> LINECBIBCLA(int FPEMFJILKDE, [In] LPLBBMCLGNH<KHMKGBDANIH, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>?> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<IJOGBJOFPED<KHMKGBDANIH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2690930", Offset = "0x268FD30", VA = "0x182690930", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2691010", Offset = "0x2690410", VA = "0x182691010")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD005B0", Offset = "0xCFF9B0", VA = "0x180D005B0", Slot = "4")]
		public int JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690")]
		public bool DOHBBEDOPEE(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "5")]
		private bool LCKBKBPANPI(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x26910B0", Offset = "0x26904B0", VA = "0x1826910B0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x268B140", Offset = "0x268A540", VA = "0x18268B140")]
		public AJFCGHOLDCP<int> DCPABAHBGKL(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x268B0A0", Offset = "0x268A4A0", VA = "0x18268B0A0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x268B1C0", Offset = "0x268A5C0", VA = "0x18268B1C0", Slot = "6")]
		public void LNOLCFOFNAO(int CJFNAFNJJLB, AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x268B140", Offset = "0x268A540", VA = "0x18268B140", Slot = "4")]
		private AJFCGHOLDCP<int> IHCMGLCDNEF(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> VariableId, IJOGBJOFPED<JAHELGAGFCI<KGFODMDJAKK<JCKHHCNOCBD>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x268B1B0", Offset = "0x268A5B0", VA = "0x18268B1B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2690AA0", Offset = "0x268FEA0", VA = "0x182690AA0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD005B0", Offset = "0xCFF9B0", VA = "0x180D005B0", Slot = "4")]
		public int JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690")]
		public bool DOHBBEDOPEE(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "5")]
		private bool POGIKPMAOOD(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2690B40", Offset = "0x268FF40", VA = "0x182690B40", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x2687AB0", Offset = "0x2686EB0", VA = "0x182687AB0")]
		public AJFCGHOLDCP<int> DCPABAHBGKL(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2687A10", Offset = "0x2686E10", VA = "0x182687A10")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2687B30", Offset = "0x2686F30", VA = "0x182687B30", Slot = "6")]
		public void LNOLCFOFNAO(int CJFNAFNJJLB, AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2687AB0", Offset = "0x2686EB0", VA = "0x182687AB0", Slot = "4")]
		private AJFCGHOLDCP<int> JGDBLDJILOJ(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2687B20", Offset = "0x2686F20", VA = "0x182687B20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2691DB0", Offset = "0x26911B0", VA = "0x182691DB0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xD005B0", Offset = "0xCFF9B0", VA = "0x180D005B0", Slot = "4")]
		public int JJHMBHCPEID(int CJFNAFNJJLB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690")]
		public bool DOHBBEDOPEE(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9AF690", Offset = "0x9AEA90", VA = "0x1809AF690", Slot = "5")]
		private bool POGIKPMAOOD(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2691E50", Offset = "0x2691250", VA = "0x182691E50", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x2687390", Offset = "0x2686790", VA = "0x182687390")]
		public AJFCGHOLDCP<int> DCPABAHBGKL(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x26872F0", Offset = "0x26866F0", VA = "0x1826872F0")]
		public IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> CPLJODJPMAN(int CJFNAFNJJLB, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2687410", Offset = "0x2686810", VA = "0x182687410", Slot = "6")]
		public void LNOLCFOFNAO(int CJFNAFNJJLB, AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF, IJOGBJOFPED<JAHELGAGFCI<JCKHHCNOCBD>> FFOEEMKIKJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2687390", Offset = "0x2686790", VA = "0x182687390", Slot = "4")]
		private AJFCGHOLDCP<int> JGDBLDJILOJ(int FPEMFJILKDE, [In] AJFCGHOLDCP<(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> Target, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ByteCodeWriteLocation)> JGMAGBDHLIF)
		{
			return default(AJFCGHOLDCP<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2687400", Offset = "0x2686800", VA = "0x182687400", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D312C0", Offset = "0x1D306C0", VA = "0x181D312C0")]
		public JDJGONKJECJ(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF, bool BGFDPHNDDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x26910C0", Offset = "0x26904C0", VA = "0x1826910C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2687C50", Offset = "0x2687050", VA = "0x182687C50")]
		public DLLNNGJEJLM(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF, bool BGFDPHNDDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2687C20", Offset = "0x2687020", VA = "0x182687C20")]
		public void LKJBGMAPBIG([Out] IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF, [Out] bool BGFDPHNDDKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2687C30", Offset = "0x2687030", VA = "0x182687C30")]
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
		[Cpp2IlInjected.Address(RVA = "0xC6A680", Offset = "0xC69A80", VA = "0x180C6A680")]
		public LKPECIBOABK(IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2691E70", Offset = "0x2691270", VA = "0x182691E70")]
		public void LKJBGMAPBIG([Out] IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF, [Out] IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2689C90", Offset = "0x2689090", VA = "0x182689C90")]
	public static void OAHDOECNNKP(this EDDACBEFLJG JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2689C00", Offset = "0x2689000", VA = "0x182689C00")]
	public static void NMEMKDDOOCA(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> JNIGANDJNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2689120", Offset = "0x2688520", VA = "0x182689120")]
	public static void IMAPNGFMMKE(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> JNIGANDJNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2687DD0", Offset = "0x26871D0", VA = "0x182687DD0")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>? ANGHAAMIHDD([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2688720", Offset = "0x2687B20", VA = "0x182688720")]
	public static IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> DOKALJNJPJE([In] this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x26883C0", Offset = "0x26877C0", VA = "0x1826883C0")]
	private static void CLIJONDIDAA(this EDDACBEFLJG JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2688BF0", Offset = "0x2687FF0", VA = "0x182688BF0")]
	private static IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>? HHDFDIACCDF([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2689320", Offset = "0x2688720", VA = "0x182689320")]
	public static void JAFLPDKAICG(this EDDACBEFLJG JOCJBPPJMJJ, [In] AJFCGHOLDCP<BPLMMHANMGE> PJCDGNKPJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2687C60", Offset = "0x2687060", VA = "0x182687C60")]
	public static JLIGNDJDGFD.OMODGDONHAE AHALBNMBBHB([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(JLIGNDJDGFD.OMODGDONHAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2689A90", Offset = "0x2688E90", VA = "0x182689A90")]
	public static GHDELNLDBAO<byte> MMCIFJEEEEJ([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(GHDELNLDBAO<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2687CE0", Offset = "0x26870E0", VA = "0x182687CE0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> ALHHLDLENMH([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x26885B0", Offset = "0x26879B0", VA = "0x1826885B0")]
	public static AKBOPDOBDEE DKDGOEKILNK([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(AKBOPDOBDEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3465620", Offset = "0x3464A20", VA = "0x183465620")]
	private static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> IBFGDMMHKLL<TMJoin>(this EDDACBEFLJG JOCJBPPJMJJ, JLIGNDJDGFD.OMODGDONHAE EIJDODJDHLH, IJOGBJOFPED<TMJoin> OFPHKBLIIDI) where TMJoin : JLIGNDJDGFD.FOMEKLECOJL
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2689B80", Offset = "0x2688F80", VA = "0x182689B80")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> NEECBHCNHDM(this EDDACBEFLJG JOCJBPPJMJJ, bool OAAFEPPONMI)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2689600", Offset = "0x2688A00", VA = "0x182689600")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> KCEAAMDNKHN(this EDDACBEFLJG JOCJBPPJMJJ, GHDELNLDBAO<byte> DHHEGLJJIIE)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2688F60", Offset = "0x2688360", VA = "0x182688F60")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> IFKAFOBAHJL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> AKLIGBGACAM)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2689580", Offset = "0x2688980", VA = "0x182689580")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> JJGAACJBIOB(this EDDACBEFLJG JOCJBPPJMJJ, int DJLIDNFCFDD)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2688530", Offset = "0x2687930", VA = "0x182688530")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> DFOHNJAPFDK(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3465570", Offset = "0x3464970", VA = "0x183465570")]
	private static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> GFFIBBCHKGG<TMJoin>(this EDDACBEFLJG JOCJBPPJMJJ, FCAEPDDPFBC.HIINLLBJOAN EIJDODJDHLH, IJOGBJOFPED<TMJoin> OFPHKBLIIDI) where TMJoin : FCAEPDDPFBC.NOOINAHCFJH
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2688910", Offset = "0x2687D10", VA = "0x182688910")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> GOHAJMKJEKC(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x26887D0", Offset = "0x2687BD0", VA = "0x1826887D0")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> FBDMDOOHCDE(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2688150", Offset = "0x2687550", VA = "0x182688150")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> CCJLEEADAIP(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> CJLKOLCLMEC)
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2688FE0", Offset = "0x26883E0", VA = "0x182688FE0")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> IIHAGCCKELN(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2688780", Offset = "0x2687B80", VA = "0x182688780")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> DONGFFCDDAL(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2688950", Offset = "0x2687D50", VA = "0x182688950")]
	public static CILPNDCBHOO.KKPEOFPBMPB GOIHANGFJDO([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> AHMNMKOHBOP)
	{
		return default(CILPNDCBHOO.KKPEOFPBMPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x268A2A0", Offset = "0x26896A0", VA = "0x18268A2A0")]
	public static DCFBMJCCGFF<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>, PCNDONFGOFI<CILPNDCBHOO.BCKDPEPOOOG>> PDAAAKNHJED([In] this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(DCFBMJCCGFF<IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>, PCNDONFGOFI<CILPNDCBHOO.BCKDPEPOOOG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2689FD0", Offset = "0x26893D0", VA = "0x182689FD0")]
	public static IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> OKCGJHPMHBP([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> AHMNMKOHBOP)
	{
		return default(IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x26886A0", Offset = "0x2687AA0", VA = "0x1826886A0")]
	public static CILPNDCBHOO.OCCLCJDDNPE DLECHHAJNOK([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> ODGINCJIADF)
	{
		return default(CILPNDCBHOO.OCCLCJDDNPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2689920", Offset = "0x2688D20", VA = "0x182689920")]
	public static CILPNDCBHOO.OCCLCJDDNPE LPLGFABCACL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> ODGINCJIADF)
	{
		return default(CILPNDCBHOO.OCCLCJDDNPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x34654D0", Offset = "0x34648D0", VA = "0x1834654D0")]
	private static IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> FGBEJFELMNP<TMJoin>(this EDDACBEFLJG JOCJBPPJMJJ, CILPNDCBHOO.KKPEOFPBMPB EIJDODJDHLH, IJOGBJOFPED<TMJoin> OFPHKBLIIDI) where TMJoin : CILPNDCBHOO.IKDNMCOFGEN
	{
		return default(IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2689690", Offset = "0x2688A90", VA = "0x182689690")]
	public static (IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>) KGHFMCJIKFI(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default((IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2688CB0", Offset = "0x26880B0", VA = "0x182688CB0")]
	public static (IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>) HIKELPDDALB(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default((IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x26898D0", Offset = "0x2688CD0", VA = "0x1826898D0")]
	public static IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> LCFNIEHLNLP(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2689840", Offset = "0x2688C40", VA = "0x182689840")]
	public static void LBAPIPAGPPL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG> ODGINCJIADF, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> IDGPNLEBBBI, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>> HOMLKMNGBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x34646A0", Offset = "0x3463AA0", VA = "0x1834646A0")]
	public static JDJGONKJECJ CLCBKNONAOL<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<KHMKGBDANIH> DGBNICFCJPK) where TDeps : CMBMBJMPEFJ<TStateSys>
	{
		return default(JDJGONKJECJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x34657A0", Offset = "0x3464BA0", VA = "0x1834657A0")]
	public static DLLNNGJEJLM NHMBPBGHAEB<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, int FNJFCLABCPK) where TDeps : CMBMBJMPEFJ<TStateSys>
	{
		return default(DLLNNGJEJLM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3463C90", Offset = "0x3463090", VA = "0x183463C90")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>? APGFCKNONIO<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<EICBKBBFNCN> CCBIHMLAAKK, [In] ReadOnlySpan<int> DGOGFAIDOHL, [In] Span<LKPECIBOABK> LDLOAPOMCNG) where TDeps : CMBMBJMPEFJ<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x34640D0", Offset = "0x34634D0", VA = "0x1834640D0")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> CACLDCNIDBJ<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH, IJOGBJOFPED<DIEOFHIAEHN> MPJFFADFMPN) where TDeps : CMBMBJMPEFJ<TStateSys>
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x26899A0", Offset = "0x2688DA0", VA = "0x1826899A0")]
	public static ADPHNPFBBOB.MBPONCINENC MIFBGPIPLDA([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return default(ADPHNPFBBOB.MBPONCINENC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2689030", Offset = "0x2688430", VA = "0x182689030")]
	public static ADPHNPFBBOB.INEEPBGOCLG IIKOLAGNCAJ([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return default(ADPHNPFBBOB.INEEPBGOCLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2689490", Offset = "0x2688890", VA = "0x182689490")]
	public static ADPHNPFBBOB.ELDOLLHGIJK JELEACINJDL([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return default(ADPHNPFBBOB.ELDOLLHGIJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2687FC0", Offset = "0x26873C0", VA = "0x182687FC0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BJAKDFAFNDA(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL, string IGEPDAOOLBO)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2688820", Offset = "0x2687C20", VA = "0x182688820")]
	public static ADPHNPFBBOB.IJKNMBAIJOB GLAMENFJLPI([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return default(ADPHNPFBBOB.IJKNMBAIJOB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2688EF0", Offset = "0x26882F0", VA = "0x182688EF0")]
	public static ADPHNPFBBOB.FINEOBEFHDP IDINCOLJJJF([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return default(ADPHNPFBBOB.FINEOBEFHDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2689F60", Offset = "0x2689360", VA = "0x182689F60")]
	public static int? OGDBCGKHCAO([In] this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3463B90", Offset = "0x3462F90", VA = "0x183463B90")]
	private static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> AFDCCIHIMNL<TMJoin>(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL, ADPHNPFBBOB.FINEOBEFHDP EIJDODJDHLH, IJOGBJOFPED<TMJoin> OFPHKBLIIDI) where TMJoin : ADPHNPFBBOB.GOMNELOMNHI
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2688310", Offset = "0x2687710", VA = "0x182688310")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CJELJBODFBB(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> AHMNMKOHBOP, int CJFNAFNJJLB)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2687F60", Offset = "0x2687360", VA = "0x182687F60")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BEEGKBNLBAG(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x26889D0", Offset = "0x2687DD0", VA = "0x1826889D0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> HEGCBDFGCHC(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? AEIDFEKHNMP, int? DFEEGAKIKLL)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2688E60", Offset = "0x2688260", VA = "0x182688E60")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> HJBMKFGHDEN(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL, int CJFNAFNJJLB)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x268A240", Offset = "0x2689640", VA = "0x18268A240")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PBMOBJDAPBA(this EDDACBEFLJG JOCJBPPJMJJ, int? DFEEGAKIKLL)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26881D0", Offset = "0x26875D0", VA = "0x1826881D0")]
	public static void CCNJPKPONMM(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC> AHMNMKOHBOP, int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x26891F0", Offset = "0x26885F0", VA = "0x1826891F0")]
	public static void IMIPMNKMKBK(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI, int CJFNAFNJJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2687E90", Offset = "0x2687290", VA = "0x182687E90")]
	public static void AOLPFABLHCN(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x268A1B0", Offset = "0x26895B0", VA = "0x18268A1B0")]
	public static void OPHIEHBMGNI(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> IGICHEAKAKH, IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> KDPKPPHCBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2688B20", Offset = "0x2687F20", VA = "0x182688B20")]
	public static void HHCFFKDCBAA(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CCHPBPDKAFI, IJOGBJOFPED<JAHELGAGFCI<NGJBIHDGFDI>> DIIFAOEIECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x34656D0", Offset = "0x3464AD0", VA = "0x1834656D0")]
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
	[Cpp2IlInjected.Address(RVA = "0x35D74B0", Offset = "0x35D68B0", VA = "0x1835D74B0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK?> KLJGJDAMFMH<T, TOpInput, TOpOutput>(this EDDACBEFLJG JOCJBPPJMJJ, T BICHNBDCKLH, T CKCKMBIGMMF, int ELCPMIPCPDL, IntPtr DKFMMLIFNLP)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x35D8B70", Offset = "0x35D7F70", VA = "0x1835D8B70")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK?> OPANOFNHKGE<T, TOpInput, TOpOutput>(this EDDACBEFLJG JOCJBPPJMJJ, T BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF, int ELCPMIPCPDL, IntPtr DKFMMLIFNLP)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x35D8440", Offset = "0x35D7840", VA = "0x1835D8440")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK?> MBNLMNJNCBA<TOpInput, TOpOutput>(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF, int ELCPMIPCPDL, IntPtr DKFMMLIFNLP)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x268C110", Offset = "0x268B510", VA = "0x18268C110")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DAMNAACPOMB(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x268DB70", Offset = "0x268CF70", VA = "0x18268DB70")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> HHEAMEACOIL(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x268BE90", Offset = "0x268B290", VA = "0x18268BE90")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CJDMJALBHAN(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x268BA20", Offset = "0x268AE20", VA = "0x18268BA20")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BMBCDNIIJNC(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2690130", Offset = "0x268F530", VA = "0x182690130")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OOCMMMFLOGP(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x268DF90", Offset = "0x268D390", VA = "0x18268DF90")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> IBOJHJLHODP(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x268ECA0", Offset = "0x268E0A0", VA = "0x18268ECA0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> LBNCDPNBMDB(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2690490", Offset = "0x268F890", VA = "0x182690490")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PHOEJBOPBNE(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x268F430", Offset = "0x268E830", VA = "0x18268F430")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NGJAGLIBCOC(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x268E5C0", Offset = "0x268D9C0", VA = "0x18268E5C0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> JLEMNGPNFCB(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, int CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x268B660", Offset = "0x268AA60", VA = "0x18268B660")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> AMAMPDPCCKK(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x268C210", Offset = "0x268B610", VA = "0x18268C210")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DCDIPCLEOPJ(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x268E840", Offset = "0x268DC40", VA = "0x18268E840")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KFLHFOJCNBE(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, float CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x268EFD0", Offset = "0x268E3D0", VA = "0x18268EFD0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> MIHNBGLOCDO(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x26905B0", Offset = "0x268F9B0", VA = "0x1826905B0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PILINANMNFC(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x268F600", Offset = "0x268EA00", VA = "0x18268F600")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NMDNAMAEGPJ(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, int CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x268BB20", Offset = "0x268AF20", VA = "0x18268BB20")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BMKEJHMDHAL(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x268F9F0", Offset = "0x268EDF0", VA = "0x18268F9F0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OGIILFMNLFP(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x268F970", Offset = "0x268ED70", VA = "0x18268F970")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OGIIFIPFNDF(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, float CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2690410", Offset = "0x268F810", VA = "0x182690410")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PEOMNIDFMEC(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x268E0D0", Offset = "0x268D4D0", VA = "0x18268E0D0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> IEGIMHFAMHL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x268D4A0", Offset = "0x268C8A0", VA = "0x18268D4A0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> GGFMAOCNPGE(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, int CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x268E7C0", Offset = "0x268DBC0", VA = "0x18268E7C0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KEEALCFEBPI(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x268C470", Offset = "0x268B870", VA = "0x18268C470")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DOEDGMDJEGF(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x268CDD0", Offset = "0x268C1D0", VA = "0x18268CDD0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FKGNJNOMOEP(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, float CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x268CB70", Offset = "0x268BF70", VA = "0x18268CB70")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> ELKJMOBNDKA(this EDDACBEFLJG JOCJBPPJMJJ, float BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x268E440", Offset = "0x268D840", VA = "0x18268E440")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> JEKCIAKAJFC(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x268E150", Offset = "0x268D550", VA = "0x18268E150")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> JBCIGMKHLNB(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x268BBA0", Offset = "0x268AFA0", VA = "0x18268BBA0")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> CELJLDADEBA(this EDDACBEFLJG JOCJBPPJMJJ, int FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x268C870", Offset = "0x268BC70", VA = "0x18268C870")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> ECAPPNGKHHA(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x268D760", Offset = "0x268CB60", VA = "0x18268D760")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> HAJCNFCMCCG(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> ELNMFMMMJEF)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x268DAF0", Offset = "0x268CEF0", VA = "0x18268DAF0")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> HGKFGNEDGCO(this EDDACBEFLJG JOCJBPPJMJJ, int FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x268D910", Offset = "0x268CD10", VA = "0x18268D910")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> HDNJCICJGAH(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x268CE50", Offset = "0x268C250", VA = "0x18268CE50")]
	public static (IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>) FKHICOOPDPN(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<GFMPOBJPFLN> BMMHOGHMCMD, [In] ReadOnlySpan<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> PBMICCGPFNN, [In] ReadOnlySpan<int?> PGFOLGJDCCH, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> LMCBKNEPHCC)
	{
		return default((IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x268FCF0", Offset = "0x268F0F0", VA = "0x18268FCF0")]
	public static (IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>) OMMGLKFNBPL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<DCGBFPGIBOL> ABAEHEHCKOH, [In] ReadOnlySpan<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> PBMICCGPFNN, [In] ReadOnlySpan<int?> PGFOLGJDCCH, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> LMCBKNEPHCC)
	{
		return default((IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x35D6E10", Offset = "0x35D6210", VA = "0x1835D6E10")]
	public static (IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>) GONHHDDEJDE<TMarker>(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<FNOIGLEFPAM> DPOANBKHFEA, [In] ReadOnlySpan<byte> HPMNBNLACCC)
	{
		return default((IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<JAHELGAGFCI<FNOIGLEFPAM>>, IJOGBJOFPED<JAHELGAGFCI<NEBCLJMKMGM>>, IJOGBJOFPED<JAHELGAGFCI<TMarker>>, IJOGBJOFPED<CILPNDCBHOO.JHHFOECNGCC>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x268CD10", Offset = "0x268C110", VA = "0x18268CD10")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FKFLNCICGLC(this EDDACBEFLJG JOCJBPPJMJJ, int FJONCPGPEAA, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x268F340", Offset = "0x268E740", VA = "0x18268F340")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NBPIGBPECID(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FJONCPGPEAA, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x268F780", Offset = "0x268EB80", VA = "0x18268F780")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NOMHEBBIEKA(this EDDACBEFLJG JOCJBPPJMJJ, [In] ReadOnlySpan<byte> FJONCPGPEAA, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x268D9B0", Offset = "0x268CDB0", VA = "0x18268D9B0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> HDOGJCJALJC(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FJONCPGPEAA, int MNDMOIHIBEI, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x268B920", Offset = "0x268AD20", VA = "0x18268B920")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDFEOPEADBK(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x268CBF0", Offset = "0x268BFF0", VA = "0x18268CBF0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FDLHNNIHBAA(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x268EA60", Offset = "0x268DE60", VA = "0x18268EA60")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KMAOIEBEECH(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x268D3A0", Offset = "0x268C7A0", VA = "0x18268D3A0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FMKHIOIKNFL(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x268B780", Offset = "0x268AB80", VA = "0x18268B780")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> AOIOKJOBMFM(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x268F100", Offset = "0x268E500", VA = "0x18268F100")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> MIIDIMJCILL(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x268F570", Offset = "0x268E970", VA = "0x18268F570")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NIFADNPFPEJ(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, int CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x268B8A0", Offset = "0x268ACA0", VA = "0x18268B8A0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> APOCGKJELEN(this EDDACBEFLJG JOCJBPPJMJJ, int BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2690250", Offset = "0x268F650", VA = "0x182690250")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PBFMOKJFHEA(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BICHNBDCKLH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CKCKMBIGMMF)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x268E4C0", Offset = "0x268D8C0", VA = "0x18268E4C0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> JKLAKODMOAC(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x268BC20", Offset = "0x268B020", VA = "0x18268BC20")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CHBEJOLGKCA(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x268BFD0", Offset = "0x268B3D0", VA = "0x18268BFD0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CLCKBBDGDIF(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x268F240", Offset = "0x268E640", VA = "0x18268F240")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> MPLIELCDNDF(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x268D640", Offset = "0x268CA40", VA = "0x18268D640")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> GLLGGKFNCCA(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x268C910", Offset = "0x268BD10", VA = "0x18268C910")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> EELAAEFLNMK(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x268DAD0", Offset = "0x268CED0", VA = "0x18268DAD0")]
	public static IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>> HFOOOBIKGDI(this EDDACBEFLJG JOCJBPPJMJJ)
	{
		return default(IJOGBJOFPED<JAHELGAGFCI<JAHELGAGFCI<MIEINCILBCI>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x268EED0", Offset = "0x268E2D0", VA = "0x18268EED0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> LPKJLCGPLMP(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x268E940", Offset = "0x268DD40", VA = "0x18268E940")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KLGHOPHCBCF(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x268FA70", Offset = "0x268EE70", VA = "0x18268FA70")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OHFACKLMLEN(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x268EBA0", Offset = "0x268DFA0", VA = "0x18268EBA0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KOEEFDPKMNH(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x268C350", Offset = "0x268B750", VA = "0x18268C350")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DKMCINFOKKG(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x268E300", Offset = "0x268D700", VA = "0x18268E300")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> JCIAGDIDPMF(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x26906F0", Offset = "0x268FAF0", VA = "0x1826906F0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PKOPGHAEJLI(this EDDACBEFLJG JOCJBPPJMJJ, int FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x268D290", Offset = "0x268C690", VA = "0x18268D290")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FLLLFGDPNFF(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FFOEEMKIKJO)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x268F5F0", Offset = "0x268E9F0", VA = "0x18268F5F0")]
	public static void NJDOCPNPPIO(this EDDACBEFLJG JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x268E6C0", Offset = "0x268DAC0", VA = "0x18268E6C0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> KBAALKCLKGP(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, float BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x268B540", Offset = "0x268A940", VA = "0x18268B540")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> ACEKPMDNCCE(this EDDACBEFLJG JOCJBPPJMJJ, float DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x268FBB0", Offset = "0x268EFB0", VA = "0x18268FBB0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OMKGMDDIEPK(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x268F870", Offset = "0x268EC70", VA = "0x18268F870")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> OGAIGFDCDBM(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x268CA50", Offset = "0x268BE50", VA = "0x18268CA50")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> EJJBPAACIAJ(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x26902D0", Offset = "0x268F6D0", VA = "0x1826902D0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> PBLNKCALNMF(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x268C4F0", Offset = "0x268B8F0", VA = "0x18268C4F0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> EBODLGLIFKI(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> MGBEIFFJIMF, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> BLAIJCBBAKK)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x268F680", Offset = "0x268EA80", VA = "0x18268F680")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NOALDOFHLGO(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, int BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x268D520", Offset = "0x268C920", VA = "0x18268D520")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> GJCHODJKFJO(this EDDACBEFLJG JOCJBPPJMJJ, int DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x268BD50", Offset = "0x268B150", VA = "0x18268BD50")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> CIPDEIHPELB(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DEMCJNIKPJH, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> BDBPBKINMFE)
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x35D6F10", Offset = "0x35D6310", VA = "0x1835D6F10")]
	public static void KCNGHJHKMKI<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<GFMPOBJPFLN> BMMHOGHMCMD, [In] ReadOnlySpan<IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>> GANOKHBODHE, [In] ReadOnlySpan<int?> PGFOLGJDCCH, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> LMCBKNEPHCC, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> BKNKGBPICFA, [In] ReadOnlySpan<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>?> PJGEDMLFNJK) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x35D7EA0", Offset = "0x35D72A0", VA = "0x1835D7EA0")]
	public static void LJNLDDLEBCO<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<DCGBFPGIBOL> MOIIPMBKBLO, [In] ReadOnlySpan<IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>> MEFGIOJONAH, [In] ReadOnlySpan<int?> PGFOLGJDCCH, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> LMCBKNEPHCC, [In] Span<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>> BKNKGBPICFA, [In] ReadOnlySpan<IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>?> PJGEDMLFNJK) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x35D5FB0", Offset = "0x35D53B0", VA = "0x1835D5FB0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> DBABOBIKBIO<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> AEIDFEKHNMP, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x35D7A40", Offset = "0x35D6E40", VA = "0x1835D7A40")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> LFPAICEDMND<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> CJLKOLCLMEC, [Optional] IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x35D6190", Offset = "0x35D5590", VA = "0x1835D6190")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> FKIKOAKOKDC<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL) where TDeps : notnull, CMBMBJMPEFJ<TStateSys> where TStateSys : notnull
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x35D8960", Offset = "0x35D7D60", VA = "0x1835D8960")]
	public static IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK> NELEHBBGHEF<TDeps, TStateSys>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL) where TDeps : notnull, CMBMBJMPEFJ<TStateSys> where TStateSys : notnull
	{
		return default(IJOGBJOFPED<FCAEPDDPFBC.IFENLCHPHFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x268EDA0", Offset = "0x268E1A0", VA = "0x18268EDA0")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> LOHHKJHLMEI(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> KFLJPENHCGO, IntPtr OCJCMAFICIM, IntPtr CHBMCIMNEFN)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x268DC90", Offset = "0x268D090", VA = "0x18268DC90")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> HKFEEDPCAOI(this EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> MHPBHKJGGDO, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> GOIBOPLIJAF, IntPtr KCFFJEOMCMJ, IntPtr JFLKIHGDLMP, IntPtr HGPAGNHHADF, bool DEIELNKMDNJ)
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x35D63C0", Offset = "0x35D57C0", VA = "0x1835D63C0")]
	public static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> FLKMAFJMNOI<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<GFMPOBJPFLN> HBJCDKADOKE, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> MHPBHKJGGDO, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> GOIBOPLIJAF, int? OLLGCHGGKLF, [Optional] IntPtr FOGPIMBEOKF) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x35D65D0", Offset = "0x35D59D0", VA = "0x1835D65D0")]
	private static IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> FLKMAFJMNOI<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<GFMPOBJPFLN> HBJCDKADOKE, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> MHPBHKJGGDO, IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB> GOIBOPLIJAF, int? OLLGCHGGKLF) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
		return default(IJOGBJOFPED<JLIGNDJDGFD.AFNNHJDEFHB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x35D85B0", Offset = "0x35D79B0", VA = "0x1835D85B0")]
	public static IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> MNMNGHMFAIO<TDeps, TState>(this EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TState DHJOIBPBMPI, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> FJONCPGPEAA, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>? DECLPGCFODA) where TDeps : notnull, CMBMBJMPEFJ<TState> where TState : notnull
	{
		return default(IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x35D77B0", Offset = "0x35D6BB0", VA = "0x1835D77B0")]
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
	[Cpp2IlInjected.Address(RVA = "0xC6A680", Offset = "0xC69A80", VA = "0x180C6A680")]
	public BKEHPPOADCP(IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> LBHANGFCPFF, IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>> MKNDHEOLHOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x26872E0", Offset = "0x26866E0", VA = "0x1826872E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC6A680", Offset = "0xC69A80", VA = "0x180C6A680")]
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
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
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
		[Cpp2IlInjected.Address(RVA = "0xC6A680", Offset = "0xC69A80", VA = "0x180C6A680")]
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
		[Cpp2IlInjected.Address(RVA = "0x2692070", Offset = "0x2691470", VA = "0x182692070")]
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
		[Cpp2IlInjected.Address(RVA = "0x11BE580", Offset = "0x11BD980", VA = "0x1811BE580")]
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
	[Cpp2IlInjected.Address(RVA = "0x2687020", Offset = "0x2686420", VA = "0x182687020")]
	private ADPHNPFBBOB([In] LILLHCBLPLN<FDDNNFEDGPK, LNGLGEAHADL> OJKCOPIGGNJ, [In] LILLHCBLPLN<DMMNNCOPFHI, MBPONCINENC> POFFKGPLKCF, [In] LILLHCBLPLN<LDBKLELIOGB, ELDOLLHGIJK> OCBKMBIFEAG, [In] LILLHCBLPLN<KGLBOEIOADE, IJKNMBAIJOB> FLFMKGJFANF, [In] LILLHCBLPLN<GDLPIHKLGAI, INEEPBGOCLG> PPHMOPPBFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2686E30", Offset = "0x2686230", VA = "0x182686E30")]
	public static ADPHNPFBBOB HBLBJMFGHFK()
	{
		return default(ADPHNPFBBOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class PNHAFFNCACB
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2692800", Offset = "0x2691C00", VA = "0x182692800")]
	public static void OAHDOECNNKP(this ADPHNPFBBOB JOCJBPPJMJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class AABBEMNJPEC
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2686C50", Offset = "0x2686050", VA = "0x182686C50")]
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
	[Cpp2IlInjected.Address(RVA = "0x26925D0", Offset = "0x26919D0", VA = "0x1826925D0")]
	private NJAMGGIAIGO([In] LPLBBMCLGNH<CILPNDCBHOO.BCKDPEPOOOG, HDEBCKOAHJN> GCLEABKBNIC, int NMFGNKHMDLC, int LBMPMOPJKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2692370", Offset = "0x2691770", VA = "0x182692370")]
	public static NJAMGGIAIGO HBLBJMFGHFK()
	{
		return default(NJAMGGIAIGO);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x26923E0", Offset = "0x26917E0", VA = "0x1826923E0")]
	public void OAHDOECNNKP([In] EDDACBEFLJG PDBOIKJNMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x37BF0F0", Offset = "0x37BE4F0", VA = "0x1837BF0F0")]
	public static void AMNMBKBGPIL<TDeps, TStateSys>(EDDACBEFLJG JOCJBPPJMJJ, TDeps OHJFEHDLOHB, TStateSys BFFPFEMKACL, IJOGBJOFPED<IIPIDDOCOEJ> MIFALNLOHHH) where TDeps : notnull, CMBMBJMPEFJ<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NEAPDPAEADL
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x26921A0", Offset = "0x26915A0", VA = "0x1826921A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2690A20", Offset = "0x268FE20", VA = "0x182690A20", Slot = "4")]
		public void GLHCMKINICF(AJFCGHOLDCP<byte> IIMJDNDCHAP, int PHFIONPIAGC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct EKGINKMJFBL : EMJLFLFLJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x268AFF0", Offset = "0x268A3F0", VA = "0x18268AFF0", Slot = "4")]
		public void GLHCMKINICF(AJFCGHOLDCP<byte> IIMJDNDCHAP, int PHFIONPIAGC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct ADKJOLJJEOH : EMJLFLFLJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2686DB0", Offset = "0x26861B0", VA = "0x182686DB0", Slot = "4")]
		public void GLHCMKINICF(AJFCGHOLDCP<byte> IIMJDNDCHAP, int PHFIONPIAGC)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct CLFMEDJMGIC : EMJLFLFLJAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2687960", Offset = "0x2686D60", VA = "0x182687960", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BB4F00", Offset = "0x3BB4300", VA = "0x183BB4F00")]
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
	[Cpp2IlInjected.Address(RVA = "0x26872A0", Offset = "0x26866A0", VA = "0x1826872A0")]
	private BAHKKEKGKBO([In] AJFCGHOLDCP<BPLMMHANMGE> PJCDGNKPJKH, Dictionary<IJOGBJOFPED<JAHELGAGFCI<MIEINCILBCI>>, IJOGBJOFPED<CILPNDCBHOO.BCKDPEPOOOG>> GNNKGJNBMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x26871A0", Offset = "0x26865A0", VA = "0x1826871A0")]
	public static BAHKKEKGKBO HBLBJMFGHFK()
	{
		return default(BAHKKEKGKBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2687260", Offset = "0x2686660", VA = "0x182687260")]
	public void OAHDOECNNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x336FB00", Offset = "0x336EF00", VA = "0x18336FB00")]
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
	[Cpp2IlInjected.Address(RVA = "0x26910D0", Offset = "0x26904D0", VA = "0x1826910D0")]
	public static void AMNMBKBGPIL(EDDACBEFLJG JOCJBPPJMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2691790", Offset = "0x2690B90", VA = "0x182691790")]
	private static void BEJIBKIOGEP([In] EDDACBEFLJG JOCJBPPJMJJ, IJOGBJOFPED<ADPHNPFBBOB.FDDNNFEDGPK> NCJKGMLAKGH, AJFCGHOLDCP<byte> JPAHMGFBKBH, List<CJBFFOAGFMK> IBDHNEBCFJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2691920", Offset = "0x2690D20", VA = "0x182691920")]
	private static void BEJIBKIOGEP(AJFCGHOLDCP<byte> JPAHMGFBKBH, int MNDMOIHIBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2691A60", Offset = "0x2690E60", VA = "0x182691A60")]
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
	[Cpp2IlInjected.Address(RVA = "0x4BE6540", Offset = "0x4BE5940", VA = "0x184BE6540")]
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
	[Cpp2IlInjected.Address(RVA = "0x4D8BF40", Offset = "0x4D8B340", VA = "0x184D8BF40")]
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
