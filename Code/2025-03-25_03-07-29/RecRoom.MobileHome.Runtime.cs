using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x788E6E0", Offset = "0x788DAE0", VA = "0x18788E6E0", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7890420", Offset = "0x788F820", VA = "0x187890420", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LIDENACEAAO
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
	PlayerCustomization = 34,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	RoomLoading = 64,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	InOrientation = 65,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	InDorm = 66,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	InRoom = 67,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	InEvent = 68,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Logout = 128,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	ExitingClient = 129
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ALKMELNBMIF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JLCOENKKLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? AHCPANLBINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? DEMJKFOAPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? DAKNIILLIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? PCFEFDFAHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	LLNBFMIGJJG OKBNHBONIAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CNCBBAPIDPJ(LIDENACEAAO FBOKGPFKJCL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MBHBIOMKKEG();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NJAEKEHPBCG();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JJGGADKDANJ(string PCGENKDPJLI);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<LLNBFMIGJJG> GKNGFLEGOAC([Optional] CancellationToken BLABAMPAGAH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DGPIACPJLHM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FMKNDFBHHGK
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PAEBABLLOLP : ALKMELNBMIF
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum LHCEHBCHCFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void HOBKHAHPCCO(string HMBDOGODMIC);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int GEGNJHFFILD();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct PIKLEJAMDGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<LLNBFMIGJJG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public PAEBABLLOLP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<LLNBFMIGJJG> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<LLNBFMIGJJG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x788FC90", Offset = "0x788F090", VA = "0x18788FC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x78902D0", Offset = "0x788F6D0", VA = "0x1878902D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly ABDDJEPKCOD DLBCFJLNCHA;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static PAEBABLLOLP MOAEMAHGOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HNAFBHEKIKK ACIGBMLBDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KHKCCPNIAAP FPPOAHLPNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly FFMKCODMNLJ PLNMFICFBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool PKNLEPNADOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PDIDINEJIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool ODHEJIAIHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? OJEAMEHHFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool HCPCJCAKMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? OBFIBOIJPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool CPMJDBCEPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? MIJNLJBPCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private LIDENACEAAO NAAJMEAJPEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object LAKJCCNHMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<LLNBFMIGJJG> CKDOAKIOGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<LLNBFMIGJJG> EKPABLAFEPO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool JLCOENKKLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? AHCPANLBINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x788F830", Offset = "0x788EC30", VA = "0x18788F830", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? DEMJKFOAPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x788F350", Offset = "0x788E750", VA = "0x18788F350", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? DAKNIILLIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x788EF90", Offset = "0x788E390", VA = "0x18788EF90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? PCFEFDFAHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x788E7F0", Offset = "0x788DBF0", VA = "0x18788E7F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LLNBFMIGJJG OKBNHBONIAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB2BB10", Offset = "0xB2AF10", VA = "0x180B2BB10", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x11E1950", Offset = "0x11E0D50", VA = "0x1811E1950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x788FB10", Offset = "0x788EF10", VA = "0x18788FB10")]
	[RecRoom.NoEngine.Common.Preserve]
	public PAEBABLLOLP([GKAMHFFOHNI(null)] HNAFBHEKIKK ACIGBMLBDHL, [GKAMHFFOHNI(null)] KHKCCPNIAAP FPPOAHLPNDN, [GKAMHFFOHNI(null)] FFMKCODMNLJ PLNMFICFBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x788F3D0", Offset = "0x788E7D0", VA = "0x18788F3D0", Slot = "11")]
	public void MBHBIOMKKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x788E8B0", Offset = "0x788DCB0", VA = "0x18788E8B0", Slot = "16")]
	public void CKKBHFFEMDN(string IPKJDGNPMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x788F020", Offset = "0x788E420", VA = "0x18788F020", Slot = "12")]
	public void NJAEKEHPBCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x788F020", Offset = "0x788E420", VA = "0x18788F020", Slot = "17")]
	public void GGAPFNNLDJL([Optional] string AIPMFKPBIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x788F020", Offset = "0x788E420", VA = "0x18788F020", Slot = "13")]
	public void JJGGADKDANJ(string PCGENKDPJLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x788ECD0", Offset = "0x788E0D0", VA = "0x18788ECD0", Slot = "10")]
	public void CNCBBAPIDPJ(LIDENACEAAO FBOKGPFKJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x788ED20", Offset = "0x788E120", VA = "0x18788ED20", Slot = "15")]
	public void DGPIACPJLHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x788F060", Offset = "0x788E460", VA = "0x18788F060", Slot = "14")]
	[AsyncStateMachine(typeof(PIKLEJAMDGH))]
	public Task<LLNBFMIGJJG> GKNGFLEGOAC(CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x788F540", Offset = "0x788E940", VA = "0x18788F540")]
	private void MHHBBFLMDLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x788F8B0", Offset = "0x788ECB0", VA = "0x18788F8B0")]
	[MonoPInvokeCallback(typeof(HOBKHAHPCCO))]
	private static void PJOBMBFJFFJ(string IPKJDGNPMAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x788F7D0", Offset = "0x788EBD0", VA = "0x18788F7D0")]
	[MonoPInvokeCallback(typeof(GEGNJHFFILD))]
	private static int NDHPPEGPPOD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x788E770", Offset = "0x788DB70", VA = "0x18788E770")]
	private void BDIAEDJLHFL(string MAJFAELMBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x788EEB0", Offset = "0x788E2B0", VA = "0x18788EEB0")]
	private void DIFHJJHBGNA(HOBKHAHPCCO FJLFOAFFGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x788F180", Offset = "0x788E580", VA = "0x18788F180")]
	private void ICNOPOCBDEO(GEGNJHFFILD FJLFOAFFGHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x788F020", Offset = "0x788E420", VA = "0x18788F020")]
	private void NJAEKEHPBCG(LHCEHBCHCFH CIAFGFLDDGN, string CCOPOGOBFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x788EEF0", Offset = "0x788E2F0", VA = "0x18788EEF0")]
	private void DJPGKIKHAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x788F290", Offset = "0x788E690", VA = "0x18788F290")]
	private long? LGPINALBGNH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x788EF30", Offset = "0x788E330", VA = "0x18788EF30")]
	private long? EJLPALNEOHD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x788EE40", Offset = "0x788E240", VA = "0x18788EE40")]
	private Guid? DICBGMAMIBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x788F2F0", Offset = "0x788E6F0", VA = "0x18788F2F0")]
	private double? LNLGDFFMIGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x788F1C0", Offset = "0x788E5C0", VA = "0x18788F1C0")]
	internal static void JDNNJACKGHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x788F920", Offset = "0x788ED20", VA = "0x18788F920")]
	private void POEHJDDDNHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BEKDPMJGKOE
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x788E4E0", Offset = "0x788D8E0", VA = "0x18788E4E0")]
	[BOBPNFIGGBE.NBDKKMMHNGD]
	internal static void JPJMIENCOHM(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x788E5E0", Offset = "0x788D9E0", VA = "0x18788E5E0")]
	[FGALJGDFECK.NDOKACNFLAD]
	internal static void PJNDJCGFHJJ()
	{
	}
}
namespace Cpp2IlInjected
{
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
}
