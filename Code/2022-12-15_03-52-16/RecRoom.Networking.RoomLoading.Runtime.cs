using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using JetBrains.Annotations;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal class ABDAALIJIGF : global::LJJKDOGPGLE<ACIJGDJCAMO>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class ABFJLACCFEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public ABFJLACCFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5D63560", Offset = "0x5D61F60", VA = "0x185D63560")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] FNPGGNGPGLB;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly ABDAALIJIGF LOGBPMLPMIM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D62D40", Offset = "0x5D61740", VA = "0x185D62D40", Slot = "5")]
	protected override void IHONEGDEJKI(ACIJGDJCAMO DIDMFBHHIEC, IDictionary<object, object> JIHCLPECHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D621E0", Offset = "0x5D60BE0", VA = "0x185D621E0", Slot = "6")]
	public override ACIJGDJCAMO FFFJLEEKFAK(IDictionary<object, object> JIHCLPECHIB)
	{
		return default(ACIJGDJCAMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D633D0", Offset = "0x5D61DD0", VA = "0x185D633D0")]
	public ABDAALIJIGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class KOANDAEHODA
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string PJEAADOCOIM([NotNull] byte[] GOMBJHKPMMM);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct FPMHAOACIJN<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly IFEHKAEEIFG PEBAGHHPEBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool HILADLBJMLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T PFJNJLLDGHO;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x325FB70", Offset = "0x325E570", VA = "0x18325FB70")]
		public static FPMHAOACIJN<T> OBKBLKAKLHN(ACIJGDJCAMO ELLLPJKBNNO, Func<byte[], T> JNCBKLEEJKJ)
		{
			return default(FPMHAOACIJN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x325FF20", Offset = "0x325E920", VA = "0x18325FF20")]
		public FPMHAOACIJN(IFEHKAEEIFG BHMPEHCGJFO, T GOMBJHKPMMM, bool AIDKONEFHMC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x325FDF0", Offset = "0x325E7F0", VA = "0x18325FDF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NPBGDJEOABP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BFJGBKGIAEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<ACIJGDJCAMO> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public NPBGDJEOABP <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public BFJGBKGIAEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5D640C0", Offset = "0x5D62AC0", VA = "0x185D640C0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5D64110", Offset = "0x5D62B10", VA = "0x185D64110")]
			internal EFIFDIKBDFH <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class LNHGDMNCOLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public DPFDMHPCAKL.AFAHGOCKAKJ itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public LNHGDMNCOLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5D6BF60", Offset = "0x5D6A960", VA = "0x185D6BF60")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct DCINKBILPCL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<ACIJGDJCAMO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public NPBGDJEOABP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private BFJGBKGIAEG <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<ACIJGDJCAMO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5D64950", Offset = "0x5D63350", VA = "0x185D64950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5D65160", Offset = "0x5D63B60", VA = "0x185D65160", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class DBEDDLANIBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public HABJHBNLKPP sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
			public DBEDDLANIBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5D64770", Offset = "0x5D63170", VA = "0x185D64770")]
			internal bool <ClearSlice>b__0(ACIJGDJCAMO bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly AHHKAFEBAHA BPNCMNGDNEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string NHJJGEPNCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<ACIJGDJCAMO> IBIBMLAGIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(DPFDMHPCAKL.AFAHGOCKAKJ itemType, long totalStopwatchTicks)> DIJLBJHLHIN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool CDKPHPHGECN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5D6D180", Offset = "0x5D6BB80", VA = "0x185D6D180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<ACIJGDJCAMO> KJAGKCCBKCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5D6D0E0", Offset = "0x5D6BAE0", VA = "0x185D6D0E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5D6D4A0", Offset = "0x5D6BEA0", VA = "0x185D6D4A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D5F0", Offset = "0x5D6BFF0", VA = "0x185D6D5F0")]
		public NPBGDJEOABP(AHHKAFEBAHA BPNCMNGDNEF, string NHJJGEPNCIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D350", Offset = "0x5D6BD50", VA = "0x185D6D350")]
		[AsyncStateMachine(typeof(DCINKBILPCL))]
		public Task<ACIJGDJCAMO> HJIPIHFJEAI(CancellationToken JLIEBAENBAG, TimeSpan DKOGNBKHEEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D540", Offset = "0x5D6BF40", VA = "0x185D6D540")]
		public void POONOBALAEC(ACIJGDJCAMO DIDMFBHHIEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D1D0", Offset = "0x5D6BBD0", VA = "0x185D6D1D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D220", Offset = "0x5D6BC20", VA = "0x185D6D220")]
		public void GCFLILLAEHL(HABJHBNLKPP JCBAHBFNBHI, Guid CBBOJGIJLHN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OBGNAAJENAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<ACIJGDJCAMO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public GMCFJEBBKEC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public KOANDAEHODA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GMCFJEBBKEC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<ACIJGDJCAMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D860", Offset = "0x5D6C260", VA = "0x185D6D860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E180", Offset = "0x5D6CB80", VA = "0x185D6E180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct MBDMNNLPHDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public KOANDAEHODA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GMCFJEBBKEC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GMCFJEBBKEC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<FPMHAOACIJN<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C030", Offset = "0x5D6AA30", VA = "0x185D6C030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C3E0", Offset = "0x5D6ADE0", VA = "0x185D6C3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NNBCDDJDHLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<ACIJGDJCAMO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public KOANDAEHODA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public GMCFJEBBKEC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public GMCFJEBBKEC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private Stopwatch <sw>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <frameStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private TaskAwaiter<ACIJGDJCAMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C790", Offset = "0x5D6B190", VA = "0x185D6C790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5D6D090", Offset = "0x5D6BA90", VA = "0x185D6D090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class NPHAKOMBHHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public KOANDAEHODA <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public NPHAKOMBHHF()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HLEKBNLLLDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<ACIJGDJCAMO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public KOANDAEHODA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private NPHAKOMBHHF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public GMCFJEBBKEC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public GMCFJEBBKEC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private KHJMDKOCBNC <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<ACIJGDJCAMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5D65810", Offset = "0x5D64210", VA = "0x185D65810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5D662B0", Offset = "0x5D64CB0", VA = "0x185D662B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OCPJEHDOLJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<ACIJGDJCAMO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public KOANDAEHODA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public GMCFJEBBKEC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public GMCFJEBBKEC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<ACIJGDJCAMO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E1D0", Offset = "0x5D6CBD0", VA = "0x185D6E1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E5B0", Offset = "0x5D6CFB0", VA = "0x185D6E5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DHCMAPBCNDF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public DHCMAPBCNDF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5D6EB70", Offset = "0x5D6D570", VA = "0x185D6EB70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5D6ECE0", Offset = "0x5D6D6E0", VA = "0x185D6ECE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public DHCMAPBCNDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5D651B0", Offset = "0x5D63BB0", VA = "0x185D651B0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct CJAPKCGPKIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public KOANDAEHODA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public GMCFJEBBKEC unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public GMCFJEBBKEC pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D64490", Offset = "0x5D62E90", VA = "0x185D64490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x67F320", Offset = "0x67DD20", VA = "0x18067F320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class MGPMALNCDBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public MGPMALNCDBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C5A0", Offset = "0x5D6AFA0", VA = "0x185D6C5A0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C550", Offset = "0x5D6AF50", VA = "0x185D6C550")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EANOAFNPEBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public HABJHBNLKPP sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public EANOAFNPEBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5D655D0", Offset = "0x5D63FD0", VA = "0x185D655D0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MDGOGHIKKAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public HABJHBNLKPP sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public MDGOGHIKKAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5D6C430", Offset = "0x5D6AE30", VA = "0x185D6C430")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LLHLEGEAJPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public LLHLEGEAJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5D6BEF0", Offset = "0x5D6A8F0", VA = "0x185D6BEF0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DCCDKGJBAPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public DCCDKGJBAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5D648E0", Offset = "0x5D632E0", VA = "0x185D648E0")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HIJAGEMANIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public HIJAGEMANIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5D65780", Offset = "0x5D64180", VA = "0x185D65780")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class GAHLJLFMDPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public GAHLJLFMDPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5D656F0", Offset = "0x5D640F0", VA = "0x185D656F0")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BAAPOIKGIMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Func<Guid, bool> matchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Func<Guid, bool> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Func<Guid, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public BAAPOIKGIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5D64060", Offset = "0x5D62A60", VA = "0x185D64060")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5D64000", Offset = "0x5D62A00", VA = "0x185D64000")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class CLGGKGDIACE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public CLGGKGDIACE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5D646D0", Offset = "0x5D630D0", VA = "0x185D646D0")]
		internal bool <ClearSliceIds>b__3(MKIGBFHDBDL stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PAGCEOCKJMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677530", VA = "0x180678B30")]
		public PAGCEOCKJMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E670", Offset = "0x5D6D070", VA = "0x185D6E670")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E8F0", Offset = "0x5D6D2F0", VA = "0x185D6E8F0")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5D6E600", Offset = "0x5D6D000", VA = "0x185D6E600")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly PJEAADOCOIM EKPIFHIFMOB;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable HDFCIJGMMLE;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly EDGFCDOLJKI AJIPNBALKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly NPBGDJEOABP GMICPCDJFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly AHHKAFEBAHA BPNCMNGDNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly PCGMNJPFOND KGHNFIILJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GPEHMGCIABO MFPPFKAHGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PJEAADOCOIM CPAMGMJMIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool GLPBIJFMILI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan MPKDCECCCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan GEJIFONJDEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte GBJEEFAOALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] KDHJPCBDFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<MKIGBFHDBDL> NGODPJJODGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private IFEHKAEEIFG? AEDEKIOMBAK;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly EDGFCDOLJKI KCDBHANOKEL;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly EDGFCDOLJKI PPCHCFMLIJJ;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<ACIJGDJCAMO> FFELKHOGJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B450", Offset = "0x5D69E50", VA = "0x185D6B450")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5D6B1F0", Offset = "0x5D69BF0", VA = "0x185D6B1F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5D6BA40", Offset = "0x5D6A440", VA = "0x185D6BA40")]
	public KOANDAEHODA(AHHKAFEBAHA BPNCMNGDNEF, PCGMNJPFOND KGHNFIILJPH, GPEHMGCIABO MFPPFKAHGEE, [Optional] TimeSpan? FMOGLDGMAHK, [Optional] PJEAADOCOIM AOFCGLOKMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x22A7D10", Offset = "0x22A6710", VA = "0x1822A7D10")]
	public static KOANDAEHODA DMHLLJAGJPA<TNetworking>(TNetworking IFOIKAOPFOA, [Optional] TimeSpan? FMOGLDGMAHK, [Optional] PJEAADOCOIM AOFCGLOKMME) where TNetworking : AHHKAFEBAHA, PCGMNJPFOND, GPEHMGCIABO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D68790", Offset = "0x5D67190", VA = "0x185D68790")]
	public void BOHBKACNFPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D696C0", Offset = "0x5D680C0", VA = "0x185D696C0")]
	private byte HDGBKIMFIPH()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D69480", Offset = "0x5D67E80", VA = "0x185D69480")]
	private TimeSpan HBMFFKKEPAM(TimeSpan? FMOGLDGMAHK, int GLFNHOAPPJL = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x22A8200", Offset = "0x22A6C00", VA = "0x1822A8200")]
	public bool IDEKMLABDJG<T>(T KBDNLNNBEPF, Func<T, byte[]> IOHHLKEMCKO, bool AIDKONEFHMC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D696D0", Offset = "0x5D680D0", VA = "0x185D696D0")]
	public bool IDEKMLABDJG(byte[] KBDNLNNBEPF, int LHDGFKFPAIE, bool AIDKONEFHMC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x774500", Offset = "0x772F00", VA = "0x180774500")]
	private static string DLMGPJACJGC(string DIDMFBHHIEC, string GCBELIJEOPF = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5D68D80", Offset = "0x5D67780", VA = "0x185D68D80")]
	[AsyncStateMachine(typeof(OBGNAAJENAE))]
	public Task<ACIJGDJCAMO> FFOIMJHNOFI(CancellationToken JLIEBAENBAG, [Optional] GMCFJEBBKEC CIKHJFIMNOG, [Optional] GMCFJEBBKEC AEGOGAOIAJP, [Optional] TimeSpan? FMOGLDGMAHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D68F00", Offset = "0x5D67900", VA = "0x185D68F00")]
	[AsyncStateMachine(typeof(MBDMNNLPHDH))]
	public Task<Guid> FJPPMFEOEPP(Guid KKNMEKNPDDJ, CancellationToken JLIEBAENBAG, [Optional] GMCFJEBBKEC CIKHJFIMNOG, [Optional] GMCFJEBBKEC AEGOGAOIAJP, [Optional] TimeSpan? DKOGNBKHEEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x22A7B50", Offset = "0x22A6550", VA = "0x1822A7B50")]
	[AsyncStateMachine(typeof(PMOGADGOICN))]
	public Task<FPMHAOACIJN<T>> DLJMBILLBFC<T>(T KBDNLNNBEPF, Func<T, byte[]> IOHHLKEMCKO, Func<byte[], T> JNCBKLEEJKJ, CancellationToken JLIEBAENBAG, [Optional] GMCFJEBBKEC CIKHJFIMNOG, [Optional] GMCFJEBBKEC AEGOGAOIAJP, [Optional] TimeSpan? DKOGNBKHEEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D68AE0", Offset = "0x5D674E0", VA = "0x185D68AE0")]
	[AsyncStateMachine(typeof(NNBCDDJDHLB))]
	public Task<ACIJGDJCAMO> DLJMBILLBFC(byte[] KBDNLNNBEPF, CancellationToken JLIEBAENBAG, [Optional] GMCFJEBBKEC CIKHJFIMNOG, [Optional] GMCFJEBBKEC AEGOGAOIAJP, [Optional] TimeSpan? DKOGNBKHEEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D67F40", Offset = "0x5D66940", VA = "0x185D67F40")]
	[AsyncStateMachine(typeof(HLEKBNLLLDJ))]
	private Task<ACIJGDJCAMO> BMONEBCEBDM(byte[] KBDNLNNBEPF, CancellationToken JLIEBAENBAG, GMCFJEBBKEC CIKHJFIMNOG, GMCFJEBBKEC AEGOGAOIAJP, TimeSpan? FMOGLDGMAHK, Stopwatch CHMEMLFHPGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A620", Offset = "0x5D69020", VA = "0x185D6A620")]
	[AsyncStateMachine(typeof(OCPJEHDOLJA))]
	private Task<ACIJGDJCAMO> KJBNMDLGJJJ(byte[] KBDNLNNBEPF, CancellationToken JLIEBAENBAG, [Optional] GMCFJEBBKEC CIKHJFIMNOG, [Optional] GMCFJEBBKEC AEGOGAOIAJP, [Optional] TimeSpan? DKOGNBKHEEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D68610", Offset = "0x5D67010", VA = "0x185D68610")]
	[AsyncStateMachine(typeof(CJAPKCGPKIK))]
	public Task BNHDHLELEAM(CancellationToken CGNPIKGMLAB, Func<CancellationToken, Task> AILJMABAGCL, [Optional] GMCFJEBBKEC CIKHJFIMNOG, [Optional] GMCFJEBBKEC AEGOGAOIAJP, int AEMMIGCCAPI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x22A74E0", Offset = "0x22A5EE0", VA = "0x1822A74E0")]
	[AsyncStateMachine(typeof(IEDOFJGPHPF))]
	public Task<T> BNHDHLELEAM<T>(CancellationToken CGNPIKGMLAB, Func<CancellationToken, Task<T>> AILJMABAGCL, [Optional] GMCFJEBBKEC CIKHJFIMNOG, [Optional] GMCFJEBBKEC AEGOGAOIAJP, int AEMMIGCCAPI = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x22A7DB0", Offset = "0x22A67B0", VA = "0x1822A7DB0")]
	[AsyncStateMachine(typeof(CMFHBGBPHOJ))]
	private Task<(bool, T)> EGGDNBOGOOM<T>(Guid BMFNECELJHI, CancellationToken CGNPIKGMLAB, Func<CancellationToken, Task<T>> AILJMABAGCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A860", Offset = "0x5D69260", VA = "0x185D6A860")]
	public void LCDAMPCLOND(byte OHKFJKCFKMH, int LIMGPBBOCJI, object FODDMJNLGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D68880", Offset = "0x5D67280", VA = "0x185D68880")]
	public Guid CCIPLAIPAJA(Guid DKEAFCJLHFH)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A0A0", Offset = "0x5D68AA0", VA = "0x185D6A0A0")]
	public bool JOBDEMGEGDC(HABJHBNLKPP JCBAHBFNBHI, Guid BMFNECELJHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D69CB0", Offset = "0x5D686B0", VA = "0x185D69CB0")]
	public void ILCGEHEKNEF(HABJHBNLKPP JCBAHBFNBHI, Guid BMFNECELJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D68780", Offset = "0x5D67180", VA = "0x185D68780")]
	private void BNLDMLKKIHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D68C70", Offset = "0x5D67670", VA = "0x185D68C70")]
	internal IFEHKAEEIFG EAFEHDBNKMM(bool EODDKIIALLM = false)
	{
		return default(IFEHKAEEIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B6C0", Offset = "0x5D6A0C0", VA = "0x185D6B6C0")]
	private HashSet<Guid> NHBADKOCNNB(HABJHBNLKPP JCBAHBFNBHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B290", Offset = "0x5D69C90", VA = "0x185D6B290")]
	private void LKHHMBHPBMG(HABJHBNLKPP JCBAHBFNBHI, Guid CBBOJGIJLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D69090", Offset = "0x5D67A90", VA = "0x185D69090")]
	private void FMIPMNPICKN(HABJHBNLKPP JCBAHBFNBHI, Guid CBBOJGIJLHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D6A7B0", Offset = "0x5D691B0", VA = "0x185D6A7B0")]
	public static Func<Guid, bool> KMNLOBPFPJE(Guid CBBOJGIJLHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B610", Offset = "0x5D6A010", VA = "0x185D6B610")]
	public static Func<Guid, bool> NDLAMKDIKHH(Guid CBBOJGIJLHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D69370", Offset = "0x5D67D70", VA = "0x185D69370")]
	public void GCFLILLAEHL(HABJHBNLKPP JCBAHBFNBHI, Guid KIEFNBLKNLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D680F0", Offset = "0x5D66AF0", VA = "0x185D680F0")]
	public void BNFOIJNEOGJ(HABJHBNLKPP JCBAHBFNBHI, Func<Guid, bool> JGCALFANHIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D6B4F0", Offset = "0x5D69EF0", VA = "0x185D6B4F0")]
	private static ExitGames.Client.Photon.Hashtable MIPIOGAPKNB(HABJHBNLKPP JCBAHBFNBHI, Guid ONPPHDODPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5D67810", Offset = "0x5D66210", VA = "0x185D67810")]
	private void BGFBFCGELLE(HABJHBNLKPP JCBAHBFNBHI, Guid ONPPHDODPBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class EFIFDIKBDFH : NHGIHPCFDAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(DPFDMHPCAKL.AFAHGOCKAKJ itemType, long totalStopwatchTicks)> JDGKJFECCIC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(DPFDMHPCAKL.AFAHGOCKAKJ itemType, long totalStopwatchTicks)> HGEGAKNDDDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x67DE20", Offset = "0x67C820", VA = "0x18067DE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D65670", Offset = "0x5D64070", VA = "0x185D65670")]
	public EFIFDIKBDFH(TimeSpan DKOGNBKHEEK, List<(DPFDMHPCAKL.AFAHGOCKAKJ itemType, long totalStopwatchTicks)> JDGKJFECCIC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class APFONCBMMOP : KHJMDKOCBNC
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct DKHGIDGLFOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid PCHCFOHKJPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int OHPCMMCOHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int LBEFPNFHLFM;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5D655C0", Offset = "0x5D63FC0", VA = "0x185D655C0")]
		public DKHGIDGLFOE(Guid NJPFMIPFJOD, int DFOBFGOMFPH, int OICEJJNKBJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5D654E0", Offset = "0x5D63EE0", VA = "0x185D654E0")]
		public static byte[] HGEKGOKJCDE(DKHGIDGLFOE DIDMFBHHIEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5D65420", Offset = "0x5D63E20", VA = "0x185D65420")]
		public static DKHGIDGLFOE FFFJLEEKFAK(byte[] PPJLGCLGPJE)
		{
			return default(DKHGIDGLFOE);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5D653A0", Offset = "0x5D63DA0", VA = "0x185D653A0")]
		private static byte[] EIGNGPEKGPI(int LJOFAPCHBHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5D652F0", Offset = "0x5D63CF0", VA = "0x185D652F0")]
		private static int AEBEOJMHCFC(byte[] BCLNEPAEFDC, int EBBLFLFCHFB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid NJPFMIPFJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly KOANDAEHODA EBFKOHPMINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool DFNPHGJFDIM;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D63FA0", Offset = "0x5D629A0", VA = "0x185D63FA0")]
	public APFONCBMMOP(Guid NJPFMIPFJOD, KOANDAEHODA EBFKOHPMINB, GPEHMGCIABO IFOIKAOPFOA, CancellationToken CGNPIKGMLAB, [Optional] MEENOGPMDNN FEIFCKNPHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D63A10", Offset = "0x5D62410", VA = "0x185D63A10", Slot = "5")]
	protected override void CFHIGKKENMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D63E00", Offset = "0x5D62800", VA = "0x185D63E00", Slot = "6")]
	protected override void OILEFIOLBIK(int AJNLHLNPCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D63BE0", Offset = "0x5D625E0", VA = "0x185D63BE0")]
	private void FFELKHOGJMC(ACIJGDJCAMO CAPENLNBAFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct ACIJGDJCAMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly IFEHKAEEIFG PEBAGHHPEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte OFNBKEHJDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte GBHFEEHLPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool HILADLBJMLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] PFJNJLLDGHO;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5D639B0", Offset = "0x5D623B0", VA = "0x185D639B0")]
	public ACIJGDJCAMO(IFEHKAEEIFG BHMPEHCGJFO, [CanBeNull] byte[] GOMBJHKPMMM, bool AIDKONEFHMC, byte IMEMFDJIHMO, byte NLKFJJCJGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5D63810", Offset = "0x5D62210", VA = "0x185D63810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5D63620", Offset = "0x5D62020", VA = "0x185D63620")]
	private static void BELJGOMHGDN(byte[] GOMBJHKPMMM, StringBuilder CCLNHPOEGCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct IFEHKAEEIFG
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class IJFHAOAALCN : IEnumerable<MKIGBFHDBDL>, IEnumerable, IEnumerator<MKIGBFHDBDL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private MKIGBFHDBDL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public IFEHKAEEIFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public IFEHKAEEIFG <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private HABJHBNLKPP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private MKIGBFHDBDL System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x323DE50", Offset = "0x323C850", VA = "0x18323DE50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MKIGBFHDBDL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5D67390", Offset = "0x5D65D90", VA = "0x185D67390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA97B60", Offset = "0xA96560", VA = "0x180A97B60")]
		[DebuggerHidden]
		public IJFHAOAALCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D670C0", Offset = "0x5D65AC0", VA = "0x185D670C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D67350", Offset = "0x5D65D50", VA = "0x185D67350", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5D672B0", Offset = "0x5D65CB0", VA = "0x185D672B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MKIGBFHDBDL> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5D672B0", Offset = "0x5D65CB0", VA = "0x185D672B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly HABJHBNLKPP GEJLPMPBLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] AHCKMGAFLFH;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5D66B80", Offset = "0x5D65580", VA = "0x185D66B80")]
	public static IFEHKAEEIFG GCMINJBFOMF(HABJHBNLKPP JCBAHBFNBHI, Guid EIDKEKGMALI)
	{
		return default(IFEHKAEEIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5D66300", Offset = "0x5D64D00", VA = "0x185D66300")]
	public static IFEHKAEEIFG APMMPOPPELF(List<MKIGBFHDBDL> ADFBNDAGOPO)
	{
		return default(IFEHKAEEIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5D66720", Offset = "0x5D65120", VA = "0x185D66720")]
	public static IFEHKAEEIFG EINACHFAHDF(HABJHBNLKPP KBEGAJLJFME, Guid[] FOFJELBEGKN)
	{
		return default(IFEHKAEEIFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5D66E80", Offset = "0x5D65880", VA = "0x185D66E80")]
	private IFEHKAEEIFG(HABJHBNLKPP KBEGAJLJFME, Guid[] FOFJELBEGKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5D66C80", Offset = "0x5D65680", VA = "0x185D66C80")]
	[IteratorStateMachine(typeof(IJFHAOAALCN))]
	public IEnumerable<MKIGBFHDBDL> JMPIKDDOIAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5D66D00", Offset = "0x5D65700", VA = "0x185D66D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class LJJKDOGPGLE<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x225B660", Offset = "0x225A060", VA = "0x18225B660", Slot = "4")]
	public void JPEBDENDJAC(T DIDMFBHHIEC, IDictionary<object, object> JIHCLPECHIB, bool MFPMBHHAPPF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void IHONEGDEJKI(T DIDMFBHHIEC, IDictionary<object, object> JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T FFFJLEEKFAK(IDictionary<object, object> JIHCLPECHIB);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x14A8F00", Offset = "0x14A7900", VA = "0x1814A8F00")]
	protected LJJKDOGPGLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KHJMDKOCBNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool MEENOGPMDNN(int IIJFCNNFGKJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool LNPMOHBLPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly GPEHMGCIABO OLBPIEBMOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken CGNPIKGMLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken DGJHOMCACMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly MEENOGPMDNN FEIFCKNPHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource IFDDHLNJDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource KGKNPLOMEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int GMNAINIOHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool EFJIBLEBJOO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken EPHFHOBKEGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D67530", Offset = "0x5D65F30", VA = "0x185D67530")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool OLGGCGPALJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D675F0", Offset = "0x5D65FF0", VA = "0x185D675F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D67660", Offset = "0x5D66060", VA = "0x185D67660")]
	public KHJMDKOCBNC(GPEHMGCIABO IFOIKAOPFOA, CancellationToken CGNPIKGMLAB, [Optional] MEENOGPMDNN FEIFCKNPHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D67510", Offset = "0x5D65F10", VA = "0x185D67510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D673E0", Offset = "0x5D65DE0", VA = "0x185D673E0", Slot = "5")]
	protected virtual void CFHIGKKENMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D67550", Offset = "0x5D65F50", VA = "0x185D67550")]
	private void GEADGMGMOHG(CHIAPKEENBB MMDPCAIEINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D674B0", Offset = "0x5D65EB0", VA = "0x185D674B0")]
	protected void COHHGLDNCMA(int AJNLHLNPCIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D67640", Offset = "0x5D66040", VA = "0x185D67640", Slot = "6")]
	protected virtual void OILEFIOLBIK(int AJNLHLNPCIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct MKIGBFHDBDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly HABJHBNLKPP NKJEJGHEJKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid EMMHFICCGPE;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x42F6C00", Offset = "0x42F5600", VA = "0x1842F6C00")]
	public MKIGBFHDBDL(HABJHBNLKPP JCBAHBFNBHI, Guid BMFNECELJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C730", Offset = "0x5D6B130", VA = "0x185D6C730")]
	public bool PEGCDPIHGIH(MKIGBFHDBDL OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C640", Offset = "0x5D6B040", VA = "0x185D6C640", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D6C700", Offset = "0x5D6B100", VA = "0x185D6C700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum HABJHBNLKPP : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Operation = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	RoomLoad = 2,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	MasterBlock = 4
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class ABDNKCBHNBL
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly HABJHBNLKPP[] INKBDMKHBFC;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D63410", Offset = "0x5D61E10", VA = "0x185D63410")]
	public static int PKNCAKHJHMA(HABJHBNLKPP JCBAHBFNBHI)
	{
		return default(int);
	}
}
namespace Cpp2IlInjected;

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
