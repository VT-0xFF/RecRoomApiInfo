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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x216BD30", Offset = "0x216A730", VA = "0x18216BD30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct IBFKAGHMKJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> OKJGINENODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int FINIPIMGMHL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9C0C50", Offset = "0x9BF650", VA = "0x1809C0C50")]
	public IBFKAGHMKJI(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> DBFNEOCMANL, int IEHCONIHMPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DKJPMNNDPDB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class PHBCEINHLNM : PEFBKAEADGB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct GHFIJLBBBED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly LIHFOMABAPF<byte> LLPJDGLJBKJ;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2120150", Offset = "0x211EB50", VA = "0x182120150")]
		public GHFIJLBBBED(LIHFOMABAPF<byte> CNGBPDKMHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21680B0", Offset = "0x2166AB0", VA = "0x1821680B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class LCPOILLEKCO : PEFBKAEADGB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct GNAJJNELPNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> ALPBNPFNEKK;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
		public GNAJJNELPNJ(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> EDPFGKBAOKN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum EAGKLJPDCLF
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
	public sealed class NGMHCBCFFHF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PEFBKAEADGB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct JDDDONAPMHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly EAGKLJPDCLF PFPGPLAGBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly MJGAEDNBJIL<PEFBKAEADGB> BDBODELCKAL;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C50", Offset = "0x9BF650", VA = "0x1809C0C50")]
		public JDDDONAPMHE(EAGKLJPDCLF KNOOGPPOFML, MJGAEDNBJIL<PEFBKAEADGB> GGEHCDLEHMP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class IEKCLPEMKDG : PEFBKAEADGB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct OAADMONIDPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MEGDIAKKDLM;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
		public OAADMONIDPL(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class CBMENFKJMNI : PEFBKAEADGB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct LPDJNGLHGFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly POJKEEADMGJ PMFBIEEKLAB;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
		public LPDJNGLHGFH(POJKEEADMGJ JKGJADKACPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x216B210", Offset = "0x2169C10", VA = "0x18216B210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal NDBKODFDANE<NGMHCBCFFHF, JDDDONAPMHE> KHFJKDKICOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal NDBKODFDANE<PHBCEINHLNM, GHFIJLBBBED> EHFEEGOEILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal NDBKODFDANE<LCPOILLEKCO, GNAJJNELPNJ> JMKNKBFPCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal NDBKODFDANE<IEKCLPEMKDG, OAADMONIDPL> FBJOHOBGPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal NDBKODFDANE<CBMENFKJMNI, LPDJNGLHGFH> OFFBPFNHFEN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x21674D0", Offset = "0x2165ED0", VA = "0x1821674D0")]
	private DKJPMNNDPDB([In] NDBKODFDANE<NGMHCBCFFHF, JDDDONAPMHE> OCCICMDPMFD, [In] NDBKODFDANE<PHBCEINHLNM, GHFIJLBBBED> GAPFNBOOPHE, [In] NDBKODFDANE<LCPOILLEKCO, GNAJJNELPNJ> MMLAPPHKPIF, [In] NDBKODFDANE<IEKCLPEMKDG, OAADMONIDPL> HPPJGFCGJDE, [In] NDBKODFDANE<CBMENFKJMNI, LPDJNGLHGFH> OENNDONOOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2167390", Offset = "0x2165D90", VA = "0x182167390")]
	public static DKJPMNNDPDB GGBAHLJJLHO()
	{
		return default(DKJPMNNDPDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IHIDDKDLKCO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x216ABC0", Offset = "0x21695C0", VA = "0x18216ABC0")]
	public static void AGDCKPANMGG(this DKJPMNNDPDB BJNJBGHPMEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum KNLOGKNJOCN
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
public struct AKIPLOPCFBD
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class DNPFNGIDJCP : KBGIDILEDGL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ONNIDFMLAOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> KGFGKGBMAAF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
		public ONNIDFMLAOJ(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> BLGBBOOFFHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum AJDFBNPAIKI
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
	public sealed class BBBOHFAGDBF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class KBGIDILEDGL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct EIAAPIGALFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly AJDFBNPAIKI PFPGPLAGBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly MJGAEDNBJIL<KBGIDILEDGL> BDBODELCKAL;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C50", Offset = "0x9BF650", VA = "0x1809C0C50")]
		public EIAAPIGALFJ(AJDFBNPAIKI KNOOGPPOFML, MJGAEDNBJIL<KBGIDILEDGL> GGEHCDLEHMP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal NDBKODFDANE<BBBOHFAGDBF, EIAAPIGALFJ> KHFJKDKICOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal NDBKODFDANE<DNPFNGIDJCP, ONNIDFMLAOJ> JLCDCPCICLP;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2161AF0", Offset = "0x21604F0", VA = "0x182161AF0")]
	private AKIPLOPCFBD([In] NDBKODFDANE<BBBOHFAGDBF, EIAAPIGALFJ> OCCICMDPMFD, [In] NDBKODFDANE<DNPFNGIDJCP, ONNIDFMLAOJ> ONHFDJCFCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2161A60", Offset = "0x2160460", VA = "0x182161A60")]
	public static AKIPLOPCFBD GGBAHLJJLHO()
	{
		return default(AKIPLOPCFBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NLJBILNJION
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x216B9C0", Offset = "0x216A3C0", VA = "0x18216B9C0")]
	public static void AGDCKPANMGG(this AKIPLOPCFBD BJNJBGHPMEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NMOLOKKKNHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public JEJGNFFBHBC<int> HOHEJPABMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public JEJGNFFBHBC<int> OIINAEPLLFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int NAFDNDCEFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int BKJFFOICCNL;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x216BCD0", Offset = "0x216A6D0", VA = "0x18216BCD0")]
	private NMOLOKKKNHP([In] JEJGNFFBHBC<int> BBPDFCOBPLJ, [In] JEJGNFFBHBC<int> IAHOGGLKEFM, int OGHNEHMAFOP, int FHJKCCBLDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x216BC30", Offset = "0x216A630", VA = "0x18216BC30")]
	public static NMOLOKKKNHP GGBAHLJJLHO()
	{
		return default(NMOLOKKKNHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class FLPBJKJPFGM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2167E70", Offset = "0x2166870", VA = "0x182167E70")]
	public static void AGDCKPANMGG(this NMOLOKKKNHP BJNJBGHPMEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct EOPHNKNAFPB
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum IIFIPLIFBPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class NNFNIHFFHPI : POMGAMHDDOA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct OIIADMGBEPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly MJGAEDNBJIL<CAFFJCLHNIB> KCAOLIPDGJB;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
		public OIIADMGBEPG(MJGAEDNBJIL<CAFFJCLHNIB> BPCJOPJOKMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class HHMAGFAOEKE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class POMGAMHDDOA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct PNLDAFADNOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly IIFIPLIFBPI PFPGPLAGBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly MJGAEDNBJIL<POMGAMHDDOA> BDBODELCKAL;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C50", Offset = "0x9BF650", VA = "0x1809C0C50")]
		private PNLDAFADNOH(IIFIPLIFBPI KNOOGPPOFML, MJGAEDNBJIL<POMGAMHDDOA> GGEHCDLEHMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x216CC80", Offset = "0x216B680", VA = "0x18216CC80")]
		public static PNLDAFADNOH GGBAHLJJLHO(IIFIPLIFBPI KNOOGPPOFML, MJGAEDNBJIL<POMGAMHDDOA> GGEHCDLEHMP)
		{
			return default(PNLDAFADNOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class LJCCNGENPHM : POMGAMHDDOA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct KOGEBNLPILI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly MJGAEDNBJIL<CAFFJCLHNIB> KCAOLIPDGJB;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
		public KOGEBNLPILI(MJGAEDNBJIL<CAFFJCLHNIB> BPCJOPJOKMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class CAFFJCLHNIB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct LGBKLKHNOOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public JEJGNFFBHBC<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> JGJEOCCAODC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public JEJGNFFBHBC<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> MCAPKPIKDAG;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2161AF0", Offset = "0x21604F0", VA = "0x182161AF0")]
		private LGBKLKHNOOL([In] JEJGNFFBHBC<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> GLMADGBENON, [In] JEJGNFFBHBC<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> JFKMGGLMMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x216B110", Offset = "0x2169B10", VA = "0x18216B110")]
		public static LGBKLKHNOOL GGBAHLJJLHO()
		{
			return default(LGBKLKHNOOL);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal NDBKODFDANE<HHMAGFAOEKE, PNLDAFADNOH> KHFJKDKICOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal NDBKODFDANE<LJCCNGENPHM, KOGEBNLPILI> FGCHJMOEGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal NDBKODFDANE<NNFNIHFFHPI, OIIADMGBEPG> EOBONAJHKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal JEJGNFFBHBC<(MJGAEDNBJIL<HHMAGFAOEKE> CallId, MJGAEDNBJIL<CAFFJCLHNIB> IOId)> DKAFKPDMCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal NDBKODFDANE<CAFFJCLHNIB, LGBKLKHNOOL> LPEGELOPJMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal EEPBGMDANNB<CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> PHFDDKOMBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal EEPBGMDANNB<CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> FDGKNJFBKNM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2167A20", Offset = "0x2166420", VA = "0x182167A20")]
	private EOPHNKNAFPB([In] NDBKODFDANE<HHMAGFAOEKE, PNLDAFADNOH> OCCICMDPMFD, [In] NDBKODFDANE<LJCCNGENPHM, KOGEBNLPILI> GOPMKMEEPMM, [In] NDBKODFDANE<NNFNIHFFHPI, OIIADMGBEPG> ALBKLHKDGNJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<HHMAGFAOEKE> CallId, MJGAEDNBJIL<CAFFJCLHNIB> IOId)> BNAHIGKIHCL, [In] NDBKODFDANE<CAFFJCLHNIB, LGBKLKHNOOL> MIBFDDHNHNO, [In] EEPBGMDANNB<CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> JDJOCGIFGLD, [In] EEPBGMDANNB<CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> LDGLJHMOKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2167880", Offset = "0x2166280", VA = "0x182167880")]
	public static EOPHNKNAFPB GGBAHLJJLHO()
	{
		return default(EOPHNKNAFPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FGBJHDPLIFB
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2167C10", Offset = "0x2166610", VA = "0x182167C10")]
	private static void AGDCKPANMGG(this EOPHNKNAFPB.LGBKLKHNOOL BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2167C60", Offset = "0x2166660", VA = "0x182167C60")]
	public static void AGDCKPANMGG(this EOPHNKNAFPB BJNJBGHPMEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct OABHMKKJHIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public JEJGNFFBHBC<byte> ECGLEHCJBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal EOPHNKNAFPB KIFAMDMDDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal DLJMAJKPJFE LPOMLKEPLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> EBLIINGKNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal DKJPMNNDPDB HBIPNBJNIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal AKIPLOPCFBD OHNFGECHIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal EEPBGMDANNB<POKJECOIACH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>?> GHLIBLFBJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal JEJGNFFBHBC<MJGAEDNBJIL<POKJECOIACH>> BEEDGIMKKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> AGJCHABFKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> DPLOLBBGBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> GJAEEFFJBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal ANIACHIBHKF CLOJMEMEJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal IBJMLJGEDOA FJODJKCOPFJ;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x216C870", Offset = "0x216B270", VA = "0x18216C870")]
	private OABHMKKJHIF([In] JEJGNFFBHBC<byte> NJPPNJMNAMC, [In] EOPHNKNAFPB LAICLHKHLKA, [In] DLJMAJKPJFE HIJCDBFBMKB, [In] DKJPMNNDPDB HDMNOEBMCHC, [In] AKIPLOPCFBD KBPAAOJKBAN, [In] EEPBGMDANNB<POKJECOIACH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>?> FACJANHMCCL, [In] JEJGNFFBHBC<MJGAEDNBJIL<POKJECOIACH>> GNIMIGCFLLC, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> KLFMEBLPBIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ENBIKFLEBBI, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> FFIPGIGFEPL, [In] ANIACHIBHKF GOLFCALPEBN, [In] IBJMLJGEDOA HLJMGLLFHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x216BDB0", Offset = "0x216A7B0", VA = "0x18216BDB0")]
	public static OABHMKKJHIF GGBAHLJJLHO()
	{
		return default(OABHMKKJHIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class HLMKFAPIBNL
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct NDEJECHABML : OJKCGPLAMHG<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>, EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x216B700", Offset = "0x216A100", VA = "0x18216B700")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x216B7C0", Offset = "0x216A1C0", VA = "0x18216B7C0", Slot = "4")]
		public MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0")]
		public bool OPHJDAMMNNH(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "5")]
		private bool CNIBNHPBMKG(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x216B7B0", Offset = "0x216A1B0", VA = "0x18216B7B0", Slot = "6")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> ENPDGBPPKCH(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct FPDMHOHGJLO : HICOKGMCEFJ<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>, EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2168030", Offset = "0x2166A30", VA = "0x182168030")]
		public JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2167EC0", Offset = "0x21668C0", VA = "0x182167EC0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2167F70", Offset = "0x2166970", VA = "0x182167F70", Slot = "6")]
		public void FMHGLADJLPJ(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2168030", Offset = "0x2166A30", VA = "0x182168030", Slot = "4")]
		private JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>> LBBAJFIHGPJ(int LBNMKJDAMIJ, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x21680A0", Offset = "0x2166AA0", VA = "0x1821680A0", Slot = "5")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> NDPCEGLNPJE(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct JGADBOPCDCL : OJKCGPLAMHG<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>, EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x216AE90", Offset = "0x2169890", VA = "0x18216AE90")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x216AF50", Offset = "0x2169950", VA = "0x18216AF50", Slot = "4")]
		public MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0")]
		public bool OPHJDAMMNNH(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "5")]
		private bool ECNDPJGKPHK(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x216AF40", Offset = "0x2169940", VA = "0x18216AF40", Slot = "6")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> FIGNMMFKJPB(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct MKENJEBOBGB : HICOKGMCEFJ<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>, EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x216B460", Offset = "0x2169E60", VA = "0x18216B460")]
		public JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x216B4E0", Offset = "0x2169EE0", VA = "0x18216B4E0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x216B590", Offset = "0x2169F90", VA = "0x18216B590", Slot = "6")]
		public void FMHGLADJLPJ(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x216B460", Offset = "0x2169E60", VA = "0x18216B460", Slot = "4")]
		private JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>> APILHLJMBNI(int LBNMKJDAMIJ, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x216B4D0", Offset = "0x2169ED0", VA = "0x18216B4D0", Slot = "5")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BBHKBFKDGCD(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct KINMFBEJECH : OJKCGPLAMHG<MJGAEDNBJIL<OIEHBMHNIBK>, EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x216AF80", Offset = "0x2169980", VA = "0x18216AF80")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x216B0E0", Offset = "0x2169AE0", VA = "0x18216B0E0", Slot = "4")]
		public MJGAEDNBJIL<OIEHBMHNIBK> POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(MJGAEDNBJIL<OIEHBMHNIBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x216B060", Offset = "0x2169A60", VA = "0x18216B060")]
		public bool OPHJDAMMNNH(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x216B060", Offset = "0x2169A60", VA = "0x18216B060", Slot = "5")]
		private bool IJNFNHLKBJG(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x216B050", Offset = "0x2169A50", VA = "0x18216B050", Slot = "6")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> HBGACMNFDPL(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct MDAIFCBLGBF : HICOKGMCEFJ<MJGAEDNBJIL<OIEHBMHNIBK>, EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x216B240", Offset = "0x2169C40", VA = "0x18216B240")]
		public JEJGNFFBHBC<MJGAEDNBJIL<OIEHBMHNIBK>> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<OIEHBMHNIBK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x216B2B0", Offset = "0x2169CB0", VA = "0x18216B2B0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x216B380", Offset = "0x2169D80", VA = "0x18216B380", Slot = "6")]
		public void FMHGLADJLPJ(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x216B240", Offset = "0x2169C40", VA = "0x18216B240", Slot = "4")]
		private JEJGNFFBHBC<MJGAEDNBJIL<OIEHBMHNIBK>> BAMLAPKFBKK(int LBNMKJDAMIJ, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<OIEHBMHNIBK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x216B230", Offset = "0x2169C30", VA = "0x18216B230", Slot = "5")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> AHOGIOIPDKG(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct BFALDEKHLKE : OJKCGPLAMHG<int, JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2161DD0", Offset = "0x21607D0", VA = "0x182161DD0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9B9460", Offset = "0x9B7E60", VA = "0x1809B9460", Slot = "4")]
		public int POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0")]
		public bool OPHJDAMMNNH(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "5")]
		private bool DPMFJKNNNBK(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2161E70", Offset = "0x2160870", VA = "0x182161E70", Slot = "6")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> HJDFAKKEMGM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct JEMJGEKBJGK : HICOKGMCEFJ<int, JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x216AE10", Offset = "0x2169810", VA = "0x18216AE10")]
		public JEJGNFFBHBC<int> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x216AC70", Offset = "0x2169670", VA = "0x18216AC70")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x216AD10", Offset = "0x2169710", VA = "0x18216AD10", Slot = "6")]
		public void FMHGLADJLPJ(int HGFDMIDEFHN, JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x216AE10", Offset = "0x2169810", VA = "0x18216AE10", Slot = "4")]
		private JEJGNFFBHBC<int> LBAJEKCIDMF(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x216AE80", Offset = "0x2169880", VA = "0x18216AE80", Slot = "5")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> OHEDFEAGPMI(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct PJIMCBABMNJ : OJKCGPLAMHG<int, JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x216CBD0", Offset = "0x216B5D0", VA = "0x18216CBD0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9B9460", Offset = "0x9B7E60", VA = "0x1809B9460", Slot = "4")]
		public int POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0")]
		public bool OPHJDAMMNNH(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "5")]
		private bool IFFBJONHOJH(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x216CC70", Offset = "0x216B670", VA = "0x18216CC70", Slot = "6")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> EAILFHJMJJK(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct NMEJBEGNGIO : HICOKGMCEFJ<int, JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x216BA20", Offset = "0x216A420", VA = "0x18216BA20")]
		public JEJGNFFBHBC<int> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x216BA90", Offset = "0x216A490", VA = "0x18216BA90")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x216BB40", Offset = "0x216A540", VA = "0x18216BB40", Slot = "6")]
		public void FMHGLADJLPJ(int HGFDMIDEFHN, JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x216BA20", Offset = "0x216A420", VA = "0x18216BA20", Slot = "4")]
		private JEJGNFFBHBC<int> BNCBIFEPAKH(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x216BB30", Offset = "0x216A530", VA = "0x18216BB30", Slot = "5")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> DBIPDNBBHMJ(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct FBFBHMKEHIL : OJKCGPLAMHG<int, JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2167AE0", Offset = "0x21664E0", VA = "0x182167AE0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9B9460", Offset = "0x9B7E60", VA = "0x1809B9460", Slot = "4")]
		public int POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0")]
		public bool OPHJDAMMNNH(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8B27B0", Offset = "0x8B11B0", VA = "0x1808B27B0", Slot = "5")]
		private bool IFFBJONHOJH(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2167B80", Offset = "0x2166580", VA = "0x182167B80", Slot = "6")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> EAILFHJMJJK(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct BODCBDMAGPP : HICOKGMCEFJ<int, JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2161EA0", Offset = "0x21608A0", VA = "0x182161EA0")]
		public JEJGNFFBHBC<int> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2161F10", Offset = "0x2160910", VA = "0x182161F10")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2161FC0", Offset = "0x21609C0", VA = "0x182161FC0", Slot = "6")]
		public void FMHGLADJLPJ(int HGFDMIDEFHN, JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2161EA0", Offset = "0x21608A0", VA = "0x182161EA0", Slot = "4")]
		private JEJGNFFBHBC<int> BNCBIFEPAKH(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2161FB0", Offset = "0x21609B0", VA = "0x182161FB0", Slot = "5")]
		private MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> DBIPDNBBHMJ(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct BMELGLKLHFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> KJEEHHDJKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool ONCKFCMPBMD;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x164E120", Offset = "0x164CB20", VA = "0x18164E120")]
		public BMELGLKLHFM(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK, bool GCFBFNGDIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2161E90", Offset = "0x2160890", VA = "0x182161E90")]
		public void MMDHOICOGNG([Out] MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK, [Out] bool GCFBFNGDIDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct CBBAKAAKKFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly MJGAEDNBJIL<OIEHBMHNIBK> KBJJOJJHOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> KJEEHHDJKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool ONCKFCMPBMD;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x21620F0", Offset = "0x2160AF0", VA = "0x1821620F0")]
		public CBBAKAAKKFF(MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK, bool GCFBFNGDIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x21620C0", Offset = "0x2160AC0", VA = "0x1821620C0")]
		public void MMDHOICOGNG([Out] MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK, [Out] bool GCFBFNGDIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x21620D0", Offset = "0x2160AD0", VA = "0x1821620D0")]
		public void MMDHOICOGNG([Out] MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK, [Out] MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD, [Out] bool GCFBFNGDIDI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct BLEIFOJDBGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly MJGAEDNBJIL<OIEHBMHNIBK> KBJJOJJHOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> KJEEHHDJKHJ;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C50", Offset = "0x9BF650", VA = "0x1809C0C50")]
		public BLEIFOJDBGD(MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2161E80", Offset = "0x2160880", VA = "0x182161E80")]
		public void MMDHOICOGNG([Out] MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK, [Out] MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2168500", Offset = "0x2166F00", VA = "0x182168500")]
	public static void AGDCKPANMGG(this OABHMKKJHIF BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2169960", Offset = "0x2168360", VA = "0x182169960")]
	public static void HPLMEKKLAKG(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DBGAMICIANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2168A00", Offset = "0x2167400", VA = "0x182168A00")]
	public static void BKKBAPJJLLM(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DBGAMICIANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x216A510", Offset = "0x2168F10", VA = "0x18216A510")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>? PDMNCNAGHLC([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x21691B0", Offset = "0x2167BB0", VA = "0x1821691B0")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> DOAEMKKHFKK([In] this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x216A610", Offset = "0x2169010", VA = "0x18216A610")]
	private static void PGEIFEPHMAH(this OABHMKKJHIF BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x216A450", Offset = "0x2168E50", VA = "0x18216A450")]
	private static MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>? PCFGJGJFDBE([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2169BA0", Offset = "0x21685A0", VA = "0x182169BA0")]
	public static void KDFAIHPOOKA(this OABHMKKJHIF BJNJBGHPMEH, [In] JEJGNFFBHBC<IBFKAGHMKJI> FACOFPNKNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x21698E0", Offset = "0x21682E0", VA = "0x1821698E0")]
	public static DKJPMNNDPDB.EAGKLJPDCLF HNKGMMHAFHA([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(DKJPMNNDPDB.EAGKLJPDCLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2169F30", Offset = "0x2168930", VA = "0x182169F30")]
	public static LIHFOMABAPF<byte> LMMJLADCHGP([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(LIHFOMABAPF<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x216A020", Offset = "0x2168A20", VA = "0x18216A020")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MEONFBLEKDH([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2169DE0", Offset = "0x21687E0", VA = "0x182169DE0")]
	public static POJKEEADMGJ KPCENNBICPC([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2DDFFC0", Offset = "0x2DDE9C0", VA = "0x182DDFFC0")]
	private static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DFIHKDHMGPC<TMJoin>(this OABHMKKJHIF BJNJBGHPMEH, DKJPMNNDPDB.EAGKLJPDCLF KNOOGPPOFML, MJGAEDNBJIL<TMJoin> GGEHCDLEHMP) where TMJoin : DKJPMNNDPDB.PEFBKAEADGB
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x216A3D0", Offset = "0x2168DD0", VA = "0x18216A3D0")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> OPJOCKIMIDO(this OABHMKKJHIF BJNJBGHPMEH, bool PCGLLKCAJJA)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x21699F0", Offset = "0x21683F0", VA = "0x1821699F0")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> ICBCHFICLDH(this OABHMKKJHIF BJNJBGHPMEH, LIHFOMABAPF<byte> CNGBPDKMHBB)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2169130", Offset = "0x2167B30", VA = "0x182169130")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DNNKFCDAPEL(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> EDPFGKBAOKN)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2169620", Offset = "0x2168020", VA = "0x182169620")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> FDGHOGFBNBD(this OABHMKKJHIF BJNJBGHPMEH, int NLICHAIBNKJ)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2169B20", Offset = "0x2168520", VA = "0x182169B20")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> JALOKCBFOKL(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1550", Offset = "0x2DDFF50", VA = "0x182DE1550")]
	private static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> PDAFPJIBFFA<TMJoin>(this OABHMKKJHIF BJNJBGHPMEH, AKIPLOPCFBD.AJDFBNPAIKI KNOOGPPOFML, MJGAEDNBJIL<TMJoin> GGEHCDLEHMP) where TMJoin : AKIPLOPCFBD.KBGIDILEDGL
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2169AE0", Offset = "0x21684E0", VA = "0x182169AE0")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> JAFFGLFBCNP(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2169DA0", Offset = "0x21687A0", VA = "0x182169DA0")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> KOPLFMKONEG(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2168D40", Offset = "0x2167740", VA = "0x182168D40")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> CPCPGBKODID(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> BLGBBOOFFHI)
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x216A5D0", Offset = "0x2168FD0", VA = "0x18216A5D0")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> PEFNJFNFNGH(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2168AD0", Offset = "0x21674D0", VA = "0x182168AD0")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> BPCAFBCKJAP(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x216A110", Offset = "0x2168B10", VA = "0x18216A110")]
	public static EOPHNKNAFPB.IIFIPLIFBPI MGGPNFJGGJD([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> ALLAIHGJFJB)
	{
		return default(EOPHNKNAFPB.IIFIPLIFBPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2169720", Offset = "0x2168120", VA = "0x182169720")]
	public static FDGCEDOBPAL<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>, NPOPOFILLMJ<EOPHNKNAFPB.CAFFJCLHNIB>> FPGNIDDOKFE([In] this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(FDGCEDOBPAL<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>, NPOPOFILLMJ<EOPHNKNAFPB.CAFFJCLHNIB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2169390", Offset = "0x2167D90", VA = "0x182169390")]
	public static MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> EILAFEPCIOI([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> ALLAIHGJFJB)
	{
		return default(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x216A190", Offset = "0x2168B90", VA = "0x18216A190")]
	public static EOPHNKNAFPB.LGBKLKHNOOL NEJMMGHALJG([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> BPCJOPJOKMO)
	{
		return default(EOPHNKNAFPB.LGBKLKHNOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x21696A0", Offset = "0x21680A0", VA = "0x1821696A0")]
	public static EOPHNKNAFPB.LGBKLKHNOOL FNBIGOHFKMK(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> BPCJOPJOKMO)
	{
		return default(EOPHNKNAFPB.LGBKLKHNOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2DE14B0", Offset = "0x2DDFEB0", VA = "0x182DE14B0")]
	private static MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> MPKLEILLPEE<TMJoin>(this OABHMKKJHIF BJNJBGHPMEH, EOPHNKNAFPB.IIFIPLIFBPI KNOOGPPOFML, MJGAEDNBJIL<TMJoin> GGEHCDLEHMP) where TMJoin : EOPHNKNAFPB.POMGAMHDDOA
	{
		return default(MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2168330", Offset = "0x2166D30", VA = "0x182168330")]
	public static (MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>) AEJANKFICCC(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default((MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2168B80", Offset = "0x2167580", VA = "0x182168B80")]
	public static (MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>) CEGJKMAMBJN(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default((MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2169830", Offset = "0x2168230", VA = "0x182169830")]
	public static MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> GJNJFDAKEEE(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2169D10", Offset = "0x2168710", VA = "0x182169D10")]
	public static void KKEFBKGJPAJ(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> BPCJOPJOKMO, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> MLDAKFILAPO, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>> CEKHBCCPJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2DE05B0", Offset = "0x2DDEFB0", VA = "0x182DE05B0")]
	public static BMELGLKLHFM HOEJIIMBKEO<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD) where TDeps : DLHNIHAOCBJ<TStateSys>
	{
		return default(BMELGLKLHFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2DE1600", Offset = "0x2DE0000", VA = "0x182DE1600")]
	public static CBBAKAAKKFF PPFFIPDOGOK<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<BKFIMEBJLKC> JJLNKABMPOP, int DLKOGGNFIGC) where TDeps : DLHNIHAOCBJ<TStateSys>
	{
		return default(CBBAKAAKKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2DE0070", Offset = "0x2DDEA70", VA = "0x182DE0070")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>? GCKHPAPGHAO<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<BKFIMEBJLKC> JJLNKABMPOP, [In] ReadOnlySpan<int> ABIJPPAADCK, [In] Span<BLEIFOJDBGD> JMOBPLJAPBK) where TDeps : DLHNIHAOCBJ<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2DDF9F0", Offset = "0x2DDE3F0", VA = "0x182DDF9F0")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> AMOOGFJMMJD<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD) where TDeps : DLHNIHAOCBJ<TStateSys>
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x216A2E0", Offset = "0x2168CE0", VA = "0x18216A2E0")]
	public static DLJMAJKPJFE.HAHKDPHIMLK OKBKPKOLHLB([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return default(DLJMAJKPJFE.HAHKDPHIMLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x216A780", Offset = "0x2169180", VA = "0x18216A780")]
	public static DLJMAJKPJFE.CPIOCAABGFF PMOPCNMCHCK([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return default(DLJMAJKPJFE.CPIOCAABGFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2168910", Offset = "0x2167310", VA = "0x182168910")]
	public static DLJMAJKPJFE.CJJLFEDLPFA BBDJGPBEHFD([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return default(DLJMAJKPJFE.CJJLFEDLPFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2168DC0", Offset = "0x21677C0", VA = "0x182168DC0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CPHIBFEPKDP(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP, string KJPHMNNIMDP)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2169210", Offset = "0x2167C10", VA = "0x182169210")]
	public static DLJMAJKPJFE.AOBNJIMHOBC DPOAOPOJIJA([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return default(DLJMAJKPJFE.AOBNJIMHOBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2169870", Offset = "0x2168270", VA = "0x182169870")]
	public static DLJMAJKPJFE.OCIJHHEDLAM GKBKIIIJNOE([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return default(DLJMAJKPJFE.OCIJHHEDLAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2168B10", Offset = "0x2167510", VA = "0x182168B10")]
	public static int? CAPDHCCBHLE([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2DE04B0", Offset = "0x2DDEEB0", VA = "0x182DE04B0")]
	private static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GDKFHBHDILM<TMJoin>(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP, DLJMAJKPJFE.OCIJHHEDLAM KNOOGPPOFML, MJGAEDNBJIL<TMJoin> GGEHCDLEHMP) where TMJoin : DLJMAJKPJFE.LEHHFIKNBKN
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2169570", Offset = "0x2167F70", VA = "0x182169570")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> FCONFGNPLDM(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> ALLAIHGJFJB, int HGFDMIDEFHN)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2169A80", Offset = "0x2168480", VA = "0x182169A80")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> INHAKNGGKCA(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2168F50", Offset = "0x2167950", VA = "0x182168F50")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> DLLKHAJIBKC(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? HKHCMAAMHNC, int? NIFBFKNJPJP)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2169300", Offset = "0x2167D00", VA = "0x182169300")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> EHGPMFCEBFG(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP, int HGFDMIDEFHN)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2169ED0", Offset = "0x21688D0", VA = "0x182169ED0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> LDAGLLIDHME(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x21687D0", Offset = "0x21671D0", VA = "0x1821687D0")]
	public static void AJIDDNOIBBA(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> ALLAIHGJFJB, int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2168200", Offset = "0x2166C00", VA = "0x182168200")]
	public static void ABMOIOMECFE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF, int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x216A210", Offset = "0x2168C10", VA = "0x18216A210")]
	public static void OFFACHLIHOA(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x21690A0", Offset = "0x2167AA0", VA = "0x1821690A0")]
	public static void DNMJLKKANMG(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> LLMCGMPLMBL, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> JKBANFAFAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2169760", Offset = "0x2168160", VA = "0x182169760")]
	public static void GAIOBKBNCMI(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF, MJGAEDNBJIL<JEBGKIHAOOI<EKHPEIMOKCE>> CDEIDIPPKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2DE13E0", Offset = "0x2DDFDE0", VA = "0x182DE13E0")]
	public static void KPOPOIMKAAC<M>(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<M>>> CDEIDIPPKPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface DLHNIHAOCBJ<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MJGAEDNBJIL<PGDNFPGMBLK> PEJMJNBFKLM(TStateSys NKAKOJLAIAN);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MJGAEDNBJIL<PGDNFPGMBLK> ECDMDDHFOGC(TStateSys NKAKOJLAIAN);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MJGAEDNBJIL<PGDNFPGMBLK> GGMPHEDMHLM(TStateSys NKAKOJLAIAN);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MJGAEDNBJIL<PGDNFPGMBLK> NOCNFKKHPLA(TStateSys NKAKOJLAIAN);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> MAHGGCLPEFG(TStateSys NKAKOJLAIAN, OABHMKKJHIF IHDPPPBCPPN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> IIAKMFFEJNB(TStateSys NKAKOJLAIAN, OABHMKKJHIF IHDPPPBCPPN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CAOEGBPILDC(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MJGAEDNBJIL<POKJECOIACH> EFBILKDLHPO(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD, int POPPKCBMEOO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KNLOGKNJOCN KCCJIFPPKDP(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool CLMEFONFDDB(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int JKHPEAKKOHI(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LIHFOMABAPF<byte> NGNJKHGPAOF(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(LIHFOMABAPF<byte>, MJGAEDNBJIL<PGDNFPGMBLK>) DPPENDGKNEA(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int HOAEKDPBAGB(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MJGAEDNBJIL<OIEHBMHNIBK> MJCPBKIMGAG(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD, int DLKOGGNFIGC);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MJGAEDNBJIL<OIEHBMHNIBK> GKFACEKAHPO(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<BKFIMEBJLKC> JJLNKABMPOP, int DLKOGGNFIGC);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int JJPHPPOFBID(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? OOLGDOAPNOH(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, int HGFDMIDEFHN);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int BAEFDPBNDIB(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? KCEODNDBMBD(TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, int HGFDMIDEFHN);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class DCJNKBGNCGK
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA8F0", Offset = "0x2BA92F0", VA = "0x182BAA8F0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA?> IEHNALNAAEO<T, TOpInput, TOpOutput>(this OABHMKKJHIF BJNJBGHPMEH, T JDKMLCHPKLA, T AENKMLMFBAD, int JJJIHDNFNIB, IntPtr DLMFPIAEPPD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9300", Offset = "0x2BA7D00", VA = "0x182BA9300")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA?> APAEOILAIEI<T, TOpInput, TOpOutput>(this OABHMKKJHIF BJNJBGHPMEH, T JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD, int JJJIHDNFNIB, IntPtr DLMFPIAEPPD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2BAABF0", Offset = "0x2BA95F0", VA = "0x182BAABF0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA?> LENGECGEKGH<TOpInput, TOpOutput>(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD, int JJJIHDNFNIB, IntPtr DLMFPIAEPPD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2163620", Offset = "0x2162020", VA = "0x182163620")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GFJKFKBFMLH(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2162BA0", Offset = "0x21615A0", VA = "0x182162BA0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CLMBLEHADAI(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2165100", Offset = "0x2163B00", VA = "0x182165100")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KILEOGIPHJB(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2163CC0", Offset = "0x21626C0", VA = "0x182163CC0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HGKHFMFHBNO(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2165650", Offset = "0x2164050", VA = "0x182165650")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MAKOMFKDHOF(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2164D80", Offset = "0x2163780", VA = "0x182164D80")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KFAACMAHKGE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2162970", Offset = "0x2161370", VA = "0x182162970")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CIMNOLKHLLE(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x21663D0", Offset = "0x2164DD0", VA = "0x1821663D0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> OHFKBNENPJI(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2165240", Offset = "0x2163C40", VA = "0x182165240")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KMMKOEGKNCD(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2162410", Offset = "0x2160E10", VA = "0x182162410")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AKHDGLEGGGL(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, int AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2165770", Offset = "0x2164170", VA = "0x182165770")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCPJOCKEFDJ(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2165D40", Offset = "0x2164740", VA = "0x182165D40")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MOGOBKAKCMN(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2163DB0", Offset = "0x21627B0", VA = "0x182163DB0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HHLPGANEPMB(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, float AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2167080", Offset = "0x2165A80", VA = "0x182167080")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PKKGLANNNPP(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2166290", Offset = "0x2164C90", VA = "0x182166290")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> OEDKEDJLFFC(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2162650", Offset = "0x2161050", VA = "0x182162650")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> BOEMHLKFBOK(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, int AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2162390", Offset = "0x2160D90", VA = "0x182162390")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AIENNKDNIJK(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x21635A0", Offset = "0x2161FA0", VA = "0x1821635A0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> FPILLMKOHID(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2163190", Offset = "0x2161B90", VA = "0x182163190")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> EKEDMKJJJHC(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, float AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2162DB0", Offset = "0x21617B0", VA = "0x182162DB0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> COFNBNNICKE(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2163210", Offset = "0x2161C10", VA = "0x182163210")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> EMCOMIHBDCN(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2163F30", Offset = "0x2162930", VA = "0x182163F30")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HJLENCHEGFC(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, int AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2163C40", Offset = "0x2162640", VA = "0x182163C40")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HFNHBIMGOFK(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2166950", Offset = "0x2165350", VA = "0x182166950")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PBGNAJMDHHE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2163EB0", Offset = "0x21628B0", VA = "0x182163EB0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HIOHMBMDBGK(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, float AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2162100", Offset = "0x2160B00", VA = "0x182162100")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> ADMJMHIINAK(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2165420", Offset = "0x2163E20", VA = "0x182165420")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> LLKILJHOOOO(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2165E80", Offset = "0x2164880", VA = "0x182165E80")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> NLBLPOJELEB(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2166AD0", Offset = "0x21654D0", VA = "0x182166AD0")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> PFFGPPPKCCA(this OABHMKKJHIF BJNJBGHPMEH, int KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x21671B0", Offset = "0x2165BB0", VA = "0x1821671B0")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> PNOLFKEJIAG(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x21654A0", Offset = "0x2163EA0", VA = "0x1821654A0")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> LMKBENMJMEE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2163520", Offset = "0x2161F20", VA = "0x182163520")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> FLBGKNEKGPH(this OABHMKKJHIF BJNJBGHPMEH, int KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2165380", Offset = "0x2163D80", VA = "0x182165380")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> LKFALFJJHFB(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x21664F0", Offset = "0x2164EF0", VA = "0x1821664F0")]
	public static (MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>) PAGOIEDDHMH(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<GAPKMCGHPMH> MEFOHNKECKL, [In] ReadOnlySpan<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> GLMADGBENON, [In] ReadOnlySpan<int?> MDCODLCEJDI, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> ELJBPMGHBGE)
	{
		return default((MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x21641B0", Offset = "0x2162BB0", VA = "0x1821641B0")]
	public static (MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>) IKHKHGBOLJG(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<KNKIADDLFII> NIFAMGNOPOG, [In] ReadOnlySpan<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> GLMADGBENON, [In] ReadOnlySpan<int?> MDCODLCEJDI, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> ELJBPMGHBGE)
	{
		return default((MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2BAAD60", Offset = "0x2BA9760", VA = "0x182BAAD60")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<PGDNFPGMBLK>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<TMarker>>, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>) NBHPKGDFIJL<TMarker>(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<PGDNFPGMBLK> HKFLLKEMFPM, [In] ReadOnlySpan<byte> JGCMECODHDI)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<PGDNFPGMBLK>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<TMarker>>, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x21640D0", Offset = "0x2162AD0", VA = "0x1821640D0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HOOGOPENJGA(this OABHMKKJHIF BJNJBGHPMEH, int NEDJODMJOFF, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2164AA0", Offset = "0x21634A0", VA = "0x182164AA0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JMLBJNFMGEK(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NEDJODMJOFF, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2162CC0", Offset = "0x21616C0", VA = "0x182162CC0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CNJIFKMGCML(this OABHMKKJHIF BJNJBGHPMEH, [In] ReadOnlySpan<byte> NEDJODMJOFF, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2165890", Offset = "0x2164290", VA = "0x182165890")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MEBHCOPMNNF(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NEDJODMJOFF, int BHEAFIOEIAD, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x21669D0", Offset = "0x21653D0", VA = "0x1821669D0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PBNGJDEAKFL(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2164FE0", Offset = "0x21639E0", VA = "0x182164FE0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KHMKHAMCJJH(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2166150", Offset = "0x2164B50", VA = "0x182166150")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NPEBBJAGMIB(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x21622A0", Offset = "0x2160CA0", VA = "0x1821622A0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AHGIKKKDKMF(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2163070", Offset = "0x2161A70", VA = "0x182163070")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> DNIDIMOJJIA(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2162510", Offset = "0x2160F10", VA = "0x182162510")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> BGAMODIFMPJ(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x21626D0", Offset = "0x21610D0", VA = "0x1821626D0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> BPOCOFFAMHP(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, int AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2163290", Offset = "0x2161C90", VA = "0x182163290")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> FBAMKKAPBDL(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2163720", Offset = "0x2162120", VA = "0x182163720")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GGPEDNFOOBC(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2164C80", Offset = "0x2163680", VA = "0x182164C80")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KAAFPIJONJI(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2163B10", Offset = "0x2162510", VA = "0x182163B10")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HFDEGCONBMI(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x21637A0", Offset = "0x21621A0", VA = "0x1821637A0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GJEOGDFFJNC(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2164620", Offset = "0x2163020", VA = "0x182164620")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> IPJFFADCNGD(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2166030", Offset = "0x2164A30", VA = "0x182166030")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NMJJDAEIBHI(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x21639D0", Offset = "0x21623D0", VA = "0x1821639D0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HCAFNDAINMI(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2164190", Offset = "0x2162B90", VA = "0x182164190")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ICNHGCDHKBI(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2162870", Offset = "0x2161270", VA = "0x182162870")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CIKAGGHKPIP(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2162180", Offset = "0x2160B80", VA = "0x182162180")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AGDIMBLGPJF(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2162F30", Offset = "0x2161930", VA = "0x182162F30")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> DMHKLJDFOOJ(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2166C90", Offset = "0x2165690", VA = "0x182166C90")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PICNDEPMCOI(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2163FB0", Offset = "0x21629B0", VA = "0x182163FB0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HLCCGAGEBDP(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2164710", Offset = "0x2163110", VA = "0x182164710")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JCGNHNIINPP(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2163420", Offset = "0x2161E20", VA = "0x182163420")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> FIMEJFILBMH(this OABHMKKJHIF BJNJBGHPMEH, int KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2163310", Offset = "0x2161D10", VA = "0x182163310")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> FGBBDFOCBKB(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2162500", Offset = "0x2160F00", VA = "0x182162500")]
	public static void APFEAPAJCCH(this OABHMKKJHIF BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2162E30", Offset = "0x2161830", VA = "0x182162E30")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> DLLDKLMDAGG(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2164EC0", Offset = "0x21638C0", VA = "0x182164EC0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KGDNPNLHNED(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2166B50", Offset = "0x2165550", VA = "0x182166B50")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PHCPLAGMPNK(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2164B90", Offset = "0x2163590", VA = "0x182164B90")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JOHIGIGPDMA(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2162750", Offset = "0x2161150", VA = "0x182162750")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CGBCEMAIPJO(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2162A60", Offset = "0x2161460", VA = "0x182162A60")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CKOOMIHMKLA(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x21659B0", Offset = "0x21643B0", VA = "0x1821659B0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MEGDOLLFJPE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> MOFKFDNIBOB, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> JHOAAHCMKFA)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x21638E0", Offset = "0x21622E0", VA = "0x1821638E0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GNJOADKLFDD(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2164850", Offset = "0x2163250", VA = "0x182164850")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JGFNMMEJGFF(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2167250", Offset = "0x2165C50", VA = "0x182167250")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PPIEOLJGIAL(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2BA96A0", Offset = "0x2BA80A0", VA = "0x182BA96A0")]
	public static void CLHFDGBJMEE<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<GAPKMCGHPMH> MEFOHNKECKL, [In] ReadOnlySpan<MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>> PIKLLANPOHP, [In] ReadOnlySpan<int?> MDCODLCEJDI, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> ELJBPMGHBGE, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> BAMLAOIMFKE, [In] ReadOnlySpan<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>?> MDKAEFBLADA) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2BAAE60", Offset = "0x2BA9860", VA = "0x182BAAE60")]
	public static void NFHEEKDPDCB<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<KNKIADDLFII> OADEFMMDNAN, [In] ReadOnlySpan<MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>> BNEEODCMBOC, [In] ReadOnlySpan<int?> MDCODLCEJDI, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> ELJBPMGHBGE, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> BAMLAOIMFKE, [In] ReadOnlySpan<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>?> MDKAEFBLADA) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2BABE50", Offset = "0x2BAA850", VA = "0x182BABE50")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PFJCDHAJDAA<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HKHCMAAMHNC, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA0E0", Offset = "0x2BA8AE0", VA = "0x182BAA0E0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GOFIKDKODJC<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> BLGBBOOFFHI, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2BA90D0", Offset = "0x2BA7AD0", VA = "0x182BA90D0")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> AIJKPDDBCBI<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN) where TDeps : notnull, DLHNIHAOCBJ<TStateSys> where TStateSys : notnull
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9C40", Offset = "0x2BA8640", VA = "0x182BA9C40")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> DAODJLHEKFP<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN) where TDeps : notnull, DLHNIHAOCBJ<TStateSys> where TStateSys : notnull
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2164970", Offset = "0x2163370", VA = "0x182164970")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> JHBOOLDELGE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> PPFNFCBGHOA, IntPtr KPIBGHNADCG, IntPtr NPMACOGLFLF)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2166D80", Offset = "0x2165780", VA = "0x182166D80")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> PKGLNLDIEAD(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> GODNPGIDKJI, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DOJBMHHEBIN, IntPtr HNGGIMOOKAP, IntPtr IKPMCINFPBP, IntPtr PGFEABBNPHE, bool JJIIOPAIFIO)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB720", Offset = "0x2BAA120", VA = "0x182BAB720")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> OBKCEEABKIH<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<GAPKMCGHPMH> PEHJMENKLDP, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> GODNPGIDKJI, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DOJBMHHEBIN, int? BAPCDIMHAJJ, [Optional] IntPtr INIKMDDFKKE) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2BAB400", Offset = "0x2BA9E00", VA = "0x182BAB400")]
	private static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> OBKCEEABKIH<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<GAPKMCGHPMH> PEHJMENKLDP, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> GODNPGIDKJI, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DOJBMHHEBIN, int? BAPCDIMHAJJ) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2BAA540", Offset = "0x2BA8F40", VA = "0x182BAA540")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HKOLHLBFJKN<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NEDJODMJOFF, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA9E50", Offset = "0x2BA8850", VA = "0x182BA9E50")]
	public static void DNMMIANKKCJ<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, int EKMLJLAOIGI) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct HACNMLHBCIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> BOIFKJLJDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> FDCENKIONCG;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x9C0C50", Offset = "0x9BF650", VA = "0x1809C0C50")]
	public HACNMLHBCIC(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> EFBMMDLILFA, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> OCOMBJMNJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2168140", Offset = "0x2166B40", VA = "0x182168140")]
	public static HACNMLHBCIC GGBAHLJJLHO(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> EFBMMDLILFA)
	{
		return default(HACNMLHBCIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct DLJMAJKPJFE
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class AKDOCGAMCAP : LEHHFIKNBKN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct HAHKDPHIMLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> KGKIABLDENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int OAGDGHBELJN;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C50", Offset = "0x9BF650", VA = "0x1809C0C50")]
		public HAHKDPHIMLK(MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> ALLAIHGJFJB, int HGFDMIDEFHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class ELFHLCJGNNA : LEHHFIKNBKN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct CPIOCAABGFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int OAGDGHBELJN;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
		public CPIOCAABGFF(int HGFDMIDEFHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class MNJDABFMPGE : LEHHFIKNBKN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct CJJLFEDLPFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> KGKIABLDENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int OAGDGHBELJN;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9C0C50", Offset = "0x9BF650", VA = "0x1809C0C50")]
		public CJJLFEDLPFA(MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> ALLAIHGJFJB, int HGFDMIDEFHN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum OCIJHHEDLAM
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
	public sealed class EDDBLKHAOOA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class LEHHFIKNBKN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct GOACLLBBOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? KIPNLNELJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public HACNMLHBCIC MFLGFLLDFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public OCIJHHEDLAM PFPGPLAGBNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public MJGAEDNBJIL<LEHHFIKNBKN> BDBODELCKAL;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2168120", Offset = "0x2166B20", VA = "0x182168120")]
		public GOACLLBBOML(int? NIFBFKNJPJP, [In] HACNMLHBCIC DMNGNMGHMIB, OCIJHHEDLAM KNOOGPPOFML, MJGAEDNBJIL<LEHHFIKNBKN> GGEHCDLEHMP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class EJGGFDMLNJF : LEHHFIKNBKN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct AOBNJIMHOBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int OAGDGHBELJN;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xBBBFC0", Offset = "0xBBA9C0", VA = "0x180BBBFC0")]
		public AOBNJIMHOBC(int HGFDMIDEFHN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal COBDJKOAFAO<EDDBLKHAOOA, GOACLLBBOML> KHFJKDKICOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal COBDJKOAFAO<AKDOCGAMCAP, HAHKDPHIMLK> AMIOPIFAOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal COBDJKOAFAO<MNJDABFMPGE, CJJLFEDLPFA> PKNLLILKMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal COBDJKOAFAO<EJGGFDMLNJF, AOBNJIMHOBC> BANJCADGHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal COBDJKOAFAO<ELFHLCJGNNA, CPIOCAABGFF> ONJKHFHCAEF;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2167750", Offset = "0x2166150", VA = "0x182167750")]
	private DLJMAJKPJFE([In] COBDJKOAFAO<EDDBLKHAOOA, GOACLLBBOML> OCCICMDPMFD, [In] COBDJKOAFAO<AKDOCGAMCAP, HAHKDPHIMLK> FPAONECPGEH, [In] COBDJKOAFAO<MNJDABFMPGE, CJJLFEDLPFA> IJKHALFFDHK, [In] COBDJKOAFAO<EJGGFDMLNJF, AOBNJIMHOBC> NMJEIOOBGFP, [In] COBDJKOAFAO<ELFHLCJGNNA, CPIOCAABGFF> OBKBMDFIJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2167560", Offset = "0x2165F60", VA = "0x182167560")]
	public static DLJMAJKPJFE GGBAHLJJLHO()
	{
		return default(DLJMAJKPJFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NCHOBIEKAKG
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x216B650", Offset = "0x216A050", VA = "0x18216B650")]
	public static void AGDCKPANMGG(this DLJMAJKPJFE BJNJBGHPMEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class HPNMDGCJDCM
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x216A920", Offset = "0x2169320", VA = "0x18216A920")]
	public static void CKOMBPKHALD(OABHMKKJHIF BJNJBGHPMEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct ANIACHIBHKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, NMOLOKKKNHP> LELHFFMOGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int OJLJPAIHHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int GJJAPPKOELL;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2161D90", Offset = "0x2160790", VA = "0x182161D90")]
	private ANIACHIBHKF([In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, NMOLOKKKNHP> DFJKLFLBGLH, int DFGKCGEICPG, int JDJGHDBLECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2161D20", Offset = "0x2160720", VA = "0x182161D20")]
	public static ANIACHIBHKF GGBAHLJJLHO()
	{
		return default(ANIACHIBHKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2161B30", Offset = "0x2160530", VA = "0x182161B30")]
	public void AGDCKPANMGG([In] OABHMKKJHIF KOFICKKDIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x344BEF0", Offset = "0x344A8F0", VA = "0x18344BEF0")]
	public static void CKOMBPKHALD<TDeps, TStateSys>(OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK) where TDeps : notnull, DLHNIHAOCBJ<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NHDDDHLGGEN
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x216B7F0", Offset = "0x216A1F0", VA = "0x18216B7F0")]
	public static void CKOMBPKHALD(OABHMKKJHIF BJNJBGHPMEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct IBJMLJGEDOA
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface BDHLBFMFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DIJNOKEDNJP(JEJGNFFBHBC<byte> NJPPNJMNAMC, int GMLMJEFFEAA);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct FDMOMCFCODO : BDHLBFMFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2167B90", Offset = "0x2166590", VA = "0x182167B90", Slot = "4")]
		public void DIJNOKEDNJP(JEJGNFFBHBC<byte> NJPPNJMNAMC, int GMLMJEFFEAA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct HDMNLKFNAOJ : BDHLBFMFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2168150", Offset = "0x2166B50", VA = "0x182168150", Slot = "4")]
		public void DIJNOKEDNJP(JEJGNFFBHBC<byte> NJPPNJMNAMC, int GMLMJEFFEAA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct LMNLKNMNALO : BDHLBFMFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x216B190", Offset = "0x2169B90", VA = "0x18216B190", Slot = "4")]
		public void DIJNOKEDNJP(JEJGNFFBHBC<byte> NJPPNJMNAMC, int GMLMJEFFEAA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct HMHCNCLLHBE : BDHLBFMFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x216A870", Offset = "0x2169270", VA = "0x18216A870", Slot = "4")]
		public void DIJNOKEDNJP(JEJGNFFBHBC<byte> NJPPNJMNAMC, int GMLMJEFFEAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class HEIMJOIKEEI<TCallProcessorDeps> where TCallProcessorDeps : struct, BDHLBFMFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps FJKKNCLMNHM;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2B0B1A0", Offset = "0x2B09BA0", VA = "0x182B0B1A0")]
		public static int CKOMBPKHALD<TDeps, TStateSys>(TDeps LAKCFHGOLJA, TStateSys FDKAGJLJMPF, OABHMKKJHIF KOFICKKDIEG, [In] JEJGNFFBHBC<byte> LBHMBOGFIOB, int OGPKFMCBIAC) where TDeps : DLHNIHAOCBJ<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private JEJGNFFBHBC<IBFKAGHMKJI> LEADKOKFDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>> OOFBKFCIEDM;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x216AB80", Offset = "0x2169580", VA = "0x18216AB80")]
	private IBJMLJGEDOA([In] JEJGNFFBHBC<IBFKAGHMKJI> FACOFPNKNFL, Dictionary<MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>> PDDPGMFNAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x216AAC0", Offset = "0x21694C0", VA = "0x18216AAC0")]
	public static IBJMLJGEDOA GGBAHLJJLHO()
	{
		return default(IBJMLJGEDOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x216AA80", Offset = "0x2169480", VA = "0x18216AA80")]
	public void AGDCKPANMGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2DF1130", Offset = "0x2DEFB30", VA = "0x182DF1130")]
	public static void CKOMBPKHALD<TDeps, TStateSys>(OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN) where TDeps : DLHNIHAOCBJ<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class KFDFHGEFNBA<TDeps, TIndex, TValues> where TDeps : struct, HICOKGMCEFJ<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly TDeps FJKKNCLMNHM;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x441D9F0", Offset = "0x441C3F0", VA = "0x18441D9F0")]
	public static void CKOMBPKHALD([In] JEJGNFFBHBC<IBFKAGHMKJI> FACOFPNKNFL, int LBNMKJDAMIJ, TValues ICLOFOKMOJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface HICOKGMCEFJ<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JEJGNFFBHBC<TIndex> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] TValues ICLOFOKMOJF);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(TIndex HGFDMIDEFHN, [In] TValues ICLOFOKMOJF);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMHGLADJLPJ(TIndex HGFDMIDEFHN, TValues ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface OJKCGPLAMHG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex POBFLKKJCJL(int HGFDMIDEFHN);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OPHJDAMMNNH(TIndex HGFDMIDEFHN, [In] TValues ICLOFOKMOJF);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(TIndex HGFDMIDEFHN, [In] TValues ICLOFOKMOJF);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class FFCDMFOHPOG<TDeps, TIndex, TValues> where TDeps : struct, OJKCGPLAMHG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static readonly TDeps FJKKNCLMNHM;

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE9230", Offset = "0x3DE7C30", VA = "0x183DE9230")]
	public static JEJGNFFBHBC<TIndex> CKOMBPKHALD(int LBNMKJDAMIJ, [In] TValues ICLOFOKMOJF)
	{
		return default(JEJGNFFBHBC<TIndex>);
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
