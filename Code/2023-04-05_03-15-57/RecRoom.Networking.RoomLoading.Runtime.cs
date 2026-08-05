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
internal class JKILKNIKCGO : global::GMLHPAHEHLN<PJCGIDNCOGN>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class PPKLLJKNFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IDictionary<object, object> data;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public PPKLLJKNFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62E04F0", Offset = "0x62DF4F0", VA = "0x1862E04F0")]
		internal object <Deserialize>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal static readonly string[] PLNNDFOOKAM;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly JKILKNIKCGO FDNKALDKIIB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x62DDA20", Offset = "0x62DCA20", VA = "0x1862DDA20", Slot = "5")]
	protected override void EFDJJBMEFLJ(PJCGIDNCOGN GOMILMNIGIC, IDictionary<object, object> FNIHENPLJHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x62DDE90", Offset = "0x62DCE90", VA = "0x1862DDE90", Slot = "6")]
	public override PJCGIDNCOGN EOLLHEJPBAN(IDictionary<object, object> FNIHENPLJHK)
	{
		return default(PJCGIDNCOGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x62DEC30", Offset = "0x62DDC30", VA = "0x1862DEC30")]
	public JKILKNIKCGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class GKOLCONDKGI
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate string KKNBPFLCGDL([NotNull] byte[] OBBOCNIOLOI);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public readonly struct GOPHJMMNFAH<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly AHOMOGJCLBL CEAFDINBPHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly bool PAMGKPLMJGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly T NDPPPPIFPGJ;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2EDDAD0", Offset = "0x2EDCAD0", VA = "0x182EDDAD0")]
		public static GOPHJMMNFAH<T> GIANPFCJNJK(PJCGIDNCOGN IGDHMDELDAF, Func<byte[], T> IJDBELIHGMK)
		{
			return default(GOPHJMMNFAH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2EDDD30", Offset = "0x2EDCD30", VA = "0x182EDDD30")]
		public GOPHJMMNFAH(AHOMOGJCLBL OFGNEKKNGAH, T OBBOCNIOLOI, bool NCGFNCDAHGG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2EDDC50", Offset = "0x2EDCC50", VA = "0x182EDDC50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JEEGDDOEEPN : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ALCAHGCMMBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public TaskCompletionSource<PJCGIDNCOGN> newMessageTaskCompletionSource;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public JEEGDDOEEPN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public ALCAHGCMMBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x62D4880", Offset = "0x62D3880", VA = "0x1862D4880")]
			internal void <AwaitNextMessage>b__0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x62D48D0", Offset = "0x62D38D0", VA = "0x1862D48D0")]
			internal GDJAINNMDJM <AwaitNextMessage>b__4(TimeSpan ts)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class IJFOONGPLJF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public MBAMKFGIACI.FPPPOLBMDJC itemType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public long totalStopwatchTicks;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public IJFOONGPLJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x62DC9A0", Offset = "0x62DB9A0", VA = "0x1862DC9A0")]
			internal object <AwaitNextMessage>b__3()
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct HMDDLNAECKN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<PJCGIDNCOGN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public JEEGDDOEEPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private ALCAHGCMMBC <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<PJCGIDNCOGN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x62DB030", Offset = "0x62DA030", VA = "0x1862DB030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x62DB840", Offset = "0x62DA840", VA = "0x1862DB840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class LBLDHIHHDNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public MKDGNKFCJHE sliceType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public Guid id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int sliceTypeIndex;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public LBLDHIHHDNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x62DECE0", Offset = "0x62DDCE0", VA = "0x1862DECE0")]
			internal bool <ClearSlice>b__0(PJCGIDNCOGN bufMsg)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly IHDFDMGGMJE FDDPLOBEGML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly string EHJJHKOGKJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly List<PJCGIDNCOGN> FMCBGJDCALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<(MBAMKFGIACI.FPPPOLBMDJC itemType, long totalStopwatchTicks)> EFHNOLADKLK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool EMMAEMBEDAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x62DD780", Offset = "0x62DC780", VA = "0x1862DD780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		private event Action<PJCGIDNCOGN> KEALCPBDBPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x62DD410", Offset = "0x62DC410", VA = "0x1862DD410")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x62DD5B0", Offset = "0x62DC5B0", VA = "0x1862DD5B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x62DD920", Offset = "0x62DC920", VA = "0x1862DD920")]
		public JEEGDDOEEPN(IHDFDMGGMJE FDDPLOBEGML, string EHJJHKOGKJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62DD7D0", Offset = "0x62DC7D0", VA = "0x1862DD7D0")]
		[AsyncStateMachine(typeof(HMDDLNAECKN))]
		public Task<PJCGIDNCOGN> PPGBONJIDDE(CancellationToken ANIIOKLMHLI, TimeSpan FAMGKJPNCKD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x62DD500", Offset = "0x62DC500", VA = "0x1862DD500")]
		public void FILGFNMNDKI(PJCGIDNCOGN GOMILMNIGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x62DD4B0", Offset = "0x62DC4B0", VA = "0x1862DD4B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x62DD650", Offset = "0x62DC650", VA = "0x1862DD650")]
		public void NCACPBODKLC(MKDGNKFCJHE NPJOFFBOLPN, Guid CLOAPFCHKDE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JDLHLDALCOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<PJCGIDNCOGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JCFIPKDIHDN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public GKOLCONDKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public JCFIPKDIHDN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<PJCGIDNCOGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x62DCA70", Offset = "0x62DBA70", VA = "0x1862DCA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x62DD3C0", Offset = "0x62DC3C0", VA = "0x1862DD3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct OLJLPGHEAPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder<Guid> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public GKOLCONDKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid proposedGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public JCFIPKDIHDN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public JCFIPKDIHDN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<GOPHJMMNFAH<Guid>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x62DFC80", Offset = "0x62DEC80", VA = "0x1862DFC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x62E0030", Offset = "0x62DF030", VA = "0x1862E0030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HFMEAGMAONL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AsyncTaskMethodBuilder<PJCGIDNCOGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public GKOLCONDKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public JCFIPKDIHDN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JCFIPKDIHDN pauseAfterListeningToken;

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
		private TaskAwaiter<PJCGIDNCOGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x62DA6E0", Offset = "0x62D96E0", VA = "0x1862DA6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x62DAFE0", Offset = "0x62D9FE0", VA = "0x1862DAFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class BBGMIENKMDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public GKOLCONDKGI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public BBGMIENKMDH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HPOBNGONFAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<PJCGIDNCOGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public GKOLCONDKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public TimeSpan? timeoutOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private BBGMIENKMDH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public JCFIPKDIHDN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JCFIPKDIHDN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Stopwatch elapsedStopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <attempts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private NEBPKBIECEH <masterSwitchScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private TaskAwaiter<PJCGIDNCOGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x62DBE00", Offset = "0x62DAE00", VA = "0x1862DBE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x62DC8E0", Offset = "0x62DB8E0", VA = "0x1862DC8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct FIKIGPFJDBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public AsyncTaskMethodBuilder<PJCGIDNCOGN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public GKOLCONDKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public byte[] messageToSend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public JCFIPKDIHDN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public JCFIPKDIHDN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TimeSpan? timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private TaskAwaiter<PJCGIDNCOGN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62D5A00", Offset = "0x62D4A00", VA = "0x1862D5A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x62D5DE0", Offset = "0x62D4DE0", VA = "0x1862D5DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class DIPKMOKNBPD
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
			public DIPKMOKNBPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x62E05B0", Offset = "0x62DF5B0", VA = "0x1862E05B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x62E0720", Offset = "0x62DF720", VA = "0x1862E0720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public DIPKMOKNBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x62D56E0", Offset = "0x62D46E0", VA = "0x1862D56E0")]
		[AsyncStateMachine(typeof(<<MasterLockedBlock>b__0>d))]
		internal Task<bool> <MasterLockedBlock>b__0(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct NBACIBHAMLH : IAsyncStateMachine
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
		public GKOLCONDKGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public JCFIPKDIHDN unpauseForListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JCFIPKDIHDN pauseAfterListeningToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62DF360", Offset = "0x62DE360", VA = "0x1862DF360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LDKFIPMBPHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public object customDataObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDictionary<object, object> eventData;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public LDKFIPMBPHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62DEEA0", Offset = "0x62DDEA0", VA = "0x1862DEEA0")]
		internal object <OnEvent>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x62DEE50", Offset = "0x62DDE50", VA = "0x1862DEE50")]
		internal object <OnEvent>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class LLJFMKKGABE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public MKDGNKFCJHE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public LLJFMKKGABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x62DEF40", Offset = "0x62DDF40", VA = "0x1862DEF40")]
		internal object <StartSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class MCNMCPOENOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public MKDGNKFCJHE sliceType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public MCNMCPOENOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x62DF2C0", Offset = "0x62DE2C0", VA = "0x1862DF2C0")]
		internal object <StopSliceLocal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class ICLPDAOEDBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public ICLPDAOEDBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x62DC930", Offset = "0x62DB930", VA = "0x1862DC930")]
		internal object <MarkSliceIdKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class KKKGMALBPEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public KKKGMALBPEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x62DEC70", Offset = "0x62DDC70", VA = "0x1862DEC70")]
		internal object <MarkSliceIdNotKnown>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class EAFLHDMLNDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public EAFLHDMLNDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x62D5820", Offset = "0x62D4820", VA = "0x1862D5820")]
		internal bool <DoesNotMatch>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FOGDJGHLNFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public Guid id;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public FOGDJGHLNFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62D5E30", Offset = "0x62D4E30", VA = "0x1862D5E30")]
		internal bool <Matches>b__0(Guid pid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class NFMHIMHJFAJ
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
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public NFMHIMHJFAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x62DFB80", Offset = "0x62DEB80", VA = "0x1862DFB80")]
		internal bool <ClearSliceIds>b__2(Guid id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62DFB20", Offset = "0x62DEB20", VA = "0x1862DFB20")]
		internal bool <ClearSliceIds>b__1(Guid id)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NJFPNIMFLIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public NJFPNIMFLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x62DFBE0", Offset = "0x62DEBE0", VA = "0x1862DFBE0")]
		internal bool <ClearSliceIds>b__3(ECMLFDGBKFL stackSlice)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HNEPJPFAGKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Guid sliceToRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public ExitGames.Client.Photon.Hashtable bufferClearContent;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public HNEPJPFAGKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62DB900", Offset = "0x62DA900", VA = "0x1862DB900")]
		internal object <ClearSliceInternal>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62DBB80", Offset = "0x62DAB80", VA = "0x1862DBB80")]
		internal object <ClearSliceInternal>b__2()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62DB890", Offset = "0x62DA890", VA = "0x1862DB890")]
		internal object <ClearSliceInternal>b__0()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public static readonly KKNBPFLCGDL AOKDHAPGKBC;

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ExitGames.Client.Photon.Hashtable PBMBEFFGHFP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly GHKEPKNDEOC NPELEEDPGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly JEEGDDOEEPN AIAFDHIAJOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly IHDFDMGGMJE FDDPLOBEGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly IGIAPMPCPIJ ICAGNOBALAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly CPGAEBEDAOI GEEJMCNJJJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly KKNBPFLCGDL BNKKFBPMPHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool LJINJAFAKDG;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly TimeSpan GBDBDLHFIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly TimeSpan LLFGMILDMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private byte OGICMMNLDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly HashSet<Guid>[] OFEJLNFKBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<ECMLFDGBKFL> CCMFLHBBALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private AHOMOGJCLBL? BENKCCJPMPK;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly GHKEPKNDEOC KFNDGFECNII;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly GHKEPKNDEOC JMKADFELOBO;

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	internal event Action<PJCGIDNCOGN> MHCGFBJJPFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x62D6AD0", Offset = "0x62D5AD0", VA = "0x1862D6AD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62D6FF0", Offset = "0x62D5FF0", VA = "0x1862D6FF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x62DA230", Offset = "0x62D9230", VA = "0x1862DA230")]
	public GKOLCONDKGI(IHDFDMGGMJE FDDPLOBEGML, IGIAPMPCPIJ ICAGNOBALAM, CPGAEBEDAOI GEEJMCNJJJF, [Optional] TimeSpan? BMKIMCLNFHE, [Optional] KKNBPFLCGDL HFMAJKPBBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2326F00", Offset = "0x2325F00", VA = "0x182326F00")]
	public static GKOLCONDKGI JICAHPEGDNC<TNetworking>(TNetworking COOCGBJBNBF, [Optional] TimeSpan? BMKIMCLNFHE, [Optional] KKNBPFLCGDL HFMAJKPBBOM) where TNetworking : IHDFDMGGMJE, IGIAPMPCPIJ, CPGAEBEDAOI
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x62D8740", Offset = "0x62D7740", VA = "0x1862D8740")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x62D9A00", Offset = "0x62D8A00", VA = "0x1862D9A00")]
	private byte PDKFABJBLFN()
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x62D7090", Offset = "0x62D6090", VA = "0x1862D7090")]
	private TimeSpan GAMKPNCPIHM(TimeSpan? BMKIMCLNFHE, int PMICEACFIEP = 1)
	{
		return default(TimeSpan);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2327320", Offset = "0x2326320", VA = "0x182327320")]
	public bool LJJEPDBBLDB<T>(T KFEHEJKLOIJ, Func<T, byte[]> NLIHAKMICKJ, bool NCGFNCDAHGG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x62D8EF0", Offset = "0x62D7EF0", VA = "0x1862D8EF0")]
	public bool LJJEPDBBLDB(byte[] KFEHEJKLOIJ, int BGHDPAEAGFN, bool NCGFNCDAHGG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7FDE20", Offset = "0x7FCE20", VA = "0x1807FDE20")]
	private static string NMFCJMGECAA(string GOMILMNIGIC, string LDFNLMPJEDN = "yellow")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x62D5F40", Offset = "0x62D4F40", VA = "0x1862D5F40")]
	[AsyncStateMachine(typeof(JDLHLDALCOA))]
	public Task<PJCGIDNCOGN> AGDDBGICCHD(CancellationToken ANIIOKLMHLI, [Optional] JCFIPKDIHDN FJNPBJPMFLG, [Optional] JCFIPKDIHDN EEOOKMPEFFJ, [Optional] TimeSpan? BMKIMCLNFHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x62D7BE0", Offset = "0x62D6BE0", VA = "0x1862D7BE0")]
	[AsyncStateMachine(typeof(OLJLPGHEAPD))]
	public Task<Guid> JGKGPPOENHL(Guid ADIAHDAJMDK, CancellationToken ANIIOKLMHLI, [Optional] JCFIPKDIHDN FJNPBJPMFLG, [Optional] JCFIPKDIHDN EEOOKMPEFFJ, [Optional] TimeSpan? FAMGKJPNCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2326FA0", Offset = "0x2325FA0", VA = "0x182326FA0")]
	[AsyncStateMachine(typeof(KBGINOOMAGA))]
	public Task<GOPHJMMNFAH<T>> LDGKMNPGPJC<T>(T KFEHEJKLOIJ, Func<T, byte[]> NLIHAKMICKJ, Func<byte[], T> IJDBELIHGMK, CancellationToken ANIIOKLMHLI, [Optional] JCFIPKDIHDN FJNPBJPMFLG, [Optional] JCFIPKDIHDN EEOOKMPEFFJ, [Optional] TimeSpan? FAMGKJPNCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x62D8B00", Offset = "0x62D7B00", VA = "0x1862D8B00")]
	[AsyncStateMachine(typeof(HFMEAGMAONL))]
	public Task<PJCGIDNCOGN> LDGKMNPGPJC(byte[] KFEHEJKLOIJ, CancellationToken ANIIOKLMHLI, [Optional] JCFIPKDIHDN FJNPBJPMFLG, [Optional] JCFIPKDIHDN EEOOKMPEFFJ, [Optional] TimeSpan? FAMGKJPNCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x62D8830", Offset = "0x62D7830", VA = "0x1862D8830")]
	[AsyncStateMachine(typeof(HPOBNGONFAF))]
	private Task<PJCGIDNCOGN> KOEDBHLEKEN(byte[] KFEHEJKLOIJ, CancellationToken ANIIOKLMHLI, JCFIPKDIHDN FJNPBJPMFLG, JCFIPKDIHDN EEOOKMPEFFJ, TimeSpan? BMKIMCLNFHE, Stopwatch GIABGFLKIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62D6B70", Offset = "0x62D5B70", VA = "0x1862D6B70")]
	[AsyncStateMachine(typeof(FIKIGPFJDBM))]
	private Task<PJCGIDNCOGN> FCPNOCDEJIA(byte[] KFEHEJKLOIJ, CancellationToken ANIIOKLMHLI, [Optional] JCFIPKDIHDN FJNPBJPMFLG, [Optional] JCFIPKDIHDN EEOOKMPEFFJ, [Optional] TimeSpan? FAMGKJPNCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x62D60C0", Offset = "0x62D50C0", VA = "0x1862D60C0")]
	[AsyncStateMachine(typeof(NBACIBHAMLH))]
	public Task BAFOLBGFOIP(CancellationToken IBHNKIMJDFD, Func<CancellationToken, Task> PHDCHONOFBG, [Optional] JCFIPKDIHDN FJNPBJPMFLG, [Optional] JCFIPKDIHDN EEOOKMPEFFJ, int GMFLDEFAHGD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2326600", Offset = "0x2325600", VA = "0x182326600")]
	[AsyncStateMachine(typeof(EJFMJHIIONK))]
	public Task<T> BAFOLBGFOIP<T>(CancellationToken IBHNKIMJDFD, Func<CancellationToken, Task<T>> PHDCHONOFBG, [Optional] JCFIPKDIHDN FJNPBJPMFLG, [Optional] JCFIPKDIHDN EEOOKMPEFFJ, int GMFLDEFAHGD = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2326AB0", Offset = "0x2325AB0", VA = "0x182326AB0")]
	[AsyncStateMachine(typeof(MBHDKJCMOHJ))]
	private Task<(bool, T)> CFJDPOFBAAB<T>(Guid PMAFNODLPFF, CancellationToken IBHNKIMJDFD, Func<CancellationToken, Task<T>> PHDCHONOFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x62D7D70", Offset = "0x62D6D70", VA = "0x1862D7D70")]
	public void JKFCEEFFEDD(byte FNPPMGEGKBM, int BEBIFELFGPB, object GJGEEADHGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x62D8C90", Offset = "0x62D7C90", VA = "0x1862D8C90")]
	public Guid LDMAPCIGKKL(Guid EGLJHLFGOPD)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x62D74A0", Offset = "0x62D64A0", VA = "0x1862D74A0")]
	public bool HLPJPPMLPHF(MKDGNKFCJHE NPJOFFBOLPN, Guid PMAFNODLPFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x62D9600", Offset = "0x62D8600", VA = "0x1862D9600")]
	public void NNEBKPPFMGF(MKDGNKFCJHE NPJOFFBOLPN, Guid PMAFNODLPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x62D6AC0", Offset = "0x62D5AC0", VA = "0x1862D6AC0")]
	private void ELEOELJDFDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x62D7AD0", Offset = "0x62D6AD0", VA = "0x1862D7AD0")]
	internal AHOMOGJCLBL IKMFLHMHNKC(bool HKODCGIPGAN = false)
	{
		return default(AHOMOGJCLBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x62D6980", Offset = "0x62D5980", VA = "0x1862D6980")]
	private HashSet<Guid> CPNHGNDLIFO(MKDGNKFCJHE NPJOFFBOLPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x62D72D0", Offset = "0x62D62D0", VA = "0x1862D72D0")]
	private void GEPJHOBGFEI(MKDGNKFCJHE NPJOFFBOLPN, Guid CLOAPFCHKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x62D6D00", Offset = "0x62D5D00", VA = "0x1862D6D00")]
	private void FNOAFFOHOGC(MKDGNKFCJHE NPJOFFBOLPN, Guid CLOAPFCHKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x62D9A10", Offset = "0x62D8A10", VA = "0x1862D9A10")]
	public static Func<Guid, bool> PGOOGIOPIDH(Guid CLOAPFCHKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x62D7A20", Offset = "0x62D6A20", VA = "0x1862D7A20")]
	public static Func<Guid, bool> HOCIKADFMCP(Guid CLOAPFCHKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x62D94F0", Offset = "0x62D84F0", VA = "0x1862D94F0")]
	public void NCACPBODKLC(MKDGNKFCJHE NPJOFFBOLPN, Guid ELLKBPHIOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x62D9AC0", Offset = "0x62D8AC0", VA = "0x1862D9AC0")]
	public void PPNKEGEPOEM(MKDGNKFCJHE NPJOFFBOLPN, Func<Guid, bool> BFDIHJOBMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x62D89E0", Offset = "0x62D79E0", VA = "0x1862D89E0")]
	private static ExitGames.Client.Photon.Hashtable LBDPDPDBGGE(MKDGNKFCJHE NPJOFFBOLPN, Guid EPGCGCLDMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x62D6230", Offset = "0x62D5230", VA = "0x1862D6230")]
	private void CEGOHPMABIP(MKDGNKFCJHE NPJOFFBOLPN, Guid EPGCGCLDMCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class GDJAINNMDJM : IIBFAPEOHPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private List<(MBAMKFGIACI.FPPPOLBMDJC itemType, long totalStopwatchTicks)> IALDGKPNFEB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IReadOnlyList<(MBAMKFGIACI.FPPPOLBMDJC itemType, long totalStopwatchTicks)> BCNABOGDGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E20", Offset = "0x6E4E20", VA = "0x1806E5E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x62D5EC0", Offset = "0x62D4EC0", VA = "0x1862D5EC0")]
	public GDJAINNMDJM(TimeSpan FAMGKJPNCKD, List<(MBAMKFGIACI.FPPPOLBMDJC itemType, long totalStopwatchTicks)> IALDGKPNFEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BLHEFEIOPJD : NEBPKBIECEH
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct MBGKKJHOINN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public readonly Guid HPHNBLCAAPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly int EGDGMGNONJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly int DMIFOMDPLIK;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x62DF2B0", Offset = "0x62DE2B0", VA = "0x1862DF2B0")]
		public MBGKKJHOINN(Guid OCEDKFHDABH, int OFFGHIGIHEL, int OGJJDONEIKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x62DF060", Offset = "0x62DE060", VA = "0x1862DF060")]
		public static byte[] CJKIIDNIDDE(MBGKKJHOINN GOMILMNIGIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x62DF140", Offset = "0x62DE140", VA = "0x1862DF140")]
		public static MBGKKJHOINN EOLLHEJPBAN(byte[] FHNEBAPANCE)
		{
			return default(MBGKKJHOINN);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62DEFE0", Offset = "0x62DDFE0", VA = "0x1862DEFE0")]
		private static byte[] AFGOJNKAEHD(int BDAADCOCKII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62DF200", Offset = "0x62DE200", VA = "0x1862DF200")]
		private static int KDDEKMCKIAA(byte[] ILKNGBFCLDM, int EGBCAPEEJBF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly Guid OCEDKFHDABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly GKOLCONDKGI GIHOOMJMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private bool JNLPCMEKLJD;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x62D5360", Offset = "0x62D4360", VA = "0x1862D5360")]
	public BLHEFEIOPJD(Guid OCEDKFHDABH, GKOLCONDKGI GIHOOMJMFDE, CPGAEBEDAOI COOCGBJBNBF, CancellationToken IBHNKIMJDFD, [Optional] PHMBBLMBBIH GAGONMLIKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x62D4DD0", Offset = "0x62D3DD0", VA = "0x1862D4DD0", Slot = "5")]
	protected override void KFIBDMFMDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x62D4FA0", Offset = "0x62D3FA0", VA = "0x1862D4FA0", Slot = "6")]
	protected override void KMIJJNEKINH(int JIFGKAMNBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62D5140", Offset = "0x62D4140", VA = "0x1862D5140")]
	private void MHCGFBJJPFF(PJCGIDNCOGN DAPOIFOFGJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct PJCGIDNCOGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public readonly AHOMOGJCLBL CEAFDINBPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public readonly byte PHMFPCHIKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public readonly byte IHPKCNAEFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public readonly bool PAMGKPLMJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public readonly byte[] NDPPPPIFPGJ;

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x62E0490", Offset = "0x62DF490", VA = "0x1862E0490")]
	public PJCGIDNCOGN(AHOMOGJCLBL OFGNEKKNGAH, [CanBeNull] byte[] OBBOCNIOLOI, bool NCGFNCDAHGG, byte AKIIHOLIKCP, byte EHKEMFFJKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x62E02F0", Offset = "0x62DF2F0", VA = "0x1862E02F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x62E0100", Offset = "0x62DF100", VA = "0x1862E0100")]
	private static void IPFFHHHNMCJ(byte[] OBBOCNIOLOI, StringBuilder IJHIBJKGICN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct AHOMOGJCLBL
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BNGJONFCEKL : IEnumerable<ECMLFDGBKFL>, IEnumerable, IEnumerator<ECMLFDGBKFL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private ECMLFDGBKFL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AHOMOGJCLBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AHOMOGJCLBL <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private MKDGNKFCJHE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private ECMLFDGBKFL System.Collections.Generic.IEnumerator<RecRoom.Networking.Events.Slice>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x3031290", Offset = "0x3030290", VA = "0x183031290", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(ECMLFDGBKFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x62D5690", Offset = "0x62D4690", VA = "0x1862D5690", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x986E80", Offset = "0x985E80", VA = "0x180986E80")]
		[DebuggerHidden]
		public BNGJONFCEKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x62D53C0", Offset = "0x62D43C0", VA = "0x1862D53C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62D5650", Offset = "0x62D4650", VA = "0x1862D5650", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x62D55B0", Offset = "0x62D45B0", VA = "0x1862D55B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ECMLFDGBKFL> System.Collections.Generic.IEnumerable<RecRoom.Networking.Events.Slice>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x62D55B0", Offset = "0x62D45B0", VA = "0x1862D55B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public readonly MKDGNKFCJHE MDLCFNHOEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public readonly Guid[] FJNLEMPENHO;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x62D3FA0", Offset = "0x62D2FA0", VA = "0x1862D3FA0")]
	public static AHOMOGJCLBL KEKBKKGJNDE(MKDGNKFCJHE NPJOFFBOLPN, Guid HGCIAEONMFF)
	{
		return default(AHOMOGJCLBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x62D40A0", Offset = "0x62D30A0", VA = "0x1862D40A0")]
	public static AHOMOGJCLBL LHDBNGGFDNP(List<ECMLFDGBKFL> IAEIAFHKINL)
	{
		return default(AHOMOGJCLBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x62D3AC0", Offset = "0x62D2AC0", VA = "0x1862D3AC0")]
	public static AHOMOGJCLBL BAKCAOPKNDD(MKDGNKFCJHE BHOOIMFMKAF, Guid[] JJCPFPGOPEI)
	{
		return default(AHOMOGJCLBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x62D4640", Offset = "0x62D3640", VA = "0x1862D4640")]
	private AHOMOGJCLBL(MKDGNKFCJHE BHOOIMFMKAF, Guid[] JJCPFPGOPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x62D3F20", Offset = "0x62D2F20", VA = "0x1862D3F20")]
	[IteratorStateMachine(typeof(BNGJONFCEKL))]
	public IEnumerable<ECMLFDGBKFL> HOBHEAKIDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x62D44C0", Offset = "0x62D34C0", VA = "0x1862D44C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class GMLHPAHEHLN<T>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3ABEB60", Offset = "0x3ABDB60", VA = "0x183ABEB60", Slot = "4")]
	public void MNEIPMKACNH(T GOMILMNIGIC, IDictionary<object, object> FNIHENPLJHK, bool HEDNGCCEAKO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void EFDJJBMEFLJ(T GOMILMNIGIC, IDictionary<object, object> FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract T EOLLHEJPBAN(IDictionary<object, object> FNIHENPLJHK);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
	protected GMLHPAHEHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NEBPKBIECEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate bool PHMBBLMBBIH(int BAGAFJILJLE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool FLFCLOAFFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	protected readonly CPGAEBEDAOI LLDNGHGBEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CancellationToken IBHNKIMJDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly CancellationToken GGLIFKBOFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly PHMBBLMBBIH GAGONMLIKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CancellationTokenSource AKMHNHJPIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly CancellationTokenSource AHDOPPJEGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly int CIPKEPGCIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool DNHHMIHMHOK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CancellationToken IDMPDDDOHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x62DF5A0", Offset = "0x62DE5A0", VA = "0x1862DF5A0")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool ENAEEDACEDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x62DF7D0", Offset = "0x62DE7D0", VA = "0x1862DF7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x62DF820", Offset = "0x62DE820", VA = "0x1862DF820")]
	public NEBPKBIECEH(CPGAEBEDAOI COOCGBJBNBF, CancellationToken IBHNKIMJDFD, [Optional] PHMBBLMBBIH GAGONMLIKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x62DF5C0", Offset = "0x62DE5C0", VA = "0x1862DF5C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x62DF6E0", Offset = "0x62DE6E0", VA = "0x1862DF6E0", Slot = "5")]
	protected virtual void KFIBDMFMDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x62DF640", Offset = "0x62DE640", VA = "0x1862DF640")]
	private void GGKLKIFGGCP(HHHLLJHNCOK NMJDPNBNEFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x62DF5E0", Offset = "0x62DE5E0", VA = "0x1862DF5E0")]
	protected void FCGFHAOPHPK(int JIFGKAMNBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x62DF7B0", Offset = "0x62DE7B0", VA = "0x1862DF7B0", Slot = "6")]
	protected virtual void KMIJJNEKINH(int JIFGKAMNBLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct ECMLFDGBKFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public readonly MKDGNKFCJHE JNLDACGLLLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public readonly Guid HADCOCFAGGI;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x32E3D60", Offset = "0x32E2D60", VA = "0x1832E3D60")]
	public ECMLFDGBKFL(MKDGNKFCJHE NPJOFFBOLPN, Guid PMAFNODLPFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x62D59A0", Offset = "0x62D49A0", VA = "0x1862D59A0")]
	public bool OGHMKNDIAJH(ECMLFDGBKFL JHMCLPBFJBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x62D58B0", Offset = "0x62D48B0", VA = "0x1862D58B0", Slot = "0")]
	public override bool Equals(object AELIHOPICED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x62D5970", Offset = "0x62D4970", VA = "0x1862D5970", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[Flags]
public enum MKDGNKFCJHE : byte
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
internal static class NEJCBMMBFEI
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal static readonly MKDGNKFCJHE[] PBKFDHMKGEI;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x62DF9D0", Offset = "0x62DE9D0", VA = "0x1862DF9D0")]
	public static int OHDNBADKLAE(MKDGNKFCJHE NPJOFFBOLPN)
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
