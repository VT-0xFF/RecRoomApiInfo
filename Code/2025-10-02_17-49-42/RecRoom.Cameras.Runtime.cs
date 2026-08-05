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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83B5DA0", Offset = "0x83B47A0", VA = "0x1883B5DA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
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
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83B5820", Offset = "0x83B4220", VA = "0x1883B5820", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LDDMKMABCFO]
public class PNCJPCCOJJG : JHNBKOHMNNF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal enum OGHDBDCIGDB
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
	private class IHMMJCMDHFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public OGHDBDCIGDB KGPPMPHHPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int PCCAJJBOMCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationTokenSource OHFCLCGHNMB;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE520", Offset = "0x7FFCF20", VA = "0x187FFE520")]
		public IHMMJCMDHFO(OGHDBDCIGDB KGPPMPHHPML, int PCCAJJBOMCL, CancellationTokenSource OHFCLCGHNMB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct IKDIAHBJLLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public PNCJPCCOJJG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x83B4AC0", Offset = "0x83B34C0", VA = "0x1883B4AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83B4F00", Offset = "0x83B3900", VA = "0x1883B4F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class DHNNPAGEDAK
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
			public DHNNPAGEDAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private List<TaskCompletionSource<OGHDBDCIGDB>> <awaitersToNotify>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x83B81F0", Offset = "0x83B6BF0", VA = "0x1883B81F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x83B8720", Offset = "0x83B7120", VA = "0x1883B8720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PNCJPCCOJJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IHMMJCMDHFO transitionTaskState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public OGHDBDCIGDB transitionType;

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
		public OGHDBDCIGDB completionState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public CancellationToken systemDisposalToken;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DHNNPAGEDAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83B3180", Offset = "0x83B1B80", VA = "0x1883B3180")]
		[AsyncStateMachine(typeof(<<RunTransitionAsync>g__CleanupStateAndNotifyWaiters|0>d))]
		internal Task CMBGNHGDHKM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct GOIPGNGADBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public PNCJPCCOJJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IHMMJCMDHFO transitionTaskState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken systemDisposalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Func<GLKMJAFGMNH> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private DHNNPAGEDAK <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x83B3960", Offset = "0x83B2360", VA = "0x1883B3960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83B4A60", Offset = "0x83B3460", VA = "0x1883B4A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct NJBMMHOJLKF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public PNCJPCCOJJG <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x83B5900", Offset = "0x83B4300", VA = "0x1883B5900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83B5D40", Offset = "0x83B4740", VA = "0x1883B5D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NHBDHCKAFJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public TaskCompletionSource<OGHDBDCIGDB> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NHBDHCKAFJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83B58B0", Offset = "0x83B42B0", VA = "0x1883B58B0")]
		internal void HKOILFCJAFD()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IPFOIKIMBEP : IAsyncStateMachine
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
		public ICollection<TaskCompletionSource<OGHDBDCIGDB>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private NHBDHCKAFJK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<OGHDBDCIGDB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83B4F60", Offset = "0x83B3960", VA = "0x1883B4F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x83B57C0", Offset = "0x83B41C0", VA = "0x1883B57C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GIBONNGCELP HKCLIJAIAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly IPCIDKEPBGK NDAIGEDAALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JLFIJNDEFBP OPGACPAKDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KNPAKHMHOAC DLMHDNHEOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NJDDFNKNKDL HKJAJPPLJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Func<Task> OJAEGODIDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly AJOFHDJLHFC GBNNGAJAANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly AJOFHDJLHFC EBGGGDJLFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource GMGIFPKDCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationToken KIHOIGMAJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly NPGIIPPFGLB<OMCJCLBFMAA> ALNBANCENNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object PPMFAAMKMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly object OKLGKGDBGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<OGHDBDCIGDB>> IOLLJLCMGJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<TaskCompletionSource<OGHDBDCIGDB>> JKHMHIAKBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<IHMMJCMDHFO> LJEBAIBHGGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int BKNPJALKDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private OGHDBDCIGDB JIAAEOHLMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal bool LPGNFCGNGPM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool COAJFLNLPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83B7890", Offset = "0x83B6290", VA = "0x1883B7890", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool MPPEOPFFOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83B70C0", Offset = "0x83B5AC0", VA = "0x1883B70C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KFAAPDGLIJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83B6450", Offset = "0x83B4E50", VA = "0x1883B6450", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float AGENNLIPKGO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDA71D0", Offset = "0xDA5BD0", VA = "0x180DA71D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xE217B0", Offset = "0xE201B0", VA = "0x180E217B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private OGHDBDCIGDB HMKHMFFLILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF68C80", Offset = "0xF67680", VA = "0x180F68C80")]
		get
		{
			return default(OGHDBDCIGDB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83B6910", Offset = "0x83B5310", VA = "0x1883B6910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool ILCEBJOBLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83B6790", Offset = "0x83B5190", VA = "0x1883B6790", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x83B7030", Offset = "0x83B5A30", VA = "0x1883B7030")]
	private OGHDBDCIGDB IPFKFGPKEBI(OGHDBDCIGDB IMNBLKDCAKA)
	{
		return default(OGHDBDCIGDB);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x83B6100", Offset = "0x83B4B00", VA = "0x1883B6100")]
	private void AFEGOGNLLFG(IHMMJCMDHFO GKEFKGMEBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x83B64B0", Offset = "0x83B4EB0", VA = "0x1883B64B0")]
	private void ECDLGLLGPAE(IHMMJCMDHFO GKEFKGMEBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x83B6320", Offset = "0x83B4D20", VA = "0x1883B6320")]
	private void CHLBGMGJLPN(OGHDBDCIGDB KGPPMPHHPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x83B6460", Offset = "0x83B4E60", VA = "0x1883B6460")]
	private int DIAOODMPGJB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x83B81A0", Offset = "0x83B6BA0", VA = "0x1883B81A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PNCJPCCOJJG([BMCONCJPCIA(null)] GIBONNGCELP HKCLIJAIAPM, [BMCONCJPCIA(null)] IPCIDKEPBGK NDAIGEDAALB, [BMCONCJPCIA(null)] JLFIJNDEFBP OPGACPAKDDP, [BMCONCJPCIA("CameraFadeTimeoutDetector")] KNPAKHMHOAC DLMHDNHEOOD, [BMCONCJPCIA(null)] NJDDFNKNKDL HKJAJPPLJAG, [BMCONCJPCIA(null)] BADJDEJKIIJ<CameraFadeOptions> ALFCEIKBPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x83B7A90", Offset = "0x83B6490", VA = "0x1883B7A90")]
	internal PNCJPCCOJJG(GIBONNGCELP HKCLIJAIAPM, IPCIDKEPBGK NDAIGEDAALB, JLFIJNDEFBP OPGACPAKDDP, KNPAKHMHOAC DLMHDNHEOOD, NJDDFNKNKDL HKJAJPPLJAG, BADJDEJKIIJ<CameraFadeOptions> ALFCEIKBPNG, Func<Task>? OJAEGODIDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x83B7220", Offset = "0x83B5C20", VA = "0x1883B7220", Slot = "8")]
	public IBFOPPEEJNA OFAOKJEFJCB(OMCJCLBFMAA MFKHKDDANII, [Optional] DGAGDIFOCGB? JHKBJHDECNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x83B61B0", Offset = "0x83B4BB0", VA = "0x1883B61B0", Slot = "9")]
	[AsyncStateMachine(typeof(IKDIAHBJLLG))]
	public Task AJMMDPJMFGH([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x83B6A20", Offset = "0x83B5420", VA = "0x1883B6A20", Slot = "10")]
	public IReadOnlyCollection<OMCJCLBFMAA> HHPAGHKOPGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x83B6610", Offset = "0x83B5010", VA = "0x1883B6610")]
	internal void EPBLEMLBFIL(OMCJCLBFMAA MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x83B7100", Offset = "0x83B5B00", VA = "0x1883B7100")]
	private GLKMJAFGMNH NFNJBGCMNBA()
	{
		return default(GLKMJAFGMNH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x83B70D0", Offset = "0x83B5AD0", VA = "0x1883B70D0")]
	private GLKMJAFGMNH NENEHNLGIDI()
	{
		return default(GLKMJAFGMNH);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x83B6B70", Offset = "0x83B5570", VA = "0x1883B6B70")]
	internal void IFKNMFFPADG(OMCJCLBFMAA MFKHKDDANII, DGAGDIFOCGB FJHGAMNBBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83B6860", Offset = "0x83B5260", VA = "0x1883B6860")]
	private static void GKIBFKGBHND(List<TaskCompletionSource<OGHDBDCIGDB>> CLNJIEELJIN, OGHDBDCIGDB LHHPKBEMCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x83B6D20", Offset = "0x83B5720", VA = "0x1883B6D20")]
	private void IHBDCFOANAF(float CJGCGHGFFAD, Func<GLKMJAFGMNH> GDAJLCIKEEC, OGHDBDCIGDB JKHOFOPCKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x83B62A0", Offset = "0x83B4CA0", VA = "0x1883B62A0")]
	private static bool BKFALIGOKDL(float EICJFDNFOCB, float MIBIEOGGIAP, float OAGMLPDHICP = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x83B78B0", Offset = "0x83B62B0", VA = "0x1883B78B0")]
	[AsyncStateMachine(typeof(GOIPGNGADBL))]
	private Task PJKHEDGEKPK(IHMMJCMDHFO INDEIDNPGIB, float CJGCGHGFFAD, Func<GLKMJAFGMNH> ADEOOLEJGBM, CancellationToken KBPKOKAHNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x83B6510", Offset = "0x83B4F10", VA = "0x1883B6510")]
	private void EFKAOJPKLEI(float JLCOMPMBADN, int PCCAJJBOMCL = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x83B7130", Offset = "0x83B5B30", VA = "0x1883B7130")]
	[AsyncStateMachine(typeof(NJBMMHOJLKF))]
	internal Task NFPEABIEFAN([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x83B6A70", Offset = "0x83B5470", VA = "0x1883B6A70")]
	[AsyncStateMachine(typeof(IPFOIKIMBEP))]
	private static Task HLPKAHHBADG(ICollection<TaskCompletionSource<OGHDBDCIGDB>> CLNJIEELJIN, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x83B6470", Offset = "0x83B4E70", VA = "0x1883B6470", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class FAPFFGKJGBG : IBFOPPEEJNA, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ODNJBMKJIBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FAPFFGKJGBG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83B5E20", Offset = "0x83B4820", VA = "0x1883B5E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83B60A0", Offset = "0x83B4AA0", VA = "0x1883B60A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly string LFJCEAIDJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly HHIPOMEIBHM GKHJAILEPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly PNCJPCCOJJG CCJBPALLILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly OMCJCLBFMAA MFKHKDDANII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool ICPNMNBNLKA;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x83B3580", Offset = "0x83B1F80", VA = "0x1883B3580")]
	internal FAPFFGKJGBG(PNCJPCCOJJG CCJBPALLILA, OMCJCLBFMAA MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83B3400", Offset = "0x83B1E00", VA = "0x1883B3400", Slot = "4")]
	[AsyncStateMachine(typeof(ODNJBMKJIBE))]
	public Task HPHKLCPMHCL([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83B3250", Offset = "0x83B1C50", VA = "0x1883B3250", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal readonly struct GLKMJAFGMNH : IEquatable<GLKMJAFGMNH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly bool JIECLIBKJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly float CKGGPGGCLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly float COCCBGKGPJI;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83B3890", Offset = "0x83B2290", VA = "0x1883B3890")]
	public GLKMJAFGMNH(float GJKGFNFKKHF, float NDKGEJPCLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83B3730", Offset = "0x83B2130", VA = "0x1883B3730", Slot = "4")]
	public bool Equals(GLKMJAFGMNH GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x83B3680", Offset = "0x83B2080", VA = "0x1883B3680", Slot = "0")]
	public override bool Equals(object? PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x83B3770", Offset = "0x83B2170", VA = "0x1883B3770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x83B37F0", Offset = "0x83B21F0", VA = "0x1883B37F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class AJOFHDJLHFC
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum NCCMPPGLHNO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NCCMPPGLHNO LBIENJJLHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<object, GLKMJAFGMNH> AFADJHPBJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly GLKMJAFGMNH GLKDANAFKPP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GLKMJAFGMNH AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xEC2660", Offset = "0xEC1060", VA = "0x180EC2660")]
		[CompilerGenerated]
		get
		{
			return default(GLKMJAFGMNH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xEC27A0", Offset = "0xEC11A0", VA = "0x180EC27A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x83B30C0", Offset = "0x83B1AC0", VA = "0x1883B30C0")]
	public AJOFHDJLHFC(NCCMPPGLHNO LBIENJJLHJD, GLKMJAFGMNH GLKDANAFKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x83B2F60", Offset = "0x83B1960", VA = "0x1883B2F60")]
	public void MFIGMNCEEFG(object MFKHKDDANII, GLKMJAFGMNH DPCKNGEAKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x83B2EF0", Offset = "0x83B18F0", VA = "0x1883B2EF0")]
	public void MCKODPOBNPM(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x83B2C20", Offset = "0x83B1620", VA = "0x1883B2C20")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83B2E50", Offset = "0x83B1850", VA = "0x1883B2E50")]
	private void LJPOLIIPBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83B3080", Offset = "0x83B1A80", VA = "0x1883B3080")]
	private GLKMJAFGMNH PPMIPCBHEEM()
	{
		return default(GLKMJAFGMNH);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x83B2E10", Offset = "0x83B1810", VA = "0x1883B2E10")]
	private GLKMJAFGMNH KNPEEAGBOIE()
	{
		return default(GLKMJAFGMNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x83B2C70", Offset = "0x83B1670", VA = "0x1883B2C70")]
	private GLKMJAFGMNH GOCILBLLFMD(int FNEGEJGHGII)
	{
		return default(GLKMJAFGMNH);
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
