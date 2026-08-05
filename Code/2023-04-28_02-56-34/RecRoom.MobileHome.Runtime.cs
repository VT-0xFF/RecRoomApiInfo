using System;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NDCOJJCAGOG
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
public interface NCCFKDOPOFE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BNJDNEOAIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? MHGOOGAAFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? DNPIHMHAJFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JAOBBBKPBGH(NDCOJJCAGOG OJNFGJAPBNC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KADCCJJCHBP();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CKBIMPOKHGC();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IAMNPPDCNDJ(string FLODAHKHAOP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CPNFEDLLCBA([Optional] string GNCMLGLHCOM);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EEEKDACKHFI
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONHBAHNPNJB(LNGPPGPCAKA PECGMHKGBON);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MPFBOGGKGBK : NCCFKDOPOFE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum BEPGGHKBEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void GDHJFABHNNJ(string PECGMHKGBON);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int LEDJMIAGPAF();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static MPFBOGGKGBK MLLKBCFLFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool AKOHNGGJNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool KMBGICGNPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool KHDFFIBKOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private long? MIDKDBHIBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? HFEHDJPNPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NDCOJJCAGOG BCOKEPMECAA;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BNJDNEOAIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72A820", Offset = "0x729220", VA = "0x18072A820", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long? MHGOOGAAFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A17C50", Offset = "0x6A16650", VA = "0x186A17C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long? DNPIHMHAJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A17DD0", Offset = "0x6A167D0", VA = "0x186A17DD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A17E50", Offset = "0x6A16850", VA = "0x186A17E50")]
	[Preserve]
	public MPFBOGGKGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6A17C90", Offset = "0x6A16690", VA = "0x186A17C90", Slot = "8")]
	public void KADCCJJCHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A177E0", Offset = "0x6A161E0", VA = "0x186A177E0", Slot = "9")]
	public void CKBIMPOKHGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A177E0", Offset = "0x6A161E0", VA = "0x186A177E0", Slot = "11")]
	public void CPNFEDLLCBA([Optional] string GNCMLGLHCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A177E0", Offset = "0x6A161E0", VA = "0x186A177E0", Slot = "10")]
	public void IAMNPPDCNDJ(string FLODAHKHAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A17AF0", Offset = "0x6A164F0", VA = "0x186A17AF0", Slot = "7")]
	public void JAOBBBKPBGH(NDCOJJCAGOG OJNFGJAPBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A17B40", Offset = "0x6A16540", VA = "0x186A17B40")]
	private void JGLMOCFHIMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A17900", Offset = "0x6A16300", VA = "0x186A17900")]
	private void DPJBKJAHIBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6A17990", Offset = "0x6A16390", VA = "0x186A17990")]
	[MonoPInvokeCallback(typeof(GDHJFABHNNJ))]
	private static void GCOLGBOGPPO(string HPACEGGAIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6A17730", Offset = "0x6A16130", VA = "0x186A17730")]
	[MonoPInvokeCallback(typeof(LEDJMIAGPAF))]
	private static int BFPJCKMPAKM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6A17820", Offset = "0x6A16220", VA = "0x186A17820")]
	private void DKAJHLIKBDA(string ANEFBKHHPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6A17AB0", Offset = "0x6A164B0", VA = "0x186A17AB0")]
	private void IDNAIFCMOHN(GDHJFABHNNJ MIKGEIBIMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6A17E10", Offset = "0x6A16810", VA = "0x186A17E10")]
	private void KDJKMOMKLGF(LEDJMIAGPAF MIKGEIBIMCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6A177E0", Offset = "0x6A161E0", VA = "0x186A177E0")]
	private void CKBIMPOKHGC(BEPGGHKBEAJ JALEHBMHNHI, string PGHFFGMDEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6A176F0", Offset = "0x6A160F0", VA = "0x186A176F0")]
	private void ANHPIMEBPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A178A0", Offset = "0x6A162A0", VA = "0x186A178A0")]
	private long? DOJBNCFLFBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A17780", Offset = "0x6A16180", VA = "0x186A17780")]
	private long? CFGGPLJIJLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A17630", Offset = "0x6A16030", VA = "0x186A17630")]
	internal static void KGLGIFBGKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A17980", Offset = "0x6A16380", VA = "0x186A17980")]
	private void FOBPFMCPMHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CHALLKEGFJN
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6A17540", Offset = "0x6A15F40", VA = "0x186A17540")]
	[JDDIJBKLPJE(GHILFLKBMBN.None)]
	private static void BLJDAMCOIOA(AOONKACGDKK ONILLNPEPMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6A17630", Offset = "0x6A16030", VA = "0x186A17630")]
	[DKOCLKLDKBJ(BAHKGFILFFP.Unity_BeforeSceneLoad)]
	private static void LCMPLGNHGDK()
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
