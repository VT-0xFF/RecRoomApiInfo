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
public enum MKDAOAOMBOG
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
public interface EFLHLJOCPLH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CAGBMGJFNAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? HDAIILKAFII
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? ONOBIHIGHGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? PKPKDJIHLGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DICDAECFJMD(MKDAOAOMBOG KIGOLAOAAMI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCKCHEHGBKI();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CBDNOKGMJKF();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ILDELPGIHON(string IELIBEMPOFK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DBBEDDBIEIP
{
	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HPCCENGCCLN(NJNJCGMAECI CNFJBLAOGLM, [Optional] CancellationToken BCCDJHNACKO);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BPODJEDLFAN : EFLHLJOCPLH
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum OGLHPEJDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void KLDNBAHEPAN(string CNFJBLAOGLM);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int BHIIKNIFPPD();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static BPODJEDLFAN BBDPDFCKIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool PGOCLMKCOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool KFMFIGLCIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool CEKGEHDEDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private long? PECEINLDFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool POCHJELLHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long? FKMCIHEFJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool DNAFOPPEDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private Guid? FIKIGAENCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly CPMLMAGGHDP GPFDNNLFEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private MKDAOAOMBOG MILBJIDOOLB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CAGBMGJFNAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long? HDAIILKAFII
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CC2910", Offset = "0x5CC1710", VA = "0x185CC2910", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? ONOBIHIGHGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3320", Offset = "0x5CC2120", VA = "0x185CC3320", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Guid? PKPKDJIHLGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC36A0", Offset = "0x5CC24A0", VA = "0x185CC36A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3AB0", Offset = "0x5CC28B0", VA = "0x185CC3AB0")]
	[Preserve]
	public BPODJEDLFAN([FGPOJKOJBFM(null)] CPMLMAGGHDP GPFDNNLFEKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3410", Offset = "0x5CC2210", VA = "0x185CC3410", Slot = "9")]
	public void HCKCHEHGBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2A00", Offset = "0x5CC1800", VA = "0x185CC2A00", Slot = "10")]
	public void CBDNOKGMJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2F80", Offset = "0x5CC1D80", VA = "0x185CC2F80", Slot = "12")]
	public void FAMBKAONDOF([Optional] string MBJEMJLPJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3830", Offset = "0x5CC2630", VA = "0x185CC3830", Slot = "11")]
	public void ILDELPGIHON(string IELIBEMPOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2C60", Offset = "0x5CC1A60", VA = "0x185CC2C60", Slot = "8")]
	public void DICDAECFJMD(MKDAOAOMBOG KIGOLAOAAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2F90", Offset = "0x5CC1D90", VA = "0x185CC2F90")]
	private void FMBBGPFDHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3960", Offset = "0x5CC2760", VA = "0x185CC3960")]
	[MonoPInvokeCallback(typeof(KLDNBAHEPAN))]
	private static void NGAOEPIHIKE(string EAJNMIHOIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2F30", Offset = "0x5CC1D30", VA = "0x185CC2F30")]
	[MonoPInvokeCallback(typeof(BHIIKNIFPPD))]
	private static int EOHBICKMMMO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CC32B0", Offset = "0x5CC20B0", VA = "0x185CC32B0")]
	private void GHCIIAAPJGG(string KMHNNDLBODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CC37A0", Offset = "0x5CC25A0", VA = "0x185CC37A0")]
	private void IKDCEAHNDAG(KLDNBAHEPAN PMOMGAGBHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3840", Offset = "0x5CC2640", VA = "0x185CC3840")]
	private void JMKMDHNFACI(BHIIKNIFPPD PMOMGAGBHKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2A10", Offset = "0x5CC1810", VA = "0x185CC2A10")]
	private void CBDNOKGMJKF(OGLHPEJDCFC BNAPAMOAFNA, string EMJMPPDNOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC38D0", Offset = "0x5CC26D0", VA = "0x185CC38D0")]
	private void MKMGJKPDAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC35F0", Offset = "0x5CC23F0", VA = "0x185CC35F0")]
	private long? IACHBEAKACK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3540", Offset = "0x5CC2340", VA = "0x185CC3540")]
	private long? HMDJLDEHCFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2AA0", Offset = "0x5CC18A0", VA = "0x185CC2AA0")]
	private Guid? CPLBPDAGJDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2E70", Offset = "0x5CC1C70", VA = "0x185CC2E70")]
	internal static void EGCHICIEEIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2B50", Offset = "0x5CC1950", VA = "0x185CC2B50")]
	private void DAGFMFIBPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2D20", Offset = "0x5CC1B20", VA = "0x185CC2D20")]
	[CompilerGenerated]
	private void DKABIOPFFOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class IMLPEKMFIGI
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3B30", Offset = "0x5CC2930", VA = "0x185CC3B30")]
	[DJDJPHIPNFL(IEJLPKKICHC.None)]
	private static void HACFLCEFAPO(NNIGDKDCOBN LAJBGPNDGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2E70", Offset = "0x5CC1C70", VA = "0x185CC2E70")]
	[NDCOICPCJMM(JMJDGGKCJFL.Unity_BeforeSceneLoad)]
	private static void JFKGNOBFHKI()
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
