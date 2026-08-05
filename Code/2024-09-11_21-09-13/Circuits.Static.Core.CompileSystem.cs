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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x20CA500", Offset = "0x20C8B00", VA = "0x1820CA500")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
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
	[Cpp2IlInjected.Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
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
		[Cpp2IlInjected.Address(RVA = "0x207F250", Offset = "0x207D850", VA = "0x18207F250")]
		public GHFIJLBBBED(LIHFOMABAPF<byte> CNGBPDKMHBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x20C6880", Offset = "0x20C4E80", VA = "0x1820C6880", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
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
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0")]
		public LPDJNGLHGFH(POJKEEADMGJ JKGJADKACPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x20C99E0", Offset = "0x20C7FE0", VA = "0x1820C99E0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x20C5CA0", Offset = "0x20C42A0", VA = "0x1820C5CA0")]
	private DKJPMNNDPDB([In] NDBKODFDANE<NGMHCBCFFHF, JDDDONAPMHE> OCCICMDPMFD, [In] NDBKODFDANE<PHBCEINHLNM, GHFIJLBBBED> GAPFNBOOPHE, [In] NDBKODFDANE<LCPOILLEKCO, GNAJJNELPNJ> MMLAPPHKPIF, [In] NDBKODFDANE<IEKCLPEMKDG, OAADMONIDPL> HPPJGFCGJDE, [In] NDBKODFDANE<CBMENFKJMNI, LPDJNGLHGFH> OENNDONOOPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x20C5B60", Offset = "0x20C4160", VA = "0x1820C5B60")]
	public static DKJPMNNDPDB GGBAHLJJLHO()
	{
		return default(DKJPMNNDPDB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IHIDDKDLKCO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x20C9390", Offset = "0x20C7990", VA = "0x1820C9390")]
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
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
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
	[Cpp2IlInjected.Address(RVA = "0x20C02C0", Offset = "0x20BE8C0", VA = "0x1820C02C0")]
	private AKIPLOPCFBD([In] NDBKODFDANE<BBBOHFAGDBF, EIAAPIGALFJ> OCCICMDPMFD, [In] NDBKODFDANE<DNPFNGIDJCP, ONNIDFMLAOJ> ONHFDJCFCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x20C0230", Offset = "0x20BE830", VA = "0x1820C0230")]
	public static AKIPLOPCFBD GGBAHLJJLHO()
	{
		return default(AKIPLOPCFBD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NLJBILNJION
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x20CA190", Offset = "0x20C8790", VA = "0x1820CA190")]
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
	[Cpp2IlInjected.Address(RVA = "0x20CA4A0", Offset = "0x20C8AA0", VA = "0x1820CA4A0")]
	private NMOLOKKKNHP([In] JEJGNFFBHBC<int> BBPDFCOBPLJ, [In] JEJGNFFBHBC<int> IAHOGGLKEFM, int OGHNEHMAFOP, int FHJKCCBLDPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x20CA400", Offset = "0x20C8A00", VA = "0x1820CA400")]
	public static NMOLOKKKNHP GGBAHLJJLHO()
	{
		return default(NMOLOKKKNHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class FLPBJKJPFGM
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x20C6640", Offset = "0x20C4C40", VA = "0x1820C6640")]
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
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
		private PNLDAFADNOH(IIFIPLIFBPI KNOOGPPOFML, MJGAEDNBJIL<POMGAMHDDOA> GGEHCDLEHMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x20CB450", Offset = "0x20C9A50", VA = "0x1820CB450")]
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
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C02C0", Offset = "0x20BE8C0", VA = "0x1820C02C0")]
		private LGBKLKHNOOL([In] JEJGNFFBHBC<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> GLMADGBENON, [In] JEJGNFFBHBC<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> JFKMGGLMMMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x20C98E0", Offset = "0x20C7EE0", VA = "0x1820C98E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20C61F0", Offset = "0x20C47F0", VA = "0x1820C61F0")]
	private EOPHNKNAFPB([In] NDBKODFDANE<HHMAGFAOEKE, PNLDAFADNOH> OCCICMDPMFD, [In] NDBKODFDANE<LJCCNGENPHM, KOGEBNLPILI> GOPMKMEEPMM, [In] NDBKODFDANE<NNFNIHFFHPI, OIIADMGBEPG> ALBKLHKDGNJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<HHMAGFAOEKE> CallId, MJGAEDNBJIL<CAFFJCLHNIB> IOId)> BNAHIGKIHCL, [In] NDBKODFDANE<CAFFJCLHNIB, LGBKLKHNOOL> MIBFDDHNHNO, [In] EEPBGMDANNB<CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> JDJOCGIFGLD, [In] EEPBGMDANNB<CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> LDGLJHMOKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x20C6050", Offset = "0x20C4650", VA = "0x1820C6050")]
	public static EOPHNKNAFPB GGBAHLJJLHO()
	{
		return default(EOPHNKNAFPB);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class FGBJHDPLIFB
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x20C63E0", Offset = "0x20C49E0", VA = "0x1820C63E0")]
	private static void AGDCKPANMGG(this EOPHNKNAFPB.LGBKLKHNOOL BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x20C6430", Offset = "0x20C4A30", VA = "0x1820C6430")]
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
	[Cpp2IlInjected.Address(RVA = "0x20CB040", Offset = "0x20C9640", VA = "0x1820CB040")]
	private OABHMKKJHIF([In] JEJGNFFBHBC<byte> NJPPNJMNAMC, [In] EOPHNKNAFPB LAICLHKHLKA, [In] DLJMAJKPJFE HIJCDBFBMKB, [In] DKJPMNNDPDB HDMNOEBMCHC, [In] AKIPLOPCFBD KBPAAOJKBAN, [In] EEPBGMDANNB<POKJECOIACH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>?> FACJANHMCCL, [In] JEJGNFFBHBC<MJGAEDNBJIL<POKJECOIACH>> GNIMIGCFLLC, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> KLFMEBLPBIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ENBIKFLEBBI, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> FFIPGIGFEPL, [In] ANIACHIBHKF GOLFCALPEBN, [In] IBJMLJGEDOA HLJMGLLFHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x20CA580", Offset = "0x20C8B80", VA = "0x1820CA580")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C9ED0", Offset = "0x20C84D0", VA = "0x1820C9ED0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x20C9F90", Offset = "0x20C8590", VA = "0x1820C9F90", Slot = "4")]
		public MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0")]
		public bool OPHJDAMMNNH(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "5")]
		private bool CNIBNHPBMKG(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x20C9F80", Offset = "0x20C8580", VA = "0x1820C9F80", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C6800", Offset = "0x20C4E00", VA = "0x1820C6800")]
		public JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x20C6690", Offset = "0x20C4C90", VA = "0x1820C6690")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x20C6740", Offset = "0x20C4D40", VA = "0x1820C6740", Slot = "6")]
		public void FMHGLADJLPJ(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x20C6800", Offset = "0x20C4E00", VA = "0x1820C6800", Slot = "4")]
		private JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>> LBBAJFIHGPJ(int LBNMKJDAMIJ, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x20C6870", Offset = "0x20C4E70", VA = "0x1820C6870", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C9660", Offset = "0x20C7C60", VA = "0x1820C9660")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x20C9720", Offset = "0x20C7D20", VA = "0x1820C9720", Slot = "4")]
		public MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0")]
		public bool OPHJDAMMNNH(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "5")]
		private bool ECNDPJGKPHK(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x20C9710", Offset = "0x20C7D10", VA = "0x1820C9710", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C9C30", Offset = "0x20C8230", VA = "0x1820C9C30")]
		public JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x20C9CB0", Offset = "0x20C82B0", VA = "0x1820C9CB0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x20C9D60", Offset = "0x20C8360", VA = "0x1820C9D60", Slot = "6")]
		public void FMHGLADJLPJ(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> HGFDMIDEFHN, EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x20C9C30", Offset = "0x20C8230", VA = "0x1820C9C30", Slot = "4")]
		private JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>> APILHLJMBNI(int LBNMKJDAMIJ, [In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x20C9CA0", Offset = "0x20C82A0", VA = "0x1820C9CA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C9750", Offset = "0x20C7D50", VA = "0x1820C9750")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x20C98B0", Offset = "0x20C7EB0", VA = "0x1820C98B0", Slot = "4")]
		public MJGAEDNBJIL<OIEHBMHNIBK> POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(MJGAEDNBJIL<OIEHBMHNIBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x20C9830", Offset = "0x20C7E30", VA = "0x1820C9830")]
		public bool OPHJDAMMNNH(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x20C9830", Offset = "0x20C7E30", VA = "0x1820C9830", Slot = "5")]
		private bool IJNFNHLKBJG(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x20C9820", Offset = "0x20C7E20", VA = "0x1820C9820", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C9A10", Offset = "0x20C8010", VA = "0x1820C9A10")]
		public JEJGNFFBHBC<MJGAEDNBJIL<OIEHBMHNIBK>> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<OIEHBMHNIBK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x20C9A80", Offset = "0x20C8080", VA = "0x1820C9A80")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x20C9B50", Offset = "0x20C8150", VA = "0x1820C9B50", Slot = "6")]
		public void FMHGLADJLPJ(MJGAEDNBJIL<OIEHBMHNIBK> HGFDMIDEFHN, EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x20C9A10", Offset = "0x20C8010", VA = "0x1820C9A10", Slot = "4")]
		private JEJGNFFBHBC<MJGAEDNBJIL<OIEHBMHNIBK>> BAMLAPKFBKK(int LBNMKJDAMIJ, [In] EEPBGMDANNB<OIEHBMHNIBK, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>?> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<MJGAEDNBJIL<OIEHBMHNIBK>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x20C9A00", Offset = "0x20C8000", VA = "0x1820C9A00", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C05A0", Offset = "0x20BEBA0", VA = "0x1820C05A0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9151D0", Offset = "0x9137D0", VA = "0x1809151D0", Slot = "4")]
		public int POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0")]
		public bool OPHJDAMMNNH(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "5")]
		private bool DPMFJKNNNBK(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x20C0640", Offset = "0x20BEC40", VA = "0x1820C0640", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C95E0", Offset = "0x20C7BE0", VA = "0x1820C95E0")]
		public JEJGNFFBHBC<int> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x20C9440", Offset = "0x20C7A40", VA = "0x1820C9440")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x20C94E0", Offset = "0x20C7AE0", VA = "0x1820C94E0", Slot = "6")]
		public void FMHGLADJLPJ(int HGFDMIDEFHN, JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x20C95E0", Offset = "0x20C7BE0", VA = "0x1820C95E0", Slot = "4")]
		private JEJGNFFBHBC<int> LBAJEKCIDMF(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> VariableId, MJGAEDNBJIL<JEBGKIHAOOI<EBDEMPHJNGG<DDFNPDLLDDI>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x20C9650", Offset = "0x20C7C50", VA = "0x1820C9650", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x20CB3A0", Offset = "0x20C99A0", VA = "0x1820CB3A0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9151D0", Offset = "0x9137D0", VA = "0x1809151D0", Slot = "4")]
		public int POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0")]
		public bool OPHJDAMMNNH(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "5")]
		private bool IFFBJONHOJH(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x20CB440", Offset = "0x20C9A40", VA = "0x1820CB440", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x20CA1F0", Offset = "0x20C87F0", VA = "0x1820CA1F0")]
		public JEJGNFFBHBC<int> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x20CA260", Offset = "0x20C8860", VA = "0x1820CA260")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x20CA310", Offset = "0x20C8910", VA = "0x1820CA310", Slot = "6")]
		public void FMHGLADJLPJ(int HGFDMIDEFHN, JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x20CA1F0", Offset = "0x20C87F0", VA = "0x1820CA1F0", Slot = "4")]
		private JEJGNFFBHBC<int> BNCBIFEPAKH(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x20CA300", Offset = "0x20C8900", VA = "0x1820CA300", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C62B0", Offset = "0x20C48B0", VA = "0x1820C62B0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9151D0", Offset = "0x9137D0", VA = "0x1809151D0", Slot = "4")]
		public int POBFLKKJCJL(int HGFDMIDEFHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0")]
		public bool OPHJDAMMNNH(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8A07B0", Offset = "0x89EDB0", VA = "0x1808A07B0", Slot = "5")]
		private bool IFFBJONHOJH(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x20C6350", Offset = "0x20C4950", VA = "0x1820C6350", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C0670", Offset = "0x20BEC70", VA = "0x1820C0670")]
		public JEJGNFFBHBC<int> OFMFBHKDACJ(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x20C06E0", Offset = "0x20BECE0", VA = "0x1820C06E0")]
		public MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> BODHFKCBLDM(int HGFDMIDEFHN, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x20C0790", Offset = "0x20BED90", VA = "0x1820C0790", Slot = "6")]
		public void FMHGLADJLPJ(int HGFDMIDEFHN, JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF, MJGAEDNBJIL<JEBGKIHAOOI<DDFNPDLLDDI>> KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x20C0670", Offset = "0x20BEC70", VA = "0x1820C0670", Slot = "4")]
		private JEJGNFFBHBC<int> BNCBIFEPAKH(int LBNMKJDAMIJ, [In] JEJGNFFBHBC<(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> Target, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ByteCodeWriteLocation)> ICLOFOKMOJF)
		{
			return default(JEJGNFFBHBC<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x20C0780", Offset = "0x20BED80", VA = "0x1820C0780", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1524920", Offset = "0x1522F20", VA = "0x181524920")]
		public BMELGLKLHFM(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK, bool GCFBFNGDIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x20C0660", Offset = "0x20BEC60", VA = "0x1820C0660")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C08C0", Offset = "0x20BEEC0", VA = "0x1820C08C0")]
		public CBBAKAAKKFF(MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK, bool GCFBFNGDIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x20C0890", Offset = "0x20BEE90", VA = "0x1820C0890")]
		public void MMDHOICOGNG([Out] MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK, [Out] bool GCFBFNGDIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x20C08A0", Offset = "0x20BEEA0", VA = "0x1820C08A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
		public BLEIFOJDBGD(MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x20C0650", Offset = "0x20BEC50", VA = "0x1820C0650")]
		public void MMDHOICOGNG([Out] MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK, [Out] MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x20C6CD0", Offset = "0x20C52D0", VA = "0x1820C6CD0")]
	public static void AGDCKPANMGG(this OABHMKKJHIF BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x20C8130", Offset = "0x20C6730", VA = "0x1820C8130")]
	public static void HPLMEKKLAKG(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DBGAMICIANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x20C71D0", Offset = "0x20C57D0", VA = "0x1820C71D0")]
	public static void BKKBAPJJLLM(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DBGAMICIANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x20C8CE0", Offset = "0x20C72E0", VA = "0x1820C8CE0")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>? PDMNCNAGHLC([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x20C7980", Offset = "0x20C5F80", VA = "0x1820C7980")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> DOAEMKKHFKK([In] this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x20C8DE0", Offset = "0x20C73E0", VA = "0x1820C8DE0")]
	private static void PGEIFEPHMAH(this OABHMKKJHIF BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x20C8C20", Offset = "0x20C7220", VA = "0x1820C8C20")]
	private static MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>? PCFGJGJFDBE([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x20C8370", Offset = "0x20C6970", VA = "0x1820C8370")]
	public static void KDFAIHPOOKA(this OABHMKKJHIF BJNJBGHPMEH, [In] JEJGNFFBHBC<IBFKAGHMKJI> FACOFPNKNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x20C80B0", Offset = "0x20C66B0", VA = "0x1820C80B0")]
	public static DKJPMNNDPDB.EAGKLJPDCLF HNKGMMHAFHA([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(DKJPMNNDPDB.EAGKLJPDCLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x20C8700", Offset = "0x20C6D00", VA = "0x1820C8700")]
	public static LIHFOMABAPF<byte> LMMJLADCHGP([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(LIHFOMABAPF<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x20C87F0", Offset = "0x20C6DF0", VA = "0x1820C87F0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MEONFBLEKDH([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x20C85B0", Offset = "0x20C6BB0", VA = "0x1820C85B0")]
	public static POJKEEADMGJ KPCENNBICPC([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(POJKEEADMGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2D007A0", Offset = "0x2CFEDA0", VA = "0x182D007A0")]
	private static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DFIHKDHMGPC<TMJoin>(this OABHMKKJHIF BJNJBGHPMEH, DKJPMNNDPDB.EAGKLJPDCLF KNOOGPPOFML, MJGAEDNBJIL<TMJoin> GGEHCDLEHMP) where TMJoin : DKJPMNNDPDB.PEFBKAEADGB
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x20C8BA0", Offset = "0x20C71A0", VA = "0x1820C8BA0")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> OPJOCKIMIDO(this OABHMKKJHIF BJNJBGHPMEH, bool PCGLLKCAJJA)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x20C81C0", Offset = "0x20C67C0", VA = "0x1820C81C0")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> ICBCHFICLDH(this OABHMKKJHIF BJNJBGHPMEH, LIHFOMABAPF<byte> CNGBPDKMHBB)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x20C7900", Offset = "0x20C5F00", VA = "0x1820C7900")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DNNKFCDAPEL(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> EDPFGKBAOKN)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x20C7DF0", Offset = "0x20C63F0", VA = "0x1820C7DF0")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> FDGHOGFBNBD(this OABHMKKJHIF BJNJBGHPMEH, int NLICHAIBNKJ)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x20C82F0", Offset = "0x20C68F0", VA = "0x1820C82F0")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> JALOKCBFOKL(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D01D30", Offset = "0x2D00330", VA = "0x182D01D30")]
	private static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> PDAFPJIBFFA<TMJoin>(this OABHMKKJHIF BJNJBGHPMEH, AKIPLOPCFBD.AJDFBNPAIKI KNOOGPPOFML, MJGAEDNBJIL<TMJoin> GGEHCDLEHMP) where TMJoin : AKIPLOPCFBD.KBGIDILEDGL
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x20C82B0", Offset = "0x20C68B0", VA = "0x1820C82B0")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> JAFFGLFBCNP(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x20C8570", Offset = "0x20C6B70", VA = "0x1820C8570")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> KOPLFMKONEG(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x20C7510", Offset = "0x20C5B10", VA = "0x1820C7510")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> CPCPGBKODID(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> BLGBBOOFFHI)
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x20C8DA0", Offset = "0x20C73A0", VA = "0x1820C8DA0")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> PEFNJFNFNGH(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x20C72A0", Offset = "0x20C58A0", VA = "0x1820C72A0")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> BPCAFBCKJAP(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x20C88E0", Offset = "0x20C6EE0", VA = "0x1820C88E0")]
	public static EOPHNKNAFPB.IIFIPLIFBPI MGGPNFJGGJD([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> ALLAIHGJFJB)
	{
		return default(EOPHNKNAFPB.IIFIPLIFBPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x20C7EF0", Offset = "0x20C64F0", VA = "0x1820C7EF0")]
	public static FDGCEDOBPAL<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>, NPOPOFILLMJ<EOPHNKNAFPB.CAFFJCLHNIB>> FPGNIDDOKFE([In] this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(FDGCEDOBPAL<MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>, NPOPOFILLMJ<EOPHNKNAFPB.CAFFJCLHNIB>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x20C7B60", Offset = "0x20C6160", VA = "0x1820C7B60")]
	public static MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> EILAFEPCIOI([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> ALLAIHGJFJB)
	{
		return default(MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x20C8960", Offset = "0x20C6F60", VA = "0x1820C8960")]
	public static EOPHNKNAFPB.LGBKLKHNOOL NEJMMGHALJG([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> BPCJOPJOKMO)
	{
		return default(EOPHNKNAFPB.LGBKLKHNOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x20C7E70", Offset = "0x20C6470", VA = "0x1820C7E70")]
	public static EOPHNKNAFPB.LGBKLKHNOOL FNBIGOHFKMK(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> BPCJOPJOKMO)
	{
		return default(EOPHNKNAFPB.LGBKLKHNOOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2D01C90", Offset = "0x2D00290", VA = "0x182D01C90")]
	private static MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> MPKLEILLPEE<TMJoin>(this OABHMKKJHIF BJNJBGHPMEH, EOPHNKNAFPB.IIFIPLIFBPI KNOOGPPOFML, MJGAEDNBJIL<TMJoin> GGEHCDLEHMP) where TMJoin : EOPHNKNAFPB.POMGAMHDDOA
	{
		return default(MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x20C6B00", Offset = "0x20C5100", VA = "0x1820C6B00")]
	public static (MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>) AEJANKFICCC(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default((MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x20C7350", Offset = "0x20C5950", VA = "0x1820C7350")]
	public static (MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>) CEGJKMAMBJN(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default((MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x20C8000", Offset = "0x20C6600", VA = "0x1820C8000")]
	public static MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> GJNJFDAKEEE(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x20C84E0", Offset = "0x20C6AE0", VA = "0x1820C84E0")]
	public static void KKEFBKGJPAJ(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB> BPCJOPJOKMO, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> MLDAKFILAPO, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>> CEKHBCCPJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x2D00D90", Offset = "0x2CFF390", VA = "0x182D00D90")]
	public static BMELGLKLHFM HOEJIIMBKEO<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<OIEHBMHNIBK> JJHCIBLPKAD) where TDeps : DLHNIHAOCBJ<TStateSys>
	{
		return default(BMELGLKLHFM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x2D01DE0", Offset = "0x2D003E0", VA = "0x182D01DE0")]
	public static CBBAKAAKKFF PPFFIPDOGOK<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<BKFIMEBJLKC> JJLNKABMPOP, int DLKOGGNFIGC) where TDeps : DLHNIHAOCBJ<TStateSys>
	{
		return default(CBBAKAAKKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x2D00850", Offset = "0x2CFEE50", VA = "0x182D00850")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>? GCKHPAPGHAO<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<BKFIMEBJLKC> JJLNKABMPOP, [In] ReadOnlySpan<int> ABIJPPAADCK, [In] Span<BLEIFOJDBGD> JMOBPLJAPBK) where TDeps : DLHNIHAOCBJ<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D001D0", Offset = "0x2CFE7D0", VA = "0x182D001D0")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> AMOOGFJMMJD<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK, MJGAEDNBJIL<POKJECOIACH> GNAGOFFMLAD) where TDeps : DLHNIHAOCBJ<TStateSys>
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x20C8AB0", Offset = "0x20C70B0", VA = "0x1820C8AB0")]
	public static DLJMAJKPJFE.HAHKDPHIMLK OKBKPKOLHLB([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return default(DLJMAJKPJFE.HAHKDPHIMLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x20C8F50", Offset = "0x20C7550", VA = "0x1820C8F50")]
	public static DLJMAJKPJFE.CPIOCAABGFF PMOPCNMCHCK([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return default(DLJMAJKPJFE.CPIOCAABGFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x20C70E0", Offset = "0x20C56E0", VA = "0x1820C70E0")]
	public static DLJMAJKPJFE.CJJLFEDLPFA BBDJGPBEHFD([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return default(DLJMAJKPJFE.CJJLFEDLPFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x20C7590", Offset = "0x20C5B90", VA = "0x1820C7590")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CPHIBFEPKDP(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP, string KJPHMNNIMDP)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x20C79E0", Offset = "0x20C5FE0", VA = "0x1820C79E0")]
	public static DLJMAJKPJFE.AOBNJIMHOBC DPOAOPOJIJA([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return default(DLJMAJKPJFE.AOBNJIMHOBC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x20C8040", Offset = "0x20C6640", VA = "0x1820C8040")]
	public static DLJMAJKPJFE.OCIJHHEDLAM GKBKIIIJNOE([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return default(DLJMAJKPJFE.OCIJHHEDLAM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x20C72E0", Offset = "0x20C58E0", VA = "0x1820C72E0")]
	public static int? CAPDHCCBHLE([In] this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCAKFNPAKIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2D00C90", Offset = "0x2CFF290", VA = "0x182D00C90")]
	private static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GDKFHBHDILM<TMJoin>(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP, DLJMAJKPJFE.OCIJHHEDLAM KNOOGPPOFML, MJGAEDNBJIL<TMJoin> GGEHCDLEHMP) where TMJoin : DLJMAJKPJFE.LEHHFIKNBKN
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x20C7D40", Offset = "0x20C6340", VA = "0x1820C7D40")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> FCONFGNPLDM(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> ALLAIHGJFJB, int HGFDMIDEFHN)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x20C8250", Offset = "0x20C6850", VA = "0x1820C8250")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> INHAKNGGKCA(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x20C7720", Offset = "0x20C5D20", VA = "0x1820C7720")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> DLLKHAJIBKC(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? HKHCMAAMHNC, int? NIFBFKNJPJP)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x20C7AD0", Offset = "0x20C60D0", VA = "0x1820C7AD0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> EHGPMFCEBFG(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP, int HGFDMIDEFHN)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x20C86A0", Offset = "0x20C6CA0", VA = "0x1820C86A0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> LDAGLLIDHME(this OABHMKKJHIF BJNJBGHPMEH, int? NIFBFKNJPJP)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x20C6FA0", Offset = "0x20C55A0", VA = "0x1820C6FA0")]
	public static void AJIDDNOIBBA(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE> ALLAIHGJFJB, int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x20C69D0", Offset = "0x20C4FD0", VA = "0x1820C69D0")]
	public static void ABMOIOMECFE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF, int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x20C89E0", Offset = "0x20C6FE0", VA = "0x1820C89E0")]
	public static void OFFACHLIHOA(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x20C7870", Offset = "0x20C5E70", VA = "0x1820C7870")]
	public static void DNMJLKKANMG(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> LLMCGMPLMBL, MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> JKBANFAFAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x20C7F30", Offset = "0x20C6530", VA = "0x1820C7F30")]
	public static void GAIOBKBNCMI(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GHLDCNOHGPF, MJGAEDNBJIL<JEBGKIHAOOI<EKHPEIMOKCE>> CDEIDIPPKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2D01BC0", Offset = "0x2D001C0", VA = "0x182D01BC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2AF0780", Offset = "0x2AEED80", VA = "0x182AF0780")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA?> IEHNALNAAEO<T, TOpInput, TOpOutput>(this OABHMKKJHIF BJNJBGHPMEH, T JDKMLCHPKLA, T AENKMLMFBAD, int JJJIHDNFNIB, IntPtr DLMFPIAEPPD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF190", Offset = "0x2AED790", VA = "0x182AEF190")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA?> APAEOILAIEI<T, TOpInput, TOpOutput>(this OABHMKKJHIF BJNJBGHPMEH, T JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD, int JJJIHDNFNIB, IntPtr DLMFPIAEPPD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0A80", Offset = "0x2AEF080", VA = "0x182AF0A80")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA?> LENGECGEKGH<TOpInput, TOpOutput>(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD, int JJJIHDNFNIB, IntPtr DLMFPIAEPPD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x20C1DF0", Offset = "0x20C03F0", VA = "0x1820C1DF0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GFJKFKBFMLH(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x20C1370", Offset = "0x20BF970", VA = "0x1820C1370")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CLMBLEHADAI(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x20C38D0", Offset = "0x20C1ED0", VA = "0x1820C38D0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KILEOGIPHJB(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x20C2490", Offset = "0x20C0A90", VA = "0x1820C2490")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HGKHFMFHBNO(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x20C3E20", Offset = "0x20C2420", VA = "0x1820C3E20")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MAKOMFKDHOF(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x20C3550", Offset = "0x20C1B50", VA = "0x1820C3550")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KFAACMAHKGE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x20C1140", Offset = "0x20BF740", VA = "0x1820C1140")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CIMNOLKHLLE(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x20C4BA0", Offset = "0x20C31A0", VA = "0x1820C4BA0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> OHFKBNENPJI(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x20C3A10", Offset = "0x20C2010", VA = "0x1820C3A10")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KMMKOEGKNCD(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x20C0BE0", Offset = "0x20BF1E0", VA = "0x1820C0BE0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AKHDGLEGGGL(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, int AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x20C3F40", Offset = "0x20C2540", VA = "0x1820C3F40")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MCPJOCKEFDJ(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x20C4510", Offset = "0x20C2B10", VA = "0x1820C4510")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MOGOBKAKCMN(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x20C2580", Offset = "0x20C0B80", VA = "0x1820C2580")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HHLPGANEPMB(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, float AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x20C5850", Offset = "0x20C3E50", VA = "0x1820C5850")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PKKGLANNNPP(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x20C4A60", Offset = "0x20C3060", VA = "0x1820C4A60")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> OEDKEDJLFFC(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x20C0E20", Offset = "0x20BF420", VA = "0x1820C0E20")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> BOEMHLKFBOK(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, int AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x20C0B60", Offset = "0x20BF160", VA = "0x1820C0B60")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AIENNKDNIJK(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x20C1D70", Offset = "0x20C0370", VA = "0x1820C1D70")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> FPILLMKOHID(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x20C1960", Offset = "0x20BFF60", VA = "0x1820C1960")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> EKEDMKJJJHC(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, float AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x20C1580", Offset = "0x20BFB80", VA = "0x1820C1580")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> COFNBNNICKE(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x20C19E0", Offset = "0x20BFFE0", VA = "0x1820C19E0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> EMCOMIHBDCN(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x20C2700", Offset = "0x20C0D00", VA = "0x1820C2700")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HJLENCHEGFC(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, int AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x20C2410", Offset = "0x20C0A10", VA = "0x1820C2410")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HFNHBIMGOFK(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x20C5120", Offset = "0x20C3720", VA = "0x1820C5120")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PBGNAJMDHHE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x20C2680", Offset = "0x20C0C80", VA = "0x1820C2680")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HIOHMBMDBGK(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, float AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x20C08D0", Offset = "0x20BEED0", VA = "0x1820C08D0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> ADMJMHIINAK(this OABHMKKJHIF BJNJBGHPMEH, float JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x20C3BF0", Offset = "0x20C21F0", VA = "0x1820C3BF0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> LLKILJHOOOO(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x20C4650", Offset = "0x20C2C50", VA = "0x1820C4650")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> NLBLPOJELEB(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x20C52A0", Offset = "0x20C38A0", VA = "0x1820C52A0")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> PFFGPPPKCCA(this OABHMKKJHIF BJNJBGHPMEH, int KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x20C5980", Offset = "0x20C3F80", VA = "0x1820C5980")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> PNOLFKEJIAG(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x20C3C70", Offset = "0x20C2270", VA = "0x1820C3C70")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> LMKBENMJMEE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> LGJNNADLAFK)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x20C1CF0", Offset = "0x20C02F0", VA = "0x1820C1CF0")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> FLBGKNEKGPH(this OABHMKKJHIF BJNJBGHPMEH, int KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x20C3B50", Offset = "0x20C2150", VA = "0x1820C3B50")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> LKFALFJJHFB(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x20C4CC0", Offset = "0x20C32C0", VA = "0x1820C4CC0")]
	public static (MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>) PAGOIEDDHMH(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<GAPKMCGHPMH> MEFOHNKECKL, [In] ReadOnlySpan<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> GLMADGBENON, [In] ReadOnlySpan<int?> MDCODLCEJDI, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> ELJBPMGHBGE)
	{
		return default((MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x20C2980", Offset = "0x20C0F80", VA = "0x1820C2980")]
	public static (MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>) IKHKHGBOLJG(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<KNKIADDLFII> NIFAMGNOPOG, [In] ReadOnlySpan<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> GLMADGBENON, [In] ReadOnlySpan<int?> MDCODLCEJDI, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> ELJBPMGHBGE)
	{
		return default((MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0BF0", Offset = "0x2AEF1F0", VA = "0x182AF0BF0")]
	public static (MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<PGDNFPGMBLK>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<TMarker>>, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>) NBHPKGDFIJL<TMarker>(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<PGDNFPGMBLK> HKFLLKEMFPM, [In] ReadOnlySpan<byte> JGCMECODHDI)
	{
		return default((MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<JEBGKIHAOOI<PGDNFPGMBLK>>, MJGAEDNBJIL<JEBGKIHAOOI<AIKPPCNEKMJ>>, MJGAEDNBJIL<JEBGKIHAOOI<TMarker>>, MJGAEDNBJIL<EOPHNKNAFPB.HHMAGFAOEKE>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x20C28A0", Offset = "0x20C0EA0", VA = "0x1820C28A0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HOOGOPENJGA(this OABHMKKJHIF BJNJBGHPMEH, int NEDJODMJOFF, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x20C3270", Offset = "0x20C1870", VA = "0x1820C3270")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JMLBJNFMGEK(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NEDJODMJOFF, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x20C1490", Offset = "0x20BFA90", VA = "0x1820C1490")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CNJIFKMGCML(this OABHMKKJHIF BJNJBGHPMEH, [In] ReadOnlySpan<byte> NEDJODMJOFF, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x20C4060", Offset = "0x20C2660", VA = "0x1820C4060")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MEBHCOPMNNF(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NEDJODMJOFF, int BHEAFIOEIAD, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x20C51A0", Offset = "0x20C37A0", VA = "0x1820C51A0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PBNGJDEAKFL(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x20C37B0", Offset = "0x20C1DB0", VA = "0x1820C37B0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KHMKHAMCJJH(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x20C4920", Offset = "0x20C2F20", VA = "0x1820C4920")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NPEBBJAGMIB(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x20C0A70", Offset = "0x20BF070", VA = "0x1820C0A70")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AHGIKKKDKMF(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x20C1840", Offset = "0x20BFE40", VA = "0x1820C1840")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> DNIDIMOJJIA(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x20C0CE0", Offset = "0x20BF2E0", VA = "0x1820C0CE0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> BGAMODIFMPJ(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x20C0EA0", Offset = "0x20BF4A0", VA = "0x1820C0EA0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> BPOCOFFAMHP(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, int AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x20C1A60", Offset = "0x20C0060", VA = "0x1820C1A60")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> FBAMKKAPBDL(this OABHMKKJHIF BJNJBGHPMEH, int JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x20C1EF0", Offset = "0x20C04F0", VA = "0x1820C1EF0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GGPEDNFOOBC(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JDKMLCHPKLA, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AENKMLMFBAD)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x20C3450", Offset = "0x20C1A50", VA = "0x1820C3450")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KAAFPIJONJI(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x20C22E0", Offset = "0x20C08E0", VA = "0x1820C22E0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HFDEGCONBMI(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x20C1F70", Offset = "0x20C0570", VA = "0x1820C1F70")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GJEOGDFFJNC(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x20C2DF0", Offset = "0x20C13F0", VA = "0x1820C2DF0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> IPJFFADCNGD(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x20C4800", Offset = "0x20C2E00", VA = "0x1820C4800")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NMJJDAEIBHI(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x20C21A0", Offset = "0x20C07A0", VA = "0x1820C21A0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HCAFNDAINMI(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x20C2960", Offset = "0x20C0F60", VA = "0x1820C2960")]
	public static MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>> ICNHGCDHKBI(this OABHMKKJHIF BJNJBGHPMEH)
	{
		return default(MJGAEDNBJIL<JEBGKIHAOOI<JEBGKIHAOOI<GNMBBGKMBGH>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x20C1040", Offset = "0x20BF640", VA = "0x1820C1040")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CIKAGGHKPIP(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x20C0950", Offset = "0x20BEF50", VA = "0x1820C0950")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> AGDIMBLGPJF(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x20C1700", Offset = "0x20BFD00", VA = "0x1820C1700")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> DMHKLJDFOOJ(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x20C5460", Offset = "0x20C3A60", VA = "0x1820C5460")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PICNDEPMCOI(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x20C2780", Offset = "0x20C0D80", VA = "0x1820C2780")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HLCCGAGEBDP(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x20C2EE0", Offset = "0x20C14E0", VA = "0x1820C2EE0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JCGNHNIINPP(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x20C1BF0", Offset = "0x20C01F0", VA = "0x1820C1BF0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> FIMEJFILBMH(this OABHMKKJHIF BJNJBGHPMEH, int KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x20C1AE0", Offset = "0x20C00E0", VA = "0x1820C1AE0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> FGBBDFOCBKB(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KLABJGGMBGH)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x20C0CD0", Offset = "0x20BF2D0", VA = "0x1820C0CD0")]
	public static void APFEAPAJCCH(this OABHMKKJHIF BJNJBGHPMEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x20C1600", Offset = "0x20BFC00", VA = "0x1820C1600")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> DLLDKLMDAGG(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, float NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x20C3690", Offset = "0x20C1C90", VA = "0x1820C3690")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> KGDNPNLHNED(this OABHMKKJHIF BJNJBGHPMEH, float APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x20C5320", Offset = "0x20C3920", VA = "0x1820C5320")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PHCPLAGMPNK(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x20C3360", Offset = "0x20C1960", VA = "0x1820C3360")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JOHIGIGPDMA(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x20C0F20", Offset = "0x20BF520", VA = "0x1820C0F20")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CGBCEMAIPJO(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x20C1230", Offset = "0x20BF830", VA = "0x1820C1230")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> CKOOMIHMKLA(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x20C4180", Offset = "0x20C2780", VA = "0x1820C4180")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> MEGDOLLFJPE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> MOFKFDNIBOB, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> JHOAAHCMKFA)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x20C20B0", Offset = "0x20C06B0", VA = "0x1820C20B0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GNJOADKLFDD(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, int NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x20C3020", Offset = "0x20C1620", VA = "0x1820C3020")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> JGFNMMEJGFF(this OABHMKKJHIF BJNJBGHPMEH, int APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x20C5A20", Offset = "0x20C4020", VA = "0x1820C5A20")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PPIEOLJGIAL(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> APHLHEGNKOO, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NALJIKBHJBG)
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x2AEF530", Offset = "0x2AEDB30", VA = "0x182AEF530")]
	public static void CLHFDGBJMEE<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<GAPKMCGHPMH> MEFOHNKECKL, [In] ReadOnlySpan<MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>> PIKLLANPOHP, [In] ReadOnlySpan<int?> MDCODLCEJDI, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> ELJBPMGHBGE, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> BAMLAOIMFKE, [In] ReadOnlySpan<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>?> MDKAEFBLADA) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x2AF0CF0", Offset = "0x2AEF2F0", VA = "0x182AF0CF0")]
	public static void NFHEEKDPDCB<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<KNKIADDLFII> OADEFMMDNAN, [In] ReadOnlySpan<MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>> BNEEODCMBOC, [In] ReadOnlySpan<int?> MDCODLCEJDI, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> ELJBPMGHBGE, [In] Span<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>> BAMLAOIMFKE, [In] ReadOnlySpan<MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>?> MDKAEFBLADA) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1CE0", Offset = "0x2AF02E0", VA = "0x182AF1CE0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> PFJCDHAJDAA<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HKHCMAAMHNC, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFF70", Offset = "0x2AEE570", VA = "0x182AEFF70")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> GOFIKDKODJC<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> BLGBBOOFFHI, [Optional] MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x2AEEF60", Offset = "0x2AED560", VA = "0x182AEEF60")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> AIJKPDDBCBI<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN) where TDeps : notnull, DLHNIHAOCBJ<TStateSys> where TStateSys : notnull
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFAD0", Offset = "0x2AEE0D0", VA = "0x182AEFAD0")]
	public static MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF> DAODJLHEKFP<TDeps, TStateSys>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN) where TDeps : notnull, DLHNIHAOCBJ<TStateSys> where TStateSys : notnull
	{
		return default(MJGAEDNBJIL<AKIPLOPCFBD.BBBOHFAGDBF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x20C3140", Offset = "0x20C1740", VA = "0x1820C3140")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> JHBOOLDELGE(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> PPFNFCBGHOA, IntPtr KPIBGHNADCG, IntPtr NPMACOGLFLF)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x20C5550", Offset = "0x20C3B50", VA = "0x1820C5550")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> PKGLNLDIEAD(this OABHMKKJHIF BJNJBGHPMEH, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> GODNPGIDKJI, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DOJBMHHEBIN, IntPtr HNGGIMOOKAP, IntPtr IKPMCINFPBP, IntPtr PGFEABBNPHE, bool JJIIOPAIFIO)
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF15B0", Offset = "0x2AEFBB0", VA = "0x182AF15B0")]
	public static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> OBKCEEABKIH<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<GAPKMCGHPMH> PEHJMENKLDP, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> GODNPGIDKJI, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DOJBMHHEBIN, int? BAPCDIMHAJJ, [Optional] IntPtr INIKMDDFKKE) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF1290", Offset = "0x2AEF890", VA = "0x182AF1290")]
	private static MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> OBKCEEABKIH<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<GAPKMCGHPMH> PEHJMENKLDP, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> GODNPGIDKJI, MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF> DOJBMHHEBIN, int? BAPCDIMHAJJ) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
		return default(MJGAEDNBJIL<DKJPMNNDPDB.NGMHCBCFFHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF03D0", Offset = "0x2AEE9D0", VA = "0x182AF03D0")]
	public static MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> HKOLHLBFJKN<TDeps, TState>(this OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TState FDKAGJLJMPF, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA> NEDJODMJOFF, MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>? OHIICHJPFBL) where TDeps : notnull, DLHNIHAOCBJ<TState> where TState : notnull
	{
		return default(MJGAEDNBJIL<DLJMAJKPJFE.EDDBLKHAOOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2AEFCE0", Offset = "0x2AEE2E0", VA = "0x182AEFCE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
	public HACNMLHBCIC(MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> EFBMMDLILFA, MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>> OCOMBJMNJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x20C6910", Offset = "0x20C4F10", VA = "0x1820C6910")]
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
		[Cpp2IlInjected.Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
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
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x91C930", Offset = "0x91AF30", VA = "0x18091C930")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C68F0", Offset = "0x20C4EF0", VA = "0x1820C68F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB082E0", Offset = "0xB068E0", VA = "0x180B082E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20C5F20", Offset = "0x20C4520", VA = "0x1820C5F20")]
	private DLJMAJKPJFE([In] COBDJKOAFAO<EDDBLKHAOOA, GOACLLBBOML> OCCICMDPMFD, [In] COBDJKOAFAO<AKDOCGAMCAP, HAHKDPHIMLK> FPAONECPGEH, [In] COBDJKOAFAO<MNJDABFMPGE, CJJLFEDLPFA> IJKHALFFDHK, [In] COBDJKOAFAO<EJGGFDMLNJF, AOBNJIMHOBC> NMJEIOOBGFP, [In] COBDJKOAFAO<ELFHLCJGNNA, CPIOCAABGFF> OBKBMDFIJOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x20C5D30", Offset = "0x20C4330", VA = "0x1820C5D30")]
	public static DLJMAJKPJFE GGBAHLJJLHO()
	{
		return default(DLJMAJKPJFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class NCHOBIEKAKG
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x20C9E20", Offset = "0x20C8420", VA = "0x1820C9E20")]
	public static void AGDCKPANMGG(this DLJMAJKPJFE BJNJBGHPMEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class HPNMDGCJDCM
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x20C90F0", Offset = "0x20C76F0", VA = "0x1820C90F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x20C0560", Offset = "0x20BEB60", VA = "0x1820C0560")]
	private ANIACHIBHKF([In] EEPBGMDANNB<EOPHNKNAFPB.CAFFJCLHNIB, NMOLOKKKNHP> DFJKLFLBGLH, int DFGKCGEICPG, int JDJGHDBLECD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x20C04F0", Offset = "0x20BEAF0", VA = "0x1820C04F0")]
	public static ANIACHIBHKF GGBAHLJJLHO()
	{
		return default(ANIACHIBHKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x20C0300", Offset = "0x20BE900", VA = "0x1820C0300")]
	public void AGDCKPANMGG([In] OABHMKKJHIF KOFICKKDIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x33541A0", Offset = "0x33527A0", VA = "0x1833541A0")]
	public static void CKOMBPKHALD<TDeps, TStateSys>(OABHMKKJHIF BJNJBGHPMEH, TDeps LAKCFHGOLJA, TStateSys NKAKOJLAIAN, MJGAEDNBJIL<IKLMIGOGHKN> CFNEBLLEIOK) where TDeps : notnull, DLHNIHAOCBJ<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NHDDDHLGGEN
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x20C9FC0", Offset = "0x20C85C0", VA = "0x1820C9FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x20C6360", Offset = "0x20C4960", VA = "0x1820C6360", Slot = "4")]
		public void DIJNOKEDNJP(JEJGNFFBHBC<byte> NJPPNJMNAMC, int GMLMJEFFEAA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct HDMNLKFNAOJ : BDHLBFMFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x20C6920", Offset = "0x20C4F20", VA = "0x1820C6920", Slot = "4")]
		public void DIJNOKEDNJP(JEJGNFFBHBC<byte> NJPPNJMNAMC, int GMLMJEFFEAA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct LMNLKNMNALO : BDHLBFMFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x20C9960", Offset = "0x20C7F60", VA = "0x1820C9960", Slot = "4")]
		public void DIJNOKEDNJP(JEJGNFFBHBC<byte> NJPPNJMNAMC, int GMLMJEFFEAA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct HMHCNCLLHBE : BDHLBFMFPHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x20C9040", Offset = "0x20C7640", VA = "0x1820C9040", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2945A20", Offset = "0x2944020", VA = "0x182945A20")]
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
	[Cpp2IlInjected.Address(RVA = "0x20C9350", Offset = "0x20C7950", VA = "0x1820C9350")]
	private IBJMLJGEDOA([In] JEJGNFFBHBC<IBFKAGHMKJI> FACOFPNKNFL, Dictionary<MJGAEDNBJIL<JEBGKIHAOOI<GNMBBGKMBGH>>, MJGAEDNBJIL<EOPHNKNAFPB.CAFFJCLHNIB>> PDDPGMFNAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x20C9290", Offset = "0x20C7890", VA = "0x1820C9290")]
	public static IBJMLJGEDOA GGBAHLJJLHO()
	{
		return default(IBJMLJGEDOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x20C9250", Offset = "0x20C7850", VA = "0x1820C9250")]
	public void AGDCKPANMGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2D11BA0", Offset = "0x2D101A0", VA = "0x182D11BA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4348E50", Offset = "0x4347450", VA = "0x184348E50")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D16960", Offset = "0x3D14F60", VA = "0x183D16960")]
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
