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
public enum EDIJFAANDKB
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
public interface HFAIIGCCLPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AOPGKMOEBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? KEGMDLFONIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? IGCLJBJKGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? AOALEGKEMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? BFPCLNBBFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	GFNLPENIKAO NKNIGLFFFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> DMNMMGOKEKO;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PHAONDJLHNE(EDIJFAANDKB DMDDBNBIFMI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HMCGAKKBHMB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ALKGLNLBPNP();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LOLKNHILIJP(string MCMGPBCLOFD);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void EJHDLEPHEGL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EIJCKNNPNBA
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ODIPOLBLEHK(GFNLPENIKAO ADOIDDNDNLD, [Optional] CancellationToken MPLGBOFHPLM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GLJEEEFDOKM : HFAIIGCCLPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum DAGIFLELAJP
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void PFBMNEPBHNJ(string ADOIDDNDNLD);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int GNJMOPBKLHD();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static GLJEEEFDOKM BOLGDNNEFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly NICHJPMKMDF IBEALNKFJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ADBNOEBBGNC NNMMDENOCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool DADCJCFJHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool KLAPFNEOEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool HKHMLDNLLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool IDHADCNAEJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? CMAKMAOBNND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool LHOFOLPGCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? DGLHMNGCAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool DJBHBHNHLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? PCBNHGMFNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private EDIJFAANDKB BBHJFNGEFAE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool AOPGKMOEBCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? KEGMDLFONIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69510E0", Offset = "0x69502E0", VA = "0x1869510E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? IGCLJBJKGDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6950B00", Offset = "0x694FD00", VA = "0x186950B00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? AOALEGKEMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6950920", Offset = "0x694FB20", VA = "0x186950920", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? BFPCLNBBFKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69511E0", Offset = "0x69503E0", VA = "0x1869511E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GFNLPENIKAO NKNIGLFFFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85FD30", Offset = "0x85EF30", VA = "0x18085FD30", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85FD60", Offset = "0x85EF60", VA = "0x18085FD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> DMNMMGOKEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6950740", Offset = "0x694F940", VA = "0x186950740", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6951030", Offset = "0x6950230", VA = "0x186951030", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6950C10", Offset = "0x694FE10", VA = "0x186950C10")]
	private void FLOLOBGOJKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69518D0", Offset = "0x6950AD0", VA = "0x1869518D0")]
	[Preserve]
	public GLJEEEFDOKM([OMAPKKAGFIL(null)] NICHJPMKMDF IBEALNKFJMI, [OMAPKKAGFIL(null)] ADBNOEBBGNC NNMMDENOCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6950CF0", Offset = "0x694FEF0", VA = "0x186950CF0", Slot = "13")]
	public void HMCGAKKBHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6950BF0", Offset = "0x694FDF0", VA = "0x186950BF0", Slot = "16")]
	public void EJHDLEPHEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6950DC0", Offset = "0x694FFC0", VA = "0x186950DC0", Slot = "17")]
	public void INMNJNKOFMJ(string MGPNNLBFKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69506C0", Offset = "0x694F8C0", VA = "0x1869506C0", Slot = "14")]
	public void ALKGLNLBPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6950C00", Offset = "0x694FE00", VA = "0x186950C00", Slot = "18")]
	public void FKMBNMJJIJN([Optional] string NDBDOOLOIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69511D0", Offset = "0x69503D0", VA = "0x1869511D0", Slot = "15")]
	public void LOLKNHILIJP(string MCMGPBCLOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6951430", Offset = "0x6950630", VA = "0x186951430", Slot = "12")]
	public void PHAONDJLHNE(EDIJFAANDKB DMDDBNBIFMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69515B0", Offset = "0x69507B0", VA = "0x1869515B0")]
	private void POHJGCNNACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6950C90", Offset = "0x694FE90", VA = "0x186950C90")]
	[MonoPInvokeCallback(typeof(PFBMNEPBHNJ))]
	private static void HKMLHMOMKKB(string MGPNNLBFKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6950AB0", Offset = "0x694FCB0", VA = "0x186950AB0")]
	[MonoPInvokeCallback(typeof(GNJMOPBKLHD))]
	private static int DNJBPIPHPPN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69506D0", Offset = "0x694F8D0", VA = "0x1869506D0")]
	private void BHEGJGMNCCB(string IINNADPBALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6950A20", Offset = "0x694FC20", VA = "0x186950A20")]
	private void CONEMFBAKBC(PFBMNEPBHNJ HBBMMHKOEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6950FA0", Offset = "0x69501A0", VA = "0x186950FA0")]
	private void JNOLIEIICFH(GNJMOPBKLHD HBBMMHKOEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6950630", Offset = "0x694F830", VA = "0x186950630")]
	private void ALKGLNLBPNP(DAGIFLELAJP NPGFMGMHJJL, string DBOMBJEFLDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69512F0", Offset = "0x69504F0", VA = "0x1869512F0")]
	private void OCADMFKECNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6951380", Offset = "0x6950580", VA = "0x186951380")]
	private long? OOCALALFJBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6950D10", Offset = "0x694FF10", VA = "0x186950D10")]
	private long? ICODHFHHJGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6950580", Offset = "0x694F780", VA = "0x186950580")]
	private Guid? ACGGNJKAIML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6951500", Offset = "0x6950700", VA = "0x186951500")]
	private double? PHPIMCDNLDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69503C0", Offset = "0x694F5C0", VA = "0x1869503C0")]
	internal static void DIIOGIHPBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69507F0", Offset = "0x694F9F0", VA = "0x1869507F0")]
	private void CGFFHPGDAGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AEEMMHJBDHG
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6950480", Offset = "0x694F680", VA = "0x186950480")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	private static void LAHBKIPICAO(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69503C0", Offset = "0x694F5C0", VA = "0x1869503C0")]
	[FCFOCBHCEIP(MJLCCMEEJMA.Unity_BeforeSceneLoad)]
	private static void HPMHKKKKPPB()
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
