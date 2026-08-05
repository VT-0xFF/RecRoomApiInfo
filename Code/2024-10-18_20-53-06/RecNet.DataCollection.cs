using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x648E610", Offset = "0x648DA10", VA = "0x18648E610")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x648E520", Offset = "0x648D920", VA = "0x18648E520", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecNet_DataCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x648F270", Offset = "0x648E670", VA = "0x18648F270", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PBAAKHKGCHK
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> DKAAJMLHDFG();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class DMHOGINMCGG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface NPIKNPNGOFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ODPECCCDLCM JAILHLJMEGG(Guid EKBPHLNJBLE, string JGFCOKPAFFB, [Optional] string EFAMPHDCDAB, [Optional] long? MKKHNNOINLF, [Optional] string DIMPEGEDIAJ, [Optional] string JGEHOGGFEPF);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class JHAGFJLKIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x648D430", Offset = "0x648C830", VA = "0x18648D430")]
		public static ODPECCCDLCM DPHEHHHNBPI(Guid EKBPHLNJBLE, string JGFCOKPAFFB, string EFAMPHDCDAB, [Optional] long? MKKHNNOINLF, [Optional] string DIMPEGEDIAJ, [Optional] string JGEHOGGFEPF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ODPECCCDLCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected INGJDNIDAGM COLIBJAKAHH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B47B0", Offset = "0x8B3BB0", VA = "0x1808B47B0")]
		public ODPECCCDLCM(INGJDNIDAGM COLIBJAKAHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x648E690", Offset = "0x648DA90", VA = "0x18648E690")]
		public ODPECCCDLCM AALFBHBPIKE(string ECJEGOAKEPN, string EEPLCHCGAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x353FA20", Offset = "0x353EE20", VA = "0x18353FA20")]
		public ODPECCCDLCM AALFBHBPIKE<T>(string ECJEGOAKEPN, T EEPLCHCGAIN) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x353FDB0", Offset = "0x353F1B0", VA = "0x18353FDB0")]
		public ODPECCCDLCM AKMKGMPKEEE<T>(string ECJEGOAKEPN, T? EEPLCHCGAIN) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x648E710", Offset = "0x648DB10", VA = "0x18648E710")]
		public ODPECCCDLCM AKMKGMPKEEE(string ECJEGOAKEPN, string EEPLCHCGAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x648E7A0", Offset = "0x648DBA0", VA = "0x18648E7A0")]
		public GELPMBCHBBO ELBHCMHCOGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2210760", Offset = "0x220FB60", VA = "0x182210760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class INGJDNIDAGM
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<INGJDNIDAGM> GHAPOMLMOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string IMOHKABEMNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> DIGOHHPBNFC;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x648A970", Offset = "0x6489D70", VA = "0x18648A970")]
		private INGJDNIDAGM(string IMOHKABEMNJ, int OEOJIBEMNAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6489710", Offset = "0x6488B10", VA = "0x186489710")]
		public static ODPECCCDLCM JMOKCOIDHBC(string IMOHKABEMNJ, int OEOJIBEMNAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x648A660", Offset = "0x6489A60", VA = "0x18648A660")]
		public GELPMBCHBBO ELBHCMHCOGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x648A900", Offset = "0x6489D00", VA = "0x18648A900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2E4A230", Offset = "0x2E49630", VA = "0x182E4A230")]
		internal void PDKGGGBEBJK<T>(string ECJEGOAKEPN, T EEPLCHCGAIN) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x648A8A0", Offset = "0x6489CA0", VA = "0x18648A8A0")]
		internal void PDKGGGBEBJK(string ECJEGOAKEPN, string EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x353D0D0", Offset = "0x353C4D0", VA = "0x18353D0D0")]
		private void CJJAAFFKMHD<T>(string ECJEGOAKEPN, T EEPLCHCGAIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct JACFFLNPPKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string IJHHFKBMGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? LMAPJLOLJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? OADANAFNNPG;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x648BF00", Offset = "0x648B300", VA = "0x18648BF00")]
		public JACFFLNPPKL(string ILFFOGDMFHA, [Optional] long? FJBFONPAOAD, [Optional] short? HGBABIIFDPO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct IAAHNBNAFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int LGMIIGEMFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string HGGMKCKNPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short OKDJOANECIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string GPMJOFIKEEJ;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6489F10", Offset = "0x6489310", VA = "0x186489F10")]
		public IAAHNBNAFJH(int PPOKIGIDFJE, string NNFNKDKJOIA, short PDKBHCFPPEA, string BLMOGCODMAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class JFGMFLHLHBL : CIBMIMGPIGM<EGDJLOMDJDP, IAAHNBNAFJH, JACFFLNPPKL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string NNFNKDKJOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short PDKBHCFPPEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string BLMOGCODMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> GEBKOFDCAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int OOLFKFCKPDE;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x648D3B0", Offset = "0x648C7B0", VA = "0x18648D3B0")]
		public JFGMFLHLHBL(string CBLLLCEODBN, Guid CIAMAKMFKFA, long HLIJNPAAKME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x648CD30", Offset = "0x648C130", VA = "0x18648CD30", Slot = "4")]
		public override void FKFGNELBIGH(IAAHNBNAFJH JBKFADCHMKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x648D2D0", Offset = "0x648C6D0", VA = "0x18648D2D0")]
		public void OMLCFPCJFLM(short PDKBHCFPPEA, bool OLHNONNPMPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3F24980", Offset = "0x3F23D80", VA = "0x183F24980")]
		public void FKIFPJCONHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB60", Offset = "0x8ABF60", VA = "0x1808ACB60")]
		public void IOFKIDFLIOP(string GGAMBLOEKPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x648BF40", Offset = "0x648B340", VA = "0x18648BF40", Slot = "5")]
		public override void CKEMDGOEOAG(bool BBCKBBJHADH, JACFFLNPPKL MHCHAFEDOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x648D020", Offset = "0x648C420", VA = "0x18648D020", Slot = "6")]
		public override PDLIDEPELNN IMIHPPEDABC(EGDJLOMDJDP OBCNDPEHEPN, int HAJICDLBEKC, string MHDOPFNMJEE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class KBODACIIOGC : PDLIDEPELNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string NNFNKDKJOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short PDKBHCFPPEA;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x648D7F0", Offset = "0x648CBF0", VA = "0x18648D7F0")]
		public KBODACIIOGC(long NNAHLJLIKCH, int PPOKIGIDFJE, string EFAMPHDCDAB, long HLIJNPAAKME, int DJMOFGNFDNA, string DIMPEGEDIAJ, short PDKBHCFPPEA, string NNFNKDKJOIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x648D640", Offset = "0x648CA40", VA = "0x18648D640")]
		public void CHCGCBJLJHI(int PPOKIGIDFJE, string NNFNKDKJOIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x648D6C0", Offset = "0x648CAC0", VA = "0x18648D6C0", Slot = "5")]
		public override ODPECCCDLCM JAILHLJMEGG(Guid EKBPHLNJBLE, string JGFCOKPAFFB, [Optional] string EFAMPHDCDAB, [Optional] long? MKKHNNOINLF, [Optional] string DIMPEGEDIAJ, [Optional] string JGEHOGGFEPF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class AEJBGOGMCAC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6485AA0", Offset = "0x6484EA0", VA = "0x186485AA0")]
		public static void FOMCANAJPIL(string OEOMDKHBDFI, object PLGEFEIIOKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class LPPPFCDNKJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public readonly struct GHLGFIKMDKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int CMPFOHKMOMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int OOEPACDPKPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int MLPOFKKFGCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int CCNNKICPMMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int ADONILFLAFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int FMBFNKAPDLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int KOCAJJMBDOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int PJLPKKDEAHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int PGKOFLJIGLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int JKMPDJLGFBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int PPCCCHOMCNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int HEJMKAEFKON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int LGFHDDKKPAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int BBLLBHALCEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int PHCNLPKHPCI;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6489E00", Offset = "0x6489200", VA = "0x186489E00")]
			public GHLGFIKMDKG(int NODNKDLDHGM, int NFFOJJNJPBE, int GMGMAGLPICH, int DOPICOEHOMD, int LIPMNFADIIL, int JMJOGNGLLGL, int AKPHOLAPKFJ, int KALADFEEADC, int OIEBJJDMLMH, int MOJKNEFFKNJ, int AGODOMCKFFJ, int GAMAKDPNLAG, int DPBKFMEPBHP, int EIKCNIEKABL, int MFDIFADIBDF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? DPLLFJHJMFD;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> NMFEBCAIPDA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x648DC80", Offset = "0x648D080", VA = "0x18648DC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x648DD30", Offset = "0x648D130", VA = "0x18648DD30")]
		public static void NOMMDPKMGJB(GHLGFIKMDKG DBDCFIJEJDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class DICHHDNGKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6489560", Offset = "0x6488960", VA = "0x186489560")]
		public static void FOMCANAJPIL(string OEOMDKHBDFI, object PLGEFEIIOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6489450", Offset = "0x6488850", VA = "0x186489450")]
		public static void FOMCANAJPIL(string OEOMDKHBDFI, float EEPLCHCGAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6489220", Offset = "0x6488620", VA = "0x186489220")]
		public static void FOMCANAJPIL(string OEOMDKHBDFI, MOLGPDBBANN PLGEFEIIOKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class DMIGFMMEKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6489BD0", Offset = "0x6488FD0", VA = "0x186489BD0")]
		public static void MNAEAPOICDO(float3 CLHMEGFDOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6489CE0", Offset = "0x64890E0", VA = "0x186489CE0")]
		public static void OBPILMDIHPM(bool PDMCOKBBKLJ, bool GFIPKGGPELF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6489B30", Offset = "0x6488F30", VA = "0x186489B30")]
		public static void ENNLLEFLMIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class OBKPEMAOECF<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class CJFCPNJKJND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public OBKPEMAOECF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public CJFCPNJKJND()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x596D540", Offset = "0x596C940", VA = "0x18596D540")]
			internal object ODODECIMBBG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class CIJHNMPIJIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public OBKPEMAOECF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public CIJHNMPIJIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x596CEC0", Offset = "0x596C2C0", VA = "0x18596CEC0")]
			internal object KNCICMEIHIM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class EOGBHICABBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public OBKPEMAOECF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public EOGBHICABBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3BB5620", Offset = "0x3BB4A20", VA = "0x183BB5620")]
			internal object AFCFFCALGHI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class FAIAMAAFEAN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public OBKPEMAOECF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public FAIAMAAFEAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3F2C770", Offset = "0x3F2BB70", VA = "0x183F2C770")]
			internal object BNCHFGEALHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float KCIJHFFEEHG = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid EKBPHLNJBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string DIMPEGEDIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string DFFABBFBDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string NOHBNHDJOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string JGEHOGGFEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string GIKONIPLIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string HHPNHELMOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string JEAAMJIBBKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string JKEMPDGCAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string EJJFALKPGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Guid? MJBHGOLEIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private (int, int)? CMJOKGGNCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HashSet<T> LDHDHPKFALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), string> IBGAHBCGLDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<(T, int), float> MMBIPILNFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Dictionary<T, string> PILDMDILFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private string EKFOAICCICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool HOEHIBOJHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GELPMBCHBBO IIOEKICDOGE;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4A06460", Offset = "0x4A05860", VA = "0x184A06460")]
		public OBKPEMAOECF(Guid EKBPHLNJBLE, string DFFABBFBDNF, string DIMPEGEDIAJ, string NOHBNHDJOOD, [Optional] string JGEHOGGFEPF, [Optional] string GIKONIPLIME, [Optional] string HHPNHELMOCJ, [Optional] string EJJFALKPGCG, [Optional] string EKFOAICCICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C20", Offset = "0x8B2020", VA = "0x1808B2C20")]
		public void LMDGMHKMPEA(string JGEHOGGFEPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD00", Offset = "0x8AA100", VA = "0x1808AAD00")]
		public void CAPAKKOPLGN(string NOHBNHDJOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8B2360", Offset = "0x8B1760", VA = "0x1808B2360")]
		public void MJBAMMMIIGL(string EKFOAICCICI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAD0", Offset = "0x8ABED0", VA = "0x1808ACAD0")]
		public void BJMGDKJMMIG(string JEAAMJIBBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4A06450", Offset = "0x4A05850", VA = "0x184A06450")]
		public void PIBMGOCBNNJ(Guid? EKBPHLNJBLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4A01930", Offset = "0x4A00D30", VA = "0x184A01930")]
		public void CLHHGFOOMPP((int, int)? CMJOKGGNCCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB20", Offset = "0x8ABF20", VA = "0x1808ACB20")]
		public void JAJDOGIHHAJ(string JKEMPDGCAOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4A01CA0", Offset = "0x4A010A0", VA = "0x184A01CA0")]
		public void DLNMHNLKKCH(T MKKHNNOINLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4A00DB0", Offset = "0x4A001B0", VA = "0x184A00DB0")]
		public void AFCMFMGLGIK(T MKKHNNOINLF, int DGNDOAPADMC, float AMGMJAOIIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4A01660", Offset = "0x4A00A60", VA = "0x184A01660")]
		public void AHAJCGCKNKF(T MKKHNNOINLF, int DGNDOAPADMC, string JCCPHMKMHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4A05380", Offset = "0x4A04780", VA = "0x184A05380")]
		public void KHDFJPLMCAD(T MKKHNNOINLF, string GCACJCBBKGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4A01FE0", Offset = "0x4A013E0", VA = "0x184A01FE0")]
		public GELPMBCHBBO ELBHCMHCOGE(bool MALABKOONDB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4A04D20", Offset = "0x4A04120", VA = "0x184A04D20")]
		private (IEnumerable<T>, string) IHBKODFCANI()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4A05C90", Offset = "0x4A05090", VA = "0x184A05C90")]
		public static ODPECCCDLCM LICAECLEJGJ(Guid EKBPHLNJBLE, string DFFABBFBDNF, T MKKHNNOINLF, string DIMPEGEDIAJ, string DJGBOLBJCDK, string JGEHOGGFEPF, int? HAJICDLBEKC, [Optional] string ANLBIJDFAPJ, [Optional] string GCACJCBBKGG, [Optional] int? OFOMAOPOOIC, [Optional] Guid? MJBHGOLEIHA, [Optional] string EKFOAICCICI, [Optional] string EFAMPHDCDAB, [Optional] (int, int)? CMJOKGGNCCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4A01950", Offset = "0x4A00D50", VA = "0x184A01950")]
		[CompilerGenerated]
		private string CNONAFDAFIH(T NKPCGMJMEIE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class CIBMIMGPIGM<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected readonly string CBLLLCEODBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected readonly Guid CIAMAKMFKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected readonly long HLIJNPAAKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int PPOKIGIDFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int INEPJIFAOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected DateTime OIOPMIJAKKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected bool CEHAJPJJLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected Dictionary<long, PDLIDEPELNN> IKKLBPFFIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected bool JHLFLNOPBCG;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CADCNCOFEFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x97DB20", Offset = "0x97CF20", VA = "0x18097DB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool LFIGADFKICE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA15480", Offset = "0xA14880", VA = "0x180A15480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5965CA0", Offset = "0x59650A0", VA = "0x185965CA0")]
		public CIBMIMGPIGM(string CBLLLCEODBN, Guid CIAMAKMFKFA, long HLIJNPAAKME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void FKFGNELBIGH(TListSessionStartParams JBKFADCHMKB);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC24570", Offset = "0xC23970", VA = "0x180C24570")]
		public void AAINFCFAJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void CKEMDGOEOAG(bool BBCKBBJHADH, TListSessionLogParams MHCHAFEDOGO);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5965940", Offset = "0x5964D40", VA = "0x185965940")]
		public void BOKCEPCDHCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5965AB0", Offset = "0x5964EB0", VA = "0x185965AB0")]
		public void CAKPINMKNGD(long NNAHLJLIKCH, int HAJICDLBEKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5965C10", Offset = "0x5965010", VA = "0x185965C10")]
		public void IPADGBOCCLL(long NNAHLJLIKCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract PDLIDEPELNN IMIHPPEDABC(TItem HHDONFMCNBA, int HAJICDLBEKC, string MHDOPFNMJEE);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class PDLIDEPELNN : NPIKNPNGOFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int PPOKIGIDFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long NNAHLJLIKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private long HLIJNPAAKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly string OLBCCIFCFMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly string OPEHDIPGAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly int DJMOFGNFDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DateTime CCILEEDCEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private double JOGPBKFHDEA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool KOIPCEFOCJH
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x985720", Offset = "0x984B20", VA = "0x180985720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9850C0", Offset = "0x9844C0", VA = "0x1809850C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x648EEA0", Offset = "0x648E2A0", VA = "0x18648EEA0")]
		public PDLIDEPELNN(long NNAHLJLIKCH, int PPOKIGIDFJE, string EFAMPHDCDAB, long HLIJNPAAKME, int DJMOFGNFDNA, [Optional] string DIMPEGEDIAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x648EE30", Offset = "0x648E230", VA = "0x18648EE30")]
		public void OPPDOIGFGEH(int PPOKIGIDFJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x648E7C0", Offset = "0x648DBC0", VA = "0x18648E7C0")]
		public void GGFLLMDBHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x648ECC0", Offset = "0x648E0C0", VA = "0x18648ECC0")]
		public void KEIMIMGABLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x648EDD0", Offset = "0x648E1D0", VA = "0x18648EDD0")]
		private void KNGKEGNKMOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x648E810", Offset = "0x648DC10", VA = "0x18648E810", Slot = "5")]
		public virtual ODPECCCDLCM JAILHLJMEGG(Guid EKBPHLNJBLE, string JGFCOKPAFFB, [Optional] string EFAMPHDCDAB, [Optional] long? MKKHNNOINLF, [Optional] string DIMPEGEDIAJ, [Optional] string JGEHOGGFEPF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class CNKPLNPLICP
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class HDIJIOMGLDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public HDIJIOMGLDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x6489E70", Offset = "0x6489270", VA = "0x186489E70")]
			internal bool MBJDGEANANO()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct IOGJOEHKAIC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private HDIJIOMGLDI <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private TimeSpan <delayPollingInterval>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private bool <isForcedHeartbeatEvent>5__3;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x648ACB0", Offset = "0x648A0B0", VA = "0x18648ACB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x648BEA0", Offset = "0x648B2A0", VA = "0x18648BEA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly float MAKLNDGGEBM;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static Dictionary<string, Dictionary<string, object>> HFPBCKGIIKM;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static Dictionary<string, Dictionary<string, object>> FFIJBPEDEPF;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static string HKNAIAKKKEN;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static CancellationTokenSource? JDDIBOLAFIK;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static int DJBEJHMBBNM;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static int PHKEDAJKPFI;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static bool COJJMLBPDAK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly Dictionary<string, PBAAKHKGCHK> HLBNFCJAIBJ;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly PJFDJKKNHLD<bool> LCCAGCPLIPK;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static OMPFDBLPBEP? HLAMINIEJOM;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string EDPBBJKHNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x64861E0", Offset = "0x64855E0", VA = "0x1864861E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6488490", Offset = "0x6487890", VA = "0x186488490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? IGBDFLDHMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6487180", Offset = "0x6486580", VA = "0x186487180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6487980", Offset = "0x6486D80", VA = "0x186487980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Guid? DIOGFBFNAKI
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x6486230", Offset = "0x6485630", VA = "0x186486230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6485F50", Offset = "0x6485350", VA = "0x186485F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static PJKFGNFNJNN<bool> EGKJOBOJNLP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6488440", Offset = "0x6487840", VA = "0x186488440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool IDIPCAIONPH
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x64879E0", Offset = "0x6486DE0", VA = "0x1864879E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6487080", Offset = "0x6486480", VA = "0x186487080")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool NEGLCIFAFNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6486D40", Offset = "0x6486140", VA = "0x186486D40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6488620", Offset = "0x6487A20", VA = "0x186488620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private static float FONMJPBJKCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6486290", Offset = "0x6485690", VA = "0x186486290")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x6487A30", Offset = "0x6486E30", VA = "0x186487A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x64883B0", Offset = "0x64877B0", VA = "0x1864883B0")]
		public static void MLJALHGOBCH(string KOCDFBCKKPE, PBAAKHKGCHK NFDLEJFDLEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6487A90", Offset = "0x6486E90", VA = "0x186487A90")]
		private static void MBDKLFJEELC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6486000", Offset = "0x6485400", VA = "0x186486000")]
		internal static void CGCFJDLGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6486ED0", Offset = "0x64862D0", VA = "0x186486ED0")]
		internal static void HBEHOJCOJOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x64870E0", Offset = "0x64864E0", VA = "0x1864870E0")]
		internal static void IIEDCOOIFDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6486770", Offset = "0x6485B70", VA = "0x186486770")]
		public static Guid FKFGNELBIGH(string KOCDFBCKKPE, [Optional] string? BAIEBNKCGJF, [Optional] Dictionary<string, object>? EFMKANKHOBL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x64866D0", Offset = "0x6485AD0", VA = "0x1864866D0")]
		public static Guid FKFGNELBIGH(string KOCDFBCKKPE, long BAIEBNKCGJF, [Optional] Dictionary<string, object>? EFMKANKHOBL)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6485CF0", Offset = "0x64850F0", VA = "0x186485CF0")]
		public static void AAINFCFAJBP(string KOCDFBCKKPE, [Optional] Guid? GPJCGLBMIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6487710", Offset = "0x6486B10", VA = "0x186487710")]
		public static void JDEGHDCNOIB(string KOCDFBCKKPE, string PDAACPAIBNO, object HMHECCBBENO, bool COJJMLBPDAK = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6487EC0", Offset = "0x64872C0", VA = "0x186487EC0")]
		public static bool MEMEHCDNOAC(string KOCDFBCKKPE, [Optional] string? BAIEBNKCGJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6486D90", Offset = "0x6486190", VA = "0x186486D90")]
		private static void GLGHPFAMHPG(bool FNJGFIEEHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6488230", Offset = "0x6487630", VA = "0x186488230")]
		internal static void MGHCACPNIKH(string OMHMFLHBNDJ, string OEOMDKHBDFI, object AIKOCCMKKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x64880B0", Offset = "0x64874B0", VA = "0x1864880B0")]
		internal static void MGHCACPNIKH(string OMHMFLHBNDJ, Dictionary<string, object> KODDIJIFMHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6487910", Offset = "0x6486D10", VA = "0x186487910")]
		private static void JJAOBMDFDNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6485FB0", Offset = "0x64853B0", VA = "0x186485FB0")]
		public static void BLINHGONEDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6486680", Offset = "0x6485A80", VA = "0x186486680")]
		public static void FIIBIJEANJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x64862E0", Offset = "0x64856E0", VA = "0x1864862E0")]
		private static void FGLEHKBPHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6487640", Offset = "0x6486A40", VA = "0x186487640")]
		private static void INKMODEAMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6488540", Offset = "0x6487940", VA = "0x186488540")]
		[AsyncStateMachine(typeof(IOGJOEHKAIC))]
		private static Task PGHFHCEJKKD(CancellationToken NBBCMDKGJKI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x64871E0", Offset = "0x64865E0", VA = "0x1864871E0")]
		private static void INFGLKMCHDL(string KOCDFBCKKPE, Guid EKBPHLNJBLE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class DDEBLPOABMI
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct LBEFDDMMJBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public bool KDJCPPCLCIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string MOHONHDGABF;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x1F6DBB0", Offset = "0x1F6CFB0", VA = "0x181F6DBB0")]
			public LBEFDDMMJBP(bool KDJCPPCLCIG, string MOHONHDGABF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6488F10", Offset = "0x6488310", VA = "0x186488F10")]
		public static LBEFDDMMJBP PKELKJJEMAA(ODPECCCDLCM GHLOOJNKPDN)
		{
			return default(LBEFDDMMJBP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6488D50", Offset = "0x6488150", VA = "0x186488D50")]
		private static void AENGAHICJFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6488E50", Offset = "0x6488250", VA = "0x186488E50")]
		private static void FACOKBCNLDA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NJHJLADIBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x648E5B0", Offset = "0x648D9B0", VA = "0x18648E5B0")]
		public static ODPECCCDLCM ADBHAONEGIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class DBHOIDFCHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6488CF0", Offset = "0x64880F0", VA = "0x186488CF0")]
		public static ODPECCCDLCM NEDEEIIIBHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x64889F0", Offset = "0x6487DF0", VA = "0x1864889F0")]
		public static ODPECCCDLCM FBDNNPGHHAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6488BD0", Offset = "0x6487FD0", VA = "0x186488BD0")]
		public static ODPECCCDLCM JNDNHEGAACD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x64888D0", Offset = "0x6487CD0", VA = "0x1864888D0")]
		public static ODPECCCDLCM BAHHABNHMKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6488A50", Offset = "0x6487E50", VA = "0x186488A50")]
		public static ODPECCCDLCM HODPKFMBBIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6488AB0", Offset = "0x6487EB0", VA = "0x186488AB0")]
		public static ODPECCCDLCM IOLMNGBCBDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6488930", Offset = "0x6487D30", VA = "0x186488930")]
		public static ODPECCCDLCM CDJOPLHAGJF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6488C90", Offset = "0x6488090", VA = "0x186488C90")]
		public static ODPECCCDLCM NBCHPAPLFIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6488B10", Offset = "0x6487F10", VA = "0x186488B10")]
		public static ODPECCCDLCM JDAAOBOFFBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6488B70", Offset = "0x6487F70", VA = "0x186488B70")]
		public static ODPECCCDLCM JMMIOIGDMPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6488990", Offset = "0x6487D90", VA = "0x186488990")]
		public static ODPECCCDLCM DHIIDGMDJDL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6488C30", Offset = "0x6488030", VA = "0x186488C30")]
		public static ODPECCCDLCM MPGKLMHNLNC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class BKOEPPBKDED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6485B10", Offset = "0x6484F10", VA = "0x186485B10")]
		public static ODPECCCDLCM JLOCNKGFIDD(long FJBFONPAOAD, long JOABCKCOFMA, bool CKGJBNHKIFL, string JKGEMLFJKOI, string LDHOALNGNFL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class KIHDLOMBEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x648D8E0", Offset = "0x648CCE0", VA = "0x18648D8E0")]
		public static ODPECCCDLCM IEBLPNOMMPN(string KKFPEKMBKKK, string DPLPKFCAKIG, bool HFBEFEIAAJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x648DA50", Offset = "0x648CE50", VA = "0x18648DA50")]
		public static ODPECCCDLCM KOLMDGPAENM(string OMHMFLHBNDJ, string ODEHFKLEMHM, string PHJMBCPAGBC, [Optional] int? BLKBLBADJIK, [Optional] double[] PBFHDPDEKIF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class IMAPAHGMMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x648A1D0", Offset = "0x64895D0", VA = "0x18648A1D0")]
		public static ODPECCCDLCM FPCGFIHHCID(string FBLPBKIAANB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x648A520", Offset = "0x6489920", VA = "0x18648A520")]
		public static ODPECCCDLCM HOCONHBJCPA(string FDGNCIPFLEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6489F60", Offset = "0x6489360", VA = "0x186489F60")]
		public static ODPECCCDLCM CCLLELDHLMO(int OEOJIBEMNAM, string DDDHPCNFCEK, string NKPCGMJMEIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x648A170", Offset = "0x6489570", VA = "0x18648A170")]
		public static ODPECCCDLCM FGBEINMIIBF(int OEOJIBEMNAM, string DDDHPCNFCEK, string NKPCGMJMEIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6489FC0", Offset = "0x64893C0", VA = "0x186489FC0")]
		public static ODPECCCDLCM DJENGLGMPML(int OEOJIBEMNAM, string DDDHPCNFCEK, string NKPCGMJMEIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x648A600", Offset = "0x6489A00", VA = "0x18648A600")]
		public static ODPECCCDLCM NKGPFJGJMFK(int OEOJIBEMNAM, string DDDHPCNFCEK, string NKPCGMJMEIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x648A020", Offset = "0x6489420", VA = "0x18648A020")]
		public static ODPECCCDLCM EKEPAGJLEFN(string DDDHPCNFCEK, string NKPCGMJMEIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x648A2B0", Offset = "0x64896B0", VA = "0x18648A2B0")]
		private static ODPECCCDLCM HHLOKKIBDDM(string CBLLLCEODBN, int OEOJIBEMNAM, string HKBMGECEJEI, string JHEMMGMGOOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x648A3F0", Offset = "0x64897F0", VA = "0x18648A3F0")]
		private static ODPECCCDLCM HHLOKKIBDDM(string CBLLLCEODBN, string HKBMGECEJEI, string JHEMMGMGOOG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly FLILHMOBPPM PKELKJJEMAA;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static EMIKPOFNKEE NONJFGLABPH;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static AMJGCABCMKH GPODKPAOAFI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<ODPECCCDLCM> KMPDBMAIHPN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long EONPJAHICCN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64898E0", Offset = "0x6488CE0", VA = "0x1864898E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64899D0", Offset = "0x6488DD0", VA = "0x1864899D0")]
	[GEPLGCINGLB.DNOGLPMHBOB]
	internal static void PDDEBFDPIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x64895D0", Offset = "0x64889D0", VA = "0x1864895D0")]
	private static void CGCFJDLGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6489690", Offset = "0x6488A90", VA = "0x186489690")]
	public static ODPECCCDLCM NIAELIHBOHK(string IMOHKABEMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6489710", Offset = "0x6488B10", VA = "0x186489710")]
	public static ODPECCCDLCM NIAELIHBOHK(string IMOHKABEMNJ, int OEOJIBEMNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x64897C0", Offset = "0x6488BC0", VA = "0x1864897C0")]
	[GEPLGCINGLB.DNOGLPMHBOB]
	internal static void NIEPGIJOBBG()
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
