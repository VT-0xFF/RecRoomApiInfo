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
public enum MOBLHABIPMC
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
public interface AGJOBPKKDCI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FCOAJHNCDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? GONAFLMIIMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? DPCFJGHACPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? BEMMBCACCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? LNJLBMCAGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DEGBGGLBAND(MOBLHABIPMC ILNNMFPHEJI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NGFHLNOOHDK();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KHCFPMKBONI();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MIBNPGFGINM(string LLJAEKEFAFD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void INLCIDLJOEA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OHBDABGMHDN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DOPKEPEJKDE(BEPIIIJPHLC DKDEPGAILDF, [Optional] CancellationToken HNLFPBLPOKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LGCCABDEMID : AGJOBPKKDCI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum LPJNLKFEEPH
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void FMNEONDFPDN(string DKDEPGAILDF);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int HPNHDGEIAHO();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static LGCCABDEMID CONPDDCOPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool KOJPDGBKFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool GEHFKNJJKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool MHOCIPGFEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool GBMBEADEOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? HNJDNCBFLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool OFJAABPKLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long? BKFLDKJECGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool HFAPPHJHFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Guid? NJKPOIAEHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IHEGMKEPADJ NHGOLBIKFPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MOBLHABIPMC MHHHAEONKGP;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool FCOAJHNCDNL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? GONAFLMIIMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FA51B0", Offset = "0x5FA45B0", VA = "0x185FA51B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? DPCFJGHACPG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FA4F40", Offset = "0x5FA4340", VA = "0x185FA4F40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? BEMMBCACCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FA52F0", Offset = "0x5FA46F0", VA = "0x185FA52F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? LNJLBMCAGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5FA5030", Offset = "0x5FA4430", VA = "0x185FA5030", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA53F0", Offset = "0x5FA47F0", VA = "0x185FA53F0")]
	[Preserve]
	public LGCCABDEMID([CNGDHLLDFHE(null)] IHEGMKEPADJ NHGOLBIKFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4CF0", Offset = "0x5FA40F0", VA = "0x185FA4CF0", Slot = "10")]
	public void NGFHLNOOHDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x32F62C0", Offset = "0x32F56C0", VA = "0x1832F62C0", Slot = "13")]
	public void INLCIDLJOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5FA46A0", Offset = "0x5FA3AA0", VA = "0x185FA46A0", Slot = "11")]
	public void KHCFPMKBONI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4200", Offset = "0x5FA3600", VA = "0x185FA4200", Slot = "14")]
	public void DELNMEDMAJO([Optional] string NDDJGFHBJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4860", Offset = "0x5FA3C60", VA = "0x185FA4860", Slot = "12")]
	public void MIBNPGFGINM(string LLJAEKEFAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4140", Offset = "0x5FA3540", VA = "0x185FA4140", Slot = "9")]
	public void DEGBGGLBAND(MOBLHABIPMC ILNNMFPHEJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4870", Offset = "0x5FA3C70", VA = "0x185FA4870")]
	private void MIIDDPOMDPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4550", Offset = "0x5FA3950", VA = "0x185FA4550")]
	[MonoPInvokeCallback(typeof(FMNEONDFPDN))]
	private static void JIOLMAOANFH(string NDIHGNADIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FA52A0", Offset = "0x5FA46A0", VA = "0x185FA52A0")]
	[MonoPInvokeCallback(typeof(HPNHDGEIAHO))]
	private static int PIJKJEPMGLH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA5140", Offset = "0x5FA4540", VA = "0x185FA5140")]
	private void PGOHGLCCDCI(string ADPHLEPNCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4E20", Offset = "0x5FA4220", VA = "0x185FA4E20")]
	private void NODLJPDEGOL(FMNEONDFPDN DBIEPHLOFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FA42C0", Offset = "0x5FA36C0", VA = "0x185FA42C0")]
	private void FJGHPNEOBOL(HPNHDGEIAHO DBIEPHLOFKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5FA46B0", Offset = "0x5FA3AB0", VA = "0x185FA46B0")]
	private void KHCFPMKBONI(LPJNLKFEEPH LCAIGDLPJAO, string OOMBFFOGJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4EB0", Offset = "0x5FA42B0", VA = "0x185FA4EB0")]
	private void ODJFFCAKJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4C40", Offset = "0x5FA4040", VA = "0x185FA4C40")]
	private long? NCDNDKOHIKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4B90", Offset = "0x5FA3F90", VA = "0x185FA4B90")]
	private long? MMCOLLKCOBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5FA44A0", Offset = "0x5FA38A0", VA = "0x185FA44A0")]
	private Guid? IKAAKLNPAPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4210", Offset = "0x5FA3610", VA = "0x185FA4210")]
	private double? FGKNALKOEGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3F80", Offset = "0x5FA3380", VA = "0x185FA3F80")]
	internal static void OJFPHDGJDPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4740", Offset = "0x5FA3B40", VA = "0x185FA4740")]
	private void KKPJKKPLCOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4350", Offset = "0x5FA3750", VA = "0x185FA4350")]
	[CompilerGenerated]
	private void HAFIMDFJKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class BHAIAGMCNFL
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5FA4040", Offset = "0x5FA3440", VA = "0x185FA4040")]
	[NEHHKLCIMGL(OJLOCLENGNC.None)]
	private static void DMAEDBKEFEF(BHJKECHLECD CHBOBHMMJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5FA3F80", Offset = "0x5FA3380", VA = "0x185FA3F80")]
	[DDPIKLHKBPE(PCHEJJBEMBB.Unity_BeforeSceneLoad)]
	private static void BJNNJGCMPCN()
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
