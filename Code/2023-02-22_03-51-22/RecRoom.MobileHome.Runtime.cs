using System;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AEKBENHOCAA
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
public interface OFKIFKBHLNK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LCADOMBEHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNGDAOHCFFA(AEKBENHOCAA BGHMFEPCABE);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNACPANAOEJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BAKFEDJFCGD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DAKMLHLMGIF(string DAAPCFBCGFE);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LNMGKHDHLCP([Optional] string KCNKKGPIPFC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KINDNAONJGB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IKEJMODMDMN(KDJPANEHMBE NOOLKINGDNC);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GHCBPMENHNM : OFKIFKBHLNK, IFMNAAKDLMN
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum MPBKAFIGPKC
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void HHHPDFAABKL(string NOOLKINGDNC);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int PIEBBJJEOHD();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static GHCBPMENHNM MPOGNODCFNK;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static bool MCCMHGFICMP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static bool OGJMPNNBHBD;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static bool PLOLBPHKPKK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static long? IJOOJOLNIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly HAJIHANPHCH HHINPIOBOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private AEKBENHOCAA DJNMIPDBHAF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long KFJPJMOGEFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64A06A0", Offset = "0x649F8A0", VA = "0x1864A06A0", Slot = "10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LCADOMBEHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6CAD00", Offset = "0x6C9F00", VA = "0x1806CAD00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64A0BE0", Offset = "0x649FDE0", VA = "0x1864A0BE0")]
	[Preserve]
	public GHCBPMENHNM([CNHALHMHHIC(null)] HAJIHANPHCH HHINPIOBOBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64A0250", Offset = "0x649F450", VA = "0x1864A0250", Slot = "6")]
	public void BNACPANAOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x64A0180", Offset = "0x649F380", VA = "0x1864A0180", Slot = "7")]
	public void BAKFEDJFCGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64A0180", Offset = "0x649F380", VA = "0x1864A0180", Slot = "9")]
	public void LNMGKHDHLCP([Optional] string KCNKKGPIPFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x64A0180", Offset = "0x649F380", VA = "0x1864A0180", Slot = "8")]
	public void DAKMLHLMGIF(string DAAPCFBCGFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x64A0530", Offset = "0x649F730", VA = "0x1864A0530", Slot = "5")]
	public void CNGDAOHCFFA(AEKBENHOCAA BGHMFEPCABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64A0960", Offset = "0x649FB60", VA = "0x1864A0960")]
	private void LBPLDKGDJOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x64A0080", Offset = "0x649F280", VA = "0x1864A0080")]
	private void APGIKCNNBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64A0840", Offset = "0x649FA40", VA = "0x1864A0840")]
	[MonoPInvokeCallback(typeof(HHHPDFAABKL))]
	private static void JFHLKGEHFAE(string BKGAPHGBLIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x64A0AD0", Offset = "0x649FCD0", VA = "0x1864A0AD0")]
	[MonoPInvokeCallback(typeof(PIEBBJJEOHD))]
	private static int MGKDMPHOIHD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x64A0620", Offset = "0x649F820", VA = "0x1864A0620")]
	private void EGCEEFNNFHJ(string GEKJHOHKDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x64A0B40", Offset = "0x649FD40", VA = "0x1864A0B40")]
	private void OLCMPOLJFLH(HHHPDFAABKL IGAMPECHIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x64A05E0", Offset = "0x649F7E0", VA = "0x1864A05E0")]
	private void DGIJEJPMHIE(PIEBBJJEOHD IGAMPECHIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x64A0180", Offset = "0x649F380", VA = "0x1864A0180")]
	private void BAKFEDJFCGD(MPBKAFIGPKC EBBINHBEDJD, string BGDPJCBNCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x64A0040", Offset = "0x649F240", VA = "0x1864A0040")]
	private void AEIDIBADFCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x64A07E0", Offset = "0x649F9E0", VA = "0x1864A07E0")]
	private long? HKJJKBAGNKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x64A0A70", Offset = "0x649FC70", VA = "0x1864A0A70")]
	private long? LIPKNNHABFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64A01C0", Offset = "0x649F3C0", VA = "0x1864A01C0")]
	internal static void BJEJHCNNHKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x64A0770", Offset = "0x649F970", VA = "0x1864A0770")]
	private static void HAOIHKBKJCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class JDLAJCPLKOI
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x64A0C70", Offset = "0x649FE70", VA = "0x1864A0C70")]
	[ELNMOMKNGKB(LBAHANGFDMJ.None)]
	private static void DKDPIHJEFHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x64A0D70", Offset = "0x649FF70", VA = "0x1864A0D70")]
	[NHJENIDEHPD(PAIIGJKJFJG.Unity_BeforeSceneLoad)]
	private static void FFCEFLEFEMA()
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
