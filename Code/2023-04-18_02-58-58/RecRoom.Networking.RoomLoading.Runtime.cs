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
internal class GBOADCCDBPJ : global::FBPHFGEEIPK<KJNLACHNNBC>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class KMKGDEHPODA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public KMKGDEHPODA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x63A70A0", Offset = "0x63A62A0", VA = "0x1863A70A0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] MIFPOMCDNNL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly GBOADCCDBPJ OFDKPDDLIJC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x63A4230", Offset = "0x63A3430", VA = "0x1863A4230", Slot = "5")]
	protected override void BIFODNGCFFC(KJNLACHNNBC OFCFPGACNJB, IDictionary<object, object> PCPEJHIMHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x63A36B0", Offset = "0x63A28B0", VA = "0x1863A36B0", Slot = "6")]
	public override KJNLACHNNBC BBCFAILGGHN(IDictionary<object, object> PCPEJHIMHJJ)
	{
		return default(KJNLACHNNBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63A48C0", Offset = "0x63A3AC0", VA = "0x1863A48C0")]
	public GBOADCCDBPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class CIFHGJMONAD
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string EDAFDCDNEOI([NotNull] byte[] KHKGGNHOCOE);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct EDGDDOJJJCK<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly HFPKFPAPIPO FHACFIFHNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool BFJOPDAHAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T BMMKHHAFPCC;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x238FC50", Offset = "0x238EE50", VA = "0x18238FC50")]
		public static EDGDDOJJJCK<T> OPCDBKNPODM(KJNLACHNNBC PHHDOEICHGI, Func<byte[], T> AHAFOILAFPJ)
		{
			return default(EDGDDOJJJCK<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2390000", Offset = "0x238F200", VA = "0x182390000")]
		public EDGDDOJJJCK(HFPKFPAPIPO BAFBKHLJBGK, T KHKGGNHOCOE, bool EBHKCFMKLOC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x238FE60", Offset = "0x238F060", VA = "0x18238FE60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LAEPAIMHCBL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GHKLPLJADBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<KJNLACHNNBC> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public LAEPAIMHCBL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public GHKLPLJADBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x63A4900", Offset = "0x63A3B00", VA = "0x1863A4900")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x63A4950", Offset = "0x63A3B50", VA = "0x1863A4950")]
			internal NCFCOEPOKMM <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class FDDPJDEFMGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public HMIMBILJJGO.GDFIHGJKPGM itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public FDDPJDEFMGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x63A2BB0", Offset = "0x63A1DB0", VA = "0x1863A2BB0")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct JKGPDNHNHLB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<KJNLACHNNBC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public LAEPAIMHCBL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private GHKLPLJADBL <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<KJNLACHNNBC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x63A6290", Offset = "0x63A5490", VA = "0x1863A6290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63A6AA0", Offset = "0x63A5CA0", VA = "0x1863A6AA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class DKHBADMLGBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public LFFOMMJHDDP sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
			public DKHBADMLGBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x63A1B10", Offset = "0x63A0D10", VA = "0x1863A1B10")]
			internal bool <ClearSlice>b__0(KJNLACHNNBC bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly OADCCNAMIBC JKJKDGCLGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string HOLLFLHAINA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<KJNLACHNNBC> NHIACFJEBPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(HMIMBILJJGO.GDFIHGJKPGM itemType, long totalStopwatchTicks)> OGHHIJOPECB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool JBCFDLIGLAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x63A7760", Offset = "0x63A6960", VA = "0x1863A7760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<KJNLACHNNBC> EDEGKIPOOFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x63A7570", Offset = "0x63A6770", VA = "0x1863A7570")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x63A73A0", Offset = "0x63A65A0", VA = "0x1863A73A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63A77B0", Offset = "0x63A69B0", VA = "0x1863A77B0")]
		public LAEPAIMHCBL(OADCCNAMIBC JKJKDGCLGGK, string HOLLFLHAINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63A7610", Offset = "0x63A6810", VA = "0x1863A7610")]
		[AsyncStateMachine(typeof(JKGPDNHNHLB))]
		public Task<KJNLACHNNBC> KAECEMIBPAP(CancellationToken NDKAKDJMDIF, TimeSpan JHHEDLPJBLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63A72A0", Offset = "0x63A64A0", VA = "0x1863A72A0")]
		public void CIAAEAMHNCP(KJNLACHNNBC OFCFPGACNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x63A7350", Offset = "0x63A6550", VA = "0x1863A7350", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x63A7440", Offset = "0x63A6640", VA = "0x1863A7440")]
		public void EPLIAPLAEHG(LFFOMMJHDDP HJMLNEHBNBE, Guid IKHNIJKGJFD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct FOPCMOFFNAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<KJNLACHNNBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public IFCCNGGAOKK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CIFHGJMONAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public IFCCNGGAOKK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<KJNLACHNNBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x63A2D10", Offset = "0x63A1F10", VA = "0x1863A2D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x63A3660", Offset = "0x63A2860", VA = "0x1863A3660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct EOHLPFIAHFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public CIFHGJMONAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public IFCCNGGAOKK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public IFCCNGGAOKK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<EDGDDOJJJCK<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x63A25D0", Offset = "0x63A17D0", VA = "0x1863A25D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x63A2980", Offset = "0x63A1B80", VA = "0x1863A2980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct CGOFKIDKNAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<KJNLACHNNBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public CIFHGJMONAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IFCCNGGAOKK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public IFCCNGGAOKK pauseAfterListeningToken;

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
		private TaskAwaiter<KJNLACHNNBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x639C830", Offset = "0x639BA30", VA = "0x18639C830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x639D130", Offset = "0x639C330", VA = "0x18639D130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class FAGCOGBJJGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CIFHGJMONAD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public FAGCOGBJJGE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct ACIAIDHHHCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<KJNLACHNNBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public CIFHGJMONAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private FAGCOGBJJGE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public IFCCNGGAOKK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public IFCCNGGAOKK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private BENALPDHOED <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<KJNLACHNNBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x639B7E0", Offset = "0x639A9E0", VA = "0x18639B7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x639C2C0", Offset = "0x639B4C0", VA = "0x18639C2C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JDJEGIFDEME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<KJNLACHNNBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CIFHGJMONAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public IFCCNGGAOKK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public IFCCNGGAOKK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<KJNLACHNNBC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x63A5E60", Offset = "0x63A5060", VA = "0x1863A5E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x63A6240", Offset = "0x63A5440", VA = "0x1863A6240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class KODDPAOMNFA
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
			public KODDPAOMNFA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x63A82D0", Offset = "0x63A74D0", VA = "0x1863A82D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x63A8440", Offset = "0x63A7640", VA = "0x1863A8440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public KODDPAOMNFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x63A7160", Offset = "0x63A6360", VA = "0x1863A7160")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MNCLIBJECIG : IAsyncStateMachine
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
		public CIFHGJMONAD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public IFCCNGGAOKK unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public IFCCNGGAOKK pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x63A7950", Offset = "0x63A6B50", VA = "0x1863A7950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class APIDIPGMCPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public APIDIPGMCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x639C360", Offset = "0x639B560", VA = "0x18639C360")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x639C310", Offset = "0x639B510", VA = "0x18639C310")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HHAKAPHLKON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LFFOMMJHDDP sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public HHAKAPHLKON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63A5DC0", Offset = "0x63A4FC0", VA = "0x1863A5DC0")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LIPPPPDNMME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public LFFOMMJHDDP sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public LIPPPPDNMME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x63A78B0", Offset = "0x63A6AB0", VA = "0x1863A78B0")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JOJPENPCDIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public JOJPENPCDIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x63A6AF0", Offset = "0x63A5CF0", VA = "0x1863A6AF0")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FBFIFKGKOEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public FBFIFKGKOEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x63A2B40", Offset = "0x63A1D40", VA = "0x1863A2B40")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CKKBMIGDFJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public CKKBMIGDFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x63A1920", Offset = "0x63A0B20", VA = "0x1863A1920")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FODMAODHOBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public FODMAODHOBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x63A2C80", Offset = "0x63A1E80", VA = "0x1863A2C80")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DGLEFEEEJDA
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
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public DGLEFEEEJDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x63A1AB0", Offset = "0x63A0CB0", VA = "0x1863A1AB0")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x63A1A50", Offset = "0x63A0C50", VA = "0x1863A1A50")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class COKPMDEBHKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public COKPMDEBHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x63A19B0", Offset = "0x63A0BB0", VA = "0x1863A19B0")]
		internal bool <ClearSliceIds>b__3(NEIHDMJNDAO stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class NFKMIJBONAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NFKMIJBONAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x63A7DD0", Offset = "0x63A6FD0", VA = "0x1863A7DD0")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x63A8050", Offset = "0x63A7250", VA = "0x1863A8050")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x63A7D60", Offset = "0x63A6F60", VA = "0x1863A7D60")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly EDAFDCDNEOI APKOIHPLIAD;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable JGJDMEGAJOP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IDJBOINDOMB AINIEEGEACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly LAEPAIMHCBL FCNCDAFIFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OADCCNAMIBC JKJKDGCLGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly LGAKCPLHMFF NAPFCNHMCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly IIONDEIOMHI OCFMHHAKGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly EDAFDCDNEOI BBKCNNPEJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool CAPGEKKMIBE;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan KCAHFLAKNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan IDGNAEDAILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte ONELODAGIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] PLCGMANNNIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<NEIHDMJNDAO> CDOFNGAPFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private HFPKFPAPIPO? FKBIIODFEBJ;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly IDJBOINDOMB NFPPJLMPEMN;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly IDJBOINDOMB LEJKIGJFILE;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<KJNLACHNNBC> GJHDFPGPGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x639DE70", Offset = "0x639D070", VA = "0x18639DE70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x639DDB0", Offset = "0x639CFB0", VA = "0x18639DDB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x63A1470", Offset = "0x63A0670", VA = "0x1863A1470")]
	public CIFHGJMONAD(OADCCNAMIBC JKJKDGCLGGK, LGAKCPLHMFF NAPFCNHMCNC, IIONDEIOMHI OCFMHHAKGEI, [Optional] TimeSpan? GCJCEKKDKGJ, [Optional] EDAFDCDNEOI DGAFCGLGKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1154F80", Offset = "0x1154180", VA = "0x181154F80")]
	public static CIFHGJMONAD PBHNCBCIEKB<TNetworking>(TNetworking GCOGGHDIHNM, [Optional] TimeSpan? GCJCEKKDKGJ, [Optional] EDAFDCDNEOI DGAFCGLGKBK) where TNetworking : OADCCNAMIBC, LGAKCPLHMFF, IIONDEIOMHI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x639D180", Offset = "0x639C380", VA = "0x18639D180")]
	public void AFELIDKEEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x639DE60", Offset = "0x639D060", VA = "0x18639DE60")]
	private byte EDBDAEMIOCB()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x639F8C0", Offset = "0x639EAC0", VA = "0x18639F8C0")]
	private TimeSpan LJNHIIFAFHE(TimeSpan? GCJCEKKDKGJ, int COHBNIGJJKO = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1154700", Offset = "0x1153900", VA = "0x181154700")]
	public bool GLDHNLLBHIM<T>(T JHFLMJONPPF, Func<T, byte[]> CMCBBMOIFHP, bool EBHKCFMKLOC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x639E020", Offset = "0x639D220", VA = "0x18639E020")]
	public bool GLDHNLLBHIM(byte[] JHFLMJONPPF, int MGBFMLFNGEE, bool EBHKCFMKLOC = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85D960", Offset = "0x85CB60", VA = "0x18085D960")]
	private static string LNFOAGGDICI(string OFCFPGACNJB, string HMCAFGCGFJF = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x63A10B0", Offset = "0x63A02B0", VA = "0x1863A10B0")]
	[AsyncStateMachine(typeof(FOPCMOFFNAJ))]
	public Task<KJNLACHNNBC> PHBNPFGEIBM(CancellationToken NDKAKDJMDIF, [Optional] IFCCNGGAOKK IFADKJLNJBA, [Optional] IFCCNGGAOKK EFJAHGFOFPH, [Optional] TimeSpan? GCJCEKKDKGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x639E620", Offset = "0x639D820", VA = "0x18639E620")]
	[AsyncStateMachine(typeof(EOHLPFIAHFA))]
	public Task<Guid> GLOLADCCDEG(Guid GBFLINPNGMN, CancellationToken NDKAKDJMDIF, [Optional] IFCCNGGAOKK IFADKJLNJBA, [Optional] IFCCNGGAOKK EFJAHGFOFPH, [Optional] TimeSpan? JHHEDLPJBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1154C00", Offset = "0x1153E00", VA = "0x181154C00")]
	[AsyncStateMachine(typeof(DLIIGGGDCHM))]
	public Task<EDGDDOJJJCK<T>> NPPHLOGHDKI<T>(T JHFLMJONPPF, Func<T, byte[]> CMCBBMOIFHP, Func<byte[], T> AHAFOILAFPJ, CancellationToken NDKAKDJMDIF, [Optional] IFCCNGGAOKK IFADKJLNJBA, [Optional] IFCCNGGAOKK EFJAHGFOFPH, [Optional] TimeSpan? JHHEDLPJBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x63A0220", Offset = "0x639F420", VA = "0x1863A0220")]
	[AsyncStateMachine(typeof(CGOFKIDKNAF))]
	public Task<KJNLACHNNBC> NPPHLOGHDKI(byte[] JHFLMJONPPF, CancellationToken NDKAKDJMDIF, [Optional] IFCCNGGAOKK IFADKJLNJBA, [Optional] IFCCNGGAOKK EFJAHGFOFPH, [Optional] TimeSpan? JHHEDLPJBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x63A0B00", Offset = "0x639FD00", VA = "0x1863A0B00")]
	[AsyncStateMachine(typeof(ACIAIDHHHCJ))]
	private Task<KJNLACHNNBC> OIHAGLEPKNL(byte[] JHFLMJONPPF, CancellationToken NDKAKDJMDIF, IFCCNGGAOKK IFADKJLNJBA, IFCCNGGAOKK EFJAHGFOFPH, TimeSpan? GCJCEKKDKGJ, Stopwatch FOLNHBBIJKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x639EFD0", Offset = "0x639E1D0", VA = "0x18639EFD0")]
	[AsyncStateMachine(typeof(JDJEGIFDEME))]
	private Task<KJNLACHNNBC> JCAELBCBDJM(byte[] JHFLMJONPPF, CancellationToken NDKAKDJMDIF, [Optional] IFCCNGGAOKK IFADKJLNJBA, [Optional] IFCCNGGAOKK EFJAHGFOFPH, [Optional] TimeSpan? JHHEDLPJBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x639D270", Offset = "0x639C470", VA = "0x18639D270")]
	[AsyncStateMachine(typeof(MNCLIBJECIG))]
	public Task AMNAJOCNLIO(CancellationToken MFMBGLNBFDO, Func<CancellationToken, Task> BOAGONCOPPJ, [Optional] IFCCNGGAOKK IFADKJLNJBA, [Optional] IFCCNGGAOKK EFJAHGFOFPH, int PHKNFHFIJGP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1154250", Offset = "0x1153450", VA = "0x181154250")]
	[AsyncStateMachine(typeof(JKPJINJCAEM))]
	public Task<T> AMNAJOCNLIO<T>(CancellationToken MFMBGLNBFDO, Func<CancellationToken, Task<T>> BOAGONCOPPJ, [Optional] IFCCNGGAOKK IFADKJLNJBA, [Optional] IFCCNGGAOKK EFJAHGFOFPH, int PHKNFHFIJGP = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x11547B0", Offset = "0x11539B0", VA = "0x1811547B0")]
	[AsyncStateMachine(typeof(CDOLAKOEABD))]
	private Task<(bool, T)> ILNIBIKCKBD<T>(Guid IPNKAPKOHCI, CancellationToken MFMBGLNBFDO, Func<CancellationToken, Task<T>> BOAGONCOPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x639D3E0", Offset = "0x639C5E0", VA = "0x18639D3E0")]
	public void BMAIOBNEEHB(byte DFCHABKNANO, int PIHPHEMDPGD, object LBLGPPHFEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x639FFC0", Offset = "0x639F1C0", VA = "0x18639FFC0")]
	public Guid NPILDGJPBKI(Guid JOLBLOPJFEM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x639E860", Offset = "0x639DA60", VA = "0x18639E860")]
	public bool HBNEJCBOJGD(LFFOMMJHDDP HJMLNEHBNBE, Guid IPNKAPKOHCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x63A0CB0", Offset = "0x639FEB0", VA = "0x1863A0CB0")]
	public void ONKBKGOLNNJ(LFFOMMJHDDP HJMLNEHBNBE, Guid IPNKAPKOHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x639DE50", Offset = "0x639D050", VA = "0x18639DE50")]
	private void CMABOOMFIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x639F690", Offset = "0x639E890", VA = "0x18639F690")]
	internal HFPKFPAPIPO KLHNLAAEGFL(bool KAGIMFAPGOG = false)
	{
		return default(HFPKFPAPIPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x639EDE0", Offset = "0x639DFE0", VA = "0x18639EDE0")]
	private HashSet<Guid> HIMAIIMNPOJ(LFFOMMJHDDP HJMLNEHBNBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x639FDF0", Offset = "0x639EFF0", VA = "0x18639FDF0")]
	private void NLLBMOBAHPO(LFFOMMJHDDP HJMLNEHBNBE, Guid IKHNIJKGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x639FB00", Offset = "0x639ED00", VA = "0x18639FB00")]
	private void NHKOMLECOEH(LFFOMMJHDDP HJMLNEHBNBE, Guid IKHNIJKGJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x639E7B0", Offset = "0x639D9B0", VA = "0x18639E7B0")]
	public static Func<Guid, bool> GOCIAONDJIL(Guid IKHNIJKGJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x639EF20", Offset = "0x639E120", VA = "0x18639EF20")]
	public static Func<Guid, bool> INPBKODPGAA(Guid IKHNIJKGJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x639DF10", Offset = "0x639D110", VA = "0x18639DF10")]
	public void EPLIAPLAEHG(LFFOMMJHDDP HJMLNEHBNBE, Guid PGEONKOMPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x639F160", Offset = "0x639E360", VA = "0x18639F160")]
	public void JEJFOFCCBNF(LFFOMMJHDDP HJMLNEHBNBE, Func<Guid, bool> JFBOMJMBNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x639F7A0", Offset = "0x639E9A0", VA = "0x18639F7A0")]
	private static ExitGames.Client.Photon.Hashtable LFLGEFNEEKN(LFFOMMJHDDP HJMLNEHBNBE, Guid KPDAJEPPJON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x63A03B0", Offset = "0x639F5B0", VA = "0x1863A03B0")]
	private void OGJFMJPLMGA(LFFOMMJHDDP HJMLNEHBNBE, Guid KPDAJEPPJON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class NCFCOEPOKMM : KNNKGMJLOGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(HMIMBILJJGO.GDFIHGJKPGM itemType, long totalStopwatchTicks)> EGIBFLPOLKG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(HMIMBILJJGO.GDFIHGJKPGM itemType, long totalStopwatchTicks)> CEAPKDCHOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x82B680", Offset = "0x82A880", VA = "0x18082B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x63A7B90", Offset = "0x63A6D90", VA = "0x1863A7B90")]
	public NCFCOEPOKMM(TimeSpan JHHEDLPJBLL, List<(HMIMBILJJGO.GDFIHGJKPGM itemType, long totalStopwatchTicks)> EGIBFLPOLKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class EDHBADJBOLB : BENALPDHOED
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct DLMLOHBGJNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid ABLFMFHNJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int IFBGEFKMFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int DNOCMGGOLPJ;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x63A1F50", Offset = "0x63A1150", VA = "0x1863A1F50")]
		public DLMLOHBGJNK(Guid APMEBBJFJIJ, int DGJBJJNIGFN, int FOIKONIGGKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x63A1DF0", Offset = "0x63A0FF0", VA = "0x1863A1DF0")]
		public static byte[] IIADKJHBOIN(DLMLOHBGJNK OFCFPGACNJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x63A1C80", Offset = "0x63A0E80", VA = "0x1863A1C80")]
		public static DLMLOHBGJNK BBCFAILGGHN(byte[] ODBGNNDKAMK)
		{
			return default(DLMLOHBGJNK);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x63A1ED0", Offset = "0x63A10D0", VA = "0x1863A1ED0")]
		private static byte[] LFGMPPHODPH(int MLECAGAJCGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63A1D40", Offset = "0x63A0F40", VA = "0x1863A1D40")]
		private static int FPIANPMGCNE(byte[] CNNCOGAJIFO, int GMEHLIHLGEH)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid APMEBBJFJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CIFHGJMONAD FPOFHCENANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool GGGLLMJIICC;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63A2570", Offset = "0x63A1770", VA = "0x1863A2570")]
	public EDHBADJBOLB(Guid APMEBBJFJIJ, CIFHGJMONAD FPOFHCENANL, IIONDEIOMHI GCOGGHDIHNM, CancellationToken MFMBGLNBFDO, [Optional] DPMDGJGCGAO AOOAPKHKBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x63A2180", Offset = "0x63A1380", VA = "0x1863A2180", Slot = "5")]
	protected override void GFABPGMJEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x63A1FE0", Offset = "0x63A11E0", VA = "0x1863A1FE0", Slot = "6")]
	protected override void FOANMOFEDFA(int BDLGNBHJMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x63A2350", Offset = "0x63A1550", VA = "0x1863A2350")]
	private void GJHDFPGPGNG(KJNLACHNNBC MBBMLOFCBKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct KJNLACHNNBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly HFPKFPAPIPO FHACFIFHNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte GLGAJOJBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte PEJEGOEOAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool BFJOPDAHAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] BMMKHHAFPCC;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x63A7040", Offset = "0x63A6240", VA = "0x1863A7040")]
	public KJNLACHNNBC(HFPKFPAPIPO BAFBKHLJBGK, [CanBeNull] byte[] KHKGGNHOCOE, bool EBHKCFMKLOC, byte CPBMMCKLLKC, byte GHHHEADIENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x63A6EA0", Offset = "0x63A60A0", VA = "0x1863A6EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x63A6CB0", Offset = "0x63A5EB0", VA = "0x1863A6CB0")]
	private static void FMGPOPGMGIH(byte[] KHKGGNHOCOE, StringBuilder NOPIEJEEOPP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct HFPKFPAPIPO
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class HCPICBJCOHI : IEnumerable<NEIHDMJNDAO>, IEnumerable, IEnumerator<NEIHDMJNDAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private NEIHDMJNDAO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public HFPKFPAPIPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public HFPKFPAPIPO <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private LFFOMMJHDDP[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private NEIHDMJNDAO System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x21B0B70", Offset = "0x21AFD70", VA = "0x1821B0B70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NEIHDMJNDAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x63A4FB0", Offset = "0x63A41B0", VA = "0x1863A4FB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x1E99350", Offset = "0x1E98550", VA = "0x181E99350")]
		[DebuggerHidden]
		public HCPICBJCOHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x63A4CE0", Offset = "0x63A3EE0", VA = "0x1863A4CE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x63A4F70", Offset = "0x63A4170", VA = "0x1863A4F70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x63A4ED0", Offset = "0x63A40D0", VA = "0x1863A4ED0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NEIHDMJNDAO> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x63A4ED0", Offset = "0x63A40D0", VA = "0x1863A4ED0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly LFFOMMJHDDP IOKEKDPFIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] DADJBLDMDOF;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x63A54A0", Offset = "0x63A46A0", VA = "0x1863A54A0")]
	public static HFPKFPAPIPO MICAGPHBKCK(LFFOMMJHDDP HJMLNEHBNBE, Guid IOOECFNNOCH)
	{
		return default(HFPKFPAPIPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x63A5080", Offset = "0x63A4280", VA = "0x1863A5080")]
	public static HFPKFPAPIPO DDCGEPFPKGD(List<NEIHDMJNDAO> HFIIJJMJFJP)
	{
		return default(HFPKFPAPIPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x63A55A0", Offset = "0x63A47A0", VA = "0x1863A55A0")]
	public static HFPKFPAPIPO NAOEDDIGNHE(LFFOMMJHDDP DJHNCAFOCGA, Guid[] FHPNPBCJBKE)
	{
		return default(HFPKFPAPIPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x63A5B80", Offset = "0x63A4D80", VA = "0x1863A5B80")]
	private HFPKFPAPIPO(LFFOMMJHDDP DJHNCAFOCGA, Guid[] FHPNPBCJBKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x63A5000", Offset = "0x63A4200", VA = "0x1863A5000")]
	[IteratorStateMachine(typeof(HCPICBJCOHI))]
	public IEnumerable<NEIHDMJNDAO> CFCGIDHEOJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x63A5A00", Offset = "0x63A4C00", VA = "0x1863A5A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class FBPHFGEEIPK<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1B5D8E0", Offset = "0x1B5CAE0", VA = "0x181B5D8E0", Slot = "4")]
	public void NNLIBKFFFJN(T OFCFPGACNJB, IDictionary<object, object> PCPEJHIMHJJ, bool ENJLLCHIHBO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void BIFODNGCFFC(T OFCFPGACNJB, IDictionary<object, object> PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T BBCFAILGGHN(IDictionary<object, object> PCPEJHIMHJJ);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
	protected FBPHFGEEIPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BENALPDHOED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool DPMDGJGCGAO(int MIOEFAMNPMB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly IIONDEIOMHI LEPFKHILIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken MFMBGLNBFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken HALEHCEHIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly DPMDGJGCGAO AOOAPKHKBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource ECDKFGFBOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource INDICOGGFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int FMBNHHIOPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool NKKALFPHEFO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken OIEMPLEPFKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x639C610", Offset = "0x639B810", VA = "0x18639C610")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool NANALKCODCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x639C630", Offset = "0x639B830", VA = "0x18639C630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x639C680", Offset = "0x639B880", VA = "0x18639C680")]
	public BENALPDHOED(IIONDEIOMHI GCOGGHDIHNM, CancellationToken MFMBGLNBFDO, [Optional] DPMDGJGCGAO AOOAPKHKBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x639C500", Offset = "0x639B700", VA = "0x18639C500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x639C540", Offset = "0x639B740", VA = "0x18639C540", Slot = "5")]
	protected virtual void GFABPGMJEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x639C400", Offset = "0x639B600", VA = "0x18639C400")]
	private void AMDDEJFGDBC(JDCIJIEOFOL GKNDJIKLPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x639C4A0", Offset = "0x639B6A0", VA = "0x18639C4A0")]
	protected void CCPCCKIGCMB(int BDLGNBHJMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x639C520", Offset = "0x639B720", VA = "0x18639C520", Slot = "6")]
	protected virtual void FOANMOFEDFA(int BDLGNBHJMNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct NEIHDMJNDAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly LFFOMMJHDDP KEGBECDPJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid OCAPGMIBFDM;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x2E589C0", Offset = "0x2E57BC0", VA = "0x182E589C0")]
	public NEIHDMJNDAO(LFFOMMJHDDP HJMLNEHBNBE, Guid IPNKAPKOHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x63A7D00", Offset = "0x63A6F00", VA = "0x1863A7D00")]
	public bool OFPEIHMPLIL(NEIHDMJNDAO HNPEBINPOBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x63A7C10", Offset = "0x63A6E10", VA = "0x1863A7C10", Slot = "0")]
	public override bool Equals(object ICHBECDKHOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x63A7CD0", Offset = "0x63A6ED0", VA = "0x1863A7CD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum LFFOMMJHDDP : byte
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
internal static class KFOPAOGECBK
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly LFFOMMJHDDP[] PIMDMDCCAON;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x63A6B60", Offset = "0x63A5D60", VA = "0x1863A6B60")]
	public static int CLODPIINFNB(LFFOMMJHDDP HJMLNEHBNBE)
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
