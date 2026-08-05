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
public enum IEBMPLCCKON
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
public interface HBPHCENCANF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HJIGIGHLFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? ALKELKBDCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? COKDLKOLCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? JPNKDLKGODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? AHOELDJKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ODDBFNFADNC BFCFPMLLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> KBJJHJIPBED;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IHMLOOPFNAH(IEBMPLCCKON AHEJMLCHHMA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MGIGIPLLEKC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AIJAPJNPBAL();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PANFOJGIFNF(string IBNPNLCJAIA);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LKILKKBNNKF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AANOMLFLDBE
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GHKEDDLBMCP(ODDBFNFADNC FFJOKNMPADN, [Optional] CancellationToken GNJJGEHBGKC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BOIBKPBMMKC : HBPHCENCANF
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum DNIDMNKABEI
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void PKOBODIJDCN(string FFJOKNMPADN);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int KAGLLLPHFPM();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static BOIBKPBMMKC GHLPOEBBIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly GKCKIEBCDOA NKHDJEADIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MKKFECJHHIC FIEMCMBOBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool MJFMHMGHJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool LHMNOMPDNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool LLKBBAJIPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool NLPDHMMMDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? PGABENCFPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool EGMCALEIEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? KBJHKABIHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool DLHHFCEEOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? OMHNONJPOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private IEBMPLCCKON JFCFNFJJLNC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool HJIGIGHLFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? ALKELKBDCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6955680", Offset = "0x6954A80", VA = "0x186955680", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? COKDLKOLCGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69560F0", Offset = "0x69554F0", VA = "0x1869560F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? JPNKDLKGODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6955900", Offset = "0x6954D00", VA = "0x186955900", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? AHOELDJKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69557F0", Offset = "0x6954BF0", VA = "0x1869557F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ODDBFNFADNC BFCFPMLLLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x855F20", Offset = "0x855320", VA = "0x180855F20", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x855F00", Offset = "0x855300", VA = "0x180855F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> KBJJHJIPBED
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6955430", Offset = "0x6954830", VA = "0x186955430", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6956200", Offset = "0x6955600", VA = "0x186956200", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6955770", Offset = "0x6954B70", VA = "0x186955770")]
	private void ECFDPOPICAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6956730", Offset = "0x6955B30", VA = "0x186956730")]
	[Preserve]
	public BOIBKPBMMKC([NCPIDBJOPHL(null)] GKCKIEBCDOA NKHDJEADIGA, [NCPIDBJOPHL(null)] MKKFECJHHIC FIEMCMBOBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6956360", Offset = "0x6955760", VA = "0x186956360", Slot = "13")]
	public void MGIGIPLLEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69561F0", Offset = "0x69555F0", VA = "0x1869561F0", Slot = "16")]
	public void LKILKKBNNKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6956410", Offset = "0x6955810", VA = "0x186956410", Slot = "17")]
	public void OEHNJLMHAAA(string KPOPEFKNANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69554E0", Offset = "0x69548E0", VA = "0x1869554E0", Slot = "14")]
	public void AIJAPJNPBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69561E0", Offset = "0x69555E0", VA = "0x1869561E0", Slot = "18")]
	public void LILPHKGBJHF([Optional] string AGOGJNJHNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6956600", Offset = "0x6955A00", VA = "0x186956600", Slot = "15")]
	public void PANFOJGIFNF(string IBNPNLCJAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6955BD0", Offset = "0x6954FD0", VA = "0x186955BD0", Slot = "12")]
	public void IHMLOOPFNAH(IEBMPLCCKON AHEJMLCHHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6955CA0", Offset = "0x69550A0", VA = "0x186955CA0")]
	private void KJELOCBDEFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69553D0", Offset = "0x69547D0", VA = "0x1869553D0")]
	[MonoPInvokeCallback(typeof(PKOBODIJDCN))]
	private static void AAMOFPHMBOB(string KPOPEFKNANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6955630", Offset = "0x6954A30", VA = "0x186955630")]
	[MonoPInvokeCallback(typeof(KAGLLLPHFPM))]
	private static int CJOAPKPDDKM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6955B60", Offset = "0x6954F60", VA = "0x186955B60")]
	private void HBPMDFCHEJH(string ELPCOOAGILC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69566A0", Offset = "0x6955AA0", VA = "0x1869566A0")]
	private void PGCDEBANCEA(PKOBODIJDCN PKJIBFLDCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6956380", Offset = "0x6955780", VA = "0x186956380")]
	private void MIKALAFGJFM(KAGLLLPHFPM PKJIBFLDCKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69554F0", Offset = "0x69548F0", VA = "0x1869554F0")]
	private void AIJAPJNPBAL(DNIDMNKABEI PCEHLDFDGKI, string BDPMAJBPBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6956610", Offset = "0x6955A10", VA = "0x186956610")]
	private void PBENDBEKADG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6955A00", Offset = "0x6954E00", VA = "0x186955A00")]
	private long? FOJELPNLIJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69562B0", Offset = "0x69556B0", VA = "0x1869562B0")]
	private long? MEJKAHNLGIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6955AB0", Offset = "0x6954EB0", VA = "0x186955AB0")]
	private Guid? HAMHIALEOPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6955580", Offset = "0x6954980", VA = "0x186955580")]
	private double? BDBBMPAKMDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6955210", Offset = "0x6954610", VA = "0x186955210")]
	internal static void POHAKILHMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6955FC0", Offset = "0x69553C0", VA = "0x186955FC0")]
	private void LDHMIGJIMKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BJCLHDLLCDI
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69552D0", Offset = "0x69546D0", VA = "0x1869552D0")]
	[EAMANMFIEOM(NBICBCAKHEI.None)]
	private static void PBAIMDHFLHJ(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6955210", Offset = "0x6954610", VA = "0x186955210")]
	[NOENHMEFMBP(NDPGHFIEDII.Unity_BeforeSceneLoad)]
	private static void MCKLFFLIMBO()
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
