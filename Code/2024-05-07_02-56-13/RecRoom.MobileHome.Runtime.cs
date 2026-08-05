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
public enum ODCNIENPCPB
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
public interface IKCIKIGHCKN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NJMOEPDHBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? HNGJJFAJLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? OBFEKOONLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? EEBIIIJJIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? LKLELFJBHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	FLCNBKLLCIP CMFNNMHPPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> CEPCGIBIDKH;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHLDDANGODJ(ODCNIENPCPB OAODOPKGJBP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GEJAFFIMNGM();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EEAHHNNPFJG();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FDKKLENMNKP(string NHPIJCGMDPF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HPLEIKAGOAE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IKEIECPMODE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BOBEADLPOCJ(FLCNBKLLCIP ADMCABILFML, [Optional] CancellationToken AIHJHMPAHCH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CICKNGMDNKP : IKCIKIGHCKN
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum HJHNDMDHCLL
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void JADLEIHKBGF(string ADMCABILFML);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int MFFHHHFIIHH();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static CICKNGMDNKP JHPIMPOFIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly LFGFELEHJNP BEDGBOCOMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool JHLDMBBJPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool KHLGPGBMGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool FJHPCBMNODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool CLCKOBMBEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? CADNHLGBDMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool JEADINIPFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private long? CDPCMDMFAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool NLBAACBDCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Guid? MJEGFGHBFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private ODCNIENPCPB DKIHKLKALFB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NJMOEPDHBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? HNGJJFAJLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x62466E0", Offset = "0x62458E0", VA = "0x1862466E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? OBFEKOONLNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6247050", Offset = "0x6246250", VA = "0x186247050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? EEBIIIJJIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x62474E0", Offset = "0x62466E0", VA = "0x1862474E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? LKLELFJBHAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x62467D0", Offset = "0x62459D0", VA = "0x1862467D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FLCNBKLLCIP CMFNNMHPPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CC0", Offset = "0x7B7EC0", VA = "0x1807B8CC0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CD0", Offset = "0x7B7ED0", VA = "0x1807B8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> CEPCGIBIDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6246630", Offset = "0x6245830", VA = "0x186246630", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6246A90", Offset = "0x6245C90", VA = "0x186246A90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6247320", Offset = "0x6246520", VA = "0x186247320")]
	private void JGMAAOGNONN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6247870", Offset = "0x6246A70", VA = "0x186247870")]
	[Preserve]
	public CICKNGMDNKP([GAGPBLHNPNO(null)] LFGFELEHJNP BEDGBOCOMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6246F20", Offset = "0x6246120", VA = "0x186246F20", Slot = "13")]
	public void GEJAFFIMNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6247140", Offset = "0x6246340", VA = "0x186247140", Slot = "16")]
	public void HPLEIKAGOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6247690", Offset = "0x6246890", VA = "0x186247690", Slot = "17")]
	public void PCJMHACDENB(string CPMKKJBNGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x62469A0", Offset = "0x6245BA0", VA = "0x1862469A0", Slot = "14")]
	public void EEAHHNNPFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6246550", Offset = "0x6245750", VA = "0x186246550", Slot = "18")]
	public void CGMDBPFJICJ([Optional] string FJLFJHDOIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6246B40", Offset = "0x6245D40", VA = "0x186246B40", Slot = "15")]
	public void FDKKLENMNKP(string NHPIJCGMDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6246560", Offset = "0x6245760", VA = "0x186246560", Slot = "12")]
	public void CHLDDANGODJ(ODCNIENPCPB OAODOPKGJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6246C00", Offset = "0x6245E00", VA = "0x186246C00")]
	private void FIMOLPAEHMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6246A40", Offset = "0x6245C40", VA = "0x186246A40")]
	[MonoPInvokeCallback(typeof(JADLEIHKBGF))]
	private static void FBCDNLCBDDO(string CPMKKJBNGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6246490", Offset = "0x6245690", VA = "0x186246490")]
	[MonoPInvokeCallback(typeof(MFFHHHFIIHH))]
	private static int AHLKENAILIL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x62464E0", Offset = "0x62456E0", VA = "0x1862464E0")]
	private void AKGCKOBPNJI(string KPGPENNAGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x62473A0", Offset = "0x62465A0", VA = "0x1862473A0")]
	private void MFPLMDILINL(JADLEIHKBGF IAPBAMILEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6247150", Offset = "0x6246350", VA = "0x186247150")]
	private void IHFEIHDENIM(MFFHHHFIIHH IAPBAMILEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62469B0", Offset = "0x6245BB0", VA = "0x1862469B0")]
	private void EEAHHNNPFJG(HJHNDMDHCLL LGGFDGCPFCF, string PMAGDKPBHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6247290", Offset = "0x6246490", VA = "0x186247290")]
	private void JGKMMFCOGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x62471E0", Offset = "0x62463E0", VA = "0x1862471E0")]
	private long? IMBPLJDOBEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x62475E0", Offset = "0x62467E0", VA = "0x1862475E0")]
	private long? OJEKFCEGKKK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6247430", Offset = "0x6246630", VA = "0x186247430")]
	private Guid? MLMNOCGKOFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6246B50", Offset = "0x6245D50", VA = "0x186246B50")]
	private double? FFGJCHHOJAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x62468E0", Offset = "0x6245AE0", VA = "0x1862468E0")]
	internal static void DNKHBFLNAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6246F40", Offset = "0x6246140", VA = "0x186246F40")]
	private void GGMFNIKLKGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LEPEGFPDIIM
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x62478F0", Offset = "0x6246AF0", VA = "0x1862478F0")]
	[KEFCCLBEAOJ(CMEECPGEPNF.None)]
	private static void FNBGPOLFIGO(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x62468E0", Offset = "0x6245AE0", VA = "0x1862468E0")]
	[IGEKFJAFMOG(BLJBFKICAJD.Unity_BeforeSceneLoad)]
	private static void NKCEPBDEBIA()
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
