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
using RecRoom.Analytics.Statsig;
using RecRoom.Core;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.UrlHandler.Runtime;
using UJect;
using UJect.Injection;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_MobileHome_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8616450", Offset = "0x8615250", VA = "0x188616450", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86182B0", Offset = "0x86170B0", VA = "0x1886182B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.MobileHome
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum GameClientState
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
	public interface CQOZCLSORZL
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool TSUMSITDZLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		long? BLMIIMGGMWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		long? STCCUZECEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Guid? GDXTVHAYJLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		float? BQRJIDECSIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		LVIPGIHTSRG VSRYITULIZI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void AUSOEKCHFFX(GameClientState a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ShowMobileHome();

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void CBKXXTJOFLJ(string a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<LVIPGIHTSRG> YRBVUMSIDZT([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void LNLWHCIYHCV();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface CZEYPMYMTYQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class UEXNQRWDRXM : CQOZCLSORZL
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private enum ShowMobileHomeReasons
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			Default = 0,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Logout = 1,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			Error = -1
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private delegate void ProcessRRUrlDelegate(string rrUrl);

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private delegate int GetGameClientStateDelegate();

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct <GetNextRRUrl>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<LVIPGIHTSRG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public UEXNQRWDRXM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskCompletionSource<LVIPGIHTSRG> <tcs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<LVIPGIHTSRG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x86164D0", Offset = "0x86152D0", VA = "0x1886164D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8616B00", Offset = "0x8615900", VA = "0x188616B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly Log WPIOOUTTKAH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static UEXNQRWDRXM VUSGKOYVZZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DINTWZBUUTH ELRDSSJYRWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly XRHBEMYGAXH TMNKLGDJEFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly TFIDSPXUOAI JGXSFZKBFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private bool CCBWSVUWFAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool GNADAOGCUOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool MCVYNVPQRUY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private long? IMXSREOJNKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool GCCHWHSAQVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private long? WHTBGUZCWPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool XLCRVRZOCOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Guid? HNQITNNXWZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private GameClientState DMBPIXJAKAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly object ETDEVKUZGCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Queue<LVIPGIHTSRG> WQAACSVOFJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskCompletionSource<LVIPGIHTSRG> IMELEROGXRH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool TSUMSITDZLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long? BLMIIMGGMWG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8617710", Offset = "0x8616510", VA = "0x188617710", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public long? STCCUZECEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8617040", Offset = "0x8615E40", VA = "0x188617040", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid? GDXTVHAYJLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8617790", Offset = "0x8616590", VA = "0x188617790", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float? BQRJIDECSIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8617D10", Offset = "0x8616B10", VA = "0x188617D10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LVIPGIHTSRG VSRYITULIZI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xAEDD70", Offset = "0xAECB70", VA = "0x180AEDD70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB880F0", Offset = "0xB86EF0", VA = "0x180B880F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8617F60", Offset = "0x8616D60", VA = "0x188617F60")]
		[RecRoom.NoEngine.Common.Preserve]
		public UEXNQRWDRXM([Inject(null)] DINTWZBUUTH statsigClient, [Inject(null)] XRHBEMYGAXH sessionManager, [Inject(null)] TFIDSPXUOAI commandLineManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8616ED0", Offset = "0x8615CD0", VA = "0x188616ED0", Slot = "11")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86178F0", Offset = "0x86166F0", VA = "0x1886178F0", Slot = "16")]
		public void YIWCWONIDGJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8616CA0", Offset = "0x8615AA0", VA = "0x188616CA0", Slot = "12")]
		public void ShowMobileHome()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8616CA0", Offset = "0x8615AA0", VA = "0x188616CA0", Slot = "17")]
		public void XUOIZBGOXOV([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8616CA0", Offset = "0x8615AA0", VA = "0x188616CA0", Slot = "13")]
		public void CBKXXTJOFLJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8616C50", Offset = "0x8615A50", VA = "0x188616C50", Slot = "10")]
		public void AUSOEKCHFFX(GameClientState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86170C0", Offset = "0x8615EC0", VA = "0x1886170C0", Slot = "15")]
		public void LNLWHCIYHCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8617DD0", Offset = "0x8616BD0", VA = "0x188617DD0", Slot = "14")]
		[AsyncStateMachine(typeof(<GetNextRRUrl>d__40))]
		public Task<LVIPGIHTSRG> YRBVUMSIDZT(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86171E0", Offset = "0x8615FE0", VA = "0x1886171E0")]
		private void LWWPQQBAKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8617620", Offset = "0x8616420", VA = "0x188617620")]
		[MonoPInvokeCallback(typeof(ProcessRRUrlDelegate))]
		private static void QUAXCUGMZWC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8616E70", Offset = "0x8615C70", VA = "0x188616E70")]
		[MonoPInvokeCallback(typeof(GetGameClientStateDelegate))]
		private static int HYLRMCPPVLY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86175A0", Offset = "0x86163A0", VA = "0x1886175A0")]
		private void QBXZEOAEAGM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86176D0", Offset = "0x86164D0", VA = "0x1886176D0")]
		private void RegisterProcessRRUrlCallback(ProcessRRUrlDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8617690", Offset = "0x8616490", VA = "0x188617690")]
		private void RegisterGetGameClientStateCallback(GetGameClientStateDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8616CA0", Offset = "0x8615AA0", VA = "0x188616CA0")]
		private void ShowMobileHome(ShowMobileHomeReasons reason, string details)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8617560", Offset = "0x8616360", VA = "0x188617560")]
		private void OnGameClientStateChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8616D50", Offset = "0x8615B50", VA = "0x188616D50")]
		private long? GetGameSessionId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8616DB0", Offset = "0x8615BB0", VA = "0x188616DB0")]
		private long? GetRudderstackSessionId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8616CE0", Offset = "0x8615AE0", VA = "0x188616CE0")]
		private Guid? GetAppSessionGuid()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8616E10", Offset = "0x8615C10", VA = "0x188616E10")]
		private double? GetTimeSinceUnityStart()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8617820", Offset = "0x8616620", VA = "0x188617820")]
		internal static void YCOAOESOALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86173E0", Offset = "0x86161E0", VA = "0x1886173E0")]
		private void NBYVBHQRNPY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ZEQWUIZDCGQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86180C0", Offset = "0x8616EC0", VA = "0x1886180C0")]
		[FDNTPBIGLET.Root]
		internal static void CPQSXQWHCVQ(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86181B0", Offset = "0x8616FB0", VA = "0x1886181B0")]
		[RRRuntimeInitializeMethod.BeforeSceneLoad]
		internal static void SBZXRNJWPMA()
		{
		}
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
