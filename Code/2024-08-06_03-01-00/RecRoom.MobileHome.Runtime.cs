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
public enum GPLIOPEIBCN
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
public interface MBECPIFEOOD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MNMMJLBHGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? LPMBHFNNKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? MBLNFPLJHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? GMKKOCNGJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? GOPENAGMHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	HMDEECGHJFL FOLMBNNKBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> EKKHMFEGGCK;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KMEBKHCKMCF(GPLIOPEIBCN HJBEGIDNCHF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HGDANEHJCNG();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IBFKIKNLBBN();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void ELMMPHJGOLI(string MDNKALPBOMB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DGKJHCAGFJA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LABIABOCKPC
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task AEIMCIPOPOL(HMDEECGHJFL OILCDMBGDJJ, [Optional] CancellationToken NNGMAHIDECE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HHICONCOLBI : MBECPIFEOOD
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum HLFBKOIFHOB
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void LDNLHLAPEML(string OILCDMBGDJJ);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int FIJJOCCEMLM();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static HHICONCOLBI GCEDGJIKNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly BBFOFLHBLBK OFOOEMCHLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly DKNIJDNBEKH BBCFICOCGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool JEGEKNDMMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool FGCKAHFGGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool EAPFEADGNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool ACLFLPFNHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? EKIDGKJGPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool DCAPGOHNOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? AEONMPGCBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool HBGKELAKHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? LBNHANIBJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private GPLIOPEIBCN HDIHIOFACMF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool MNMMJLBHGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? LPMBHFNNKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F0E0", Offset = "0x6A0D6E0", VA = "0x186A0F0E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? MBLNFPLJHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A0DE90", Offset = "0x6A0C490", VA = "0x186A0DE90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? GMKKOCNGJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A0E9D0", Offset = "0x6A0CFD0", VA = "0x186A0E9D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? GOPENAGMHMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A0DF80", Offset = "0x6A0C580", VA = "0x186A0DF80", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public HMDEECGHJFL FOLMBNNKBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x861F20", Offset = "0x860520", VA = "0x180861F20", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x861E10", Offset = "0x860410", VA = "0x180861E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> EKKHMFEGGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A0E090", Offset = "0x6A0C690", VA = "0x186A0E090", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6A0E140", Offset = "0x6A0C740", VA = "0x186A0E140", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A0EBF0", Offset = "0x6A0D1F0", VA = "0x186A0EBF0")]
	private void LGCKKLBDBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F1D0", Offset = "0x6A0D7D0", VA = "0x186A0F1D0")]
	[Preserve]
	public HHICONCOLBI([JLPFJOFFNLM(null)] BBFOFLHBLBK OFOOEMCHLFC, [JLPFJOFFNLM(null)] DKNIJDNBEKH BBCFICOCGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E6D0", Offset = "0x6A0CCD0", VA = "0x186A0E6D0", Slot = "13")]
	public void HGDANEHJCNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E240", Offset = "0x6A0C840", VA = "0x186A0E240", Slot = "16")]
	public void DGKJHCAGFJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0EE40", Offset = "0x6A0D440", VA = "0x186A0EE40", Slot = "17")]
	public void NHAAABBHBOB(string HHKGHCFMDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E780", Offset = "0x6A0CD80", VA = "0x186A0E780", Slot = "14")]
	public void IBFKIKNLBBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E250", Offset = "0x6A0C850", VA = "0x186A0E250", Slot = "18")]
	public void EGBLLOHJKLB([Optional] string BAJAIDKCKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E2F0", Offset = "0x6A0C8F0", VA = "0x186A0E2F0", Slot = "15")]
	public void ELMMPHJGOLI(string MDNKALPBOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A0EB20", Offset = "0x6A0D120", VA = "0x186A0EB20", Slot = "12")]
	public void KMEBKHCKMCF(GPLIOPEIBCN HJBEGIDNCHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E3B0", Offset = "0x6A0C9B0", VA = "0x186A0E3B0")]
	private void FKPAOCLBABJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A0EAD0", Offset = "0x6A0D0D0", VA = "0x186A0EAD0")]
	[MonoPInvokeCallback(typeof(LDNLHLAPEML))]
	private static void KJMLKLPEBGE(string HHKGHCFMDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E1F0", Offset = "0x6A0C7F0", VA = "0x186A0E1F0")]
	[MonoPInvokeCallback(typeof(FIJJOCCEMLM))]
	private static int DAPKNKPODNB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E790", Offset = "0x6A0CD90", VA = "0x186A0E790")]
	private void IMKHOEJACCG(string NELHMCMMKNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A0EC70", Offset = "0x6A0D270", VA = "0x186A0EC70")]
	private void LJFKEAMOJFC(LDNLHLAPEML MAPPKFKPMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A0EDB0", Offset = "0x6A0D3B0", VA = "0x186A0EDB0")]
	private void MFMPEFGPOBL(FIJJOCCEMLM MAPPKFKPMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E6F0", Offset = "0x6A0CCF0", VA = "0x186A0E6F0")]
	private void IBFKIKNLBBN(HLFBKOIFHOB HBKEEHODHEK, string NPIOANDONOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E260", Offset = "0x6A0C860", VA = "0x186A0E260")]
	private void EGEABGFMBFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E300", Offset = "0x6A0C900", VA = "0x186A0E300")]
	private long? FEFKGLEDFHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E800", Offset = "0x6A0CE00", VA = "0x186A0E800")]
	private long? INNLPGGMOLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DDE0", Offset = "0x6A0C3E0", VA = "0x186A0DDE0")]
	private Guid? ADIIMAAJONB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0ED00", Offset = "0x6A0D300", VA = "0x186A0ED00")]
	private double? LOLBKKPKICJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F020", Offset = "0x6A0D620", VA = "0x186A0F020")]
	internal static void ODEGJPEKOGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E8B0", Offset = "0x6A0CEB0", VA = "0x186A0E8B0")]
	private void JIPACOHODOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class LMEANANJANN
{
	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F270", Offset = "0x6A0D870", VA = "0x186A0F270")]
	[CCEDJDOPMOE(CFIDNIINJOK.None)]
	private static void HMNFMEGJEJO(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F020", Offset = "0x6A0D620", VA = "0x186A0F020")]
	[MMFLCHFLHAE(DIEKPBJOOBM.Unity_BeforeSceneLoad)]
	private static void MKFFAAEACEA()
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
