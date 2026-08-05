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
public enum HNALGEHCGCC
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
public interface IHGMNIILLDE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KELCMGADGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? EGJCMNNPCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? ANBEOBDMIPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? DMMHCHJIDLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PBLEOBKJILJ(HNALGEHCGCC KAFJGNMGLLD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MJKJMKCCJMD();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOKDFIBLNDP();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OMCPAFEKDDA(string BDJPOBPOGJA);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KJLDKPMJHAD
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NIMJLLPLIGP(ENODCDOEDFP AFDDGCCICGK, [Optional] CancellationToken NCEIDHNHODH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NANJECPDMPI : IHGMNIILLDE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum NKLALCOJGAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void BBAEBKDOMHC(string AFDDGCCICGK);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int DLJNEEGBHOO();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static NANJECPDMPI AOCDGMDEJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool LEGJIJKDDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool FLINFKOPCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool CIPDJMICEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private long? MCCJHHAOBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? CPAKAEBHKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private Guid? AALEGAIMFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly HKFOCLLIPFB DOFHJFLGELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private HNALGEHCGCC ODEABEFHEOL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KELCMGADGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2F0", Offset = "0x7A9AF0", VA = "0x1807AB2F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long? EGJCMNNPCND
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2B60", Offset = "0x5CE1360", VA = "0x185CE2B60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? ANBEOBDMIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2CA0", Offset = "0x5CE14A0", VA = "0x185CE2CA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Guid? DMMHCHJIDLO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CE2BA0", Offset = "0x5CE13A0", VA = "0x185CE2BA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3AA0", Offset = "0x5CE22A0", VA = "0x185CE3AA0")]
	[Preserve]
	public NANJECPDMPI([AKMGDNDIMPI(null)] HKFOCLLIPFB DOFHJFLGELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3470", Offset = "0x5CE1C70", VA = "0x185CE3470", Slot = "9")]
	public void MJKJMKCCJMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2F70", Offset = "0x5CE1770", VA = "0x185CE2F70", Slot = "10")]
	public void GOKDFIBLNDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3460", Offset = "0x5CE1C60", VA = "0x185CE3460", Slot = "12")]
	public void MGEAMBDOFAC([Optional] string NACMCBDIHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3960", Offset = "0x5CE2160", VA = "0x185CE3960", Slot = "11")]
	public void OMCPAFEKDDA(string BDJPOBPOGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3970", Offset = "0x5CE2170", VA = "0x185CE3970", Slot = "8")]
	public void PBLEOBKJILJ(HNALGEHCGCC KAFJGNMGLLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CE35B0", Offset = "0x5CE1DB0", VA = "0x185CE35B0")]
	private void NFKIPDOIELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3010", Offset = "0x5CE1810", VA = "0x185CE3010")]
	private void IALIMKMGIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2CE0", Offset = "0x5CE14E0", VA = "0x185CE2CE0")]
	[MonoPInvokeCallback(typeof(BBAEBKDOMHC))]
	private static void FCJEGDJJNLD(string LGNJODOOFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2A00", Offset = "0x5CE1200", VA = "0x185CE2A00")]
	[MonoPInvokeCallback(typeof(DLJNEEGBHOO))]
	private static int AHEJBNCAHAL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3A30", Offset = "0x5CE2230", VA = "0x185CE3A30")]
	private void PNKDDMOAGLF(string KCJJFCAEEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CE38D0", Offset = "0x5CE20D0", VA = "0x185CE38D0")]
	private void NOPLOLEHDML(BBAEBKDOMHC ELLFKJCIDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2F80", Offset = "0x5CE1780", VA = "0x185CE2F80")]
	private void HPAPADEGFFM(DLJNEEGBHOO ELLFKJCIDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2EE0", Offset = "0x5CE16E0", VA = "0x185CE2EE0")]
	private void GOKDFIBLNDP(NKLALCOJGAD PHFMGFNHLEP, string NMPELAADIGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CE33D0", Offset = "0x5CE1BD0", VA = "0x185CE33D0")]
	private void LMMNNCCOKAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2E30", Offset = "0x5CE1630", VA = "0x185CE2E30")]
	private long? FEDKFPPNCME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CE31D0", Offset = "0x5CE19D0", VA = "0x185CE31D0")]
	private long? IDEFIHOBMEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2BF0", Offset = "0x5CE13F0", VA = "0x185CE2BF0")]
	private Guid? EFBCMEPMAHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2940", Offset = "0x5CE1140", VA = "0x185CE2940")]
	internal static void IEICJMPEELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2A50", Offset = "0x5CE1250", VA = "0x185CE2A50")]
	private void AJNMLJFAIAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CE3280", Offset = "0x5CE1A80", VA = "0x185CE3280")]
	[CompilerGenerated]
	private void LGONGJHEAPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class DJMONFOAHIN
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2840", Offset = "0x5CE1040", VA = "0x185CE2840")]
	[OPPPCFMOGOO(OIAOEFLOJIJ.None)]
	private static void PKPLBOMGNEC(MPCHBJGCNBP DJDFFLPPHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5CE2940", Offset = "0x5CE1140", VA = "0x185CE2940")]
	[OBMNFKLINDG(KBJMBFFAEHK.Unity_BeforeSceneLoad)]
	private static void POMALLFPADK()
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
