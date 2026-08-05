using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71C5A80", Offset = "0x71C4C80", VA = "0x1871C5A80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MIJBFIBBBEO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum MNAAGEJJDMO
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Cancelled,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public string EIGCPAKBOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public string NPGBIEDNJGL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MNAAGEJJDMO JFPHGHKAELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(MNAAGEJJDMO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GJNPNOICMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x20536C0", Offset = "0x20528C0", VA = "0x1820536C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IHOMJHGHLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x17539A0", Offset = "0x1752BA0", VA = "0x1817539A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x71C4EE0", Offset = "0x71C40E0", VA = "0x1871C4EE0")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static MIJBFIBBBEO KDJBHGKCOBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x71C4E50", Offset = "0x71C4050", VA = "0x1871C4E50")]
	[Obsolete("Use RecNet.Store.SkuPurchaseResult instead")]
	public static MIJBFIBBBEO FIFDPDCDADE([Optional] string LHOIMMPGJCO, [Optional] string HNMFIHELCAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MIJBFIBBBEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface APDPHCGIHLB
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	string ANCDJKHINJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string INPCOEOHOHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface OCCFAGNEHMG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NDCOIAMFCNJ<GCHOBDJLIIJ> FDNPOJJHADK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	NDCOIAMFCNJ<CNMKEBNFHGG> DOJJIOPIPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGDBEFAKGIL();

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<PKBHKCNDNHN> BEJHGPLPJCO(bool HNOIIDKCNBM, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<CENDJIAFFND> DCBMNLEFFDM(bool BAJCKLHDKEI = false, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<DIOJMAKAIED> DBPAMOCKGJL([Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<PKBHKCNDNHN> NEKIMIFABJF(bool BAJCKLHDKEI = false, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<PKBHKCNDNHN> EGPDPMBFJHO([Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<APDPHCGIHLB> HIKPMEBNAGC(string JPLLHKJOCLN, string CMCCFJKMNOC, string MJMPDLMIHPD, string? ELDLBFOGMBJ, float LKDJACNIAAI, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<PKBHKCNDNHN> KAONJBFBDCC(long GKDHCJGNLGL, decimal DHKHHNMEALA, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task ALDDKBENJAH(string ANPKGOFDOAE, string LELDJMLADPI, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task OOKOLEFNJGB(long BKGDCHGAMLH, string LELDJMLADPI, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<string> NFGBBEGNHFM(long BKGDCHGAMLH, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<string> NJACDPELBDF(string JPLLHKJOCLN, string OFDPIGBEHEH, [Optional] string? JAFKPMJIGFL, [Optional] string? PHAMKINPOJJ, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task<OJPBHMKKBOM?>? EJDBEEPPIBM(string OFDPIGBEHEH, [Optional] GIALDOHEDFG? BIIDBHHNIOM, [Optional] string? PBDIKCHLCBG, bool OONBBLPOPFI = false, [Optional] string? CMCCFJKMNOC, [Optional] string? JLKFIDPFEDG, [Optional] string? JPLLHKJOCLN, [Optional] bool? CIGDGEKDGPI, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<OJPBHMKKBOM> ECFGGEINHLC(string DEBMEFDDEDD, [Optional] GIALDOHEDFG? BIIDBHHNIOM, bool OONBBLPOPFI = false, [Optional] string? JLKFIDPFEDG, [Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CKLKLCIJBJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private string GNGHLKDADMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private string PINMEAPBIFM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public string NCMKENPDLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string EKHCIDKKPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string AFEPHCLLCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string JONPOLPOLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int? LMDKPGIOHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int? GIGMFCKHLLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x71BEF60", Offset = "0x71BE160", VA = "0x1871BEF60")]
	public CKLKLCIJBJM(string AKJHBBPEAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x71BEF30", Offset = "0x71BE130", VA = "0x1871BEF30")]
	public void GHOKGCINMCA(string NNAEDLPADFP = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x71BEE30", Offset = "0x71BE030", VA = "0x1871BEE30")]
	private void AKPFHBNEOPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LCCPONHOJND
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	OHHLIEHJBIN EJABNMKENON
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BDPMMDJFFLC> NILCEODICOC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<GLDBEEEFCFO> DCACJKOAFCJ;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<GLDBEEEFCFO> PNJLNHEEEIB(bool LHLMOFLLJNF = false, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DHILAJPHKOE([Out] GLDBEEEFCFO LFIHNHECHJI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class BDMNEPEBCAF
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x71BE9D0", Offset = "0x71BDBD0", VA = "0x1871BE9D0")]
	public static bool JLKEHPDFEHD(this LCCPONHOJND ICMANGEDBDE, [Out] BDPMMDJFFLC KMCKJMIFNEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x71BEAB0", Offset = "0x71BDCB0", VA = "0x1871BEAB0")]
	public static bool LELDCLLJMHP(this LCCPONHOJND ICMANGEDBDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KLMIHAMBMDP
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BOAKAEHMOLN(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NIEDINFNCDH(int BHCJLLOBCFA, [Out] GGOFPOECOOD? EPCCHCFNMNH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GGOFPOECOOD
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int CADMOHFOLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	string? BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string? BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool? IKKKKAFPBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	string? KIGCMGCDCBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	string? CCCNGINDAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	HAJPAMKIGLI? APLLAAOEAMN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool DFHCLIBEOIL(string IALGFEKIPFM, [Out] AKFKADHIAOM? EPCCHCFNMNH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AKFKADHIAOM
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string? CPEKBNDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	string? FHFPDDDDGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	string? ILDCHFJHOIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	IReadOnlyList<IEFPOANEIJB>? PKIMPMKNEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	HAJPAMKIGLI? APLLAAOEAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	long? JJCBIEDAIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IEFPOANEIJB
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	string FHFPDDDDGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	string AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	OLOHJDGGDIJ HKMBDPMMEFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HAJPAMKIGLI
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	string FHFPDDDDGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	string? EOLNBOPFKPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DBAGFLHDBHH]
public class AJGGAKGCEDE
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int EAJOLKMOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public List<MNMIDIFIAMI> ALHIAEHPHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Dictionary<string, string> LEPOIMNHCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x71BE230", Offset = "0x71BD430", VA = "0x1871BE230")]
	public AJGGAKGCEDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DBAGFLHDBHH]
public class MNMIDIFIAMI
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int CADMOHFOLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string KIGCMGCDCBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string CCCNGINDAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool? IKKKKAFPBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xD345B0", Offset = "0xD337B0", VA = "0x180D345B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xD345C0", Offset = "0xD337C0", VA = "0x180D345C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public JMIOMBANECN APLLAAOEAMN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Dictionary<string, EKANEEMFKAL> BBJIEIFNINI
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x71C4F40", Offset = "0x71C4140", VA = "0x1871C4F40")]
	public MNMIDIFIAMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DBAGFLHDBHH]
public class JMIOMBANECN
{
	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public string FHFPDDDDGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string EOLNBOPFKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public JMIOMBANECN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DBAGFLHDBHH]
public class EKANEEMFKAL
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string CPEKBNDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public string FHFPDDDDGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string ILDCHFJHOIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public List<OMOJBCFCOMN> PKIMPMKNEEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public JMIOMBANECN APLLAAOEAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public long JJCBIEDAIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9FD8C0", Offset = "0x9FCAC0", VA = "0x1809FD8C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x71C0780", Offset = "0x71BF980", VA = "0x1871C0780")]
	public EKANEEMFKAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum OLOHJDGGDIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	DismissDialog,
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	CloseWatch,
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	GoToStore,
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	GoToCreate,
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	GoToDayPass,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	PositiveEvent,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	NegativeEvent,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	CancelEvent
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DBAGFLHDBHH]
public class OMOJBCFCOMN
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string FHFPDDDDGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public OLOHJDGGDIJ HKMBDPMMEFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(OLOHJDGGDIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public OMOJBCFCOMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct BBMLOKHEAMB : IEquatable<BBMLOKHEAMB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly bool FAAKPCGHFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DateTime NMLKJALIGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly bool GPHLBKGACNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly OHGJBEJJKAO? PJAEOEIPAFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string NDNCLGLPMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly int? PNEFBODMGIE;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static BBMLOKHEAMB IEAMPDJOKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x27619B0", Offset = "0x2760BB0", VA = "0x1827619B0")]
		get
		{
			return default(BBMLOKHEAMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x71BE990", Offset = "0x71BDB90", VA = "0x1871BE990")]
	public BBMLOKHEAMB(DateTime PEALHJBCKPN, bool BPGPENDNKNK, OHGJBEJJKAO? FCBJLGEKDNE, string LAECIIPJCAJ, int? PNKMMPFDFJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x71BE780", Offset = "0x71BD980", VA = "0x1871BE780")]
	public BDPMMDJFFLC KFPLNEJEIBD(OHHLIEHJBIN KMNNIFIEFOE)
	{
		return default(BDPMMDJFFLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x71BE840", Offset = "0x71BDA40", VA = "0x1871BE840")]
	private static BDPMMDJFFLC NKHCJILCMIA(OHHLIEHJBIN KMNNIFIEFOE, DateTime PEALHJBCKPN)
	{
		return default(BDPMMDJFFLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x71BE4C0", Offset = "0x71BD6C0", VA = "0x1871BE4C0", Slot = "4")]
	public bool Equals(BBMLOKHEAMB FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x71BE620", Offset = "0x71BD820", VA = "0x1871BE620", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x71BE6D0", Offset = "0x71BD8D0", VA = "0x1871BE6D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x71BE810", Offset = "0x71BDA10", VA = "0x1871BE810")]
	public static bool NDBPPCEOMJH(BBMLOKHEAMB MHEJPNNFCGC, BBMLOKHEAMB BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x71BE480", Offset = "0x71BD680", VA = "0x1871BE480")]
	public static bool EFJOOJHLAGB(BBMLOKHEAMB MHEJPNNFCGC, BBMLOKHEAMB BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x71BE8C0", Offset = "0x71BDAC0", VA = "0x1871BE8C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct GLDBEEEFCFO : IEquatable<GLDBEEEFCFO>
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly GLDBEEEFCFO IEAMPDJOKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly bool KJALJJOFOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly BDPMMDJFFLC JGBIOACINLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly BBMLOKHEAMB OIHMKJNADBF;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x71C27E0", Offset = "0x71C19E0", VA = "0x1871C27E0")]
	public GLDBEEEFCFO(BDPMMDJFFLC KMCKJMIFNEH, BBMLOKHEAMB FCEEFCBPJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x71C2470", Offset = "0x71C1670", VA = "0x1871C2470", Slot = "4")]
	public bool Equals(GLDBEEEFCFO FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x71C2340", Offset = "0x71C1540", VA = "0x1871C2340", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x71C2520", Offset = "0x71C1720", VA = "0x1871C2520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x71C25E0", Offset = "0x71C17E0", VA = "0x1871C25E0")]
	public static bool NDBPPCEOMJH(GLDBEEEFCFO MHEJPNNFCGC, GLDBEEEFCFO BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x71C2220", Offset = "0x71C1420", VA = "0x1871C2220")]
	public static bool EFJOOJHLAGB(GLDBEEEFCFO MHEJPNNFCGC, GLDBEEEFCFO BGMAPCGDHFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x71C26F0", Offset = "0x71C18F0", VA = "0x1871C26F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum BDPMMDJFFLC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	Expired,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	Active
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JHMPPAFDBCI : OHHLIEHJBIN
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public const string KGEEKOOOPGB = "ServerTime";

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly Stopwatch ANFFLGOAONJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static DateTimeOffset? LOOFPPMKAPP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly JHMPPAFDBCI BJFPHBLMMJE;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public static OHHLIEHJBIN NDDGJHHDBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x71C3460", Offset = "0x71C2660", VA = "0x1871C3460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal static JHMPPAFDBCI MMGFIPILPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x71C3570", Offset = "0x71C2770", VA = "0x1871C3570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static DateTimeOffset CIJGLJJIJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x71C3300", Offset = "0x71C2500", VA = "0x1871C3300")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static DateTime CMEINEOAGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x71C35C0", Offset = "0x71C27C0", VA = "0x1871C35C0")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public DateTime BNEIPCBAKHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x71C34B0", Offset = "0x71C26B0", VA = "0x1871C34B0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DateTimeOffset NMLHBNBLIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x71C3650", Offset = "0x71C2850", VA = "0x1871C3650", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	private JHMPPAFDBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x71C30E0", Offset = "0x71C22E0", VA = "0x1871C30E0")]
	internal static void AOKCAMAPFFL(DateTime? BMLGFOBFGAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum GNGDKPIJAHF
{
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Front,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	Back
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum NEDBEKKFPGE
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AnimatedPuppet,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Imposter
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DBAGFLHDBHH]
public class ECGLABHDGNK : CMDPBLNFPIL, JMGCHNCFNHB, EDDGMJLBELL, JODOMHIHKJK, JKOFKAODANP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private struct KFBFEBOMDMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public ECGLABHDGNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x71C3800", Offset = "0x71C2A00", VA = "0x1871C3800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x71C3BA0", Offset = "0x71C2DA0", VA = "0x1871C3BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[IgnoreDataMember]
	public static GNFHNBGBBHA CMDBAHKPCHP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Guid CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int MDIMNOHNLCE
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int MNLAMBOMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xD6AC00", Offset = "0xD69E00", VA = "0x180D6AC00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public LNMPHCNNDCM LLKHKPGDPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7C0", Offset = "0xA0D9C0", VA = "0x180A0E7C0", Slot = "44")]
		[CompilerGenerated]
		get
		{
			return default(LNMPHCNNDCM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1495150", Offset = "0x1494350", VA = "0x181495150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool OGPAKKOOKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xC1FDC0", Offset = "0xC1EFC0", VA = "0x180C1FDC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xCF9F40", Offset = "0xCF9140", VA = "0x180CF9F40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool BLHPOCHMOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xD80DF0", Offset = "0xD7FFF0", VA = "0x180D80DF0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xD80720", Offset = "0xD7F920", VA = "0x180D80720")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool CLJAOINMMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1E81890", Offset = "0x1E80A90", VA = "0x181E81890", Slot = "41")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1E81500", Offset = "0x1E80700", VA = "0x181E81500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int? BJEPJEHLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x71C0620", Offset = "0x71BF820", VA = "0x1871C0620", Slot = "43")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x71C0470", Offset = "0x71BF670", VA = "0x1871C0470", Slot = "14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string LHLNHFEOMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string NMANNNHCAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string JNOKIOJEPMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xE74AC0", Offset = "0xE73CC0", VA = "0x180E74AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public DateTime IKGJDBNACMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9F3280", Offset = "0x9F2480", VA = "0x1809F3280", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xE75370", Offset = "0xE74570", VA = "0x180E75370")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public GNGDKPIJAHF IACBPBEOODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xDBA170", Offset = "0xDB9370", VA = "0x180DBA170", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(GNGDKPIJAHF);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xEA27B0", Offset = "0xEA19B0", VA = "0x180EA27B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string FHMEOHHPFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9F94E0", Offset = "0x9F86E0", VA = "0x1809F94E0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F95B0", Offset = "0x9F87B0", VA = "0x1809F95B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int PCHEFMJHINA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC585F0", Offset = "0xC577F0", VA = "0x180C585F0", Slot = "42")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC588F0", Offset = "0xC57AF0", VA = "0x180C588F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public IReadOnlyList<DAKGJBDKPBO> NGHMEGMEHPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xBE1AD0", Offset = "0xBE0CD0", VA = "0x180BE1AD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1316000", Offset = "0x1315200", VA = "0x181316000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public IReadOnlyList<LNHMIKPMCAH> JBLICDCJNED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xBE1AD0", Offset = "0xBE0CD0", VA = "0x180BE1AD0", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public OBNDCIGENOG OCDLMMNNGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9F9400", Offset = "0x9F8600", VA = "0x1809F9400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F94C0", Offset = "0x9F86C0", VA = "0x1809F94C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public string JIGDFHCEJHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x71C0450", Offset = "0x71BF650", VA = "0x1871C0450", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public GGLHPEALCFJ MBNHPGJCJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xBE2300", Offset = "0xBE1500", VA = "0x180BE2300", Slot = "24")]
		get
		{
			return default(GGLHPEALCFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public string CCDGCEMKGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x71C0450", Offset = "0x71BF650", VA = "0x1871C0450", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public string GKPIDFDNOIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool FBCKILNFHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "29")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public NKIINHMBKEE EIGCEEILHNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xF7C570", Offset = "0xF7B770", VA = "0x180F7C570", Slot = "30")]
		get
		{
			return default(NKIINHMBKEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string GPKEBBMOJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "31")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public MDBCGJONPIJ? APFFBAOJGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x71C0480", Offset = "0x71BF680", VA = "0x1871C0480", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public JNLJMCFKGBP PEDDJMMBPDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xBE2300", Offset = "0xBE1500", VA = "0x180BE2300", Slot = "33")]
		get
		{
			return default(JNLJMCFKGBP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool LIANLPCBJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "34")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public ECGLABHDGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0xF98910", Offset = "0xF97B10", VA = "0x180F98910")]
	public ECGLABHDGNK([Optional] Guid NFCMKJPGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x71C02A0", Offset = "0x71BF4A0", VA = "0x1871C02A0", Slot = "35")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x71C04D0", Offset = "0x71BF6D0", VA = "0x1871C04D0", Slot = "36")]
	[AsyncStateMachine(typeof(KFBFEBOMDMB))]
	public Task KPBJEKHPINM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x71C05A0", Offset = "0x71BF7A0", VA = "0x1871C05A0")]
	public ECGLABHDGNK MAHOJFGCJHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DBAGFLHDBHH]
public class EAELIDMEPCJ : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int MNLAMBOMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int? BJEPJEHLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xEDE6D0", Offset = "0xEDD8D0", VA = "0x180EDE6D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xEDE700", Offset = "0xEDD900", VA = "0x180EDE700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public string LHLNHFEOMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public LNMPHCNNDCM LLKHKPGDPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0")]
		[CompilerGenerated]
		get
		{
			return default(LNMPHCNNDCM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xD6AC00", Offset = "0xD69E00", VA = "0x180D6AC00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public GNGDKPIJAHF? IACBPBEOODJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xCBAC40", Offset = "0xCB9E40", VA = "0x180CBAC40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xCBAC90", Offset = "0xCB9E90", VA = "0x180CBAC90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public EAELIDMEPCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DBAGFLHDBHH]
public class BBDBEPFNIFH : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int MDIMNOHNLCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int? BJEPJEHLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xEDE690", Offset = "0xEDD890", VA = "0x180EDE690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xEE7570", Offset = "0xEE6770", VA = "0x180EE7570")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string NMANNNHCAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string LHLNHFEOMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public BBDBEPFNIFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DBAGFLHDBHH]
public class AECGBCDNLBD : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int? BJEPJEHLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public string LHLNHFEOMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public AECGBCDNLBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct PEKEMAEELIM
{
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static int GMKBLDBFAJF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static int CJMINEIEBGE;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int NLIDOCIPBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int NPHMJKECDGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x71C7310", Offset = "0x71C6510", VA = "0x1871C7310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public static PEKEMAEELIM EMOEMPAFHHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x71C72C0", Offset = "0x71C64C0", VA = "0x1871C72C0")]
		get
		{
			return default(PEKEMAEELIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x71C73B0", Offset = "0x71C65B0", VA = "0x1871C73B0")]
	public PEKEMAEELIM(int HBGGMKIOAPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DBAGFLHDBHH]
public class NCJNPEJEJIH : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int MAMJILCMDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int? GEAKAJJPHCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xEDE690", Offset = "0xEDD890", VA = "0x180EDE690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xEE7570", Offset = "0xEE6770", VA = "0x180EE7570")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string? FIKKCGNKHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x71C51A0", Offset = "0x71C43A0", VA = "0x1871C51A0")]
	public NCJNPEJEJIH(int PMMDPJNEPEE, int? FHONBKFFHOC, string? BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public NCJNPEJEJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DBAGFLHDBHH]
public class IAEJBHFKFMM : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public LMPCMIDLNCK.MFBAPPPEMHM KHAJJAJFDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(LMPCMIDLNCK.MFBAPPPEMHM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string FNBONJEAEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public int? ABOLNHHPINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xCBAC80", Offset = "0xCB9E80", VA = "0x180CBAC80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public IAEJBHFKFMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LNHMIKPMCAH
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	long HFCGBONFAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	Guid CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	Guid FMGNEFGHELO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	string ELKAEJDEDME
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	string HPNAJKCGHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	int AOFKIEDHDCL
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string GMJKJPDFILF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string HOHJKOPHEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string BBEBCOGFLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	string AJKKNFJNPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	int PCHEFMJHINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DBAGFLHDBHH]
public class DAKGJBDKPBO : LNHMIKPMCAH, EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public long HFCGBONFAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public Guid CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xDD6D20", Offset = "0xDD5F20", VA = "0x180DD6D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Guid FMGNEFGHELO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x12A6210", Offset = "0x12A5410", VA = "0x1812A6210", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x12A62F0", Offset = "0x12A54F0", VA = "0x1812A62F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9FD8C0", Offset = "0x9FCAC0", VA = "0x1809FD8C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public string ELKAEJDEDME
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public string HPNAJKCGHDD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int AOFKIEDHDCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xD34D90", Offset = "0xD33F90", VA = "0x180D34D90", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xE964A0", Offset = "0xE956A0", VA = "0x180E964A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public string GMJKJPDFILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string HOHJKOPHEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public string BBEBCOGFLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string AJKKNFJNPHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9F3280", Offset = "0x9F2480", VA = "0x1809F3280", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9F3310", Offset = "0x9F2510", VA = "0x1809F3310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int PCHEFMJHINA
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xDBA170", Offset = "0xDB9370", VA = "0x180DBA170", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xEA27B0", Offset = "0xEA19B0", VA = "0x180EA27B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "15")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DAKGJBDKPBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Flags]
public enum ODLGNEFCEDE
{
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	Shirt = 1,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum ECHPHHPENOM
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	SearchScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	HotScoreDescending,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Newest,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Oldest,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	PriceAscending,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	PriceDescending,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	FeaturedFirst
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class LJJLKEDDGKF
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x71C4330", Offset = "0x71C3530", VA = "0x1871C4330")]
	public static int? APDLHGEMFEC(ODLGNEFCEDE? EPFBLIKIEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x71C43C0", Offset = "0x71C35C0", VA = "0x1871C43C0")]
	public static int? JGBMDHJCBMA(ECHPHHPENOM? HIFCIFMELHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[DBAGFLHDBHH]
public class BPBFPJLBBIK : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int? MNLAMBOMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCBAC80", Offset = "0xCB9E80", VA = "0x180CBAC80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public LNMPHCNNDCM? LLKHKPGDPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9F2520", Offset = "0x9F1720", VA = "0x1809F2520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public BPBFPJLBBIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DBAGFLHDBHH]
public class MJJEAILKKIC : OCPIHIKNAGF, EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public Guid CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public byte AOJFILOCGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MJJEAILKKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class JAKBMOAOLOP
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x71C2D30", Offset = "0x71C1F30", VA = "0x1871C2D30")]
	public static HHNPNGAMMKB CEOMFCPDELP(this MJJEAILKKIC CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CMDPBLNFPIL
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	Guid CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	int MDIMNOHNLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	int MNLAMBOMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	LNMPHCNNDCM LLKHKPGDPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	bool OGPAKKOOKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	bool BLHPOCHMOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	bool CLJAOINMMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	int? BJEPJEHLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	string LHLNHFEOMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	string NMANNNHCAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	string JNOKIOJEPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	DateTime IKGJDBNACMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	GNGDKPIJAHF IACBPBEOODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	string FHMEOHHPFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	int PCHEFMJHINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	string JIGDFHCEJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x71BF590", Offset = "0x71BE790", VA = "0x1871BF590", Slot = "19")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface JKOFKAODANP
{
	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	IReadOnlyList<LNHMIKPMCAH> JBLICDCJNED
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	Guid CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	int MDIMNOHNLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	bool CLJAOINMMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	int PCHEFMJHINA
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	int? BJEPJEHLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	LNMPHCNNDCM LLKHKPGDPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class CPILGLKBAMK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct MBLMBJLCELI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<JODOMHIHKJK> list;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x71C4A90", Offset = "0x71C3C90", VA = "0x1871C4A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x71C4D30", Offset = "0x71C3F30", VA = "0x1871C4D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x71BF780", Offset = "0x71BE980", VA = "0x1871BF780")]
	public static bool MFGKBJDAOEP(this IEnumerable<EDDGMJLBELL> MEHAOGGFJIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x71BF6B0", Offset = "0x71BE8B0", VA = "0x1871BF6B0")]
	[AsyncStateMachine(typeof(MBLMBJLCELI))]
	public static Task BKAEOBEKAHE(this IEnumerable<JODOMHIHKJK> MEHAOGGFJIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct ELAGIFLJMJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public readonly string DOGMAOHHFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public readonly string ACJEGOOIMMO;

	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public static readonly ELAGIFLJMJI AIIEKMBHIHD;

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0xAE1FD0", Offset = "0xAE11D0", VA = "0x180AE1FD0")]
	public ELAGIFLJMJI(string PLGAHLOHPMG, string BDJMEJKDJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0xEFE5C0", Offset = "0xEFD7C0", VA = "0x180EFE5C0")]
	public bool EKHAGIJCEHN(ELAGIFLJMJI FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x71C0890", Offset = "0x71BFA90", VA = "0x1871C0890", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x71C0960", Offset = "0x71BFB60", VA = "0x1871C0960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x71C09D0", Offset = "0x71BFBD0", VA = "0x1871C09D0")]
	public static bool NDBPPCEOMJH(ELAGIFLJMJI MHEJPNNFCGC, ELAGIFLJMJI BGMAPCGDHFK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x71C0810", Offset = "0x71BFA10", VA = "0x1871C0810")]
	public static bool EFJOOJHLAGB(ELAGIFLJMJI MHEJPNNFCGC, ELAGIFLJMJI BGMAPCGDHFK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface ICONAKFLFKD
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	CKLKLCIJBJM EAJOLKMOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	string JIFDBDKOPOD
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string EBCEMELBELN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	long LOMKNFGKJHI
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	string KIEBDFMLNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	string FJCBKGPFLJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	string PMMOFHCOHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	string GPCOOBIGJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[DBAGFLHDBHH]
public class KFGOEOHPOIO : PNGDEELGAML
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string IAOLECBBMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public ONEMKEMDJGJ BCKCGMLFDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(ONEMKEMDJGJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public OHHDPLEPIAI EBOACDCGAFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630")]
		[CompilerGenerated]
		get
		{
			return default(OHHDPLEPIAI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xF275F0", Offset = "0xF267F0", VA = "0x180F275F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public COAIGDJGJHN CONPFNAJOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		[CompilerGenerated]
		get
		{
			return default(COAIGDJGJHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	[DataMember(Name = "Header")]
	public string? OEHFIPBDIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string? CPEKBNDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public string? OOOHIFKEJMD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public List<string> MODNMABDPGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public List<FINOGJPFLBL> PKIMPMKNEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x71C3F40", Offset = "0x71C3140", VA = "0x1871C3F40", Slot = "5")]
	public override void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x71C3F50", Offset = "0x71C3150", VA = "0x1871C3F50")]
	public KFGOEOHPOIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public enum GLHCDNECPOI
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Url,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	AccountId,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	EventId,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	RoomName,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Storefront,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	[Obsolete("6/4/21: This was only ever used for an announcement for Shawn's referral event, which is not happening again. Removing as part of a StackUI cleanup")]
	ActionCode,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Item,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	AuthorizedRecNetUrl,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Close
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public enum ONEMKEMDJGJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	Vertical,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	Horizontal
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum OHHDPLEPIAI
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	Small,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	Medium,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	Large
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum COAIGDJGJHN
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Before,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Overlay,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	After
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
[DBAGFLHDBHH]
public class FINOGJPFLBL : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public GLHCDNECPOI HNCFKKFIOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(GLHCDNECPOI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public string? OKNPIIMAILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	[DataMember(Name = "LinkParameter")]
	public string? MNKKMNHCCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public string? OJNFKAIBLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FINOGJPFLBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class PNGDEELGAML : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	[IgnoreDataMember]
	public string? PGKILOKLCHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void EJBLMMEIOCH();

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x71C7800", Offset = "0x71C6A00", VA = "0x1871C7800")]
	protected PNGDEELGAML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[DBAGFLHDBHH]
public class PAMOIDCKGAC : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public string? LJNIMPGGIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public PAMOIDCKGAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[DBAGFLHDBHH]
public class NMENKCBPELF : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	internal static Func<string, KFGOEOHPOIO>? LFMJFNHFNMG;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal static Func<string, CLMHAJOGIDJ>? OOCBILCFAKD;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public string? LJNIMPGGIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public string? NBMNBNEHEIK
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool KJILPJCDHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public OHGJBEJJKAO HECKAKIFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630")]
		[CompilerGenerated]
		get
		{
			return default(OHGJBEJJKAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xF275F0", Offset = "0xF267F0", VA = "0x180F275F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public IBKBPFELIAH OIAEJNLCDIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		[CompilerGenerated]
		get
		{
			return default(IBKBPFELIAH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public int AFKEOEFICMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xC73E60", Offset = "0xC73060", VA = "0x180C73E60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x13D2D70", Offset = "0x13D1F70", VA = "0x1813D2D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public DateTime HANDDEIAAJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x9F24C0", Offset = "0x9F16C0", VA = "0x1809F24C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[DataMember(Name = "IsRead")]
	internal bool GHMHDMFABON
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xD8A840", Offset = "0xD89A40", VA = "0x180D8A840")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xD8A860", Offset = "0xD89A60", VA = "0x180D8A860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	[IgnoreDataMember]
	public bool DHDBPKGBLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xD8A850", Offset = "0xD89A50", VA = "0x180D8A850")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xD8A870", Offset = "0xD89A70", VA = "0x180D8A870")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public BAFFGFBICDD EHOMFEJJNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7C0", Offset = "0xA0D9C0", VA = "0x180A0E7C0")]
		[CompilerGenerated]
		get
		{
			return default(BAFFGFBICDD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x1495150", Offset = "0x1494350", VA = "0x181495150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public BNGAHLAKDIN EGHKCBIICAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xBFB9D0", Offset = "0xBFABD0", VA = "0x180BFB9D0")]
		[CompilerGenerated]
		get
		{
			return default(BNGAHLAKDIN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xE21FA0", Offset = "0xE211A0", VA = "0x180E21FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	internal string? KFAPGKMNLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	[IgnoreDataMember]
	public KFGOEOHPOIO? FMBHFDNCDIG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x71C58E0", Offset = "0x71C4AE0", VA = "0x1871C58E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	[IgnoreDataMember]
	public CLMHAJOGIDJ? JOCJKBHIIEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x71C5970", Offset = "0x71C4B70", VA = "0x1871C5970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	[IgnoreDataMember]
	public PNGDEELGAML? BMAILHAOHCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x71C55C0", Offset = "0x71C47C0", VA = "0x1871C55C0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0xA1B6E0", Offset = "0xA1A8E0", VA = "0x180A1B6E0")]
	public NMENKCBPELF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DBAGFLHDBHH]
public class FOJMFJIEIOM : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public OJGLJCPEDFD NFPKBFMCBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(OJGLJCPEDFD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public string JGOGKBFHFMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public int JOKAFKGNKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x71C1C00", Offset = "0x71C0E00", VA = "0x1871C1C00")]
	public FOJMFJIEIOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[DBAGFLHDBHH]
public class CLMHAJOGIDJ : PNGDEELGAML
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string GGKCIIOKDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public string? BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public MLLMOKDKMEK DPLFFABLIAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		[CompilerGenerated]
		get
		{
			return default(MLLMOKDKMEK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	[DataMember(Name = "all_conditions_required")]
	public bool FJPCHIIOCGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x15AC340", Offset = "0x15AB540", VA = "0x1815AC340")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xF1D270", Offset = "0xF1C470", VA = "0x180F1D270")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public List<FOJMFJIEIOM> HAODJLKFCJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x71BF4C0", Offset = "0x71BE6C0", VA = "0x1871BF4C0", Slot = "5")]
	public override void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x71BF4D0", Offset = "0x71BE6D0", VA = "0x1871BF4D0")]
	public CLMHAJOGIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public enum BNGAHLAKDIN
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	ContentBlock,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	JustInTimeTutorialTrigger
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public enum BAFFGFBICDD
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Announcements,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	JustInTimeTutorials
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public enum MLLMOKDKMEK
{
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	MakerPenButtonHighlight = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	PlaceControlTutorial = 3
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public enum OJGLJCPEDFD
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	EnteredRoom = 0,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	TimeInRoom = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	ObjectInteractionRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	ObjectPlaceStartedRoom = 4
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface KMIBFJKMIEO
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	bool NFHEHLPFMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	NDCOIAMFCNJ<NMENKCBPELF> DKEJOGHEFAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	NDCOIAMFCNJ<string> CEEEADELCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	NDCOIAMFCNJ<NMENKCBPELF> PFMLLKLJGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	NDCOIAMFCNJ<NMENKCBPELF> KKCNGBDPAPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<NMENKCBPELF> JOLMANFBKNF(BAFFGFBICDD AHONJNIOAOK);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<NMENKCBPELF> MKOLMCAOLOD(BAFFGFBICDD AHONJNIOAOK);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NMENKCBPELF JKBLDLFBKHE(BAFFGFBICDD AHONJNIOAOK, string JAEDOMCLCCD);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NMENKCBPELF IEJKLCPFAAE(BAFFGFBICDD AHONJNIOAOK);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CMMCMAGCMPC(BAFFGFBICDD AHONJNIOAOK);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	int CEOEDEOCNEC(BAFFGFBICDD AHONJNIOAOK);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task EKKFJPFEFEC();

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task CKPPHEPPEDP(NMENKCBPELF BDAAPBJEHGD);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface OLALNMLGOHH
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	JNBIKMJHLGB OHJMDLHJHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	int CGJOIAKLMEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool IGPHJONGFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool JACGIPOKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	bool MBCNPCDAJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool GKBOINEMKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool MHPGMGNDGAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool IMCMNCFOJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	bool BKFBLNDFEPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action LMEOOCFJAAA;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	CMEBMOPMCFP<EGAKMNNIDNK> HBEHBHDNGOO(int JKLFDKBOKPI);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IJPNCIBDOFL EGDBIFOEBAI(DateTime CJNDGAGCDFP);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IJPNCIBDOFL DFGBMEKNIHK(string FPDINLCIJOK);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task ILDDBLOMMGA([Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum BMLGADNKDFN
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Memory,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Multiplayer
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DKJKKIKMKJH
{
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x71BFE00", Offset = "0x71BF000", VA = "0x1871BFE00")]
	public static string KPEDIOHHFOP(this BMLGADNKDFN BKMIPPHHKEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public interface OKJDEPLLPFM
{
	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<NMENKCBPELF>> CELLJDLKDJM(BAFFGFBICDD AHONJNIOAOK);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task CKPPHEPPEDP(string JAEDOMCLCCD);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface MFIGDAONILM
{
	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CJHBIAJJPIN> AABPDLCMJAE();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface FJMKJFEDIHK
{
	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CMEBMOPMCFP<List<NECKHIMNGEO>> PENMDKADBOF();

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CMEBMOPMCFP<List<NECKHIMNGEO>> HODBAMPGPFH();

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<NECKHIMNGEO>> LNMPGOPFKMI([Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CMEBMOPMCFP<List<NECKHIMNGEO>> NFGFMOCKCJM(List<PMLAJJBBALO> AHKPNOKLHIF);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CMEBMOPMCFP<List<NECKHIMNGEO>> IPGNNHHFMDG(List<PMLAJJBBALO> AHKPNOKLHIF);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface GLLIIHCJKOA
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	List<GHKJMIKCPFE> ENPGCOCAFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<MBFNHHPFPBC> LBDPKBKGFGD;

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IJPNCIBDOFL HGLECBKNBFD(GHKJMIKCPFE MDODNKHHNEN);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	[Obsolete("Alternate gift contexts are being phased out. Use LocalRequestGiftPackage(GiftContext context, string message) instead")]
	CMEBMOPMCFP<GHKJMIKCPFE> KIADKNNHGCH(BAACIDJNIFD OPJOIGJBJKN, BAACIDJNIFD? NBCCPMLNDPD, bool CEENLNOJHLJ, string BDAAPBJEHGD);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CMEBMOPMCFP<GHKJMIKCPFE> KIADKNNHGCH(BAACIDJNIFD OPJOIGJBJKN, string BDAAPBJEHGD);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MGPPGJECGEO(GHKJMIKCPFE LGPHIDLGFLK, bool BMNMKBPJNEF = false, bool GEOOEIHCHMB = false, bool EBPHJEAIGIE = true);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CMEBMOPMCFP<List<GHKJMIKCPFE>> AKPNHMKOGOJ();
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface ODMGDJBFMBC
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	string GMBNLPCPCBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	bool APLODJDAGKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IJPNCIBDOFL PAPDGPHNDHM();

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IJPNCIBDOFL HBFJBIHPHEC(string LNILCBKOKNI, string IGBONPLKKBH);

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IJPNCIBDOFL KJMDHNIEAFH(string EFDMEGMJDOD);

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPLOHFHFMKC();

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<JDEFJBLIOPE> KHCDMKKIHFO(string FPDINLCIJOK, string EFDMEGMJDOD, bool DDICIEMPGGP, string ONALBCEDBKK, string MKEFFENDHDH, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task BBGHONPBJNF(int JKLFDKBOKPI, string JAOMDMIPJOD, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task MAFJKODMFNJ(int JKLFDKBOKPI, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task NFMKMJJEPPN([Optional] BMLGADNKDFN? IAINMPFMOBH, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<IReadOnlyList<DBBCJHOFHMN>> ELOIHKJPPBG([Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task KCHPLEGPAOA([Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KNPICNEIIKL
{
	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<FMLDLIGKHIB>> LCFBEDNPLIA([Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<List<HLFDIJPGNLN>> HGAMHKDGBGB([Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface LNIOOEFIELG
{
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ACGNCBPJJLH([Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FMLILAKBEID();
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface BKFMICOMOJN
{
	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event LNJNMAIOHEA? EBKBCHOAFLN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event LNJNMAIOHEA? AJOELFEKEME;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event LNJNMAIOHEA? DBABKKNFFND;

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<AKHNIDFFNPA> DDGFDEABDFH();

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<AKHNIDFFNPA?>? LMNCKDAPGMO(int JKLFDKBOKPI);

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<List<JHOCPCCMMME>> PBIJNDOBCEJ(List<int> IHOLCANINIK);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task<IReadOnlyDictionary<int, AKHNIDFFNPA>> NEGKBOHBCDJ();

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<List<AKHNIDFFNPA?>?>? AIMJLMHPHLG(int JKLFDKBOKPI);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task OLKANCKLDJA(int FIAODFNFKEN);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<OKKKIMFHCLG> KCBCAOOBJPL(AKHNIDFFNPA ANFHEEPDABD);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public delegate void LNJNMAIOHEA(int JKLFDKBOKPI, int FIAODFNFKEN, AKHNIDFFNPA? ANFHEEPDABD);
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface GNFHNBGBBHA : FAFNJCDEAHB, HBBMHOBICDC
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[Flags]
	public enum CJEGDMGOCEG
	{
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		FilterProfanity = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		FilterURL = 2
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	string GLGKLPBJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	PFPLJFNADEF GOJGJIFMOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	OHGJBEJJKAO HECKAKIFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	string NDNCLGLPMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	byte NPHIIMJMGFK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	int DEHLLHBGDBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	int PPDAPLHMFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	bool EGGKIEAMBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	bool KDLMKKLOAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	bool CGMDKBHIFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	bool HCLGEDBPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	bool MNKFAKIHBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	bool KLEGKDJHLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	bool CMCAPEFHEAN
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CMEBMOPMCFP<string> NFCDPCMJAMD();

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<string> FGDMMLPPHOJ();

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "15")]
	CMEBMOPMCFP<bool> IsPlayerCommunicationRestricted(int JKLFDKBOKPI);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "16")]
	string FDLEGINEBOI(string DGIAFBEDPNJ, bool FNFFDAHLGGJ = true);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task<string> HDJCOHNOCDI(string DGIAFBEDPNJ, bool FNFFDAHLGGJ = true);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	CMEBMOPMCFP<string> MakeRoomNameAdhereToPlatformRequirements(long BENLNHBBIME, string DGIAFBEDPNJ);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool SanitizeDisplayText(string HNNDEGJHCBJ, CJEGDMGOCEG BPNOFDNIPEE = CJEGDMGOCEG.FilterProfanity | CJEGDMGOCEG.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<string> SanitizeDisplayTextAsync(string HNNDEGJHCBJ, CJEGDMGOCEG BPNOFDNIPEE = CJEGDMGOCEG.FilterProfanity | CJEGDMGOCEG.FilterURL, bool PNBKFMFMJCD = false);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool CheckNameForProfanity(string DGIAFBEDPNJ, CJEGDMGOCEG BPNOFDNIPEE = CJEGDMGOCEG.FilterProfanity | CJEGDMGOCEG.FilterURL);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "23")]
	CMEBMOPMCFP<string> GetCommerceSubscriptionAccessToken();
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface PBMDNLFFDBF
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<List<MMDIFLJBPNG>> KLBHIANKOHO([Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface LCMCOJMILPG
{
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BFFINANPKJC(byte[] BDJMEJKDJOJ, byte[] OAGFPNNKPFO);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface NAJBPHGMHGP
{
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CELNJNNKFNB(string KHGJPILIPDI);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface GFDNNHDEGLC
{
	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	NDCOIAMFCNJ<COOPBDILGAD> CJOLHGJHJCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<bool> HOIIIOBHDJP(string EALFDDLKEFJ);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BONFOJLEOLO> CBPNNLIAECI(string EALFDDLKEFJ, string HNDFKNCFFEB);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JBPNDBFIJNF(string EALFDDLKEFJ, IEnumerable<string> IGNLPNJPOGF, int IDMEKEAALMJ = 0);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<DEOBABMLFHH<FilteredTextDTO>>> OMIDKMOMCDF(uint PJMBCGJNAAB, IEnumerable<string> IGNLPNJPOGF);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public interface KKKDGIALHIP
{
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BAAGIBHGKKI([Out] bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JHFJFIGAMEG([Out] bool MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EHFKFCCGGJK([Out] int MLCDCHNOCFI);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public enum KKAEMGDFPBK
{
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	BasedOnBirthday,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	ModerationOverride,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	PendingOverride
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public enum AALCEGBGHHC
{
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Id,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Email,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Phone
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[Flags]
public enum NEFNAGNJGEG
{
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	SheHer = 1,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	HeHim = 2,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	TheyThem = 4,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	ZeHir = 8,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	ZeZir = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	XeXem = 0x20
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[Flags]
public enum ALDEGKMCOPN
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	LGBTQIA = 1,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Transgender = 2,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Bisexual = 4,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Lesbian = 8,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Pansexual = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	Asexual = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Intersex = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Genderqueer = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Nonbinary = 0x100,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Aromantic = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum NOFHFGCDDCK
{
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Daily = 10,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Weekly = 20,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	Monthly = 30,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	Never = 40,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	Yes = 50
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum LJPCCCNEGCP
{
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	BELOW_TEN = 0,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	BETWEEN_TEN_AND_TWELVE = 10,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	TEEN = 13,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	ADULT = 18,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	UNKNOWN = 999
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface EGAKMNNIDNK
{
	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	int OGDCDIANMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	string IFBPEFHMCFK
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	string HCKEGHJGNPF
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	string GNHGJFIMKBM
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	string MJKILIJCJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	string DLHAHHHKIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	string GAILBJOEBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	bool LFCBEICAMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	bool GNGKFCBHOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	NEFNAGNJGEG ODJFHBFHPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	ALDEGKMCOPN DKEIKDOLEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	bool? EBOIEMKBBGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DHKKCGHJGHG(bool GFPMJNFKIJI);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DOFADHIPHPI(bool OHCAOEEPBEG);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface JNBIKMJHLGB : EGAKMNNIDNK
{
	[Cpp2IlInjected.Token(Token = "0x17000106")]
	string JODCCGPFNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	string AFFBGFIPIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	DateTime? OGBBCNCJIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	KKAEMGDFPBK KGMJNOOLDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	int? CDCAJPCOJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	int HENOKBGJGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	bool HALMNACNOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	bool IBALCAGDAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	bool? FCOGHGILKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class JBMOMEHJMIL
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public EGAKMNNIDNK CIBCIDAJCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public AALCEGBGHHC ALIPFLAPAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		[CompilerGenerated]
		get
		{
			return default(AALCEGBGHHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public string JABEOADMOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x6B562B0", Offset = "0x6B554B0", VA = "0x186B562B0")]
	public JBMOMEHJMIL(EGAKMNNIDNK MLBEKKKBNJL, AALCEGBGHHC KMJKHBGEBJH, string HPCDDIEGEIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface GIADMAGGKPK
{
	[Cpp2IlInjected.Token(Token = "0x17000112")]
	int OGDCDIANMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	bool CHAACGNDGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface KJNFKJJLMJG
{
	[Cpp2IlInjected.Token(Token = "0x17000114")]
	int OGDCDIANMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	bool BCDPMCFBCHK
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public interface HPLJGFAAJIL
{
	[Cpp2IlInjected.Token(Token = "0x17000116")]
	int OGDCDIANMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	string FCCIKNNLLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public enum MDBCGJONPIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Outfit,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	HairDye,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	CustomOutfit
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class NECKHIMNGEO
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public MDBCGJONPIJ APFFBAOJGJD
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(MDBCGJONPIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public string GKPIDFDNOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public string PNJKACJMPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public NKIINHMBKEE EIGCEEILHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		[CompilerGenerated]
		get
		{
			return default(NKIINHMBKEE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public string KHOIKHDGFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public int FHCPJEDPBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0xD6AC00", Offset = "0xD69E00", VA = "0x180D6AC00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public bool FBPEIJAGLGL
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xE2D920", Offset = "0xE2CB20", VA = "0x180E2D920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0xE2D500", Offset = "0xE2C700", VA = "0x180E2D500")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public PMLAJJBBALO HHNGEBFCJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x12AEFE0", Offset = "0x12AE1E0", VA = "0x1812AEFE0")]
		[CompilerGenerated]
		get
		{
			return default(PMLAJJBBALO);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x71C5200", Offset = "0x71C4400", VA = "0x1871C5200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public IKJJOJNJAPI LOPFKCONFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x195E810", Offset = "0x195DA10", VA = "0x18195E810")]
		[CompilerGenerated]
		get
		{
			return default(IKJJOJNJAPI);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x52CC810", Offset = "0x52CBA10", VA = "0x1852CC810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public string HLNHGLGIOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x9F94E0", Offset = "0x9F86E0", VA = "0x1809F94E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x9F95B0", Offset = "0x9F87B0", VA = "0x1809F95B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x9F9460", Offset = "0x9F8660", VA = "0x1809F9460")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x672D030", Offset = "0x672C230", VA = "0x18672D030")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x71C5220", Offset = "0x71C4420", VA = "0x1871C5220")]
	internal NECKHIMNGEO(JFGHLJEBKDM EPJHIGDNHBM, IPAKPNEOHDP MEDIAACNIDC, FCFDCMAIFMA KKFHBKHKLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x71C5480", Offset = "0x71C4680", VA = "0x1871C5480")]
	public NECKHIMNGEO(MDBCGJONPIJ CLNPLFDLNCN = MDBCGJONPIJ.Outfit, [Optional] PMLAJJBBALO LEMPOEPOIHP, [Optional] string AOEGJGILOAO, [Optional] string EKMHIOABOHB, NKIINHMBKEE NBMHKFAKKCP = NKIINHMBKEE.Common, [Optional] string BIDPPJMMNKF, int FCGPCABMNKH = 0, bool MJCBIJCMPPJ = false, [Optional] string HBFHEGFGKIJ, [Optional] DateTime? OFDMKGELPHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[DBAGFLHDBHH]
public class JFGHLJEBKDM : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public MDBCGJONPIJ APFFBAOJGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(MDBCGJONPIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	[DataMember(Name = "AvatarItemDesc")]
	public string GEJJNLPMBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public string GKPIDFDNOIL
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public string PNJKACJMPON
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public NKIINHMBKEE EIGCEEILHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x9FD530", Offset = "0x9FC730", VA = "0x1809FD530")]
		[CompilerGenerated]
		get
		{
			return default(NKIINHMBKEE);
		}
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x9FD8D0", Offset = "0x9FCAD0", VA = "0x1809FD8D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public string KHOIKHDGFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public int FHCPJEDPBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xBFB9D0", Offset = "0xBFABD0", VA = "0x180BFB9D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xE21FA0", Offset = "0xE211A0", VA = "0x180E21FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public bool FBPEIJAGLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x169B760", Offset = "0x169A960", VA = "0x18169B760")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x16A0170", Offset = "0x169F370", VA = "0x1816A0170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public string BPOCBFLELCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0xE2D910", Offset = "0xE2CB10", VA = "0x180E2D910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public JFGHLJEBKDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DBAGFLHDBHH]
public sealed class JDAGNILBPPF : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public List<string> CFNMEBFDFOB
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x71C2DA0", Offset = "0x71C1FA0", VA = "0x1871C2DA0")]
	public JDAGNILBPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public JDAGNILBPPF(List<string> AHKPNOKLHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DBAGFLHDBHH]
public class CJHBIAJJPIN : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public JFCHDCMOAPE OMEKABGPKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public NAIOEHMLMNK AMNBFCKFNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CJHBIAJJPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public CJHBIAJJPIN(JFCHDCMOAPE FFMBCHKDOEA, NAIOEHMLMNK BKGONDNCAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public enum FBMHBJCHDJB
{
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum ALIBILEKCEK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	APNS,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	Firebase,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	Mock,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	Braze,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	Rengage
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[DBAGFLHDBHH]
public class JFCHDCMOAPE : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public FBMHBJCHDJB LOKHBGEILOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(FBMHBJCHDJB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public ALIBILEKCEK? KNEBHJLEDIB
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x2E284E0", Offset = "0x2E276E0", VA = "0x182E284E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7053D30", Offset = "0x7052F30", VA = "0x187053D30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	public bool GBDAEPOAHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1D805F0", Offset = "0x1D7F7F0", VA = "0x181D805F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1D805C0", Offset = "0x1D7F7C0", VA = "0x181D805C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x71C30D0", Offset = "0x71C22D0", VA = "0x1871C30D0")]
	public JFCHDCMOAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x71C3040", Offset = "0x71C2240", VA = "0x1871C3040")]
	public JFCHDCMOAPE(FBMHBJCHDJB PALAJGELBAG, ALIBILEKCEK IBJDPGINCCD, bool LJOPIFKOMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[DBAGFLHDBHH]
public class NAIOEHMLMNK : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public string NKALLMPPGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public string LKFDEKILOLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public NAIOEHMLMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public NAIOEHMLMNK(string BFKJMNKOCND, string CLHADNJKHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public enum PFPLJFNADEF
{
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	VR,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	Screen,
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	VRLow,
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	Quest2
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct MBFNHHPFPBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public GHKJMIKCPFE LAFFPKNHNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public bool MFBBOOEDECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public bool BCKBNBNKHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public bool MLCDACKCNJP;
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[DBAGFLHDBHH]
public class GHKJMIKCPFE : JODOMHIHKJK, EDDGMJLBELL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct DMDHBKFNLLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public GHKJMIKCPFE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x71C00B0", Offset = "0x71BF2B0", VA = "0x1871C00B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x71C0240", Offset = "0x71BF440", VA = "0x1871C0240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	internal static Action<GHKJMIKCPFE> CHCOJHDMPIB;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	internal static Func<GHKJMIKCPFE, Task> HDJGALLDKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	[IgnoreDataMember]
	public bool BCHGLIJFEIM;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public long? CCDGCEMKGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public int LCNGJOONIBB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public int? JKMHEDDJEEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xEDE6D0", Offset = "0xEDD8D0", VA = "0x180EDE6D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xEDE700", Offset = "0xEDD900", VA = "0x180EDE700")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public string GPKEBBMOJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public MDBCGJONPIJ? APFFBAOJGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x9FD8C0", Offset = "0x9FCAC0", VA = "0x1809FD8C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	[DataMember(Name = "AvatarItemDesc")]
	public string OCHJFOAMAID
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Guid? CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x71C2060", Offset = "0x71C1260", VA = "0x1871C2060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x71C2150", Offset = "0x71C1350", VA = "0x1871C2150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public string GMMLCKOKBIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public string MDOPMFDLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public CIHMKPKBLFN JLBDCKJMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA17F30", Offset = "0xA17130", VA = "0x180A17F30")]
		[CompilerGenerated]
		get
		{
			return default(CIHMKPKBLFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x132D4E0", Offset = "0x132C6E0", VA = "0x18132D4E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public int GINAAIIGPEP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA17F90", Offset = "0xA17190", VA = "0x180A17F90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x132D590", Offset = "0x132C790", VA = "0x18132D590")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public int PFFOCDMMOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xDBA170", Offset = "0xDB9370", VA = "0x180DBA170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0xEA27B0", Offset = "0xEA19B0", VA = "0x180EA27B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public BAACIDJNIFD LBGMEFAJCDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0xE45440", Offset = "0xE44640", VA = "0x180E45440")]
		[CompilerGenerated]
		get
		{
			return default(BAACIDJNIFD);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x13717E0", Offset = "0x13709E0", VA = "0x1813717E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public NKIINHMBKEE PCEKFHKNCCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0xC18130", Offset = "0xC17330", VA = "0x180C18130")]
		[CompilerGenerated]
		get
		{
			return default(NKIINHMBKEE);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x1344B60", Offset = "0x1343D60", VA = "0x181344B60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	[DataMember(Name = "Message")]
	public string MOCCNCAILIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9460", Offset = "0x9F8660", VA = "0x1809F9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F94A0", Offset = "0x9F86A0", VA = "0x1809F94A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public string LGAFDLPMBDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xBE1AD0", Offset = "0xBE0CD0", VA = "0x180BE1AD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1316000", Offset = "0x1315200", VA = "0x181316000")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool AIHHBGIJJEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xE2DEC0", Offset = "0xE2D0C0", VA = "0x180E2DEC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xE2E1A0", Offset = "0xE2D3A0", VA = "0x180E2E1A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public OHGJBEJJKAO HECKAKIFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xDB9170", Offset = "0xDB8370", VA = "0x180DB9170")]
		[CompilerGenerated]
		get
		{
			return default(OHGJBEJJKAO);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xDB7E90", Offset = "0xDB7090", VA = "0x180DB7E90")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public IBKBPFELIAH ILFIPEOBPHL
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F9510", Offset = "0x9F8710", VA = "0x1809F9510")]
		[CompilerGenerated]
		get
		{
			return default(IBKBPFELIAH);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F9570", Offset = "0x9F8770", VA = "0x1809F9570")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	public INNKLILOHKI? JLJABPKFMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x71C1FD0", Offset = "0x71C11D0", VA = "0x1871C1FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x71C2160", Offset = "0x71C1360", VA = "0x1871C2160")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public bool FIJEHOADBII
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x71C2190", Offset = "0x71C1390", VA = "0x1871C2190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool OANEHJGHFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x71C2170", Offset = "0x71C1370", VA = "0x1871C2170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool FCMCILINPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x71C2040", Offset = "0x71C1240", VA = "0x1871C2040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	[IgnoreDataMember]
	public bool MDMEOBHDBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x9EF220", Offset = "0x9EE420", VA = "0x1809EF220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1F0", Offset = "0x9EE3F0", VA = "0x1809EF1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	[IgnoreDataMember]
	public bool KJALJJOFOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x2B22090", Offset = "0x2B21290", VA = "0x182B22090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x2B223A0", Offset = "0x2B215A0", VA = "0x182B223A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	[IgnoreDataMember]
	public string JNFICOKHEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xD6D9C0", Offset = "0xD6CBC0", VA = "0x180D6D9C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xE70820", Offset = "0xE6FA20", VA = "0x180E70820")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	[IgnoreDataMember]
	public string NGBHLJEJIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xD51D30", Offset = "0xD50F30", VA = "0x180D51D30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xD51D40", Offset = "0xD50F40", VA = "0x180D51D40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	[IgnoreDataMember]
	public bool ECKMBBLDEGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0xF50EC0", Offset = "0xF500C0", VA = "0x180F50EC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xBDDDD0", Offset = "0xBDCFD0", VA = "0x180BDDDD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x71C1FE0", Offset = "0x71C11E0", VA = "0x1871C1FE0", Slot = "5")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x71C2080", Offset = "0x71C1280", VA = "0x1871C2080", Slot = "6")]
	[AsyncStateMachine(typeof(DMDHBKFNLLK))]
	public virtual Task KPBJEKHPINM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x13717E0", Offset = "0x13709E0", VA = "0x1813717E0")]
	public void MMBHPBOFPAJ(BAACIDJNIFD OPJOIGJBJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GHKJMIKCPFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface NGKCIGMIGCI
{
	[Cpp2IlInjected.Token(Token = "0x17000151")]
	long KKHDEOGDELK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	string BMKOOCPFAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	int OMGCPPDKIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	string EJNONMFBDGI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	string EOLKJMPOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	byte MHLLLKDHDHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	int EGLCLCFNCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	int IAOIOGBLEGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	LNMPHCNNDCM LLKHKPGDPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	bool OGPAKKOOKAH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	DateTime IKGJDBNACMI
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	DateTime? BJNNMHMLKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	long? GHMADCBOKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	int DEKNAEKGEAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	int LOONJFENLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	int FMEOODBGCBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	GHIFIMEACDK JBOIFOKCLAK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	GHIFIMEACDK MLDAFHFNPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	bool FGHKOPLANNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	bool ILMFKLDEADI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	bool CLJAOINMMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	bool JEIDKLBJDCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	int? MNLAMBOMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	bool IIIODKGNCCM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	string NMINMCBLLFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LNHKADKBBEC();

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ALCIEIJKNAE();
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DBAGFLHDBHH]
public class GDKMHHNMMFP : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public List<DKLEEOBOOCG> LKFBICNBCEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x71C1C50", Offset = "0x71C0E50", VA = "0x1871C1C50")]
	public List<string> BDABNLNIGMF(params KKAHILCAKHN[] CPLCCNOHCOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x71C1E10", Offset = "0x71C1010", VA = "0x1871C1E10")]
	public List<string> CBJDMCPDGGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x71C1F80", Offset = "0x71C1180", VA = "0x1871C1F80")]
	public List<string> OMLPFMLLJBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x71C1E90", Offset = "0x71C1090", VA = "0x1871C1E90", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GDKMHHNMMFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DBAGFLHDBHH]
public class PEMPMHLNGPK : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	public int OMGCPPDKIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public PEMPMHLNGPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DBAGFLHDBHH]
public class DCLIPLIEFKC : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	public long KKHDEOGDELK
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	public string BMKOOCPFAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	public int KPNBIKBCPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	public bool EBGLLHFJJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xD224B0", Offset = "0xD216B0", VA = "0x180D224B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0xD22350", Offset = "0xD21550", VA = "0x180D22350")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public int AOGIGBBKBOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public int LHNPFNJDNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xC73E60", Offset = "0xC73060", VA = "0x180C73E60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x13D2D70", Offset = "0x13D1F70", VA = "0x1813D2D70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000175")]
	public int LFCNGMMMKBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x9FD530", Offset = "0x9FC730", VA = "0x1809FD530")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9FD8D0", Offset = "0x9FCAD0", VA = "0x1809FD8D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000176")]
	public int HCMIFPANDMD
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0xA31650", Offset = "0xA30850", VA = "0x180A31650")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xA30790", Offset = "0xA2F990", VA = "0x180A30790")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000177")]
	public string OONKNDJFANB
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000178")]
	public string GNHKMLPPEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000179")]
	public DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x6F03C40", Offset = "0x6F02E40", VA = "0x186F03C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017A")]
	public LNMPHCNNDCM? IKGOKDBDHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xE2D910", Offset = "0xE2CB10", VA = "0x180E2D910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017B")]
	public IReadOnlyList<Guid> DPKKCFCOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700017C")]
	public ELAGIFLJMJI LOGIEMEIEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x71BFA20", Offset = "0x71BEC20", VA = "0x1871BFA20")]
		get
		{
			return default(ELAGIFLJMJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x71BFA80", Offset = "0x71BEC80", VA = "0x1871BFA80", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x71BFA70", Offset = "0x71BEC70", VA = "0x1871BFA70")]
	public bool EKHAGIJCEHN(DCLIPLIEFKC CAOALFLCMLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x71BFB10", Offset = "0x71BED10", VA = "0x1871BFB10")]
	private bool MLHNMFFHLPN(DCLIPLIEFKC CAOALFLCMLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x71BFCF0", Offset = "0x71BEEF0", VA = "0x1871BFCF0")]
	private static bool PJGAGEMFEMJ(IReadOnlyList<Guid> KKNIAPMJJLB, IReadOnlyList<Guid> OCEENEOJELM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x27BFBE0", Offset = "0x27BEDE0", VA = "0x1827BFBE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DCLIPLIEFKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DBAGFLHDBHH]
public class PNEFGIFKOMO : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700017D")]
	public int INDJCIBJDOK
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public PNEFGIFKOMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DBAGFLHDBHH]
public class FBDHKGOOMMK : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700017E")]
	public bool FAECIEINIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B7E0", VA = "0x180C8C5E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5D0", Offset = "0xC8B7D0", VA = "0x180C8C5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FBDHKGOOMMK()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[DBAGFLHDBHH]
	public class NewInventionRequestDTO : EDDGMJLBELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public ODJGKIKFMEP creatorAccountRole;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public long? convertedFromInventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public string displayMetadataJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public string longDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0xEB70D0", Offset = "0xEB62D0", VA = "0x180EB70D0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x71C5A70", Offset = "0x71C4C70", VA = "0x1871C5A70")]
		public NewInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[DBAGFLHDBHH]
	public class AddVersionInventionRequestDTO : EDDGMJLBELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public long inventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool hasBetaContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int instantiationCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int lightsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public int chipsCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int cloudVariablesCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int aiCost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public byte ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public long creationRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public string inventionDataFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public List<long> referencedInventions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public IReadOnlyList<Guid> referencedUnityAssetIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public ModifyTagsRequest tagsRequest;

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0xEB70D0", Offset = "0xEB62D0", VA = "0x180EB70D0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x71BE470", Offset = "0x71BD670", VA = "0x1871BE470")]
		public AddVersionInventionRequestDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[DBAGFLHDBHH]
	public class ModifyTagsRequest : EDDGMJLBELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public List<string> AutoTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public List<string> CustomTags;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[DBAGFLHDBHH]
	public class InventionModifyTagsRequest : ModifyTagsRequest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public long InventionId;

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public InventionModifyTagsRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[DBAGFLHDBHH]
	public class ReportRequest : EDDGMJLBELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public string Details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public ECEGBCEKFDI ReportCategory;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ReportRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[DBAGFLHDBHH]
	public class CheerRequest : EDDGMJLBELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public bool Cheer;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public CheerRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[DBAGFLHDBHH]
	public class UpdatePriceRequest : EDDGMJLBELL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public long InventionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int Price;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public UpdatePriceRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[DBAGFLHDBHH]
	public class UpdateInventionMetadataRequest : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		public string LongDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		public ModifyTagsRequest TagsRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0xEB70D0", Offset = "0xEB62D0", VA = "0x180EB70D0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public UpdateInventionMetadataRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[DBAGFLHDBHH]
	public class UpdateInventionGeneralPermissionRequest : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x17000185")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		public GHIFIMEACDK Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			[CompilerGenerated]
			get
			{
				return default(GHIFIMEACDK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public UpdateInventionGeneralPermissionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[DBAGFLHDBHH]
	public class PublishInventionRequest : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x17000187")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		public GHIFIMEACDK Permission
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			[CompilerGenerated]
			get
			{
				return default(GHIFIMEACDK);
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		public LNMPHCNNDCM Accessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xA18BE0", Offset = "0xA17DE0", VA = "0x180A18BE0")]
			[CompilerGenerated]
			get
			{
				return default(LNMPHCNNDCM);
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xD6F6E0", Offset = "0xD6E8E0", VA = "0x180D6F6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		public int? Price
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0xCBAC80", Offset = "0xCB9E80", VA = "0x180CBAC80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public PublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[DBAGFLHDBHH]
	public class UnpublishInventionRequest : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public UnpublishInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[DBAGFLHDBHH]
	public class DeleteInventionRequest : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public DeleteInventionRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[DBAGFLHDBHH]
	public class SetInventionVersionAccessibilityRequest : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		public long InventionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		public int VersionNumber
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		public LNMPHCNNDCM NewAccessibility
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xA18BE0", Offset = "0xA17DE0", VA = "0x180A18BE0")]
			[CompilerGenerated]
			get
			{
				return default(LNMPHCNNDCM);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xD6F6E0", Offset = "0xD6E8E0", VA = "0x180D6F6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public SetInventionVersionAccessibilityRequest()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[DBAGFLHDBHH]
	public class SpecialTags : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x17000190")]
		public List<string> AutoTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		public List<string> AGOnlyTags
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public SpecialTags()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public enum IDLGFKBAHCP
{
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	InvalidParameters,
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	PlayerCannotUpload,
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	DuplicateName,
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	NameTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	NameTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	NotCreator,
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	DoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	ImageDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	InventionLimitReached,
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	DescriptionTooLong,
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	InnapropriateName,
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	InappropriateDescription,
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	CannotBeModified,
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	PlayerCannotPublish,
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	AlreadyPublished,
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	AlreadyUnpublished,
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	InventionUnderModerationReview,
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	PlayerCannotDownload,
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	PlayerAlreadyOwns,
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	DescriptionTooShort,
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	DoesNotHavePermission,
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	PermissionLevelCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	AlreadyCheered,
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	AlreadyRemovedCheer,
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	ModeratorRestrictedPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	PlayerCannotSell,
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	InvalidPrice,
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	PriceCannotBeChanged,
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	InvalidPermissionForPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	PurchaseFailed,
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	CannotDownloadPaidInvention,
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	CannotSellUnownedLineage,
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	DoesNotAllowTrial,
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	StillOnTrialCooldown,
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	PlayerCannotTrial,
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	PaidInventionPublishingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	PaidInventionPurchasingDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	OperationIsDisabled,
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	PlayerRestrictedFromP2PSelling,
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	PlayerNotRecRoomPlusMember,
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	InvalidInstantiationCost,
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	FeaturedInventionNotPublished,
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	FeaturedInventionNotActive,
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	InventionContainsBlockedFiles,
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	PlayerRestrictedFromP2PBuying,
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	ReservedWordRuleViolationInName,
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	ReservedWordRuleViolationInDescription,
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	InventionContainsBetaContent,
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	PlatformDoesntSupportPublishing,
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	MismatchedUgcVersions,
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	ConvertedFromSameUgcVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	ConvertedFromInventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	ConvertedFromInventionHigherVersion,
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	PlatformDoesntSupportInvention
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public enum ECEGBCEKFDI
{
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	CoC_Discriminatory,
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	CoC_Sexual,
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	CoC_Trolling,
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	Misleading,
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	Other
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public enum AHCNLMOKJPC
{
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	False,
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	True,
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	Invited
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public interface DBBCJHOFHMN
{
	[Cpp2IlInjected.Token(Token = "0x17000192")]
	OHGJBEJJKAO HECKAKIFAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000193")]
	string NDNCLGLPMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000194")]
	int OGDCDIANMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000195")]
	DateTime LHIKEFFJMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000196")]
	bool FMMDPHGIJIG
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000197")]
	string HOAGGPFNPMH
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000198")]
	EGAKMNNIDNK CIBCIDAJCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EJBLMMEIOCH();

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HGHOCGLIMMG(EGAKMNNIDNK MLBEKKKBNJL);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface BLGGIMOJBFG
{
	[Cpp2IlInjected.Token(Token = "0x17000199")]
	string FHFPDDDDGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019A")]
	int LNJBLGDGPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700019B")]
	bool EIFJBLOBLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EJBLMMEIOCH();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public struct JDEFJBLIOPE
{
	[Cpp2IlInjected.Token(Token = "0x1700019C")]
	public EBLNGFCBABB HHCPBPCCFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA3D0B0", Offset = "0xA3C2B0", VA = "0x180A3D0B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(EBLNGFCBABB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x12B95B0", Offset = "0x12B87B0", VA = "0x1812B95B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019D")]
	public BLGGIMOJBFG ONDFEBEFONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xDAB610", Offset = "0xDAA810", VA = "0x180DAB610")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0xDAB540", Offset = "0xDAA740", VA = "0x180DAB540")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700019E")]
	public string EFCLCBOAGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x5C516A0", Offset = "0x5C508A0", VA = "0x185C516A0")]
	public JDEFJBLIOPE(EBLNGFCBABB CLEHGGOHMOO, [Optional] BLGGIMOJBFG NHOAPDHOOLC, [Optional] string MKEFFENDHDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public enum EBLNGFCBABB
{
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	ContinueSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	TryAgainSecurityCode,
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	RemoteAuthPending
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DBAGFLHDBHH]
public class FMLDLIGKHIB : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700019F")]
	public string BOOHGFLEOCF
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A0")]
	public string IPFFKLHMEDF
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A1")]
	public string AKAKOMCEHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A2")]
	public string LNNFDKNHMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A3")]
	public List<IPNOGLHAKEO> DNHOCDDFFCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FMLDLIGKHIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x4937220", Offset = "0x4936420", VA = "0x184937220")]
	public FMLDLIGKHIB([Optional] string HMJLCNALFAJ, [Optional] string DPHLDNMFMID, [Optional] string IIACHJLOEID, [Optional] string NHGLOAIPGPG, [Optional] List<IPNOGLHAKEO> FGCNIHIELGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[DBAGFLHDBHH]
public class IPNOGLHAKEO : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170001A4")]
	public string PMMOFHCOHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A5")]
	public string LNNFDKNHMDN
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public IPNOGLHAKEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DBAGFLHDBHH]
public class HLFDIJPGNLN : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170001A6")]
	public string IPFFKLHMEDF
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A7")]
	public string HHCPBPCCFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A8")]
	public string BOOHGFLEOCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001A9")]
	public List<string> ICECEFIFAOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HLFDIJPGNLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[DBAGFLHDBHH]
public interface EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EJBLMMEIOCH();
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[DBAGFLHDBHH]
public interface JODOMHIHKJK : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KPBJEKHPINM();
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[HKAHCOHPLFH]
public interface OCPIHIKNAGF : EDDGMJLBELL
{
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DBAGFLHDBHH]
public class HHNPNGAMMKB : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170001AA")]
	public Guid CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AB")]
	public int AOJFILOCGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AC")]
	public string ANONJDNGOCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AD")]
	public string HPNAJKCGHDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HHNPNGAMMKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x71C28D0", Offset = "0x71C1AD0", VA = "0x1871C28D0")]
	public HHNPNGAMMKB([Optional] Guid NFCMKJPGKGP, int IKCLPEICFDN = 0, [Optional] string DGACIKAIKAD, [Optional] string MGPKKEOCJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[DBAGFLHDBHH]
public class AKHNIDFFNPA : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public const int IAJEJPPNIOI = 0;

	[Cpp2IlInjected.Token(Token = "0x170001AE")]
	public long JMNBOGKFLAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001AF")]
	public MADOHDFLEFJ CIDCEHCHHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B0")]
	public string GPNDJIJBNDE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public List<HHNPNGAMMKB> HDMMJBKDEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public int MKIODEAICCF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x9FD530", Offset = "0x9FC730", VA = "0x1809FD530")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x9FD8D0", Offset = "0x9FCAD0", VA = "0x1809FD8D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public LNMPHCNNDCM LLKHKPGDPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xBFB9D0", Offset = "0xBFABD0", VA = "0x180BFB9D0")]
		[CompilerGenerated]
		get
		{
			return default(LNMPHCNNDCM);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xE21FA0", Offset = "0xE211A0", VA = "0x180E21FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public string ELKAEJDEDME
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public bool GMNJJMBOKPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x1E06570", Offset = "0x1E05770", VA = "0x181E06570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x71BE3E0", Offset = "0x71BD5E0", VA = "0x1871BE3E0")]
	public AKHNIDFFNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x71BE2C0", Offset = "0x71BD4C0", VA = "0x1871BE2C0")]
	public AKHNIDFFNPA(long PCJNBDJCNDP = 0L, [Optional] MADOHDFLEFJ LKMBNKOMMID, [Optional] string CNMCNFHDGKA, [Optional] List<HHNPNGAMMKB> NOJDNAFLHEN, int FIAODFNFKEN = 0, [Optional] string DGIAFBEDPNJ, LNMPHCNNDCM BCCBJDEOPHO = LNMPHCNNDCM.Private, [Optional] string PNGKFGJBONL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class JHOCPCCMMME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public readonly int OGDCDIANMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public readonly AKHNIDFFNPA GICHGAKHOGA;

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xEC7B70", Offset = "0xEC6D70", VA = "0x180EC7B70")]
	public JHOCPCCMMME(int JKLFDKBOKPI, AKHNIDFFNPA ANFHEEPDABD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[DBAGFLHDBHH]
public class MADOHDFLEFJ : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public string HMLJKMIHLKN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public string GFGNOOPHAGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B9")]
	public string FNBDKKMMHDM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public string GMCNMLMPFKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BB")]
	public string BOELCEDGEIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BC")]
	public string HDMMJBKDEJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x71C4A60", Offset = "0x71C3C60", VA = "0x1871C4A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MADOHDFLEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x4937220", Offset = "0x4936420", VA = "0x184937220")]
	public MADOHDFLEFJ([Optional] string LCCCKDFEGIB, [Optional] string DCHDDGPPBFN, [Optional] string LFLGHGKLGBD, [Optional] string PPBFBMBLICC, [Optional] string AOFEBAENHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[DBAGFLHDBHH]
public class CKKOBIOLHHI : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170001BD")]
	public Dictionary<int, AKHNIDFFNPA> BENAJMCDJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CKKOBIOLHHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[DBAGFLHDBHH]
public class IGABBDCANMM : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170001BE")]
	public List<int> GANNGHNPJEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001BF")]
	public byte? NPHIIMJMGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x2E29470", Offset = "0x2E28670", VA = "0x182E29470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x2E29460", Offset = "0x2E28660", VA = "0x182E29460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C0")]
	public int? DEHLLHBGDBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xEDE6C0", Offset = "0xEDD8C0", VA = "0x180EDE6C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0xEDE6F0", Offset = "0xEDD8F0", VA = "0x180EDE6F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public IGABBDCANMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class EPILNIMNLPM
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x71C0AD0", Offset = "0x71BFCD0", VA = "0x1871C0AD0")]
	public static MJJEAILKKIC BKJKOAFALNC(this HHNPNGAMMKB CEENCLMGJAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[Flags]
public enum IBKBPFELIAH
{
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	Steam = 1,
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	PlayStation = 4,
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	Xbox = 8,
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	RecNet = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	IOS = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	GooglePlay = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	Standalone = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	Pico = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	Switch = 0x200,
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	All = -1
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public enum OHGJBEJJKAO
{
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	All = -1,
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	Steam,
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	Oculus,
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	PlayStation,
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	Xbox,
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	IOS,
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	GooglePlay,
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	Standalone,
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	Switch
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[DBAGFLHDBHH]
public class ABAECDIKNBL : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170001C1")]
	[DataMember(Name = "PlayerId")]
	public int OGDCDIANMOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C2")]
	public int BAECBNPALCP
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0xB834E0", Offset = "0xB826E0", VA = "0x180B834E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0xC65020", Offset = "0xC64220", VA = "0x180C65020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public int GOADELGCBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public ABAECDIKNBL()
	{
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[DBAGFLHDBHH]
	public class ProgressionEventRecordDTO : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		public int OGDCDIANMOB
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		public int PFFOCDMMOOM
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xB834E0", Offset = "0xB826E0", VA = "0x180B834E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xC65020", Offset = "0xC64220", VA = "0x180C65020")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		public int GEKCDBFIGEI
		{
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		public int JAMNCLHBAKL
		{
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0xA18BE0", Offset = "0xA17DE0", VA = "0x180A18BE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xD6F6E0", Offset = "0xD6E8E0", VA = "0x180D6F6E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		public int KEJJENOFOHE
		{
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		public DateTime? GHEAAOMFNLF
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x12A6210", Offset = "0x12A5410", VA = "0x1812A6210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x12A62F0", Offset = "0x12A54F0", VA = "0x1812A62F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ProgressionEventRecordDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x71C82A0", Offset = "0x71C74A0", VA = "0x1871C82A0")]
		public ProgressionEventRecordDTO(int JKLFDKBOKPI = 0, int KLGMLOOMEHH = 0, int BHDHNMIFNAJ = 0, int CDINLAEGHDH = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[DBAGFLHDBHH]
	public class ProgressionEventDTO : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public long AIALAJDHAJN
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public string BGMICIBNDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public List<ProgressionEventRewardDTO> OFKHPACHPIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		public List<KeepsakeRoomListDTO> FFDNCCMPBPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		public DateTime OBGBEKNJEIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x9F24C0", Offset = "0x9F16C0", VA = "0x1809F24C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		public DateTime DEHHJIILLGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x9FD8C0", Offset = "0x9FCAC0", VA = "0x1809FD8C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		public DateTime POCDJBAFGGF
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0xE2DEB0", Offset = "0xE2D0B0", VA = "0x180E2DEB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		public bool BMOBMOPDMPE
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xC1FDB0", Offset = "0xC1EFB0", VA = "0x180C1FDB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0xC54940", Offset = "0xC53B40", VA = "0x180C54940")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		public int OFEODEOHIEG
		{
			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x1377120", Offset = "0x1376320", VA = "0x181377120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x20143A0", Offset = "0x20135A0", VA = "0x1820143A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		public float LNNNIJLDIJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x10CFA70", Offset = "0x10CEC70", VA = "0x1810CFA70")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x1383F20", Offset = "0x1383120", VA = "0x181383F20")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		public Guid? ODKLOCCOCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x71C81D0", Offset = "0x71C73D0", VA = "0x1871C81D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x71C81C0", Offset = "0x71C73C0", VA = "0x1871C81C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		public string NFGGKMGGKPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public string NAIOKGNIAGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x9F3280", Offset = "0x9F2480", VA = "0x1809F3280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x9F3310", Offset = "0x9F2510", VA = "0x1809F3310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public string JMMOGPMGPAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8670", VA = "0x1809F9470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x9F93F0", Offset = "0x9F85F0", VA = "0x1809F93F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public string BPCDCOOCKFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x9F94E0", Offset = "0x9F86E0", VA = "0x1809F94E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x9F95B0", Offset = "0x9F87B0", VA = "0x1809F95B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ProgressionEventDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x71C81F0", Offset = "0x71C73F0", VA = "0x1871C81F0")]
		public ProgressionEventDTO(long MJOKCDGEBGK = 0L, [Optional] string DGIAFBEDPNJ, [Optional] List<ProgressionEventRewardDTO> PGBMEPBDFEP, [Optional] List<KeepsakeRoomListDTO> NPFKKOAPEIC, [Optional] DateTime EGLLDLKJACK, [Optional] DateTime EOPOJMMBBAN, [Optional] DateTime JKMAKFCIIPH, bool LBOPPFHDDCH = false, int ACCMOMKCDFO = 0, float EMNNPDIGINJ = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[DBAGFLHDBHH]
	public class KeepsakeRoomListDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public long PMJJMBCHAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public long AIALAJDHAJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xC65010", Offset = "0xC64210", VA = "0x180C65010")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public int? PBMINGFCNFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0xCBAC80", Offset = "0xCB9E80", VA = "0x180CBAC80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public int? CFMPPFHGLAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x9F2520", Offset = "0x9F1720", VA = "0x1809F2520")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public long? DLPLKBADGKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0xDCD600", Offset = "0xDCC800", VA = "0x180DCD600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xDCCD80", Offset = "0xDCBF80", VA = "0x180DCCD80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public long HHECDFNPFKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xE2DEB0", Offset = "0xE2D0B0", VA = "0x180E2DEB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public TimeSpan MJLHFLIDDDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x71C41A0", Offset = "0x71C33A0", VA = "0x1871C41A0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public long ABJMLGJOEPI
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x6F03C40", Offset = "0x6F02E40", VA = "0x186F03C40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public TimeSpan HGACJOFKMIO
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x71C41F0", Offset = "0x71C33F0", VA = "0x1871C41F0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public int MKBHCKDNJIG
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xD34D90", Offset = "0xD33F90", VA = "0x180D34D90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xE964A0", Offset = "0xE956A0", VA = "0x180E964A0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public HBBBDCHLDGB MPFJLJDODAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x113E9A0", Offset = "0x113DBA0", VA = "0x18113E9A0")]
			[CompilerGenerated]
			get
			{
				return default(HBBBDCHLDGB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x21A5C60", Offset = "0x21A4E60", VA = "0x1821A5C60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public List<KeepsakeRoomDTO> BKNJMINOKNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KeepsakeRoomListDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x71C4240", Offset = "0x71C3440", VA = "0x1871C4240")]
		public KeepsakeRoomListDTO(long BFFBAHBIELJ = 0L, long MJOKCDGEBGK = 0L, [Optional] int? IEPAGPLEMAJ, [Optional] int? KMPBLMHFPKP, [Optional] long? CMKJELOGBEJ, long FCPMBEMHGFK = 0L, long LGOLFGJIAGO = 0L, int IHPAHMFKFFJ = 0, HBBBDCHLDGB AIPOCEKPDEC = HBBBDCHLDGB.Standard, [Optional] List<KeepsakeRoomDTO> HAHFFIGFHFL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[DBAGFLHDBHH]
	public class KeepsakeRoomDTO
	{
		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public long OOHDCPHLKEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public long IDAIGHAHCBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0xC65010", Offset = "0xC64210", VA = "0x180C65010")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public long PMJJMBCHAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0xCBAC80", Offset = "0xCB9E80", VA = "0x180CBAC80")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public HBBBDCHLDGB AFGCMPJBOON
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
			[CompilerGenerated]
			get
			{
				return default(HBBBDCHLDGB);
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public int IPGKACLMHMN
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xC73E60", Offset = "0xC73060", VA = "0x180C73E60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x13D2D70", Offset = "0x13D1F70", VA = "0x1813D2D70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public KeepsakeRoomDTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x71C4140", Offset = "0x71C3340", VA = "0x1871C4140")]
		public KeepsakeRoomDTO(long PLCMNBHPDNM = 0L, long BENLNHBBIME = 0L, long BFFBAHBIELJ = 0L, HBBBDCHLDGB EDLOHJEBKFM = HBBBDCHLDGB.Standard, int JOIDHAINDIA = 0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[DBAGFLHDBHH]
	public class ProgressionEventRewardDTO : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public long GHKKHIGCAEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public int OPANLINHKNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public string EOLKJMPOLOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public int PFFOCDMMOOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public int HDIMHKCLNGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xC73E60", Offset = "0xC73060", VA = "0x180C73E60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x13D2D70", Offset = "0x13D1F70", VA = "0x1813D2D70")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public bool NBGKBBKBAPK
		{
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0xA1E2D0", Offset = "0xA1D4D0", VA = "0x180A1E2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0xA1E050", Offset = "0xA1D250", VA = "0x180A1E050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ProgressionEventRewardDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[DBAGFLHDBHH]
	public class ProgressionEventPurchasableXpBoostDTO : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public Guid LBNENJIKOJF
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public int ECBBHEIKDDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public int KOMMGOPPOKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xF275F0", Offset = "0xF267F0", VA = "0x180F275F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public int BHILPNIJHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public long FBIPLAKMBCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x9F24C0", Offset = "0x9F16C0", VA = "0x1809F24C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public long BLDGLAJDHEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x9FD8C0", Offset = "0x9FCAC0", VA = "0x1809FD8C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ProgressionEventPurchasableXpBoostDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public enum HBBBDCHLDGB
{
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	Standard,
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	Premium
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public enum DCGPHHIICLO
{
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	Explore = 0,
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	GreenPowerCore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	Present = 2,
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	PurplePowerCore = 3,
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	UnnamedKeepsakeNumber1 = 4,
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	UnnamedKeepsakeNumber2 = 5,
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	UnnamedKeepsakeNumber3 = 6,
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	UnnamedKeepsakeNumber4 = 7,
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	UnnamedKeepsakeNumber5 = 8,
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	_Test = 1000
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[DBAGFLHDBHH]
public class MMDIFLJBPNG : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170001F6")]
	public string DOGMAOHHFOD
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001F7")]
	public string? ACJEGOOIMMO
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MMDIFLJBPNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface PKBHKCNDNHN
{
	[Cpp2IlInjected.Token(Token = "0x170001F8")]
	bool KDJBHGKCOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001F9")]
	string? LAFFMJFIHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170001FA")]
	string? HPMOCGKECIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface KOILHCAPEDD<T> : PKBHKCNDNHN
{
	[Cpp2IlInjected.Token(Token = "0x170001FB")]
	T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class BJDHDIPICLM
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x35B7AC0", Offset = "0x35B6CC0", VA = "0x1835B7AC0")]
	public static KOILHCAPEDD<T> NBDDMFIBPFA<T, U>(this KOILHCAPEDD<U> IGGKBIDIAJL, Func<U, T> NMHAFEDCMAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public struct JJGBGANNECB<T> : KOILHCAPEDD<T>, PKBHKCNDNHN
{
	[Cpp2IlInjected.Token(Token = "0x170001FC")]
	public bool KDJBHGKCOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xF400B0", Offset = "0xF3F2B0", VA = "0x180F400B0", Slot = "5")]
		[CompilerGenerated]
		readonly get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x29E56C0", Offset = "0x29E48C0", VA = "0x1829E56C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FD")]
	public string? LAFFMJFIHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0xDAB610", Offset = "0xDAA810", VA = "0x180DAB610", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0xDAB540", Offset = "0xDAA740", VA = "0x180DAB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FE")]
	public string? HPMOCGKECIM
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "7")]
		[CompilerGenerated]
		readonly get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001FF")]
	public T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x4EC8460", Offset = "0x4EC7660", VA = "0x184EC8460")]
	public static JJGBGANNECB<T> ODDIHJFJMPN(T MLCDCHNOCFI)
	{
		return default(JJGBGANNECB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x4EC83A0", Offset = "0x4EC75A0", VA = "0x184EC83A0")]
	public static JJGBGANNECB<T> ALBJONCFKJN(string KOIHEPAFBFG, string JKCEOCEEFNF = "")
	{
		return default(JJGBGANNECB<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DBAGFLHDBHH]
public class OKKKIMFHCLG : PKBHKCNDNHN, EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000200")]
	public bool KDJBHGKCOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B7E0", VA = "0x180C8C5E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5D0", Offset = "0xC8B7D0", VA = "0x180C8C5D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000201")]
	public string? LAFFMJFIHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000202")]
	[DataMember(Name = "error_id")]
	public string? HPMOCGKECIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "8")]
	public virtual void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x71C6BE0", Offset = "0x71C5DE0", VA = "0x1871C6BE0")]
	public static OKKKIMFHCLG ODDIHJFJMPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x71C6B50", Offset = "0x71C5D50", VA = "0x1871C6B50")]
	public static OKKKIMFHCLG ALBJONCFKJN(string KOIHEPAFBFG, string JKCEOCEEFNF = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public OKKKIMFHCLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[BHLBHLLEBBE]
public abstract class OAPIEIGAADC<T> : OKKKIMFHCLG, KOILHCAPEDD<T>, PKBHKCNDNHN
{
	[Cpp2IlInjected.Token(Token = "0x17000203")]
	public T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0xDC4260", Offset = "0xDC3460", VA = "0x180DC4260", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0xAADDE0", Offset = "0xAACFE0", VA = "0x180AADDE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
	protected OAPIEIGAADC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[BHLBHLLEBBE]
public class DLDDBHKMFLD<T> : OAPIEIGAADC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6A29BA0", Offset = "0x6A28DA0", VA = "0x186A29BA0")]
	private static void BFHGOCHKGMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x44F4310", Offset = "0x44F3510", VA = "0x1844F4310")]
	public DLDDBHKMFLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[BHLBHLLEBBE]
public class DEOBABMLFHH<T> : OAPIEIGAADC<T>, JODOMHIHKJK, EDDGMJLBELL where T : EDDGMJLBELL, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct MEFLAOGOCGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public DEOBABMLFHH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x52D86A0", Offset = "0x52D78A0", VA = "0x1852D86A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x52D8920", Offset = "0x52D7B20", VA = "0x1852D8920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x6A20370", Offset = "0x6A1F570", VA = "0x186A20370", Slot = "8")]
	public override void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x6A20400", Offset = "0x6A1F600", VA = "0x186A20400", Slot = "10")]
	[AsyncStateMachine(typeof(DEOBABMLFHH<>.MEFLAOGOCGG))]
	public Task KPBJEKHPINM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x6A204D0", Offset = "0x6A1F6D0", VA = "0x186A204D0")]
	public static DEOBABMLFHH<T> ODDIHJFJMPN(T MLCDCHNOCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x6A20220", Offset = "0x6A1F420", VA = "0x186A20220")]
	public new static DEOBABMLFHH<T> ALBJONCFKJN(string KOIHEPAFBFG, string JKCEOCEEFNF = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x4535FA0", Offset = "0x45351A0", VA = "0x184535FA0")]
	public DEOBABMLFHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[BHLBHLLEBBE]
public class LMDOHOLNPPG<T> : OAPIEIGAADC<List<T>>
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x44F4310", Offset = "0x44F3510", VA = "0x1844F4310")]
	public LMDOHOLNPPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[BHLBHLLEBBE]
public class KIDNPGBGLPA<T> : OAPIEIGAADC<List<T>>, JODOMHIHKJK, EDDGMJLBELL where T : EDDGMJLBELL, new()
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct BCEIEONPCJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public KIDNPGBGLPA<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x5E70550", Offset = "0x5E6F750", VA = "0x185E70550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x5E70760", Offset = "0x5E6F960", VA = "0x185E70760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5015DB0", Offset = "0x5014FB0", VA = "0x185015DB0")]
	public static KIDNPGBGLPA<T> ODDIHJFJMPN(List<T> MLCDCHNOCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5015920", Offset = "0x5014B20", VA = "0x185015920")]
	public new static KIDNPGBGLPA<T> ALBJONCFKJN(string KOIHEPAFBFG, string JKCEOCEEFNF = "")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5015A70", Offset = "0x5014C70", VA = "0x185015A70", Slot = "8")]
	public override void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5015CE0", Offset = "0x5014EE0", VA = "0x185015CE0", Slot = "10")]
	[AsyncStateMachine(typeof(KIDNPGBGLPA<>.BCEIEONPCJE))]
	public Task KPBJEKHPINM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x4F68930", Offset = "0x4F67B30", VA = "0x184F68930")]
	public KIDNPGBGLPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public enum BKCHBBCPJCA
{
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	AI,
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	Auth,
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	API,
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	Commerce,
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	Matchmaking,
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	Notifications,
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	Images,
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	CDN,
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	Storage,
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	Chat,
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	Leaderboard,
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	Accounts,
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	Link,
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	Lists,
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	RoomComments,
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	Clubs,
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	Rooms,
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	PlatformNotifications,
	[Cpp2IlInjected.Token(Token = "0x40002B3")]
	Moderation,
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	DataCollection,
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	BugReporting,
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	Discovery,
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	PlayerSettings,
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	Studio,
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	GameLogs,
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	Strings,
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	StringsCDN,
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	WWW,
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	Econ,
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	Data,
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	Cards
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class DBGMNAOEMJH
{
	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x71BF9C0", Offset = "0x71BEBC0", VA = "0x1871BF9C0")]
	public static bool KHLNKDJGNHH(this BKCHBBCPJCA JJHEMKLPAME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x71BF9C0", Offset = "0x71BEBC0", VA = "0x1871BF9C0")]
	public static bool OLHCEKDCCNL(this BKCHBBCPJCA JJHEMKLPAME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public enum CIHMKPKBLFN
{
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	LaserTagTickets = 1,
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	RecCenterTokens = 2,
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	LostSkullsGold = 100,
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	DraculaSilver = 101,
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	RecRoyale_Season1 = 200,
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	RoomCurrency = 300,
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	RoomInventoryItem = 301,
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	ProgressionEvent = 400
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public enum INNKLILOHKI
{
	[Cpp2IlInjected.Token(Token = "0x40002CB")]
	NonPurchasedNotUsableInP2P = -2,
	[Cpp2IlInjected.Token(Token = "0x40002CC")]
	NonPurchasedDefault = -1,
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	SteamPurchased = 0,
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	OculusPurchased = 1,
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	PlayStationPurchased = 2,
	[Cpp2IlInjected.Token(Token = "0x40002D0")]
	MicrosoftPurchased = 3,
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	IOSPurchased = 5,
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	GooglePlayPurchased = 6,
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	PicoPurchased = 8,
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	RecNetPurchased = 4,
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	SwitchPurchased = 9,
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	[Obsolete("Subscription benefits for PS4 players were awarded with this balance type. It is not transferrable to other platforms. Usable in P2P economy. We are using PlayStationPurchased instead now. -- bilal - 11/11/2020")]
	PlayStationNonPurchasedP2P = 100,
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	[Obsolete("Subscription benefits for NON PS4 players were awarded with this balance type. We are using <PlatformType>Purchased instead now. -- bilal - 11/11/2020")]
	NonPlayStationNonPurchasedP2P = 101,
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	NonPurchasedEarnedByP2P = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	NonPurchasedEarnedByP2Pv2 = 1001
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public enum BAACIDJNIFD
{
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	First_Activity = 1,
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	Game_Drop = 2,
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	All_Daily_Challenges_Complete = 3,
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	All_Weekly_Challenge_Complete = 4,
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	Daily_Challenge_Complete = 5,
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	Weekly_Challenge_Complete = 6,
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	Unassigned_Equipment = 10,
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	Unassigned_Avatar = 11,
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	Unassigned_Consumable = 12,
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	Reacquisition = 20,
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	Membership = 21,
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	NUX_TokensAndDressUp = 30,
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	NUX_Experiment1 = 31,
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	NUX_Experiment2 = 32,
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	NUX_Experiment3 = 33,
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	NUX_Experiment4 = 34,
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	NUX_Experiment5 = 35,
	[Cpp2IlInjected.Token(Token = "0x40002EE")]
	GameRewards = 50,
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	GameRewards_Tokens = 51,
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	GameRewards_Tokens_Experiment_Override = 52,
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	GameRewards_A = 53,
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	GameRewards_B = 54,
	[Cpp2IlInjected.Token(Token = "0x40002F3")]
	LevelUp = 100,
	[Cpp2IlInjected.Token(Token = "0x40002F4")]
	Purchased_Gift_A = 500,
	[Cpp2IlInjected.Token(Token = "0x40002F5")]
	Purchased_Gift_B = 501,
	[Cpp2IlInjected.Token(Token = "0x40002F6")]
	Purchased_Gift_C = 502,
	[Cpp2IlInjected.Token(Token = "0x40002F7")]
	Purchased_Gift_D = 503,
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	Holiday = 1000,
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	Contest = 1001,
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	Promotion = 1002,
	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	LimitedTime = 1003,
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	LimitedTimeEvent = 1004,
	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	Deprecated = 1100,
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	RecRoyale = 1200,
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	Friendotron_Gift = 1300,
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	DEPRECATED_Paintball_ClearCut = 2000,
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	DEPRECATED_Paintball_Homestead = 2001,
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	DEPRECATED_Paintball_Quarry = 2002,
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	DEPRECATED_Paintball_River = 2003,
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	DEPRECATED_Paintball_Dam = 2004,
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	DEPRECATED_Paintball_DriveIn = 2005,
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	Paintball_ClearCut = 2010,
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	Paintball_Homestead = 2011,
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	Paintball_Quarry = 2012,
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	Paintball_River = 2013,
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	Paintball_Dam = 2014,
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	Paintball_DriveIn = 2015,
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	DEPRECATED_Discgolf_Propulsion = 3000,
	[Cpp2IlInjected.Token(Token = "0x400030D")]
	DEPRECATED_Discgolf_Lake = 3001,
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	Discgolf_Propulsion = 3010,
	[Cpp2IlInjected.Token(Token = "0x400030F")]
	Discgolf_Lake = 3011,
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	Discgolf_Mode_CoopCatch = 3500,
	[Cpp2IlInjected.Token(Token = "0x4000311")]
	Quest_Goblin_A = 4000,
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	Quest_Goblin_B = 4001,
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	Quest_Goblin_C = 4002,
	[Cpp2IlInjected.Token(Token = "0x4000314")]
	Quest_Goblin_S = 4003,
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	Quest_Goblin_Consumable = 4004,
	[Cpp2IlInjected.Token(Token = "0x4000316")]
	Quest_Cauldron_A = 4010,
	[Cpp2IlInjected.Token(Token = "0x4000317")]
	Quest_Cauldron_B = 4011,
	[Cpp2IlInjected.Token(Token = "0x4000318")]
	Quest_Cauldron_C = 4012,
	[Cpp2IlInjected.Token(Token = "0x4000319")]
	Quest_Cauldron_S = 4013,
	[Cpp2IlInjected.Token(Token = "0x400031A")]
	Quest_Cauldron_Consumable = 4014,
	[Cpp2IlInjected.Token(Token = "0x400031B")]
	Quest_Pirate1_A = 4100,
	[Cpp2IlInjected.Token(Token = "0x400031C")]
	Quest_Pirate1_B = 4101,
	[Cpp2IlInjected.Token(Token = "0x400031D")]
	Quest_Pirate1_C = 4102,
	[Cpp2IlInjected.Token(Token = "0x400031E")]
	Quest_Pirate1_S = 4103,
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	Quest_Pirate1_X = 4104,
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	Quest_Pirate1_Consumable = 4105,
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	Quest_Dracula1_A = 4200,
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	Quest_Dracula1_B = 4201,
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	Quest_Dracula1_C = 4202,
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	Quest_Dracula1_S = 4203,
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	Quest_Dracula1_X = 4204,
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	Quest_Dracula1_Consumable = 4205,
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	Quest_Dracula1_SS = 4206,
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	Quest_SciFi_A = 4500,
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	Quest_SciFi_B = 4501,
	[Cpp2IlInjected.Token(Token = "0x400032A")]
	Quest_SciFi_C = 4502,
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	Quest_SciFi_S = 4503,
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	Quest_Scifi_Consumable = 4504,
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	DEPRECATED_Charades = 5000,
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	Charades = 5001,
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	DEPRECATED_Soccer = 6000,
	[Cpp2IlInjected.Token(Token = "0x4000330")]
	Soccer = 6001,
	[Cpp2IlInjected.Token(Token = "0x4000331")]
	DEPRECATED_Paddleball = 7000,
	[Cpp2IlInjected.Token(Token = "0x4000332")]
	Paddleball = 7001,
	[Cpp2IlInjected.Token(Token = "0x4000333")]
	DEPRECATED_Dodgeball = 8000,
	[Cpp2IlInjected.Token(Token = "0x4000334")]
	Dodgeball = 8001,
	[Cpp2IlInjected.Token(Token = "0x4000335")]
	DEPRECATED_Lasertag = 9000,
	[Cpp2IlInjected.Token(Token = "0x4000336")]
	Lasertag = 9001,
	[Cpp2IlInjected.Token(Token = "0x4000337")]
	DEPRECATED_Bowling = 10000,
	[Cpp2IlInjected.Token(Token = "0x4000338")]
	Bowling = 10001,
	[Cpp2IlInjected.Token(Token = "0x4000339")]
	StuntRunner_TheMainEvent_A = 11000,
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	StuntRunner_TheMainEvent_B = 11001,
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	StuntRunner_TheMainEvent_C = 11002,
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	StuntRunner_TheMainEvent_D = 11003,
	[Cpp2IlInjected.Token(Token = "0x400033D")]
	StuntRunner_TheMainEvent_S = 11004,
	[Cpp2IlInjected.Token(Token = "0x400033E")]
	StuntRunner_TheMainEvent_X = 11005,
	[Cpp2IlInjected.Token(Token = "0x400033F")]
	StuntRunner_TheMainEvent_Consumable = 11006,
	[Cpp2IlInjected.Token(Token = "0x4000340")]
	StuntRunner_TheMainEvent_SS = 11007,
	[Cpp2IlInjected.Token(Token = "0x4000341")]
	RecRally = 12000,
	[Cpp2IlInjected.Token(Token = "0x4000342")]
	Showdown_A = 12100,
	[Cpp2IlInjected.Token(Token = "0x4000343")]
	Showdown_B = 12101,
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	Showdown_C = 12102,
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	MyLittleMonsters = 12200,
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	RunTheBlock = 12300,
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	RROStorefront_ToBeNamed_2 = 12400,
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	ProgressionEvent = 13000,
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	Store_LaserTag = 100000,
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	Store_RecCenter = 100010,
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	Consumable = 110000,
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	Token = 110100,
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	Punchcard_Challenge_Complete = 110200,
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	All_Punchcard_Challenges_Complete = 110201,
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	New_Player_Checklist_Item_Complete = 110300,
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	Commerce_Purchase = 200000,
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	Gift_Card_Redemption = 210000
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public enum NKIINHMBKEE
{
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	Common = 0,
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	Uncommon = 10,
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	Rare = 20,
	[Cpp2IlInjected.Token(Token = "0x4000357")]
	Epic = 30,
	[Cpp2IlInjected.Token(Token = "0x4000358")]
	Legendary = 50
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public enum MMODBOLHKCM
{
	[Cpp2IlInjected.Token(Token = "0x400035A")]
	OK,
	[Cpp2IlInjected.Token(Token = "0x400035B")]
	TooManyRequests,
	[Cpp2IlInjected.Token(Token = "0x400035C")]
	NotEnoughCredit,
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	AlreadyOwned,
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	NoItemAvailable,
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	CouponNotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	RequestedPriceDoesNotMatch,
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	RequestedAmountNotAllowed,
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	PlayerNotEligible,
	[Cpp2IlInjected.Token(Token = "0x4000363")]
	RequestCannotBeRefunded,
	[Cpp2IlInjected.Token(Token = "0x4000364")]
	PlayerNotApproved
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[DBAGFLHDBHH]
	public class BalanceResponseDTO : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x17000204")]
		public long Balance
		{
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		public CIHMKPKBLFN CurrencyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			[CompilerGenerated]
			get
			{
				return default(CIHMKPKBLFN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		[DataMember(Name = "Platform")]
		public INNKLILOHKI BalanceType
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xA18BE0", Offset = "0xA17DE0", VA = "0x180A18BE0")]
			[CompilerGenerated]
			get
			{
				return default(INNKLILOHKI);
			}
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0xD6F6E0", Offset = "0xD6E8E0", VA = "0x180D6F6E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public virtual void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BalanceResponseDTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[DBAGFLHDBHH]
	public class FilteredTextDTO : EDDGMJLBELL
	{
		[Cpp2IlInjected.Token(Token = "0x17000207")]
		public string FHFPDDDDGDA
		{
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public int NMKIKLHENGM
		{
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
		public void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public FilteredTextDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[DBAGFLHDBHH]
public class KBAJKMHLGIJ : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000209")]
	public string IOHPGHDECJP
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020A")]
	public string IKPPIHAMJDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KBAJKMHLGIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[DBAGFLHDBHH]
public class BONFOJLEOLO : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700020B")]
	public List<KBAJKMHLGIJ> KIONICHDDPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public BONFOJLEOLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[DBAGFLHDBHH]
public class JCACKAGNDNK : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700020C")]
	public string ALDLLIODOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public JCACKAGNDNK(string ABGJHFCBJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[DBAGFLHDBHH]
public class JEEIFFJNAGD : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700020D")]
	public List<KBAJKMHLGIJ> KIONICHDDPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public JEEIFFJNAGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
[DBAGFLHDBHH]
public class MCPOFPEDNOC : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700020E")]
	public List<JCACKAGNDNK> ALPICKFDDJA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700020F")]
	public string DOPAOOPALDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000210")]
	public bool ANBGONEHAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000211")]
	public int CFCGGIJDICN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0xF275F0", Offset = "0xF267F0", VA = "0x180F275F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MCPOFPEDNOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x71C4DE0", Offset = "0x71C3FE0", VA = "0x1871C4DE0")]
	public MCPOFPEDNOC(string EALFDDLKEFJ, List<JCACKAGNDNK> IGNLPNJPOGF, bool LKGKBHKDKBF, int IDMEKEAALMJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[DBAGFLHDBHH]
public class KPIANAFAKEC : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000212")]
	public List<JEEIFFJNAGD> OALFELIOEII
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000213")]
	public bool ANBGONEHAMK
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0xAACFF0", Offset = "0xAAC1F0", VA = "0x180AACFF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F8320", Offset = "0x9F7520", VA = "0x1809F8320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KPIANAFAKEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[DBAGFLHDBHH]
public class COOPBDILGAD : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public enum FJNKGFJCHHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		EnqueuedPending,
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		DequeuedStarting,
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		CompleteSuccess
	}

	[Cpp2IlInjected.Token(Token = "0x4000375")]
	public const string KMCLEALCBIH = "StringAutoLocalizationJob";

	[Cpp2IlInjected.Token(Token = "0x17000214")]
	public string DOPAOOPALDD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000215")]
	public FJNKGFJCHHE HHCPBPCCFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		[CompilerGenerated]
		get
		{
			return default(FJNKGFJCHHE);
		}
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x71BF650", Offset = "0x71BE850", VA = "0x1871BF650")]
	public COOPBDILGAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x71BF660", Offset = "0x71BE860", VA = "0x1871BF660")]
	public COOPBDILGAD(string EALFDDLKEFJ, FJNKGFJCHHE CLEHGGOHMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
[DBAGFLHDBHH]
public class CCOLICLLGEJ : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000216")]
	public bool AIAOMNGCAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B7E0", VA = "0x180C8C5E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5D0", Offset = "0xC8B7D0", VA = "0x180C8C5D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CCOLICLLGEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C3")]
public static class LMPCMIDLNCK
{
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public enum MFBAPPPEMHM
	{
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		CoC_Discriminatory,
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		CoC_Sexual,
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		CoC_Trolling,
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		Misleading,
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		InappropriateClothing
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
[DBAGFLHDBHH]
public class ABNKKPFIGAC : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000217")]
	public long IDAIGHAHCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000218")]
	public Guid HMGPNLEADDM
	{
		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0xDD6D20", Offset = "0xDD5F20", VA = "0x180DD6D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000219")]
	public long KBFCEOJMLKG
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F2520", Offset = "0x9F1720", VA = "0x1809F2520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021A")]
	public OMCBLEEAKAN AFLACMOIPHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public ABNKKPFIGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x71BE120", Offset = "0x71BD320", VA = "0x1871BE120")]
	public ABNKKPFIGAC(long BENLNHBBIME, Guid OFIKLCBNKFF, long BJDKEGOHCNL, OMCBLEEAKAN OAKHKILEGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x71BE100", Offset = "0x71BD300", VA = "0x1871BE100", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[DBAGFLHDBHH]
public class BNFLNIBBEBD : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700021B")]
	public MGONOANNAMP JPOOALJFOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(MGONOANNAMP);
		}
		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021C")]
	public CIBHGMCBEEO GLPIALOMIID
	{
		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public BNFLNIBBEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0xEC7B70", Offset = "0xEC6D70", VA = "0x180EC7B70")]
	public BNFLNIBBEBD(MGONOANNAMP IGGKBIDIAJL, CIBHGMCBEEO LAGDAFFKDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[DBAGFLHDBHH]
public class OMCBLEEAKAN : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700021D")]
	public Guid? PODKGCKKHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x2DFB1E0", Offset = "0x2DFA3E0", VA = "0x182DFB1E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x71C6C50", Offset = "0x71C5E50", VA = "0x1871C6C50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700021E")]
	public Guid IMOFHOMOIPK
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0xD34DA0", Offset = "0xD33FA0", VA = "0x180D34DA0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0xF45E50", Offset = "0xF45050", VA = "0x180F45E50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public OMCBLEEAKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x71C6C60", Offset = "0x71C5E60", VA = "0x1871C6C60")]
	public OMCBLEEAKAN(Guid? FMHPPFMJJFH, Guid OKDDCALHLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[DBAGFLHDBHH]
public class CIBHGMCBEEO : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700021F")]
	public long IDAIGHAHCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000220")]
	public Guid HMGPNLEADDM
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0xDD6D20", Offset = "0xDD5F20", VA = "0x180DD6D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000221")]
	public long FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F2520", Offset = "0x9F1720", VA = "0x1809F2520")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000222")]
	public Guid GIMMFJKNKOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0xDCD600", Offset = "0xDCC800", VA = "0x180DCD600")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xDCCD80", Offset = "0xDCBF80", VA = "0x180DCCD80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000223")]
	public DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xE2DEB0", Offset = "0xE2D0B0", VA = "0x180E2DEB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000224")]
	public DateTime IKGJDBNACMI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x6F03C40", Offset = "0x6F02E40", VA = "0x186F03C40")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CIBHGMCBEEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
[DBAGFLHDBHH]
public class ODBEFNMNGJL : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000225")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000226")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000227")]
	public string EOLKJMPOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000228")]
	public List<long> NJNCKIIOELO
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000229")]
	public List<DLJIPIMKBLE> JAFBEIGJIII
	{
		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022A")]
	public string BFLCNFBCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022B")]
	public byte? EAIBNJGGHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x71C6B40", Offset = "0x71C5D40", VA = "0x1871C6B40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x71C6B30", Offset = "0x71C5D30", VA = "0x1871C6B30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022C")]
	public int? JKEFBPPDDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x71C0620", Offset = "0x71BF820", VA = "0x1871C0620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x71C0470", Offset = "0x71BF670", VA = "0x1871C0470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022D")]
	public Guid? HNKIFLHHBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x71C6B10", Offset = "0x71C5D10", VA = "0x1871C6B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x71C6B00", Offset = "0x71C5D00", VA = "0x1871C6B00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700022E")]
	public bool LNDDJEBEMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D80", Offset = "0x9F5F80", VA = "0x1809F6D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D60", Offset = "0x9F5F60", VA = "0x1809F6D60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public ODBEFNMNGJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
[DBAGFLHDBHH]
public class PNNAJNMBLMN : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700022F")]
	public Guid HNKIFLHHBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000230")]
	public long IDAIGHAHCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0xCBAC80", Offset = "0xCB9E80", VA = "0x180CBAC80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000231")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000232")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000233")]
	public string EOLKJMPOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000234")]
	public DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xE2DEB0", Offset = "0xE2D0B0", VA = "0x180E2DEB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000235")]
	public DateTime IKGJDBNACMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x6F03C40", Offset = "0x6F02E40", VA = "0x186F03C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000236")]
	public string BFLCNFBCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000237")]
	public List<long> NJNCKIIOELO
	{
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000238")]
	public List<LLEOACLEDBO> JAFBEIGJIII
	{
		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000239")]
	public byte EAIBNJGGHCM
	{
		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0xD34EB0", Offset = "0xD340B0", VA = "0x180D34EB0")]
		[CompilerGenerated]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x122CCE0", Offset = "0x122BEE0", VA = "0x18122CCE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023A")]
	public int JKEFBPPDDCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xA27C90", Offset = "0xA26E90", VA = "0x180A27C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x132DD30", Offset = "0x132CF30", VA = "0x18132DD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public PNNAJNMBLMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
public enum MGONOANNAMP
{
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	Unknown = -1,
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	RoomInventoryItemDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	PlayerDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	RequestQuantityTooLarge,
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	PlayerHasReachedTheMinimumOwnedAmount,
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	ConcurrencyCodeMismatch,
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	InvalidConcurrencyCode
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public interface AIHNKMGKNIF
{
	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OAPIEIGAADC<PNNAJNMBLMN>> OBOGMKHBCFC(Guid? HABHLGAHKCC, long BENLNHBBIME, string DGIAFBEDPNJ, string CMDDDPOOGFO, string GGCHPOGNGCI, string LEAJIONEKBN, byte FDPAKEMBDAE, int EKKMKLFENBL, [Optional] List<long> JGALFLFHKDM, [Optional] List<LLEOACLEDBO> DNIOOEJIEKH, bool GHCNMGJFIJL = false, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OAPIEIGAADC<PNNAJNMBLMN>> DMNNNLNDMJN(Guid OFIKLCBNKFF, long BENLNHBBIME, [Optional] string DGIAFBEDPNJ, [Optional] string CMDDDPOOGFO, [Optional] string GGCHPOGNGCI, [Optional] List<long> JGALFLFHKDM, [Optional] Dictionary<string, string> DNIOOEJIEKH, [Optional] string LEAJIONEKBN, [Optional] byte? FDPAKEMBDAE, [Optional] int? EKKMKLFENBL, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OKKKIMFHCLG> OKILHPCBANE(Guid OFIKLCBNKFF, long BENLNHBBIME, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<PNNAJNMBLMN>> EKDFGECIJJP(long BENLNHBBIME, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<List<CIBHGMCBEEO>> JEHKHCGPCOG(long BENLNHBBIME, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<List<BNFLNIBBEBD>> OFHKKEFNPIK(long BENLNHBBIME, List<ABNKKPFIGAC> AMEPKMJHNEA, [Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
[DBAGFLHDBHH]
public class DLJIPIMKBLE : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700023B")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023C")]
	public string BFLCNFBCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DLJIPIMKBLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
[DBAGFLHDBHH]
public class LLEOACLEDBO : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700023D")]
	public long JDLEFIIGOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023E")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700023F")]
	public string BFLCNFBCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public LLEOACLEDBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
[DBAGFLHDBHH]
public class GKFIHGCJKKM : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000240")]
	public long JDLEFIIGOJF
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000241")]
	public string BFLCNFBCBEF
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x49306C0", Offset = "0x492F8C0", VA = "0x1849306C0")]
	public GKFIHGCJKKM(long PEHHPIDDOBA, string PPDPHFAEOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public interface JKDMHCBFCLK
{
	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OAPIEIGAADC<List<LLEOACLEDBO>>> GIAKCFMALMG(long BENLNHBBIME, List<GKFIHGCJKKM> AMEPKMJHNEA, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OKKKIMFHCLG> NNGPIEAKGHJ(long PEHHPIDDOBA, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<List<LLEOACLEDBO>> DDIICLGKELO(long BENLNHBBIME, [Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[DBAGFLHDBHH]
public class AHCGBALGKEI : JEAKBKHNFMG, IEquatable<AHCGBALGKEI>
{
	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x71BE180", Offset = "0x71BD380", VA = "0x1871BE180", Slot = "7")]
	public bool Equals(AHCGBALGKEI FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x71BE1C0", Offset = "0x71BD3C0", VA = "0x1871BE1C0", Slot = "6")]
	public override JEAKBKHNFMG GIAPJGILOPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public AHCGBALGKEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
public static class NCHPMMDFGAI
{
	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x71C5030", Offset = "0x71C4230", VA = "0x1871C5030")]
	public static AHCGBALGKEI GGKCIIOKDCJ(this FDNFENGHPEB CKEIAGIGCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x71C50A0", Offset = "0x71C42A0", VA = "0x1871C50A0")]
	public static AHCGBALGKEI HIKPPIMIIBN(string AAJHBKMHLML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
[DBAGFLHDBHH]
public class FDNFENGHPEB : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x40003B9")]
	public const int LIFBKMIHNMM = 3;

	[Cpp2IlInjected.Token(Token = "0x40003BA")]
	public const int LBDCODLAEJH = 40;

	[Cpp2IlInjected.Token(Token = "0x40003BB")]
	public const int KFDIENKHPAI = 180;

	[Cpp2IlInjected.Token(Token = "0x40003BC")]
	public const int MAMEOHIFAGH = 1000;

	[Cpp2IlInjected.Token(Token = "0x40003BD")]
	public const int MKOHFHAMFFL = 99999;

	[Cpp2IlInjected.Token(Token = "0x40003BE")]
	public const int ELCJHMKBPHN = 8;

	[Cpp2IlInjected.Token(Token = "0x40003BF")]
	public const int FICNAOOOGLL = 1;

	[Cpp2IlInjected.Token(Token = "0x40003C0")]
	public const int PDGJLFLHKHN = 1000000000;

	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public const int FKCABBONLMF = 9999;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40003CF")]
	[IgnoreDataMember]
	private IReadOnlyDictionary<Guid, int>? KBMDJFPHIIA;

	[Cpp2IlInjected.Token(Token = "0x17000242")]
	public Guid HNKIFLHHBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000243")]
	public long IDAIGHAHCBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xCBAC80", Offset = "0xCB9E80", VA = "0x180CBAC80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000244")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000245")]
	public string? BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000246")]
	public string? EOLKJMPOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000247")]
	public int MNLAMBOMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xBFB9D0", Offset = "0xBFABD0", VA = "0x180BFB9D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xE21FA0", Offset = "0xE211A0", VA = "0x180E21FA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000248")]
	public Guid? LFLKPMGLFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x71C1A10", Offset = "0x71C0C10", VA = "0x1871C1A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x71C1A30", Offset = "0x71C0C30", VA = "0x1871C1A30")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000249")]
	public int EAJOLKMOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xD863B0", Offset = "0xD855B0", VA = "0x180D863B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xD863A0", Offset = "0xD855A0", VA = "0x180D863A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024A")]
	public int? CLFMFAEHPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6380", Offset = "0x6BE5580", VA = "0x186BE6380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x6BE63A0", Offset = "0x6BE55A0", VA = "0x186BE63A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024B")]
	public int? EKCBFJMHGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x71C16D0", Offset = "0x71C08D0", VA = "0x1871C16D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x71C16C0", Offset = "0x71C08C0", VA = "0x1871C16C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024C")]
	public IReadOnlyList<KMKLLFGKKNI> MEBEDHGPAGM
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x9F3280", Offset = "0x9F2480", VA = "0x1809F3280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x9F3310", Offset = "0x9F2510", VA = "0x1809F3310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024D")]
	public DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8670", VA = "0x1809F9470")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xE75340", Offset = "0xE74540", VA = "0x180E75340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024E")]
	public DateTime IKGJDBNACMI
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x9F94E0", Offset = "0x9F86E0", VA = "0x1809F94E0")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xE74790", Offset = "0xE73990", VA = "0x180E74790")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700024F")]
	[IgnoreDataMember]
	public OGNGFANCKGI EEHEMNEPALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x71C1AB0", Offset = "0x71C0CB0", VA = "0x1871C1AB0")]
		get
		{
			return default(OGNGFANCKGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000250")]
	[IgnoreDataMember]
	public IReadOnlyDictionary<Guid, int> OHECNPELCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x71C16F0", Offset = "0x71C08F0", VA = "0x1871C16F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x9F94A0", Offset = "0x9F86A0", VA = "0x1809F94A0")]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x71C16E0", Offset = "0x71C08E0", VA = "0x1871C16E0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FDNFENGHPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x71C1B20", Offset = "0x71C0D20", VA = "0x1871C1B20")]
	public FDNFENGHPEB(Guid HABHLGAHKCC, long BENLNHBBIME, string DGIAFBEDPNJ, string CMDDDPOOGFO, string GGCHPOGNGCI, int CDLHEIHGPNH, int? MJKDGEDLEBI, int? GEBODAOOMFP, List<KMKLLFGKKNI> NFONBGJBGBM, [Optional] DateTime OFDMKGELPHL, [Optional] DateTime IONJONLKHMA, [Optional] Guid? NNBODMEMAAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x71C1A40", Offset = "0x71C0C40", VA = "0x1871C1A40")]
	private OGNGFANCKGI OIFAHMCECKP()
	{
		return default(OGNGFANCKGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x71C1740", Offset = "0x71C0940", VA = "0x1871C1740")]
	private Dictionary<Guid, int> JDPNMLNIAAN(IReadOnlyList<KMKLLFGKKNI> NFONBGJBGBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[DBAGFLHDBHH]
public class LJKOJJFCJIO : EDDGMJLBELL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003D0")]
	public Guid HNKIFLHHBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D1")]
	public long IDAIGHAHCBA;

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public LJKOJJFCJIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
[DBAGFLHDBHH]
public class GPGBIBJKKNJ : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000251")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000252")]
	public string? BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000253")]
	public string? EOLKJMPOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000254")]
	public int MNLAMBOMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000255")]
	public int? CLFMFAEHPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0xEDE6B0", Offset = "0xEDD8B0", VA = "0x180EDE6B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0xEDE6E0", Offset = "0xEDD8E0", VA = "0x180EDE6E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000256")]
	public int? EKCBFJMHGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0xCBAC50", Offset = "0xCB9E50", VA = "0x180CBAC50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0xCBACA0", Offset = "0xCB9EA0", VA = "0x180CBACA0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000257")]
	public List<KMKLLFGKKNI> MEBEDHGPAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000258")]
	public Guid? DECINDPPPBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x71C2060", Offset = "0x71C1260", VA = "0x1871C2060")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x71C2150", Offset = "0x71C1350", VA = "0x1871C2150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000259")]
	public Guid? HNKIFLHHBFH
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x71C2830", Offset = "0x71C1A30", VA = "0x1871C2830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x71C2810", Offset = "0x71C1A10", VA = "0x1871C2810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025A")]
	public bool LNDDJEBEMKM
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0xD34ED0", Offset = "0xD340D0", VA = "0x180D34ED0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0xE92CC0", Offset = "0xE91EC0", VA = "0x180E92CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x71C2820", Offset = "0x71C1A20", VA = "0x1871C2820", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GPGBIBJKKNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
[DBAGFLHDBHH]
public class KMKLLFGKKNI : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700025B")]
	public AGLBKNJOAKP MBNHPGJCJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B7E0", VA = "0x180C8C5E0")]
		[CompilerGenerated]
		get
		{
			return default(AGLBKNJOAKP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5D0", Offset = "0xC8B7D0", VA = "0x180C8C5D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025C")]
	public Guid POEMFPCPIOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x18E5C10", Offset = "0x18E4E10", VA = "0x1818E5C10")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x585A3A0", Offset = "0x58595A0", VA = "0x18585A3A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025D")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0xF275F0", Offset = "0xF267F0", VA = "0x180F275F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KMKLLFGKKNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x71C40F0", Offset = "0x71C32F0", VA = "0x1871C40F0")]
	public KMKLLFGKKNI(Guid GKEFPHPIPAA, AGLBKNJOAKP EDLOHJEBKFM, int KIFHGDECLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[DBAGFLHDBHH]
public class JOGGFLCLEOI : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700025E")]
	public Guid BNADCAJOFJO
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700025F")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000260")]
	public int BFMBOODFJOM
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000261")]
	public DateTime KMMDCAADKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x9F24C0", Offset = "0x9F16C0", VA = "0x1809F24C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000262")]
	public int EAJOLKMOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xD6AC00", Offset = "0xD69E00", VA = "0x180D6AC00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x71C3790", Offset = "0x71C2990", VA = "0x1871C3790")]
	public JOGGFLCLEOI(Guid KPFLELDHLPD, string DGIAFBEDPNJ, int KJEHAPBKEFG, DateTime IACCPEDOGHG, int COBPGHDNJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public JOGGFLCLEOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
[DBAGFLHDBHH]
public class PMKOLNNFEAL : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000263")]
	public Guid BNADCAJOFJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xF99CD0", Offset = "0xF98ED0", VA = "0x180F99CD0")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xF99CE0", Offset = "0xF98EE0", VA = "0x180F99CE0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000264")]
	public int BEPKKFOLIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public PMKOLNNFEAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x5549650", Offset = "0x5548850", VA = "0x185549650")]
	public PMKOLNNFEAL(Guid KPFLELDHLPD, int HCGFJLNHNCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
[DBAGFLHDBHH]
public class CLMGDLFKJJO : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000265")]
	public int BEPKKFOLIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000266")]
	public Guid JFLPMDGODOE
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x18E5C10", Offset = "0x18E4E10", VA = "0x1818E5C10")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x585A3A0", Offset = "0x58595A0", VA = "0x18585A3A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000267")]
	public int BMHCBIGAMHI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0xF275F0", Offset = "0xF267F0", VA = "0x180F275F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000268")]
	public Guid? JAODBAPMGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0xE75B80", Offset = "0xE74D80", VA = "0x180E75B80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x2198E60", Offset = "0x2198060", VA = "0x182198E60")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000269")]
	public int MMLJDJBJMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7C0", Offset = "0xA0D9C0", VA = "0x180A0E7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x1495150", Offset = "0x1494350", VA = "0x181495150")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026A")]
	public Dictionary<Guid, Guid?> OCKCCPOLBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CLMGDLFKJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x71BF440", Offset = "0x71BE640", VA = "0x1871BF440")]
	public CLMGDLFKJJO(int HCGFJLNHNCA, Guid OKMBDDMPEBJ, int JJNGOBDINBA, Guid? BAAMOBOMNPC, int LNHNIBOMGBC, Dictionary<Guid, Guid?> GKCHPJCCKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
[DBAGFLHDBHH]
public class HHADHMOJKDN : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700026B")]
	public NLIKIILHCPI IHGFDGFOOMK
	{
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B7E0", VA = "0x180C8C5E0")]
		[CompilerGenerated]
		get
		{
			return default(NLIKIILHCPI);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xC8C5D0", Offset = "0xC8B7D0", VA = "0x180C8C5D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026C")]
	public MMODBOLHKCM? DPIHAKHEJAB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0xEDE690", Offset = "0xEDD890", VA = "0x180EDE690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xEE7570", Offset = "0xEE6770", VA = "0x180EE7570")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026D")]
	public BalanceResponseDTO FHILCJNKMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700026E")]
	public List<CIBHGMCBEEO> EPJDAJMADCO
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HHADHMOJKDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x71C2860", Offset = "0x71C1A60", VA = "0x1871C2860")]
	public HHADHMOJKDN(NLIKIILHCPI PEAFKMLOHMF, MMODBOLHKCM? CKEEEHOODBC, BalanceResponseDTO BCCAFCPGBIG, List<CIBHGMCBEEO> EPKFIBCFPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x71C2850", Offset = "0x71C1A50", VA = "0x1871C2850", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public enum AGLBKNJOAKP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003F1")]
	Unset,
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	RoomInventoryItem
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public enum NLIKIILHCPI : byte
{
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	Success = 0,
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	ConcurrencyCodeMismatch = 1,
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	RoomOfferDoesNotExist = 2,
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	InvalidRequest = 3,
	[Cpp2IlInjected.Token(Token = "0x40003F8")]
	AccountIdIsInvalid = 4,
	[Cpp2IlInjected.Token(Token = "0x40003F9")]
	PlayerIsP2PBuyingRestricted = 5,
	[Cpp2IlInjected.Token(Token = "0x40003FA")]
	ExpectedOfferTotalPriceMismatch = 6,
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	ExpectedOfferVersionMismatch = 7,
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	InsufficientBalance = 8,
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	OfferUnderModeration = 9,
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	InvalidExpectedTotalPrice = 10,
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	InvalidExpectedOfferVersion = 11,
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	CannotPurchaseMoreThanPerPlayerLimit = 12,
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	InvalidExpectedPriceUnit = 13,
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	InsufficientInventoryItems = 14,
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	NoConcurrencyCodesForInventoryItem = 100,
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	UnexpectedOfferItemType = 101,
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	FeatureDisabled = 254,
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	UnknownError = byte.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public enum OGNGFANCKGI : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000409")]
	OneTimePurchase,
	[Cpp2IlInjected.Token(Token = "0x400040A")]
	BulkPurchase
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public interface PFOOAAKIHGN
{
	[Cpp2IlInjected.Token(Token = "0x400040B")]
	static NDCOIAMFCNJ<FDNFENGHPEB> EKHPIFDAGOB;

	[Cpp2IlInjected.Token(Token = "0x400040C")]
	static NDCOIAMFCNJ<FDNFENGHPEB> HAMOJBBJJOE;

	[Cpp2IlInjected.Token(Token = "0x400040D")]
	static NDCOIAMFCNJ<Guid> IKFCJIFLBCL;

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<OAPIEIGAADC<FDNFENGHPEB?>?>? JHJKFEGJFBL(Guid? HABHLGAHKCC, long BENLNHBBIME, string DGIAFBEDPNJ, string? CMDDDPOOGFO, string? GGCHPOGNGCI, int CDLHEIHGPNH, OGNGFANCKGI CLBCKNKJINM, [Optional] Dictionary<Guid, int>? BCOPDGJFDKP, [Optional] Guid? BAHFAMJEONF, bool GHCNMGJFIJL = false, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OAPIEIGAADC<FDNFENGHPEB?>?>? DNCOBNEBNJG(Guid KPFLELDHLPD, long BENLNHBBIME, string DGIAFBEDPNJ, string? CMDDDPOOGFO, string? GGCHPOGNGCI, int CDLHEIHGPNH, OGNGFANCKGI CLBCKNKJINM, [Optional] Dictionary<Guid, int>? BCOPDGJFDKP, [Optional] Guid? BAHFAMJEONF, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<OKKKIMFHCLG> ONFJHIFGGLN(Guid KPFLELDHLPD, long BENLNHBBIME, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<List<FDNFENGHPEB>> HFGOLDNPEFM(long BENLNHBBIME, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<OAPIEIGAADC<List<PMKOLNNFEAL>>> JHEGHMIJAJO(long BENLNHBBIME, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<OAPIEIGAADC<List<JOGGFLCLEOI>>> ONMBJDPNFAC(long BENLNHBBIME, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task<HHADHMOJKDN> BKHOGKIOFLM(Guid KPFLELDHLPD, long BENLNHBBIME, int HCGFJLNHNCA, int JJNGOBDINBA, Guid? FCCBJPMECAB, int LNHNIBOMGBC, Dictionary<Guid, Guid?> GKOIPIFOIEI, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x71C7400", Offset = "0x71C6600", VA = "0x1871C7400")]
	static PFOOAAKIHGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DF")]
[DBAGFLHDBHH]
public class ENDDFIDOKCE : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700026F")]
	public long IDAIGHAHCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000270")]
	public bool BPJIIPBMMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0xAACFF0", Offset = "0xAAC1F0", VA = "0x180AACFF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x9F8320", Offset = "0x9F7520", VA = "0x1809F8320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public ENDDFIDOKCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public interface JMFJGEGPOKN
{
	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<ENDDFIDOKCE> AMICGGLOKDD(long BENLNHBBIME, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<OKKKIMFHCLG> BHAMDIGABBN(long BENLNHBBIME, bool HBNLPAPACAG, [Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
[BHLBHLLEBBE]
public class NLOCICHFPJE<DataType> where DataType : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000271")]
	public long CJJLOCAPHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000272")]
	public CIHMKPKBLFN JLBDCKJMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		[CompilerGenerated]
		get
		{
			return default(CIHMKPKBLFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000273")]
	public INNKLILOHKI JLJABPKFMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0xA18BE0", Offset = "0xA17DE0", VA = "0x180A18BE0")]
		[CompilerGenerated]
		get
		{
			return default(INNKLILOHKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0xD6F6E0", Offset = "0xD6E8E0", VA = "0x180D6F6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000274")]
	public DataType ALBEJFPMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return (DataType)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public NLOCICHFPJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
[BHLBHLLEBBE]
public class BLDPFEIIKMF<DataType> where DataType : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000275")]
	public long CJJLOCAPHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000276")]
	public CIHMKPKBLFN JLBDCKJMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		[CompilerGenerated]
		get
		{
			return default(CIHMKPKBLFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000277")]
	public INNKLILOHKI JLJABPKFMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0xA18BE0", Offset = "0xA17DE0", VA = "0x180A18BE0")]
		[CompilerGenerated]
		get
		{
			return default(INNKLILOHKI);
		}
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0xD6F6E0", Offset = "0xD6E8E0", VA = "0x180D6F6E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000278")]
	public List<DataType> ALBEJFPMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public BLDPFEIIKMF()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[BHLBHLLEBBE]
	public class BalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : EDDGMJLBELL, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[BHLBHLLEBBE]
		public class PBGIBJKHIMP : JODOMHIHKJK, EDDGMJLBELL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E5")]
			[CompilerGenerated]
			private struct DCMMPDNJLOE : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041C")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041D")]
				public PBGIBJKHIMP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400041E")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005E5")]
				[Cpp2IlInjected.Address(RVA = "0x69D5450", Offset = "0x69D4650", VA = "0x1869D5450", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005E6")]
				[Cpp2IlInjected.Address(RVA = "0x69D5730", Offset = "0x69D4930", VA = "0x1869D5730", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027A")]
			public MMODBOLHKCM HHADEEJIGAG
			{
				[Cpp2IlInjected.Token(Token = "0x60005DE")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				[CompilerGenerated]
				get
				{
					return default(MMODBOLHKCM);
				}
				[Cpp2IlInjected.Token(Token = "0x60005DF")]
				[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027B")]
			public DataTypeDTO ALBEJFPMKJB
			{
				[Cpp2IlInjected.Token(Token = "0x60005E0")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				[CompilerGenerated]
				get
				{
					return (DataTypeDTO)null;
				}
				[Cpp2IlInjected.Token(Token = "0x60005E1")]
				[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005E2")]
			[Cpp2IlInjected.Address(RVA = "0x5604200", Offset = "0x5603400", VA = "0x185604200", Slot = "5")]
			public void EJBLMMEIOCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005E3")]
			[Cpp2IlInjected.Address(RVA = "0x56042F0", Offset = "0x56034F0", VA = "0x1856042F0", Slot = "4")]
			[AsyncStateMachine(typeof(BalanceUpdateResponseDTO<>.PBGIBJKHIMP.DCMMPDNJLOE))]
			public Task KPBJEKHPINM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public PBGIBJKHIMP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000279")]
		public List<PBGIBJKHIMP> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60005DA")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005DB")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x5679F60", Offset = "0x5679160", VA = "0x185679F60", Slot = "5")]
		public override void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public BalanceUpdateResponseDTO()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[BHLBHLLEBBE]
	public class PurchaseBalanceUpdateResponseDTO<DataTypeDTO> : BalanceResponseDTO where DataTypeDTO : EDDGMJLBELL, new()
	{
		[Cpp2IlInjected.Token(Token = "0x20000E7")]
		[BHLBHLLEBBE]
		public class PJPBPHBMLKG : JODOMHIHKJK, EDDGMJLBELL
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000E8")]
			[CompilerGenerated]
			private struct OPMGPALACCG : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000422")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000423")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000424")]
				public PJPBPHBMLKG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000425")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60005F2")]
				[Cpp2IlInjected.Address(RVA = "0x5549BC0", Offset = "0x5548DC0", VA = "0x185549BC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60005F3")]
				[Cpp2IlInjected.Address(RVA = "0x5549E30", Offset = "0x5549030", VA = "0x185549E30", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027D")]
			public MMODBOLHKCM HHADEEJIGAG
			{
				[Cpp2IlInjected.Token(Token = "0x60005EB")]
				[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
				[CompilerGenerated]
				get
				{
					return default(MMODBOLHKCM);
				}
				[Cpp2IlInjected.Token(Token = "0x60005EC")]
				[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700027E")]
			public List<DataTypeDTO> ALBEJFPMKJB
			{
				[Cpp2IlInjected.Token(Token = "0x60005ED")]
				[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60005EE")]
				[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
				[CompilerGenerated]
				internal set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x5630390", Offset = "0x562F590", VA = "0x185630390", Slot = "5")]
			public void EJBLMMEIOCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x5630630", Offset = "0x562F830", VA = "0x185630630", Slot = "4")]
			[AsyncStateMachine(typeof(PurchaseBalanceUpdateResponseDTO<>.PJPBPHBMLKG.OPMGPALACCG))]
			public Task KPBJEKHPINM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
			public PJPBPHBMLKG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		public List<PJPBPHBMLKG> BalanceUpdates
		{
			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x5679F60", Offset = "0x5679160", VA = "0x185679F60", Slot = "5")]
		public override void EJBLMMEIOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
		public PurchaseBalanceUpdateResponseDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
[IHLKOOMPMFH]
public class DCLCGGMMPKF : PurchaseBalanceUpdateResponseDTO<GHKJMIKCPFE>
{
	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x71BF9E0", Offset = "0x71BEBE0", VA = "0x1871BF9E0")]
	public DCLCGGMMPKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
[IHLKOOMPMFH]
public class EPMNMAPEFEL : PurchaseBalanceUpdateResponseDTO<GHKJMIKCPFE>.PJPBPHBMLKG
{
	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x71C0B40", Offset = "0x71BFD40", VA = "0x1871C0B40")]
	public EPMNMAPEFEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
[DBAGFLHDBHH]
public class FABMLMOMEOL : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700027F")]
	public HKNMNBNPHJB CIIABINKFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000280")]
	public long MAMJILCMDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xC65010", Offset = "0xC64210", VA = "0x180C65010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000281")]
	public GiftItemDTO? HLNJFJGGHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000282")]
	public long? FKEGFCPODAF
	{
		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x12A6210", Offset = "0x12A5410", VA = "0x1812A6210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x12A62F0", Offset = "0x12A54F0", VA = "0x1812A62F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000283")]
	public int HPIIMPFBOOH
	{
		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0xA0E7B0", Offset = "0xA0D9B0", VA = "0x180A0E7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0xD6AC00", Offset = "0xD69E00", VA = "0x180D6AC00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x71C0B80", Offset = "0x71BFD80", VA = "0x1871C0B80")]
	public FABMLMOMEOL(HKNMNBNPHJB ODLOOOFOLBN, long PMMDPJNEPEE, GiftItemDTO? MDODNKHHNEN, int EFBHJGDEKHC = 1, [Optional] long? FLIHMCFFMPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[DBAGFLHDBHH]
public class DHMOPCGBNOO : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000284")]
	public List<FABMLMOMEOL> OHMJBDJNKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000285")]
	public DAJCBAEDADB? NEPEIEMKPCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0xC65010", Offset = "0xC64210", VA = "0x180C65010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000286")]
	public CIHMKPKBLFN JLBDCKJMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(CIHMKPKBLFN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000287")]
	public bool EPBHKFECKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0xD224B0", Offset = "0xD216B0", VA = "0x180D224B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0xD22350", Offset = "0xD21550", VA = "0x180D22350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000288")]
	public bool CBOFCICGKOP
	{
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x136E830", Offset = "0x136DA30", VA = "0x18136E830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x2661130", Offset = "0x2660330", VA = "0x182661130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x71BFD90", Offset = "0x71BEF90", VA = "0x1871BFD90")]
	public DHMOPCGBNOO(List<FABMLMOMEOL> CFNGNBDOLIE, DAJCBAEDADB? ALFOCLJBJFM, CIHMKPKBLFN FPBMLOPCHIM, bool FKFINBJBOHP, bool CJAJNKEMCAP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
[DBAGFLHDBHH]
public class PPJBNCHIOGE : JODOMHIHKJK, EDDGMJLBELL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct KFEIJJEOPAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public PPJBNCHIOGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x71C3C00", Offset = "0x71C2E00", VA = "0x1871C3C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x71C3EE0", Offset = "0x71C30E0", VA = "0x1871C3EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000430")]
	internal static Action<GHKJMIKCPFE>? BCGOFGGBFPB;

	[Cpp2IlInjected.Token(Token = "0x4000431")]
	internal static Func<GHKJMIKCPFE, Task>? ICHNFBBFILD;

	[Cpp2IlInjected.Token(Token = "0x17000289")]
	public GHKJMIKCPFE LAFFPKNHNFP
	{
		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700028A")]
	public ECGLABHDGNK? DMIDIDNEODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x71C8030", Offset = "0x71C7230", VA = "0x1871C8030", Slot = "5")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x71C80F0", Offset = "0x71C72F0", VA = "0x1871C80F0", Slot = "6")]
	[AsyncStateMachine(typeof(KFEIJJEOPAC))]
	public virtual Task KPBJEKHPINM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public PPJBNCHIOGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
[IHLKOOMPMFH]
public class KHANBNAJMEH : BalanceUpdateResponseDTO<PPJBNCHIOGE>
{
	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x71C4090", Offset = "0x71C3290", VA = "0x1871C4090")]
	public KHANBNAJMEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
[IHLKOOMPMFH]
public class LPJCIKOOFOA : BalanceUpdateResponseDTO<PPJBNCHIOGE>.PBGIBJKHIMP
{
	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x71C4990", Offset = "0x71C3B90", VA = "0x1871C4990")]
	public LPJCIKOOFOA()
	{
	}
}
namespace RecNet
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[DBAGFLHDBHH]
	public class GiftItemDTO
	{
		[Cpp2IlInjected.Token(Token = "0x1700028B")]
		public int ToPlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028C")]
		public string? Message
		{
			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		public bool Anonymous
		{
			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		public BAACIDJNIFD GiftContext
		{
			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630")]
			[CompilerGenerated]
			get
			{
				return default(BAACIDJNIFD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0xF275F0", Offset = "0xF267F0", VA = "0x180F275F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public GiftItemDTO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
[DBAGFLHDBHH]
public class OBNDCIGENOG : EDDGMJLBELL, IKCLLFELIOF
{
	[Cpp2IlInjected.Token(Token = "0x1700028F")]
	public CBOPCFKLNND? LEIAKCBPPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000290")]
	[IgnoreDataMember]
	public Guid CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x71C5D40", Offset = "0x71C4F40", VA = "0x1871C5D40", Slot = "5")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000291")]
	public HKNMNBNPHJB? FFLIIMKMDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000292")]
	public List<MCMAGLPIIOA>? CIONAHCFAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000293")]
	public DateTime? NEPEFAJNMBP
	{
		[Cpp2IlInjected.Token(Token = "0x600062A")]
		[Cpp2IlInjected.Address(RVA = "0x12A6210", Offset = "0x12A5410", VA = "0x1812A6210", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x12A62F0", Offset = "0x12A54F0", VA = "0x1812A62F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000294")]
	public DateTime? OBJCGFLKFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x1384310", Offset = "0x1383510", VA = "0x181384310", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x1384E50", Offset = "0x1384050", VA = "0x181384E50")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000295")]
	public DateTime? AINHHMMHILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0xD34EF0", Offset = "0xD340F0", VA = "0x180D34EF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x5856D00", Offset = "0x5855F00", VA = "0x185856D00")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000296")]
	public bool NIJJCPDGLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0xC09F90", Offset = "0xC09190", VA = "0x180C09F90", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0xC09740", Offset = "0xC08940", VA = "0x180C09740")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000297")]
	public bool OHJFANOAMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x10D1C10", Offset = "0x10D0E10", VA = "0x1810D1C10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000633")]
		[Cpp2IlInjected.Address(RVA = "0x10D1C20", Offset = "0x10D0E20", VA = "0x1810D1C20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000298")]
	public bool FBCKILNFHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0xEBEEA0", Offset = "0xEBE0A0", VA = "0x180EBEEA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x15547B0", Offset = "0x15539B0", VA = "0x1815547B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000299")]
	public bool BLHPOCHMOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0xEB96B0", Offset = "0xEB88B0", VA = "0x180EB96B0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0xEBD4A0", Offset = "0xEBC6A0", VA = "0x180EBD4A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x71C5B00", Offset = "0x71C4D00", VA = "0x1871C5B00")]
	public static OBNDCIGENOG GFMGCOLAOEO(Guid NFCMKJPGKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public OBNDCIGENOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
[DBAGFLHDBHH]
public class MMLDIIDECPP
{
	[Cpp2IlInjected.Token(Token = "0x1700029A")]
	public int EAJOLKMOCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029B")]
	public string MFMGGFFPFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029C")]
	public string ICKJEFKLOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029D")]
	public Dictionary<int, BDHJFOJDJIL> COIGHIBBBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029E")]
	public Dictionary<string, int> MNAIKPPEPAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700029F")]
	public Dictionary<OFMLOFNIPDK, List<int>> DIPEEBPGCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A0")]
	public Dictionary<string, string> LDFLMGLDAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MMLDIIDECPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public enum OFMLOFNIPDK
{
	[Cpp2IlInjected.Token(Token = "0x400044E")]
	DetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	SignUpScreen,
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	ManageMembershipScreen,
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	ItemDetailsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	ActivityRewardsScreen,
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	RoomPublishUpsell
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
[DBAGFLHDBHH]
public class BDHJFOJDJIL : INHLFCLKHAM
{
	[Cpp2IlInjected.Token(Token = "0x170002A1")]
	public IBKBPFELIAH FAKPHDDDHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(IBKBPFELIAH);
		}
		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A2")]
	public bool HBJKAAKMBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x113F3B0", Offset = "0x113E5B0", VA = "0x18113F3B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x136ED10", Offset = "0x136DF10", VA = "0x18136ED10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A3")]
	public bool ADFHNMEFNIG
	{
		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x1D80740", Offset = "0x1D7F940", VA = "0x181D80740")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x1D805E0", Offset = "0x1D7F7E0", VA = "0x181D805E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A4")]
	public string LBECAMCNEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A5")]
	public string JELFCDGEPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A6")]
	public string GNIJCNDGBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A7")]
	public string GPDOFIDEMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002A8")]
	public Dictionary<OHGJBEJJKAO, string> KFMIGCAHDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x136ED60", Offset = "0x136DF60", VA = "0x18136ED60")]
	public BDHJFOJDJIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
[DBAGFLHDBHH]
public class CFBPHHGDJJO : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170002A9")]
	public IReadOnlyList<CBOPCFKLNND>? CNIDAMELIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CFBPHHGDJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public CFBPHHGDJJO(IReadOnlyList<CBOPCFKLNND>? GOFHHJFDBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065E")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public enum JNLJMCFKGBP
{
	[Cpp2IlInjected.Token(Token = "0x400045E")]
	Unspecified = -1,
	[Cpp2IlInjected.Token(Token = "0x400045F")]
	XP,
	[Cpp2IlInjected.Token(Token = "0x4000460")]
	OutfitItem,
	[Cpp2IlInjected.Token(Token = "0x4000461")]
	Equipment,
	[Cpp2IlInjected.Token(Token = "0x4000462")]
	Currency,
	[Cpp2IlInjected.Token(Token = "0x4000463")]
	Consumable,
	[Cpp2IlInjected.Token(Token = "0x4000464")]
	Query,
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	HairDye
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface IKCLLFELIOF
{
	[Cpp2IlInjected.Token(Token = "0x170002AA")]
	Guid CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AB")]
	HKNMNBNPHJB? FFLIIMKMDFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AC")]
	List<MCMAGLPIIOA>? CIONAHCFAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AD")]
	DateTime? NEPEFAJNMBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AE")]
	DateTime? OBJCGFLKFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002AF")]
	DateTime? AINHHMMHILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B0")]
	bool NIJJCPDGLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B1")]
	bool FBCKILNFHLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B2")]
	bool BLHPOCHMOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface CJEGBMAINCF
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action NGNILMCGFPO;

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BOAKAEHMOLN(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task FFMHKIOCKKO(CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JBEKIMILCBA([Out] DABFDPBCGCB EPCCHCFNMNH);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface DABFDPBCGCB
{
	[Cpp2IlInjected.Token(Token = "0x170002B3")]
	string MFMGGFFPFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B4")]
	string ICKJEFKLOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B5")]
	IReadOnlyDictionary<OFMLOFNIPDK, IReadOnlyList<INHLFCLKHAM>> BFNMFOFNMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B6")]
	IReadOnlyDictionary<string, string> LDFLMGLDAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000670")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface INHLFCLKHAM
{
	[Cpp2IlInjected.Token(Token = "0x170002B7")]
	string JELFCDGEPOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B8")]
	string LBECAMCNEGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002B9")]
	string GNIJCNDGBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BA")]
	string GPDOFIDEMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public interface JMGCHNCFNHB
{
	[Cpp2IlInjected.Token(Token = "0x170002BB")]
	GGLHPEALCFJ MBNHPGJCJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BC")]
	string CCDGCEMKGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BD")]
	string GKPIDFDNOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BE")]
	string JNOKIOJEPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002BF")]
	bool BLHPOCHMOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C0")]
	bool FBCKILNFHLH
	{
		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C1")]
	NKIINHMBKEE EIGCEEILHNM
	{
		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C2")]
	string GPKEBBMOJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C3")]
	MDBCGJONPIJ? APFFBAOJGJD
	{
		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C4")]
	JNLJMCFKGBP PEDDJMMBPDD
	{
		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002C5")]
	bool LIANLPCBJOE
	{
		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
[DBAGFLHDBHH]
public class HKNMNBNPHJB : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170002C6")]
	public GGLHPEALCFJ AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(GGLHPEALCFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C7")]
	public int? NCMBIKDEGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0xEDE690", Offset = "0xEDD890", VA = "0x180EDE690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xEE7570", Offset = "0xEE6770", VA = "0x180EE7570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002C8")]
	public Guid? FCLMLMMKKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F8740", VA = "0x1809F9540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x9F9580", Offset = "0x9F8780", VA = "0x1809F9580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000686")]
	[Cpp2IlInjected.Address(RVA = "0x71C2A00", Offset = "0x71C1C00", VA = "0x1871C2A00")]
	public static HKNMNBNPHJB DALGMCDMLMG(int EFCDCBJBHHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000687")]
	[Cpp2IlInjected.Address(RVA = "0x71C2940", Offset = "0x71C1B40", VA = "0x1871C2940")]
	public static HKNMNBNPHJB CFAILJJJHPA(Guid NFCMKJPGKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000688")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HKNMNBNPHJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public enum GGLHPEALCFJ
{
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	PurchasableItem,
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	CustomAvatarItem
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
[DBAGFLHDBHH]
public class MCMAGLPIIOA : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170002C9")]
	public CIHMKPKBLFN JLBDCKJMMIL
	{
		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(CIHMKPKBLFN);
		}
		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CA")]
	public int MNLAMBOMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0xB834E0", Offset = "0xB826E0", VA = "0x180B834E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0xC65020", Offset = "0xC64220", VA = "0x180C65020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CB")]
	public LLDDHHLPMOM NMCAPCEDDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0xEB70D0", Offset = "0xEB62D0", VA = "0x180EB70D0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x71C4D90", Offset = "0x71C3F90", VA = "0x1871C4D90")]
	public int MKCDKCPAEAG(DateTime KEIJCGKHOOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MCMAGLPIIOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
[DBAGFLHDBHH]
public class LLDDHHLPMOM : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170002CC")]
	public int PLILJBHCBLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000694")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CD")]
	public DateTime? EDNMKMLOMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0xDD6D20", Offset = "0xDD5F20", VA = "0x180DD6D20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002CE")]
	public DateTime? BADPHCAFLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(RVA = "0x12A6210", Offset = "0x12A5410", VA = "0x1812A6210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x12A62F0", Offset = "0x12A54F0", VA = "0x1812A62F0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x71C4450", Offset = "0x71C3650", VA = "0x1871C4450")]
	public bool IFKIPOECBLM(DateTime KEIJCGKHOOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x71C4630", Offset = "0x71C3830", VA = "0x1871C4630")]
	public int OHBHHHFLMLE(DateTime KEIJCGKHOOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x71C4540", Offset = "0x71C3740", VA = "0x1871C4540")]
	public TimeSpan? NLAELGHCJAC(DateTime KEIJCGKHOOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public LLDDHHLPMOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public enum DAJCBAEDADB
{
	[Cpp2IlInjected.Token(Token = "0x4000473")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000474")]
	LaserTag = 1,
	[Cpp2IlInjected.Token(Token = "0x4000475")]
	RecCenter = 2,
	[Cpp2IlInjected.Token(Token = "0x4000476")]
	Watch = 3,
	[Cpp2IlInjected.Token(Token = "0x4000477")]
	Quest_LostSkulls = 100,
	[Cpp2IlInjected.Token(Token = "0x4000478")]
	Quest_Dracula = 101,
	[Cpp2IlInjected.Token(Token = "0x4000479")]
	Quest_GoldenTrophy = 102,
	[Cpp2IlInjected.Token(Token = "0x400047A")]
	Quest_CrimsonCauldron = 103,
	[Cpp2IlInjected.Token(Token = "0x400047B")]
	RecRoyale = 200,
	[Cpp2IlInjected.Token(Token = "0x400047C")]
	Cafe = 300,
	[Cpp2IlInjected.Token(Token = "0x400047D")]
	Paintball = 400,
	[Cpp2IlInjected.Token(Token = "0x400047E")]
	Paintball_River = 401,
	[Cpp2IlInjected.Token(Token = "0x400047F")]
	Paintball_Homestead = 402,
	[Cpp2IlInjected.Token(Token = "0x4000480")]
	Paintball_Quarry = 403,
	[Cpp2IlInjected.Token(Token = "0x4000481")]
	Paintball_ClearCut = 404,
	[Cpp2IlInjected.Token(Token = "0x4000482")]
	Paintball_Spillway = 405,
	[Cpp2IlInjected.Token(Token = "0x4000483")]
	Paintball_SunsetDriveIn = 406,
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	Bowling = 500,
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	StuntRunner = 600,
	[Cpp2IlInjected.Token(Token = "0x4000486")]
	DormMirror = 700,
	[Cpp2IlInjected.Token(Token = "0x4000487")]
	InventionStore = 800,
	[Cpp2IlInjected.Token(Token = "0x4000488")]
	RoomKeys = 900,
	[Cpp2IlInjected.Token(Token = "0x4000489")]
	Player_Profile = 1000,
	[Cpp2IlInjected.Token(Token = "0x400048A")]
	Room_Save = 1100,
	[Cpp2IlInjected.Token(Token = "0x400048B")]
	RoomCurrencies = 1200,
	[Cpp2IlInjected.Token(Token = "0x400048C")]
	Wishlist = 1300,
	[Cpp2IlInjected.Token(Token = "0x400048D")]
	Friendotron = 1400,
	[Cpp2IlInjected.Token(Token = "0x400048E")]
	RoomConsumables = 1500,
	[Cpp2IlInjected.Token(Token = "0x400048F")]
	RecRally = 1600,
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	PopUpShop_1 = 1700,
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	PopUpShop_2 = 1701,
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	PopUpShop_3 = 1702,
	[Cpp2IlInjected.Token(Token = "0x4000493")]
	PopUpShop_4 = 1703,
	[Cpp2IlInjected.Token(Token = "0x4000494")]
	PopUpShop_5 = 1704,
	[Cpp2IlInjected.Token(Token = "0x4000495")]
	PopUpShop_6 = 1705,
	[Cpp2IlInjected.Token(Token = "0x4000496")]
	PopUpShop_7 = 1706,
	[Cpp2IlInjected.Token(Token = "0x4000497")]
	PopUpShop_8 = 1707,
	[Cpp2IlInjected.Token(Token = "0x4000498")]
	PopUpShop_9 = 1708,
	[Cpp2IlInjected.Token(Token = "0x4000499")]
	PopUpShop_10 = 1709,
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	PopUpShop_11 = 1710,
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	PopUpShop_12 = 1711,
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	PopUpShop_13 = 1712,
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	PopUpShop_14 = 1713,
	[Cpp2IlInjected.Token(Token = "0x400049E")]
	PopUpShop_15 = 1714,
	[Cpp2IlInjected.Token(Token = "0x400049F")]
	PopUpShop_16 = 1715,
	[Cpp2IlInjected.Token(Token = "0x40004A0")]
	PopUpShop_17 = 1716,
	[Cpp2IlInjected.Token(Token = "0x40004A1")]
	PopUpShop_18 = 1717,
	[Cpp2IlInjected.Token(Token = "0x40004A2")]
	PopUpShop_19 = 1718,
	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	PopUpShop_20 = 1719,
	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	CustomAvatarItems = 1800,
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	ProgressionEventPurchasableXpBoosts = 1900,
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	PopUpShop_ProgressionEvent_1 = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	PopUpShop_ProgressionEvent_2 = 2001,
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	PopUpShop_ProgressionEvent_3 = 2002,
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	PopUpShop_ProgressionEvent_4 = 2003,
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	PopUpShop_ProgressionEvent_5 = 2004,
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	RoomOffers = 2100,
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	MyLittleMonsters = 2200,
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	Destiny = 2201,
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	RunTheBlock = 2202,
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	RROStorefront_ToBeNamed_2 = 2203,
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	DevStorefront_DoNotAddToWatch_1 = 2300,
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	DevStorefront_DoNotAddToWatch_2 = 2301,
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	DevStorefront_DoNotAddToWatch_3 = 2302,
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	DevStorefront_DoNotAddToWatch_4 = 2303,
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	DevStorefront_DoNotAddToWatch_5 = 2304
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public enum DHCKCLDMMPM
{
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	GiftDrop,
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	SeasonTier,
	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	SeasonEliteUpgrade
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public enum EPLHOPDIFAB
{
	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	Invalid = 0,
	[Cpp2IlInjected.Token(Token = "0x40004BB")]
	DirectBalanceWithMultiplier = 1,
	[Cpp2IlInjected.Token(Token = "0x40004BC")]
	FromGiftBox = 2,
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	NUXChallenge = 10,
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	AllNUXChallenges = 11,
	[Cpp2IlInjected.Token(Token = "0x40004BF")]
	DailyChallenge = 100,
	[Cpp2IlInjected.Token(Token = "0x40004C0")]
	AllDailyChallenges = 101,
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	FinishActivity = 200,
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	RecRoyaleMatchFinished = 250,
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	ChecklistCredit = 303,
	[Cpp2IlInjected.Token(Token = "0x40004C4")]
	WonGame = 1000,
	[Cpp2IlInjected.Token(Token = "0x40004C5")]
	LostGame = 1001,
	[Cpp2IlInjected.Token(Token = "0x40004C6")]
	WonGameRateLimited = 1002,
	[Cpp2IlInjected.Token(Token = "0x40004C7")]
	WonGamePartial = 1003,
	[Cpp2IlInjected.Token(Token = "0x40004C8")]
	LevelUp = 1100,
	[Cpp2IlInjected.Token(Token = "0x40004C9")]
	Registered = 1200,
	[Cpp2IlInjected.Token(Token = "0x40004CA")]
	CreatorReward = 1300,
	[Cpp2IlInjected.Token(Token = "0x40004CB")]
	CommercePurchase = 1400,
	[Cpp2IlInjected.Token(Token = "0x40004CC")]
	CommercePurchaseRevoked = 1401,
	[Cpp2IlInjected.Token(Token = "0x40004CD")]
	Manual_Refund = 2000,
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	Manual_Thanks = 2010,
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	Manual_Apology = 2020,
	[Cpp2IlInjected.Token(Token = "0x40004D0")]
	TestOnly = 8000
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public enum MCLDJLMOOIE
{
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	Interval,
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	PerDay
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public enum NKOFIJDPEMB
{
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	PERCENTAGE = 1,
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	EXACT_AMOUNT
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
[DBAGFLHDBHH]
public class FALNAGGKLEC : IEquatable<FALNAGGKLEC>
{
	[Cpp2IlInjected.Token(Token = "0x170002CF")]
	public int? PPOKLEGIJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D0")]
	public int? CPOBCALBJPK
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0xC65010", Offset = "0xC64210", VA = "0x180C65010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D1")]
	public int? NAHIEJLKNDE
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xCBAC80", Offset = "0xCB9E80", VA = "0x180CBAC80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D2")]
	public List<int>? HCHCHNPJMKI
	{
		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x71C1290", Offset = "0x71C0490", VA = "0x1871C1290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x71C1230", Offset = "0x71C0430", VA = "0x1871C1230")]
	public static FALNAGGKLEC LMCGPCGDDCC(int? KFAJDOCDNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x71C0ED0", Offset = "0x71C00D0", VA = "0x1871C0ED0", Slot = "4")]
	public bool Equals(FALNAGGKLEC? FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x71C0C00", Offset = "0x71BFE00", VA = "0x1871C0C00")]
	private static bool ADNMDLBDEAK(List<int>? FCKEKMKDGOB, List<int>? PMDPDEMGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x71C0CA0", Offset = "0x71BFEA0", VA = "0x1871C0CA0", Slot = "0")]
	public override bool Equals(object? DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x71C1050", Offset = "0x71C0250", VA = "0x1871C1050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FALNAGGKLEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public struct OCLLJFMDPPK : IEquatable<OCLLJFMDPPK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly GGLHPEALCFJ MBNHPGJCJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private readonly int NCMBIKDEGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	private readonly Guid FCLMLMMKKNH;

	[Cpp2IlInjected.Token(Token = "0x170002D3")]
	public Guid CHOEJPKBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x71C6250", Offset = "0x71C5450", VA = "0x1871C6250")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D4")]
	public int ADEHAIPNBPO
	{
		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x71C5ED0", Offset = "0x71C50D0", VA = "0x1871C5ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D5")]
	public string DCCKFBFCPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x71C6170", Offset = "0x71C5370", VA = "0x1871C6170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x71C6410", Offset = "0x71C5610", VA = "0x1871C6410")]
	public static bool ONGMIMEBEHB(string NFEAHFMGOCB, [Out] OCLLJFMDPPK ALAFLBBKKIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x71C5EE0", Offset = "0x71C50E0", VA = "0x1871C5EE0")]
	public static OCLLJFMDPPK COBAKHMBIGH(int MKHHKDJKLDN)
	{
		return default(OCLLJFMDPPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x71C62C0", Offset = "0x71C54C0", VA = "0x1871C62C0")]
	public static OCLLJFMDPPK JHINJKNLGJB(Guid MKHHKDJKLDN)
	{
		return default(OCLLJFMDPPK);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(RVA = "0x71C5DC0", Offset = "0x71C4FC0", VA = "0x1871C5DC0")]
	private static bool AIKEPIPAOMP(string NFEAHFMGOCB, [Out] GGLHPEALCFJ BGHEDGKBAFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(RVA = "0x71C6900", Offset = "0x71C5B00", VA = "0x1871C6900")]
	private OCLLJFMDPPK(GGLHPEALCFJ BGHEDGKBAFJ, int? AFJJMBEEKDJ, Guid? NFCMKJPGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(RVA = "0x71C6100", Offset = "0x71C5300", VA = "0x1871C6100", Slot = "4")]
	public bool Equals(OCLLJFMDPPK FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(RVA = "0x71C6010", Offset = "0x71C5210", VA = "0x1871C6010", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B7")]
	[Cpp2IlInjected.Address(RVA = "0x71C61C0", Offset = "0x71C53C0", VA = "0x1871C61C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006B8")]
	[Cpp2IlInjected.Address(RVA = "0x71C6850", Offset = "0x71C5A50", VA = "0x1871C6850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
[DBAGFLHDBHH]
public abstract class JEAKBKHNFMG : IEquatable<JEAKBKHNFMG>, EDDGMJLBELL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public Guid PJEBGIFFKDF;

	[Cpp2IlInjected.Token(Token = "0x60006B9")]
	[Cpp2IlInjected.Address(RVA = "0x71C2FD0", Offset = "0x71C21D0", VA = "0x1871C2FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x71C2F50", Offset = "0x71C2150", VA = "0x1871C2F50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BB")]
	[Cpp2IlInjected.Address(RVA = "0x71BE180", Offset = "0x71BD380", VA = "0x1871BE180", Slot = "4")]
	public bool Equals(JEAKBKHNFMG FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BC")]
	[Cpp2IlInjected.Address(RVA = "0x71C2E30", Offset = "0x71C2030", VA = "0x1871C2E30", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract JEAKBKHNFMG GIAPJGILOPE();

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected JEAKBKHNFMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public enum DIIAKBNIPAF
{
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	RoomKey,
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	RoomConsumable,
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	RoomCurrencyPurchaseOffer,
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	CustomAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	StoreUGCAvatarItem,
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	UNDEFINED
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
[DBAGFLHDBHH]
public class CBOPCFKLNND : JEAKBKHNFMG, IEquatable<CBOPCFKLNND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	public DIIAKBNIPAF BGHEDGKBAFJ;

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x71BED50", Offset = "0x71BDF50", VA = "0x1871BED50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x71BEC60", Offset = "0x71BDE60", VA = "0x1871BEC60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CBOPCFKLNND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x71BEDF0", Offset = "0x71BDFF0", VA = "0x1871BEDF0")]
	public CBOPCFKLNND(DIIAKBNIPAF BGHEDGKBAFJ, Guid PJEBGIFFKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x71BECE0", Offset = "0x71BDEE0", VA = "0x1871BECE0")]
	public static CBOPCFKLNND JHINJKNLGJB(Guid FCGPCABMNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x71BEBA0", Offset = "0x71BDDA0", VA = "0x1871BEBA0", Slot = "7")]
	public bool Equals(CBOPCFKLNND FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0x71BEBF0", Offset = "0x71BDDF0", VA = "0x1871BEBF0", Slot = "6")]
	public override JEAKBKHNFMG GIAPJGILOPE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public static class DLIINIFBCIN
{
	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x71BFF50", Offset = "0x71BF150", VA = "0x1871BFF50")]
	public static CBOPCFKLNND GGKCIIOKDCJ(this LOEEOHOEJMC CKEIAGIGCJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x71BFFC0", Offset = "0x71BF1C0", VA = "0x1871BFFC0")]
	public static CBOPCFKLNND HIKPPIMIIBN(string HCLAMDNFPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x71BFEE0", Offset = "0x71BF0E0", VA = "0x1871BFEE0")]
	public static CBOPCFKLNND APHCPDIONED(Guid GPHKHMHENGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
[DBAGFLHDBHH]
public class LOEEOHOEJMC : OCPIHIKNAGF, EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170002D6")]
	public DIIAKBNIPAF MBNHPGJCJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(DIIAKBNIPAF);
		}
		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D7")]
	public Guid LEIAKCBPPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006CC")]
		[Cpp2IlInjected.Address(RVA = "0x18E5C10", Offset = "0x18E4E10", VA = "0x1818E5C10")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0x585A3A0", Offset = "0x58595A0", VA = "0x18585A3A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D8")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002D9")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DA")]
	public string EOLKJMPOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DB")]
	public long? IDAIGHAHCBA
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xED4410", Offset = "0xED3610", VA = "0x180ED4410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xED4400", Offset = "0xED3600", VA = "0x180ED4400")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DC")]
	public long MNLAMBOMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xE2D910", Offset = "0xE2CB10", VA = "0x180E2D910")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DD")]
	public Guid? AIIBFBOMJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x71C47F0", Offset = "0x71C39F0", VA = "0x1871C47F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x71C4810", Offset = "0x71C3A10", VA = "0x1871C4810")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DE")]
	public DateTime JOAFFIOMGFM
	{
		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F3280", Offset = "0x9F2480", VA = "0x1809F3280")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0xE75370", Offset = "0xE74570", VA = "0x180E75370")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002DF")]
	public DateTime IKGJDBNACMI
	{
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8670", VA = "0x1809F9470")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0xE75340", Offset = "0xE74540", VA = "0x180E75340")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public LOEEOHOEJMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x71C48D0", Offset = "0x71C3AD0", VA = "0x1871C48D0")]
	public LOEEOHOEJMC(DIIAKBNIPAF BGHEDGKBAFJ, Guid PJEBGIFFKDF, [Optional] string DGIAFBEDPNJ, [Optional] string CMDDDPOOGFO, [Optional] string GGCHPOGNGCI, [Optional] long? BENLNHBBIME, long CDLHEIHGPNH = 0L, [Optional] Guid? ONLAJEBNDIC, [Optional] DateTime OFDMKGELPHL, [Optional] DateTime IONJONLKHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E1")]
	[Cpp2IlInjected.Address(RVA = "0x71C4820", Offset = "0x71C3A20", VA = "0x1871C4820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public enum KKAHILCAKHN
{
	[Cpp2IlInjected.Token(Token = "0x40004F2")]
	General,
	[Cpp2IlInjected.Token(Token = "0x40004F3")]
	Auto,
	[Cpp2IlInjected.Token(Token = "0x40004F4")]
	AGOnly,
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	Banned
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public enum KGGBPFOLKBL
{
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	Success,
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	TooManyTags,
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	TagUseRestricted,
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	InvalidTag,
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	InappropriateTag,
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	TagTooLong,
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	TagNotFound,
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	TagAlreadyExists,
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	NoChange,
	[Cpp2IlInjected.Token(Token = "0x4000500")]
	TagRepeated,
	[Cpp2IlInjected.Token(Token = "0x4000501")]
	LacksPermission,
	[Cpp2IlInjected.Token(Token = "0x4000502")]
	RoomDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000503")]
	InventionDoesNotExist,
	[Cpp2IlInjected.Token(Token = "0x4000504")]
	ReservedWordViolation
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
[DBAGFLHDBHH]
public class PGFBBLHHHPI : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170002E0")]
	public KGGBPFOLKBL JPOOALJFOCK
	{
		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(KGGBPFOLKBL);
		}
		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E1")]
	public List<string> LKFBICNBCEE
	{
		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E7")]
	[Cpp2IlInjected.Address(RVA = "0x71C7550", Offset = "0x71C6750", VA = "0x1871C7550")]
	public string JACEACGDNMO(int LEFKHMMENHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E8")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public PGFBBLHHHPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
[DBAGFLHDBHH]
public class DKLEEOBOOCG : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170002E2")]
	public string MAKNAOCMPEP
	{
		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E3")]
	public KKAHILCAKHN AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		[CompilerGenerated]
		get
		{
			return default(KKAHILCAKHN);
		}
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DKLEEOBOOCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000111")]
public static class FBIGEADFKDC
{
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	public const string MLLCHCBHDIB = "costume";

	[Cpp2IlInjected.Token(Token = "0x400050A")]
	public const string LLGPNJMCJDE = "gadget";

	[Cpp2IlInjected.Token(Token = "0x400050B")]
	public const string PCBPJPMEDHM = "holotar";

	[Cpp2IlInjected.Token(Token = "0x400050C")]
	public const string PLPAHLDLCMN = "large";

	[Cpp2IlInjected.Token(Token = "0x400050D")]
	public const string HHAFBDLKKGH = "medium";

	[Cpp2IlInjected.Token(Token = "0x400050E")]
	public const string OMKJJMMEIFE = "small";

	[Cpp2IlInjected.Token(Token = "0x400050F")]
	public const string JGHNDCMBPOE = "sound";

	[Cpp2IlInjected.Token(Token = "0x4000510")]
	public const string PGHPHIMCKCN = "dormanchor";

	[Cpp2IlInjected.Token(Token = "0x4000511")]
	public const string MEPADDBAONI = "reccenteranchor";

	[Cpp2IlInjected.Token(Token = "0x4000512")]
	public const string PLHPAOLGICP = "r2";

	[Cpp2IlInjected.Token(Token = "0x170002E4")]
	public static List<string> PLKGGBACIHP
	{
		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x71C1400", Offset = "0x71C0600", VA = "0x1871C1400")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000112")]
public static class OJDCMJBHAMM
{
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	public const string KKKKNGJFOOK = "beta";

	[Cpp2IlInjected.Token(Token = "0x4000514")]
	public const string IAIDNPOLIAG = "limitsv2";
}
[Cpp2IlInjected.Token(Token = "0x2000113")]
[DBAGFLHDBHH]
public class HBGOFOEHLIE : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170002E5")]
	public List<string> JHLHFKKGAIF
	{
		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E6")]
	public List<string> GNEOAAJNHEE
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E7")]
	public List<string> EMLLONAODBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HBGOFOEHLIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
public class POPPIBDDFLI : IEquatable<POPPIBDDFLI>
{
	[Cpp2IlInjected.Token(Token = "0x170002E8")]
	protected virtual Type CDJPHOOCGDK
	{
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x71C7D80", Offset = "0x71C6F80", VA = "0x1871C7D80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002E9")]
	public BKCHBBCPJCA? JBCDAOLNABL
	{
		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EA")]
	public HttpMethod? GOIDHDJJOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EB")]
	public string? NMNOCLPDLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x71C7FE0", Offset = "0x71C71E0", VA = "0x1871C7FE0")]
	public POPPIBDDFLI(BKCHBBCPJCA? JBCDAOLNABL, HttpMethod? GOIDHDJJOMH, string? NMNOCLPDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x71C7E70", Offset = "0x71C7070", VA = "0x1871C7E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000701")]
	[Cpp2IlInjected.Address(RVA = "0x71C7850", Offset = "0x71C6A50", VA = "0x1871C7850", Slot = "6")]
	protected virtual bool BCOHOGBGCPL(StringBuilder IBLPFKMMCPG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000702")]
	[Cpp2IlInjected.Address(RVA = "0xEFE1C0", Offset = "0xEFD3C0", VA = "0x180EFE1C0")]
	public static bool EFJOOJHLAGB(POPPIBDDFLI? ANJBDIMHCCG, POPPIBDDFLI? DPPBJFDHFOC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000703")]
	[Cpp2IlInjected.Address(RVA = "0xEFE190", Offset = "0xEFD390", VA = "0x180EFE190")]
	public static bool NDBPPCEOMJH(POPPIBDDFLI? ANJBDIMHCCG, POPPIBDDFLI? DPPBJFDHFOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000704")]
	[Cpp2IlInjected.Address(RVA = "0x71C7C10", Offset = "0x71C6E10", VA = "0x1871C7C10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000705")]
	[Cpp2IlInjected.Address(RVA = "0x71C7B80", Offset = "0x71C6D80", VA = "0x1871C7B80", Slot = "0")]
	public override bool Equals(object? DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000706")]
	[Cpp2IlInjected.Address(RVA = "0x71C79F0", Offset = "0x71C6BF0", VA = "0x1871C79F0", Slot = "7")]
	public virtual bool Equals(POPPIBDDFLI? FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000707")]
	[Cpp2IlInjected.Address(RVA = "0x71C7DE0", Offset = "0x71C6FE0", VA = "0x1871C7DE0", Slot = "8")]
	public virtual POPPIBDDFLI OKHPFCENAGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x71C7F80", Offset = "0x71C7180", VA = "0x1871C7F80")]
	protected POPPIBDDFLI(POPPIBDDFLI DCCCEFOFIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x71C79B0", Offset = "0x71C6BB0", VA = "0x1871C79B0")]
	public void EFFIMEDBJAK([Out] BKCHBBCPJCA? JBCDAOLNABL, [Out] HttpMethod? GOIDHDJJOMH, [Out] string? NMNOCLPDLFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public class PEDOCMICNMM : IEquatable<PEDOCMICNMM>
{
	[Cpp2IlInjected.Token(Token = "0x170002EC")]
	protected virtual Type CDJPHOOCGDK
	{
		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x71C70D0", Offset = "0x71C62D0", VA = "0x1871C70D0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002ED")]
	public int EKGMMLIKONC
	{
		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002EE")]
	public JAJDPGNKFGD DBCOFAHCFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xB834E0", Offset = "0xB826E0", VA = "0x180B834E0")]
		[CompilerGenerated]
		get
		{
			return default(JAJDPGNKFGD);
		}
		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xC65020", Offset = "0xC64220", VA = "0x180C65020")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x71C72B0", Offset = "0x71C64B0", VA = "0x1871C72B0")]
	public PEDOCMICNMM(int EKGMMLIKONC, JAJDPGNKFGD DBCOFAHCFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x71C71A0", Offset = "0x71C63A0", VA = "0x1871C71A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x71C6CB0", Offset = "0x71C5EB0", VA = "0x1871C6CB0", Slot = "6")]
	protected virtual bool BCOHOGBGCPL(StringBuilder IBLPFKMMCPG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xEFE1C0", Offset = "0xEFD3C0", VA = "0x180EFE1C0")]
	public static bool EFJOOJHLAGB(PEDOCMICNMM? ANJBDIMHCCG, PEDOCMICNMM? DPPBJFDHFOC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000713")]
	[Cpp2IlInjected.Address(RVA = "0xEFE190", Offset = "0xEFD390", VA = "0x180EFE190")]
	public static bool NDBPPCEOMJH(PEDOCMICNMM? ANJBDIMHCCG, PEDOCMICNMM? DPPBJFDHFOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000714")]
	[Cpp2IlInjected.Address(RVA = "0x71C6FC0", Offset = "0x71C61C0", VA = "0x1871C6FC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000715")]
	[Cpp2IlInjected.Address(RVA = "0x71C6F30", Offset = "0x71C6130", VA = "0x1871C6F30", Slot = "0")]
	public override bool Equals(object? DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000716")]
	[Cpp2IlInjected.Address(RVA = "0x71C6DF0", Offset = "0x71C5FF0", VA = "0x1871C6DF0", Slot = "7")]
	public virtual bool Equals(PEDOCMICNMM? FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000717")]
	[Cpp2IlInjected.Address(RVA = "0x71C7130", Offset = "0x71C6330", VA = "0x1871C7130", Slot = "8")]
	public virtual PEDOCMICNMM OKHPFCENAGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000718")]
	[Cpp2IlInjected.Address(RVA = "0xB83600", Offset = "0xB82800", VA = "0x180B83600")]
	protected PEDOCMICNMM(PEDOCMICNMM DCCCEFOFIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000719")]
	[Cpp2IlInjected.Address(RVA = "0x71C6DE0", Offset = "0x71C5FE0", VA = "0x1871C6DE0")]
	public void EFFIMEDBJAK([Out] int EKGMMLIKONC, [Out] JAJDPGNKFGD DBCOFAHCFAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public enum JAJDPGNKFGD
{
	[Cpp2IlInjected.Token(Token = "0x400051E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	ConnectionTimeout,
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	InternalServerError
}
[Cpp2IlInjected.Token(Token = "0x2000117")]
public interface JCDNGFPJEHN
{
	[Cpp2IlInjected.Token(Token = "0x600071A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyDictionary<POPPIBDDFLI, PEDOCMICNMM> IBALMGLKFEJ();

	[Cpp2IlInjected.Token(Token = "0x600071B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFJCADMBDCH(POPPIBDDFLI AGBHGDFILGO, PEDOCMICNMM HDKINMMJOHF);

	[Cpp2IlInjected.Token(Token = "0x600071C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGNJFEFCNNF(POPPIBDDFLI AGBHGDFILGO);

	[Cpp2IlInjected.Token(Token = "0x600071D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INCIAEMLJLL();

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task NCIKKALDGIM(BKCHBBCPJCA JJHEMKLPAME, HttpMethod IPBOIENDBHP, string DNPCEGLLJIP, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[BHLBHLLEBBE]
public class KHJJFNOMMBL<TResult> where TResult : EDDGMJLBELL, new()
{
	[Cpp2IlInjected.Token(Token = "0x170002EF")]
	public IReadOnlyList<TResult> MMJKMOAIKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002F0")]
	public long KFMFODMNLFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xC65010", Offset = "0xC64210", VA = "0x180C65010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KHJJFNOMMBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
public enum PLHEFELFLFF
{
	[Cpp2IlInjected.Token(Token = "0x4000524")]
	Development = 1,
	[Cpp2IlInjected.Token(Token = "0x4000525")]
	QA = 8,
	[Cpp2IlInjected.Token(Token = "0x4000526")]
	Production = 0x100
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
public interface FAFNJCDEAHB : HBBMHOBICDC
{
	[Cpp2IlInjected.Token(Token = "0x170002F1")]
	bool NLGBAMFNDPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000724")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AuthorizePurchaseAsync(long OKMBDDMPEBJ, ICFCMLIKFOC GBBHMJBEIDC);

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<MIJBFIBBBEO> PurchaseAsync(ICFCMLIKFOC GBBHMJBEIDC, FALNAGGKLEC AGDHIAHIJAD);

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task ValidatePurchasingSupported(BJJNPIHKDCB KMFCGKCLLII, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
public interface HBBMHOBICDC
{
	[Cpp2IlInjected.Token(Token = "0x170002F2")]
	bool IABJDAIIKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<string> FetchCommerceAccessToken([Optional] CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
public interface BAJAPMNNKMD
{
	[Cpp2IlInjected.Token(Token = "0x170002F3")]
	int GCAPLODHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<ICFCMLIKFOC>> NBDICBFOMLH(bool LHLMOFLLJNF = false, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FFGNNMLLBND([Out] ICFCMLIKFOC? MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<ICFCMLIKFOC> EOHPNDKJJBC(bool LHLMOFLLJNF = false, [Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NGJKEKIFBKL(string BPAILNFLNFH = "");
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
public interface ONJBMCKGNDK
{
	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CIOELBGNEJH(BJJNPIHKDCB KMFCGKCLLII, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OELAGHPLEKF(BJJNPIHKDCB KMFCGKCLLII, CancellationToken HCELDNOKOAM, [Optional] DEFNGEOCNAD? LJFPLLAPOFI);
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
public interface DEFNGEOCNAD
{
	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHHCHINJKBC(string PGAPAABCDDF);
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
public interface KDDJOKMEFGI
{
	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KEKMLHNANAB(BJJNPIHKDCB FPLEPEKFFEF, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
public interface HOIMLEJGBMB
{
	[Cpp2IlInjected.Token(Token = "0x170002F4")]
	bool GCOBLOJKJHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
public interface BOIHHGNKNHH
{
	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BJJNPIHKDCB NEMNCOCIAMO(ICFCMLIKFOC GBBHMJBEIDC, FALNAGGKLEC AGDHIAHIJAD, string KDLHHEBNIHL, [Optional] ONJBMCKGNDK? HHDCPNAIDBC);
}
[Cpp2IlInjected.Token(Token = "0x2000122")]
public interface AFPGNCINEOI
{
	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DMINNOABHEL(KDDJOKMEFGI LKMFAJMIACB);

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NDJAAEJCJHB(KDDJOKMEFGI LKMFAJMIACB);

	[Cpp2IlInjected.Token(Token = "0x6000737")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BKMIGCOBLFD(BJJNPIHKDCB KMFCGKCLLII, CancellationToken HCELDNOKOAM);
}
[Cpp2IlInjected.Token(Token = "0x2000123")]
public interface BJJNPIHKDCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170002F5")]
	OMHCLIKOHPK AMJEAGJIGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002F6")]
	ICFCMLIKFOC ENCHNHIOBEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002F7")]
	FALNAGGKLEC FEGOKMEJGFP
	{
		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002F8")]
	string GNPHJOMMJAA
	{
		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170002F9")]
	string NDPAIOMBCMH
	{
		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600073D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<ILFPOKCPHBL> KICFOMOODGH(CancellationToken DMKDGAIEPFB, [Optional] DEFNGEOCNAD? LJFPLLAPOFI);

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DAIGIPFCHKL(string FNJOHGLGALB);

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DAIGIPFCHKL<T>(Func<T, string> FNJOHGLGALB, [In] T FFFFJFHODFG);
}
[Cpp2IlInjected.Token(Token = "0x2000124")]
public abstract class OBOBJCHNLOA
{
	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected OBOBJCHNLOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
public enum PGDJILDBKAF
{
	[Cpp2IlInjected.Token(Token = "0x4000528")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000529")]
	InAppPurchaseNotAllowedOnAccount,
	[Cpp2IlInjected.Token(Token = "0x400052A")]
	PlatformPurchaseException,
	[Cpp2IlInjected.Token(Token = "0x400052B")]
	PlatformPurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400052C")]
	CommerceInitiatePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400052D")]
	FailedToGetPlatformAccessToken,
	[Cpp2IlInjected.Token(Token = "0x400052E")]
	PlatformAuthorizePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x400052F")]
	CommerceCompletePurchaseFailure,
	[Cpp2IlInjected.Token(Token = "0x4000530")]
	PlatformSubscriptionNotSupported,
	[Cpp2IlInjected.Token(Token = "0x4000531")]
	PlatformPurchasesNotSupported,
	[Cpp2IlInjected.Token(Token = "0x4000532")]
	OculusDesktopPlayersMustBeInVR,
	[Cpp2IlInjected.Token(Token = "0x4000533")]
	FailedToRetrieveParentalControls,
	[Cpp2IlInjected.Token(Token = "0x4000534")]
	UserCanceled,
	[Cpp2IlInjected.Token(Token = "0x4000535")]
	DebugError
}
[Cpp2IlInjected.Token(Token = "0x2000126")]
public enum NAHIFGDCKPN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000537")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000538")]
	AccountError,
	[Cpp2IlInjected.Token(Token = "0x4000539")]
	PlatformError,
	[Cpp2IlInjected.Token(Token = "0x400053A")]
	CommerceError,
	[Cpp2IlInjected.Token(Token = "0x400053B")]
	UserAction
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
[DBAGFLHDBHH]
public class ICFCMLIKFOC : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x170002FA")]
	public int CADMOHFOLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FB")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FC")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FD")]
	public string EOLKJMPOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FE")]
	public int MNLAMBOMMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x9FD530", Offset = "0x9FC730", VA = "0x1809FD530")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x9FD8D0", Offset = "0x9FCAD0", VA = "0x1809FD8D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170002FF")]
	public string NJNGECMCLLI
	{
		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000300")]
	public string BKENKCABDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600074D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000301")]
	[DataMember(Name = "PsnProductLabel")]
	public string EAGIHBEFDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000302")]
	public string BCADHHFENPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000303")]
	public string JLMEBGMKECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000304")]
	public string FOCIJCFOCIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000755")]
		[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000305")]
	public string JHKLBIFOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000306")]
	public string OFNLHEOPMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x9F3280", Offset = "0x9F2480", VA = "0x1809F3280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0x9F3310", Offset = "0x9F2510", VA = "0x1809F3310")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000307")]
	public bool AELLNOBJINL
	{
		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0xC562B0", Offset = "0xC554B0", VA = "0x180C562B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0xC55B20", Offset = "0xC54D20", VA = "0x180C55B20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000308")]
	public bool OCIAOGPJIME
	{
		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x15D8760", Offset = "0x15D7960", VA = "0x1815D8760")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x15D8940", Offset = "0x15D7B40", VA = "0x1815D8940")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000309")]
	public PHHIBJMHCKI ALBEJFPMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x9F94E0", Offset = "0x9F86E0", VA = "0x1809F94E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x9F95B0", Offset = "0x9F87B0", VA = "0x1809F95B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030A")]
	[IgnoreDataMember]
	public string AEPOAOBLJFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x9F9460", Offset = "0x9F8660", VA = "0x1809F9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x9F94A0", Offset = "0x9F86A0", VA = "0x1809F94A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030B")]
	[IgnoreDataMember]
	public string EJNONMFBDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xBE1AD0", Offset = "0xBE0CD0", VA = "0x180BE1AD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x1316000", Offset = "0x1315200", VA = "0x181316000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030C")]
	[IgnoreDataMember]
	public string AAKKEFLHACN
	{
		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x9F9400", Offset = "0x9F8600", VA = "0x1809F9400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x9F94C0", Offset = "0x9F86C0", VA = "0x1809F94C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030D")]
	[IgnoreDataMember]
	public OBOBJCHNLOA MNLDOHAKGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xCDF180", Offset = "0xCDE380", VA = "0x180CDF180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xE62E80", Offset = "0xE62080", VA = "0x180E62E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030E")]
	[IgnoreDataMember]
	public bool MIKPBNAMPCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x71C2B90", Offset = "0x71C1D90", VA = "0x1871C2B90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700030F")]
	[IgnoreDataMember]
	public string KIGCMGCDCBP
	{
		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x9F8B10", Offset = "0x9F7D10", VA = "0x1809F8B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x9F8AD0", Offset = "0x9F7CD0", VA = "0x1809F8AD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600076C")]
	[Cpp2IlInjected.Address(RVA = "0x71C2AA0", Offset = "0x71C1CA0", VA = "0x1871C2AA0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600076D")]
	[Cpp2IlInjected.Address(RVA = "0x71C2BB0", Offset = "0x71C1DB0", VA = "0x1871C2BB0")]
	public static ICFCMLIKFOC LDCLNBFPLNF(int MKHHKDJKLDN, string DGIAFBEDPNJ, string GGCHPOGNGCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600076E")]
	[Cpp2IlInjected.Address(RVA = "0x71C2C50", Offset = "0x71C1E50", VA = "0x1871C2C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600076F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public ICFCMLIKFOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000128")]
[DBAGFLHDBHH]
public class PHHIBJMHCKI : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000310")]
	public List<int> OLGOFMKIFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000311")]
	public string FIKKCGNKHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000312")]
	public GKPMFMBHMOF AGPNKLHECGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000776")]
	[Cpp2IlInjected.Address(RVA = "0xEB70D0", Offset = "0xEB62D0", VA = "0x180EB70D0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000777")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public PHHIBJMHCKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000129")]
public readonly struct ILFPOKCPHBL
{
	[Cpp2IlInjected.Token(Token = "0x200012A")]
	public enum PEDGOGIMJKD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		CancelledByUser,
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		Success
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000554")]
	public readonly PEDGOGIMJKD DMCBBKIPEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000555")]
	public readonly NAHIFGDCKPN ADONFMMLHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000556")]
	public readonly PGDJILDBKAF DOHFIACIIBD;

	[Cpp2IlInjected.Token(Token = "0x6000778")]
	[Cpp2IlInjected.Address(RVA = "0x71C2D20", Offset = "0x71C1F20", VA = "0x1871C2D20")]
	private ILFPOKCPHBL(PEDGOGIMJKD HPAPEOOKLIH, NAHIFGDCKPN GBJMCGOGBDO = NAHIFGDCKPN.Unknown, PGDJILDBKAF MAEGNGBEODM = PGDJILDBKAF.Unknown)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000779")]
	[Cpp2IlInjected.Address(RVA = "0x71C2CE0", Offset = "0x71C1EE0", VA = "0x1871C2CE0")]
	public static ILFPOKCPHBL KDJBHGKCOBM()
	{
		return default(ILFPOKCPHBL);
	}

	[Cpp2IlInjected.Token(Token = "0x600077A")]
	[Cpp2IlInjected.Address(RVA = "0x71C2CC0", Offset = "0x71C1EC0", VA = "0x1871C2CC0")]
	public static ILFPOKCPHBL FIFDPDCDADE()
	{
		return default(ILFPOKCPHBL);
	}

	[Cpp2IlInjected.Token(Token = "0x600077B")]
	[Cpp2IlInjected.Address(RVA = "0x71C2D00", Offset = "0x71C1F00", VA = "0x1871C2D00")]
	public static ILFPOKCPHBL LAFFMJFIHDJ(NAHIFGDCKPN GBJMCGOGBDO, PGDJILDBKAF MAEGNGBEODM)
	{
		return default(ILFPOKCPHBL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200012B")]
public enum ILIBFAGEKAA
{
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	Gold,
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	Platinum
}
[Cpp2IlInjected.Token(Token = "0x200012C")]
public enum EHBEAIAADOK
{
	[Cpp2IlInjected.Token(Token = "0x400055F")]
	Month,
	[Cpp2IlInjected.Token(Token = "0x4000560")]
	Year,
	[Cpp2IlInjected.Token(Token = "0x4000561")]
	ThreeMonth,
	[Cpp2IlInjected.Token(Token = "0x4000562")]
	SixMonth
}
[Cpp2IlInjected.Token(Token = "0x200012D")]
[DBAGFLHDBHH]
public class GKPMFMBHMOF : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000313")]
	public ILIBFAGEKAA BAECBNPALCP
	{
		[Cpp2IlInjected.Token(Token = "0x600077C")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(ILIBFAGEKAA);
		}
		[Cpp2IlInjected.Token(Token = "0x600077D")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000314")]
	public EHBEAIAADOK IFNDKMBFGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0xB834E0", Offset = "0xB826E0", VA = "0x180B834E0")]
		[CompilerGenerated]
		get
		{
			return default(EHBEAIAADOK);
		}
		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0xC65020", Offset = "0xC64220", VA = "0x180C65020")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000315")]
	public bool GPHLBKGACNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0xAACFF0", Offset = "0xAAC1F0", VA = "0x180AACFF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000781")]
		[Cpp2IlInjected.Address(RVA = "0x9F8320", Offset = "0x9F7520", VA = "0x1809F8320")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000782")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000783")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GKPMFMBHMOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
public enum OMHCLIKOHPK
{
	[Cpp2IlInjected.Token(Token = "0x4000567")]
	Error = -2,
	[Cpp2IlInjected.Token(Token = "0x4000568")]
	Cancelled,
	[Cpp2IlInjected.Token(Token = "0x4000569")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x400056A")]
	AttemptStarted,
	[Cpp2IlInjected.Token(Token = "0x400056B")]
	PurchaseComplete
}
[Cpp2IlInjected.Token(Token = "0x200012F")]
[DBAGFLHDBHH]
public class KKEKINDNPIB : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000316")]
	public string AFJCPNNPDNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000317")]
	public GIALDOHEDFG? BPGPNAKOIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000318")]
	public string? EMLAHENKICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000319")]
	public bool IJEDOKECGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0xDC4260", Offset = "0xDC3460", VA = "0x180DC4260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600078B")]
		[Cpp2IlInjected.Address(RVA = "0xAADDE0", Offset = "0xAACFE0", VA = "0x180AADDE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031A")]
	public string? HNOIBAPLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600078C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031B")]
	public string? IBFIBEJPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031C")]
	public string? BBIEALCOAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000790")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000791")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031D")]
	public bool? MBKMGNLNJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000792")]
		[Cpp2IlInjected.Address(RVA = "0x71C40E0", Offset = "0x71C32E0", VA = "0x1871C40E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000793")]
		[Cpp2IlInjected.Address(RVA = "0x71C40D0", Offset = "0x71C32D0", VA = "0x1871C40D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public KKEKINDNPIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
[DBAGFLHDBHH]
public class MKHCODPGDGJ : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700031E")]
	public string EGKLDLJEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000796")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000797")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700031F")]
	public GIALDOHEDFG? BPGPNAKOIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000320")]
	public bool IJEDOKECGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000321")]
	public string? IBFIBEJPKBC
	{
		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600079D")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public MKHCODPGDGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000131")]
[DBAGFLHDBHH]
public class GGNGLJKKDOM : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000322")]
	public string BBIEALCOAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000323")]
	public string HNOIBAPLNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60007A2")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000324")]
	public string LMDKNGJBMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60007A4")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000325")]
	public string? KNFLPEEGEAG
	{
		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000326")]
	public float OIIGDHKGEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60007A8")]
		[Cpp2IlInjected.Address(RVA = "0xC11C90", Offset = "0xC10E90", VA = "0x180C11C90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60007A9")]
		[Cpp2IlInjected.Address(RVA = "0xF1CCB0", Offset = "0xF1BEB0", VA = "0x180F1CCB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GGNGLJKKDOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
[DBAGFLHDBHH]
public class HKPFLNGBMEH : APDPHCGIHLB, EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000327")]
	public string ANCDJKHINJL
	{
		[Cpp2IlInjected.Token(Token = "0x60007AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000328")]
	public string INPCOEOHOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60007AE")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B0")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "6")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B1")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HKPFLNGBMEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
[DBAGFLHDBHH]
public class HDOOMIJNBBA : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000329")]
	public long AKNJKLNCIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032A")]
	public decimal GHDBFMFALDH
	{
		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0xDD6D20", Offset = "0xDD5F20", VA = "0x180DD6D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007B6")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007B7")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HDOOMIJNBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000134")]
[DBAGFLHDBHH]
public class BKMALJLOMNE : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700032B")]
	public string ANCDJKHINJL
	{
		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032C")]
	public string BMHBBOFKOPC
	{
		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007BC")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public BKMALJLOMNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BD")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public BKMALJLOMNE(string ANPKGOFDOAE, string LELDJMLADPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007BE")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
[DBAGFLHDBHH]
public class HMAFPHCPIEJ : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700032D")]
	public string BMHBBOFKOPC
	{
		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007C1")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007C2")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HMAFPHCPIEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
[DBAGFLHDBHH]
public class FMLMFNEDEKK : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700032E")]
	public string BBIEALCOAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700032F")]
	public string AFJCPNNPDNB
	{
		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000330")]
	public string? LDPBGKCICAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000331")]
	public string? LKPGEEJCGOF
	{
		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CB")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007CC")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public FMLMFNEDEKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
[DBAGFLHDBHH]
public class EOMPAAEJIEK : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000332")]
	public string DOGMAOHHFOD
	{
		[Cpp2IlInjected.Token(Token = "0x60007CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007CE")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007CF")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007D0")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public EOMPAAEJIEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
[DBAGFLHDBHH]
public class MADACAGCJGL : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000333")]
	public int CCDGCEMKGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000334")]
	public string AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x60007D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000335")]
	public string? BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000336")]
	public IReadOnlyList<int> MBBHBGLEHIH
	{
		[Cpp2IlInjected.Token(Token = "0x60007D7")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000337")]
	public string? PKLMHDECIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60007D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007DA")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007DB")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007DC")]
	[Cpp2IlInjected.Address(RVA = "0x71C49D0", Offset = "0x71C3BD0", VA = "0x1871C49D0")]
	public MADACAGCJGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
[DBAGFLHDBHH]
public class FBNFAPPLIJE : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000338")]
	public int CCDGCEMKGPH
	{
		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000339")]
	public Guid? FCLMLMMKKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x2199180", Offset = "0x2198380", VA = "0x182199180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x2199170", Offset = "0x2198370", VA = "0x182199170")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	public string AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	public List<MADACAGCJGL> BOMONELHGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E4")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	public List<MADACAGCJGL> EILMOCKNJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E6")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033D")]
	public string? BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60007E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007E8")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	public string? PKLMHDECIJD
	{
		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	public string? JFLMKKDAAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0x71C15D0", Offset = "0x71C07D0", VA = "0x1871C15D0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x71C1600", Offset = "0x71C0800", VA = "0x1871C1600")]
	public FBNFAPPLIJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013A")]
[DBAGFLHDBHH]
public class NBEIFKANDFN : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000340")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000341")]
	public FBNFAPPLIJE BOMONELHGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000342")]
	public FBNFAPPLIJE EILMOCKNJPL
	{
		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000343")]
	public string? JFLMKKDAAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60007F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007F6")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60007F7")]
	[Cpp2IlInjected.Address(RVA = "0x71C4FD0", Offset = "0x71C41D0", VA = "0x1871C4FD0", Slot = "5")]
	public virtual void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public NBEIFKANDFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[DBAGFLHDBHH]
public class EJCMOABEJEP : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000344")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x60007F9")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000345")]
	public IReadOnlyList<FBNFAPPLIJE> KMLCABJNNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60007FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000346")]
	public IReadOnlyList<NBEIFKANDFN> MGOBMPLHLEO
	{
		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60007FE")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000347")]
	public IReadOnlyList<EJCMOABEJEP> GHHPFEOIIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60007FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000800")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000348")]
	public string? JFLMKKDAAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000801")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000803")]
	[Cpp2IlInjected.Address(RVA = "0x71C0630", Offset = "0x71BF830", VA = "0x1871C0630", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0x71C0660", Offset = "0x71BF860", VA = "0x1871C0660")]
	public EJCMOABEJEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
[DBAGFLHDBHH]
public class GIALDOHEDFG : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000349")]
	public string BGMICIBNDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000805")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034A")]
	public string AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034B")]
	public List<GIALDOHEDFG>? MKHNEOCCLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x71C2200", Offset = "0x71C1400", VA = "0x1871C2200", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080C")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GIALDOHEDFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
[DBAGFLHDBHH]
public class NMNGCPHJDJA : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700034C")]
	public string CCDGCEMKGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034D")]
	public EJCMOABEJEP EPGDAMLFCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034E")]
	public GIALDOHEDFG? BPGPNAKOIAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700034F")]
	public string? EGKLDLJEOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x71C5A00", Offset = "0x71C4C00", VA = "0x1871C5A00", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public NMNGCPHJDJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[DBAGFLHDBHH]
public class OJPBHMKKBOM : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000350")]
	public DEOBABMLFHH<NMNGCPHJDJA> JPOOALJFOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000351")]
	public decimal ABNMIEKGLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0")]
		[CompilerGenerated]
		get
		{
			return default(decimal);
		}
		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0xDD6D20", Offset = "0xDD5F20", VA = "0x180DD6D20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0x6F86D60", Offset = "0x6F85F60", VA = "0x186F86D60", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public OJPBHMKKBOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
public enum GKNIGBIGFGD
{
	[Cpp2IlInjected.Token(Token = "0x40005A9")]
	Empty,
	[Cpp2IlInjected.Token(Token = "0x40005AA")]
	Low,
	[Cpp2IlInjected.Token(Token = "0x40005AB")]
	Good
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
[DBAGFLHDBHH]
public class GCHOBDJLIIJ : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000352")]
	public GKNIGBIGFGD CBIJJOPGNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(GKNIGBIGFGD);
		}
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000353")]
	public DateTime CECEPJODOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600081F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x6000820")]
		[Cpp2IlInjected.Address(RVA = "0xC65010", Offset = "0xC64210", VA = "0x180C65010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000821")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000822")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public GCHOBDJLIIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
[DBAGFLHDBHH]
public class CNMKEBNFHGG : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000354")]
	public GKNIGBIGFGD LNBMPAPPIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(GKNIGBIGFGD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000824")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000355")]
	public float GNMOOKGHDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000825")]
		[Cpp2IlInjected.Address(RVA = "0xD21BC0", Offset = "0xD20DC0", VA = "0x180D21BC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000826")]
		[Cpp2IlInjected.Address(RVA = "0xD21EC0", Offset = "0xD210C0", VA = "0x180D21EC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000827")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000828")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CNMKEBNFHGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
[DBAGFLHDBHH]
public class CENDJIAFFND : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x17000356")]
	public GKNIGBIGFGD CBIJJOPGNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000829")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(GKNIGBIGFGD);
		}
		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000357")]
	public DateTime CECEPJODOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xC65010", Offset = "0xC64210", VA = "0x180C65010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000358")]
	public GKNIGBIGFGD LNBMPAPPIDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
		[CompilerGenerated]
		get
		{
			return default(GKNIGBIGFGD);
		}
		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xC8CB20", Offset = "0xC8BD20", VA = "0x180C8CB20")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000359")]
	public float GNMOOKGHDMA
	{
		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0x107F670", Offset = "0x107E870", VA = "0x18107F670")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0x1292B80", Offset = "0x1291D80", VA = "0x181292B80")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035A")]
	public GKNIGBIGFGD GFHBDBLGGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		[CompilerGenerated]
		get
		{
			return default(GKNIGBIGFGD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035B")]
	public float GDPPALEOKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xC5D8B0", Offset = "0xC5CAB0", VA = "0x180C5D8B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xC5D8C0", Offset = "0xC5CAC0", VA = "0x180C5D8C0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000835")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000836")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public CENDJIAFFND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000143")]
[DBAGFLHDBHH]
public class DIOJMAKAIED : EDDGMJLBELL
{
	[Cpp2IlInjected.Token(Token = "0x1700035C")]
	public TimeSpan JJCBIEDAIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xD2C040", Offset = "0xD2B240", VA = "0x180D2C040")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700035D")]
	public TimeSpan INDJCIBJDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xC65010", Offset = "0xC64210", VA = "0x180C65010")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600083B")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void EJBLMMEIOCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083C")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public DIOJMAKAIED()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000144")]
public class HKJKGJGAGLN
{
	[Cpp2IlInjected.Token(Token = "0x600083D")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public HKJKGJGAGLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600083E")]
	[Cpp2IlInjected.Address(RVA = "0x6EEC010", Offset = "0x6EEB210", VA = "0x186EEC010")]
	public static string HBPFEGFMEGC(byte[] GOKBGOMFIIG, byte[] BEJBCBEBEAC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
