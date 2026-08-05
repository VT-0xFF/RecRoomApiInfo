using System;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum LCBIADAIBJB
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
public interface NPJHKLKNFMM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MMLGFFKFBDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? POMKGCKNMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? PLHJBEJGLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPIPNGLCINJ(LCBIADAIBJB GMDALJMBJKE);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGIHAENGDGO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OEBCGKJEOMG();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HBPAAJMADEJ(string HCANNJFNPIO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PDPFCNOCFGE([Optional] string EELNIBOLDDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JKNAOIFAMEC
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJFGEPMFMCD(EIAJOJBHMMM KENLJLLIJGP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HDALLABNKBL : NPJHKLKNFMM
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum FDLOKJMBPPD
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void EAHKAHMPBEJ(string KENLJLLIJGP);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int EMPDPHMPBEO();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static HDALLABNKBL DMDACHFLMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool CBPLACKGPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool PPKAPNCBIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool KIDBBCCBGKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private long? IOHDGNCHCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? CHJFPAPGGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private LCBIADAIBJB LMJHCJGBBDN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MMLGFFKFBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x745330", Offset = "0x744130", VA = "0x180745330", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long? POMKGCKNMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B30A70", Offset = "0x6B2F870", VA = "0x186B30A70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long? PLHJBEJGLPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6B308E0", Offset = "0x6B2F6E0", VA = "0x186B308E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B30FA0", Offset = "0x6B2FDA0", VA = "0x186B30FA0")]
	[Preserve]
	public HDALLABNKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6B30E00", Offset = "0x6B2FC00", VA = "0x186B30E00", Slot = "8")]
	public void PGIHAENGDGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B30920", Offset = "0x6B2F720", VA = "0x186B30920", Slot = "9")]
	public void OEBCGKJEOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B30920", Offset = "0x6B2F720", VA = "0x186B30920", Slot = "11")]
	public void PDPFCNOCFGE([Optional] string EELNIBOLDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B30920", Offset = "0x6B2F720", VA = "0x186B30920", Slot = "10")]
	public void HBPAAJMADEJ(string HCANNJFNPIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B30960", Offset = "0x6B2F760", VA = "0x186B30960", Slot = "7")]
	public void IPIPNGLCINJ(LCBIADAIBJB GMDALJMBJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6B30B30", Offset = "0x6B2F930", VA = "0x186B30B30")]
	private void LOOCABHDBBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6B309B0", Offset = "0x6B2F7B0", VA = "0x186B309B0")]
	private void JPFBFFMKJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B30CD0", Offset = "0x6B2FAD0", VA = "0x186B30CD0")]
	[MonoPInvokeCallback(typeof(EAHKAHMPBEJ))]
	private static void MLLAOBFHIKG(string EOHPAGELIPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B30C40", Offset = "0x6B2FA40", VA = "0x186B30C40")]
	[MonoPInvokeCallback(typeof(EMPDPHMPBEO))]
	private static int MADLDNHIING()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B30AB0", Offset = "0x6B2F8B0", VA = "0x186B30AB0")]
	private void LNDHMIHIJIL(string HHDCMGAIDBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B30780", Offset = "0x6B2F580", VA = "0x186B30780")]
	private void DIEIHCIAAMO(EAHKAHMPBEJ FNIOCOFMFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B30A30", Offset = "0x6B2F830", VA = "0x186B30A30")]
	private void KKHMODFHHNM(EMPDPHMPBEO FNIOCOFMFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6B30920", Offset = "0x6B2F720", VA = "0x186B30920")]
	private void OEBCGKJEOMG(FDLOKJMBPPD PDFOLHHIIFI, string GBLKDGGCOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B30C90", Offset = "0x6B2FA90", VA = "0x186B30C90")]
	private void MDGJLLGGGDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B30F40", Offset = "0x6B2FD40", VA = "0x186B30F40")]
	private long? PKABIPAGEIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B30880", Offset = "0x6B2F680", VA = "0x186B30880")]
	private long? ELENMMJMLDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6B307C0", Offset = "0x6B2F5C0", VA = "0x186B307C0")]
	internal static void DNLMDIEMFHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B30DF0", Offset = "0x6B2FBF0", VA = "0x186B30DF0")]
	private void OILINMMOCJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class HOEPNDAEIIA
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B31000", Offset = "0x6B2FE00", VA = "0x186B31000")]
	[CFDOMFEMHNO(ANAFFCEINAM.None)]
	private static void HGJFPOKIOHJ(GMLHNNIDAIC IPJNDIBMKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B307C0", Offset = "0x6B2F5C0", VA = "0x186B307C0")]
	[ALDBEIMIKEO(NGGIKFHAPNK.Unity_BeforeSceneLoad)]
	private static void EHDNHAENJIA()
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
