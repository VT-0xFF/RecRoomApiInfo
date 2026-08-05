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
public enum HNBNLIBLIMP
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
public interface LMOMIDJMGNE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LJDENHDOOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? HJBGGLLFHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? FJCLDOLFOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? FNMGBLIMGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? FDGOAGJJHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	KCPADCDOCND MOFFHNNKOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> LINBEEDMLJB;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GEIKDOPOHJA(HNBNLIBLIMP NGHALOPECFO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BGGINNGCCML();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GNJEAEPJFEA();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void BEOCLCMNKAK(string EPLFNDNPINO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NAHHOKAIFHL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EGIGCJGHEHL
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task BJALJOBLIAD(KCPADCDOCND DPPEDIPLNAA, [Optional] CancellationToken DADBOHKBJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IJAMOBGCPBB : LMOMIDJMGNE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum GHPDFHLBJKI
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void ODPAPPDGPFD(string DPPEDIPLNAA);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int HKLBMMDCGPK();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static IJAMOBGCPBB MGNNEDNHDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly KKBDEFJOIBO NOKFMENAHGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool DHBABAMIFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool NGCDMECMEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool GLLCFIGGNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool IDMFKMNPAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? MGMJDOLCOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool LKBGGIAHIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private long? OBECGBJFKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool PKABEOFLNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Guid? KAGJCHCDMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private HNBNLIBLIMP BJBNHPPDIFD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LJDENHDOOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? HJBGGLLFHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x699B370", Offset = "0x6999970", VA = "0x18699B370", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? FJCLDOLFOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x699BA20", Offset = "0x699A020", VA = "0x18699BA20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? FNMGBLIMGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x699B6E0", Offset = "0x6999CE0", VA = "0x18699B6E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? FDGOAGJJHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x699C140", Offset = "0x699A740", VA = "0x18699C140", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public KCPADCDOCND MOFFHNNKOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x863E50", Offset = "0x862450", VA = "0x180863E50", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x863E20", Offset = "0x862420", VA = "0x180863E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> LINBEEDMLJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x699C420", Offset = "0x699AA20", VA = "0x18699C420", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x699BC50", Offset = "0x699A250", VA = "0x18699BC50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x699B4F0", Offset = "0x6999AF0", VA = "0x18699B4F0")]
	private void APKMOFMJBBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x699C6C0", Offset = "0x699ACC0", VA = "0x18699C6C0")]
	[Preserve]
	public IJAMOBGCPBB([JFHFHOOOEKP(null)] KKBDEFJOIBO NOKFMENAHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x699B580", Offset = "0x6999B80", VA = "0x18699B580", Slot = "13")]
	public void BGGINNGCCML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x699C250", Offset = "0x699A850", VA = "0x18699C250", Slot = "16")]
	public void NAHHOKAIFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x699C4D0", Offset = "0x699AAD0", VA = "0x18699C4D0", Slot = "17")]
	public void PHCLPNPAKHN(string KPHFBJDIBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x699B980", Offset = "0x6999F80", VA = "0x18699B980", Slot = "14")]
	public void GNJEAEPJFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x699B970", Offset = "0x6999F70", VA = "0x18699B970", Slot = "18")]
	public void GIGJIGBDLKK([Optional] string CCOBICFGCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x699B570", Offset = "0x6999B70", VA = "0x18699B570", Slot = "15")]
	public void BEOCLCMNKAK(string EPLFNDNPINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x699B850", Offset = "0x6999E50", VA = "0x18699B850", Slot = "12")]
	public void GEIKDOPOHJA(HNBNLIBLIMP NGHALOPECFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x699BE20", Offset = "0x699A420", VA = "0x18699BE20")]
	private void LDCONPFFBGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x699C260", Offset = "0x699A860", VA = "0x18699C260")]
	[MonoPInvokeCallback(typeof(ODPAPPDGPFD))]
	private static void OGFAPDDALBC(string KPHFBJDIBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x699B920", Offset = "0x6999F20", VA = "0x18699B920")]
	[MonoPInvokeCallback(typeof(HKLBMMDCGPK))]
	private static int GEOAIBNLNPI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x699B7E0", Offset = "0x6999DE0", VA = "0x18699B7E0")]
	private void FKMAFCJECCN(string KILNHNEIELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x699B650", Offset = "0x6999C50", VA = "0x18699B650")]
	private void CNNOIBGNPAN(ODPAPPDGPFD AHJILKLLLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x699BBC0", Offset = "0x699A1C0", VA = "0x18699BBC0")]
	private void JIAMLNDLCDE(HKLBMMDCGPK AHJILKLLLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x699B990", Offset = "0x6999F90", VA = "0x18699B990")]
	private void GNJEAEPJFEA(GHPDFHLBJKI CLPBFEAPBCA, string ADAGBMIAJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x699B460", Offset = "0x6999A60", VA = "0x18699B460")]
	private void AFPCMMGECKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x699C2C0", Offset = "0x699A8C0", VA = "0x18699C2C0")]
	private long? OHMOLLEKJLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x699B5A0", Offset = "0x6999BA0", VA = "0x18699B5A0")]
	private long? CGGPPIHLGFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x699C370", Offset = "0x699A970", VA = "0x18699C370")]
	private Guid? OMHKKGFBCJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x699BB10", Offset = "0x699A110", VA = "0x18699BB10")]
	private double? HFCGGMMKADN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x699B1B0", Offset = "0x69997B0", VA = "0x18699B1B0")]
	internal static void BFBPLNPKOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x699BD00", Offset = "0x699A300", VA = "0x18699BD00")]
	private void KJCJBAAOMJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AILJJJEFMCI
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x699B270", Offset = "0x6999870", VA = "0x18699B270")]
	[PECFDJPHGEK(BOIKMOKIOJG.None)]
	private static void PDECJEAEPFN(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x699B1B0", Offset = "0x69997B0", VA = "0x18699B1B0")]
	[JCLEFGKHEPL(LONMDOPJFCD.Unity_BeforeSceneLoad)]
	private static void MNHIJBNIBME()
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
