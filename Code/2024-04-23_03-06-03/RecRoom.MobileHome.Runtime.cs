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
public enum BKBINPIHAMJ
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
public interface LHCIJCDJOAE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JFIHNLFCPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? JGGOKABHFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? JMJJDLCCOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? FFBPABDAMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? CMOHPPPJAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NAJBIPOEEFI ENGFOCPKDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> EDBCDKFHNEJ;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MNFIAMHGODM(BKBINPIHAMJ DKOKOEEPCNN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CJMKLAKCCOG();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FHPALIKIEHK();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OGFIELPDDCA(string BGEJECFEDMH);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FBLADMIHENF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JPKCPIJMLMM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KMHJLHFNEFF(NAJBIPOEEFI MGECLINEGIB, [Optional] CancellationToken GHLJDIEPICD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CHFOMAHHNMB : LHCIJCDJOAE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum JLGKNHDFDHC
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void MHLDMMMLABL(string MGECLINEGIB);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int NNPHBDLCDAO();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static CHFOMAHHNMB ILCIGJJMCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly AKFCCKOFHLL MNLGKLFEOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool IKHJKNMJPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool JOAGGBHPMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool CEDMMOFPIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool NPDCDCCAAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? FAHPPMDKJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool EIAADOHOOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private long? HBFHCDGKFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool HOMFNKKKEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Guid? DBADEIENJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private BKBINPIHAMJ CPAGJFOOIPG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JFIHNLFCPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? JGGOKABHFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6309B00", Offset = "0x6308B00", VA = "0x186309B00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? JMJJDLCCOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x630A890", Offset = "0x6309890", VA = "0x18630A890", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? FFBPABDAMFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x630A040", Offset = "0x6309040", VA = "0x18630A040", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? CMOHPPPJAML
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6309E90", Offset = "0x6308E90", VA = "0x186309E90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NAJBIPOEEFI ENGFOCPKDJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C7960", Offset = "0x7C6960", VA = "0x1807C7960", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C7990", Offset = "0x7C6990", VA = "0x1807C7990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> EDBCDKFHNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x630A140", Offset = "0x6309140", VA = "0x18630A140", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x630A460", Offset = "0x6309460", VA = "0x18630A460", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x630A3E0", Offset = "0x63093E0", VA = "0x18630A3E0")]
	private void IDANHIMMNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x630ABD0", Offset = "0x6309BD0", VA = "0x18630ABD0")]
	[Preserve]
	public CHFOMAHHNMB([POILJEECDED(null)] AKFCCKOFHLL MNLGKLFEOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6309AE0", Offset = "0x6308AE0", VA = "0x186309AE0", Slot = "13")]
	public void CJMKLAKCCOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6309E80", Offset = "0x6308E80", VA = "0x186309E80", Slot = "16")]
	public void FBLADMIHENF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6309C00", Offset = "0x6308C00", VA = "0x186309C00", Slot = "17")]
	public void EDJDGFIKKCG(string EFEKDBPPCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6309FA0", Offset = "0x6308FA0", VA = "0x186309FA0", Slot = "14")]
	public void FHPALIKIEHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6309BF0", Offset = "0x6308BF0", VA = "0x186309BF0", Slot = "18")]
	public void DBFPLJHCCBI([Optional] string OHKNKGLACEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x630ABC0", Offset = "0x6309BC0", VA = "0x18630ABC0", Slot = "15")]
	public void OGFIELPDDCA(string BGEJECFEDMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x630AAF0", Offset = "0x6309AF0", VA = "0x18630AAF0", Slot = "12")]
	public void MNFIAMHGODM(BKBINPIHAMJ DKOKOEEPCNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x63097C0", Offset = "0x63087C0", VA = "0x1863097C0")]
	private void AIMHLLDHGLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x630A710", Offset = "0x6309710", VA = "0x18630A710")]
	[MonoPInvokeCallback(typeof(MHLDMMMLABL))]
	private static void LGHMCPEHPIG(string EFEKDBPPCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x630AAA0", Offset = "0x6309AA0", VA = "0x18630AAA0")]
	[MonoPInvokeCallback(typeof(NNPHBDLCDAO))]
	private static int MGDCANLFGEC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x630AA30", Offset = "0x6309A30", VA = "0x18630AA30")]
	private void MCHJADJJMJE(string HHEOEPKNGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x630A2A0", Offset = "0x63092A0", VA = "0x18630A2A0")]
	private void HIINIAJJMOG(MHLDMMMLABL HLFIKKGGCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x630A5D0", Offset = "0x63095D0", VA = "0x18630A5D0")]
	private void JJAJCMLBOJD(NNPHBDLCDAO HLFIKKGGCCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6309FB0", Offset = "0x6308FB0", VA = "0x186309FB0")]
	private void FHPALIKIEHK(JLGKNHDFDHC KDLIPBNGNPF, string DPNPNDGALJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6309DF0", Offset = "0x6308DF0", VA = "0x186309DF0")]
	private void EFCGONMMHMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x630A660", Offset = "0x6309660", VA = "0x18630A660")]
	private long? KCHDAHDNGCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x630A980", Offset = "0x6309980", VA = "0x18630A980")]
	private long? MBANJDLOPED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x630A330", Offset = "0x6309330", VA = "0x18630A330")]
	private Guid? HPNKABENDCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x630A1F0", Offset = "0x63091F0", VA = "0x18630A1F0")]
	private double? GFPDFPDCNKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x630A510", Offset = "0x6309510", VA = "0x18630A510")]
	internal static void INMAGHNDCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x630A770", Offset = "0x6309770", VA = "0x18630A770")]
	private void LJFPAFMJHLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MNPBNCADGDP
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x630AC50", Offset = "0x6309C50", VA = "0x18630AC50")]
	[ILJDPBHFAFI(DIDBPCEENMM.None)]
	private static void KDNIGEBECPO(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x630A510", Offset = "0x6309510", VA = "0x18630A510")]
	[JONKOHOJNNC(CDBPKHMDHEP.Unity_BeforeSceneLoad)]
	private static void CNPJMCFIDJN()
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
