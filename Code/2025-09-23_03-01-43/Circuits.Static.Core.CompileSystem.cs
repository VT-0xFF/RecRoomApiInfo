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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B6EF90", Offset = "0x2B6D590", VA = "0x182B6EF90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct NIGEFILAFME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public readonly AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> BIDNFKNJBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public readonly int CDOMHMKBDBB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xECAC90", Offset = "0xEC9290", VA = "0x180ECAC90")]
	public NIGEFILAFME(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> MKJJKBDAKLC, int PIOCNHLFCNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OAOOGAIHAMO
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class ENNHGGLGEJJ : FGGDALAEEMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct KNEDMGMEOFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly ADLLGELKECP<byte> PNDPDEALCCN;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AF9070", Offset = "0x2AF7670", VA = "0x182AF9070")]
		public KNEDMGMEOFC(ADLLGELKECP<byte> EIJIDGHNNNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B66C90", Offset = "0x2B65290", VA = "0x182B66C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class HJLAPGBAIEG : FGGDALAEEMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public readonly struct JDDOFACBKHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> KFIAGEAPNPA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
		public JDDOFACBKHN(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> JNGPFKNBNEB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum DAMMIHGDBFN
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
	public sealed class JCHEMFDMHGL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class FGGDALAEEMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public readonly struct OJJNADFHIMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly DAMMIHGDBFN KCAOLIJOLKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly AIOJMGEOJFK<FGGDALAEEMA> FNNCAHBEJGF;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xECAC90", Offset = "0xEC9290", VA = "0x180ECAC90")]
		public OJJNADFHIMK(DAMMIHGDBFN NDLIDFKNCIJ, AIOJMGEOJFK<FGGDALAEEMA> FBNOFEEHOMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public sealed class IPAEHIKJDDH : FGGDALAEEMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public readonly struct NNAMBKMPGLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> ECHMMCONKGH;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
		public NNAMBKMPGLB(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KOCEENMADIJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class CBODMMNLCFH : FGGDALAEEMA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public readonly struct FAGNGOBBHCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly BIEIIMGPOMM GOKEBBNEDHF;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
		public FAGNGOBBHCH(BIEIIMGPOMM MPOOLKBDFFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2B65F60", Offset = "0x2B64560", VA = "0x182B65F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal BHJPABIMNKA<JCHEMFDMHGL, OJJNADFHIMK> IPCDKIIKHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal BHJPABIMNKA<ENNHGGLGEJJ, KNEDMGMEOFC> GPFALIOIOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal BHJPABIMNKA<HJLAPGBAIEG, JDDOFACBKHN> CBDPJHJJOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal BHJPABIMNKA<IPAEHIKJDDH, NNAMBKMPGLB> OOLHDOHALJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal BHJPABIMNKA<CBODMMNLCFH, FAGNGOBBHCH> FLOJCALBOPL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F1E0", Offset = "0x2B6D7E0", VA = "0x182B6F1E0")]
	private OAOOGAIHAMO([In] BHJPABIMNKA<JCHEMFDMHGL, OJJNADFHIMK> OEOGOKGCNDD, [In] BHJPABIMNKA<ENNHGGLGEJJ, KNEDMGMEOFC> LFGGHBOHKCC, [In] BHJPABIMNKA<HJLAPGBAIEG, JDDOFACBKHN> IPDELHLHMKO, [In] BHJPABIMNKA<IPAEHIKJDDH, NNAMBKMPGLB> CBMHJFHCDBG, [In] BHJPABIMNKA<CBODMMNLCFH, FAGNGOBBHCH> DLINEBOJHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F0A0", Offset = "0x2B6D6A0", VA = "0x182B6F0A0")]
	public static OAOOGAIHAMO CPNHECDILPK()
	{
		return default(OAOOGAIHAMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HKPADEMFILM
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2B664A0", Offset = "0x2B64AA0", VA = "0x182B664A0")]
	public static void GELLEPHLJAH(this OAOOGAIHAMO JNMMMBJNOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum CIGPNEIIOND
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
public struct OOFDDBHCLAP
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class EJGJECFAAGJ : EFFALGIMNBD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public readonly struct NFLFAAAACFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> MIEJHIDDKGO;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
		public NFLFAAAACFE(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> BHDOFCPPKAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public enum HFNMPAFAPHJ
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
	public sealed class OMHJNOJBENA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class EFFALGIMNBD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public readonly struct IGBCMGPLAFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly HFNMPAFAPHJ KCAOLIJOLKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly AIOJMGEOJFK<EFFALGIMNBD> FNNCAHBEJGF;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xECAC90", Offset = "0xEC9290", VA = "0x180ECAC90")]
		public IGBCMGPLAFJ(HFNMPAFAPHJ NDLIDFKNCIJ, AIOJMGEOJFK<EFFALGIMNBD> FBNOFEEHOMK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal BHJPABIMNKA<OMHJNOJBENA, IGBCMGPLAFJ> IPCDKIIKHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal BHJPABIMNKA<EJGJECFAAGJ, NFLFAAAACFE> GJLPMACKBDA;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B66800", Offset = "0x2B64E00", VA = "0x182B66800")]
	private OOFDDBHCLAP([In] BHJPABIMNKA<OMHJNOJBENA, IGBCMGPLAFJ> OEOGOKGCNDD, [In] BHJPABIMNKA<EJGJECFAAGJ, NFLFAAAACFE> AHDOBJHMLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F450", Offset = "0x2B6DA50", VA = "0x182B6F450")]
	public static OOFDDBHCLAP CPNHECDILPK()
	{
		return default(OOFDDBHCLAP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class LFBEEGGLKED
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2B670C0", Offset = "0x2B656C0", VA = "0x182B670C0")]
	public static void GELLEPHLJAH(this OOFDDBHCLAP JNMMMBJNOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BLOENPAKOMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NHNLFJGMEDN<int> LNOLMABBOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NHNLFJGMEDN<int> FLAHNKCGDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int MNGMJFLFEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int GOHLKEGOAIK;

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2B650B0", Offset = "0x2B636B0", VA = "0x182B650B0")]
	private BLOENPAKOMK([In] NHNLFJGMEDN<int> JHHBHAGBNKC, [In] NHNLFJGMEDN<int> LAKDLKIBDAO, int JEEPMELKHLC, int MIGBHFKLIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2B65010", Offset = "0x2B63610", VA = "0x182B65010")]
	public static BLOENPAKOMK CPNHECDILPK()
	{
		return default(BLOENPAKOMK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KPHPPFKIDIP
{
	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2B66EF0", Offset = "0x2B654F0", VA = "0x182B66EF0")]
	public static void GELLEPHLJAH(this BLOENPAKOMK JNMMMBJNOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct NNBPLNPNGBP
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum JDDBECBGCII
	{
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		External,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Internal,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Runtime
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public sealed class LFNKIDFCCBA : BEGAGAIENLH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public readonly struct BFFAKNHFDAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly AIOJMGEOJFK<ICIDECKPALE> HCJEJALLGMD;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
		public BFFAKNHFDAJ(AIOJMGEOJFK<ICIDECKPALE> PCECFFJOLBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public sealed class MCPKEADPILJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class BEGAGAIENLH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public readonly struct LFCGLCHOCML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly JDDBECBGCII KCAOLIJOLKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly AIOJMGEOJFK<BEGAGAIENLH> FNNCAHBEJGF;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xECAC90", Offset = "0xEC9290", VA = "0x180ECAC90")]
		private LFCGLCHOCML(JDDBECBGCII NDLIDFKNCIJ, AIOJMGEOJFK<BEGAGAIENLH> FBNOFEEHOMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2B67120", Offset = "0x2B65720", VA = "0x182B67120")]
		public static LFCGLCHOCML CPNHECDILPK(JDDBECBGCII NDLIDFKNCIJ, AIOJMGEOJFK<BEGAGAIENLH> FBNOFEEHOMK)
		{
			return default(LFCGLCHOCML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class GJDDKFBDBFD : BEGAGAIENLH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public readonly struct CHHFEOLLNIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly AIOJMGEOJFK<ICIDECKPALE> HCJEJALLGMD;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
		public CHHFEOLLNIM(AIOJMGEOJFK<ICIDECKPALE> PCECFFJOLBL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class ICIDECKPALE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public struct INCKCFODOPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NHNLFJGMEDN<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> KFNKAPLDHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NHNLFJGMEDN<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> IBBJFKJCPKP;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2B66800", Offset = "0x2B64E00", VA = "0x182B66800")]
		private INCKCFODOPA([In] NHNLFJGMEDN<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> MGPPHEGFGJP, [In] NHNLFJGMEDN<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> MDIMAGNNMFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2B66780", Offset = "0x2B64D80", VA = "0x182B66780")]
		public static INCKCFODOPA CPNHECDILPK()
		{
			return default(INCKCFODOPA);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	internal BHJPABIMNKA<MCPKEADPILJ, LFCGLCHOCML> IPCDKIIKHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	internal BHJPABIMNKA<GJDDKFBDBFD, CHHFEOLLNIM> HAHLJECIOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	internal BHJPABIMNKA<LFNKIDFCCBA, BFFAKNHFDAJ> AAMBHOPLHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	internal NHNLFJGMEDN<(AIOJMGEOJFK<MCPKEADPILJ> CallId, AIOJMGEOJFK<ICIDECKPALE> IOId)> BDFOOIPNADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	internal BHJPABIMNKA<ICIDECKPALE, INCKCFODOPA> LDHNGFCLJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal AGMAKDOIOBI<ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>> JGKFMBDCAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal AGMAKDOIOBI<ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>> MCEIOIOBMFM;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EED0", Offset = "0x2B6D4D0", VA = "0x182B6EED0")]
	private NNBPLNPNGBP([In] BHJPABIMNKA<MCPKEADPILJ, LFCGLCHOCML> OEOGOKGCNDD, [In] BHJPABIMNKA<GJDDKFBDBFD, CHHFEOLLNIM> PFPOOAJLJFJ, [In] BHJPABIMNKA<LFNKIDFCCBA, BFFAKNHFDAJ> FFGHGDEJLJB, [In] NHNLFJGMEDN<(AIOJMGEOJFK<MCPKEADPILJ> CallId, AIOJMGEOJFK<ICIDECKPALE> IOId)> MBIMHGGPFGL, [In] BHJPABIMNKA<ICIDECKPALE, INCKCFODOPA> DBIJFHBFJLP, [In] AGMAKDOIOBI<ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>> JBIGJEMLFNE, [In] AGMAKDOIOBI<ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>> AGNACEPJBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2B6ED30", Offset = "0x2B6D330", VA = "0x182B6ED30")]
	public static NNBPLNPNGBP CPNHECDILPK()
	{
		return default(NNBPLNPNGBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class NBKNLNIJKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E920", Offset = "0x2B6CF20", VA = "0x182B6E920")]
	private static void GELLEPHLJAH(this NNBPLNPNGBP.INCKCFODOPA JNMMMBJNOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E970", Offset = "0x2B6CF70", VA = "0x182B6E970")]
	public static void GELLEPHLJAH(this NNBPLNPNGBP JNMMMBJNOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public struct DILBINPLABC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public NHNLFJGMEDN<byte> DAIPFJOKLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal NNBPLNPNGBP KAFEBOIPALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal GKIOMMDHDFN CCCAAAOBOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal Dictionary<string, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> NPOLLOJOGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal OAOOGAIHAMO OPLAFADDKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal OOFDDBHCLAP BJBCONJICGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal AGMAKDOIOBI<DKKLODGCMAB, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>?> NEDGHAJCHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal NHNLFJGMEDN<AIOJMGEOJFK<DKKLODGCMAB>> PCBICKMPMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?> NKPAKPPLNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> VariableId, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>> ByteCodeWriteLocation)> CMLHOOFKCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	internal NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> NIKNNJCAHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal BDEDMJDDNPH KCJLAELLOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal FDNPJFKAONP HJAKJGGKOJE;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B65AD0", Offset = "0x2B640D0", VA = "0x182B65AD0")]
	private DILBINPLABC([In] NHNLFJGMEDN<byte> FECEADMKGKM, [In] NNBPLNPNGBP PLDFIKBBBCG, [In] GKIOMMDHDFN OGNCJMAFECI, [In] OAOOGAIHAMO EDIDJBJEAIM, [In] OOFDDBHCLAP IGJBBHHNEKO, [In] AGMAKDOIOBI<DKKLODGCMAB, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>?> BBDJLAJDDOD, [In] NHNLFJGMEDN<AIOJMGEOJFK<DKKLODGCMAB>> DPGILDNAABC, [In] AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?> BOFGDMBMAMA, [In] NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> VariableId, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>> ByteCodeWriteLocation)> JILFMDNEBON, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> PCBBNJPHMJK, [In] BDEDMJDDNPH MGGLPKDJCLK, [In] FDNPJFKAONP NKDBIJDGJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B65120", Offset = "0x2B63720", VA = "0x182B65120")]
	public static DILBINPLABC CPNHECDILPK()
	{
		return default(DILBINPLABC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class NBJGMEGKGEK
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private readonly struct LMNDNPPANEH : KLBBPIFNEFO<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>, AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B67160", Offset = "0x2B65760", VA = "0x182B67160")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2B67130", Offset = "0x2B65730", VA = "0x182B67130", Slot = "4")]
		public AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> KMGPOBDOJKI(int PMIGBJGNLLP)
		{
			return default(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
		public bool ODJFHHBJOBH(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "5")]
		private bool CCNAODODBGF(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2B67160", Offset = "0x2B65760", VA = "0x182B67160", Slot = "6")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> MJCACBGPEBE(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct LDBFAINDIJJ : NMIIPFIHAMN<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>, AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2B67050", Offset = "0x2B65650", VA = "0x182B67050")]
		public NHNLFJGMEDN<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>> LLDBCAIABBF(int NDODHNELJFD, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B66F40", Offset = "0x2B65540", VA = "0x182B66F40")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2B66FC0", Offset = "0x2B655C0", VA = "0x182B66FC0", Slot = "6")]
		public void EHBMPGNGFDM(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>> LGMBOCEBOMM, AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B67050", Offset = "0x2B65650", VA = "0x182B67050", Slot = "4")]
		private NHNLFJGMEDN<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>> NHCDMAKIKBF(int NDODHNELJFD, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B66F40", Offset = "0x2B65540", VA = "0x182B66F40", Slot = "5")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> AEGLPHJHHFL(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private readonly struct IEBHCAAOHJA : KLBBPIFNEFO<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>, AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2B66550", Offset = "0x2B64B50", VA = "0x182B66550")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2B665D0", Offset = "0x2B64BD0", VA = "0x182B665D0", Slot = "4")]
		public AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> KMGPOBDOJKI(int PMIGBJGNLLP)
		{
			return default(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
		public bool ODJFHHBJOBH(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "5")]
		private bool EJDLAKLKACD(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B66550", Offset = "0x2B64B50", VA = "0x182B66550", Slot = "6")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> FLLAICJCEEB(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private readonly struct IIAIDCADNBH : NMIIPFIHAMN<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>, AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>>>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x2B66710", Offset = "0x2B64D10", VA = "0x182B66710")]
		public NHNLFJGMEDN<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>> LLDBCAIABBF(int NDODHNELJFD, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2B66690", Offset = "0x2B64C90", VA = "0x182B66690")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2B66600", Offset = "0x2B64C00", VA = "0x182B66600", Slot = "6")]
		public void EHBMPGNGFDM(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>> LGMBOCEBOMM, AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2B66710", Offset = "0x2B64D10", VA = "0x182B66710", Slot = "4")]
		private NHNLFJGMEDN<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>> KKHNJAPDFKC(int NDODHNELJFD, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x2B66690", Offset = "0x2B64C90", VA = "0x182B66690", Slot = "5")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> HCEILAGOJBH(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PMIGBJGNLLP, [In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct KJOKLDNHOAL : KLBBPIFNEFO<AIOJMGEOJFK<OICMPGAJNLN>, AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x2B66B90", Offset = "0x2B65190", VA = "0x182B66B90")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(AIOJMGEOJFK<OICMPGAJNLN> PMIGBJGNLLP, [In] AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x2B66B60", Offset = "0x2B65160", VA = "0x182B66B60", Slot = "4")]
		public AIOJMGEOJFK<OICMPGAJNLN> KMGPOBDOJKI(int PMIGBJGNLLP)
		{
			return default(AIOJMGEOJFK<OICMPGAJNLN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B66C30", Offset = "0x2B65230", VA = "0x182B66C30")]
		public bool ODJFHHBJOBH(AIOJMGEOJFK<OICMPGAJNLN> PMIGBJGNLLP, [In] AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x2B66C30", Offset = "0x2B65230", VA = "0x182B66C30", Slot = "5")]
		private bool LIPJNNJDNLO(AIOJMGEOJFK<OICMPGAJNLN> PMIGBJGNLLP, [In] AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2B66B50", Offset = "0x2B65150", VA = "0x182B66B50", Slot = "6")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> EGKIMKGBCCI(AIOJMGEOJFK<OICMPGAJNLN> PMIGBJGNLLP, [In] AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct PFOHOOMAMCJ : NMIIPFIHAMN<AIOJMGEOJFK<OICMPGAJNLN>, AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F6D0", Offset = "0x2B6DCD0", VA = "0x182B6F6D0")]
		public NHNLFJGMEDN<AIOJMGEOJFK<OICMPGAJNLN>> LLDBCAIABBF(int NDODHNELJFD, [In] AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<AIOJMGEOJFK<OICMPGAJNLN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F800", Offset = "0x2B6DE00", VA = "0x182B6F800")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(AIOJMGEOJFK<OICMPGAJNLN> PMIGBJGNLLP, [In] AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F740", Offset = "0x2B6DD40", VA = "0x182B6F740", Slot = "6")]
		public void EHBMPGNGFDM(AIOJMGEOJFK<OICMPGAJNLN> PMIGBJGNLLP, AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?> LGMBOCEBOMM, AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F6D0", Offset = "0x2B6DCD0", VA = "0x182B6F6D0", Slot = "4")]
		private NHNLFJGMEDN<AIOJMGEOJFK<OICMPGAJNLN>> BCJDFCAAIGN(int NDODHNELJFD, [In] AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<AIOJMGEOJFK<OICMPGAJNLN>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F7F0", Offset = "0x2B6DDF0", VA = "0x182B6F7F0", Slot = "5")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> FMHJOEGBBAC(AIOJMGEOJFK<OICMPGAJNLN> PMIGBJGNLLP, [In] AGMAKDOIOBI<OICMPGAJNLN, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>?> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private readonly struct JAMFOPAIEAE : KLBBPIFNEFO<int, NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2B66850", Offset = "0x2B64E50", VA = "0x182B66850")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> VariableId, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xBBBE20", Offset = "0xBBA420", VA = "0x180BBBE20", Slot = "4")]
		public int KMGPOBDOJKI(int PMIGBJGNLLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
		public bool ODJFHHBJOBH(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> VariableId, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "5")]
		private bool CHMPGOMBMJN(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> VariableId, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x2B668D0", Offset = "0x2B64ED0", VA = "0x182B668D0", Slot = "6")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> NIIJBDBFKBO(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> VariableId, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	private readonly struct PFJPBHAKFIE : NMIIPFIHAMN<int, NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F660", Offset = "0x2B6DC60", VA = "0x182B6F660")]
		public NHNLFJGMEDN<int> LLDBCAIABBF(int NDODHNELJFD, [In] NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> VariableId, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F5E0", Offset = "0x2B6DBE0", VA = "0x182B6F5E0")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> VariableId, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F4E0", Offset = "0x2B6DAE0", VA = "0x182B6F4E0", Slot = "6")]
		public void EHBMPGNGFDM(int PMIGBJGNLLP, NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> VariableId, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>> ByteCodeWriteLocation)> LGMBOCEBOMM, AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F660", Offset = "0x2B6DC60", VA = "0x182B6F660", Slot = "4")]
		private NHNLFJGMEDN<int> MEMENHNGIOM(int NDODHNELJFD, [In] NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> VariableId, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F5D0", Offset = "0x2B6DBD0", VA = "0x182B6F5D0", Slot = "5")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> FIADKLGFPDO(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> VariableId, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<HIGOLCKHIEO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private readonly struct OBAHOOGAOLM : KLBBPIFNEFO<int, NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F270", Offset = "0x2B6D870", VA = "0x182B6F270")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xBBBE20", Offset = "0xBBA420", VA = "0x180BBBE20", Slot = "4")]
		public int KMGPOBDOJKI(int PMIGBJGNLLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
		public bool ODJFHHBJOBH(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "5")]
		private bool PNJJKEIAHIB(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F270", Offset = "0x2B6D870", VA = "0x182B6F270", Slot = "6")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KOCFNHDCMAN(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private readonly struct JFCMPLIENBF : NMIIPFIHAMN<int, NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2B669C0", Offset = "0x2B64FC0", VA = "0x182B669C0")]
		public NHNLFJGMEDN<int> LLDBCAIABBF(int NDODHNELJFD, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x2B66A30", Offset = "0x2B65030", VA = "0x182B66A30")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x2B668E0", Offset = "0x2B64EE0", VA = "0x182B668E0", Slot = "6")]
		public void EHBMPGNGFDM(int PMIGBJGNLLP, NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM, AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x2B669C0", Offset = "0x2B64FC0", VA = "0x182B669C0", Slot = "4")]
		private NHNLFJGMEDN<int> FEEMNNPOIJI(int NDODHNELJFD, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2B66A30", Offset = "0x2B65030", VA = "0x182B66A30", Slot = "5")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KENMHCPGJKA(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private readonly struct OACFAEHBOED : KLBBPIFNEFO<int, NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F010", Offset = "0x2B6D610", VA = "0x182B6F010")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xBBBE20", Offset = "0xBBA420", VA = "0x180BBBE20", Slot = "4")]
		public int KMGPOBDOJKI(int PMIGBJGNLLP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
		public bool ODJFHHBJOBH(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "5")]
		private bool PNJJKEIAHIB(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2B6F090", Offset = "0x2B6D690", VA = "0x182B6F090", Slot = "6")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KOCFNHDCMAN(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private readonly struct KODFJCGHMJB : NMIIPFIHAMN<int, NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>)>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x2B66DF0", Offset = "0x2B653F0", VA = "0x182B66DF0")]
		public NHNLFJGMEDN<int> LLDBCAIABBF(int NDODHNELJFD, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2B66E70", Offset = "0x2B65470", VA = "0x182B66E70")]
		public AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x2B66D00", Offset = "0x2B65300", VA = "0x182B66D00", Slot = "6")]
		public void EHBMPGNGFDM(int PMIGBJGNLLP, NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM, AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x2B66DF0", Offset = "0x2B653F0", VA = "0x182B66DF0", Slot = "4")]
		private NHNLFJGMEDN<int> FEEMNNPOIJI(int NDODHNELJFD, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(NHNLFJGMEDN<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x2B66E60", Offset = "0x2B65460", VA = "0x182B66E60", Slot = "5")]
		private AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KENMHCPGJKA(int PMIGBJGNLLP, [In] NHNLFJGMEDN<(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> Target, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> ByteCodeWriteLocation)> LGMBOCEBOMM)
		{
			return default(AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public readonly struct DGHNKLAHHEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> HAMJMJMEHCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly bool EHMAMCAIOIG;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x21D6EB0", Offset = "0x21D54B0", VA = "0x1821D6EB0")]
		public DGHNKLAHHEC(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO, bool OGPNBPCOIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x2B65110", Offset = "0x2B63710", VA = "0x182B65110")]
		public void HEAGIBMIAPN([Out] AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO, [Out] bool OGPNBPCOIOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct FANPAEDHHKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly AIOJMGEOJFK<OICMPGAJNLN> DDCGPJPBEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> HAMJMJMEHCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly bool EHMAMCAIOIG;

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x2B65FB0", Offset = "0x2B645B0", VA = "0x182B65FB0")]
		public FANPAEDHHKN(AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO, bool OGPNBPCOIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2B65F80", Offset = "0x2B64580", VA = "0x182B65F80")]
		public void HEAGIBMIAPN([Out] AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO, [Out] bool OGPNBPCOIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2B65F90", Offset = "0x2B64590", VA = "0x182B65F90")]
		public void HEAGIBMIAPN([Out] AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO, [Out] AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM, [Out] bool OGPNBPCOIOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public readonly struct BKIGFFJBFIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly AIOJMGEOJFK<OICMPGAJNLN> DDCGPJPBEGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> HAMJMJMEHCF;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xECAC90", Offset = "0xEC9290", VA = "0x180ECAC90")]
		public BKIGFFJBFIM(AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2B65000", Offset = "0x2B63600", VA = "0x182B65000")]
		public void HEAGIBMIAPN([Out] AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO, [Out] AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CF70", Offset = "0x2B6B570", VA = "0x182B6CF70")]
	public static void GELLEPHLJAH(this DILBINPLABC JNMMMBJNOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E180", Offset = "0x2B6C780", VA = "0x182B6E180")]
	public static void LGGPIBJKJIJ(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<DKKLODGCMAB> LCBAPKAFNJK, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> GCEEEIEIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CDF0", Offset = "0x2B6B3F0", VA = "0x182B6CDF0")]
	public static void ELDPGJCNHCO(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<DKKLODGCMAB> LCBAPKAFNJK, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> GCEEEIEIGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D240", Offset = "0x2B6B840", VA = "0x182B6D240")]
	public static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>? GLCGOLODPHM([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<DKKLODGCMAB> LCBAPKAFNJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C5A0", Offset = "0x2B6ABA0", VA = "0x182B6C5A0")]
	public static AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> ACGNFAPCACJ([In] this DILBINPLABC JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C8A0", Offset = "0x2B6AEA0", VA = "0x182B6C8A0")]
	private static void CJIABKEJKNL(this DILBINPLABC JNMMMBJNOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E7C0", Offset = "0x2B6CDC0", VA = "0x182B6E7C0")]
	private static AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>? OOOAHONLDGC([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CC80", Offset = "0x2B6B280", VA = "0x182B6CC80")]
	public static void EBAFPJFHCGP(this DILBINPLABC JNMMMBJNOND, [In] NHNLFJGMEDN<NIGEFILAFME> ONNHBLDKDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D9C0", Offset = "0x2B6BFC0", VA = "0x182B6D9C0")]
	public static OAOOGAIHAMO.DAMMIHGDBFN JHHMBMKLFOC([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO)
	{
		return default(OAOOGAIHAMO.DAMMIHGDBFN);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C6C0", Offset = "0x2B6ACC0", VA = "0x182B6C6C0")]
	public static ADLLGELKECP<byte> BCFLPDHALML([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO)
	{
		return default(ADLLGELKECP<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E480", Offset = "0x2B6CA80", VA = "0x182B6E480")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> MCHIFGJPBHH([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D8B0", Offset = "0x2B6BEB0", VA = "0x182B6D8B0")]
	public static BIEIIMGPOMM JCJLKGGJOHD([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO)
	{
		return default(BIEIIMGPOMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3F41D10", Offset = "0x3F40310", VA = "0x183F41D10")]
	private static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> HBLMDKLKBLF<TMJoin>(this DILBINPLABC JNMMMBJNOND, OAOOGAIHAMO.DAMMIHGDBFN NDLIDFKNCIJ, AIOJMGEOJFK<TMJoin> FBNOFEEHOMK) where TMJoin : OAOOGAIHAMO.FGGDALAEEMA
	{
		return default(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E3A0", Offset = "0x2B6C9A0", VA = "0x182B6E3A0")]
	public static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> LJGPNEONBDM(this DILBINPLABC JNMMMBJNOND, bool BAGCEIOAFAC)
	{
		return default(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D330", Offset = "0x2B6B930", VA = "0x182B6D330")]
	public static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> HCHODPLLECA(this DILBINPLABC JNMMMBJNOND, ADLLGELKECP<byte> EIJIDGHNNNL)
	{
		return default(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E610", Offset = "0x2B6CC10", VA = "0x182B6E610")]
	public static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> NEBDAGBNGPJ(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> JNGPFKNBNEB)
	{
		return default(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E740", Offset = "0x2B6CD40", VA = "0x182B6E740")]
	public static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> OOCMOBCBHNN(this DILBINPLABC JNMMMBJNOND, int AKEMJGPPHCG)
	{
		return default(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D620", Offset = "0x2B6BC20", VA = "0x182B6D620")]
	public static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> ICEANIBAMOA(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KOCEENMADIJ)
	{
		return default(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3F42C10", Offset = "0x3F41210", VA = "0x183F42C10")]
	private static AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA> LCCHHPIIJMA<TMJoin>(this DILBINPLABC JNMMMBJNOND, OOFDDBHCLAP.HFNMPAFAPHJ NDLIDFKNCIJ, AIOJMGEOJFK<TMJoin> FBNOFEEHOMK) where TMJoin : OOFDDBHCLAP.EFFALGIMNBD
	{
		return default(AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D5E0", Offset = "0x2B6BBE0", VA = "0x182B6D5E0")]
	public static AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA> HHKCDOJPEDF(this DILBINPLABC JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CB30", Offset = "0x2B6B130", VA = "0x182B6CB30")]
	public static AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA> DKHHIBCILHK(this DILBINPLABC JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CAB0", Offset = "0x2B6B0B0", VA = "0x182B6CAB0")]
	public static AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA> DIILMFJFEAN(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> BHDOFCPPKAM)
	{
		return default(AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D3C0", Offset = "0x2B6B9C0", VA = "0x182B6D3C0")]
	public static AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA> HFICHMDMPBA(this DILBINPLABC JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CC30", Offset = "0x2B6B230", VA = "0x182B6CC30")]
	public static AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA> DPFBENIOLJH(this DILBINPLABC JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E420", Offset = "0x2B6CA20", VA = "0x182B6E420")]
	public static NNBPLNPNGBP.JDDBECBGCII LKNOCABFPAO([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ> PDCBJNKPMHP)
	{
		return default(NNBPLNPNGBP.JDDBECBGCII);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E850", Offset = "0x2B6CE50", VA = "0x182B6E850")]
	public static LMAMBNHNDEF<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>, DCPBHLOKEFF<NNBPLNPNGBP.ICIDECKPALE>> OPOJELCNINM([In] this DILBINPLABC JNMMMBJNOND)
	{
		return default(LMAMBNHNDEF<AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>, DCPBHLOKEFF<NNBPLNPNGBP.ICIDECKPALE>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E000", Offset = "0x2B6C600", VA = "0x182B6E000")]
	public static AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> LBEMNAKGEAD([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ> PDCBJNKPMHP)
	{
		return default(AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DFA0", Offset = "0x2B6C5A0", VA = "0x182B6DFA0")]
	public static NNBPLNPNGBP.INCKCFODOPA KKNIBMEICEH([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PCECFFJOLBL)
	{
		return default(NNBPLNPNGBP.INCKCFODOPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D7C0", Offset = "0x2B6BDC0", VA = "0x182B6D7C0")]
	public static NNBPLNPNGBP.INCKCFODOPA ILKBHACGEED(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PCECFFJOLBL)
	{
		return default(NNBPLNPNGBP.INCKCFODOPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3F42B80", Offset = "0x3F41180", VA = "0x183F42B80")]
	private static AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ> KDJMHHGLKJF<TMJoin>(this DILBINPLABC JNMMMBJNOND, NNBPLNPNGBP.JDDBECBGCII NDLIDFKNCIJ, AIOJMGEOJFK<TMJoin> FBNOFEEHOMK) where TMJoin : NNBPLNPNGBP.BEGAGAIENLH
	{
		return default(AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DA20", Offset = "0x2B6C020", VA = "0x182B6DA20")]
	public static (AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>) JMKOCAOOFON(this DILBINPLABC JNMMMBJNOND)
	{
		return default((AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DBD0", Offset = "0x2B6C1D0", VA = "0x182B6DBD0")]
	public static (AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>) JNMFALIFINH(this DILBINPLABC JNMMMBJNOND)
	{
		return default((AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E5C0", Offset = "0x2B6CBC0", VA = "0x182B6E5C0")]
	public static AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ> MIOIOOKNOEK(this DILBINPLABC JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E890", Offset = "0x2B6CE90", VA = "0x182B6E890")]
	public static void PBHOJACIIOL(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE> PCECFFJOLBL, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> IMMKGEOJIKN, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>> NJPGMDNMGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3F41DA0", Offset = "0x3F403A0", VA = "0x183F41DA0")]
	public static DGHNKLAHHEC JMHJCKMELCG<TDeps, TStateSys>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM) where TDeps : NBEABGMEFGC<TStateSys>
	{
		return default(DGHNKLAHHEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3F42CA0", Offset = "0x3F412A0", VA = "0x183F42CA0")]
	public static FANPAEDHHKN MALMCKEPHJO<TDeps, TStateSys>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OMGMEOLCEJA> PLBMJMHLGMM, int KMEJGFPEMOG) where TDeps : NBEABGMEFGC<TStateSys>
	{
		return default(FANPAEDHHKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F418F0", Offset = "0x3F3FEF0", VA = "0x183F418F0")]
	public static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>? GACLEFCINII<TDeps, TStateSys>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OMGMEOLCEJA> PLBMJMHLGMM, [In] ReadOnlySpan<int> HFJOALPIGLN, [In] Span<BKIGFFJBFIM> BGFCFFEFNLE) where TDeps : NBEABGMEFGC<TStateSys>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3F42F20", Offset = "0x3F41520", VA = "0x183F42F20")]
	public static AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA> PCECMMCGLKA<TDeps, TStateSys>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<DKKLODGCMAB> LCBAPKAFNJK) where TDeps : NBEABGMEFGC<TStateSys>
	{
		return default(AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D530", Offset = "0x2B6BB30", VA = "0x182B6D530")]
	public static GKIOMMDHDFN.FEMBNPOIKIH HGCIJPLFDJM([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NMILEMOAODL)
	{
		return default(GKIOMMDHDFN.FEMBNPOIKIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E690", Offset = "0x2B6CC90", VA = "0x182B6E690")]
	public static GKIOMMDHDFN.BGAFGAPEBJC NNELBLPHCLO([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NMILEMOAODL)
	{
		return default(GKIOMMDHDFN.BGAFGAPEBJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CB80", Offset = "0x2B6B180", VA = "0x182B6CB80")]
	public static GKIOMMDHDFN.LDONHKCPINM DMBBGNOMIFC([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NMILEMOAODL)
	{
		return default(GKIOMMDHDFN.LDONHKCPINM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DDE0", Offset = "0x2B6C3E0", VA = "0x182B6DDE0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KHNKHKBCEDH(this DILBINPLABC JNMMMBJNOND, int? KGLAMBDGAEL, string NDIENANOGEK)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CA00", Offset = "0x2B6B000", VA = "0x182B6CA00")]
	public static GKIOMMDHDFN.LJOFAKJAKFF DEALLPANBAP([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NMILEMOAODL)
	{
		return default(GKIOMMDHDFN.LJOFAKJAKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D2D0", Offset = "0x2B6B8D0", VA = "0x182B6D2D0")]
	public static GKIOMMDHDFN.HCFPDBGOKHD HBJODLACPGE([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NMILEMOAODL)
	{
		return default(GKIOMMDHDFN.HCFPDBGOKHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D760", Offset = "0x2B6BD60", VA = "0x182B6D760")]
	public static int? IIEKGJFEBMJ([In] this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NMILEMOAODL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3F41810", Offset = "0x3F3FE10", VA = "0x183F41810")]
	private static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DLKEDMNAKHA<TMJoin>(this DILBINPLABC JNMMMBJNOND, int? KGLAMBDGAEL, GKIOMMDHDFN.HCFPDBGOKHD NDLIDFKNCIJ, AIOJMGEOJFK<TMJoin> FBNOFEEHOMK) where TMJoin : GKIOMMDHDFN.EPENECFNPLA
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2B6CEC0", Offset = "0x2B6B4C0", VA = "0x182B6CEC0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> FDOIEGIFNGP(this DILBINPLABC JNMMMBJNOND, int? KGLAMBDGAEL, AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ> PDCBJNKPMHP, int PMIGBJGNLLP)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2B6DD80", Offset = "0x2B6C380", VA = "0x182B6DD80")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KHEECCAALDH(this DILBINPLABC JNMMMBJNOND, int? KGLAMBDGAEL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E210", Offset = "0x2B6C810", VA = "0x182B6E210")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> LIOLIDJMBIF(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>? EJMGENIHEHO, int? KGLAMBDGAEL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D820", Offset = "0x2B6BE20", VA = "0x182B6D820")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> IMECDENMJDG(this DILBINPLABC JNMMMBJNOND, int? KGLAMBDGAEL, int PMIGBJGNLLP)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D960", Offset = "0x2B6BF60", VA = "0x182B6D960")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> JGGPOEAHPAK(this DILBINPLABC JNMMMBJNOND, int? KGLAMBDGAEL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C770", Offset = "0x2B6AD70", VA = "0x182B6C770")]
	public static void BJOGCBAMFJI(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KOCEENMADIJ, AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ> PDCBJNKPMHP, int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D410", Offset = "0x2B6BA10", VA = "0x182B6D410")]
	public static void HFKMJBHOKLH(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KOCEENMADIJ, int PMIGBJGNLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C600", Offset = "0x2B6AC00", VA = "0x182B6C600")]
	public static void ACOLJCOIJKD(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KOCEENMADIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E530", Offset = "0x2B6CB30", VA = "0x182B6E530")]
	public static void MIHBJEAGPAF(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> AMMKGILEHBG, AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> POELHGONDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2B6D6A0", Offset = "0x2B6BCA0", VA = "0x182B6D6A0")]
	public static void IGPGAKGMJDI(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KOCEENMADIJ, AIOJMGEOJFK<FKJOADIJDOP<BANLCGFCCGL>> JHJKNGLCECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3F41750", Offset = "0x3F3FD50", VA = "0x183F41750")]
	public static void BEDGLJANJPF<M>(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KOCEENMADIJ, AIOJMGEOJFK<FKJOADIJDOP<MAFIFIMAKDP<M>>> JHJKNGLCECL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface NBEABGMEFGC<TStateSys>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AIOJMGEOJFK<KPJKCKGFDKH> EKPMIMBLLEK(TStateSys EKCGLLINMJN);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIOJMGEOJFK<KPJKCKGFDKH> CHNCLAMDNHN(TStateSys EKCGLLINMJN);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AIOJMGEOJFK<KPJKCKGFDKH> EGOEODOHMDN(TStateSys EKCGLLINMJN);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AIOJMGEOJFK<KPJKCKGFDKH> HHFMPAJFGHK(TStateSys EKCGLLINMJN);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA> DGINJMABCLD(TStateSys EKCGLLINMJN, DILBINPLABC DJKECHGAGHM, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> DCPKCJHABHJ(TStateSys EKCGLLINMJN, DILBINPLABC DJKECHGAGHM, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<DKKLODGCMAB> LCBAPKAFNJK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int DNFIMMOBNJI(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AIOJMGEOJFK<DKKLODGCMAB> FEIOKKBEPKN(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM, int PNDKBGDMGBK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	CIGPNEIIOND OIMANOBCFKP(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FLCBONEJLLJ(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	int OAKMFHEPOBA(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ADLLGELKECP<byte> KOFEHKFHHCB(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	(ADLLGELKECP<byte>, AIOJMGEOJFK<KPJKCKGFDKH>) GKMAIAANDKH(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OICMPGAJNLN> ACDFJJHANOM);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	int AFNCCBMJIJK(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<DKKLODGCMAB> LCBAPKAFNJK);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AIOJMGEOJFK<OICMPGAJNLN> EBKICFCMCLI(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<DKKLODGCMAB> LCBAPKAFNJK, int KMEJGFPEMOG);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	AIOJMGEOJFK<OICMPGAJNLN> FKEJPIGGALJ(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, AIOJMGEOJFK<OMGMEOLCEJA> PLBMJMHLGMM, int KMEJGFPEMOG);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	int GACCMBPBHMO(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	int? PFLMANCNDJM(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, int PMIGBJGNLLP);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	int BILAIEHLMPK(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	int? MGOBNFAHFJI(TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP, int PMIGBJGNLLP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MFFNOECPFFO
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1590", Offset = "0x3ECFB90", VA = "0x183ED1590")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO?> BKCOLMLHGDI<T, TOpInput, TOpOutput>(this DILBINPLABC JNMMMBJNOND, T BNPLNGPMIIG, T DIIGMDFDOAL, int JCCJJKCPAFB, IntPtr CIFBALODDNE)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2F80", Offset = "0x3ED1580", VA = "0x183ED2F80")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO?> HCHJONGGEHA<T, TOpInput, TOpOutput>(this DILBINPLABC JNMMMBJNOND, T BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL, int JCCJJKCPAFB, IntPtr CIFBALODDNE)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1D50", Offset = "0x3ED0350", VA = "0x183ED1D50")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO?> DFHIKAIFHEJ<TOpInput, TOpOutput>(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL, int JCCJJKCPAFB, IntPtr CIFBALODDNE)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2B69930", Offset = "0x2B67F30", VA = "0x182B69930")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> GJMOGLNDHGP(this DILBINPLABC JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A010", Offset = "0x2B68610", VA = "0x182B6A010")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> IAINONFJCNO(this DILBINPLABC JNMMMBJNOND, float KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2B686E0", Offset = "0x2B66CE0", VA = "0x182B686E0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> ECEEKFAPIAA(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2B67A80", Offset = "0x2B66080", VA = "0x182B67A80")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> CINDGPDIJBC(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AA90", Offset = "0x2B69090", VA = "0x182B6AA90")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> JOOLFPGIOAO(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2B697F0", Offset = "0x2B67DF0", VA = "0x182B697F0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> GIPPDDCKOLO(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C000", Offset = "0x2B6A600", VA = "0x182B6C000")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> OCBCCLOJNAA(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2B68340", Offset = "0x2B66940", VA = "0x182B68340")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIDKPANMKKP(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x2B67260", Offset = "0x2B65860", VA = "0x182B67260")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BCBFEAEKALE(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2B68A80", Offset = "0x2B67080", VA = "0x182B68A80")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> EOKFDIGPPIF(this DILBINPLABC JNMMMBJNOND, int BNPLNGPMIIG, int DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A130", Offset = "0x2B68730", VA = "0x182B6A130")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> IBCBJJLKGIK(this DILBINPLABC JNMMMBJNOND, int BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AD90", Offset = "0x2B69390", VA = "0x182B6AD90")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KIPHCABBLHG(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C360", Offset = "0x2B6A960", VA = "0x182B6C360")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> PIIFPFLBMAA(this DILBINPLABC JNMMMBJNOND, float BNPLNGPMIIG, float DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B680", Offset = "0x2B69C80", VA = "0x182B6B680")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> MKDMBKNIJPI(this DILBINPLABC JNMMMBJNOND, float BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2B6ABB0", Offset = "0x2B691B0", VA = "0x182B6ABB0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDOGMLKOCPA(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A430", Offset = "0x2B68A30", VA = "0x182B6A430")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> IHFHEIHFIML(this DILBINPLABC JNMMMBJNOND, int BNPLNGPMIIG, int DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2B69C70", Offset = "0x2B68270", VA = "0x182B69C70")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> GPGHBNNMBEO(this DILBINPLABC JNMMMBJNOND, int BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A910", Offset = "0x2B68F10", VA = "0x182B6A910")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> JGHNCAEJOON(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2B68E80", Offset = "0x2B67480", VA = "0x182B68E80")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> FKADBJKDFAD(this DILBINPLABC JNMMMBJNOND, float BNPLNGPMIIG, float DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2B68E00", Offset = "0x2B67400", VA = "0x182B68E00")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> FJLOBMJPKHA(this DILBINPLABC JNMMMBJNOND, float BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x2B69CF0", Offset = "0x2B682F0", VA = "0x182B69CF0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HCOJPIIGFEE(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A890", Offset = "0x2B68E90", VA = "0x182B6A890")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> JEEJBAHAMME(this DILBINPLABC JNMMMBJNOND, int BNPLNGPMIIG, int DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AD10", Offset = "0x2B69310", VA = "0x182B6AD10")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KIMNNANAFHK(this DILBINPLABC JNMMMBJNOND, int BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A6D0", Offset = "0x2B68CD0", VA = "0x182B6A6D0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> JCCFNCEJDMH(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B600", Offset = "0x2B69C00", VA = "0x182B6B600")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> MGKIOOEPIPE(this DILBINPLABC JNMMMBJNOND, float BNPLNGPMIIG, float DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x2B68D80", Offset = "0x2B67380", VA = "0x182B68D80")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> FIEIIFIOHNM(this DILBINPLABC JNMMMBJNOND, float BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C2E0", Offset = "0x2B6A8E0", VA = "0x182B6C2E0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> PBCMCDIGGIP(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A250", Offset = "0x2B68850", VA = "0x182B6A250")]
	public static AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> IDNLHHFMHIG(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B69E70", Offset = "0x2B68470", VA = "0x182B69E70")]
	public static AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> HDNIGHCBGHH(this DILBINPLABC JNMMMBJNOND, int KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B460", Offset = "0x2B69A60", VA = "0x182B6B460")]
	public static AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> MEFODIDDLOK(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C100", Offset = "0x2B6A700", VA = "0x182B6C100")]
	public static AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> OIJLPPIJGNF(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> EEHJLNLBEFO)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2B682C0", Offset = "0x2B668C0", VA = "0x182B682C0")]
	public static AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> DDMPALCCLOI(this DILBINPLABC JNMMMBJNOND, int KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B010", Offset = "0x2B69610", VA = "0x182B6B010")]
	public static AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> KNBIANFNKLH(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x2B67CA0", Offset = "0x2B662A0", VA = "0x182B67CA0")]
	public static (AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>) COEHHDDJGFK(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<AIKJPLOFBEB> APFACCKEIAD, [In] ReadOnlySpan<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> MGPPHEGFGJP, [In] ReadOnlySpan<int?> KBBNGKMFKBO, [In] Span<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> FLGGMBJGMPG)
	{
		return default((AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2B69280", Offset = "0x2B67880", VA = "0x182B69280")]
	public static (AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>) GFMDMAECHPC(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<KGHGPEMKPNJ> DADHIFDHFKH, [In] ReadOnlySpan<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> MGPPHEGFGJP, [In] ReadOnlySpan<int?> KBBNGKMFKBO, [In] Span<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> FLGGMBJGMPG)
	{
		return default((AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3ED35D0", Offset = "0x3ED1BD0", VA = "0x183ED35D0")]
	public static (AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<KPJKCKGFDKH>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<TMarker>>, AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>) LMKPJDPJNDJ<TMarker>(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<KPJKCKGFDKH> CEGDALCEEJE, [In] ReadOnlySpan<byte> CDDIADBJAOB)
	{
		return default((AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<FKJOADIJDOP<KPJKCKGFDKH>>, AIOJMGEOJFK<FKJOADIJDOP<AIGEEEJNNHA>>, AIOJMGEOJFK<FKJOADIJDOP<TMarker>>, AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2B68200", Offset = "0x2B66800", VA = "0x182B68200")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DCFOPIDNLPL(this DILBINPLABC JNMMMBJNOND, int AJBFKHLMPBC, [Optional] AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>? BNIHMOKPGDO)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2B68110", Offset = "0x2B66710", VA = "0x182B68110")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DBDKEMHJBAI(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> AJBFKHLMPBC, [Optional] AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>? BNIHMOKPGDO)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2B68C90", Offset = "0x2B67290", VA = "0x182B68C90")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> FDKHEKPOEOF(this DILBINPLABC JNMMMBJNOND, [In] ReadOnlySpan<byte> AJBFKHLMPBC, [Optional] AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>? BNIHMOKPGDO)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2B69EF0", Offset = "0x2B684F0", VA = "0x182B69EF0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HJJOAOHPAFE(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> AJBFKHLMPBC, int KCJLCGFEBMJ, [Optional] AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>? BNIHMOKPGDO)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A5D0", Offset = "0x2B68BD0", VA = "0x182B6A5D0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> IINNLHHDGBC(this DILBINPLABC JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x2B67B80", Offset = "0x2B66180", VA = "0x182B67B80")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> CLFBMLDKHKF(this DILBINPLABC JNMMMBJNOND, float KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x2B67940", Offset = "0x2B65F40", VA = "0x182B67940")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> CAKIGDMHJBN(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x2B696F0", Offset = "0x2B67CF0", VA = "0x182B696F0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> GHBEDOMOHHP(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B7B0", Offset = "0x2B69DB0", VA = "0x182B6B7B0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> MMAEBOAFKDK(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2B68940", Offset = "0x2B66F40", VA = "0x182B68940")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> EFPBPPOIBNO(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2B69200", Offset = "0x2B67800", VA = "0x182B69200")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> GFIEGGIBIJD(this DILBINPLABC JNMMMBJNOND, int BNPLNGPMIIG, int DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x2B68560", Offset = "0x2B66B60", VA = "0x182B68560")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DJLNKHGJDOD(this DILBINPLABC JNMMMBJNOND, int BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x2B671E0", Offset = "0x2B657E0", VA = "0x182B671E0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> ABALBMOFNMG(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BNPLNGPMIIG, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DIIGMDFDOAL)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A990", Offset = "0x2B68F90", VA = "0x182B6A990")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> JIODOLDHHNP(this DILBINPLABC JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B330", Offset = "0x2B69930", VA = "0x182B6B330")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> MEEAMGFAEHP(this DILBINPLABC JNMMMBJNOND, float KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2B6C460", Offset = "0x2B6AA60", VA = "0x182B6C460")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> POBEOGPMJAB(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B500", Offset = "0x2B69B00", VA = "0x182B6B500")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> MELNDAMPICJ(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A4B0", Offset = "0x2B68AB0", VA = "0x182B6A4B0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> IHGPOKIDALJ(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2B673A0", Offset = "0x2B659A0", VA = "0x182B673A0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BDHINMGPIDO(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2B6ACF0", Offset = "0x2B692F0", VA = "0x182B6ACF0")]
	public static AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>> KECOPAGBBAA(this DILBINPLABC JNMMMBJNOND)
	{
		return default(AIOJMGEOJFK<FKJOADIJDOP<FKJOADIJDOP<EMNGKOKIKPO>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2B685E0", Offset = "0x2B66BE0", VA = "0x182B685E0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DLFDPHDJOBE(this DILBINPLABC JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2B69B50", Offset = "0x2B68150", VA = "0x182B69B50")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> GOJFBGJHIFP(this DILBINPLABC JNMMMBJNOND, float KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B0B0", Offset = "0x2B696B0", VA = "0x182B6B0B0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> LDNDHOHGDEA(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2B69D70", Offset = "0x2B68370", VA = "0x182B69D70")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HDDCMKAEDDH(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2B69A30", Offset = "0x2B68030", VA = "0x182B69A30")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> GLLCDABLGHK(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BB00", Offset = "0x2B6A100", VA = "0x182B6BB00")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NLOAGCMGKCL(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2B675E0", Offset = "0x2B65BE0", VA = "0x182B675E0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BEKJKJICGHI(this DILBINPLABC JNMMMBJNOND, int KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x2B68B80", Offset = "0x2B67180", VA = "0x182B68B80")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> FBGNPJFOJHN(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KOPHBHGIACG)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BAF0", Offset = "0x2B6A0F0", VA = "0x182B6BAF0")]
	public static void NINBCCIGPPC(this DILBINPLABC JNMMMBJNOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x2B68460", Offset = "0x2B66A60", VA = "0x182B68460")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> DJKEPNNCMFF(this DILBINPLABC JNMMMBJNOND, float KDEJNGMKJHJ, float HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x2B68820", Offset = "0x2B66E20", VA = "0x182B68820")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> ECGKIAANPKM(this DILBINPLABC JNMMMBJNOND, float KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x2B67800", Offset = "0x2B65E00", VA = "0x182B67800")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BPJDAMKJLCP(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x2B674E0", Offset = "0x2B65AE0", VA = "0x182B674E0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BEDBMONACNB(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B9D0", Offset = "0x2B69FD0", VA = "0x182B6B9D0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NHNDACPIDBL(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x2B6AED0", Offset = "0x2B694D0", VA = "0x182B6AED0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KJBAENCNFEG(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x2B6BC40", Offset = "0x2B6A240", VA = "0x182B6BC40")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NMBALFNFDFP(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> HKKLINMAOIB, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> GHBCNPNCPLH)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B8D0", Offset = "0x2B69ED0", VA = "0x182B6B8D0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NENCBFJANCC(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, int HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x2B676E0", Offset = "0x2B65CE0", VA = "0x182B676E0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> BEMJDIBPBJO(this DILBINPLABC JNMMMBJNOND, int KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x2B6A750", Offset = "0x2B68D50", VA = "0x182B6A750")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> JCCJEJLJOFA(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> KDEJNGMKJHJ, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> HLNDACBMLAC)
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1840", Offset = "0x3ECFE40", VA = "0x183ED1840")]
	public static void CCKPNDBJLMN<TDeps, TState>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TState HFPFCKAPBFI, AIOJMGEOJFK<AIKJPLOFBEB> APFACCKEIAD, [In] ReadOnlySpan<AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>> IGDPBPONGKM, [In] ReadOnlySpan<int?> KBBNGKMFKBO, [In] Span<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> FLGGMBJGMPG, [In] Span<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> JGNFMHDMIBE, [In] ReadOnlySpan<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>?> EIOHBGGJJGB) where TDeps : notnull, NBEABGMEFGC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3ED1E70", Offset = "0x3ED0470", VA = "0x183ED1E70")]
	public static void DOAIFKKPFMN<TDeps, TState>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TState HFPFCKAPBFI, AIOJMGEOJFK<KGHGPEMKPNJ> OFMFDPOLEGO, [In] ReadOnlySpan<AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>> IOKFIGKKPCG, [In] ReadOnlySpan<int?> KBBNGKMFKBO, [In] Span<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> FLGGMBJGMPG, [In] Span<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>> JGNFMHDMIBE, [In] ReadOnlySpan<AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>?> EIOHBGGJJGB) where TDeps : notnull, NBEABGMEFGC<TState> where TState : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x3ED36C0", Offset = "0x3ED1CC0", VA = "0x183ED36C0")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NGCKMIAIHMO<TDeps, TState>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TState HFPFCKAPBFI, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> EJMGENIHEHO, [Optional] AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>? BNIHMOKPGDO) where TDeps : notnull, NBEABGMEFGC<TState> where TState : notnull
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2B50", Offset = "0x3ED1150", VA = "0x183ED2B50")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> GLBPOFIEDCC<TDeps, TState>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TState HFPFCKAPBFI, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> BHDOFCPPKAM, [Optional] AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>? BNIHMOKPGDO) where TDeps : notnull, NBEABGMEFGC<TState> where TState : notnull
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3ED3260", Offset = "0x3ED1860", VA = "0x183ED3260")]
	public static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> HPMCLHABMMF<TDeps, TStateSys>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TStateSys EKCGLLINMJN) where TDeps : notnull, NBEABGMEFGC<TStateSys> where TStateSys : notnull
	{
		return default(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2800", Offset = "0x3ED0E00", VA = "0x183ED2800")]
	public static AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA> FAABKIHPLMO<TDeps, TStateSys>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TStateSys EKCGLLINMJN) where TDeps : notnull, NBEABGMEFGC<TStateSys> where TStateSys : notnull
	{
		return default(AIOJMGEOJFK<OOFDDBHCLAP.OMHJNOJBENA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x2B6B1F0", Offset = "0x2B697F0", VA = "0x182B6B1F0")]
	public static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> LFBMLOCPDKK(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> CDGGLMIIDFF, IntPtr OFDDOFEAJCG, IntPtr MBOKJAJICHJ)
	{
		return default(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x2B68F00", Offset = "0x2B67500", VA = "0x182B68F00")]
	public static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> GDBLLHLJDEB(this DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> NNPFNGHALFJ, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> NPMNGDEEJDC, IntPtr EAPMBJKEGFE, IntPtr HBHIHHFANNF, IntPtr ONCBBEMMEIJ, bool FFBJJJOJDHK)
	{
		return default(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0EE0", Offset = "0x3ECF4E0", VA = "0x183ED0EE0")]
	public static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> AMDCEBFNDKG<TDeps, TState>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TState HFPFCKAPBFI, AIOJMGEOJFK<AIKJPLOFBEB> KJJBAJIJNNF, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> NNPFNGHALFJ, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> NPMNGDEEJDC, int? IBLFGMDLPOA, [Optional] IntPtr FIMKJHBAKNN) where TDeps : notnull, NBEABGMEFGC<TState> where TState : notnull
	{
		return default(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0BD0", Offset = "0x3ECF1D0", VA = "0x183ED0BD0")]
	private static AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> AMDCEBFNDKG<TDeps, TState>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TState HFPFCKAPBFI, AIOJMGEOJFK<AIKJPLOFBEB> KJJBAJIJNNF, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> NNPFNGHALFJ, AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL> NPMNGDEEJDC, int? IBLFGMDLPOA) where TDeps : notnull, NBEABGMEFGC<TState> where TState : notnull
	{
		return default(AIOJMGEOJFK<OAOOGAIHAMO.JCHEMFDMHGL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2380", Offset = "0x3ED0980", VA = "0x183ED2380")]
	public static AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> ECIHAIOJOHP<TDeps, TState>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TState HFPFCKAPBFI, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> AJBFKHLMPBC, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>? BNIHMOKPGDO) where TDeps : notnull, NBEABGMEFGC<TState> where TState : notnull
	{
		return default(AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3ED0810", Offset = "0x3ECEE10", VA = "0x183ED0810")]
	public static void AJCDCOCHBEJ<TDeps, TState>(this DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TState HFPFCKAPBFI, int CIHGGPLBDAP) where TDeps : notnull, NBEABGMEFGC<TState> where TState : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct INIGANBJEHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> IIEGKOFOAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> HGPCDEKFCJF;

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xECAC90", Offset = "0xEC9290", VA = "0x180ECAC90")]
	public INIGANBJEHJ(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> HCKAAAENCCO, AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> BAPMLEKEFBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x2B66840", Offset = "0x2B64E40", VA = "0x182B66840")]
	public static INIGANBJEHJ CPNHECDILPK(AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>> HCKAAAENCCO)
	{
		return default(INIGANBJEHJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct GKIOMMDHDFN
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class GNAAINOPABK : EPENECFNPLA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public struct FEMBNPOIKIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ> MNPPHEONMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int GKFLGCDAIDH;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xECAC90", Offset = "0xEC9290", VA = "0x180ECAC90")]
		public FEMBNPOIKIH(AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ> PDCBJNKPMHP, int PMIGBJGNLLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class PADFOGAAEIO : EPENECFNPLA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct BGAFGAPEBJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int GKFLGCDAIDH;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
		public BGAFGAPEBJC(int PMIGBJGNLLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class PLBMPCKAJMB : EPENECFNPLA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public struct LDONHKCPINM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ> MNPPHEONMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int GKFLGCDAIDH;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xECAC90", Offset = "0xEC9290", VA = "0x180ECAC90")]
		public LDONHKCPINM(AIOJMGEOJFK<NNBPLNPNGBP.MCPKEADPILJ> PDCBJNKPMHP, int PMIGBJGNLLP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public enum HCFPDBGOKHD
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
	public sealed class BLCJLPLAIPO
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public abstract class EPENECFNPLA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct APGDBAMLNLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int? KANCIIMCALK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public INIGANBJEHJ PIPKDFOONGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public HCFPDBGOKHD KCAOLIJOLKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AIOJMGEOJFK<EPENECFNPLA> FNNCAHBEJGF;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2B64D60", Offset = "0x2B63360", VA = "0x182B64D60")]
		public APGDBAMLNLD(int? KGLAMBDGAEL, [In] INIGANBJEHJ IIHOHJMDFDB, HCFPDBGOKHD NDLIDFKNCIJ, AIOJMGEOJFK<EPENECFNPLA> FBNOFEEHOMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public sealed class JKHGOMPKAMJ : EPENECFNPLA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct LJOFAKJAKFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public int GKFLGCDAIDH;

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x15C7B70", Offset = "0x15C6170", VA = "0x1815C7B70")]
		public LJOFAKJAKFF(int PMIGBJGNLLP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	internal NMFPCMCHOLK<BLCJLPLAIPO, APGDBAMLNLD> IPCDKIIKHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	internal NMFPCMCHOLK<GNAAINOPABK, FEMBNPOIKIH> ANDDKELPLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	internal NMFPCMCHOLK<PLBMPCKAJMB, LDONHKCPINM> AEOLODMMBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal NMFPCMCHOLK<JKHGOMPKAMJ, LJOFAKJAKFF> PEMNDEHIGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	internal NMFPCMCHOLK<PADFOGAAEIO, BGAFGAPEBJC> JPHDGEOGEEF;

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x2B66370", Offset = "0x2B64970", VA = "0x182B66370")]
	private GKIOMMDHDFN([In] NMFPCMCHOLK<BLCJLPLAIPO, APGDBAMLNLD> OEOGOKGCNDD, [In] NMFPCMCHOLK<GNAAINOPABK, FEMBNPOIKIH> AEMLBAPJLPL, [In] NMFPCMCHOLK<PLBMPCKAJMB, LDONHKCPINM> AIBKMCGNDHI, [In] NMFPCMCHOLK<JKHGOMPKAMJ, LJOFAKJAKFF> MGDLPKKGGOM, [In] NMFPCMCHOLK<PADFOGAAEIO, BGAFGAPEBJC> BEBADBGEAII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x2B66180", Offset = "0x2B64780", VA = "0x182B66180")]
	public static GKIOMMDHDFN CPNHECDILPK()
	{
		return default(GKIOMMDHDFN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class EAPJCKLIPMN
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2B65EB0", Offset = "0x2B644B0", VA = "0x182B65EB0")]
	public static void GELLEPHLJAH(this GKIOMMDHDFN JNMMMBJNOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class OLNPMAJNEMO
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F2F0", Offset = "0x2B6D8F0", VA = "0x182B6F2F0")]
	public static void CKKIIFJHCHE(DILBINPLABC JNMMMBJNOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public struct BDEDMJDDNPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	internal AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, BLOENPAKOMK> HCOPIPDJPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	internal int MLFBHBGNMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	internal int CLBCLFKHCMM;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x2B64FC0", Offset = "0x2B635C0", VA = "0x182B64FC0")]
	private BDEDMJDDNPH([In] AGMAKDOIOBI<NNBPLNPNGBP.ICIDECKPALE, BLOENPAKOMK> DHDPPMBABMH, int DGKOCMHNBFA, int NIEGLFAEHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2B64D80", Offset = "0x2B63380", VA = "0x182B64D80")]
	public static BDEDMJDDNPH CPNHECDILPK()
	{
		return default(BDEDMJDDNPH);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x2B64DF0", Offset = "0x2B633F0", VA = "0x182B64DF0")]
	public void GELLEPHLJAH([In] DILBINPLABC BJEFEGNHMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B5A0C0", Offset = "0x3B586C0", VA = "0x183B5A0C0")]
	public static void CKKIIFJHCHE<TDeps, TStateSys>(DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TStateSys EKCGLLINMJN, AIOJMGEOJFK<NEJNMGMJLDN> HCMLLANKMHP) where TDeps : notnull, NBEABGMEFGC<TStateSys> where TStateSys : notnull
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class NCDHCDDNMOH
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2B6EB80", Offset = "0x2B6D180", VA = "0x182B6EB80")]
	public static void CKKIIFJHCHE(DILBINPLABC JNMMMBJNOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public struct FDNPJFKAONP
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private interface KIFGHHHBANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JCICBAPILHM(NHNLFJGMEDN<byte> FECEADMKGKM, int GDHIMNHMGPK);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private readonly struct DONMDCILEAJ : KIFGHHHBANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2B65E30", Offset = "0x2B64430", VA = "0x182B65E30", Slot = "4")]
		public void JCICBAPILHM(NHNLFJGMEDN<byte> FECEADMKGKM, int GDHIMNHMGPK)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private readonly struct JPHFIBIKDEO : KIFGHHHBANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2B66AB0", Offset = "0x2B650B0", VA = "0x182B66AB0", Slot = "4")]
		public void JCICBAPILHM(NHNLFJGMEDN<byte> FECEADMKGKM, int GDHIMNHMGPK)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private readonly struct FHHKONEAMON : KIFGHHHBANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2B66100", Offset = "0x2B64700", VA = "0x182B66100", Slot = "4")]
		public void JCICBAPILHM(NHNLFJGMEDN<byte> FECEADMKGKM, int GDHIMNHMGPK)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private readonly struct ANFCMFBFCCC : KIFGHHHBANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2B64CC0", Offset = "0x2B632C0", VA = "0x182B64CC0", Slot = "4")]
		public void JCICBAPILHM(NHNLFJGMEDN<byte> FECEADMKGKM, int GDHIMNHMGPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private static class NJAJDNHIPOB<TCallProcessorDeps> where TCallProcessorDeps : struct, KIFGHHHBANA
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly TCallProcessorDeps EHPINPNKKID;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4541660", Offset = "0x453FC60", VA = "0x184541660")]
		public static int CKKIIFJHCHE<TDeps, TStateSys>(TDeps NBGHBGMICNM, TStateSys HFPFCKAPBFI, DILBINPLABC BJEFEGNHMAK, [In] NHNLFJGMEDN<byte> CBJOCOBKFIE, int LGDFEKPBPCJ) where TDeps : NBEABGMEFGC<TStateSys>
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NHNLFJGMEDN<NIGEFILAFME> NNFNCNOEFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private Dictionary<AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>> CBNKKPLOHOH;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x2B660C0", Offset = "0x2B646C0", VA = "0x182B660C0")]
	private FDNPJFKAONP([In] NHNLFJGMEDN<NIGEFILAFME> ONNHBLDKDKK, Dictionary<AIOJMGEOJFK<FKJOADIJDOP<EMNGKOKIKPO>>, AIOJMGEOJFK<NNBPLNPNGBP.ICIDECKPALE>> COOOCOHBGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2B65FC0", Offset = "0x2B645C0", VA = "0x182B65FC0")]
	public static FDNPJFKAONP CPNHECDILPK()
	{
		return default(FDNPJFKAONP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2B66080", Offset = "0x2B64680", VA = "0x182B66080")]
	public void GELLEPHLJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3DB90E0", Offset = "0x3DB76E0", VA = "0x183DB90E0")]
	public static void CKKIIFJHCHE<TDeps, TStateSys>(DILBINPLABC JNMMMBJNOND, TDeps NBGHBGMICNM, TStateSys EKCGLLINMJN) where TDeps : NBEABGMEFGC<TStateSys>
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class PGEJKADOJGK
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct BCLNHAMMNHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> FPIKLINPBJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public int MAAOLGHFHJD;
	}

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static int PNEBDBMPHJL;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static int OIIDHGIIAHJ;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2B6F8A0", Offset = "0x2B6DEA0", VA = "0x182B6F8A0")]
	public static void CKKIIFJHCHE(DILBINPLABC JNMMMBJNOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2B6FE10", Offset = "0x2B6E410", VA = "0x182B6FE10")]
	private static void HCGMDNFAHKA([In] DILBINPLABC JNMMMBJNOND, AIOJMGEOJFK<GKIOMMDHDFN.BLCJLPLAIPO> NMILEMOAODL, NHNLFJGMEDN<byte> JFFCMCFPKDH, List<BCLNHAMMNHD> KFKFLPEPKEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2B70040", Offset = "0x2B6E640", VA = "0x182B70040")]
	private static void HCGMDNFAHKA(NHNLFJGMEDN<byte> JFFCMCFPKDH, int KCJLCGFEBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2B70180", Offset = "0x2B6E780", VA = "0x182B70180")]
	private static void IELKLLIPGGH(DILBINPLABC JNMMMBJNOND, List<BCLNHAMMNHD> KFKFLPEPKEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class EDBLEIDIJAG<TDeps, TIndex, TValues> where TDeps : struct, NMIIPFIHAMN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static readonly TDeps EHPINPNKKID;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4B02FF0", Offset = "0x4B015F0", VA = "0x184B02FF0")]
	public static void CKKIIFJHCHE([In] NHNLFJGMEDN<NIGEFILAFME> ONNHBLDKDKK, int NDODHNELJFD, TValues LGMBOCEBOMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface NMIIPFIHAMN<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NHNLFJGMEDN<TIndex> LLDBCAIABBF(int NDODHNELJFD, [In] TValues LGMBOCEBOMM);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(TIndex PMIGBJGNLLP, [In] TValues LGMBOCEBOMM);

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EHBMPGNGFDM(TIndex PMIGBJGNLLP, TValues LGMBOCEBOMM, AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KOPHBHGIACG);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface KLBBPIFNEFO<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TIndex KMGPOBDOJKI(int PMIGBJGNLLP);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ODJFHHBJOBH(TIndex PMIGBJGNLLP, [In] TValues LGMBOCEBOMM);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AIOJMGEOJFK<FKJOADIJDOP<HIGOLCKHIEO>> KNCDHMHOEMP(TIndex PMIGBJGNLLP, [In] TValues LGMBOCEBOMM);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class LNIPMCNGMAD<TDeps, TIndex, TValues> where TDeps : struct, KLBBPIFNEFO<TIndex, TValues>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static readonly TDeps EHPINPNKKID;

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x57E17D0", Offset = "0x57DFDD0", VA = "0x1857E17D0")]
	public static NHNLFJGMEDN<TIndex> CKKIIFJHCHE(int NDODHNELJFD, [In] TValues LGMBOCEBOMM)
	{
		return default(NHNLFJGMEDN<TIndex>);
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
