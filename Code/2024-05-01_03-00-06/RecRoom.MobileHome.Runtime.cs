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
public enum FEECPCOJDJI
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
public interface IBBFOCDCHCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EKKNBGOHAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? NEIAEOOOOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? PGLFCECHHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? FPBCMOBBMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? EOFPOKOKJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	IFCCKGFAINE NFNIBDNHKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> NGFIELJPOED;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FHJEKGMMFEC(FEECPCOJDJI DEPIDMABJHK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HBPIHILNAPB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OENKGOHJIEP();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CMNICPANCAC(string NJMOGJMJHOJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GKIBOMIFMPC();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GPBPKELKPKF
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LNJPKCCKFON(IFCCKGFAINE HBNLKONMHNP, [Optional] CancellationToken KANPDHELHMD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ENLBPDMFFEJ : IBBFOCDCHCM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum BBGGFNNIOLE
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void JKEGENMKPIE(string HBNLKONMHNP);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int HDOEHAHHMBB();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static ENLBPDMFFEJ LOMIFCBLBKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly AFNONAOOEPJ IMMPCMCONFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool FDGJAELKKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool FPBOGCOGBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool AJNKPJEAJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool GJOPIGAEMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? HPNCECGIBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool HGPFFCEMHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private long? MMLKPGFDDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private bool FEJFEPLDKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Guid? HDNNAHNONOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private FEECPCOJDJI OKFKJJONDEB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EKKNBGOHAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? NEIAEOOOOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x626EC70", Offset = "0x626DA70", VA = "0x18626EC70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? PGLFCECHHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x626E540", Offset = "0x626D340", VA = "0x18626E540", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? FPBCMOBBMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x626E6B0", Offset = "0x626D4B0", VA = "0x18626E6B0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? EOFPOKOKJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x626E350", Offset = "0x626D150", VA = "0x18626E350", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IFCCKGFAINE NFNIBDNHKBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B7070", Offset = "0x7B5E70", VA = "0x1807B7070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> NGFIELJPOED
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x626D9E0", Offset = "0x626C7E0", VA = "0x18626D9E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x626EBC0", Offset = "0x626D9C0", VA = "0x18626EBC0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x626E630", Offset = "0x626D430", VA = "0x18626E630")]
	private void IHPIEEAMBGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x626ED60", Offset = "0x626DB60", VA = "0x18626ED60")]
	[Preserve]
	public ENLBPDMFFEJ([PENMPEOFMMN(null)] AFNONAOOEPJ IMMPCMCONFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x626E520", Offset = "0x626D320", VA = "0x18626E520", Slot = "13")]
	public void HBPIHILNAPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x626E460", Offset = "0x626D260", VA = "0x18626E460", Slot = "16")]
	public void GKIBOMIFMPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x626E0B0", Offset = "0x626CEB0", VA = "0x18626E0B0", Slot = "17")]
	public void EJPPOHPGJMM(string DCDPDDFOGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x626EB20", Offset = "0x626D920", VA = "0x18626EB20", Slot = "14")]
	public void OENKGOHJIEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x626E840", Offset = "0x626D640", VA = "0x18626E840", Slot = "18")]
	public void KFKKPOHEIOI([Optional] string GEOECMMGOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x626DF00", Offset = "0x626CD00", VA = "0x18626DF00", Slot = "15")]
	public void CMNICPANCAC(string NJMOGJMJHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x626E280", Offset = "0x626D080", VA = "0x18626E280", Slot = "12")]
	public void FHJEKGMMFEC(FEECPCOJDJI DEPIDMABJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x626DBE0", Offset = "0x626C9E0", VA = "0x18626DBE0")]
	private void CBMOCEIJBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x626D990", Offset = "0x626C790", VA = "0x18626D990")]
	[MonoPInvokeCallback(typeof(JKEGENMKPIE))]
	private static void AHPNKFLKMIE(string DCDPDDFOGDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x626DB00", Offset = "0x626C900", VA = "0x18626DB00")]
	[MonoPInvokeCallback(typeof(HDOEHAHHMBB))]
	private static int BJOAHAKNGKK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x626DA90", Offset = "0x626C890", VA = "0x18626DA90")]
	private void BHEPMPELMBF(string LAOLEPDFPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x626E7B0", Offset = "0x626D5B0", VA = "0x18626E7B0")]
	private void JMMBHBIKMOF(JKEGENMKPIE KPIAINDMMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x626DB50", Offset = "0x626C950", VA = "0x18626DB50")]
	private void BNIHOHOEODG(HDOEHAHHMBB KPIAINDMMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x626EB30", Offset = "0x626D930", VA = "0x18626EB30")]
	private void OENKGOHJIEP(BBGGFNNIOLE JNFKLJKGAMI, string OMOKBKDMNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x626E020", Offset = "0x626CE20", VA = "0x18626E020")]
	private void DDDNANMPKKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x626E9C0", Offset = "0x626D7C0", VA = "0x18626E9C0")]
	private long? NLHICDJJGOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x626EA70", Offset = "0x626D870", VA = "0x18626EA70")]
	private long? NOBMICDIJPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x626E470", Offset = "0x626D270", VA = "0x18626E470")]
	private Guid? GLHLNJGCEPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x626E850", Offset = "0x626D650", VA = "0x18626E850")]
	private double? MDACJIEEIEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x626E900", Offset = "0x626D700", VA = "0x18626E900")]
	internal static void MDJKHAAEKOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x626DF10", Offset = "0x626CD10", VA = "0x18626DF10")]
	private void DAIGEFFDFBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OGFDJBLLPHC
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x626EDE0", Offset = "0x626DBE0", VA = "0x18626EDE0")]
	[DPHBJKOLDBD(OHNOEEJKPCM.None)]
	private static void GLMPPFGOPJL(NAINNGGFMLM COEPBABOGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x626E900", Offset = "0x626D700", VA = "0x18626E900")]
	[MCGCGJJLKLL(PHCHACMKDPF.Unity_BeforeSceneLoad)]
	private static void DCFJLCOPHIL()
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
