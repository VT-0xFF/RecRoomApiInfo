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

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? BCPLABFCBHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? PCAGMCGGFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CNMABKIAHBE(AOKBKOFLMIE KFCHBPFAEMJ);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHHOMPLGCBC();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GDKLADPEBMC();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ECLIHLKAAJP(string LCJFDKGDDEB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GBLBLHJHINF([Optional] string IGPLKKHHMMG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OJNAANGAEKH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMAFLMDEAMC(AAKDJOKOLDG CDBODNACJHL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BJHJMNCIPMJ : OOHJPJHOKFA
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool LGCFNIJLIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool PJPDOBNJCFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool LJMDKKKPGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private long? DIBEBNBJFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? CJHKCKGBPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private AOKBKOFLMIE ACHNGJPOJOI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool HDMJCEBCAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long? BCPLABFCBHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6727A70", Offset = "0x6726E70", VA = "0x186727A70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long? PCAGMCGGFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6727B40", Offset = "0x6726F40", VA = "0x186727B40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6727C00", Offset = "0x6727000", VA = "0x186727C00")]
	[Preserve]
	public BJHJMNCIPMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6727700", Offset = "0x6726B00", VA = "0x186727700", Slot = "8")]
	public void JHHOMPLGCBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6727500", Offset = "0x6726900", VA = "0x186727500", Slot = "9")]
	public void GDKLADPEBMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6727500", Offset = "0x6726900", VA = "0x186727500", Slot = "11")]
	public void GBLBLHJHINF([Optional] string IGPLKKHHMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6727500", Offset = "0x6726900", VA = "0x186727500", Slot = "10")]
	public void ECLIHLKAAJP(string LCJFDKGDDEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67273E0", Offset = "0x67267E0", VA = "0x1867273E0", Slot = "7")]
	public void CNMABKIAHBE(AOKBKOFLMIE KFCHBPFAEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6727960", Offset = "0x6726D60", VA = "0x186727960")]
	private void LIIOJCBHOGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6727B80", Offset = "0x6726F80", VA = "0x186727B80")]
	private void PPMNIPOHJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6727840", Offset = "0x6726C40", VA = "0x186727840")]
	[MonoPInvokeCallback(typeof(FMBECFGLKHN))]
	private static void KGDNKEGAKJL(string NBCEGPACLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6727AF0", Offset = "0x6726EF0", VA = "0x186727AF0")]
	[MonoPInvokeCallback(typeof(KGMKMPGMBIK))]
	private static int NIIELPCKOIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6727680", Offset = "0x6726A80", VA = "0x186727680")]
	private void HHCHOJDCMBE(string CKOFLINMDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6727640", Offset = "0x6726A40", VA = "0x186727640")]
	private void GGBIEOPNOJO(FMBECFGLKHN PEPHBHFBJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6727AB0", Offset = "0x6726EB0", VA = "0x186727AB0")]
	private void NHANCEPCIIK(KGMKMPGMBIK PEPHBHFBJFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6727500", Offset = "0x6726900", VA = "0x186727500")]
	private void GDKLADPEBMC(BMBCNNNKAOM PMFINIOLCAO, string LCNDCHDLCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6727540", Offset = "0x6726940", VA = "0x186727540")]
	private void FHDOGNKCFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6727580", Offset = "0x6726980", VA = "0x186727580")]
	private long? FIIJLCEICKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x67275E0", Offset = "0x67269E0", VA = "0x1867275E0")]
	private long? FOECHGPLLAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6727440", Offset = "0x6726840", VA = "0x186727440")]
	internal static void EBIACLCMBDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6727430", Offset = "0x6726830", VA = "0x186727430")]
	private void DECDIFEAHFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CAKNKPGKNMH
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6727C60", Offset = "0x6727060", VA = "0x186727C60")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	private static void GDFJHBNIOGM(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6727440", Offset = "0x6726840", VA = "0x186727440")]
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
