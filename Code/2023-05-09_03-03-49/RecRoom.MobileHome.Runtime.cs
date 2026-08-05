using System;
using System.Reflection;
using System.Runtime.InteropServices;
using AOT;
using Cpp2IlInjected;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NOPKJPLGFJD
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
public interface ALONGLJJPCL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MLJPKPLCHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? BFDJHLCOAAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? OBHFMNKCDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKMOGIFFHAK(NOPKJPLGFJD GFHEAAHHEHC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCBKDFJCMBF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GABCADDGEKC();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MIPLDGEGLDB(string ADOGJDNCDLM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NJPLPAEOMNK([Optional] string MMKHLNGEOLO);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GNICGDLLEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ABMIHHFANIP(MAHBAJKPECG BHNPPCKFMDF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GGDEAACNGGL : ALONGLJJPCL
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum BDFFPDCAKEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void JNODEEBMPOM(string BHNPPCKFMDF);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int FFKEHDONNLD();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static GGDEAACNGGL JCJDNADEMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool LOGIBHIDHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool NPHBEFCJIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool OFKOFDDFEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private long? IKBPLFHPPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? FDGFAPMLBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private NOPKJPLGFJD PMGHGEKGKGJ;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool MLJPKPLCHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7373D0", Offset = "0x735DD0", VA = "0x1807373D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long? BFDJHLCOAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1E713C0", Offset = "0x1E6FDC0", VA = "0x181E713C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long? OBHFMNKCDLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1E710C0", Offset = "0x1E6FAC0", VA = "0x181E710C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1E71620", Offset = "0x1E70020", VA = "0x181E71620")]
	[Preserve]
	public GGDEAACNGGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E71400", Offset = "0x1E6FE00", VA = "0x181E71400", Slot = "8")]
	public void NCBKDFJCMBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E70F30", Offset = "0x1E6F930", VA = "0x181E70F30", Slot = "9")]
	public void GABCADDGEKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E70F30", Offset = "0x1E6F930", VA = "0x181E70F30", Slot = "11")]
	public void NJPLPAEOMNK([Optional] string MMKHLNGEOLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E70F30", Offset = "0x1E6F930", VA = "0x181E70F30", Slot = "10")]
	public void MIPLDGEGLDB(string ADOGJDNCDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E71250", Offset = "0x1E6FC50", VA = "0x181E71250", Slot = "7")]
	public void KKMOGIFFHAK(NOPKJPLGFJD GFHEAAHHEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E70F70", Offset = "0x1E6F970", VA = "0x181E70F70")]
	private void HPJJCLMHPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E715A0", Offset = "0x1E6FFA0", VA = "0x181E715A0")]
	private void OJPKEGGMGAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E712A0", Offset = "0x1E6FCA0", VA = "0x181E712A0")]
	[MonoPInvokeCallback(typeof(JNODEEBMPOM))]
	private static void LBANHHGNFJP(string DLDBEAFJHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E711C0", Offset = "0x1E6FBC0", VA = "0x181E711C0")]
	[MonoPInvokeCallback(typeof(FFKEHDONNLD))]
	private static int JCAIMHFGALI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E70EA0", Offset = "0x1E6F8A0", VA = "0x181E70EA0")]
	private void EDLHEGIHLDH(string OEKCJJMGHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E71080", Offset = "0x1E6FA80", VA = "0x181E71080")]
	private void ICHLCEEFFIO(JNODEEBMPOM KFICNKMCGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1E71210", Offset = "0x1E6FC10", VA = "0x181E71210")]
	private void JKDLBMJKFOE(FFKEHDONNLD KFICNKMCGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1E70F30", Offset = "0x1E6F930", VA = "0x181E70F30")]
	private void GABCADDGEKC(BDFFPDCAKEF GFDAIBJCMIE, string EHLMAEDBMIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1E70E00", Offset = "0x1E6F800", VA = "0x181E70E00")]
	private void AGDKNJCGKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1E70E40", Offset = "0x1E6F840", VA = "0x181E70E40")]
	private long? ANLGNLCCAPP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1E71540", Offset = "0x1E6FF40", VA = "0x181E71540")]
	private long? NOFECBPGEII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1E71100", Offset = "0x1E6FB00", VA = "0x181E71100")]
	internal static void IHPDHAEAPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1E70F20", Offset = "0x1E6F920", VA = "0x181E70F20")]
	private void EKENPIJACNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PNCLOLIFIKL
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1E71680", Offset = "0x1E70080", VA = "0x181E71680")]
	[MBJLKJLIAAH(JDACKNHLALI.None)]
	private static void LJLDJLMDFPP(DPALDOJEBJE GCADPHBJBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1E71100", Offset = "0x1E6FB00", VA = "0x181E71100")]
	[ILPAJAIEFEA(BMBGADEKIAB.Unity_BeforeSceneLoad)]
	private static void PGBPDBHHGDN()
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
