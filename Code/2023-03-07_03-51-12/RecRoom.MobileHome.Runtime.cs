using System;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LPNOCMPPGIA
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
public interface HCNBIFDELLA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NEMCMIJABNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFBOBAOHMAN(LPNOCMPPGIA LGKAKPIGKKN);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NPFGFFCDMGH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KBBOJOHMEAG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AHBMGABIMNG(string HJGEIKHKJMN);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CGPHIDFAHIB([Optional] string CGKLLGOGFMN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EABMBJAOHKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ENGGBENJBPA(CEDPHPHFBIF FFNAPLFEDFC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IGNGKOCAEAL : HCNBIFDELLA, NCDAFMOCPLK
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum HPJHDFCOAJC
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void DIOKFEBEHPC(string FFNAPLFEDFC);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int DPDCKLLLLDO();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static IGNGKOCAEAL GLONDIMDLCD;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static bool DPDNDIINMEP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static bool CJOJAOEENLM;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static bool BCCHFIFOCHB;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static long? GEOFEAMJLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly MDDMOHNNJIM HOBHOLIHJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private LPNOCMPPGIA HMNHJFHLLKJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long CCGNCMFJGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64F6920", Offset = "0x64F5D20", VA = "0x1864F6920", Slot = "10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NEMCMIJABNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64F6E00", Offset = "0x64F6200", VA = "0x1864F6E00")]
	[Preserve]
	public IGNGKOCAEAL([ANGFGGDOPHE(null)] MDDMOHNNJIM HOBHOLIHJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64F6AC0", Offset = "0x64F5EC0", VA = "0x1864F6AC0", Slot = "6")]
	public void NPFGFFCDMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x64F62F0", Offset = "0x64F56F0", VA = "0x1864F62F0", Slot = "7")]
	public void KBBOJOHMEAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64F62F0", Offset = "0x64F56F0", VA = "0x1864F62F0", Slot = "9")]
	public void CGPHIDFAHIB([Optional] string CGKLLGOGFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x64F62F0", Offset = "0x64F56F0", VA = "0x1864F62F0", Slot = "8")]
	public void AHBMGABIMNG(string HJGEIKHKJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x64F6490", Offset = "0x64F5890", VA = "0x1864F6490", Slot = "5")]
	public void DFBOBAOHMAN(LPNOCMPPGIA LGKAKPIGKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64F6540", Offset = "0x64F5940", VA = "0x1864F6540")]
	private void DHFFHDLIBNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x64F6650", Offset = "0x64F5A50", VA = "0x1864F6650")]
	private void EAOGEIDPALG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64F6750", Offset = "0x64F5B50", VA = "0x1864F6750")]
	[MonoPInvokeCallback(typeof(DIOKFEBEHPC))]
	private static void FJKBFAEAKCI(string ABLLDBAGOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64F69F0", Offset = "0x64F5DF0", VA = "0x1864F69F0")]
	[MonoPInvokeCallback(typeof(DPDCKLLLLDO))]
	private static int LHDEOOBFBPG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64F6390", Offset = "0x64F5790", VA = "0x1864F6390")]
	private void BMPCEJJFEIE(string JJKNPHFFGJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x64F6410", Offset = "0x64F5810", VA = "0x1864F6410")]
	private void CLHAFNHCKMJ(DIOKFEBEHPC KCKLDKHBENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64F6450", Offset = "0x64F5850", VA = "0x1864F6450")]
	private void DDPAHAHLPPB(DPDCKLLLLDO KCKLDKHBENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64F62F0", Offset = "0x64F56F0", VA = "0x1864F62F0")]
	private void KBBOJOHMEAG(HPJHDFCOAJC DFCEDJEBLNA, string GFMFFEBIJHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64F6870", Offset = "0x64F5C70", VA = "0x1864F6870")]
	private void FLIAMEAJAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x64F6A60", Offset = "0x64F5E60", VA = "0x1864F6A60")]
	private long? LOFPDKFOAJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64F6330", Offset = "0x64F5730", VA = "0x1864F6330")]
	private long? AOJFHKIKJLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64F6260", Offset = "0x64F5660", VA = "0x1864F6260")]
	internal static void AFGIFNFAAFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x64F68B0", Offset = "0x64F5CB0", VA = "0x1864F68B0")]
	private static void IAIIFCJCKGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JLCEOEDOOJG
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x64F6F60", Offset = "0x64F6360", VA = "0x1864F6F60")]
	[KPHLIICFIPJ(OEKFJILJDLM.None)]
	private static void DIICKCLOPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x64F6E90", Offset = "0x64F6290", VA = "0x1864F6E90")]
	[IHGFJIOHIHA(AIACHMLABFB.Unity_BeforeSceneLoad)]
	private static void AGOGLIOBBJK()
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
