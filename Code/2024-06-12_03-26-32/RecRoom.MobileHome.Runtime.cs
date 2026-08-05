using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LNOECNOFGEB
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Unknown = 0,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Initializing = 1,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ReadyForLogin = 2,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	PlayerLoading = 32,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	PlayerLoaded = 33,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	PlayerCustomization = 34,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	RoomLoading = 64,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InOrientation = 65,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InDorm = 66,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	InRoom = 67,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	InEvent = 68,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Logout = 128,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ExitingClient = 129
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AGPHPENMHIC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DIKPGHEMBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? CNPGHMHMCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? BIBEBNOILGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? EBMNCLNECKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? PDIAGPGMOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	JNCAGLDONDC KIHBGMOGLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> OGACGLHEAPH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KGDEHKAENFG(LNOECNOFGEB GJEHPOMDLIP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EHHLDMLDHNI();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NIIIDMKFNKO();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GMEPLMOMCMI(string DIIKHOHHLDK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DNLKPDBBDJL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KGPJGODDCNK
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CNIMKPJLFPH(JNCAGLDONDC EHNJOBPPFGP, [Optional] CancellationToken MPLCHGMFENA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AHMLMPHICCE : AGPHPENMHIC
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum FPKKKPHGFOF
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void NNAJOHIAGFC(string EHNJOBPPFGP);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int PDGPCPOFMCJ();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static AHMLMPHICCE HFEGKIPECIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GKDHMMKGFLI CKEDCANNHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool HNNGEOAPJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool FALPGIAENHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool IGCJJJHODGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool LEOJAMCPCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? DHLEDKFAFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool CBOCEJHMAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private long? OOGECJKGNGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool MJFONFNLNNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Guid? GFOIPELJBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private LNOECNOFGEB HNLOEMLKILO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DIKPGHEMBEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? CNPGHMHMCFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x692E5D0", Offset = "0x692D1D0", VA = "0x18692E5D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? BIBEBNOILGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x692ECC0", Offset = "0x692D8C0", VA = "0x18692ECC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? EBMNCLNECKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x692E090", Offset = "0x692CC90", VA = "0x18692E090", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? PDIAGPGMOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x692E740", Offset = "0x692D340", VA = "0x18692E740", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JNCAGLDONDC KIHBGMOGLMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8431C0", Offset = "0x841DC0", VA = "0x1808431C0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x843380", Offset = "0x841F80", VA = "0x180843380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> OGACGLHEAPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x692E240", Offset = "0x692CE40", VA = "0x18692E240", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x692E520", Offset = "0x692D120", VA = "0x18692E520", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x692E6C0", Offset = "0x692D2C0", VA = "0x18692E6C0")]
	private void LJBMJGCICBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x692EED0", Offset = "0x692DAD0", VA = "0x18692EED0")]
	[Preserve]
	public AHMLMPHICCE([GOICEJLKLIB(null)] GKDHMMKGFLI CKEDCANNHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x692DFB0", Offset = "0x692CBB0", VA = "0x18692DFB0", Slot = "13")]
	public void EHHLDMLDHNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x692DF10", Offset = "0x692CB10", VA = "0x18692DF10", Slot = "16")]
	public void DNLKPDBBDJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x692DB60", Offset = "0x692C760", VA = "0x18692DB60", Slot = "17")]
	public void AIPEOPIKMOE(string MCNFPKGIEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x692EC50", Offset = "0x692D850", VA = "0x18692EC50", Slot = "14")]
	public void NIIIDMKFNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x692DE00", Offset = "0x692CA00", VA = "0x18692DE00", Slot = "18")]
	public void ALOEBPOFJIO([Optional] string BLMACNFFCCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x692E080", Offset = "0x692CC80", VA = "0x18692E080", Slot = "15")]
	public void GMEPLMOMCMI(string DIIKHOHHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x692E450", Offset = "0x692D050", VA = "0x18692E450", Slot = "12")]
	public void KGDEHKAENFG(LNOECNOFGEB GJEHPOMDLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x692E8A0", Offset = "0x692D4A0", VA = "0x18692E8A0")]
	private void MLDKJIFJEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x692EC60", Offset = "0x692D860", VA = "0x18692EC60")]
	[MonoPInvokeCallback(typeof(NNAJOHIAGFC))]
	private static void NPKFCNPHBLL(string MCNFPKGIEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x692E850", Offset = "0x692D450", VA = "0x18692E850")]
	[MonoPInvokeCallback(typeof(PDGPCPOFMCJ))]
	private static int MJDFNKCEGHK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x692DE10", Offset = "0x692CA10", VA = "0x18692DE10")]
	private void APHGINGOEKM(string IKGPLHJMCAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x692DE80", Offset = "0x692CA80", VA = "0x18692DE80")]
	private void CFJOOCAMNGM(NNAJOHIAGFC LHMNAJJOJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x692DF20", Offset = "0x692CB20", VA = "0x18692DF20")]
	private void DODJHCBCNOF(PDGPCPOFMCJ LHMNAJJOJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x692EBC0", Offset = "0x692D7C0", VA = "0x18692EBC0")]
	private void NIIIDMKFNKO(FPKKKPHGFOF BGLFCJCCBPJ, string NDEKAOCDLCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x692DAD0", Offset = "0x692C6D0", VA = "0x18692DAD0")]
	private void ABGJFKKHMNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x692E190", Offset = "0x692CD90", VA = "0x18692E190")]
	private long? IKBMBEBJGNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x692DFD0", Offset = "0x692CBD0", VA = "0x18692DFD0")]
	private long? FNDNCPHBAOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x692E3A0", Offset = "0x692CFA0", VA = "0x18692E3A0")]
	private Guid? KCEKNKJDOIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x692E2F0", Offset = "0x692CEF0", VA = "0x18692E2F0")]
	private double? JOPNAGPMNDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x692DD40", Offset = "0x692C940", VA = "0x18692DD40")]
	internal static void ALKHIMNMFEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x692EDB0", Offset = "0x692D9B0", VA = "0x18692EDB0")]
	private void PKODIODEMKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HMLPDLKMNAO
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x692EF50", Offset = "0x692DB50", VA = "0x18692EF50")]
	[FJJFAIMPJIC(JBEKPLNNIEC.None)]
	private static void JPDDIPCAKKO(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x692DD40", Offset = "0x692C940", VA = "0x18692DD40")]
	[JINDIHIDKGM(CBKAKHJHIKE.Unity_BeforeSceneLoad)]
	private static void ADEDAAHIPEI()
	{
	}
}
namespace Cpp2IlInjected;

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
