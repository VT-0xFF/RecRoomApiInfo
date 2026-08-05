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
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
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
		[Cpp2IlInjected.Address(RVA = "0x77ABFE0", Offset = "0x77AB3E0", VA = "0x1877ABFE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9D5490", Offset = "0x9D4890", VA = "0x1809D5490")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D54D0", Offset = "0x9D48D0", VA = "0x1809D54D0")]
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
	public class LogRegistrationIndex : BDONJGGEMII
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x77ABC20", Offset = "0x77AB020", VA = "0x1877ABC20", Slot = "4")]
		public override void GEAMIGHEOPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9D4820", Offset = "0x9D3C20", VA = "0x1809D4820")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[CBAKGNGODOD]
public class KFCIENKCPGC : OOEHFEBFNNO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal enum FDGDNHNNOMH
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
	private class IINCLCJCGHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FDGDNHNNOMH MAFNBFGJNHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int ILIBNMMBILB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationTokenSource NKPAICCCLOJ;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x74810E0", Offset = "0x74804E0", VA = "0x1874810E0")]
		public IINCLCJCGHO(FDGDNHNNOMH MAFNBFGJNHN, int ILIBNMMBILB, CancellationTokenSource NKPAICCCLOJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct HOPHGNFGEAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public KFCIENKCPGC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x77A9100", Offset = "0x77A8500", VA = "0x1877A9100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x77A9540", Offset = "0x77A8940", VA = "0x1877A9540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JEKNLFIGPAI
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
			public JEKNLFIGPAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private List<TaskCompletionSource<FDGDNHNNOMH>> <awaitersToNotify>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x77AC340", Offset = "0x77AB740", VA = "0x1877AC340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x77AC870", Offset = "0x77ABC70", VA = "0x1877AC870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public KFCIENKCPGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IINCLCJCGHO transitionTaskState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public FDGDNHNNOMH transitionType;

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
		public FDGDNHNNOMH completionState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public CancellationToken systemDisposalToken;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public JEKNLFIGPAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x77A9A40", Offset = "0x77A8E40", VA = "0x1877A9A40")]
		[AsyncStateMachine(typeof(<<RunTransitionAsync>g__CleanupStateAndNotifyWaiters|0>d))]
		internal Task PDGLJIMCAAA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct GCAHGEMNKGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public KFCIENKCPGC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IINCLCJCGHO transitionTaskState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken systemDisposalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Func<NMAJFFODBBJ> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private JEKNLFIGPAI <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x77A7FB0", Offset = "0x77A73B0", VA = "0x1877A7FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x77A90A0", Offset = "0x77A84A0", VA = "0x1877A90A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct ICDGKJOBPCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public KFCIENKCPGC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x77A95A0", Offset = "0x77A89A0", VA = "0x1877A95A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x77A99E0", Offset = "0x77A8DE0", VA = "0x1877A99E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NMDELAOMAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public TaskCompletionSource<FDGDNHNNOMH> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
		public NMDELAOMAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x77ABF90", Offset = "0x77AB390", VA = "0x1877ABF90")]
		internal void KOOMHAEPOEF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct BADOPPGLFIO : IAsyncStateMachine
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
		public ICollection<TaskCompletionSource<FDGDNHNNOMH>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private NMDELAOMAOO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<FDGDNHNNOMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77A6D80", Offset = "0x77A6180", VA = "0x1877A6D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x77A75D0", Offset = "0x77A69D0", VA = "0x1877A75D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly GBHBOJAPDOA DPDKJPMBJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NABFNGFJNFB PPBECPOOCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KNNMDBNCIAK JIPEIOAGDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NNOOHIAHMIG ENFLKMBLIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly DOFOAGGDJHP NPEBMNKPBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NLHJGDPBHNK IHPAONIPNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Func<Task> AHIOHCMIJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly CEPMGMJBKGI CAIDJBCFEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CEPMGMJBKGI CNBJNEEMMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource GDNOCPJDEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationToken MPKICAJAEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly DPCJKIAOFOP<CEGHMOMNMEC> CCJHOOAFGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object JCFEBLAPLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly object OLLFMIICHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<FDGDNHNNOMH>> PPHNMDFDPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<TaskCompletionSource<FDGDNHNNOMH>> IDNEDLLAPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<IINCLCJCGHO> JBHLJOONGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int FDFJJBPDKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private FDGDNHNNOMH JJCBPLPHMDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal bool DICBJEDCPGD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OJBLDOKPFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77A9E80", Offset = "0x77A9280", VA = "0x1877A9E80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GNFILGPIMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77A9BC0", Offset = "0x77A8FC0", VA = "0x1877A9BC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HAGIBLNBAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77A9BD0", Offset = "0x77A8FD0", VA = "0x1877A9BD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OPAHKAHPJEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB62380", Offset = "0xB61780", VA = "0x180B62380", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBC5750", Offset = "0xBC4B50", VA = "0x180BC5750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private FDGDNHNNOMH EHLHIBKKAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xD12CF0", Offset = "0xD120F0", VA = "0x180D12CF0")]
		get
		{
			return default(FDGDNHNNOMH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77AA600", Offset = "0x77A9A00", VA = "0x1877AA600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool ICJJEFKGKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77A9BE0", Offset = "0x77A8FE0", VA = "0x1877A9BE0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x77A9DB0", Offset = "0x77A91B0", VA = "0x1877A9DB0")]
	private FDGDNHNNOMH DOEJFJKIEGP(FDGDNHNNOMH DHJOIBPBMPI)
	{
		return default(FDGDNHNNOMH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x77A9CE0", Offset = "0x77A90E0", VA = "0x1877A9CE0")]
	private void DKLMAEBHNFI(IINCLCJCGHO AGJJMEGFCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x77AAA40", Offset = "0x77A9E40", VA = "0x1877AAA40")]
	private void INHNFGFDBHN(IINCLCJCGHO AGJJMEGFCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x77AB0D0", Offset = "0x77AA4D0", VA = "0x1877AB0D0")]
	private void MJAAKGHFFHG(FDGDNHNNOMH MAFNBFGJNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x77AAC70", Offset = "0x77AA070", VA = "0x1877AAC70")]
	private int KNFCLHBBHGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x77ABBD0", Offset = "0x77AAFD0", VA = "0x1877ABBD0")]
	[RecRoom.NoEngine.Common.Preserve]
	public KFCIENKCPGC([CMKKAFOAFJE(null)] NABFNGFJNFB PPBECPOOCEC, [CMKKAFOAFJE(null)] KNNMDBNCIAK JIPEIOAGDLL, [CMKKAFOAFJE(null)] NNOOHIAHMIG ENFLKMBLIJN, [CMKKAFOAFJE("CameraFadeTimeoutDetector")] DOFOAGGDJHP NPEBMNKPBOK, [CMKKAFOAFJE(null)] NLHJGDPBHNK IHPAONIPNJI, [CMKKAFOAFJE(null)] OAODAKEKPCL<CameraFadeOptions> FBCMGOKFCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x77AB4D0", Offset = "0x77AA8D0", VA = "0x1877AB4D0")]
	internal KFCIENKCPGC(NABFNGFJNFB PPBECPOOCEC, KNNMDBNCIAK JIPEIOAGDLL, NNOOHIAHMIG ENFLKMBLIJN, DOFOAGGDJHP NPEBMNKPBOK, NLHJGDPBHNK IHPAONIPNJI, OAODAKEKPCL<CameraFadeOptions> FBCMGOKFCPJ, Func<Task>? AHIOHCMIJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x77A9F90", Offset = "0x77A9390", VA = "0x1877A9F90", Slot = "8")]
	public PBHBHLLFPAM HICOEMPCIAN(CEGHMOMNMEC HHGPJKKLNIG, [Optional] LJPODHPCLNO? LHMCDJOODCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x77A9EA0", Offset = "0x77A92A0", VA = "0x1877A9EA0", Slot = "9")]
	[AsyncStateMachine(typeof(HOPHGNFGEAK))]
	public Task FHDFJDODHKE([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x77AAAA0", Offset = "0x77A9EA0", VA = "0x1877AAAA0", Slot = "10")]
	public IReadOnlyCollection<CEGHMOMNMEC> JHGDPPDHDAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x77AAF50", Offset = "0x77AA350", VA = "0x1877AAF50")]
	internal void LMJBDAEPLJH(CEGHMOMNMEC HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x77AAE30", Offset = "0x77AA230", VA = "0x1877AAE30")]
	private NMAJFFODBBJ LCFFOENLCNJ()
	{
		return default(NMAJFFODBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x77A9CB0", Offset = "0x77A90B0", VA = "0x1877A9CB0")]
	private NMAJFFODBBJ DGCIBCPLKLC()
	{
		return default(NMAJFFODBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x77AAC80", Offset = "0x77AA080", VA = "0x1877AAC80")]
	internal void LBKAMBHIPIE(CEGHMOMNMEC HHGPJKKLNIG, LJPODHPCLNO HINACHOEPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x77A9B10", Offset = "0x77A8F10", VA = "0x1877A9B10")]
	private static void ADABELOELDK(List<TaskCompletionSource<FDGDNHNNOMH>> CCLPPFLCMBN, FDGDNHNNOMH JMPIOLAAOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x77AA710", Offset = "0x77A9B10", VA = "0x1877AA710")]
	private void HNJOGBKBAOO(float IPMOKOHBHMA, Func<NMAJFFODBBJ> MOOIHFDMMNF, FDGDNHNNOMH JDIBNCIBLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x77AABF0", Offset = "0x77A9FF0", VA = "0x1877AABF0")]
	private static bool KIEMKPLAONH(float PCMHLCLONGN, float IAJJOLNCJOI, float KFOLEGMCNJG = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x77AB300", Offset = "0x77AA700", VA = "0x1877AB300")]
	[AsyncStateMachine(typeof(GCAHGEMNKGL))]
	private Task OADAOACEGJM(IINCLCJCGHO GHEOHGNGJGE, float IPMOKOHBHMA, Func<NMAJFFODBBJ> KMOJLMPDEGD, CancellationToken BLGOGNLPMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x77AAAF0", Offset = "0x77A9EF0", VA = "0x1877AAAF0")]
	private void KHCNHKCHDOA(float EPBHFHJLJKP, int ILIBNMMBILB = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x77AAE60", Offset = "0x77AA260", VA = "0x1877AAE60")]
	[AsyncStateMachine(typeof(ICDGKJOBPCA))]
	internal Task LCOOKCGKIOF([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x77AB200", Offset = "0x77AA600", VA = "0x1877AB200")]
	[AsyncStateMachine(typeof(BADOPPGLFIO))]
	private static Task NLHAAAACPCF(ICollection<TaskCompletionSource<FDGDNHNNOMH>> CCLPPFLCMBN, CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x77A9E40", Offset = "0x77A9240", VA = "0x1877A9E40", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class BNNNBDGFLID : PBHBHLLFPAM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PJEKIJOADBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BNNNBDGFLID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x77AC060", Offset = "0x77AB460", VA = "0x1877AC060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x77AC2E0", Offset = "0x77AB6E0", VA = "0x1877AC2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly string MHMHHBOBGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly MLHHDOMPAAM ACPIEGPJILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly KFCIENKCPGC LBNHFJAFLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly CEGHMOMNMEC HHGPJKKLNIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool ACJJLPFCEAB;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x77A7950", Offset = "0x77A6D50", VA = "0x1877A7950")]
	internal BNNNBDGFLID(KFCIENKCPGC LBNHFJAFLON, CEGHMOMNMEC HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x77A77E0", Offset = "0x77A6BE0", VA = "0x1877A77E0", Slot = "4")]
	[AsyncStateMachine(typeof(PJEKIJOADBI))]
	public Task LGCEPIHDJIE([Optional] CancellationToken LMNHDKIFBOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x77A7630", Offset = "0x77A6A30", VA = "0x1877A7630", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal readonly struct NMAJFFODBBJ : IEquatable<NMAJFFODBBJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly bool IEEFMNINENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly float PMGEOGCMMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly float EJFKKDHEIAF;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x77ABEC0", Offset = "0x77AB2C0", VA = "0x1877ABEC0")]
	public NMAJFFODBBJ(float PLPJCNOKCML, float HLOBKBPABIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x77ABCB0", Offset = "0x77AB0B0", VA = "0x1877ABCB0", Slot = "4")]
	public bool Equals(NMAJFFODBBJ KNCKFHOKGJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x77ABCF0", Offset = "0x77AB0F0", VA = "0x1877ABCF0", Slot = "0")]
	public override bool Equals(object? BLFGIKOAKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x77ABDA0", Offset = "0x77AB1A0", VA = "0x1877ABDA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x77ABE20", Offset = "0x77AB220", VA = "0x1877ABE20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class CEPMGMJBKGI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum CJIFIACBOBL : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly CJIFIACBOBL BOGELKFEDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<object, NMAJFFODBBJ> ADJALFIAHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NMAJFFODBBJ LFNGLINMJBJ;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NMAJFFODBBJ HDKOPKMNJCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC6E9E0", Offset = "0xC6DDE0", VA = "0x180C6E9E0")]
		[CompilerGenerated]
		get
		{
			return default(NMAJFFODBBJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC6EB20", Offset = "0xC6DF20", VA = "0x180C6EB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x77A7EF0", Offset = "0x77A72F0", VA = "0x1877A7EF0")]
	public CEPMGMJBKGI(CJIFIACBOBL BOGELKFEDKL, NMAJFFODBBJ LFNGLINMJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x77A7A50", Offset = "0x77A6E50", VA = "0x1877A7A50")]
	public void AAOLFIDMMMI(object HHGPJKKLNIG, NMAJFFODBBJ MIMMADBKDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x77A7CE0", Offset = "0x77A70E0", VA = "0x1877A7CE0")]
	public void JEBJOEBLLEI(object HHGPJKKLNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x77A7C10", Offset = "0x77A7010", VA = "0x1877A7C10")]
	public void CJEMNCEDADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x77A7B70", Offset = "0x77A6F70", VA = "0x1877A7B70")]
	private void AHKOGFBEFOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x77A7C60", Offset = "0x77A7060", VA = "0x1877A7C60")]
	private NMAJFFODBBJ DIGCMFDOMDP()
	{
		return default(NMAJFFODBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x77A7CA0", Offset = "0x77A70A0", VA = "0x1877A7CA0")]
	private NMAJFFODBBJ INCCGPODLNM()
	{
		return default(NMAJFFODBBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x77A7D50", Offset = "0x77A7150", VA = "0x1877A7D50")]
	private NMAJFFODBBJ LJJJEMFONPG(int OJFCFPLHDOH)
	{
		return default(NMAJFFODBBJ);
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
