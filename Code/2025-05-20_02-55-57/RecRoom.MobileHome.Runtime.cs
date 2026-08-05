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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7D13480", Offset = "0x7D12680", VA = "0x187D13480", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D14B10", Offset = "0x7D13D10", VA = "0x187D14B10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2675970", Offset = "0x2674B70", VA = "0x182675970")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KBCJKHMOMEI
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
public interface INHHCFGOOJH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LDOIGNIOAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	long? OPNKANGOIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	long? HNBFNBHGNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Guid? AIJBJLKJEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float? FONKONDEMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	NJEDIOFHEIL LJOPONDFJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AMODLGNGKAA(KBCJKHMOMEI HPAPEOOKLIH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ILLMBOBOELN();

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BKKNEEMLNDA();

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BPCDIBLOBCN(string JGBHCJABAIH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<NJEDIOFHEIL> LFCAHFNPBCO([Optional] CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GEPJEHMLNBH();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ONMGMLNBKKK
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class OJCDOJJFJPL : INHHCFGOOJH
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private enum GJBGMOGPKDL
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Logout = 1,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Error = -1
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void GJDMJKCJAEO(string AIHOLFGEDBF);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private delegate int JHGHEHDJKJH();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct EGNCPDEFFMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<NJEDIOFHEIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public OJCDOJJFJPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskCompletionSource<NJEDIOFHEIL> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private TaskAwaiter<NJEDIOFHEIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7D12DD0", Offset = "0x7D11FD0", VA = "0x187D12DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7D13410", Offset = "0x7D12610", VA = "0x187D13410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly FODGIOKBGBI GCMHLHCLEDM;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static OJCDOJJFJPL BJFPHBLMMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HCDMAMCBAKB EMEHCGCBFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly JCJNPKLKHAD FBPEJAMFOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly OINALMOGKHN HEBHDIHEDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private bool IFNHNOEGLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private bool ALNMJJFFDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool LLLHAALPMBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private long? NBJNHJBGJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private bool PBOOOBHOCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private long? IOCADNGKOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private bool KHLCMOJNCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private Guid? DNLOLGAIEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private KBCJKHMOMEI JHCOHKFMEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly object EGLBKBCIPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly Queue<NJEDIOFHEIL> BNGLNNBBEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private TaskCompletionSource<NJEDIOFHEIL> FHMCIKHPHBG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LDOIGNIOAMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public long? OPNKANGOIBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D13CE0", Offset = "0x7D12EE0", VA = "0x187D13CE0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public long? HNBFNBHGNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7D14760", Offset = "0x7D13960", VA = "0x187D14760", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public Guid? AIJBJLKJEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7D13ED0", Offset = "0x7D130D0", VA = "0x187D13ED0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public float? FONKONDEMIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D141C0", Offset = "0x7D133C0", VA = "0x187D141C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NJEDIOFHEIL LJOPONDFJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBE1AD0", Offset = "0xBE0CD0", VA = "0x180BE1AD0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1316000", Offset = "0x1315200", VA = "0x181316000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D148B0", Offset = "0x7D13AB0", VA = "0x187D148B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public OJCDOJJFJPL([ALHAHLCGLLK(null)] HCDMAMCBAKB EMEHCGCBFGM, [ALHAHLCGLLK(null)] JCJNPKLKHAD FBPEJAMFOCE, [ALHAHLCGLLK(null)] OINALMOGKHN HEBHDIHEDHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D13D60", Offset = "0x7D12F60", VA = "0x187D13D60", Slot = "11")]
	public void ILLMBOBOELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D136E0", Offset = "0x7D128E0", VA = "0x187D136E0", Slot = "16")]
	public void FCAMGOOLDHD(string DFDOGDHKFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D136A0", Offset = "0x7D128A0", VA = "0x187D136A0", Slot = "12")]
	public void BKKNEEMLNDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D136A0", Offset = "0x7D128A0", VA = "0x187D136A0", Slot = "17")]
	public void GEMDKABDDDJ([Optional] string CPDBDGAAEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D136A0", Offset = "0x7D128A0", VA = "0x187D136A0", Slot = "13")]
	public void BPCDIBLOBCN(string JGBHCJABAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D135E0", Offset = "0x7D127E0", VA = "0x187D135E0", Slot = "10")]
	public void AMODLGNGKAA(KBCJKHMOMEI HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D13B00", Offset = "0x7D12D00", VA = "0x187D13B00", Slot = "15")]
	public void GEPJEHMLNBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D14580", Offset = "0x7D13780", VA = "0x187D14580", Slot = "14")]
	[AsyncStateMachine(typeof(EGNCPDEFFMJ))]
	public Task<NJEDIOFHEIL> LFCAHFNPBCO(CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D14280", Offset = "0x7D13480", VA = "0x187D14280")]
	private void KHJFKDEMCNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D13630", Offset = "0x7D12830", VA = "0x187D13630")]
	[MonoPInvokeCallback(typeof(GJDMJKCJAEO))]
	private static void BHMNKMGGACF(string DFDOGDHKFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D14160", Offset = "0x7D13360", VA = "0x187D14160")]
	[MonoPInvokeCallback(typeof(JHGHEHDJKJH))]
	private static int JOCPEDBPJCI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D13F60", Offset = "0x7D13160", VA = "0x187D13F60")]
	private void JEGFIEHMDHN(string BFKKHDOKBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D13C60", Offset = "0x7D12E60", VA = "0x187D13C60")]
	private void HFIKJCGNGIE(GJDMJKCJAEO LKEPFHDAAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7D13C20", Offset = "0x7D12E20", VA = "0x187D13C20")]
	private void GFBLKPHANHH(JHGHEHDJKJH LKEPFHDAAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7D136A0", Offset = "0x7D128A0", VA = "0x187D136A0")]
	private void BKKNEEMLNDA(GJBGMOGPKDL BPAILNFLNFH, string HLLLKDGFKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7D13CA0", Offset = "0x7D12EA0", VA = "0x187D13CA0")]
	private void HMMGIJPBIFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D14700", Offset = "0x7D13900", VA = "0x187D14700")]
	private long? MILOAFKMHMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D146A0", Offset = "0x7D138A0", VA = "0x187D146A0")]
	private long? LOKKGLIDLAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D14510", Offset = "0x7D13710", VA = "0x187D14510")]
	private Guid? LFBNMALMPHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7D147E0", Offset = "0x7D139E0", VA = "0x187D147E0")]
	private double? PAMIKOPGHOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7D13510", Offset = "0x7D12710", VA = "0x187D13510")]
	internal static void AGEFKLMOJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7D13FE0", Offset = "0x7D131E0", VA = "0x187D13FE0")]
	private void JIMMIKCJPCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CJBAEKGMKAF
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7D12CD0", Offset = "0x7D11ED0", VA = "0x187D12CD0")]
	[DBIDCJGLKKO.BICJMLCNMCI]
	internal static void BCGDKAFCJOB(HILJAABEPDC NPCDKJJJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7D12BD0", Offset = "0x7D11DD0", VA = "0x187D12BD0")]
	[CBBBKCBCELM.JEOCHIKIEPK]
	internal static void AMOOGCHHLCK()
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
