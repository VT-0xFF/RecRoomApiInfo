using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum MIGLAPOFOPE
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
	RoomLoading = 64,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	InOrientation = 65,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InDorm = 66,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InRoom = 67,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	InEvent = 68,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Logout = 128,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	ExitingClient = 129
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OOLFHOOKDDC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MACAJLMIJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? LLMGKLJHEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? HDDDADAMBHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? JHLEPLHNHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDCKHMOOGFO(MIGLAPOFOPE CDOGIGHJFKJ);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GLJEDCMMNGN();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EHLKMBFKDFL();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PGAALMOGKOG(string MMKDCJKIOML);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EKGNIBFGJDE
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ENMPOELILEB(NPDFGKDAHPO ANCJHIMKCAH, [Optional] CancellationToken EHCFBFBFEDH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CIBMEOONHBP : OOLFHOOKDDC
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum GJCHBNOINMF
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void PJDGKDMPAKM(string ANCJHIMKCAH);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int DPIFCBEKAEP();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static CIBMEOONHBP IALEADLNNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool CPDGHOMIMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool JDKHPFLJFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool DICMNAFDEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private long? DMABEHDOAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? NLDJPGHAKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private Guid? JOOHGNNCEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly JJCDNFCIIMN BNGNJDMHJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private MIGLAPOFOPE OFCNMEAFJCI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool MACAJLMIJPP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long? LLMGKLJHEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B3C0", Offset = "0x5D19BC0", VA = "0x185D1B3C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? HDDDADAMBHH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AD50", Offset = "0x5D19550", VA = "0x185D1AD50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Guid? JHLEPLHNHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BC30", Offset = "0x5D1A430", VA = "0x185D1BC30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BC80", Offset = "0x5D1A480", VA = "0x185D1BC80")]
	[Preserve]
	public CIBMEOONHBP([KEKICHOEFEB(null)] JJCDNFCIIMN BNGNJDMHJOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B400", Offset = "0x5D19C00", VA = "0x185D1B400", Slot = "9")]
	public void GLJEDCMMNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B3B0", Offset = "0x5D19BB0", VA = "0x185D1B3B0", Slot = "10")]
	public void EHLKMBFKDFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B310", Offset = "0x5D19B10", VA = "0x185D1B310", Slot = "12")]
	public void EBHDPCANBBL([Optional] string HCCHNLLBNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BC20", Offset = "0x5D1A420", VA = "0x185D1BC20", Slot = "11")]
	public void PGAALMOGKOG(string MMKDCJKIOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B600", Offset = "0x5D19E00", VA = "0x185D1B600", Slot = "8")]
	public void HDCKHMOOGFO(MIGLAPOFOPE CDOGIGHJFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AFF0", Offset = "0x5D197F0", VA = "0x185D1AFF0")]
	private void DHONOJBJLIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B770", Offset = "0x5D19F70", VA = "0x185D1B770")]
	private void IBGCAOLFOKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AD90", Offset = "0x5D19590", VA = "0x185D1AD90")]
	[MonoPInvokeCallback(typeof(PJDGKDMPAKM))]
	private static void CFFOLBBLCPP(string FBCHHKBKKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AC70", Offset = "0x5D19470", VA = "0x185D1AC70")]
	[MonoPInvokeCallback(typeof(DPIFCBEKAEP))]
	private static int AGNKEKCJPOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BBB0", Offset = "0x5D1A3B0", VA = "0x185D1BBB0")]
	private void OKOFPFAMLJE(string JMMPMHACILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B9C0", Offset = "0x5D1A1C0", VA = "0x185D1B9C0")]
	private void KBINDJBJJMJ(PJDGKDMPAKM ABCKGGDLEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ACC0", Offset = "0x5D194C0", VA = "0x185D1ACC0")]
	private void AOPOEOIPOCF(DPIFCBEKAEP ABCKGGDLEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B320", Offset = "0x5D19B20", VA = "0x185D1B320")]
	private void EHLKMBFKDFL(GJCHBNOINMF OGMICOLLEPG, string ANLNGNDIKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B930", Offset = "0x5D1A130", VA = "0x185D1B930")]
	private void IPAOPFIEDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B6C0", Offset = "0x5D19EC0", VA = "0x185D1B6C0")]
	private long? HEIPLHLBPFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BA50", Offset = "0x5D1A250", VA = "0x185D1BA50")]
	private long? KNHOIFOJAIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BB00", Offset = "0x5D1A300", VA = "0x185D1BB00")]
	private Guid? LAJFLDPFFKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B540", Offset = "0x5D19D40", VA = "0x185D1B540")]
	internal static void GNHNIPANEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AEE0", Offset = "0x5D196E0", VA = "0x185D1AEE0")]
	private void DEBGMMPPPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AB20", Offset = "0x5D19320", VA = "0x185D1AB20")]
	[CompilerGenerated]
	private void ABGCBALKNDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OFLFACGCIKL
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BD00", Offset = "0x5D1A500", VA = "0x185D1BD00")]
	[NJKKEFDLCAD(AFMDLPKJFNK.None)]
	private static void KNDDDKDAIND(LLKIHBKOOLA OKPDFALIJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B540", Offset = "0x5D19D40", VA = "0x185D1B540")]
	[MPOGKHKBIDF(EDLHBKHFALL.Unity_BeforeSceneLoad)]
	private static void MJFOKJGONDB()
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
