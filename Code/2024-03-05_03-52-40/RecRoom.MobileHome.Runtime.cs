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
public enum EKIJAPFJFML
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
public interface AAAKKHNOOJH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KBLJAEPMCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? AJCNCEMMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? IFJDCFDMJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? GDGAFBAIBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? LFGKFPGMCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PHHFEAJAGEK(EKIJAPFJFML OHBBLINCHPH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCJBJGBIMAI();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FCCFAELGKAH();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GEEDCMOJHNH(string PENBPMGOKKL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KNHBIBMHGAE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GMALFIPLPDH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DLOBFNENMLE(HNJDOPCNJPJ LBLBAIKIIGI, [Optional] CancellationToken MBHHHCCHBAO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GKBBGJPCEIO : AAAKKHNOOJH
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum AMNGDBKKEFB
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void BDEFPOFHHHF(string LBLBAIKIIGI);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int LIDNKJIPPAO();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static GKBBGJPCEIO DIPPNLOGDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KOJNBDKFDDJ ACOIFFDKBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool HPHBIIBMDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool MIFMKKGJHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool AHPDJIFMOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool GLKHOLFPLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long? KAKEMCMMLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool NMLOCFOMNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? EDMOMAHGLNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool NDGNPNACJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Guid? IHHHFDJEMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private EKIJAPFJFML ACOMNOOKOBJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KBLJAEPMCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? AJCNCEMMPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61382B0", Offset = "0x61370B0", VA = "0x1861382B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? IFJDCFDMJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61394A0", Offset = "0x61382A0", VA = "0x1861394A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? GDGAFBAIBIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6138450", Offset = "0x6137250", VA = "0x186138450", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? LFGKFPGMCCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6138D60", Offset = "0x6137B60", VA = "0x186138D60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HNJDOPCNJPJ EKBGIBLBGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BB850", Offset = "0x7BA650", VA = "0x1807BB850", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BB870", Offset = "0x7BA670", VA = "0x1807BB870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61398B0", Offset = "0x61386B0", VA = "0x1861398B0")]
	[Preserve]
	public GKBBGJPCEIO([BMAJFBAIDDE(null)] KOJNBDKFDDJ ACOIFFDKBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6138F90", Offset = "0x6137D90", VA = "0x186138F90", Slot = "10")]
	public void KCJBJGBIMAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61390C0", Offset = "0x6137EC0", VA = "0x1861390C0", Slot = "13")]
	public void KNHBIBMHGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6139740", Offset = "0x6138540", VA = "0x186139740", Slot = "15")]
	public void PNPHAEEOLHC(string MFMBPDKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61386D0", Offset = "0x61374D0", VA = "0x1861386D0", Slot = "11")]
	public void FCCFAELGKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6138600", Offset = "0x6137400", VA = "0x186138600", Slot = "16")]
	public void DFPNCFMLJNF([Optional] string MIHBOLADPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6138770", Offset = "0x6137570", VA = "0x186138770", Slot = "12")]
	public void GEEDCMOJHNH(string PENBPMGOKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6139670", Offset = "0x6138470", VA = "0x186139670", Slot = "9")]
	public void PHHFEAJAGEK(EKIJAPFJFML OHBBLINCHPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61387F0", Offset = "0x61375F0", VA = "0x1861387F0")]
	private void IFEBHOIJOJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6138B10", Offset = "0x6137910", VA = "0x186138B10")]
	[MonoPInvokeCallback(typeof(BDEFPOFHHHF))]
	private static void IMAIMHBCJOL(string MFMBPDKDPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6139590", Offset = "0x6138390", VA = "0x186139590")]
	[MonoPInvokeCallback(typeof(LIDNKJIPPAO))]
	private static int OPHMLKEAPAB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6138780", Offset = "0x6137580", VA = "0x186138780")]
	private void GGNFJHMGDCG(string GJEEECFOICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6139360", Offset = "0x6138160", VA = "0x186139360")]
	private void MMFKHMHPGPG(BDEFPOFHHHF NHPEKKMOHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61390D0", Offset = "0x6137ED0", VA = "0x1861390D0")]
	private void KOHKPEEECGO(LIDNKJIPPAO NHPEKKMOHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61386E0", Offset = "0x61374E0", VA = "0x1861386E0")]
	private void FCCFAELGKAH(AMNGDBKKEFB NMANOHAACJH, string JDFPKHNGGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61395E0", Offset = "0x61383E0", VA = "0x1861395E0")]
	private void PAIAPKGDMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61393F0", Offset = "0x61381F0", VA = "0x1861393F0")]
	private long? OGFLNPBECPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61383A0", Offset = "0x61371A0", VA = "0x1861383A0")]
	private long? BDIAFCMELEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6138CB0", Offset = "0x6137AB0", VA = "0x186138CB0")]
	private Guid? JCEKEKGDKBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6138550", Offset = "0x6137350", VA = "0x186138550")]
	private double? COGPAGBFKPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6138610", Offset = "0x6137410", VA = "0x186138610")]
	internal static void DMIAEIAPEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6138E70", Offset = "0x6137C70", VA = "0x186138E70")]
	private void JPNAEFOANCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6139160", Offset = "0x6137F60", VA = "0x186139160")]
	[CompilerGenerated]
	private void LEJMIBPIMFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KAGJJLIFMLE
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6139930", Offset = "0x6138730", VA = "0x186139930")]
	[HBAMLEIOGOF(BHCECOANHAK.None)]
	private static void MFEIOALDEKM(CMADEFPIMOE LANMIEEPANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6138610", Offset = "0x6137410", VA = "0x186138610")]
	[GJCBJFIHOBA(OPNAEKDCKEJ.Unity_BeforeSceneLoad)]
	private static void JICDLMHENJG()
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
