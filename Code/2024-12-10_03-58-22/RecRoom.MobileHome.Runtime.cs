using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3C20", Offset = "0x6CB2820", VA = "0x186CB3C20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2039EC0", Offset = "0x2038AC0", VA = "0x182039EC0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum DCMCFGHCGGC
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
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BJDBJLIFDCN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EDLMIBGJIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? DOJFDFIJJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? CFNCPCHOBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? GLMKKBIMPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? KADAMIKPHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CNBKENJLFMJ OAOBBFICHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event EventHandler<EventArgs> CFBKNKGHHAD;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GKGCGGPNMAB(DCMCFGHCGGC GFCPLDIMNPM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KMAKNPIEEHP();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ELANNDNFJEF();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void EJFOOFBDBCE(string GBOALNADBDE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void BEFHIONLBGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IBBFBCDCNHO
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LJKHBJFNNPF(CNBKENJLFMJ IGIMKFOJAIL, [Optional] CancellationToken CKKFHABGBNL);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KALMFJMHHNE : BJDBJLIFDCN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private enum HJKJGADDBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private delegate void FNJPMIPNOOD(string IGIMKFOJAIL);

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate int OKILPOMNKDL();

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static KALMFJMHHNE CMIAKAKADAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly OAJBCHCNOFD OKBIACGFBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly MGGEODNKKBO CMNELMPCMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private bool DOBLPLFAOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool LMIFKFPMDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool PMLHDALDMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool LEMEOJLJNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? MCDHFPBAPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool HMPODCEJELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? LKMLEMECIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool ENKNJCEIPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? KLIPPGOAOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private DCMCFGHCGGC HIDKCLALLFF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool EDLMIBGJIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? DOJFDFIJJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3A90", Offset = "0x6CB2690", VA = "0x186CB3A90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? CFNCPCHOBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6CB3790", Offset = "0x6CB2390", VA = "0x186CB3790", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? GLMKKBIMPBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6CB2D30", Offset = "0x6CB1930", VA = "0x186CB2D30", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? KADAMIKPHNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6CB35F0", Offset = "0x6CB21F0", VA = "0x186CB35F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public CNBKENJLFMJ OAOBBFICHPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88EA10", Offset = "0x88D610", VA = "0x18088EA10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88EAB0", Offset = "0x88D6B0", VA = "0x18088EAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event EventHandler<EventArgs> CFBKNKGHHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6CB39E0", Offset = "0x6CB25E0", VA = "0x186CB39E0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6CB32A0", Offset = "0x6CB1EA0", VA = "0x186CB32A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3700", Offset = "0x6CB2300", VA = "0x186CB3700")]
	private void HLFKGGKNGOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3B80", Offset = "0x6CB2780", VA = "0x186CB3B80")]
	[RecRoom.NoEngine.Common.Preserve]
	public KALMFJMHHNE([JGAMIMHCGFI(null)] OAJBCHCNOFD OKBIACGFBEO, [JGAMIMHCGFI(null)] MGGEODNKKBO CMNELMPCMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3880", Offset = "0x6CB2480", VA = "0x186CB3880", Slot = "13")]
	public void KMAKNPIEEHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2930", Offset = "0x6CB1530", VA = "0x186CB2930", Slot = "16")]
	public void BEFHIONLBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2940", Offset = "0x6CB1540", VA = "0x186CB2940", Slot = "17")]
	public void BMEELFPBEFG(string NDBBIGMEMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2E30", Offset = "0x6CB1A30", VA = "0x186CB2E30", Slot = "14")]
	public void ELANNDNFJEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3780", Offset = "0x6CB2380", VA = "0x186CB3780", Slot = "18")]
	public void HPMENDPLNFP([Optional] string FFDKHDBDCCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2D20", Offset = "0x6CB1920", VA = "0x186CB2D20", Slot = "15")]
	public void EJFOOFBDBCE(string GBOALNADBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3400", Offset = "0x6CB2000", VA = "0x186CB3400", Slot = "12")]
	public void GKGCGGPNMAB(DCMCFGHCGGC GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2F80", Offset = "0x6CB1B80", VA = "0x186CB2F80")]
	private void FPFCENJAPLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2CD0", Offset = "0x6CB18D0", VA = "0x186CB2CD0")]
	[MonoPInvokeCallback(typeof(FNJPMIPNOOD))]
	private static void DKAIHGFFMOK(string NDBBIGMEMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2B40", Offset = "0x6CB1740", VA = "0x186CB2B40")]
	[MonoPInvokeCallback(typeof(OKILPOMNKDL))]
	private static int CICJLHHKBLH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6CB28C0", Offset = "0x6CB14C0", VA = "0x186CB28C0")]
	private void BBHONKJNHGA(string CEALFNECEBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2830", Offset = "0x6CB1430", VA = "0x186CB2830")]
	private void AOLLMADFOHG(FNJPMIPNOOD NNGDIBHFMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6CB38A0", Offset = "0x6CB24A0", VA = "0x186CB38A0")]
	private void NJPMEDKAIIK(OKILPOMNKDL NNGDIBHFMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2E40", Offset = "0x6CB1A40", VA = "0x186CB2E40")]
	private void ELANNDNFJEF(HJKJGADDBIJ CKHPKJLILHH, string LAAJLABBANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2C40", Offset = "0x6CB1840", VA = "0x186CB2C40")]
	private void DIJABMMNDDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2ED0", Offset = "0x6CB1AD0", VA = "0x186CB2ED0")]
	private long? EONLELDEMMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2B90", Offset = "0x6CB1790", VA = "0x186CB2B90")]
	private long? DBIHAMMGBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3350", Offset = "0x6CB1F50", VA = "0x186CB3350")]
	private Guid? GJDEOFBHMMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3930", Offset = "0x6CB2530", VA = "0x186CB3930")]
	private double? OALPMGMCJFH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2670", Offset = "0x6CB1270", VA = "0x186CB2670")]
	internal static void ACKKFNBBBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6CB34D0", Offset = "0x6CB20D0", VA = "0x186CB34D0")]
	private void GLMBHHCJJJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DLLCEGFNNIB
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2730", Offset = "0x6CB1330", VA = "0x186CB2730")]
	[BOLBLOCFHKO.ENGLBNKHCKK]
	internal static void JIEKEBODNGC(EAEKKMJPCLA EBEEBGHJNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6CB2670", Offset = "0x6CB1270", VA = "0x186CB2670")]
	[INGHJIDHCCJ.DFFPMDBMIAE]
	internal static void EEJKNFECAEA()
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
