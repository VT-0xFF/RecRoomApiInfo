using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum OIMALKEBHNM
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
public interface GNIDEPLKLMG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CNGPEJLDNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? FPINOAGJGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? KAGEPHNPJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? GNBGGLFCPBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FFELADEKJHN(OIMALKEBHNM EPLFCMFNFIK);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OOCIGOIJKNJ();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MIEBNBAPANE();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JBNJHFAOCDA(string ABCGLPGDFPB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PNELHNFPEOA
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ONMILLOKPDA(MKNKBCAADPK FBKNHKPIFMG, [Optional] CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IKJHHPMFLLP : GNIDEPLKLMG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum AJKFMPGFKCG
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void OCPOJJMIGBD(string FBKNHKPIFMG);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int AIIEIPEAAOC();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static IKJHHPMFLLP JGOGHBIKMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool EPLBOEAGIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool COJBLOIGHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool FGMFONIGLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private long? PHGENKNMMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? PBLIDJENDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private Guid? DCGBCPPEIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly MKKKCKMGIGJ HHNMKAKKFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private OIMALKEBHNM GNIGEEJBIBI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CNGPEJLDNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long? FPINOAGJGEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A970", Offset = "0x5D19770", VA = "0x185D1A970", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? KAGEPHNPJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B540", Offset = "0x5D1A340", VA = "0x185D1B540", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Guid? GNBGGLFCPBE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B9C0", Offset = "0x5D1A7C0", VA = "0x185D1B9C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BA10", Offset = "0x5D1A810", VA = "0x185D1BA10")]
	[Preserve]
	public IKJHHPMFLLP([NMBHAKGIBHG(null)] MKKKCKMGIGJ HHNMKAKKFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B7F0", Offset = "0x5D1A5F0", VA = "0x185D1B7F0", Slot = "9")]
	public void OOCIGOIJKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B750", Offset = "0x5D1A550", VA = "0x185D1B750", Slot = "10")]
	public void MIEBNBAPANE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AD60", Offset = "0x5D19B60", VA = "0x185D1AD60", Slot = "12")]
	public void EJPOICGNDPI([Optional] string HNLBCHOABOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B030", Offset = "0x5D19E30", VA = "0x185D1B030", Slot = "11")]
	public void JBNJHFAOCDA(string ABCGLPGDFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AE20", Offset = "0x5D19C20", VA = "0x185D1AE20", Slot = "8")]
	public void FFELADEKJHN(OIMALKEBHNM EPLFCMFNFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B220", Offset = "0x5D1A020", VA = "0x185D1B220")]
	private void LJNMGIEIOLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ABA0", Offset = "0x5D199A0", VA = "0x185D1ABA0")]
	private void DLBFAMNBKOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B0D0", Offset = "0x5D19ED0", VA = "0x185D1B0D0")]
	[MonoPInvokeCallback(typeof(OCPOJJMIGBD))]
	private static void KFPLAJONJOC(string CBPAGMOHFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B700", Offset = "0x5D1A500", VA = "0x185D1B700")]
	[MonoPInvokeCallback(typeof(AIIEIPEAAOC))]
	private static int MGMCKHAJALA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B690", Offset = "0x5D1A490", VA = "0x185D1B690")]
	private void MGJGLKLEEDF(string LAPHEIIELLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B930", Offset = "0x5D1A730", VA = "0x185D1B930")]
	private void PCPMJCJHJHL(OCPOJJMIGBD MEKLMIFMFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A9B0", Offset = "0x5D197B0", VA = "0x185D1A9B0")]
	private void AHHCDJFOLKN(AIIEIPEAAOC MEKLMIFMFCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B760", Offset = "0x5D1A560", VA = "0x185D1B760")]
	private void MIEBNBAPANE(AJKFMPGFKCG GHFGMAKMGKH, string GGOCDDJHHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B040", Offset = "0x5D19E40", VA = "0x185D1B040")]
	private void JMLKIKHKCGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AD70", Offset = "0x5D19B70", VA = "0x185D1AD70")]
	private long? ELGOMCDIIJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AA40", Offset = "0x5D19840", VA = "0x185D1AA40")]
	private long? BGBAPIMHJFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AAF0", Offset = "0x5D198F0", VA = "0x185D1AAF0")]
	private Guid? DCHMCALIFIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A7B0", Offset = "0x5D195B0", VA = "0x185D1A7B0")]
	internal static void BKADOFDLLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B580", Offset = "0x5D1A380", VA = "0x185D1B580")]
	private void MEPFGBOKGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AEE0", Offset = "0x5D19CE0", VA = "0x185D1AEE0")]
	[CompilerGenerated]
	private void HPPBCMGMPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AFGIODMDPPH
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A870", Offset = "0x5D19670", VA = "0x185D1A870")]
	[GAPOPKHLLNB(OGJCEJIMIKL.None)]
	private static void NANBHMOPBJJ(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A7B0", Offset = "0x5D195B0", VA = "0x185D1A7B0")]
	[CCODNAGEEMD(JPDNIMGFJLH.Unity_BeforeSceneLoad)]
	private static void MMADPBPMGGI()
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
