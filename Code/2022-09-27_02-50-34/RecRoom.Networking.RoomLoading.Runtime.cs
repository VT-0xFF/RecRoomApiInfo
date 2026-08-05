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
internal class OFAKBKJKKLG : global::JGKEOILPKGC<HBBEKBJCEAO>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class LOOJODMFBKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public LOOJODMFBKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x26AA110", Offset = "0x26A9310", VA = "0x1826AA110")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] JPJICNCLHAN;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly OFAKBKJKKLG HBKBBJLFPOI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x26AACC0", Offset = "0x26A9EC0", VA = "0x1826AACC0", Slot = "5")]
	protected override void FHJIAKGCMEM(HBBEKBJCEAO HGHEMBBLDIC, IDictionary<object, object> ADIGGFBANFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x26AB0B0", Offset = "0x26AA2B0", VA = "0x1826AB0B0", Slot = "6")]
	public override HBBEKBJCEAO LGPKACCHBHO(IDictionary<object, object> ADIGGFBANFM)
	{
		return default(HBBEKBJCEAO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26ABB80", Offset = "0x26AAD80", VA = "0x1826ABB80")]
	public OFAKBKJKKLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class IAOOBAIGPGE
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string PIHKHNOFICL([NotNull] byte[] FDBJMNOLEFJ);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Flags]
	public enum HDKBHGMPIIC : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Operation = 1,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		RoomLoad = 2,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		MasterBlock = 4
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private readonly struct PDKEIAJCJPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public readonly HDKBHGMPIIC CNJILPACAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Guid CDPMKELKNFC;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x26ABD10", Offset = "0x26AAF10", VA = "0x1826ABD10")]
		public PDKEIAJCJPJ(HDKBHGMPIIC PEFDFPCGOMH, Guid NEPPMHBKFPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x26ABCB0", Offset = "0x26AAEB0", VA = "0x1826ABCB0")]
		public bool KCEJIHLPAFP(PDKEIAJCJPJ GHOINNFPLDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x26ABBC0", Offset = "0x26AADC0", VA = "0x1826ABBC0", Slot = "0")]
		public override bool Equals(object PBKPNJLDBOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x26ABC80", Offset = "0x26AAE80", VA = "0x1826ABC80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public readonly struct KONFJFIPOOK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public readonly bool NOAOGLLFMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly HDKBHGMPIIC CNJILPACAOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly Guid[] NCNPMFACNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public readonly T DBEIMJBGPKB;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x411CD60", Offset = "0x411BF60", VA = "0x18411CD60")]
		public static KONFJFIPOOK<T> EFEKPODLKCI(HBBEKBJCEAO PJBALODCHIP, Func<byte[], T> NDIADMMIJHJ)
		{
			return default(KONFJFIPOOK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x411D170", Offset = "0x411C370", VA = "0x18411D170")]
		public KONFJFIPOOK(HDKBHGMPIIC PEFDFPCGOMH, Guid[] GFPBLABJOPP, T FDBJMNOLEFJ, bool IKGHHPBGAEG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x411CFE0", Offset = "0x411C1E0", VA = "0x18411CFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JDEJDAHPIAI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class NANFMOBLGKG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public TaskCompletionSource<HBBEKBJCEAO> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public JDEJDAHPIAI <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public NANFMOBLGKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x26AA1B0", Offset = "0x26A93B0", VA = "0x1826AA1B0")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x26AA200", Offset = "0x26A9400", VA = "0x1826AA200")]
			internal AHFNNIPMBOM <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class GCMLDIBJEAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public HFKNDJPGMMK.OMBOODOKGIJ itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public GCMLDIBJEAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x26A3430", Offset = "0x26A2630", VA = "0x1826A3430")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct APOGDMJFIFJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<HBBEKBJCEAO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public JDEJDAHPIAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private NANFMOBLGKG <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private TaskAwaiter<HBBEKBJCEAO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x26A19B0", Offset = "0x26A0BB0", VA = "0x1826A19B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x26A2060", Offset = "0x26A1260", VA = "0x1826A2060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class NIBEMEOCGBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public HDKBHGMPIIC sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
			public NIBEMEOCGBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x26AA520", Offset = "0x26A9720", VA = "0x1826AA520")]
			internal bool <ClearSlice>b__0(HBBEKBJCEAO bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly MCHDFABIOOM HCHCIMPBLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly string BKJBAPEFFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly List<HBBEKBJCEAO> KMNDODEHIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private List<(HFKNDJPGMMK.OMBOODOKGIJ itemType, long totalStopwatchTicks)> DOODNLAGNHE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GJKOMPOJJCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x26A8D00", Offset = "0x26A7F00", VA = "0x1826A8D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<HBBEKBJCEAO> PPFLDDJGEFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x26A8D40", Offset = "0x26A7F40", VA = "0x1826A8D40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x26A8930", Offset = "0x26A7B30", VA = "0x1826A8930")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x26A8DE0", Offset = "0x26A7FE0", VA = "0x1826A8DE0")]
		public JDEJDAHPIAI(MCHDFABIOOM HCHCIMPBLMM, string BKJBAPEFFNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x26A8A20", Offset = "0x26A7C20", VA = "0x1826A8A20")]
		[AsyncStateMachine(typeof(APOGDMJFIFJ))]
		public Task<HBBEKBJCEAO> FIINGLOJHGM(CancellationToken GENHLOEKMNL, TimeSpan DKDELEMGGHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x26A8B60", Offset = "0x26A7D60", VA = "0x1826A8B60")]
		public void HAHEGLOJHEB(HBBEKBJCEAO HGHEMBBLDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x26A89D0", Offset = "0x26A7BD0", VA = "0x1826A89D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x26A8C10", Offset = "0x26A7E10", VA = "0x1826A8C10")]
		public void KDLLBDHGGEM(HDKBHGMPIIC PEFDFPCGOMH, Guid IHPCCBHNEMN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct FJAHNIKHJDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<HBBEKBJCEAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public DPBKAPJPKAG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IAOOBAIGPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public DPBKAPJPKAG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<HBBEKBJCEAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x26A2C00", Offset = "0x26A1E00", VA = "0x1826A2C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x26A33E0", Offset = "0x26A25E0", VA = "0x1826A33E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct OEEALOLOPOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public IAOOBAIGPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public DPBKAPJPKAG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public DPBKAPJPKAG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter<KONFJFIPOOK<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x26AA950", Offset = "0x26A9B50", VA = "0x1826AA950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x26AAC70", Offset = "0x26A9E70", VA = "0x1826AAC70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IIJKKFFMFMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public AsyncTaskMethodBuilder<HBBEKBJCEAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public IAOOBAIGPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public DPBKAPJPKAG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public DPBKAPJPKAG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private Stopwatch <sw>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <frameStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private TaskAwaiter<HBBEKBJCEAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x26A7E00", Offset = "0x26A7000", VA = "0x1826A7E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x26A8550", Offset = "0x26A7750", VA = "0x1826A8550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class DFPPBCJKEJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public IAOOBAIGPGE <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DFPPBCJKEJI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct KMOMNADEKJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public AsyncTaskMethodBuilder<HBBEKBJCEAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public IAOOBAIGPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private DFPPBCJKEJI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public DPBKAPJPKAG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DPBKAPJPKAG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private JIKDKJKBOON <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskAwaiter<HBBEKBJCEAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x26A9300", Offset = "0x26A8500", VA = "0x1826A9300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x26A9B70", Offset = "0x26A8D70", VA = "0x1826A9B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct HKEGJNNBACP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public AsyncTaskMethodBuilder<HBBEKBJCEAO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IAOOBAIGPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public DPBKAPJPKAG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DPBKAPJPKAG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<HBBEKBJCEAO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x26A3D80", Offset = "0x26A2F80", VA = "0x1826A3D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x26A40B0", Offset = "0x26A32B0", VA = "0x1826A40B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class COABMDHNLIA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private struct <<MasterLockedBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public COABMDHNLIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x26ABD20", Offset = "0x26AAF20", VA = "0x1826ABD20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x26ABE80", Offset = "0x26AB080", VA = "0x1826ABE80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public COABMDHNLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x26A26B0", Offset = "0x26A18B0", VA = "0x1826A26B0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct FCKHEOJBGCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public IAOOBAIGPGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public DPBKAPJPKAG unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public DPBKAPJPKAG pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x26A2A20", Offset = "0x26A1C20", VA = "0x1826A2A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class INCHHLLPFEF : IEnumerable<(HDKBHGMPIIC, Guid)>, IEnumerable, IEnumerator<(HDKBHGMPIIC, Guid)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private (HDKBHGMPIIC sliceType, Guid sliceId) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private HDKBHGMPIIC sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HDKBHGMPIIC <>3__sliceTypeFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private Guid[] sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Guid[] <>3__sliceTypeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private HDKBHGMPIIC[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		private (HDKBHGMPIIC, Guid) System.Collections.Generic.IEnumerator<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x26A8870", Offset = "0x26A7A70", VA = "0x1826A8870", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((HDKBHGMPIIC, Guid));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x26A88E0", Offset = "0x26A7AE0", VA = "0x1826A88E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x880060", Offset = "0x87F260", VA = "0x180880060")]
		[DebuggerHidden]
		public INCHHLLPFEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x26A85A0", Offset = "0x26A77A0", VA = "0x1826A85A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x26A8890", Offset = "0x26A7A90", VA = "0x1826A8890", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x26A87C0", Offset = "0x26A79C0", VA = "0x1826A87C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(HDKBHGMPIIC, Guid)> System.Collections.Generic.IEnumerable<(RecRoom.Networking.Events.BufferedEventHelper.SliceTypesliceType,System.GuidsliceId)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x26A87C0", Offset = "0x26A79C0", VA = "0x1826A87C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class APCBIBJINAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public APCBIBJINAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x26A18E0", Offset = "0x26A0AE0", VA = "0x1826A18E0")]
		internal object <OnEvent>b__0()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x26A1920", Offset = "0x26A0B20", VA = "0x1826A1920")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x26A1970", Offset = "0x26A0B70", VA = "0x1826A1970")]
		internal object <OnEvent>b__2()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CCBNOFIEBMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public HDKBHGMPIIC sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public CCBNOFIEBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x26A2630", Offset = "0x26A1830", VA = "0x1826A2630")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HIOBJDKAENC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public HDKBHGMPIIC sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public HIOBJDKAENC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x26A3D00", Offset = "0x26A2F00", VA = "0x1826A3D00")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HCEJFLAKINC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public HCEJFLAKINC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x26A3BE0", Offset = "0x26A2DE0", VA = "0x1826A3BE0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DDMODEEAKFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DDMODEEAKFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x26A27D0", Offset = "0x26A19D0", VA = "0x1826A27D0")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GOLIBNEEFKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public GOLIBNEEFKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x26A34E0", Offset = "0x26A26E0", VA = "0x1826A34E0")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DPKHADPAKNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public DPKHADPAKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x26A2990", Offset = "0x26A1B90", VA = "0x1826A2990")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class HDKAHCGLMJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Func<Guid, bool> matchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<Guid, bool> <>9__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Func<Guid, bool> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public HDKAHCGLMJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x26A3CA0", Offset = "0x26A2EA0", VA = "0x1826A3CA0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x26A3C40", Offset = "0x26A2E40", VA = "0x1826A3C40")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BHKIENFCGHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public ExitGames.Client.Photon.Hashtable content;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
		public BHKIENFCGHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x26A20B0", Offset = "0x26A12B0", VA = "0x1826A20B0")]
		internal bool <ClearSliceIds>b__3(PDKEIAJCJPJ stackSlice)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x26A21B0", Offset = "0x26A13B0", VA = "0x1826A21B0")]
		internal object <ClearSliceIds>b__5()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x26A23F0", Offset = "0x26A15F0", VA = "0x1826A23F0")]
		internal object <ClearSliceIds>b__6()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x26A2150", Offset = "0x26A1350", VA = "0x1826A2150")]
		internal object <ClearSliceIds>b__4()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly PIHKHNOFICL FOBBNODKGLD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable BLGBEPHCMEC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly FJFANJPNCGN MOKJELFNJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JDEJDAHPIAI EJJNICECKAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MCHDFABIOOM HCHCIMPBLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CMGCODDFPPE FKKJHGEECMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly LIJNDJHFMJO KAHLIDAGINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PIHKHNOFICL HGGOAGPDDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool ODHDMLLLNOE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan BFCJMFJBEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan CEEAOLHIHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte EOAOOFICINH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal static readonly HDKBHGMPIIC[] NPKBDLMKLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HashSet<Guid>[] EKLIDDGGFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<PDKEIAJCJPJ> OAMFABCOCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private (HDKBHGMPIIC combinedSliceType, Guid[] sliceTypeIds)? CLHOCEHIJFO;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<HBBEKBJCEAO> LCGDMIEDKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x26A5E00", Offset = "0x26A5000", VA = "0x1826A5E00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x26A6020", Offset = "0x26A5220", VA = "0x1826A6020")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x26A7A10", Offset = "0x26A6C10", VA = "0x1826A7A10")]
	public IAOOBAIGPGE(MCHDFABIOOM HCHCIMPBLMM, CMGCODDFPPE FKKJHGEECMD, LIJNDJHFMJO KAHLIDAGINI, [Optional] TimeSpan? LDDCOEFJDAN, [Optional] PIHKHNOFICL KHCCGKPFPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x398CF90", Offset = "0x398C190", VA = "0x18398CF90")]
	public static IAOOBAIGPGE BDJHHDEPNNB<TNetworking>(TNetworking ELPBHABCDMF, [Optional] TimeSpan? LDDCOEFJDAN, [Optional] PIHKHNOFICL KHCCGKPFPAN) where TNetworking : MCHDFABIOOM, CMGCODDFPPE, LIJNDJHFMJO
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x26A54C0", Offset = "0x26A46C0", VA = "0x1826A54C0")]
	public void DIPAICNNLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x26A5A70", Offset = "0x26A4C70", VA = "0x1826A5A70")]
	private byte GLDNGLIFLDJ()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x26A52E0", Offset = "0x26A44E0", VA = "0x1826A52E0")]
	private TimeSpan DIGEEILIDCJ(TimeSpan? LDDCOEFJDAN, int CMDGOLKDHEC = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x46A0410", Offset = "0x469F610", VA = "0x1846A0410")]
	public bool OJKEOOPJFEK<T>(T KHAAOCINPHL, Func<T, byte[]> CANPFCDJMLM, bool IKGHHPBGAEG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x26A6CB0", Offset = "0x26A5EB0", VA = "0x1826A6CB0")]
	public bool OJKEOOPJFEK(byte[] KHAAOCINPHL, int MPJEAEJAMJH, bool IKGHHPBGAEG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6D6330", Offset = "0x6D5530", VA = "0x1806D6330")]
	private static string HPCDNPOKONG(string HGHEMBBLDIC, string JGDHNJNCLMJ = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26A55A0", Offset = "0x26A47A0", VA = "0x1826A55A0")]
	[AsyncStateMachine(typeof(FJAHNIKHJDC))]
	public Task<HBBEKBJCEAO> DMKHDMIFHEC(CancellationToken GENHLOEKMNL, [Optional] DPBKAPJPKAG HBEGFJNGOBI, [Optional] DPBKAPJPKAG BHNIBBLDPPJ, [Optional] TimeSpan? LDDCOEFJDAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x26A5790", Offset = "0x26A4990", VA = "0x1826A5790")]
	[AsyncStateMachine(typeof(OEEALOLOPOL))]
	public Task<Guid> FCJPKNEMFBH(Guid FKLPJHFJALO, CancellationToken GENHLOEKMNL, [Optional] DPBKAPJPKAG HBEGFJNGOBI, [Optional] DPBKAPJPKAG BHNIBBLDPPJ, [Optional] TimeSpan? DKDELEMGGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x385F890", Offset = "0x385EA90", VA = "0x18385F890")]
	[AsyncStateMachine(typeof(JOPGDGKIJKK))]
	public Task<KONFJFIPOOK<T>> GCICCNPEIBI<T>(T KHAAOCINPHL, Func<T, byte[]> CANPFCDJMLM, Func<byte[], T> NDIADMMIJHJ, CancellationToken GENHLOEKMNL, [Optional] DPBKAPJPKAG HBEGFJNGOBI, [Optional] DPBKAPJPKAG BHNIBBLDPPJ, [Optional] TimeSpan? DKDELEMGGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x26A5900", Offset = "0x26A4B00", VA = "0x1826A5900")]
	[AsyncStateMachine(typeof(IIJKKFFMFMC))]
	public Task<HBBEKBJCEAO> GCICCNPEIBI(byte[] KHAAOCINPHL, CancellationToken GENHLOEKMNL, [Optional] DPBKAPJPKAG HBEGFJNGOBI, [Optional] DPBKAPJPKAG BHNIBBLDPPJ, [Optional] TimeSpan? DKDELEMGGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x26A5C00", Offset = "0x26A4E00", VA = "0x1826A5C00")]
	[AsyncStateMachine(typeof(KMOMNADEKJI))]
	private Task<HBBEKBJCEAO> HBKJMPJDOFB(byte[] KHAAOCINPHL, CancellationToken GENHLOEKMNL, DPBKAPJPKAG HBEGFJNGOBI, DPBKAPJPKAG BHNIBBLDPPJ, TimeSpan? LDDCOEFJDAN, Stopwatch FAKKJDKIBFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x26A60C0", Offset = "0x26A52C0", VA = "0x1826A60C0")]
	[AsyncStateMachine(typeof(HKEGJNNBACP))]
	private Task<HBBEKBJCEAO> MHJICHDHOML(byte[] KHAAOCINPHL, CancellationToken GENHLOEKMNL, [Optional] DPBKAPJPKAG HBEGFJNGOBI, [Optional] DPBKAPJPKAG BHNIBBLDPPJ, [Optional] TimeSpan? DKDELEMGGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26A71D0", Offset = "0x26A63D0", VA = "0x1826A71D0")]
	[AsyncStateMachine(typeof(FCKHEOJBGCF))]
	public Task OLMJNECPFIP(CancellationToken HJBBMMLLNMM, Func<CancellationToken, Task> PCLMPEHMHNL, [Optional] DPBKAPJPKAG HBEGFJNGOBI, [Optional] DPBKAPJPKAG BHNIBBLDPPJ, int OKCPLCDKAED = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x385FF00", Offset = "0x385F100", VA = "0x18385FF00")]
	[AsyncStateMachine(typeof(AOFLPFFFNEI))]
	public Task<T> OLMJNECPFIP<T>(CancellationToken HJBBMMLLNMM, Func<CancellationToken, Task<T>> PCLMPEHMHNL, [Optional] DPBKAPJPKAG HBEGFJNGOBI, [Optional] DPBKAPJPKAG BHNIBBLDPPJ, int OKCPLCDKAED = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x385FA50", Offset = "0x385EC50", VA = "0x18385FA50")]
	[AsyncStateMachine(typeof(NCJFIAEKLBF))]
	private Task<(bool, T)> KKHGCNCIEKJ<T>(Guid NEPPMHBKFPH, CancellationToken HJBBMMLLNMM, Func<CancellationToken, Task<T>> PCLMPEHMHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x26A5D80", Offset = "0x26A4F80", VA = "0x1826A5D80")]
	[IteratorStateMachine(typeof(INCHHLLPFEF))]
	internal static IEnumerable<(HDKBHGMPIIC, Guid)> HKPNDHCBBOP(HDKBHGMPIIC BDINJOMHGHB, Guid[] NMAGODEIGBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x26A6230", Offset = "0x26A5430", VA = "0x1826A6230")]
	public void NBNPJLPJHMG(byte MADGAIOEDCO, int FOIFOHEODKO, object KFLLFLKGPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x26A4100", Offset = "0x26A3300", VA = "0x1826A4100")]
	public Guid AFLKLDNECLF(Guid ENLEIGJHNNC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x26A4FE0", Offset = "0x26A41E0", VA = "0x1826A4FE0")]
	internal static int CMBIOIMGLLJ(HDKBHGMPIIC PEFDFPCGOMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x26A4B90", Offset = "0x26A3D90", VA = "0x1826A4B90")]
	public bool CDBODPGLPLM(HDKBHGMPIIC PEFDFPCGOMH, Guid NEPPMHBKFPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x26A6980", Offset = "0x26A5B80", VA = "0x1826A6980")]
	public void OJHKHPBBCNH(HDKBHGMPIIC PEFDFPCGOMH, Guid NEPPMHBKFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x26A58F0", Offset = "0x26A4AF0", VA = "0x1826A58F0")]
	private void FHJMPNCAJPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x26A7330", Offset = "0x26A6530", VA = "0x1826A7330")]
	internal (HDKBHGMPIIC, Guid[]) PBDDMHILIIF(bool JJGOIOOIAKD = false)
	{
		return default((HDKBHGMPIIC, Guid[]));
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x26A7720", Offset = "0x26A6920", VA = "0x1826A7720")]
	private HashSet<Guid> POABOCAGNKN(HDKBHGMPIIC PEFDFPCGOMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x26A5A80", Offset = "0x26A4C80", VA = "0x1826A5A80")]
	private void GMHMLIGJMFJ(HDKBHGMPIIC PEFDFPCGOMH, Guid IHPCCBHNEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x26A5090", Offset = "0x26A4290", VA = "0x1826A5090")]
	private void DBJHHBOCEDK(HDKBHGMPIIC PEFDFPCGOMH, Guid IHPCCBHNEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x26A5F90", Offset = "0x26A5190", VA = "0x1826A5F90")]
	public static Func<Guid, bool> LLAELMBJKNI(Guid IHPCCBHNEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x26A5700", Offset = "0x26A4900", VA = "0x1826A5700")]
	public static Func<Guid, bool> EEIKCICBOGA(Guid IHPCCBHNEMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x26A5EA0", Offset = "0x26A50A0", VA = "0x1826A5EA0")]
	public void KDLLBDHGGEM(HDKBHGMPIIC PEFDFPCGOMH, Guid EECGAHKGANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x26A4350", Offset = "0x26A3550", VA = "0x1826A4350")]
	public void BPIBBICIFML(HDKBHGMPIIC PEFDFPCGOMH, Func<Guid, bool> KMPAAFLCLMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class AHFNNIPMBOM : FCFOJNLFCIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private List<(HFKNDJPGMMK.OMBOODOKGIJ itemType, long totalStopwatchTicks)> GEKABGNENPG;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public IReadOnlyList<(HFKNDJPGMMK.OMBOODOKGIJ itemType, long totalStopwatchTicks)> LFNKOGODFLL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x699000", Offset = "0x698200", VA = "0x180699000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x26A1860", Offset = "0x26A0A60", VA = "0x1826A1860")]
	public AHFNNIPMBOM(TimeSpan DKDELEMGGHG, List<(HFKNDJPGMMK.OMBOODOKGIJ itemType, long totalStopwatchTicks)> GEKABGNENPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LAINLFHGOMH : JIKDKJKBOON
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	private struct NPIFDDOKFJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public readonly Guid OBNOMPJCDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public readonly int AEFAGELBPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public readonly int LPHIECHBMCD;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x26AA940", Offset = "0x26A9B40", VA = "0x1826AA940")]
		public NPIFDDOKFJK(Guid NBFEGIBPIKK, int KHGHKLHGJKO, int MAHADBDPEFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x26AA7C0", Offset = "0x26A99C0", VA = "0x1826AA7C0")]
		public static byte[] LIOPAMDCNLD(NPIFDDOKFJK HGHEMBBLDIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x26AA710", Offset = "0x26A9910", VA = "0x1826AA710")]
		public static NPIFDDOKFJK LGPKACCHBHO(byte[] FAOJAOEJLMO)
		{
			return default(NPIFDDOKFJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x26AA690", Offset = "0x26A9890", VA = "0x1826AA690")]
		private static byte[] IAKEMIMEJEJ(int OCLFFJGEIJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x26AA890", Offset = "0x26A9A90", VA = "0x1826AA890")]
		private static int OPFLMECBFNE(byte[] GFJLOIKHIOH, int MJNAIOAAGCG)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly Guid NBFEGIBPIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly IAOOBAIGPGE JJOJAOGBEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool OIDJKDGKAPO;

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x26AA0B0", Offset = "0x26A92B0", VA = "0x1826AA0B0")]
	public LAINLFHGOMH(Guid NBFEGIBPIKK, IAOOBAIGPGE JJOJAOGBEED, LIJNDJHFMJO ELPBHABCDMF, CancellationToken HJBBMMLLNMM, [Optional] KGKJGEOHNNH PKFOCLBKGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x26A9D50", Offset = "0x26A8F50", VA = "0x1826A9D50", Slot = "5")]
	protected override void JHGKHFCELFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x26A9BC0", Offset = "0x26A8DC0", VA = "0x1826A9BC0", Slot = "6")]
	protected override void AFJPIOJAJAB(int IMNGPLGBAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x26A9ED0", Offset = "0x26A90D0", VA = "0x1826A9ED0")]
	private void LCGDMIEDKKP(HBBEKBJCEAO LPNEBAPLECG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct HBBEKBJCEAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public readonly byte JALNKFOANOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public readonly byte NFKNKDPHHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly bool NOAOGLLFMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly IAOOBAIGPGE.HDKBHGMPIIC CNJILPACAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly Guid[] NCNPMFACNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly byte[] DBEIMJBGPKB;

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x26A3B80", Offset = "0x26A2D80", VA = "0x1826A3B80")]
	public HBBEKBJCEAO(IAOOBAIGPGE.HDKBHGMPIIC PEFDFPCGOMH, [NotNull] Guid[] GFPBLABJOPP, byte[] FDBJMNOLEFJ, bool IKGHHPBGAEG, byte ONIKLJKLELG, byte CMGLMPMFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26A3710", Offset = "0x26A2910", VA = "0x1826A3710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x26A3570", Offset = "0x26A2770", VA = "0x1826A3570")]
	private static void GFGELCKAKJB(byte[] FDBJMNOLEFJ, StringBuilder OIGMPFBMKME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public abstract class JGKEOILPKGC<T>
{
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x46B8D70", Offset = "0x46B7F70", VA = "0x1846B8D70", Slot = "4")]
	public void OCEKEFEDHAF(T HGHEMBBLDIC, IDictionary<object, object> ADIGGFBANFM, bool JCHNGMGPHNH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void FHJIAKGCMEM(T HGHEMBBLDIC, IDictionary<object, object> ADIGGFBANFM);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T LGPKACCHBHO(IDictionary<object, object> ADIGGFBANFM);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x46B8B60", Offset = "0x46B7D60", VA = "0x1846B8B60", Slot = "7")]
	public bool FIBJMPDIPCH(IDictionary<object, object> ADIGGFBANFM, out T JFFJLMOJHPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
	protected JGKEOILPKGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JIKDKJKBOON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate bool KGKJGEOHNNH(int GCKEINLANOM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool JGKFDLIIMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	protected readonly LIJNDJHFMJO GLIPAFNENJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationToken HJBBMMLLNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationToken FDKDHNCIGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly KGKJGEOHNNH PKFOCLBKGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly CancellationTokenSource OGDFMNGOILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly CancellationTokenSource JHNBFHCEACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly int EAJHGMBLNGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool MHKEGOKLGCK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken FIAPAJIBIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x26A90E0", Offset = "0x26A82E0", VA = "0x1826A90E0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool KHIJICHLKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x26A8FE0", Offset = "0x26A81E0", VA = "0x1826A8FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x26A9100", Offset = "0x26A8300", VA = "0x1826A9100")]
	public JIKDKJKBOON(LIJNDJHFMJO ELPBHABCDMF, CancellationToken HJBBMMLLNMM, [Optional] KGKJGEOHNNH PKFOCLBKGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x26A8FC0", Offset = "0x26A81C0", VA = "0x1826A8FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x26A9030", Offset = "0x26A8230", VA = "0x1826A9030", Slot = "5")]
	protected virtual void JHGKHFCELFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x26A8F30", Offset = "0x26A8130", VA = "0x1826A8F30")]
	private void CHOJCNKDJLI(FLLPHMIGOPF IFAPKDFJBAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x26A8ED0", Offset = "0x26A80D0", VA = "0x1826A8ED0")]
	protected void BNNGPHLIHCL(int IMNGPLGBAJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x26A8EB0", Offset = "0x26A80B0", VA = "0x1826A8EB0", Slot = "6")]
	protected virtual void AFJPIOJAJAB(int IMNGPLGBAJA)
	{
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
