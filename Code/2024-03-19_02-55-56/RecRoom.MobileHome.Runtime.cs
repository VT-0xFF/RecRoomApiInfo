using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum NPEJOKGNHCK
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
public interface LALKPKHMHLK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JNMFKDNHPFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? HOPIJCOAEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? NCEGKIAOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? JLOGIELKHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? LILECMEEHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HFGCOGGLEND(NPEJOKGNHCK NLJIDPFGNFP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DPGLELIALOP();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OHJJNCBLNOL();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KCNIAEEHMMN(string KGDODHFFJDA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LFHGOCPMJPL();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NFEFMPHBANN
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ECPGEFLNNJC(HJGMGNLOHLF LPJLHICHIAJ, [Optional] CancellationToken JMJKFNJJBHM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KPDABLBKNJE : LALKPKHMHLK
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum INFAODJHPDI
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void NKHFMKHIBMK(string LPJLHICHIAJ);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int NAGBGONOGNC();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static KPDABLBKNJE LMOHAHGFEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly ICNGNPAFHKP ODGLLGOIPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool PCJEKEPMCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool KNKNMCJBEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool EMGDAHEBMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool JNIIJGBDMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private long? BPMADONIPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool BCIPIIHJHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private long? CLPBLINBIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool CACJKAFCHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private Guid? FJKDJCLDCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private NPEJOKGNHCK DKGEPIBLFPB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool JNMFKDNHPFL
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? HOPIJCOAEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x61E64D0", Offset = "0x61E54D0", VA = "0x1861E64D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? NCEGKIAOPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61E6EF0", Offset = "0x61E5EF0", VA = "0x1861E6EF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? JLOGIELKHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61E7600", Offset = "0x61E6600", VA = "0x1861E7600", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? LILECMEEHPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x61E65C0", Offset = "0x61E55C0", VA = "0x1861E65C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public HJGMGNLOHLF IDKJPKLDCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C1290", Offset = "0x7C0290", VA = "0x1807C1290", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C1220", Offset = "0x7C0220", VA = "0x1807C1220")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61E7700", Offset = "0x61E6700", VA = "0x1861E7700")]
	[Preserve]
	public KPDABLBKNJE([CJCLEPGLAOP(null)] ICNGNPAFHKP ODGLLGOIPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61E69B0", Offset = "0x61E59B0", VA = "0x1861E69B0", Slot = "10")]
	public void DPGLELIALOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61E70A0", Offset = "0x61E60A0", VA = "0x1861E70A0", Slot = "13")]
	public void LFHGOCPMJPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x61E6AF0", Offset = "0x61E5AF0", VA = "0x1861E6AF0", Slot = "15")]
	public void EGKFNFNKEOG(string DPOCAHDAFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61E7460", Offset = "0x61E6460", VA = "0x1861E7460", Slot = "11")]
	public void OHJJNCBLNOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61E6E30", Offset = "0x61E5E30", VA = "0x1861E6E30", Slot = "16")]
	public void IPKEDEKMBDF([Optional] string PHLFKPBBKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61E7090", Offset = "0x61E6090", VA = "0x1861E7090", Slot = "12")]
	public void KCNIAEEHMMN(string KGDODHFFJDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61E6D60", Offset = "0x61E5D60", VA = "0x1861E6D60", Slot = "9")]
	public void HFGCOGGLEND(NPEJOKGNHCK NLJIDPFGNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61E7140", Offset = "0x61E6140", VA = "0x1861E7140")]
	private void OCLADEPJNLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61E66D0", Offset = "0x61E56D0", VA = "0x1861E66D0")]
	[MonoPInvokeCallback(typeof(NKHFMKHIBMK))]
	private static void BFCBGODBKIP(string DPOCAHDAFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61E75B0", Offset = "0x61E65B0", VA = "0x1861E75B0")]
	[MonoPInvokeCallback(typeof(NAGBGONOGNC))]
	private static int PGHFPCBCDDL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61E6C60", Offset = "0x61E5C60", VA = "0x1861E6C60")]
	private void FGNLGKMNEJN(string DNPEKIFELFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61E6CD0", Offset = "0x61E5CD0", VA = "0x1861E6CD0")]
	private void GJMADAGPKAJ(NKHFMKHIBMK ADABDJONAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61E70B0", Offset = "0x61E60B0", VA = "0x1861E70B0")]
	private void MDIEPECOMDJ(NAGBGONOGNC ADABDJONAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61E7470", Offset = "0x61E6470", VA = "0x1861E7470")]
	private void OHJJNCBLNOL(INFAODJHPDI CPHMIDDIJGK, string EOKKOPOPCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61E6920", Offset = "0x61E5920", VA = "0x1861E6920")]
	private void DDDNJLELCAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61E6FE0", Offset = "0x61E5FE0", VA = "0x1861E6FE0")]
	private long? JKFCFIJDHJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61E6870", Offset = "0x61E5870", VA = "0x1861E6870")]
	private long? CMBCPDHLCKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61E6E40", Offset = "0x61E5E40", VA = "0x1861E6E40")]
	private Guid? JEKDDLJAHDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61E7500", Offset = "0x61E6500", VA = "0x1861E7500")]
	private double? OPKPCHLLFNJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61E6310", Offset = "0x61E5310", VA = "0x1861E6310")]
	internal static void KFKFNKLFBCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61E69D0", Offset = "0x61E59D0", VA = "0x1861E69D0")]
	private void EDCAKLDPBDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class FOBKPIHJFEH
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x61E63D0", Offset = "0x61E53D0", VA = "0x1861E63D0")]
	[KEBGMDILACL(JMIJNHPDBML.None)]
	private static void LMNGPPGMDIK(ONGJLMJLNJA CNBEIAALEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61E6310", Offset = "0x61E5310", VA = "0x1861E6310")]
	[HMAONFLKHFC(PNOGLCABCMB.Unity_BeforeSceneLoad)]
	private static void AANMGJCFION()
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
