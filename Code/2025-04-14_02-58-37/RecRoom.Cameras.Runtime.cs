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
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x77E29C0", Offset = "0x77E13C0", VA = "0x1877E29C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D8490", Offset = "0x9D6E90", VA = "0x1809D8490")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9D84D0", Offset = "0x9D6ED0", VA = "0x1809D84D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Cameras_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x77E2490", Offset = "0x77E0E90", VA = "0x1877E2490", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OHBOADDCADD]
public class GLJPHHDMION : HMJOFPFMBKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal enum FMCNELHDOJA
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		ShowingCamera,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		FadingToBlack,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		ShowingBlack,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		FadingToCamera
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class FDAAGJMCIGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FMCNELHDOJA IEBAIHKKBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int BBOJCODAIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationTokenSource LBOCPDNMHLP;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74AE8D0", Offset = "0x74AD2D0", VA = "0x1874AE8D0")]
		public FDAAGJMCIGM(FMCNELHDOJA IEBAIHKKBEK, int BBOJCODAIDP, CancellationTokenSource LBOCPDNMHLP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CJNFNINOFNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public GLJPHHDMION <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x77DDD30", Offset = "0x77DC730", VA = "0x1877DDD30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x77DE170", Offset = "0x77DCB70", VA = "0x1877DE170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LLFIKOCAJAI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private struct <<RunTransitionAsync>g__CleanupStateAndNotifyWaiters|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public LLFIKOCAJAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private List<TaskCompletionSource<FMCNELHDOJA>> <awaitersToNotify>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x77E32F0", Offset = "0x77E1CF0", VA = "0x1877E32F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x77E3820", Offset = "0x77E2220", VA = "0x1877E3820", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public GLJPHHDMION <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public FDAAGJMCIGM transitionTaskState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public FMCNELHDOJA transitionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public object animateInOutSuppressionToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int taskId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public FMCNELHDOJA completionState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public CancellationToken systemDisposalToken;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public LLFIKOCAJAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x77E23C0", Offset = "0x77E0DC0", VA = "0x1877E23C0")]
		[AsyncStateMachine(typeof(<<RunTransitionAsync>g__CleanupStateAndNotifyWaiters|0>d))]
		internal Task PBEOFNPIDOA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct KGNDIHAIMCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public GLJPHHDMION <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FDAAGJMCIGM transitionTaskState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken systemDisposalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Func<KEJKLPFBMLN> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private LLFIKOCAJAI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private CancellationTokenSource <cts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float? <lastFadeSlope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float <lerpTimeStart>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private float <lerpTimeEnd>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float <lerpStartValue>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private float <lerpEndValue>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x77E1220", Offset = "0x77DFC20", VA = "0x1877E1220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x77E2310", Offset = "0x77E0D10", VA = "0x1877E2310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct MMAKKEAMLGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public GLJPHHDMION <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x77E2520", Offset = "0x77E0F20", VA = "0x1877E2520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x77E2960", Offset = "0x77E1360", VA = "0x1877E2960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class LFGHMMGLCGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public TaskCompletionSource<FMCNELHDOJA> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
		public LFGHMMGLCGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x77E2370", Offset = "0x77E0D70", VA = "0x1877E2370")]
		internal void BIHNDBANPKL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PEFPFCNLNIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ICollection<TaskCompletionSource<FMCNELHDOJA>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private LFGHMMGLCGN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<FMCNELHDOJA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77E2A40", Offset = "0x77E1440", VA = "0x1877E2A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x77E3290", Offset = "0x77E1C90", VA = "0x1877E3290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly LMPJBEBLCLM BLAHIKOFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly OPEKJGDBDBC NIBPLFBFPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HBOEFAIBPNK NMAOIOCICCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly BGNEBPNKOAE FAKMMFCIMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HIIAIILFNPO PPKPNABLAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly ELHGBDEKHCC IGACGDLEEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Func<Task> FGDAGJALIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KFDNHOFMJGF AMLIHBKLBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly KFDNHOFMJGF KKLFLNEFJIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource HBCCHBKKFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationToken KHONACIBNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CDGOMBJIGND<MDCBAMNMOAI> BJADDKJDGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object ABMDILHEOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly object JKGJFMNPKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<FMCNELHDOJA>> AMKPNJKBCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<TaskCompletionSource<FMCNELHDOJA>> NPEGOFOFHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<FDAAGJMCIGM> KOOFCCAFLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int HNKHEIIEBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private FMCNELHDOJA HFCDECLEPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal bool CDIADFJILKN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool AIOKNJBONHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77DE5A0", Offset = "0x77DCFA0", VA = "0x1877DE5A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FKCOMCJIGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77DFCB0", Offset = "0x77DE6B0", VA = "0x1877DFCB0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DDEDJKHLOHE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77DF800", Offset = "0x77DE200", VA = "0x1877DF800", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JBGDOKPOGDK
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB9A7A0", Offset = "0xB991A0", VA = "0x180B9A7A0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBFD880", Offset = "0xBFC280", VA = "0x180BFD880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private FMCNELHDOJA AMMGLPNMKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xD3AA10", Offset = "0xD39410", VA = "0x180D3AA10")]
		get
		{
			return default(FMCNELHDOJA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77DE830", Offset = "0x77DD230", VA = "0x1877DE830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool GHDLOHCHGIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77DE760", Offset = "0x77DD160", VA = "0x1877DE760", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x77DE4B0", Offset = "0x77DCEB0", VA = "0x1877DE4B0")]
	private FMCNELHDOJA AEGALEKMDAF(FMCNELHDOJA JCFJJCIGDKC)
	{
		return default(FMCNELHDOJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x77DF970", Offset = "0x77DE370", VA = "0x1877DF970")]
	private void NKEBPCLGBGA(FDAAGJMCIGM CBKNJOLMLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x77DE540", Offset = "0x77DCF40", VA = "0x1877DE540")]
	private void AJJNHCAONPL(FDAAGJMCIGM CBKNJOLMLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x77DE940", Offset = "0x77DD340", VA = "0x1877DE940")]
	private void GENLBGLMDPA(FMCNELHDOJA IEBAIHKKBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x77DF960", Offset = "0x77DE360", VA = "0x1877DF960")]
	private int NACPBNLHKPI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x77DFE70", Offset = "0x77DE870", VA = "0x1877DFE70")]
	[RecRoom.NoEngine.Common.Preserve]
	public GLJPHHDMION([GJJKIKPKKBJ(null)] OPEKJGDBDBC NIBPLFBFPMA, [GJJKIKPKKBJ(null)] HBOEFAIBPNK NMAOIOCICCB, [GJJKIKPKKBJ(null)] BGNEBPNKOAE FAKMMFCIMGO, [GJJKIKPKKBJ("CameraFadeTimeoutDetector")] HIIAIILFNPO PPKPNABLAJF, [GJJKIKPKKBJ(null)] ELHGBDEKHCC IGACGDLEEIE, [GJJKIKPKKBJ(null)] LJADAAJOKBP<CameraFadeOptions> LPHHENIAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x77DFEC0", Offset = "0x77DE8C0", VA = "0x1877DFEC0")]
	internal GLJPHHDMION(OPEKJGDBDBC NIBPLFBFPMA, HBOEFAIBPNK NMAOIOCICCB, BGNEBPNKOAE FAKMMFCIMGO, HIIAIILFNPO PPKPNABLAJF, ELHGBDEKHCC IGACGDLEEIE, LJADAAJOKBP<CameraFadeOptions> LPHHENIAGIG, Func<Task>? FGDAGJALIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x77DF190", Offset = "0x77DDB90", VA = "0x1877DF190", Slot = "8")]
	public GHJBLFPCPMC KBNBHJGNHAF(MDCBAMNMOAI GNAAILLDOKI, [Optional] BHKJOMFLGCK? MDNNOLJAEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x77DFA40", Offset = "0x77DE440", VA = "0x1877DFA40", Slot = "9")]
	[AsyncStateMachine(typeof(CJNFNINOFNG))]
	public Task NOMGLNEKEKG([Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x77DF810", Offset = "0x77DE210", VA = "0x1877DF810", Slot = "10")]
	public IReadOnlyCollection<MDCBAMNMOAI> KHMOJPIAHDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x77DFB30", Offset = "0x77DE530", VA = "0x1877DFB30")]
	internal void NOPLEPMFHPK(MDCBAMNMOAI GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x77DE5C0", Offset = "0x77DCFC0", VA = "0x1877DE5C0")]
	private KEJKLPFBMLN CEMBNKOBJBK()
	{
		return default(KEJKLPFBMLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77DFDC0", Offset = "0x77DE7C0", VA = "0x1877DFDC0")]
	private KEJKLPFBMLN PBMJIBBMBOP()
	{
		return default(KEJKLPFBMLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x77DEA70", Offset = "0x77DD470", VA = "0x1877DEA70")]
	internal void HBAIFKLONLJ(MDCBAMNMOAI GNAAILLDOKI, BHKJOMFLGCK DHCPHEEFOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77DE5F0", Offset = "0x77DCFF0", VA = "0x1877DE5F0")]
	private static void DLFHIAFPPAK(List<TaskCompletionSource<FMCNELHDOJA>> CNKKCAKCDGK, FMCNELHDOJA KBPPNEBBAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77DEE60", Offset = "0x77DD860", VA = "0x1877DEE60")]
	private void IODGBKAJMDL(float IPJHHDLFJJO, Func<KEJKLPFBMLN> IMFLEOGOMIJ, FMCNELHDOJA NPDMDBGDBOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x77DE6A0", Offset = "0x77DD0A0", VA = "0x1877DE6A0")]
	private static bool DOEPJLEIDGP(float KEEADJCBJCP, float LKKBJAKGIGL, float LLAHHPGPOPL = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77DED10", Offset = "0x77DD710", VA = "0x1877DED10")]
	[AsyncStateMachine(typeof(KGNDIHAIMCJ))]
	private Task ICFODAJCGOA(FDAAGJMCIGM LDOHPADAGAO, float IPJHHDLFJJO, Func<KEJKLPFBMLN> GGEHJHJAOPK, CancellationToken ONNGMLHMNPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77DF860", Offset = "0x77DE260", VA = "0x1877DF860")]
	private void MKMONHIABNC(float HJDCKBFOAPK, int BBOJCODAIDP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x77DEC20", Offset = "0x77DD620", VA = "0x1877DEC20")]
	[AsyncStateMachine(typeof(MMAKKEAMLGM))]
	internal Task HMDMBPNDLON([Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77DFCC0", Offset = "0x77DE6C0", VA = "0x1877DFCC0")]
	[AsyncStateMachine(typeof(PEFPFCNLNIG))]
	private static Task OPFBEHGJEOE(ICollection<TaskCompletionSource<FMCNELHDOJA>> CNKKCAKCDGK, CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77DE720", Offset = "0x77DD120", VA = "0x1877DE720", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class IFCADLNHMBH : GHJBLFPCPMC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct DPNKACFHNGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public IFCADLNHMBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x77DE1D0", Offset = "0x77DCBD0", VA = "0x1877DE1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x77DE450", Offset = "0x77DCE50", VA = "0x1877DE450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly string GKMCGBJNOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly DLHGENCNAGI LBHAOALJIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly GLJPHHDMION HONHKIBBAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly MDCBAMNMOAI GNAAILLDOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool AGGPBOPKIOC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x77E08E0", Offset = "0x77DF2E0", VA = "0x1877E08E0")]
	internal IFCADLNHMBH(GLJPHHDMION HONHKIBBAAE, MDCBAMNMOAI GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x77E0770", Offset = "0x77DF170", VA = "0x1877E0770", Slot = "4")]
	[AsyncStateMachine(typeof(DPNKACFHNGH))]
	public Task HAPAMCDOBPE([Optional] CancellationToken BJEPDCCBCHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x77E05C0", Offset = "0x77DEFC0", VA = "0x1877E05C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal readonly struct KEJKLPFBMLN : IEquatable<KEJKLPFBMLN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly bool PKICCLCPDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly float MDBCGOLBJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly float EFBFOFMFMCH;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x77E0BF0", Offset = "0x77DF5F0", VA = "0x1877E0BF0")]
	public KEJKLPFBMLN(float MKFACFIMEHL, float JHEFBFGKIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x77E09E0", Offset = "0x77DF3E0", VA = "0x1877E09E0", Slot = "4")]
	public bool Equals(KEJKLPFBMLN OLKLGHOAKNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x77E0A20", Offset = "0x77DF420", VA = "0x1877E0A20", Slot = "0")]
	public override bool Equals(object? OIIGDBLKEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x77E0AD0", Offset = "0x77DF4D0", VA = "0x1877E0AD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x77E0B50", Offset = "0x77DF550", VA = "0x1877E0B50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class KFDNHOFMJGF
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum GGBJOGHNLBG : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly GGBJOGHNLBG LEAIPNLPKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<object, KEJKLPFBMLN> KLEBLNPFDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly KEJKLPFBMLN NGMFLLCFKCG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KEJKLPFBMLN ABKPALEDJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC96530", Offset = "0xC94F30", VA = "0x180C96530")]
		[CompilerGenerated]
		get
		{
			return default(KEJKLPFBMLN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC96670", Offset = "0xC95070", VA = "0x180C96670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x77E1160", Offset = "0x77DFB60", VA = "0x1877E1160")]
	public KFDNHOFMJGF(GGBJOGHNLBG LEAIPNLPKLA, KEJKLPFBMLN NGMFLLCFKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x77E0DD0", Offset = "0x77DF7D0", VA = "0x1877E0DD0")]
	public void LOPIDCKMNGD(object GNAAILLDOKI, KEJKLPFBMLN DDLOMOOOEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x77E0CC0", Offset = "0x77DF6C0", VA = "0x1877E0CC0")]
	public void CBCJJMKDJJC(object GNAAILLDOKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x77E1110", Offset = "0x77DFB10", VA = "0x1877E1110")]
	public void OPINELCICKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x77E0D30", Offset = "0x77DF730", VA = "0x1877E0D30")]
	private void EHENGHOGPKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x77E1090", Offset = "0x77DFA90", VA = "0x1877E1090")]
	private KEJKLPFBMLN OBCMDMMOAAK()
	{
		return default(KEJKLPFBMLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x77E10D0", Offset = "0x77DFAD0", VA = "0x1877E10D0")]
	private KEJKLPFBMLN OMONADIJDEJ()
	{
		return default(KEJKLPFBMLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x77E0EF0", Offset = "0x77DF8F0", VA = "0x1877E0EF0")]
	private KEJKLPFBMLN NPLLKKICINO(int DMKHGCCHMED)
	{
		return default(KEJKLPFBMLN);
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
