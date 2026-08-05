using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74DD470", Offset = "0x74DC870", VA = "0x1874DD470", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74DD7F0", Offset = "0x74DCBF0", VA = "0x1874DD7F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LNHGIPIJFDF
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
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IBILEDDMJLC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FHGCECCCGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? GIOILMPFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? LFKOAKOIJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? DENJFMBICBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? FAKBHGKGKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GKFMEGGBKFN GEOPAGKHEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KNMMLBHMKCG(LNHGIPIJFDF CEGAGHAOIDD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HPHCPPKCEKM();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LLIIPFOHDNE();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PDJBKBKFFNM(string BHPFPDNBMAP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<GKFMEGGBKFN> IOKAGNKEKKD([Optional] CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LMDOBABOCEL();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NECHKINNDGO
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HGKPFIBIAEH : IBILEDDMJLC
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum JEGEEPPMKDC
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void HHDELKOOACH(string ABPOFEIANMP);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int NKNCLPDKBKE();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct EGBCDCBHIKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<GKFMEGGBKFN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public HGKPFIBIAEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<GKFMEGGBKFN> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<GKFMEGGBKFN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x74DB870", Offset = "0x74DAC70", VA = "0x1874DB870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x74DBEB0", Offset = "0x74DB2B0", VA = "0x1874DBEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly IBCMILIKEJG IEGNOINNOMJ;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static HGKPFIBIAEH AIHLLHKMGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly CHDNBFGGGBI JFKMCMPFKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly BPJLCHCNDMD MBDIGPMMHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HOBPLGJHDBC DOODPAFDOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool KAIJNBIFNHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PEOHEEIFJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool AJJPHPAOMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? DJOKBDEIOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool ONHKFIKPJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? EBKCNBHLNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool ODAIEGNHCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? MCDGHHEEPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private LNHGIPIJFDF DCOLOKHNPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object JPKKEAAKAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<GKFMEGGBKFN> IILFIOFAIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<GKFMEGGBKFN> JEPLPLAPALE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool FHGCECCCGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? GIOILMPFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x74DC740", Offset = "0x74DBB40", VA = "0x1874DC740", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? LFKOAKOIJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x74DC7C0", Offset = "0x74DBBC0", VA = "0x1874DC7C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? DENJFMBICBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x74DC840", Offset = "0x74DBC40", VA = "0x1874DC840", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? FAKBHGKGKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74DCD30", Offset = "0x74DC130", VA = "0x1874DCD30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GKFMEGGBKFN GEOPAGKHEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA6B960", Offset = "0xA6AD60", VA = "0x180A6B960", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1112680", Offset = "0x1111A80", VA = "0x181112680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x74DD2F0", Offset = "0x74DC6F0", VA = "0x1874DD2F0")]
	[RecRoom.NoEngine.Common.Preserve]
	public HGKPFIBIAEH([IBJCGEMJMJL(null)] CHDNBFGGGBI JFKMCMPFKPC, [IBJCGEMJMJL(null)] BPJLCHCNDMD MBDIGPMMHLD, [IBJCGEMJMJL(null)] HOBPLGJHDBC DOODPAFDOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74DC5D0", Offset = "0x74DB9D0", VA = "0x1874DC5D0", Slot = "11")]
	public void HPHCPPKCEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x74DCE50", Offset = "0x74DC250", VA = "0x1874DCE50", Slot = "16")]
	public void OEMLHCJKABP(string NDKHLCFKKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74DCA50", Offset = "0x74DBE50", VA = "0x1874DCA50", Slot = "12")]
	public void LLIIPFOHDNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74DCA50", Offset = "0x74DBE50", VA = "0x1874DCA50", Slot = "17")]
	public void JCHLFBHODFO([Optional] string FBJFILGBMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74DCA50", Offset = "0x74DBE50", VA = "0x1874DCA50", Slot = "13")]
	public void PDJBKBKFFNM(string BHPFPDNBMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74DCA90", Offset = "0x74DBE90", VA = "0x1874DCA90", Slot = "10")]
	public void KNMMLBHMKCG(LNHGIPIJFDF CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x74DCB50", Offset = "0x74DBF50", VA = "0x1874DCB50", Slot = "15")]
	public void LMDOBABOCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74DC8D0", Offset = "0x74DBCD0", VA = "0x1874DC8D0", Slot = "14")]
	[AsyncStateMachine(typeof(EGBCDCBHIKJ))]
	public Task<GKFMEGGBKFN> IOKAGNKEKKD(CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x74DBF60", Offset = "0x74DB360", VA = "0x1874DBF60")]
	private void BJGEOFIEAJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x74DC560", Offset = "0x74DB960", VA = "0x1874DC560")]
	[MonoPInvokeCallback(typeof(HHDELKOOACH))]
	private static void HJPLLMNAGJI(string NDKHLCFKKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74DC9F0", Offset = "0x74DBDF0", VA = "0x1874DC9F0")]
	[MonoPInvokeCallback(typeof(NKNCLPDKBKE))]
	private static int IPAGFKGACHO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x74DCCB0", Offset = "0x74DC0B0", VA = "0x1874DCCB0")]
	private void NCIGEKCBOIF(string PFPIJPBMNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x74DBF20", Offset = "0x74DB320", VA = "0x1874DBF20")]
	private void BDLHLMMIDDC(HHDELKOOACH IJCKFHFIADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x74DC460", Offset = "0x74DB860", VA = "0x1874DC460")]
	private void DEJLHACAKOG(NKNCLPDKBKE IJCKFHFIADK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x74DCA50", Offset = "0x74DBE50", VA = "0x1874DCA50")]
	private void LLIIPFOHDNE(JEGEEPPMKDC CEGFAIJENKH, string HEINCJEMEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x74DCC70", Offset = "0x74DC070", VA = "0x1874DCC70")]
	private void MGMFOHEMBAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x74DC4A0", Offset = "0x74DB8A0", VA = "0x1874DC4A0")]
	private long? GHDIPNBJHHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74DC500", Offset = "0x74DB900", VA = "0x1874DC500")]
	private long? GPGDDKAFLHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x74DCAE0", Offset = "0x74DBEE0", VA = "0x1874DCAE0")]
	private Guid? LBOAKCFFNBK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x74DCDF0", Offset = "0x74DC1F0", VA = "0x1874DCDF0")]
	private double? NMCANAMOLLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x74DC380", Offset = "0x74DB780", VA = "0x1874DC380")]
	internal static void DBDOLJLCOFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x74DC1F0", Offset = "0x74DB5F0", VA = "0x1874DC1F0")]
	private void CFHGDCOEMGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NHPEAFADNHP
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x74DD600", Offset = "0x74DCA00", VA = "0x1874DD600")]
	[HLOHOCOKELO.IDGFAEKKODB]
	internal static void JLOEIKCGHLK(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x74DD500", Offset = "0x74DC900", VA = "0x1874DD500")]
	[ONDAMKAMKDB.LAIHOOOIOBJ]
	internal static void FDAPFLHEMPE()
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
