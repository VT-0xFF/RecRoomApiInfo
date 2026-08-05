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
public enum BHODJFJHCPE
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
public interface JIBFIJPPGDB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BNPPFJEGLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? LKNHKHMLPOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? BOHPBJIFMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? KCJMGGFLOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? MFFKLEDOAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LCBHJBFMDPA AKDCKKKPEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> LCKMFDGLCAA;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OEJHHOBJIAC(BHODJFJHCPE FFBJIDDDHKC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NJFEGHENHFC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NFMMLNMPIGM();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EGMINGLLKBO(string EKMKGBJIPDB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LGCHJKLOFLL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NGJJLLPNMKN
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ODLFHAGJNDL(LCBHJBFMDPA JAICNNDBJOG, [Optional] CancellationToken PPKBAEMFIMG);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MPPIIPFFLHA : JIBFIJPPGDB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum FHKEGGGJNEG
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void DENJKGMIGAG(string JAICNNDBJOG);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int FGGOLCDNEPL();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static MPPIIPFFLHA AGABHBIFGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HFDCGAIKGJC NIKFKJHFJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JCNJLOKLNCG EFPPCDLMBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool MKDLEDHNOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool NDMPMFLMNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HHBMCCCFHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool FMNALBANKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? DICIBKKFPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool INGJECDKKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? PJJPGKFPFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool GNCAOOACANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? GDJGACDOGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private BHODJFJHCPE MAODEILCPCO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool BNPPFJEGLBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? LKNHKHMLPOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A2E310", Offset = "0x6A2CF10", VA = "0x186A2E310", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? BOHPBJIFMMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A2E220", Offset = "0x6A2CE20", VA = "0x186A2E220", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? KCJMGGFLOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A2DB10", Offset = "0x6A2C710", VA = "0x186A2DB10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? MFFKLEDOAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A2DDF0", Offset = "0x6A2C9F0", VA = "0x186A2DDF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LCBHJBFMDPA AKDCKKKPEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x872470", Offset = "0x871070", VA = "0x180872470", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x872420", Offset = "0x871020", VA = "0x180872420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> LCKMFDGLCAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A2DF00", Offset = "0x6A2CB00", VA = "0x186A2DF00", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6A2E400", Offset = "0x6A2D000", VA = "0x186A2E400", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A2DFB0", Offset = "0x6A2CBB0", VA = "0x186A2DFB0")]
	private void EGBHCCJPBPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EB40", Offset = "0x6A2D740", VA = "0x186A2EB40")]
	[Preserve]
	public MPPIIPFFLHA([POJODGKFIMO(null)] HFDCGAIKGJC NIKFKJHFJLD, [POJODGKFIMO(null)] JCNJLOKLNCG EFPPCDLMBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E810", Offset = "0x6A2D410", VA = "0x186A2E810", Slot = "13")]
	public void NJFEGHENHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E590", Offset = "0x6A2D190", VA = "0x186A2E590", Slot = "16")]
	public void LGCHJKLOFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A2DC10", Offset = "0x6A2C810", VA = "0x186A2DC10", Slot = "17")]
	public void DONIEFOIOKK(string CGONGBHHKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E6E0", Offset = "0x6A2D2E0", VA = "0x186A2E6E0", Slot = "14")]
	public void NFMMLNMPIGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E0B0", Offset = "0x6A2CCB0", VA = "0x186A2E0B0", Slot = "18")]
	public void GEBPFINMNOO([Optional] string FODHCNBHHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E030", Offset = "0x6A2CC30", VA = "0x186A2E030", Slot = "15")]
	public void EGMINGLLKBO(string EKMKGBJIPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E8E0", Offset = "0x6A2D4E0", VA = "0x186A2E8E0", Slot = "12")]
	public void OEJHHOBJIAC(BHODJFJHCPE FFBJIDDDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D7F0", Offset = "0x6A2C3F0", VA = "0x186A2D7F0")]
	private void AJAFDEGBFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E9B0", Offset = "0x6A2D5B0", VA = "0x186A2E9B0")]
	[MonoPInvokeCallback(typeof(DENJKGMIGAG))]
	private static void ONAEELNBBNE(string CGONGBHHKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E4B0", Offset = "0x6A2D0B0", VA = "0x186A2E4B0")]
	[MonoPInvokeCallback(typeof(FGGOLCDNEPL))]
	private static int JMHMINCCLDO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E040", Offset = "0x6A2CC40", VA = "0x186A2E040")]
	private void EPHJBHFNIBJ(string ABJLFDHICFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E500", Offset = "0x6A2D100", VA = "0x186A2E500")]
	private void JNFEMNGAMJH(DENJKGMIGAG LABOKGHKKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E780", Offset = "0x6A2D380", VA = "0x186A2E780")]
	private void NHHJACFHAGE(FGGOLCDNEPL LABOKGHKKOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E6F0", Offset = "0x6A2D2F0", VA = "0x186A2E6F0")]
	private void NFMMLNMPIGM(FHKEGGGJNEG GLMDIHNLEBJ, string MNODLBKIAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E650", Offset = "0x6A2D250", VA = "0x186A2E650")]
	private void MKGLCKLDNJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E830", Offset = "0x6A2D430", VA = "0x186A2E830")]
	private long? NJOOEBJLBFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E170", Offset = "0x6A2CD70", VA = "0x186A2E170")]
	private long? GIOOBPGNMMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E0C0", Offset = "0x6A2CCC0", VA = "0x186A2E0C0")]
	private Guid? GGEEHKBJFAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E5A0", Offset = "0x6A2D1A0", VA = "0x186A2E5A0")]
	private double? LMMPPDOJMGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D730", Offset = "0x6A2C330", VA = "0x186A2D730")]
	internal static void FGEPBDLJOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EA10", Offset = "0x6A2D610", VA = "0x186A2EA10")]
	private void PNKNGLIABFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FDPFKMGEPJK
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D640", Offset = "0x6A2C240", VA = "0x186A2D640")]
	[DHOHFCLMOGD(IDHBAGABJJA.None)]
	private static void EIIOALHJGEO(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A2D730", Offset = "0x6A2C330", VA = "0x186A2D730")]
	[ECODOIAJHDJ(JPJJCBLCFNP.Unity_BeforeSceneLoad)]
	private static void HEELJDCBEPM()
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
