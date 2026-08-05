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
internal class BLBKEBEFFKM : global::IKAKHFPKIEO<MHHMGLIINAL>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FEEGJIFMAPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public FEEGJIFMAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5C0EED0", Offset = "0x5C0D8D0", VA = "0x185C0EED0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] NHNAGPILALA;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly BLBKEBEFFKM BLPHKNHCNDJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5C0C5E0", Offset = "0x5C0AFE0", VA = "0x185C0C5E0", Slot = "5")]
	protected override void FBPPCBLHMNP(MHHMGLIINAL PJJGOJBLNDL, IDictionary<object, object> PJIINDGLAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5C0CA50", Offset = "0x5C0B450", VA = "0x185C0CA50", Slot = "6")]
	public override MHHMGLIINAL GKBAFEAOLLC(IDictionary<object, object> PJIINDGLAPJ)
	{
		return default(MHHMGLIINAL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D7D0", Offset = "0x5C0C1D0", VA = "0x185C0D7D0")]
	public BLBKEBEFFKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class FFDLPAMNALE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string EGNNPPEPFEN([NotNull] byte[] IKLIFLGKEBP);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct PJBKIOJKJHD<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly JCEJBEBHLIG BGPFHMFPAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool GLAPACPILLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T DIAPLDMNKLO;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2F5AF60", Offset = "0x2F59960", VA = "0x182F5AF60")]
		public static PJBKIOJKJHD<T> PBPNODBDLHJ(MHHMGLIINAL HJPJCFEBBPH, Func<byte[], T> DDKDOCOMGJN)
		{
			return default(PJBKIOJKJHD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2F5B210", Offset = "0x2F59C10", VA = "0x182F5B210")]
		public PJBKIOJKJHD(JCEJBEBHLIG IEIHDFLAFGN, T IKLIFLGKEBP, bool NLANPPBOCDD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2F5B0E0", Offset = "0x2F59AE0", VA = "0x182F5B0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OEDCJBEJPGD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HBHLJIPALLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<MHHMGLIINAL> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public OEDCJBEJPGD <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public HBHLJIPALLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5C142A0", Offset = "0x5C12CA0", VA = "0x185C142A0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5C142F0", Offset = "0x5C12CF0", VA = "0x185C142F0")]
			internal AKLFEECCMIJ <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class OGGOKLBMJLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IMJBDMIHCKA.KOJBCOCKAAO itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public OGGOKLBMJLM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x5C18350", Offset = "0x5C16D50", VA = "0x185C18350")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct BOBOGOGHJPL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<MHHMGLIINAL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public OEDCJBEJPGD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private HBHLJIPALLC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<MHHMGLIINAL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5C0DE00", Offset = "0x5C0C800", VA = "0x185C0DE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5C0E610", Offset = "0x5C0D010", VA = "0x185C0E610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class DACBGJDBEPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public EOIKFJEBBHE sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public DACBGJDBEPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5C0EA60", Offset = "0x5C0D460", VA = "0x185C0EA60")]
			internal bool <ClearSlice>b__0(MHHMGLIINAL bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly MFIONILMKIE CLBJFMCGEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string OKADEGOBECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<MHHMGLIINAL> LNPPKABPLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(IMJBDMIHCKA.KOJBCOCKAAO itemType, long totalStopwatchTicks)> DJJALBEKEAF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ACLENAGOMJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5C173F0", Offset = "0x5C15DF0", VA = "0x185C173F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<MHHMGLIINAL> EGOOMACJHOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5C176C0", Offset = "0x5C160C0", VA = "0x185C176C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5C174F0", Offset = "0x5C15EF0", VA = "0x185C174F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5C17760", Offset = "0x5C16160", VA = "0x185C17760")]
		public OEDCJBEJPGD(MFIONILMKIE CLBJFMCGEMI, string OKADEGOBECF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5C17250", Offset = "0x5C15C50", VA = "0x185C17250")]
		[AsyncStateMachine(typeof(BOBOGOGHJPL))]
		public Task<MHHMGLIINAL> BCNNBLABCFJ(CancellationToken OGOJJPCADFI, TimeSpan PDMPKAPONBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5C17440", Offset = "0x5C15E40", VA = "0x185C17440")]
		public void IACAHMEFHBA(MHHMGLIINAL PJJGOJBLNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5C173A0", Offset = "0x5C15DA0", VA = "0x185C173A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5C17590", Offset = "0x5C15F90", VA = "0x185C17590")]
		public void IOOAGKGAMDB(EOIKFJEBBHE GDBEGDEBBBP, Guid ENFGKNDHLNI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FONMOGCGNMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<MHHMGLIINAL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public BEFCABJAJLP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public FFDLPAMNALE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public BEFCABJAJLP pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<MHHMGLIINAL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5C13670", Offset = "0x5C12070", VA = "0x185C13670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5C13F90", Offset = "0x5C12990", VA = "0x185C13F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct CPGPLDBDBCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public FFDLPAMNALE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public BEFCABJAJLP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public BEFCABJAJLP pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<PJBKIOJKJHD<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5C0E660", Offset = "0x5C0D060", VA = "0x185C0E660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5C0EA10", Offset = "0x5C0D410", VA = "0x185C0EA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct JKFHHMFNEOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<MHHMGLIINAL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public FFDLPAMNALE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public BEFCABJAJLP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public BEFCABJAJLP pauseAfterListeningToken;

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
		private TaskAwaiter<MHHMGLIINAL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5C157D0", Offset = "0x5C141D0", VA = "0x185C157D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5C160D0", Offset = "0x5C14AD0", VA = "0x185C160D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class GFFJAGANPNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public FFDLPAMNALE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public GFFJAGANPNB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OGEFBHLFILO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<MHHMGLIINAL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public FFDLPAMNALE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private GFFJAGANPNB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public BEFCABJAJLP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public BEFCABJAJLP pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private LPJGPFDHFFL <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<MHHMGLIINAL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5C17860", Offset = "0x5C16260", VA = "0x185C17860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5C18300", Offset = "0x5C16D00", VA = "0x185C18300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OPPOIKHPODD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<MHHMGLIINAL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public FFDLPAMNALE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public BEFCABJAJLP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public BEFCABJAJLP pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<MHHMGLIINAL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5C18670", Offset = "0x5C17070", VA = "0x185C18670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5C18A50", Offset = "0x5C17450", VA = "0x185C18A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class EEMKGFPLDFO
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
			public EEMKGFPLDFO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5C18B30", Offset = "0x5C17530", VA = "0x185C18B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5C18CA0", Offset = "0x5C176A0", VA = "0x185C18CA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public EEMKGFPLDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5C0EBD0", Offset = "0x5C0D5D0", VA = "0x185C0EBD0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct LFFGFJPIFPE : IAsyncStateMachine
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
		public FFDLPAMNALE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public BEFCABJAJLP unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public BEFCABJAJLP pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5C16690", Offset = "0x5C15090", VA = "0x185C16690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x795F10", Offset = "0x794910", VA = "0x180795F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class NFHLABMIHLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public NFHLABMIHLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5C171B0", Offset = "0x5C15BB0", VA = "0x185C171B0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5C17160", Offset = "0x5C15B60", VA = "0x185C17160")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EFJOKAHBDDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EOIKFJEBBHE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public EFJOKAHBDDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5C0ED10", Offset = "0x5C0D710", VA = "0x185C0ED10")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class FDNFGBBFEGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public EOIKFJEBBHE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public FDNFGBBFEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5C0EE30", Offset = "0x5C0D830", VA = "0x185C0EE30")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class NEMKFCECEDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public NEMKFCECEDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5C170F0", Offset = "0x5C15AF0", VA = "0x185C170F0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class OMKHOOGNJNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public OMKHOOGNJNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5C18420", Offset = "0x5C16E20", VA = "0x185C18420")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PGDDJFFEANB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public PGDDJFFEANB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5C18AA0", Offset = "0x5C174A0", VA = "0x185C18AA0")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class OPFCGGNKGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public OPFCGGNKGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5C18490", Offset = "0x5C16E90", VA = "0x185C18490")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ICIHMNMLLOG
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
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public ICIHMNMLLOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5C149B0", Offset = "0x5C133B0", VA = "0x185C149B0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5C14950", Offset = "0x5C13350", VA = "0x185C14950")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class BCAHCEOADDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public BCAHCEOADDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C220", Offset = "0x5C0AC20", VA = "0x185C0C220")]
		internal bool <ClearSliceIds>b__3(HBEFNGNHEBB stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LBFCFIGKPFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public LBFCFIGKPFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5C16190", Offset = "0x5C14B90", VA = "0x185C16190")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5C16410", Offset = "0x5C14E10", VA = "0x185C16410")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5C16120", Offset = "0x5C14B20", VA = "0x185C16120")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly EGNNPPEPFEN DMKOELJLKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable JPFNCBPKAPN;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly FNEPLMMLBJC GNFMLMPHGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly OEDCJBEJPGD EOOFDKMEDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MFIONILMKIE CLBJFMCGEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HIDPPPFHIML CLICMEBPLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JHKKNPKBLLK BGMGABMLAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly EGNNPPEPFEN GFGPACJCFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool KHOMFNMOLBI;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan BFOMAKBBBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan GJGPDICABCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte ODKOFEMIALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] FFICNIHEJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<HBEFNGNHEBB> NPOKBLEIEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private JCEJBEBHLIG? LDDBBPEJADJ;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly FNEPLMMLBJC EHGCDCEJNKN;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly FNEPLMMLBJC EOLMMLJPHFC;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<MHHMGLIINAL> LEMJIALPAFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C12EE0", Offset = "0x5C118E0", VA = "0x185C12EE0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C0FE10", Offset = "0x5C0E810", VA = "0x185C0FE10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5C131C0", Offset = "0x5C11BC0", VA = "0x185C131C0")]
	public FFDLPAMNALE(MFIONILMKIE CLBJFMCGEMI, HIDPPPFHIML CLICMEBPLKA, JHKKNPKBLLK BGMGABMLAKE, [Optional] TimeSpan? BJELOJEJBEO, [Optional] EGNNPPEPFEN LCMAIIGEBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1AAA8B0", Offset = "0x1AA92B0", VA = "0x181AAA8B0")]
	public static FFDLPAMNALE NKIAPCNOHNH<TNetworking>(TNetworking MCPBOIHDMMJ, [Optional] TimeSpan? BJELOJEJBEO, [Optional] EGNNPPEPFEN LCMAIIGEBOK) where TNetworking : MFIONILMKIE, HIDPPPFHIML, JHKKNPKBLLK
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FEB0", Offset = "0x5C0E8B0", VA = "0x185C0FEB0")]
	public void DMDPJFLHNDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F120", Offset = "0x5C0DB20", VA = "0x185C0F120")]
	private byte AICABHKBHAA()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5C10B90", Offset = "0x5C0F590", VA = "0x185C10B90")]
	private TimeSpan IAPPHGEOHCB(TimeSpan? BJELOJEJBEO, int BINODEJNOAJ = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1AAA350", Offset = "0x1AA8D50", VA = "0x181AAA350")]
	public bool EBMDDHICFPO<T>(T ILHAJPIDFCO, Func<T, byte[]> CGNILOEHIHM, bool NLANPPBOCDD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FFA0", Offset = "0x5C0E9A0", VA = "0x185C0FFA0")]
	public bool EBMDDHICFPO(byte[] ILHAJPIDFCO, int IBMAHCIBNHL, bool NLANPPBOCDD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69E450", Offset = "0x69CE50", VA = "0x18069E450")]
	private static string LONGABCLJNN(string PJJGOJBLNDL, string FDMANEGJPBO = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5C10580", Offset = "0x5C0EF80", VA = "0x185C10580")]
	[AsyncStateMachine(typeof(FONMOGCGNMA))]
	public Task<MHHMGLIINAL> EKNOLLLFNOC(CancellationToken OGOJJPCADFI, [Optional] BEFCABJAJLP NBKDEJBFNBM, [Optional] BEFCABJAJLP FIIJPDKFPBM, [Optional] TimeSpan? BJELOJEJBEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5C0EF90", Offset = "0x5C0D990", VA = "0x185C0EF90")]
	[AsyncStateMachine(typeof(CPGPLDBDBCC))]
	public Task<Guid> ADJIPCKOIPM(Guid PGLHFAFNNCB, CancellationToken OGOJJPCADFI, [Optional] BEFCABJAJLP NBKDEJBFNBM, [Optional] BEFCABJAJLP FIIJPDKFPBM, [Optional] TimeSpan? PDMPKAPONBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1AA9FD0", Offset = "0x1AA89D0", VA = "0x181AA9FD0")]
	[AsyncStateMachine(typeof(FIAJDIHMMOL))]
	public Task<PJBKIOJKJHD<T>> BNJFAOMACKH<T>(T ILHAJPIDFCO, Func<T, byte[]> CGNILOEHIHM, Func<byte[], T> DDKDOCOMGJN, CancellationToken OGOJJPCADFI, [Optional] BEFCABJAJLP NBKDEJBFNBM, [Optional] BEFCABJAJLP FIIJPDKFPBM, [Optional] TimeSpan? PDMPKAPONBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F890", Offset = "0x5C0E290", VA = "0x185C0F890")]
	[AsyncStateMachine(typeof(JKFHHMFNEOM))]
	public Task<MHHMGLIINAL> BNJFAOMACKH(byte[] ILHAJPIDFCO, CancellationToken OGOJJPCADFI, [Optional] BEFCABJAJLP NBKDEJBFNBM, [Optional] BEFCABJAJLP FIIJPDKFPBM, [Optional] TimeSpan? PDMPKAPONBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5C109E0", Offset = "0x5C0F3E0", VA = "0x185C109E0")]
	[AsyncStateMachine(typeof(OGEFBHLFILO))]
	private Task<MHHMGLIINAL> HJJBOKMGGOP(byte[] ILHAJPIDFCO, CancellationToken OGOJJPCADFI, BEFCABJAJLP NBKDEJBFNBM, BEFCABJAJLP FIIJPDKFPBM, TimeSpan? BJELOJEJBEO, Stopwatch BGLCHAIGCOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F130", Offset = "0x5C0DB30", VA = "0x185C0F130")]
	[AsyncStateMachine(typeof(OPPOIKHPODD))]
	private Task<MHHMGLIINAL> AMFCOFOFAIH(byte[] ILHAJPIDFCO, CancellationToken OGOJJPCADFI, [Optional] BEFCABJAJLP NBKDEJBFNBM, [Optional] BEFCABJAJLP FIIJPDKFPBM, [Optional] TimeSpan? PDMPKAPONBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C121F0", Offset = "0x5C10BF0", VA = "0x185C121F0")]
	[AsyncStateMachine(typeof(LFFGFJPIFPE))]
	public Task LHEDKMFEGPA(CancellationToken NNCKLKMJCBA, Func<CancellationToken, Task> IHJBFAAOGMN, [Optional] BEFCABJAJLP NBKDEJBFNBM, [Optional] BEFCABJAJLP FIIJPDKFPBM, int MLLGGANFOGF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1AAA400", Offset = "0x1AA8E00", VA = "0x181AAA400")]
	[AsyncStateMachine(typeof(BLNPNPDECAM))]
	public Task<T> LHEDKMFEGPA<T>(CancellationToken NNCKLKMJCBA, Func<CancellationToken, Task<T>> IHJBFAAOGMN, [Optional] BEFCABJAJLP NBKDEJBFNBM, [Optional] BEFCABJAJLP FIIJPDKFPBM, int MLLGGANFOGF = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1AAA950", Offset = "0x1AA9350", VA = "0x181AAA950")]
	[AsyncStateMachine(typeof(CMJFBLPHEOD))]
	private Task<(bool, T)> NOEMGJBINDE<T>(Guid OMHEHEILMCO, CancellationToken NNCKLKMJCBA, Func<CancellationToken, Task<T>> IHJBFAAOGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C10DD0", Offset = "0x5C0F7D0", VA = "0x185C10DD0")]
	public void IFPNBAMLIGJ(byte KKBGNEELMCG, int GMPHILNBFIM, object PLCEPCKEGNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C129A0", Offset = "0x5C113A0", VA = "0x185C129A0")]
	public Guid NDGLHLPLEHC(Guid ADDKGBDONJC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C12370", Offset = "0x5C10D70", VA = "0x185C12370")]
	public bool LPCHOKJHAGB(EOIKFJEBBHE GDBEGDEBBBP, Guid OMHEHEILMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C0FA20", Offset = "0x5C0E420", VA = "0x185C0FA20")]
	public void CLJMJEHPPKE(EOIKFJEBBHE GDBEGDEBBBP, Guid OMHEHEILMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5C12360", Offset = "0x5C10D60", VA = "0x185C12360")]
	private void LLGOGEFGNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5C11760", Offset = "0x5C10160", VA = "0x185C11760")]
	internal JCEJBEBHLIG IOKPHOHNFIL(bool LNMEKAHGJFH = false)
	{
		return default(JCEJBEBHLIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5C120B0", Offset = "0x5C10AB0", VA = "0x185C120B0")]
	private HashSet<Guid> KMCGKELDLGF(EOIKFJEBBHE GDBEGDEBBBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5C10820", Offset = "0x5C0F220", VA = "0x185C10820")]
	private void HHPMOPFEEFJ(EOIKFJEBBHE GDBEGDEBBBP, Guid ENFGKNDHLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5C12C00", Offset = "0x5C11600", VA = "0x185C12C00")]
	private void NIFOLOEGGGN(EOIKFJEBBHE GDBEGDEBBBP, Guid ENFGKNDHLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5C128F0", Offset = "0x5C112F0", VA = "0x185C128F0")]
	public static Func<Guid, bool> MFLKAACMOIJ(Guid ENFGKNDHLNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F2C0", Offset = "0x5C0DCC0", VA = "0x185C0F2C0")]
	public static Func<Guid, bool> AOMLJIFJNEG(Guid ENFGKNDHLNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C11870", Offset = "0x5C10270", VA = "0x185C11870")]
	public void IOOAGKGAMDB(EOIKFJEBBHE GDBEGDEBBBP, Guid ABOIPOGNGBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5C0F370", Offset = "0x5C0DD70", VA = "0x185C0F370")]
	public void BFCCICNNCCG(EOIKFJEBBHE GDBEGDEBBBP, Func<Guid, bool> ILHCKCFLIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5C10700", Offset = "0x5C0F100", VA = "0x185C10700")]
	private static ExitGames.Client.Photon.Hashtable GHEINMOBMIG(EOIKFJEBBHE GDBEGDEBBBP, Guid PCAIDAKKEIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5C11980", Offset = "0x5C10380", VA = "0x185C11980")]
	private void JLPHLDJJIGA(EOIKFJEBBHE GDBEGDEBBBP, Guid PCAIDAKKEIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class AKLFEECCMIJ : PKOJEBPMPJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(IMJBDMIHCKA.KOJBCOCKAAO itemType, long totalStopwatchTicks)> PJIKFKCOHMK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(IMJBDMIHCKA.KOJBCOCKAAO itemType, long totalStopwatchTicks)> KDALDDFIOGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7602D0", Offset = "0x75ECD0", VA = "0x1807602D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5C0C1A0", Offset = "0x5C0ABA0", VA = "0x185C0C1A0")]
	public AKLFEECCMIJ(TimeSpan PDMPKAPONBC, List<(IMJBDMIHCKA.KOJBCOCKAAO itemType, long totalStopwatchTicks)> PJIKFKCOHMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BNEJMFIBNCE : LPJGPFDHFFL
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct ICGAKFGNDIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid IDIOONCCEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int JPGLCFGMKOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int JPMOONDGNNK;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5C14940", Offset = "0x5C13340", VA = "0x185C14940")]
		public ICGAKFGNDIL(Guid OGGCBNLPMPM, int LAIENHOOGPA, int DJPMOAFEAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5C14860", Offset = "0x5C13260", VA = "0x185C14860")]
		public static byte[] NJDODOCIOLN(ICGAKFGNDIL PJJGOJBLNDL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5C14670", Offset = "0x5C13070", VA = "0x185C14670")]
		public static ICGAKFGNDIL GKBAFEAOLLC(byte[] GHEBPHBJKNK)
		{
			return default(ICGAKFGNDIL);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5C14730", Offset = "0x5C13130", VA = "0x185C14730")]
		private static byte[] JJKMKBHFPIA(int JEBAMNOFEGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5C147B0", Offset = "0x5C131B0", VA = "0x185C147B0")]
		private static int JOAJOGKHIIG(byte[] PFBGHMDDEDH, int NENMOOINMCH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid OGGCBNLPMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly FFDLPAMNALE HFJDAKOGAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool APPNAFPIAGJ;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DDA0", Offset = "0x5C0C7A0", VA = "0x185C0DDA0")]
	public BNEJMFIBNCE(Guid OGGCBNLPMPM, FFDLPAMNALE HFJDAKOGAKE, JHKKNPKBLLK MCPBOIHDMMJ, CancellationToken NNCKLKMJCBA, [Optional] FBHPFLEKABP PJJLAPNFNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D810", Offset = "0x5C0C210", VA = "0x185C0D810", Slot = "5")]
	protected override void KMGIGLELAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5C0DC00", Offset = "0x5C0C600", VA = "0x185C0DC00", Slot = "6")]
	protected override void PNIOPGKLALI(int KKBAAFFLMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5C0D9E0", Offset = "0x5C0C3E0", VA = "0x185C0D9E0")]
	private void LEMJIALPAFP(MHHMGLIINAL AFEFOCJCHEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct MHHMGLIINAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly JCEJBEBHLIG BGPFHMFPAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte KPGAOLLIEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte ELCECBCFKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool GLAPACPILLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] DIAPLDMNKLO;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5C17090", Offset = "0x5C15A90", VA = "0x185C17090")]
	public MHHMGLIINAL(JCEJBEBHLIG IEIHDFLAFGN, [CanBeNull] byte[] IKLIFLGKEBP, bool NLANPPBOCDD, byte HEPBPDPMGJM, byte IHFPPAABMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5C16EF0", Offset = "0x5C158F0", VA = "0x185C16EF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x5C16D00", Offset = "0x5C15700", VA = "0x185C16D00")]
	private static void DKBNOBHJEOH(byte[] IKLIFLGKEBP, StringBuilder JOJKMIILDGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct JCEJBEBHLIG
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BDGBNAMBKNF : IEnumerable<HBEFNGNHEBB>, IEnumerable, IEnumerator<HBEFNGNHEBB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private HBEFNGNHEBB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public JCEJBEBHLIG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public JCEJBEBHLIG <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private EOIKFJEBBHE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private HBEFNGNHEBB System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x2B93630", Offset = "0x2B92030", VA = "0x182B93630", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(HBEFNGNHEBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x5C0C590", Offset = "0x5C0AF90", VA = "0x185C0C590", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC340", Offset = "0x1EBAD40", VA = "0x181EBC340")]
		[DebuggerHidden]
		public BDGBNAMBKNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C2C0", Offset = "0x5C0ACC0", VA = "0x185C0C2C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C550", Offset = "0x5C0AF50", VA = "0x185C0C550", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C4B0", Offset = "0x5C0AEB0", VA = "0x185C0C4B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HBEFNGNHEBB> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5C0C4B0", Offset = "0x5C0AEB0", VA = "0x185C0C4B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly EOIKFJEBBHE MFMOCHNJFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] OFFHHJDICAE;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5C14EB0", Offset = "0x5C138B0", VA = "0x185C14EB0")]
	public static JCEJBEBHLIG GJIGHIEPMLG(EOIKFJEBBHE GDBEGDEBBBP, Guid PLIGEOOJANO)
	{
		return default(JCEJBEBHLIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5C14A90", Offset = "0x5C13490", VA = "0x185C14A90")]
	public static JCEJBEBHLIG FECGPOGFEFA(List<HBEFNGNHEBB> NIHGGCCILCP)
	{
		return default(JCEJBEBHLIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5C14FB0", Offset = "0x5C139B0", VA = "0x185C14FB0")]
	public static JCEJBEBHLIG HNEBEOEHKDE(EOIKFJEBBHE KFGFDJMPFJM, Guid[] EBDLFBMAKEG)
	{
		return default(JCEJBEBHLIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5C15590", Offset = "0x5C13F90", VA = "0x185C15590")]
	private JCEJBEBHLIG(EOIKFJEBBHE KFGFDJMPFJM, Guid[] EBDLFBMAKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5C14A10", Offset = "0x5C13410", VA = "0x185C14A10")]
	[IteratorStateMachine(typeof(BDGBNAMBKNF))]
	public IEnumerable<HBEFNGNHEBB> BOFECCBJDLJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5C15410", Offset = "0x5C13E10", VA = "0x185C15410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class IKAKHFPKIEO<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1A54B50", Offset = "0x1A53550", VA = "0x181A54B50", Slot = "4")]
	public void PJLEAFEEMAO(T PJJGOJBLNDL, IDictionary<object, object> PJIINDGLAPJ, bool NBOAEEFJLGF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void FBPPCBLHMNP(T PJJGOJBLNDL, IDictionary<object, object> PJIINDGLAPJ);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T GKBAFEAOLLC(IDictionary<object, object> PJIINDGLAPJ);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
	protected IKAKHFPKIEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LPJGPFDHFFL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool FBHPFLEKABP(int JNKLNJNCALA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool HHKBONGDECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly JHKKNPKBLLK JHOHCOCKGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken NNCKLKMJCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken HEOHFMBACJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly FBHPFLEKABP PJJLAPNFNAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource EACILHLJELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource MIAMMOFACCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int GJGCACIKPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool NHJOHBLNLJJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken LNODJMODCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5C168F0", Offset = "0x5C152F0", VA = "0x185C168F0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NHCPBAMMKIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5C16A80", Offset = "0x5C15480", VA = "0x185C16A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x5C16B50", Offset = "0x5C15550", VA = "0x185C16B50")]
	public LPJGPFDHFFL(JHKKNPKBLLK MCPBOIHDMMJ, CancellationToken NNCKLKMJCBA, [Optional] FBHPFLEKABP PJJLAPNFNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5C168D0", Offset = "0x5C152D0", VA = "0x185C168D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x5C16910", Offset = "0x5C15310", VA = "0x185C16910", Slot = "5")]
	protected virtual void KMGIGLELAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5C169E0", Offset = "0x5C153E0", VA = "0x185C169E0")]
	private void LPOMKFMHEFL(CNFJAKLHDLB PNAIBFOOLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5C16AD0", Offset = "0x5C154D0", VA = "0x185C16AD0")]
	protected void OHKIHAEJAFB(int KKBAAFFLMOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5C16B30", Offset = "0x5C15530", VA = "0x185C16B30", Slot = "6")]
	protected virtual void PNIOPGKLALI(int KKBAAFFLMOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct HBEFNGNHEBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly EOIKFJEBBHE FNNGLGNDIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid GGMHNMOBCMI;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x46952E0", Offset = "0x4693CE0", VA = "0x1846952E0")]
	public HBEFNGNHEBB(EOIKFJEBBHE GDBEGDEBBBP, Guid OMHEHEILMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5C14240", Offset = "0x5C12C40", VA = "0x185C14240")]
	public bool JEJFAEMEMPN(HBEFNGNHEBB BPKBHFMGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5C14150", Offset = "0x5C12B50", VA = "0x185C14150", Slot = "0")]
	public override bool Equals(object PDHKCBEBPNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5C14210", Offset = "0x5C12C10", VA = "0x185C14210", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum EOIKFJEBBHE : byte
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
internal static class OPIFMFGODPC
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly EOIKFJEBBHE[] JLMAKMBINJL;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5C18520", Offset = "0x5C16F20", VA = "0x185C18520")]
	public static int IPMNPDKDDEB(EOIKFJEBBHE GDBEGDEBBBP)
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
