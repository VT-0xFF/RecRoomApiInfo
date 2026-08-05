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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6324F10", Offset = "0x6324110", VA = "0x186324F10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C0750", Offset = "0x8BF950", VA = "0x1808C0750")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C0790", Offset = "0x8BF990", VA = "0x1808C0790")]
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
	public class LogRegistrationIndex : MPFOBEHAELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6324E30", Offset = "0x6324030", VA = "0x186324E30", Slot = "4")]
		public override void ALGAFMBJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6326070", Offset = "0x6325270", VA = "0x186326070", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface POLAIOINCOD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<string, object> JAECAIMKJHA();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KADOAKAHJLM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface JPKICEJMAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KDNKODPIPNI OCAFNBFEPAA(Guid AGBINIFDAHI, string KAHIBNOIODP, [Optional] string BBKEAILFBHL, [Optional] long? JNLBHIGBPMF, [Optional] string FKNBFFOAAJK, [Optional] string CACMEDGFIIF);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class OOGCHGKHOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6325330", Offset = "0x6324530", VA = "0x186325330")]
		public static KDNKODPIPNI ANHFBNFJICK(Guid AGBINIFDAHI, string KAHIBNOIODP, string BBKEAILFBHL, [Optional] long? JNLBHIGBPMF, [Optional] string FKNBFFOAAJK, [Optional] string CACMEDGFIIF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class KDNKODPIPNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		protected LDFCHLJHEKN LCGCLNOIDEA;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89D490", Offset = "0x89C690", VA = "0x18089D490")]
		public KDNKODPIPNI(LDFCHLJHEKN LCGCLNOIDEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6321040", Offset = "0x6320240", VA = "0x186321040")]
		public KDNKODPIPNI OBIMIFGACNE(string BAEKDMBADGA, string JECHHBGMFLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x34D0130", Offset = "0x34CF330", VA = "0x1834D0130")]
		public KDNKODPIPNI OBIMIFGACNE<T>(string BAEKDMBADGA, T JECHHBGMFLN) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x34D00A0", Offset = "0x34CF2A0", VA = "0x1834D00A0")]
		public KDNKODPIPNI DKLPFOGGHAL<T>(string BAEKDMBADGA, T? JECHHBGMFLN) where T : struct
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6320F90", Offset = "0x6320190", VA = "0x186320F90")]
		public KDNKODPIPNI DKLPFOGGHAL(string BAEKDMBADGA, string JECHHBGMFLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6321020", Offset = "0x6320220", VA = "0x186321020")]
		public KAHDNIHNJDF EDECJLLKNCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x21E66F0", Offset = "0x21E58F0", VA = "0x1821E66F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class LDFCHLJHEKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static Action<LDFCHLJHEKN> BEOMEOFHCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly string EIGECJIBAAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<string, object> PDKPPMKCJMC;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6324910", Offset = "0x6323B10", VA = "0x186324910")]
		private LDFCHLJHEKN(string EIGECJIBAAN, int HBNHEKOLHND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6320E70", Offset = "0x6320070", VA = "0x186320E70")]
		public static KDNKODPIPNI LGJIMIKIEOH(string EIGECJIBAAN, int HBNHEKOLHND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6324600", Offset = "0x6323800", VA = "0x186324600")]
		public KAHDNIHNJDF EDECJLLKNCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x63248A0", Offset = "0x6323AA0", VA = "0x1863248A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2C6A5C0", Offset = "0x2C697C0", VA = "0x182C6A5C0")]
		internal void GCGFJGBEFLF<T>(string BAEKDMBADGA, T JECHHBGMFLN) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6324840", Offset = "0x6323A40", VA = "0x186324840")]
		internal void GCGFJGBEFLF(string BAEKDMBADGA, string JECHHBGMFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x34D1AD0", Offset = "0x34D0CD0", VA = "0x1834D1AD0")]
		private void MOMKNBMDHOC<T>(string BAEKDMBADGA, T JECHHBGMFLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct KKNCMFEHJPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly string BACJFMBCPFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly long? KAHMLHFALKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly short? OKNNCBGLBID;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x63245C0", Offset = "0x63237C0", VA = "0x1863245C0")]
		public KKNCMFEHJPG(string MDCHOKMFLFA, [Optional] long? MMNCPOOFGEF, [Optional] short? LJECNFGEAKD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct NCIDEGMPGOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly int BHHPOLONGGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string JKAONEOOJHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly short AAGGDPKDEHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string AACPJBDKMPD;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6324EC0", Offset = "0x63240C0", VA = "0x186324EC0")]
		public NCIDEGMPGOD(int PKNFIKHOBEK, string NGCDJIPOMLB, short NDMAMIFPBLK, string ENFIBCFNBBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class CGIEBIJDFBI : IJEHABIDJNK<POIAGPIPFHA, NCIDEGMPGOD, KKNCMFEHJPG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string NGCDJIPOMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private short NDMAMIFPBLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string ENFIBCFNBBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Dictionary<short, int> LAFFEAKKOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int CNHMLONFGFA;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x631E980", Offset = "0x631DB80", VA = "0x18631E980")]
		public CGIEBIJDFBI(string DKGLKDOENCI, Guid LFEIPCFLGHA, long FONNPINLHLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x631E690", Offset = "0x631D890", VA = "0x18631E690", Slot = "4")]
		public override void OFFEKNPJGDM(NCIDEGMPGOD KJILJECFBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x631D7D0", Offset = "0x631C9D0", VA = "0x18631D7D0")]
		public void GHDGDAGGFDD(short NDMAMIFPBLK, bool ICHAPIDJBHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E514B0", Offset = "0x3E506B0", VA = "0x183E514B0")]
		public void IPNNNAEHEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8941C0", Offset = "0x8933C0", VA = "0x1808941C0")]
		public void EHMOGNNADLG(string FINDANLFGBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x631D8B0", Offset = "0x631CAB0", VA = "0x18631D8B0", Slot = "5")]
		public override void LEOKFGEANGK(bool GLCAOFIIPOM, KKNCMFEHJPG GGFJIFHHEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x631D520", Offset = "0x631C720", VA = "0x18631D520", Slot = "6")]
		public override APMPNOPHNIC CKEFOLHKPNN(POIAGPIPFHA IAODKJFIKHM, int KINMHNEMPOD, string CEHCHNCKAKA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class IMDJADLPPEJ : APMPNOPHNIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private string NGCDJIPOMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly short NDMAMIFPBLK;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x631EC80", Offset = "0x631DE80", VA = "0x18631EC80")]
		public IMDJADLPPEJ(long PLLOFJJFIKG, int PKNFIKHOBEK, string BBKEAILFBHL, long FONNPINLHLC, int DGIGENFNJPM, string FKNBFFOAAJK, short NDMAMIFPBLK, string NGCDJIPOMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x631EAD0", Offset = "0x631DCD0", VA = "0x18631EAD0")]
		public void JLIKNKDAPCJ(int PKNFIKHOBEK, string NGCDJIPOMLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x631EB50", Offset = "0x631DD50", VA = "0x18631EB50", Slot = "5")]
		public override KDNKODPIPNI OCAFNBFEPAA(Guid AGBINIFDAHI, string KAHIBNOIODP, [Optional] string BBKEAILFBHL, [Optional] long? JNLBHIGBPMF, [Optional] string FKNBFFOAAJK, [Optional] string CACMEDGFIIF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class IBAKKBEFLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x631EA00", Offset = "0x631DC00", VA = "0x18631EA00")]
		public static void HHMGNLBPJNH(string CPBLLDDDHEE, object ONMNMNGDPOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class KGBMFHNGACM
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public readonly struct KDOKLJGGEOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public readonly int NHDNJINNEMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public readonly int OIIPDGLNOPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public readonly int IMPIMMABHLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public readonly int AAALCAFOJNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public readonly int NGLHCPKOFAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public readonly int AKCHPPJACDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public readonly int IKDEOFBCCKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public readonly int JPKGEKJBDON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public readonly int HIOONOKPMEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public readonly int HLJJBENJMGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public readonly int MOKBEAMBNKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public readonly int BNGNCBKPJJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public readonly int BKPLKIMPIPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public readonly int CGDAOHPOFPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly int DBLOLKIECDO;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63210C0", Offset = "0x63202C0", VA = "0x1863210C0")]
			public KDOKLJGGEOA(int EBEBNJGOBFO, int ANEEFKBHPCO, int ANEIDFDLLOL, int CDDAAOHFIFN, int HMMGMBBJGMN, int BEHJPPLILPK, int NHKNGKJIJMF, int LIEPJHOAJNO, int GEPFOGAKCDF, int HECKEILELIF, int IBDPJBEHOEK, int CPKEKKEMOGL, int BEKCJKFPDMN, int NPOBIDANKBC, int FJJKIOCICMN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static Dictionary<string, object>? HPOEEFMCFLC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private static Dictionary<string, object> MJDLEKKBCFL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6321130", Offset = "0x6320330", VA = "0x186321130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x63211E0", Offset = "0x63203E0", VA = "0x1863211E0")]
		public static void GFILIIBPJKA(KDOKLJGGEOA NFEAADKNGGC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class OOIKDMNBMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6325880", Offset = "0x6324A80", VA = "0x186325880")]
		public static void HHMGNLBPJNH(string CPBLLDDDHEE, object ONMNMNGDPOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6325770", Offset = "0x6324970", VA = "0x186325770")]
		public static void HHMGNLBPJNH(string CPBLLDDDHEE, float JECHHBGMFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6325540", Offset = "0x6324740", VA = "0x186325540")]
		public static void HHMGNLBPJNH(string CPBLLDDDHEE, DONPJEOIHOP ONMNMNGDPOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class JDNIJNHPDGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x631EE90", Offset = "0x631E090", VA = "0x18631EE90")]
		public static void GCOIABEKADJ(float3 FJFKFIAGEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x631ED70", Offset = "0x631DF70", VA = "0x18631ED70")]
		public static void DGHBJMLHHJL(bool PBCBJAEFFFC, bool BKPPADGMPJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x631EFA0", Offset = "0x631E1A0", VA = "0x18631EFA0")]
		public static void HDOMIEABCJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class MPPFCJDEEDE<T> where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class IILIMEGJHMA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public MPPFCJDEEDE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public IILIMEGJHMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4175C60", Offset = "0x4174E60", VA = "0x184175C60")]
			internal object NFKFCHLDEHG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class LFLLBAENGIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public MPPFCJDEEDE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public LFLLBAENGIA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4550210", Offset = "0x454F410", VA = "0x184550210")]
			internal object JAPOAFPBGLG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class GMAAPOGCEOP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public MPPFCJDEEDE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public GMAAPOGCEOP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3FC7840", Offset = "0x3FC6A40", VA = "0x183FC7840")]
			internal object CJADFPKFEKE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class HIOPFHPDGJC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public MPPFCJDEEDE<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public T elementId;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public HIOPFHPDGJC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4038820", Offset = "0x4037A20", VA = "0x184038820")]
			internal object IAHAKHMLLBM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const float IAADHHFPJKO = 0.1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Guid AGBINIFDAHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly string FKNBFFOAAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly string IAJOJNEIHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private string GHGPFMFFOEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private string CACMEDGFIIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private string NHBPMEJNEDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private string GPMEIHALFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private string GIAFHHDJFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private string DFBBBHDAAOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private string PCJAHDDAOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private Guid? KDHKPKENPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private (int, int)? ICJJOPBPHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly HashSet<T> KDCICJKMNLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Dictionary<(T, int), string> GNBCGKOKJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly Dictionary<(T, int), float> EIHCOABKJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Dictionary<T, string> CJFJLIFIPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private string KHJHABIELMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool FANKLFMJICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private KAHDNIHNJDF DEDIBBPEHLL;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x47D2CB0", Offset = "0x47D1EB0", VA = "0x1847D2CB0")]
		public MPPFCJDEEDE(Guid AGBINIFDAHI, string IAJOJNEIHHB, string FKNBFFOAAJK, string GHGPFMFFOEO, [Optional] string CACMEDGFIIF, [Optional] string NHBPMEJNEDP, [Optional] string GPMEIHALFEA, [Optional] string PCJAHDDAOAP, [Optional] string KHJHABIELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x894320", Offset = "0x893520", VA = "0x180894320")]
		public void CALIPENBCDO(string CACMEDGFIIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89AD00", Offset = "0x899F00", VA = "0x18089AD00")]
		public void EOBEPEJPJKF(string GHGPFMFFOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8993B0", Offset = "0x8985B0", VA = "0x1808993B0")]
		public void KIMDFAAOANK(string KHJHABIELMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x894430", Offset = "0x893630", VA = "0x180894430")]
		public void OHBBHAIAAKP(string GIAFHHDJFLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x47CDA30", Offset = "0x47CCC30", VA = "0x1847CDA30")]
		public void CFNHLMINHEO(Guid? AGBINIFDAHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x47D2AE0", Offset = "0x47D1CE0", VA = "0x1847D2AE0")]
		public void MNEHANPNABO((int, int)? ICJJOPBPHHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x894370", Offset = "0x893570", VA = "0x180894370")]
		public void OHOEPEFCAPH(string DFBBBHDAAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x47D1C40", Offset = "0x47D0E40", VA = "0x1847D1C40")]
		public void MAJEHCONCEA(T JNLBHIGBPMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x47D0000", Offset = "0x47CF200", VA = "0x1847D0000")]
		public void EFMLGKCHNEP(T JNLBHIGBPMF, int HFDPLIEEHJI, float OIHNKNJFMCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x47CD290", Offset = "0x47CC490", VA = "0x1847CD290")]
		public void ADMPJKEMKMG(T JNLBHIGBPMF, int HFDPLIEEHJI, string JGEIJHBPDHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x47D1760", Offset = "0x47D0960", VA = "0x1847D1760")]
		public void HOGGJGAGLLJ(T JNLBHIGBPMF, string CCBIKMDCLHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x47CE4C0", Offset = "0x47CD6C0", VA = "0x1847CE4C0")]
		public KAHDNIHNJDF EDECJLLKNCK(bool PLHFEDHICDP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x47D0980", Offset = "0x47CFB80", VA = "0x1847D0980")]
		private (IEnumerable<T>, string) GLFAJALDGJC()
		{
			return default((IEnumerable<T>, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x47D2330", Offset = "0x47D1530", VA = "0x1847D2330")]
		public static KDNKODPIPNI MFHCMCBPIJC(Guid AGBINIFDAHI, string IAJOJNEIHHB, T JNLBHIGBPMF, string FKNBFFOAAJK, string AJAPLFABLIB, string CACMEDGFIIF, int? KINMHNEMPOD, [Optional] string MKEPIJDPILN, [Optional] string CCBIKMDCLHJ, [Optional] int? IDAFKJLBELB, [Optional] Guid? KDHKPKENPNK, [Optional] string KHJHABIELMB, [Optional] string BBKEAILFBHL, [Optional] (int, int)? ICJJOPBPHHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x47D2C20", Offset = "0x47D1E20", VA = "0x1847D2C20")]
		[CompilerGenerated]
		private string POHCEJEEAEA(T MHMAFIBKDFF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class IJEHABIDJNK<TItem, TListSessionStartParams, TListSessionLogParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		protected readonly string DKGLKDOENCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		protected readonly Guid LFEIPCFLGHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		protected readonly long FONNPINLHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		protected int PKNFIKHOBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		protected int NKAFHFMCGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		protected DateTime DCGBJEOBLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		protected bool LCMOPOCGFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		protected Dictionary<long, APMPNOPHNIC> LELOMNPPJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		protected bool FPIFLIFPBIP;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool GAJGBHCNAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x969330", Offset = "0x968530", VA = "0x180969330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool EDLIMHNCPAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9F8F10", Offset = "0x9F8110", VA = "0x1809F8F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4177410", Offset = "0x4176610", VA = "0x184177410")]
		public IJEHABIDJNK(string DKGLKDOENCI, Guid LFEIPCFLGHA, long FONNPINLHLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void OFFEKNPJGDM(TListSessionStartParams KJILJECFBHP);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC10920", Offset = "0xC0FB20", VA = "0x180C10920")]
		public void JFOKICJNICO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void LEOKFGEANGK(bool GLCAOFIIPOM, TListSessionLogParams GGFJIFHHEDF);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4177180", Offset = "0x4176380", VA = "0x184177180")]
		public void OJLOPEBFGLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x41770B0", Offset = "0x41762B0", VA = "0x1841770B0")]
		public void BJMDFIEGOFA(long PLLOFJJFIKG, int KINMHNEMPOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x41772B0", Offset = "0x41764B0", VA = "0x1841772B0")]
		public void OPKKKLEEICH(long PLLOFJJFIKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract APMPNOPHNIC CKEFOLHKPNN(TItem LFDONPLGGIG, int KINMHNEMPOD, string CEHCHNCKAKA);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class APMPNOPHNIC : JPKICEJMAML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int PKNFIKHOBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private long PLLOFJJFIKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private long FONNPINLHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly string CGFADNMCMBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly string PCCOIALFGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly int DGIGENFNJPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private DateTime OIMJGMNBBPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private double HEMDAPKMJBO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DKKEOGGKFOP
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x973670", Offset = "0x972870", VA = "0x180973670")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9738E0", Offset = "0x972AE0", VA = "0x1809738E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x631D450", Offset = "0x631C650", VA = "0x18631D450")]
		public APMPNOPHNIC(long PLLOFJJFIKG, int PKNFIKHOBEK, string BBKEAILFBHL, long FONNPINLHLC, int DGIGENFNJPM, [Optional] string FKNBFFOAAJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x631CDD0", Offset = "0x631BFD0", VA = "0x18631CDD0")]
		public void JJGCHEPIBGF(int PKNFIKHOBEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x631D400", Offset = "0x631C600", VA = "0x18631D400")]
		public void PDAOCCDKBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x631CE40", Offset = "0x631C040", VA = "0x18631CE40")]
		public void NJCMAINJHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x631CD70", Offset = "0x631BF70", VA = "0x18631CD70")]
		private void HIKDKNAIBKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x631CF50", Offset = "0x631C150", VA = "0x18631CF50", Slot = "5")]
		public virtual KDNKODPIPNI OCAFNBFEPAA(Guid AGBINIFDAHI, string KAHIBNOIODP, [Optional] string BBKEAILFBHL, [Optional] long? JNLBHIGBPMF, [Optional] string FKNBFFOAAJK, [Optional] string CACMEDGFIIF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class KHAJDEJABAH
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class JHEOOIOIGIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public float nextHeartbeatSendTime;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public JHEOOIOIGIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x631F040", Offset = "0x631E240", VA = "0x18631F040")]
			internal bool PLCMLBOFDJG()
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct JMANFDECBKN : IAsyncStateMachine
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
			private JHEOOIOIGIB <>8__1;

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
			[Cpp2IlInjected.Address(RVA = "0x631F7E0", Offset = "0x631E9E0", VA = "0x18631F7E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x63209D0", Offset = "0x631FBD0", VA = "0x1863209D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public static readonly float DGALFILHFPN;

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static Dictionary<string, Dictionary<string, object>> FDAACEHPAAP;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static Dictionary<string, Dictionary<string, object>> KNHGKJCJLNB;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static string PFIEGLAGHMK;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static CancellationTokenSource? MEPJGPBNBGK;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static int FHGNHJAGLFD;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static int KPAGLNIIEKB;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static bool MHKNNGIFNHH;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static readonly Dictionary<string, POLAIOINCOD> FIOJLBCMNIL;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly MNNONBMLAOA<bool> DBLFGANJDIF;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static ILGPNHEOFNI? BPNGGOHGOND;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		private static string NLOOOCIIFNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6324320", Offset = "0x6323520", VA = "0x186324320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6322BC0", Offset = "0x6321DC0", VA = "0x186322BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static Guid? PKOKMJGEBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6323510", Offset = "0x6322710", VA = "0x186323510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6323570", Offset = "0x6322770", VA = "0x186323570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Guid? IOJIFLINGFA
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x63235D0", Offset = "0x63227D0", VA = "0x1863235D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6322160", Offset = "0x6321360", VA = "0x186322160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static DCLHMIFOFNO<bool> KDIDBFGEFGH
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6322490", Offset = "0x6321690", VA = "0x186322490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private static bool IBDDCCHECFF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x6321D70", Offset = "0x6320F70", VA = "0x186321D70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x6323B40", Offset = "0x6322D40", VA = "0x186323B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private static bool GDGHGJLELKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x6323BA0", Offset = "0x6322DA0", VA = "0x186323BA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x6323AE0", Offset = "0x6322CE0", VA = "0x186323AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private static float HNNMCNIABDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x63242D0", Offset = "0x63234D0", VA = "0x1863242D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x63229B0", Offset = "0x6321BB0", VA = "0x1863229B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x63224E0", Offset = "0x63216E0", VA = "0x1863224E0")]
		public static void GGCGPIMGFEA(string GCMONJEFKOH, POLAIOINCOD ONHCBDPJCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x63230E0", Offset = "0x63222E0", VA = "0x1863230E0")]
		private static void JJODDICHPKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6322260", Offset = "0x6321460", VA = "0x186322260")]
		internal static void DDNLIMMJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6321DC0", Offset = "0x6320FC0", VA = "0x186321DC0")]
		internal static void AOJKMPFKLPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x63221C0", Offset = "0x63213C0", VA = "0x1863221C0")]
		internal static void CHHHCFHPIJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6323C90", Offset = "0x6322E90", VA = "0x186323C90")]
		public static Guid OFFEKNPJGDM(string GCMONJEFKOH, [Optional] string? NPIMNAEGOCC, [Optional] Dictionary<string, object>? HGMNFBABFJD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6323BF0", Offset = "0x6322DF0", VA = "0x186323BF0")]
		public static Guid OFFEKNPJGDM(string GCMONJEFKOH, long NPIMNAEGOCC, [Optional] Dictionary<string, object>? HGMNFBABFJD)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6322C70", Offset = "0x6321E70", VA = "0x186322C70")]
		public static void JFOKICJNICO(string GCMONJEFKOH, [Optional] Guid? KGBBBBHDKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6322ED0", Offset = "0x63220D0", VA = "0x186322ED0")]
		public static void JIJDDEPFBPI(string GCMONJEFKOH, string BKKKDBHEDBF, object NNMNEBOGJBE, bool MHKNNGIFNHH = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6321F70", Offset = "0x6321170", VA = "0x186321F70")]
		public static bool BHFHFDBKIEF(string GCMONJEFKOH, [Optional] string? NPIMNAEGOCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6322570", Offset = "0x6321770", VA = "0x186322570")]
		private static void GHCJKJLIBNJ(bool CBGDKLAFDBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6322830", Offset = "0x6321A30", VA = "0x186322830")]
		internal static void GLPMBIGHLNI(string GFIAFOEJCDD, string CPBLLDDDHEE, object LJIEGDEDOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x63226B0", Offset = "0x63218B0", VA = "0x1863226B0")]
		internal static void GLPMBIGHLNI(string GFIAFOEJCDD, Dictionary<string, object> MOJPKHAFJOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6324260", Offset = "0x6323460", VA = "0x186324260")]
		private static void OFIMDHEBGDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6322440", Offset = "0x6321640", VA = "0x186322440")]
		public static void DMMPLNELOIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6323630", Offset = "0x6322830", VA = "0x186323630")]
		public static void LGFFDJPJJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x63219D0", Offset = "0x6320BD0", VA = "0x1863219D0")]
		private static void AGOLHDPEOPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6322AF0", Offset = "0x6321CF0", VA = "0x186322AF0")]
		private static void HAGPFFDBHIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6322A10", Offset = "0x6321C10", VA = "0x186322A10")]
		[AsyncStateMachine(typeof(JMANFDECBKN))]
		private static Task GOADJANAMDI(CancellationToken DDNLBFLLCLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6323680", Offset = "0x6322880", VA = "0x186323680")]
		private static void LKFCKLOEDEF(string GCMONJEFKOH, Guid AGBINIFDAHI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class AJOANJHFLAB
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct ECNOCMFFOCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public bool LIFLGCGNBFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public string CEDHAKCPDLI;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x1F43800", Offset = "0x1F42A00", VA = "0x181F43800")]
			public ECNOCMFFOCP(bool LIFLGCGNBFL, string CEDHAKCPDLI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x631CA60", Offset = "0x631BC60", VA = "0x18631CA60")]
		public static ECNOCMFFOCP OBPAMGBPHCN(KDNKODPIPNI CCKMMJDGLKE)
		{
			return default(ECNOCMFFOCP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x631C8A0", Offset = "0x631BAA0", VA = "0x18631C8A0")]
		private static void NBKLFNCGNJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x631C9A0", Offset = "0x631BBA0", VA = "0x18631C9A0")]
		private static void OBFENNCLIDF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class ILDDBLMHPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x631EA70", Offset = "0x631DC70", VA = "0x18631EA70")]
		public static KDNKODPIPNI JKAHDIFJPDD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PPEAOCEOJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6325BF0", Offset = "0x6324DF0", VA = "0x186325BF0")]
		public static KDNKODPIPNI JNHGBLIJHCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6325B30", Offset = "0x6324D30", VA = "0x186325B30")]
		public static KDNKODPIPNI JIPEIIPJMIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6325A10", Offset = "0x6324C10", VA = "0x186325A10")]
		public static KDNKODPIPNI FFBLCFPMBBP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x63259B0", Offset = "0x6324BB0", VA = "0x1863259B0")]
		public static KDNKODPIPNI FBNDOHEMJMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x63258F0", Offset = "0x6324AF0", VA = "0x1863258F0")]
		public static KDNKODPIPNI CPBJPDBDFCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6325950", Offset = "0x6324B50", VA = "0x186325950")]
		public static KDNKODPIPNI FAAHOLDFFCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6325CB0", Offset = "0x6324EB0", VA = "0x186325CB0")]
		public static KDNKODPIPNI NALCJPHAIOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6325AD0", Offset = "0x6324CD0", VA = "0x186325AD0")]
		public static KDNKODPIPNI INJIKGCOFFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6325C50", Offset = "0x6324E50", VA = "0x186325C50")]
		public static KDNKODPIPNI LKBLDICKPGE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6325A70", Offset = "0x6324C70", VA = "0x186325A70")]
		public static KDNKODPIPNI GJODNIBHDAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6325D10", Offset = "0x6324F10", VA = "0x186325D10")]
		public static KDNKODPIPNI OENKHIJGLNF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6325B90", Offset = "0x6324D90", VA = "0x186325B90")]
		public static KDNKODPIPNI JLOJLKJJEOI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class LOMKGGPNKPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6324C50", Offset = "0x6323E50", VA = "0x186324C50")]
		public static KDNKODPIPNI FKIHJMHEGKE(long MMNCPOOFGEF, long NAFENLOBBFI, bool LDHPHMLKIOC, string NOABLJJIFDM, string NLBNGOKOEPJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ODCDOBABPND
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6324F90", Offset = "0x6324190", VA = "0x186324F90")]
		public static KDNKODPIPNI LGKECNLIHHG(string PEFNBJCFOGL, string PLHODBJAEJI, bool IHFNDPBOKPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6325100", Offset = "0x6324300", VA = "0x186325100")]
		public static KDNKODPIPNI MGNOFILCKKG(string GFIAFOEJCDD, string FDCBHNILAGI, string IPNJNLPAKHE, [Optional] int? JCHGCPHBPAA, [Optional] double[] MOCCAANHEFP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class JIGHLBMIAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x631F5B0", Offset = "0x631E7B0", VA = "0x18631F5B0")]
		public static KDNKODPIPNI PCPKFACMFOL(string OAGGKKJEHAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x631F410", Offset = "0x631E610", VA = "0x18631F410")]
		public static KDNKODPIPNI EPELHLMBALF(string KBMABNAOIOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x631F4F0", Offset = "0x631E6F0", VA = "0x18631F4F0")]
		public static KDNKODPIPNI JECAJEFOFPM(int HBNHEKOLHND, string EPPPGDEIJCI, string MHMAFIBKDFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x631F0E0", Offset = "0x631E2E0", VA = "0x18631F0E0")]
		public static KDNKODPIPNI AJPINOCMIGO(int HBNHEKOLHND, string EPPPGDEIJCI, string MHMAFIBKDFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x631F550", Offset = "0x631E750", VA = "0x18631F550")]
		public static KDNKODPIPNI KPCEDPFOLHJ(int HBNHEKOLHND, string EPPPGDEIJCI, string MHMAFIBKDFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x631F140", Offset = "0x631E340", VA = "0x18631F140")]
		public static KDNKODPIPNI BBIILEDIDHJ(int HBNHEKOLHND, string EPPPGDEIJCI, string MHMAFIBKDFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x631F690", Offset = "0x631E890", VA = "0x18631F690")]
		public static KDNKODPIPNI PJGEJHIJIND(string EPPPGDEIJCI, string MHMAFIBKDFF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x631F1A0", Offset = "0x631E3A0", VA = "0x18631F1A0")]
		private static KDNKODPIPNI BDLHFFPILHG(string DKGLKDOENCI, int HBNHEKOLHND, string OCGGMLGDNMM, string PNCFDGHDLAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x631F2E0", Offset = "0x631E4E0", VA = "0x18631F2E0")]
		private static KDNKODPIPNI BDLHFFPILHG(string DKGLKDOENCI, string OCGGMLGDNMM, string PNCFDGHDLAN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly GAFGFHIJEHD OBPAMGBPHCN;

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private static NHPNODKLKOI HGMOGMHICAM;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static HEFMPGEOOHA NANBNLLJKDO;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static Queue<KDNKODPIPNI> OGIFAFGDAMH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static long AKPKHFIOFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6320C10", Offset = "0x631FE10", VA = "0x186320C10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6320D00", Offset = "0x631FF00", VA = "0x186320D00")]
	[FDIPEGGIDGC.LPKMJLHEMIB]
	internal static void LJDDNBPKOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6320B50", Offset = "0x631FD50", VA = "0x186320B50")]
	private static void DDNLIMMJHCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6320DF0", Offset = "0x631FFF0", VA = "0x186320DF0")]
	public static KDNKODPIPNI OLDEGHBFFPN(string EIGECJIBAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6320E70", Offset = "0x6320070", VA = "0x186320E70")]
	public static KDNKODPIPNI OLDEGHBFFPN(string EIGECJIBAAN, int HBNHEKOLHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6320A30", Offset = "0x631FC30", VA = "0x186320A30")]
	[FDIPEGGIDGC.LPKMJLHEMIB]
	internal static void BNOIHMEJJPC()
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
