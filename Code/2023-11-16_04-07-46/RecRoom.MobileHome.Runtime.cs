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
public enum MFOEPPHEAFN
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
public interface NNACPOLLIMC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EAMIEJFBMJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? PKLHGLBABAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? FKJEKEDIKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? NPJBIIBDNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? IFJEKELNBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IPKNCEMHNJH(MFOEPPHEAFN LDGNDDODOCD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EMCBFDNIFOC();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EHLAHGEPOLM();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MMDOMABHCBP(string JLEHGNOPMFG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HBBHEEPBGJF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OMDNBKLHIMB
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task NGBGKKOHFAC(JNOPIEIAFJI JJDCODADAAD, [Optional] CancellationToken JEBPNJAPHEL);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DKGMGKPBODF : NNACPOLLIMC
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum OLNJDGINFMP
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void AMGHMNBKMJH(string JJDCODADAAD);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int MCHFAHPODEN();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static DKGMGKPBODF PBJLMCDEAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool JLOKNJCPCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool ILLHMOHDAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool JGMPBBDIGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool JNJGEGPPCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? ADGALFDCDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool KDLLPCNFFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long? IKILMGEMBEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool MEHOKCMGACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Guid? JONDFHDMLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LOHIMAIEHBA DKKMNDKFKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MFOEPPHEAFN GNHIHOHKEAO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool EAMIEJFBMJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B92E0", VA = "0x1807BA2E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? PKLHGLBABAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E350D0", Offset = "0x5E340D0", VA = "0x185E350D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? FKJEKEDIKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E35790", Offset = "0x5E34790", VA = "0x185E35790", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? NPJBIIBDNAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E34BF0", Offset = "0x5E33BF0", VA = "0x185E34BF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? IFJEKELNBHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E34DA0", Offset = "0x5E33DA0", VA = "0x185E34DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E35F60", Offset = "0x5E34F60", VA = "0x185E35F60")]
	[Preserve]
	public DKGMGKPBODF([KHIPNIHHNOH(null)] LOHIMAIEHBA DKKMNDKFKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E34FA0", Offset = "0x5E33FA0", VA = "0x185E34FA0", Slot = "10")]
	public void EMCBFDNIFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x31D8CE0", Offset = "0x31D7CE0", VA = "0x1831D8CE0", Slot = "13")]
	public void HBBHEEPBGJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E34F00", Offset = "0x5E33F00", VA = "0x185E34F00", Slot = "11")]
	public void EHLAHGEPOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E35780", Offset = "0x5E34780", VA = "0x185E35780", Slot = "14")]
	public void JPGNOJJLEKJ([Optional] string IDFLGJEKCHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E35910", Offset = "0x5E34910", VA = "0x185E35910", Slot = "12")]
	public void MMDOMABHCBP(string JLEHGNOPMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E35450", Offset = "0x5E34450", VA = "0x185E35450", Slot = "9")]
	public void IPKNCEMHNJH(MFOEPPHEAFN LDGNDDODOCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E35C40", Offset = "0x5E34C40", VA = "0x185E35C40")]
	private void OMKJAEFPHEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E359D0", Offset = "0x5E349D0", VA = "0x185E359D0")]
	[MonoPInvokeCallback(typeof(AMGHMNBKMJH))]
	private static void MPPDPDJGLDC(string CPGAOHIFJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E34EB0", Offset = "0x5E33EB0", VA = "0x185E34EB0")]
	[MonoPInvokeCallback(typeof(MCHFAHPODEN))]
	private static int ECBNADLHHBL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E35B20", Offset = "0x5E34B20", VA = "0x185E35B20")]
	private void NACAILJEEJG(string EBNLOLGACFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E35880", Offset = "0x5E34880", VA = "0x185E35880")]
	private void MBPKGMCLGMC(AMGHMNBKMJH CAEGDBPOJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E356F0", Offset = "0x5E346F0", VA = "0x185E356F0")]
	private void JOKHDOGNGFE(MCHFAHPODEN CAEGDBPOJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E34F10", Offset = "0x5E33F10", VA = "0x185E34F10")]
	private void EHLAHGEPOLM(OLNJDGINFMP GEIKHBJFIME, string NBJJJNIOIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E35660", Offset = "0x5E34660", VA = "0x185E35660")]
	private void JHLFDCHECLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E351C0", Offset = "0x5E341C0", VA = "0x185E351C0")]
	private long? GJAOMIJAOFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E34CF0", Offset = "0x5E33CF0", VA = "0x185E34CF0")]
	private long? CEJMBJHPPPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E35B90", Offset = "0x5E34B90", VA = "0x185E35B90")]
	private Guid? NNJNKPGKMNM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E35920", Offset = "0x5E34920", VA = "0x185E35920")]
	private double? MPFGPJDIBBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E35270", Offset = "0x5E34270", VA = "0x185E35270")]
	internal static void GJHPCHMIGDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E35330", Offset = "0x5E34330", VA = "0x185E35330")]
	private void GKLLAEKAMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E35510", Offset = "0x5E34510", VA = "0x185E35510")]
	[CompilerGenerated]
	private void JHIOIDJDMNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NLOEKCKKDOH
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E35FE0", Offset = "0x5E34FE0", VA = "0x185E35FE0")]
	[PKDJMILODMH(OMIAJJHDDGO.None)]
	private static void AJHFPNCPAMB(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E35270", Offset = "0x5E34270", VA = "0x185E35270")]
	[GABBFJBHOKF(HMIDDPKLECI.Unity_BeforeSceneLoad)]
	private static void OFDOBKFKLAD()
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
