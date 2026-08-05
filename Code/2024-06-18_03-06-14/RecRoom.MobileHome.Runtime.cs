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
public enum PJOMLJMNKOH
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
public interface OOONFJKJOEK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DGMKJEJILKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? OPGADLMKGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? LPBFJIFJDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? NBANKEGKCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? LFJHPGHGCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IHHLHHJJIGK AEDODMDPAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> DCBGMKDMDJM;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HGMKHHABLIF(PJOMLJMNKOH FAKDNFCMPPB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CCPNKNOIBEC();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BBLAEFHMKED();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LCCFAJFAICO(string KMGMFBCECLK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FEAOLAEOEPB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IJIGHNDDLIF
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DCILPOIJDEG(IHHLHHJJIGK POENNLMDDIL, [Optional] CancellationToken AOLOJHLCMLE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MEDKKPFKMAO : OOONFJKJOEK
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum PJENDKAKIKL
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void ELCOGMJAMEA(string POENNLMDDIL);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int PCEFMINPIMG();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static MEDKKPFKMAO LGHIKPMCACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly BACKHJNLNPC IKGNLPJPPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool MFMFOABKLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool OFMPIOBPIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool EOCNMKDBINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool MOKCGAAJGDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? CFNEPIFBAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool EKJECBEFPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private long? LJKGGFFBCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool CJBOGOGHPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Guid? ECDJAJFNJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private PJOMLJMNKOH ALGCIFAGAHF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DGMKJEJILKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? OPGADLMKGKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6927830", Offset = "0x6926230", VA = "0x186927830", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? LPBFJIFJDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6927100", Offset = "0x6925B00", VA = "0x186927100", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? NBANKEGKCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6927250", Offset = "0x6925C50", VA = "0x186927250", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? LFJHPGHGCBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6928210", Offset = "0x6926C10", VA = "0x186928210", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IHHLHHJJIGK AEDODMDPAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84FE40", Offset = "0x84E840", VA = "0x18084FE40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84FCB0", Offset = "0x84E6B0", VA = "0x18084FCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> DCBGMKDMDJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6927A10", Offset = "0x6926410", VA = "0x186927A10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6927050", Offset = "0x6925A50", VA = "0x186927050", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6927AC0", Offset = "0x69264C0", VA = "0x186927AC0")]
	private void LIDJLKFANLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6928320", Offset = "0x6926D20", VA = "0x186928320")]
	[Preserve]
	public MEDKKPFKMAO([OHLKLPAILPF(null)] BACKHJNLNPC IKGNLPJPPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6927030", Offset = "0x6925A30", VA = "0x186927030", Slot = "13")]
	public void CCPNKNOIBEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6927350", Offset = "0x6925D50", VA = "0x186927350", Slot = "16")]
	public void FEAOLAEOEPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6927BD0", Offset = "0x69265D0", VA = "0x186927BD0", Slot = "17")]
	public void MODJMOBHKMK(string GCOFFLPIIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6926F90", Offset = "0x6925990", VA = "0x186926F90", Slot = "14")]
	public void BBLAEFHMKED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6927410", Offset = "0x6925E10", VA = "0x186927410", Slot = "18")]
	public void GLCIHMLDANH([Optional] string GOJEMCBHHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6927A00", Offset = "0x6926400", VA = "0x186927A00", Slot = "15")]
	public void LCCFAJFAICO(string KMGMFBCECLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69274E0", Offset = "0x6925EE0", VA = "0x1869274E0", Slot = "12")]
	public void HGMKHHABLIF(PJOMLJMNKOH FAKDNFCMPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6927EF0", Offset = "0x69268F0", VA = "0x186927EF0")]
	private void PGFBLONDMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69271F0", Offset = "0x6925BF0", VA = "0x1869271F0")]
	[MonoPInvokeCallback(typeof(ELCOGMJAMEA))]
	private static void DFKPBALHAAP(string GCOFFLPIIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6927920", Offset = "0x6926320", VA = "0x186927920")]
	[MonoPInvokeCallback(typeof(PCEFMINPIMG))]
	private static int JFICFGHGMLM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6926F20", Offset = "0x6925920", VA = "0x186926F20")]
	private void ABEFLIBADAO(string OMAFNKHKHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6927970", Offset = "0x6926370", VA = "0x186927970")]
	private void KIKCKKDEBOJ(ELCOGMJAMEA BHKFHJNIBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6927B40", Offset = "0x6926540", VA = "0x186927B40")]
	private void MGIGPCMBNJP(PCEFMINPIMG BHKFHJNIBAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6926FA0", Offset = "0x69259A0", VA = "0x186926FA0")]
	private void BBLAEFHMKED(PJENDKAKIKL GDIKEMIFDHP, string IJJCJPADFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6927E60", Offset = "0x6926860", VA = "0x186927E60")]
	private void OGPPBPBDGFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6927360", Offset = "0x6925D60", VA = "0x186927360")]
	private long? GJAJFMCNFJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6927DB0", Offset = "0x69267B0", VA = "0x186927DB0")]
	private long? NMDBEGJCEJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69275B0", Offset = "0x6925FB0", VA = "0x1869275B0")]
	private Guid? HMANENDGEIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6927660", Offset = "0x6926060", VA = "0x186927660")]
	private double? IADCPBEIDEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6927420", Offset = "0x6925E20", VA = "0x186927420")]
	internal static void HDOPBNJHENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6927710", Offset = "0x6926110", VA = "0x186927710")]
	private void IDBKLBPIAPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NLGAKOFGNNA
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69283A0", Offset = "0x6926DA0", VA = "0x1869283A0")]
	[MHFEIEAPENL(CMFCLNIIIKO.None)]
	private static void HMIEDEJHNLC(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6927420", Offset = "0x6925E20", VA = "0x186927420")]
	[DMPANLBIAGM(ACEEKKJJCPD.Unity_BeforeSceneLoad)]
	private static void DCDLNJBNACK()
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
