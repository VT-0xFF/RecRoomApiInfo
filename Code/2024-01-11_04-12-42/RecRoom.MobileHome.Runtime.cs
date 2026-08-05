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
public enum IOPIJEJIAPE
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
public interface AIEBMBPGECD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BJJGDNHOOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? HIPLHFKENPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? HFCEHELIAGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? FEIANFGDIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? LEOFJJLMPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABFJILFNLLA(IOPIJEJIAPE HELMNHPMHNC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IAMMEFBKIFH();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FMDKGEFKMNK();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LGPPODJIIMA(string IHGCNAFBNIC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void POJGPHKBILJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BHIHNMLAJFC
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PCOJMGHHKEG(EDKBIMPKHAP MAPKGHIABMO, [Optional] CancellationToken EAPNOLMLMHM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KDINPOIBDED : AIEBMBPGECD
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum DPCKKGAMNOI
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void NMOGOLOGJMI(string MAPKGHIABMO);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int HKJEBMBOEIM();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static KDINPOIBDED BDFKMGIHPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool LDEJJIBMEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool PJPBCDOMMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool FOLBMEHFFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool DOKPJDOIEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? KEHCKDPNBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool GDNPIAIGGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long? FNJFKHHNLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool GJEOPFJHEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Guid? KFDJBGLNGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly PHNKKHEMGLI PBDDCJAGGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private IOPIJEJIAPE LIPCOFHGIPB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BJJGDNHOOAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? HIPLHFKENPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6019620", Offset = "0x6018020", VA = "0x186019620", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? HFCEHELIAGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6019350", Offset = "0x6017D50", VA = "0x186019350", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? FEIANFGDIGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6018960", Offset = "0x6017360", VA = "0x186018960", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? LEOFJJLMPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6018DC0", Offset = "0x60177C0", VA = "0x186018DC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6019850", Offset = "0x6018250", VA = "0x186019850")]
	[Preserve]
	public KDINPOIBDED([KNBPONIPMPA(null)] PHNKKHEMGLI PBDDCJAGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6018AB0", Offset = "0x60174B0", VA = "0x186018AB0", Slot = "10")]
	public void IAMMEFBKIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3329120", Offset = "0x3327B20", VA = "0x183329120", Slot = "13")]
	public void POJGPHKBILJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x60188C0", Offset = "0x60172C0", VA = "0x1860188C0", Slot = "11")]
	public void FMDKGEFKMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6018C50", Offset = "0x6017650", VA = "0x186018C50", Slot = "14")]
	public void JEFAOCEKLAC([Optional] string MMECPFELGDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60191F0", Offset = "0x6017BF0", VA = "0x1860191F0", Slot = "12")]
	public void LGPPODJIIMA(string IHGCNAFBNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60185A0", Offset = "0x6016FA0", VA = "0x1860185A0", Slot = "9")]
	public void ABFJILFNLLA(IOPIJEJIAPE HELMNHPMHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6018ED0", Offset = "0x60178D0", VA = "0x186018ED0")]
	private void LGBCCLNPDBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6019440", Offset = "0x6017E40", VA = "0x186019440")]
	[MonoPInvokeCallback(typeof(NMOGOLOGJMI))]
	private static void NCPPEHIFFAD(string AODEBBPMBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6018A60", Offset = "0x6017460", VA = "0x186018A60")]
	[MonoPInvokeCallback(typeof(HKJEBMBOEIM))]
	private static int HGKDBCGGAKO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6018BE0", Offset = "0x60175E0", VA = "0x186018BE0")]
	private void IBCPPHHDMNO(string OBHHJDJJIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6019590", Offset = "0x6017F90", VA = "0x186019590")]
	private void NPHBIPCOIFG(NMOGOLOGJMI MKEOIOPNPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6018830", Offset = "0x6017230", VA = "0x186018830")]
	private void DNMINCNOBJN(HKJEBMBOEIM MKEOIOPNPIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60188D0", Offset = "0x60172D0", VA = "0x1860188D0")]
	private void FMDKGEFKMNK(DPCKKGAMNOI OPBOHICBHLE, string JCMDABMHJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6019710", Offset = "0x6018110", VA = "0x186019710")]
	private void OPDLDEEJGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60197A0", Offset = "0x60181A0", VA = "0x1860197A0")]
	private long? PJFKLMBOLED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6018780", Offset = "0x6017180", VA = "0x186018780")]
	private long? CEMBMFAPBEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6018C60", Offset = "0x6017660", VA = "0x186018C60")]
	private Guid? JOCOIMAMJAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6018D10", Offset = "0x6017710", VA = "0x186018D10")]
	private double? KHFAHFMFCEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60183E0", Offset = "0x6016DE0", VA = "0x1860183E0")]
	internal static void DMDMFHLFINH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6018660", Offset = "0x6017060", VA = "0x186018660")]
	private void ACJPNJFKKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6019200", Offset = "0x6017C00", VA = "0x186019200")]
	[CompilerGenerated]
	private void LMOIDMHMAPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ININDKLDLHJ
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60184A0", Offset = "0x6016EA0", VA = "0x1860184A0")]
	[BBBFDPEBAMC(HLEKCCEDPHP.None)]
	private static void PIIFFCABCNO(AFDLAPABCDH DFLLKHNKNDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60183E0", Offset = "0x6016DE0", VA = "0x1860183E0")]
	[DLKEJLMCDAC(LIAHCPEMJMG.Unity_BeforeSceneLoad)]
	private static void FDPBBFHPEHH()
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
