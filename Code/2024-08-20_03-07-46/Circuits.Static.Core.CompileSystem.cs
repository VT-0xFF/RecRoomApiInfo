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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x20187D0", Offset = "0x20177D0", VA = "0x1820187D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87C700", Offset = "0x87B700", VA = "0x18087C700")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C740", Offset = "0x87B740", VA = "0x18087C740")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct KKGMKACNGAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> NNEEKJPJBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int IEOGBNCKHJD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xD41330", Offset = "0xD40330", VA = "0x180D41330")]
	public KKGMKACNGAK(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> HKCMDFBNFFA, int BEMLKOBANDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct JCBIKNGFNMG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class MNHJLNLBGHD : MOBHFBLJNFP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct ABCOAMBIACF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly LCPFLDCEIMC<byte> FHMKJFFONJO;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1FCC420", Offset = "0x1FCB420", VA = "0x181FCC420")]
		public ABCOAMBIACF(LCPFLDCEIMC<byte> KABOAHAAMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x200EE50", Offset = "0x200DE50", VA = "0x18200EE50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class NPKIOKFGLOD : MOBHFBLJNFP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct OHCLDFFHNGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> FDAGJELLAAE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
		public OHCLDFFHNGO(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> GAMFEBONLKJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum EDJEPNOAJKL
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
	public sealed class EAGHCMIEFAN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class MOBHFBLJNFP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct FEPGBKENLCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly EDJEPNOAJKL NFJFOGEPKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly BGKDPCAKPBJ<MOBHFBLJNFP> PACHMFDJHMF;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xD41330", Offset = "0xD40330", VA = "0x180D41330")]
		public FEPGBKENLCM(EDJEPNOAJKL PINHPAGBMLC, BGKDPCAKPBJ<MOBHFBLJNFP> MJFOMEFMEJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class NHABAIAILAH : MOBHFBLJNFP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct CKNIIPLLOEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DBOJJOKKILP;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
		public CKNIIPLLOEB(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> OEFFHPLBKNB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class CPEIPPHMDKN : MOBHFBLJNFP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct KEJPNNADMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly KMHLEJADADA JFOFGHJOPML;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
		public KEJPNNADMGK(KMHLEJADADA LOABGNNCIDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2017390", Offset = "0x2016390", VA = "0x182017390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal ANJEOAICFDN<EAGHCMIEFAN, FEPGBKENLCM> LKCMKDOAEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal ANJEOAICFDN<MNHJLNLBGHD, ABCOAMBIACF> AMEKFLBMCGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal ANJEOAICFDN<NPKIOKFGLOD, OHCLDFFHNGO> DHPMINHMNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal ANJEOAICFDN<NHABAIAILAH, CKNIIPLLOEB> EDECAGDGHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal ANJEOAICFDN<CPEIPPHMDKN, KEJPNNADMGK> FHOICOHDBGF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2017250", Offset = "0x2016250", VA = "0x182017250")]
	private JCBIKNGFNMG([In] ANJEOAICFDN<EAGHCMIEFAN, FEPGBKENLCM> MMKPJGDLGFB, [In] ANJEOAICFDN<MNHJLNLBGHD, ABCOAMBIACF> MDIDKKELFDM, [In] ANJEOAICFDN<NPKIOKFGLOD, OHCLDFFHNGO> AOCBHMICDAP, [In] ANJEOAICFDN<NHABAIAILAH, CKNIIPLLOEB> IIFNDEFGEDH, [In] ANJEOAICFDN<CPEIPPHMDKN, KEJPNNADMGK> KCDDOLFCDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2017110", Offset = "0x2016110", VA = "0x182017110")]
	public static JCBIKNGFNMG GAKCNKPJGEK()
	{
		return default(JCBIKNGFNMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class ELBPJPAHKGL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2016B60", Offset = "0x2015B60", VA = "0x182016B60")]
	public static void CANECBKHGDE(this JCBIKNGFNMG KALCJEIICGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum NGPJIGGIEIC
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
public struct PMEGHHCPDLK
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class DNCCMHKHEJO : GBFODIMCOEO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ANOGOCBECOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> CFLCEHMHAAC;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
		public ANOGOCBECOP(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NPELKMFBNAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum LGOAINJLCEK
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
	public sealed class IBHGIMIKCGH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class GBFODIMCOEO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct GFBOBCFCGGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly LGOAINJLCEK NFJFOGEPKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly BGKDPCAKPBJ<GBFODIMCOEO> PACHMFDJHMF;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xD41330", Offset = "0xD40330", VA = "0x180D41330")]
		public GFBOBCFCGGM(LGOAINJLCEK PINHPAGBMLC, BGKDPCAKPBJ<GBFODIMCOEO> MJFOMEFMEJH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal ANJEOAICFDN<IBHGIMIKCGH, GFBOBCFCGGM> LKCMKDOAEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal ANJEOAICFDN<DNCCMHKHEJO, ANOGOCBECOP> PGGBFGODPOJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2016E80", Offset = "0x2015E80", VA = "0x182016E80")]
	private PMEGHHCPDLK([In] ANJEOAICFDN<IBHGIMIKCGH, GFBOBCFCGGM> MMKPJGDLGFB, [In] ANJEOAICFDN<DNCCMHKHEJO, ANOGOCBECOP> AGNBMHFDFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2019E90", Offset = "0x2018E90", VA = "0x182019E90")]
	public static PMEGHHCPDLK GAKCNKPJGEK()
	{
		return default(PMEGHHCPDLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class PKPCNOCPPEN
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2019E30", Offset = "0x2018E30", VA = "0x182019E30")]
	public static void CANECBKHGDE(this PMEGHHCPDLK KALCJEIICGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct OKOAJJNBGIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public PPKMBIHDAAO<int> DLDPJPGBCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public PPKMBIHDAAO<int> NFHNENHBPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int MMLCOPLHFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int EIAPILIOODG;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2018DE0", Offset = "0x2017DE0", VA = "0x182018DE0")]
	private OKOAJJNBGIH([In] PPKMBIHDAAO<int> ILLMGIGAIBB, [In] PPKMBIHDAAO<int> JOLAIFOEFDL, int DAGIBOLPAMC, int GGEGFGBGEPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2018D40", Offset = "0x2017D40", VA = "0x182018D40")]
	public static OKOAJJNBGIH GAKCNKPJGEK()
	{
		return default(OKOAJJNBGIH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class LBCAHBGJDIF
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2017610", Offset = "0x2016610", VA = "0x182017610")]
	public static void CANECBKHGDE(this OKOAJJNBGIH KALCJEIICGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct OFEFBDEEECH
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum EEBFMEHHFDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class ELOEKHCOFLK : ACMOLNKPEGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct BIFFNBGPGJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly BGKDPCAKPBJ<DOOFFEGBPFG> DDCJBLHDJAG;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
		public BIFFNBGPGJL(BGKDPCAKPBJ<DOOFFEGBPFG> OJAGLHLCGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class MPNIPPAOPNE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class ACMOLNKPEGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct HIADDAFLCPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly EEBFMEHHFDO NFJFOGEPKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly BGKDPCAKPBJ<ACMOLNKPEGP> PACHMFDJHMF;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD41330", Offset = "0xD40330", VA = "0x180D41330")]
		private HIADDAFLCPK(EEBFMEHHFDO PINHPAGBMLC, BGKDPCAKPBJ<ACMOLNKPEGP> MJFOMEFMEJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2016EC0", Offset = "0x2015EC0", VA = "0x182016EC0")]
		public static HIADDAFLCPK GAKCNKPJGEK(EEBFMEHHFDO PINHPAGBMLC, BGKDPCAKPBJ<ACMOLNKPEGP> MJFOMEFMEJH)
		{
			return default(HIADDAFLCPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class FIHONAIAGKN : ACMOLNKPEGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct OKKCOGJNHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly BGKDPCAKPBJ<DOOFFEGBPFG> DDCJBLHDJAG;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
		public OKKCOGJNHML(BGKDPCAKPBJ<DOOFFEGBPFG> OJAGLHLCGCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class DOOFFEGBPFG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct FBOCNIMDJKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PPKMBIHDAAO<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> IGHDMELPFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public PPKMBIHDAAO<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> ECIGNHGKPNN;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2016E80", Offset = "0x2015E80", VA = "0x182016E80")]
		private FBOCNIMDJKG([In] PPKMBIHDAAO<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> MDDNIKGJOEN, [In] PPKMBIHDAAO<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> MIFMKBBDIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2016E00", Offset = "0x2015E00", VA = "0x182016E00")]
		public static FBOCNIMDJKG GAKCNKPJGEK()
		{
			return default(FBOCNIMDJKG);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal ANJEOAICFDN<MPNIPPAOPNE, HIADDAFLCPK> LKCMKDOAEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal ANJEOAICFDN<FIHONAIAGKN, OKKCOGJNHML> PNIODLILHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal ANJEOAICFDN<ELOEKHCOFLK, BIFFNBGPGJL> KHGBKFHNOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal PPKMBIHDAAO<(BGKDPCAKPBJ<MPNIPPAOPNE> CallId, BGKDPCAKPBJ<DOOFFEGBPFG> IOId)> EDJBDKMAAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal ANJEOAICFDN<DOOFFEGBPFG, FBOCNIMDJKG> BALCBOKHHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal CGKMNIMGDBN<DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>> DPKNCNPHMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal CGKMNIMGDBN<DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>> CLCEHKLCJGH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2018AA0", Offset = "0x2017AA0", VA = "0x182018AA0")]
	private OFEFBDEEECH([In] ANJEOAICFDN<MPNIPPAOPNE, HIADDAFLCPK> MMKPJGDLGFB, [In] ANJEOAICFDN<FIHONAIAGKN, OKKCOGJNHML> KCANHMEHIJD, [In] ANJEOAICFDN<ELOEKHCOFLK, BIFFNBGPGJL> KFCCPENMJNH, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<MPNIPPAOPNE> CallId, BGKDPCAKPBJ<DOOFFEGBPFG> IOId)> KODLHMBGKLK, [In] ANJEOAICFDN<DOOFFEGBPFG, FBOCNIMDJKG> IJFLLDIKLGG, [In] CGKMNIMGDBN<DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>> IKBGBENHOIM, [In] CGKMNIMGDBN<DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>> CKJCCKGCHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2018900", Offset = "0x2017900", VA = "0x182018900")]
	public static OFEFBDEEECH GAKCNKPJGEK()
	{
		return default(OFEFBDEEECH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class KPGHGKOMGLC
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x20173B0", Offset = "0x20163B0", VA = "0x1820173B0")]
	private static void CANECBKHGDE(this OFEFBDEEECH.FBOCNIMDJKG KALCJEIICGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2017400", Offset = "0x2016400", VA = "0x182017400")]
	public static void CANECBKHGDE(this OFEFBDEEECH KALCJEIICGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct PCBCHGMLJHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public PPKMBIHDAAO<byte> IMCAACNPHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal OFEFBDEEECH FOOLIFCJMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal CLJFPLFLHBJ CBMHLFFCKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> DNJKOJBNCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal JCBIKNGFNMG FKOEGIJFCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal PMEGHHCPDLK DMKJACCMIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal CGKMNIMGDBN<LMEADFHGDCP, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>?> GMEJMDIEMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal PPKMBIHDAAO<BGKDPCAKPBJ<LMEADFHGDCP>> FOBIFMEGONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?> KJDKGNPPBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> VariableId, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>> ByteCodeWriteLocation)> BOMEMLHNHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ALHAGLEKOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal LCNKACHDDND JGLAFCHJNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal LCIJCIIEJHM ELAJMAOONCC;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2019AD0", Offset = "0x2018AD0", VA = "0x182019AD0")]
	private PCBCHGMLJHL([In] PPKMBIHDAAO<byte> FOIOOGAIGCE, [In] OFEFBDEEECH HDOAJLEKIBA, [In] CLJFPLFLHBJ GGNICOCCKPL, [In] JCBIKNGFNMG LHPOIBEOHMK, [In] PMEGHHCPDLK HMGBJADHEFP, [In] CGKMNIMGDBN<LMEADFHGDCP, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>?> OKIAPDKIBMA, [In] PPKMBIHDAAO<BGKDPCAKPBJ<LMEADFHGDCP>> IKFNAMCKIML, [In] CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?> BNFMPPOICKN, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> VariableId, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>> ByteCodeWriteLocation)> CPJHMEEJPBK, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> BEMONMIGBHF, [In] LCNKACHDDND OIJIKJMKJIK, [In] LCIJCIIEJHM DLEHJOEHCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2019010", Offset = "0x2018010", VA = "0x182019010")]
	public static PCBCHGMLJHL GAKCNKPJGEK()
	{
		return default(PCBCHGMLJHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class ALLDLCFIDJH
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct MEAGGCLOLBH : LAIGFOMMBBA<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>, CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2017B40", Offset = "0x2016B40", VA = "0x182017B40")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2017B00", Offset = "0x2016B00", VA = "0x182017B00", Slot = "4")]
		public BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> DOIPLPKEDNC(int HCALFJOJKJO)
		{
			return default(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0")]
		public bool DBHPNIDCGJM(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "5")]
		private bool JHBJECNJAJJ(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2017B30", Offset = "0x2016B30", VA = "0x182017B30", Slot = "6")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> LCBCHLMDPPG(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct NGKGGBBDBNP : HDEKLHBDBOE<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>, CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x20183B0", Offset = "0x20173B0", VA = "0x1820183B0")]
		public PPKMBIHDAAO<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>> APCOFOLNGAF(int IHFNMDOGMLO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x20184E0", Offset = "0x20174E0", VA = "0x1820184E0")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2018420", Offset = "0x2017420", VA = "0x182018420", Slot = "6")]
		public void DDHLDELELIH(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>> ADLAOOMHAPB, BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x20183B0", Offset = "0x20173B0", VA = "0x1820183B0", Slot = "4")]
		private PPKMBIHDAAO<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>> LLLCHDHAGDM(int IHFNMDOGMLO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2018590", Offset = "0x2017590", VA = "0x182018590", Slot = "5")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> NOAPJDHIHLK(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct OHKBOBDFPGJ : LAIGFOMMBBA<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>, CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2018BD0", Offset = "0x2017BD0", VA = "0x182018BD0")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2018BA0", Offset = "0x2017BA0", VA = "0x182018BA0", Slot = "4")]
		public BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> DOIPLPKEDNC(int HCALFJOJKJO)
		{
			return default(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0")]
		public bool DBHPNIDCGJM(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "5")]
		private bool FAFOBHBFGIG(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2018C80", Offset = "0x2017C80", VA = "0x182018C80", Slot = "6")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> PDOHKMPFBNK(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct EOJIFJCLJLC : HDEKLHBDBOE<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>, CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2016C20", Offset = "0x2015C20", VA = "0x182016C20")]
		public PPKMBIHDAAO<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>> APCOFOLNGAF(int IHFNMDOGMLO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2016D50", Offset = "0x2015D50", VA = "0x182016D50")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2016C90", Offset = "0x2015C90", VA = "0x182016C90", Slot = "6")]
		public void DDHLDELELIH(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>> ADLAOOMHAPB, BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2016C20", Offset = "0x2015C20", VA = "0x182016C20", Slot = "4")]
		private PPKMBIHDAAO<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>> JNGBDBCFECN(int IHFNMDOGMLO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2016C10", Offset = "0x2015C10", VA = "0x182016C10", Slot = "5")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> AFJKKBJAIJP(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> HCALFJOJKJO, [In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct HLFGGJDJKHJ : LAIGFOMMBBA<BGKDPCAKPBJ<BLEKLEBBJEP>, CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2016F80", Offset = "0x2015F80", VA = "0x182016F80")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(BGKDPCAKPBJ<BLEKLEBBJEP> HCALFJOJKJO, [In] CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2016F50", Offset = "0x2015F50", VA = "0x182016F50", Slot = "4")]
		public BGKDPCAKPBJ<BLEKLEBBJEP> DOIPLPKEDNC(int HCALFJOJKJO)
		{
			return default(BGKDPCAKPBJ<BLEKLEBBJEP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2016EE0", Offset = "0x2015EE0", VA = "0x182016EE0")]
		public bool DBHPNIDCGJM(BGKDPCAKPBJ<BLEKLEBBJEP> HCALFJOJKJO, [In] CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2016EE0", Offset = "0x2015EE0", VA = "0x182016EE0", Slot = "5")]
		private bool DFPABIFBIGG(BGKDPCAKPBJ<BLEKLEBBJEP> HCALFJOJKJO, [In] CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2016ED0", Offset = "0x2015ED0", VA = "0x182016ED0", Slot = "6")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> ADBIOLGFBCA(BGKDPCAKPBJ<BLEKLEBBJEP> HCALFJOJKJO, [In] CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct MMODBNLIJGA : HDEKLHBDBOE<BGKDPCAKPBJ<BLEKLEBBJEP>, CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2018020", Offset = "0x2017020", VA = "0x182018020")]
		public PPKMBIHDAAO<BGKDPCAKPBJ<BLEKLEBBJEP>> APCOFOLNGAF(int IHFNMDOGMLO, [In] CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<BGKDPCAKPBJ<BLEKLEBBJEP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2018170", Offset = "0x2017170", VA = "0x182018170")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(BGKDPCAKPBJ<BLEKLEBBJEP> HCALFJOJKJO, [In] CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2018090", Offset = "0x2017090", VA = "0x182018090", Slot = "6")]
		public void DDHLDELELIH(BGKDPCAKPBJ<BLEKLEBBJEP> HCALFJOJKJO, CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?> ADLAOOMHAPB, BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2018020", Offset = "0x2017020", VA = "0x182018020", Slot = "4")]
		private PPKMBIHDAAO<BGKDPCAKPBJ<BLEKLEBBJEP>> OJJCALEKKNB(int IHFNMDOGMLO, [In] CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<BGKDPCAKPBJ<BLEKLEBBJEP>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2018240", Offset = "0x2017240", VA = "0x182018240", Slot = "5")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> PCJNHNGCLNK(BGKDPCAKPBJ<BLEKLEBBJEP> HCALFJOJKJO, [In] CGKMNIMGDBN<BLEKLEBBJEP, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>?> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct OANOBCKIBDB : LAIGFOMMBBA<int, PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2018860", Offset = "0x2017860", VA = "0x182018860")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> VariableId, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1484220", Offset = "0x1483220", VA = "0x181484220", Slot = "4")]
		public int DOIPLPKEDNC(int HCALFJOJKJO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0")]
		public bool DBHPNIDCGJM(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> VariableId, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "5")]
		private bool JDHFIGJMAOP(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> VariableId, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2018850", Offset = "0x2017850", VA = "0x182018850", Slot = "6")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> DJHNOMKAFJF(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> VariableId, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct NMDELDGNBOC : HDEKLHBDBOE<int, PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x20185A0", Offset = "0x20175A0", VA = "0x1820185A0")]
		public PPKMBIHDAAO<int> APCOFOLNGAF(int IHFNMDOGMLO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> VariableId, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2018720", Offset = "0x2017720", VA = "0x182018720")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> VariableId, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2018610", Offset = "0x2017610", VA = "0x182018610", Slot = "6")]
		public void DDHLDELELIH(int HCALFJOJKJO, PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> VariableId, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>> ByteCodeWriteLocation)> ADLAOOMHAPB, BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x20185A0", Offset = "0x20175A0", VA = "0x1820185A0", Slot = "4")]
		private PPKMBIHDAAO<int> LDOJAEMHOEM(int IHFNMDOGMLO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> VariableId, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2018710", Offset = "0x2017710", VA = "0x182018710", Slot = "5")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> LPOBFAICOFM(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> VariableId, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<GDEICLOHDHO>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct OJGNAMOIIFG : LAIGFOMMBBA<int, PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2018CA0", Offset = "0x2017CA0", VA = "0x182018CA0")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1484220", Offset = "0x1483220", VA = "0x181484220", Slot = "4")]
		public int DOIPLPKEDNC(int HCALFJOJKJO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0")]
		public bool DBHPNIDCGJM(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "5")]
		private bool IEFDCGIOJLN(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2018C90", Offset = "0x2017C90", VA = "0x182018C90", Slot = "6")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> LFBIPDNGADL(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct MEHNCLPDFBD : HDEKLHBDBOE<int, PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2017C00", Offset = "0x2016C00", VA = "0x182017C00")]
		public PPKMBIHDAAO<int> APCOFOLNGAF(int IHFNMDOGMLO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2017D60", Offset = "0x2016D60", VA = "0x182017D60")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2017C70", Offset = "0x2016C70", VA = "0x182017C70", Slot = "6")]
		public void DDHLDELELIH(int HCALFJOJKJO, PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB, BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2017C00", Offset = "0x2016C00", VA = "0x182017C00", Slot = "4")]
		private PPKMBIHDAAO<int> GGMGBHKGPNP(int IHFNMDOGMLO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2017BF0", Offset = "0x2016BF0", VA = "0x182017BF0", Slot = "5")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> ABPPFAJHGDH(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct LMGIJKDEHCO : LAIGFOMMBBA<int, PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2017A60", Offset = "0x2016A60", VA = "0x182017A60")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1484220", Offset = "0x1483220", VA = "0x181484220", Slot = "4")]
		public int DOIPLPKEDNC(int HCALFJOJKJO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0")]
		public bool DBHPNIDCGJM(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x86C5D0", Offset = "0x86B5D0", VA = "0x18086C5D0", Slot = "5")]
		private bool IEFDCGIOJLN(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2017A50", Offset = "0x2016A50", VA = "0x182017A50", Slot = "6")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> LFBIPDNGADL(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct MJHAJAMHFPE : HDEKLHBDBOE<int, PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2017E10", Offset = "0x2016E10", VA = "0x182017E10")]
		public PPKMBIHDAAO<int> APCOFOLNGAF(int IHFNMDOGMLO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2017F80", Offset = "0x2016F80", VA = "0x182017F80")]
		public BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2017E80", Offset = "0x2016E80", VA = "0x182017E80", Slot = "6")]
		public void DDHLDELELIH(int HCALFJOJKJO, PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB, BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2017E10", Offset = "0x2016E10", VA = "0x182017E10", Slot = "4")]
		private PPKMBIHDAAO<int> GGMGBHKGPNP(int IHFNMDOGMLO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(PPKMBIHDAAO<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2017E00", Offset = "0x2016E00", VA = "0x182017E00", Slot = "5")]
		private BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> ABPPFAJHGDH(int HCALFJOJKJO, [In] PPKMBIHDAAO<(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> Target, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ByteCodeWriteLocation)> ADLAOOMHAPB)
		{
			return default(BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct LBHMHHCDACA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> HNPIAFBBOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool ADDLIPKFAMP;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x129B3E0", Offset = "0x129A3E0", VA = "0x18129B3E0")]
		public LBHMHHCDACA(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ, bool JHKEHMGKAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2017660", Offset = "0x2016660", VA = "0x182017660")]
		public void JNNCHEFJEMI([Out] BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ, [Out] bool JHKEHMGKAKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct OFHGOEPHAKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly BGKDPCAKPBJ<BLEKLEBBJEP> FBBJKDCNDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> HNPIAFBBOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool ADDLIPKFAMP;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2018B90", Offset = "0x2017B90", VA = "0x182018B90")]
		public OFHGOEPHAKK(BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ, bool JHKEHMGKAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2018B60", Offset = "0x2017B60", VA = "0x182018B60")]
		public void JNNCHEFJEMI([Out] BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ, [Out] bool JHKEHMGKAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2018B70", Offset = "0x2017B70", VA = "0x182018B70")]
		public void JNNCHEFJEMI([Out] BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ, [Out] BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL, [Out] bool JHKEHMGKAKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct NMMHKEOGAOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly BGKDPCAKPBJ<BLEKLEBBJEP> FBBJKDCNDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> HNPIAFBBOPF;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xD41330", Offset = "0xD40330", VA = "0x180D41330")]
		public NMMHKEOGAOA(BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x20187C0", Offset = "0x20177C0", VA = "0x1820187C0")]
		public void JNNCHEFJEMI([Out] BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ, [Out] BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2014620", Offset = "0x2013620", VA = "0x182014620")]
	public static void CANECBKHGDE(this PCBCHGMLJHL KALCJEIICGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2016150", Offset = "0x2015150", VA = "0x182016150")]
	public static void MPBEAKACPOJ(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<LMEADFHGDCP> GPBEODKKKPJ, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NABHEBFIIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x20144D0", Offset = "0x20134D0", VA = "0x1820144D0")]
	public static void BAIMNOAGJEB(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<LMEADFHGDCP> GPBEODKKKPJ, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NABHEBFIIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2015300", Offset = "0x2014300", VA = "0x182015300")]
	public static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>? FCDLGFBKOJP([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<LMEADFHGDCP> GPBEODKKKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2015BE0", Offset = "0x2014BE0", VA = "0x182015BE0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> LDHCDGNBMGJ([In] this PCBCHGMLJHL KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2014210", Offset = "0x2013210", VA = "0x182014210")]
	private static void AJKPFEFBMFM(this PCBCHGMLJHL KALCJEIICGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2015E00", Offset = "0x2014E00", VA = "0x182015E00")]
	private static BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>? MFAFLGBDCDI([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2015EF0", Offset = "0x2014EF0", VA = "0x182015EF0")]
	public static void MNPEHJHCAGF(this PCBCHGMLJHL KALCJEIICGB, [In] PPKMBIHDAAO<KKGMKACNGAK> JAKNEFBDHIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2014E70", Offset = "0x2013E70", VA = "0x182014E70")]
	public static JCBIKNGFNMG.EDJEPNOAJKL DNDMHFKFFJK([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ)
	{
		return default(JCBIKNGFNMG.EDJEPNOAJKL);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x20148F0", Offset = "0x20138F0", VA = "0x1820148F0")]
	public static LCPFLDCEIMC<byte> CKJPCKFEJLA([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ)
	{
		return default(LCPFLDCEIMC<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2014EF0", Offset = "0x2013EF0", VA = "0x182014EF0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DPCLGMPPPBN([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2016060", Offset = "0x2015060", VA = "0x182016060")]
	public static KMHLEJADADA MOIBEHNACBM([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ)
	{
		return default(KMHLEJADADA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x326D5F0", Offset = "0x326C5F0", VA = "0x18326D5F0")]
	private static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> HMMOGMJJFDN<TMJoin>(this PCBCHGMLJHL KALCJEIICGB, JCBIKNGFNMG.EDJEPNOAJKL PINHPAGBMLC, BGKDPCAKPBJ<TMJoin> MJFOMEFMEJH) where TMJoin : JCBIKNGFNMG.MOBHFBLJNFP
	{
		return default(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2014190", Offset = "0x2013190", VA = "0x182014190")]
	public static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> AIJJGBBACPA(this PCBCHGMLJHL KALCJEIICGB, bool GHHJNDDMPAE)
	{
		return default(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x20149E0", Offset = "0x20139E0", VA = "0x1820149E0")]
	public static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> CKNLAGNEBFD(this PCBCHGMLJHL KALCJEIICGB, LCPFLDCEIMC<byte> KABOAHAAMFF)
	{
		return default(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2015280", Offset = "0x2014280", VA = "0x182015280")]
	public static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> EPFDFMFENGM(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> GAMFEBONLKJ)
	{
		return default(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x20159F0", Offset = "0x20149F0", VA = "0x1820159F0")]
	public static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> IJMNNECLAPB(this PCBCHGMLJHL KALCJEIICGB, int ADADDONMMNK)
	{
		return default(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x20150D0", Offset = "0x20140D0", VA = "0x1820150D0")]
	public static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> EHMIPFHEPBO(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> OEFFHPLBKNB)
	{
		return default(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x326D6A0", Offset = "0x326C6A0", VA = "0x18326D6A0")]
	private static BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH> IILGLIMLHBD<TMJoin>(this PCBCHGMLJHL KALCJEIICGB, PMEGHHCPDLK.LGOAINJLCEK PINHPAGBMLC, BGKDPCAKPBJ<TMJoin> MJFOMEFMEJH) where TMJoin : PMEGHHCPDLK.GBFODIMCOEO
	{
		return default(BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2015150", Offset = "0x2014150", VA = "0x182015150")]
	public static BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH> EJHBFLBIBFM(this PCBCHGMLJHL KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2015AF0", Offset = "0x2014AF0", VA = "0x182015AF0")]
	public static BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH> KGHBKNCECHF(this PCBCHGMLJHL KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2014D80", Offset = "0x2013D80", VA = "0x182014D80")]
	public static BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH> DGMLFHFMKLK(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NPELKMFBNAD)
	{
		return default(BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2015760", Offset = "0x2014760", VA = "0x182015760")]
	public static BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH> GOBMLDNPDJO(this PCBCHGMLJHL KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x20156B0", Offset = "0x20146B0", VA = "0x1820156B0")]
	public static BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH> GGAJKEJABNM(this PCBCHGMLJHL KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2016720", Offset = "0x2015720", VA = "0x182016720")]
	public static OFEFBDEEECH.EEBFMEHHFDO PEJBNBMODHG([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE> JOBBFNLMLNK)
	{
		return default(OFEFBDEEECH.EEBFMEHHFDO);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2015EB0", Offset = "0x2014EB0", VA = "0x182015EB0")]
	public static HLFHEBCGJHL<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>, COODDOCJCKN<OFEFBDEEECH.DOOFFEGBPFG>> MKKMBDCMLFB([In] this PCBCHGMLJHL KALCJEIICGB)
	{
		return default(HLFHEBCGJHL<BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>, COODDOCJCKN<OFEFBDEEECH.DOOFFEGBPFG>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2014A70", Offset = "0x2013A70", VA = "0x182014A70")]
	public static BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> DALFFOBOPHO([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE> JOBBFNLMLNK)
	{
		return default(BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2015A70", Offset = "0x2014A70", VA = "0x182015A70")]
	public static OFEFBDEEECH.FBOCNIMDJKG KCJNHNDNPBE([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> OJAGLHLCGCI)
	{
		return default(OFEFBDEEECH.FBOCNIMDJKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x20145A0", Offset = "0x20135A0", VA = "0x1820145A0")]
	public static OFEFBDEEECH.FBOCNIMDJKG BGBBHANJBKD(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> OJAGLHLCGCI)
	{
		return default(OFEFBDEEECH.FBOCNIMDJKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x326E150", Offset = "0x326D150", VA = "0x18326E150")]
	private static BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE> NEGIADFJGKK<TMJoin>(this PCBCHGMLJHL KALCJEIICGB, OFEFBDEEECH.EEBFMEHHFDO PINHPAGBMLC, BGKDPCAKPBJ<TMJoin> MJFOMEFMEJH) where TMJoin : OFEFBDEEECH.ACMOLNKPEGP
	{
		return default(BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2016370", Offset = "0x2015370", VA = "0x182016370")]
	public static (BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>) NBFFNMCBOKK(this PCBCHGMLJHL KALCJEIICGB)
	{
		return default((BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2015C40", Offset = "0x2014C40", VA = "0x182015C40")]
	public static (BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>) LLMNGHIEMED(this PCBCHGMLJHL KALCJEIICGB)
	{
		return default((BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2014150", Offset = "0x2013150", VA = "0x182014150")]
	public static BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE> AIICAAJPEOI(this PCBCHGMLJHL KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2016540", Offset = "0x2015540", VA = "0x182016540")]
	public static void NCOEEEIBPMA(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG> OJAGLHLCGCI, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> CDDCKILBDCA, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>> LMDNLEBHCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x326C430", Offset = "0x326B430", VA = "0x18326C430")]
	public static LBHMHHCDACA CINPOGFFEIN<TDeps, TStateSys>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL) where TDeps : CMJIGCOCNKP<TStateSys>
	{
		return default(LBHMHHCDACA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x326D250", Offset = "0x326C250", VA = "0x18326D250")]
	public static OFHGOEPHAKK DPAGOHIJGOF<TDeps, TStateSys>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<PMIFAKHBGDE> GODNEBGANDJ, int MHMEGHMBDAL) where TDeps : CMJIGCOCNKP<TStateSys>
	{
		return default(OFHGOEPHAKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x326D750", Offset = "0x326C750", VA = "0x18326D750")]
	public static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>? ILCBDANIEKJ<TDeps, TStateSys>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<PMIFAKHBGDE> GODNEBGANDJ, [In] ReadOnlySpan<int> DEHBIJLIIOO, [In] Span<NMMHKEOGAOA> ALDFDCILHDI) where TDeps : CMJIGCOCNKP<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x326DB90", Offset = "0x326CB90", VA = "0x18326DB90")]
	public static BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH> KDDMJGHFFAO<TDeps, TStateSys>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<LMEADFHGDCP> GPBEODKKKPJ) where TDeps : CMJIGCOCNKP<TStateSys>
	{
		return default(BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2014FE0", Offset = "0x2013FE0", VA = "0x182014FE0")]
	public static CLJFPLFLHBJ.FBCIHMIJPEE EGNMMKDGJIH([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KHLDDJPHOBA)
	{
		return default(CLJFPLFLHBJ.FBCIHMIJPEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2015480", Offset = "0x2014480", VA = "0x182015480")]
	public static CLJFPLFLHBJ.AOCOJJGBHFB FIPBMMJKMNG([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KHLDDJPHOBA)
	{
		return default(CLJFPLFLHBJ.AOCOJJGBHFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2015190", Offset = "0x2014190", VA = "0x182015190")]
	public static CLJFPLFLHBJ.BJKFNNIPMDG EMMGOIKAHPD([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KHLDDJPHOBA)
	{
		return default(CLJFPLFLHBJ.BJKFNNIPMDG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x20161E0", Offset = "0x20151E0", VA = "0x1820161E0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> NAIPNEKALDA(this PCBCHGMLJHL KALCJEIICGB, int? KNDDKDBBOPN, string CKEJJGPNKGO)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2016630", Offset = "0x2015630", VA = "0x182016630")]
	public static CLJFPLFLHBJ.OPEJFLHDALF PCJFLDNHKHI([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KHLDDJPHOBA)
	{
		return default(CLJFPLFLHBJ.OPEJFLHDALF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2014E00", Offset = "0x2013E00", VA = "0x182014E00")]
	public static CLJFPLFLHBJ.KGJEGHDGDJD DHBAIAGIINF([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KHLDDJPHOBA)
	{
		return default(CLJFPLFLHBJ.KGJEGHDGDJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x20156F0", Offset = "0x20146F0", VA = "0x1820156F0")]
	public static int? GNIDJHLOJEJ([In] this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KHLDDJPHOBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x326D4F0", Offset = "0x326C4F0", VA = "0x18326D4F0")]
	private static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> GJENKBJGONN<TMJoin>(this PCBCHGMLJHL KALCJEIICGB, int? KNDDKDBBOPN, CLJFPLFLHBJ.KGJEGHDGDJD PINHPAGBMLC, BGKDPCAKPBJ<TMJoin> MJFOMEFMEJH) where TMJoin : CLJFPLFLHBJ.DCMEIKCIJGP
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2015B30", Offset = "0x2014B30", VA = "0x182015B30")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KNMAFJKNAIL(this PCBCHGMLJHL KALCJEIICGB, int? KNDDKDBBOPN, BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE> JOBBFNLMLNK, int HCALFJOJKJO)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2014D20", Offset = "0x2013D20", VA = "0x182014D20")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DGGEDDBGFJF(this PCBCHGMLJHL KALCJEIICGB, int? KNDDKDBBOPN)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2014380", Offset = "0x2013380", VA = "0x182014380")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> AOCJEKPDBLI(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>? MMNBHHAMMFK, int? KNDDKDBBOPN)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2015830", Offset = "0x2014830", VA = "0x182015830")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HHKFLKGJCCF(this PCBCHGMLJHL KALCJEIICGB, int? KNDDKDBBOPN, int HCALFJOJKJO)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x20165D0", Offset = "0x20155D0", VA = "0x1820165D0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> NNGMAHMHHLF(this PCBCHGMLJHL KALCJEIICGB, int? KNDDKDBBOPN)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2015570", Offset = "0x2014570", VA = "0x182015570")]
	public static void FPEIJIMIOMI(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> OEFFHPLBKNB, BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE> JOBBFNLMLNK, int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x20158C0", Offset = "0x20148C0", VA = "0x1820158C0")]
	public static void IFAODEAKHNK(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> OEFFHPLBKNB, int HCALFJOJKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2014C50", Offset = "0x2013C50", VA = "0x182014C50")]
	public static void DBPGBNKJDID(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> OEFFHPLBKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x20157A0", Offset = "0x20147A0", VA = "0x1820157A0")]
	public static void HALDMCKALNI(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> KAEDHDLBKFF, BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> BMPGIIDGLAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x20153B0", Offset = "0x20143B0", VA = "0x1820153B0")]
	public static void FGMMGBCMOMJ(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> OEFFHPLBKNB, BGKDPCAKPBJ<AOGIMHHCCDD<ABPHJLKIFOM>> NIKJOKHHDJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x326C360", Offset = "0x326B360", VA = "0x18326C360")]
	public static void AALDNLPJAMP<M>(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> OEFFHPLBKNB, BGKDPCAKPBJ<AOGIMHHCCDD<KKPCOHNODPC<M>>> NIKJOKHHDJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CMJIGCOCNKP<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BGKDPCAKPBJ<CABCPBKFDEH> ODLEDLPJAAM(TStateSys DLPKDOOIFFD);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BGKDPCAKPBJ<CABCPBKFDEH> NGBIAIAAGOJ(TStateSys DLPKDOOIFFD);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BGKDPCAKPBJ<CABCPBKFDEH> EOEOBPCLHDH(TStateSys DLPKDOOIFFD);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BGKDPCAKPBJ<CABCPBKFDEH> AHDPFKMBLHH(TStateSys DLPKDOOIFFD);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH> NCFLLCLIHLB(TStateSys DLPKDOOIFFD, PCBCHGMLJHL POOOFNNEGFG, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> AJBIMMOPFAB(TStateSys DLPKDOOIFFD, PCBCHGMLJHL POOOFNNEGFG, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<LMEADFHGDCP> GPBEODKKKPJ);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int FLMIPFJCFFG(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BGKDPCAKPBJ<LMEADFHGDCP> JNIMHBCIOPO(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL, int FCPCFFHNMNC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	NGPJIGGIEIC KEIBOHOKJNB(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NINEHCFIIJF(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int CJFDNCGPDLB(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LCPFLDCEIMC<byte> JEKFODFAEDH(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(LCPFLDCEIMC<byte>, BGKDPCAKPBJ<CABCPBKFDEH>) MIAPLKAJMMM(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<BLEKLEBBJEP> IMIBEIBKNDL);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int CADLEDNIGBM(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<LMEADFHGDCP> GPBEODKKKPJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	BGKDPCAKPBJ<BLEKLEBBJEP> NGFHGEOCIFJ(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<LMEADFHGDCP> GPBEODKKKPJ, int MHMEGHMBDAL);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	BGKDPCAKPBJ<BLEKLEBBJEP> KOIHOPAFMGC(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, BGKDPCAKPBJ<PMIFAKHBGDE> GODNEBGANDJ, int MHMEGHMBDAL);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int HHECIANNBHC(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? NBNNHLAIHLL(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, int HCALFJOJKJO);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int KKDJLJIBHMN(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? BGCLHAELFHD(TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD, int HCALFJOJKJO);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class AGMCFCINHEJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x32691E0", Offset = "0x32681E0", VA = "0x1832691E0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC?> PEFLCPGDJBO<T, TOpInput, TOpOutput>(this PCBCHGMLJHL KALCJEIICGB, T PNODNPKGJKB, T JHNJJGDAEGF, int CPAFKNCKEIH, IntPtr ELECLKGFGKN)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3267930", Offset = "0x3266930", VA = "0x183267930")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC?> GHGINBLKFPF<T, TOpInput, TOpOutput>(this PCBCHGMLJHL KALCJEIICGB, T PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF, int CPAFKNCKEIH, IntPtr ELECLKGFGKN)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x32677C0", Offset = "0x32667C0", VA = "0x1832677C0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC?> GDCFHPAPEDE<TOpInput, TOpOutput>(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF, int CPAFKNCKEIH, IntPtr ELECLKGFGKN)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2011970", Offset = "0x2010970", VA = "0x182011970")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HHEOGMANJPO(this PCBCHGMLJHL KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2013CE0", Offset = "0x2012CE0", VA = "0x182013CE0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PLHDHJGAEIN(this PCBCHGMLJHL KALCJEIICGB, float HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2013B20", Offset = "0x2012B20", VA = "0x182013B20")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PIOPBPKLGDM(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2011770", Offset = "0x2010770", VA = "0x182011770")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> GPFDCMCOMPA(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x200FD60", Offset = "0x200ED60", VA = "0x18200FD60")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DCCJDEHAHBG(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x20129A0", Offset = "0x20119A0", VA = "0x1820129A0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> LJONKLBFADD(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2014060", Offset = "0x2013060", VA = "0x182014060")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PONNBBIPAEM(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x200FF00", Offset = "0x200EF00", VA = "0x18200FF00")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DDICELNKGDL(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2011D00", Offset = "0x2010D00", VA = "0x182011D00")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JFJPEDFMLGF(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x20107F0", Offset = "0x200F7F0", VA = "0x1820107F0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> EPOHEEFFNGN(this PCBCHGMLJHL KALCJEIICGB, int PNODNPKGJKB, int JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2013900", Offset = "0x2012900", VA = "0x182013900")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PFAEDOBONHB(this PCBCHGMLJHL KALCJEIICGB, int PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x200F2A0", Offset = "0x200E2A0", VA = "0x18200F2A0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> BAOFAFBIEMC(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2010FB0", Offset = "0x200FFB0", VA = "0x182010FB0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> GGAJAJFJFOE(this PCBCHGMLJHL KALCJEIICGB, float PNODNPKGJKB, float JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x20133A0", Offset = "0x20123A0", VA = "0x1820133A0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> NCNMAKJACFK(this PCBCHGMLJHL KALCJEIICGB, float PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2013120", Offset = "0x2012120", VA = "0x182013120")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> MHLKJGEIAEE(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2010E10", Offset = "0x200FE10", VA = "0x182010E10")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> GAPPKGMDHGI(this PCBCHGMLJHL KALCJEIICGB, int PNODNPKGJKB, int JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x200FE80", Offset = "0x200EE80", VA = "0x18200FE80")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DCKOEFELMEB(this PCBCHGMLJHL KALCJEIICGB, int PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2010020", Offset = "0x200F020", VA = "0x182010020")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DJHFGGKLOGL(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2011FB0", Offset = "0x2010FB0", VA = "0x182011FB0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KNAGABKMFJE(this PCBCHGMLJHL KALCJEIICGB, float PNODNPKGJKB, float JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2013C60", Offset = "0x2012C60", VA = "0x182013C60")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PKPFFCKGLKP(this PCBCHGMLJHL KALCJEIICGB, float PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2010350", Offset = "0x200F350", VA = "0x182010350")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DOLDJGOGHOO(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2013880", Offset = "0x2012880", VA = "0x182013880")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PDAGDNCNAMA(this PCBCHGMLJHL KALCJEIICGB, int PNODNPKGJKB, int JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2010770", Offset = "0x200F770", VA = "0x182010770")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> EONNOOAGLIC(this PCBCHGMLJHL KALCJEIICGB, int PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x20101E0", Offset = "0x200F1E0", VA = "0x1820101E0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DMHJKEDGHCN(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x20106F0", Offset = "0x200F6F0", VA = "0x1820106F0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> ENOHGDOHFKP(this PCBCHGMLJHL KALCJEIICGB, float PNODNPKGJKB, float JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2010670", Offset = "0x200F670", VA = "0x182010670")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> EEFPKOOAJPD(this PCBCHGMLJHL KALCJEIICGB, float PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2011A70", Offset = "0x2010A70", VA = "0x182011A70")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HJNLEBCKAAM(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x200EEC0", Offset = "0x200DEC0", VA = "0x18200EEC0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> ABCADIKGMMH(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2012820", Offset = "0x2011820", VA = "0x182012820")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> LGFBNALFLAH(this PCBCHGMLJHL KALCJEIICGB, int JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2012AE0", Offset = "0x2011AE0", VA = "0x182012AE0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> LOKNGIKLPBJ(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x20104C0", Offset = "0x200F4C0", VA = "0x1820104C0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> EAICLAMFMKI(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NJFPLGCFMFJ)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x20108E0", Offset = "0x200F8E0", VA = "0x1820108E0")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> FABDDPMMFMB(this PCBCHGMLJHL KALCJEIICGB, int JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2012D80", Offset = "0x2011D80", VA = "0x182012D80")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> MFNLOGLELFF(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x20110B0", Offset = "0x20100B0", VA = "0x1820110B0")]
	public static (BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>) GHDKMMAOLDB(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<AJJHAIFHNDG> FLFDDBDODKJ, [In] ReadOnlySpan<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> MDDNIKGJOEN, [In] ReadOnlySpan<int?> AGGBDHILACL, [In] Span<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> BMKBKHJAKJD)
	{
		return default((BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x20122B0", Offset = "0x20112B0", VA = "0x1820122B0")]
	public static (BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>) LEIMHAAMCOK(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<HDAPBNILEED> NJMLJIOCKCL, [In] ReadOnlySpan<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> MDDNIKGJOEN, [In] ReadOnlySpan<int?> AGGBDHILACL, [In] Span<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> BMKBKHJAKJD)
	{
		return default((BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3267CC0", Offset = "0x3266CC0", VA = "0x183267CC0")]
	public static (BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<CABCPBKFDEH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<TMarker>>, BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>) IAFEBEEBMIJ<TMarker>(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CABCPBKFDEH> BGDEHBKJHGJ, [In] ReadOnlySpan<byte> AHGAPHMJDIB)
	{
		return default((BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<AOGIMHHCCDD<CABCPBKFDEH>>, BGKDPCAKPBJ<AOGIMHHCCDD<IDFFJOFDIGH>>, BGKDPCAKPBJ<AOGIMHHCCDD<TMarker>>, BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x20134D0", Offset = "0x20124D0", VA = "0x1820134D0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> NJECOIFLICE(this PCBCHGMLJHL KALCJEIICGB, int GOCEFODHDBO, [Optional] BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>? FICFNKLGBCA)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x20103D0", Offset = "0x200F3D0", VA = "0x1820103D0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DPHKCMNPDIJ(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> GOCEFODHDBO, [Optional] BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>? FICFNKLGBCA)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2010BE0", Offset = "0x200FBE0", VA = "0x182010BE0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> FNPNLEHCDMF(this PCBCHGMLJHL KALCJEIICGB, [In] ReadOnlySpan<byte> GOCEFODHDBO, [Optional] BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>? FICFNKLGBCA)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x200F860", Offset = "0x200E860", VA = "0x18200F860")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> BIMNNEFNNNN(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> GOCEFODHDBO, int GHACOABIHDA, [Optional] BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>? FICFNKLGBCA)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2013A20", Offset = "0x2012A20", VA = "0x182013A20")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PIOHGFFFEAP(this PCBCHGMLJHL KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2011650", Offset = "0x2010650", VA = "0x182011650")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> GMJNKICDHLK(this PCBCHGMLJHL KALCJEIICGB, float HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2012030", Offset = "0x2011030", VA = "0x182012030")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KPBCPHNEHJN(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2010260", Offset = "0x200F260", VA = "0x182010260")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DOGHANGMHHA(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x200FAA0", Offset = "0x200EAA0", VA = "0x18200FAA0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> CCPDCGAMJNJ(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2010CD0", Offset = "0x200FCD0", VA = "0x182010CD0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> GAPNKDIMPHO(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2011E40", Offset = "0x2010E40", VA = "0x182011E40")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEGBEHFEIFN(this PCBCHGMLJHL KALCJEIICGB, int PNODNPKGJKB, int JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x20137E0", Offset = "0x20127E0", VA = "0x1820137E0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PAGHHFMHAGC(this PCBCHGMLJHL KALCJEIICGB, int PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x200FCE0", Offset = "0x200ECE0", VA = "0x18200FCE0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> CMFKHFMKFOI(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PNODNPKGJKB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JHNJJGDAEGF)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2012720", Offset = "0x2011720", VA = "0x182012720")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> LFHMFNIDNCI(this PCBCHGMLJHL KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x20136B0", Offset = "0x20126B0", VA = "0x1820136B0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> ODAJCAMHILC(this PCBCHGMLJHL KALCJEIICGB, float HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x200F160", Offset = "0x200E160", VA = "0x18200F160")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> AKIGMMCJJND(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2011EC0", Offset = "0x2010EC0", VA = "0x182011EC0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KGBGOLJLKAD(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x200FBC0", Offset = "0x200EBC0", VA = "0x18200FBC0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> CKLPAHDFEJG(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2013260", Offset = "0x2012260", VA = "0x182013260")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> NCNEAHGLOHC(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2013860", Offset = "0x2012860", VA = "0x182013860")]
	public static BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>> PCJLECKDLKA(this PCBCHGMLJHL KALCJEIICGB)
	{
		return default(BGKDPCAKPBJ<AOGIMHHCCDD<AOGIMHHCCDD<JNDEJCCNEEG>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x20128A0", Offset = "0x20118A0", VA = "0x1820128A0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> LIMKJOPFMDM(this PCBCHGMLJHL KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2013590", Offset = "0x2012590", VA = "0x182013590")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> NJKIIHNGJJJ(this PCBCHGMLJHL KALCJEIICGB, float HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2012170", Offset = "0x2011170", VA = "0x182012170")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> LBHNKJGEAKN(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2011AF0", Offset = "0x2010AF0", VA = "0x182011AF0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HJPLKEIBMCH(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x200F980", Offset = "0x200E980", VA = "0x18200F980")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> BNFOCGLPDDO(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2010AA0", Offset = "0x200FAA0", VA = "0x182010AA0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> FNBJAOFNDNB(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2012B80", Offset = "0x2011B80", VA = "0x182012B80")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> MDOLLJBCJFH(this PCBCHGMLJHL KALCJEIICGB, int JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2011860", Offset = "0x2010860", VA = "0x182011860")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HAPAIELDAHJ(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> JJCEIJMGOAB)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2011640", Offset = "0x2010640", VA = "0x182011640")]
	public static void GMFBMKOFOLH(this PCBCHGMLJHL KALCJEIICGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2012C80", Offset = "0x2011C80", VA = "0x182012C80")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> MEPGLOBONKH(this PCBCHGMLJHL KALCJEIICGB, float HANNFMOCMEI, float KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2011BE0", Offset = "0x2010BE0", VA = "0x182011BE0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> ILGCIOJEJGB(this PCBCHGMLJHL KALCJEIICGB, float HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2010960", Offset = "0x200F960", VA = "0x182010960")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> FDGOCKCALAH(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x200F070", Offset = "0x200E070", VA = "0x18200F070")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> AGCJHJONEKM(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2013F40", Offset = "0x2012F40", VA = "0x182013F40")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PMKMIOFLBEK(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2013E00", Offset = "0x2012E00", VA = "0x182013E00")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> PMHNPFCFHME(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x200F3E0", Offset = "0x200E3E0", VA = "0x18200F3E0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> BDBPPKJDAPE(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NKGJMKLLBPH, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> KPBPPKKDFGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x200F770", Offset = "0x200E770", VA = "0x18200F770")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> BECJPNDGANH(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, int KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2010E90", Offset = "0x200FE90", VA = "0x182010E90")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> GCEIJDMLKHK(this PCBCHGMLJHL KALCJEIICGB, int HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x20100A0", Offset = "0x200F0A0", VA = "0x1820100A0")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> DJJFCDMNFJC(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> HANNFMOCMEI, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> KEOGPFNFIGD)
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3268560", Offset = "0x3267560", VA = "0x183268560")]
	public static void KAMLFKECBNB<TDeps, TState>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TState JKKAFCBPEPF, BGKDPCAKPBJ<AJJHAIFHNDG> FLFDDBDODKJ, [In] ReadOnlySpan<BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>> PIEJNGIJLIN, [In] ReadOnlySpan<int?> AGGBDHILACL, [In] Span<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> BMKBKHJAKJD, [In] Span<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> KLLMGAGFKPE, [In] ReadOnlySpan<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>?> JIBIJNOFOBD) where TDeps : notnull, CMJIGCOCNKP<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3267FD0", Offset = "0x3266FD0", VA = "0x183267FD0")]
	public static void JOALLACCCJN<TDeps, TState>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TState JKKAFCBPEPF, BGKDPCAKPBJ<HDAPBNILEED> BOJOFOCMOIF, [In] ReadOnlySpan<BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>> HNEDBCDDLFH, [In] ReadOnlySpan<int?> AGGBDHILACL, [In] Span<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> BMKBKHJAKJD, [In] Span<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>> KLLMGAGFKPE, [In] ReadOnlySpan<BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>?> JIBIJNOFOBD) where TDeps : notnull, CMJIGCOCNKP<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3267010", Offset = "0x3266010", VA = "0x183267010")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> BFFPFIBBDNG<TDeps, TState>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TState JKKAFCBPEPF, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> MMNBHHAMMFK, [Optional] BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>? FICFNKLGBCA) where TDeps : notnull, CMJIGCOCNKP<TState> where TState : notnull
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3268D80", Offset = "0x3267D80", VA = "0x183268D80")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> NBDLICMOGFP<TDeps, TState>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TState JKKAFCBPEPF, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NPELKMFBNAD, [Optional] BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>? FICFNKLGBCA) where TDeps : notnull, CMJIGCOCNKP<TState> where TState : notnull
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x32671F0", Offset = "0x32661F0", VA = "0x1832671F0")]
	public static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> CDDIOGPNHAD<TDeps, TStateSys>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TStateSys DLPKDOOIFFD) where TDeps : notnull, CMJIGCOCNKP<TStateSys> where TStateSys : notnull
	{
		return default(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3267DC0", Offset = "0x3266DC0", VA = "0x183267DC0")]
	public static BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH> IAFNPOADMAG<TDeps, TStateSys>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TStateSys DLPKDOOIFFD) where TDeps : notnull, CMJIGCOCNKP<TStateSys> where TStateSys : notnull
	{
		return default(BGKDPCAKPBJ<PMEGHHCPDLK.IBHGIMIKCGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2011510", Offset = "0x2010510", VA = "0x182011510")]
	public static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> GKMPINFPLJF(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> NLFKFJEOELI, IntPtr MDGABODFLGE, IntPtr IIHLGCJPPML)
	{
		return default(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2012E20", Offset = "0x2011E20", VA = "0x182012E20")]
	public static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> MHECCAFEADO(this PCBCHGMLJHL KALCJEIICGB, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> GBFANNMDHJD, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> IFOBOIJMDHD, IntPtr PPLIMIHBNKL, IntPtr KDMLLKBDFFP, IntPtr PIOLIIFLLOK, bool DABOCBDDOIK)
	{
		return default(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x32694E0", Offset = "0x32684E0", VA = "0x1832694E0")]
	public static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> PPCCBPDMDNG<TDeps, TState>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TState JKKAFCBPEPF, BGKDPCAKPBJ<AJJHAIFHNDG> KLJBPBJCBLJ, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> GBFANNMDHJD, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> IFOBOIJMDHD, int? IBBIMHMMKIB, [Optional] IntPtr ODLFOIPEIEA) where TDeps : notnull, CMJIGCOCNKP<TState> where TState : notnull
	{
		return default(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x32696E0", Offset = "0x32686E0", VA = "0x1832696E0")]
	private static BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> PPCCBPDMDNG<TDeps, TState>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TState JKKAFCBPEPF, BGKDPCAKPBJ<AJJHAIFHNDG> KLJBPBJCBLJ, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> GBFANNMDHJD, BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN> IFOBOIJMDHD, int? IBBIMHMMKIB) where TDeps : notnull, CMJIGCOCNKP<TState> where TState : notnull
	{
		return default(BGKDPCAKPBJ<JCBIKNGFNMG.EAGHCMIEFAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3267420", Offset = "0x3266420", VA = "0x183267420")]
	public static BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> FJMLAHJLJIM<TDeps, TState>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TState JKKAFCBPEPF, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC> GOCEFODHDBO, BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>? FICFNKLGBCA) where TDeps : notnull, CMJIGCOCNKP<TState> where TState : notnull
	{
		return default(BGKDPCAKPBJ<CLJFPLFLHBJ.OLJHKGKOBMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3268AF0", Offset = "0x3267AF0", VA = "0x183268AF0")]
	public static void MLDCEIICCEP<TDeps, TState>(this PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TState JKKAFCBPEPF, int MOJPFPDCILB) where TDeps : notnull, CMJIGCOCNKP<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct IMBENFKCAOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> ONDEDJAJOJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> GAKKHNINDDD;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xD41330", Offset = "0xD40330", VA = "0x180D41330")]
	public IMBENFKCAOL(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> MPOKHBJOJIA, BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> LEGJKFGJKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2017100", Offset = "0x2016100", VA = "0x182017100")]
	public static IMBENFKCAOL GAKCNKPJGEK(BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>> MPOKHBJOJIA)
	{
		return default(IMBENFKCAOL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct CLJFPLFLHBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class GPDACJLIMHO : DCMEIKCIJGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct FBCIHMIJPEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE> PNBBPFANHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int LCNJIFOOGIB;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xD41330", Offset = "0xD40330", VA = "0x180D41330")]
		public FBCIHMIJPEE(BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE> JOBBFNLMLNK, int HCALFJOJKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class EEGHLPMPPEP : DCMEIKCIJGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct AOCOJJGBHFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int LCNJIFOOGIB;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
		public AOCOJJGBHFB(int HCALFJOJKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class BADPFBMMHEJ : DCMEIKCIJGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct BJKFNNIPMDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE> PNBBPFANHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int LCNJIFOOGIB;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xD41330", Offset = "0xD40330", VA = "0x180D41330")]
		public BJKFNNIPMDG(BGKDPCAKPBJ<OFEFBDEEECH.MPNIPPAOPNE> JOBBFNLMLNK, int HCALFJOJKJO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum KGJEGHDGDJD
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
	public sealed class OLJHKGKOBMC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class DCMEIKCIJGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct DHOEOLEACNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? JEGHIJBOIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public IMBENFKCAOL MCBPKGDFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public KGJEGHDGDJD NFJFOGEPKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public BGKDPCAKPBJ<DCMEIKCIJGP> PACHMFDJHMF;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2016AC0", Offset = "0x2015AC0", VA = "0x182016AC0")]
		public DHOEOLEACNO(int? KNDDKDBBOPN, [In] IMBENFKCAOL BNHKAEKGGGJ, KGJEGHDGDJD PINHPAGBMLC, BGKDPCAKPBJ<DCMEIKCIJGP> MJFOMEFMEJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class MOPKNMLGMHP : DCMEIKCIJGP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct OPEJFLHDALF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int LCNJIFOOGIB;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB57260", Offset = "0xB56260", VA = "0x180B57260")]
		public OPEJFLHDALF(int HCALFJOJKJO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal PKCLCAGMMLE<OLJHKGKOBMC, DHOEOLEACNO> LKCMKDOAEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal PKCLCAGMMLE<GPDACJLIMHO, FBCIHMIJPEE> OOCMKLJLBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal PKCLCAGMMLE<BADPFBMMHEJ, BJKFNNIPMDG> EPODGGJEIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal PKCLCAGMMLE<MOPKNMLGMHP, OPEJFLHDALF> JDHCFOFKBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal PKCLCAGMMLE<EEGHLPMPPEP, AOCOJJGBHFB> DBDNFOMCDOG;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2016990", Offset = "0x2015990", VA = "0x182016990")]
	private CLJFPLFLHBJ([In] PKCLCAGMMLE<OLJHKGKOBMC, DHOEOLEACNO> MMKPJGDLGFB, [In] PKCLCAGMMLE<GPDACJLIMHO, FBCIHMIJPEE> BCMAEFFKJIF, [In] PKCLCAGMMLE<BADPFBMMHEJ, BJKFNNIPMDG> OBCPCFLGCIJ, [In] PKCLCAGMMLE<MOPKNMLGMHP, OPEJFLHDALF> BGLBLOOOCII, [In] PKCLCAGMMLE<EEGHLPMPPEP, AOCOJJGBHFB> LDEEAHKGGMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x20167A0", Offset = "0x20157A0", VA = "0x1820167A0")]
	public static CLJFPLFLHBJ GAKCNKPJGEK()
	{
		return default(CLJFPLFLHBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class IKDFNMDOAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2017050", Offset = "0x2016050", VA = "0x182017050")]
	public static void CANECBKHGDE(this CLJFPLFLHBJ KALCJEIICGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class NCAJAJBCKJH
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2018250", Offset = "0x2017250", VA = "0x182018250")]
	public static void PCBFBKDIPKL(PCBCHGMLJHL KALCJEIICGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct LCNKACHDDND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, OKOAJJNBGIH> JMHFHBKDIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int EGJAFFJNONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int IEGMIOGOBCH;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2017A10", Offset = "0x2016A10", VA = "0x182017A10")]
	private LCNKACHDDND([In] CGKMNIMGDBN<OFEFBDEEECH.DOOFFEGBPFG, OKOAJJNBGIH> BEBJCICMANG, int CFMKOCPGCIE, int DLANEMDFGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x20179A0", Offset = "0x20169A0", VA = "0x1820179A0")]
	public static LCNKACHDDND GAKCNKPJGEK()
	{
		return default(LCNKACHDDND);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x20177B0", Offset = "0x20167B0", VA = "0x1820177B0")]
	public void CANECBKHGDE([In] PCBCHGMLJHL IBLIIOCCPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x2C78BE0", Offset = "0x2C77BE0", VA = "0x182C78BE0")]
	public static void PCBFBKDIPKL<TDeps, TStateSys>(PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TStateSys DLPKDOOIFFD, BGKDPCAKPBJ<EHIJHEMDKLF> GFIFEILMJAD) where TDeps : notnull, CMJIGCOCNKP<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class PAJAGGCFALL
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2018E40", Offset = "0x2017E40", VA = "0x182018E40")]
	public static void PCBFBKDIPKL(PCBCHGMLJHL KALCJEIICGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct LCIJCIIEJHM
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface FONFKBHBEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PAAJLNDCFEI(PPKMBIHDAAO<byte> FOIOOGAIGCE, int GILOAJDBPDN);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct PPEIJDMGALL : FONFKBHBEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2019FD0", Offset = "0x2018FD0", VA = "0x182019FD0", Slot = "4")]
		public void PAAJLNDCFEI(PPKMBIHDAAO<byte> FOIOOGAIGCE, int GILOAJDBPDN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct KBIFCHBAHHF : FONFKBHBEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x20172E0", Offset = "0x20162E0", VA = "0x1820172E0", Slot = "4")]
		public void PAAJLNDCFEI(PPKMBIHDAAO<byte> FOIOOGAIGCE, int GILOAJDBPDN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct EEBDJMDLAFN : FONFKBHBEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2016AE0", Offset = "0x2015AE0", VA = "0x182016AE0", Slot = "4")]
		public void PAAJLNDCFEI(PPKMBIHDAAO<byte> FOIOOGAIGCE, int GILOAJDBPDN)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct PMHHBFKPHHG : FONFKBHBEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2019F20", Offset = "0x2018F20", VA = "0x182019F20", Slot = "4")]
		public void PAAJLNDCFEI(PPKMBIHDAAO<byte> FOIOOGAIGCE, int GILOAJDBPDN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class OCEGIFOFEOO<TCallProcessorDeps> where TCallProcessorDeps : struct, FONFKBHBEKI
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps OMOPLBNHPIH;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2C035B0", Offset = "0x2C025B0", VA = "0x182C035B0")]
		public static int PCBFBKDIPKL<TDeps, TStateSys>(TDeps HPGJLJLFPIH, TStateSys JKKAFCBPEPF, PCBCHGMLJHL IBLIIOCCPPC, [In] PPKMBIHDAAO<byte> JGBIPJNDLBD, int LIPIFNEJJJL) where TDeps : CMJIGCOCNKP<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private PPKMBIHDAAO<KKGMKACNGAK> KGFIILJMMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>> NAMAHNNLHID;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2017770", Offset = "0x2016770", VA = "0x182017770")]
	private LCIJCIIEJHM([In] PPKMBIHDAAO<KKGMKACNGAK> JAKNEFBDHIM, Dictionary<BGKDPCAKPBJ<AOGIMHHCCDD<JNDEJCCNEEG>>, BGKDPCAKPBJ<OFEFBDEEECH.DOOFFEGBPFG>> PJFOEOHAFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x20176B0", Offset = "0x20166B0", VA = "0x1820176B0")]
	public static LCIJCIIEJHM GAKCNKPJGEK()
	{
		return default(LCIJCIIEJHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2017670", Offset = "0x2016670", VA = "0x182017670")]
	public void CANECBKHGDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2C769D0", Offset = "0x2C759D0", VA = "0x182C769D0")]
	public static void PCBFBKDIPKL<TDeps, TStateSys>(PCBCHGMLJHL KALCJEIICGB, TDeps HPGJLJLFPIH, TStateSys DLPKDOOIFFD) where TDeps : CMJIGCOCNKP<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class CHJFHJIOJMK<TDeps, TIndex, TValues> where TDeps : struct, HDEKLHBDBOE<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps OMOPLBNHPIH;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x527FC90", Offset = "0x527EC90", VA = "0x18527FC90")]
	public static void PCBFBKDIPKL([In] PPKMBIHDAAO<KKGMKACNGAK> JAKNEFBDHIM, int IHFNMDOGMLO, TValues ADLAOOMHAPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface HDEKLHBDBOE<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PPKMBIHDAAO<TIndex> APCOFOLNGAF(int IHFNMDOGMLO, [In] TValues ADLAOOMHAPB);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(TIndex HCALFJOJKJO, [In] TValues ADLAOOMHAPB);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DDHLDELELIH(TIndex HCALFJOJKJO, TValues ADLAOOMHAPB, BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> JJCEIJMGOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface LAIGFOMMBBA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex DOIPLPKEDNC(int HCALFJOJKJO);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DBHPNIDCGJM(TIndex HCALFJOJKJO, [In] TValues ADLAOOMHAPB);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BGKDPCAKPBJ<AOGIMHHCCDD<GDEICLOHDHO>> MPJLNJJLHJN(TIndex HCALFJOJKJO, [In] TValues ADLAOOMHAPB);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class EHGFAOGOLFN<TDeps, TIndex, TValues> where TDeps : struct, LAIGFOMMBBA<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps OMOPLBNHPIH;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x389A670", Offset = "0x3899670", VA = "0x18389A670")]
	public static PPKMBIHDAAO<TIndex> PCBFBKDIPKL(int IHFNMDOGMLO, [In] TValues ADLAOOMHAPB)
	{
		return default(PPKMBIHDAAO<TIndex>);
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
