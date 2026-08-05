using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Cameras.Effects;
using RecRoom.NoEngine.Common;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7997A0", Offset = "0x7985A0", VA = "0x1807997A0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A6E0", Offset = "0x5D194E0", VA = "0x185D1A6E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x799B60", Offset = "0x798960", VA = "0x180799B60")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x799BA0", Offset = "0x7989A0", VA = "0x180799BA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[KBJLIMKPDCA]
public class OOIHCFCOEHL : NHAHPJAOMNI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal enum GBFEOPOHMHC
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		ShowingCamera,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		FadingToBlack,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		ShowingBlack,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		FadingToCamera
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MANHEGHGOAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public OOIHCFCOEHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5D191D0", Offset = "0x5D17FD0", VA = "0x185D191D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5D195D0", Offset = "0x5D183D0", VA = "0x185D195D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MNIBONECLBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public MNIBONECLBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5D19910", Offset = "0x5D18710", VA = "0x185D19910")]
		internal void NKPLOIEOJCH(GBFEOPOHMHC fadeState)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct NFCBMBLFKFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public GBFEOPOHMHC completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public OOIHCFCOEHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<MEBKGJPNLAN> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private MNIBONECLBB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private object <animateInOutSuppressionToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float <transitionStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CancellationToken <cancellationToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float? <lastFadeSlope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private float <lerpTimeStart>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private float <lerpTimeEnd>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private float <lerpStartValue>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float <lerpEndValue>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5D19940", Offset = "0x5D18740", VA = "0x185D19940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A680", Offset = "0x5D19480", VA = "0x185D1A680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct MANGIDLINKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public OOIHCFCOEHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5D18D60", Offset = "0x5D17B60", VA = "0x185D18D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5D19170", Offset = "0x5D17F70", VA = "0x185D19170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class LHNIENAJEBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public TaskCompletionSource<GBFEOPOHMHC> tcs;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public LHNIENAJEBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5D189C0", Offset = "0x5D177C0", VA = "0x185D189C0")]
		internal void CAPMJLPBLOO()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct JJKOBENIDJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public ICollection<TaskCompletionSource<GBFEOPOHMHC>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private LHNIENAJEBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<GBFEOPOHMHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5D182F0", Offset = "0x5D170F0", VA = "0x185D182F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5D18960", Offset = "0x5D17760", VA = "0x185D18960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ONIINPABCBC KKGJBDKEEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LDOPLFEHIDC CDLIFLJAEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KMAPALJLENL JADCKHJMPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NKIMNIANPPG CPPGDNPOAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MMMEDELMKAF ONNEJCIMMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<Task> BAGCJIKBOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly FDAMOGBDELP JCDODKEACHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FDAMOGBDELP NDDCIBOKPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource GCPOFNIBKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationToken AKIPAEAMJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LGOCCBOIBDC<GMLJCNLKEBM> FKIOKCHMLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly object ONLAMJLIIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object PPBBOMADODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TaskCompletionSource<GBFEOPOHMHC>> GDIGBOFOCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<GBFEOPOHMHC>> EONGLCEDFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private GBFEOPOHMHC IIIBMHKECAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal bool DOIGEMIBCPG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool IJGBPEHKANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B890", Offset = "0x5D1A690", VA = "0x185D1B890", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BANBAEOENHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BA30", Offset = "0x5D1A830", VA = "0x185D1BA30", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BFBNGCAHGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A880", Offset = "0x5D19680", VA = "0x185D1A880", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float FOLEJALFLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAE8BA0", Offset = "0xAE79A0", VA = "0x180AE8BA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAE8BB0", Offset = "0xAE79B0", VA = "0x180AE8BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private GBFEOPOHMHC HBJMCIHLGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB63850", Offset = "0xB62650", VA = "0x180B63850")]
		get
		{
			return default(GBFEOPOHMHC);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1A890", Offset = "0x5D19690", VA = "0x185D1A890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<GBFEOPOHMHC> BDAABLEHEEM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AE80", Offset = "0x5D19C80", VA = "0x185D1AE80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B1B0", Offset = "0x5D19FB0", VA = "0x185D1B1B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C3B0", Offset = "0x5D1B1B0", VA = "0x185D1C3B0")]
	[Preserve]
	public OOIHCFCOEHL([HOHGLGKGFHE(null)] ONIINPABCBC KKGJBDKEEGE, [HOHGLGKGFHE(null)] LDOPLFEHIDC CDLIFLJAEBK, [HOHGLGKGFHE(null)] KMAPALJLENL JADCKHJMPEE, [HOHGLGKGFHE("CameraFadeTimeoutDetector")] NKIMNIANPPG CPPGDNPOAEK, [HOHGLGKGFHE(null)] MMMEDELMKAF ONNEJCIMMMG, [HOHGLGKGFHE(null)] FMENBEFEHCP<CameraFadeOptions> INHBNHHKMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BD00", Offset = "0x5D1AB00", VA = "0x185D1BD00")]
	internal OOIHCFCOEHL(ONIINPABCBC KKGJBDKEEGE, LDOPLFEHIDC CDLIFLJAEBK, KMAPALJLENL JADCKHJMPEE, NKIMNIANPPG CPPGDNPOAEK, MMMEDELMKAF ONNEJCIMMMG, FMENBEFEHCP<CameraFadeOptions> INHBNHHKMGG, Func<Task>? BAGCJIKBOML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B270", Offset = "0x5D1A070", VA = "0x185D1B270", Slot = "8")]
	public FDLMNJNGMKJ JECGJIJAAPE(GMLJCNLKEBM HOBAPMCPFML, [Optional] BDOKMAEEEDC? NIBIPHFFFDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B0C0", Offset = "0x5D19EC0", VA = "0x185D1B0C0", Slot = "9")]
	[AsyncStateMachine(typeof(MANHEGHGOAI))]
	public Task GKJEJMLHLCI([Optional] CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BB70", Offset = "0x5D1A970", VA = "0x185D1BB70", Slot = "10")]
	public IReadOnlyCollection<GMLJCNLKEBM> OFPPBALIMIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B8B0", Offset = "0x5D1A6B0", VA = "0x185D1B8B0")]
	internal void LIHCAJKBANP(GMLJCNLKEBM HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A760", Offset = "0x5D19560", VA = "0x185D1A760")]
	private MEBKGJPNLAN ABOHBDHKOBM()
	{
		return default(MEBKGJPNLAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BA40", Offset = "0x5D1A840", VA = "0x185D1BA40")]
	private MEBKGJPNLAN MPPBOIEAFAE()
	{
		return default(MEBKGJPNLAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ACD0", Offset = "0x5D19AD0", VA = "0x185D1ACD0")]
	internal void EOGPNGOLNBM(GMLJCNLKEBM HOBAPMCPFML, BDOKMAEEEDC FEIGAGEMCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BBC0", Offset = "0x5D1A9C0", VA = "0x185D1BBC0")]
	private static void PIHNGEDGPMD(IReadOnlyList<TaskCompletionSource<GBFEOPOHMHC>> FCKOAIKPMKC, GBFEOPOHMHC BFLKPBBPEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AF40", Offset = "0x5D19D40", VA = "0x185D1AF40")]
	private void GFDLCFFPLHC(float NJFAKANIHLJ, Func<MEBKGJPNLAN> PDJFPAGCIHC, GBFEOPOHMHC ILPKIMEDGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AB40", Offset = "0x5D19940", VA = "0x185D1AB40")]
	private static bool EAGNDLAPAHF(float ALNGIEPPLJJ, float DCODMCLNKEM, float JCIELIKINJI = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A9C0", Offset = "0x5D197C0", VA = "0x185D1A9C0")]
	[AsyncStateMachine(typeof(NFCBMBLFKFI))]
	private Task CGDGONOKGGD(CancellationToken FODMGJKDOOC, float NJFAKANIHLJ, Func<MEBKGJPNLAN> ALCAJPGHHEL, GBFEOPOHMHC ILPKIMEDGNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ABC0", Offset = "0x5D199C0", VA = "0x185D1ABC0")]
	private void EFAAFIMEDKL(float FCPLNPBLLOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A790", Offset = "0x5D19590", VA = "0x185D1A790")]
	[AsyncStateMachine(typeof(MANGIDLINKN))]
	internal Task AJENDIFNGBH([Optional] CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BA70", Offset = "0x5D1A870", VA = "0x185D1BA70")]
	[AsyncStateMachine(typeof(JJKOBENIDJN))]
	private static Task NLCMNPEOFKG(ICollection<TaskCompletionSource<GBFEOPOHMHC>> FCKOAIKPMKC, CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D1AB00", Offset = "0x5D19900", VA = "0x185D1AB00", Slot = "11")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class LHPPDEHIHHC : FDLMNJNGMKJ, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ABPNMOCMIIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LHPPDEHIHHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5D17AB0", Offset = "0x5D168B0", VA = "0x185D17AB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D17D30", Offset = "0x5D16B30", VA = "0x185D17D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly BGIGGGBPADJ EFHCKGMAEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly OOIHCFCOEHL FPDLDNLHLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly GMLJCNLKEBM HOBAPMCPFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool AOBNNKEMCKA;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D18CB0", Offset = "0x5D17AB0", VA = "0x185D18CB0")]
	internal LHPPDEHIHHC(OOIHCFCOEHL FPDLDNLHLOH, GMLJCNLKEBM HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D18A10", Offset = "0x5D17810", VA = "0x185D18A10", Slot = "4")]
	[AsyncStateMachine(typeof(ABPNMOCMIIG))]
	public Task ACEIIIEFMCB([Optional] CancellationToken ELPOPHCEGNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D18B00", Offset = "0x5D17900", VA = "0x185D18B00", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal readonly struct MEBKGJPNLAN : IEquatable<MEBKGJPNLAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool LPMDMLCPFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly float IFHLCICAOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly float HGOKGCKJDIE;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D19840", Offset = "0x5D18640", VA = "0x185D19840")]
	public MEBKGJPNLAN(float BDKAENJPDBP, float BIIJIGPINMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D19630", Offset = "0x5D18430", VA = "0x185D19630", Slot = "4")]
	public bool Equals(MEBKGJPNLAN LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D19670", Offset = "0x5D18470", VA = "0x185D19670", Slot = "0")]
	public override bool Equals(object? KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D19720", Offset = "0x5D18520", VA = "0x185D19720", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D197A0", Offset = "0x5D185A0", VA = "0x185D197A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class FDAMOGBDELP
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum JJBHCHGFGMA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly JJBHCHGFGMA DOCECOOJFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Dictionary<object, MEBKGJPNLAN> DANEFPJEHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly MEBKGJPNLAN OJACGADPJDL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MEBKGJPNLAN DHGNDNJJJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x89AFE0", Offset = "0x899DE0", VA = "0x18089AFE0")]
		[CompilerGenerated]
		get
		{
			return default(MEBKGJPNLAN);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89ACC0", Offset = "0x899AC0", VA = "0x18089ACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D18230", Offset = "0x5D17030", VA = "0x185D18230")]
	public FDAMOGBDELP(JJBHCHGFGMA DOCECOOJFLJ, MEBKGJPNLAN OJACGADPJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D17E80", Offset = "0x5D16C80", VA = "0x185D17E80")]
	public void EIHPADLGANG(object HOBAPMCPFML, MEBKGJPNLAN FHHGBKNCMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5D17DD0", Offset = "0x5D16BD0", VA = "0x185D17DD0")]
	public void BFKGBCINJJC(object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D18040", Offset = "0x5D16E40", VA = "0x185D18040")]
	public void LPNBJONBLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D17FA0", Offset = "0x5D16DA0", VA = "0x185D17FA0")]
	private void GLGICIHBDKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5D17E40", Offset = "0x5D16C40", VA = "0x185D17E40")]
	private MEBKGJPNLAN EIGLDKBLMFA()
	{
		return default(MEBKGJPNLAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D17D90", Offset = "0x5D16B90", VA = "0x185D17D90")]
	private MEBKGJPNLAN APBPJEJDLAL()
	{
		return default(MEBKGJPNLAN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D18090", Offset = "0x5D16E90", VA = "0x185D18090")]
	private MEBKGJPNLAN OFBIOPFHIKB(int CNEBONMFBFL)
	{
		return default(MEBKGJPNLAN);
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
