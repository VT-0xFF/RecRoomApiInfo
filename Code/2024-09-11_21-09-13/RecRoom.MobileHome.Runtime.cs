using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6BCC7F0", Offset = "0x6BCADF0", VA = "0x186BCC7F0", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum IJCLHAIJIHA
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
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MCMBKHDPAKB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IGHKGBGJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? KOEJAMDLGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? KAPHLAIGIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? GCENCDDNFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? OOMKLECNIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	PBIFGENIPEN CLFBDHILHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> KNNPPNPGHPO;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LFKKBMCHAOP(IJCLHAIJIHA FDKAGJLJMPF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AIFHKOLJDOL();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HFMKIAAFCDK();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PONECHFCBAD(string CCOJMELONMF);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OBAKEPHIELP();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MBFNACHDPOI
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CAGHOGCHNMH(PBIFGENIPEN GMIDEBKLJMI, [Optional] CancellationToken IONNNJNKLMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class JGHEFGELGCA : MCMBKHDPAKB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private enum FMGFHIFGNFO
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void HKAAIMBOJAF(string GMIDEBKLJMI);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate int EJFPICKPJMO();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static JGHEFGELGCA NFEPGHCPILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly CDCHCDMFJJO GFFIBCDBBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly NIBILAFKEMK HMHBIGEEOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool FFPLPIIJMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool AJOLOLIADAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool IAEMBPIMADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool MIACEEDMJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? LBMDNBOODPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool KPJKFBFCFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? AGNPIOOENID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool FPLNJPONFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? OGBOFNOGHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private IJCLHAIJIHA DOGHJFLIPIM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool IGHKGBGJMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? KOEJAMDLGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBC00", Offset = "0x6BCA200", VA = "0x186BCBC00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? KAPHLAIGIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6BCB420", Offset = "0x6BC9A20", VA = "0x186BCB420", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? GCENCDDNFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6BCC100", Offset = "0x6BCA700", VA = "0x186BCC100", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? OOMKLECNIHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBFF0", Offset = "0x6BCA5F0", VA = "0x186BCBFF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public PBIFGENIPEN CLFBDHILHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88D7B0", Offset = "0x88BDB0", VA = "0x18088D7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> KNNPPNPGHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6BCC690", Offset = "0x6BCAC90", VA = "0x186BCC690", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6BCBAB0", Offset = "0x6BCA0B0", VA = "0x186BCBAB0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB9A0", Offset = "0x6BC9FA0", VA = "0x186BCB9A0")]
	private void GHPFMFCONAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC750", Offset = "0x6BCAD50", VA = "0x186BCC750")]
	[RecRoom.NoEngine.Common.Preserve]
	public JGHEFGELGCA([OLJNBPOCBCJ(null)] CDCHCDMFJJO GFFIBCDBBFN, [OLJNBPOCBCJ(null)] NIBILAFKEMK HMHBIGEEOMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB400", Offset = "0x6BC9A00", VA = "0x186BCB400", Slot = "13")]
	public void AIFHKOLJDOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC680", Offset = "0x6BCAC80", VA = "0x186BCC680", Slot = "16")]
	public void OBAKEPHIELP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBD40", Offset = "0x6BCA340", VA = "0x186BCBD40", Slot = "17")]
	public void JBGEKDAOJHD(string EOCCIDJOJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBB60", Offset = "0x6BCA160", VA = "0x186BCBB60", Slot = "14")]
	public void HFMKIAAFCDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB7E0", Offset = "0x6BC9DE0", VA = "0x186BCB7E0", Slot = "18")]
	public void FMOJJCHKEHL([Optional] string JAEBKIILOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC740", Offset = "0x6BCAD40", VA = "0x186BCC740", Slot = "15")]
	public void PONECHFCBAD(string CCOJMELONMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC290", Offset = "0x6BCA890", VA = "0x186BCC290", Slot = "12")]
	public void LFKKBMCHAOP(IJCLHAIJIHA FDKAGJLJMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC360", Offset = "0x6BCA960", VA = "0x186BCC360")]
	private void NEHFKBOCJJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB670", Offset = "0x6BC9C70", VA = "0x186BCB670")]
	[MonoPInvokeCallback(typeof(HKAAIMBOJAF))]
	private static void DKFGLENCGBL(string EOCCIDJOJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBCF0", Offset = "0x6BCA2F0", VA = "0x186BCBCF0")]
	[MonoPInvokeCallback(typeof(EJFPICKPJMO))]
	private static int IJJEDAHILIJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB770", Offset = "0x6BC9D70", VA = "0x186BCB770")]
	private void DOAKDKDDPMC(string KOGIAAOOJFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB910", Offset = "0x6BC9F10", VA = "0x186BCB910")]
	private void GHCHKHINDOA(HKAAIMBOJAF JMKAJHCEDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBA20", Offset = "0x6BCA020", VA = "0x186BCBA20")]
	private void GMAGLLHCIEA(EJFPICKPJMO JMKAJHCEDCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBB70", Offset = "0x6BCA170", VA = "0x186BCBB70")]
	private void HFMKIAAFCDK(FMGFHIFGNFO ONIANAELCBB, string DBHMBAIPMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BCC200", Offset = "0x6BCA800", VA = "0x186BCC200")]
	private void LFFNLFMMKGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB510", Offset = "0x6BC9B10", VA = "0x186BCB510")]
	private long? BKHPFAADIEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB6C0", Offset = "0x6BC9CC0", VA = "0x186BCB6C0")]
	private long? DMLKCGOKPNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB5C0", Offset = "0x6BC9BC0", VA = "0x186BCB5C0")]
	private Guid? CPGHEIFOMIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BCBF40", Offset = "0x6BCA540", VA = "0x186BCBF40")]
	private double? JECNGIHHELA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB240", Offset = "0x6BC9840", VA = "0x186BCB240")]
	internal static void LMLMBGINBMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB7F0", Offset = "0x6BC9DF0", VA = "0x186BCB7F0")]
	private void GBNJFBLGJID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CHLGHCLAJFG
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB300", Offset = "0x6BC9900", VA = "0x186BCB300")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	internal static void NHCNGJDKHBJ(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BCB240", Offset = "0x6BC9840", VA = "0x186BCB240")]
	[KMFBAGPNCPO.KMNJIMBONBM]
	internal static void NCFKHHJLNDP()
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
