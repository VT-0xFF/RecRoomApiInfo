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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A7D530", Offset = "0x2A7BF30", VA = "0x182A7D530")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct NBMKKHGAEPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> GKEOAHIAJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int MPEIPFAGFHN;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xE83310", Offset = "0xE81D10", VA = "0x180E83310")]
	public NBMKKHGAEPH(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> OHMKEAGCOII, int KIOPHNHDMKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct DHJOCINNCIA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class FLNFDIEHIAN : NJHOKNNJPLB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct CFOPHJFJKOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly KNEFAFDDNNC<byte> EBDHHMPGCDO;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A04300", Offset = "0x2A02D00", VA = "0x182A04300")]
		public CFOPHJFJKOH(KNEFAFDDNNC<byte> LHALFHPGBPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2A74990", Offset = "0x2A73390", VA = "0x182A74990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class IOCBMHJHFID : NJHOKNNJPLB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct BGMKKDHHPCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> GPLAKDMHADI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		public BGMKKDHHPCM(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> JJJGELAFLOE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DNPKLMEOFCA
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
	public sealed class INJNEGKAAPK
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class NJHOKNNJPLB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct KMLIBDHMLLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly DNPKLMEOFCA NBGPLJBKGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly COBPPOBACAG<NJHOKNNJPLB> MKNDMLFKJDM;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE83310", Offset = "0xE81D10", VA = "0x180E83310")]
		public KMLIBDHMLLH(DNPKLMEOFCA LJPDADGMNIB, COBPPOBACAG<NJHOKNNJPLB> FJJBJFLOGAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class NMIMAEPHDDD : NJHOKNNJPLB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct EAIMLKAKFBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> KJPIIOHHEHC;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		public EAIMLKAKFBM(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> MAPCAHLPHEI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class AIICGHOEBME : NJHOKNNJPLB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct NCDCEJAHAOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly LOALHEIKMIM HBGDOGLELJB;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		public NCDCEJAHAOI(LOALHEIKMIM JNKMPAEFMCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D400", Offset = "0x2A7BE00", VA = "0x182A7D400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal LPCPOHGEHNI<INJNEGKAAPK, KMLIBDHMLLH> IJJDJNJFMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal LPCPOHGEHNI<FLNFDIEHIAN, CFOPHJFJKOH> MPBCLFIDGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal LPCPOHGEHNI<IOCBMHJHFID, BGMKKDHHPCM> FADJFDKOCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal LPCPOHGEHNI<NMIMAEPHDDD, EAIMLKAKFBM> MJKDPNPDLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal LPCPOHGEHNI<AIICGHOEBME, NCDCEJAHAOI> MPDJOMGNHLE;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A74E60", Offset = "0x2A73860", VA = "0x182A74E60")]
	private DHJOCINNCIA([In] LPCPOHGEHNI<INJNEGKAAPK, KMLIBDHMLLH> DIDFJPIPDBI, [In] LPCPOHGEHNI<FLNFDIEHIAN, CFOPHJFJKOH> AJMFIKAKGJG, [In] LPCPOHGEHNI<IOCBMHJHFID, BGMKKDHHPCM> LANPJECJDPP, [In] LPCPOHGEHNI<NMIMAEPHDDD, EAIMLKAKFBM> HHLJEIKAJDN, [In] LPCPOHGEHNI<AIICGHOEBME, NCDCEJAHAOI> IGCOGNNDHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2A74D20", Offset = "0x2A73720", VA = "0x182A74D20")]
	public static DHJOCINNCIA MDDJOGPLAFO()
	{
		return default(DHJOCINNCIA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NDJHGAIJACL
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D420", Offset = "0x2A7BE20", VA = "0x182A7D420")]
	public static void NHMIPJFACPH(this DHJOCINNCIA NLDLHIJAJBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum DNJFGCOJKEK
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
public struct GMPLDKLOIAO
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class EAMDPKAAAHL : PIDDFKOHLFD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct ACMEGKMGGGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> IIHOIKMICIG;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		public ACMEGKMGGGG(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> JDGOANEGJCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum NPBCCMBFPMA
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
	public sealed class ALPDPDDMIAF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class PIDDFKOHLFD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct MPFIFCNNFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly NPBCCMBFPMA NBGPLJBKGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly COBPPOBACAG<PIDDFKOHLFD> MKNDMLFKJDM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xE83310", Offset = "0xE81D10", VA = "0x180E83310")]
		public MPFIFCNNFJI(NPBCCMBFPMA LJPDADGMNIB, COBPPOBACAG<PIDDFKOHLFD> FJJBJFLOGAP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal LPCPOHGEHNI<ALPDPDDMIAF, MPFIFCNNFJI> IJJDJNJFMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal LPCPOHGEHNI<EAMDPKAAAHL, ACMEGKMGGGG> NKICBHHDBBK;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2A72470", Offset = "0x2A70E70", VA = "0x182A72470")]
	private GMPLDKLOIAO([In] LPCPOHGEHNI<ALPDPDDMIAF, MPFIFCNNFJI> DIDFJPIPDBI, [In] LPCPOHGEHNI<EAMDPKAAAHL, ACMEGKMGGGG> OAAPEPCIGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B150", Offset = "0x2A79B50", VA = "0x182A7B150")]
	public static GMPLDKLOIAO MDDJOGPLAFO()
	{
		return default(GMPLDKLOIAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class NPIEPLHEIGB
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D4D0", Offset = "0x2A7BED0", VA = "0x182A7D4D0")]
	public static void NHMIPJFACPH(this GMPLDKLOIAO NLDLHIJAJBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct KNGCAOLAHHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public GNGEHCNCBFJ<int> HMJJNCEMOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public GNGEHCNCBFJ<int> MALDJKHBEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int EBBOJBNDEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int LCGJHBECACH;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C380", Offset = "0x2A7AD80", VA = "0x182A7C380")]
	private KNGCAOLAHHO([In] GNGEHCNCBFJ<int> IKPKJEJHGIJ, [In] GNGEHCNCBFJ<int> EPLAJBCNINC, int DFBFAGLMPGG, int OJPNKHJGLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C2E0", Offset = "0x2A7ACE0", VA = "0x182A7C2E0")]
	public static KNGCAOLAHHO MDDJOGPLAFO()
	{
		return default(KNGCAOLAHHO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KHELLLHOFLG
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C270", Offset = "0x2A7AC70", VA = "0x182A7C270")]
	public static void NHMIPJFACPH(this KNGCAOLAHHO NLDLHIJAJBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct KFBECEOFGEG
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum OAKPCMMIKIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class FPHGHNBCFLE : AIEIGNIHIMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct NMIJDDCCMCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly COBPPOBACAG<BNAHLKCPLDH> IJGIGEFFHNK;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		public NMIJDDCCMCO(COBPPOBACAG<BNAHLKCPLDH> PAABEALEEPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class HHFNPFAKFII
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class AIEIGNIHIMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct OMBLOGBHFBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly OAKPCMMIKIK NBGPLJBKGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly COBPPOBACAG<AIEIGNIHIMD> MKNDMLFKJDM;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xE83310", Offset = "0xE81D10", VA = "0x180E83310")]
		private OMBLOGBHFBP(OAKPCMMIKIK LJPDADGMNIB, COBPPOBACAG<AIEIGNIHIMD> FJJBJFLOGAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D820", Offset = "0x2A7C220", VA = "0x182A7D820")]
		public static OMBLOGBHFBP MDDJOGPLAFO(OAKPCMMIKIK LJPDADGMNIB, COBPPOBACAG<AIEIGNIHIMD> FJJBJFLOGAP)
		{
			return default(OMBLOGBHFBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class FMIAPGABNCI : AIEIGNIHIMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct EBADNEPJIOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly COBPPOBACAG<BNAHLKCPLDH> IJGIGEFFHNK;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		public EBADNEPJIOP(COBPPOBACAG<BNAHLKCPLDH> PAABEALEEPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class BNAHLKCPLDH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct AECMFCKJCPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public GNGEHCNCBFJ<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> CFCLHOALNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public GNGEHCNCBFJ<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> LKCJNMJCDBL;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A72470", Offset = "0x2A70E70", VA = "0x182A72470")]
		private AECMFCKJCPF([In] GNGEHCNCBFJ<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> JEAMHIFDMBF, [In] GNGEHCNCBFJ<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> DOGLDBMIICN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2A723F0", Offset = "0x2A70DF0", VA = "0x182A723F0")]
		public static AECMFCKJCPF MDDJOGPLAFO()
		{
			return default(AECMFCKJCPF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal LPCPOHGEHNI<HHFNPFAKFII, OMBLOGBHFBP> IJJDJNJFMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal LPCPOHGEHNI<FMIAPGABNCI, EBADNEPJIOP> JLIOPEJMHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal LPCPOHGEHNI<FPHGHNBCFLE, NMIJDDCCMCO> OKCNHLOJIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal GNGEHCNCBFJ<(COBPPOBACAG<HHFNPFAKFII> CallId, COBPPOBACAG<BNAHLKCPLDH> IOId)> DEHIDKCOAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal LPCPOHGEHNI<BNAHLKCPLDH, AECMFCKJCPF> HDEPJKICMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal HCBAHOABANP<BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>> MJPBHECHOFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal HCBAHOABANP<BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>> JCEBCDMKGCH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C130", Offset = "0x2A7AB30", VA = "0x182A7C130")]
	private KFBECEOFGEG([In] LPCPOHGEHNI<HHFNPFAKFII, OMBLOGBHFBP> DIDFJPIPDBI, [In] LPCPOHGEHNI<FMIAPGABNCI, EBADNEPJIOP> NAEDKGKOPJJ, [In] LPCPOHGEHNI<FPHGHNBCFLE, NMIJDDCCMCO> ELADGGIPEGD, [In] GNGEHCNCBFJ<(COBPPOBACAG<HHFNPFAKFII> CallId, COBPPOBACAG<BNAHLKCPLDH> IOId)> HPNBFFMICLM, [In] LPCPOHGEHNI<BNAHLKCPLDH, AECMFCKJCPF> ALFGACLNFGD, [In] HCBAHOABANP<BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>> NKHLPCBEGBG, [In] HCBAHOABANP<BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>> JLEDGHMDLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BF90", Offset = "0x2A7A990", VA = "0x182A7BF90")]
	public static KFBECEOFGEG MDDJOGPLAFO()
	{
		return default(KFBECEOFGEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HNFEFLHOKPF
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B7D0", Offset = "0x2A7A1D0", VA = "0x182A7B7D0")]
	private static void NHMIPJFACPH(this KFBECEOFGEG.AECMFCKJCPF NLDLHIJAJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B5C0", Offset = "0x2A79FC0", VA = "0x182A7B5C0")]
	public static void NHMIPJFACPH(this KFBECEOFGEG NLDLHIJAJBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct GKCECMAPKLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public GNGEHCNCBFJ<byte> EPPHHOIMLPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal KFBECEOFGEG CEALNNGJKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal CHBGCMCOPKD GOEAHFAONDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> AJCJNGPFBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal DHJOCINNCIA MFFFGJAMNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal GMPLDKLOIAO OLIBJIPHGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal HCBAHOABANP<IIGNEBOMHLM, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>?> DNPIMPCLCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal GNGEHCNCBFJ<COBPPOBACAG<IIGNEBOMHLM>> JAFDMDIPPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?> CDPDJDPFOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> VariableId, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>> ByteCodeWriteLocation)> NIKBIOJADOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> ANDDLFIIOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal IDIHJPCGING GNBDANCGBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal EOBBAJJJFIP JCMLLNEGDBG;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2A7ADF0", Offset = "0x2A797F0", VA = "0x182A7ADF0")]
	private GKCECMAPKLA([In] GNGEHCNCBFJ<byte> MFANGEKPLIN, [In] KFBECEOFGEG POLMJPLCFCL, [In] CHBGCMCOPKD DNBBCBLJGAL, [In] DHJOCINNCIA CLDDFJMEKHB, [In] GMPLDKLOIAO OOHHPINIGGM, [In] HCBAHOABANP<IIGNEBOMHLM, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>?> BCCIAMCPLFN, [In] GNGEHCNCBFJ<COBPPOBACAG<IIGNEBOMHLM>> OJFIOHJPBBI, [In] HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?> LBINDDHBKDE, [In] GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> VariableId, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>> ByteCodeWriteLocation)> LGCNIENNDHF, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> NDNCBMHFKJA, [In] IDIHJPCGING LCPPOAAKGNE, [In] EOBBAJJJFIP IJPPEAINFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A440", Offset = "0x2A78E40", VA = "0x182A7A440")]
	public static GKCECMAPKLA MDDJOGPLAFO()
	{
		return default(GKCECMAPKLA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class AHCCJFJDGDP
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct PPPMIAMMNOL : MBEOLADBEBG<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>, HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D990", Offset = "0x2A7C390", VA = "0x182A7D990")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7DA10", Offset = "0x2A7C410", VA = "0x182A7DA10", Slot = "4")]
		public COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> CMKOLFLGNMK(int FILGHJLFKAL)
		{
			return default(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980")]
		public bool CFCHPHBGBKA(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "5")]
		private bool KIGPOJKCGHN(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D990", Offset = "0x2A7C390", VA = "0x182A7D990", Slot = "6")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> CCJCPOJCGHA(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct MOCDIEEBJHM : MMKCOLBMJOD<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>, HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D160", Offset = "0x2A7BB60", VA = "0x182A7D160")]
		public GNGEHCNCBFJ<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>> PJDAADNAKED(int NHDJOCNLNFK, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D1D0", Offset = "0x2A7BBD0", VA = "0x182A7D1D0")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D0D0", Offset = "0x2A7BAD0", VA = "0x182A7D0D0", Slot = "6")]
		public void BDEIGHHFGND(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>> EJKNLPOFFNN, COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D160", Offset = "0x2A7BB60", VA = "0x182A7D160", Slot = "4")]
		private GNGEHCNCBFJ<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>> CDGAKEJMNBD(int NHDJOCNLNFK, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D1D0", Offset = "0x2A7BBD0", VA = "0x182A7D1D0", Slot = "5")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> IKCODMLBDFD(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct OOAFOACBADD : MBEOLADBEBG<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>, HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D870", Offset = "0x2A7C270", VA = "0x182A7D870")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D840", Offset = "0x2A7C240", VA = "0x182A7D840", Slot = "4")]
		public COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> CMKOLFLGNMK(int FILGHJLFKAL)
		{
			return default(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980")]
		public bool CFCHPHBGBKA(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "5")]
		private bool JIJDEKICGHB(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D870", Offset = "0x2A7C270", VA = "0x182A7D870", Slot = "6")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> IOEEBLEIBGE(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct KOICDLCDPBP : MMKCOLBMJOD<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>, HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C4F0", Offset = "0x2A7AEF0", VA = "0x182A7C4F0")]
		public GNGEHCNCBFJ<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>> PJDAADNAKED(int NHDJOCNLNFK, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C470", Offset = "0x2A7AE70", VA = "0x182A7C470")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C3E0", Offset = "0x2A7ADE0", VA = "0x182A7C3E0", Slot = "6")]
		public void BDEIGHHFGND(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>> EJKNLPOFFNN, COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C4F0", Offset = "0x2A7AEF0", VA = "0x182A7C4F0", Slot = "4")]
		private GNGEHCNCBFJ<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>> EMGNNPILODM(int NHDJOCNLNFK, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C470", Offset = "0x2A7AE70", VA = "0x182A7C470", Slot = "5")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> BLPOGJMAGHH(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> FILGHJLFKAL, [In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct IJPBBAHCIPB : MBEOLADBEBG<COBPPOBACAG<BHNPPOPBMAI>, HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BB40", Offset = "0x2A7A540", VA = "0x182A7BB40")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(COBPPOBACAG<BHNPPOPBMAI> FILGHJLFKAL, [In] HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BB10", Offset = "0x2A7A510", VA = "0x182A7BB10", Slot = "4")]
		public COBPPOBACAG<BHNPPOPBMAI> CMKOLFLGNMK(int FILGHJLFKAL)
		{
			return default(COBPPOBACAG<BHNPPOPBMAI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BAA0", Offset = "0x2A7A4A0", VA = "0x182A7BAA0")]
		public bool CFCHPHBGBKA(COBPPOBACAG<BHNPPOPBMAI> FILGHJLFKAL, [In] HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BAA0", Offset = "0x2A7A4A0", VA = "0x182A7BAA0", Slot = "5")]
		private bool BNGCCLJLEAB(COBPPOBACAG<BHNPPOPBMAI> FILGHJLFKAL, [In] HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BB00", Offset = "0x2A7A500", VA = "0x182A7BB00", Slot = "6")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> BPCKJLHNAJK(COBPPOBACAG<BHNPPOPBMAI> FILGHJLFKAL, [In] HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct JCABNFANALK : MMKCOLBMJOD<COBPPOBACAG<BHNPPOPBMAI>, HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BF10", Offset = "0x2A7A910", VA = "0x182A7BF10")]
		public GNGEHCNCBFJ<COBPPOBACAG<BHNPPOPBMAI>> PJDAADNAKED(int NHDJOCNLNFK, [In] HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<COBPPOBACAG<BHNPPOPBMAI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BE70", Offset = "0x2A7A870", VA = "0x182A7BE70")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(COBPPOBACAG<BHNPPOPBMAI> FILGHJLFKAL, [In] HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BDB0", Offset = "0x2A7A7B0", VA = "0x182A7BDB0", Slot = "6")]
		public void BDEIGHHFGND(COBPPOBACAG<BHNPPOPBMAI> FILGHJLFKAL, HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?> EJKNLPOFFNN, COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BF10", Offset = "0x2A7A910", VA = "0x182A7BF10", Slot = "4")]
		private GNGEHCNCBFJ<COBPPOBACAG<BHNPPOPBMAI>> PIPHEEFKDBI(int NHDJOCNLNFK, [In] HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<COBPPOBACAG<BHNPPOPBMAI>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BE60", Offset = "0x2A7A860", VA = "0x182A7BE60", Slot = "5")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> LPLOMGIDDDI(COBPPOBACAG<BHNPPOPBMAI> FILGHJLFKAL, [In] HCBAHOABANP<BHNPPOPBMAI, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>?> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct MBFGCPJBFOA : MBEOLADBEBG<int, GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C570", Offset = "0x2A7AF70", VA = "0x182A7C570")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> VariableId, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB82680", Offset = "0xB81080", VA = "0x180B82680", Slot = "4")]
		public int CMKOLFLGNMK(int FILGHJLFKAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980")]
		public bool CFCHPHBGBKA(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> VariableId, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "5")]
		private bool IFODJACOHPD(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> VariableId, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C560", Offset = "0x2A7AF60", VA = "0x182A7C560", Slot = "6")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> DCILNOPCNII(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> VariableId, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct OABBMKCEFIM : MMKCOLBMJOD<int, GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D6B0", Offset = "0x2A7C0B0", VA = "0x182A7D6B0")]
		public GNGEHCNCBFJ<int> PJDAADNAKED(int NHDJOCNLNFK, [In] GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> VariableId, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D720", Offset = "0x2A7C120", VA = "0x182A7D720")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> VariableId, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D5C0", Offset = "0x2A7BFC0", VA = "0x182A7D5C0", Slot = "6")]
		public void BDEIGHHFGND(int FILGHJLFKAL, GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> VariableId, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>> ByteCodeWriteLocation)> EJKNLPOFFNN, COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D6B0", Offset = "0x2A7C0B0", VA = "0x182A7D6B0", Slot = "4")]
		private GNGEHCNCBFJ<int> FLNLOKFCNLD(int NHDJOCNLNFK, [In] GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> VariableId, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D5B0", Offset = "0x2A7BFB0", VA = "0x182A7D5B0", Slot = "5")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> AICLKLCBMHG(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> VariableId, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<LPPGLHMNLFG>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct MIJPFCLEPOF : MBEOLADBEBG<int, GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D050", Offset = "0x2A7BA50", VA = "0x182A7D050")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB82680", Offset = "0xB81080", VA = "0x180B82680", Slot = "4")]
		public int CMKOLFLGNMK(int FILGHJLFKAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980")]
		public bool CFCHPHBGBKA(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "5")]
		private bool NBJCLAMMDCI(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D050", Offset = "0x2A7BA50", VA = "0x182A7D050", Slot = "6")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PCGNMKMPFII(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct IODKPLCBNAC : MMKCOLBMJOD<int, GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BD40", Offset = "0x2A7A740", VA = "0x182A7BD40")]
		public GNGEHCNCBFJ<int> PJDAADNAKED(int NHDJOCNLNFK, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BCC0", Offset = "0x2A7A6C0", VA = "0x182A7BCC0")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BBE0", Offset = "0x2A7A5E0", VA = "0x182A7BBE0", Slot = "6")]
		public void BDEIGHHFGND(int FILGHJLFKAL, GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN, COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BD40", Offset = "0x2A7A740", VA = "0x182A7BD40", Slot = "4")]
		private GNGEHCNCBFJ<int> EEINGGOJGGJ(int NHDJOCNLNFK, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BCC0", Offset = "0x2A7A6C0", VA = "0x182A7BCC0", Slot = "5")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> BFNDDBLNHPL(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct HEAGCKBPMLB : MBEOLADBEBG<int, GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B350", Offset = "0x2A79D50", VA = "0x182A7B350")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB82680", Offset = "0xB81080", VA = "0x180B82680", Slot = "4")]
		public int CMKOLFLGNMK(int FILGHJLFKAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980")]
		public bool CFCHPHBGBKA(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "5")]
		private bool NBJCLAMMDCI(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B340", Offset = "0x2A79D40", VA = "0x182A7B340", Slot = "6")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PCGNMKMPFII(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct HHEOAHBHNMJ : MMKCOLBMJOD<int, GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B4D0", Offset = "0x2A79ED0", VA = "0x182A7B4D0")]
		public GNGEHCNCBFJ<int> PJDAADNAKED(int NHDJOCNLNFK, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B540", Offset = "0x2A79F40", VA = "0x182A7B540")]
		public COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B3D0", Offset = "0x2A79DD0", VA = "0x182A7B3D0", Slot = "6")]
		public void BDEIGHHFGND(int FILGHJLFKAL, GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN, COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PDKJBMPOMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B4D0", Offset = "0x2A79ED0", VA = "0x182A7B4D0", Slot = "4")]
		private GNGEHCNCBFJ<int> EEINGGOJGGJ(int NHDJOCNLNFK, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(GNGEHCNCBFJ<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2A7B4C0", Offset = "0x2A79EC0", VA = "0x182A7B4C0", Slot = "5")]
		private COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> BFNDDBLNHPL(int FILGHJLFKAL, [In] GNGEHCNCBFJ<(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> Target, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ByteCodeWriteLocation)> EJKNLPOFFNN)
		{
			return default(COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct JNMOCIOMPCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> AKALIMLPIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool EFCDPGKNJNA;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x21209A0", Offset = "0x211F3A0", VA = "0x1821209A0")]
		public JNMOCIOMPCJ(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL, bool PJOGLAJBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2A7BF80", Offset = "0x2A7A980", VA = "0x182A7BF80")]
		public void GNAIPCHGPNM([Out] COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL, [Out] bool PJOGLAJBNNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct FIHLHLBGIIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly COBPPOBACAG<BHNPPOPBMAI> KDHIIHIMNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> AKALIMLPIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool EFCDPGKNJNA;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A430", Offset = "0x2A78E30", VA = "0x182A7A430")]
		public FIHLHLBGIIL(COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL, bool PJOGLAJBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A420", Offset = "0x2A78E20", VA = "0x182A7A420")]
		public void GNAIPCHGPNM([Out] COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL, [Out] bool PJOGLAJBNNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2A7A400", Offset = "0x2A78E00", VA = "0x182A7A400")]
		public void GNAIPCHGPNM([Out] COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL, [Out] COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN, [Out] bool PJOGLAJBNNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct OMLPKALPPGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly COBPPOBACAG<BHNPPOPBMAI> KDHIIHIMNBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> AKALIMLPIPH;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xE83310", Offset = "0xE81D10", VA = "0x180E83310")]
		public OMLPKALPPGG(COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D830", Offset = "0x2A7C230", VA = "0x182A7D830")]
		public void GNAIPCHGPNM([Out] COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL, [Out] COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2A73FC0", Offset = "0x2A729C0", VA = "0x182A73FC0")]
	public static void NHMIPJFACPH(this GKCECMAPKLA NLDLHIJAJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2A73100", Offset = "0x2A71B00", VA = "0x182A73100")]
	public static void HMGCKBKHDKG(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<IIGNEBOMHLM> PJCICAAFAEH, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> BBGOJGHLEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2A73680", Offset = "0x2A72080", VA = "0x182A73680")]
	public static void JDIJJGFPCDK(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<IIGNEBOMHLM> PJCICAAFAEH, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> BBGOJGHLEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2A734B0", Offset = "0x2A71EB0", VA = "0x182A734B0")]
	public static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>? ILLOGPNOJND([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<IIGNEBOMHLM> PJCICAAFAEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2A73EB0", Offset = "0x2A728B0", VA = "0x182A73EB0")]
	public static COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> NFEKLDFFDJF([In] this GKCECMAPKLA NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2A725D0", Offset = "0x2A70FD0", VA = "0x182A725D0")]
	private static void AHJHLJJCIPK(this GKCECMAPKLA NLDLHIJAJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2A735F0", Offset = "0x2A71FF0", VA = "0x182A735F0")]
	private static COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>? JBFIJHLLCMD([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2A728A0", Offset = "0x2A712A0", VA = "0x182A728A0")]
	public static void CEOGBCHJFFK(this GKCECMAPKLA NLDLHIJAJBO, [In] GNGEHCNCBFJ<NBMKKHGAEPH> KOAIBNBGFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2A727E0", Offset = "0x2A711E0", VA = "0x182A727E0")]
	public static DHJOCINNCIA.DNPKLMEOFCA ALLOMDBLOBI([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL)
	{
		return default(DHJOCINNCIA.DNPKLMEOFCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2A72730", Offset = "0x2A71130", VA = "0x182A72730")]
	public static KNEFAFDDNNC<byte> AJLFAOMHCNF([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL)
	{
		return default(KNEFAFDDNNC<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2A74410", Offset = "0x2A72E10", VA = "0x182A74410")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NOJDLEOAPOM([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2A744C0", Offset = "0x2A72EC0", VA = "0x182A744C0")]
	public static LOALHEIKMIM PFLJPPLAPCK([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL)
	{
		return default(LOALHEIKMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x31C8FB0", Offset = "0x31C79B0", VA = "0x1831C8FB0")]
	private static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> HAGOGKLCEJH<TMJoin>(this GKCECMAPKLA NLDLHIJAJBO, DHJOCINNCIA.DNPKLMEOFCA LJPDADGMNIB, COBPPOBACAG<TMJoin> FJJBJFLOGAP) where TMJoin : DHJOCINNCIA.NJHOKNNJPLB
	{
		return default(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2A74700", Offset = "0x2A73100", VA = "0x182A74700")]
	public static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> PMDLJNPCCHK(this GKCECMAPKLA NLDLHIJAJBO, bool MPPIEBICBPH)
	{
		return default(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2A72A90", Offset = "0x2A71490", VA = "0x182A72A90")]
	public static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> DLLOAPEEEIE(this GKCECMAPKLA NLDLHIJAJBO, KNEFAFDDNNC<byte> LHALFHPGBPD)
	{
		return default(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2A72F80", Offset = "0x2A71980", VA = "0x182A72F80")]
	public static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> HAHKLFIOBAF(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> JJJGELAFLOE)
	{
		return default(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2A73E30", Offset = "0x2A72830", VA = "0x182A73E30")]
	public static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> MPOBLHHLHGB(this GKCECMAPKLA NLDLHIJAJBO, int OIIEJHDCLKL)
	{
		return default(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2A73800", Offset = "0x2A72200", VA = "0x182A73800")]
	public static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> KKIEKCNPCEC(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> MAPCAHLPHEI)
	{
		return default(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x31C9D10", Offset = "0x31C8710", VA = "0x1831C9D10")]
	private static COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF> ODEPEEBHBPA<TMJoin>(this GKCECMAPKLA NLDLHIJAJBO, GMPLDKLOIAO.NPBCCMBFPMA LJPDADGMNIB, COBPPOBACAG<TMJoin> FJJBJFLOGAP) where TMJoin : GMPLDKLOIAO.PIDDFKOHLFD
	{
		return default(COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2A73060", Offset = "0x2A71A60", VA = "0x182A73060")]
	public static COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF> HCFAANOCBMP(this GKCECMAPKLA NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2A73750", Offset = "0x2A72150", VA = "0x182A73750")]
	public static COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF> JKJPKJKMELC(this GKCECMAPKLA NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2A72A10", Offset = "0x2A71410", VA = "0x182A72A10")]
	public static COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF> COCALMIJPCN(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> JDGOANEGJCB)
	{
		return default(COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A73270", Offset = "0x2A71C70", VA = "0x182A73270")]
	public static COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF> ICMLNLFNNJB(this GKCECMAPKLA NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2A72DB0", Offset = "0x2A717B0", VA = "0x182A72DB0")]
	public static COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF> GBBBJHEMEJH(this GKCECMAPKLA NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2A74350", Offset = "0x2A72D50", VA = "0x182A74350")]
	public static KFBECEOFGEG.OAKPCMMIKIK NKOMKGCNLBK([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII> NDEIKOOBOBC)
	{
		return default(KFBECEOFGEG.OAKPCMMIKIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2A732C0", Offset = "0x2A71CC0", VA = "0x182A732C0")]
	public static NPPNACLKOBJ<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>, NLGODIBAJEH<KFBECEOFGEG.BNAHLKCPLDH>> IENPEOFFLHJ([In] this GKCECMAPKLA NLDLHIJAJBO)
	{
		return default(NPPNACLKOBJ<COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>, NLGODIBAJEH<KFBECEOFGEG.BNAHLKCPLDH>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2A73880", Offset = "0x2A72280", VA = "0x182A73880")]
	public static COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> LGFMLEMCHFI([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII> NDEIKOOBOBC)
	{
		return default(COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2A73000", Offset = "0x2A71A00", VA = "0x182A73000")]
	public static KFBECEOFGEG.AECMFCKJCPF HBMFLLGDENL([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> PAABEALEEPJ)
	{
		return default(KFBECEOFGEG.AECMFCKJCPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2A743B0", Offset = "0x2A72DB0", VA = "0x182A743B0")]
	public static KFBECEOFGEG.AECMFCKJCPF NLILNJKCCDN(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> PAABEALEEPJ)
	{
		return default(KFBECEOFGEG.AECMFCKJCPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x31C9860", Offset = "0x31C8260", VA = "0x1831C9860")]
	private static COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII> KIJMOBEAFBK<TMJoin>(this GKCECMAPKLA NLDLHIJAJBO, KFBECEOFGEG.OAKPCMMIKIK LJPDADGMNIB, COBPPOBACAG<TMJoin> FJJBJFLOGAP) where TMJoin : KFBECEOFGEG.AIEIGNIHIMD
	{
		return default(COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2A73300", Offset = "0x2A71D00", VA = "0x182A73300")]
	public static (COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>) IHGBLMLAMCA(this GKCECMAPKLA NLDLHIJAJBO)
	{
		return default((COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2A73A00", Offset = "0x2A72400", VA = "0x182A73A00")]
	public static (COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>) LKAALNFDPBI(this GKCECMAPKLA NLDLHIJAJBO)
	{
		return default((COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2A73190", Offset = "0x2A71B90", VA = "0x182A73190")]
	public static COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII> HMGOHNJJAAO(this GKCECMAPKLA NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A72E90", Offset = "0x2A71890", VA = "0x182A72E90")]
	public static void GMPGNINKKNG(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH> PAABEALEEPJ, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> IBBKNGNJABN, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>> KIGBAIMPDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x31C8030", Offset = "0x31C6A30", VA = "0x1831C8030")]
	public static JNMOCIOMPCJ CKMDNINIMNO<TDeps, TStateSys>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN) where TDeps : IHOJBDIKHDC<TStateSys>
	{
		return default(JNMOCIOMPCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x31C95E0", Offset = "0x31C7FE0", VA = "0x1831C95E0")]
	public static FIHLHLBGIIL JMLPMBMOFIP<TDeps, TStateSys>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<CFJBLOCLLGM> KALNIGICCJC, int FOFPDNPBFFD) where TDeps : IHOJBDIKHDC<TStateSys>
	{
		return default(FIHLHLBGIIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x31C98F0", Offset = "0x31C82F0", VA = "0x1831C98F0")]
	public static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>? LJPJHBDGIKO<TDeps, TStateSys>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<CFJBLOCLLGM> KALNIGICCJC, [In] ReadOnlySpan<int> KBLJCIIKDMO, [In] Span<OMLPKALPPGG> LHAINLPOBDO) where TDeps : IHOJBDIKHDC<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x31C9040", Offset = "0x31C7A40", VA = "0x1831C9040")]
	public static COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF> IAFGDJHDKOE<TDeps, TStateSys>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<IIGNEBOMHLM> PJCICAAFAEH) where TDeps : IHOJBDIKHDC<TStateSys>
	{
		return default(COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2A72D00", Offset = "0x2A71700", VA = "0x182A72D00")]
	public static CHBGCMCOPKD.OMKCGJOAJCB FOKHDOJPPKD([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> EGJGKBPPPFG)
	{
		return default(CHBGCMCOPKD.OMKCGJOAJCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2A72C50", Offset = "0x2A71650", VA = "0x182A72C50")]
	public static CHBGCMCOPKD.MPDCHCPINDA FOFFCBKPHPL([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> EGJGKBPPPFG)
	{
		return default(CHBGCMCOPKD.MPDCHCPINDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2A73540", Offset = "0x2A71F40", VA = "0x182A73540")]
	public static CHBGCMCOPKD.HFHCLMHLDMM INAEPECKBNL([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> EGJGKBPPPFG)
	{
		return default(CHBGCMCOPKD.HFHCLMHLDMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2A73C70", Offset = "0x2A72670", VA = "0x182A73C70")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> MKFKDLIANHI(this GKCECMAPKLA NLDLHIJAJBO, int? IFONBHFMBAG, string FLBFBHGDBLM)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2A73F10", Offset = "0x2A72910", VA = "0x182A73F10")]
	public static CHBGCMCOPKD.FEAKIKGOFBI NGBJGEDNCJK([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> EGJGKBPPPFG)
	{
		return default(CHBGCMCOPKD.FEAKIKGOFBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2A730A0", Offset = "0x2A71AA0", VA = "0x182A730A0")]
	public static CHBGCMCOPKD.HJKHJHJJMKA HLMILJAGDKJ([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> EGJGKBPPPFG)
	{
		return default(CHBGCMCOPKD.HJKHJHJJMKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2A737A0", Offset = "0x2A721A0", VA = "0x182A737A0")]
	public static int? KBDAPNPMJAI([In] this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> EGJGKBPPPFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x31C8E10", Offset = "0x31C7810", VA = "0x1831C8E10")]
	private static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> DGKCDGOGEFH<TMJoin>(this GKCECMAPKLA NLDLHIJAJBO, int? IFONBHFMBAG, CHBGCMCOPKD.HJKHJHJJMKA LJPDADGMNIB, COBPPOBACAG<TMJoin> FJJBJFLOGAP) where TMJoin : CHBGCMCOPKD.FMMEFOJFJLO
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2A74780", Offset = "0x2A73180", VA = "0x182A74780")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> POIJBIALJAN(this GKCECMAPKLA NLDLHIJAJBO, int? IFONBHFMBAG, COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII> NDEIKOOBOBC, int FILGHJLFKAL)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2A72F20", Offset = "0x2A71920", VA = "0x182A72F20")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> GPHAAILEAFD(this GKCECMAPKLA NLDLHIJAJBO, int? IFONBHFMBAG)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2A74570", Offset = "0x2A72F70", VA = "0x182A74570")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> PKAONOGDAPF(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>? KLNAAIPMMCJ, int? IFONBHFMBAG)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2A72E00", Offset = "0x2A71800", VA = "0x182A72E00")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> GBKGPMAPMGK(this GKCECMAPKLA NLDLHIJAJBO, int? IFONBHFMBAG, int FILGHJLFKAL)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2A72840", Offset = "0x2A71240", VA = "0x182A72840")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> BFOLDLIHJDP(this GKCECMAPKLA NLDLHIJAJBO, int? IFONBHFMBAG)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A72B20", Offset = "0x2A71520", VA = "0x182A72B20")]
	public static void EBKHFPDDFCI(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> MAPCAHLPHEI, COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII> NDEIKOOBOBC, int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2A724B0", Offset = "0x2A70EB0", VA = "0x182A724B0")]
	public static void AGALHHIIABP(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> MAPCAHLPHEI, int FILGHJLFKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2A73BB0", Offset = "0x2A725B0", VA = "0x182A73BB0")]
	public static void MDFDLBLAANO(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> MAPCAHLPHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2A731E0", Offset = "0x2A71BE0", VA = "0x182A731E0")]
	public static void IALEDHJLAIM(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> IMFCAPGBDGB, COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ACBLOCOMOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2A74290", Offset = "0x2A72C90", VA = "0x182A74290")]
	public static void NIGNBGGJFMA(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> MAPCAHLPHEI, COBPPOBACAG<EIIIOAJCEPD<HDOLKGCHLPO>> LNPAGGLBAEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x31C8EF0", Offset = "0x31C78F0", VA = "0x1831C8EF0")]
	public static void EOKADIPMNFP<M>(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> MAPCAHLPHEI, COBPPOBACAG<EIIIOAJCEPD<MLOCJABKMLJ<M>>> LNPAGGLBAEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IHOJBDIKHDC<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	COBPPOBACAG<JIAAFONGLED> NAPEJJGPIGC(TStateSys DKKINNHHNDG);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	COBPPOBACAG<JIAAFONGLED> KFHKMHBOCKP(TStateSys DKKINNHHNDG);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	COBPPOBACAG<JIAAFONGLED> LDOPMEAHMDK(TStateSys DKKINNHHNDG);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	COBPPOBACAG<JIAAFONGLED> DIJCJDKNMEO(TStateSys DKKINNHHNDG);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF> OFFEHKJKNCA(TStateSys DKKINNHHNDG, GKCECMAPKLA EHLPLKANNDI, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> GJMFPBJNLGE(TStateSys DKKINNHHNDG, GKCECMAPKLA EHLPLKANNDI, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<IIGNEBOMHLM> PJCICAAFAEH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DMMFICPCAFJ(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	COBPPOBACAG<IIGNEBOMHLM> MCNLIIIPMHH(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN, int LBLHGIGCCJF);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	DNJFGCOJKEK KIKBEBNDGGK(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool KNBNDJNGLCH(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int MIGJKOFGAKD(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KNEFAFDDNNC<byte> HDAKCCNEFPG(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(KNEFAFDDNNC<byte>, COBPPOBACAG<JIAAFONGLED>) MEAHIONBOKG(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<BHNPPOPBMAI> PCKBHKCCEGN);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int PPDHJNEJDEI(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<IIGNEBOMHLM> PJCICAAFAEH);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	COBPPOBACAG<BHNPPOPBMAI> MGCBAAIBBKA(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<IIGNEBOMHLM> PJCICAAFAEH, int FOFPDNPBFFD);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	COBPPOBACAG<BHNPPOPBMAI> LNIKHNJNJMA(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<CFJBLOCLLGM> KALNIGICCJC, int FOFPDNPBFFD);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int LIBCEJKOEPB(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? LIBPODHEAFB(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, int FILGHJLFKAL);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int ODNHEIMDPIJ(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? GBNECFHIFJG(TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, int FILGHJLFKAL);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EPBMPLEHHHB
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3AE9F10", Offset = "0x3AE8910", VA = "0x183AE9F10")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA?> AFBCJOAHGKK<T, TOpInput, TOpOutput>(this GKCECMAPKLA NLDLHIJAJBO, T HEOFBNHHDGF, T HEGCIIKIHGF, int KLNCFMHLHGC, IntPtr FEPLAELCNLG)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3AEA1B0", Offset = "0x3AE8BB0", VA = "0x183AEA1B0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA?> DDAAMMFMNAD<T, TOpInput, TOpOutput>(this GKCECMAPKLA NLDLHIJAJBO, T HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF, int KLNCFMHLHGC, IntPtr FEPLAELCNLG)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AECE50", Offset = "0x3AEB850", VA = "0x183AECE50")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA?> PLGGDIOIJKB<TOpInput, TOpOutput>(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF, int KLNCFMHLHGC, IntPtr FEPLAELCNLG)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2A775A0", Offset = "0x2A75FA0", VA = "0x182A775A0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> GEMMKHAOGPF(this GKCECMAPKLA NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2A755D0", Offset = "0x2A73FD0", VA = "0x182A755D0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> AJEIBNKAHGF(this GKCECMAPKLA NLDLHIJAJBO, float OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2A78FC0", Offset = "0x2A779C0", VA = "0x182A78FC0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> LIPLCKAMHAP(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2A79420", Offset = "0x2A77E20", VA = "0x182A79420")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> MJIJAGKOHCG(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A77E80", Offset = "0x2A76880", VA = "0x182A77E80")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> JOJFACICKME(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A1C0", Offset = "0x2A78BC0", VA = "0x182A7A1C0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> PNNJDOGLIGO(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A300", Offset = "0x2A78D00", VA = "0x182A7A300")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> PPHEJNADODI(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2A76130", Offset = "0x2A74B30", VA = "0x182A76130")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> CGFNOOENMFG(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2A778A0", Offset = "0x2A762A0", VA = "0x182A778A0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> GPPJCEJOACM(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2A79D40", Offset = "0x2A78740", VA = "0x182A79D40")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NONIFIEEKLL(this GKCECMAPKLA NLDLHIJAJBO, int HEOFBNHHDGF, int HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2A779E0", Offset = "0x2A763E0", VA = "0x182A779E0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HBMFEDLBGKD(this GKCECMAPKLA NLDLHIJAJBO, int HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2A78A40", Offset = "0x2A77440", VA = "0x182A78A40")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> LBCHFIBEIMI(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2A77FA0", Offset = "0x2A769A0", VA = "0x182A77FA0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> JPDMJNALDHO(this GKCECMAPKLA NLDLHIJAJBO, float HEOFBNHHDGF, float HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2A76350", Offset = "0x2A74D50", VA = "0x182A76350")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> COCKJFLBJMO(this GKCECMAPKLA NLDLHIJAJBO, float HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2A75FF0", Offset = "0x2A749F0", VA = "0x182A75FF0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> CEBJJLHCJAJ(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2A77B00", Offset = "0x2A76500", VA = "0x182A77B00")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEDJNLLBPDH(this GKCECMAPKLA NLDLHIJAJBO, int HEOFBNHHDGF, int HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2A77420", Offset = "0x2A75E20", VA = "0x182A77420")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> FMOINBOOPGE(this GKCECMAPKLA NLDLHIJAJBO, int HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2A79100", Offset = "0x2A77B00", VA = "0x182A79100")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> LLFCPLBENDH(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2A776A0", Offset = "0x2A760A0", VA = "0x182A776A0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> GGLONCCJMFF(this GKCECMAPKLA NLDLHIJAJBO, float HEOFBNHHDGF, float HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2A76D60", Offset = "0x2A75760", VA = "0x182A76D60")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> EBAOHANNPJC(this GKCECMAPKLA NLDLHIJAJBO, float HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2A77B80", Offset = "0x2A76580", VA = "0x182A77B80")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> IALLFMPKIOD(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2A781A0", Offset = "0x2A76BA0", VA = "0x182A781A0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> KCFOGCBPKJO(this GKCECMAPKLA NLDLHIJAJBO, int HEOFBNHHDGF, int HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2A79620", Offset = "0x2A78020", VA = "0x182A79620")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKHGFMPMFA(this GKCECMAPKLA NLDLHIJAJBO, int HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2A78220", Offset = "0x2A76C20", VA = "0x182A78220")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> KGDOGBOFKOL(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2A77E00", Offset = "0x2A76800", VA = "0x182A77E00")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> JKMMHKKEENE(this GKCECMAPKLA NLDLHIJAJBO, float HEOFBNHHDGF, float HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2A768B0", Offset = "0x2A752B0", VA = "0x182A768B0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> DFPDCLCJIHO(this GKCECMAPKLA NLDLHIJAJBO, float HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2A76BF0", Offset = "0x2A755F0", VA = "0x182A76BF0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> DLOMOBFFPIF(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2A76DE0", Offset = "0x2A757E0", VA = "0x182A76DE0")]
	public static COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> EJFLEPGJOKC(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2A76FC0", Offset = "0x2A759C0", VA = "0x182A76FC0")]
	public static COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> ENKCOGKMFOH(this GKCECMAPKLA NLDLHIJAJBO, int PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2A78B80", Offset = "0x2A77580", VA = "0x182A78B80")]
	public static COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> LDJGLNKAMJM(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2A77040", Offset = "0x2A75A40", VA = "0x182A77040")]
	public static COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> FDILAHIFMFH(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> CCABBMGMCJL)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2A76930", Offset = "0x2A75330", VA = "0x182A76930")]
	public static COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> DGHPIBLIFFA(this GKCECMAPKLA NLDLHIJAJBO, int PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2A79B60", Offset = "0x2A78560", VA = "0x182A79B60")]
	public static COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> NNHBCJBFPFN(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2A785D0", Offset = "0x2A76FD0", VA = "0x182A785D0")]
	public static (COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>) KOHFEKMDMLK(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<COKJODFCCBA> MJFDHPAECKH, [In] ReadOnlySpan<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> JEAMHIFDMBF, [In] ReadOnlySpan<int?> BDBBIAPFPMN, [In] Span<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> BCBEBKPGNIL)
	{
		return default((COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2A75940", Offset = "0x2A74340", VA = "0x182A75940")]
	public static (COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>) BJKIJAMLCAC(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<KGIFHJJEBBG> CHFJGIMKONH, [In] ReadOnlySpan<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> JEAMHIFDMBF, [In] ReadOnlySpan<int?> BDBBIAPFPMN, [In] Span<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> BCBEBKPGNIL)
	{
		return default((COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3AEB940", Offset = "0x3AEA340", VA = "0x183AEB940")]
	public static (COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<JIAAFONGLED>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<TMarker>>, COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>) GPIHNLBFKCG<TMarker>(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<JIAAFONGLED> EJNANNHGLDF, [In] ReadOnlySpan<byte> GPCDCFCPGFK)
	{
		return default((COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<EIIIOAJCEPD<JIAAFONGLED>>, COBPPOBACAG<EIIIOAJCEPD<AOALJIIJMIN>>, COBPPOBACAG<EIIIOAJCEPD<TMarker>>, COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2A77D40", Offset = "0x2A76740", VA = "0x182A77D40")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> JFDFGIBNHJF(this GKCECMAPKLA NLDLHIJAJBO, int LJJKDPNMLNL, [Optional] COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>? GHCLINPMECF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2A76C70", Offset = "0x2A75670", VA = "0x182A76C70")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> DMEPEALAGME(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> LJJKDPNMLNL, [Optional] COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>? GHCLINPMECF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2A782A0", Offset = "0x2A76CA0", VA = "0x182A782A0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> KGHLMCPDCEK(this GKCECMAPKLA NLDLHIJAJBO, [In] ReadOnlySpan<byte> LJJKDPNMLNL, [Optional] COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>? GHCLINPMECF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2A75270", Offset = "0x2A73C70", VA = "0x182A75270")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> ACEFBJEHCEM(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> LJJKDPNMLNL, int CGAAPEOHPIP, [Optional] COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>? GHCLINPMECF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2A77720", Offset = "0x2A76120", VA = "0x182A77720")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> GIJCBPMNKCO(this GKCECMAPKLA NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2A769B0", Offset = "0x2A753B0", VA = "0x182A769B0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> DHEIAPHBDDJ(this GKCECMAPKLA NLDLHIJAJBO, float OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2A79180", Offset = "0x2A77B80", VA = "0x182A79180")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> MDGODABCKMK(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2A780A0", Offset = "0x2A76AA0", VA = "0x182A780A0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> KBOPMPLODFO(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2A756F0", Offset = "0x2A740F0", VA = "0x182A756F0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> AOHKOHMPPLC(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2A79C00", Offset = "0x2A78600", VA = "0x182A79C00")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NOGIDMGBKPP(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2A796A0", Offset = "0x2A780A0", VA = "0x182A796A0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NGKMJMKCKMH(this GKCECMAPKLA NLDLHIJAJBO, int HEOFBNHHDGF, int HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2A77820", Offset = "0x2A76220", VA = "0x182A77820")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> GJMHAIMKJBO(this GKCECMAPKLA NLDLHIJAJBO, int HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2A79AE0", Offset = "0x2A784E0", VA = "0x182A79AE0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NLOLFHEHKFF(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEOFBNHHDGF, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> HEGCIIKIHGF)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2A77320", Offset = "0x2A75D20", VA = "0x182A77320")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> FKAPIPFBECM(this GKCECMAPKLA NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2A7A090", Offset = "0x2A78A90", VA = "0x182A7A090")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> PICBGDGMONJ(this GKCECMAPKLA NLDLHIJAJBO, float OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2A78E80", Offset = "0x2A77880", VA = "0x182A78E80")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> LFPKBGIOMEN(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2A76250", Offset = "0x2A74C50", VA = "0x182A76250")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> CILKLNNGJBH(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2A78D60", Offset = "0x2A77760", VA = "0x182A78D60")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> LFOMOPOICOH(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2A78C20", Offset = "0x2A77620", VA = "0x182A78C20")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> LEEFPLGBIKG(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2A79400", Offset = "0x2A77E00", VA = "0x182A79400")]
	public static COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>> MIGDLHLEEFL(this GKCECMAPKLA NLDLHIJAJBO)
	{
		return default(COBPPOBACAG<EIIIOAJCEPD<EIIIOAJCEPD<AALHAEKNAFA>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2A78390", Offset = "0x2A76D90", VA = "0x182A78390")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> KHEPHDNCFHJ(this GKCECMAPKLA NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2A76AD0", Offset = "0x2A754D0", VA = "0x182A76AD0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> DJGKNEEEACD(this GKCECMAPKLA NLDLHIJAJBO, float OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2A792C0", Offset = "0x2A77CC0", VA = "0x182A792C0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> MIABMGGEGPH(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2A75EF0", Offset = "0x2A748F0", VA = "0x182A75EF0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> BMNKEPKILBG(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2A75150", Offset = "0x2A73B50", VA = "0x182A75150")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> ABCPHHBDIIM(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2A75DB0", Offset = "0x2A747B0", VA = "0x182A75DB0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> BMAGJEIAKKH(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2A77220", Offset = "0x2A75C20", VA = "0x182A77220")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> FDKKPGADNEC(this GKCECMAPKLA NLDLHIJAJBO, int PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2A79E40", Offset = "0x2A78840", VA = "0x182A79E40")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OKACADFPDJN(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> PDKJBMPOMNC)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2A75810", Offset = "0x2A74210", VA = "0x182A75810")]
	public static void APGNOKINALI(this GKCECMAPKLA NLDLHIJAJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2A754D0", Offset = "0x2A73ED0", VA = "0x182A754D0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> AICJNBCCLNG(this GKCECMAPKLA NLDLHIJAJBO, float OGEEJDNANBD, float NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2A75820", Offset = "0x2A74220", VA = "0x182A75820")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> BDEHNABIIDN(this GKCECMAPKLA NLDLHIJAJBO, float OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2A77C00", Offset = "0x2A76600", VA = "0x182A77C00")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> ILELJGMGAIK(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2A774A0", Offset = "0x2A75EA0", VA = "0x182A774A0")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> GCIJPHHAKAI(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2A76790", Offset = "0x2A75190", VA = "0x182A76790")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> DECCCBBEKAA(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2A79F50", Offset = "0x2A78950", VA = "0x182A79F50")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> PFDCEEKDLOJ(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2A79720", Offset = "0x2A78120", VA = "0x182A79720")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NKKIBGEBABF(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> AFHKCEBGPGP, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> GNNCMAIABGH)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2A79520", Offset = "0x2A77F20", VA = "0x182A79520")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NAEHOFKLPHA(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, int NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2A75030", Offset = "0x2A73A30", VA = "0x182A75030")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> AAFDDNBHDBH(this GKCECMAPKLA NLDLHIJAJBO, int OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2A75390", Offset = "0x2A73D90", VA = "0x182A75390")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> AEHLKFBIHLP(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> OGEEJDNANBD, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> NEKBMMAICDE)
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3AEBA30", Offset = "0x3AEA430", VA = "0x183AEBA30")]
	public static void IOCJEIEAIDJ<TDeps, TState>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TState BLKFHFCBEDC, COBPPOBACAG<COKJODFCCBA> MJFDHPAECKH, [In] ReadOnlySpan<COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>> CLPCKLOFKJF, [In] ReadOnlySpan<int?> BDBBIAPFPMN, [In] Span<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> BCBEBKPGNIL, [In] Span<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> PMGIODLJCCD, [In] ReadOnlySpan<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>?> AKHPPFECMGI) where TDeps : notnull, IHOJBDIKHDC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3AEC580", Offset = "0x3AEAF80", VA = "0x183AEC580")]
	public static void MKJLGHPMACD<TDeps, TState>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TState BLKFHFCBEDC, COBPPOBACAG<KGIFHJJEBBG> JENFFPGIJNL, [In] ReadOnlySpan<COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>> CCKLEGJNNHN, [In] ReadOnlySpan<int?> BDBBIAPFPMN, [In] Span<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> BCBEBKPGNIL, [In] Span<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>> PMGIODLJCCD, [In] ReadOnlySpan<COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>?> AKHPPFECMGI) where TDeps : notnull, IHOJBDIKHDC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3AEBF40", Offset = "0x3AEA940", VA = "0x183AEBF40")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> JPFHIDMOOME<TDeps, TState>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TState BLKFHFCBEDC, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> KLNAAIPMMCJ, [Optional] COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>? GHCLINPMECF) where TDeps : notnull, IHOJBDIKHDC<TState> where TState : notnull
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3AEA490", Offset = "0x3AE8E90", VA = "0x183AEA490")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> EFBJFJFLLIF<TDeps, TState>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TState BLKFHFCBEDC, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> JDGOANEGJCB, [Optional] COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>? GHCLINPMECF) where TDeps : notnull, IHOJBDIKHDC<TState> where TState : notnull
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3AEAC10", Offset = "0x3AE9610", VA = "0x183AEAC10")]
	public static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> GGLNHCMAGPD<TDeps, TStateSys>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TStateSys DKKINNHHNDG) where TDeps : notnull, IHOJBDIKHDC<TStateSys> where TStateSys : notnull
	{
		return default(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3AEA8C0", Offset = "0x3AE92C0", VA = "0x183AEA8C0")]
	public static COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF> EKAHEMCMAJM<TDeps, TStateSys>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TStateSys DKKINNHHNDG) where TDeps : notnull, IHOJBDIKHDC<TStateSys> where TStateSys : notnull
	{
		return default(COBPPOBACAG<GMPLDKLOIAO.ALPDPDDMIAF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2A78490", Offset = "0x2A76E90", VA = "0x182A78490")]
	public static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> KNGADJHGBGM(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> KJDHACNHGCA, IntPtr INNDFKJAOII, IntPtr BAAKMODOMEN)
	{
		return default(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2A76480", Offset = "0x2A74E80", VA = "0x182A76480")]
	public static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> DEBELMNIJLI(this GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> GJJCHNLBCLD, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> OENDPEBOOOF, IntPtr KIFDGPFEKFG, IntPtr ONLOMNIOION, IntPtr FNPLCFKMAAK, bool FJNBJKMHKPI)
	{
		return default(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3AEAF80", Offset = "0x3AE9980", VA = "0x183AEAF80")]
	public static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> GHNCHHLOBMA<TDeps, TState>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TState BLKFHFCBEDC, COBPPOBACAG<COKJODFCCBA> LADBLKGNGAN, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> GJJCHNLBCLD, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> OENDPEBOOOF, int? EPNDFBKMDEN, [Optional] IntPtr COFPLBNGIMO) where TDeps : notnull, IHOJBDIKHDC<TState> where TState : notnull
	{
		return default(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3AEB150", Offset = "0x3AE9B50", VA = "0x183AEB150")]
	private static COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> GHNCHHLOBMA<TDeps, TState>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TState BLKFHFCBEDC, COBPPOBACAG<COKJODFCCBA> LADBLKGNGAN, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> GJJCHNLBCLD, COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK> OENDPEBOOOF, int? EPNDFBKMDEN) where TDeps : notnull, IHOJBDIKHDC<TState> where TState : notnull
	{
		return default(COBPPOBACAG<DHJOCINNCIA.INJNEGKAAPK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3AEC100", Offset = "0x3AEAB00", VA = "0x183AEC100")]
	public static COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> KLKKLMKBFHI<TDeps, TState>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TState BLKFHFCBEDC, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> LJJKDPNMLNL, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>? GHCLINPMECF) where TDeps : notnull, IHOJBDIKHDC<TState> where TState : notnull
	{
		return default(COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3AECA90", Offset = "0x3AEB490", VA = "0x183AECA90")]
	public static void NIEEBHPFGJJ<TDeps, TState>(this GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TState BLKFHFCBEDC, int OOBFIPEEFKB) where TDeps : notnull, IHOJBDIKHDC<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct BMPMAIEGOGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> FFGGIEPGEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> HLOAJIPHCMD;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xE83310", Offset = "0xE81D10", VA = "0x180E83310")]
	public BMPMAIEGOGJ(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> LHPFEFFCCIE, COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> NIMHMDKIBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2A74830", Offset = "0x2A73230", VA = "0x182A74830")]
	public static BMPMAIEGOGJ MDDJOGPLAFO(COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>> LHPFEFFCCIE)
	{
		return default(BMPMAIEGOGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct CHBGCMCOPKD
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class NGHKJBEOPPH : FMMEFOJFJLO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct OMKCGJOAJCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII> ECNNEOPPKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int ODEBCJMJOPK;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xE83310", Offset = "0xE81D10", VA = "0x180E83310")]
		public OMKCGJOAJCB(COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII> NDEIKOOBOBC, int FILGHJLFKAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class JOGFOHANNNG : FMMEFOJFJLO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct MPDCHCPINDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int ODEBCJMJOPK;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		public MPDCHCPINDA(int FILGHJLFKAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class IIOPBDBHJJB : FMMEFOJFJLO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct HFHCLMHLDMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII> ECNNEOPPKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int ODEBCJMJOPK;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xE83310", Offset = "0xE81D10", VA = "0x180E83310")]
		public HFHCLMHLDMM(COBPPOBACAG<KFBECEOFGEG.HHFNPFAKFII> NDEIKOOBOBC, int FILGHJLFKAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum HJKHJHJJMKA
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
	public sealed class CNALIFMLODA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class FMMEFOJFJLO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct KLIOGKMOGHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? OKEJFBHNDHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public BMPMAIEGOGJ PBGPIMEBGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public HJKHJHJJMKA NBGPLJBKGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public COBPPOBACAG<FMMEFOJFJLO> MKNDMLFKJDM;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C2C0", Offset = "0x2A7ACC0", VA = "0x182A7C2C0")]
		public KLIOGKMOGHP(int? IFONBHFMBAG, [In] BMPMAIEGOGJ PPKKENOOPKP, HJKHJHJJMKA LJPDADGMNIB, COBPPOBACAG<FMMEFOJFJLO> FJJBJFLOGAP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class FEKLJKDCOIK : FMMEFOJFJLO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct FEAKIKGOFBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int ODEBCJMJOPK;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x152BB60", Offset = "0x152A560", VA = "0x18152BB60")]
		public FEAKIKGOFBI(int FILGHJLFKAL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal BEBEFGCCDLP<CNALIFMLODA, KLIOGKMOGHP> IJJDJNJFMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal BEBEFGCCDLP<NGHKJBEOPPH, OMKCGJOAJCB> JALCKIKLEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal BEBEFGCCDLP<IIOPBDBHJJB, HFHCLMHLDMM> BPJMIHHJJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal BEBEFGCCDLP<FEKLJKDCOIK, FEAKIKGOFBI> PJKFNFPFKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal BEBEFGCCDLP<JOGFOHANNNG, MPDCHCPINDA> IGIINLMLDHO;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2A74BF0", Offset = "0x2A735F0", VA = "0x182A74BF0")]
	private CHBGCMCOPKD([In] BEBEFGCCDLP<CNALIFMLODA, KLIOGKMOGHP> DIDFJPIPDBI, [In] BEBEFGCCDLP<NGHKJBEOPPH, OMKCGJOAJCB> LKOHBECMIEB, [In] BEBEFGCCDLP<IIOPBDBHJJB, HFHCLMHLDMM> FGNMLBPDKMF, [In] BEBEFGCCDLP<FEKLJKDCOIK, FEAKIKGOFBI> BPGIMDGMHDG, [In] BEBEFGCCDLP<JOGFOHANNNG, MPDCHCPINDA> GGCAMCDPBEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2A74A00", Offset = "0x2A73400", VA = "0x182A74A00")]
	public static CHBGCMCOPKD MDDJOGPLAFO()
	{
		return default(CHBGCMCOPKD);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class CABBKNEFPKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2A748E0", Offset = "0x2A732E0", VA = "0x182A748E0")]
	public static void NHMIPJFACPH(this CHBGCMCOPKD NLDLHIJAJBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GNHLEKKNAIH
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B1E0", Offset = "0x2A79BE0", VA = "0x182A7B1E0")]
	public static void JCNNIFHFEKH(GKCECMAPKLA NLDLHIJAJBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct IDIHJPCGING
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, KNGCAOLAHHO> JFPAODAELIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int NNCCMJCECAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int GBAPKLBBDAG;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2A7BA60", Offset = "0x2A7A460", VA = "0x182A7BA60")]
	private IDIHJPCGING([In] HCBAHOABANP<KFBECEOFGEG.BNAHLKCPLDH, KNGCAOLAHHO> PJGMLDDEHOD, int NFDLDJAOOAF, int GDEPJCOFOEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B820", Offset = "0x2A7A220", VA = "0x182A7B820")]
	public static IDIHJPCGING MDDJOGPLAFO()
	{
		return default(IDIHJPCGING);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7B890", Offset = "0x2A7A290", VA = "0x182A7B890")]
	public void NHMIPJFACPH([In] GKCECMAPKLA HBBBMBPBDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3CAB900", Offset = "0x3CAA300", VA = "0x183CAB900")]
	public static void JCNNIFHFEKH<TDeps, TStateSys>(GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TStateSys DKKINNHHNDG, COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE) where TDeps : notnull, IHOJBDIKHDC<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class MPNMBEHANHL
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2A7D250", Offset = "0x2A7BC50", VA = "0x182A7D250")]
	public static void JCNNIFHFEKH(GKCECMAPKLA NLDLHIJAJBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct EOBBAJJJFIP
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface KEKHFICGPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HHGPCBIFCNL(GNGEHCNCBFJ<byte> MFANGEKPLIN, int OJGCHMFEGHJ);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct OAFDPFBMNMF : KEKHFICGPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D7A0", Offset = "0x2A7C1A0", VA = "0x182A7D7A0", Slot = "4")]
		public void HHGPCBIFCNL(GNGEHCNCBFJ<byte> MFANGEKPLIN, int OJGCHMFEGHJ)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct BOPGMEILIAL : KEKHFICGPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2A74840", Offset = "0x2A73240", VA = "0x182A74840", Slot = "4")]
		public void HHGPCBIFCNL(GNGEHCNCBFJ<byte> MFANGEKPLIN, int OJGCHMFEGHJ)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct KFHKDBJJGCN : KEKHFICGPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2A7C1F0", Offset = "0x2A7ABF0", VA = "0x182A7C1F0", Slot = "4")]
		public void HHGPCBIFCNL(GNGEHCNCBFJ<byte> MFANGEKPLIN, int OJGCHMFEGHJ)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct PNFLHLCIPIN : KEKHFICGPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2A7D8F0", Offset = "0x2A7C2F0", VA = "0x182A7D8F0", Slot = "4")]
		public void HHGPCBIFCNL(GNGEHCNCBFJ<byte> MFANGEKPLIN, int OJGCHMFEGHJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class PGONONKKEHC<TCallProcessorDeps> where TCallProcessorDeps : struct, KEKHFICGPMO
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps CHPBOPOCLBJ;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4410A60", Offset = "0x440F460", VA = "0x184410A60")]
		public static int JCNNIFHFEKH<TDeps, TStateSys>(TDeps MADJNKEDNDC, TStateSys BLKFHFCBEDC, GKCECMAPKLA HBBBMBPBDCO, [In] GNGEHCNCBFJ<byte> ADDNKJJIBOJ, int CGEHFMOCKHC) where TDeps : IHOJBDIKHDC<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private GNGEHCNCBFJ<NBMKKHGAEPH> DPLPHBMJBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>> PFCPNLHKJLD;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2A74FF0", Offset = "0x2A739F0", VA = "0x182A74FF0")]
	private EOBBAJJJFIP([In] GNGEHCNCBFJ<NBMKKHGAEPH> KOAIBNBGFPP, Dictionary<COBPPOBACAG<EIIIOAJCEPD<AALHAEKNAFA>>, COBPPOBACAG<KFBECEOFGEG.BNAHLKCPLDH>> MCCBDFJNNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2A74EF0", Offset = "0x2A738F0", VA = "0x182A74EF0")]
	public static EOBBAJJJFIP MDDJOGPLAFO()
	{
		return default(EOBBAJJJFIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2A74FB0", Offset = "0x2A739B0", VA = "0x182A74FB0")]
	public void NHMIPJFACPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3AE70D0", Offset = "0x3AE5AD0", VA = "0x183AE70D0")]
	public static void JCNNIFHFEKH<TDeps, TStateSys>(GKCECMAPKLA NLDLHIJAJBO, TDeps MADJNKEDNDC, TStateSys DKKINNHHNDG) where TDeps : IHOJBDIKHDC<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class MDDJOEFEPAG
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct MHGMPFKBCED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> JAKLAMNDCGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int AGGFECKLIJD;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int CCAMFJNBLAI;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int CIBGNDDDJBB;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2A7CA90", Offset = "0x2A7B490", VA = "0x182A7CA90")]
	public static void JCNNIFHFEKH(GKCECMAPKLA NLDLHIJAJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C5F0", Offset = "0x2A7AFF0", VA = "0x182A7C5F0")]
	private static void CGHPFCLENBO([In] GKCECMAPKLA NLDLHIJAJBO, COBPPOBACAG<CHBGCMCOPKD.CNALIFMLODA> EGJGKBPPPFG, GNGEHCNCBFJ<byte> CJODEHGIAHJ, List<MHGMPFKBCED> BHIHOMGFFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C820", Offset = "0x2A7B220", VA = "0x182A7C820")]
	private static void CGHPFCLENBO(GNGEHCNCBFJ<byte> CJODEHGIAHJ, int CGAAPEOHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2A7C960", Offset = "0x2A7B360", VA = "0x182A7C960")]
	private static void HLBCNEKKPMF(GKCECMAPKLA NLDLHIJAJBO, List<MHGMPFKBCED> BHIHOMGFFOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class AJMBFDOHJOK<TDeps, TIndex, TValues> where TDeps : struct, MMKCOLBMJOD<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps CHPBOPOCLBJ;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x530E0E0", Offset = "0x530CAE0", VA = "0x18530E0E0")]
	public static void JCNNIFHFEKH([In] GNGEHCNCBFJ<NBMKKHGAEPH> KOAIBNBGFPP, int NHDJOCNLNFK, TValues EJKNLPOFFNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface MMKCOLBMJOD<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GNGEHCNCBFJ<TIndex> PJDAADNAKED(int NHDJOCNLNFK, [In] TValues EJKNLPOFFNN);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(TIndex FILGHJLFKAL, [In] TValues EJKNLPOFFNN);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDEIGHHFGND(TIndex FILGHJLFKAL, TValues EJKNLPOFFNN, COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PDKJBMPOMNC);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface MBEOLADBEBG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex CMKOLFLGNMK(int FILGHJLFKAL);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CFCHPHBGBKA(TIndex FILGHJLFKAL, [In] TValues EJKNLPOFFNN);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	COBPPOBACAG<EIIIOAJCEPD<LPPGLHMNLFG>> PHNIDFDBFII(TIndex FILGHJLFKAL, [In] TValues EJKNLPOFFNN);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class MBFLIBGDLHD<TDeps, TIndex, TValues> where TDeps : struct, MBEOLADBEBG<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps CHPBOPOCLBJ;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x580A440", Offset = "0x5808E40", VA = "0x18580A440")]
	public static GNGEHCNCBFJ<TIndex> JCNNIFHFEKH(int NHDJOCNLNFK, [In] TValues EJKNLPOFFNN)
	{
		return default(GNGEHCNCBFJ<TIndex>);
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
