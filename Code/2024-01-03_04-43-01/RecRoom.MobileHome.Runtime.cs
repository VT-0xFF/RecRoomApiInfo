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
public enum CMEBENPDNCO
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
public interface DHCANBKABOA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MOAENJJIOAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? EKMOPIGFIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? OEEHCNFBLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? JNMHNMGEPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? CGOOKNEJHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LOEGDIBOOLP(CMEBENPDNCO FPIEOLNLDGP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMCKLNABHHJ();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMAPNCIKHDF();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCMCGNIBGGB(string IOABPCNNHKK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EKILCNCBKEG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ANNFEOELIII
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task EKHLCEDLMJC(MMBCEDACIMJ NMNDOBCNBIJ, [Optional] CancellationToken BJFJMBIBKLL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LAHDCICMPHB : DHCANBKABOA
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum MPFOIBADAHL
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void DEDNHIBEMJE(string NMNDOBCNBIJ);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int MGCMPFGMBID();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static LAHDCICMPHB BJMIJNLECJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool MDPPINMIJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool KGJDBLELDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool DHCFFCNOPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool BFABHIAKCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? MGJELFCGANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool NJBNLEAJOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long? FLAJIPBHKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool PGCHOPCPGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Guid? JMNJIHJJDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IFODMKLBIPC GKENIGHFABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private CMEBENPDNCO EGPLBDGGGHI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool MOAENJJIOAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB2E0", Offset = "0x7B9EE0", VA = "0x1807BB2E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? EKMOPIGFIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E54230", Offset = "0x5E52E30", VA = "0x185E54230", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? OEEHCNFBLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E53DF0", Offset = "0x5E529F0", VA = "0x185E53DF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? JNMHNMGEPKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E53310", Offset = "0x5E51F10", VA = "0x185E53310", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? CGOOKNEJHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E544A0", Offset = "0x5E530A0", VA = "0x185E544A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E545C0", Offset = "0x5E531C0", VA = "0x185E545C0")]
	[Preserve]
	public LAHDCICMPHB([DLBAGNNJKKK(null)] IFODMKLBIPC GKENIGHFABJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E53EE0", Offset = "0x5E52AE0", VA = "0x185E53EE0", Slot = "10")]
	public void JMCKLNABHHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x324B250", Offset = "0x3249E50", VA = "0x18324B250", Slot = "13")]
	public void EKILCNCBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E54320", Offset = "0x5E52F20", VA = "0x185E54320", Slot = "11")]
	public void NMAPNCIKHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E545B0", Offset = "0x5E531B0", VA = "0x185E545B0", Slot = "14")]
	public void PHAMONIEJEA([Optional] string DLJDLJCCGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E53410", Offset = "0x5E52010", VA = "0x185E53410", Slot = "12")]
	public void CCMCGNIBGGB(string IOABPCNNHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E540C0", Offset = "0x5E52CC0", VA = "0x185E540C0", Slot = "9")]
	public void LOEGDIBOOLP(CMEBENPDNCO FPIEOLNLDGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E53800", Offset = "0x5E52400", VA = "0x185E53800")]
	private void EIBKGJGPPEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E536B0", Offset = "0x5E522B0", VA = "0x185E536B0")]
	[MonoPInvokeCallback(typeof(DEDNHIBEMJE))]
	private static void EFIPOFDNPJD(string LEOGAJNLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E54450", Offset = "0x5E53050", VA = "0x185E54450")]
	[MonoPInvokeCallback(typeof(MGCMPFGMBID))]
	private static int OHILPGDKDPL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E53C60", Offset = "0x5E52860", VA = "0x185E53C60")]
	private void IOHKBECACEF(string APEDJAJCJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E53B20", Offset = "0x5E52720", VA = "0x185E53B20")]
	private void FFDJLMKGDCF(DEDNHIBEMJE FCFEFDOJHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E53620", Offset = "0x5E52220", VA = "0x185E53620")]
	private void DDPCJPFDLGF(MGCMPFGMBID FCFEFDOJHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E54330", Offset = "0x5E52F30", VA = "0x185E54330")]
	private void NMAPNCIKHDF(MPFOIBADAHL OKDGKAJLADI, string OHBKKFMJBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E543C0", Offset = "0x5E52FC0", VA = "0x185E543C0")]
	private void OAGKEGFFFGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E54010", Offset = "0x5E52C10", VA = "0x185E54010")]
	private long? KMIDDCLNOHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E54180", Offset = "0x5E52D80", VA = "0x185E54180")]
	private long? MIPBEEPEEKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E53BB0", Offset = "0x5E527B0", VA = "0x185E53BB0")]
	private Guid? HHPAEEPHOOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E53570", Offset = "0x5E52170", VA = "0x185E53570")]
	private double? COHLFDHEKHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E53250", Offset = "0x5E51E50", VA = "0x185E53250")]
	internal static void MPCIJLOMAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E53CD0", Offset = "0x5E528D0", VA = "0x185E53CD0")]
	private void IOIIMNKOPEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E53420", Offset = "0x5E52020", VA = "0x185E53420")]
	[CompilerGenerated]
	private void CJNDGLAOFML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FFPGPIHMEEN
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E53150", Offset = "0x5E51D50", VA = "0x185E53150")]
	[GFMBCOBENIN(CDPNEOMLNDL.None)]
	private static void JLDLABFOIIF(OKOCNPPIKGG PCOJMOHPOND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E53250", Offset = "0x5E51E50", VA = "0x185E53250")]
	[DGIJNOPMGJE(IOENMJMEHBM.Unity_BeforeSceneLoad)]
	private static void PPMGLEIFJCM()
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
