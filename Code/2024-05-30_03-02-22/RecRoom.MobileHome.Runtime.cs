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
public enum CBICLCLIHMF
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
public interface KOJEDDACOBB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NCGAPCGFBNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? IAMENBJJCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? NNIGIHKGILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? HKBDDLKBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? BLDHLDGCJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	ODHFIIMBHLE AHHCFBOJILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> KLPGFKFGLBG;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LBGJKOEHEBJ(CBICLCLIHMF JLPFJEBDMDB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CNOOLEDIEBH();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JDKDLMBHDJF();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void MPGBJDCLMDN(string BPMOENBDEJN);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MMHOIBBPFHN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface ANJIKFFMGGM
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task PBOEOPELFJG(ODHFIIMBHLE ABIGAALAKKE, [Optional] CancellationToken GILHKFNDIJP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FKEJOPAOBHI : KOJEDDACOBB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum HEFGLOJDKKI
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void LIFIFDADCOK(string ABIGAALAKKE);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int BIBFABHKHLP();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static FKEJOPAOBHI PNLOKOBAKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HNMFBCLJGLA FJBDPJEPIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool GBNMEIPOBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool JHLLEPMKOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool MHMJEJPBHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool AOHMCINNHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? GLMGAMLMKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool BHNPNFHCAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private long? ECKGHLLFPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool NPEGMOAANHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Guid? CLCKJNKNLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private CBICLCLIHMF DOIBNBLEOOC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool NCGAPCGFBNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? IAMENBJJCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6457280", Offset = "0x6456480", VA = "0x186457280", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? NNIGIHKGILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6457140", Offset = "0x6456340", VA = "0x186457140", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? HKBDDLKBDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6457730", Offset = "0x6456930", VA = "0x186457730", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? BLDHLDGCJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6457CD0", Offset = "0x6456ED0", VA = "0x186457CD0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ODHFIIMBHLE AHHCFBOJILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7CE890", Offset = "0x7CDA90", VA = "0x1807CE890", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7CE960", Offset = "0x7CDB60", VA = "0x1807CE960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> KLPGFKFGLBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6457090", Offset = "0x6456290", VA = "0x186457090", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6457B10", Offset = "0x6456D10", VA = "0x186457B10", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6457DF0", Offset = "0x6456FF0", VA = "0x186457DF0")]
	private void NCMPLGAFABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6458300", Offset = "0x6457500", VA = "0x186458300")]
	[Preserve]
	public FKEJOPAOBHI([KFHLAIGNCCH(null)] HNMFBCLJGLA FJBDPJEPIDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6457070", Offset = "0x6456270", VA = "0x186457070", Slot = "13")]
	public void CNOOLEDIEBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6457C30", Offset = "0x6456E30", VA = "0x186457C30", Slot = "16")]
	public void MMHOIBBPFHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6458120", Offset = "0x6457320", VA = "0x186458120", Slot = "17")]
	public void PBGICJNPBJA(string PFCMENBJHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6457720", Offset = "0x6456920", VA = "0x186457720", Slot = "14")]
	public void JDKDLMBHDJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6457060", Offset = "0x6456260", VA = "0x186457060", Slot = "18")]
	public void CHPIFFOOKDH([Optional] string GCFCBPJKPMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6457DE0", Offset = "0x6456FE0", VA = "0x186457DE0", Slot = "15")]
	public void MPGBJDCLMDN(string BPMOENBDEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x64579E0", Offset = "0x6456BE0", VA = "0x1864579E0", Slot = "12")]
	public void LBGJKOEHEBJ(CBICLCLIHMF JLPFJEBDMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6457370", Offset = "0x6456570", VA = "0x186457370")]
	private void IBFFEEADFEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6457AB0", Offset = "0x6456CB0", VA = "0x186457AB0")]
	[MonoPInvokeCallback(typeof(LIFIFDADCOK))]
	private static void LEAIAGOHLNP(string PFCMENBJHEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6457230", Offset = "0x6456430", VA = "0x186457230")]
	[MonoPInvokeCallback(typeof(BIBFABHKHLP))]
	private static int FNFJPMGHOCJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6457BC0", Offset = "0x6456DC0", VA = "0x186457BC0")]
	private void MJACCDJDGEM(string PKFJJJHKDJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6457C40", Offset = "0x6456E40", VA = "0x186457C40")]
	private void MNAKBAGIEOO(LIFIFDADCOK GPGHCLCHGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6457FE0", Offset = "0x64571E0", VA = "0x186457FE0")]
	private void OKIIGDDHHAO(BIBFABHKHLP GPGHCLCHGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6457690", Offset = "0x6456890", VA = "0x186457690")]
	private void JDKDLMBHDJF(HEFGLOJDKKI NCKBEFBPNFM, string BMNELJCNLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6457830", Offset = "0x6456A30", VA = "0x186457830")]
	private void JPMDIOKEEAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6456FB0", Offset = "0x64561B0", VA = "0x186456FB0")]
	private long? BEEJAFJJIAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6458070", Offset = "0x6457270", VA = "0x186458070")]
	private long? OMBCMNMMPKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6457E70", Offset = "0x6457070", VA = "0x186457E70")]
	private Guid? NGAENJMANAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6456F00", Offset = "0x6456100", VA = "0x186456F00")]
	private double? BBHPGMNMHAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6457F20", Offset = "0x6457120", VA = "0x186457F20")]
	internal static void OHCEKEABMFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x64578C0", Offset = "0x6456AC0", VA = "0x1864578C0")]
	private void KECGOKABEEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OEJNKGLFOOG
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6458380", Offset = "0x6457580", VA = "0x186458380")]
	[JIMPHGEJKMA(CLDBMEKPFFP.None)]
	private static void OKAINDBHHOL(EHGDBDLIOFB IFAAMIKFIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6457F20", Offset = "0x6457120", VA = "0x186457F20")]
	[HCFPGNPFDEC(FELFKELNNKC.Unity_BeforeSceneLoad)]
	private static void FKGJBIBNIHI()
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
