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
public enum LLHFKOJCMKN
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
public interface KGJLGMIFLEK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JPCOHOPOJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? FAKMGDOEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? OKBFOPOBFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? PEMDFHCEDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? DMPFEKEAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	KGDONOEOPOG JNDFAMEMOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> IGKFNCFNOGI;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BAMMPENDHJK(LLHFKOJCMKN DAGLKLOEBMA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DIHNAABPOCM();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HBGMGOJGOHA();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void IDBIENDOEEL(string COBPFHINIBC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GLDPDLOPNCP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PJBOLDIJNMD
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task CPCJMEKIPIG(KGDONOEOPOG AMMCKFNGLAG, [Optional] CancellationToken ODNHMAMKFFP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EOFJMEDFHDB : KGJLGMIFLEK
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum OPJALDMIDCI
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void JCDDCECDLAC(string AMMCKFNGLAG);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int PEAHPGFLLJN();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static EOFJMEDFHDB OFKHAJDAKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly CKECBDNFIAF MLLPDLCJEAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool KOACPDIIKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool NBIGCLIFOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool CANOJLNKJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool JEAPCEACEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? LPIFIOLGGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool EOOKCHFOMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private long? GKAHHKNDHNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool GGCMNBDEHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Guid? BHLBOLBIEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private LLHFKOJCMKN JEJPCLMPALE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JPCOHOPOJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? FAKMGDOEAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x68B0690", Offset = "0x68AEE90", VA = "0x1868B0690", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? OKBFOPOBFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x68B0F20", Offset = "0x68AF720", VA = "0x1868B0F20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? PEMDFHCEDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68B0E20", Offset = "0x68AF620", VA = "0x1868B0E20", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? DMPFEKEAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68B04C0", Offset = "0x68AECC0", VA = "0x1868B04C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public KGDONOEOPOG JNDFAMEMOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x843F90", Offset = "0x842790", VA = "0x180843F90", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x843FD0", Offset = "0x8427D0", VA = "0x180843FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> IGKFNCFNOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68B0410", Offset = "0x68AEC10", VA = "0x1868B0410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68B1330", Offset = "0x68AFB30", VA = "0x1868B1330", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x68B0C00", Offset = "0x68AF400", VA = "0x1868B0C00")]
	private void MLIKGMGOBHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x68B1430", Offset = "0x68AFC30", VA = "0x1868B1430")]
	[Preserve]
	public EOFJMEDFHDB([GNKLNMHODGG(null)] CKECBDNFIAF MLLPDLCJEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68B03E0", Offset = "0x68AEBE0", VA = "0x1868B03E0", Slot = "13")]
	public void DIHNAABPOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68B0680", Offset = "0x68AEE80", VA = "0x1868B0680", Slot = "16")]
	public void GLDPDLOPNCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68B0A20", Offset = "0x68AF220", VA = "0x1868B0A20", Slot = "17")]
	public void MIJBHCMNBJB(string CABKLNKNCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68B0780", Offset = "0x68AEF80", VA = "0x1868B0780", Slot = "14")]
	public void HBGMGOJGOHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68B0400", Offset = "0x68AEC00", VA = "0x1868B0400", Slot = "18")]
	public void EACGANPBCCJ([Optional] string ECCOLONPBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68B0960", Offset = "0x68AF160", VA = "0x1868B0960", Slot = "15")]
	public void IDBIENDOEEL(string COBPFHINIBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68B0160", Offset = "0x68AE960", VA = "0x1868B0160", Slot = "12")]
	public void BAMMPENDHJK(LLHFKOJCMKN DAGLKLOEBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68B1010", Offset = "0x68AF810", VA = "0x1868B1010")]
	private void PGGOGDAOCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x68B13E0", Offset = "0x68AFBE0", VA = "0x1868B13E0")]
	[MonoPInvokeCallback(typeof(JCDDCECDLAC))]
	private static void POPEANKPAKA(string CABKLNKNCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x68B0110", Offset = "0x68AE910", VA = "0x1868B0110")]
	[MonoPInvokeCallback(typeof(PEAHPGFLLJN))]
	private static int AIBLNKPICGN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x68B02C0", Offset = "0x68AEAC0", VA = "0x1868B02C0")]
	private void BLPPOKHALKG(string ODJAPCKHMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x68B0230", Offset = "0x68AEA30", VA = "0x1868B0230")]
	private void BHHHCCKBAKB(JCDDCECDLAC GLJPAFELCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x68B0820", Offset = "0x68AF020", VA = "0x1868B0820")]
	private void HELHNPNIHHM(PEAHPGFLLJN GLJPAFELCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x68B0790", Offset = "0x68AEF90", VA = "0x1868B0790")]
	private void HBGMGOJGOHA(OPJALDMIDCI DAGAMHLIEBK, string CKBILPCMCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x68B0C80", Offset = "0x68AF480", VA = "0x1868B0C80")]
	private void NHJDJGNGELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x68B0970", Offset = "0x68AF170", VA = "0x1868B0970")]
	private long? KDAAGHJMPDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x68B0330", Offset = "0x68AEB30", VA = "0x1868B0330")]
	private long? CEHGKADIAGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x68B05D0", Offset = "0x68AEDD0", VA = "0x1868B05D0")]
	private Guid? FOPEEGPLLMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x68B08B0", Offset = "0x68AF0B0", VA = "0x1868B08B0")]
	private double? IAFBALNLNHE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68B0050", Offset = "0x68AE850", VA = "0x1868B0050")]
	internal static void OLKPDEJEJJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x68B0D10", Offset = "0x68AF510", VA = "0x1868B0D10")]
	private void NNLGINHIEBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CCIFIONHKLO
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68AFF50", Offset = "0x68AE750", VA = "0x1868AFF50")]
	[ANLGLDAOJJE(ELBANFBEGNE.None)]
	private static void IOJDKJKPMEL(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68B0050", Offset = "0x68AE850", VA = "0x1868B0050")]
	[ODHFHHNMGDK(MHEOPBLLNDG.Unity_BeforeSceneLoad)]
	private static void PELDBADPMPL()
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
