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
		[Cpp2IlInjected.Address(RVA = "0x8A945A0", Offset = "0x8A931A0", VA = "0x188A945A0", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A962A0", Offset = "0x8A94EA0", VA = "0x188A962A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
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
	public interface AHAVANPKBUP
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool PTZYVTCEMQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		long? VCRHHZGQLAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		long? YKDUUIYFITV
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Guid? QRVURHYPUUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		float? DTAUEDACHJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		HZKIBBUFLKW XPXPFCPJKAI
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void WLCASBJTUNV(GameClientState a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void ShowMobileHome();

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void ERKUFSGVKER(string a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<HZKIBBUFLKW> DVZUDQJHXEH([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void OIJVNEZEKPJ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface SMATCMIGXDQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class SVUFQITYHQY : AHAVANPKBUP
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
			public AsyncTaskMethodBuilder<HZKIBBUFLKW> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public SVUFQITYHQY <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskCompletionSource<HZKIBBUFLKW> <tcs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<HZKIBBUFLKW> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8A95AA0", Offset = "0x8A946A0", VA = "0x188A95AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8A96150", Offset = "0x8A94D50", VA = "0x188A96150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly Log NPHEYIXDMFH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static SVUFQITYHQY RKTTWJLJQPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly NADKVDSFRLV XEKCXIISDVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly ASVHLEOBLHF BZXEPCYGBRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly XKGFAQFEAAW FYQEGOTKIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private bool ZTCXLQGGKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool UCWBSNBCBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool DHAUJFOYCVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private long? OKIHCMIQIUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool KSXNMMRWBXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private long? TTIGYBWQDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private bool QTLVRKTYKYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Guid? TMXFYLPHEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private GameClientState ERVFABVKXIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly object QCLFLGXTMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly Queue<HZKIBBUFLKW> AWTGGNSKADQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskCompletionSource<HZKIBBUFLKW> EKMQIHMRSFB;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool PTZYVTCEMQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long? VCRHHZGQLAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8A957C0", Offset = "0x8A943C0", VA = "0x188A957C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public long? YKDUUIYFITV
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8A94CC0", Offset = "0x8A938C0", VA = "0x188A94CC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Guid? QRVURHYPUUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8A95840", Offset = "0x8A94440", VA = "0x188A95840", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float? DTAUEDACHJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8A94A00", Offset = "0x8A93600", VA = "0x188A94A00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public HZKIBBUFLKW XPXPFCPJKAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xB44440", Offset = "0xB43040", VA = "0x180B44440", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xBD4170", Offset = "0xBD2D70", VA = "0x180BD4170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8A95940", Offset = "0x8A94540", VA = "0x188A95940")]
		[RecRoom.NoEngine.Common.Preserve]
		public SVUFQITYHQY([Inject(null)] NADKVDSFRLV statsigClient, [Inject(null)] ASVHLEOBLHF sessionManager, [Inject(null)] XKGFAQFEAAW commandLineManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8A94D40", Offset = "0x8A93940", VA = "0x188A94D40", Slot = "11")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8A95280", Offset = "0x8A93E80", VA = "0x188A95280", Slot = "16")]
		public void VIZJCKKLUAX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8A94830", Offset = "0x8A93430", VA = "0x188A94830", Slot = "12")]
		public void ShowMobileHome()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A94830", Offset = "0x8A93430", VA = "0x188A94830", Slot = "17")]
		public void NNTKAYAHIHB([Optional] string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A94830", Offset = "0x8A93430", VA = "0x188A94830", Slot = "13")]
		public void ERKUFSGVKER(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A956A0", Offset = "0x8A942A0", VA = "0x188A956A0", Slot = "10")]
		public void WLCASBJTUNV(GameClientState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A94EB0", Offset = "0x8A93AB0", VA = "0x188A94EB0", Slot = "15")]
		public void OIJVNEZEKPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A94620", Offset = "0x8A93220", VA = "0x188A94620", Slot = "14")]
		[AsyncStateMachine(typeof(<GetNextRRUrl>d__40))]
		public Task<HZKIBBUFLKW> DVZUDQJHXEH(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A94AC0", Offset = "0x8A936C0", VA = "0x188A94AC0")]
		private void HLZOZHLQGSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A947C0", Offset = "0x8A933C0", VA = "0x188A947C0")]
		[MonoPInvokeCallback(typeof(ProcessRRUrlDelegate))]
		private static void EPXCTKIPLDW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8A95220", Offset = "0x8A93E20", VA = "0x188A95220")]
		[MonoPInvokeCallback(typeof(GetGameClientStateDelegate))]
		private static int TEHHRQQTWMM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8A94740", Offset = "0x8A93340", VA = "0x188A94740")]
		private void EHSSVFIBBMW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8A95050", Offset = "0x8A93C50", VA = "0x188A95050")]
		private void RegisterProcessRRUrlCallback(ProcessRRUrlDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8A95010", Offset = "0x8A93C10", VA = "0x188A95010")]
		private void RegisterGetGameClientStateCallback(GetGameClientStateDelegate callback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A94830", Offset = "0x8A93430", VA = "0x188A94830")]
		private void ShowMobileHome(ShowMobileHomeReasons reason, string details)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8A94FD0", Offset = "0x8A93BD0", VA = "0x188A94FD0")]
		private void OnGameClientStateChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8A948E0", Offset = "0x8A934E0", VA = "0x188A948E0")]
		private long? GetGameSessionId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A94940", Offset = "0x8A93540", VA = "0x188A94940")]
		private long? GetRudderstackSessionId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8A94870", Offset = "0x8A93470", VA = "0x188A94870")]
		private Guid? GetAppSessionGuid()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8A949A0", Offset = "0x8A935A0", VA = "0x188A949A0")]
		private double? GetTimeSinceUnityStart()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A956F0", Offset = "0x8A942F0", VA = "0x188A956F0")]
		internal static void YJLEIQHCMFQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A95090", Offset = "0x8A93C90", VA = "0x188A95090")]
		private void SAYIYMZELPS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class FDWUDGQXMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8A943B0", Offset = "0x8A92FB0", VA = "0x188A943B0")]
		[IFIZWETSKCB.Root]
		internal static void EOCUNEIODMM(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8A944A0", Offset = "0x8A930A0", VA = "0x188A944A0")]
		[RRRuntimeInitializeMethod.BeforeSceneLoad]
		internal static void WPKHQWSCCQW()
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
