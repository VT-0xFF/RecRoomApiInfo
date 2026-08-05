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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C1D910", Offset = "0x7C1C310", VA = "0x187C1D910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
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
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D760", Offset = "0x7C1C160", VA = "0x187C1D760", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NHPBPJDIEFG]
public class DBILLJHOIBN : ECDKCDAMMIP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal enum LGPBHFHPMFJ
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
	private class ECHKHLKHFFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public LGPBHFHPMFJ BEOCOCAAPIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int GNKKONPFECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationTokenSource LCAAPFCGOMH;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x78AF540", Offset = "0x78ADF40", VA = "0x1878AF540")]
		public ECHKHLKHFFB(LGPBHFHPMFJ BEOCOCAAPIG, int GNKKONPFECD, CancellationTokenSource LCAAPFCGOMH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct CFFAFFNALDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public DBILLJHOIBN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7C1A790", Offset = "0x7C19190", VA = "0x187C1A790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7C1ABD0", Offset = "0x7C195D0", VA = "0x187C1ABD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class MDJPFHKIBJE
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
			public MDJPFHKIBJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private List<TaskCompletionSource<LGPBHFHPMFJ>> <awaitersToNotify>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7C1E7A0", Offset = "0x7C1D1A0", VA = "0x187C1E7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7C1ECD0", Offset = "0x7C1D6D0", VA = "0x187C1ECD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public DBILLJHOIBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public ECHKHLKHFFB transitionTaskState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public LGPBHFHPMFJ transitionType;

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
		public LGPBHFHPMFJ completionState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public CancellationToken systemDisposalToken;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public MDJPFHKIBJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D7F0", Offset = "0x7C1C1F0", VA = "0x187C1D7F0")]
		[AsyncStateMachine(typeof(<<RunTransitionAsync>g__CleanupStateAndNotifyWaiters|0>d))]
		internal Task DLNHBFGIPIG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct ALJCFEMFKFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public DBILLJHOIBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ECHKHLKHFFB transitionTaskState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken systemDisposalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Func<KFHFBPMNGOI> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private MDJPFHKIBJE <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x7C19220", Offset = "0x7C17C20", VA = "0x187C19220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C1A310", Offset = "0x7C18D10", VA = "0x187C1A310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct CLJEBCPCLEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public DBILLJHOIBN <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7C1AC30", Offset = "0x7C19630", VA = "0x187C1AC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B070", Offset = "0x7C19A70", VA = "0x187C1B070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NPDKBCHOMJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public TaskCompletionSource<LGPBHFHPMFJ> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NPDKBCHOMJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D8C0", Offset = "0x7C1C2C0", VA = "0x187C1D8C0")]
		internal void LLPKMNCIJMI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PACIMCKFPAF : IAsyncStateMachine
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
		public ICollection<TaskCompletionSource<LGPBHFHPMFJ>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private NPDKBCHOMJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<LGPBHFHPMFJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D990", Offset = "0x7C1C390", VA = "0x187C1D990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1E1E0", Offset = "0x7C1CBE0", VA = "0x187C1E1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly COJJKFBGGKB PMPMPCJHKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IKKADOOMIAD OMKPHENOEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly AJFFMNJNEKC PODGOIBIEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JJPMOJNHOLC CCEMKGCMKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LJHAHDLAIDP DELPFODFBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HKFNDNNDPDP PGDCFDKJHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Func<Task> DNLGPMHKFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PLJGEAPNMFI OCEMFIMKGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly PLJGEAPNMFI PAIMLAGDJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource KIEHPKNBBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationToken PNMGHEENLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly PGCBMANNDHK<EPPGEGDDHJJ> OJHDOBCFLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object ONILLLBLPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly object JCMGDIFHOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<LGPBHFHPMFJ>> AIEMCPEBODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<TaskCompletionSource<LGPBHFHPMFJ>> MPGJJKIGIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<ECHKHLKHFFB> PJACHLDAFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int NKEFHBPEJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private LGPBHFHPMFJ LCAKMDAJNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal bool HLENGDEPEAD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GAIAFILCAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BA90", Offset = "0x7C1A490", VA = "0x187C1BA90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool JMEGHEHLMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BA80", Offset = "0x7C1A480", VA = "0x187C1BA80", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ADGOFBOMANM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BA40", Offset = "0x7C1A440", VA = "0x187C1BA40", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float KIBNKDAGJFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCA95B0", Offset = "0xCA7FB0", VA = "0x180CA95B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCF0BC0", Offset = "0xCEF5C0", VA = "0x180CF0BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private LGPBHFHPMFJ OCGBBKJAGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xE49110", Offset = "0xE47B10", VA = "0x180E49110")]
		get
		{
			return default(LGPBHFHPMFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C1C740", Offset = "0x7C1B140", VA = "0x187C1C740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool CNENLDKLLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C1B580", Offset = "0x7C19F80", VA = "0x187C1B580", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B300", Offset = "0x7C19D00", VA = "0x187C1B300")]
	private LGPBHFHPMFJ CCPPMGCMMHK(LGPBHFHPMFJ LOPOEJHIPKN)
	{
		return default(LGPBHFHPMFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B7B0", Offset = "0x7C1A1B0", VA = "0x187C1B7B0")]
	private void GEAPCPPDEHI(ECHKHLKHFFB BNCHAIOLPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C530", Offset = "0x7C1AF30", VA = "0x187C1C530")]
	private void KIMFGNEPLAB(ECHKHLKHFFB BNCHAIOLPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B860", Offset = "0x7C1A260", VA = "0x187C1B860")]
	private void GFKFGHLKGCM(LGPBHFHPMFJ BEOCOCAAPIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B150", Offset = "0x7C19B50", VA = "0x187C1B150")]
	private int BEMFOOMIOFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D150", Offset = "0x7C1BB50", VA = "0x187C1D150")]
	[RecRoom.NoEngine.Common.Preserve]
	public DBILLJHOIBN([CNHMBDDCGKB(null)] IKKADOOMIAD OMKPHENOEJM, [CNHMBDDCGKB(null)] AJFFMNJNEKC PODGOIBIEEE, [CNHMBDDCGKB(null)] JJPMOJNHOLC CCEMKGCMKEF, [CNHMBDDCGKB("CameraFadeTimeoutDetector")] LJHAHDLAIDP DELPFODFBCI, [CNHMBDDCGKB(null)] HKFNDNNDPDP PGDCFDKJHHG, [CNHMBDDCGKB(null)] DMAIMHDJNEK<CameraFadeOptions> LCCNAOLCHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C1CA50", Offset = "0x7C1B450", VA = "0x187C1CA50")]
	internal DBILLJHOIBN(IKKADOOMIAD OMKPHENOEJM, AJFFMNJNEKC PODGOIBIEEE, JJPMOJNHOLC CCEMKGCMKEF, LJHAHDLAIDP DELPFODFBCI, HKFNDNNDPDP PGDCFDKJHHG, DMAIMHDJNEK<CameraFadeOptions> LCCNAOLCHEE, Func<Task>? DNLGPMHKFEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BAB0", Offset = "0x7C1A4B0", VA = "0x187C1BAB0", Slot = "8")]
	public AOGCLKAMMAP ICPBIBDKDAM(EPPGEGDDHJJ BECBHDDLOHA, [Optional] JPHOADEFBGO? KMJEAKFKNCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B490", Offset = "0x7C19E90", VA = "0x187C1B490", Slot = "9")]
	[AsyncStateMachine(typeof(CFFAFFNALDC))]
	public Task DEGFABPGOHI([Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B2B0", Offset = "0x7C19CB0", VA = "0x187C1B2B0", Slot = "10")]
	public IReadOnlyCollection<EPPGEGDDHJJ> BNCHCEGCEMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C850", Offset = "0x7C1B250", VA = "0x187C1C850")]
	internal void POENGAPLCIG(EPPGEGDDHJJ BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1BA50", Offset = "0x7C1A450", VA = "0x187C1BA50")]
	private KFHFBPMNGOI HHEJGMHBINN()
	{
		return default(KFHFBPMNGOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B690", Offset = "0x7C1A090", VA = "0x187C1B690")]
	private KFHFBPMNGOI EGPDMKEBINE()
	{
		return default(KFHFBPMNGOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C590", Offset = "0x7C1AF90", VA = "0x187C1C590")]
	internal void LNIDMJOKKPH(EPPGEGDDHJJ BECBHDDLOHA, JPHOADEFBGO FABPCEPBDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B990", Offset = "0x7C1A390", VA = "0x187C1B990")]
	private static void GNCGNBNJFAH(List<TaskCompletionSource<LGPBHFHPMFJ>> IICJEIAONBA, LGPBHFHPMFJ HGJKJEBHFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C120", Offset = "0x7C1AB20", VA = "0x187C1C120")]
	private void JIJAPAONMAD(float GBBIBFCGOFC, Func<KFHFBPMNGOI> CNNNJCHENNF, LGPBHFHPMFJ AHPJMHDIEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B0D0", Offset = "0x7C19AD0", VA = "0x187C1B0D0")]
	private static bool AABKFKOONPF(float MJGADEGDMOP, float LJDEEJKPAEN, float BNCIEJPJNCL = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B160", Offset = "0x7C19B60", VA = "0x187C1B160")]
	[AsyncStateMachine(typeof(ALJCFEMFKFJ))]
	private Task BIFGNLECPGI(ECHKHLKHFFB HKJPJODINMB, float GBBIBFCGOFC, Func<KFHFBPMNGOI> NPEFEOCOIBH, CancellationToken AKAJNEMHGAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B390", Offset = "0x7C19D90", VA = "0x187C1B390")]
	private void CHOANDNEMEJ(float GHMMCPJNJPI, int GNKKONPFECD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B6C0", Offset = "0x7C1A0C0", VA = "0x187C1B6C0")]
	[AsyncStateMachine(typeof(CLJEBCPCLEJ))]
	internal Task EJCKEGOCIPN([Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C1C430", Offset = "0x7C1AE30", VA = "0x187C1C430")]
	[AsyncStateMachine(typeof(PACIMCKFPAF))]
	private static Task JMKOMLBINFO(ICollection<TaskCompletionSource<LGPBHFHPMFJ>> IICJEIAONBA, CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C1B650", Offset = "0x7C1A050", VA = "0x187C1B650", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class BFJOJHNPCJA : AOGCLKAMMAP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct FHIBPFOGEIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BFJOJHNPCJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D1A0", Offset = "0x7C1BBA0", VA = "0x187C1D1A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D420", Offset = "0x7C1BE20", VA = "0x187C1D420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly string NAHBHDEDBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly ONKIACMKPLC LPFHHOPFMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly DBILLJHOIBN CBDBIJBBDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly EPPGEGDDHJJ BECBHDDLOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool CDPHAALIFLC;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A690", Offset = "0x7C19090", VA = "0x187C1A690")]
	internal BFJOJHNPCJA(DBILLJHOIBN CBDBIJBBDNF, EPPGEGDDHJJ BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A520", Offset = "0x7C18F20", VA = "0x187C1A520", Slot = "4")]
	[AsyncStateMachine(typeof(FHIBPFOGEIP))]
	public Task HJLJDCBDGFE([Optional] CancellationToken JKPNCAGHEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1A370", Offset = "0x7C18D70", VA = "0x187C1A370", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal readonly struct KFHFBPMNGOI : IEquatable<KFHFBPMNGOI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly bool KFPPOGACLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly float APMKLCNOCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly float JAIBLBIDMPL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D690", Offset = "0x7C1C090", VA = "0x187C1D690")]
	public KFHFBPMNGOI(float HCKMEDPCBCG, float IDDLOIFGNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D480", Offset = "0x7C1BE80", VA = "0x187C1D480", Slot = "4")]
	public bool Equals(KFHFBPMNGOI NDNHELJMDCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D4C0", Offset = "0x7C1BEC0", VA = "0x187C1D4C0", Slot = "0")]
	public override bool Equals(object? OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D570", Offset = "0x7C1BF70", VA = "0x187C1D570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D5F0", Offset = "0x7C1BFF0", VA = "0x187C1D5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class PLJGEAPNMFI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum HOHHHOJPLEF : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HOHHHOJPLEF AOOIPFLPJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<object, KFHFBPMNGOI> JOGHMEKPCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly KFHFBPMNGOI BEKCFCPACEI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KFHFBPMNGOI AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDBC620", Offset = "0xDBB020", VA = "0x180DBC620")]
		[CompilerGenerated]
		get
		{
			return default(KFHFBPMNGOI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDBC760", Offset = "0xDBB160", VA = "0x180DBC760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E6E0", Offset = "0x7C1D0E0", VA = "0x187C1E6E0")]
	public PLJGEAPNMFI(HOHHHOJPLEF AOOIPFLPJFP, KFHFBPMNGOI BEKCFCPACEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E390", Offset = "0x7C1CD90", VA = "0x187C1E390")]
	public void FCGGCFBPIPA(object BECBHDDLOHA, KFHFBPMNGOI EHCOCMNJALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E280", Offset = "0x7C1CC80", VA = "0x187C1E280")]
	public void DAAFLACHELB(object BECBHDDLOHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E4B0", Offset = "0x7C1CEB0", VA = "0x187C1E4B0")]
	public void MPMJEFEEPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E2F0", Offset = "0x7C1CCF0", VA = "0x187C1E2F0")]
	private void DHLDGEONJBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E6A0", Offset = "0x7C1D0A0", VA = "0x187C1E6A0")]
	private KFHFBPMNGOI OLJBDPJKICO()
	{
		return default(KFHFBPMNGOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E240", Offset = "0x7C1CC40", VA = "0x187C1E240")]
	private KFHFBPMNGOI AOGGCJACDNJ()
	{
		return default(KFHFBPMNGOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E500", Offset = "0x7C1CF00", VA = "0x187C1E500")]
	private KFHFBPMNGOI OEDFFKOBGGK(int ICEKCPHCPEK)
	{
		return default(KFHFBPMNGOI);
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
