using System;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum JADKCBLGACP
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
public interface BLAKCOPIAME
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GMCFJBOHPCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HOOPLNHBCGA(JADKCBLGACP MKPFHFLNAEL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGKFDHOAMGH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCHPPPHAGDA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OMKKNHJPIAA(string MBCKBGIPBKC);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFINAAECEAP([Optional] string ALOPHFDCOIC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GNLAGNDOOGI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJNCGIGKHBP(JHCBOJMIANK BJDPIJBJNLN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EMBBOICHPEN : BLAKCOPIAME, JLOLDMHNOLA
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum GJOPMAJLEIL
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void EEPJICINJGP(string BJDPIJBJNLN);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int IACIDCNIMDA();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static EMBBOICHPEN AIDJCJOCGNF;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static bool FMDJLKABKJG;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static bool DGPDDHMIMDL;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static bool GFCBGFJCFBI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static long? CKMEOHBNDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly NNDNCLOJDHF FIOHFIJDMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private JADKCBLGACP LLHNFBGIIFF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long BIMIGPAGNOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64AAB40", Offset = "0x64A9540", VA = "0x1864AAB40", Slot = "10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GMCFJBOHPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64AB110", Offset = "0x64A9B10", VA = "0x1864AB110")]
	[Preserve]
	public EMBBOICHPEN([HGGCKJALFAG(null)] NNDNCLOJDHF FIOHFIJDMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64AAC10", Offset = "0x64A9610", VA = "0x1864AAC10", Slot = "6")]
	public void JGKFDHOAMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x64AA840", Offset = "0x64A9240", VA = "0x1864AA840", Slot = "7")]
	public void FCHPPPHAGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64AA840", Offset = "0x64A9240", VA = "0x1864AA840", Slot = "9")]
	public void LFINAAECEAP([Optional] string ALOPHFDCOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x64AA840", Offset = "0x64A9240", VA = "0x1864AA840", Slot = "8")]
	public void OMKKNHJPIAA(string MBCKBGIPBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x64AAA90", Offset = "0x64A9490", VA = "0x1864AAA90", Slot = "5")]
	public void HOOPLNHBCGA(JADKCBLGACP MKPFHFLNAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64AA730", Offset = "0x64A9130", VA = "0x1864AA730")]
	private void BNJKMACAOIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x64AA880", Offset = "0x64A9280", VA = "0x1864AA880")]
	private void FPKADHOFPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64AAF50", Offset = "0x64A9950", VA = "0x1864AAF50")]
	[MonoPInvokeCallback(typeof(EEPJICINJGP))]
	private static void OEIBPGIJPFE(string DHGAJKEGJGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64AA600", Offset = "0x64A9000", VA = "0x1864AA600")]
	[MonoPInvokeCallback(typeof(IACIDCNIMDA))]
	private static int AELKKHDLDLI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64AA6B0", Offset = "0x64A90B0", VA = "0x1864AA6B0")]
	private void BKJCEENDCFE(string PACNJAFDDGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x64AA9E0", Offset = "0x64A93E0", VA = "0x1864AA9E0")]
	private void GFHCGJAPGBD(EEPJICINJGP JOIALDGLEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64AB070", Offset = "0x64A9A70", VA = "0x1864AB070")]
	private void PANOHMIMHNK(IACIDCNIMDA JOIALDGLEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64AA840", Offset = "0x64A9240", VA = "0x1864AA840")]
	private void FCHPPPHAGDA(GJOPMAJLEIL JMBFNCMEOEA, string JGHNAKJOGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64AA670", Offset = "0x64A9070", VA = "0x1864AA670")]
	private void BELOGLMHKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x64AA980", Offset = "0x64A9380", VA = "0x1864AA980")]
	private long? GBJHHANAFJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64AAEF0", Offset = "0x64A98F0", VA = "0x1864AAEF0")]
	private long? JHJGLFPIFJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64AA570", Offset = "0x64A8F70", VA = "0x1864AA570")]
	internal static void AEINPGHMMMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x64AAA20", Offset = "0x64A9420", VA = "0x1864AAA20")]
	private static void GJJIELFBBIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NHJMFBHPKCN
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x64AB270", Offset = "0x64A9C70", VA = "0x1864AB270")]
	[CJJNALDLMHL(HFKENCJEONK.None)]
	private static void HMIMBPJEEAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x64AB1A0", Offset = "0x64A9BA0", VA = "0x1864AB1A0")]
	[GGMCOFEBBAE(BKOJJJFAHIH.Unity_BeforeSceneLoad)]
	private static void BDOHGIOIBMD()
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
