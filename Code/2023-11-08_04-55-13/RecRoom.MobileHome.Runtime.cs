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
public enum CIKMJKMEICA
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
public interface DIEMNCBAGBL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KAIKFCIOAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? OFEGJNEJEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? EPPDMFNGNGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? FFANKGLCNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? BKGPGIPEMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDBKACDODIA(CIKMJKMEICA BHDPLHMNJLD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CAKCEPELMIL();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FPDNGNLBANA();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BPCJONJPOGO(string ABJEKOFLLKA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NGBGKLPONKB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JHNPAAGFANM
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DNFGMNIPCIM(OBCNCNJMMNH DGCJPMOJEPP, [Optional] CancellationToken ELPOPHCEGNN);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PBIPDAOOFPE : DIEMNCBAGBL
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private enum GKOMIKPFKBC
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private delegate void EOBBHACAKNE(string DGCJPMOJEPP);

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate int CGNJCGMFLMM();

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static PBIPDAOOFPE PCALNAMFDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private bool ADIKKGFEGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private bool FPIPHIMHDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private bool LLFEBDKPDBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private bool HFCBFDGBFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private long? LNPIPDOJLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool GDBJMFPEDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private long? MCPCNLFBJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool PCALJLBOAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Guid? PDLKDHBKODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly MNPAFMDHOOO DPKBOPPKKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private CIKMJKMEICA HCPIMINLECI;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KAIKFCIOAJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public long? OFEGJNEJEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F3B0", Offset = "0x5E2E1B0", VA = "0x185E2F3B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? EPPDMFNGNGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EC40", Offset = "0x5E2DA40", VA = "0x185E2EC40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public Guid? FFANKGLCNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EB40", Offset = "0x5E2D940", VA = "0x185E2EB40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float? BKGPGIPEMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E2E710", Offset = "0x5E2D510", VA = "0x185E2E710", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F530", Offset = "0x5E2E330", VA = "0x185E2F530")]
	[Preserve]
	public PBIPDAOOFPE([HOHGLGKGFHE(null)] MNPAFMDHOOO DPKBOPPKKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E3D0", Offset = "0x5E2D1D0", VA = "0x185E2E3D0", Slot = "10")]
	public void CAKCEPELMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x31BC730", Offset = "0x31BB530", VA = "0x1831BC730", Slot = "13")]
	public void NGBGKLPONKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E8B0", Offset = "0x5E2D6B0", VA = "0x185E2E8B0", Slot = "11")]
	public void FPDNGNLBANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F3A0", Offset = "0x5E2E1A0", VA = "0x185E2F3A0", Slot = "14")]
	public void OHJHGBCLFBG([Optional] string PNMIJOLAALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E310", Offset = "0x5E2D110", VA = "0x185E2E310", Slot = "12")]
	public void BPCJONJPOGO(string ABJEKOFLLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E500", Offset = "0x5E2D300", VA = "0x185E2E500", Slot = "9")]
	public void CDBKACDODIA(CIKMJKMEICA BHDPLHMNJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EE80", Offset = "0x5E2DC80", VA = "0x185E2EE80")]
	private void KGJCMGCOMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F1A0", Offset = "0x5E2DFA0", VA = "0x185E2F1A0")]
	[MonoPInvokeCallback(typeof(EOBBHACAKNE))]
	private static void KNBGAFCIPLG(string IHCGFEFIAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E630", Offset = "0x5E2D430", VA = "0x185E2E630")]
	[MonoPInvokeCallback(typeof(CGNJCGMFLMM))]
	private static int CJAAEOMMGMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E5C0", Offset = "0x5E2D3C0", VA = "0x185E2E5C0")]
	private void CGFIGDELOGB(string LDCGOFFDAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E280", Offset = "0x5E2D080", VA = "0x185E2E280")]
	private void BGNCLKMJENH(EOBBHACAKNE PJJEKPONKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F4A0", Offset = "0x5E2E2A0", VA = "0x185E2F4A0")]
	private void PCACMCJDNND(CGNJCGMFLMM PJJEKPONKPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E820", Offset = "0x5E2D620", VA = "0x185E2E820")]
	private void FPDNGNLBANA(GKOMIKPFKBC HGDPOIIJHAL, string BPGEIGEOHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E680", Offset = "0x5E2D480", VA = "0x185E2E680")]
	private void COHFJEHFPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E320", Offset = "0x5E2D120", VA = "0x185E2E320")]
	private long? BPNKGGEMKMD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E8C0", Offset = "0x5E2D6C0", VA = "0x185E2E8C0")]
	private long? GKIHNLKFBGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F2F0", Offset = "0x5E2E0F0", VA = "0x185E2F2F0")]
	private Guid? LGONPBEDJFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E970", Offset = "0x5E2D770", VA = "0x185E2E970")]
	private double? HDCGGMDIPEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E1C0", Offset = "0x5E2CFC0", VA = "0x185E2E1C0")]
	internal static void GNHNGFBFFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EA20", Offset = "0x5E2D820", VA = "0x185E2EA20")]
	private void IAOKAFGGKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5E2ED30", Offset = "0x5E2DB30", VA = "0x185E2ED30")]
	[CompilerGenerated]
	private void JOPGOMBBFGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class NKEPANLPPKK
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E0C0", Offset = "0x5E2CEC0", VA = "0x185E2E0C0")]
	[IBKPEPPEMNJ(MIBJABCBNEH.None)]
	private static void AGANDBGBFCP(KIDCBAFLGEK FEKKHCCBLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2E1C0", Offset = "0x5E2CFC0", VA = "0x185E2E1C0")]
	[FLGENPOMBLL(JMPBNKBIDHL.Unity_BeforeSceneLoad)]
	private static void IECJAGNMKLN()
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
