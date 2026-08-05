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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x293DD60", Offset = "0x293C960", VA = "0x18293DD60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct APGDOJAOBND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> DAPDHDMFNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int DMBCPOGLMHC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xDCF610", Offset = "0xDCE210", VA = "0x180DCF610")]
	public APGDOJAOBND(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> JALLLEOFPKG, int KPHEINADMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KPMBHLBECNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class KKFIHDJKFEF : HIGNNFJMCEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct HFCNBDNKJDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly BFIMJIAKEHP<byte> HKPAGKDIJHM;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28CB4B0", Offset = "0x28CA0B0", VA = "0x1828CB4B0")]
		public HFCNBDNKJDJ(BFIMJIAKEHP<byte> OEOOBGJGDIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x293BA80", Offset = "0x293A680", VA = "0x18293BA80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class FJHEPAKOEIB : HIGNNFJMCEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct FBFNOMPIFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> FDCDGFLCIAM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560")]
		public FBFNOMPIFFC(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> BLJPLGGJFFD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum GJOKIIFCGKH
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
	public sealed class IDKILNEHPHG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class HIGNNFJMCEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct FAFLHDGNPMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly GJOKIIFCGKH HMDIPKAKOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly IKLALLBKLKC<HIGNNFJMCEF> BPEBPKAOAJP;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDCF610", Offset = "0xDCE210", VA = "0x180DCF610")]
		public FAFLHDGNPMC(GJOKIIFCGKH KIKGBMCKHBA, IKLALLBKLKC<HIGNNFJMCEF> GCMOMJGFGJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class JIABEKBJLGA : HIGNNFJMCEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct EHMAEPEOAFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> CBOIFPLHIGL;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560")]
		public EHMAEPEOAFN(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> IJNKFNLPHOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class GDCMOFOKDAB : HIGNNFJMCEF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct KJKNMGOPAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly KAMJILGICKA KJJCCMLNEFM;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560")]
		public KJKNMGOPAMP(KAMJILGICKA KGBKPGJHJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x293D340", Offset = "0x293BF40", VA = "0x18293D340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal LJEKNEILIBB<IDKILNEHPHG, FAFLHDGNPMC> APKAJDDKFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal LJEKNEILIBB<KKFIHDJKFEF, HFCNBDNKJDJ> EKPPNCGCBMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal LJEKNEILIBB<FJHEPAKOEIB, FBFNOMPIFFC> NLHCLJNIIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal LJEKNEILIBB<JIABEKBJLGA, EHMAEPEOAFN> PMDPKPHPAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal LJEKNEILIBB<GDCMOFOKDAB, KJKNMGOPAMP> JGOJMCHOEJE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x293D530", Offset = "0x293C130", VA = "0x18293D530")]
	private KPMBHLBECNJ([In] LJEKNEILIBB<IDKILNEHPHG, FAFLHDGNPMC> ILCPGOCMOEK, [In] LJEKNEILIBB<KKFIHDJKFEF, HFCNBDNKJDJ> KDCIBLJIOIG, [In] LJEKNEILIBB<FJHEPAKOEIB, FBFNOMPIFFC> OHLPOCGMDEC, [In] LJEKNEILIBB<JIABEKBJLGA, EHMAEPEOAFN> NBANPGPMAEP, [In] LJEKNEILIBB<GDCMOFOKDAB, KJKNMGOPAMP> ECOLBNIICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x293D3F0", Offset = "0x293BFF0", VA = "0x18293D3F0")]
	public static KPMBHLBECNJ JHMOIFLKJAD()
	{
		return default(KPMBHLBECNJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GDKEMNMCNIB
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x293B380", Offset = "0x2939F80", VA = "0x18293B380")]
	public static void AMAAGOMLOEN(this KPMBHLBECNJ LAAPKLDJLPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum KILLFNFAMCD
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
public struct HNHIAMBODKF
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class NNOJKHCFHEB : BGCKBLELEFI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct IJKJEKEKAEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> DOCJAGDEGPK;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560")]
		public IJKJEKEKAEH(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> GJFDAKBKKLH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum COGENBCGBEK
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
	public sealed class AJNHAFCLMBN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class BGCKBLELEFI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct KMHGEDNOEJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly COGENBCGBEK HMDIPKAKOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly IKLALLBKLKC<BGCKBLELEFI> BPEBPKAOAJP;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDCF610", Offset = "0xDCE210", VA = "0x180DCF610")]
		public KMHGEDNOEJB(COGENBCGBEK KIKGBMCKHBA, IKLALLBKLKC<BGCKBLELEFI> GCMOMJGFGJN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal LJEKNEILIBB<AJNHAFCLMBN, KMHGEDNOEJB> APKAJDDKFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LJEKNEILIBB<NNOJKHCFHEB, IJKJEKEKAEH> NCAKOFLDOHC;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x293BB80", Offset = "0x293A780", VA = "0x18293BB80")]
	private HNHIAMBODKF([In] LJEKNEILIBB<AJNHAFCLMBN, KMHGEDNOEJB> ILCPGOCMOEK, [In] LJEKNEILIBB<NNOJKHCFHEB, IJKJEKEKAEH> GILOGLCHKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x293BAF0", Offset = "0x293A6F0", VA = "0x18293BAF0")]
	public static HNHIAMBODKF JHMOIFLKJAD()
	{
		return default(HNHIAMBODKF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class MAMCOEPDPBM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x293D9E0", Offset = "0x293C5E0", VA = "0x18293D9E0")]
	public static void AMAAGOMLOEN(this HNHIAMBODKF LAAPKLDJLPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FMLFHOBGNDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public MJLLGLFJCNK<int> MGAMDBHBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public MJLLGLFJCNK<int> AIHGKBACHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int GCAAMNKECPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int PMBECCDHGAK;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x293B170", Offset = "0x2939D70", VA = "0x18293B170")]
	private FMLFHOBGNDJ([In] MJLLGLFJCNK<int> PGBNLGMLFPP, [In] MJLLGLFJCNK<int> CALGNAJHAIP, int KJIHFLOGHCM, int DFIAABPHDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x293B0D0", Offset = "0x2939CD0", VA = "0x18293B0D0")]
	public static FMLFHOBGNDJ JHMOIFLKJAD()
	{
		return default(FMLFHOBGNDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class FOLKFOPDOCA
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x293B1D0", Offset = "0x2939DD0", VA = "0x18293B1D0")]
	public static void AMAAGOMLOEN(this FMLFHOBGNDJ LAAPKLDJLPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct JKEIFDFFLJE
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum JKNMEKKDJEA
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class PAKFMMJEBBN : LAHJNPNLGNH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct OFNJOHBFHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly IKLALLBKLKC<PHMNHGGMNHK> OCCKONBGMFO;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560")]
		public OFNJOHBFHNA(IKLALLBKLKC<PHMNHGGMNHK> AEHDNMOIMFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class HCMJHBLJCIN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class LAHJNPNLGNH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct IOOKJCOANNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly JKNMEKKDJEA HMDIPKAKOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly IKLALLBKLKC<LAHJNPNLGNH> BPEBPKAOAJP;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xDCF610", Offset = "0xDCE210", VA = "0x180DCF610")]
		private IOOKJCOANNG(JKNMEKKDJEA KIKGBMCKHBA, IKLALLBKLKC<LAHJNPNLGNH> GCMOMJGFGJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x293C070", Offset = "0x293AC70", VA = "0x18293C070")]
		public static IOOKJCOANNG JHMOIFLKJAD(JKNMEKKDJEA KIKGBMCKHBA, IKLALLBKLKC<LAHJNPNLGNH> GCMOMJGFGJN)
		{
			return default(IOOKJCOANNG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class APMGOMCOKFA : LAHJNPNLGNH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct LIJOIEADPFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly IKLALLBKLKC<PHMNHGGMNHK> OCCKONBGMFO;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560")]
		public LIJOIEADPFP(IKLALLBKLKC<PHMNHGGMNHK> AEHDNMOIMFM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class PHMNHGGMNHK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct MNGOIIMNKLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public MJLLGLFJCNK<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> HAJGFHFLLIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public MJLLGLFJCNK<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> JADKIKBDGAK;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x293BB80", Offset = "0x293A780", VA = "0x18293BB80")]
		private MNGOIIMNKLI([In] MJLLGLFJCNK<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> HNMKHBLHFDD, [In] MJLLGLFJCNK<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> JNMHEBNPJIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x293DA40", Offset = "0x293C640", VA = "0x18293DA40")]
		public static MNGOIIMNKLI JHMOIFLKJAD()
		{
			return default(MNGOIIMNKLI);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal LJEKNEILIBB<HCMJHBLJCIN, IOOKJCOANNG> APKAJDDKFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal LJEKNEILIBB<APMGOMCOKFA, LIJOIEADPFP> AEJCAOBIPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal LJEKNEILIBB<PAKFMMJEBBN, OFNJOHBFHNA> MDIPDAFBJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal MJLLGLFJCNK<(IKLALLBKLKC<HCMJHBLJCIN> CallId, IKLALLBKLKC<PHMNHGGMNHK> IOId)> DOCFJOPDELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal LJEKNEILIBB<PHMNHGGMNHK, MNGOIIMNKLI> KAPNNCAHEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal FKBNOJLBGKB<PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>> MALGKHOAGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal FKBNOJLBGKB<PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>> OEDGEGKAMNP;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x293C2D0", Offset = "0x293AED0", VA = "0x18293C2D0")]
	private JKEIFDFFLJE([In] LJEKNEILIBB<HCMJHBLJCIN, IOOKJCOANNG> ILCPGOCMOEK, [In] LJEKNEILIBB<APMGOMCOKFA, LIJOIEADPFP> KEELFNKEADE, [In] LJEKNEILIBB<PAKFMMJEBBN, OFNJOHBFHNA> AFPMCJKPODJ, [In] MJLLGLFJCNK<(IKLALLBKLKC<HCMJHBLJCIN> CallId, IKLALLBKLKC<PHMNHGGMNHK> IOId)> EHAOFOMIAAB, [In] LJEKNEILIBB<PHMNHGGMNHK, MNGOIIMNKLI> KAIJGNPPCEK, [In] FKBNOJLBGKB<PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>> DJBCEIBFJGC, [In] FKBNOJLBGKB<PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>> IKIJLPAPAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x293C130", Offset = "0x293AD30", VA = "0x18293C130")]
	public static JKEIFDFFLJE JHMOIFLKJAD()
	{
		return default(JKEIFDFFLJE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class NKMBCBECDPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x293DAC0", Offset = "0x293C6C0", VA = "0x18293DAC0")]
	private static void AMAAGOMLOEN(this JKEIFDFFLJE.MNGOIIMNKLI LAAPKLDJLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x293DB10", Offset = "0x293C710", VA = "0x18293DB10")]
	public static void AMAAGOMLOEN(this JKEIFDFFLJE LAAPKLDJLPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct JOOGONCAGGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public MJLLGLFJCNK<byte> OHBDKNFHELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal JKEIFDFFLJE KDBKGADOJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal GGJKKDNFPFG LIHHFAANPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> PHDFCAJACBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal KPMBHLBECNJ AIEDAMENCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal HNHIAMBODKF NGCMMPBJIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal FKBNOJLBGKB<PPCGBNBBHPM, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>?> NILLDEMNGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal MJLLGLFJCNK<IKLALLBKLKC<PPCGBNBBHPM>> BNPEAFKGKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?> CPKIMACOPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> VariableId, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>> ByteCodeWriteLocation)> DJMCHCALOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> PBGIKKONCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal KIAJAPNCDFA BFCJIEBOHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal ILHPKNLOGLG OENBCPOELFH;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x293CD40", Offset = "0x293B940", VA = "0x18293CD40")]
	private JOOGONCAGGO([In] MJLLGLFJCNK<byte> AINPEHPOKAD, [In] JKEIFDFFLJE AKOKDGFNDON, [In] GGJKKDNFPFG ODCJEIEPNJO, [In] KPMBHLBECNJ HBAIGAIKNCK, [In] HNHIAMBODKF LPCIMMKOCLM, [In] FKBNOJLBGKB<PPCGBNBBHPM, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>?> DOIPPEGOIAH, [In] MJLLGLFJCNK<IKLALLBKLKC<PPCGBNBBHPM>> IMHJILBHCKL, [In] FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?> NBCBEHEODDJ, [In] MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> VariableId, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>> ByteCodeWriteLocation)> HKMAKAICIIL, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> BJMEDLCBMAC, [In] KIAJAPNCDFA ANLDLPBFIJN, [In] ILHPKNLOGLG OCJKNEAKCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x293C390", Offset = "0x293AF90", VA = "0x18293C390")]
	public static JOOGONCAGGO JHMOIFLKJAD()
	{
		return default(JOOGONCAGGO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DKOEJHDBAEA
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct GBFFPGIBELK : AEGGBOPKKPN<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>, FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x293B250", Offset = "0x2939E50", VA = "0x18293B250")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x293B220", Offset = "0x2939E20", VA = "0x18293B220", Slot = "4")]
		public IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> KBCGCOOEJNG(int EMMACFPOKFB)
		{
			return default(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390")]
		public bool JDBNJCPDMFM(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "5")]
		private bool MCKCBJKEOMI(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x293B250", Offset = "0x2939E50", VA = "0x18293B250", Slot = "6")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MEFBOHIMDJH(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct AGGJGGODBDJ : JMFDMKCFLMM<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>, FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x29328F0", Offset = "0x29314F0", VA = "0x1829328F0")]
		public MJLLGLFJCNK<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>> KCEHFDCDCMF(int AEIELADFFKL, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x29329F0", Offset = "0x29315F0", VA = "0x1829329F0")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2932960", Offset = "0x2931560", VA = "0x182932960", Slot = "6")]
		public void BAFGCIHDBGE(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>> AIPJHMCGMIB, IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x29328F0", Offset = "0x29314F0", VA = "0x1829328F0", Slot = "4")]
		private MJLLGLFJCNK<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>> ACFBOEPGLKD(int AEIELADFFKL, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x29329F0", Offset = "0x29315F0", VA = "0x1829329F0", Slot = "5")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> CACLBOFENCG(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct JHACFOODOOP : AEGGBOPKKPN<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>, FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x293C080", Offset = "0x293AC80", VA = "0x18293C080")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x293C100", Offset = "0x293AD00", VA = "0x18293C100", Slot = "4")]
		public IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> KBCGCOOEJNG(int EMMACFPOKFB)
		{
			return default(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390")]
		public bool JDBNJCPDMFM(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "5")]
		private bool GFLGFHFAJGI(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x293C080", Offset = "0x293AC80", VA = "0x18293C080", Slot = "6")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> GLEPKMNGEHL(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct IIPBIONAFHB : JMFDMKCFLMM<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>, FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x293BC50", Offset = "0x293A850", VA = "0x18293BC50")]
		public MJLLGLFJCNK<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>> KCEHFDCDCMF(int AEIELADFFKL, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x293BCC0", Offset = "0x293A8C0", VA = "0x18293BCC0")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x293BBC0", Offset = "0x293A7C0", VA = "0x18293BBC0", Slot = "6")]
		public void BAFGCIHDBGE(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>> AIPJHMCGMIB, IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x293BC50", Offset = "0x293A850", VA = "0x18293BC50", Slot = "4")]
		private MJLLGLFJCNK<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>> PEPKOOKAOGP(int AEIELADFFKL, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x293BCC0", Offset = "0x293A8C0", VA = "0x18293BCC0", Slot = "5")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> OPOCLBMMGCD(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> EMMACFPOKFB, [In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct LCLNJCPCHNA : AEGGBOPKKPN<IKLALLBKLKC<EFEDBHKEGPL>, FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x293D6F0", Offset = "0x293C2F0", VA = "0x18293D6F0")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(IKLALLBKLKC<EFEDBHKEGPL> EMMACFPOKFB, [In] FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x293D6B0", Offset = "0x293C2B0", VA = "0x18293D6B0", Slot = "4")]
		public IKLALLBKLKC<EFEDBHKEGPL> KBCGCOOEJNG(int EMMACFPOKFB)
		{
			return default(IKLALLBKLKC<EFEDBHKEGPL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x293D650", Offset = "0x293C250", VA = "0x18293D650")]
		public bool JDBNJCPDMFM(IKLALLBKLKC<EFEDBHKEGPL> EMMACFPOKFB, [In] FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x293D650", Offset = "0x293C250", VA = "0x18293D650", Slot = "5")]
		private bool IMPKAHDIAPL(IKLALLBKLKC<EFEDBHKEGPL> EMMACFPOKFB, [In] FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x293D6E0", Offset = "0x293C2E0", VA = "0x18293D6E0", Slot = "6")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDKOGCKDFEG(IKLALLBKLKC<EFEDBHKEGPL> EMMACFPOKFB, [In] FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct LGJAPKODGOO : JMFDMKCFLMM<IKLALLBKLKC<EFEDBHKEGPL>, FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x293D850", Offset = "0x293C450", VA = "0x18293D850")]
		public MJLLGLFJCNK<IKLALLBKLKC<EFEDBHKEGPL>> KCEHFDCDCMF(int AEIELADFFKL, [In] FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<IKLALLBKLKC<EFEDBHKEGPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x293D8C0", Offset = "0x293C4C0", VA = "0x18293D8C0")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(IKLALLBKLKC<EFEDBHKEGPL> EMMACFPOKFB, [In] FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x293D790", Offset = "0x293C390", VA = "0x18293D790", Slot = "6")]
		public void BAFGCIHDBGE(IKLALLBKLKC<EFEDBHKEGPL> EMMACFPOKFB, FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?> AIPJHMCGMIB, IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x293D850", Offset = "0x293C450", VA = "0x18293D850", Slot = "4")]
		private MJLLGLFJCNK<IKLALLBKLKC<EFEDBHKEGPL>> KBCHKDLFMLI(int AEIELADFFKL, [In] FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<IKLALLBKLKC<EFEDBHKEGPL>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x293D840", Offset = "0x293C440", VA = "0x18293D840", Slot = "5")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> DKEENBCEOAN(IKLALLBKLKC<EFEDBHKEGPL> EMMACFPOKFB, [In] FKBNOJLBGKB<EFEDBHKEGPL, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>?> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct KMKCFKHNLFG : AEGGBOPKKPN<int, MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x293D370", Offset = "0x293BF70", VA = "0x18293D370")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> VariableId, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB00010", Offset = "0xAFEC10", VA = "0x180B00010", Slot = "4")]
		public int KBCGCOOEJNG(int EMMACFPOKFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390")]
		public bool JDBNJCPDMFM(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> VariableId, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "5")]
		private bool EFCIICAGOAC(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> VariableId, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x293D360", Offset = "0x293BF60", VA = "0x18293D360", Slot = "6")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> FNMLJMCHOKN(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> VariableId, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct DCPOEOGNLJE : JMFDMKCFLMM<int, MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2933810", Offset = "0x2932410", VA = "0x182933810")]
		public MJLLGLFJCNK<int> KCEHFDCDCMF(int AEIELADFFKL, [In] MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> VariableId, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2933890", Offset = "0x2932490", VA = "0x182933890")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> VariableId, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2933720", Offset = "0x2932320", VA = "0x182933720", Slot = "6")]
		public void BAFGCIHDBGE(int EMMACFPOKFB, MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> VariableId, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>> ByteCodeWriteLocation)> AIPJHMCGMIB, IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2933810", Offset = "0x2932410", VA = "0x182933810", Slot = "4")]
		private MJLLGLFJCNK<int> DKBLJNILPKP(int AEIELADFFKL, [In] MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> VariableId, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2933880", Offset = "0x2932480", VA = "0x182933880", Slot = "5")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> JDMCOHJICBG(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> VariableId, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<OICBEJIKPDD>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct LOAABACHAIG : AEGGBOPKKPN<int, MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x293D960", Offset = "0x293C560", VA = "0x18293D960")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB00010", Offset = "0xAFEC10", VA = "0x180B00010", Slot = "4")]
		public int KBCGCOOEJNG(int EMMACFPOKFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390")]
		public bool JDBNJCPDMFM(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "5")]
		private bool FMBCBAIHADF(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x293D960", Offset = "0x293C560", VA = "0x18293D960", Slot = "6")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> GBIKGCKGNOJ(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct HEEBNIDDHLJ : JMFDMKCFLMM<int, MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x293B990", Offset = "0x293A590", VA = "0x18293B990")]
		public MJLLGLFJCNK<int> KCEHFDCDCMF(int AEIELADFFKL, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x293BA00", Offset = "0x293A600", VA = "0x18293BA00")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x293B8B0", Offset = "0x293A4B0", VA = "0x18293B8B0", Slot = "6")]
		public void BAFGCIHDBGE(int EMMACFPOKFB, MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB, IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x293B990", Offset = "0x293A590", VA = "0x18293B990", Slot = "4")]
		private MJLLGLFJCNK<int> GGKNEOBKLIN(int AEIELADFFKL, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x293BA00", Offset = "0x293A600", VA = "0x18293BA00", Slot = "5")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> GOGLEOJDJEF(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct LBAJDPKPAIN : AEGGBOPKKPN<int, MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x293D5D0", Offset = "0x293C1D0", VA = "0x18293D5D0")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB00010", Offset = "0xAFEC10", VA = "0x180B00010", Slot = "4")]
		public int KBCGCOOEJNG(int EMMACFPOKFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390")]
		public bool JDBNJCPDMFM(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "5")]
		private bool FMBCBAIHADF(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x293D5C0", Offset = "0x293C1C0", VA = "0x18293D5C0", Slot = "6")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> GBIKGCKGNOJ(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct INIGDBKKIOF : JMFDMKCFLMM<int, MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x293BF70", Offset = "0x293AB70", VA = "0x18293BF70")]
		public MJLLGLFJCNK<int> KCEHFDCDCMF(int AEIELADFFKL, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x293BFF0", Offset = "0x293ABF0", VA = "0x18293BFF0")]
		public IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x293BE80", Offset = "0x293AA80", VA = "0x18293BE80", Slot = "6")]
		public void BAFGCIHDBGE(int EMMACFPOKFB, MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB, IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> OOHGFGHCOAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x293BF70", Offset = "0x293AB70", VA = "0x18293BF70", Slot = "4")]
		private MJLLGLFJCNK<int> GGKNEOBKLIN(int AEIELADFFKL, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(MJLLGLFJCNK<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x293BFE0", Offset = "0x293ABE0", VA = "0x18293BFE0", Slot = "5")]
		private IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> GOGLEOJDJEF(int EMMACFPOKFB, [In] MJLLGLFJCNK<(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> Target, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ByteCodeWriteLocation)> AIPJHMCGMIB)
		{
			return default(IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct PJANGFHHKPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> HLDBAOOBEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool OHIMNLJOHMO;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1FFBD80", Offset = "0x1FFA980", VA = "0x181FFBD80")]
		public PJANGFHHKPG(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM, bool CCFDLNHDDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x293DF10", Offset = "0x293CB10", VA = "0x18293DF10")]
		public void AMHBPBGIPFF([Out] IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM, [Out] bool CCFDLNHDDFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct NNFBFFAFBGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly IKLALLBKLKC<EFEDBHKEGPL> JDJOOBNLBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> HLDBAOOBEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool OHIMNLJOHMO;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x293DD50", Offset = "0x293C950", VA = "0x18293DD50")]
		public NNFBFFAFBGE(IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM, bool CCFDLNHDDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x293DD40", Offset = "0x293C940", VA = "0x18293DD40")]
		public void AMHBPBGIPFF([Out] IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM, [Out] bool CCFDLNHDDFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x293DD20", Offset = "0x293C920", VA = "0x18293DD20")]
		public void AMHBPBGIPFF([Out] IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM, [Out] IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD, [Out] bool CCFDLNHDDFG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct PGHMIMGDBFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly IKLALLBKLKC<EFEDBHKEGPL> JDJOOBNLBLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> HLDBAOOBEDN;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xDCF610", Offset = "0xDCE210", VA = "0x180DCF610")]
		public PGHMIMGDBFK(IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x293DF00", Offset = "0x293CB00", VA = "0x18293DF00")]
		public void AMHBPBGIPFF([Out] IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM, [Out] IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2933AF0", Offset = "0x29326F0", VA = "0x182933AF0")]
	public static void AMAAGOMLOEN(this JOOGONCAGGO LAAPKLDJLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x29339D0", Offset = "0x29325D0", VA = "0x1829339D0")]
	public static void AJOIPGFFMMM(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<PPCGBNBBHPM> BCPDNCNKAPP, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> DJMKMHGPLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2934E00", Offset = "0x2933A00", VA = "0x182934E00")]
	public static void ILLEKIOHOMK(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<PPCGBNBBHPM> BCPDNCNKAPP, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> DJMKMHGPLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29349A0", Offset = "0x29335A0", VA = "0x1829349A0")]
	public static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>? GGPFFACBAJC([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<PPCGBNBBHPM> BCPDNCNKAPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x29351F0", Offset = "0x2933DF0", VA = "0x1829351F0")]
	public static IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> KLEKOGFHGLB([In] this JOOGONCAGGO LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2933DC0", Offset = "0x29329C0", VA = "0x182933DC0")]
	private static void APCENDFMNLE(this JOOGONCAGGO LAAPKLDJLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2933A60", Offset = "0x2932660", VA = "0x182933A60")]
	private static IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>? AKLCFMFNFMH([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2934430", Offset = "0x2933030", VA = "0x182934430")]
	public static void EFKONJCMGIP(this JOOGONCAGGO LAAPKLDJLPE, [In] MJLLGLFJCNK<APGDOJAOBND> FHPLFHLAADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x29345A0", Offset = "0x29331A0", VA = "0x1829345A0")]
	public static KPMBHLBECNJ.GJOKIIFCGKH EFNPECLCACA([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM)
	{
		return default(KPMBHLBECNJ.GJOKIIFCGKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2934730", Offset = "0x2933330", VA = "0x182934730")]
	public static BFIMJIAKEHP<byte> FLCHCAPBIGN([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM)
	{
		return default(BFIMJIAKEHP<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2934CF0", Offset = "0x29338F0", VA = "0x182934CF0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> IGCEOPHDPOI([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2934280", Offset = "0x2932E80", VA = "0x182934280")]
	public static KAMJILGICKA BMIGAFIFKFM([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x38EBBB0", Offset = "0x38EA7B0", VA = "0x1838EBBB0")]
	private static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> ELBHCKJJIBC<TMJoin>(this JOOGONCAGGO LAAPKLDJLPE, KPMBHLBECNJ.GJOKIIFCGKH KIKGBMCKHBA, IKLALLBKLKC<TMJoin> GCMOMJGFGJN) where TMJoin : KPMBHLBECNJ.HIGNNFJMCEF
	{
		return default(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x29350E0", Offset = "0x2933CE0", VA = "0x1829350E0")]
	public static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> KCMBADLDGMD(this JOOGONCAGGO LAAPKLDJLPE, bool GMLKFMNCGNJ)
	{
		return default(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2935160", Offset = "0x2933D60", VA = "0x182935160")]
	public static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> KLBNHDOLOLC(this JOOGONCAGGO LAAPKLDJLPE, BFIMJIAKEHP<byte> OEOOBGJGDIH)
	{
		return default(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2935AA0", Offset = "0x29346A0", VA = "0x182935AA0")]
	public static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PHGIAJMOHJN(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> BLJPLGGJFFD)
	{
		return default(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2934AE0", Offset = "0x29336E0", VA = "0x182934AE0")]
	public static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> GIAEBKJAEKH(this JOOGONCAGGO LAAPKLDJLPE, int OONNDFOKJNP)
	{
		return default(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2935250", Offset = "0x2933E50", VA = "0x182935250")]
	public static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> KMKADFBFPHL(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> IJNKFNLPHOF)
	{
		return default(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x38EA690", Offset = "0x38E9290", VA = "0x1838EA690")]
	private static IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN> BFBCDHDIPMA<TMJoin>(this JOOGONCAGGO LAAPKLDJLPE, HNHIAMBODKF.COGENBCGBEK KIKGBMCKHBA, IKLALLBKLKC<TMJoin> GCMOMJGFGJN) where TMJoin : HNHIAMBODKF.BGCKBLELEFI
	{
		return default(IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2935B20", Offset = "0x2934720", VA = "0x182935B20")]
	public static IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN> PHMOMPGNIHO(this JOOGONCAGGO LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x29343E0", Offset = "0x2932FE0", VA = "0x1829343E0")]
	public static IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN> DBLNNGIOGHG(this JOOGONCAGGO LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2934660", Offset = "0x2933260", VA = "0x182934660")]
	public static IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN> FEJBLBAMMEL(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> GJFDAKBKKLH)
	{
		return default(IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x29348A0", Offset = "0x29334A0", VA = "0x1829348A0")]
	public static IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN> GDEIGJHPKHE(this JOOGONCAGGO LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x29346E0", Offset = "0x29332E0", VA = "0x1829346E0")]
	public static IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN> FHMLJHLKALK(this JOOGONCAGGO LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x29356F0", Offset = "0x29342F0", VA = "0x1829356F0")]
	public static JKEIFDFFLJE.JKNMEKKDJEA NLMHGOIEFNI([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN> PKEJILNNPHF)
	{
		return default(JKEIFDFFLJE.JKNMEKKDJEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x29359B0", Offset = "0x29345B0", VA = "0x1829359B0")]
	public static ECABMMAFEOH<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>, MFEDJGDBNIE<JKEIFDFFLJE.PHMNHGGMNHK>> OHKBIMCPKFD([In] this JOOGONCAGGO LAAPKLDJLPE)
	{
		return default(ECABMMAFEOH<IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>, MFEDJGDBNIE<JKEIFDFFLJE.PHMNHGGMNHK>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2935570", Offset = "0x2934170", VA = "0x182935570")]
	public static IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> NGFKOPPDGFJ([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN> PKEJILNNPHF)
	{
		return default(IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2934DA0", Offset = "0x29339A0", VA = "0x182934DA0")]
	public static JKEIFDFFLJE.MNGOIIMNKLI IGGIEFADPIB([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> AEHDNMOIMFM)
	{
		return default(JKEIFDFFLJE.MNGOIIMNKLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x29352D0", Offset = "0x2933ED0", VA = "0x1829352D0")]
	public static JKEIFDFFLJE.MNGOIIMNKLI LBMNNFMLGLG(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> AEHDNMOIMFM)
	{
		return default(JKEIFDFFLJE.MNGOIIMNKLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x38EBD20", Offset = "0x38EA920", VA = "0x1838EBD20")]
	private static IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN> HIFCOMOFEKG<TMJoin>(this JOOGONCAGGO LAAPKLDJLPE, JKEIFDFFLJE.JKNMEKKDJEA KIKGBMCKHBA, IKLALLBKLKC<TMJoin> GCMOMJGFGJN) where TMJoin : JKEIFDFFLJE.LAHJNPNLGNH
	{
		return default(IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2933F20", Offset = "0x2932B20", VA = "0x182933F20")]
	public static (IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>) BECPHKDBLAG(this JOOGONCAGGO LAAPKLDJLPE)
	{
		return default((IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2935800", Offset = "0x2934400", VA = "0x182935800")]
	public static (IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>) OFBDFLAMPCG(this JOOGONCAGGO LAAPKLDJLPE)
	{
		return default((IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2935090", Offset = "0x2933C90", VA = "0x182935090")]
	public static IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN> JLCLFNBCBJK(this JOOGONCAGGO LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2935330", Offset = "0x2933F30", VA = "0x182935330")]
	public static void MPEMNKDHMNN(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK> AEHDNMOIMFM, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> CCDNLBICHGJ, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>> LOEAMDDMCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x38EACC0", Offset = "0x38E98C0", VA = "0x1838EACC0")]
	public static PJANGFHHKPG DDKDKAAOMAL<TDeps, TStateSys>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD) where TDeps : MKPNDNMDMBE<TStateSys>
	{
		return default(PJANGFHHKPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x38EC1D0", Offset = "0x38EADD0", VA = "0x1838EC1D0")]
	public static NNFBFFAFBGE KLEDPIEBJKE<TDeps, TStateSys>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<DKJICOCFIKD> GKLJHCMGFAB, int NPGCKANHPFN) where TDeps : MKPNDNMDMBE<TStateSys>
	{
		return default(NNFBFFAFBGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x38EBDB0", Offset = "0x38EA9B0", VA = "0x1838EBDB0")]
	public static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>? IBKIEDBFIKC<TDeps, TStateSys>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<DKJICOCFIKD> GKLJHCMGFAB, [In] ReadOnlySpan<int> PHGJFACAHGD, [In] Span<PGHMIMGDBFK> NHGOAFDMKEP) where TDeps : MKPNDNMDMBE<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x38EA720", Offset = "0x38E9320", VA = "0x1838EA720")]
	public static IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN> CCIIPCICGBC<TDeps, TStateSys>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<PPCGBNBBHPM> BCPDNCNKAPP) where TDeps : MKPNDNMDMBE<TStateSys>
	{
		return default(IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x29359F0", Offset = "0x29345F0", VA = "0x1829359F0")]
	public static GGJKKDNFPFG.ONCGAGOFLCC OLFBJAFCHBA([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> ALPNKEJICNA)
	{
		return default(GGJKKDNFPFG.ONCGAGOFLCC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x29348F0", Offset = "0x29334F0", VA = "0x1829348F0")]
	public static GGJKKDNFPFG.DEFOPFGBJAI GGKMANPGDEE([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> ALPNKEJICNA)
	{
		return default(GGJKKDNFPFG.DEFOPFGBJAI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2934330", Offset = "0x2932F30", VA = "0x182934330")]
	public static GGJKKDNFPFG.FCOMHMNOKHK CJNGJHHFCAK([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> ALPNKEJICNA)
	{
		return default(GGJKKDNFPFG.FCOMHMNOKHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2934ED0", Offset = "0x2933AD0", VA = "0x182934ED0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> JJGEOKFPJLC(this JOOGONCAGGO LAAPKLDJLPE, int? EEBMPCLPPHA, string LAOCJKNALFF)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2935750", Offset = "0x2934350", VA = "0x182935750")]
	public static GGJKKDNFPFG.IEHLOIPBPJP NOLDHALOOJJ([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> ALPNKEJICNA)
	{
		return default(GGJKKDNFPFG.IEHLOIPBPJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2933910", Offset = "0x2932510", VA = "0x182933910")]
	public static GGJKKDNFPFG.PAICLNKEKNE ABGECJHGNFH([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> ALPNKEJICNA)
	{
		return default(GGJKKDNFPFG.PAICLNKEKNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2933970", Offset = "0x2932570", VA = "0x182933970")]
	public static int? AGJEDPHHCPD([In] this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> ALPNKEJICNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x38EBC40", Offset = "0x38EA840", VA = "0x1838EBC40")]
	private static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> FNHJDOMAOML<TMJoin>(this JOOGONCAGGO LAAPKLDJLPE, int? EEBMPCLPPHA, GGJKKDNFPFG.PAICLNKEKNE KIKGBMCKHBA, IKLALLBKLKC<TMJoin> GCMOMJGFGJN) where TMJoin : GGJKKDNFPFG.PMDPEEOJGBI
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2934A30", Offset = "0x2933630", VA = "0x182934A30")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> GHEBENKDIKP(this JOOGONCAGGO LAAPKLDJLPE, int? EEBMPCLPPHA, IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN> PKEJILNNPHF, int EMMACFPOKFB)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2934600", Offset = "0x2933200", VA = "0x182934600")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> FACEALFNIEL(this JOOGONCAGGO LAAPKLDJLPE, int? EEBMPCLPPHA)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2934B60", Offset = "0x2933760", VA = "0x182934B60")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> GKBOFGOBONM(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>? EPHLHHADIGO, int? EEBMPCLPPHA)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x29341F0", Offset = "0x2932DF0", VA = "0x1829341F0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> BMAJMMFECDG(this JOOGONCAGGO LAAPKLDJLPE, int? EEBMPCLPPHA, int EMMACFPOKFB)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2935480", Offset = "0x2934080", VA = "0x182935480")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> NFBBHECKEAI(this JOOGONCAGGO LAAPKLDJLPE, int? EEBMPCLPPHA)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2935B60", Offset = "0x2934760", VA = "0x182935B60")]
	public static void PONPJACOLCJ(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> IJNKFNLPHOF, IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN> PKEJILNNPHF, int EMMACFPOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x29340D0", Offset = "0x2932CD0", VA = "0x1829340D0")]
	public static void BLBNEPJKAMP(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> IJNKFNLPHOF, int EMMACFPOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x29347E0", Offset = "0x29333E0", VA = "0x1829347E0")]
	public static void FMFDOGBCJOO(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> IJNKFNLPHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x29354E0", Offset = "0x29340E0", VA = "0x1829354E0")]
	public static void NFLCAKCDGDC(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> MDKAAPLMLKG, IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> PLNDCKBJINA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x29353C0", Offset = "0x2933FC0", VA = "0x1829353C0")]
	public static void NBLFEDHOCAG(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> IJNKFNLPHOF, IKLALLBKLKC<FBBBJKHBBDB<HCOIJEHFDFF>> KFKNBOJGAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x38EC450", Offset = "0x38EB050", VA = "0x1838EC450")]
	public static void MMCENMGNDJF<M>(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> IJNKFNLPHOF, IKLALLBKLKC<FBBBJKHBBDB<DGDDJKDGKMF<M>>> KFKNBOJGAGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface MKPNDNMDMBE<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IKLALLBKLKC<EALKCLEEIPA> DOOOAKOHFFB(TStateSys MGBNKIFDPJA);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IKLALLBKLKC<EALKCLEEIPA> OEGJLMOBHFK(TStateSys MGBNKIFDPJA);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IKLALLBKLKC<EALKCLEEIPA> GOEOODEGEPM(TStateSys MGBNKIFDPJA);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IKLALLBKLKC<EALKCLEEIPA> GFGGLICFCBL(TStateSys MGBNKIFDPJA);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN> DFALFPJDCLD(TStateSys MGBNKIFDPJA, JOOGONCAGGO PBHHLGFCKAL, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> JJDBKMGDAFP(TStateSys MGBNKIFDPJA, JOOGONCAGGO PBHHLGFCKAL, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<PPCGBNBBHPM> BCPDNCNKAPP);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int JPALBFCOBPF(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IKLALLBKLKC<PPCGBNBBHPM> HLFLPIDPLPM(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD, int PBNCPBOEDBJ);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KILLFNFAMCD BOBLDJLNCCL(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IDOPOKFMJIN(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int GIKLJIEHNJJ(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	BFIMJIAKEHP<byte> DNBGOAEEPDB(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(BFIMJIAKEHP<byte>, IKLALLBKLKC<EALKCLEEIPA>) KCBKDNFPNBD(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<EFEDBHKEGPL> PELPLHFFPLD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int GKOIOMOKNHF(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<PPCGBNBBHPM> BCPDNCNKAPP);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IKLALLBKLKC<EFEDBHKEGPL> GJJHFNNBMFF(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<PPCGBNBBHPM> BCPDNCNKAPP, int NPGCKANHPFN);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IKLALLBKLKC<EFEDBHKEGPL> AJHLDEPOJAJ(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, IKLALLBKLKC<DKJICOCFIKD> GKLJHCMGFAB, int NPGCKANHPFN);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int IMNHNAEFCCO(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? KMGIOKFEIGD(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, int EMMACFPOKFB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int ABFPLJBIGCN(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? EMHPJCPJMNP(TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI, int EMMACFPOKFB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DPEBHIPGIJI
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x38EF760", Offset = "0x38EE360", VA = "0x1838EF760")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM?> HAJPLFHELMP<T, TOpInput, TOpOutput>(this JOOGONCAGGO LAAPKLDJLPE, T HLPEBKMLKLE, T MAELALMKOEM, int JBDPHCDIPEL, IntPtr ILKCEJAIIBJ)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x38EFA10", Offset = "0x38EE610", VA = "0x1838EFA10")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM?> HIAHPDAHOID<T, TOpInput, TOpOutput>(this JOOGONCAGGO LAAPKLDJLPE, T HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM, int JBDPHCDIPEL, IntPtr ILKCEJAIIBJ)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x38F1490", Offset = "0x38F0090", VA = "0x1838F1490")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM?> NLNDABMGKEF<TOpInput, TOpOutput>(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM, int JBDPHCDIPEL, IntPtr ILKCEJAIIBJ)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2937090", Offset = "0x2935C90", VA = "0x182937090")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> DBJPDFKGAJE(this JOOGONCAGGO LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2939450", Offset = "0x2938050", VA = "0x182939450")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> KGHHJJLPBAL(this JOOGONCAGGO LAAPKLDJLPE, float HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2938EA0", Offset = "0x2937AA0", VA = "0x182938EA0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> JPHIHKOEJGM(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2936E60", Offset = "0x2935A60", VA = "0x182936E60")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> COEDJLBGLGE(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2939C30", Offset = "0x2938830", VA = "0x182939C30")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> LOCGINLKDKM(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2938820", Offset = "0x2937420", VA = "0x182938820")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> JCFFKHDNKGG(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x293A390", Offset = "0x2938F90", VA = "0x18293A390")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> NMNOGPFNGCK(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2937790", Offset = "0x2936390", VA = "0x182937790")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHIEGLFFDKA(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x293A590", Offset = "0x2939190", VA = "0x18293A590")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> OALJMCJMABP(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x293A970", Offset = "0x2939570", VA = "0x18293A970")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> OJBOHFGKHBJ(this JOOGONCAGGO LAAPKLDJLPE, int HLPEBKMLKLE, int MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2939910", Offset = "0x2938510", VA = "0x182939910")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> KOJLOGAPGOC(this JOOGONCAGGO LAAPKLDJLPE, int HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2939E70", Offset = "0x2938A70", VA = "0x182939E70")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAMHJMGJHFG(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2935D30", Offset = "0x2934930", VA = "0x182935D30")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> AOKOJLBLOEL(this JOOGONCAGGO LAAPKLDJLPE, float HLPEBKMLKLE, float MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2938620", Offset = "0x2937220", VA = "0x182938620")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HIFPCLALFBI(this JOOGONCAGGO LAAPKLDJLPE, float HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x293AE90", Offset = "0x2939A90", VA = "0x18293AE90")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> OPPCIJNLOFH(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x293A6D0", Offset = "0x29392D0", VA = "0x18293A6D0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> OBKMDKOBODB(this JOOGONCAGGO LAAPKLDJLPE, int HLPEBKMLKLE, int MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2936050", Offset = "0x2934C50", VA = "0x182936050")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> BGBENJFCDBL(this JOOGONCAGGO LAAPKLDJLPE, int HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2937290", Offset = "0x2935E90", VA = "0x182937290")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> DKNKKIFGMHH(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2937190", Offset = "0x2935D90", VA = "0x182937190")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> DFFBDEJPAGB(this JOOGONCAGGO LAAPKLDJLPE, float HLPEBKMLKLE, float MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x29360D0", Offset = "0x2934CD0", VA = "0x1829360D0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> BIFDPOEOMIF(this JOOGONCAGGO LAAPKLDJLPE, float HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x29379F0", Offset = "0x29365F0", VA = "0x1829379F0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EKLOAICLJOB(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2938D00", Offset = "0x2937900", VA = "0x182938D00")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> JKELNKDGKEO(this JOOGONCAGGO LAAPKLDJLPE, int HLPEBKMLKLE, int MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2939A30", Offset = "0x2938630", VA = "0x182939A30")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> LBMINMAIPKD(this JOOGONCAGGO LAAPKLDJLPE, int HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x29376F0", Offset = "0x29362F0", VA = "0x1829376F0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EAPJPKIADMD(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2939750", Offset = "0x2938350", VA = "0x182939750")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> KNHLPCONLNN(this JOOGONCAGGO LAAPKLDJLPE, float HLPEBKMLKLE, float MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2937550", Offset = "0x2936150", VA = "0x182937550")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> DOELGOCOPDE(this JOOGONCAGGO LAAPKLDJLPE, float HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2937210", Offset = "0x2935E10", VA = "0x182937210")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> DIDJMJAAKGD(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2939570", Offset = "0x2938170", VA = "0x182939570")]
	public static IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> KLALDODFECG(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x293AFD0", Offset = "0x2939BD0", VA = "0x18293AFD0")]
	public static IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> PODIJDFCPPL(this JOOGONCAGGO LAAPKLDJLPE, int OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2937F80", Offset = "0x2936B80", VA = "0x182937F80")]
	public static IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> FKIMHCBLPLN(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x293AB90", Offset = "0x2939790", VA = "0x18293AB90")]
	public static IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> OMLKAFJNGEL(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> PEPDBKBLPNM)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x29367B0", Offset = "0x29353B0", VA = "0x1829367B0")]
	public static IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> CFJJCIMAONO(this JOOGONCAGGO LAAPKLDJLPE, int OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2935C90", Offset = "0x2934890", VA = "0x182935C90")]
	public static IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> ACPPBIGNDCF(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2938FE0", Offset = "0x2937BE0", VA = "0x182938FE0")]
	public static (IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>) KDNNCHAMENC(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<OIFGIPCOJFI> BBGAEEPMEBH, [In] ReadOnlySpan<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> HNMKHBLHFDD, [In] ReadOnlySpan<int?> AJNNEONCHDN, [In] Span<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> EALOADEEDNE)
	{
		return default((IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2936150", Offset = "0x2934D50", VA = "0x182936150")]
	public static (IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>) BNCOCGNLKDN(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GHCHPNLGLBH> DBEPMHACJGL, [In] ReadOnlySpan<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> HNMKHBLHFDD, [In] ReadOnlySpan<int?> AJNNEONCHDN, [In] Span<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> EALOADEEDNE)
	{
		return default((IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x38F15B0", Offset = "0x38F01B0", VA = "0x1838F15B0")]
	public static (IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<EALKCLEEIPA>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<TMarker>>, IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>) PLFINBEGDGM<TMarker>(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<EALKCLEEIPA> LOODKCMJMMK, [In] ReadOnlySpan<byte> PEDMEJIDLNB)
	{
		return default((IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<FBBBJKHBBDB<EALKCLEEIPA>>, IKLALLBKLKC<FBBBJKHBBDB<AHBNIAOBGCP>>, IKLALLBKLKC<FBBBJKHBBDB<TMarker>>, IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2938760", Offset = "0x2937360", VA = "0x182938760")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> IOLGBJKIMPC(this JOOGONCAGGO LAAPKLDJLPE, int BBKPJEIDMDD, [Optional] IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>? HKLMEDDFFBN)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x29365C0", Offset = "0x29351C0", VA = "0x1829365C0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> CEMIKCNIENK(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> BBKPJEIDMDD, [Optional] IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>? HKLMEDDFFBN)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x29368B0", Offset = "0x29354B0", VA = "0x1829368B0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> CLAFCENLIDG(this JOOGONCAGGO LAAPKLDJLPE, [In] ReadOnlySpan<byte> BBKPJEIDMDD, [Optional] IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>? HKLMEDDFFBN)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2938960", Offset = "0x2937560", VA = "0x182938960")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> JGGBJKKFIMK(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> BBKPJEIDMDD, int DKFJGBGJGBG, [Optional] IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>? HKLMEDDFFBN)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2939AB0", Offset = "0x29386B0", VA = "0x182939AB0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> LEAFAGIMLOL(this JOOGONCAGGO LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2935E30", Offset = "0x2934A30", VA = "0x182935E30")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> BCAALMJAMKO(this JOOGONCAGGO LAAPKLDJLPE, float HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x29397D0", Offset = "0x29383D0", VA = "0x1829397D0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> KNIKONAIMIM(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2937310", Offset = "0x2935F10", VA = "0x182937310")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> DLGOBJOKLJK(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2938D80", Offset = "0x2937980", VA = "0x182938D80")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> JNCEILDEEHI(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2937410", Offset = "0x2936010", VA = "0x182937410")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> DNPBKHNKNMM(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2936830", Offset = "0x2935430", VA = "0x182936830")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> CGBBCGNBOOI(this JOOGONCAGGO LAAPKLDJLPE, int HLPEBKMLKLE, int MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x293A0B0", Offset = "0x2938CB0", VA = "0x18293A0B0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MCPDBGPNKBC(this JOOGONCAGGO LAAPKLDJLPE, int HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2939BB0", Offset = "0x29387B0", VA = "0x182939BB0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> LKDPGFIMJND(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HLPEBKMLKLE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MAELALMKOEM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2936D60", Offset = "0x2935960", VA = "0x182936D60")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> CNJGOPHHPON(this JOOGONCAGGO LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2936F60", Offset = "0x2935B60", VA = "0x182936F60")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> CPEAHOJMBGN(this JOOGONCAGGO LAAPKLDJLPE, float HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x29384E0", Offset = "0x29370E0", VA = "0x1829384E0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> GOMKDBDODBI(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2939FB0", Offset = "0x2938BB0", VA = "0x182939FB0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> MCNGBKIJDOK(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x29375D0", Offset = "0x29361D0", VA = "0x1829375D0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> DPIIIFGIHOA(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2938260", Offset = "0x2936E60", VA = "0x182938260")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> GHMEKCGCOBG(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2937770", Offset = "0x2936370", VA = "0x182937770")]
	public static IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>> EHEGDCPPBDA(this JOOGONCAGGO LAAPKLDJLPE)
	{
		return default(IKLALLBKLKC<FBBBJKHBBDB<FBBBJKHBBDB<CHFJELKDJEN>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2938160", Offset = "0x2936D60", VA = "0x182938160")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> GHDIMIBOLKI(this JOOGONCAGGO LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2939D50", Offset = "0x2938950", VA = "0x182939D50")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> LPONHPOIPAE(this JOOGONCAGGO LAAPKLDJLPE, float HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2938A80", Offset = "0x2937680", VA = "0x182938A80")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> JHHOPCBNCIO(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x29366B0", Offset = "0x29352B0", VA = "0x1829366B0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> CFDPOLENGBF(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x293A270", Offset = "0x2938E70", VA = "0x18293A270")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> NEPIBODFEPF(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x29383A0", Offset = "0x2936FA0", VA = "0x1829383A0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> GMNNAEBENGI(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2937B80", Offset = "0x2936780", VA = "0x182937B80")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> FIIONNIFOIO(this JOOGONCAGGO LAAPKLDJLPE, int OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2937A70", Offset = "0x2936670", VA = "0x182937A70")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> FDOJGBCOAMP(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> OOHGFGHCOAJ)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2938750", Offset = "0x2937350", VA = "0x182938750")]
	public static void IOANMPHBIJA(this JOOGONCAGGO LAAPKLDJLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2935F50", Offset = "0x2934B50", VA = "0x182935F50")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> BFDJPGKNEJH(this JOOGONCAGGO LAAPKLDJLPE, float HJGNALALCBH, float EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x293AA70", Offset = "0x2939670", VA = "0x18293AA70")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> OMAICNJILBC(this JOOGONCAGGO LAAPKLDJLPE, float HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2938020", Offset = "0x2936C20", VA = "0x182938020")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> FPCBONOJJMG(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x293A490", Offset = "0x2939090", VA = "0x18293A490")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> OADIOFOMCOK(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x293AD70", Offset = "0x2939970", VA = "0x18293AD70")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> ONJKAGDPJCA(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x293A130", Offset = "0x2938D30", VA = "0x18293A130")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> NAIODELDDDG(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x29369A0", Offset = "0x29355A0", VA = "0x1829369A0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> CNHCMDHKALA(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> EDDAIJAFGGA, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> HHMHJMLLIPM)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x293A870", Offset = "0x2939470", VA = "0x18293A870")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> OENLFLPHFDC(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, int EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x293A750", Offset = "0x2939350", VA = "0x18293A750")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> OCMDHJNPHMN(this JOOGONCAGGO LAAPKLDJLPE, int HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x29378B0", Offset = "0x29364B0", VA = "0x1829378B0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EIONKLOMKHB(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> HJGNALALCBH, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EHHJAGNGOON)
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x38EFCF0", Offset = "0x38EE8F0", VA = "0x1838EFCF0")]
	public static void KAEGLDAKICB<TDeps, TState>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TState DKILGKEHOLM, IKLALLBKLKC<OIFGIPCOJFI> BBGAEEPMEBH, [In] ReadOnlySpan<IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>> HKOGOKGLCBE, [In] ReadOnlySpan<int?> AJNNEONCHDN, [In] Span<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> EALOADEEDNE, [In] Span<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> CMIBAALDHDM, [In] ReadOnlySpan<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>?> BJJLPJJGOPE) where TDeps : notnull, MKPNDNMDMBE<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x38F0200", Offset = "0x38EEE00", VA = "0x1838F0200")]
	public static void LCJHADOLFGD<TDeps, TState>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TState DKILGKEHOLM, IKLALLBKLKC<GHCHPNLGLBH> PAGHHLHAGEE, [In] ReadOnlySpan<IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>> GCFGKBPIOMD, [In] ReadOnlySpan<int?> AJNNEONCHDN, [In] Span<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> EALOADEEDNE, [In] Span<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>> CMIBAALDHDM, [In] ReadOnlySpan<IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>?> BJJLPJJGOPE) where TDeps : notnull, MKPNDNMDMBE<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x38EEA60", Offset = "0x38ED660", VA = "0x1838EEA60")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EINDDBCANBE<TDeps, TState>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TState DKILGKEHOLM, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> EPHLHHADIGO, [Optional] IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>? HKLMEDDFFBN) where TDeps : notnull, MKPNDNMDMBE<TState> where TState : notnull
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x38EE630", Offset = "0x38ED230", VA = "0x1838EE630")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> AAKGDJJICKF<TDeps, TState>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TState DKILGKEHOLM, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> GJFDAKBKKLH, [Optional] IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>? HKLMEDDFFBN) where TDeps : notnull, MKPNDNMDMBE<TState> where TState : notnull
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x38EEC20", Offset = "0x38ED820", VA = "0x1838EEC20")]
	public static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> FBLAOIJMJOL<TDeps, TStateSys>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TStateSys MGBNKIFDPJA) where TDeps : notnull, MKPNDNMDMBE<TStateSys> where TStateSys : notnull
	{
		return default(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x38EEF90", Offset = "0x38EDB90", VA = "0x1838EEF90")]
	public static IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN> FGJPCLMLOMJ<TDeps, TStateSys>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TStateSys MGBNKIFDPJA) where TDeps : notnull, MKPNDNMDMBE<TStateSys> where TStateSys : notnull
	{
		return default(IKLALLBKLKC<HNHIAMBODKF.AJNHAFCLMBN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2938BC0", Offset = "0x29377C0", VA = "0x182938BC0")]
	public static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> JHKOPEJCPCF(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> HAAJDLAGIKM, IntPtr OMCJFBECNAA, IntPtr PMLBLINAJII)
	{
		return default(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2937C80", Offset = "0x2936880", VA = "0x182937C80")]
	public static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> FJPPIEBHGCL(this JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> MGPPFHIJNNJ, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> HBLCDKHHKHN, IntPtr HLIAAOBEBHF, IntPtr OKJHPNIGNBJ, IntPtr OPNIDIJBAOB, bool FECHGMPBHDN)
	{
		return default(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x38F0710", Offset = "0x38EF310", VA = "0x1838F0710")]
	public static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> LGBKJGFDMJA<TDeps, TState>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TState DKILGKEHOLM, IKLALLBKLKC<OIFGIPCOJFI> FNHENIMCKGM, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> MGPPFHIJNNJ, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> HBLCDKHHKHN, int? LBOHLHGBABD, [Optional] IntPtr AIDOJOLOGEC) where TDeps : notnull, MKPNDNMDMBE<TState> where TState : notnull
	{
		return default(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x38F08E0", Offset = "0x38EF4E0", VA = "0x1838F08E0")]
	private static IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> LGBKJGFDMJA<TDeps, TState>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TState DKILGKEHOLM, IKLALLBKLKC<OIFGIPCOJFI> FNHENIMCKGM, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> MGPPFHIJNNJ, IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG> HBLCDKHHKHN, int? LBOHLHGBABD) where TDeps : notnull, MKPNDNMDMBE<TState> where TState : notnull
	{
		return default(IKLALLBKLKC<KPMBHLBECNJ.IDKILNEHPHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x38EF2E0", Offset = "0x38EDEE0", VA = "0x1838EF2E0")]
	public static IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> GKFMIDABDGF<TDeps, TState>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TState DKILGKEHOLM, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> BBKPJEIDMDD, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>? HKLMEDDFFBN) where TDeps : notnull, MKPNDNMDMBE<TState> where TState : notnull
	{
		return default(IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x38F10D0", Offset = "0x38EFCD0", VA = "0x1838F10D0")]
	public static void MFEHDAJIKND<TDeps, TState>(this JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TState DKILGKEHOLM, int ECHHDCJFIBD) where TDeps : notnull, MKPNDNMDMBE<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct CNBDPJKCEOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> HLLFLFKDDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> FKMDEKOBBKI;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xDCF610", Offset = "0xDCE210", VA = "0x180DCF610")]
	public CNBDPJKCEOE(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> OHDJFGNMHKC, IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> OBOAHDMPJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2933710", Offset = "0x2932310", VA = "0x182933710")]
	public static CNBDPJKCEOE JHMOIFLKJAD(IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>> OHDJFGNMHKC)
	{
		return default(CNBDPJKCEOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct GGJKKDNFPFG
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class CAHIGGOJLKF : PMDPEEOJGBI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct ONCGAGOFLCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN> LDLFDIOBJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int FCJKCAOMEFN;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xDCF610", Offset = "0xDCE210", VA = "0x180DCF610")]
		public ONCGAGOFLCC(IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN> PKEJILNNPHF, int EMMACFPOKFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class LKJEIODMBGE : PMDPEEOJGBI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct DEFOPFGBJAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int FCJKCAOMEFN;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560")]
		public DEFOPFGBJAI(int EMMACFPOKFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class NJGEODGLODA : PMDPEEOJGBI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct FCOMHMNOKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN> LDLFDIOBJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int FCJKCAOMEFN;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xDCF610", Offset = "0xDCE210", VA = "0x180DCF610")]
		public FCOMHMNOKHK(IKLALLBKLKC<JKEIFDFFLJE.HCMJHBLJCIN> PKEJILNNPHF, int EMMACFPOKFB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum PAICLNKEKNE
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
	public sealed class BGNIAOMNPNM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class PMDPEEOJGBI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct KHHOBBCIJOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? INKPGELPKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CNBDPJKCEOE JIKDCELJOAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public PAICLNKEKNE HMDIPKAKOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public IKLALLBKLKC<PMDPEEOJGBI> BPEBPKAOAJP;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x293D0A0", Offset = "0x293BCA0", VA = "0x18293D0A0")]
		public KHHOBBCIJOF(int? EEBMPCLPPHA, [In] CNBDPJKCEOE KFBFFCEPPJJ, PAICLNKEKNE KIKGBMCKHBA, IKLALLBKLKC<PMDPEEOJGBI> GCMOMJGFGJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class CLCDKIFCIJP : PMDPEEOJGBI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct IEHLOIPBPJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int FCJKCAOMEFN;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560")]
		public IEHLOIPBPJP(int EMMACFPOKFB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal GFKDCKGHOGN<BGNIAOMNPNM, KHHOBBCIJOF> APKAJDDKFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal GFKDCKGHOGN<CAHIGGOJLKF, ONCGAGOFLCC> BKBCBNPFJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal GFKDCKGHOGN<NJGEODGLODA, FCOMHMNOKHK> OAHCKPFDHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal GFKDCKGHOGN<CLCDKIFCIJP, IEHLOIPBPJP> EHBGJCIBDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal GFKDCKGHOGN<LKJEIODMBGE, DEFOPFGBJAI> FOBOJICICCL;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x293B620", Offset = "0x293A220", VA = "0x18293B620")]
	private GGJKKDNFPFG([In] GFKDCKGHOGN<BGNIAOMNPNM, KHHOBBCIJOF> ILCPGOCMOEK, [In] GFKDCKGHOGN<CAHIGGOJLKF, ONCGAGOFLCC> CFLDBGCMDKB, [In] GFKDCKGHOGN<NJGEODGLODA, FCOMHMNOKHK> FGHINHCNKNC, [In] GFKDCKGHOGN<CLCDKIFCIJP, IEHLOIPBPJP> JMCMOJEMLLF, [In] GFKDCKGHOGN<LKJEIODMBGE, DEFOPFGBJAI> OHDLIMEJNOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x293B430", Offset = "0x293A030", VA = "0x18293B430")]
	public static GGJKKDNFPFG JHMOIFLKJAD()
	{
		return default(GGJKKDNFPFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class GBKIDEONMFN
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x293B2D0", Offset = "0x2939ED0", VA = "0x18293B2D0")]
	public static void AMAAGOMLOEN(this GGJKKDNFPFG LAAPKLDJLPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GHDCHEHAEMK
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x293B750", Offset = "0x293A350", VA = "0x18293B750")]
	public static void KNAKIDBGLNI(JOOGONCAGGO LAAPKLDJLPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct KIAJAPNCDFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, FMLFHOBGNDJ> APADDJENMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int JIKNFOABDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int CKNEDBLJMAA;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x293D300", Offset = "0x293BF00", VA = "0x18293D300")]
	private KIAJAPNCDFA([In] FKBNOJLBGKB<JKEIFDFFLJE.PHMNHGGMNHK, FMLFHOBGNDJ> HIPJPECFBLP, int BGJICNIMFGG, int EJGMBAELJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x293D290", Offset = "0x293BE90", VA = "0x18293D290")]
	public static KIAJAPNCDFA JHMOIFLKJAD()
	{
		return default(KIAJAPNCDFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x293D0C0", Offset = "0x293BCC0", VA = "0x18293D0C0")]
	public void AMAAGOMLOEN([In] JOOGONCAGGO GEKAHFAOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B65BE0", Offset = "0x3B647E0", VA = "0x183B65BE0")]
	public static void KNAKIDBGLNI<TDeps, TStateSys>(JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TStateSys MGBNKIFDPJA, IKLALLBKLKC<FNJCFKDMDPO> LMBLGALMBCI) where TDeps : notnull, MKPNDNMDMBE<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class BMJMEDJDEGD
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2933560", Offset = "0x2932160", VA = "0x182933560")]
	public static void KNAKIDBGLNI(JOOGONCAGGO LAAPKLDJLPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct ILHPKNLOGLG
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface KLJNBPAMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IIBJMNEICPL(MJLLGLFJCNK<byte> AINPEHPOKAD, int DLHOLOFDBLM);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct EBOEMFEAEAF : KLJNBPAMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x293B050", Offset = "0x2939C50", VA = "0x18293B050", Slot = "4")]
		public void IIBJMNEICPL(MJLLGLFJCNK<byte> AINPEHPOKAD, int DLHOLOFDBLM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct OJPKGCJJKFC : KLJNBPAMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x293DDE0", Offset = "0x293C9E0", VA = "0x18293DDE0", Slot = "4")]
		public void IIBJMNEICPL(MJLLGLFJCNK<byte> AINPEHPOKAD, int DLHOLOFDBLM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct PACGLKHBCHI : KLJNBPAMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x293DE80", Offset = "0x293CA80", VA = "0x18293DE80", Slot = "4")]
		public void IIBJMNEICPL(MJLLGLFJCNK<byte> AINPEHPOKAD, int DLHOLOFDBLM)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct APKBMFOHFGJ : KLJNBPAMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2932A70", Offset = "0x2931670", VA = "0x182932A70", Slot = "4")]
		public void IIBJMNEICPL(MJLLGLFJCNK<byte> AINPEHPOKAD, int DLHOLOFDBLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class ODGKHKECNIG<TCallProcessorDeps> where TCallProcessorDeps : struct, KLJNBPAMFIL
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps MPDEJFBBCAJ;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x421EF30", Offset = "0x421DB30", VA = "0x18421EF30")]
		public static int KNAKIDBGLNI<TDeps, TStateSys>(TDeps FCHJEFGMLNE, TStateSys DKILGKEHOLM, JOOGONCAGGO GEKAHFAOKFB, [In] MJLLGLFJCNK<byte> IGHMHBLOJAN, int KAJPEMGLPLH) where TDeps : MKPNDNMDMBE<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private MJLLGLFJCNK<APGDOJAOBND> ICHMADPPJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>> EMPAGPLGKKI;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x293BE40", Offset = "0x293AA40", VA = "0x18293BE40")]
	private ILHPKNLOGLG([In] MJLLGLFJCNK<APGDOJAOBND> FHPLFHLAADM, Dictionary<IKLALLBKLKC<FBBBJKHBBDB<CHFJELKDJEN>>, IKLALLBKLKC<JKEIFDFFLJE.PHMNHGGMNHK>> GOFLMMIOJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x293BD80", Offset = "0x293A980", VA = "0x18293BD80")]
	public static ILHPKNLOGLG JHMOIFLKJAD()
	{
		return default(ILHPKNLOGLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x293BD40", Offset = "0x293A940", VA = "0x18293BD40")]
	public void AMAAGOMLOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3B01CA0", Offset = "0x3B008A0", VA = "0x183B01CA0")]
	public static void KNAKIDBGLNI<TDeps, TStateSys>(JOOGONCAGGO LAAPKLDJLPE, TDeps FCHJEFGMLNE, TStateSys MGBNKIFDPJA) where TDeps : MKPNDNMDMBE<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class BGKHGGDNHJG
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct AGEPHEMNLDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> ELDJMBEFJAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int NHCDHIPJHND;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int PICEHGDMCHA;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int EJCGGPCHJMK;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2932C40", Offset = "0x2931840", VA = "0x182932C40")]
	public static void KNAKIDBGLNI(JOOGONCAGGO LAAPKLDJLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x29332F0", Offset = "0x2931EF0", VA = "0x1829332F0")]
	private static void LEFDDLOAJMD([In] JOOGONCAGGO LAAPKLDJLPE, IKLALLBKLKC<GGJKKDNFPFG.BGNIAOMNPNM> ALPNKEJICNA, MJLLGLFJCNK<byte> IPCFAEHDMFE, List<AGEPHEMNLDO> GLLFEEHBBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x29331B0", Offset = "0x2931DB0", VA = "0x1829331B0")]
	private static void LEFDDLOAJMD(MJLLGLFJCNK<byte> IPCFAEHDMFE, int DKFJGBGJGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2932B10", Offset = "0x2931710", VA = "0x182932B10")]
	private static void FKPDJFOIMBM(JOOGONCAGGO LAAPKLDJLPE, List<AGEPHEMNLDO> GLLFEEHBBOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class MBEGBOOAIJB<TDeps, TIndex, TValues> where TDeps : struct, JMFDMKCFLMM<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps MPDEJFBBCAJ;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x549A7E0", Offset = "0x54993E0", VA = "0x18549A7E0")]
	public static void KNAKIDBGLNI([In] MJLLGLFJCNK<APGDOJAOBND> FHPLFHLAADM, int AEIELADFFKL, TValues AIPJHMCGMIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface JMFDMKCFLMM<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJLLGLFJCNK<TIndex> KCEHFDCDCMF(int AEIELADFFKL, [In] TValues AIPJHMCGMIB);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(TIndex EMMACFPOKFB, [In] TValues AIPJHMCGMIB);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAFGCIHDBGE(TIndex EMMACFPOKFB, TValues AIPJHMCGMIB, IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> OOHGFGHCOAJ);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface AEGGBOPKKPN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex KBCGCOOEJNG(int EMMACFPOKFB);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JDBNJCPDMFM(TIndex EMMACFPOKFB, [In] TValues AIPJHMCGMIB);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IKLALLBKLKC<FBBBJKHBBDB<OICBEJIKPDD>> MDPBIBIPLAG(TIndex EMMACFPOKFB, [In] TValues AIPJHMCGMIB);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BOHNAMNBPFJ<TDeps, TIndex, TValues> where TDeps : struct, AEGGBOPKKPN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps MPDEJFBBCAJ;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x661F410", Offset = "0x661E010", VA = "0x18661F410")]
	public static MJLLGLFJCNK<TIndex> KNAKIDBGLNI(int AEIELADFFKL, [In] TValues AIPJHMCGMIB)
	{
		return default(MJLLGLFJCNK<TIndex>);
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
