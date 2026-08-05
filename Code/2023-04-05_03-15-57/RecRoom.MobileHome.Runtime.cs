using System;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AOKBKOFLMIE
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
public interface OOHJPJHOKFA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HDMJCEBCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CNMABKIAHBE(AOKBKOFLMIE KFCHBPFAEMJ);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHHOMPLGCBC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GDKLADPEBMC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECLIHLKAAJP(string LCJFDKGDDEB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBLBLHJHINF([Optional] string IGPLKKHHMMG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OJNAANGAEKH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMAFLMDEAMC(AAKDJOKOLDG CDBODNACJHL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BJHJMNCIPMJ : OOHJPJHOKFA, ICMLHACBHDC
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum BMBCNNNKAOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void FMBECFGLKHN(string CDBODNACJHL);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int KGMKMPGMBIK();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static BJHJMNCIPMJ NMHCDAEEFOA;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static bool LGCFNIJLIKH;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static bool PJPDOBNJCFG;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static bool LJMDKKKPGIF;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static long? DIBEBNBJFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly FKDAHMCHFPK PNIBBHPIMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private AOKBKOFLMIE ACHNGJPOJOI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private long NBDLCNBHLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66A7590", Offset = "0x66A6590", VA = "0x1866A7590", Slot = "10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HDMJCEBCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x66A7D80", Offset = "0x66A6D80", VA = "0x1866A7D80")]
	[Preserve]
	public BJHJMNCIPMJ([KCHLPHCLLFB(null)] FKDAHMCHFPK PNIBBHPIMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66A7660", Offset = "0x66A6660", VA = "0x1866A7660", Slot = "6")]
	public void JHHOMPLGCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66A7390", Offset = "0x66A6390", VA = "0x1866A7390", Slot = "7")]
	public void GDKLADPEBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x66A7390", Offset = "0x66A6390", VA = "0x1866A7390", Slot = "9")]
	public void GBLBLHJHINF([Optional] string IGPLKKHHMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x66A7390", Offset = "0x66A6390", VA = "0x1866A7390", Slot = "8")]
	public void ECLIHLKAAJP(string LCJFDKGDDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x66A71E0", Offset = "0x66A61E0", VA = "0x1866A71E0", Slot = "5")]
	public void CNMABKIAHBE(AOKBKOFLMIE KFCHBPFAEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x66A7A60", Offset = "0x66A6A60", VA = "0x1866A7A60")]
	private void LIIOJCBHOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x66A7C20", Offset = "0x66A6C20", VA = "0x1866A7C20")]
	private void PPMNIPOHJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x66A7940", Offset = "0x66A6940", VA = "0x1866A7940")]
	[MonoPInvokeCallback(typeof(FMBECFGLKHN))]
	private static void KGDNKEGAKJL(string NBCEGPACLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x66A7BB0", Offset = "0x66A6BB0", VA = "0x1866A7BB0")]
	[MonoPInvokeCallback(typeof(KGMKMPGMBIK))]
	private static int NIIELPCKOIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x66A7510", Offset = "0x66A6510", VA = "0x1866A7510")]
	private void HHCHOJDCMBE(string CKOFLINMDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x66A74D0", Offset = "0x66A64D0", VA = "0x1866A74D0")]
	private void GGBIEOPNOJO(FMBECFGLKHN PEPHBHFBJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x66A7B70", Offset = "0x66A6B70", VA = "0x1866A7B70")]
	private void NHANCEPCIIK(KGMKMPGMBIK PEPHBHFBJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x66A7390", Offset = "0x66A6390", VA = "0x1866A7390")]
	private void GDKLADPEBMC(BMBCNNNKAOM PMFINIOLCAO, string LCNDCHDLCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x66A73D0", Offset = "0x66A63D0", VA = "0x1866A73D0")]
	private void FHDOGNKCFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x66A7410", Offset = "0x66A6410", VA = "0x1866A7410")]
	private long? FIIJLCEICKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x66A7470", Offset = "0x66A6470", VA = "0x1866A7470")]
	private long? FOECHGPLLAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x66A7300", Offset = "0x66A6300", VA = "0x1866A7300")]
	internal static void EBIACLCMBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x66A7290", Offset = "0x66A6290", VA = "0x1866A7290")]
	private static void DECDIFEAHFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CAKNKPGKNMH
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x66A7EE0", Offset = "0x66A6EE0", VA = "0x1866A7EE0")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	private static void GDFJHBNIOGM(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x66A7E10", Offset = "0x66A6E10", VA = "0x1866A7E10")]
	[DBEMBPHJILD(JAIANHPNEMN.Unity_BeforeSceneLoad)]
	private static void EPFIFBLMKPL()
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
